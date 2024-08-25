using System;
using System.IO;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;
using Terraria;
using UnityEngine;

// Token: 0x0200030B RID: 779
public class XNAUnityRunner : MonoBehaviour
{
	// Token: 0x170001B4 RID: 436
	// (get) Token: 0x06001216 RID: 4630 RVA: 0x000581F8 File Offset: 0x000563F8
	public static XNAUnityRunner.ForcedInputMode CurrentInputMode
	{
		get
		{
			return XNAUnityRunner.ForcedInputMode.KeyboardMouse;
		}
	}

	// Token: 0x170001B5 RID: 437
	// (get) Token: 0x06001217 RID: 4631 RVA: 0x00058208 File Offset: 0x00056408
	public static XNAUnityRunner.ForcedInputMode PrimaryInputMode
	{
		get
		{
			return XNAUnityRunner.ForcedInputMode.KeyboardMouse;
		}
	}

	// Token: 0x06001218 RID: 4632 RVA: 0x0005823C File Offset: 0x0005643C
	private void Awake()
	{
		DrPlatform.Setup();
		if (!true)
		{
		}
		LayoutDefinition.LoadReleaseLayout();
		Application.targetFrameRate = 60;
		if (!true)
		{
		}
		if (!true)
		{
		}
		long num = 0L;
		UserManagement.SetupPrimary();
		Screen.sleepTimeout = (int)num;
		this.WorldCameraSettings.ApplyCamera();
		this.UICameraSettings.ApplyCamera();
		Singleton.Create();
	}

	// Token: 0x06001219 RID: 4633 RVA: 0x00058290 File Offset: 0x00056490
	private void Start()
	{
		this._game.UnityStart();
		this.isStarted = true;
	}

	// Token: 0x0600121A RID: 4634 RVA: 0x000582B0 File Offset: 0x000564B0
	private void Application_lowMemory()
	{
		if (!true)
		{
		}
		TextureAtlasDB.UnloadAssets();
		TextureAtlasDB.ActionPendingUnloadAssets(false);
	}

	// Token: 0x0600121B RID: 4635 RVA: 0x000582D0 File Offset: 0x000564D0
	private void OnDisable()
	{
		if (!true)
		{
		}
	}

	// Token: 0x0600121C RID: 4636 RVA: 0x000582E0 File Offset: 0x000564E0
	private void OnGUI()
	{
	}

	// Token: 0x0600121D RID: 4637 RVA: 0x000582F0 File Offset: 0x000564F0
	public void OnApplicationQuit()
	{
		if (!true)
		{
		}
		Netplay.ServerLoopUpdateFrame();
		if (!true)
		{
		}
		ThreadManager.TerminateAll();
		ServerAutoFinder.StopSearching();
		Netplay.StopBroadCasting();
	}

	// Token: 0x0600121E RID: 4638 RVA: 0x00058320 File Offset: 0x00056520
	private void OnApplicationFocus(bool focus)
	{
		DrKeyboard_Touch.AppFocusGained();
	}

	// Token: 0x0600121F RID: 4639 RVA: 0x00058338 File Offset: 0x00056538
	private void OnApplicationPause(bool pause)
	{
		Game game = this._game;
		if (game != null)
		{
			if (game == null)
			{
			}
			if (game != null)
			{
				bool isEditor = Application.isEditor;
				DrPlatform.DrPlatformType currentPlatform = DrPlatform.CurrentPlatform;
				XBOChatPermissions.Reset();
				XBOOnlinePresencePermissions.Reset();
				Game game2 = this._game;
				bool active = game2._active;
				long num = 0L;
				game2._active = active;
				if (game2 == null)
				{
				}
				if (game2.content.p == null)
				{
				}
				if (num != 0L)
				{
					return;
				}
				if (this._game != null)
				{
				}
				if (Main.ActivePlayerFileData != null)
				{
					Main.ActivePlayerFileData.OnLostFocus();
				}
				return;
			}
		}
	}

