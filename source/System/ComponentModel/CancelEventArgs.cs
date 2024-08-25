using System;
using System.Runtime.CompilerServices;

namespace System.ComponentModel
{
	// Token: 0x020003C8 RID: 968
	public class CancelEventArgs : EventArgs
	{
		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x060019BA RID: 6586 RVA: 0x00047978 File Offset: 0x00045B78
		// (set) Token: 0x060019BB RID: 6587 RVA: 0x0004798C File Offset: 0x00045B8C
		public bool Cancel
		{
			[CompilerGenerated]
			get
			{
				return this.<Cancel>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060019BC RID: 6588 RVA: 0x0004799C File Offset: 0x00045B9C
		public CancelEventArgs()
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x060019BD RID: 6589 RVA: 0x000479B4 File Offset: 0x00045BB4
		public CancelEventArgs(bool cancel)
		{
			if (!true)
			{
			}
			base..ctor();
			this.<Cancel>k__BackingField = true;
		}

		// Token: 0x040012DC RID: 4828
		[CompilerGenerated]
		private bool <Cancel>k__BackingField;
	}
}
