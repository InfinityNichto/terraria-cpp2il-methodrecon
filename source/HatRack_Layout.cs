using System;

// Token: 0x020001D6 RID: 470
public class HatRack_Layout : PageControllerLayoutDefinition<HatRack_Layout>
{
	// Token: 0x06000C0F RID: 3087 RVA: 0x0003BDE4 File Offset: 0x00039FE4
	public HatRack_Layout()
	{
	}

	// Token: 0x040010E4 RID: 4324
	public String_Layout Title;

	// Token: 0x040010E5 RID: 4325
	public float HatScale;

	// Token: 0x040010E6 RID: 4326
	public float HatHighlightScale;

	// Token: 0x040010E7 RID: 4327
	public ItemGrid_Layout HatDye;

	// Token: 0x040010E8 RID: 4328
	public ItemGrid_Layout Hat;

	// Token: 0x040010E9 RID: 4329
	public TransactionButton_Layout RemoveButton;
}
