using System;
using System.Diagnostics;
using Cpp2IlInjected;

namespace System.Collections.Generic
{
	// Token: 0x0200064B RID: 1611
	[DebuggerDisplay("Count = {Count}")]
	internal class LowLevelList<T>
	{
		// Token: 0x0600312F RID: 12591 RVA: 0x0006B0D8 File Offset: 0x000692D8
		public LowLevelList()
		{
		}

		// Token: 0x06003130 RID: 12592 RVA: 0x0006B0EC File Offset: 0x000692EC
		public LowLevelList(int capacity)
		{
			if (capacity != 0)
			{
				this._items = this;
				return;
			}
		}

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x06003131 RID: 12593 RVA: 0x0000207A File Offset: 0x0000027A
		// (set) Token: 0x06003132 RID: 12594 RVA: 0x0000207A File Offset: 0x0000027A
		public int Capacity
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x06003133 RID: 12595 RVA: 0x0006B10C File Offset: 0x0006930C
		public int Count
		{
			get
			{
				return this._size;
			}
		}

		// Token: 0x170007F2 RID: 2034
		public T this[int index]
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06003136 RID: 12598 RVA: 0x0000207A File Offset: 0x0000027A
		public void Add(T item)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003137 RID: 12599 RVA: 0x0000207A File Offset: 0x0000027A
		private void EnsureCapacity(int min)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003138 RID: 12600 RVA: 0x0006B120 File Offset: 0x00069320
		public void AddRange(IEnumerable<T> collection)
		{
			int size = this._size;
		}

		// Token: 0x06003139 RID: 12601 RVA: 0x0000207A File Offset: 0x0000027A
		public void Clear()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600313A RID: 12602 RVA: 0x0000207A File Offset: 0x0000027A
		public bool Contains(T item)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600313B RID: 12603 RVA: 0x0000207A File Offset: 0x0000027A
		public void CopyTo(T[] array, int arrayIndex)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600313C RID: 12604 RVA: 0x0000207A File Offset: 0x0000027A
		public int IndexOf(T item)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600313D RID: 12605 RVA: 0x0000207A File Offset: 0x0000027A
		public void Insert(int index, T item)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600313E RID: 12606 RVA: 0x0000207A File Offset: 0x0000027A
		public void InsertRange(int index, IEnumerable<T> collection)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600313F RID: 12607 RVA: 0x0006B134 File Offset: 0x00069334
		public bool Remove(T item)
		{
			return true;
		}

		// Token: 0x06003140 RID: 12608 RVA: 0x0000207A File Offset: 0x0000027A
		public int RemoveAll(Predicate<T> match)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003141 RID: 12609 RVA: 0x0000207A File Offset: 0x0000027A
		public void RemoveAt(int index)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003142 RID: 12610 RVA: 0x0006B144 File Offset: 0x00069344
		// Note: this type is marked as 'beforefieldinit'.
		static LowLevelList()
		{
		}

		// Token: 0x04001A9D RID: 6813
		protected T[] _items;

		// Token: 0x04001A9E RID: 6814
		protected int _size;

		// Token: 0x04001A9F RID: 6815
		protected int _version;

		// Token: 0x04001AA0 RID: 6816
		private static readonly T[] s_emptyArray;
	}
}
