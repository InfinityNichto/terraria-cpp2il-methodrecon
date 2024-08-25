using System;
using System.Threading;

namespace InControl.Internal
{
	// Token: 0x02000075 RID: 117
	public class RingBuffer<T>
	{
		// Token: 0x06000570 RID: 1392 RVA: 0x00010D7C File Offset: 0x0000EF7C
		public RingBuffer(int size)
		{
			this.size = size;
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x00010D98 File Offset: 0x0000EF98
		public void Enqueue(T value)
		{
			int num = this.size;
			int num2 = this.tail;
			object obj = this.sync;
			this.tail = num2;
			this.sync = num;
			long num3 = 0L;
			if (num2 != 0)
			{
				Monitor.Exit(this);
			}
			if (num3 == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x00010DFC File Offset: 0x0000EFFC
		public T Dequeue()
		{
			int num = this.size;
			object obj = this.sync;
			int num2 = this.tail;
			this.sync = obj;
			long num3 = 0L;
			if (obj != null)
			{
				Monitor.Exit(this);
			}
			if (num3 == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0400040C RID: 1036
		private readonly int size;

		// Token: 0x0400040D RID: 1037
		private readonly T[] data;

		// Token: 0x0400040E RID: 1038
		private int head;

		// Token: 0x0400040F RID: 1039
		private int tail;

		// Token: 0x04000410 RID: 1040
		private readonly object sync;
	}
}
