using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	// Token: 0x020002D6 RID: 726
	[ComVisible(true)]
	[Serializable]
	public struct DSAParameters
	{
		// Token: 0x04000CA5 RID: 3237
		public byte[] P;

		// Token: 0x04000CA6 RID: 3238
		public byte[] Q;

		// Token: 0x04000CA7 RID: 3239
		public byte[] G;

		// Token: 0x04000CA8 RID: 3240
		public byte[] Y;

		// Token: 0x04000CA9 RID: 3241
		public byte[] J;

		// Token: 0x04000CAA RID: 3242
		[NonSerialized]
		public byte[] X;

		// Token: 0x04000CAB RID: 3243
		public byte[] Seed;

		// Token: 0x04000CAC RID: 3244
		public int Counter;
	}
}
