using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System.Buffers
{
	// Token: 0x02000664 RID: 1636
	public struct MemoryHandle : IDisposable
	{
		// Token: 0x060031C9 RID: 12745 RVA: 0x0006BB0C File Offset: 0x00069D0C
		[CLSCompliant(false)]
		public unsafe MemoryHandle(void* pointer, [Optional] GCHandle handle, [Optional] IPinnable pinnable)
		{
			this._pointer = pointer;
			this._handle = handle;
			this._pinnable = pinnable;
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x060031CA RID: 12746 RVA: 0x0000207A File Offset: 0x0000027A
		[CLSCompliant(false)]
		public unsafe void* Pointer
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x060031CB RID: 12747 RVA: 0x0006BB30 File Offset: 0x00069D30
		public void Dispose()
		{
			if (this._pinnable != null)
			{
				return;
			}
		}

		// Token: 0x04001AAF RID: 6831
		private unsafe void* _pointer;

		// Token: 0x04001AB0 RID: 6832
		private GCHandle _handle;

		// Token: 0x04001AB1 RID: 6833
		private IPinnable _pinnable;
	}
}
