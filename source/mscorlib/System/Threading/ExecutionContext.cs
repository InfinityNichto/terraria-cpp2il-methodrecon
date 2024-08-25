using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.ExceptionServices;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using Cpp2IlInjected;

namespace System.Threading
{
	// Token: 0x020001EC RID: 492
	[Serializable]
	public sealed class ExecutionContext : IDisposable, ISerializable
	{
		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06001182 RID: 4482 RVA: 0x0002544C File Offset: 0x0002364C
		// (set) Token: 0x06001183 RID: 4483 RVA: 0x00025460 File Offset: 0x00023660
		internal bool isNewCapture
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001182)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Threading.ExecutionContext::get_isNewCapture()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Flags(var_0_06, ldfld:Flags(ExecutionContext::_flags, ldloc:ExecutionContext(this)))
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
			set
			{
				ExecutionContext.Flags flags = this._flags;
				this._flags = flags;
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06001184 RID: 4484 RVA: 0x0002547C File Offset: 0x0002367C
		// (set) Token: 0x06001185 RID: 4485 RVA: 0x00025490 File Offset: 0x00023690
		internal bool isFlowSuppressed
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001184)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Threading.ExecutionContext::get_isFlowSuppressed()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Flags(var_0_06, ldfld:Flags(ExecutionContext::_flags, ldloc:ExecutionContext(this)))
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
			set
			{
				ExecutionContext.Flags flags = this._flags;
				this._flags = flags;
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06001186 RID: 4486 RVA: 0x000254AC File Offset: 0x000236AC
		internal bool IsPreAllocatedDefault
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001186)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Threading.ExecutionContext::get_IsPreAllocatedDefault()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Flags(var_0_06, ldfld:Flags(ExecutionContext::_flags, ldloc:ExecutionContext(this)))
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

		// Token: 0x06001187 RID: 4487 RVA: 0x000254C0 File Offset: 0x000236C0
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		internal ExecutionContext()
		{
		}

		// Token: 0x06001188 RID: 4488 RVA: 0x000254D4 File Offset: 0x000236D4
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		internal ExecutionContext(bool isPreAllocatedDefault)
		{
			this._flags = ExecutionContext.Flags.IsPreAllocatedDefault;
		}

