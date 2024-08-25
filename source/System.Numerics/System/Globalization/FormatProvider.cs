using System;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Globalization
{
	// Token: 0x02000007 RID: 7
	internal class FormatProvider
	{
		// Token: 0x0600002F RID: 47 RVA: 0x00002674 File Offset: 0x00000874
		internal static void FormatBigInteger(ValueStringBuilder sb, int precision, int scale, bool sign, ReadOnlySpan<char> format, NumberFormatInfo numberFormatInfo, char[] digits, int startIndex)
		{
			int num = 1;
			if (startIndex != 0)
			{
				return;
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x02000008 RID: 8
		private class Number
		{
			// Token: 0x06000030 RID: 48 RVA: 0x00002694 File Offset: 0x00000894
			internal unsafe static void Int32ToDecChars(char* buffer, int index, uint value, int digits)
			{
				if (value == 0U)
				{
					return;
				}
			}

			// Token: 0x06000031 RID: 49 RVA: 0x000026A8 File Offset: 0x000008A8
			internal static char ParseFormatSpecifier(ReadOnlySpan<char> format, [Out] int digits)
			{
				/*
An exception occurred when decompiling this method (06000031)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Char System.Globalization.FormatProvider/Number::ParseFormatSpecifier(System.ReadOnlySpan`1<System.Char>,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_2:
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](digits), ldloc:int64[exp:int32](var_5_25))
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

			// Token: 0x06000032 RID: 50 RVA: 0x000026E8 File Offset: 0x000008E8
			internal static void NumberToString(ValueStringBuilder sb, FormatProvider.Number.NumberBuffer number, char format, int nMaxDigits, NumberFormatInfo info, bool isDecimal)
			{
			}

			// Token: 0x06000033 RID: 51 RVA: 0x0000289C File Offset: 0x00000A9C
			private static void FormatCurrency(ValueStringBuilder sb, FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info)
			{
				int num = 1;
				bool sign = number.sign;
				if (num == 0)
				{
				}
				int num2 = 184;
				long num3 = 0L;
				int[] currencyGroupSizes = info.CurrencyGroupSizes;
				string currencyGroupSeparator = info.currencyGroupSeparator;
				string currencyDecimalSeparator = info.currencyDecimalSeparator;
				if (num2 == 0)
				{
				}
				FormatProvider.Number.FormatFixed(sb, number, (int)num3, nMaxDigits, info, currencyGroupSizes, currencyDecimalSeparator, currencyGroupSeparator);
			}

			// Token: 0x06000034 RID: 52 RVA: 0x00002978 File Offset: 0x00000B78
			private unsafe static int wcslen(char* s)
			{
			}

			// Token: 0x06000035 RID: 53 RVA: 0x00002988 File Offset: 0x00000B88
			private unsafe static void FormatFixed(ValueStringBuilder sb, FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, int[] groupDigits, string sDecimal, string sGroup)
			{
				int num = 1;
				int scale = number.scale;
				char* overrideDigits = number.overrideDigits;
				if (num == 0)
				{
				}
			}

			// Token: 0x06000036 RID: 54 RVA: 0x00002A4C File Offset: 0x00000C4C
			private static void FormatNumber(ValueStringBuilder sb, FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info)
			{
				int num = 1;
				bool sign = number.sign;
				if (num == 0)
				{
				}
				if (sign)
				{
					return;
				}
				long num2 = 0L;
				int[] numberGroupSizes = info.NumberGroupSizes;
				string numberDecimalSeparator = info.numberDecimalSeparator;
				string numberGroupSeparator = info.numberGroupSeparator;
				FormatProvider.Number.FormatFixed(sb, number, (int)num2, nMaxDigits, info, numberGroupSizes, numberDecimalSeparator, numberGroupSeparator);
			}

			// Token: 0x06000037 RID: 55 RVA: 0x00002B08 File Offset: 0x00000D08
			private unsafe static void FormatScientific(ValueStringBuilder sb, FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar)
			{
				char* overrideDigits = number.overrideDigits;
				int length = sb._chars._length;
				Span<char> chars = sb._chars;
			}

			// Token: 0x06000038 RID: 56 RVA: 0x00002BC4 File Offset: 0x00000DC4
			private static void FormatExponent(ValueStringBuilder sb, NumberFormatInfo info, int value, char expChar, int minDigits, bool positiveSign)
			{
				int length = sb._chars._length;
				sb._chars._pointer = expChar;
			}

			// Token: 0x06000039 RID: 57 RVA: 0x00002CC0 File Offset: 0x00000EC0
			private static void FormatGeneral(ValueStringBuilder sb, FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar, bool bSuppressScientific)
			{
				int scale = number.scale;
			}

			// Token: 0x0600003A RID: 58 RVA: 0x00002DAC File Offset: 0x00000FAC
			private static void FormatPercent(ValueStringBuilder sb, FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info)
			{
				int num = 1;
				bool sign = number.sign;
				if (num == 0)
				{
				}
				int num2 = 196;
				long num3 = 0L;
				int[] percentGroupSizes = info.PercentGroupSizes;
				string percentDecimalSeparator = info.percentDecimalSeparator;
				string percentGroupSeparator = info.percentGroupSeparator;
				if (num2 == 0)
				{
				}
				FormatProvider.Number.FormatFixed(sb, number, (int)num3, nMaxDigits, info, percentGroupSizes, percentDecimalSeparator, percentGroupSeparator);
			}

			// Token: 0x0600003B RID: 59 RVA: 0x00002E88 File Offset: 0x00001088
			private unsafe static void RoundNumber(FormatProvider.Number.NumberBuffer number, int pos)
			{
				char* overrideDigits = number.overrideDigits;
			}

			// Token: 0x0600003C RID: 60 RVA: 0x00002EC8 File Offset: 0x000010C8
			private static int FindSection(ReadOnlySpan<char> format, int section)
			{
				if (section != 0)
				{
					return;
				}
			}

			// Token: 0x0600003D RID: 61 RVA: 0x00002EDC File Offset: 0x000010DC
			internal unsafe static void NumberToStringFormat(ValueStringBuilder sb, FormatProvider.Number.NumberBuffer number, ReadOnlySpan<char> format, NumberFormatInfo info)
			{
				char* overrideDigits = number.overrideDigits;
				bool sign = number.sign;
			}

			// Token: 0x0600003E RID: 62 RVA: 0x00003164 File Offset: 0x00001364
			// Note: this type is marked as 'beforefieldinit'.
			static Number()
			{
				if (("$#" == null || "$#" != null) && ("#$" == null || "#$" != null) && ("$ #" == null || "$ #" != null) && ("# $" == null || "# $" != null) && ("($#)" == null || "($#)" != null) && ("-$#" == null || "-$#" != null) && ("$-#" == null || "$-#" != null) && ("$#-" == null || "$#-" != null) && ("(#$)" == null || "(#$)" != null) && ("-#$" == null || "-#$" != null) && ("#-$" == null || "#-$" != null) && ("#$-" == null || "#$-" != null) && ("-# $" == null || "-# $" != null) && ("-$ #" == null || "-$ #" != null) && ("# $-" == null || "# $-" != null) && ("$ #-" == null || "$ #-" != null) && ("$ -#" == null || "$ -#" != null) && ("#- $" == null || "#- $" != null) && ("($ #)" == null || "($ #)" != null) && ("(# $)" == null || "(# $)" != null) && ("# %" == null || "# %" != null) && ("#%" == null || "#%" != null) && ("%#" == null || "%#" != null) && ("% #" == null || "% #" != null) && ("-# %" == null || "-# %" != null) && ("-#%" == null || "-#%" != null) && ("-%#" == null || "-%#" != null) && ("%-#" == null || "%-#" != null) && ("%#-" == null || "%#-" != null) && ("#-%" == null || "#-%" != null) && ("#%-" == null || "#%-" != null) && ("-% #" == null || "-% #" != null) && ("# %-" == null || "# %-" != null) && ("% #-" == null || "% #-" != null) && ("% -#" == null || "% -#" != null) && ("#- %" == null || "#- %" != null) && ("(#)" == null || "(#)" != null) && ("-#" == null || "-#" != null) && ("- #" == null || "- #" != null) && ("#-" == null || "#-" != null) && ("# -" == null || "# -" != null))
				{
					return;
				}
				throw new ArrayTypeMismatchException();
			}

			// Token: 0x04000010 RID: 16
			private static string[] s_posCurrencyFormats;

			// Token: 0x04000011 RID: 17
			private static string[] s_negCurrencyFormats;

			// Token: 0x04000012 RID: 18
			private static string[] s_posPercentFormats;

			// Token: 0x04000013 RID: 19
			private static string[] s_negPercentFormats;

			// Token: 0x04000014 RID: 20
			private static string[] s_negNumberFormats;

			// Token: 0x04000015 RID: 21
			private static string s_posNumberFormat;

			// Token: 0x02000009 RID: 9
			internal struct NumberBuffer
			{
				// Token: 0x17000002 RID: 2
				// (get) Token: 0x0600003F RID: 63 RVA: 0x0000341B File Offset: 0x0000161B
				public unsafe char* digits
				{
					get
					{
						return null;
					}
				}

				// Token: 0x04000016 RID: 22
				public int precision;

				// Token: 0x04000017 RID: 23
				public int scale;

				// Token: 0x04000018 RID: 24
				public bool sign;

				// Token: 0x04000019 RID: 25
				public unsafe char* overrideDigits;
			}
		}
	}
}
