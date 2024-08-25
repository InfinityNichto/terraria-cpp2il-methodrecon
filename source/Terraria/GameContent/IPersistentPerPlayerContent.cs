using System;
using System.IO;

namespace Terraria.GameContent
{
	// Token: 0x020007D8 RID: 2008
	public interface IPersistentPerPlayerContent
	{
		// Token: 0x060040D7 RID: 16599
		void Save(Player player, BinaryWriter writer);

		// Token: 0x060040D8 RID: 16600
		void Load(Player player, BinaryReader reader, int gameVersionSaveWasMadeOn);

		// Token: 0x060040D9 RID: 16601
		void ApplyLoadedDataToOutOfPlayerFields(Player player);

		// Token: 0x060040DA RID: 16602
		void ResetDataForNewPlayer(Player player);

		// Token: 0x060040DB RID: 16603
		void Reset();
	}
}
