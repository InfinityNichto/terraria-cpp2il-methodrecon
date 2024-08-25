using System;
using Cpp2IlInjected;

namespace Mono
{
	// Token: 0x02000018 RID: 24
	internal struct RuntimeGPtrArrayHandle
	{
		// Token: 0x06000056 RID: 86 RVA: 0x00002518 File Offset: 0x00000718
		internal unsafe RuntimeGPtrArrayHandle(IntPtr ptr)
		{
			void* ptr2 = (void*)ptr;
			this.value = (RuntimeStructs.GPtrArray*)ptr2;
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000057 RID: 87 RVA: 0x0000207A File Offset: 0x0000027A
		internal int Length
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700000C RID: 12
		internal IntPtr this[int i]
		{
			get
			{
				return this.Lookup(i);
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000207A File Offset: 0x0000027A
		internal IntPtr Lookup(int i)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002548 File Offset: 0x00000748
		private unsafe static void GPtrArrayFree(RuntimeStructs.GPtrArray* value)
		{
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002558 File Offset: 0x00000758
		internal static void DestroyAndFree(RuntimeGPtrArrayHandle h)
		{
		}

		// Token: 0x04000090 RID: 144
		private unsafe RuntimeStructs.GPtrArray* value;
	}
}
