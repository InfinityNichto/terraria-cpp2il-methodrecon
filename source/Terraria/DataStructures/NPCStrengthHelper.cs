using System;

namespace Terraria.DataStructures
{
	// Token: 0x0200062C RID: 1580
	public struct NPCStrengthHelper
	{
		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x0600361D RID: 13853 RVA: 0x002122FC File Offset: 0x002104FC
		public bool IsExpertMode
		{
			get
			{
				float gameModeDifficulty = this._gameModeDifficulty;
				return true;
			}
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x0600361E RID: 13854 RVA: 0x00212314 File Offset: 0x00210514
		public bool IsMasterMode
		{
			get
			{
				float gameModeDifficulty = this._gameModeDifficulty;
				return true;
			}
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x0600361F RID: 13855 RVA: 0x0021232C File Offset: 0x0021052C
		public bool ExtraDamageForGetGoodWorld
		{
			get
			{
				float gameModeDifficulty = this._gameModeDifficulty;
				return true;
			}
		}

		// Token: 0x06003620 RID: 13856 RVA: 0x00212344 File Offset: 0x00210544
		public NPCStrengthHelper(GameModeData data, float strength, bool isGetGoodWorld)
		{
			this._gameModeData = data;
			this._gameModeDifficulty = (float)16256;
			bool <IsExpertMode>k__BackingField = data.<IsExpertMode>k__BackingField;
			if (!data.<IsMasterMode>k__BackingField)
			{
				return;
			}
		}

		// Token: 0x040076E3 RID: 30435
		private float _strengthOverride;

		// Token: 0x040076E4 RID: 30436
		private float _gameModeDifficulty;

		// Token: 0x040076E5 RID: 30437
		private GameModeData _gameModeData;
	}
}
