using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.Enums;

namespace Terraria.DataStructures
{
	// Token: 0x02000637 RID: 1591
	public struct NPCAimedTarget
	{
		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x06003632 RID: 13874 RVA: 0x000021DB File Offset: 0x000003DB
		public bool Invalid
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x06003633 RID: 13875 RVA: 0x00212548 File Offset: 0x00210748
		public Vector2 Center
		{
			get
			{
				int width = this.Width;
				int height = this.Height;
				float x = this.Position.X;
				float y = this.Position.Y;
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x06003634 RID: 13876 RVA: 0x00212588 File Offset: 0x00210788
		public Vector2 Size
		{
			get
			{
				int width = this.Width;
				int height = this.Height;
				Vector2 vector;
				return vector;
			}
		}

		// Token: 0x06003635 RID: 13877 RVA: 0x002125A4 File Offset: 0x002107A4
		public NPCAimedTarget(NPC npc)
		{
			this.Type = NPCTargetType.NPC;
			Rectangle hitbox = npc.Hitbox;
			int width = npc.width;
			Vector2 position = npc.position;
			Vector2 velocity = npc.velocity;
		}

		// Token: 0x06003636 RID: 13878 RVA: 0x002125D4 File Offset: 0x002107D4
		public NPCAimedTarget(Player player, bool ignoreTank = true)
		{
			int num = 1;
			this.Type = (NPCTargetType)num;
			Rectangle hitbox = player.Hitbox;
			int width = player.width;
			Vector2 position = player.position;
			Vector2 velocity = player.velocity;
			int tankPet = player.tankPet;
			int tankPet2 = player.tankPet;
			int num2 = 3;
			this.Type = (NPCTargetType)num2;
			Rectangle hitbox2 = player.Hitbox;
			int width2 = player.width;
			Vector2 position2 = player.position;
			Vector2 velocity2 = player.velocity;
		}

		// Token: 0x040076F2 RID: 30450
		public NPCTargetType Type;

		// Token: 0x040076F3 RID: 30451
		public Rectangle Hitbox;

		// Token: 0x040076F4 RID: 30452
		public int Width;

		// Token: 0x040076F5 RID: 30453
		public int Height;

		// Token: 0x040076F6 RID: 30454
		public Vector2 Position;

		// Token: 0x040076F7 RID: 30455
		public Vector2 Velocity;
	}
}
