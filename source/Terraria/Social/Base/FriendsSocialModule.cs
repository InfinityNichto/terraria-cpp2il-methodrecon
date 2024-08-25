using System;

namespace Terraria.Social.Base
{
	// Token: 0x0200052A RID: 1322
	public abstract class FriendsSocialModule : ISocialModule
	{
		// Token: 0x060031D0 RID: 12752
		public abstract string GetUsername();

		// Token: 0x060031D1 RID: 12753
		public abstract void OpenJoinInterface();

		// Token: 0x060031D2 RID: 12754
		public abstract void Initialize();

		// Token: 0x060031D3 RID: 12755
		public abstract void Shutdown();

		// Token: 0x060031D4 RID: 12756 RVA: 0x001F8DC4 File Offset: 0x001F6FC4
		protected FriendsSocialModule()
		{
		}
	}
}
