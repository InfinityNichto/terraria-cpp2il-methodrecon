using System;
using Terraria.Chat;
using Terraria.Localization;

namespace Terraria.Initializers
{
	// Token: 0x02000589 RID: 1417
	public static class ChatInitializer
	{
		// Token: 0x06003493 RID: 13459 RVA: 0x00209A78 File Offset: 0x00207C78
		public static void Load()
		{
			if (("c" == null || "c" != null) && ("color" == null || "color" != null) && ("i" == null || "i" != null) && ("item" == null || "item" != null) && ("n" == null || "n" != null) && ("name" == null || "name" != null) && ("a" == null || "a" != null) && ("achievement" == null || "achievement" != null) && ("g" == null || "g" != null) && ("glyph" == null || "glyph" != null) && ("ca" == null || "ca" != null) && ("controls axis" == null || "controls axis" != null) && ("cb" == null || "cb" != null) && ("controls button" == null || "controls button" != null) && ("ct" == null || "ct" != null) && ("controls touch" == null || "controls touch" != null))
			{
				ChatCommandProcessor chatCommandProcessor2;
				ChatCommandProcessor chatCommandProcessor = chatCommandProcessor2.AddCommand().AddCommand().AddCommand()
					.AddCommand()
					.AddCommand()
					.AddCommand()
					.AddCommand()
					.AddCommand()
					.AddCommand()
					.AddCommand()
					.AddDefaultCommand();
				ChatInitializer.PrepareAliases();
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06003494 RID: 13460 RVA: 0x00209BD0 File Offset: 0x00207DD0
		public static void PrepareAliases()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			string text2;
			LocalizedText text = Language.GetText("EmojiCommand." + text2);
			LocalizedText text3 = Language.GetText("ChatCommand.Emoji_1");
			if (text3 == null || text3 != null)
			{
				LocalizedText text4 = Language.GetText("EmojiName." + text2);
				if (text4 == null || text4 != null)
				{
					return;
				}
			}
			throw new ArrayTypeMismatchException();
		}
	}
}
