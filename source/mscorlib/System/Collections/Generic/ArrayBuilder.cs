using System;
using Cpp2IlInjected;

namespace System.Collections.Generic
{
	// Token: 0x0200063D RID: 1597
	internal struct ArrayBuilder<T>
	{
		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x060030E5 RID: 12517 RVA: 0x0006AB5C File Offset: 0x00068D5C
		public int Capacity
		{
			get
			{
			}
		}

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x060030E6 RID: 12518 RVA: 0x0006AB6C File Offset: 0x00068D6C
		public int Count
		{
			get
			{
				return this._count;
			}
		}

		// Token: 0x170007E4 RID: 2020
		public T this[int index]
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x060030E8 RID: 12520 RVA: 0x0006AB80 File Offset: 0x00068D80
		public void Add(T item)
		{
			int count = this._count;
			int count2 = this._count;
		}

		// Token: 0x060030E9 RID: 12521 RVA: 0x0006AB9C File Offset: 0x00068D9C
		public void UncheckedAdd(T item)
		{
		}

		// Token: 0x060030EA RID: 12522 RVA: 0x0006ABAC File Offset: 0x00068DAC
		private void EnsureCapacity(int minimum)
		{
			int num = Math.Max(0, minimum);
		}

		// Token: 0x04001A7C RID: 6780
		private T[] _array;

		// Token: 0x04001A7D RID: 6781
		private int _count;
	}
}
