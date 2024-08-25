using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000F2 RID: 242
	[Preserve]
	internal class QueryFilter : PathFilter
	{
		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060009E3 RID: 2531 RVA: 0x00018544 File Offset: 0x00016744
		// (set) Token: 0x060009E4 RID: 2532 RVA: 0x00018558 File Offset: 0x00016758
		public QueryExpression Expression
		{
			[CompilerGenerated]
			get
			{
				return this.<Expression>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Expression>k__BackingField = value;
			}
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x0000212A File Offset: 0x0000032A
		public override IEnumerable<JToken> ExecuteFilter(IEnumerable<JToken> current, bool errorWhenNoMatch)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x0001856C File Offset: 0x0001676C
		public QueryFilter()
		{
		}

		// Token: 0x040003DF RID: 991
		[CompilerGenerated]
		private QueryExpression <Expression>k__BackingField;

		// Token: 0x020000F3 RID: 243
		[CompilerGenerated]
		private sealed class <ExecuteFilter>d__4 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IDisposable, IEnumerator
		{
			// Token: 0x060009E7 RID: 2535 RVA: 0x00018580 File Offset: 0x00016780
			[DebuggerHidden]
			public <ExecuteFilter>d__4(int <>1__state)
			{
				this.<>1__state = <>1__state;
				int managedThreadId = Thread.CurrentThread.ManagedThreadId;
				this.<>l__initialThreadId = managedThreadId;
			}

			// Token: 0x060009E8 RID: 2536 RVA: 0x000185B0 File Offset: 0x000167B0
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
				int num = this.<>1__state;
			}

			// Token: 0x060009E9 RID: 2537 RVA: 0x000185F0 File Offset: 0x000167F0
			private bool MoveNext()
			{
				int num = this.<>1__state;
				if (num == 0)
				{
					IEnumerable<JToken> enumerable = this.current;
					this.<>1__state = num;
				}
				long value = 0.m_value;
				throw new OutOfMemoryException();
			}

			// Token: 0x060009EA RID: 2538 RVA: 0x0001862C File Offset: 0x0001682C
			private void <>m__Finally1()
			{
				int num = 1;
				IEnumerator<JToken> enumerator = this.<>7__wrap1;
				this.<>1__state = num;
				if (enumerator != null)
				{
					return;
				}
			}

			// Token: 0x060009EB RID: 2539 RVA: 0x00018650 File Offset: 0x00016850
			private void <>m__Finally2()
			{
				int num = 1;
				IEnumerator<JToken> enumerator = this.<>7__wrap2;
				this.<>1__state = num;
				if (enumerator != null)
				{
					return;
				}
			}

			// Token: 0x170001C6 RID: 454
			// (get) Token: 0x060009EC RID: 2540 RVA: 0x00018674 File Offset: 0x00016874
			JToken IEnumerator<JToken>.Current
			{
				[DebuggerHidden]
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x060009ED RID: 2541 RVA: 0x0000212A File Offset: 0x0000032A
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x170001C7 RID: 455
			// (get) Token: 0x060009EE RID: 2542 RVA: 0x00018688 File Offset: 0x00016888
			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					/*
An exception occurred when decompiling this method (060009EE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object Newtonsoft.Json.Linq.JsonPath.QueryFilter/<ExecuteFilter>d__4::System.Collections.IEnumerator.get_Current()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:JToken(var_0_06, ldfld:JToken('<ExecuteFilter>d__4'::<>2__current, ldloc:'<ExecuteFilter>d__4'(this)))
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

			// Token: 0x060009EF RID: 2543 RVA: 0x0001869C File Offset: 0x0001689C
			[DebuggerHidden]
			IEnumerator<JToken> IEnumerable<JToken>.GetEnumerator()
			{
				/*
An exception occurred when decompiling this method (060009EF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IEnumerator`1<Newtonsoft.Json.Linq.JToken> Newtonsoft.Json.Linq.JsonPath.QueryFilter/<ExecuteFilter>d__4::System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32('<ExecuteFilter>d__4'::<>1__state, ldloc:'<ExecuteFilter>d__4'(this)))
	stloc:int32(var_1_0D, ldfld:int32('<ExecuteFilter>d__4'::<>l__initialThreadId, ldloc:'<ExecuteFilter>d__4'(this)))
	stloc:int32(var_3_1A, callgetter:int32(Thread::get_ManagedThreadId, callgetter:Thread(Thread::get_CurrentThread)))
	stloc:QueryFilter(var_5_24, ldfld:QueryFilter('<ExecuteFilter>d__4'::<>4__this, ldloc:'<ExecuteFilter>d__4'(this)))
	stloc:class [mscorlib]System.Collections.Generic.IEnumerable`1<class Newtonsoft.Json.Linq.JToken>(var_6_2C, ldfld:class [mscorlib]System.Collections.Generic.IEnumerable`1<class Newtonsoft.Json.Linq.JToken>('<ExecuteFilter>d__4'::<>3__current, ldloc:'<ExecuteFilter>d__4'(this)))
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

			// Token: 0x060009F0 RID: 2544 RVA: 0x000186D8 File Offset: 0x000168D8
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				/*
An exception occurred when decompiling this method (060009F0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.IEnumerator Newtonsoft.Json.Linq.JsonPath.QueryFilter/<ExecuteFilter>d__4::System.Collections.IEnumerable.GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.IEnumerator`1<class Newtonsoft.Json.Linq.JToken>(var_0_06, call:IEnumerator`1[exp:class [mscorlib]System.Collections.Generic.IEnumerator`1<class Newtonsoft.Json.Linq.JToken>]('<ExecuteFilter>d__4'::System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator, ldloc:'<ExecuteFilter>d__4'(this)))
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

			// Token: 0x040003E0 RID: 992
			private int <>1__state;

			// Token: 0x040003E1 RID: 993
			private JToken <>2__current;

			// Token: 0x040003E2 RID: 994
			private int <>l__initialThreadId;

			// Token: 0x040003E3 RID: 995
			private IEnumerable<JToken> current;

			// Token: 0x040003E4 RID: 996
			public IEnumerable<JToken> <>3__current;

			// Token: 0x040003E5 RID: 997
			public QueryFilter <>4__this;

			// Token: 0x040003E6 RID: 998
			private IEnumerator<JToken> <>7__wrap1;

			// Token: 0x040003E7 RID: 999
			private IEnumerator<JToken> <>7__wrap2;
		}
	}
}
