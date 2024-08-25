using System;

// Token: 0x020001F6 RID: 502
public class DeleteWorld_Layout : LayoutDefinition
{
	// Token: 0x06000C8C RID: 3212 RVA: 0x0003DE54 File Offset: 0x0003C054
	private void Awake()
	{
	}

	// Token: 0x06000C8D RID: 3213 RVA: 0x0003DE64 File Offset: 0x0003C064
	public DeleteWorld_Layout()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x04001243 RID: 4675
	public static DeleteWorld_Layout Instance;

	// Token: 0x04001244 RID: 4676
	public StringButton_Layout Title;

	// Token: 0x04001245 RID: 4677
	public Panel_Layout Backing;

	// Token: 0x04001246 RID: 4678
	public Panel_Layout MenuDivider;

	// Token: 0x04001247 RID: 4679
	public StringButton_Layout DeletePrompt;

	// Token: 0x04001248 RID: 4680
	public TransactionButton_Layout Yes;

	// Token: 0x04001249 RID: 4681
	public TransactionButton_Layout No;
}
