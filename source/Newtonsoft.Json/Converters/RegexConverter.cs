using System;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000101 RID: 257
	[Preserve]
	public class RegexConverter : JsonConverter
	{
		// Token: 0x06000A38 RID: 2616 RVA: 0x00019268 File Offset: 0x00017468
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			if (value != null)
			{
			}
			if (writer != null)
			{
			}
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x0000212A File Offset: 0x0000032A
		private bool HasFlag(RegexOptions options, RegexOptions flag)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x00019284 File Offset: 0x00017484
		private void WriteBson(BsonWriter writer, Regex regex)
		{
			RegexOptions roptions = regex.roptions;
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x000192E8 File Offset: 0x000174E8
		private void WriteJson(JsonWriter writer, Regex regex, JsonSerializer serializer)
		{
			if (serializer != null)
			{
			}
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x00019308 File Offset: 0x00017508
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			object obj;
			return obj;
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x00019324 File Offset: 0x00017524
		private object ReadRegexString(JsonReader reader)
		{
			if (reader != null)
			{
			}
			string text;
			int stringLength = text._stringLength;
			long num = 0L;
			char c = text[(int)num];
			int stringLength2 = text._stringLength;
			throw new InvalidCastException();
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x00019360 File Offset: 0x00017560
		private Regex ReadRegexObject(JsonReader reader, JsonSerializer serializer)
		{
			RegexOptions regexOptions = serializer.Deserialize<RegexOptions>(reader);
			reader.Skip();
			while (reader == null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x00019398 File Offset: 0x00017598
		public override bool CanConvert(Type objectType)
		{
			/*
An exception occurred when decompiling this method (06000A3F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Newtonsoft.Json.Converters.RegexConverter::CanConvert(System.Type)

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

		// Token: 0x06000A40 RID: 2624 RVA: 0x000193A8 File Offset: 0x000175A8
		public RegexConverter()
		{
		}

		// Token: 0x040003FF RID: 1023
		private const string PatternName = "Pattern";

		// Token: 0x04000400 RID: 1024
		private const string OptionsName = "Options";
	}
}
