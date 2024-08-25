using System;
using Microsoft.Xna.Framework;
using Terraria.Utilities;

namespace Terraria
{
	// Token: 0x0200045C RID: 1116
	public class Star
	{
		// Token: 0x06002A32 RID: 10802 RVA: 0x001B1F70 File Offset: 0x001B0170
		public static void NightSetup()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (16256 == 0)
			{
			}
			int num;
			if (num == 0)
			{
				return;
			}
			int num2;
			if (num2 != 0)
			{
				return;
			}
			if (16256 == 0)
			{
			}
		}

		// Token: 0x06002A33 RID: 10803 RVA: 0x001B1F9C File Offset: 0x001B019C
		public static void StarFall(float positionX)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int num2 = 17648;
			if (num2 == 0)
			{
			}
			if (num2 == 0)
			{
				if (num2 == 0)
				{
				}
				if (num2 != 0 || num2 == 0)
				{
				}
			}
		}

		// Token: 0x06002A34 RID: 10804 RVA: 0x001B1FC8 File Offset: 0x001B01C8
		public static void SpawnStars(int s = -1)
		{
			FastRandom fastRandom = FastRandom.CreateWithRandomSeed();
			int num = 200;
			int num2 = 400;
			int num3 = fastRandom.Next(num, num2);
			if (16256 == 0)
			{
			}
		}

		// Token: 0x06002A35 RID: 10805 RVA: 0x001B2070 File Offset: 0x001B0270
		public void Fall()
		{
			this.falling = true;
			if (!true)
			{
			}
		}

		// Token: 0x06002A36 RID: 10806 RVA: 0x001B2088 File Offset: 0x001B0288
		public void Update()
		{
			bool flag;
			float num2;
			if (this.falling)
			{
				flag = this.hidden;
				if (!flag)
				{
					int num = this.fallTime;
					float x = this.position.X;
					float y = this.position.Y;
					float x2 = this.fallSpeed.X;
					float y2 = this.fallSpeed.Y;
					this.position.X = num2;
					int num3 = 1;
					this.hidden = num3 != 0;
					if (num3 == 0)
					{
					}
					if (num3 != 0)
					{
						int num4 = 1;
						this.hidden = num4 != 0;
					}
					float num5 = this.twinkle;
					float num6 = this.twinkleSpeed;
					this.twinkle = num5;
					this.twinkleSpeed = num6;
					float num7 = this.rotation;
					this.rotation = num7;
					this.rotation = num7;
					return;
				}
			}
			float num8 = this.fadeIn;
			float num9;
			if (!flag)
			{
				num9 = this.fadeIn;
			}
			this.fadeIn = num9;
			float num10 = this.twinkle;
			float num11 = this.twinkleSpeed;
			this.twinkle = num10;
			this.twinkleSpeed = num11;
			num2 = this.rotation;
			float num12 = this.rotationSpeed;
		}

		// Token: 0x06002A37 RID: 10807 RVA: 0x001B2198 File Offset: 0x001B0398
		public static void UpdateStars()
		{
			if (!true)
			{
			}
			Star.SpawnStars(0);
		}

		// Token: 0x06002A38 RID: 10808 RVA: 0x001B21B4 File Offset: 0x001B03B4
		public Star()
		{
		}

		// Token: 0x06002A39 RID: 10809 RVA: 0x001B21C8 File Offset: 0x001B03C8
		// Note: this type is marked as 'beforefieldinit'.
		static Star()
		{
		}

		// Token: 0x04003732 RID: 14130
		public Vector2 position;

		// Token: 0x04003733 RID: 14131
		public float scale;

		// Token: 0x04003734 RID: 14132
		public float rotation;

		// Token: 0x04003735 RID: 14133
		public int type;

		// Token: 0x04003736 RID: 14134
		public float twinkle;

		// Token: 0x04003737 RID: 14135
		public float twinkleSpeed;

		// Token: 0x04003738 RID: 14136
		public float rotationSpeed;

		// Token: 0x04003739 RID: 14137
		public bool falling;

		// Token: 0x0400373A RID: 14138
		public bool hidden;

		// Token: 0x0400373B RID: 14139
		public Vector2 fallSpeed;

		// Token: 0x0400373C RID: 14140
		public int fallTime;

		// Token: 0x0400373D RID: 14141
		public static bool dayCheck;

		// Token: 0x0400373E RID: 14142
		public static float starfallBoost;

		// Token: 0x0400373F RID: 14143
		public static int starFallCount;

		// Token: 0x04003740 RID: 14144
		public float fadeIn;
	}
}
