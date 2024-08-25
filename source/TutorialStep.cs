using System;
using Cpp2IlInjected;
using Terraria;
using Terraria.GameContent.Creative;

// Token: 0x020002EE RID: 750
public class TutorialStep
{
	// Token: 0x06001161 RID: 4449 RVA: 0x00055E18 File Offset: 0x00054018
	public virtual void Reset()
	{
	}

	// Token: 0x06001162 RID: 4450 RVA: 0x00055E28 File Offset: 0x00054028
	public virtual void Begin()
	{
	}

	// Token: 0x06001163 RID: 4451 RVA: 0x00055E38 File Offset: 0x00054038
	public virtual bool Update()
	{
	}

	// Token: 0x06001164 RID: 4452 RVA: 0x00055E48 File Offset: 0x00054048
	public virtual TutorialStep.GuideOverLoadState GetGuideState()
	{
	}

	// Token: 0x06001165 RID: 4453 RVA: 0x000021DB File Offset: 0x000003DB
	public virtual string GetGuideString()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06001166 RID: 4454 RVA: 0x00055E58 File Offset: 0x00054058
	public virtual void OnGuideDialogueOpen()
	{
	}

	// Token: 0x06001167 RID: 4455 RVA: 0x00055E68 File Offset: 0x00054068
	public virtual void OnItemPlaced(int itemId, int tileType)
	{
	}

	// Token: 0x06001168 RID: 4456 RVA: 0x00055E78 File Offset: 0x00054078
	protected void SetTime(int hour, int min, bool freeze)
	{
		bool <Enabled>k__BackingField = CreativePowerManager.Instance.GetPower<CreativePowers.FreezeTime>().<Enabled>k__BackingField;
		CreativePowerManager.Instance.GetPower<CreativePowers.FreezeTime>().RequestUse();
	}

	// Token: 0x06001169 RID: 4457 RVA: 0x00055EAC File Offset: 0x000540AC
	protected void SetSpawnRate(float spawnRate)
	{
		CreativePowerManager.Instance.GetPower<CreativePowers.SpawnRateSliderPerPlayerPower>().SetValueKeyboard(spawnRate);
		CreativePowerManager.Instance.GetPower<CreativePowers.SpawnRateSliderPerPlayerPower>().AttemptPushingChange();
	}

	// Token: 0x0600116A RID: 4458 RVA: 0x00055EDC File Offset: 0x000540DC
	protected void GiveItem(short item, int stackCount)
	{
		if (!true)
		{
		}
		Item item2;
		Main.mouseItem = item2;
		Item mouseItem = Main.mouseItem;
		int type = Main.mouseItem.type;
		mouseItem.SetDefaults(type);
		Main.mouseItem.stack = stackCount;
	}

	// Token: 0x0600116B RID: 4459 RVA: 0x00055F20 File Offset: 0x00054120
	public TutorialStep()
	{
	}

	// Token: 0x020002EF RID: 751
	public enum GuideOverLoadState
	{
		// Token: 0x0400212F RID: 8495
		None,
		// Token: 0x04002130 RID: 8496
		StepInProgessDialogue,
		// Token: 0x04002131 RID: 8497
		StepCompleteDialogue
	}
}
