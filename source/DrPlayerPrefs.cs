using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200003E RID: 62
public class DrPlayerPrefs
{
	// Token: 0x06000151 RID: 337 RVA: 0x000043F0 File Offset: 0x000025F0
	public static void DeleteAll()
	{
		PlayerPrefs.DeleteAll();
	}

	// Token: 0x06000152 RID: 338 RVA: 0x00004404 File Offset: 0x00002604
	public static void DeleteKey(string key)
	{
		PlayerPrefs.DeleteKey(key);
	}

	// Token: 0x06000153 RID: 339 RVA: 0x000021DB File Offset: 0x000003DB
	public static float GetFloat(string key)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000154 RID: 340 RVA: 0x000021DB File Offset: 0x000003DB
	public static float GetFloat(string key, float defaultValue)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000155 RID: 341 RVA: 0x00004418 File Offset: 0x00002618
	public static int GetInt(string key)
	{
		int num;
		return num;
	}

	// Token: 0x06000156 RID: 342 RVA: 0x00004428 File Offset: 0x00002628
	public static int GetInt(string key, int defaultValue)
	{
		int num;
		return num;
	}

	// Token: 0x06000157 RID: 343 RVA: 0x00004438 File Offset: 0x00002638
	public static string GetString(string key)
	{
		string text;
		return text;
	}

	// Token: 0x06000158 RID: 344 RVA: 0x00004448 File Offset: 0x00002648
	public static string GetString(string key, string defaultValue)
	{
		string text;
		return text;
	}

	// Token: 0x06000159 RID: 345 RVA: 0x00004458 File Offset: 0x00002658
	public static bool HasKey(string key)
	{
		bool flag;
		return flag;
	}

	// Token: 0x0600015A RID: 346 RVA: 0x00004468 File Offset: 0x00002668
	public static void Save()
	{
		PlayerPrefs.Save();
	}

	// Token: 0x0600015B RID: 347 RVA: 0x0000447C File Offset: 0x0000267C
	public static void SetFloat(string key, float value)
	{
		PlayerPrefs.SetFloat(key, value);
	}

	// Token: 0x0600015C RID: 348 RVA: 0x00004490 File Offset: 0x00002690
	public static void SetInt(string key, int value)
	{
		PlayerPrefs.SetInt(key, value);
	}

	// Token: 0x0600015D RID: 349 RVA: 0x000044A4 File Offset: 0x000026A4
	public static void SetString(string key, string value)
	{
		PlayerPrefs.SetString(key, value);
	}

	// Token: 0x0600015E RID: 350 RVA: 0x000044B8 File Offset: 0x000026B8
	public DrPlayerPrefs()
	{
	}
}
