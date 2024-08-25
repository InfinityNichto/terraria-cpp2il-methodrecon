using System;
using System.Runtime.InteropServices;

namespace System
{
	// Token: 0x02000188 RID: 392
	[ComVisible(true)]
	[Serializable]
	public enum PlatformID
	{
		// Token: 0x0400068D RID: 1677
		Win32S,
		// Token: 0x0400068E RID: 1678
		Win32Windows,
		// Token: 0x0400068F RID: 1679
		Win32NT,
		// Token: 0x04000690 RID: 1680
		WinCE,
		// Token: 0x04000691 RID: 1681
		Unix,
		// Token: 0x04000692 RID: 1682
		Xbox,
		// Token: 0x04000693 RID: 1683
		MacOSX
	}
}
