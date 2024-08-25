using System;

namespace Mono.Math.Prime.Generator
{
	// Token: 0x02000069 RID: 105
	public abstract class PrimeGeneratorBase
	{
		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060002F3 RID: 755 RVA: 0x0000BDC0 File Offset: 0x00009FC0
		public virtual ConfidenceFactor Confidence
		{
			get
			{
				return ConfidenceFactor.Medium;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x0000BDD0 File Offset: 0x00009FD0
		public virtual PrimalityTest PrimalityTest
		{
			get
			{
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x0000BDE0 File Offset: 0x00009FE0
		public virtual int TrialDivisionBounds
		{
			get
			{
				return 4000;
			}
		}

		// Token: 0x060002F6 RID: 758
		public abstract BigInteger GenerateNewPrime(int bits);

		// Token: 0x060002F7 RID: 759 RVA: 0x0000BDF4 File Offset: 0x00009FF4
		protected PrimeGeneratorBase()
		{
		}
	}
}
