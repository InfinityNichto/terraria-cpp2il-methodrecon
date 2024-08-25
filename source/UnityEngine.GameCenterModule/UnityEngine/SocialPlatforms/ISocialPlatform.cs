using System;

namespace UnityEngine.SocialPlatforms
{
	// Token: 0x02000005 RID: 5
	public interface ISocialPlatform
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000A RID: 10
		ILocalUser localUser { get; }

		// Token: 0x0600000B RID: 11
		void Authenticate(ILocalUser user, Action<bool> callback);
	}
}
