using System;

namespace Terraria.DataStructures
{
	// Token: 0x02000648 RID: 1608
	public struct PlayerMovementAccsCache
	{
		// Token: 0x060036DA RID: 14042 RVA: 0x00220A1C File Offset: 0x0021EC1C
		public void CopyFrom(Player player)
		{
			int num = 257;
			this._readyToPaste = num != 0;
			bool blockExtraJumps = player.mount.BlockExtraJumps;
			this._mountPreventedExtraJumps = num != 0;
			int num2 = player.rocketTime;
			this.rocketTime = num2;
			float num3 = player.wingTime;
			this.wingTime = num3;
			bool canJumpAgain_Cloud = player.canJumpAgain_Cloud;
			this.jumpAgainCloud = canJumpAgain_Cloud;
			bool canJumpAgain_Sandstorm = player.canJumpAgain_Sandstorm;
			this.jumpAgainSandstorm = canJumpAgain_Sandstorm;
			bool canJumpAgain_Blizzard = player.canJumpAgain_Blizzard;
			this.jumpAgainBlizzard = canJumpAgain_Blizzard;
			bool canJumpAgain_Fart = player.canJumpAgain_Fart;
			this.jumpAgainFart = canJumpAgain_Fart;
			bool canJumpAgain_Sail = player.canJumpAgain_Sail;
			this.jumpAgainSail = canJumpAgain_Sail;
			bool canJumpAgain_Unicorn = player.canJumpAgain_Unicorn;
			this.jumpAgainUnicorn = canJumpAgain_Unicorn;
		}

		// Token: 0x060036DB RID: 14043 RVA: 0x00220AC8 File Offset: 0x0021ECC8
		public void PasteInto(Player player)
		{
			if (this._mountPreventedFlight)
			{
				int num = this.rocketTime;
				player.rocketTime = num;
				float num2 = this.wingTime;
				player.wingTime = num2;
			}
			if (this._mountPreventedExtraJumps)
			{
				bool flag = this.jumpAgainCloud;
				player.canJumpAgain_Cloud = flag;
				bool flag2 = this.jumpAgainSandstorm;
				player.canJumpAgain_Sandstorm = flag2;
				bool flag3 = this.jumpAgainBlizzard;
				player.canJumpAgain_Blizzard = flag3;
				bool flag4 = this.jumpAgainFart;
				player.canJumpAgain_Fart = flag4;
				bool flag5 = this.jumpAgainSail;
				player.canJumpAgain_Sail = flag5;
				bool flag6 = this.jumpAgainUnicorn;
				player.canJumpAgain_Unicorn = flag6;
			}
		}

		// Token: 0x040077E1 RID: 30689
		private bool _readyToPaste;

		// Token: 0x040077E2 RID: 30690
		private bool _mountPreventedFlight;

		// Token: 0x040077E3 RID: 30691
		private bool _mountPreventedExtraJumps;

		// Token: 0x040077E4 RID: 30692
		private int rocketTime;

		// Token: 0x040077E5 RID: 30693
		private float wingTime;

		// Token: 0x040077E6 RID: 30694
		private int rocketDelay;

		// Token: 0x040077E7 RID: 30695
		private int rocketDelay2;

		// Token: 0x040077E8 RID: 30696
		private bool jumpAgainCloud;

		// Token: 0x040077E9 RID: 30697
		private bool jumpAgainSandstorm;

		// Token: 0x040077EA RID: 30698
		private bool jumpAgainBlizzard;

		// Token: 0x040077EB RID: 30699
		private bool jumpAgainFart;

		// Token: 0x040077EC RID: 30700
		private bool jumpAgainSail;

		// Token: 0x040077ED RID: 30701
		private bool jumpAgainUnicorn;
	}
}
