using System;

// Token: 0x02000074 RID: 116
public class GUIControllerMappingEntryBase : GUISettingEntry
{
	// Token: 0x06000288 RID: 648 RVA: 0x00007318 File Offset: 0x00005518
	public GUIControllerMappingEntryBase(GUISettingID id)
		: base(id)
	{
	}

	// Token: 0x04000241 RID: 577
	public ControllerMappingsCategories_Layout.Category Category;

	// Token: 0x04000242 RID: 578
	public int SortOrder;
}
