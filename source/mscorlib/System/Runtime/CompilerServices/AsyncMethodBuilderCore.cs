using System;
using System.Diagnostics;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000492 RID: 1170
	internal struct AsyncMethodBuilderCore
	{
		// Token: 0x06002274 RID: 8820 RVA: 0x0004D784 File Offset: 0x0004B984
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			/*
An exception occurred when decompiling this method (06002274)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Runtime.CompilerServices.AsyncMethodBuilderCore::SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000B:
	stloc:string(var_0_15, call:string(Environment::GetResourceString, ldstr:string("The builder was not properly initialized.")))
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

		// Token: 0x06002275 RID: 8821 RVA: 0x0004D7A8 File Offset: 0x0004B9A8
		internal Action GetCompletionAction(Task taskForTracing, AsyncMethodBuilderCore.MoveNextRunner runnerToInitialize)
		{
			if (!true)
			{
			}
			Debugger.NotifyOfCrossThreadDependency();
			if (!true)
			{
			}
			ExecutionContext executionContext = ExecutionContext.FastCapture();
			Action action2;
			if (executionContext != null)
			{
				bool isPreAllocatedDefault = executionContext.IsPreAllocatedDefault;
				if (this.m_defaultContextAction == null)
				{
					if (taskForTracing != null)
					{
						Action action;
						this.m_defaultContextAction = action;
						return action;
					}
					this.m_defaultContextAction = action2;
					return action2;
				}
			}
			else if (taskForTracing != null)
			{
			}
			return action2;
		}

		// Token: 0x06002276 RID: 8822 RVA: 0x0004D7FC File Offset: 0x0004B9FC
		private Action OutputAsyncCausalityEvents(Task innerTask, Action continuation)
		{
			Action action;
			return action;
		}

		// Token: 0x06002277 RID: 8823 RVA: 0x0004D80C File Offset: 0x0004BA0C
		internal void PostBoxInitialization(IAsyncStateMachine stateMachine, AsyncMethodBuilderCore.MoveNextRunner runner, Task builtTask)
		{
			if (builtTask != null)
			{
				bool loggingOn = AsyncCausalityTracer.LoggingOn;
				int id = builtTask.Id;
				if ("Async: " == null)
				{
				}
				if ("Async: " != null)
				{
					if ("Async: " == null)
					{
					}
					bool flag = Task.AddToActiveTasks(builtTask);
				}
			}
			this.m_stateMachine = stateMachine;
		}

		// Token: 0x06002278 RID: 8824 RVA: 0x0004D854 File Offset: 0x0004BA54
		internal static void ThrowAsync(Exception exception, SynchronizationContext targetContext)
		{
			ExceptionDispatchInfo exceptionDispatchInfo = ExceptionDispatchInfo.Capture(exception);
			if (targetContext != null)
			{
				return;
			}
		}

		// Token: 0x06002279 RID: 8825 RVA: 0x0000207A File Offset: 0x0000027A
		internal static Action CreateContinuationWrapper(Action continuation, Action invokeAction, [Optional] Task innerTask)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600227A RID: 8826 RVA: 0x0004D880 File Offset: 0x0004BA80
		internal static Task TryGetContinuationTask(Action action)
		{
			if (true)
			{
				return;
			}
		}

		// Token: 0x040012D2 RID: 4818
		internal IAsyncStateMachine m_stateMachine;

		// Token: 0x040012D3 RID: 4819
		internal Action m_defaultContextAction;

		// Token: 0x02000493 RID: 1171
		internal sealed class MoveNextRunner
		{
			// Token: 0x0600227B RID: 8827 RVA: 0x0004D894 File Offset: 0x0004BA94
			internal MoveNextRunner(ExecutionContext context, IAsyncStateMachine stateMachine)
			{
				this.m_context = context;
				this.m_stateMachine = stateMachine;
			}

			// Token: 0x0600227C RID: 8828 RVA: 0x0004D8B8 File Offset: 0x0004BAB8
			internal void Run()
			{
				if (this.m_context != null)
				{
					ExecutionContext context = this.m_context;
					IAsyncStateMachine stateMachine = this.m_stateMachine;
					ExecutionContext context2 = this.m_context;
					context2.Dispose();
					return;
				}
				IAsyncStateMachine stateMachine2 = this.m_stateMachine;
			}

			// Token: 0x0600227D RID: 8829 RVA: 0x0004D918 File Offset: 0x0004BB18
			private static void InvokeMoveNext(object stateMachine)
			{
				if (stateMachine == null)
				{
					return;
				}
				if (stateMachine != null && stateMachine != null)
				{
					return;
				}
				throw new InvalidCastException();
			}

			// Token: 0x040012D4 RID: 4820
			private readonly ExecutionContext m_context;

			// Token: 0x040012D5 RID: 4821
			internal IAsyncStateMachine m_stateMachine;

			// Token: 0x040012D6 RID: 4822
			private static ContextCallback s_invokeMoveNext;
		}

		// Token: 0x02000494 RID: 1172
		private class ContinuationWrapper
		{
			// Token: 0x0600227E RID: 8830 RVA: 0x0004D940 File Offset: 0x0004BB40
			internal ContinuationWrapper(Action continuation, Action invokeAction, Task innerTask)
			{
				Task task;
				if (innerTask == null)
				{
					task = AsyncMethodBuilderCore.TryGetContinuationTask(continuation);
				}
				this.m_invokeAction = invokeAction;
				this.m_innerTask = task;
				this.m_continuation = continuation;
			}

			// Token: 0x0600227F RID: 8831 RVA: 0x0004D974 File Offset: 0x0004BB74
			internal void Invoke()
			{
				Action invokeAction = this.m_invokeAction;
				IntPtr invoke_impl = invokeAction.invoke_impl;
				IntPtr method_code = invokeAction.method_code;
				IntPtr method = invokeAction.method;
			}

			// Token: 0x040012D7 RID: 4823
			internal readonly Action m_continuation;

			// Token: 0x040012D8 RID: 4824
			private readonly Action m_invokeAction;

			// Token: 0x040012D9 RID: 4825
			internal readonly Task m_innerTask;
		}

		// Token: 0x02000495 RID: 1173
		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_0
		{
			// Token: 0x06002280 RID: 8832 RVA: 0x0004D9A0 File Offset: 0x0004BBA0
			public <>c__DisplayClass5_0()
			{
			}

			// Token: 0x06002281 RID: 8833 RVA: 0x0004D9B4 File Offset: 0x0004BBB4
			internal void <OutputAsyncCausalityEvents>b__0()
			{
				int id = this.innerTask.Id;
				Action action = this.continuation;
				IntPtr invoke_impl = action.invoke_impl;
				IntPtr method_code = action.method_code;
				IntPtr method = action.method;
			}

			// Token: 0x040012DA RID: 4826
			public Task innerTask;

			// Token: 0x040012DB RID: 4827
			public Action continuation;
		}

		// Token: 0x02000496 RID: 1174
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002282 RID: 8834 RVA: 0x0004D9F0 File Offset: 0x0004BBF0
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06002283 RID: 8835 RVA: 0x0004DA00 File Offset: 0x0004BC00
			public <>c()
			{
			}

			// Token: 0x06002284 RID: 8836 RVA: 0x0004DA14 File Offset: 0x0004BC14
			internal void <ThrowAsync>b__7_0(object state)
			{
				throw new InvalidCastException();
			}

			// Token: 0x06002285 RID: 8837 RVA: 0x0004DA2C File Offset: 0x0004BC2C
			internal void <ThrowAsync>b__7_1(object state)
			{
				throw new InvalidCastException();
			}

			// Token: 0x040012DC RID: 4828
			public static readonly AsyncMethodBuilderCore.<>c <>9;

			// Token: 0x040012DD RID: 4829
			public static SendOrPostCallback <>9__7_0;

			// Token: 0x040012DE RID: 4830
			public static WaitCallback <>9__7_1;
		}
	}
}
