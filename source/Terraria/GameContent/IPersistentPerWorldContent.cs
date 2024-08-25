using System;
using System.IO;

namespace Terraria.GameContent
{
	// Token: 0x020007D7 RID: 2007
	public interface IPersistentPerWorldContent
	{
		// Token: 0x060040D3 RID: 16595
		void Save(BinaryWriter writer);

		// Token: 0x060040D4 RID: 16596
		void Load(BinaryReader reader, int gameVersionSaveWasMadeOn);

		// Token: 0x060040D5 RID: 16597
		void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn);

		// Token: 0x060040D6 RID: 16598
		void Reset();
	}
}
