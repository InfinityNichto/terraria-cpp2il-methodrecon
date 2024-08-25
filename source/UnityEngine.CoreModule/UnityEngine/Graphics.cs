using System;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
	// Token: 0x02000054 RID: 84
	[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
	[NativeHeader("Runtime/Misc/PlayerSettings.h")]
	[NativeHeader("Runtime/Camera/LightProbeProxyVolume.h")]
	[NativeHeader("Runtime/Shaders/ComputeShader.h")]
	[NativeHeader("Runtime/Graphics/ColorGamut.h")]
	[NativeHeader("Runtime/Graphics/CopyTexture.h")]
	public class Graphics
	{
		// Token: 0x06000172 RID: 370 RVA: 0x000041E0 File Offset: 0x000023E0
		public static void Blit(Texture source, RenderTexture dest, Material mat, [DefaultValue("-1")] int pass)
		{
			if (!true)
			{
			}
			throw new MissingMethodException();
		}

		// Token: 0x06000173 RID: 371 RVA: 0x000041F8 File Offset: 0x000023F8
		public static void Blit(Texture source, RenderTexture dest, Material mat)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00004208 File Offset: 0x00002408
		[FreeFunction("GraphicsScripting::GetMaxDrawMeshInstanceCount")]
		private static int Internal_GetMaxDrawMeshInstanceCount()
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0000421C File Offset: 0x0000241C
		[FreeFunction("GraphicsScripting::BlitMaterial")]
		private static void Internal_BlitMaterial5(Texture source, RenderTexture dest, [NotNull("ArgumentNullException")] Material mat, int pass, bool setRT)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00004230 File Offset: 0x00002430
		// Note: this type is marked as 'beforefieldinit'.
		static Graphics()
		{
			throw new MissingMethodException();
		}

		// Token: 0x04000219 RID: 537
		internal static readonly int kMaxDrawMeshInstanceCount;
	}
}
