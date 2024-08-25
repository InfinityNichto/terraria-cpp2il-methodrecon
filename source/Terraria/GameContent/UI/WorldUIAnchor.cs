using System;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.UI
{
	// Token: 0x02000A6B RID: 2667
	public class WorldUIAnchor
	{
		// Token: 0x06004EA9 RID: 20137 RVA: 0x00277978 File Offset: 0x00275B78
		public WorldUIAnchor()
		{
			if (!true)
			{
			}
			if (true)
			{
				return;
			}
			if (!true)
			{
			}
			this.type = WorldUIAnchor.AnchorType.None;
		}

		// Token: 0x06004EAA RID: 20138 RVA: 0x00277998 File Offset: 0x00275B98
		public WorldUIAnchor(Entity anchor)
		{
			if (!true)
			{
			}
			if (true)
			{
				return;
			}
			if (!true)
			{
			}
		}

		// Token: 0x06004EAB RID: 20139 RVA: 0x002779B0 File Offset: 0x00275BB0
		public WorldUIAnchor(Vector2 anchor)
		{
			if (!true)
			{
			}
			if (true)
			{
				return;
			}
			if (!true)
			{
			}
			this.size = 1;
			base..ctor();
			this.type = WorldUIAnchor.AnchorType.Pos;
		}

		// Token: 0x06004EAC RID: 20140 RVA: 0x002779DC File Offset: 0x00275BDC
		public WorldUIAnchor(int topLeftX, int topLeftY, int width, int height)
		{
			if (!true)
			{
			}
			if (true)
			{
				return;
			}
			if (!true)
			{
			}
			this.size = 1;
			base..ctor();
			this.type = WorldUIAnchor.AnchorType.Tile;
		}

		// Token: 0x06004EAD RID: 20141 RVA: 0x00277A0C File Offset: 0x00275C0C
		public bool InRange(Vector2 target, float tileRangeX, float tileRangeY)
		{
			WorldUIAnchor.AnchorType anchorType = this.type;
			if (anchorType == WorldUIAnchor.AnchorType.Entity)
			{
				Vector2 center = this.entity.Center;
				if (anchorType == WorldUIAnchor.AnchorType.Entity)
				{
				}
				Entity entity = this.entity;
				int width = entity.width;
				Vector2 center2 = entity.Center;
				if (anchorType == WorldUIAnchor.AnchorType.Entity)
				{
				}
				Entity entity2 = this.entity;
				int height = entity2.height;
				float x = this.pos.X;
				if (entity2 == null)
				{
				}
				float y = this.pos.Y;
				if (entity2 == null)
				{
				}
				float x2 = this.pos.X;
				if (entity2 == null)
				{
				}
				float x3 = this.size.X;
			}
			return true;
		}

		// Token: 0x040087C0 RID: 34752
		public WorldUIAnchor.AnchorType type;

		// Token: 0x040087C1 RID: 34753
		public Entity entity;

		// Token: 0x040087C2 RID: 34754
		public Vector2 pos;

		// Token: 0x040087C3 RID: 34755
		public Vector2 size;

		// Token: 0x02000A6C RID: 2668
		public enum AnchorType
		{
			// Token: 0x040087C5 RID: 34757
			Entity,
			// Token: 0x040087C6 RID: 34758
			Tile,
			// Token: 0x040087C7 RID: 34759
			Pos,
			// Token: 0x040087C8 RID: 34760
			None
		}
	}
}
