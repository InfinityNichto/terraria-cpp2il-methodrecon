using System;
using Cpp2IlInjected;

namespace System.Globalization
{
	// Token: 0x020005B4 RID: 1460
	[Serializable]
	public class UmAlQuraCalendar : Calendar
	{
		// Token: 0x06002C6E RID: 11374 RVA: 0x00062044 File Offset: 0x00060244
		private static UmAlQuraCalendar.DateMapping[] InitDateMapping()
		{
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x06002C6F RID: 11375 RVA: 0x0006205C File Offset: 0x0006025C
		public override DateTime MinSupportedDateTime
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x06002C70 RID: 11376 RVA: 0x00062070 File Offset: 0x00060270
		public override DateTime MaxSupportedDateTime
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x06002C71 RID: 11377 RVA: 0x00062084 File Offset: 0x00060284
		public UmAlQuraCalendar()
		{
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06002C72 RID: 11378 RVA: 0x00062098 File Offset: 0x00060298
		internal override int BaseCalendarID
		{
			get
			{
				return 6;
			}
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x06002C73 RID: 11379 RVA: 0x000620A8 File Offset: 0x000602A8
		internal override int ID
		{
			get
			{
				return 23;
			}
		}

		// Token: 0x06002C74 RID: 11380 RVA: 0x000620B8 File Offset: 0x000602B8
		private static void ConvertHijriToGregorian(int HijriYear, int HijriMonth, int HijriDay, int yg, int mg, int dg)
		{
			if (!true)
			{
			}
			DateTime dateTime;
			int year = dateTime.Year;
			yg.m_value = year;
			int num;
			mg.m_value = num;
			int num2;
			dg.m_value = num2;
		}

		// Token: 0x06002C75 RID: 11381 RVA: 0x000620E8 File Offset: 0x000602E8
		private static long GetAbsoluteDateUmAlQura(int year, int month, int day)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			return GregorianCalendar.GetAbsoluteDate(0, month, year);
		}

		// Token: 0x06002C76 RID: 11382 RVA: 0x00062104 File Offset: 0x00060304
		internal static void CheckTicksRange(long ticks)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06002C77 RID: 11383 RVA: 0x0006212C File Offset: 0x0006032C
		internal static void CheckEraRange(int era)
		{
		}

		// Token: 0x06002C78 RID: 11384 RVA: 0x00062144 File Offset: 0x00060344
		internal static void CheckYearRange(int year, int era)
		{
			if (!true)
			{
			}
			UmAlQuraCalendar.CheckEraRange(era);
		}

		// Token: 0x06002C79 RID: 11385 RVA: 0x0006216C File Offset: 0x0006036C
		internal static void CheckYearMonthRange(int year, int month, int era)
		{
			if (!true)
			{
			}
			UmAlQuraCalendar.CheckYearRange(year, era);
		}

		// Token: 0x06002C7A RID: 11386 RVA: 0x00062190 File Offset: 0x00060390
		private static void ConvertGregorianToHijri(DateTime time, int HijriYear, int HijriMonth, int HijriDay)
		{
			long num = 33251L;
			if (num == 0L)
			{
			}
			TimeSpan timeSpan;
			double totalDays = timeSpan.TotalDays;
			int num2 = 1;
			HijriDay.m_value = (int)num;
			HijriMonth.m_value = num2;
			long num3;
			HijriYear.m_value = (int)num3;
		}

		// Token: 0x06002C7B RID: 11387 RVA: 0x000621C8 File Offset: 0x000603C8
		internal virtual int GetDatePart(DateTime time, int part)
		{
			/*
An exception occurred when decompiling this method (06002C7B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Globalization.UmAlQuraCalendar::GetDatePart(System.DateTime,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0009:
	stloc:int64(var_1_15, call:int64(UmAlQuraCalendar::GetAbsoluteDateUmAlQura, ldloc:int32(part), ldloc:int64[exp:int32](var_0), ldc.i4:int32(-1073741824)))
	stloc:int32(var_2_17, ldc.i4:int32(1))
	stloc:int32(var_3_19, ldc.i4:int32(1))
	stloc:int64(var_4_22, call:int64(UmAlQuraCalendar::GetAbsoluteDateUmAlQura, ldloc:int32(part), ldloc:int32(var_2_17), ldloc:int32(var_3_19)))
	stloc:string(var_5_2E, call:string(Environment::GetResourceString, ldstr:string("Internal Error in DateTime and Calendar operations.")))
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

		// Token: 0x06002C7C RID: 11388 RVA: 0x0000207A File Offset: 0x0000027A
		public override int GetDayOfMonth(DateTime time)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002C7D RID: 11389 RVA: 0x0000207A File Offset: 0x0000027A
		public override DayOfWeek GetDayOfWeek(DateTime time)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002C7E RID: 11390 RVA: 0x00062204 File Offset: 0x00060404
		public override int GetDaysInMonth(int year, int month, int era)
		{
			if (!true)
			{
			}
			UmAlQuraCalendar.CheckYearMonthRange(year, month, era);
			return year;
		}

		// Token: 0x06002C7F RID: 11391 RVA: 0x00062220 File Offset: 0x00060420
		internal static int RealGetDaysInYear(int year)
		{
		}

		// Token: 0x06002C80 RID: 11392 RVA: 0x00062230 File Offset: 0x00060430
		public override int GetDaysInYear(int year, int era)
		{
			if (!true)
			{
			}
			UmAlQuraCalendar.CheckYearRange(year, era);
			return UmAlQuraCalendar.RealGetDaysInYear(year);
		}

		// Token: 0x06002C81 RID: 11393 RVA: 0x00062250 File Offset: 0x00060450
		public override int GetEra(DateTime time)
		{
			long num;
			UmAlQuraCalendar.CheckTicksRange(num);
			return 1;
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06002C82 RID: 11394 RVA: 0x0000207A File Offset: 0x0000027A
		public override int[] Eras
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06002C83 RID: 11395 RVA: 0x0000207A File Offset: 0x0000027A
		public override int GetMonth(DateTime time)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002C84 RID: 11396 RVA: 0x00062264 File Offset: 0x00060464
		public override int GetMonthsInYear(int year, int era)
		{
			if (!true)
			{
			}
			UmAlQuraCalendar.CheckYearRange(year, era);
			return 12;
		}

		// Token: 0x06002C85 RID: 11397 RVA: 0x0000207A File Offset: 0x0000027A
		public override int GetYear(DateTime time)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002C86 RID: 11398 RVA: 0x00062280 File Offset: 0x00060480
		public override bool IsLeapYear(int year, int era)
		{
			/*
An exception occurred when decompiling this method (06002C86)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Globalization.UmAlQuraCalendar::IsLeapYear(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	call:void(UmAlQuraCalendar::CheckYearRange, ldloc:int32(year), ldloc:int32(era))
	stloc:int32(var_0_10, call:int32(UmAlQuraCalendar::RealGetDaysInYear, ldloc:int32(year)))
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

		// Token: 0x06002C87 RID: 11399 RVA: 0x000622A0 File Offset: 0x000604A0
		public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
		{
			/*
An exception occurred when decompiling this method (06002C87)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.DateTime System.Globalization.UmAlQuraCalendar::ToDateTime(System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:CultureInfo(var_1_07, callgetter:CultureInfo(CultureInfo::get_CurrentCulture))
	stloc:string(var_2_12, call:string(Environment::GetResourceString, ldstr:string("Day must be between 1 and {0} for month {1}.")))
	stloc:string(var_7_24, call:string(Environment::GetResourceString, ldstr:string("Year, Month, and Day parameters describe an un-representable DateTime.")))
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

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06002C88 RID: 11400 RVA: 0x000622D4 File Offset: 0x000604D4
		// (set) Token: 0x06002C89 RID: 11401 RVA: 0x000622F0 File Offset: 0x000604F0
		public override int TwoDigitYearMax
		{
			get
			{
				int twoDigitYearMax = this.twoDigitYearMax;
				int num;
				this.twoDigitYearMax = num;
				return num;
			}
			set
			{
				base.VerifyWritable();
				this.twoDigitYearMax = value;
			}
		}

		// Token: 0x06002C8A RID: 11402 RVA: 0x0006231C File Offset: 0x0006051C
		public override int ToFourDigitYear(int year)
		{
			return base.ToFourDigitYear(year);
		}

		// Token: 0x06002C8B RID: 11403 RVA: 0x00062350 File Offset: 0x00060550
		// Note: this type is marked as 'beforefieldinit'.
		static UmAlQuraCalendar()
		{
			UmAlQuraCalendar.DateMapping[] array = UmAlQuraCalendar.InitDateMapping();
		}

		// Token: 0x040018B4 RID: 6324
		private static readonly UmAlQuraCalendar.DateMapping[] HijriYearInfo;

		// Token: 0x040018B5 RID: 6325
		internal static DateTime minDate;

		// Token: 0x040018B6 RID: 6326
		internal static DateTime maxDate;

		// Token: 0x020005B5 RID: 1461
		internal struct DateMapping
		{
			// Token: 0x06002C8C RID: 11404 RVA: 0x00062394 File Offset: 0x00060594
			internal DateMapping(int MonthsLengthFlags, int GYear, int GMonth, int GDay)
			{
				this.HijriMonthsLengthFlags = MonthsLengthFlags;
			}

			// Token: 0x040018B7 RID: 6327
			internal int HijriMonthsLengthFlags;

			// Token: 0x040018B8 RID: 6328
			internal DateTime GregorianDate;
		}
	}
}
