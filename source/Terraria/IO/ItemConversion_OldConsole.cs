using System;

namespace Terraria.IO
{
	// Token: 0x02000578 RID: 1400
	public static class ItemConversion_OldConsole
	{
		// Token: 0x060033FF RID: 13311 RVA: 0x00201468 File Offset: 0x001FF668
		public static bool ModifyItem(short itemId, short itemStack, byte prefix, bool chestConversion = false)
		{
			int num = 60;
			itemStack.m_value = (short)num;
			return false;
		}

		// Token: 0x06003400 RID: 13312 RVA: 0x002014A0 File Offset: 0x001FF6A0
		private static void GetCoinItem(int coinValue, short itemId, short itemStack)
		{
			int num = 74;
			itemId.m_value = (short)num;
		}

		// Token: 0x06003401 RID: 13313 RVA: 0x0020150C File Offset: 0x001FF70C
		public static bool ModifyBodySlot(int slot)
		{
		}

		// Token: 0x06003402 RID: 13314 RVA: 0x0020151C File Offset: 0x001FF71C
		public static bool ModifyHeadSlot(int slot)
		{
		}

		// Token: 0x06003403 RID: 13315 RVA: 0x0020152C File Offset: 0x001FF72C
		public static bool ModifyLegSlot(int slot)
		{
		}

		// Token: 0x04003E67 RID: 15975
		private const short DragonMask = 10000;

		// Token: 0x04003E68 RID: 15976
		private const short DragonBreastplate = 10001;

		// Token: 0x04003E69 RID: 15977
		private const short DragonGreaves = 10002;

		// Token: 0x04003E6A RID: 15978
		private const short SpectralHeadgear = 10003;

		// Token: 0x04003E6B RID: 15979
		private const short SpectralArmor = 10004;

		// Token: 0x04003E6C RID: 15980
		private const short SpectralSubligar = 10005;

		// Token: 0x04003E6D RID: 15981
		private const short TitanHelmet = 10006;

		// Token: 0x04003E6E RID: 15982
		private const short TitanMail = 10007;

		// Token: 0x04003E6F RID: 15983
		private const short TitanLeggings = 10008;

		// Token: 0x04003E70 RID: 15984
		private const short OcramMask = 10009;

		// Token: 0x04003E71 RID: 15985
		private const short HornedGodMask = 10010;

		// Token: 0x04003E72 RID: 15986
		private const short HornedGodRobe = 10011;

		// Token: 0x04003E73 RID: 15987
		private const short HornedGodBoots = 10012;

		// Token: 0x04003E74 RID: 15988
		private const short OcramTrophy = 10013;

		// Token: 0x04003E75 RID: 15989
		private const short AlbinoAntlionBanner = 10014;

		// Token: 0x04003E76 RID: 15990
		private const short ArchWyvernBanner = 10015;

		// Token: 0x04003E77 RID: 15991
		private const short ArchDemonBanner = 10016;

		// Token: 0x04003E78 RID: 15992
		private const short DragonSnatcherBanner = 10017;

		// Token: 0x04003E79 RID: 15993
		private const short OrcaBanner = 10018;

		// Token: 0x04003E7A RID: 15994
		private const short ShadowHammerBanner = 10019;

		// Token: 0x04003E7B RID: 15995
		private const short ShadowMummyBanner = 10020;

		// Token: 0x04003E7C RID: 15996
		private const short SpectralGastropodBanner = 10021;

		// Token: 0x04003E7D RID: 15997
		private const short SpectralElementalBanner = 10022;

		// Token: 0x04003E7E RID: 15998
		private const short VampireMinerBanner = 10023;

		// Token: 0x04003E7F RID: 15999
		private const short MusicBoxTutorial = 10024;

		// Token: 0x04003E80 RID: 16000
		private const short StarTopper4 = 10025;

		// Token: 0x04003E81 RID: 16001
		private const short StarTopper5 = 10026;

		// Token: 0x04003E82 RID: 16002
		private const short ShirenHat = 10027;

		// Token: 0x04003E83 RID: 16003
		private const short ShirenShirt = 10028;

		// Token: 0x04003E84 RID: 16004
		private const short ShirenPants = 10029;

		// Token: 0x04003E85 RID: 16005
		private const short MonokumaHead = 10030;

		// Token: 0x04003E86 RID: 16006
		private const short MonokumaBody = 10031;

		// Token: 0x04003E87 RID: 16007
		private const short MonokumaLegs = 10032;

		// Token: 0x04003E88 RID: 16008
		private const short WhiteThread = 10033;

		// Token: 0x04003E89 RID: 16009
		private const short MonomiHead = 10034;

		// Token: 0x04003E8A RID: 16010
		private const short MonomiBody = 10035;

		// Token: 0x04003E8B RID: 16011
		private const short MonomiLegs = 10036;

		// Token: 0x04003E8C RID: 16012
		private const short TorosHead = 10037;

		// Token: 0x04003E8D RID: 16013
		private const short TorosBody = 10038;

		// Token: 0x04003E8E RID: 16014
		private const short TorosLegs = 10039;

		// Token: 0x04003E8F RID: 16015
		public static int CompensatedCurrency;

