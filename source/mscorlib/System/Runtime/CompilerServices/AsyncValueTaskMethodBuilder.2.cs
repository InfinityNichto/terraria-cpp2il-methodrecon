using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000465 RID: 1125
	[StructLayout(3)]
	public struct AsyncValueTaskMethodBuilder<TResult>
	{
		// Token: 0x060021F3 RID: 8691 RVA: 0x0000207A File Offset: 0x0000027A
		public static AsyncValueTaskMethodBuilder<TResult> Create()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060021F4 RID: 8692 RVA: 0x0004CBEC File Offset: 0x0004ADEC
		public void Start<TStateMachine>(TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine
		{
		}

		// Token: 0x060021F5 RID: 8693 RVA: 0x0004CBFC File Offset: 0x0004ADFC
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		// Token: 0x060021F6 RID: 8694 RVA: 0x0004CC0C File Offset: 0x0004AE0C
		public void SetResult(TResult result)
		{
		}

		// Token: 0x060021F7 RID: 8695 RVA: 0x0004CC24 File Offset: 0x0004AE24
		public void SetException(Exception exception)
		{
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x060021F8 RID: 8696 RVA: 0x0004CC34 File Offset: 0x0004AE34
		public ValueTask<TResult> Task
		{
			get
			{
				/*
An exception occurred when decompiling this method (060021F8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.ValueTask`1<TResult> System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder`1::get_Task()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(ThrowHelper::ThrowArgumentNullException, ldc.i4:ExceptionArgument(38))
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

		// Token: 0x060021F9 RID: 8697 RVA: 0x0004CC50 File Offset: 0x0004AE50
		public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(TAwaiter awaiter, TStateMachine stateMachine) where TAwaiter : ICriticalNotifyCompletion where TStateMachine : IAsyncStateMachine
		{
		}

		// Token: 0x040012A6 RID: 4774
		private AsyncTaskMethodBuilder<TResult> _methodBuilder;

		// Token: 0x040012A7 RID: 4775
		private TResult _result;

		// Token: 0x040012A8 RID: 4776
		private bool _haveResult;

		// Token: 0x040012A9 RID: 4777
		private bool _useBuilder;
	}
}
