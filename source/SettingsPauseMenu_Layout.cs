using System;

// Token: 0x0200021D RID: 541
public class SettingsPauseMenu_Layout : LayoutDefinition
{
	// Token: 0x06000CCE RID: 3278 RVA: 0x0003E458 File Offset: 0x0003C658
	private void Awake()
	{
	}

	// Token: 0x06000CCF RID: 3279 RVA: 0x0003E468 File Offset: 0x0003C668
	public SettingsPauseMenu_Layout()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x040014BC RID: 5308
	public static SettingsPauseMenu_Layout Instance;

	// Token: 0x040014BD RID: 5309
	public Panel_Layout Backing;

	// Token: 0x040014BE RID: 5310
	public Panel_Layout JourneyBacking;

	// Token: 0x040014BF RID: 5311
	public TransactionButton_Layout Settings;

	// Token: 0x040014C0 RID: 5312
	public TransactionButton_Layout Home;

	// Token: 0x040014C1 RID: 5313
	public TransactionButton_Layout Achievements;

	// Token: 0x040014C2 RID: 5314
	public TransactionButton_Layout Bestiary;

	// Token: 0x040014C3 RID: 5315
	public TransactionButton_Layout JourneySettings;

	// Token: 0x040014C4 RID: 5316
	public TransactionButton_Layout Close;

	// Token: 0x040014C5 RID: 5317
	public float ButtonExtraPadding;
}
