using System;
using System.ComponentModel;

namespace System.Net
{
	// Token: 0x0200017C RID: 380
	public class DownloadStringCompletedEventArgs : global::System.ComponentModel.AsyncCompletedEventArgs
	{
		// Token: 0x060009EF RID: 2543 RVA: 0x00021F84 File Offset: 0x00020184
		internal DownloadStringCompletedEventArgs(string result, Exception exception, bool cancelled, object userToken)
		{
			this._result = result;
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x060009F0 RID: 2544 RVA: 0x00021F98 File Offset: 0x00020198
		public string Result
		{
			get
			{
				/*
An exception occurred when decompiling this method (060009F0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Net.DownloadStringCompletedEventArgs::get_Result()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(AsyncCompletedEventArgs::RaiseExceptionIfNecessary, ldloc:DownloadStringCompletedEventArgs[exp:AsyncCompletedEventArgs](this))
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

		// Token: 0x060009F1 RID: 2545 RVA: 0x00021FAC File Offset: 0x000201AC
		internal DownloadStringCompletedEventArgs()
		{
			throw new NotSupportedException();
		}

		// Token: 0x0400079C RID: 1948
		private readonly string _result;
	}
}
