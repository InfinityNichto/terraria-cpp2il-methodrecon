using System;
using System.Globalization;

namespace System.ComponentModel
{
	// Token: 0x020003DE RID: 990
	public class DateTimeOffsetConverter : TypeConverter
	{
		// Token: 0x06001A2A RID: 6698 RVA: 0x000485B8 File Offset: 0x000467B8
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			if (!true)
			{
			}
			Type type;
			bool flag = sourceType == type;
			return true;
		}

		// Token: 0x06001A2B RID: 6699 RVA: 0x000485D4 File Offset: 0x000467D4
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			if (!true)
			{
			}
			Type type;
			bool flag = destinationType == type;
			return true;
		}

		// Token: 0x06001A2C RID: 6700 RVA: 0x000485F0 File Offset: 0x000467F0
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			if (value != null)
			{
			}
			return base.ConvertFrom(context, culture, value);
		}

		// Token: 0x06001A2D RID: 6701 RVA: 0x0004864C File Offset: 0x0004684C
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
			Type type2;
			bool flag2 = destinationType == type2;
			if (value != null)
			{
			}
			object obj;
			return obj;
		}

		// Token: 0x06001A2E RID: 6702 RVA: 0x00048748 File Offset: 0x00046948
		public DateTimeOffsetConverter()
		{
		}
	}
}
