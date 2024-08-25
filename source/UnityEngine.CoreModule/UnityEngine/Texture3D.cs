using System;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200004D RID: 77
	[ExcludeFromPreset]
	[NativeHeader("Runtime/Graphics/Texture3D.h")]
	public sealed class Texture3D : Texture
	{
		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00003A2C File Offset: 0x00001C2C
		public override bool isReadable
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00003A40 File Offset: 0x00001C40
		[FreeFunction("Texture3DScripting::Create")]
		private static bool Internal_CreateImpl([Writable] Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00003A54 File Offset: 0x00001C54
		private static void Internal_Create([Writable] Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00003A68 File Offset: 0x00001C68
		[ExcludeFromDocs]
		public Texture3D(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00003A7C File Offset: 0x00001C7C
		[ExcludeFromDocs]
		[RequiredByNativeCode]
		public Texture3D(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00003A8C File Offset: 0x00001C8C
		[ExcludeFromDocs]
		public Texture3D(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, [DefaultValue("-1")] int mipCount)
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00003AA4 File Offset: 0x00001CA4
		[ExcludeFromDocs]
		public Texture3D(int width, int height, int depth, TextureFormat textureFormat, int mipCount)
		{
			if (!true)
			{
			}
			base..ctor();
			bool flag = base.ValidateFormat(textureFormat);
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

		// Token: 0x06000138 RID: 312 RVA: 0x00003ADC File Offset: 0x00001CDC
		public Texture3D(int width, int height, int depth, TextureFormat textureFormat, int mipCount, [DefaultValue("IntPtr.Zero")] IntPtr nativeTex)
		{
			if (!true)
			{
			}
			base..ctor();
			bool flag = base.ValidateFormat(textureFormat);
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

		// Token: 0x06000139 RID: 313 RVA: 0x00003B14 File Offset: 0x00001D14
		[ExcludeFromDocs]
		public Texture3D(int width, int height, int depth, TextureFormat textureFormat, bool mipChain)
		{
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00003B24 File Offset: 0x00001D24
		public Texture3D(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, [DefaultValue("IntPtr.Zero")] IntPtr nativeTex)
		{
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00003B34 File Offset: 0x00001D34
		private static void ValidateIsNotCrunched(TextureCreationFlags flags)
		{
		}
	}
}
