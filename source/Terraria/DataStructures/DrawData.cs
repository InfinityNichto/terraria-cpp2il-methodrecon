using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.DataStructures
{
	// Token: 0x02000621 RID: 1569
	public struct DrawData
	{
		// Token: 0x060035E0 RID: 13792 RVA: 0x00211BF0 File Offset: 0x0020FDF0
		public DrawData(Texture2D texture, Vector2 position, Color color)
		{
			this.texture = texture;
			this.color = position;
			if (!true)
			{
			}
			long num = 0L;
			long num2 = 0L;
			long num3 = 0L;
			long num4 = 0L;
			Rectangle rectangle = texture.Frame(1, 1, (int)num, (int)num2, (int)num3, (int)num4);
			this.sourceRect = rectangle;
			this.sourceRect.Width = 1;
			if (!true)
			{
			}
			if (!true)
			{
			}
			this.origin = 1;
			if (!true)
			{
			}
			this.scale = 1;
		}

		// Token: 0x060035E1 RID: 13793 RVA: 0x00211C50 File Offset: 0x0020FE50
		public DrawData(Texture2D texture, Vector2 position, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effect, int inactiveLayerDepth)
		{
			this.texture = texture;
			if (!true)
			{
			}
			Rectangle rectangle;
			this.sourceRect = rectangle;
			this.sourceRect.Width = 1;
			this.color = position;
			this.effect = color;
			this.scale = 1;
		}

		// Token: 0x060035E2 RID: 13794 RVA: 0x00211C90 File Offset: 0x0020FE90
		public DrawData(Texture2D texture, Vector2 position, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effect, int inactiveLayerDepth)
		{
			if (!true)
			{
			}
			long num = 0L;
			long num2 = 0L;
			long num3 = 0L;
			long num4 = 0L;
			Rectangle rectangle = texture.Frame(1, 1, (int)num, (int)num2, (int)num3, (int)num4);
			this.sourceRect = rectangle;
			this.sourceRect.Width = 1;
			this.color = position;
			this.effect = color;
		}

		// Token: 0x060035E3 RID: 13795 RVA: 0x00211CD8 File Offset: 0x0020FED8
		public DrawData(Texture2D texture, Vector2 position, Rectangle sourceRect, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effect, int inactiveLayerDepth)
		{
			this.texture = texture;
			this.sourceRect = position;
			this.sourceRect.Width = sourceRect;
			this.color = color;
			this.effect = origin;
		}

		// Token: 0x060035E4 RID: 13796 RVA: 0x00211D10 File Offset: 0x0020FF10
		public DrawData(Texture2D texture, Vector2 position, Rectangle sourceRect, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effect, int inactiveLayerDepth)
		{
			this.texture = texture;
			this.sourceRect = position;
			this.sourceRect.Width = sourceRect;
			this.color = color;
			this.effect = origin;
		}

		// Token: 0x060035E5 RID: 13797 RVA: 0x00211D48 File Offset: 0x0020FF48
		public void Draw(SpriteBatch sb)
		{
			float num = this.rotation;
			float x = this.origin.X;
			float y = this.origin.Y;
			float x2 = this.scale.X;
			float y2 = this.scale.Y;
			SpriteEffects spriteEffects = this.effect;
		}

		// Token: 0x060035E6 RID: 13798 RVA: 0x00211D98 File Offset: 0x0020FF98
		public void Draw(SpriteBatch sb, Vector2 offset)
		{
			int num = 1;
			float x = this.position.X;
			float y = this.position.Y;
			if (num == 0)
			{
			}
			float num2 = this.rotation;
			float x2 = this.origin.X;
			float y2 = this.origin.Y;
			float x3 = this.scale.X;
			float y3 = this.scale.Y;
			SpriteEffects spriteEffects = this.effect;
		}

		// Token: 0x040076B3 RID: 30387
		public Texture2D texture;

		// Token: 0x040076B4 RID: 30388
		public Vector2 position;

		// Token: 0x040076B5 RID: 30389
		public Rectangle sourceRect;

		// Token: 0x040076B6 RID: 30390
		public Color color;

		// Token: 0x040076B7 RID: 30391
		public float rotation;

		// Token: 0x040076B8 RID: 30392
		public Vector2 origin;

		// Token: 0x040076B9 RID: 30393
		public Vector2 scale;

		// Token: 0x040076BA RID: 30394
		public SpriteEffects effect;

		// Token: 0x040076BB RID: 30395
		public int shader;

		// Token: 0x040076BC RID: 30396
		public bool ignorePlayerRotation;

		// Token: 0x040076BD RID: 30397
		public static Rectangle? nullRectangle;
	}
}
