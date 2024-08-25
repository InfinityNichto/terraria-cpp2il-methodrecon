using System;

// Token: 0x02000209 RID: 521
public class PlayerAndGameModeMismatch_Layout : LayoutDefinition
{
	// Token: 0x06000CB0 RID: 3248 RVA: 0x0003E13C File Offset: 0x0003C33C
	private void Awake()
	{
	}

	// Token: 0x06000CB1 RID: 3249 RVA: 0x0003E14C File Offset: 0x0003C34C
	public PlayerAndGameModeMismatch_Layout()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x04001327 RID: 4903
	public static PlayerAndGameModeMismatch_Layout Instance;

	// Token: 0x04001328 RID: 4904
	public StringButton_Layout Title;

	// Token: 0x04001329 RID: 4905
	public Panel_Layout Backing;

	// Token: 0x0400132A RID: 4906
	public Panel_Layout MenuDivider;

	// Token: 0x0400132B RID: 4907
	public StringButton_Layout Status;

	// Token: 0x0400132C RID: 4908
	public TransactionButton_Layout Back;

	// Token: 0x0400132D RID: 4909
	public String_Layout GameTip;
}
