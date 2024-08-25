using System;
using System.Globalization;

namespace System.Net
{
	// Token: 0x02000210 RID: 528
	internal class CookieParser
	{
		// Token: 0x06000D0D RID: 3341 RVA: 0x00029990 File Offset: 0x00027B90
		internal CookieParser(string cookieString)
		{
			int stringLength = cookieString._stringLength;
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x000299AC File Offset: 0x00027BAC
		internal Cookie Get()
		{
			for (;;)
			{
				CookieTokenizer tokenizer = this.m_tokenizer;
				if (false)
				{
					CookieTokenizer tokenizer2 = this.m_tokenizer;
					CookieToken token = tokenizer2.m_token;
					if (tokenizer2.m_value == null)
					{
					}
				}
				string name = this.m_tokenizer.m_name;
				if (this.m_tokenizer.m_value == null)
				{
				}
				CookieToken token2 = this.m_tokenizer.m_token;
				if (43163648 == 0)
				{
				}
				int num = 1;
				string text;
				bool flag = int.TryParse(text, num);
				bool quoted = this.m_tokenizer.m_quoted;
				bool quoted2 = this.m_tokenizer.m_quoted;
				if (43163648 == 0)
				{
				}
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
				if (43163648 == 0)
				{
				}
				DateTime now = DateTime.Now;
				CookieTokenizer tokenizer3 = this.m_tokenizer;
				int index = tokenizer3.m_index;
				if (tokenizer3.m_eofCookie)
				{
					return;
				}
			}
		}

		// Token: 0x06000D0F RID: 3343 RVA: 0x00029A7C File Offset: 0x00027C7C
		internal Cookie GetServer()
		{
			Cookie savedCookie;
			for (;;)
			{
				int num = 1;
				savedCookie = this.m_savedCookie;
				if (savedCookie != null && num != 0)
				{
					break;
				}
				CookieTokenizer tokenizer = this.m_tokenizer;
				int num2 = 1;
				long num3 = 0L;
				CookieToken cookieToken = tokenizer.Next(num2 != 0, num3 != 0L);
				if (savedCookie == null)
				{
				}
				string name = this.m_tokenizer.m_name;
				if (this.m_tokenizer.m_value == null)
				{
				}
				CookieTokenizer tokenizer2 = this.m_tokenizer;
				int index = tokenizer2.m_index;
				if (tokenizer2.m_eofCookie)
				{
					return int.MinValue;
				}
			}
			CookieTokenizer tokenizer3 = this.m_tokenizer;
			CookieTokenizer tokenizer4 = this.m_tokenizer;
			CookieToken token = tokenizer4.m_token;
			string text = CookieParser.CheckQuoted(tokenizer4.m_value);
			savedCookie.Domain = text;
			bool quoted = this.m_tokenizer.m_quoted;
			savedCookie.IsQuotedDomain = quoted;
			return savedCookie;
		}

		// Token: 0x06000D10 RID: 3344 RVA: 0x00029BA8 File Offset: 0x00027DA8
		internal static string CheckQuoted(string value)
		{
			string text;
			return text;
		}

		// Token: 0x04000B32 RID: 2866
		private CookieTokenizer m_tokenizer;

		// Token: 0x04000B33 RID: 2867
		private Cookie m_savedCookie;
	}
}
