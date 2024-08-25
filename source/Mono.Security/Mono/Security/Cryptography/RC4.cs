using System;
using System.Security.Cryptography;
using Cpp2IlInjected;

namespace Mono.Security.Cryptography
{
	// Token: 0x0200005C RID: 92
	public abstract class RC4 : SymmetricAlgorithm
	{
		// Token: 0x06000280 RID: 640 RVA: 0x00009D90 File Offset: 0x00007F90
		public RC4()
		{
			this.KeySizeValue = 128;
			if (128 == 0)
			{
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000281 RID: 641 RVA: 0x00009DB8 File Offset: 0x00007FB8
		// (set) Token: 0x06000282 RID: 642 RVA: 0x00009DC8 File Offset: 0x00007FC8
		public override byte[] IV
		{
			get
			{
			}
			set
			{
			}
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00002050 File Offset: 0x00000250
		public new static RC4 Create()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00009DD8 File Offset: 0x00007FD8
		// Note: this type is marked as 'beforefieldinit'.
		static RC4()
		{
		}

		// Token: 0x0400026B RID: 619
		private static KeySizes[] s_legalBlockSizes;

		// Token: 0x0400026C RID: 620
		private static KeySizes[] s_legalKeySizes;
	}
}
