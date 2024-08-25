using System;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Localization;

namespace Terraria.Chat.Commands
{
	// Token: 0x020007A9 RID: 1961
	[ChatCommand("Roll")]
	public class RollCommand : IChatCommand
	{
		// Token: 0x06003FE5 RID: 16357 RVA: 0x0024160C File Offset: 0x0023F80C
		public void ProcessIncomingMessage(string text, byte clientId)
		{
			if (!true)
			{
			}
			NetworkText networkText;
			if (networkText == null || networkText != null)
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06003FE6 RID: 16358 RVA: 0x00241634 File Offset: 0x0023F834
		public void ProcessOutgoingMessage(ChatMessage message)
		{
		}

		// Token: 0x06003FE7 RID: 16359 RVA: 0x00241644 File Offset: 0x0023F844
		public RollCommand()
		{
		}

		// Token: 0x06003FE8 RID: 16360 RVA: 0x00241658 File Offset: 0x0023F858
		// Note: this type is marked as 'beforefieldinit'.
		static RollCommand()
		{
		}

		// Token: 0x04007DD9 RID: 32217
		private static readonly Color RESPONSE_COLOR;
	}
}
