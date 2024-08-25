using System;

// Token: 0x0200020E RID: 526
public class QuitConfirm_Layout : LayoutDefinition
{
	// Token: 0x06000CBA RID: 3258 RVA: 0x0003E240 File Offset: 0x0003C440
	private void Awake()
	{
	}

	// Token: 0x06000CBB RID: 3259 RVA: 0x0003E250 File Offset: 0x0003C450
	public QuitConfirm_Layout()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x04001397 RID: 5015
	public static QuitConfirm_Layout Instance;

	// Token: 0x04001398 RID: 5016
	public StringButton_Layout Title;

	// Token: 0x04001399 RID: 5017
	public Panel_Layout Backing;

	// Token: 0x0400139A RID: 5018
	public Panel_Layout MenuDivider;

	// Token: 0x0400139B RID: 5019
	public StringButton_Layout Status;

	// Token: 0x0400139C RID: 5020
	public TransactionButton_Layout Quit;

	// Token: 0x0400139D RID: 5021
	public TransactionButton_Layout Back;
}
