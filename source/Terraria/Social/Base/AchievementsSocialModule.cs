using System;

namespace Terraria.Social.Base
{
	// Token: 0x02000527 RID: 1319
	public abstract class AchievementsSocialModule : ISocialModule
	{
		// Token: 0x060031B4 RID: 12724
		public abstract void Initialize();

		// Token: 0x060031B5 RID: 12725
		public abstract void Shutdown();

		// Token: 0x060031B6 RID: 12726
		public abstract byte[] GetEncryptionKey();

		// Token: 0x060031B7 RID: 12727
		public abstract string GetSavePath();

		// Token: 0x060031B8 RID: 12728
		public abstract void UpdateIntStat(string name, int value);

		// Token: 0x060031B9 RID: 12729
		public abstract void UpdateFloatStat(string name, float value);

		// Token: 0x060031BA RID: 12730
		public abstract void CompleteAchievement(string name);

		// Token: 0x060031BB RID: 12731
		public abstract bool IsAchievementCompleted(string name);

		// Token: 0x060031BC RID: 12732
		public abstract void StoreStats();

		// Token: 0x060031BD RID: 12733 RVA: 0x001F8D30 File Offset: 0x001F6F30
		protected AchievementsSocialModule()
		{
		}
	}
}
