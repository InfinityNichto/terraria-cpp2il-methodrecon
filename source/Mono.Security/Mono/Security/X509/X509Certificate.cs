using System;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using Mono.Security.Cryptography;

namespace Mono.Security.X509
{
	// Token: 0x02000015 RID: 21
	public class X509Certificate : ISerializable
	{
		// Token: 0x060000C5 RID: 197 RVA: 0x0000538C File Offset: 0x0000358C
		private void Parse(byte[] data)
		{
			ASN1 asn;
			byte nTag = asn.m_nTag;
			ASN1 asn2 = this.decoder;
			long num = 0L;
			ASN1 asn3 = asn2[(int)num];
			ASN1 asn4 = this.decoder;
			long num2 = 0L;
			ASN1 asn5 = asn4[(int)num2];
			long num3 = 0L;
			ASN1 asn6 = asn5[(int)num3];
			int num4 = 1;
			this.version = num4;
			byte nTag2 = asn6.m_nTag;
			int num5;
			if (asn6.elist != null)
			{
				num5 = this.version;
				long num6 = 0L;
				byte[] value = asn6[(int)num6].Value;
				return;
			}
			long num7 = 0L;
			ASN1 asn7 = this.decoder;
			long num8 = 0L;
			ASN1 asn8 = asn7[(int)num8][(int)num7];
			byte nTag3 = asn8.m_nTag;
			byte[] value2 = asn8.Value;
			this.serialnumber = value2;
			int num9 = 48;
			ASN1 asn9 = asn3.Element(num5, (byte)num9);
			this.issuer = asn9;
			string text = X501.ToString(asn9);
			this.m_issuername = text;
			int num10 = 48;
			ASN1 asn10 = asn3.Element(num5, (byte)num10);
			long num11 = 0L;
			DateTime dateTime = ASN1Convert.ToDateTime(asn10[(int)num11]);
			this.m_from = dateTime;
			int num12 = 1;
			DateTime dateTime2 = ASN1Convert.ToDateTime(asn10[num12]);
			this.m_until = dateTime2;
			int num13 = 48;
			ASN1 asn11 = asn3.Element(num12, (byte)num13);
			this.subject = asn11;
			string text2 = X501.ToString(asn11);
			this.m_subject = text2;
			int num14 = 48;
			ASN1 asn12 = asn3.Element(num12, (byte)num14);
			int num15 = 48;
			long num16 = 0L;
			ASN1 asn13 = asn12.Element((int)num16, (byte)num15);
			int num17 = 6;
			long num18 = 0L;
			string text3 = ASN1Convert.ToOid(asn13.Element((int)num18, (byte)num17));
			this.m_keyalgo = text3;
			int num19 = 1;
			ASN1 asn14 = asn13[num19];
			if (asn13.elist != null)
			{
				return;
			}
			long num20;
			this.m_keyalgoparams = num20;
			int num21 = 1;
			int num22 = 3;
			ASN1 asn15 = asn12.Element(num21, (byte)num22);
			if (asn15.m_aValue != null)
			{
			}
			byte[] value3 = asn15.Value;
			byte[] publickey = this.m_publickey;
			ASN1 asn16 = this.decoder;
			int num23 = 2;
			byte[] value4 = asn16[num23].Value;
			ASN1 asn17 = this.decoder;
			int num24 = 1;
			ASN1 asn18 = asn17[num24];
			int num25 = 6;
			long num26 = 0L;
			string text4 = ASN1Convert.ToOid(asn18.Element((int)num26, (byte)num25));
			this.m_signaturealgo = text4;
			int num27 = 1;
			ASN1 asn19 = asn18[num27];
			if (asn19 != null)
			{
			}
			this.m_signaturealgoparams = asn19;
			int num28 = 129;
			ASN1 asn20 = asn3.Element((int)num7, (byte)num28);
			if (asn20 != null)
			{
				byte[] value5 = asn20.Value;
				this.issuerUniqueID = value5;
			}
			int num29 = 130;
			ASN1 asn21 = asn3.Element((int)num7, (byte)num29);
			if (asn21 != null)
			{
				byte[] value6 = asn21.Value;
				this.subjectUniqueID = value6;
			}
			int num30 = 163;
			ASN1 asn22 = asn3.Element((int)num7, (byte)num30);
			if (asn22 != null && asn22.elist != null)
			{
				long num31 = 0L;
				ASN1 asn23 = asn22[(int)num31];
				return;
			}
			object obj;
			if (obj != null)
			{
				if (obj == null)
				{
					throw new InvalidCastException();
				}
				this.m_encodedcert = obj;
				if (obj == null)
				{
					throw new InvalidCastException();
				}
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000056CC File Offset: 0x000038CC
		public X509Certificate(byte[] data)
		{
			int num = 1;
			base..ctor();
			if (data != null)
			{
				byte[] array;
				if (num != 0)
				{
					array = X509Certificate.PEM("CERTIFICATE", data);
				}
				this.Parse(array);
				return;
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00005700 File Offset: 0x00003900
		private byte[] GetUnsignedBigInteger(byte[] integer)
		{
			/*
An exception occurred when decompiling this method (060000C7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] Mono.Security.X509.X509Certificate::GetUnsignedBigInteger(System.Byte[])

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

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00005710 File Offset: 0x00003910
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x00005794 File Offset: 0x00003994
		public DSA DSA
		{
			get
			{
				while (this.m_keyalgoparams == null)
				{
				}
				if (this._dsa == null)
				{
					bool flag = this.m_keyalgo == "1.2.840.10040.4.1";
					byte[] publickey = this.m_publickey;
					byte[] keyalgoparams = this.m_keyalgoparams;
					ASN1 asn;
					byte nTag = asn.m_nTag;
					ASN1 asn2;
					byte nTag2 = asn2.m_nTag;
					ASN1 asn3;
					byte nTag3 = asn3.m_nTag;
					ASN1 asn4;
					byte[] value = asn4.Value;
					ASN1 asn5;
					byte[] value2 = asn5.Value;
					ASN1 asn6;
					byte[] value3 = asn6.Value;
				}
				return this._dsa;
			}
			set
			{
				this._dsa = value;
				if (value != null)
				{
				}
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000CA RID: 202 RVA: 0x000057AC File Offset: 0x000039AC
		public X509ExtensionCollection Extensions
		{
			get
			{
				return this.extensions;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000CB RID: 203 RVA: 0x000057C0 File Offset: 0x000039C0
		public byte[] Hash
		{
			get
			{
				string text;
				for (;;)
				{
					object obj;
					if (this.certhash != null)
					{
						if (obj != null && obj == null)
						{
							break;
						}
					}
					else if (obj != null && text != null)
					{
						goto Block_4;
					}
				}
				throw new InvalidCastException();
				Block_4:
				HashAlgorithm hashAlgorithm = PKCS1.CreateFromName(text);
				ASN1 asn;
				byte[] aValue = asn.m_aValue;
				long num = 0L;
				if (hashAlgorithm != null)
				{
					long value = 0.m_value;
				}
				if (num == 0L)
				{
					throw new InvalidCastException();
				}
				throw new OutOfMemoryException();
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00005834 File Offset: 0x00003A34
		public virtual string IssuerName
		{
			get
			{
				return this.m_issuername;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00005848 File Offset: 0x00003A48
		public virtual string KeyAlgorithm
		{
			get
			{
				return this.m_keyalgo;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000CE RID: 206 RVA: 0x0000585C File Offset: 0x00003A5C
		// (set) Token: 0x060000CF RID: 207 RVA: 0x0000587C File Offset: 0x00003A7C
		public virtual byte[] KeyAlgorithmParameters
		{
			get
			{
				object obj;
				if (this.m_keyalgoparams == null || obj == null || obj != null)
				{
				}
				throw new InvalidCastException();
			}
			set
			{
				this.m_keyalgoparams = value;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00005890 File Offset: 0x00003A90
		public virtual byte[] PublicKey
		{
			get
			{
				object obj;
				if (this.m_publickey == null || obj == null || obj != null)
				{
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x000058B0 File Offset: 0x00003AB0
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x00005914 File Offset: 0x00003B14
		public virtual RSA RSA
		{
			get
			{
				while (this._rsa == null)
				{
					bool flag = this.m_keyalgo == "1.2.840.113549.1.1.1";
					byte[] publickey = this.m_publickey;
					ASN1 asn;
					if (asn != null)
					{
						byte nTag = asn.m_nTag;
						ASN1 asn2;
						byte nTag2 = asn2.m_nTag;
						byte[] value = asn.Value;
						byte[] value2 = asn2.Value;
						this._rsa = 0;
						break;
					}
				}
				return this._rsa;
			}
			set
			{
				if (value != null)
				{
				}
				this._rsa = value;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x0000592C File Offset: 0x00003B2C
		public virtual byte[] RawData
		{
			get
			{
				object obj;
				if (this.m_encodedcert == null || obj == null || obj != null)
				{
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x0000594C File Offset: 0x00003B4C
		public virtual byte[] SerialNumber
		{
			get
			{
				object obj;
				if (this.serialnumber == null || obj == null || obj != null)
				{
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x0000596C File Offset: 0x00003B6C
		public virtual byte[] Signature
		{
			get
			{
				if (this.signature != null)
				{
					string signaturealgo = this.m_signaturealgo;
					uint num = <PrivateImplementationDetails>.ComputeStringHash(signaturealgo);
					bool flag = signaturealgo == "1.2.840.10040.4.3";
					byte[] array = this.signature;
					ASN1 asn;
					byte[] value = asn.Value;
					ASN1 asn2;
					byte[] value2 = asn2.Value;
					int num2 = 40;
					int num3 = Math.Max(0, num2);
					int num4 = Math.Max(0, num2);
					int num5 = Math.Max(0, num3);
					int num6 = Math.Max(20, num3);
					return value2;
				}
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00005A60 File Offset: 0x00003C60
		public virtual string SignatureAlgorithm
		{
			get
			{
				return this.m_signaturealgo;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00005A74 File Offset: 0x00003C74
		public virtual byte[] SignatureAlgorithmParameters
		{
			get
			{
				object obj;
				if (this.m_signaturealgoparams == null || obj == null || obj != null)
				{
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00005A94 File Offset: 0x00003C94
		public virtual string SubjectName
		{
			get
			{
				return this.m_subject;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00005AA8 File Offset: 0x00003CA8
		public virtual DateTime ValidFrom
		{
			get
			{
				DateTime from = this.m_from;
				DateTime dateTime;
				return dateTime;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000DA RID: 218 RVA: 0x00005AC0 File Offset: 0x00003CC0
		public virtual DateTime ValidUntil
		{
			get
			{
				DateTime until = this.m_until;
				DateTime dateTime;
				return dateTime;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00005AD8 File Offset: 0x00003CD8
		public int Version
		{
			get
			{
				return this.version;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000DC RID: 220 RVA: 0x00005AEC File Offset: 0x00003CEC
		public bool IsCurrent
		{
			get
			{
				if (!true)
				{
				}
				DateTime utcNow = DateTime.UtcNow;
				return this.WasCurrent(utcNow);
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00005B0C File Offset: 0x00003D0C
		public bool WasCurrent(DateTime instant)
		{
			bool flag;
			return flag;
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00005B1C File Offset: 0x00003D1C
		public byte[] IssuerUniqueIdentifier
		{
			get
			{
				object obj;
				if (this.issuerUniqueID == null || obj == null || obj != null)
				{
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00005B3C File Offset: 0x00003D3C
		public byte[] SubjectUniqueIdentifier
		{
			get
			{
				object obj;
				if (this.subjectUniqueID == null || obj == null || obj != null)
				{
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00005B5C File Offset: 0x00003D5C
		internal bool VerifySignature(DSA dsa)
		{
			/*
An exception occurred when decompiling this method (060000E0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Mono.Security.X509.X509Certificate::VerifySignature(System.Security.Cryptography.DSA)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8[](var_0_06, callgetter:uint8[](X509Certificate::get_Hash, ldloc:X509Certificate(this)))
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

		// Token: 0x060000E1 RID: 225 RVA: 0x00005B70 File Offset: 0x00003D70
		internal bool VerifySignature(RSA rsa)
		{
			/*
An exception occurred when decompiling this method (060000E1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Mono.Security.X509.X509Certificate::VerifySignature(System.Security.Cryptography.RSA)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_10, call:bool(string::op_Equality, ldfld:string(X509Certificate::m_signaturealgo, ldloc:X509Certificate(this)), ldstr:string("1.2.840.10040.4.3")))
	stloc:string(var_2_1F, call:string(PKCS1::HashNameFromOid, ldfld:string(X509Certificate::m_signaturealgo, ldloc:X509Certificate(this)), ldc.i4:bool(1)))
	stloc:uint8[](var_3_26, callgetter:uint8[](X509Certificate::get_Hash, ldloc:X509Certificate(this)))
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

		// Token: 0x060000E2 RID: 226 RVA: 0x00005BA4 File Offset: 0x00003DA4
		public bool VerifySignature(AsymmetricAlgorithm aa)
		{
			while (aa == null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00005BB8 File Offset: 0x00003DB8
		public bool CheckSignature(byte[] hash, string hashAlgorithm, byte[] signature)
		{
			if (this != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x00005BD0 File Offset: 0x00003DD0
		public bool IsSelfSigned
		{
			get
			{
				string issuername = this.m_issuername;
				string text = this.m_subject;
				bool flag = issuername != text;
				if (this != null)
				{
					bool flag2;
					return flag2;
				}
				bool flag3;
				if (this.DSA != null)
				{
					DSA dsa = this.DSA;
					flag3 = this.VerifySignature(dsa);
				}
				return flag3;
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00005C2C File Offset: 0x00003E2C
		public ASN1 GetIssuerName()
		{
			return this.issuer;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00005C40 File Offset: 0x00003E40
		public ASN1 GetSubjectName()
		{
			return this.subject;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00005C54 File Offset: 0x00003E54
		protected X509Certificate(SerializationInfo info, StreamingContext context)
		{
			if (!true)
			{
			}
			Type type;
			object value = info.GetValue("raw", type);
			if (value != null && value == null)
			{
				throw new InvalidCastException();
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00005C84 File Offset: 0x00003E84
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			byte[] encodedcert = this.m_encodedcert;
			info.AddValue("raw", encodedcert);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00005CA4 File Offset: 0x00003EA4
		private static byte[] PEM(string type, byte[] data)
		{
			Encoding ascii = Encoding.ASCII;
			string text = string.Format("-----BEGIN {0}-----", type);
			string text2 = string.Format("-----END {0}-----", type);
			int stringLength = text._stringLength;
			string text3;
			return Convert.FromBase64String(text3);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00005CE0 File Offset: 0x00003EE0
		// Note: this type is marked as 'beforefieldinit'.
		static X509Certificate()
		{
		}

		// Token: 0x04000069 RID: 105
		private ASN1 decoder;

		// Token: 0x0400006A RID: 106
		private byte[] m_encodedcert;

		// Token: 0x0400006B RID: 107
		private DateTime m_from;

		// Token: 0x0400006C RID: 108
		private DateTime m_until;

		// Token: 0x0400006D RID: 109
		private ASN1 issuer;

		// Token: 0x0400006E RID: 110
		private string m_issuername;

		// Token: 0x0400006F RID: 111
		private string m_keyalgo;

		// Token: 0x04000070 RID: 112
		private byte[] m_keyalgoparams;

		// Token: 0x04000071 RID: 113
		private ASN1 subject;

		// Token: 0x04000072 RID: 114
		private string m_subject;

		// Token: 0x04000073 RID: 115
		private byte[] m_publickey;

		// Token: 0x04000074 RID: 116
		private byte[] signature;

		// Token: 0x04000075 RID: 117
		private string m_signaturealgo;

		// Token: 0x04000076 RID: 118
		private byte[] m_signaturealgoparams;

		// Token: 0x04000077 RID: 119
		private byte[] certhash;

		// Token: 0x04000078 RID: 120
		private RSA _rsa;

		// Token: 0x04000079 RID: 121
		private DSA _dsa;

		// Token: 0x0400007A RID: 122
		internal const string OID_DSA = "1.2.840.10040.4.1";

		// Token: 0x0400007B RID: 123
		internal const string OID_RSA = "1.2.840.113549.1.1.1";

		// Token: 0x0400007C RID: 124
		internal const string OID_ECC = "1.2.840.10045.2.1";

		// Token: 0x0400007D RID: 125
		private int version;

		// Token: 0x0400007E RID: 126
		private byte[] serialnumber;

		// Token: 0x0400007F RID: 127
		private byte[] issuerUniqueID;

		// Token: 0x04000080 RID: 128
		private byte[] subjectUniqueID;

		// Token: 0x04000081 RID: 129
		private X509ExtensionCollection extensions;

		// Token: 0x04000082 RID: 130
		private static string encoding_error;
	}
}
