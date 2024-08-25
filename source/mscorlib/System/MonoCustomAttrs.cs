using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x02000181 RID: 385
	internal static class MonoCustomAttrs
	{
		// Token: 0x06000F0D RID: 3853 RVA: 0x000200D4 File Offset: 0x0001E2D4
		private static bool IsUserCattrProvider(object obj)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06000F0E RID: 3854 RVA: 0x0000207A File Offset: 0x0000027A
		internal static Attribute[] GetCustomAttributesInternal(ICustomAttributeProvider obj, Type attributeType, bool pseudoAttrs)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x000200E8 File Offset: 0x0001E2E8
		internal static object[] GetPseudoCustomAttributes(ICustomAttributeProvider obj, Type attributeType)
		{
			object[] array;
			return array;
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x0002010C File Offset: 0x0001E30C
		private static object[] GetPseudoCustomAttributes(Type type)
		{
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000F11 RID: 3857 RVA: 0x00020120 File Offset: 0x0001E320
		internal static object[] GetCustomAttributesBase(ICustomAttributeProvider obj, Type attributeType, bool inheritedOnly)
		{
			/*
An exception occurred when decompiling this method (06000F11)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object[] System.MonoCustomAttrs::GetCustomAttributesBase(System.Reflection.ICustomAttributeProvider,System.Type,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000B:
	brtrue(IL_0000, logicnot:bool(ldloc:object[][exp:bool](var_2)))
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

		// Token: 0x06000F12 RID: 3858 RVA: 0x0002013C File Offset: 0x0001E33C
		internal static object[] GetCustomAttributes(ICustomAttributeProvider obj, Type attributeType, bool inherit)
		{
			if (!false)
			{
			}
			AttributeUsageAttribute attributeUsageAttribute;
			if (!attributeUsageAttribute._inherited)
			{
			}
			int num = 16;
			int num2 = Math.Max(0, num);
			long num3 = 0L;
			AttributeUsageAttribute attributeUsageAttribute2;
			bool allowMultiple;
			if ((num3 == 0L && num3 == 0L) || attributeUsageAttribute2._inherited)
			{
				allowMultiple = attributeUsageAttribute2._allowMultiple;
				if (allowMultiple || allowMultiple)
				{
				}
			}
			if (!allowMultiple)
			{
			}
			ICustomAttributeProvider customAttributeProvider;
			if (customAttributeProvider != null)
			{
				object[] array;
				return array;
			}
			Array array2;
			if (array2 != null)
			{
				if (array2 == null)
				{
					throw new InvalidCastException();
				}
			}
			Array array3;
			if (array3 != null && array3 == null)
			{
				throw new InvalidCastException();
			}
			return "obj";
		}

		// Token: 0x06000F13 RID: 3859 RVA: 0x000201D8 File Offset: 0x0001E3D8
		internal static object[] GetCustomAttributes(ICustomAttributeProvider obj, bool inherit)
		{
			object[] array;
			return array;
		}

		// Token: 0x06000F14 RID: 3860 RVA: 0x0000207A File Offset: 0x0000027A
		private static CustomAttributeData[] GetCustomAttributesDataInternal(ICustomAttributeProvider obj)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000F15 RID: 3861 RVA: 0x000201F4 File Offset: 0x0001E3F4
		internal static IList<CustomAttributeData> GetCustomAttributesData(ICustomAttributeProvider obj, bool inherit = false)
		{
			IList<CustomAttributeData> list;
			return list;
		}

		// Token: 0x06000F16 RID: 3862 RVA: 0x00020204 File Offset: 0x0001E404
		internal static IList<CustomAttributeData> GetCustomAttributesData(ICustomAttributeProvider obj, Type attributeType, bool inherit)
		{
			if (!true)
			{
			}
			IList<CustomAttributeData> list;
			return list;
		}

		// Token: 0x06000F17 RID: 3863 RVA: 0x00020368 File Offset: 0x0001E568
		internal static IList<CustomAttributeData> GetCustomAttributesDataBase(ICustomAttributeProvider obj, Type attributeType, bool inheritedOnly)
		{
			/*
An exception occurred when decompiling this method (06000F17)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IList`1<System.Reflection.CustomAttributeData> System.MonoCustomAttrs::GetCustomAttributesDataBase(System.Reflection.ICustomAttributeProvider,System.Type,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class System.Collections.Generic.IList`1<valuetype System.Reflection.CustomAttributeTypedArgument>(var_2_0C, ldfld:class System.Collections.Generic.IList`1<valuetype System.Reflection.CustomAttributeTypedArgument>(CustomAttributeData::ctorArgs, ldloc:class System.Reflection.CustomAttributeData[][exp:CustomAttributeData](var_1)))
	stloc:class System.Collections.Generic.IList`1<valuetype System.Reflection.CustomAttributeTypedArgument>(var_3_13, ldfld:class System.Collections.Generic.IList`1<valuetype System.Reflection.CustomAttributeTypedArgument>(CustomAttributeData::ctorArgs, ldloc:class System.Reflection.CustomAttributeData[][exp:CustomAttributeData](var_1)))
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

		// Token: 0x06000F18 RID: 3864 RVA: 0x00020388 File Offset: 0x0001E588
		internal static CustomAttributeData[] GetPseudoCustomAttributesData(ICustomAttributeProvider obj, Type attributeType)
		{
			CustomAttributeData[] array;
			return array;
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x000203C0 File Offset: 0x0001E5C0
		private static CustomAttributeData[] GetPseudoCustomAttributesData(Type type)
		{
			if (!false)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x000203D8 File Offset: 0x0001E5D8
		internal static bool IsDefined(ICustomAttributeProvider obj, Type attributeType, bool inherit)
		{
			/*
An exception occurred when decompiling this method (06000F1A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.MonoCustomAttrs::IsDefined(System.Reflection.ICustomAttributeProvider,System.Type,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0032:
	stloc:int64(var_10_38, ldfld:int64(int64::m_value, ldc.i4:int32[exp:int64&](0)))
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

		// Token: 0x06000F1B RID: 3867 RVA: 0x0000207A File Offset: 0x0000027A
		internal static bool IsDefinedInternal(ICustomAttributeProvider obj, Type AttributeType)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x00020420 File Offset: 0x0001E620
		private static PropertyInfo GetBasePropertyDefinition(RuntimePropertyInfo property)
		{
			bool flag;
			if (flag)
			{
			}
			bool flag2;
			if (flag2 && flag)
			{
				PropertyInfo propertyInfo;
				return propertyInfo;
			}
			PropertyInfo propertyInfo2;
			return propertyInfo2;
		}

		// Token: 0x06000F1D RID: 3869 RVA: 0x00020450 File Offset: 0x0001E650
		private static EventInfo GetBaseEventDefinition(RuntimeEventInfo evt)
		{
			bool flag;
			if (flag)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x00020468 File Offset: 0x0001E668
		private static ICustomAttributeProvider GetBase(ICustomAttributeProvider obj)
		{
			if (false)
			{
			}
			MethodInfo methodInfo;
			while (methodInfo == null)
			{
			}
			MethodInfo methodInfo2;
			bool flag = methodInfo2 == methodInfo;
			throw new InvalidCastException();
		}

		// Token: 0x06000F1F RID: 3871 RVA: 0x0002049C File Offset: 0x0001E69C
		private static AttributeUsageAttribute RetrieveAttributeUsageNoCache(Type attributeType)
		{
			object[] array;
			do
			{
				if (!true)
				{
				}
				Type type;
				bool flag = type == type;
				if (!true)
				{
				}
			}
			while (array == null);
			throw new InvalidCastException();
		}

		// Token: 0x06000F20 RID: 3872 RVA: 0x000204C4 File Offset: 0x0001E6C4
		private static AttributeUsageAttribute RetrieveAttributeUsage(Type attributeType)
		{
			/*
An exception occurred when decompiling this method (06000F20)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.AttributeUsageAttribute System.MonoCustomAttrs::RetrieveAttributeUsage(System.Type)

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

		// Token: 0x06000F21 RID: 3873 RVA: 0x000204D4 File Offset: 0x0001E6D4
		// Note: this type is marked as 'beforefieldinit'.
		static MonoCustomAttrs()
		{
		}

		// Token: 0x04000683 RID: 1667
		private static Assembly corlib;

		// Token: 0x04000684 RID: 1668
		[ThreadStatic]
		private static Dictionary<Type, AttributeUsageAttribute> usage_cache;

		// Token: 0x04000685 RID: 1669
		private static readonly AttributeUsageAttribute DefaultAttributeUsage;

		// Token: 0x02000182 RID: 386
		private class AttributeInfo
		{
			// Token: 0x06000F22 RID: 3874 RVA: 0x000204E4 File Offset: 0x0001E6E4
			public AttributeInfo(AttributeUsageAttribute usage, int inheritanceLevel)
			{
			}

			// Token: 0x1700015D RID: 349
			// (get) Token: 0x06000F23 RID: 3875 RVA: 0x00020500 File Offset: 0x0001E700
			public AttributeUsageAttribute Usage
			{
				get
				{
					return this._usage;
				}
			}

			// Token: 0x1700015E RID: 350
			// (get) Token: 0x06000F24 RID: 3876 RVA: 0x00020514 File Offset: 0x0001E714
			public int InheritanceLevel
			{
				get
				{
					return this._inheritanceLevel;
				}
			}

			// Token: 0x04000686 RID: 1670
			private AttributeUsageAttribute _usage = usage;

			// Token: 0x04000687 RID: 1671
			private int _inheritanceLevel = inheritanceLevel;
		}
	}
}
