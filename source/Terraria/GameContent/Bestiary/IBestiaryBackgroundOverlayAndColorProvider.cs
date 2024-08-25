using System;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x0200094D RID: 2381
	public interface IBestiaryBackgroundOverlayAndColorProvider
	{
		// Token: 0x060047B1 RID: 18353
		Asset<Texture2D> GetBackgroundOverlayImage();

		// Token: 0x060047B2 RID: 18354
		Color? GetBackgroundOverlayColor();

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x060047B3 RID: 18355
		float DisplayPriority { get; }
	}
}
