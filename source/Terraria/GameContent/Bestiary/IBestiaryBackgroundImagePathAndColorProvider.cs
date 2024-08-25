using System;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x0200094B RID: 2379
	public interface IBestiaryBackgroundImagePathAndColorProvider
	{
		// Token: 0x060047AE RID: 18350
		Asset<Texture2D> GetBackgroundImage();

		// Token: 0x060047AF RID: 18351
		Color? GetBackgroundColor();
	}
}
