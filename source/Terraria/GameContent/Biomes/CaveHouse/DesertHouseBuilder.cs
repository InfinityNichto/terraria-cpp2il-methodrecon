using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.Biomes.CaveHouse
{
	// Token: 0x0200090B RID: 2315
	public class DesertHouseBuilder : HouseBuilder
	{
		// Token: 0x06004682 RID: 18050 RVA: 0x00259D60 File Offset: 0x00257F60
		public DesertHouseBuilder(IEnumerable<Rectangle> rooms)
		{
			if (!true)
			{
			}
			base..ctor(HouseType.Desert, rooms);
			this.<TileType>k__BackingField = 396;
			this.<BeamType>k__BackingField = 577;
			this.<TableStyle>k__BackingField = 7;
			this.<UsesTables2>k__BackingField = true;
			this.<ChestStyle>k__BackingField = 10;
			this.<UsesContainers2>k__BackingField = true;
		}

		// Token: 0x06004683 RID: 18051 RVA: 0x00259DAC File Offset: 0x00257FAC
		protected override void AgeRoom(Rectangle room)
		{
			ushort <TileType>k__BackingField = this.<TileType>k__BackingField;
		}
	}
}
