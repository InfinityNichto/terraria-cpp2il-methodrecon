using System;

// Token: 0x02000196 RID: 406
public class ButtonBar_Layout : LayoutDefinition
{
	// Token: 0x06000B5B RID: 2907 RVA: 0x0003941C File Offset: 0x0003761C
	private void Awake()
	{
	}

	// Token: 0x06000B5C RID: 2908 RVA: 0x0003942C File Offset: 0x0003762C
	public ButtonBar_Layout()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x04000CA3 RID: 3235
	public static ButtonBar_Layout Instance;

	// Token: 0x04000CA4 RID: 3236
	public float GridItemScale;

	// Token: 0x04000CA5 RID: 3237
	public Stretched_Layout Backing;

	// Token: 0x04000CA6 RID: 3238
	public ItemGrid_Layout ButtonGrid;

	// Token: 0x04000CA7 RID: 3239
	public TransactionButton_Layout ButtonCollapsed;

	// Token: 0x04000CA8 RID: 3240
	public TransactionButton_Layout ButtonTemplateFirst;

	// Token: 0x04000CA9 RID: 3241
	public TransactionButton_Layout ButtonTemplateEntry;

	// Token: 0x04000CAA RID: 3242
	public TransactionButton_Layout ButtonTemplateLast;

	// Token: 0x04000CAB RID: 3243
	public Texture_Layout ExpandIcon;

	// Token: 0x04000CAC RID: 3244
	public Texture_Layout CollapseIcon;

	// Token: 0x04000CAD RID: 3245
	public Texture_Layout ChatIcon;

	// Token: 0x04000CAE RID: 3246
	public Texture_Layout TutorialIcon;

	// Token: 0x04000CAF RID: 3247
	public Texture_Layout TutorialIconSelected;

	// Token: 0x04000CB0 RID: 3248
	public Texture_Layout JourneyWorldSettingsIcon;

	// Token: 0x04000CB1 RID: 3249
	public Texture_Layout HousingIcon;

	// Token: 0x04000CB2 RID: 3250
	public Texture_Layout PVPIcon;

	// Token: 0x04000CB3 RID: 3251
	public Texture_Layout BestiaryIcon;

	// Token: 0x04000CB4 RID: 3252
	public Texture_Layout DuplicateIcon;

	// Token: 0x04000CB5 RID: 3253
	public Texture_Layout MapIcon;
}
