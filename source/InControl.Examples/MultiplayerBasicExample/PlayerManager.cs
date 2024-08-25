using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using InControl;
using UnityEngine;

namespace MultiplayerBasicExample
{
	// Token: 0x02000009 RID: 9
	public class PlayerManager : MonoBehaviour
	{
		// Token: 0x0600002F RID: 47 RVA: 0x00002AFC File Offset: 0x00000CFC
		private void Start()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002B0C File Offset: 0x00000D0C
		private void Update()
		{
			if (!true)
			{
			}
			InputDevice activeDevice = InputManager.ActiveDevice;
			bool flag = this.ThereIsNoPlayerUsingDevice(activeDevice);
			Player player = this.CreatePlayer(activeDevice);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002B38 File Offset: 0x00000D38
		private bool JoinButtonWasPressedOnDevice(InputDevice inputDevice)
		{
			bool wasPressed = inputDevice.Action1.WasPressed;
			bool wasPressed2 = inputDevice.Action2.WasPressed;
			bool wasPressed3 = inputDevice.Action3.WasPressed;
			return true;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002B78 File Offset: 0x00000D78
		private Player FindPlayerUsingDevice(InputDevice inputDevice)
		{
			/*
An exception occurred when decompiling this method (06000032)

ICSharpCode.Decompiler.DecompilerException: Error decompiling MultiplayerBasicExample.Player MultiplayerBasicExample.PlayerManager::FindPlayerUsingDevice(InControl.InputDevice)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.List`1<class MultiplayerBasicExample.Player>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.List`1<class MultiplayerBasicExample.Player>(PlayerManager::players, ldloc:PlayerManager(this)))
	stloc:int32(var_1_0D, ldfld:int32(List`1::_size, ldloc:class [mscorlib]System.Collections.Generic.List`1<class MultiplayerBasicExample.Player>[exp:List`1](var_0_06)))
	stloc:int32(var_2_14, ldfld:int32(List`1::_size, ldloc:class [mscorlib]System.Collections.Generic.List`1<class MultiplayerBasicExample.Player>[exp:List`1](var_0_06)))
	stloc:int32(var_4_22, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class MultiplayerBasicExample.Player>[exp:List`1](PlayerManager::players, ldloc:PlayerManager(this))))
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

		// Token: 0x06000033 RID: 51 RVA: 0x00002BAC File Offset: 0x00000DAC
		private bool ThereIsNoPlayerUsingDevice(InputDevice inputDevice)
		{
			Player player = this.FindPlayerUsingDevice(inputDevice);
			bool flag;
			return flag;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002BC4 File Offset: 0x00000DC4
		private void OnDeviceDetached(InputDevice inputDevice)
		{
			Player player = this.FindPlayerUsingDevice(inputDevice);
			this.RemovePlayer(player);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002295 File Offset: 0x00000495
		private Player CreatePlayer(InputDevice inputDevice)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002BE4 File Offset: 0x00000DE4
		private void RemovePlayer(Player player)
		{
			List<Vector3> list = this.playerPositions;
			Vector3 position = player.transform.position;
			List<Player> list2 = this.players;
			global::UnityEngine.Object.Destroy(player.gameObject);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002C18 File Offset: 0x00000E18
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

		// Token: 0x06000038 RID: 56 RVA: 0x00002C60 File Offset: 0x00000E60
		public PlayerManager()
		{
		}

		// Token: 0x0400001E RID: 30
		public GameObject playerPrefab;

		// Token: 0x0400001F RID: 31
		private const int maxPlayers = 4;

		// Token: 0x04000020 RID: 32
		private List<Vector3> playerPositions;

		// Token: 0x04000021 RID: 33
		private List<Player> players;
	}
}
