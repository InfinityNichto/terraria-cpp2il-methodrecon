using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using Terraria.Chat;
using UnityEngine;

// Token: 0x02000026 RID: 38
public class DrPlatform
{
	// Token: 0x17000038 RID: 56
	// (get) Token: 0x060000C8 RID: 200 RVA: 0x000021DB File Offset: 0x000003DB
	public static bool IsChromebook
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x17000039 RID: 57
	// (get) Token: 0x060000C9 RID: 201 RVA: 0x000039B4 File Offset: 0x00001BB4
	public static DrPlatform.DrPlatformType CurrentPlatform
	{
		get
		{
			return DrPlatform.DrPlatformType.Google;
		}
	}

	// Token: 0x1700003A RID: 58
	// (get) Token: 0x060000CA RID: 202 RVA: 0x000039C4 File Offset: 0x00001BC4
	public static DrPlatform.DrSKUType CurrentSKU
	{
		get
		{
		}
	}

	// Token: 0x060000CB RID: 203 RVA: 0x000039D4 File Offset: 0x00001BD4
	public static void OpenStoreURL()
	{
		bool flag = string.IsNullOrEmpty("market://details?id=com.and.games505.commanders");
	}

	// Token: 0x060000CC RID: 204 RVA: 0x000021DB File Offset: 0x000003DB
	public static bool IsCurrentPlatform(DrPlatform.DrPlatformType platform)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060000CD RID: 205 RVA: 0x000039F8 File Offset: 0x00001BF8
	public static bool IsCachedSignIn()
	{
		/*
An exception occurred when decompiling this method (060000CD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean DrPlatform::IsCachedSignIn()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:LoginState(var_0_05, callgetter:LoginState(User::get_CurrentLoginState))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
	}

	// Token: 0x060000CE RID: 206 RVA: 0x00003A0C File Offset: 0x00001C0C
	public static bool IsSignedInToCurrentPlatform()
	{
		return string.IsNullOrEmpty(DrPlatform.Android.User.UserUID);
	}

	// Token: 0x060000CF RID: 207 RVA: 0x000021DB File Offset: 0x000003DB
	public static bool PlatformMatches(DrPlatform.DrPlatformType platformCompare1, DrPlatform.DrPlatformType platformCompare2)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060000D0 RID: 208 RVA: 0x00003A24 File Offset: 0x00001C24
	public static void Update(float elapsedTime)
	{
		if (!true)
		{
		}
		MainThreadExecution.ExecuteSnippets();
		DrPlatform.Android.Update();
		if (!true)
		{
		}
		DrPlatform.User.UpdateChatRequests();
	}

	// Token: 0x1700003B RID: 59
	// (get) Token: 0x060000D1 RID: 209 RVA: 0x00003A48 File Offset: 0x00001C48
	public static bool IsMainThread
	{
		get
		{
			/*
An exception occurred when decompiling this method (060000D1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean DrPlatform::get_IsMainThread()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Thread(var_1_07, callgetter:Thread(Thread::get_CurrentThread))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}
	}

	// Token: 0x060000D2 RID: 210 RVA: 0x00003A5C File Offset: 0x00001C5C
	public static void Setup()
	{
		Thread currentThread = Thread.CurrentThread;
		string deviceModel = SystemInfo.deviceModel;
		Input.simulateMouseWithTouches = false;
	}

	// Token: 0x060000D3 RID: 211 RVA: 0x00003A80 File Offset: 0x00001C80
	public static void Start()
	{
		string deviceModel = SystemInfo.deviceModel;
	}

	// Token: 0x060000D4 RID: 212 RVA: 0x00003A98 File Offset: 0x00001C98
	public static void StartSession()
	{
		Guid guid = Guid.NewGuid();
	}

	// Token: 0x060000D5 RID: 213 RVA: 0x00003AB0 File Offset: 0x00001CB0
	private static void SetConnectionDown(bool connectionDown)
	{
	}

	// Token: 0x060000D6 RID: 214 RVA: 0x00003AC0 File Offset: 0x00001CC0
	private static void SetVSyncCount()
	{
	}

	// Token: 0x1700003C RID: 60
	// (get) Token: 0x060000D7 RID: 215 RVA: 0x00003AD0 File Offset: 0x00001CD0
	public static bool IsUIHighlightEnabled
	{
		get
		{
			return Application.isEditor;
		}
	}

	// Token: 0x1700003D RID: 61
	// (get) Token: 0x060000D8 RID: 216 RVA: 0x00003AE4 File Offset: 0x00001CE4
	public static string InstallSource
	{
		get
		{
			bool isEditor = Application.isEditor;
			return "Editor";
		}
	}

	// Token: 0x060000D9 RID: 217 RVA: 0x00003B04 File Offset: 0x00001D04
	public DrPlatform()
	{
	}

	// Token: 0x04000089 RID: 137
	private static bool? isChromebook;

	// Token: 0x0400008A RID: 138
	public static Thread MainThread;

	// Token: 0x0400008B RID: 139
	public static string DeviceModel;

	// Token: 0x0400008C RID: 140
	public static bool ConnectionDown;

	// Token: 0x0400008D RID: 141
	public static Guid SessionId;

	// Token: 0x02000027 RID: 39
	public class Android
	{
		// Token: 0x060000DA RID: 218 RVA: 0x00003B18 File Offset: 0x00001D18
		[Conditional("UNITY_ANDROID")]
		public static void Setup()
		{
			Input.simulateMouseWithTouches = false;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00003B2C File Offset: 0x00001D2C
		[Conditional("UNITY_ANDROID")]
		public static void Update()
		{
			if (!true)
			{
			}
			Android_UserManager.Update();
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000DC RID: 220 RVA: 0x00003B44 File Offset: 0x00001D44
		public static string InstallSource
		{
			get
			{
				if ("currentActivity" == null)
				{
				}
				if ("currentActivity" == null)
				{
				}
				throw new ArrayTypeMismatchException();
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00003B70 File Offset: 0x00001D70
		public Android()
		{
		}

		// Token: 0x02000028 RID: 40
		public class User
		{
			// Token: 0x1700003F RID: 63
			// (get) Token: 0x060000DE RID: 222 RVA: 0x00003B83 File Offset: 0x00001D83
			public static string UserUID
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000040 RID: 64
			// (get) Token: 0x060000DF RID: 223 RVA: 0x00003B83 File Offset: 0x00001D83
			public static string GamerTag
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000041 RID: 65
			// (get) Token: 0x060000E0 RID: 224 RVA: 0x00003B88 File Offset: 0x00001D88
			public static DrPlatform.Android.User.LoginState CurrentLoginState
			{
				get
				{
					return DrPlatform.Android.User.LoginState.Waiting;
				}
			}

			// Token: 0x17000042 RID: 66
			// (get) Token: 0x060000E1 RID: 225 RVA: 0x00003B83 File Offset: 0x00001D83
			public static string AccountProfileURL
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000043 RID: 67
			// (get) Token: 0x060000E2 RID: 226 RVA: 0x00003BA0 File Offset: 0x00001DA0
			public static bool SigningIn
			{
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060000E3 RID: 227 RVA: 0x00003BB6 File Offset: 0x00001DB6
			public static void RequestLogin()
			{
			}

			// Token: 0x060000E4 RID: 228 RVA: 0x00003BB6 File Offset: 0x00001DB6
			public static void Logout()
			{
			}

			// Token: 0x060000E5 RID: 229 RVA: 0x00003BB6 File Offset: 0x00001DB6
			public User()
			{
			}

			// Token: 0x02000029 RID: 41
			public enum LoginState
			{
				// Token: 0x0400008F RID: 143
				Waiting,
				// Token: 0x04000090 RID: 144
				LoggingIn,
				// Token: 0x04000091 RID: 145
				LoggedIn,
				// Token: 0x04000092 RID: 146
				FromCache,
				// Token: 0x04000093 RID: 147
				LoggedOut
			}
		}
	}

	// Token: 0x0200002A RID: 42
	public enum DrPlatformType
	{
		// Token: 0x04000095 RID: 149
		None,
		// Token: 0x04000096 RID: 150
		PC,
		// Token: 0x04000097 RID: 151
		Google,
		// Token: 0x04000098 RID: 152
		iOS = 4,
		// Token: 0x04000099 RID: 153
		Amazon = 8,
		// Token: 0x0400009A RID: 154
		Steam = 16,
		// Token: 0x0400009B RID: 155
		PS4 = 32,
		// Token: 0x0400009C RID: 156
		Yahoo = 64,
		// Token: 0x0400009D RID: 157
		XBOXONE = 128,
		// Token: 0x0400009E RID: 158
		Stadia = 256,
		// Token: 0x0400009F RID: 159
		Switch = 512,
		// Token: 0x040000A0 RID: 160
		Mobile = 14,
		// Token: 0x040000A1 RID: 161
		Console = 672,
		// Token: 0x040000A2 RID: 162
		All = 65535
	}

	// Token: 0x0200002B RID: 43
	public enum DrSKUType
	{
		// Token: 0x040000A4 RID: 164
		UNKNOWN,
		// Token: 0x040000A5 RID: 165
		SCEE,
		// Token: 0x040000A6 RID: 166
		SCEA,
		// Token: 0x040000A7 RID: 167
		SCEASIA
	}

	// Token: 0x0200002C RID: 44
	public static class User
	{
		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00003BB8 File Offset: 0x00001DB8
		public static bool PermissionsFetchFailed
		{
			get
			{
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x00003BC8 File Offset: 0x00001DC8
		public static bool HasUserGeneratedContentPermissions
		{
			get
			{
				bool isEditor = Application.isEditor;
				bool flag;
				return flag;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00003BE4 File Offset: 0x00001DE4
		public static bool HasChatPermissions
		{
			get
			{
				bool isEditor = Application.isEditor;
				bool flag;
				return flag;
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00003C00 File Offset: 0x00001E00
		public static void UpdateChatRequests()
		{
			if (!true)
			{
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00003C14 File Offset: 0x00001E14
		public static void FilterText(string inputText, Action<string> callback)
		{
			if (!true)
			{
			}
			long num = 0L;
			if (true)
			{
			}
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00003C4C File Offset: 0x00001E4C
		private static void PlatformCheckCanChatThread()
		{
			if (!true)
			{
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00003C60 File Offset: 0x00001E60
		public static void CanChatWith(ChatHelper.ChatRequest request)
		{
			if (!true)
			{
			}
			bool hasChatPermissions = DrPlatform.User.HasChatPermissions;
			ChatHelper.ChatRequest.ChatRequestCallback callback = request.Callback;
			IntPtr method_code = callback.method_code;
			IntPtr invoke_impl = callback.invoke_impl;
			IntPtr method = callback.method;
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000ED RID: 237 RVA: 0x00003C94 File Offset: 0x00001E94
		public static bool IsAgeRestricted
		{
			get
			{
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000EE RID: 238 RVA: 0x00003CA4 File Offset: 0x00001EA4
		public static bool IsPatchRequired
		{
			get
			{
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000EF RID: 239 RVA: 0x00003CB4 File Offset: 0x00001EB4
		public static bool HasMultiplayerPermissions
		{
			get
			{
				bool isEditor = Application.isEditor;
				bool flag;
				return flag;
			}
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00003CD0 File Offset: 0x00001ED0
		public static void OnPlatformUserChanged()
		{
			if (!true)
			{
			}
			if (true)
			{
				return;
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060000F1 RID: 241 RVA: 0x00003CE4 File Offset: 0x00001EE4
		// (remove) Token: 0x060000F2 RID: 242 RVA: 0x00003D00 File Offset: 0x00001F00
		public static event Action PlatformUserChanged
		{
			[CompilerGenerated]
			add
			{
				if (!true)
				{
				}
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (!true)
				{
				}
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00003D1C File Offset: 0x00001F1C
		// Note: this type is marked as 'beforefieldinit'.
		static User()
		{
		}

		// Token: 0x040000A8 RID: 168
		private static ConcurrentQueue<ChatHelper.ChatRequest> PendingChatRequests;

		// Token: 0x040000A9 RID: 169
		private static ManualResetEvent chatCheckPending;

		// Token: 0x040000AA RID: 170
		private static ConcurrentQueue<ChatHelper.ChatRequest> CompletedChatRequests;

		// Token: 0x040000AB RID: 171
		private static ManagedThread PlatformCheckThread;

		// Token: 0x040000AC RID: 172
		private static object fiitlerOpLock;

		// Token: 0x040000AD RID: 173
		private static AutoResetEvent fliterOpCompleteEvent;

		// Token: 0x040000AE RID: 174
		[CompilerGenerated]
		private static Action PlatformUserChanged;
	}

	// Token: 0x0200002D RID: 45
	public class IOS
	{
		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x00003D30 File Offset: 0x00001F30
		public static iOS_Mouse Mouse
		{
			get
			{
				/*
An exception occurred when decompiling this method (060000F4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling iOS_Mouse DrPlatform/IOS::get_Mouse()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_1_07, callgetter:bool(Application::get_isEditor))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00003D44 File Offset: 0x00001F44
		[Conditional("UNITY_IOS")]
		public static void Update()
		{
			if (!true)
			{
			}
			iOS_UserManager.Update();
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00003D5C File Offset: 0x00001F5C
		[Conditional("UNITY_IOS")]
		public static void Setup()
		{
			Input.simulateMouseWithTouches = false;
			if (!true)
			{
			}
			iOS_UserManager.Setup();
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00003D78 File Offset: 0x00001F78
		[Conditional("UNITY_IOS")]
		public static void OpenGameCentreSettings()
		{
			Application.OpenURL("App-Prefs:root=GAMECENTER");
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x00003D90 File Offset: 0x00001F90
		public static string AppID
		{
			get
			{
				return "1078942993";
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00003DA4 File Offset: 0x00001FA4
		public static void UpdateMouse()
		{
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00003DB4 File Offset: 0x00001FB4
		public IOS()
		{
		}

		// Token: 0x040000AF RID: 175
		private static iOS_Mouse _mouse;

		// Token: 0x040000B0 RID: 176
		private const string c_gamecenterSettingsURL = "App-Prefs:root=GAMECENTER";

		// Token: 0x0200002E RID: 46
		public class User
		{
			// Token: 0x1700004C RID: 76
			// (get) Token: 0x060000FB RID: 251 RVA: 0x00003DC8 File Offset: 0x00001FC8
			public static bool SigningIn
			{
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060000FC RID: 252 RVA: 0x00003BB6 File Offset: 0x00001DB6
			public static void RequestSignIn()
			{
			}

			// Token: 0x1700004D RID: 77
			// (get) Token: 0x060000FD RID: 253 RVA: 0x00003DE0 File Offset: 0x00001FE0
			public static DrPlatform.IOS.User.UserState LoginState
			{
				get
				{
					return DrPlatform.IOS.User.UserState.LoadedFromCache;
				}
			}

			// Token: 0x1700004E RID: 78
			// (get) Token: 0x060000FE RID: 254 RVA: 0x00003B83 File Offset: 0x00001D83
			public static string UserUID
			{
				get
				{
					return null;
				}
			}

			// Token: 0x1700004F RID: 79
			// (get) Token: 0x060000FF RID: 255 RVA: 0x00003B83 File Offset: 0x00001D83
			public static string GamerTag
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06000100 RID: 256 RVA: 0x00003BB6 File Offset: 0x00001DB6
			public User()
			{
			}

			// Token: 0x0200002F RID: 47
			public enum UserState
			{
				// Token: 0x040000B2 RID: 178
				LoadedFromCache,
				// Token: 0x040000B3 RID: 179
				SignedIn,
				// Token: 0x040000B4 RID: 180
				SignedOut
			}
		}
	}

	// Token: 0x02000030 RID: 48
	public class PS4
	{
		// Token: 0x06000101 RID: 257 RVA: 0x00003DF8 File Offset: 0x00001FF8
		public static void UpdateMouse()
		{
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00003E08 File Offset: 0x00002008
		[Conditional("UNITY_PS4")]
		public static void Update(bool updateFocus = false)
		{
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00003E18 File Offset: 0x00002018
		[Conditional("UNITY_PS4")]
		public static void Setup()
		{
			if (!true)
			{
			}
			if (true || !true)
			{
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00003E30 File Offset: 0x00002030
		[Conditional("UNITY_PS4")]
		public static void StartSession()
		{
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00003E40 File Offset: 0x00002040
		[Conditional("UNITY_PS4")]
		public static void Start()
		{
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00003E50 File Offset: 0x00002050
		[Conditional("UNITY_PS4")]
		public static void NotfityMultiplayerRealTimeUsage()
		{
			if (!true)
			{
			}
			DateTime utcNow = DateTime.UtcNow;
			TimeSpan timeSpan;
			double totalSeconds = timeSpan.TotalSeconds;
			DateTime utcNow2 = DateTime.UtcNow;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00003E7C File Offset: 0x0000207C
		public PS4()
		{
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00003E90 File Offset: 0x00002090
		// Note: this type is marked as 'beforefieldinit'.
		static PS4()
		{
			if (256 == 0)
			{
			}
		}

		// Token: 0x040000B5 RID: 181
		private const float SOCKET_CLEANUP_TIME = 1f;

		// Token: 0x040000B6 RID: 182
		private static bool _setup;

		// Token: 0x040000B7 RID: 183
		private static bool _hasFocus;

		// Token: 0x040000B8 RID: 184
		private static float _socketsTimer;

		// Token: 0x040000B9 RID: 185
		private static DateTime _lastMPNofityMessage;

		// Token: 0x040000BA RID: 186
		public static bool DisablePlatformChecks;

		// Token: 0x040000BB RID: 187
		private static bool wasMouseConnected;

		// Token: 0x040000BC RID: 188
		public static Vector3 lastUnityMousePosition;

		// Token: 0x040000BD RID: 189
		public static Vector3 MousePosition;

		// Token: 0x040000BE RID: 190
		public static bool MouseButton0;

		// Token: 0x040000BF RID: 191
		public static bool MouseButton1;

		// Token: 0x040000C0 RID: 192
		public static bool MouseButton2;

		// Token: 0x040000C1 RID: 193
		public static bool MouseButtonPrev0;

		// Token: 0x040000C2 RID: 194
		public static bool MouseButtonPrev1;

		// Token: 0x040000C3 RID: 195
		public static bool MouseButtonPrev2;

		// Token: 0x02000031 RID: 49
		public class User
		{
			// Token: 0x06000109 RID: 265 RVA: 0x00003BB6 File Offset: 0x00001DB6
			public static void ShowProfile(string playerId)
			{
			}

			// Token: 0x17000050 RID: 80
			// (get) Token: 0x0600010A RID: 266 RVA: 0x00003EA4 File Offset: 0x000020A4
			public static bool PermissionsFetchFailed
			{
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000051 RID: 81
			// (get) Token: 0x0600010B RID: 267 RVA: 0x00003EBC File Offset: 0x000020BC
			public static bool IsPatchRequired
			{
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000052 RID: 82
			// (get) Token: 0x0600010C RID: 268 RVA: 0x00003ED4 File Offset: 0x000020D4
			public static bool IsAgeRestricted
			{
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000053 RID: 83
			// (get) Token: 0x0600010D RID: 269 RVA: 0x00003EEC File Offset: 0x000020EC
			public static bool HasUserGeneratedContentPermissions
			{
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000054 RID: 84
			// (get) Token: 0x0600010E RID: 270 RVA: 0x00003F04 File Offset: 0x00002104
			public static bool HasChatPermissions
			{
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000055 RID: 85
			// (get) Token: 0x0600010F RID: 271 RVA: 0x00003B83 File Offset: 0x00001D83
			public static string UserUID
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000056 RID: 86
			// (get) Token: 0x06000110 RID: 272 RVA: 0x00003B83 File Offset: 0x00001D83
			public static string GamerTag
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06000111 RID: 273 RVA: 0x00003F1C File Offset: 0x0000211C
			public static bool CanViewPlayerOnline(string playerId)
			{
				return default(bool);
			}

			// Token: 0x06000112 RID: 274 RVA: 0x00003BB6 File Offset: 0x00001DB6
			[Conditional("UNITY_PS4")]
			public static void Start()
			{
			}

			// Token: 0x06000113 RID: 275 RVA: 0x00003BB6 File Offset: 0x00001DB6
			public static void ResetPermissions()
			{
			}

			// Token: 0x06000114 RID: 276 RVA: 0x00003BB6 File Offset: 0x00001DB6
			private static void SetupPermissions()
			{
			}

			// Token: 0x06000115 RID: 277 RVA: 0x00003BB6 File Offset: 0x00001DB6
			public User()
			{
			}

			// Token: 0x040000C4 RID: 196
			public static int PrimaryUserID;

			// Token: 0x040000C5 RID: 197
			private static bool UGCRestriction;

			// Token: 0x040000C6 RID: 198
			private static bool ChatRestriction;

			// Token: 0x040000C7 RID: 199
			private static bool PatchRequired;

			// Token: 0x040000C8 RID: 200
			private static bool AgeRestricted;

			// Token: 0x040000C9 RID: 201
			private static bool MultiplayerRestricted;

			// Token: 0x040000CA RID: 202
			private static bool SetupUserPermissions;
		}
	}

	// Token: 0x02000032 RID: 50
	public class Stadia
	{
		// Token: 0x06000116 RID: 278 RVA: 0x00003F34 File Offset: 0x00002134
		[Conditional("UNITY_STADIA")]
		public static void Start()
		{
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00003F44 File Offset: 0x00002144
		[Conditional("UNITY_STADIA")]
		public static void Setup()
		{
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00003F54 File Offset: 0x00002154
		[Conditional("UNITY_STADIA")]
		public static void Update()
		{
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00003F64 File Offset: 0x00002164
		public Stadia()
		{
		}

		// Token: 0x02000033 RID: 51
		public class User
		{
			// Token: 0x17000057 RID: 87
			// (get) Token: 0x0600011A RID: 282 RVA: 0x00003B83 File Offset: 0x00001D83
			public static string UserUID
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000058 RID: 88
			// (get) Token: 0x0600011B RID: 283 RVA: 0x00003F78 File Offset: 0x00002178
			public static bool HasMultiplayerPermissions
			{
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000059 RID: 89
			// (get) Token: 0x0600011C RID: 284 RVA: 0x00003F90 File Offset: 0x00002190
			public static bool HasChatPermissions
			{
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600011D RID: 285 RVA: 0x00003BB6 File Offset: 0x00001DB6
			public static void ShowMultiplayerRestrictionOverlay()
			{
			}

			// Token: 0x0600011E RID: 286 RVA: 0x00003BB6 File Offset: 0x00001DB6
			public User()
			{
			}

			// Token: 0x0600011F RID: 287 RVA: 0x00003BB6 File Offset: 0x00001DB6
			// Note: this type is marked as 'beforefieldinit'.
			static User()
			{
			}

			// Token: 0x040000CB RID: 203
			private static string savePath;
		}
	}

	// Token: 0x02000034 RID: 52
	public class Steam
	{
		// Token: 0x06000120 RID: 288 RVA: 0x00003FA8 File Offset: 0x000021A8
		[Conditional("UNITY_STEAM")]
		public static void Setup()
		{
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00003FB8 File Offset: 0x000021B8
		[Conditional("UNITY_STEAM")]
		public static void Update()
		{
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00003FC8 File Offset: 0x000021C8
		public Steam()
		{
		}

		// Token: 0x02000035 RID: 53
		public class User
		{
			// Token: 0x1700005A RID: 90
			// (get) Token: 0x06000123 RID: 291 RVA: 0x00003B83 File Offset: 0x00001D83
			public static string UserUID
			{
				get
				{
					return null;
				}
			}

			// Token: 0x1700005B RID: 91
			// (get) Token: 0x06000124 RID: 292 RVA: 0x00003B83 File Offset: 0x00001D83
			public static string GamerTag
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06000125 RID: 293 RVA: 0x00003B83 File Offset: 0x00001D83
			public static string GetAuthSessionTicket()
			{
				return null;
			}

			// Token: 0x06000126 RID: 294 RVA: 0x00003BB6 File Offset: 0x00001DB6
			public User()
			{
			}
		}
	}

	// Token: 0x02000036 RID: 54
	public class Switch
	{
		// Token: 0x06000127 RID: 295 RVA: 0x00003FDC File Offset: 0x000021DC
		[Conditional("UNITY_SWITCH")]
		public static void Setup()
		{
			DrPlatform.Switch.CPUBoostMode = true;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00003FF0 File Offset: 0x000021F0
		[Conditional("UNITY_SWITCH")]
		public static void Start()
		{
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00004000 File Offset: 0x00002200
		[Conditional("UNITY_SWITCH")]
		public static void Update()
		{
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600012A RID: 298 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool Docked
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00004010 File Offset: 0x00002210
		private static void SetCpuBoostMode(object data)
		{
			string text;
			Debug.Log(text);
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600012C RID: 300 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x0600012D RID: 301 RVA: 0x00004024 File Offset: 0x00002224
		public static bool CPUBoostMode
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00004040 File Offset: 0x00002240
		[Conditional("UNITY_SWITCH")]
		public static void ShowProfile(PlatformUser user)
		{
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00004050 File Offset: 0x00002250
		[Conditional("UNITY_SWITCH")]
		public static void FilterText(string value)
		{
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00004060 File Offset: 0x00002260
		public Switch()
		{
		}

		// Token: 0x040000CC RID: 204
		private static bool cpuBoost;
	}

	// Token: 0x02000037 RID: 55
	public class XBO
	{
		// Token: 0x06000131 RID: 305 RVA: 0x00004074 File Offset: 0x00002274
		[Conditional("UNITY_XBOXONE")]
		public static void Update()
		{
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00004084 File Offset: 0x00002284
		[Conditional("UNITY_XBOXONE")]
		public static void Setup()
		{
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00004094 File Offset: 0x00002294
		private static void Suspending()
		{
		}

		// Token: 0x06000134 RID: 308 RVA: 0x000040B4 File Offset: 0x000022B4
		private static void Resuming(double span)
		{
		}

		// Token: 0x06000135 RID: 309 RVA: 0x000040C4 File Offset: 0x000022C4
		private static void ResourceAvailabilityChangedEvent(bool amConstrained)
		{
		}

		// Token: 0x06000136 RID: 310 RVA: 0x000040D4 File Offset: 0x000022D4
		[Conditional("UNITY_XBOXONE")]
		public static void StartSession()
		{
		}

		// Token: 0x06000137 RID: 311 RVA: 0x000040E4 File Offset: 0x000022E4
		[Conditional("UNITY_XBOXONE")]
		public static void Start()
		{
		}

		// Token: 0x06000138 RID: 312 RVA: 0x000040F4 File Offset: 0x000022F4
		public XBO()
		{
		}

		// Token: 0x040000CD RID: 205
		public const string SCID = "f4f80100-7f03-4df9-8fbd-f0191738ca2a";

		// Token: 0x040000CE RID: 206
		private static bool _setup;

		// Token: 0x040000CF RID: 207
		private static NetworkReachability networkReachability;

		// Token: 0x02000038 RID: 56
		public class User
		{
			// Token: 0x1700005E RID: 94
			// (get) Token: 0x06000139 RID: 313 RVA: 0x00004108 File Offset: 0x00002308
			public static bool HasMultiplayerPermissions
			{
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700005F RID: 95
			// (get) Token: 0x0600013A RID: 314 RVA: 0x00004120 File Offset: 0x00002320
			public static bool HasUserGeneratedContentPermissions
			{
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000060 RID: 96
			// (get) Token: 0x0600013B RID: 315 RVA: 0x00004138 File Offset: 0x00002338
			public static bool HasChatPermissions
			{
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000061 RID: 97
			// (get) Token: 0x0600013C RID: 316 RVA: 0x00003B83 File Offset: 0x00001D83
			public static string UserUID
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000062 RID: 98
			// (get) Token: 0x0600013D RID: 317 RVA: 0x00003B83 File Offset: 0x00001D83
			public static string GamerTag
			{
				get
				{
					return null;
				}
			}

			// Token: 0x0600013E RID: 318 RVA: 0x00003BB6 File Offset: 0x00001DB6
			[Conditional("UNITY_XBOXONE")]
			public static void Start()
			{
			}

			// Token: 0x0600013F RID: 319 RVA: 0x00003BB6 File Offset: 0x00001DB6
			[Conditional("UNITY_XBOXONE")]
			public static void ShowGamerCard(string xboPlayerId)
			{
			}

			// Token: 0x06000140 RID: 320 RVA: 0x00003BB6 File Offset: 0x00001DB6
			public User()
			{
			}
		}
	}
}
