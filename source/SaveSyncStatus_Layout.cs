using System;

// Token: 0x0200023E RID: 574
public class SaveSyncStatus_Layout : LayoutDefinition
{
	// Token: 0x06000D19 RID: 3353 RVA: 0x0003EBFC File Offset: 0x0003CDFC
	private void Awake()
	{
	}

	// Token: 0x06000D1A RID: 3354 RVA: 0x0003EC0C File Offset: 0x0003CE0C
	public SaveSyncStatus_Layout()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x040017D6 RID: 6102
	public static SaveSyncStatus_Layout Instance;

	// Token: 0x040017D7 RID: 6103
	public StringButton_Layout Status;

	// Token: 0x040017D8 RID: 6104
	public TransactionButton_Layout Cancel;
}
