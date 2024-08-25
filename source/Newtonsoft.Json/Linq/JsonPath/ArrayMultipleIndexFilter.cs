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
	// Token: 0x020000E3 RID: 227
	[Preserve]
	internal class ArrayMultipleIndexFilter : PathFilter
	{
		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000980 RID: 2432 RVA: 0x000170F8 File Offset: 0x000152F8
		// (set) Token: 0x06000981 RID: 2433 RVA: 0x0001710C File Offset: 0x0001530C
		public List<int> Indexes
		{
			[CompilerGenerated]
			get
			{
				return this.<Indexes>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Indexes>k__BackingField = value;
			}
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x0000212A File Offset: 0x0000032A
		public override IEnumerable<JToken> ExecuteFilter(IEnumerable<JToken> current, bool errorWhenNoMatch)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x00017120 File Offset: 0x00015320
		public ArrayMultipleIndexFilter()
		{
		}

		// Token: 0x04000392 RID: 914
		[CompilerGenerated]
		private List<int> <Indexes>k__BackingField;

		// Token: 0x020000E4 RID: 228
		[CompilerGenerated]
		private sealed class <ExecuteFilter>d__4 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IDisposable, IEnumerator
		{
			// Token: 0x06000984 RID: 2436 RVA: 0x00017134 File Offset: 0x00015334
			[DebuggerHidden]
			public <ExecuteFilter>d__4(int <>1__state)
			{
				this.<>1__state = <>1__state;
				int managedThreadId = Thread.CurrentThread.ManagedThreadId;
				this.<>l__initialThreadId = managedThreadId;
			}

			// Token: 0x06000985 RID: 2437 RVA: 0x00017164 File Offset: 0x00015364
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
				int num = this.<>1__state;
			}

			// Token: 0x06000986 RID: 2438 RVA: 0x000171A4 File Offset: 0x000153A4
			private bool MoveNext()
			{
				int num = this.<>1__state;
				if (num == 0)
				{
					IEnumerable<JToken> enumerable = this.current;
					this.<>1__state = num;
				}
				JToken jtoken;
				while (jtoken == null)
				{
				}
				throw new OutOfMemoryException();
			}

			// Token: 0x06000987 RID: 2439 RVA: 0x000171E0 File Offset: 0x000153E0
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

			// Token: 0x06000988 RID: 2440 RVA: 0x00017204 File Offset: 0x00015404
			private void <>m__Finally2()
			{
				int num = 1;
				this.<>1__state = num;
			}

			// Token: 0x170001B3 RID: 435
			// (get) Token: 0x06000989 RID: 2441 RVA: 0x0001721C File Offset: 0x0001541C
			JToken IEnumerator<JToken>.Current
			{
				[DebuggerHidden]
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x0600098A RID: 2442 RVA: 0x0000212A File Offset: 0x0000032A
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x170001B4 RID: 436
			// (get) Token: 0x0600098B RID: 2443 RVA: 0x00017230 File Offset: 0x00015430
			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					/*
An exception occurred when decompiling this method (0600098B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object Newtonsoft.Json.Linq.JsonPath.ArrayMultipleIndexFilter/<ExecuteFilter>d__4::System.Collections.IEnumerator.get_Current()

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

			// Token: 0x0600098C RID: 2444 RVA: 0x00017244 File Offset: 0x00015444
			[DebuggerHidden]
			IEnumerator<JToken> IEnumerable<JToken>.GetEnumerator()
			{
				/*
An exception occurred when decompiling this method (0600098C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IEnumerator`1<Newtonsoft.Json.Linq.JToken> Newtonsoft.Json.Linq.JsonPath.ArrayMultipleIndexFilter/<ExecuteFilter>d__4::System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32('<ExecuteFilter>d__4'::<>1__state, ldloc:'<ExecuteFilter>d__4'(this)))
	stloc:int32(var_1_0D, ldfld:int32('<ExecuteFilter>d__4'::<>l__initialThreadId, ldloc:'<ExecuteFilter>d__4'(this)))
	stloc:int32(var_3_1A, callgetter:int32(Thread::get_ManagedThreadId, callgetter:Thread(Thread::get_CurrentThread)))
	stloc:ArrayMultipleIndexFilter(var_5_24, ldfld:ArrayMultipleIndexFilter('<ExecuteFilter>d__4'::<>4__this, ldloc:'<ExecuteFilter>d__4'(this)))
	stloc:class [mscorlib]System.Collections.Generic.IEnumerable`1<class Newtonsoft.Json.Linq.JToken>(var_6_2C, ldfld:class [mscorlib]System.Collections.Generic.IEnumerable`1<class Newtonsoft.Json.Linq.JToken>('<ExecuteFilter>d__4'::<>3__current, ldloc:'<ExecuteFilter>d__4'(this)))
	stloc:bool(var_7_34, ldfld:bool('<ExecuteFilter>d__4'::<>3__errorWhenNoMatch, ldloc:'<ExecuteFilter>d__4'(this)))
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

			// Token: 0x0600098D RID: 2445 RVA: 0x00017288 File Offset: 0x00015488
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				/*
An exception occurred when decompiling this method (0600098D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.IEnumerator Newtonsoft.Json.Linq.JsonPath.ArrayMultipleIndexFilter/<ExecuteFilter>d__4::System.Collections.IEnumerable.GetEnumerator()

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

			// Token: 0x04000393 RID: 915
			private int <>1__state;

			// Token: 0x04000394 RID: 916
			private JToken <>2__current;

			// Token: 0x04000395 RID: 917
			private int <>l__initialThreadId;

			// Token: 0x04000396 RID: 918
			private IEnumerable<JToken> current;

			// Token: 0x04000397 RID: 919
			public IEnumerable<JToken> <>3__current;

			// Token: 0x04000398 RID: 920
			public ArrayMultipleIndexFilter <>4__this;

			// Token: 0x04000399 RID: 921
			private JToken <t>5__1;

			// Token: 0x0400039A RID: 922
			private bool errorWhenNoMatch;

			// Token: 0x0400039B RID: 923
			public bool <>3__errorWhenNoMatch;

			// Token: 0x0400039C RID: 924
			private IEnumerator<JToken> <>7__wrap1;

			// Token: 0x0400039D RID: 925
			private List<int>.Enumerator <>7__wrap2;
		}
	}
}
