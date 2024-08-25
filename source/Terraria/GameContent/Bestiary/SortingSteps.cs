using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Terraria.DataStructures;
using Terraria.Localization;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x0200092D RID: 2349
	public static class SortingSteps
	{
		// Token: 0x0200092E RID: 2350
		public class ByNetId : IBestiarySortStep, IEntrySortStep<BestiaryEntry>, IComparer<BestiaryEntry>
		{
			// Token: 0x1700081B RID: 2075
			// (get) Token: 0x0600472F RID: 18223 RVA: 0x0025E094 File Offset: 0x0025C294
			public bool HiddenFromSortOptions
			{
				get
				{
					return true;
				}
			}

			// Token: 0x06004730 RID: 18224 RVA: 0x0025E0A4 File Offset: 0x0025C2A4
			public int Compare(BestiaryEntry x, BestiaryEntry y)
			{
				int num = 1;
				List<IBestiaryInfoElement> <Info>k__BackingField = x.<Info>k__BackingField;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				if (<Info>k__BackingField != null)
				{
				}
				long num2 = 0L;
				List<IBestiaryInfoElement> <Info>k__BackingField2 = y.<Info>k__BackingField;
				if (<Info>k__BackingField == null)
				{
				}
				if (<Info>k__BackingField2 != null)
				{
				}
				long num3 = 0L;
				int num4;
				if (num2 == 0L)
				{
					return num4;
				}
				if (num3 != 0L)
				{
					return num4;
				}
				return num4;
			}

			// Token: 0x06004731 RID: 18225 RVA: 0x0025E0E8 File Offset: 0x0025C2E8
			public string GetDisplayNameKey()
			{
				return "BestiaryInfo.Sort_ID";
			}

			// Token: 0x06004732 RID: 18226 RVA: 0x0025E0FC File Offset: 0x0025C2FC
			public ByNetId()
			{
			}

			// Token: 0x0200092F RID: 2351
			[CompilerGenerated]
			[Serializable]
			private sealed class <>c
			{
				// Token: 0x06004733 RID: 18227 RVA: 0x00003BB6 File Offset: 0x00001DB6
				// Note: this type is marked as 'beforefieldinit'.
				static <>c()
				{
				}

				// Token: 0x06004734 RID: 18228 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public <>c()
				{
				}

				// Token: 0x06004735 RID: 18229 RVA: 0x0025E110 File Offset: 0x0025C310
				internal bool <Compare>b__2_0(IBestiaryInfoElement element)
				{
					return default(bool);
				}

				// Token: 0x06004736 RID: 18230 RVA: 0x0025E128 File Offset: 0x0025C328
				internal bool <Compare>b__2_1(IBestiaryInfoElement element)
				{
					return default(bool);
				}

				// Token: 0x04008350 RID: 33616
				public static readonly SortingSteps.ByNetId.<>c <>9;

				// Token: 0x04008351 RID: 33617
				public static Func<IBestiaryInfoElement, bool> <>9__2_0;

				// Token: 0x04008352 RID: 33618
				public static Func<IBestiaryInfoElement, bool> <>9__2_1;
			}
		}

		// Token: 0x02000930 RID: 2352
		public class ByUnlockState : IBestiarySortStep, IEntrySortStep<BestiaryEntry>, IComparer<BestiaryEntry>
		{
			// Token: 0x1700081C RID: 2076
			// (get) Token: 0x06004737 RID: 18231 RVA: 0x0025E140 File Offset: 0x0025C340
			public bool HiddenFromSortOptions
			{
				get
				{
					return true;
				}
			}

			// Token: 0x06004738 RID: 18232 RVA: 0x0025E150 File Offset: 0x0025C350
			public int Compare(BestiaryEntry x, BestiaryEntry y)
			{
				IBestiaryUICollectionInfoProvider uiinfoProvider = x.UIInfoProvider;
				IBestiaryUICollectionInfoProvider uiinfoProvider2 = y.UIInfoProvider;
				IEntryIcon icon = y.Icon;
				IEntryIcon icon2 = x.Icon;
				int num;
				return num;
			}

			// Token: 0x06004739 RID: 18233 RVA: 0x0025E17C File Offset: 0x0025C37C
			public string GetDisplayNameKey()
			{
				return "BestiaryInfo.Sort_Unlocks";
			}

			// Token: 0x0600473A RID: 18234 RVA: 0x0025E190 File Offset: 0x0025C390
			public ByUnlockState()
			{
			}
		}

		// Token: 0x02000931 RID: 2353
		public class ByBestiarySortingId : IBestiarySortStep, IEntrySortStep<BestiaryEntry>, IComparer<BestiaryEntry>
		{
			// Token: 0x1700081D RID: 2077
			// (get) Token: 0x0600473B RID: 18235 RVA: 0x0025E1A4 File Offset: 0x0025C3A4
			public bool HiddenFromSortOptions
			{
				get
				{
				}
			}

			// Token: 0x0600473C RID: 18236 RVA: 0x0025E1B4 File Offset: 0x0025C3B4
			public int Compare(BestiaryEntry x, BestiaryEntry y)
			{
				int num = 1;
				List<IBestiaryInfoElement> <Info>k__BackingField = x.<Info>k__BackingField;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				if (<Info>k__BackingField != null)
				{
				}
				long num2 = 0L;
				List<IBestiaryInfoElement> <Info>k__BackingField2 = y.<Info>k__BackingField;
				if (<Info>k__BackingField == null)
				{
				}
				if (<Info>k__BackingField2 != null)
				{
				}
				long num3 = 0L;
				int num4;
				if (num2 == 0L)
				{
					return num4;
				}
				if (num3 != 0L)
				{
					return num4;
				}
				return num4;
			}

			// Token: 0x0600473D RID: 18237 RVA: 0x0025E1F8 File Offset: 0x0025C3F8
			public string GetDisplayNameKey()
			{
				return "BestiaryInfo.Sort_BestiaryID";
			}

			// Token: 0x0600473E RID: 18238 RVA: 0x0025E20C File Offset: 0x0025C40C
			public ByBestiarySortingId()
			{
			}

			// Token: 0x02000932 RID: 2354
			[CompilerGenerated]
			[Serializable]
			private sealed class <>c
			{
				// Token: 0x0600473F RID: 18239 RVA: 0x00003BB6 File Offset: 0x00001DB6
				// Note: this type is marked as 'beforefieldinit'.
				static <>c()
				{
				}

				// Token: 0x06004740 RID: 18240 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public <>c()
				{
				}

				// Token: 0x06004741 RID: 18241 RVA: 0x0025E220 File Offset: 0x0025C420
				internal bool <Compare>b__2_0(IBestiaryInfoElement element)
				{
					return default(bool);
				}

				// Token: 0x06004742 RID: 18242 RVA: 0x0025E238 File Offset: 0x0025C438
				internal bool <Compare>b__2_1(IBestiaryInfoElement element)
				{
					return default(bool);
				}

				// Token: 0x04008353 RID: 33619
				public static readonly SortingSteps.ByBestiarySortingId.<>c <>9;

				// Token: 0x04008354 RID: 33620
				public static Func<IBestiaryInfoElement, bool> <>9__2_0;

				// Token: 0x04008355 RID: 33621
				public static Func<IBestiaryInfoElement, bool> <>9__2_1;
			}
		}

		// Token: 0x02000933 RID: 2355
		public class ByBestiaryRarity : IBestiarySortStep, IEntrySortStep<BestiaryEntry>, IComparer<BestiaryEntry>
		{
			// Token: 0x1700081E RID: 2078
			// (get) Token: 0x06004743 RID: 18243 RVA: 0x0025E250 File Offset: 0x0025C450
			public bool HiddenFromSortOptions
			{
				get
				{
				}
			}

			// Token: 0x06004744 RID: 18244 RVA: 0x0025E260 File Offset: 0x0025C460
			public int Compare(BestiaryEntry x, BestiaryEntry y)
			{
				int num = 1;
				List<IBestiaryInfoElement> <Info>k__BackingField = x.<Info>k__BackingField;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				if (<Info>k__BackingField != null)
				{
				}
				long num2 = 0L;
				List<IBestiaryInfoElement> <Info>k__BackingField2 = y.<Info>k__BackingField;
				if (<Info>k__BackingField == null)
				{
				}
				if (<Info>k__BackingField2 != null)
				{
				}
				long num3 = 0L;
				int num4;
				if (num2 == 0L)
				{
					return num4;
				}
				if (num3 != 0L)
				{
					return num4;
				}
				return num4;
			}

			// Token: 0x06004745 RID: 18245 RVA: 0x0025E2A4 File Offset: 0x0025C4A4
			public string GetDisplayNameKey()
			{
				return "BestiaryInfo.Sort_Rarity";
			}

			// Token: 0x06004746 RID: 18246 RVA: 0x0025E2B8 File Offset: 0x0025C4B8
			public ByBestiaryRarity()
			{
			}

			// Token: 0x02000934 RID: 2356
			[CompilerGenerated]
			[Serializable]
			private sealed class <>c
			{
				// Token: 0x06004747 RID: 18247 RVA: 0x00003BB6 File Offset: 0x00001DB6
				// Note: this type is marked as 'beforefieldinit'.
				static <>c()
				{
				}

				// Token: 0x06004748 RID: 18248 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public <>c()
				{
				}

				// Token: 0x06004749 RID: 18249 RVA: 0x0025E2CC File Offset: 0x0025C4CC
				internal bool <Compare>b__2_0(IBestiaryInfoElement element)
				{
					return default(bool);
				}

				// Token: 0x0600474A RID: 18250 RVA: 0x0025E2E4 File Offset: 0x0025C4E4
				internal bool <Compare>b__2_1(IBestiaryInfoElement element)
				{
					return default(bool);
				}

				// Token: 0x04008356 RID: 33622
				public static readonly SortingSteps.ByBestiaryRarity.<>c <>9;

				// Token: 0x04008357 RID: 33623
				public static Func<IBestiaryInfoElement, bool> <>9__2_0;

				// Token: 0x04008358 RID: 33624
				public static Func<IBestiaryInfoElement, bool> <>9__2_1;
			}
		}

		// Token: 0x02000935 RID: 2357
		public class Alphabetical : IBestiarySortStep, IEntrySortStep<BestiaryEntry>, IComparer<BestiaryEntry>
		{
			// Token: 0x1700081F RID: 2079
			// (get) Token: 0x0600474B RID: 18251 RVA: 0x0025E2FC File Offset: 0x0025C4FC
			public bool HiddenFromSortOptions
			{
				get
				{
				}
			}

			// Token: 0x0600474C RID: 18252 RVA: 0x0025E30C File Offset: 0x0025C50C
			public int Compare(BestiaryEntry x, BestiaryEntry y)
			{
				int num = 1;
				List<IBestiaryInfoElement> <Info>k__BackingField = x.<Info>k__BackingField;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				if (<Info>k__BackingField != null)
				{
				}
				long num2 = 0L;
				List<IBestiaryInfoElement> <Info>k__BackingField2 = y.<Info>k__BackingField;
				if (<Info>k__BackingField == null)
				{
				}
				if (<Info>k__BackingField2 != null)
				{
				}
				long num3 = 0L;
				int num4;
				if (num2 == 0L)
				{
					return num4;
				}
				if (num3 != 0L)
				{
					string text;
					string textValue = Language.GetTextValue(text);
					string text2;
					string textValue2 = Language.GetTextValue(text2);
					num4 = textValue.CompareTo(textValue2);
					return num4;
				}
				return num4;
			}

			// Token: 0x0600474D RID: 18253 RVA: 0x0025E36C File Offset: 0x0025C56C
			public string GetDisplayNameKey()
			{
				return "BestiaryInfo.Sort_Alphabetical";
			}

			// Token: 0x0600474E RID: 18254 RVA: 0x0025E380 File Offset: 0x0025C580
			public Alphabetical()
			{
			}

			// Token: 0x02000936 RID: 2358
			[CompilerGenerated]
			[Serializable]
			private sealed class <>c
			{
				// Token: 0x0600474F RID: 18255 RVA: 0x00003BB6 File Offset: 0x00001DB6
				// Note: this type is marked as 'beforefieldinit'.
				static <>c()
				{
				}

				// Token: 0x06004750 RID: 18256 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public <>c()
				{
				}

				// Token: 0x06004751 RID: 18257 RVA: 0x0025E394 File Offset: 0x0025C594
				internal bool <Compare>b__2_0(IBestiaryInfoElement element)
				{
					return default(bool);
				}

				// Token: 0x06004752 RID: 18258 RVA: 0x0025E3AC File Offset: 0x0025C5AC
				internal bool <Compare>b__2_1(IBestiaryInfoElement element)
				{
					return default(bool);
				}

				// Token: 0x04008359 RID: 33625
				public static readonly SortingSteps.Alphabetical.<>c <>9;

				// Token: 0x0400835A RID: 33626
				public static Func<IBestiaryInfoElement, bool> <>9__2_0;

				// Token: 0x0400835B RID: 33627
				public static Func<IBestiaryInfoElement, bool> <>9__2_1;
			}
		}

		// Token: 0x02000937 RID: 2359
		public abstract class ByStat : IBestiarySortStep, IEntrySortStep<BestiaryEntry>, IComparer<BestiaryEntry>
		{
			// Token: 0x17000820 RID: 2080
			// (get) Token: 0x06004753 RID: 18259 RVA: 0x0025E3C4 File Offset: 0x0025C5C4
			public bool HiddenFromSortOptions
			{
				get
				{
				}
			}

			// Token: 0x06004754 RID: 18260 RVA: 0x0025E3D4 File Offset: 0x0025C5D4
			public int Compare(BestiaryEntry x, BestiaryEntry y)
			{
				/*
An exception occurred when decompiling this method (06004754)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.GameContent.Bestiary.SortingSteps/ByStat::Compare(Terraria.GameContent.Bestiary.BestiaryEntry,Terraria.GameContent.Bestiary.BestiaryEntry)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001A:
	brtrue(IL_001A, ldloc:int64[exp:bool](var_0_09))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}

			// Token: 0x06004755 RID: 18261
			public abstract int Compare(NPCStatsReportInfoElement cardX, NPCStatsReportInfoElement cardY);

			// Token: 0x06004756 RID: 18262
			public abstract string GetDisplayNameKey();

			// Token: 0x06004757 RID: 18263 RVA: 0x0025E400 File Offset: 0x0025C600
			private bool IsAStatsCardINeed(IBestiaryInfoElement element)
			{
				if (element != null)
				{
					return;
				}
			}

			// Token: 0x06004758 RID: 18264 RVA: 0x0025E414 File Offset: 0x0025C614
			protected ByStat()
			{
			}

			// Token: 0x06004759 RID: 18265 RVA: 0x0025E428 File Offset: 0x0025C628
			[CompilerGenerated]
			private bool <Compare>b__2_0(IBestiaryInfoElement element)
			{
				return this.IsAStatsCardINeed(element);
			}

			// Token: 0x0600475A RID: 18266 RVA: 0x0025E43C File Offset: 0x0025C63C
			[CompilerGenerated]
			private bool <Compare>b__2_1(IBestiaryInfoElement element)
			{
				return this.IsAStatsCardINeed(element);
			}
		}

		// Token: 0x02000938 RID: 2360
		public class ByAttack : SortingSteps.ByStat
		{
			// Token: 0x0600475B RID: 18267 RVA: 0x0025E450 File Offset: 0x0025C650
			public override int Compare(NPCStatsReportInfoElement cardX, NPCStatsReportInfoElement cardY)
			{
				int damage = cardX.Damage;
				int num;
				return num;
			}

			// Token: 0x0600475C RID: 18268 RVA: 0x0025E468 File Offset: 0x0025C668
			public override string GetDisplayNameKey()
			{
				return "BestiaryInfo.Sort_Attack";
			}

			// Token: 0x0600475D RID: 18269 RVA: 0x0025E47C File Offset: 0x0025C67C
			public ByAttack()
			{
			}
		}

		// Token: 0x02000939 RID: 2361
		public class ByDefense : SortingSteps.ByStat
		{
			// Token: 0x0600475E RID: 18270 RVA: 0x0025E490 File Offset: 0x0025C690
			public override int Compare(NPCStatsReportInfoElement cardX, NPCStatsReportInfoElement cardY)
			{
				int defense = cardX.Defense;
				int num;
				return num;
			}

			// Token: 0x0600475F RID: 18271 RVA: 0x0025E4A8 File Offset: 0x0025C6A8
			public override string GetDisplayNameKey()
			{
				return "BestiaryInfo.Sort_Defense";
			}

			// Token: 0x06004760 RID: 18272 RVA: 0x0025E4BC File Offset: 0x0025C6BC
			public ByDefense()
			{
			}
		}

		// Token: 0x0200093A RID: 2362
		public class ByCoins : SortingSteps.ByStat
		{
			// Token: 0x06004761 RID: 18273 RVA: 0x0025E4D0 File Offset: 0x0025C6D0
			public override int Compare(NPCStatsReportInfoElement cardX, NPCStatsReportInfoElement cardY)
			{
				float monetaryValue = cardX.MonetaryValue;
				int num;
				return num;
			}

			// Token: 0x06004762 RID: 18274 RVA: 0x0025E4E8 File Offset: 0x0025C6E8
			public override string GetDisplayNameKey()
			{
				return "BestiaryInfo.Sort_Coins";
			}

			// Token: 0x06004763 RID: 18275 RVA: 0x0025E4FC File Offset: 0x0025C6FC
			public ByCoins()
			{
			}
		}

		// Token: 0x0200093B RID: 2363
		public class ByHP : SortingSteps.ByStat
		{
			// Token: 0x06004764 RID: 18276 RVA: 0x0025E510 File Offset: 0x0025C710
			public override int Compare(NPCStatsReportInfoElement cardX, NPCStatsReportInfoElement cardY)
			{
				int lifeMax = cardX.LifeMax;
				int num;
				return num;
			}

			// Token: 0x06004765 RID: 18277 RVA: 0x0025E528 File Offset: 0x0025C728
			public override string GetDisplayNameKey()
			{
				return "BestiaryInfo.Sort_HitPoints";
			}

			// Token: 0x06004766 RID: 18278 RVA: 0x0025E53C File Offset: 0x0025C73C
			public ByHP()
			{
			}
		}
	}
}
