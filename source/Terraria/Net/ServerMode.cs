using System;

namespace Terraria.Net
{
	// Token: 0x020006AB RID: 1707
	[Flags]
	public enum ServerMode : byte
	{
		// Token: 0x0400795B RID: 31067
		None = 0,
		// Token: 0x0400795C RID: 31068
		Lobby = 1,
		// Token: 0x0400795D RID: 31069
		FriendsCanJoin = 2,
		// Token: 0x0400795E RID: 31070
		FriendsOfFriends = 4
	}
}
