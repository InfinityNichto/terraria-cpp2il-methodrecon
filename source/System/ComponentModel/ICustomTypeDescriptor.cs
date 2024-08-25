using System;

namespace System.ComponentModel
{
	// Token: 0x02000380 RID: 896
	public interface ICustomTypeDescriptor
	{
		// Token: 0x06001789 RID: 6025
		AttributeCollection GetAttributes();

		// Token: 0x0600178A RID: 6026
		string GetClassName();

		// Token: 0x0600178B RID: 6027
		string GetComponentName();

		// Token: 0x0600178C RID: 6028
		TypeConverter GetConverter();

		// Token: 0x0600178D RID: 6029
		EventDescriptor GetDefaultEvent();

		// Token: 0x0600178E RID: 6030
		PropertyDescriptor GetDefaultProperty();

		// Token: 0x0600178F RID: 6031
		object GetEditor(Type editorBaseType);

		// Token: 0x06001790 RID: 6032
		EventDescriptorCollection GetEvents();

		// Token: 0x06001791 RID: 6033
		EventDescriptorCollection GetEvents(Attribute[] attributes);

		// Token: 0x06001792 RID: 6034
		PropertyDescriptorCollection GetProperties();

		// Token: 0x06001793 RID: 6035
		PropertyDescriptorCollection GetProperties(Attribute[] attributes);

		// Token: 0x06001794 RID: 6036
		object GetPropertyOwner(PropertyDescriptor pd);
	}
}
