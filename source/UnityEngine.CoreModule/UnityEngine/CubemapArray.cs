using System;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200004F RID: 79
	[NativeHeader("Runtime/Graphics/CubemapArrayTexture.h")]
	[ExcludeFromPreset]
	public sealed class CubemapArray : Texture
	{
		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000148 RID: 328 RVA: 0x00003C88 File Offset: 0x00001E88
		public override bool isReadable
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00003C9C File Offset: 0x00001E9C
		[FreeFunction("CubemapArrayScripting::Create")]
		private static bool Internal_CreateImpl([Writable] CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureCreationFlags flags)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00003CB0 File Offset: 0x00001EB0
		private static void Internal_Create([Writable] CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureCreationFlags flags)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00003CC4 File Offset: 0x00001EC4
		[ExcludeFromDocs]
		public CubemapArray(int width, int cubemapCount, DefaultFormat format, TextureCreationFlags flags)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00003CD8 File Offset: 0x00001ED8
		[ExcludeFromDocs]
		[RequiredByNativeCode]
		public CubemapArray(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags)
		{
			if (!true)
			{
			}
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00003CE8 File Offset: 0x00001EE8
		[ExcludeFromDocs]
		public CubemapArray(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags, [DefaultValue("-1")] int mipCount)
		{
			if (!true)
			{
			}
			base..ctor();
			CubemapArray.ValidateIsNotCrunched(flags);
			CubemapArray.Internal_Create(this, width, cubemapCount, mipCount, format, flags);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00003D14 File Offset: 0x00001F14
		public CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, int mipCount, bool linear)
		{
			if (!true)
			{
			}
			base..ctor();
			bool flag = base.ValidateFormat(textureFormat);
			if (!true)
			{
			}
			if (!true)
			{
			}
			bool flag2 = GraphicsFormatUtility.IsCrunchFormat(textureFormat);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00003D40 File Offset: 0x00001F40
		public CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain, [DefaultValue("false")] bool linear)
		{
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00003D50 File Offset: 0x00001F50
		[ExcludeFromDocs]
		public CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain)
		{
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00003D60 File Offset: 0x00001F60
		private static void ValidateIsNotCrunched(TextureCreationFlags flags)
		{
		}
	}
}
