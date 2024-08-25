using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System.Threading
{
	// Token: 0x020001E1 RID: 481
	[ComVisible(false)]
	[DebuggerTypeProxy(typeof(SpinLock.SystemThreading_SpinLockDebugView))]
	[DebuggerDisplay("IsHeld = {IsHeld}")]
	public struct SpinLock
	{
		// Token: 0x0600115A RID: 4442 RVA: 0x00024CF8 File Offset: 0x00022EF8
		public SpinLock(bool enableThreadOwnerTracking)
		{
			this.m_owner = 32768;
		}

		// Token: 0x0600115B RID: 4443 RVA: 0x00024D10 File Offset: 0x00022F10
		public void Enter(bool lockTaken)
		{
			Thread.BeginCriticalRegion();
		}

		// Token: 0x0600115C RID: 4444 RVA: 0x00024D2C File Offset: 0x00022F2C
		public void TryEnter(int millisecondsTimeout, bool lockTaken)
		{
			Thread.BeginCriticalRegion();
		}

		// Token: 0x0600115D RID: 4445 RVA: 0x00024D48 File Offset: 0x00022F48
		private void ContinueTryEnter(int millisecondsTimeout, bool lockTaken)
		{
			Thread.EndCriticalRegion();
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x00024DDC File Offset: 0x00022FDC
		private void DecrementWaiters()
		{
		}

		// Token: 0x0600115F RID: 4447 RVA: 0x00024DF0 File Offset: 0x00022FF0
		private void ContinueTryEnterWithThreadTracking(int millisecondsTimeout, uint startTime, bool lockTaken)
		{
			Thread currentThread;
			do
			{
				currentThread = Thread.CurrentThread;
			}
			while (currentThread.internal_thread != null);
			int managed_id = currentThread.internal_thread.managed_id;
			Thread.BeginCriticalRegion();
			int num;
			if (num != 0)
			{
				Thread.EndCriticalRegion();
				if (millisecondsTimeout != 0)
				{
					int tickCount = Environment.TickCount;
				}
			}
		}

		// Token: 0x06001160 RID: 4448 RVA: 0x00024E40 File Offset: 0x00023040
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public void Exit(bool useMemoryBarrier)
		{
		}

		// Token: 0x06001161 RID: 4449 RVA: 0x00024E5C File Offset: 0x0002305C
		private void ExitSlowPath(bool useMemoryBarrier)
		{
			bool isHeldByCurrentThread = this.IsHeldByCurrentThread;
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06001162 RID: 4450 RVA: 0x00024E88 File Offset: 0x00023088
		public bool IsHeldByCurrentThread
		{
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
			get
			{
				/*
An exception occurred when decompiling this method (06001162)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Threading.SpinLock::get_IsHeldByCurrentThread()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_1_19, ldfld:int32(InternalThread::managed_id, ldfld:InternalThread(Thread::internal_thread, ldloc:Thread(var_0_05))))
	stloc:string(var_2_24, call:string(Environment::GetResourceString, ldstr:string("Thread tracking is disabled.")))
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

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06001163 RID: 4451 RVA: 0x0000207A File Offset: 0x0000027A
		public bool IsThreadOwnerTrackingEnabled
		{
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06001164 RID: 4452 RVA: 0x00024EBC File Offset: 0x000230BC
		// Note: this type is marked as 'beforefieldinit'.
		static SpinLock()
		{
		}

		// Token: 0x04000963 RID: 2403
		private int m_owner;

		// Token: 0x04000964 RID: 2404
		private static int MAXIMUM_WAITERS;

		// Token: 0x020001E2 RID: 482
		internal class SystemThreading_SpinLockDebugView
		{
		}
	}
}
