using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000DA RID: 218
	[NativeHeader("Runtime/Misc/Player.h")]
	[NativeHeader("Runtime/PreloadManager/PreloadManager.h")]
	[NativeHeader("Runtime/Network/NetworkUtility.h")]
	[NativeHeader("Runtime/Misc/SystemInfo.h")]
	[NativeHeader("Runtime/PreloadManager/LoadSceneOperation.h")]
	[NativeHeader("Runtime/Application/AdsIdHandler.h")]
	[NativeHeader("Runtime/BaseClasses/IsPlaying.h")]
	[NativeHeader("Runtime/Application/ApplicationInfo.h")]
	[NativeHeader("Runtime/Input/GetInput.h")]
	[NativeHeader("Runtime/File/ApplicationSpecificPersistentDataPath.h")]
	[NativeHeader("Runtime/Input/InputManager.h")]
	[NativeHeader("Runtime/Export/Application/Application.bindings.h")]
	[NativeHeader("Runtime/Logging/LogSystem.h")]
	[NativeHeader("Runtime/Misc/BuildSettings.h")]
	[NativeHeader("Runtime/Misc/PlayerSettings.h")]
	[NativeHeader("Runtime/Utilities/URLUtility.h")]
	[NativeHeader("Runtime/Utilities/Argv.h")]
	[NativeHeader("Runtime/Input/TargetFrameRate.h")]
	public class Application
	{
		// Token: 0x0600047A RID: 1146 RVA: 0x0000842C File Offset: 0x0000662C
		[FreeFunction("GetInputManager().QuitApplication")]
		public static void Quit(int exitCode)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00008440 File Offset: 0x00006640
		public static void Quit()
		{
			throw new MissingMethodException();
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600047C RID: 1148 RVA: 0x00008454 File Offset: 0x00006654
		public static bool isPlaying
		{
			[FreeFunction("IsWorldPlaying")]
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600047D RID: 1149 RVA: 0x00008468 File Offset: 0x00006668
		public static bool isBatchMode
		{
			[FreeFunction("::IsBatchmode")]
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x0000847C File Offset: 0x0000667C
		public static string persistentDataPath
		{
			[FreeFunction("GetPersistentDataPathApplicationSpecific")]
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600047F RID: 1151 RVA: 0x00008490 File Offset: 0x00006690
		public static string unityVersion
		{
			[FreeFunction("Application_Bindings::GetUnityVersion", IsThreadSafe = true)]
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000480 RID: 1152 RVA: 0x000084A4 File Offset: 0x000066A4
		public static string identifier
		{
			[FreeFunction("GetApplicationInfo().GetApplicationIdentifier")]
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x000084B8 File Offset: 0x000066B8
		[FreeFunction("OpenURL")]
		public static void OpenURL(string url)
		{
			throw new MissingMethodException();
		}

		// Token: 0x170000E8 RID: 232
		// (set) Token: 0x06000482 RID: 1154 RVA: 0x000084CC File Offset: 0x000066CC
		public static int targetFrameRate
		{
			[FreeFunction("SetTargetFrameRate")]
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000483 RID: 1155 RVA: 0x000084E0 File Offset: 0x000066E0
		public static RuntimePlatform platform
		{
			[FreeFunction("systeminfo::GetRuntimePlatform", IsThreadSafe = true)]
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000484 RID: 1156 RVA: 0x000084F4 File Offset: 0x000066F4
		public static SystemLanguage systemLanguage
		{
			[FreeFunction("(SystemLanguage)systeminfo::GetSystemLanguage")]
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000485 RID: 1157 RVA: 0x00008508 File Offset: 0x00006708
		// (remove) Token: 0x06000486 RID: 1158 RVA: 0x00008520 File Offset: 0x00006720
		public static event Application.LowMemoryCallback lowMemory
		{
			[CompilerGenerated]
			add
			{
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00008538 File Offset: 0x00006738
		[RequiredByNativeCode]
		internal static void CallLowMemory()
		{
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00008548 File Offset: 0x00006748
		[RequiredByNativeCode]
		private static void CallLogCallback(string logString, string stackTrace, LogType type, bool invokedOnMainThread)
		{
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00008558 File Offset: 0x00006758
		[RequiredByNativeCode]
		private static bool Internal_ApplicationWantsToQuit()
		{
			throw new InvalidCastException();
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00008574 File Offset: 0x00006774
		[RequiredByNativeCode]
		private static void Internal_ApplicationQuit()
		{
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00008584 File Offset: 0x00006784
		[RequiredByNativeCode]
		private static void Internal_ApplicationUnload()
		{
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00008594 File Offset: 0x00006794
		[RequiredByNativeCode]
		internal static void InvokeOnBeforeRender()
		{
			if (!true)
			{
			}
			BeforeRenderHelper.Invoke();
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x000085AC File Offset: 0x000067AC
		[RequiredByNativeCode]
		internal static void InvokeFocusChanged(bool focus)
		{
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x000085BC File Offset: 0x000067BC
		[RequiredByNativeCode]
		internal static void InvokeDeepLinkActivated(string url)
		{
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x0600048F RID: 1167 RVA: 0x000085CC File Offset: 0x000067CC
		public static bool isEditor
		{
			get
			{
			}
		}

		// Token: 0x040003D0 RID: 976
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Application.LowMemoryCallback lowMemory;

		// Token: 0x040003D1 RID: 977
		private static Application.LogCallback s_LogCallbackHandler;

		// Token: 0x040003D2 RID: 978
		private static Application.LogCallback s_LogCallbackHandlerThreaded;

		// Token: 0x040003D3 RID: 979
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<bool> focusChanged;

		// Token: 0x040003D4 RID: 980
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<string> deepLinkActivated;

		// Token: 0x040003D5 RID: 981
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Func<bool> wantsToQuit;

		// Token: 0x040003D6 RID: 982
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action quitting;

		// Token: 0x040003D7 RID: 983
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action unloading;

		// Token: 0x020000DB RID: 219
		public sealed class LowMemoryCallback : MulticastDelegate
		{
			// Token: 0x06000490 RID: 1168 RVA: 0x000085DC File Offset: 0x000067DC
			public LowMemoryCallback(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06000491 RID: 1169 RVA: 0x00008630 File Offset: 0x00006830
			public void Invoke()
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}
		}

		// Token: 0x020000DC RID: 220
		public sealed class LogCallback : MulticastDelegate
		{
			// Token: 0x06000492 RID: 1170 RVA: 0x00008654 File Offset: 0x00006854
			public LogCallback(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06000493 RID: 1171 RVA: 0x000086A8 File Offset: 0x000068A8
			public void Invoke(string condition, string stackTrace, LogType type)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}
		}
	}
}
