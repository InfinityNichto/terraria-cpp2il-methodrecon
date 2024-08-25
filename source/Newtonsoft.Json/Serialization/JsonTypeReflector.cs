using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000B0 RID: 176
	[Preserve]
	internal static class JsonTypeReflector
	{
		// Token: 0x060006A4 RID: 1700 RVA: 0x0000212A File Offset: 0x0000032A
		public static T GetCachedAttribute<T>(object cpp2il__autoParamName__idx_1) where T : Attribute
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00011B10 File Offset: 0x0000FD10
		public static DataContractAttribute GetDataContractAttribute(Type type)
		{
			!0 !;
			do
			{
				if (!true)
				{
				}
			}
			while (! != null);
			Type type2;
			while (type2 != null)
			{
			}
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x00011B28 File Offset: 0x0000FD28
		public static DataMemberAttribute GetDataMemberAttribute(MemberInfo memberInfo)
		{
			do
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				!0 !;
				if (! != null)
				{
					break;
				}
				if (num == 0)
				{
				}
				bool flag;
				if (!flag)
				{
					break;
				}
				if (num == 0)
				{
				}
				MemberInfo memberInfo2;
				if (memberInfo2 != null)
				{
					!0 attribute = CachedAttributeGetter.GetAttribute(memberInfo2);
				}
			}
			while (!false);
			throw new InvalidCastException();
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x00011B68 File Offset: 0x0000FD68
		public static MemberSerialization GetObjectMemberSerialization(Type objectType, bool ignoreSerializableAttribute)
		{
			if (!true)
			{
			}
			JsonObjectAttribute jsonObjectAttribute;
			if (jsonObjectAttribute != null)
			{
				return jsonObjectAttribute._memberSerialization;
			}
			if (!true)
			{
			}
			DataContractAttribute dataContractAttribute;
			if (dataContractAttribute != null)
			{
				return MemberSerialization.OptIn;
			}
			if (!true)
			{
			}
			SerializableAttribute serializableAttribute;
			if (serializableAttribute != null)
			{
				return MemberSerialization.Fields;
			}
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x00011B94 File Offset: 0x0000FD94
		public static JsonConverter GetJsonConverter(object attributeProvider)
		{
			if (!true)
			{
			}
			JsonConverterAttribute jsonConverterAttribute;
			if (jsonConverterAttribute == null)
			{
				return;
			}
			if (!true)
			{
			}
			Type converterType = jsonConverterAttribute._converterType;
			!1 !;
			if (! != null)
			{
				object[] <ConverterParameters>k__BackingField = jsonConverterAttribute.<ConverterParameters>k__BackingField;
				return 1;
			}
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x00011BC0 File Offset: 0x0000FDC0
		public static JsonConverter CreateJsonConverterInstance(Type converterType, object[] converterArgs)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x00011BD4 File Offset: 0x0000FDD4
		private static Func<object[], JsonConverter> GetJsonConverterCreator(Type converterType)
		{
			/*
An exception occurred when decompiling this method (060006AA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Func`2<System.Object[],Newtonsoft.Json.JsonConverter> Newtonsoft.Json.Serialization.JsonTypeReflector::GetJsonConverterCreator(System.Type)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:ReflectionDelegateFactory(var_1_08, callgetter:ReflectionDelegateFactory(JsonTypeReflector::get_ReflectionDelegateFactory))
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

		// Token: 0x060006AB RID: 1707 RVA: 0x00011BEC File Offset: 0x0000FDEC
		public static TypeConverter GetTypeConverter(Type type)
		{
			if (!true)
			{
			}
			TypeConverter typeConverter;
			return typeConverter;
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x00011C00 File Offset: 0x0000FE00
		private static Type GetAssociatedMetadataType(Type type)
		{
			/*
An exception occurred when decompiling this method (060006AC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Type Newtonsoft.Json.Serialization.JsonTypeReflector::GetAssociatedMetadataType(System.Type)

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

		// Token: 0x060006AD RID: 1709 RVA: 0x00011C10 File Offset: 0x0000FE10
		private static Type GetAssociateMetadataTypeFromAttribute(Type type)
		{
			if (!true)
			{
			}
			Attribute[] array;
			Type type2 = array.GetType();
			if ("MetadataClassType" == null || "MetadataClassType" != null)
			{
				object obj;
				if (obj != null)
				{
				}
				throw new InvalidCastException();
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x00011C4C File Offset: 0x0000FE4C
		private static T GetAttribute<T>(Type type) where T : Attribute
		{
			for (;;)
			{
				int num = 1;
				if (num == 0)
				{
				}
				Type type2;
				if (type2 != null)
				{
					if (num == 0)
					{
					}
					if (type2 != null)
					{
						continue;
					}
				}
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				if (type2 == null)
				{
					return;
				}
			}
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x00011C74 File Offset: 0x0000FE74
		private static T GetAttribute<T>(MemberInfo memberInfo) where T : Attribute
		{
			Type type;
			MemberInfo memberInfo2;
			MemberInfo memberInfo3;
			while ((type != null && memberInfo2 != null && memberInfo2 != null) || (memberInfo3 != null && memberInfo3 != null))
			{
			}
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x0000212A File Offset: 0x0000032A
		public static T GetAttribute<T>(object cpp2il__autoParamName__idx_1) where T : Attribute
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060006B1 RID: 1713 RVA: 0x00011C94 File Offset: 0x0000FE94
		public static bool DynamicCodeGeneration
		{
			get
			{
				if (!true)
				{
					return;
				}
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060006B2 RID: 1714 RVA: 0x00011CA8 File Offset: 0x0000FEA8
		public static bool FullyTrusted
		{
			get
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num == 0)
				{
					return;
				}
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060006B3 RID: 1715 RVA: 0x00011CC0 File Offset: 0x0000FEC0
		public static ReflectionDelegateFactory ReflectionDelegateFactory
		{
			get
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x00011CD4 File Offset: 0x0000FED4
		// Note: this type is marked as 'beforefieldinit'.
		static JsonTypeReflector()
		{
		}

		// Token: 0x040002D7 RID: 727
		private static bool? _dynamicCodeGeneration;

		// Token: 0x040002D8 RID: 728
		private static bool? _fullyTrusted;

		// Token: 0x040002D9 RID: 729
		public const string IdPropertyName = "$id";

		// Token: 0x040002DA RID: 730
		public const string RefPropertyName = "$ref";

		// Token: 0x040002DB RID: 731
		public const string TypePropertyName = "$type";

		// Token: 0x040002DC RID: 732
		public const string ValuePropertyName = "$value";

		// Token: 0x040002DD RID: 733
		public const string ArrayValuesPropertyName = "$values";

		// Token: 0x040002DE RID: 734
		public const string ShouldSerializePrefix = "ShouldSerialize";

		// Token: 0x040002DF RID: 735
		public const string SpecifiedPostfix = "Specified";

		// Token: 0x040002E0 RID: 736
		private static readonly ThreadSafeStore<Type, Func<object[], JsonConverter>> JsonConverterCreatorCache;

		// Token: 0x040002E1 RID: 737
		private static readonly ThreadSafeStore<Type, Type> AssociatedMetadataTypesCache;

		// Token: 0x040002E2 RID: 738
		private static ReflectionObject _metadataTypeAttributeReflectionObject;

		// Token: 0x020000B1 RID: 177
		[CompilerGenerated]
		private sealed class <>c__DisplayClass18_0
		{
			// Token: 0x060006B5 RID: 1717 RVA: 0x00011CE4 File Offset: 0x0000FEE4
			public <>c__DisplayClass18_0()
			{
			}

			// Token: 0x060006B6 RID: 1718 RVA: 0x00011CF8 File Offset: 0x0000FEF8
			internal JsonConverter <GetJsonConverterCreator>b__0(object[] parameters)
			{
				/*
An exception occurred when decompiling this method (060006B6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Newtonsoft.Json.JsonConverter Newtonsoft.Json.Serialization.JsonTypeReflector/<>c__DisplayClass18_0::<GetJsonConverterCreator>b__0(System.Object[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0048:
	stloc:CultureInfo(var_8_50, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
	stloc:Type(var_9_58, ldfld:Type('<>c__DisplayClass18_0'::converterType, ldloc:'<>c__DisplayClass18_0'(this)))
	stloc:string(var_10_68, call:string(StringUtils::FormatWith, ldstr:string("No parameterless constructor defined for '{0}'."), ldloc:CultureInfo[exp:IFormatProvider](var_8_50), ldloc:Type[exp:object](var_9_58)))
	stloc:int64(var_11_6B, ldc.i4:int64(0))
	stloc:CultureInfo(var_13_75, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
	stloc:Type(var_14_7D, ldfld:Type('<>c__DisplayClass18_0'::converterType, ldloc:'<>c__DisplayClass18_0'(this)))
	stloc:string(var_15_8D, call:string(StringUtils::FormatWith, ldstr:string("Error creating '{0}'."), ldloc:CultureInfo[exp:IFormatProvider](var_13_75), ldloc:int64[exp:object](var_11_6B)))
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

			// Token: 0x040002E3 RID: 739
			public Type converterType;

			// Token: 0x040002E4 RID: 740
			public Func<object> defaultConstructor;
		}

		// Token: 0x020000B2 RID: 178
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060006B7 RID: 1719 RVA: 0x00011D98 File Offset: 0x0000FF98
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060006B8 RID: 1720 RVA: 0x00011DA8 File Offset: 0x0000FFA8
			public <>c()
			{
			}

			// Token: 0x060006B9 RID: 1721 RVA: 0x00011DBC File Offset: 0x0000FFBC
			internal Type <GetJsonConverterCreator>b__18_1(object param)
			{
				return param.GetType();
			}

			// Token: 0x040002E5 RID: 741
			public static readonly JsonTypeReflector.<>c <>9;

			// Token: 0x040002E6 RID: 742
			public static Func<object, Type> <>9__18_1;
		}
	}
}
