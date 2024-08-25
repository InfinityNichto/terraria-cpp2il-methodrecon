using System;

// Token: 0x02000231 RID: 561
public class PurchaseChecker_Layout : LayoutDefinition
{
	// Token: 0x06000CFA RID: 3322 RVA: 0x0003E910 File Offset: 0x0003CB10
	private void Awake()
	{
	}

	// Token: 0x06000CFB RID: 3323 RVA: 0x0003E920 File Offset: 0x0003CB20
	public PurchaseChecker_Layout()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x04001697 RID: 5783
	public static PurchaseChecker_Layout Instance;

	// Token: 0x04001698 RID: 5784
	public String_Layout Information;

	// Token: 0x04001699 RID: 5785
	public TransactionButton_Layout Retry;

	// Token: 0x0400169A RID: 5786
	public TransactionButton_Layout Store;

	// Token: 0x0400169B RID: 5787
	public Button_Layout SearchingIcon;
}
