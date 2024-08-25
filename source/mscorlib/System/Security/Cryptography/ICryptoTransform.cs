using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	// Token: 0x020002E1 RID: 737
	[ComVisible(true)]
	public interface ICryptoTransform : IDisposable
	{
		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x060018BC RID: 6332
		int InputBlockSize { get; }

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x060018BD RID: 6333
		int OutputBlockSize { get; }

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x060018BE RID: 6334
		bool CanTransformMultipleBlocks { get; }

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x060018BF RID: 6335
		bool CanReuseTransform { get; }

		// Token: 0x060018C0 RID: 6336
		int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset);

		// Token: 0x060018C1 RID: 6337
		byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount);
	}
}
