using System;
using Microsoft.Xna.Framework;

// Token: 0x0200018D RID: 397
public class Achievements_Layout : LayoutDefinition
{
	// Token: 0x06000B47 RID: 2887 RVA: 0x000391FC File Offset: 0x000373FC
	private void Awake()
	{
	}

	// Token: 0x06000B48 RID: 2888 RVA: 0x0003920C File Offset: 0x0003740C
	public Achievements_Layout()
	{
		if (340 == 0)
		{
		}
		base..ctor();
	}

	// Token: 0x04000BF6 RID: 3062
	public static Achievements_Layout Instance;

	// Token: 0x04000BF7 RID: 3063
	public Panel_Layout Backing;

	// Token: 0x04000BF8 RID: 3064
	public DraggableItemGrid_Layout AchievementsGrid;

	// Token: 0x04000BF9 RID: 3065
	public StringButton_Layout Title;

	// Token: 0x04000BFA RID: 3066
	public Panel_Layout MenuDivider;

	// Token: 0x04000BFB RID: 3067
	public Panel_Layout MenuDivider2;

	// Token: 0x04000BFC RID: 3068
	public TransactionButton_Layout Back;

	// Token: 0x04000BFD RID: 3069
	public Panel_Layout ItemBacking;

	// Token: 0x04000BFE RID: 3070
	public Panel_Layout ItemSelectedBacking;

	// Token: 0x04000BFF RID: 3071
	public Button_Layout ItemDivider;

	// Token: 0x04000C00 RID: 3072
	public String_Layout ItemName;

	// Token: 0x04000C01 RID: 3073
	public String_Layout ItemNameCompleted;

	// Token: 0x04000C02 RID: 3074
	public Panel_Layout ItemNameDivider;

	// Token: 0x04000C03 RID: 3075
	public String_Layout ItemDescription;

	// Token: 0x04000C04 RID: 3076
	public int ItemDescWidth = 340;

	// Token: 0x04000C05 RID: 3077
	public AchievementIcon ItemIcon;

	// Token: 0x04000C06 RID: 3078
	public Vector2 ItemCatIconsPosition = 340;

	// Token: 0x04000C07 RID: 3079
	public float ItemCatIconsScale = (float)16256;

	// Token: 0x04000C08 RID: 3080
	public String_Layout ProgressNumbers;

	// Token: 0x04000C09 RID: 3081
	public ProgressBar_Layout ProgressBar;

	// Token: 0x04000C0A RID: 3082
	public Panel_Layout ItemInnerPanelTop;

	// Token: 0x04000C0B RID: 3083
	public Panel_Layout ItemSelectedInnerPanelTop;

	// Token: 0x04000C0C RID: 3084
	public Panel_Layout ItemInnerPanelBottom;

	// Token: 0x04000C0D RID: 3085
	public Panel_Layout ItemSelectedInnerPanelBottom;

	// Token: 0x04000C0E RID: 3086
	public Panel_Layout CategoryDivider;

	// Token: 0x04000C0F RID: 3087
	public Vector2 InGameWindowShift = 340;

	// Token: 0x04000C10 RID: 3088
	public TransactionButton_Layout Filters;

	// Token: 0x04000C11 RID: 3089
	public Panel_Layout FiltersBacking;

	// Token: 0x04000C12 RID: 3090
	public TransactionButton_Layout Slayer;

	// Token: 0x04000C13 RID: 3091
	public TransactionButton_Layout Collector;

	// Token: 0x04000C14 RID: 3092
	public TransactionButton_Layout Explorer;

	// Token: 0x04000C15 RID: 3093
	public TransactionButton_Layout Challenger;
}
