using System;

namespace System.Threading
{
	// Token: 0x020001D6 RID: 470
	internal struct CancellationCallbackCoreWorkArguments
	{
		// Token: 0x0600112A RID: 4394 RVA: 0x000244EC File Offset: 0x000226EC
		public CancellationCallbackCoreWorkArguments(SparselyPopulatedArrayFragment<CancellationCallbackInfo> currArrayFragment, int currArrayIndex)
		{
			this._currArrayFragment = currArrayFragment;
			this._currArrayIndex = currArrayIndex;
		}

		// Token: 0x0400093B RID: 2363
		internal SparselyPopulatedArrayFragment<CancellationCallbackInfo> _currArrayFragment;

		// Token: 0x0400093C RID: 2364
		internal int _currArrayIndex;
	}
}
