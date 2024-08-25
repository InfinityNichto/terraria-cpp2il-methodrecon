using System;
using UnityEngine;

// Token: 0x02000059 RID: 89
public class Localisation
{
	// Token: 0x060001E1 RID: 481 RVA: 0x000059E8 File Offset: 0x00003BE8
	private static SystemLanguage GetPS4SystemLanguage()
	{
		return SystemLanguage.English;
	}

	// Token: 0x060001E2 RID: 482 RVA: 0x000059F8 File Offset: 0x00003BF8
	private static SystemLanguage GetSwitchSystemLanguage()
	{
		return SystemLanguage.English;
	}

	// Token: 0x060001E3 RID: 483 RVA: 0x00005A08 File Offset: 0x00003C08
	public static int GetLanguage()
	{
		SystemLanguage systemLanguage = Application.systemLanguage;
		Type type;
		string text;
		bool flag = Enum.IsDefined(type, text);
		Type type2;
		string text2;
		object obj = Enum.Parse(type2, text2);
		return 1;
	}

	// Token: 0x060001E4 RID: 484 RVA: 0x00005A38 File Offset: 0x00003C38
	public Localisation()
	{
	}

	// Token: 0x0200005A RID: 90
	public enum SupportedLanguages
	{
		// Token: 0x040001D6 RID: 470
		English = 1,
		// Token: 0x040001D7 RID: 471
		German,
		// Token: 0x040001D8 RID: 472
		Italian,
		// Token: 0x040001D9 RID: 473
		French,
		// Token: 0x040001DA RID: 474
		Spanish,
		// Token: 0x040001DB RID: 475
		Russian,
		// Token: 0x040001DC RID: 476
		Portuguese = 8,
		// Token: 0x040001DD RID: 477
		Japanese = 10
	}
}
