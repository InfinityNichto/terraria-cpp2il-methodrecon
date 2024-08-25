using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Cpp2IlInjected;

namespace System.Diagnostics
{
	// Token: 0x020005D4 RID: 1492
	[ComVisible(true)]
	[MonoTODO("Serialized objects are not compatible with .NET")]
	[Serializable]
	public class StackTrace
	{
		// Token: 0x06002D6A RID: 11626 RVA: 0x00064758 File Offset: 0x00062958
		public StackTrace()
		{
			long num = 0L;
			long num2 = 0L;
			this.init_frames((int)num, num2 != 0L);
		}

		// Token: 0x06002D6B RID: 11627 RVA: 0x00064778 File Offset: 0x00062978
		public StackTrace(bool fNeedFileInfo)
		{
		}

		// Token: 0x06002D6C RID: 11628 RVA: 0x0006478C File Offset: 0x0006298C
		public StackTrace(int skipFrames, bool fNeedFileInfo)
		{
			this.init_frames(skipFrames, fNeedFileInfo);
		}

		// Token: 0x06002D6D RID: 11629 RVA: 0x000647A8 File Offset: 0x000629A8
		private void init_frames(int skipFrames, bool fNeedFileInfo)
		{
		}

		// Token: 0x06002D6E RID: 11630 RVA: 0x0000207A File Offset: 0x0000027A
		private static StackFrame[] get_trace(Exception e, int skipFrames, bool fNeedFileInfo)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002D6F RID: 11631 RVA: 0x000647B8 File Offset: 0x000629B8
		public StackTrace(Exception e, bool fNeedFileInfo)
		{
		}

		// Token: 0x06002D70 RID: 11632 RVA: 0x000647C8 File Offset: 0x000629C8
		public StackTrace(Exception e, int skipFrames, bool fNeedFileInfo)
		{
			if (e != null)
			{
				this.frames = e;
				StackTrace[] array = e.captured_traces;
				this.captured_traces = array;
				return;
			}
		}

		// Token: 0x06002D71 RID: 11633 RVA: 0x000647F4 File Offset: 0x000629F4
		[MonoLimitation("Not possible to create StackTraces from other threads")]
		[Obsolete]
		public StackTrace(Thread targetThread, bool needFileInfo)
		{
			Thread currentThread = Thread.CurrentThread;
			long num = 0L;
			this.init_frames((int)num, needFileInfo);
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x06002D72 RID: 11634 RVA: 0x0006481C File Offset: 0x00062A1C
		public virtual int FrameCount
		{
			get
			{
				StackFrame[] array = this.frames;
				if (array != null)
				{
					long methodAddress = array.methodAddress;
					return;
				}
			}
		}

		// Token: 0x06002D73 RID: 11635 RVA: 0x0006483C File Offset: 0x00062A3C
		public virtual StackFrame GetFrame(int index)
		{
			/*
An exception occurred when decompiling this method (06002D73)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Diagnostics.StackFrame System.Diagnostics.StackTrace::GetFrame(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint32(var_0_0B, ldfld:uint32(StackFrame::methodIndex, ldfld:class System.Diagnostics.StackFrame[][exp:StackFrame](StackTrace::frames, ldloc:StackTrace(this))))
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

		// Token: 0x06002D74 RID: 11636 RVA: 0x00064858 File Offset: 0x00062A58
		private static string GetAotId()
		{
			string text;
			if (RuntimeAssembly.GetAotId() != null)
			{
				return text;
			}
			return text;
		}

		// Token: 0x06002D75 RID: 11637 RVA: 0x00064874 File Offset: 0x00062A74
		private bool AddFrames(StringBuilder sb, bool separator, [Out] bool isAsync)
		{
			/*
An exception occurred when decompiling this method (06002D75)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Diagnostics.StackTrace::AddFrames(System.Text.StringBuilder,System.Boolean,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0075:
	stloc:string(var_18_81, call:string(string::Format, ldstr:string("<{0}>"), ldloc:string[exp:object](var_15)))
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

		// Token: 0x06002D76 RID: 11638 RVA: 0x00064904 File Offset: 0x00062B04
		private void GetFullNameForStackTrace(StringBuilder sb, MethodBase mi, bool needsNewLine, [Out] bool skipped, [Out] bool isAsync)
		{
		}

		// Token: 0x06002D77 RID: 11639 RVA: 0x000649F0 File Offset: 0x00062BF0
		private static void ConvertAsyncStateMachineMethod(MethodBase method, Type declaringType)
		{
			IEnumerable enumerable;
			if (enumerable != null)
			{
				return;
			}
		}

		// Token: 0x06002D78 RID: 11640 RVA: 0x00064A48 File Offset: 0x00062C48
		public override string ToString()
		{
			/*
An exception occurred when decompiling this method (06002D78)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Diagnostics.StackTrace::ToString()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_1:
	stloc:string(var_5_1E, callgetter:string(Environment::get_NewLine))
	stloc:string(var_9_28, callgetter:string(Environment::get_NewLine))
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

		// Token: 0x06002D79 RID: 11641 RVA: 0x0000207A File Offset: 0x0000027A
		internal string ToString(StackTrace.TraceFormat traceFormat)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0400196A RID: 6506
		public const int METHODS_TO_SKIP = 0;

		// Token: 0x0400196B RID: 6507
		private const string prefix = "  at ";

		// Token: 0x0400196C RID: 6508
		private StackFrame[] frames;

		// Token: 0x0400196D RID: 6509
		private readonly StackTrace[] captured_traces;

		// Token: 0x0400196E RID: 6510
		private bool debug_info;

		// Token: 0x0400196F RID: 6511
		private static bool isAotidSet;

		// Token: 0x04001970 RID: 6512
		private static string aotid;

		// Token: 0x020005D5 RID: 1493
		internal enum TraceFormat
		{
			// Token: 0x04001972 RID: 6514
			Normal,
			// Token: 0x04001973 RID: 6515
			TrailingNewLine,
			// Token: 0x04001974 RID: 6516
			NoResourceLookup
		}
	}
}
