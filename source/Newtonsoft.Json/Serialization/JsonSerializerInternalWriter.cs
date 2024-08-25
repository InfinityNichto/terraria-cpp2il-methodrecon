using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000AD RID: 173
	[Preserve]
	internal class JsonSerializerInternalWriter : JsonSerializerInternalBase
	{
		// Token: 0x0600063F RID: 1599 RVA: 0x00010B10 File Offset: 0x0000ED10
		public JsonSerializerInternalWriter(JsonSerializer serializer)
			: base(serializer)
		{
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00010B24 File Offset: 0x0000ED24
		public void Serialize(JsonWriter jsonWriter, object value, Type objectType)
		{
			if (jsonWriter != null)
			{
				List<object> serializeStack = this._serializeStack;
				this._rootType = objectType;
				int size = serializeStack._size;
				this._rootLevel = size;
				JsonContract contractSafe = this.GetContractSafe(value);
				this.WriteReference(jsonWriter, value);
				return;
			}
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x00010B90 File Offset: 0x0000ED90
		private JsonSerializerProxy GetInternalSerializer()
		{
			/*
An exception occurred when decompiling this method (06000641)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Newtonsoft.Json.Serialization.JsonSerializerProxy Newtonsoft.Json.Serialization.JsonSerializerInternalWriter::GetInternalSerializer()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:JsonSerializerProxy[exp:bool](JsonSerializerInternalBase::InternalSerializer, ldloc:JsonSerializerInternalWriter[exp:JsonSerializerInternalBase](this)))
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

		// Token: 0x06000642 RID: 1602 RVA: 0x00010BA4 File Offset: 0x0000EDA4
		private JsonContract GetContractSafe(object value)
		{
			/*
An exception occurred when decompiling this method (06000642)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Newtonsoft.Json.Serialization.JsonContract Newtonsoft.Json.Serialization.JsonSerializerInternalWriter::GetContractSafe(System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0016:
	stloc:int64(var_2_1C, ldfld:int64(int64::m_value, ldc.i4:int32[exp:int64&](0)))
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

		// Token: 0x06000643 RID: 1603 RVA: 0x00010BD0 File Offset: 0x0000EDD0
		private void SerializePrimitive(JsonWriter writer, object value, JsonPrimitiveContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
			PrimitiveTypeCode <TypeCode>k__BackingField = contract.<TypeCode>k__BackingField;
			bool flag = this.ShouldWriteType(TypeNameHandling.Objects, contract, member, containerContract, containerProperty);
			Type createdType = contract._createdType;
			this.WriteTypeProperty(writer, createdType);
			PrimitiveTypeCode <TypeCode>k__BackingField2 = contract.<TypeCode>k__BackingField;
			JsonWriter.WriteValue(writer, <TypeCode>k__BackingField2, value);
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x00010C1C File Offset: 0x0000EE1C
		private void SerializeValue(JsonWriter writer, object value, JsonContract valueContract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
			if (value != null)
			{
				JsonConverter <InternalConverter>k__BackingField;
				if ((member == null || member.<Converter>k__BackingField == null) && (containerProperty == null || containerProperty.<ItemConverter>k__BackingField == null) && (containerContract == null || containerContract.<ItemConverter>k__BackingField == null) && valueContract.<Converter>k__BackingField == null)
				{
					JsonSerializer serializer = this.Serializer;
					Type <UnderlyingType>k__BackingField = valueContract.<UnderlyingType>k__BackingField;
					if (serializer.GetMatchingConverter(<UnderlyingType>k__BackingField) == null)
					{
						<InternalConverter>k__BackingField = valueContract.<InternalConverter>k__BackingField;
						if (<InternalConverter>k__BackingField == null)
						{
							JsonContractType contractType = valueContract.ContractType;
							return;
						}
					}
				}
				this.SerializeConvertable(writer, <InternalConverter>k__BackingField, value, valueContract, containerContract, containerProperty);
				return;
			}
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x00010CC4 File Offset: 0x0000EEC4
		private bool? ResolveIsReference(JsonContract contract, JsonProperty property, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			/*
An exception occurred when decompiling this method (06000645)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Nullable`1<System.Boolean> Newtonsoft.Json.Serialization.JsonSerializerInternalWriter::ResolveIsReference(Newtonsoft.Json.Serialization.JsonContract,Newtonsoft.Json.Serialization.JsonProperty,Newtonsoft.Json.Serialization.JsonContainerContract,Newtonsoft.Json.Serialization.JsonProperty)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0024:
	stloc:valuetype [mscorlib]System.Nullable`1<bool>(var_3_2A, ldfld:valuetype [mscorlib]System.Nullable`1<bool>(JsonContract::<IsReference>k__BackingField, ldloc:JsonContract(contract)))
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

		// Token: 0x06000646 RID: 1606 RVA: 0x00010CFC File Offset: 0x0000EEFC
		private bool ShouldWriteReference(object value, JsonProperty property, JsonContract valueContract, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			/*
An exception occurred when decompiling this method (06000646)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Newtonsoft.Json.Serialization.JsonSerializerInternalWriter::ShouldWriteReference(System.Object,Newtonsoft.Json.Serialization.JsonProperty,Newtonsoft.Json.Serialization.JsonContract,Newtonsoft.Json.Serialization.JsonContainerContract,Newtonsoft.Json.Serialization.JsonProperty)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0038:
	stloc:int64(var_7_3E, ldfld:int64(int64::m_value, ldc.i4:int32[exp:int64&](0)))
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

		// Token: 0x06000647 RID: 1607 RVA: 0x00010D48 File Offset: 0x0000EF48
		private bool ShouldWriteProperty(object memberValue, JsonProperty property)
		{
			NullValueHandling? <NullValueHandling>k__BackingField = property.<NullValueHandling>k__BackingField;
			NullValueHandling nullValueHandling = this.Serializer._nullValueHandling;
			if (memberValue == null)
			{
			}
			DefaultValueHandling? <DefaultValueHandling>k__BackingField = property.<DefaultValueHandling>k__BackingField;
			DefaultValueHandling defaultValueHandling = this.Serializer._defaultValueHandling;
			object resolvedDefaultValue = property.GetResolvedDefaultValue();
			bool flag = MiscellaneousUtils.ValueEquals(memberValue, resolvedDefaultValue);
			return true;
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x00010D94 File Offset: 0x0000EF94
		private bool CheckForCircularReference(JsonWriter writer, object value, JsonProperty property, JsonContract contract, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
			while (value != null)
			{
				JsonContractType contractType = contract.ContractType;
				if (property != null)
				{
					ReferenceLoopHandling? <ReferenceLoopHandling>k__BackingField = property.<ReferenceLoopHandling>k__BackingField;
					if (containerProperty == null)
					{
						return " for property '{0}'" != null;
					}
				}
				else if (containerProperty != null)
				{
				}
				if (containerContract != null)
				{
				}
				JsonSerializer serializer = this.Serializer;
				List<object> serializeStack = this._serializeStack;
				if (serializer._equalityComparer != null)
				{
					bool flag;
					return flag;
				}
				string text2;
				if (property != null)
				{
					if ("Self referencing loop detected" == null)
					{
					}
					CultureInfo invariantCulture = CultureInfo.InvariantCulture;
					string propertyName = property._propertyName;
					string text = " for property '{0}'".FormatWith(invariantCulture, propertyName);
					text2 = "Self referencing loop detected" + text;
				}
				if (" for property '{0}'" == null)
				{
				}
				CultureInfo invariantCulture2 = CultureInfo.InvariantCulture;
				Type type = value.GetType();
				string text3 = " with type '{0}'.".FormatWith(invariantCulture2, type);
				string text4 = text2 + text3;
				ReferenceLoopHandling referenceLoopHandling = this.Serializer._referenceLoopHandling;
				if (text4 != null)
				{
					return;
				}
				string containerPath = writer.ContainerPath;
				if (this.TraceWriter == null)
				{
					return;
				}
				if (this.TraceWriter != null)
				{
					ITraceWriter traceWriter = this.TraceWriter;
					string text5 = text4 + ". Serializing self referenced value.";
					string text6 = text5 + ". Skipping serializing self referenced value.";
					return;
				}
			}
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x00010EB0 File Offset: 0x0000F0B0
		private void WriteReference(JsonWriter writer, object value)
		{
			string reference = this.GetReference(writer, value);
			if (this.TraceWriter != null)
			{
				return;
			}
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x00010F04 File Offset: 0x0000F104
		private string GetReference(JsonWriter writer, object value)
		{
			/*
An exception occurred when decompiling this method (0600064A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Newtonsoft.Json.Serialization.JsonSerializerInternalWriter::GetReference(Newtonsoft.Json.JsonWriter,System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:IReferenceResolver(var_0_0B, call:IReferenceResolver(JsonSerializer::GetReferenceResolver, ldfld:JsonSerializer(JsonSerializerInternalBase::Serializer, ldloc:JsonSerializerInternalWriter[exp:JsonSerializerInternalBase](this))))
	stloc:string(var_1_12, callgetter:string(JsonWriter::get_ContainerPath, ldloc:JsonWriter(writer)))
	stloc:CultureInfo(var_3_1A, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
	stloc:Type(var_4_21, call:Type(object::GetType, ldloc:object(value)))
	stloc:string(var_5_30, call:string(StringUtils::FormatWith, ldstr:string("Error writing object reference for '{0}'."), ldloc:CultureInfo[exp:IFormatProvider](var_3_1A), ldloc:Type[exp:object](var_4_21)))
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

		// Token: 0x0600064B RID: 1611 RVA: 0x00010F48 File Offset: 0x0000F148
		internal static bool TryConvertToString(object value, Type type, [Out] string s)
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
				string text = typeConverter.ConvertToInvariantString(type3);
				return;
			}
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x00010F7C File Offset: 0x0000F17C
		private void SerializeString(JsonWriter writer, object value, JsonStringContract contract)
		{
			this.OnSerializing(writer, contract, value);
			Type <UnderlyingType>k__BackingField = contract.<UnderlyingType>k__BackingField;
			this.OnSerialized(writer, contract, value);
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x00010FA4 File Offset: 0x0000F1A4
		private void OnSerializing(JsonWriter writer, JsonContract contract, object value)
		{
			if (this.TraceWriter != null)
			{
				return;
			}
			JsonSerializer serializer = this.Serializer;
			StreamingContext context = serializer._context;
			StreamingContextStates state = serializer._context.m_state;
			contract.InvokeOnSerializing(value, context);
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x00011014 File Offset: 0x0000F214
		private void OnSerialized(JsonWriter writer, JsonContract contract, object value)
		{
			if (this.TraceWriter != null)
			{
				return;
			}
			JsonSerializer serializer = this.Serializer;
			StreamingContext context = serializer._context;
			StreamingContextStates state = serializer._context.m_state;
			contract.InvokeOnSerialized(value, context);
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x0000212A File Offset: 0x0000032A
		private void SerializeObject(JsonWriter writer, object value, JsonObjectContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x00011084 File Offset: 0x0000F284
		private bool CalculatePropertyValues(JsonWriter writer, object value, JsonContainerContract contract, JsonProperty member, JsonProperty property, [Out] JsonContract memberContract, [Out] object memberValue)
		{
			do
			{
				if (property.<Ignored>k__BackingField)
				{
				}
			}
			while (!property.<Readable>k__BackingField);
			bool flag = this.ShouldSerialize(writer, property, value);
			bool flag2 = this.IsSpecified(writer, property, value);
			if (property.<PropertyContract>k__BackingField == null)
			{
				IContractResolver contractResolver = this.Serializer._contractResolver;
				Type propertyType = property._propertyType;
				property.<PropertyContract>k__BackingField = contractResolver;
			}
			IValueProvider <ValueProvider>k__BackingField = property.<ValueProvider>k__BackingField;
			if (!property.<PropertyContract>k__BackingField.IsSealed)
			{
			}
			property.WritePropertyName(writer);
			if (contract != null)
			{
			}
			bool flag3;
			return flag3;
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x0001115C File Offset: 0x0000F35C
		private void WriteObjectStart(JsonWriter writer, object value, JsonContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			if (member == null || member.<Writable>k__BackingField)
			{
				Type <UnderlyingType>k__BackingField = contract.<UnderlyingType>k__BackingField;
				this.WriteReferenceIdProperty(writer, <UnderlyingType>k__BackingField, value);
				return;
			}
			Type <UnderlyingType>k__BackingField2 = contract.<UnderlyingType>k__BackingField;
			this.WriteTypeProperty(writer, <UnderlyingType>k__BackingField2);
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x000111A8 File Offset: 0x0000F3A8
		private void WriteReferenceIdProperty(JsonWriter writer, Type type, object value)
		{
			string reference = this.GetReference(writer, value);
			if (this.TraceWriter != null)
			{
				return;
			}
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x000111F4 File Offset: 0x0000F3F4
		private void WriteTypeProperty(JsonWriter writer, Type type)
		{
			JsonSerializer serializer = this.Serializer;
			FormatterAssemblyStyle typeNameAssemblyFormat = serializer._typeNameAssemblyFormat;
			SerializationBinder binder = serializer._binder;
			string typeName = ReflectionUtils.GetTypeName(type, typeNameAssemblyFormat, binder);
			if (this.TraceWriter != null)
			{
				return;
			}
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x0000212A File Offset: 0x0000032A
		private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x0000212A File Offset: 0x0000032A
		private bool HasFlag(PreserveReferencesHandling value, PreserveReferencesHandling flag)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x0000212A File Offset: 0x0000032A
		private bool HasFlag(TypeNameHandling value, TypeNameHandling flag)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x0000212A File Offset: 0x0000032A
		private void SerializeConvertable(JsonWriter writer, JsonConverter converter, object value, JsonContract contract, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x0000212A File Offset: 0x0000032A
		private void SerializeList(JsonWriter writer, IEnumerable values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x0000212A File Offset: 0x0000032A
		private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x00011258 File Offset: 0x0000F458
		private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, int initialDepth, int[] indices)
		{
			int lowerBound = values.GetLowerBound(43159552);
			int upperBound = values.GetUpperBound(43159552);
			initialDepth.m_value = lowerBound;
			int rank = values.Rank;
			object obj;
			if (contract._finalItemContract == null)
			{
				JsonContract contractSafe = this.GetContractSafe(obj);
			}
			this.WriteReference(writer, obj);
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x000112CC File Offset: 0x0000F4CC
		private bool WriteStartArray(JsonWriter writer, object values, JsonArrayContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
			/*
An exception occurred when decompiling this method (0600065B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Newtonsoft.Json.Serialization.JsonSerializerInternalWriter::WriteStartArray(Newtonsoft.Json.JsonWriter,System.Object,Newtonsoft.Json.Serialization.JsonArrayContract,Newtonsoft.Json.Serialization.JsonProperty,Newtonsoft.Json.Serialization.JsonContainerContract,Newtonsoft.Json.Serialization.JsonProperty)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_2:
	stloc:JsonSerializer(var_9_41, ldfld:JsonSerializer(JsonSerializerInternalBase::Serializer, ldloc:JsonSerializerInternalWriter[exp:JsonSerializerInternalBase](this)))
	stloc:Type(var_10_49, ldfld:Type(JsonArrayContract::<CollectionItemType>k__BackingField, ldloc:JsonArrayContract(contract)))
	stloc:IContractResolver(var_11_52, ldfld:IContractResolver(JsonSerializer::_contractResolver, ldloc:JsonSerializer(var_9_41)))
	brtrue(IL_0000, ldloc:Type[exp:bool](var_10_49))
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

		// Token: 0x0600065C RID: 1628 RVA: 0x0000212A File Offset: 0x0000032A
		private void SerializeISerializable(JsonWriter writer, ISerializable value, JsonISerializableContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00011330 File Offset: 0x0000F530
		private bool ShouldWriteDynamicProperty(object memberValue)
		{
			JsonSerializer serializer = this.Serializer;
			NullValueHandling nullValueHandling;
			if (memberValue == null)
			{
				nullValueHandling = serializer._nullValueHandling;
			}
			DefaultValueHandling defaultValueHandling = serializer._defaultValueHandling;
			while (memberValue == null)
			{
			}
			Type type = memberValue.GetType();
			if (nullValueHandling == NullValueHandling.Include)
			{
			}
			object defaultValue = ReflectionUtils.GetDefaultValue(type);
			bool flag = MiscellaneousUtils.ValueEquals(memberValue, defaultValue);
			return true;
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x0001137C File Offset: 0x0000F57C
		private bool ShouldWriteType(TypeNameHandling typeNameHandlingFlag, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
			/*
An exception occurred when decompiling this method (0600065E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Newtonsoft.Json.Serialization.JsonSerializerInternalWriter::ShouldWriteType(Newtonsoft.Json.TypeNameHandling,Newtonsoft.Json.Serialization.JsonContract,Newtonsoft.Json.Serialization.JsonProperty,Newtonsoft.Json.Serialization.JsonContainerContract,Newtonsoft.Json.Serialization.JsonProperty)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_008E:
	stloc:Type(var_10_94, ldfld:Type(JsonContract::<UnderlyingType>k__BackingField, ldloc:JsonContract(contract)))
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

		// Token: 0x0600065F RID: 1631 RVA: 0x0000212A File Offset: 0x0000032A
		private void SerializeDictionary(JsonWriter writer, IDictionary values, JsonDictionaryContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x00011420 File Offset: 0x0000F620
		private string GetPropertyName(JsonWriter writer, object name, JsonContract contract, [Out] bool escape)
		{
			JsonContractType contractType = contract.ContractType;
			DateTimeZoneHandling dateTimeZoneHandling = writer._dateTimeZoneHandling;
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			DateFormatHandling dateFormatHandling = writer._dateFormatHandling;
			string dateFormatString = writer._dateFormatString;
			CultureInfo culture = writer.Culture;
			DateTime dateTime;
			Type type = dateTime.GetType();
			int num = 1;
			dateFormatHandling.value__ = num;
			CultureInfo invariantCulture2 = CultureInfo.InvariantCulture;
			DateFormatHandling dateFormatHandling2 = writer._dateFormatHandling;
			string dateFormatString2 = writer._dateFormatString;
			CultureInfo culture2 = writer.Culture;
			ulong dateData = dateTime._dateData;
			if (!true)
			{
			}
			CultureInfo invariantCulture3 = CultureInfo.InvariantCulture;
			return Convert.ToString(dateTime, invariantCulture3);
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x000114BC File Offset: 0x0000F6BC
		private void HandleError(JsonWriter writer, int initialDepth)
		{
			base.ClearErrorContext();
			WriteState writeState = writer.WriteState;
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x000114E0 File Offset: 0x0000F6E0
		private bool ShouldSerialize(JsonWriter writer, JsonProperty property, object target)
		{
			/*
An exception occurred when decompiling this method (06000662)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Newtonsoft.Json.Serialization.JsonSerializerInternalWriter::ShouldSerialize(Newtonsoft.Json.JsonWriter,Newtonsoft.Json.Serialization.JsonProperty,System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0010:
	stloc:ITraceWriter(var_0_16, ldfld:ITraceWriter(JsonSerializerInternalBase::TraceWriter, ldloc:JsonSerializerInternalWriter[exp:JsonSerializerInternalBase](this)))
	stloc:string(var_1_1D, callgetter:string(JsonWriter::get_Path, ldloc:JsonWriter(writer)))
	stloc:CultureInfo(var_3_25, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
	stloc:string(var_4_2C, ldfld:string(JsonProperty::_propertyName, ldloc:JsonProperty(property)))
	stloc:Type(var_5_34, ldfld:Type(JsonProperty::<DeclaringType>k__BackingField, ldloc:JsonProperty(property)))
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

		// Token: 0x06000663 RID: 1635 RVA: 0x00011528 File Offset: 0x0000F728
		private bool IsSpecified(JsonWriter writer, JsonProperty property, object target)
		{
			/*
An exception occurred when decompiling this method (06000663)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Newtonsoft.Json.Serialization.JsonSerializerInternalWriter::IsSpecified(Newtonsoft.Json.JsonWriter,Newtonsoft.Json.Serialization.JsonProperty,System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0010:
	stloc:ITraceWriter(var_0_16, ldfld:ITraceWriter(JsonSerializerInternalBase::TraceWriter, ldloc:JsonSerializerInternalWriter[exp:JsonSerializerInternalBase](this)))
	stloc:string(var_1_1D, callgetter:string(JsonWriter::get_Path, ldloc:JsonWriter(writer)))
	stloc:CultureInfo(var_3_25, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
	stloc:string(var_4_2C, ldfld:string(JsonProperty::_propertyName, ldloc:JsonProperty(property)))
	stloc:Type(var_5_34, ldfld:Type(JsonProperty::<DeclaringType>k__BackingField, ldloc:JsonProperty(property)))
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

		// Token: 0x040002D1 RID: 721
		private Type _rootType;

		// Token: 0x040002D2 RID: 722
		private int _rootLevel;

		// Token: 0x040002D3 RID: 723
		private readonly List<object> _serializeStack;
	}
}
