using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000103 RID: 259
	[Preserve]
	public class StringEnumConverter : JsonConverter
	{
		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000A46 RID: 2630 RVA: 0x0001944C File Offset: 0x0001764C
		// (set) Token: 0x06000A47 RID: 2631 RVA: 0x00019460 File Offset: 0x00017660
		public bool CamelCaseText
		{
			[CompilerGenerated]
			get
			{
				return this.<CamelCaseText>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000A48 RID: 2632 RVA: 0x00019470 File Offset: 0x00017670
		// (set) Token: 0x06000A49 RID: 2633 RVA: 0x00019484 File Offset: 0x00017684
		public bool AllowIntegerValues
		{
			[CompilerGenerated]
			get
			{
				return this.<AllowIntegerValues>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x00019494 File Offset: 0x00017694
		public StringEnumConverter()
		{
			this.<AllowIntegerValues>k__BackingField = true;
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x000194B0 File Offset: 0x000176B0
		public StringEnumConverter(bool camelCaseText)
		{
			this.<AllowIntegerValues>k__BackingField = true;
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x000194CC File Offset: 0x000176CC
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			if (value != null)
			{
				long num = 0L;
				string text;
				bool flag = char.IsNumber(text[(int)num]);
				long num2 = 0L;
				char c = text[(int)num2];
				return;
			}
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x00019520 File Offset: 0x00017720
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			Type underlyingType = Nullable.GetUnderlyingType(objectType);
			object obj;
			return obj;
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x000195BC File Offset: 0x000177BC
		public override bool CanConvert(Type objectType)
		{
			if (!true)
			{
			}
			bool flag = ReflectionUtils.IsNullableType(objectType);
			return Nullable.GetUnderlyingType(objectType).IsEnum();
		}

		// Token: 0x04000401 RID: 1025
		[CompilerGenerated]
		private bool <CamelCaseText>k__BackingField;

		// Token: 0x04000402 RID: 1026
		[CompilerGenerated]
		private bool <AllowIntegerValues>k__BackingField;
	}
}
