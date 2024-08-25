using System;

// Token: 0x0200019F RID: 415
public class ControllerHardwareProfile_Layout : LayoutDefinition
{
	// Token: 0x06000B6A RID: 2922 RVA: 0x000396F4 File Offset: 0x000378F4
	private void Awake()
	{
	}

	// Token: 0x06000B6B RID: 2923 RVA: 0x00039704 File Offset: 0x00037904
	public ControllerHardwareProfile_Layout()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x04000D16 RID: 3350
	public static ControllerHardwareProfile_Layout Instance;

	// Token: 0x04000D17 RID: 3351
	public StringButton_Layout Title;

	// Token: 0x04000D18 RID: 3352
	public Panel_Layout Backing;

	// Token: 0x04000D19 RID: 3353
	public DraggableItemGrid_Layout OptionGrid;

	// Token: 0x04000D1A RID: 3354
	public TransactionButton_Layout Close;

	// Token: 0x04000D1B RID: 3355
	public TransactionButton_Layout ResetSettings;

	// Token: 0x04000D1C RID: 3356
	public TransactionButton_Layout Clear;

	// Token: 0x04000D1D RID: 3357
	public TransactionButton_Layout EditMapping;

	// Token: 0x04000D1E RID: 3358
	public ControllerProfileMappingEntry_Layout PulldownTemplate;
}
