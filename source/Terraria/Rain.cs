using System;
using Microsoft.Xna.Framework;

namespace Terraria
{
	// Token: 0x02000453 RID: 1107
	public class Rain
	{
		// Token: 0x0600297E RID: 10622 RVA: 0x0019BA38 File Offset: 0x00199C38
		public static void ClearRain()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Rain[] rain = Main.rain;
		}

		// Token: 0x0600297F RID: 10623 RVA: 0x0019BA58 File Offset: 0x00199C58
		public static void MakeRain()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			bool netHostOnly = Main.NetHostOnly;
			if (num == 0)
			{
			}
		}

		// Token: 0x06002980 RID: 10624 RVA: 0x0019BB80 File Offset: 0x00199D80
		public static Vector2 GetRainFallVelocity()
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06002981 RID: 10625 RVA: 0x0019BB94 File Offset: 0x00199D94
		public void Update()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				return;
			}
			float x = this.position.X;
			float y = this.position.Y;
			float x2 = this.velocity.X;
			float y2 = this.velocity.Y;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			bool gameMenu = Main.gameMenu;
			float y3 = this.position.Y;
			if (num == 0)
			{
			}
			Vector2 screenPosition = Main.screenPosition;
			int screenHeight = Main.screenHeight;
		}

		// Token: 0x06002982 RID: 10626 RVA: 0x0019BD48 File Offset: 0x00199F48
		public static int NewRainForced(Vector2 Position, Vector2 Velocity)
		{
			if (!true)
			{
			}
			float gfxQuality = Main.gfxQuality;
			int num = 32640;
			if (num == 0)
			{
			}
			Rain[] rain = Main.rain;
			if (num != 0)
			{
			}
			if (num == 0)
			{
			}
			Rain[] rain2 = Main.rain;
			int waterStyle = Main.waterStyle;
			int num2;
			return num2;
		}

		// Token: 0x06002983 RID: 10627 RVA: 0x0019BD98 File Offset: 0x00199F98
		private static int NewRain(Vector2 Position, Vector2 Velocity)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int num2 = 32640;
			if (num2 != 0)
			{
			}
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			if (num2 == 0)
			{
			}
			float num4;
			float num3 = Math.Max(num4, num4);
			float gfxQuality = Main.gfxQuality;
			if (32640 == 0)
			{
			}
			int <SnowTileCount>k__BackingField = Main.SceneMetrics.<SnowTileCount>k__BackingField;
			int num5 = 800;
			if (17480 == 0)
			{
			}
			if (num5 == 0)
			{
			}
			double num6 = Math.Pow((double)gfxQuality, 0.9);
			int num7 = 32768;
			if (num7 == 0)
			{
			}
			Rain[] rain = Main.rain;
			if (num7 != 0)
			{
			}
			if (num7 == 0)
			{
			}
			Rain[] rain2 = Main.rain;
			int waterStyle = Main.waterStyle;
			int num8;
			return num8;
		}

		// Token: 0x06002984 RID: 10628 RVA: 0x0019BE58 File Offset: 0x0019A058
		public Rain()
		{
		}

		// Token: 0x040036AD RID: 13997
		public Vector2 position;

		// Token: 0x040036AE RID: 13998
		public Vector2 velocity;

		// Token: 0x040036AF RID: 13999
		public float scale;

		// Token: 0x040036B0 RID: 14000
		public float rotation;

		// Token: 0x040036B1 RID: 14001
		public int alpha;

		// Token: 0x040036B2 RID: 14002
		public bool active;

		// Token: 0x040036B3 RID: 14003
		public byte type;
	}
}
