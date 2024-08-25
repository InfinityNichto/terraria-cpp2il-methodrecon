using System;
using Microsoft.Xna.Framework;

namespace Terraria.Physics
{
	// Token: 0x02000543 RID: 1347
	public interface IBallContactListener
	{
		// Token: 0x06003269 RID: 12905
		void OnCollision(PhysicsProperties properties, Vector2 position, Vector2 velocity, BallCollisionEvent collision);

		// Token: 0x0600326A RID: 12906
		void OnPassThrough(PhysicsProperties properties, Vector2 position, Vector2 velocity, float angularVelocity, BallPassThroughEvent passThrough);
	}
}
