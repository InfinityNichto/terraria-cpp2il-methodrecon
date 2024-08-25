using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.Golf
{
	// Token: 0x02000A09 RID: 2569
	public class GolfBallTrackRecord
	{
		// Token: 0x06004BCE RID: 19406 RVA: 0x00270384 File Offset: 0x0026E584
		public GolfBallTrackRecord()
		{
		}

		// Token: 0x06004BCF RID: 19407 RVA: 0x000021DB File Offset: 0x000003DB
		public void RecordHit(Vector2 position)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004BD0 RID: 19408 RVA: 0x000021DB File Offset: 0x000003DB
		public int GetAccumulatedScore()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004BD1 RID: 19409 RVA: 0x00270398 File Offset: 0x0026E598
		private void GetTrackInfo([Out] double totalDistancePassed, [Out] int hitsMade)
		{
			int size = this._hitLocations._size;
			List<Vector2> hitLocations = this._hitLocations;
			if (size == 0)
			{
			}
			int size2 = this._hitLocations._size;
		}

		// Token: 0x0400860B RID: 34315
		private List<Vector2> _hitLocations;
	}
}