		// Token: 0x02000579 RID: 1401
		public enum eBodySlot
		{
			// Token: 0x04003E91 RID: 16017
			None = -1,
			// Token: 0x04003E92 RID: 16018
			FamiliarShirt,
			// Token: 0x04003E93 RID: 16019
			CopperChainmail,
			// Token: 0x04003E94 RID: 16020
			IronChainmail,
			// Token: 0x04003E95 RID: 16021
			SilverChainmail,
			// Token: 0x04003E96 RID: 16022
			GoldChainmail,
			// Token: 0x04003E97 RID: 16023
			ShadowScalemail,
			// Token: 0x04003E98 RID: 16024
			MeteorSuit,
			// Token: 0x04003E99 RID: 16025
			NecroBreastplate,
			// Token: 0x04003E9A RID: 16026
			JungleShirt,
			// Token: 0x04003E9B RID: 16027
			MoltenBreastplate,
			// Token: 0x04003E9C RID: 16028
			TuxedoShirt,
			// Token: 0x04003E9D RID: 16029
			PlumbersShirt,
			// Token: 0x04003E9E RID: 16030
			HerosShirt,
			// Token: 0x04003E9F RID: 16031
			ArchaeologistsJacket,
			// Token: 0x04003EA0 RID: 16032
			NinjaShirt,
			// Token: 0x04003EA1 RID: 16033
			Robe,
			// Token: 0x04003EA2 RID: 16034
			TheDoctorsShirt,
			// Token: 0x04003EA3 RID: 16035
			CobaltBreastplate,
			// Token: 0x04003EA4 RID: 16036
			MythrilChainmail,
			// Token: 0x04003EA5 RID: 16037
			AdamantiteBreastplate,
			// Token: 0x04003EA6 RID: 16038
			MiningShirt,
			// Token: 0x04003EA7 RID: 16039
			WerewolfBody,
			// Token: 0x04003EA8 RID: 16040
			MermanBody,
			// Token: 0x04003EA9 RID: 16041
			ClownShirt,
			// Token: 0x04003EAA RID: 16042
			HallowedPlateMail,
			// Token: 0x04003EAB RID: 16043
			SantaShirt,
			// Token: 0x04003EAC RID: 16044
			RedsBreastplate,
			// Token: 0x04003EAD RID: 16045
			FrostBreastplate,
			// Token: 0x04003EAE RID: 16046
			TinChainmail,
			// Token: 0x04003EAF RID: 16047
			LeadChainmail,
			// Token: 0x04003EB0 RID: 16048
			TungstenChainmail,
			// Token: 0x04003EB1 RID: 16049
			PlatinumChainmail,
			// Token: 0x04003EB2 RID: 16050
			WoodBreastplate,
			// Token: 0x04003EB3 RID: 16051
			EbonwoodBreastplate,
			// Token: 0x04003EB4 RID: 16052
			RichMahoganyBreastplate,
			// Token: 0x04003EB5 RID: 16053
			PearlwoodBreastplate,
			// Token: 0x04003EB6 RID: 16054
			RuneRobe,
			// Token: 0x04003EB7 RID: 16055
			CrimsonScalemail,
			// Token: 0x04003EB8 RID: 16056
			EskimoCoat,
			// Token: 0x04003EB9 RID: 16057
			SteampunkShirt,
			// Token: 0x04003EBA RID: 16058
			BeeShirt,
			// Token: 0x04003EBB RID: 16059
			PrincessDress,
			// Token: 0x04003EBC RID: 16060
			PharaohsRobe,
			// Token: 0x04003EBD RID: 16061
			MummyShirt,
			// Token: 0x04003EBE RID: 16062
			CowboyJacket,
			// Token: 0x04003EBF RID: 16063
			PirateShirt,
			// Token: 0x04003EC0 RID: 16064
			CactusBreastplate,
			// Token: 0x04003EC1 RID: 16065
			ShadewoodBreastplate,
			// Token: 0x04003EC2 RID: 16066
			AncientShadowScalemail,
			// Token: 0x04003EC3 RID: 16067
			AncientCobaltBreastplate,
			// Token: 0x04003EC4 RID: 16068
			PinkEskimoCoat,
			// Token: 0x04003EC5 RID: 16069
			ChlorophytePlateMail,
			// Token: 0x04003EC6 RID: 16070
			RainCoat,
			// Token: 0x04003EC7 RID: 16071
			TikiShirt,
			// Token: 0x04003EC8 RID: 16072
			PalladiumBreastplate,
			// Token: 0x04003EC9 RID: 16073
			OrichalcumBreastplate,
			// Token: 0x04003ECA RID: 16074
			TitaniumBreastplate,
			// Token: 0x04003ECB RID: 16075
			SailorShirt,
			// Token: 0x04003ECC RID: 16076
			AmethystRobe,
			// Token: 0x04003ECD RID: 16077
			TopazRobe,
			// Token: 0x04003ECE RID: 16078
			SapphireRobe,
			// Token: 0x04003ECF RID: 16079
			EmeraldRobe,
			// Token: 0x04003ED0 RID: 16080
			RubyRobe,
			// Token: 0x04003ED1 RID: 16081
			DiamondRobe,
			// Token: 0x04003ED2 RID: 16082
			WhiteTuxedoShirt,
			// Token: 0x04003ED3 RID: 16083
			TurtleScaleMail,
			// Token: 0x04003ED4 RID: 16084
			SpectreRobe,
			// Token: 0x04003ED5 RID: 16085
			ShroomiteBreastplate,
			// Token: 0x04003ED6 RID: 16086
			CenxsBreastplate,
			// Token: 0x04003ED7 RID: 16087
			CrownosBreastplate,
			// Token: 0x04003ED8 RID: 16088
			WillsBreastplate,
			// Token: 0x04003ED9 RID: 16089
			JimsBreastplate,
			// Token: 0x04003EDA RID: 16090
			AaronsBreastplate,
			// Token: 0x04003EDB RID: 16091
			DTownsBreastplate,
			// Token: 0x04003EDC RID: 16092
			CenxsDress,
			// Token: 0x04003EDD RID: 16093
			PumpkinBreastplate,
			// Token: 0x04003EDE RID: 16094
			NurseShirt,
			// Token: 0x04003EDF RID: 16095
			DyeTraderRobe,
			// Token: 0x04003EE0 RID: 16096
			CyborgShirt,
			// Token: 0x04003EE1 RID: 16097
			CreeperShirt,
			// Token: 0x04003EE2 RID: 16098
			CatShirt,
			// Token: 0x04003EE3 RID: 16099
			GhostShirt,
			// Token: 0x04003EE4 RID: 16100
			PumpkinShirt,
			// Token: 0x04003EE5 RID: 16101
			RobotShirt,
			// Token: 0x04003EE6 RID: 16102
			UnicornShirt,
			// Token: 0x04003EE7 RID: 16103
			VampireShirt,
			// Token: 0x04003EE8 RID: 16104
			LeprechaunShirt,
			// Token: 0x04003EE9 RID: 16105
			PixieShirt,
			// Token: 0x04003EEA RID: 16106
			PrincessDressNew,
			// Token: 0x04003EEB RID: 16107
			WitchDress,
			// Token: 0x04003EEC RID: 16108
			BrideofFrankensteinDress,
			// Token: 0x04003EED RID: 16109
			KarateTortoiseShirt,
			// Token: 0x04003EEE RID: 16110
			ScarecrowShirt,
			// Token: 0x04003EEF RID: 16111
			ReaperRobe,
			// Token: 0x04003EF0 RID: 16112
			FoxShirt,
			// Token: 0x04003EF1 RID: 16113
			SpookyBreastplate,
			// Token: 0x04003EF2 RID: 16114
			SpaceCreatureShirt,
			// Token: 0x04003EF3 RID: 16115
			WolfShirt,
			// Token: 0x04003EF4 RID: 16116
			TreasureHunterShirt,
			// Token: 0x04003EF5 RID: 16117
			DryadCoverings,
			// Token: 0x04003EF6 RID: 16118
			MrsClauseShirt,
			// Token: 0x04003EF7 RID: 16119
			TreeShirt,
			// Token: 0x04003EF8 RID: 16120
			ParkaCoat,
			// Token: 0x04003EF9 RID: 16121
			UglySweater,
			// Token: 0x04003EFA RID: 16122
			ElfShirt,
			// Token: 0x04003EFB RID: 16123
			BeetleScaleMail,
			// Token: 0x04003EFC RID: 16124
			BeetleShell,
			// Token: 0x04003EFD RID: 16125
			Gi = 165,
			// Token: 0x04003EFE RID: 16126
			Kimono,
			// Token: 0x04003EFF RID: 16127
			GypsyRobe,
			// Token: 0x04003F00 RID: 16128
			BeeBreastplate,
			// Token: 0x04003F01 RID: 16129
			AnglerVest,
			// Token: 0x04003F02 RID: 16130
			SpiderBreastplate,
			// Token: 0x04003F03 RID: 16131
			MermaidAdornment,
			// Token: 0x04003F04 RID: 16132
			FishCostumeShirt,
			// Token: 0x04003F05 RID: 16133
			BorealWoodBreastplate,
			// Token: 0x04003F06 RID: 16134
			PalmWoodBreastplate,
			// Token: 0x04003F07 RID: 16135
			VortexBreastplate,
			// Token: 0x04003F08 RID: 16136
			NebulaBreastplate,
			// Token: 0x04003F09 RID: 16137
			SolarFlareBreastplate,
			// Token: 0x04003F0A RID: 16138
			MartianCostumeShirt,
			// Token: 0x04003F0B RID: 16139
			MartianUniformTorso,
			// Token: 0x04003F0C RID: 16140
			WhiteLunaticRobe,
			// Token: 0x04003F0D RID: 16141
			BlueLunaticRobe,
			// Token: 0x04003F0E RID: 16142
			GladiatorBreastplate,
			// Token: 0x04003F0F RID: 16143
			BejeweledValkyrieBody,
			// Token: 0x04003F10 RID: 16144
			TaxCollectorSuit,
			// Token: 0x04003F11 RID: 16145
			ClothierJacket,
			// Token: 0x04003F12 RID: 16146
			BuccaneerShirt,
			// Token: 0x04003F13 RID: 16147
			ObsidianShirt,
			// Token: 0x04003F14 RID: 16148
			FallenTuxedoShirt,
			// Token: 0x04003F15 RID: 16149
			FossilShirt,
			// Token: 0x04003F16 RID: 16150
			StardustBreastplate,
			// Token: 0x04003F17 RID: 16151
			TheBrideDress,
			// Token: 0x04003F18 RID: 16152
			Yoraiz0rShirt,
			// Token: 0x04003F19 RID: 16153
			SkiphsShirt,
			// Token: 0x04003F1A RID: 16154
			LokisShirt,
			// Token: 0x04003F1B RID: 16155
			SillySunflowerTops,
			// Token: 0x04003F1C RID: 16156
			PedguinsJacket,
			// Token: 0x04003F1D RID: 16157
			AncientArmor,
			// Token: 0x04003F1E RID: 16158
			AncientBattleArmor,
			// Token: 0x04003F1F RID: 16159
			Lamia,
			// Token: 0x04003F20 RID: 16160
			ApprenticeRobe,
			// Token: 0x04003F21 RID: 16161
			SquirePlating,
			// Token: 0x04003F22 RID: 16162
			HuntressJerkin,
			// Token: 0x04003F23 RID: 16163
			MonkShirt,
			// Token: 0x04003F24 RID: 16164
			ValhallaKnight,
			// Token: 0x04003F25 RID: 16165
			ApprenticeDark,
			// Token: 0x04003F26 RID: 16166
			RedRidingHuntress,
			// Token: 0x04003F27 RID: 16167
			ShinobiInfiltrator,
			// Token: 0x04003F28 RID: 16168
			ArkhalisShirt,
			// Token: 0x04003F29 RID: 16169
			LeinforsShirt,
			// Token: 0x04003F2A RID: 16170
			DragonBreastplate = 300,
			// Token: 0x04003F2B RID: 16171
			SpectralArmor,
			// Token: 0x04003F2C RID: 16172
			TitanMail,
			// Token: 0x04003F2D RID: 16173
			HornedGodRobe,
			// Token: 0x04003F2E RID: 16174
			FabulousDress,
			// Token: 0x04003F2F RID: 16175
			GeorgesSuit,
			// Token: 0x04003F30 RID: 16176
			ShirenShirt,
			// Token: 0x04003F31 RID: 16177
			MonokumaBody,
			// Token: 0x04003F32 RID: 16178
			MonomiBody,
			// Token: 0x04003F33 RID: 16179
			TorosBody,
			// Token: 0x04003F34 RID: 16180
			Count
		}