	// Token: 0x06001220 RID: 4640 RVA: 0x000583E0 File Offset: 0x000565E0
	private string GetNextScreenshotFilename()
	{
		string text;
		bool flag = text.EndsWith("/");
		DirectoryInfo directoryInfo = Directory.CreateDirectory(text + "/");
		string text3;
		string text4;
		string text2 = text3 + "_" + text4 + ".png";
		bool flag2 = File.Exists(text2);
		return text2;
	}

	// Token: 0x170001B6 RID: 438
	// (get) Token: 0x06001221 RID: 4641 RVA: 0x0005842C File Offset: 0x0005662C
	public static int ScreenWidth
	{
		get
		{
			return Screen.width;
		}
	}

	// Token: 0x170001B7 RID: 439
	// (get) Token: 0x06001222 RID: 4642 RVA: 0x00058440 File Offset: 0x00056640
	public static int ScreenHeight
	{
		get
		{
			return Screen.height;
		}
	}

	// Token: 0x06001223 RID: 4643 RVA: 0x00058454 File Offset: 0x00056654
	private void Update()
	{
		if (!true)
		{
		}
		ThreadManager.Update();
		float deltaTime = Time.deltaTime;
		this.ExecuteFrame(deltaTime);
	}

	// Token: 0x170001B8 RID: 440
	// (get) Token: 0x06001224 RID: 4644 RVA: 0x0005847C File Offset: 0x0005667C
	public static global::UnityEngine.Vector3 MousePosition
	{
		get
		{
			/*
An exception occurred when decompiling this method (06001224)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Vector3 XNAUnityRunner::get_MousePosition()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:DrPlatformType(var_2_07, callgetter:DrPlatformType(DrPlatform::get_CurrentPlatform))
	stloc:DrPlatformType(var_4_0F, callgetter:DrPlatformType(DrPlatform::get_CurrentPlatform))
	stloc:iOS_Mouse(var_6_19, callgetter:iOS_Mouse(IOS::get_Mouse))
	stloc:float32(var_7_27, ldfld:float32(Vector3::x, ldfld:Vector3[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Vector3&](iOS_Mouse::MousePosition, ldloc:iOS_Mouse(var_6_19))))
	stloc:float32(var_8_35, ldfld:float32(Vector3::y, ldfld:Vector3[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Vector3&](iOS_Mouse::MousePosition, ldloc:iOS_Mouse(var_6_19))))
	stloc:float32(var_9_43, ldfld:float32(Vector3::z, ldfld:Vector3[exp:valuetype [UnityEngine.CoreModule]UnityEngine.Vector3&](iOS_Mouse::MousePosition, ldloc:iOS_Mouse(var_6_19))))
	stloc:Vector3(var_11_4D, callgetter:Vector3(Input::get_mousePosition))
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

	// Token: 0x170001B9 RID: 441
	// (get) Token: 0x06001225 RID: 4645 RVA: 0x000584D8 File Offset: 0x000566D8
	public static global::UnityEngine.Vector3 MousePositionReal
	{
		get
		{
			if (!true)
			{
			}
			global::UnityEngine.Vector3 mousePosition = XNAUnityRunner.MousePosition;
			return 1;
		}
	}

	// Token: 0x06001226 RID: 4646 RVA: 0x000584F0 File Offset: 0x000566F0
	public static float GetMouseScrollDelta(bool ignoreEditor = false)
	{
		/*
An exception occurred when decompiling this method (06001226)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single XNAUnityRunner::GetMouseScrollDelta(System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:DrPlatformType(var_2_07, callgetter:DrPlatformType(DrPlatform::get_CurrentPlatform))
	stloc:float32(var_4_14, ldfld:float32(iOS_Mouse::MouseScroll, callgetter:iOS_Mouse(IOS::get_Mouse)))
	stloc:Vector2(var_6_1E, callgetter:Vector2(Input::get_mouseScrollDelta))
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

	// Token: 0x06001227 RID: 4647 RVA: 0x0005851C File Offset: 0x0005671C
	public static bool GetMouseButton(int index, bool ignoreEditor = false)
	{
		bool flag;
		return flag;
	}

	// Token: 0x06001228 RID: 4648 RVA: 0x00058564 File Offset: 0x00056764
	public static bool GetMouseButtonUp(int index, bool ignoreEditor = false)
	{
		bool flag;
		return flag;
	}

	// Token: 0x06001229 RID: 4649 RVA: 0x000585DC File Offset: 0x000567DC
	public static bool GetMouseButtonDown(int index, bool ignoreEditor = false)
	{
		bool flag;
		return flag;
	}

	// Token: 0x170001BA RID: 442
	// (get) Token: 0x0600122A RID: 4650 RVA: 0x00058654 File Offset: 0x00056854
	// (set) Token: 0x0600122B RID: 4651 RVA: 0x00058664 File Offset: 0x00056864
	public static bool MobileKeyboardLocked
	{
		get
		{
			/*
An exception occurred when decompiling this method (0600122A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean XNAUnityRunner::get_MobileKeyboardLocked()

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
		set
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			XNAUnityRunner.MobileControllerLocked = false;
		}
	}

	// Token: 0x170001BB RID: 443
	// (get) Token: 0x0600122C RID: 4652 RVA: 0x00058680 File Offset: 0x00056880
	public static bool KeyboardModeLocked
	{
		get
		{
			bool flag = DrPlatform.IsCurrentPlatform(DrPlatform.DrPlatformType.Mobile);
			if (!true)
			{
			}
			if (!true)
			{
				return;
			}
		}
	}

	// Token: 0x170001BC RID: 444
	// (get) Token: 0x0600122D RID: 4653 RVA: 0x0005869C File Offset: 0x0005689C
	// (set) Token: 0x0600122E RID: 4654 RVA: 0x000586AC File Offset: 0x000568AC
	public static bool MobileControllerLocked
	{
		get
		{
			/*
An exception occurred when decompiling this method (0600122D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean XNAUnityRunner::get_MobileControllerLocked()

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
		set
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			XNAUnityRunner.MobileKeyboardLocked = false;
		}
	}

	// Token: 0x170001BD RID: 445
	// (get) Token: 0x0600122F RID: 4655 RVA: 0x000586C8 File Offset: 0x000568C8
	public static bool ControllerModeLocked
	{
		get
		{
			DrPlatform.DrPlatformType currentPlatform = DrPlatform.CurrentPlatform;
			return true;
		}
	}

	// Token: 0x170001BE RID: 446
	// (get) Token: 0x06001230 RID: 4656 RVA: 0x000586F0 File Offset: 0x000568F0
	// (set) Token: 0x06001231 RID: 4657 RVA: 0x00058700 File Offset: 0x00056900
	public static bool MobileTouchLocked
	{
		get
		{
			/*
An exception occurred when decompiling this method (06001230)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean XNAUnityRunner::get_MobileTouchLocked()

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
		set
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			XNAUnityRunner.MobileKeyboardLocked = false;
			XNAUnityRunner.MobileControllerLocked = false;
		}
	}

	// Token: 0x170001BF RID: 447
	// (get) Token: 0x06001232 RID: 4658 RVA: 0x00058720 File Offset: 0x00056920
	public static bool TouchInputKeyboardLocked
	{
		get
		{
			if (!true)
			{
			}
			bool touchModeLocked = XNAUnityRunner.TouchModeLocked;
			bool flag = DrPlatform.IsCurrentPlatform((DrPlatform.DrPlatformType)10);
			bool mousePresent = Input.mousePresent;
			return true;
		}
	}

	// Token: 0x170001C0 RID: 448
	// (get) Token: 0x06001233 RID: 4659 RVA: 0x0005874C File Offset: 0x0005694C
	public static bool TouchModeLocked
	{
		get
		{
			bool flag = DrPlatform.IsCurrentPlatform(DrPlatform.DrPlatformType.Mobile);
			if (!true)
			{
			}
			if (!true)
			{
				return;
			}
		}
	}

	// Token: 0x06001234 RID: 4660 RVA: 0x00058768 File Offset: 0x00056968
	private void SetMobileMouseMode(int mode)
	{
		this.mobileMouseMode = mode;
		int num = this.mobileMouseMode;
		if (num != 0)
		{
		}
	}

	// Token: 0x06001235 RID: 4661 RVA: 0x000587D4 File Offset: 0x000569D4
	private void ExecuteFrame(float timeDelta)
	{
		int num = 1;
		if (num == 0)
		{
		}
		if (num == 0)
		{
		}
		KeyboardInput.Update();
		if (num == 0)
		{
		}
		ThreadContentRequest.UpdatingLoading();
		UserManagement.LookForNewUsers();
		long num2 = 0L;
		this.WorldCameraSettings.ApplyCamera();
		this.UICameraSettings.ApplyCamera();
		if (num2 != 0L)
		{
			DrPlatform.DrPlatformType currentPlatform = DrPlatform.CurrentPlatform;
		}
		DrPlatform.PS4.UpdateMouse();
		DrPlatform.IOS.UpdateMouse();
		XNAUnityRunner.MobileControllerLocked = false;
		int num3 = 1;
		if (num3 == 0)
		{
		}
		if (num3 != 0)
		{
			XNAUnityRunner.MobileKeyboardLocked = false;
		}
		bool keyboardOpen = this.KeyboardOpen;
		bool hasKeyboard = Main.HasKeyboard;
		if (keyboardOpen)
		{
			global::UnityEngine.Vector3 mousePosition = XNAUnityRunner.MousePosition;
			return;
		}
		int num4 = 1;
		this.KeyboardOpen = num4 != 0;
	}

	// Token: 0x170001C1 RID: 449
	// (get) Token: 0x06001236 RID: 4662 RVA: 0x00058AE0 File Offset: 0x00056CE0
	public static bool RenderingUI
	{
		get
		{
			/*
An exception occurred when decompiling this method (06001236)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean XNAUnityRunner::get_RenderingUI()

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

	// Token: 0x170001C2 RID: 450
	// (get) Token: 0x06001237 RID: 4663 RVA: 0x000021DB File Offset: 0x000003DB
	private static XNAUnityRunner.MouseStateBackup _uiMouseState
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x170001C3 RID: 451
	// (get) Token: 0x06001238 RID: 4664 RVA: 0x000021DB File Offset: 0x000003DB
	private static XNAUnityRunner.MouseStateBackup _worldMouseState
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x170001C4 RID: 452
	// (get) Token: 0x06001239 RID: 4665 RVA: 0x000021DB File Offset: 0x000003DB
	// (set) Token: 0x0600123A RID: 4666 RVA: 0x00058AF0 File Offset: 0x00056CF0
	private static int _lastUIFrame
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
		set
		{
		}
	}

	// Token: 0x0600123B RID: 4667 RVA: 0x00058B00 File Offset: 0x00056D00
	public static Microsoft.Xna.Framework.Vector2 AdjustRealScreenForUI(Microsoft.Xna.Framework.Vector2 inputPosition)
	{
		/*
An exception occurred when decompiling this method (0600123B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 XNAUnityRunner::AdjustRealScreenForUI(Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_1_0A, callgetter:int32(Screen::get_width))
	stloc:int32(var_3_12, callgetter:int32(Screen::get_height))
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

	// Token: 0x0600123C RID: 4668 RVA: 0x00058B20 File Offset: 0x00056D20
	public static Microsoft.Xna.Framework.Vector2 AdjustWorldForRealScreen(Microsoft.Xna.Framework.Vector2 inputPosition)
	{
		/*
An exception occurred when decompiling this method (0600123C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 XNAUnityRunner::AdjustWorldForRealScreen(Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000E:
	stloc:int32(var_3_15, callgetter:int32(Screen::get_width))
	stloc:Vector2(var_5_1E, callgetter:Vector2(Main::get_screenPosition))
	stloc:int32(var_7_28, callgetter:int32(Screen::get_height))
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

	// Token: 0x0600123D RID: 4669 RVA: 0x00058B58 File Offset: 0x00056D58
	public static Microsoft.Xna.Framework.Vector2 AdjustUIForRealScreen(Microsoft.Xna.Framework.Vector2 inputPosition)
	{
		/*
An exception occurred when decompiling this method (0600123D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 XNAUnityRunner::AdjustUIForRealScreen(Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_1_0A, callgetter:int32(Screen::get_width))
	stloc:int32(var_3_12, callgetter:int32(Screen::get_height))
	stloc:int32(var_5_1B, callgetter:int32(Screen::get_height))
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

	// Token: 0x0600123E RID: 4670 RVA: 0x00058B84 File Offset: 0x00056D84
	public static Microsoft.Xna.Framework.Vector2 AdjustWorldPositionForUI(Microsoft.Xna.Framework.Vector2 inputPosition)
	{
		/*
An exception occurred when decompiling this method (0600123E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 XNAUnityRunner::AdjustWorldPositionForUI(Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0010:
	stloc:Vector2(var_4_17, callgetter:Vector2(Main::get_screenPosition))
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

	// Token: 0x0600123F RID: 4671 RVA: 0x00058BAC File Offset: 0x00056DAC
	public static Microsoft.Xna.Framework.Vector2 ScaleUIDirectionForRealScreen(Microsoft.Xna.Framework.Vector2 inputPosition)
	{
		/*
An exception occurred when decompiling this method (0600123F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 XNAUnityRunner::ScaleUIDirectionForRealScreen(Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_1_0A, callgetter:int32(Screen::get_width))
	stloc:int32(var_3_12, callgetter:int32(Screen::get_height))
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

	// Token: 0x06001240 RID: 4672 RVA: 0x00058BCC File Offset: 0x00056DCC
	public static Microsoft.Xna.Framework.Vector2 ScaleScreenDirectionForWorld(Microsoft.Xna.Framework.Vector2 inputPosition)
	{
		if (!true)
		{
		}
		return 32640;
	}

	// Token: 0x06001241 RID: 4673 RVA: 0x00058BE4 File Offset: 0x00056DE4
	public static Microsoft.Xna.Framework.Vector2 ScaleWorldDirectionForScreen(Microsoft.Xna.Framework.Vector2 inputPosition)
	{
		if (!true)
		{
		}
		return 32640;
	}

	// Token: 0x06001242 RID: 4674 RVA: 0x00058BFC File Offset: 0x00056DFC
	public static Microsoft.Xna.Framework.Vector2 AdjustScreenPositionForWorld(Microsoft.Xna.Framework.Vector2 inputPosition)
	{
		/*
An exception occurred when decompiling this method (06001242)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 XNAUnityRunner::AdjustScreenPositionForWorld(Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:Vector2(var_1_0A, callgetter:Vector2(Main::get_screenPosition))
	stloc:Vector2(var_3_12, callgetter:Vector2(Main::get_screenPosition))
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

	// Token: 0x06001243 RID: 4675 RVA: 0x00058C1C File Offset: 0x00056E1C
	public static void SetupRenderingUI(bool renderingUI)
	{
		if (!true)
		{
		}
	}

	// Token: 0x06001244 RID: 4676 RVA: 0x00058D1C File Offset: 0x00056F1C
	public XNAUnityRunner()
	{
		this.lastMousePosition.z = (float)50298;
		this.ReleaseVersion = "v1.3.0.7.2 Build ";
		this.mobileMouseMode = 50298;
		base..ctor();
	}

	// Token: 0x06001245 RID: 4677 RVA: 0x00058D7C File Offset: 0x00056F7C
	// Note: this type is marked as 'beforefieldinit'.
	static XNAUnityRunner()
	{
	}

	// Token: 0x040021A4 RID: 8612
	public static XNAUnityRunner _instance;

	// Token: 0x040021A5 RID: 8613
	public XNAWorldCameraSettings WorldCameraSettings;

	// Token: 0x040021A6 RID: 8614
	public XNAUICameraSettings UICameraSettings;

	// Token: 0x040021A7 RID: 8615
	public bool IncrementalBatching;

	// Token: 0x040021A8 RID: 8616
	public bool LogMaterialCreation;

	// Token: 0x040021A9 RID: 8617
	public bool DisableVariableUpdate;

	// Token: 0x040021AA RID: 8618
	public Microsoft.Xna.Framework.Vector2 IncrementalBatchingOffset;

	// Token: 0x040021AB RID: 8619
	public bool EnableBatching = true;

	// Token: 0x040021AC RID: 8620
	public bool DumpMemory;

	// Token: 0x040021AD RID: 8621
	public string ReleaseVersion;

	// Token: 0x040021AE RID: 8622
	public int BuildNumber;

	// Token: 0x040021AF RID: 8623
	public bool DumpGeometryStats;

	// Token: 0x040021B0 RID: 8624
	public float DefaultUITabletMode = (float)16512;

	// Token: 0x040021B1 RID: 8625
	public Texture2D WaterMask;

	// Token: 0x040021B2 RID: 8626
	public int WorldInputEdgeRange = 28;

	// Token: 0x040021B3 RID: 8627
	public long SimulatedDiskSpace;

	// Token: 0x040021B4 RID: 8628
	public long SimulatedDeviceMemory;

	// Token: 0x040021B5 RID: 8629
	public bool SimulatedCloudRequired;

	// Token: 0x040021B6 RID: 8630
	public bool SimulatedCloudAvailable;

	// Token: 0x040021B7 RID: 8631
	public bool SimulatedCloudConnected;

	// Token: 0x040021B8 RID: 8632
	public float SimulatedCloudSyncTime = (float)16256;

	// Token: 0x040021B9 RID: 8633
	public XNAUnityRunner.ForcedInputMode ForcedInput;

	// Token: 0x040021BA RID: 8634
	private Game _game;

	// Token: 0x040021BB RID: 8635
	public bool isStarted;

	// Token: 0x040021BC RID: 8636
	private static bool broadcastTest;

	// Token: 0x040021BD RID: 8637
	private static bool firstUpdate;

	// Token: 0x040021BE RID: 8638
	private static global::UnityEngine.Vector3 LastMousePosition;

	// Token: 0x040021BF RID: 8639
	private global::UnityEngine.Vector3 lastMousePosition;

	// Token: 0x040021C0 RID: 8640
	private bool KeyboardOpen;

	// Token: 0x040021C1 RID: 8641
	private bool lastFrameSplitHorizontal;

	// Token: 0x040021C2 RID: 8642
	private int lastSplitPlayerCount;

	// Token: 0x040021C3 RID: 8643
	public bool SplitscreenOrientationChanged;

	// Token: 0x040021C4 RID: 8644
	private bool switchNextFrame;

	// Token: 0x040021C5 RID: 8645
	public static bool _mobileKeyboardLocked;

	// Token: 0x040021C6 RID: 8646
	public static int DelayInputSwitch;

	// Token: 0x040021C7 RID: 8647
	public static bool _mobileControllerLocked;

	// Token: 0x040021C8 RID: 8648
	public static bool _mobileTouchLocked;

	// Token: 0x040021C9 RID: 8649
	private int mobileMouseMode;

	// Token: 0x040021CA RID: 8650
	private static bool _renderingUI;

	// Token: 0x040021CB RID: 8651
	public static int _frame;

	// Token: 0x040021CC RID: 8652
	public AnimationCurve FireAxisRemap;

	// Token: 0x0200030C RID: 780
	public enum ForcedInputMode
	{
		// Token: 0x040021CE RID: 8654
		None,
		// Token: 0x040021CF RID: 8655
		Touch,
		// Token: 0x040021D0 RID: 8656
		Controller,
		// Token: 0x040021D1 RID: 8657
		KeyboardMouse
	}

	// Token: 0x0200030D RID: 781
	public class MouseStateBackup
	{
		// Token: 0x06001246 RID: 4678 RVA: 0x00058D8C File Offset: 0x00056F8C
		public void Capture()
		{
			if (!true)
			{
			}
			int mouseX = Main.mouseX;
			this._mouseX = mouseX;
			int mouseY = Main.mouseY;
			this._mouseY = mouseY;
			int lastMouseX = Main.lastMouseX;
			this._lastMouseX = lastMouseX;
			int lastMouseY = Main.lastMouseY;
			this._lastMouseX = lastMouseY;
			bool mouseLeft = Main.mouseLeft;
			this._mouseLeft = true;
			bool mouseLeftRelease = Main.mouseLeftRelease;
			this._mouseLeftRelease = true;
			bool mouseRight = Main.mouseRight;
			this._mouseRight = true;
			bool mouseRightRelease = Main.mouseRightRelease;
			this._mouseRightRelease = true;
			int worldMouseX = Main.worldMouseX;
			this._worldMouseX = worldMouseX;
			int worldMouseY = Main.worldMouseY;
			this._worldMouseY = worldMouseY;
		}

		// Token: 0x06001247 RID: 4679 RVA: 0x00058E48 File Offset: 0x00057048
		public void Restore()
		{
			int mouseX = this._mouseX;
			if (!true)
			{
			}
			Main.mouseX = mouseX;
			Main.mouseY = this._mouseY;
			Main.lastMouseX = this._lastMouseX;
			Main.lastMouseY = this._lastMouseY;
			Main.mouseLeft = this._mouseLeft;
			Main.mouseLeftRelease = this._mouseLeftRelease;
			Main.mouseRight = this._mouseRight;
			Main.mouseRightRelease = this._mouseRightRelease;
			Main.worldMouseX = this._worldMouseX;
			Main.worldMouseY = this._worldMouseY;
			if (true)
			{
				return;
			}
			if (!true)
			{
			}
			Main.mouseLeft = false;
			Main.mouseLeftRelease = true;
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x00058EDC File Offset: 0x000570DC
		public void UpdateState()
		{
			if (!true)
			{
			}
			MouseState state = Mouse.GetState();
			int mouseX = this._mouseX;
			bool mouseLeft = this._mouseLeft;
			this._mouseX = 1;
			this._lastMouseX = mouseX;
			bool mouseRight = this._mouseRight;
			this._mouseLeftRelease = true;
			this._mouseLeft = true;
			this._mouseRightRelease = mouseRight;
			this._mouseRight = true;
			if (!true)
			{
			}
			if (!true)
			{
				this._mouseLeftRelease = true;
			}
		}

		// Token: 0x06001249 RID: 4681 RVA: 0x00058F44 File Offset: 0x00057144
		public MouseStateBackup()
		{
		}

		// Token: 0x040021D2 RID: 8658
		private int _mouseX;

		// Token: 0x040021D3 RID: 8659
		private int _mouseY;

		// Token: 0x040021D4 RID: 8660
		private int _lastMouseX;

		// Token: 0x040021D5 RID: 8661
		private int _lastMouseY;

		// Token: 0x040021D6 RID: 8662
		private int _worldMouseX;

		// Token: 0x040021D7 RID: 8663
		private int _worldMouseY;

		// Token: 0x040021D8 RID: 8664
		private bool _mouseLeft;

		// Token: 0x040021D9 RID: 8665
		private bool _mouseRight;

		// Token: 0x040021DA RID: 8666
		private bool _mouseLeftRelease;

		// Token: 0x040021DB RID: 8667
		private bool _mouseRightRelease;
	}
}
