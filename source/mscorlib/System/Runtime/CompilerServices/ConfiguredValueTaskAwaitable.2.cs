using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace System.Runtime.CompilerServices
{
	// Token: 0x0200046A RID: 1130
	[StructLayout(3)]
	public readonly struct ConfiguredValueTaskAwaitable<TResult>
	{
		// Token: 0x06002202 RID: 8706 RVA: 0x0004CD04 File Offset: 0x0004AF04
		internal ConfiguredValueTaskAwaitable(ValueTask<TResult> value)
		{
			this._value = value;
		}

		// Token: 0x06002203 RID: 8707 RVA: 0x0004CD18 File Offset: 0x0004AF18
		public ConfiguredValueTaskAwaitable<TResult>.ConfiguredValueTaskAwaiter GetAwaiter()
		{
			/*
An exception occurred when decompiling this method (06002203)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable`1/ConfiguredValueTaskAwaiter<TResult> System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable`1::GetAwaiter()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ValueTask`1(var_0_06, ldfld:valuetype System.Threading.Tasks.ValueTask`1<!TResult>[exp:ValueTask`1](ConfiguredValueTaskAwaitable`1::_value, ldloc:valuetype System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable`1&(this)))
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

		// Token: 0x040012AC RID: 4780
		private readonly ValueTask<TResult> _value;

		// Token: 0x0200046B RID: 1131
		[StructLayout(3)]
		public readonly struct ConfiguredValueTaskAwaiter : ICriticalNotifyCompletion
		{
			// Token: 0x06002204 RID: 8708 RVA: 0x0004CD2C File Offset: 0x0004AF2C
			internal ConfiguredValueTaskAwaiter(ValueTask<TResult> value)
			{
				this._value = value;
			}

			// Token: 0x17000464 RID: 1124
			// (get) Token: 0x06002205 RID: 8709 RVA: 0x0000207A File Offset: 0x0000027A
			public bool IsCompleted
			{
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x06002206 RID: 8710 RVA: 0x0000207A File Offset: 0x0000027A
			[StackTraceHidden]
			public TResult GetResult()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06002207 RID: 8711 RVA: 0x0004CD40 File Offset: 0x0004AF40
			public void UnsafeOnCompleted(Action continuation)
			{
			}

			// Token: 0x040012AD RID: 4781
			private readonly ValueTask<TResult> _value;
		}
	}
}