		// Token: 0x0200057A RID: 1402
		public enum eHeadSlot
		{
			// Token: 0x04003F36 RID: 16182
			None = -1,
			// Token: 0x04003F37 RID: 16183
			FamiliarWig,
			// Token: 0x04003F38 RID: 16184
			CopperHelmet,
			// Token: 0x04003F39 RID: 16185
			IronHelmet,
			// Token: 0x04003F3A RID: 16186
			SilverHelmet,
			// Token: 0x04003F3B RID: 16187
			GoldHelmet,
			// Token: 0x04003F3C RID: 16188
			ShadowHelmet,
			// Token: 0x04003F3D RID: 16189
			MeteorHelmet,
			// Token: 0x04003F3E RID: 16190
			NecroHelmet,
			// Token: 0x04003F3F RID: 16191
			JungleHat,
			// Token: 0x04003F40 RID: 16192
			MoltenHelmet,
			// Token: 0x04003F41 RID: 16193
			Goggles,
			// Token: 0x04003F42 RID: 16194
			MiningHelmet,
			// Token: 0x04003F43 RID: 16195
			Sunglasses,
			// Token: 0x04003F44 RID: 16196
			EmptyBucket,
			// Token: 0x04003F45 RID: 16197
			WizardHat,
			// Token: 0x04003F46 RID: 16198
			TopHat,
			// Token: 0x04003F47 RID: 16199
			SummerHat,
			// Token: 0x04003F48 RID: 16200
			BunnyHood,
			// Token: 0x04003F49 RID: 16201
			PlumbersHat,
			// Token: 0x04003F4A RID: 16202
			HerosHat,
			// Token: 0x04003F4B RID: 16203
			FishBowl,
			// Token: 0x04003F4C RID: 16204
			ArchaeologistsHat,
			// Token: 0x04003F4D RID: 16205
			NinjaHood,
			// Token: 0x04003F4E RID: 16206
			JungleRose,
			// Token: 0x04003F4F RID: 16207
			RedHat,
			// Token: 0x04003F50 RID: 16208
			RobotHat,
			// Token: 0x04003F51 RID: 16209
			GoldCrown,
			// Token: 0x04003F52 RID: 16210
			DivingHelmet,
			// Token: 0x04003F53 RID: 16211
			MimeMask,
			// Token: 0x04003F54 RID: 16212
			CobaltHat,
			// Token: 0x04003F55 RID: 16213
			CobaltHelmet,
			// Token: 0x04003F56 RID: 16214
			CobaltMask,
			// Token: 0x04003F57 RID: 16215
			MythrilHood,
			// Token: 0x04003F58 RID: 16216
			MythrilHelmet,
			// Token: 0x04003F59 RID: 16217
			MythrilHat,
			// Token: 0x04003F5A RID: 16218
			AdamantiteHeadgear,
			// Token: 0x04003F5B RID: 16219
			AdamantiteHelmet,
			// Token: 0x04003F5C RID: 16220
			AdamantiteMask,
			// Token: 0x04003F5D RID: 16221
			WerewolfHead,
			// Token: 0x04003F5E RID: 16222
			MermanHead,
			// Token: 0x04003F5F RID: 16223
			ClownHat,
			// Token: 0x04003F60 RID: 16224
			HallowedHelmet,
			// Token: 0x04003F61 RID: 16225
			HallowedHeadgear,
			// Token: 0x04003F62 RID: 16226
			HallowedMask,
			// Token: 0x04003F63 RID: 16227
			SantaHat,
			// Token: 0x04003F64 RID: 16228
			RedsHelmet,
			// Token: 0x04003F65 RID: 16229
			FrostHelmet,
			// Token: 0x04003F66 RID: 16230
			TinHelmet,
			// Token: 0x04003F67 RID: 16231
			LeadHelmet,
			// Token: 0x04003F68 RID: 16232
			TungstenHelmet,
			// Token: 0x04003F69 RID: 16233
			PlatinumHelmet,
			// Token: 0x04003F6A RID: 16234
			PlatinumCrown,
			// Token: 0x04003F6B RID: 16235
			WoodHelmet,
			// Token: 0x04003F6C RID: 16236
			EbonwoodHelmet,
			// Token: 0x04003F6D RID: 16237
			RichMahoganyHelmet,
			// Token: 0x04003F6E RID: 16238
			PearlwoodHelmet,
			// Token: 0x04003F6F RID: 16239
			RuneHat,
			// Token: 0x04003F70 RID: 16240
			CrimsonHelmet,
			// Token: 0x04003F71 RID: 16241
			EskimoHood,
			// Token: 0x04003F72 RID: 16242
			SteampunkHat,
			// Token: 0x04003F73 RID: 16243
			BeeHat,
			// Token: 0x04003F74 RID: 16244
			PharaohsMask,
			// Token: 0x04003F75 RID: 16245
			Tiara,
			// Token: 0x04003F76 RID: 16246
			GreenCap,
			// Token: 0x04003F77 RID: 16247
			MushroomCap,
			// Token: 0x04003F78 RID: 16248
			TamOShanter,
			// Token: 0x04003F79 RID: 16249
			MummyMask,
			// Token: 0x04003F7A RID: 16250
			CowboyHat,
			// Token: 0x04003F7B RID: 16251
			PirateHat,
			// Token: 0x04003F7C RID: 16252
			VikingHelmet,
			// Token: 0x04003F7D RID: 16253
			CactusHelmet,
			// Token: 0x04003F7E RID: 16254
			ShadewoodHelmet,
			// Token: 0x04003F7F RID: 16255
			AncientIronHelmet,
			// Token: 0x04003F80 RID: 16256
			AncientGoldHelmet,
			// Token: 0x04003F81 RID: 16257
			AncientShadowHelmet,
			// Token: 0x04003F82 RID: 16258
			AncientNecroHelmet,
			// Token: 0x04003F83 RID: 16259
			AncientCobaltHelmet,
			// Token: 0x04003F84 RID: 16260
			PinkEskimoHood,
			// Token: 0x04003F85 RID: 16261
			ChlorophyteMask,
			// Token: 0x04003F86 RID: 16262
			ChlorophyteHelmet,
			// Token: 0x04003F87 RID: 16263
			ChlorophyteHeadgear,
			// Token: 0x04003F88 RID: 16264
			RainHat,
			// Token: 0x04003F89 RID: 16265
			TikiMask,
			// Token: 0x04003F8A RID: 16266
			PalladiumMask,
			// Token: 0x04003F8B RID: 16267
			PalladiumHelmet,
			// Token: 0x04003F8C RID: 16268
			PalladiumHeadgear,
			// Token: 0x04003F8D RID: 16269
			OrichalcumMask,
			// Token: 0x04003F8E RID: 16270
			OrichalcumHelmet,
			// Token: 0x04003F8F RID: 16271
			OrichalcumHeadgear,
			// Token: 0x04003F90 RID: 16272
			TitaniumMask,
			// Token: 0x04003F91 RID: 16273
			TitaniumHelmet,
			// Token: 0x04003F92 RID: 16274
			TitaniumHeadgear,
			// Token: 0x04003F93 RID: 16275
			UmbrellaHat,
			// Token: 0x04003F94 RID: 16276
			Skull,
			// Token: 0x04003F95 RID: 16277
			BallaHat,
			// Token: 0x04003F96 RID: 16278
			GangstaHat,
			// Token: 0x04003F97 RID: 16279
			SailorHat,
			// Token: 0x04003F98 RID: 16280
			EyePatch,
			// Token: 0x04003F99 RID: 16281
			SkeletronMask,
			// Token: 0x04003F9A RID: 16282
			TurtleHelmet,
			// Token: 0x04003F9B RID: 16283
			Beanie,
			// Token: 0x04003F9C RID: 16284
			SpectreHood,
			// Token: 0x04003F9D RID: 16285
			SWATHelmet,
			// Token: 0x04003F9E RID: 16286
			ShroomiteHeadgear,
			// Token: 0x04003F9F RID: 16287
			ShroomiteMask,
			// Token: 0x04003FA0 RID: 16288
			ShroomiteHelmet,
			// Token: 0x04003FA1 RID: 16289
			CenxsTiara,
			// Token: 0x04003FA2 RID: 16290
			CrownosMask,
			// Token: 0x04003FA3 RID: 16291
			WillsHelmet,
			// Token: 0x04003FA4 RID: 16292
			JimsHelmet,
			// Token: 0x04003FA5 RID: 16293
			AaronsHelmet,
			// Token: 0x04003FA6 RID: 16294
			DTownsHelmet,
			// Token: 0x04003FA7 RID: 16295
			PumpkinHelmet,
			// Token: 0x04003FA8 RID: 16296
			NurseHat,
			// Token: 0x04003FA9 RID: 16297
			WizardsHat,
			// Token: 0x04003FAA RID: 16298
			GuyFawkesMask,
			// Token: 0x04003FAB RID: 16299
			SteampunkGoggles,
			// Token: 0x04003FAC RID: 16300
			CyborgHelmet,
			// Token: 0x04003FAD RID: 16301
			CreeperMask,
			// Token: 0x04003FAE RID: 16302
			CatMask,
			// Token: 0x04003FAF RID: 16303
			GhostMask,
			// Token: 0x04003FB0 RID: 16304
			PumpkinMask,
			// Token: 0x04003FB1 RID: 16305
			RobotMask,
			// Token: 0x04003FB2 RID: 16306
			UnicornMask,
			// Token: 0x04003FB3 RID: 16307
			VampireMask,
			// Token: 0x04003FB4 RID: 16308
			WitchHat,
			// Token: 0x04003FB5 RID: 16309
			LeprechaunHat,
			// Token: 0x04003FB6 RID: 16310
			PrincessHat,
			// Token: 0x04003FB7 RID: 16311
			BrideofFrankensteinMask,
			// Token: 0x04003FB8 RID: 16312
			KarateTortoiseMask,
			// Token: 0x04003FB9 RID: 16313
			ScarecrowHat,
			// Token: 0x04003FBA RID: 16314
			ReaperHood,
			// Token: 0x04003FBB RID: 16315
			FoxMask,
			// Token: 0x04003FBC RID: 16316
			CatEars,
			// Token: 0x04003FBD RID: 16317
			SpookyHelmet,
			// Token: 0x04003FBE RID: 16318
			SpaceCreatureMask,
			// Token: 0x04003FBF RID: 16319
			WolfMask,
			// Token: 0x04003FC0 RID: 16320
			JackOLanternMask,
			// Token: 0x04003FC1 RID: 16321
			GiantBow,
			// Token: 0x04003FC2 RID: 16322
			ReindeerAntlers,
			// Token: 0x04003FC3 RID: 16323
			MrsClauseHat,
			// Token: 0x04003FC4 RID: 16324
			TreeMask,
			// Token: 0x04003FC5 RID: 16325
			ParkaHood,
			// Token: 0x04003FC6 RID: 16326
			SnowHat,
			// Token: 0x04003FC7 RID: 16327
			ElfHat,
			// Token: 0x04003FC8 RID: 16328
			Fez,
			// Token: 0x04003FC9 RID: 16329
			BrainMask,
			// Token: 0x04003FCA RID: 16330
			FleshMask,
			// Token: 0x04003FCB RID: 16331
			TwinMask,
			// Token: 0x04003FCC RID: 16332
			SkeletronPrimeMask,
			// Token: 0x04003FCD RID: 16333
			BeeMask,
			// Token: 0x04003FCE RID: 16334
			PlanteraMask,
			// Token: 0x04003FCF RID: 16335
			GolemMask,
			// Token: 0x04003FD0 RID: 16336
			EaterMask,
			// Token: 0x04003FD1 RID: 16337
			EyeMask,
			// Token: 0x04003FD2 RID: 16338
			DestroyerMask,
			// Token: 0x04003FD3 RID: 16339
			SpectreMask,
			// Token: 0x04003FD4 RID: 16340
			BeetleHelmet,
			// Token: 0x04003FD5 RID: 16341
			PeddlersHat,
			// Token: 0x04003FD6 RID: 16342
			MagicHat,
			// Token: 0x04003FD7 RID: 16343
			BeeHeadgear,
			// Token: 0x04003FD8 RID: 16344
			AnglerHat,
			// Token: 0x04003FD9 RID: 16345
			SpiderMask,
			// Token: 0x04003FDA RID: 16346
			SeashellHairpin,
			// Token: 0x04003FDB RID: 16347
			KingSlimeMask,
			// Token: 0x04003FDC RID: 16348
			FishCostumeMask,
			// Token: 0x04003FDD RID: 16349
			BorealWoodHelmet,
			// Token: 0x04003FDE RID: 16350
			PalmWoodHelmet,
			// Token: 0x04003FDF RID: 16351
			DukeFishronMask,
			// Token: 0x04003FE0 RID: 16352
			VortexHelmet,
			// Token: 0x04003FE1 RID: 16353
			NebulaHelmet,
			// Token: 0x04003FE2 RID: 16354
			SolarFlareHelmet,
			// Token: 0x04003FE3 RID: 16355
			MoonMask,
			// Token: 0x04003FE4 RID: 16356
			SunMask,
			// Token: 0x04003FE5 RID: 16357
			MartianCostumeMask,
			// Token: 0x04003FE6 RID: 16358
			MartianUniformHelmet,
			// Token: 0x04003FE7 RID: 16359
			WhiteLunaticHood,
			// Token: 0x04003FE8 RID: 16360
			BlueLunaticHood,
			// Token: 0x04003FE9 RID: 16361
			HiTekSunglasses,
			// Token: 0x04003FEA RID: 16362
			NightVisionHelmet,
			// Token: 0x04003FEB RID: 16363
			GladiatorHelmet,
			// Token: 0x04003FEC RID: 16364
			BejeweledValkyrieHead,
			// Token: 0x04003FED RID: 16365
			TaxCollectorHat,
			// Token: 0x04003FEE RID: 16366
			DyeTraderTurban,
			// Token: 0x04003FEF RID: 16367
			BuccaneerBandana,
			// Token: 0x04003FF0 RID: 16368
			ObsidianHelm,
			// Token: 0x04003FF1 RID: 16369
			BossMaskCultist,
			// Token: 0x04003FF2 RID: 16370
			BossMaskMoonlord,
			// Token: 0x04003FF3 RID: 16371
			FossilHelm,
			// Token: 0x04003FF4 RID: 16372
			StardustHelmet,
			// Token: 0x04003FF5 RID: 16373
			TheBrideHat,
			// Token: 0x04003FF6 RID: 16374
			Yoraiz0rHead,
			// Token: 0x04003FF7 RID: 16375
			SkiphsHelm,
			// Token: 0x04003FF8 RID: 16376
			LokisHelm,
			// Token: 0x04003FF9 RID: 16377
			EngineeringHelmet,
			// Token: 0x04003FFA RID: 16378
			PartyHat,
			// Token: 0x04003FFB RID: 16379
			SillySunflowerPetals,
			// Token: 0x04003FFC RID: 16380
			PedguinsHood,
			// Token: 0x04003FFD RID: 16381
			_0x33sAviators,
			// Token: 0x04003FFE RID: 16382
			AncientArmor,
			// Token: 0x04003FFF RID: 16383
			AncientBattleArmor,
			// Token: 0x04004000 RID: 16384
			LamiaMale,
			// Token: 0x04004001 RID: 16385
			LamiaFemale,
			// Token: 0x04004002 RID: 16386
			ApprenticeHat,
			// Token: 0x04004003 RID: 16387
			SquireGreatHelm,
			// Token: 0x04004004 RID: 16388
			HuntressWig,
			// Token: 0x04004005 RID: 16389
			MonkBrows,
			// Token: 0x04004006 RID: 16390
			MaskBetsy,
			// Token: 0x04004007 RID: 16391
			MaskDarkMage,
			// Token: 0x04004008 RID: 16392
			MaskOgre,
			// Token: 0x04004009 RID: 16393
			ValhallaKnight,
			// Token: 0x0400400A RID: 16394
			ApprenticeDark,
			// Token: 0x0400400B RID: 16395
			RedRidingHuntress,
			// Token: 0x0400400C RID: 16396
			ShinobiInfiltrator,
			// Token: 0x0400400D RID: 16397
			ArkhalisHat,
			// Token: 0x0400400E RID: 16398
			LeinforsHat,
			// Token: 0x0400400F RID: 16399
			DragonMask = 300,
			// Token: 0x04004010 RID: 16400
			SpectralHeadgear,
			// Token: 0x04004011 RID: 16401
			TitanHelmet,
			// Token: 0x04004012 RID: 16402
			OcramMask,
			// Token: 0x04004013 RID: 16403
			HornedGodMask,
			// Token: 0x04004014 RID: 16404
			FabulousRibbon,
			// Token: 0x04004015 RID: 16405
			GeorgesHat,
			// Token: 0x04004016 RID: 16406
			ShirenHat,
			// Token: 0x04004017 RID: 16407
			MonokumaHead,
			// Token: 0x04004018 RID: 16408
			MonomiHead,
			// Token: 0x04004019 RID: 16409
			TorosHead,
			// Token: 0x0400401A RID: 16410
			Count
		}

