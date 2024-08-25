using System;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent
{
	// Token: 0x020007B8 RID: 1976
	public class DontStarveSeed
	{
		// Token: 0x06004064 RID: 16484 RVA: 0x00243200 File Offset: 0x00241400
		public static void ModifyNightColor(Color bgColorToSet, Color moonColor)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x06004065 RID: 16485 RVA: 0x0024321C File Offset: 0x0024141C
		public static void ModifyMinimumLightColorAtNight(byte minimalLight)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			minimalLight.m_value = 1;
			if (!true)
			{
			}
			if (true)
			{
				byte b;
				minimalLight.m_value = b;
			}
		}

		// Token: 0x06004066 RID: 16486 RVA: 0x00243244 File Offset: 0x00241444
		public static void FixBiomeDarkness(Color bgColor, int R, int G, int B)
		{
			if (!true)
			{
			}
			if (true)
			{
				byte r = bgColor.R;
				byte g = bgColor.G;
				byte b = bgColor.B;
			}
		}

		// Token: 0x06004067 RID: 16487 RVA: 0x00243270 File Offset: 0x00241470
		public static void Initialize()
		{
		}

		// Token: 0x06004068 RID: 16488 RVA: 0x00243280 File Offset: 0x00241480
		private static void Hook_OnEnterWorld(Player player)
		{
			long num = 0L;
			player.UpdateStarvingState(num != 0L);
		}

		// Token: 0x06004069 RID: 16489 RVA: 0x00243298 File Offset: 0x00241498
		public DontStarveSeed()
		{
		}
	}
}
