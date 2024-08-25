using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace System.Threading
{
	// Token: 0x020001D1 RID: 465
	public class CancellationTokenSource : IDisposable
	{
		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06001109 RID: 4361 RVA: 0x000240B8 File Offset: 0x000222B8
		public bool IsCancellationRequested
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001109)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Threading.CancellationTokenSource::get_IsCancellationRequested()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(CancellationTokenSource::_state, ldloc:CancellationTokenSource(this)))
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

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x0600110A RID: 4362 RVA: 0x000240CC File Offset: 0x000222CC
		internal bool IsCancellationCompleted
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600110A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Threading.CancellationTokenSource::get_IsCancellationCompleted()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(CancellationTokenSource::_state, ldloc:CancellationTokenSource(this)))
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

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x0600110B RID: 4363 RVA: 0x000240E0 File Offset: 0x000222E0
		internal bool IsDisposed
		{
			get
			{
				return this._disposed;
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x0600110C RID: 4364 RVA: 0x000240F4 File Offset: 0x000222F4
		// (set) Token: 0x0600110D RID: 4365 RVA: 0x00024108 File Offset: 0x00022308
		internal int ThreadIDExecutingCallbacks
		{
			get
			{
				return this._threadIDExecutingCallbacks;
			}
			set
			{
				this._threadIDExecutingCallbacks = value;
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x0600110E RID: 4366 RVA: 0x0002411C File Offset: 0x0002231C
		public CancellationToken Token
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600110E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.CancellationToken System.Threading.CancellationTokenSource::get_Token()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(CancellationTokenSource::ThrowIfDisposed, ldloc:CancellationTokenSource(this))
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

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x0600110F RID: 4367 RVA: 0x00024130 File Offset: 0x00022330
		internal CancellationCallbackInfo ExecutingCallback
		{
			get
			{
				return this._executingCallback;
			}
		}

		// Token: 0x06001110 RID: 4368 RVA: 0x00024144 File Offset: 0x00022344
		public CancellationTokenSource()
		{
			this._state = 1;
		}

		// Token: 0x06001111 RID: 4369 RVA: 0x00024160 File Offset: 0x00022360
		public void Cancel()
		{
			this.ThrowIfDisposed();
			long num = 0L;
			this.NotifyCancellation(num != 0L);
		}

		// Token: 0x06001112 RID: 4370 RVA: 0x0002417C File Offset: 0x0002237C
		public void Cancel(bool throwOnFirstException)
		{
			this.ThrowIfDisposed();
			this.NotifyCancellation(throwOnFirstException);
		}

		// Token: 0x06001113 RID: 4371 RVA: 0x00024198 File Offset: 0x00022398
		public void CancelAfter(int millisecondsDelay)
		{
			int num = 1;
			this.ThrowIfDisposed();
			int state = this._state;
			if (this._timer == null)
			{
				if (num == 0)
				{
				}
				if (this != null)
				{
				}
			}
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x000241CC File Offset: 0x000223CC
		private static void TimerCallbackLogic(object obj)
		{
			if (obj != null)
			{
			}
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x000241EC File Offset: 0x000223EC
		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		// Token: 0x06001116 RID: 4374 RVA: 0x00024200 File Offset: 0x00022400
		protected virtual void Dispose(bool disposing)
		{
			if (!this._disposed)
			{
				Timer timer = this._timer;
				if (timer != null)
				{
					timer.Dispose();
				}
				if (this._kernelEvent != null && this != null)
				{
					int state = this._state;
				}
				this._disposed = true;
			}
		}

		// Token: 0x06001117 RID: 4375 RVA: 0x00024240 File Offset: 0x00022440
		internal void ThrowIfDisposed()
		{
			/*
An exception occurred when decompiling this method (06001117)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Threading.CancellationTokenSource::ThrowIfDisposed()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0009:
	call:void(CancellationTokenSource::ThrowObjectDisposedException)
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

		// Token: 0x06001118 RID: 4376 RVA: 0x0000207A File Offset: 0x0000027A
		private static void ThrowObjectDisposedException()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x0002425C File Offset: 0x0002245C
		internal CancellationTokenRegistration InternalRegister(Action<object> callback, object stateForCallback, SynchronizationContext targetSyncContext, ExecutionContext executionContext)
		{
			/*
An exception occurred when decompiling this method (06001119)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.CancellationTokenRegistration System.Threading.CancellationTokenSource::InternalRegister(System.Action`1<System.Object>,System.Object,System.Threading.SynchronizationContext,System.Threading.ExecutionContext)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_002F:
	stloc:int32(var_6_35, ldfld:int32(CancellationTokenSource::_state, ldloc:CancellationTokenSource(this)))
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

		// Token: 0x0600111A RID: 4378 RVA: 0x000242A0 File Offset: 0x000224A0
		private void NotifyCancellation(bool throwOnFirstException)
		{
			int state = this._state;
			Timer timer = this._timer;
			long num;
			if (timer != null)
			{
				num = 0L;
				timer.Dispose();
			}
			int currentManagedThreadId = Environment.CurrentManagedThreadId;
			ManualResetEvent kernelEvent = this._kernelEvent;
			this._threadIDExecutingCallbacks = currentManagedThreadId;
			if (kernelEvent != null)
			{
				bool flag = kernelEvent.Set();
			}
			this.ExecuteCallbackHandlers(num != 0L);
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x000242F8 File Offset: 0x000224F8
		private void ExecuteCallbackHandlers(bool throwOnFirstException)
		{
			if (this._registeredCallbacksLists == null)
			{
				return;
			}
			SparselyPopulatedArrayFragment sparselyPopulatedArrayFragment;
			if (sparselyPopulatedArrayFragment == null)
			{
				return;
			}
			int length = sparselyPopulatedArrayFragment.Length;
			!0 ! = sparselyPopulatedArrayFragment[0];
			this._executingCallback = !;
			if (! != null)
			{
				if (this._executingCallback != null)
				{
				}
				return;
			}
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x000243B0 File Offset: 0x000225B0
		private void CancellationCallbackCoreWork_OnSyncContext(object obj)
		{
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x000243C4 File Offset: 0x000225C4
		private void CancellationCallbackCoreWork(CancellationCallbackCoreWorkArguments args)
		{
			CancellationCallbackInfo executingCallback = this._executingCallback;
			CancellationCallbackInfo executingCallback2 = this._executingCallback;
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x000243EC File Offset: 0x000225EC
		public static CancellationTokenSource CreateLinkedTokenSource(CancellationToken token1, CancellationToken token2)
		{
			while (token1 == null)
			{
			}
			return CancellationTokenSource.CreateLinkedTokenSource(token1);
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x0000207A File Offset: 0x0000027A
		internal static CancellationTokenSource CreateLinkedTokenSource(CancellationToken token)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x00024404 File Offset: 0x00022604
		internal void WaitForCallbackToComplete(CancellationCallbackInfo callbackInfo)
		{
			CancellationCallbackInfo executingCallback = this._executingCallback;
			CancellationCallbackInfo executingCallback2 = this._executingCallback;
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x00024420 File Offset: 0x00022620
		// Note: this type is marked as 'beforefieldinit'.
		static CancellationTokenSource()
		{
			int processorCount = PlatformHelper.ProcessorCount;
		}

		// Token: 0x0400092B RID: 2347
		internal static readonly CancellationTokenSource s_canceledSource;

		// Token: 0x0400092C RID: 2348
		internal static readonly CancellationTokenSource s_neverCanceledSource;

		// Token: 0x0400092D RID: 2349
		private static readonly int s_nLists;

		// Token: 0x0400092E RID: 2350
		private ManualResetEvent _kernelEvent;

		// Token: 0x0400092F RID: 2351
		private SparselyPopulatedArray<CancellationCallbackInfo>[] _registeredCallbacksLists;

		// Token: 0x04000930 RID: 2352
		private int _state;

		// Token: 0x04000931 RID: 2353
		private int _threadIDExecutingCallbacks;

		// Token: 0x04000932 RID: 2354
		private bool _disposed;

		// Token: 0x04000933 RID: 2355
		private CancellationCallbackInfo _executingCallback;

		// Token: 0x04000934 RID: 2356
		private Timer _timer;

		// Token: 0x04000935 RID: 2357
		private static readonly TimerCallback s_timerCallback;

		// Token: 0x020001D2 RID: 466
		private sealed class Linked1CancellationTokenSource : CancellationTokenSource
		{
			// Token: 0x06001122 RID: 4386 RVA: 0x0002443C File Offset: 0x0002263C
			internal Linked1CancellationTokenSource(CancellationToken token1)
			{
				if (!true)
				{
				}
				this._threadIDExecutingCallbacks = 1;
				base..ctor();
				this._state = 1;
				if (!true)
				{
				}
				this._reg1.m_registrationInfo._index = 1;
			}

			// Token: 0x06001123 RID: 4387 RVA: 0x00024474 File Offset: 0x00022674
			protected override void Dispose(bool disposing)
			{
				if (this._disposed)
				{
					return;
				}
				int num = 1;
				base.Dispose(num != 0);
			}

			// Token: 0x04000936 RID: 2358
			private readonly CancellationTokenRegistration _reg1;
		}

		// Token: 0x020001D3 RID: 467
		private sealed class Linked2CancellationTokenSource : CancellationTokenSource
		{
			// Token: 0x06001124 RID: 4388 RVA: 0x00024494 File Offset: 0x00022694
			internal Linked2CancellationTokenSource(CancellationToken token1, CancellationToken token2)
			{
				if (!true)
				{
				}
				this._threadIDExecutingCallbacks = 1;
				base..ctor();
				this._state = 1;
				if (!true)
				{
				}
			}

			// Token: 0x06001125 RID: 4389 RVA: 0x000244BC File Offset: 0x000226BC
			protected override void Dispose(bool disposing)
			{
				if (this._disposed)
				{
					return;
				}
				int num = 1;
				base.Dispose(num != 0);
			}

			// Token: 0x04000937 RID: 2359
			private readonly CancellationTokenRegistration _reg1;

			// Token: 0x04000938 RID: 2360
			private readonly CancellationTokenRegistration _reg2;
		}

		// Token: 0x020001D4 RID: 468
		private sealed class LinkedNCancellationTokenSource : CancellationTokenSource
		{
			// Token: 0x06001126 RID: 4390 RVA: 0x000244DC File Offset: 0x000226DC
			// Note: this type is marked as 'beforefieldinit'.
			static LinkedNCancellationTokenSource()
			{
				if (!true)
				{
				}
			}

			// Token: 0x04000939 RID: 2361
			internal static readonly Action<object> s_linkedTokenCancelDelegate;

			// Token: 0x020001D5 RID: 469
			[CompilerGenerated]
			[Serializable]
			private sealed class <>c
			{
				// Token: 0x06001127 RID: 4391 RVA: 0x0001B05E File Offset: 0x0001925E
				// Note: this type is marked as 'beforefieldinit'.
				static <>c()
				{
				}

				// Token: 0x06001128 RID: 4392 RVA: 0x0001B05E File Offset: 0x0001925E
				public <>c()
				{
				}

				// Token: 0x06001129 RID: 4393 RVA: 0x0001B05E File Offset: 0x0001925E
				internal void <.cctor>b__4_0(object s)
				{
				}

				// Token: 0x0400093A RID: 2362
				public static readonly CancellationTokenSource.LinkedNCancellationTokenSource.<>c <>9;
			}
		}
	}
}
