using System;
using Mono.Security;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x02000116 RID: 278
	public sealed class X509EnhancedKeyUsageExtension : X509Extension
	{
		// Token: 0x0600068C RID: 1676 RVA: 0x000183EC File Offset: 0x000165EC
		public X509EnhancedKeyUsageExtension()
		{
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x00018400 File Offset: 0x00016600
		public X509EnhancedKeyUsageExtension(AsnEncodedData encodedEnhancedKeyUsages, bool critical)
		{
			byte[] raw = encodedEnhancedKeyUsages._raw;
			this._critical = true;
			this._raw = raw;
			AsnDecodeStatus asnDecodeStatus = this.Decode(raw);
			this._status = asnDecodeStatus;
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x00018438 File Offset: 0x00016638
		public X509EnhancedKeyUsageExtension(OidCollection enhancedKeyUsages, bool critical)
		{
			do
			{
				base..ctor();
			}
			while (enhancedKeyUsages == null);
			OidEnumerator enumerator = enhancedKeyUsages.GetEnumerator();
			bool flag = enumerator.MoveNext();
			Oid oid = enumerator.Current;
			int num = this._enhKeyUsage.Add(oid);
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x00018484 File Offset: 0x00016684
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
			this._critical = "2.5.29.37" != null;
			AsnDecodeStatus asnDecodeStatus = this.Decode(raw2);
			this._status = asnDecodeStatus;
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x000184D8 File Offset: 0x000166D8
		internal AsnDecodeStatus Decode(byte[] extension)
		{
			int num = 1;
			if (extension != null && num != 0)
			{
				if (this._enhKeyUsage == null)
				{
				}
				OidCollection enhKeyUsage = this._enhKeyUsage;
				ASN1 asn;
				string text = ASN1Convert.ToOid(asn);
				string text2 = Locale.GetText("Invalid ASN.1 Tag");
				return;
			}
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x00018520 File Offset: 0x00016720
		internal byte[] Encode()
		{
			/*
An exception occurred when decompiling this method (06000691)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] System.Security.Cryptography.X509Certificates.X509EnhancedKeyUsageExtension::Encode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:OidEnumerator(var_0_0B, call:OidEnumerator(OidCollection::GetEnumerator, ldfld:OidCollection(X509EnhancedKeyUsageExtension::_enhKeyUsage, ldloc:X509EnhancedKeyUsageExtension(this))))
	stloc:bool(var_1_12, call:bool(OidEnumerator::MoveNext, ldloc:OidEnumerator(var_0_0B)))
	stloc:ASN1(var_2_23, call:ASN1(ASN1Convert::FromOid, ldfld:string(Oid::_value, callgetter:Oid(OidEnumerator::get_Current, ldloc:OidEnumerator(var_0_0B)))))
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

		// Token: 0x06000692 RID: 1682 RVA: 0x00018550 File Offset: 0x00016750
		internal override string ToString(bool multiLine)
		{
			AsnDecodeStatus status = this._status;
			byte[] raw = this._raw;
			string text;
			return text;
		}

		// Token: 0x04000529 RID: 1321
		private OidCollection _enhKeyUsage;

		// Token: 0x0400052A RID: 1322
		private AsnDecodeStatus _status;
	}
}
