using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;

namespace System.Linq
{
	// Token: 0x02000008 RID: 8
	public static class Enumerable
	{
		// Token: 0x06000037 RID: 55 RVA: 0x0000252C File Offset: 0x0000072C
		public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			if (source == null)
			{
				Exception ex = Error.ArgumentNull("predicate");
				throw new InvalidCastException();
			}
			if (source == null)
			{
				return source;
			}
			if (source != null)
			{
				return source;
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002568 File Offset: 0x00000768
		public static IEnumerable<TResult> Select<TResult, TSource>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
		{
			if (source == null)
			{
				Exception ex = Error.ArgumentNull("selector");
				throw new InvalidCastException();
			}
			if (source == null)
			{
				return source;
			}
			if (source != null)
			{
				return source;
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000025A4 File Offset: 0x000007A4
		public static IEnumerable<TResult> Select<TResult, TSource>(this IEnumerable<TSource> source, Func<TSource, int, TResult> selector)
		{
			/*
An exception occurred when decompiling this method (06000039)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable::Select<TResult,TSource>(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`3<TSource,System.Int32,TResult>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0009:
	stloc:Exception(var_0_13, call:Exception(Error::ArgumentNull, ldstr:string("selector")))
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

		// Token: 0x0600003A RID: 58 RVA: 0x00002050 File Offset: 0x00000250
		private static IEnumerable<TResult> SelectIterator<TResult, TSource>(IEnumerable<TSource> source, Func<TSource, int, TResult> selector)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000025C4 File Offset: 0x000007C4
		private static Func<TSource, bool> CombinePredicates<TSource>(Func<TSource, bool> predicate1, Func<TSource, bool> predicate2)
		{
			return predicate2;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000025D4 File Offset: 0x000007D4
		private static Func<TSource, TResult> CombineSelectors<TSource, TResult, TMiddle>(Func<TSource, TMiddle> selector1, Func<TMiddle, TResult> selector2)
		{
			return selector2;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000025E4 File Offset: 0x000007E4
		public static IEnumerable<TResult> SelectMany<TResult, TSource>(this IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector)
		{
			/*
An exception occurred when decompiling this method (0600003D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable::SelectMany<TResult,TSource>(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Collections.Generic.IEnumerable`1<TResult>>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0009:
	stloc:Exception(var_0_13, call:Exception(Error::ArgumentNull, ldstr:string("selector")))
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

		// Token: 0x0600003E RID: 62 RVA: 0x00002050 File Offset: 0x00000250
		private static IEnumerable<TResult> SelectManyIterator<TResult, TSource>(IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002604 File Offset: 0x00000804
		public static IEnumerable<TSource> Take<TSource>(this IEnumerable<TSource> source, int count)
		{
			/*
An exception occurred when decompiling this method (0600003F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable::Take<TSource>(System.Collections.Generic.IEnumerable`1<TSource>,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Exception(var_0_0A, call:Exception(Error::ArgumentNull, ldstr:string("source")))
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

		// Token: 0x06000040 RID: 64 RVA: 0x00002050 File Offset: 0x00000250
		private static IEnumerable<TSource> TakeIterator<TSource>(IEnumerable<TSource> source, int count)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002050 File Offset: 0x00000250
		public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002050 File Offset: 0x00000250
		public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0000261C File Offset: 0x0000081C
		public static IOrderedEnumerable<TSource> ThenBy<TSource, TKey>(this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			/*
An exception occurred when decompiling this method (06000043)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Linq.IOrderedEnumerable`1<TSource> System.Linq.Enumerable::ThenBy<TSource,TKey>(System.Linq.IOrderedEnumerable`1<TSource>,System.Func`2<TSource,TKey>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Exception(var_0_0A, call:Exception(Error::ArgumentNull, ldstr:string("source")))
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

		// Token: 0x06000044 RID: 68 RVA: 0x00002050 File Offset: 0x00000250
		public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TKey, TSource>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002634 File Offset: 0x00000834
		public static IEnumerable<TSource> Distinct<TSource>(this IEnumerable<TSource> source)
		{
			/*
An exception occurred when decompiling this method (06000045)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable::Distinct<TSource>(System.Collections.Generic.IEnumerable`1<TSource>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Exception(var_0_0A, call:Exception(Error::ArgumentNull, ldstr:string("source")))
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

		// Token: 0x06000046 RID: 70 RVA: 0x00002050 File Offset: 0x00000250
		private static IEnumerable<TSource> DistinctIterator<TSource>(IEnumerable<TSource> source, IEqualityComparer<TSource> comparer)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000264C File Offset: 0x0000084C
		public static IEnumerable<TSource> Union<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
		{
			/*
An exception occurred when decompiling this method (06000047)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable::Union<TSource>(System.Collections.Generic.IEnumerable`1<TSource>,System.Collections.Generic.IEnumerable`1<TSource>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0009:
	stloc:Exception(var_0_13, call:Exception(Error::ArgumentNull, ldstr:string("second")))
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

		// Token: 0x06000048 RID: 72 RVA: 0x00002050 File Offset: 0x00000250
		private static IEnumerable<TSource> UnionIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000266C File Offset: 0x0000086C
		public static IEnumerable<TSource> Except<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
		{
			/*
An exception occurred when decompiling this method (06000049)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable::Except<TSource>(System.Collections.Generic.IEnumerable`1<TSource>,System.Collections.Generic.IEnumerable`1<TSource>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0009:
	stloc:Exception(var_0_13, call:Exception(Error::ArgumentNull, ldstr:string("second")))
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

		// Token: 0x0600004A RID: 74 RVA: 0x00002050 File Offset: 0x00000250
		private static IEnumerable<TSource> ExceptIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002050 File Offset: 0x00000250
		public static bool SequenceEqual<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000268C File Offset: 0x0000088C
		public static bool SequenceEqual<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
		{
			if (second != null)
			{
				if (first == null)
				{
					Exception ex = Error.ArgumentNull("second");
					throw new OutOfMemoryException();
				}
				while (second != null)
				{
				}
			}
			return "first" != null;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002740 File Offset: 0x00000940
		public static TSource[] ToArray<TSource>(this IEnumerable<TSource> source)
		{
			/*
An exception occurred when decompiling this method (0600004D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling TSource[] System.Linq.Enumerable::ToArray<TSource>(System.Collections.Generic.IEnumerable`1<TSource>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Exception(var_0_0A, call:Exception(Error::ArgumentNull, ldstr:string("source")))
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

		// Token: 0x0600004E RID: 78 RVA: 0x00002758 File Offset: 0x00000958
		public static List<TSource> ToList<TSource>(this IEnumerable<TSource> source)
		{
			/*
An exception occurred when decompiling this method (0600004E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.List`1<TSource> System.Linq.Enumerable::ToList<TSource>(System.Collections.Generic.IEnumerable`1<TSource>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Exception(var_0_0A, call:Exception(Error::ArgumentNull, ldstr:string("source")))
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

		// Token: 0x0600004F RID: 79 RVA: 0x00002050 File Offset: 0x00000250
		public static Dictionary<TKey, TElement> ToDictionary<TKey, TElement, TSource>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002770 File Offset: 0x00000970
		public static Dictionary<TKey, TElement> ToDictionary<TKey, TElement, TSource>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
		{
			if (source != null)
			{
				if (keySelector != null)
				{
					long num = 0L;
					if (elementSelector != null)
					{
					}
					if (num == 0L)
					{
						return "source";
					}
				}
				else
				{
					Exception ex = Error.ArgumentNull("elementSelector");
				}
				throw new OutOfMemoryException();
			}
			return "keySelector";
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000027C0 File Offset: 0x000009C0
		public static IEnumerable<TResult> OfType<TResult>(this IEnumerable source)
		{
			/*
An exception occurred when decompiling this method (06000051)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable::OfType<TResult>(System.Collections.IEnumerable)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Exception(var_0_0A, call:Exception(Error::ArgumentNull, ldstr:string("source")))
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

		// Token: 0x06000052 RID: 82 RVA: 0x00002050 File Offset: 0x00000250
		private static IEnumerable<TResult> OfTypeIterator<TResult>(IEnumerable source)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000027D8 File Offset: 0x000009D8
		public static IEnumerable<TResult> Cast<TResult>(this IEnumerable source)
		{
			/*
An exception occurred when decompiling this method (06000053)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable::Cast<TResult>(System.Collections.IEnumerable)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:Exception(var_0_0D, call:Exception(Error::ArgumentNull, ldstr:string("source")))
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

		// Token: 0x06000054 RID: 84 RVA: 0x00002050 File Offset: 0x00000250
		private static IEnumerable<TResult> CastIterator<TResult>(IEnumerable source)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000027F4 File Offset: 0x000009F4
		public static TSource First<TSource>(this IEnumerable<TSource> source)
		{
			long num = 0L;
			int num2 = 8;
			if (num == 0L)
			{
				if (num2 != 0)
				{
				}
				Exception ex = Error.NoElements();
				Exception ex2 = Error.ArgumentNull("source");
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000284C File Offset: 0x00000A4C
		public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source)
		{
			long num = 0L;
			int num2 = 8;
			if (num == 0L)
			{
				if (num2 == 0)
				{
				}
				Exception ex = Error.ArgumentNull("source");
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002894 File Offset: 0x00000A94
		public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			if (source != null)
			{
				long num = 0L;
				int num2 = 11;
				if (num == 0L)
				{
					if (num2 == 0)
					{
					}
					return "source";
				}
			}
			else
			{
				Exception ex = Error.ArgumentNull("predicate");
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000028E4 File Offset: 0x00000AE4
		public static TSource Last<TSource>(this IEnumerable<TSource> source)
		{
			long num = 0L;
			int num2 = 6;
			if (num == 0L)
			{
				if (num2 != 0)
				{
				}
				Exception ex = Error.NoElements();
				Exception ex2 = Error.ArgumentNull("source");
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000293C File Offset: 0x00000B3C
		public static TSource LastOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			if (source != null)
			{
				if (!false)
				{
					return "source";
				}
			}
			else
			{
				Exception ex = Error.ArgumentNull("predicate");
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002980 File Offset: 0x00000B80
		public static TSource Single<TSource>(this IEnumerable<TSource> source)
		{
			int num = 8;
			long num2 = 0L;
			if (num != 0)
			{
			}
			if (num2 == 0L)
			{
				Exception ex = Error.NoElements();
				Exception ex2 = Error.MoreThanOneElement();
				Exception ex3 = Error.ArgumentNull("source");
				Exception ex4 = Error.NoElements();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000029E8 File Offset: 0x00000BE8
		public static TSource SingleOrDefault<TSource>(this IEnumerable<TSource> source)
		{
			long num = 0L;
			long value = num.m_value;
			int num2;
			long num3;
			if (num == 0L)
			{
				long value2 = num.m_value;
				long value3 = num.m_value;
				long value4 = num.m_value;
				num2 = 8;
				num3 = 0L;
				if (num == 0L)
				{
					goto IL_0037;
				}
			}
			if (num2 != 0)
			{
			}
			long value5 = num.m_value;
			IL_0037:
			if (num3 == 0L)
			{
				Exception ex = Error.MoreThanOneElement();
				Exception ex2 = Error.ArgumentNull("source");
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002A74 File Offset: 0x00000C74
		public static TSource SingleOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			if (source != null)
			{
				long num = 0L;
				long num2 = 0L;
				int num3 = 12;
				if (num2 == 0L)
				{
					if (num3 == 0)
					{
						if (num != 0L)
						{
							Exception ex = Error.MoreThanOneMatch();
						}
					}
					throw new OverflowException();
				}
			}
			else
			{
				Exception ex2 = Error.ArgumentNull("predicate");
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002AE4 File Offset: 0x00000CE4
		public static TSource ElementAt<TSource>(this IEnumerable<TSource> source, int index)
		{
			while (source != null)
			{
			}
			if (!false)
			{
				Exception ex = Error.ArgumentOutOfRange("index");
				Exception ex2 = Error.ArgumentNull("source");
				Exception ex3 = Error.ArgumentOutOfRange("index");
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002050 File Offset: 0x00000250
		public static IEnumerable<TResult> Empty<TResult>()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002B38 File Offset: 0x00000D38
		public static bool Any<TSource>(this IEnumerable<TSource> source)
		{
			if (!false)
			{
				Exception ex = Error.ArgumentNull("source");
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002B74 File Offset: 0x00000D74
		public static bool Any<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			if (source != null)
			{
				if (!false)
				{
					return "source" != null;
				}
			}
			else
			{
				Exception ex = Error.ArgumentNull("predicate");
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002BC4 File Offset: 0x00000DC4
		public static bool All<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			if (source != null)
			{
				if (!false)
				{
					return "source" != null;
				}
			}
			else
			{
				Exception ex = Error.ArgumentNull("predicate");
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002C14 File Offset: 0x00000E14
		public static int Count<TSource>(this IEnumerable<TSource> source)
		{
			if (!false)
			{
				throw new OverflowException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002C54 File Offset: 0x00000E54
		public static int Count<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			if (source != null)
			{
				if (!false)
				{
					throw new OverflowException();
				}
			}
			else
			{
				Exception ex = Error.ArgumentNull("predicate");
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002C9C File Offset: 0x00000E9C
		public static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value)
		{
			/*
An exception occurred when decompiling this method (06000064)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Linq.Enumerable::Contains<TSource>(System.Collections.Generic.IEnumerable`1<TSource>,TSource)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldloc:class [mscorlib]System.Collections.Generic.IEnumerable`1<!!TSource>[exp:bool](source)))
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

		// Token: 0x06000065 RID: 101 RVA: 0x00002CAC File Offset: 0x00000EAC
		public static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer)
		{
			if (value != null)
			{
				while (value != null)
				{
				}
			}
			Exception ex = Error.ArgumentNull("source");
			long num;
			if (ex == null)
			{
				num = 0L;
				if (ex != null)
				{
				}
			}
			if (num == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002D00 File Offset: 0x00000F00
		public static int Min(this IEnumerable<int> source)
		{
			if (!false)
			{
				Exception ex = Error.ArgumentNull("source");
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002D40 File Offset: 0x00000F40
		public static int Min<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
		{
			int num;
			return num;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002D50 File Offset: 0x00000F50
		public static int Max(this IEnumerable<int> source)
		{
			if (!false)
			{
				Exception ex = Error.ArgumentNull("source");
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002D90 File Offset: 0x00000F90
		public static int Max<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
		{
			int num;
			return num;
		}

		// Token: 0x02000009 RID: 9
		private abstract class Iterator<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
		{
			// Token: 0x0600006A RID: 106 RVA: 0x00002DA0 File Offset: 0x00000FA0
			public Iterator()
			{
				int managedThreadId = Thread.CurrentThread.ManagedThreadId;
				this.threadId = managedThreadId;
			}

			// Token: 0x1700000D RID: 13
			// (get) Token: 0x0600006B RID: 107 RVA: 0x00002DC8 File Offset: 0x00000FC8
			public TSource Current
			{
				get
				{
					return this.current;
				}
			}

			// Token: 0x0600006C RID: 108
			public abstract Enumerable.Iterator<TSource> Clone();

			// Token: 0x0600006D RID: 109 RVA: 0x00002DDC File Offset: 0x00000FDC
			public virtual void Dispose()
			{
			}

			// Token: 0x0600006E RID: 110 RVA: 0x00002DEC File Offset: 0x00000FEC
			public IEnumerator<TSource> GetEnumerator()
			{
				/*
An exception occurred when decompiling this method (0600006E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IEnumerator`1<TSource> System.Linq.Enumerable/Iterator`1::GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001C:
	stfld:int32(Iterator`1::state, ldloc:Iterator`1(this), ldc.i4:int32(1))
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

			// Token: 0x0600006F RID: 111
			public abstract bool MoveNext();

			// Token: 0x06000070 RID: 112
			public abstract IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector);

			// Token: 0x06000071 RID: 113
			public abstract IEnumerable<TSource> Where(Func<TSource, bool> predicate);

			// Token: 0x1700000E RID: 14
			// (get) Token: 0x06000072 RID: 114 RVA: 0x00002050 File Offset: 0x00000250
			object IEnumerator.Current
			{
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x06000073 RID: 115 RVA: 0x00002050 File Offset: 0x00000250
			IEnumerator IEnumerable.GetEnumerator()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06000074 RID: 116 RVA: 0x00002050 File Offset: 0x00000250
			void IEnumerator.Reset()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x04000010 RID: 16
			private int threadId;

			// Token: 0x04000011 RID: 17
			internal int state;

			// Token: 0x04000012 RID: 18
			internal TSource current;
		}

		// Token: 0x0200000A RID: 10
		private class WhereEnumerableIterator<TSource> : Enumerable.Iterator<TSource>
		{
			// Token: 0x06000075 RID: 117 RVA: 0x00002E1C File Offset: 0x0000101C
			public WhereEnumerableIterator(IEnumerable<TSource> source, Func<TSource, bool> predicate)
			{
			}

			// Token: 0x06000076 RID: 118 RVA: 0x00002E2C File Offset: 0x0000102C
			public override Enumerable.Iterator<TSource> Clone()
			{
				/*
An exception occurred when decompiling this method (06000076)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::Clone()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Func`2(var_0_06, ldfld:class [mscorlib]System.Func`2<!TSource, bool>[exp:Func`2](WhereEnumerableIterator`1::predicate, ldloc:WhereEnumerableIterator`1(this)))
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

			// Token: 0x06000077 RID: 119 RVA: 0x00002E40 File Offset: 0x00001040
			public override void Dispose()
			{
			}

			// Token: 0x06000078 RID: 120 RVA: 0x00002E50 File Offset: 0x00001050
			public override bool MoveNext()
			{
				return false;
			}

			// Token: 0x06000079 RID: 121 RVA: 0x00002050 File Offset: 0x00000250
			public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x0600007A RID: 122 RVA: 0x00002E74 File Offset: 0x00001074
			public override IEnumerable<TSource> Where(Func<TSource, bool> predicate)
			{
				/*
An exception occurred when decompiling this method (0600007A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::Where(System.Func`2<TSource,System.Boolean>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Func`2(var_0_06, ldfld:class [mscorlib]System.Func`2<!TSource, bool>[exp:Func`2](WhereEnumerableIterator`1::predicate, ldloc:WhereEnumerableIterator`1(this)))
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

			// Token: 0x04000013 RID: 19
			private IEnumerable<TSource> source;

			// Token: 0x04000014 RID: 20
			private Func<TSource, bool> predicate;

			// Token: 0x04000015 RID: 21
			private IEnumerator<TSource> enumerator;
		}

		// Token: 0x0200000B RID: 11
		private class WhereArrayIterator<TSource> : Enumerable.Iterator<TSource>
		{
			// Token: 0x0600007B RID: 123 RVA: 0x00002E88 File Offset: 0x00001088
			public WhereArrayIterator(TSource[] source, Func<TSource, bool> predicate)
			{
			}

			// Token: 0x0600007C RID: 124 RVA: 0x00002E98 File Offset: 0x00001098
			public override Enumerable.Iterator<TSource> Clone()
			{
				/*
An exception occurred when decompiling this method (0600007C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/WhereArrayIterator`1::Clone()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Func`2(var_0_06, ldfld:class [mscorlib]System.Func`2<!TSource, bool>[exp:Func`2](WhereArrayIterator`1::predicate, ldloc:WhereArrayIterator`1(this)))
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

			// Token: 0x0600007D RID: 125 RVA: 0x00002EAC File Offset: 0x000010AC
			public override bool MoveNext()
			{
			}

			// Token: 0x0600007E RID: 126 RVA: 0x00002050 File Offset: 0x00000250
			public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x0600007F RID: 127 RVA: 0x00002EBC File Offset: 0x000010BC
			public override IEnumerable<TSource> Where(Func<TSource, bool> predicate)
			{
				/*
An exception occurred when decompiling this method (0600007F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereArrayIterator`1::Where(System.Func`2<TSource,System.Boolean>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Func`2(var_0_06, ldfld:class [mscorlib]System.Func`2<!TSource, bool>[exp:Func`2](WhereArrayIterator`1::predicate, ldloc:WhereArrayIterator`1(this)))
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

			// Token: 0x04000016 RID: 22
			private TSource[] source;

			// Token: 0x04000017 RID: 23
			private Func<TSource, bool> predicate;

			// Token: 0x04000018 RID: 24
			private int index;
		}

		// Token: 0x0200000C RID: 12
		private class WhereListIterator<TSource> : Enumerable.Iterator<TSource>
		{
			// Token: 0x06000080 RID: 128 RVA: 0x00002050 File Offset: 0x00000250
			public WhereListIterator(List<TSource> source, Func<TSource, bool> predicate)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06000081 RID: 129 RVA: 0x00002050 File Offset: 0x00000250
			public override Enumerable.Iterator<TSource> Clone()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06000082 RID: 130 RVA: 0x00002050 File Offset: 0x00000250
			public override bool MoveNext()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06000083 RID: 131 RVA: 0x00002050 File Offset: 0x00000250
			public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06000084 RID: 132 RVA: 0x00002050 File Offset: 0x00000250
			public override IEnumerable<TSource> Where(Func<TSource, bool> predicate)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x04000019 RID: 25
			private List<TSource> source;

			// Token: 0x0400001A RID: 26
			private Func<TSource, bool> predicate;

			// Token: 0x0400001B RID: 27
			private List<TSource>.Enumerator enumerator;
		}

		// Token: 0x0200000D RID: 13
		private class WhereSelectEnumerableIterator<TSource, TResult> : Enumerable.Iterator<TResult>
		{
			// Token: 0x06000085 RID: 133 RVA: 0x00002ED0 File Offset: 0x000010D0
			public WhereSelectEnumerableIterator(IEnumerable<TSource> source, Func<TSource, bool> predicate, Func<TSource, TResult> selector)
			{
			}

			// Token: 0x06000086 RID: 134 RVA: 0x00002EE4 File Offset: 0x000010E4
			public override Enumerable.Iterator<TResult> Clone()
			{
				/*
An exception occurred when decompiling this method (06000086)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectEnumerableIterator`2::Clone()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Func`2(var_0_06, ldfld:class [mscorlib]System.Func`2<!TSource, !TResult>[exp:Func`2](WhereSelectEnumerableIterator`2::selector, ldloc:WhereSelectEnumerableIterator`2(this)))
	stloc:IEnumerator`1(var_1_0D, ldfld:class [mscorlib]System.Collections.Generic.IEnumerator`1<!TSource>[exp:IEnumerator`1](WhereSelectEnumerableIterator`2::enumerator, ldloc:WhereSelectEnumerableIterator`2(this)))
	stloc:Func`2(var_2_14, ldfld:class [mscorlib]System.Func`2<!TSource, bool>[exp:Func`2](WhereSelectEnumerableIterator`2::predicate, ldloc:WhereSelectEnumerableIterator`2(this)))
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

			// Token: 0x06000087 RID: 135 RVA: 0x00002F08 File Offset: 0x00001108
			public override void Dispose()
			{
			}

			// Token: 0x06000088 RID: 136 RVA: 0x00002F18 File Offset: 0x00001118
			public override bool MoveNext()
			{
				Func func = this.selector;
				if (this.enumerator != null)
				{
					return;
				}
			}

			// Token: 0x06000089 RID: 137 RVA: 0x00002F3C File Offset: 0x0000113C
			public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector)
			{
				/*
An exception occurred when decompiling this method (06000089)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IEnumerable`1<TResult2> System.Linq.Enumerable/WhereSelectEnumerableIterator`2::Select<TResult2>(System.Func`2<TResult,TResult2>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Func`2(var_0_06, ldfld:class [mscorlib]System.Func`2<!TSource, !TResult>[exp:Func`2](WhereSelectEnumerableIterator`2::selector, ldloc:WhereSelectEnumerableIterator`2(this)))
	stloc:IEnumerator`1(var_1_0D, ldfld:class [mscorlib]System.Collections.Generic.IEnumerator`1<!TSource>[exp:IEnumerator`1](WhereSelectEnumerableIterator`2::enumerator, ldloc:WhereSelectEnumerableIterator`2(this)))
	stloc:IEnumerable`1(var_2_14, ldfld:class [mscorlib]System.Collections.Generic.IEnumerable`1<!TSource>[exp:IEnumerable`1](WhereSelectEnumerableIterator`2::source, ldloc:WhereSelectEnumerableIterator`2(this)))
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

			// Token: 0x0600008A RID: 138 RVA: 0x00002050 File Offset: 0x00000250
			public override IEnumerable<TResult> Where(Func<TResult, bool> predicate)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x0400001C RID: 28
			private IEnumerable<TSource> source;

			// Token: 0x0400001D RID: 29
			private Func<TSource, bool> predicate;

			// Token: 0x0400001E RID: 30
			private Func<TSource, TResult> selector = source;

			// Token: 0x0400001F RID: 31
			private IEnumerator<TSource> enumerator;
		}

		// Token: 0x0200000E RID: 14
		private class WhereSelectArrayIterator<TSource, TResult> : Enumerable.Iterator<TResult>
		{
			// Token: 0x0600008B RID: 139 RVA: 0x00002F60 File Offset: 0x00001160
			public WhereSelectArrayIterator(TSource[] source, Func<TSource, bool> predicate, Func<TSource, TResult> selector)
			{
			}

			// Token: 0x0600008C RID: 140 RVA: 0x00002F70 File Offset: 0x00001170
			public override Enumerable.Iterator<TResult> Clone()
			{
				/*
An exception occurred when decompiling this method (0600008C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectArrayIterator`2::Clone()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Func`2(var_0_06, ldfld:class [mscorlib]System.Func`2<!TSource, !TResult>[exp:Func`2](WhereSelectArrayIterator`2::selector, ldloc:WhereSelectArrayIterator`2(this)))
	stloc:int32(var_1_0D, ldfld:int32(WhereSelectArrayIterator`2::index, ldloc:WhereSelectArrayIterator`2(this)))
	stloc:Func`2(var_2_14, ldfld:class [mscorlib]System.Func`2<!TSource, bool>[exp:Func`2](WhereSelectArrayIterator`2::predicate, ldloc:WhereSelectArrayIterator`2(this)))
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

			// Token: 0x0600008D RID: 141 RVA: 0x00002F94 File Offset: 0x00001194
			public override bool MoveNext()
			{
				/*
An exception occurred when decompiling this method (0600008D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Linq.Enumerable/WhereSelectArrayIterator`2::MoveNext()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0011:
	stfld:class [mscorlib]System.Func`2<!TSource, bool>(WhereSelectArrayIterator`2::predicate, ldloc:WhereSelectArrayIterator`2(this), ldloc:int32[exp:class [mscorlib]System.Func`2<!TSource, bool>](var_1_0D))
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

			// Token: 0x0600008E RID: 142 RVA: 0x00002050 File Offset: 0x00000250
			public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x0600008F RID: 143 RVA: 0x00002050 File Offset: 0x00000250
			public override IEnumerable<TResult> Where(Func<TResult, bool> predicate)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x04000020 RID: 32
			private TSource[] source;

			// Token: 0x04000021 RID: 33
			private Func<TSource, bool> predicate;

			// Token: 0x04000022 RID: 34
			private Func<TSource, TResult> selector;

			// Token: 0x04000023 RID: 35
			private int index;
		}

		// Token: 0x0200000F RID: 15
		private class WhereSelectListIterator<TSource, TResult> : Enumerable.Iterator<TResult>
		{
			// Token: 0x06000090 RID: 144 RVA: 0x00002050 File Offset: 0x00000250
			public WhereSelectListIterator(List<TSource> source, Func<TSource, bool> predicate, Func<TSource, TResult> selector)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06000091 RID: 145 RVA: 0x00002050 File Offset: 0x00000250
			public override Enumerable.Iterator<TResult> Clone()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06000092 RID: 146 RVA: 0x00002050 File Offset: 0x00000250
			public override bool MoveNext()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06000093 RID: 147 RVA: 0x00002050 File Offset: 0x00000250
			public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06000094 RID: 148 RVA: 0x00002050 File Offset: 0x00000250
			public override IEnumerable<TResult> Where(Func<TResult, bool> predicate)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x04000024 RID: 36
			private List<TSource> source;

			// Token: 0x04000025 RID: 37
			private Func<TSource, bool> predicate;

			// Token: 0x04000026 RID: 38
			private Func<TSource, TResult> selector;

			// Token: 0x04000027 RID: 39
			private List<TSource>.Enumerator enumerator;
		}

		// Token: 0x02000010 RID: 16
		[CompilerGenerated]
		private sealed class <SelectIterator>d__5<TSource, TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator
		{
			// Token: 0x06000095 RID: 149 RVA: 0x00002FBC File Offset: 0x000011BC
			[DebuggerHidden]
			public <SelectIterator>d__5(int <>1__state)
			{
				this.<>1__state = <>1__state;
				int currentManagedThreadId = Environment.CurrentManagedThreadId;
				this.source = currentManagedThreadId;
			}

			// Token: 0x06000096 RID: 150 RVA: 0x00002FE8 File Offset: 0x000011E8
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
				int num = this.<>1__state;
			}

			// Token: 0x06000097 RID: 151 RVA: 0x00003000 File Offset: 0x00001200
			private bool MoveNext()
			{
				int num = this.<>1__state;
				if (num == 0)
				{
					this.<>1__state = num;
					IEnumerable enumerable = this.<>3__source;
					long value = 0.m_value;
					throw new OverflowException();
				}
				throw new OutOfMemoryException();
			}

			// Token: 0x06000098 RID: 152 RVA: 0x00003048 File Offset: 0x00001248
			private void <>m__Finally1()
			{
				int num = 1;
				this.<>1__state = num;
			}

			// Token: 0x1700000F RID: 15
			// (get) Token: 0x06000099 RID: 153 RVA: 0x00002050 File Offset: 0x00000250
			TResult IEnumerator<TResult>.Current
			{
				[DebuggerHidden]
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x0600009A RID: 154 RVA: 0x00002050 File Offset: 0x00000250
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x0600009B RID: 155 RVA: 0x00002050 File Offset: 0x00000250
			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x0600009C RID: 156 RVA: 0x00003060 File Offset: 0x00001260
			[DebuggerHidden]
			IEnumerator<TResult> IEnumerable<TResult>.GetEnumerator()
			{
				/*
An exception occurred when decompiling this method (0600009C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IEnumerator`1<TResult> System.Linq.Enumerable/<SelectIterator>d__5`2::System.Collections.Generic.IEnumerable<TResult>.GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32('<SelectIterator>d__5`2'::<>1__state, ldloc:'<SelectIterator>d__5`2'(this)))
	stloc:IEnumerable`1(var_1_0D, ldfld:class [mscorlib]System.Collections.Generic.IEnumerable`1<!TSource>[exp:IEnumerable`1]('<SelectIterator>d__5`2'::source, ldloc:'<SelectIterator>d__5`2'(this)))
	stloc:int32(var_3_15, callgetter:int32(Environment::get_CurrentManagedThreadId))
	stloc:IEnumerable`1(var_4_1C, ldfld:class [mscorlib]System.Collections.Generic.IEnumerable`1<!TSource>[exp:IEnumerable`1]('<SelectIterator>d__5`2'::source, ldloc:'<SelectIterator>d__5`2'(this)))
	stloc:IEnumerable`1(var_5_24, ldfld:class [mscorlib]System.Collections.Generic.IEnumerable`1<!TSource>[exp:IEnumerable`1]('<SelectIterator>d__5`2'::source, ldloc:'<SelectIterator>d__5`2'(this)))
	stloc:Func`3(var_6_2C, ldfld:class [mscorlib]System.Func`3<!TSource, int32, !TResult>[exp:Func`3]('<SelectIterator>d__5`2'::selector, ldloc:'<SelectIterator>d__5`2'(this)))
	stloc:int32(var_7_34, ldfld:int32('<SelectIterator>d__5`2'::<index>5__2, ldloc:'<SelectIterator>d__5`2'(this)))
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

			// Token: 0x0600009D RID: 157 RVA: 0x00002050 File Offset: 0x00000250
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x04000028 RID: 40
			private int <>1__state;

			// Token: 0x04000029 RID: 41
			private TResult <>2__current;

			// Token: 0x0400002A RID: 42
			private int <>l__initialThreadId;

			// Token: 0x0400002B RID: 43
			private IEnumerable<TSource> source;

			// Token: 0x0400002C RID: 44
			public IEnumerable<TSource> <>3__source;

			// Token: 0x0400002D RID: 45
			private Func<TSource, int, TResult> selector;

			// Token: 0x0400002E RID: 46
			public Func<TSource, int, TResult> <>3__selector;

			// Token: 0x0400002F RID: 47
			private int <index>5__2;

			// Token: 0x04000030 RID: 48
			private IEnumerator<TSource> <>7__wrap2;
		}

		// Token: 0x02000011 RID: 17
		[CompilerGenerated]
		private sealed class <>c__DisplayClass6_0<TSource>
		{
			// Token: 0x0600009E RID: 158 RVA: 0x000030A4 File Offset: 0x000012A4
			public <>c__DisplayClass6_0()
			{
			}

			// Token: 0x0600009F RID: 159 RVA: 0x000030B8 File Offset: 0x000012B8
			internal bool <CombinePredicates>b__0(TSource x)
			{
				/*
An exception occurred when decompiling this method (0600009F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Linq.Enumerable/<>c__DisplayClass6_0`1::<CombinePredicates>b__0(TSource)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Func`2(var_0_06, ldfld:class [mscorlib]System.Func`2<!TSource, bool>[exp:Func`2]('<>c__DisplayClass6_0`1'::predicate1, ldloc:'<>c__DisplayClass6_0`1'(this)))
	stloc:Func`2(var_1_0D, ldfld:class [mscorlib]System.Func`2<!TSource, bool>[exp:Func`2]('<>c__DisplayClass6_0`1'::predicate2, ldloc:'<>c__DisplayClass6_0`1'(this)))
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

			// Token: 0x04000031 RID: 49
			public Func<TSource, bool> predicate1;

			// Token: 0x04000032 RID: 50
			public Func<TSource, bool> predicate2;
		}

		// Token: 0x02000012 RID: 18
		[CompilerGenerated]
		private sealed class <>c__DisplayClass7_0<TSource, TMiddle, TResult>
		{
			// Token: 0x060000A0 RID: 160 RVA: 0x000030D4 File Offset: 0x000012D4
			public <>c__DisplayClass7_0()
			{
			}

			// Token: 0x060000A1 RID: 161 RVA: 0x000030E8 File Offset: 0x000012E8
			internal TResult <CombineSelectors>b__0(TSource x)
			{
				/*
An exception occurred when decompiling this method (060000A1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling TResult System.Linq.Enumerable/<>c__DisplayClass7_0`3::<CombineSelectors>b__0(TSource)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Func`2(var_0_06, ldfld:class [mscorlib]System.Func`2<!TMiddle, !TResult>[exp:Func`2]('<>c__DisplayClass7_0`3'::selector2, ldloc:'<>c__DisplayClass7_0`3'(this)))
	stloc:Func`2(var_1_0D, ldfld:class [mscorlib]System.Func`2<!TSource, !TMiddle>[exp:Func`2]('<>c__DisplayClass7_0`3'::selector1, ldloc:'<>c__DisplayClass7_0`3'(this)))
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

			// Token: 0x04000033 RID: 51
			public Func<TMiddle, TResult> selector2;

			// Token: 0x04000034 RID: 52
			public Func<TSource, TMiddle> selector1;
		}

		// Token: 0x02000013 RID: 19
		[CompilerGenerated]
		private sealed class <SelectManyIterator>d__17<TSource, TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator
		{
			// Token: 0x060000A2 RID: 162 RVA: 0x00003104 File Offset: 0x00001304
			[DebuggerHidden]
			public <SelectManyIterator>d__17(int <>1__state)
			{
				this.<>1__state = <>1__state;
				int currentManagedThreadId = Environment.CurrentManagedThreadId;
				this.source = currentManagedThreadId;
			}

			// Token: 0x060000A3 RID: 163 RVA: 0x00003130 File Offset: 0x00001330
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
				int num = this.<>1__state;
			}

			// Token: 0x060000A4 RID: 164 RVA: 0x00003160 File Offset: 0x00001360
			private bool MoveNext()
			{
				int num = this.<>1__state;
				if (num == 0)
				{
					this.<>1__state = num;
					IEnumerable enumerable = this.<>3__source;
				}
				throw new OutOfMemoryException();
			}

			// Token: 0x060000A5 RID: 165 RVA: 0x00003198 File Offset: 0x00001398
			private void <>m__Finally1()
			{
				int num = 1;
				IEnumerator enumerator = this.<>7__wrap2;
				this.<>1__state = num;
				if (enumerator != null)
				{
					return;
				}
			}

			// Token: 0x060000A6 RID: 166 RVA: 0x000031BC File Offset: 0x000013BC
			private void <>m__Finally2()
			{
				int num = 1;
				this.<>1__state = num;
			}

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x060000A7 RID: 167 RVA: 0x00002050 File Offset: 0x00000250
			TResult IEnumerator<TResult>.Current
			{
				[DebuggerHidden]
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x060000A8 RID: 168 RVA: 0x00002050 File Offset: 0x00000250
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x060000A9 RID: 169 RVA: 0x00002050 File Offset: 0x00000250
			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x060000AA RID: 170 RVA: 0x000031D4 File Offset: 0x000013D4
			[DebuggerHidden]
			IEnumerator<TResult> IEnumerable<TResult>.GetEnumerator()
			{
				/*
An exception occurred when decompiling this method (060000AA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IEnumerator`1<TResult> System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.Collections.Generic.IEnumerable<TResult>.GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32('<SelectManyIterator>d__17`2'::<>1__state, ldloc:'<SelectManyIterator>d__17`2'(this)))
	stloc:IEnumerable`1(var_1_0D, ldfld:class [mscorlib]System.Collections.Generic.IEnumerable`1<!TSource>[exp:IEnumerable`1]('<SelectManyIterator>d__17`2'::source, ldloc:'<SelectManyIterator>d__17`2'(this)))
	stloc:int32(var_3_15, callgetter:int32(Environment::get_CurrentManagedThreadId))
	stloc:IEnumerable`1(var_4_1C, ldfld:class [mscorlib]System.Collections.Generic.IEnumerable`1<!TSource>[exp:IEnumerable`1]('<SelectManyIterator>d__17`2'::source, ldloc:'<SelectManyIterator>d__17`2'(this)))
	stloc:IEnumerable`1(var_5_24, ldfld:class [mscorlib]System.Collections.Generic.IEnumerable`1<!TSource>[exp:IEnumerable`1]('<SelectManyIterator>d__17`2'::source, ldloc:'<SelectManyIterator>d__17`2'(this)))
	stloc:Func`2(var_6_2C, ldfld:class [mscorlib]System.Func`2<!TSource, class [mscorlib]System.Collections.Generic.IEnumerable`1<!TResult>>[exp:Func`2]('<SelectManyIterator>d__17`2'::selector, ldloc:'<SelectManyIterator>d__17`2'(this)))
	stloc:IEnumerator`1(var_7_34, ldfld:class [mscorlib]System.Collections.Generic.IEnumerator`1<!TSource>[exp:IEnumerator`1]('<SelectManyIterator>d__17`2'::<>7__wrap1, ldloc:'<SelectManyIterator>d__17`2'(this)))
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

			// Token: 0x060000AB RID: 171 RVA: 0x00002050 File Offset: 0x00000250
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x04000035 RID: 53
			private int <>1__state;

			// Token: 0x04000036 RID: 54
			private TResult <>2__current;

			// Token: 0x04000037 RID: 55
			private int <>l__initialThreadId;

			// Token: 0x04000038 RID: 56
			private IEnumerable<TSource> source;

			// Token: 0x04000039 RID: 57
			public IEnumerable<TSource> <>3__source;

			// Token: 0x0400003A RID: 58
			private Func<TSource, IEnumerable<TResult>> selector;

			// Token: 0x0400003B RID: 59
			public Func<TSource, IEnumerable<TResult>> <>3__selector;

			// Token: 0x0400003C RID: 60
			private IEnumerator<TSource> <>7__wrap1;

			// Token: 0x0400003D RID: 61
			private IEnumerator<TResult> <>7__wrap2;
		}

		// Token: 0x02000014 RID: 20
		[CompilerGenerated]
		private sealed class <TakeIterator>d__25<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
		{
			// Token: 0x060000AC RID: 172 RVA: 0x00003218 File Offset: 0x00001418
			[DebuggerHidden]
			public <TakeIterator>d__25(int <>1__state)
			{
				this.<>1__state = <>1__state;
				int currentManagedThreadId = Environment.CurrentManagedThreadId;
				this.count = currentManagedThreadId;
			}

			// Token: 0x060000AD RID: 173 RVA: 0x00003244 File Offset: 0x00001444
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
				int num = this.<>1__state;
			}

			// Token: 0x060000AE RID: 174 RVA: 0x0000325C File Offset: 0x0000145C
			private bool MoveNext()
			{
				if (this.<>1__state == 0)
				{
					int num = this.<>3__count;
					IEnumerable enumerable = this.<>3__source;
					long value = 0.m_value;
				}
				throw new OutOfMemoryException();
			}

			// Token: 0x060000AF RID: 175 RVA: 0x00003298 File Offset: 0x00001498
			private void <>m__Finally1()
			{
				int num = 1;
				this.<>1__state = num;
			}

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x060000B0 RID: 176 RVA: 0x00002050 File Offset: 0x00000250
			TSource IEnumerator<TSource>.Current
			{
				[DebuggerHidden]
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x060000B1 RID: 177 RVA: 0x00002050 File Offset: 0x00000250
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x060000B2 RID: 178 RVA: 0x00002050 File Offset: 0x00000250
			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x060000B3 RID: 179 RVA: 0x000032B0 File Offset: 0x000014B0
			[DebuggerHidden]
			IEnumerator<TSource> IEnumerable<TSource>.GetEnumerator()
			{
				/*
An exception occurred when decompiling this method (060000B3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IEnumerator`1<TSource> System.Linq.Enumerable/<TakeIterator>d__25`1::System.Collections.Generic.IEnumerable<TSource>.GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32('<TakeIterator>d__25`1'::<>1__state, ldloc:'<TakeIterator>d__25`1'(this)))
	stloc:int32(var_1_0D, ldfld:int32('<TakeIterator>d__25`1'::count, ldloc:'<TakeIterator>d__25`1'(this)))
	stloc:int32(var_3_15, callgetter:int32(Environment::get_CurrentManagedThreadId))
	stloc:int32(var_4_1C, ldfld:int32('<TakeIterator>d__25`1'::count, ldloc:'<TakeIterator>d__25`1'(this)))
	stloc:int32(var_5_24, ldfld:int32('<TakeIterator>d__25`1'::count, ldloc:'<TakeIterator>d__25`1'(this)))
	stloc:IEnumerator`1(var_6_2C, ldfld:class [mscorlib]System.Collections.Generic.IEnumerator`1<!TSource>[exp:IEnumerator`1]('<TakeIterator>d__25`1'::<>7__wrap1, ldloc:'<TakeIterator>d__25`1'(this)))
	stloc:IEnumerable`1(var_7_34, ldfld:class [mscorlib]System.Collections.Generic.IEnumerable`1<!TSource>[exp:IEnumerable`1]('<TakeIterator>d__25`1'::source, ldloc:'<TakeIterator>d__25`1'(this)))
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

			// Token: 0x060000B4 RID: 180 RVA: 0x00002050 File Offset: 0x00000250
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x0400003E RID: 62
			private int <>1__state;

			// Token: 0x0400003F RID: 63
			private TSource <>2__current;

			// Token: 0x04000040 RID: 64
			private int <>l__initialThreadId;

			// Token: 0x04000041 RID: 65
			private int count;

			// Token: 0x04000042 RID: 66
			public int <>3__count;

			// Token: 0x04000043 RID: 67
			private IEnumerable<TSource> source;

			// Token: 0x04000044 RID: 68
			public IEnumerable<TSource> <>3__source;

			// Token: 0x04000045 RID: 69
			private IEnumerator<TSource> <>7__wrap1;
		}

		// Token: 0x02000015 RID: 21
		[CompilerGenerated]
		private sealed class <DistinctIterator>d__68<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
		{
			// Token: 0x060000B5 RID: 181 RVA: 0x000032F4 File Offset: 0x000014F4
			[DebuggerHidden]
			public <DistinctIterator>d__68(int <>1__state)
			{
				this.<>1__state = <>1__state;
				int currentManagedThreadId = Environment.CurrentManagedThreadId;
			}

			// Token: 0x060000B6 RID: 182 RVA: 0x00003318 File Offset: 0x00001518
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
				int num = this.<>1__state;
			}

			// Token: 0x060000B7 RID: 183 RVA: 0x00003330 File Offset: 0x00001530
			private bool MoveNext()
			{
				int num = this.<>1__state;
				if (num == 0)
				{
					this.<>1__state = num;
					IEqualityComparer equalityComparer = this.comparer;
				}
				throw new OutOfMemoryException();
			}

			// Token: 0x060000B8 RID: 184 RVA: 0x00003368 File Offset: 0x00001568
			private void <>m__Finally1()
			{
				int num = 1;
				IEnumerator enumerator = this.<>7__wrap2;
				this.<>1__state = num;
				if (enumerator != null)
				{
					return;
				}
			}

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x060000B9 RID: 185 RVA: 0x0000338C File Offset: 0x0000158C
			TSource IEnumerator<TSource>.Current
			{
				[DebuggerHidden]
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x060000BA RID: 186 RVA: 0x00002050 File Offset: 0x00000250
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x17000016 RID: 22
			// (get) Token: 0x060000BB RID: 187 RVA: 0x000033A0 File Offset: 0x000015A0
			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					/*
An exception occurred when decompiling this method (060000BB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Linq.Enumerable/<DistinctIterator>d__68`1::System.Collections.IEnumerator.get_Current()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:!TSource(var_0_06, ldfld:!TSource('<DistinctIterator>d__68`1'::<>2__current, ldloc:'<DistinctIterator>d__68`1'(this)))
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

			// Token: 0x060000BC RID: 188 RVA: 0x000033B4 File Offset: 0x000015B4
			[DebuggerHidden]
			IEnumerator<TSource> IEnumerable<TSource>.GetEnumerator()
			{
				/*
An exception occurred when decompiling this method (060000BC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IEnumerator`1<TSource> System.Linq.Enumerable/<DistinctIterator>d__68`1::System.Collections.Generic.IEnumerable<TSource>.GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32('<DistinctIterator>d__68`1'::<>1__state, ldloc:'<DistinctIterator>d__68`1'(this)))
	stloc:int32(var_2_0E, callgetter:int32(Environment::get_CurrentManagedThreadId))
	stloc:IEqualityComparer`1(var_3_15, ldfld:class [mscorlib]System.Collections.Generic.IEqualityComparer`1<!TSource>[exp:IEqualityComparer`1]('<DistinctIterator>d__68`1'::comparer, ldloc:'<DistinctIterator>d__68`1'(this)))
	stloc:IEqualityComparer`1(var_4_1C, ldfld:class [mscorlib]System.Collections.Generic.IEqualityComparer`1<!TSource>[exp:IEqualityComparer`1]('<DistinctIterator>d__68`1'::comparer, ldloc:'<DistinctIterator>d__68`1'(this)))
	stloc:IEnumerable`1(var_5_24, ldfld:class [mscorlib]System.Collections.Generic.IEnumerable`1<!TSource>[exp:IEnumerable`1]('<DistinctIterator>d__68`1'::<>3__source, ldloc:'<DistinctIterator>d__68`1'(this)))
	stloc:IEqualityComparer`1(var_6_2C, ldfld:class [mscorlib]System.Collections.Generic.IEqualityComparer`1<!TSource>[exp:IEqualityComparer`1]('<DistinctIterator>d__68`1'::<>3__comparer, ldloc:'<DistinctIterator>d__68`1'(this)))
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

			// Token: 0x060000BD RID: 189 RVA: 0x00002050 File Offset: 0x00000250
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x04000046 RID: 70
			private int <>1__state;

			// Token: 0x04000047 RID: 71
			private TSource <>2__current;

			// Token: 0x04000048 RID: 72
			private int <>l__initialThreadId;

			// Token: 0x04000049 RID: 73
			private IEqualityComparer<TSource> comparer;

			// Token: 0x0400004A RID: 74
			public IEqualityComparer<TSource> <>3__comparer;

			// Token: 0x0400004B RID: 75
			private IEnumerable<TSource> source;

			// Token: 0x0400004C RID: 76
			public IEnumerable<TSource> <>3__source;

			// Token: 0x0400004D RID: 77
			private Set<TSource> <set>5__2;

			// Token: 0x0400004E RID: 78
			private IEnumerator<TSource> <>7__wrap2;
		}

		// Token: 0x02000016 RID: 22
		[CompilerGenerated]
		private sealed class <UnionIterator>d__71<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
		{
			// Token: 0x060000BE RID: 190 RVA: 0x000033F0 File Offset: 0x000015F0
			[DebuggerHidden]
			public <UnionIterator>d__71(int <>1__state)
			{
				this.<>1__state = <>1__state;
				int currentManagedThreadId = Environment.CurrentManagedThreadId;
			}

			// Token: 0x060000BF RID: 191 RVA: 0x00003414 File Offset: 0x00001614
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
				int num = this.<>1__state;
			}

			// Token: 0x060000C0 RID: 192 RVA: 0x0000342C File Offset: 0x0000162C
			private bool MoveNext()
			{
				int num = this.<>1__state;
				if (num == 0)
				{
					this.<>1__state = num;
					IEqualityComparer equalityComparer = this.comparer;
				}
				throw new OutOfMemoryException();
			}

			// Token: 0x060000C1 RID: 193 RVA: 0x0000346C File Offset: 0x0000166C
			private void <>m__Finally1()
			{
				int num = 1;
				IEnumerator enumerator = this.<>7__wrap2;
				this.<>1__state = num;
				if (enumerator != null)
				{
					return;
				}
			}

			// Token: 0x060000C2 RID: 194 RVA: 0x00003490 File Offset: 0x00001690
			private void <>m__Finally2()
			{
				int num = 1;
				IEnumerator enumerator = this.<>7__wrap2;
				this.<>1__state = num;
				if (enumerator != null)
				{
					return;
				}
			}

			// Token: 0x17000017 RID: 23
			// (get) Token: 0x060000C3 RID: 195 RVA: 0x000034B4 File Offset: 0x000016B4
			TSource IEnumerator<TSource>.Current
			{
				[DebuggerHidden]
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x060000C4 RID: 196 RVA: 0x00002050 File Offset: 0x00000250
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x17000018 RID: 24
			// (get) Token: 0x060000C5 RID: 197 RVA: 0x000034C8 File Offset: 0x000016C8
			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					/*
An exception occurred when decompiling this method (060000C5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Linq.Enumerable/<UnionIterator>d__71`1::System.Collections.IEnumerator.get_Current()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:!TSource(var_0_06, ldfld:!TSource('<UnionIterator>d__71`1'::<>2__current, ldloc:'<UnionIterator>d__71`1'(this)))
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

			// Token: 0x060000C6 RID: 198 RVA: 0x000034DC File Offset: 0x000016DC
			[DebuggerHidden]
			IEnumerator<TSource> IEnumerable<TSource>.GetEnumerator()
			{
				/*
An exception occurred when decompiling this method (060000C6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IEnumerator`1<TSource> System.Linq.Enumerable/<UnionIterator>d__71`1::System.Collections.Generic.IEnumerable<TSource>.GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32('<UnionIterator>d__71`1'::<>1__state, ldloc:'<UnionIterator>d__71`1'(this)))
	stloc:int32(var_2_0E, callgetter:int32(Environment::get_CurrentManagedThreadId))
	stloc:IEqualityComparer`1(var_3_15, ldfld:class [mscorlib]System.Collections.Generic.IEqualityComparer`1<!TSource>[exp:IEqualityComparer`1]('<UnionIterator>d__71`1'::comparer, ldloc:'<UnionIterator>d__71`1'(this)))
	stloc:IEqualityComparer`1(var_4_1C, ldfld:class [mscorlib]System.Collections.Generic.IEqualityComparer`1<!TSource>[exp:IEqualityComparer`1]('<UnionIterator>d__71`1'::comparer, ldloc:'<UnionIterator>d__71`1'(this)))
	stloc:IEnumerable`1(var_5_24, ldfld:class [mscorlib]System.Collections.Generic.IEnumerable`1<!TSource>[exp:IEnumerable`1]('<UnionIterator>d__71`1'::<>3__first, ldloc:'<UnionIterator>d__71`1'(this)))
	stloc:IEnumerable`1(var_6_2C, ldfld:class [mscorlib]System.Collections.Generic.IEnumerable`1<!TSource>[exp:IEnumerable`1]('<UnionIterator>d__71`1'::<>3__second, ldloc:'<UnionIterator>d__71`1'(this)))
	stloc:IEqualityComparer`1(var_7_34, ldfld:class [mscorlib]System.Collections.Generic.IEqualityComparer`1<!TSource>[exp:IEqualityComparer`1]('<UnionIterator>d__71`1'::<>3__comparer, ldloc:'<UnionIterator>d__71`1'(this)))
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

			// Token: 0x060000C7 RID: 199 RVA: 0x00002050 File Offset: 0x00000250
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x0400004F RID: 79
			private int <>1__state;

			// Token: 0x04000050 RID: 80
			private TSource <>2__current;

			// Token: 0x04000051 RID: 81
			private int <>l__initialThreadId;

			// Token: 0x04000052 RID: 82
			private IEqualityComparer<TSource> comparer;

			// Token: 0x04000053 RID: 83
			public IEqualityComparer<TSource> <>3__comparer;

			// Token: 0x04000054 RID: 84
			private IEnumerable<TSource> first;

			// Token: 0x04000055 RID: 85
			public IEnumerable<TSource> <>3__first;

			// Token: 0x04000056 RID: 86
			private IEnumerable<TSource> second;

			// Token: 0x04000057 RID: 87
			public IEnumerable<TSource> <>3__second;

			// Token: 0x04000058 RID: 88
			private Set<TSource> <set>5__2;

			// Token: 0x04000059 RID: 89
			private IEnumerator<TSource> <>7__wrap2;
		}

		// Token: 0x02000017 RID: 23
		[CompilerGenerated]
		private sealed class <ExceptIterator>d__77<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
		{
			// Token: 0x060000C8 RID: 200 RVA: 0x00003520 File Offset: 0x00001720
			[DebuggerHidden]
			public <ExceptIterator>d__77(int <>1__state)
			{
				this.<>1__state = <>1__state;
				int currentManagedThreadId = Environment.CurrentManagedThreadId;
				this.comparer = currentManagedThreadId;
			}

			// Token: 0x060000C9 RID: 201 RVA: 0x0000354C File Offset: 0x0000174C
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
				int num = this.<>1__state;
			}

			// Token: 0x060000CA RID: 202 RVA: 0x00003564 File Offset: 0x00001764
			private bool MoveNext()
			{
				int num = this.<>1__state;
				if (num == 0)
				{
					this.<>1__state = num;
					IEqualityComparer equalityComparer = this.<>3__comparer;
					long num2 = 0L;
					int num3 = 7;
					if (equalityComparer != null)
					{
					}
					if (num2 != 0L || num3 == 0)
					{
						throw new OutOfMemoryException();
					}
				}
				throw new OutOfMemoryException();
			}

			// Token: 0x060000CB RID: 203 RVA: 0x000035C4 File Offset: 0x000017C4
			private void <>m__Finally1()
			{
				int num = 1;
				this.<>1__state = num;
			}

			// Token: 0x17000019 RID: 25
			// (get) Token: 0x060000CC RID: 204 RVA: 0x00002050 File Offset: 0x00000250
			TSource IEnumerator<TSource>.Current
			{
				[DebuggerHidden]
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x060000CD RID: 205 RVA: 0x00002050 File Offset: 0x00000250
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x060000CE RID: 206 RVA: 0x00002050 File Offset: 0x00000250
			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x060000CF RID: 207 RVA: 0x000035DC File Offset: 0x000017DC
			[DebuggerHidden]
			IEnumerator<TSource> IEnumerable<TSource>.GetEnumerator()
			{
				/*
An exception occurred when decompiling this method (060000CF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IEnumerator`1<TSource> System.Linq.Enumerable/<ExceptIterator>d__77`1::System.Collections.Generic.IEnumerable<TSource>.GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32('<ExceptIterator>d__77`1'::<>1__state, ldloc:'<ExceptIterator>d__77`1'(this)))
	stloc:IEqualityComparer`1(var_1_0D, ldfld:class [mscorlib]System.Collections.Generic.IEqualityComparer`1<!TSource>[exp:IEqualityComparer`1]('<ExceptIterator>d__77`1'::comparer, ldloc:'<ExceptIterator>d__77`1'(this)))
	stloc:int32(var_3_15, callgetter:int32(Environment::get_CurrentManagedThreadId))
	stloc:IEqualityComparer`1(var_4_1C, ldfld:class [mscorlib]System.Collections.Generic.IEqualityComparer`1<!TSource>[exp:IEqualityComparer`1]('<ExceptIterator>d__77`1'::comparer, ldloc:'<ExceptIterator>d__77`1'(this)))
	stloc:IEqualityComparer`1(var_5_24, ldfld:class [mscorlib]System.Collections.Generic.IEqualityComparer`1<!TSource>[exp:IEqualityComparer`1]('<ExceptIterator>d__77`1'::comparer, ldloc:'<ExceptIterator>d__77`1'(this)))
	stloc:Set`1(var_6_2C, ldfld:class System.Linq.Set`1<!TSource>[exp:Set`1]('<ExceptIterator>d__77`1'::<set>5__2, ldloc:'<ExceptIterator>d__77`1'(this)))
	stloc:IEnumerable`1(var_7_34, ldfld:class [mscorlib]System.Collections.Generic.IEnumerable`1<!TSource>[exp:IEnumerable`1]('<ExceptIterator>d__77`1'::first, ldloc:'<ExceptIterator>d__77`1'(this)))
	stloc:IEnumerable`1(var_8_3C, ldfld:class [mscorlib]System.Collections.Generic.IEnumerable`1<!TSource>[exp:IEnumerable`1]('<ExceptIterator>d__77`1'::second, ldloc:'<ExceptIterator>d__77`1'(this)))
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

			// Token: 0x060000D0 RID: 208 RVA: 0x00002050 File Offset: 0x00000250
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x0400005A RID: 90
			private int <>1__state;

			// Token: 0x0400005B RID: 91
			private TSource <>2__current;

			// Token: 0x0400005C RID: 92
			private int <>l__initialThreadId;

			// Token: 0x0400005D RID: 93
			private IEqualityComparer<TSource> comparer;

			// Token: 0x0400005E RID: 94
			public IEqualityComparer<TSource> <>3__comparer;

			// Token: 0x0400005F RID: 95
			private IEnumerable<TSource> second;

			// Token: 0x04000060 RID: 96
			public IEnumerable<TSource> <>3__second;

			// Token: 0x04000061 RID: 97
			private IEnumerable<TSource> first;

			// Token: 0x04000062 RID: 98
			public IEnumerable<TSource> <>3__first;

			// Token: 0x04000063 RID: 99
			private Set<TSource> <set>5__2;

			// Token: 0x04000064 RID: 100
			private IEnumerator<TSource> <>7__wrap2;
		}

		// Token: 0x02000018 RID: 24
		[CompilerGenerated]
		private sealed class <OfTypeIterator>d__97<TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator
		{
			// Token: 0x060000D1 RID: 209 RVA: 0x00003628 File Offset: 0x00001828
			[DebuggerHidden]
			public <OfTypeIterator>d__97(int <>1__state)
			{
				this.<>1__state = <>1__state;
				int currentManagedThreadId = Environment.CurrentManagedThreadId;
				this.source = currentManagedThreadId;
			}

			// Token: 0x060000D2 RID: 210 RVA: 0x00003654 File Offset: 0x00001854
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
				int num = this.<>1__state;
			}

			// Token: 0x060000D3 RID: 211 RVA: 0x0000366C File Offset: 0x0000186C
			private bool MoveNext()
			{
				int num = this.<>1__state;
				if (num != 0)
				{
					throw new OutOfMemoryException();
				}
				IEnumerable enumerable = this.<>3__source;
				this.<>1__state = num;
				if (enumerable == null)
				{
				}
				if (enumerable != null && enumerable == null)
				{
					throw new InvalidCastException();
				}
				if (enumerable == null || enumerable != null)
				{
				}
				throw new InvalidCastException();
			}

			// Token: 0x060000D4 RID: 212 RVA: 0x000036C0 File Offset: 0x000018C0
			private void <>m__Finally1()
			{
				int num = 1;
				this.<>1__state = num;
			}

			// Token: 0x1700001B RID: 27
			// (get) Token: 0x060000D5 RID: 213 RVA: 0x00002050 File Offset: 0x00000250
			TResult IEnumerator<TResult>.Current
			{
				[DebuggerHidden]
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x060000D6 RID: 214 RVA: 0x00002050 File Offset: 0x00000250
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x1700001C RID: 28
			// (get) Token: 0x060000D7 RID: 215 RVA: 0x00002050 File Offset: 0x00000250
			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x060000D8 RID: 216 RVA: 0x000036D8 File Offset: 0x000018D8
			[DebuggerHidden]
			IEnumerator<TResult> IEnumerable<TResult>.GetEnumerator()
			{
				/*
An exception occurred when decompiling this method (060000D8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IEnumerator`1<TResult> System.Linq.Enumerable/<OfTypeIterator>d__97`1::System.Collections.Generic.IEnumerable<TResult>.GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32('<OfTypeIterator>d__97`1'::<>1__state, ldloc:'<OfTypeIterator>d__97`1'(this)))
	stloc:IEnumerable(var_1_0D, ldfld:IEnumerable('<OfTypeIterator>d__97`1'::source, ldloc:'<OfTypeIterator>d__97`1'(this)))
	stloc:int32(var_3_15, callgetter:int32(Environment::get_CurrentManagedThreadId))
	stloc:IEnumerable(var_4_1C, ldfld:IEnumerable('<OfTypeIterator>d__97`1'::source, ldloc:'<OfTypeIterator>d__97`1'(this)))
	stloc:IEnumerable(var_5_24, ldfld:IEnumerable('<OfTypeIterator>d__97`1'::source, ldloc:'<OfTypeIterator>d__97`1'(this)))
	stloc:IEnumerator(var_6_2C, ldfld:IEnumerator('<OfTypeIterator>d__97`1'::<>7__wrap1, ldloc:'<OfTypeIterator>d__97`1'(this)))
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

			// Token: 0x060000D9 RID: 217 RVA: 0x00002050 File Offset: 0x00000250
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x04000065 RID: 101
			private int <>1__state;

			// Token: 0x04000066 RID: 102
			private TResult <>2__current;

			// Token: 0x04000067 RID: 103
			private int <>l__initialThreadId;

			// Token: 0x04000068 RID: 104
			private IEnumerable source;

			// Token: 0x04000069 RID: 105
			public IEnumerable <>3__source;

			// Token: 0x0400006A RID: 106
			private IEnumerator <>7__wrap1;
		}

		// Token: 0x02000019 RID: 25
		[CompilerGenerated]
		private sealed class <CastIterator>d__99<TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator
		{
			// Token: 0x060000DA RID: 218 RVA: 0x00003714 File Offset: 0x00001914
			[DebuggerHidden]
			public <CastIterator>d__99(int <>1__state)
			{
				this.<>1__state = <>1__state;
				int currentManagedThreadId = Environment.CurrentManagedThreadId;
				this.<>3__source = currentManagedThreadId;
			}

			// Token: 0x060000DB RID: 219 RVA: 0x00003740 File Offset: 0x00001940
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
				int num = this.<>1__state;
			}

			// Token: 0x060000DC RID: 220 RVA: 0x00003758 File Offset: 0x00001958
			private bool MoveNext()
			{
				int num = this.<>1__state;
				if (num == 0)
				{
					IEnumerator enumerator = this.<>7__wrap1;
					this.<>1__state = num;
					long value = 0.m_value;
					throw new InvalidCastException();
				}
				throw new OutOfMemoryException();
			}

			// Token: 0x060000DD RID: 221 RVA: 0x0000379C File Offset: 0x0000199C
			private void <>m__Finally1()
			{
				int num = 1;
				this.<>1__state = num;
			}

			// Token: 0x1700001D RID: 29
			// (get) Token: 0x060000DE RID: 222 RVA: 0x000037B4 File Offset: 0x000019B4
			TResult IEnumerator<TResult>.Current
			{
				[DebuggerHidden]
				get
				{
					/*
An exception occurred when decompiling this method (060000DE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling TResult System.Linq.Enumerable/<CastIterator>d__99`1::System.Collections.Generic.IEnumerator<TResult>.get_Current()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:IEnumerable(var_0_06, ldfld:IEnumerable('<CastIterator>d__99`1'::source, ldloc:'<CastIterator>d__99`1'(this)))
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

			// Token: 0x060000DF RID: 223 RVA: 0x00002050 File Offset: 0x00000250
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x060000E0 RID: 224 RVA: 0x00002050 File Offset: 0x00000250
			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x060000E1 RID: 225 RVA: 0x000037C8 File Offset: 0x000019C8
			[DebuggerHidden]
			IEnumerator<TResult> IEnumerable<TResult>.GetEnumerator()
			{
				/*
An exception occurred when decompiling this method (060000E1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IEnumerator`1<TResult> System.Linq.Enumerable/<CastIterator>d__99`1::System.Collections.Generic.IEnumerable<TResult>.GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32('<CastIterator>d__99`1'::<>1__state, ldloc:'<CastIterator>d__99`1'(this)))
	stloc:IEnumerable(var_1_0D, ldfld:IEnumerable('<CastIterator>d__99`1'::<>3__source, ldloc:'<CastIterator>d__99`1'(this)))
	stloc:int32(var_3_15, callgetter:int32(Environment::get_CurrentManagedThreadId))
	stloc:IEnumerable(var_4_1C, ldfld:IEnumerable('<CastIterator>d__99`1'::source, ldloc:'<CastIterator>d__99`1'(this)))
	stloc:IEnumerable(var_5_24, ldfld:IEnumerable('<CastIterator>d__99`1'::source, ldloc:'<CastIterator>d__99`1'(this)))
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

			// Token: 0x060000E2 RID: 226 RVA: 0x00002050 File Offset: 0x00000250
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x0400006B RID: 107
			private int <>1__state;

			// Token: 0x0400006C RID: 108
			private TResult <>2__current;

			// Token: 0x0400006D RID: 109
			private int <>l__initialThreadId;

			// Token: 0x0400006E RID: 110
			private IEnumerable source;

			// Token: 0x0400006F RID: 111
			public IEnumerable <>3__source;

			// Token: 0x04000070 RID: 112
			private IEnumerator <>7__wrap1;
		}
	}
}
