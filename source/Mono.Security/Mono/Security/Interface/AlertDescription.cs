using System;

namespace Mono.Security.Interface
{
	// Token: 0x02000043 RID: 67
	public enum AlertDescription : byte
	{
		// Token: 0x040000FB RID: 251
		CloseNotify,
		// Token: 0x040000FC RID: 252
		UnexpectedMessage = 10,
		// Token: 0x040000FD RID: 253
		BadRecordMAC = 20,
		// Token: 0x040000FE RID: 254
		DecryptionFailed_RESERVED,
		// Token: 0x040000FF RID: 255
		RecordOverflow,
		// Token: 0x04000100 RID: 256
		DecompressionFailure = 30,
		// Token: 0x04000101 RID: 257
		HandshakeFailure = 40,
		// Token: 0x04000102 RID: 258
		NoCertificate_RESERVED,
		// Token: 0x04000103 RID: 259
		BadCertificate,
		// Token: 0x04000104 RID: 260
		UnsupportedCertificate,
		// Token: 0x04000105 RID: 261
		CertificateRevoked,
		// Token: 0x04000106 RID: 262
		CertificateExpired,
		// Token: 0x04000107 RID: 263
		CertificateUnknown,
		// Token: 0x04000108 RID: 264
		IlegalParameter,
		// Token: 0x04000109 RID: 265
		UnknownCA,
		// Token: 0x0400010A RID: 266
		AccessDenied,
		// Token: 0x0400010B RID: 267
		DecodeError,
		// Token: 0x0400010C RID: 268
		DecryptError,
		// Token: 0x0400010D RID: 269
		ExportRestriction = 60,
		// Token: 0x0400010E RID: 270
		ProtocolVersion = 70,
		// Token: 0x0400010F RID: 271
		InsuficientSecurity,
		// Token: 0x04000110 RID: 272
		InternalError = 80,
		// Token: 0x04000111 RID: 273
		UserCancelled = 90,
		// Token: 0x04000112 RID: 274
		NoRenegotiation = 100,
		// Token: 0x04000113 RID: 275
		UnsupportedExtension = 110
	}
}
