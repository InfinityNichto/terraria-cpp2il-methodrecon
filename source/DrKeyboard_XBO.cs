using System;
using UnityEngine;

// Token: 0x02000021 RID: 33
public class DrKeyboard_XBO : DrKeyboard_Touch
{
	// Token: 0x060000A1 RID: 161 RVA: 0x00003438 File Offset: 0x00001638
	public DrKeyboard_XBO(TouchScreenKeyboardType type, string initialText, int maxChars, string title, string prompt)
	{
		long num = 0L;
		long num2 = 0L;
		base..ctor(type, initialText, maxChars, title, prompt, num != 0L, num2 != 0L);
	}

	// Token: 0x0400006A RID: 106
	public static DrKeyboard_XBO LastKeyboard;
}
