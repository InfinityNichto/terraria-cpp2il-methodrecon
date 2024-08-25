using System;

namespace System.Xml.Schema
{
	// Token: 0x02000118 RID: 280
	internal class Datatype_QNameXdr : Datatype_anySimpleType
	{
		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x060009AE RID: 2478 RVA: 0x0001C4A8 File Offset: 0x0001A6A8
		public override XmlTokenizedType TokenizedType
		{
			get
			{
				return XmlTokenizedType.QName;
			}
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x0001C4B8 File Offset: 0x0001A6B8
		public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr)
		{
			if (s != null && s._stringLength != 0 && nsmgr != null)
			{
				string text = s.Trim();
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x060009B0 RID: 2480 RVA: 0x0001C4E4 File Offset: 0x0001A6E4
		public override Type ValueType
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x060009B1 RID: 2481 RVA: 0x0001C4F8 File Offset: 0x0001A6F8
		internal override Type ListValueType
		{
			get
			{
				/*
An exception occurred when decompiling this method (060009B1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Type System.Xml.Schema.Datatype_QNameXdr::get_ListValueType()

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
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x0001C508 File Offset: 0x0001A708
		public Datatype_QNameXdr()
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x0001C520 File Offset: 0x0001A720
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_QNameXdr()
		{
			if (!true)
			{
			}
		}

		// Token: 0x04000507 RID: 1287
		private static readonly Type atomicValueType;

		// Token: 0x04000508 RID: 1288
		private static readonly Type listValueType;
	}
}
