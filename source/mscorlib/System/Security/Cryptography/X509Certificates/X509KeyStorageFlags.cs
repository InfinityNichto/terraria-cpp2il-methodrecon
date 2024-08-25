using System;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x02000321 RID: 801
	[Flags]
	public enum X509KeyStorageFlags
	{
		// Token: 0x04000DCE RID: 3534
		DefaultKeySet = 0,
		// Token: 0x04000DCF RID: 3535
		UserKeySet = 1,
		// Token: 0x04000DD0 RID: 3536
		MachineKeySet = 2,
		// Token: 0x04000DD1 RID: 3537
		Exportable = 4,
		// Token: 0x04000DD2 RID: 3538
		UserProtected = 8,
		// Token: 0x04000DD3 RID: 3539
		PersistKeySet = 16,
		// Token: 0x04000DD4 RID: 3540
		EphemeralKeySet = 32
	}
}
