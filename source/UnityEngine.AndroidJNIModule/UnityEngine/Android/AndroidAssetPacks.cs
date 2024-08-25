using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Android
{
	// Token: 0x02000014 RID: 20
	[StaticAccessor("AndroidAssetPacksBindingsHelpers", StaticAccessorType.DoubleColon)]
	[NativeHeader("Modules/AndroidJNI/Public/AndroidAssetPacksBindingsHelpers.h")]
	public static class AndroidAssetPacks
	{
		// Token: 0x06000183 RID: 387 RVA: 0x00005550 File Offset: 0x00003750
		private static AndroidJavaObject GetAssetPackManager()
		{
			long num = 0L;
			int num2 = 3;
			if (num == 0L)
			{
				while (num2 == 0)
				{
				}
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0400003F RID: 63
		private static AndroidJavaObject s_JavaPlayAssetDeliveryWrapper;

		// Token: 0x04000040 RID: 64
		private static bool s_ApiMissing;

		// Token: 0x02000015 RID: 21
		private class AssetPackManagerDownloadStatusCallback : AndroidJavaProxy
		{
			// Token: 0x06000184 RID: 388 RVA: 0x00005584 File Offset: 0x00003784
			public AssetPackManagerDownloadStatusCallback(Action<AndroidAssetPackInfo> callback, string[] assetPacks)
			{
				if (!true)
				{
				}
				base..ctor("com.unity3d.player.IAssetPackManagerDownloadStatusCallback");
				this.m_Callback = callback;
				this.m_AssetPacks = assetPacks;
			}

			// Token: 0x06000185 RID: 389 RVA: 0x000055B0 File Offset: 0x000037B0
			[Preserve]
			private void onStatusUpdate(string assetPackName, int assetPackStatus, long assetPackSize, long assetPackBytesDownloaded, int assetPackTransferProgress, int assetPackErrorCode)
			{
				string[] assetPacks = this.m_AssetPacks;
				if (this.m_Callback != null)
				{
					return;
				}
			}

			// Token: 0x04000041 RID: 65
			private Action<AndroidAssetPackInfo> m_Callback;

			// Token: 0x04000042 RID: 66
			private string[] m_AssetPacks;
		}

		// Token: 0x02000016 RID: 22
		private class AssetPackManagerMobileDataConfirmationCallback : AndroidJavaProxy
		{
			// Token: 0x06000186 RID: 390 RVA: 0x000055D0 File Offset: 0x000037D0
			public AssetPackManagerMobileDataConfirmationCallback(Action<AndroidAssetPackUseMobileDataRequestResult> callback)
			{
				if (!true)
				{
				}
				base..ctor("com.unity3d.player.IAssetPackManagerMobileDataConfirmationCallback");
				this.m_Callback = callback;
			}

			// Token: 0x06000187 RID: 391 RVA: 0x000055F4 File Offset: 0x000037F4
			[Preserve]
			private void onMobileDataConfirmationResult(bool allowed)
			{
				if (this.m_Callback != null)
				{
					return;
				}
			}

			// Token: 0x04000043 RID: 67
			private Action<AndroidAssetPackUseMobileDataRequestResult> m_Callback;
		}

		// Token: 0x02000017 RID: 23
		private class AssetPackManagerStatusQueryCallback : AndroidJavaProxy
		{
			// Token: 0x06000188 RID: 392 RVA: 0x0000560C File Offset: 0x0000380C
			public AssetPackManagerStatusQueryCallback(Action<ulong, AndroidAssetPackState[]> callback, string[] assetPacks)
			{
				if (!true)
				{
				}
				base..ctor("com.unity3d.player.IAssetPackManagerStatusQueryCallback");
				this.m_Callback = callback;
				this.m_AssetPackNames = assetPacks;
			}

			// Token: 0x06000189 RID: 393 RVA: 0x0000353A File Offset: 0x0000173A
			[Preserve]
			private void onStatusResult(long totalBytes, string[] assetPackNames, int[] assetPackStatuses, int[] assetPackErrorCodes)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x04000044 RID: 68
			private Action<ulong, AndroidAssetPackState[]> m_Callback;

			// Token: 0x04000045 RID: 69
			private List<string> m_AssetPackNames;

			// Token: 0x04000046 RID: 70
			private List<AndroidAssetPackState> m_States;

			// Token: 0x04000047 RID: 71
			private long m_Size;
		}
	}
}
