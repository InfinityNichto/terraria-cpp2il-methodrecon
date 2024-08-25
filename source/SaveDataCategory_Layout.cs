using System;

// Token: 0x0200023A RID: 570
public class SaveDataCategory_Layout : LayoutDefinition
{
	// Token: 0x06000D11 RID: 3345 RVA: 0x0003EB5C File Offset: 0x0003CD5C
	private void Awake()
	{
	}

	// Token: 0x06000D12 RID: 3346 RVA: 0x0003EB6C File Offset: 0x0003CD6C
	public SaveDataCategory_Layout()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x0400176D RID: 5997
	public static SaveDataCategory_Layout Instance;

	// Token: 0x0400176E RID: 5998
	public Panel_Layout Backing;

	// Token: 0x0400176F RID: 5999
	public TransactionButton_Layout LocalPlayers;

	// Token: 0x04001770 RID: 6000
	public TransactionButton_Layout RemotePlayers;

	// Token: 0x04001771 RID: 6001
	public TransactionButton_Layout LocalWorlds;

	// Token: 0x04001772 RID: 6002
	public TransactionButton_Layout RemoteWorlds;

	// Token: 0x04001773 RID: 6003
	public TransactionButton_Layout Upload;

	// Token: 0x04001774 RID: 6004
	public TransactionButton_Layout Download;

	// Token: 0x04001775 RID: 6005
	public TransactionButton_Layout UploadSettings;

	// Token: 0x04001776 RID: 6006
	public TransactionButton_Layout DownloadSettings;
}
