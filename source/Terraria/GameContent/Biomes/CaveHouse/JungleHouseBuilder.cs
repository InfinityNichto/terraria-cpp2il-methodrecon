using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.Biomes.CaveHouse
{
	// Token: 0x02000913 RID: 2323
	public class JungleHouseBuilder : HouseBuilder
	{
		// Token: 0x060046CD RID: 18125 RVA: 0x0025AF9C File Offset: 0x0025919C
		public JungleHouseBuilder(IEnumerable<Rectangle> rooms)
		{
			if (!true)
			{
			}
			base..ctor(HouseType.Jungle, rooms);
			this.<TileType>k__BackingField = 158;
			this.<BeamType>k__BackingField = 575;
			this.<TableStyle>k__BackingField = 2;
			this.<ChestStyle>k__BackingField = 8;
		}

		// Token: 0x060046CE RID: 18126 RVA: 0x0025AFD8 File Offset: 0x002591D8
		protected override void AgeRoom(Rectangle room)
		{
			ushort <TileType>k__BackingField = this.<TileType>k__BackingField;
		}
	}
}
