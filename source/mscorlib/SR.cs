using System;
using System.Globalization;
using Cpp2IlInjected;

// Token: 0x0200000D RID: 13
internal static class SR
{
	// Token: 0x06000030 RID: 48 RVA: 0x00002258 File Offset: 0x00000458
	internal static string GetString(string name, params object[] args)
	{
		if (!true)
		{
		}
		CultureInfo invariantCulture = CultureInfo.InvariantCulture;
		string text;
		return text;
	}

	// Token: 0x06000031 RID: 49 RVA: 0x00002274 File Offset: 0x00000474
	internal static string GetString(CultureInfo culture, string name, params object[] args)
	{
		string text;
		return text;
	}

	// Token: 0x06000032 RID: 50 RVA: 0x0000207A File Offset: 0x0000027A
	internal static string GetString(string name)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00002284 File Offset: 0x00000484
	internal static string Format(string resourceFormat, params object[] args)
	{
		string text;
		if (resourceFormat != null)
		{
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			return text;
		}
		return text;
	}

	// Token: 0x06000034 RID: 52 RVA: 0x000022A0 File Offset: 0x000004A0
	internal static string Format(string resourceFormat, object p1)
	{
		if (!true)
		{
		}
		return string.Format(CultureInfo.InvariantCulture, resourceFormat, resourceFormat);
	}

	// Token: 0x06000035 RID: 53 RVA: 0x000022C0 File Offset: 0x000004C0
	internal static string Format(string resourceFormat, object p1, object p2)
	{
		if (!true)
		{
		}
		return string.Format(CultureInfo.InvariantCulture, resourceFormat, resourceFormat, p1);
	}

	// Token: 0x06000036 RID: 54 RVA: 0x000022E0 File Offset: 0x000004E0
	internal static string Format(string resourceFormat, object p1, object p2, object p3)
	{
		if (!true)
		{
		}
		return string.Format(CultureInfo.InvariantCulture, resourceFormat, resourceFormat, p1, p2);
	}

	// Token: 0x06000037 RID: 55 RVA: 0x0000207A File Offset: 0x0000027A
	internal static string GetResourceString(string str)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}
}
