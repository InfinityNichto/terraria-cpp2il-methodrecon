using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System.Collections.Generic
{
	// Token: 0x0200063F RID: 1599
	internal struct LargeArrayBuilder<T>
	{
		// Token: 0x060030EC RID: 12524 RVA: 0x0006ABD4 File Offset: 0x00068DD4
		public LargeArrayBuilder(bool initialize)
		{
		}

		// Token: 0x060030ED RID: 12525 RVA: 0x0000207A File Offset: 0x0000027A
		public LargeArrayBuilder(int maxCapacity)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060030EE RID: 12526 RVA: 0x0006ABE4 File Offset: 0x00068DE4
		public void AddRange(IEnumerable<T> items)
		{
		}

		// Token: 0x060030EF RID: 12527 RVA: 0x0006AC20 File Offset: 0x00068E20
		private void AddWithBufferAllocation(T item, T[] destination, int index)
		{
			this.AllocateBuffer();
			int index2 = this._index;
			index.m_value = index2;
			int index3 = this._index;
		}

		// Token: 0x060030F0 RID: 12528 RVA: 0x0000207A File Offset: 0x0000027A
		public void CopyTo(T[] array, int arrayIndex, int count)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060030F1 RID: 12529 RVA: 0x0000207A File Offset: 0x0000027A
		public T[] GetBuffer(int index)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060030F2 RID: 12530 RVA: 0x0000207A File Offset: 0x0000027A
		public T[] ToArray()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060030F3 RID: 12531 RVA: 0x0000207A File Offset: 0x0000027A
		public bool TryMove([Out] T[] array)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060030F4 RID: 12532 RVA: 0x0006AC48 File Offset: 0x00068E48
		private void AllocateBuffer()
		{
			int num = 4;
			this._index = num;
			int index = this._index;
		}

		// Token: 0x04001A7E RID: 6782
		private readonly int _maxCapacity;

		// Token: 0x04001A7F RID: 6783
		private T[] _first;

		// Token: 0x04001A80 RID: 6784
		private ArrayBuilder<T[]> _buffers;

		// Token: 0x04001A81 RID: 6785
		private T[] _current;

		// Token: 0x04001A82 RID: 6786
		private int _index;

		// Token: 0x04001A83 RID: 6787
		private int _count;
	}
}
