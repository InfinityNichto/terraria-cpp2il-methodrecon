using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace System
{
	// Token: 0x0200009C RID: 156
	[StructLayout(0)]
	internal class IOSelectorJob : IThreadPoolWorkItem
	{
		// Token: 0x060002C1 RID: 705 RVA: 0x0000AACC File Offset: 0x00008CCC
		public IOSelectorJob(global::System.IOOperation operation, global::System.IOAsyncCallback callback, global::System.IOAsyncResult state)
		{
			this.operation = operation;
			this.callback = callback;
			this.state = state;
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0000AAF4 File Offset: 0x00008CF4
		void IThreadPoolWorkItem.ExecuteWorkItem()
		{
			global::System.IOAsyncCallback ioasyncCallback = this.callback;
			global::System.IOAsyncResult ioasyncResult = this.state;
			IntPtr invoke_impl = ioasyncCallback.invoke_impl;
			IntPtr method_code = ioasyncCallback.method_code;
			IntPtr method = ioasyncCallback.method;
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0000AB28 File Offset: 0x00008D28
		void IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae)
		{
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0000AB38 File Offset: 0x00008D38
		public void MarkDisposed()
		{
			global::System.IOAsyncResult ioasyncResult = this.state;
		}

		// Token: 0x0400026D RID: 621
		private global::System.IOOperation operation;

		// Token: 0x0400026E RID: 622
		private global::System.IOAsyncCallback callback;

		// Token: 0x0400026F RID: 623
		private global::System.IOAsyncResult state;
	}
}
