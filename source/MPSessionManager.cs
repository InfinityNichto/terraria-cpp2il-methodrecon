using System;
using Cpp2IlInjected;
using Terraria;

// Token: 0x020002B4 RID: 692
public class MPSessionManager
{
	// Token: 0x0600100A RID: 4106 RVA: 0x000021DB File Offset: 0x000003DB
	public static MPSessionManager Create()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x0600100B RID: 4107 RVA: 0x0004F1D8 File Offset: 0x0004D3D8
	public MPSessionManager()
	{
	}

	// Token: 0x0600100C RID: 4108 RVA: 0x0004F1EC File Offset: 0x0004D3EC
	private void SessionInviteJoined(MPSession newSession)
	{
		this.PendingSession = newSession;
	}

	// Token: 0x0600100D RID: 4109 RVA: 0x0004F200 File Offset: 0x0004D400
	public MPSession[] FindUserSessions(PlatformUser[] users)
	{
		/*
An exception occurred when decompiling this method (0600100D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling MPSession[] MPSessionManager::FindUserSessions(PlatformUser[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:MPSessionAPI(var_0_06, ldfld:MPSessionAPI(MPSessionManager::platformAPI, ldloc:MPSessionManager(this)))
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

	// Token: 0x0600100E RID: 4110 RVA: 0x0004F214 File Offset: 0x0004D414
	public MPSession CreateNewSession(PlatformUser hostUser, MPSessionManager.LobbyState state)
	{
		/*
An exception occurred when decompiling this method (0600100E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling MPSession MPSessionManager::CreateNewSession(PlatformUser,MPSessionManager/LobbyState)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:MPSessionAPI(var_0_06, ldfld:MPSessionAPI(MPSessionManager::platformAPI, ldloc:MPSessionManager(this)))
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

	// Token: 0x0600100F RID: 4111 RVA: 0x0004F228 File Offset: 0x0004D428
	public MPSession CreateNewDirectSession(PlatformUser hostUser, MPSessionManager.LobbyState state, string serverAddress, int serverPort)
	{
		/*
An exception occurred when decompiling this method (0600100F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling MPSession MPSessionManager::CreateNewDirectSession(PlatformUser,MPSessionManager/LobbyState,System.String,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:MPSessionAPI(var_0_06, ldfld:MPSessionAPI(MPSessionManager::platformAPI, ldloc:MPSessionManager(this)))
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

	// Token: 0x06001010 RID: 4112 RVA: 0x0004F23C File Offset: 0x0004D43C
	public void SetPendingSession(MPSession session)
	{
		this.PendingSession = session;
	}

	// Token: 0x06001011 RID: 4113 RVA: 0x0004F250 File Offset: 0x0004D450
	private void CheckShutdownSwitchMPMenus()
	{
	}

	// Token: 0x06001012 RID: 4114 RVA: 0x0004F260 File Offset: 0x0004D460
	public void UpdateUI()
	{
		bool gameMenu = Main.gameMenu;
		MPSession pendingSession = this.PendingSession;
		MPSession mpsession;
		if (pendingSession != null)
		{
			mpsession = this.sessionJoining;
			if (pendingSession == null)
			{
			}
			int menuMode = Main.menuMode;
			if (pendingSession == null)
			{
			}
			int menuMode2 = Main.menuMode;
			if (pendingSession == null)
			{
			}
			int menuMode3 = Main.menuMode;
			return;
		}
		MPSessionAPI mpsessionAPI = this.platformAPI;
		if (mpsession != null)
		{
		}
	}

	// Token: 0x06001013 RID: 4115 RVA: 0x0004F300 File Offset: 0x0004D500
	public void PlayerSelected()
	{
		if (this.sessionJoining != null)
		{
			MPSession mpsession = this.sessionJoining;
			return;
		}
		DrPlatform.DrPlatformType currentPlatform = DrPlatform.CurrentPlatform;
	}

	// Token: 0x06001014 RID: 4116 RVA: 0x0004F350 File Offset: 0x0004D550
	public void CancelPending()
	{
		if (this.sessionJoining != null && this.PendingSession != null)
		{
			PlatformUser currentUser = PlatformUser.CurrentUser;
			return;
		}
	}

	// Token: 0x06001015 RID: 4117 RVA: 0x0004F374 File Offset: 0x0004D574
	public void OpenInviteOverlay()
	{
		if (this.CurrentSession != null)
		{
			MPSessionAPI mpsessionAPI = this.platformAPI;
			PlatformUser currentUser = PlatformUser.CurrentUser;
			MPSession currentSession = this.CurrentSession;
			return;
		}
	}

	// Token: 0x04001D89 RID: 7561
	public static MPSessionManager Instance;

	// Token: 0x04001D8A RID: 7562
	private MPSession sessionJoining;

	// Token: 0x04001D8B RID: 7563
	public MPSession CurrentSession;

	// Token: 0x04001D8C RID: 7564
	public MPSession PendingSession;

	// Token: 0x04001D8D RID: 7565
	public MPSessionAPI platformAPI;

	// Token: 0x020002B5 RID: 693
	public enum LobbyState
	{
		// Token: 0x04001D8F RID: 7567
		None,
		// Token: 0x04001D90 RID: 7568
		MenuLobby,
		// Token: 0x04001D91 RID: 7569
		InProgress,
		// Token: 0x04001D92 RID: 7570
		Shutdown
	}
}
