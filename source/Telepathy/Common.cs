using System;
using System.Collections.Concurrent;
using System.IO;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading;

namespace Telepathy
{
	// Token: 0x02000312 RID: 786
	public abstract class Common
	{
		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06001264 RID: 4708 RVA: 0x000598D8 File Offset: 0x00057AD8
		public int ReceiveQueueCount
		{
			get
			{
				return this.receiveQueue.Count;
			}
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x000598F0 File Offset: 0x00057AF0
		public bool GetNextMessage([Out] Message message)
		{
			ConcurrentQueue<Message> concurrentQueue = this.receiveQueue;
			bool flag;
			return flag;
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x00059908 File Offset: 0x00057B08
		protected static bool SendMessagesBlocking(NetworkStream stream, byte[][] messages)
		{
			Stream.ReadWriteTask activeReadWriteTask = stream._activeReadWriteTask;
			long num = 0L;
			if (num == 0L)
			{
			}
			if (num == 0L || num == 0L)
			{
			}
			Stream.ReadWriteTask activeReadWriteTask2 = stream._activeReadWriteTask;
			if (activeReadWriteTask2 == null)
			{
			}
			Delegate action = activeReadWriteTask2.m_action;
			if (activeReadWriteTask2.m_action == null)
			{
				return;
			}
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x00059954 File Offset: 0x00057B54
		protected static bool ReadMessageBlocking(NetworkStream stream, int MaxMessageSize, [Out] byte[] content)
		{
			if (!true)
			{
			}
			string text2;
			string text = "ReadMessageBlocking: possible allocation attack with a header of: " + text2 + " bytes.";
			bool flag;
			return flag;
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x00059980 File Offset: 0x00057B80
		protected static void ReceiveLoop(int connectionId, TcpClient client, ConcurrentQueue<Message> receiveQueue, int MaxMessageSize)
		{
			NetworkStream stream = client.GetStream();
			DateTime now = DateTime.Now;
			if (42170256 == 0)
			{
			}
			double totalSeconds = (DateTime.Now - now).TotalSeconds;
			if (42170256 == 0)
			{
			}
			int num;
			string text = num.ToString();
			string text2 = "ReceiveLoop: messageQueue is getting big(" + text + "), try calling GetNextMessage more often. You can call it more than once per frame!";
			if (42170256 == 0)
			{
			}
			DateTime now2 = DateTime.Now;
		}

		// Token: 0x06001269 RID: 4713 RVA: 0x00059A10 File Offset: 0x00057C10
		protected static void SendLoop(int connectionId, TcpClient client, SafeQueue<byte[]> sendQueue, ManualResetEvent sendPending)
		{
			int num = 1;
			NetworkStream stream = client.GetStream();
			bool connected = client.Connected;
			bool flag = sendPending.Reset();
			if (num == 0)
			{
			}
		}

		// Token: 0x0600126A RID: 4714 RVA: 0x00059A58 File Offset: 0x00057C58
		protected Common()
		{
		}

		// Token: 0x0600126B RID: 4715 RVA: 0x00059A74 File Offset: 0x00057C74
		// Note: this type is marked as 'beforefieldinit'.
		static Common()
		{
		}

		// Token: 0x040021F7 RID: 8695
		protected ConcurrentQueue<Message> receiveQueue;

		// Token: 0x040021F8 RID: 8696
		public static int messageQueueSizeWarning;

		// Token: 0x040021F9 RID: 8697
		public bool NoDelay = true;

		// Token: 0x040021FA RID: 8698
		public int MaxMessageSize;

		// Token: 0x040021FB RID: 8699
		public int SendTimeout;

		// Token: 0x040021FC RID: 8700
		[ThreadStatic]
		private static byte[] header;

		// Token: 0x040021FD RID: 8701
		[ThreadStatic]
		private static byte[] payload;
	}
}
