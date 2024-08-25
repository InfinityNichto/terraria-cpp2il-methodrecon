using System;

// Token: 0x020001A5 RID: 421
public class ControllerMappings_Layout : LayoutDefinition
{
	// Token: 0x06000B72 RID: 2930 RVA: 0x0003A24C File Offset: 0x0003844C
	private void Awake()
	{
	}

	// Token: 0x06000B73 RID: 2931 RVA: 0x0003A25C File Offset: 0x0003845C
	public ControllerMappings_Layout()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x04000DAD RID: 3501
	public static ControllerMappings_Layout Instance;

	// Token: 0x04000DAE RID: 3502
	public StringButton_Layout Title;

	// Token: 0x04000DAF RID: 3503
	public Panel_Layout Backing;

	// Token: 0x04000DB0 RID: 3504
	public Panel_Layout MenuDivider;

	// Token: 0x04000DB1 RID: 3505
	public Panel_Layout MenuDivider2;

	// Token: 0x04000DB2 RID: 3506
	public DraggableItemGrid_Layout OptionGrid;

	// Token: 0x04000DB3 RID: 3507
	public ControllerMappingsCategories_Layout Categories;

	// Token: 0x04000DB4 RID: 3508
	public TransactionButton_Layout Close;

	// Token: 0x04000DB5 RID: 3509
	public TransactionButton_Layout ResetSettings;

	// Token: 0x04000DB6 RID: 3510
	public TransactionButton_Layout Clear;

	// Token: 0x04000DB7 RID: 3511
	public TransactionButton_Layout EditMapping;

	// Token: 0x04000DB8 RID: 3512
	public ControllerMappingEntry_Layout PulldownTemplate;
}
