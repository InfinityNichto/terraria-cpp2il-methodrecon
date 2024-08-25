using System;
using Cpp2IlInjected;

namespace ReLogic.Content
{
	// Token: 0x02000B4C RID: 2892
	public sealed class LoadAssetDelegate<T> : MulticastDelegate where T : class
	{
		// Token: 0x0600541B RID: 21531 RVA: 0x0028565C File Offset: 0x0028385C
		public LoadAssetDelegate(object @object, IntPtr method)
		{
		}

		// Token: 0x0600541C RID: 21532 RVA: 0x00285678 File Offset: 0x00283878
		public void Invoke(bool loadedSuccessfully, T theAsset)
		{
		}

		// Token: 0x0600541D RID: 21533 RVA: 0x000021DB File Offset: 0x000003DB
		public IAsyncResult BeginInvoke(bool loadedSuccessfully, T theAsset, AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600541E RID: 21534 RVA: 0x00285688 File Offset: 0x00283888
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
