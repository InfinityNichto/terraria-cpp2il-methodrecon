using System;

namespace System.ComponentModel
{
	// Token: 0x0200035C RID: 860
	public abstract class ContainerFilterService
	{
		// Token: 0x06001673 RID: 5747 RVA: 0x000419CC File Offset: 0x0003FBCC
		protected ContainerFilterService()
		{
		}

		// Token: 0x06001674 RID: 5748 RVA: 0x000419E0 File Offset: 0x0003FBE0
		public virtual ComponentCollection FilterComponents(ComponentCollection components)
		{
			return components;
		}
	}
}
