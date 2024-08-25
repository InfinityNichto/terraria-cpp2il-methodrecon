using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000010 RID: 16
	[NativeHeader("Runtime/Utilities/CopyPaste.h")]
	[NativeHeader("Runtime/Camera/RenderLayers/GUITexture.h")]
	[NativeHeader("Runtime/Input/InputManager.h")]
	[NativeHeader("Modules/IMGUI/GUIUtility.h")]
	[NativeHeader("Modules/IMGUI/GUIManager.h")]
	[NativeHeader("Runtime/Input/InputBindings.h")]
	public class GUIUtility
	{
		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00002FD0 File Offset: 0x000011D0
		[NativeProperty("GetGUIState().m_PixelsPerPoint", true, TargetType.Field)]
		internal static float pixelsPerPoint
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00002FE4 File Offset: 0x000011E4
		[NativeProperty("GetGUIState().m_OnGUIDepth", true, TargetType.Field)]
		internal static int guiDepth
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000021 RID: 33
		// (set) Token: 0x0600006A RID: 106 RVA: 0x00002FF8 File Offset: 0x000011F8
		[NativeProperty("GetGUIState().m_CanvasGUIState.m_IsMouseUsed", true, TargetType.Field)]
		internal static bool mouseUsed
		{
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600006B RID: 107 RVA: 0x0000300C File Offset: 0x0000120C
		// (set) Token: 0x0600006C RID: 108 RVA: 0x00003020 File Offset: 0x00001220
		public static string systemCopyBuffer
		{
			[FreeFunction("GetCopyBuffer")]
			get
			{
				throw new MissingMethodException();
			}
			[FreeFunction("SetCopyBuffer")]
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00003034 File Offset: 0x00001234
		[FreeFunction("GetGUIState().GetControlID")]
		private static int Internal_GetControlID(int hint, FocusType focusType, Rect rect)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00003048 File Offset: 0x00001248
		public static int GetControlID(int hint, FocusType focusType, Rect rect)
		{
			int num;
			return num;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00003058 File Offset: 0x00001258
		private static int Internal_GetHotControl()
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000306C File Offset: 0x0000126C
		private static int Internal_GetKeyboardControl()
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00003080 File Offset: 0x00001280
		private static object Internal_GetDefaultSkin(int skinMode)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00003094 File Offset: 0x00001294
		private static void Internal_ExitGUI()
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000030A8 File Offset: 0x000012A8
		[RequiredByNativeCode]
		private static void MarkGUIChanged()
		{
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000030B8 File Offset: 0x000012B8
		public static int GetControlID(int hint, FocusType focus)
		{
			Rect zero = Rect.zero;
			int num;
			return num;
		}

		// Token: 0x17000023 RID: 35
		// (set) Token: 0x06000075 RID: 117 RVA: 0x000030D0 File Offset: 0x000012D0
		internal static bool guiIsExiting
		{
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000076 RID: 118 RVA: 0x000030E0 File Offset: 0x000012E0
		public static int hotControl
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000030F4 File Offset: 0x000012F4
		[RequiredByNativeCode]
		internal static void TakeCapture()
		{
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00003104 File Offset: 0x00001304
		[RequiredByNativeCode]
		internal static void RemoveCapture()
		{
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00003114 File Offset: 0x00001314
		public static int keyboardControl
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00003128 File Offset: 0x00001328
		internal static bool HasKeyFocus(int controlID)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00003140 File Offset: 0x00001340
		internal static GUISkin GetDefaultSkin()
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00003154 File Offset: 0x00001354
		[RequiredByNativeCode]
		internal static void ProcessEvent(int instanceID, IntPtr nativeEventPtr, [Out] bool result)
		{
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00003164 File Offset: 0x00001364
		[RequiredByNativeCode]
		internal static void BeginGUI(int skinMode, int instanceID, int useGUILayout)
		{
			GUIUtility.ResetGlobalState();
			if (useGUILayout != 0)
			{
				GUILayoutUtility.Begin(instanceID);
				return;
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00003180 File Offset: 0x00001380
		[RequiredByNativeCode]
		internal static void EndGUI(int layoutType)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000031DC File Offset: 0x000013DC
		[RequiredByNativeCode]
		internal static bool EndGUIFromException(Exception exception)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000031F0 File Offset: 0x000013F0
		[RequiredByNativeCode]
		internal static bool EndContainerGUIFromException(Exception exception)
		{
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00003200 File Offset: 0x00001400
		internal static void ResetGlobalState()
		{
			if (!true)
			{
			}
			throw new MissingMethodException();
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000321C File Offset: 0x0000141C
		internal static bool IsExitGUIException(Exception exception)
		{
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000322C File Offset: 0x0000142C
		internal static bool ShouldRethrowException(Exception exception)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000323C File Offset: 0x0000143C
		internal static void CheckOnGUI()
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00003250 File Offset: 0x00001450
		internal static bool HitTest(Rect rect, Vector2 point, int offset)
		{
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00003260 File Offset: 0x00001460
		internal static bool HitTest(Rect rect, Vector2 point, bool isDirectManipulationDevice)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00003270 File Offset: 0x00001470
		internal static bool HitTest(Rect rect, Event evt)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00003280 File Offset: 0x00001480
		private static int Internal_GetControlID_Injected(int hint, FocusType focusType, Rect rect)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0400005F RID: 95
		internal static int s_ControlCount;

		// Token: 0x04000060 RID: 96
		internal static int s_SkinMode;

		// Token: 0x04000061 RID: 97
		internal static int s_OriginalID;

		// Token: 0x04000062 RID: 98
		internal static Action takeCapture;

		// Token: 0x04000063 RID: 99
		internal static Action releaseCapture;

		// Token: 0x04000064 RID: 100
		internal static Func<int, IntPtr, bool> processEvent;

		// Token: 0x04000065 RID: 101
		internal static Func<Exception, bool> endContainerGUIFromException;

		// Token: 0x04000066 RID: 102
		internal static Action guiChanged;

		// Token: 0x04000067 RID: 103
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static bool <guiIsExiting>k__BackingField;

		// Token: 0x04000068 RID: 104
		internal static Func<bool> s_HasCurrentWindowKeyFocusFunc;
	}
}
