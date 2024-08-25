using System;
using System.Globalization;

namespace System
{
	// Token: 0x020000BA RID: 186
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	internal ref struct DateTimeResult
	{
		// Token: 0x0600071F RID: 1823 RVA: 0x00011A38 File Offset: 0x0000FC38
		internal void Init(ReadOnlySpan<char> originalDateTimeString)
		{
			this.originalDateTimeString = originalDateTimeString;
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x00011A4C File Offset: 0x0000FC4C
		internal void SetDate(int year, int month, int day)
		{
			this.Year = year;
			this.Day = month;
			this.Day = day;
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x00011A70 File Offset: 0x0000FC70
		internal void SetBadFormatSpecifierFailure()
		{
			this.failure = ParseFailureKind.FormatWithFormatSpecifier;
			this.failureMessageID = "Format specifier was invalid.";
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x00011A90 File Offset: 0x0000FC90
		internal void SetBadFormatSpecifierFailure(ReadOnlySpan<char> failedFormatSpecifier)
		{
			this.failure = ParseFailureKind.FormatWithFormatSpecifier;
			this.failedFormatSpecifier = failedFormatSpecifier;
			this.failureMessageID = "Format specifier was invalid.";
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x00011AB8 File Offset: 0x0000FCB8
		internal void SetBadDateTimeFailure()
		{
			this.failure = ParseFailureKind.FormatWithOriginalDateTime;
			this.failureMessageID = "String was not recognized as a valid DateTime.";
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x00011AD8 File Offset: 0x0000FCD8
		internal void SetFailure(ParseFailureKind failure, string failureMessageID)
		{
			this.failure = failure;
			this.failureMessageID = failureMessageID;
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x00011AF4 File Offset: 0x0000FCF4
		internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument)
		{
			this.failure = failure;
			this.failureMessageID = failureMessageID;
			this.failureMessageFormatArgument = failureMessageFormatArgument;
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x00011B18 File Offset: 0x0000FD18
		internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument, string failureArgumentName)
		{
			this.failure = failure;
			this.failureMessageID = failureMessageID;
			this.failureMessageFormatArgument = failureMessageFormatArgument;
			this.failureArgumentName = failureArgumentName;
		}

		// Token: 0x040002F1 RID: 753
		internal int Year;

		// Token: 0x040002F2 RID: 754
		internal int Month;

		// Token: 0x040002F3 RID: 755
		internal int Day;

		// Token: 0x040002F4 RID: 756
		internal int Hour;

		// Token: 0x040002F5 RID: 757
		internal int Minute;

		// Token: 0x040002F6 RID: 758
		internal int Second;

		// Token: 0x040002F7 RID: 759
		internal double fraction;

		// Token: 0x040002F8 RID: 760
		internal int era;

		// Token: 0x040002F9 RID: 761
		internal ParseFlags flags;

		// Token: 0x040002FA RID: 762
		internal TimeSpan timeZoneOffset;

		// Token: 0x040002FB RID: 763
		internal Calendar calendar;

		// Token: 0x040002FC RID: 764
		internal DateTime parsedDate;

		// Token: 0x040002FD RID: 765
		internal ParseFailureKind failure;

		// Token: 0x040002FE RID: 766
		internal string failureMessageID;

		// Token: 0x040002FF RID: 767
		internal object failureMessageFormatArgument;

		// Token: 0x04000300 RID: 768
		internal string failureArgumentName;

		// Token: 0x04000301 RID: 769
		internal ReadOnlySpan<char> originalDateTimeString;

		// Token: 0x04000302 RID: 770
		internal ReadOnlySpan<char> failedFormatSpecifier;
	}
}
