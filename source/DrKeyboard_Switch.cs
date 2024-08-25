using System;
using UnityEngine;

// Token: 0x0200001F RID: 31
public class DrKeyboard_Switch : DrKeyboard_Touch
{
	// Token: 0x06000098 RID: 152 RVA: 0x00003320 File Offset: 0x00001520
	public DrKeyboard_Switch(TouchScreenKeyboardType type, string initialText, int maxChars, string title, string prompt, bool multiline, bool filterText)
	{
		long num = 0L;
		base..ctor(type, initialText, maxChars, title, prompt, num != 0L, filterText);
	}

	// Token: 0x04000067 RID: 103
	public static DrKeyboard_Switch LastKeyboard;
}
