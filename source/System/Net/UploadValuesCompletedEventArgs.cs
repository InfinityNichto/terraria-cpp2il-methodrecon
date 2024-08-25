using System;
using System.ComponentModel;

namespace System.Net
{
	// Token: 0x02000181 RID: 385
	public class UploadValuesCompletedEventArgs : global::System.ComponentModel.AsyncCompletedEventArgs
	{
		// Token: 0x060009FE RID: 2558 RVA: 0x000220D0 File Offset: 0x000202D0
		internal UploadValuesCompletedEventArgs(byte[] result, Exception exception, bool cancelled, object userToken)
		{
			this._result = result;
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x060009FF RID: 2559 RVA: 0x000220E4 File Offset: 0x000202E4
		public byte[] Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return this._result;
			}
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x00022100 File Offset: 0x00020300
		internal UploadValuesCompletedEventArgs()
		{
			throw new NotSupportedException();
		}

		// Token: 0x040007A1 RID: 1953
		private readonly byte[] _result;
	}
}
