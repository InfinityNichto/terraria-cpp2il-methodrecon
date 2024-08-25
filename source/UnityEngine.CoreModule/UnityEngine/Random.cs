using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000075 RID: 117
	[NativeHeader("Runtime/Export/Random/Random.bindings.h")]
	public static class Random
	{
		// Token: 0x060001D7 RID: 471 RVA: 0x00004A94 File Offset: 0x00002C94
		public static int Range(int minInclusive, int maxExclusive)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00004AA8 File Offset: 0x00002CA8
		[FreeFunction]
		private static int RandomRangeInt(int minInclusive, int maxExclusive)
		{
			throw new MissingMethodException();
		}
	}
}
