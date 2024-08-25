using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000007 RID: 7
	[StaticAccessor("UI::SystemProfilerApi", StaticAccessorType.DoubleColon)]
	[NativeHeader("Modules/UI/Canvas.h")]
	public static class UISystemProfilerApi
	{
		// Token: 0x06000054 RID: 84 RVA: 0x00002788 File Offset: 0x00000988
		public static void BeginSample(UISystemProfilerApi.SampleType type)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000279C File Offset: 0x0000099C
		public static void EndSample(UISystemProfilerApi.SampleType type)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000027B0 File Offset: 0x000009B0
		public static void AddMarker(string name, Object obj)
		{
			throw new MissingMethodException();
		}

		// Token: 0x02000008 RID: 8
		public enum SampleType
		{
			// Token: 0x0400000D RID: 13
			Layout,
			// Token: 0x0400000E RID: 14
			Render
		}
	}
}
