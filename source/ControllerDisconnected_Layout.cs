using System;

// Token: 0x0200019E RID: 414
public class ControllerDisconnected_Layout : LayoutDefinition
{
	// Token: 0x06000B68 RID: 2920 RVA: 0x000396CC File Offset: 0x000378CC
	private void Awake()
	{
	}

	// Token: 0x06000B69 RID: 2921 RVA: 0x000396DC File Offset: 0x000378DC
	public ControllerDisconnected_Layout()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x04000D0D RID: 3341
	public static ControllerDisconnected_Layout Instance;

	// Token: 0x04000D0E RID: 3342
	public Panel_Layout Greyout;

	// Token: 0x04000D0F RID: 3343
	public Panel_Layout Backing;

	// Token: 0x04000D10 RID: 3344
	public StringButton_Layout Status;

	// Token: 0x04000D11 RID: 3345
	public Button_Layout SearchingIcon;

	// Token: 0x04000D12 RID: 3346
	public Panel_Layout SwitchBacking;

	// Token: 0x04000D13 RID: 3347
	public String_Layout SwitchStatus;

	// Token: 0x04000D14 RID: 3348
	public TransactionButton_Layout SwitchConfigure;

	// Token: 0x04000D15 RID: 3349
	public Button_Layout SwitchSearchingIcon;
}
