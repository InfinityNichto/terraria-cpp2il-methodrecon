using System;
using Terraria;
using Terraria.Localization;

// Token: 0x020002F5 RID: 757
public class TutorialStep_06_Mining : TutorialStep
{
	// Token: 0x0600118B RID: 4491 RVA: 0x000566C0 File Offset: 0x000548C0
	public override TutorialStep.GuideOverLoadState GetGuideState()
	{
		return TutorialStep.GuideOverLoadState.StepInProgessDialogue;
	}

	// Token: 0x0600118C RID: 4492 RVA: 0x000566D0 File Offset: 0x000548D0
	public override string GetGuideString()
	{
		if (this.givenPickaxe)
		{
			bool flag = this.collectedOres;
			return "Tutorial.CollectOres";
		}
		return Language.GetText("Tutorial.CraftLightsValidHouse").<Value>k__BackingField;
	}

	// Token: 0x0600118D RID: 4493 RVA: 0x00056704 File Offset: 0x00054904
	public override void Reset()
	{
	}

	// Token: 0x0600118E RID: 4494 RVA: 0x00056714 File Offset: 0x00054914
	public override void OnItemPlaced(int itemId, int tileId)
	{
	}

	// Token: 0x0600118F RID: 4495 RVA: 0x00056724 File Offset: 0x00054924
	public override void OnGuideDialogueOpen()
	{
		if (this.givenPickaxe)
		{
			if (!this.givenFurnace && this.collectedOres)
			{
				this.givenFurnace = true;
				return;
			}
		}
		else
		{
			this.givenPickaxe = true;
		}
	}

	// Token: 0x06001190 RID: 4496 RVA: 0x00056758 File Offset: 0x00054958
	public override bool Update()
	{
		if (!true)
		{
		}
		int myPlayer = Main.myPlayer;
		long num = 0L;
		this.collectedOres = num != 0L;
		return this.givenFurnace;
	}

	// Token: 0x06001191 RID: 4497 RVA: 0x00056784 File Offset: 0x00054984
	public TutorialStep_06_Mining()
	{
	}

	// Token: 0x0400213F RID: 8511
	private bool givenPickaxe;

	// Token: 0x04002140 RID: 8512
	private bool collectedOres;

	// Token: 0x04002141 RID: 8513
	private bool givenFurnace;
}
