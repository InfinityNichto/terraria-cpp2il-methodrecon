using System;
using System.Collections;
using System.Globalization;
using System.Threading;

namespace System.Diagnostics
{
	// Token: 0x020000CC RID: 204
	public class TraceEventCache
	{
		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060004A0 RID: 1184 RVA: 0x00013654 File Offset: 0x00011854
		public string Callstack
		{
			get
			{
				string text;
				if (this.stackTrace == null)
				{
					text = Environment.StackTrace;
					this.stackTrace = text;
				}
				return text;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x00013678 File Offset: 0x00011878
		public Stack LogicalOperationStack
		{
			get
			{
				return Trace.CorrelationManager.GetLogicalOperationStack();
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060004A2 RID: 1186 RVA: 0x00013690 File Offset: 0x00011890
		public DateTime DateTime
		{
			get
			{
				DateTime dateTime = this.dateTime;
				if (!true)
				{
				}
				if (!true)
				{
				}
				DateTime utcNow = DateTime.UtcNow;
				this.dateTime = utcNow;
				return 1;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060004A3 RID: 1187 RVA: 0x000136C4 File Offset: 0x000118C4
		public int ProcessId
		{
			get
			{
				return TraceEventCache.GetProcessId();
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060004A4 RID: 1188 RVA: 0x000136D8 File Offset: 0x000118D8
		public string ThreadId
		{
			get
			{
				int managedThreadId = Thread.CurrentThread.ManagedThreadId;
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
				string text;
				return text;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060004A5 RID: 1189 RVA: 0x000136FC File Offset: 0x000118FC
		public long Timestamp
		{
			get
			{
				/*
An exception occurred when decompiling this method (060004A5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int64 System.Diagnostics.TraceEventCache::get_Timestamp()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int64(var_0_06, ldfld:int64(TraceEventCache::timeStamp, ldloc:TraceEventCache(this)))
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
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00013710 File Offset: 0x00011910
		private static void InitProcessInfo()
		{
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00013764 File Offset: 0x00011964
		internal static int GetProcessId()
		{
			/*
An exception occurred when decompiling this method (060004A7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Diagnostics.TraceEventCache::GetProcessId()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(TraceEventCache::InitProcessInfo)
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

		// Token: 0x060004A8 RID: 1192 RVA: 0x00013778 File Offset: 0x00011978
		internal static int GetThreadId()
		{
			return Thread.CurrentThread.ManagedThreadId;
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00013794 File Offset: 0x00011994
		public TraceEventCache()
		{
			if (!true)
			{
			}
			this.dateTime = 1;
			base..ctor();
		}

		// Token: 0x04000395 RID: 917
		private static int processId;

		// Token: 0x04000396 RID: 918
		private static string processName;

		// Token: 0x04000397 RID: 919
		private long timeStamp = 1L;

		// Token: 0x04000398 RID: 920
		private DateTime dateTime;

		// Token: 0x04000399 RID: 921
		private string stackTrace;
	}
}
