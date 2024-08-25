using System;
using Terraria.Achievements;
using Terraria.Audio;
using Terraria.GameContent.UI.Chat;
using Terraria.Localization;

namespace Terraria.Initializers
{
	// Token: 0x02000581 RID: 1409
	public class AchievementInitializer
	{
		// Token: 0x06003464 RID: 13412 RVA: 0x0020332C File Offset: 0x0020152C
		public static void Load()
		{
			if (!true)
			{
			}
			bool netHostOnly = Main.NetHostOnly;
		}

		// Token: 0x06003465 RID: 13413 RVA: 0x00204DBC File Offset: 0x00202FBC
		private static void OnAchievementCompleted(Achievement achievement)
		{
			string text = AchievementTagHandler.GenerateTag(achievement);
			string textValue = Language.GetTextValue("Achievements.Completed", text);
			ActiveSound activeSound;
			if (activeSound != null)
			{
				return;
			}
		}

		// Token: 0x06003466 RID: 13414 RVA: 0x00204DE0 File Offset: 0x00202FE0
		public AchievementInitializer()
		{
		}
	}
}
