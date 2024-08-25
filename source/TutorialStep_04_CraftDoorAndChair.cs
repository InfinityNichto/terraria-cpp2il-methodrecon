using System;
using Terraria.Localization;

// Token: 0x020002F3 RID: 755
public class TutorialStep_04_CraftDoorAndChair : TutorialStep
{
	// Token: 0x0600117D RID: 4477 RVA: 0x000563B8 File Offset: 0x000545B8
	public override TutorialStep.GuideOverLoadState GetGuideState()
	{
		return TutorialStep.GuideOverLoadState.StepInProgessDialogue;
	}

	// Token: 0x0600117E RID: 4478 RVA: 0x000563C8 File Offset: 0x000545C8
	public override string GetGuideString()
	{
		string <Value>k__BackingField = Language.GetText("Tutorial.CraftChairDoor").<Value>k__BackingField;
		XNAUnityRunner.ForcedInputMode primaryInputMode = XNAUnityRunner.PrimaryInputMode;
		return Language.GetTextValue("TutorialTouch.CraftChairDoor");
	}

	// Token: 0x0600117F RID: 4479 RVA: 0x00056410 File Offset: 0x00054610
	public override void Reset()
	{
	}

	// Token: 0x06001180 RID: 4480 RVA: 0x00056420 File Offset: 0x00054620
	public override void OnGuideDialogueOpen()
	{
		long num = 0L;
		base.SetTime(12, (int)num, true);
	}

	// Token: 0x06001181 RID: 4481 RVA: 0x0005643C File Offset: 0x0005463C
	public override void OnItemPlaced(int itemId, int tileId)
	{
		int num = 1;
		this.chairPlaced = num != 0;
	}

	// Token: 0x06001182 RID: 4482 RVA: 0x00056468 File Offset: 0x00054668
	public override bool Update()
	{
		if (this.doorPlaced && this.chairPlaced)
		{
			bool flag = this.tablePlaced;
			return;
		}
	}

	// Token: 0x06001183 RID: 4483 RVA: 0x00056490 File Offset: 0x00054690
	public TutorialStep_04_CraftDoorAndChair()
	{
	}

	// Token: 0x04002137 RID: 8503
	private bool doorPlaced;

	// Token: 0x04002138 RID: 8504
	private bool chairPlaced;

	// Token: 0x04002139 RID: 8505
	private bool tablePlaced;

	// Token: 0x0400213A RID: 8506
	private bool complete;
}
