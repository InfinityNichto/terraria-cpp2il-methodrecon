using System;

// Token: 0x020001EB RID: 491
public class KeyboardMappings_Layout : LayoutDefinition
{
	// Token: 0x06000C52 RID: 3154 RVA: 0x0003D8AC File Offset: 0x0003BAAC
	private void Awake()
	{
	}

	// Token: 0x06000C53 RID: 3155 RVA: 0x0003D8BC File Offset: 0x0003BABC
	public KeyboardMappings_Layout()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x040011DA RID: 4570
	public static KeyboardMappings_Layout Instance;

	// Token: 0x040011DB RID: 4571
	public StringButton_Layout Title;

	// Token: 0x040011DC RID: 4572
	public Panel_Layout Backing;

	// Token: 0x040011DD RID: 4573
	public Panel_Layout MenuDivider;

	// Token: 0x040011DE RID: 4574
	public Panel_Layout MenuDivider2;

	// Token: 0x040011DF RID: 4575
	public DraggableItemGrid_Layout OptionGrid;

	// Token: 0x040011E0 RID: 4576
	public KeyboardMappingsCategories_Layout Categories;

	// Token: 0x040011E1 RID: 4577
	public TransactionButton_Layout Close;

	// Token: 0x040011E2 RID: 4578
	public TransactionButton_Layout ResetSettings;

	// Token: 0x040011E3 RID: 4579
	public TransactionButton_Layout Clear;

	// Token: 0x040011E4 RID: 4580
	public TransactionButton_Layout EditMapping;

	// Token: 0x040011E5 RID: 4581
	public TransactionButton_Layout Defaults;

	// Token: 0x040011E6 RID: 4582
	public ControllerMappingEntry_Layout PulldownTemplate;
}
