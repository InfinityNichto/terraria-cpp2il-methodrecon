using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Sources;

namespace System.Threading.Tasks
{
	// Token: 0x02000220 RID: 544
	[AsyncMethodBuilder(typeof(AsyncValueTaskMethodBuilder<>))]
	[StructLayout(3)]
	public readonly struct ValueTask<TResult> : IEquatable<ValueTask<TResult>>
	{
		// Token: 0x060012FE RID: 4862 RVA: 0x00027FDC File Offset: 0x000261DC
		public ValueTask(TResult result)
		{
			this._result = result;
		}

		// Token: 0x060012FF RID: 4863 RVA: 0x00027FF0 File Offset: 0x000261F0
		public ValueTask(Task<TResult> task)
		{
			if (task == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.task);
			}
			this._obj = task;
		}

		// Token: 0x06001300 RID: 4864 RVA: 0x00028010 File Offset: 0x00026210
		public ValueTask(IValueTaskSource<TResult> source, short token)
		{
			if (source == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.source);
			}
			this._obj = source;
		}

		// Token: 0x06001301 RID: 4865 RVA: 0x00028030 File Offset: 0x00026230
		private ValueTask(object obj, TResult result, short token, bool continueOnCapturedContext)
		{
			this._obj = obj;
			this._result = result;
		}

		// Token: 0x06001302 RID: 4866 RVA: 0x0002804C File Offset: 0x0002624C
		public override int GetHashCode()
		{
			int num;
			return num;
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x0002805C File Offset: 0x0002625C
		public override bool Equals(object obj)
		{
			short token = this._token;
			if (obj != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x0002807C File Offset: 0x0002627C
		public bool Equals(ValueTask<TResult> other)
		{
			/*
An exception occurred when decompiling this method (06001304)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Threading.Tasks.ValueTask`1::Equals(System.Threading.Tasks.ValueTask`1<TResult>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:!TResult(var_1_0B, ldfld:!TResult(ValueTask`1::_result, ldloc:valuetype System.Threading.Tasks.ValueTask`1&(this)))
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

		// Token: 0x06001305 RID: 4869 RVA: 0x00028094 File Offset: 0x00026294
		public Task<TResult> AsTask()
		{
			Task task;
			return task;
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x000280AC File Offset: 0x000262AC
		private Task<TResult> GetTaskForValueTaskSource(IValueTaskSource<TResult> t)
		{
			if (t != null)
			{
			}
			if (false)
			{
				return;
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06001307 RID: 4871 RVA: 0x000280C4 File Offset: 0x000262C4
		public bool IsCompleted
		{
			get
			{
				int value = 1.m_value;
				bool flag;
				return flag;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06001308 RID: 4872 RVA: 0x000280DC File Offset: 0x000262DC
		public bool IsCompletedSuccessfully
		{
			get
			{
				int value = 1.m_value;
				bool flag;
				return flag;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06001309 RID: 4873 RVA: 0x000280F4 File Offset: 0x000262F4
		public TResult Result
		{
			get
			{
				return this._result;
			}
		}

		// Token: 0x0600130A RID: 4874 RVA: 0x00028108 File Offset: 0x00026308
		public ValueTaskAwaiter<TResult> GetAwaiter()
		{
			/*
An exception occurred when decompiling this method (0600130A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Runtime.CompilerServices.ValueTaskAwaiter`1<TResult> System.Threading.Tasks.ValueTask`1::GetAwaiter()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:object(var_0_06, ldfld:object(ValueTask`1::_obj, ldloc:valuetype System.Threading.Tasks.ValueTask`1&(this)))
	stloc:!TResult(var_1_0D, ldfld:!TResult(ValueTask`1::_result, ldloc:valuetype System.Threading.Tasks.ValueTask`1&(this)))
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

		// Token: 0x0600130B RID: 4875 RVA: 0x00028124 File Offset: 0x00026324
		public ConfiguredValueTaskAwaitable<TResult> ConfigureAwait(bool continueOnCapturedContext)
		{
			/*
An exception occurred when decompiling this method (0600130B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable`1<TResult> System.Threading.Tasks.ValueTask`1::ConfigureAwait(System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:!TResult(var_0_06, ldfld:!TResult(ValueTask`1::_result, ldloc:valuetype System.Threading.Tasks.ValueTask`1&(this)))
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

		// Token: 0x0600130C RID: 4876 RVA: 0x00028138 File Offset: 0x00026338
		public override string ToString()
		{
			string text;
			return text;
		}

		// Token: 0x04000A2A RID: 2602
		private static Task<TResult> s_canceledTask;

		// Token: 0x04000A2B RID: 2603
		internal readonly object _obj;

		// Token: 0x04000A2C RID: 2604
		internal readonly TResult _result;

		// Token: 0x04000A2D RID: 2605
		internal readonly short _token;

		// Token: 0x04000A2E RID: 2606
		internal readonly bool _continueOnCapturedContext;

		// Token: 0x02000221 RID: 545
		private sealed class ValueTaskSourceAsTask : Task<TResult>
		{
			// Token: 0x0600130D RID: 4877 RVA: 0x00028148 File Offset: 0x00026348
			public ValueTaskSourceAsTask(IValueTaskSource<TResult> source, short token)
			{
			}

			// Token: 0x0600130E RID: 4878 RVA: 0x00028158 File Offset: 0x00026358
			// Note: this type is marked as 'beforefieldinit'.
			static ValueTaskSourceAsTask()
			{
				if (!true)
				{
				}
			}

			// Token: 0x04000A2F RID: 2607
			private static readonly Action<object> s_completionAction;

			// Token: 0x04000A30 RID: 2608
			private IValueTaskSource<TResult> _source;

			// Token: 0x04000A31 RID: 2609
			private readonly short _token;

			// Token: 0x02000222 RID: 546
			[CompilerGenerated]
			[Serializable]
			private sealed class <>c
			{
				// Token: 0x0600130F RID: 4879 RVA: 0x0001B05E File Offset: 0x0001925E
				// Note: this type is marked as 'beforefieldinit'.
				static <>c()
				{
				}

				// Token: 0x06001310 RID: 4880 RVA: 0x0001B05E File Offset: 0x0001925E
				public <>c()
				{
				}

				// Token: 0x06001311 RID: 4881 RVA: 0x0001B05E File Offset: 0x0001925E
				internal void <.cctor>b__4_0(object state)
				{
				}

				// Token: 0x04000A32 RID: 2610
				public static readonly ValueTask<TResult>.ValueTaskSourceAsTask.<>c <>9;
			}
		}
	}
}
