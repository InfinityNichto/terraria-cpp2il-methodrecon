using System;
using System.Collections;
using System.Security.Cryptography;
using Mono.Security.X509;

namespace Mono.Security.Authenticode
{
	// Token: 0x02000060 RID: 96
	public class AuthenticodeDeformatter : AuthenticodeBase
	{
		// Token: 0x0600029F RID: 671 RVA: 0x0000AB04 File Offset: 0x00008D04
		public AuthenticodeDeformatter()
		{
			this.reason = 1;
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0000AB20 File Offset: 0x00008D20
		public AuthenticodeDeformatter(byte[] rawData)
		{
			this.RawData = rawData;
		}

		// Token: 0x170000BD RID: 189
		// (set) Token: 0x060002A1 RID: 673 RVA: 0x0000AB34 File Offset: 0x00008D34
		public byte[] RawData
		{
			set
			{
				this.Reset();
				this.rawdata = value;
				bool flag = this.CheckSignature();
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x0000AB68 File Offset: 0x00008D68
		public X509Certificate SigningCertificate
		{
			get
			{
				return this.signingCertificate;
			}
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0000AB7C File Offset: 0x00008D7C
		private bool CheckSignature()
		{
			/*
An exception occurred when decompiling this method (060002A3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Mono.Security.Authenticode.AuthenticodeDeformatter::CheckSignature()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_005E:
	stfld:int32(AuthenticodeDeformatter::reason, ldloc:AuthenticodeDeformatter(this), ldc.i4:int32(1))
	call:void(AuthenticodeBase::Close, ldloc:AuthenticodeDeformatter[exp:AuthenticodeBase](this))
	stloc:SHA1(var_13_76, call:SHA1(SHA1::Create))
	stloc:MD5(var_15_80, call:MD5(MD5::Create))
	stloc:SHA256(var_17_8A, call:SHA256(SHA256::Create))
	stloc:SHA384(var_19_94, call:SHA384(SHA384::Create))
	stloc:uint8[](var_20_9E, call:uint8[](AuthenticodeBase::GetHash, ldloc:AuthenticodeDeformatter[exp:AuthenticodeBase](this), ldloc:SHA384[exp:HashAlgorithm](var_19_94)))
	stfld:uint8[](AuthenticodeDeformatter::hash, ldloc:AuthenticodeDeformatter(this), ldloc:uint8[](var_20_9E))
	call:void(AuthenticodeBase::Close, ldloc:AuthenticodeDeformatter[exp:AuthenticodeBase](this))
	stloc:ASN1(var_21_B4, ldfld:ASN1(AuthenticodeDeformatter::signedHash, ldloc:AuthenticodeDeformatter(this)))
	stloc:uint8[](var_22_BC, ldfld:uint8[](AuthenticodeDeformatter::hash, ldloc:AuthenticodeDeformatter(this)))
	stloc:bool(var_23_C7, call:bool(ASN1::CompareValue, ldloc:ASN1(var_21_B4), ldloc:uint8[](var_22_BC)))
	stfld:int32(AuthenticodeDeformatter::reason, ldloc:AuthenticodeDeformatter(this), ldc.i4:int32(2))
	stloc:uint8[](var_26_DA, callgetter:uint8[](ASN1::get_Value, ldloc:ASN1(var_25)))
	stloc:uint8[](var_27_E5, call:uint8[](HashAlgorithm::ComputeHash, ldloc:SHA384[exp:HashAlgorithm](var_19_94), ldloc:uint8[](var_26_DA)))
	stloc:int32(var_30_F0, ldfld:int32(AuthenticodeDeformatter::reason, ldloc:AuthenticodeDeformatter(this)))
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

		// Token: 0x060002A4 RID: 676 RVA: 0x0000AC7C File Offset: 0x00008E7C
		private bool CompareIssuerSerial(string issuer, byte[] serial, X509Certificate x509)
		{
			/*
An exception occurred when decompiling this method (060002A4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Mono.Security.Authenticode.AuthenticodeDeformatter::CompareIssuerSerial(System.String,System.Byte[],Mono.Security.X509.X509Certificate)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8[](var_1_06, ldfld:uint8[](X509Certificate::m_encodedcert, ldloc:X509Certificate(x509)))
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

		// Token: 0x060002A5 RID: 677 RVA: 0x0000AC98 File Offset: 0x00008E98
		private bool VerifySignature(PKCS7.SignedData sd, byte[] calculatedMessageDigest, HashAlgorithm ha)
		{
			ArrayList authenticatedAttributes = sd.signerInfo.authenticatedAttributes;
			if (sd.signerInfo.authenticatedAttributes != null)
			{
			}
			ASN1 asn;
			string text = ASN1Convert.ToOid(asn);
			bool flag = text == "1.2.840.113549.1.9.3";
			long num = 0L;
			ASN1 asn2;
			string text2 = ASN1Convert.ToOid(asn2[(int)num]);
			bool flag2 = text == "1.2.840.113549.1.9.4";
			long num2 = 0L;
			ASN1 asn4;
			ASN1 asn3 = asn4[(int)num2];
			bool flag3 = text == "1.3.6.1.4.1.311.2.1.11";
			bool flag4 = text == "1.3.6.1.4.1.311.2.1.12";
			ArrayList authenticatedAttributes2 = sd.signerInfo.authenticatedAttributes;
			long num3 = 0L;
			if (num3 != 0L)
			{
				ArrayList authenticatedAttributes3 = sd.signerInfo.authenticatedAttributes;
				if (authenticatedAttributes3 != null)
				{
				}
				long num4 = 0L;
				int num5 = 12;
				if (authenticatedAttributes3 != null)
				{
				}
				if (num4 != 0L)
				{
					throw new OutOfMemoryException();
				}
				if (num5 == 0)
				{
					byte[] signature = sd.signerInfo.Signature;
					PKCS7.SignerInfo signerInfo = sd.signerInfo;
					string issuer = signerInfo.issuer;
					byte[] serialNumber = signerInfo.SerialNumber;
					X509CertificateCollection.X509CertificateEnumerator x509CertificateEnumerator;
					bool flag5 = x509CertificateEnumerator.MoveNext();
					X509Certificate x509Certificate = x509CertificateEnumerator.Current;
					byte[] encodedcert = x509Certificate.m_encodedcert;
					if (x509Certificate != null)
					{
					}
					bool flag6;
					return flag6;
				}
			}
			throw new InvalidCastException();
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0000AE60 File Offset: 0x00009060
		private bool VerifyCounterSignature(PKCS7.SignerInfo cs, byte[] signature)
		{
			byte version = cs.version;
			ArrayList authenticatedAttributes = cs.authenticatedAttributes;
			if (cs.authenticatedAttributes != null)
			{
			}
			ASN1 asn;
			string text = ASN1Convert.ToOid(asn);
			bool flag = text == "1.2.840.113549.1.9.3";
			long num = 0L;
			ASN1 asn2;
			string text2 = ASN1Convert.ToOid(asn2[(int)num]);
			bool flag2 = text == "1.2.840.113549.1.9.4";
			long num2 = 0L;
			ASN1 asn4;
			ASN1 asn3 = asn4[(int)num2];
			bool flag3 = text == "1.2.840.113549.1.9.5";
			long num3 = 0L;
			ASN1 asn5;
			DateTime dateTime = ASN1Convert.ToDateTime(asn5[(int)num3]);
			ArrayList authenticatedAttributes2 = cs.authenticatedAttributes;
			long num4 = 0L;
			ArrayList authenticatedAttributes3;
			if (num4 != 0L)
			{
				byte[] array = HashAlgorithm.Create("SHA256").ComputeHash(signature);
				byte[] signature2 = cs.Signature;
				authenticatedAttributes3 = cs.authenticatedAttributes;
				if (authenticatedAttributes3 != null)
				{
				}
			}
			long num5 = 0L;
			int num6 = 21;
			if (authenticatedAttributes3 != null)
			{
			}
			if (num5 == 0L)
			{
				while (num6 != 0)
				{
				}
				string issuer = cs.issuer;
				byte[] serialNumber = cs.SerialNumber;
				X509CertificateCollection.X509CertificateEnumerator x509CertificateEnumerator;
				bool flag4 = x509CertificateEnumerator.MoveNext();
				X509Certificate x509Certificate = x509CertificateEnumerator.Current;
				if (num5 != 0L)
				{
				}
				bool flag5;
				return flag5;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0000AFCC File Offset: 0x000091CC
		private void Reset()
		{
			X509Chain x509Chain = this.signerChain;
			this.reason = 1;
			x509Chain.Reset();
			this.timestampChain.Reset();
			if (!true)
			{
			}
			this.timestamp = 1;
		}

		// Token: 0x04000283 RID: 643
		private string filename;

		// Token: 0x04000284 RID: 644
		private byte[] rawdata;

		// Token: 0x04000285 RID: 645
		private byte[] hash;

		// Token: 0x04000286 RID: 646
		private X509CertificateCollection coll;

		// Token: 0x04000287 RID: 647
		private ASN1 signedHash;

		// Token: 0x04000288 RID: 648
		private DateTime timestamp;

		// Token: 0x04000289 RID: 649
		private X509Certificate signingCertificate;

		// Token: 0x0400028A RID: 650
		private int reason;

		// Token: 0x0400028B RID: 651
		private bool trustedRoot;

		// Token: 0x0400028C RID: 652
		private bool trustedTimestampRoot;

		// Token: 0x0400028D RID: 653
		private byte[] entry;

		// Token: 0x0400028E RID: 654
		private X509Chain signerChain;

		// Token: 0x0400028F RID: 655
		private X509Chain timestampChain;
	}
}
