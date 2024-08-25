using System;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x020000FA RID: 250
	[Flags]
	public enum X509ChainStatusFlags
	{
		// Token: 0x04000492 RID: 1170
		NoError = 0,
		// Token: 0x04000493 RID: 1171
		NotTimeValid = 1,
		// Token: 0x04000494 RID: 1172
		NotTimeNested = 2,
		// Token: 0x04000495 RID: 1173
		Revoked = 4,
		// Token: 0x04000496 RID: 1174
		NotSignatureValid = 8,
		// Token: 0x04000497 RID: 1175
		NotValidForUsage = 16,
		// Token: 0x04000498 RID: 1176
		UntrustedRoot = 32,
		// Token: 0x04000499 RID: 1177
		RevocationStatusUnknown = 64,
		// Token: 0x0400049A RID: 1178
		Cyclic = 128,
		// Token: 0x0400049B RID: 1179
		InvalidExtension = 256,
		// Token: 0x0400049C RID: 1180
		InvalidPolicyConstraints = 512,
		// Token: 0x0400049D RID: 1181
		InvalidBasicConstraints = 1024,
		// Token: 0x0400049E RID: 1182
		InvalidNameConstraints = 2048,
		// Token: 0x0400049F RID: 1183
		HasNotSupportedNameConstraint = 4096,
		// Token: 0x040004A0 RID: 1184
		HasNotDefinedNameConstraint = 8192,
		// Token: 0x040004A1 RID: 1185
		HasNotPermittedNameConstraint = 16384,
		// Token: 0x040004A2 RID: 1186
		HasExcludedNameConstraint = 32768,
		// Token: 0x040004A3 RID: 1187
		PartialChain = 65536,
		// Token: 0x040004A4 RID: 1188
		CtlNotTimeValid = 131072,
		// Token: 0x040004A5 RID: 1189
		CtlNotSignatureValid = 262144,
		// Token: 0x040004A6 RID: 1190
		CtlNotValidForUsage = 524288,
		// Token: 0x040004A7 RID: 1191
		OfflineRevocation = 16777216,
		// Token: 0x040004A8 RID: 1192
		NoIssuanceChainPolicy = 33554432,
		// Token: 0x040004A9 RID: 1193
		ExplicitDistrust = 67108864,
		// Token: 0x040004AA RID: 1194
		HasNotSupportedCriticalExtension = 134217728,
		// Token: 0x040004AB RID: 1195
		HasWeakSignature = 1048576
	}
}
