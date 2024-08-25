using System;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x0200095F RID: 2399
	public interface IFilterInfoProvider
	{
		// Token: 0x06004802 RID: 18434
		UIElement GetFilterImage();

		// Token: 0x06004803 RID: 18435
		string GetDisplayNameKey();

		// Token: 0x06004804 RID: 18436
		void GetDisplay([Out] Texture2D texture, [Out] Rectangle frame);
	}
}
