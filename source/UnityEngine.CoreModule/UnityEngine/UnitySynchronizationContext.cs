using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000C5 RID: 197
	internal sealed class UnitySynchronizationContext : SynchronizationContext
	{
		// Token: 0x0600036F RID: 879 RVA: 0x00006FD0 File Offset: 0x000051D0
		private UnitySynchronizationContext(int mainThreadID)
		{
			this.m_MainThreadID = mainThreadID;
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00006FEC File Offset: 0x000051EC
		private UnitySynchronizationContext(List<UnitySynchronizationContext.WorkRequest> queue, int mainThreadID)
		{
			this.m_AsyncWorkQueue = queue;
			this.m_MainThreadID = mainThreadID;
		}

		// Token: 0x06000371 RID: 881 RVA: 0x000021B3 File Offset: 0x000003B3
		public override void Send(SendOrPostCallback callback, object state)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00007010 File Offset: 0x00005210
		public override void OperationStarted()
		{
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00007020 File Offset: 0x00005220
		public override void OperationCompleted()
		{
		}

		// Token: 0x06000374 RID: 884 RVA: 0x000021B3 File Offset: 0x000003B3
		public override void Post(SendOrPostCallback callback, object state)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00007030 File Offset: 0x00005230
		public override SynchronizationContext CreateCopy()
		{
			/*
An exception occurred when decompiling this method (06000375)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.SynchronizationContext UnityEngine.UnitySynchronizationContext::CreateCopy()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.List`1<valuetype UnityEngine.UnitySynchronizationContext/WorkRequest>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.List`1<valuetype UnityEngine.UnitySynchronizationContext/WorkRequest>(UnitySynchronizationContext::m_AsyncWorkQueue, ldloc:UnitySynchronizationContext(this)))
	stloc:int32(var_1_0D, ldfld:int32(UnitySynchronizationContext::m_MainThreadID, ldloc:UnitySynchronizationContext(this)))
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

		// Token: 0x06000376 RID: 886 RVA: 0x000021B3 File Offset: 0x000003B3
		private void Exec()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000377 RID: 887 RVA: 0x0000704C File Offset: 0x0000524C
		private bool HasPendingTasks()
		{
			if (this.m_AsyncWorkQueue._size != 0)
			{
				return true;
			}
			int trackedCount = this.m_TrackedCount;
			return true;
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00007070 File Offset: 0x00005270
		[RequiredByNativeCode]
		private static void InitializeSynchronizationContext()
		{
			int managedThreadId = Thread.CurrentThread.ManagedThreadId;
		}

		// Token: 0x06000379 RID: 889 RVA: 0x0000708C File Offset: 0x0000528C
		[RequiredByNativeCode]
		private static void ExecuteTasks()
		{
			if (SynchronizationContext.Current != null)
			{
			}
		}

		// Token: 0x0600037A RID: 890 RVA: 0x000070A4 File Offset: 0x000052A4
		[RequiredByNativeCode]
		private static bool ExecutePendingTasks(long millisecondsTimeout)
		{
			if (SynchronizationContext.Current != null)
			{
				Thread.Sleep(1);
				return true;
			}
			return true;
		}

		// Token: 0x04000376 RID: 886
		private readonly List<UnitySynchronizationContext.WorkRequest> m_AsyncWorkQueue;

		// Token: 0x04000377 RID: 887
		private readonly List<UnitySynchronizationContext.WorkRequest> m_CurrentFrameWork;

		// Token: 0x04000378 RID: 888
		private readonly int m_MainThreadID;

		// Token: 0x04000379 RID: 889
		private int m_TrackedCount;

		// Token: 0x020000C6 RID: 198
		private struct WorkRequest
		{
			// Token: 0x0600037B RID: 891 RVA: 0x000070C8 File Offset: 0x000052C8
			public WorkRequest(SendOrPostCallback callback, object state, [Optional] ManualResetEvent waitHandle)
			{
				this.m_DelagateCallback = callback;
				this.m_DelagateState = state;
				this.m_WaitHandle = waitHandle;
			}

			// Token: 0x0600037C RID: 892 RVA: 0x000070EC File Offset: 0x000052EC
			public void Invoke()
			{
				SendOrPostCallback delagateCallback = this.m_DelagateCallback;
				object delagateState = this.m_DelagateState;
				IntPtr method_code = delagateCallback.method_code;
				IntPtr invoke_impl = delagateCallback.invoke_impl;
				IntPtr method = delagateCallback.method;
				long num = 0L;
				ManualResetEvent waitHandle = this.m_WaitHandle;
				if (waitHandle != null)
				{
					bool flag = waitHandle.Set();
				}
				if (num == 0L)
				{
					return;
				}
				throw new OutOfMemoryException();
			}

			// Token: 0x0400037A RID: 890
			private readonly SendOrPostCallback m_DelagateCallback;

			// Token: 0x0400037B RID: 891
			private readonly object m_DelagateState;

			// Token: 0x0400037C RID: 892
			private readonly ManualResetEvent m_WaitHandle;
		}
	}
}
