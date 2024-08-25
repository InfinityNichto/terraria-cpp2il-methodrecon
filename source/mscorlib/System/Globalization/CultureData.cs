using System;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;

namespace System.Globalization
{
	// Token: 0x020005B8 RID: 1464
	[StructLayout(0)]
	internal class CultureData
	{
		// Token: 0x06002C9D RID: 11421 RVA: 0x00062524 File Offset: 0x00060724
		private CultureData(string name)
		{
			this.sRealName = name;
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x06002C9E RID: 11422 RVA: 0x00062540 File Offset: 0x00060740
		public static CultureData Invariant
		{
			get
			{
				if (true || ("HH:mm:ss" != null && "HH:mm:ss" == null) || ("HH:mm" != null && "HH:mm" == null) || ("hh:mm tt" != null && "hh:mm tt" == null) || ("H:mm" != null && "H:mm" == null) || "h:mm tt" == null || "h:mm tt" != null)
				{
				}
				throw new ArrayTypeMismatchException();
			}
		}

		// Token: 0x06002C9F RID: 11423 RVA: 0x0006259C File Offset: 0x0006079C
		public static CultureData GetCultureData(string cultureName, bool useUserOverride)
		{
		}

		// Token: 0x06002CA0 RID: 11424 RVA: 0x000625B0 File Offset: 0x000607B0
		public static CultureData GetCultureData(string cultureName, bool useUserOverride, int datetimeIndex, int calendarId, int numberIndex, string iso2lang, int ansiCodePage, int oemCodePage, int macCodePage, int ebcdicCodePage, bool rightToLeft, string listSeparator)
		{
			return CultureData.Invariant;
		}

		// Token: 0x06002CA1 RID: 11425 RVA: 0x000625C4 File Offset: 0x000607C4
		private void fill_culture_data(int datetimeIndex)
		{
		}

		// Token: 0x06002CA2 RID: 11426 RVA: 0x000625D4 File Offset: 0x000607D4
		public CalendarData GetCalendar(int calendarId)
		{
			if (this.calendars == null)
			{
			}
			string text = this.sRealName;
			bool flag = this.bUseOverrides;
			CalendarData[] array = this.calendars;
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x06002CA3 RID: 11427 RVA: 0x00062608 File Offset: 0x00060808
		internal string[] LongTimes
		{
			get
			{
				return this.saLongTimes;
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x06002CA4 RID: 11428 RVA: 0x0006261C File Offset: 0x0006081C
		internal string[] ShortTimes
		{
			get
			{
				return this.saShortTimes;
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x06002CA5 RID: 11429 RVA: 0x00062630 File Offset: 0x00060830
		internal string SISO639LANGNAME
		{
			get
			{
				return this.sISO639Language;
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x06002CA6 RID: 11430 RVA: 0x00062644 File Offset: 0x00060844
		internal int IFIRSTDAYOFWEEK
		{
			get
			{
				return this.iFirstDayOfWeek;
			}
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x06002CA7 RID: 11431 RVA: 0x00062658 File Offset: 0x00060858
		internal int IFIRSTWEEKOFYEAR
		{
			get
			{
				return this.iFirstWeekOfYear;
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06002CA8 RID: 11432 RVA: 0x0006266C File Offset: 0x0006086C
		internal string SAM1159
		{
			get
			{
				return this.sAM1159;
			}
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x06002CA9 RID: 11433 RVA: 0x00062680 File Offset: 0x00060880
		internal string SPM2359
		{
			get
			{
				return this.sPM2359;
			}
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x06002CAA RID: 11434 RVA: 0x00062694 File Offset: 0x00060894
		internal string TimeSeparator
		{
			get
			{
				return this.sTimeSeparator;
			}
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x06002CAB RID: 11435 RVA: 0x000626A8 File Offset: 0x000608A8
		internal int[] CalendarIds
		{
			get
			{
				if (this.waCalendars != null)
				{
					int[] array = this.waCalendars;
					return "zh";
				}
				bool flag = this.sISO639Language == "ja";
				int num = this.calendarId;
				int num2 = this.calendarId;
				int num3 = this.calendarId;
				int num4 = this.calendarId;
				return num3;
			}
		}

		// Token: 0x06002CAC RID: 11436 RVA: 0x000626FC File Offset: 0x000608FC
		internal CalendarId[] GetCalendarIds()
		{
			/*
An exception occurred when decompiling this method (06002CAC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Globalization.CalendarId[] System.Globalization.CultureData::GetCalendarIds()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32[](var_0_06, callgetter:int32[](CultureData::get_CalendarIds, ldloc:CultureData(this)))
	stloc:int32[](var_1_0D, callgetter:int32[](CultureData::get_CalendarIds, ldloc:CultureData(this)))
	stloc:int32[](var_3_16, callgetter:int32[](CultureData::get_CalendarIds, ldloc:CultureData(this)))
	stloc:int32[](var_4_1D, callgetter:int32[](CultureData::get_CalendarIds, ldloc:CultureData(this)))
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

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x06002CAD RID: 11437 RVA: 0x00062728 File Offset: 0x00060928
		internal bool IsInvariantCulture
		{
			get
			{
				return string.IsNullOrEmpty(this.sRealName);
			}
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x06002CAE RID: 11438 RVA: 0x00062740 File Offset: 0x00060940
		internal string CultureName
		{
			get
			{
				return this.sRealName;
			}
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x06002CAF RID: 11439 RVA: 0x00062754 File Offset: 0x00060954
		internal string SCOMPAREINFO
		{
			get
			{
				return "";
			}
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x06002CB0 RID: 11440 RVA: 0x00062768 File Offset: 0x00060968
		internal string STEXTINFO
		{
			get
			{
				return this.sRealName;
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x06002CB1 RID: 11441 RVA: 0x0006277C File Offset: 0x0006097C
		internal bool UseUserOverride
		{
			get
			{
				return this.bUseOverrides;
			}
		}

		// Token: 0x06002CB2 RID: 11442 RVA: 0x00062790 File Offset: 0x00060990
		internal string[] EraNames(int calendarId)
		{
			return this.GetCalendar(calendarId).saEraNames;
		}

		// Token: 0x06002CB3 RID: 11443 RVA: 0x000627AC File Offset: 0x000609AC
		internal string[] AbbrevEraNames(int calendarId)
		{
			return this.GetCalendar(calendarId).saAbbrevEraNames;
		}

		// Token: 0x06002CB4 RID: 11444 RVA: 0x000627C8 File Offset: 0x000609C8
		internal string[] AbbreviatedEnglishEraNames(int calendarId)
		{
			return this.GetCalendar(calendarId).saAbbrevEnglishEraNames;
		}

		// Token: 0x06002CB5 RID: 11445 RVA: 0x000627E4 File Offset: 0x000609E4
		internal string[] ShortDates(int calendarId)
		{
			return this.GetCalendar(calendarId).saShortDates;
		}

		// Token: 0x06002CB6 RID: 11446 RVA: 0x00062800 File Offset: 0x00060A00
		internal string[] LongDates(int calendarId)
		{
			return this.GetCalendar(calendarId).saLongDates;
		}

		// Token: 0x06002CB7 RID: 11447 RVA: 0x0006281C File Offset: 0x00060A1C
		internal string[] YearMonths(int calendarId)
		{
			return this.GetCalendar(calendarId).saYearMonths;
		}

		// Token: 0x06002CB8 RID: 11448 RVA: 0x00062838 File Offset: 0x00060A38
		internal string[] DayNames(int calendarId)
		{
			return this.GetCalendar(calendarId).saDayNames;
		}

		// Token: 0x06002CB9 RID: 11449 RVA: 0x00062854 File Offset: 0x00060A54
		internal string[] AbbreviatedDayNames(int calendarId)
		{
			return this.GetCalendar(calendarId).saAbbrevDayNames;
		}

		// Token: 0x06002CBA RID: 11450 RVA: 0x00062870 File Offset: 0x00060A70
		internal string[] MonthNames(int calendarId)
		{
			return this.GetCalendar(calendarId).saMonthNames;
		}

		// Token: 0x06002CBB RID: 11451 RVA: 0x0006288C File Offset: 0x00060A8C
		internal string[] GenitiveMonthNames(int calendarId)
		{
			return this.GetCalendar(calendarId).saMonthGenitiveNames;
		}

		// Token: 0x06002CBC RID: 11452 RVA: 0x000628A8 File Offset: 0x00060AA8
		internal string[] AbbreviatedMonthNames(int calendarId)
		{
			return this.GetCalendar(calendarId).saAbbrevMonthNames;
		}

		// Token: 0x06002CBD RID: 11453 RVA: 0x000628C4 File Offset: 0x00060AC4
		internal string[] AbbreviatedGenitiveMonthNames(int calendarId)
		{
			return this.GetCalendar(calendarId).saAbbrevMonthGenitiveNames;
		}

		// Token: 0x06002CBE RID: 11454 RVA: 0x000628E0 File Offset: 0x00060AE0
		internal string[] LeapYearMonthNames(int calendarId)
		{
			return this.GetCalendar(calendarId).saLeapYearMonthNames;
		}

		// Token: 0x06002CBF RID: 11455 RVA: 0x000628FC File Offset: 0x00060AFC
		internal string MonthDay(int calendarId)
		{
			return this.GetCalendar(calendarId).sMonthDay;
		}

		// Token: 0x06002CC0 RID: 11456 RVA: 0x00062918 File Offset: 0x00060B18
		internal string DateSeparator(int calendarId)
		{
			string[] saShortDates = this.GetCalendar(calendarId).saShortDates;
			string text;
			return text;
		}

		// Token: 0x06002CC1 RID: 11457 RVA: 0x0006293C File Offset: 0x00060B3C
		private static string GetDateSeparator(string format)
		{
			return CultureData.GetSeparator("dyM", "dyM");
		}

		// Token: 0x06002CC2 RID: 11458 RVA: 0x00062958 File Offset: 0x00060B58
		private static string GetSeparator(string format, string timeParts)
		{
			string text;
			return text;
		}

		// Token: 0x06002CC3 RID: 11459 RVA: 0x0000207A File Offset: 0x0000027A
		private static int IndexOfTimePart(string format, int startIndex, string timeParts)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002CC4 RID: 11460 RVA: 0x0006296C File Offset: 0x00060B6C
		private static string UnescapeNlsString(string str, int start, int end)
		{
			if (!false)
			{
			}
			string text;
			return text;
		}

		// Token: 0x06002CC5 RID: 11461 RVA: 0x0000207A File Offset: 0x0000027A
		internal static string[] ReescapeWin32Strings(string[] array)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002CC6 RID: 11462 RVA: 0x0000207A File Offset: 0x0000027A
		internal static string ReescapeWin32String(string str)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002CC7 RID: 11463 RVA: 0x0000207A File Offset: 0x0000027A
		private unsafe static int strlen(byte* s)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002CC8 RID: 11464 RVA: 0x00062980 File Offset: 0x00060B80
		private unsafe static string idx2string(byte* data, int idx)
		{
			return Encoding.UTF8.GetString(data, idx);
		}

		// Token: 0x06002CC9 RID: 11465 RVA: 0x0006299C File Offset: 0x00060B9C
		private int[] create_group_sizes_array(int gs0, int gs1)
		{
		}

		// Token: 0x06002CCA RID: 11466 RVA: 0x000629AC File Offset: 0x00060BAC
		internal void GetNFIValues(NumberFormatInfo nfi)
		{
			bool flag = string.IsNullOrEmpty(this.sRealName);
			int num = this.numberIndex;
			int[] array;
			nfi.currencyGroupSizes = array;
			int[] array2;
			nfi.numberGroupSizes = array2;
			string text;
			nfi.NaNSymbol = text;
			string text2;
			nfi.currencyDecimalSeparator = text2;
			string text3;
			nfi.currencyGroupSeparator = text3;
			string text4;
			nfi.currencySymbol = text4;
			string text5;
			nfi.negativeInfinitySymbol = text5;
			string text6;
			nfi.negativeSign = text6;
			string text7;
			nfi.numberDecimalSeparator = text7;
			string text8;
			nfi.numberGroupSeparator = text8;
			string text9;
			nfi.perMilleSymbol = text9;
			string text10;
			nfi.percentSymbol = text10;
			string text11;
			nfi.positiveInfinitySymbol = text11;
			string text12;
			nfi.positiveSign = text12;
			int numberDecimalDigits = nfi.numberDecimalDigits;
			int[] numberGroupSizes = nfi.numberGroupSizes;
			nfi.percentDecimalDigits = numberDecimalDigits;
			nfi.percentGroupSizes = numberGroupSizes;
		}

		// Token: 0x06002CCB RID: 11467 RVA: 0x0000207A File Offset: 0x0000027A
		private unsafe static byte* fill_number_data(int index, CultureData.NumberFormatEntryManaged nfe)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x040018BD RID: 6333
		private string sAM1159;

		// Token: 0x040018BE RID: 6334
		private string sPM2359;

		// Token: 0x040018BF RID: 6335
		private string sTimeSeparator;

		// Token: 0x040018C0 RID: 6336
		private string[] saLongTimes;

		// Token: 0x040018C1 RID: 6337
		private string[] saShortTimes;

		// Token: 0x040018C2 RID: 6338
		private int iFirstDayOfWeek;

		// Token: 0x040018C3 RID: 6339
		private int iFirstWeekOfYear;

		// Token: 0x040018C4 RID: 6340
		private int[] waCalendars;

		// Token: 0x040018C5 RID: 6341
		private CalendarData[] calendars;

		// Token: 0x040018C6 RID: 6342
		private string sISO639Language;

		// Token: 0x040018C7 RID: 6343
		private readonly string sRealName;

		// Token: 0x040018C8 RID: 6344
		private bool bUseOverrides;

		// Token: 0x040018C9 RID: 6345
		private int calendarId;

		// Token: 0x040018CA RID: 6346
		private int numberIndex;

		// Token: 0x040018CB RID: 6347
		private int iDefaultAnsiCodePage;

		// Token: 0x040018CC RID: 6348
		private int iDefaultOemCodePage;

		// Token: 0x040018CD RID: 6349
		private int iDefaultMacCodePage;

		// Token: 0x040018CE RID: 6350
		private int iDefaultEbcdicCodePage;

		// Token: 0x040018CF RID: 6351
		private bool isRightToLeft;

		// Token: 0x040018D0 RID: 6352
		private string sListSeparator;

		// Token: 0x040018D1 RID: 6353
		private static CultureData s_Invariant;

		// Token: 0x020005B9 RID: 1465
		internal struct NumberFormatEntryManaged
		{
			// Token: 0x040018D2 RID: 6354
			internal int currency_decimal_digits;

			// Token: 0x040018D3 RID: 6355
			internal int currency_decimal_separator;

			// Token: 0x040018D4 RID: 6356
			internal int currency_group_separator;

			// Token: 0x040018D5 RID: 6357
			internal int currency_group_sizes0;

			// Token: 0x040018D6 RID: 6358
			internal int currency_group_sizes1;

			// Token: 0x040018D7 RID: 6359
			internal int currency_negative_pattern;

			// Token: 0x040018D8 RID: 6360
			internal int currency_positive_pattern;

			// Token: 0x040018D9 RID: 6361
			internal int currency_symbol;

			// Token: 0x040018DA RID: 6362
			internal int nan_symbol;

			// Token: 0x040018DB RID: 6363
			internal int negative_infinity_symbol;

			// Token: 0x040018DC RID: 6364
			internal int negative_sign;

			// Token: 0x040018DD RID: 6365
			internal int number_decimal_digits;

			// Token: 0x040018DE RID: 6366
			internal int number_decimal_separator;

			// Token: 0x040018DF RID: 6367
			internal int number_group_separator;

			// Token: 0x040018E0 RID: 6368
			internal int number_group_sizes0;

			// Token: 0x040018E1 RID: 6369
			internal int number_group_sizes1;

			// Token: 0x040018E2 RID: 6370
			internal int number_negative_pattern;

			// Token: 0x040018E3 RID: 6371
			internal int per_mille_symbol;

			// Token: 0x040018E4 RID: 6372
			internal int percent_negative_pattern;

			// Token: 0x040018E5 RID: 6373
			internal int percent_positive_pattern;

			// Token: 0x040018E6 RID: 6374
			internal int percent_symbol;

			// Token: 0x040018E7 RID: 6375
			internal int positive_infinity_symbol;

			// Token: 0x040018E8 RID: 6376
			internal int positive_sign;
		}
	}
}
