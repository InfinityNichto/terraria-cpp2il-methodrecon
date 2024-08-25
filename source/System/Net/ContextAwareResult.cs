using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.Net
{
	// Token: 0x0200011E RID: 286
	internal class ContextAwareResult : LazyAsyncResult
	{
		// Token: 0x060006CD RID: 1741 RVA: 0x00018EF0 File Offset: 0x000170F0
		private void SafeCaptureIdentity()
		{
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x00018F00 File Offset: 0x00017100
		private void CleanupInternal()
		{
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x00018F10 File Offset: 0x00017110
		internal ContextAwareResult(object myObject, object myState, AsyncCallback myCallBack)
			: base(myObject, myState, myCallBack)
		{
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x00018F28 File Offset: 0x00017128
		internal ContextAwareResult(bool captureIdentity, bool forceCaptureContext, object myObject, object myState, AsyncCallback myCallBack)
			: base(myObject, myState, myCallBack)
		{
			this._flags = ContextAwareResult.StateFlags.CaptureContext;
			ContextAwareResult.StateFlags flags = this._flags;
			this._flags = flags;
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x00018F58 File Offset: 0x00017158
		internal ContextAwareResult(bool captureIdentity, bool forceCaptureContext, bool threadSafeContextCopy, object myObject, object myState, AsyncCallback myCallBack)
			: base(myObject, myState, myCallBack)
		{
			ContextAwareResult.StateFlags flags = this._flags;
			this._flags = flags;
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060006D2 RID: 1746 RVA: 0x00018F98 File Offset: 0x00017198
		internal ExecutionContext ContextCopy
		{
			get
			{
				do
				{
					bool internalPeekCompleted = base.InternalPeekCompleted;
				}
				while (this._context != null);
				if (this.m_AsyncCallback == null)
				{
					if (this._flags == ContextAwareResult.StateFlags.None)
					{
					}
					NetEventSource.Fail(this, "No context captured - specify a callback or forceCaptureContext.", "ContextCopy");
				}
				ContextAwareResult.StateFlags flags = this._flags;
				object @lock;
				if (this._lock == null)
				{
					if (flags == ContextAwareResult.StateFlags.None)
					{
					}
					NetEventSource.Fail(this, "Must lock (StartPostingAsyncOp()) { ... FinishPostingAsyncOp(); } when calling ContextCopy (unless it's only called after FinishPostingAsyncOp).", "ContextCopy");
					@lock = this._lock;
				}
				long num = 0L;
				if (flags != ContextAwareResult.StateFlags.None)
				{
					Monitor.Exit(@lock);
				}
				if (num == 0L)
				{
					bool internalPeekCompleted2 = base.InternalPeekCompleted;
					return this._context;
				}
				throw new OutOfMemoryException();
			}
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x00019064 File Offset: 0x00017264
		internal object StartPostingAsyncOp()
		{
			return this.StartPostingAsyncOp(true);
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x00019078 File Offset: 0x00017278
		internal object StartPostingAsyncOp(bool lockCapture)
		{
			/*
An exception occurred when decompiling this method (060006D4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Net.ContextAwareResult::StartPostingAsyncOp(System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_06, callgetter:bool(LazyAsyncResult::get_InternalPeekCompleted, ldloc:ContextAwareResult[exp:LazyAsyncResult](this)))
	call:void(NetEventSource::Fail, ldloc:ContextAwareResult[exp:object](this), ldstr:string[exp:object]("Called on completed result."), ldstr:string("StartPostingAsyncOp"))
	stloc:int64(var_1_18, ldc.i4:int64(0))
	stloc:StateFlags(var_2_1F, ldfld:StateFlags(ContextAwareResult::_flags, ldloc:ContextAwareResult(this)))
	stfld:object(ContextAwareResult::_lock, ldloc:ContextAwareResult(this), ldloc:int64[exp:object](var_1_18))
	stfld:StateFlags(ContextAwareResult::_flags, ldloc:ContextAwareResult(this), ldloc:StateFlags(var_2_1F))
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

		// Token: 0x060006D5 RID: 1749 RVA: 0x000190B4 File Offset: 0x000172B4
		internal bool FinishPostingAsyncOp()
		{
			ContextAwareResult.StateFlags flags = this._flags;
			this._flags = flags;
			bool flag;
			return flag;
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x000190D4 File Offset: 0x000172D4
		internal bool FinishPostingAsyncOp(CallbackClosure closure)
		{
			ContextAwareResult.StateFlags flags = this._flags;
			this._flags = flags;
			if (this.m_AsyncCallback != null)
			{
				this.m_AsyncCallback = flags;
				bool flag;
				return flag;
			}
			bool flag2;
			return flag2;
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x0001910C File Offset: 0x0001730C
		protected override void Cleanup()
		{
			base.Cleanup();
			bool isEnabled = NetEventSource.IsEnabled;
			if (!true)
			{
			}
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x0001912C File Offset: 0x0001732C
		private bool CaptureOrComplete(ExecutionContext cachedContext, bool returnContext)
		{
			if (this._flags == ContextAwareResult.StateFlags.None)
			{
			}
			NetEventSource.Fail(this, "Called without calling StartPostingAsyncOp.", "CaptureOrComplete");
			AsyncCallback asyncCallback = this.m_AsyncCallback;
			ContextAwareResult.StateFlags flags = this._flags;
			if (asyncCallback != null)
			{
			}
			bool internalPeekCompleted = base.InternalPeekCompleted;
			if (!true)
			{
				if (flags == ContextAwareResult.StateFlags.None)
				{
				}
				bool isEnabled = NetEventSource.IsEnabled;
				if (flags == ContextAwareResult.StateFlags.None)
				{
				}
				NetEventSource.Info(this, "starting identity capture", "CaptureOrComplete");
			}
			if (true)
			{
				bool internalPeekCompleted2 = base.InternalPeekCompleted;
			}
			if (flags == ContextAwareResult.StateFlags.None)
			{
			}
			bool isEnabled2 = NetEventSource.IsEnabled;
			if (flags == ContextAwareResult.StateFlags.None)
			{
			}
			NetEventSource.Info(this, "Skipping capture", "CaptureOrComplete");
			AsyncCallback asyncCallback2 = this.m_AsyncCallback;
			if (asyncCallback2 != null)
			{
				bool completedSynchronously = base.CompletedSynchronously;
				if (asyncCallback2 == null)
				{
				}
				NetEventSource.Fail(this, "Didn't capture context, but didn't complete synchronously!", "CaptureOrComplete");
				if (asyncCallback2 == null)
				{
				}
				bool isEnabled3 = NetEventSource.IsEnabled;
				if (asyncCallback2 == null)
				{
				}
				NetEventSource.Info(this, "starting capture", "CaptureOrComplete");
				ExecutionContext executionContext;
				if ("Didn't capture context, but didn't complete synchronously!" == null)
				{
					executionContext = ExecutionContext.Capture();
					if (executionContext == null)
					{
						goto IL_00DE;
					}
				}
				this._context = executionContext;
				IL_00DE:
				bool isEnabled4 = NetEventSource.IsEnabled;
				ExecutionContext context = this._context;
				if (context != null && context == null)
				{
					throw new ArrayTypeMismatchException();
				}
				if (asyncCallback == null)
				{
				}
				FormattableString formattableString;
				NetEventSource.Info(this, formattableString, "CaptureOrComplete");
			}
			bool completedSynchronously2 = base.CompletedSynchronously;
			bool isEnabled5 = NetEventSource.IsEnabled;
			NetEventSource.Info(this, "Completing synchronously", "CaptureOrComplete");
			return true;
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x00019268 File Offset: 0x00017468
		protected override void Complete(IntPtr userToken)
		{
			if (!true)
			{
			}
			bool isEnabled = NetEventSource.IsEnabled;
			ExecutionContext context = this._context;
			FormattableString formattableString;
			NetEventSource.Info(this, formattableString, "Complete");
			ContextAwareResult.StateFlags flags = this._flags;
			base.Complete(userToken);
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x000192BC File Offset: 0x000174BC
		private void CompleteCallback()
		{
			if (!true)
			{
			}
			bool isEnabled = NetEventSource.IsEnabled;
			if (!true)
			{
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060006DB RID: 1755 RVA: 0x000192D8 File Offset: 0x000174D8
		internal virtual EndPoint RemoteEndPoint
		{
			get
			{
			}
		}

		// Token: 0x0400053E RID: 1342
		private ExecutionContext _context;

		// Token: 0x0400053F RID: 1343
		private object _lock;

		// Token: 0x04000540 RID: 1344
		private ContextAwareResult.StateFlags _flags;

		// Token: 0x0200011F RID: 287
		[Flags]
		private enum StateFlags : byte
		{
			// Token: 0x04000542 RID: 1346
			None = 0,
			// Token: 0x04000543 RID: 1347
			CaptureIdentity = 1,
			// Token: 0x04000544 RID: 1348
			CaptureContext = 2,
			// Token: 0x04000545 RID: 1349
			ThreadSafeContextCopy = 4,
			// Token: 0x04000546 RID: 1350
			PostBlockStarted = 8,
			// Token: 0x04000547 RID: 1351
			PostBlockFinished = 16
		}

		// Token: 0x02000120 RID: 288
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060006DC RID: 1756 RVA: 0x000192E8 File Offset: 0x000174E8
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060006DD RID: 1757 RVA: 0x000192F8 File Offset: 0x000174F8
			public <>c()
			{
			}

			// Token: 0x060006DE RID: 1758 RVA: 0x0001930C File Offset: 0x0001750C
			internal void <Complete>b__17_0(object s)
			{
				if (s != null)
				{
				}
			}

			// Token: 0x04000548 RID: 1352
			public static readonly ContextAwareResult.<>c <>9;

			// Token: 0x04000549 RID: 1353
			public static ContextCallback <>9__17_0;
		}
	}
}
