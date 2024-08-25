using System;

namespace Internal.Cryptography.Pal
{
	// Token: 0x02000071 RID: 113
	internal enum GeneralNameType
	{
		// Token: 0x0400013C RID: 316
		OtherName,
		// Token: 0x0400013D RID: 317
		Rfc822Name,
		// Token: 0x0400013E RID: 318
		Email = 1,
		// Token: 0x0400013F RID: 319
		DnsName,
		// Token: 0x04000140 RID: 320
		X400Address,
		// Token: 0x04000141 RID: 321
		DirectoryName,
		// Token: 0x04000142 RID: 322
		EdiPartyName,
		// Token: 0x04000143 RID: 323
		UniformResourceIdentifier,
		// Token: 0x04000144 RID: 324
		IPAddress,
		// Token: 0x04000145 RID: 325
		RegisteredId
	}
}
