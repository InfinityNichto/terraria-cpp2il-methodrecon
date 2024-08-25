using System;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000FA RID: 250
	public class EnumerableVectorConverter<T> : JsonConverter
	{
		// Token: 0x06000A12 RID: 2578 RVA: 0x00018C38 File Offset: 0x00016E38
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			if (value == null)
			{
			}
			if (value != null && value != null)
			{
				return;
			}
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x00018C54 File Offset: 0x00016E54
		public override bool CanConvert(Type objectType)
		{
			if (!true)
			{
			}
			return true;
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x00018C68 File Offset: 0x00016E68
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			/*
An exception occurred when decompiling this method (06000A14)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object Newtonsoft.Json.Converters.EnumerableVectorConverter`1::ReadJson(Newtonsoft.Json.JsonReader,System.Type,System.Object,Newtonsoft.Json.JsonSerializer)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:JObject(var_0_06, call:JObject(JObject::Load, ldloc:JsonReader(reader)))
	stloc:int32(var_1_0D, callgetter:int32(JContainer::get_Count, ldloc:JObject[exp:JContainer](var_0_06)))
	stloc:int32(var_3_16, callgetter:int32(JContainer::get_Count, ldloc:JObject[exp:JContainer](var_0_06)))
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

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000A15 RID: 2581 RVA: 0x00018C8C File Offset: 0x00016E8C
		public override bool CanRead
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x00018C9C File Offset: 0x00016E9C
		public EnumerableVectorConverter()
		{
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x00018CB0 File Offset: 0x00016EB0
		// Note: this type is marked as 'beforefieldinit'.
		static EnumerableVectorConverter()
		{
		}

		// Token: 0x040003F5 RID: 1013
		private static readonly VectorConverter VectorConverter;
	}
}
