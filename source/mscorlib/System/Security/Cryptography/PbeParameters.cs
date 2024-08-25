using System;
using System.Runtime.CompilerServices;

namespace System.Security.Cryptography
{
	// Token: 0x0200031F RID: 799
	public sealed class PbeParameters
	{
		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06001B06 RID: 6918 RVA: 0x0003A3C4 File Offset: 0x000385C4
		public PbeEncryptionAlgorithm EncryptionAlgorithm
		{
			[CompilerGenerated]
			get
			{
				return this.<EncryptionAlgorithm>k__BackingField;
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06001B07 RID: 6919 RVA: 0x0003A3D8 File Offset: 0x000385D8
		public HashAlgorithmName HashAlgorithm
		{
			[CompilerGenerated]
			get
			{
				return this.<HashAlgorithm>k__BackingField;
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06001B08 RID: 6920 RVA: 0x0003A3EC File Offset: 0x000385EC
		public int IterationCount
		{
			[CompilerGenerated]
			get
			{
				return this.<IterationCount>k__BackingField;
			}
		}

		// Token: 0x06001B09 RID: 6921 RVA: 0x0003A400 File Offset: 0x00038600
		public PbeParameters(PbeEncryptionAlgorithm encryptionAlgorithm, HashAlgorithmName hashAlgorithm, int iterationCount)
		{
			this.EncryptionAlgorithm = encryptionAlgorithm;
			this.HashAlgorithm = hashAlgorithm;
			this.IterationCount = iterationCount;
		}

		// Token: 0x04000DC1 RID: 3521
		[CompilerGenerated]
		private readonly PbeEncryptionAlgorithm <EncryptionAlgorithm>k__BackingField;

		// Token: 0x04000DC2 RID: 3522
		[CompilerGenerated]
		private readonly HashAlgorithmName <HashAlgorithm>k__BackingField;

		// Token: 0x04000DC3 RID: 3523
		[CompilerGenerated]
		private readonly int <IterationCount>k__BackingField;
	}
}
