using System;
using System.Runtime.InteropServices;
using ReLogic.Content.Sources;

namespace ReLogic.Content
{
	// Token: 0x02000B49 RID: 2889
	public interface IAssetLoader
	{
		// Token: 0x0600540D RID: 21517
		bool TryLoad<T>(string assetName, IContentSource source, [Out] T resultAsset) where T : class;
	}
}
