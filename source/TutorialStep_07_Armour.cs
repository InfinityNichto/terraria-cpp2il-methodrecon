using System;
using Terraria;
using Terraria.Localization;

// Token: 0x020002F6 RID: 758
public class TutorialStep_07_Armour : TutorialStep
{
	// Token: 0x06001192 RID: 4498 RVA: 0x00056798 File Offset: 0x00054998
	public override TutorialStep.GuideOverLoadState GetGuideState()
	{
		return TutorialStep.GuideOverLoadState.StepInProgessDialogue;
	}

	// Token: 0x06001193 RID: 4499 RVA: 0x000567A8 File Offset: 0x000549A8
	public override string GetGuideString()
	{
		if (this.copperGiven)
		{
			string textValue;
			if (this.armourHead && this.armourLegs && this.armourBody)
			{
				string <Value>k__BackingField = Language.GetText("Tutorial.EquipArmour").<Value>k__BackingField;
				XNAUnityRunner.ForcedInputMode primaryInputMode = XNAUnityRunner.PrimaryInputMode;
				textValue = Language.GetTextValue("TutorialTouch.EquipArmour");
				return textValue;
			}
			return textValue;
		}
		else
		{
			string textValue;
			if ("Tutorial.CraftCopperArmour2" != null)
			{
				return textValue;
			}
			if ("Tutorial.CraftCopperArmour" != null)
			{
				return textValue;
			}
			return Language.GetText("Tutorial.FurnaceSmelt2").<Value>k__BackingField;
		}
	}

	// Token: 0x06001194 RID: 4500 RVA: 0x000568B4 File Offset: 0x00054AB4
	public override void Reset()
	{
	}

	// Token: 0x06001195 RID: 4501 RVA: 0x000568C4 File Offset: 0x00054AC4
	public override void OnItemPlaced(int itemId, int tileId)
	{
		this.furnacePlaced = true;
	}

	// Token: 0x06001196 RID: 4502 RVA: 0x000568E0 File Offset: 0x00054AE0
	public override void OnGuideDialogueOpen()
	{
		bool flag = this.anvilPlaced;
		bool flag2 = this.copperGiven;
		if (flag)
		{
			if (!flag2)
			{
				this.copperGiven = true;
				return;
			}
		}
		else if (!true)
		{
			return;
		}
		if (this.armourHead && this.armourLegs && this.armourBody)
		{
			long num = 0L;
			base.SetTime(19, (int)num, true);
			this.complete = true;
		}
	}

	// Token: 0x06001197 RID: 4503 RVA: 0x00056938 File Offset: 0x00054B38
	public override bool Update()
	{
		if (!true)
		{
		}
		int myPlayer = Main.myPlayer;
		bool flag = this.armourHead;
		this.armourHead = flag;
		bool flag2 = this.armourBody;
		this.armourBody = flag2;
		bool flag3 = this.armourLegs;
		long num = 0L;
		this.armourLegs = num != 0L;
		long num2 = 0L;
		bool flag4 = this.collectedBars;
		bool flag5 = this.complete;
		this.collectedBars = num2 != 0L;
		return flag5;
	}

	// Token: 0x06001198 RID: 4504 RVA: 0x000569A4 File Offset: 0x00054BA4
	public TutorialStep_07_Armour()
	{
	}

	// Token: 0x04002142 RID: 8514
	private bool furnacePlaced;

	// Token: 0x04002143 RID: 8515
	private bool collectedBars;

	// Token: 0x04002144 RID: 8516
	private bool anvilPlaced;

	// Token: 0x04002145 RID: 8517
	private bool copperGiven;

	// Token: 0x04002146 RID: 8518
	private bool armourHead;

	// Token: 0x04002147 RID: 8519
	private bool armourBody;

	// Token: 0x04002148 RID: 8520
	private bool armourLegs;

	// Token: 0x04002149 RID: 8521
	private bool complete;
}
