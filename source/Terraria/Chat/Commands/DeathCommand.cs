using System;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Chat.Commands
{
	// Token: 0x0200079E RID: 1950
	[ChatCommand("Death")]
	public class DeathCommand : IChatCommand
	{
		// Token: 0x06003FB6 RID: 16310 RVA: 0x00241120 File Offset: 0x0023F320
		public void ProcessIncomingMessage(string text, byte clientId)
		{
		}

		// Token: 0x06003FB7 RID: 16311 RVA: 0x00241138 File Offset: 0x0023F338
		public void ProcessOutgoingMessage(ChatMessage message)
		{
		}

		// Token: 0x06003FB8 RID: 16312 RVA: 0x00241148 File Offset: 0x0023F348
		public DeathCommand()
		{
		}

		// Token: 0x06003FB9 RID: 16313 RVA: 0x0024115C File Offset: 0x0023F35C
		// Note: this type is marked as 'beforefieldinit'.
		static DeathCommand()
		{
		}

		// Token: 0x04007DCC RID: 32204
		private static readonly Color RESPONSE_COLOR;
	}
}
