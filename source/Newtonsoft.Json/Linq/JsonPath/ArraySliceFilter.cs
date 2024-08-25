using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000E5 RID: 229
	[Preserve]
	internal class ArraySliceFilter : PathFilter
	{
		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x0600098E RID: 2446 RVA: 0x0001729C File Offset: 0x0001549C
		// (set) Token: 0x0600098F RID: 2447 RVA: 0x000172B0 File Offset: 0x000154B0
		public int? Start
		{
			[CompilerGenerated]
			get
			{
				return this.<Start>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Start>k__BackingField = value;
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000990 RID: 2448 RVA: 0x000172C4 File Offset: 0x000154C4
		// (set) Token: 0x06000991 RID: 2449 RVA: 0x000172D8 File Offset: 0x000154D8
		public int? End
		{
			[CompilerGenerated]
			get
			{
				return this.<End>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<End>k__BackingField = value;
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000992 RID: 2450 RVA: 0x000172EC File Offset: 0x000154EC
		// (set) Token: 0x06000993 RID: 2451 RVA: 0x00017300 File Offset: 0x00015500
		public int? Step
		{
			[CompilerGenerated]
			get
			{
				return this.<Step>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Step>k__BackingField = value;
			}
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x0000212A File Offset: 0x0000032A
		public override IEnumerable<JToken> ExecuteFilter(IEnumerable<JToken> current, bool errorWhenNoMatch)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x0000212A File Offset: 0x0000032A
		private bool IsValid(int index, int stopIndex, bool positiveStep)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x00017314 File Offset: 0x00015514
		public ArraySliceFilter()
		{
		}

		// Token: 0x0400039E RID: 926
		[CompilerGenerated]
		private int? <Start>k__BackingField;

		// Token: 0x0400039F RID: 927
		[CompilerGenerated]
		private int? <End>k__BackingField;

		// Token: 0x040003A0 RID: 928
		[CompilerGenerated]
		private int? <Step>k__BackingField;

		// Token: 0x020000E6 RID: 230
		[CompilerGenerated]
		private sealed class <ExecuteFilter>d__12 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IDisposable, IEnumerator
		{
			// Token: 0x06000997 RID: 2455 RVA: 0x00017328 File Offset: 0x00015528
			[DebuggerHidden]
			public <ExecuteFilter>d__12(int <>1__state)
			{
				this.<>1__state = <>1__state;
				int managedThreadId = Thread.CurrentThread.ManagedThreadId;
				this.<>l__initialThreadId = managedThreadId;
			}

			// Token: 0x06000998 RID: 2456 RVA: 0x00017358 File Offset: 0x00015558
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
				int num = this.<>1__state;
				this.<>m__Finally1();
			}

			// Token: 0x06000999 RID: 2457 RVA: 0x00017374 File Offset: 0x00015574
			private bool MoveNext()
			{
				JToken jtoken;
				if (this.<>1__state == 0)
				{
					int? <Step>k__BackingField = this.<>4__this.<Step>k__BackingField;
					IEnumerable<JToken> enumerable = this.current;
					long num = 0L;
					if (num != 0L)
					{
					}
					if (num != 0L)
					{
						if (num == 0L)
						{
						}
						CultureInfo invariantCulture = CultureInfo.InvariantCulture;
						Type type = invariantCulture.GetType();
						string text = "Array slice is not valid on {0}.".FormatWith(invariantCulture, type);
						long num2 = 0L;
						long num3 = 0L;
						int num4 = Math.Max((int)num2, (int)num3);
						if (text == null)
						{
						}
						int num6;
						int num7;
						int num5 = Math.Min(Math.Max(Math.Min(num4, num6), num6), num7);
						if (jtoken == null)
						{
						}
					}
				}
				if (jtoken == null)
				{
				}
				CultureInfo invariantCulture2 = CultureInfo.InvariantCulture;
				object annotations = jtoken._annotations;
				return "*" != null;
			}

			// Token: 0x0600099A RID: 2458 RVA: 0x00017464 File Offset: 0x00015664
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

			// Token: 0x170001B8 RID: 440
			// (get) Token: 0x0600099B RID: 2459 RVA: 0x00017488 File Offset: 0x00015688
			JToken IEnumerator<JToken>.Current
			{
				[DebuggerHidden]
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x0600099C RID: 2460 RVA: 0x0000212A File Offset: 0x0000032A
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x170001B9 RID: 441
			// (get) Token: 0x0600099D RID: 2461 RVA: 0x0001749C File Offset: 0x0001569C
			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					/*
An exception occurred when decompiling this method (0600099D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object Newtonsoft.Json.Linq.JsonPath.ArraySliceFilter/<ExecuteFilter>d__12::System.Collections.IEnumerator.get_Current()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:JToken(var_0_06, ldfld:JToken('<ExecuteFilter>d__12'::<>2__current, ldloc:'<ExecuteFilter>d__12'(this)))
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

			// Token: 0x0600099E RID: 2462 RVA: 0x000174B0 File Offset: 0x000156B0
			[DebuggerHidden]
			IEnumerator<JToken> IEnumerable<JToken>.GetEnumerator()
			{
				/*
An exception occurred when decompiling this method (0600099E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IEnumerator`1<Newtonsoft.Json.Linq.JToken> Newtonsoft.Json.Linq.JsonPath.ArraySliceFilter/<ExecuteFilter>d__12::System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32('<ExecuteFilter>d__12'::<>1__state, ldloc:'<ExecuteFilter>d__12'(this)))
	stloc:int32(var_1_0D, ldfld:int32('<ExecuteFilter>d__12'::<>l__initialThreadId, ldloc:'<ExecuteFilter>d__12'(this)))
	stloc:int32(var_3_1A, callgetter:int32(Thread::get_ManagedThreadId, callgetter:Thread(Thread::get_CurrentThread)))
	stloc:ArraySliceFilter(var_5_24, ldfld:ArraySliceFilter('<ExecuteFilter>d__12'::<>4__this, ldloc:'<ExecuteFilter>d__12'(this)))
	stloc:class [mscorlib]System.Collections.Generic.IEnumerable`1<class Newtonsoft.Json.Linq.JToken>(var_6_2C, ldfld:class [mscorlib]System.Collections.Generic.IEnumerable`1<class Newtonsoft.Json.Linq.JToken>('<ExecuteFilter>d__12'::<>3__current, ldloc:'<ExecuteFilter>d__12'(this)))
	stloc:bool(var_7_34, ldfld:bool('<ExecuteFilter>d__12'::<>3__errorWhenNoMatch, ldloc:'<ExecuteFilter>d__12'(this)))
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

			// Token: 0x0600099F RID: 2463 RVA: 0x000174F4 File Offset: 0x000156F4
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				/*
An exception occurred when decompiling this method (0600099F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.IEnumerator Newtonsoft.Json.Linq.JsonPath.ArraySliceFilter/<ExecuteFilter>d__12::System.Collections.IEnumerable.GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.IEnumerator`1<class Newtonsoft.Json.Linq.JToken>(var_0_06, call:IEnumerator`1[exp:class [mscorlib]System.Collections.Generic.IEnumerator`1<class Newtonsoft.Json.Linq.JToken>]('<ExecuteFilter>d__12'::System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator, ldloc:'<ExecuteFilter>d__12'(this)))
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

			// Token: 0x040003A1 RID: 929
			private int <>1__state;

			// Token: 0x040003A2 RID: 930
			private JToken <>2__current;

			// Token: 0x040003A3 RID: 931
			private int <>l__initialThreadId;

			// Token: 0x040003A4 RID: 932
			public ArraySliceFilter <>4__this;

			// Token: 0x040003A5 RID: 933
			private IEnumerable<JToken> current;

			// Token: 0x040003A6 RID: 934
			public IEnumerable<JToken> <>3__current;

			// Token: 0x040003A7 RID: 935
			private JArray <a>5__1;

			// Token: 0x040003A8 RID: 936
			private int <i>5__2;

			// Token: 0x040003A9 RID: 937
			private int <stepCount>5__3;

			// Token: 0x040003AA RID: 938
			private int <stopIndex>5__4;

			// Token: 0x040003AB RID: 939
			private bool <positiveStep>5__5;

			// Token: 0x040003AC RID: 940
			private bool errorWhenNoMatch;

			// Token: 0x040003AD RID: 941
			public bool <>3__errorWhenNoMatch;

			// Token: 0x040003AE RID: 942
			private JToken <t>5__6;

			// Token: 0x040003AF RID: 943
			private IEnumerator<JToken> <>7__wrap1;
		}
	}
}
