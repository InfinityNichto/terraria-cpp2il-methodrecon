using System;

// Token: 0x02000208 RID: 520
public class NetPlayStatusMenu_Layout : LayoutDefinition
{
	// Token: 0x06000CAE RID: 3246 RVA: 0x0003E114 File Offset: 0x0003C314
	private void Awake()
	{
	}

	// Token: 0x06000CAF RID: 3247 RVA: 0x0003E124 File Offset: 0x0003C324
	public NetPlayStatusMenu_Layout()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x04001322 RID: 4898
	public static NetPlayStatusMenu_Layout Instance;

	// Token: 0x04001323 RID: 4899
	public StringButton_Layout Status;

	// Token: 0x04001324 RID: 4900
	public StringButton_Layout ServerStatus;

	// Token: 0x04001325 RID: 4901
	public Button_Layout SearchingIcon;

	// Token: 0x04001326 RID: 4902
	public TransactionButton_Layout Cancel;
}
