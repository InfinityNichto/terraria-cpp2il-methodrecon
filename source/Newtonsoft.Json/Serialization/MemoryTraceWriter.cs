using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200007D RID: 125
	[Preserve]
	public class MemoryTraceWriter : ITraceWriter
	{
		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000460 RID: 1120 RVA: 0x0000BB1C File Offset: 0x00009D1C
		// (set) Token: 0x06000461 RID: 1121 RVA: 0x0000BB30 File Offset: 0x00009D30
		public TraceLevel LevelFilter
		{
			[CompilerGenerated]
			get
			{
				return this.<LevelFilter>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<LevelFilter>k__BackingField = value;
			}
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x0000BB44 File Offset: 0x00009D44
		public MemoryTraceWriter()
		{
			this.LevelFilter = TraceLevel.Verbose;
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x0000BB60 File Offset: 0x00009D60
		public void Trace(TraceLevel level, string message, Exception ex)
		{
			Queue<string> traceMessages = this._traceMessages;
			int size = traceMessages._size;
			string text = traceMessages.Dequeue();
			DateTime now = DateTime.Now;
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			Queue<string> traceMessages2 = this._traceMessages;
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x0000BBA0 File Offset: 0x00009DA0
		public IEnumerable<string> GetTraceMessages()
		{
			/*
An exception occurred when decompiling this method (06000464)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IEnumerable`1<System.String> Newtonsoft.Json.Serialization.MemoryTraceWriter::GetTraceMessages()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.Queue`1<string>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.Queue`1<string>(MemoryTraceWriter::_traceMessages, ldloc:MemoryTraceWriter(this)))
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

		// Token: 0x06000465 RID: 1125 RVA: 0x0000212A File Offset: 0x0000032A
		public override string ToString()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x04000211 RID: 529
		private readonly Queue<string> _traceMessages;

		// Token: 0x04000212 RID: 530
		[CompilerGenerated]
		private TraceLevel <LevelFilter>k__BackingField;
	}
}
