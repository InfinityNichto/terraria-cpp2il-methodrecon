using System;
using Terraria.Localization;

namespace Terraria.Chat.Commands
{
	// Token: 0x020007AA RID: 1962
	[ChatCommand("Say")]
	public class SayChatCommand : IChatCommand
	{
		// Token: 0x06003FE9 RID: 16361 RVA: 0x00241668 File Offset: 0x0023F868
		public void ProcessIncomingMessage(string text, byte clientId)
		{
			if (!true)
			{
			}
			NetworkText networkText = NetworkText.FromLiteral(text);
			Console.WriteLine("<{0}> {1}", clientId, text);
		}

		// Token: 0x06003FEA RID: 16362 RVA: 0x0024168C File Offset: 0x0023F88C
		public void ProcessOutgoingMessage(ChatMessage message)
		{
		}

		// Token: 0x06003FEB RID: 16363 RVA: 0x0024169C File Offset: 0x0023F89C
		public SayChatCommand()
		{
		}
	}
}
