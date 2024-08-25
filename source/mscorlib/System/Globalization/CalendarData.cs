using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System.Globalization
{
	// Token: 0x020005A9 RID: 1449
	[StructLayout(0)]
	internal class CalendarData
	{
		// Token: 0x06002B8D RID: 11149 RVA: 0x0005FB4C File Offset: 0x0005DD4C
		private CalendarData()
		{
		}

		// Token: 0x06002B8E RID: 11150 RVA: 0x0005FB6C File Offset: 0x0005DD6C
		static CalendarData()
		{
			if (("תשרי" == null || "תשרי" != null) && ("חשון" == null || "חשון" != null) && ("כסלו" == null || "כסלו" != null) && ("טבת" == null || "טבת" != null) && ("שבט" == null || "שבט" != null) && ("אדר" == null || "אדר" != null) && ("אדר ב" == null || "אדר ב" != null) && ("ניסן" == null || "ניסן" != null) && ("אייר" == null || "אייר" != null) && ("סיון" == null || "סיון" != null) && ("תמוז" == null || "תמוז" != null) && ("אב" == null || "אב" != null) && ("אלול" == null || "אלול" != null) && ("תשרי" == null || "תשרי" != null) && ("חשון" == null || "חשון" != null) && ("כסלו" == null || "כסלו" != null) && ("טבת" == null || "טבת" != null) && ("שבט" == null || "שבט" != null) && ("אדר א" == null || "אדר א" != null) && ("אדר ב" == null || "אדר ב" != null) && ("ניסן" == null || "ניסן" != null) && ("אייר" == null || "אייר" != null) && ("סיון" == null || "סיון" != null) && ("תמוז" == null || "תמוז" != null) && ("תמוז" == null || "תמוז" != null) && ("אלול" == null || "אלול" != null) && ("MM/dd/yyyy" == null || "MM/dd/yyyy" != null) && ("yyyy-MM-dd" == null || "yyyy-MM-dd" != null) && ("dddd, dd MMMM yyyy" == null || "dddd, dd MMMM yyyy" != null) && ("yyyy MMMM" == null || "yyyy MMMM" != null) && ("A.D." == null || "A.D." != null) && ("AD" == null || "AD" != null) && ("AD" == null || "AD" != null) && ("Sunday" == null || "Sunday" != null) && ("Monday" == null || "Monday" != null) && ("Tuesday" == null || "Tuesday" != null) && ("Wednesday" == null || "Wednesday" != null) && ("Thursday" == null || "Thursday" != null) && ("Friday" == null || "Friday" != null) && ("Saturday" == null || "Saturday" != null) && ("Sun" == null || "Sun" != null) && ("Mon" == null || "Mon" != null) && ("Tue" == null || "Tue" != null) && ("Wed" == null || "Wed" != null) && ("Thu" == null || "Thu" != null) && ("Fri" == null || "Fri" != null) && "Sat" != null && ("Su" == null || "Su" != null) && ("Su" == null || "Su" != null) && ("Tu" == null || "Tu" != null) && ("We" == null || "We" != null) && ("Th" == null || "Th" != null) && ("Fr" == null || "Fr" != null) && ("Sa" == null || "Sa" != null) && ("January" == null || "January" != null) && ("February" == null || "February" != null) && ("March" == null || "March" != null) && ("April" == null || "April" != null) && ("May" == null || "May" != null) && ("June" == null || "June" != null) && ("July" == null || "July" != null) && ("August" == null || "August" != null) && ("September" == null || "September" != null) && ("October" == null || "October" != null) && ("November" == null || "November" != null) && ("December" == null || "December" != null) && ("Jan" == null || "Jan" != null) && ("Feb" == null || "Feb" != null) && ("Mar" == null || "Mar" != null) && ("Apr" == null || "Apr" != null) && ("May" == null || "May" != null) && ("Jun" == null || "Jun" != null) && ("Jul" == null || "Jul" != null) && "Aug" != null && ("Sep" == null || "Sep" != null) && ("Oct" == null || "Oct" != null) && ("Nov" == null || "Nov" != null) && ("Dec" == null || "Dec" != null))
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06002B8F RID: 11151 RVA: 0x0006008C File Offset: 0x0005E28C
		internal CalendarData(string localeName, int calendarId, bool bUseUserOverrides)
		{
			if (2029 == 0)
			{
			}
			bool flag = CalendarData.nativeGetCalendarData(this, localeName, calendarId);
			if (this.sNativeName == null)
			{
			}
			string[] array = this.saShortDates;
			if (array != null || array == null)
			{
			}
			string[] array2 = this.saYearMonths;
			if (array2 != null || array2 == null)
			{
			}
			string[] array3 = this.saLongDates;
			if (array3 != null || array3 == null)
			{
			}
			string text = this.sMonthDay;
			if (text != null || text == null)
			{
			}
			string[] array4 = this.saEraNames;
			if (array4 != null || array4 == null)
			{
			}
			string[] array5 = this.saAbbrevEraNames;
			if (array5 != null || array5 == null)
			{
			}
			string[] array6 = this.saAbbrevEnglishEraNames;
			if (array6 != null || array6 == null)
			{
			}
			string[] array7 = this.saDayNames;
			if (array7 != null || array7 == null)
			{
			}
			string[] array8 = this.saAbbrevDayNames;
			if (array8 != null || array8 == null)
			{
			}
			string[] array9 = this.saSuperShortDayNames;
			if (array9 != null || array9 == null)
			{
			}
			string[] array10 = this.saMonthNames;
			if (array10 != null || array10 == null)
			{
			}
			string[] array11 = this.saAbbrevMonthNames;
			if (array11 != null || array11 == null)
			{
			}
			string[] array12 = CultureData.ReescapeWin32Strings(this.saShortDates);
			string[] array13 = this.saLongDates;
			this.saShortDates = array12;
			string[] array14 = CultureData.ReescapeWin32Strings(array13);
			string[] array15 = this.saYearMonths;
			this.saLongDates = array14;
			string[] array16 = CultureData.ReescapeWin32Strings(array15);
			string text2 = this.sMonthDay;
			this.saYearMonths = array16;
			string text3 = CultureData.ReescapeWin32String(text2);
			this.sMonthDay = text3;
			if (text2 == null)
			{
			}
			if (text2 != null)
			{
				return;
			}
			if (this.saMonthGenitiveNames != null)
			{
			}
			string[] array17 = this.saMonthNames;
			this.saMonthGenitiveNames = array17;
			if (this.saAbbrevMonthGenitiveNames != null)
			{
			}
			string[] array18 = this.saAbbrevMonthNames;
			this.saAbbrevMonthGenitiveNames = array18;
			if (this.saLeapYearMonthNames != null)
			{
			}
			string[] array19 = this.saMonthNames;
			this.saLeapYearMonthNames = array19;
			this.InitializeEraNames(localeName, calendarId);
			this.InitializeAbbreviatedEraNames(localeName, calendarId);
			if (array19 == null)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
				if (!true)
				{
				}
				string[] japaneseEnglishEraNames = CalendarData.GetJapaneseEnglishEraNames();
				this.saAbbrevEnglishEraNames = japaneseEnglishEraNames;
				return;
			}
			if ("" == null || "" != null)
			{
				string[] array20 = this.saEraNames;
				this.iCurrentEra = array20;
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06002B90 RID: 11152 RVA: 0x0006027C File Offset: 0x0005E47C
		private void InitializeEraNames(string localeName, int calendarId)
		{
		}

		// Token: 0x06002B91 RID: 11153 RVA: 0x00060354 File Offset: 0x0005E554
		private static string[] GetJapaneseEraNames()
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
			return JapaneseCalendar.EraNames();
		}

		// Token: 0x06002B92 RID: 11154 RVA: 0x00060370 File Offset: 0x0005E570
		private static string[] GetJapaneseEnglishEraNames()
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
			return JapaneseCalendar.EnglishEraNames();
		}

		// Token: 0x06002B93 RID: 11155 RVA: 0x0006038C File Offset: 0x0005E58C
		private void InitializeAbbreviatedEraNames(string localeName, int calendarId)
		{
		}

		// Token: 0x06002B94 RID: 11156 RVA: 0x00060424 File Offset: 0x0005E624
		internal static CalendarData GetCalendarData(int calendarId)
		{
			if (!true)
			{
			}
			string text = CalendarData.CalendarIdToCultureName(1073741824);
			long num = 0L;
			return CultureInfo.GetCultureInfo(text).m_cultureData.GetCalendar((int)num);
		}

		// Token: 0x06002B95 RID: 11157 RVA: 0x00060454 File Offset: 0x0005E654
		private static string CalendarIdToCultureName(int calendarId)
		{
			return "ar-DZ";
		}

		// Token: 0x06002B96 RID: 11158 RVA: 0x0000207A File Offset: 0x0000027A
		public static int nativeGetTwoDigitYearMax(int calID)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002B97 RID: 11159 RVA: 0x00060470 File Offset: 0x0005E670
		private static bool nativeGetCalendarData(CalendarData data, string localeName, int calendarId)
		{
			if (!true)
			{
			}
			return true;
		}

		// Token: 0x06002B98 RID: 11160 RVA: 0x0000207A File Offset: 0x0000027A
		private bool fill_calendar_data(string localeName, int datetimeIndex)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x04001843 RID: 6211
		internal const int MAX_CALENDARS = 23;

		// Token: 0x04001844 RID: 6212
		internal string sNativeName;

		// Token: 0x04001845 RID: 6213
		internal string[] saShortDates;

		// Token: 0x04001846 RID: 6214
		internal string[] saYearMonths;

		// Token: 0x04001847 RID: 6215
		internal string[] saLongDates;

		// Token: 0x04001848 RID: 6216
		internal string sMonthDay;

		// Token: 0x04001849 RID: 6217
		internal string[] saEraNames;

		// Token: 0x0400184A RID: 6218
		internal string[] saAbbrevEraNames;

		// Token: 0x0400184B RID: 6219
		internal string[] saAbbrevEnglishEraNames;

		// Token: 0x0400184C RID: 6220
		internal string[] saDayNames;

		// Token: 0x0400184D RID: 6221
		internal string[] saAbbrevDayNames;

		// Token: 0x0400184E RID: 6222
		internal string[] saSuperShortDayNames;

		// Token: 0x0400184F RID: 6223
		internal string[] saMonthNames;

		// Token: 0x04001850 RID: 6224
		internal string[] saAbbrevMonthNames;

		// Token: 0x04001851 RID: 6225
		internal string[] saMonthGenitiveNames;

		// Token: 0x04001852 RID: 6226
		internal string[] saAbbrevMonthGenitiveNames;

		// Token: 0x04001853 RID: 6227
		internal string[] saLeapYearMonthNames;

		// Token: 0x04001854 RID: 6228
		internal int iTwoDigitYearMax = 2029;

		// Token: 0x04001855 RID: 6229
		internal int iCurrentEra;

		// Token: 0x04001856 RID: 6230
		internal bool bUseUserOverrides;

		// Token: 0x04001857 RID: 6231
		internal static CalendarData Invariant;

		// Token: 0x04001858 RID: 6232
		private static string[] HEBREW_MONTH_NAMES;

		// Token: 0x04001859 RID: 6233
		private static string[] HEBREW_LEAP_MONTH_NAMES;
	}
}
