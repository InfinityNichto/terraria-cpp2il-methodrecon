﻿using System;
using System.Security.Cryptography.X509Certificates;

namespace System.Net.Security
{
	// Token: 0x02000321 RID: 801
	internal sealed class LocalCertSelectionCallback : MulticastDelegate
	{
		// Token: 0x060014B8 RID: 5304 RVA: 0x0003ED44 File Offset: 0x0003CF44
		public LocalCertSelectionCallback(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x0003ED98 File Offset: 0x0003CF98
		public X509Certificate Invoke(string targetHost, global::System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers)
		{
			/*
An exception occurred when decompiling this method (060014B9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Security.Cryptography.X509Certificates.X509Certificate System.Net.Security.LocalCertSelectionCallback::Invoke(System.String,System.Security.Cryptography.X509Certificates.X509CertificateCollection,System.Security.Cryptography.X509Certificates.X509Certificate,System.String[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:native int(var_0_06, ldfld:native int(Delegate::method_code, ldloc:LocalCertSelectionCallback[exp:Delegate](this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:LocalCertSelectionCallback[exp:Delegate](this)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method, ldloc:LocalCertSelectionCallback[exp:Delegate](this)))
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
}