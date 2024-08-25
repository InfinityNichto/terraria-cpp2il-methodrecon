using System;

namespace UnityEngine.SocialPlatforms
{
	// Token: 0x0200000C RID: 12
	public struct Range
	{
		// Token: 0x06000010 RID: 16 RVA: 0x000020F4 File Offset: 0x000002F4
		public Range(int fromValue, int valueCount)
		{
			this.from = fromValue;
		}

		// Token: 0x04000016 RID: 22
		public int from;

		// Token: 0x04000017 RID: 23
		public int count;
	}
}
