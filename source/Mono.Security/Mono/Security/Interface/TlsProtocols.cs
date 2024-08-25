using System;

namespace Mono.Security.Interface
{
	// Token: 0x02000050 RID: 80
	[Flags]
	public enum TlsProtocols
	{
		// Token: 0x04000242 RID: 578
		Zero = 0,
		// Token: 0x04000243 RID: 579
		Tls10Client = 128,
		// Token: 0x04000244 RID: 580
		Tls10Server = 64,
		// Token: 0x04000245 RID: 581
		Tls10 = 192,
		// Token: 0x04000246 RID: 582
		Tls11Client = 512,
		// Token: 0x04000247 RID: 583
		Tls11Server = 256,
		// Token: 0x04000248 RID: 584
		Tls11 = 768,
		// Token: 0x04000249 RID: 585
		Tls12Client = 2048,
		// Token: 0x0400024A RID: 586
		Tls12Server = 1024,
		// Token: 0x0400024B RID: 587
		Tls12 = 3072,
		// Token: 0x0400024C RID: 588
		ClientMask = 2688,
		// Token: 0x0400024D RID: 589
		ServerMask = 1344
	}
}
