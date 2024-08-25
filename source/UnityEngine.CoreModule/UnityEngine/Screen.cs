using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x0200005C RID: 92
	[NativeHeader("Runtime/Graphics/ScreenManager.h")]
	[NativeHeader("Runtime/Graphics/WindowLayout.h")]
	[StaticAccessor("GetScreenManager()", StaticAccessorType.Dot)]
	[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
	public sealed class Screen
	{
		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600018B RID: 395 RVA: 0x000043AC File Offset: 0x000025AC
		public static int width
		{
			[NativeMethod(Name = "GetWidth", IsThreadSafe = true)]
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600018C RID: 396 RVA: 0x000043C0 File Offset: 0x000025C0
		public static int height
		{
			[NativeMethod(Name = "GetHeight", IsThreadSafe = true)]
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600018D RID: 397 RVA: 0x000043D4 File Offset: 0x000025D4
		public static float dpi
		{
			[NativeName("GetDPI")]
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000050 RID: 80
		// (set) Token: 0x0600018E RID: 398 RVA: 0x000043E8 File Offset: 0x000025E8
		[NativeProperty("ScreenTimeout")]
		public static int sleepTimeout
		{
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600018F RID: 399 RVA: 0x000043FC File Offset: 0x000025FC
		public static bool fullScreen
		{
			[NativeName("IsFullscreen")]
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000190 RID: 400 RVA: 0x00004410 File Offset: 0x00002610
		public static Rect safeArea
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00004424 File Offset: 0x00002624
		private static void get_safeArea_Injected([Out] Rect ret)
		{
			throw new MissingMethodException();
		}
	}
}
