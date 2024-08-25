using System;
using System.IO;

namespace Terraria.GameContent.Creative
{
	// Token: 0x02000A14 RID: 2580
	public class CreativeUnlocksTracker : IPersistentPerWorldContent, IOnPlayerJoining
	{
		// Token: 0x06004C2B RID: 19499 RVA: 0x002715E4 File Offset: 0x0026F7E4
		public void Save(BinaryWriter writer)
		{
			this.ItemSacrifices.Save(writer);
		}

		// Token: 0x06004C2C RID: 19500 RVA: 0x00271600 File Offset: 0x0026F800
		public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
		{
			this.ItemSacrifices.Load(reader, gameVersionSaveWasMadeOn);
		}

		// Token: 0x06004C2D RID: 19501 RVA: 0x0027161C File Offset: 0x0026F81C
		public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
		{
		}

		// Token: 0x06004C2E RID: 19502 RVA: 0x0027162C File Offset: 0x0026F82C
		public void Reset()
		{
			this.ItemSacrifices.Reset();
		}

		// Token: 0x06004C2F RID: 19503 RVA: 0x00271644 File Offset: 0x0026F844
		public void OnPlayerJoining(int playerIndex)
		{
		}

		// Token: 0x06004C30 RID: 19504 RVA: 0x00271654 File Offset: 0x0026F854
		public CreativeUnlocksTracker()
		{
		}

		// Token: 0x0400864D RID: 34381
		public ItemsSacrificedUnlocksTracker ItemSacrifices;
	}
}
