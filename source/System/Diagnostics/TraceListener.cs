using System;
using System.Collections;
using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Diagnostics
{
	// Token: 0x020000D1 RID: 209
	public abstract class TraceListener : MarshalByRefObject, IDisposable
	{
		// Token: 0x060004B2 RID: 1202 RVA: 0x00013834 File Offset: 0x00011A34
		protected TraceListener(string name)
		{
			this.listenerName = name;
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x0001385C File Offset: 0x00011A5C
		public virtual bool IsThreadSafe
		{
			get
			{
			}
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x0001386C File Offset: 0x00011A6C
		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00013880 File Offset: 0x00011A80
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00013890 File Offset: 0x00011A90
		public virtual void Flush()
		{
		}

		// Token: 0x170000D6 RID: 214
		// (set) Token: 0x060004B7 RID: 1207 RVA: 0x000138A0 File Offset: 0x00011AA0
		public int IndentLevel
		{
			set
			{
			}
		}

		// Token: 0x170000D7 RID: 215
		// (set) Token: 0x060004B8 RID: 1208 RVA: 0x000138B0 File Offset: 0x00011AB0
		public int IndentSize
		{
			set
			{
				this.indentSize = value;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x000138D0 File Offset: 0x00011AD0
		[ComVisible(false)]
		public TraceFilter Filter
		{
			get
			{
				return this.filter;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060004BA RID: 1210 RVA: 0x000138E4 File Offset: 0x00011AE4
		// (set) Token: 0x060004BB RID: 1211 RVA: 0x000138F8 File Offset: 0x00011AF8
		protected bool NeedIndent
		{
			get
			{
				return this.needIndent;
			}
			set
			{
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060004BC RID: 1212 RVA: 0x00013908 File Offset: 0x00011B08
		[ComVisible(false)]
		public TraceOptions TraceOutputOptions
		{
			get
			{
				return this.traceOptions;
			}
		}

		// Token: 0x060004BD RID: 1213
		public abstract void Write(string message);

		// Token: 0x060004BE RID: 1214 RVA: 0x0001391C File Offset: 0x00011B1C
		protected virtual void WriteIndent()
		{
			int num = this.indentLevel;
			int num2 = this.indentSize;
		}

		// Token: 0x060004BF RID: 1215
		public abstract void WriteLine(string message);

		// Token: 0x060004C0 RID: 1216 RVA: 0x0001394C File Offset: 0x00011B4C
		[ComVisible(false)]
		public virtual void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string message)
		{
			if (this.filter != null)
			{
			}
			this.WriteHeader(source, eventType, id);
			this.WriteFooter(eventCache);
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00013974 File Offset: 0x00011B74
		private void WriteHeader(string source, TraceEventType eventType, int id)
		{
			if (!true)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			CultureInfo invariantCulture2 = CultureInfo.InvariantCulture;
			string text2;
			string text3;
			string text = string.Format(invariantCulture, "{0} {1}: {2} : ", source, text2, text3);
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x000139A8 File Offset: 0x00011BA8
		private void WriteFooter(TraceEventCache eventCache)
		{
			if (eventCache != null)
			{
				int num = this.indentLevel;
				TraceOptions traceOptions = this.traceOptions;
				this.indentLevel = num;
				string text = TraceEventCache.GetProcessId().ToString();
				string text2 = "ProcessId=" + text;
				TraceOptions traceOptions2 = this.traceOptions;
				Stack logicalOperationStack = Trace.CorrelationManager.GetLogicalOperationStack();
				if ("LogicalOperationStack=" != null)
				{
				}
				return;
			}
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00013AF0 File Offset: 0x00011CF0
		internal bool IsEnabled(TraceOptions opts)
		{
			/*
An exception occurred when decompiling this method (060004C3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Diagnostics.TraceListener::IsEnabled(System.Diagnostics.TraceOptions)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:TraceOptions(var_0_06, ldfld:TraceOptions(TraceListener::traceOptions, ldloc:TraceListener(this)))
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

		// Token: 0x040003B1 RID: 945
		private int indentLevel;

		// Token: 0x040003B2 RID: 946
		private int indentSize = 4;

		// Token: 0x040003B3 RID: 947
		private TraceOptions traceOptions;

		// Token: 0x040003B4 RID: 948
		private bool needIndent = true;

		// Token: 0x040003B5 RID: 949
		private string listenerName;

		// Token: 0x040003B6 RID: 950
		private TraceFilter filter;
	}
}
