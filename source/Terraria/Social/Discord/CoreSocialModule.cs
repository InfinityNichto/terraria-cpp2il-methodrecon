using System;

namespace Terraria.Social.Discord
{
	// Token: 0x02000515 RID: 1301
	public class CoreSocialModule : ISocialModule
	{
		// Token: 0x0600316C RID: 12652 RVA: 0x001F826C File Offset: 0x001F646C
		public void Initialize()
		{
		}

		// Token: 0x0600316D RID: 12653 RVA: 0x001F827C File Offset: 0x001F647C
		public void Shutdown()
		{
			if (!true)
			{
			}
			DiscordRpc.Shutdown();
		}

		// Token: 0x0600316E RID: 12654 RVA: 0x001F8294 File Offset: 0x001F6494
		private void Pulse()
		{
			DiscordRpc.RunCallbacks();
		}

		// Token: 0x0600316F RID: 12655 RVA: 0x001F82A8 File Offset: 0x001F64A8
		public CoreSocialModule()
		{
		}

		// Token: 0x04003B1D RID: 15133
		private const string TERRARIA_STEAM_APPLICATION_ID = "105600";

		// Token: 0x04003B1E RID: 15134
		private const string TERRARIA_DISCORD_APPLICATION_ID = "356943499456937984";

		// Token: 0x04003B1F RID: 15135
		private const bool AUTO_REGISTER_STEAM = false;

		// Token: 0x04003B20 RID: 15136
		public static DiscordHooks Hooks;

		// Token: 0x04003B21 RID: 15137
		private DiscordRpc.EventHandlers _handlers;
	}
}
