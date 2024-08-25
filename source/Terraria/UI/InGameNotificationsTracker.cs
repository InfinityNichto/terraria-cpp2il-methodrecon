using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Achievements;
using Terraria.GameInput;
using Terraria.Social.Base;

namespace Terraria.UI
{
	// Token: 0x020006E0 RID: 1760
	public class InGameNotificationsTracker
	{
		// Token: 0x06003B14 RID: 15124 RVA: 0x002341FC File Offset: 0x002323FC
		public static void Initialize()
		{
			if (!true)
			{
			}
			AchievementManager achievements = Main.Achievements;
		}

		// Token: 0x06003B15 RID: 15125 RVA: 0x0023421C File Offset: 0x0023241C
		private static void JoinRequests_OnRequestAdded(UserJoinToServerRequest request)
		{
			if (!true)
			{
			}
			InGameNotificationsTracker.AddJoinRequest(request);
		}

		// Token: 0x06003B16 RID: 15126 RVA: 0x00234234 File Offset: 0x00232434
		private static void JoinRequests_OnRequestRemoved(UserJoinToServerRequest request)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003B17 RID: 15127 RVA: 0x00234248 File Offset: 0x00232448
		public static void DrawInGame(SpriteBatch sb)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int screenHeight = Main.screenHeight;
			if (num == 0)
			{
			}
			bool usingGamepad = PlayerInput.UsingGamepad;
		}

		// Token: 0x06003B18 RID: 15128 RVA: 0x00234288 File Offset: 0x00232488
		public static void DrawInIngameOptions(SpriteBatch spriteBatch, Rectangle area, int gamepadPointIdLocalIndexToUse)
		{
			int num = 1;
			int num2 = 26215;
			if (num == 0)
			{
			}
			if (num2 != 0)
			{
			}
		}

		// Token: 0x06003B19 RID: 15129 RVA: 0x002342CC File Offset: 0x002324CC
		public static void AddCompleted(Achievement achievement)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool netHost = Main.NetHost;
			if (num == 0)
			{
			}
		}

		// Token: 0x06003B1A RID: 15130 RVA: 0x002342EC File Offset: 0x002324EC
		public static void AddJoinRequest(UserJoinToServerRequest request)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool netHost = Main.NetHost;
			if (num == 0)
			{
			}
		}

		// Token: 0x06003B1B RID: 15131 RVA: 0x0023430C File Offset: 0x0023250C
		public static void Clear()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003B1C RID: 15132 RVA: 0x00234320 File Offset: 0x00232520
		public static void Update()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003B1D RID: 15133 RVA: 0x00234338 File Offset: 0x00232538
		public InGameNotificationsTracker()
		{
		}

		// Token: 0x06003B1E RID: 15134 RVA: 0x0023434C File Offset: 0x0023254C
		// Note: this type is marked as 'beforefieldinit'.
		static InGameNotificationsTracker()
		{
		}

		// Token: 0x04007AF3 RID: 31475
		private static List<IInGameNotification> _notifications;
	}
}
