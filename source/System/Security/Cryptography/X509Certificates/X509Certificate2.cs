using System;
using System.Runtime.Serialization;
using Cpp2IlInjected;
using Mono;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x02000105 RID: 261
	[Serializable]
	public class X509Certificate2 : X509Certificate
	{
		// Token: 0x060005B6 RID: 1462 RVA: 0x000163D0 File Offset: 0x000145D0
		public override void Reset()
		{
			base.Reset();
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x000163E4 File Offset: 0x000145E4
		public X509Certificate2()
		{
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x000163F8 File Offset: 0x000145F8
		public X509Certificate2(byte[] rawData)
		{
			int num = 1;
			base..ctor(rawData);
			if (rawData != null && num != 0)
			{
				X509CertificateImpl x509CertificateImpl;
				base.ImportHandle(x509CertificateImpl);
				return;
			}
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x0001643C File Offset: 0x0001463C
		internal X509Certificate2(X509Certificate2Impl impl)
			: base(impl)
		{
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00016450 File Offset: 0x00014650
		public X509Certificate2(string fileName)
			: base(fileName)
		{
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00016464 File Offset: 0x00014664
		public X509Certificate2(X509Certificate certificate)
			: base(certificate)
		{
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00016478 File Offset: 0x00014678
		protected X509Certificate2(SerializationInfo info, StreamingContext context)
		{
			/*
An exception occurred when decompiling this method (060005BC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Security.Cryptography.X509Certificates.X509Certificate2::.ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(X509Certificate::.ctor, ldloc:X509Certificate2[exp:X509Certificate](this), ldloc:SerializationInfo(info), ldloc:StreamingContext(context))
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

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060005BD RID: 1469 RVA: 0x0001648C File Offset: 0x0001468C
		public X509ExtensionCollection Extensions
		{
			get
			{
				base.ThrowIfInvalid();
				if (this.lazyExtensions == null)
				{
					X509Certificate2Impl impl = this.Impl;
					X509Extension x509Extension;
					if (x509Extension != null)
					{
					}
					long num = 0L;
					int num2 = 6;
					if (impl != null)
					{
					}
					if (num != 0L || num2 == 0)
					{
					}
				}
				throw new OutOfMemoryException();
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060005BE RID: 1470 RVA: 0x000164E4 File Offset: 0x000146E4
		public bool HasPrivateKey
		{
			get
			{
				/*
An exception occurred when decompiling this method (060005BE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Security.Cryptography.X509Certificates.X509Certificate2::get_HasPrivateKey()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(X509Certificate::ThrowIfInvalid, ldloc:X509Certificate2[exp:X509Certificate](this))
	stloc:X509Certificate2Impl(var_0_0C, callgetter:X509Certificate2Impl(X509Certificate2::get_Impl, ldloc:X509Certificate2(this)))
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

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060005BF RID: 1471 RVA: 0x00016500 File Offset: 0x00014700
		public AsymmetricAlgorithm PrivateKey
		{
			get
			{
				/*
An exception occurred when decompiling this method (060005BF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Security.Cryptography.AsymmetricAlgorithm System.Security.Cryptography.X509Certificates.X509Certificate2::get_PrivateKey()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0022:
	stloc:X509Certificate2Impl(var_3_28, callgetter:X509Certificate2Impl(X509Certificate2::get_Impl, ldloc:X509Certificate2(this)))
	stloc:X509Certificate2Impl(var_5_2F, callgetter:X509Certificate2Impl(X509Certificate2::get_Impl, ldloc:X509Certificate2(this)))
	stfld:AsymmetricAlgorithm(X509Certificate2::lazyPrivateKey, ldloc:X509Certificate2(this), ldloc:X509Certificate2Impl[exp:AsymmetricAlgorithm](var_5_2F))
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

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060005C0 RID: 1472 RVA: 0x00016548 File Offset: 0x00014748
		public X500DistinguishedName IssuerName
		{
			get
			{
				/*
An exception occurred when decompiling this method (060005C0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Security.Cryptography.X509Certificates.X500DistinguishedName System.Security.Cryptography.X509Certificates.X509Certificate2::get_IssuerName()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:X509Certificate2Impl(var_0_14, callgetter:X509Certificate2Impl(X509Certificate2::get_Impl, ldloc:X509Certificate2(this)))
	stfld:X500DistinguishedName(X509Certificate2::lazyIssuerName, ldloc:X509Certificate2(this), ldloc:X509Certificate2Impl[exp:X500DistinguishedName](var_0_14))
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

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060005C1 RID: 1473 RVA: 0x00016570 File Offset: 0x00014770
		public DateTime NotAfter
		{
			get
			{
				DateTime notAfter = base.GetNotAfter();
				DateTime dateTime;
				return dateTime;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060005C2 RID: 1474 RVA: 0x00016588 File Offset: 0x00014788
		public DateTime NotBefore
		{
			get
			{
				DateTime notBefore = base.GetNotBefore();
				DateTime dateTime;
				return dateTime;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060005C3 RID: 1475 RVA: 0x000165A0 File Offset: 0x000147A0
		public PublicKey PublicKey
		{
			get
			{
				/*
An exception occurred when decompiling this method (060005C3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Security.Cryptography.X509Certificates.PublicKey System.Security.Cryptography.X509Certificates.X509Certificate2::get_PublicKey()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	call:void(X509Certificate::ThrowIfInvalid, ldloc:X509Certificate2[exp:X509Certificate](this))
	brtrue(IL_0000, ldfld:PublicKey[exp:bool](X509Certificate2::lazyPublicKey, ldloc:X509Certificate2(this)))
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

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060005C4 RID: 1476 RVA: 0x000165BC File Offset: 0x000147BC
		public byte[] RawData
		{
			get
			{
				base.ThrowIfInvalid();
				if (this.lazyRawData == null)
				{
					X509Certificate2Impl impl = this.Impl;
					this.lazyRawData = impl;
				}
				byte[] array;
				return array;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060005C5 RID: 1477 RVA: 0x00002050 File Offset: 0x00000250
		public string SerialNumber
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060005C6 RID: 1478 RVA: 0x000165E8 File Offset: 0x000147E8
		public Oid SignatureAlgorithm
		{
			get
			{
				base.ThrowIfInvalid();
				Oid oid;
				if (this.lazySignatureAlgorithm == null)
				{
					X509Certificate2Impl impl = this.Impl;
					this.lazySignatureAlgorithm = oid;
				}
				return oid;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060005C7 RID: 1479 RVA: 0x00016614 File Offset: 0x00014814
		public X500DistinguishedName SubjectName
		{
			get
			{
				/*
An exception occurred when decompiling this method (060005C7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Security.Cryptography.X509Certificates.X500DistinguishedName System.Security.Cryptography.X509Certificates.X509Certificate2::get_SubjectName()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:X509Certificate2Impl(var_0_14, callgetter:X509Certificate2Impl(X509Certificate2::get_Impl, ldloc:X509Certificate2(this)))
	stfld:X500DistinguishedName(X509Certificate2::lazySubjectName, ldloc:X509Certificate2(this), ldloc:X509Certificate2Impl[exp:X500DistinguishedName](var_0_14))
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

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060005C8 RID: 1480 RVA: 0x0001663C File Offset: 0x0001483C
		public string Thumbprint
		{
			get
			{
				string text;
				return text;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060005C9 RID: 1481 RVA: 0x0001664C File Offset: 0x0001484C
		public int Version
		{
			get
			{
				/*
An exception occurred when decompiling this method (060005C9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Security.Cryptography.X509Certificates.X509Certificate2::get_Version()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:X509Certificate2Impl(var_0_14, callgetter:X509Certificate2Impl(X509Certificate2::get_Impl, ldloc:X509Certificate2(this)))
	stfld:int32(X509Certificate2::lazyVersion, ldloc:X509Certificate2(this), ldloc:X509Certificate2Impl[exp:int32](var_0_14))
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

		// Token: 0x060005CA RID: 1482 RVA: 0x00016674 File Offset: 0x00014874
		public static X509ContentType GetCertContentType(byte[] rawData)
		{
			return global::Mono.X509Pal.Instance.GetCertContentType(rawData);
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x00016690 File Offset: 0x00014890
		public string GetNameInfo(X509NameType nameType, bool forIssuer)
		{
			/*
An exception occurred when decompiling this method (060005CB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Security.Cryptography.X509Certificates.X509Certificate2::GetNameInfo(System.Security.Cryptography.X509Certificates.X509NameType,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:X509Certificate2Impl(var_0_06, callgetter:X509Certificate2Impl(X509Certificate2::get_Impl, ldloc:X509Certificate2(this)))
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

		// Token: 0x060005CC RID: 1484 RVA: 0x000166A4 File Offset: 0x000148A4
		public override string ToString()
		{
			return base.ToString(true);
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x000166B8 File Offset: 0x000148B8
		public override string ToString(bool verbose)
		{
			bool isValid = base.IsValid;
			int version = this.Version;
			string name = this.SubjectName.name;
			X509Certificate2Impl impl = this.Impl;
			X509Certificate2Impl impl2 = this.Impl;
			X509Certificate2Impl impl3 = this.Impl;
			X509Certificate2Impl impl4 = this.Impl;
			string name2 = this.IssuerName.name;
			X509Certificate2Impl impl5 = this.Impl;
			X509Certificate2Impl impl6 = this.Impl;
			X509Certificate2Impl impl7 = this.Impl;
			X509Certificate2Impl impl8 = this.Impl;
			string text = X509Certificate.FormatDate(base.GetNotBefore());
			string text2 = X509Certificate.FormatDate(base.GetNotAfter());
			string friendlyName = this.SignatureAlgorithm.FriendlyName;
			string value = this.SignatureAlgorithm._value;
			PublicKey publicKey = this.PublicKey;
			string friendlyName2 = publicKey._oid.FriendlyName;
			if (this.GetRSAPublicKey() != null)
			{
				long num = 0L;
				int num2 = 13;
				if (num != 0L)
				{
					goto IL_013F;
				}
				if (num2 != 0)
				{
				}
			}
			AsnEncodedData keyValue = publicKey._keyValue;
			AsnEncodedData @params = publicKey._params;
			X509Certificate2Impl impl9 = this.Impl;
			X509ExtensionCollection extensions = this.Extensions;
			int count = extensions.Count;
			X509ExtensionEnumerator enumerator = extensions.GetEnumerator();
			bool flag = enumerator.MoveNext();
			X509Extension x509Extension = enumerator.Current;
			string friendlyName3 = x509Extension._oid.FriendlyName;
			string value2 = x509Extension._oid._value;
			bool flag2 = enumerator.MoveNext();
			IL_013F:
			throw new OutOfMemoryException();
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x000168A4 File Offset: 0x00014AA4
		public bool Verify()
		{
			/*
An exception occurred when decompiling this method (060005CE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Security.Cryptography.X509Certificates.X509Certificate2::Verify()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:X509Certificate2Impl(var_0_06, callgetter:X509Certificate2Impl(X509Certificate2::get_Impl, ldloc:X509Certificate2(this)))
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

		// Token: 0x060005CF RID: 1487 RVA: 0x000168B8 File Offset: 0x00014AB8
		private static X509Extension CreateCustomExtensionIfAny(Oid oid)
		{
			/*
An exception occurred when decompiling this method (060005CF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Security.Cryptography.X509Certificates.X509Extension System.Security.Cryptography.X509Certificates.X509Certificate2::CreateCustomExtensionIfAny(System.Security.Cryptography.Oid)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_0F, call:bool(string::op_Equality, ldstr:string("2.5.29.19"), ldstr:string("2.5.29.10")))
	stloc:bool(var_2_1C, callgetter:bool(X509PalImpl::get_SupportsLegacyBasicConstraintsExtension, callgetter:X509PalImpl(X509Pal::get_Instance)))
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

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060005D0 RID: 1488 RVA: 0x000168E4 File Offset: 0x00014AE4
		internal X509Certificate2Impl Impl
		{
			get
			{
				if (this.impl != null)
				{
					return;
				}
			}
		}

		// Token: 0x040004F5 RID: 1269
		private byte[] lazyRawData;

		// Token: 0x040004F6 RID: 1270
		private Oid lazySignatureAlgorithm;

		// Token: 0x040004F7 RID: 1271
		private int lazyVersion;

		// Token: 0x040004F8 RID: 1272
		private X500DistinguishedName lazySubjectName;

		// Token: 0x040004F9 RID: 1273
		private X500DistinguishedName lazyIssuerName;

		// Token: 0x040004FA RID: 1274
		private PublicKey lazyPublicKey;

		// Token: 0x040004FB RID: 1275
		private AsymmetricAlgorithm lazyPrivateKey;

		// Token: 0x040004FC RID: 1276
		private X509ExtensionCollection lazyExtensions;
	}
}
