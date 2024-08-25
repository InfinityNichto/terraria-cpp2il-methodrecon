using System;

namespace System.ComponentModel
{
	// Token: 0x020003DB RID: 987
	public class ComponentConverter : ReferenceConverter
	{
		// Token: 0x06001A13 RID: 6675 RVA: 0x0004813C File Offset: 0x0004633C
		public ComponentConverter(Type type)
		{
			if (!true)
			{
			}
			base..ctor(type);
		}

		// Token: 0x06001A14 RID: 6676 RVA: 0x00048154 File Offset: 0x00046354
		public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
		{
			if (!true)
			{
			}
			return TypeDescriptor.GetProperties(value, attributes);
		}

		// Token: 0x06001A15 RID: 6677 RVA: 0x0004816C File Offset: 0x0004636C
		public override bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
			return true;
		}
	}
}
