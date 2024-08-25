using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ReLogic.OS.Windows
{
	// Token: 0x02000B24 RID: 2852
	internal class STATaskInvoker : IDisposable
	{
		// Token: 0x06005350 RID: 21328 RVA: 0x0028447C File Offset: 0x0028267C
		private STATaskInvoker()
		{
			this._shouldThreadContinue = true;
			Thread staThread = this._staThread;
			this._staThread.Start();
		}

		// Token: 0x06005351 RID: 21329 RVA: 0x002844A8 File Offset: 0x002826A8
		public static void Invoke(Action action)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06005352 RID: 21330 RVA: 0x002844B8 File Offset: 0x002826B8
		public static T Invoke<T>(Func<T> action)
		{
			/*
An exception occurred when decompiling this method (06005352)

ICSharpCode.Decompiler.DecompilerException: Error decompiling T ReLogic.OS.Windows.STATaskInvoker::Invoke<T>(System.Func`1<T>)

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

		// Token: 0x06005353 RID: 21331 RVA: 0x002844C8 File Offset: 0x002826C8
		private void InvokeAndWait(Action action)
		{
			object taskInvokeLock = this._taskInvokeLock;
			object taskCompletionLock = this._taskCompletionLock;
			BlockingCollection<Action> staTasks = this._staTasks;
			bool flag = Monitor.Wait(this._taskCompletionLock);
			long num = 0L;
			Monitor.Exit(taskCompletionLock);
			if (num != 0L)
			{
				throw new OutOfMemoryException();
			}
			long num2 = 0L;
			Monitor.Exit(taskInvokeLock);
			if (num2 == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06005354 RID: 21332 RVA: 0x0028455C File Offset: 0x0028275C
		private void TaskThreadStart()
		{
			if (this._shouldThreadContinue)
			{
				Action action = this._staTasks.Take();
				object taskCompletionLock = this._taskCompletionLock;
				Monitor.Enter(taskCompletionLock, true);
				IntPtr method_code = action.method_code;
				IntPtr method = action.method;
				IntPtr invoke_impl = action.invoke_impl;
				Monitor.Pulse(this._taskCompletionLock);
				long num = 0L;
				if (invoke_impl != 0)
				{
					Monitor.Exit(taskCompletionLock);
				}
				while (num == 0L)
				{
				}
				return;
			}
		}

		// Token: 0x06005355 RID: 21333 RVA: 0x002845E8 File Offset: 0x002827E8
		private void Shutdown()
		{
		}

		// Token: 0x06005356 RID: 21334 RVA: 0x002845F8 File Offset: 0x002827F8
		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposedValue)
			{
				this.Shutdown();
				BlockingCollection<Action> staTasks = this._staTasks;
				if (staTasks != null)
				{
					staTasks.Dispose();
				}
				this.disposedValue = true;
			}
		}

		// Token: 0x06005357 RID: 21335 RVA: 0x0028462C File Offset: 0x0028282C
		public void Dispose()
		{
		}

		// Token: 0x06005358 RID: 21336 RVA: 0x0028463C File Offset: 0x0028283C
		[CompilerGenerated]
		private void <Shutdown>b__11_0()
		{
		}

		// Token: 0x04008B16 RID: 35606
		private static STATaskInvoker Instance;

		// Token: 0x04008B17 RID: 35607
		private Thread _staThread;

		// Token: 0x04008B18 RID: 35608
		private bool _shouldThreadContinue;

		// Token: 0x04008B19 RID: 35609
		private BlockingCollection<Action> _staTasks;

		// Token: 0x04008B1A RID: 35610
		private object _taskInvokeLock;

		// Token: 0x04008B1B RID: 35611
		private object _taskCompletionLock;

		// Token: 0x04008B1C RID: 35612
		private bool disposedValue;

		// Token: 0x02000B25 RID: 2853
		[CompilerGenerated]
		private sealed class <>c__DisplayClass8_0<T>
		{
			// Token: 0x06005359 RID: 21337 RVA: 0x0028464C File Offset: 0x0028284C
			public <>c__DisplayClass8_0()
			{
			}

			// Token: 0x0600535A RID: 21338 RVA: 0x00284660 File Offset: 0x00282860
			internal void <Invoke>b__0()
			{
				Func func = this.action;
				this.output = func;
			}

			// Token: 0x04008B1D RID: 35613
			public T output;

			// Token: 0x04008B1E RID: 35614
			public Func<T> action;
		}
	}
}
