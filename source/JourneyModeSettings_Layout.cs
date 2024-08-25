using System;

// Token: 0x020001E3 RID: 483
public class JourneyModeSettings_Layout : LayoutDefinition
{
	// Token: 0x06000C49 RID: 3145 RVA: 0x0003D348 File Offset: 0x0003B548
	private void Awake()
	{
	}

	// Token: 0x06000C4A RID: 3146 RVA: 0x0003D358 File Offset: 0x0003B558
	public JourneyModeSettings_Layout()
	{
	}

	// Token: 0x0400116F RID: 4463
	public static JourneyModeSettings_Layout Instance;

	// Token: 0x04001170 RID: 4464
	public TransactionButton_Layout JWSettingsButton;

	// Token: 0x04001171 RID: 4465
	public StringButton_Layout Title;

	// Token: 0x04001172 RID: 4466
	public Panel_Layout Backing;

	// Token: 0x04001173 RID: 4467
	public DraggableItemGrid_Layout OptionGrid;

	// Token: 0x04001174 RID: 4468
	public Panel_Layout MenuDivider;

	// Token: 0x04001175 RID: 4469
	public Panel_Layout MenuDivider2;

	// Token: 0x04001176 RID: 4470
	public TransactionButton_Layout CloseButton;

	// Token: 0x04001177 RID: 4471
	public Panel_Layout CategoryBacking;

	// Token: 0x04001178 RID: 4472
	public TransactionButton_Layout CategoryTime;

	// Token: 0x04001179 RID: 4473
	public TransactionButton_Layout CategoryWeather;

	// Token: 0x0400117A RID: 4474
	public TransactionButton_Layout CategoryPowers;

	// Token: 0x0400117B RID: 4475
	public JourneySettingsSlider_Layout SliderLayout;

	// Token: 0x0400117C RID: 4476
	public JourneySettingsButton_Layout ButtonLayout;

	// Token: 0x0400117D RID: 4477
	public JourneySettingsToggle_Layout ToggleLayout;

	// Token: 0x0400117E RID: 4478
	public TransactionButton_Layout WindEastNotch;

	// Token: 0x0400117F RID: 4479
	public TransactionButton_Layout WindNoneNotch;

	// Token: 0x04001180 RID: 4480
	public TransactionButton_Layout WindWestNotch;

	// Token: 0x04001181 RID: 4481
	public float WindNoneThreashold;

	// Token: 0x04001182 RID: 4482
	public float WindWestThreashold;

	// Token: 0x04001183 RID: 4483
	public TransactionButton_Layout RainClearNotch;

	// Token: 0x04001184 RID: 4484
	public TransactionButton_Layout RainDrizzleNotch;

	// Token: 0x04001185 RID: 4485
	public TransactionButton_Layout RainMonsoonNotch;

	// Token: 0x04001186 RID: 4486
	public float RainDrizzleThreshold;

	// Token: 0x04001187 RID: 4487
	public float RainMonsoonThreshold;

	// Token: 0x04001188 RID: 4488
	public TransactionButton_Layout DifficultyJourneyNotch;

	// Token: 0x04001189 RID: 4489
	public TransactionButton_Layout DifficultyClassicNotch;

	// Token: 0x0400118A RID: 4490
	public TransactionButton_Layout DifficultyExpertNotch;

	// Token: 0x0400118B RID: 4491
	public TransactionButton_Layout DifficultyMasterNotch;

	// Token: 0x0400118C RID: 4492
	public float DifficultyClassicThreshold;

	// Token: 0x0400118D RID: 4493
	public float DifficultyExpertThreshold;

	// Token: 0x0400118E RID: 4494
	public float DifficultyMasterThreshold = (float)52429;

	// Token: 0x0400118F RID: 4495
	public bool ControllerFosusShowItems = true;
}
