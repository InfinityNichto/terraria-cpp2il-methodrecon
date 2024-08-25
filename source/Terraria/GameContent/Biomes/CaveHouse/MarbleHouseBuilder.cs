using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.Biomes.CaveHouse
{
	// Token: 0x02000914 RID: 2324
	public class MarbleHouseBuilder : HouseBuilder
	{
		// Token: 0x060046CF RID: 18127 RVA: 0x0025B048 File Offset: 0x00259248
		public MarbleHouseBuilder(IEnumerable<Rectangle> rooms)
		{
			if (!true)
			{
			}
			base..ctor(HouseType.Marble, rooms);
			this.<TileType>k__BackingField = 357;
			this.<BeamType>k__BackingField = 561;
			this.<TableStyle>k__BackingField = 34;
			this.<ChestStyle>k__BackingField = 51;
		}

		// Token: 0x060046D0 RID: 18128 RVA: 0x0025B088 File Offset: 0x00259288
		protected override void AgeRoom(Rectangle room)
		{
			ushort <TileType>k__BackingField = this.<TileType>k__BackingField;
		}
	}
}
