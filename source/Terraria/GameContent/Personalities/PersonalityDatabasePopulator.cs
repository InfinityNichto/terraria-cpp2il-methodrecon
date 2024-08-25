using System;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x02000830 RID: 2096
	public class PersonalityDatabasePopulator
	{
		// Token: 0x060042ED RID: 17133 RVA: 0x0024CDF4 File Offset: 0x0024AFF4
		public void Populate(PersonalityDatabase database)
		{
			this._currentDatabase = database;
			this.Populate_BiomePreferences(database);
		}

		// Token: 0x060042EE RID: 17134 RVA: 0x0024CE10 File Offset: 0x0024B010
		private void Populate_BiomePreferences(PersonalityDatabase database)
		{
		}

		// Token: 0x060042EF RID: 17135 RVA: 0x0024CE20 File Offset: 0x0024B020
		public PersonalityDatabasePopulator()
		{
		}

		// Token: 0x04008133 RID: 33075
		private PersonalityDatabase _currentDatabase;
	}
}
