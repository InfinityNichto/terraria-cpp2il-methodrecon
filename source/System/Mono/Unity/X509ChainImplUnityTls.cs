using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Mono.Unity
{
	// Token: 0x02000048 RID: 72
	internal class X509ChainImplUnityTls : global::System.Security.Cryptography.X509Certificates.X509ChainImpl
	{
		// Token: 0x060000B2 RID: 178 RVA: 0x000039D8 File Offset: 0x00001BD8
		internal X509ChainImplUnityTls(UnityTls.unitytls_x509list_ref nativeCertificateChain, bool reverseOrder = false)
		{
			this.nativeCertificateChain = nativeCertificateChain;
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x000039F4 File Offset: 0x00001BF4
		public override bool IsValid
		{
			get
			{
				/*
An exception occurred when decompiling this method (060000B3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Mono.Unity.X509ChainImplUnityTls::get_IsValid()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:unitytls_x509list_ref(var_0_06, ldfld:unitytls_x509list_ref(X509ChainImplUnityTls::nativeCertificateChain, ldloc:X509ChainImplUnityTls(this)))
	stloc:uint64(var_1_11, ldfld:uint64(unitytls_interface_struct::UNITYTLS_INVALID_HANDLE, callgetter:unitytls_interface_struct(UnityTls::get_NativeInterface)))
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

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00003A14 File Offset: 0x00001C14
		internal UnityTls.unitytls_x509list_ref NativeCertificateChain
		{
			get
			{
				return this.nativeCertificateChain;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00003A28 File Offset: 0x00001C28
		public override global::System.Security.Cryptography.X509Certificates.X509ChainElementCollection ChainElements
		{
			get
			{
				do
				{
					base.ThrowIfContextInvalid();
				}
				while (this.elements != null);
				UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t unitytls_errorstate_create = UnityTls.NativeInterface.unitytls_errorstate_create;
				IntPtr invoke_impl = unitytls_errorstate_create.invoke_impl;
				IntPtr method_code = unitytls_errorstate_create.method_code;
				IntPtr method = unitytls_errorstate_create.method;
				UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t unitytls_x509list_get_x = UnityTls.NativeInterface.unitytls_x509list_get_x509;
				UnityTls.unitytls_x509list_ref unitytls_x509list_ref = this.nativeCertificateChain;
				IntPtr intPtr = (IntPtr)0;
				IntPtr method_code2 = unitytls_x509list_get_x.method_code;
				IntPtr invoke_impl2 = unitytls_x509list_get_x.invoke_impl;
				IntPtr method2 = unitytls_x509list_get_x.method;
				UnityTls.unitytls_interface_struct nativeInterface = UnityTls.NativeInterface;
				int num = 1;
				UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t unitytls_x509_export_der = UnityTls.NativeInterface.unitytls_x509_export_der;
				IntPtr intPtr2 = (IntPtr)0;
				IntPtr method_code3 = unitytls_x509_export_der.method_code;
				IntPtr invoke_impl3 = unitytls_x509_export_der.invoke_impl;
				IntPtr method3 = unitytls_x509_export_der.method;
				int num2 = (int)method_code3;
				UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t unitytls_x509_export_der2 = UnityTls.NativeInterface.unitytls_x509_export_der;
				IntPtr invoke_impl4 = unitytls_x509_export_der2.invoke_impl;
				IntPtr method_code4 = unitytls_x509_export_der2.method_code;
				IntPtr method4 = unitytls_x509_export_der2.method;
				global::System.Security.Cryptography.X509Certificates.X509ChainElementCollection x509ChainElementCollection = this.elements;
				UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t unitytls_x509list_get_x2 = UnityTls.NativeInterface.unitytls_x509list_get_x509;
				UnityTls.unitytls_x509list_ref unitytls_x509list_ref2 = this.nativeCertificateChain;
				IntPtr intPtr3 = (IntPtr)num;
				IntPtr method_code5 = unitytls_x509list_get_x2.method_code;
				IntPtr invoke_impl5 = unitytls_x509list_get_x2.invoke_impl;
				IntPtr method5 = unitytls_x509list_get_x2.method;
				ulong unitytls_INVALID_HANDLE = UnityTls.NativeInterface.UNITYTLS_INVALID_HANDLE;
				if (this.reverseOrder)
				{
					int count = this.elements.Count;
					global::System.Security.Cryptography.X509Certificates.X509Certificate2 certificate = this.elements[count].certificate;
				}
				return this.elements;
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00003B80 File Offset: 0x00001D80
		public override void AddStatus(global::System.Security.Cryptography.X509Certificates.X509ChainStatusFlags error)
		{
			if (this.chainStatusList == null)
			{
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x00003B98 File Offset: 0x00001D98
		public override global::System.Security.Cryptography.X509Certificates.X509ChainPolicy ChainPolicy
		{
			get
			{
				return this.policy;
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00003BAC File Offset: 0x00001DAC
		public override bool Build(global::System.Security.Cryptography.X509Certificates.X509Certificate2 certificate)
		{
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00003BBC File Offset: 0x00001DBC
		public override void Reset()
		{
			if (this.elements != null)
			{
				ulong unitytls_INVALID_HANDLE = UnityTls.NativeInterface.UNITYTLS_INVALID_HANDLE;
				global::System.Security.Cryptography.X509Certificates.X509ChainElementCollection x509ChainElementCollection = this.elements;
				this.nativeCertificateChain = unitytls_INVALID_HANDLE;
				x509ChainElementCollection.Clear();
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00003BF0 File Offset: 0x00001DF0
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x04000096 RID: 150
		private global::System.Security.Cryptography.X509Certificates.X509ChainElementCollection elements;

		// Token: 0x04000097 RID: 151
		private UnityTls.unitytls_x509list_ref nativeCertificateChain;

		// Token: 0x04000098 RID: 152
		private global::System.Security.Cryptography.X509Certificates.X509ChainPolicy policy;

		// Token: 0x04000099 RID: 153
		private List<global::System.Security.Cryptography.X509Certificates.X509ChainStatus> chainStatusList;

		// Token: 0x0400009A RID: 154
		private bool reverseOrder;
	}
}
