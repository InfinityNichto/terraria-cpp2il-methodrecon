using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Threading.Tasks
{
	// Token: 0x0200024E RID: 590
	[DebuggerDisplay("Id={Id}")]
	[DebuggerTypeProxy(typeof(TaskScheduler.SystemThreadingTasks_TaskSchedulerDebugView))]
	public abstract class TaskScheduler
	{
		// Token: 0x06001440 RID: 5184
		protected internal abstract void QueueTask(Task task);

		// Token: 0x06001441 RID: 5185
		protected abstract bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued);

		// Token: 0x06001442 RID: 5186 RVA: 0x0002A898 File Offset: 0x00028A98
		internal bool TryRunInline(Task task, bool taskWasPreviouslyQueued)
		{
			TaskScheduler taskScheduler = task.m_taskScheduler;
			bool flag;
			if (taskScheduler != null)
			{
				flag = taskScheduler.TryRunInline(task, taskWasPreviouslyQueued);
				return flag;
			}
			StackGuard currentStackGuard;
			if (flag)
			{
				if (task.m_action != null)
				{
					int stateFlags = task.m_stateFlags;
					int stateFlags2 = task.m_stateFlags;
					currentStackGuard = Task.CurrentStackGuard;
					int inliningDepth = currentStackGuard.m_inliningDepth;
					bool flag2 = RuntimeHelpers.TryEnsureSufficientExecutionStack();
					int inliningDepth2 = currentStackGuard.m_inliningDepth;
					currentStackGuard.m_inliningDepth = inliningDepth2;
					int inliningDepth3 = currentStackGuard.m_inliningDepth;
					currentStackGuard.m_inliningDepth = inliningDepth3;
					int stateFlags3 = task.m_stateFlags;
					int stateFlags4 = task.m_stateFlags;
					int inliningDepth4 = currentStackGuard.m_inliningDepth;
					currentStackGuard.m_inliningDepth = inliningDepth4;
				}
			}
			int inliningDepth5 = currentStackGuard.m_inliningDepth;
			currentStackGuard.m_inliningDepth = inliningDepth5;
			throw new OutOfMemoryException();
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x0002A968 File Offset: 0x00028B68
		protected internal virtual bool TryDequeue(Task task)
		{
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x0002A978 File Offset: 0x00028B78
		internal virtual void NotifyWorkItemProgress()
		{
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06001445 RID: 5189 RVA: 0x0002A988 File Offset: 0x00028B88
		internal virtual bool RequiresAtomicStartTransition
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x0002A998 File Offset: 0x00028B98
		protected TaskScheduler()
		{
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06001447 RID: 5191 RVA: 0x0002A9AC File Offset: 0x00028BAC
		public static TaskScheduler Default
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06001448 RID: 5192 RVA: 0x0002A9C0 File Offset: 0x00028BC0
		public static TaskScheduler Current
		{
			get
			{
				if (!true)
				{
				}
				if (TaskScheduler.InternalCurrent == null)
				{
					if (!true)
					{
					}
					if (!true)
					{
					}
				}
				return 1;
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06001449 RID: 5193 RVA: 0x0002A9E0 File Offset: 0x00028BE0
		internal static TaskScheduler InternalCurrent
		{
			get
			{
				if (!true)
				{
				}
				if (!true)
				{
					return;
				}
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x0600144A RID: 5194 RVA: 0x0002A9F4 File Offset: 0x00028BF4
		public int Id
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600144A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Threading.Tasks.TaskScheduler::get_Id()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	brtrue(IL_0000, ldloc:int32[exp:bool](var_0_01))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
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
		}

		// Token: 0x0600144B RID: 5195 RVA: 0x0002AA10 File Offset: 0x00028C10
		internal static void PublishUnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs ueea)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (true)
			{
			}
		}

		// Token: 0x0600144C RID: 5196 RVA: 0x0002AA3C File Offset: 0x00028C3C
		// Note: this type is marked as 'beforefieldinit'.
		static TaskScheduler()
		{
		}

		// Token: 0x04000ABE RID: 2750
		private static readonly TaskScheduler s_defaultTaskScheduler;

		// Token: 0x04000ABF RID: 2751
		internal static int s_taskSchedulerIdCounter;

		// Token: 0x04000AC0 RID: 2752
		private int m_taskSchedulerId;

		// Token: 0x04000AC1 RID: 2753
		private static EventHandler<UnobservedTaskExceptionEventArgs> _unobservedTaskException;

		// Token: 0x04000AC2 RID: 2754
		private static readonly Lock _unobservedTaskExceptionLockObject;

		// Token: 0x0200024F RID: 591
		internal sealed class SystemThreadingTasks_TaskSchedulerDebugView
		{
		}
	}
}
