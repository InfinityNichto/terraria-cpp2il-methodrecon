using System;

// Token: 0x020001FF RID: 511
public class LowMemoryPopup_Layout : LayoutDefinition
{
	// Token: 0x06000C9E RID: 3230 RVA: 0x0003DFD4 File Offset: 0x0003C1D4
	private void Awake()
	{
	}

	// Token: 0x06000C9F RID: 3231 RVA: 0x0003DFE4 File Offset: 0x0003C1E4
	public LowMemoryPopup_Layout()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x040012A9 RID: 4777
	public static LowMemoryPopup_Layout Instance;

	// Token: 0x040012AA RID: 4778
	public StringButton_Layout Status;

	// Token: 0x040012AB RID: 4779
	public TransactionButton_Layout Cancel;

	// Token: 0x040012AC RID: 4780
	public TransactionButton_Layout Continue;
}
