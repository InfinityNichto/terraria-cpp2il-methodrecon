using System;

namespace System.ComponentModel.Design
{
	// Token: 0x0200040C RID: 1036
	public interface IComponentChangeService
	{
		// Token: 0x06001C08 RID: 7176
		void OnComponentChanged(object component, MemberDescriptor member, object oldValue, object newValue);

		// Token: 0x06001C09 RID: 7177
		void OnComponentChanging(object component, MemberDescriptor member);
	}
}
