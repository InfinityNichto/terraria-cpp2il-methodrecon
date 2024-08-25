using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x0200024D RID: 589
	public class HttpListenerPrefixCollection : ICollection<string>, IEnumerable<string>, IEnumerable
	{
		// Token: 0x06000F08 RID: 3848 RVA: 0x0002FE10 File Offset: 0x0002E010
		internal HttpListenerPrefixCollection(HttpListener listener)
		{
			this.listener = listener;
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000F09 RID: 3849 RVA: 0x0002FE2C File Offset: 0x0002E02C
		public int Count
		{
			get
			{
				return this.prefixes._size;
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000F0A RID: 3850 RVA: 0x0002FE44 File Offset: 0x0002E044
		public bool IsReadOnly
		{
			get
			{
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000F0B RID: 3851 RVA: 0x0002FE54 File Offset: 0x0002E054
		public bool IsSynchronized
		{
			get
			{
			}
		}

		// Token: 0x06000F0C RID: 3852 RVA: 0x00002050 File Offset: 0x00000250
		public void Add(string uriPrefix)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x00002050 File Offset: 0x00000250
		public void Clear()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000F0E RID: 3854 RVA: 0x0002FE64 File Offset: 0x0002E064
		public bool Contains(string uriPrefix)
		{
			/*
An exception occurred when decompiling this method (06000F0E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.HttpListenerPrefixCollection::Contains(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(HttpListener::CheckDisposed, ldfld:HttpListener(HttpListenerPrefixCollection::listener, ldloc:HttpListenerPrefixCollection(this)))
	stloc:class [mscorlib]System.Collections.Generic.List`1<string>(var_0_11, ldfld:class [mscorlib]System.Collections.Generic.List`1<string>(HttpListenerPrefixCollection::prefixes, ldloc:HttpListenerPrefixCollection(this)))
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

		// Token: 0x06000F0F RID: 3855 RVA: 0x0002FE84 File Offset: 0x0002E084
		public void CopyTo(string[] array, int offset)
		{
			this.listener.CheckDisposed();
			List<string> list = this.prefixes;
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x0002FEA4 File Offset: 0x0002E0A4
		public void CopyTo(Array array, int offset)
		{
			this.listener.CheckDisposed();
			List<string> list = this.prefixes;
		}

		// Token: 0x06000F11 RID: 3857 RVA: 0x0002FEC4 File Offset: 0x0002E0C4
		public IEnumerator<string> GetEnumerator()
		{
			/*
An exception occurred when decompiling this method (06000F11)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IEnumerator`1<System.String> System.Net.HttpListenerPrefixCollection::GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.List`1<string>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.List`1<string>(HttpListenerPrefixCollection::prefixes, ldloc:HttpListenerPrefixCollection(this)))
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

		// Token: 0x06000F12 RID: 3858 RVA: 0x0002FED8 File Offset: 0x0002E0D8
		IEnumerator IEnumerable.GetEnumerator()
		{
			/*
An exception occurred when decompiling this method (06000F12)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.IEnumerator System.Net.HttpListenerPrefixCollection::System.Collections.IEnumerable.GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.List`1<string>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.List`1<string>(HttpListenerPrefixCollection::prefixes, ldloc:HttpListenerPrefixCollection(this)))
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

		// Token: 0x06000F13 RID: 3859 RVA: 0x0002FEEC File Offset: 0x0002E0EC
		public bool Remove(string uriPrefix)
		{
			do
			{
				this.listener.CheckDisposed();
			}
			while (uriPrefix == null);
			List<string> list = this.prefixes;
			HttpListener httpListener = this.listener;
			if (httpListener.listening)
			{
				EndPointManager.RemovePrefix(uriPrefix, httpListener);
			}
			return true;
		}

		// Token: 0x06000F14 RID: 3860 RVA: 0x0002FF28 File Offset: 0x0002E128
		internal HttpListenerPrefixCollection()
		{
			throw new NotSupportedException();
		}

		// Token: 0x04000C30 RID: 3120
		private List<string> prefixes;

		// Token: 0x04000C31 RID: 3121
		private HttpListener listener;
	}
}
