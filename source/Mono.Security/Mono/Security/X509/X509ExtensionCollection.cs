using System;
using System.Collections;

namespace Mono.Security.X509
{
	// Token: 0x0200001C RID: 28
	public sealed class X509ExtensionCollection : CollectionBase, IEnumerable
	{
		// Token: 0x0600013C RID: 316 RVA: 0x00006970 File Offset: 0x00004B70
		public X509ExtensionCollection()
		{
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00006984 File Offset: 0x00004B84
		public X509ExtensionCollection(ASN1 asn1)
		{
			int num = 1;
			this.readOnly = num != 0;
			if (asn1 != null)
			{
				byte nTag = asn1.m_nTag;
				int count = asn1.Count;
				long num2 = 0L;
				ASN1 asn2 = asn1[(int)num2];
				ArrayList list = this._list;
				int count2 = asn1.Count;
			}
		}

		// Token: 0x0600013E RID: 318 RVA: 0x000069CC File Offset: 0x00004BCC
		public int Add(X509Extension extension)
		{
			/*
An exception occurred when decompiling this method (0600013E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Mono.Security.X509.X509ExtensionCollection::Add(Mono.Security.X509.X509Extension)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_1:
	stloc:ArrayList(var_0_11, ldfld:ArrayList(CollectionBase::_list, ldloc:X509ExtensionCollection[exp:CollectionBase](this)))
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

		// Token: 0x0600013F RID: 319 RVA: 0x000069EC File Offset: 0x00004BEC
		public void AddRange(X509Extension[] extension)
		{
			while (extension != null)
			{
				if (!this.readOnly)
				{
					bool extnCritical = extension.extnCritical;
					ArrayList list = this._list;
					return;
				}
			}
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00006A18 File Offset: 0x00004C18
		public void AddRange(X509ExtensionCollection collection)
		{
			while (collection != null)
			{
				if (!this.readOnly)
				{
					ArrayList list = collection._list;
					long num = 0L;
					ArrayList list2 = this._list;
					X509Extension x509Extension = collection[(int)num];
					ArrayList list3 = collection._list;
					return;
				}
			}
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00006A54 File Offset: 0x00004C54
		public bool Contains(X509Extension extension)
		{
			/*
An exception occurred when decompiling this method (06000141)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Mono.Security.X509.X509ExtensionCollection::Contains(Mono.Security.X509.X509Extension)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_07, call:int32(X509ExtensionCollection::IndexOf, ldloc:X509ExtensionCollection(this), ldloc:X509Extension(extension)))
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

		// Token: 0x06000142 RID: 322 RVA: 0x00006A68 File Offset: 0x00004C68
		public bool Contains(string oid)
		{
			/*
An exception occurred when decompiling this method (06000142)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Mono.Security.X509.X509ExtensionCollection::Contains(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_07, call:int32(X509ExtensionCollection::IndexOf, ldloc:X509ExtensionCollection(this), ldloc:string(oid)))
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

		// Token: 0x06000143 RID: 323 RVA: 0x00006A7C File Offset: 0x00004C7C
		public void CopyTo(X509Extension[] extensions, int index)
		{
			while (extensions == null)
			{
			}
			ArrayList list = this._list;
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00006A94 File Offset: 0x00004C94
		public int IndexOf(X509Extension extension)
		{
			while (extension == null)
			{
			}
			ArrayList list = this._list;
			ArrayList list2 = this._list;
			ArrayList list3 = this._list;
			throw new InvalidCastException();
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00006AC0 File Offset: 0x00004CC0
		public int IndexOf(string oid)
		{
			while (oid == null)
			{
			}
			ArrayList list = this._list;
			ArrayList list2 = this._list;
			if (list2 != null)
			{
			}
			object[] items = list2._items;
			ArrayList list3 = this._list;
			throw new InvalidCastException();
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00006AF8 File Offset: 0x00004CF8
		public void Insert(int index, X509Extension extension)
		{
			while (extension == null)
			{
			}
			ArrayList list = this._list;
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00006B10 File Offset: 0x00004D10
		public void Remove(X509Extension extension)
		{
			while (extension == null)
			{
			}
			ArrayList list = this._list;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00006B28 File Offset: 0x00004D28
		public void Remove(string oid)
		{
			while (oid == null)
			{
			}
			int num = this.IndexOf(oid);
			ArrayList list = this._list;
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00006B48 File Offset: 0x00004D48
		IEnumerator IEnumerable.GetEnumerator()
		{
			/*
An exception occurred when decompiling this method (06000149)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.IEnumerator Mono.Security.X509.X509ExtensionCollection::System.Collections.IEnumerable.GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ArrayList(var_0_06, ldfld:ArrayList(CollectionBase::_list, ldloc:X509ExtensionCollection[exp:CollectionBase](this)))
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

		// Token: 0x1700005F RID: 95
		public X509Extension this[int index]
		{
			get
			{
				if (this._list != null)
				{
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x17000060 RID: 96
		public X509Extension this[string oid]
		{
			get
			{
				do
				{
					int num = this.IndexOf(oid);
				}
				while (this._list == null);
				throw new InvalidCastException();
			}
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00006B9C File Offset: 0x00004D9C
		public byte[] GetBytes()
		{
			ArrayList list = this._list;
			ArrayList list2 = this._list;
			if (this._list != null)
			{
			}
			ArrayList list3 = this._list;
			throw new InvalidCastException();
		}

		// Token: 0x0400009E RID: 158
		private bool readOnly;
	}
}
