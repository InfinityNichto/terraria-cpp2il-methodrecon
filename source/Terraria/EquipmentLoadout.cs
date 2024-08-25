using System;
using System.IO;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Terraria
{
	// Token: 0x0200044E RID: 1102
	public class EquipmentLoadout : IFixLoadedData
	{
		// Token: 0x0600296B RID: 10603 RVA: 0x0019B64C File Offset: 0x0019984C
		public EquipmentLoadout()
		{
			Item[] array = this.CreateItemArray(20);
			this.Armor = array;
			Item[] array2;
			this.Dye = array2;
		}

		// Token: 0x0600296C RID: 10604 RVA: 0x0019B678 File Offset: 0x00199878
		private Item[] CreateItemArray(int length)
		{
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600296D RID: 10605 RVA: 0x0019B68C File Offset: 0x0019988C
		public void Serialize(BinaryWriter writer)
		{
			Item[] armor = this.Armor;
			long entityId = armor.entityId;
			Vector2 position = armor.position;
			Item[] armor2 = this.Armor;
			Item[] dye = this.Dye;
			long entityId2 = dye.entityId;
			Vector2 position2 = dye.position;
			Item[] dye2 = this.Dye;
			bool[] hide = this.Hide;
			bool[] hide2 = this.Hide;
		}

		// Token: 0x0600296E RID: 10606 RVA: 0x0019B6F0 File Offset: 0x001998F0
		public void Deserialize(BinaryReader reader, int gameVersion)
		{
			Item[] armor = this.Armor;
			long entityId = armor.entityId;
			Vector2 position = armor.position;
			Item[] armor2 = this.Armor;
			Item[] dye = this.Dye;
			long entityId2 = dye.entityId;
			Vector2 position2 = dye.position;
			Item[] dye2 = this.Dye;
			bool[] hide = this.Hide;
			bool[] hide2 = this.Hide;
		}

		// Token: 0x0600296F RID: 10607 RVA: 0x0019B754 File Offset: 0x00199954
		public void Swap(Player player)
		{
			long entityId = player.armor.entityId;
			Item[] armor = this.Armor;
			if (entityId == 0L)
			{
			}
			long entityId2 = player.dye.entityId;
			Item[] dye = this.Dye;
			if (entityId2 == 0L)
			{
			}
			bool[] hideVisibleAccessory = player.hideVisibleAccessory;
			bool[] hide = this.Hide;
			if (entityId2 == 0L)
			{
			}
		}

		// Token: 0x06002970 RID: 10608 RVA: 0x0019B7A8 File Offset: 0x001999A8
		public void TryDroppingItems(Player player, IEntitySource source)
		{
			Item[] armor = this.Armor;
			long entityId = armor.entityId;
			Vector2 position = armor.position;
			Item[] armor2 = this.Armor;
			Item[] dye = this.Dye;
			long entityId2 = dye.entityId;
			Vector2 position2 = dye.position;
			Item[] dye2 = this.Dye;
		}

		// Token: 0x06002971 RID: 10609 RVA: 0x0019B7F8 File Offset: 0x001999F8
		public void FixLoadedData()
		{
			long entityId = this.Armor.entityId;
			Item[] armor = this.Armor;
			Item[] dye = this.Dye;
			long entityId2 = dye.entityId;
			Vector2 position = dye.position;
			Item[] dye2 = this.Dye;
			Item[] armor2 = this.Armor;
			if (dye2 == null)
			{
			}
			Player.FixLoadedData_EliminiateDuplicateAccessories(armor2);
		}

		// Token: 0x04003690 RID: 13968
		public Item[] Armor;

		// Token: 0x04003691 RID: 13969
		public Item[] Dye;

		// Token: 0x04003692 RID: 13970
		public bool[] Hide;
	}
}
