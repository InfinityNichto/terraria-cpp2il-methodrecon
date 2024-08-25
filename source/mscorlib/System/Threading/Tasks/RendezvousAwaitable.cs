using System;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

namespace System.Threading.Tasks
{
	// Token: 0x02000227 RID: 551
	internal class RendezvousAwaitable<TResult> : ICriticalNotifyCompletion
	{
		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x0600131D RID: 4893 RVA: 0x00028214 File Offset: 0x00026414
		// (set) Token: 0x0600131E RID: 4894 RVA: 0x00028228 File Offset: 0x00026428
		public bool RunContinuationsAsynchronously
		{
			[CompilerGenerated]
			get
			{
				return this.<RunContinuationsAsynchronously>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x00028238 File Offset: 0x00026438
		public RendezvousAwaitable<TResult> GetAwaiter()
		{
			return this;
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06001320 RID: 4896 RVA: 0x00028248 File Offset: 0x00026448
		public bool IsCompleted
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001320)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Threading.Tasks.RendezvousAwaitable`1::get_IsCompleted()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Action(var_0_06, ldfld:Action(RendezvousAwaitable`1::_continuation, ldloc:RendezvousAwaitable`1(this)))
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

		// Token: 0x06001321 RID: 4897 RVA: 0x0002825C File Offset: 0x0002645C
		public TResult GetResult()
		{
			ExceptionDispatchInfo error = this._error;
			if (error != null)
			{
				error.Throw();
			}
			return this._result;
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x00028280 File Offset: 0x00026480
		public void SetResult(TResult result)
		{
			this._result = result;
		}

		// Token: 0x06001323 RID: 4899 RVA: 0x00028294 File Offset: 0x00026494
		private void NotifyAwaiter()
		{
			if (this._continuation == null)
			{
				if (!true)
				{
				}
				if (this == null)
				{
					return;
				}
			}
		}

		// Token: 0x06001324 RID: 4900 RVA: 0x000282C0 File Offset: 0x000264C0
		public void OnCompleted(Action continuation)
		{
			if (this._continuation != null || this != null)
			{
				Task task = Task.Run(continuation);
				return;
			}
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x000282E0 File Offset: 0x000264E0
		public void UnsafeOnCompleted(Action continuation)
		{
		}

		// Token: 0x06001326 RID: 4902 RVA: 0x000282F0 File Offset: 0x000264F0
		public RendezvousAwaitable()
		{
		}

		// Token: 0x06001327 RID: 4903 RVA: 0x0002830C File Offset: 0x0002650C
		// Note: this type is marked as 'beforefieldinit'.
		static RendezvousAwaitable()
		{
			if (!true)
			{
			}
		}

		// Token: 0x04000A36 RID: 2614
		private static readonly Action s_completionSentinel;

		// Token: 0x04000A37 RID: 2615
		private Action _continuation;

		// Token: 0x04000A38 RID: 2616
		private ExceptionDispatchInfo _error;

		// Token: 0x04000A39 RID: 2617
		private TResult _result;

		// Token: 0x04000A3A RID: 2618
		[CompilerGenerated]
		private bool <RunContinuationsAsynchronously>k__BackingField = true;

		// Token: 0x02000228 RID: 552
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06001328 RID: 4904 RVA: 0x00028320 File Offset: 0x00026520
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06001329 RID: 4905 RVA: 0x00028330 File Offset: 0x00026530
			public <>c()
			{
			}

			// Token: 0x0600132A RID: 4906 RVA: 0x00028344 File Offset: 0x00026544
			internal void <.cctor>b__20_0()
			{
			}

			// Token: 0x04000A3B RID: 2619
			public static readonly RendezvousAwaitable<TResult>.<>c <>9;
		}
	}
}
