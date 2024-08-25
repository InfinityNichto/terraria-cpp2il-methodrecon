using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace System.Resources
{
	// Token: 0x020004AC RID: 1196
	internal sealed class RuntimeResourceSet : ResourceSet, IEnumerable
	{
		// Token: 0x060022D5 RID: 8917 RVA: 0x0004E294 File Offset: 0x0004C494
		internal RuntimeResourceSet(string fileName)
		{
			if (!true)
			{
			}
			Dictionary<string, ResourceLocator> resCache = this._resCache;
		}

		// Token: 0x060022D6 RID: 8918 RVA: 0x0004E2B4 File Offset: 0x0004C4B4
		internal RuntimeResourceSet(Stream stream)
		{
			if (!true)
			{
			}
		}

		// Token: 0x060022D7 RID: 8919 RVA: 0x0004E2CC File Offset: 0x0004C4CC
		protected override void Dispose(bool disposing)
		{
			if (this.Reader != null)
			{
				ResourceReader defaultReader = this._defaultReader;
				if (defaultReader == null || defaultReader._store != null)
				{
				}
				base.Dispose(true);
				long num = 0L;
				long num2 = 0L;
				if (num != 0L)
				{
					throw new OutOfMemoryException();
				}
				if (5 == 0)
				{
					base.Dispose(num2 != 0L);
				}
			}
		}

		// Token: 0x060022D8 RID: 8920 RVA: 0x0004E320 File Offset: 0x0004C520
		public override IDictionaryEnumerator GetEnumerator()
		{
			return this.GetEnumeratorHelper();
		}

		// Token: 0x060022D9 RID: 8921 RVA: 0x0004E334 File Offset: 0x0004C534
		IEnumerator IEnumerable.GetEnumerator()
		{
			/*
An exception occurred when decompiling this method (060022D9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.IEnumerator System.Resources.RuntimeResourceSet::System.Collections.IEnumerable.GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:IDictionaryEnumerator(var_0_06, call:IDictionaryEnumerator(RuntimeResourceSet::GetEnumeratorHelper, ldloc:RuntimeResourceSet(this)))
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

		// Token: 0x060022DA RID: 8922 RVA: 0x0004E348 File Offset: 0x0004C548
		private IDictionaryEnumerator GetEnumeratorHelper()
		{
			/*
An exception occurred when decompiling this method (060022DA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.IDictionaryEnumerator System.Resources.RuntimeResourceSet::GetEnumeratorHelper()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_1:
	brtrue(IL_0000, logicnot:bool(ldloc:class System.Collections.Generic.Dictionary`2<string, valuetype System.Resources.ResourceLocator>[exp:bool](var_0_0E)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

		// Token: 0x060022DB RID: 8923 RVA: 0x0004E36C File Offset: 0x0004C56C
		public override string GetString(string key)
		{
			long num = 0L;
			if (this.GetObject(key, num != 0L, true) != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x060022DC RID: 8924 RVA: 0x0004E38C File Offset: 0x0004C58C
		public override string GetString(string key, bool ignoreCase)
		{
			if (this.GetObject(key, ignoreCase, true) != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x060022DD RID: 8925 RVA: 0x0004E3AC File Offset: 0x0004C5AC
		public override object GetObject(string key)
		{
			long num = 0L;
			long num2 = 0L;
			return this.GetObject(key, num != 0L, num2 != 0L);
		}

		// Token: 0x060022DE RID: 8926 RVA: 0x0004E3C8 File Offset: 0x0004C5C8
		public override object GetObject(string key, bool ignoreCase)
		{
			long num = 0L;
			return this.GetObject(key, ignoreCase, num != 0L);
		}

		// Token: 0x060022DF RID: 8927 RVA: 0x0004E3E0 File Offset: 0x0004C5E0
		private object GetObject(string key, bool ignoreCase, bool isString)
		{
			if (key != null)
			{
				if (this.Reader == null || this._resCache == null)
				{
					throw new InvalidCastException();
				}
				if (this.Reader == null)
				{
					throw new OutOfMemoryException();
				}
				if (this._defaultReader != null)
				{
					Dictionary<string, ResourceLocator> resCache = this._resCache;
					int num = this._defaultReader.FindPosForResource(key);
					string text = this._defaultReader.LoadString(num);
					object obj;
					return obj;
				}
				if (!this._haveReadFromReader)
				{
					Dictionary<string, ResourceLocator> caseInsensitiveTable = this._caseInsensitiveTable;
					if (caseInsensitiveTable == null)
					{
						if (caseInsensitiveTable == null)
						{
						}
						if (!true)
						{
						}
					}
					ResourceReader defaultReader = this._defaultReader;
					int dataPosition;
					if (defaultReader != null)
					{
						ResourceReader.ResourceEnumerator enumeratorInternal = defaultReader.GetEnumeratorInternal();
						int num2 = 1;
						int currentName = enumeratorInternal._currentName;
						int numResources = enumeratorInternal._reader._numResources;
						enumeratorInternal._currentIsValid = num2 != 0;
						enumeratorInternal._currentName = currentName;
						if (enumeratorInternal.Key != null)
						{
						}
						dataPosition = enumeratorInternal._dataPosition;
						Dictionary<string, ResourceLocator> caseInsensitiveTable2 = this._caseInsensitiveTable;
						int num3 = 32768;
						enumeratorInternal._currentName = num3;
					}
					IResourceReader reader = this.Reader;
					if (dataPosition != 0)
					{
					}
					if (reader != null)
					{
					}
					Dictionary<string, ResourceLocator> resCache2 = this._resCache;
					Dictionary<string, ResourceLocator> caseInsensitiveTable3 = this._caseInsensitiveTable;
					IResourceReader reader2 = this.Reader;
					int num4 = 1;
					this._haveReadFromReader = num4 != 0;
				}
				if (this._defaultReader != null)
				{
					Dictionary<string, ResourceLocator> resCache3 = this._resCache;
					Dictionary<string, ResourceLocator> resCache4 = this._resCache;
					object obj2;
					return obj2;
				}
				int num5 = 1;
				Dictionary<string, ResourceLocator> caseInsensitiveTable4 = this._caseInsensitiveTable;
				Dictionary<string, ResourceLocator> resCache5 = this._resCache;
				long num6 = 0L;
				if (num5 != 0)
				{
				}
				if (num6 == 0L)
				{
					object obj3;
					return obj3;
				}
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060022E0 RID: 8928 RVA: 0x0004E5B0 File Offset: 0x0004C7B0
		private object ResolveResourceLocator(ResourceLocator resLocation, string key, Dictionary<string, ResourceLocator> copyOfCache, bool keyInWrongCase)
		{
			if (resLocation != null)
			{
			}
			IResourceReader reader = this.Reader;
			ResourceReader defaultReader = this._defaultReader;
			long num = 0L;
			if (true)
			{
			}
			if (num == 0L)
			{
				while (3 != 0)
				{
				}
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x04001317 RID: 4887
		internal const int Version = 2;

		// Token: 0x04001318 RID: 4888
		private Dictionary<string, ResourceLocator> _resCache;

		// Token: 0x04001319 RID: 4889
		private ResourceReader _defaultReader;

		// Token: 0x0400131A RID: 4890
		private Dictionary<string, ResourceLocator> _caseInsensitiveTable;

		// Token: 0x0400131B RID: 4891
		private bool _haveReadFromReader;
	}
}
