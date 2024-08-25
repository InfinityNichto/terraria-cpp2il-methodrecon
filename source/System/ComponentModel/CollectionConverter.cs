using System;
using System.Globalization;

namespace System.ComponentModel
{
	// Token: 0x020003D8 RID: 984
	public class CollectionConverter : TypeConverter
	{
		// Token: 0x060019FD RID: 6653 RVA: 0x00047ED4 File Offset: 0x000460D4
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (!true)
			{
			}
			Type type;
			bool flag = destinationType == type;
			if (value != null)
			{
				string @string = SR.GetString("(Collection)");
			}
			object obj;
			return obj;
		}

		// Token: 0x060019FE RID: 6654 RVA: 0x00047F00 File Offset: 0x00046100
		public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
		{
		}

		// Token: 0x060019FF RID: 6655 RVA: 0x00047F10 File Offset: 0x00046110
		public override bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
		}

		// Token: 0x06001A00 RID: 6656 RVA: 0x00047F20 File Offset: 0x00046120
		public CollectionConverter()
		{
		}
	}
}
