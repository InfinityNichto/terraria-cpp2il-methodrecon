using System;

namespace Microsoft.Xna.Framework.Audio
{
	// Token: 0x020003CB RID: 971
	public class AudioEngine
	{
		// Token: 0x06001A66 RID: 6758 RVA: 0x0006C9A0 File Offset: 0x0006ABA0
		public AudioEngine(string contentPath)
		{
			Singleton.Create();
		}
	}
}
