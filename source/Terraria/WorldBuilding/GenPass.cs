using System;
using Terraria.IO;

namespace Terraria.WorldBuilding
{
	// Token: 0x020004CD RID: 1229
	public abstract class GenPass : GenBase
	{
		// Token: 0x06003024 RID: 12324 RVA: 0x001F5B10 File Offset: 0x001F3D10
		public GenPass(string name, double loadWeight)
		{
			this.Name = name;
			this.Weight = loadWeight;
		}

		// Token: 0x06003025 RID: 12325
		protected abstract void ApplyPass(GenerationProgress progress, GameConfiguration configuration);

		// Token: 0x06003026 RID: 12326 RVA: 0x001F5B34 File Offset: 0x001F3D34
		public void Apply(GenerationProgress progress, GameConfiguration configuration)
		{
		}

		// Token: 0x040039CA RID: 14794
		public string Name;

		// Token: 0x040039CB RID: 14795
		public double Weight;
	}
}
