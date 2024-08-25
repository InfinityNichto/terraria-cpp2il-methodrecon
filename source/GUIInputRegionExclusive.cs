using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

// Token: 0x0200017C RID: 380
public class GUIInputRegionExclusive
{
	// Token: 0x06000ACB RID: 2763 RVA: 0x00036FD0 File Offset: 0x000351D0
	public GUIInputRegionExclusive(GUIInputRegionExclusive.IsOverHandler handler)
	{
		this.isOver = handler;
	}

	// Token: 0x06000ACC RID: 2764 RVA: 0x00036FEC File Offset: 0x000351EC
	public bool Over(int x, int y)
	{
		if (this.Active)
		{
			GUIInputRegionExclusive.IsOverHandler isOverHandler = this.isOver;
			IntPtr invoke_impl = isOverHandler.invoke_impl;
			IntPtr method_code = isOverHandler.method_code;
			IntPtr method = isOverHandler.method;
			return;
		}
	}

	// Token: 0x04000B29 RID: 2857
	public readonly GUIInputRegionExclusive.IsOverHandler isOver;

	// Token: 0x04000B2A RID: 2858
	public bool Active;

	// Token: 0x0200017D RID: 381
	public sealed class IsOverHandler : MulticastDelegate
	{
		// Token: 0x06000ACD RID: 2765 RVA: 0x00037020 File Offset: 0x00035220
		public IsOverHandler(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x00037074 File Offset: 0x00035274
		public bool Invoke(Vector2 cursorPosition)
		{
			/*
An exception occurred when decompiling this method (06000ACE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIInputRegionExclusive/IsOverHandler::Invoke(Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:native int(var_0_06, ldfld:native int(Delegate::method_code, ldloc:IsOverHandler[exp:Delegate](this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:IsOverHandler[exp:Delegate](this)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method, ldloc:IsOverHandler[exp:Delegate](this)))
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

		// Token: 0x06000ACF RID: 2767 RVA: 0x000021DB File Offset: 0x000003DB
		public IAsyncResult BeginInvoke(Vector2 cursorPosition, AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x000021DB File Offset: 0x000003DB
		public bool EndInvoke(IAsyncResult result)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
