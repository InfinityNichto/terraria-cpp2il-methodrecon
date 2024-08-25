using System;
using System.Collections;
using Cpp2IlInjected;
using Mono.Security.X509;

namespace Mono.Security
{
	// Token: 0x02000006 RID: 6
	public sealed class PKCS7
	{
		// Token: 0x06000024 RID: 36 RVA: 0x00002050 File Offset: 0x00000250
		public static ASN1 AlgorithmIdentifier(string oid)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002050 File Offset: 0x00000250
		public static ASN1 AlgorithmIdentifier(string oid, ASN1 parameters)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x02000007 RID: 7
		public class ContentInfo
		{
			// Token: 0x06000026 RID: 38 RVA: 0x0000250C File Offset: 0x0000070C
			public ContentInfo()
			{
			}

			// Token: 0x06000027 RID: 39 RVA: 0x00002520 File Offset: 0x00000720
			public ContentInfo(string oid)
			{
				this.contentType = oid;
			}

			// Token: 0x06000028 RID: 40 RVA: 0x00002534 File Offset: 0x00000734
			public ContentInfo(byte[] data)
			{
			}

			// Token: 0x06000029 RID: 41 RVA: 0x00002544 File Offset: 0x00000744
			public ContentInfo(ASN1 asn1)
			{
				byte nTag = asn1.m_nTag;
				if (asn1.elist == null || asn1.elist != null)
				{
				}
				long num = 0L;
				byte nTag2 = asn1[(int)num].m_nTag;
				long num2 = 0L;
				string text = ASN1Convert.ToOid(asn1[(int)num2]);
				this.contentType = text;
				if (asn1.elist != null)
				{
					byte nTag3 = asn1[1].m_nTag;
					ASN1 asn2 = asn1[1];
					this.content = asn2;
				}
			}

			// Token: 0x17000006 RID: 6
			// (get) Token: 0x0600002A RID: 42 RVA: 0x000025C0 File Offset: 0x000007C0
			public ASN1 ASN1
			{
				get
				{
					return this.GetASN1();
				}
			}

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x0600002B RID: 43 RVA: 0x000025D4 File Offset: 0x000007D4
			// (set) Token: 0x0600002C RID: 44 RVA: 0x000025E8 File Offset: 0x000007E8
			public ASN1 Content
			{
				get
				{
					return this.content;
				}
				set
				{
					this.content = value;
				}
			}

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x0600002D RID: 45 RVA: 0x000025FC File Offset: 0x000007FC
			// (set) Token: 0x0600002E RID: 46 RVA: 0x00002610 File Offset: 0x00000810
			public string ContentType
			{
				get
				{
					return this.contentType;
				}
				set
				{
					this.contentType = value;
				}
			}

