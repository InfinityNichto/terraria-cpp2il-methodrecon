using System;
using System.Collections.Concurrent;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;

namespace Telepathy
{
	// Token: 0x02000310 RID: 784
	public class Client : Common
	{
		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06001258 RID: 4696 RVA: 0x00059424 File Offset: 0x00057624
		public bool Connected
		{
			get
			{
				TcpClient tcpClient = this.client;
				if (tcpClient == null)
				{
					return;
				}
				Socket clientSocket = tcpClient.m_ClientSocket;
				if (clientSocket != null)
				{
					bool is_connected = clientSocket.is_connected;
					return;
				}
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06001259 RID: 4697 RVA: 0x00059450 File Offset: 0x00057650
		public bool Connecting
		{
			get
			{
				return this._Connecting;
			}
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x00059464 File Offset: 0x00057664
		private bool GetIPV6AddressFromIPV4(string hostname, [Out] string ipv6Address)
		{
			IPHostEntry hostEntry = Dns.GetHostEntry("re-logic.com");
			IPAddress[] addressList2;
			if (hostEntry != null)
			{
				IPAddress[] addressList = hostEntry.addressList;
				if (addressList != null)
				{
					ushort[] numbers = addressList._numbers;
					string toString = addressList._toString;
					addressList2 = hostEntry.addressList;
				}
			}
			string toString2 = addressList2._toString;
			long num = 0L;
			int num2 = toString2.IndexOf("::");
			long num3 = 0L;
			string text = toString2.Substring((int)num3, (int)num);
			string text2;
			string text3;
			string text4;
			string text5;
			if ((text == null || text != null) && (text2 == null || text2 != null) && (text3 == null || text3 != null) && (":" == null || ":" != null) && (text4 == null || text4 != null) && (text5 == null || text5 != null))
			{
				string text7;
				string text6 = text7.ToLower();
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x0005952C File Offset: 0x0005772C
		private void ReceiveThreadFunction(string ip, int port)
		{
			TcpClient tcpClient = this.client;
			if (tcpClient != null)
			{
				tcpClient.Connect(ip, port);
				if (this.client != null)
				{
					TcpClient tcpClient2 = this.client;
					bool noDelay = this.NoDelay;
					tcpClient2.NoDelay = noDelay;
					TcpClient tcpClient3 = this.client;
					int sendTimeout = this.SendTimeout;
					tcpClient3.SendTimeout = sendTimeout;
					this.sendThread.Start();
					TcpClient tcpClient4 = this.client;
					ConcurrentQueue<Message> receiveQueue = this.receiveQueue;
					int maxMessageSize = this.MaxMessageSize;
					Common.ReceiveLoop(0, tcpClient4, receiveQueue, maxMessageSize);
					Thread thread = this.sendThread;
					if (thread != null)
					{
						thread.Interrupt();
					}
					TcpClient tcpClient5 = this.client;
					if (tcpClient5 != null)
					{
						tcpClient5.Close();
					}
					return;
				}
			}
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x00059670 File Offset: 0x00057870
		private IPAddress GetIPAddress()
		{
			NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
			string text;
			bool flag = text.Contains("virtual");
			string text2;
			bool flag2 = text2.Contains("pseudo");
			long num;
			int num2;
			if (allNetworkInterfaces == null)
			{
				num = 0L;
				num2 = 5;
				if (allNetworkInterfaces != null)
				{
				}
			}
			if (num == 0L)
			{
				if (num2 == 0)
				{
					while (allNetworkInterfaces != null)
					{
					}
				}
				long num3 = 0L;
				if (allNetworkInterfaces != null)
				{
				}
				if (num3 == 0L)
				{
				}
				throw new OutOfMemoryException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600125D RID: 4701 RVA: 0x000596DC File Offset: 0x000578DC
		public void Connect(string ip, int port)
		{
			for (;;)
			{
				Debug.Log("Connecting" + ip);
				if (this._Connecting)
				{
					break;
				}
				TcpClient tcpClient = this.client;
				if (tcpClient == null)
				{
					goto IL_0035;
				}
				Socket clientSocket = tcpClient.m_ClientSocket;
				if (clientSocket == null || !clientSocket.is_connected)
				{
					goto IL_0035;
				}
			}
			return;
			IL_0035:
			this._Connecting = true;
			this.sendQueue.Clear();
			this.receiveThread.Start();
		}

		// Token: 0x0600125E RID: 4702 RVA: 0x0005973C File Offset: 0x0005793C
		public void Disconnect()
		{
			while (!this._Connecting)
			{
				TcpClient tcpClient = this.client;
				if (tcpClient != null)
				{
					Socket clientSocket = tcpClient.m_ClientSocket;
					if (clientSocket != null)
					{
						if (!clientSocket.is_connected)
						{
							return;
						}
						continue;
					}
				}
				return;
			}
			if (this._Connecting)
			{
				Thread thread = this.receiveThread;
				if (thread != null)
				{
					thread.Interrupt();
				}
				Thread thread2 = this.sendThread;
				if (thread2 != null)
				{
					thread2.Interrupt();
				}
				TcpClient tcpClient2 = this.client;
				if (tcpClient2 != null)
				{
					tcpClient2.Close();
					return;
				}
			}
			else
			{
				TcpClient tcpClient3 = this.client;
				if (tcpClient3 != null)
				{
					tcpClient3.Close();
				}
				Thread thread3 = this.receiveThread;
				if (thread3 != null)
				{
					thread3.Join();
				}
				SafeQueue<byte[]> safeQueue = this.sendQueue;
				if (safeQueue != null)
				{
					safeQueue.Clear();
				}
			}
			TcpClient tcpClient4 = this.client;
			if (tcpClient4 != null)
			{
				tcpClient4.Dispose();
				return;
			}
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x000597F8 File Offset: 0x000579F8
		public bool Send(byte[] data, int length)
		{
			TcpClient tcpClient = this.client;
			if (tcpClient != null)
			{
				Socket clientSocket = tcpClient.m_ClientSocket;
				if (clientSocket != null && clientSocket.is_connected)
				{
					if (this.MaxMessageSize == 0)
					{
					}
					string text2;
					string text3;
					string text = "Client.Send: message too big: " + text2 + ". Limit: " + text3;
					return "Client.Send: message too big: " != null;
				}
			}
			if ("Client.Send: message too big: " == null)
			{
			}
			return true;
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x00059850 File Offset: 0x00057A50
		public Client()
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x00059868 File Offset: 0x00057A68
		[CompilerGenerated]
		private void <ReceiveThreadFunction>b__11_0()
		{
			TcpClient tcpClient = this.client;
			SafeQueue<byte[]> safeQueue = this.sendQueue;
			ManualResetEvent manualResetEvent = this.sendPending;
			if (!true)
			{
			}
			Common.SendLoop(0, tcpClient, safeQueue, manualResetEvent);
		}

		// Token: 0x040021EE RID: 8686
		public TcpClient client;

		// Token: 0x040021EF RID: 8687
		private Thread receiveThread;

		// Token: 0x040021F0 RID: 8688
		private Thread sendThread;

		// Token: 0x040021F1 RID: 8689
		private bool _Connecting;

		// Token: 0x040021F2 RID: 8690
		private SafeQueue<byte[]> sendQueue;

		// Token: 0x040021F3 RID: 8691
		private ManualResetEvent sendPending;

		// Token: 0x02000311 RID: 785
		[CompilerGenerated]
		private sealed class <>c__DisplayClass13_0
		{
			// Token: 0x06001262 RID: 4706 RVA: 0x00059898 File Offset: 0x00057A98
			public <>c__DisplayClass13_0()
			{
			}

			// Token: 0x06001263 RID: 4707 RVA: 0x000598AC File Offset: 0x00057AAC
			internal void <Connect>b__0()
			{
				Client client = this.<>4__this;
				string text = this.ip;
				int num = this.port;
				client.ReceiveThreadFunction(text, num);
			}

			// Token: 0x040021F4 RID: 8692
			public Client <>4__this;

			// Token: 0x040021F5 RID: 8693
			public string ip;

			// Token: 0x040021F6 RID: 8694
			public int port;
		}
	}
}
