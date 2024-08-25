using System;

namespace Terraria.Chat.Commands
{
	// Token: 0x0200079D RID: 1949
	public interface IChatCommand
	{
		// Token: 0x06003FB4 RID: 16308
		void ProcessIncomingMessage(string text, byte clientId);

		// Token: 0x06003FB5 RID: 16309
		void ProcessOutgoingMessage(ChatMessage message);
	}
}
