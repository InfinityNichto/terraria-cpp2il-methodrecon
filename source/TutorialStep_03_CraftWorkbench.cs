using System;
using Controller;
using Terraria;
using Terraria.Localization;
using UnityEngine;

// Token: 0x020002F2 RID: 754
public class TutorialStep_03_CraftWorkbench : TutorialStep
{
	// Token: 0x06001176 RID: 4470 RVA: 0x000561A8 File Offset: 0x000543A8
	public override TutorialStep.GuideOverLoadState GetGuideState()
	{
		return TutorialStep.GuideOverLoadState.StepInProgessDialogue;
	}

	// Token: 0x06001177 RID: 4471 RVA: 0x000561B8 File Offset: 0x000543B8
	public override string GetGuideString()
	{
		do
		{
			LocalizedText text = Language.GetText("Tutorial.NeedMoreWood");
			if (this.craftedWorkbench)
			{
			}
		}
		while (!this.got10Wood);
		string <Value>k__BackingField = Language.GetText("Tutorial.HaveWood").<Value>k__BackingField;
		XNAUnityRunner.ForcedInputMode primaryInputMode = XNAUnityRunner.PrimaryInputMode;
		if (this.craftedWorkbench)
		{
			string controlTag = GUIKeyboardMappings.GetControlTag(ControlsKeyboardTagHandler.MappingType.Aim);
			string text2 = <Value>k__BackingField.Replace("[cm:1]", controlTag);
			string controlTag2 = GUIKeyboardMappings.GetControlTag(ControlsKeyboardTagHandler.MappingType.Fire);
			string text3 = text2.Replace("[cm:2]", controlTag2);
			string controlTag3 = GUIKeyboardMappings.GetControlTag(ControlsKeyboardTagHandler.MappingType.InventoryToggle);
			string text4 = text3.Replace("[cm:5]", controlTag3);
			ControllerActionButton.Entry entry;
			ControllerActionButton.Entry entry2;
			if (entry.InputKey == KeyCode.None && entry2.InputKey == KeyCode.None)
			{
				return 9;
			}
			string controlTag4 = GUIKeyboardMappings.GetControlTag(ControlsKeyboardTagHandler.MappingType.CycleLeftPage);
			string text5 = text4.Replace("[cm:7]", controlTag4);
			string controlTag5 = GUIKeyboardMappings.GetControlTag(ControlsKeyboardTagHandler.MappingType.CycleRightPage);
			string text6 = text5.Replace("[cm:8]", controlTag5);
			ControllerActionButton.Entry entry3;
			ControllerActionButton.Entry entry4;
			if (entry3.InputKey != KeyCode.None || entry4.InputKey != KeyCode.None)
			{
				string controlTag6 = GUIKeyboardMappings.GetControlTag(ControlsKeyboardTagHandler.MappingType.CyclePreviousHotbarItem);
				string text7 = text6.Replace("[cm:9]", controlTag6);
				string controlTag7 = GUIKeyboardMappings.GetControlTag(ControlsKeyboardTagHandler.MappingType.CycleNextHotbarItem);
				string text8 = text7.Replace("[cm:10]", controlTag7);
				string controlTag8 = GUIKeyboardMappings.GetControlTag(ControlsKeyboardTagHandler.MappingType.CraftItem);
				return text8.Replace("[cm:12]", controlTag8);
			}
			return 22;
		}
		else
		{
			string text8;
			if (text8._stringLength != 0)
			{
				return "[cm:12]";
			}
			return Language.GetTextValue("TutorialTouch.NeedMoreWood");
		}
	}

	// Token: 0x06001178 RID: 4472 RVA: 0x00056314 File Offset: 0x00054514
	public override void Reset()
	{
	}

	// Token: 0x06001179 RID: 4473 RVA: 0x00056324 File Offset: 0x00054524
	public override void OnGuideDialogueOpen()
	{
		if (this.craftedWorkbench)
		{
			return;
		}
		if (this.got10Wood)
		{
			long num = 0L;
			base.SetTime(10, (int)num, true);
			return;
		}
	}

	// Token: 0x0600117A RID: 4474 RVA: 0x00056350 File Offset: 0x00054550
	public override void OnItemPlaced(int itemId, int tileType)
	{
		if (!true)
		{
		}
		this.placedWorkbench = true;
	}

	// Token: 0x0600117B RID: 4475 RVA: 0x00056368 File Offset: 0x00054568
	public override bool Update()
	{
		int num = 1;
		if (num == 0)
		{
		}
		int myPlayer = Main.myPlayer;
		int num2 = 1;
		this.got10Wood = num2 != 0;
		if (num == 0)
		{
		}
		this.craftedWorkbench = num2 != 0;
		return this.placedWorkbench;
	}

	// Token: 0x0600117C RID: 4476 RVA: 0x000563A4 File Offset: 0x000545A4
	public TutorialStep_03_CraftWorkbench()
	{
	}

	// Token: 0x04002134 RID: 8500
	private bool got10Wood;

	// Token: 0x04002135 RID: 8501
	private bool craftedWorkbench;

	// Token: 0x04002136 RID: 8502
	private bool placedWorkbench;
}
