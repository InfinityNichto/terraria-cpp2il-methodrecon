using System;

// Token: 0x02000203 RID: 515
public class MultiplayerHost_Layout : LayoutDefinition
{
	// Token: 0x06000CA5 RID: 3237 RVA: 0x0003E060 File Offset: 0x0003C260
	private void Awake()
	{
	}

	// Token: 0x06000CA6 RID: 3238 RVA: 0x0003E070 File Offset: 0x0003C270
	public MultiplayerHost_Layout()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x040012C3 RID: 4803
	public static MultiplayerHost_Layout Instance;

	// Token: 0x040012C4 RID: 4804
	public Panel_Layout Backing;

	// Token: 0x040012C5 RID: 4805
	public Panel_Layout Greyout;

	// Token: 0x040012C6 RID: 4806
	public StringButton_Layout Title;

	// Token: 0x040012C7 RID: 4807
	public Panel_Layout MenuDivider;

	// Token: 0x040012C8 RID: 4808
	public TransactionButton_Layout Back;

	// Token: 0x040012C9 RID: 4809
	public TransactionButton_Layout Host;

	// Token: 0x040012CA RID: 4810
	public MaxPlayersSlider_Layout MaxPlayers;

	// Token: 0x040012CB RID: 4811
	public TransactionButton_Layout Password;

	// Token: 0x040012CC RID: 4812
	public Panel_Layout ItemBacking;

	// Token: 0x040012CD RID: 4813
	public Button_Layout ItemPlay;

	// Token: 0x040012CE RID: 4814
	public Button_Layout ItemDelete;

	// Token: 0x040012CF RID: 4815
	public Button_Layout ItemFavourite;

	// Token: 0x040012D0 RID: 4816
	public Button_Layout ItemDivider;

	// Token: 0x040012D1 RID: 4817
	public String_Layout ItemName;

	// Token: 0x040012D2 RID: 4818
	public Panel_Layout ItemNameDivider;

	// Token: 0x040012D3 RID: 4819
	public Panel_Layout ItemTimeBacking;

	// Token: 0x040012D4 RID: 4820
	public String_Layout ItemTime;

	// Token: 0x040012D5 RID: 4821
	public Panel_Layout ItemModeBacking;

	// Token: 0x040012D6 RID: 4822
	public String_Layout ItemMode;

	// Token: 0x040012D7 RID: 4823
	public Panel_Layout ItemSizeBacking;

	// Token: 0x040012D8 RID: 4824
	public String_Layout ItemSize;

	// Token: 0x040012D9 RID: 4825
	public Panel_Layout ItemImage;

	// Token: 0x040012DA RID: 4826
	public String_Layout PlayerCountTitle;

	// Token: 0x040012DB RID: 4827
	public String_Layout PlayerCountLabel;

	// Token: 0x040012DC RID: 4828
	public Slider_Layout PlayerCount;

	// Token: 0x040012DD RID: 4829
	public String_Layout ServerPasswordTitle;

	// Token: 0x040012DE RID: 4830
	public String_Layout ServerPasswordEdit;

	// Token: 0x040012DF RID: 4831
	public SettingsOverlayToggle_Layout InviteOpenToggle;
}
