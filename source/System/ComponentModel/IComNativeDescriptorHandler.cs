using System;

namespace System.ComponentModel
{
	// Token: 0x0200037F RID: 895
	[Obsolete("This interface has been deprecated. Add a TypeDescriptionProvider to handle type TypeDescriptor.ComObjectType instead.  https://go.microsoft.com/fwlink/?linkid=14202")]
	public interface IComNativeDescriptorHandler
	{
		// Token: 0x0600177D RID: 6013
		AttributeCollection GetAttributes(object component);

		// Token: 0x0600177E RID: 6014
		string GetClassName(object component);

		// Token: 0x0600177F RID: 6015
		TypeConverter GetConverter(object component);

		// Token: 0x06001780 RID: 6016
		EventDescriptor GetDefaultEvent(object component);

		// Token: 0x06001781 RID: 6017
		PropertyDescriptor GetDefaultProperty(object component);

		// Token: 0x06001782 RID: 6018
		object GetEditor(object component, Type baseEditorType);

		// Token: 0x06001783 RID: 6019
		string GetName(object component);

		// Token: 0x06001784 RID: 6020
		EventDescriptorCollection GetEvents(object component);

		// Token: 0x06001785 RID: 6021
		EventDescriptorCollection GetEvents(object component, Attribute[] attributes);

		// Token: 0x06001786 RID: 6022
		PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes);

		// Token: 0x06001787 RID: 6023
		object GetPropertyValue(object component, string propertyName, bool success);

		// Token: 0x06001788 RID: 6024
		object GetPropertyValue(object component, int dispid, bool success);
	}
}
