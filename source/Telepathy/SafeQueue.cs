using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;

namespace Telepathy
{
	// Token: 0x02000316 RID: 790
	public class SafeQueue<T>
	{
		// Token: 0x170001CF RID: 463
		// (get) Token: 0x0600126E RID: 4718 RVA: 0x00059AC0 File Offset: 0x00057CC0
		public int Count
		{
			get
			{
				Queue queue = this.queue;
				Queue queue2 = this.queue;
				long num = 0L;
				Monitor.Exit(queue);
				if (num == 0L)
				{
				}
				throw new OutOfMemoryException();
			}
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x00059B08 File Offset: 0x00057D08
		public void Enqueue(T item)
		{
			Queue queue = this.queue;
			Queue queue2 = this.queue;
			long num = 0L;
			Monitor.Exit(queue);
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x00059B54 File Offset: 0x00057D54
		public bool TryDequeue([Out] T result)
		{
			Queue queue = this.queue;
			Queue queue2 = this.queue;
			Queue queue3 = this.queue;
			long num = 0L;
			Monitor.Exit(queue);
			if (num == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001271 RID: 4721 RVA: 0x00059BA8 File Offset: 0x00057DA8
		public bool TryDequeueAll([Out] T[] result)
		{
			Queue queue = this.queue;
			Queue queue2 = this.queue;
			Queue queue3 = this.queue;
			long num = 0L;
			Monitor.Exit(queue);
			if (num == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001272 RID: 4722 RVA: 0x00059BF8 File Offset: 0x00057DF8
		public void Clear()
		{
			Queue queue = this.queue;
			Queue queue2 = this.queue;
			long num = 0L;
			Monitor.Exit(queue);
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001273 RID: 4723 RVA: 0x00059C44 File Offset: 0x00057E44
		public SafeQueue()
		{
			this.queue = this;
			base..ctor();
		}

		// Token: 0x04002208 RID: 8712
		private Queue<T> queue;
	}
}
