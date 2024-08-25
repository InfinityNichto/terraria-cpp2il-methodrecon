using System;
using System.ComponentModel;

namespace System.Net
{
	// Token: 0x0200017F RID: 383
	public class UploadDataCompletedEventArgs : global::System.ComponentModel.AsyncCompletedEventArgs
	{
		// Token: 0x060009F8 RID: 2552 RVA: 0x00022048 File Offset: 0x00020248
		internal UploadDataCompletedEventArgs(byte[] result, Exception exception, bool cancelled, object userToken)
		{
			this._result = result;
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x060009F9 RID: 2553 RVA: 0x0002205C File Offset: 0x0002025C
		public byte[] Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return this._result;
			}
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x00022078 File Offset: 0x00020278
		internal UploadDataCompletedEventArgs()
		{
			throw new NotSupportedException();
		}

		// Token: 0x0400079F RID: 1951
		private readonly byte[] _result;
	}
}
