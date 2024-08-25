using System;

namespace System.Xml
{
	// Token: 0x02000072 RID: 114
	public abstract class XmlLinkedNode : XmlNode
	{
		// Token: 0x06000572 RID: 1394 RVA: 0x00012F9C File Offset: 0x0001119C
		internal XmlLinkedNode(XmlDocument doc)
			: base(doc)
		{
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000573 RID: 1395 RVA: 0x00012FB0 File Offset: 0x000111B0
		public override XmlNode PreviousSibling
		{
			get
			{
				while (this != null && this == null)
				{
				}
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000574 RID: 1396 RVA: 0x00012FC4 File Offset: 0x000111C4
		public override XmlNode NextSibling
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000574)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Xml.XmlNode System.Xml.XmlLinkedNode::get_NextSibling()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:XmlLinkedNode(var_0_09, ldfld:XmlLinkedNode(XmlLinkedNode::next, ldloc:XmlLinkedNode(this)))
	stloc:XmlLinkedNode(var_1_10, ldfld:XmlLinkedNode(XmlLinkedNode::next, ldloc:XmlLinkedNode(this)))
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

		// Token: 0x040002DE RID: 734
		internal XmlLinkedNode next;
	}
}
