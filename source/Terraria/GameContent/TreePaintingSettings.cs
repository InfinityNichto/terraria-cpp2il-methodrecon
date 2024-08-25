using System;

namespace Terraria.GameContent
{
	// Token: 0x020007D0 RID: 2000
	public class TreePaintingSettings
	{
		// Token: 0x060040B5 RID: 16565 RVA: 0x00243A9C File Offset: 0x00241C9C
		public TreePaintingSettings()
		{
		}

		// Token: 0x04007E60 RID: 32352
		public TreePaintingSettings.TreePaintingSettingsId Id;

		// Token: 0x04007E61 RID: 32353
		public float SpecialGroupMinimalHueValue;

		// Token: 0x04007E62 RID: 32354
		public float SpecialGroupMaximumHueValue;

		// Token: 0x04007E63 RID: 32355
		public float SpecialGroupMinimumSaturationValue;

		// Token: 0x04007E64 RID: 32356
		public float SpecialGroupMaximumSaturationValue;

		// Token: 0x04007E65 RID: 32357
		public float HueTestOffset;

		// Token: 0x04007E66 RID: 32358
		public bool UseSpecialGroups;

		// Token: 0x04007E67 RID: 32359
		public bool UseWallShaderHacks;

		// Token: 0x04007E68 RID: 32360
		public bool InvertSpecialGroupResult;

		// Token: 0x020007D1 RID: 2001
		public enum TreePaintingSettingsId
		{
			// Token: 0x04007E6A RID: 32362
			None,
			// Token: 0x04007E6B RID: 32363
			DefaultDirt,
			// Token: 0x04007E6C RID: 32364
			CullMud,
			// Token: 0x04007E6D RID: 32365
			WoodPurity,
			// Token: 0x04007E6E RID: 32366
			WoodCorruption,
			// Token: 0x04007E6F RID: 32367
			WoodJungle,
			// Token: 0x04007E70 RID: 32368
			WoodHallow,
			// Token: 0x04007E71 RID: 32369
			WoodSnow,
			// Token: 0x04007E72 RID: 32370
			WoodCrimson,
			// Token: 0x04007E73 RID: 32371
			WoodJungleUnderground,
			// Token: 0x04007E74 RID: 32372
			WoodGlowingMushroom,
			// Token: 0x04007E75 RID: 32373
			VanityCherry,
			// Token: 0x04007E76 RID: 32374
			VanityYellowWillow,
			// Token: 0x04007E77 RID: 32375
			GemTree,
			// Token: 0x04007E78 RID: 32376
			PalmTreePurity,
			// Token: 0x04007E79 RID: 32377
			PalmTreeCorruption,
			// Token: 0x04007E7A RID: 32378
			PalmTreeCrimson,
			// Token: 0x04007E7B RID: 32379
			PalmTreeHallow,
			// Token: 0x04007E7C RID: 32380
			Count
		}
	}
}
