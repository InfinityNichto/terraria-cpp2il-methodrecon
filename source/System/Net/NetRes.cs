using System;
using System.Globalization;

namespace System.Net
{
	// Token: 0x020001F4 RID: 500
	internal class NetRes
	{
		// Token: 0x06000C57 RID: 3159 RVA: 0x0002788C File Offset: 0x00025A8C
		private NetRes()
		{
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x000278A0 File Offset: 0x00025AA0
		public static string GetWebStatusString(string Res, WebExceptionStatus Status)
		{
			if (!true)
			{
			}
			string text;
			string @string = SR.GetString(text);
			string string2 = SR.GetString(@string);
			return string.Format(CultureInfo.CurrentCulture, string2, @string);
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x000278CC File Offset: 0x00025ACC
		public static string GetWebStatusString(WebExceptionStatus Status)
		{
			if (!true)
			{
			}
			string text;
			return SR.GetString(text);
		}

		// Token: 0x06000C5A RID: 3162 RVA: 0x000278E4 File Offset: 0x00025AE4
		public static string GetWebStatusCodeString(HttpStatusCode statusCode, string statusDescription)
		{
			NumberFormatInfo invariantInfo = NumberFormatInfo.InvariantInfo;
			string text2;
			string text = "(" + text2 + ")";
			string text4;
			string text3 = "net_httpstatuscode_" + text4;
			string text5;
			if (text5 != null)
			{
				int stringLength = text5._stringLength;
				return text;
			}
			if (statusCode != (HttpStatusCode)0)
			{
			}
			string text6;
			return text6;
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x00027934 File Offset: 0x00025B34
		public static string GetWebStatusCodeString(FtpStatusCode statusCode, string statusDescription)
		{
			NumberFormatInfo invariantInfo = NumberFormatInfo.InvariantInfo;
			string text2;
			string text = "(" + text2 + ")";
			string text4;
			string text3 = "net_ftpstatuscode_" + text4;
			string text5;
			if (text5 != null)
			{
				int stringLength = text5._stringLength;
				return text;
			}
			if (statusCode != FtpStatusCode.Undefined)
			{
			}
			string text6;
			return text6;
		}
	}
}
