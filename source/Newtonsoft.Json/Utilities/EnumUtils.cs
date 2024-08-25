using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000065 RID: 101
	[Preserve]
	internal static class EnumUtils
	{
		// Token: 0x060003A1 RID: 929 RVA: 0x0000A5A8 File Offset: 0x000087A8
		private static BidirectionalDictionary<string, string> InitializeEnumType(Type type)
		{
			/*
An exception occurred when decompiling this method (060003A1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Newtonsoft.Json.Utilities.BidirectionalDictionary`2<System.String,System.String> Newtonsoft.Json.Utilities.EnumUtils::InitializeEnumType(System.Type)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000E:
	stloc:CultureInfo(var_6_16, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
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

		// Token: 0x060003A2 RID: 930 RVA: 0x0000A5CC File Offset: 0x000087CC
		public static IList<T> GetFlagsValues<T>(T value) where T : struct
		{
			return null;
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0000A5CC File Offset: 0x000087CC
		public static IList<EnumValue<ulong>> GetNamesAndValues<T>() where T : struct
		{
			return null;
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0000A5CC File Offset: 0x000087CC
		public static IList<EnumValue<TUnderlyingType>> GetNamesAndValues<TUnderlyingType>(Type enumType) where TUnderlyingType : struct
		{
			return null;
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0000A5D0 File Offset: 0x000087D0
		public static IList<object> GetValues(Type enumType)
		{
			long num = 0L;
			FieldInfo[] array;
			if (array != null)
			{
			}
			if (num == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0000A604 File Offset: 0x00008804
		public static IList<string> GetNames(Type enumType)
		{
			long num = 0L;
			FieldInfo[] array;
			if (array != null)
			{
			}
			if (num == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0000A630 File Offset: 0x00008830
		public static object ParseEnumName(string enumText, bool isNullable, Type t)
		{
			string[] array;
			string text = array.Trim();
			string text2;
			if (text2 == null || text2 != null)
			{
				string text3 = string.Join(", ", array);
				if (", " == null)
				{
				}
				object obj;
				return obj;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0000A674 File Offset: 0x00008874
		public static string ToEnumName(Type enumType, string enumText, bool camelCaseText)
		{
			if (!true)
			{
			}
			string[] array;
			string text = StringUtils.ToCamelCase(array.Trim());
			if (text == null || text != null)
			{
				return string.Join(", ", array);
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0000212A File Offset: 0x0000032A
		private static string ResolvedEnumName(BidirectionalDictionary<string, string> map, string enumText)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0000A6B4 File Offset: 0x000088B4
		// Note: this type is marked as 'beforefieldinit'.
		static EnumUtils()
		{
		}

		// Token: 0x040001EA RID: 490
		private static readonly ThreadSafeStore<Type, BidirectionalDictionary<string, string>> EnumMemberNamesPerType;

		// Token: 0x02000066 RID: 102
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060003AB RID: 939 RVA: 0x0000A6C4 File Offset: 0x000088C4
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060003AC RID: 940 RVA: 0x0000A6D4 File Offset: 0x000088D4
			public <>c()
			{
			}

			// Token: 0x060003AD RID: 941 RVA: 0x0000A6E8 File Offset: 0x000088E8
			internal string <InitializeEnumType>b__1_0(EnumMemberAttribute a)
			{
				return a.value;
			}

			// Token: 0x060003AE RID: 942 RVA: 0x0000A6FC File Offset: 0x000088FC
			internal bool <GetValues>b__5_0(FieldInfo f)
			{
				return f.IsLiteral;
			}

			// Token: 0x060003AF RID: 943 RVA: 0x0000A710 File Offset: 0x00008910
			internal bool <GetNames>b__6_0(FieldInfo f)
			{
				return f.IsLiteral;
			}

			// Token: 0x040001EB RID: 491
			public static readonly EnumUtils.<>c <>9;

			// Token: 0x040001EC RID: 492
			public static Func<EnumMemberAttribute, string> <>9__1_0;

			// Token: 0x040001ED RID: 493
			public static Func<FieldInfo, bool> <>9__5_0;

			// Token: 0x040001EE RID: 494
			public static Func<FieldInfo, bool> <>9__6_0;
		}

		// Token: 0x02000067 RID: 103
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c__2<T> where T : struct
		{
			// Token: 0x060003B0 RID: 944 RVA: 0x0000A723 File Offset: 0x00008923
			// Note: this type is marked as 'beforefieldinit'.
			static <>c__2()
			{
			}

			// Token: 0x060003B1 RID: 945 RVA: 0x0000A723 File Offset: 0x00008923
			public <>c__2()
			{
			}

			// Token: 0x060003B2 RID: 946 RVA: 0x0000A728 File Offset: 0x00008928
			internal bool <GetFlagsValues>b__2_0(EnumValue<ulong> v)
			{
				return default(bool);
			}

			// Token: 0x040001EF RID: 495
			public static readonly EnumUtils.<>c__2<T> <>9;

			// Token: 0x040001F0 RID: 496
			public static Func<EnumValue<ulong>, bool> <>9__2_0;
		}
	}
}
