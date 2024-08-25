using System;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	// Token: 0x02000314 RID: 788
	internal class RC2Transform : SymmetricTransform
	{
		// Token: 0x06001AC4 RID: 6852 RVA: 0x00039B88 File Offset: 0x00037D88
		public RC2Transform(RC2 rc2Algo, bool encryption, byte[] key, byte[] iv)
			: base(rc2Algo, encryption, iv)
		{
			if (key == null)
			{
				return;
			}
			object obj;
			if (obj != null && obj == null)
			{
				throw new InvalidCastException();
			}
			if (255 == 0)
			{
			}
		}

		// Token: 0x06001AC5 RID: 6853 RVA: 0x00039BE0 File Offset: 0x00037DE0
		protected override void ECB(byte[] input, byte[] output)
		{
			if (this.encrypt)
			{
				ushort[] k = this.K;
				int num = 20;
				this.j = num;
				this.j = num;
				this.R0 = k;
				this.R0 = k;
				return;
			}
			ushort[] k2 = this.K;
			int num2 = 63;
			this.j = num2;
			this.R3 = (ushort)num2;
			this.R1 = (ushort)num2;
			this.R0 = input;
			int num3 = 43;
			this.j = num3;
			this.R3 = (ushort)num2;
			this.R3 = (ushort)num2;
			this.R1 = input;
			this.j = num3;
			this.R2 = (ushort)num2;
			this.R0 = k2;
			this.R2 = (ushort)num2;
			this.R0 = input;
			this.R0 = k2;
			this.j = num3;
			ushort r = this.R1;
			ushort r2 = this.R2;
			ushort r3 = this.R3;
		}

		// Token: 0x06001AC6 RID: 6854 RVA: 0x00039CB8 File Offset: 0x00037EB8
		// Note: this type is marked as 'beforefieldinit'.
		static RC2Transform()
		{
		}

		// Token: 0x04000DA1 RID: 3489
		private ushort R0;

		// Token: 0x04000DA2 RID: 3490
		private ushort R1;

		// Token: 0x04000DA3 RID: 3491
		private ushort R2;

		// Token: 0x04000DA4 RID: 3492
		private ushort R3;

		// Token: 0x04000DA5 RID: 3493
		private ushort[] K;

		// Token: 0x04000DA6 RID: 3494
		private int j;

		// Token: 0x04000DA7 RID: 3495
		private static readonly byte[] pitable;
	}
}
