using System;
using Cpp2IlInjected;

namespace System.Diagnostics
{
	// Token: 0x020000E3 RID: 227
	public class Stopwatch
	{
		// Token: 0x06000530 RID: 1328 RVA: 0x00002050 File Offset: 0x00000250
		public static long GetTimestamp()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x00014DFC File Offset: 0x00012FFC
		public Stopwatch()
		{
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000532 RID: 1330 RVA: 0x00014E10 File Offset: 0x00013010
		public TimeSpan Elapsed
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000532)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.TimeSpan System.Diagnostics.Stopwatch::get_Elapsed()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0016:
	stloc:TimeSpan(var_2_1C, call:TimeSpan(TimeSpan::FromTicks, ldloc:int64(var_1_0B)))
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

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000533 RID: 1331 RVA: 0x00014E3C File Offset: 0x0001303C
		public long ElapsedMilliseconds
		{
			get
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num != 0)
				{
					return this.ElapsedTicks;
				}
				TimeSpan timeSpan;
				double totalMilliseconds = timeSpan.TotalMilliseconds;
				throw new OverflowException();
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000534 RID: 1332 RVA: 0x00014E64 File Offset: 0x00013064
		public long ElapsedTicks
		{
			get
			{
				if (this.is_running)
				{
					long num = this.elapsed;
					long num2 = this.started;
				}
				return this.elapsed;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000535 RID: 1333 RVA: 0x00014E90 File Offset: 0x00013090
		public bool IsRunning
		{
			get
			{
				return this.is_running;
			}
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x00014EA4 File Offset: 0x000130A4
		public void Reset()
		{
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x00014EB4 File Offset: 0x000130B4
		public void Start()
		{
			if (!this.is_running)
			{
				this.is_running = true;
			}
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x00014ED0 File Offset: 0x000130D0
		public void Stop()
		{
			if (this.is_running)
			{
				long num = this.elapsed;
				long num2 = this.started;
				this.elapsed = num2;
			}
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00014EFC File Offset: 0x000130FC
		public void Restart()
		{
			if (!true)
			{
			}
			this.is_running = true;
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x00014F14 File Offset: 0x00013114
		// Note: this type is marked as 'beforefieldinit'.
		static Stopwatch()
		{
		}

		// Token: 0x04000428 RID: 1064
		public static readonly long Frequency;

		// Token: 0x04000429 RID: 1065
		public static readonly bool IsHighResolution;

		// Token: 0x0400042A RID: 1066
		private long elapsed;

		// Token: 0x0400042B RID: 1067
		private long started;

		// Token: 0x0400042C RID: 1068
		private bool is_running;
	}
}
