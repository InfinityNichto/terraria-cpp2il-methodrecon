using System;
using UnityEngine.Bindings;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x0200013A RID: 314
	[NativeHeader("Runtime/Graphics/Format.h")]
	[NativeHeader("Runtime/Graphics/TextureFormat.h")]
	[NativeHeader("Runtime/Graphics/GraphicsFormatUtility.bindings.h")]
	public class GraphicsFormatUtility
	{
		// Token: 0x0600060A RID: 1546 RVA: 0x0000AF78 File Offset: 0x00009178
		public static GraphicsFormat GetGraphicsFormat(TextureFormat format, bool isSRGB)
		{
			if (!true)
			{
			}
			throw new MissingMethodException();
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x0000AF90 File Offset: 0x00009190
		[FreeFunction(IsThreadSafe = true)]
		private static GraphicsFormat GetGraphicsFormat_Native_TextureFormat(TextureFormat format, bool isSRGB)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x0000AFA4 File Offset: 0x000091A4
		public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, bool isSRGB)
		{
			if (!true)
			{
			}
			throw new MissingMethodException();
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x0000AFBC File Offset: 0x000091BC
		[FreeFunction]
		private static GraphicsFormat GetGraphicsFormat_Native_RenderTextureFormat(RenderTextureFormat format, bool isSRGB)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x0000AFD0 File Offset: 0x000091D0
		public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, RenderTextureReadWrite readWrite)
		{
			ColorSpace activeColorSpace = QualitySettings.activeColorSpace;
			if ("br" == null)
			{
			}
			GraphicsFormat graphicsFormat;
			return graphicsFormat;
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x0000AFF0 File Offset: 0x000091F0
		[FreeFunction(IsThreadSafe = true)]
		private static GraphicsFormat GetDepthStencilFormatFromBitsLegacy_Native(int minimumDepthBits)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x0000B004 File Offset: 0x00009204
		internal static GraphicsFormat GetDepthStencilFormat(int minimumDepthBits)
		{
			if (!true)
			{
			}
			throw new MissingMethodException();
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x0000B01C File Offset: 0x0000921C
		public static GraphicsFormat GetDepthStencilFormat(int minimumDepthBits, int minimumStencilBits)
		{
			if (true)
			{
				if (2 == 0)
				{
				}
				Debug.Assert(false);
				if (!false)
				{
				}
			}
			return "Number of bits in DepthStencil format can't be negative.";
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x0000B048 File Offset: 0x00009248
		[FreeFunction(IsThreadSafe = true)]
		public static bool IsSRGBFormat(GraphicsFormat format)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x0000B05C File Offset: 0x0000925C
		[FreeFunction("IsAnyCompressedTextureFormat", true)]
		internal static bool IsCompressedTextureFormat(TextureFormat format)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x0000B070 File Offset: 0x00009270
		[FreeFunction(IsThreadSafe = true)]
		private static bool CanDecompressFormat(GraphicsFormat format, bool wholeImage)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x0000B084 File Offset: 0x00009284
		internal static bool CanDecompressFormat(GraphicsFormat format)
		{
			if (!true)
			{
			}
			throw new MissingMethodException();
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x0000B09C File Offset: 0x0000929C
		[FreeFunction(IsThreadSafe = true)]
		public static bool IsDepthFormat(GraphicsFormat format)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x0000B0B0 File Offset: 0x000092B0
		[FreeFunction(IsThreadSafe = true)]
		public static bool IsStencilFormat(GraphicsFormat format)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x0000B0C4 File Offset: 0x000092C4
		[FreeFunction(IsThreadSafe = true)]
		public static bool IsPVRTCFormat(GraphicsFormat format)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x0000B0D8 File Offset: 0x000092D8
		public static bool IsCrunchFormat(TextureFormat format)
		{
			return true;
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x0000B0E8 File Offset: 0x000092E8
		// Note: this type is marked as 'beforefieldinit'.
		static GraphicsFormatUtility()
		{
		}

		// Token: 0x0400055E RID: 1374
		private static readonly GraphicsFormat[] tableNoStencil;

		// Token: 0x0400055F RID: 1375
		private static readonly GraphicsFormat[] tableStencil;
	}
}
