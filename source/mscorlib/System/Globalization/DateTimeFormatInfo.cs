using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System.Globalization
{
	// Token: 0x02000588 RID: 1416
	[Serializable]
	public sealed class DateTimeFormatInfo : IFormatProvider, ICloneable
	{
		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06002AA8 RID: 10920 RVA: 0x0005CA4C File Offset: 0x0005AC4C
		private string CultureName
		{
			get
			{
				string name = this._name;
				if (name != null)
				{
					return name;
				}
				string sRealName = this._cultureData.sRealName;
				this._name = sRealName;
				return sRealName;
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06002AA9 RID: 10921 RVA: 0x0005CA7C File Offset: 0x0005AC7C
		private CultureInfo Culture
		{
			get
			{
				CultureInfo cultureInfo;
				if (this._cultureInfo == null)
				{
					string sRealName;
					if (this._name == null)
					{
						sRealName = this._cultureData.sRealName;
						this._name = sRealName;
					}
					cultureInfo = CultureInfo.GetCultureInfo(sRealName);
					this._cultureInfo = cultureInfo;
				}
				return cultureInfo;
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06002AAA RID: 10922 RVA: 0x0005CABC File Offset: 0x0005ACBC
		private string LanguageName
		{
			get
			{
				string langName = this._langName;
				if (langName != null)
				{
					return langName;
				}
				string sISO639Language = this._cultureData.sISO639Language;
				this._langName = sISO639Language;
				return sISO639Language;
			}
		}

		// Token: 0x06002AAB RID: 10923 RVA: 0x0005CAEC File Offset: 0x0005ACEC
		private string[] internalGetAbbreviatedDayOfWeekNames()
		{
			string[] array = this.abbreviatedDayNames;
			if (array != null)
			{
				return array;
			}
			string[] array2;
			return array2;
		}

		// Token: 0x06002AAC RID: 10924 RVA: 0x0005CB08 File Offset: 0x0005AD08
		private string[] internalGetAbbreviatedDayOfWeekNamesCore()
		{
			Calendar calendar = this.calendar;
			CultureData cultureData = this._cultureData;
			string[] array;
			this.abbreviatedDayNames = array;
			return array;
		}

		// Token: 0x06002AAD RID: 10925 RVA: 0x0005CB2C File Offset: 0x0005AD2C
		private string[] internalGetDayOfWeekNames()
		{
			string[] array = this.dayNames;
			if (array != null)
			{
				return array;
			}
			string[] array2;
			return array2;
		}

		// Token: 0x06002AAE RID: 10926 RVA: 0x0005CB48 File Offset: 0x0005AD48
		private string[] internalGetDayOfWeekNamesCore()
		{
			Calendar calendar = this.calendar;
			CultureData cultureData = this._cultureData;
			string[] array;
			this.dayNames = array;
			return array;
		}

		// Token: 0x06002AAF RID: 10927 RVA: 0x0005CB6C File Offset: 0x0005AD6C
		private string[] internalGetAbbreviatedMonthNames()
		{
			string[] array = this.abbreviatedMonthNames;
			if (array != null)
			{
				return array;
			}
			string[] array2;
			return array2;
		}

		// Token: 0x06002AB0 RID: 10928 RVA: 0x0005CB88 File Offset: 0x0005AD88
		private string[] internalGetAbbreviatedMonthNamesCore()
		{
			Calendar calendar = this.calendar;
			CultureData cultureData = this._cultureData;
			string[] array;
			this.abbreviatedMonthNames = array;
			return array;
		}

		// Token: 0x06002AB1 RID: 10929 RVA: 0x0005CBAC File Offset: 0x0005ADAC
		private string[] internalGetMonthNames()
		{
			string[] array = this.monthNames;
			if (array != null)
			{
				return array;
			}
			string[] array2;
			return array2;
		}

		// Token: 0x06002AB2 RID: 10930 RVA: 0x0005CBC8 File Offset: 0x0005ADC8
		private string[] internalGetMonthNamesCore()
		{
			Calendar calendar = this.calendar;
			CultureData cultureData = this._cultureData;
			string[] array;
			this.monthNames = array;
			return array;
		}

		// Token: 0x06002AB3 RID: 10931 RVA: 0x0005CBEC File Offset: 0x0005ADEC
		public DateTimeFormatInfo()
		{
			this.formatFlags = DateTimeFormatFlags.UseGenitiveMonth;
			base..ctor();
			if (this.yearMonthPattern == null)
			{
			}
			CultureData cultureData = CultureInfo.InvariantCulture.m_cultureData;
			this._cultureData = cultureData;
			if (cultureData == null)
			{
			}
			Calendar defaultInstance = GregorianCalendar.GetDefaultInstance();
			this.calendar = defaultInstance;
			CultureData cultureData2 = this._cultureData;
		}

		// Token: 0x06002AB4 RID: 10932 RVA: 0x0005CC3C File Offset: 0x0005AE3C
		internal DateTimeFormatInfo(CultureData cultureData, Calendar cal)
		{
			this._cultureData = cultureData;
			this.Calendar = cal;
		}

		// Token: 0x06002AB5 RID: 10933 RVA: 0x0005CC60 File Offset: 0x0005AE60
		private void InitializeOverridableProperties(CultureData cultureData, int calendarId)
		{
			int num = this.firstDayOfWeek;
			this.firstDayOfWeek = num;
			int num2 = this.calendarWeekRule;
			this.calendarWeekRule = num2;
			string text = this.amDesignator;
			if (text == null)
			{
				this.amDesignator = text;
			}
			string text2 = this.pmDesignator;
			if (text2 == null)
			{
				this.pmDesignator = text2;
			}
			string text3 = this.timeSeparator;
			if (text3 == null)
			{
				this.timeSeparator = text3;
			}
			if (this.dateSeparator == null)
			{
				string text4;
				this.dateSeparator = text4;
			}
			string[] longTimes = this._cultureData.LongTimes;
			CultureData cultureData2 = this._cultureData;
			this.allLongTimePatterns = longTimes;
			string[] shortTimes = cultureData2.ShortTimes;
			this.allShortTimePatterns = shortTimes;
			string[] array;
			this.allLongDatePatterns = array;
			string[] array2;
			this.allShortDatePatterns = array2;
			string[] array3;
			this.allYearMonthPatterns = array3;
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06002AB6 RID: 10934 RVA: 0x0005CD18 File Offset: 0x0005AF18
		public static DateTimeFormatInfo InvariantInfo
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002AB6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Globalization.DateTimeFormatInfo System.Globalization.DateTimeFormatInfo::get_InvariantInfo()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06002AB7 RID: 10935 RVA: 0x0005CD30 File Offset: 0x0005AF30
		public static DateTimeFormatInfo CurrentInfo
		{
			get
			{
				if (", HasRightShoulderButton=" == null)
				{
				}
				CultureInfo currentCulture = CultureInfo.CurrentCulture;
				DateTimeFormatInfo dateTimeInfo;
				if (currentCulture.m_isInherited)
				{
					if (currentCulture != null)
					{
						throw new InvalidCastException();
					}
				}
				else
				{
					dateTimeInfo = currentCulture.dateTimeInfo;
					while (dateTimeInfo == null)
					{
					}
				}
				return dateTimeInfo;
			}
		}

		// Token: 0x06002AB8 RID: 10936 RVA: 0x0005CD68 File Offset: 0x0005AF68
		public static DateTimeFormatInfo GetInstance(IFormatProvider provider)
		{
			Type type;
			if (true || type != null)
			{
			}
			return DateTimeFormatInfo.CurrentInfo;
		}

		// Token: 0x06002AB9 RID: 10937 RVA: 0x0005CD84 File Offset: 0x0005AF84
		public object GetFormat(Type formatType)
		{
			/*
An exception occurred when decompiling this method (06002AB9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Globalization.DateTimeFormatInfo::GetFormat(System.Type)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:bool(var_1_0A, call:bool(Type::op_Equality, ldloc:Type(formatType), ldloc:Type(var_0)))
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

		// Token: 0x06002ABA RID: 10938 RVA: 0x0005CD9C File Offset: 0x0005AF9C
		public object Clone()
		{
			object obj = base.MemberwiseClone();
			if (obj != null)
			{
			}
			if (this.calendar != null)
			{
			}
			return obj;
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06002ABB RID: 10939 RVA: 0x0005CDC4 File Offset: 0x0005AFC4
		public string AMDesignator
		{
			get
			{
				string text = this.amDesignator;
				if (text != null)
				{
					return text;
				}
				string sAM = this._cultureData.sAM1159;
				this.amDesignator = sAM;
				return sAM;
			}
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06002ABC RID: 10940 RVA: 0x0005CDF4 File Offset: 0x0005AFF4
		// (set) Token: 0x06002ABD RID: 10941 RVA: 0x0005CE08 File Offset: 0x0005B008
		public Calendar Calendar
		{
			get
			{
				return this.calendar;
			}
			set
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
				bool isReadOnly = this.IsReadOnly;
				if (value != null)
				{
					Calendar calendar = this.calendar;
					CalendarId[] calendarIds;
					if (this.optionalCalendars == null)
					{
						calendarIds = this._cultureData.GetCalendarIds();
						this.optionalCalendars = calendarIds;
					}
					if (calendarIds == null)
					{
						CalendarId[] calendarIds2 = this._cultureData.GetCalendarIds();
						this.optionalCalendars = calendarIds2;
					}
					Calendar calendar2 = this.calendar;
					if (calendar2 != null)
					{
						this.formatFlags = calendar2;
					}
					this.calendar = value;
					CultureData cultureData = this._cultureData;
					return;
				}
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06002ABE RID: 10942 RVA: 0x0005CE88 File Offset: 0x0005B088
		private CalendarId[] OptionalCalendars
		{
			get
			{
				CalendarId[] calendarIds;
				if (this.optionalCalendars == null)
				{
					calendarIds = this._cultureData.GetCalendarIds();
					this.optionalCalendars = calendarIds;
				}
				return calendarIds;
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06002ABF RID: 10943 RVA: 0x0005CEB4 File Offset: 0x0005B0B4
		internal string[] EraNames
		{
			get
			{
				string[] array;
				if (this.m_eraNames == null)
				{
					Calendar calendar = this.calendar;
					CultureData cultureData = this._cultureData;
					this.m_eraNames = array;
				}
				return array;
			}
		}

		// Token: 0x06002AC0 RID: 10944 RVA: 0x0005CEE0 File Offset: 0x0005B0E0
		public string GetEraName(int era)
		{
			if (era == 0)
			{
				Calendar calendar = this.calendar;
			}
			string[] eraNames = this.EraNames;
			string[] eraNames2 = this.m_eraNames;
			return eraNames;
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06002AC1 RID: 10945 RVA: 0x0005CF08 File Offset: 0x0005B108
		internal string[] AbbreviatedEraNames
		{
			get
			{
				string[] array;
				if (this.m_abbrevEraNames == null)
				{
					Calendar calendar = this.calendar;
					CultureData cultureData = this._cultureData;
					this.m_abbrevEraNames = array;
				}
				return array;
			}
		}

		// Token: 0x06002AC2 RID: 10946 RVA: 0x0005CF34 File Offset: 0x0005B134
		public string GetAbbreviatedEraName(int era)
		{
			string[] abbreviatedEraNames = this.AbbreviatedEraNames;
			if (era == 0)
			{
				Calendar calendar = this.calendar;
			}
			string[] abbrevEraNames = this.m_abbrevEraNames;
			string text;
			return text;
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06002AC3 RID: 10947 RVA: 0x0005CF5C File Offset: 0x0005B15C
		internal string[] AbbreviatedEnglishEraNames
		{
			get
			{
				string[] array;
				if (this.m_abbrevEnglishEraNames == null)
				{
					Calendar calendar = this.calendar;
					CultureData cultureData = this._cultureData;
					this.m_abbrevEnglishEraNames = array;
				}
				return array;
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06002AC4 RID: 10948 RVA: 0x0005CF88 File Offset: 0x0005B188
		public string DateSeparator
		{
			get
			{
				string text;
				if (this.dateSeparator == null)
				{
					Calendar calendar = this.calendar;
					CultureData cultureData = this._cultureData;
					this.dateSeparator = text;
				}
				return text;
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06002AC5 RID: 10949 RVA: 0x0005CFB4 File Offset: 0x0005B1B4
		public string FullDateTimePattern
		{
			get
			{
				string text3;
				if (this.fullDateTimePattern == null)
				{
					string text = this.longDatePattern;
					if (text == null)
					{
						string[] unclonedLongDatePatterns = this.UnclonedLongDatePatterns;
						this.longDatePattern = text;
					}
					string text2 = this.LongTimePattern;
					text3 = text + " " + text2;
					this.fullDateTimePattern = text3;
				}
				return text3;
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06002AC6 RID: 10950 RVA: 0x0005D000 File Offset: 0x0005B200
		public string LongDatePattern
		{
			get
			{
				string[] unclonedLongDatePatterns;
				if (this.longDatePattern == null)
				{
					unclonedLongDatePatterns = this.UnclonedLongDatePatterns;
					this.longDatePattern = unclonedLongDatePatterns;
				}
				return unclonedLongDatePatterns;
			}
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06002AC7 RID: 10951 RVA: 0x0005D024 File Offset: 0x0005B224
		public string LongTimePattern
		{
			get
			{
				string[] longTimes;
				if (this.longTimePattern == null)
				{
					if (this.allLongTimePatterns == null)
					{
						longTimes = this._cultureData.LongTimes;
						this.allLongTimePatterns = longTimes;
					}
					this.longTimePattern = longTimes;
				}
				return longTimes;
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06002AC8 RID: 10952 RVA: 0x0005D05C File Offset: 0x0005B25C
		public string MonthDayPattern
		{
			get
			{
				string text;
				if (this == null)
				{
					Calendar calendar = this.calendar;
					CultureData cultureData = this._cultureData;
					this.monthDayPattern = text;
				}
				return text;
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06002AC9 RID: 10953 RVA: 0x0005D084 File Offset: 0x0005B284
		public string PMDesignator
		{
			get
			{
				string text = this.pmDesignator;
				if (text != null)
				{
					return text;
				}
				string sPM = this._cultureData.sPM2359;
				this.pmDesignator = sPM;
				return sPM;
			}
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06002ACA RID: 10954 RVA: 0x0005D0B4 File Offset: 0x0005B2B4
		public string RFC1123Pattern
		{
			get
			{
				return "ddd, dd MMM yyyy HH':'mm':'ss 'GMT'";
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06002ACB RID: 10955 RVA: 0x0005D0C8 File Offset: 0x0005B2C8
		public string ShortDatePattern
		{
			get
			{
				string[] unclonedShortDatePatterns;
				if (this.shortDatePattern == null)
				{
					unclonedShortDatePatterns = this.UnclonedShortDatePatterns;
					this.shortDatePattern = unclonedShortDatePatterns;
				}
				return unclonedShortDatePatterns;
			}
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06002ACC RID: 10956 RVA: 0x0005D0EC File Offset: 0x0005B2EC
		public string ShortTimePattern
		{
			get
			{
				string[] shortTimes;
				if (this.shortTimePattern == null)
				{
					if (this.allShortTimePatterns == null)
					{
						shortTimes = this._cultureData.ShortTimes;
						this.allShortTimePatterns = shortTimes;
					}
					this.shortTimePattern = shortTimes;
				}
				return shortTimes;
			}
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06002ACD RID: 10957 RVA: 0x0005D124 File Offset: 0x0005B324
		public string SortableDateTimePattern
		{
			get
			{
				return "yyyy'-'MM'-'dd'T'HH':'mm':'ss";
			}
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06002ACE RID: 10958 RVA: 0x0005D138 File Offset: 0x0005B338
		internal string GeneralShortTimePattern
		{
			get
			{
				string text3;
				if (this.generalShortTimePattern == null)
				{
					string text = this.shortDatePattern;
					if (text == null)
					{
						string[] unclonedShortDatePatterns = this.UnclonedShortDatePatterns;
						this.shortDatePattern = text;
					}
					string text2 = this.ShortTimePattern;
					text3 = text + " " + text2;
					this.generalShortTimePattern = text3;
				}
				return text3;
			}
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06002ACF RID: 10959 RVA: 0x0005D184 File Offset: 0x0005B384
		internal string GeneralLongTimePattern
		{
			get
			{
				string text3;
				if (this.generalLongTimePattern == null)
				{
					string text = this.shortDatePattern;
					if (text == null)
					{
						string[] unclonedShortDatePatterns = this.UnclonedShortDatePatterns;
						this.shortDatePattern = text;
					}
					string text2 = this.LongTimePattern;
					text3 = text + " " + text2;
					this.generalLongTimePattern = text3;
				}
				return text3;
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06002AD0 RID: 10960 RVA: 0x0005D1D0 File Offset: 0x0005B3D0
		internal string DateTimeOffsetPattern
		{
			get
			{
				if (this.dateTimeOffsetPattern == null)
				{
					string text = this.shortDatePattern;
					if (text == null)
					{
						string[] unclonedShortDatePatterns = this.UnclonedShortDatePatterns;
						this.shortDatePattern = text;
					}
					string text2 = this.LongTimePattern;
					string text3 = text + " " + text2;
					int stringLength = this.LongTimePattern._stringLength;
					long num = 0L;
					char c = this.LongTimePattern[(int)num];
					string text4 = this.LongTimePattern;
					int stringLength2 = text4._stringLength;
					return text4;
				}
				string text5;
				return text5;
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06002AD1 RID: 10961 RVA: 0x0005D270 File Offset: 0x0005B470
		public string TimeSeparator
		{
			get
			{
				string text = this.timeSeparator;
				if (text != null)
				{
					return text;
				}
				string sTimeSeparator = this._cultureData.sTimeSeparator;
				this.timeSeparator = sTimeSeparator;
				return sTimeSeparator;
			}
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06002AD2 RID: 10962 RVA: 0x0005D2A0 File Offset: 0x0005B4A0
		public string UniversalSortableDateTimePattern
		{
			get
			{
				return "yyyy'-'MM'-'dd HH':'mm':'ss'Z'";
			}
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06002AD3 RID: 10963 RVA: 0x0005D2B4 File Offset: 0x0005B4B4
		public string YearMonthPattern
		{
			get
			{
				string[] unclonedYearMonthPatterns;
				if (this.yearMonthPattern == null)
				{
					unclonedYearMonthPatterns = this.UnclonedYearMonthPatterns;
					this.yearMonthPattern = unclonedYearMonthPatterns;
				}
				return unclonedYearMonthPatterns;
			}
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x06002AD4 RID: 10964 RVA: 0x0005D2D8 File Offset: 0x0005B4D8
		public string[] AbbreviatedDayNames
		{
			get
			{
				if (this.abbreviatedDayNames == null)
				{
					string[] array = this.internalGetAbbreviatedDayOfWeekNamesCore();
				}
				object obj;
				if (obj == null || obj != null)
				{
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06002AD5 RID: 10965 RVA: 0x0005D300 File Offset: 0x0005B500
		public string[] DayNames
		{
			get
			{
				object obj;
				if (obj == null || obj != null)
				{
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06002AD6 RID: 10966 RVA: 0x0005D318 File Offset: 0x0005B518
		public string[] AbbreviatedMonthNames
		{
			get
			{
				if (this.abbreviatedMonthNames == null)
				{
					string[] array = this.internalGetAbbreviatedMonthNamesCore();
				}
				object obj;
				if (obj == null || obj != null)
				{
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06002AD7 RID: 10967 RVA: 0x0005D340 File Offset: 0x0005B540
		public string[] MonthNames
		{
			get
			{
				if (this.monthNames == null)
				{
					string[] array = this.internalGetMonthNamesCore();
				}
				object obj;
				if (obj == null || obj != null)
				{
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x06002AD8 RID: 10968 RVA: 0x0005D368 File Offset: 0x0005B568
		internal bool HasSpacesInMonthNames
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002AD8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Globalization.DateTimeFormatInfo::get_HasSpacesInMonthNames()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:DateTimeFormatFlags(var_0_06, ldfld:DateTimeFormatFlags(DateTimeFormatInfo::formatFlags, ldloc:DateTimeFormatInfo(this)))
	stloc:DateTimeFormatFlags(var_1_0D, call:DateTimeFormatFlags(DateTimeFormatInfo::InitializeFormatFlags, ldloc:DateTimeFormatInfo(this)))
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

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06002AD9 RID: 10969 RVA: 0x0005D384 File Offset: 0x0005B584
		internal bool HasSpacesInDayNames
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002AD9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Globalization.DateTimeFormatInfo::get_HasSpacesInDayNames()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:DateTimeFormatFlags(var_0_06, ldfld:DateTimeFormatFlags(DateTimeFormatInfo::formatFlags, ldloc:DateTimeFormatInfo(this)))
	stloc:DateTimeFormatFlags(var_1_0D, call:DateTimeFormatFlags(DateTimeFormatInfo::InitializeFormatFlags, ldloc:DateTimeFormatInfo(this)))
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

		// Token: 0x06002ADA RID: 10970 RVA: 0x0005D3A0 File Offset: 0x0005B5A0
		internal string internalGetMonthName(int month, MonthNameStyles style, bool abbreviated)
		{
			return this.internalGetGenitiveMonthNames(month != 0);
		}

		// Token: 0x06002ADB RID: 10971 RVA: 0x0005D3E0 File Offset: 0x0005B5E0
		private string[] internalGetGenitiveMonthNames(bool abbreviated)
		{
			if (this.m_genitiveAbbreviatedMonthNames == null)
			{
				Calendar calendar = this.calendar;
				CultureData cultureData = this._cultureData;
				string[] array;
				this.m_genitiveAbbreviatedMonthNames = array;
				return array;
			}
			string[] array2;
			return array2;
		}

		// Token: 0x06002ADC RID: 10972 RVA: 0x0005D430 File Offset: 0x0005B630
		internal string[] internalGetLeapYearMonthNames()
		{
			string[] array;
			if (this.leapYearMonthNames == null)
			{
				Calendar calendar = this.calendar;
				CultureData cultureData = this._cultureData;
				this.leapYearMonthNames = array;
			}
			return array;
		}

		// Token: 0x06002ADD RID: 10973 RVA: 0x0005D45C File Offset: 0x0005B65C
		public string GetAbbreviatedDayName(DayOfWeek dayofweek)
		{
			while (this.abbreviatedDayNames != null)
			{
			}
			return this.internalGetAbbreviatedDayOfWeekNamesCore();
		}

		// Token: 0x06002ADE RID: 10974 RVA: 0x0005D478 File Offset: 0x0005B678
		private static string[] GetCombinedPatterns(string[] patterns1, string[] patterns2, string connectString)
		{
			string text;
			if (text == null || text != null)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06002ADF RID: 10975 RVA: 0x0005D498 File Offset: 0x0005B698
		public string[] GetAllDateTimePatterns(char format)
		{
			return "yyyy'-'MM'-'dd'T'HH':'mm':'ss";
		}

		// Token: 0x06002AE0 RID: 10976 RVA: 0x0005D514 File Offset: 0x0005B714
		public string GetDayName(DayOfWeek dayofweek)
		{
			while (this.dayNames != null)
			{
			}
			return this.internalGetDayOfWeekNamesCore();
		}

		// Token: 0x06002AE1 RID: 10977 RVA: 0x0005D530 File Offset: 0x0005B730
		public string GetAbbreviatedMonthName(int month)
		{
			while (this.abbreviatedMonthNames != null)
			{
			}
			return this.internalGetAbbreviatedMonthNamesCore();
		}

		// Token: 0x06002AE2 RID: 10978 RVA: 0x0005D54C File Offset: 0x0005B74C
		public string GetMonthName(int month)
		{
			while (this.monthNames != null)
			{
			}
			return this.internalGetMonthNamesCore();
		}

		// Token: 0x06002AE3 RID: 10979 RVA: 0x0005D568 File Offset: 0x0005B768
		private static string[] GetMergedPatterns(string[] patterns, string defaultPattern)
		{
			bool flag = patterns == patterns;
			object obj;
			if (obj == null || obj == null)
			{
				object obj2;
				if (obj2 == null)
				{
					throw new InvalidCastException();
				}
				if ((obj == null && obj == null) || obj != null)
				{
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06002AE4 RID: 10980 RVA: 0x0005D5A4 File Offset: 0x0005B7A4
		private string[] AllYearMonthPatterns
		{
			get
			{
				string[] unclonedYearMonthPatterns = this.UnclonedYearMonthPatterns;
				string text = this.yearMonthPattern;
				if (text == null)
				{
					string[] unclonedYearMonthPatterns2 = this.UnclonedYearMonthPatterns;
					this.yearMonthPattern = text;
				}
				if (!true)
				{
				}
				return DateTimeFormatInfo.GetMergedPatterns(unclonedYearMonthPatterns, text);
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06002AE5 RID: 10981 RVA: 0x0005D5DC File Offset: 0x0005B7DC
		private string[] AllShortDatePatterns
		{
			get
			{
				string[] unclonedShortDatePatterns = this.UnclonedShortDatePatterns;
				string text = this.shortDatePattern;
				if (text == null)
				{
					string[] unclonedShortDatePatterns2 = this.UnclonedShortDatePatterns;
					this.shortDatePattern = text;
				}
				if (!true)
				{
				}
				return DateTimeFormatInfo.GetMergedPatterns(unclonedShortDatePatterns, text);
			}
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06002AE6 RID: 10982 RVA: 0x0005D614 File Offset: 0x0005B814
		private string[] AllShortTimePatterns
		{
			get
			{
				string[] shortTimes;
				if (this.allShortTimePatterns == null)
				{
					shortTimes = this._cultureData.ShortTimes;
					this.allShortTimePatterns = shortTimes;
				}
				string text = this.ShortTimePattern;
				return DateTimeFormatInfo.GetMergedPatterns(shortTimes, text);
			}
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06002AE7 RID: 10983 RVA: 0x0005D64C File Offset: 0x0005B84C
		private string[] AllLongDatePatterns
		{
			get
			{
				string[] unclonedLongDatePatterns = this.UnclonedLongDatePatterns;
				string text = this.longDatePattern;
				if (text == null)
				{
					string[] unclonedLongDatePatterns2 = this.UnclonedLongDatePatterns;
					this.longDatePattern = text;
				}
				if (!true)
				{
				}
				return DateTimeFormatInfo.GetMergedPatterns(unclonedLongDatePatterns, text);
			}
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06002AE8 RID: 10984 RVA: 0x0005D684 File Offset: 0x0005B884
		private string[] AllLongTimePatterns
		{
			get
			{
				string[] longTimes;
				if (this.allLongTimePatterns == null)
				{
					longTimes = this._cultureData.LongTimes;
					this.allLongTimePatterns = longTimes;
				}
				string text = this.LongTimePattern;
				return DateTimeFormatInfo.GetMergedPatterns(longTimes, text);
			}
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06002AE9 RID: 10985 RVA: 0x0005D6BC File Offset: 0x0005B8BC
		private string[] UnclonedYearMonthPatterns
		{
			get
			{
				string[] array;
				if (this.allYearMonthPatterns == null)
				{
					Calendar calendar = this.calendar;
					CultureData cultureData = this._cultureData;
					this.allYearMonthPatterns = array;
				}
				return array;
			}
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06002AEA RID: 10986 RVA: 0x0005D6E8 File Offset: 0x0005B8E8
		private string[] UnclonedShortDatePatterns
		{
			get
			{
				string[] array;
				if (this.allShortDatePatterns == null)
				{
					Calendar calendar = this.calendar;
					CultureData cultureData = this._cultureData;
					this.allShortDatePatterns = array;
				}
				return array;
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06002AEB RID: 10987 RVA: 0x0005D714 File Offset: 0x0005B914
		private string[] UnclonedLongDatePatterns
		{
			get
			{
				string[] array;
				if (this.allLongDatePatterns == null)
				{
					Calendar calendar = this.calendar;
					CultureData cultureData = this._cultureData;
					this.allLongDatePatterns = array;
				}
				return array;
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x06002AEC RID: 10988 RVA: 0x0005D740 File Offset: 0x0005B940
		private string[] UnclonedShortTimePatterns
		{
			get
			{
				string[] shortTimes;
				if (this.allShortTimePatterns == null)
				{
					shortTimes = this._cultureData.ShortTimes;
					this.allShortTimePatterns = shortTimes;
				}
				return shortTimes;
			}
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06002AED RID: 10989 RVA: 0x0005D76C File Offset: 0x0005B96C
		private string[] UnclonedLongTimePatterns
		{
			get
			{
				string[] longTimes;
				if (this.allLongTimePatterns == null)
				{
					longTimes = this._cultureData.LongTimes;
					this.allLongTimePatterns = longTimes;
				}
				return longTimes;
			}
		}

		// Token: 0x06002AEE RID: 10990 RVA: 0x0005D798 File Offset: 0x0005B998
		public static DateTimeFormatInfo ReadOnly(DateTimeFormatInfo dtfi)
		{
			bool flag;
			if (flag.MemberwiseClone() != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06002AEF RID: 10991 RVA: 0x0005D7B4 File Offset: 0x0005B9B4
		public bool IsReadOnly
		{
			get
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
				if (true)
				{
					return true;
				}
				bool isReadOnly = this._isReadOnly;
				return true;
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06002AF0 RID: 10992 RVA: 0x0005D7D4 File Offset: 0x0005B9D4
		public string[] MonthGenitiveNames
		{
			get
			{
				long num = 0L;
				string[] array = this.internalGetGenitiveMonthNames(num != 0L);
				object obj;
				if (obj == null || obj != null)
				{
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06002AF1 RID: 10993 RVA: 0x0005D7F8 File Offset: 0x0005B9F8
		internal string FullTimeSpanPositivePattern
		{
			get
			{
				string text;
				if (this._fullTimeSpanPositivePattern == null)
				{
					CultureData cultureData = this._cultureData;
					if (cultureData.bUseOverrides)
					{
						string sRealName = cultureData.sRealName;
						long num = 0L;
						CultureData cultureData2 = CultureData.GetCultureData(sRealName, num != 0L);
					}
					this._fullTimeSpanPositivePattern = text;
				}
				return text;
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06002AF2 RID: 10994 RVA: 0x0005D838 File Offset: 0x0005BA38
		internal string FullTimeSpanNegativePattern
		{
			get
			{
				string text;
				if (this._fullTimeSpanNegativePattern == null)
				{
					string fullTimeSpanPositivePattern = this.FullTimeSpanPositivePattern;
					text = "'-'" + fullTimeSpanPositivePattern;
					this._fullTimeSpanNegativePattern = text;
				}
				return text;
			}
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06002AF3 RID: 10995 RVA: 0x0005D868 File Offset: 0x0005BA68
		internal CompareInfo CompareInfo
		{
			get
			{
				CompareInfo compareInfo;
				if (this._compareInfo == null)
				{
					compareInfo = CompareInfo.GetCompareInfo(this._cultureData.SCOMPAREINFO);
					this._compareInfo = compareInfo;
				}
				return compareInfo;
			}
		}

		// Token: 0x06002AF4 RID: 10996 RVA: 0x0005D898 File Offset: 0x0005BA98
		internal static void ValidateStyles(DateTimeStyles style, string parameterName)
		{
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06002AF5 RID: 10997 RVA: 0x0005D8A8 File Offset: 0x0005BAA8
		internal DateTimeFormatFlags FormatFlags
		{
			get
			{
				return this.formatFlags;
			}
		}

		// Token: 0x06002AF6 RID: 10998 RVA: 0x0005D8C0 File Offset: 0x0005BAC0
		private DateTimeFormatFlags InitializeFormatFlags()
		{
			/*
An exception occurred when decompiling this method (06002AF6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Globalization.DateTimeFormatFlags System.Globalization.DateTimeFormatInfo::InitializeFormatFlags()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string[](var_0_06, callgetter:string[](DateTimeFormatInfo::get_MonthNames, ldloc:DateTimeFormatInfo(this)))
	stloc:int64(var_1_08, ldc.i4:int64(0))
	stloc:string[](var_2_10, call:string[](DateTimeFormatInfo::internalGetGenitiveMonthNames, ldloc:DateTimeFormatInfo(this), ldloc:int64[exp:bool](var_1_08)))
	stloc:string[](var_3_17, callgetter:string[](DateTimeFormatInfo::get_AbbreviatedMonthNames, ldloc:DateTimeFormatInfo(this)))
	stloc:string[](var_4_1F, call:string[](DateTimeFormatInfo::internalGetGenitiveMonthNames, ldloc:DateTimeFormatInfo(this), ldc.i4:bool(1)))
	stloc:FORMATFLAGS(var_5_2B, call:FORMATFLAGS(DateTimeFormatInfoScanner::GetFormatFlagGenitiveMonth, ldloc:string[](var_0_06), ldloc:string[](var_2_10), ldloc:string[](var_3_17), ldloc:string[](var_4_1F)))
	stloc:string[](var_6_33, callgetter:string[](DateTimeFormatInfo::get_MonthNames, ldloc:DateTimeFormatInfo(this)))
	stloc:int64(var_7_36, ldc.i4:int64(0))
	stloc:string[](var_8_40, call:string[](DateTimeFormatInfo::internalGetGenitiveMonthNames, ldloc:DateTimeFormatInfo(this), ldloc:int64[exp:bool](var_7_36)))
	stloc:string[](var_9_48, callgetter:string[](DateTimeFormatInfo::get_AbbreviatedMonthNames, ldloc:DateTimeFormatInfo(this)))
	stloc:string[](var_10_51, call:string[](DateTimeFormatInfo::internalGetGenitiveMonthNames, ldloc:DateTimeFormatInfo(this), ldc.i4:bool(1)))
	stloc:FORMATFLAGS(var_11_60, call:FORMATFLAGS(DateTimeFormatInfoScanner::GetFormatFlagUseSpaceInMonthNames, ldloc:string[](var_6_33), ldloc:string[](var_8_40), ldloc:string[](var_9_48), ldloc:string[](var_10_51)))
	stloc:string[](var_12_68, callgetter:string[](DateTimeFormatInfo::get_DayNames, ldloc:DateTimeFormatInfo(this)))
	stloc:string[](var_13_70, callgetter:string[](DateTimeFormatInfo::get_AbbreviatedDayNames, ldloc:DateTimeFormatInfo(this)))
	stloc:FORMATFLAGS(var_14_7B, call:FORMATFLAGS(DateTimeFormatInfoScanner::GetFormatFlagUseSpaceInDayNames, ldloc:string[](var_12_68), ldloc:string[](var_13_70)))
	stloc:Calendar(var_15_83, ldfld:Calendar(DateTimeFormatInfo::calendar, ldloc:DateTimeFormatInfo(this)))
	stfld:DateTimeFormatFlags(DateTimeFormatInfo::formatFlags, ldloc:DateTimeFormatInfo(this), ldloc:FORMATFLAGS[exp:DateTimeFormatFlags](var_16))
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

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06002AF7 RID: 10999 RVA: 0x0005D95C File Offset: 0x0005BB5C
		internal bool HasForceTwoDigitYears
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002AF7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Globalization.DateTimeFormatInfo::get_HasForceTwoDigitYears()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Calendar(var_0_06, ldfld:Calendar(DateTimeFormatInfo::calendar, ldloc:DateTimeFormatInfo(this)))
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

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06002AF8 RID: 11000 RVA: 0x0005D970 File Offset: 0x0005BB70
		internal bool HasYearMonthAdjustment
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002AF8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Globalization.DateTimeFormatInfo::get_HasYearMonthAdjustment()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:DateTimeFormatFlags(var_0_06, ldfld:DateTimeFormatFlags(DateTimeFormatInfo::formatFlags, ldloc:DateTimeFormatInfo(this)))
	stloc:DateTimeFormatFlags(var_1_0D, call:DateTimeFormatFlags(DateTimeFormatInfo::InitializeFormatFlags, ldloc:DateTimeFormatInfo(this)))
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

		// Token: 0x06002AF9 RID: 11001 RVA: 0x0005D98C File Offset: 0x0005BB8C
		internal bool YearMonthAdjustment(int year, int month, bool parsedMonthName)
		{
			/*
An exception occurred when decompiling this method (06002AF9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Globalization.DateTimeFormatInfo::YearMonthAdjustment(System.Int32,System.Int32,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:DateTimeFormatFlags(var_0_06, ldfld:DateTimeFormatFlags(DateTimeFormatInfo::formatFlags, ldloc:DateTimeFormatInfo(this)))
	stloc:DateTimeFormatFlags(var_1_0D, call:DateTimeFormatFlags(DateTimeFormatInfo::InitializeFormatFlags, ldloc:DateTimeFormatInfo(this)))
	stloc:Calendar(var_2_14, ldfld:Calendar(DateTimeFormatInfo::calendar, ldloc:DateTimeFormatInfo(this)))
	stloc:Calendar(var_3_1B, ldfld:Calendar(DateTimeFormatInfo::calendar, ldloc:DateTimeFormatInfo(this)))
	stloc:Calendar(var_5_25, ldfld:Calendar(DateTimeFormatInfo::calendar, ldloc:DateTimeFormatInfo(this)))
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

		// Token: 0x06002AFA RID: 11002 RVA: 0x0005D9C4 File Offset: 0x0005BBC4
		internal static DateTimeFormatInfo GetJapaneseCalendarDTFI()
		{
			/*
An exception occurred when decompiling this method (06002AFA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Globalization.DateTimeFormatInfo System.Globalization.DateTimeFormatInfo::GetJapaneseCalendarDTFI()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000C:
	stloc:Calendar(var_2_15, call:Calendar(JapaneseCalendar::GetDefaultInstance))
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

		// Token: 0x06002AFB RID: 11003 RVA: 0x0005D9E8 File Offset: 0x0005BBE8
		internal static DateTimeFormatInfo GetTaiwanCalendarDTFI()
		{
			/*
An exception occurred when decompiling this method (06002AFB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Globalization.DateTimeFormatInfo System.Globalization.DateTimeFormatInfo::GetTaiwanCalendarDTFI()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000C:
	stloc:Calendar(var_2_15, call:Calendar(TaiwanCalendar::GetDefaultInstance))
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

		// Token: 0x06002AFC RID: 11004 RVA: 0x0005DA0C File Offset: 0x0005BC0C
		private void ClearTokenHashTable()
		{
		}

		// Token: 0x06002AFD RID: 11005 RVA: 0x0005DA1C File Offset: 0x0005BC1C
		internal DateTimeFormatInfo.TokenHashValue[] CreateTokenHashTable()
		{
			/*
An exception occurred when decompiling this method (06002AFD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Globalization.DateTimeFormatInfo/TokenHashValue[] System.Globalization.DateTimeFormatInfo::CreateTokenHashTable()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_022D:
	stloc:DateTimeFormatInfo(var_44_232, callgetter:DateTimeFormatInfo(DateTimeFormatInfo::get_InvariantInfo))
	stloc:DateTimeFormatInfo(var_46_239, callgetter:DateTimeFormatInfo(DateTimeFormatInfo::get_InvariantInfo))
	stloc:string[](var_48_241, callgetter:string[](DateTimeFormatInfo::get_AbbreviatedEnglishEraNames, ldloc:DateTimeFormatInfo(this)))
	stloc:string[](var_50_24C, callgetter:string[](DateTimeFormatInfo::get_AbbreviatedEnglishEraNames, ldloc:DateTimeFormatInfo(this)))
	stloc:string(var_51_255, ldfld:string(CultureData::sTimeSeparator, ldloc:CultureData(var_38)))
	stloc:string[](var_52_25D, callgetter:string[](DateTimeFormatInfo::get_AbbreviatedEnglishEraNames, ldloc:DateTimeFormatInfo(this)))
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

		// Token: 0x06002AFE RID: 11006 RVA: 0x0005DC88 File Offset: 0x0005BE88
		private void PopulateSpecialTokenHashTable(DateTimeFormatInfo.TokenHashValue[] temp, bool useDateSepAsIgnorableSymbol)
		{
			string sISO639Language;
			if (this._langName == null)
			{
				sISO639Language = this._cultureData.sISO639Language;
				this._langName = sISO639Language;
			}
			bool flag = sISO639Language.Equals("sq");
			string sAM;
			if (this.amDesignator == null)
			{
				sAM = this._cultureData.sAM1159;
				this.amDesignator = sAM;
			}
			string text = "." + sAM;
			string sPM;
			if (this.pmDesignator == null)
			{
				sPM = this._cultureData.sPM2359;
				this.pmDesignator = sPM;
			}
			string text2 = "." + sPM;
			Calendar calendar = this.calendar;
			string sISO639Language2;
			if (this._langName == null)
			{
				sISO639Language2 = this._cultureData.sISO639Language;
				this._langName = sISO639Language2;
			}
			bool flag2 = sISO639Language2.Equals("ko");
			DateTimeFormatFlags dateTimeFormatFlags = this.formatFlags;
			string[] array;
			if (array == null)
			{
				return;
			}
			string text3;
			this.AddMonthNames(temp, text3);
		}

		// Token: 0x06002AFF RID: 11007 RVA: 0x0005DEEC File Offset: 0x0005C0EC
		private static bool IsJapaneseCalendar(Calendar calendar)
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
			Type type;
			Type type2;
			return type == type2;
		}

		// Token: 0x06002B00 RID: 11008 RVA: 0x0005DF0C File Offset: 0x0005C10C
		private void AddMonthNames(DateTimeFormatInfo.TokenHashValue[] temp, string monthPostfix)
		{
			int num = 1;
			string monthName = this.GetMonthName(num);
			int stringLength = monthName._stringLength;
			if (monthPostfix != null)
			{
				string text = monthName + monthPostfix;
			}
			string abbreviatedMonthName = this.GetAbbreviatedMonthName(num);
		}

		// Token: 0x06002B01 RID: 11009 RVA: 0x0005DF40 File Offset: 0x0005C140
		private static bool TryParseHebrewNumber(__DTString str, [Out] bool badFormat, [Out] int number)
		{
			/*
An exception occurred when decompiling this method (06002B01)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Globalization.DateTimeFormatInfo::TryParseHebrewNumber(System.__DTString,System.Boolean,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_01, ldc.i4:int32(1))
	stfld:bool(bool::m_value, ldloc:bool[exp:bool&](badFormat), ldloc:int32[exp:bool](var_0_01))
	stfld:bool(bool::m_value, ldloc:bool[exp:bool&](badFormat), ldloc:int32[exp:bool](var_0_01))
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

		// Token: 0x06002B02 RID: 11010 RVA: 0x0000207A File Offset: 0x0000027A
		private static bool IsHebrewChar(char ch)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002B03 RID: 11011 RVA: 0x0005DF64 File Offset: 0x0005C164
		private bool IsAllowedJapaneseTokenFollowedByNonSpaceLetter(string tokenString, char nextCh)
		{
			Calendar calendar = this.calendar;
			bool flag = tokenString == "元";
			return true;
		}

		// Token: 0x06002B04 RID: 11012 RVA: 0x0005DF90 File Offset: 0x0005C190
		internal bool Tokenize(TokenType TokenMask, [Out] TokenType tokenType, [Out] int tokenValue, __DTString str)
		{
			int num = 11;
			tokenType.value__ = num;
			char current = str.m_current;
			if (num == 0)
			{
			}
			bool flag = char.IsLetter(current);
			if (!true)
			{
			}
			int length = str.Length;
			int index = str.Index;
			CultureInfo cultureInfo;
			if (cultureInfo == null)
			{
			}
			if (tokenValue == 0)
			{
				return;
			}
			int index2 = str.Index;
			int length2 = str.Length;
			int length3 = str.Length;
			if (index2 == 0)
			{
			}
			ThrowHelper.ThrowArgumentOutOfRangeException();
			int num2;
			if (num2 != 0)
			{
				return;
			}
		}

		// Token: 0x06002B05 RID: 11013 RVA: 0x0005E010 File Offset: 0x0005C210
		private void InsertAtCurrentHashNode(DateTimeFormatInfo.TokenHashValue[] hashTable, string str, char ch, TokenType tokenType, int tokenValue, int pos, int hashcode, int hashProbe)
		{
			CultureInfo culture = this.Culture;
		}

		// Token: 0x06002B06 RID: 11014 RVA: 0x0005E030 File Offset: 0x0005C230
		private void InsertHash(DateTimeFormatInfo.TokenHashValue[] hashTable, string str, TokenType tokenType, int tokenValue)
		{
			if (str != null && str._stringLength != 0)
			{
				long num = 0L;
				char c = str[(int)num];
				long num2 = 0L;
				bool flag = char.IsWhiteSpace(c);
				int stringLength = str._stringLength;
				bool flag2 = char.IsWhiteSpace(str[(int)num2]);
				string text;
				if (text._stringLength != 0)
				{
					CultureInfo culture = this.Culture;
					long num3 = 0L;
					char c2 = text[(int)num3];
					int stringLength2 = text._stringLength;
					return;
				}
			}
		}

		// Token: 0x06002B07 RID: 11015 RVA: 0x0005E0BC File Offset: 0x0005C2BC
		private bool CompareStringIgnoreCaseOptimized(string string1, int offset1, int length1, string string2, int offset2, int length2)
		{
			char c = string1[offset1];
			char c2 = string2[offset2];
			return true;
		}

		// Token: 0x06002B08 RID: 11016 RVA: 0x0005E0E4 File Offset: 0x0005C2E4
		// Note: this type is marked as 'beforefieldinit'.
		static DateTimeFormatInfo()
		{
		}

		// Token: 0x040016E5 RID: 5861
		private static DateTimeFormatInfo s_invariantInfo;

		// Token: 0x040016E6 RID: 5862
		[NonSerialized]
		private CultureData _cultureData;

		// Token: 0x040016E7 RID: 5863
		private string _name;

		// Token: 0x040016E8 RID: 5864
		[NonSerialized]
		private string _langName;

		// Token: 0x040016E9 RID: 5865
		[NonSerialized]
		private CompareInfo _compareInfo;

		// Token: 0x040016EA RID: 5866
		[NonSerialized]
		private CultureInfo _cultureInfo;

		// Token: 0x040016EB RID: 5867
		private string amDesignator;

		// Token: 0x040016EC RID: 5868
		private string pmDesignator;

		// Token: 0x040016ED RID: 5869
		private string dateSeparator;

		// Token: 0x040016EE RID: 5870
		private string generalShortTimePattern;

		// Token: 0x040016EF RID: 5871
		private string generalLongTimePattern;

		// Token: 0x040016F0 RID: 5872
		private string timeSeparator;

		// Token: 0x040016F1 RID: 5873
		private string monthDayPattern;

		// Token: 0x040016F2 RID: 5874
		private string dateTimeOffsetPattern;

		// Token: 0x040016F3 RID: 5875
		private const string rfc1123Pattern = "ddd, dd MMM yyyy HH':'mm':'ss 'GMT'";

		// Token: 0x040016F4 RID: 5876
		private const string sortableDateTimePattern = "yyyy'-'MM'-'dd'T'HH':'mm':'ss";

		// Token: 0x040016F5 RID: 5877
		private const string universalSortableDateTimePattern = "yyyy'-'MM'-'dd HH':'mm':'ss'Z'";

		// Token: 0x040016F6 RID: 5878
		private Calendar calendar;

		// Token: 0x040016F7 RID: 5879
		private int firstDayOfWeek;

		// Token: 0x040016F8 RID: 5880
		private int calendarWeekRule;

		// Token: 0x040016F9 RID: 5881
		private string fullDateTimePattern;

		// Token: 0x040016FA RID: 5882
		private string[] abbreviatedDayNames;

		// Token: 0x040016FB RID: 5883
		private string[] m_superShortDayNames;

		// Token: 0x040016FC RID: 5884
		private string[] dayNames;

		// Token: 0x040016FD RID: 5885
		private string[] abbreviatedMonthNames;

		// Token: 0x040016FE RID: 5886
		private string[] monthNames;

		// Token: 0x040016FF RID: 5887
		private string[] genitiveMonthNames;

		// Token: 0x04001700 RID: 5888
		private string[] m_genitiveAbbreviatedMonthNames;

		// Token: 0x04001701 RID: 5889
		private string[] leapYearMonthNames;

		// Token: 0x04001702 RID: 5890
		private string longDatePattern;

		// Token: 0x04001703 RID: 5891
		private string shortDatePattern;

		// Token: 0x04001704 RID: 5892
		private string yearMonthPattern;

		// Token: 0x04001705 RID: 5893
		private string longTimePattern;

		// Token: 0x04001706 RID: 5894
		private string shortTimePattern;

		// Token: 0x04001707 RID: 5895
		private string[] allYearMonthPatterns;

		// Token: 0x04001708 RID: 5896
		private string[] allShortDatePatterns;

		// Token: 0x04001709 RID: 5897
		private string[] allLongDatePatterns;

		// Token: 0x0400170A RID: 5898
		private string[] allShortTimePatterns;

		// Token: 0x0400170B RID: 5899
		private string[] allLongTimePatterns;

		// Token: 0x0400170C RID: 5900
		private string[] m_eraNames;

		// Token: 0x0400170D RID: 5901
		private string[] m_abbrevEraNames;

		// Token: 0x0400170E RID: 5902
		private string[] m_abbrevEnglishEraNames;

		// Token: 0x0400170F RID: 5903
		private CalendarId[] optionalCalendars;

		// Token: 0x04001710 RID: 5904
		private const int DEFAULT_ALL_DATETIMES_SIZE = 132;

		// Token: 0x04001711 RID: 5905
		internal bool _isReadOnly;

		// Token: 0x04001712 RID: 5906
		private DateTimeFormatFlags formatFlags;

		// Token: 0x04001713 RID: 5907
		private static readonly char[] s_monthSpaces;

		// Token: 0x04001714 RID: 5908
		internal const string RoundtripFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK";

		// Token: 0x04001715 RID: 5909
		internal const string RoundtripDateTimeUnfixed = "yyyy'-'MM'-'ddTHH':'mm':'ss zzz";

		// Token: 0x04001716 RID: 5910
		private string _fullTimeSpanPositivePattern;

		// Token: 0x04001717 RID: 5911
		private string _fullTimeSpanNegativePattern;

		// Token: 0x04001718 RID: 5912
		internal const DateTimeStyles InvalidDateTimeStyles = ~(DateTimeStyles.AllowLeadingWhite | DateTimeStyles.AllowTrailingWhite | DateTimeStyles.AllowInnerWhite | DateTimeStyles.NoCurrentDateDefault | DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeLocal | DateTimeStyles.AssumeUniversal | DateTimeStyles.RoundtripKind);

		// Token: 0x04001719 RID: 5913
		[NonSerialized]
		private DateTimeFormatInfo.TokenHashValue[] _dtfiTokenHash;

		// Token: 0x0400171A RID: 5914
		private const int TOKEN_HASH_SIZE = 199;

		// Token: 0x0400171B RID: 5915
		private const int SECOND_PRIME = 197;

		// Token: 0x0400171C RID: 5916
		private const string dateSeparatorOrTimeZoneOffset = "-";

		// Token: 0x0400171D RID: 5917
		private const string invariantDateSeparator = "/";

		// Token: 0x0400171E RID: 5918
		private const string invariantTimeSeparator = ":";

		// Token: 0x0400171F RID: 5919
		internal const string IgnorablePeriod = ".";

		// Token: 0x04001720 RID: 5920
		internal const string IgnorableComma = ",";

		// Token: 0x04001721 RID: 5921
		internal const string CJKYearSuff = "年";

		// Token: 0x04001722 RID: 5922
		internal const string CJKMonthSuff = "月";

		// Token: 0x04001723 RID: 5923
		internal const string CJKDaySuff = "日";

		// Token: 0x04001724 RID: 5924
		internal const string KoreanYearSuff = "년";

		// Token: 0x04001725 RID: 5925
		internal const string KoreanMonthSuff = "월";

		// Token: 0x04001726 RID: 5926
		internal const string KoreanDaySuff = "일";

		// Token: 0x04001727 RID: 5927
		internal const string KoreanHourSuff = "시";

		// Token: 0x04001728 RID: 5928
		internal const string KoreanMinuteSuff = "분";

		// Token: 0x04001729 RID: 5929
		internal const string KoreanSecondSuff = "초";

		// Token: 0x0400172A RID: 5930
		internal const string CJKHourSuff = "時";

		// Token: 0x0400172B RID: 5931
		internal const string ChineseHourSuff = "时";

		// Token: 0x0400172C RID: 5932
		internal const string CJKMinuteSuff = "分";

		// Token: 0x0400172D RID: 5933
		internal const string CJKSecondSuff = "秒";

		// Token: 0x0400172E RID: 5934
		internal const string JapaneseEraStart = "元";

		// Token: 0x0400172F RID: 5935
		internal const string LocalTimeMark = "T";

		// Token: 0x04001730 RID: 5936
		internal const string GMTName = "GMT";

		// Token: 0x04001731 RID: 5937
		internal const string ZuluName = "Z";

		// Token: 0x04001732 RID: 5938
		internal const string KoreanLangName = "ko";

		// Token: 0x04001733 RID: 5939
		internal const string JapaneseLangName = "ja";

		// Token: 0x04001734 RID: 5940
		internal const string EnglishLangName = "en";

		// Token: 0x04001735 RID: 5941
		private static DateTimeFormatInfo s_jajpDTFI;

		// Token: 0x04001736 RID: 5942
		private static DateTimeFormatInfo s_zhtwDTFI;

		// Token: 0x02000589 RID: 1417
		internal class TokenHashValue
		{
			// Token: 0x06002B09 RID: 11017 RVA: 0x0005E0F4 File Offset: 0x0005C2F4
			internal TokenHashValue(string tokenString, TokenType tokenType, int tokenValue)
			{
				this.tokenString = tokenString;
				this.tokenType = tokenType;
			}

			// Token: 0x04001737 RID: 5943
			internal string tokenString;

			// Token: 0x04001738 RID: 5944
			internal TokenType tokenType;

			// Token: 0x04001739 RID: 5945
			internal int tokenValue;
		}
	}
}
