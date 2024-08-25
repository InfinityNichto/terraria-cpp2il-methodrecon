using System;
using Terraria;
using Terraria.Localization;

// Token: 0x020002F7 RID: 759
public class TutorialStep_08_KillZombies : TutorialStep
{
	// Token: 0x06001199 RID: 4505 RVA: 0x000569B8 File Offset: 0x00054BB8
	public override TutorialStep.GuideOverLoadState GetGuideState()
	{
		return TutorialStep.GuideOverLoadState.StepInProgessDialogue;
	}

	// Token: 0x0600119A RID: 4506 RVA: 0x000569C8 File Offset: 0x00054BC8
	public override string GetGuideString()
	{
		while ((!this.armourHead || !this.armourBody || !this.armourLegs) && !this.killing)
		{
			string <Value>k__BackingField = Language.GetText("Tutorial.EquipArmour").<Value>k__BackingField;
			XNAUnityRunner.ForcedInputMode primaryInputMode = XNAUnityRunner.PrimaryInputMode;
			if ((!this.armourHead || !this.armourBody || !this.armourLegs) && !this.killing)
			{
				return Language.GetTextValue("TutorialTouch.EquipArmour");
			}
		}
		return Language.GetText("Tutorial.KillZombies").<Value>k__BackingField;
	}

	// Token: 0x0600119B RID: 4507 RVA: 0x00056AD8 File Offset: 0x00054CD8
	public override void Reset()
	{
	}

	// Token: 0x0600119C RID: 4508 RVA: 0x00056AE8 File Offset: 0x00054CE8
	public override void OnItemPlaced(int itemId, int tileId)
	{
	}

	// Token: 0x0600119D RID: 4509 RVA: 0x00056AF8 File Offset: 0x00054CF8
	public override void OnGuideDialogueOpen()
	{
		if (this.killing)
		{
			return;
		}
		if (this.armourHead && this.armourBody)
		{
			bool flag = this.armourLegs;
			if (flag)
			{
				this.killing = true;
				if (!flag)
				{
				}
				DateTime now = DateTime.Now;
				this.killStart = now;
				return;
			}
		}
	}

	// Token: 0x0600119E RID: 4510 RVA: 0x00056B4C File Offset: 0x00054D4C
	public override bool Update()
	{
		int num = 1;
		if (num == 0)
		{
		}
		int myPlayer = Main.myPlayer;
		this.armourHead = num != 0;
		int myPlayer2 = Main.myPlayer;
		int myPlayer3 = Main.myPlayer;
		if (this.killing)
		{
			DateTime now = DateTime.Now;
			DateTime dateTime = this.killStart;
			double totalSeconds = (now - dateTime).TotalSeconds;
			int num2 = 1;
			this.complete = num2 != 0;
		}
		return this.complete;
	}

	// Token: 0x0600119F RID: 4511 RVA: 0x00056BBC File Offset: 0x00054DBC
	public TutorialStep_08_KillZombies()
	{
	}

	// Token: 0x0400214A RID: 8522
	private bool armourHead;

	// Token: 0x0400214B RID: 8523
	private bool armourBody;

	// Token: 0x0400214C RID: 8524
	private bool armourLegs;

	// Token: 0x0400214D RID: 8525
	private bool complete;

	// Token: 0x0400214E RID: 8526
	private bool killing;

	// Token: 0x0400214F RID: 8527
	private DateTime killStart;
}
