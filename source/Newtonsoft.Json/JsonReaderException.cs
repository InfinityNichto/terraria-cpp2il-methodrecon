using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x0200002E RID: 46
	[Preserve]
	[Serializable]
	public class JsonReaderException : JsonException
	{
		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00005824 File Offset: 0x00003A24
		// (set) Token: 0x0600014C RID: 332 RVA: 0x00005838 File Offset: 0x00003A38
		public int LineNumber
		{
			[CompilerGenerated]
			get
			{
				return this.<LineNumber>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<LineNumber>k__BackingField = value;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600014D RID: 333 RVA: 0x0000584C File Offset: 0x00003A4C
		// (set) Token: 0x0600014E RID: 334 RVA: 0x00005860 File Offset: 0x00003A60
		public int LinePosition
		{
			[CompilerGenerated]
			get
			{
				return this.<LinePosition>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<LinePosition>k__BackingField = value;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600014F RID: 335 RVA: 0x00005874 File Offset: 0x00003A74
		// (set) Token: 0x06000150 RID: 336 RVA: 0x00005888 File Offset: 0x00003A88
		public string Path
		{
			[CompilerGenerated]
			get
			{
				return this.<Path>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Path>k__BackingField = value;
			}
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0000589C File Offset: 0x00003A9C
		public JsonReaderException()
		{
		}

		// Token: 0x06000152 RID: 338 RVA: 0x000058B0 File Offset: 0x00003AB0
		public JsonReaderException(string message)
			: base(message)
		{
		}

		// Token: 0x06000153 RID: 339 RVA: 0x000058C4 File Offset: 0x00003AC4
		public JsonReaderException(string message, Exception innerException)
			: base(message, innerException)
		{
		}

		// Token: 0x06000154 RID: 340 RVA: 0x000058DC File Offset: 0x00003ADC
		public JsonReaderException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		// Token: 0x06000155 RID: 341 RVA: 0x000058F4 File Offset: 0x00003AF4
		internal JsonReaderException(string message, Exception innerException, string path, int lineNumber, int linePosition)
			: base(message, innerException)
		{
			this.Path = path;
			this.LineNumber = lineNumber;
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00005918 File Offset: 0x00003B18
		internal static JsonReaderException Create(JsonReader reader, string message)
		{
			JsonReaderException ex;
			return ex;
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00005928 File Offset: 0x00003B28
		internal static JsonReaderException Create(JsonReader reader, string message, Exception ex)
		{
			JsonReaderException ex2;
			return ex2;
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00005938 File Offset: 0x00003B38
		internal static JsonReaderException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex)
		{
			/*
An exception occurred when decompiling this method (06000158)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Newtonsoft.Json.JsonReaderException Newtonsoft.Json.JsonReaderException::Create(Newtonsoft.Json.IJsonLineInfo,System.String,System.String,System.Exception)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int64(var_1_09, ldfld:int64(int64::m_value, ldc.i4:int32[exp:int64&](0)))
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

		// Token: 0x040000C6 RID: 198
		[CompilerGenerated]
		private int <LineNumber>k__BackingField;

		// Token: 0x040000C7 RID: 199
		[CompilerGenerated]
		private int <LinePosition>k__BackingField;

		// Token: 0x040000C8 RID: 200
		[CompilerGenerated]
		private string <Path>k__BackingField;
	}
}
