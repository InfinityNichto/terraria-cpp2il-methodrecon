using System;

// Token: 0x0200023C RID: 572
public class SaveDataViewWorld_Layout : LayoutDefinition
{
	// Token: 0x06000D15 RID: 3349 RVA: 0x0003EBAC File Offset: 0x0003CDAC
	private void Awake()
	{
	}

	// Token: 0x06000D16 RID: 3350 RVA: 0x0003EBBC File Offset: 0x0003CDBC
	public SaveDataViewWorld_Layout()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x0400179B RID: 6043
	public static SaveDataViewWorld_Layout Instance;

	// Token: 0x0400179C RID: 6044
	public Panel_Layout Backing;

	// Token: 0x0400179D RID: 6045
	public DraggableItemGrid_Layout WorldGrid;

	// Token: 0x0400179E RID: 6046
	public StringButton_Layout Title;

	// Token: 0x0400179F RID: 6047
	public TransactionButton_Layout New;

	// Token: 0x040017A0 RID: 6048
	public TransactionButton_Layout Back;

	// Token: 0x040017A1 RID: 6049
	public TransactionButton_Layout Options;

	// Token: 0x040017A2 RID: 6050
	public Panel_Layout OptionsGreyout;

	// Token: 0x040017A3 RID: 6051
	public Panel_Layout OptionsBacking;

	// Token: 0x040017A4 RID: 6052
	public Panel_Layout OptionsWithCloudBacking;

	// Token: 0x040017A5 RID: 6053
	public TransactionButton_Layout Play;

	// Token: 0x040017A6 RID: 6054
	public TransactionButton_Layout Delete;

	// Token: 0x040017A7 RID: 6055
	public TransactionButton_Layout Favorite;

	// Token: 0x040017A8 RID: 6056
	public TransactionButton_Layout Cloud;

	// Token: 0x040017A9 RID: 6057
	public SelectWorldFavoriteIcons FavoriteIcons;

	// Token: 0x040017AA RID: 6058
	public SelectWorldFavoriteIcons CloudIcons;

	// Token: 0x040017AB RID: 6059
	public Panel_Layout ItemBacking;

	// Token: 0x040017AC RID: 6060
	public Panel_Layout ItemGreyout;

	// Token: 0x040017AD RID: 6061
	public Panel_Layout ItemSelectedBacking;

	// Token: 0x040017AE RID: 6062
	public Panel_Layout ItemSelectedGreyout;

	// Token: 0x040017AF RID: 6063
	public Button_Layout ItemPlay;

	// Token: 0x040017B0 RID: 6064
	public Button_Layout ItemDelete;

	// Token: 0x040017B1 RID: 6065
	public Button_Layout ItemFavourite;

	// Token: 0x040017B2 RID: 6066
	public Button_Layout ItemCloud;

	// Token: 0x040017B3 RID: 6067
	public Button_Layout ItemDivider;

	// Token: 0x040017B4 RID: 6068
	public String_Layout ItemName;

	// Token: 0x040017B5 RID: 6069
	public Panel_Layout ItemNameDivider;

	// Token: 0x040017B6 RID: 6070
	public Panel_Layout ItemTimeBacking;

	// Token: 0x040017B7 RID: 6071
	public String_Layout ItemTime;

	// Token: 0x040017B8 RID: 6072
	public Panel_Layout ItemModeBacking;

	// Token: 0x040017B9 RID: 6073
	public String_Layout ItemMode;

	// Token: 0x040017BA RID: 6074
	public Panel_Layout ItemSizeBacking;

	// Token: 0x040017BB RID: 6075
	public String_Layout ItemSize;

	// Token: 0x040017BC RID: 6076
	public Panel_Layout ItemImage;
}
