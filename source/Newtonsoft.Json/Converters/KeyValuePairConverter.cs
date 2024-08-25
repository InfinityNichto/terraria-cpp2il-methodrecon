using System;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000FC RID: 252
	[Preserve]
	public class KeyValuePairConverter : JsonConverter
	{
		// Token: 0x06000A1D RID: 2589 RVA: 0x00018D6C File Offset: 0x00016F6C
		private static ReflectionObject InitializeReflectionObject(Type t)
		{
			return "Key";
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x00018DC8 File Offset: 0x00016FC8
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			if (!true)
			{
			}
			Type type = value.GetType();
			if (serializer != null)
			{
			}
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x00018E04 File Offset: 0x00017004
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			bool flag = ReflectionUtils.IsNullableType(objectType);
			reader.ReadAndAssert();
			bool flag2 = ReflectionUtils.IsNullableType(objectType);
			Type underlyingType = Nullable.GetUnderlyingType(objectType);
			reader.ReadAndAssert();
			Type type;
			return serializer.Deserialize(reader, type);
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x00018EB0 File Offset: 0x000170B0
		public override bool CanConvert(Type objectType)
		{
			/*
An exception occurred when decompiling this method (06000A20)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Newtonsoft.Json.Converters.KeyValuePairConverter::CanConvert(System.Type)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:bool(var_0_09, call:bool(ReflectionUtils::IsNullableType, ldloc:Type(objectType)))
	stloc:Type(var_1_10, call:Type(Nullable::GetUnderlyingType, ldloc:Type(objectType)))
	stloc:bool(var_2_17, call:bool(TypeExtensions::IsValueType, ldloc:Type(var_1_10)))
	stloc:bool(var_3_1E, call:bool(TypeExtensions::IsGenericType, ldloc:Type(var_1_10)))
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

		// Token: 0x06000A21 RID: 2593 RVA: 0x00018EE0 File Offset: 0x000170E0
		public KeyValuePairConverter()
		{
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x00018EF4 File Offset: 0x000170F4
		// Note: this type is marked as 'beforefieldinit'.
		static KeyValuePairConverter()
		{
		}

		// Token: 0x040003F6 RID: 1014
		private const string KeyName = "Key";

		// Token: 0x040003F7 RID: 1015
		private const string ValueName = "Value";

		// Token: 0x040003F8 RID: 1016
		private static readonly ThreadSafeStore<Type, ReflectionObject> ReflectionObjectPerType;
	}
}
