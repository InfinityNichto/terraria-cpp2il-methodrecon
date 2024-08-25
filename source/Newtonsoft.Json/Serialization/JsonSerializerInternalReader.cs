using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2IlInjected;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000A8 RID: 168
	[Preserve]
	internal class JsonSerializerInternalReader : JsonSerializerInternalBase
	{
		// Token: 0x06000607 RID: 1543 RVA: 0x0000F188 File Offset: 0x0000D388
		public JsonSerializerInternalReader(JsonSerializer serializer)
			: base(serializer)
		{
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x0000F19C File Offset: 0x0000D39C
		public void Populate(JsonReader reader, object target)
		{
			ValidationUtils.ArgumentNotNull(target, "target");
			Type type = target.GetType();
			IContractResolver contractResolver = this.Serializer._contractResolver;
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x0000F238 File Offset: 0x0000D438
		private JsonContract GetContractSafe(Type type)
		{
			/*
An exception occurred when decompiling this method (06000609)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Newtonsoft.Json.Serialization.JsonContract Newtonsoft.Json.Serialization.JsonSerializerInternalReader::GetContractSafe(System.Type)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000F:
	stloc:int64(var_1_15, ldfld:int64(int64::m_value, ldc.i4:int32[exp:int64&](0)))
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

		// Token: 0x0600060A RID: 1546 RVA: 0x0000F25C File Offset: 0x0000D45C
		public object Deserialize(JsonReader reader, Type objectType, bool checkAdditionalContent)
		{
			JsonContract contractSafe;
			bool isNullable;
			if (reader != null)
			{
				contractSafe = this.GetContractSafe(objectType);
				if (contractSafe != null)
				{
					if (contractSafe.<Converter>k__BackingField != null)
					{
						goto IL_0037;
					}
					JsonSerializer serializer = this.Serializer;
					Type <UnderlyingType>k__BackingField = contractSafe.<UnderlyingType>k__BackingField;
					if (serializer.GetMatchingConverter(<UnderlyingType>k__BackingField) != null)
					{
						goto IL_0037;
					}
					JsonConverter <InternalConverter>k__BackingField = contractSafe.<InternalConverter>k__BackingField;
				}
				long num = 0L;
				IL_0037:
				if (reader == null)
				{
				}
				if (num != 0L)
				{
					object obj;
					return obj;
				}
				if (contractSafe != null)
				{
					isNullable = contractSafe.IsNullable;
					if (isNullable)
					{
					}
				}
			}
			if (!isNullable)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			Type <UnderlyingType>k__BackingField2 = contractSafe.<UnderlyingType>k__BackingField;
			string text = "No JSON content found and type '{0}' is not nullable.".FormatWith(invariantCulture, <UnderlyingType>k__BackingField2);
			JsonSerializationException ex = JsonSerializationException.Create(reader, text);
			throw new OutOfMemoryException();
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x0000F2F4 File Offset: 0x0000D4F4
		private JsonSerializerProxy GetInternalSerializer()
		{
			/*
An exception occurred when decompiling this method (0600060B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Newtonsoft.Json.Serialization.JsonSerializerProxy Newtonsoft.Json.Serialization.JsonSerializerInternalReader::GetInternalSerializer()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:JsonSerializerProxy[exp:bool](JsonSerializerInternalBase::InternalSerializer, ldloc:JsonSerializerInternalReader[exp:JsonSerializerInternalBase](this)))
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

		// Token: 0x0600060C RID: 1548 RVA: 0x0000F308 File Offset: 0x0000D508
		private JToken CreateJToken(JsonReader reader, JsonContract contract)
		{
			ValidationUtils.ArgumentNotNull(reader, "reader");
			if (contract != null)
			{
				Type <UnderlyingType>k__BackingField = contract.<UnderlyingType>k__BackingField;
				Type <UnderlyingType>k__BackingField2 = contract.<UnderlyingType>k__BackingField;
				Type <UnderlyingType>k__BackingField3 = contract.<UnderlyingType>k__BackingField;
			}
			if (!false)
			{
				JToken jtoken;
				return jtoken;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x0000F360 File Offset: 0x0000D560
		private JToken CreateJObject(JsonReader reader)
		{
			ValidationUtils.ArgumentNotNull(reader, "reader");
			if (reader != null)
			{
			}
			bool flag = reader.ReadAndMoveToContent();
			JsonSerializationException ex = JsonSerializationException.Create(reader, "Unexpected end when deserializing object.");
			if (!false)
			{
				JToken jtoken;
				return jtoken;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x0000F3B4 File Offset: 0x0000D5B4
		private object CreateValueInternal(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue)
		{
			if (contract != null)
			{
				JsonContractType contractType = contract.ContractType;
			}
			return "Unexpected end when deserializing object.";
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x0000F41C File Offset: 0x0000D61C
		private static bool CoerceEmptyStringToNull(Type objectType, JsonContract contract, string s)
		{
			/*
An exception occurred when decompiling this method (0600060F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Newtonsoft.Json.Serialization.JsonSerializerInternalReader::CoerceEmptyStringToNull(System.Type,Newtonsoft.Json.Serialization.JsonContract,System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:RuntimeTypeHandle(var_4_0B, ldfld:RuntimeTypeHandle(Type::_impl, ldloc:Type(objectType)))
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

		// Token: 0x06000610 RID: 1552 RVA: 0x0000F438 File Offset: 0x0000D638
		internal string GetExpectedDescription(JsonContract contract)
		{
			JsonContractType contractType = contract.ContractType;
			return "JSON object (e.g. {\"name\":\"value\"})";
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x0000F454 File Offset: 0x0000D654
		private JsonConverter GetConverter(JsonContract contract, JsonConverter memberConverter, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
			while (memberConverter == null)
			{
				if ((containerProperty == null || containerProperty.<ItemConverter>k__BackingField == null) && (containerContract == null || containerContract.<ItemConverter>k__BackingField == null))
				{
					if (contract == null)
					{
						JsonConverter <InternalConverter>k__BackingField;
						return <InternalConverter>k__BackingField;
					}
					if (contract.<Converter>k__BackingField == null)
					{
						Type <UnderlyingType>k__BackingField = contract.<UnderlyingType>k__BackingField;
						JsonConverter jsonConverter;
						while (jsonConverter != null)
						{
						}
						JsonConverter <InternalConverter>k__BackingField = contract.<InternalConverter>k__BackingField;
						return <InternalConverter>k__BackingField;
					}
				}
			}
			return memberConverter;
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x0000F4A0 File Offset: 0x0000D6A0
		private object CreateObject(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue)
		{
			JsonSerializer serializer = this.Serializer;
			reader.ReadAndAssert();
			JToken jtoken = this.CreateJObject(reader);
			JsonSerializer serializer2 = this.Serializer;
			if (reader != null)
			{
			}
			JsonReader jsonReader = JToken.ReadFrom(reader).CreateReader();
			if (jsonReader != null)
			{
			}
			CultureInfo culture = reader.Culture;
			jsonReader._culture = culture;
			string dateFormatString = reader._dateFormatString;
			jsonReader._dateFormatString = dateFormatString;
			DateParseHandling dateParseHandling = reader._dateParseHandling;
			jsonReader.DateParseHandling = dateParseHandling;
			DateTimeZoneHandling dateTimeZoneHandling = reader._dateTimeZoneHandling;
			jsonReader.DateTimeZoneHandling = dateTimeZoneHandling;
			FloatParseHandling floatParseHandling = reader._floatParseHandling;
			jsonReader.FloatParseHandling = floatParseHandling;
			bool <SupportMultipleContent>k__BackingField = reader.<SupportMultipleContent>k__BackingField;
			jsonReader.<SupportMultipleContent>k__BackingField = <SupportMultipleContent>k__BackingField;
			jsonReader.ReadAndAssert();
			if (jtoken != null)
			{
				Type type = jtoken.GetType();
			}
			object obj;
			return obj;
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x0000F698 File Offset: 0x0000D898
		private bool ReadMetadataPropertiesToken(JTokenReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, [Out] object newValue, [Out] string id)
		{
			/*
An exception occurred when decompiling this method (06000613)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Newtonsoft.Json.Serialization.JsonSerializerInternalReader::ReadMetadataPropertiesToken(Newtonsoft.Json.Linq.JTokenReader,System.Type,Newtonsoft.Json.Serialization.JsonContract,Newtonsoft.Json.Serialization.JsonProperty,Newtonsoft.Json.Serialization.JsonContainerContract,Newtonsoft.Json.Serialization.JsonProperty,System.Object,System.Object,System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00EB:
	stloc:CultureInfo(var_23_F3, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
	stloc:string(var_24_106, call:string(StringUtils::FormatWith, ldstr:string("Additional content found in JSON reference object. A JSON reference object should only have a {0} property."), ldloc:CultureInfo[exp:IFormatProvider](var_23_F3), ldstr:string[exp:object]("$ref")))
	stloc:CultureInfo(var_27_110, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
	stloc:string(var_28_123, call:string(StringUtils::FormatWith, ldstr:string("JSON reference {0} property must have a string or null value."), ldloc:CultureInfo[exp:IFormatProvider](var_27_110), ldstr:string[exp:object]("$ref")))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

		// Token: 0x06000614 RID: 1556 RVA: 0x0000F7CC File Offset: 0x0000D9CC
		private bool ReadMetadataProperties(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, [Out] object newValue, [Out] string id)
		{
			reader.ReadAndAssert();
			if (reader != null)
			{
				reader.ReadAndAssert();
				if (reader == null)
				{
					goto IL_0029;
				}
				reader.ReadAndAssert();
				reader.ReadAndAssert();
				if (reader != null)
				{
				}
			}
			reader.ReadAndAssert();
			IL_0029:
			IReferenceResolver referenceResolver = this.Serializer.GetReferenceResolver();
			reader.ReadAndAssert();
			reader.ReadAndAssert();
			if (referenceResolver != null)
			{
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
				Type type;
				string text = "Resolved object reference '{0}' to {1}.".FormatWith(invariantCulture, reader, type);
			}
			CultureInfo invariantCulture2 = CultureInfo.InvariantCulture;
			string text2 = "JSON reference {0} property must have a string or null value.".FormatWith(invariantCulture2, "$ref");
			CultureInfo invariantCulture3 = CultureInfo.InvariantCulture;
			return "Additional content found in JSON reference object. A JSON reference object should only have a {0} property." != null;
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x0000F86C File Offset: 0x0000DA6C
		private void ResolveTypeName(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, string qualifiedTypeName)
		{
			if (member != null)
			{
				TypeNameHandling? <TypeNameHandling>k__BackingField = member.<TypeNameHandling>k__BackingField;
				if (<TypeNameHandling>k__BackingField != null)
				{
					if (<TypeNameHandling>k__BackingField == null)
					{
						return;
					}
					goto IL_0046;
				}
			}
			if (containerContract != null)
			{
				TypeNameHandling? <ItemTypeNameHandling>k__BackingField = containerContract.<ItemTypeNameHandling>k__BackingField;
				if (<ItemTypeNameHandling>k__BackingField != null)
				{
					if (<ItemTypeNameHandling>k__BackingField == null)
					{
						return;
					}
					goto IL_0046;
				}
			}
			if (containerMember != null)
			{
				TypeNameHandling? <ItemTypeNameHandling>k__BackingField2 = containerMember.<ItemTypeNameHandling>k__BackingField;
				if (<ItemTypeNameHandling>k__BackingField2 != null)
				{
					if (<ItemTypeNameHandling>k__BackingField2 == null)
					{
						return;
					}
					goto IL_0046;
				}
			}
			if (this.Serializer._typeNameHandling == TypeNameHandling.None)
			{
				return;
			}
			IL_0046:
			SerializationBinder binder = this.Serializer._binder;
			if (binder == null)
			{
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
				string text2;
				string text = "Type specified in JSON '{0}' was not resolved.".FormatWith(invariantCulture, text2);
				return;
			}
			if (this.TraceWriter != null)
			{
				return;
			}
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x0000F948 File Offset: 0x0000DB48
		private JsonArrayContract EnsureArrayContract(JsonReader reader, Type objectType, JsonContract contract)
		{
			/*
An exception occurred when decompiling this method (06000616)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Newtonsoft.Json.Serialization.JsonArrayContract Newtonsoft.Json.Serialization.JsonSerializerInternalReader::EnsureArrayContract(Newtonsoft.Json.JsonReader,System.Type,Newtonsoft.Json.Serialization.JsonContract)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_003E:
	stloc:CultureInfo(var_10_46, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
	stloc:string(var_11_55, call:string(StringUtils::FormatWith, ldstr:string("Could not resolve type '{0}' to a JsonContract."), ldloc:CultureInfo[exp:IFormatProvider](var_10_46), ldloc:Type[exp:object](objectType)))
	stloc:JsonSerializationException(var_12_5F, call:JsonSerializationException(JsonSerializationException::Create, ldloc:JsonReader(reader), ldloc:string(var_11_55)))
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

		// Token: 0x06000617 RID: 1559 RVA: 0x0000F9B8 File Offset: 0x0000DBB8
		private object CreateList(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, object existingValue, string id)
		{
			JsonArrayContract jsonArrayContract;
			CultureInfo invariantCulture;
			if (existingValue != null)
			{
				if (!jsonArrayContract.<CanDeserialize>k__BackingField)
				{
					invariantCulture = CultureInfo.InvariantCulture;
					return "Cannot populate list type {0}.";
				}
				if (!jsonArrayContract.<ShouldCreateWrapper>k__BackingField)
				{
					goto IL_002F;
				}
				IWrappedCollection wrappedCollection = jsonArrayContract.CreateWrapper(existingValue);
			}
			if (id != null)
			{
				CultureInfo invariantCulture2 = CultureInfo.InvariantCulture;
				string iso3lang = invariantCulture.iso3lang;
				return "Cannot preserve reference to array or readonly list, or list created from a non-default constructor: {0}.";
			}
			IList<SerializationCallback> onSerializingCallbacks = contract.OnSerializingCallbacks;
			IL_002F:
			IList list;
			if (list != null)
			{
				return this.PopulateList(list, reader, jsonArrayContract, member, id);
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x0000FB2C File Offset: 0x0000DD2C
		private bool HasNoDefinedType(JsonContract contract)
		{
			if (contract != null)
			{
				Type <UnderlyingType>k__BackingField = contract.<UnderlyingType>k__BackingField;
				JsonContractType contractType = contract.ContractType;
			}
			return true;
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x0000FB4C File Offset: 0x0000DD4C
		private object EnsureType(JsonReader reader, object value, CultureInfo culture, JsonContract contract, Type targetType)
		{
			while (targetType != null)
			{
				Type objectType = ReflectionUtils.GetObjectType(value);
				if (value != null)
				{
					if (!contract.IsConvertable)
					{
						break;
					}
					if (contract.IsEnum)
					{
						if (value != null)
						{
						}
						object obj = Enum.ToObject(contract.NonNullableUnderlyingType, value);
						return obj;
					}
					Type nonNullableUnderlyingType = contract.NonNullableUnderlyingType;
					object obj2;
					return obj2;
				}
				else if (contract.IsNullable)
				{
					object obj;
					return obj;
				}
			}
			object obj3;
			return obj3;
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x0000FBF8 File Offset: 0x0000DDF8
		private bool SetPropertyValue(JsonProperty property, JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target)
		{
			/*
An exception occurred when decompiling this method (0600061A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Newtonsoft.Json.Serialization.JsonSerializerInternalReader::SetPropertyValue(Newtonsoft.Json.Serialization.JsonProperty,Newtonsoft.Json.JsonConverter,Newtonsoft.Json.Serialization.JsonContainerContract,Newtonsoft.Json.Serialization.JsonProperty,Newtonsoft.Json.JsonReader,System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_007C:
	stloc:class [mscorlib]System.Action`2<object, object>(var_15_82, ldfld:class [mscorlib]System.Action`2<object, object>(JsonProperty::<SetIsSpecified>k__BackingField, ldloc:JsonProperty(property)))
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

		// Token: 0x0600061B RID: 1563 RVA: 0x0000FC8C File Offset: 0x0000DE8C
		private bool CalculatePropertyDetails(JsonProperty property, JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target, [Out] bool useExistingValue, [Out] object currentValue, [Out] JsonContract propertyContract, [Out] bool gottenCurrentValue)
		{
			/*
An exception occurred when decompiling this method (0600061B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Newtonsoft.Json.Serialization.JsonSerializerInternalReader::CalculatePropertyDetails(Newtonsoft.Json.Serialization.JsonProperty,Newtonsoft.Json.JsonConverter,Newtonsoft.Json.Serialization.JsonContainerContract,Newtonsoft.Json.Serialization.JsonProperty,Newtonsoft.Json.JsonReader,System.Object,System.Boolean,System.Object,Newtonsoft.Json.Serialization.JsonContract,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_010C:
	stloc:JsonContract(var_24_112, ldfld:JsonContract(JsonProperty::<PropertyContract>k__BackingField, ldloc:JsonProperty(property)))
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

		// Token: 0x0600061C RID: 1564 RVA: 0x0000FDB0 File Offset: 0x0000DFB0
		private void AddReference(JsonReader reader, string id, object value)
		{
			if (this.TraceWriter != null)
			{
				return;
			}
			IReferenceResolver referenceResolver = this.Serializer.GetReferenceResolver();
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x0000212A File Offset: 0x0000032A
		private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x0000FE20 File Offset: 0x0000E020
		private bool ShouldSetPropertyValue(JsonProperty property, object value)
		{
			NullValueHandling? <NullValueHandling>k__BackingField = property.<NullValueHandling>k__BackingField;
			NullValueHandling nullValueHandling = this.Serializer._nullValueHandling;
			if (value == null)
			{
			}
			DefaultValueHandling? <DefaultValueHandling>k__BackingField = property.<DefaultValueHandling>k__BackingField;
			DefaultValueHandling defaultValueHandling = this.Serializer._defaultValueHandling;
			DefaultValueHandling? <DefaultValueHandling>k__BackingField2 = property.<DefaultValueHandling>k__BackingField;
			DefaultValueHandling defaultValueHandling2 = this.Serializer._defaultValueHandling;
			object resolvedDefaultValue = property.GetResolvedDefaultValue();
			bool flag = MiscellaneousUtils.ValueEquals(value, resolvedDefaultValue);
			bool <Writable>k__BackingField = property.<Writable>k__BackingField;
			return flag;
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x0000FE8C File Offset: 0x0000E08C
		private IList CreateNewList(JsonReader reader, JsonArrayContract contract, [Out] bool createdFromNonDefaultCreator)
		{
			if (contract.<CanDeserialize>k__BackingField)
			{
				if (contract._overrideCreator != null)
				{
					if (contract.<HasParameterizedCreator>k__BackingField)
					{
						createdFromNonDefaultCreator.m_value = true;
						return contract.CreateTemporaryCollection();
					}
					goto IL_0047;
				}
				else
				{
					if (!contract.IsReadOnlyOrFixedSize)
					{
						goto IL_0050;
					}
					createdFromNonDefaultCreator.m_value = true;
					IList list = contract.CreateTemporaryCollection();
					if (contract.<ShouldCreateWrapper>k__BackingField)
					{
						goto IL_0047;
					}
				}
				IL_008A:
				bool <ShouldCreateWrapper>k__BackingField;
				while (<ShouldCreateWrapper>k__BackingField)
				{
				}
				while (<ShouldCreateWrapper>k__BackingField)
				{
				}
				while (<ShouldCreateWrapper>k__BackingField)
				{
				}
				if (!<ShouldCreateWrapper>k__BackingField)
				{
				}
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
				if (this == null)
				{
					return "Could not create an instance of type {0}. Type is an interface or abstract class and cannot be instantiated.";
				}
				goto IL_00B7;
				IL_0047:
				ObjectConstructor<object> overrideCreator = contract._overrideCreator;
				IL_0050:
				if (contract.<DefaultCreator>k__BackingField == null)
				{
					goto IL_008A;
				}
				if (contract.<DefaultCreatorNonPublic>k__BackingField)
				{
					ConstructorHandling constructorHandling = this.Serializer._constructorHandling;
				}
				<ShouldCreateWrapper>k__BackingField = contract.<ShouldCreateWrapper>k__BackingField;
				if (<ShouldCreateWrapper>k__BackingField)
				{
				}
				IWrappedCollection wrappedCollection;
				if (wrappedCollection == null)
				{
					goto IL_008A;
				}
				if (wrappedCollection == null)
				{
					throw new InvalidCastException();
				}
				goto IL_008A;
			}
			else
			{
				CultureInfo invariantCulture2 = CultureInfo.InvariantCulture;
			}
			IL_00B7:
			return "Unable to find a constructor to use for type {0}.";
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x0000FF58 File Offset: 0x0000E158
		private IDictionary CreateNewDictionary(JsonReader reader, JsonDictionaryContract contract, [Out] bool createdFromNonDefaultCreator)
		{
			for (;;)
			{
				if (contract._overrideCreator != null)
				{
					if (contract.<HasParameterizedCreator>k__BackingField)
					{
						break;
					}
					ObjectConstructor<object> overrideCreator = contract._overrideCreator;
				}
				if (contract.IsReadOnlyOrFixedSize)
				{
					break;
				}
				bool <ShouldCreateWrapper>k__BackingField;
				if (contract.<DefaultCreator>k__BackingField != null)
				{
					if (contract.<DefaultCreatorNonPublic>k__BackingField)
					{
						ConstructorHandling constructorHandling = this.Serializer._constructorHandling;
					}
					<ShouldCreateWrapper>k__BackingField = contract.<ShouldCreateWrapper>k__BackingField;
					if (<ShouldCreateWrapper>k__BackingField)
					{
					}
					IWrappedDictionary wrappedDictionary;
					if (wrappedDictionary == null)
					{
						goto IL_007C;
					}
					if (wrappedDictionary == null)
					{
						goto IL_007F;
					}
				}
				while (<ShouldCreateWrapper>k__BackingField)
				{
				}
				while (<ShouldCreateWrapper>k__BackingField)
				{
				}
				while (<ShouldCreateWrapper>k__BackingField)
				{
				}
				if (!<ShouldCreateWrapper>k__BackingField)
				{
				}
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
				if (this == null)
				{
					goto Block_6;
				}
			}
			createdFromNonDefaultCreator.m_value = true;
			return contract.CreateTemporaryDictionary();
			Block_6:
			return "Could not create an instance of type {0}. Type is an interface or abstract class and cannot be instantiated.";
			IL_007C:
			IL_007F:
			throw new InvalidCastException();
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x0000FFEC File Offset: 0x0000E1EC
		private void OnDeserializing(JsonReader reader, JsonContract contract, object value)
		{
			if (this.TraceWriter != null)
			{
				return;
			}
			JsonSerializer serializer = this.Serializer;
			StreamingContext context = serializer._context;
			StreamingContextStates state = serializer._context.m_state;
			contract.InvokeOnDeserializing(value, context);
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00010050 File Offset: 0x0000E250
		private void OnDeserialized(JsonReader reader, JsonContract contract, object value)
		{
			if (this.TraceWriter != null)
			{
				return;
			}
			JsonSerializer serializer = this.Serializer;
			StreamingContext context = serializer._context;
			StreamingContextStates state = serializer._context.m_state;
			contract.InvokeOnDeserialized(value, context);
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x000100B4 File Offset: 0x0000E2B4
		private object PopulateDictionary(IDictionary dictionary, JsonReader reader, JsonDictionaryContract contract, JsonProperty containerProperty, string id)
		{
			if (dictionary != null)
			{
			}
			if (id != null)
			{
			}
			if (contract.<KeyContract>k__BackingField == null)
			{
				Type <DictionaryKeyType>k__BackingField = contract.<DictionaryKeyType>k__BackingField;
				JsonContract contractSafe = this.GetContractSafe(<DictionaryKeyType>k__BackingField);
				contract.<KeyContract>k__BackingField = contractSafe;
			}
			if (contract._itemContract == null)
			{
				Type <DictionaryValueType>k__BackingField = contract.<DictionaryValueType>k__BackingField;
				JsonContract contractSafe2 = this.GetContractSafe(<DictionaryValueType>k__BackingField);
				contract.ItemContract = contractSafe2;
			}
			if (contract.<ItemConverter>k__BackingField == null)
			{
				JsonContract itemContract = contract._itemContract;
			}
			if (contract.<KeyContract>k__BackingField != null)
			{
			}
			DateTimeZoneHandling dateTimeZoneHandling = reader._dateTimeZoneHandling;
			string dateFormatString = reader._dateFormatString;
			CultureInfo culture = reader.Culture;
			string dateFormatString2 = reader._dateFormatString;
			CultureInfo culture2 = reader.Culture;
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			JsonContract <KeyContract>k__BackingField = contract.<KeyContract>k__BackingField;
			Type <DictionaryKeyType>k__BackingField2 = contract.<DictionaryKeyType>k__BackingField;
			object obj;
			return obj;
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x0000212A File Offset: 0x0000032A
		private object PopulateMultidimensionalArray(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00010214 File Offset: 0x0000E414
		private void ThrowUnexpectedEndException(JsonReader reader, JsonContract contract, object currentObject, string message)
		{
			JsonSerializationException ex = JsonSerializationException.Create(reader, message);
			base.ClearErrorContext();
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00010238 File Offset: 0x0000E438
		private object PopulateList(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id)
		{
			JsonConverter jsonConverter;
			for (;;)
			{
				if (list != null)
				{
				}
				if (id != null)
				{
				}
				reader.Skip();
				if (contract._itemContract == null)
				{
					Type <CollectionItemType>k__BackingField = contract.<CollectionItemType>k__BackingField;
					JsonContract contractSafe = this.GetContractSafe(<CollectionItemType>k__BackingField);
					contract.ItemContract = contractSafe;
					JsonContract itemContract = contract._itemContract;
				}
				JsonContract itemContract2 = contract._itemContract;
				if (jsonConverter != null)
				{
					break;
				}
				Type <CollectionItemType>k__BackingField2 = contract.<CollectionItemType>k__BackingField;
				JsonContract itemContract3 = contract._itemContract;
				if (reader == null)
				{
					goto Block_2;
				}
			}
			Type <CollectionItemType>k__BackingField3 = contract.<CollectionItemType>k__BackingField;
			long num = 0L;
			return this.DeserializeConvertable(jsonConverter, reader, <CollectionItemType>k__BackingField3, num);
			Block_2:
			throw new OutOfMemoryException();
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x000102B8 File Offset: 0x0000E4B8
		private object CreateISerializable(JsonReader reader, JsonISerializableContract contract, JsonProperty member, string id)
		{
			/*
An exception occurred when decompiling this method (06000627)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object Newtonsoft.Json.Serialization.JsonSerializerInternalReader::CreateISerializable(Newtonsoft.Json.JsonReader,Newtonsoft.Json.Serialization.JsonISerializableContract,Newtonsoft.Json.Serialization.JsonProperty,System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00D0:
	stloc:CultureInfo(var_26_D8, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
	stloc:string(var_27_E8, call:string(StringUtils::FormatWith, ldstr:string("ISerializable type '{0}' does not have a valid constructor. To correctly implement ISerializable a constructor that takes SerializationInfo and StreamingContext parameters should be present."), ldloc:CultureInfo[exp:IFormatProvider](var_26_D8), ldloc:class Newtonsoft.Json.Serialization.ObjectConstructor`1<object>[exp:object](var_12_68)))
	stloc:JsonSerializationException(var_28_F2, call:JsonSerializationException(JsonSerializationException::Create, ldloc:JsonReader(reader), ldloc:string(var_27_E8)))
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

		// Token: 0x06000628 RID: 1576 RVA: 0x000103B8 File Offset: 0x0000E5B8
		internal object CreateISerializableItem(JToken token, Type type, JsonISerializableContract contract, JsonProperty member)
		{
			JsonContract contractSafe = this.GetContractSafe(type);
			JsonReader jsonReader = token.CreateReader();
			jsonReader.ReadAndAssert();
			JsonConverter jsonConverter;
			if (jsonConverter != null)
			{
				long num = 0L;
				return this.DeserializeConvertable(jsonConverter, jsonReader, type, num);
			}
			object obj;
			return obj;
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x0000212A File Offset: 0x0000032A
		private object CreateObjectUsingCreatorWithParameters(JsonReader reader, JsonObjectContract contract, JsonProperty containerProperty, ObjectConstructor<object> creator, string id)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x000103EC File Offset: 0x0000E5EC
		private object DeserializeConvertable(JsonConverter converter, JsonReader reader, Type objectType, object existingValue)
		{
			/*
An exception occurred when decompiling this method (0600062A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object Newtonsoft.Json.Serialization.JsonSerializerInternalReader::DeserializeConvertable(Newtonsoft.Json.JsonConverter,Newtonsoft.Json.JsonReader,System.Type,System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_1:
	stloc:ITraceWriter(var_7_43, ldfld:ITraceWriter(JsonSerializerInternalBase::TraceWriter, ldloc:JsonSerializerInternalReader[exp:JsonSerializerInternalBase](this)))
	stloc:CultureInfo(var_9_4D, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
	stloc:Type(var_10_55, call:Type(object::GetType, ldloc:JsonConverter[exp:object](converter)))
	stloc:string(var_11_66, call:string(StringUtils::FormatWith, ldstr:string("Finished deserializing {0} with converter {1}."), ldloc:CultureInfo[exp:IFormatProvider](var_9_4D), ldloc:Type[exp:object](objectType), ldloc:Type[exp:object](var_10_55)))
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

		// Token: 0x0600062B RID: 1579 RVA: 0x00010460 File Offset: 0x0000E660
		private List<JsonSerializerInternalReader.CreatorPropertyContext> ResolvePropertyAndCreatorValues(JsonObjectContract contract, JsonProperty containerProperty, JsonReader reader, Type objectType)
		{
			/*
An exception occurred when decompiling this method (0600062B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.List`1<Newtonsoft.Json.Serialization.JsonSerializerInternalReader/CreatorPropertyContext> Newtonsoft.Json.Serialization.JsonSerializerInternalReader::ResolvePropertyAndCreatorValues(Newtonsoft.Json.Serialization.JsonObjectContract,Newtonsoft.Json.Serialization.JsonProperty,Newtonsoft.Json.JsonReader,System.Type)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_005A:
	call:void(JsonReader::Skip, ldloc:JsonReader(reader))
	stloc:CultureInfo(var_19_68, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
	stloc:string(var_20_77, call:string(StringUtils::FormatWith, ldstr:string("Unexpected end when setting {0}'s value."), ldloc:CultureInfo[exp:IFormatProvider](var_19_68), ldloc:JsonReader[exp:object](reader)))
	stloc:CultureInfo(var_22_81, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
	stloc:string(var_23_92, call:string(StringUtils::FormatWith, ldstr:string("Could not find member '{0}' on object of type '{1}'"), ldloc:CultureInfo[exp:IFormatProvider](var_22_81), ldloc:JsonReader[exp:object](reader), ldloc:Type[exp:object](objectType)))
	stloc:JsonSerializationException(var_24_9C, call:JsonSerializationException(JsonSerializationException::Create, ldloc:JsonReader(reader), ldloc:string(var_23_92)))
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

		// Token: 0x0600062C RID: 1580 RVA: 0x0001050C File Offset: 0x0000E70C
		private bool ReadForType(JsonReader reader, JsonContract contract, bool hasConverter)
		{
			if (contract != null)
			{
				ReadType internalReadType = contract.InternalReadType;
			}
			return reader.ReadAndMoveToContent();
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x00010538 File Offset: 0x0000E738
		public object CreateNewObject(JsonReader reader, JsonObjectContract objectContract, JsonProperty containerMember, JsonProperty containerProperty, string id, [Out] bool createdFromNonDefaultCreator)
		{
			/*
An exception occurred when decompiling this method (0600062D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object Newtonsoft.Json.Serialization.JsonSerializerInternalReader::CreateNewObject(Newtonsoft.Json.JsonReader,Newtonsoft.Json.Serialization.JsonObjectContract,Newtonsoft.Json.Serialization.JsonProperty,Newtonsoft.Json.Serialization.JsonProperty,System.String,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0096:
	stloc:string(var_11_A4, call:string(StringUtils::FormatWith, ldstr:string("Unable to find a constructor to use for type {0}. A class should either have a default constructor, one constructor with arguments or a constructor marked with the JsonConstructor attribute."), ldloc:CultureInfo[exp:IFormatProvider](var_9_82), ldloc:Type[exp:object](var_10_8A)))
	stloc:JsonSerializationException(var_12_AE, call:JsonSerializationException(JsonSerializationException::Create, ldloc:JsonReader(reader), ldloc:string(var_11_A4)))
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

		// Token: 0x0600062E RID: 1582 RVA: 0x000105F4 File Offset: 0x0000E7F4
		private object PopulateObject(object newObject, JsonReader reader, JsonObjectContract contract, JsonProperty member, string id)
		{
			this.OnDeserializing(reader, contract, newObject);
			bool hasRequiredOrDefaultValueProperties = contract.HasRequiredOrDefaultValueProperties;
			DefaultValueHandling defaultValueHandling = this.Serializer._defaultValueHandling;
			JsonPropertyCollection <Properties>k__BackingField;
			if (id == null)
			{
				<Properties>k__BackingField = contract.<Properties>k__BackingField;
				if (defaultValueHandling == DefaultValueHandling.Include)
				{
				}
				if (defaultValueHandling == DefaultValueHandling.Include)
				{
				}
				if (defaultValueHandling == DefaultValueHandling.Include)
				{
				}
				if (defaultValueHandling == DefaultValueHandling.Include)
				{
				}
				if (id == null)
				{
					goto IL_0041;
				}
			}
			this.AddReference(reader, id, newObject);
			IL_0041:
			JsonPropertyCollection <Properties>k__BackingField2 = contract.<Properties>k__BackingField;
			JsonProperty jsonProperty;
			if (jsonProperty != null && !jsonProperty.<Ignored>k__BackingField)
			{
				bool flag = this.ShouldDeserialize(reader, jsonProperty, newObject);
				JsonContract contractSafe;
				if (jsonProperty.<PropertyContract>k__BackingField == null)
				{
					Type propertyType = jsonProperty._propertyType;
					contractSafe = this.GetContractSafe(propertyType);
					jsonProperty.<PropertyContract>k__BackingField = contractSafe;
				}
				JsonConverter <MemberConverter>k__BackingField = jsonProperty.<MemberConverter>k__BackingField;
				JsonConverter converter = this.GetConverter(contractSafe, <MemberConverter>k__BackingField, contract, member);
				JsonContract <PropertyContract>k__BackingField = jsonProperty.<PropertyContract>k__BackingField;
				bool flag2 = this.SetPropertyValue(jsonProperty, converter, contract, member, reader, newObject);
			}
			if (this.TraceWriter != null)
			{
				ITraceWriter traceWriter = this.TraceWriter;
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
				Type <UnderlyingType>k__BackingField = contract.<UnderlyingType>k__BackingField;
				string text = "Could not find member '{0}' on {1}".FormatWith(invariantCulture, reader, <UnderlyingType>k__BackingField);
			}
			MissingMemberHandling missingMemberHandling = this.Serializer._missingMemberHandling;
			CultureInfo invariantCulture2 = CultureInfo.InvariantCulture;
			Type <UnderlyingType>k__BackingField2 = contract.<UnderlyingType>k__BackingField;
			string text2 = "Could not find member '{0}' on object of type '{1}'".FormatWith(invariantCulture2, reader, <UnderlyingType>k__BackingField2);
			JsonSerializationException ex = JsonSerializationException.Create(reader, text2);
			CultureInfo invariantCulture3 = CultureInfo.InvariantCulture;
			string text3 = "Unexpected end when setting {0}'s value.".FormatWith(invariantCulture3, reader);
			JsonSerializationException ex2 = JsonSerializationException.Create(reader, text3);
			this.ThrowUnexpectedEndException(reader, contract, newObject, "Unexpected end when deserializing object.");
			if (<Properties>k__BackingField != null)
			{
			}
			this.OnDeserialized(reader, contract, newObject);
			return newObject;
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x0001078C File Offset: 0x0000E98C
		private bool ShouldDeserialize(JsonReader reader, JsonProperty property, object target)
		{
			/*
An exception occurred when decompiling this method (0600062F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Newtonsoft.Json.Serialization.JsonSerializerInternalReader::ShouldDeserialize(Newtonsoft.Json.JsonReader,Newtonsoft.Json.Serialization.JsonProperty,System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0010:
	stloc:ITraceWriter(var_0_16, ldfld:ITraceWriter(JsonSerializerInternalBase::TraceWriter, ldloc:JsonSerializerInternalReader[exp:JsonSerializerInternalBase](this)))
	stloc:CultureInfo(var_2_1E, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
	stloc:string(var_3_25, ldfld:string(JsonProperty::_propertyName, ldloc:JsonProperty(property)))
	stloc:Type(var_4_2C, ldfld:Type(JsonProperty::<DeclaringType>k__BackingField, ldloc:JsonProperty(property)))
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

		// Token: 0x06000630 RID: 1584 RVA: 0x000107CC File Offset: 0x0000E9CC
		private bool CheckPropertyName(JsonReader reader, string memberName)
		{
			JsonSerializer serializer = this.Serializer;
			bool flag = memberName == "$id";
			bool flag2 = memberName == "$ref";
			bool flag3 = memberName == "$type";
			bool flag4 = memberName == "$values";
			reader.Skip();
			return true;
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x0001081C File Offset: 0x0000EA1C
		private void SetExtensionData(JsonObjectContract contract, JsonProperty member, JsonReader reader, string memberName, object o)
		{
			if (contract.<ExtensionDataSetter>k__BackingField != null)
			{
				object obj = this.ReadExtensionDataValue(contract, member, reader);
				ExtensionDataSetter <ExtensionDataSetter>k__BackingField = contract.<ExtensionDataSetter>k__BackingField;
				IntPtr method_code = <ExtensionDataSetter>k__BackingField.method_code;
				IntPtr invoke_impl = <ExtensionDataSetter>k__BackingField.invoke_impl;
				IntPtr method = <ExtensionDataSetter>k__BackingField.method;
				return;
			}
			reader.Skip();
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x00010888 File Offset: 0x0000EA88
		private object ReadExtensionDataValue(JsonObjectContract contract, JsonProperty member, JsonReader reader)
		{
			if (contract.ExtensionDataIsJToken)
			{
				JToken jtoken = JToken.ReadFrom(reader);
			}
			object obj;
			return obj;
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x000108A8 File Offset: 0x0000EAA8
		private void EndProcessProperty(object newObject, JsonReader reader, JsonObjectContract contract, int initialDepth, JsonProperty property, JsonSerializerInternalReader.PropertyPresence presence, bool setDefaultValue)
		{
			if (presence == JsonSerializerInternalReader.PropertyPresence.None)
			{
				Required? required = property._required;
				string propertyName;
				if (required != null)
				{
					if (presence == JsonSerializerInternalReader.PropertyPresence.None)
					{
						goto IL_0054;
					}
					if (required == null)
					{
					}
					CultureInfo invariantCulture = CultureInfo.InvariantCulture;
					propertyName = property._propertyName;
					string text = "Required property '{0}' expects a value but got null.".FormatWith(invariantCulture, propertyName);
					JsonSerializationException ex = JsonSerializationException.Create(reader, text);
				}
				Required? <ItemRequired>k__BackingField = contract.<ItemRequired>k__BackingField;
				JsonPropertyCollection <Properties>k__BackingField = contract.<Properties>k__BackingField;
				while (propertyName != null)
				{
				}
				IL_0054:
				if (!property.<Ignored>k__BackingField)
				{
					if (property.<PropertyContract>k__BackingField == null)
					{
						Type propertyType = property._propertyType;
						JsonContract contractSafe = this.GetContractSafe(propertyType);
						property.<PropertyContract>k__BackingField = contractSafe;
					}
					DefaultValueHandling? <DefaultValueHandling>k__BackingField = property.<DefaultValueHandling>k__BackingField;
					DefaultValueHandling defaultValueHandling = this.Serializer._defaultValueHandling;
					if (property.<Writable>k__BackingField)
					{
						IValueProvider <ValueProvider>k__BackingField = property.<ValueProvider>k__BackingField;
						object resolvedDefaultValue = property.GetResolvedDefaultValue();
						CultureInfo invariantCulture2 = CultureInfo.InvariantCulture;
						Type propertyType2 = property._propertyType;
						JsonContract <PropertyContract>k__BackingField = property.<PropertyContract>k__BackingField;
						return;
					}
				}
			}
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x00010A10 File Offset: 0x0000EC10
		private void SetPropertyPresence(JsonReader reader, JsonProperty property, Dictionary<JsonProperty, JsonSerializerInternalReader.PropertyPresence> requiredProperties)
		{
			if (property != null && requiredProperties != null)
			{
				return;
			}
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x00010A44 File Offset: 0x0000EC44
		private void HandleError(JsonReader reader, bool readPastError, int initialDepth)
		{
			base.ClearErrorContext();
			reader.Skip();
		}

		// Token: 0x020000A9 RID: 169
		internal enum PropertyPresence
		{
			// Token: 0x040002C2 RID: 706
			None,
			// Token: 0x040002C3 RID: 707
			Null,
			// Token: 0x040002C4 RID: 708
			Value
		}

		// Token: 0x020000AA RID: 170
		internal class CreatorPropertyContext
		{
			// Token: 0x06000636 RID: 1590 RVA: 0x00010A60 File Offset: 0x0000EC60
			public CreatorPropertyContext()
			{
			}

			// Token: 0x040002C5 RID: 709
			public string Name;

			// Token: 0x040002C6 RID: 710
			public JsonProperty Property;

			// Token: 0x040002C7 RID: 711
			public JsonProperty ConstructorProperty;

			// Token: 0x040002C8 RID: 712
			public JsonSerializerInternalReader.PropertyPresence? Presence;

			// Token: 0x040002C9 RID: 713
			public object Value;

			// Token: 0x040002CA RID: 714
			public bool Used;
		}

		// Token: 0x020000AB RID: 171
		[CompilerGenerated]
		private sealed class <>c__DisplayClass36_0
		{
			// Token: 0x06000637 RID: 1591 RVA: 0x00010A74 File Offset: 0x0000EC74
			public <>c__DisplayClass36_0()
			{
			}

			// Token: 0x06000638 RID: 1592 RVA: 0x00010A88 File Offset: 0x0000EC88
			internal bool <CreateObjectUsingCreatorWithParameters>b__1(JsonSerializerInternalReader.CreatorPropertyContext p)
			{
				/*
An exception occurred when decompiling this method (06000638)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Newtonsoft.Json.Serialization.JsonSerializerInternalReader/<>c__DisplayClass36_0::<CreateObjectUsingCreatorWithParameters>b__1(Newtonsoft.Json.Serialization.JsonSerializerInternalReader/CreatorPropertyContext)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:JsonProperty(var_0_06, ldfld:JsonProperty(CreatorPropertyContext::Property, ldloc:CreatorPropertyContext(p)))
	stloc:JsonProperty(var_1_0D, ldfld:JsonProperty('<>c__DisplayClass36_0'::property, ldloc:'<>c__DisplayClass36_0'(this)))
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

			// Token: 0x040002CB RID: 715
			public JsonProperty property;
		}

		// Token: 0x020000AC RID: 172
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000639 RID: 1593 RVA: 0x00010AA4 File Offset: 0x0000ECA4
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600063A RID: 1594 RVA: 0x00010AB4 File Offset: 0x0000ECB4
			public <>c()
			{
			}

			// Token: 0x0600063B RID: 1595 RVA: 0x00010AC8 File Offset: 0x0000ECC8
			internal string <CreateObjectUsingCreatorWithParameters>b__36_0(JsonProperty p)
			{
				return p._propertyName;
			}

			// Token: 0x0600063C RID: 1596 RVA: 0x00010ADC File Offset: 0x0000ECDC
			internal string <CreateObjectUsingCreatorWithParameters>b__36_2(JsonProperty p)
			{
				return p._propertyName;
			}

			// Token: 0x0600063D RID: 1597 RVA: 0x00010AF0 File Offset: 0x0000ECF0
			internal JsonProperty <PopulateObject>b__41_0(JsonProperty m)
			{
				return m;
			}

			// Token: 0x0600063E RID: 1598 RVA: 0x00010B00 File Offset: 0x0000ED00
			internal JsonSerializerInternalReader.PropertyPresence <PopulateObject>b__41_1(JsonProperty m)
			{
			}

			// Token: 0x040002CC RID: 716
			public static readonly JsonSerializerInternalReader.<>c <>9;

			// Token: 0x040002CD RID: 717
			public static Func<JsonProperty, string> <>9__36_0;

			// Token: 0x040002CE RID: 718
			public static Func<JsonProperty, string> <>9__36_2;

			// Token: 0x040002CF RID: 719
			public static Func<JsonProperty, JsonProperty> <>9__41_0;

			// Token: 0x040002D0 RID: 720
			public static Func<JsonProperty, JsonSerializerInternalReader.PropertyPresence> <>9__41_1;
		}
	}
}
