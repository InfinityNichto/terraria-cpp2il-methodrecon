using System;
using System.Globalization;
using System.IO;
using System.Net.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Cpp2IlInjected;
using Mono.Net.Security;
using Mono.Security.Interface;
using Mono.Util;

namespace Mono.Unity
{
	// Token: 0x02000046 RID: 70
	internal class UnityTlsProvider : Mono.Net.Security.MobileTlsProvider
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00003568 File Offset: 0x00001768
		public override string Name
		{
			get
			{
				return "unitytls";
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x0000357C File Offset: 0x0000177C
		public override Guid ID
		{
			get
			{
				/*
An exception occurred when decompiling this method (060000A6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Guid Mono.Unity.UnityTlsProvider::get_ID()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x0000358C File Offset: 0x0000178C
		public override bool SupportsSslStream
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x0000359C File Offset: 0x0000179C
		public override bool SupportsMonoExtensions
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x000035AC File Offset: 0x000017AC
		public override bool SupportsConnectionInfo
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060000AA RID: 170 RVA: 0x000035BC File Offset: 0x000017BC
		internal override bool SupportsCleanShutdown
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000AB RID: 171 RVA: 0x000035CC File Offset: 0x000017CC
		public override global::System.Security.Authentication.SslProtocols SupportedProtocols
		{
			get
			{
				return global::System.Security.Authentication.SslProtocols.Tls | global::System.Security.Authentication.SslProtocols.Tls11 | global::System.Security.Authentication.SslProtocols.Tls12;
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002050 File Offset: 0x00000250
		internal override Mono.Net.Security.MobileAuthenticatedStream CreateSslStream(global::System.Net.Security.SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000035E0 File Offset: 0x000017E0
		[Mono.Util.MonoPInvokeCallback(typeof(UnityTls.unitytls_x509verify_callback))]
		private unsafe static UnityTls.unitytls_x509verify_result x509verify_callback(void* userData, UnityTls.unitytls_x509_ref cert, UnityTls.unitytls_x509verify_result result, UnityTls.unitytls_errorstate* errorState)
		{
			/*
An exception occurred when decompiling this method (060000AD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Mono.Unity.UnityTls/unitytls_x509verify_result Mono.Unity.UnityTlsProvider::x509verify_callback(System.Void*,Mono.Unity.UnityTls/unitytls_x509_ref,Mono.Unity.UnityTls/unitytls_x509verify_result,Mono.Unity.UnityTls/unitytls_errorstate*)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:unitytls_x509list_append_t(var_0_0A, ldfld:unitytls_x509list_append_t(unitytls_interface_struct::unitytls_x509list_append, callgetter:unitytls_interface_struct(UnityTls::get_NativeInterface)))
	stloc:native int(var_1_11, ldfld:native int(Delegate::invoke_impl, ldloc:unitytls_x509list_append_t[exp:Delegate](var_0_0A)))
	stloc:native int(var_2_18, ldfld:native int(Delegate::method_code, ldloc:unitytls_x509list_append_t[exp:Delegate](var_0_0A)))
	stloc:native int(var_3_1F, ldfld:native int(Delegate::method, ldloc:unitytls_x509list_append_t[exp:Delegate](var_0_0A)))
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

		// Token: 0x060000AE RID: 174 RVA: 0x0000360C File Offset: 0x0000180C
		internal override bool ValidateCertificate(Mono.Net.Security.ChainValidationHelper validator, string targetHost, bool serverMode, global::System.Security.Cryptography.X509Certificates.X509CertificateCollection certificates, bool wantsChain, global::System.Security.Cryptography.X509Certificates.X509Chain chain, global::System.Net.Security.SslPolicyErrors errors, int status11)
		{
			UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t unitytls_errorstate_create = UnityTls.NativeInterface.unitytls_errorstate_create;
			IntPtr invoke_impl = unitytls_errorstate_create.invoke_impl;
			IntPtr method_code = unitytls_errorstate_create.method_code;
			IntPtr method = unitytls_errorstate_create.method;
			global::System.Security.Cryptography.X509Certificates.X509ChainImpl x509ChainImpl;
			if (x509ChainImpl != null)
			{
			}
			if (certificates != null && certificates.Count != 0)
			{
				return string.IsNullOrEmpty(targetHost);
			}
			UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t unitytls_x509verify_explicit_ca = UnityTls.NativeInterface.unitytls_x509verify_explicit_ca;
			Encoding encoding;
			CodePageDataItem dataItem = encoding.dataItem;
			IntPtr method_code2 = unitytls_x509verify_explicit_ca.method_code;
			IntPtr invoke_impl2 = unitytls_x509verify_explicit_ca.invoke_impl;
			IntPtr method2 = unitytls_x509verify_explicit_ca.method;
			long num = 0L;
			int num2 = 14;
			UnityTls.unitytls_interface_struct.unitytls_x509list_free_t unitytls_x509list_free = UnityTls.NativeInterface.unitytls_x509list_free;
			IntPtr method_code3 = unitytls_x509list_free.method_code;
			IntPtr invoke_impl3 = unitytls_x509list_free.invoke_impl;
			IntPtr method3 = unitytls_x509list_free.method;
			if (num == 0L)
			{
				IntPtr method_code4;
				int num3;
				if (num2 == 0)
				{
					if (encoding != null)
					{
						CodePageDataItem dataItem2 = encoding.dataItem;
					}
					UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t unitytls_x509verify_default_ca = UnityTls.NativeInterface.unitytls_x509verify_default_ca;
					CodePageDataItem dataItem3 = encoding.dataItem;
					method_code4 = unitytls_x509verify_default_ca.method_code;
					IntPtr invoke_impl4 = unitytls_x509verify_default_ca.invoke_impl;
					IntPtr method4 = unitytls_x509verify_default_ca.method;
					num3 = 18;
				}
				long num4 = 0L;
				UnityTls.unitytls_interface_struct.unitytls_x509list_free_t unitytls_x509list_free2 = UnityTls.NativeInterface.unitytls_x509list_free;
				IntPtr invoke_impl5 = unitytls_x509list_free2.invoke_impl;
				IntPtr method_code5 = unitytls_x509list_free2.method_code;
				IntPtr method5 = unitytls_x509list_free2.method;
				if (num4 == 0L)
				{
					if (num3 == 0)
					{
						UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t unitytls_x509list_get_ref = UnityTls.NativeInterface.unitytls_x509list_get_ref;
						IntPtr invoke_impl6 = unitytls_x509list_get_ref.invoke_impl;
						IntPtr method_code6 = unitytls_x509list_get_ref.method_code;
						IntPtr method6 = unitytls_x509list_get_ref.method;
						if (method_code4 == 0)
						{
							int num5 = 4;
							errors.value__ = num5;
						}
						if (method_code4 != 0)
						{
						}
					}
				}
				throw new OutOfMemoryException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000039A4 File Offset: 0x00001BA4
		public UnityTlsProvider()
		{
		}
	}
}
