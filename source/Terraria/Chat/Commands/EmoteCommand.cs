using System;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Localization;

namespace Terraria.Chat.Commands
{
	// Token: 0x020007A4 RID: 1956
	[ChatCommand("Emote")]
	public class EmoteCommand : IChatCommand
	{
		// Token: 0x06003FCE RID: 16334 RVA: 0x002413A8 File Offset: 0x0023F5A8
		public void ProcessIncomingMessage(string text, byte clientId)
		{
			int num = 1;
			bool flag = text != "";
			if (num == 0)
			{
			}
			NetworkText networkText = NetworkText.FromLiteral(string.Format("*{0} {1}", "", text));
		}

		// Token: 0x06003FCF RID: 16335 RVA: 0x002413E0 File Offset: 0x0023F5E0
		public void ProcessOutgoingMessage(ChatMessage message)
		{
		}

		// Token: 0x06003FD0 RID: 16336 RVA: 0x002413F0 File Offset: 0x0023F5F0
		public EmoteCommand()
		{
		}

		// Token: 0x06003FD1 RID: 16337 RVA: 0x00241404 File Offset: 0x0023F604
		// Note: this type is marked as 'beforefieldinit'.
		static EmoteCommand()
		{
		}

		// Token: 0x04007DD2 RID: 32210
		private static readonly Color RESPONSE_COLOR;
	}
}
