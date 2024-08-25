using System;

namespace UnityEngine.SocialPlatforms
{
	// Token: 0x02000006 RID: 6
	public interface ILocalUser : IUserProfile
	{
		// Token: 0x0600000C RID: 12
		void Authenticate(Action<bool> callback);

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000D RID: 13
		bool authenticated { get; }
	}
}
