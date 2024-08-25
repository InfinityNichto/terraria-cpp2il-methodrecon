using System;

// Token: 0x020001FC RID: 508
[Serializable]
public class WorldNoBackup
{
	// Token: 0x06000C98 RID: 3224 RVA: 0x0003DF40 File Offset: 0x0003C140
	private void Awake()
	{
	}

	// Token: 0x06000C99 RID: 3225 RVA: 0x0003DF50 File Offset: 0x0003C150
	public WorldNoBackup()
	{
	}

	// Token: 0x0400129C RID: 4764
	public static WorldNoBackup Instance;

	// Token: 0x0400129D RID: 4765
	public StringButton_Layout Status;

	// Token: 0x0400129E RID: 4766
	public StringButton_Layout Description;

	// Token: 0x0400129F RID: 4767
	public TransactionButton_Layout Back;
}
