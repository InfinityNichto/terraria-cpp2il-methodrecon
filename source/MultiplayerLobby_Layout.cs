using System;

// Token: 0x02000205 RID: 517
public class MultiplayerLobby_Layout : LayoutDefinition
{
	// Token: 0x06000CA9 RID: 3241 RVA: 0x0003E0B0 File Offset: 0x0003C2B0
	private void Awake()
	{
	}

	// Token: 0x06000CAA RID: 3242 RVA: 0x0003E0C0 File Offset: 0x0003C2C0
	public MultiplayerLobby_Layout()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x040012EF RID: 4847
	public static MultiplayerLobby_Layout Instance;

	// Token: 0x040012F0 RID: 4848
	public Panel_Layout Backing;

	// Token: 0x040012F1 RID: 4849
	public StringButton_Layout Title;

	// Token: 0x040012F2 RID: 4850
	public TransactionButton_Layout Options;

	// Token: 0x040012F3 RID: 4851
	public Panel_Layout OptionsBacking;

	// Token: 0x040012F4 RID: 4852
	public Panel_Layout OptionsGreyout;

	// Token: 0x040012F5 RID: 4853
	public TransactionButton_Layout LB;

	// Token: 0x040012F6 RID: 4854
	public TransactionButton_Layout RB;

	// Token: 0x040012F7 RID: 4855
	public TransactionButton_Layout Local;

	// Token: 0x040012F8 RID: 4856
	public TransactionButton_Layout Dedicated;

	// Token: 0x040012F9 RID: 4857
	public TransactionButton_Layout Friends;

	// Token: 0x040012FA RID: 4858
	public Panel_Layout MenuDivider;

	// Token: 0x040012FB RID: 4859
	public Panel_Layout MenuDivider2;

	// Token: 0x040012FC RID: 4860
	public TransactionButton_Layout Back;

	// Token: 0x040012FD RID: 4861
	public TransactionButton_Layout Join;

	// Token: 0x040012FE RID: 4862
	public TransactionButton_Layout Delete;

	// Token: 0x040012FF RID: 4863
	public TransactionButton_Layout Favorite;

	// Token: 0x04001300 RID: 4864
	public TransactionButton_Layout PlatformInvite;

	// Token: 0x04001301 RID: 4865
	public bool ShowPlatformInvite;

	// Token: 0x04001302 RID: 4866
	public bool AlwaysShowPlatformInvite;

	// Token: 0x04001303 RID: 4867
	public DraggableItemGrid_Layout FriendsGrid;

	// Token: 0x04001304 RID: 4868
	public DraggableItemGrid_Layout LocalGrid;

	// Token: 0x04001305 RID: 4869
	public TransactionButton_Layout LocalNew;

	// Token: 0x04001306 RID: 4870
	public String_Layout SearchingText;

	// Token: 0x04001307 RID: 4871
	public Button_Layout SearchingIcon;

	// Token: 0x04001308 RID: 4872
	public String_Layout NoFriendsText;

	// Token: 0x04001309 RID: 4873
	public DraggableItemGrid_Layout DedicatedGrid;

	// Token: 0x0400130A RID: 4874
	public TransactionButton_Layout DedicatedNew;

	// Token: 0x0400130B RID: 4875
	public Panel_Layout ItemBacking;

	// Token: 0x0400130C RID: 4876
	public Panel_Layout ItemSelectedBacking;

	// Token: 0x0400130D RID: 4877
	public Button_Layout ItemPlay;

	// Token: 0x0400130E RID: 4878
	public Button_Layout ItemDivider;

	// Token: 0x0400130F RID: 4879
	public String_Layout ItemName;

	// Token: 0x04001310 RID: 4880
	public int ItemNameMaxWidth;

	// Token: 0x04001311 RID: 4881
	public Panel_Layout ItemNameDivider;

	// Token: 0x04001312 RID: 4882
	public Panel_Layout ItemPlayerBacking;

	// Token: 0x04001313 RID: 4883
	public String_Layout ItemPlayer;

	// Token: 0x04001314 RID: 4884
	public Panel_Layout ItemModeBacking;

	// Token: 0x04001315 RID: 4885
	public String_Layout ItemMode;

	// Token: 0x04001316 RID: 4886
	public Panel_Layout ItemSizeBacking;

	// Token: 0x04001317 RID: 4887
	public String_Layout ItemSize;

	// Token: 0x04001318 RID: 4888
	public Panel_Layout ItemImage;

	// Token: 0x04001319 RID: 4889
	public Button_Layout ItemFavourite;

	// Token: 0x0400131A RID: 4890
	public SelectPlayerFavoriteIcons FavoriteIcons;
}
