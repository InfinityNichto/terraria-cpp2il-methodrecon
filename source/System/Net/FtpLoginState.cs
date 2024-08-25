using System;

namespace System.Net
{
	// Token: 0x02000149 RID: 329
	internal enum FtpLoginState : byte
	{
		// Token: 0x04000678 RID: 1656
		NotLoggedIn,
		// Token: 0x04000679 RID: 1657
		LoggedIn,
		// Token: 0x0400067A RID: 1658
		LoggedInButNeedsRelogin,
		// Token: 0x0400067B RID: 1659
		ReloginFailed
	}
}
