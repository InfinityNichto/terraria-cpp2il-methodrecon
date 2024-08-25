using System;
using Terraria.Localization;

// Token: 0x020002F9 RID: 761
public class TutorialStep_10_Settings : TutorialStep
{
	// Token: 0x060011A7 RID: 4519 RVA: 0x00056CA4 File Offset: 0x00054EA4
	public override TutorialStep.GuideOverLoadState GetGuideState()
	{
		return TutorialStep.GuideOverLoadState.StepInProgessDialogue;
	}

	// Token: 0x060011A8 RID: 4520 RVA: 0x00056CB4 File Offset: 0x00054EB4
	public override string GetGuideString()
	{
		string <Value>k__BackingField = Language.GetText("Tutorial.OpenSettings").<Value>k__BackingField;
		XNAUnityRunner.ForcedInputMode primaryInputMode = XNAUnityRunner.PrimaryInputMode;
		return Language.GetTextValue("TutorialTouch.OpenSettings");
	}

	// Token: 0x060011A9 RID: 4521 RVA: 0x00056CFC File Offset: 0x00054EFC
	public override void Reset()
	{
	}

	// Token: 0x060011AA RID: 4522 RVA: 0x00056D0C File Offset: 0x00054F0C
	public override void OnItemPlaced(int itemId, int tileId)
	{
	}

	// Token: 0x060011AB RID: 4523 RVA: 0x00056D1C File Offset: 0x00054F1C
	public override void OnGuideDialogueOpen()
	{
		this.complete = true;
	}

	// Token: 0x060011AC RID: 4524 RVA: 0x00056D30 File Offset: 0x00054F30
	public override bool Update()
	{
		return this.complete;
	}

	// Token: 0x060011AD RID: 4525 RVA: 0x00056D44 File Offset: 0x00054F44
	public TutorialStep_10_Settings()
	{
	}

	// Token: 0x04002151 RID: 8529
	private bool complete;
}
