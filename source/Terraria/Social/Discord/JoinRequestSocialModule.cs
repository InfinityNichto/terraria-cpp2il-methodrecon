using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Terraria.Net;

namespace Terraria.Social.Discord
{
	// Token: 0x02000523 RID: 1315
	public class JoinRequestSocialModule : ISocialModule
	{
		// Token: 0x0600319F RID: 12703 RVA: 0x001F8AA8 File Offset: 0x001F6CA8
		public void Initialize()
		{
			Delegate @delegate;
			if (@delegate != null)
			{
				return;
			}
			Delegate delegate2;
			if (delegate2 != null)
			{
				throw new InvalidCastException();
			}
		}

		// Token: 0x060031A0 RID: 12704 RVA: 0x001F8AC4 File Offset: 0x001F6CC4
		public void Shutdown()
		{
			Delegate @delegate;
			if (@delegate != null)
			{
				return;
			}
			Delegate delegate2;
			if (delegate2 != null)
			{
				throw new InvalidCastException();
			}
		}

		// Token: 0x060031A1 RID: 12705 RVA: 0x001F8AE0 File Offset: 0x001F6CE0
		private void ReceiveJoinRequest(DiscordRpc.DiscordUser request)
		{
			string userId = request.userId;
			string username = request.username;
		}

		// Token: 0x060031A2 RID: 12706 RVA: 0x001F8AFC File Offset: 0x001F6CFC
		private void ReceiveJoinCallback(string secret)
		{
			this.TestSecretIsWhatWeExpectItToBe(secret);
		}

		// Token: 0x060031A3 RID: 12707 RVA: 0x001F8B10 File Offset: 0x001F6D10
		private void TestSecretIsWhatWeExpectItToBe(string secret)
		{
			bool flag = this.CanJoinGame();
			Dictionary<NetGroupInfo.InfoProviderId, string> dictionary = this._infoAboutNetGroup.DecomposeInfo(secret);
		}

		// Token: 0x060031A4 RID: 12708 RVA: 0x001F8B34 File Offset: 0x001F6D34
		private bool CanJoinGame()
		{
			if (!true)
			{
			}
			return Main.gameMenu;
		}

		// Token: 0x060031A5 RID: 12709 RVA: 0x001F8B4C File Offset: 0x001F6D4C
		public JoinRequestSocialModule()
		{
		}

		// Token: 0x04003B56 RID: 15190
		private NetGroupInfo _infoAboutNetGroup;

		// Token: 0x02000524 RID: 1316
		[CompilerGenerated]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x060031A6 RID: 12710 RVA: 0x001F8B60 File Offset: 0x001F6D60
			public <>c__DisplayClass3_0()
			{
			}

			// Token: 0x060031A7 RID: 12711 RVA: 0x001F8B74 File Offset: 0x001F6D74
			internal void <ReceiveJoinRequest>b__0()
			{
				DiscordRpc.Respond(this.userId, DiscordRpc.Reply.Yes);
			}

			// Token: 0x060031A8 RID: 12712 RVA: 0x001F8B90 File Offset: 0x001F6D90
			internal void <ReceiveJoinRequest>b__1()
			{
				string text = this.userId;
			}

			// Token: 0x04003B57 RID: 15191
			public string userId;
		}
	}
}
