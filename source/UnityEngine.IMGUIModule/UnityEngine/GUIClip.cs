using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000008 RID: 8
	[NativeHeader("Modules/IMGUI/GUIClip.h")]
	[NativeHeader("Modules/IMGUI/GUIState.h")]
	internal sealed class GUIClip
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000030 RID: 48 RVA: 0x000027C4 File Offset: 0x000009C4
		internal static Rect visibleRect
		{
			[FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.GetVisibleRect")]
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000027D8 File Offset: 0x000009D8
		internal static void Internal_Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000027EC File Offset: 0x000009EC
		internal static void Internal_Pop()
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002800 File Offset: 0x00000A00
		internal static void Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset)
		{
			GUIClip.Internal_Push(screenRect, scrollOffset, renderOffset, resetOffset);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002818 File Offset: 0x00000A18
		private static void get_visibleRect_Injected([Out] Rect ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000282C File Offset: 0x00000A2C
		private static void Internal_Push_Injected(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset)
		{
			throw new MissingMethodException();
		}
	}
}
