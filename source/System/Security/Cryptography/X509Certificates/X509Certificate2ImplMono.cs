using System;
using System.Collections;
using Cpp2IlInjected;
using Microsoft.Win32.SafeHandles;
using Mono.Security.X509;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x02000109 RID: 265
	internal class X509Certificate2ImplMono : X509Certificate2ImplUnix
	{
		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060005EE RID: 1518 RVA: 0x00016B9C File Offset: 0x00014D9C
		public override bool IsValid
		{
			get
			{
				/*
An exception occurred when decompiling this method (060005EE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono::get_IsValid()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:X509Certificate(var_0_06, ldfld:X509Certificate(X509Certificate2ImplMono::_cert, ldloc:X509Certificate2ImplMono(this)))
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

		// Token: 0x060005EF RID: 1519 RVA: 0x00016BB0 File Offset: 0x00014DB0
		public X509Certificate2ImplMono(X509Certificate cert)
		{
			this._cert = cert;
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x00016BCC File Offset: 0x00014DCC
		private X509Certificate2ImplMono(X509Certificate2ImplMono other)
		{
			X509Certificate cert = other._cert;
			this._cert = cert;
			X509CertificateImplCollection x509CertificateImplCollection = other.intermediateCerts;
			if (x509CertificateImplCollection != null)
			{
				X509CertificateImplCollection x509CertificateImplCollection2 = x509CertificateImplCollection.Clone();
				this.intermediateCerts = x509CertificateImplCollection2;
			}
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x00016C08 File Offset: 0x00014E08
		public X509Certificate2ImplMono(byte[] rawData, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags)
		{
			X509ContentType certContentType = X509Certificate2.GetCertContentType(rawData);
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x00016C3C File Offset: 0x00014E3C
		public override X509CertificateImpl Clone()
		{
			/*
An exception occurred when decompiling this method (060005F2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Security.Cryptography.X509Certificates.X509CertificateImpl System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono::Clone()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(X509CertificateImpl::ThrowIfContextInvalid, ldloc:X509Certificate2ImplMono[exp:X509CertificateImpl](this))
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

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060005F3 RID: 1523 RVA: 0x00016C50 File Offset: 0x00014E50
		private X509Certificate Cert
		{
			get
			{
				base.ThrowIfContextInvalid();
				return this._cert;
			}
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00016C6C File Offset: 0x00014E6C
		protected override byte[] GetRawCertData()
		{
			/*
An exception occurred when decompiling this method (060005F4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono::GetRawCertData()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(X509CertificateImpl::ThrowIfContextInvalid, ldloc:X509Certificate2ImplMono[exp:X509CertificateImpl](this))
	call:void(X509CertificateImpl::ThrowIfContextInvalid, ldloc:X509Certificate2ImplMono[exp:X509CertificateImpl](this))
	stloc:X509Certificate(var_0_12, ldfld:X509Certificate(X509Certificate2ImplMono::_cert, ldloc:X509Certificate2ImplMono(this)))
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

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060005F5 RID: 1525 RVA: 0x00002050 File Offset: 0x00000250
		public override bool HasPrivateKey
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060005F6 RID: 1526 RVA: 0x00016C8C File Offset: 0x00014E8C
		// (set) Token: 0x060005F7 RID: 1527 RVA: 0x00016CDC File Offset: 0x00014EDC
		public override AsymmetricAlgorithm PrivateKey
		{
			get
			{
				X509Certificate cert = this._cert;
				if (cert != null)
				{
					if (cert != null)
					{
					}
					if (this._cert != null)
					{
					}
					if (this._cert.DSA != null)
					{
						DSA dsa = this._cert.DSA;
						X509Certificate cert2 = this._cert;
					}
					X509Certificate cert3 = this._cert;
					return;
				}
			}
			set
			{
				while (this._cert == null)
				{
				}
				if (value != null)
				{
					return;
				}
				X509Certificate cert = this._cert;
			}
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x00016D00 File Offset: 0x00014F00
		public override RSA GetRSAPrivateKey()
		{
			while (this == null)
			{
			}
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x00016D14 File Offset: 0x00014F14
		public override DSA GetDSAPrivateKey()
		{
			while (this == null)
			{
			}
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00016D28 File Offset: 0x00014F28
		private X509Certificate ImportPkcs12(byte[] rawData, SafePasswordHandle password)
		{
			string text;
			if (password != null)
			{
				text = password.Mono_DangerousGetString();
			}
			return this.ImportPkcs12(rawData, text);
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00016D48 File Offset: 0x00014F48
		private X509Certificate ImportPkcs12(byte[] rawData, string password)
		{
			bool flag = string.IsNullOrEmpty(password);
			X509CertificateCollection x509CertificateCollection;
			ArrayList arrayList;
			if (x509CertificateCollection.Count != 0 && arrayList != null)
			{
				ArrayList arrayList2;
				if (arrayList2 != null)
				{
				}
			}
			long num = 0L;
			X509CertificateCollection x509CertificateCollection2;
			return x509CertificateCollection2[(int)num];
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x00016E4C File Offset: 0x0001504C
		[MonoTODO("by default this depends on the incomplete X509Chain")]
		public override bool Verify(X509Certificate2 thisCertificate)
		{
			/*
An exception occurred when decompiling this method (060005FC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono::Verify(System.Security.Cryptography.X509Certificates.X509Certificate2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:X509Chain(var_0_0D, call:X509Chain(X509Chain::Create))
	call:void(X509Helper2::ThrowIfContextInvalid, ldfld:X509ChainImpl(X509Chain::impl, ldloc:X509Chain(var_0_0D)))
	stloc:X509ChainImpl(var_1_1F, ldfld:X509ChainImpl(X509Chain::impl, ldloc:X509Chain(var_0_0D)))
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

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060005FD RID: 1533 RVA: 0x00016E78 File Offset: 0x00015078
		internal override X509CertificateImplCollection IntermediateCertificates
		{
			get
			{
				return this.intermediateCerts;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060005FE RID: 1534 RVA: 0x00016E8C File Offset: 0x0001508C
		internal X509Certificate MonoCertificate
		{
			get
			{
				return this._cert;
			}
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00016EA0 File Offset: 0x000150A0
		// Note: this type is marked as 'beforefieldinit'.
		static X509Certificate2ImplMono()
		{
			string text = Locale.GetText("Certificate instance is empty.");
		}

		// Token: 0x040004FF RID: 1279
		private X509CertificateImplCollection intermediateCerts;

		// Token: 0x04000500 RID: 1280
		private X509Certificate _cert;

		// Token: 0x04000501 RID: 1281
		private static string empty_error;

		// Token: 0x04000502 RID: 1282
		private static byte[] signedData;
	}
}
