using System;

namespace Terraria.DataStructures
{
	// Token: 0x02000682 RID: 1666
	public struct WingStats
	{
		// Token: 0x060037A6 RID: 14246 RVA: 0x00222074 File Offset: 0x00220274
		public WingStats(int flyTime = 100, float flySpeedOverride = -1f, float accelerationMultiplier = 1f, bool hasHoldDownHoverFeatures = false, float hoverFlySpeedOverride = -1f, float hoverAccelerationMultiplier = 1f)
		{
			this.FlyTime = flyTime;
		}

		// Token: 0x060037A7 RID: 14247 RVA: 0x00222088 File Offset: 0x00220288
		public WingStats WithSpeedBoost(float multiplier)
		{
			float accRunSpeedOverride = this.AccRunSpeedOverride;
			float downHoverSpeedOverride = this.DownHoverSpeedOverride;
			float accRunAccelerationMult = this.AccRunAccelerationMult;
			bool hasDownHoverStats = this.HasDownHoverStats;
			float downHoverAccelerationMult = this.DownHoverAccelerationMult;
			WingStats wingStats;
			wingStats.AccRunAccelerationMult = accRunAccelerationMult;
			wingStats.HasDownHoverStats = hasDownHoverStats;
			wingStats.DownHoverAccelerationMult = downHoverAccelerationMult;
			return wingStats;
		}

		// Token: 0x060037A8 RID: 14248 RVA: 0x002220D4 File Offset: 0x002202D4
		// Note: this type is marked as 'beforefieldinit'.
		static WingStats()
		{
		}

		// Token: 0x0400789A RID: 30874
		public static readonly WingStats Default;

		// Token: 0x0400789B RID: 30875
		public int FlyTime;

		// Token: 0x0400789C RID: 30876
		public float AccRunSpeedOverride;

		// Token: 0x0400789D RID: 30877
		public float AccRunAccelerationMult;

		// Token: 0x0400789E RID: 30878
		public bool HasDownHoverStats;

		// Token: 0x0400789F RID: 30879
		public float DownHoverSpeedOverride;

		// Token: 0x040078A0 RID: 30880
		public float DownHoverAccelerationMult;
	}
}
