using System;
using System.Threading;

namespace System.Net
{
	// Token: 0x02000121 RID: 289
	internal class CallbackClosure
	{
		// Token: 0x060006DF RID: 1759 RVA: 0x00019324 File Offset: 0x00017524
		internal CallbackClosure(ExecutionContext context, AsyncCallback callback)
		{
			if (callback != null)
			{
				this._savedCallback = callback;
				this._savedContext = context;
			}
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x00019348 File Offset: 0x00017548
		internal bool IsCompatible(AsyncCallback callback)
		{
			if (callback == null)
			{
				return;
			}
			AsyncCallback savedCallback = this._savedCallback;
			if (savedCallback != null)
			{
				return object.Equals(savedCallback, callback);
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060006E1 RID: 1761 RVA: 0x0001936C File Offset: 0x0001756C
		internal AsyncCallback AsyncCallback
		{
			get
			{
				return this._savedCallback;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060006E2 RID: 1762 RVA: 0x00019380 File Offset: 0x00017580
		internal ExecutionContext Context
		{
			get
			{
				return this._savedContext;
			}
		}

		// Token: 0x0400054A RID: 1354
		private AsyncCallback _savedCallback;

		// Token: 0x0400054B RID: 1355
		private ExecutionContext _savedContext;
	}
}
