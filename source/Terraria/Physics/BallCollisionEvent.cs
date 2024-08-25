using System;
using Microsoft.Xna.Framework;

namespace Terraria.Physics
{
	// Token: 0x0200053E RID: 1342
	public struct BallCollisionEvent
	{
		// Token: 0x06003263 RID: 12899 RVA: 0x001F9B50 File Offset: 0x001F7D50
		public BallCollisionEvent(float timeScale, Vector2 normal, Vector2 impactPoint, Tile tile, Entity entity)
		{
			this.Tile = normal;
			this.Entity = impactPoint;
		}

		// Token: 0x04003B8E RID: 15246
		public readonly Vector2 Normal;

		// Token: 0x04003B8F RID: 15247
		public readonly Vector2 ImpactPoint;

		// Token: 0x04003B90 RID: 15248
		public readonly Tile Tile;

		// Token: 0x04003B91 RID: 15249
		public readonly Entity Entity;

		// Token: 0x04003B92 RID: 15250
		public readonly float TimeScale;
	}
}
