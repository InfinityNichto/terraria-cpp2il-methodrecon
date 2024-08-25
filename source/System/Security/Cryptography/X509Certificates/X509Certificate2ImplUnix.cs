using System;
using System.Collections.Generic;
using System.Text;
using Internal.Cryptography.Pal;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x0200010A RID: 266
	internal abstract class X509Certificate2ImplUnix : X509Certificate2Impl
	{
		// Token: 0x06000600 RID: 1536 RVA: 0x00016EB8 File Offset: 0x000150B8
		private void EnsureCertData()
		{
			if (!this.readCertData)
			{
				base.ThrowIfContextInvalid();
				int num = 1;
				this.readCertData = num != 0;
			}
		}

		// Token: 0x06000601 RID: 1537
		protected abstract byte[] GetRawCertData();

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000602 RID: 1538 RVA: 0x00016EDC File Offset: 0x000150DC
		public sealed override string KeyAlgorithm
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000602)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Security.Cryptography.X509Certificates.X509Certificate2ImplUnix::get_KeyAlgorithm()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(X509Certificate2ImplUnix::EnsureCertData, ldloc:X509Certificate2ImplUnix(this))
	stloc:AlgorithmIdentifier(var_0_11, ldfld:AlgorithmIdentifier(CertificateData::PublicKeyAlgorithm, ldfld:CertificateData[exp:valuetype Internal.Cryptography.Pal.CertificateData&](X509Certificate2ImplUnix::certData, ldloc:X509Certificate2ImplUnix(this))))
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

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000603 RID: 1539 RVA: 0x00016EFC File Offset: 0x000150FC
		public sealed override byte[] KeyAlgorithmParameters
		{
			get
			{
				this.EnsureCertData();
				return this.certData.PublicKeyAlgorithm.Parameters;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000604 RID: 1540 RVA: 0x00016F20 File Offset: 0x00015120
		public sealed override byte[] PublicKeyValue
		{
			get
			{
				this.EnsureCertData();
				return this.certData.PublicKey;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000605 RID: 1541 RVA: 0x00016F40 File Offset: 0x00015140
		public sealed override byte[] SerialNumber
		{
			get
			{
				this.EnsureCertData();
				return this.certData.SerialNumber;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000606 RID: 1542 RVA: 0x00016F60 File Offset: 0x00015160
		public sealed override string SignatureAlgorithm
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000606)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Security.Cryptography.X509Certificates.X509Certificate2ImplUnix::get_SignatureAlgorithm()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(X509Certificate2ImplUnix::EnsureCertData, ldloc:X509Certificate2ImplUnix(this))
	stloc:AlgorithmIdentifier(var_0_11, ldfld:AlgorithmIdentifier(CertificateData::SignatureAlgorithm, ldfld:CertificateData[exp:valuetype Internal.Cryptography.Pal.CertificateData&](X509Certificate2ImplUnix::certData, ldloc:X509Certificate2ImplUnix(this))))
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

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000607 RID: 1543 RVA: 0x00016F80 File Offset: 0x00015180
		public sealed override int Version
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000607)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Security.Cryptography.X509Certificates.X509Certificate2ImplUnix::get_Version()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(X509Certificate2ImplUnix::EnsureCertData, ldloc:X509Certificate2ImplUnix(this))
	stloc:int32(var_0_11, ldfld:int32(CertificateData::Version, ldfld:CertificateData[exp:valuetype Internal.Cryptography.Pal.CertificateData&](X509Certificate2ImplUnix::certData, ldloc:X509Certificate2ImplUnix(this))))
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

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000608 RID: 1544 RVA: 0x00016FA0 File Offset: 0x000151A0
		public sealed override X500DistinguishedName SubjectName
		{
			get
			{
				this.EnsureCertData();
				return this.certData.Subject;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000609 RID: 1545 RVA: 0x00016FC0 File Offset: 0x000151C0
		public sealed override X500DistinguishedName IssuerName
		{
			get
			{
				this.EnsureCertData();
				return this.certData.Issuer;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600060A RID: 1546 RVA: 0x00016FE0 File Offset: 0x000151E0
		public sealed override string Subject
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600060A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Security.Cryptography.X509Certificates.X509Certificate2ImplUnix::get_Subject()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8[](var_0_0B, ldfld:uint8[](CertificateData::SubjectPublicKeyInfo, ldfld:CertificateData[exp:valuetype Internal.Cryptography.Pal.CertificateData&](X509Certificate2ImplUnix::certData, ldloc:X509Certificate2ImplUnix(this))))
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

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600060B RID: 1547 RVA: 0x00016FF8 File Offset: 0x000151F8
		public sealed override string Issuer
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600060B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Security.Cryptography.X509Certificates.X509Certificate2ImplUnix::get_Issuer()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8[](var_0_0B, ldfld:uint8[](CertificateData::SubjectPublicKeyInfo, ldfld:CertificateData[exp:valuetype Internal.Cryptography.Pal.CertificateData&](X509Certificate2ImplUnix::certData, ldloc:X509Certificate2ImplUnix(this))))
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

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x0600060C RID: 1548 RVA: 0x00017010 File Offset: 0x00015210
		public sealed override byte[] RawData
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600060C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] System.Security.Cryptography.X509Certificates.X509Certificate2ImplUnix::get_RawData()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(X509Certificate2ImplUnix::EnsureCertData, ldloc:X509Certificate2ImplUnix(this))
	stloc:CertificateData(var_0_0C, ldfld:CertificateData(X509Certificate2ImplUnix::certData, ldloc:X509Certificate2ImplUnix(this)))
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

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x0600060D RID: 1549 RVA: 0x0001702C File Offset: 0x0001522C
		public sealed override byte[] Thumbprint
		{
			get
			{
				this.EnsureCertData();
				SHA1 sha = SHA1.Create();
				Internal.Cryptography.Pal.CertificateData certificateData = this.certData;
				long num = 0L;
				if (sha != null)
				{
				}
				if (num == 0L)
				{
					byte[] array;
					return array;
				}
				throw new OutOfMemoryException();
			}
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00017084 File Offset: 0x00015284
		public sealed override string GetNameInfo(X509NameType nameType, bool forIssuer)
		{
			this.EnsureCertData();
			string text;
			return text;
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x0600060F RID: 1551 RVA: 0x00017098 File Offset: 0x00015298
		public sealed override IEnumerable<X509Extension> Extensions
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600060F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IEnumerable`1<System.Security.Cryptography.X509Certificates.X509Extension> System.Security.Cryptography.X509Certificates.X509Certificate2ImplUnix::get_Extensions()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(X509Certificate2ImplUnix::EnsureCertData, ldloc:X509Certificate2ImplUnix(this))
	stloc:class [mscorlib]System.Collections.Generic.List`1<class System.Security.Cryptography.X509Certificates.X509Extension>(var_0_11, ldfld:class [mscorlib]System.Collections.Generic.List`1<class System.Security.Cryptography.X509Certificates.X509Extension>(CertificateData::Extensions, ldfld:CertificateData[exp:valuetype Internal.Cryptography.Pal.CertificateData&](X509Certificate2ImplUnix::certData, ldloc:X509Certificate2ImplUnix(this))))
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

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000610 RID: 1552 RVA: 0x000170B8 File Offset: 0x000152B8
		public sealed override DateTime NotAfter
		{
			get
			{
				this.EnsureCertData();
				DateTime dateTime;
				return dateTime;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000611 RID: 1553 RVA: 0x000170CC File Offset: 0x000152CC
		public sealed override DateTime NotBefore
		{
			get
			{
				this.EnsureCertData();
				DateTime dateTime;
				return dateTime;
			}
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x000170E0 File Offset: 0x000152E0
		public sealed override void AppendPrivateKeyInfo(StringBuilder sb)
		{
			StringBuilder stringBuilder = sb.AppendLine();
			StringBuilder stringBuilder2 = sb.AppendLine();
			StringBuilder stringBuilder3 = sb.AppendLine("[Private Key]");
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00017108 File Offset: 0x00015308
		protected X509Certificate2ImplUnix()
		{
		}

		// Token: 0x04000503 RID: 1283
		private bool readCertData;

		// Token: 0x04000504 RID: 1284
		private Internal.Cryptography.Pal.CertificateData certData;
	}
}
