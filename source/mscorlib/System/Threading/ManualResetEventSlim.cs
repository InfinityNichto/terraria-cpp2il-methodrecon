using System;
using System.Diagnostics;
using Cpp2IlInjected;

namespace System.Threading
{
	// Token: 0x020001CB RID: 459
	[DebuggerDisplay("Set = {IsSet}")]
	public class ManualResetEventSlim : IDisposable
	{
		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060010E1 RID: 4321 RVA: 0x00023B04 File Offset: 0x00021D04
		public WaitHandle WaitHandle
		{
			get
			{
				/*
An exception occurred when decompiling this method (060010E1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.WaitHandle System.Threading.ManualResetEventSlim::get_WaitHandle()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0015:
	stloc:ManualResetEvent(var_1_1B, ldfld:ManualResetEvent(ManualResetEventSlim::m_eventObj, ldloc:ManualResetEventSlim(this)))
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

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060010E2 RID: 4322 RVA: 0x00023B2C File Offset: 0x00021D2C
		// (set) Token: 0x060010E3 RID: 4323 RVA: 0x00023B44 File Offset: 0x00021D44
		public bool IsSet
		{
			get
			{
				/*
An exception occurred when decompiling this method (060010E2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Threading.ManualResetEventSlim::get_IsSet()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	stloc:int32(var_0_06, ldfld:int32(ManualResetEventSlim::m_combinedState, ldloc:ManualResetEventSlim(this)))
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
			private set
			{
				this.UpdateStateAtomically(value ? 1 : 0, 32768);
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060010E4 RID: 4324 RVA: 0x00023B60 File Offset: 0x00021D60
		// (set) Token: 0x060010E5 RID: 4325 RVA: 0x00023B78 File Offset: 0x00021D78
		public int SpinCount
		{
			get
			{
				/*
An exception occurred when decompiling this method (060010E4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Threading.ManualResetEventSlim::get_SpinCount()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	stloc:int32(var_0_06, ldfld:int32(ManualResetEventSlim::m_combinedState, ldloc:ManualResetEventSlim(this)))
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
			private set
			{
				int combinedState = this.m_combinedState;
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060010E6 RID: 4326 RVA: 0x00023B8C File Offset: 0x00021D8C
		// (set) Token: 0x060010E7 RID: 4327 RVA: 0x00023BA4 File Offset: 0x00021DA4
		private int Waiters
		{
			get
			{
				/*
An exception occurred when decompiling this method (060010E6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Threading.ManualResetEventSlim::get_Waiters()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	stloc:int32(var_0_06, ldfld:int32(ManualResetEventSlim::m_combinedState, ldloc:ManualResetEventSlim(this)))
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
			set
			{
			}
		}

		// Token: 0x060010E8 RID: 4328 RVA: 0x00023BB4 File Offset: 0x00021DB4
		public ManualResetEventSlim(bool initialState)
		{
			long num = 0L;
			base..ctor();
			if (!true)
			{
			}
			this.Initialize(num != 0L, 1);
		}

		// Token: 0x060010E9 RID: 4329 RVA: 0x00023BD4 File Offset: 0x00021DD4
		public ManualResetEventSlim(bool initialState, int spinCount)
		{
			long num = 0L;
			base..ctor();
			this.Initialize(num != 0L, spinCount);
		}

		// Token: 0x060010EA RID: 4330 RVA: 0x00023BF4 File Offset: 0x00021DF4
		private void Initialize(bool initialState, int spinCount)
		{
			this.m_combinedState = (initialState ? 1 : 0);
			if (32768 == 0)
			{
				int combinedState = this.m_combinedState;
			}
			this.m_combinedState = 32768;
		}

		// Token: 0x060010EB RID: 4331 RVA: 0x00023C24 File Offset: 0x00021E24
		private void EnsureLockObjectCreated()
		{
			if (this.m_lock != null)
			{
				return;
			}
		}

		// Token: 0x060010EC RID: 4332 RVA: 0x00023C3C File Offset: 0x00021E3C
		private bool LazyInitializeEvent()
		{
			bool isSet = this.IsSet;
			bool isSet2 = this.IsSet;
			if (!false)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060010ED RID: 4333 RVA: 0x00023C78 File Offset: 0x00021E78
		public void Set()
		{
			long num = 0L;
			this.Set(num != 0L);
		}

		// Token: 0x060010EE RID: 4334 RVA: 0x00023C90 File Offset: 0x00021E90
		private void Set(bool duringCancellation)
		{
			this.UpdateStateAtomically(0, 32768);
			int waiters = this.Waiters;
			Monitor.Enter(this.m_lock, false);
			Monitor.PulseAll(this.m_lock);
			if (!false)
			{
				ManualResetEvent eventObj = this.m_eventObj;
				if (eventObj != null)
				{
					Monitor.Enter(eventObj, false);
					if (this.m_eventObj != null)
					{
						bool flag = this.m_eventObj.Set();
					}
					if (false)
					{
						throw new OutOfMemoryException();
					}
				}
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060010EF RID: 4335 RVA: 0x00023D24 File Offset: 0x00021F24
		public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			int num = 1;
			this.ThrowIfDisposed();
			bool isSet = this.IsSet;
			if (millisecondsTimeout != 0)
			{
				int tickCount = Environment.TickCount;
				int spinCount = this.SpinCount;
				int num2 = 10;
				bool isSet2 = this.IsSet;
				if (num == 0)
				{
				}
				this.EnsureLockObjectCreated();
				if (num == 0)
				{
				}
				object @lock = this.m_lock;
				bool isSet3 = this.IsSet;
				int tickCount2 = Environment.TickCount;
				int waiters = this.Waiters;
				bool isSet4 = this.IsSet;
				object lock2 = this.m_lock;
				long num3 = 0L;
				bool flag = Monitor.Wait(lock2, millisecondsTimeout, num3 != 0L);
				long num4 = 0L;
				int waiters2 = this.Waiters;
				this.Waiters = millisecondsTimeout;
				if (num4 != 0L)
				{
					throw new OutOfMemoryException();
				}
				while (num2 == 0)
				{
				}
				long num5 = 0L;
				if (num != 0)
				{
				}
				if (num5 != 0L)
				{
					throw new OutOfMemoryException();
				}
			}
			if (false)
			{
				throw new OutOfMemoryException();
			}
			long num6 = 0L;
			if (num != 0)
			{
			}
			if (num6 == 0L)
			{
				throw new OutOfMemoryException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x00023E24 File Offset: 0x00022024
		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		// Token: 0x060010F1 RID: 4337 RVA: 0x00023E38 File Offset: 0x00022038
		protected virtual void Dispose(bool disposing)
		{
			int combinedState = this.m_combinedState;
			int combinedState2 = this.m_combinedState;
			ManualResetEvent eventObj = this.m_eventObj;
			if (eventObj != null)
			{
				Monitor.Enter(eventObj, disposing);
				eventObj.Dispose();
				if (false)
				{
					throw new OutOfMemoryException();
				}
			}
		}

		// Token: 0x060010F2 RID: 4338 RVA: 0x00023E8C File Offset: 0x0002208C
		private void ThrowIfDisposed()
		{
			int combinedState = this.m_combinedState;
		}

		// Token: 0x060010F3 RID: 4339 RVA: 0x00023EA0 File Offset: 0x000220A0
		private static void CancellationTokenCallback(object obj)
		{
			if (!false)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060010F4 RID: 4340 RVA: 0x00023ECC File Offset: 0x000220CC
		private void UpdateStateAtomically(int newBits, int updateBitsMask)
		{
			int combinedState = this.m_combinedState;
		}

		// Token: 0x060010F5 RID: 4341 RVA: 0x0000207A File Offset: 0x0000027A
		private static int ExtractStatePortionAndShiftRight(int state, int mask, int rightBitShiftCount)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060010F6 RID: 4342 RVA: 0x0000207A File Offset: 0x0000027A
		private static int ExtractStatePortion(int state, int mask)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060010F7 RID: 4343 RVA: 0x00023EE0 File Offset: 0x000220E0
		// Note: this type is marked as 'beforefieldinit'.
		static ManualResetEventSlim()
		{
		}

		// Token: 0x0400091B RID: 2331
		private object m_lock;

		// Token: 0x0400091C RID: 2332
		private ManualResetEvent m_eventObj;

		// Token: 0x0400091D RID: 2333
		private int m_combinedState;

		// Token: 0x0400091E RID: 2334
		private static Action<object> s_cancellationTokenCallback;
	}
}
