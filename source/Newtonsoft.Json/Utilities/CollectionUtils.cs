using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200006C RID: 108
	[Preserve]
	internal static class CollectionUtils
	{
		// Token: 0x060003CA RID: 970 RVA: 0x0000AB04 File Offset: 0x00008D04
		public static bool IsNullOrEmpty<T>(ICollection<T> collection)
		{
			/*
An exception occurred when decompiling this method (060003CA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Newtonsoft.Json.Utilities.CollectionUtils::IsNullOrEmpty<T>(System.Collections.Generic.ICollection`1<T>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(int32::m_value, ldc.i4:int32[exp:int32&](1)))
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

		// Token: 0x060003CB RID: 971 RVA: 0x0000AB18 File Offset: 0x00008D18
		public static void AddRange<T>(this IList<T> initial, IEnumerable<T> collection)
		{
			if (initial == null)
			{
				throw new OutOfMemoryException();
			}
			if (collection != null)
			{
				return;
			}
		}

		// Token: 0x060003CC RID: 972 RVA: 0x0000AB54 File Offset: 0x00008D54
		public static void AddRange<T>(this IList<T> initial, IEnumerable collection)
		{
		}

		// Token: 0x060003CD RID: 973 RVA: 0x0000AB64 File Offset: 0x00008D64
		public static bool IsDictionaryType(Type type)
		{
			ValidationUtils.ArgumentNotNull("type", "type");
			if (!true)
			{
			}
			return true;
		}

		// Token: 0x060003CE RID: 974 RVA: 0x0000AB88 File Offset: 0x00008D88
		public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType)
		{
			if (!true)
			{
			}
			if (collectionType == null || collectionType != null)
			{
				Type type;
				return CollectionUtils.ResolveEnumerableCollectionConstructor(type, collectionType, type);
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060003CF RID: 975 RVA: 0x0000ABAC File Offset: 0x00008DAC
		public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType, Type constructorArgumentType)
		{
			if (!true)
			{
			}
			if ((collectionType != null && collectionType == null) || !false)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x0000212A File Offset: 0x0000032A
		public static bool AddDistinct<T>(this IList<T> list, T value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x0000ABD0 File Offset: 0x00008DD0
		public static bool AddDistinct<T>(this IList<T> list, T value, IEqualityComparer<T> comparer)
		{
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x0000ABE0 File Offset: 0x00008DE0
		public static bool ContainsValue<TSource>(this IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer)
		{
			if (value != null)
			{
				while (value != null)
				{
				}
			}
			if (!false)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x0000AC14 File Offset: 0x00008E14
		public static bool AddRangeDistinct<T>(this IList<T> list, IEnumerable<T> values, IEqualityComparer<T> comparer)
		{
			long num = 0L;
			if (list != null)
			{
			}
			if (num == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x0000AC48 File Offset: 0x00008E48
		public static int IndexOf<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
		{
			if (!false)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x0000AC78 File Offset: 0x00008E78
		public static bool Contains<T>(this List<T> list, T value, IEqualityComparer comparer)
		{
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x0000AC8C File Offset: 0x00008E8C
		public static int IndexOfReference<T>(this List<T> list, T item)
		{
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0000AC9C File Offset: 0x00008E9C
		private static IList<int> GetDimensions(IList values, int dimensionsCount)
		{
			throw new InvalidCastException();
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x0000ACB0 File Offset: 0x00008EB0
		private static void CopyFromJaggedToMultidimensionalArray(IList values, Array multidimensionalArray, int[] indices)
		{
			int rank = multidimensionalArray.Rank;
			object obj = CollectionUtils.JaggedArrayGetValue(values, indices);
			multidimensionalArray.SetValue(obj, indices);
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x0000AD1C File Offset: 0x00008F1C
		private static object JaggedArrayGetValue(IList values, int[] indices)
		{
			throw new InvalidCastException();
		}

		// Token: 0x060003DA RID: 986 RVA: 0x0000AD34 File Offset: 0x00008F34
		public static Array ToMultidimensionalArray(IList values, Type type, int rank)
		{
			IList<int> list;
			int[] array = Enumerable.ToArray<int>(list);
			Array array2;
			return array2;
		}
	}
}
