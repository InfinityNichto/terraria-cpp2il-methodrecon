using System;
using Cpp2IlInjected;

namespace Mono
{
	// Token: 0x02000027 RID: 39
	internal struct SafeGPtrArrayHandle : IDisposable
	{
		// Token: 0x06000062 RID: 98 RVA: 0x000025B0 File Offset: 0x000007B0
		internal unsafe SafeGPtrArrayHandle(IntPtr ptr)
		{
			void* ptr2 = (void*)ptr;
			this.handle = ptr2;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000025CC File Offset: 0x000007CC
		public void Dispose()
		{
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000064 RID: 100 RVA: 0x0000207A File Offset: 0x0000027A
		internal int Length
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700000E RID: 14
		internal IntPtr this[int i]
		{
			get
			{
				IntPtr intPtr;
				return intPtr;
			}
		}

		// Token: 0x040000BA RID: 186
		private RuntimeGPtrArrayHandle handle;
	}
}
