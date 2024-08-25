using System;
using System.Threading;

namespace System.IO
{
	// Token: 0x02000568 RID: 1384
	internal class FileStreamAsyncResult : IAsyncResult
	{
		// Token: 0x0600299F RID: 10655 RVA: 0x0005A7A4 File Offset: 0x000589A4
		public FileStreamAsyncResult(AsyncCallback cb, object state)
		{
			this.state = state;
			this.realcb = cb;
			if (cb != null)
			{
			}
		}

		// Token: 0x060029A0 RID: 10656 RVA: 0x0005A7CC File Offset: 0x000589CC
		private static void CBWrapper(IAsyncResult ares)
		{
			if (ares != null)
			{
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x060029A1 RID: 10657 RVA: 0x0005A7E4 File Offset: 0x000589E4
		public object AsyncState
		{
			get
			{
				return this.state;
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x060029A2 RID: 10658 RVA: 0x0005A7F8 File Offset: 0x000589F8
		public bool CompletedSynchronously
		{
			get
			{
				return this.completedSynch;
			}
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x060029A3 RID: 10659 RVA: 0x0005A80C File Offset: 0x00058A0C
		public WaitHandle AsyncWaitHandle
		{
			get
			{
				/*
An exception occurred when decompiling this method (060029A3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.WaitHandle System.IO.FileStreamAsyncResult::get_AsyncWaitHandle()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ManualResetEvent(var_0_06, ldfld:ManualResetEvent(FileStreamAsyncResult::wh, ldloc:FileStreamAsyncResult(this)))
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

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x060029A4 RID: 10660 RVA: 0x0005A820 File Offset: 0x00058A20
		public bool IsCompleted
		{
			get
			{
				return this.completed;
			}
		}

		// Token: 0x04001648 RID: 5704
		private object state;

		// Token: 0x04001649 RID: 5705
		private bool completed;

		// Token: 0x0400164A RID: 5706
		private ManualResetEvent wh;

		// Token: 0x0400164B RID: 5707
		private AsyncCallback cb;

		// Token: 0x0400164C RID: 5708
		private bool completedSynch;

		// Token: 0x0400164D RID: 5709
		public int Count;

		// Token: 0x0400164E RID: 5710
		public int OriginalCount;

		// Token: 0x0400164F RID: 5711
		public int BytesRead;

		// Token: 0x04001650 RID: 5712
		private AsyncCallback realcb;
	}
}
