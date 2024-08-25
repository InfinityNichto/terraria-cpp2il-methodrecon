using System;

// Token: 0x020001F7 RID: 503
public class ErrorScreen_Layout : LayoutDefinition
{
	// Token: 0x06000C8E RID: 3214 RVA: 0x0003DE7C File Offset: 0x0003C07C
	private void Awake()
	{
	}

	// Token: 0x06000C8F RID: 3215 RVA: 0x0003DE8C File Offset: 0x0003C08C
	public ErrorScreen_Layout()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x0400124A RID: 4682
	public static ErrorScreen_Layout Instance;

	// Token: 0x0400124B RID: 4683
	public StringButton_Layout Status;

	// Token: 0x0400124C RID: 4684
	public TransactionButton_Layout Back;
}
