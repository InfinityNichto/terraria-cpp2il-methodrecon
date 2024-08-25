using System;
using System.Reflection;
using Cpp2IlInjected;

namespace System.Text
{
	// Token: 0x02000290 RID: 656
	internal static class EncodingHelper
	{
		// Token: 0x1700024B RID: 587
		// (get) Token: 0x060016B6 RID: 5814 RVA: 0x0002FDEC File Offset: 0x0002DFEC
		internal static Encoding UTF8Unmarked
		{
			get
			{
				if (!true)
				{
				}
				if (!true)
				{
					if (!true)
					{
					}
					if (!true)
					{
					}
					if (true)
					{
					}
					long num = 0L;
					if (true)
					{
					}
					if (num != 0L)
					{
						throw new OutOfMemoryException();
					}
				}
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x060016B7 RID: 5815 RVA: 0x0000207A File Offset: 0x0000027A
		internal static string InternalCodePage(int code_page)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060016B8 RID: 5816 RVA: 0x0002FE30 File Offset: 0x0002E030
		internal static Encoding GetDefaultEncoding()
		{
			if (!true)
			{
			}
			Encoding encoding;
			return encoding;
		}

		// Token: 0x060016B9 RID: 5817 RVA: 0x0002FE7C File Offset: 0x0002E07C
		internal static object InvokeI18N(string name, params object[] args)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			long num2 = 0L;
			if (num != 0)
			{
			}
			if (num2 == 0L)
			{
				Assembly assembly = Assembly.Load("I18N, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756");
				if ("I18N, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756" != null)
				{
				}
				if ("I18N, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756" == null)
				{
				}
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060016BA RID: 5818 RVA: 0x0002FEDC File Offset: 0x0002E0DC
		// Note: this type is marked as 'beforefieldinit'.
		static EncodingHelper()
		{
		}

		// Token: 0x04000B92 RID: 2962
		private static Encoding utf8EncodingWithoutMarkers;

		// Token: 0x04000B93 RID: 2963
		private static readonly object lockobj;

		// Token: 0x04000B94 RID: 2964
		private static Assembly i18nAssembly;

		// Token: 0x04000B95 RID: 2965
		private static bool i18nDisabled;
	}
}
