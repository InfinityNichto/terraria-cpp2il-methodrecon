using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent
{
	// Token: 0x020007B3 RID: 1971
	public class PressurePlateHelper
	{
		// Token: 0x0600403C RID: 16444 RVA: 0x00242A40 File Offset: 0x00240C40
		public static void Update()
		{
			if (!true)
			{
			}
		}

		// Token: 0x0600403D RID: 16445 RVA: 0x00242A64 File Offset: 0x00240C64
		public static void Reset()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x0600403E RID: 16446 RVA: 0x00242A80 File Offset: 0x00240C80
		public static void ResetPlayer(int player)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x0600403F RID: 16447 RVA: 0x00242A98 File Offset: 0x00240C98
		public static void UpdatePlayerPosition(Player player)
		{
			int num = 1;
			int num2 = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Vector2 size = player.Size;
			Vector2 bottomRight = player.BottomRight;
			Rectangle hitbox = player.Hitbox;
			long num3 = 0L;
			Rectangle hitbox2 = player.Hitbox;
			hitbox2.Inflate((int)num3, num2);
			hitbox2.Inflate((int)num3, num2);
			if (32640 == 0)
			{
			}
			Tile tile;
			bool flag = tile.active();
			int whoAmI = player.whoAmI;
		}

		// Token: 0x06004040 RID: 16448 RVA: 0x00242B30 File Offset: 0x00240D30
		public static void DestroyPlate(Point location)
		{
		}

		// Token: 0x06004041 RID: 16449 RVA: 0x00242B4C File Offset: 0x00240D4C
		private static void UpdatePlatePosition(Point location, int player, bool onIt)
		{
			if (!true)
			{
			}
			PressurePlateHelper.MoveInto(location, player);
		}

		// Token: 0x06004042 RID: 16450 RVA: 0x00242B6C File Offset: 0x00240D6C
		private static void MoveInto(Point location, int player)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06004043 RID: 16451 RVA: 0x00242BB8 File Offset: 0x00240DB8
		private static void MoveAwayFrom(Point location, int player)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			long num2 = 0L;
			int num3 = 7;
			if (num != 0)
			{
			}
			if (num2 == 0L)
			{
				if (num3 == 0)
				{
					if (num == 0)
					{
					}
					PressurePlateHelper.PokeLocation(location);
				}
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06004044 RID: 16452 RVA: 0x00242C04 File Offset: 0x00240E04
		private static void PokeLocation(Point location)
		{
			if (!true)
			{
			}
			bool logicHost = Main.LogicHost;
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x06004045 RID: 16453 RVA: 0x00242C24 File Offset: 0x00240E24
		public PressurePlateHelper()
		{
		}

		// Token: 0x06004046 RID: 16454 RVA: 0x00242C38 File Offset: 0x00240E38
		// Note: this type is marked as 'beforefieldinit'.
		static PressurePlateHelper()
		{
		}

		// Token: 0x04007E0B RID: 32267
		public static object EntityCreationLock;

		// Token: 0x04007E0C RID: 32268
		public static Dictionary<Point, bool[]> PressurePlatesPressed;

		// Token: 0x04007E0D RID: 32269
		public static bool NeedsFirstUpdate;

		// Token: 0x04007E0E RID: 32270
		private static Vector2[] PlayerLastPosition;

		// Token: 0x04007E0F RID: 32271
		private static Rectangle pressurePlateBounds;

		// Token: 0x04007E10 RID: 32272
		private static List<Point> tilesOld;

		// Token: 0x04007E11 RID: 32273
		private static List<Point> tilesNew;
	}
}
