using System;

namespace UnityEngine.SocialPlatforms.Impl
{
	// Token: 0x0200000D RID: 13
	public class LocalUser : UserProfile, ILocalUser, IUserProfile
	{
		// Token: 0x06000011 RID: 17 RVA: 0x00002108 File Offset: 0x00000308
		public LocalUser()
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002120 File Offset: 0x00000320
		public void Authenticate(Action<bool> callback)
		{
			ISocialPlatform instance = ActivePlatform.Instance;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002134 File Offset: 0x00000334
		public void SetAuthenticated(bool value)
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002144 File Offset: 0x00000344
		public void SetUnderage(bool value)
		{
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00002154 File Offset: 0x00000354
		public bool authenticated
		{
			get
			{
				return this.m_Authenticated;
			}
		}

		// Token: 0x04000018 RID: 24
		private IUserProfile[] m_Friends;

		// Token: 0x04000019 RID: 25
		private bool m_Authenticated;

		// Token: 0x0400001A RID: 26
		private bool m_Underage;
	}
}
