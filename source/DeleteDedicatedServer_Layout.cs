using System;

// Token: 0x020001F4 RID: 500
public class DeleteDedicatedServer_Layout : LayoutDefinition
{
	// Token: 0x06000C88 RID: 3208 RVA: 0x0003DE04 File Offset: 0x0003C004
	private void Awake()
	{
	}

	// Token: 0x06000C89 RID: 3209 RVA: 0x0003DE14 File Offset: 0x0003C014
	public DeleteDedicatedServer_Layout()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x04001235 RID: 4661
	public static DeleteDedicatedServer_Layout Instance;

	// Token: 0x04001236 RID: 4662
	public StringButton_Layout Title;

	// Token: 0x04001237 RID: 4663
	public Panel_Layout Backing;

	// Token: 0x04001238 RID: 4664
	public Panel_Layout MenuDivider;

	// Token: 0x04001239 RID: 4665
	public StringButton_Layout DeletePrompt;

	// Token: 0x0400123A RID: 4666
	public TransactionButton_Layout Yes;

	// Token: 0x0400123B RID: 4667
	public TransactionButton_Layout No;
}
