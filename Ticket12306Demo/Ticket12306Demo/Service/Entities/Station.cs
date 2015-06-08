using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket12306Demo.Service.Entities
{
	class Station
	{

		/// <summary>
		/// 首字母拼音
		/// </summary>
		public string FirstLetter { get; private set; }

		/// <summary>
		/// 车站名
		/// </summary>
		public string Name { get; private set; }

		/// <summary>
		/// 电报码
		/// </summary>
		public string Code { get; private set; }

		/// <summary>
		/// 全拼
		/// </summary>
		public string Spell { get; private set; }


		/// <summary>
		/// Initializes a new instance of the <see cref="Station"/> class.
		/// </summary>
		/// <param name="firstLetter"></param>
		/// <param name="name"></param>
		/// <param name="code"></param>
		/// <param name="spell"></param>
		public Station(string firstLetter, string name, string code, string spell)
		{
			FirstLetter = firstLetter;
			Name = name;
			Code = code;
			Spell = spell;
		}
	}
}
