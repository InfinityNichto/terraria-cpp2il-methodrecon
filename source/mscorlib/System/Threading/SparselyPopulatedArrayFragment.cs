using System;
using Cpp2IlInjected;

namespace System.Threading
{
	// Token: 0x020001DB RID: 475
	internal class SparselyPopulatedArrayFragment<T> where T : class
	{
		// Token: 0x06001135 RID: 4405 RVA: 0x00024628 File Offset: 0x00022828
		internal SparselyPopulatedArrayFragment(int size)
		{
		}

		// Token: 0x06001136 RID: 4406 RVA: 0x00024638 File Offset: 0x00022838
		internal SparselyPopulatedArrayFragment(int size, SparselyPopulatedArrayFragment<T> prev)
		{
			this._elements = this;
			this._freeCount = size;
		}

		// Token: 0x1700019A RID: 410
		internal T this[int index]
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06001138 RID: 4408 RVA: 0x0000207A File Offset: 0x0000027A
		internal int Length
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06001139 RID: 4409 RVA: 0x0002465C File Offset: 0x0002285C
		internal SparselyPopulatedArrayFragment<T> Prev
		{
			get
			{
				return this;
			}
		}

		// Token: 0x0600113A RID: 4410 RVA: 0x0000207A File Offset: 0x0000027A
		internal T SafeAtomicRemove(int index, T expectedElement)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x04000947 RID: 2375
		internal readonly T[] _elements;

		// Token: 0x04000948 RID: 2376
		internal int _freeCount;

		// Token: 0x04000949 RID: 2377
		internal SparselyPopulatedArrayFragment<T> _next;

		// Token: 0x0400094A RID: 2378
		internal SparselyPopulatedArrayFragment<T> _prev;
	}
}
