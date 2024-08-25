using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Sources;
using Cpp2IlInjected;

namespace System.Threading.Tasks
{
	// Token: 0x0200021D RID: 541
	[AsyncMethodBuilder(typeof(AsyncValueTaskMethodBuilder))]
	[StructLayout(3)]
	public readonly struct ValueTask : IEquatable<ValueTask>
	{
		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060012EB RID: 4843 RVA: 0x00027E4C File Offset: 0x0002604C
		internal static Task CompletedTask
		{
			get
			{
				/*
An exception occurred when decompiling this method (060012EB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task System.Threading.Tasks.ValueTask::get_CompletedTask()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
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
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x00027E60 File Offset: 0x00026060
		public ValueTask(Task task)
		{
			if (task == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.task);
			}
			this._obj = task;
			this._continueOnCapturedContext = true;
		}

		// Token: 0x060012ED RID: 4845 RVA: 0x00027E88 File Offset: 0x00026088
		public ValueTask(IValueTaskSource source, short token)
		{
			if (source == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.source);
			}
			this._obj = source;
			this._token = token;
			this._continueOnCapturedContext = true;
		}

		// Token: 0x060012EE RID: 4846 RVA: 0x00027EB4 File Offset: 0x000260B4
		private ValueTask(object obj, short token, bool continueOnCapturedContext)
		{
			this._obj = obj;
			this._token = token;
		}

		// Token: 0x060012EF RID: 4847 RVA: 0x0000207A File Offset: 0x0000027A
		public override int GetHashCode()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x00027ED0 File Offset: 0x000260D0
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				return;
			}
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x00027EE4 File Offset: 0x000260E4
		public bool Equals(ValueTask other)
		{
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x00027EF4 File Offset: 0x000260F4
		public Task AsTask()
		{
			Task task;
			return task;
		}

		// Token: 0x060012F3 RID: 4851 RVA: 0x00027F08 File Offset: 0x00026108
		private Task GetTaskForValueTaskSource(IValueTaskSource t)
		{
			short token = this._token;
			short token2 = this._token;
			if (t != null)
			{
			}
			return ValueTask.CompletedTask;
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060012F4 RID: 4852 RVA: 0x00027F34 File Offset: 0x00026134
		public bool IsCompleted
		{
			get
			{
				short token = this._token;
				int value = 1.m_value;
				bool flag;
				return flag;
			}
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x00027F50 File Offset: 0x00026150
		[StackTraceHidden]
		internal void ThrowIfCompletedUnsuccessfully()
		{
			short token = this._token;
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x00027F68 File Offset: 0x00026168
		public ValueTaskAwaiter GetAwaiter()
		{
			/*
An exception occurred when decompiling this method (060012F6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Runtime.CompilerServices.ValueTaskAwaiter System.Threading.Tasks.ValueTask::GetAwaiter()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:object(var_0_06, ldfld:object(ValueTask::_obj, ldloc:valuetype System.Threading.Tasks.ValueTask&(this)))
	stloc:int16(var_1_0D, ldfld:int16(ValueTask::_token, ldloc:valuetype System.Threading.Tasks.ValueTask&(this)))
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

		// Token: 0x060012F7 RID: 4855 RVA: 0x00027F84 File Offset: 0x00026184
		public ConfiguredValueTaskAwaitable ConfigureAwait(bool continueOnCapturedContext)
		{
			/*
An exception occurred when decompiling this method (060012F7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable System.Threading.Tasks.ValueTask::ConfigureAwait(System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int16(var_0_06, ldfld:int16(ValueTask::_token, ldloc:valuetype System.Threading.Tasks.ValueTask&(this)))
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

		// Token: 0x060012F8 RID: 4856 RVA: 0x00027F98 File Offset: 0x00026198
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTask()
		{
			if (!true)
			{
			}
		}

		// Token: 0x04000A22 RID: 2594
		private static readonly Task s_canceledTask;

		// Token: 0x04000A23 RID: 2595
		internal readonly object _obj;

		// Token: 0x04000A24 RID: 2596
		internal readonly short _token;

		// Token: 0x04000A25 RID: 2597
		internal readonly bool _continueOnCapturedContext;

		// Token: 0x0200021E RID: 542
		private sealed class ValueTaskSourceAsTask : Task<VoidTaskResult>
		{
			// Token: 0x060012F9 RID: 4857 RVA: 0x00027FA8 File Offset: 0x000261A8
			public ValueTaskSourceAsTask(IValueTaskSource source, short token)
			{
				int num = 1;
				this._token = token;
				this._source = source;
				if (num == 0)
				{
				}
			}

			// Token: 0x060012FA RID: 4858 RVA: 0x00027FCC File Offset: 0x000261CC
			// Note: this type is marked as 'beforefieldinit'.
			static ValueTaskSourceAsTask()
			{
				if (!true)
				{
				}
			}

			// Token: 0x04000A26 RID: 2598
			private static readonly Action<object> s_completionAction;

			// Token: 0x04000A27 RID: 2599
			private IValueTaskSource _source;

			// Token: 0x04000A28 RID: 2600
			private readonly short _token;

			// Token: 0x0200021F RID: 543
			[CompilerGenerated]
			[Serializable]
			private sealed class <>c
			{
				// Token: 0x060012FB RID: 4859 RVA: 0x0001B05E File Offset: 0x0001925E
				// Note: this type is marked as 'beforefieldinit'.
				static <>c()
				{
				}

				// Token: 0x060012FC RID: 4860 RVA: 0x0001B05E File Offset: 0x0001925E
				public <>c()
				{
				}

				// Token: 0x060012FD RID: 4861 RVA: 0x0001B05E File Offset: 0x0001925E
				internal void <.cctor>b__4_0(object state)
				{
				}

				// Token: 0x04000A29 RID: 2601
				public static readonly ValueTask.ValueTaskSourceAsTask.<>c <>9;
			}
		}
	}
}
