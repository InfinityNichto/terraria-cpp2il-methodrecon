using System;

namespace System.Xml.Schema
{
	// Token: 0x020000D3 RID: 211
	internal class ContentValidator
	{
		// Token: 0x0600084F RID: 2127 RVA: 0x0001A52C File Offset: 0x0001872C
		public ContentValidator(XmlSchemaContentType contentType)
		{
			this.contentType = contentType;
			this.isEmptiable = true;
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x0001A550 File Offset: 0x00018750
		protected ContentValidator(XmlSchemaContentType contentType, bool isOpen, bool isEmptiable)
		{
			this.contentType = contentType;
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000851 RID: 2129 RVA: 0x0001A56C File Offset: 0x0001876C
		public XmlSchemaContentType ContentType
		{
			get
			{
				return this.contentType;
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000852 RID: 2130 RVA: 0x0001A580 File Offset: 0x00018780
		public bool IsOpen
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000852)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.Schema.ContentValidator::get_IsOpen()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:XmlSchemaContentType(var_0_06, ldfld:XmlSchemaContentType(ContentValidator::contentType, ldloc:ContentValidator(this)))
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
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x0001A598 File Offset: 0x00018798
		// Note: this type is marked as 'beforefieldinit'.
		static ContentValidator()
		{
		}

		// Token: 0x04000430 RID: 1072
		private XmlSchemaContentType contentType;

		// Token: 0x04000431 RID: 1073
		private bool isOpen;

		// Token: 0x04000432 RID: 1074
		private bool isEmptiable;

		// Token: 0x04000433 RID: 1075
		public static readonly ContentValidator Empty;

		// Token: 0x04000434 RID: 1076
		public static readonly ContentValidator TextOnly;

		// Token: 0x04000435 RID: 1077
		public static readonly ContentValidator Mixed;

		// Token: 0x04000436 RID: 1078
		public static readonly ContentValidator Any;
	}
}
