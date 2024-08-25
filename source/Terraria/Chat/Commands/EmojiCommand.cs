using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Terraria.Localization;

namespace Terraria.Chat.Commands
{
	// Token: 0x020007A2 RID: 1954
	[ChatCommand("Emoji")]
	public class EmojiCommand : IChatCommand
	{
		// Token: 0x06003FC6 RID: 16326 RVA: 0x00241278 File Offset: 0x0023F478
		public EmojiCommand()
		{
			this.Initialize();
		}

		// Token: 0x06003FC7 RID: 16327 RVA: 0x00241294 File Offset: 0x0023F494
		public void Initialize()
		{
			int num = 1;
			Dictionary<LocalizedText, int> byName = this._byName;
			long num2 = 0L;
			if (num == 0)
			{
			}
			LocalizedText emojiName = Lang.GetEmojiName((int)num2);
			Dictionary<LocalizedText, int> byName2 = this._byName;
		}

		// Token: 0x06003FC8 RID: 16328 RVA: 0x002412C0 File Offset: 0x0023F4C0
		public void ProcessIncomingMessage(string text, byte clientId)
		{
		}

		// Token: 0x06003FC9 RID: 16329 RVA: 0x002412D0 File Offset: 0x0023F4D0
		public void ProcessOutgoingMessage(ChatMessage message)
		{
			string <Text>k__BackingField = message.<Text>k__BackingField;
		}

		// Token: 0x06003FCA RID: 16330 RVA: 0x000021DB File Offset: 0x000003DB
		public void PrintWarning(string text)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x04007DD0 RID: 32208
		public const int PlayerEmojiDuration = 360;

		// Token: 0x04007DD1 RID: 32209
		private readonly Dictionary<LocalizedText, int> _byName;
	}
}
