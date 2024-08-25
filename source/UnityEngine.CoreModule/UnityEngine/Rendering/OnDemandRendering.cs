using System;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	// Token: 0x02000104 RID: 260
	[RequiredByNativeCode]
	public class OnDemandRendering
	{
		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000556 RID: 1366 RVA: 0x00009960 File Offset: 0x00007B60
		public static int renderFrameInterval
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00009974 File Offset: 0x00007B74
		[RequiredByNativeCode]
		internal static void GetRenderFrameInterval([Out] int frameInterval)
		{
			if (!true)
			{
			}
			int renderFrameInterval = OnDemandRendering.renderFrameInterval;
			frameInterval.m_value = renderFrameInterval;
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00009994 File Offset: 0x00007B94
		// Note: this type is marked as 'beforefieldinit'.
		static OnDemandRendering()
		{
		}

		// Token: 0x0400042E RID: 1070
		private static int m_RenderFrameInterval;
	}
}
