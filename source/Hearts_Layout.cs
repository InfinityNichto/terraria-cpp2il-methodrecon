using System;

// Token: 0x020001D7 RID: 471
public class Hearts_Layout : LayoutDefinition
{
	// Token: 0x06000C10 RID: 3088 RVA: 0x0003BDF8 File Offset: 0x00039FF8
	private void Awake()
	{
	}

	// Token: 0x06000C11 RID: 3089 RVA: 0x0003BE08 File Offset: 0x0003A008
	public Hearts_Layout()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x040010EA RID: 4330
	public static Hearts_Layout Instance;

	// Token: 0x040010EB RID: 4331
	public bool HideWhenInventoryOpen = true;

	// Token: 0x040010EC RID: 4332
	public String_Layout HealthTitle;

	// Token: 0x040010ED RID: 4333
	public String_Layout HealthValue;

	// Token: 0x040010EE RID: 4334
	public float HeartsScale = (float)16256;

	// Token: 0x040010EF RID: 4335
	public ItemGrid_Layout HeartsGrid;

	// Token: 0x040010F0 RID: 4336
	public ItemGrid_Layout HeartsGridController;

	// Token: 0x040010F1 RID: 4337
	public String_Layout HealthTitleController;

	// Token: 0x040010F2 RID: 4338
	public String_Layout HealthValueController;

	// Token: 0x040010F3 RID: 4339
	public ItemGrid_Layout HorizontalHeartsGrid;

	// Token: 0x040010F4 RID: 4340
	public ItemGrid_Layout HorizontalHeartsGridController;
}
