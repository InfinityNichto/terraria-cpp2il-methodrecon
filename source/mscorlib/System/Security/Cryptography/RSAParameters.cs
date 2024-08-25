using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	// Token: 0x020002F2 RID: 754
	[ComVisible(true)]
	[Serializable]
	public struct RSAParameters
	{
		// Token: 0x04000CF5 RID: 3317
		public byte[] Exponent;

		// Token: 0x04000CF6 RID: 3318
		public byte[] Modulus;

		// Token: 0x04000CF7 RID: 3319
		[NonSerialized]
		public byte[] P;

		// Token: 0x04000CF8 RID: 3320
		[NonSerialized]
		public byte[] Q;

		// Token: 0x04000CF9 RID: 3321
		[NonSerialized]
		public byte[] DP;

		// Token: 0x04000CFA RID: 3322
		[NonSerialized]
		public byte[] DQ;

		// Token: 0x04000CFB RID: 3323
		[NonSerialized]
		public byte[] InverseQ;

		// Token: 0x04000CFC RID: 3324
		[NonSerialized]
		public byte[] D;
	}
}
