using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace System.Linq
{
	// Token: 0x02000026 RID: 38
	internal abstract class OrderedEnumerable<TElement> : IOrderedEnumerable<TElement>, IEnumerable<TElement>, IEnumerable
	{
		// Token: 0x06000116 RID: 278 RVA: 0x00002050 File Offset: 0x00000250
		public IEnumerator<TElement> GetEnumerator()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000117 RID: 279
		internal abstract EnumerableSorter<TElement> GetEnumerableSorter(EnumerableSorter<TElement> next);

		// Token: 0x06000118 RID: 280 RVA: 0x00002050 File Offset: 0x00000250
		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00003CBC File Offset: 0x00001EBC
		IOrderedEnumerable<TElement> IOrderedEnumerable<TElement>.CreateOrderedEnumerable<TKey>(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending)
		{
			/*
An exception occurred when decompiling this method (06000119)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Linq.IOrderedEnumerable`1<TElement> System.Linq.OrderedEnumerable`1::System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<TKey>(System.Func`2<TElement,TKey>,System.Collections.Generic.IComparer`1<TKey>,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:IEnumerable`1(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.IEnumerable`1<!TElement>[exp:IEnumerable`1](OrderedEnumerable`1::source, ldloc:OrderedEnumerable`1(this)))
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

		// Token: 0x0600011A RID: 282 RVA: 0x00003CD0 File Offset: 0x00001ED0
		protected OrderedEnumerable()
		{
		}

		// Token: 0x04000092 RID: 146
		internal IEnumerable<TElement> source;

		// Token: 0x02000027 RID: 39
		[CompilerGenerated]
		private sealed class <GetEnumerator>d__1 : IEnumerator<TElement>, IDisposable, IEnumerator
		{
			// Token: 0x0600011B RID: 283 RVA: 0x00003CE4 File Offset: 0x00001EE4
			[DebuggerHidden]
			public <GetEnumerator>d__1(int <>1__state)
			{
				this.<>1__state = <>1__state;
			}

			// Token: 0x0600011C RID: 284 RVA: 0x00003D00 File Offset: 0x00001F00
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			// Token: 0x0600011D RID: 285 RVA: 0x00002050 File Offset: 0x00000250
			private bool MoveNext()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x17000029 RID: 41
			// (get) Token: 0x0600011E RID: 286 RVA: 0x00002050 File Offset: 0x00000250
			TElement IEnumerator<TElement>.Current
			{
				[DebuggerHidden]
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x0600011F RID: 287 RVA: 0x00002050 File Offset: 0x00000250
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x1700002A RID: 42
			// (get) Token: 0x06000120 RID: 288 RVA: 0x00002050 File Offset: 0x00000250
			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x04000093 RID: 147
			private int <>1__state;

			// Token: 0x04000094 RID: 148
			private TElement <>2__current;

			// Token: 0x04000095 RID: 149
			public OrderedEnumerable<TElement> <>4__this;

			// Token: 0x04000096 RID: 150
			private Buffer<TElement> <buffer>5__2;

			// Token: 0x04000097 RID: 151
			private int[] <map>5__3;

			// Token: 0x04000098 RID: 152
			private int <i>5__4;
		}
	}
}
