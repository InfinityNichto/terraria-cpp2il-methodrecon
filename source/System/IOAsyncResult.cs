using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace System
{
	// Token: 0x0200009B RID: 155
	[StructLayout(0)]
	internal abstract class IOAsyncResult : IAsyncResult
	{
		// Token: 0x060002B6 RID: 694 RVA: 0x0000A968 File Offset: 0x00008B68
		protected IOAsyncResult()
		{
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0000A97C File Offset: 0x00008B7C
		protected void Init(AsyncCallback async_callback, object async_state)
		{
			ManualResetEvent manualResetEvent = this.wait_handle;
			this.async_callback = async_callback;
			this.async_state = async_state;
			if (manualResetEvent != null)
			{
				bool flag = manualResetEvent.Reset();
				return;
			}
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0000A9AC File Offset: 0x00008BAC
		protected IOAsyncResult(AsyncCallback async_callback, object async_state)
		{
			this.async_callback = async_callback;
			this.async_state = async_state;
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060002B9 RID: 697 RVA: 0x0000A9D0 File Offset: 0x00008BD0
		public AsyncCallback AsyncCallback
		{
			get
			{
				return this.async_callback;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060002BA RID: 698 RVA: 0x0000A9E4 File Offset: 0x00008BE4
		public object AsyncState
		{
			get
			{
				return this.async_state;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060002BB RID: 699 RVA: 0x0000A9F8 File Offset: 0x00008BF8
		public WaitHandle AsyncWaitHandle
		{
			get
			{
				if (this.wait_handle != null)
				{
				}
				bool flag = this.completed;
				long num = 0L;
				Monitor.Exit(this);
				if (num == 0L)
				{
				}
				throw new OutOfMemoryException();
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060002BC RID: 700 RVA: 0x0000AA40 File Offset: 0x00008C40
		// (set) Token: 0x060002BD RID: 701 RVA: 0x0000AA54 File Offset: 0x00008C54
		public bool CompletedSynchronously
		{
			get
			{
				return this.completed_synchronously;
			}
			protected set
			{
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060002BE RID: 702 RVA: 0x0000AA64 File Offset: 0x00008C64
		// (set) Token: 0x060002BF RID: 703 RVA: 0x0000AA78 File Offset: 0x00008C78
		public bool IsCompleted
		{
			get
			{
				return this.completed;
			}
			protected set
			{
				Monitor.Enter(this, value);
				ManualResetEvent manualResetEvent = this.wait_handle;
				if (manualResetEvent != null)
				{
					bool flag = manualResetEvent.Set();
					return;
				}
				long num = 0L;
				Monitor.Exit(this);
				if (num == 0L)
				{
					return;
				}
				throw new OutOfMemoryException();
			}
		}

		// Token: 0x060002C0 RID: 704
		internal abstract void CompleteDisposed();

		// Token: 0x04000268 RID: 616
		private AsyncCallback async_callback;

		// Token: 0x04000269 RID: 617
		private object async_state;

		// Token: 0x0400026A RID: 618
		private ManualResetEvent wait_handle;

		// Token: 0x0400026B RID: 619
		private bool completed_synchronously;

		// Token: 0x0400026C RID: 620
		private bool completed;
	}
}
