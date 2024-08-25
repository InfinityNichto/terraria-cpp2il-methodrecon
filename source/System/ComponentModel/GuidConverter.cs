using System;
using System.Globalization;

namespace System.ComponentModel
{
	// Token: 0x02000379 RID: 889
	public class GuidConverter : TypeConverter
	{
		// Token: 0x06001756 RID: 5974 RVA: 0x0004348C File Offset: 0x0004168C
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			if (!true)
			{
			}
			Type type;
			bool flag = sourceType == type;
			return true;
		}

		// Token: 0x06001757 RID: 5975 RVA: 0x000434B0 File Offset: 0x000416B0
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			if (!true)
			{
			}
			Type type;
			bool flag = destinationType == type;
			return true;
		}

		// Token: 0x06001758 RID: 5976 RVA: 0x000434D4 File Offset: 0x000416D4
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			if (value != null)
			{
			}
			return base.ConvertFrom(context, culture, value);
		}

		// Token: 0x06001759 RID: 5977 RVA: 0x000434F0 File Offset: 0x000416F0
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (!true)
			{
			}
			Type type;
			bool flag = destinationType == type;
			Type type2;
			if (value == null || (type2 != null && (value == null || value != null)))
			{
				object obj;
				return obj;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600175A RID: 5978 RVA: 0x00043520 File Offset: 0x00041720
		public GuidConverter()
		{
		}
	}
}
