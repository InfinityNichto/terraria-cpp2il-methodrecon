using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Utilities;

namespace Terraria
{
	// Token: 0x02000424 RID: 1060
	public class Cloud
	{
		// Token: 0x06002760 RID: 10080 RVA: 0x0018C8C4 File Offset: 0x0018AAC4
		public static void resetClouds()
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
			if (num == 0)
			{
			}
			Cloud.addCloud();
			if (num == 0)
			{
			}
		}

		// Token: 0x06002761 RID: 10081 RVA: 0x0018C904 File Offset: 0x0018AB04
		public static void addCloud()
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool netHostOnly = Main.NetHostOnly;
			if (num == 0)
			{
			}
		}

		// Token: 0x06002762 RID: 10082 RVA: 0x0018CA9C File Offset: 0x0018AC9C
		private static int RollRareCloud()
		{
			if (!true)
			{
			}
			int num;
			return num;
		}

		// Token: 0x06002763 RID: 10083 RVA: 0x0018CAB8 File Offset: 0x0018ACB8
		public Color cloudColor(Color bgColor)
		{
			float num = this.scale;
			float alpha = this.Alpha;
			Color color;
			return color;
		}

		// Token: 0x06002764 RID: 10084 RVA: 0x0018CAD4 File Offset: 0x0018ACD4
		public object Clone()
		{
			return base.MemberwiseClone();
		}

		// Token: 0x06002765 RID: 10085 RVA: 0x0018CAE8 File Offset: 0x0018ACE8
		public static void UpdateClouds()
		{
			if (!true)
			{
			}
			bool netHostOnly = Main.NetHostOnly;
		}

		// Token: 0x06002766 RID: 10086 RVA: 0x0018CB30 File Offset: 0x0018AD30
		public void Update()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				if (num == 0)
				{
				}
				bool gameMenu = Main.gameMenu;
				int num2 = 28;
				this.type = num2;
			}
			float num3 = this.scale;
		}

		// Token: 0x06002767 RID: 10087 RVA: 0x0018CC98 File Offset: 0x0018AE98
		public Cloud()
		{
		}

		// Token: 0x06002768 RID: 10088 RVA: 0x0018CCAC File Offset: 0x0018AEAC
		// Note: this type is marked as 'beforefieldinit'.
		static Cloud()
		{
		}

		// Token: 0x0400339B RID: 13211
		public Vector2 position;

		// Token: 0x0400339C RID: 13212
		public float scale;

		// Token: 0x0400339D RID: 13213
		public float rotation;

		// Token: 0x0400339E RID: 13214
		public float rSpeed;

		// Token: 0x0400339F RID: 13215
		public float sSpeed;

		// Token: 0x040033A0 RID: 13216
		public bool active;

		// Token: 0x040033A1 RID: 13217
		public SpriteEffects spriteDir;

		// Token: 0x040033A2 RID: 13218
		public int type;

		// Token: 0x040033A3 RID: 13219
		public int width;

		// Token: 0x040033A4 RID: 13220
		public int height;

		// Token: 0x040033A5 RID: 13221
		public float Alpha;

		// Token: 0x040033A6 RID: 13222
		public bool kill;

		// Token: 0x040033A7 RID: 13223
		private static UnifiedRandom rand;
	}
}
