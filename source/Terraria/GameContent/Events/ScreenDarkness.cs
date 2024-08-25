using System;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.Events
{
	// Token: 0x02000A57 RID: 2647
	public class ScreenDarkness
	{
		// Token: 0x06004E33 RID: 20019 RVA: 0x00276208 File Offset: 0x00274408
		public static void Update()
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
		}

		// Token: 0x06004E34 RID: 20020 RVA: 0x00276234 File Offset: 0x00274434
		public static void DrawBack(SpriteBatch spriteBatch)
		{
			if (!true)
			{
			}
			int screenWidth = Main.screenWidth;
			int screenHeight = Main.screenHeight;
		}

		// Token: 0x06004E35 RID: 20021 RVA: 0x00276264 File Offset: 0x00274464
		public static void DrawFront(SpriteBatch spriteBatch)
		{
			if (!true)
			{
			}
			int screenWidth = Main.screenWidth;
			int screenHeight = Main.screenHeight;
		}

		// Token: 0x06004E36 RID: 20022 RVA: 0x00276294 File Offset: 0x00274494
		public ScreenDarkness()
		{
		}

		// Token: 0x06004E37 RID: 20023 RVA: 0x002762A8 File Offset: 0x002744A8
		// Note: this type is marked as 'beforefieldinit'.
		static ScreenDarkness()
		{
		}

		// Token: 0x040086E1 RID: 34529
		public static float screenObstruction;

		// Token: 0x040086E2 RID: 34530
		public static Color frontColor;
	}
}
