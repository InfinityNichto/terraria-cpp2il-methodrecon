using System;
using System.Collections.Generic;
using System.IO;

namespace ReLogic.Content.Sources
{
	// Token: 0x02000B4E RID: 2894
	public interface IContentSource
	{
		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x0600542A RID: 21546
		// (set) Token: 0x0600542B RID: 21547
		IContentValidator ContentValidator { get; set; }

		// Token: 0x0600542C RID: 21548
		bool HasAsset(string assetName);

		// Token: 0x0600542D RID: 21549
		string GetExtension(string assetName);

		// Token: 0x0600542E RID: 21550
		Stream OpenStream(string assetName);

		// Token: 0x0600542F RID: 21551
		void RejectAsset(string assetName, IRejectionReason reason);

		// Token: 0x06005430 RID: 21552
		void ClearRejections();

		// Token: 0x06005431 RID: 21553
		bool TryGetRejections(List<string> rejectionReasons);
	}
}
