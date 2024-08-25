using System;
using System.Runtime.CompilerServices;

namespace System.ComponentModel
{
	// Token: 0x02000358 RID: 856
	public class CollectionChangeEventArgs : EventArgs
	{
		// Token: 0x0600165E RID: 5726 RVA: 0x00041648 File Offset: 0x0003F848
		public CollectionChangeEventArgs(CollectionChangeAction action, object element)
		{
			if (!true)
			{
			}
			base..ctor();
			this.Action = action;
			this.Element = element;
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x0600165F RID: 5727 RVA: 0x0004166C File Offset: 0x0003F86C
		public virtual CollectionChangeAction Action
		{
			[CompilerGenerated]
			get
			{
				return this.<Action>k__BackingField;
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06001660 RID: 5728 RVA: 0x00041680 File Offset: 0x0003F880
		public virtual object Element
		{
			[CompilerGenerated]
			get
			{
				return this.<Element>k__BackingField;
			}
		}

		// Token: 0x040011DC RID: 4572
		[CompilerGenerated]
		private readonly CollectionChangeAction <Action>k__BackingField;

		// Token: 0x040011DD RID: 4573
		[CompilerGenerated]
		private readonly object <Element>k__BackingField;
	}
}
