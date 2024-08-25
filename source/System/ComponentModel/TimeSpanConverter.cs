using System;
using System.Globalization;

namespace System.ComponentModel
{
	// Token: 0x020003BC RID: 956
	public class TimeSpanConverter : TypeConverter
	{
		// Token: 0x06001972 RID: 6514 RVA: 0x00047218 File Offset: 0x00045418
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			if (!true)
			{
			}
			Type type;
			bool flag = sourceType == type;
			return true;
		}

		// Token: 0x06001973 RID: 6515 RVA: 0x0004723C File Offset: 0x0004543C
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			if (!true)
			{
			}
			Type type;
			bool flag = destinationType == type;
			return true;
		}

		// Token: 0x06001974 RID: 6516 RVA: 0x00047260 File Offset: 0x00045460
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			if (value != null)
			{
			}
			return base.ConvertFrom(context, culture, value);
		}

		// Token: 0x06001975 RID: 6517 RVA: 0x0004729C File Offset: 0x0004549C
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (!true)
			{
			}
			Type type;
			bool flag = destinationType == type;
			Type type2;
			if (value == null || ((type2 == null || type2 != null) && (value == null || value != null)))
			{
				object obj;
				return obj;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06001976 RID: 6518 RVA: 0x000472D0 File Offset: 0x000454D0
		public TimeSpanConverter()
		{
		}
	}
}
