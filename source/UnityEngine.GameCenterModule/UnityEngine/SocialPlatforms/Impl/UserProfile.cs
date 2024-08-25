using System;

namespace UnityEngine.SocialPlatforms.Impl
{
	// Token: 0x0200000E RID: 14
	public class UserProfile : IUserProfile
	{
		// Token: 0x06000016 RID: 22 RVA: 0x00002168 File Offset: 0x00000368
		public UserProfile()
		{
			this.m_UserName = "Uninitialized";
			this.m_State = UserState.Offline;
			this.m_ID = "0";
			this.m_legacyID = "0";
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000021A4 File Offset: 0x000003A4
		public UserProfile(string name, string id, bool friend, UserState state, Texture2D image)
		{
			this.m_UserName = name;
			this.m_ID = id;
			this.m_Image = image;
			this.m_gameID = id;
			this.m_State = state;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000021DC File Offset: 0x000003DC
		public UserProfile(string name, string teamId, string gameId, bool friend, UserState state, Texture2D image)
		{
			this.m_UserName = name;
			this.m_ID = teamId;
			this.m_Image = image;
			this.m_gameID = gameId;
			this.m_State = state;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002214 File Offset: 0x00000414
		public override string ToString()
		{
			string id = this.m_ID;
			if ((id == null || id != null) && (" - " == null || " - " != null))
			{
				string userName = this.m_UserName;
				if ((userName == null || userName != null) && (" - " == null || " - " != null))
				{
					bool isFriend = this.m_IsFriend;
					string text;
					if ((text == null || text != null) && (" - " == null || " - " != null))
					{
						UserState state = this.m_State;
						string text2;
						if (text2 == null || text2 != null)
						{
							string text3;
							return text3;
						}
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000228C File Offset: 0x0000048C
		public void SetUserName(string name)
		{
			this.m_UserName = name;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000022A0 File Offset: 0x000004A0
		public void SetUserID(string id)
		{
			this.m_ID = id;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000022B4 File Offset: 0x000004B4
		public void SetImage(Texture2D image)
		{
			this.m_Image = image;
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600001D RID: 29 RVA: 0x000022C8 File Offset: 0x000004C8
		public string userName
		{
			get
			{
				return this.m_UserName;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600001E RID: 30 RVA: 0x000022DC File Offset: 0x000004DC
		public string id
		{
			get
			{
				return this.m_ID;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600001F RID: 31 RVA: 0x000022F0 File Offset: 0x000004F0
		public bool isFriend
		{
			get
			{
				return this.m_IsFriend;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00002304 File Offset: 0x00000504
		public UserState state
		{
			get
			{
				return this.m_State;
			}
		}

		// Token: 0x0400001B RID: 27
		protected string m_UserName;

		// Token: 0x0400001C RID: 28
		protected string m_ID;

		// Token: 0x0400001D RID: 29
		private string m_legacyID;

		// Token: 0x0400001E RID: 30
		protected bool m_IsFriend;

		// Token: 0x0400001F RID: 31
		protected UserState m_State;

		// Token: 0x04000020 RID: 32
		protected Texture2D m_Image;

		// Token: 0x04000021 RID: 33
		private string m_gameID;
	}
}
