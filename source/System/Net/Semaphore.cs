using System;
using System.Threading;

namespace System.Net
{
	// Token: 0x020001FD RID: 509
	internal sealed class Semaphore : WaitHandle
	{
		// Token: 0x06000C7C RID: 3196 RVA: 0x00027D70 File Offset: 0x00025F70
		internal Semaphore(int initialCount, int maxCount)
		{
			if (!true)
			{
			}
			long num = 0L;
			base..ctor();
			Monitor.Enter(this, num != 0L);
			if (!true)
			{
			}
			long num2 = 0L;
			Monitor.Exit(this);
			if (num2 == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x00027DC0 File Offset: 0x00025FC0
		internal bool ReleaseSemaphore()
		{
			bool flag;
			return flag;
		}
	}
}
