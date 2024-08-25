using System;
using Terraria;

// Token: 0x020002F0 RID: 752
public class TutorialStep_01_WelcomeDialogue : TutorialStep
{
	// Token: 0x0600116C RID: 4460 RVA: 0x00055F34 File Offset: 0x00054134
	public override void Reset()
	{
	}

	// Token: 0x0600116D RID: 4461 RVA: 0x00055F44 File Offset: 0x00054144
	public override void Begin()
	{
		if (!true)
		{
		}
	}

	// Token: 0x0600116E RID: 4462 RVA: 0x00055F54 File Offset: 0x00054154
	public override bool Update()
	{
		if (!true)
		{
		}
		bool gameMenu = Main.gameMenu;
		bool flag = this.displayed;
		return gameMenu;
	}

	// Token: 0x0600116F RID: 4463 RVA: 0x00056064 File Offset: 0x00054264
	public TutorialStep_01_WelcomeDialogue()
	{
	}

	// Token: 0x04002132 RID: 8498
	private bool displayed;
}
