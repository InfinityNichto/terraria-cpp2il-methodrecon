using System;

namespace Terraria.GameContent.Events
{
	// Token: 0x02000A50 RID: 2640
	public class LanternNight
	{
		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x06004DF6 RID: 19958 RVA: 0x00275558 File Offset: 0x00273758
		public static bool LanternsUp
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06004DF7 RID: 19959 RVA: 0x00275568 File Offset: 0x00273768
		public static void CheckMorning()
		{
		}

		// Token: 0x06004DF8 RID: 19960 RVA: 0x00275578 File Offset: 0x00273778
		public static void CheckNight()
		{
			LanternNight.NaturalAttempt();
		}

		// Token: 0x06004DF9 RID: 19961 RVA: 0x0027558C File Offset: 0x0027378C
		public static bool LanternsCanPersist()
		{
			if (!true)
			{
			}
			if (true)
			{
			}
			return LanternNight.LanternsCanStart();
		}

		// Token: 0x06004DFA RID: 19962 RVA: 0x002755A8 File Offset: 0x002737A8
		public static bool LanternsCanStart()
		{
			if (!true)
			{
			}
			return LanternNight.BossIsActive();
		}

		// Token: 0x06004DFB RID: 19963 RVA: 0x002755C0 File Offset: 0x002737C0
		private static bool BossIsActive()
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06004DFC RID: 19964 RVA: 0x002755D8 File Offset: 0x002737D8
		private static void NaturalAttempt()
		{
			if (!true)
			{
			}
			bool netClientOnly = Main.NetClientOnly;
			bool flag = LanternNight.LanternsCanStart();
		}

		// Token: 0x06004DFD RID: 19965 RVA: 0x002755FC File Offset: 0x002737FC
		public static void ToggleManualLanterns()
		{
			bool lanternsUp = LanternNight.LanternsUp;
			bool logicHost = Main.LogicHost;
			bool lanternsUp2 = LanternNight.LanternsUp;
			bool netHost = Main.NetHost;
		}

		// Token: 0x06004DFE RID: 19966 RVA: 0x00275628 File Offset: 0x00273828
		public static void WorldClear()
		{
		}

		// Token: 0x06004DFF RID: 19967 RVA: 0x00275638 File Offset: 0x00273838
		public static void UpdateTime()
		{
			bool flag = LanternNight.LanternsCanPersist();
			bool lanternsUp = LanternNight.LanternsUp;
			bool logicClient = Main.LogicClient;
			bool lanternsUp2 = LanternNight.LanternsUp;
		}

		// Token: 0x06004E00 RID: 19968 RVA: 0x00275674 File Offset: 0x00273874
		public LanternNight()
		{
		}

		// Token: 0x040086BE RID: 34494
		public static bool ManualLanterns;

		// Token: 0x040086BF RID: 34495
		public static bool GenuineLanterns;

		// Token: 0x040086C0 RID: 34496
		public static bool NextNightIsLanternNight;

		// Token: 0x040086C1 RID: 34497
		public static int LanternNightsOnCooldown;

		// Token: 0x040086C2 RID: 34498
		private static bool _wasLanternNight;
	}
}
