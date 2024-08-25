using System;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000191 RID: 401
public class Bestiary_Layout : LayoutDefinition
{
	// Token: 0x06000B4E RID: 2894 RVA: 0x000392C4 File Offset: 0x000374C4
	private void Awake()
	{
	}

	// Token: 0x06000B4F RID: 2895 RVA: 0x000392D4 File Offset: 0x000374D4
	public Bestiary_Layout()
	{
		if (16256 == 0)
		{
		}
		this.SearchValidTextColor = 16256;
		this.SearchInvalidTextColor = 16256;
		if (16256 == 0)
		{
		}
		base..ctor();
	}

	// Token: 0x04000C2F RID: 3119
	public static Bestiary_Layout Instance;

	// Token: 0x04000C30 RID: 3120
	public TransactionButton_Layout BestiaryButton;

	// Token: 0x04000C31 RID: 3121
	public Panel_Layout Backing;

	// Token: 0x04000C32 RID: 3122
	public StringButton_Layout Title;

	// Token: 0x04000C33 RID: 3123
	public TransactionButton_Layout Back;

	// Token: 0x04000C34 RID: 3124
	public Panel_Layout LeftRightSeperator;

	// Token: 0x04000C35 RID: 3125
	public Panel_Layout MenuSeperator;

	// Token: 0x04000C36 RID: 3126
	public Panel_Layout CoinsSeperator;

	// Token: 0x04000C37 RID: 3127
	public DraggableItemGrid_Layout BestiaryGrid;

	// Token: 0x04000C38 RID: 3128
	public float BestiaryScale;

	// Token: 0x04000C39 RID: 3129
	public TransactionButton_Layout Order;

	// Token: 0x04000C3A RID: 3130
	public TransactionButton_Layout OrderController;

	// Token: 0x04000C3B RID: 3131
	public TransactionButton_Layout Filters;

	// Token: 0x04000C3C RID: 3132
	public TransactionButton_Layout FiltersController;

	// Token: 0x04000C3D RID: 3133
	public TransactionButton_Layout Close;

	// Token: 0x04000C3E RID: 3134
	public TransactionButton_Layout Loot;

	// Token: 0x04000C3F RID: 3135
	public TransactionButton_Layout LootController;

	// Token: 0x04000C40 RID: 3136
	public Panel_Layout LootBacking;

	// Token: 0x04000C41 RID: 3137
	public DraggableItemGrid_Layout LootGrid;

	// Token: 0x04000C42 RID: 3138
	public TransactionButton_Layout LootEntry;

	// Token: 0x04000C43 RID: 3139
	public String_Layout LootEntryCount;

	// Token: 0x04000C44 RID: 3140
	public String_Layout UnlockProgress;

	// Token: 0x04000C45 RID: 3141
	public Panel_Layout UnlockBarBacking;

	// Token: 0x04000C46 RID: 3142
	public Panel_Layout UnlockBarProgress;

	// Token: 0x04000C47 RID: 3143
	public Panel_Layout ItemBacking;

	// Token: 0x04000C48 RID: 3144
	public Panel_Layout ItemSelectedBacking;

	// Token: 0x04000C49 RID: 3145
	public Panel_Layout ItemImage;

	// Token: 0x04000C4A RID: 3146
	public String_Layout ItemId;

	// Token: 0x04000C4B RID: 3147
	public float ItemLockedScale = (float)16256;

	// Token: 0x04000C4C RID: 3148
	public Panel_Layout FiltersBacking;

	// Token: 0x04000C4D RID: 3149
	public ItemGrid_Layout FiltersGrid;

	// Token: 0x04000C4E RID: 3150
	public TransactionButton_Layout FilterEntry;

	// Token: 0x04000C4F RID: 3151
	public Panel_Layout SearchSeperator;

	// Token: 0x04000C50 RID: 3152
	public TransactionButton_Layout BeginSearch;

	// Token: 0x04000C51 RID: 3153
	public float SearchTextWrapSize = (float)17274;

	// Token: 0x04000C52 RID: 3154
	public String_Layout SearchText;

	// Token: 0x04000C53 RID: 3155
	public Color SearchValidTextColor;

	// Token: 0x04000C54 RID: 3156
	public Color SearchInvalidTextColor;

	// Token: 0x04000C55 RID: 3157
	public Panel_Layout OrdersBacking;

	// Token: 0x04000C56 RID: 3158
	public ItemGrid_Layout OrdersGrid;

	// Token: 0x04000C57 RID: 3159
	public TransactionButton_Layout OrderEntry;

	// Token: 0x04000C58 RID: 3160
	public Texture_Layout[] OrderIcons;

	// Token: 0x04000C59 RID: 3161
	public Panel_Layout EntryNameBacking;

	// Token: 0x04000C5A RID: 3162
	public String_Layout EntryName;

	// Token: 0x04000C5B RID: 3163
	public Panel_Layout EntryImage;

	// Token: 0x04000C5C RID: 3164
	public Panel_Layout EntryImageOverlay;

	// Token: 0x04000C5D RID: 3165
	public Panel_Layout EntryScrollDivider;

	// Token: 0x04000C5E RID: 3166
	public ItemGrid_Layout EntryStars;

	// Token: 0x04000C5F RID: 3167
	public float EntryStarScale;

	// Token: 0x04000C60 RID: 3168
	public ItemGrid_Layout EntrySpawns;

	// Token: 0x04000C61 RID: 3169
	public Panel_Layout EntrySpawnBacking;

	// Token: 0x04000C62 RID: 3170
	public Panel_Layout EntrySpawnIcon;

	// Token: 0x04000C63 RID: 3171
	public String_Layout EntrySpawnType;

	// Token: 0x04000C64 RID: 3172
	public TransactionButton_Layout EntryHealth;

	// Token: 0x04000C65 RID: 3173
	public TransactionButton_Layout EntryAttack;

	// Token: 0x04000C66 RID: 3174
	public TransactionButton_Layout EntryDefence;

	// Token: 0x04000C67 RID: 3175
	public TransactionButton_Layout EntryKnockback;

	// Token: 0x04000C68 RID: 3176
	public TransactionButton_Layout EntryKills;

	// Token: 0x04000C69 RID: 3177
	public TransactionButton_Layout EntryCoinDropBacking;

	// Token: 0x04000C6A RID: 3178
	public TransactionButton_Layout EntryCoinPlatinum;

	// Token: 0x04000C6B RID: 3179
	public TransactionButton_Layout EntryCoinGold;

	// Token: 0x04000C6C RID: 3180
	public TransactionButton_Layout EntryCoinSilver;

	// Token: 0x04000C6D RID: 3181
	public TransactionButton_Layout EntryCoinCopper;

	// Token: 0x04000C6E RID: 3182
	public String_Layout EntryDescription;
}
