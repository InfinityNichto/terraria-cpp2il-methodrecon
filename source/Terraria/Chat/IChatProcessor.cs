using System;

namespace Terraria.Chat
{
	// Token: 0x0200079B RID: 1947
	public interface IChatProcessor
	{
		// Token: 0x06003FB1 RID: 16305
		void ProcessIncomingMessage(ChatMessage message, int clientId);

		// Token: 0x06003FB2 RID: 16306
		ChatMessage CreateOutgoingMessage(string text);
	}
}
