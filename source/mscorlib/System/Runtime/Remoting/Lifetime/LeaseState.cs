using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Lifetime
{
	// Token: 0x02000363 RID: 867
	[ComVisible(true)]
	[Serializable]
	public enum LeaseState
	{
		// Token: 0x04000E97 RID: 3735
		Null,
		// Token: 0x04000E98 RID: 3736
		Initial,
		// Token: 0x04000E99 RID: 3737
		Active,
		// Token: 0x04000E9A RID: 3738
		Renewing,
		// Token: 0x04000E9B RID: 3739
		Expired
	}
}
