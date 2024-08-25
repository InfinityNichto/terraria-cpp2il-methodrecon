using System;

namespace System.Xml.Linq
{
	// Token: 0x02000008 RID: 8
	public class XDeclaration
	{
		// Token: 0x06000037 RID: 55 RVA: 0x00002940 File Offset: 0x00000B40
		public XDeclaration(string version, string encoding, string standalone)
		{
			this._version = version;
			this._encoding = encoding;
			this._standalone = standalone;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002968 File Offset: 0x00000B68
		public XDeclaration(XDeclaration other)
		{
			do
			{
				base..ctor();
			}
			while (other == null);
			string version = other._version;
			this._version = version;
			string standalone = other._standalone;
			this._standalone = standalone;
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000039 RID: 57 RVA: 0x0000299C File Offset: 0x00000B9C
		// (set) Token: 0x0600003A RID: 58 RVA: 0x000029B0 File Offset: 0x00000BB0
		public string Encoding
		{
			get
			{
				return this._encoding;
			}
			set
			{
				this._encoding = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600003B RID: 59 RVA: 0x000029C4 File Offset: 0x00000BC4
		// (set) Token: 0x0600003C RID: 60 RVA: 0x000029D8 File Offset: 0x00000BD8
		public string Standalone
		{
			get
			{
				return this._standalone;
			}
			set
			{
				this._standalone = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600003D RID: 61 RVA: 0x000029EC File Offset: 0x00000BEC
		public string Version
		{
			get
			{
				return this._version;
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002A00 File Offset: 0x00000C00
		public override string ToString()
		{
			/*
An exception occurred when decompiling this method (0600003E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Xml.Linq.XDeclaration::ToString()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0086:
	stloc:StringBuilder(var_14_91, call:StringBuilder(StringBuilder::Append, ldloc:StringBuilder(var_0_07), ldstr:string("?>")))
	call:void(StringBuilderCache::Release, ldloc:StringBuilder(var_0_07))
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

		// Token: 0x0400000B RID: 11
		private string _version;

		// Token: 0x0400000C RID: 12
		private string _encoding;

		// Token: 0x0400000D RID: 13
		private string _standalone;
	}
}
