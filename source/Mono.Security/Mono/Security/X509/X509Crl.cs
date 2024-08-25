using System;
using System.Collections;
using System.Security.Cryptography;
using Mono.Security.Cryptography;

namespace Mono.Security.X509
{
	// Token: 0x02000013 RID: 19
	public class X509Crl
	{
		// Token: 0x060000A6 RID: 166 RVA: 0x00004D20 File Offset: 0x00002F20
		public X509Crl(byte[] crl)
		{
			do
			{
				base..ctor();
			}
			while (crl == null);
			object obj;
			if (obj != null)
			{
				if (obj != null)
				{
					this.encoded = obj;
					if (obj != null)
					{
						return;
					}
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00004D4C File Offset: 0x00002F4C
		private void Parse(byte[] crl)
		{
			byte[] array = this.encoded;
			ASN1 asn;
			byte nTag = asn.m_nTag;
			if (asn.elist != null)
			{
				long num = 0L;
				byte nTag2 = asn[(int)num].m_nTag;
				long num2 = 0L;
				byte[] value = asn[(int)num2].Value;
				return;
			}
			string text = "Input data cannot be coded as a valid CRL." + " [Non-matching signature algorithms in CRL]";
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00004EF4 File Offset: 0x000030F4
		public ArrayList Entries
		{
			get
			{
				return ArrayList.ReadOnly(this.entries);
			}
		}

		// Token: 0x17000025 RID: 37
		public X509Crl.X509CrlEntry this[int index]
		{
			get
			{
				if (this.entries != null)
				{
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x17000026 RID: 38
		public X509Crl.X509CrlEntry this[byte[] serialNumber]
		{
			get
			{
				return this.GetCrlEntry(serialNumber);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000AB RID: 171 RVA: 0x00004F3C File Offset: 0x0000313C
		public X509ExtensionCollection Extensions
		{
			get
			{
				return this.extensions;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00004F50 File Offset: 0x00003150
		public byte[] Hash
		{
			get
			{
				while (this.hash_value != null)
				{
				}
				byte[] array = this.encoded;
				HashAlgorithm hashAlgorithm = PKCS1.CreateFromOid(this.signatureOID);
				long num = 0L;
				byte[] array2;
				this.hash_value = array2;
				if (hashAlgorithm != null)
				{
				}
				if (num == 0L)
				{
					return this.hash_value;
				}
				throw new OutOfMemoryException();
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00004FB4 File Offset: 0x000031B4
		public string IssuerName
		{
			get
			{
				return this.issuer;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00004FC8 File Offset: 0x000031C8
		public DateTime NextUpdate
		{
			get
			{
				DateTime dateTime = this.nextUpdate;
				DateTime dateTime2;
				return dateTime2;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00004FE0 File Offset: 0x000031E0
		public DateTime ThisUpdate
		{
			get
			{
				DateTime dateTime = this.thisUpdate;
				DateTime dateTime2;
				return dateTime2;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00004FF8 File Offset: 0x000031F8
		public string SignatureAlgorithm
		{
			get
			{
				return this.signatureOID;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x0000500C File Offset: 0x0000320C
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

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x0000502C File Offset: 0x0000322C
		public byte[] RawData
		{
			get
			{
				byte[] array = this.encoded;
				object obj;
				if (obj == null || obj != null)
				{
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x0000504C File Offset: 0x0000324C
		public byte Version
		{
			get
			{
				return this.version;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00005060 File Offset: 0x00003260
		public bool IsCurrent
		{
			get
			{
				if (!true)
				{
				}
				DateTime now = DateTime.Now;
				return this.WasCurrent(now);
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00005080 File Offset: 0x00003280
		public bool WasCurrent(DateTime instant)
		{
			DateTime dateTime = this.nextUpdate;
			if (!true)
			{
			}
			bool flag = dateTime == instant;
			DateTime dateTime2 = this.thisUpdate;
			return instant >= dateTime2;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000050BC File Offset: 0x000032BC
		public byte[] GetBytes()
		{
			byte[] array = this.encoded;
			object obj;
			if (obj == null || obj != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000050DC File Offset: 0x000032DC
		private bool Compare(byte[] array1, byte[] array2)
		{
			while (array1 == null || array2 == null)
			{
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000050F4 File Offset: 0x000032F4
		public X509Crl.X509CrlEntry GetCrlEntry(X509Certificate x509)
		{
			while (x509 == null)
			{
			}
			X509Crl.X509CrlEntry x509CrlEntry;
			return x509CrlEntry;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00005108 File Offset: 0x00003308
		public X509Crl.X509CrlEntry GetCrlEntry(byte[] serialNumber)
		{
			while (serialNumber == null)
			{
			}
			ArrayList arrayList = this.entries;
			if (this.entries != null)
			{
			}
			ArrayList arrayList2 = this.entries;
			throw new InvalidCastException();
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000513C File Offset: 0x0000333C
		public bool VerifySignature(X509Certificate x509)
		{
			while (x509 == null)
			{
			}
			int num = x509.version;
			if (x509.extensions["2.5.29.19"] != null)
			{
			}
			long num2 = 0L;
			if (x509.extensions["2.5.29.15"] == null || num2 != 0L)
			{
				string text = this.issuer;
			}
			bool flag = this.signatureOID == "1.2.840.10040.4.3";
			DSA dsa = x509.DSA;
			return this.VerifySignature(dsa);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000051AC File Offset: 0x000033AC
		internal bool VerifySignature(DSA dsa)
		{
			/*
An exception occurred when decompiling this method (060000BB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Mono.Security.X509.X509Crl::VerifySignature(System.Security.Cryptography.DSA)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_10, call:bool(string::op_Inequality, ldfld:string(X509Crl::signatureOID, ldloc:X509Crl(this)), ldstr:string("1.2.840.10040.4.3")))
	stloc:uint8[](var_1_17, ldfld:uint8[](X509Crl::signature, ldloc:X509Crl(this)))
	stloc:uint8[](var_4_20, callgetter:uint8[](ASN1::get_Value, ldloc:ASN1(var_3)))
	stloc:uint8[](var_7_2C, callgetter:uint8[](ASN1::get_Value, ldloc:ASN1(var_6)))
	stloc:int32(var_8_30, ldc.i4:int32(40))
	stloc:int32(var_9_3A, call:int32(Math::Max, ldc.i4:int32(0), ldloc:int32(var_8_30)))
	stloc:int32(var_10_44, call:int32(Math::Max, ldc.i4:int32(0), ldloc:int32(var_8_30)))
	stloc:int32(var_11_4E, call:int32(Math::Max, ldc.i4:int32(0), ldloc:int32(var_9_3A)))
	stloc:int32(var_12_59, call:int32(Math::Max, ldc.i4:int32(20), ldloc:int32(var_9_3A)))
	stloc:uint8[](var_13_61, callgetter:uint8[](X509Crl::get_Hash, ldloc:X509Crl(this)))
	stloc:string(var_15_6C, ldfld:string(X509Crl::signatureOID, ldloc:X509Crl(this)))
	stloc:string(var_16_7A, call:string(string::Concat, ldstr:string("Unsupported hash algorithm: "), ldloc:string(var_15_6C)))
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

		// Token: 0x060000BC RID: 188 RVA: 0x00005234 File Offset: 0x00003434
		internal bool VerifySignature(RSA rsa)
		{
			/*
An exception occurred when decompiling this method (060000BC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Mono.Security.X509.X509Crl::VerifySignature(System.Security.Cryptography.RSA)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000A:
	stloc:string(var_1_11, call:string(PKCS1::HashNameFromOid, ldloc:string(var_0_06), ldc.i4:bool(1)))
	stloc:uint8[](var_2_18, callgetter:uint8[](X509Crl::get_Hash, ldloc:X509Crl(this)))
	stloc:uint8[](var_3_1F, ldfld:uint8[](X509Crl::signature, ldloc:X509Crl(this)))
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

		// Token: 0x060000BD RID: 189 RVA: 0x00005260 File Offset: 0x00003460
		public bool VerifySignature(AsymmetricAlgorithm aa)
		{
			while (aa == null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00005274 File Offset: 0x00003474
		public static X509Crl CreateFromFile(string filename)
		{
			if (!false)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0400005C RID: 92
		private string issuer;

		// Token: 0x0400005D RID: 93
		private byte version;

		// Token: 0x0400005E RID: 94
		private DateTime thisUpdate;

		// Token: 0x0400005F RID: 95
		private DateTime nextUpdate;

		// Token: 0x04000060 RID: 96
		private ArrayList entries;

		// Token: 0x04000061 RID: 97
		private string signatureOID;

		// Token: 0x04000062 RID: 98
		private byte[] signature;

		// Token: 0x04000063 RID: 99
		private X509ExtensionCollection extensions;

		// Token: 0x04000064 RID: 100
		private byte[] encoded;

		// Token: 0x04000065 RID: 101
		private byte[] hash_value;

		// Token: 0x02000014 RID: 20
		public class X509CrlEntry
		{
			// Token: 0x060000BF RID: 191 RVA: 0x00005298 File Offset: 0x00003498
			internal X509CrlEntry(byte[] serialNumber, DateTime revocationDate, X509ExtensionCollection extensions)
			{
				this.sn = serialNumber;
				this.revocationDate = revocationDate;
				if (extensions == null)
				{
				}
			}

			// Token: 0x060000C0 RID: 192 RVA: 0x000052BC File Offset: 0x000034BC
			internal X509CrlEntry(ASN1 entry)
			{
				long num = 0L;
				byte[] value = entry[(int)num].Value;
				this.sn = value;
				DateTime dateTime = ASN1Convert.ToDateTime(entry[1]);
				this.revocationDate = dateTime;
				ASN1 asn = entry[2];
			}

			// Token: 0x17000031 RID: 49
			// (get) Token: 0x060000C1 RID: 193 RVA: 0x00005304 File Offset: 0x00003504
			public byte[] SerialNumber
			{
				get
				{
					byte[] array = this.sn;
					object obj;
					if (obj == null || obj != null)
					{
					}
					throw new InvalidCastException();
				}
			}

			// Token: 0x17000032 RID: 50
			// (get) Token: 0x060000C2 RID: 194 RVA: 0x00005324 File Offset: 0x00003524
			public DateTime RevocationDate
			{
				get
				{
					DateTime dateTime = this.revocationDate;
					DateTime dateTime2;
					return dateTime2;
				}
			}

			// Token: 0x17000033 RID: 51
			// (get) Token: 0x060000C3 RID: 195 RVA: 0x0000533C File Offset: 0x0000353C
			public X509ExtensionCollection Extensions
			{
				get
				{
					return this.extensions;
				}
			}

			// Token: 0x060000C4 RID: 196 RVA: 0x00005350 File Offset: 0x00003550
			public byte[] GetBytes()
			{
				/*
An exception occurred when decompiling this method (060000C4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] Mono.Security.X509.X509Crl/X509CrlEntry::GetBytes()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8[](var_0_06, ldfld:uint8[](X509CrlEntry::sn, ldloc:X509CrlEntry(this)))
	stloc:ASN1(var_2_12, call:ASN1(ASN1Convert::FromDateTime, ldfld:DateTime(X509CrlEntry::revocationDate, ldloc:X509CrlEntry(this))))
	stloc:int32(var_4_1E, callgetter:int32(CollectionBase::get_Count, ldfld:X509ExtensionCollection[exp:CollectionBase](X509CrlEntry::extensions, ldloc:X509CrlEntry(this))))
	stloc:uint8[](var_5_2B, call:uint8[](X509ExtensionCollection::GetBytes, ldfld:X509ExtensionCollection(X509CrlEntry::extensions, ldloc:X509CrlEntry(this))))
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

			// Token: 0x04000066 RID: 102
			private byte[] sn;

			// Token: 0x04000067 RID: 103
			private DateTime revocationDate;

			// Token: 0x04000068 RID: 104
			private X509ExtensionCollection extensions;
		}
	}
}
