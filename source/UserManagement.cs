using System;
using System.Collections.Generic;
using Controller;
using Terraria;
using Terraria.Localization;
using UnityEngine;

// Token: 0x020002C1 RID: 705
public class UserManagement
{
	// Token: 0x06001049 RID: 4169 RVA: 0x0004FFF0 File Offset: 0x0004E1F0
	public static void HandleNetworkLost()
	{
		if (!true)
		{
		}
		bool gameMenu = Main.gameMenu;
		Main.menuMode = 10;
		Main.gameMenu = true;
		Debug.LogWarning(Language.GetTextValue("Net.LostConnection"));
	}

	// Token: 0x0600104A RID: 4170 RVA: 0x00050030 File Offset: 0x0004E230
	public static void SetupPrimary()
	{
		PlatformUser currentUser = PlatformUser.CurrentUser;
		if (!true)
		{
		}
		UserManagement.SwitchPrimaryUser(currentUser);
	}

	// Token: 0x0600104B RID: 4171 RVA: 0x0005004C File Offset: 0x0004E24C
	public static void SwitchPrimaryUser(PlatformUser platformUser)
	{
		if (!true)
		{
		}
	}

	// Token: 0x0600104C RID: 4172 RVA: 0x000500C0 File Offset: 0x0004E2C0
	public static void UserSignIn(ControllerDevice localDevice, PlatformUser platformUser)
	{
		int num = 1;
		if (num == 0)
		{
		}
		if (num == 0)
		{
		}
		if (num == 0)
		{
		}
	}

	// Token: 0x0600104D RID: 4173 RVA: 0x000500EC File Offset: 0x0004E2EC
	public static void AddUser(ControllerDevice localDevice, PlatformUser platformUser)
	{
		int num = 1;
		if (num == 0)
		{
		}
		if (num == 0)
		{
		}
	}

	// Token: 0x0600104E RID: 4174 RVA: 0x0005011C File Offset: 0x0004E31C
	public static void UserSignedOut(PlatformUser user)
	{
		if (!true)
		{
		}
	}

	// Token: 0x0600104F RID: 4175 RVA: 0x00050134 File Offset: 0x0004E334
	public static void LocalUserQuit(LocalUser user)
	{
		int num = 1;
		if (num == 0)
		{
		}
		int userIndex = user.UserIndex;
		if (num == 0)
		{
		}
		Player.Hooks.PlayerDisconnect(userIndex);
		if (num == 0)
		{
		}
		ThreadManager.TerminateUserThreads(user);
		user.GameState._achievements.Shutdown();
		user.fileManager.Shutdown();
		GameObject gameObject = user.UICameraSettings.Camera.gameObject;
		long num2 = 0L;
		gameObject.SetActive(num2 != 0L);
		GameObject gameObject2 = user.WorldCameraSettings.Camera.gameObject;
		long num3 = 0L;
		gameObject2.SetActive(num3 != 0L);
		GUIInstance guiinstance = user.GUIInstance;
		guiinstance.GUIMap.CleanupMapTargets();
		if (guiinstance == null)
		{
		}
		InterfaceProfile_Layout active = guiinstance._active;
	}

	// Token: 0x06001050 RID: 4176 RVA: 0x000501DC File Offset: 0x0004E3DC
	public static void SignInController(ControllerDevice localDevice)
	{
	}

	// Token: 0x06001051 RID: 4177 RVA: 0x000501EC File Offset: 0x0004E3EC
	public static bool CanControllerBeUserForPrimaryPlayer(ControllerDevice localDevice)
	{
		return true;
	}

	// Token: 0x06001052 RID: 4178 RVA: 0x000501FC File Offset: 0x0004E3FC
	public static bool CanControllerBeUsedForPlayer(ControllerDevice localDevice, LocalUser user)
	{
		return true;
	}

	// Token: 0x06001053 RID: 4179 RVA: 0x0005020C File Offset: 0x0004E40C
	public static LocalUser FindLocalUserByUser(PlatformUser user)
	{
		if (!true)
		{
			return;
		}
	}

	// Token: 0x06001054 RID: 4180 RVA: 0x00050224 File Offset: 0x0004E424
	public static LocalUser FindLocalUserByPlayer(Player player)
	{
		if (!true)
		{
			return;
		}
	}

	// Token: 0x06001055 RID: 4181 RVA: 0x0005023C File Offset: 0x0004E43C
	public static LocalUser FindLocalUserByController(ControllerDevice controller)
	{
		/*
An exception occurred when decompiling this method (06001055)

ICSharpCode.Decompiler.DecompilerException: Error decompiling LocalUser UserManagement::FindLocalUserByController(Controller.ControllerDevice)

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

	// Token: 0x06001056 RID: 4182 RVA: 0x00050250 File Offset: 0x0004E450
	public static void LookForNewUsers()
	{
		if (!true)
		{
		}
		PresenceManager.Update();
		LocalUser localUser;
		if (localUser == null)
		{
			bool gameMenu = Main.gameMenu;
		}
	}

	// Token: 0x06001057 RID: 4183 RVA: 0x00050294 File Offset: 0x0004E494
	public void SwitchUser(int index)
	{
	}

	// Token: 0x06001058 RID: 4184 RVA: 0x000502A4 File Offset: 0x0004E4A4
	public static void UpdateViewPorts()
	{
		if (!true)
		{
		}
		Rect rect;
		Vector2 center = rect.center;
		int screenWidth = XNAUnityRunner.ScreenWidth;
		int screenHeight = XNAUnityRunner.ScreenHeight;
	}

	// Token: 0x06001059 RID: 4185 RVA: 0x000502D4 File Offset: 0x0004E4D4
	public void ApplyCameras()
	{
		if (!true)
		{
		}
	}

	// Token: 0x0600105A RID: 4186 RVA: 0x000502EC File Offset: 0x0004E4EC
	public UserManagement()
	{
	}

	// Token: 0x0600105B RID: 4187 RVA: 0x00050300 File Offset: 0x0004E500
	// Note: this type is marked as 'beforefieldinit'.
	static UserManagement()
	{
	}

	// Token: 0x04001F3B RID: 7995
	private static List<int> AvailableIndices;

	// Token: 0x04001F3C RID: 7996
	public static bool SplitHorizontalFirst;

	// Token: 0x04001F3D RID: 7997
	public static LocalUser PrimaryPlayer;

	// Token: 0x04001F3E RID: 7998
	public static List<LocalUser> LocalUsers;

	// Token: 0x04001F3F RID: 7999
	public static LocalUser PendingUser;
}
