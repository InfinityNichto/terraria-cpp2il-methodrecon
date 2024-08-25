using System;
using System.Runtime.CompilerServices;
using InControl;
using UnityEngine;

namespace BindingsExample
{
	// Token: 0x0200000E RID: 14
	public class PlayerActions : PlayerActionSet
	{
		// Token: 0x0600004B RID: 75 RVA: 0x000030C4 File Offset: 0x000012C4
		public PlayerActions()
		{
			PlayerAction playerAction = base.CreatePlayerAction("Fire");
			this.Fire = playerAction;
			PlayerAction playerAction2 = base.CreatePlayerAction("Jump");
			this.Jump = playerAction2;
			PlayerAction playerAction3 = base.CreatePlayerAction("Move Left");
			this.Left = playerAction3;
			PlayerAction playerAction4 = base.CreatePlayerAction("Move Right");
			this.Right = playerAction4;
			PlayerAction playerAction5 = base.CreatePlayerAction("Move Up");
			this.Up = playerAction5;
			PlayerAction playerAction6 = base.CreatePlayerAction("Move Down");
			PlayerAction left = this.Left;
			PlayerAction right = this.Right;
			PlayerAction up = this.Up;
			this.Down = playerAction6;
			PlayerTwoAxisAction playerTwoAxisAction = base.CreateTwoAxisPlayerAction(left, right, playerAction6, up);
			this.Move = playerTwoAxisAction;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00003180 File Offset: 0x00001380
		public static PlayerActions CreateWithDefaultBindings()
		{
			Delegate delegate2;
			do
			{
				if (84 == 0)
				{
				}
				if (4 != 0 || 84 == 0)
				{
				}
				if (84 == 0)
				{
				}
				if (84 != 0 || 84 == 0)
				{
				}
				Delegate @delegate;
				if (@delegate != null)
				{
					if (@delegate == null)
					{
						break;
					}
					if (@delegate == null)
					{
					}
				}
			}
			while (delegate2 == null || (delegate2 != null && delegate2 != null));
			throw new InvalidCastException();
		}

		// Token: 0x0400002C RID: 44
		public readonly PlayerAction Fire;

		// Token: 0x0400002D RID: 45
		public readonly PlayerAction Jump;

		// Token: 0x0400002E RID: 46
		public readonly PlayerAction Left;

		// Token: 0x0400002F RID: 47
		public readonly PlayerAction Right;

		// Token: 0x04000030 RID: 48
		public readonly PlayerAction Up;

		// Token: 0x04000031 RID: 49
		public readonly PlayerAction Down;

		// Token: 0x04000032 RID: 50
		public readonly PlayerTwoAxisAction Move;

		// Token: 0x0200000F RID: 15
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600004D RID: 77 RVA: 0x000031BC File Offset: 0x000013BC
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600004E RID: 78 RVA: 0x000031CC File Offset: 0x000013CC
			public <>c()
			{
			}

			// Token: 0x0600004F RID: 79 RVA: 0x000031E0 File Offset: 0x000013E0
			internal bool <CreateWithDefaultBindings>b__8_0(PlayerAction action, BindingSource binding)
			{
				/*
An exception occurred when decompiling this method (0600004F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean BindingsExample.PlayerActions/<>c::<CreateWithDefaultBindings>b__8_0(InControl.PlayerAction,InControl.BindingSource)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(PlayerAction::StopListeningForBinding, ldloc:PlayerAction(action))
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

			// Token: 0x06000050 RID: 80 RVA: 0x000031F4 File Offset: 0x000013F4
			internal void <CreateWithDefaultBindings>b__8_1(PlayerAction action, BindingSource binding)
			{
				string text;
				Debug.Log(text);
			}

			// Token: 0x06000051 RID: 81 RVA: 0x00003208 File Offset: 0x00001408
			internal void <CreateWithDefaultBindings>b__8_2(PlayerAction action, BindingSource binding, BindingSourceRejectionType reason)
			{
				string text;
				Debug.Log("Binding rejected... " + text);
			}

			// Token: 0x04000033 RID: 51
			public static readonly PlayerActions.<>c <>9;

			// Token: 0x04000034 RID: 52
			public static Func<PlayerAction, BindingSource, bool> <>9__8_0;

			// Token: 0x04000035 RID: 53
			public static Action<PlayerAction, BindingSource> <>9__8_1;

			// Token: 0x04000036 RID: 54
			public static Action<PlayerAction, BindingSource, BindingSourceRejectionType> <>9__8_2;
		}
	}
}
