using System;
using System.ComponentModel;

namespace System.Net
{
	// Token: 0x0200017E RID: 382
	public class UploadStringCompletedEventArgs : global::System.ComponentModel.AsyncCompletedEventArgs
	{
		// Token: 0x060009F5 RID: 2549 RVA: 0x00022004 File Offset: 0x00020204
		internal UploadStringCompletedEventArgs(string result, Exception exception, bool cancelled, object userToken)
		{
			this._result = result;
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x060009F6 RID: 2550 RVA: 0x00022018 File Offset: 0x00020218
		public string Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return this._result;
			}
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x00022034 File Offset: 0x00020234
		internal UploadStringCompletedEventArgs()
		{
			throw new NotSupportedException();
		}

		// Token: 0x0400079E RID: 1950
		private readonly string _result;
	}
}
