using System;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Chat.Commands
{
	// Token: 0x020007A1 RID: 1953
	[ChatCommand("AllPVPDeath")]
	public class AllPVPDeathCommand : IChatCommand
	{
		// Token: 0x06003FC2 RID: 16322 RVA: 0x00241218 File Offset: 0x0023F418
		public void ProcessIncomingMessage(string text, byte clientId)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0 || "LegacyMultiplayer.26" == null)
			{
			}
		}

		// Token: 0x06003FC3 RID: 16323 RVA: 0x00241244 File Offset: 0x0023F444
		public void ProcessOutgoingMessage(ChatMessage message)
		{
		}

		// Token: 0x06003FC4 RID: 16324 RVA: 0x00241254 File Offset: 0x0023F454
		public AllPVPDeathCommand()
		{
		}

		// Token: 0x06003FC5 RID: 16325 RVA: 0x00241268 File Offset: 0x0023F468
		// Note: this type is marked as 'beforefieldinit'.
		static AllPVPDeathCommand()
		{
		}

		// Token: 0x04007DCF RID: 32207
		private static readonly Color RESPONSE_COLOR;
	}
}
