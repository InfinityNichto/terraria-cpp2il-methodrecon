using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;

namespace System.Collections.Concurrent
{
	// Token: 0x02000429 RID: 1065
	[DebuggerTypeProxy(typeof(BlockingCollectionDebugView<>))]
	[DebuggerDisplay("Count = {Count}, Type = {_collection}")]
	public class BlockingCollection<T> : IEnumerable<T>, IEnumerable, ICollection, IDisposable, IReadOnlyCollection<T>
	{
		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06001CDF RID: 7391 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsAddingCompleted
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06001CE0 RID: 7392 RVA: 0x0004E99C File Offset: 0x0004CB9C
		public bool IsCompleted
		{
			get
			{
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06001CE1 RID: 7393 RVA: 0x0004E9AC File Offset: 0x0004CBAC
		public int Count
		{
			get
			{
				int num;
				return num;
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06001CE2 RID: 7394 RVA: 0x0004E9BC File Offset: 0x0004CBBC
		bool ICollection.IsSynchronized
		{
			get
			{
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06001CE3 RID: 7395 RVA: 0x00002050 File Offset: 0x00000250
		object ICollection.SyncRoot
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06001CE4 RID: 7396 RVA: 0x0004E9CC File Offset: 0x0004CBCC
		public BlockingCollection()
		{
			int boundedCapacity = this._boundedCapacity;
		}

		// Token: 0x06001CE5 RID: 7397 RVA: 0x0004E9E0 File Offset: 0x0004CBE0
		public BlockingCollection(IProducerConsumerCollection<T> collection)
		{
			do
			{
				base..ctor();
			}
			while (collection == null);
		}

		// Token: 0x06001CE6 RID: 7398 RVA: 0x0004E9F8 File Offset: 0x0004CBF8
		private void Initialize(IProducerConsumerCollection<T> collection, int boundedCapacity, int collectionCount)
		{
			this._collection = collection;
			this._boundedCapacity = boundedCapacity;
		}

		// Token: 0x06001CE7 RID: 7399 RVA: 0x0004EA18 File Offset: 0x0004CC18
		public void Add(T item)
		{
		}

		// Token: 0x06001CE8 RID: 7400 RVA: 0x0004EA28 File Offset: 0x0004CC28
		private bool TryAddWithNoTimeValidation(T item, int millisecondsTimeout, CancellationToken cancellationToken)
		{
			if (this != null)
			{
				CancellationTokenSource cancellationTokenSource;
				CancellationToken token = cancellationTokenSource.Token;
				long num = 0L;
				if (cancellationTokenSource != null)
				{
					cancellationTokenSource.Dispose();
				}
				if (num != 0L)
				{
					goto IL_0038;
				}
			}
			long value = 0.m_value;
			if (false)
			{
				throw new OutOfMemoryException();
			}
			IL_0038:
			throw new OutOfMemoryException();
		}

		// Token: 0x06001CE9 RID: 7401 RVA: 0x0004EAB4 File Offset: 0x0004CCB4
		public T Take()
		{
			/*
An exception occurred when decompiling this method (06001CE9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling T System.Collections.Concurrent.BlockingCollection`1::Take()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:CancellationToken(var_1_0A, callgetter:CancellationToken(CancellationToken::get_None))
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

		// Token: 0x06001CEA RID: 7402 RVA: 0x00002050 File Offset: 0x00000250
		public T Take(CancellationToken cancellationToken)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001CEB RID: 7403 RVA: 0x00002050 File Offset: 0x00000250
		public bool TryTake([Out] T item, int millisecondsTimeout, CancellationToken cancellationToken)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001CEC RID: 7404 RVA: 0x0004EACC File Offset: 0x0004CCCC
		private bool TryTakeWithNoTimeValidation([Out] T item, int millisecondsTimeout, CancellationToken cancellationToken, CancellationTokenSource combinedTokenSource)
		{
			long num = 0L;
			if (combinedTokenSource == null && combinedTokenSource != null)
			{
				combinedTokenSource.Dispose();
			}
			if (num == 0L)
			{
				IProducerConsumerCollection collection = this._collection;
				if (collection == null)
				{
				}
				CancellationTokenSource cancellationTokenSource;
				CancellationToken token = cancellationTokenSource.Token;
				while (collection == null)
				{
				}
				bool flag;
				return flag;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001CED RID: 7405 RVA: 0x0004EB7C File Offset: 0x0004CD7C
		private void CancelWaitingConsumers()
		{
		}

		// Token: 0x06001CEE RID: 7406 RVA: 0x0004EB8C File Offset: 0x0004CD8C
		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		// Token: 0x06001CEF RID: 7407 RVA: 0x0004EBA0 File Offset: 0x0004CDA0
		protected virtual void Dispose(bool disposing)
		{
			if (this != null)
			{
			}
		}

		// Token: 0x06001CF0 RID: 7408 RVA: 0x0004EBB0 File Offset: 0x0004CDB0
		void ICollection.CopyTo(Array array, int index)
		{
			IProducerConsumerCollection collection = this._collection;
		}

		// Token: 0x06001CF1 RID: 7409 RVA: 0x0004EBD8 File Offset: 0x0004CDD8
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			/*
An exception occurred when decompiling this method (06001CF1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IEnumerator`1<T> System.Collections.Concurrent.BlockingCollection`1::System.Collections.Generic.IEnumerable<T>.GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:IProducerConsumerCollection`1(var_0_06, ldfld:class [mscorlib]System.Collections.Concurrent.IProducerConsumerCollection`1<!T>[exp:IProducerConsumerCollection`1](BlockingCollection`1::_collection, ldloc:BlockingCollection`1(this)))
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

		// Token: 0x06001CF2 RID: 7410 RVA: 0x00002050 File Offset: 0x00000250
		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001CF3 RID: 7411 RVA: 0x0004EBEC File Offset: 0x0004CDEC
		private static void ValidateMillisecondsTimeout(int millisecondsTimeout)
		{
		}

		// Token: 0x06001CF4 RID: 7412 RVA: 0x0004EC04 File Offset: 0x0004CE04
		private void CheckDisposed()
		{
		}

		// Token: 0x040013CC RID: 5068
		private IProducerConsumerCollection<T> _collection;

		// Token: 0x040013CD RID: 5069
		private int _boundedCapacity;

		// Token: 0x040013CE RID: 5070
		private SemaphoreSlim _freeNodes;

		// Token: 0x040013CF RID: 5071
		private SemaphoreSlim _occupiedNodes;

		// Token: 0x040013D0 RID: 5072
		private bool _isDisposed;

		// Token: 0x040013D1 RID: 5073
		private CancellationTokenSource _consumersCancellationTokenSource;

		// Token: 0x040013D2 RID: 5074
		private CancellationTokenSource _producersCancellationTokenSource;

		// Token: 0x040013D3 RID: 5075
		private int _currentAdders;
	}
}
