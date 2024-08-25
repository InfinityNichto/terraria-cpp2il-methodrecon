using System;

namespace Terraria.Social.Base
{
	// Token: 0x0200052D RID: 1325
	public abstract class PlatformSocialModule : ISocialModule
	{
		// Token: 0x060031EB RID: 12779
		public abstract void Initialize();

		// Token: 0x060031EC RID: 12780
		public abstract void Shutdown();

		// Token: 0x060031ED RID: 12781 RVA: 0x001F8E00 File Offset: 0x001F7000
		protected PlatformSocialModule()
		{
		}
	}
}
