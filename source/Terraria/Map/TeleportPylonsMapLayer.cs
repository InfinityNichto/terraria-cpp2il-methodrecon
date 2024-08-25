using System;
using Terraria.GameContent;

namespace Terraria.Map
{
	// Token: 0x020006C0 RID: 1728
	public class TeleportPylonsMapLayer : IMapLayer
	{
		// Token: 0x06003928 RID: 14632 RVA: 0x0022C954 File Offset: 0x0022AB54
		public void Draw(MapOverlayDrawContext context, string text)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool flag = TeleportPylonsSystem.IsPlayerNearAPylon(Main.LocalPlayer);
			if (num == 0)
			{
			}
			bool inUse;
			if (Main.DroneCameraTracker != null)
			{
				if (num == 0)
				{
				}
				inUse = Main.DroneCameraTracker._inUse;
				return;
			}
			if (!inUse)
			{
			}
		}

		// Token: 0x06003929 RID: 14633 RVA: 0x0022C9E8 File Offset: 0x0022ABE8
		public TeleportPylonsMapLayer()
		{
		}
	}
}
