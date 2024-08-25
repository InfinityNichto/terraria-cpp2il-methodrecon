using System;

namespace Terraria.Physics
{
	// Token: 0x0200053F RID: 1343
	public struct BallPassThroughEvent
	{
		// Token: 0x06003264 RID: 12900 RVA: 0x001F9B6C File Offset: 0x001F7D6C
		public BallPassThroughEvent(float timeScale, Tile tile, Entity entity, BallPassThroughType type)
		{
			this.Tile = tile;
			this.Entity = entity;
			this.Type = type;
		}

		// Token: 0x04003B93 RID: 15251
		public readonly Tile Tile;

		// Token: 0x04003B94 RID: 15252
		public readonly Entity Entity;

		// Token: 0x04003B95 RID: 15253
		public readonly BallPassThroughType Type;

		// Token: 0x04003B96 RID: 15254
		public readonly float TimeScale;
	}
}
