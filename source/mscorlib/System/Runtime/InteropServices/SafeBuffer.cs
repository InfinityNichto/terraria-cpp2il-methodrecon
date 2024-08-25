using System;
using Cpp2IlInjected;
using Microsoft.Win32.SafeHandles;

namespace System.Runtime.InteropServices
{
	// Token: 0x02000433 RID: 1075
	public abstract class SafeBuffer : SafeHandleZeroOrMinusOneIsInvalid
	{
		// Token: 0x0600215A RID: 8538 RVA: 0x0004BEE0 File Offset: 0x0004A0E0
		[CLSCompliant(false)]
		public unsafe void AcquirePointer(byte* pointer)
		{
			UIntPtr numBytes = this._numBytes;
			if (!true)
			{
			}
			bool flag = numBytes == 0;
			base.DangerousAddRef(false);
			void* ptr = (void*)this.handle;
			pointer->m_value = ptr;
		}

		// Token: 0x0600215B RID: 8539 RVA: 0x0004BF20 File Offset: 0x0004A120
		public void ReleasePointer()
		{
			UIntPtr numBytes = this._numBytes;
			if (!true)
			{
			}
			long num = 0L;
			base.DangerousReleaseInternal(num != 0L);
		}

		// Token: 0x0600215C RID: 8540 RVA: 0x0000207A File Offset: 0x0000027A
		private static InvalidOperationException NotInitialized()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600215D RID: 8541 RVA: 0x0004BF48 File Offset: 0x0004A148
		// Note: this type is marked as 'beforefieldinit'.
		static SafeBuffer()
		{
			if (!true)
			{
			}
			int size = UIntPtr.Size;
			UIntPtr uintPtr = (UIntPtr)((uint)(-1073741824));
		}

		// Token: 0x040011F7 RID: 4599
		private static readonly UIntPtr Uninitialized;

		// Token: 0x040011F8 RID: 4600
		private UIntPtr _numBytes;
	}
}
