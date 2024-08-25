using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using Cpp2IlInjected;

namespace System.Threading
{
	// Token: 0x020001F2 RID: 498
	public class SynchronizationContext
	{
		// Token: 0x060011C3 RID: 4547 RVA: 0x00025C24 File Offset: 0x00023E24
		public SynchronizationContext()
		{
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x00025C38 File Offset: 0x00023E38
		public bool IsWaitNotificationRequired()
		{
			/*
An exception occurred when decompiling this method (060011C4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Threading.SynchronizationContext::IsWaitNotificationRequired()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:SynchronizationContextProperties(var_0_06, ldfld:SynchronizationContextProperties(SynchronizationContext::_props, ldloc:SynchronizationContext(this)))
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

		// Token: 0x060011C5 RID: 4549 RVA: 0x00025C4C File Offset: 0x00023E4C
		public virtual void Send(SendOrPostCallback d, object state)
		{
			IntPtr method = d.method;
			IntPtr invoke_impl = d.invoke_impl;
			IntPtr method_code = d.method_code;
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x00025C70 File Offset: 0x00023E70
		public virtual void Post(SendOrPostCallback d, object state)
		{
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x00025C80 File Offset: 0x00023E80
		public virtual void OperationStarted()
		{
		}

		// Token: 0x060011C8 RID: 4552 RVA: 0x00025C90 File Offset: 0x00023E90
		public virtual void OperationCompleted()
		{
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x00025CA0 File Offset: 0x00023EA0
		[CLSCompliant(false)]
		[PrePrepareMethod]
		public virtual int Wait(IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout)
		{
			while (waitHandles == null)
			{
			}
			int num;
			return num;
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x00025CB4 File Offset: 0x00023EB4
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		[CLSCompliant(false)]
		[PrePrepareMethod]
		protected static int WaitHelper(IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout)
		{
			int num;
			return num;
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x00025CC4 File Offset: 0x00023EC4
		public static void SetSynchronizationContext(SynchronizationContext syncContext)
		{
			ExecutionContext mutableExecutionContext = Thread.CurrentThread.GetMutableExecutionContext();
			mutableExecutionContext._syncContext = syncContext;
			mutableExecutionContext._syncContextNoFlow = syncContext;
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x060011CC RID: 4556 RVA: 0x00025CEC File Offset: 0x00023EEC
		public static SynchronizationContext Current
		{
			get
			{
				ExecutionContext executionContext = Thread.CurrentThread.m_ExecutionContext;
				if (executionContext != null)
				{
					SynchronizationContext syncContext = executionContext._syncContext;
					if (syncContext != null)
					{
						return syncContext;
					}
				}
				return SynchronizationContext.GetThreadLocalContext();
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x060011CD RID: 4557 RVA: 0x00025D18 File Offset: 0x00023F18
		internal static SynchronizationContext CurrentNoFlow
		{
			[FriendAccessAllowed]
			get
			{
				ExecutionContext executionContext = Thread.CurrentThread.m_ExecutionContext;
				if (executionContext != null)
				{
					SynchronizationContext syncContextNoFlow = executionContext._syncContextNoFlow;
					if (syncContextNoFlow != null)
					{
						return syncContextNoFlow;
					}
				}
				return SynchronizationContext.GetThreadLocalContext();
			}
		}

		// Token: 0x060011CE RID: 4558 RVA: 0x00025D44 File Offset: 0x00023F44
		private static SynchronizationContext GetThreadLocalContext()
		{
			/*
An exception occurred when decompiling this method (060011CE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.SynchronizationContext System.Threading.SynchronizationContext::GetThreadLocalContext()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:OSSpecificSynchronizationContext(var_0_08, call:OSSpecificSynchronizationContext(OSSpecificSynchronizationContext::Get))
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

		// Token: 0x060011CF RID: 4559 RVA: 0x0000207A File Offset: 0x0000027A
		public virtual SynchronizationContext CreateCopy()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x060011D0 RID: 4560 RVA: 0x00025D5C File Offset: 0x00023F5C
		internal static SynchronizationContext CurrentExplicit
		{
			get
			{
				return SynchronizationContext.Current;
			}
		}

		// Token: 0x04000990 RID: 2448
		private SynchronizationContextProperties _props;

		// Token: 0x04000991 RID: 2449
		private static Type s_cachedPreparedType1;

		// Token: 0x04000992 RID: 2450
		private static Type s_cachedPreparedType2;

		// Token: 0x04000993 RID: 2451
		private static Type s_cachedPreparedType3;

		// Token: 0x04000994 RID: 2452
		private static Type s_cachedPreparedType4;

		// Token: 0x04000995 RID: 2453
		private static Type s_cachedPreparedType5;
	}
}
