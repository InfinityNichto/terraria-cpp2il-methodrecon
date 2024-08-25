using System;
using System.ComponentModel;

namespace System.Net
{
	// Token: 0x02000180 RID: 384
	public class UploadFileCompletedEventArgs : global::System.ComponentModel.AsyncCompletedEventArgs
	{
		// Token: 0x060009FB RID: 2555 RVA: 0x0002208C File Offset: 0x0002028C
		internal UploadFileCompletedEventArgs(byte[] result, Exception exception, bool cancelled, object userToken)
		{
			this._result = result;
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x060009FC RID: 2556 RVA: 0x000220A0 File Offset: 0x000202A0
		public byte[] Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return this._result;
			}
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x000220BC File Offset: 0x000202BC
		internal UploadFileCompletedEventArgs()
		{
			throw new NotSupportedException();
		}

		// Token: 0x040007A0 RID: 1952
		private readonly byte[] _result;
	}
}
