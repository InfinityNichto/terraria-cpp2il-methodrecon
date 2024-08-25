using System;
using System.Globalization;

namespace System.ComponentModel
{
	// Token: 0x020003A7 RID: 935
	public class MultilineStringConverter : TypeConverter
	{
		// Token: 0x060018A7 RID: 6311 RVA: 0x000457F4 File Offset: 0x000439F4
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

		// Token: 0x060018A8 RID: 6312 RVA: 0x00045824 File Offset: 0x00043A24
		public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
		{
		}

		// Token: 0x060018A9 RID: 6313 RVA: 0x00045834 File Offset: 0x00043A34
		public override bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
		}

		// Token: 0x060018AA RID: 6314 RVA: 0x00045844 File Offset: 0x00043A44
		public MultilineStringConverter()
		{
		}
	}
}
