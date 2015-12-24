using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket12306Demo.Network
{
	using System.Reflection;
	using FSLib.Network.Http;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Serialization;

	/// <summary>
	/// 基于FSLIB.NETWORK的网络层扩展，进一步抽象以便于后期提供功能
	/// </summary>
	class NetClient : HttpClient
	{
		/// <summary>
		/// 默认构造函数
		/// </summary>
		public NetClient()
		{
			Setting.JsonDeserializationSetting = new JsonDeserializationSetting();
			Setting.JsonDeserializationSetting.Setting.ContractResolver = new JsonContractResolver();
		}
	}

	public class JsonContractResolver : DefaultContractResolver
	{
		protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
		{
			var prop = base.CreateProperty(member, memberSerialization);

			if (!prop.Writable)
			{
				var property = member as PropertyInfo;
				if (property != null)
				{
					var hasPrivateSetter = property.GetSetMethod(true) != null;
					prop.Writable = hasPrivateSetter;
				}
			}

			return prop;
		}
	}
}
