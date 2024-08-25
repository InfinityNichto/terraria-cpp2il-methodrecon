using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.Biomes.CaveHouse
{
	// Token: 0x02000915 RID: 2325
	public class MushroomHouseBuilder : HouseBuilder
	{
		// Token: 0x060046D1 RID: 18129 RVA: 0x0025B0E4 File Offset: 0x002592E4
		public MushroomHouseBuilder(IEnumerable<Rectangle> rooms)
			: base(HouseType.Mushroom, rooms)
		{
			this.<TileType>k__BackingField = 190;
			this.<BeamType>k__BackingField = 578;
			this.<TableStyle>k__BackingField = 27;
			this.<ChestStyle>k__BackingField = 32;
		}

		// Token: 0x060046D2 RID: 18130 RVA: 0x0025B120 File Offset: 0x00259320
		protected override void AgeRoom(Rectangle room)
		{
		}
	}
}
