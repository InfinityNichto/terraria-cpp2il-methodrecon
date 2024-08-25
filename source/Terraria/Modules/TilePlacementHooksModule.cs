using System;
using System.Runtime.InteropServices;
using Terraria.DataStructures;

namespace Terraria.Modules
{
	// Token: 0x02000550 RID: 1360
	public class TilePlacementHooksModule
	{
		// Token: 0x060032F3 RID: 13043 RVA: 0x001FE230 File Offset: 0x001FC430
		public TilePlacementHooksModule([Optional] TilePlacementHooksModule copyFrom)
		{
			Func<int, int, int, int, int, int, int> hook2;
			if (copyFrom != null)
			{
				bool processedCoordinates = copyFrom.check.processedCoordinates;
				Func<int, int, int, int, int, int, int> hook = copyFrom.check.hook;
				this.check.processedCoordinates = processedCoordinates;
				this.check.hook = hook;
				bool processedCoordinates2 = copyFrom.postPlaceEveryone.processedCoordinates;
				this.postPlaceEveryone.processedCoordinates = processedCoordinates2;
				bool processedCoordinates3 = copyFrom.postPlaceMyPlayer.processedCoordinates;
				hook2 = copyFrom.postPlaceMyPlayer.hook;
				this.postPlaceMyPlayer.processedCoordinates = processedCoordinates3;
				this.postPlaceMyPlayer.hook = hook2;
				bool processedCoordinates4 = copyFrom.placeOverride.processedCoordinates;
				this.placeOverride.processedCoordinates = processedCoordinates4;
				return;
			}
			this.postPlaceMyPlayer.processedCoordinates = hook2 != null;
			this.postPlaceEveryone.badReturn = hook2;
			this.postPlaceEveryone.badResponse = hook2;
			this.check.hook = hook2;
		}

		// Token: 0x04003C01 RID: 15361
		public PlacementHook check;

		// Token: 0x04003C02 RID: 15362
		public PlacementHook postPlaceEveryone;

		// Token: 0x04003C03 RID: 15363
		public PlacementHook postPlaceMyPlayer;

		// Token: 0x04003C04 RID: 15364
		public PlacementHook placeOverride;
	}
}
