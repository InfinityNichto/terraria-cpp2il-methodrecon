using System;

namespace Terraria.GameContent.Ambience
{
	// Token: 0x02000AF8 RID: 2808
	public class AmbientSkyDrawCache
	{
		// Token: 0x0600523A RID: 21050 RVA: 0x002828AC File Offset: 0x00280AAC
		public void SetUnderworldInfo(int drawIndex, float scale)
		{
			AmbientSkyDrawCache.UnderworldCache[] underworld = this.Underworld;
		}

		// Token: 0x0600523B RID: 21051 RVA: 0x002828C0 File Offset: 0x00280AC0
		public void SetOceanLineInfo(float yScreenPosition, float oceanOpacity)
		{
		}

		// Token: 0x0600523C RID: 21052 RVA: 0x002828D0 File Offset: 0x00280AD0
		public AmbientSkyDrawCache()
		{
		}

		// Token: 0x0600523D RID: 21053 RVA: 0x002828E4 File Offset: 0x00280AE4
		// Note: this type is marked as 'beforefieldinit'.
		static AmbientSkyDrawCache()
		{
		}

		// Token: 0x04008A7D RID: 35453
		public static AmbientSkyDrawCache Instance;

		// Token: 0x04008A7E RID: 35454
		public AmbientSkyDrawCache.UnderworldCache[] Underworld;

		// Token: 0x04008A7F RID: 35455
		public AmbientSkyDrawCache.OceanLineCache OceanLineInfo;

		// Token: 0x02000AF9 RID: 2809
		public struct UnderworldCache
		{
			// Token: 0x04008A80 RID: 35456
			public float Scale;
		}

		// Token: 0x02000AFA RID: 2810
		public struct OceanLineCache
		{
			// Token: 0x04008A81 RID: 35457
			public float YScreenPosition;

			// Token: 0x04008A82 RID: 35458
			public float OceanOpacity;
		}
	}
}
