using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000070 RID: 112
	[Preserve]
	internal static class ReflectionUtils
	{
		// Token: 0x060003ED RID: 1005 RVA: 0x0000AF38 File Offset: 0x00009138
		static ReflectionUtils()
		{
			if (!true)
			{
			}
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0000AF48 File Offset: 0x00009148
		public static bool IsVirtual(this PropertyInfo propertyInfo)
		{
			ValidationUtils.ArgumentNotNull("propertyInfo", "propertyInfo");
			MethodInfo methodInfo;
			if (methodInfo != null)
			{
				bool isVirtual = methodInfo.IsVirtual;
			}
			MethodInfo methodInfo2;
			if (methodInfo2 != null)
			{
				bool isVirtual2 = methodInfo2.IsVirtual;
				return true;
			}
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x0000AF7C File Offset: 0x0000917C
		public static MethodInfo GetBaseDefinition(this PropertyInfo propertyInfo)
		{
			ValidationUtils.ArgumentNotNull("propertyInfo", "propertyInfo");
			MethodInfo methodInfo;
			MethodInfo methodInfo2;
			if (methodInfo != null || methodInfo2 != null)
			{
				return methodInfo2;
			}
			return methodInfo2;
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x0000AFA4 File Offset: 0x000091A4
		public static bool IsPublic(PropertyInfo property)
		{
			MethodInfo methodInfo;
			if (methodInfo != null)
			{
				MethodInfo methodInfo2;
				bool isPublic = methodInfo2.IsPublic;
			}
			MethodInfo methodInfo3;
			if (methodInfo3 != null)
			{
				MethodInfo methodInfo4;
				bool isPublic2 = methodInfo4.IsPublic;
				return true;
			}
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x0000AFCC File Offset: 0x000091CC
		public static Type GetObjectType(object v)
		{
			Type type;
			return type;
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x0000AFDC File Offset: 0x000091DC
		public static string GetTypeName(Type t, FormatterAssemblyStyle assemblyFormat, SerializationBinder binder)
		{
			while (t != null)
			{
			}
			string text;
			return text;
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x0000AFF0 File Offset: 0x000091F0
		private static string RemoveAssemblyDetails(string fullyQualifiedTypeName)
		{
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x0000B008 File Offset: 0x00009208
		public static bool HasDefaultConstructor(Type t, bool nonPublic)
		{
			ValidationUtils.ArgumentNotNull("t", "t");
			return true;
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x0000B028 File Offset: 0x00009228
		public static ConstructorInfo GetDefaultConstructor(Type t)
		{
			if (!true)
			{
			}
			ConstructorInfo constructorInfo;
			return constructorInfo;
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x0000B03C File Offset: 0x0000923C
		public static ConstructorInfo GetDefaultConstructor(Type t, bool nonPublic)
		{
			if (t == null)
			{
			}
			ConstructorInfo constructorInfo;
			return constructorInfo;
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x0000B050 File Offset: 0x00009250
		public static bool IsNullable(Type t)
		{
			ValidationUtils.ArgumentNotNull("t", "t");
			bool flag;
			return flag;
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0000B070 File Offset: 0x00009270
		public static bool IsNullableType(Type t)
		{
			/*
An exception occurred when decompiling this method (060003F8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Newtonsoft.Json.Utilities.ReflectionUtils::IsNullableType(System.Type)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(ValidationUtils::ArgumentNotNull, ldstr:string[exp:object]("t"), ldstr:string("t"))
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

		// Token: 0x060003F9 RID: 1017 RVA: 0x0000B090 File Offset: 0x00009290
		public static Type EnsureNotNullableType(Type t)
		{
			if (!true)
			{
			}
			Type type;
			return type;
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x0000B0A4 File Offset: 0x000092A4
		public static bool IsGenericDefinition(Type type, Type genericInterfaceDefinition)
		{
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x0000B0B4 File Offset: 0x000092B4
		public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0000B0C8 File Offset: 0x000092C8
		public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition, [Out] Type implementingType)
		{
			/*
An exception occurred when decompiling this method (060003FC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Newtonsoft.Json.Utilities.ReflectionUtils::ImplementsGenericDefinition(System.Type,System.Type,System.Type)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(ValidationUtils::ArgumentNotNull, ldstr:string[exp:object]("genericInterfaceDefinition"), ldstr:string("type"))
	call:void(ValidationUtils::ArgumentNotNull, ldloc:Type[exp:object](type), ldstr:string("type"))
	stloc:bool(var_0_20, callgetter:bool(Type::get_IsInterface, ldloc:Type(type)))
	stloc:bool(var_1_27, callgetter:bool(Type::get_IsInterface, ldloc:Type(type)))
	stloc:CultureInfo(var_7_3A, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
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

		// Token: 0x060003FD RID: 1021 RVA: 0x0000B110 File Offset: 0x00009310
		public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x0000B124 File Offset: 0x00009324
		public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition, [Out] Type implementingType)
		{
			ValidationUtils.ArgumentNotNull("genericClassDefinition", "type");
			ValidationUtils.ArgumentNotNull(type, "genericClassDefinition");
			bool isClass = type.IsClass;
			bool flag;
			return flag;
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x0000B16C File Offset: 0x0000936C
		private static bool InheritsGenericDefinitionInternal(Type currentType, Type genericClassDefinition, [Out] Type implementingType)
		{
			return true;
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x0000B17C File Offset: 0x0000937C
		public static Type GetCollectionItemType(Type type)
		{
			ValidationUtils.ArgumentNotNull("type", "type");
			Type type2;
			return type2;
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x0000B1A8 File Offset: 0x000093A8
		public static void GetDictionaryKeyValueTypes(Type dictionaryType, [Out] Type keyType, [Out] Type valueType)
		{
			ValidationUtils.ArgumentNotNull(dictionaryType, "dictionaryType");
			if (!true)
			{
			}
			Type type;
			bool flag = ReflectionUtils.ImplementsGenericDefinition(dictionaryType, type, valueType);
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x0000B1E8 File Offset: 0x000093E8
		public static Type GetMemberUnderlyingType(MemberInfo member)
		{
			ValidationUtils.ArgumentNotNull("member", "member");
			return "member";
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x0000B224 File Offset: 0x00009424
		public static bool IsIndexedProperty(MemberInfo member)
		{
			ValidationUtils.ArgumentNotNull("member", "member");
			bool flag;
			return flag;
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x0000B244 File Offset: 0x00009444
		public static bool IsIndexedProperty(PropertyInfo property)
		{
			ValidationUtils.ArgumentNotNull("property", "property");
			return "property" != null;
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x0000B268 File Offset: 0x00009468
		public static object GetMemberValue(MemberInfo member, object target)
		{
			ValidationUtils.ArgumentNotNull("member", "member");
			ValidationUtils.ArgumentNotNull(member, "target");
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			CultureInfo invariantCulture2 = CultureInfo.InvariantCulture;
			string text = "MemberInfo '{0}' is not of type FieldInfo or PropertyInfo".FormatWith(invariantCulture, invariantCulture2, invariantCulture2);
			throw new InvalidCastException();
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x0000B2D8 File Offset: 0x000094D8
		public static void SetMemberValue(MemberInfo member, object target, object value)
		{
			ValidationUtils.ArgumentNotNull(member, "member");
			ValidationUtils.ArgumentNotNull(target, "target");
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x0000B318 File Offset: 0x00009518
		public static bool CanReadMemberValue(MemberInfo member, bool nonPublic)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x0000B334 File Offset: 0x00009534
		public static bool CanSetMemberValue(MemberInfo member, bool nonPublic, bool canSetReadOnly)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x0000B350 File Offset: 0x00009550
		public static List<MemberInfo> GetFieldsAndProperties(Type type, BindingFlags bindingAttr)
		{
			if (10 == 0)
			{
			}
			if (!false)
			{
				return "Item";
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x0000B394 File Offset: 0x00009594
		private static bool IsOverridenGenericMember(MemberInfo memberInfo, BindingFlags bindingAttr)
		{
			if (!true)
			{
			}
			bool flag;
			if (flag)
			{
				Type memberUnderlyingType = ReflectionUtils.GetMemberUnderlyingType(memberInfo);
			}
			throw new InvalidCastException();
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x0000B3B8 File Offset: 0x000095B8
		public static T GetAttribute<T>(object cpp2il__autoParamName__idx_1) where T : Attribute
		{
			/*
An exception occurred when decompiling this method (0600040B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling T Newtonsoft.Json.Utilities.ReflectionUtils::GetAttribute<T>(System.Object)

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

		// Token: 0x0600040C RID: 1036 RVA: 0x0000B3C8 File Offset: 0x000095C8
		public static T GetAttribute<T>(object attributeProvider, bool inherit) where T : Attribute
		{
			/*
An exception occurred when decompiling this method (0600040C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling T Newtonsoft.Json.Utilities.ReflectionUtils::GetAttribute<T>(System.Object,System.Boolean)

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

		// Token: 0x0600040D RID: 1037 RVA: 0x0000B3D8 File Offset: 0x000095D8
		public static T[] GetAttributes<T>(object attributeProvider, bool inherit) where T : Attribute
		{
			/*
An exception occurred when decompiling this method (0600040D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling T[] Newtonsoft.Json.Utilities.ReflectionUtils::GetAttributes<T>(System.Object,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldloc:class [mscorlib]System.Attribute[][exp:bool](var_1)))
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

		// Token: 0x0600040E RID: 1038 RVA: 0x0000B3E8 File Offset: 0x000095E8
		public static Attribute[] GetAttributes(object attributeProvider, Type attributeType, bool inherit)
		{
			ValidationUtils.ArgumentNotNull("attributeProvider", "attributeProvider");
			if ("attributeProvider" == null)
			{
				throw new InvalidCastException();
			}
			if (attributeProvider != null)
			{
			}
			long num;
			long value = num.m_value;
			if (attributeProvider != null)
			{
				if (attributeProvider != null)
				{
					Attribute[] array;
					return array;
				}
				Attribute[] array2;
				return array2;
			}
			else
			{
				Attribute[] array3;
				if (array3 != null)
				{
					return array3;
				}
				return array3;
			}
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x0000B450 File Offset: 0x00009650
		public static void SplitFullyQualifiedTypeName(string fullyQualifiedTypeName, [Out] string typeName, [Out] string assemblyName)
		{
			if (!true)
			{
			}
			int? assemblyDelimiterIndex = ReflectionUtils.GetAssemblyDelimiterIndex(fullyQualifiedTypeName);
			long num = 0L;
			string text = fullyQualifiedTypeName.Substring((int)num, 43159552);
			long num2 = 0L;
			string text2 = text.Trim();
			int stringLength = fullyQualifiedTypeName._stringLength;
			string text3 = fullyQualifiedTypeName.Substring((int)num2, 43159552).Trim();
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x0000B4A0 File Offset: 0x000096A0
		private static int? GetAssemblyDelimiterIndex(string fullyQualifiedTypeName)
		{
			for (;;)
			{
				long num = 0L;
				if (num != 0L)
				{
					return;
				}
			}
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x0000B4B8 File Offset: 0x000096B8
		public static MemberInfo GetMemberInfoFromType(Type targetType, MemberInfo memberInfo)
		{
			MemberInfo memberInfo2;
			return memberInfo2;
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x0000212A File Offset: 0x0000032A
		public static IEnumerable<FieldInfo> GetFields(Type targetType, BindingFlags bindingAttr)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x0000B4CC File Offset: 0x000096CC
		private static void GetChildPrivateFields(IList<MemberInfo> initialFields, Type targetType, BindingFlags bindingAttr)
		{
			if (targetType != null)
			{
				while (targetType != null)
				{
				}
			}
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x0000B4E0 File Offset: 0x000096E0
		public static IEnumerable<PropertyInfo> GetProperties(Type targetType, BindingFlags bindingAttr)
		{
			ValidationUtils.ArgumentNotNull("targetType", "targetType");
			MemberInfo memberInfo;
			if (memberInfo != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x0000212A File Offset: 0x0000032A
		public static BindingFlags RemoveFlag(this BindingFlags bindingAttr, BindingFlags flag)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x0000B508 File Offset: 0x00009708
		private static void GetChildPrivateProperties(IList<PropertyInfo> initialProperties, Type targetType, BindingFlags bindingAttr)
		{
			if (targetType != null)
			{
				return;
			}
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x0000B524 File Offset: 0x00009724
		public static bool IsMethodOverridden(Type currentType, Type methodDeclaringType, string method)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x0000B534 File Offset: 0x00009734
		public static object GetDefaultValue(Type type)
		{
			object obj;
			return obj;
		}

		// Token: 0x040001FA RID: 506
		public static readonly Type[] EmptyTypes;

		// Token: 0x02000071 RID: 113
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000419 RID: 1049 RVA: 0x0000B548 File Offset: 0x00009748
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600041A RID: 1050 RVA: 0x0000B558 File Offset: 0x00009758
			public <>c()
			{
			}

			// Token: 0x0600041B RID: 1051 RVA: 0x0000B56C File Offset: 0x0000976C
			internal bool <GetDefaultConstructor>b__10_0(ConstructorInfo c)
			{
				bool flag;
				return flag;
			}

			// Token: 0x0600041C RID: 1052 RVA: 0x0000212A File Offset: 0x0000032A
			internal string <GetFieldsAndProperties>b__29_0(MemberInfo m)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x0600041D RID: 1053 RVA: 0x0000212A File Offset: 0x0000032A
			internal Type <GetMemberInfoFromType>b__37_0(ParameterInfo p)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x0600041E RID: 1054 RVA: 0x0000B57C File Offset: 0x0000977C
			internal bool <GetChildPrivateFields>b__39_0(FieldInfo f)
			{
				return f.IsPrivate;
			}

			// Token: 0x040001FB RID: 507
			public static readonly ReflectionUtils.<>c <>9;

			// Token: 0x040001FC RID: 508
			public static Func<ConstructorInfo, bool> <>9__10_0;

			// Token: 0x040001FD RID: 509
			public static Func<MemberInfo, string> <>9__29_0;

			// Token: 0x040001FE RID: 510
			public static Func<ParameterInfo, Type> <>9__37_0;

			// Token: 0x040001FF RID: 511
			public static Func<FieldInfo, bool> <>9__39_0;
		}

		// Token: 0x02000072 RID: 114
		[CompilerGenerated]
		private sealed class <>c__DisplayClass42_0
		{
			// Token: 0x0600041F RID: 1055 RVA: 0x0000B590 File Offset: 0x00009790
			public <>c__DisplayClass42_0()
			{
			}

			// Token: 0x06000420 RID: 1056 RVA: 0x0000B5A4 File Offset: 0x000097A4
			internal bool <GetChildPrivateProperties>b__0(PropertyInfo p)
			{
				PropertyInfo propertyInfo = this.subTypeProperty;
				bool flag;
				return flag;
			}

			// Token: 0x06000421 RID: 1057 RVA: 0x0000B5BC File Offset: 0x000097BC
			internal bool <GetChildPrivateProperties>b__1(PropertyInfo p)
			{
				/*
An exception occurred when decompiling this method (06000421)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Newtonsoft.Json.Utilities.ReflectionUtils/<>c__DisplayClass42_0::<GetChildPrivateProperties>b__1(System.Reflection.PropertyInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:PropertyInfo(var_0_06, ldfld:PropertyInfo('<>c__DisplayClass42_0'::subTypeProperty, ldloc:'<>c__DisplayClass42_0'(this)))
	stloc:PropertyInfo(var_2_0D, ldfld:PropertyInfo('<>c__DisplayClass42_0'::subTypeProperty, ldloc:'<>c__DisplayClass42_0'(this)))
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

			// Token: 0x06000422 RID: 1058 RVA: 0x0000B5D8 File Offset: 0x000097D8
			internal bool <GetChildPrivateProperties>b__2(PropertyInfo p)
			{
				PropertyInfo propertyInfo = this.subTypeProperty;
				if (propertyInfo == null)
				{
				}
				bool flag = p.IsVirtual();
				if (propertyInfo == null)
				{
				}
				if (p.GetBaseDefinition() != null)
				{
					if (propertyInfo == null)
					{
					}
					MethodInfo baseDefinition = p.GetBaseDefinition();
					MethodInfo baseDefinition2 = this.subTypeProperty.GetBaseDefinition();
					return;
				}
			}

			// Token: 0x04000200 RID: 512
			public PropertyInfo subTypeProperty;
		}

		// Token: 0x02000073 RID: 115
		[CompilerGenerated]
		private sealed class <>c__DisplayClass43_0
		{
			// Token: 0x06000423 RID: 1059 RVA: 0x0000B61C File Offset: 0x0000981C
			public <>c__DisplayClass43_0()
			{
			}

			// Token: 0x06000424 RID: 1060 RVA: 0x0000B630 File Offset: 0x00009830
			internal bool <IsMethodOverridden>b__0(MethodInfo info)
			{
				/*
An exception occurred when decompiling this method (06000424)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Newtonsoft.Json.Utilities.ReflectionUtils/<>c__DisplayClass43_0::<IsMethodOverridden>b__0(System.Reflection.MethodInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_06, ldfld:string('<>c__DisplayClass43_0'::method, ldloc:'<>c__DisplayClass43_0'(this)))
	stloc:Type(var_2_0D, ldfld:Type('<>c__DisplayClass43_0'::methodDeclaringType, ldloc:'<>c__DisplayClass43_0'(this)))
	stloc:Type(var_3_14, ldfld:Type('<>c__DisplayClass43_0'::methodDeclaringType, ldloc:'<>c__DisplayClass43_0'(this)))
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

			// Token: 0x04000201 RID: 513
			public string method;

			// Token: 0x04000202 RID: 514
			public Type methodDeclaringType;
		}
	}
}
