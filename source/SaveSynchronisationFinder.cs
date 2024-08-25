using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Terraria.Net;

// Token: 0x020002C4 RID: 708
public static class SaveSynchronisationFinder
{
	// Token: 0x06001066 RID: 4198 RVA: 0x000505B4 File Offset: 0x0004E7B4
	private static void BroadcastRecieveThread()
	{
		if (!true)
		{
		}
		Thread.Sleep(1000);
		long num = 0L;
		string text;
		bool flag = TcpAddress.IsLocalHost(text);
		if ("" == null)
		{
		}
		Monitor.Enter("", num != 0L);
	}

	// Token: 0x06001067 RID: 4199 RVA: 0x000506CC File Offset: 0x0004E8CC
	public static void UpdateResults()
	{
		if (!true)
		{
		}
		DateTime now = DateTime.Now;
		TimeSpan timeSpan;
		double totalSeconds = timeSpan.TotalSeconds;
		DateTime now2 = DateTime.Now;
		TimeSpan timeSpan2;
		double totalSeconds2 = timeSpan2.TotalSeconds;
	}

	// Token: 0x06001068 RID: 4200 RVA: 0x00050734 File Offset: 0x0004E934
	public static void StartSearching()
	{
		if (!true)
		{
		}
		if (true)
		{
			if (!true)
			{
			}
			SaveSynchronisationFinder.StopSearching();
		}
		if (!true)
		{
		}
	}

	// Token: 0x06001069 RID: 4201 RVA: 0x00050754 File Offset: 0x0004E954
	public static void StopSearching()
	{
		if (!true)
		{
		}
		if (true)
		{
		}
	}

	// Token: 0x0600106A RID: 4202 RVA: 0x00050768 File Offset: 0x0004E968
	// Note: this type is marked as 'beforefieldinit'.
	static SaveSynchronisationFinder()
	{
	}

	// Token: 0x04001F44 RID: 8004
	private static List<SaveSynchronisationFinder.SearchServerResult> TempResults;

	// Token: 0x04001F45 RID: 8005
	private static DateTime LastListUpdate;

	// Token: 0x04001F46 RID: 8006
	public static List<SaveSynchronisationFinder.SearchServerResult> Results;

	// Token: 0x04001F47 RID: 8007
	private const SocketOptionName OnlyAllowIPv6 = SocketOptionName.IPv6Only;

	// Token: 0x04001F48 RID: 8008
	private static UdpClient broadcastPort;

	// Token: 0x04001F49 RID: 8009
	private static Thread broadcastThread;

	// Token: 0x020002C5 RID: 709
	public class SearchServerResult
	{
		// Token: 0x0600106B RID: 4203 RVA: 0x00050778 File Offset: 0x0004E978
		public SearchServerResult()
		{
		}

		// Token: 0x04001F4A RID: 8010
		public IPAddress ServerAddress;

		// Token: 0x04001F4B RID: 8011
		public string HostName;

		// Token: 0x04001F4C RID: 8012
		public DrPlatform.DrPlatformType Platform;

		// Token: 0x04001F4D RID: 8013
		public int PlayerFileCount;

		// Token: 0x04001F4E RID: 8014
		public int WorldFileCount;

		// Token: 0x04001F4F RID: 8015
		public DateTime LastRecieved;
	}
}
