using System;
using System.Runtime.InteropServices;
using System.Text;

namespace System
{
	// Token: 0x02000082 RID: 130
	internal static class IriHelper
	{
		// Token: 0x060001F7 RID: 503 RVA: 0x00006A30 File Offset: 0x00004C30
		internal static bool CheckIriUnicodeRange(char unicode, bool isQuery)
		{
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00006A40 File Offset: 0x00004C40
		internal static bool CheckIriUnicodeRange(char highSurr, char lowSurr, bool surrogatePair, bool isQuery)
		{
			if (!true)
			{
			}
			lowSurr.m_value = '\u0001';
			string text;
			int num = string.CompareOrdinal(text, "\ud800\udc00");
			int num2 = string.CompareOrdinal(text, "\ud83f\udffd");
			int num3 = string.CompareOrdinal(text, "\ud840\udc00");
			int num4 = string.CompareOrdinal(text, "\ud87f\udffd");
			int num5 = string.CompareOrdinal(text, "\ud880\udc00");
			int num6 = string.CompareOrdinal(text, "\ud8bf\udffd");
			int num7 = string.CompareOrdinal(text, "\ud8c0\udc00");
			int num8 = string.CompareOrdinal(text, "\ud8ff\udffd");
			int num9 = string.CompareOrdinal(text, "\ud900\udc00");
			int num10 = string.CompareOrdinal(text, "\ud93f\udffd");
			int num11 = string.CompareOrdinal(text, "\ud940\udc00");
			int num12 = string.CompareOrdinal(text, "\ud97f\udffd");
			int num13 = string.CompareOrdinal(text, "\ud980\udc00");
			int num14 = string.CompareOrdinal(text, "\ud9bf\udffd");
			int num15 = string.CompareOrdinal(text, "\ud9ff\udffd");
			int num16 = string.CompareOrdinal(text, "\uda00\udc00");
			int num17 = string.CompareOrdinal(text, "\uda3f\udffd");
			int num18 = string.CompareOrdinal(text, "\uda40\udc00");
			int num19 = string.CompareOrdinal(text, "\uda7f\udffd");
			int num20 = string.CompareOrdinal(text, "\uda80\udc00");
			int num21 = string.CompareOrdinal(text, "\udabf\udffd");
			int num22 = string.CompareOrdinal(text, "\udac0\udc00");
			int num23 = string.CompareOrdinal(text, "\udaff\udffd");
			int num24 = string.CompareOrdinal(text, "\udb00\udc00");
			int num25 = string.CompareOrdinal(text, "\udb3f\udffd");
			int num26 = string.CompareOrdinal(text, "\udb44\udc00");
			int num27 = string.CompareOrdinal(text, "\udb7f\udffd");
			int num28 = string.CompareOrdinal(text, "\udb80\udc00");
			int num29 = string.CompareOrdinal(text, "\udbbf\udffd");
			int num30 = string.CompareOrdinal(text, "\udbc0\udc00");
			return true;
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00006BE4 File Offset: 0x00004DE4
		internal static bool CheckIsReserved(char ch, global::System.UriComponents component)
		{
			bool flag;
			return flag;
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00006C10 File Offset: 0x00004E10
		internal unsafe static string EscapeUnescapeIri(char* pInput, int start, int end, global::System.UriComponents component)
		{
			int num = 1;
			long num2 = 0L;
			GCHandle gchandle;
			void* ptr = (void*)gchandle.AddrOfPinnedObject();
			long num3 = 0L;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			char c;
			bool flag = global::System.UriHelper.IsNotSafeForUnescape(c);
			int num4 = 37;
			long num5 = 0L;
			bool flag2 = global::System.IriHelper.CheckIriUnicodeRange(c, (char)num5, num2 != 0L, end != 0);
			if (num4 == 0 && num4 == 0)
			{
				GCHandle gchandle2;
				void* ptr2 = (void*)gchandle2.AddrOfPinnedObject();
				Encoding utf = Encoding.UTF8;
				if (!true)
				{
				}
				if (num3 == 0L)
				{
				}
				Encoding utf2 = Encoding.UTF8;
				if (utf2 != null)
				{
				}
				if (utf2 != null)
				{
				}
				string text;
				return text;
			}
			throw new OverflowException();
		}
	}
}
