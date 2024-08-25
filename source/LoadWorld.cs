using System;

// Token: 0x020001FB RID: 507
[Serializable]
public class LoadWorld
{
	// Token: 0x06000C96 RID: 3222 RVA: 0x0003DF1C File Offset: 0x0003C11C
	private void Awake()
	{
	}

	// Token: 0x06000C97 RID: 3223 RVA: 0x0003DF2C File Offset: 0x0003C12C
	public LoadWorld()
	{
	}

	// Token: 0x04001298 RID: 4760
	public static LoadWorld Instance;

	// Token: 0x04001299 RID: 4761
	public StringButton_Layout Status;

	// Token: 0x0400129A RID: 4762
	public TransactionButton_Layout Load;

	// Token: 0x0400129B RID: 4763
	public TransactionButton_Layout Back;
}
