using System;
using System.Globalization;

namespace System.ComponentModel
{
	// Token: 0x020003BA RID: 954
	public class StringConverter : TypeConverter
	{
		// Token: 0x0600196C RID: 6508 RVA: 0x00047188 File Offset: 0x00045388
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			if (!true)
			{
			}
			Type type;
			bool flag = sourceType == type;
			return true;
		}

		// Token: 0x0600196D RID: 6509 RVA: 0x000471AC File Offset: 0x000453AC
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			return base.ConvertFrom(context, culture, value);
		}

		// Token: 0x0600196E RID: 6510 RVA: 0x000471C4 File Offset: 0x000453C4
		public StringConverter()
		{
		}
	}
}
