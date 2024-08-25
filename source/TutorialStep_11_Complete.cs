using System;
using Terraria;
using Terraria.Localization;

// Token: 0x020002FA RID: 762
public class TutorialStep_11_Complete : TutorialStep
{
	// Token: 0x060011AE RID: 4526 RVA: 0x00056D58 File Offset: 0x00054F58
	public override TutorialStep.GuideOverLoadState GetGuideState()
	{
		return TutorialStep.GuideOverLoadState.StepInProgessDialogue;
	}

	// Token: 0x060011AF RID: 4527 RVA: 0x00056D68 File Offset: 0x00054F68
	public override string GetGuideString()
	{
		string <Value>k__BackingField = Language.GetText("Tutorial.Complete").<Value>k__BackingField;
		XNAUnityRunner.ForcedInputMode primaryInputMode = XNAUnityRunner.PrimaryInputMode;
		return Language.GetTextValue("TutorialTouch.Complete");
	}

	// Token: 0x060011B0 RID: 4528 RVA: 0x00056DAC File Offset: 0x00054FAC
	public override void Reset()
	{
	}

	// Token: 0x060011B1 RID: 4529 RVA: 0x00056DBC File Offset: 0x00054FBC
	public override void OnItemPlaced(int itemId, int tileId)
	{
	}

	// Token: 0x060011B2 RID: 4530 RVA: 0x00056DCC File Offset: 0x00054FCC
	public override void OnGuideDialogueOpen()
	{
		int num = 1;
		this.complete = num != 0;
		if (num == 0)
		{
		}
		int myPlayer = Main.myPlayer;
	}

	// Token: 0x060011B3 RID: 4531 RVA: 0x00056DF0 File Offset: 0x00054FF0
	public override bool Update()
	{
		return this.complete;
	}

	// Token: 0x060011B4 RID: 4532 RVA: 0x00056E04 File Offset: 0x00055004
	public TutorialStep_11_Complete()
	{
	}

	// Token: 0x04002152 RID: 8530
	private bool complete;
}
