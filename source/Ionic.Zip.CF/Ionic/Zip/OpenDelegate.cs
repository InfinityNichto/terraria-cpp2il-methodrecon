using System;
using System.IO;
using Cpp2IlInjected;

namespace Ionic.Zip
{
	// Token: 0x02000005 RID: 5
	public sealed class OpenDelegate : MulticastDelegate
	{
		// Token: 0x06000009 RID: 9 RVA: 0x00002140 File Offset: 0x00000340
		public OpenDelegate(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002194 File Offset: 0x00000394
		public Stream Invoke(string entryName)
		{
			/*
An exception occurred when decompiling this method (0600000A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IO.Stream Ionic.Zip.OpenDelegate::Invoke(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:native int(var_0_06, ldfld:native int(Delegate::method_code, ldloc:OpenDelegate[exp:Delegate](this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:OpenDelegate[exp:Delegate](this)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method, ldloc:OpenDelegate[exp:Delegate](this)))
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

		// Token: 0x0600000B RID: 11 RVA: 0x00002122 File Offset: 0x00000322
		public IAsyncResult BeginInvoke(string entryName, AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002122 File Offset: 0x00000322
		public Stream EndInvoke(IAsyncResult result)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
