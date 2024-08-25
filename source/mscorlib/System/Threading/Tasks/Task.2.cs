using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Internal.Threading.Tasks.Tracing;

namespace System.Threading.Tasks
{
	// Token: 0x02000232 RID: 562
	[DebuggerTypeProxy(typeof(SystemThreadingTasks_TaskDebugView))]
	[DebuggerDisplay("Id = {Id}, Status = {Status}, Method = {DebuggerDisplayMethodDescription}")]
	public class Task : IThreadPoolWorkItem, IAsyncResult, IDisposable
	{
		// Token: 0x0600135F RID: 4959 RVA: 0x000288D8 File Offset: 0x00026AD8
		internal Task(bool canceled, TaskCreationOptions creationOptions, CancellationToken ct)
		{
			this.m_stateFlags = 80;
		}

		// Token: 0x06001360 RID: 4960 RVA: 0x000288F4 File Offset: 0x00026AF4
		internal Task()
		{
			this.m_stateFlags = 1024;
		}

		// Token: 0x06001361 RID: 4961 RVA: 0x00028914 File Offset: 0x00026B14
		internal Task(object state, TaskCreationOptions creationOptions, bool promiseStyle)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x06001362 RID: 4962 RVA: 0x00028930 File Offset: 0x00026B30
		internal Task(Delegate action, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
		{
			do
			{
				base..ctor();
			}
			while (action == null);
			this.m_parent = parent;
			this.TaskConstructorCore(action, state, cancellationToken, creationOptions, internalOptions, scheduler);
		}

		// Token: 0x06001363 RID: 4963 RVA: 0x00028960 File Offset: 0x00026B60
		internal void TaskConstructorCore(Delegate action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
		{
			this.m_action = action;
			this.m_stateObject = state;
			this.m_taskScheduler = scheduler;
			this.m_stateFlags = (int)internalOptions;
			Task parent = this.m_parent;
			if (parent != null)
			{
				TaskCreationOptions options = parent.Options;
				this.m_parent.AddNewChild();
			}
			if (!true)
			{
			}
			ExecutionContext executionContext = ExecutionContext.Capture();
			this.CapturedContext = executionContext;
		}

		// Token: 0x06001364 RID: 4964 RVA: 0x000289BC File Offset: 0x00026BBC
		private void AssignCancellationToken(CancellationToken cancellationToken, Task antecedent, TaskContinuation continuation)
		{
			while (this.m_contingentProperties != null)
			{
			}
			long num = 0L;
			this.EnsureContingentPropertiesInitializedCore(num != 0L).m_cancellationToken = cancellationToken;
			TaskCreationOptions options = this.Options;
			long num2 = 0L;
			bool flag = this.InternalCancel(num2 != 0L);
		}

		// Token: 0x06001365 RID: 4965 RVA: 0x00028A3C File Offset: 0x00026C3C
		private static void TaskCancelCallback(object o)
		{
			if (o != null)
			{
				return;
			}
		}

		// Token: 0x06001366 RID: 4966 RVA: 0x00028A50 File Offset: 0x00026C50
		internal bool TrySetCanceled(CancellationToken tokenToRecord)
		{
			long num = 0L;
			return this.TrySetCanceled(tokenToRecord, num);
		}

		// Token: 0x06001367 RID: 4967 RVA: 0x00028A68 File Offset: 0x00026C68
		internal bool TrySetCanceled(CancellationToken tokenToRecord, object cancellationException)
		{
			bool flag = this.AtomicStateUpdate(1024, 1376);
			this.RecordInternalCancellationRequest(tokenToRecord, cancellationException);
			this.CancellationCleanupLogic();
			return true;
		}

		// Token: 0x06001368 RID: 4968 RVA: 0x00028A98 File Offset: 0x00026C98
		internal bool TrySetException(object exceptionObject)
		{
			if (this.m_contingentProperties == null)
			{
				Task.ContingentProperties contingentProperties = this.EnsureContingentPropertiesInitializedCore(true);
			}
			bool flag = this.AtomicStateUpdate(1024, 1376);
			long num = 0L;
			this.AddException(exceptionObject, num != 0L);
			long num2 = 0L;
			this.Finish(num2 != 0L);
			return true;
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06001369 RID: 4969 RVA: 0x00028AE0 File Offset: 0x00026CE0
		internal TaskCreationOptions Options
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001369)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.TaskCreationOptions System.Threading.Tasks.Task::get_Options()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	stloc:int32(var_0_06, ldfld:int32(Task::m_stateFlags, ldloc:Task(this)))
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
		}

		// Token: 0x0600136A RID: 4970 RVA: 0x0000207A File Offset: 0x0000027A
		internal static TaskCreationOptions OptionsMethod(int flags)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600136B RID: 4971 RVA: 0x00028AF8 File Offset: 0x00026CF8
		internal bool AtomicStateUpdate(int newBits, int illegalBits)
		{
			int stateFlags = this.m_stateFlags;
			return true;
		}

		// Token: 0x0600136C RID: 4972 RVA: 0x00028B14 File Offset: 0x00026D14
		internal bool AtomicStateUpdate(int newBits, int illegalBits, int oldFlags)
		{
			int stateFlags = this.m_stateFlags;
			oldFlags.m_value = stateFlags;
			return true;
		}

		// Token: 0x0600136D RID: 4973 RVA: 0x00028B34 File Offset: 0x00026D34
		internal void SetNotificationForWaitCompletion(bool enabled)
		{
			bool flag = this.AtomicStateUpdate(4096, 1376);
		}

		// Token: 0x0600136E RID: 4974 RVA: 0x00028B5C File Offset: 0x00026D5C
		internal bool NotifyDebuggerOfWaitCompletionIfNecessary()
		{
			int stateFlags = this.m_stateFlags;
			this.NotifyDebuggerOfWaitCompletion();
			return true;
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x0600136F RID: 4975 RVA: 0x00028B7C File Offset: 0x00026D7C
		internal bool IsWaitNotificationEnabledOrNotRanToCompletion
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600136F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Threading.Tasks.Task::get_IsWaitNotificationEnabledOrNotRanToCompletion()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Task::m_stateFlags, ldloc:Task(this)))
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

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06001370 RID: 4976 RVA: 0x00028B90 File Offset: 0x00026D90
		internal virtual bool ShouldNotifyDebuggerOfWaitCompletion
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001370)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Threading.Tasks.Task::get_ShouldNotifyDebuggerOfWaitCompletion()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Task::m_stateFlags, ldloc:Task(this)))
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

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06001371 RID: 4977 RVA: 0x00028BA4 File Offset: 0x00026DA4
		internal bool IsWaitNotificationEnabled
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001371)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Threading.Tasks.Task::get_IsWaitNotificationEnabled()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Task::m_stateFlags, ldloc:Task(this)))
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

		// Token: 0x06001372 RID: 4978 RVA: 0x00028BB8 File Offset: 0x00026DB8
		private void NotifyDebuggerOfWaitCompletion()
		{
		}

		// Token: 0x06001373 RID: 4979 RVA: 0x00028BC8 File Offset: 0x00026DC8
		internal bool MarkStarted()
		{
			return this.AtomicStateUpdate(1, 65);
		}

		// Token: 0x06001374 RID: 4980 RVA: 0x00028BE0 File Offset: 0x00026DE0
		internal void AddNewChild()
		{
			while (this.m_contingentProperties != null)
			{
			}
			int num = 1;
			int completionCountdown = this.EnsureContingentPropertiesInitializedCore(num != 0).m_completionCountdown;
		}

		// Token: 0x06001375 RID: 4981 RVA: 0x00028C08 File Offset: 0x00026E08
		internal void DisregardChild()
		{
			if (this.m_contingentProperties == null)
			{
				int num = 1;
				Task.ContingentProperties contingentProperties = this.EnsureContingentPropertiesInitializedCore(num != 0);
			}
		}

		// Token: 0x06001376 RID: 4982 RVA: 0x00028C28 File Offset: 0x00026E28
		internal static Task InternalStartNew(Task creatingTask, Delegate action, object state, CancellationToken cancellationToken, TaskScheduler scheduler, TaskCreationOptions options, InternalTaskOptions internalOptions)
		{
			while (cancellationToken == null)
			{
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06001377 RID: 4983 RVA: 0x00028C3C File Offset: 0x00026E3C
		public int Id
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001377)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Threading.Tasks.Task::get_Id()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	brtrue(IL_0000, ldc.i4:bool(1))
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

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06001378 RID: 4984 RVA: 0x00028C54 File Offset: 0x00026E54
		internal static Task InternalCurrent
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001378)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task System.Threading.Tasks.Task::get_InternalCurrent()

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
		}

		// Token: 0x06001379 RID: 4985 RVA: 0x00028C64 File Offset: 0x00026E64
		internal static Task InternalCurrentIfAttached(TaskCreationOptions creationOptions)
		{
			/*
An exception occurred when decompiling this method (06001379)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task System.Threading.Tasks.Task::InternalCurrentIfAttached(System.Threading.Tasks.TaskCreationOptions)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0005:
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

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x0600137A RID: 4986 RVA: 0x00028C78 File Offset: 0x00026E78
		internal static StackGuard CurrentStackGuard
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600137A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.StackGuard System.Threading.Tasks.Task::get_CurrentStackGuard()

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
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x0600137B RID: 4987 RVA: 0x00028C88 File Offset: 0x00026E88
		public AggregateException Exception
		{
			get
			{
				int stateFlags = this.m_stateFlags;
				long num = 0L;
				return this.GetExceptions(num != 0L);
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x0600137C RID: 4988 RVA: 0x00028CA8 File Offset: 0x00026EA8
		public TaskStatus Status
		{
			get
			{
				int stateFlags = this.m_stateFlags;
				return TaskStatus.Faulted;
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x0600137D RID: 4989 RVA: 0x00028CC8 File Offset: 0x00026EC8
		public bool IsCanceled
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600137D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Threading.Tasks.Task::get_IsCanceled()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Task::m_stateFlags, ldloc:Task(this)))
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

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x0600137E RID: 4990 RVA: 0x00028CDC File Offset: 0x00026EDC
		internal bool IsCancellationRequested
		{
			get
			{
				Task.ContingentProperties contingentProperties = this.m_contingentProperties;
				if (contingentProperties != null)
				{
					int internalCancellationRequested = contingentProperties.m_internalCancellationRequested;
				}
				bool flag;
				return flag;
			}
		}

		// Token: 0x0600137F RID: 4991 RVA: 0x00028D00 File Offset: 0x00026F00
		internal Task.ContingentProperties EnsureContingentPropertiesInitialized(bool needsProtection)
		{
			Task.ContingentProperties contingentProperties = this.m_contingentProperties;
			if (contingentProperties != null)
			{
				return contingentProperties;
			}
			return this.EnsureContingentPropertiesInitializedCore(needsProtection);
		}

		// Token: 0x06001380 RID: 4992 RVA: 0x00028D20 File Offset: 0x00026F20
		private Task.ContingentProperties EnsureContingentPropertiesInitializedCore(bool needsProtection)
		{
			Task.ContingentProperties contingentProperties;
			return contingentProperties;
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06001381 RID: 4993 RVA: 0x00028D30 File Offset: 0x00026F30
		internal CancellationToken CancellationToken
		{
			get
			{
				Task.ContingentProperties contingentProperties = this.m_contingentProperties;
				if (contingentProperties != null)
				{
					return contingentProperties.m_cancellationToken;
				}
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06001382 RID: 4994 RVA: 0x00028D50 File Offset: 0x00026F50
		internal bool IsCancellationAcknowledged
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001382)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Threading.Tasks.Task::get_IsCancellationAcknowledged()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Task::m_stateFlags, ldloc:Task(this)))
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

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06001383 RID: 4995 RVA: 0x00028D64 File Offset: 0x00026F64
		public bool IsCompleted
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001383)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Threading.Tasks.Task::get_IsCompleted()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	stloc:int32(var_0_06, ldfld:int32(Task::m_stateFlags, ldloc:Task(this)))
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
		}

		// Token: 0x06001384 RID: 4996 RVA: 0x0000207A File Offset: 0x0000027A
		private static bool IsCompletedMethod(int flags)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06001385 RID: 4997 RVA: 0x00028D7C File Offset: 0x00026F7C
		public bool IsCompletedSuccessfully
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001385)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Threading.Tasks.Task::get_IsCompletedSuccessfully()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Task::m_stateFlags, ldloc:Task(this)))
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

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06001386 RID: 4998 RVA: 0x00028D90 File Offset: 0x00026F90
		public TaskCreationOptions CreationOptions
		{
			get
			{
				return this.Options;
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06001387 RID: 4999 RVA: 0x00028DA4 File Offset: 0x00026FA4
		WaitHandle IAsyncResult.AsyncWaitHandle
		{
			get
			{
				int stateFlags = this.m_stateFlags;
				return this.CompletedEvent.WaitHandle;
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06001388 RID: 5000 RVA: 0x00028DC4 File Offset: 0x00026FC4
		public object AsyncState
		{
			get
			{
				return this.m_stateObject;
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06001389 RID: 5001 RVA: 0x00028DD8 File Offset: 0x00026FD8
		bool IAsyncResult.CompletedSynchronously
		{
			get
			{
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x0600138A RID: 5002 RVA: 0x0000207A File Offset: 0x0000027A
		internal TaskScheduler ExecutingTaskScheduler
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x0600138B RID: 5003 RVA: 0x00028DE8 File Offset: 0x00026FE8
		public static TaskFactory Factory
		{
			[CompilerGenerated]
			get
			{
				/*
An exception occurred when decompiling this method (0600138B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.TaskFactory System.Threading.Tasks.Task::get_Factory()

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
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x0600138C RID: 5004 RVA: 0x00028DF8 File Offset: 0x00026FF8
		public static Task CompletedTask
		{
			[CompilerGenerated]
			get
			{
				/*
An exception occurred when decompiling this method (0600138C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task System.Threading.Tasks.Task::get_CompletedTask()

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
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x0600138D RID: 5005 RVA: 0x00028E08 File Offset: 0x00027008
		internal ManualResetEventSlim CompletedEvent
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600138D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.ManualResetEventSlim System.Threading.Tasks.Task::get_CompletedEvent()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0022:
	stloc:bool(var_2_28, callgetter:bool(Task::get_IsCompleted, ldloc:Task(this)))
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

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x0600138E RID: 5006 RVA: 0x00028E40 File Offset: 0x00027040
		internal bool ExceptionRecorded
		{
			get
			{
				Task.ContingentProperties contingentProperties = this.m_contingentProperties;
				if (contingentProperties != null && contingentProperties.m_exceptionsHolder != null)
				{
					LowLevelListWithIList<ExceptionDispatchInfo> faultExceptions = contingentProperties.m_exceptionsHolder.m_faultExceptions;
					return;
				}
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x0600138F RID: 5007 RVA: 0x00028E6C File Offset: 0x0002706C
		public bool IsFaulted
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600138F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Threading.Tasks.Task::get_IsFaulted()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Task::m_stateFlags, ldloc:Task(this)))
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

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06001390 RID: 5008 RVA: 0x00028E80 File Offset: 0x00027080
		// (set) Token: 0x06001391 RID: 5009 RVA: 0x00028EA4 File Offset: 0x000270A4
		internal ExecutionContext CapturedContext
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001390)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.ExecutionContext System.Threading.Tasks.Task::get_CapturedContext()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0012:
	brtrue(IL_0000, ldc.i4:bool(1))
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
			set
			{
				do
				{
					if (!true)
					{
					}
				}
				while (this.m_contingentProperties != null);
				long num = 0L;
				this.EnsureContingentPropertiesInitializedCore(num != 0L).m_capturedContext = value;
			}
		}

		// Token: 0x06001392 RID: 5010 RVA: 0x00028ECC File Offset: 0x000270CC
		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		// Token: 0x06001393 RID: 5011 RVA: 0x00028EE0 File Offset: 0x000270E0
		protected virtual void Dispose(bool disposing)
		{
			TaskCreationOptions options = this.Options;
			bool isCompleted = this.IsCompleted;
			Task.ContingentProperties contingentProperties = this.m_contingentProperties;
			if (contingentProperties != null)
			{
				ManualResetEventSlim completionEvent = contingentProperties.m_completionEvent;
				if (completionEvent != null)
				{
					bool isSet = completionEvent.IsSet;
					completionEvent.Set();
					completionEvent.Dispose();
				}
			}
			int stateFlags = this.m_stateFlags;
		}

		// Token: 0x06001394 RID: 5012 RVA: 0x00028F2C File Offset: 0x0002712C
		internal void ScheduleAndStart(bool needsProtection)
		{
			int num = 1;
			int num2 = 65;
			bool flag = this.AtomicStateUpdate(num, num2);
		}

		// Token: 0x06001395 RID: 5013 RVA: 0x00028FA8 File Offset: 0x000271A8
		internal void AddException(object exceptionObject)
		{
			long num = 0L;
			this.AddException(exceptionObject, num != 0L);
		}

		// Token: 0x06001396 RID: 5014 RVA: 0x00028FC0 File Offset: 0x000271C0
		internal void AddException(object exceptionObject, bool representsCancellation)
		{
			Task.ContingentProperties contingentProperties;
			if (this.m_contingentProperties == null)
			{
				contingentProperties = this.EnsureContingentPropertiesInitializedCore(true);
			}
			long num;
			if (contingentProperties.m_exceptionsHolder == null && contingentProperties != null)
			{
				num = 0L;
			}
			Monitor.Enter(contingentProperties, num != 0L);
		}

		// Token: 0x06001397 RID: 5015 RVA: 0x00029024 File Offset: 0x00027224
		private AggregateException GetExceptions(bool includeTaskCanceledExceptions)
		{
			int stateFlags = this.m_stateFlags;
			bool exceptionRecorded = this.ExceptionRecorded;
			TaskExceptionHolder exceptionsHolder = this.m_contingentProperties.m_exceptionsHolder;
			AggregateException ex;
			return ex;
		}

		// Token: 0x06001398 RID: 5016 RVA: 0x00029060 File Offset: 0x00027260
		internal ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos()
		{
			int stateFlags = this.m_stateFlags;
			bool exceptionRecorded = this.ExceptionRecorded;
			return this.m_contingentProperties.m_exceptionsHolder.GetExceptionDispatchInfos();
		}

		// Token: 0x06001399 RID: 5017 RVA: 0x0002908C File Offset: 0x0002728C
		internal ExceptionDispatchInfo GetCancellationExceptionDispatchInfo()
		{
			Task.ContingentProperties contingentProperties = this.m_contingentProperties;
			if (contingentProperties == null)
			{
				return;
			}
			TaskExceptionHolder exceptionsHolder = contingentProperties.m_exceptionsHolder;
			if (exceptionsHolder != null)
			{
				return exceptionsHolder.m_cancellationException;
			}
		}

		// Token: 0x0600139A RID: 5018 RVA: 0x000290B8 File Offset: 0x000272B8
		internal void ThrowIfExceptional(bool includeTaskCanceledExceptions)
		{
			/*
An exception occurred when decompiling this method (0600139A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Threading.Tasks.Task::ThrowIfExceptional(System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000A:
	call:void(Task::UpdateExceptionObservedStatus, ldloc:Task(this))
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

		// Token: 0x0600139B RID: 5019 RVA: 0x000290D4 File Offset: 0x000272D4
		internal void UpdateExceptionObservedStatus()
		{
			Task parent = this.m_parent;
			if (parent != null)
			{
				TaskCreationOptions options = this.Options;
				TaskCreationOptions options2 = this.m_parent.Options;
				if (parent == null)
				{
				}
				if (!true)
				{
				}
				Task parent2 = this.m_parent;
				int stateFlags = this.m_stateFlags;
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x0600139C RID: 5020 RVA: 0x00029114 File Offset: 0x00027314
		internal bool IsExceptionObservedByParent
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600139C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Threading.Tasks.Task::get_IsExceptionObservedByParent()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Task::m_stateFlags, ldloc:Task(this)))
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

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x0600139D RID: 5021 RVA: 0x00029128 File Offset: 0x00027328
		internal bool IsDelegateInvoked
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600139D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Threading.Tasks.Task::get_IsDelegateInvoked()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Task::m_stateFlags, ldloc:Task(this)))
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

		// Token: 0x0600139E RID: 5022 RVA: 0x0002913C File Offset: 0x0002733C
		internal void Finish(bool bUserDelegateExecuted)
		{
			Task.ContingentProperties contingentProperties = this.m_contingentProperties;
			if (contingentProperties == null)
			{
				this.FinishStageTwo();
				return;
			}
			int completionCountdown = contingentProperties.m_completionCountdown;
			if (contingentProperties != null)
			{
				bool flag = this.AtomicStateUpdate(1, 352);
				return;
			}
			this.FinishStageTwo();
			LowLevelListWithIList<Task> exceptionalChildren = contingentProperties.m_exceptionalChildren;
			if (exceptionalChildren != null)
			{
				Monitor.Enter(exceptionalChildren, true);
				if (!true)
				{
				}
				long num = 0L;
				if (true)
				{
					Monitor.Exit(exceptionalChildren);
				}
				if (num != 0L)
				{
					throw new OutOfMemoryException();
				}
			}
		}

		// Token: 0x0600139F RID: 5023 RVA: 0x000291C4 File Offset: 0x000273C4
		internal void FinishStageTwo()
		{
			this.AddExceptionsFromChildren();
			bool exceptionRecorded = this.ExceptionRecorded;
			if (true || !true)
			{
			}
			if (!true)
			{
			}
			if (true)
			{
				if (!true)
				{
				}
				DebuggerSupport.RemoveFromActiveTasksNonInlined(this);
			}
		}

		// Token: 0x060013A0 RID: 5024 RVA: 0x00029244 File Offset: 0x00027444
		internal void FinishStageThree()
		{
			Task parent = this.m_parent;
			if (parent != null)
			{
				TaskCreationOptions options = parent.Options;
			}
		}

		// Token: 0x060013A1 RID: 5025 RVA: 0x00029264 File Offset: 0x00027464
		internal void ProcessChildCompletion(Task childTask)
		{
			Task.ContingentProperties contingentProperties = this.m_contingentProperties;
			int stateFlags = childTask.m_stateFlags;
			int stateFlags2 = childTask.m_stateFlags;
			if (contingentProperties.m_exceptionalChildren == null)
			{
			}
			long num = 0L;
			if (num == 0L)
			{
				if (num == 0L)
				{
					this.FinishStageTwo();
				}
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060013A2 RID: 5026 RVA: 0x000292B8 File Offset: 0x000274B8
		internal void AddExceptionsFromChildren()
		{
			Task.ContingentProperties contingentProperties = this.m_contingentProperties;
			if (contingentProperties != null)
			{
				LowLevelListWithIList<Task> exceptionalChildren = contingentProperties.m_exceptionalChildren;
				if (exceptionalChildren != null)
				{
					return;
				}
			}
		}

		// Token: 0x060013A3 RID: 5027 RVA: 0x00029364 File Offset: 0x00027564
		private void Execute()
		{
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x00029374 File Offset: 0x00027574
		void IThreadPoolWorkItem.ExecuteWorkItem()
		{
			long num = 0L;
			bool flag = this.ExecuteEntry(num != 0L);
		}

		// Token: 0x060013A5 RID: 5029 RVA: 0x0002938C File Offset: 0x0002758C
		internal bool ExecuteEntry(bool bPreventDoubleExecution)
		{
			int stateFlags = this.m_stateFlags;
			this.m_stateFlags = 1;
			bool isCancellationRequested = this.IsCancellationRequested;
			int stateFlags2 = this.m_stateFlags;
			int stateFlags3 = this.m_stateFlags;
			this.CancellationCleanupLogic();
			if (!true)
			{
			}
			return true;
		}

		// Token: 0x060013A6 RID: 5030 RVA: 0x000293CC File Offset: 0x000275CC
		private static void ExecutionContextCallback(object obj)
		{
			if (obj != null)
			{
			}
		}

		// Token: 0x060013A7 RID: 5031 RVA: 0x000293E0 File Offset: 0x000275E0
		internal virtual void InnerInvoke()
		{
			Delegate action = this.m_action;
			if (action != null)
			{
			}
			if (action != null)
			{
				IntPtr method_code = action.method_code;
				IntPtr invoke_impl = action.invoke_impl;
				IntPtr method = action.method;
				return;
			}
		}

		// Token: 0x060013A8 RID: 5032 RVA: 0x00029414 File Offset: 0x00027614
		private void HandleException(Exception unhandledException)
		{
			if (unhandledException != null)
			{
				bool isCancellationRequested = this.IsCancellationRequested;
				CancellationToken cancellationToken = this.m_contingentProperties.m_cancellationToken;
				int stateFlags = this.m_stateFlags;
				return;
			}
			long num = 0L;
			this.AddException(unhandledException, num != 0L);
		}

		// Token: 0x060013A9 RID: 5033 RVA: 0x0000207A File Offset: 0x0000027A
		public TaskAwaiter GetAwaiter()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x0000207A File Offset: 0x0000027A
		public ConfiguredTaskAwaitable ConfigureAwait(bool continueOnCapturedContext)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060013AB RID: 5035 RVA: 0x0002944C File Offset: 0x0002764C
		internal void SetContinuationForAwait(Action continuationAction, bool continueOnCapturedContext, bool flowExecutionContext)
		{
			SynchronizationContext synchronizationContext = SynchronizationContext.Current;
			if (synchronizationContext != null)
			{
				Type type = synchronizationContext.GetType();
				Type type2;
				bool flag = type != type2;
				return;
			}
			if (TaskScheduler.InternalCurrent != null)
			{
				if (!true)
				{
				}
				return;
			}
			long num = 0L;
			bool flag2 = this.AddTaskContinuation(continuationAction, num != 0L);
		}

		// Token: 0x060013AC RID: 5036 RVA: 0x00029498 File Offset: 0x00027698
		public void Wait()
		{
		}

		// Token: 0x060013AD RID: 5037 RVA: 0x000294A8 File Offset: 0x000276A8
		public bool Wait(int millisecondsTimeout)
		{
			bool flag;
			return flag;
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x000294B8 File Offset: 0x000276B8
		public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			/*
An exception occurred when decompiling this method (060013AE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Threading.Tasks.Task::Wait(System.Int32,System.Threading.CancellationToken)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Task::m_stateFlags, ldloc:Task(this)))
	stloc:int32(var_2_0D, ldfld:int32(Task::m_stateFlags, ldloc:Task(this)))
	stloc:bool(var_3_14, call:bool(Task::NotifyDebuggerOfWaitCompletionIfNecessary, ldloc:Task(this)))
	stloc:int32(var_4_1B, ldfld:int32(Task::m_stateFlags, ldloc:Task(this)))
	call:void(Task::ThrowIfExceptional, ldloc:Task(this), ldc.i4:bool(1))
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

		// Token: 0x060013AF RID: 5039 RVA: 0x000294EC File Offset: 0x000276EC
		private bool WrappedTryRunInline()
		{
			TaskScheduler taskScheduler;
			do
			{
				taskScheduler = this.m_taskScheduler;
			}
			while (taskScheduler == null);
			int num = 1;
			return taskScheduler.TryRunInline(this, num != 0);
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x00029510 File Offset: 0x00027710
		internal bool InternalWait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			return TaskTrace.Enabled;
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x000295B4 File Offset: 0x000277B4
		private bool SpinThenBlockingWait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			int tickCount = Environment.TickCount;
			return this.SpinWait(millisecondsTimeout);
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x00029608 File Offset: 0x00027808
		private bool SpinWait(int millisecondsTimeout)
		{
			bool isCompleted = this.IsCompleted;
			return true;
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x0002962C File Offset: 0x0002782C
		internal bool InternalCancel(bool bCancelNonExecutingOnly)
		{
			int stateFlags = this.m_stateFlags;
			if (this.m_taskScheduler != null)
			{
			}
			if (false)
			{
				int num = 64;
				int num2 = 66;
				return this.AtomicStateUpdate(num, num2);
			}
			this.RecordInternalCancellationRequest();
			int num3 = 64;
			int num4 = 66;
			return this.AtomicStateUpdate(num3, num4);
		}

		// Token: 0x060013B4 RID: 5044 RVA: 0x00029698 File Offset: 0x00027898
		internal void RecordInternalCancellationRequest()
		{
			while (this.m_contingentProperties != null)
			{
			}
			this.EnsureContingentPropertiesInitializedCore(true).m_internalCancellationRequested = 1;
		}

		// Token: 0x060013B5 RID: 5045 RVA: 0x000296BC File Offset: 0x000278BC
		internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord)
		{
			this.RecordInternalCancellationRequest();
			if (!true)
			{
			}
			this.m_contingentProperties.m_cancellationToken = tokenToRecord;
		}

		// Token: 0x060013B6 RID: 5046 RVA: 0x000296E0 File Offset: 0x000278E0
		internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord, object cancellationException)
		{
			this.RecordInternalCancellationRequest(tokenToRecord);
			if (cancellationException != null)
			{
				this.AddException(cancellationException, true);
				return;
			}
		}

		// Token: 0x060013B7 RID: 5047 RVA: 0x00029700 File Offset: 0x00027900
		internal void CancellationCleanupLogic()
		{
			int stateFlags = this.m_stateFlags;
			if (this.m_taskId == 0 || stateFlags != 0)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (true)
			{
				if (!true)
				{
				}
				DebuggerSupport.RemoveFromActiveTasksNonInlined(this);
			}
			this.FinishStageThree();
		}

		// Token: 0x060013B8 RID: 5048 RVA: 0x00029738 File Offset: 0x00027938
		private void SetCancellationAcknowledged()
		{
			int stateFlags = this.m_stateFlags;
		}

		// Token: 0x060013B9 RID: 5049 RVA: 0x0002974C File Offset: 0x0002794C
		internal void FinishContinuations()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int stateFlags = this.m_stateFlags;
			int stateFlags2 = this.m_stateFlags;
		}

		// Token: 0x060013BA RID: 5050 RVA: 0x000297D8 File Offset: 0x000279D8
		private void LogFinishCompletionNotification()
		{
			if (true)
			{
				return;
			}
		}

		// Token: 0x060013BB RID: 5051 RVA: 0x000297EC File Offset: 0x000279EC
		public Task ContinueWith(Action<Task> continuationAction)
		{
			if (!true)
			{
			}
			TaskScheduler taskScheduler = TaskScheduler.Current;
			Task task;
			return task;
		}

		// Token: 0x060013BC RID: 5052 RVA: 0x00029804 File Offset: 0x00027A04
		private Task ContinueWith(Action<Task> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
		{
			while (continuationAction != null && scheduler == null)
			{
			}
			return "continuationAction";
		}

		// Token: 0x060013BD RID: 5053 RVA: 0x0002981C File Offset: 0x00027A1C
		public Task ContinueWith(Action<Task, object> continuationAction, object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return this.ContinueWith(continuationAction, state, scheduler, cancellationToken, continuationOptions);
		}

		// Token: 0x060013BE RID: 5054 RVA: 0x00029838 File Offset: 0x00027A38
		private Task ContinueWith(Action<Task, object> continuationAction, object state, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
		{
			while (continuationAction != null && scheduler == null)
			{
			}
			return "continuationAction";
		}

		// Token: 0x060013BF RID: 5055 RVA: 0x00029850 File Offset: 0x00027A50
		internal static void CreationOptionsFromContinuationOptions(TaskContinuationOptions continuationOptions, [Out] TaskCreationOptions creationOptions, [Out] InternalTaskOptions internalOptions)
		{
			creationOptions.value__ = 95;
			internalOptions.value__ = 4608;
		}

		// Token: 0x060013C0 RID: 5056 RVA: 0x00029874 File Offset: 0x00027A74
		internal void ContinueWithCore(Task continuationTask, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions options)
		{
			bool isCompleted = this.IsCompleted;
		}

		// Token: 0x060013C1 RID: 5057 RVA: 0x00029890 File Offset: 0x00027A90
		internal void AddCompletionAction(ITaskCompletionAction action)
		{
			long num = 0L;
			this.AddCompletionAction(action, num != 0L);
		}

		// Token: 0x060013C2 RID: 5058 RVA: 0x000298A8 File Offset: 0x00027AA8
		private void AddCompletionAction(ITaskCompletionAction action, bool addBeforeOthers)
		{
		}

		// Token: 0x060013C3 RID: 5059 RVA: 0x000298B8 File Offset: 0x00027AB8
		private bool AddTaskContinuationComplex(object tc, bool addBeforeOthers)
		{
			object continuationObject = this.m_continuationObject;
			if (!true)
			{
			}
			if (continuationObject != null)
			{
			}
			if (!false)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060013C4 RID: 5060 RVA: 0x000298EC File Offset: 0x00027AEC
		private bool AddTaskContinuation(object tc, bool addBeforeOthers)
		{
			bool isCompleted = this.IsCompleted;
			if (this.m_continuationObject == null)
			{
			}
			return this.AddTaskContinuationComplex(tc, addBeforeOthers);
		}

		// Token: 0x060013C5 RID: 5061 RVA: 0x00029914 File Offset: 0x00027B14
		internal void RemoveContinuation(object continuationObject)
		{
			object continuationObject2 = this.m_continuationObject;
			if (!true)
			{
			}
			if (continuationObject2 != null)
			{
			}
		}

		// Token: 0x060013C6 RID: 5062 RVA: 0x0000207A File Offset: 0x0000027A
		public static Task<TResult> FromResult<TResult>(TResult result)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060013C7 RID: 5063 RVA: 0x00029954 File Offset: 0x00027B54
		public static Task FromException(Exception exception)
		{
			/*
An exception occurred when decompiling this method (060013C7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task System.Threading.Tasks.Task::FromException(System.Exception)

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

		// Token: 0x060013C8 RID: 5064 RVA: 0x00029964 File Offset: 0x00027B64
		public static Task<TResult> FromException<TResult>(Exception exception)
		{
			/*
An exception occurred when decompiling this method (060013C8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task`1<TResult> System.Threading.Tasks.Task::FromException<TResult>(System.Exception)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:object(var_0_06, ldfld:object(Exception::_stackTrace, ldloc:Exception(exception)))
	stloc:object(var_1_0D, ldfld:object(Exception::_stackTrace, ldloc:Exception(exception)))
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

		// Token: 0x060013C9 RID: 5065 RVA: 0x0000207A File Offset: 0x0000027A
		internal static Task FromCancellation(CancellationToken cancellationToken)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060013CA RID: 5066 RVA: 0x00029980 File Offset: 0x00027B80
		public static Task FromCanceled(CancellationToken cancellationToken)
		{
			if (!true)
			{
			}
			Task task;
			return task;
		}

		// Token: 0x060013CB RID: 5067 RVA: 0x0000207A File Offset: 0x0000027A
		internal static Task<TResult> FromCancellation<TResult>(CancellationToken cancellationToken)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060013CC RID: 5068 RVA: 0x00029994 File Offset: 0x00027B94
		public static Task<TResult> FromCanceled<TResult>(CancellationToken cancellationToken)
		{
			/*
An exception occurred when decompiling this method (060013CC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task`1<TResult> System.Threading.Tasks.Task::FromCanceled<TResult>(System.Threading.CancellationToken)

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

		// Token: 0x060013CD RID: 5069 RVA: 0x000299A4 File Offset: 0x00027BA4
		internal static Task<TResult> FromCancellation<TResult>(OperationCanceledException exception)
		{
			/*
An exception occurred when decompiling this method (060013CD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task`1<TResult> System.Threading.Tasks.Task::FromCancellation<TResult>(System.OperationCanceledException)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:object(var_0_06, ldfld:object(Exception::_stackTrace, ldloc:OperationCanceledException[exp:Exception](exception)))
	stloc:object(var_1_0D, ldfld:object(Exception::_stackTrace, ldloc:OperationCanceledException[exp:Exception](exception)))
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

		// Token: 0x060013CE RID: 5070 RVA: 0x000299C0 File Offset: 0x00027BC0
		public static Task Run(Action action)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			Task task;
			return task;
		}

		// Token: 0x060013CF RID: 5071 RVA: 0x000299D8 File Offset: 0x00027BD8
		public static Task<TResult> Run<TResult>(Func<TResult> function)
		{
			if (!true)
			{
			}
			if (!true)
			{
				return;
			}
		}

		// Token: 0x060013D0 RID: 5072 RVA: 0x000299EC File Offset: 0x00027BEC
		public static Task Run(Func<Task> function)
		{
			if (!true)
			{
			}
			Task task;
			return task;
		}

		// Token: 0x060013D1 RID: 5073 RVA: 0x00029A00 File Offset: 0x00027C00
		public static Task Run(Func<Task> function, CancellationToken cancellationToken)
		{
			if (!true)
			{
			}
			Task task;
			return task;
		}

		// Token: 0x060013D2 RID: 5074 RVA: 0x00029A20 File Offset: 0x00027C20
		public static Task<TResult> Run<TResult>(Func<Task<TResult>> function)
		{
			/*
An exception occurred when decompiling this method (060013D2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task`1<TResult> System.Threading.Tasks.Task::Run<TResult>(System.Func`1<System.Threading.Tasks.Task`1<TResult>>)

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

		// Token: 0x060013D3 RID: 5075 RVA: 0x00029A30 File Offset: 0x00027C30
		public static Task<TResult> Run<TResult>(Func<Task<TResult>> function, CancellationToken cancellationToken)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x060013D4 RID: 5076 RVA: 0x00029A50 File Offset: 0x00027C50
		public static Task Delay(int millisecondsDelay)
		{
			if (!true)
			{
			}
			Task task;
			return task;
		}

		// Token: 0x060013D5 RID: 5077 RVA: 0x00029A64 File Offset: 0x00027C64
		public static Task Delay(int millisecondsDelay, CancellationToken cancellationToken)
		{
			if (!true)
			{
			}
			Task task;
			return task;
		}

		// Token: 0x060013D6 RID: 5078 RVA: 0x00029A78 File Offset: 0x00027C78
		public static Task<Task> WhenAny(params Task[] tasks)
		{
			Task<Task> task;
			return task;
		}

		// Token: 0x060013D7 RID: 5079 RVA: 0x00029A9C File Offset: 0x00027C9C
		public static Task<Task> WhenAny(IEnumerable<Task> tasks)
		{
			long num = 0L;
			int num2 = 10;
			if (num != 0L)
			{
				throw new OutOfMemoryException();
			}
			Task<Task> task;
			if (num2 == 0)
			{
				return task;
			}
			return task;
		}

		// Token: 0x060013D8 RID: 5080 RVA: 0x00029AEC File Offset: 0x00027CEC
		[FriendAccessAllowed]
		internal static bool AddToActiveTasks(Task task)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!false)
			{
				return true;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x00029B1C File Offset: 0x00027D1C
		[FriendAccessAllowed]
		internal static void RemoveFromActiveTasks(int taskId)
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

		// Token: 0x060013DA RID: 5082 RVA: 0x00029B50 File Offset: 0x00027D50
		public void MarkAborted(ThreadAbortException e)
		{
		}

		// Token: 0x060013DB RID: 5083 RVA: 0x00029B60 File Offset: 0x00027D60
		private void ExecuteWithThreadLocal(Task currentTaskSlot)
		{
			if (this.CapturedContext != null)
			{
				if (!true)
				{
				}
				return;
			}
			this.Execute();
			this.Finish(true);
		}

		// Token: 0x060013DC RID: 5084 RVA: 0x00029B98 File Offset: 0x00027D98
		// Note: this type is marked as 'beforefieldinit'.
		static Task()
		{
		}

		// Token: 0x04000A59 RID: 2649
		internal static int s_taskIdCounter;

		// Token: 0x04000A5A RID: 2650
		private int m_taskId;

		// Token: 0x04000A5B RID: 2651
		internal Delegate m_action;

		// Token: 0x04000A5C RID: 2652
		internal object m_stateObject;

		// Token: 0x04000A5D RID: 2653
		internal TaskScheduler m_taskScheduler;

		// Token: 0x04000A5E RID: 2654
		internal readonly Task m_parent;

		// Token: 0x04000A5F RID: 2655
		internal int m_stateFlags;

		// Token: 0x04000A60 RID: 2656
		private object m_continuationObject;

		// Token: 0x04000A61 RID: 2657
		private static readonly object s_taskCompletionSentinel;

		// Token: 0x04000A62 RID: 2658
		internal static bool s_asyncDebuggingEnabled;

		// Token: 0x04000A63 RID: 2659
		internal Task.ContingentProperties m_contingentProperties;

		// Token: 0x04000A64 RID: 2660
		private static readonly Action<object> s_taskCancelCallback;

		// Token: 0x04000A65 RID: 2661
		[ThreadStatic]
		internal static Task t_currentTask;

		// Token: 0x04000A66 RID: 2662
		[ThreadStatic]
		private static StackGuard t_stackGuard;

		// Token: 0x04000A67 RID: 2663
		private static readonly Func<Task.ContingentProperties> s_createContingentProperties;

		// Token: 0x04000A68 RID: 2664
		[CompilerGenerated]
		private static readonly TaskFactory <Factory>k__BackingField;

		// Token: 0x04000A69 RID: 2665
		[CompilerGenerated]
		private static readonly Task <CompletedTask>k__BackingField;

		// Token: 0x04000A6A RID: 2666
		private static readonly Predicate<Task> s_IsExceptionObservedByParentPredicate;

		// Token: 0x04000A6B RID: 2667
		private static ContextCallback s_ecCallback;

		// Token: 0x04000A6C RID: 2668
		private static readonly Predicate<object> s_IsTaskContinuationNullPredicate;

		// Token: 0x04000A6D RID: 2669
		private static readonly Dictionary<int, Task> s_currentActiveTasks;

		// Token: 0x04000A6E RID: 2670
		private static readonly object s_activeTasksLock;

		// Token: 0x02000233 RID: 563
		internal class ContingentProperties
		{
			// Token: 0x060013DD RID: 5085 RVA: 0x00029BA8 File Offset: 0x00027DA8
			internal void SetCompleted()
			{
				ManualResetEventSlim completionEvent = this.m_completionEvent;
				if (completionEvent != null)
				{
					completionEvent.Set();
					return;
				}
			}

			// Token: 0x060013DE RID: 5086 RVA: 0x00029BC8 File Offset: 0x00027DC8
			internal void UnregisterCancellationCallback()
			{
				if (this.m_cancellationRegistration != null)
				{
				}
			}

			// Token: 0x060013DF RID: 5087 RVA: 0x00029BF0 File Offset: 0x00027DF0
			public ContingentProperties()
			{
			}

			// Token: 0x04000A6F RID: 2671
			internal ExecutionContext m_capturedContext;

			// Token: 0x04000A70 RID: 2672
			internal ManualResetEventSlim m_completionEvent;

			// Token: 0x04000A71 RID: 2673
			internal TaskExceptionHolder m_exceptionsHolder;

			// Token: 0x04000A72 RID: 2674
			internal CancellationToken m_cancellationToken;

			// Token: 0x04000A73 RID: 2675
			internal object m_cancellationRegistration;

			// Token: 0x04000A74 RID: 2676
			internal int m_internalCancellationRequested;

			// Token: 0x04000A75 RID: 2677
			internal int m_completionCountdown = 1;

			// Token: 0x04000A76 RID: 2678
			internal LowLevelListWithIList<Task> m_exceptionalChildren;
		}

		// Token: 0x02000234 RID: 564
		private sealed class SetOnInvokeMres : ManualResetEventSlim, ITaskCompletionAction
		{
			// Token: 0x060013E0 RID: 5088 RVA: 0x00029C0C File Offset: 0x00027E0C
			internal SetOnInvokeMres()
			{
				if (!true)
				{
				}
				long num = 0L;
				long num2 = 0L;
				base..ctor(num != 0L, (int)num2);
			}

			// Token: 0x060013E1 RID: 5089 RVA: 0x00029C28 File Offset: 0x00027E28
			public void Invoke(Task completingTask)
			{
				base.Set();
			}

			// Token: 0x170001F2 RID: 498
			// (get) Token: 0x060013E2 RID: 5090 RVA: 0x00029C3C File Offset: 0x00027E3C
			public bool InvokeMayRunArbitraryCode
			{
				get
				{
				}
			}
		}

		// Token: 0x02000235 RID: 565
		private sealed class DelayPromise : Task<VoidTaskResult>
		{
			// Token: 0x060013E3 RID: 5091 RVA: 0x00029C4C File Offset: 0x00027E4C
			internal DelayPromise(CancellationToken token)
			{
				if (true || !true)
				{
				}
				if (!true)
				{
				}
				if (true)
				{
					if (!true)
					{
					}
					DebuggerSupport.AddToActiveTasksNonInlined(this);
					return;
				}
			}

			// Token: 0x060013E4 RID: 5092 RVA: 0x00029C78 File Offset: 0x00027E78
			internal void Complete()
			{
				CancellationToken token = this.Token;
				long num = 0L;
				bool flag = base.TrySetCanceled(token, num);
			}

			// Token: 0x04000A77 RID: 2679
			internal readonly CancellationToken Token = token;

			// Token: 0x04000A78 RID: 2680
			internal CancellationTokenRegistration Registration;

			// Token: 0x04000A79 RID: 2681
			internal Timer Timer;
		}

		// Token: 0x02000236 RID: 566
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060013E5 RID: 5093 RVA: 0x00029CCC File Offset: 0x00027ECC
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060013E6 RID: 5094 RVA: 0x00029CDC File Offset: 0x00027EDC
			public <>c()
			{
			}

			// Token: 0x060013E7 RID: 5095 RVA: 0x00029CF0 File Offset: 0x00027EF0
			internal void <Delay>b__247_0(object state)
			{
			}

			// Token: 0x060013E8 RID: 5096 RVA: 0x00029D04 File Offset: 0x00027F04
			internal void <Delay>b__247_1(object state)
			{
			}

			// Token: 0x060013E9 RID: 5097 RVA: 0x0000207A File Offset: 0x0000027A
			internal Task.ContingentProperties <.cctor>b__271_0()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x060013EA RID: 5098 RVA: 0x00029D18 File Offset: 0x00027F18
			internal bool <.cctor>b__271_1(Task t)
			{
				/*
An exception occurred when decompiling this method (060013EA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Threading.Tasks.Task/<>c::<.cctor>b__271_1(System.Threading.Tasks.Task)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Task::m_stateFlags, ldloc:Task(t)))
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

			// Token: 0x060013EB RID: 5099 RVA: 0x0000207A File Offset: 0x0000027A
			internal bool <.cctor>b__271_2(object tc)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x04000A7A RID: 2682
			public static readonly Task.<>c <>9;

			// Token: 0x04000A7B RID: 2683
			public static Action<object> <>9__247_0;

			// Token: 0x04000A7C RID: 2684
			public static TimerCallback <>9__247_1;
		}
	}
}
