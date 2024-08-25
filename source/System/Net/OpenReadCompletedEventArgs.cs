using System;
using System.ComponentModel;
using System.IO;

namespace System.Net
{
	// Token: 0x0200017A RID: 378
	public class OpenReadCompletedEventArgs : global::System.ComponentModel.AsyncCompletedEventArgs
	{
		// Token: 0x060009E9 RID: 2537 RVA: 0x00021EFC File Offset: 0x000200FC
		internal OpenReadCompletedEventArgs(Stream result, Exception exception, bool cancelled, object userToken)
		{
			this._result = result;
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x060009EA RID: 2538 RVA: 0x00021F10 File Offset: 0x00020110
		public Stream Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return this._result;
			}
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x00021F2C File Offset: 0x0002012C
		internal OpenReadCompletedEventArgs()
		{
			throw new NotSupportedException();
		}

		// Token: 0x0400079A RID: 1946
		private readonly Stream _result;
	}
}
