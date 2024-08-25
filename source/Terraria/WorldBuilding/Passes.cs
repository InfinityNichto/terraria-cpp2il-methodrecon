using System;
using System.Runtime.InteropServices;
using Terraria.IO;
using Terraria.Utilities;

namespace Terraria.WorldBuilding
{
	// Token: 0x020004CE RID: 1230
	public static class Passes
	{
		// Token: 0x020004CF RID: 1231
		public class Clear : GenPass
		{
			// Token: 0x06003027 RID: 12327 RVA: 0x001F5B44 File Offset: 0x001F3D44
			public Clear()
			{
				this.Name = "clear";
			}

			// Token: 0x06003028 RID: 12328 RVA: 0x001F5B64 File Offset: 0x001F3D64
			protected override void ApplyPass(GenerationProgress progress, GameConfiguration configuration)
			{
				Tile tile;
				tile.ClearEverything();
			}
		}

		// Token: 0x020004D0 RID: 1232
		public class ScatterCustom : GenPass
		{
			// Token: 0x06003029 RID: 12329 RVA: 0x001F5B80 File Offset: 0x001F3D80
			public ScatterCustom(string name, double loadWeight, int count, [Optional] GenBase.CustomPerUnitAction perUnit)
			{
				this.Name = name;
				this.Weight = loadWeight;
				this._perUnit = perUnit;
				this._count = count;
			}

			// Token: 0x0600302A RID: 12330 RVA: 0x001F5BB0 File Offset: 0x001F3DB0
			public void SetCustomAction(GenBase.CustomPerUnitAction perUnit)
			{
				this._perUnit = perUnit;
			}

			// Token: 0x0600302B RID: 12331 RVA: 0x001F5BC4 File Offset: 0x001F3DC4
			protected override void ApplyPass(GenerationProgress progress, GameConfiguration configuration)
			{
				int count = this._count;
				GenBase.CustomPerUnitAction perUnit = this._perUnit;
				UnifiedRandom random = GenBase._random;
				UnifiedRandom random2 = GenBase._random;
				IntPtr invoke_impl = perUnit.invoke_impl;
				IntPtr method_code = perUnit.method_code;
				IntPtr method = perUnit.method;
			}

			// Token: 0x040039CC RID: 14796
			private GenBase.CustomPerUnitAction _perUnit;

			// Token: 0x040039CD RID: 14797
			private int _count;
		}
	}
}
