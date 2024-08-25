using System;
using System.Collections.Generic;
using System.Threading;
using Cpp2IlInjected;

namespace Terraria.ID
{
	// Token: 0x020005EE RID: 1518
	public class SetFactory
	{
		// Token: 0x0600357E RID: 13694 RVA: 0x00210F38 File Offset: 0x0020F138
		public SetFactory(int size)
		{
			do
			{
				base..ctor();
			}
			while (size == 0);
			this._size = size;
		}

		// Token: 0x0600357F RID: 13695 RVA: 0x00210F58 File Offset: 0x0020F158
		protected bool[] GetBoolBuffer()
		{
			object queueLock = this._queueLock;
			Queue<bool[]> boolBufferCache = this._boolBufferCache;
			if (boolBufferCache._size != 0)
			{
				return boolBufferCache.Dequeue();
			}
			int size = this._size;
			long num = 0L;
			Monitor.Exit(queueLock);
			if (num == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06003580 RID: 13696 RVA: 0x00210FB8 File Offset: 0x0020F1B8
		protected int[] GetIntBuffer()
		{
			object queueLock = this._queueLock;
			Queue<int[]> intBufferCache = this._intBufferCache;
			if (intBufferCache._size != 0)
			{
				return intBufferCache.Dequeue();
			}
			int size = this._size;
			long num = 0L;
			Monitor.Exit(queueLock);
			if (num == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06003581 RID: 13697 RVA: 0x00211018 File Offset: 0x0020F218
		protected ushort[] GetUshortBuffer()
		{
			object queueLock = this._queueLock;
			Queue<ushort[]> ushortBufferCache = this._ushortBufferCache;
			if (ushortBufferCache._size != 0)
			{
				return ushortBufferCache.Dequeue();
			}
			int size = this._size;
			long num = 0L;
			Monitor.Exit(queueLock);
			if (num == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06003582 RID: 13698 RVA: 0x00211078 File Offset: 0x0020F278
		protected float[] GetFloatBuffer()
		{
			object queueLock = this._queueLock;
			Queue<float[]> floatBufferCache = this._floatBufferCache;
			if (floatBufferCache._size != 0)
			{
				return floatBufferCache.Dequeue();
			}
			int size = this._size;
			long num = 0L;
			Monitor.Exit(queueLock);
			if (num == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06003583 RID: 13699 RVA: 0x002110D8 File Offset: 0x0020F2D8
		public void Recycle<T>(T[] buffer)
		{
			object queueLock = this._queueLock;
			Queue<bool[]> boolBufferCache = this._boolBufferCache;
			if (buffer != null && buffer == null)
			{
				throw new InvalidCastException();
			}
		}

		// Token: 0x06003584 RID: 13700 RVA: 0x00211150 File Offset: 0x0020F350
		public bool[] CreateBoolSet(params int[] types)
		{
			long num = 0L;
			return this.CreateBoolSet(num != 0L, types);
		}

		// Token: 0x06003585 RID: 13701 RVA: 0x00211168 File Offset: 0x0020F368
		public bool[] CreateBoolSet(bool defaultState, params int[] types)
		{
			return this.GetBoolBuffer();
		}

		// Token: 0x06003586 RID: 13702 RVA: 0x00211180 File Offset: 0x0020F380
		public int[] CreateIntSet(params int[] types)
		{
			int[] array;
			return array;
		}

		// Token: 0x06003587 RID: 13703 RVA: 0x00211190 File Offset: 0x0020F390
		public int[] CreateIntSet(int defaultState, params int[] inputs)
		{
			return this.GetIntBuffer();
		}

		// Token: 0x06003588 RID: 13704 RVA: 0x002111AC File Offset: 0x0020F3AC
		public ushort[] CreateUshortSet(ushort defaultState, params ushort[] inputs)
		{
			return this.GetUshortBuffer();
		}

		// Token: 0x06003589 RID: 13705 RVA: 0x002111C8 File Offset: 0x0020F3C8
		public float[] CreateFloatSet(float defaultState, params float[] inputs)
		{
			return this.GetFloatBuffer();
		}

		// Token: 0x0600358A RID: 13706 RVA: 0x000021DB File Offset: 0x000003DB
		public T[] CreateCustomSet<T>(T defaultState, params object[] inputs)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x04006DB1 RID: 28081
		protected int _size;

		// Token: 0x04006DB2 RID: 28082
		private readonly Queue<int[]> _intBufferCache;

		// Token: 0x04006DB3 RID: 28083
		private readonly Queue<ushort[]> _ushortBufferCache;

		// Token: 0x04006DB4 RID: 28084
		private readonly Queue<bool[]> _boolBufferCache;

		// Token: 0x04006DB5 RID: 28085
		private readonly Queue<float[]> _floatBufferCache;

		// Token: 0x04006DB6 RID: 28086
		private object _queueLock;
	}
}
