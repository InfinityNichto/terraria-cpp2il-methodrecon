using System;
using System.Collections.Generic;
using ReLogic.Content.Sources;

namespace ReLogic.Content
{
	// Token: 0x02000B4A RID: 2890
	public interface IAssetRepository : IDisposable
	{
		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x0600540E RID: 21518
		int PendingAssets { get; }

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x0600540F RID: 21519
		int TotalAssets { get; }

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06005410 RID: 21520
		int LoadedAssets { get; }

		// Token: 0x06005411 RID: 21521
		void SetSources(IEnumerable<IContentSource> sources, AssetRequestMode mode = AssetRequestMode.ImmediateLoad);

		// Token: 0x06005412 RID: 21522
		Asset<T> Request<T>(string assetName, AssetRequestMode mode = AssetRequestMode.ImmediateLoad) where T : class;

		// Token: 0x06005413 RID: 21523
		void TransferCompletedAssets();

		// Token: 0x06005414 RID: 21524
		void ProcessAsyncLoad();
	}
}
