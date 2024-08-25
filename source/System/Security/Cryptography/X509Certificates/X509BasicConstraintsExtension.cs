using System;
using Mono.Security;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x02000104 RID: 260
	public sealed class X509BasicConstraintsExtension : X509Extension
	{
		// Token: 0x060005AC RID: 1452 RVA: 0x00016178 File Offset: 0x00014378
		public X509BasicConstraintsExtension()
		{
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x0001618C File Offset: 0x0001438C
		public X509BasicConstraintsExtension(AsnEncodedData encodedBasicConstraints, bool critical)
		{
			byte[] raw = encodedBasicConstraints._raw;
			this._critical = true;
			this._raw = raw;
			AsnDecodeStatus asnDecodeStatus = this.Decode(raw);
			this._status = asnDecodeStatus;
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x000161C4 File Offset: 0x000143C4
		public X509BasicConstraintsExtension(bool certificateAuthority, bool hasPathLengthConstraint, int pathLengthConstraint, bool critical)
		{
			this._pathLengthConstraint = pathLengthConstraint;
			this._certificateAuthority = true;
			this._critical = true;
			byte[] array = this.Encode();
			base.RawData = array;
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x000161FC File Offset: 0x000143FC
		public bool CertificateAuthority
		{
			get
			{
				AsnDecodeStatus status = this._status;
				return this._certificateAuthority;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060005B0 RID: 1456 RVA: 0x00016218 File Offset: 0x00014418
		public bool HasPathLengthConstraint
		{
			get
			{
				AsnDecodeStatus status = this._status;
				return this._hasPathLengthConstraint;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060005B1 RID: 1457 RVA: 0x00016234 File Offset: 0x00014434
		public int PathLengthConstraint
		{
			get
			{
				AsnDecodeStatus status = this._status;
				return this._pathLengthConstraint;
			}
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x00016250 File Offset: 0x00014450
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
			this._critical = "2.5.29.19" != null;
			AsnDecodeStatus asnDecodeStatus = this.Decode(raw2);
			this._status = asnDecodeStatus;
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x000162A4 File Offset: 0x000144A4
		internal AsnDecodeStatus Decode(byte[] extension)
		{
			int num = 1;
			if (extension != null && num != 0)
			{
				ASN1 asn;
				if (asn != null)
				{
					byte nTag = asn.m_nTag;
					byte[] value = asn.Value;
					this._certificateAuthority = asn != null;
					ASN1 asn2;
					if (asn2 != null)
					{
						byte nTag2 = asn2.m_nTag;
						int num2 = 1;
						this._hasPathLengthConstraint = num2 != 0;
						int num3 = ASN1Convert.ToInt32(asn2);
						this._pathLengthConstraint = num3;
						while (num3 == 0)
						{
						}
					}
				}
				return;
			}
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00016318 File Offset: 0x00014518
		internal byte[] Encode()
		{
			/*
An exception occurred when decompiling this method (060005B4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] System.Security.Cryptography.X509Certificates.X509BasicConstraintsExtension::Encode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_1:
	stloc:ASN1(var_2_20, call:ASN1(ASN1Convert::FromInt32, ldloc:int32(var_1_16)))
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

		// Token: 0x060005B5 RID: 1461 RVA: 0x00016348 File Offset: 0x00014548
		internal override string ToString(bool multiLine)
		{
			AsnDecodeStatus status = this._status;
			return "2.5.29.19";
		}

		// Token: 0x040004EF RID: 1263
		internal const string oid = "2.5.29.19";

		// Token: 0x040004F0 RID: 1264
		internal const string friendlyName = "Basic Constraints";

		// Token: 0x040004F1 RID: 1265
		private bool _certificateAuthority;

		// Token: 0x040004F2 RID: 1266
		private bool _hasPathLengthConstraint;

		// Token: 0x040004F3 RID: 1267
		private int _pathLengthConstraint;

		// Token: 0x040004F4 RID: 1268
		private AsnDecodeStatus _status;
	}
}
