using System;

namespace System.Net
{
	// Token: 0x0200026B RID: 619
	internal class NtlmClient : IAuthenticationModule
	{
		// Token: 0x0600109B RID: 4251 RVA: 0x00034938 File Offset: 0x00032B38
		public NtlmClient()
		{
		}

		// Token: 0x0600109C RID: 4252 RVA: 0x0003494C File Offset: 0x00032B4C
		public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials)
		{
			/*
An exception occurred when decompiling this method (0600109C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Net.Authorization System.Net.NtlmClient::Authenticate(System.String,System.Net.WebRequest,System.Net.ICredentials)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0008:
	stloc:int64(var_0_0E, ldfld:int64(int64::m_value, ldc.i4:int32[exp:int64&](0)))
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

		// Token: 0x0600109D RID: 4253 RVA: 0x00034968 File Offset: 0x00032B68
		public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials)
		{
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x0600109E RID: 4254 RVA: 0x00034978 File Offset: 0x00032B78
		public string AuthenticationType
		{
			get
			{
				return "NTLM";
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x0600109F RID: 4255 RVA: 0x0003498C File Offset: 0x00032B8C
		public bool CanPreAuthenticate
		{
			get
			{
			}
		}

		// Token: 0x04000D1F RID: 3359
		private IAuthenticationModule authObject;
	}
}
