using System;

// Token: 0x020001FE RID: 510
public class LowDiskSpacePopup_Layout : LayoutDefinition
{
	// Token: 0x06000C9C RID: 3228 RVA: 0x0003DFAC File Offset: 0x0003C1AC
	private void Awake()
	{
	}

	// Token: 0x06000C9D RID: 3229 RVA: 0x0003DFBC File Offset: 0x0003C1BC
	public LowDiskSpacePopup_Layout()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x040012A5 RID: 4773
	public static LowDiskSpacePopup_Layout Instance;

	// Token: 0x040012A6 RID: 4774
	public StringButton_Layout Status;

	// Token: 0x040012A7 RID: 4775
	public TransactionButton_Layout Cancel;

	// Token: 0x040012A8 RID: 4776
	public TransactionButton_Layout Continue;
}
