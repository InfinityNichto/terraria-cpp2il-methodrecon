using System;
using System.IO;
using System.Threading;

namespace System.Net
{
	// Token: 0x02000138 RID: 312
	internal class ClosableStream : DelegatedStream
	{
		// Token: 0x0600075F RID: 1887 RVA: 0x0001A898 File Offset: 0x00018A98
		internal ClosableStream(Stream stream, EventHandler onClose)
			: base(stream)
		{
			this._onClose = onClose;
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x0001A8B4 File Offset: 0x00018AB4
		public override void Close()
		{
			int num = Interlocked.Increment(int.MinValue);
			EventHandler onClose = this._onClose;
			if (onClose != null)
			{
				IntPtr invoke_impl = onClose.invoke_impl;
				IntPtr method_code = onClose.method_code;
				IntPtr method = onClose.method;
				return;
			}
		}

		// Token: 0x040005E9 RID: 1513
		private readonly EventHandler _onClose;

		// Token: 0x040005EA RID: 1514
		private int _closed;
	}
}