			// Token: 0x0600002F RID: 47 RVA: 0x00002624 File Offset: 0x00000824
			internal ASN1 GetASN1()
			{
				/*
An exception occurred when decompiling this method (0600002F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Mono.Security.ASN1 Mono.Security.PKCS7/ContentInfo::GetASN1()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_1:
	stloc:ASN1(var_3_24, ldfld:ASN1(ContentInfo::content, ldloc:ContentInfo(this)))
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

			// Token: 0x04000004 RID: 4
			private string contentType;

			// Token: 0x04000005 RID: 5
			private ASN1 content;
		}

		// Token: 0x02000008 RID: 8
		public class EncryptedData
		{
			// Token: 0x06000030 RID: 48 RVA: 0x00002658 File Offset: 0x00000858
			public EncryptedData()
			{
			}

			// Token: 0x06000031 RID: 49 RVA: 0x0000266C File Offset: 0x0000086C
			public EncryptedData(ASN1 asn1)
			{
				byte nTag = asn1.m_nTag;
				if (asn1.elist != null)
				{
					long num = 0L;
					byte nTag2 = asn1[(int)num].m_nTag;
					long num2 = 0L;
					byte[] value = asn1[(int)num2].Value;
					this._version = nTag2;
					byte nTag3 = asn1[1].m_nTag;
					long num3 = 0L;
					ASN1 asn2 = asn1[(int)num3];
					byte nTag4 = asn2.m_nTag;
					string text = ASN1Convert.ToOid(asn2);
					ASN1 asn3 = asn1[1];
					byte nTag5 = asn3.m_nTag;
					string text2 = ASN1Convert.ToOid(asn3[1]);
					ASN1 asn4 = asn3[1];
					ASN1 asn5 = asn1[2];
					byte nTag6 = asn5.m_nTag;
					byte[] value2 = asn5.Value;
					this._encrypted = value2;
					return;
				}
			}

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x06000032 RID: 50 RVA: 0x00002738 File Offset: 0x00000938
			public PKCS7.ContentInfo EncryptionAlgorithm
			{
				get
				{
					return this._encryptionAlgorithm;
				}
			}

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x06000033 RID: 51 RVA: 0x0000274C File Offset: 0x0000094C
			public byte[] EncryptedContent
			{
				get
				{
					object obj;
					if (this._encrypted == null || obj == null || obj != null)
					{
					}
					throw new InvalidCastException();
				}
			}

			// Token: 0x04000006 RID: 6
			private byte _version;

			// Token: 0x04000007 RID: 7
			private PKCS7.ContentInfo _content;

			// Token: 0x04000008 RID: 8
			private PKCS7.ContentInfo _encryptionAlgorithm;

			// Token: 0x04000009 RID: 9
			private byte[] _encrypted;
		}

		// Token: 0x02000009 RID: 9
		public class SignedData
		{
			// Token: 0x06000034 RID: 52 RVA: 0x0000276C File Offset: 0x0000096C
			public SignedData(ASN1 asn1)
			{
				long num = 0L;
				byte nTag = asn1[(int)num].m_nTag;
				long num2 = 0L;
				if (asn1[(int)num2].elist != null)
				{
					long num3 = 0L;
					ASN1 asn2 = asn1[(int)num3];
					long num4 = 0L;
					byte nTag2 = asn2[(int)num4].m_nTag;
					long num5 = 0L;
					ASN1 asn3 = asn1[(int)num5];
					long num6 = 0L;
					byte[] value = asn3[(int)num6].Value;
					long num7 = 0L;
					this.version = nTag2;
					ASN1 asn4 = asn1[(int)num7];
					int num8 = 2;
					ASN1 asn5 = asn4[num8];
					long num9 = 0L;
					ASN1 asn6 = asn1[(int)num9];
					int num10 = 3;
					byte nTag3 = asn6[num10].m_nTag;
					long num11 = 0L;
					long num12 = 0L;
					ASN1 asn7 = asn1[(int)num12];
					int num13 = 3;
					if (asn7[num13].elist != null)
					{
					}
					X509CertificateCollection x509CertificateCollection = this.certs;
					long num14 = 0L;
					ASN1 asn8 = asn1[(int)num14];
					int num15 = 3;
					ASN1 asn9 = asn8[num15][(int)num11];
					return;
				}
			}

			// Token: 0x1700000B RID: 11
			// (get) Token: 0x06000035 RID: 53 RVA: 0x00002924 File Offset: 0x00000B24
			public X509CertificateCollection Certificates
			{
				get
				{
					return this.certs;
				}
			}

			// Token: 0x1700000C RID: 12
			// (get) Token: 0x06000036 RID: 54 RVA: 0x00002938 File Offset: 0x00000B38
			public PKCS7.ContentInfo ContentInfo
			{
				get
				{
					return this.contentInfo;
				}
			}

			// Token: 0x1700000D RID: 13
			// (set) Token: 0x06000037 RID: 55 RVA: 0x0000294C File Offset: 0x00000B4C
			public string HashName
			{
				set
				{
					PKCS7.SignerInfo signerInfo = this.signerInfo;
					this.hashAlgorithm = value;
					signerInfo.hashAlgorithm = value;
				}
			}

			// Token: 0x1700000E RID: 14
			// (get) Token: 0x06000038 RID: 56 RVA: 0x00002970 File Offset: 0x00000B70
			public PKCS7.SignerInfo SignerInfo
			{
				get
				{
					return this.signerInfo;
				}
			}

			// Token: 0x06000039 RID: 57 RVA: 0x00002984 File Offset: 0x00000B84
			internal string OidToName(string oid)
			{
				bool flag = oid == "1.3.14.3.2.26";
				bool flag2 = oid == "1.2.840.113549.2.2";
				bool flag3 = oid == "1.2.840.113549.2.5";
				bool flag4 = oid == "2.16.840.1.101.3.4.1";
				bool flag5 = oid == "2.16.840.1.101.3.4.2";
				return "SHA384";
			}

			// Token: 0x0400000A RID: 10
			private byte version;

			// Token: 0x0400000B RID: 11
			private string hashAlgorithm;

			// Token: 0x0400000C RID: 12
			private PKCS7.ContentInfo contentInfo;

			// Token: 0x0400000D RID: 13
			private X509CertificateCollection certs;

			// Token: 0x0400000E RID: 14
			private ArrayList crls;

			// Token: 0x0400000F RID: 15
			private PKCS7.SignerInfo signerInfo;

			// Token: 0x04000010 RID: 16
			private bool mda;
		}

		// Token: 0x0200000A RID: 10
		public class SignerInfo
		{
			// Token: 0x0600003A RID: 58 RVA: 0x000029E0 File Offset: 0x00000BE0
			public SignerInfo()
			{
				this.version = 1;
			}

			// Token: 0x0600003B RID: 59 RVA: 0x000029FC File Offset: 0x00000BFC
			public SignerInfo(ASN1 asn1)
			{
				long num = 0L;
				byte nTag = asn1[(int)num].m_nTag;
				long num2 = 0L;
				if (asn1[(int)num2].elist != null)
				{
					long num3 = 0L;
					ASN1 asn2 = asn1[(int)num3];
					long num4 = 0L;
					byte nTag2 = asn2[(int)num4].m_nTag;
					long num5 = 0L;
					ASN1 asn3 = asn1[(int)num5];
					long num6 = 0L;
					byte[] value = asn3[(int)num6].Value;
					long num7 = 0L;
					this.version = nTag2;
					ASN1 asn4 = asn1[(int)num7];
					int num8 = 1;
					ASN1 asn5 = asn4[num8];
					byte nTag3 = asn5.m_nTag;
					byte b = this.version;
					byte[] value2 = asn5.Value;
					this.ski = value2;
					return;
				}
			}

			// Token: 0x1700000F RID: 15
			// (get) Token: 0x0600003C RID: 60 RVA: 0x00002BCC File Offset: 0x00000DCC
			public string IssuerName
			{
				get
				{
					return this.issuer;
				}
			}

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x0600003D RID: 61 RVA: 0x00002BE0 File Offset: 0x00000DE0
			public byte[] SerialNumber
			{
				get
				{
					object obj;
					if (this.serial == null || obj == null || obj != null)
					{
					}
					throw new InvalidCastException();
				}
			}

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x0600003E RID: 62 RVA: 0x00002C00 File Offset: 0x00000E00
			public ArrayList AuthenticatedAttributes
			{
				get
				{
					return this.authenticatedAttributes;
				}
			}

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x0600003F RID: 63 RVA: 0x00002C14 File Offset: 0x00000E14
			// (set) Token: 0x06000040 RID: 64 RVA: 0x00002C28 File Offset: 0x00000E28
			public string HashName
			{
				get
				{
					return this.hashAlgorithm;
				}
				set
				{
					this.hashAlgorithm = value;
				}
			}

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x06000041 RID: 65 RVA: 0x00002C3C File Offset: 0x00000E3C
			public byte[] Signature
			{
				get
				{
					object obj;
					if (this.signature == null || obj == null || obj != null)
					{
					}
					throw new InvalidCastException();
				}
			}

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x06000042 RID: 66 RVA: 0x00002C5C File Offset: 0x00000E5C
			public ArrayList UnauthenticatedAttributes
			{
				get
				{
					return this.unauthenticatedAttributes;
				}
			}

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x06000043 RID: 67 RVA: 0x00002C70 File Offset: 0x00000E70
			public byte Version
			{
				get
				{
					return this.version;
				}
			}

			// Token: 0x04000011 RID: 17
			private byte version;

			// Token: 0x04000012 RID: 18
			private string hashAlgorithm;

			// Token: 0x04000013 RID: 19
			private ArrayList authenticatedAttributes;

			// Token: 0x04000014 RID: 20
			private ArrayList unauthenticatedAttributes;

			// Token: 0x04000015 RID: 21
			private byte[] signature;

			// Token: 0x04000016 RID: 22
			private string issuer;

			// Token: 0x04000017 RID: 23
			private byte[] serial;

			// Token: 0x04000018 RID: 24
			private byte[] ski;
		}
	}
}
