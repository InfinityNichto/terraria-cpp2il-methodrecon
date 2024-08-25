using System;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.BigProgressBar
{
	// Token: 0x02000AE6 RID: 2790
	internal interface IBigProgressBar
	{
		// Token: 0x060051F7 RID: 20983
		bool ValidateAndCollectNecessaryInfo(BigProgressBarInfo info);

		// Token: 0x060051F8 RID: 20984
		void Draw(BigProgressBarInfo info, SpriteBatch spriteBatch);
	}
}
