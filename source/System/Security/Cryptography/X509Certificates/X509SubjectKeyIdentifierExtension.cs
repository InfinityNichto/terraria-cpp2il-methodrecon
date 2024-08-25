using System;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x0200011D RID: 285
	public sealed class X509SubjectKeyIdentifierExtension : X509Extension
	{
		// Token: 0x060006BF RID: 1727 RVA: 0x00018BE0 File Offset: 0x00016DE0
		public X509SubjectKeyIdentifierExtension()
		{
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x00018BF4 File Offset: 0x00016DF4
		public X509SubjectKeyIdentifierExtension(AsnEncodedData encodedSubjectKeyIdentifier, bool critical)
		{
			byte[] raw = encodedSubjectKeyIdentifier._raw;
			this._critical = true;
			this._raw = raw;
			AsnDecodeStatus asnDecodeStatus = this.Decode(raw);
			this._status = asnDecodeStatus;
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x00018C2C File Offset: 0x00016E2C
		public X509SubjectKeyIdentifierExtension(byte[] subjectKeyIdentifier, bool critical)
		{
			do
			{
				base..ctor();
				if (subjectKeyIdentifier == null)
				{
					return;
				}
			}
			while (!true);
			object obj;
			if (obj != null)
			{
				if (obj != null)
				{
					this._subjectKeyIdentifier = obj;
					if (obj != null)
					{
						goto IL_0022;
					}
				}
				throw new InvalidCastException();
			}
			IL_0022:
			byte[] array = this.Encode();
			base.RawData = array;
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x00018C6C File Offset: 0x00016E6C
		public X509SubjectKeyIdentifierExtension(string subjectKeyIdentifier, bool critical)
		{
			if (subjectKeyIdentifier != null)
			{
				int stringLength = subjectKeyIdentifier._stringLength;
				byte[] array = X509SubjectKeyIdentifierExtension.FromHex(subjectKeyIdentifier);
				this._subjectKeyIdentifier = array;
				byte[] array2 = this.Encode();
				base.RawData = array2;
				return;
			}
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x00018CA8 File Offset: 0x00016EA8
		public X509SubjectKeyIdentifierExtension(PublicKey key, bool critical)
		{
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x00018CB8 File Offset: 0x00016EB8
		public X509SubjectKeyIdentifierExtension(PublicKey key, X509SubjectKeyIdentifierHashAlgorithm algorithm, bool critical)
		{
			do
			{
				base..ctor();
				if (key == null)
				{
					return;
				}
				byte[] raw = key._keyValue._raw;
			}
			while (algorithm != X509SubjectKeyIdentifierHashAlgorithm.Sha1);
			SHA1 sha = SHA1.Create();
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060006C5 RID: 1733 RVA: 0x00018D5C File Offset: 0x00016F5C
		public string SubjectKeyIdentifier
		{
			get
			{
				AsnDecodeStatus status = this._status;
				byte[] subjectKeyIdentifier = this._subjectKeyIdentifier;
				if (subjectKeyIdentifier != null)
				{
					string text = CryptoConvert.ToHex(subjectKeyIdentifier);
					this._ski = text;
					return text;
				}
				return this._ski;
			}
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x00018D90 File Offset: 0x00016F90
		public override void CopyFrom(AsnEncodedData asnEncodedData)
		{
			while (asnEncodedData == null)
			{
			}
			if (asnEncodedData._oid != null)
			{
				return;
			}
			byte[] raw = asnEncodedData._raw;
			base.RawData = raw;
			byte[] raw2 = this._raw;
			this._critical = "2.5.29.14" != null;
			AsnDecodeStatus asnDecodeStatus = this.Decode(raw2);
			this._status = asnDecodeStatus;
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x00018DE4 File Offset: 0x00016FE4
		internal static byte FromHexChar(char c)
		{
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x00018DF8 File Offset: 0x00016FF8
		internal static byte FromHexChars(char c1, char c2)
		{
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x00018E18 File Offset: 0x00017018
		internal static byte[] FromHex(string hex)
		{
			char c;
			char c2;
			return X509SubjectKeyIdentifierExtension.FromHexChars(c, c2);
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x00018E30 File Offset: 0x00017030
		internal AsnDecodeStatus Decode(byte[] extension)
		{
			int num = 1;
			if (extension != null && num != 0)
			{
				byte[] array;
				this._subjectKeyIdentifier = array;
				return;
			}
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x00018E60 File Offset: 0x00017060
		internal byte[] Encode()
		{
			/*
An exception occurred when decompiling this method (060006CB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] System.Security.Cryptography.X509Certificates.X509SubjectKeyIdentifierExtension::Encode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8[](var_0_06, ldfld:uint8[](X509SubjectKeyIdentifierExtension::_subjectKeyIdentifier, ldloc:X509SubjectKeyIdentifierExtension(this)))
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

		// Token: 0x060006CC RID: 1740 RVA: 0x00018E74 File Offset: 0x00017074
		internal override string ToString(bool multiLine)
		{
			AsnDecodeStatus status = this._status;
			return "Unknown Key Usage ({0})";
		}

		// Token: 0x04000539 RID: 1337
		internal const string oid = "2.5.29.14";

		// Token: 0x0400053A RID: 1338
		internal const string friendlyName = "Subject Key Identifier";

		// Token: 0x0400053B RID: 1339
		private byte[] _subjectKeyIdentifier;

		// Token: 0x0400053C RID: 1340
		private string _ski;

		// Token: 0x0400053D RID: 1341
		private AsnDecodeStatus _status;
	}
}
