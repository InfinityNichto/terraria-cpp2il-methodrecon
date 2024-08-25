using System;

namespace System.IO.Enumeration
{
	// Token: 0x02000580 RID: 1408
	public static class FileSystemName
	{
		// Token: 0x06002A4B RID: 10827 RVA: 0x0005BE54 File Offset: 0x0005A054
		public static string TranslateWin32Expression(string expression)
		{
			bool flag = string.IsNullOrEmpty("*");
			return "*";
		}

		// Token: 0x06002A4C RID: 10828 RVA: 0x0005BE98 File Offset: 0x0005A098
		public static bool MatchesWin32Expression(ReadOnlySpan<char> expression, ReadOnlySpan<char> name, bool ignoreCase = true)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06002A4D RID: 10829 RVA: 0x0005BEAC File Offset: 0x0005A0AC
		public static bool MatchesSimpleExpression(ReadOnlySpan<char> expression, ReadOnlySpan<char> name, bool ignoreCase = true)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06002A4E RID: 10830 RVA: 0x0005BEC0 File Offset: 0x0005A0C0
		private static bool MatchPattern(ReadOnlySpan<char> expression, ReadOnlySpan<char> name, bool ignoreCase, bool useExtendedWildcards)
		{
			if (true && ignoreCase)
			{
				int num = 1;
				int num2 = 1;
				if (num2 != 0)
				{
					num2.m_value = num;
				}
				num2.m_value = num;
				num2.m_value = num;
				num2.m_value = num;
			}
			bool flag;
			return flag;
		}

		// Token: 0x06002A4F RID: 10831 RVA: 0x0005BF14 File Offset: 0x0005A114
		// Note: this type is marked as 'beforefieldinit'.
		static FileSystemName()
		{
		}

		// Token: 0x040016B4 RID: 5812
		private static readonly char[] s_wildcardChars;

		// Token: 0x040016B5 RID: 5813
		private static readonly char[] s_simpleWildcardChars;
	}
}
