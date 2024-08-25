using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x020000AD RID: 173
	internal static class DateTimeParse
	{
		// Token: 0x060006AB RID: 1707 RVA: 0x000103E4 File Offset: 0x0000E5E4
		internal static DateTime ParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, DateTimeStyles style)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x000103F8 File Offset: 0x0000E5F8
		internal static DateTime ParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, DateTimeStyles style, [Out] TimeSpan offset)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x0001040C File Offset: 0x0000E60C
		internal static bool TryParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, DateTimeStyles style, [Out] DateTime result)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			return true;
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x00010424 File Offset: 0x0000E624
		internal static bool TryParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, DateTimeStyles style, [Out] DateTime result, [Out] TimeSpan offset)
		{
			if (!true)
			{
			}
			offset._ticks = 1L;
			if (!true)
			{
			}
			if (!true)
			{
			}
			offset._ticks = 1L;
			return true;
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x00010450 File Offset: 0x0000E650
		internal static bool TryParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, DateTimeStyles style, DateTimeResult result)
		{
			bool flag;
			if (s == null)
			{
				return flag;
			}
			if (dtfi != null)
			{
				return flag;
			}
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x0000207A File Offset: 0x0000027A
		internal static DateTime ParseExactMultiple(ReadOnlySpan<char> s, string[] formats, DateTimeFormatInfo dtfi, DateTimeStyles style)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x00010468 File Offset: 0x0000E668
		internal static bool TryParseExactMultiple(ReadOnlySpan<char> s, string[] formats, DateTimeFormatInfo dtfi, DateTimeStyles style, DateTimeResult result)
		{
			/*
An exception occurred when decompiling this method (060006B1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.DateTimeParse::TryParseExactMultiple(System.ReadOnlySpan`1<System.Char>,System.String[],System.Globalization.DateTimeFormatInfo,System.Globalization.DateTimeStyles,System.DateTimeResult)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001F:
	call:void(DateTimeResult::SetBadFormatSpecifierFailure, ldloc:DateTimeResult[exp:valuetype System.DateTimeResult&](result))
	stfld:DateTime(DateTimeResult::parsedDate, ldloc:DateTimeResult[exp:valuetype System.DateTimeResult&](result), ldstr:string[exp:DateTime]("Format_NoFormatSpecifier"))
	stfld:TimeSpan(DateTimeResult::timeZoneOffset, ldloc:DateTimeResult[exp:valuetype System.DateTimeResult&](result), ldstr:string[exp:TimeSpan]("Format_NoFormatSpecifier"))
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

		// Token: 0x060006B2 RID: 1714 RVA: 0x000104B8 File Offset: 0x0000E6B8
		private static bool MatchWord(__DTString str, string target)
		{
			int index = str.Index;
			ThrowHelper.ThrowArgumentOutOfRangeException();
			int num;
			if (num != 0)
			{
			}
			if (str.Index == 0)
			{
				return;
			}
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x000104E8 File Offset: 0x0000E6E8
		private static bool GetTimeZoneName(__DTString str)
		{
			if (!true)
			{
			}
			return true;
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x0000207A File Offset: 0x0000027A
		internal static bool IsDigit(char ch)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x00010500 File Offset: 0x0000E700
		private static bool ParseFraction(__DTString str, [Out] double result)
		{
			bool flag;
			return flag;
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x00010510 File Offset: 0x0000E710
		private static bool ParseTimeZone(__DTString str, TimeSpan result)
		{
			/*
An exception occurred when decompiling this method (060006B6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.DateTimeParse::ParseTimeZone(System.__DTString,System.TimeSpan)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int64(var_1_01, ldc.i4:int64(0))
	stloc:char(var_2_09, callgetter:char(DTSubString::get_Item, ldloc:DTSubString[exp:valuetype System.DTSubString&](var_0), ldloc:int64[exp:int32](var_1_01)))
	stloc:int64(var_6_0D, ldc.i4:int64(0))
	stloc:char(var_7_18, callgetter:char(DTSubString::get_Item, ldloc:DTSubString[exp:valuetype System.DTSubString&](var_5), ldloc:int64[exp:int32](var_6_0D)))
	stloc:int32(var_10_22, ldc.i4:int32(34079))
	stfld:valuetype System.ReadOnlySpan`1<char>(__DTString::Value, ldloc:__DTString[exp:valuetype System.__DTString&](str), ldloc:int32[exp:valuetype System.ReadOnlySpan`1<char>](var_10_22))
	stfld:valuetype System.ReadOnlySpan`1<char>(__DTString::Value, ldloc:__DTString[exp:valuetype System.__DTString&](str), ldloc:TimeSpan[exp:valuetype System.ReadOnlySpan`1<char>](var_15))
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

		// Token: 0x060006B7 RID: 1719 RVA: 0x00010560 File Offset: 0x0000E760
		private static bool HandleTimeZone(__DTString str, DateTimeResult result)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x00010578 File Offset: 0x0000E778
		private static bool Lex(DateTimeParse.DS dps, __DTString str, DateTimeToken dtok, DateTimeRawInfo raw, DateTimeResult result, DateTimeFormatInfo dtfi, DateTimeStyles styles)
		{
			int num = 18;
			str.Value = num;
			int num2 = dtok.num;
			if (3 == 0)
			{
			}
			if (!true)
			{
			}
			Calendar taiwanCalendarDefaultInstance = DateTimeParse.GetTaiwanCalendarDefaultInstance();
			DateTimeFormatInfo taiwanCalendarDTFI = DateTimeFormatInfo.GetTaiwanCalendarDTFI();
			if (!true)
			{
			}
			Calendar japaneseCalendarDefaultInstance = DateTimeParse.GetJapaneseCalendarDefaultInstance();
			DateTimeFormatInfo japaneseCalendarDTFI = DateTimeFormatInfo.GetJapaneseCalendarDTFI();
			result.Year = japaneseCalendarDTFI;
			double fraction = raw.fraction;
			int num3 = 16;
			raw.fraction = fraction;
			str.Value = num3;
			int num4 = 15;
			str.Value = num4;
			bool flag;
			return flag;
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x0001063C File Offset: 0x0000E83C
		private static Calendar GetJapaneseCalendarDefaultInstance()
		{
			do
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
			}
			while (true);
			return JapaneseCalendar.GetDefaultInstance();
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x0001065C File Offset: 0x0000E85C
		internal static Calendar GetTaiwanCalendarDefaultInstance()
		{
			do
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
			}
			while (true);
			return TaiwanCalendar.GetDefaultInstance();
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x0001067C File Offset: 0x0000E87C
		private static bool VerifyValidPunctuation(__DTString str)
		{
			int num = 1;
			if (num == 0 && num == 0)
			{
				if (num == 0)
				{
				}
				bool flag;
				return flag;
			}
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x000106A0 File Offset: 0x0000E8A0
		private static bool GetYearMonthDayOrder(string datePattern, DateTimeFormatInfo dtfi, [Out] int order)
		{
			long num = 0L;
			if (num == 0L)
			{
			}
			if (num == 0L)
			{
			}
			if (num == 0L)
			{
				return;
			}
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x000106D0 File Offset: 0x0000E8D0
		private static bool GetYearMonthOrder(string pattern, DateTimeFormatInfo dtfi, [Out] int order)
		{
			long num = 0L;
			if (num == 0L)
			{
			}
			if (num == 0L)
			{
				return;
			}
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x000106F0 File Offset: 0x0000E8F0
		private static bool GetMonthDayOrder(string pattern, DateTimeFormatInfo dtfi, [Out] int order)
		{
			if (!false)
			{
				return;
			}
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00010718 File Offset: 0x0000E918
		private static bool TryAdjustYear(DateTimeResult result, int year, [Out] int adjustedYear)
		{
			/*
An exception occurred when decompiling this method (060006BF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.DateTimeParse::TryAdjustYear(System.DateTimeResult,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](year), ldloc:DateTimeResult[exp:int32](result))
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

		// Token: 0x060006C0 RID: 1728 RVA: 0x00010734 File Offset: 0x0000E934
		private static bool SetDateYMD(DateTimeResult result, int year, int month, int day)
		{
			return true;
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x00010744 File Offset: 0x0000E944
		private static bool SetDateMDY(DateTimeResult result, int month, int day, int year)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x00010758 File Offset: 0x0000E958
		private static bool SetDateDMY(DateTimeResult result, int day, int month, int year)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x0001076C File Offset: 0x0000E96C
		private static bool SetDateYDM(DateTimeResult result, int year, int day, int month)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x00010780 File Offset: 0x0000E980
		private static void GetDefaultYear(DateTimeResult result, DateTimeStyles styles)
		{
			Calendar calendar = result.calendar;
			if (!true)
			{
			}
			DateTime dateTimeNow = DateTimeParse.GetDateTimeNow(result, styles);
			ParseFlags flags = result.flags;
			result.Year = calendar;
			result.flags = flags;
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x000107B4 File Offset: 0x0000E9B4
		private static bool GetDayOfNN(DateTimeResult result, DateTimeStyles styles, DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			return true;
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x000107C8 File Offset: 0x0000E9C8
		private static bool GetDayOfNNN(DateTimeResult result, DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			bool flag;
			return flag;
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x000107F0 File Offset: 0x0000E9F0
		private static bool GetDayOfMN(DateTimeResult result, DateTimeStyles styles, DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			bool flag;
			return flag;
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x0001080C File Offset: 0x0000EA0C
		private static bool GetHebrewDayOfNM(DateTimeResult result, DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			int hour = result.Hour;
			return true;
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x0001082C File Offset: 0x0000EA2C
		private static bool GetDayOfNM(DateTimeResult result, DateTimeStyles styles, DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			bool flag;
			return flag;
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x00010848 File Offset: 0x0000EA48
		private static bool GetDayOfMNN(DateTimeResult result, DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			int hour = result.Hour;
			int hour2 = result.Hour;
			bool flag;
			return flag;
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x00010874 File Offset: 0x0000EA74
		private static bool GetDayOfYNN(DateTimeResult result, DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			int minute = result.Minute;
			string text;
			if (text != null)
			{
			}
			return true;
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x00010894 File Offset: 0x0000EA94
		private static bool GetDayOfNNY(DateTimeResult result, DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			int minute = result.Minute;
			return true;
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x000108B0 File Offset: 0x0000EAB0
		private static bool GetDayOfYMN(DateTimeResult result, DateTimeRawInfo raw)
		{
			int hour = result.Hour;
			int second = result.Second;
			return true;
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x000108D4 File Offset: 0x0000EAD4
		private static bool GetDayOfYN(DateTimeResult result, DateTimeRawInfo raw)
		{
			int minute = result.Minute;
			return true;
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x000108F0 File Offset: 0x0000EAF0
		private static bool GetDayOfYM(DateTimeResult result, DateTimeRawInfo raw)
		{
			int hour = result.Hour;
			int second = result.Second;
			return true;
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x00010910 File Offset: 0x0000EB10
		private static void AdjustTimeMark(DateTimeFormatInfo dtfi, DateTimeRawInfo raw)
		{
			DateTimeParse.TM timeMark = raw.timeMark;
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x00010970 File Offset: 0x0000EB70
		private static bool AdjustHour(int hour, DateTimeParse.TM timeMark)
		{
			if (hour != 0)
			{
				return;
			}
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x00010984 File Offset: 0x0000EB84
		private static bool GetTimeOfN(DateTimeResult result, DateTimeRawInfo raw)
		{
			return true;
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x00010998 File Offset: 0x0000EB98
		private static bool GetTimeOfNN(DateTimeResult result, DateTimeRawInfo raw)
		{
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x000109A8 File Offset: 0x0000EBA8
		private static bool GetTimeOfNNN(DateTimeResult result, DateTimeRawInfo raw)
		{
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x000109BC File Offset: 0x0000EBBC
		private static bool GetDateOfDSN(DateTimeResult result, DateTimeRawInfo raw)
		{
			int day = result.Day;
			return true;
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x000109D8 File Offset: 0x0000EBD8
		private static bool GetDateOfNDS(DateTimeResult result, DateTimeRawInfo raw)
		{
			return true;
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x000109EC File Offset: 0x0000EBEC
		private static bool GetDateOfNNDS(DateTimeResult result, DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			int minute = result.Minute;
			return true;
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x00010A10 File Offset: 0x0000EC10
		private static bool ProcessDateTimeSuffix(DateTimeResult result, DateTimeRawInfo raw, DateTimeToken dtok)
		{
			int numCount = raw.numCount;
			int numCount2 = raw.numCount;
			int numCount3 = raw.numCount;
			int numCount4 = raw.numCount;
			int numCount5 = raw.numCount;
			result.Minute = numCount5;
			int numCount6 = raw.numCount;
			result.Hour = numCount6;
			return true;
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x00010A60 File Offset: 0x0000EC60
		internal static bool ProcessHebrewTerminalState(DateTimeParse.DS dps, __DTString str, DateTimeResult result, DateTimeStyles styles, DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			return "The DateTime represented by the string is not supported in calendar {0}." != null;
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00010A9C File Offset: 0x0000EC9C
		internal static bool ProcessTerminalState(DateTimeParse.DS dps, __DTString str, DateTimeResult result, DateTimeStyles styles, DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			bool flag;
			return flag;
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x00010ADC File Offset: 0x0000ECDC
		internal static DateTime Parse(ReadOnlySpan<char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x00010AF0 File Offset: 0x0000ECF0
		internal static DateTime Parse(ReadOnlySpan<char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles, [Out] TimeSpan offset)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x00010B04 File Offset: 0x0000ED04
		internal static bool TryParse(ReadOnlySpan<char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles, [Out] DateTime result)
		{
			if (!true)
			{
			}
			result._dateData = 1UL;
			if (!true)
			{
			}
			result._dateData = 1UL;
			return true;
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x00010B28 File Offset: 0x0000ED28
		internal static bool TryParse(ReadOnlySpan<char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles, [Out] DateTime result, [Out] TimeSpan offset)
		{
			if (!true)
			{
			}
			result._dateData = 1UL;
			if (!true)
			{
			}
			offset._ticks = 1L;
			if (!true)
			{
			}
			result._dateData = 1UL;
			offset._ticks = 1L;
			return true;
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x00010B60 File Offset: 0x0000ED60
		internal static bool TryParse(ReadOnlySpan<char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles, DateTimeResult result)
		{
			if (s != null)
			{
				string dateSeparator = dtfi.DateSeparator;
				string timeSeparator = dtfi.TimeSeparator;
				Calendar calendar = dtfi.calendar;
				result.calendar = calendar;
				if (calendar == null)
				{
				}
				bool flag;
				return flag;
			}
			if ("String was not recognized as a valid DateTime." == null)
			{
			}
			bool flag2;
			return flag2;
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x00010C44 File Offset: 0x0000EE44
		private static bool DetermineTimeZoneAdjustments(__DTString str, DateTimeResult result, DateTimeStyles styles, bool bTimeOnly)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x00010C80 File Offset: 0x0000EE80
		private static bool DateTimeOffsetTimeZonePostProcessing(__DTString str, DateTimeResult result, DateTimeStyles styles)
		{
			/*
An exception occurred when decompiling this method (060006E1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.DateTimeParse::DateTimeOffsetTimeZonePostProcessing(System.__DTString,System.DateTimeResult,System.Globalization.DateTimeStyles)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001B:
	brtrue(IL_0000, ldloc:int64[exp:bool](var_4_13))
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

		// Token: 0x060006E2 RID: 1762 RVA: 0x00010CAC File Offset: 0x0000EEAC
		private static bool AdjustTimeZoneToUniversal(DateTimeResult result)
		{
			return "The DateTime represented by the string is out of range." != null;
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00010CC8 File Offset: 0x0000EEC8
		private static bool AdjustTimeZoneToLocal(DateTimeResult result, bool bTimeOnly)
		{
			int num = 1;
			TimeZoneInfo local = TimeZoneInfo.Local;
			if (num == 0)
			{
			}
			TimeZoneInfo local2 = TimeZoneInfo.Local;
			if (num == 0)
			{
			}
			DateTime now = DateTime.Now;
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x00010D0C File Offset: 0x0000EF0C
		private static bool ParseISO8601(DateTimeRawInfo raw, __DTString str, DateTimeStyles styles, DateTimeResult result)
		{
			int year = raw.year;
			raw.year = year;
			if (year == 0)
			{
			}
			if (year == 0)
			{
			}
			if (year == 0)
			{
			}
			if (year == 0)
			{
			}
			int year2 = raw.year;
			raw.year = year2;
			if (year2 == 0)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x00010DA0 File Offset: 0x0000EFA0
		internal static bool MatchHebrewDigits(__DTString str, int digitLen, [Out] int number)
		{
			return true;
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x00010DB4 File Offset: 0x0000EFB4
		internal static bool ParseDigits(__DTString str, int digitLen, [Out] int result)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x00010DC8 File Offset: 0x0000EFC8
		internal static bool ParseDigits(__DTString str, int minDigitLen, int maxDigitLen, [Out] int result)
		{
			/*
An exception occurred when decompiling this method (060006E7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.DateTimeParse::ParseDigits(System.__DTString,System.Int32,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int64(var_4_05, ldc.i4:int64(0))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](maxDigitLen), ldloc:int64[exp:int32](var_4_05))
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

		// Token: 0x060006E8 RID: 1768 RVA: 0x00010DEC File Offset: 0x0000EFEC
		private static bool ParseFractionExact(__DTString str, int maxDigitLen, double result)
		{
			/*
An exception occurred when decompiling this method (060006E8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.DateTimeParse::ParseFractionExact(System.__DTString,System.Int32,System.Double)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](maxDigitLen), ldloc:float64[exp:int32](result))
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

		// Token: 0x060006E9 RID: 1769 RVA: 0x00010E08 File Offset: 0x0000F008
		private static bool ParseSign(__DTString str, bool result)
		{
			str.Value = 1;
			return true;
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x00010E24 File Offset: 0x0000F024
		private static bool ParseTimeZoneOffset(__DTString str, int len, TimeSpan result)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (":" == null)
			{
			}
			len.m_value = ":";
			if (":" == null)
			{
				TimeSpan timeSpan;
				len.m_value = timeSpan;
				return;
			}
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x00010E6C File Offset: 0x0000F06C
		private static bool MatchAbbreviatedMonthName(__DTString str, DateTimeFormatInfo dtfi, int result)
		{
			string text;
			int stringLength = text._stringLength;
			string text2;
			int stringLength2 = text2._stringLength;
			bool flag;
			return flag;
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x00010EBC File Offset: 0x0000F0BC
		private static bool MatchMonthName(__DTString str, DateTimeFormatInfo dtfi, int result)
		{
			string text;
			int stringLength = text._stringLength;
			string text2;
			int stringLength2 = text2._stringLength;
			bool flag;
			return flag;
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x00010F0C File Offset: 0x0000F10C
		private static bool MatchAbbreviatedDayName(__DTString str, DateTimeFormatInfo dtfi, int result)
		{
			string text;
			int stringLength = text._stringLength;
			bool flag;
			return flag;
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x00010F4C File Offset: 0x0000F14C
		private static bool MatchDayName(__DTString str, DateTimeFormatInfo dtfi, int result)
		{
			string text;
			int stringLength = text._stringLength;
			bool flag;
			return flag;
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x00010F8C File Offset: 0x0000F18C
		private static bool MatchEraName(__DTString str, DateTimeFormatInfo dtfi, int result)
		{
			/*
An exception occurred when decompiling this method (060006EF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.DateTimeParse::MatchEraName(System.__DTString,System.Globalization.DateTimeFormatInfo,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_004D:
	stloc:int32(var_19_54, ldfld:int32(string::_stringLength, ldloc:string(var_11)))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](var_19_54), ldloc:int32(var_12))
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

		// Token: 0x060006F0 RID: 1776 RVA: 0x00010FFC File Offset: 0x0000F1FC
		private static bool MatchTimeMark(__DTString str, DateTimeFormatInfo dtfi, DateTimeParse.TM result)
		{
			string text;
			if (text._stringLength == 0)
			{
			}
			string text2;
			if (text2._stringLength == 0)
			{
			}
			ThrowHelper.ThrowArgumentOutOfRangeException();
			int num;
			if (num == 0)
			{
				return;
			}
			string text3;
			int stringLength = text3._stringLength;
			ThrowHelper.ThrowArgumentOutOfRangeException();
			int num2;
			if (num2 != 0)
			{
				return;
			}
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x00011048 File Offset: 0x0000F248
		private static bool MatchAbbreviatedTimeMark(__DTString str, DateTimeFormatInfo dtfi, DateTimeParse.TM result)
		{
			string text;
			int stringLength = text._stringLength;
			long num = 0L;
			char c = text[(int)num];
			return true;
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x00011088 File Offset: 0x0000F288
		private static bool CheckNewValue(int currentValue, int newValue, char patternChar, DateTimeResult result)
		{
			return true;
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x00011098 File Offset: 0x0000F298
		private static DateTime GetDateTimeNow(DateTimeResult result, DateTimeStyles styles)
		{
			/*
An exception occurred when decompiling this method (060006F3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.DateTime System.DateTimeParse::GetDateTimeNow(System.DateTimeResult,System.Globalization.DateTimeStyles)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ParseFlags(var_0_06, ldfld:ParseFlags(DateTimeResult::flags, ldloc:DateTimeResult[exp:valuetype System.DateTimeResult&](result)))
	stloc:DateTime(var_1_0C, callgetter:DateTime(DateTime::get_Now))
	stloc:DateTime(var_2_12, callgetter:DateTime(DateTime::get_UtcNow))
	stloc:DateTime(var_3_18, callgetter:DateTime(DateTime::get_UtcNow))
	stloc:TimeSpan(var_4_1F, ldfld:TimeSpan(DateTimeResult::timeZoneOffset, ldloc:DateTimeResult[exp:valuetype System.DateTimeResult&](result)))
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

		// Token: 0x060006F4 RID: 1780 RVA: 0x000110C8 File Offset: 0x0000F2C8
		private static bool CheckDefaultDateTime(DateTimeResult result, Calendar cal, DateTimeStyles styles)
		{
			Calendar defaultInstance = GregorianCalendar.GetDefaultInstance();
			result.Year = defaultInstance;
			return true;
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x000110E8 File Offset: 0x0000F2E8
		private static string ExpandPredefinedFormat(ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, ParsingInfo parseInfo, DateTimeResult result)
		{
			/*
An exception occurred when decompiling this method (060006F5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.DateTimeParse::ExpandPredefinedFormat(System.ReadOnlySpan`1<System.Char>,System.Globalization.DateTimeFormatInfo,System.ParsingInfo,System.DateTimeResult)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00A5:
	stloc:Calendar(var_25_AD, call:Calendar(GregorianCalendar::GetDefaultInstance))
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

		// Token: 0x060006F6 RID: 1782 RVA: 0x000111A4 File Offset: 0x0000F3A4
		private static bool ParseJapaneseEraStart(__DTString str, DateTimeFormatInfo dtfi)
		{
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x000111BC File Offset: 0x0000F3BC
		private static bool ParseByFormat(__DTString str, __DTString format, ParsingInfo parseInfo, DateTimeFormatInfo dtfi, DateTimeResult result)
		{
			char @char = str.GetChar();
			int index = str.Index;
			CompareInfo compareInfo = dtfi._compareInfo;
			string text;
			int stringLength = text._stringLength;
			long num = 0L;
			string text2;
			char c = text2[(int)num];
			int repeatCount = str.GetRepeatCount();
			if (!true)
			{
			}
			bool next = str.GetNext();
			int num2 = 70;
			bool flag = str.Match((char)num2);
			int repeatCount2 = str.GetRepeatCount();
			int repeatCount3 = str.GetRepeatCount();
			bool flag2;
			return flag2;
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x000113CC File Offset: 0x0000F5CC
		internal static bool TryParseQuoteString(ReadOnlySpan<char> format, int pos, StringBuilder result, [Out] int returnValue)
		{
			/*
An exception occurred when decompiling this method (060006F8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.DateTimeParse::TryParseQuoteString(System.ReadOnlySpan`1<System.Char>,System.Int32,System.Text.StringBuilder,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_01, ldc.i4:int32(1))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](returnValue), ldloc:int32(var_0_01))
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

		// Token: 0x060006F9 RID: 1785 RVA: 0x000113E8 File Offset: 0x0000F5E8
		private static bool DoStrictParse(ReadOnlySpan<char> s, ReadOnlySpan<char> formatParam, DateTimeStyles styles, DateTimeFormatInfo dtfi, DateTimeResult result)
		{
			int length = result.failedFormatSpecifier._length;
			return "The DateTime represented by the string is not supported in calendar {0}." != null;
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x00011454 File Offset: 0x0000F654
		private static Exception GetDateTimeParseException(DateTimeResult result)
		{
			/*
An exception occurred when decompiling this method (060006FA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Exception System.DateTimeParse::GetDateTimeParseException(System.DateTimeResult)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_3_12, call:string(SR::GetResourceString, call:string(SR::GetResourceString, call:string(SR::GetResourceString, ldloc:string(var_2)))))
	stloc:int64(var_6_17, ldc.i4:int64(0))
	stloc:string(var_7_26, call:string(SR::GetResourceString, call:string(SR::Format, ldloc:string(var_3_12), ldloc:string[exp:object](var_5))))
	stloc:string(var_10_32, call:string(SR::GetResourceString, ldloc:string(var_9)))
	stloc:string(var_13_42, call:string(SR::Format, ldloc:string(var_10_32), ldloc:string[exp:object](var_12), ldloc:int64[exp:object](var_6_17)))
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

		// Token: 0x060006FB RID: 1787 RVA: 0x000114A4 File Offset: 0x0000F6A4
		// Note: this type is marked as 'beforefieldinit'.
		static DateTimeParse()
		{
		}

		// Token: 0x04000275 RID: 629
		internal static DateTimeParse.MatchNumberDelegate m_hebrewNumberParser;

		// Token: 0x04000276 RID: 630
		private static DateTimeParse.DS[][] dateParsingStates;

		// Token: 0x020000AE RID: 174
		internal sealed class MatchNumberDelegate : MulticastDelegate
		{
			// Token: 0x060006FC RID: 1788 RVA: 0x000114C0 File Offset: 0x0000F6C0
			public MatchNumberDelegate(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x060006FD RID: 1789 RVA: 0x00011514 File Offset: 0x0000F714
			public bool Invoke(__DTString str, int digitLen, [Out] int result)
			{
				/*
An exception occurred when decompiling this method (060006FD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.DateTimeParse/MatchNumberDelegate::Invoke(System.__DTString,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:native int(var_0_06, ldfld:native int(Delegate::method_code, ldloc:MatchNumberDelegate[exp:Delegate](this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:MatchNumberDelegate[exp:Delegate](this)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method, ldloc:MatchNumberDelegate[exp:Delegate](this)))
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

		// Token: 0x020000AF RID: 175
		internal enum DTT
		{
			// Token: 0x04000278 RID: 632
			End,
			// Token: 0x04000279 RID: 633
			NumEnd,
			// Token: 0x0400027A RID: 634
			NumAmpm,
			// Token: 0x0400027B RID: 635
			NumSpace,
			// Token: 0x0400027C RID: 636
			NumDatesep,
			// Token: 0x0400027D RID: 637
			NumTimesep,
			// Token: 0x0400027E RID: 638
			MonthEnd,
			// Token: 0x0400027F RID: 639
			MonthSpace,
			// Token: 0x04000280 RID: 640
			MonthDatesep,
			// Token: 0x04000281 RID: 641
			NumDatesuff,
			// Token: 0x04000282 RID: 642
			NumTimesuff,
			// Token: 0x04000283 RID: 643
			DayOfWeek,
			// Token: 0x04000284 RID: 644
			YearSpace,
			// Token: 0x04000285 RID: 645
			YearDateSep,
			// Token: 0x04000286 RID: 646
			YearEnd,
			// Token: 0x04000287 RID: 647
			TimeZone,
			// Token: 0x04000288 RID: 648
			Era,
			// Token: 0x04000289 RID: 649
			NumUTCTimeMark,
			// Token: 0x0400028A RID: 650
			Unk,
			// Token: 0x0400028B RID: 651
			NumLocalTimeMark,
			// Token: 0x0400028C RID: 652
			Max
		}

		// Token: 0x020000B0 RID: 176
		internal enum TM
		{
			// Token: 0x0400028E RID: 654
			NotSet = -1,
			// Token: 0x0400028F RID: 655
			AM,
			// Token: 0x04000290 RID: 656
			PM
		}

		// Token: 0x020000B1 RID: 177
		internal enum DS
		{
			// Token: 0x04000292 RID: 658
			BEGIN,
			// Token: 0x04000293 RID: 659
			N,
			// Token: 0x04000294 RID: 660
			NN,
			// Token: 0x04000295 RID: 661
			D_Nd,
			// Token: 0x04000296 RID: 662
			D_NN,
			// Token: 0x04000297 RID: 663
			D_NNd,
			// Token: 0x04000298 RID: 664
			D_M,
			// Token: 0x04000299 RID: 665
			D_MN,
			// Token: 0x0400029A RID: 666
			D_NM,
			// Token: 0x0400029B RID: 667
			D_MNd,
			// Token: 0x0400029C RID: 668
			D_NDS,
			// Token: 0x0400029D RID: 669
			D_Y,
			// Token: 0x0400029E RID: 670
			D_YN,
			// Token: 0x0400029F RID: 671
			D_YNd,
			// Token: 0x040002A0 RID: 672
			D_YM,
			// Token: 0x040002A1 RID: 673
			D_YMd,
			// Token: 0x040002A2 RID: 674
			D_S,
			// Token: 0x040002A3 RID: 675
			T_S,
			// Token: 0x040002A4 RID: 676
			T_Nt,
			// Token: 0x040002A5 RID: 677
			T_NNt,
			// Token: 0x040002A6 RID: 678
			ERROR,
			// Token: 0x040002A7 RID: 679
			DX_NN,
			// Token: 0x040002A8 RID: 680
			DX_NNN,
			// Token: 0x040002A9 RID: 681
			DX_MN,
			// Token: 0x040002AA RID: 682
			DX_NM,
			// Token: 0x040002AB RID: 683
			DX_MNN,
			// Token: 0x040002AC RID: 684
			DX_DS,
			// Token: 0x040002AD RID: 685
			DX_DSN,
			// Token: 0x040002AE RID: 686
			DX_NDS,
			// Token: 0x040002AF RID: 687
			DX_NNDS,
			// Token: 0x040002B0 RID: 688
			DX_YNN,
			// Token: 0x040002B1 RID: 689
			DX_YMN,
			// Token: 0x040002B2 RID: 690
			DX_YN,
			// Token: 0x040002B3 RID: 691
			DX_YM,
			// Token: 0x040002B4 RID: 692
			TX_N,
			// Token: 0x040002B5 RID: 693
			TX_NN,
			// Token: 0x040002B6 RID: 694
			TX_NNN,
			// Token: 0x040002B7 RID: 695
			TX_TS,
			// Token: 0x040002B8 RID: 696
			DX_NNY
		}

		// Token: 0x020000B2 RID: 178
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060006FE RID: 1790 RVA: 0x00011538 File Offset: 0x0000F738
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060006FF RID: 1791 RVA: 0x00011548 File Offset: 0x0000F748
			public <>c()
			{
			}

			// Token: 0x06000700 RID: 1792 RVA: 0x0001155C File Offset: 0x0000F75C
			internal DateTimeParse.MatchNumberDelegate <DoStrictParse>b__98_0()
			{
			}

			// Token: 0x040002B9 RID: 697
			public static readonly DateTimeParse.<>c <>9;

			// Token: 0x040002BA RID: 698
			public static Func<DateTimeParse.MatchNumberDelegate> <>9__98_0;
		}
	}
}
