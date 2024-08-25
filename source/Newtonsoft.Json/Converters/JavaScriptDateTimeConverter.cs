using System;
using System.Globalization;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000108 RID: 264
	[Preserve]
	public class JavaScriptDateTimeConverter : DateTimeConverterBase
	{
		// Token: 0x06000A70 RID: 2672 RVA: 0x000199F4 File Offset: 0x00017BF4
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			while (value == null)
			{
			}
			DateTimeOffset dateTimeOffset;
			DateTime utcDateTime = dateTimeOffset.UtcDateTime;
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x00019A14 File Offset: 0x00017C14
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			bool flag = ReflectionUtils.IsNullable(objectType);
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			return "Cannot convert null value to {0}.";
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x00019A70 File Offset: 0x00017C70
		public JavaScriptDateTimeConverter()
		{
		}
	}
}
