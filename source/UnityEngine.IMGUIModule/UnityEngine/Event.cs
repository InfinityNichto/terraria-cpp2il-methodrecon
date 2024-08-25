using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200000C RID: 12
	[StaticAccessor("GUIEvent", StaticAccessorType.DoubleColon)]
	[NativeHeader("Modules/IMGUI/Event.bindings.h")]
	[StructLayout(0)]
	public sealed class Event
	{
		// Token: 0x06000036 RID: 54 RVA: 0x00002840 File Offset: 0x00000A40
		public Event()
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002864 File Offset: 0x00000A64
		public Event(int displayIndex)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002884 File Offset: 0x00000A84
		protected override void Finalize()
		{
			IntPtr ptr = this.m_Ptr;
			IntPtr ptr2 = this.m_Ptr;
			throw new MissingMethodException();
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000039 RID: 57 RVA: 0x000028D0 File Offset: 0x00000AD0
		public bool shift
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600003A RID: 58 RVA: 0x000028E4 File Offset: 0x00000AE4
		public bool control
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600003B RID: 59 RVA: 0x000028F8 File Offset: 0x00000AF8
		public bool alt
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003C RID: 60 RVA: 0x0000290C File Offset: 0x00000B0C
		public bool command
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600003D RID: 61 RVA: 0x000020F5 File Offset: 0x000002F5
		public static Event current
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00002920 File Offset: 0x00000B20
		public bool isKey
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00002934 File Offset: 0x00000B34
		public bool isMouse
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00002948 File Offset: 0x00000B48
		internal bool isDirectManipulationDevice
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002964 File Offset: 0x00000B64
		public override int GetHashCode()
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002994 File Offset: 0x00000B94
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				Type type = obj.GetType();
				Type type2 = base.GetType();
				throw new MissingMethodException();
			}
			throw new MissingMethodException();
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002A04 File Offset: 0x00000C04
		public override string ToString()
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002B34 File Offset: 0x00000D34
		public void Use()
		{
			throw new MissingMethodException();
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00002B68 File Offset: 0x00000D68
		[NativeProperty("type", false, TargetType.Field)]
		public EventType rawType
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00002B7C File Offset: 0x00000D7C
		[NativeProperty("mousePosition", false, TargetType.Field)]
		public Vector2 mousePosition
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00002B90 File Offset: 0x00000D90
		[NativeProperty("pointerType", false, TargetType.Field)]
		public PointerType pointerType
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00002BA4 File Offset: 0x00000DA4
		[NativeProperty("modifiers", false, TargetType.Field)]
		public EventModifiers modifiers
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00002BB8 File Offset: 0x00000DB8
		[NativeProperty("character", false, TargetType.Field)]
		public char character
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00002BCC File Offset: 0x00000DCC
		[NativeProperty("keycode", false, TargetType.Field)]
		public KeyCode keyCode
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700001B RID: 27
		// (set) Token: 0x0600004B RID: 75 RVA: 0x00002BE0 File Offset: 0x00000DE0
		[NativeProperty("displayIndex", false, TargetType.Field)]
		public int displayIndex
		{
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00002BF4 File Offset: 0x00000DF4
		public EventType type
		{
			[FreeFunction("GUIEvent::GetType", HasExplicitThis = true)]
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00002C08 File Offset: 0x00000E08
		public string commandName
		{
			[FreeFunction("GUIEvent::GetCommandName", HasExplicitThis = true)]
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002C1C File Offset: 0x00000E1C
		[NativeMethod("Use")]
		private void Internal_Use()
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002C30 File Offset: 0x00000E30
		[FreeFunction("GUIEvent::Internal_Create", IsThreadSafe = true)]
		private static IntPtr Internal_Create(int displayIndex)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002C44 File Offset: 0x00000E44
		[FreeFunction("GUIEvent::Internal_Destroy", IsThreadSafe = true)]
		private static void Internal_Destroy(IntPtr ptr)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002C58 File Offset: 0x00000E58
		public static bool PopEvent([NotNull("ArgumentNullException")] Event outEvent)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002C6C File Offset: 0x00000E6C
		private static void Internal_SetNativeEvent(IntPtr ptr)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002C80 File Offset: 0x00000E80
		[RequiredByNativeCode]
		internal static void Internal_MakeMasterEventCurrent(int displayIndex)
		{
			if (!true)
			{
			}
			throw new MissingMethodException();
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002C9C File Offset: 0x00000E9C
		private void get_mousePosition_Injected([Out] Vector2 ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x04000054 RID: 84
		[NonSerialized]
		internal IntPtr m_Ptr;

		// Token: 0x04000055 RID: 85
		private static Event s_Current;

		// Token: 0x04000056 RID: 86
		private static Event s_MasterEvent;
	}
}
