using System;
using System.Runtime.CompilerServices;

namespace System.Threading.Tasks
{
	// Token: 0x02000254 RID: 596
	[FriendAccessAllowed]
	internal enum AsyncCausalityStatus
	{
		// Token: 0x04000ACC RID: 2764
		Started,
		// Token: 0x04000ACD RID: 2765
		Completed,
		// Token: 0x04000ACE RID: 2766
		Canceled,
		// Token: 0x04000ACF RID: 2767
		Error
	}
}
