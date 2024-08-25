using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Win32.SafeHandles;

namespace System.Threading
{
	// Token: 0x02000209 RID: 521
	[ComVisible(true)]
	[StructLayout(0)]
	public abstract class WaitHandle : MarshalByRefObject, IDisposable
	{
		// Token: 0x06001274 RID: 4724 RVA: 0x000270C0 File Offset: 0x000252C0
		protected WaitHandle()
		{
			this.Init();
		}

		// Token: 0x06001275 RID: 4725 RVA: 0x000270DC File Offset: 0x000252DC
		private void Init()
		{
			if (!true)
			{
			}
			this.waitHandle = 1;
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06001276 RID: 4726 RVA: 0x000270F4 File Offset: 0x000252F4
		// (set) Token: 0x06001277 RID: 4727 RVA: 0x00027114 File Offset: 0x00025314
		[Obsolete("Use the SafeWaitHandle property instead.")]
		public virtual IntPtr Handle
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001276)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IntPtr System.Threading.WaitHandle::get_Handle()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0011:
	brtrue(IL_0000, ldloc:int32[exp:bool](var_0_01))
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
				if (!true)
				{
				}
				bool flag = value == 1;
				if (this.safeWaitHandle != null)
				{
					this.safeWaitHandle.SetHandleAsInvalid();
					return;
				}
				this.waitHandle = value;
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06001278 RID: 4728 RVA: 0x00027148 File Offset: 0x00025348
		// (set) Token: 0x06001279 RID: 4729 RVA: 0x00027168 File Offset: 0x00025368
		public SafeWaitHandle SafeWaitHandle
		{
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
			get
			{
				if (this.safeWaitHandle != null)
				{
					SafeWaitHandle safeWaitHandle = this.safeWaitHandle;
				}
				if (!true)
				{
					return;
				}
			}
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
			set
			{
				int num = 1;
				RuntimeHelpers.PrepareConstrainedRegions();
				if (value != null)
				{
					this.safeWaitHandle = value;
					return;
				}
				if (num == 0)
				{
				}
			}
		}

