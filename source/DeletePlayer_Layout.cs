using System;

// Token: 0x020001F5 RID: 501
public class DeletePlayer_Layout : LayoutDefinition
{
	// Token: 0x06000C8A RID: 3210 RVA: 0x0003DE2C File Offset: 0x0003C02C
	private void Awake()
	{
	}

	// Token: 0x06000C8B RID: 3211 RVA: 0x0003DE3C File Offset: 0x0003C03C
	public DeletePlayer_Layout()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x0400123C RID: 4668
	public static DeletePlayer_Layout Instance;

	// Token: 0x0400123D RID: 4669
	public StringButton_Layout Title;

	// Token: 0x0400123E RID: 4670
	public Panel_Layout Backing;

	// Token: 0x0400123F RID: 4671
	public Panel_Layout MenuDivider;

	// Token: 0x04001240 RID: 4672
	public StringButton_Layout DeletePrompt;

	// Token: 0x04001241 RID: 4673
	public TransactionButton_Layout Yes;

	// Token: 0x04001242 RID: 4674
	public TransactionButton_Layout No;
}
