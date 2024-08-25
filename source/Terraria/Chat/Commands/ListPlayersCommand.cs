using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Localization;

namespace Terraria.Chat.Commands
{
	// Token: 0x020007A6 RID: 1958
	[ChatCommand("Playing")]
	public class ListPlayersCommand : IChatCommand
	{
		// Token: 0x06003FD8 RID: 16344 RVA: 0x002414F8 File Offset: 0x0023F6F8
		public void ProcessIncomingMessage(string text, byte clientId)
		{
			string text2;
			NetworkText networkText = NetworkText.FromLiteral(text2);
		}

		// Token: 0x06003FD9 RID: 16345 RVA: 0x0024150C File Offset: 0x0023F70C
		public void ProcessOutgoingMessage(ChatMessage message)
		{
		}

		// Token: 0x06003FDA RID: 16346 RVA: 0x0024151C File Offset: 0x0023F71C
		public ListPlayersCommand()
		{
		}

		// Token: 0x06003FDB RID: 16347 RVA: 0x00241530 File Offset: 0x0023F730
		// Note: this type is marked as 'beforefieldinit'.
		static ListPlayersCommand()
		{
		}

		// Token: 0x04007DD4 RID: 32212
		private static readonly Color RESPONSE_COLOR;

		// Token: 0x020007A7 RID: 1959
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003FDC RID: 16348 RVA: 0x00241540 File Offset: 0x0023F740
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06003FDD RID: 16349 RVA: 0x00241550 File Offset: 0x0023F750
			public <>c()
			{
			}

			// Token: 0x06003FDE RID: 16350 RVA: 0x00241564 File Offset: 0x0023F764
			internal bool <ProcessIncomingMessage>b__1_0(Player player)
			{
				return player.active;
			}

			// Token: 0x06003FDF RID: 16351 RVA: 0x00241578 File Offset: 0x0023F778
			internal string <ProcessIncomingMessage>b__1_1(Player player)
			{
				return player.name;
			}

			// Token: 0x04007DD5 RID: 32213
			public static readonly ListPlayersCommand.<>c <>9;

			// Token: 0x04007DD6 RID: 32214
			public static Func<Player, bool> <>9__1_0;

			// Token: 0x04007DD7 RID: 32215
			public static Func<Player, string> <>9__1_1;
		}
	}
}
