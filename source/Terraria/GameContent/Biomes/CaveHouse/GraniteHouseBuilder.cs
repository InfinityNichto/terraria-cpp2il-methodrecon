using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.Biomes.CaveHouse
{
	// Token: 0x0200090C RID: 2316
	public class GraniteHouseBuilder : HouseBuilder
	{
		// Token: 0x06004684 RID: 18052 RVA: 0x00259E18 File Offset: 0x00258018
		public GraniteHouseBuilder(IEnumerable<Rectangle> rooms)
		{
			if (!true)
			{
			}
			base..ctor(HouseType.Granite, rooms);
			this.<TileType>k__BackingField = 369;
			this.<BeamType>k__BackingField = 576;
			this.<TableStyle>k__BackingField = 33;
			this.<ChestStyle>k__BackingField = 50;
		}

		// Token: 0x06004685 RID: 18053 RVA: 0x00259E58 File Offset: 0x00258058
		protected override void AgeRoom(Rectangle room)
		{
			ushort <TileType>k__BackingField = this.<TileType>k__BackingField;
		}
	}
}
