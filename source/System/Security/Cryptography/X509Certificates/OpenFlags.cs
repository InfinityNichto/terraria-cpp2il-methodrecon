using System;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x020000F6 RID: 246
	[Flags]
	public enum OpenFlags
	{
		// Token: 0x04000475 RID: 1141
		ReadOnly = 0,
		// Token: 0x04000476 RID: 1142
		ReadWrite = 1,
		// Token: 0x04000477 RID: 1143
		MaxAllowed = 2,
		// Token: 0x04000478 RID: 1144
		OpenExistingOnly = 4,
		// Token: 0x04000479 RID: 1145
		IncludeArchived = 8
	}
}
