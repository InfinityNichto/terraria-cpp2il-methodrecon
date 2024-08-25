using System;

namespace Mono.Math.Prime.Generator
{
	// Token: 0x02000056 RID: 86
	internal abstract class PrimeGeneratorBase
	{
		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000207 RID: 519 RVA: 0x00007FA0 File Offset: 0x000061A0
		public virtual ConfidenceFactor Confidence
		{
			get
			{
				return ConfidenceFactor.Medium;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000208 RID: 520 RVA: 0x00007FB0 File Offset: 0x000061B0
		public virtual PrimalityTest PrimalityTest
		{
			get
			{
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000209 RID: 521 RVA: 0x00007FC0 File Offset: 0x000061C0
		public virtual int TrialDivisionBounds
		{
			get
			{
				return 4000;
			}
		}

		// Token: 0x0600020A RID: 522
		public abstract BigInteger GenerateNewPrime(int bits);

		// Token: 0x0600020B RID: 523 RVA: 0x00007FD4 File Offset: 0x000061D4
		protected PrimeGeneratorBase()
		{
		}
	}
}
