using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.Biomes.CaveHouse
{
	// Token: 0x02000912 RID: 2322
	public class IceHouseBuilder : HouseBuilder
	{
		// Token: 0x060046CB RID: 18123 RVA: 0x0025AEF0 File Offset: 0x002590F0
		public IceHouseBuilder(IEnumerable<Rectangle> rooms)
		{
			if (!true)
			{
			}
			base..ctor(HouseType.Ice, rooms);
			this.<TileType>k__BackingField = 321;
			this.<BeamType>k__BackingField = 574;
			this.<TableStyle>k__BackingField = 28;
			this.<ChestStyle>k__BackingField = 11;
		}

		// Token: 0x060046CC RID: 18124 RVA: 0x0025AF30 File Offset: 0x00259130
		protected override void AgeRoom(Rectangle room)
		{
			ushort <TileType>k__BackingField = this.<TileType>k__BackingField;
		}
	}
}
