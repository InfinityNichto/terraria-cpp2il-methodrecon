using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine.SocialPlatforms.Impl;

namespace UnityEngine.SocialPlatforms
{
	// Token: 0x02000003 RID: 3
	public class Local : ISocialPlatform
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002076 File Offset: 0x00000276
		public ILocalUser localUser
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002084 File Offset: 0x00000284
		void ISocialPlatform.Authenticate(ILocalUser user, Action<bool> callback)
		{
			if (user != null)
			{
			}
			Texture2D texture2D;
			this.m_DefaultTexture = texture2D;
			this.PopulateStaticData();
			Texture2D defaultTexture = this.m_DefaultTexture;
			if (callback != null)
			{
				return;
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002076 File Offset: 0x00000276
		private void PopulateStaticData()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000020BC File Offset: 0x000002BC
		private Texture2D CreateDummyTexture(int width, int height)
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000020CC File Offset: 0x000002CC
		public Local()
		{
		}

		// Token: 0x04000001 RID: 1
		private static LocalUser m_LocalUser;

		// Token: 0x04000002 RID: 2
		private List<UserProfile> m_Friends;

		// Token: 0x04000003 RID: 3
		private List<UserProfile> m_Users;

		// Token: 0x04000004 RID: 4
		private List<AchievementDescription> m_AchievementDescriptions;

		// Token: 0x04000005 RID: 5
		private List<Achievement> m_Achievements;

		// Token: 0x04000006 RID: 6
		private List<Leaderboard> m_Leaderboards;

		// Token: 0x04000007 RID: 7
		private Texture2D m_DefaultTexture;
	}
}
