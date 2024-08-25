using System;

namespace System.ComponentModel
{
	// Token: 0x02000376 RID: 886
	public class ExpandableObjectConverter : TypeConverter
	{
		// Token: 0x0600173D RID: 5949 RVA: 0x00043214 File Offset: 0x00041414
		public ExpandableObjectConverter()
		{
		}

		// Token: 0x0600173E RID: 5950 RVA: 0x00043228 File Offset: 0x00041428
		public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
		{
			if (!true)
			{
			}
			return TypeDescriptor.GetProperties(value, attributes);
		}

		// Token: 0x0600173F RID: 5951 RVA: 0x00043240 File Offset: 0x00041440
		public override bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
			return true;
		}
	}
}
