using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000468 RID: 1128
	[StructLayout(3)]
	public readonly struct ConfiguredValueTaskAwaitable
	{
		// Token: 0x060021FC RID: 8700 RVA: 0x0004CC88 File Offset: 0x0004AE88
		internal ConfiguredValueTaskAwaitable(ValueTask value)
		{
			this._value = value;
		}

		// Token: 0x060021FD RID: 8701 RVA: 0x0004CC9C File Offset: 0x0004AE9C
		public ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter GetAwaiter()
		{
			/*
An exception occurred when decompiling this method (060021FD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable/ConfiguredValueTaskAwaiter System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable::GetAwaiter()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ValueTask(var_0_06, ldfld:ValueTask(ConfiguredValueTaskAwaitable::_value, ldloc:valuetype System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable&(this)))
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

		// Token: 0x040012AA RID: 4778
		private readonly ValueTask _value;

		// Token: 0x02000469 RID: 1129
		[StructLayout(3)]
		public readonly struct ConfiguredValueTaskAwaiter : ICriticalNotifyCompletion
		{
			// Token: 0x060021FE RID: 8702 RVA: 0x0004CCB0 File Offset: 0x0004AEB0
			internal ConfiguredValueTaskAwaiter(ValueTask value)
			{
				this._value = value;
			}

			// Token: 0x17000463 RID: 1123
			// (get) Token: 0x060021FF RID: 8703 RVA: 0x0004CCC4 File Offset: 0x0004AEC4
			public bool IsCompleted
			{
				get
				{
					int value = 1.m_value;
					bool flag;
					return flag;
				}
			}

			// Token: 0x06002200 RID: 8704 RVA: 0x0004CCDC File Offset: 0x0004AEDC
			[StackTraceHidden]
			public void GetResult()
			{
			}

			// Token: 0x06002201 RID: 8705 RVA: 0x0004CCEC File Offset: 0x0004AEEC
			public void UnsafeOnCompleted(Action continuation)
			{
			}

			// Token: 0x040012AB RID: 4779
			private readonly ValueTask _value;
		}
	}
}
