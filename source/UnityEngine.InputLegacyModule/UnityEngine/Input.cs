using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000008 RID: 8
	[NativeHeader("Runtime/Input/InputBindings.h")]
	public class Input
	{
		// Token: 0x06000010 RID: 16 RVA: 0x00002188 File Offset: 0x00000388
		[NativeThrows]
		private static bool GetKeyInt(KeyCode key)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000219C File Offset: 0x0000039C
		[NativeThrows]
		private static bool GetKeyString(string name)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000021B0 File Offset: 0x000003B0
		[NativeThrows]
		private static bool GetKeyDownInt(KeyCode key)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000021C4 File Offset: 0x000003C4
		[NativeThrows]
		public static float GetAxisRaw(string axisName)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000021D8 File Offset: 0x000003D8
		[NativeThrows]
		public static bool GetButtonDown(string buttonName)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000021EC File Offset: 0x000003EC
		[NativeThrows]
		public static bool GetMouseButton(int button)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002200 File Offset: 0x00000400
		[NativeThrows]
		public static bool GetMouseButtonDown(int button)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002214 File Offset: 0x00000414
		[NativeThrows]
		public static bool GetMouseButtonUp(int button)
		{
			while (button != 0)
			{
			}
			throw new MissingMethodException();
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000222C File Offset: 0x0000042C
		[NativeThrows]
		public static string[] GetJoystickNames()
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002240 File Offset: 0x00000440
		[NativeThrows]
		public static Touch GetTouch(int index)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002254 File Offset: 0x00000454
		public static bool GetKey(KeyCode key)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002268 File Offset: 0x00000468
		public static bool GetKey(string name)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000227C File Offset: 0x0000047C
		public static bool GetKeyDown(KeyCode key)
		{
			throw new MissingMethodException();
		}

		// Token: 0x1700000C RID: 12
		// (set) Token: 0x0600001D RID: 29 RVA: 0x00002290 File Offset: 0x00000490
		public static bool simulateMouseWithTouches
		{
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600001E RID: 30 RVA: 0x000022A4 File Offset: 0x000004A4
		[NativeThrows]
		public static string inputString
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600001F RID: 31 RVA: 0x000022B8 File Offset: 0x000004B8
		[NativeThrows]
		public static Vector3 mousePosition
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000020 RID: 32 RVA: 0x000022CC File Offset: 0x000004CC
		[NativeThrows]
		public static Vector2 mouseScrollDelta
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000021 RID: 33 RVA: 0x000022E0 File Offset: 0x000004E0
		// (set) Token: 0x06000022 RID: 34 RVA: 0x000022F4 File Offset: 0x000004F4
		public static IMECompositionMode imeCompositionMode
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

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00002308 File Offset: 0x00000508
		public static string compositionString
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000024 RID: 36 RVA: 0x0000231C File Offset: 0x0000051C
		// (set) Token: 0x06000025 RID: 37 RVA: 0x00002330 File Offset: 0x00000530
		public static Vector2 compositionCursorPos
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

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00002344 File Offset: 0x00000544
		public static bool mousePresent
		{
			[FreeFunction("GetMousePresent")]
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00002358 File Offset: 0x00000558
		public static int touchCount
		{
			[FreeFunction("GetTouchCount")]
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000028 RID: 40 RVA: 0x0000236C File Offset: 0x0000056C
		public static bool touchSupported
		{
			[FreeFunction("IsTouchSupported")]
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00002380 File Offset: 0x00000580
		public static DeviceOrientation deviceOrientation
		{
			[FreeFunction("GetOrientation")]
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00002394 File Offset: 0x00000594
		public static Touch[] touches
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000023B0 File Offset: 0x000005B0
		internal static bool CheckDisabled()
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000023C4 File Offset: 0x000005C4
		private static void GetTouch_Injected(int index, [Out] Touch ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000023D8 File Offset: 0x000005D8
		private static void get_mousePosition_Injected([Out] Vector3 ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000023EC File Offset: 0x000005EC
		private static void get_mouseScrollDelta_Injected([Out] Vector2 ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002400 File Offset: 0x00000600
		private static void get_compositionCursorPos_Injected([Out] Vector2 ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002414 File Offset: 0x00000614
		private static void set_compositionCursorPos_Injected(Vector2 value)
		{
			throw new MissingMethodException();
		}
	}
}
