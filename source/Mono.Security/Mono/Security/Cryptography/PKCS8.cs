using System;
using System.Collections;
using System.Security.Cryptography;
using Cpp2IlInjected;

namespace Mono.Security.Cryptography
{
	// Token: 0x02000059 RID: 89
	public sealed class PKCS8
	{
		// Token: 0x0200005A RID: 90
		public class PrivateKeyInfo
		{
			// Token: 0x06000266 RID: 614 RVA: 0x000098A4 File Offset: 0x00007AA4
			public PrivateKeyInfo()
			{
			}

			// Token: 0x06000267 RID: 615 RVA: 0x000098B8 File Offset: 0x00007AB8
			public PrivateKeyInfo(byte[] data)
			{
				this.Decode(data);
			}

			// Token: 0x170000B1 RID: 177
			// (get) Token: 0x06000268 RID: 616 RVA: 0x000098CC File Offset: 0x00007ACC
			// (set) Token: 0x06000269 RID: 617 RVA: 0x000098E0 File Offset: 0x00007AE0
			public string Algorithm
			{
				get
				{
					return this._algorithm;
				}
				set
				{
					this._algorithm = value;
				}
			}

			// Token: 0x170000B2 RID: 178
			// (get) Token: 0x0600026A RID: 618 RVA: 0x000098F4 File Offset: 0x00007AF4
			// (set) Token: 0x0600026B RID: 619 RVA: 0x00009914 File Offset: 0x00007B14
			public byte[] PrivateKey
			{
				get
				{
					object obj;
					if (this._key == null || obj == null || obj != null)
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
								goto IL_001A;
							}
							this._key = obj;
							if (obj == null)
							{
								throw new InvalidCastException();
							}
						}
						return;
					}
					IL_001A:
					throw new InvalidCastException();
				}
			}

			// Token: 0x0600026C RID: 620 RVA: 0x00009940 File Offset: 0x00007B40
			private void Decode(byte[] data)
			{
				ASN1 asn;
				byte nTag = asn.m_nTag;
				byte[] value = asn.Value;
				this._version = (int)nTag;
				ASN1 asn2;
				byte nTag2 = asn2.m_nTag;
				long num = 0L;
				ASN1 asn3 = asn2[(int)num];
				byte nTag3 = asn3.m_nTag;
				string text = ASN1Convert.ToOid(asn3);
				this._algorithm = text;
				ASN1 asn4;
				byte[] value2 = asn4.Value;
				this._key = value2;
				ASN1 asn5;
				int count = asn5.Count;
				long num2 = 0L;
				ArrayList list = this._list;
				ASN1 asn6 = asn5[(int)num2];
				int count2 = asn5.Count;
			}

			// Token: 0x0600026D RID: 621 RVA: 0x000099E0 File Offset: 0x00007BE0
			public byte[] GetBytes()
			{
				ASN1 asn = ASN1Convert.FromOid(this._algorithm);
				int version = this._version;
				byte[] key = this._key;
				ArrayList list = this._list;
				ArrayList list2 = this._list;
				if (list2 != null)
				{
				}
				long num = 0L;
				int num2 = 5;
				if (list2 != null)
				{
				}
				if (num == 0L)
				{
					if (num2 == 0)
					{
					}
					throw new InvalidCastException();
				}
				throw new OutOfMemoryException();
			}

			// Token: 0x0600026E RID: 622 RVA: 0x00009A64 File Offset: 0x00007C64
			private static byte[] RemoveLeadingZero(byte[] bigInt)
			{
			}

			// Token: 0x0600026F RID: 623 RVA: 0x00009A74 File Offset: 0x00007C74
			private static byte[] Normalize(byte[] bigInt, int length)
			{
				byte[] array;
				return array;
			}

			// Token: 0x06000270 RID: 624 RVA: 0x00009A84 File Offset: 0x00007C84
			public static RSA DecodeRSA(byte[] keypair)
			{
				ASN1 asn;
				byte nTag = asn.m_nTag;
				ASN1 asn2;
				byte[] array = PKCS8.PrivateKeyInfo.RemoveLeadingZero(asn2.Value);
				ASN1 asn3;
				byte[] array2 = PKCS8.PrivateKeyInfo.Normalize(asn3.Value, 43151360);
				long num = 0L;
				ASN1 asn4;
				byte[] array3 = PKCS8.PrivateKeyInfo.Normalize(asn4.Value, (int)num);
				long num2 = 0L;
				ASN1 asn5;
				byte[] array4 = PKCS8.PrivateKeyInfo.Normalize(asn5.Value, (int)num2);
				ASN1 asn6;
				byte[] array5 = PKCS8.PrivateKeyInfo.RemoveLeadingZero(asn6.Value);
				long num3 = 0L;
				ASN1 asn7;
				byte[] array6 = PKCS8.PrivateKeyInfo.Normalize(asn7.Value, (int)num3);
				long num4 = 0L;
				ASN1 asn8;
				byte[] array7 = PKCS8.PrivateKeyInfo.Normalize(asn8.Value, (int)num4);
				long num5 = 0L;
				ASN1 asn9;
				byte[] array8 = PKCS8.PrivateKeyInfo.Normalize(asn9.Value, (int)num5);
				return RSA.Create();
			}

			// Token: 0x06000271 RID: 625 RVA: 0x00009B5C File Offset: 0x00007D5C
			public static byte[] Encode(RSA rsa)
			{
				/*
An exception occurred when decompiling this method (06000271)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] Mono.Security.Cryptography.PKCS8/PrivateKeyInfo::Encode(System.Security.Cryptography.RSA)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ASN1(var_10_09, call:ASN1(ASN1::Add, ldloc:ASN1(var_9), ldloc:ASN1(var_9)))
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

			// Token: 0x06000272 RID: 626 RVA: 0x00009B74 File Offset: 0x00007D74
			public static DSA DecodeDSA(byte[] privateKey, DSAParameters dsaParameters)
			{
				byte[] array2;
				byte[] array = PKCS8.PrivateKeyInfo.Normalize(array2, 20);
				DSA dsa = DSA.Create();
				byte value = privateKey.m_value;
				return dsa;
			}

			// Token: 0x06000273 RID: 627 RVA: 0x00002050 File Offset: 0x00000250
			public static byte[] Encode(DSA dsa)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06000274 RID: 628 RVA: 0x00009B9C File Offset: 0x00007D9C
			public static byte[] Encode(AsymmetricAlgorithm aa)
			{
				byte[] array;
				return array;
			}

			// Token: 0x04000263 RID: 611
			private int _version;

			// Token: 0x04000264 RID: 612
			private string _algorithm;

			// Token: 0x04000265 RID: 613
			private byte[] _key;

			// Token: 0x04000266 RID: 614
			private ArrayList _list;
		}

		// Token: 0x0200005B RID: 91
		public class EncryptedPrivateKeyInfo
		{
			// Token: 0x06000275 RID: 629 RVA: 0x00009BAC File Offset: 0x00007DAC
			public EncryptedPrivateKeyInfo()
			{
			}

			// Token: 0x06000276 RID: 630 RVA: 0x00009BC0 File Offset: 0x00007DC0
			public EncryptedPrivateKeyInfo(byte[] data)
			{
				this.Decode(data);
			}

			// Token: 0x170000B3 RID: 179
			// (get) Token: 0x06000277 RID: 631 RVA: 0x00009BDC File Offset: 0x00007DDC
			// (set) Token: 0x06000278 RID: 632 RVA: 0x00009BF0 File Offset: 0x00007DF0
			public string Algorithm
			{
				get
				{
					return this._algorithm;
				}
				set
				{
					this._algorithm = value;
				}
			}

			// Token: 0x170000B4 RID: 180
			// (get) Token: 0x06000279 RID: 633 RVA: 0x00009C04 File Offset: 0x00007E04
			// (set) Token: 0x0600027A RID: 634 RVA: 0x00009C24 File Offset: 0x00007E24
			public byte[] EncryptedData
			{
				get
				{
					object obj;
					if (this._data == null || obj == null || obj != null)
					{
					}
					throw new InvalidCastException();
				}
				set
				{
					long num;
					if (value != null)
					{
						object obj;
						if (obj != null && obj == null)
						{
							throw new InvalidCastException();
						}
					}
					else
					{
						num = 0L;
					}
					this._data = num;
				}
			}

			// Token: 0x170000B5 RID: 181
			// (get) Token: 0x0600027B RID: 635 RVA: 0x00009C4C File Offset: 0x00007E4C
			public byte[] Salt
			{
				get
				{
					if (this._salt == null)
					{
						RandomNumberGenerator randomNumberGenerator = RandomNumberGenerator.Create();
						byte[] salt = this._salt;
					}
					object obj;
					if (obj == null || obj != null)
					{
					}
					throw new InvalidCastException();
				}
			}

			// Token: 0x170000B6 RID: 182
			// (get) Token: 0x0600027C RID: 636 RVA: 0x00009C7C File Offset: 0x00007E7C
			// (set) Token: 0x0600027D RID: 637 RVA: 0x00009C90 File Offset: 0x00007E90
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

			// Token: 0x0600027E RID: 638 RVA: 0x00009CA4 File Offset: 0x00007EA4
			private void Decode(byte[] data)
			{
				ASN1 asn;
				byte nTag = asn.m_nTag;
				long num = 0L;
				ASN1 asn2 = asn[(int)num];
				byte nTag2 = asn2.m_nTag;
				string text = ASN1Convert.ToOid(asn2);
				this._algorithm = text;
				int count = asn.Count;
				byte nTag3 = asn[1].m_nTag;
				ASN1 asn3;
				byte nTag4 = asn3.m_nTag;
				byte[] value = asn3.Value;
				this._salt = value;
				ASN1 asn4;
				byte nTag5 = asn4.m_nTag;
				int num2 = ASN1Convert.ToInt32(asn4);
				this._iterations = num2;
				ASN1 asn5;
				byte nTag6 = asn5.m_nTag;
				byte[] value2 = asn5.Value;
				this._data = value2;
			}

			// Token: 0x0600027F RID: 639 RVA: 0x00009D4C File Offset: 0x00007F4C
			public byte[] GetBytes()
			{
				/*
An exception occurred when decompiling this method (0600027F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] Mono.Security.Cryptography.PKCS8/EncryptedPrivateKeyInfo::GetBytes()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_002F:
	stloc:uint8[](var_7_35, ldfld:uint8[](EncryptedPrivateKeyInfo::_data, ldloc:EncryptedPrivateKeyInfo(this)))
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

			// Token: 0x04000267 RID: 615
			private string _algorithm;

			// Token: 0x04000268 RID: 616
			private byte[] _salt;

			// Token: 0x04000269 RID: 617
			private int _iterations;

			// Token: 0x0400026A RID: 618
			private byte[] _data;
		}
	}
}
