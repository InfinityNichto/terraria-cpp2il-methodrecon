using System;
using System.Collections;
using System.Reflection;

namespace System.Xml.Schema
{
	// Token: 0x0200014C RID: 332
	[DefaultMember("Item")]
	public class XmlSchemaObjectCollection : CollectionBase
	{
		// Token: 0x06000AF7 RID: 2807 RVA: 0x0001E5E0 File Offset: 0x0001C7E0
		public XmlSchemaObjectCollection()
		{
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x0001E5F4 File Offset: 0x0001C7F4
		public int Add(XmlSchemaObject item)
		{
			/*
An exception occurred when decompiling this method (06000AF8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Xml.Schema.XmlSchemaObjectCollection::Add(System.Xml.Schema.XmlSchemaObject)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:IList(var_0_06, callgetter:IList(CollectionBase::get_List, ldloc:XmlSchemaObjectCollection[exp:CollectionBase](this)))
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

		// Token: 0x06000AF9 RID: 2809 RVA: 0x0001E608 File Offset: 0x0001C808
		protected override void OnInsert(int index, object item)
		{
			if (this.parent != null)
			{
				return;
			}
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x0001E620 File Offset: 0x0001C820
		protected override void OnSet(int index, object oldValue, object newValue)
		{
			if (this.parent != null)
			{
				XmlSchemaObject xmlSchemaObject = this.parent;
				return;
			}
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x0001E640 File Offset: 0x0001C840
		protected override void OnClear()
		{
			if (this.parent != null)
			{
				return;
			}
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x0001E658 File Offset: 0x0001C858
		protected override void OnRemove(int index, object item)
		{
			if (this.parent != null)
			{
				return;
			}
		}

		// Token: 0x040005A0 RID: 1440
		private XmlSchemaObject parent;
	}
}
