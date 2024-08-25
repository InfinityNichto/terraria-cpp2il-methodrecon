using System;

// Token: 0x02000200 RID: 512
public class LowMemorySettings_Layout : LayoutDefinition
{
	// Token: 0x06000CA0 RID: 3232 RVA: 0x0003DFFC File Offset: 0x0003C1FC
	private void Awake()
	{
	}

	// Token: 0x06000CA1 RID: 3233 RVA: 0x0003E00C File Offset: 0x0003C20C
	public LowMemorySettings_Layout()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x040012AD RID: 4781
	public static LowMemorySettings_Layout Instance;

	// Token: 0x040012AE RID: 4782
	public StringButton_Layout Status;

	// Token: 0x040012AF RID: 4783
	public TransactionButton_Layout Cancel;

	// Token: 0x040012B0 RID: 4784
	public TransactionButton_Layout Continue;
}
