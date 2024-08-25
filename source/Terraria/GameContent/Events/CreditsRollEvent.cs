using System;
using Cpp2IlInjected;

namespace Terraria.GameContent.Events
{
	// Token: 0x02000A54 RID: 2644
	public class CreditsRollEvent
	{
		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x06004E16 RID: 19990 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool IsEventOngoing
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06004E17 RID: 19991 RVA: 0x00275B6C File Offset: 0x00273D6C
		public static void TryStartingCreditsRoll()
		{
			!0 !;
			if (! != null)
			{
			}
			bool netHost = Main.NetHost;
		}

		// Token: 0x06004E18 RID: 19992 RVA: 0x00275B8C File Offset: 0x00273D8C
		public static void SendCreditsRollRemainingTimeToPlayer(int playerIndex)
		{
			bool netHost = Main.NetHost;
		}

		// Token: 0x06004E19 RID: 19993 RVA: 0x00275BA4 File Offset: 0x00273DA4
		public static void UpdateTime()
		{
		}

		// Token: 0x06004E1A RID: 19994 RVA: 0x00275BB4 File Offset: 0x00273DB4
		public static void Reset()
		{
		}

		// Token: 0x06004E1B RID: 19995 RVA: 0x00275BC4 File Offset: 0x00273DC4
		public static void SetRemainingTimeDirect(int time)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06004E1C RID: 19996 RVA: 0x00275BD4 File Offset: 0x00273DD4
		public CreditsRollEvent()
		{
		}

		// Token: 0x040086D4 RID: 34516
		private const int MAX_TIME_FOR_CREDITS_ROLL_IN_FRAMES = 28800;

		// Token: 0x040086D5 RID: 34517
		private static int _creditsRollRemainingTime;
	}
}
