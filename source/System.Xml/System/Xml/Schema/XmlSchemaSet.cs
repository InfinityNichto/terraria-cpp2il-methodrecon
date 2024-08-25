using System;
using System.Collections;

namespace System.Xml.Schema
{
	// Token: 0x02000151 RID: 337
	public class XmlSchemaSet
	{
		// Token: 0x06000B04 RID: 2820 RVA: 0x0001E75C File Offset: 0x0001C95C
		public XmlSchemaSet()
		{
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x0001E76C File Offset: 0x0001C96C
		public XmlSchemaSet(XmlNameTable nameTable)
		{
			do
			{
				base..ctor();
			}
			while (nameTable == null);
			this.nameTable = nameTable;
			this.readerSettings.NameTable = nameTable;
			XmlReaderSettings xmlReaderSettings = this.readerSettings;
			this.compileAll = true;
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x0001E7A4 File Offset: 0x0001C9A4
		private void InternalValidationCallback(object sender, ValidationEventArgs e)
		{
			/*
An exception occurred when decompiling this method (06000B06)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Xml.Schema.XmlSchemaSet::InternalValidationCallback(System.Object,System.Xml.Schema.ValidationEventArgs)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0009:
	stloc:XmlSchemaException(var_0_0F, ldfld:XmlSchemaException(ValidationEventArgs::ex, ldloc:ValidationEventArgs(e)))
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

		// Token: 0x040005AA RID: 1450
		private XmlNameTable nameTable;

		// Token: 0x040005AB RID: 1451
		private SortedList schemas;

		// Token: 0x040005AC RID: 1452
		private ValidationEventHandler internalEventHandler;

		// Token: 0x040005AD RID: 1453
		private ValidationEventHandler eventHandler;

		// Token: 0x040005AE RID: 1454
		private Hashtable schemaLocations;

		// Token: 0x040005AF RID: 1455
		private Hashtable chameleonSchemas;

		// Token: 0x040005B0 RID: 1456
		private Hashtable targetNamespaces;

		// Token: 0x040005B1 RID: 1457
		private bool compileAll;

		// Token: 0x040005B2 RID: 1458
		private SchemaInfo cachedCompiledInfo;

		// Token: 0x040005B3 RID: 1459
		private XmlReaderSettings readerSettings;

		// Token: 0x040005B4 RID: 1460
		private XmlSchemaCompilationSettings compilationSettings;
	}
}
