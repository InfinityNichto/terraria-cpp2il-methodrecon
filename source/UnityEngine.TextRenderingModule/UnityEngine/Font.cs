using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200000C RID: 12
	[NativeHeader("Modules/TextRendering/Public/FontImpl.h")]
	[NativeHeader("Modules/TextRendering/Public/Font.h")]
	[StaticAccessor("TextRenderingPrivate", StaticAccessorType.DoubleColon)]
	[NativeClass("TextRendering::Font")]
	public sealed class Font : Object
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000024 RID: 36 RVA: 0x000025C4 File Offset: 0x000007C4
		// (remove) Token: 0x06000025 RID: 37 RVA: 0x000025E0 File Offset: 0x000007E0
		public static event Action<Font> textureRebuilt
		{
			[CompilerGenerated]
			add
			{
				Delegate @delegate;
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
			[CompilerGenerated]
			remove
			{
				Delegate @delegate;
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000026 RID: 38 RVA: 0x000025FC File Offset: 0x000007FC
		public Material material
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00002610 File Offset: 0x00000810
		public bool dynamic
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00002624 File Offset: 0x00000824
		public int fontSize
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002638 File Offset: 0x00000838
		[RequiredByNativeCode]
		internal static void InvokeTextureRebuilt_Internal(Font font)
		{
			Font.FontTextureRebuildCallback fontTextureRebuildCallback = font.m_FontTextureRebuildCallback;
			if (fontTextureRebuildCallback != null)
			{
				IntPtr invoke_impl = fontTextureRebuildCallback.invoke_impl;
				IntPtr method_code = fontTextureRebuildCallback.method_code;
				IntPtr method = fontTextureRebuildCallback.method;
				return;
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002668 File Offset: 0x00000868
		public bool HasCharacter(char c)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0000267C File Offset: 0x0000087C
		private bool HasCharacter(int c)
		{
			throw new MissingMethodException();
		}

		// Token: 0x04000049 RID: 73
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<Font> textureRebuilt;

		// Token: 0x0400004A RID: 74
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Font.FontTextureRebuildCallback m_FontTextureRebuildCallback;

		// Token: 0x0200000D RID: 13
		public sealed class FontTextureRebuildCallback : MulticastDelegate
		{
			// Token: 0x0600002C RID: 44 RVA: 0x00002690 File Offset: 0x00000890
			public FontTextureRebuildCallback(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x0600002D RID: 45 RVA: 0x000026E4 File Offset: 0x000008E4
			public void Invoke()
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}
		}
	}
}
