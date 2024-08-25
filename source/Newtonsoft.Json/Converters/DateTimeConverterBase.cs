using System;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000F9 RID: 249
	[Preserve]
	public abstract class DateTimeConverterBase : JsonConverter
	{
		// Token: 0x06000A10 RID: 2576 RVA: 0x00018C10 File Offset: 0x00016E10
		public override bool CanConvert(Type objectType)
		{
			if (!true)
			{
			}
			return true;
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x00018C24 File Offset: 0x00016E24
		protected DateTimeConverterBase()
		{
		}
	}
}
