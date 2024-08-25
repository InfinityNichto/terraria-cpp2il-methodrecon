using System;
using System.Runtime.InteropServices;

namespace Terraria.Net.Sockets
{
	// Token: 0x020006AF RID: 1711
	public interface ISocket
	{
		// Token: 0x060038C1 RID: 14529
		void Close();

		// Token: 0x060038C2 RID: 14530
		bool IsConnected();

		// Token: 0x060038C3 RID: 14531
		void Connect(RemoteAddress address);

		// Token: 0x060038C4 RID: 14532
		void AsyncSend(byte[] data, int offset, int size, SocketSendCallback callback, [Optional] object state);

		// Token: 0x060038C5 RID: 14533
		void AsyncReceive(byte[] data, int offset, int size, SocketReceiveCallback callback, [Optional] object state);

		// Token: 0x060038C6 RID: 14534
		bool IsDataAvailable();

		// Token: 0x060038C7 RID: 14535
		void SendQueuedPackets();

		// Token: 0x060038C8 RID: 14536
		bool StartListening(SocketConnectionAccepted callback);

		// Token: 0x060038C9 RID: 14537
		void StopListening();

		// Token: 0x060038CA RID: 14538
		RemoteAddress GetRemoteAddress();
	}
}
