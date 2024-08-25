using System;

// Token: 0x020001C3 RID: 451
[Serializable]
public class TransactionButtonStyle_Layout
{
	// Token: 0x06000BE5 RID: 3045 RVA: 0x0003B934 File Offset: 0x00039B34
	public TransactionButtonStyle_Layout()
	{
	}

	// Token: 0x06000BE6 RID: 3046 RVA: 0x0003B948 File Offset: 0x00039B48
	public TransactionButtonStyle_Layout(string defaultSyleId)
	{
		this.StyleId = defaultSyleId;
	}

	// Token: 0x04000F3D RID: 3901
	public string StyleId;
}
