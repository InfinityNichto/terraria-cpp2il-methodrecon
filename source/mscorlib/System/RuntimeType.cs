using System;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x02000158 RID: 344
	[Serializable]
	[StructLayout(0)]
	internal class RuntimeType : TypeInfo, ISerializable, ICloneable
	{
		// Token: 0x06000D8F RID: 3471 RVA: 0x0001D968 File Offset: 0x0001BB68
		internal static RuntimeType GetType(string typeName, bool throwOnError, bool ignoreCase, bool reflectionOnly, StackCrawlMark stackMark)
		{
			RuntimeType runtimeType;
			return runtimeType;
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x0001D978 File Offset: 0x0001BB78
		private static void ThrowIfTypeNeverValidGenericArgument(RuntimeType type)
		{
			bool isPointer = type.IsPointer;
			bool isByRef = type.IsByRef;
			Type type2;
			bool flag = type == type2;
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x0001D9A4 File Offset: 0x0001BBA4
		internal static void SanityCheckGenericArguments(RuntimeType[] genericArguments, RuntimeType[] genericParamters)
		{
			if (genericArguments != null)
			{
				MonoTypeInfo monoTypeInfo = genericArguments.type_info;
				if (monoTypeInfo == null)
				{
				}
				if (monoTypeInfo == null)
				{
				}
				MonoTypeInfo monoTypeInfo2 = genericArguments.type_info;
				MonoTypeInfo monoTypeInfo3 = genericParamters.type_info;
				return;
			}
			MonoTypeInfo monoTypeInfo4 = genericArguments.type_info;
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x0001D9E8 File Offset: 0x0001BBE8
		private static void SplitName(string fullname, [Out] string name, [Out] string ns)
		{
			if (fullname != null)
			{
				long num = 0L;
				int num2;
				int stringLength = fullname.Substring((int)num, num2)._stringLength;
				int stringLength2 = fullname._stringLength;
				string text = fullname.Substring((int)num, num2);
				return;
			}
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x0000207A File Offset: 0x0000027A
		internal static BindingFlags FilterPreCalculate(bool isPublic, bool isInherited, bool isStatic)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x0001DA1C File Offset: 0x0001BC1C
		private static void FilterHelper(BindingFlags bindingFlags, string name, bool allowPrefixLookup, [Out] bool prefixLookup, [Out] bool ignoreCase, [Out] RuntimeType.MemberListType listType)
		{
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x0001DA5C File Offset: 0x0001BC5C
		private static void FilterHelper(BindingFlags bindingFlags, string name, [Out] bool ignoreCase, [Out] RuntimeType.MemberListType listType)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x0001DA6C File Offset: 0x0001BC6C
		private static bool FilterApplyPrefixLookup(MemberInfo memberInfo, string name, bool ignoreCase)
		{
			return true;
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x0001DA7C File Offset: 0x0001BC7C
		private static bool FilterApplyBase(MemberInfo memberInfo, BindingFlags bindingFlags, bool isPublic, bool isNonProtectedInternal, bool isStatic, string name, bool prefixLookup)
		{
			int num = 1;
			if (num != 0)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x0001DA9C File Offset: 0x0001BC9C
		private static bool FilterApplyType(Type type, BindingFlags bindingFlags, string name, bool prefixLookup, string ns)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x0001DAB4 File Offset: 0x0001BCB4
		private static bool FilterApplyMethodInfo(RuntimeMethodInfo method, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x0001DAC8 File Offset: 0x0001BCC8
		private static bool FilterApplyConstructorInfo(RuntimeConstructorInfo constructor, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x0001DADC File Offset: 0x0001BCDC
		private static bool FilterApplyMethodBase(MethodBase methodBase, BindingFlags methodFlags, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes)
		{
			if (callConv != (CallingConventions)0)
			{
				bool flag;
				return flag;
			}
		}

		// Token: 0x06000D9C RID: 3484 RVA: 0x0001DB04 File Offset: 0x0001BD04
		internal RuntimeType()
		{
			/*
An exception occurred when decompiling this method (06000D9C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.RuntimeType::.ctor()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(TypeInfo::.ctor, ldloc:RuntimeType[exp:TypeInfo](this))
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

		// Token: 0x06000D9D RID: 3485 RVA: 0x0001DB18 File Offset: 0x0001BD18
		private RuntimeType.ListBuilder<MethodInfo> GetMethodCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, int genericParamCount, bool allowPrefixLookup)
		{
			/*
An exception occurred when decompiling this method (06000D9D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.RuntimeType/ListBuilder`1<System.Reflection.MethodInfo> System.RuntimeType::GetMethodCandidates(System.String,System.Reflection.BindingFlags,System.Reflection.CallingConventions,System.Type[],System.Int32,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:string(var_1_09, ldfld:string(RuntimeMethodInfo::name, ldloc:class System.Reflection.RuntimeMethodInfo[][exp:RuntimeMethodInfo](var_0)))
	stloc:string(var_2_10, ldfld:string(RuntimeMethodInfo::name, ldloc:class System.Reflection.RuntimeMethodInfo[][exp:RuntimeMethodInfo](var_0)))
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

		// Token: 0x06000D9E RID: 3486 RVA: 0x0001DB38 File Offset: 0x0001BD38
		private RuntimeType.ListBuilder<ConstructorInfo> GetConstructorCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, bool allowPrefixLookup)
		{
			/*
An exception occurred when decompiling this method (06000D9E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.RuntimeType/ListBuilder`1<System.Reflection.ConstructorInfo> System.RuntimeType::GetConstructorCandidates(System.String,System.Reflection.BindingFlags,System.Reflection.CallingConventions,System.Type[],System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0038:
	brtrue(IL_0000, ldloc:string[exp:bool](var_7_2F))
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

		// Token: 0x06000D9F RID: 3487 RVA: 0x0001DB80 File Offset: 0x0001BD80
		private RuntimeType.ListBuilder<PropertyInfo> GetPropertyCandidates(string name, BindingFlags bindingAttr, Type[] types, bool allowPrefixLookup)
		{
			/*
An exception occurred when decompiling this method (06000D9F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.RuntimeType/ListBuilder`1<System.Reflection.PropertyInfo> System.RuntimeType::GetPropertyCandidates(System.String,System.Reflection.BindingFlags,System.Type[],System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:native int(var_1_09, ldfld:native int(RuntimePropertyInfo::prop, ldloc:class System.Reflection.RuntimePropertyInfo[][exp:RuntimePropertyInfo](var_0)))
	stloc:native int(var_2_10, ldfld:native int(RuntimePropertyInfo::prop, ldloc:class System.Reflection.RuntimePropertyInfo[][exp:RuntimePropertyInfo](var_0)))
	brtrue(IL_0000, logicnot:bool(ldloc:class System.Type[][exp:bool](types)))
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

		// Token: 0x06000DA0 RID: 3488 RVA: 0x0001DBA4 File Offset: 0x0001BDA4
		private RuntimeType.ListBuilder<EventInfo> GetEventCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup)
		{
			/*
An exception occurred when decompiling this method (06000DA0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.RuntimeType/ListBuilder`1<System.Reflection.EventInfo> System.RuntimeType::GetEventCandidates(System.String,System.Reflection.BindingFlags,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:native int(var_1_09, ldfld:native int(RuntimeEventInfo::klass, ldloc:class System.Reflection.RuntimeEventInfo[][exp:RuntimeEventInfo](var_0)))
	brtrue(IL_0000, ldfld:native int[exp:bool](RuntimeEventInfo::klass, ldloc:class System.Reflection.RuntimeEventInfo[][exp:RuntimeEventInfo](var_0)))
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

		// Token: 0x06000DA1 RID: 3489 RVA: 0x0001DBC8 File Offset: 0x0001BDC8
		private RuntimeType.ListBuilder<FieldInfo> GetFieldCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup)
		{
			/*
An exception occurred when decompiling this method (06000DA1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.RuntimeType/ListBuilder`1<System.Reflection.FieldInfo> System.RuntimeType::GetFieldCandidates(System.String,System.Reflection.BindingFlags,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	stloc:RuntimeFieldHandle(var_1_06, ldfld:RuntimeFieldHandle(RuntimeFieldInfo::fhandle, ldloc:class System.Reflection.RuntimeFieldInfo[][exp:RuntimeFieldInfo](var_0)))
	brtrue(IL_0000, ldfld:RuntimeFieldHandle[exp:bool](RuntimeFieldInfo::fhandle, ldloc:class System.Reflection.RuntimeFieldInfo[][exp:RuntimeFieldInfo](var_0)))
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

		// Token: 0x06000DA2 RID: 3490 RVA: 0x0001DBE8 File Offset: 0x0001BDE8
		private RuntimeType.ListBuilder<Type> GetNestedTypeCandidates(string fullname, BindingFlags bindingAttr, bool allowPrefixLookup)
		{
			/*
An exception occurred when decompiling this method (06000DA2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.RuntimeType/ListBuilder`1<System.Type> System.RuntimeType::GetNestedTypeCandidates(System.String,System.Reflection.BindingFlags,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:MonoTypeInfo(var_1_09, ldfld:MonoTypeInfo(RuntimeType::type_info, ldloc:class System.RuntimeType[][exp:RuntimeType](var_0)))
	brtrue(IL_0000, ldfld:MonoTypeInfo[exp:bool](RuntimeType::type_info, ldloc:class System.RuntimeType[][exp:RuntimeType](var_0)))
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

		// Token: 0x06000DA3 RID: 3491 RVA: 0x0001DC0C File Offset: 0x0001BE0C
		public override MethodInfo[] GetMethods(BindingFlags bindingAttr)
		{
			RuntimeType.ListBuilder<MethodInfo> listBuilder;
			return listBuilder.ToArray();
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x0001DC20 File Offset: 0x0001BE20
		[ComVisible(true)]
		public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr)
		{
			RuntimeType.ListBuilder<ConstructorInfo> listBuilder;
			return listBuilder.ToArray();
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x0001DC34 File Offset: 0x0001BE34
		public override PropertyInfo[] GetProperties(BindingFlags bindingAttr)
		{
			RuntimeType.ListBuilder<PropertyInfo> listBuilder;
			return listBuilder.ToArray();
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x0001DC48 File Offset: 0x0001BE48
		public override EventInfo[] GetEvents(BindingFlags bindingAttr)
		{
			RuntimeType.ListBuilder<EventInfo> listBuilder;
			return listBuilder.ToArray();
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x0001DC5C File Offset: 0x0001BE5C
		public override FieldInfo[] GetFields(BindingFlags bindingAttr)
		{
			RuntimeType.ListBuilder<FieldInfo> listBuilder;
			return listBuilder.ToArray();
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x0000207A File Offset: 0x0000027A
		protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x0000207A File Offset: 0x0000027A
		protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x0001DC70 File Offset: 0x0001BE70
		public override EventInfo GetEvent(string name, BindingFlags bindingAttr)
		{
			/*
An exception occurred when decompiling this method (06000DAA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Reflection.EventInfo System.RuntimeType::GetEvent(System.String,System.Reflection.BindingFlags)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:native int(var_1_09, ldfld:native int(RuntimeEventInfo::klass, ldloc:class System.Reflection.RuntimeEventInfo[][exp:RuntimeEventInfo](var_0)))
	stloc:string(var_8_1B, call:string(Environment::GetResourceString, ldstr:string("Ambiguous match found.")))
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

		// Token: 0x06000DAB RID: 3499 RVA: 0x0001DC9C File Offset: 0x0001BE9C
		public override FieldInfo GetField(string name, BindingFlags bindingAttr)
		{
			/*
An exception occurred when decompiling this method (06000DAB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Reflection.FieldInfo System.RuntimeType::GetField(System.String,System.Reflection.BindingFlags)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:RuntimeFieldHandle(var_1_09, ldfld:RuntimeFieldHandle(RuntimeFieldInfo::fhandle, ldloc:class System.Reflection.RuntimeFieldInfo[][exp:RuntimeFieldInfo](var_0)))
	stloc:string(var_12_18, call:string(Environment::GetResourceString, ldstr:string("Ambiguous match found.")))
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

		// Token: 0x06000DAC RID: 3500 RVA: 0x0001DCC8 File Offset: 0x0001BEC8
		public override Type GetNestedType(string fullname, BindingFlags bindingAttr)
		{
			/*
An exception occurred when decompiling this method (06000DAC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Type System.RuntimeType::GetNestedType(System.String,System.Reflection.BindingFlags)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001E:
	stloc:string(var_7_2B, call:string(Environment::GetResourceString, ldstr:string("Ambiguous match found.")))
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

		// Token: 0x06000DAD RID: 3501 RVA: 0x0001DD04 File Offset: 0x0001BF04
		public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr)
		{
			/*
An exception occurred when decompiling this method (06000DAD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Reflection.MemberInfo[] System.RuntimeType::GetMember(System.String,System.Reflection.MemberTypes,System.Reflection.BindingFlags)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_4_06, ldc.i4:int32(1))
	stloc:valuetype System.RuntimeType/ListBuilder`1<class System.Reflection.EventInfo>(var_5_12, call:ListBuilder`1[exp:valuetype System.RuntimeType/ListBuilder`1<class System.Reflection.EventInfo>](RuntimeType::GetEventCandidates, ldloc:RuntimeType(this), ldloc:string(name), ldloc:BindingFlags(bindingAttr), ldloc:int32[exp:bool](var_4_06)))
	stloc:int32(var_6_15, ldc.i4:int32(1))
	stloc:valuetype System.RuntimeType/ListBuilder`1<class System.Reflection.FieldInfo>(var_7_21, call:ListBuilder`1[exp:valuetype System.RuntimeType/ListBuilder`1<class System.Reflection.FieldInfo>](RuntimeType::GetFieldCandidates, ldloc:RuntimeType(this), ldloc:string(name), ldloc:BindingFlags(bindingAttr), ldloc:int32[exp:bool](var_6_15)))
	stloc:int32(var_8_24, ldc.i4:int32(1))
	stloc:class System.Type[](var_9_35, call:!0[][exp:class System.Type[]](ListBuilder`1::ToArray, call:ListBuilder`1[exp:valuetype System.RuntimeType/ListBuilder`1&](RuntimeType::GetNestedTypeCandidates, ldloc:RuntimeType(this), ldloc:string(name), ldloc:BindingFlags(bindingAttr), ldloc:int32[exp:bool](var_8_24))))
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

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000DAE RID: 3502 RVA: 0x0001DD48 File Offset: 0x0001BF48
		public override Module Module
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000DAE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Reflection.Module System.RuntimeType::get_Module()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:RuntimeModule(var_0_06, call:RuntimeModule(RuntimeTypeHandle::GetModule, ldloc:RuntimeType(this)))
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

		// Token: 0x06000DAF RID: 3503 RVA: 0x0001DD5C File Offset: 0x0001BF5C
		internal RuntimeModule GetRuntimeModule()
		{
			return RuntimeTypeHandle.GetModule(this);
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000DB0 RID: 3504 RVA: 0x0001DD70 File Offset: 0x0001BF70
		public override Assembly Assembly
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000DB0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Reflection.Assembly System.RuntimeType::get_Assembly()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:RuntimeAssembly(var_0_06, call:RuntimeAssembly(RuntimeTypeHandle::GetAssembly, ldloc:RuntimeType(this)))
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

		// Token: 0x06000DB1 RID: 3505 RVA: 0x0001DD84 File Offset: 0x0001BF84
		internal RuntimeAssembly GetRuntimeAssembly()
		{
			return RuntimeTypeHandle.GetAssembly(this);
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000DB2 RID: 3506 RVA: 0x0000207A File Offset: 0x0000027A
		public override RuntimeTypeHandle TypeHandle
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x0001DD98 File Offset: 0x0001BF98
		public override bool IsInstanceOfType(object o)
		{
			return RuntimeTypeHandle.IsInstanceOfType(this, o);
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x0001DDAC File Offset: 0x0001BFAC
		public override bool IsAssignableFrom(Type c)
		{
			if (c == null)
			{
				return;
			}
			if (c != null)
			{
			}
			long num = 0L;
			if (num != 0L)
			{
				bool flag;
				return flag;
			}
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x0001DDCC File Offset: 0x0001BFCC
		public override bool IsEquivalentTo(Type other)
		{
			if (other != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000DB6 RID: 3510 RVA: 0x0001DDE4 File Offset: 0x0001BFE4
		public override Type BaseType
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000DB6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Type System.RuntimeType::get_BaseType()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:RuntimeType(var_0_06, call:RuntimeType(RuntimeType::GetBaseType, ldloc:RuntimeType(this)))
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

		// Token: 0x06000DB7 RID: 3511 RVA: 0x0001DDF8 File Offset: 0x0001BFF8
		private RuntimeType GetBaseType()
		{
			bool isInterface = base.IsInterface;
			bool flag = RuntimeTypeHandle.IsGenericVariable(this);
			MonoTypeInfo monoTypeInfo = this.type_info;
			return RuntimeTypeHandle.GetBaseType(this);
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000DB8 RID: 3512 RVA: 0x0000207A File Offset: 0x0000027A
		public override Type UnderlyingSystemType
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x0001DE2C File Offset: 0x0001C02C
		protected override TypeAttributes GetAttributeFlagsImpl()
		{
			return RuntimeTypeHandle.GetAttributes(this);
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x0001DE40 File Offset: 0x0001C040
		protected override bool IsContextfulImpl()
		{
			return RuntimeTypeHandle.IsContextful(this);
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x0001DE54 File Offset: 0x0001C054
		protected override bool IsByRefImpl()
		{
			return RuntimeTypeHandle.IsByRef(this);
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x0001DE68 File Offset: 0x0001C068
		protected override bool IsPrimitiveImpl()
		{
			return RuntimeTypeHandle.IsPrimitive(this);
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x0001DE7C File Offset: 0x0001C07C
		protected override bool IsPointerImpl()
		{
			return RuntimeTypeHandle.IsPointer(this);
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x0001DE90 File Offset: 0x0001C090
		protected override bool IsCOMObjectImpl()
		{
			long num = 0L;
			return RuntimeTypeHandle.IsComObject(this, num != 0L);
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x0001DEA8 File Offset: 0x0001C0A8
		protected override bool IsValueTypeImpl()
		{
			/*
An exception occurred when decompiling this method (06000DBF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.RuntimeType::IsValueTypeImpl()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:bool(var_1_0A, call:bool(Type::op_Equality, ldloc:RuntimeType[exp:Type](this), ldloc:Type(var_0)))
	stloc:bool(var_3_12, call:bool(Type::op_Equality, ldloc:RuntimeType[exp:Type](this), ldloc:Type(var_2)))
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

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000DC0 RID: 3520 RVA: 0x0001DECC File Offset: 0x0001C0CC
		public override bool IsEnum
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000DC0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.RuntimeType::get_IsEnum()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:RuntimeType(var_0_06, call:RuntimeType(RuntimeType::GetBaseType, ldloc:RuntimeType(this)))
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

		// Token: 0x06000DC1 RID: 3521 RVA: 0x0001DEE0 File Offset: 0x0001C0E0
		protected override bool HasElementTypeImpl()
		{
			return RuntimeTypeHandle.HasElementType(this);
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000DC2 RID: 3522 RVA: 0x0001DEF4 File Offset: 0x0001C0F4
		public override GenericParameterAttributes GenericParameterAttributes
		{
			get
			{
				return this.GetGenericParameterAttributes();
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000DC3 RID: 3523 RVA: 0x0001DF14 File Offset: 0x0001C114
		internal override bool IsSzArray
		{
			get
			{
				return RuntimeTypeHandle.IsSzArray(this);
			}
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x0001DF28 File Offset: 0x0001C128
		protected override bool IsArrayImpl()
		{
			return RuntimeTypeHandle.IsArray(this);
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x0001DF3C File Offset: 0x0001C13C
		public override int GetArrayRank()
		{
			return RuntimeTypeHandle.GetArrayRank(this);
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x0001DF5C File Offset: 0x0001C15C
		public override Type GetElementType()
		{
			/*
An exception occurred when decompiling this method (06000DC6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Type System.RuntimeType::GetElementType()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:RuntimeType(var_0_06, call:RuntimeType(RuntimeTypeHandle::GetElementType, ldloc:RuntimeType(this)))
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

		// Token: 0x06000DC7 RID: 3527 RVA: 0x0001DF70 File Offset: 0x0001C170
		public override string[] GetEnumNames()
		{
			/*
An exception occurred when decompiling this method (06000DC7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String[] System.RuntimeType::GetEnumNames()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string[](var_0_06, call:string[](Enum::InternalGetNames, ldloc:RuntimeType(this)))
	stloc:string(var_1_11, call:string(Environment::GetResourceString, ldstr:string("Type provided must be an Enum.")))
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

		// Token: 0x06000DC8 RID: 3528 RVA: 0x0001DF90 File Offset: 0x0001C190
		public override Array GetEnumValues()
		{
			ulong[] array = Enum.InternalGetValues(this);
			long num = 0L;
			Array array2;
			object obj;
			array2.SetValue(obj, (int)num);
			return array2;
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x0001DFBC File Offset: 0x0001C1BC
		public override Type GetEnumUnderlyingType()
		{
			/*
An exception occurred when decompiling this method (06000DC9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Type System.RuntimeType::GetEnumUnderlyingType()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_0A, call:string(Environment::GetResourceString, ldstr:string("Type provided must be an Enum.")))
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

		// Token: 0x06000DCA RID: 3530 RVA: 0x0001DFD4 File Offset: 0x0001C1D4
		public override bool IsEnumDefined(object value)
		{
			if (value != null)
			{
				Type type = value.GetType();
				if (type != null)
				{
					throw new InvalidCastException();
				}
				bool flag = Type.IsIntegerType(type);
				ulong[] array = Enum.InternalGetValues(this);
				ulong num = Enum.ToUInt64(value);
			}
			string resourceString = Environment.GetResourceString("Unknown enum type.");
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x0001E050 File Offset: 0x0001C250
		public override string GetEnumName(object value)
		{
			Type type;
			bool flag = Type.IsIntegerType(type);
			ulong num = Enum.ToUInt64(Enum.InternalGetValues(this));
			return Enum.InternalGetNames(this);
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x0001E084 File Offset: 0x0001C284
		internal RuntimeType[] GetGenericArgumentsInternal()
		{
			if (this == null || this != null)
			{
				return this;
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x0001E0A0 File Offset: 0x0001C2A0
		public override Type[] GetGenericArguments()
		{
			/*
An exception occurred when decompiling this method (06000DCD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Type[] System.RuntimeType::GetGenericArguments()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldloc:RuntimeType[exp:bool](this))
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

		// Token: 0x06000DCE RID: 3534 RVA: 0x0001E0B0 File Offset: 0x0001C2B0
		public override Type MakeGenericType(params Type[] instantiation)
		{
			if (instantiation != null)
			{
				MonoTypeInfo monoTypeInfo = this.type_info;
				if (monoTypeInfo == null)
				{
				}
				long num = 0L;
				if (monoTypeInfo == null)
				{
				}
				RuntimeType[] genericArgumentsInternal;
				if (num != 0L)
				{
					if (num == 0L)
					{
						throw new ArrayTypeMismatchException();
					}
					genericArgumentsInternal = this.GetGenericArgumentsInternal();
				}
				return Type.MakeGenericSignatureType(this, genericArgumentsInternal);
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000DCF RID: 3535 RVA: 0x0001E130 File Offset: 0x0001C330
		public override bool IsGenericTypeDefinition
		{
			get
			{
				return RuntimeTypeHandle.IsGenericTypeDefinition(this);
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000DD0 RID: 3536 RVA: 0x0001E144 File Offset: 0x0001C344
		public override bool IsGenericParameter
		{
			get
			{
				return RuntimeTypeHandle.IsGenericVariable(this);
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000DD1 RID: 3537 RVA: 0x0001E158 File Offset: 0x0001C358
		public override int GenericParameterPosition
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000DD1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.RuntimeType::get_GenericParameterPosition()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_0A, call:string(Environment::GetResourceString, ldstr:string("Method may only be called on a Type for which Type.IsGenericParameter is true.")))
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

		// Token: 0x06000DD2 RID: 3538 RVA: 0x0001E170 File Offset: 0x0001C370
		public override Type GetGenericTypeDefinition()
		{
			return RuntimeTypeHandle.GetGenericTypeDefinition(this);
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000DD3 RID: 3539 RVA: 0x0001E190 File Offset: 0x0001C390
		public override bool IsGenericType
		{
			get
			{
				return RuntimeTypeHandle.HasInstantiation(this);
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000DD4 RID: 3540 RVA: 0x0000207A File Offset: 0x0000027A
		public override bool IsConstructedGenericType
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x0001E1A4 File Offset: 0x0001C3A4
		[DebuggerStepThrough]
		[DebuggerHidden]
		public override object InvokeMember(string name, BindingFlags bindingFlags, Binder binder, object target, object[] providedArgs, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParams)
		{
			int num;
			Binder defaultBinder;
			for (;;)
			{
				num = 28;
				if (providedArgs == null)
				{
					break;
				}
				if (providedArgs != null)
				{
				}
				if (binder == null)
				{
					goto IL_0045;
				}
				if (name == null)
				{
					goto IL_0138;
				}
				if (name._stringLength != 0)
				{
					bool flag = name.Equals("[DISPID=0]");
				}
				string defaultMemberName = this.GetDefaultMemberName();
				if (num != 0)
				{
					if (num != 0)
					{
						goto Block_5;
					}
					if (providedArgs == null)
					{
						goto IL_014A;
					}
					MonoTypeInfo monoTypeInfo = this.type_info;
					object genericCache = this.GenericCache;
					if (monoTypeInfo == null || num != 0)
					{
					}
					long num2 = 0L;
					if (defaultBinder == null)
					{
						goto IL_009C;
					}
					if (defaultBinder == null)
					{
						goto IL_0108;
					}
					if (defaultBinder == null)
					{
						goto IL_009C;
					}
				}
			}
			int num3;
			while (num3 == 0)
			{
			}
			return "Named parameter array cannot be bigger than argument array.";
			Block_5:
			if ("ToString" == null)
			{
				return "Cannot specify both GetField and SetProperty.";
			}
			return "Cannot specify both Get and Set on a field.";
			IL_0045:
			if ("ToString" == null)
			{
			}
			defaultBinder = Type.DefaultBinder;
			num3 = 15616;
			object obj;
			return obj;
			IL_009C:
			long value = 0.m_value;
			if (62208 != 0)
			{
				return "Cannot specify Set on a property and Invoke on a method.";
			}
			MonoTypeInfo monoTypeInfo2 = this.type_info;
			long num4 = 0L;
			if (providedArgs != null || providedArgs != null)
			{
			}
			if (num4 == 0L)
			{
				MonoTypeInfo monoTypeInfo3 = this.type_info;
			}
			if (num != 0)
			{
				long num2;
				if (num2 != 0L)
				{
					return "No arguments can be provided to Get a field value.";
				}
				if (this != null)
				{
				}
				if (num != 0)
				{
					object obj2;
					return obj2;
				}
			}
			else
			{
				if (!false)
				{
				}
				long num2;
				if (num2 == 0L)
				{
				}
				while (this == null)
				{
				}
			}
			throw new InvalidCastException();
			IL_0108:
			throw new InvalidCastException();
			IL_0138:
			return "name";
			IL_014A:
			return "Cannot specify both SetField and GetProperty.";
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x0000207A File Offset: 0x0000027A
		public override bool Equals(object obj)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x0000207A File Offset: 0x0000027A
		public static bool operator ==(RuntimeType left, RuntimeType right)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x0000207A File Offset: 0x0000027A
		public static bool operator !=(RuntimeType left, RuntimeType right)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x0000207A File Offset: 0x0000027A
		public object Clone()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x0001E33C File Offset: 0x0001C53C
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			while (info == null)
			{
			}
			UnitySerializationHolder.GetUnitySerializationInfo(info, this);
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x0001E354 File Offset: 0x0001C554
		public override object[] GetCustomAttributes(bool inherit)
		{
			if (!true)
			{
			}
			object[] array;
			return array;
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x0001E368 File Offset: 0x0001C568
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			/*
An exception occurred when decompiling this method (06000DDC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object[] System.RuntimeType::GetCustomAttributes(System.Type,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000B:
	stloc:string(var_1_15, call:string(Environment::GetResourceString, ldstr:string("Type must be a type provided by the runtime.")))
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

		// Token: 0x06000DDD RID: 3549 RVA: 0x0001E38C File Offset: 0x0001C58C
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			/*
An exception occurred when decompiling this method (06000DDD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.RuntimeType::IsDefined(System.Type,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000B:
	stloc:string(var_1_15, call:string(Environment::GetResourceString, ldstr:string("Type must be a type provided by the runtime.")))
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

		// Token: 0x06000DDE RID: 3550 RVA: 0x0001E3B0 File Offset: 0x0001C5B0
		internal override string FormatTypeName(bool serialization)
		{
			return "System.";
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000DDF RID: 3551 RVA: 0x0001E3F0 File Offset: 0x0001C5F0
		public override MemberTypes MemberType
		{
			get
			{
				bool isPublic = base.IsPublic;
				return MemberTypes.TypeInfo;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000DE0 RID: 3552 RVA: 0x0000207A File Offset: 0x0000027A
		public override Type ReflectedType
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000DE1 RID: 3553 RVA: 0x0001E410 File Offset: 0x0001C610
		public override int MetadataToken
		{
			get
			{
				return RuntimeTypeHandle.GetToken(this);
			}
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x0001E424 File Offset: 0x0001C624
		private void CreateInstanceCheckThis()
		{
			Type rootElementType = base.GetRootElementType();
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x0001E45C File Offset: 0x0001C65C
		internal object CreateInstanceImpl(BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, StackCrawlMark stackMark)
		{
			this.CreateInstanceCheckThis();
			if (args == null)
			{
			}
			if (binder == null)
			{
				Binder defaultBinder = Type.DefaultBinder;
			}
			bool isValueType = base.IsValueType;
			object obj;
			return obj;
		}

		// Token: 0x06000DE4 RID: 3556 RVA: 0x0001E4F8 File Offset: 0x0001C6F8
		[DebuggerStepThrough]
		[DebuggerHidden]
		internal object CreateInstanceDefaultCtor(bool publicOnly, bool skipCheckThis, bool fillCache, bool wrapExceptions, StackCrawlMark stackMark)
		{
			Type type;
			bool flag = base.GetType() == type;
			this.CreateInstanceCheckThis();
			object obj;
			return obj;
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x0001E524 File Offset: 0x0001C724
		internal RuntimeConstructorInfo GetDefaultConstructor()
		{
			MonoTypeInfo monoTypeInfo = this.type_info;
			if (monoTypeInfo != null)
			{
				RuntimeConstructorInfo default_ctor = monoTypeInfo.default_ctor;
			}
			long num = 0L;
			MonoTypeInfo monoTypeInfo2 = this.type_info;
			if (this != null)
			{
			}
			MonoTypeInfo monoTypeInfo3 = this.type_info;
			if (num != 0L)
			{
			}
			monoTypeInfo3.default_ctor = num;
			throw new InvalidCastException();
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x0001E56C File Offset: 0x0001C76C
		private string GetDefaultMemberName()
		{
			if (!true)
			{
			}
			if (this.type_info == null || this.GenericCache != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x0001E594 File Offset: 0x0001C794
		internal RuntimeConstructorInfo GetSerializationCtor()
		{
			if (!true)
			{
			}
			Type type;
			Type type2;
			ConstructorInfo constructorInfo;
			if ((type != null && type == null) || (type2 != null && type2 == null) || constructorInfo != null)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x0001E5C0 File Offset: 0x0001C7C0
		internal object CreateInstanceSlow(bool publicOnly, bool wrapExceptions, bool skipCheckThis, bool fillCache)
		{
			this.CreateInstanceCheckThis();
			return this.CreateInstanceMono(publicOnly, wrapExceptions);
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x0001E5DC File Offset: 0x0001C7DC
		private object CreateInstanceMono(bool nonPublic, bool wrapExceptions)
		{
			if (!true)
			{
			}
			RuntimeConstructorInfo runtimeConstructorInfo;
			bool isPublic = runtimeConstructorInfo.IsPublic;
			if (!true)
			{
			}
			Type rootElementType = base.GetRootElementType();
			bool isValueType = base.IsValueType;
			bool isAbstract = base.IsAbstract;
			object obj;
			return obj;
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x0001E62C File Offset: 0x0001C82C
		internal object CheckValue(object value, Binder binder, CultureInfo culture, BindingFlags invokeAttr)
		{
			/*
An exception occurred when decompiling this method (06000DEA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.RuntimeType::CheckValue(System.Object,System.Reflection.Binder,System.Globalization.CultureInfo,System.Reflection.BindingFlags)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000E:
	stloc:CultureInfo(var_4_15, callgetter:CultureInfo(CultureInfo::get_CurrentUICulture))
	stloc:string(var_5_21, call:string(Environment::GetResourceString, ldstr:string("Object of type '{0}' cannot be converted to type '{1}'.")))
	stloc:Type(var_6_29, call:Type(object::GetType, ldloc:object(value)))
	stloc:string(var_7_37, call:string(string::Format, ldloc:CultureInfo[exp:IFormatProvider](var_4_15), ldloc:string(var_5_21), ldloc:Type[exp:object](var_6_29), ldloc:RuntimeType[exp:object](this)))
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

		// Token: 0x06000DEB RID: 3563 RVA: 0x0001E674 File Offset: 0x0001C874
		private object TryConvertToType(object value, bool failed)
		{
			return value;
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x0001E6EC File Offset: 0x0001C8EC
		private static object IsConvertibleToPrimitiveType(object value, Type targetType)
		{
			Type type;
			TypeCode typeCode = Type.GetTypeCode(Enum.GetUnderlyingType(type));
			throw new InvalidCastException();
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x0000207A File Offset: 0x0000027A
		private string GetCachedName(TypeNameKind kind)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x0000207A File Offset: 0x0000027A
		private Type make_array_type(int rank)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x0000207A File Offset: 0x0000027A
		public override Type MakeArrayType()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x0000207A File Offset: 0x0000027A
		public override Type MakeArrayType(int rank)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x0000207A File Offset: 0x0000027A
		private Type make_byref_type()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x0001E710 File Offset: 0x0001C910
		public override Type MakeByRefType()
		{
			/*
An exception occurred when decompiling this method (06000DF2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Type System.RuntimeType::MakeByRefType()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_06, callgetter:bool(Type::get_IsByRef, ldloc:RuntimeType[exp:Type](this)))
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

		// Token: 0x06000DF3 RID: 3571 RVA: 0x0000207A File Offset: 0x0000027A
		private static Type MakePointerType(Type type)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x0001E724 File Offset: 0x0001C924
		public override Type MakePointerType()
		{
			/*
An exception occurred when decompiling this method (06000DF4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Type System.RuntimeType::MakePointerType()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_06, callgetter:bool(Type::get_IsByRef, ldloc:RuntimeType[exp:Type](this)))
	stloc:Type(var_1_0D, call:Type(Type::GetType, ldloc:RuntimeType[exp:Type](this)))
	stloc:string(var_2_1A, call:string(string::Format, ldstr:string("Could not load type '{0}' from assembly '{1}"), ldloc:Type[exp:object](var_1_0D), ldloc:RuntimeType[exp:object](this)))
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

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000DF5 RID: 3573 RVA: 0x0001E74C File Offset: 0x0001C94C
		public override bool ContainsGenericParameters
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000DF5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.RuntimeType::get_ContainsGenericParameters()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:MonoTypeInfo(var_1_08, ldfld:MonoTypeInfo(RuntimeType::type_info, ldloc:RuntimeType(this)))
	stloc:bool(var_3_11, callgetter:bool(Type::get_HasElementType, ldloc:RuntimeType[exp:Type](this)))
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

		// Token: 0x06000DF6 RID: 3574 RVA: 0x0001E770 File Offset: 0x0001C970
		public override Type[] GetGenericParameterConstraints()
		{
			/*
An exception occurred when decompiling this method (06000DF6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Type[] System.RuntimeType::GetGenericParameterConstraints()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000A:
	stloc:string(var_2_14, call:string(Environment::GetResourceString, ldstr:string("Method may only be called on a Type for which Type.IsGenericParameter is true.")))
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

		// Token: 0x06000DF7 RID: 3575 RVA: 0x0001E794 File Offset: 0x0001C994
		internal static object CreateInstanceForAnotherGenericParameter(Type genericType, RuntimeType genericArgument)
		{
			if (genericType == null || genericType != null)
			{
				object obj;
				return obj;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x0000207A File Offset: 0x0000027A
		private static Type MakeGenericType(Type gt, Type[] types)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x0000207A File Offset: 0x0000027A
		internal IntPtr GetMethodsByName_native(IntPtr namePtr, BindingFlags bindingAttr, RuntimeType.MemberListType listType)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x0001E7B8 File Offset: 0x0001C9B8
		internal RuntimeMethodInfo[] GetMethodsByName(string name, BindingFlags bindingAttr, RuntimeType.MemberListType listType, RuntimeType reflectedType)
		{
			MethodBase methodBase;
			if (methodBase != null && methodBase == null)
			{
				throw new ArrayTypeMismatchException();
			}
			if (!false)
			{
				throw new InvalidCastException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x0000207A File Offset: 0x0000027A
		private IntPtr GetPropertiesByName_native(IntPtr name, BindingFlags bindingAttr, RuntimeType.MemberListType listType)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x0000207A File Offset: 0x0000027A
		private IntPtr GetConstructors_native(BindingFlags bindingAttr)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x0001E808 File Offset: 0x0001CA08
		private RuntimeConstructorInfo[] GetConstructors_internal(BindingFlags bindingAttr, RuntimeType reflectedType)
		{
			MethodBase methodBase;
			if (methodBase == null || methodBase != null)
			{
				throw new InvalidCastException();
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x0001E840 File Offset: 0x0001CA40
		private RuntimePropertyInfo[] GetPropertiesByName(string name, BindingFlags bindingAttr, RuntimeType.MemberListType listType, RuntimeType reflectedType)
		{
			PropertyInfo propertyInfo;
			if (propertyInfo != null && propertyInfo == null)
			{
				throw new ArrayTypeMismatchException();
			}
			if (!false)
			{
				throw new InvalidCastException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x0001E890 File Offset: 0x0001CA90
		protected override TypeCode GetTypeCodeImpl()
		{
			/*
An exception occurred when decompiling this method (06000DFF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.TypeCode System.RuntimeType::GetTypeCodeImpl()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
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

		// Token: 0x06000E00 RID: 3584 RVA: 0x0000207A File Offset: 0x0000027A
		private static TypeCode GetTypeCodeImplInternal(Type type)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x0000207A File Offset: 0x0000027A
		public override string ToString()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x0001E8A0 File Offset: 0x0001CAA0
		private bool IsGenericCOMObjectImpl()
		{
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x0000207A File Offset: 0x0000027A
		private static object CreateInstanceInternal(Type type)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000E04 RID: 3588 RVA: 0x0000207A File Offset: 0x0000027A
		public override MethodBase DeclaringMethod
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x0000207A File Offset: 0x0000027A
		internal string getFullName(bool full_name, bool assembly_qualified)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x0000207A File Offset: 0x0000027A
		private Type[] GetGenericArgumentsInternal(bool runtimeArray)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x0001E8B0 File Offset: 0x0001CAB0
		private GenericParameterAttributes GetGenericParameterAttributes()
		{
			IntPtr genericParameterInfo = RuntimeTypeHandle.GetGenericParameterInfo(this);
			GenericParameterAttributes genericParameterAttributes;
			return genericParameterAttributes;
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x0000207A File Offset: 0x0000027A
		private int GetGenericParameterPosition()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x0000207A File Offset: 0x0000027A
		private IntPtr GetEvents_native(IntPtr name, RuntimeType.MemberListType listType)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x0000207A File Offset: 0x0000027A
		private IntPtr GetFields_native(IntPtr name, BindingFlags bindingAttr, RuntimeType.MemberListType listType)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x0001E8C8 File Offset: 0x0001CAC8
		private RuntimeFieldInfo[] GetFields_internal(string name, BindingFlags bindingAttr, RuntimeType.MemberListType listType, RuntimeType reflectedType)
		{
			FieldInfo fieldInfo;
			if (fieldInfo != null && fieldInfo == null)
			{
				throw new ArrayTypeMismatchException();
			}
			if (!false)
			{
				throw new InvalidCastException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x0001E918 File Offset: 0x0001CB18
		private RuntimeEventInfo[] GetEvents_internal(string name, BindingFlags bindingAttr, RuntimeType.MemberListType listType, RuntimeType reflectedType)
		{
			EventInfo eventInfo;
			if (eventInfo != null && eventInfo == null)
			{
				throw new ArrayTypeMismatchException();
			}
			if (!false)
			{
				throw new InvalidCastException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x0000207A File Offset: 0x0000027A
		public override Type[] GetInterfaces()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x0000207A File Offset: 0x0000027A
		private IntPtr GetNestedTypes_native(IntPtr name, BindingFlags bindingAttr, RuntimeType.MemberListType listType)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x0001E968 File Offset: 0x0001CB68
		private RuntimeType[] GetNestedTypes_internal(string displayName, BindingFlags bindingAttr, RuntimeType.MemberListType listType)
		{
			if (displayName != null)
			{
				TypeIdentifier typeIdentifier = TypeIdentifiers.FromDisplay(displayName);
			}
			Type type;
			if (type != null && type == null)
			{
				throw new ArrayTypeMismatchException();
			}
			if (!false)
			{
				throw new InvalidCastException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000E10 RID: 3600 RVA: 0x0000207A File Offset: 0x0000027A
		public override string AssemblyQualifiedName
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000E11 RID: 3601 RVA: 0x0000207A File Offset: 0x0000027A
		public override Type DeclaringType
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000E12 RID: 3602 RVA: 0x0000207A File Offset: 0x0000027A
		public override string Name
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000E13 RID: 3603 RVA: 0x0000207A File Offset: 0x0000027A
		public override string Namespace
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x0001E9C4 File Offset: 0x0001CBC4
		public override int GetHashCode()
		{
			bool flag = this != this;
			RuntimeTypeHandle impl = this._impl;
			int num;
			return num;
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000E15 RID: 3605 RVA: 0x0001E9E4 File Offset: 0x0001CBE4
		public override string FullName
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000E15)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.RuntimeType::get_FullName()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	stloc:Type(var_0_06, call:Type(Type::GetRootElementType, ldloc:RuntimeType[exp:Type](this)))
	brtrue(IL_0000, ldfld:MonoTypeInfo[exp:bool](RuntimeType::type_info, ldloc:RuntimeType(this)))
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
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000E16 RID: 3606 RVA: 0x0001EA00 File Offset: 0x0001CC00
		public override bool IsSZArray
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000E16)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.RuntimeType::get_IsSZArray()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_06, callgetter:bool(Type::get_IsArray, ldloc:RuntimeType[exp:Type](this)))
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

		// Token: 0x06000E17 RID: 3607 RVA: 0x0001EA18 File Offset: 0x0001CC18
		[ComVisible(true)]
		public override bool IsSubclassOf(Type type)
		{
			while (type == null)
			{
			}
			long num = 0L;
			if (num != 0L)
			{
				bool flag;
				return flag;
			}
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x0001EA34 File Offset: 0x0001CC34
		protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConv, Type[] types, ParameterModifier[] modifiers)
		{
			MethodInfo methodInfo;
			return methodInfo;
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x0000207A File Offset: 0x0000027A
		private MethodInfo GetMethodImplCommon(string name, int genericParameterCount, BindingFlags bindingAttr, Binder binder, CallingConventions callConv, Type[] types, ParameterModifier[] modifiers)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x0001EA44 File Offset: 0x0001CC44
		private RuntimeType.ListBuilder<MethodInfo> GetMethodCandidates(string name, int genericParameterCount, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, bool allowPrefixLookup)
		{
			/*
An exception occurred when decompiling this method (06000E1A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.RuntimeType/ListBuilder`1<System.Reflection.MethodInfo> System.RuntimeType::GetMethodCandidates(System.String,System.Int32,System.Reflection.BindingFlags,System.Reflection.CallingConventions,System.Type[],System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:string(var_1_09, ldfld:string(RuntimeMethodInfo::name, ldloc:class System.Reflection.RuntimeMethodInfo[][exp:RuntimeMethodInfo](var_0)))
	stloc:string(var_2_10, ldfld:string(RuntimeMethodInfo::name, ldloc:class System.Reflection.RuntimeMethodInfo[][exp:RuntimeMethodInfo](var_0)))
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

		// Token: 0x06000E1B RID: 3611 RVA: 0x0001EA64 File Offset: 0x0001CC64
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeType()
		{
			if (!true)
			{
			}
			Type type;
			if (type != null)
			{
				return;
			}
			Type type2;
			if (type2 != null)
			{
				return;
			}
			Type type3;
			if (type3 != null)
			{
				return;
			}
			Type type4;
			if (type4 != null)
			{
				return;
			}
			Type type5;
			if (type5 != null)
			{
				return;
			}
			Type type6;
			if (type6 != null)
			{
				throw new InvalidCastException();
			}
		}

		// Token: 0x0400054A RID: 1354
		internal static readonly RuntimeType ValueType;

		// Token: 0x0400054B RID: 1355
		internal static readonly RuntimeType EnumType;

		// Token: 0x0400054C RID: 1356
		private static readonly RuntimeType ObjectType;

		// Token: 0x0400054D RID: 1357
		private static readonly RuntimeType StringType;

		// Token: 0x0400054E RID: 1358
		private static readonly RuntimeType DelegateType;

		// Token: 0x0400054F RID: 1359
		private static Type[] s_SICtorParamTypes;

		// Token: 0x04000550 RID: 1360
		internal static Func<Type, Type[], Type> MakeTypeBuilderInstantiation;

		// Token: 0x04000551 RID: 1361
		private const BindingFlags MemberBindingMask = (BindingFlags)255;

		// Token: 0x04000552 RID: 1362
		private const BindingFlags InvocationMask = BindingFlags.InvokeMethod | BindingFlags.CreateInstance | BindingFlags.GetField | BindingFlags.SetField | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.PutDispProperty | BindingFlags.PutRefDispProperty;

		// Token: 0x04000553 RID: 1363
		private const BindingFlags BinderNonCreateInstance = BindingFlags.InvokeMethod | BindingFlags.GetField | BindingFlags.SetField | BindingFlags.GetProperty | BindingFlags.SetProperty;

		// Token: 0x04000554 RID: 1364
		private const BindingFlags BinderGetSetProperty = BindingFlags.GetProperty | BindingFlags.SetProperty;

		// Token: 0x04000555 RID: 1365
		private const BindingFlags BinderSetInvokeProperty = BindingFlags.InvokeMethod | BindingFlags.SetProperty;

		// Token: 0x04000556 RID: 1366
		private const BindingFlags BinderGetSetField = BindingFlags.GetField | BindingFlags.SetField;

		// Token: 0x04000557 RID: 1367
		private const BindingFlags BinderSetInvokeField = BindingFlags.InvokeMethod | BindingFlags.SetField;

		// Token: 0x04000558 RID: 1368
		private const BindingFlags BinderNonFieldGetSet = (BindingFlags)16773888;

		// Token: 0x04000559 RID: 1369
		private const BindingFlags ClassicBindingMask = BindingFlags.InvokeMethod | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.PutDispProperty | BindingFlags.PutRefDispProperty;

		// Token: 0x0400055A RID: 1370
		private static RuntimeType s_typedRef;

		// Token: 0x0400055B RID: 1371
		[NonSerialized]
		private MonoTypeInfo type_info;

		// Token: 0x0400055C RID: 1372
		internal object GenericCache;

		// Token: 0x0400055D RID: 1373
		private RuntimeConstructorInfo m_serializationCtor;

		// Token: 0x0400055E RID: 1374
		private const int GenericParameterCountAny = -1;

		// Token: 0x02000159 RID: 345
		internal enum MemberListType
		{
			// Token: 0x04000560 RID: 1376
			All,
			// Token: 0x04000561 RID: 1377
			CaseSensitive,
			// Token: 0x04000562 RID: 1378
			CaseInsensitive,
			// Token: 0x04000563 RID: 1379
			HandleToInfo
		}

		// Token: 0x0200015A RID: 346
		private struct ListBuilder<T> where T : class
		{
			// Token: 0x06000E1C RID: 3612 RVA: 0x0001EA98 File Offset: 0x0001CC98
			public ListBuilder(int capacity)
			{
			}

			// Token: 0x1700013D RID: 317
			public T this[int index]
			{
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x06000E1E RID: 3614 RVA: 0x0001EAA8 File Offset: 0x0001CCA8
			public T[] ToArray()
			{
				while (this._count != 0)
				{
				}
				return this._item;
			}

			// Token: 0x06000E1F RID: 3615 RVA: 0x0001EAD4 File Offset: 0x0001CCD4
			public void CopyTo(object[] array, int index)
			{
				if (this._count != 0)
				{
					T item = this._item;
					if (item != null && item == null)
					{
						throw new ArrayTypeMismatchException();
					}
				}
			}

			// Token: 0x1700013E RID: 318
			// (get) Token: 0x06000E20 RID: 3616 RVA: 0x0001EB00 File Offset: 0x0001CD00
			public int Count
			{
				get
				{
					return this._count;
				}
			}

			// Token: 0x06000E21 RID: 3617 RVA: 0x0001EB14 File Offset: 0x0001CD14
			public void Add(T item)
			{
				if (this._count != 0)
				{
					int capacity = this._capacity;
					int num = 4;
					this._capacity = num;
					T item2 = this._item;
					this._items = ref this;
					return;
				}
				this._item = item;
			}

			// Token: 0x04000564 RID: 1380
			private T[] _items;

			// Token: 0x04000565 RID: 1381
			private T _item;

			// Token: 0x04000566 RID: 1382
			private int _count;

			// Token: 0x04000567 RID: 1383
			private int _capacity;
		}
	}
}
