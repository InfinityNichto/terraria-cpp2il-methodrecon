using System;
using System.Runtime.CompilerServices;

namespace System.ComponentModel
{
	// Token: 0x0200037A RID: 890
	public class HandledEventArgs : EventArgs
	{
		// Token: 0x0600175B RID: 5979 RVA: 0x00043534 File Offset: 0x00041734
		public HandledEventArgs()
		{
		}

		// Token: 0x0600175C RID: 5980 RVA: 0x00043544 File Offset: 0x00041744
		public HandledEventArgs(bool defaultHandledValue)
		{
			if (!true)
			{
			}
			base..ctor();
			this.<Handled>k__BackingField = true;
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x0600175D RID: 5981 RVA: 0x00043564 File Offset: 0x00041764
		// (set) Token: 0x0600175E RID: 5982 RVA: 0x00043578 File Offset: 0x00041778
		public bool Handled
		{
			[CompilerGenerated]
			get
			{
				return this.<Handled>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0400122B RID: 4651
		[CompilerGenerated]
		private bool <Handled>k__BackingField;
	}
}
