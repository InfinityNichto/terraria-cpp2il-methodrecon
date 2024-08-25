using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Terraria.Social.Base;

namespace Terraria.Social
{
	// Token: 0x02000510 RID: 1296
	public static class SocialAPI
	{
		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06003145 RID: 12613 RVA: 0x000021DB File Offset: 0x000003DB
		public static SocialMode Mode
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06003146 RID: 12614 RVA: 0x001F7CDC File Offset: 0x001F5EDC
		public static void Initialize([Optional] SocialMode? mode)
		{
		}

		// Token: 0x06003147 RID: 12615 RVA: 0x001F7D00 File Offset: 0x001F5F00
		public static void Shutdown()
		{
		}

		// Token: 0x06003148 RID: 12616 RVA: 0x000021DB File Offset: 0x000003DB
		private static T LoadModule<T>() where T : ISocialModule, new()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003149 RID: 12617 RVA: 0x000021DB File Offset: 0x000003DB
		private static T LoadModule<T>(T module) where T : ISocialModule
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600314A RID: 12618 RVA: 0x001F7D24 File Offset: 0x001F5F24
		private static void LoadDiscord()
		{
			if (true)
			{
				return;
			}
		}

		// Token: 0x0600314B RID: 12619 RVA: 0x001F7D38 File Offset: 0x001F5F38
		private static void LoadSteam()
		{
		}

		// Token: 0x04003B08 RID: 15112
		private static SocialMode _mode;

		// Token: 0x04003B09 RID: 15113
		public static FriendsSocialModule Friends;

		// Token: 0x04003B0A RID: 15114
		public static AchievementsSocialModule Achievements;

		// Token: 0x04003B0B RID: 15115
		public static CloudSocialModule Cloud;

		// Token: 0x04003B0C RID: 15116
		public static NetSocialModule Network;

		// Token: 0x04003B0D RID: 15117
		public static OverlaySocialModule Overlay;

		// Token: 0x04003B0E RID: 15118
		public static ServerJoinRequestsManager JoinRequests;

		// Token: 0x04003B0F RID: 15119
		public static PlatformSocialModule Platform;

		// Token: 0x04003B10 RID: 15120
		private static List<ISocialModule> _modules;
	}
}
