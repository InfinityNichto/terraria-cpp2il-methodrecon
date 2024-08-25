using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Terraria.Utilities;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x0200087C RID: 2172
	public class CommonDropWithRerolls : CommonDrop
	{
		// Token: 0x060043F7 RID: 17399 RVA: 0x0024EEE4 File Offset: 0x0024D0E4
		public CommonDropWithRerolls(int itemId, int chanceDenominator, int amountDroppedMinimum, int amountDroppedMaximum, int rerolls)
		{
			int num = 1;
			base..ctor(itemId, chanceDenominator, amountDroppedMinimum, amountDroppedMaximum, num);
		}

		// Token: 0x060043F8 RID: 17400 RVA: 0x0024EF00 File Offset: 0x0024D100
		public override ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
		{
			int num = this.timesToRoll;
			Player player = info.player;
			int chanceDenominator = this.chanceDenominator;
			long num2 = 0L;
			int num3 = player.RollLuck(chanceDenominator);
			int chanceNumerator = this.chanceNumerator;
			int num4 = this.timesToRoll;
			if (chanceNumerator != 0)
			{
				int amountDroppedMinimum = this.amountDroppedMinimum;
				int chanceNumerator2 = this.chanceNumerator;
				UnifiedRandom rng = info.rng;
				int itemId = this.itemId;
				int num5 = rng.Next(amountDroppedMinimum, (int)num2);
				return;
			}
		}

		// Token: 0x060043F9 RID: 17401 RVA: 0x000021DB File Offset: 0x000003DB
		public override void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x040081C4 RID: 33220
		public int timesToRoll;
	}
}
