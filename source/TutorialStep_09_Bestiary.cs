using System;
using Terraria.Localization;

// Token: 0x020002F8 RID: 760
public class TutorialStep_09_Bestiary : TutorialStep
{
	// Token: 0x060011A0 RID: 4512 RVA: 0x00056BD0 File Offset: 0x00054DD0
	public override TutorialStep.GuideOverLoadState GetGuideState()
	{
		return TutorialStep.GuideOverLoadState.StepInProgessDialogue;
	}

	// Token: 0x060011A1 RID: 4513 RVA: 0x00056BE0 File Offset: 0x00054DE0
	public override string GetGuideString()
	{
		string <Value>k__BackingField = Language.GetText("Tutorial.OpenBestiary").<Value>k__BackingField;
		XNAUnityRunner.ForcedInputMode primaryInputMode = XNAUnityRunner.PrimaryInputMode;
		return Language.GetTextValue("TutorialTouch.OpenBestiary");
	}

	// Token: 0x060011A2 RID: 4514 RVA: 0x00056C40 File Offset: 0x00054E40
	public override void Begin()
	{
		if (!true)
		{
		}
	}

	// Token: 0x060011A3 RID: 4515 RVA: 0x00056C50 File Offset: 0x00054E50
	public override void Reset()
	{
	}

	// Token: 0x060011A4 RID: 4516 RVA: 0x00056C60 File Offset: 0x00054E60
	public override void OnGuideDialogueOpen()
	{
	}

	// Token: 0x060011A5 RID: 4517 RVA: 0x00056C70 File Offset: 0x00054E70
	public override bool Update()
	{
		this.openedBestiary = true;
		return true;
	}

	// Token: 0x060011A6 RID: 4518 RVA: 0x00056C90 File Offset: 0x00054E90
	public TutorialStep_09_Bestiary()
	{
	}

	// Token: 0x04002150 RID: 8528
	private bool openedBestiary;
}
