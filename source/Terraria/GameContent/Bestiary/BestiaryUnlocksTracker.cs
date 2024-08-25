using System;
using System.IO;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x0200093C RID: 2364
	public class BestiaryUnlocksTracker : IPersistentPerWorldContent, IOnPlayerJoining
	{
		// Token: 0x06004767 RID: 18279 RVA: 0x0025E550 File Offset: 0x0025C750
		public void Save(BinaryWriter writer)
		{
			this.Kills.Save(writer);
		}

		// Token: 0x06004768 RID: 18280 RVA: 0x0025E56C File Offset: 0x0025C76C
		public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
		{
			this.Kills.Load(reader, gameVersionSaveWasMadeOn);
			this.Sights.Load(reader, gameVersionSaveWasMadeOn);
			this.Chats.Load(reader, gameVersionSaveWasMadeOn);
		}

		// Token: 0x06004769 RID: 18281 RVA: 0x0025E5A0 File Offset: 0x0025C7A0
		public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
		{
		}

		// Token: 0x0600476A RID: 18282 RVA: 0x0025E5B0 File Offset: 0x0025C7B0
		public void Reset()
		{
			this.Kills.Reset();
			this.Sights.Reset();
			this.Chats.Reset();
		}

		// Token: 0x0600476B RID: 18283 RVA: 0x0025E5E0 File Offset: 0x0025C7E0
		public void OnPlayerJoining(int playerIndex)
		{
			this.Kills.OnPlayerJoining(playerIndex);
		}

		// Token: 0x0600476C RID: 18284 RVA: 0x0025E5FC File Offset: 0x0025C7FC
		public void FillBasedOnVersionBefore210()
		{
		}

		// Token: 0x0600476D RID: 18285 RVA: 0x0025E60C File Offset: 0x0025C80C
		public BestiaryUnlocksTracker()
		{
		}

		// Token: 0x0400835C RID: 33628
		public NPCKillsTracker Kills;

		// Token: 0x0400835D RID: 33629
		public NPCWasNearPlayerTracker Sights;

		// Token: 0x0400835E RID: 33630
		public NPCWasChatWithTracker Chats;
	}
}
