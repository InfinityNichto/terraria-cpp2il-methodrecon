using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;

namespace System
{
	// Token: 0x020000AC RID: 172
	internal static class DateTimeFormat
	{
		// Token: 0x0600068F RID: 1679 RVA: 0x0000FBE4 File Offset: 0x0000DDE4
		internal static void FormatDigits(StringBuilder outputBuffer, int value, int len)
		{
			if (!true)
			{
			}
			long num = 0L;
			DateTimeFormat.FormatDigits(outputBuffer, value, len, num != 0L);
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x0000FC00 File Offset: 0x0000DE00
		internal static void FormatDigits(StringBuilder outputBuffer, int value, int len, bool overrideLengthLimit)
		{
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x0000FC14 File Offset: 0x0000DE14
		private static void HebrewFormatDigits(StringBuilder outputBuffer, int digits)
		{
			if (!true)
			{
			}
			string text = HebrewNumber.ToString(digits);
			StringBuilder stringBuilder = outputBuffer.Append(text);
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x0000FC34 File Offset: 0x0000DE34
		internal static int ParseRepeatPattern(ReadOnlySpan<char> format, int pos, char patternChar)
		{
			return 1;
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x0000FC44 File Offset: 0x0000DE44
		private static string FormatDayOfWeek(int dayOfWeek, int repeat, DateTimeFormatInfo dtfi)
		{
			string text;
			return text;
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x0000FC54 File Offset: 0x0000DE54
		private static string FormatMonth(int month, int repeatCount, DateTimeFormatInfo dtfi)
		{
			string text;
			return text;
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x0000FC64 File Offset: 0x0000DE64
		private static string FormatHebrewMonthName(DateTime time, int month, int repeatCount, DateTimeFormatInfo dtfi)
		{
			string text;
			return text;
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x0000FC78 File Offset: 0x0000DE78
		internal static int ParseQuoteString(ReadOnlySpan<char> format, int pos, StringBuilder result)
		{
			/*
An exception occurred when decompiling this method (06000696)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.DateTimeFormat::ParseQuoteString(System.ReadOnlySpan`1<System.Char>,System.Int32,System.Text.StringBuilder)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:CultureInfo(var_3_09, callgetter:CultureInfo(CultureInfo::get_CurrentCulture))
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

		// Token: 0x06000697 RID: 1687 RVA: 0x0000FC90 File Offset: 0x0000DE90
		internal static int ParseNextChar(ReadOnlySpan<char> format, int pos)
		{
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x0000FCA0 File Offset: 0x0000DEA0
		private static bool IsUseGenitiveForm(ReadOnlySpan<char> format, int index, int tokenLen, char patternToMatch)
		{
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x0000FCB0 File Offset: 0x0000DEB0
		private static StringBuilder FormatCustomized(DateTime dateTime, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, TimeSpan offset, StringBuilder result)
		{
			int num = 1;
			Calendar calendar = dtfi.calendar;
			if (result == null)
			{
				StringBuilder stringBuilder = StringBuilderCache.Acquire(16);
			}
			if (num == 0)
			{
			}
			if (!true)
			{
			}
			if (calendar == null)
			{
			}
			if (!true)
			{
			}
			if (!false)
			{
			}
			if (!true)
			{
			}
			StringBuilder stringBuilder2;
			return stringBuilder2;
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x0000FEEC File Offset: 0x0000E0EC
		private static void FormatCustomizedTimeZone(DateTime dateTime, TimeSpan offset, ReadOnlySpan<char> format, int tokenLen, bool timeOnly, StringBuilder result)
		{
			if (!true)
			{
			}
			DateTime now = DateTime.Now;
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x0000FF24 File Offset: 0x0000E124
		private static void FormatCustomizedRoundripTimeZone(DateTime dateTime, TimeSpan offset, StringBuilder result)
		{
			if (!true)
			{
			}
			StringBuilder stringBuilder = result.Append("Z");
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x0000FFB0 File Offset: 0x0000E1B0
		private static void Append2DigitNumber(StringBuilder result, int val)
		{
			StringBuilder stringBuilder = result.Append((char)val);
			StringBuilder stringBuilder2 = result.Append((char)val);
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x0000FFD0 File Offset: 0x0000E1D0
		internal static string GetRealFormat(ReadOnlySpan<char> format, DateTimeFormatInfo dtfi)
		{
			return "yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK";
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x00010060 File Offset: 0x0000E260
		private static string ExpandPredefinedFormat(ReadOnlySpan<char> format, DateTime dateTime, DateTimeFormatInfo dtfi, TimeSpan offset)
		{
			DateTimeFormatInfo invariantInfo = DateTimeFormatInfo.InvariantInfo;
			string text;
			return text;
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x000100AC File Offset: 0x0000E2AC
		internal static string Format(DateTime dateTime, string format, IFormatProvider provider)
		{
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x000100C0 File Offset: 0x0000E2C0
		internal static string Format(DateTime dateTime, string format, IFormatProvider provider, TimeSpan offset)
		{
			if (dateTime != null)
			{
				if (!true)
				{
				}
				ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			int num;
			if (dateTime != null)
			{
				num = 1;
				while (dateTime != null)
				{
				}
			}
			if (num == 0)
			{
			}
			StringBuilder stringBuilder;
			return StringBuilderCache.GetStringAndRelease(stringBuilder);
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x00010110 File Offset: 0x0000E310
		internal static bool TryFormat(DateTime dateTime, Span<char> destination, [Out] int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x00010124 File Offset: 0x0000E324
		internal static bool TryFormat(DateTime dateTime, Span<char> destination, [Out] int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider, TimeSpan offset)
		{
			bool flag;
			return flag;
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x00010160 File Offset: 0x0000E360
		private static StringBuilder FormatStringBuilder(DateTime dateTime, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, TimeSpan offset)
		{
			if (format != null)
			{
				return "s";
			}
			Calendar calendar = dtfi.calendar;
			DateTimeFormatInfo invariantInfo = DateTimeFormatInfo.InvariantInfo;
			if (160 == 0)
			{
			}
			string text;
			if ("s" != null || text != null)
			{
				char rawStringData = text.GetRawStringData();
				int stringLength = text._stringLength;
				string text2;
				if (text2 != null)
				{
					char rawStringData2 = text2.GetRawStringData();
					int stringLength2 = text2._stringLength;
					while (text2 != null)
					{
					}
				}
			}
			StringBuilder stringBuilder;
			return stringBuilder;
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x000101D0 File Offset: 0x0000E3D0
		private static bool TryFormatO(DateTime dateTime, TimeSpan offset, Span<char> destination, [Out] int charsWritten)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00010290 File Offset: 0x0000E490
		private static bool TryFormatR(DateTime dateTime, TimeSpan offset, Span<char> destination, [Out] int charsWritten)
		{
			/*
An exception occurred when decompiling this method (060006A5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.DateTimeFormat::TryFormatR(System.DateTime,System.TimeSpan,System.Span`1<System.Char>,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0007:
	stfld:int64(TimeSpan::_ticks, ldloc:TimeSpan[exp:valuetype System.TimeSpan&](offset), ldloc:char[exp:int64](var_6))
	stloc:int32(var_25_52, ldc.i4:int32(29))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](charsWritten), ldloc:int32(var_25_52))
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

		// Token: 0x060006A6 RID: 1702 RVA: 0x000102F8 File Offset: 0x0000E4F8
		private static void WriteTwoDecimalDigits(uint value, Span<char> destination, int offset)
		{
			int num = 52429;
			destination._pointer = num;
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x00010314 File Offset: 0x0000E514
		private static void WriteFourDecimalDigits(uint value, Span<char> buffer, int startingIndex = 0)
		{
			int num = 52429;
			int num2 = 19923;
			buffer._pointer = num;
			buffer._pointer = num2;
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x0001033C File Offset: 0x0000E53C
		private static void WriteDigits(ulong value, Span<char> buffer)
		{
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x00010354 File Offset: 0x0000E554
		internal static void InvalidFormatForLocal(ReadOnlySpan<char> format, DateTime dateTime)
		{
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x00010364 File Offset: 0x0000E564
		// Note: this type is marked as 'beforefieldinit'.
		static DateTimeFormat()
		{
			if (!true)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			if (("0" == null || "0" != null) && ("00" == null || "00" != null) && ("000" == null || "000" != null) && ("0000" == null || "0000" != null) && ("00000" == null || "00000" != null) && ("000000" == null || "000000" != null) && ("0000000" == null || "0000000" != null))
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0400026F RID: 623
		internal static readonly TimeSpan NullOffset;

		// Token: 0x04000270 RID: 624
		internal static char[] allStandardFormats;

		// Token: 0x04000271 RID: 625
		internal static readonly DateTimeFormatInfo InvariantFormatInfo;

		// Token: 0x04000272 RID: 626
		internal static readonly string[] InvariantAbbreviatedMonthNames;

		// Token: 0x04000273 RID: 627
		internal static readonly string[] InvariantAbbreviatedDayNames;

		// Token: 0x04000274 RID: 628
		internal static string[] fixedNumberFormats;
	}
}
