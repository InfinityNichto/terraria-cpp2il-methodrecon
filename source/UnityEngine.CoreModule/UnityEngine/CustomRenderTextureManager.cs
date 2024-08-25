using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000058 RID: 88
	[NativeHeader("Runtime/Graphics/CustomRenderTextureManager.h")]
	public static class CustomRenderTextureManager
	{
		// Token: 0x06000180 RID: 384 RVA: 0x000042F4 File Offset: 0x000024F4
		[RequiredByNativeCode]
		private static void InvokeOnTextureLoaded_Internal(CustomRenderTexture source)
		{
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00004304 File Offset: 0x00002504
		[RequiredByNativeCode]
		private static void InvokeOnTextureUnloaded_Internal(CustomRenderTexture source)
		{
		}

		// Token: 0x0400021D RID: 541
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<CustomRenderTexture> textureLoaded;

		// Token: 0x0400021E RID: 542
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<CustomRenderTexture> textureUnloaded;
	}
}
