using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Internal;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000050 RID: 80
	[UsedByNativeCode]
	[NativeHeader("Runtime/Camera/Camera.h")]
	[NativeHeader("Runtime/Graphics/RenderBufferManager.h")]
	[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
	[NativeHeader("Runtime/Graphics/RenderTexture.h")]
	public class RenderTexture : Texture
	{
		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000152 RID: 338 RVA: 0x00003D70 File Offset: 0x00001F70
		// (set) Token: 0x06000153 RID: 339 RVA: 0x00003D84 File Offset: 0x00001F84
		public override int width
		{
			get
			{
				throw new MissingMethodException();
			}
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000154 RID: 340 RVA: 0x00003D98 File Offset: 0x00001F98
		// (set) Token: 0x06000155 RID: 341 RVA: 0x00003DAC File Offset: 0x00001FAC
		public override int height
		{
			get
			{
				throw new MissingMethodException();
			}
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700003D RID: 61
		// (set) Token: 0x06000156 RID: 342 RVA: 0x00003DC0 File Offset: 0x00001FC0
		[NativeProperty("ColorFormat")]
		public GraphicsFormat graphicsFormat
		{
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700003E RID: 62
		// (set) Token: 0x06000157 RID: 343 RVA: 0x00003DD4 File Offset: 0x00001FD4
		public GraphicsFormat depthStencilFormat
		{
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00003DE8 File Offset: 0x00001FE8
		private void SetMipMapCount(int count)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00003DFC File Offset: 0x00001FFC
		internal void SetSRGBReadWrite(bool srgb)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00003E10 File Offset: 0x00002010
		[FreeFunction("RenderTextureScripting::Create")]
		private static void Internal_Create([Writable] RenderTexture rt)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00003E24 File Offset: 0x00002024
		[NativeName("SetRenderTextureDescFromScript")]
		private void SetRenderTextureDescriptor(RenderTextureDescriptor desc)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00003E38 File Offset: 0x00002038
		[NativeName("GetRenderTextureDesc")]
		private RenderTextureDescriptor GetDescriptor()
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00003E4C File Offset: 0x0000204C
		[RequiredByNativeCode]
		protected internal RenderTexture()
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00003E64 File Offset: 0x00002064
		public RenderTexture(RenderTextureDescriptor desc)
		{
			if (!true)
			{
			}
			base..ctor();
			RenderTextureMemoryless <memoryless>k__BackingField = desc.<memoryless>k__BackingField;
			int <mipCount>k__BackingField = desc.<mipCount>k__BackingField;
			int value__ = desc._graphicsFormat.value__;
			throw new MissingMethodException();
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00003EC4 File Offset: 0x000020C4
		public RenderTexture(RenderTexture textureToCopy)
		{
			int num = 1;
			if (num == 0)
			{
			}
			base..ctor();
			if (num == 0)
			{
			}
			RenderTexture.ValidateRenderTextureDesc(textureToCopy.descriptor);
			throw new MissingMethodException();
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00003F00 File Offset: 0x00002100
		[ExcludeFromDocs]
		public RenderTexture(int width, int height, int depth, DefaultFormat format)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00003F14 File Offset: 0x00002114
		[ExcludeFromDocs]
		public RenderTexture(int width, int height, int depth, GraphicsFormat format)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00003F24 File Offset: 0x00002124
		[ExcludeFromDocs]
		public RenderTexture(int width, int height, int depth, GraphicsFormat format, int mipCount)
		{
			if (!true)
			{
			}
			base..ctor();
			throw new MissingMethodException();
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00003F6C File Offset: 0x0000216C
		[ExcludeFromDocs]
		public RenderTexture(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat, int mipCount)
		{
			int num = 1;
			if (num == 0)
			{
			}
			base..ctor();
			if (colorFormat == GraphicsFormat.None || num == 0)
			{
			}
			throw new MissingMethodException();
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00003FB0 File Offset: 0x000021B0
		[ExcludeFromDocs]
		public RenderTexture(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00003FC0 File Offset: 0x000021C0
		public RenderTexture(int width, int height, int depth, [DefaultValue("RenderTextureFormat.Default")] RenderTextureFormat format, [DefaultValue("RenderTextureReadWrite.Default")] RenderTextureReadWrite readWrite)
		{
			if (!true)
			{
			}
			base..ctor();
			this.Initialize(width, height, depth, format, readWrite, 1073741824);
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00003FE8 File Offset: 0x000021E8
		[ExcludeFromDocs]
		public RenderTexture(int width, int height, int depth, RenderTextureFormat format)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00003FF8 File Offset: 0x000021F8
		[ExcludeFromDocs]
		public RenderTexture(int width, int height, int depth)
		{
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00004008 File Offset: 0x00002208
		[ExcludeFromDocs]
		public RenderTexture(int width, int height, int depth, RenderTextureFormat format, int mipCount)
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00004020 File Offset: 0x00002220
		private void Initialize(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite, int mipCount)
		{
			GraphicsFormat compatibleFormat = RenderTexture.GetCompatibleFormat(format, readWrite);
			GraphicsFormat depthStencilFormatLegacy = RenderTexture.GetDepthStencilFormatLegacy(depth, compatibleFormat);
			if (compatibleFormat != GraphicsFormat.None)
			{
			}
			throw new MissingMethodException();
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00004068 File Offset: 0x00002268
		internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, GraphicsFormat colorFormat)
		{
			if (!true)
			{
			}
			long num = 0L;
			return GraphicsFormatUtility.GetDepthStencilFormat(int.MinValue, (int)num);
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600016B RID: 363 RVA: 0x00004088 File Offset: 0x00002288
		public RenderTextureDescriptor descriptor
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0000409C File Offset: 0x0000229C
		private static void ValidateRenderTextureDesc(RenderTextureDescriptor desc)
		{
			if (desc._graphicsFormat != GraphicsFormat.None)
			{
				throw new MissingMethodException();
			}
			GraphicsFormat <depthStencilFormat>k__BackingField = desc.<depthStencilFormat>k__BackingField;
			if (<depthStencilFormat>k__BackingField != GraphicsFormat.None)
			{
				bool flag = GraphicsFormatUtility.IsDepthFormat(<depthStencilFormat>k__BackingField);
				bool flag2 = GraphicsFormatUtility.IsStencilFormat(desc.<depthStencilFormat>k__BackingField);
				int <height>k__BackingField = desc.<height>k__BackingField;
				int <volumeDepth>k__BackingField = desc.<volumeDepth>k__BackingField;
				int <msaaSamples>k__BackingField = desc.<msaaSamples>k__BackingField;
				TextureDimension <dimension>k__BackingField = desc.<dimension>k__BackingField;
				GraphicsFormat graphicsFormat = desc._graphicsFormat;
				if (<dimension>k__BackingField == TextureDimension.None)
				{
				}
				bool flag3 = GraphicsFormatUtility.IsDepthFormat(graphicsFormat);
				GraphicsFormat graphicsFormat2 = desc._graphicsFormat;
				if (<dimension>k__BackingField == TextureDimension.None)
				{
				}
				bool flag4 = GraphicsFormatUtility.IsStencilFormat(graphicsFormat2);
				return;
			}
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00004160 File Offset: 0x00002360
		internal static GraphicsFormat GetCompatibleFormat(RenderTextureFormat renderTextureFormat, RenderTextureReadWrite readWrite)
		{
			if (!true)
			{
			}
			throw new MissingMethodException();
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00004194 File Offset: 0x00002394
		private void SetRenderTextureDescriptor_Injected(RenderTextureDescriptor desc)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600016F RID: 367 RVA: 0x000041A8 File Offset: 0x000023A8
		private void GetDescriptor_Injected([Out] RenderTextureDescriptor ret)
		{
			throw new MissingMethodException();
		}
	}
}
