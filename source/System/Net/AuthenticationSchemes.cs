using System;

namespace System.Net
{
	// Token: 0x02000185 RID: 389
	[Flags]
	public enum AuthenticationSchemes
	{
		// Token: 0x040007A9 RID: 1961
		None = 0,
		// Token: 0x040007AA RID: 1962
		Digest = 1,
		// Token: 0x040007AB RID: 1963
		Negotiate = 2,
		// Token: 0x040007AC RID: 1964
		Ntlm = 4,
		// Token: 0x040007AD RID: 1965
		Basic = 8,
		// Token: 0x040007AE RID: 1966
		Anonymous = 32768,
		// Token: 0x040007AF RID: 1967
		IntegratedWindowsAuthentication = 6
	}
}
