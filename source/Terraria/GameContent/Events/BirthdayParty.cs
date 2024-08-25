using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Terraria.GameContent.Achievements;

namespace Terraria.GameContent.Events
{
	// Token: 0x02000A4C RID: 2636
	public class BirthdayParty
	{
		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x06004DA1 RID: 19873 RVA: 0x00273D90 File Offset: 0x00271F90
		public static bool PartyIsUp
		{
			get
			{
				if (!true)
				{
				}
				return true;
			}
		}

		// Token: 0x06004DA2 RID: 19874 RVA: 0x00273DA4 File Offset: 0x00271FA4
		public static void CheckMorning()
		{
			if (!true)
			{
			}
			BirthdayParty.NaturalAttempt();
		}

		// Token: 0x06004DA3 RID: 19875 RVA: 0x00273DBC File Offset: 0x00271FBC
		public static void CheckNight()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06004DA4 RID: 19876 RVA: 0x00273DE8 File Offset: 0x00271FE8
		private static bool CanNPCParty(NPC n)
		{
			int num = 1;
			if (num == 0 || num == 0 || num != 0)
			{
				return;
			}
		}

		// Token: 0x06004DA5 RID: 19877 RVA: 0x00273E04 File Offset: 0x00272004
		private static void NaturalAttempt()
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool netClientOnly = Main.NetClientOnly;
			if (num == 0)
			{
			}
			bool flag = NPC.AnyNPCs(208);
			if (num == 0)
			{
			}
		}

		// Token: 0x06004DA6 RID: 19878 RVA: 0x00273ED8 File Offset: 0x002720D8
		public static void ToggleManualParty()
		{
			if (!true)
			{
			}
			bool partyIsUp = BirthdayParty.PartyIsUp;
			bool netClientOnly = Main.NetClientOnly;
		}

		// Token: 0x06004DA7 RID: 19879 RVA: 0x00273F10 File Offset: 0x00272110
		private static void CheckForAchievement()
		{
			if (!true)
			{
			}
			bool partyIsUp = BirthdayParty.PartyIsUp;
			AchievementsHelper.NotifyProgressionEvent(25);
		}

		// Token: 0x06004DA8 RID: 19880 RVA: 0x00273F30 File Offset: 0x00272130
		public static void WorldClear()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06004DA9 RID: 19881 RVA: 0x00273F40 File Offset: 0x00272140
		public static void UpdateTime()
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool partyIsUp = BirthdayParty.PartyIsUp;
			if (num == 0)
			{
			}
			bool netHostOnly = Main.NetHostOnly;
			if (num == 0)
			{
			}
			bool partyIsUp2 = BirthdayParty.PartyIsUp;
		}

		// Token: 0x06004DAA RID: 19882 RVA: 0x00273F98 File Offset: 0x00272198
		public BirthdayParty()
		{
		}

		// Token: 0x06004DAB RID: 19883 RVA: 0x00273FAC File Offset: 0x002721AC
		// Note: this type is marked as 'beforefieldinit'.
		static BirthdayParty()
		{
		}

		// Token: 0x0400869B RID: 34459
		public static bool ManualParty;

		// Token: 0x0400869C RID: 34460
		public static bool GenuineParty;

		// Token: 0x0400869D RID: 34461
		public static int PartyDaysOnCooldown;

		// Token: 0x0400869E RID: 34462
		public static List<int> CelebratingNPCs;

		// Token: 0x0400869F RID: 34463
		private static bool _wasCelebrating;

		// Token: 0x02000A4D RID: 2637
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004DAC RID: 19884 RVA: 0x00273FBC File Offset: 0x002721BC
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06004DAD RID: 19885 RVA: 0x00273FCC File Offset: 0x002721CC
			public <>c()
			{
			}

			// Token: 0x06004DAE RID: 19886 RVA: 0x00273FE0 File Offset: 0x002721E0
			internal int <NaturalAttempt>b__10_0(NPC i)
			{
				if (!true)
				{
				}
				int num;
				return num;
			}

			// Token: 0x040086A0 RID: 34464
			public static readonly BirthdayParty.<>c <>9;

			// Token: 0x040086A1 RID: 34465
			public static Func<NPC, int> <>9__10_0;
		}
	}
}
