using System;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200004E RID: 78
	[NativeHeader("Runtime/Graphics/Texture2DArray.h")]
	public sealed class Texture2DArray : Texture
	{
		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600013C RID: 316 RVA: 0x00003B44 File Offset: 0x00001D44
		public override bool isReadable
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00003B58 File Offset: 0x00001D58
		[FreeFunction("Texture2DArrayScripting::Create")]
		private static bool Internal_CreateImpl([Writable] Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00003B6C File Offset: 0x00001D6C
		private static void Internal_Create([Writable] Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00003B80 File Offset: 0x00001D80
		internal bool ValidateFormat(TextureFormat format, int width, int height)
		{
			bool flag = base.ValidateFormat(format);
			return Mathf.IsPowerOfTwo(width);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00003BA8 File Offset: 0x00001DA8
		internal bool ValidateFormat(GraphicsFormat format, int width, int height)
		{
			bool flag = GraphicsFormatUtility.IsPVRTCFormat(format);
			return Mathf.IsPowerOfTwo(width);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00003BD0 File Offset: 0x00001DD0
		[ExcludeFromDocs]
		public Texture2DArray(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00003BE4 File Offset: 0x00001DE4
		[ExcludeFromDocs]
		[RequiredByNativeCode]
		public Texture2DArray(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00003BF4 File Offset: 0x00001DF4
		[ExcludeFromDocs]
		public Texture2DArray(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount)
		{
			if (!true)
			{
			}
			base..ctor();
			bool flag = this.ValidateFormat(format, width, height);
			Texture2DArray.ValidateIsNotCrunched(flags);
			Texture2DArray.Internal_Create(this, width, height, depth, mipCount, format, flags);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00003C2C File Offset: 0x00001E2C
		public Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear)
		{
			if (!true)
			{
			}
			bool flag = this.ValidateFormat(textureFormat, width, height);
			if (!true)
			{
			}
			if (!true)
			{
			}
			bool flag2 = GraphicsFormatUtility.IsCrunchFormat(textureFormat);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00003C58 File Offset: 0x00001E58
		public Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, [DefaultValue("false")] bool linear)
		{
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00003C68 File Offset: 0x00001E68
		[ExcludeFromDocs]
		public Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, bool mipChain)
		{
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00003C78 File Offset: 0x00001E78
		private static void ValidateIsNotCrunched(TextureCreationFlags flags)
		{
		}
	}
}
