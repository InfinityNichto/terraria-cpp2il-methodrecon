using System;
using System.Collections.Generic;

namespace UnityEngine.UI
{
	// Token: 0x0200001B RID: 27
	public static class FontUpdateTracker
	{
		// Token: 0x060000DD RID: 221 RVA: 0x00003D3C File Offset: 0x00001F3C
		public static void TrackText(Text t)
		{
			Font font = t.font;
			Font font2 = t.font;
			Font font3 = t.font;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00003D60 File Offset: 0x00001F60
		private static void RebuildForFont(Font f)
		{
			if (!true)
			{
			}
			if (true)
			{
				return;
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00003D8C File Offset: 0x00001F8C
		public static void UntrackText(Text t)
		{
			Font font = t.font;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00003DA0 File Offset: 0x00001FA0
		// Note: this type is marked as 'beforefieldinit'.
		static FontUpdateTracker()
		{
		}

		// Token: 0x04000067 RID: 103
		private static Dictionary<Font, HashSet<Text>> m_Tracked;
	}
}
