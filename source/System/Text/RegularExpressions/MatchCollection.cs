using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000AC RID: 172
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(CollectionDebuggerProxy<Match>))]
	[Serializable]
	public class MatchCollection : IList<Match>, ICollection<Match>, IEnumerable<Match>, IEnumerable, IReadOnlyList<Match>, IReadOnlyCollection<Match>, IList, ICollection
	{
		// Token: 0x0600032A RID: 810 RVA: 0x0000B7A4 File Offset: 0x000099A4
		internal MatchCollection(Regex regex, string input, int beginning, int length, int startat)
		{
			int stringLength = input._stringLength;
			this._regex = regex;
			this._input = input;
			this._beginning = beginning;
			this._startat = length;
			this._startat = startat;
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600032B RID: 811 RVA: 0x0000B7E4 File Offset: 0x000099E4
		public bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600032C RID: 812 RVA: 0x0000B7F4 File Offset: 0x000099F4
		public int Count
		{
			get
			{
				if (!this._done)
				{
				}
				return this._matches._size;
			}
		}

		// Token: 0x170000B2 RID: 178
		public virtual Match this[int i]
		{
			get
			{
				Match match;
				do
				{
					match = this.GetMatch(i);
				}
				while (match == null);
				return match;
			}
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00002050 File Offset: 0x00000250
		public IEnumerator GetEnumerator()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00002050 File Offset: 0x00000250
		IEnumerator<Match> IEnumerable<Match>.GetEnumerator()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00002050 File Offset: 0x00000250
		private Match GetMatch(int i)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0000B830 File Offset: 0x00009A30
		private void EnsureInitialized()
		{
			if (this._done)
			{
				return;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000332 RID: 818 RVA: 0x0000B848 File Offset: 0x00009A48
		public bool IsSynchronized
		{
			get
			{
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000333 RID: 819 RVA: 0x00002050 File Offset: 0x00000250
		public object SyncRoot
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0000B858 File Offset: 0x00009A58
		public void CopyTo(Array array, int arrayIndex)
		{
			if (!this._done)
			{
			}
			List<Match> matches = this._matches;
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0000B878 File Offset: 0x00009A78
		public void CopyTo(Match[] array, int arrayIndex)
		{
			if (!this._done)
			{
			}
			List<Match> matches = this._matches;
		}

		// Token: 0x06000336 RID: 822 RVA: 0x0000B894 File Offset: 0x00009A94
		int IList<Match>.IndexOf(Match item)
		{
			/*
An exception occurred when decompiling this method (06000336)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Text.RegularExpressions.MatchCollection::System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.IndexOf(System.Text.RegularExpressions.Match)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0008:
	stloc:class [mscorlib]System.Collections.Generic.List`1<class System.Text.RegularExpressions.Match>(var_1_0E, ldfld:class [mscorlib]System.Collections.Generic.List`1<class System.Text.RegularExpressions.Match>(MatchCollection::_matches, ldloc:MatchCollection(this)))
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

		// Token: 0x06000337 RID: 823 RVA: 0x00002050 File Offset: 0x00000250
		void IList<Match>.Insert(int index, Match item)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00002050 File Offset: 0x00000250
		void IList<Match>.RemoveAt(int index)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x170000B5 RID: 181
		Match IList<Match>.this[int index]
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00002050 File Offset: 0x00000250
		void ICollection<Match>.Add(Match item)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00002050 File Offset: 0x00000250
		void ICollection<Match>.Clear()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0000B8B0 File Offset: 0x00009AB0
		bool ICollection<Match>.Contains(Match item)
		{
			/*
An exception occurred when decompiling this method (0600033D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Text.RegularExpressions.MatchCollection::System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Contains(System.Text.RegularExpressions.Match)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0008:
	stloc:class [mscorlib]System.Collections.Generic.List`1<class System.Text.RegularExpressions.Match>(var_1_0E, ldfld:class [mscorlib]System.Collections.Generic.List`1<class System.Text.RegularExpressions.Match>(MatchCollection::_matches, ldloc:MatchCollection(this)))
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

		// Token: 0x0600033E RID: 830 RVA: 0x00002050 File Offset: 0x00000250
		bool ICollection<Match>.Remove(Match item)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00002050 File Offset: 0x00000250
		int IList.Add(object value)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00002050 File Offset: 0x00000250
		void IList.Clear()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0000B8CC File Offset: 0x00009ACC
		bool IList.Contains(object value)
		{
			if (value != null)
			{
				return;
			}
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0000B8E0 File Offset: 0x00009AE0
		int IList.IndexOf(object value)
		{
			/*
An exception occurred when decompiling this method (06000342)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Text.RegularExpressions.MatchCollection::System.Collections.IList.IndexOf(System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldloc:object[exp:bool](value)))
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

		// Token: 0x06000343 RID: 835 RVA: 0x00002050 File Offset: 0x00000250
		void IList.Insert(int index, object value)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000344 RID: 836 RVA: 0x0000B8F0 File Offset: 0x00009AF0
		bool IList.IsFixedSize
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00002050 File Offset: 0x00000250
		void IList.Remove(object value)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00002050 File Offset: 0x00000250
		void IList.RemoveAt(int index)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x170000B7 RID: 183
		object IList.this[int index]
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0000B900 File Offset: 0x00009B00
		internal MatchCollection()
		{
			throw new NotSupportedException();
		}

		// Token: 0x0400029B RID: 667
		private readonly Regex _regex;

		// Token: 0x0400029C RID: 668
		private readonly List<Match> _matches;

		// Token: 0x0400029D RID: 669
		private bool _done;

		// Token: 0x0400029E RID: 670
		private readonly string _input;

		// Token: 0x0400029F RID: 671
		private readonly int _beginning;

		// Token: 0x040002A0 RID: 672
		private readonly int _length;

		// Token: 0x040002A1 RID: 673
		private int _startat;

		// Token: 0x040002A2 RID: 674
		private int _prevlen;

		// Token: 0x020000AD RID: 173
		[Serializable]
		private sealed class Enumerator : IEnumerator<Match>, IDisposable, IEnumerator
		{
			// Token: 0x0600034A RID: 842 RVA: 0x0000B914 File Offset: 0x00009B14
			internal Enumerator(MatchCollection collection)
			{
				this._collection = collection;
			}

			// Token: 0x0600034B RID: 843 RVA: 0x0000B930 File Offset: 0x00009B30
			public bool MoveNext()
			{
				for (;;)
				{
					int index = this._index;
					Match match;
					if (match != null)
					{
						return;
					}
				}
			}

			// Token: 0x170000B8 RID: 184
			// (get) Token: 0x0600034C RID: 844 RVA: 0x0000B94C File Offset: 0x00009B4C
			public Match Current
			{
				get
				{
					int index = this._index;
					return this._collection.GetMatch(index);
				}
			}

			// Token: 0x170000B9 RID: 185
			// (get) Token: 0x0600034D RID: 845 RVA: 0x0000B96C File Offset: 0x00009B6C
			object IEnumerator.Current
			{
				get
				{
					/*
An exception occurred when decompiling this method (0600034D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Text.RegularExpressions.MatchCollection/Enumerator::System.Collections.IEnumerator.get_Current()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Match(var_0_06, callgetter:Match(Enumerator::get_Current, ldloc:Enumerator(this)))
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

			// Token: 0x0600034E RID: 846 RVA: 0x0000B980 File Offset: 0x00009B80
			void IEnumerator.Reset()
			{
			}

			// Token: 0x0600034F RID: 847 RVA: 0x0000B990 File Offset: 0x00009B90
			void IDisposable.Dispose()
			{
			}

			// Token: 0x040002A3 RID: 675
			private readonly MatchCollection _collection;

			// Token: 0x040002A4 RID: 676
			private int _index;
		}
	}
}
