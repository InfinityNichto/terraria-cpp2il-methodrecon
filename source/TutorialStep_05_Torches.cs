using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using UnityEngine;

// Token: 0x020002F4 RID: 756
public class TutorialStep_05_Torches : TutorialStep
{
	// Token: 0x06001184 RID: 4484 RVA: 0x000564A4 File Offset: 0x000546A4
	public override TutorialStep.GuideOverLoadState GetGuideState()
	{
		return TutorialStep.GuideOverLoadState.StepInProgessDialogue;
	}

	// Token: 0x06001185 RID: 4485 RVA: 0x000564B4 File Offset: 0x000546B4
	public override string GetGuideString()
	{
		LocalizedText text = Language.GetText("Tutorial.CraftLightsKillSlimes2");
		if (this.givenSword && !this.torchesPlaced)
		{
			KeyCode keyCode;
			while (keyCode == KeyCode.None)
			{
			}
			string text2;
			return text2;
		}
		string <Value>k__BackingField = Language.GetText("Tutorial.CraftLightsKillSlimes").<Value>k__BackingField;
		if ("Tutorial.CraftLightsKillSlimes" == null)
		{
		}
		XNAUnityRunner.ForcedInputMode primaryInputMode = XNAUnityRunner.PrimaryInputMode;
		string textValue = Language.GetTextValue("TutorialTouch.CraftLightsKillSlimes2");
		if (!this.givenSword || this.torchesPlaced)
		{
			return Language.GetTextValue("TutorialTouch.CraftLightsKillSlimes");
		}
		if ("Tutorial.CraftLightsCraftTorches" != null)
		{
			return "TutorialTouch.CraftLightsCraftTorches";
		}
		string text3;
		return text3;
	}

	// Token: 0x06001186 RID: 4486 RVA: 0x000565AC File Offset: 0x000547AC
	public override void Reset()
	{
	}

	// Token: 0x06001187 RID: 4487 RVA: 0x000565BC File Offset: 0x000547BC
	public override void OnItemPlaced(int itemId, int tileId)
	{
		int num = 1;
		if (num == 0)
		{
		}
		if (num != 0)
		{
			int num2 = 1;
			this.torchesPlaced = num2 != 0;
		}
	}

	// Token: 0x06001188 RID: 4488 RVA: 0x000565DC File Offset: 0x000547DC
	public override void OnGuideDialogueOpen()
	{
		while (this.givenSword)
		{
			if (this.torchesPlaced)
			{
				return;
			}
			if (this.collectedGels)
			{
				long num = 0L;
				base.SetTime(14, (int)num, true);
				return;
			}
		}
		long num2 = 0L;
		base.SetTime(13, (int)num2, true);
		this.givenSword = true;
	}

	// Token: 0x06001189 RID: 4489 RVA: 0x00056624 File Offset: 0x00054824
	public override bool Update()
	{
		if (!true)
		{
		}
		int myPlayer = Main.myPlayer;
		int num = 1;
		this.collectedGels = num != 0;
		this.craftedTorches = num != 0;
		int worldMouseX = Main.worldMouseX;
		Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
		int worldMouseY = Main.worldMouseY;
		Microsoft.Xna.Framework.Vector2 screenPosition2 = Main.screenPosition;
		int num2 = 32640;
		if (num2 == 0)
		{
		}
		if (num2 == 0)
		{
		}
		bool flag = WorldGen.RoomNeeds(22);
		Debug.Log("Room complete");
		int num3 = 1;
		this.torchesPlaced = num3 != 0;
		return this.torchesPlaced;
	}

	// Token: 0x0600118A RID: 4490 RVA: 0x000566AC File Offset: 0x000548AC
	public TutorialStep_05_Torches()
	{
	}

	// Token: 0x0400213B RID: 8507
	private bool givenSword;

	// Token: 0x0400213C RID: 8508
	private bool collectedGels;

	// Token: 0x0400213D RID: 8509
	private bool craftedTorches;

	// Token: 0x0400213E RID: 8510
	private bool torchesPlaced;
}
