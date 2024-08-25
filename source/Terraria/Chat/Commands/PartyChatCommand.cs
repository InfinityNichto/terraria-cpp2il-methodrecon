using System;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Localization;

namespace Terraria.Chat.Commands
{
	// Token: 0x020007A8 RID: 1960
	[ChatCommand("Party")]
	public class PartyChatCommand : IChatCommand
	{
		// Token: 0x06003FE0 RID: 16352 RVA: 0x0024158C File Offset: 0x0023F78C
		public void ProcessIncomingMessage(string text, byte clientId)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool flag = text == "";
			if (num == 0)
			{
			}
			if (num != 0)
			{
				if ("" == null)
				{
				}
				NetworkText networkText = NetworkText.FromLiteral(text);
				if ("" == null)
				{
				}
			}
		}

		// Token: 0x06003FE1 RID: 16353 RVA: 0x002415C8 File Offset: 0x0023F7C8
		public void ProcessOutgoingMessage(ChatMessage message)
		{
		}

		// Token: 0x06003FE2 RID: 16354 RVA: 0x002415D8 File Offset: 0x0023F7D8
		private void SendNoTeamError(byte clientId)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003FE3 RID: 16355 RVA: 0x002415E8 File Offset: 0x0023F7E8
		public PartyChatCommand()
		{
		}

		// Token: 0x06003FE4 RID: 16356 RVA: 0x002415FC File Offset: 0x0023F7FC
		// Note: this type is marked as 'beforefieldinit'.
		static PartyChatCommand()
		{
		}

		// Token: 0x04007DD8 RID: 32216
		private static readonly Color ERROR_COLOR;
	}
}
