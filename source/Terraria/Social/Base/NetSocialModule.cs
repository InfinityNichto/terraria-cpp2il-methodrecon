using System;
using System.Diagnostics;
using Terraria.Net;
using Terraria.Net.Sockets;

namespace Terraria.Social.Base
{
	// Token: 0x0200052B RID: 1323
	public abstract class NetSocialModule : ISocialModule
	{
		// Token: 0x060031D5 RID: 12757
		public abstract void Initialize();

		// Token: 0x060031D6 RID: 12758
		public abstract void Shutdown();

		// Token: 0x060031D7 RID: 12759
		public abstract void Close(RemoteAddress address);

		// Token: 0x060031D8 RID: 12760
		public abstract bool IsConnected(RemoteAddress address);

		// Token: 0x060031D9 RID: 12761
		public abstract void Connect(RemoteAddress address);

		// Token: 0x060031DA RID: 12762
		public abstract bool Send(RemoteAddress address, byte[] data, int length);

		// Token: 0x060031DB RID: 12763
		public abstract int Receive(RemoteAddress address, byte[] data, int offset, int length);

		// Token: 0x060031DC RID: 12764
		public abstract bool IsDataAvailable(RemoteAddress address);

		// Token: 0x060031DD RID: 12765
		public abstract void LaunchLocalServer(Process process, ServerMode mode);

		// Token: 0x060031DE RID: 12766
		public abstract bool CanInvite();

		// Token: 0x060031DF RID: 12767
		public abstract void OpenInviteInterface();

		// Token: 0x060031E0 RID: 12768
		public abstract void CancelJoin();

		// Token: 0x060031E1 RID: 12769
		public abstract bool StartListening(SocketConnectionAccepted callback);

		// Token: 0x060031E2 RID: 12770
		public abstract void StopListening();

		// Token: 0x060031E3 RID: 12771
		public abstract ulong GetLobbyId();

		// Token: 0x060031E4 RID: 12772 RVA: 0x001F8DD8 File Offset: 0x001F6FD8
		protected NetSocialModule()
		{
		}
	}
}
