using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x0200088B RID: 2187
	public static class Chains
	{
		// Token: 0x0600444B RID: 17483 RVA: 0x0024F92C File Offset: 0x0024DB2C
		public static void ReportDroprates(List<IItemDropRuleChainAttempt> ChainedRules, float personalDropRate, List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
		{
		}

		// Token: 0x0600444C RID: 17484 RVA: 0x0024F950 File Offset: 0x0024DB50
		public static IItemDropRule OnFailedRoll(this IItemDropRule rule, IItemDropRule ruleToChain, bool hideLootReport = false)
		{
			return rule;
		}

		// Token: 0x0600444D RID: 17485 RVA: 0x0024F960 File Offset: 0x0024DB60
		public static IItemDropRule OnSuccess(this IItemDropRule rule, IItemDropRule ruleToChain, bool hideLootReport = false)
		{
			return rule;
		}

		// Token: 0x0600444E RID: 17486 RVA: 0x0024F970 File Offset: 0x0024DB70
		public static IItemDropRule OnFailedConditions(this IItemDropRule rule, IItemDropRule ruleToChain, bool hideLootReport = false)
		{
			return rule;
		}

		// Token: 0x0200088C RID: 2188
		public class TryIfFailedRandomRoll : IItemDropRuleChainAttempt
		{
			// Token: 0x170007E1 RID: 2017
			// (get) Token: 0x0600444F RID: 17487 RVA: 0x0024F980 File Offset: 0x0024DB80
			// (set) Token: 0x06004450 RID: 17488 RVA: 0x0024F994 File Offset: 0x0024DB94
			public IItemDropRule RuleToChain
			{
				[CompilerGenerated]
				get
				{
					return this.<RuleToChain>k__BackingField;
				}
				[CompilerGenerated]
				private set
				{
					this.<RuleToChain>k__BackingField = value;
				}
			}

			// Token: 0x06004451 RID: 17489 RVA: 0x0024F9A8 File Offset: 0x0024DBA8
			public TryIfFailedRandomRoll(IItemDropRule rule, bool hideLootReport = false)
			{
			}

			// Token: 0x06004452 RID: 17490 RVA: 0x000021DB File Offset: 0x000003DB
			public bool CanChainIntoRule(ItemDropAttemptResult parentResult)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06004453 RID: 17491 RVA: 0x0024F9BC File Offset: 0x0024DBBC
			public void ReportDroprates(float personalDropRate, List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
			{
				if (!this.hideLootReport)
				{
					IItemDropRule itemDropRule = this.<RuleToChain>k__BackingField;
					return;
				}
			}

			// Token: 0x040081F0 RID: 33264
			[CompilerGenerated]
			private IItemDropRule <RuleToChain>k__BackingField;

			// Token: 0x040081F1 RID: 33265
			public bool hideLootReport;
		}

		// Token: 0x0200088D RID: 2189
		public class TryIfSucceeded : IItemDropRuleChainAttempt
		{
			// Token: 0x170007E2 RID: 2018
			// (get) Token: 0x06004454 RID: 17492 RVA: 0x0024F9DC File Offset: 0x0024DBDC
			// (set) Token: 0x06004455 RID: 17493 RVA: 0x0024F9F0 File Offset: 0x0024DBF0
			public IItemDropRule RuleToChain
			{
				[CompilerGenerated]
				get
				{
					return this.<RuleToChain>k__BackingField;
				}
				[CompilerGenerated]
				private set
				{
					this.<RuleToChain>k__BackingField = value;
				}
			}

			// Token: 0x06004456 RID: 17494 RVA: 0x0024FA04 File Offset: 0x0024DC04
			public TryIfSucceeded(IItemDropRule rule, bool hideLootReport = false)
			{
				this.RuleToChain = rule;
			}

			// Token: 0x06004457 RID: 17495 RVA: 0x000021DB File Offset: 0x000003DB
			public bool CanChainIntoRule(ItemDropAttemptResult parentResult)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06004458 RID: 17496 RVA: 0x0024FA20 File Offset: 0x0024DC20
			public void ReportDroprates(float personalDropRate, List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
			{
				if (!this.hideLootReport)
				{
					IItemDropRule itemDropRule = this.<RuleToChain>k__BackingField;
					return;
				}
			}

			// Token: 0x040081F2 RID: 33266
			[CompilerGenerated]
			private IItemDropRule <RuleToChain>k__BackingField;

			// Token: 0x040081F3 RID: 33267
			public bool hideLootReport;
		}

		// Token: 0x0200088E RID: 2190
		public class TryIfDoesntFillConditions : IItemDropRuleChainAttempt
		{
			// Token: 0x170007E3 RID: 2019
			// (get) Token: 0x06004459 RID: 17497 RVA: 0x0024FA40 File Offset: 0x0024DC40
			// (set) Token: 0x0600445A RID: 17498 RVA: 0x0024FA54 File Offset: 0x0024DC54
			public IItemDropRule RuleToChain
			{
				[CompilerGenerated]
				get
				{
					return this.<RuleToChain>k__BackingField;
				}
				[CompilerGenerated]
				private set
				{
					this.<RuleToChain>k__BackingField = value;
				}
			}

			// Token: 0x0600445B RID: 17499 RVA: 0x0024FA68 File Offset: 0x0024DC68
			public TryIfDoesntFillConditions(IItemDropRule rule, bool hideLootReport = false)
			{
				this.RuleToChain = rule;
			}

			// Token: 0x0600445C RID: 17500 RVA: 0x000021DB File Offset: 0x000003DB
			public bool CanChainIntoRule(ItemDropAttemptResult parentResult)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x0600445D RID: 17501 RVA: 0x0024FA84 File Offset: 0x0024DC84
			public void ReportDroprates(float personalDropRate, List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
			{
				if (!this.hideLootReport)
				{
					IItemDropRule itemDropRule = this.<RuleToChain>k__BackingField;
					return;
				}
			}

			// Token: 0x040081F4 RID: 33268
			[CompilerGenerated]
			private IItemDropRule <RuleToChain>k__BackingField;

			// Token: 0x040081F5 RID: 33269
			public bool hideLootReport;
		}
	}
}
