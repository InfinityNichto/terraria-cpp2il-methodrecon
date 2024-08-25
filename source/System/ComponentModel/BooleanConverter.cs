using System;
using System.Globalization;

namespace System.ComponentModel
{
	// Token: 0x02000353 RID: 851
	public class BooleanConverter : TypeConverter
	{
		// Token: 0x0600164B RID: 5707 RVA: 0x00041404 File Offset: 0x0003F604
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			if (!true)
			{
			}
			Type type;
			bool flag = sourceType == type;
			return true;
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x00041420 File Offset: 0x0003F620
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			if (value != null)
			{
			}
			return base.ConvertFrom(context, culture, value);
		}

		// Token: 0x0600164D RID: 5709 RVA: 0x0004145C File Offset: 0x0003F65C
		public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600164E RID: 5710 RVA: 0x00041470 File Offset: 0x0003F670
		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x0600164F RID: 5711 RVA: 0x00041480 File Offset: 0x0003F680
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x06001650 RID: 5712 RVA: 0x00041490 File Offset: 0x0003F690
		public BooleanConverter()
		{
		}

		// Token: 0x040011D7 RID: 4567
		private static TypeConverter.StandardValuesCollection s_values;
	}
}
