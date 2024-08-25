using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200008A RID: 138
	[Preserve]
	public class DefaultContractResolver : IContractResolver
	{
		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060004D4 RID: 1236 RVA: 0x0000CA60 File Offset: 0x0000AC60
		internal static IContractResolver Instance
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x0000CA74 File Offset: 0x0000AC74
		public bool DynamicCodeGeneration
		{
			get
			{
				if (!true)
				{
				}
				return JsonTypeReflector.DynamicCodeGeneration;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060004D6 RID: 1238 RVA: 0x0000CA8C File Offset: 0x0000AC8C
		// (set) Token: 0x060004D7 RID: 1239 RVA: 0x0000CAA0 File Offset: 0x0000ACA0
		[Obsolete("DefaultMembersSearchFlags is obsolete. To modify the members serialized inherit from DefaultContractResolver and override the GetSerializableMembers method instead.")]
		public BindingFlags DefaultMembersSearchFlags
		{
			[CompilerGenerated]
			get
			{
				return this.<DefaultMembersSearchFlags>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<DefaultMembersSearchFlags>k__BackingField = value;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060004D8 RID: 1240 RVA: 0x0000CAB4 File Offset: 0x0000ACB4
		// (set) Token: 0x060004D9 RID: 1241 RVA: 0x0000CAC8 File Offset: 0x0000ACC8
		public bool SerializeCompilerGeneratedMembers
		{
			[CompilerGenerated]
			get
			{
				return this.<SerializeCompilerGeneratedMembers>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060004DA RID: 1242 RVA: 0x0000CAD8 File Offset: 0x0000ACD8
		// (set) Token: 0x060004DB RID: 1243 RVA: 0x0000CAEC File Offset: 0x0000ACEC
		public bool IgnoreSerializableInterface
		{
			[CompilerGenerated]
			get
			{
				return this.<IgnoreSerializableInterface>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060004DC RID: 1244 RVA: 0x0000CAFC File Offset: 0x0000ACFC
		// (set) Token: 0x060004DD RID: 1245 RVA: 0x0000CB10 File Offset: 0x0000AD10
		public bool IgnoreSerializableAttribute
		{
			[CompilerGenerated]
			get
			{
				return this.<IgnoreSerializableAttribute>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x0000CB20 File Offset: 0x0000AD20
		public DefaultContractResolver()
		{
			this.<IgnoreSerializableAttribute>k__BackingField = true;
			this.DefaultMembersSearchFlags = BindingFlags.Instance | BindingFlags.Public;
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x0000CB44 File Offset: 0x0000AD44
		[Obsolete("DefaultContractResolver(bool) is obsolete. Use the parameterless constructor and cache instances of the contract resolver within your application for optimal performance.")]
		public DefaultContractResolver(bool shareCache)
		{
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x0000CB54 File Offset: 0x0000AD54
		internal DefaultContractResolverState GetState()
		{
			/*
An exception occurred when decompiling this method (060004E0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Newtonsoft.Json.Serialization.DefaultContractResolverState Newtonsoft.Json.Serialization.DefaultContractResolver::GetState()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	brtrue(IL_0000, ldloc:bool(var_0_06))
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

		// Token: 0x060004E1 RID: 1249 RVA: 0x0000CB70 File Offset: 0x0000AD70
		public virtual JsonContract ResolveContract(Type type)
		{
			if (type != null)
			{
				DefaultContractResolverState state = this.GetState();
				Type type2 = base.GetType();
				if (state.ContractCache != null)
				{
				}
				Monitor.Enter(this);
				if (state.ContractCache != null)
				{
				}
				Monitor.Exit(this);
			}
			Monitor.Exit(this);
			throw new OutOfMemoryException();
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x0000CBC8 File Offset: 0x0000ADC8
		protected virtual List<MemberInfo> GetSerializableMembers(Type objectType)
		{
			List<MemberInfo> list;
			do
			{
				bool flag = this.<IgnoreSerializableAttribute>k__BackingField;
				if (objectType == null)
				{
				}
				while (this == null)
				{
				}
				BindingFlags bindingFlags = this.<DefaultMembersSearchFlags>k__BackingField;
				bool flag2 = this.<SerializeCompilerGeneratedMembers>k__BackingField;
				if (flag2 || !flag2)
				{
				}
				if (JsonTypeReflector.GetAttribute<JsonPropertyAttribute>(list) != null)
				{
				}
				if (JsonTypeReflector.GetAttribute<JsonRequiredAttribute>(list) != null)
				{
				}
			}
			while (JsonTypeReflector.GetAttribute<DataMemberAttribute>(list) == null);
			throw new OutOfMemoryException();
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x0000CC30 File Offset: 0x0000AE30
		private bool ShouldSerializeEntityMember(MemberInfo memberInfo)
		{
			if (memberInfo != null)
			{
				return;
			}
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x0000CC44 File Offset: 0x0000AE44
		protected virtual JsonObjectContract CreateObjectContract(Type objectType)
		{
			JsonObjectAttribute cachedAttribute;
			do
			{
				bool flag = this.<IgnoreSerializableAttribute>k__BackingField;
				if (!true)
				{
				}
				MemberSerialization objectMemberSerialization = JsonTypeReflector.GetObjectMemberSerialization(objectType, true);
				cachedAttribute = JsonTypeReflector.GetCachedAttribute<JsonObjectAttribute>(objectType);
			}
			while (cachedAttribute == null);
			ConstructorInfo constructorInfo;
			if (cachedAttribute._itemRequired == null || constructorInfo != null)
			{
				MemberInfo memberInfo;
				if (memberInfo != null)
				{
				}
				return 1;
			}
			bool fullyTrusted = JsonTypeReflector.FullyTrusted;
			ConstructorInfo constructorInfo2;
			while (constructorInfo2 == null)
			{
			}
			return 1;
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x0000CC90 File Offset: 0x0000AE90
		private MemberInfo GetExtensionDataMemberForType(Type type)
		{
			MemberInfo memberInfo;
			return memberInfo;
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x0000CCA0 File Offset: 0x0000AEA0
		private static void SetExtensionDataDelegates(JsonObjectContract contract, MemberInfo member)
		{
			int num = 1;
			if (num == 0)
			{
			}
			JsonExtensionDataAttribute attribute = ReflectionUtils.GetAttribute<JsonExtensionDataAttribute>(member);
			if (attribute != null)
			{
				if (num == 0)
				{
				}
				Type type;
				bool flag = ReflectionUtils.IsGenericDefinition(ReflectionUtils.GetMemberUnderlyingType(member), type);
				ReflectionDelegateFactory reflectionDelegateFactory = JsonTypeReflector.ReflectionDelegateFactory;
				if (attribute.<ReadData>k__BackingField)
				{
					ReflectionDelegateFactory reflectionDelegateFactory2 = JsonTypeReflector.ReflectionDelegateFactory;
					ReflectionDelegateFactory reflectionDelegateFactory3 = JsonTypeReflector.ReflectionDelegateFactory;
					ReflectionDelegateFactory reflectionDelegateFactory4 = JsonTypeReflector.ReflectionDelegateFactory;
				}
				if (attribute.<WriteData>k__BackingField)
				{
					Type type2;
					ConstructorInfo constructorInfo = Enumerable.First<ConstructorInfo>(type2.GetConstructors());
					ReflectionDelegateFactory reflectionDelegateFactory5 = JsonTypeReflector.ReflectionDelegateFactory;
				}
			}
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x0000CD30 File Offset: 0x0000AF30
		private ConstructorInfo GetAttributeConstructor(Type objectType)
		{
			Type type;
			Type type2;
			Type type3;
			Type type4;
			if ((type == null || type != null) && (type2 == null || type2 != null) && (type3 == null || type3 != null) && (type4 == null || type4 != null))
			{
				ConstructorInfo constructorInfo;
				return constructorInfo;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x0000CD68 File Offset: 0x0000AF68
		private ConstructorInfo GetParameterizedConstructor(Type objectType)
		{
			/*
An exception occurred when decompiling this method (060004E8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Reflection.ConstructorInfo Newtonsoft.Json.Serialization.DefaultContractResolver::GetParameterizedConstructor(System.Type)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int64(var_0_06, ldfld:int64(int64::m_value, ldc.i4:int32[exp:int64&](0)))
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

		// Token: 0x060004E9 RID: 1257 RVA: 0x0000CD7C File Offset: 0x0000AF7C
		protected virtual IList<JsonProperty> CreateConstructorParameters(ConstructorInfo constructor, JsonPropertyCollection memberProperties)
		{
			/*
An exception occurred when decompiling this method (060004E9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IList`1<Newtonsoft.Json.Serialization.JsonProperty> Newtonsoft.Json.Serialization.DefaultContractResolver::CreateConstructorParameters(System.Reflection.ConstructorInfo,Newtonsoft.Json.Serialization.JsonPropertyCollection)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_2:
	brtrue(IL_0000, logicnot:bool(ldloc:DefaultContractResolver[exp:bool](this)))
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

		// Token: 0x060004EA RID: 1258 RVA: 0x0000CDA0 File Offset: 0x0000AFA0
		protected virtual JsonProperty CreatePropertyFromConstructorParameter(JsonProperty matchingMemberProperty, ParameterInfo parameterInfo)
		{
			/*
An exception occurred when decompiling this method (060004EA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Newtonsoft.Json.Serialization.JsonProperty Newtonsoft.Json.Serialization.DefaultContractResolver::CreatePropertyFromConstructorParameter(Newtonsoft.Json.Serialization.JsonProperty,System.Reflection.ParameterInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0023:
	stloc:valuetype [mscorlib]System.Nullable`1<bool>(var_4_29, ldfld:valuetype [mscorlib]System.Nullable`1<bool>(JsonProperty::<IsReference>k__BackingField, ldloc:JsonProperty(matchingMemberProperty)))
	stloc:valuetype [mscorlib]System.Nullable`1<valuetype Newtonsoft.Json.NullValueHandling>(var_5_31, ldfld:valuetype [mscorlib]System.Nullable`1<valuetype Newtonsoft.Json.NullValueHandling>(JsonProperty::<NullValueHandling>k__BackingField, ldloc:JsonProperty(matchingMemberProperty)))
	stloc:valuetype [mscorlib]System.Nullable`1<valuetype Newtonsoft.Json.DefaultValueHandling>(var_6_39, ldfld:valuetype [mscorlib]System.Nullable`1<valuetype Newtonsoft.Json.DefaultValueHandling>(JsonProperty::<DefaultValueHandling>k__BackingField, ldloc:JsonProperty(matchingMemberProperty)))
	stloc:valuetype [mscorlib]System.Nullable`1<valuetype Newtonsoft.Json.ReferenceLoopHandling>(var_7_41, ldfld:valuetype [mscorlib]System.Nullable`1<valuetype Newtonsoft.Json.ReferenceLoopHandling>(JsonProperty::<ReferenceLoopHandling>k__BackingField, ldloc:JsonProperty(matchingMemberProperty)))
	stloc:valuetype [mscorlib]System.Nullable`1<valuetype Newtonsoft.Json.ObjectCreationHandling>(var_8_49, ldfld:valuetype [mscorlib]System.Nullable`1<valuetype Newtonsoft.Json.ObjectCreationHandling>(JsonProperty::<ObjectCreationHandling>k__BackingField, ldloc:JsonProperty(matchingMemberProperty)))
	stloc:valuetype [mscorlib]System.Nullable`1<valuetype Newtonsoft.Json.TypeNameHandling>(var_9_51, ldfld:valuetype [mscorlib]System.Nullable`1<valuetype Newtonsoft.Json.TypeNameHandling>(JsonProperty::<TypeNameHandling>k__BackingField, ldloc:JsonProperty(matchingMemberProperty)))
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

		// Token: 0x060004EB RID: 1259 RVA: 0x0000CE00 File Offset: 0x0000B000
		protected virtual JsonConverter ResolveContractConverter(Type objectType)
		{
			if (!true)
			{
			}
			return JsonTypeReflector.GetJsonConverter(objectType);
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x0000CE18 File Offset: 0x0000B018
		private Func<object> GetDefaultCreator(Type createdType)
		{
			/*
An exception occurred when decompiling this method (060004EC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Func`1<System.Object> Newtonsoft.Json.Serialization.DefaultContractResolver::GetDefaultCreator(System.Type)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:ReflectionDelegateFactory(var_1_0A, callgetter:ReflectionDelegateFactory(JsonTypeReflector::get_ReflectionDelegateFactory))
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

		// Token: 0x060004ED RID: 1261 RVA: 0x0000CE30 File Offset: 0x0000B030
		private void InitializeContract(JsonContract contract)
		{
			JsonContainerAttribute cachedAttribute;
			for (;;)
			{
				Type nonNullableUnderlyingType = contract.NonNullableUnderlyingType;
				if (!true)
				{
				}
				cachedAttribute = JsonTypeReflector.GetCachedAttribute<JsonContainerAttribute>(nonNullableUnderlyingType);
				if (cachedAttribute != null)
				{
					break;
				}
				Type nonNullableUnderlyingType2 = contract.NonNullableUnderlyingType;
				long num;
				if (num == 0L)
				{
				}
				DataContractAttribute dataContractAttribute = JsonTypeReflector.GetDataContractAttribute(nonNullableUnderlyingType2);
				while (dataContractAttribute == null)
				{
				}
				if (dataContractAttribute.isReference)
				{
					return;
				}
			}
			bool? isReference = cachedAttribute._isReference;
			contract.<IsReference>k__BackingField = isReference;
			Type nonNullableUnderlyingType3 = contract.NonNullableUnderlyingType;
			contract.<Converter>k__BackingField = this;
			Type nonNullableUnderlyingType4 = contract.NonNullableUnderlyingType;
			bool isInstantiable = contract.IsInstantiable;
			JsonConverter jsonConverter;
			contract.<InternalConverter>k__BackingField = jsonConverter;
			if (isInstantiable)
			{
				Type createdType = contract._createdType;
				if (!isInstantiable)
				{
				}
				bool flag = ReflectionUtils.HasDefaultConstructor(createdType, true);
				bool flag2 = contract._createdType.IsValueType();
				Type createdType2 = contract._createdType;
				Type createdType3 = contract._createdType;
				Func<object> func;
				contract.<DefaultCreator>k__BackingField = func;
				bool flag3 = createdType3.IsValueType();
				long num = 0L;
				return;
			}
			Type nonNullableUnderlyingType5 = contract.NonNullableUnderlyingType;
			this.ResolveCallbackMethods(contract, nonNullableUnderlyingType5);
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x0000CF1C File Offset: 0x0000B11C
		private void ResolveCallbackMethods(JsonContract contract, Type t)
		{
			if (t != null)
			{
				IList<SerializationCallback> onSerializingCallbacks = contract.OnSerializingCallbacks;
			}
			if (t != null)
			{
				IList<SerializationCallback> onSerializedCallbacks = contract.OnSerializedCallbacks;
			}
			if (t != null)
			{
				IList<SerializationCallback> onDeserializingCallbacks = contract.OnDeserializingCallbacks;
			}
			if (t != null)
			{
				IList<SerializationCallback> onDeserializedCallbacks = contract.OnDeserializedCallbacks;
			}
			if (t != null)
			{
				IList<SerializationErrorCallback> onErrorCallbacks = contract.OnErrorCallbacks;
			}
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x0000CF5C File Offset: 0x0000B15C
		private void GetCallbackMethodsForType(Type type, [Out] List<SerializationCallback> onSerializing, [Out] List<SerializationCallback> onSerialized, [Out] List<SerializationCallback> onDeserializing, [Out] List<SerializationCallback> onDeserialized, [Out] List<SerializationErrorCallback> onError)
		{
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x0000CFA8 File Offset: 0x0000B1A8
		private static bool ShouldSkipDeserialized(Type t)
		{
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x0000CFB8 File Offset: 0x0000B1B8
		private static bool ShouldSkipSerializing(Type t)
		{
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x0000CFC8 File Offset: 0x0000B1C8
		private List<Type> GetClassHierarchyForType(Type type)
		{
			/*
An exception occurred when decompiling this method (060004F2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.List`1<System.Type> Newtonsoft.Json.Serialization.DefaultContractResolver::GetClassHierarchyForType(System.Type)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0008:
	brtrue(IL_0000, call:Type[exp:bool](TypeExtensions::BaseType, ldloc:Type(type)))
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

		// Token: 0x060004F3 RID: 1267 RVA: 0x0000CFE4 File Offset: 0x0000B1E4
		protected virtual JsonDictionaryContract CreateDictionaryContract(Type objectType)
		{
			ConstructorInfo constructorInfo;
			if (constructorInfo != null)
			{
				Type type;
				if (type != null && type == null)
				{
					throw new ArrayTypeMismatchException();
				}
				if (!true)
				{
				}
				ReflectionDelegateFactory reflectionDelegateFactory = JsonTypeReflector.ReflectionDelegateFactory;
			}
			throw new NullReferenceException();
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x0000D01C File Offset: 0x0000B21C
		protected virtual JsonArrayContract CreateArrayContract(Type objectType)
		{
			ConstructorInfo constructorInfo;
			if (constructorInfo != null)
			{
				if (!true)
				{
				}
				ReflectionDelegateFactory reflectionDelegateFactory = JsonTypeReflector.ReflectionDelegateFactory;
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x0000212A File Offset: 0x0000032A
		protected virtual JsonPrimitiveContract CreatePrimitiveContract(Type objectType)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x0000212A File Offset: 0x0000032A
		protected virtual JsonLinqContract CreateLinqContract(Type objectType)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x0000D048 File Offset: 0x0000B248
		protected virtual JsonISerializableContract CreateISerializableContract(Type objectType)
		{
			Type type;
			Type type2;
			ConstructorInfo constructorInfo;
			if ((type == null || type != null) && (type2 == null || type2 != null) && constructorInfo != null)
			{
				ReflectionDelegateFactory reflectionDelegateFactory = JsonTypeReflector.ReflectionDelegateFactory;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x0000212A File Offset: 0x0000032A
		protected virtual JsonStringContract CreateStringContract(Type objectType)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x0000D074 File Offset: 0x0000B274
		protected virtual JsonContract CreateContract(Type objectType)
		{
			/*
An exception occurred when decompiling this method (060004F9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Newtonsoft.Json.Serialization.JsonContract Newtonsoft.Json.Serialization.DefaultContractResolver::CreateContract(System.Type)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0031:
	stloc:bool(var_8_37, call:bool(DefaultContractResolver::IsIConvertible, ldloc:Type(var_1_10)))
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

		// Token: 0x060004FA RID: 1274 RVA: 0x0000D0BC File Offset: 0x0000B2BC
		internal static bool IsJsonPrimitiveType(Type t)
		{
			/*
An exception occurred when decompiling this method (060004FA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Newtonsoft.Json.Serialization.DefaultContractResolver::IsJsonPrimitiveType(System.Type)

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

		// Token: 0x060004FB RID: 1275 RVA: 0x0000D0CC File Offset: 0x0000B2CC
		internal static bool IsIConvertible(Type t)
		{
			/*
An exception occurred when decompiling this method (060004FB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Newtonsoft.Json.Serialization.DefaultContractResolver::IsIConvertible(System.Type)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:Type(var_4_09, call:Type(Nullable::GetUnderlyingType, ldloc:Type(var_3)))
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

		// Token: 0x060004FC RID: 1276 RVA: 0x0000D0E4 File Offset: 0x0000B2E4
		internal static bool CanConvertToString(Type type)
		{
			if (!true)
			{
			}
			TypeConverter typeConverter;
			if (typeConverter != null)
			{
				Type type2 = typeConverter.GetType();
				Type type3;
				bool flag = typeConverter.CanConvertTo(type3);
				return;
			}
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x0000D10C File Offset: 0x0000B30C
		private static bool IsValidCallback(MethodInfo method, ParameterInfo[] parameters, Type attributeType, MethodInfo currentCallback, Type prevAttributeType)
		{
			if (attributeType == null)
			{
				if (method != null)
				{
				}
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
				return false;
			}
			CultureInfo invariantCulture2 = CultureInfo.InvariantCulture;
			return "Invalid attribute. Both '{0}' and '{1}' in type '{2}' have '{3}'." != null;
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x0000D184 File Offset: 0x0000B384
		internal static string GetClrTypeFullName(Type type)
		{
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			string text;
			return text;
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x0000D1A4 File Offset: 0x0000B3A4
		protected virtual IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
		{
			if (this == null)
			{
				throw new OutOfMemoryException();
			}
			while (this == null)
			{
			}
			DefaultContractResolverState state = this.GetState();
			PropertyNameTable nameTable = state.NameTable;
			Monitor.Enter(nameTable);
			PropertyNameTable nameTable2 = state.NameTable;
			long num = 0L;
			Monitor.Exit(nameTable);
			if (num == 0L)
			{
				if (7 != 0 || memberSerialization == MemberSerialization.OptOut)
				{
				}
				Monitor.Exit(nameTable);
				throw new OutOfMemoryException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x0000212A File Offset: 0x0000032A
		protected virtual IValueProvider CreateMemberValueProvider(MemberInfo member)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x0000D20C File Offset: 0x0000B40C
		protected virtual JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
		{
			/*
An exception occurred when decompiling this method (06000501)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Newtonsoft.Json.Serialization.JsonProperty Newtonsoft.Json.Serialization.DefaultContractResolver::CreateProperty(System.Reflection.MemberInfo,Newtonsoft.Json.MemberSerialization)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:Type(var_0_09, call:Type(ReflectionUtils::GetMemberUnderlyingType, ldloc:MemberInfo(member)))
	brtrue(IL_0000, ldc.i4:int32[exp:bool](257))
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

		// Token: 0x06000502 RID: 1282 RVA: 0x0000D22C File Offset: 0x0000B42C
		private void SetPropertySettingsFromAttributes(JsonProperty property, object attributeProvider, string name, Type declaringType, MemberSerialization memberSerialization, [Out] bool allowNonPublicAccess)
		{
			if (!true)
			{
			}
			DataContractAttribute dataContractAttribute = JsonTypeReflector.GetDataContractAttribute(declaringType);
			if (attributeProvider != null)
			{
			}
			long num = 0L;
			JsonPropertyAttribute attribute = JsonTypeReflector.GetAttribute<JsonPropertyAttribute>(attributeProvider);
			JsonRequiredAttribute attribute2 = JsonTypeReflector.GetAttribute<JsonRequiredAttribute>(attributeProvider);
			if ((attribute != null && attribute.<PropertyName>k__BackingField != null) || num != 0L)
			{
			}
			property.<UnderlyingName>k__BackingField = name;
			int num2;
			bool? itemIsReference;
			if (attribute == null)
			{
				while (num2 == 0)
				{
				}
				property._required = itemIsReference;
				return;
			}
			DefaultValueHandling? defaultValueHandling = attribute._defaultValueHandling;
			property.<DefaultValueHandling>k__BackingField = defaultValueHandling;
			if (attribute2 != null)
			{
				num2 = 1;
				property._required = defaultValueHandling;
			}
			property.<HasMemberAttribute>k__BackingField = num2 != 0;
			if (defaultValueHandling == null)
			{
			}
			BindingFlags bindingFlags;
			Type <ItemConverterType>k__BackingField;
			if (JsonTypeReflector.GetAttribute<JsonIgnoreAttribute>(attributeProvider) == null)
			{
				if (defaultValueHandling == null)
				{
				}
				if (JsonTypeReflector.GetAttribute<JsonExtensionDataAttribute>(attributeProvider) == null)
				{
					if (bindingFlags == BindingFlags.Default)
					{
					}
					NonSerializedAttribute attribute3 = JsonTypeReflector.GetAttribute<NonSerializedAttribute>(<ItemConverterType>k__BackingField);
					return;
				}
			}
			int num3 = 1;
			property.<Ignored>k__BackingField = num3 != 0;
			if (num3 == 0)
			{
			}
			JsonConverter jsonConverter = JsonTypeReflector.GetJsonConverter(attributeProvider);
			property.<Converter>k__BackingField = jsonConverter;
			JsonConverter jsonConverter2 = JsonTypeReflector.GetJsonConverter(attributeProvider);
			property.<MemberConverter>k__BackingField = jsonConverter2;
			DefaultValueAttribute attribute4 = JsonTypeReflector.GetAttribute<DefaultValueAttribute>(attributeProvider);
			if (attribute4 != null)
			{
				int num4 = 1;
				property._hasExplicitDefaultValue = num4 != 0;
				property._defaultValue = attribute4;
			}
			if (attribute == null)
			{
				return;
			}
			NullValueHandling? nullValueHandling = attribute._nullValueHandling;
			ReferenceLoopHandling? referenceLoopHandling = attribute._referenceLoopHandling;
			ObjectCreationHandling? objectCreationHandling = attribute._objectCreationHandling;
			TypeNameHandling? typeNameHandling = attribute._typeNameHandling;
			bool? isReference = attribute._isReference;
			itemIsReference = attribute._itemIsReference;
			<ItemConverterType>k__BackingField = attribute.<ItemConverterType>k__BackingField;
			if (<ItemConverterType>k__BackingField != null)
			{
				object[] <ItemConverterParameters>k__BackingField = attribute.<ItemConverterParameters>k__BackingField;
				if (itemIsReference == null)
				{
				}
				JsonConverter jsonConverter3 = JsonTypeReflector.CreateJsonConverterInstance(<ItemConverterType>k__BackingField, <ItemConverterParameters>k__BackingField);
				return;
			}
			long num5 = 0L;
			property.<ItemConverter>k__BackingField = num5;
			ReferenceLoopHandling? itemReferenceLoopHandling = attribute._itemReferenceLoopHandling;
			TypeNameHandling? itemTypeNameHandling = attribute._itemTypeNameHandling;
			bindingFlags = this.<DefaultMembersSearchFlags>k__BackingField;
			allowNonPublicAccess.m_value = bindingFlags != BindingFlags.Default;
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x0000D3C8 File Offset: 0x0000B5C8
		private Predicate<object> CreateShouldSerializeTest(MemberInfo member)
		{
			MethodInfo methodInfo;
			if (methodInfo != null)
			{
				ReflectionDelegateFactory reflectionDelegateFactory = JsonTypeReflector.ReflectionDelegateFactory;
				return;
			}
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x0000D3E4 File Offset: 0x0000B5E4
		private void SetIsSpecifiedActions(JsonProperty property, MemberInfo member, bool allowNonPublicAccess)
		{
			PropertyInfo propertyInfo;
			if (propertyInfo == null)
			{
			}
			FieldInfo fieldInfo;
			if (fieldInfo != null)
			{
				Type memberUnderlyingType = ReflectionUtils.GetMemberUnderlyingType(fieldInfo);
				Func func = JsonTypeReflector.ReflectionDelegateFactory.CreateGet(fieldInfo);
				long num = 0L;
				bool flag = ReflectionUtils.CanSetMemberValue(fieldInfo, true, num != 0L);
				Action action = JsonTypeReflector.ReflectionDelegateFactory.CreateSet(fieldInfo);
				property.<SetIsSpecified>k__BackingField = action;
			}
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x0000D438 File Offset: 0x0000B638
		protected virtual string ResolvePropertyName(string propertyName)
		{
			return propertyName;
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x0000212A File Offset: 0x0000032A
		protected virtual string ResolveDictionaryKey(string dictionaryKey)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x0000212A File Offset: 0x0000032A
		public string GetResolvedPropertyName(string propertyName)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x0000D448 File Offset: 0x0000B648
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultContractResolver()
		{
		}

		// Token: 0x04000227 RID: 551
		private static readonly IContractResolver _instance;

		// Token: 0x04000228 RID: 552
		private static readonly JsonConverter[] BuiltInConverters;

		// Token: 0x04000229 RID: 553
		private static readonly object TypeContractCacheLock;

		// Token: 0x0400022A RID: 554
		private static readonly DefaultContractResolverState _sharedState;

		// Token: 0x0400022B RID: 555
		private readonly DefaultContractResolverState _instanceState;

		// Token: 0x0400022C RID: 556
		private readonly bool _sharedCache;

		// Token: 0x0400022D RID: 557
		[CompilerGenerated]
		private BindingFlags <DefaultMembersSearchFlags>k__BackingField;

		// Token: 0x0400022E RID: 558
		[CompilerGenerated]
		private bool <SerializeCompilerGeneratedMembers>k__BackingField;

		// Token: 0x0400022F RID: 559
		[CompilerGenerated]
		private bool <IgnoreSerializableInterface>k__BackingField;

		// Token: 0x04000230 RID: 560
		[CompilerGenerated]
		private bool <IgnoreSerializableAttribute>k__BackingField;

		// Token: 0x0200008B RID: 139
		internal class EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue> : IEnumerable<KeyValuePair<object, object>>, IEnumerable
		{
			// Token: 0x06000509 RID: 1289 RVA: 0x0000D45C File Offset: 0x0000B65C
			public EnumerableDictionaryWrapper(IEnumerable<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> e)
			{
				this._e = e;
			}

			// Token: 0x0600050A RID: 1290 RVA: 0x0000212A File Offset: 0x0000032A
			public IEnumerator<KeyValuePair<object, object>> GetEnumerator()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x0600050B RID: 1291 RVA: 0x0000212A File Offset: 0x0000032A
			IEnumerator IEnumerable.GetEnumerator()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x04000231 RID: 561
			private readonly IEnumerable<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> _e;

			// Token: 0x0200008C RID: 140
			[CompilerGenerated]
			private sealed class <GetEnumerator>d__2 : IEnumerator<KeyValuePair<object, object>>, IDisposable, IEnumerator
			{
				// Token: 0x0600050C RID: 1292 RVA: 0x0000A723 File Offset: 0x00008923
				[DebuggerHidden]
				public <GetEnumerator>d__2(int <>1__state)
				{
				}

				// Token: 0x0600050D RID: 1293 RVA: 0x0000A723 File Offset: 0x00008923
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				// Token: 0x0600050E RID: 1294 RVA: 0x0000D478 File Offset: 0x0000B678
				private bool MoveNext()
				{
					return default(bool);
				}

				// Token: 0x0600050F RID: 1295 RVA: 0x0000A723 File Offset: 0x00008923
				private void <>m__Finally1()
				{
				}

				// Token: 0x170000D4 RID: 212
				// (get) Token: 0x06000510 RID: 1296 RVA: 0x0000D490 File Offset: 0x0000B690
				KeyValuePair<object, object> IEnumerator<KeyValuePair<object, object>>.Current
				{
					[DebuggerHidden]
					get
					{
						return default(KeyValuePair<object, object>);
					}
				}

				// Token: 0x06000511 RID: 1297 RVA: 0x0000A723 File Offset: 0x00008923
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}

				// Token: 0x170000D5 RID: 213
				// (get) Token: 0x06000512 RID: 1298 RVA: 0x0000A5CC File Offset: 0x000087CC
				object IEnumerator.Current
				{
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				// Token: 0x04000232 RID: 562
				private int <>1__state;

				// Token: 0x04000233 RID: 563
				private KeyValuePair<object, object> <>2__current;

				// Token: 0x04000234 RID: 564
				public DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue> <>4__this;

				// Token: 0x04000235 RID: 565
				private IEnumerator<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> <>7__wrap1;
			}
		}

		// Token: 0x0200008D RID: 141
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000513 RID: 1299 RVA: 0x0000D4A8 File Offset: 0x0000B6A8
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06000514 RID: 1300 RVA: 0x0000D4B8 File Offset: 0x0000B6B8
			public <>c()
			{
			}

			// Token: 0x06000515 RID: 1301 RVA: 0x0000D4CC File Offset: 0x0000B6CC
			internal bool <GetSerializableMembers>b__30_0(MemberInfo m)
			{
				if (!true)
				{
				}
				return ReflectionUtils.IsIndexedProperty(m);
			}

			// Token: 0x06000516 RID: 1302 RVA: 0x0000D4E4 File Offset: 0x0000B6E4
			internal bool <GetSerializableMembers>b__30_1(MemberInfo m)
			{
				if (!true)
				{
				}
				return ReflectionUtils.IsIndexedProperty(m);
			}

			// Token: 0x06000517 RID: 1303 RVA: 0x0000212A File Offset: 0x0000032A
			internal IEnumerable<MemberInfo> <GetExtensionDataMemberForType>b__33_0(Type baseType)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06000518 RID: 1304 RVA: 0x0000D4FC File Offset: 0x0000B6FC
			internal bool <GetExtensionDataMemberForType>b__33_1(MemberInfo m)
			{
				MemberTypes memberTypes = m.MemberType();
				if (m == null)
				{
				}
				bool flag = ReflectionUtils.CanReadMemberValue(m, true);
				if (m == null)
				{
				}
				Type memberUnderlyingType = ReflectionUtils.GetMemberUnderlyingType(m);
				return true;
			}

			// Token: 0x06000519 RID: 1305 RVA: 0x0000D554 File Offset: 0x0000B754
			internal bool <GetAttributeConstructor>b__36_0(ConstructorInfo c)
			{
				/*
An exception occurred when decompiling this method (06000519)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Newtonsoft.Json.Serialization.DefaultContractResolver/<>c::<GetAttributeConstructor>b__36_0(System.Reflection.ConstructorInfo)

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

			// Token: 0x0600051A RID: 1306 RVA: 0x0000D564 File Offset: 0x0000B764
			internal int <CreateProperties>b__60_0(JsonProperty p)
			{
				/*
An exception occurred when decompiling this method (0600051A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Newtonsoft.Json.Serialization.DefaultContractResolver/<>c::<CreateProperties>b__60_0(Newtonsoft.Json.Serialization.JsonProperty)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:valuetype [mscorlib]System.Nullable`1<int32>(var_0_06, ldfld:valuetype [mscorlib]System.Nullable`1<int32>(JsonProperty::<Order>k__BackingField, ldloc:JsonProperty(p)))
	stloc:string(var_1_0D, ldfld:string(JsonProperty::<UnderlyingName>k__BackingField, ldloc:JsonProperty(p)))
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

			// Token: 0x04000236 RID: 566
			public static readonly DefaultContractResolver.<>c <>9;

			// Token: 0x04000237 RID: 567
			public static Func<MemberInfo, bool> <>9__30_0;

			// Token: 0x04000238 RID: 568
			public static Func<MemberInfo, bool> <>9__30_1;

			// Token: 0x04000239 RID: 569
			public static Func<Type, IEnumerable<MemberInfo>> <>9__33_0;

			// Token: 0x0400023A RID: 570
			public static Func<MemberInfo, bool> <>9__33_1;

			// Token: 0x0400023B RID: 571
			public static Func<ConstructorInfo, bool> <>9__36_0;

			// Token: 0x0400023C RID: 572
			public static Func<JsonProperty, int> <>9__60_0;
		}

		// Token: 0x0200008E RID: 142
		[CompilerGenerated]
		private sealed class <>c__DisplayClass34_0
		{
			// Token: 0x0600051B RID: 1307 RVA: 0x0000D580 File Offset: 0x0000B780
			public <>c__DisplayClass34_0()
			{
			}

			// Token: 0x0400023D RID: 573
			public Func<object, object> getExtensionDataDictionary;

			// Token: 0x0400023E RID: 574
			public MemberInfo member;
		}

		// Token: 0x0200008F RID: 143
		[CompilerGenerated]
		private sealed class <>c__DisplayClass34_1
		{
			// Token: 0x0600051C RID: 1308 RVA: 0x0000D594 File Offset: 0x0000B794
			public <>c__DisplayClass34_1()
			{
			}

			// Token: 0x0600051D RID: 1309 RVA: 0x0000D5A8 File Offset: 0x0000B7A8
			internal void <SetExtensionDataDelegates>b__0(object o, string key, object value)
			{
				/*
An exception occurred when decompiling this method (0600051D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Newtonsoft.Json.Serialization.DefaultContractResolver/<>c__DisplayClass34_1::<SetExtensionDataDelegates>b__0(System.Object,System.String,System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_003C:
	stloc:CultureInfo(var_5_44, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
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

			// Token: 0x0400023F RID: 575
			public Action<object, object> setExtensionDataDictionary;

			// Token: 0x04000240 RID: 576
			public Func<object> createExtensionDataDictionary;

			// Token: 0x04000241 RID: 577
			public MethodCall<object, object> setExtensionDataDictionaryValue;

			// Token: 0x04000242 RID: 578
			public DefaultContractResolver.<>c__DisplayClass34_0 CS$<>8__locals1;
		}

		// Token: 0x02000090 RID: 144
		[CompilerGenerated]
		private sealed class <>c__DisplayClass34_2
		{
			// Token: 0x0600051E RID: 1310 RVA: 0x0000D5FC File Offset: 0x0000B7FC
			public <>c__DisplayClass34_2()
			{
			}

			// Token: 0x0600051F RID: 1311 RVA: 0x0000D610 File Offset: 0x0000B810
			internal IEnumerable<KeyValuePair<object, object>> <SetExtensionDataDelegates>b__1(object o)
			{
				Func<object, object> getExtensionDataDictionary = this.CS$<>8__locals2.getExtensionDataDictionary;
				ObjectConstructor<object> objectConstructor = this.createEnumerableWrapper;
				throw new ArrayTypeMismatchException();
			}

			// Token: 0x04000243 RID: 579
			public ObjectConstructor<object> createEnumerableWrapper;

			// Token: 0x04000244 RID: 580
			public DefaultContractResolver.<>c__DisplayClass34_0 CS$<>8__locals2;
		}

		// Token: 0x02000091 RID: 145
		[CompilerGenerated]
		private sealed class <>c__DisplayClass64_0
		{
			// Token: 0x06000520 RID: 1312 RVA: 0x0000D63C File Offset: 0x0000B83C
			public <>c__DisplayClass64_0()
			{
			}

			// Token: 0x06000521 RID: 1313 RVA: 0x0000D650 File Offset: 0x0000B850
			internal bool <CreateShouldSerializeTest>b__0(object o)
			{
				MethodCall<object, object> methodCall = this.shouldSerializeCall;
				return true;
			}

			// Token: 0x04000245 RID: 581
			public MethodCall<object, object> shouldSerializeCall;
		}

		// Token: 0x02000092 RID: 146
		[CompilerGenerated]
		private sealed class <>c__DisplayClass65_0
		{
			// Token: 0x06000522 RID: 1314 RVA: 0x0000D670 File Offset: 0x0000B870
			public <>c__DisplayClass65_0()
			{
			}

			// Token: 0x06000523 RID: 1315 RVA: 0x0000D684 File Offset: 0x0000B884
			internal bool <SetIsSpecifiedActions>b__0(object o)
			{
				Func<object, object> func = this.specifiedPropertyGet;
				throw new InvalidCastException();
			}

			// Token: 0x04000246 RID: 582
			public Func<object, object> specifiedPropertyGet;
		}
	}
}
