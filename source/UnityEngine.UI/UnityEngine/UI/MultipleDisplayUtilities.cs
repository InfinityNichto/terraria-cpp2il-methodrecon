using System;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000059 RID: 89
	internal static class MultipleDisplayUtilities
	{
		// Token: 0x0600035E RID: 862 RVA: 0x0000B130 File Offset: 0x00009330
		public static bool GetRelativeMousePositionForDrag(PointerEventData eventData, Vector2 position)
		{
			return true;
		}

		// Token: 0x0600035F RID: 863 RVA: 0x0000B140 File Offset: 0x00009340
		public static Vector3 RelativeMouseAtScaled(Vector2 position)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int renderingWidth = Display.main.renderingWidth;
			int systemWidth = Display.main.systemWidth;
			if (num == 0)
			{
			}
			int renderingHeight = Display.main.renderingHeight;
			int systemHeight = Display.main.systemHeight;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int systemWidth2 = Display.main.systemWidth;
			int systemHeight2 = Display.main.systemHeight;
			int renderingWidth2 = Display.main.renderingWidth;
			int renderingHeight2 = Display.main.renderingHeight;
			bool fullScreen = Screen.fullScreen;
			int width = Screen.width;
			int height = Screen.height;
			int systemHeight3 = Display.main.systemHeight;
			int systemWidth3 = Display.main.systemWidth;
			int renderingHeight3 = Display.main.renderingHeight;
			int renderingWidth3 = Display.main.renderingWidth;
			int renderingHeight4 = Display.main.renderingHeight;
			bool fullScreen2 = Screen.fullScreen;
			if (systemWidth3 == 0)
			{
			}
			int systemWidth4 = Display.main.systemWidth;
			int systemHeight4 = Display.main.systemHeight;
			if (systemWidth3 == 0)
			{
			}
			int renderingWidth4 = Display.main.renderingWidth;
			int systemWidth5 = Display.main.systemWidth;
			int renderingHeight5 = Display.main.renderingHeight;
			int systemHeight5 = Display.main.systemHeight;
			if (systemWidth3 == 0)
			{
				return;
			}
		}
	}
}
