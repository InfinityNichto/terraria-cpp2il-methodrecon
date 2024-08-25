using System;
using Cpp2IlInjected;

namespace System.Threading
{
	// Token: 0x020001DA RID: 474
	internal struct SparselyPopulatedArrayAddInfo<T> where T : class
	{
		// Token: 0x06001132 RID: 4402 RVA: 0x000245F8 File Offset: 0x000227F8
		internal SparselyPopulatedArrayAddInfo(SparselyPopulatedArrayFragment<T> source, int index)
		{
			this._source = source;
			this._index = index;
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06001133 RID: 4403 RVA: 0x0000207A File Offset: 0x0000027A
		internal SparselyPopulatedArrayFragment<T> Source
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06001134 RID: 4404 RVA: 0x00024614 File Offset: 0x00022814
		internal int Index
		{
			get
			{
				return this._index;
			}
		}

		// Token: 0x04000945 RID: 2373
		private SparselyPopulatedArrayFragment<T> _source;

		// Token: 0x04000946 RID: 2374
		private int _index;
	}
}
