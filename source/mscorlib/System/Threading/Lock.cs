using System;

namespace System.Threading
{
	// Token: 0x020001DD RID: 477
	public class Lock
	{
		// Token: 0x0600113D RID: 4413 RVA: 0x0002467C File Offset: 0x0002287C
		public void Acquire()
		{
			object @lock = this._lock;
		}

		// Token: 0x0600113E RID: 4414 RVA: 0x00024690 File Offset: 0x00022890
		public void Release()
		{
			object @lock = this._lock;
		}

		// Token: 0x0600113F RID: 4415 RVA: 0x000246A4 File Offset: 0x000228A4
		public Lock()
		{
		}

		// Token: 0x0400094C RID: 2380
		private object _lock;
	}
}
