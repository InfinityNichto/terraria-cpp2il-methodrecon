using System;
using Cpp2IlInjected;

namespace System.Linq
{
	// Token: 0x02000029 RID: 41
	internal abstract class EnumerableSorter<TElement>
	{
		// Token: 0x06000123 RID: 291
		internal abstract void ComputeKeys(TElement[] elements, int count);

		// Token: 0x06000124 RID: 292
		internal abstract int CompareKeys(int index1, int index2);

		// Token: 0x06000125 RID: 293 RVA: 0x00002050 File Offset: 0x00000250
		internal int[] Sort(TElement[] elements, int count)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00003D6C File Offset: 0x00001F6C
		private void QuickSort(int[] map, int left, int right)
		{
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00003D7C File Offset: 0x00001F7C
		protected EnumerableSorter()
		{
		}
	}
}
