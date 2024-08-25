using System;
using Microsoft.Xna.Framework;

namespace ReLogic.OS
{
	// Token: 0x02000B21 RID: 2849
	public interface IWindowService
	{
		// Token: 0x06005349 RID: 21321
		void SetUnicodeTitle(GameWindow window, string title);

		// Token: 0x0600534A RID: 21322
		void StartFlashingIcon(GameWindow window);

		// Token: 0x0600534B RID: 21323
		void StopFlashingIcon(GameWindow window);

		// Token: 0x0600534C RID: 21324
		float GetScaling();

		// Token: 0x0600534D RID: 21325
		void SetQuickEditEnabled(bool enabled);
	}
}