		// Token: 0x0600127A RID: 4730 RVA: 0x0002718C File Offset: 0x0002538C
		internal void SetHandleInternal(SafeWaitHandle handle)
		{
			this.safeWaitHandle = handle;
			IntPtr handle2 = handle.handle;
			this.waitHandle = handle2;
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x000271B0 File Offset: 0x000253B0
		public virtual bool WaitOne(int millisecondsTimeout, bool exitContext)
		{
			return this.WaitOne((long)millisecondsTimeout, exitContext);
		}

		// Token: 0x0600127C RID: 4732 RVA: 0x0000207A File Offset: 0x0000027A
		public virtual bool WaitOne()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600127D RID: 4733 RVA: 0x0000207A File Offset: 0x0000027A
		public virtual bool WaitOne(int millisecondsTimeout)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600127E RID: 4734 RVA: 0x000271D0 File Offset: 0x000253D0
		private bool WaitOne(long timeout, bool exitContext)
		{
			SafeWaitHandle safeWaitHandle = this.safeWaitHandle;
			bool flag = this.hasThreadAffinity;
			if (!true)
			{
			}
			bool flag2;
			return flag2;
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x000271F0 File Offset: 0x000253F0
		internal static bool InternalWaitOne(SafeHandle waitableSafeHandle, long millisecondsTimeout, bool hasThreadAffinity, bool exitContext)
		{
			/*
An exception occurred when decompiling this method (0600127F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Threading.WaitHandle::InternalWaitOne(System.Runtime.InteropServices.SafeHandle,System.Int64,System.Boolean,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:string(var_1_0D, call:string(Environment::GetResourceString, ldstr:string("Cannot access a disposed object.")))
	call:void(WaitHandle::ThrowAbandonedMutexException)
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

		// Token: 0x06001280 RID: 4736 RVA: 0x00027210 File Offset: 0x00025410
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public static int WaitAny(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext)
		{
			if (waitHandles != null)
			{
				int num;
				return num;
			}
			string resourceString = Environment.GetResourceString("Waithandle array may not be empty.");
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x00027274 File Offset: 0x00025474
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public static int WaitAny(WaitHandle[] waitHandles, TimeSpan timeout, bool exitContext)
		{
			int num;
			return num;
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x00027298 File Offset: 0x00025498
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public static int WaitAny(WaitHandle[] waitHandles, int millisecondsTimeout)
		{
			if (!true)
			{
			}
			int num;
			return num;
		}

		// Token: 0x06001283 RID: 4739 RVA: 0x0000207A File Offset: 0x0000027A
		private static void ThrowAbandonedMutexException()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x0000207A File Offset: 0x0000027A
		private static void ThrowAbandonedMutexException(int location, WaitHandle handle)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x000272AC File Offset: 0x000254AC
		public virtual void Close()
		{
			GC.SuppressFinalize(this);
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x000272C0 File Offset: 0x000254C0
		protected virtual void Dispose(bool explicitDisposing)
		{
			if (this.safeWaitHandle != null)
			{
				this.safeWaitHandle.Close();
				return;
			}
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x000272E4 File Offset: 0x000254E4
		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		// Token: 0x06001288 RID: 4744 RVA: 0x000272F8 File Offset: 0x000254F8
		private static int WaitOneNative(SafeHandle waitableSafeHandle, uint millisecondsTimeout, bool hasThreadAffinity, bool exitContext)
		{
			SynchronizationContext synchronizationContext = SynchronizationContext.Current;
			if (synchronizationContext != null)
			{
				bool flag = synchronizationContext.IsWaitNotificationRequired();
			}
			if (!false)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001289 RID: 4745 RVA: 0x00027334 File Offset: 0x00025534
		private static int WaitMultiple(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext, bool WaitAll)
		{
			SynchronizationContext synchronizationContext = SynchronizationContext.Current;
			if (synchronizationContext != null || synchronizationContext != null)
			{
				bool flag = synchronizationContext.IsWaitNotificationRequired();
				SafeWaitHandle safeWaitHandle;
				IntPtr handle = safeWaitHandle.handle;
			}
			SafeWaitHandle safeWaitHandle2;
			IntPtr handle2 = safeWaitHandle2.handle;
			long num = 0L;
			SafeWaitHandle safeWaitHandle3;
			safeWaitHandle3.DangerousRelease();
			if (num == 0L)
			{
				SynchronizationContextProperties props = synchronizationContext._props;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x0000207A File Offset: 0x0000027A
		internal unsafe static int Wait_internal(IntPtr* handles, int numHandles, bool waitAll, int ms)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600128B RID: 4747 RVA: 0x000273B0 File Offset: 0x000255B0
		// Note: this type is marked as 'beforefieldinit'.
		static WaitHandle()
		{
			IntPtr intPtr = (IntPtr)42189704;
		}

		// Token: 0x040009CE RID: 2510
		public const int WaitTimeout = 258;

		// Token: 0x040009CF RID: 2511
		private const int MAX_WAITHANDLES = 64;

		// Token: 0x040009D0 RID: 2512
		private IntPtr waitHandle;

		// Token: 0x040009D1 RID: 2513
		internal SafeWaitHandle safeWaitHandle;

		// Token: 0x040009D2 RID: 2514
		internal bool hasThreadAffinity;

		// Token: 0x040009D3 RID: 2515
		private const int WAIT_OBJECT_0 = 0;

		// Token: 0x040009D4 RID: 2516
		private const int WAIT_ABANDONED = 128;

		// Token: 0x040009D5 RID: 2517
		private const int WAIT_FAILED = 2147483647;

		// Token: 0x040009D6 RID: 2518
		private const int ERROR_TOO_MANY_POSTS = 298;

		// Token: 0x040009D7 RID: 2519
		private const int ERROR_NOT_OWNED_BY_CALLER = 299;

		// Token: 0x040009D8 RID: 2520
		protected static readonly IntPtr InvalidHandle;

		// Token: 0x040009D9 RID: 2521
		internal const int MaxWaitHandles = 64;
	}
}
