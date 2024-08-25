using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System.Security.Cryptography
{
	// Token: 0x020002EC RID: 748
	[ComVisible(true)]
	public abstract class Rijndael : SymmetricAlgorithm
	{
		// Token: 0x0600191E RID: 6430 RVA: 0x00035CB0 File Offset: 0x00033EB0
		protected Rijndael()
		{
			this.KeySizeValue = 256;
			if (256 == 0)
			{
			}
		}

		// Token: 0x0600191F RID: 6431 RVA: 0x0000207A File Offset: 0x0000027A
		public new static Rijndael Create()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001920 RID: 6432 RVA: 0x00035CD8 File Offset: 0x00033ED8
		public new static Rijndael Create(string algName)
		{
			if (!true)
			{
			}
			object obj;
			if (obj != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06001921 RID: 6433 RVA: 0x00035CF0 File Offset: 0x00033EF0
		// Note: this type is marked as 'beforefieldinit'.
		static Rijndael()
		{
		}

		// Token: 0x04000CD4 RID: 3284
		private static KeySizes[] s_legalBlockSizes;

		// Token: 0x04000CD5 RID: 3285
		private static KeySizes[] s_legalKeySizes;
	}
}