		// Token: 0x0200057B RID: 1403
		public enum eLegSlot
		{
			// Token: 0x0400401C RID: 16412
			None = -1,
			// Token: 0x0400401D RID: 16413
			FamiliarPants,
			// Token: 0x0400401E RID: 16414
			CopperGreaves,
			// Token: 0x0400401F RID: 16415
			IronGreaves,
			// Token: 0x04004020 RID: 16416
			SilverGreaves,
			// Token: 0x04004021 RID: 16417
			GoldGreaves,
			// Token: 0x04004022 RID: 16418
			ShadowGreaves,
			// Token: 0x04004023 RID: 16419
			MeteorLeggings,
			// Token: 0x04004024 RID: 16420
			NecroGreaves,
			// Token: 0x04004025 RID: 16421
			JunglePants,
			// Token: 0x04004026 RID: 16422
			MoltenGreaves,
			// Token: 0x04004027 RID: 16423
			TuxedoPants,
			// Token: 0x04004028 RID: 16424
			PlumbersPants,
			// Token: 0x04004029 RID: 16425
			HerosPants,
			// Token: 0x0400402A RID: 16426
			ArchaeologistsPants,
			// Token: 0x0400402B RID: 16427
			NinjaPants,
			// Token: 0x0400402C RID: 16428
			TheDoctorsPants,
			// Token: 0x0400402D RID: 16429
			CobaltLeggings,
			// Token: 0x0400402E RID: 16430
			MythrilGreaves,
			// Token: 0x0400402F RID: 16431
			AdamantiteLeggings,
			// Token: 0x04004030 RID: 16432
			MiningPants,
			// Token: 0x04004031 RID: 16433
			WerewolfLegs,
			// Token: 0x04004032 RID: 16434
			MermanLegs,
			// Token: 0x04004033 RID: 16435
			ClownPants,
			// Token: 0x04004034 RID: 16436
			HallowedGreaves,
			// Token: 0x04004035 RID: 16437
			SantaPants,
			// Token: 0x04004036 RID: 16438
			RedsLeggings,
			// Token: 0x04004037 RID: 16439
			FrostLeggings,
			// Token: 0x04004038 RID: 16440
			TinGreaves,
			// Token: 0x04004039 RID: 16441
			LeadGreaves,
			// Token: 0x0400403A RID: 16442
			TungstenGreaves,
			// Token: 0x0400403B RID: 16443
			PlatinumGreaves,
			// Token: 0x0400403C RID: 16444
			WoodGreaves,
			// Token: 0x0400403D RID: 16445
			EbonwoodGreaves,
			// Token: 0x0400403E RID: 16446
			RichMahoganyGreaves,
			// Token: 0x0400403F RID: 16447
			PearlwoodGreaves,
			// Token: 0x04004040 RID: 16448
			CrimsonGreaves,
			// Token: 0x04004041 RID: 16449
			EskimoPants,
			// Token: 0x04004042 RID: 16450
			SteampunkPants,
			// Token: 0x04004043 RID: 16451
			BeePants,
			// Token: 0x04004044 RID: 16452
			MummyPants,
			// Token: 0x04004045 RID: 16453
			CowboyPants,
			// Token: 0x04004046 RID: 16454
			PiratePants,
			// Token: 0x04004047 RID: 16455
			CactusLeggings,
			// Token: 0x04004048 RID: 16456
			ShadewoodGreaves,
			// Token: 0x04004049 RID: 16457
			AncientShadowGreaves,
			// Token: 0x0400404A RID: 16458
			AncientCobaltLeggings,
			// Token: 0x0400404B RID: 16459
			PinkEskimoPants,
			// Token: 0x0400404C RID: 16460
			ChlorophyteGreaves,
			// Token: 0x0400404D RID: 16461
			TikiPants,
			// Token: 0x0400404E RID: 16462
			PalladiumLeggings,
			// Token: 0x0400404F RID: 16463
			OrichalcumLeggings,
			// Token: 0x04004050 RID: 16464
			TitaniumLeggings,
			// Token: 0x04004051 RID: 16465
			SailorPants,
			// Token: 0x04004052 RID: 16466
			WhiteTuxedoPants,
			// Token: 0x04004053 RID: 16467
			TurtleLeggings,
			// Token: 0x04004054 RID: 16468
			SpectrePants,
			// Token: 0x04004055 RID: 16469
			ShroomiteLeggings,
			// Token: 0x04004056 RID: 16470
			CenxsLeggings,
			// Token: 0x04004057 RID: 16471
			CrownosLeggings,
			// Token: 0x04004058 RID: 16472
			WillsLeggings,
			// Token: 0x04004059 RID: 16473
			JimsLeggings,
			// Token: 0x0400405A RID: 16474
			AaronsLeggings,
			// Token: 0x0400405B RID: 16475
			DTownsLeggings,
			// Token: 0x0400405C RID: 16476
			CenxsDressPants,
			// Token: 0x0400405D RID: 16477
			PumpkinLeggings,
			// Token: 0x0400405E RID: 16478
			NursePants,
			// Token: 0x0400405F RID: 16479
			CyborgPants,
			// Token: 0x04004060 RID: 16480
			CreeperPants,
			// Token: 0x04004061 RID: 16481
			CatPants,
			// Token: 0x04004062 RID: 16482
			PumpkinPants,
			// Token: 0x04004063 RID: 16483
			RobotPants,
			// Token: 0x04004064 RID: 16484
			UnicornPants,
			// Token: 0x04004065 RID: 16485
			VampirePants,
			// Token: 0x04004066 RID: 16486
			LeprechaunPants,
			// Token: 0x04004067 RID: 16487
			PixiePants,
			// Token: 0x04004068 RID: 16488
			WitchBoots,
			// Token: 0x04004069 RID: 16489
			KarateTortoisePants,
			// Token: 0x0400406A RID: 16490
			ScarecrowPants,
			// Token: 0x0400406B RID: 16491
			FoxPants,
			// Token: 0x0400406C RID: 16492
			SpookyLeggings,
			// Token: 0x0400406D RID: 16493
			SpaceCreaturePants,
			// Token: 0x0400406E RID: 16494
			WolfPants,
			// Token: 0x0400406F RID: 16495
			TreasureHunterPants,
			// Token: 0x04004070 RID: 16496
			DryadLoincloth,
			// Token: 0x04004071 RID: 16497
			MrsClauseHeels,
			// Token: 0x04004072 RID: 16498
			TreeTrunks,
			// Token: 0x04004073 RID: 16499
			ParkaPants,
			// Token: 0x04004074 RID: 16500
			ElfPants,
			// Token: 0x04004075 RID: 16501
			BeetleLeggings = 98,
			// Token: 0x04004076 RID: 16502
			BeeGreaves = 103,
			// Token: 0x04004077 RID: 16503
			AnglerPants,
			// Token: 0x04004078 RID: 16504
			SpiderGreaves,
			// Token: 0x04004079 RID: 16505
			MermaidTail,
			// Token: 0x0400407A RID: 16506
			FishCostumeFinskirt,
			// Token: 0x0400407B RID: 16507
			BorealWoodGreaves,
			// Token: 0x0400407C RID: 16508
			PalmWoodGreaves,
			// Token: 0x0400407D RID: 16509
			VortexLeggings,
			// Token: 0x0400407E RID: 16510
			NebulaLeggings,
			// Token: 0x0400407F RID: 16511
			SolarFlareLeggings,
			// Token: 0x04004080 RID: 16512
			MartianCostumePants,
			// Token: 0x04004081 RID: 16513
			MartianUniformPants,
			// Token: 0x04004082 RID: 16514
			DryadLoinclothOnMannequin = 117,
			// Token: 0x04004083 RID: 16515
			MrsClauseHeelsOnMannequin = 120,
			// Token: 0x04004084 RID: 16516
			GladiatorLeggings = 122,
			// Token: 0x04004085 RID: 16517
			TaxCollectorPants = 124,
			// Token: 0x04004086 RID: 16518
			ClothierPants,
			// Token: 0x04004087 RID: 16519
			BuccaneerPants,
			// Token: 0x04004088 RID: 16520
			ObsidianPants,
			// Token: 0x04004089 RID: 16521
			FallenTuxedoPants,
			// Token: 0x0400408A RID: 16522
			FossilPants,
			// Token: 0x0400408B RID: 16523
			StardustLeggings,
			// Token: 0x0400408C RID: 16524
			Yoraiz0rPants = 132,
			// Token: 0x0400408D RID: 16525
			SkiphsPants,
			// Token: 0x0400408E RID: 16526
			LokisPants,
			// Token: 0x0400408F RID: 16527
			SillySunflowerBottoms = 138,
			// Token: 0x04004090 RID: 16528
			PedguinsTrousers,
			// Token: 0x04004091 RID: 16529
			DjinnsCurse,
			// Token: 0x04004092 RID: 16530
			AncientArmor,
			// Token: 0x04004093 RID: 16531
			AncientBattleArmor,
			// Token: 0x04004094 RID: 16532
			Lamia,
			// Token: 0x04004095 RID: 16533
			ApprenticeTrousers,
			// Token: 0x04004096 RID: 16534
			SquireGreaves,
			// Token: 0x04004097 RID: 16535
			HuntressPantsMale,
			// Token: 0x04004098 RID: 16536
			HuntressPantsFemale,
			// Token: 0x04004099 RID: 16537
			MonkPants,
			// Token: 0x0400409A RID: 16538
			ApprenticeRobeExtension,
			// Token: 0x0400409B RID: 16539
			SquirePlatingExtension,
			// Token: 0x0400409C RID: 16540
			HuntressJerkinExtension,
			// Token: 0x0400409D RID: 16541
			ValhallaKnight,
			// Token: 0x0400409E RID: 16542
			ApprenticeDark,
			// Token: 0x0400409F RID: 16543
			RedRidingHuntress,
			// Token: 0x040040A0 RID: 16544
			RedRidingHuntress_Male,
			// Token: 0x040040A1 RID: 16545
			ShinobiInfiltrator,
			// Token: 0x040040A2 RID: 16546
			ArkhalisPants_Male,
			// Token: 0x040040A3 RID: 16547
			ArkhalisPants_Female,
			// Token: 0x040040A4 RID: 16548
			LeinforsPants,
			// Token: 0x040040A5 RID: 16549
			LeinforsPantsCoat,
			// Token: 0x040040A6 RID: 16550
			DragonGreaves = 300,
			// Token: 0x040040A7 RID: 16551
			SpectralSubligar,
			// Token: 0x040040A8 RID: 16552
			TitanLeggings,
			// Token: 0x040040A9 RID: 16553
			HornedGodBoots,
			// Token: 0x040040AA RID: 16554
			FabulousSlippers,
			// Token: 0x040040AB RID: 16555
			GeorgesPants,
			// Token: 0x040040AC RID: 16556
			ShirenPants,
			// Token: 0x040040AD RID: 16557
			MonokumaLegs,
			// Token: 0x040040AE RID: 16558
			MonomiLegs,
			// Token: 0x040040AF RID: 16559
			TorosLegs,
			// Token: 0x040040B0 RID: 16560
			Count
		}
	}
}
