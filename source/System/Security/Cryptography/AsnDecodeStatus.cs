using System;

namespace System.Security.Cryptography
{
	// Token: 0x020000F4 RID: 244
	internal enum AsnDecodeStatus
	{
		// Token: 0x0400046C RID: 1132
		NotDecoded = -1,
		// Token: 0x0400046D RID: 1133
		Ok,
		// Token: 0x0400046E RID: 1134
		BadAsn,
		// Token: 0x0400046F RID: 1135
		BadTag,
		// Token: 0x04000470 RID: 1136
		BadLength,
		// Token: 0x04000471 RID: 1137
		InformationNotAvailable
	}
}
