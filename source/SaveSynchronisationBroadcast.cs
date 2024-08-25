using System;
using System.Net.Sockets;

// Token: 0x020002C2 RID: 706
public static class SaveSynchronisationBroadcast
{
	// Token: 0x0600105C RID: 4188 RVA: 0x00050310 File Offset: 0x0004E510
	private static void BroadcastThread()
	{
		DrPlatform.DrPlatformType currentPlatform = DrPlatform.CurrentPlatform;
	}

	// Token: 0x0600105D RID: 4189 RVA: 0x000503DC File Offset: 0x0004E5DC
	public static void StartBroadCasting()
	{
		SaveSynchronisationBroadcast.StopBroadCasting();
	}

	// Token: 0x0600105E RID: 4190 RVA: 0x000503F0 File Offset: 0x0004E5F0
	public static void StopBroadCasting()
	{
	}

	// Token: 0x04001F40 RID: 8000
	private static UdpClient BroadcastClient;

	// Token: 0x04001F41 RID: 8001
	private static ManagedThread broadcastThread;
}
