using System;

// Token: 0x0200020C RID: 524
public class PlayerSelectMenu_Layout : LayoutDefinition
{
	// Token: 0x06000CB6 RID: 3254 RVA: 0x0003E1B8 File Offset: 0x0003C3B8
	private void Awake()
	{
	}

	// Token: 0x1700015F RID: 351
	// (get) Token: 0x06000CB7 RID: 3255 RVA: 0x0003E1C8 File Offset: 0x0003C3C8
	public int PlatformMaxPlayers
	{
		get
		{
			int maxPlayers = this.MaxPlayers;
			DrPlatform.DrPlatformType currentPlatform = DrPlatform.CurrentPlatform;
			int maxPlayers_Stadia = this.MaxPlayers_Stadia;
			DrPlatform.DrPlatformType currentPlatform2 = DrPlatform.CurrentPlatform;
			DrPlatform.DrPlatformType currentPlatform3 = DrPlatform.CurrentPlatform;
			DrPlatform.DrPlatformType currentPlatform4 = DrPlatform.CurrentPlatform;
			return 30;
		}
	}

	// Token: 0x06000CB8 RID: 3256 RVA: 0x0003E20C File Offset: 0x0003C40C
	public PlayerSelectMenu_Layout()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x04001368 RID: 4968
	public static PlayerSelectMenu_Layout Instance;

	// Token: 0x04001369 RID: 4969
	public Panel_Layout Backing;

	// Token: 0x0400136A RID: 4970
	public DraggableItemGrid_Layout PlayerGrid;

	// Token: 0x0400136B RID: 4971
	public StringButton_Layout Title;

	// Token: 0x0400136C RID: 4972
	public TransactionButton_Layout New;

	// Token: 0x0400136D RID: 4973
	public TransactionButton_Layout Back;

	// Token: 0x0400136E RID: 4974
	public Panel_Layout MenuDivider;

	// Token: 0x0400136F RID: 4975
	public TransactionButton_Layout Options;

	// Token: 0x04001370 RID: 4976
	public Panel_Layout OptionsBacking;

	// Token: 0x04001371 RID: 4977
	public Panel_Layout OptionsWithCloudBacking;

	// Token: 0x04001372 RID: 4978
	public Panel_Layout OptionsGreyout;

	// Token: 0x04001373 RID: 4979
	public TransactionButton_Layout Play;

	// Token: 0x04001374 RID: 4980
	public TransactionButton_Layout EditName;

	// Token: 0x04001375 RID: 4981
	public TransactionButton_Layout Delete;

	// Token: 0x04001376 RID: 4982
	public TransactionButton_Layout Favorite;

	// Token: 0x04001377 RID: 4983
	public TransactionButton_Layout Cloud;

	// Token: 0x04001378 RID: 4984
	public SelectPlayerFavoriteIcons FavoriteIcons;

	// Token: 0x04001379 RID: 4985
	public SelectPlayerFavoriteIcons CloudIcons;

	// Token: 0x0400137A RID: 4986
	public Panel_Layout ItemBacking;

	// Token: 0x0400137B RID: 4987
	public Panel_Layout ItemSelectedBacking;

	// Token: 0x0400137C RID: 4988
	public Button_Layout ItemPlay;

	// Token: 0x0400137D RID: 4989
	public Button_Layout ItemEditName;

	// Token: 0x0400137E RID: 4990
	public Button_Layout ItemDelete;

	// Token: 0x0400137F RID: 4991
	public Button_Layout ItemFavourite;

	// Token: 0x04001380 RID: 4992
	public Button_Layout ItemCloud;

	// Token: 0x04001381 RID: 4993
	public Button_Layout ItemDivider;

	// Token: 0x04001382 RID: 4994
	public Panel_Layout ItemHealthBacking;

	// Token: 0x04001383 RID: 4995
	public Button_Layout ItemHealthIcon;

	// Token: 0x04001384 RID: 4996
	public String_Layout ItemHealth;

	// Token: 0x04001385 RID: 4997
	public Panel_Layout ItemManaBacking;

	// Token: 0x04001386 RID: 4998
	public Button_Layout ItemManaIcon;

	// Token: 0x04001387 RID: 4999
	public String_Layout ItemMana;

	// Token: 0x04001388 RID: 5000
	public String_Layout ItemName;

	// Token: 0x04001389 RID: 5001
	public Panel_Layout ItemNameDivider;

	// Token: 0x0400138A RID: 5002
	public TransactionButton_Layout PlayerName;

	// Token: 0x0400138B RID: 5003
	public Panel_Layout ItemTimeBacking;

	// Token: 0x0400138C RID: 5004
	public String_Layout ItemTime;

	// Token: 0x0400138D RID: 5005
	public Panel_Layout ItemModeBacking;

	// Token: 0x0400138E RID: 5006
	public String_Layout ItemMode;

	// Token: 0x0400138F RID: 5007
	public Panel_Layout ItemImage;

	// Token: 0x04001390 RID: 5008
	public String_Layout SyncInformation;

	// Token: 0x04001391 RID: 5009
	public Button_Layout SyncIcon;

	// Token: 0x04001392 RID: 5010
	public int MaxPlayers;

	// Token: 0x04001393 RID: 5011
	public int MaxPlayers_Stadia;

	// Token: 0x04001394 RID: 5012
	public bool FavouriteVisualScroll = true;
}
