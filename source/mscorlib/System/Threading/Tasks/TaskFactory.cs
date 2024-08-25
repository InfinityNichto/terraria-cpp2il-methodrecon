using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace System.Threading.Tasks
{
	// Token: 0x0200022C RID: 556
	public class TaskFactory<TResult>
	{
		// Token: 0x0600134C RID: 4940 RVA: 0x00028624 File Offset: 0x00026824
		public TaskFactory()
		{
		}

		// Token: 0x0600134D RID: 4941 RVA: 0x0000207A File Offset: 0x0000027A
		public TaskFactory(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600134E RID: 4942 RVA: 0x00028634 File Offset: 0x00026834
		private static void FromAsyncCoreLogic(IAsyncResult iar, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, Task<TResult> promise, bool requiresSynchronization)
		{
			if (endFunction != null)
			{
				return;
			}
		}

		// Token: 0x0600134F RID: 4943 RVA: 0x00028670 File Offset: 0x00026870
		public Task<TResult> FromAsync(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, object state)
		{
			/*
An exception occurred when decompiling this method (0600134F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task`1<TResult> System.Threading.Tasks.TaskFactory`1::FromAsync(System.Func`3<System.AsyncCallback,System.Object,System.IAsyncResult>,System.Func`2<System.IAsyncResult,TResult>,System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:TaskCreationOptions(var_0_06, ldfld:TaskCreationOptions(TaskFactory`1::m_defaultCreationOptions, ldloc:TaskFactory`1(this)))
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

		// Token: 0x06001350 RID: 4944 RVA: 0x00028684 File Offset: 0x00026884
		internal static Task<TResult> FromAsyncImpl(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, object state, TaskCreationOptions creationOptions)
		{
			int num = 1;
			if (beginMethod != null || endFunction != null)
			{
				if (num == 0)
				{
				}
				bool loggingOn = DebuggerSupport.LoggingOn;
				if ("TaskFactory.FromAsync: " == null)
				{
				}
				int num2 = 1;
				if (num2 == 0)
				{
				}
				if (num2 == 0 || num2 == 0)
				{
				}
				if ("TaskFactory.FromAsync: " != null)
				{
				}
				return "beginMethod";
			}
			bool loggingOn2 = DebuggerSupport.LoggingOn;
			int num3 = 1;
			if (num3 == 0)
			{
			}
			if (num3 == 0 || num3 == 0)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001351 RID: 4945 RVA: 0x000286F0 File Offset: 0x000268F0
		public Task<TResult> FromAsync<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, object state)
		{
			/*
An exception occurred when decompiling this method (06001351)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task`1<TResult> System.Threading.Tasks.TaskFactory`1::FromAsync<TArg1>(System.Func`4<TArg1,System.AsyncCallback,System.Object,System.IAsyncResult>,System.Func`2<System.IAsyncResult,TResult>,TArg1,System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:TaskCreationOptions(var_0_06, ldfld:TaskCreationOptions(TaskFactory`1::m_defaultCreationOptions, ldloc:TaskFactory`1(this)))
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

		// Token: 0x06001352 RID: 4946 RVA: 0x00028704 File Offset: 0x00026904
		internal static Task<TResult> FromAsyncImpl<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, TArg1 arg1, object state, TaskCreationOptions creationOptions)
		{
			int num = 1;
			if (beginMethod != null || endFunction != null)
			{
				if (num == 0)
				{
				}
				bool loggingOn = DebuggerSupport.LoggingOn;
				if ("TaskFactory.FromAsync: " == null)
				{
				}
				int num2 = 1;
				if (num2 == 0)
				{
				}
				if (num2 == 0 || num2 == 0)
				{
				}
				if ("TaskFactory.FromAsync: " != null)
				{
				}
			}
			bool loggingOn2 = DebuggerSupport.LoggingOn;
			int num3 = 1;
			if (num3 == 0)
			{
			}
			if (num3 == 0 || num3 == 0)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001353 RID: 4947 RVA: 0x00028768 File Offset: 0x00026968
		internal static Task<TResult> FromAsyncImpl<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions)
		{
			int num = 1;
			if (beginMethod != null || endFunction != null)
			{
				if (num == 0)
				{
				}
				bool loggingOn = DebuggerSupport.LoggingOn;
				if ("TaskFactory.FromAsync: " == null)
				{
				}
				int num2 = 1;
				if (num2 == 0)
				{
				}
				if (num2 == 0 || num2 == 0)
				{
				}
				if ("TaskFactory.FromAsync: " != null)
				{
				}
				return "beginMethod";
			}
			bool loggingOn2 = DebuggerSupport.LoggingOn;
			int num3 = 1;
			if (num3 == 0)
			{
			}
			if (num3 == 0 || num3 == 0)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001354 RID: 4948 RVA: 0x000287D4 File Offset: 0x000269D4
		internal static Task<TResult> FromAsyncTrim<TInstance, TArgs>(TInstance thisRef, TArgs args, Func<TInstance, TArgs, AsyncCallback, object, IAsyncResult> beginMethod, Func<TInstance, IAsyncResult, TResult> endMethod) where TInstance : class
		{
			/*
An exception occurred when decompiling this method (06001354)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task`1<TResult> System.Threading.Tasks.TaskFactory`1::FromAsyncTrim<TInstance,TArgs>(TInstance,TArgs,System.Func`5<TInstance,TArgs,System.AsyncCallback,System.Object,System.IAsyncResult>,System.Func`3<TInstance,System.IAsyncResult,TResult>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
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

		// Token: 0x04000A40 RID: 2624
		private CancellationToken m_defaultCancellationToken;

		// Token: 0x04000A41 RID: 2625
		private TaskScheduler m_defaultScheduler;

		// Token: 0x04000A42 RID: 2626
		private TaskCreationOptions m_defaultCreationOptions;

		// Token: 0x04000A43 RID: 2627
		private TaskContinuationOptions m_defaultContinuationOptions;

		// Token: 0x0200022D RID: 557
		private sealed class FromAsyncTrimPromise<TInstance> : Task<TResult> where TInstance : class
		{
			// Token: 0x06001355 RID: 4949 RVA: 0x000287E4 File Offset: 0x000269E4
			internal FromAsyncTrimPromise(TInstance thisRef, Func<TInstance, IAsyncResult, TResult> endMethod)
			{
			}

			// Token: 0x06001356 RID: 4950 RVA: 0x000287F4 File Offset: 0x000269F4
			internal static void CompleteFromAsyncResult(IAsyncResult asyncResult)
			{
				while (asyncResult == null)
				{
				}
			}

			// Token: 0x06001357 RID: 4951 RVA: 0x0002880C File Offset: 0x00026A0C
			internal void Complete(TInstance thisRef, Func<TInstance, IAsyncResult, TResult> endMethod, IAsyncResult asyncResult, bool requiresSynchronization)
			{
			}

			// Token: 0x06001358 RID: 4952 RVA: 0x00028820 File Offset: 0x00026A20
			// Note: this type is marked as 'beforefieldinit'.
			static FromAsyncTrimPromise()
			{
			}

			// Token: 0x04000A44 RID: 2628
			internal static readonly AsyncCallback s_completeFromAsyncResult;

			// Token: 0x04000A45 RID: 2629
			private TInstance m_thisRef;

			// Token: 0x04000A46 RID: 2630
			private Func<TInstance, IAsyncResult, TResult> m_endMethod;
		}

		// Token: 0x0200022E RID: 558
		[CompilerGenerated]
		private sealed class <>c__DisplayClass35_0
		{
			// Token: 0x06001359 RID: 4953 RVA: 0x00028830 File Offset: 0x00026A30
			public <>c__DisplayClass35_0()
			{
			}

			// Token: 0x0600135A RID: 4954 RVA: 0x00028844 File Offset: 0x00026A44
			internal void <FromAsyncImpl>b__0(IAsyncResult iar)
			{
			}

			// Token: 0x04000A47 RID: 2631
			public Func<IAsyncResult, TResult> endFunction;

			// Token: 0x04000A48 RID: 2632
			public Action<IAsyncResult> endAction;

			// Token: 0x04000A49 RID: 2633
			public Task<TResult> promise;
		}

		// Token: 0x0200022F RID: 559
		[CompilerGenerated]
		private sealed class <>c__DisplayClass38_0<TArg1>
		{
			// Token: 0x0600135B RID: 4955 RVA: 0x00028868 File Offset: 0x00026A68
			public <>c__DisplayClass38_0()
			{
			}

			// Token: 0x0600135C RID: 4956 RVA: 0x0002887C File Offset: 0x00026A7C
			internal void <FromAsyncImpl>b__0(IAsyncResult iar)
			{
			}

			// Token: 0x04000A4A RID: 2634
			public Func<IAsyncResult, TResult> endFunction;

			// Token: 0x04000A4B RID: 2635
			public Action<IAsyncResult> endAction;

			// Token: 0x04000A4C RID: 2636
			public Task<TResult> promise;
		}

		// Token: 0x02000230 RID: 560
		[CompilerGenerated]
		private sealed class <>c__DisplayClass41_0<TArg1, TArg2>
		{
			// Token: 0x0600135D RID: 4957 RVA: 0x000288A0 File Offset: 0x00026AA0
			public <>c__DisplayClass41_0()
			{
			}

			// Token: 0x0600135E RID: 4958 RVA: 0x000288B4 File Offset: 0x00026AB4
			internal void <FromAsyncImpl>b__0(IAsyncResult iar)
			{
			}

			// Token: 0x04000A4D RID: 2637
			public Func<IAsyncResult, TResult> endFunction;

			// Token: 0x04000A4E RID: 2638
			public Action<IAsyncResult> endAction;

			// Token: 0x04000A4F RID: 2639
			public Task<TResult> promise;
		}
	}
}
