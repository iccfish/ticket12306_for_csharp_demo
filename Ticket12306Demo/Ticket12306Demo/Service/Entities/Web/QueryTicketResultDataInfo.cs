namespace Ticket12306Demo.Service.Entities.Web
{
	class QueryTicketResultDataInfo
	{
		public string Train_No { get; private set; }

		public string Station_Train_Code { get; private set; }

		/// <summary>
		/// 始发站电报码
		/// </summary>
		public string Start_Station_TeleCode { get; private set; }

		/// <summary>
		/// 始发站名称
		/// </summary>
		public string Start_Station_Name { get; private set; }

		/// <summary>
		/// 发站电报码
		/// </summary>
		public string From_Station_TeleCode { get; private set; }

		/// <summary>
		/// 发站名称
		/// </summary>
		public string From_Station_Name { get; private set; }

		/// <summary>
		/// 到站电报码
		/// </summary>
		public string To_Station_TeleCode { get; private set; }

		/// <summary>
		/// 到站名称
		/// </summary>
		public string To_Station_Name { get; private set; }

		/// <summary>
		/// 到站电报码
		/// </summary>
		public string End_Station_TeleCode { get; private set; }

		/// <summary>
		/// 到站名称
		/// </summary>
		public string End_Station_Name { get; private set; }

		public string Start_Time { get; private set; }

		public string Arrive_Time { get; private set; }

		public int Day_Difference { get; private set; }

		/// <summary>
		/// 历时
		/// </summary>
		public int LiShiValue { get; private set; }

		public string CanWebBuy { get; private set; }

		public string Gg_Num { get; private set; }
		public string Gr_Num { get; private set; }
		public string Qt_Num { get; private set; }
		public string Rw_Num { get; private set; }
		public string Rz_Num { get; private set; }
		public string Tz_Num { get; private set; }
		public string Wz_Num { get; private set; }
		public string Yb_Num { get; private set; }
		public string Yw_Num { get; private set; }
		public string Yz_Num { get; private set; }
		public string Ze_Num { get; private set; }
		public string Zy_Num { get; private set; }
		public string Swz_Num { get; private set; }
	}
}