using System;
using System.Threading;

namespace System.Net
{
	// Token: 0x02000254 RID: 596
	internal class HttpStreamAsyncResult : IAsyncResult
	{
		// Token: 0x06000F82 RID: 3970 RVA: 0x000312F4 File Offset: 0x0002F4F4
		public void Complete(Exception e)
		{
			this.Error = e;
			this.Complete();
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x00031310 File Offset: 0x0002F510
		public void Complete()
		{
			object obj = this.locker;
			if (this.completed)
			{
				return;
			}
			if (obj != null)
			{
			}
			bool flag;
			while (!flag)
			{
			}
			long num = 0L;
			if (true)
			{
				Monitor.Exit(obj);
			}
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000F84 RID: 3972 RVA: 0x00031370 File Offset: 0x0002F570
		public object AsyncState
		{
			get
			{
				return this.State;
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000F85 RID: 3973 RVA: 0x00031384 File Offset: 0x0002F584
		public WaitHandle AsyncWaitHandle
		{
			get
			{
				object obj = this.locker;
				if (this.handle != null)
				{
				}
				bool flag = this.completed;
				long num = 0L;
				Monitor.Exit(obj);
				if (num == 0L && 3 == 0)
				{
					ManualResetEvent manualResetEvent = this.handle;
				}
				throw new OutOfMemoryException();
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000F86 RID: 3974 RVA: 0x000313DC File Offset: 0x0002F5DC
		public bool CompletedSynchronously
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000F86)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.HttpStreamAsyncResult::get_CompletedSynchronously()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(HttpStreamAsyncResult::SynchRead, ldloc:HttpStreamAsyncResult(this)))
	stloc:int32(var_1_0D, ldfld:int32(HttpStreamAsyncResult::Count, ldloc:HttpStreamAsyncResult(this)))
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

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000F87 RID: 3975 RVA: 0x000313F8 File Offset: 0x0002F5F8
		public bool IsCompleted
		{
			get
			{
				object obj = this.locker;
				bool flag = this.completed;
				long num = 0L;
				if (flag)
				{
					Monitor.Exit(obj);
				}
				if (num == 0L)
				{
				}
				throw new OutOfMemoryException();
			}
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x00031444 File Offset: 0x0002F644
		public HttpStreamAsyncResult()
		{
		}

		// Token: 0x04000C5A RID: 3162
		private object locker;

		// Token: 0x04000C5B RID: 3163
		private ManualResetEvent handle;

		// Token: 0x04000C5C RID: 3164
		private bool completed;

		// Token: 0x04000C5D RID: 3165
		internal byte[] Buffer;

		// Token: 0x04000C5E RID: 3166
		internal int Offset;

		// Token: 0x04000C5F RID: 3167
		internal int Count;

		// Token: 0x04000C60 RID: 3168
		internal AsyncCallback Callback;

		// Token: 0x04000C61 RID: 3169
		internal object State;

		// Token: 0x04000C62 RID: 3170
		internal int SynchRead;

		// Token: 0x04000C63 RID: 3171
		internal Exception Error;
	}
}
