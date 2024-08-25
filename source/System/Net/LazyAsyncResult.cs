using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x020001EF RID: 495
	internal class LazyAsyncResult : IAsyncResult
	{
		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000C13 RID: 3091 RVA: 0x00002050 File Offset: 0x00000250
		private static LazyAsyncResult.ThreadContext CurrentThreadContext
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x000271BC File Offset: 0x000253BC
		internal LazyAsyncResult(object myObject, object myState, AsyncCallback myCallBack)
		{
			this.m_AsyncObject = myObject;
			this.m_AsyncState = myState;
			this.m_AsyncCallback = myCallBack;
			if (!true)
			{
			}
			this.m_Result = 1;
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x000271F0 File Offset: 0x000253F0
		internal LazyAsyncResult(object myObject, object myState, AsyncCallback myCallBack, object result)
		{
			this.m_AsyncObject = myObject;
			this.m_AsyncState = myState;
			this.m_AsyncCallback = myCallBack;
			this.m_Result = result;
			this.m_IntCompleted = 1;
			if (myCallBack != null)
			{
				IntPtr invoke_impl = myCallBack.invoke_impl;
				IntPtr method_code = myCallBack.method_code;
				IntPtr method = myCallBack.method;
				return;
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000C16 RID: 3094 RVA: 0x00027240 File Offset: 0x00025440
		internal object AsyncObject
		{
			get
			{
				return this.m_AsyncObject;
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000C17 RID: 3095 RVA: 0x00027254 File Offset: 0x00025454
		public object AsyncState
		{
			get
			{
				return this.m_AsyncState;
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000C18 RID: 3096 RVA: 0x00027268 File Offset: 0x00025468
		// (set) Token: 0x06000C19 RID: 3097 RVA: 0x0002727C File Offset: 0x0002547C
		protected AsyncCallback AsyncCallback
		{
			get
			{
				return this.m_AsyncCallback;
			}
			set
			{
				this.m_AsyncCallback = value;
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000C1A RID: 3098 RVA: 0x00027290 File Offset: 0x00025490
		public WaitHandle AsyncWaitHandle
		{
			get
			{
				if (this.m_IntCompleted == 0)
				{
				}
				if (this.m_Event != null)
				{
				}
				bool flag;
				while (!flag)
				{
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x000272B8 File Offset: 0x000254B8
		private bool LazilyCreateEvent([Out] ManualResetEvent waitHandle)
		{
			object obj;
			if (obj != null)
			{
			}
			int intCompleted = this.m_IntCompleted;
			throw new InvalidCastException();
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x000272F0 File Offset: 0x000254F0
		[Conditional("DEBUG")]
		protected void DebugProtectState(bool protect)
		{
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000C1D RID: 3101 RVA: 0x00027300 File Offset: 0x00025500
		public bool CompletedSynchronously
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000C1D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.LazyAsyncResult::get_CompletedSynchronously()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:int32[exp:bool](LazyAsyncResult::m_IntCompleted, ldloc:LazyAsyncResult(this)))
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

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000C1E RID: 3102 RVA: 0x00027314 File Offset: 0x00025514
		public bool IsCompleted
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000C1E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.LazyAsyncResult::get_IsCompleted()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:int32[exp:bool](LazyAsyncResult::m_IntCompleted, ldloc:LazyAsyncResult(this)))
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

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000C1F RID: 3103 RVA: 0x00027328 File Offset: 0x00025528
		internal bool InternalPeekCompleted
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000C1F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.LazyAsyncResult::get_InternalPeekCompleted()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(LazyAsyncResult::m_IntCompleted, ldloc:LazyAsyncResult(this)))
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

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000C20 RID: 3104 RVA: 0x0002733C File Offset: 0x0002553C
		// (set) Token: 0x06000C21 RID: 3105 RVA: 0x0002735C File Offset: 0x0002555C
		internal object Result
		{
			get
			{
				object result = this.m_Result;
				if (!true)
				{
				}
				return this.m_Result;
			}
			set
			{
				this.m_Result = value;
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000C22 RID: 3106 RVA: 0x00027370 File Offset: 0x00025570
		// (set) Token: 0x06000C23 RID: 3107 RVA: 0x00027384 File Offset: 0x00025584
		internal bool EndCalled
		{
			get
			{
				return this.m_EndCalled;
			}
			set
			{
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000C24 RID: 3108 RVA: 0x00027394 File Offset: 0x00025594
		// (set) Token: 0x06000C25 RID: 3109 RVA: 0x000273A8 File Offset: 0x000255A8
		internal int ErrorCode
		{
			get
			{
				return this.m_ErrorCode;
			}
			set
			{
				this.m_ErrorCode = value;
			}
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x000273BC File Offset: 0x000255BC
		protected void ProtectedInvokeCallback(object result, IntPtr userToken)
		{
			if (!true)
			{
			}
			int intCompleted = this.m_IntCompleted;
			object result2 = this.m_Result;
			if (intCompleted == 0)
			{
			}
			this.m_Result = result;
			if (this.m_Event != null)
			{
			}
		}

		// Token: 0x06000C27 RID: 3111 RVA: 0x000273F8 File Offset: 0x000255F8
		internal void InvokeCallback(object result)
		{
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x00027408 File Offset: 0x00025608
		internal void InvokeCallback()
		{
		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x00027418 File Offset: 0x00025618
		protected virtual void Complete(IntPtr userToken)
		{
			LazyAsyncResult.ThreadContext currentThreadContext = LazyAsyncResult.CurrentThreadContext;
			int nestedIOCount = currentThreadContext.m_NestedIOCount;
			AsyncCallback asyncCallback = this.m_AsyncCallback;
			if (asyncCallback != null)
			{
				IntPtr method_code = asyncCallback.method_code;
				IntPtr invoke_impl = asyncCallback.invoke_impl;
				IntPtr method = asyncCallback.method;
			}
			long num = 0L;
			int nestedIOCount2 = currentThreadContext.m_NestedIOCount;
			currentThreadContext.m_NestedIOCount = nestedIOCount2;
			if (num != 0L)
			{
				throw new OutOfMemoryException();
			}
		}

		// Token: 0x06000C2A RID: 3114 RVA: 0x000274AC File Offset: 0x000256AC
		private void WorkerThreadComplete(object state)
		{
			AsyncCallback asyncCallback = this.m_AsyncCallback;
			IntPtr method_code = asyncCallback.method_code;
			IntPtr invoke_impl = asyncCallback.invoke_impl;
			IntPtr method = asyncCallback.method;
			if (!false)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x000274F4 File Offset: 0x000256F4
		protected virtual void Cleanup()
		{
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x00027504 File Offset: 0x00025704
		internal object InternalWaitForCompletion()
		{
			return this.WaitForCompletion(true);
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x00027518 File Offset: 0x00025718
		private object WaitForCompletion(bool snap)
		{
			if (this.m_IntCompleted == 0)
			{
			}
			long num;
			if (!false)
			{
				object @event = this.m_Event;
				if (@event != null)
				{
					num = 0L;
					if (@event != null)
					{
						goto IL_0020;
					}
				}
				if (@event == null)
				{
					goto IL_008C;
				}
			}
			IL_0020:
			long num2 = 0L;
			int num3 = 5;
			object event2;
			if (num != 0L && !this.m_UserEvent)
			{
				event2 = this.m_Event;
				if (event2 != null)
				{
				}
			}
			if (num2 != 0L)
			{
				throw new OutOfMemoryException();
			}
			if (num3 != 0)
			{
				return event2;
			}
			Thread.SpinWait(1);
			IL_008C:
			object result = this.m_Result;
			return this.m_Result;
		}

		// Token: 0x06000C2E RID: 3118 RVA: 0x000275C0 File Offset: 0x000257C0
		internal void InternalCleanup()
		{
			int intCompleted = this.m_IntCompleted;
		}

		// Token: 0x04000A83 RID: 2691
		private const int c_HighBit = -2147483648;

		// Token: 0x04000A84 RID: 2692
		private const int c_ForceAsyncCount = 50;

		// Token: 0x04000A85 RID: 2693
		[ThreadStatic]
		private static LazyAsyncResult.ThreadContext t_ThreadContext;

		// Token: 0x04000A86 RID: 2694
		private object m_AsyncObject;

		// Token: 0x04000A87 RID: 2695
		private object m_AsyncState;

		// Token: 0x04000A88 RID: 2696
		private AsyncCallback m_AsyncCallback;

		// Token: 0x04000A89 RID: 2697
		private object m_Result;

		// Token: 0x04000A8A RID: 2698
		private int m_ErrorCode;

		// Token: 0x04000A8B RID: 2699
		private int m_IntCompleted;

		// Token: 0x04000A8C RID: 2700
		private bool m_EndCalled;

		// Token: 0x04000A8D RID: 2701
		private bool m_UserEvent;

		// Token: 0x04000A8E RID: 2702
		private object m_Event;

		// Token: 0x020001F0 RID: 496
		private class ThreadContext
		{
			// Token: 0x06000C2F RID: 3119 RVA: 0x000275D8 File Offset: 0x000257D8
			public ThreadContext()
			{
			}

			// Token: 0x04000A8F RID: 2703
			internal int m_NestedIOCount;
		}
	}
}
