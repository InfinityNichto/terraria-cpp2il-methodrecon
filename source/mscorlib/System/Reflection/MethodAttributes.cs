using System;

namespace System.Reflection
{
	// Token: 0x020004DC RID: 1244
	[Flags]
	public enum MethodAttributes
	{
		// Token: 0x040013BE RID: 5054
		MemberAccessMask = 7,
		// Token: 0x040013BF RID: 5055
		PrivateScope = 0,
		// Token: 0x040013C0 RID: 5056
		Private = 1,
		// Token: 0x040013C1 RID: 5057
		FamANDAssem = 2,
		// Token: 0x040013C2 RID: 5058
		Assembly = 3,
		// Token: 0x040013C3 RID: 5059
		Family = 4,
		// Token: 0x040013C4 RID: 5060
		FamORAssem = 5,
		// Token: 0x040013C5 RID: 5061
		Public = 6,
		// Token: 0x040013C6 RID: 5062
		Static = 16,
		// Token: 0x040013C7 RID: 5063
		Final = 32,
		// Token: 0x040013C8 RID: 5064
		Virtual = 64,
		// Token: 0x040013C9 RID: 5065
		HideBySig = 128,
		// Token: 0x040013CA RID: 5066
		CheckAccessOnOverride = 512,
		// Token: 0x040013CB RID: 5067
		VtableLayoutMask = 256,
		// Token: 0x040013CC RID: 5068
		ReuseSlot = 0,
		// Token: 0x040013CD RID: 5069
		NewSlot = 256,
		// Token: 0x040013CE RID: 5070
		Abstract = 1024,
		// Token: 0x040013CF RID: 5071
		SpecialName = 2048,
		// Token: 0x040013D0 RID: 5072
		PinvokeImpl = 8192,
		// Token: 0x040013D1 RID: 5073
		UnmanagedExport = 8,
		// Token: 0x040013D2 RID: 5074
		RTSpecialName = 4096,
		// Token: 0x040013D3 RID: 5075
		HasSecurity = 16384,
		// Token: 0x040013D4 RID: 5076
		RequireSecObject = 32768,
		// Token: 0x040013D5 RID: 5077
		ReservedMask = 53248
	}
}
