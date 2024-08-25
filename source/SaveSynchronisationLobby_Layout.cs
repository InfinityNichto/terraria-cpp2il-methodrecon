using System;

// Token: 0x0200023D RID: 573
public class SaveSynchronisationLobby_Layout : LayoutDefinition
{
	// Token: 0x06000D17 RID: 3351 RVA: 0x0003EBD4 File Offset: 0x0003CDD4
	private void Awake()
	{
	}

	// Token: 0x06000D18 RID: 3352 RVA: 0x0003EBE4 File Offset: 0x0003CDE4
	public SaveSynchronisationLobby_Layout()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x040017BD RID: 6077
	public static SaveSynchronisationLobby_Layout Instance;

	// Token: 0x040017BE RID: 6078
	public Panel_Layout Backing;

	// Token: 0x040017BF RID: 6079
	public StringButton_Layout Title;

	// Token: 0x040017C0 RID: 6080
	public TransactionButton_Layout Back;

	// Token: 0x040017C1 RID: 6081
	public TransactionButton_Layout Connect;

	// Token: 0x040017C2 RID: 6082
	public TransactionButton_Layout ConnectViaIP;

	// Token: 0x040017C3 RID: 6083
	public String_Layout SearchingText;

	// Token: 0x040017C4 RID: 6084
	public Button_Layout SearchingIcon;

	// Token: 0x040017C5 RID: 6085
	public DraggableItemGrid_Layout HostDevicesGrid;

	// Token: 0x040017C6 RID: 6086
	public Panel_Layout ItemBacking;

	// Token: 0x040017C7 RID: 6087
	public Panel_Layout ItemSelectedBacking;

	// Token: 0x040017C8 RID: 6088
	public Button_Layout ItemDivider;

	// Token: 0x040017C9 RID: 6089
	public String_Layout ItemName;

	// Token: 0x040017CA RID: 6090
	public int ItemNameMaxWidth;

	// Token: 0x040017CB RID: 6091
	public Panel_Layout ItemNameDivider;

	// Token: 0x040017CC RID: 6092
	public TransactionButton_Layout ItemPlayers;

	// Token: 0x040017CD RID: 6093
	public TransactionButton_Layout ItemWorlds;

	// Token: 0x040017CE RID: 6094
	public Panel_Layout ItemImage;

	// Token: 0x040017CF RID: 6095
	public Texture_Layout PC_Icon;

	// Token: 0x040017D0 RID: 6096
	public Texture_Layout Amazon_Icon;

	// Token: 0x040017D1 RID: 6097
	public Texture_Layout Google_Icon;

	// Token: 0x040017D2 RID: 6098
	public Texture_Layout iOS_Icon;

	// Token: 0x040017D3 RID: 6099
	public Texture_Layout XBOX_Icon;

	// Token: 0x040017D4 RID: 6100
	public Texture_Layout PS4_Icon;

	// Token: 0x040017D5 RID: 6101
	public Texture_Layout Switch_Icon;
}
