using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System.Security.Cryptography
{
	// Token: 0x0200030E RID: 782
	[ComVisible(true)]
	public sealed class CryptoAPITransform : ICryptoTransform, IDisposable
	{
		// Token: 0x06001A6B RID: 6763 RVA: 0x00038A2C File Offset: 0x00036C2C
		internal CryptoAPITransform()
		{
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06001A6C RID: 6764 RVA: 0x00038A40 File Offset: 0x00036C40
		public bool CanReuseTransform
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06001A6D RID: 6765 RVA: 0x00038A50 File Offset: 0x00036C50
		public bool CanTransformMultipleBlocks
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06001A6E RID: 6766 RVA: 0x00038A60 File Offset: 0x00036C60
		public int InputBlockSize
		{
			get
			{
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06001A6F RID: 6767 RVA: 0x0000207A File Offset: 0x0000027A
		public IntPtr KeyHandle
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06001A70 RID: 6768 RVA: 0x00038A70 File Offset: 0x00036C70
		public int OutputBlockSize
		{
			get
			{
			}
		}

		// Token: 0x06001A71 RID: 6769 RVA: 0x00038A80 File Offset: 0x00036C80
		public void Dispose()
		{
			if (!this.m_disposed)
			{
				this.m_disposed = true;
			}
		}

		// Token: 0x06001A72 RID: 6770 RVA: 0x00038A9C File Offset: 0x00036C9C
		public void Clear()
		{
			if (this.m_disposed)
			{
				return;
			}
			this.m_disposed = true;
		}

		// Token: 0x06001A73 RID: 6771 RVA: 0x00038ABC File Offset: 0x00036CBC
		private void Dispose(bool disposing)
		{
			if (this.m_disposed)
			{
				return;
			}
			this.m_disposed = true;
		}

		// Token: 0x06001A74 RID: 6772 RVA: 0x00038ADC File Offset: 0x00036CDC
		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
		}

		// Token: 0x06001A75 RID: 6773 RVA: 0x00038AEC File Offset: 0x00036CEC
		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
		}

		// Token: 0x06001A76 RID: 6774 RVA: 0x00038AFC File Offset: 0x00036CFC
		[ComVisible(false)]
		public void Reset()
		{
		}

		// Token: 0x04000D80 RID: 3456
		private bool m_disposed;
	}
}
