using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket12306Demo.Service
{
	using System.Text.RegularExpressions;
	using FSLib.Network.Http;
	using Ticket12306Demo.Service.Entities;
	using Ticket12306Demo.Service.Entities.Web;

	/// <summary>
	/// 车票查询服务
	/// </summary>
	class TicketQueryService : ServiceBase
	{
		public TicketQueryService(ServiceContext context) : base(context)
		{
		}

		string _queryUrl;
		bool _saveQueryLog;

		async Task LoadInitPage()
		{
			var client = ServiceContext.Session.NetClient;

			var ctx = client.Create<string>(HttpMethod.Get, "https://kyfw.12306.cn/otn/leftTicket/init");
			await ctx.SendTask();

			if (!ctx.IsValid())
			{
				//失败了，没有能获得地址
				return;
			}

			//获得到了查票页HTML，分析参数
			var matches = Regex.Matches(ctx.Result, @"var\s*(CLeftTicketUrl|isSaveQueryLog)\s*=\s*['""]([^'""]+)['""];");
			foreach (Match match in matches)
			{
				switch (match.GetGroupValue(1))
				{
					case "CLeftTicketUrl":
						_queryUrl = match.GetGroupValue(2);
						break;
					case "isSaveQueryLog":
						_saveQueryLog = match.GetGroupValue(2) == "Y";
						break;
				}
			}
		}


		/// <summary>
		/// 查票
		/// </summary>
		/// <param name="date">出发日期</param>
		/// <param name="fromName">发站名</param>
		/// <param name="fromCode">发站电报码</param>
		/// <param name="toName">到站名</param>
		/// <param name="toCode">到站电报码</param>
		/// <param name="isStudent">是否是学生票</param>
		/// <returns></returns>
		public async Task<TicketQueryResult> QueryTicket(DateTime date, string fromName, string fromCode, string toName, string toCode, bool isStudent)
		{
			var client = ServiceContext.Session.NetClient;

			if (_queryUrl.IsNullOrEmpty())
			{
				//没有查询地址，说明咱还没查询过。所以这里先加载一下引导页
				await LoadInitPage();
			}

			//如果还是没有找到查询页地址，则报错
			if (_queryUrl.IsNullOrEmpty())
			{
				throw new Exception("无法找到查询页地址");
			}

			//构造查询字符串
			var queryparam = string.Format("?leftTicketDTO.train_date={0}&leftTicketDTO.from_station={1}&leftTicketDTO.to_station={2}&purpose_codes={3}",
				date.ToString("yyyy-MM-dd"),
				fromCode,
				toCode,
				(isStudent ? "0X00" : "ADULT"));

			//如果需要发送日志，则发送
			if (_saveQueryLog)
			{
				client.Create<string>(HttpMethod.Get,
									"https://kyfw.12306.cn/otn/leftTicket/log" + queryparam,
									"https://kyfw.12306.cn/otn/leftTicket/init"
					).SendAsync(false);
			}

			//发送查询请求
			var ctx = client.Create<WebResponseResult<QueryTicketResultData>>(
																			 HttpMethod.Get,
																			"https://kyfw.12306.cn/otn/" + _queryUrl + queryparam,
																			"https://kyfw.12306.cn/otn/leftTicket/init"
				);
			await ctx.SendTask();

			if (!ctx.IsValid())
			{
				throw ctx.Exception ?? new Exception("未能查询。");
			}

			if (ctx.Result.Data == null)
			{
				//服务器返回错误信息
				throw new Exception(ctx.Result.GetErrorMessage().DefaultForEmpty("未知错误信息"));
			}

			//生成结果
			var result = new TicketQueryResult()
			{
				QueryFromStationCode = fromCode,
				QueryFromStationName = fromName,
				QueryToStationCode = toCode,
				QueryToStationName = toName,
				QueryDate = date
			};
			result.AddRange(ctx.Result.Data.Select(s => new TicketQueryResultItem(date, s)));

			return result;
		}


	}
}
