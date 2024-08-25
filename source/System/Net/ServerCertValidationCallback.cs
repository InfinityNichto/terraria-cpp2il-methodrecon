using System;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace System.Net
{
	// Token: 0x0200022B RID: 555
	internal class ServerCertValidationCallback
	{
		// Token: 0x06000DF4 RID: 3572 RVA: 0x0002C804 File Offset: 0x0002AA04
		internal ServerCertValidationCallback(global::System.Net.Security.RemoteCertificateValidationCallback validationCallback)
		{
			this.m_ValidationCallback = validationCallback;
			if (!true)
			{
			}
			ExecutionContext executionContext = ExecutionContext.Capture();
			this.m_Context = executionContext;
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000DF5 RID: 3573 RVA: 0x0002C830 File Offset: 0x0002AA30
		internal global::System.Net.Security.RemoteCertificateValidationCallback ValidationCallback
		{
			get
			{
				return this.m_ValidationCallback;
			}
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x0002C844 File Offset: 0x0002AA44
		internal void Callback(object state)
		{
			if (state != null)
			{
			}
			global::System.Net.Security.RemoteCertificateValidationCallback validationCallback = this.m_ValidationCallback;
			IntPtr invoke_impl = validationCallback.invoke_impl;
			IntPtr method_code = validationCallback.method_code;
			IntPtr method = validationCallback.method;
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x0002C878 File Offset: 0x0002AA78
		internal bool Invoke(object request, X509Certificate certificate, global::System.Security.Cryptography.X509Certificates.X509Chain chain, global::System.Net.Security.SslPolicyErrors sslPolicyErrors)
		{
			/*
An exception occurred when decompiling this method (06000DF7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.ServerCertValidationCallback::Invoke(System.Object,System.Security.Cryptography.X509Certificates.X509Certificate,System.Security.Cryptography.X509Certificates.X509Chain,System.Net.Security.SslPolicyErrors)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0011:
	stloc:RemoteCertificateValidationCallback(var_2_17, ldfld:RemoteCertificateValidationCallback(ServerCertValidationCallback::m_ValidationCallback, ldloc:ServerCertValidationCallback(this)))
	stloc:native int(var_3_1E, ldfld:native int(Delegate::invoke_impl, ldloc:RemoteCertificateValidationCallback[exp:Delegate](var_2_17)))
	stloc:native int(var_4_25, ldfld:native int(Delegate::method_code, ldloc:RemoteCertificateValidationCallback[exp:Delegate](var_2_17)))
	stloc:native int(var_5_2D, ldfld:native int(Delegate::method, ldloc:RemoteCertificateValidationCallback[exp:Delegate](var_2_17)))
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

		// Token: 0x04000BA8 RID: 2984
		private readonly global::System.Net.Security.RemoteCertificateValidationCallback m_ValidationCallback;

		// Token: 0x04000BA9 RID: 2985
		private readonly ExecutionContext m_Context;

		// Token: 0x0200022C RID: 556
		private class CallbackContext
		{
			// Token: 0x06000DF8 RID: 3576 RVA: 0x0002C8B4 File Offset: 0x0002AAB4
			internal CallbackContext(object request, X509Certificate certificate, global::System.Security.Cryptography.X509Certificates.X509Chain chain, global::System.Net.Security.SslPolicyErrors sslPolicyErrors)
			{
				this.request = request;
				this.certificate = certificate;
				this.chain = chain;
				this.sslPolicyErrors = sslPolicyErrors;
			}

			// Token: 0x04000BAA RID: 2986
			internal readonly object request;

			// Token: 0x04000BAB RID: 2987
			internal readonly X509Certificate certificate;

			// Token: 0x04000BAC RID: 2988
			internal readonly global::System.Security.Cryptography.X509Certificates.X509Chain chain;

			// Token: 0x04000BAD RID: 2989
			internal readonly global::System.Net.Security.SslPolicyErrors sslPolicyErrors;

			// Token: 0x04000BAE RID: 2990
			internal bool result;
		}
	}
}
