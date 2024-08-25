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
	// Token: 0x020000E9 RID: 233
	[Preserve]
	internal class FieldMultipleFilter : PathFilter
	{
		// Token: 0x170001BD RID: 445
		// (get) Token: 0x060009AE RID: 2478 RVA: 0x00017758 File Offset: 0x00015958
		// (set) Token: 0x060009AF RID: 2479 RVA: 0x0001776C File Offset: 0x0001596C
		public List<string> Names
		{
			[CompilerGenerated]
			get
			{
				return this.<Names>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Names>k__BackingField = value;
			}
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x0000212A File Offset: 0x0000032A
		public override IEnumerable<JToken> ExecuteFilter(IEnumerable<JToken> current, bool errorWhenNoMatch)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x00017780 File Offset: 0x00015980
		public FieldMultipleFilter()
		{
		}

		// Token: 0x040003BD RID: 957
		[CompilerGenerated]
		private List<string> <Names>k__BackingField;

		// Token: 0x020000EA RID: 234
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060009B2 RID: 2482 RVA: 0x00017794 File Offset: 0x00015994
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060009B3 RID: 2483 RVA: 0x000177A4 File Offset: 0x000159A4
			public <>c()
			{
			}

			// Token: 0x060009B4 RID: 2484 RVA: 0x000177B8 File Offset: 0x000159B8
			internal string <ExecuteFilter>b__4_0(string n)
			{
				return "'" + n + "'";
			}

			// Token: 0x040003BE RID: 958
			public static readonly FieldMultipleFilter.<>c <>9;

			// Token: 0x040003BF RID: 959
			public static Func<string, string> <>9__4_0;
		}

		// Token: 0x020000EB RID: 235
		[CompilerGenerated]
		private sealed class <ExecuteFilter>d__4 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IDisposable, IEnumerator
		{
			// Token: 0x060009B5 RID: 2485 RVA: 0x000177D8 File Offset: 0x000159D8
			[DebuggerHidden]
			public <ExecuteFilter>d__4(int <>1__state)
			{
				this.<>1__state = <>1__state;
				int managedThreadId = Thread.CurrentThread.ManagedThreadId;
				this.<>l__initialThreadId = managedThreadId;
			}

			// Token: 0x060009B6 RID: 2486 RVA: 0x00017808 File Offset: 0x00015A08
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
				int num = this.<>1__state;
			}

			// Token: 0x060009B7 RID: 2487 RVA: 0x00017848 File Offset: 0x00015A48
			private bool MoveNext()
			{
				IEnumerable<JToken> enumerable;
				do
				{
					int num = this.<>1__state;
					if (num == 0)
					{
						enumerable = this.current;
						this.<>1__state = num;
					}
				}
				while (enumerable == null);
				if (false)
				{
				}
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
				string text;
				Type type = text.GetType();
				string text2 = "Properties {0} not valid on {1}.".FormatWith(invariantCulture, text, type);
				JToken jtoken;
				if (jtoken == null)
				{
				}
				int num2 = 1;
				text2._stringLength = num2;
				if (jtoken == null)
				{
				}
				CultureInfo invariantCulture2 = CultureInfo.InvariantCulture;
				throw new OutOfMemoryException();
			}

			// Token: 0x060009B8 RID: 2488 RVA: 0x000178C8 File Offset: 0x00015AC8
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

			// Token: 0x060009B9 RID: 2489 RVA: 0x000178EC File Offset: 0x00015AEC
			private void <>m__Finally2()
			{
				int num = 1;
				this.<>1__state = num;
			}

			// Token: 0x170001BE RID: 446
			// (get) Token: 0x060009BA RID: 2490 RVA: 0x00017904 File Offset: 0x00015B04
			JToken IEnumerator<JToken>.Current
			{
				[DebuggerHidden]
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x060009BB RID: 2491 RVA: 0x0000212A File Offset: 0x0000032A
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x170001BF RID: 447
			// (get) Token: 0x060009BC RID: 2492 RVA: 0x00017918 File Offset: 0x00015B18
			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					/*
An exception occurred when decompiling this method (060009BC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object Newtonsoft.Json.Linq.JsonPath.FieldMultipleFilter/<ExecuteFilter>d__4::System.Collections.IEnumerator.get_Current()

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

			// Token: 0x060009BD RID: 2493 RVA: 0x0001792C File Offset: 0x00015B2C
			[DebuggerHidden]
			IEnumerator<JToken> IEnumerable<JToken>.GetEnumerator()
			{
				/*
An exception occurred when decompiling this method (060009BD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IEnumerator`1<Newtonsoft.Json.Linq.JToken> Newtonsoft.Json.Linq.JsonPath.FieldMultipleFilter/<ExecuteFilter>d__4::System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32('<ExecuteFilter>d__4'::<>1__state, ldloc:'<ExecuteFilter>d__4'(this)))
	stloc:int32(var_1_0D, ldfld:int32('<ExecuteFilter>d__4'::<>l__initialThreadId, ldloc:'<ExecuteFilter>d__4'(this)))
	stloc:int32(var_3_1A, callgetter:int32(Thread::get_ManagedThreadId, callgetter:Thread(Thread::get_CurrentThread)))
	stloc:FieldMultipleFilter(var_5_24, ldfld:FieldMultipleFilter('<ExecuteFilter>d__4'::<>4__this, ldloc:'<ExecuteFilter>d__4'(this)))
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

			// Token: 0x060009BE RID: 2494 RVA: 0x00017970 File Offset: 0x00015B70
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				/*
An exception occurred when decompiling this method (060009BE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.IEnumerator Newtonsoft.Json.Linq.JsonPath.FieldMultipleFilter/<ExecuteFilter>d__4::System.Collections.IEnumerable.GetEnumerator()

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

			// Token: 0x040003C0 RID: 960
			private int <>1__state;

			// Token: 0x040003C1 RID: 961
			private JToken <>2__current;

			// Token: 0x040003C2 RID: 962
			private int <>l__initialThreadId;

			// Token: 0x040003C3 RID: 963
			private IEnumerable<JToken> current;

			// Token: 0x040003C4 RID: 964
			public IEnumerable<JToken> <>3__current;

			// Token: 0x040003C5 RID: 965
			public FieldMultipleFilter <>4__this;

			// Token: 0x040003C6 RID: 966
			private JObject <o>5__1;

			// Token: 0x040003C7 RID: 967
			private bool errorWhenNoMatch;

			// Token: 0x040003C8 RID: 968
			public bool <>3__errorWhenNoMatch;

			// Token: 0x040003C9 RID: 969
			private string <name>5__2;

			// Token: 0x040003CA RID: 970
			private JToken <t>5__3;

			// Token: 0x040003CB RID: 971
			private IEnumerator<JToken> <>7__wrap1;

			// Token: 0x040003CC RID: 972
			private List<string>.Enumerator <>7__wrap2;
		}
	}
}
