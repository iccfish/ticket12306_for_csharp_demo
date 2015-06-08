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

	/// <summary>
	/// 车站数据服务
	/// </summary>
	class StationDataService : ServiceBase
	{
		/// <summary>
		/// 所有车站
		/// </summary>
		List<Station> _allStations;

		/// <summary>
		/// 所有车站的电报码-车站索引
		/// </summary>
		Dictionary<string, Station> _allStationsCodeMap;

		/// <summary>
		/// 所有的车站列表
		/// </summary>
		public List<Station> AllStations
		{
			get { return _allStations; }
			set
			{
				_allStations = value;
				_allStationsCodeMap = value != null ? value.ToDictionary(s => s.Code) : null;
			}
		}


		public StationDataService(ServiceContext context) : base(context)
		{
		}

		/// <summary>
		/// 异步加载站点数据
		/// </summary>
		/// <returns></returns>
		public async Task LoadStationDatasAsync()
		{
			if (_allStations != null)
				return;

			//创建网络请求并发送。注意地址中最后的随机数，并没有发送。
			//对于静态文件来说，这个查询字符串是无效的
			//一般用来区分版本号，以便于更新的时候拿到过期的数据。
			var stCtx = ServiceContext.Session.NetClient
				.Create<string>(HttpMethod.Get, "https://kyfw.12306.cn/otn/resources/js/framework/station_name.js")
				.SendTask();

			//等待任务完成
			var jsContent = await stCtx;

			//解析请求
			var matches = Regex.Matches(jsContent, @"@[a-z]+\|([^\|]+)\|([a-z]+)\|([a-z]+)\|([a-z]+)\|(\d+)", RegexOptions.IgnoreCase);
			var list = new List<Station>(matches.Count);

			foreach (Match match in matches)
			{
				//转换为实体。注意：这里简拼没有使用
				list.Add(new Station(match.GetGroupValue(4), match.GetGroupValue(1), match.GetGroupValue(2), match.GetGroupValue(3)));
			}
			_allStations = list;
		}
	}
}
