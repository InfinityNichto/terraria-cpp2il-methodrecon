using System;

// Token: 0x0200022E RID: 558
public class PickupContextMenu_Layout : LayoutDefinition
{
	// Token: 0x06000CF4 RID: 3316 RVA: 0x0003E898 File Offset: 0x0003CA98
	private void Awake()
	{
	}

	// Token: 0x06000CF5 RID: 3317 RVA: 0x0003E8A8 File Offset: 0x0003CAA8
	public PickupContextMenu_Layout()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x04001679 RID: 5753
	public static PickupContextMenu_Layout Instance;

	// Token: 0x0400167A RID: 5754
	public TransactionButton_Layout LeftThrow;

	// Token: 0x0400167B RID: 5755
	public TransactionButton_Layout LeftTrash;

	// Token: 0x0400167C RID: 5756
	public TransactionButton_Layout LeftDeposit;

	// Token: 0x0400167D RID: 5757
	public TransactionButton_Layout RightThrow;

	// Token: 0x0400167E RID: 5758
	public TransactionButton_Layout RightTrash;

	// Token: 0x0400167F RID: 5759
	public TransactionButton_Layout RightDeposit;
}
