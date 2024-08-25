using System;

// Token: 0x02000204 RID: 516
public class MultiplayerJoin_Layout : LayoutDefinition
{
	// Token: 0x06000CA7 RID: 3239 RVA: 0x0003E088 File Offset: 0x0003C288
	private void Awake()
	{
	}

	// Token: 0x06000CA8 RID: 3240 RVA: 0x0003E098 File Offset: 0x0003C298
	public MultiplayerJoin_Layout()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x040012E0 RID: 4832
	public static MultiplayerJoin_Layout Instance;

	// Token: 0x040012E1 RID: 4833
	public Panel_Layout Backing;

	// Token: 0x040012E2 RID: 4834
	public Panel_Layout Greyout;

	// Token: 0x040012E3 RID: 4835
	public StringButton_Layout Title;

	// Token: 0x040012E4 RID: 4836
	public Panel_Layout MenuDivider;

	// Token: 0x040012E5 RID: 4837
	public String_Layout ServerIPTitle;

	// Token: 0x040012E6 RID: 4838
	public String_Layout ServerIP;

	// Token: 0x040012E7 RID: 4839
	public String_Layout ServerIPEdit;

	// Token: 0x040012E8 RID: 4840
	public String_Layout ServerPortTitle;

	// Token: 0x040012E9 RID: 4841
	public String_Layout ServerPort;

	// Token: 0x040012EA RID: 4842
	public String_Layout ServerPortEdit;

	// Token: 0x040012EB RID: 4843
	public TransactionButton_Layout ServerIPButton;

	// Token: 0x040012EC RID: 4844
	public TransactionButton_Layout ServerPortButton;

	// Token: 0x040012ED RID: 4845
	public TransactionButton_Layout Back;

	// Token: 0x040012EE RID: 4846
	public TransactionButton_Layout Join;
}
