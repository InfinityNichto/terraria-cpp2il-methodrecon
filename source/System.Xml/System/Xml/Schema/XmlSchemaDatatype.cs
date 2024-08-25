using System;
using System.Runtime.InteropServices;

namespace System.Xml.Schema
{
	// Token: 0x02000144 RID: 324
	public abstract class XmlSchemaDatatype
	{
		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000ACC RID: 2764
		public abstract Type ValueType { get; }

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000ACD RID: 2765
		public abstract XmlTokenizedType TokenizedType { get; }

		// Token: 0x06000ACE RID: 2766
		public abstract object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr);

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000ACF RID: 2767 RVA: 0x0001E138 File Offset: 0x0001C338
		public virtual XmlSchemaDatatypeVariety Variety
		{
			get
			{
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000AD0 RID: 2768 RVA: 0x0001E148 File Offset: 0x0001C348
		public virtual XmlTypeCode TypeCode
		{
			get
			{
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000AD1 RID: 2769
		internal abstract XmlValueConverter ValueConverter { get; }

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000AD2 RID: 2770
		internal abstract RestrictionFacets Restriction { get; }

		// Token: 0x06000AD3 RID: 2771
		internal abstract int Compare(object value1, object value2);

		// Token: 0x06000AD4 RID: 2772
		internal abstract Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, [Out] object typedValue);

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000AD5 RID: 2773
		internal abstract FacetsChecker FacetsChecker { get; }

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000AD6 RID: 2774
		internal abstract XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

		// Token: 0x06000AD7 RID: 2775
		internal abstract bool IsEqual(object o1, object o2);

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000AD8 RID: 2776 RVA: 0x0001E158 File Offset: 0x0001C358
		internal string TypeCodeString
		{
			get
			{
				if (this != null)
				{
				}
				return "Union";
			}
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x0001E17C File Offset: 0x0001C37C
		internal string TypeCodeToString(XmlTypeCode typeCode)
		{
			return "NonPositiveInteger";
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x0001E1F4 File Offset: 0x0001C3F4
		internal static XmlSchemaDatatype FromXmlTokenizedType(XmlTokenizedType token)
		{
			/*
An exception occurred when decompiling this method (06000ADA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.Schema.XmlSchemaDatatype System.Xml.Schema.XmlSchemaDatatype::FromXmlTokenizedType(System.Xml.XmlTokenizedType)

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

		// Token: 0x06000ADB RID: 2779 RVA: 0x0001E204 File Offset: 0x0001C404
		protected XmlSchemaDatatype()
		{
		}
	}
}
