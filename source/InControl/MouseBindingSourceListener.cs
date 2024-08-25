using System;

namespace InControl
{
	// Token: 0x02000010 RID: 16
	public class MouseBindingSourceListener : BindingSourceListener
	{
		// Token: 0x0600007C RID: 124 RVA: 0x00002D94 File Offset: 0x00000F94
		public void Reset()
		{
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002DA4 File Offset: 0x00000FA4
		public BindingSource Listen(BindingListenOptions listenOptions, InputDevice device)
		{
			/*
An exception occurred when decompiling this method (0600007D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling InControl.BindingSource InControl.MouseBindingSourceListener::Listen(InControl.BindingListenOptions,InControl.InputDevice)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_002B:
	stfld:int32(MouseBindingSourceListener::detectPhase, ldloc:MouseBindingSourceListener(this), ldc.i4:int32(1))
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

		// Token: 0x0600007E RID: 126 RVA: 0x00002DE8 File Offset: 0x00000FE8
		private bool IsPressed(Mouse control)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002E08 File Offset: 0x00001008
		private Mouse ListenForControl(BindingListenOptions listenOptions)
		{
			bool includeMouseButtons = listenOptions.IncludeMouseButtons;
			if (!includeMouseButtons || !includeMouseButtons)
			{
			}
			if (!listenOptions.IncludeMouseScrollWheel)
			{
				return;
			}
			if ("JSON integer {0} is too large or small for an Int64." == null)
			{
			}
			if ("JSON integer {0} is too large or small for an Int64." == null)
			{
				return;
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002E3C File Offset: 0x0000103C
		public MouseBindingSourceListener()
		{
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002E50 File Offset: 0x00001050
		// Note: this type is marked as 'beforefieldinit'.
		static MouseBindingSourceListener()
		{
		}

		// Token: 0x040000C9 RID: 201
		public static float ScrollWheelThreshold;

		// Token: 0x040000CA RID: 202
		private Mouse detectFound;

		// Token: 0x040000CB RID: 203
		private int detectPhase;
	}
}
