using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace MultiplayerWithBindingsExample
{
	// Token: 0x02000005 RID: 5
	public class Player : MonoBehaviour
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00002568 File Offset: 0x00000768
		// (set) Token: 0x06000013 RID: 19 RVA: 0x0000257C File Offset: 0x0000077C
		public PlayerActions Actions
		{
			[CompilerGenerated]
			get
			{
				return this.<Actions>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Actions>k__BackingField = value;
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002590 File Offset: 0x00000790
		private void OnDisable()
		{
			PlayerActions playerActions = this.<Actions>k__BackingField;
			if (playerActions != null)
			{
				playerActions.Destroy();
				return;
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000025B0 File Offset: 0x000007B0
		private void Start()
		{
			Renderer component = base.GetComponent<Renderer>();
			this.cachedRenderer = component;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000025CC File Offset: 0x000007CC
		private void Update()
		{
			PlayerActions playerActions = this.<Actions>k__BackingField;
			Material material = this.cachedRenderer.material;
			if (playerActions != null)
			{
				Color colorFromInput = this.GetColorFromInput();
				Transform transform = base.transform;
				float deltaTime = Time.deltaTime;
				float <X>k__BackingField = this.<Actions>k__BackingField.Rotate.<X>k__BackingField;
				Transform transform2 = base.transform;
				float deltaTime2 = Time.deltaTime;
				float <Y>k__BackingField = this.<Actions>k__BackingField.Rotate.<Y>k__BackingField;
				return;
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002640 File Offset: 0x00000840
		private Color GetColorFromInput()
		{
			/*
An exception occurred when decompiling this method (06000017)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Color MultiplayerWithBindingsExample.Player::GetColorFromInput()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_10, call:bool(OneAxisInputControl::op_Implicit, ldfld:PlayerAction[exp:OneAxisInputControl](PlayerActions::Green, ldfld:PlayerActions(Player::<Actions>k__BackingField, ldloc:Player(this)))))
	stloc:bool(var_1_21, call:bool(OneAxisInputControl::op_Implicit, ldfld:PlayerAction[exp:OneAxisInputControl](PlayerActions::Red, ldfld:PlayerActions(Player::<Actions>k__BackingField, ldloc:Player(this)))))
	stloc:bool(var_2_32, call:bool(OneAxisInputControl::op_Implicit, ldfld:PlayerAction[exp:OneAxisInputControl](PlayerActions::Blue, ldfld:PlayerActions(Player::<Actions>k__BackingField, ldloc:Player(this)))))
	stloc:bool(var_3_43, call:bool(OneAxisInputControl::op_Implicit, ldfld:PlayerAction[exp:OneAxisInputControl](PlayerActions::Yellow, ldfld:PlayerActions(Player::<Actions>k__BackingField, ldloc:Player(this)))))
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

		// Token: 0x06000018 RID: 24 RVA: 0x00002690 File Offset: 0x00000890
		public Player()
		{
		}

		// Token: 0x0400000B RID: 11
		[CompilerGenerated]
		private PlayerActions <Actions>k__BackingField;

		// Token: 0x0400000C RID: 12
		private Renderer cachedRenderer;
	}
}
