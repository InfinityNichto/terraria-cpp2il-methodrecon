using System;
using Cpp2IlInjected;

namespace Terraria.DataStructures
{
	// Token: 0x0200061E RID: 1566
	public class DoubleStack<T1>
	{
		// Token: 0x060035D1 RID: 13777 RVA: 0x000021DB File Offset: 0x000003DB
		public DoubleStack(int segmentSize = 1024, int initialSize = 0)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060035D2 RID: 13778 RVA: 0x000021DB File Offset: 0x000003DB
		public void PushFront(T1 front)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060035D3 RID: 13779 RVA: 0x000021DB File Offset: 0x000003DB
		public T1 PopFront()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060035D4 RID: 13780 RVA: 0x000021DB File Offset: 0x000003DB
		public T1 PeekFront()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060035D5 RID: 13781 RVA: 0x000021DB File Offset: 0x000003DB
		public void PushBack(T1 back)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060035D6 RID: 13782 RVA: 0x000021DB File Offset: 0x000003DB
		public T1 PopBack()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060035D7 RID: 13783 RVA: 0x000021DB File Offset: 0x000003DB
		public T1 PeekBack()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060035D8 RID: 13784 RVA: 0x000021DB File Offset: 0x000003DB
		public void Clear(bool quickClear = false)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x060035D9 RID: 13785 RVA: 0x00211AC8 File Offset: 0x0020FCC8
		public int Count
		{
			get
			{
				return this._size;
			}
		}

		// Token: 0x040076A5 RID: 30373
		private T1[][] _segmentList;

		// Token: 0x040076A6 RID: 30374
		private readonly int _segmentSize;

		// Token: 0x040076A7 RID: 30375
		private int _segmentCount;

		// Token: 0x040076A8 RID: 30376
		private readonly int _segmentShiftPosition;

		// Token: 0x040076A9 RID: 30377
		private int _start;

		// Token: 0x040076AA RID: 30378
		private int _end;

		// Token: 0x040076AB RID: 30379
		private int _size;

		// Token: 0x040076AC RID: 30380
		private int _last;
	}
}