		// Token: 0x06001189 RID: 4489 RVA: 0x000254F0 File Offset: 0x000236F0
		internal static void SetLocalValue(IAsyncLocal local, object newValue, bool needChangeNotifications)
		{
			ExecutionContext mutableExecutionContext = Thread.CurrentThread.GetMutableExecutionContext();
			if (mutableExecutionContext._localValues != null)
			{
				return;
			}
			if (mutableExecutionContext._localValues != null)
			{
				return;
			}
			if (mutableExecutionContext._localChangeNotifications != null)
			{
				return;
			}
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x00025528 File Offset: 0x00023728
		[HandleProcessCorruptedStateExceptions]
		internal static void OnAsyncLocalContextChanged(ExecutionContext previous, ExecutionContext current)
		{
			if (previous != null)
			{
				if (previous._localChangeNotifications != null)
				{
					if (previous._localValues != null)
					{
					}
					if (current != null && current._localValues != null)
					{
						return;
					}
					return;
				}
			}
			if (current == null || current._localChangeNotifications == null)
			{
				return;
			}
			if (previous == null || previous._localValues != null)
			{
			}
			if (current._localValues != null)
			{
				return;
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x0600118B RID: 4491 RVA: 0x000255D4 File Offset: 0x000237D4
		// (set) Token: 0x0600118C RID: 4492 RVA: 0x000255E8 File Offset: 0x000237E8
		internal LogicalCallContext LogicalCallContext
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600118B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Runtime.Remoting.Messaging.LogicalCallContext System.Threading.ExecutionContext::get_LogicalCallContext()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:LogicalCallContext[exp:bool](ExecutionContext::_logicalCallContext, ldloc:ExecutionContext(this)))
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
			set
			{
				this._logicalCallContext = value;
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x0600118D RID: 4493 RVA: 0x000255FC File Offset: 0x000237FC
		// (set) Token: 0x0600118E RID: 4494 RVA: 0x00025610 File Offset: 0x00023810
		internal IllogicalCallContext IllogicalCallContext
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600118D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Runtime.Remoting.Messaging.IllogicalCallContext System.Threading.ExecutionContext::get_IllogicalCallContext()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:IllogicalCallContext[exp:bool](ExecutionContext::_illogicalCallContext, ldloc:ExecutionContext(this)))
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
			set
			{
				this._illogicalCallContext = value;
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x0600118F RID: 4495 RVA: 0x00025624 File Offset: 0x00023824
		// (set) Token: 0x06001190 RID: 4496 RVA: 0x00025638 File Offset: 0x00023838
		internal SynchronizationContext SynchronizationContext
		{
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
			get
			{
				return this._syncContext;
			}
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
			set
			{
				this._syncContext = value;
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06001191 RID: 4497 RVA: 0x0002564C File Offset: 0x0002384C
		// (set) Token: 0x06001192 RID: 4498 RVA: 0x00025660 File Offset: 0x00023860
		internal SynchronizationContext SynchronizationContextNoFlow
		{
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
			get
			{
				return this._syncContextNoFlow;
			}
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
			set
			{
				this._syncContextNoFlow = value;
			}
		}

		// Token: 0x06001193 RID: 4499 RVA: 0x00025674 File Offset: 0x00023874
		public void Dispose()
		{
		}

		// Token: 0x06001194 RID: 4500 RVA: 0x00025684 File Offset: 0x00023884
		public static void Run(ExecutionContext executionContext, ContextCallback callback, object state)
		{
			if (executionContext != null)
			{
				ExecutionContext.Flags flags = executionContext._flags;
				long num = 0L;
				ExecutionContext.Run(executionContext, callback, state, num != 0L);
				return;
			}
		}

		// Token: 0x06001195 RID: 4501 RVA: 0x000256B4 File Offset: 0x000238B4
		[FriendAccessAllowed]
		internal static void Run(ExecutionContext executionContext, ContextCallback callback, object state, bool preserveSyncCtx)
		{
			if (!true)
			{
			}
			ExecutionContext.RunInternal(executionContext, callback, state, preserveSyncCtx);
		}

		// Token: 0x06001196 RID: 4502 RVA: 0x000256D0 File Offset: 0x000238D0
		internal static void RunInternal(ExecutionContext executionContext, ContextCallback callback, object state)
		{
			if (!true)
			{
			}
			long num = 0L;
			ExecutionContext.RunInternal(executionContext, callback, state, num != 0L);
		}

		// Token: 0x06001197 RID: 4503 RVA: 0x000256EC File Offset: 0x000238EC
		[HandleProcessCorruptedStateExceptions]
		internal static void RunInternal(ExecutionContext executionContext, ContextCallback callback, object state, bool preserveSyncCtx)
		{
			ExecutionContext.Flags flags = executionContext._flags;
			executionContext._flags = flags;
			Thread currentThread = Thread.CurrentThread;
			RuntimeHelpers.PrepareConstrainedRegions();
			ExecutionContext executionContext2 = currentThread.m_ExecutionContext;
			if (executionContext2 != null)
			{
			}
			if (executionContext2 != null)
			{
				Dictionary<IAsyncLocal, object> localValues = executionContext2._localValues;
				return;
			}
			Dictionary<IAsyncLocal, object> localValues2 = executionContext._localValues;
			if (executionContext._flags == ExecutionContext.Flags.None)
			{
			}
			IntPtr method_code = callback.method_code;
			IntPtr invoke_impl = callback.invoke_impl;
			IntPtr method = callback.method;
		}

		// Token: 0x06001198 RID: 4504 RVA: 0x00025784 File Offset: 0x00023984
		internal static void EstablishCopyOnWriteScope(ExecutionContextSwitcher ecsw)
		{
			Thread currentThread = Thread.CurrentThread;
			ExecutionContext executionContext = currentThread.m_ExecutionContext;
			ecsw.outerEC = executionContext;
			bool executionContextBelongsToOuterScope = currentThread.m_ExecutionContextBelongsToOuterScope;
			ecsw.outerECBelongsToScope = executionContextBelongsToOuterScope;
			currentThread.m_ExecutionContextBelongsToOuterScope = true;
			ecsw.thread = currentThread;
		}

		// Token: 0x06001199 RID: 4505 RVA: 0x000257C4 File Offset: 0x000239C4
		private static void EstablishCopyOnWriteScope(Thread currentThread, bool knownNullWindowsIdentity, ExecutionContextSwitcher ecsw)
		{
			ExecutionContext executionContext = currentThread.m_ExecutionContext;
			ecsw.outerEC = executionContext;
			bool executionContextBelongsToOuterScope = currentThread.m_ExecutionContextBelongsToOuterScope;
			ecsw.outerECBelongsToScope = executionContextBelongsToOuterScope;
			currentThread.m_ExecutionContextBelongsToOuterScope = true;
			ecsw.thread = currentThread;
		}

		// Token: 0x0600119A RID: 4506 RVA: 0x000257FC File Offset: 0x000239FC
		[HandleProcessCorruptedStateExceptions]
		internal static ExecutionContextSwitcher SetExecutionContext(ExecutionContext executionContext, bool preserveSyncCtx)
		{
			Thread currentThread = Thread.CurrentThread;
			ExecutionContext executionContext2 = currentThread.m_ExecutionContext;
			bool executionContextBelongsToOuterScope = currentThread.m_ExecutionContextBelongsToOuterScope;
			if (executionContext2 != null)
			{
				SynchronizationContext syncContext = executionContext2._syncContext;
			}
			long num = 0L;
			executionContext._syncContext = num;
			if (executionContext2 != null)
			{
				SynchronizationContext syncContextNoFlow = executionContext2._syncContextNoFlow;
			}
			long num2 = 0L;
			executionContext._syncContextNoFlow = num2;
			currentThread.m_ExecutionContext = executionContext;
			RuntimeHelpers.PrepareConstrainedRegions();
			if (num2 == 0L)
			{
			}
			ExecutionContext.OnAsyncLocalContextChanged(executionContext2, executionContext);
			throw new OutOfMemoryException();
		}

		// Token: 0x0600119B RID: 4507 RVA: 0x0002586C File Offset: 0x00023A6C
		public ExecutionContext CreateCopy()
		{
			ExecutionContext.Flags flags = this._flags;
			if (this._syncContext != null)
			{
			}
			if (this._logicalCallContext == null || this.LogicalCallContext.Clone() != null)
			{
			}
			string resourceString = Environment.GetResourceString("Only newly captured contexts can be copied");
			throw new InvalidCastException();
		}

		// Token: 0x0600119C RID: 4508 RVA: 0x000258B0 File Offset: 0x00023AB0
		internal ExecutionContext CreateMutableCopy()
		{
			SynchronizationContext syncContext = this._syncContext;
			if (this._logicalCallContext == null || this.LogicalCallContext.Clone() != null)
			{
			}
			if (this._illogicalCallContext != null)
			{
				IllogicalCallContext illogicalCallContext = this.IllogicalCallContext.CreateCopy();
			}
			ExecutionContext.Flags flags = this._flags;
			throw new InvalidCastException();
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x000258FC File Offset: 0x00023AFC
		public static bool IsFlowSuppressed()
		{
			ExecutionContext executionContext = Thread.CurrentThread.m_ExecutionContext;
			if (executionContext != null)
			{
				ExecutionContext.Flags flags = executionContext._flags;
				return;
			}
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x00025920 File Offset: 0x00023B20
		public static ExecutionContext Capture()
		{
			if (!true)
			{
			}
			ExecutionContext executionContext;
			return executionContext;
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x00025934 File Offset: 0x00023B34
		[FriendAccessAllowed]
		internal static ExecutionContext FastCapture()
		{
			if (!true)
			{
			}
			ExecutionContext executionContext;
			return executionContext;
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x00025948 File Offset: 0x00023B48
		internal static ExecutionContext Capture(StackCrawlMark stackMark, ExecutionContext.CaptureOptions options)
		{
			/*
An exception occurred when decompiling this method (060011A0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.ExecutionContext System.Threading.ExecutionContext::Capture(System.Threading.StackCrawlMark,System.Threading.ExecutionContext/CaptureOptions)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_4:
	brtrue(IL_0000, ldloc:class System.Collections.Generic.Dictionary`2<class System.Threading.IAsyncLocal, object>[exp:bool](var_7_34))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

		// Token: 0x060011A1 RID: 4513 RVA: 0x000259B4 File Offset: 0x00023BB4
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			while (info == null)
			{
			}
			LogicalCallContext logicalCallContext = this._logicalCallContext;
			if (logicalCallContext != null)
			{
				Type type;
				info.AddValue("LogicalCallContext", logicalCallContext, type);
				return;
			}
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x000259DC File Offset: 0x00023BDC
		private ExecutionContext(SerializationInfo info, StreamingContext context)
		{
			SerializationInfoEnumerator enumerator = info.GetEnumerator();
			bool flag = enumerator.MoveNext();
			bool flag2 = enumerator.Name.Equals("LogicalCallContext");
			object value = enumerator.Value;
			if (value != null)
			{
				this._logicalCallContext = value;
				return;
			}
			bool flag3 = enumerator.MoveNext();
		}

		// Token: 0x060011A3 RID: 4515 RVA: 0x00025A30 File Offset: 0x00023C30
		internal bool IsDefaultFTContext(bool ignoreSyncCtx)
		{
			if (this._syncContext == null)
			{
				LogicalCallContext logicalCallContext = this._logicalCallContext;
				if (logicalCallContext != null)
				{
					bool hasInfo = logicalCallContext.HasInfo;
				}
				IllogicalCallContext illogicalCallContext = this._illogicalCallContext;
				if (illogicalCallContext != null)
				{
					bool hasUserData = illogicalCallContext.HasUserData;
				}
			}
			return true;
		}

		// Token: 0x060011A4 RID: 4516 RVA: 0x00025A6C File Offset: 0x00023C6C
		// Note: this type is marked as 'beforefieldinit'.
		static ExecutionContext()
		{
		}

		// Token: 0x0400097A RID: 2426
		private SynchronizationContext _syncContext;

		// Token: 0x0400097B RID: 2427
		private SynchronizationContext _syncContextNoFlow;

		// Token: 0x0400097C RID: 2428
		private LogicalCallContext _logicalCallContext;

		// Token: 0x0400097D RID: 2429
		private IllogicalCallContext _illogicalCallContext;

		// Token: 0x0400097E RID: 2430
		private ExecutionContext.Flags _flags;

		// Token: 0x0400097F RID: 2431
		private Dictionary<IAsyncLocal, object> _localValues;

		// Token: 0x04000980 RID: 2432
		private List<IAsyncLocal> _localChangeNotifications;

		// Token: 0x04000981 RID: 2433
		private static readonly ExecutionContext s_dummyDefaultEC;

		// Token: 0x04000982 RID: 2434
		internal static readonly ExecutionContext Default;

		// Token: 0x020001ED RID: 493
		private enum Flags
		{
			// Token: 0x04000984 RID: 2436
			None,
			// Token: 0x04000985 RID: 2437
			IsNewCapture,
			// Token: 0x04000986 RID: 2438
			IsFlowSuppressed,
			// Token: 0x04000987 RID: 2439
			IsPreAllocatedDefault = 4
		}

		// Token: 0x020001EE RID: 494
		internal struct Reader
		{
			// Token: 0x060011A5 RID: 4517 RVA: 0x00025A7C File Offset: 0x00023C7C
			public Reader(ExecutionContext ec)
			{
				this.m_ec = ec;
			}

			// Token: 0x060011A6 RID: 4518 RVA: 0x0000207A File Offset: 0x0000027A
			public ExecutionContext DangerousGetRawExecutionContext()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x170001A9 RID: 425
			// (get) Token: 0x060011A7 RID: 4519 RVA: 0x0000207A File Offset: 0x0000027A
			public bool IsNull
			{
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x060011A8 RID: 4520 RVA: 0x00025A90 File Offset: 0x00023C90
			public bool IsDefaultFTContext(bool ignoreSyncCtx)
			{
				bool flag;
				return flag;
			}

			// Token: 0x170001AA RID: 426
			// (get) Token: 0x060011A9 RID: 4521 RVA: 0x00025AA0 File Offset: 0x00023CA0
			public bool IsFlowSuppressed
			{
				get
				{
				}
			}

			// Token: 0x170001AB RID: 427
			// (get) Token: 0x060011AA RID: 4522 RVA: 0x00025AB0 File Offset: 0x00023CB0
			public SynchronizationContext SynchronizationContext
			{
				get
				{
				}
			}

			// Token: 0x170001AC RID: 428
			// (get) Token: 0x060011AB RID: 4523 RVA: 0x0000207A File Offset: 0x0000027A
			public SynchronizationContext SynchronizationContextNoFlow
			{
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x170001AD RID: 429
			// (get) Token: 0x060011AC RID: 4524 RVA: 0x0000207A File Offset: 0x0000027A
			public LogicalCallContext.Reader LogicalCallContext
			{
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x060011AD RID: 4525 RVA: 0x00025AC0 File Offset: 0x00023CC0
			public bool HasSameLocalValues(ExecutionContext other)
			{
				if (other != null)
				{
					Dictionary<IAsyncLocal, object> localValues = other._localValues;
					return;
				}
			}

			// Token: 0x04000988 RID: 2440
			private ExecutionContext m_ec;
		}

		// Token: 0x020001EF RID: 495
		[Flags]
		internal enum CaptureOptions
		{
			// Token: 0x0400098A RID: 2442
			None = 0,
			// Token: 0x0400098B RID: 2443
			IgnoreSyncCtx = 1,
			// Token: 0x0400098C RID: 2444
			OptimizeDefaultCase = 2
		}
	}
}
