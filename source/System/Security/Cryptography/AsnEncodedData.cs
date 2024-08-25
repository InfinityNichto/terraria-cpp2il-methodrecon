using System;
using System.Text;
using Mono.Security;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	// Token: 0x020000F5 RID: 245
	public class AsnEncodedData
	{
		// Token: 0x06000589 RID: 1417 RVA: 0x00015B58 File Offset: 0x00013D58
		protected AsnEncodedData()
		{
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x00015B6C File Offset: 0x00013D6C
		public AsnEncodedData(string oid, byte[] rawData)
		{
			this.RawData = rawData;
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x00015B88 File Offset: 0x00013D88
		public AsnEncodedData(Oid oid, byte[] rawData)
		{
			this.Oid = oid;
			this.RawData = rawData;
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x00015BAC File Offset: 0x00013DAC
		public AsnEncodedData(AsnEncodedData asnEncodedData)
		{
			do
			{
				base..ctor();
			}
			while (asnEncodedData == null);
			if (asnEncodedData._oid != null)
			{
			}
			byte[] raw = asnEncodedData._raw;
			this.RawData = raw;
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x0600058D RID: 1421 RVA: 0x00015BD8 File Offset: 0x00013DD8
		// (set) Token: 0x0600058E RID: 1422 RVA: 0x00015BEC File Offset: 0x00013DEC
		public Oid Oid
		{
			get
			{
				return this._oid;
			}
			set
			{
				if (value != null)
				{
					return;
				}
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x00015C00 File Offset: 0x00013E00
		// (set) Token: 0x06000590 RID: 1424 RVA: 0x00015C14 File Offset: 0x00013E14
		public byte[] RawData
		{
			get
			{
				return this._raw;
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
						this._raw = obj;
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

		// Token: 0x06000591 RID: 1425 RVA: 0x00015C40 File Offset: 0x00013E40
		public virtual void CopyFrom(AsnEncodedData asnEncodedData)
		{
			while (asnEncodedData == null)
			{
			}
			if (asnEncodedData._oid != null)
			{
				return;
			}
			byte[] raw = asnEncodedData._raw;
			this.RawData = raw;
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x00015C68 File Offset: 0x00013E68
		public virtual string Format(bool multiLine)
		{
			if (this._raw == null || this._oid != null)
			{
			}
			long num = 0L;
			return this.Default(num != 0L);
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x00015C90 File Offset: 0x00013E90
		internal virtual string ToString(bool multiLine)
		{
			string value = this._oid._value;
			bool flag = value == "2.5.29.19";
			string text;
			return text;
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x00015D1C File Offset: 0x00013F1C
		internal string Default(bool multiLine)
		{
			/*
An exception occurred when decompiling this method (06000594)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Security.Cryptography.AsnEncodedData::Default(System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8[](var_0_06, ldfld:uint8[](AsnEncodedData::_raw, ldloc:AsnEncodedData(this)))
	stloc:uint8[](var_3_0D, ldfld:uint8[](AsnEncodedData::_raw, ldloc:AsnEncodedData(this)))
	stloc:uint8[](var_5_14, ldfld:uint8[](AsnEncodedData::_raw, ldloc:AsnEncodedData(this)))
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

		// Token: 0x06000595 RID: 1429 RVA: 0x00015D40 File Offset: 0x00013F40
		internal string BasicConstraintsExtension(bool multiLine)
		{
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x00015D50 File Offset: 0x00013F50
		internal string EnhancedKeyUsageExtension(bool multiLine)
		{
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00015D60 File Offset: 0x00013F60
		internal string KeyUsageExtension(bool multiLine)
		{
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x00015D70 File Offset: 0x00013F70
		internal string SubjectKeyIdentifierExtension(bool multiLine)
		{
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x00015D80 File Offset: 0x00013F80
		internal string SubjectAltName(bool multiLine)
		{
			byte[] raw = this._raw;
			ASN1 asn;
			byte nTag = asn.m_nTag;
			Encoding ascii = Encoding.ASCII;
			byte[] value = asn.Value;
			Encoding ascii2 = Encoding.ASCII;
			byte[] value2 = asn.Value;
			string text = CryptoConvert.ToHex(asn.Value);
			string newLine = Environment.NewLine;
			return "Information Not Available";
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x00015DE8 File Offset: 0x00013FE8
		internal string NetscapeCertType(bool multiLine)
		{
			byte[] raw = this._raw;
			return "Information Not Available";
		}

		// Token: 0x04000472 RID: 1138
		internal Oid _oid;

		// Token: 0x04000473 RID: 1139
		internal byte[] _raw;
	}
}
