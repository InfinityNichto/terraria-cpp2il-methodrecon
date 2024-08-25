using System;
using UnityEngine;

namespace Unity.Collections
{
	// Token: 0x02000013 RID: 19
	public static class NativeLeakDetection
	{
		// Token: 0x0600000D RID: 13 RVA: 0x00002190 File Offset: 0x00000390
		[RuntimeInitializeOnLoadMethod]
		private static void Initialize()
		{
		}

		// Token: 0x0400003B RID: 59
		private static int s_NativeLeakDetectionMode;
	}
}
