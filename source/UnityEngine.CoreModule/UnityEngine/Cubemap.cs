using System;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200004C RID: 76
	[ExcludeFromPreset]
	[NativeHeader("Runtime/Graphics/CubemapTexture.h")]
	public sealed class Cubemap : Texture
	{
		// Token: 0x06000124 RID: 292 RVA: 0x000038C8 File Offset: 0x00001AC8
		[FreeFunction("CubemapScripting::Create")]
		private static bool Internal_CreateImpl([Writable] Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000125 RID: 293 RVA: 0x000038DC File Offset: 0x00001ADC
		private static void Internal_Create([Writable] Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex)
		{
			throw new MissingMethodException();
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000126 RID: 294 RVA: 0x000038F0 File Offset: 0x00001AF0
		public override bool isReadable
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00003904 File Offset: 0x00001B04
		internal bool ValidateFormat(TextureFormat format, int width)
		{
			bool flag = base.ValidateFormat(format);
			return Mathf.IsPowerOfTwo(width);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0000392C File Offset: 0x00001B2C
		internal bool ValidateFormat(GraphicsFormat format, int width)
		{
			bool flag = GraphicsFormatUtility.IsPVRTCFormat(format);
			return Mathf.IsPowerOfTwo(width);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00003954 File Offset: 0x00001B54
		[ExcludeFromDocs]
		public Cubemap(int width, DefaultFormat format, TextureCreationFlags flags)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00003968 File Offset: 0x00001B68
		[ExcludeFromDocs]
		[RequiredByNativeCode]
		public Cubemap(int width, GraphicsFormat format, TextureCreationFlags flags)
		{
			if (!true)
			{
			}
			base..ctor();
			bool flag = this.ValidateFormat(format, width);
			if (!true)
			{
			}
		}

		// Token: 0x0600012B RID: 299 RVA: 0x0000398C File Offset: 0x00001B8C
		public Cubemap(int width, TextureFormat format, int mipCount)
		{
		}

		// Token: 0x0600012C RID: 300 RVA: 0x0000399C File Offset: 0x00001B9C
		[ExcludeFromDocs]
		public Cubemap(int width, GraphicsFormat format, TextureCreationFlags flags, int mipCount)
		{
			if (!true)
			{
			}
			base..ctor();
			bool flag = this.ValidateFormat(format, width);
			Cubemap.ValidateIsNotCrunched(flags);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x000039C4 File Offset: 0x00001BC4
		internal Cubemap(int width, TextureFormat textureFormat, int mipCount, IntPtr nativeTex)
		{
			if (!true)
			{
			}
			base..ctor();
			bool flag = this.ValidateFormat(textureFormat, width);
			if (!true)
			{
			}
			long num = 0L;
			GraphicsFormat graphicsFormat = GraphicsFormatUtility.GetGraphicsFormat(textureFormat, num != 0L);
			if (!true)
			{
			}
			bool flag2 = GraphicsFormatUtility.IsCrunchFormat(textureFormat);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x000039FC File Offset: 0x00001BFC
		internal Cubemap(int width, TextureFormat textureFormat, bool mipChain, IntPtr nativeTex)
		{
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00003A0C File Offset: 0x00001C0C
		public Cubemap(int width, TextureFormat textureFormat, bool mipChain)
		{
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00003A1C File Offset: 0x00001C1C
		private static void ValidateIsNotCrunched(TextureCreationFlags flags)
		{
		}
	}
}
