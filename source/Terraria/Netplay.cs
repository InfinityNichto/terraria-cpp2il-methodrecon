using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Content;
using Terraria.Localization;
using Terraria.Net;
using Terraria.UI;
using UnityEngine;

namespace Terraria
{
	// Token: 0x02000402 RID: 1026
	public class Netplay
	{
		// Token: 0x1400002A RID: 42
		// (add) Token: 0x060020EC RID: 8428 RVA: 0x000D1C70 File Offset: 0x000CFE70
		// (remove) Token: 0x060020ED RID: 8429 RVA: 0x000D1C8C File Offset: 0x000CFE8C
		public static event Action OnDisconnect
		{
			[CompilerGenerated]
			add
			{
				if (!true)
				{
				}
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (!true)
				{
				}
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
		}

		// Token: 0x060020EE RID: 8430 RVA: 0x000D1CA8 File Offset: 0x000CFEA8
		private static void OpenPort()
		{
			if (!true)
			{
			}
			string localIPAddress = Netplay.GetLocalIPAddress();
		}

		// Token: 0x060020EF RID: 8431 RVA: 0x000D1CC0 File Offset: 0x000CFEC0
		public static void closePort()
		{
		}

		// Token: 0x060020F0 RID: 8432 RVA: 0x000D1CD0 File Offset: 0x000CFED0
		public static string GetLocalIPAddress()
		{
			int num = 1;
			if (num == 0)
			{
			}
			string hostName = Dns.GetHostName();
			if (num == 0)
			{
			}
			ushort[] numbers = Dns.GetHostEntry(hostName).addressList._numbers;
			return "";
		}

		// Token: 0x060020F1 RID: 8433 RVA: 0x000D1D18 File Offset: 0x000CFF18
		public static void ResetNetDiag()
		{
			if (!true)
			{
			}
			INetDiagnosticsUI activeNetDiagnosticsUI = Main.ActiveNetDiagnosticsUI;
		}

		// Token: 0x060020F2 RID: 8434 RVA: 0x000D1D34 File Offset: 0x000CFF34
		public static void ResetSections()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x060020F3 RID: 8435 RVA: 0x000D1D50 File Offset: 0x000CFF50
		public static void AddBan(int plr)
		{
			if (!true)
			{
			}
			if ("//" != null)
			{
			}
		}

		// Token: 0x060020F4 RID: 8436 RVA: 0x000D1D94 File Offset: 0x000CFF94
		public static bool IsBanned(RemoteAddress address)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060020F5 RID: 8437 RVA: 0x000D1DCC File Offset: 0x000CFFCC
		public static void AddCurrentServerToRecentList()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
				if (num == 0)
				{
				}
				string text;
				string text2;
				bool flag = text == text2;
				return;
			}
		}

		// Token: 0x060020F6 RID: 8438 RVA: 0x000D1E58 File Offset: 0x000D0058
		public static void deleteDedicatedServer(string ip, int port)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				return;
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			string text = ip.ToLower();
			string text2;
			bool flag = text2 == text;
			if ((text2 == null || text2 != null) && (text2 == null || text2 != null))
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060020F7 RID: 8439 RVA: 0x000D1EB0 File Offset: 0x000D00B0
		public static void SocialClientLoop(object threadContext)
		{
		}

