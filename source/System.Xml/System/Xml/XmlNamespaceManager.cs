using System;
using System.Collections;
using System.Collections.Generic;

namespace System.Xml
{
	// Token: 0x020000AA RID: 170
	public class XmlNamespaceManager : IXmlNamespaceResolver, IEnumerable
	{
		// Token: 0x06000795 RID: 1941 RVA: 0x00019198 File Offset: 0x00017398
		internal XmlNamespaceManager()
		{
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x000191AC File Offset: 0x000173AC
		public XmlNamespaceManager(XmlNameTable nameTable)
		{
			this.nameTable = nameTable;
			this.xml = nameTable;
			this.xmlNs = nameTable;
			XmlNamespaceManager.NamespaceDeclaration[] array = this.nsdecls;
			string text = this.xmlNs;
			XmlNamespaceManager.NamespaceDeclaration[] array2 = this.nsdecls;
			string text2 = this.xml;
			this.lastDecl = 2;
			this.scopeId = 1;
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000797 RID: 1943 RVA: 0x00019200 File Offset: 0x00017400
		public virtual XmlNameTable NameTable
		{
			get
			{
				return this.nameTable;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000798 RID: 1944 RVA: 0x00019214 File Offset: 0x00017414
		public virtual string DefaultNamespace
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000798)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Xml.XmlNamespaceManager::get_DefaultNamespace()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldloc:XmlNamespaceManager[exp:bool](this))
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

		// Token: 0x06000799 RID: 1945 RVA: 0x00019224 File Offset: 0x00017424
		public virtual void PushScope()
		{
			int num = this.scopeId;
			this.scopeId = num;
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x00019240 File Offset: 0x00017440
		public virtual bool PopScope()
		{
			/*
An exception occurred when decompiling this method (0600079A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Xml.XmlNamespaceManager::PopScope()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_003B:
	stfld:int32(XmlNamespaceManager::lastDecl, ldloc:XmlNamespaceManager(this), ldloc:bool[exp:int32](var_4_1D))
	stfld:int32(XmlNamespaceManager::scopeId, ldloc:XmlNamespaceManager(this), ldloc:int32(var_7))
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

		// Token: 0x0600079B RID: 1947 RVA: 0x0001929C File Offset: 0x0001749C
		public virtual void AddNamespace(string prefix, string uri)
		{
			if (uri == null)
			{
				return;
			}
			if (prefix != null)
			{
				XmlNameTable xmlNameTable = this.nameTable;
				XmlNameTable xmlNameTable2 = this.nameTable;
				string text = this.xml;
				string text2 = this.xmlNs;
				XmlNamespaceManager.NamespaceDeclaration[] array = this.nsdecls;
				int num = this.scopeId;
				return;
			}
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x0001935C File Offset: 0x0001755C
		public virtual void RemoveNamespace(string prefix, string uri)
		{
			while (uri != null)
			{
				if (prefix != null)
				{
					int num = this.LookupNamespaceDecl(prefix);
					XmlNamespaceManager.NamespaceDeclaration[] array = this.nsdecls;
					XmlNamespaceManager.NamespaceDeclaration[] array2 = this.nsdecls;
					int num2 = this.scopeId;
					return;
				}
			}
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x00019390 File Offset: 0x00017590
		public virtual IEnumerator GetEnumerator()
		{
			/*
An exception occurred when decompiling this method (0600079D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.IEnumerator System.Xml.XmlNamespaceManager::GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(XmlNamespaceManager::lastDecl, ldloc:XmlNamespaceManager(this)))
	stloc:int32(var_1_0D, ldfld:int32(XmlNamespaceManager::lastDecl, ldloc:XmlNamespaceManager(this)))
	stloc:valuetype System.Xml.XmlNamespaceManager/NamespaceDeclaration[](var_3_16, ldfld:valuetype System.Xml.XmlNamespaceManager/NamespaceDeclaration[](XmlNamespaceManager::nsdecls, ldloc:XmlNamespaceManager(this)))
	stloc:int32(var_4_1D, ldfld:int32(XmlNamespaceManager::lastDecl, ldloc:XmlNamespaceManager(this)))
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

		// Token: 0x0600079E RID: 1950 RVA: 0x000193BC File Offset: 0x000175BC
		public virtual string LookupNamespace(string prefix)
		{
			/*
An exception occurred when decompiling this method (0600079E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Xml.XmlNamespaceManager::LookupNamespace(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_07, call:int32(XmlNamespaceManager::LookupNamespaceDecl, ldloc:XmlNamespaceManager(this), ldloc:string(prefix)))
	stloc:valuetype System.Xml.XmlNamespaceManager/NamespaceDeclaration[](var_1_0E, ldfld:valuetype System.Xml.XmlNamespaceManager/NamespaceDeclaration[](XmlNamespaceManager::nsdecls, ldloc:XmlNamespaceManager(this)))
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

		// Token: 0x0600079F RID: 1951 RVA: 0x000193DC File Offset: 0x000175DC
		private int LookupNamespaceDecl(string prefix)
		{
			if (this.useHashtable)
			{
				Dictionary<string, int> dictionary = this.hashTable;
				XmlNamespaceManager.NamespaceDeclaration[] array = this.nsdecls;
			}
			int num = this.lastDecl;
			XmlNamespaceManager.NamespaceDeclaration[] array2 = this.nsdecls;
			XmlNamespaceManager.NamespaceDeclaration[] array3 = this.nsdecls;
			if (this.nsdecls == null)
			{
			}
			return num;
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x00019428 File Offset: 0x00017628
		public virtual string LookupPrefix(string uri)
		{
			/*
An exception occurred when decompiling this method (060007A0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Xml.XmlNamespaceManager::LookupPrefix(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:valuetype System.Xml.XmlNamespaceManager/NamespaceDeclaration[](var_0_06, ldfld:valuetype System.Xml.XmlNamespaceManager/NamespaceDeclaration[](XmlNamespaceManager::nsdecls, ldloc:XmlNamespaceManager(this)))
	stloc:valuetype System.Xml.XmlNamespaceManager/NamespaceDeclaration[](var_2_0D, ldfld:valuetype System.Xml.XmlNamespaceManager/NamespaceDeclaration[](XmlNamespaceManager::nsdecls, ldloc:XmlNamespaceManager(this)))
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

		// Token: 0x040003C2 RID: 962
		private XmlNamespaceManager.NamespaceDeclaration[] nsdecls;

		// Token: 0x040003C3 RID: 963
		private int lastDecl;

		// Token: 0x040003C4 RID: 964
		private XmlNameTable nameTable;

		// Token: 0x040003C5 RID: 965
		private int scopeId;

		// Token: 0x040003C6 RID: 966
		private Dictionary<string, int> hashTable;

		// Token: 0x040003C7 RID: 967
		private bool useHashtable;

		// Token: 0x040003C8 RID: 968
		private string xml;

		// Token: 0x040003C9 RID: 969
		private string xmlNs;

		// Token: 0x020000AB RID: 171
		private struct NamespaceDeclaration
		{
			// Token: 0x060007A1 RID: 1953 RVA: 0x00019448 File Offset: 0x00017648
			public void Set(string prefix, string uri, int scopeId, int previousNsIndex)
			{
				this.prefix = prefix;
				this.uri = uri;
				this.scopeId = scopeId;
			}

			// Token: 0x040003CA RID: 970
			public string prefix;

			// Token: 0x040003CB RID: 971
			public string uri;

			// Token: 0x040003CC RID: 972
			public int scopeId;

			// Token: 0x040003CD RID: 973
			public int previousNsIndex;
		}
	}
}
