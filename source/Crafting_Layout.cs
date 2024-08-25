using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001CF RID: 463
public class Crafting_Layout : PageControllerLayoutDefinition<Crafting_Layout>
{
	// Token: 0x17000148 RID: 328
	// (get) Token: 0x06000BFB RID: 3067 RVA: 0x0003BB90 File Offset: 0x00039D90
	public DraggableItemGrid_Layout CraftGrid
	{
		get
		{
			DraggableItemGrid_Layout draggableItemGrid_Layout;
			return draggableItemGrid_Layout;
		}
	}

	// Token: 0x17000149 RID: 329
	// (get) Token: 0x06000BFC RID: 3068 RVA: 0x0003BBA0 File Offset: 0x00039DA0
	public DraggableItemGrid_Layout DuplicateGrid
	{
		get
		{
			DraggableItemGrid_Layout draggableItemGrid_Layout;
			return draggableItemGrid_Layout;
		}
	}

	// Token: 0x06000BFD RID: 3069 RVA: 0x0003BBB0 File Offset: 0x00039DB0
	public Crafting_Layout()
	{
		if (16192 == 0)
		{
		}
		this.DisabledBackingColor = 16192;
		this.MaterialBackingColor = 1;
		this.OverridenMaterialItemScale = (float)16128;
		this.OverridenMaterialTextScale = (float)16128;
		this.DisabledDuplicationBackingIconColor = 16128;
		this.DuplicationBackingColor = 16128;
		base..ctor();
	}

	// Token: 0x0400101B RID: 4123
	public String_Layout Title;

	// Token: 0x0400101C RID: 4124
	public float CraftItemScale = 0f;

	// Token: 0x0400101D RID: 4125
	public float CraftItemHighlightScale;

	// Token: 0x0400101E RID: 4126
	public DraggableItemGrid_Layout CraftItemGrid;

	// Token: 0x0400101F RID: 4127
	public DraggableItemGrid_Layout HorizontalCraftItemGrid;

	// Token: 0x04001020 RID: 4128
	public DraggableItemGrid_Layout CraftItemGridCollapsed;

	// Token: 0x04001021 RID: 4129
	public DraggableItemGrid_Layout HorizontalCraftItemGridCollapsed;

	// Token: 0x04001022 RID: 4130
	public float MaterialItemScale = (float)16192;

	// Token: 0x04001023 RID: 4131
	public Vector2 MaterialTooltipOriginOffsetLeft;

	// Token: 0x04001024 RID: 4132
	public Vector2 MaterialTooltipOriginOffsetRight;

	// Token: 0x04001025 RID: 4133
	public ItemGrid_Layout MaterialsGrid;

	// Token: 0x04001026 RID: 4134
	public ItemGrid_Layout MaterialsGridController;

	// Token: 0x04001027 RID: 4135
	public String_Layout MaterialsTitle;

	// Token: 0x04001028 RID: 4136
	public String_Layout NoRecipes;

	// Token: 0x04001029 RID: 4137
	public String_Layout NoRecipesController;

	// Token: 0x0400102A RID: 4138
	public bool ReverseScroll;

	// Token: 0x0400102B RID: 4139
	public bool DrawEmptySlots = true;

	// Token: 0x0400102C RID: 4140
	public Texture_Layout DisabledBacking;

	// Token: 0x0400102D RID: 4141
	public Color DisabledBackingColor;

	// Token: 0x0400102E RID: 4142
	public Texture_Layout DisabledBackingIcon;

	// Token: 0x0400102F RID: 4143
	public Color DisabledBackingIconColor;

	// Token: 0x04001030 RID: 4144
	public TransactionButton_Layout CraftButton;

	// Token: 0x04001031 RID: 4145
	public TransactionButton_Layout DuplicationButton;

	// Token: 0x04001032 RID: 4146
	public bool DisableMaterialBackings;

	// Token: 0x04001033 RID: 4147
	public Texture_Layout MaterialBacking;

	// Token: 0x04001034 RID: 4148
	public Texture_Layout MaterialBackingHighlght;

	// Token: 0x04001035 RID: 4149
	public Color MaterialBackingColor;

	// Token: 0x04001036 RID: 4150
	public Color MaterialBackingHighlightColor;

	// Token: 0x04001037 RID: 4151
	public bool OverrideMaterialItemScale;

	// Token: 0x04001038 RID: 4152
	public float OverridenMaterialItemScale;

	// Token: 0x04001039 RID: 4153
	public bool OverrideMaterialTextScale;

	// Token: 0x0400103A RID: 4154
	public float OverridenMaterialTextScale;

	// Token: 0x0400103B RID: 4155
	public Vector2 MaterialItemTextOffset;

	// Token: 0x0400103C RID: 4156
	public Color DisabledDuplicationBackingColor;

	// Token: 0x0400103D RID: 4157
	public Texture_Layout DisabledDuplicationBackingIcon;

	// Token: 0x0400103E RID: 4158
	public Color DisabledDuplicationBackingIconColor;

	// Token: 0x0400103F RID: 4159
	public Color DuplicationBackingColor;

	// Token: 0x04001040 RID: 4160
	public Color DuplicationBackingHighlightColor;
}
