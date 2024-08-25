using System;
using Cpp2IlInjected;

namespace System.Collections.Generic
{
	// Token: 0x02000650 RID: 1616
	internal class ArraySortHelper<TKey, TValue>
	{
		// Token: 0x06003160 RID: 12640 RVA: 0x0006B39C File Offset: 0x0006959C
		public void Sort(TKey[] keys, TValue[] values, int index, int length, IComparer<TKey> comparer)
		{
			if (comparer != null)
			{
			}
		}

		// Token: 0x06003161 RID: 12641 RVA: 0x0006B3C0 File Offset: 0x000695C0
		private static void SwapIfGreaterWithItems(TKey[] keys, TValue[] values, IComparer<TKey> comparer, int a, int b)
		{
		}

		// Token: 0x06003162 RID: 12642 RVA: 0x0006B3D0 File Offset: 0x000695D0
		private static void Swap(TKey[] keys, TValue[] values, int i, int j)
		{
		}

		// Token: 0x06003163 RID: 12643 RVA: 0x0006B3E0 File Offset: 0x000695E0
		internal static void IntrospectiveSort(TKey[] keys, TValue[] values, int left, int length, IComparer<TKey> comparer)
		{
		}

		// Token: 0x06003164 RID: 12644 RVA: 0x0006B3F8 File Offset: 0x000695F8
		private static void IntroSort(TKey[] keys, TValue[] values, int lo, int hi, int depthLimit, IComparer<TKey> comparer)
		{
		}

		// Token: 0x06003165 RID: 12645 RVA: 0x0006B424 File Offset: 0x00069624
		private static int PickPivotAndPartition(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer)
		{
			return hi;
		}

		// Token: 0x06003166 RID: 12646 RVA: 0x0006B450 File Offset: 0x00069650
		private static void Heapsort(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer)
		{
		}

		// Token: 0x06003167 RID: 12647 RVA: 0x0006B464 File Offset: 0x00069664
		private static void DownHeap(TKey[] keys, TValue[] values, int i, int n, int lo, IComparer<TKey> comparer)
		{
		}

		// Token: 0x06003168 RID: 12648 RVA: 0x0006B474 File Offset: 0x00069674
		private static void InsertionSort(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer)
		{
		}

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x06003169 RID: 12649 RVA: 0x0000207A File Offset: 0x0000027A
		public static ArraySortHelper<TKey, TValue> Default
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x0600316A RID: 12650 RVA: 0x0006B484 File Offset: 0x00069684
		public ArraySortHelper()
		{
		}

		// Token: 0x0600316B RID: 12651 RVA: 0x0006B498 File Offset: 0x00069698
		// Note: this type is marked as 'beforefieldinit'.
		static ArraySortHelper()
		{
		}

		// Token: 0x04001AA6 RID: 6822
		private static readonly ArraySortHelper<TKey, TValue> s_defaultArraySortHelper;
	}
}
