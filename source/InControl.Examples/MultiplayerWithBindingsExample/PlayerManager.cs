using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using InControl;
using UnityEngine;

namespace MultiplayerWithBindingsExample
{
	// Token: 0x02000007 RID: 7
	public class PlayerManager : MonoBehaviour
	{
		// Token: 0x0600001C RID: 28 RVA: 0x00002788 File Offset: 0x00000988
		private void OnEnable()
		{
			if (!true)
			{
			}
			PlayerActions playerActions = PlayerActions.CreateWithKeyboardBindings();
			this.keyboardListener = playerActions;
			PlayerActions playerActions2 = PlayerActions.CreateWithJoystickBindings();
			this.joystickListener = playerActions2;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000027B4 File Offset: 0x000009B4
		private void OnDisable()
		{
			if (!true)
			{
			}
			this.joystickListener.Destroy();
			this.keyboardListener.Destroy();
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000027DC File Offset: 0x000009DC
		private void Update()
		{
			PlayerActions playerActions = this.joystickListener;
			InputDevice activeDevice = InputManager.ActiveDevice;
			bool flag = this.ThereIsNoPlayerUsingJoystick(activeDevice);
			Player player = this.CreatePlayer(activeDevice);
			PlayerActions playerActions2 = this.keyboardListener;
			bool flag2 = this.ThereIsNoPlayerUsingKeyboard();
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000281C File Offset: 0x00000A1C
		private bool JoinButtonWasPressedOnListener(PlayerActions actions)
		{
			bool wasPressed = actions.Green.WasPressed;
			bool wasPressed2 = actions.Red.WasPressed;
			bool wasPressed3 = actions.Blue.WasPressed;
			return true;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000285C File Offset: 0x00000A5C
		private Player FindPlayerUsingJoystick(InputDevice inputDevice)
		{
			/*
An exception occurred when decompiling this method (06000020)

ICSharpCode.Decompiler.DecompilerException: Error decompiling MultiplayerWithBindingsExample.Player MultiplayerWithBindingsExample.PlayerManager::FindPlayerUsingJoystick(InControl.InputDevice)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.List`1<class MultiplayerWithBindingsExample.Player>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.List`1<class MultiplayerWithBindingsExample.Player>(PlayerManager::players, ldloc:PlayerManager(this)))
	stloc:int32(var_1_0D, ldfld:int32(List`1::_size, ldloc:class [mscorlib]System.Collections.Generic.List`1<class MultiplayerWithBindingsExample.Player>[exp:List`1](var_0_06)))
	stloc:int32(var_2_14, ldfld:int32(List`1::_size, ldloc:class [mscorlib]System.Collections.Generic.List`1<class MultiplayerWithBindingsExample.Player>[exp:List`1](var_0_06)))
	stloc:int32(var_4_22, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class MultiplayerWithBindingsExample.Player>[exp:List`1](PlayerManager::players, ldloc:PlayerManager(this))))
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

		// Token: 0x06000021 RID: 33 RVA: 0x00002890 File Offset: 0x00000A90
		private bool ThereIsNoPlayerUsingJoystick(InputDevice inputDevice)
		{
			Player player = this.FindPlayerUsingJoystick(inputDevice);
			bool flag;
			return flag;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000028A8 File Offset: 0x00000AA8
		private Player FindPlayerUsingKeyboard()
		{
			/*
An exception occurred when decompiling this method (06000022)

ICSharpCode.Decompiler.DecompilerException: Error decompiling MultiplayerWithBindingsExample.Player MultiplayerWithBindingsExample.PlayerManager::FindPlayerUsingKeyboard()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.List`1<class MultiplayerWithBindingsExample.Player>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.List`1<class MultiplayerWithBindingsExample.Player>(PlayerManager::players, ldloc:PlayerManager(this)))
	stloc:int32(var_1_0D, ldfld:int32(List`1::_size, ldloc:class [mscorlib]System.Collections.Generic.List`1<class MultiplayerWithBindingsExample.Player>[exp:List`1](var_0_06)))
	stloc:int32(var_2_14, ldfld:int32(List`1::_size, ldloc:class [mscorlib]System.Collections.Generic.List`1<class MultiplayerWithBindingsExample.Player>[exp:List`1](var_0_06)))
	stloc:PlayerActions(var_3_1B, ldfld:PlayerActions(PlayerManager::keyboardListener, ldloc:PlayerManager(this)))
	stloc:int32(var_5_2A, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class MultiplayerWithBindingsExample.Player>[exp:List`1](PlayerManager::players, ldloc:PlayerManager(this))))
	stloc:PlayerActions(var_6_32, ldfld:PlayerActions(PlayerManager::keyboardListener, ldloc:PlayerManager(this)))
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

		// Token: 0x06000023 RID: 35 RVA: 0x000028EC File Offset: 0x00000AEC
		private bool ThereIsNoPlayerUsingKeyboard()
		{
			Player player = this.FindPlayerUsingKeyboard();
			bool flag;
			return flag;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002904 File Offset: 0x00000B04
		private void OnDeviceDetached(InputDevice inputDevice)
		{
			Player player = this.FindPlayerUsingJoystick(inputDevice);
			this.RemovePlayer(player);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002295 File Offset: 0x00000495
		private Player CreatePlayer(InputDevice inputDevice)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002924 File Offset: 0x00000B24
		private void RemovePlayer(Player player)
		{
			List<Vector3> list = this.playerPositions;
			Vector3 position = player.transform.position;
			List<Player> list2 = this.players;
			global::UnityEngine.Object.Destroy(player.gameObject);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002958 File Offset: 0x00000B58
		private void OnGUI()
		{
			int size = this.players._size;
			string text2;
			string text3;
			string text = "Active players: " + text2 + "/" + text3;
			if (16896 == 0)
			{
			}
			int size2 = this.players._size;
			if (16896 == 0)
			{
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000029A0 File Offset: 0x00000BA0
		public PlayerManager()
		{
		}

		// Token: 0x04000016 RID: 22
		public GameObject playerPrefab;

		// Token: 0x04000017 RID: 23
		private const int maxPlayers = 4;

		// Token: 0x04000018 RID: 24
		private List<Vector3> playerPositions;

		// Token: 0x04000019 RID: 25
		private List<Player> players;

		// Token: 0x0400001A RID: 26
		private PlayerActions keyboardListener;

		// Token: 0x0400001B RID: 27
		private PlayerActions joystickListener;
	}
}
