using System;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Chat.Commands
{
	// Token: 0x020007A0 RID: 1952
	[ChatCommand("AllDeath")]
	public class AllDeathCommand : IChatCommand
	{
		// Token: 0x06003FBE RID: 16318 RVA: 0x002411B8 File Offset: 0x0023F3B8
		public void ProcessIncomingMessage(string text, byte clientId)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0 || "LegacyMultiplayer.25" == null)
			{
			}
		}

		// Token: 0x06003FBF RID: 16319 RVA: 0x002411E4 File Offset: 0x0023F3E4
		public void ProcessOutgoingMessage(ChatMessage message)
		{
		}

		// Token: 0x06003FC0 RID: 16320 RVA: 0x002411F4 File Offset: 0x0023F3F4
		public AllDeathCommand()
		{
		}

		// Token: 0x06003FC1 RID: 16321 RVA: 0x00241208 File Offset: 0x0023F408
		// Note: this type is marked as 'beforefieldinit'.
		static AllDeathCommand()
		{
		}

		// Token: 0x04007DCE RID: 32206
		private static readonly Color RESPONSE_COLOR;
	}
}
