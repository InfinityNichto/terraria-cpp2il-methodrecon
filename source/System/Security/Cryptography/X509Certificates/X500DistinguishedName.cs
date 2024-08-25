using System;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x02000103 RID: 259
	[MonoTODO("Some X500DistinguishedNameFlags options aren't supported, like DoNotUsePlusSign, DoNotUseQuotes and ForceUTF8Encoding")]
	public sealed class X500DistinguishedName : AsnEncodedData
	{
		// Token: 0x060005A4 RID: 1444 RVA: 0x00015FFC File Offset: 0x000141FC
		public X500DistinguishedName(byte[] encodedDistinguishedName)
		{
			do
			{
				base..ctor();
			}
			while (encodedDistinguishedName == null);
			base.RawData = encodedDistinguishedName;
			this.DecodeRawData();
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x00016020 File Offset: 0x00014220
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00016034 File Offset: 0x00014234
		public string Decode(X500DistinguishedNameFlags flag)
		{
			while ((flag != X500DistinguishedNameFlags.None && 29169 == 0) || this._raw == null)
			{
			}
			string separator = X500DistinguishedName.GetSeparator(flag);
			byte[] raw = this._raw;
			string text;
			return text;
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00016064 File Offset: 0x00014264
		public override string Format(bool multiLine)
		{
			string text = this.Decode(X500DistinguishedNameFlags.UseNewLines);
			int stringLength = text._stringLength;
			string newLine = Environment.NewLine;
			return text + newLine;
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00016098 File Offset: 0x00014298
		private static string GetSeparator(X500DistinguishedNameFlags flag)
		{
			return Environment.NewLine;
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x000160B4 File Offset: 0x000142B4
		private void DecodeRawData()
		{
			if (this._raw != null)
			{
				string text;
				this.name = text;
				return;
			}
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x000160D4 File Offset: 0x000142D4
		private static string Canonize(string s)
		{
			/*
An exception occurred when decompiling this method (060005AA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Security.Cryptography.X509Certificates.X500DistinguishedName::Canonize(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0020:
	stloc:bool(var_8_28, call:bool(char::IsWhiteSpace, ldloc:string(var_5), ldc.i4:int32(0)))
	stloc:char(var_9_37, call:char(char::ToUpperInvariant, callgetter:char(string::get_Chars, ldloc:string(var_5), ldc.i4:int32(0))))
	stloc:int32(var_11_40, ldfld:int32(string::_stringLength, ldloc:string(var_5)))
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

		// Token: 0x060005AB RID: 1451 RVA: 0x00016124 File Offset: 0x00014324
		internal static bool AreEqual(X500DistinguishedName name1, X500DistinguishedName name2)
		{
			int num = 1;
			if (name1 != null)
			{
				if (num == 0 || name1.canonEncoding != null)
				{
				}
				string newLine = Environment.NewLine;
				if (newLine == null || newLine != null)
				{
					string[] array;
					string text;
					bool flag = X500DistinguishedName.Canonize(array) != text;
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x040004ED RID: 1261
		private string name;

		// Token: 0x040004EE RID: 1262
		private byte[] canonEncoding;
	}
}
