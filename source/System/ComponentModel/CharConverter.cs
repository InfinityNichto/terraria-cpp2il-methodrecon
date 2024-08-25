using System;
using System.Globalization;

namespace System.ComponentModel
{
	// Token: 0x02000356 RID: 854
	public class CharConverter : TypeConverter
	{
		// Token: 0x0600165A RID: 5722 RVA: 0x000415A4 File Offset: 0x0003F7A4
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			if (!true)
			{
			}
			Type type;
			bool flag = sourceType == type;
			return true;
		}

		// Token: 0x0600165B RID: 5723 RVA: 0x000415C8 File Offset: 0x0003F7C8
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

		// Token: 0x0600165C RID: 5724 RVA: 0x000415F8 File Offset: 0x0003F7F8
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			if (value != null)
			{
			}
			return base.ConvertFrom(context, culture, value);
		}

		// Token: 0x0600165D RID: 5725 RVA: 0x00041634 File Offset: 0x0003F834
		public CharConverter()
		{
		}
	}
}
