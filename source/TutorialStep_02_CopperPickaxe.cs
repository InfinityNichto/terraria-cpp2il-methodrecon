using System;
using Terraria;
using Terraria.Localization;

// Token: 0x020002F1 RID: 753
public class TutorialStep_02_CopperPickaxe : TutorialStep
{
	// Token: 0x06001170 RID: 4464 RVA: 0x00056078 File Offset: 0x00054278
	public override TutorialStep.GuideOverLoadState GetGuideState()
	{
		return TutorialStep.GuideOverLoadState.StepCompleteDialogue;
	}

	// Token: 0x06001171 RID: 4465 RVA: 0x00056088 File Offset: 0x00054288
	public override string GetGuideString()
	{
		string <Value>k__BackingField = Language.GetText("Tutorial.CopperAxe").<Value>k__BackingField;
		XNAUnityRunner.ForcedInputMode primaryInputMode = XNAUnityRunner.PrimaryInputMode;
		return Language.GetTextValue("TutorialTouch.CopperAxe");
	}

	// Token: 0x06001172 RID: 4466 RVA: 0x0005611C File Offset: 0x0005431C
	public override void Reset()
	{
	}

	// Token: 0x06001173 RID: 4467 RVA: 0x0005612C File Offset: 0x0005432C
	public override void OnGuideDialogueOpen()
	{
		bool flag = this.givenAxe;
		if (flag)
		{
			return;
		}
		int num = 1;
		this.givenAxe = num != 0;
		if (!flag)
		{
		}
		int myPlayer = Main.myPlayer;
	}

	// Token: 0x06001174 RID: 4468 RVA: 0x00056170 File Offset: 0x00054370
	public override bool Update()
	{
		for (;;)
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
			if (this.givenAxe)
			{
				return;
			}
		}
	}

	// Token: 0x06001175 RID: 4469 RVA: 0x00056194 File Offset: 0x00054394
	public TutorialStep_02_CopperPickaxe()
	{
	}

	// Token: 0x04002133 RID: 8499
	private bool givenAxe;
}
