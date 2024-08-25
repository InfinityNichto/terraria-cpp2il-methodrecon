using System;
using System.Collections;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using Mono.Security.Cryptography;

namespace Mono.Security.X509
{
	// Token: 0x0200000E RID: 14
	public class PKCS12 : ICloneable
	{
		// Token: 0x06000049 RID: 73 RVA: 0x00002CF8 File Offset: 0x00000EF8
		public PKCS12()
		{
			this._iterations = 2000;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002D18 File Offset: 0x00000F18
		public PKCS12(byte[] data)
		{
			this.Decode(data);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002D2C File Offset: 0x00000F2C
		public PKCS12(byte[] data, string password)
		{
			this.Password = password;
			this.Decode(data);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002D48 File Offset: 0x00000F48
		public PKCS12(byte[] data, byte[] password)
		{
			this._password = password;
			this.Decode(data);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002D64 File Offset: 0x00000F64
		private void Decode(byte[] data)
		{
			ASN1 asn;
			byte nTag = asn.m_nTag;
			bool flag;
			if (flag)
			{
				ASN1 asn2;
				byte nTag2 = asn2.m_nTag;
				long num = 0L;
				byte nTag3 = asn2[(int)num].m_nTag;
				long num2 = 0L;
				ASN1 asn3;
				bool flag2 = ASN1Convert.ToOid(asn3[(int)num2]) != "1.3.14.3.2.26";
				int num3 = 1;
				ASN1 asn4;
				byte[] value = asn4.Value;
				int num4 = 1;
				ASN1 asn5 = asn2[num4];
				byte nTag4 = asn5.m_nTag;
				this._iterations = num3;
				if (asn2.elist != null)
				{
					int num5 = 2;
					ASN1 asn6 = asn2[num5];
					byte nTag5 = asn6.m_nTag;
					int num6 = ASN1Convert.ToInt32(asn6);
					this._iterations = num6;
				}
				ASN1 asn7;
				byte[] value2 = asn7.Value;
				byte[] password = this._password;
				byte[] value3 = asn5.Value;
				int iterations = this._iterations;
				return;
			}
			ASN1 asn8;
			byte[] value4 = asn8.Value;
			ASN1 asn9;
			byte[] value5 = asn9.Value;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002E9C File Offset: 0x0000109C
		protected override void Finalize()
		{
			if (this._password != null)
			{
			}
			base.Finalize();
		}

		// Token: 0x17000018 RID: 24
		// (set) Token: 0x0600004F RID: 79 RVA: 0x00002ED8 File Offset: 0x000010D8
		public string Password
		{
			set
			{
				int num = 1;
				long num2;
				if (this._password != null)
				{
					num2 = 0L;
				}
				if (value != null)
				{
					int stringLength = value._stringLength;
					if (num == 0)
					{
					}
					if (!true)
					{
					}
					char c = value[(int)num2];
					return;
				}
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00002F2C File Offset: 0x0000112C
		// (set) Token: 0x06000051 RID: 81 RVA: 0x00002F40 File Offset: 0x00001140
		public int IterationCount
		{
			get
			{
				return this._iterations;
			}
			set
			{
				this._iterations = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00002F54 File Offset: 0x00001154
		public ArrayList Keys
		{
			get
			{
				if (this._keyBagsChanged)
				{
					ArrayList keyBags = this._keyBags;
					return this._safeBags;
				}
				ArrayList keyBags2 = this._keyBags;
				return ArrayList.ReadOnly(keyBags2);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00003050 File Offset: 0x00001250
		public ArrayList Secrets
		{
			get
			{
				if (this._secretBagsChanged)
				{
					ArrayList secretBags = this._secretBags;
					return this._safeBags;
				}
				ArrayList secretBags2 = this._secretBags;
				return ArrayList.ReadOnly(secretBags2);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000054 RID: 84 RVA: 0x000030E8 File Offset: 0x000012E8
		public X509CertificateCollection Certificates
		{
			get
			{
				while (this._certsChanged)
				{
					this._certs.Clear();
					ArrayList safeBags = this._safeBags;
					if (safeBags != null)
					{
					}
					object[] items = safeBags._items;
					int size = safeBags._size;
					ASN1 asn;
					byte[] value = asn.Value;
					X509CertificateCollection certs = this._certs;
					ASN1 asn2;
					byte[] value2 = asn2.Value;
					long num = 0L;
					int num2 = 5;
					if (safeBags != null)
					{
					}
					if (num != 0L)
					{
						throw new OutOfMemoryException();
					}
					if (num2 == 0)
					{
						break;
					}
				}
				return this._certs;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00003174 File Offset: 0x00001374
		internal RandomNumberGenerator RNG
		{
			get
			{
				RandomNumberGenerator randomNumberGenerator;
				if (this._rng == null)
				{
					randomNumberGenerator = RandomNumberGenerator.Create();
					this._rng = randomNumberGenerator;
				}
				return randomNumberGenerator;
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00003198 File Offset: 0x00001398
		private bool Compare(byte[] expected, byte[] actual)
		{
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000031A8 File Offset: 0x000013A8
		private SymmetricAlgorithm GetSymmetricAlgorithm(string algorithmOid, byte[] salt, int iterationCount)
		{
			byte[] password = this._password;
			uint num = <PrivateImplementationDetails>.ComputeStringHash(algorithmOid);
			bool flag = algorithmOid == "1.2.840.113549.1.5.11";
			bool flag2 = algorithmOid == "1.2.840.113549.1.5.1";
			bool flag3 = algorithmOid == "1.2.840.113549.1.12.1.2";
			SymmetricAlgorithm symmetricAlgorithm = SymmetricAlgorithm.Create("RC2");
			if (8 != 0)
			{
			}
			return symmetricAlgorithm;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00003200 File Offset: 0x00001400
		public byte[] Decrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] encryptedData)
		{
			SymmetricAlgorithm symmetricAlgorithm = this.GetSymmetricAlgorithm(algorithmOid, salt, iterationCount);
			long num = 0L;
			if (symmetricAlgorithm != null)
			{
				symmetricAlgorithm.Clear();
			}
			if (num == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000324C File Offset: 0x0000144C
		public byte[] Decrypt(PKCS7.EncryptedData ed)
		{
			PKCS7.ContentInfo encryptionAlgorithm = ed._encryptionAlgorithm;
			long num = 0L;
			string contentType = encryptionAlgorithm.contentType;
			byte[] value = encryptionAlgorithm.content[(int)num].Value;
			int num2 = ASN1Convert.ToInt32(ed._encryptionAlgorithm.content[1]);
			byte[] encryptedContent = ed.EncryptedContent;
			return this.Decrypt(contentType, value, num2, encryptedContent);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000032A8 File Offset: 0x000014A8
		public byte[] Encrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] data)
		{
			SymmetricAlgorithm symmetricAlgorithm = this.GetSymmetricAlgorithm(algorithmOid, salt, iterationCount);
			long num = 0L;
			if (symmetricAlgorithm != null)
			{
			}
			if (num == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000032EC File Offset: 0x000014EC
		private DSAParameters GetExistingParameters([Out] bool found)
		{
			X509CertificateCollection.X509CertificateEnumerator enumerator;
			X509Certificate x509Certificate;
			do
			{
				enumerator = this.Certificates.GetEnumerator();
				bool flag = enumerator.MoveNext();
				x509Certificate = enumerator.Current;
				while (x509Certificate == null)
				{
				}
			}
			while (x509Certificate.DSA == null);
			int num = 1;
			found.m_value = num != 0;
			long num2 = 0L;
			int num3 = 5;
			if (enumerator != null)
			{
			}
			if (num2 != 0L || num3 == 0)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00003350 File Offset: 0x00001550
		private void AddPrivateKey(PKCS8.PrivateKeyInfo pki)
		{
			byte[] privateKey = pki.PrivateKey;
			string algorithm = pki._algorithm;
			bool flag = algorithm == "1.2.840.113549.1.1.1";
			ArrayList keyBags = this._keyBags;
			RSA rsa = PKCS8.PrivateKeyInfo.DecodeRSA(privateKey);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000033EC File Offset: 0x000015EC
		private void ReadSafeBag(ASN1 safeBag)
		{
			byte nTag = safeBag.m_nTag;
			long num = 0L;
			ASN1 asn = safeBag[(int)num];
			byte nTag2 = asn.m_nTag;
			int num2 = 1;
			ASN1 asn2 = safeBag[num2];
			bool flag = ASN1Convert.ToOid(asn) == "1.2.840.113549.1.12.10.1.1";
			byte[] value = asn2.Value;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00003504 File Offset: 0x00001704
		private ASN1 Pkcs8ShroudedKeyBagSafeBag(AsymmetricAlgorithm aa, IDictionary attributes)
		{
			int iterations = this._iterations;
			int iterations2 = this._iterations;
			byte[] array2;
			byte[] array3;
			byte[] array = this.Encrypt("1.2.840.113549.1.12.1.3", array2, iterations2, array3);
			ASN1 asn = ASN1Convert.FromOid("1.2.840.113549.1.12.10.1.2");
			if (attributes != null)
			{
				if (attributes != null)
				{
				}
				ASN1 asn2 = ASN1Convert.FromOid("1.2.840.113549.1.9.20");
				if (attributes == null || attributes == null)
				{
				}
				ASN1 asn3;
				return asn3;
			}
			ASN1 asn4;
			return asn4;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000035CC File Offset: 0x000017CC
		private ASN1 KeyBagSafeBag(AsymmetricAlgorithm aa, IDictionary attributes)
		{
			ASN1 asn = ASN1Convert.FromOid("1.2.840.113549.1.12.10.1.1");
			if (attributes != null)
			{
				if (attributes != null)
				{
				}
				ASN1 asn2 = ASN1Convert.FromOid("1.2.840.113549.1.9.20");
				if (attributes == null || attributes == null)
				{
				}
				ASN1 asn3;
				return asn3;
			}
			ASN1 asn4;
			return asn4;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00003680 File Offset: 0x00001880
		private ASN1 SecretBagSafeBag(byte[] secret, IDictionary attributes)
		{
			ASN1 asn = ASN1Convert.FromOid("1.2.840.113549.1.12.10.1.5");
			if (attributes != null)
			{
				if (attributes != null)
				{
				}
				ASN1 asn2 = ASN1Convert.FromOid("1.2.840.113549.1.9.20");
				if (attributes == null || attributes == null)
				{
				}
				ASN1 asn3;
				return asn3;
			}
			ASN1 asn4;
			return asn4;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00003728 File Offset: 0x00001928
		private ASN1 CertificateSafeBag(X509Certificate x509, IDictionary attributes)
		{
			ASN1 asn = ASN1Convert.FromOid("1.2.840.113549.1.12.10.1.3");
			if (attributes != null)
			{
				if (attributes != null)
				{
				}
				ASN1 asn2 = ASN1Convert.FromOid("1.2.840.113549.1.9.20");
				if (attributes == null || attributes == null)
				{
				}
				ASN1 asn3;
				return asn3;
			}
			ASN1 asn4;
			return asn4;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000037D0 File Offset: 0x000019D0
		private byte[] MAC(byte[] password, byte[] salt, int iterations, byte[] data)
		{
			HMAC hmac = HMAC.Create();
			if (hmac != null)
			{
			}
			long num = 0L;
			return hmac.ComputeHash(data, (int)num, iterations);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00003800 File Offset: 0x00001A00
		public byte[] GetBytes()
		{
			ASN1 asn;
			byte[] value = asn.Value;
			ASN1 asn2;
			byte[] value2 = asn2.Value;
			if (!false)
			{
				X509CertificateCollection x509CertificateCollection;
				X509CertificateCollection.X509CertificateEnumerator enumerator = x509CertificateCollection.GetEnumerator();
				long num = 0L;
				if (num != 0L)
				{
				}
				if (num != 0L)
				{
				}
				X509Certificate x509Certificate;
				byte[] encodedcert = x509Certificate.m_encodedcert;
				long num2 = 0L;
				int num3 = 9;
				if (num != 0L)
				{
				}
				if (num2 != 0L)
				{
					throw new OutOfMemoryException();
				}
				if (num3 == 0)
				{
					throw new InvalidCastException();
				}
				long num4 = 0L;
				if (num != 0L)
				{
				}
				if (num4 == 0L)
				{
					int num5;
					if (num5 == 0)
					{
						if (num != 0L)
						{
						}
						if (num != 0L)
						{
						}
						X509CertificateCollection x509CertificateCollection2;
						X509CertificateCollection.X509CertificateEnumerator enumerator2 = x509CertificateCollection2.GetEnumerator();
						long num6 = 0L;
						bool flag = enumerator2.MoveNext();
						byte[] encodedcert2 = enumerator2.Current.m_encodedcert;
						long num7 = 0L;
						int num8 = 15;
						if (enumerator2 == null || num6 != 0L)
						{
						}
						if (num7 != 0L)
						{
							throw new OutOfMemoryException();
						}
						if (num8 == 0)
						{
						}
						long num9 = 0L;
						if (num6 != 0L)
						{
						}
						if (num9 == 0L)
						{
							if (num6 != 0L)
							{
							}
							if (num6 != 0L)
							{
							}
							long num10 = 0L;
							int num11 = 19;
							if (num10 == 0L)
							{
								if (num11 != 0)
								{
									goto IL_019F;
								}
								long num12 = 0L;
								int num13 = 22;
								if (num12 != 0L)
								{
									goto IL_020B;
								}
								if (num13 != 0)
								{
									goto IL_019F;
								}
								long num14 = 0L;
								int num15 = 26;
								if (num14 == 0L)
								{
									if (num15 != 0)
									{
										goto IL_019F;
									}
									if ("UI.SpawnPoint" != null)
									{
										PKCS7.ContentInfo contentInfo;
										ASN1 asn3 = contentInfo.GetASN1();
										ASN1 asn4 = asn3.Add(asn3);
									}
									long num16 = 0L;
									int num17 = 31;
									if (num16 == 0L)
									{
										if (num17 != 0)
										{
											goto IL_019F;
										}
										ASN1 asn6;
										ASN1 asn5 = asn6.Add(asn6);
										long num18 = 0L;
										int num19 = 35;
										if (num18 == 0L)
										{
											if (num19 != 0)
											{
												goto IL_019F;
											}
											PKCS7.ContentInfo contentInfo2;
											ASN1 asn7 = contentInfo2.GetASN1();
											ASN1 asn8 = asn7.Add(asn7);
											if ("1.2.840.113549.1.7.1" != null)
											{
												RandomNumberGenerator randomNumberGenerator = RandomNumberGenerator.Create();
												ASN1 asn9;
												byte[] value3 = asn9.Value;
												ASN1 asn10 = ASN1Convert.FromOid("1.3.14.3.2.26");
											}
											ASN1 asn11;
											if (asn11 != null)
											{
												goto IL_019F;
											}
											goto IL_019F;
										}
									}
								}
							}
							throw new OutOfMemoryException();
						}
						throw new OutOfMemoryException();
					}
					IL_019F:
					long num20 = 0L;
					long num21 = 0L;
					if (num20 != 0L)
					{
						long value4 = num20.m_value;
						if (num20 != 0L)
						{
							throw new OutOfMemoryException();
						}
						long num22 = 0L;
						long num23;
						if (num23 != 0L)
						{
							long value5 = num23.m_value;
						}
						if (num22 != 0L)
						{
							throw new OutOfMemoryException();
						}
					}
					else
					{
						if (num21 != 0L)
						{
							throw new OutOfMemoryException();
						}
						long num23 = 0L;
						long num24;
						if (num24 != 0L)
						{
							long value6 = num24.m_value;
						}
						if (num23 != 0L)
						{
							throw new OutOfMemoryException();
						}
					}
					throw new OutOfMemoryException();
				}
				throw new OutOfMemoryException();
			}
			IL_020B:
			throw new OutOfMemoryException();
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00003AB8 File Offset: 0x00001CB8
		private PKCS7.ContentInfo EncryptedContentInfo(ASN1 safeBags, string algorithmOid)
		{
			/*
An exception occurred when decompiling this method (06000064)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Mono.Security.PKCS7/ContentInfo Mono.Security.X509.PKCS12::EncryptedContentInfo(Mono.Security.ASN1,System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0017:
	stloc:ASN1(var_3_22, call:ASN1(ASN1Convert::FromInt32, ldfld:int32(PKCS12::_iterations, ldloc:PKCS12(this))))
	stloc:ASN1(var_5_29, call:ASN1(ASN1Convert::FromOid, ldloc:string(algorithmOid)))
	stloc:int32(var_8_31, ldfld:int32(PKCS12::_iterations, ldloc:PKCS12(this)))
	stloc:ASN1(var_10_3D, call:ASN1(ASN1Convert::FromOid, ldstr:string("1.2.840.113549.1.7.1")))
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

		// Token: 0x06000065 RID: 101 RVA: 0x00003B04 File Offset: 0x00001D04
		public void AddCertificate(X509Certificate cert)
		{
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00003B14 File Offset: 0x00001D14
		public void AddCertificate(X509Certificate cert, IDictionary attributes)
		{
			if ("1.2.840.113549.1.12.10.1.3" != null)
			{
			}
			ASN1 asn;
			byte[] value = asn.Value;
			ASN1 asn2;
			byte[] value2 = asn2.Value;
			byte[] encodedcert = cert.m_encodedcert;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00003B54 File Offset: 0x00001D54
		public void RemoveCertificate(X509Certificate cert)
		{
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00003B64 File Offset: 0x00001D64
		public void RemoveCertificate(X509Certificate cert, IDictionary attrs)
		{
			ArrayList safeBags = this._safeBags;
			ArrayList safeBags2 = this._safeBags;
			if (safeBags2 != null)
			{
			}
			object[] items = safeBags2._items;
			int size = safeBags2._size;
			ASN1 asn;
			byte[] value = asn.Value;
			ASN1 asn2;
			byte[] value2 = asn2.Value;
			long num = 0L;
			if (attrs != null)
			{
				long num2 = 0L;
				ASN1 asn3;
				if (asn3.elist != null)
				{
				}
				ASN1 asn4 = asn3[(int)num2];
				long num3 = 0L;
				string text = ASN1Convert.ToOid(asn4[(int)num3]);
				if (num != 0L)
				{
				}
				return;
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00003C5C File Offset: 0x00001E5C
		private bool CompareAsymmetricAlgorithm(AsymmetricAlgorithm a1, AsymmetricAlgorithm a2)
		{
			bool flag;
			return flag;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00003C6C File Offset: 0x00001E6C
		public void AddPkcs8ShroudedKeyBag(AsymmetricAlgorithm aa)
		{
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00003C7C File Offset: 0x00001E7C
		public void AddPkcs8ShroudedKeyBag(AsymmetricAlgorithm aa, IDictionary attributes)
		{
			ArrayList safeBags = this._safeBags;
			ArrayList safeBags2 = this._safeBags;
			if (safeBags2 != null)
			{
			}
			object[] items = safeBags2._items;
			int size = safeBags2._size;
			ASN1 asn;
			byte[] value = asn.Value;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00003D18 File Offset: 0x00001F18
		public void RemovePkcs8ShroudedKeyBag(AsymmetricAlgorithm aa)
		{
			ArrayList safeBags = this._safeBags;
			ArrayList safeBags2 = this._safeBags;
			if (safeBags2 != null)
			{
			}
			object[] items = safeBags2._items;
			int size = safeBags2._size;
			ASN1 asn;
			byte[] value = asn.Value;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00003D98 File Offset: 0x00001F98
		public void AddKeyBag(AsymmetricAlgorithm aa)
		{
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00003DA8 File Offset: 0x00001FA8
		public void AddKeyBag(AsymmetricAlgorithm aa, IDictionary attributes)
		{
			ArrayList safeBags = this._safeBags;
			ArrayList safeBags2 = this._safeBags;
			if (safeBags2 != null)
			{
			}
			object[] items = safeBags2._items;
			int size = safeBags2._size;
			ASN1 asn;
			byte[] value = asn.Value;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00003E28 File Offset: 0x00002028
		public void RemoveKeyBag(AsymmetricAlgorithm aa)
		{
			ArrayList safeBags = this._safeBags;
			ArrayList safeBags2 = this._safeBags;
			if (safeBags2 != null)
			{
			}
			object[] items = safeBags2._items;
			int size = safeBags2._size;
			ASN1 asn;
			byte[] value = asn.Value;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00003E98 File Offset: 0x00002098
		public void AddSecretBag(byte[] secret)
		{
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00003EA8 File Offset: 0x000020A8
		public void AddSecretBag(byte[] secret, IDictionary attributes)
		{
			ArrayList safeBags = this._safeBags;
			ArrayList safeBags2 = this._safeBags;
			if (safeBags2 != null)
			{
			}
			object[] items = safeBags2._items;
			int size = safeBags2._size;
			ASN1 asn;
			byte[] value = asn.Value;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00003F08 File Offset: 0x00002108
		public void RemoveSecretBag(byte[] secret)
		{
			ArrayList safeBags = this._safeBags;
			ArrayList safeBags2 = this._safeBags;
			if (safeBags2 != null)
			{
			}
			object[] items = safeBags2._items;
			int size = safeBags2._size;
			ASN1 asn;
			byte[] value = asn.Value;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00003F60 File Offset: 0x00002160
		public AsymmetricAlgorithm GetAsymmetricAlgorithm(IDictionary attrs)
		{
			ArrayList safeBags = this._safeBags;
			if (safeBags != null)
			{
			}
			object[] items = safeBags._items;
			long num = 0L;
			ASN1 asn;
			if (asn.elist != null)
			{
			}
			ASN1 asn2 = asn[(int)num];
			long num2 = 0L;
			string text = ASN1Convert.ToOid(asn2[(int)num2]);
			if (attrs != null)
			{
				int num3 = 1;
				ASN1 asn3 = asn2[num3];
				if (asn3.elist != null)
				{
				}
				long num4 = 0L;
				if (asn3.elist != null)
				{
				}
				ASN1 asn4 = asn3[(int)num4];
				if (attrs == null || attrs == null)
				{
				}
				byte[] value = asn4.Value;
				if (asn3.elist != null)
				{
				}
			}
			if (asn.elist != null)
			{
			}
			ASN1 asn5;
			byte[] value2 = asn5.Value;
			byte[] array;
			RSA rsa = PKCS8.PrivateKeyInfo.DecodeRSA(array);
			long num5 = 0L;
			if (rsa != null)
			{
			}
			if (num5 == 0L)
			{
				int keySizeValue = rsa.KeySizeValue;
				byte[] array2;
				RSA rsa2 = PKCS8.PrivateKeyInfo.DecodeRSA(array2);
				long num6 = 0L;
				long num7 = 0L;
				Array.Clear(array2, (int)num7, (int)num6);
				throw new InvalidCastException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00004084 File Offset: 0x00002284
		public byte[] GetSecret(IDictionary attrs)
		{
			ArrayList safeBags = this._safeBags;
			bool flag;
			while (!flag)
			{
			}
			long num = 0L;
			ASN1 asn;
			if (asn.elist != null)
			{
			}
			ASN1 asn2 = asn[(int)num];
			long num2 = 0L;
			string text = ASN1Convert.ToOid(asn2[(int)num2]);
			if (text != null)
			{
				int num3 = 1;
				ASN1 asn3 = asn2[num3];
				if (asn3.elist != null)
				{
				}
				long num4 = 0L;
				if (asn3.elist != null)
				{
				}
				ASN1 asn4 = asn3[(int)num4];
				if (text == null || text == null)
				{
				}
				return asn4.Value;
			}
			if (asn.elist != null)
			{
			}
			ASN1 asn5;
			return asn5.Value;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00004180 File Offset: 0x00002380
		public X509Certificate GetCertificate(IDictionary attrs)
		{
			ArrayList safeBags = this._safeBags;
			bool flag;
			while (!flag)
			{
			}
			long num = 0L;
			ASN1 asn;
			if (asn.elist != null)
			{
			}
			ASN1 asn2 = asn[(int)num];
			long num2 = 0L;
			string text = ASN1Convert.ToOid(asn2[(int)num2]);
			if (text != null)
			{
				int num3 = 1;
				ASN1 asn3 = asn2[num3];
				if (asn3.elist != null)
				{
				}
				long num4 = 0L;
				if (asn3.elist != null)
				{
				}
				ASN1 asn4 = asn3[(int)num4];
				if (text == null || text == null)
				{
				}
				byte[] value = asn4.Value;
				if (asn3.elist != null)
				{
				}
			}
			if (asn.elist != null)
			{
			}
			ASN1 asn5;
			byte[] value2 = asn5.Value;
			ASN1 asn6;
			byte[] value3 = asn6.Value;
			if (!false)
			{
				throw new InvalidCastException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00004270 File Offset: 0x00002470
		public IDictionary GetAttributes(AsymmetricAlgorithm aa)
		{
			ASN1 asn;
			byte[] value = asn.Value;
			byte[] array;
			RSA rsa = PKCS8.PrivateKeyInfo.DecodeRSA(array);
			byte[] array2;
			RSA rsa2 = PKCS8.PrivateKeyInfo.DecodeRSA(array2);
			long num = 0L;
			long num2 = 0L;
			byte[] array3;
			Array.Clear(array3, (int)num2, (int)num);
			long num3 = 0L;
			long num4 = 0L;
			long num5 = 0L;
			Array.Clear(array2, (int)num5, (int)num3);
			long num6 = 0L;
			Array.Clear(array3, (int)num6, (int)num3);
			while (num4 == 0L)
			{
			}
			bool flag;
			while (!flag)
			{
			}
			long num7 = 0L;
			ASN1 asn2;
			if (asn2.elist != null)
			{
			}
			ASN1 asn3 = asn2[(int)num7];
			long num8 = 0L;
			string text = ASN1Convert.ToOid(asn3[(int)num8]);
			int num9 = 1;
			ASN1 asn4 = asn3[num9];
			long num10 = 0L;
			if (asn4.elist != null)
			{
			}
			byte[] value2 = asn4[(int)num10].Value;
			if (!false)
			{
				throw new InvalidCastException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00004344 File Offset: 0x00002544
		public IDictionary GetAttributes(X509Certificate cert)
		{
			ArrayList safeBags = this._safeBags;
			if (safeBags != null)
			{
			}
			object[] items = safeBags._items;
			int size = safeBags._size;
			ASN1 asn;
			byte[] value = asn.Value;
			ASN1 asn2;
			byte[] value2 = asn2.Value;
			byte[] encodedcert = cert.m_encodedcert;
			long num = 0L;
			long num2 = 0L;
			ASN1 asn3;
			if (asn3.elist != null)
			{
			}
			ASN1 asn4 = asn3[(int)num2];
			long num3 = 0L;
			string text = ASN1Convert.ToOid(asn4[(int)num3]);
			int num4 = 1;
			ASN1 asn5 = asn4[num4];
			long num5 = 0L;
			if (asn5.elist != null)
			{
			}
			byte[] value3 = asn5[(int)num5].Value;
			if (num != 0L)
			{
			}
			long num6 = 0L;
			if (safeBags == null || num != 0L)
			{
			}
			if (num6 == 0L)
			{
				throw new InvalidCastException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00004414 File Offset: 0x00002614
		public void SaveToFile(string filename)
		{
			if (filename != null)
			{
				FileStream fileStream = File.Create(filename);
				byte[] bytes = this.GetBytes();
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00004454 File Offset: 0x00002654
		public object Clone()
		{
			/*
An exception occurred when decompiling this method (06000079)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object Mono.Security.X509.PKCS12::Clone()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0021:
	stloc:int32(var_5_27, ldfld:int32(PKCS12::_iterations, ldloc:PKCS12(this)))
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

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600007A RID: 122 RVA: 0x0000448C File Offset: 0x0000268C
		// (set) Token: 0x0600007B RID: 123 RVA: 0x000044A0 File Offset: 0x000026A0
		public static int MaximumPasswordLength
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
			set
			{
				if (!true)
				{
				}
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000044B8 File Offset: 0x000026B8
		private static byte[] LoadFile(string filename)
		{
			if (!false)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000044F0 File Offset: 0x000026F0
		public static PKCS12 LoadFromFile(string filename)
		{
			/*
An exception occurred when decompiling this method (0600007D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Mono.Security.X509.PKCS12 Mono.Security.X509.PKCS12::LoadFromFile(System.String)

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

		// Token: 0x0600007E RID: 126 RVA: 0x00004500 File Offset: 0x00002700
		public static PKCS12 LoadFromFile(string filename, string password)
		{
			/*
An exception occurred when decompiling this method (0600007E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Mono.Security.X509.PKCS12 Mono.Security.X509.PKCS12::LoadFromFile(System.String,System.String)

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

		// Token: 0x0600007F RID: 127 RVA: 0x00004510 File Offset: 0x00002710
		// Note: this type is marked as 'beforefieldinit'.
		static PKCS12()
		{
		}

		// Token: 0x04000023 RID: 35
		public const string pbeWithSHAAnd128BitRC4 = "1.2.840.113549.1.12.1.1";

		// Token: 0x04000024 RID: 36
		public const string pbeWithSHAAnd40BitRC4 = "1.2.840.113549.1.12.1.2";

		// Token: 0x04000025 RID: 37
		public const string pbeWithSHAAnd3KeyTripleDESCBC = "1.2.840.113549.1.12.1.3";

		// Token: 0x04000026 RID: 38
		public const string pbeWithSHAAnd2KeyTripleDESCBC = "1.2.840.113549.1.12.1.4";

		// Token: 0x04000027 RID: 39
		public const string pbeWithSHAAnd128BitRC2CBC = "1.2.840.113549.1.12.1.5";

		// Token: 0x04000028 RID: 40
		public const string pbeWithSHAAnd40BitRC2CBC = "1.2.840.113549.1.12.1.6";

		// Token: 0x04000029 RID: 41
		public const string keyBag = "1.2.840.113549.1.12.10.1.1";

		// Token: 0x0400002A RID: 42
		public const string pkcs8ShroudedKeyBag = "1.2.840.113549.1.12.10.1.2";

		// Token: 0x0400002B RID: 43
		public const string certBag = "1.2.840.113549.1.12.10.1.3";

		// Token: 0x0400002C RID: 44
		public const string crlBag = "1.2.840.113549.1.12.10.1.4";

		// Token: 0x0400002D RID: 45
		public const string secretBag = "1.2.840.113549.1.12.10.1.5";

		// Token: 0x0400002E RID: 46
		public const string safeContentsBag = "1.2.840.113549.1.12.10.1.6";

		// Token: 0x0400002F RID: 47
		public const string x509Certificate = "1.2.840.113549.1.9.22.1";

		// Token: 0x04000030 RID: 48
		public const string sdsiCertificate = "1.2.840.113549.1.9.22.2";

		// Token: 0x04000031 RID: 49
		public const string x509Crl = "1.2.840.113549.1.9.23.1";

		// Token: 0x04000032 RID: 50
		private const int recommendedIterationCount = 2000;

		// Token: 0x04000033 RID: 51
		private byte[] _password;

		// Token: 0x04000034 RID: 52
		private ArrayList _keyBags;

		// Token: 0x04000035 RID: 53
		private ArrayList _secretBags;

		// Token: 0x04000036 RID: 54
		private X509CertificateCollection _certs;

		// Token: 0x04000037 RID: 55
		private bool _keyBagsChanged;

		// Token: 0x04000038 RID: 56
		private bool _secretBagsChanged;

		// Token: 0x04000039 RID: 57
		private bool _certsChanged;

		// Token: 0x0400003A RID: 58
		private int _iterations;

		// Token: 0x0400003B RID: 59
		private ArrayList _safeBags;

		// Token: 0x0400003C RID: 60
		private RandomNumberGenerator _rng;

		// Token: 0x0400003D RID: 61
		public const int CryptoApiPasswordLimit = 32;

		// Token: 0x0400003E RID: 62
		private static int password_max_length;

		// Token: 0x0200000F RID: 15
		public class DeriveBytes
		{
			// Token: 0x06000080 RID: 128 RVA: 0x00004520 File Offset: 0x00002720
			public DeriveBytes()
			{
			}

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x06000081 RID: 129 RVA: 0x00004534 File Offset: 0x00002734
			// (set) Token: 0x06000082 RID: 130 RVA: 0x00004548 File Offset: 0x00002748
			public string HashName
			{
				get
				{
					return this._hashName;
				}
				set
				{
					this._hashName = value;
				}
			}

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x06000083 RID: 131 RVA: 0x0000455C File Offset: 0x0000275C
			// (set) Token: 0x06000084 RID: 132 RVA: 0x00004570 File Offset: 0x00002770
			public int IterationCount
			{
				get
				{
					return this._iterations;
				}
				set
				{
					this._iterations = value;
				}
			}

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x06000085 RID: 133 RVA: 0x00004584 File Offset: 0x00002784
			// (set) Token: 0x06000086 RID: 134 RVA: 0x000045A4 File Offset: 0x000027A4
			public byte[] Password
			{
				get
				{
					byte[] password = this._password;
					object obj;
					if (obj == null || obj != null)
					{
					}
					throw new InvalidCastException();
				}
				set
				{
					if (value != null)
					{
						object obj;
						if (obj != null)
						{
							if (obj == null)
							{
								throw new InvalidCastException();
							}
							this._password = obj;
							if (obj == null)
							{
								throw new InvalidCastException();
							}
						}
						return;
					}
				}
			}

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x06000087 RID: 135 RVA: 0x000045D4 File Offset: 0x000027D4
			// (set) Token: 0x06000088 RID: 136 RVA: 0x000045F4 File Offset: 0x000027F4
			public byte[] Salt
			{
				get
				{
					byte[] salt = this._salt;
					object obj;
					if (obj == null || obj != null)
					{
					}
					throw new InvalidCastException();
				}
				set
				{
					object obj;
					if (value != null && obj != null)
					{
						if (obj == null)
						{
							throw new InvalidCastException();
						}
						this._salt = obj;
						if (obj == null)
						{
							throw new InvalidCastException();
						}
					}
				}
			}

			// Token: 0x06000089 RID: 137 RVA: 0x00004620 File Offset: 0x00002820
			private void Adjust(byte[] a, int aOff, byte[] b)
			{
			}

			// Token: 0x0600008A RID: 138 RVA: 0x00004630 File Offset: 0x00002830
			private byte[] Derive(byte[] diversifier, int n)
			{
				int num = 1;
				string hashName = this._hashName;
				if (num == 0)
				{
				}
				HashAlgorithm hashAlgorithm = PKCS1.CreateFromName(hashName);
				byte[] salt = this._salt;
				if (salt != null && salt != null)
				{
					if (salt != null)
					{
						byte[] salt2 = this._salt;
					}
				}
				byte[] password = this._password;
				if (password != null && password != null)
				{
					if (password != null)
					{
						byte[] password2 = this._password;
					}
				}
				long num2 = 0L;
				long num3 = 0L;
				long num4 = 0L;
				int num5 = hashAlgorithm.TransformBlock(diversifier, (int)num3, (int)num2, diversifier, (int)num4);
				int iterations = this._iterations;
				byte[] hashValue = hashAlgorithm.HashValue;
				if (this._iterations != 0)
				{
				}
				byte[] array;
				return array;
			}

			// Token: 0x0600008B RID: 139 RVA: 0x000046D4 File Offset: 0x000028D4
			public byte[] DeriveKey(int size)
			{
				if (!true)
				{
				}
				byte[] array;
				return array;
			}

			// Token: 0x0600008C RID: 140 RVA: 0x000046E8 File Offset: 0x000028E8
			public byte[] DeriveIV(int size)
			{
				if (!true)
				{
				}
				byte[] array;
				return array;
			}

			// Token: 0x0600008D RID: 141 RVA: 0x000046FC File Offset: 0x000028FC
			public byte[] DeriveMAC(int size)
			{
				if (!true)
				{
				}
				byte[] array;
				return array;
			}

			// Token: 0x0600008E RID: 142 RVA: 0x00004710 File Offset: 0x00002910
			// Note: this type is marked as 'beforefieldinit'.
			static DeriveBytes()
			{
			}

			// Token: 0x0400003F RID: 63
			private static byte[] keyDiversifier;

			// Token: 0x04000040 RID: 64
			private static byte[] ivDiversifier;

			// Token: 0x04000041 RID: 65
			private static byte[] macDiversifier;

			// Token: 0x04000042 RID: 66
			private string _hashName;

			// Token: 0x04000043 RID: 67
			private int _iterations;

			// Token: 0x04000044 RID: 68
			private byte[] _password;

			// Token: 0x04000045 RID: 69
			private byte[] _salt;

			// Token: 0x02000010 RID: 16
			public enum Purpose
			{
				// Token: 0x04000047 RID: 71
				Key,
				// Token: 0x04000048 RID: 72
				IV,
				// Token: 0x04000049 RID: 73
				MAC
			}
		}
	}
}
