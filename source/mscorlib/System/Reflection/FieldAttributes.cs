using System;

namespace System.Reflection
{
	// Token: 0x020004D3 RID: 1235
	[Flags]
	public enum FieldAttributes
	{
		// Token: 0x04001394 RID: 5012
		FieldAccessMask = 7,
		// Token: 0x04001395 RID: 5013
		PrivateScope = 0,
		// Token: 0x04001396 RID: 5014
		Private = 1,
		// Token: 0x04001397 RID: 5015
		FamANDAssem = 2,
		// Token: 0x04001398 RID: 5016
		Assembly = 3,
		// Token: 0x04001399 RID: 5017
		Family = 4,
		// Token: 0x0400139A RID: 5018
		FamORAssem = 5,
		// Token: 0x0400139B RID: 5019
		Public = 6,
		// Token: 0x0400139C RID: 5020
		Static = 16,
		// Token: 0x0400139D RID: 5021
		InitOnly = 32,
		// Token: 0x0400139E RID: 5022
		Literal = 64,
		// Token: 0x0400139F RID: 5023
		NotSerialized = 128,
		// Token: 0x040013A0 RID: 5024
		SpecialName = 512,
		// Token: 0x040013A1 RID: 5025
		PinvokeImpl = 8192,
		// Token: 0x040013A2 RID: 5026
		RTSpecialName = 1024,
		// Token: 0x040013A3 RID: 5027
		HasFieldMarshal = 4096,
		// Token: 0x040013A4 RID: 5028
		HasDefault = 32768,
		// Token: 0x040013A5 RID: 5029
		HasFieldRVA = 256,
		// Token: 0x040013A6 RID: 5030
		ReservedMask = 38144
	}
}
