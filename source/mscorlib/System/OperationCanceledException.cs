using System;
using System.Runtime.Serialization;
using System.Threading;

namespace System
{
	// Token: 0x020000EA RID: 234
	[Serializable]
	public class OperationCanceledException : SystemException
	{
		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060008C3 RID: 2243 RVA: 0x000156E0 File Offset: 0x000138E0
		// (set) Token: 0x060008C4 RID: 2244 RVA: 0x000156F4 File Offset: 0x000138F4
		public CancellationToken CancellationToken
		{
			get
			{
				return this._cancellationToken;
			}
			private set
			{
				this._cancellationToken = value;
			}
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x00015708 File Offset: 0x00013908
		public OperationCanceledException()
			: base("The operation was canceled.")
		{
			this._HResult = 5435;
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x0001572C File Offset: 0x0001392C
		public OperationCanceledException(string message)
			: base(message)
		{
			this._HResult = 5435;
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x0001574C File Offset: 0x0001394C
		public OperationCanceledException(string message, CancellationToken token)
			: base(message)
		{
			this._HResult = 5435;
			this._cancellationToken = token;
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x00015774 File Offset: 0x00013974
		protected OperationCanceledException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		// Token: 0x04000381 RID: 897
		[NonSerialized]
		private CancellationToken _cancellationToken;
	}
}
