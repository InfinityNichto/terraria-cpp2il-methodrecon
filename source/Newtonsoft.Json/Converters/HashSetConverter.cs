using System;
using System.Reflection;
using Newtonsoft.Json.Linq;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000FB RID: 251
	public class HashSetConverter : JsonConverter
	{
		// Token: 0x06000A18 RID: 2584 RVA: 0x00018CC0 File Offset: 0x00016EC0
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x00018CD0 File Offset: 0x00016ED0
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			if (existingValue != null)
			{
			}
			object obj = Activator.CreateInstance(objectType);
			MethodInfo method = objectType.GetMethod("Add");
			JArray jarray = JArray.Load(reader);
			int count = jarray.Count;
			long num = 0L;
			JsonReader jsonReader = jarray[(int)num].CreateReader();
			object obj2;
			if (obj2 == null || obj2 != null)
			{
				int count2 = jarray.Count;
				return obj;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x00018D30 File Offset: 0x00016F30
		public override bool CanConvert(Type objectType)
		{
			/*
An exception occurred when decompiling this method (06000A1A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Newtonsoft.Json.Converters.HashSetConverter::CanConvert(System.Type)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_06, call:bool(TypeExtensions::IsGenericType, ldloc:Type(objectType)))
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

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x00018D48 File Offset: 0x00016F48
		public override bool CanWrite
		{
			get
			{
			}
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x00018D58 File Offset: 0x00016F58
		public HashSetConverter()
		{
		}
	}
}
