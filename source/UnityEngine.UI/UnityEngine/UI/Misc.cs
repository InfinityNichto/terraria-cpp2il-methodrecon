using System;

namespace UnityEngine.UI
{
	// Token: 0x02000058 RID: 88
	internal static class Misc
	{
		// Token: 0x0600035C RID: 860 RVA: 0x0000B0DC File Offset: 0x000092DC
		public static void Destroy(Object obj)
		{
			if (!true)
			{
			}
			bool isPlaying = Application.isPlaying;
			if (obj != null)
			{
			}
			Object.Destroy(obj);
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0000B108 File Offset: 0x00009308
		public static void DestroyImmediate(Object obj)
		{
			if (!true)
			{
			}
			bool isEditor = Application.isEditor;
			Object.DestroyImmediate(obj);
		}
	}
}
