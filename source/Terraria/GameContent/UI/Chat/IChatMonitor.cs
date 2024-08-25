using System;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.Chat
{
	// Token: 0x02000ADB RID: 2779
	public interface IChatMonitor
	{
		// Token: 0x060051AE RID: 20910
		void NewText(string newText, byte R = 255, byte G = 255, byte B = 255);

		// Token: 0x060051AF RID: 20911
		void NewTextMultiline(string text, bool force = false, [Optional] Color c, int WidthLimit = -1);

		// Token: 0x060051B0 RID: 20912
		void DrawChat(bool drawingPlayerChat);

		// Token: 0x060051B1 RID: 20913
		void Clear();

		// Token: 0x060051B2 RID: 20914
		void Update();

		// Token: 0x060051B3 RID: 20915
		void Offset(int linesOffset);

		// Token: 0x060051B4 RID: 20916
		void ResetOffset();

		// Token: 0x060051B5 RID: 20917
		void OnResolutionChange();
	}
}
