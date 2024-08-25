using System;

// Token: 0x0200023B RID: 571
public class SaveDataViewPlayer_Layout : LayoutDefinition
{
	// Token: 0x06000D13 RID: 3347 RVA: 0x0003EB84 File Offset: 0x0003CD84
	private void Awake()
	{
	}

	// Token: 0x06000D14 RID: 3348 RVA: 0x0003EB94 File Offset: 0x0003CD94
	public SaveDataViewPlayer_Layout()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x04001777 RID: 6007
	public static SaveDataViewPlayer_Layout Instance;

	// Token: 0x04001778 RID: 6008
	public Panel_Layout Backing;

	// Token: 0x04001779 RID: 6009
	public DraggableItemGrid_Layout PlayerGrid;

	// Token: 0x0400177A RID: 6010
	public StringButton_Layout Title;

	// Token: 0x0400177B RID: 6011
	public TransactionButton_Layout New;

	// Token: 0x0400177C RID: 6012
	public TransactionButton_Layout Back;

	// Token: 0x0400177D RID: 6013
	public TransactionButton_Layout Options;

	// Token: 0x0400177E RID: 6014
	public Panel_Layout OptionsBacking;

	// Token: 0x0400177F RID: 6015
	public Panel_Layout OptionsWithCloudBacking;

	// Token: 0x04001780 RID: 6016
	public Panel_Layout OptionsGreyout;

	// Token: 0x04001781 RID: 6017
	public TransactionButton_Layout Play;

	// Token: 0x04001782 RID: 6018
	public TransactionButton_Layout Delete;

	// Token: 0x04001783 RID: 6019
	public TransactionButton_Layout Favorite;

	// Token: 0x04001784 RID: 6020
	public TransactionButton_Layout Cloud;

	// Token: 0x04001785 RID: 6021
	public SelectPlayerFavoriteIcons FavoriteIcons;

	// Token: 0x04001786 RID: 6022
	public SelectPlayerFavoriteIcons CloudIcons;

	// Token: 0x04001787 RID: 6023
	public Panel_Layout ItemBacking;

	// Token: 0x04001788 RID: 6024
	public Panel_Layout ItemSelectedBacking;

	// Token: 0x04001789 RID: 6025
	public Button_Layout ItemPlay;

	// Token: 0x0400178A RID: 6026
	public Button_Layout ItemDelete;

	// Token: 0x0400178B RID: 6027
	public Button_Layout ItemFavourite;

	// Token: 0x0400178C RID: 6028
	public Button_Layout ItemCloud;

	// Token: 0x0400178D RID: 6029
	public Button_Layout ItemDivider;

	// Token: 0x0400178E RID: 6030
	public Panel_Layout ItemHealthBacking;

	// Token: 0x0400178F RID: 6031
	public Button_Layout ItemHealthIcon;

	// Token: 0x04001790 RID: 6032
	public String_Layout ItemHealth;

	// Token: 0x04001791 RID: 6033
	public Panel_Layout ItemManaBacking;

	// Token: 0x04001792 RID: 6034
	public Button_Layout ItemManaIcon;

	// Token: 0x04001793 RID: 6035
	public String_Layout ItemMana;

	// Token: 0x04001794 RID: 6036
	public String_Layout ItemName;

	// Token: 0x04001795 RID: 6037
	public Panel_Layout ItemNameDivider;

	// Token: 0x04001796 RID: 6038
	public Panel_Layout ItemTimeBacking;

	// Token: 0x04001797 RID: 6039
	public String_Layout ItemTime;

	// Token: 0x04001798 RID: 6040
	public Panel_Layout ItemModeBacking;

	// Token: 0x04001799 RID: 6041
	public String_Layout ItemMode;

	// Token: 0x0400179A RID: 6042
	public Panel_Layout ItemImage;
}
