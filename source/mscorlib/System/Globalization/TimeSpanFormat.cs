using System;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Globalization
{
	// Token: 0x02000599 RID: 1433
	internal static class TimeSpanFormat
	{
		// Token: 0x06002B25 RID: 11045 RVA: 0x0005E564 File Offset: 0x0005C764
		private static void AppendNonNegativeInt32(StringBuilder sb, int n, int digits)
		{
			int num = 48;
			StringBuilder stringBuilder = sb.Append((char)num);
			StringBuilder stringBuilder2 = sb.Append((char)num);
		}

		// Token: 0x06002B26 RID: 11046 RVA: 0x0005E590 File Offset: 0x0005C790
		internal static string Format(TimeSpan value, string format, IFormatProvider formatProvider)
		{
			if (value != null)
			{
			}
			if (!true)
			{
			}
			StringBuilder stringBuilder;
			return StringBuilderCache.GetStringAndRelease(stringBuilder);
		}

		// Token: 0x06002B27 RID: 11047 RVA: 0x0005E5AC File Offset: 0x0005C7AC
		internal static bool TryFormat(TimeSpan value, Span<char> destination, [Out] int charsWritten, ReadOnlySpan<char> format, IFormatProvider formatProvider)
		{
			if (!true)
			{
			}
			StringBuilder stringBuilder;
			int length = stringBuilder.Length;
			StringBuilderCache.Release(stringBuilder);
			int length2 = stringBuilder.Length;
			charsWritten.m_value = length2;
			int length3 = stringBuilder.Length;
			StringBuilderCache.Release(stringBuilder);
			return true;
		}

		// Token: 0x06002B28 RID: 11048 RVA: 0x0005E5E8 File Offset: 0x0005C7E8
		private static StringBuilder FormatToBuilder(TimeSpan value, ReadOnlySpan<char> format, IFormatProvider formatProvider)
		{
			if (format != null)
			{
				return "c";
			}
			if ("c" != null)
			{
				if (!false)
				{
				}
				DateTimeFormatInfo dateTimeFormatInfo;
				string fullTimeSpanPositivePattern = dateTimeFormatInfo.FullTimeSpanPositivePattern;
			}
			StringBuilder stringBuilder;
			return stringBuilder;
		}

		// Token: 0x06002B29 RID: 11049 RVA: 0x0005E630 File Offset: 0x0005C830
		private static StringBuilder FormatStandard(TimeSpan value, bool isInvariant, ReadOnlySpan<char> format, TimeSpanFormat.Pattern pattern)
		{
			int num = 16;
			StringBuilder stringBuilder = StringBuilderCache.Acquire(num);
			if (33251 == 0)
			{
			}
			return 0;
		}

		// Token: 0x06002B2A RID: 11050 RVA: 0x0005E6F0 File Offset: 0x0005C8F0
		private static StringBuilder FormatCustomized(TimeSpan value, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, StringBuilder result)
		{
			if (result == null)
			{
				StringBuilder stringBuilder = StringBuilderCache.Acquire(16);
			}
			if (33251 == 0)
			{
			}
			StringBuilder stringBuilder2;
			return stringBuilder2;
		}

		// Token: 0x06002B2B RID: 11051 RVA: 0x0005E788 File Offset: 0x0005C988
		// Note: this type is marked as 'beforefieldinit'.
		static TimeSpanFormat()
		{
			TimeSpanFormat.FormatLiterals formatLiterals = TimeSpanFormat.FormatLiterals.InitInvariant(false);
			TimeSpanFormat.FormatLiterals formatLiterals2 = TimeSpanFormat.FormatLiterals.InitInvariant(true);
		}

		// Token: 0x040017B6 RID: 6070
		internal static readonly TimeSpanFormat.FormatLiterals PositiveInvariantFormatLiterals;

		// Token: 0x040017B7 RID: 6071
		internal static readonly TimeSpanFormat.FormatLiterals NegativeInvariantFormatLiterals;

		// Token: 0x0200059A RID: 1434
		internal enum Pattern
		{
			// Token: 0x040017B9 RID: 6073
			None,
			// Token: 0x040017BA RID: 6074
			Minimum,
			// Token: 0x040017BB RID: 6075
			Full
		}

		// Token: 0x0200059B RID: 1435
		internal struct FormatLiterals
		{
			// Token: 0x17000657 RID: 1623
			// (get) Token: 0x06002B2C RID: 11052 RVA: 0x0005E7A4 File Offset: 0x0005C9A4
			internal string Start
			{
				get
				{
					/*
An exception occurred when decompiling this method (06002B2C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Globalization.TimeSpanFormat/FormatLiterals::get_Start()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string[](var_0_06, ldfld:string[](FormatLiterals::_literals, ldloc:valuetype System.Globalization.TimeSpanFormat/FormatLiterals&(this)))
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

			// Token: 0x17000658 RID: 1624
			// (get) Token: 0x06002B2D RID: 11053 RVA: 0x0005E7B8 File Offset: 0x0005C9B8
			internal string DayHourSep
			{
				get
				{
					/*
An exception occurred when decompiling this method (06002B2D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Globalization.TimeSpanFormat/FormatLiterals::get_DayHourSep()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string[](var_0_06, ldfld:string[](FormatLiterals::_literals, ldloc:valuetype System.Globalization.TimeSpanFormat/FormatLiterals&(this)))
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

			// Token: 0x17000659 RID: 1625
			// (get) Token: 0x06002B2E RID: 11054 RVA: 0x0005E7CC File Offset: 0x0005C9CC
			internal string HourMinuteSep
			{
				get
				{
					/*
An exception occurred when decompiling this method (06002B2E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Globalization.TimeSpanFormat/FormatLiterals::get_HourMinuteSep()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string[](var_0_06, ldfld:string[](FormatLiterals::_literals, ldloc:valuetype System.Globalization.TimeSpanFormat/FormatLiterals&(this)))
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

			// Token: 0x1700065A RID: 1626
			// (get) Token: 0x06002B2F RID: 11055 RVA: 0x0005E7E0 File Offset: 0x0005C9E0
			internal string MinuteSecondSep
			{
				get
				{
					/*
An exception occurred when decompiling this method (06002B2F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Globalization.TimeSpanFormat/FormatLiterals::get_MinuteSecondSep()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string[](var_0_06, ldfld:string[](FormatLiterals::_literals, ldloc:valuetype System.Globalization.TimeSpanFormat/FormatLiterals&(this)))
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

			// Token: 0x1700065B RID: 1627
			// (get) Token: 0x06002B30 RID: 11056 RVA: 0x0005E7F4 File Offset: 0x0005C9F4
			internal string SecondFractionSep
			{
				get
				{
					/*
An exception occurred when decompiling this method (06002B30)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Globalization.TimeSpanFormat/FormatLiterals::get_SecondFractionSep()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string[](var_0_06, ldfld:string[](FormatLiterals::_literals, ldloc:valuetype System.Globalization.TimeSpanFormat/FormatLiterals&(this)))
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

			// Token: 0x1700065C RID: 1628
			// (get) Token: 0x06002B31 RID: 11057 RVA: 0x0005E808 File Offset: 0x0005CA08
			internal string End
			{
				get
				{
					/*
An exception occurred when decompiling this method (06002B31)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Globalization.TimeSpanFormat/FormatLiterals::get_End()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string[](var_0_06, ldfld:string[](FormatLiterals::_literals, ldloc:valuetype System.Globalization.TimeSpanFormat/FormatLiterals&(this)))
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

			// Token: 0x06002B32 RID: 11058 RVA: 0x0005E81C File Offset: 0x0005CA1C
			internal static TimeSpanFormat.FormatLiterals InitInvariant(bool isNegative)
			{
				return "-";
			}

			// Token: 0x06002B33 RID: 11059 RVA: 0x0005E87C File Offset: 0x0005CA7C
			internal void Init(ReadOnlySpan<char> format, bool useInvariantFieldLengths)
			{
				string[] literals = this._literals;
				int num = 16;
				StringBuilder stringBuilder = StringBuilderCache.Acquire(num);
			}

			// Token: 0x040017BC RID: 6076
			internal string AppCompatLiteral;

			// Token: 0x040017BD RID: 6077
			internal int dd;

			// Token: 0x040017BE RID: 6078
			internal int hh;

			// Token: 0x040017BF RID: 6079
			internal int mm;

			// Token: 0x040017C0 RID: 6080
			internal int ss;

			// Token: 0x040017C1 RID: 6081
			internal int ff;

			// Token: 0x040017C2 RID: 6082
			private string[] _literals;
		}
	}
}
