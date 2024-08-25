using System;

namespace System.ComponentModel
{
	// Token: 0x0200038A RID: 906
	public interface ITypedList
	{
		// Token: 0x060017A7 RID: 6055
		string GetListName(PropertyDescriptor[] listAccessors);

		// Token: 0x060017A8 RID: 6056
		PropertyDescriptorCollection GetItemProperties(PropertyDescriptor[] listAccessors);
	}
}
