using System;

namespace System.Net
{
	// Token: 0x0200026A RID: 618
	internal class NetConfig : ICloneable
	{
		// Token: 0x06001099 RID: 4249 RVA: 0x00034908 File Offset: 0x00032B08
		internal NetConfig()
		{
		}

		// Token: 0x0600109A RID: 4250 RVA: 0x00034924 File Offset: 0x00032B24
		object ICloneable.Clone()
		{
			return base.MemberwiseClone();
		}

		// Token: 0x04000D1D RID: 3357
		internal bool ipv6Enabled;

		// Token: 0x04000D1E RID: 3358
		internal int MaxResponseHeadersLength = 64;
	}
}
