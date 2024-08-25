using System;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Chat.Commands
{
	// Token: 0x0200079F RID: 1951
	[ChatCommand("PVPDeath")]
	public class PVPDeathCommand : IChatCommand
	{
		// Token: 0x06003FBA RID: 16314 RVA: 0x0024116C File Offset: 0x0023F36C
		public void ProcessIncomingMessage(string text, byte clientId)
		{
		}

		// Token: 0x06003FBB RID: 16315 RVA: 0x00241184 File Offset: 0x0023F384
		public void ProcessOutgoingMessage(ChatMessage message)
		{
		}

		// Token: 0x06003FBC RID: 16316 RVA: 0x00241194 File Offset: 0x0023F394
		public PVPDeathCommand()
		{
		}

		// Token: 0x06003FBD RID: 16317 RVA: 0x002411A8 File Offset: 0x0023F3A8
		// Note: this type is marked as 'beforefieldinit'.
		static PVPDeathCommand()
		{
		}

		// Token: 0x04007DCD RID: 32205
		private static readonly Color RESPONSE_COLOR;
	}
}
