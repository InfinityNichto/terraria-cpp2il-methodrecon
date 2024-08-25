using System;
using System.Net;

// Token: 0x020002B6 RID: 694
public class MPSessionMetaData
{
	// Token: 0x06001016 RID: 4118 RVA: 0x0004F3A8 File Offset: 0x0004D5A8
	public MPSessionMetaData()
	{
	}

	// Token: 0x04001D93 RID: 7571
	public string WorldName;

	// Token: 0x04001D94 RID: 7572
	public IPAddress ServerAddress;

	// Token: 0x04001D95 RID: 7573
	public int ServerPort;

	// Token: 0x04001D96 RID: 7574
	public ushort WorldXSize;

	// Token: 0x04001D97 RID: 7575
	public int NumberOfPlayers;

	// Token: 0x04001D98 RID: 7576
	public int MaxPlayers;

	// Token: 0x04001D99 RID: 7577
	public short GameMode;

	// Token: 0x04001D9A RID: 7578
	public bool Corruption;

	// Token: 0x04001D9B RID: 7579
	public bool HardMode;

	// Token: 0x04001D9C RID: 7580
	public string HostName;

	// Token: 0x04001D9D RID: 7581
	public bool InviteOnly = true;
}
