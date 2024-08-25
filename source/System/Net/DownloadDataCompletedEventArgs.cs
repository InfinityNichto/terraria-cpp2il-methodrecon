using System;
using System.ComponentModel;

namespace System.Net
{
	// Token: 0x0200017D RID: 381
	public class DownloadDataCompletedEventArgs : global::System.ComponentModel.AsyncCompletedEventArgs
	{
		// Token: 0x060009F2 RID: 2546 RVA: 0x00021FC0 File Offset: 0x000201C0
		internal DownloadDataCompletedEventArgs(byte[] result, Exception exception, bool cancelled, object userToken)
		{
			this._result = result;
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x060009F3 RID: 2547 RVA: 0x00021FD4 File Offset: 0x000201D4
		public byte[] Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return this._result;
			}
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x00021FF0 File Offset: 0x000201F0
		internal DownloadDataCompletedEventArgs()
		{
			throw new NotSupportedException();
		}

		// Token: 0x0400079D RID: 1949
		private readonly byte[] _result;
	}
}
