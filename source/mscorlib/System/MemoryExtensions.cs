using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace System
{
	// Token: 0x020000DA RID: 218
	public static class MemoryExtensions
	{
		// Token: 0x06000823 RID: 2083 RVA: 0x00012F18 File Offset: 0x00011118
		internal static bool EqualsOrdinal(this ReadOnlySpan<char> span, ReadOnlySpan<char> value)
		{
			if (span != null)
			{
				int length = span._length;
				int length2 = value._length;
				int length3 = value._length;
				bool flag;
				return flag;
			}
			return true;
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x00012F50 File Offset: 0x00011150
		internal static bool EqualsOrdinalIgnoreCase(this ReadOnlySpan<char> span, ReadOnlySpan<char> value)
		{
			if (span != null)
			{
			}
			return true;
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x00012F64 File Offset: 0x00011164
		internal static bool Contains(this ReadOnlySpan<char> source, char value)
		{
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x00012F78 File Offset: 0x00011178
		public static int ToUpperInvariant(this ReadOnlySpan<char> source, Span<char> destination)
		{
			/*
An exception occurred when decompiling this method (06000826)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.MemoryExtensions::ToUpperInvariant(System.ReadOnlySpan`1<System.Char>,System.Span`1<System.Char>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0006:
	stloc:CultureInfo(var_1_0D, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
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

		// Token: 0x06000827 RID: 2087 RVA: 0x00012F94 File Offset: 0x00011194
		public static bool EndsWith(this ReadOnlySpan<char> span, ReadOnlySpan<char> value, StringComparison comparisonType)
		{
			if (comparisonType != StringComparison.CurrentCulture)
			{
				CultureInfo currentCulture = CultureInfo.CurrentCulture;
			}
			int length = value._length;
			int length2 = value._length;
			bool flag;
			return flag;
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x00012FF0 File Offset: 0x000111F0
		public static Span<T> AsSpan<T>(this T[] array, int start)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException();
			if (array != null)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException();
				return;
			}
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x00013014 File Offset: 0x00011214
		public static ReadOnlySpan<char> AsSpan(this string text)
		{
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x00013024 File Offset: 0x00011224
		public static ReadOnlySpan<char> AsSpan(this string text, int start)
		{
			if (text != null)
			{
				return;
			}
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x00013040 File Offset: 0x00011240
		public static ReadOnlySpan<char> AsSpan(this string text, int start, int length)
		{
			int num = 1;
			if (num != 0)
			{
				return;
			}
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x0001305C File Offset: 0x0001125C
		public static ReadOnlySpan<char> Trim(this ReadOnlySpan<char> span)
		{
			ReadOnlySpan<char> readOnlySpan;
			return MemoryExtensions.TrimEnd(readOnlySpan);
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x00013070 File Offset: 0x00011270
		public static ReadOnlySpan<char> TrimStart(this ReadOnlySpan<char> span)
		{
			/*
An exception occurred when decompiling this method (0600082D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.ReadOnlySpan`1<System.Char> System.MemoryExtensions::TrimStart(System.ReadOnlySpan`1<System.Char>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0007:
	call:void(ThrowHelper::ThrowArgumentOutOfRangeException)
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

		// Token: 0x0600082E RID: 2094 RVA: 0x0001308C File Offset: 0x0001128C
		public static ReadOnlySpan<char> TrimEnd(this ReadOnlySpan<char> span)
		{
			/*
An exception occurred when decompiling this method (0600082E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.ReadOnlySpan`1<System.Char> System.MemoryExtensions::TrimEnd(System.ReadOnlySpan`1<System.Char>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	call:void(ThrowHelper::ThrowArgumentOutOfRangeException)
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

		// Token: 0x0600082F RID: 2095 RVA: 0x000130A4 File Offset: 0x000112A4
		public static int IndexOf<T>(this ReadOnlySpan<T> span, T value) where T : IEquatable<T>
		{
			Type type;
			Type type2;
			bool flag = type == type2;
			int num;
			return num;
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x000130CC File Offset: 0x000112CC
		public static int IndexOfAny<T>(this ReadOnlySpan<T> span, ReadOnlySpan<T> values) where T : IEquatable<T>
		{
			Type type;
			Type type2;
			bool flag = type == type2;
			int num;
			return num;
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x000130EC File Offset: 0x000112EC
		public static bool SequenceEqual<T>(this ReadOnlySpan<T> span, ReadOnlySpan<T> other) where T : IEquatable<T>
		{
			int length = span._length;
			int length2 = other._length;
			int length3 = other._length;
			bool flag;
			return flag;
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x00013124 File Offset: 0x00011324
		public static bool StartsWith<T>(this ReadOnlySpan<T> span, ReadOnlySpan<T> value) where T : IEquatable<T>
		{
			int length = span._length;
			int length2 = value._length;
			int length3 = value._length;
			bool flag;
			return flag;
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x0001315C File Offset: 0x0001135C
		public static bool EndsWith<T>(this ReadOnlySpan<T> span, ReadOnlySpan<T> value) where T : IEquatable<T>
		{
			int length = span._length;
			int length2 = value._length;
			int length3 = value._length;
			bool flag;
			return flag;
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x00013194 File Offset: 0x00011394
		public static Span<T> AsSpan<T>(this T[] array, int start, int length)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException();
			if (true)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException();
				return;
			}
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x000131B4 File Offset: 0x000113B4
		public static void CopyTo<T>(this T[] source, Span<T> destination)
		{
			if (source != null)
			{
				return;
			}
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x000131C8 File Offset: 0x000113C8
		private static bool IsTypeComparableAsBytes<T>([Out] ulong size)
		{
			Type type;
			Type type2;
			bool flag = type == type2;
			Type type3;
			Type type4;
			bool flag2 = type3 == type4;
			return true;
		}
	}
}
