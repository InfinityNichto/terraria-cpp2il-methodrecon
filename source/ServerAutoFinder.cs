using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;

// Token: 0x020002D0 RID: 720
public static class ServerAutoFinder
{
	// Token: 0x060010A8 RID: 4264 RVA: 0x00051C8C File Offset: 0x0004FE8C
	private static void BroadcastRecieveThread()
	{
		int num = 1;
		if (num == 0)
		{
		}
		Thread.Sleep(1000);
		if (num == 0)
		{
		}
	}

	// Token: 0x060010A9 RID: 4265 RVA: 0x00051D94 File Offset: 0x0004FF94
	private static void LookForFriendPlatformGames()
	{
		ThreadManager.CheckThreadTerminiate();
		if (PlatformUser.GetFriends() != null)
		{
			return;
		}
		MPSession[] array;
		if (array != null)
		{
			return;
		}
		if (false)
		{
			throw new OutOfMemoryException();
		}
		if (array != null)
		{
			return;
		}
		int num = 5000;
		Thread.Sleep(num);
	}

	// Token: 0x060010AA RID: 4266 RVA: 0x00051DF0 File Offset: 0x0004FFF0
	public static void UpdateResults()
	{
		if (!true)
		{
		}
		DateTime now = DateTime.Now;
		long num = 0L;
		TimeSpan timeSpan;
		double totalSeconds = timeSpan.TotalSeconds;
		Monitor.Enter(now, num != 0L);
		DateTime now2 = DateTime.Now;
		TimeSpan timeSpan2;
		double totalSeconds2 = timeSpan2.TotalSeconds;
	}

	// Token: 0x060010AB RID: 4267 RVA: 0x00051EA4 File Offset: 0x000500A4
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
			ServerAutoFinder.StopSearching();
		}
		DrPlatform.DrPlatformType currentPlatform = DrPlatform.CurrentPlatform;
		if (!true)
		{
		}
	}

	// Token: 0x060010AC RID: 4268 RVA: 0x00051ED0 File Offset: 0x000500D0
	public static void StopSearching()
	{
		int num = 1;
		if (num == 0)
		{
		}
		if (num == 0)
		{
		}
	}

	// Token: 0x060010AD RID: 4269 RVA: 0x00051EE8 File Offset: 0x000500E8
	// Note: this type is marked as 'beforefieldinit'.
	static ServerAutoFinder()
	{
	}

	// Token: 0x04001F81 RID: 8065
	private const SocketOptionName OnlyAllowIPv6 = SocketOptionName.IPv6Only;

	// Token: 0x04001F82 RID: 8066
	private static UdpClient broadcastPort;

	// Token: 0x04001F83 RID: 8067
	private static ManagedThread broadcastThread;

	// Token: 0x04001F84 RID: 8068
	private static ManagedThread platformFriendGamesThread;

	// Token: 0x04001F85 RID: 8069
	private static List<ServerAutoFinder.SearchServerResult> TempResults;

	// Token: 0x04001F86 RID: 8070
	private static List<ServerAutoFinder.SearchServerResult> FriendResults;

	// Token: 0x04001F87 RID: 8071
	private static DateTime LastListUpdate;

	// Token: 0x04001F88 RID: 8072
	public static List<ServerAutoFinder.SearchServerResult> Results;

	// Token: 0x020002D1 RID: 721
	public class SearchServerResult
	{
		// Token: 0x060010AE RID: 4270 RVA: 0x00051EF8 File Offset: 0x000500F8
		public SearchServerResult()
		{
		}

		// Token: 0x04001F89 RID: 8073
		public string WorldName;

		// Token: 0x04001F8A RID: 8074
		public IPAddress ServerAddress;

		// Token: 0x04001F8B RID: 8075
		public int ServerPort;

		// Token: 0x04001F8C RID: 8076
		public DateTime LastRecieved;

		// Token: 0x04001F8D RID: 8077
		public ushort WorldXSize;

		// Token: 0x04001F8E RID: 8078
		public int NumberOfPlayers;

		// Token: 0x04001F8F RID: 8079
		public int MaxPlayers;

		// Token: 0x04001F90 RID: 8080
		public short GameMode;

		// Token: 0x04001F91 RID: 8081
		public bool Corruption;

		// Token: 0x04001F92 RID: 8082
		public bool HardMode;

		// Token: 0x04001F93 RID: 8083
		public string HostName;

		// Token: 0x04001F94 RID: 8084
		public MPSession SourceSession;
	}
}
