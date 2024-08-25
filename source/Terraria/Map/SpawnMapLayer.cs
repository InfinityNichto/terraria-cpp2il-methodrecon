using System;
using Terraria.Localization;

namespace Terraria.Map
{
	// Token: 0x020006BF RID: 1727
	public class SpawnMapLayer : IMapLayer
	{
		// Token: 0x06003926 RID: 14630 RVA: 0x0022C8E0 File Offset: 0x0022AAE0
		public void Draw(MapOverlayDrawContext context, string text)
		{
			if (!true)
			{
			}
			Player localPlayer = Main.LocalPlayer;
			int spawnX = localPlayer.SpawnX;
			int spawnY = localPlayer.SpawnY;
			int spawnTileX = Main.spawnTileX;
			int spawnTileY = Main.spawnTileY;
			if (!true)
			{
			}
			string textValue = Language.GetTextValue("UI.SpawnPoint");
			if (localPlayer.SpawnX == 0)
			{
			}
			string textValue2 = Language.GetTextValue("UI.SpawnBed");
		}

		// Token: 0x06003927 RID: 14631 RVA: 0x0022C940 File Offset: 0x0022AB40
		public SpawnMapLayer()
		{
		}
	}
}
