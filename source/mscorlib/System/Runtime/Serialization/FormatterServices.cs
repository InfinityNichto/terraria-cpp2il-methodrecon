using System;
using System.Collections.Concurrent;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System.Runtime.Serialization
{
	// Token: 0x020003D7 RID: 983
	[ComVisible(true)]
	public static class FormatterServices
	{
		// Token: 0x06001F02 RID: 7938 RVA: 0x00043BE0 File Offset: 0x00041DE0
		static FormatterServices()
		{
			Type type;
			if (type == null || type != null)
			{
				Binder defaultBinder = Type.DefaultBinder;
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06001F03 RID: 7939 RVA: 0x00043C04 File Offset: 0x00041E04
		private static MemberInfo[] GetSerializableMembers(RuntimeType type)
		{
			long num = 0L;
			if (num == 0L || num != 0L)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06001F04 RID: 7940 RVA: 0x0000207A File Offset: 0x0000027A
		private static bool CheckSerializable(RuntimeType type)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001F05 RID: 7941 RVA: 0x00043C24 File Offset: 0x00041E24
		private static MemberInfo[] InternalGetSerializableMembers(RuntimeType type)
		{
			MemberInfo[] array;
			if (array != null)
			{
			}
			Type type2;
			if (type2 != null || type2 != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06001F06 RID: 7942 RVA: 0x00043C74 File Offset: 0x00041E74
		private static bool GetParentTypes(RuntimeType parentType, [Out] RuntimeType[] parentTypes, [Out] int parentTypeCount)
		{
			if (!true)
			{
			}
			Type type;
			if (type != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06001F07 RID: 7943 RVA: 0x00043CCC File Offset: 0x00041ECC
		public static MemberInfo[] GetSerializableMembers(Type type, StreamingContext context)
		{
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06001F08 RID: 7944 RVA: 0x00043CE0 File Offset: 0x00041EE0
		public static object GetUninitializedObject(Type type)
		{
			object obj;
			return obj;
		}

		// Token: 0x06001F09 RID: 7945 RVA: 0x00043D00 File Offset: 0x00041F00
		private static object nativeGetUninitializedObject(RuntimeType type)
		{
			object obj;
			return obj;
		}

		// Token: 0x06001F0A RID: 7946 RVA: 0x00043D10 File Offset: 0x00041F10
		private static bool GetEnableUnsafeTypeForwarders()
		{
		}

		// Token: 0x06001F0B RID: 7947 RVA: 0x00043D20 File Offset: 0x00041F20
		internal static bool UnsafeTypeForwardersIsEnabled()
		{
			/*
An exception occurred when decompiling this method (06001F0B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Runtime.Serialization.FormatterServices::UnsafeTypeForwardersIsEnabled()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0006:
	brtrue(IL_0000, ldc.i4:bool(1))
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

		// Token: 0x06001F0C RID: 7948 RVA: 0x00043D38 File Offset: 0x00041F38
		internal static void SerializationSetValue(MemberInfo fi, object target, object value)
		{
			if (fi != null)
			{
			}
		}

		// Token: 0x06001F0D RID: 7949 RVA: 0x00043D5C File Offset: 0x00041F5C
		public static object PopulateObjectMembers(object obj, MemberInfo[] members, object[] data)
		{
			/*
An exception occurred when decompiling this method (06001F0D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Runtime.Serialization.FormatterServices::PopulateObjectMembers(System.Object,System.Reflection.MemberInfo[],System.Object[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_002D:
	stloc:string(var_6_37, call:string(Environment::GetResourceString, ldstr:string("Parameters 'members' and 'data' must have the same length.")))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

		// Token: 0x06001F0E RID: 7950 RVA: 0x00043DA4 File Offset: 0x00041FA4
		public static object[] GetObjectData(object obj, MemberInfo[] members)
		{
			while (obj == null)
			{
			}
			object obj2;
			if (obj2 == null || obj2 != null)
			{
				throw new ArrayTypeMismatchException();
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06001F0F RID: 7951 RVA: 0x0000207A File Offset: 0x0000027A
		public static Type GetTypeFromAssembly(Assembly assem, string name)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001F10 RID: 7952 RVA: 0x00043DE8 File Offset: 0x00041FE8
		internal static Assembly LoadAssemblyFromString(string assemblyName)
		{
			Assembly assembly;
			return assembly;
		}

		// Token: 0x06001F11 RID: 7953 RVA: 0x00043DF8 File Offset: 0x00041FF8
		internal static Assembly LoadAssemblyFromStringNoThrow(string assemblyName)
		{
			if (!true)
			{
			}
			Assembly assembly;
			return assembly;
		}

		// Token: 0x06001F12 RID: 7954 RVA: 0x00043E14 File Offset: 0x00042014
		internal static string GetClrAssemblyName(Type type, [Out] bool hasTypeForwardedFrom)
		{
			Type type2;
			if (type2 != null)
			{
				if (type2 != null)
				{
				}
				RuntimeTypeHandle impl = type2._impl;
			}
			throw new InvalidCastException();
		}

		// Token: 0x06001F13 RID: 7955 RVA: 0x00043E34 File Offset: 0x00042034
		internal static string GetClrTypeFullName(Type type)
		{
			string text;
			return text;
		}

		// Token: 0x06001F14 RID: 7956 RVA: 0x00043E44 File Offset: 0x00042044
		private static string GetClrTypeFullNameForArray(Type type)
		{
			string text;
			return string.Format(CultureInfo.InvariantCulture, "{0}{1}", text, "[]");
		}

		// Token: 0x06001F15 RID: 7957 RVA: 0x00043E84 File Offset: 0x00042084
		private static string GetClrTypeFullNameForNonArrayTypes(Type type)
		{
			/*
An exception occurred when decompiling this method (06001F15)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Runtime.Serialization.FormatterServices::GetClrTypeFullNameForNonArrayTypes(System.Type)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:StringBuilder(var_3_1D, call:StringBuilder(StringBuilder::Append, call:StringBuilder(StringBuilder::Append, call:StringBuilder(StringBuilder::Append, ldloc:StringBuilder(var_0), ldstr:string("[")), ldloc:string(var_2)), ldstr:string(", ")))
	stloc:StringBuilder(var_5_30, call:StringBuilder(StringBuilder::Append, call:StringBuilder(StringBuilder::Append, ldloc:StringBuilder(var_0), ldloc:string(var_4)), ldstr:string("],")))
	stloc:int64(var_6_33, ldc.i4:int64(0))
	stloc:int32(var_7_3B, callgetter:int32(StringBuilder::get_Length, ldloc:StringBuilder(var_0)))
	stloc:int32(var_8_3E, ldc.i4:int32(1))
	stloc:StringBuilder(var_9_54, call:StringBuilder(StringBuilder::Append, call:StringBuilder(StringBuilder::Remove, ldloc:StringBuilder(var_0), ldloc:int64[exp:int32](var_6_33), ldloc:int32(var_8_3E)), ldstr:string("]")))
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

		// Token: 0x04000F8E RID: 3982
		internal static ConcurrentDictionary<MemberHolder, MemberInfo[]> m_MemberInfoTable;

		// Token: 0x04000F8F RID: 3983
		private static bool unsafeTypeForwardersIsEnabled;

		// Token: 0x04000F90 RID: 3984
		private static bool unsafeTypeForwardersIsEnabledInitialized;

		// Token: 0x04000F91 RID: 3985
		private static readonly Type[] advancedTypes;

		// Token: 0x04000F92 RID: 3986
		private static Binder s_binder;

		// Token: 0x020003D8 RID: 984
		[CompilerGenerated]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x06001F16 RID: 7958 RVA: 0x00043EE8 File Offset: 0x000420E8
			public <>c__DisplayClass9_0()
			{
			}

			// Token: 0x06001F17 RID: 7959 RVA: 0x00043EFC File Offset: 0x000420FC
			internal MemberInfo[] <GetSerializableMembers>b__0(MemberHolder _)
			{
				int num = 1;
				Type type = this.type;
				if ((num != 0 && type != null) || type != null)
				{
				}
				MemberInfo[] array;
				return array;
			}

			// Token: 0x04000F93 RID: 3987
			public Type type;
		}
	}
}
