using System;
using System.Collections;

namespace System.Xml.Schema
{
	// Token: 0x0200012B RID: 299
	internal class NamespaceList
	{
		// Token: 0x06000A17 RID: 2583 RVA: 0x0001CDA8 File Offset: 0x0001AFA8
		public NamespaceList()
		{
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x0001CDBC File Offset: 0x0001AFBC
		public NamespaceList(string namespaces, string targetNamespace)
		{
			this.targetNamespace = targetNamespace;
			string text = namespaces.Trim();
			bool flag = text == "##any";
			if (text._stringLength != 0)
			{
				bool flag2 = text == "##other";
				int num = 1;
				this.type = (NamespaceList.ListType)num;
				return;
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x0001CE48 File Offset: 0x0001B048
		public NamespaceList.ListType Type
		{
			get
			{
				return this.type;
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000A1A RID: 2586 RVA: 0x0001CE5C File Offset: 0x0001B05C
		public string Excluded
		{
			get
			{
				return this.targetNamespace;
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x0001CE70 File Offset: 0x0001B070
		public ICollection Enumerate
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000A1B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.ICollection System.Xml.Schema.NamespaceList::get_Enumerate()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ListType(var_0_06, ldfld:ListType(NamespaceList::type, ldloc:NamespaceList(this)))
	stloc:Hashtable(var_1_0D, ldfld:Hashtable(NamespaceList::set, ldloc:NamespaceList(this)))
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

		// Token: 0x06000A1C RID: 2588 RVA: 0x0001CE8C File Offset: 0x0001B08C
		public virtual bool Allows(string ns)
		{
			if (this.type == NamespaceList.ListType.Any)
			{
				return true;
			}
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x0001CEB8 File Offset: 0x0001B0B8
		public bool Allows(XmlQualifiedName qname)
		{
			/*
An exception occurred when decompiling this method (06000A1D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.Schema.NamespaceList::Allows(System.Xml.XmlQualifiedName)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_06, ldfld:string(XmlQualifiedName::ns, ldloc:XmlQualifiedName(qname)))
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

		// Token: 0x06000A1E RID: 2590 RVA: 0x0001CECC File Offset: 0x0001B0CC
		public override string ToString()
		{
			if (this.type == NamespaceList.ListType.Any)
			{
				return "##any";
			}
			Hashtable hashtable;
			if (hashtable != null)
			{
			}
			string text = this.targetNamespace;
			if (hashtable._buckets != null)
			{
			}
			long num = 0L;
			int num2 = 13;
			if (hashtable != null)
			{
			}
			if (num == 0L)
			{
				while (num2 != 0)
				{
				}
				throw new InvalidCastException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x04000512 RID: 1298
		private NamespaceList.ListType type;

		// Token: 0x04000513 RID: 1299
		private Hashtable set;

		// Token: 0x04000514 RID: 1300
		private string targetNamespace;

		// Token: 0x0200012C RID: 300
		public enum ListType
		{
			// Token: 0x04000516 RID: 1302
			Any,
			// Token: 0x04000517 RID: 1303
			Other,
			// Token: 0x04000518 RID: 1304
			Set
		}
	}
}
