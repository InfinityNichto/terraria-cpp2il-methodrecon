using System;
using ReLogic.Content.Sources;

namespace ReLogic.Content
{
	// Token: 0x02000B48 RID: 2888
	public interface IAsset : IDisposable
	{
		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x06005407 RID: 21511
		AssetState State { get; }

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x06005408 RID: 21512
		IContentSource Source { get; }

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x06005409 RID: 21513
		string Name { get; }

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x0600540A RID: 21514
		bool IsLoaded { get; }

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x0600540B RID: 21515
		bool IsDisposed { get; }

		// Token: 0x0600540C RID: 21516
		void ActionUnityLoad();
	}
}
