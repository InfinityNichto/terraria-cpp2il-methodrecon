using System;
using System.Collections;

namespace System.ComponentModel.Design
{
	// Token: 0x02000412 RID: 1042
	public interface ITypeDescriptorFilterService
	{
		// Token: 0x06001C12 RID: 7186
		bool FilterAttributes(IComponent component, IDictionary attributes);

		// Token: 0x06001C13 RID: 7187
		bool FilterEvents(IComponent component, IDictionary events);

		// Token: 0x06001C14 RID: 7188
		bool FilterProperties(IComponent component, IDictionary properties);
	}
}
