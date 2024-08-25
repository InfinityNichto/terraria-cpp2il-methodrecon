using System;
using System.Globalization;
using System.Security.Cryptography;
using Cpp2IlInjected;

namespace Mono.Security.X509
{
	// Token: 0x02000012 RID: 18
	public abstract class X509Builder
	{
		// Token: 0x0600009D RID: 157 RVA: 0x00004BC4 File Offset: 0x00002DC4
		protected X509Builder()
		{
			this.hashName = "SHA1";
		}

		// Token: 0x0600009E RID: 158
		protected abstract ASN1 ToBeSigned(string hashName);

		// Token: 0x0600009F RID: 159 RVA: 0x00004BE4 File Offset: 0x00002DE4
		protected string GetOid(string hashName)
		{
			if (!true)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			string text = hashName.ToLower(invariantCulture);
			uint num = <PrivateImplementationDetails>.ComputeStringHash(text);
			bool flag = text == "sha1";
			bool flag2 = text == "sha256";
			bool flag3 = text == "sha384";
			bool flag4 = text == "md4";
			bool flag5 = text == "md5";
			bool flag6 = text == "md2";
			bool flag7 = text == "sha512";
			return "1.2.840.113549.1.1.13";
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00004C78 File Offset: 0x00002E78
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x00004C8C File Offset: 0x00002E8C
		public string Hash
		{
			get
			{
				return this.hashName;
			}
			set
			{
				if (this.hashName != null)
				{
					this.hashName = value;
					return;
				}
				this.hashName = "SHA1";
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002050 File Offset: 0x00000250
		public virtual byte[] Sign(AsymmetricAlgorithm aa)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00004CB4 File Offset: 0x00002EB4
		private byte[] Build(ASN1 tbs, string hashoid, byte[] signature)
		{
			/*
An exception occurred when decompiling this method (060000A3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] Mono.Security.X509.X509Builder::Build(Mono.Security.ASN1,System.String,System.Byte[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ASN1(var_1_06, call:ASN1(PKCS7::AlgorithmIdentifier, ldloc:string(hashoid)))
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

		// Token: 0x060000A4 RID: 164 RVA: 0x00004CC8 File Offset: 0x00002EC8
		public virtual byte[] Sign(RSA key)
		{
			string text = this.hashName;
			HashAlgorithm hashAlgorithm = HashAlgorithm.Create(this.hashName);
			string text2 = this.hashName;
			byte[] array;
			return array;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00004CF4 File Offset: 0x00002EF4
		public virtual byte[] Sign(DSA key)
		{
			while (HashAlgorithm.Create(this.hashName) == null)
			{
			}
			string text = this.hashName;
			byte[] array;
			return array;
		}

		// Token: 0x0400005A RID: 90
		private const string defaultHash = "SHA1";

		// Token: 0x0400005B RID: 91
		private string hashName;
	}
}
