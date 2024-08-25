using System;
using System.ComponentModel;
using System.IO;

namespace System.Net
{
	// Token: 0x0200017B RID: 379
	public class OpenWriteCompletedEventArgs : global::System.ComponentModel.AsyncCompletedEventArgs
	{
		// Token: 0x060009EC RID: 2540 RVA: 0x00021F40 File Offset: 0x00020140
		internal OpenWriteCompletedEventArgs(Stream result, Exception exception, bool cancelled, object userToken)
		{
			this._result = result;
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x060009ED RID: 2541 RVA: 0x00021F54 File Offset: 0x00020154
		public Stream Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return this._result;
			}
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x00021F70 File Offset: 0x00020170
		internal OpenWriteCompletedEventArgs()
		{
			throw new NotSupportedException();
		}

		// Token: 0x0400079B RID: 1947
		private readonly Stream _result;
	}
}
