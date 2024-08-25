using System;
using System.Security.Cryptography;

namespace Mono.Security.X509
{
	// Token: 0x02000016 RID: 22
	public class X509CertificateBuilder : X509Builder
	{
		// Token: 0x060000EB RID: 235 RVA: 0x00005CF0 File Offset: 0x00003EF0
		public X509CertificateBuilder()
		{
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00005D00 File Offset: 0x00003F00
		public X509CertificateBuilder(byte version)
		{
			this.version = version;
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000ED RID: 237 RVA: 0x00005D1C File Offset: 0x00003F1C
		// (set) Token: 0x060000EE RID: 238 RVA: 0x00005D30 File Offset: 0x00003F30
		public byte Version
		{
			get
			{
				return this.version;
			}
			set
			{
				this.version = value;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000EF RID: 239 RVA: 0x00005D44 File Offset: 0x00003F44
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x00005D58 File Offset: 0x00003F58
		public byte[] SerialNumber
		{
			get
			{
				return this.sn;
			}
			set
			{
				this.sn = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00005D6C File Offset: 0x00003F6C
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x00005D80 File Offset: 0x00003F80
		public string IssuerName
		{
			get
			{
				return this.issuer;
			}
			set
			{
				this.issuer = value;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x00005D94 File Offset: 0x00003F94
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x00005DAC File Offset: 0x00003FAC
		public DateTime NotBefore
		{
			get
			{
				DateTime dateTime = this.notBefore;
				DateTime dateTime2;
				return dateTime2;
			}
			set
			{
				this.notBefore = value;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00005DC0 File Offset: 0x00003FC0
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x00005DD8 File Offset: 0x00003FD8
		public DateTime NotAfter
		{
			get
			{
				DateTime dateTime = this.notAfter;
				DateTime dateTime2;
				return dateTime2;
			}
			set
			{
				this.notAfter = value;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00005DEC File Offset: 0x00003FEC
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x00005E00 File Offset: 0x00004000
		public string SubjectName
		{
			get
			{
				return this.subject;
			}
			set
			{
				this.subject = value;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x00005E14 File Offset: 0x00004014
		// (set) Token: 0x060000FA RID: 250 RVA: 0x00005E28 File Offset: 0x00004028
		public AsymmetricAlgorithm SubjectPublicKey
		{
			get
			{
				return this.aa;
			}
			set
			{
				this.aa = value;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000FB RID: 251 RVA: 0x00005E3C File Offset: 0x0000403C
		// (set) Token: 0x060000FC RID: 252 RVA: 0x00005E50 File Offset: 0x00004050
		public byte[] IssuerUniqueId
		{
			get
			{
				return this.issuerUniqueID;
			}
			set
			{
				this.issuerUniqueID = value;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00005E64 File Offset: 0x00004064
		// (set) Token: 0x060000FE RID: 254 RVA: 0x00005E78 File Offset: 0x00004078
		public byte[] SubjectUniqueId
		{
			get
			{
				return this.subjectUniqueID;
			}
			set
			{
				this.subjectUniqueID = value;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00005E8C File Offset: 0x0000408C
		public X509ExtensionCollection Extensions
		{
			get
			{
				return this.extensions;
			}
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00005EA0 File Offset: 0x000040A0
		private ASN1 SubjectPublicKeyInfo()
		{
			/*
An exception occurred when decompiling this method (06000100)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Mono.Security.ASN1 Mono.Security.X509.X509CertificateBuilder::SubjectPublicKeyInfo()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ASN1(var_13_1A, call:ASN1(ASN1::Add, ldloc:ASN1(var_11), ldloc:ASN1(var_12)))
	stloc:ASN1(var_14_26, call:ASN1(PKCS7::AlgorithmIdentifier, ldstr:string("1.2.840.113549.1.1.1")))
	stloc:AsymmetricAlgorithm(var_16_2E, ldfld:AsymmetricAlgorithm(X509CertificateBuilder::aa, ldloc:X509CertificateBuilder(this)))
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

		// Token: 0x06000101 RID: 257 RVA: 0x00005EE0 File Offset: 0x000040E0
		private byte[] UniqueIdentifier(byte[] id)
		{
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00005EF0 File Offset: 0x000040F0
		protected override ASN1 ToBeSigned(string oid)
		{
			/*
An exception occurred when decompiling this method (06000102)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Mono.Security.ASN1 Mono.Security.X509.X509CertificateBuilder::ToBeSigned(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00A9:
	stloc:uint8(var_31_AF, ldfld:uint8(X509CertificateBuilder::version, ldloc:X509CertificateBuilder(this)))
	stloc:int32(var_32_BC, callgetter:int32(CollectionBase::get_Count, ldfld:X509ExtensionCollection[exp:CollectionBase](X509CertificateBuilder::extensions, ldloc:X509CertificateBuilder(this))))
	stloc:uint8[](var_33_C9, call:uint8[](X509ExtensionCollection::GetBytes, ldfld:X509ExtensionCollection(X509CertificateBuilder::extensions, ldloc:X509CertificateBuilder(this))))
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

		// Token: 0x04000083 RID: 131
		private byte version;

		// Token: 0x04000084 RID: 132
		private byte[] sn;

		// Token: 0x04000085 RID: 133
		private string issuer;

		// Token: 0x04000086 RID: 134
		private DateTime notBefore;

		// Token: 0x04000087 RID: 135
		private DateTime notAfter;

		// Token: 0x04000088 RID: 136
		private string subject;

		// Token: 0x04000089 RID: 137
		private AsymmetricAlgorithm aa;

		// Token: 0x0400008A RID: 138
		private byte[] issuerUniqueID;

		// Token: 0x0400008B RID: 139
		private byte[] subjectUniqueID;

		// Token: 0x0400008C RID: 140
		private X509ExtensionCollection extensions;
	}
}
