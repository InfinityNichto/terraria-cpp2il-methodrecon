using System;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000F7 RID: 247
	public class ColorConverter : JsonConverter
	{
		// Token: 0x06000A05 RID: 2565 RVA: 0x00018AE8 File Offset: 0x00016CE8
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			if (value != null)
			{
				return;
			}
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x00018B00 File Offset: 0x00016D00
		public override bool CanConvert(Type objectType)
		{
			if (!true)
			{
			}
			return true;
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x00018B14 File Offset: 0x00016D14
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			/*
An exception occurred when decompiling this method (06000A07)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object Newtonsoft.Json.Converters.ColorConverter::ReadJson(Newtonsoft.Json.JsonReader,System.Type,System.Object,Newtonsoft.Json.JsonSerializer)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:JObject(var_0_06, call:JObject(JObject::Load, ldloc:JsonReader(reader)))
	stloc:JToken(var_2_12, callgetter:JToken(JObject::get_Item, ldloc:JObject(var_0_06), ldstr:string("r")))
	stloc:float32(var_3_19, call:float32(JToken::op_Explicit, ldloc:JToken(var_2_12)))
	stloc:float32(var_4_2A, call:float32(JToken::op_Explicit, callgetter:JToken(JObject::get_Item, ldloc:JObject(var_0_06), ldstr:string("g"))))
	stloc:float32(var_5_3C, call:float32(JToken::op_Explicit, callgetter:JToken(JObject::get_Item, ldloc:JObject(var_0_06), ldstr:string("b"))))
	stloc:float32(var_6_4E, call:float32(JToken::op_Explicit, callgetter:JToken(JObject::get_Item, ldloc:JObject(var_0_06), ldstr:string("a"))))
	stloc:uint8(var_7_56, call:uint8(JToken::op_Explicit, ldloc:JToken(var_2_12)))
	stloc:uint8(var_8_68, call:uint8(JToken::op_Explicit, callgetter:JToken(JObject::get_Item, ldloc:JObject(var_0_06), ldstr:string("g"))))
	stloc:uint8(var_9_7A, call:uint8(JToken::op_Explicit, callgetter:JToken(JObject::get_Item, ldloc:JObject(var_0_06), ldstr:string("b"))))
	stloc:uint8(var_10_8C, call:uint8(JToken::op_Explicit, callgetter:JToken(JObject::get_Item, ldloc:JObject(var_0_06), ldstr:string("a"))))
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

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000A08 RID: 2568 RVA: 0x00018BB0 File Offset: 0x00016DB0
		public override bool CanRead
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x00018BC0 File Offset: 0x00016DC0
		public ColorConverter()
		{
		}
	}
}
