using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	// Token: 0x020002E5 RID: 741
	[ComVisible(true)]
	public abstract class MaskGenerationMethod
	{
		// Token: 0x060018E0 RID: 6368
		[ComVisible(true)]
		public abstract byte[] GenerateMask(byte[] rgbSeed, int cbReturn);

		// Token: 0x060018E1 RID: 6369 RVA: 0x00035520 File Offset: 0x00033720
		protected MaskGenerationMethod()
		{
		}
	}
}
