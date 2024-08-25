using System;

namespace System.ComponentModel
{
	// Token: 0x020003D5 RID: 981
	public class AsyncCompletedEventArgs : EventArgs
	{
		// Token: 0x060019DE RID: 6622 RVA: 0x00047C04 File Offset: 0x00045E04
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
		public AsyncCompletedEventArgs()
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x060019DF RID: 6623 RVA: 0x00047C1C File Offset: 0x00045E1C
		public AsyncCompletedEventArgs(Exception error, bool cancelled, object userState)
		{
			if (!true)
			{
			}
			base..ctor();
			this.error = error;
			this.userState = userState;
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x060019E0 RID: 6624 RVA: 0x00047C40 File Offset: 0x00045E40
		[global::System.SRDescription("True if operation was cancelled.")]
		public bool Cancelled
		{
			get
			{
				return this.cancelled;
			}
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x060019E1 RID: 6625 RVA: 0x00047C54 File Offset: 0x00045E54
		[global::System.SRDescription("Exception that occurred during operation.  Null if no error.")]
		public Exception Error
		{
			get
			{
				return this.error;
			}
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x060019E2 RID: 6626 RVA: 0x00047C68 File Offset: 0x00045E68
		[global::System.SRDescription("User-supplied state to identify operation.")]
		public object UserState
		{
			get
			{
				return this.userState;
			}
		}

		// Token: 0x060019E3 RID: 6627 RVA: 0x00047C7C File Offset: 0x00045E7C
		protected void RaiseExceptionIfNecessary()
		{
			/*
An exception occurred when decompiling this method (060019E3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.ComponentModel.AsyncCompletedEventArgs::RaiseExceptionIfNecessary()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0023:
	stloc:string(var_2_2D, call:string(SR::GetString, ldstr:string("Operation has been cancelled.")))
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

		// Token: 0x040012E3 RID: 4835
		private readonly Exception error;

		// Token: 0x040012E4 RID: 4836
		private readonly bool cancelled;

		// Token: 0x040012E5 RID: 4837
		private readonly object userState;
	}
}
