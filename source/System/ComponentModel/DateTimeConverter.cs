using System;
using System.Globalization;

namespace System.ComponentModel
{
	// Token: 0x02000365 RID: 869
	public class DateTimeConverter : TypeConverter
	{
		// Token: 0x060016AA RID: 5802 RVA: 0x0004208C File Offset: 0x0004028C
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			if (!true)
			{
			}
			Type type;
			bool flag = sourceType == type;
			return true;
		}

		// Token: 0x060016AB RID: 5803 RVA: 0x000420B0 File Offset: 0x000402B0
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			if (!true)
			{
			}
			Type type;
			bool flag = destinationType == type;
			return true;
		}

		// Token: 0x060016AC RID: 5804 RVA: 0x000420D4 File Offset: 0x000402D4
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			if (value != null)
			{
			}
			return base.ConvertFrom(context, culture, value);
		}

		// Token: 0x060016AD RID: 5805 RVA: 0x0004211C File Offset: 0x0004031C
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (!true)
			{
			}
			Type type;
			bool flag = destinationType == type;
			if (value != null)
			{
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}

		// Token: 0x060016AE RID: 5806 RVA: 0x00042184 File Offset: 0x00040384
		public DateTimeConverter()
		{
		}
	}
}
