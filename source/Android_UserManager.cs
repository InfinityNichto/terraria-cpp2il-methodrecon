using System;
using UnityEngine;

// Token: 0x02000025 RID: 37
public static class Android_UserManager
{
	// Token: 0x1700002F RID: 47
	// (get) Token: 0x060000B1 RID: 177 RVA: 0x000036EC File Offset: 0x000018EC
	public static DrPlatform.Android.User.LoginState CurrentState
	{
		get
		{
			if (!true)
			{
			}
			return DrPlatform.Android.User.LoginState.FromCache;
		}
	}

	// Token: 0x17000030 RID: 48
	// (get) Token: 0x060000B2 RID: 178 RVA: 0x00003704 File Offset: 0x00001904
	public static bool AttemptingSignIn
	{
		get
		{
			if (!true)
			{
			}
			return true;
		}
	}

	// Token: 0x17000031 RID: 49
	// (get) Token: 0x060000B3 RID: 179 RVA: 0x00003718 File Offset: 0x00001918
	public static string UserId
	{
		get
		{
			/*
An exception occurred when decompiling this method (060000B3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Android_UserManager::get_UserId()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}
	}

	// Token: 0x17000032 RID: 50
	// (get) Token: 0x060000B4 RID: 180 RVA: 0x00003728 File Offset: 0x00001928
	public static string GamerTag
	{
		get
		{
			/*
An exception occurred when decompiling this method (060000B4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Android_UserManager::get_GamerTag()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}
	}

	// Token: 0x17000033 RID: 51
	// (get) Token: 0x060000B5 RID: 181 RVA: 0x00003738 File Offset: 0x00001938
	public static string AccountProfileURL
	{
		get
		{
			/*
An exception occurred when decompiling this method (060000B5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Android_UserManager::get_AccountProfileURL()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}
	}

	// Token: 0x060000B6 RID: 182 RVA: 0x00003748 File Offset: 0x00001948
	public static void RequestLogin()
	{
		if (!true)
		{
		}
	}

	// Token: 0x060000B7 RID: 183 RVA: 0x00003758 File Offset: 0x00001958
	public static void Logout()
	{
		if (!true)
		{
		}
		Android_UserManager.playerLoggedOut();
	}

	// Token: 0x060000B8 RID: 184 RVA: 0x00003770 File Offset: 0x00001970
	public static void ClearCache()
	{
		PlayerPrefs.Save();
	}

	// Token: 0x060000B9 RID: 185 RVA: 0x00003784 File Offset: 0x00001984
	public static void Update()
	{
		if (true)
		{
			Debug.Log("Attempting player sign in");
			Android_UserManager.AttemptSignIn();
			bool isEditor = Application.isEditor;
			DateTime now = DateTime.Now;
			TimeSpan timeSpan;
			double totalSeconds = timeSpan.TotalSeconds;
			float editorSignInProcessTimeout = Android_UserManager.EditorSignInProcessTimeout;
			bool editorSignedIn = Android_UserManager.EditorSignedIn;
			return;
		}
	}

	// Token: 0x060000BA RID: 186 RVA: 0x000037FC File Offset: 0x000019FC
	private static void AttemptSignIn()
	{
		bool isEditor = Application.isEditor;
	}

	// Token: 0x060000BB RID: 187 RVA: 0x00003828 File Offset: 0x00001A28
	private static void playerLoggedOut()
	{
		string text;
		bool flag = string.IsNullOrEmpty(text);
	}

	// Token: 0x060000BC RID: 188 RVA: 0x00003844 File Offset: 0x00001A44
	private static void playerAuthenticated()
	{
		bool isEditor = Application.isEditor;
		if (!true)
		{
		}
		bool editorSignedIn = Android_UserManager.EditorSignedIn;
		if (!true)
		{
		}
		string editorUserId = Android_UserManager.EditorUserId;
		string editorUserId2 = Android_UserManager.EditorUserId;
		string editorUserAlias = Android_UserManager.EditorUserAlias;
		PlayerPrefs.Save();
		DrPlatform.User.OnPlatformUserChanged();
		PlayerPrefs.Save();
	}

	// Token: 0x060000BD RID: 189 RVA: 0x00003890 File Offset: 0x00001A90
	private static void _authenticationSucceededEvent(string userID)
	{
		if (!true)
		{
		}
		Debug.Log("Player authenticated :" + userID);
		Android_UserManager.playerAuthenticated();
	}

	// Token: 0x060000BE RID: 190 RVA: 0x000038B8 File Offset: 0x00001AB8
	private static void _authenticationFailedEvent(string error)
	{
		if (!true)
		{
		}
		Debug.Log("Player Failed to authenticate :" + error);
		Android_UserManager.playerLoggedOut();
	}

	// Token: 0x17000034 RID: 52
	// (get) Token: 0x060000BF RID: 191 RVA: 0x000038E0 File Offset: 0x00001AE0
	// (set) Token: 0x060000C0 RID: 192 RVA: 0x000038FC File Offset: 0x00001AFC
	public static bool EditorSignedIn
	{
		get
		{
			/*
An exception occurred when decompiling this method (060000BF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Android_UserManager::get_EditorSignedIn()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int64(var_0_01, ldc.i4:int64(0))
	stloc:int32(var_1_0D, call:int32(PlayerPrefs::GetInt, ldstr:string("Editor_GPSignedIn"), ldloc:int64[exp:int32](var_0_01)))
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
		set
		{
			PlayerPrefs.Save();
		}
	}

	// Token: 0x17000035 RID: 53
	// (get) Token: 0x060000C1 RID: 193 RVA: 0x00003910 File Offset: 0x00001B10
	// (set) Token: 0x060000C2 RID: 194 RVA: 0x00003920 File Offset: 0x00001B20
	public static string EditorUserId
	{
		get
		{
			string text;
			return text;
		}
		set
		{
			PlayerPrefs.SetString("Editor_GPUserId", value);
			PlayerPrefs.Save();
		}
	}

	// Token: 0x17000036 RID: 54
	// (get) Token: 0x060000C3 RID: 195 RVA: 0x00003940 File Offset: 0x00001B40
	// (set) Token: 0x060000C4 RID: 196 RVA: 0x00003950 File Offset: 0x00001B50
	public static string EditorUserAlias
	{
		get
		{
			string text;
			return text;
		}
		set
		{
			PlayerPrefs.SetString("Editor_GPUserAlias", value);
			PlayerPrefs.Save();
		}
	}

	// Token: 0x17000037 RID: 55
	// (get) Token: 0x060000C5 RID: 197 RVA: 0x00003970 File Offset: 0x00001B70
	// (set) Token: 0x060000C6 RID: 198 RVA: 0x00003984 File Offset: 0x00001B84
	public static float EditorSignInProcessTimeout
	{
		get
		{
			return "Editor_GPSignInTimeout";
		}
		set
		{
			PlayerPrefs.SetFloat("Editor_GPSignInTimeout", value);
			PlayerPrefs.Save();
		}
	}

	// Token: 0x060000C7 RID: 199 RVA: 0x000039A4 File Offset: 0x00001BA4
	// Note: this type is marked as 'beforefieldinit'.
	static Android_UserManager()
	{
	}

	// Token: 0x0400007D RID: 125
	public static bool EditorAttemptingSignIn;

	// Token: 0x0400007E RID: 126
	public static DateTime EditorSignInStart;

	// Token: 0x0400007F RID: 127
	private static bool _delayedStartup;

	// Token: 0x04000080 RID: 128
	private static string s_userId;

	// Token: 0x04000081 RID: 129
	private static string s_gamerTag;

	// Token: 0x04000082 RID: 130
	private static string s_avatarImageURL;

	// Token: 0x04000083 RID: 131
	private static bool s_requestedLogin;

	// Token: 0x04000084 RID: 132
	private static bool s_attemptedPassiveLogin;

	// Token: 0x04000085 RID: 133
	private static bool s_currentlyLoggingIn;

	// Token: 0x04000086 RID: 134
	private const string c_accountIdLastUserKey = "AccountId_LastUser";

	// Token: 0x04000087 RID: 135
	private const string c_accountIdLastUserGameTag = "AccountGamerTag_LastUser";

	// Token: 0x04000088 RID: 136
	private static bool s_usingCachedId;
}
