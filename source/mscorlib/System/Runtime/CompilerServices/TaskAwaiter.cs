using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Internal.Threading.Tasks.Tracing;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000486 RID: 1158
	public readonly struct TaskAwaiter : ICriticalNotifyCompletion
	{
		// Token: 0x0600223A RID: 8762 RVA: 0x0004D198 File Offset: 0x0004B398
		internal TaskAwaiter(Task task)
		{
			this.m_task = task;
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x0600223B RID: 8763 RVA: 0x0004D1AC File Offset: 0x0004B3AC
		public bool IsCompleted
		{
			get
			{
				bool flag;
				return flag;
			}
		}

		// Token: 0x0600223C RID: 8764 RVA: 0x0004D1BC File Offset: 0x0004B3BC
		public void UnsafeOnCompleted(Action continuation)
		{
		}

		// Token: 0x0600223D RID: 8765 RVA: 0x0004D1CC File Offset: 0x0004B3CC
		[StackTraceHidden]
		public void GetResult()
		{
		}

		// Token: 0x0600223E RID: 8766 RVA: 0x0004D1DC File Offset: 0x0004B3DC
		[StackTraceHidden]
		internal static void ValidateEnd(Task task)
		{
			int stateFlags = task.m_stateFlags;
		}

		// Token: 0x0600223F RID: 8767 RVA: 0x0004D1F8 File Offset: 0x0004B3F8
		[StackTraceHidden]
		private static void HandleNonSuccessAndDebuggerNotification(Task task)
		{
			bool isCompleted = task.IsCompleted;
			bool flag = task.NotifyDebuggerOfWaitCompletionIfNecessary();
			bool isCompletedSuccessfully = task.IsCompletedSuccessfully;
		}

		// Token: 0x06002240 RID: 8768 RVA: 0x0004D224 File Offset: 0x0004B424
		[StackTraceHidden]
		private static void ThrowForNonSuccess(Task task)
		{
			TaskStatus status = task.Status;
		}

		// Token: 0x06002241 RID: 8769 RVA: 0x0004D24C File Offset: 0x0004B44C
		internal static void OnCompletedInternal(Task task, Action continuation, bool continueOnCapturedContext, bool flowExecutionContext)
		{
			while (continuation == null)
			{
			}
			bool enabled = TaskTrace.Enabled;
			Action action = TaskAwaiter.OutputWaitEtwEvents(task, continuation);
			task.SetContinuationForAwait(action, continueOnCapturedContext, flowExecutionContext);
		}

		// Token: 0x06002242 RID: 8770 RVA: 0x0004D278 File Offset: 0x0004B478
		private static Action OutputWaitEtwEvents(Task task, Action continuation)
		{
			/*
An exception occurred when decompiling this method (06002242)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Action System.Runtime.CompilerServices.TaskAwaiter::OutputWaitEtwEvents(System.Threading.Tasks.Task,System.Action)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000C:
	stloc:int64(var_3_0D, ldc.i4:int64(0))
	call:void(TaskTrace::TaskWaitBegin_Asynchronous, ldloc:int32(var_2), ldloc:int64[exp:int32](var_3_0D), ldloc:int32(var_4))
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

		// Token: 0x040012BD RID: 4797
		internal readonly Task m_task;

		// Token: 0x02000487 RID: 1159
		[CompilerGenerated]
		private sealed class <>c__DisplayClass11_0
		{
			// Token: 0x06002243 RID: 8771 RVA: 0x0004D29C File Offset: 0x0004B49C
			public <>c__DisplayClass11_0()
			{
			}

			// Token: 0x06002244 RID: 8772 RVA: 0x0004D2B0 File Offset: 0x0004B4B0
			internal void <OutputWaitEtwEvents>b__0()
			{
				bool enabled = TaskTrace.Enabled;
				if (!true)
				{
				}
				if (!true)
				{
				}
			}

			// Token: 0x040012BE RID: 4798
			public Task task;

			// Token: 0x040012BF RID: 4799
			public Action continuation;
		}
	}
}
