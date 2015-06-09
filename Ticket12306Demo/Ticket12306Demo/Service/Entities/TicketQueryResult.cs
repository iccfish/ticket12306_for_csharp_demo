using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket12306Demo.Service.Entities
{
	using System.Runtime.Remoting.Channels;
	using Ticket12306Demo.Service.Entities.Web;

	/// <summary>
	/// 查票结果
	/// </summary>
	class TicketQueryResult : List<TicketQueryResultItem>
	{
		/// <summary>
		/// 查询的发站
		/// </summary>
		public string QueryFromStationName { get; set; }

		/// <summary>
		/// 查询的发站电报码
		/// </summary>
		public string QueryFromStationCode { get; set; }

		/// <summary>
		/// 查询的到站
		/// </summary>
		public string QueryToStationName { get; set; }

		/// <summary>
		/// 查询的到站电报码
		/// </summary>
		public string QueryToStationCode { get; set; }

		/// <summary>
		/// 查询的日期
		/// </summary>
		public DateTime QueryDate { get; set; }
	}

	/// <summary>
	/// 查票结果-单车次
	/// </summary>
	class TicketQueryResultItem
	{
		QueryTicketResultDataItem _rawData;

		/// <summary>
		/// Initializes a new instance of the <see cref="TicketQueryResultItem"/> class.
		/// </summary>
		/// <param name="queryDate">当前的查询日期</param>
		/// <param name="rawData"></param>
		public TicketQueryResultItem(DateTime queryDate, QueryTicketResultDataItem rawData)
		{
			_rawData = rawData;
			ElapsedTime = new TimeSpan(0, _rawData.QueryLeftNewDTO.LiShiValue, 0);
			LeftTime = queryDate.Add(TimeSpan.Parse(_rawData.QueryLeftNewDTO.Start_Time));
			ArriveTime = LeftTime.Add(ElapsedTime);
			DaysCost = _rawData.QueryLeftNewDTO.Day_Difference;
		}

		public string TrainCode { get { return _rawData.QueryLeftNewDTO.Station_Train_Code; } }

		public string TrainID { get { return _rawData.QueryLeftNewDTO.Train_No; } }

		/// <summary>
		/// 发站名
		/// </summary>
		public string FromStationName { get { return _rawData.QueryLeftNewDTO.From_Station_Name; } }

		/// <summary>
		/// 是否是始发站
		/// </summary>
		public bool IsFirstStation { get { return _rawData.QueryLeftNewDTO.From_Station_TeleCode == _rawData.QueryLeftNewDTO.Start_Station_TeleCode; } }

		public string FromStationCode { get { return _rawData.QueryLeftNewDTO.From_Station_TeleCode; } }

		public string ToStationName
		{
			get { return _rawData.QueryLeftNewDTO.To_Station_Name; }
		}

		public string ToStationCode
		{
			get { return _rawData.QueryLeftNewDTO.To_Station_TeleCode; }
		}

		/// <summary>
		/// 是否是终到站
		/// </summary>
		public bool IsLastStation { get { return _rawData.QueryLeftNewDTO.End_Station_TeleCode == _rawData.QueryLeftNewDTO.To_Station_TeleCode; } }

		public TimeSpan ElapsedTime { get; private set; }

		public DateTime LeftTime { get; private set; }

		public DateTime ArriveTime { get; private set; }

		public int DaysCost { get; private set; }

		public string SecretStr { get; private set; }

		public string Gg_Num { get { return _rawData.QueryLeftNewDTO.Gg_Num; } }
		public string Gr_Num { get { return _rawData.QueryLeftNewDTO.Gr_Num; } }
		public string Qt_Num { get { return _rawData.QueryLeftNewDTO.Qt_Num; } }
		public string Rw_Num { get { return _rawData.QueryLeftNewDTO.Rw_Num; } }
		public string Rz_Num { get { return _rawData.QueryLeftNewDTO.Rz_Num; } }
		public string Tz_Num { get { return _rawData.QueryLeftNewDTO.Tz_Num; } }
		public string Wz_Num { get { return _rawData.QueryLeftNewDTO.Wz_Num; } }
		public string Yb_Num { get { return _rawData.QueryLeftNewDTO.Yb_Num; } }
		public string Yw_Num { get { return _rawData.QueryLeftNewDTO.Yw_Num; } }
		public string Yz_Num { get { return _rawData.QueryLeftNewDTO.Yz_Num; } }
		public string Ze_Num { get { return _rawData.QueryLeftNewDTO.Ze_Num; } }
		public string Zy_Num { get { return _rawData.QueryLeftNewDTO.Zy_Num; } }
		public string Swz_Num { get { return _rawData.QueryLeftNewDTO.Swz_Num; } }


		#region 部分额外的显示信息

		public string Disp_FromName
		{
			get
			{
				if (!IsFirstStation) return FromStationName;
				return FromStationName + " [始]";
			}
		}

		public string Disp_ToName
		{
			get
			{
				if (!IsLastStation) return ToStationName;
				return ToStationName + " [终]";
			}
		}

		public string Disp_ElapsedTime
		{
			get
			{
				if (DaysCost > 0)
				{
					return ((int)ElapsedTime.TotalHours) + "小时/" + DaysCost + "天";
				}
				return ((int)ElapsedTime.TotalHours) + "小时";
			}
		}

		public string ButtonText { get { return _rawData.ButtonTextInfo; } }

		#endregion
	}
}
