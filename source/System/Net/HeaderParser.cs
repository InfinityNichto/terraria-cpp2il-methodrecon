﻿using System;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x020001EA RID: 490
	internal sealed class HeaderParser : MulticastDelegate
	{
		// Token: 0x06000C08 RID: 3080 RVA: 0x00027084 File Offset: 0x00025284
		public HeaderParser(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x000270D8 File Offset: 0x000252D8
		public string[] Invoke(string value)
		{
			/*
An exception occurred when decompiling this method (06000C09)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String[] System.Net.HeaderParser::Invoke(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:native int(var_0_06, ldfld:native int(Delegate::method_code, ldloc:HeaderParser[exp:Delegate](this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:HeaderParser[exp:Delegate](this)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method, ldloc:HeaderParser[exp:Delegate](this)))
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

		// Token: 0x06000C0A RID: 3082 RVA: 0x00002050 File Offset: 0x00000250
		public IAsyncResult BeginInvoke(string value, AsyncCallback callback, object @object)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x00002050 File Offset: 0x00000250
		public string[] EndInvoke(IAsyncResult result)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
