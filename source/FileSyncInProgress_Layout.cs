using System;

// Token: 0x020001F8 RID: 504
public class FileSyncInProgress_Layout : LayoutDefinition
{
	// Token: 0x06000C90 RID: 3216 RVA: 0x0003DEA4 File Offset: 0x0003C0A4
	private void Awake()
	{
	}

	// Token: 0x06000C91 RID: 3217 RVA: 0x0003DEB4 File Offset: 0x0003C0B4
	public FileSyncInProgress_Layout()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x0400124D RID: 4685
	public static FileSyncInProgress_Layout Instance;

	// Token: 0x0400124E RID: 4686
	public Panel_Layout Greyout;

	// Token: 0x0400124F RID: 4687
	public Panel_Layout Backing;

	// Token: 0x04001250 RID: 4688
	public StringButton_Layout Status;

	// Token: 0x04001251 RID: 4689
	public Button_Layout SearchingIcon;
}
