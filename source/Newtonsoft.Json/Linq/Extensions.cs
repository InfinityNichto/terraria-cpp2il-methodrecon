using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000C2 RID: 194
	[Preserve]
	public static class Extensions
	{
		// Token: 0x060006F5 RID: 1781 RVA: 0x00012398 File Offset: 0x00010598
		public static IJEnumerable<JToken> Ancestors<T>(this IEnumerable<T> source) where T : JToken
		{
			ValidationUtils.ArgumentNotNull("source", "source");
			if (!true)
			{
			}
			if (!true)
			{
			}
			IJEnumerable<JToken> ijenumerable;
			return ijenumerable;
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x000123BC File Offset: 0x000105BC
		public static IJEnumerable<JToken> AncestorsAndSelf<T>(this IEnumerable<T> source) where T : JToken
		{
			ValidationUtils.ArgumentNotNull("source", "source");
			if (!true)
			{
			}
			if (!true)
			{
			}
			IJEnumerable<JToken> ijenumerable;
			return ijenumerable;
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x000123E0 File Offset: 0x000105E0
		public static IJEnumerable<JToken> Descendants<T>(this IEnumerable<T> source) where T : JContainer
		{
			ValidationUtils.ArgumentNotNull("source", "source");
			if (!true)
			{
			}
			if (!true)
			{
			}
			IJEnumerable<JToken> ijenumerable;
			return ijenumerable;
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x00012404 File Offset: 0x00010604
		public static IJEnumerable<JToken> DescendantsAndSelf<T>(this IEnumerable<T> source) where T : JContainer
		{
			ValidationUtils.ArgumentNotNull("source", "source");
			if (!true)
			{
			}
			if (!true)
			{
			}
			IJEnumerable<JToken> ijenumerable;
			return ijenumerable;
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x00012428 File Offset: 0x00010628
		public static IJEnumerable<JProperty> Properties(this IEnumerable<JObject> source)
		{
			ValidationUtils.ArgumentNotNull("source", "source");
			if (!true)
			{
			}
			if (!true)
			{
			}
			IEnumerable enumerable;
			return Extensions.AsJEnumerable(enumerable);
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x00012450 File Offset: 0x00010650
		public static IJEnumerable<JToken> Values(this IEnumerable<JToken> source, object key)
		{
			IEnumerable enumerable;
			return Extensions.AsJEnumerable(enumerable);
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x00012464 File Offset: 0x00010664
		public static IJEnumerable<JToken> Values(this IEnumerable<JToken> source)
		{
			IJEnumerable<JToken> ijenumerable;
			return ijenumerable;
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x0000212A File Offset: 0x0000032A
		public static IEnumerable<U> Values<U>(this IEnumerable<JToken> source, object key)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x0000212A File Offset: 0x0000032A
		public static IEnumerable<U> Values<U>(this IEnumerable<JToken> source)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x0000212A File Offset: 0x0000032A
		public static U Value<U>(this IEnumerable<JToken> value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x00012474 File Offset: 0x00010674
		public static U Value<U, T>(this IEnumerable<T> value) where T : JToken
		{
			ValidationUtils.ArgumentNotNull("value", "value");
			return "value";
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x0000212A File Offset: 0x0000032A
		internal static IEnumerable<U> Values<U, T>(this IEnumerable<T> source, object key) where T : JToken
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x00012498 File Offset: 0x00010698
		public static IJEnumerable<JToken> Children<T>(this IEnumerable<T> source) where T : JToken
		{
			IJEnumerable<JToken> ijenumerable;
			return ijenumerable;
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x000124A8 File Offset: 0x000106A8
		public static IEnumerable<U> Children<U, T>(this IEnumerable<T> source) where T : JToken
		{
			ValidationUtils.ArgumentNotNull("source", "source");
			if (!true)
			{
			}
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x000124CC File Offset: 0x000106CC
		internal static IEnumerable<U> Convert<U, T>(this IEnumerable<T> source) where T : JToken
		{
			return source;
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x000124DC File Offset: 0x000106DC
		internal static U Convert<U, T>(this T token) where T : JToken
		{
			/*
An exception occurred when decompiling this method (06000704)

ICSharpCode.Decompiler.DecompilerException: Error decompiling U Newtonsoft.Json.Linq.Extensions::Convert<U,T>(T)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0035:
	stloc:CultureInfo(var_12_3D, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
	stloc:Type(var_13_46, call:Type(object::GetType, ldloc:object(var_9)))
	stloc:string(var_15_58, call:string(StringUtils::FormatWith, ldstr:string("Cannot cast {0} to {1}."), ldloc:CultureInfo[exp:IFormatProvider](var_12_3D), ldloc:Type[exp:object](var_13_46), ldloc:Type[exp:object](var_14)))
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

		// Token: 0x06000705 RID: 1797 RVA: 0x00012544 File Offset: 0x00010744
		public static IJEnumerable<JToken> AsJEnumerable(this IEnumerable<JToken> source)
		{
			IJEnumerable ijenumerable;
			return ijenumerable;
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x00012554 File Offset: 0x00010754
		public static IJEnumerable<T> AsJEnumerable<T>(this IEnumerable<T> source) where T : JToken
		{
			while (source == null || source != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x020000C3 RID: 195
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c__0<T> where T : JToken
		{
			// Token: 0x06000707 RID: 1799 RVA: 0x0001256C File Offset: 0x0001076C
			// Note: this type is marked as 'beforefieldinit'.
			static <>c__0()
			{
			}

			// Token: 0x06000708 RID: 1800 RVA: 0x0001257C File Offset: 0x0001077C
			public <>c__0()
			{
			}

			// Token: 0x06000709 RID: 1801 RVA: 0x00012590 File Offset: 0x00010790
			internal IEnumerable<JToken> <Ancestors>b__0_0(T j)
			{
				IEnumerable<JToken> enumerable;
				return enumerable;
			}

			// Token: 0x040002FD RID: 765
			public static readonly Extensions.<>c__0<T> <>9;

			// Token: 0x040002FE RID: 766
			public static Func<T, IEnumerable<JToken>> <>9__0_0;
		}

		// Token: 0x020000C4 RID: 196
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c__1<T> where T : JToken
		{
			// Token: 0x0600070A RID: 1802 RVA: 0x000125A0 File Offset: 0x000107A0
			// Note: this type is marked as 'beforefieldinit'.
			static <>c__1()
			{
			}

			// Token: 0x0600070B RID: 1803 RVA: 0x000125B0 File Offset: 0x000107B0
			public <>c__1()
			{
			}

			// Token: 0x0600070C RID: 1804 RVA: 0x000125C4 File Offset: 0x000107C4
			internal IEnumerable<JToken> <AncestorsAndSelf>b__1_0(T j)
			{
				IEnumerable<JToken> enumerable;
				return enumerable;
			}

			// Token: 0x040002FF RID: 767
			public static readonly Extensions.<>c__1<T> <>9;

			// Token: 0x04000300 RID: 768
			public static Func<T, IEnumerable<JToken>> <>9__1_0;
		}

		// Token: 0x020000C5 RID: 197
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c__2<T> where T : JContainer
		{
			// Token: 0x0600070D RID: 1805 RVA: 0x000125D4 File Offset: 0x000107D4
			// Note: this type is marked as 'beforefieldinit'.
			static <>c__2()
			{
			}

			// Token: 0x0600070E RID: 1806 RVA: 0x000125E4 File Offset: 0x000107E4
			public <>c__2()
			{
			}

			// Token: 0x0600070F RID: 1807 RVA: 0x000125F8 File Offset: 0x000107F8
			internal IEnumerable<JToken> <Descendants>b__2_0(T j)
			{
				IEnumerable<JToken> enumerable;
				return enumerable;
			}

			// Token: 0x04000301 RID: 769
			public static readonly Extensions.<>c__2<T> <>9;

			// Token: 0x04000302 RID: 770
			public static Func<T, IEnumerable<JToken>> <>9__2_0;
		}

		// Token: 0x020000C6 RID: 198
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c__3<T> where T : JContainer
		{
			// Token: 0x06000710 RID: 1808 RVA: 0x00012608 File Offset: 0x00010808
			// Note: this type is marked as 'beforefieldinit'.
			static <>c__3()
			{
			}

			// Token: 0x06000711 RID: 1809 RVA: 0x00012618 File Offset: 0x00010818
			public <>c__3()
			{
			}

			// Token: 0x06000712 RID: 1810 RVA: 0x0001262C File Offset: 0x0001082C
			internal IEnumerable<JToken> <DescendantsAndSelf>b__3_0(T j)
			{
				IEnumerable<JToken> enumerable;
				return enumerable;
			}

			// Token: 0x04000303 RID: 771
			public static readonly Extensions.<>c__3<T> <>9;

			// Token: 0x04000304 RID: 772
			public static Func<T, IEnumerable<JToken>> <>9__3_0;
		}

		// Token: 0x020000C7 RID: 199
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000713 RID: 1811 RVA: 0x0001263C File Offset: 0x0001083C
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06000714 RID: 1812 RVA: 0x0001264C File Offset: 0x0001084C
			public <>c()
			{
			}

			// Token: 0x06000715 RID: 1813 RVA: 0x00012660 File Offset: 0x00010860
			internal IEnumerable<JProperty> <Properties>b__4_0(JObject d)
			{
				return d.Properties();
			}

			// Token: 0x04000305 RID: 773
			public static readonly Extensions.<>c <>9;

			// Token: 0x04000306 RID: 774
			public static Func<JObject, IEnumerable<JProperty>> <>9__4_0;
		}

		// Token: 0x020000C8 RID: 200
		[CompilerGenerated]
		private sealed class <Values>d__11<T, U> : IEnumerable<U>, IEnumerable, IEnumerator<U>, IDisposable, IEnumerator where T : JToken
		{
			// Token: 0x06000716 RID: 1814 RVA: 0x00012674 File Offset: 0x00010874
			[DebuggerHidden]
			public <Values>d__11(int <>1__state)
			{
				this.<>1__state = <>1__state;
				int managedThreadId = Thread.CurrentThread.ManagedThreadId;
				this.source = managedThreadId;
			}

			// Token: 0x06000717 RID: 1815 RVA: 0x000126A4 File Offset: 0x000108A4
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
				int num = this.<>1__state;
				if (!false)
				{
					return;
				}
				throw new OutOfMemoryException();
			}

			// Token: 0x06000718 RID: 1816 RVA: 0x000126D4 File Offset: 0x000108D4
			private bool MoveNext()
			{
				int num = this.<>1__state;
				return "source" != null;
			}

			// Token: 0x06000719 RID: 1817 RVA: 0x00012730 File Offset: 0x00010930
			private void <>m__Finally1()
			{
				int num = 1;
				IEnumerator<JToken> enumerator = this.<>7__wrap2;
				this.<>1__state = num;
				if (enumerator != null)
				{
					return;
				}
			}

			// Token: 0x0600071A RID: 1818 RVA: 0x00012754 File Offset: 0x00010954
			private void <>m__Finally2()
			{
				int num = 1;
				this.<>1__state = num;
			}

			// Token: 0x17000157 RID: 343
			// (get) Token: 0x0600071B RID: 1819 RVA: 0x0000212A File Offset: 0x0000032A
			U IEnumerator<U>.Current
			{
				[DebuggerHidden]
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x0600071C RID: 1820 RVA: 0x0000212A File Offset: 0x0000032A
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x17000158 RID: 344
			// (get) Token: 0x0600071D RID: 1821 RVA: 0x0000212A File Offset: 0x0000032A
			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x0600071E RID: 1822 RVA: 0x0001276C File Offset: 0x0001096C
			[DebuggerHidden]
			IEnumerator<U> IEnumerable<U>.GetEnumerator()
			{
				/*
An exception occurred when decompiling this method (0600071E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IEnumerator`1<U> Newtonsoft.Json.Linq.Extensions/<Values>d__11`2::System.Collections.Generic.IEnumerable<U>.GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32('<Values>d__11`2'::<>1__state, ldloc:'<Values>d__11`2'(this)))
	stloc:IEnumerable`1(var_1_0D, ldfld:class [mscorlib]System.Collections.Generic.IEnumerable`1<!T>[exp:IEnumerable`1]('<Values>d__11`2'::source, ldloc:'<Values>d__11`2'(this)))
	stloc:int32(var_3_1A, callgetter:int32(Thread::get_ManagedThreadId, callgetter:Thread(Thread::get_CurrentThread)))
	stloc:IEnumerable`1(var_4_21, ldfld:class [mscorlib]System.Collections.Generic.IEnumerable`1<!T>[exp:IEnumerable`1]('<Values>d__11`2'::source, ldloc:'<Values>d__11`2'(this)))
	stloc:IEnumerable`1(var_5_29, ldfld:class [mscorlib]System.Collections.Generic.IEnumerable`1<!T>[exp:IEnumerable`1]('<Values>d__11`2'::source, ldloc:'<Values>d__11`2'(this)))
	stloc:object(var_6_31, ldfld:object('<Values>d__11`2'::key, ldloc:'<Values>d__11`2'(this)))
	stloc:JToken(var_7_39, ldfld:JToken('<Values>d__11`2'::<token>5__1, ldloc:'<Values>d__11`2'(this)))
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

			// Token: 0x0600071F RID: 1823 RVA: 0x0000212A File Offset: 0x0000032A
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x04000307 RID: 775
			private int <>1__state;

			// Token: 0x04000308 RID: 776
			private U <>2__current;

			// Token: 0x04000309 RID: 777
			private int <>l__initialThreadId;

			// Token: 0x0400030A RID: 778
			private IEnumerable<T> source;

			// Token: 0x0400030B RID: 779
			public IEnumerable<T> <>3__source;

			// Token: 0x0400030C RID: 780
			private object key;

			// Token: 0x0400030D RID: 781
			public object <>3__key;

			// Token: 0x0400030E RID: 782
			private JToken <token>5__1;

			// Token: 0x0400030F RID: 783
			private IEnumerator<T> <>7__wrap1;

			// Token: 0x04000310 RID: 784
			private IEnumerator<JToken> <>7__wrap2;
		}

		// Token: 0x020000C9 RID: 201
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c__13<T, U> where T : JToken
		{
			// Token: 0x06000720 RID: 1824 RVA: 0x000127B4 File Offset: 0x000109B4
			// Note: this type is marked as 'beforefieldinit'.
			static <>c__13()
			{
			}

			// Token: 0x06000721 RID: 1825 RVA: 0x000127C4 File Offset: 0x000109C4
			public <>c__13()
			{
			}

			// Token: 0x06000722 RID: 1826 RVA: 0x0000212A File Offset: 0x0000032A
			internal IEnumerable<JToken> <Children>b__13_0(T c)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x04000311 RID: 785
			public static readonly Extensions.<>c__13<T, U> <>9;

			// Token: 0x04000312 RID: 786
			public static Func<T, IEnumerable<JToken>> <>9__13_0;
		}

		// Token: 0x020000CA RID: 202
		[CompilerGenerated]
		private sealed class <Convert>d__14<T, U> : IEnumerable<U>, IEnumerable, IEnumerator<U>, IDisposable, IEnumerator where T : JToken
		{
			// Token: 0x06000723 RID: 1827 RVA: 0x000127D8 File Offset: 0x000109D8
			[DebuggerHidden]
			public <Convert>d__14(int <>1__state)
			{
				this.<>1__state = <>1__state;
				int managedThreadId = Thread.CurrentThread.ManagedThreadId;
				this.source = managedThreadId;
			}

			// Token: 0x06000724 RID: 1828 RVA: 0x00012808 File Offset: 0x00010A08
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
				int num = this.<>1__state;
			}

			// Token: 0x06000725 RID: 1829 RVA: 0x00012820 File Offset: 0x00010A20
			private bool MoveNext()
			{
				if (this.<>1__state == 0)
				{
					IEnumerable enumerable = this.<>3__source;
					return false;
				}
				throw new OutOfMemoryException();
			}

			// Token: 0x06000726 RID: 1830 RVA: 0x00012874 File Offset: 0x00010A74
			private void <>m__Finally1()
			{
				int num = 1;
				this.<>1__state = num;
			}

			// Token: 0x17000159 RID: 345
			// (get) Token: 0x06000727 RID: 1831 RVA: 0x0000212A File Offset: 0x0000032A
			U IEnumerator<U>.Current
			{
				[DebuggerHidden]
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x06000728 RID: 1832 RVA: 0x0000212A File Offset: 0x0000032A
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x1700015A RID: 346
			// (get) Token: 0x06000729 RID: 1833 RVA: 0x0000212A File Offset: 0x0000032A
			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x0600072A RID: 1834 RVA: 0x0001288C File Offset: 0x00010A8C
			[DebuggerHidden]
			IEnumerator<U> IEnumerable<U>.GetEnumerator()
			{
				/*
An exception occurred when decompiling this method (0600072A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IEnumerator`1<U> Newtonsoft.Json.Linq.Extensions/<Convert>d__14`2::System.Collections.Generic.IEnumerable<U>.GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32('<Convert>d__14`2'::<>1__state, ldloc:'<Convert>d__14`2'(this)))
	stloc:IEnumerable`1(var_1_0D, ldfld:class [mscorlib]System.Collections.Generic.IEnumerable`1<!T>[exp:IEnumerable`1]('<Convert>d__14`2'::source, ldloc:'<Convert>d__14`2'(this)))
	stloc:int32(var_3_1A, callgetter:int32(Thread::get_ManagedThreadId, callgetter:Thread(Thread::get_CurrentThread)))
	stloc:IEnumerable`1(var_4_21, ldfld:class [mscorlib]System.Collections.Generic.IEnumerable`1<!T>[exp:IEnumerable`1]('<Convert>d__14`2'::source, ldloc:'<Convert>d__14`2'(this)))
	stloc:IEnumerable`1(var_5_29, ldfld:class [mscorlib]System.Collections.Generic.IEnumerable`1<!T>[exp:IEnumerable`1]('<Convert>d__14`2'::source, ldloc:'<Convert>d__14`2'(this)))
	stloc:IEnumerator`1(var_6_31, ldfld:class [mscorlib]System.Collections.Generic.IEnumerator`1<!T>[exp:IEnumerator`1]('<Convert>d__14`2'::<>7__wrap1, ldloc:'<Convert>d__14`2'(this)))
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

			// Token: 0x0600072B RID: 1835 RVA: 0x0000212A File Offset: 0x0000032A
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x04000313 RID: 787
			private int <>1__state;

			// Token: 0x04000314 RID: 788
			private U <>2__current;

			// Token: 0x04000315 RID: 789
			private int <>l__initialThreadId;

			// Token: 0x04000316 RID: 790
			private IEnumerable<T> source;

			// Token: 0x04000317 RID: 791
			public IEnumerable<T> <>3__source;

			// Token: 0x04000318 RID: 792
			private IEnumerator<T> <>7__wrap1;
		}
	}
}
