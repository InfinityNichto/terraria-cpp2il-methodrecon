using System;

// Token: 0x02000201 RID: 513
public class MainMenu_Layout : LayoutDefinition
{
	// Token: 0x06000CA2 RID: 3234 RVA: 0x0003E024 File Offset: 0x0003C224
	private void Awake()
	{
	}

	// Token: 0x06000CA3 RID: 3235 RVA: 0x0003E034 File Offset: 0x0003C234
	public MainMenu_Layout()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x040012B1 RID: 4785
	public static MainMenu_Layout Instance;

	// Token: 0x040012B2 RID: 4786
	public Panel_Layout Backing;

	// Token: 0x040012B3 RID: 4787
	public TransactionButton_Layout Singleplayer;

	// Token: 0x040012B4 RID: 4788
	public TransactionButton_Layout Multiplayer;

	// Token: 0x040012B5 RID: 4789
	public TransactionButton_Layout Achievements;

	// Token: 0x040012B6 RID: 4790
	public TransactionButton_Layout Settings;

	// Token: 0x040012B7 RID: 4791
	public TransactionButton_Layout Tutorial;

	// Token: 0x040012B8 RID: 4792
	public TransactionButton_Layout Credits;

	// Token: 0x040012B9 RID: 4793
	public TransactionButton_Layout PurchaseFullGame;

	// Token: 0x040012BA RID: 4794
	public TransactionButton_Layout PlayerProfile;

	// Token: 0x040012BB RID: 4795
	public String_Layout VersionNumber;

	// Token: 0x040012BC RID: 4796
	public string VersionNumberText;

	// Token: 0x040012BD RID: 4797
	public String_Layout Copyright;

	// Token: 0x040012BE RID: 4798
	public string CopyrightText;
}