		// Token: 0x060020F8 RID: 8440 RVA: 0x000D1EC0 File Offset: 0x000D00C0
		public static void TcpLocalClientLoop(object threadContext)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Main.menuMode = 14;
			Thread.Sleep(200);
		}

		// Token: 0x060020F9 RID: 8441 RVA: 0x000D1F6C File Offset: 0x000D016C
		public static void TcpClientLoop(object threadContext)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Main.menuMode = 14;
			if (num == 0)
			{
			}
			bool asyncLoadStillRequired = ContentManager.AsyncLoadStillRequired;
			Thread.Sleep(20);
		}

		// Token: 0x060020FA RID: 8442 RVA: 0x000D20E0 File Offset: 0x000D02E0
		private static void ClientServerLoopSetup(RemoteAddress address)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Netplay.ResetNetDiag();
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			int myPlayer2 = Main.myPlayer;
			int myPlayer3 = Main.myPlayer;
			int myPlayer4 = Main.myPlayer;
		}

		// Token: 0x060020FB RID: 8443 RVA: 0x000D2144 File Offset: 0x000D0344
		private static void ClientLoopSetup(RemoteAddress address)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Netplay.ResetNetDiag();
			int myPlayer = Main.myPlayer;
			int myPlayer2 = Main.myPlayer;
			int myPlayer3 = Main.myPlayer;
			int myPlayer4 = Main.myPlayer;
		}

		// Token: 0x060020FC RID: 8444 RVA: 0x000D21D8 File Offset: 0x000D03D8
		public static void ClientUpdateFrame()
		{
			if (!true)
			{
			}
		}

		// Token: 0x060020FD RID: 8445 RVA: 0x000D21F8 File Offset: 0x000D03F8
		public static void ServerUpdateFrame()
		{
			int num = 1;
			if (num == 0)
			{
			}
			while (num != 0)
			{
			}
			if (num == 0)
			{
			}
			string text;
			bool flag = TcpAddress.IsLocalHost(text);
			NetworkText networkText;
			NetMessage.BootPlayer(43143168, networkText);
		}

		// Token: 0x060020FE RID: 8446 RVA: 0x000D2248 File Offset: 0x000D0448
		public static void UpdateClientNet()
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool netClientOnly = Main.NetClientOnly;
			if (num == 0)
			{
			}
			Netplay.ClientUpdateFrame();
			if (num == 0)
			{
			}
			if (num != 0)
			{
				return;
			}
			Netplay.ClientLoopFrameUpdate();
		}

		// Token: 0x060020FF RID: 8447 RVA: 0x000D2284 File Offset: 0x000D0484
		public static void ClientLoopFrameUpdate()
		{
			if (!true)
			{
			}
			DateTime now = DateTime.Now;
			string textValue = Language.GetTextValue("Net.FoundServer");
			if ("Net.FoundServer" == null)
			{
			}
			if ("Net.FoundServer" == null)
			{
			}
			int num = 1;
			if ("Net.FoundServer" == null)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06002100 RID: 8448 RVA: 0x000D23FC File Offset: 0x000D05FC
		private static void InnerClientLoop()
		{
			if (!true)
			{
			}
			Thread.Sleep(20);
		}

		// Token: 0x06002101 RID: 8449 RVA: 0x000021DB File Offset: 0x000003DB
		private static int FindNextOpenClientSlot()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002102 RID: 8450 RVA: 0x000D24F0 File Offset: 0x000D06F0
		private static void OnConnectionAccepted(int clientId)
		{
			if (!true)
			{
			}
			string text;
			Debug.Log(text + " is connecting...");
		}

		// Token: 0x06002103 RID: 8451 RVA: 0x000D2514 File Offset: 0x000D0714
		private static bool StartListening()
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06002104 RID: 8452 RVA: 0x000D2528 File Offset: 0x000D0728
		private static void StopListening()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002105 RID: 8453 RVA: 0x000D2538 File Offset: 0x000D0738
		private static void BroadcastThread()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Debug.LogError("World name is bad");
			if ("World name is bad" == null)
			{
			}
			DrPlatform.DrPlatformType currentPlatform = DrPlatform.CurrentPlatform;
		}

		// Token: 0x06002106 RID: 8454 RVA: 0x000D2678 File Offset: 0x000D0878
		public static void StartBroadCasting()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				if (num == 0)
				{
				}
				Netplay.StopBroadCasting();
			}
			DrPlatform.DrPlatformType currentPlatform = DrPlatform.CurrentPlatform;
		}

		// Token: 0x06002107 RID: 8455 RVA: 0x000D26C0 File Offset: 0x000D08C0
		public static void StopBroadCasting()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x06002108 RID: 8456 RVA: 0x000D26D4 File Offset: 0x000D08D4
		public static void ServerLoopUpdateFrame()
		{
			if (!true)
			{
			}
			NetMessage.SyncDisconnectedPlayer(0);
		}

		// Token: 0x06002109 RID: 8457 RVA: 0x000D2800 File Offset: 0x000D0A00
		public static void ServerLoop(object threadContext)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Netplay.ResetNetDiag();
			if (num == 0)
			{
			}
			long ticks = DateTime.Now.Ticks;
			if (3 == 0)
			{
			}
			bool flag = Netplay.StartListening();
			Main.menuMode = 14;
			string textValue = Language.GetTextValue("Mobile.FailedToCreateSession");
			int num2 = 1;
			Debug.LogError("   Exception normal: Tried to run two servers on the same PC");
			PlatformUser currentUser = PlatformUser.CurrentUser;
			if (num2 != 0)
			{
			}
		}

		// Token: 0x0600210A RID: 8458 RVA: 0x000D293C File Offset: 0x000D0B3C
		public static void StartTcpClient(bool connectingToLocalServer)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x0600210B RID: 8459 RVA: 0x000D2954 File Offset: 0x000D0B54
		public static void StartServer()
		{
		}

		// Token: 0x0600210C RID: 8460 RVA: 0x000D2964 File Offset: 0x000D0B64
		public static bool SetRemoteIP(string remoteAddress)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x0600210D RID: 8461 RVA: 0x000D2980 File Offset: 0x000D0B80
		public static void Initialize()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x0600210E RID: 8462 RVA: 0x000021DB File Offset: 0x000003DB
		public static int GetSectionX(int x)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600210F RID: 8463 RVA: 0x000021DB File Offset: 0x000003DB
		public static int GetSectionY(int y)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002110 RID: 8464 RVA: 0x000D29A0 File Offset: 0x000D0BA0
		public Netplay()
		{
		}

		// Token: 0x06002111 RID: 8465 RVA: 0x000D29B4 File Offset: 0x000D0BB4
		// Note: this type is marked as 'beforefieldinit'.
		static Netplay()
		{
		}

		// Token: 0x04002D00 RID: 11520
		public static string BanFilePath;

		// Token: 0x04002D01 RID: 11521
		public static string ServerPassword;

		// Token: 0x04002D02 RID: 11522
		public static RemoteClient[] Clients;

		// Token: 0x04002D03 RID: 11523
		public static RemoteConnection Connection;

		// Token: 0x04002D04 RID: 11524
		public static RemoteServer Server;

		// Token: 0x04002D05 RID: 11525
		public static IPAddress ServerIP;

		// Token: 0x04002D06 RID: 11526
		public static string ServerIPText;

		// Token: 0x04002D07 RID: 11527
		public static int ListenPort;

		// Token: 0x04002D08 RID: 11528
		public static bool IsServerRunning;

		// Token: 0x04002D09 RID: 11529
		public static bool IsListening;

		// Token: 0x04002D0A RID: 11530
		public static bool UseUPNP;

		// Token: 0x04002D0B RID: 11531
		public static bool LostConnection;

		// Token: 0x04002D0C RID: 11532
		public static bool Disconnect;

		// Token: 0x04002D0D RID: 11533
		public static bool SpamCheck;

		// Token: 0x04002D0E RID: 11534
		public static bool HasClients;

		// Token: 0x04002D0F RID: 11535
		public static string portForwardIP;

		// Token: 0x04002D10 RID: 11536
		public static int portForwardPort;

		// Token: 0x04002D11 RID: 11537
		public static bool portForwardOpen;

		// Token: 0x04002D12 RID: 11538
		private static int oldState;

		// Token: 0x04002D13 RID: 11539
		public static DateTime LastClientUpdateTime;

		// Token: 0x04002D14 RID: 11540
		public static bool clientLoopRunning;

		// Token: 0x04002D15 RID: 11541
		private static UdpClient BroadcastClient;

		// Token: 0x04002D16 RID: 11542
		private static ManagedThread broadcastThread;

		// Token: 0x04002D17 RID: 11543
		public const int MaxConnections = 256;

		// Token: 0x04002D18 RID: 11544
		public const int NetBufferSize = 32768;

		// Token: 0x04002D19 RID: 11545
		[CompilerGenerated]
		private static Action OnDisconnect;

		// Token: 0x04002D1A RID: 11546
		public static AutoResetEvent disconnectEvent;
	}
}
