using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x02000107 RID: 263
	[Serializable]
	public readonly struct TimeSpan : IComparable, IComparable<TimeSpan>, IEquatable<TimeSpan>, IFormattable, ISpanFormattable
	{
		// Token: 0x060009A7 RID: 2471 RVA: 0x000172F4 File Offset: 0x000154F4
		public TimeSpan(long ticks)
		{
			this._ticks = ticks;
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x00017308 File Offset: 0x00015508
		public TimeSpan(int hours, int minutes, int seconds)
		{
			if (!true)
			{
			}
			long num = TimeSpan.TimeToTicks(hours, minutes, seconds);
			this._ticks = num;
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x00017328 File Offset: 0x00015528
		public TimeSpan(int days, int hours, int minutes, int seconds, int milliseconds)
		{
			int num = 20864;
			this._ticks = (long)num;
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060009AA RID: 2474 RVA: 0x0000207A File Offset: 0x0000027A
		public long Ticks
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060009AB RID: 2475 RVA: 0x0000207A File Offset: 0x0000027A
		public int Days
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060009AC RID: 2476 RVA: 0x0000207A File Offset: 0x0000027A
		public int Hours
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060009AD RID: 2477 RVA: 0x0000207A File Offset: 0x0000027A
		public int Milliseconds
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060009AE RID: 2478 RVA: 0x0000207A File Offset: 0x0000027A
		public int Minutes
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060009AF RID: 2479 RVA: 0x0000207A File Offset: 0x0000027A
		public int Seconds
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060009B0 RID: 2480 RVA: 0x0000207A File Offset: 0x0000027A
		public double TotalDays
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060009B1 RID: 2481 RVA: 0x0000207A File Offset: 0x0000027A
		public double TotalHours
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060009B2 RID: 2482 RVA: 0x0000207A File Offset: 0x0000027A
		public double TotalMilliseconds
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060009B3 RID: 2483 RVA: 0x0000207A File Offset: 0x0000027A
		public double TotalMinutes
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060009B4 RID: 2484 RVA: 0x0000207A File Offset: 0x0000027A
		public double TotalSeconds
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x0000207A File Offset: 0x0000027A
		public TimeSpan Add(TimeSpan ts)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x00017350 File Offset: 0x00015550
		public static int Compare(TimeSpan t1, TimeSpan t2)
		{
			return 1;
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x00017360 File Offset: 0x00015560
		public int CompareTo(object value)
		{
			if (value != null)
			{
			}
			return 1;
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x00017374 File Offset: 0x00015574
		public int CompareTo(TimeSpan value)
		{
			return 1;
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x00017384 File Offset: 0x00015584
		public static TimeSpan FromDays(double value)
		{
			if (!true)
			{
			}
			TimeSpan timeSpan = TimeSpan.Interval(value, 23552);
			return 1;
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x000173A4 File Offset: 0x000155A4
		public override bool Equals(object value)
		{
			if (value != null)
			{
				return;
			}
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x0000207A File Offset: 0x0000027A
		public bool Equals(TimeSpan obj)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x000173B8 File Offset: 0x000155B8
		public override int GetHashCode()
		{
			/*
An exception occurred when decompiling this method (060009BC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.TimeSpan::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int64(var_0_06, ldfld:int64(TimeSpan::_ticks, ldloc:valuetype System.TimeSpan&(this)))
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

		// Token: 0x060009BD RID: 2493 RVA: 0x000173CC File Offset: 0x000155CC
		public static TimeSpan FromHours(double value)
		{
			if (!true)
			{
			}
			TimeSpan timeSpan = TimeSpan.Interval(value, 61056);
			return 1;
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x0000207A File Offset: 0x0000027A
		private static TimeSpan Interval(double value, int scale)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x000173EC File Offset: 0x000155EC
		public static TimeSpan FromMilliseconds(double value)
		{
			if (!true)
			{
			}
			TimeSpan timeSpan = TimeSpan.Interval(value, 1);
			return 1;
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x00017408 File Offset: 0x00015608
		public static TimeSpan FromMinutes(double value)
		{
			if (!true)
			{
			}
			TimeSpan timeSpan = TimeSpan.Interval(value, 60000);
			return 1;
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x00017428 File Offset: 0x00015628
		public TimeSpan Negate()
		{
			/*
An exception occurred when decompiling this method (060009C1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.TimeSpan System.TimeSpan::Negate()

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

		// Token: 0x060009C2 RID: 2498 RVA: 0x00017438 File Offset: 0x00015638
		public static TimeSpan FromSeconds(double value)
		{
			if (!true)
			{
			}
			TimeSpan timeSpan = TimeSpan.Interval(value, 1000);
			return 1;
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x0000207A File Offset: 0x0000027A
		public TimeSpan Subtract(TimeSpan ts)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x00017458 File Offset: 0x00015658
		public static TimeSpan FromTicks(long value)
		{
			TimeSpan timeSpan;
			return timeSpan;
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x00017468 File Offset: 0x00015668
		internal static long TimeToTicks(int hour, int minute, int second)
		{
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x00017480 File Offset: 0x00015680
		public static TimeSpan Parse(string s)
		{
			/*
An exception occurred when decompiling this method (060009C6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.TimeSpan System.TimeSpan::Parse(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0013:
	call:void(ThrowHelper::ThrowArgumentNullException, ldc.i4:ExceptionArgument(49))
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

		// Token: 0x060009C7 RID: 2503 RVA: 0x000174A8 File Offset: 0x000156A8
		public static TimeSpan Parse(string input, IFormatProvider formatProvider)
		{
			/*
An exception occurred when decompiling this method (060009C7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.TimeSpan System.TimeSpan::Parse(System.String,System.IFormatProvider)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0013:
	call:void(ThrowHelper::ThrowArgumentNullException, ldc.i4:ExceptionArgument(49))
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

		// Token: 0x060009C8 RID: 2504 RVA: 0x000174D0 File Offset: 0x000156D0
		public static bool TryParseExact(string input, string format, IFormatProvider formatProvider, [Out] TimeSpan result)
		{
			if (input != null)
			{
				char rawStringData = input.GetRawStringData();
				int stringLength = input._stringLength;
				bool flag;
				return flag;
			}
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x000174F4 File Offset: 0x000156F4
		public override string ToString()
		{
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x00017508 File Offset: 0x00015708
		public string ToString(string format)
		{
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x0001751C File Offset: 0x0001571C
		public string ToString(string format, IFormatProvider formatProvider)
		{
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x00017530 File Offset: 0x00015730
		public bool TryFormat(Span<char> destination, [Out] int charsWritten, [Optional] ReadOnlySpan<char> format, [Optional] IFormatProvider formatProvider)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x00017544 File Offset: 0x00015744
		public static TimeSpan operator -(TimeSpan t)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x00017558 File Offset: 0x00015758
		public static TimeSpan operator -(TimeSpan t1, TimeSpan t2)
		{
			TimeSpan timeSpan = t1.Subtract(t2);
			TimeSpan timeSpan2;
			return timeSpan2;
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x00017570 File Offset: 0x00015770
		public static TimeSpan operator +(TimeSpan t1, TimeSpan t2)
		{
			TimeSpan timeSpan = t1.Add(t2);
			TimeSpan timeSpan2;
			return timeSpan2;
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x0000207A File Offset: 0x0000027A
		public static bool operator ==(TimeSpan t1, TimeSpan t2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x0000207A File Offset: 0x0000027A
		public static bool operator !=(TimeSpan t1, TimeSpan t2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x0000207A File Offset: 0x0000027A
		public static bool operator <(TimeSpan t1, TimeSpan t2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x0000207A File Offset: 0x0000027A
		public static bool operator <=(TimeSpan t1, TimeSpan t2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x0000207A File Offset: 0x0000027A
		public static bool operator >(TimeSpan t1, TimeSpan t2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x0000207A File Offset: 0x0000027A
		public static bool operator >=(TimeSpan t1, TimeSpan t2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x00017588 File Offset: 0x00015788
		// Note: this type is marked as 'beforefieldinit'.
		static TimeSpan()
		{
		}

		// Token: 0x040003B3 RID: 947
		public const long TicksPerMillisecond = 10000L;

		// Token: 0x040003B4 RID: 948
		private const double MillisecondsPerTick = 0.0001;

		// Token: 0x040003B5 RID: 949
		public const long TicksPerSecond = 10000000L;

		// Token: 0x040003B6 RID: 950
		private const double SecondsPerTick = 1E-07;

		// Token: 0x040003B7 RID: 951
		public const long TicksPerMinute = 600000000L;

		// Token: 0x040003B8 RID: 952
		private const double MinutesPerTick = 1.6666666666666667E-09;

		// Token: 0x040003B9 RID: 953
		public const long TicksPerHour = 36000000000L;

		// Token: 0x040003BA RID: 954
		private const double HoursPerTick = 2.7777777777777777E-11;

		// Token: 0x040003BB RID: 955
		public const long TicksPerDay = 864000000000L;

		// Token: 0x040003BC RID: 956
		private const double DaysPerTick = 1.1574074074074074E-12;

		// Token: 0x040003BD RID: 957
		private const int MillisPerSecond = 1000;

		// Token: 0x040003BE RID: 958
		private const int MillisPerMinute = 60000;

		// Token: 0x040003BF RID: 959
		private const int MillisPerHour = 3600000;

		// Token: 0x040003C0 RID: 960
		private const int MillisPerDay = 86400000;

		// Token: 0x040003C1 RID: 961
		internal const long MaxSeconds = 922337203685L;

		// Token: 0x040003C2 RID: 962
		internal const long MinSeconds = -922337203685L;

		// Token: 0x040003C3 RID: 963
		internal const long MaxMilliSeconds = 922337203685477L;

		// Token: 0x040003C4 RID: 964
		internal const long MinMilliSeconds = -922337203685477L;

		// Token: 0x040003C5 RID: 965
		internal const long TicksPerTenthSecond = 1000000L;

		// Token: 0x040003C6 RID: 966
		public static readonly TimeSpan Zero;

		// Token: 0x040003C7 RID: 967
		public static readonly TimeSpan MaxValue;

		// Token: 0x040003C8 RID: 968
		public static readonly TimeSpan MinValue;

		// Token: 0x040003C9 RID: 969
		internal readonly long _ticks;
	}
}
