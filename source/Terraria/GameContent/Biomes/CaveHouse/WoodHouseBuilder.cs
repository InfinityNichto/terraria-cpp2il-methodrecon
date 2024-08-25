using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Xna.Framework;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes.CaveHouse
{
	// Token: 0x02000916 RID: 2326
	public class WoodHouseBuilder : HouseBuilder
	{
		// Token: 0x060046D3 RID: 18131 RVA: 0x0025B178 File Offset: 0x00259378
		public WoodHouseBuilder(IEnumerable<Rectangle> rooms)
		{
			if (!true)
			{
			}
			this.<TileType>k__BackingField = 30;
			this.<BeamType>k__BackingField = 124;
			if (30 == 0)
			{
			}
			if (124 != 0)
			{
				if (124 == 0)
				{
				}
				if (124 == 0)
				{
				}
				UnifiedRandom genRand = WorldGen.genRand;
				return;
			}
			if (160 == 0)
			{
			}
			this.<ChestStyle>k__BackingField = 1;
		}

		// Token: 0x060046D4 RID: 18132 RVA: 0x0025B1D4 File Offset: 0x002593D4
		protected override void AgeRoom(Rectangle room)
		{
			UnifiedRandom genRand = WorldGen.genRand;
			UnifiedRandom genRand2 = WorldGen.genRand;
		}

		// Token: 0x060046D5 RID: 18133 RVA: 0x0025B230 File Offset: 0x00259430
		public override void Place(HouseBuilderContext context, StructureMap structures)
		{
			base.Place(context, structures);
			this.RainbowifyOnTenthAnniversaryWorlds();
		}

		// Token: 0x060046D6 RID: 18134 RVA: 0x0025B24C File Offset: 0x0025944C
		private void RainbowifyOnTenthAnniversaryWorlds()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				ushort <TileType>k__BackingField = this.<TileType>k__BackingField;
				UnifiedRandom genRand = WorldGen.genRand;
				int num2 = 2;
				if (genRand.Next(num2) != 0)
				{
					ReadOnlyCollection<Rectangle> <Rooms>k__BackingField = this.<Rooms>k__BackingField;
					return;
				}
			}
		}
	}
}
