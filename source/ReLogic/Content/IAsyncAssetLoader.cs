using System;
using ReLogic.Content.Sources;

namespace ReLogic.Content
{
	// Token: 0x02000B4B RID: 2891
	public interface IAsyncAssetLoader : IDisposable
	{
		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x06005415 RID: 21525
		bool IsRunning { get; }

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x06005416 RID: 21526
		int Remaining { get; }

		// Token: 0x06005417 RID: 21527
		void Start();

		// Token: 0x06005418 RID: 21528
		void Stop();

		// Token: 0x06005419 RID: 21529
		void Load<T>(string assetName, IContentSource source, LoadAssetDelegate<T> callback) where T : class;

		// Token: 0x0600541A RID: 21530
		void TransferCompleted();
	}
}
