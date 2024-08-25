using System;
using System.Diagnostics;

namespace System.Threading
{
	// Token: 0x020001C8 RID: 456
	[DebuggerDisplay("Initial Count={InitialCount}, Current Count={CurrentCount}")]
	public class CountdownEvent
	{
		// Token: 0x060010CC RID: 4300 RVA: 0x00023998 File Offset: 0x00021B98
		public bool Signal()
		{
			this.ThrowIfDisposed();
			int currentCount = this._currentCount;
			int num;
			if (num != 0)
			{
			}
			ManualResetEventSlim @event = this._event;
			long num2 = 0L;
			@event.Set(num2 != 0L);
			return true;
		}

		// Token: 0x060010CD RID: 4301 RVA: 0x000239CC File Offset: 0x00021BCC
		private void ThrowIfDisposed()
		{
			while (this._disposed)
			{
			}
		}

		// Token: 0x04000915 RID: 2325
		private int _currentCount;

		// Token: 0x04000916 RID: 2326
		private ManualResetEventSlim _event;

		// Token: 0x04000917 RID: 2327
		private bool _disposed;
	}
}
