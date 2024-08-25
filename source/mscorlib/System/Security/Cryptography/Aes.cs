using System;
using System.Runtime.CompilerServices;

namespace System.Security.Cryptography
{
	// Token: 0x020002C3 RID: 707
	[TypeForwardedFrom("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
	public abstract class Aes : SymmetricAlgorithm
	{
		// Token: 0x060017F5 RID: 6133 RVA: 0x0003383C File Offset: 0x00031A3C
		protected Aes()
		{
			if (!true)
			{
			}
		}

		// Token: 0x060017F6 RID: 6134 RVA: 0x00033854 File Offset: 0x00031A54
		public new static Aes Create()
		{
			if (!true)
			{
			}
			return Aes.Create("AES");
		}

		// Token: 0x060017F7 RID: 6135 RVA: 0x00033870 File Offset: 0x00031A70
		public new static Aes Create(string algorithmName)
		{
			object obj;
			while (obj == null)
			{
			}
		}

		// Token: 0x060017F8 RID: 6136 RVA: 0x00033884 File Offset: 0x00031A84
		// Note: this type is marked as 'beforefieldinit'.
		static Aes()
		{
		}

		// Token: 0x04000C75 RID: 3189
		private static KeySizes[] s_legalBlockSizes;

		// Token: 0x04000C76 RID: 3190
		private static KeySizes[] s_legalKeySizes;
	}
}
