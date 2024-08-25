using System;

// Token: 0x0200020F RID: 527
public class ResetSettings_Layout : LayoutDefinition
{
	// Token: 0x06000CBC RID: 3260 RVA: 0x0003E268 File Offset: 0x0003C468
	private void Awake()
	{
	}

	// Token: 0x06000CBD RID: 3261 RVA: 0x0003E278 File Offset: 0x0003C478
	public ResetSettings_Layout()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x0400139E RID: 5022
	public static ResetSettings_Layout Instance;

	// Token: 0x0400139F RID: 5023
	public StringButton_Layout Title;

	// Token: 0x040013A0 RID: 5024
	public Panel_Layout Backing;

	// Token: 0x040013A1 RID: 5025
	public Panel_Layout MenuDivider;

	// Token: 0x040013A2 RID: 5026
	public StringButton_Layout DeletePrompt;

	// Token: 0x040013A3 RID: 5027
	public TransactionButton_Layout Yes;

	// Token: 0x040013A4 RID: 5028
	public TransactionButton_Layout No;
}
