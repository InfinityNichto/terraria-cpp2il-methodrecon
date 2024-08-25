using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;

namespace InControl
{
	// Token: 0x0200006F RID: 111
	internal class ThreadSafeQueue<T>
	{
		// Token: 0x06000511 RID: 1297 RVA: 0x0000FF88 File Offset: 0x0000E188
		public ThreadSafeQueue()
		{
			this.data = 1;
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x0000FFA4 File Offset: 0x0000E1A4
		public ThreadSafeQueue(int capacity)
		{
			this.data = 1;
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x0000FFC0 File Offset: 0x0000E1C0
		public void Enqueue(T item)
		{
			object obj = this.sync;
			Queue queue = this.data;
			long num = 0L;
			Monitor.Exit(obj);
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00010004 File Offset: 0x0000E204
		public bool Dequeue([Out] T item)
		{
			object obj = this.sync;
			Queue queue = this.data;
			Queue queue2 = this.data;
			long num = 0L;
			Monitor.Exit(obj);
			if (num == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00010050 File Offset: 0x0000E250
		public T Dequeue()
		{
			object obj = this.sync;
			Queue queue = this.data;
			Queue queue2 = this.data;
			long num = 0L;
			Monitor.Exit(obj);
			if (num == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00010098 File Offset: 0x0000E298
		public int Dequeue(IList<T> list)
		{
			object obj = this.sync;
			Queue queue = this.data;
			Queue queue2 = this.data;
			long num = 0L;
			Monitor.Exit(obj);
			if (num == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x040003F9 RID: 1017
		private object sync;

		// Token: 0x040003FA RID: 1018
		private Queue<T> data;
	}
}
