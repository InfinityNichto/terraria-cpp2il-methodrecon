using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Terraria.WorldBuilding
{
	// Token: 0x020004EC RID: 1260
	public class WorldGenerator
	{
		// Token: 0x06003089 RID: 12425 RVA: 0x001F6818 File Offset: 0x001F4A18
		public WorldGenerator(int seed, WorldGenConfiguration configuration)
		{
			this._seed = seed;
			this._configuration = configuration;
		}

		// Token: 0x0600308A RID: 12426 RVA: 0x000021DB File Offset: 0x000003DB
		public void Append(GenPass pass)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600308B RID: 12427 RVA: 0x001F683C File Offset: 0x001F4A3C
		public static void LogGenSeedAtPoint(string tag)
		{
		}

		// Token: 0x0600308C RID: 12428 RVA: 0x001F684C File Offset: 0x001F4A4C
		public static void SaveWorldAtPoint(string tag)
		{
		}

		// Token: 0x0600308D RID: 12429 RVA: 0x001F685C File Offset: 0x001F4A5C
		public void GenerateWorld([Optional] GenerationProgress progress)
		{
			List<GenPass> passes = this._passes;
		}

		// Token: 0x04003A96 RID: 14998
		private readonly List<GenPass> _passes;

		// Token: 0x04003A97 RID: 14999
		private double _totalLoadWeight;

		// Token: 0x04003A98 RID: 15000
		private readonly int _seed;

		// Token: 0x04003A99 RID: 15001
		private readonly WorldGenConfiguration _configuration;

		// Token: 0x04003A9A RID: 15002
		public static GenerationProgress CurrentGenerationProgress;

		// Token: 0x04003A9B RID: 15003
		public static bool TerminateWorldGen;
	}
}
