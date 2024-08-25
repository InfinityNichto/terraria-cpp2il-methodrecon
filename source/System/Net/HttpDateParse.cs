using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Net
{
	// Token: 0x020001E9 RID: 489
	internal static class HttpDateParse
	{
		// Token: 0x06000C05 RID: 3077 RVA: 0x00026FA8 File Offset: 0x000251A8
		private static char MAKE_UPPER(char c)
		{
			if (!true)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			char c2;
			return c2;
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x00026FC4 File Offset: 0x000251C4
		private static int MapDayMonthToDword(char[] lpszDay, int index)
		{
			char c2;
			char c = HttpDateParse.MAKE_UPPER(c2);
			return 12;
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x00027048 File Offset: 0x00025248
		public static bool ParseHttpDate(string DateString, [Out] DateTime dtOut)
		{
			/*
An exception occurred when decompiling this method (06000C07)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.HttpDateParse::ParseHttpDate(System.String,System.DateTime)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int64(var_4_07, ldc.i4:int64(0))
	stloc:int32(var_5_11, call:int32(HttpDateParse::MapDayMonthToDword, ldloc:char[](var_2), ldloc:int64[exp:int32](var_4_07)))
	stloc:DateTime(var_9_27, call:DateTime(DateTime::ToLocalTime, call:DateTime[exp:valuetype [mscorlib]System.DateTime&](DateTime::AddHours, ldloc:DateTime[exp:valuetype [mscorlib]System.DateTime&](var_8), ldloc:int64[exp:float64](var_4_07))))
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

		// Token: 0x04000A4D RID: 2637
		private const int BASE_DEC = 10;

		// Token: 0x04000A4E RID: 2638
		private const int DATE_INDEX_DAY_OF_WEEK = 0;

		// Token: 0x04000A4F RID: 2639
		private const int DATE_1123_INDEX_DAY = 1;

		// Token: 0x04000A50 RID: 2640
		private const int DATE_1123_INDEX_MONTH = 2;

		// Token: 0x04000A51 RID: 2641
		private const int DATE_1123_INDEX_YEAR = 3;

		// Token: 0x04000A52 RID: 2642
		private const int DATE_1123_INDEX_HRS = 4;

		// Token: 0x04000A53 RID: 2643
		private const int DATE_1123_INDEX_MINS = 5;

		// Token: 0x04000A54 RID: 2644
		private const int DATE_1123_INDEX_SECS = 6;

		// Token: 0x04000A55 RID: 2645
		private const int DATE_ANSI_INDEX_MONTH = 1;

		// Token: 0x04000A56 RID: 2646
		private const int DATE_ANSI_INDEX_DAY = 2;

		// Token: 0x04000A57 RID: 2647
		private const int DATE_ANSI_INDEX_HRS = 3;

		// Token: 0x04000A58 RID: 2648
		private const int DATE_ANSI_INDEX_MINS = 4;

		// Token: 0x04000A59 RID: 2649
		private const int DATE_ANSI_INDEX_SECS = 5;

		// Token: 0x04000A5A RID: 2650
		private const int DATE_ANSI_INDEX_YEAR = 6;

		// Token: 0x04000A5B RID: 2651
		private const int DATE_INDEX_TZ = 7;

		// Token: 0x04000A5C RID: 2652
		private const int DATE_INDEX_LAST = 7;

		// Token: 0x04000A5D RID: 2653
		private const int MAX_FIELD_DATE_ENTRIES = 8;

		// Token: 0x04000A5E RID: 2654
		private const int DATE_TOKEN_JANUARY = 1;

		// Token: 0x04000A5F RID: 2655
		private const int DATE_TOKEN_FEBRUARY = 2;

		// Token: 0x04000A60 RID: 2656
		private const int DATE_TOKEN_Microsoft = 3;

		// Token: 0x04000A61 RID: 2657
		private const int DATE_TOKEN_APRIL = 4;

		// Token: 0x04000A62 RID: 2658
		private const int DATE_TOKEN_MAY = 5;

		// Token: 0x04000A63 RID: 2659
		private const int DATE_TOKEN_JUNE = 6;

		// Token: 0x04000A64 RID: 2660
		private const int DATE_TOKEN_JULY = 7;

		// Token: 0x04000A65 RID: 2661
		private const int DATE_TOKEN_AUGUST = 8;

		// Token: 0x04000A66 RID: 2662
		private const int DATE_TOKEN_SEPTEMBER = 9;

		// Token: 0x04000A67 RID: 2663
		private const int DATE_TOKEN_OCTOBER = 10;

		// Token: 0x04000A68 RID: 2664
		private const int DATE_TOKEN_NOVEMBER = 11;

		// Token: 0x04000A69 RID: 2665
		private const int DATE_TOKEN_DECEMBER = 12;

		// Token: 0x04000A6A RID: 2666
		private const int DATE_TOKEN_LAST_MONTH = 13;

		// Token: 0x04000A6B RID: 2667
		private const int DATE_TOKEN_SUNDAY = 0;

		// Token: 0x04000A6C RID: 2668
		private const int DATE_TOKEN_MONDAY = 1;

		// Token: 0x04000A6D RID: 2669
		private const int DATE_TOKEN_TUESDAY = 2;

		// Token: 0x04000A6E RID: 2670
		private const int DATE_TOKEN_WEDNESDAY = 3;

		// Token: 0x04000A6F RID: 2671
		private const int DATE_TOKEN_THURSDAY = 4;

		// Token: 0x04000A70 RID: 2672
		private const int DATE_TOKEN_FRIDAY = 5;

		// Token: 0x04000A71 RID: 2673
		private const int DATE_TOKEN_SATURDAY = 6;

		// Token: 0x04000A72 RID: 2674
		private const int DATE_TOKEN_LAST_DAY = 7;

		// Token: 0x04000A73 RID: 2675
		private const int DATE_TOKEN_GMT = -1000;

		// Token: 0x04000A74 RID: 2676
		private const int DATE_TOKEN_LAST = -1000;

		// Token: 0x04000A75 RID: 2677
		private const int DATE_TOKEN_ERROR = -999;
	}
}
