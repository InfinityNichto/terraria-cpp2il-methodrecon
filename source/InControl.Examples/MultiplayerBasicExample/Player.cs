using System;
using System.Runtime.CompilerServices;
using InControl;
using UnityEngine;

namespace MultiplayerBasicExample
{
	// Token: 0x02000008 RID: 8
	public class Player : MonoBehaviour
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000029 RID: 41 RVA: 0x000029E0 File Offset: 0x00000BE0
		// (set) Token: 0x0600002A RID: 42 RVA: 0x000029F4 File Offset: 0x00000BF4
		public InputDevice Device
		{
			[CompilerGenerated]
			get
			{
				return this.<Device>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Device>k__BackingField = value;
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002A08 File Offset: 0x00000C08
		private void Start()
		{
			Renderer component = base.GetComponent<Renderer>();
			this.cachedRenderer = component;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002A24 File Offset: 0x00000C24
		private void Update()
		{
			InputDevice inputDevice = this.<Device>k__BackingField;
			Material material = this.cachedRenderer.material;
			if (inputDevice != null)
			{
				Color colorFromInput = this.GetColorFromInput();
				Transform transform = base.transform;
				float deltaTime = Time.deltaTime;
				float <X>k__BackingField = this.<Device>k__BackingField.Direction.<X>k__BackingField;
				Transform transform2 = base.transform;
				float deltaTime2 = Time.deltaTime;
				float <Y>k__BackingField = this.<Device>k__BackingField.Direction.<Y>k__BackingField;
				return;
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002A98 File Offset: 0x00000C98
		private Color GetColorFromInput()
		{
			/*
An exception occurred when decompiling this method (0600002D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Color MultiplayerBasicExample.Player::GetColorFromInput()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_10, call:bool(OneAxisInputControl::op_Implicit, callgetter:InputControl[exp:OneAxisInputControl](InputDevice::get_Action1, ldfld:InputDevice(Player::<Device>k__BackingField, ldloc:Player(this)))))
	stloc:bool(var_1_21, call:bool(OneAxisInputControl::op_Implicit, callgetter:InputControl[exp:OneAxisInputControl](InputDevice::get_Action2, ldfld:InputDevice(Player::<Device>k__BackingField, ldloc:Player(this)))))
	stloc:bool(var_2_32, call:bool(OneAxisInputControl::op_Implicit, callgetter:InputControl[exp:OneAxisInputControl](InputDevice::get_Action3, ldfld:InputDevice(Player::<Device>k__BackingField, ldloc:Player(this)))))
	stloc:bool(var_3_43, call:bool(OneAxisInputControl::op_Implicit, callgetter:InputControl[exp:OneAxisInputControl](InputDevice::get_Action4, ldfld:InputDevice(Player::<Device>k__BackingField, ldloc:Player(this)))))
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

		// Token: 0x0600002E RID: 46 RVA: 0x00002AE8 File Offset: 0x00000CE8
		public Player()
		{
		}

		// Token: 0x0400001C RID: 28
		[CompilerGenerated]
		private InputDevice <Device>k__BackingField;

		// Token: 0x0400001D RID: 29
		private Renderer cachedRenderer;
	}
}
