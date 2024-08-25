using System;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000F8 RID: 248
	[Preserve]
	public abstract class CustomCreationConverter<T> : JsonConverter
	{
		// Token: 0x06000A0A RID: 2570 RVA: 0x0000212A File Offset: 0x0000032A
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x00018BD4 File Offset: 0x00016DD4
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			/*
An exception occurred when decompiling this method (06000A0B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object Newtonsoft.Json.Converters.CustomCreationConverter`1::ReadJson(Newtonsoft.Json.JsonReader,System.Type,System.Object,Newtonsoft.Json.JsonSerializer)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(JsonSerializer::Populate, ldloc:JsonSerializer(serializer), ldloc:JsonReader(reader), ldloc:CustomCreationConverter`1[exp:object](this))
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

		// Token: 0x06000A0C RID: 2572
		public abstract T Create(Type objectType);

		// Token: 0x06000A0D RID: 2573 RVA: 0x0000212A File Offset: 0x0000032A
		public override bool CanConvert(Type objectType)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000A0E RID: 2574 RVA: 0x00018BEC File Offset: 0x00016DEC
		public override bool CanWrite
		{
			get
			{
			}
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x00018BFC File Offset: 0x00016DFC
		protected CustomCreationConverter()
		{
		}
	}
}
