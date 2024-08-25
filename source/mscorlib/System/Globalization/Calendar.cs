using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2IlInjected;

namespace System.Globalization
{
	// Token: 0x020005A8 RID: 1448
	[ComVisible(true)]
	[Serializable]
	public abstract class Calendar : ICloneable
	{
		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06002B6C RID: 11116 RVA: 0x0005F9A8 File Offset: 0x0005DBA8
		[ComVisible(false)]
		public virtual DateTime MinSupportedDateTime
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06002B6D RID: 11117 RVA: 0x0005F9BC File Offset: 0x0005DBBC
		[ComVisible(false)]
		public virtual DateTime MaxSupportedDateTime
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x06002B6E RID: 11118 RVA: 0x0005F9D0 File Offset: 0x0005DBD0
		protected Calendar()
		{
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06002B6F RID: 11119 RVA: 0x0000207A File Offset: 0x0000027A
		internal virtual int ID
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06002B70 RID: 11120 RVA: 0x0000207A File Offset: 0x0000027A
		internal virtual int BaseCalendarID
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06002B71 RID: 11121 RVA: 0x0005F9E4 File Offset: 0x0005DBE4
		[ComVisible(false)]
		public bool IsReadOnly
		{
			get
			{
				return this.m_isReadOnly;
			}
		}

		// Token: 0x06002B72 RID: 11122 RVA: 0x0005F9F8 File Offset: 0x0005DBF8
		[ComVisible(false)]
		public virtual object Clone()
		{
			object obj = base.MemberwiseClone();
			if (obj != null)
			{
			}
			return obj;
		}

		// Token: 0x06002B73 RID: 11123 RVA: 0x0005FA18 File Offset: 0x0005DC18
		[ComVisible(false)]
		public static Calendar ReadOnly(Calendar calendar)
		{
			if (!true)
			{
				object obj;
				if (obj != null)
				{
				}
			}
			throw new InvalidCastException();
		}

		// Token: 0x06002B74 RID: 11124 RVA: 0x0005FA34 File Offset: 0x0005DC34
		internal void VerifyWritable()
		{
			/*
An exception occurred when decompiling this method (06002B74)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Globalization.Calendar::VerifyWritable()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0009:
	stloc:string(var_0_13, call:string(Environment::GetResourceString, ldstr:string("Instance is read-only.")))
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

		// Token: 0x06002B75 RID: 11125 RVA: 0x0005FA54 File Offset: 0x0005DC54
		internal void SetReadOnlyState(bool readOnly)
		{
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06002B76 RID: 11126 RVA: 0x0005FA64 File Offset: 0x0005DC64
		internal virtual int CurrentEraValue
		{
			get
			{
				int currentEraValue = this.m_currentEraValue;
				CalendarData calendarData;
				int iCurrentEra = calendarData.iCurrentEra;
				this.m_currentEraValue = iCurrentEra;
				return iCurrentEra;
			}
		}

		// Token: 0x06002B77 RID: 11127
		public abstract int GetDayOfMonth(DateTime time);

		// Token: 0x06002B78 RID: 11128
		public abstract DayOfWeek GetDayOfWeek(DateTime time);

		// Token: 0x06002B79 RID: 11129
		public abstract int GetDaysInMonth(int year, int month, int era);

		// Token: 0x06002B7A RID: 11130
		public abstract int GetDaysInYear(int year, int era);

		// Token: 0x06002B7B RID: 11131
		public abstract int GetEra(DateTime time);

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x06002B7C RID: 11132
		public abstract int[] Eras { get; }

		// Token: 0x06002B7D RID: 11133
		public abstract int GetMonth(DateTime time);

		// Token: 0x06002B7E RID: 11134
		public abstract int GetMonthsInYear(int year, int era);

		// Token: 0x06002B7F RID: 11135
		public abstract int GetYear(DateTime time);

		// Token: 0x06002B80 RID: 11136 RVA: 0x0000207A File Offset: 0x0000027A
		public virtual bool IsLeapYear(int year)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002B81 RID: 11137
		public abstract bool IsLeapYear(int year, int era);

		// Token: 0x06002B82 RID: 11138 RVA: 0x0000207A File Offset: 0x0000027A
		public virtual DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002B83 RID: 11139
		public abstract DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era);

		// Token: 0x06002B84 RID: 11140 RVA: 0x0005FA88 File Offset: 0x0005DC88
		internal virtual bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, [Out] DateTime result)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06002B85 RID: 11141 RVA: 0x0005FAA0 File Offset: 0x0005DCA0
		internal virtual bool IsValidYear(int year, int era)
		{
		}

		// Token: 0x06002B86 RID: 11142 RVA: 0x0000207A File Offset: 0x0000027A
		internal virtual bool IsValidMonth(int year, int month, int era)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002B87 RID: 11143 RVA: 0x0000207A File Offset: 0x0000027A
		internal virtual bool IsValidDay(int year, int month, int day, int era)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x06002B88 RID: 11144 RVA: 0x0005FAB0 File Offset: 0x0005DCB0
		// (set) Token: 0x06002B89 RID: 11145 RVA: 0x0005FAC4 File Offset: 0x0005DCC4
		public virtual int TwoDigitYearMax
		{
			get
			{
				return this.twoDigitYearMax;
			}
			set
			{
				this.VerifyWritable();
				this.twoDigitYearMax = value;
			}
		}

		// Token: 0x06002B8A RID: 11146 RVA: 0x0005FAE0 File Offset: 0x0005DCE0
		public virtual int ToFourDigitYear(int year)
		{
			return year;
		}

		// Token: 0x06002B8B RID: 11147 RVA: 0x0005FB00 File Offset: 0x0005DD00
		internal static long TimeToTicks(int hour, int minute, int second, int millisecond)
		{
			return TimeSpan.TimeToTicks(42187672, hour, minute);
		}

		// Token: 0x06002B8C RID: 11148 RVA: 0x0005FB38 File Offset: 0x0005DD38
		internal static int GetSystemTwoDigitYearSetting(int CalID, int defaultYearValue)
		{
			if (!true)
			{
			}
			return CalID;
		}

		// Token: 0x04001819 RID: 6169
		internal const long TicksPerMillisecond = 10000L;

		// Token: 0x0400181A RID: 6170
		internal const long TicksPerSecond = 10000000L;

		// Token: 0x0400181B RID: 6171
		internal const long TicksPerMinute = 600000000L;

		// Token: 0x0400181C RID: 6172
		internal const long TicksPerHour = 36000000000L;

		// Token: 0x0400181D RID: 6173
		internal const long TicksPerDay = 864000000000L;

		// Token: 0x0400181E RID: 6174
		internal const int MillisPerSecond = 1000;

		// Token: 0x0400181F RID: 6175
		internal const int MillisPerMinute = 60000;

		// Token: 0x04001820 RID: 6176
		internal const int MillisPerHour = 3600000;

		// Token: 0x04001821 RID: 6177
		internal const int MillisPerDay = 86400000;

		// Token: 0x04001822 RID: 6178
		internal const int DaysPerYear = 365;

		// Token: 0x04001823 RID: 6179
		internal const int DaysPer4Years = 1461;

		// Token: 0x04001824 RID: 6180
		internal const int DaysPer100Years = 36524;

		// Token: 0x04001825 RID: 6181
		internal const int DaysPer400Years = 146097;

		// Token: 0x04001826 RID: 6182
		internal const int DaysTo10000 = 3652059;

		// Token: 0x04001827 RID: 6183
		internal const long MaxMillis = 315537897600000L;

		// Token: 0x04001828 RID: 6184
		internal const int CAL_GREGORIAN = 1;

		// Token: 0x04001829 RID: 6185
		internal const int CAL_GREGORIAN_US = 2;

		// Token: 0x0400182A RID: 6186
		internal const int CAL_JAPAN = 3;

		// Token: 0x0400182B RID: 6187
		internal const int CAL_TAIWAN = 4;

		// Token: 0x0400182C RID: 6188
		internal const int CAL_KOREA = 5;

		// Token: 0x0400182D RID: 6189
		internal const int CAL_HIJRI = 6;

		// Token: 0x0400182E RID: 6190
		internal const int CAL_THAI = 7;

		// Token: 0x0400182F RID: 6191
		internal const int CAL_HEBREW = 8;

		// Token: 0x04001830 RID: 6192
		internal const int CAL_GREGORIAN_ME_FRENCH = 9;

		// Token: 0x04001831 RID: 6193
		internal const int CAL_GREGORIAN_ARABIC = 10;

		// Token: 0x04001832 RID: 6194
		internal const int CAL_GREGORIAN_XLIT_ENGLISH = 11;

		// Token: 0x04001833 RID: 6195
		internal const int CAL_GREGORIAN_XLIT_FRENCH = 12;

		// Token: 0x04001834 RID: 6196
		internal const int CAL_JULIAN = 13;

		// Token: 0x04001835 RID: 6197
		internal const int CAL_JAPANESELUNISOLAR = 14;

		// Token: 0x04001836 RID: 6198
		internal const int CAL_CHINESELUNISOLAR = 15;

		// Token: 0x04001837 RID: 6199
		internal const int CAL_SAKA = 16;

		// Token: 0x04001838 RID: 6200
		internal const int CAL_LUNAR_ETO_CHN = 17;

		// Token: 0x04001839 RID: 6201
		internal const int CAL_LUNAR_ETO_KOR = 18;

		// Token: 0x0400183A RID: 6202
		internal const int CAL_LUNAR_ETO_ROKUYOU = 19;

		// Token: 0x0400183B RID: 6203
		internal const int CAL_KOREANLUNISOLAR = 20;

		// Token: 0x0400183C RID: 6204
		internal const int CAL_TAIWANLUNISOLAR = 21;

		// Token: 0x0400183D RID: 6205
		internal const int CAL_PERSIAN = 22;

		// Token: 0x0400183E RID: 6206
		internal const int CAL_UMALQURA = 23;

		// Token: 0x0400183F RID: 6207
		internal int m_currentEraValue;

		// Token: 0x04001840 RID: 6208
		[OptionalField(VersionAdded = 2)]
		private bool m_isReadOnly;

		// Token: 0x04001841 RID: 6209
		public const int CurrentEra = 0;

		// Token: 0x04001842 RID: 6210
		internal int twoDigitYearMax;
	}
}
