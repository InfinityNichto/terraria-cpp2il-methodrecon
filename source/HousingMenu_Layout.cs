using System;

// Token: 0x020001D9 RID: 473
public class HousingMenu_Layout : PageControllerLayoutDefinition<HousingMenu_Layout>
{
	// Token: 0x17000153 RID: 339
	// (get) Token: 0x06000C15 RID: 3093 RVA: 0x0003BE78 File Offset: 0x0003A078
	public DraggableItemGrid_Layout DisplayNPCGrid
	{
		get
		{
			DraggableItemGrid_Layout draggableItemGrid_Layout;
			return draggableItemGrid_Layout;
		}
	}

	// Token: 0x06000C16 RID: 3094 RVA: 0x0003BE88 File Offset: 0x0003A088
	public HousingMenu_Layout()
	{
	}

	// Token: 0x040010FE RID: 4350
	public String_Layout Title;

	// Token: 0x040010FF RID: 4351
	public float NPCScale;

	// Token: 0x04001100 RID: 4352
	public float NPCHighlightScale;

	// Token: 0x04001101 RID: 4353
	public DraggableItemGrid_Layout NPCGrid;

	// Token: 0x04001102 RID: 4354
	public DraggableItemGrid_Layout NPCGridCollapsed;

	// Token: 0x04001103 RID: 4355
	public TransactionButton_Layout HousingQuery;

	// Token: 0x04001104 RID: 4356
	public TransactionButton_Layout HousingClose;

	// Token: 0x04001105 RID: 4357
	public EmptyHousingSlot EmptySlot;
}
