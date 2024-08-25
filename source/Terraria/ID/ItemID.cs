using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Reflection;
using Terraria.DataStructures;

namespace Terraria.ID
{
	// Token: 0x020005D1 RID: 1489
	public class ItemID
	{
		// Token: 0x0600354F RID: 13647 RVA: 0x000021DB File Offset: 0x000003DB
		private static Dictionary<string, short> GenerateLegacyItemDictionary()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003550 RID: 13648 RVA: 0x0020B444 File Offset: 0x00209644
		public static short FromNetId(short id)
		{
		}

		// Token: 0x06003551 RID: 13649 RVA: 0x0020B59C File Offset: 0x0020979C
		public static short FromLegacyName(string name, int release)
		{
			if (!true)
			{
			}
			if (!true)
			{
				if (!true)
				{
				}
				Dictionary<string, short> dictionary = ItemID.GenerateLegacyItemDictionary();
			}
			bool flag = "Jungle Shirt" == "Cobalt Greaves";
			bool flag2 = "Jungle Shirt" == "Jungle Rose";
			bool flag3 = "Jungle Shirt" == "Gills potion";
			bool flag4 = "Jungle Shirt" == "Thorn Chakrum";
			bool flag5 = "Thorn Chakram" == "Ball 'O Hurt";
			bool flag6 = "Thorn Chakram" == "Iron Chain";
			bool flag7 = "Thorn Chakram" == "Orb of Light";
			bool flag8 = "Thorn Chakram" == "Black Dye";
			bool flag9 = "Thorn Chakram" == "Green Dye";
			if ("Green Thread" == null)
			{
			}
			return "Green Thread";
		}

		// Token: 0x06003552 RID: 13650 RVA: 0x0020B65C File Offset: 0x0020985C
		public ItemID()
		{
		}

		// Token: 0x06003553 RID: 13651 RVA: 0x0020B670 File Offset: 0x00209870
		// Note: this type is marked as 'beforefieldinit'.
		static ItemID()
		{
			IdDictionary idDictionary = IdDictionary.Create();
		}

		// Token: 0x04004E05 RID: 19973
		private static Dictionary<string, short> _legacyItemLookup;

		// Token: 0x04004E06 RID: 19974
		public const short YellowPhasesaberOld = -24;

		// Token: 0x04004E07 RID: 19975
		public const short WhitePhasesaberOld = -23;

		// Token: 0x04004E08 RID: 19976
		public const short PurplePhasesaberOld = -22;

		// Token: 0x04004E09 RID: 19977
		public const short GreenPhasesaberOld = -21;

		// Token: 0x04004E0A RID: 19978
		public const short RedPhasesaberOld = -20;

		// Token: 0x04004E0B RID: 19979
		public const short BluePhasesaberOld = -19;

		// Token: 0x04004E0C RID: 19980
		public const short PlatinumBowOld = -48;

		// Token: 0x04004E0D RID: 19981
		public const short PlatinumHammerOld = -47;

		// Token: 0x04004E0E RID: 19982
		public const short PlatinumAxeOld = -46;

		// Token: 0x04004E0F RID: 19983
		public const short PlatinumShortswordOld = -45;

		// Token: 0x04004E10 RID: 19984
		public const short PlatinumBroadswordOld = -44;

		// Token: 0x04004E11 RID: 19985
		public const short PlatinumPickaxeOld = -43;

		// Token: 0x04004E12 RID: 19986
		public const short TungstenBowOld = -42;

		// Token: 0x04004E13 RID: 19987
		public const short TungstenHammerOld = -41;

		// Token: 0x04004E14 RID: 19988
		public const short TungstenAxeOld = -40;

		// Token: 0x04004E15 RID: 19989
		public const short TungstenShortswordOld = -39;

		// Token: 0x04004E16 RID: 19990
		public const short TungstenBroadswordOld = -38;

		// Token: 0x04004E17 RID: 19991
		public const short TungstenPickaxeOld = -37;

		// Token: 0x04004E18 RID: 19992
		public const short LeadBowOld = -36;

		// Token: 0x04004E19 RID: 19993
		public const short LeadHammerOld = -35;

		// Token: 0x04004E1A RID: 19994
		public const short LeadAxeOld = -34;

		// Token: 0x04004E1B RID: 19995
		public const short LeadShortswordOld = -33;

		// Token: 0x04004E1C RID: 19996
		public const short LeadBroadswordOld = -32;

		// Token: 0x04004E1D RID: 19997
		public const short LeadPickaxeOld = -31;

		// Token: 0x04004E1E RID: 19998
		public const short TinBowOld = -30;

		// Token: 0x04004E1F RID: 19999
		public const short TinHammerOld = -29;

		// Token: 0x04004E20 RID: 20000
		public const short TinAxeOld = -28;

		// Token: 0x04004E21 RID: 20001
		public const short TinShortswordOld = -27;

		// Token: 0x04004E22 RID: 20002
		public const short TinBroadswordOld = -26;

		// Token: 0x04004E23 RID: 20003
		public const short TinPickaxeOld = -25;

		// Token: 0x04004E24 RID: 20004
		public const short CopperBowOld = -18;

		// Token: 0x04004E25 RID: 20005
		public const short CopperHammerOld = -17;

		// Token: 0x04004E26 RID: 20006
		public const short CopperAxeOld = -16;

		// Token: 0x04004E27 RID: 20007
		public const short CopperShortswordOld = -15;

		// Token: 0x04004E28 RID: 20008
		public const short CopperBroadswordOld = -14;

		// Token: 0x04004E29 RID: 20009
		public const short CopperPickaxeOld = -13;

		// Token: 0x04004E2A RID: 20010
		public const short SilverBowOld = -12;

		// Token: 0x04004E2B RID: 20011
		public const short SilverHammerOld = -11;

		// Token: 0x04004E2C RID: 20012
		public const short SilverAxeOld = -10;

		// Token: 0x04004E2D RID: 20013
		public const short SilverShortswordOld = -9;

		// Token: 0x04004E2E RID: 20014
		public const short SilverBroadswordOld = -8;

		// Token: 0x04004E2F RID: 20015
		public const short SilverPickaxeOld = -7;

		// Token: 0x04004E30 RID: 20016
		public const short GoldBowOld = -6;

		// Token: 0x04004E31 RID: 20017
		public const short GoldHammerOld = -5;

		// Token: 0x04004E32 RID: 20018
		public const short GoldAxeOld = -4;

		// Token: 0x04004E33 RID: 20019
		public const short GoldShortswordOld = -3;

		// Token: 0x04004E34 RID: 20020
		public const short GoldBroadswordOld = -2;

		// Token: 0x04004E35 RID: 20021
		public const short GoldPickaxeOld = -1;

		// Token: 0x04004E36 RID: 20022
		public const short None = 0;

		// Token: 0x04004E37 RID: 20023
		public const short IronPickaxe = 1;

		// Token: 0x04004E38 RID: 20024
		public const short DirtBlock = 2;

		// Token: 0x04004E39 RID: 20025
		public const short StoneBlock = 3;

		// Token: 0x04004E3A RID: 20026
		public const short IronBroadsword = 4;

		// Token: 0x04004E3B RID: 20027
		public const short Mushroom = 5;

		// Token: 0x04004E3C RID: 20028
		public const short IronShortsword = 6;

		// Token: 0x04004E3D RID: 20029
		public const short IronHammer = 7;

		// Token: 0x04004E3E RID: 20030
		public const short Torch = 8;

		// Token: 0x04004E3F RID: 20031
		public const short Wood = 9;

		// Token: 0x04004E40 RID: 20032
		public const short IronAxe = 10;

		// Token: 0x04004E41 RID: 20033
		public const short IronOre = 11;

		// Token: 0x04004E42 RID: 20034
		public const short CopperOre = 12;

		// Token: 0x04004E43 RID: 20035
		public const short GoldOre = 13;

		// Token: 0x04004E44 RID: 20036
		public const short SilverOre = 14;

		// Token: 0x04004E45 RID: 20037
		public const short CopperWatch = 15;

		// Token: 0x04004E46 RID: 20038
		public const short SilverWatch = 16;

		// Token: 0x04004E47 RID: 20039
		public const short GoldWatch = 17;

		// Token: 0x04004E48 RID: 20040
		public const short DepthMeter = 18;

		// Token: 0x04004E49 RID: 20041
		public const short GoldBar = 19;

		// Token: 0x04004E4A RID: 20042
		public const short CopperBar = 20;

		// Token: 0x04004E4B RID: 20043
		public const short SilverBar = 21;

		// Token: 0x04004E4C RID: 20044
		public const short IronBar = 22;

		// Token: 0x04004E4D RID: 20045
		public const short Gel = 23;

		// Token: 0x04004E4E RID: 20046
		public const short WoodenSword = 24;

		// Token: 0x04004E4F RID: 20047
		public const short WoodenDoor = 25;

		// Token: 0x04004E50 RID: 20048
		public const short StoneWall = 26;

		// Token: 0x04004E51 RID: 20049
		public const short Acorn = 27;

		// Token: 0x04004E52 RID: 20050
		public const short LesserHealingPotion = 28;

		// Token: 0x04004E53 RID: 20051
		public const short LifeCrystal = 29;

		// Token: 0x04004E54 RID: 20052
		public const short DirtWall = 30;

		// Token: 0x04004E55 RID: 20053
		public const short Bottle = 31;

		// Token: 0x04004E56 RID: 20054
		public const short WoodenTable = 32;

		// Token: 0x04004E57 RID: 20055
		public const short Furnace = 33;

		// Token: 0x04004E58 RID: 20056
		public const short WoodenChair = 34;

		// Token: 0x04004E59 RID: 20057
		public const short IronAnvil = 35;

		// Token: 0x04004E5A RID: 20058
		public const short WorkBench = 36;

		// Token: 0x04004E5B RID: 20059
		public const short Goggles = 37;

		// Token: 0x04004E5C RID: 20060
		public const short Lens = 38;

		// Token: 0x04004E5D RID: 20061
		public const short WoodenBow = 39;

		// Token: 0x04004E5E RID: 20062
		public const short WoodenArrow = 40;

		// Token: 0x04004E5F RID: 20063
		public const short FlamingArrow = 41;

		// Token: 0x04004E60 RID: 20064
		public const short Shuriken = 42;

		// Token: 0x04004E61 RID: 20065
		public const short SuspiciousLookingEye = 43;

		// Token: 0x04004E62 RID: 20066
		public const short DemonBow = 44;

		// Token: 0x04004E63 RID: 20067
		public const short WarAxeoftheNight = 45;

		// Token: 0x04004E64 RID: 20068
		public const short LightsBane = 46;

		// Token: 0x04004E65 RID: 20069
		public const short UnholyArrow = 47;

		// Token: 0x04004E66 RID: 20070
		public const short Chest = 48;

		// Token: 0x04004E67 RID: 20071
		public const short BandofRegeneration = 49;

		// Token: 0x04004E68 RID: 20072
		public const short MagicMirror = 50;

		// Token: 0x04004E69 RID: 20073
		public const short JestersArrow = 51;

		// Token: 0x04004E6A RID: 20074
		public const short AngelStatue = 52;

		// Token: 0x04004E6B RID: 20075
		public const short CloudinaBottle = 53;

		// Token: 0x04004E6C RID: 20076
		public const short HermesBoots = 54;

		// Token: 0x04004E6D RID: 20077
		public const short EnchantedBoomerang = 55;

		// Token: 0x04004E6E RID: 20078
		public const short DemoniteOre = 56;

		// Token: 0x04004E6F RID: 20079
		public const short DemoniteBar = 57;

		// Token: 0x04004E70 RID: 20080
		public const short Heart = 58;

		// Token: 0x04004E71 RID: 20081
		public const short CorruptSeeds = 59;

		// Token: 0x04004E72 RID: 20082
		public const short VileMushroom = 60;

		// Token: 0x04004E73 RID: 20083
		public const short EbonstoneBlock = 61;

		// Token: 0x04004E74 RID: 20084
		public const short GrassSeeds = 62;

		// Token: 0x04004E75 RID: 20085
		public const short Sunflower = 63;

		// Token: 0x04004E76 RID: 20086
		public const short Vilethorn = 64;

		// Token: 0x04004E77 RID: 20087
		public const short Starfury = 65;

		// Token: 0x04004E78 RID: 20088
		public const short PurificationPowder = 66;

		// Token: 0x04004E79 RID: 20089
		public const short VilePowder = 67;

		// Token: 0x04004E7A RID: 20090
		public const short RottenChunk = 68;

		// Token: 0x04004E7B RID: 20091
		public const short WormTooth = 69;

		// Token: 0x04004E7C RID: 20092
		public const short WormFood = 70;

		// Token: 0x04004E7D RID: 20093
		public const short CopperCoin = 71;

		// Token: 0x04004E7E RID: 20094
		public const short SilverCoin = 72;

		// Token: 0x04004E7F RID: 20095
		public const short GoldCoin = 73;

		// Token: 0x04004E80 RID: 20096
		public const short PlatinumCoin = 74;

		// Token: 0x04004E81 RID: 20097
		public const short FallenStar = 75;

		// Token: 0x04004E82 RID: 20098
		public const short CopperGreaves = 76;

		// Token: 0x04004E83 RID: 20099
		public const short IronGreaves = 77;

		// Token: 0x04004E84 RID: 20100
		public const short SilverGreaves = 78;

		// Token: 0x04004E85 RID: 20101
		public const short GoldGreaves = 79;

		// Token: 0x04004E86 RID: 20102
		public const short CopperChainmail = 80;

		// Token: 0x04004E87 RID: 20103
		public const short IronChainmail = 81;

		// Token: 0x04004E88 RID: 20104
		public const short SilverChainmail = 82;

		// Token: 0x04004E89 RID: 20105
		public const short GoldChainmail = 83;

		// Token: 0x04004E8A RID: 20106
		public const short GrapplingHook = 84;

		// Token: 0x04004E8B RID: 20107
		public const short Chain = 85;

		// Token: 0x04004E8C RID: 20108
		public const short ShadowScale = 86;

		// Token: 0x04004E8D RID: 20109
		public const short PiggyBank = 87;

		// Token: 0x04004E8E RID: 20110
		public const short MiningHelmet = 88;

		// Token: 0x04004E8F RID: 20111
		public const short CopperHelmet = 89;

		// Token: 0x04004E90 RID: 20112
		public const short IronHelmet = 90;

		// Token: 0x04004E91 RID: 20113
		public const short SilverHelmet = 91;

		// Token: 0x04004E92 RID: 20114
		public const short GoldHelmet = 92;

		// Token: 0x04004E93 RID: 20115
		public const short WoodWall = 93;

		// Token: 0x04004E94 RID: 20116
		public const short WoodPlatform = 94;

		// Token: 0x04004E95 RID: 20117
		public const short FlintlockPistol = 95;

		// Token: 0x04004E96 RID: 20118
		public const short Musket = 96;

		// Token: 0x04004E97 RID: 20119
		public const short MusketBall = 97;

		// Token: 0x04004E98 RID: 20120
		public const short Minishark = 98;

		// Token: 0x04004E99 RID: 20121
		public const short IronBow = 99;

		// Token: 0x04004E9A RID: 20122
		public const short ShadowGreaves = 100;

		// Token: 0x04004E9B RID: 20123
		public const short ShadowScalemail = 101;

		// Token: 0x04004E9C RID: 20124
		public const short ShadowHelmet = 102;

		// Token: 0x04004E9D RID: 20125
		public const short NightmarePickaxe = 103;

		// Token: 0x04004E9E RID: 20126
		public const short TheBreaker = 104;

		// Token: 0x04004E9F RID: 20127
		public const short Candle = 105;

		// Token: 0x04004EA0 RID: 20128
		public const short CopperChandelier = 106;

		// Token: 0x04004EA1 RID: 20129
		public const short SilverChandelier = 107;

		// Token: 0x04004EA2 RID: 20130
		public const short GoldChandelier = 108;

		// Token: 0x04004EA3 RID: 20131
		public const short ManaCrystal = 109;

		// Token: 0x04004EA4 RID: 20132
		public const short LesserManaPotion = 110;

		// Token: 0x04004EA5 RID: 20133
		public const short BandofStarpower = 111;

		// Token: 0x04004EA6 RID: 20134
		public const short FlowerofFire = 112;

		// Token: 0x04004EA7 RID: 20135
		public const short MagicMissile = 113;

		// Token: 0x04004EA8 RID: 20136
		public const short DirtRod = 114;

		// Token: 0x04004EA9 RID: 20137
		public const short ShadowOrb = 115;

		// Token: 0x04004EAA RID: 20138
		public const short Meteorite = 116;

		// Token: 0x04004EAB RID: 20139
		public const short MeteoriteBar = 117;

		// Token: 0x04004EAC RID: 20140
		public const short Hook = 118;

		// Token: 0x04004EAD RID: 20141
		public const short Flamarang = 119;

		// Token: 0x04004EAE RID: 20142
		public const short MoltenFury = 120;

		// Token: 0x04004EAF RID: 20143
		public const short FieryGreatsword = 121;

		// Token: 0x04004EB0 RID: 20144
		public const short MoltenPickaxe = 122;

		// Token: 0x04004EB1 RID: 20145
		public const short MeteorHelmet = 123;

		// Token: 0x04004EB2 RID: 20146
		public const short MeteorSuit = 124;

		// Token: 0x04004EB3 RID: 20147
		public const short MeteorLeggings = 125;

		// Token: 0x04004EB4 RID: 20148
		public const short BottledWater = 126;

		// Token: 0x04004EB5 RID: 20149
		public const short SpaceGun = 127;

		// Token: 0x04004EB6 RID: 20150
		public const short RocketBoots = 128;

		// Token: 0x04004EB7 RID: 20151
		public const short GrayBrick = 129;

		// Token: 0x04004EB8 RID: 20152
		public const short GrayBrickWall = 130;

		// Token: 0x04004EB9 RID: 20153
		public const short RedBrick = 131;

		// Token: 0x04004EBA RID: 20154
		public const short RedBrickWall = 132;

		// Token: 0x04004EBB RID: 20155
		public const short ClayBlock = 133;

		// Token: 0x04004EBC RID: 20156
		public const short BlueBrick = 134;

		// Token: 0x04004EBD RID: 20157
		public const short BlueBrickWall = 135;

		// Token: 0x04004EBE RID: 20158
		public const short ChainLantern = 136;

		// Token: 0x04004EBF RID: 20159
		public const short GreenBrick = 137;

		// Token: 0x04004EC0 RID: 20160
		public const short GreenBrickWall = 138;

		// Token: 0x04004EC1 RID: 20161
		public const short PinkBrick = 139;

		// Token: 0x04004EC2 RID: 20162
		public const short PinkBrickWall = 140;

		// Token: 0x04004EC3 RID: 20163
		public const short GoldBrick = 141;

		// Token: 0x04004EC4 RID: 20164
		public const short GoldBrickWall = 142;

		// Token: 0x04004EC5 RID: 20165
		public const short SilverBrick = 143;

		// Token: 0x04004EC6 RID: 20166
		public const short SilverBrickWall = 144;

		// Token: 0x04004EC7 RID: 20167
		public const short CopperBrick = 145;

		// Token: 0x04004EC8 RID: 20168
		public const short CopperBrickWall = 146;

		// Token: 0x04004EC9 RID: 20169
		public const short Spike = 147;

		// Token: 0x04004ECA RID: 20170
		public const short WaterCandle = 148;

		// Token: 0x04004ECB RID: 20171
		public const short Book = 149;

		// Token: 0x04004ECC RID: 20172
		public const short Cobweb = 150;

		// Token: 0x04004ECD RID: 20173
		public const short NecroHelmet = 151;

		// Token: 0x04004ECE RID: 20174
		public const short NecroBreastplate = 152;

		// Token: 0x04004ECF RID: 20175
		public const short NecroGreaves = 153;

		// Token: 0x04004ED0 RID: 20176
		public const short Bone = 154;

		// Token: 0x04004ED1 RID: 20177
		public const short Muramasa = 155;

		// Token: 0x04004ED2 RID: 20178
		public const short CobaltShield = 156;

		// Token: 0x04004ED3 RID: 20179
		public const short AquaScepter = 157;

		// Token: 0x04004ED4 RID: 20180
		public const short LuckyHorseshoe = 158;

		// Token: 0x04004ED5 RID: 20181
		public const short ShinyRedBalloon = 159;

		// Token: 0x04004ED6 RID: 20182
		public const short Harpoon = 160;

		// Token: 0x04004ED7 RID: 20183
		public const short SpikyBall = 161;

		// Token: 0x04004ED8 RID: 20184
		public const short BallOHurt = 162;

		// Token: 0x04004ED9 RID: 20185
		public const short BlueMoon = 163;

		// Token: 0x04004EDA RID: 20186
		public const short Handgun = 164;

		// Token: 0x04004EDB RID: 20187
		public const short WaterBolt = 165;

		// Token: 0x04004EDC RID: 20188
		public const short Bomb = 166;

		// Token: 0x04004EDD RID: 20189
		public const short Dynamite = 167;

		// Token: 0x04004EDE RID: 20190
		public const short Grenade = 168;

		// Token: 0x04004EDF RID: 20191
		public const short SandBlock = 169;

		// Token: 0x04004EE0 RID: 20192
		public const short Glass = 170;

		// Token: 0x04004EE1 RID: 20193
		public const short Sign = 171;

		// Token: 0x04004EE2 RID: 20194
		public const short AshBlock = 172;

		// Token: 0x04004EE3 RID: 20195
		public const short Obsidian = 173;

		// Token: 0x04004EE4 RID: 20196
		public const short Hellstone = 174;

		// Token: 0x04004EE5 RID: 20197
		public const short HellstoneBar = 175;

		// Token: 0x04004EE6 RID: 20198
		public const short MudBlock = 176;

		// Token: 0x04004EE7 RID: 20199
		public const short Sapphire = 177;

		// Token: 0x04004EE8 RID: 20200
		public const short Ruby = 178;

		// Token: 0x04004EE9 RID: 20201
		public const short Emerald = 179;

		// Token: 0x04004EEA RID: 20202
		public const short Topaz = 180;

		// Token: 0x04004EEB RID: 20203
		public const short Amethyst = 181;

		// Token: 0x04004EEC RID: 20204
		public const short Diamond = 182;

		// Token: 0x04004EED RID: 20205
		public const short GlowingMushroom = 183;

		// Token: 0x04004EEE RID: 20206
		public const short Star = 184;

		// Token: 0x04004EEF RID: 20207
		public const short IvyWhip = 185;

		// Token: 0x04004EF0 RID: 20208
		public const short BreathingReed = 186;

		// Token: 0x04004EF1 RID: 20209
		public const short Flipper = 187;

		// Token: 0x04004EF2 RID: 20210
		public const short HealingPotion = 188;

		// Token: 0x04004EF3 RID: 20211
		public const short ManaPotion = 189;

		// Token: 0x04004EF4 RID: 20212
		public const short BladeofGrass = 190;

		// Token: 0x04004EF5 RID: 20213
		public const short ThornChakram = 191;

		// Token: 0x04004EF6 RID: 20214
		public const short ObsidianBrick = 192;

		// Token: 0x04004EF7 RID: 20215
		public const short ObsidianSkull = 193;

		// Token: 0x04004EF8 RID: 20216
		public const short MushroomGrassSeeds = 194;

		// Token: 0x04004EF9 RID: 20217
		public const short JungleGrassSeeds = 195;

		// Token: 0x04004EFA RID: 20218
		public const short WoodenHammer = 196;

		// Token: 0x04004EFB RID: 20219
		public const short StarCannon = 197;

		// Token: 0x04004EFC RID: 20220
		public const short BluePhaseblade = 198;

		// Token: 0x04004EFD RID: 20221
		public const short RedPhaseblade = 199;

		// Token: 0x04004EFE RID: 20222
		public const short GreenPhaseblade = 200;

		// Token: 0x04004EFF RID: 20223
		public const short PurplePhaseblade = 201;

		// Token: 0x04004F00 RID: 20224
		public const short WhitePhaseblade = 202;

		// Token: 0x04004F01 RID: 20225
		public const short YellowPhaseblade = 203;

		// Token: 0x04004F02 RID: 20226
		public const short MeteorHamaxe = 204;

		// Token: 0x04004F03 RID: 20227
		public const short EmptyBucket = 205;

		// Token: 0x04004F04 RID: 20228
		public const short WaterBucket = 206;

		// Token: 0x04004F05 RID: 20229
		public const short LavaBucket = 207;

		// Token: 0x04004F06 RID: 20230
		public const short JungleRose = 208;

		// Token: 0x04004F07 RID: 20231
		public const short Stinger = 209;

		// Token: 0x04004F08 RID: 20232
		public const short Vine = 210;

		// Token: 0x04004F09 RID: 20233
		public const short FeralClaws = 211;

		// Token: 0x04004F0A RID: 20234
		public const short AnkletoftheWind = 212;

		// Token: 0x04004F0B RID: 20235
		public const short StaffofRegrowth = 213;

		// Token: 0x04004F0C RID: 20236
		public const short HellstoneBrick = 214;

		// Token: 0x04004F0D RID: 20237
		public const short WhoopieCushion = 215;

		// Token: 0x04004F0E RID: 20238
		public const short Shackle = 216;

		// Token: 0x04004F0F RID: 20239
		public const short MoltenHamaxe = 217;

		// Token: 0x04004F10 RID: 20240
		public const short Flamelash = 218;

		// Token: 0x04004F11 RID: 20241
		public const short PhoenixBlaster = 219;

		// Token: 0x04004F12 RID: 20242
		public const short Sunfury = 220;

		// Token: 0x04004F13 RID: 20243
		public const short Hellforge = 221;

		// Token: 0x04004F14 RID: 20244
		public const short ClayPot = 222;

		// Token: 0x04004F15 RID: 20245
		public const short NaturesGift = 223;

		// Token: 0x04004F16 RID: 20246
		public const short Bed = 224;

		// Token: 0x04004F17 RID: 20247
		public const short Silk = 225;

		// Token: 0x04004F18 RID: 20248
		public const short LesserRestorationPotion = 226;

		// Token: 0x04004F19 RID: 20249
		public const short RestorationPotion = 227;

		// Token: 0x04004F1A RID: 20250
		public const short JungleHat = 228;

		// Token: 0x04004F1B RID: 20251
		public const short JungleShirt = 229;

		// Token: 0x04004F1C RID: 20252
		public const short JunglePants = 230;

		// Token: 0x04004F1D RID: 20253
		public const short MoltenHelmet = 231;

		// Token: 0x04004F1E RID: 20254
		public const short MoltenBreastplate = 232;

		// Token: 0x04004F1F RID: 20255
		public const short MoltenGreaves = 233;

		// Token: 0x04004F20 RID: 20256
		public const short MeteorShot = 234;

		// Token: 0x04004F21 RID: 20257
		public const short StickyBomb = 235;

		// Token: 0x04004F22 RID: 20258
		public const short BlackLens = 236;

		// Token: 0x04004F23 RID: 20259
		public const short Sunglasses = 237;

		// Token: 0x04004F24 RID: 20260
		public const short WizardHat = 238;

		// Token: 0x04004F25 RID: 20261
		public const short TopHat = 239;

		// Token: 0x04004F26 RID: 20262
		public const short TuxedoShirt = 240;

		// Token: 0x04004F27 RID: 20263
		public const short TuxedoPants = 241;

		// Token: 0x04004F28 RID: 20264
		public const short SummerHat = 242;

		// Token: 0x04004F29 RID: 20265
		public const short BunnyHood = 243;

		// Token: 0x04004F2A RID: 20266
		public const short PlumbersHat = 244;

		// Token: 0x04004F2B RID: 20267
		public const short PlumbersShirt = 245;

		// Token: 0x04004F2C RID: 20268
		public const short PlumbersPants = 246;

		// Token: 0x04004F2D RID: 20269
		public const short HerosHat = 247;

		// Token: 0x04004F2E RID: 20270
		public const short HerosShirt = 248;

		// Token: 0x04004F2F RID: 20271
		public const short HerosPants = 249;

		// Token: 0x04004F30 RID: 20272
		public const short FishBowl = 250;

		// Token: 0x04004F31 RID: 20273
		public const short ArchaeologistsHat = 251;

		// Token: 0x04004F32 RID: 20274
		public const short ArchaeologistsJacket = 252;

		// Token: 0x04004F33 RID: 20275
		public const short ArchaeologistsPants = 253;

		// Token: 0x04004F34 RID: 20276
		public const short BlackThread = 254;

		// Token: 0x04004F35 RID: 20277
		public const short GreenThread = 255;

		// Token: 0x04004F36 RID: 20278
		public const short NinjaHood = 256;

		// Token: 0x04004F37 RID: 20279
		public const short NinjaShirt = 257;

		// Token: 0x04004F38 RID: 20280
		public const short NinjaPants = 258;

		// Token: 0x04004F39 RID: 20281
		public const short Leather = 259;

		// Token: 0x04004F3A RID: 20282
		public const short RedHat = 260;

		// Token: 0x04004F3B RID: 20283
		public const short Goldfish = 261;

		// Token: 0x04004F3C RID: 20284
		public const short Robe = 262;

		// Token: 0x04004F3D RID: 20285
		public const short RobotHat = 263;

		// Token: 0x04004F3E RID: 20286
		public const short GoldCrown = 264;

		// Token: 0x04004F3F RID: 20287
		public const short HellfireArrow = 265;

		// Token: 0x04004F40 RID: 20288
		public const short Sandgun = 266;

		// Token: 0x04004F41 RID: 20289
		public const short GuideVoodooDoll = 267;

		// Token: 0x04004F42 RID: 20290
		public const short DivingHelmet = 268;

		// Token: 0x04004F43 RID: 20291
		public const short FamiliarShirt = 269;

		// Token: 0x04004F44 RID: 20292
		public const short FamiliarPants = 270;

		// Token: 0x04004F45 RID: 20293
		public const short FamiliarWig = 271;

		// Token: 0x04004F46 RID: 20294
		public const short DemonScythe = 272;

		// Token: 0x04004F47 RID: 20295
		public const short NightsEdge = 273;

		// Token: 0x04004F48 RID: 20296
		public const short DarkLance = 274;

		// Token: 0x04004F49 RID: 20297
		public const short Coral = 275;

		// Token: 0x04004F4A RID: 20298
		public const short Cactus = 276;

		// Token: 0x04004F4B RID: 20299
		public const short Trident = 277;

		// Token: 0x04004F4C RID: 20300
		public const short SilverBullet = 278;

		// Token: 0x04004F4D RID: 20301
		public const short ThrowingKnife = 279;

		// Token: 0x04004F4E RID: 20302
		public const short Spear = 280;

		// Token: 0x04004F4F RID: 20303
		public const short Blowpipe = 281;

		// Token: 0x04004F50 RID: 20304
		public const short Glowstick = 282;

		// Token: 0x04004F51 RID: 20305
		public const short Seed = 283;

		// Token: 0x04004F52 RID: 20306
		public const short WoodenBoomerang = 284;

		// Token: 0x04004F53 RID: 20307
		public const short Aglet = 285;

		// Token: 0x04004F54 RID: 20308
		public const short StickyGlowstick = 286;

		// Token: 0x04004F55 RID: 20309
		public const short PoisonedKnife = 287;

		// Token: 0x04004F56 RID: 20310
		public const short ObsidianSkinPotion = 288;

		// Token: 0x04004F57 RID: 20311
		public const short RegenerationPotion = 289;

		// Token: 0x04004F58 RID: 20312
		public const short SwiftnessPotion = 290;

		// Token: 0x04004F59 RID: 20313
		public const short GillsPotion = 291;

		// Token: 0x04004F5A RID: 20314
		public const short IronskinPotion = 292;

		// Token: 0x04004F5B RID: 20315
		public const short ManaRegenerationPotion = 293;

		// Token: 0x04004F5C RID: 20316
		public const short MagicPowerPotion = 294;

		// Token: 0x04004F5D RID: 20317
		public const short FeatherfallPotion = 295;

		// Token: 0x04004F5E RID: 20318
		public const short SpelunkerPotion = 296;

		// Token: 0x04004F5F RID: 20319
		public const short InvisibilityPotion = 297;

		// Token: 0x04004F60 RID: 20320
		public const short ShinePotion = 298;

		// Token: 0x04004F61 RID: 20321
		public const short NightOwlPotion = 299;

		// Token: 0x04004F62 RID: 20322
		public const short BattlePotion = 300;

		// Token: 0x04004F63 RID: 20323
		public const short ThornsPotion = 301;

		// Token: 0x04004F64 RID: 20324
		public const short WaterWalkingPotion = 302;

		// Token: 0x04004F65 RID: 20325
		public const short ArcheryPotion = 303;

		// Token: 0x04004F66 RID: 20326
		public const short HunterPotion = 304;

		// Token: 0x04004F67 RID: 20327
		public const short GravitationPotion = 305;

		// Token: 0x04004F68 RID: 20328
		public const short GoldChest = 306;

		// Token: 0x04004F69 RID: 20329
		public const short DaybloomSeeds = 307;

		// Token: 0x04004F6A RID: 20330
		public const short MoonglowSeeds = 308;

		// Token: 0x04004F6B RID: 20331
		public const short BlinkrootSeeds = 309;

		// Token: 0x04004F6C RID: 20332
		public const short DeathweedSeeds = 310;

		// Token: 0x04004F6D RID: 20333
		public const short WaterleafSeeds = 311;

		// Token: 0x04004F6E RID: 20334
		public const short FireblossomSeeds = 312;

		// Token: 0x04004F6F RID: 20335
		public const short Daybloom = 313;

		// Token: 0x04004F70 RID: 20336
		public const short Moonglow = 314;

		// Token: 0x04004F71 RID: 20337
		public const short Blinkroot = 315;

		// Token: 0x04004F72 RID: 20338
		public const short Deathweed = 316;

		// Token: 0x04004F73 RID: 20339
		public const short Waterleaf = 317;

		// Token: 0x04004F74 RID: 20340
		public const short Fireblossom = 318;

		// Token: 0x04004F75 RID: 20341
		public const short SharkFin = 319;

		// Token: 0x04004F76 RID: 20342
		public const short Feather = 320;

		// Token: 0x04004F77 RID: 20343
		public const short Tombstone = 321;

		// Token: 0x04004F78 RID: 20344
		public const short MimeMask = 322;

		// Token: 0x04004F79 RID: 20345
		public const short AntlionMandible = 323;

		// Token: 0x04004F7A RID: 20346
		public const short IllegalGunParts = 324;

		// Token: 0x04004F7B RID: 20347
		public const short TheDoctorsShirt = 325;

		// Token: 0x04004F7C RID: 20348
		public const short TheDoctorsPants = 326;

		// Token: 0x04004F7D RID: 20349
		public const short GoldenKey = 327;

		// Token: 0x04004F7E RID: 20350
		public const short ShadowChest = 328;

		// Token: 0x04004F7F RID: 20351
		public const short ShadowKey = 329;

		// Token: 0x04004F80 RID: 20352
		public const short ObsidianBrickWall = 330;

		// Token: 0x04004F81 RID: 20353
		public const short JungleSpores = 331;

		// Token: 0x04004F82 RID: 20354
		public const short Loom = 332;

		// Token: 0x04004F83 RID: 20355
		public const short Piano = 333;

		// Token: 0x04004F84 RID: 20356
		public const short Dresser = 334;

		// Token: 0x04004F85 RID: 20357
		public const short Bench = 335;

		// Token: 0x04004F86 RID: 20358
		public const short Bathtub = 336;

		// Token: 0x04004F87 RID: 20359
		public const short RedBanner = 337;

		// Token: 0x04004F88 RID: 20360
		public const short GreenBanner = 338;

		// Token: 0x04004F89 RID: 20361
		public const short BlueBanner = 339;

		// Token: 0x04004F8A RID: 20362
		public const short YellowBanner = 340;

		// Token: 0x04004F8B RID: 20363
		public const short LampPost = 341;

		// Token: 0x04004F8C RID: 20364
		public const short TikiTorch = 342;

		// Token: 0x04004F8D RID: 20365
		public const short Barrel = 343;

		// Token: 0x04004F8E RID: 20366
		public const short ChineseLantern = 344;

		// Token: 0x04004F8F RID: 20367
		public const short CookingPot = 345;

		// Token: 0x04004F90 RID: 20368
		public const short Safe = 346;

		// Token: 0x04004F91 RID: 20369
		public const short SkullLantern = 347;

		// Token: 0x04004F92 RID: 20370
		public const short TrashCan = 348;

		// Token: 0x04004F93 RID: 20371
		public const short Candelabra = 349;

		// Token: 0x04004F94 RID: 20372
		public const short PinkVase = 350;

		// Token: 0x04004F95 RID: 20373
		public const short Mug = 351;

		// Token: 0x04004F96 RID: 20374
		public const short Keg = 352;

		// Token: 0x04004F97 RID: 20375
		public const short Ale = 353;

		// Token: 0x04004F98 RID: 20376
		public const short Bookcase = 354;

		// Token: 0x04004F99 RID: 20377
		public const short Throne = 355;

		// Token: 0x04004F9A RID: 20378
		public const short Bowl = 356;

		// Token: 0x04004F9B RID: 20379
		public const short BowlofSoup = 357;

		// Token: 0x04004F9C RID: 20380
		public const short Toilet = 358;

		// Token: 0x04004F9D RID: 20381
		public const short GrandfatherClock = 359;

		// Token: 0x04004F9E RID: 20382
		public const short ArmorStatue = 360;

		// Token: 0x04004F9F RID: 20383
		public const short GoblinBattleStandard = 361;

		// Token: 0x04004FA0 RID: 20384
		public const short TatteredCloth = 362;

		// Token: 0x04004FA1 RID: 20385
		public const short Sawmill = 363;

		// Token: 0x04004FA2 RID: 20386
		public const short CobaltOre = 364;

		// Token: 0x04004FA3 RID: 20387
		public const short MythrilOre = 365;

		// Token: 0x04004FA4 RID: 20388
		public const short AdamantiteOre = 366;

		// Token: 0x04004FA5 RID: 20389
		public const short Pwnhammer = 367;

		// Token: 0x04004FA6 RID: 20390
		public const short Excalibur = 368;

		// Token: 0x04004FA7 RID: 20391
		public const short HallowedSeeds = 369;

		// Token: 0x04004FA8 RID: 20392
		public const short EbonsandBlock = 370;

		// Token: 0x04004FA9 RID: 20393
		public const short CobaltHat = 371;

		// Token: 0x04004FAA RID: 20394
		public const short CobaltHelmet = 372;

		// Token: 0x04004FAB RID: 20395
		public const short CobaltMask = 373;

		// Token: 0x04004FAC RID: 20396
		public const short CobaltBreastplate = 374;

		// Token: 0x04004FAD RID: 20397
		public const short CobaltLeggings = 375;

		// Token: 0x04004FAE RID: 20398
		public const short MythrilHood = 376;

		// Token: 0x04004FAF RID: 20399
		public const short MythrilHelmet = 377;

		// Token: 0x04004FB0 RID: 20400
		public const short MythrilHat = 378;

		// Token: 0x04004FB1 RID: 20401
		public const short MythrilChainmail = 379;

		// Token: 0x04004FB2 RID: 20402
		public const short MythrilGreaves = 380;

		// Token: 0x04004FB3 RID: 20403
		public const short CobaltBar = 381;

		// Token: 0x04004FB4 RID: 20404
		public const short MythrilBar = 382;

		// Token: 0x04004FB5 RID: 20405
		public const short CobaltChainsaw = 383;

		// Token: 0x04004FB6 RID: 20406
		public const short MythrilChainsaw = 384;

		// Token: 0x04004FB7 RID: 20407
		public const short CobaltDrill = 385;

		// Token: 0x04004FB8 RID: 20408
		public const short MythrilDrill = 386;

		// Token: 0x04004FB9 RID: 20409
		public const short AdamantiteChainsaw = 387;

		// Token: 0x04004FBA RID: 20410
		public const short AdamantiteDrill = 388;

		// Token: 0x04004FBB RID: 20411
		public const short DaoofPow = 389;

		// Token: 0x04004FBC RID: 20412
		public const short MythrilHalberd = 390;

		// Token: 0x04004FBD RID: 20413
		public const short AdamantiteBar = 391;

		// Token: 0x04004FBE RID: 20414
		public const short GlassWall = 392;

		// Token: 0x04004FBF RID: 20415
		public const short Compass = 393;

		// Token: 0x04004FC0 RID: 20416
		public const short DivingGear = 394;

		// Token: 0x04004FC1 RID: 20417
		public const short GPS = 395;

		// Token: 0x04004FC2 RID: 20418
		public const short ObsidianHorseshoe = 396;

		// Token: 0x04004FC3 RID: 20419
		public const short ObsidianShield = 397;

		// Token: 0x04004FC4 RID: 20420
		public const short TinkerersWorkshop = 398;

		// Token: 0x04004FC5 RID: 20421
		public const short CloudinaBalloon = 399;

		// Token: 0x04004FC6 RID: 20422
		public const short AdamantiteHeadgear = 400;

		// Token: 0x04004FC7 RID: 20423
		public const short AdamantiteHelmet = 401;

		// Token: 0x04004FC8 RID: 20424
		public const short AdamantiteMask = 402;

		// Token: 0x04004FC9 RID: 20425
		public const short AdamantiteBreastplate = 403;

		// Token: 0x04004FCA RID: 20426
		public const short AdamantiteLeggings = 404;

		// Token: 0x04004FCB RID: 20427
		public const short SpectreBoots = 405;

		// Token: 0x04004FCC RID: 20428
		public const short AdamantiteGlaive = 406;

		// Token: 0x04004FCD RID: 20429
		public const short Toolbelt = 407;

		// Token: 0x04004FCE RID: 20430
		public const short PearlsandBlock = 408;

		// Token: 0x04004FCF RID: 20431
		public const short PearlstoneBlock = 409;

		// Token: 0x04004FD0 RID: 20432
		public const short MiningShirt = 410;

		// Token: 0x04004FD1 RID: 20433
		public const short MiningPants = 411;

		// Token: 0x04004FD2 RID: 20434
		public const short PearlstoneBrick = 412;

		// Token: 0x04004FD3 RID: 20435
		public const short IridescentBrick = 413;

		// Token: 0x04004FD4 RID: 20436
		public const short MudstoneBlock = 414;

		// Token: 0x04004FD5 RID: 20437
		public const short CobaltBrick = 415;

		// Token: 0x04004FD6 RID: 20438
		public const short MythrilBrick = 416;

		// Token: 0x04004FD7 RID: 20439
		public const short PearlstoneBrickWall = 417;

		// Token: 0x04004FD8 RID: 20440
		public const short IridescentBrickWall = 418;

		// Token: 0x04004FD9 RID: 20441
		public const short MudstoneBrickWall = 419;

		// Token: 0x04004FDA RID: 20442
		public const short CobaltBrickWall = 420;

		// Token: 0x04004FDB RID: 20443
		public const short MythrilBrickWall = 421;

		// Token: 0x04004FDC RID: 20444
		public const short HolyWater = 422;

		// Token: 0x04004FDD RID: 20445
		public const short UnholyWater = 423;

		// Token: 0x04004FDE RID: 20446
		public const short SiltBlock = 424;

		// Token: 0x04004FDF RID: 20447
		public const short FairyBell = 425;

		// Token: 0x04004FE0 RID: 20448
		public const short BreakerBlade = 426;

		// Token: 0x04004FE1 RID: 20449
		public const short BlueTorch = 427;

		// Token: 0x04004FE2 RID: 20450
		public const short RedTorch = 428;

		// Token: 0x04004FE3 RID: 20451
		public const short GreenTorch = 429;

		// Token: 0x04004FE4 RID: 20452
		public const short PurpleTorch = 430;

		// Token: 0x04004FE5 RID: 20453
		public const short WhiteTorch = 431;

		// Token: 0x04004FE6 RID: 20454
		public const short YellowTorch = 432;

		// Token: 0x04004FE7 RID: 20455
		public const short DemonTorch = 433;

		// Token: 0x04004FE8 RID: 20456
		public const short ClockworkAssaultRifle = 434;

		// Token: 0x04004FE9 RID: 20457
		public const short CobaltRepeater = 435;

		// Token: 0x04004FEA RID: 20458
		public const short MythrilRepeater = 436;

		// Token: 0x04004FEB RID: 20459
		public const short DualHook = 437;

		// Token: 0x04004FEC RID: 20460
		public const short StarStatue = 438;

		// Token: 0x04004FED RID: 20461
		public const short SwordStatue = 439;

		// Token: 0x04004FEE RID: 20462
		public const short SlimeStatue = 440;

		// Token: 0x04004FEF RID: 20463
		public const short GoblinStatue = 441;

		// Token: 0x04004FF0 RID: 20464
		public const short ShieldStatue = 442;

		// Token: 0x04004FF1 RID: 20465
		public const short BatStatue = 443;

		// Token: 0x04004FF2 RID: 20466
		public const short FishStatue = 444;

		// Token: 0x04004FF3 RID: 20467
		public const short BunnyStatue = 445;

		// Token: 0x04004FF4 RID: 20468
		public const short SkeletonStatue = 446;

		// Token: 0x04004FF5 RID: 20469
		public const short ReaperStatue = 447;

		// Token: 0x04004FF6 RID: 20470
		public const short WomanStatue = 448;

		// Token: 0x04004FF7 RID: 20471
		public const short ImpStatue = 449;

		// Token: 0x04004FF8 RID: 20472
		public const short GargoyleStatue = 450;

		// Token: 0x04004FF9 RID: 20473
		public const short GloomStatue = 451;

		// Token: 0x04004FFA RID: 20474
		public const short HornetStatue = 452;

		// Token: 0x04004FFB RID: 20475
		public const short BombStatue = 453;

		// Token: 0x04004FFC RID: 20476
		public const short CrabStatue = 454;

		// Token: 0x04004FFD RID: 20477
		public const short HammerStatue = 455;

		// Token: 0x04004FFE RID: 20478
		public const short PotionStatue = 456;

		// Token: 0x04004FFF RID: 20479
		public const short SpearStatue = 457;

		// Token: 0x04005000 RID: 20480
		public const short CrossStatue = 458;

		// Token: 0x04005001 RID: 20481
		public const short JellyfishStatue = 459;

		// Token: 0x04005002 RID: 20482
		public const short BowStatue = 460;

		// Token: 0x04005003 RID: 20483
		public const short BoomerangStatue = 461;

		// Token: 0x04005004 RID: 20484
		public const short BootStatue = 462;

		// Token: 0x04005005 RID: 20485
		public const short ChestStatue = 463;

		// Token: 0x04005006 RID: 20486
		public const short BirdStatue = 464;

		// Token: 0x04005007 RID: 20487
		public const short AxeStatue = 465;

		// Token: 0x04005008 RID: 20488
		public const short CorruptStatue = 466;

		// Token: 0x04005009 RID: 20489
		public const short TreeStatue = 467;

		// Token: 0x0400500A RID: 20490
		public const short AnvilStatue = 468;

		// Token: 0x0400500B RID: 20491
		public const short PickaxeStatue = 469;

		// Token: 0x0400500C RID: 20492
		public const short MushroomStatue = 470;

		// Token: 0x0400500D RID: 20493
		public const short EyeballStatue = 471;

		// Token: 0x0400500E RID: 20494
		public const short PillarStatue = 472;

		// Token: 0x0400500F RID: 20495
		public const short HeartStatue = 473;

		// Token: 0x04005010 RID: 20496
		public const short PotStatue = 474;

		// Token: 0x04005011 RID: 20497
		public const short SunflowerStatue = 475;

		// Token: 0x04005012 RID: 20498
		public const short KingStatue = 476;

		// Token: 0x04005013 RID: 20499
		public const short QueenStatue = 477;

		// Token: 0x04005014 RID: 20500
		public const short PiranhaStatue = 478;

		// Token: 0x04005015 RID: 20501
		public const short PlankedWall = 479;

		// Token: 0x04005016 RID: 20502
		public const short WoodenBeam = 480;

		// Token: 0x04005017 RID: 20503
		public const short AdamantiteRepeater = 481;

		// Token: 0x04005018 RID: 20504
		public const short AdamantiteSword = 482;

		// Token: 0x04005019 RID: 20505
		public const short CobaltSword = 483;

		// Token: 0x0400501A RID: 20506
		public const short MythrilSword = 484;

		// Token: 0x0400501B RID: 20507
		public const short MoonCharm = 485;

		// Token: 0x0400501C RID: 20508
		public const short Ruler = 486;

		// Token: 0x0400501D RID: 20509
		public const short CrystalBall = 487;

		// Token: 0x0400501E RID: 20510
		public const short DiscoBall = 488;

		// Token: 0x0400501F RID: 20511
		public const short SorcererEmblem = 489;

		// Token: 0x04005020 RID: 20512
		public const short WarriorEmblem = 490;

		// Token: 0x04005021 RID: 20513
		public const short RangerEmblem = 491;

		// Token: 0x04005022 RID: 20514
		public const short DemonWings = 492;

		// Token: 0x04005023 RID: 20515
		public const short AngelWings = 493;

		// Token: 0x04005024 RID: 20516
		public const short MagicalHarp = 494;

		// Token: 0x04005025 RID: 20517
		public const short RainbowRod = 495;

		// Token: 0x04005026 RID: 20518
		public const short IceRod = 496;

		// Token: 0x04005027 RID: 20519
		public const short NeptunesShell = 497;

		// Token: 0x04005028 RID: 20520
		public const short Mannequin = 498;

		// Token: 0x04005029 RID: 20521
		public const short GreaterHealingPotion = 499;

		// Token: 0x0400502A RID: 20522
		public const short GreaterManaPotion = 500;

		// Token: 0x0400502B RID: 20523
		public const short PixieDust = 501;

		// Token: 0x0400502C RID: 20524
		public const short CrystalShard = 502;

		// Token: 0x0400502D RID: 20525
		public const short ClownHat = 503;

		// Token: 0x0400502E RID: 20526
		public const short ClownShirt = 504;

		// Token: 0x0400502F RID: 20527
		public const short ClownPants = 505;

		// Token: 0x04005030 RID: 20528
		public const short Flamethrower = 506;

		// Token: 0x04005031 RID: 20529
		public const short Bell = 507;

		// Token: 0x04005032 RID: 20530
		public const short Harp = 508;

		// Token: 0x04005033 RID: 20531
		public const short Wrench = 509;

		// Token: 0x04005034 RID: 20532
		public const short WireCutter = 510;

		// Token: 0x04005035 RID: 20533
		public const short ActiveStoneBlock = 511;

		// Token: 0x04005036 RID: 20534
		public const short InactiveStoneBlock = 512;

		// Token: 0x04005037 RID: 20535
		public const short Lever = 513;

		// Token: 0x04005038 RID: 20536
		public const short LaserRifle = 514;

		// Token: 0x04005039 RID: 20537
		public const short CrystalBullet = 515;

		// Token: 0x0400503A RID: 20538
		public const short HolyArrow = 516;

		// Token: 0x0400503B RID: 20539
		public const short MagicDagger = 517;

		// Token: 0x0400503C RID: 20540
		public const short CrystalStorm = 518;

		// Token: 0x0400503D RID: 20541
		public const short CursedFlames = 519;

		// Token: 0x0400503E RID: 20542
		public const short SoulofLight = 520;

		// Token: 0x0400503F RID: 20543
		public const short SoulofNight = 521;

		// Token: 0x04005040 RID: 20544
		public const short CursedFlame = 522;

		// Token: 0x04005041 RID: 20545
		public const short CursedTorch = 523;

		// Token: 0x04005042 RID: 20546
		public const short AdamantiteForge = 524;

		// Token: 0x04005043 RID: 20547
		public const short MythrilAnvil = 525;

		// Token: 0x04005044 RID: 20548
		public const short UnicornHorn = 526;

		// Token: 0x04005045 RID: 20549
		public const short DarkShard = 527;

		// Token: 0x04005046 RID: 20550
		public const short LightShard = 528;

		// Token: 0x04005047 RID: 20551
		public const short RedPressurePlate = 529;

		// Token: 0x04005048 RID: 20552
		public const short Wire = 530;

		// Token: 0x04005049 RID: 20553
		public const short SpellTome = 531;

		// Token: 0x0400504A RID: 20554
		public const short StarCloak = 532;

		// Token: 0x0400504B RID: 20555
		public const short Megashark = 533;

		// Token: 0x0400504C RID: 20556
		public const short Shotgun = 534;

		// Token: 0x0400504D RID: 20557
		public const short PhilosophersStone = 535;

		// Token: 0x0400504E RID: 20558
		public const short TitanGlove = 536;

		// Token: 0x0400504F RID: 20559
		public const short CobaltNaginata = 537;

		// Token: 0x04005050 RID: 20560
		public const short Switch = 538;

		// Token: 0x04005051 RID: 20561
		public const short DartTrap = 539;

		// Token: 0x04005052 RID: 20562
		public const short Boulder = 540;

		// Token: 0x04005053 RID: 20563
		public const short GreenPressurePlate = 541;

		// Token: 0x04005054 RID: 20564
		public const short GrayPressurePlate = 542;

		// Token: 0x04005055 RID: 20565
		public const short BrownPressurePlate = 543;

		// Token: 0x04005056 RID: 20566
		public const short MechanicalEye = 544;

		// Token: 0x04005057 RID: 20567
		public const short CursedArrow = 545;

		// Token: 0x04005058 RID: 20568
		public const short CursedBullet = 546;

		// Token: 0x04005059 RID: 20569
		public const short SoulofFright = 547;

		// Token: 0x0400505A RID: 20570
		public const short SoulofMight = 548;

		// Token: 0x0400505B RID: 20571
		public const short SoulofSight = 549;

		// Token: 0x0400505C RID: 20572
		public const short Gungnir = 550;

		// Token: 0x0400505D RID: 20573
		public const short HallowedPlateMail = 551;

		// Token: 0x0400505E RID: 20574
		public const short HallowedGreaves = 552;

		// Token: 0x0400505F RID: 20575
		public const short HallowedHelmet = 553;

		// Token: 0x04005060 RID: 20576
		public const short CrossNecklace = 554;

		// Token: 0x04005061 RID: 20577
		public const short ManaFlower = 555;

		// Token: 0x04005062 RID: 20578
		public const short MechanicalWorm = 556;

		// Token: 0x04005063 RID: 20579
		public const short MechanicalSkull = 557;

		// Token: 0x04005064 RID: 20580
		public const short HallowedHeadgear = 558;

		// Token: 0x04005065 RID: 20581
		public const short HallowedMask = 559;

		// Token: 0x04005066 RID: 20582
		public const short SlimeCrown = 560;

		// Token: 0x04005067 RID: 20583
		public const short LightDisc = 561;

		// Token: 0x04005068 RID: 20584
		public const short MusicBoxOverworldDay = 562;

		// Token: 0x04005069 RID: 20585
		public const short MusicBoxEerie = 563;

		// Token: 0x0400506A RID: 20586
		public const short MusicBoxNight = 564;

		// Token: 0x0400506B RID: 20587
		public const short MusicBoxTitle = 565;

		// Token: 0x0400506C RID: 20588
		public const short MusicBoxUnderground = 566;

		// Token: 0x0400506D RID: 20589
		public const short MusicBoxBoss1 = 567;

		// Token: 0x0400506E RID: 20590
		public const short MusicBoxJungle = 568;

		// Token: 0x0400506F RID: 20591
		public const short MusicBoxCorruption = 569;

		// Token: 0x04005070 RID: 20592
		public const short MusicBoxUndergroundCorruption = 570;

		// Token: 0x04005071 RID: 20593
		public const short MusicBoxTheHallow = 571;

		// Token: 0x04005072 RID: 20594
		public const short MusicBoxBoss2 = 572;

		// Token: 0x04005073 RID: 20595
		public const short MusicBoxUndergroundHallow = 573;

		// Token: 0x04005074 RID: 20596
		public const short MusicBoxBoss3 = 574;

		// Token: 0x04005075 RID: 20597
		public const short SoulofFlight = 575;

		// Token: 0x04005076 RID: 20598
		public const short MusicBox = 576;

		// Token: 0x04005077 RID: 20599
		public const short DemoniteBrick = 577;

		// Token: 0x04005078 RID: 20600
		public const short HallowedRepeater = 578;

		// Token: 0x04005079 RID: 20601
		public const short Drax = 579;

		// Token: 0x0400507A RID: 20602
		public const short Explosives = 580;

		// Token: 0x0400507B RID: 20603
		public const short InletPump = 581;

		// Token: 0x0400507C RID: 20604
		public const short OutletPump = 582;

		// Token: 0x0400507D RID: 20605
		public const short Timer1Second = 583;

		// Token: 0x0400507E RID: 20606
		public const short Timer3Second = 584;

		// Token: 0x0400507F RID: 20607
		public const short Timer5Second = 585;

		// Token: 0x04005080 RID: 20608
		public const short CandyCaneBlock = 586;

		// Token: 0x04005081 RID: 20609
		public const short CandyCaneWall = 587;

		// Token: 0x04005082 RID: 20610
		public const short SantaHat = 588;

		// Token: 0x04005083 RID: 20611
		public const short SantaShirt = 589;

		// Token: 0x04005084 RID: 20612
		public const short SantaPants = 590;

		// Token: 0x04005085 RID: 20613
		public const short GreenCandyCaneBlock = 591;

		// Token: 0x04005086 RID: 20614
		public const short GreenCandyCaneWall = 592;

		// Token: 0x04005087 RID: 20615
		public const short SnowBlock = 593;

		// Token: 0x04005088 RID: 20616
		public const short SnowBrick = 594;

		// Token: 0x04005089 RID: 20617
		public const short SnowBrickWall = 595;

		// Token: 0x0400508A RID: 20618
		public const short BlueLight = 596;

		// Token: 0x0400508B RID: 20619
		public const short RedLight = 597;

		// Token: 0x0400508C RID: 20620
		public const short GreenLight = 598;

		// Token: 0x0400508D RID: 20621
		public const short BluePresent = 599;

		// Token: 0x0400508E RID: 20622
		public const short GreenPresent = 600;

		// Token: 0x0400508F RID: 20623
		public const short YellowPresent = 601;

		// Token: 0x04005090 RID: 20624
		public const short SnowGlobe = 602;

		// Token: 0x04005091 RID: 20625
		public const short Carrot = 603;

		// Token: 0x04005092 RID: 20626
		public const short AdamantiteBeam = 604;

		// Token: 0x04005093 RID: 20627
		public const short AdamantiteBeamWall = 605;

		// Token: 0x04005094 RID: 20628
		public const short DemoniteBrickWall = 606;

		// Token: 0x04005095 RID: 20629
		public const short SandstoneBrick = 607;

		// Token: 0x04005096 RID: 20630
		public const short SandstoneBrickWall = 608;

		// Token: 0x04005097 RID: 20631
		public const short EbonstoneBrick = 609;

		// Token: 0x04005098 RID: 20632
		public const short EbonstoneBrickWall = 610;

		// Token: 0x04005099 RID: 20633
		public const short RedStucco = 611;

		// Token: 0x0400509A RID: 20634
		public const short YellowStucco = 612;

		// Token: 0x0400509B RID: 20635
		public const short GreenStucco = 613;

		// Token: 0x0400509C RID: 20636
		public const short GrayStucco = 614;

		// Token: 0x0400509D RID: 20637
		public const short RedStuccoWall = 615;

		// Token: 0x0400509E RID: 20638
		public const short YellowStuccoWall = 616;

		// Token: 0x0400509F RID: 20639
		public const short GreenStuccoWall = 617;

		// Token: 0x040050A0 RID: 20640
		public const short GrayStuccoWall = 618;

		// Token: 0x040050A1 RID: 20641
		public const short Ebonwood = 619;

		// Token: 0x040050A2 RID: 20642
		public const short RichMahogany = 620;

		// Token: 0x040050A3 RID: 20643
		public const short Pearlwood = 621;

		// Token: 0x040050A4 RID: 20644
		public const short EbonwoodWall = 622;

		// Token: 0x040050A5 RID: 20645
		public const short RichMahoganyWall = 623;

		// Token: 0x040050A6 RID: 20646
		public const short PearlwoodWall = 624;

		// Token: 0x040050A7 RID: 20647
		public const short EbonwoodChest = 625;

		// Token: 0x040050A8 RID: 20648
		public const short RichMahoganyChest = 626;

		// Token: 0x040050A9 RID: 20649
		public const short PearlwoodChest = 627;

		// Token: 0x040050AA RID: 20650
		public const short EbonwoodChair = 628;

		// Token: 0x040050AB RID: 20651
		public const short RichMahoganyChair = 629;

		// Token: 0x040050AC RID: 20652
		public const short PearlwoodChair = 630;

		// Token: 0x040050AD RID: 20653
		public const short EbonwoodPlatform = 631;

		// Token: 0x040050AE RID: 20654
		public const short RichMahoganyPlatform = 632;

		// Token: 0x040050AF RID: 20655
		public const short PearlwoodPlatform = 633;

		// Token: 0x040050B0 RID: 20656
		public const short BonePlatform = 634;

		// Token: 0x040050B1 RID: 20657
		public const short EbonwoodWorkBench = 635;

		// Token: 0x040050B2 RID: 20658
		public const short RichMahoganyWorkBench = 636;

		// Token: 0x040050B3 RID: 20659
		public const short PearlwoodWorkBench = 637;

		// Token: 0x040050B4 RID: 20660
		public const short EbonwoodTable = 638;

		// Token: 0x040050B5 RID: 20661
		public const short RichMahoganyTable = 639;

		// Token: 0x040050B6 RID: 20662
		public const short PearlwoodTable = 640;

		// Token: 0x040050B7 RID: 20663
		public const short EbonwoodPiano = 641;

		// Token: 0x040050B8 RID: 20664
		public const short RichMahoganyPiano = 642;

		// Token: 0x040050B9 RID: 20665
		public const short PearlwoodPiano = 643;

		// Token: 0x040050BA RID: 20666
		public const short EbonwoodBed = 644;

		// Token: 0x040050BB RID: 20667
		public const short RichMahoganyBed = 645;

		// Token: 0x040050BC RID: 20668
		public const short PearlwoodBed = 646;

		// Token: 0x040050BD RID: 20669
		public const short EbonwoodDresser = 647;

		// Token: 0x040050BE RID: 20670
		public const short RichMahoganyDresser = 648;

		// Token: 0x040050BF RID: 20671
		public const short PearlwoodDresser = 649;

		// Token: 0x040050C0 RID: 20672
		public const short EbonwoodDoor = 650;

		// Token: 0x040050C1 RID: 20673
		public const short RichMahoganyDoor = 651;

		// Token: 0x040050C2 RID: 20674
		public const short PearlwoodDoor = 652;

		// Token: 0x040050C3 RID: 20675
		public const short EbonwoodSword = 653;

		// Token: 0x040050C4 RID: 20676
		public const short EbonwoodHammer = 654;

		// Token: 0x040050C5 RID: 20677
		public const short EbonwoodBow = 655;

		// Token: 0x040050C6 RID: 20678
		public const short RichMahoganySword = 656;

		// Token: 0x040050C7 RID: 20679
		public const short RichMahoganyHammer = 657;

		// Token: 0x040050C8 RID: 20680
		public const short RichMahoganyBow = 658;

		// Token: 0x040050C9 RID: 20681
		public const short PearlwoodSword = 659;

		// Token: 0x040050CA RID: 20682
		public const short PearlwoodHammer = 660;

		// Token: 0x040050CB RID: 20683
		public const short PearlwoodBow = 661;

		// Token: 0x040050CC RID: 20684
		public const short RainbowBrick = 662;

		// Token: 0x040050CD RID: 20685
		public const short RainbowBrickWall = 663;

		// Token: 0x040050CE RID: 20686
		public const short IceBlock = 664;

		// Token: 0x040050CF RID: 20687
		public const short RedsWings = 665;

		// Token: 0x040050D0 RID: 20688
		public const short RedsHelmet = 666;

		// Token: 0x040050D1 RID: 20689
		public const short RedsBreastplate = 667;

		// Token: 0x040050D2 RID: 20690
		public const short RedsLeggings = 668;

		// Token: 0x040050D3 RID: 20691
		public const short Fish = 669;

		// Token: 0x040050D4 RID: 20692
		public const short IceBoomerang = 670;

		// Token: 0x040050D5 RID: 20693
		public const short Keybrand = 671;

		// Token: 0x040050D6 RID: 20694
		public const short Cutlass = 672;

		// Token: 0x040050D7 RID: 20695
		public const short BorealWoodWorkBench = 673;

		// Token: 0x040050D8 RID: 20696
		public const short TrueExcalibur = 674;

		// Token: 0x040050D9 RID: 20697
		public const short TrueNightsEdge = 675;

		// Token: 0x040050DA RID: 20698
		public const short Frostbrand = 676;

		// Token: 0x040050DB RID: 20699
		public const short BorealWoodTable = 677;

		// Token: 0x040050DC RID: 20700
		public const short RedPotion = 678;

		// Token: 0x040050DD RID: 20701
		public const short TacticalShotgun = 679;

		// Token: 0x040050DE RID: 20702
		public const short IvyChest = 680;

		// Token: 0x040050DF RID: 20703
		public const short IceChest = 681;

		// Token: 0x040050E0 RID: 20704
		public const short Marrow = 682;

		// Token: 0x040050E1 RID: 20705
		public const short UnholyTrident = 683;

		// Token: 0x040050E2 RID: 20706
		public const short FrostHelmet = 684;

		// Token: 0x040050E3 RID: 20707
		public const short FrostBreastplate = 685;

		// Token: 0x040050E4 RID: 20708
		public const short FrostLeggings = 686;

		// Token: 0x040050E5 RID: 20709
		public const short TinHelmet = 687;

		// Token: 0x040050E6 RID: 20710
		public const short TinChainmail = 688;

		// Token: 0x040050E7 RID: 20711
		public const short TinGreaves = 689;

		// Token: 0x040050E8 RID: 20712
		public const short LeadHelmet = 690;

		// Token: 0x040050E9 RID: 20713
		public const short LeadChainmail = 691;

		// Token: 0x040050EA RID: 20714
		public const short LeadGreaves = 692;

		// Token: 0x040050EB RID: 20715
		public const short TungstenHelmet = 693;

		// Token: 0x040050EC RID: 20716
		public const short TungstenChainmail = 694;

		// Token: 0x040050ED RID: 20717
		public const short TungstenGreaves = 695;

		// Token: 0x040050EE RID: 20718
		public const short PlatinumHelmet = 696;

		// Token: 0x040050EF RID: 20719
		public const short PlatinumChainmail = 697;

		// Token: 0x040050F0 RID: 20720
		public const short PlatinumGreaves = 698;

		// Token: 0x040050F1 RID: 20721
		public const short TinOre = 699;

		// Token: 0x040050F2 RID: 20722
		public const short LeadOre = 700;

		// Token: 0x040050F3 RID: 20723
		public const short TungstenOre = 701;

		// Token: 0x040050F4 RID: 20724
		public const short PlatinumOre = 702;

		// Token: 0x040050F5 RID: 20725
		public const short TinBar = 703;

		// Token: 0x040050F6 RID: 20726
		public const short LeadBar = 704;

		// Token: 0x040050F7 RID: 20727
		public const short TungstenBar = 705;

		// Token: 0x040050F8 RID: 20728
		public const short PlatinumBar = 706;

		// Token: 0x040050F9 RID: 20729
		public const short TinWatch = 707;

		// Token: 0x040050FA RID: 20730
		public const short TungstenWatch = 708;

		// Token: 0x040050FB RID: 20731
		public const short PlatinumWatch = 709;

		// Token: 0x040050FC RID: 20732
		public const short TinChandelier = 710;

		// Token: 0x040050FD RID: 20733
		public const short TungstenChandelier = 711;

		// Token: 0x040050FE RID: 20734
		public const short PlatinumChandelier = 712;

		// Token: 0x040050FF RID: 20735
		public const short PlatinumCandle = 713;

		// Token: 0x04005100 RID: 20736
		public const short PlatinumCandelabra = 714;

		// Token: 0x04005101 RID: 20737
		public const short PlatinumCrown = 715;

		// Token: 0x04005102 RID: 20738
		public const short LeadAnvil = 716;

		// Token: 0x04005103 RID: 20739
		public const short TinBrick = 717;

		// Token: 0x04005104 RID: 20740
		public const short TungstenBrick = 718;

		// Token: 0x04005105 RID: 20741
		public const short PlatinumBrick = 719;

		// Token: 0x04005106 RID: 20742
		public const short TinBrickWall = 720;

		// Token: 0x04005107 RID: 20743
		public const short TungstenBrickWall = 721;

		// Token: 0x04005108 RID: 20744
		public const short PlatinumBrickWall = 722;

		// Token: 0x04005109 RID: 20745
		public const short BeamSword = 723;

		// Token: 0x0400510A RID: 20746
		public const short IceBlade = 724;

		// Token: 0x0400510B RID: 20747
		public const short IceBow = 725;

		// Token: 0x0400510C RID: 20748
		public const short FrostStaff = 726;

		// Token: 0x0400510D RID: 20749
		public const short WoodHelmet = 727;

		// Token: 0x0400510E RID: 20750
		public const short WoodBreastplate = 728;

		// Token: 0x0400510F RID: 20751
		public const short WoodGreaves = 729;

		// Token: 0x04005110 RID: 20752
		public const short EbonwoodHelmet = 730;

		// Token: 0x04005111 RID: 20753
		public const short EbonwoodBreastplate = 731;

		// Token: 0x04005112 RID: 20754
		public const short EbonwoodGreaves = 732;

		// Token: 0x04005113 RID: 20755
		public const short RichMahoganyHelmet = 733;

		// Token: 0x04005114 RID: 20756
		public const short RichMahoganyBreastplate = 734;

		// Token: 0x04005115 RID: 20757
		public const short RichMahoganyGreaves = 735;

		// Token: 0x04005116 RID: 20758
		public const short PearlwoodHelmet = 736;

		// Token: 0x04005117 RID: 20759
		public const short PearlwoodBreastplate = 737;

		// Token: 0x04005118 RID: 20760
		public const short PearlwoodGreaves = 738;

		// Token: 0x04005119 RID: 20761
		public const short AmethystStaff = 739;

		// Token: 0x0400511A RID: 20762
		public const short TopazStaff = 740;

		// Token: 0x0400511B RID: 20763
		public const short SapphireStaff = 741;

		// Token: 0x0400511C RID: 20764
		public const short EmeraldStaff = 742;

		// Token: 0x0400511D RID: 20765
		public const short RubyStaff = 743;

		// Token: 0x0400511E RID: 20766
		public const short DiamondStaff = 744;

		// Token: 0x0400511F RID: 20767
		public const short GrassWall = 745;

		// Token: 0x04005120 RID: 20768
		public const short JungleWall = 746;

		// Token: 0x04005121 RID: 20769
		public const short FlowerWall = 747;

		// Token: 0x04005122 RID: 20770
		public const short Jetpack = 748;

		// Token: 0x04005123 RID: 20771
		public const short ButterflyWings = 749;

		// Token: 0x04005124 RID: 20772
		public const short CactusWall = 750;

		// Token: 0x04005125 RID: 20773
		public const short Cloud = 751;

		// Token: 0x04005126 RID: 20774
		public const short CloudWall = 752;

		// Token: 0x04005127 RID: 20775
		public const short Seaweed = 753;

		// Token: 0x04005128 RID: 20776
		public const short RuneHat = 754;

		// Token: 0x04005129 RID: 20777
		public const short RuneRobe = 755;

		// Token: 0x0400512A RID: 20778
		public const short MushroomSpear = 756;

		// Token: 0x0400512B RID: 20779
		public const short TerraBlade = 757;

		// Token: 0x0400512C RID: 20780
		public const short GrenadeLauncher = 758;

		// Token: 0x0400512D RID: 20781
		public const short RocketLauncher = 759;

		// Token: 0x0400512E RID: 20782
		public const short ProximityMineLauncher = 760;

		// Token: 0x0400512F RID: 20783
		public const short FairyWings = 761;

		// Token: 0x04005130 RID: 20784
		public const short SlimeBlock = 762;

		// Token: 0x04005131 RID: 20785
		public const short FleshBlock = 763;

		// Token: 0x04005132 RID: 20786
		public const short MushroomWall = 764;

		// Token: 0x04005133 RID: 20787
		public const short RainCloud = 765;

		// Token: 0x04005134 RID: 20788
		public const short BoneBlock = 766;

		// Token: 0x04005135 RID: 20789
		public const short FrozenSlimeBlock = 767;

		// Token: 0x04005136 RID: 20790
		public const short BoneBlockWall = 768;

		// Token: 0x04005137 RID: 20791
		public const short SlimeBlockWall = 769;

		// Token: 0x04005138 RID: 20792
		public const short FleshBlockWall = 770;

		// Token: 0x04005139 RID: 20793
		public const short RocketI = 771;

		// Token: 0x0400513A RID: 20794
		public const short RocketII = 772;

		// Token: 0x0400513B RID: 20795
		public const short RocketIII = 773;

		// Token: 0x0400513C RID: 20796
		public const short RocketIV = 774;

		// Token: 0x0400513D RID: 20797
		public const short AsphaltBlock = 775;

		// Token: 0x0400513E RID: 20798
		public const short CobaltPickaxe = 776;

		// Token: 0x0400513F RID: 20799
		public const short MythrilPickaxe = 777;

		// Token: 0x04005140 RID: 20800
		public const short AdamantitePickaxe = 778;

		// Token: 0x04005141 RID: 20801
		public const short Clentaminator = 779;

		// Token: 0x04005142 RID: 20802
		public const short GreenSolution = 780;

		// Token: 0x04005143 RID: 20803
		public const short BlueSolution = 781;

		// Token: 0x04005144 RID: 20804
		public const short PurpleSolution = 782;

		// Token: 0x04005145 RID: 20805
		public const short DarkBlueSolution = 783;

		// Token: 0x04005146 RID: 20806
		public const short RedSolution = 784;

		// Token: 0x04005147 RID: 20807
		public const short HarpyWings = 785;

		// Token: 0x04005148 RID: 20808
		public const short BoneWings = 786;

		// Token: 0x04005149 RID: 20809
		public const short Hammush = 787;

		// Token: 0x0400514A RID: 20810
		public const short NettleBurst = 788;

		// Token: 0x0400514B RID: 20811
		public const short AnkhBanner = 789;

		// Token: 0x0400514C RID: 20812
		public const short SnakeBanner = 790;

		// Token: 0x0400514D RID: 20813
		public const short OmegaBanner = 791;

		// Token: 0x0400514E RID: 20814
		public const short CrimsonHelmet = 792;

		// Token: 0x0400514F RID: 20815
		public const short CrimsonScalemail = 793;

		// Token: 0x04005150 RID: 20816
		public const short CrimsonGreaves = 794;

		// Token: 0x04005151 RID: 20817
		public const short BloodButcherer = 795;

		// Token: 0x04005152 RID: 20818
		public const short TendonBow = 796;

		// Token: 0x04005153 RID: 20819
		public const short FleshGrinder = 797;

		// Token: 0x04005154 RID: 20820
		public const short DeathbringerPickaxe = 798;

		// Token: 0x04005155 RID: 20821
		public const short BloodLustCluster = 799;

		// Token: 0x04005156 RID: 20822
		public const short TheUndertaker = 800;

		// Token: 0x04005157 RID: 20823
		public const short TheMeatball = 801;

		// Token: 0x04005158 RID: 20824
		public const short TheRottedFork = 802;

		// Token: 0x04005159 RID: 20825
		public const short EskimoHood = 803;

		// Token: 0x0400515A RID: 20826
		public const short EskimoCoat = 804;

		// Token: 0x0400515B RID: 20827
		public const short EskimoPants = 805;

		// Token: 0x0400515C RID: 20828
		public const short LivingWoodChair = 806;

		// Token: 0x0400515D RID: 20829
		public const short CactusChair = 807;

		// Token: 0x0400515E RID: 20830
		public const short BoneChair = 808;

		// Token: 0x0400515F RID: 20831
		public const short FleshChair = 809;

		// Token: 0x04005160 RID: 20832
		public const short MushroomChair = 810;

		// Token: 0x04005161 RID: 20833
		public const short BoneWorkBench = 811;

		// Token: 0x04005162 RID: 20834
		public const short CactusWorkBench = 812;

		// Token: 0x04005163 RID: 20835
		public const short FleshWorkBench = 813;

		// Token: 0x04005164 RID: 20836
		public const short MushroomWorkBench = 814;

		// Token: 0x04005165 RID: 20837
		public const short SlimeWorkBench = 815;

		// Token: 0x04005166 RID: 20838
		public const short CactusDoor = 816;

		// Token: 0x04005167 RID: 20839
		public const short FleshDoor = 817;

		// Token: 0x04005168 RID: 20840
		public const short MushroomDoor = 818;

		// Token: 0x04005169 RID: 20841
		public const short LivingWoodDoor = 819;

		// Token: 0x0400516A RID: 20842
		public const short BoneDoor = 820;

		// Token: 0x0400516B RID: 20843
		public const short FlameWings = 821;

		// Token: 0x0400516C RID: 20844
		public const short FrozenWings = 822;

		// Token: 0x0400516D RID: 20845
		public const short GhostWings = 823;

		// Token: 0x0400516E RID: 20846
		public const short SunplateBlock = 824;

		// Token: 0x0400516F RID: 20847
		public const short DiscWall = 825;

		// Token: 0x04005170 RID: 20848
		public const short SkywareChair = 826;

		// Token: 0x04005171 RID: 20849
		public const short BoneTable = 827;

		// Token: 0x04005172 RID: 20850
		public const short FleshTable = 828;

		// Token: 0x04005173 RID: 20851
		public const short LivingWoodTable = 829;

		// Token: 0x04005174 RID: 20852
		public const short SkywareTable = 830;

		// Token: 0x04005175 RID: 20853
		public const short LivingWoodChest = 831;

		// Token: 0x04005176 RID: 20854
		public const short LivingWoodWand = 832;

		// Token: 0x04005177 RID: 20855
		public const short PurpleIceBlock = 833;

		// Token: 0x04005178 RID: 20856
		public const short PinkIceBlock = 834;

		// Token: 0x04005179 RID: 20857
		public const short RedIceBlock = 835;

		// Token: 0x0400517A RID: 20858
		public const short CrimstoneBlock = 836;

		// Token: 0x0400517B RID: 20859
		public const short SkywareDoor = 837;

		// Token: 0x0400517C RID: 20860
		public const short SkywareChest = 838;

		// Token: 0x0400517D RID: 20861
		public const short SteampunkHat = 839;

		// Token: 0x0400517E RID: 20862
		public const short SteampunkShirt = 840;

		// Token: 0x0400517F RID: 20863
		public const short SteampunkPants = 841;

		// Token: 0x04005180 RID: 20864
		public const short BeeHat = 842;

		// Token: 0x04005181 RID: 20865
		public const short BeeShirt = 843;

		// Token: 0x04005182 RID: 20866
		public const short BeePants = 844;

		// Token: 0x04005183 RID: 20867
		public const short WorldBanner = 845;

		// Token: 0x04005184 RID: 20868
		public const short SunBanner = 846;

		// Token: 0x04005185 RID: 20869
		public const short GravityBanner = 847;

		// Token: 0x04005186 RID: 20870
		public const short PharaohsMask = 848;

		// Token: 0x04005187 RID: 20871
		public const short Actuator = 849;

		// Token: 0x04005188 RID: 20872
		public const short BlueWrench = 850;

		// Token: 0x04005189 RID: 20873
		public const short GreenWrench = 851;

		// Token: 0x0400518A RID: 20874
		public const short BluePressurePlate = 852;

		// Token: 0x0400518B RID: 20875
		public const short YellowPressurePlate = 853;

		// Token: 0x0400518C RID: 20876
		public const short DiscountCard = 854;

		// Token: 0x0400518D RID: 20877
		public const short LuckyCoin = 855;

		// Token: 0x0400518E RID: 20878
		public const short UnicornonaStick = 856;

		// Token: 0x0400518F RID: 20879
		public const short SandstorminaBottle = 857;

		// Token: 0x04005190 RID: 20880
		public const short BorealWoodSofa = 858;

		// Token: 0x04005191 RID: 20881
		public const short BeachBall = 859;

		// Token: 0x04005192 RID: 20882
		public const short CharmofMyths = 860;

		// Token: 0x04005193 RID: 20883
		public const short MoonShell = 861;

		// Token: 0x04005194 RID: 20884
		public const short StarVeil = 862;

		// Token: 0x04005195 RID: 20885
		public const short WaterWalkingBoots = 863;

		// Token: 0x04005196 RID: 20886
		public const short Tiara = 864;

		// Token: 0x04005197 RID: 20887
		public const short PrincessDress = 865;

		// Token: 0x04005198 RID: 20888
		public const short PharaohsRobe = 866;

		// Token: 0x04005199 RID: 20889
		public const short GreenCap = 867;

		// Token: 0x0400519A RID: 20890
		public const short MushroomCap = 868;

		// Token: 0x0400519B RID: 20891
		public const short TamOShanter = 869;

		// Token: 0x0400519C RID: 20892
		public const short MummyMask = 870;

		// Token: 0x0400519D RID: 20893
		public const short MummyShirt = 871;

		// Token: 0x0400519E RID: 20894
		public const short MummyPants = 872;

		// Token: 0x0400519F RID: 20895
		public const short CowboyHat = 873;

		// Token: 0x040051A0 RID: 20896
		public const short CowboyJacket = 874;

		// Token: 0x040051A1 RID: 20897
		public const short CowboyPants = 875;

		// Token: 0x040051A2 RID: 20898
		public const short PirateHat = 876;

		// Token: 0x040051A3 RID: 20899
		public const short PirateShirt = 877;

		// Token: 0x040051A4 RID: 20900
		public const short PiratePants = 878;

		// Token: 0x040051A5 RID: 20901
		public const short VikingHelmet = 879;

		// Token: 0x040051A6 RID: 20902
		public const short CrimtaneOre = 880;

		// Token: 0x040051A7 RID: 20903
		public const short CactusSword = 881;

		// Token: 0x040051A8 RID: 20904
		public const short CactusPickaxe = 882;

		// Token: 0x040051A9 RID: 20905
		public const short IceBrick = 883;

		// Token: 0x040051AA RID: 20906
		public const short IceBrickWall = 884;

		// Token: 0x040051AB RID: 20907
		public const short AdhesiveBandage = 885;

		// Token: 0x040051AC RID: 20908
		public const short ArmorPolish = 886;

		// Token: 0x040051AD RID: 20909
		public const short Bezoar = 887;

		// Token: 0x040051AE RID: 20910
		public const short Blindfold = 888;

		// Token: 0x040051AF RID: 20911
		public const short FastClock = 889;

		// Token: 0x040051B0 RID: 20912
		public const short Megaphone = 890;

		// Token: 0x040051B1 RID: 20913
		public const short Nazar = 891;

		// Token: 0x040051B2 RID: 20914
		public const short Vitamins = 892;

		// Token: 0x040051B3 RID: 20915
		public const short TrifoldMap = 893;

		// Token: 0x040051B4 RID: 20916
		public const short CactusHelmet = 894;

		// Token: 0x040051B5 RID: 20917
		public const short CactusBreastplate = 895;

		// Token: 0x040051B6 RID: 20918
		public const short CactusLeggings = 896;

		// Token: 0x040051B7 RID: 20919
		public const short PowerGlove = 897;

		// Token: 0x040051B8 RID: 20920
		public const short LightningBoots = 898;

		// Token: 0x040051B9 RID: 20921
		public const short SunStone = 899;

		// Token: 0x040051BA RID: 20922
		public const short MoonStone = 900;

		// Token: 0x040051BB RID: 20923
		public const short ArmorBracing = 901;

		// Token: 0x040051BC RID: 20924
		public const short MedicatedBandage = 902;

		// Token: 0x040051BD RID: 20925
		public const short ThePlan = 903;

		// Token: 0x040051BE RID: 20926
		public const short CountercurseMantra = 904;

		// Token: 0x040051BF RID: 20927
		public const short CoinGun = 905;

		// Token: 0x040051C0 RID: 20928
		public const short LavaCharm = 906;

		// Token: 0x040051C1 RID: 20929
		public const short ObsidianWaterWalkingBoots = 907;

		// Token: 0x040051C2 RID: 20930
		public const short LavaWaders = 908;

		// Token: 0x040051C3 RID: 20931
		public const short PureWaterFountain = 909;

		// Token: 0x040051C4 RID: 20932
		public const short DesertWaterFountain = 910;

		// Token: 0x040051C5 RID: 20933
		public const short Shadewood = 911;

		// Token: 0x040051C6 RID: 20934
		public const short ShadewoodDoor = 912;

		// Token: 0x040051C7 RID: 20935
		public const short ShadewoodPlatform = 913;

		// Token: 0x040051C8 RID: 20936
		public const short ShadewoodChest = 914;

		// Token: 0x040051C9 RID: 20937
		public const short ShadewoodChair = 915;

		// Token: 0x040051CA RID: 20938
		public const short ShadewoodWorkBench = 916;

		// Token: 0x040051CB RID: 20939
		public const short ShadewoodTable = 917;

		// Token: 0x040051CC RID: 20940
		public const short ShadewoodDresser = 918;

		// Token: 0x040051CD RID: 20941
		public const short ShadewoodPiano = 919;

		// Token: 0x040051CE RID: 20942
		public const short ShadewoodBed = 920;

		// Token: 0x040051CF RID: 20943
		public const short ShadewoodSword = 921;

		// Token: 0x040051D0 RID: 20944
		public const short ShadewoodHammer = 922;

		// Token: 0x040051D1 RID: 20945
		public const short ShadewoodBow = 923;

		// Token: 0x040051D2 RID: 20946
		public const short ShadewoodHelmet = 924;

		// Token: 0x040051D3 RID: 20947
		public const short ShadewoodBreastplate = 925;

		// Token: 0x040051D4 RID: 20948
		public const short ShadewoodGreaves = 926;

		// Token: 0x040051D5 RID: 20949
		public const short ShadewoodWall = 927;

		// Token: 0x040051D6 RID: 20950
		public const short Cannon = 928;

		// Token: 0x040051D7 RID: 20951
		public const short Cannonball = 929;

		// Token: 0x040051D8 RID: 20952
		public const short FlareGun = 930;

		// Token: 0x040051D9 RID: 20953
		public const short Flare = 931;

		// Token: 0x040051DA RID: 20954
		public const short BoneWand = 932;

		// Token: 0x040051DB RID: 20955
		public const short LeafWand = 933;

		// Token: 0x040051DC RID: 20956
		public const short FlyingCarpet = 934;

		// Token: 0x040051DD RID: 20957
		public const short AvengerEmblem = 935;

		// Token: 0x040051DE RID: 20958
		public const short MechanicalGlove = 936;

		// Token: 0x040051DF RID: 20959
		public const short LandMine = 937;

		// Token: 0x040051E0 RID: 20960
		public const short PaladinsShield = 938;

		// Token: 0x040051E1 RID: 20961
		public const short WebSlinger = 939;

		// Token: 0x040051E2 RID: 20962
		public const short JungleWaterFountain = 940;

		// Token: 0x040051E3 RID: 20963
		public const short IcyWaterFountain = 941;

		// Token: 0x040051E4 RID: 20964
		public const short CorruptWaterFountain = 942;

		// Token: 0x040051E5 RID: 20965
		public const short CrimsonWaterFountain = 943;

		// Token: 0x040051E6 RID: 20966
		public const short HallowedWaterFountain = 944;

		// Token: 0x040051E7 RID: 20967
		public const short BloodWaterFountain = 945;

		// Token: 0x040051E8 RID: 20968
		public const short Umbrella = 946;

		// Token: 0x040051E9 RID: 20969
		public const short ChlorophyteOre = 947;

		// Token: 0x040051EA RID: 20970
		public const short SteampunkWings = 948;

		// Token: 0x040051EB RID: 20971
		public const short Snowball = 949;

		// Token: 0x040051EC RID: 20972
		public const short IceSkates = 950;

		// Token: 0x040051ED RID: 20973
		public const short SnowballLauncher = 951;

		// Token: 0x040051EE RID: 20974
		public const short WebCoveredChest = 952;

		// Token: 0x040051EF RID: 20975
		public const short ClimbingClaws = 953;

		// Token: 0x040051F0 RID: 20976
		public const short AncientIronHelmet = 954;

		// Token: 0x040051F1 RID: 20977
		public const short AncientGoldHelmet = 955;

		// Token: 0x040051F2 RID: 20978
		public const short AncientShadowHelmet = 956;

		// Token: 0x040051F3 RID: 20979
		public const short AncientShadowScalemail = 957;

		// Token: 0x040051F4 RID: 20980
		public const short AncientShadowGreaves = 958;

		// Token: 0x040051F5 RID: 20981
		public const short AncientNecroHelmet = 959;

		// Token: 0x040051F6 RID: 20982
		public const short AncientCobaltHelmet = 960;

		// Token: 0x040051F7 RID: 20983
		public const short AncientCobaltBreastplate = 961;

		// Token: 0x040051F8 RID: 20984
		public const short AncientCobaltLeggings = 962;

		// Token: 0x040051F9 RID: 20985
		public const short BlackBelt = 963;

		// Token: 0x040051FA RID: 20986
		public const short Boomstick = 964;

		// Token: 0x040051FB RID: 20987
		public const short Rope = 965;

		// Token: 0x040051FC RID: 20988
		public const short Campfire = 966;

		// Token: 0x040051FD RID: 20989
		public const short Marshmallow = 967;

		// Token: 0x040051FE RID: 20990
		public const short MarshmallowonaStick = 968;

		// Token: 0x040051FF RID: 20991
		public const short CookedMarshmallow = 969;

		// Token: 0x04005200 RID: 20992
		public const short RedRocket = 970;

		// Token: 0x04005201 RID: 20993
		public const short GreenRocket = 971;

		// Token: 0x04005202 RID: 20994
		public const short BlueRocket = 972;

		// Token: 0x04005203 RID: 20995
		public const short YellowRocket = 973;

		// Token: 0x04005204 RID: 20996
		public const short IceTorch = 974;

		// Token: 0x04005205 RID: 20997
		public const short ShoeSpikes = 975;

		// Token: 0x04005206 RID: 20998
		public const short TigerClimbingGear = 976;

		// Token: 0x04005207 RID: 20999
		public const short Tabi = 977;

		// Token: 0x04005208 RID: 21000
		public const short PinkEskimoHood = 978;

		// Token: 0x04005209 RID: 21001
		public const short PinkEskimoCoat = 979;

		// Token: 0x0400520A RID: 21002
		public const short PinkEskimoPants = 980;

		// Token: 0x0400520B RID: 21003
		public const short PinkThread = 981;

		// Token: 0x0400520C RID: 21004
		public const short ManaRegenerationBand = 982;

		// Token: 0x0400520D RID: 21005
		public const short SandstorminaBalloon = 983;

		// Token: 0x0400520E RID: 21006
		public const short MasterNinjaGear = 984;

		// Token: 0x0400520F RID: 21007
		public const short RopeCoil = 985;

		// Token: 0x04005210 RID: 21008
		public const short Blowgun = 986;

		// Token: 0x04005211 RID: 21009
		public const short BlizzardinaBottle = 987;

		// Token: 0x04005212 RID: 21010
		public const short FrostburnArrow = 988;

		// Token: 0x04005213 RID: 21011
		public const short EnchantedSword = 989;

		// Token: 0x04005214 RID: 21012
		public const short PickaxeAxe = 990;

		// Token: 0x04005215 RID: 21013
		public const short CobaltWaraxe = 991;

		// Token: 0x04005216 RID: 21014
		public const short MythrilWaraxe = 992;

		// Token: 0x04005217 RID: 21015
		public const short AdamantiteWaraxe = 993;

		// Token: 0x04005218 RID: 21016
		public const short EatersBone = 994;

		// Token: 0x04005219 RID: 21017
		public const short BlendOMatic = 995;

		// Token: 0x0400521A RID: 21018
		public const short MeatGrinder = 996;

		// Token: 0x0400521B RID: 21019
		public const short Extractinator = 997;

		// Token: 0x0400521C RID: 21020
		public const short Solidifier = 998;

		// Token: 0x0400521D RID: 21021
		public const short Amber = 999;

		// Token: 0x0400521E RID: 21022
		public const short ConfettiGun = 1000;

		// Token: 0x0400521F RID: 21023
		public const short ChlorophyteMask = 1001;

		// Token: 0x04005220 RID: 21024
		public const short ChlorophyteHelmet = 1002;

		// Token: 0x04005221 RID: 21025
		public const short ChlorophyteHeadgear = 1003;

		// Token: 0x04005222 RID: 21026
		public const short ChlorophytePlateMail = 1004;

		// Token: 0x04005223 RID: 21027
		public const short ChlorophyteGreaves = 1005;

		// Token: 0x04005224 RID: 21028
		public const short ChlorophyteBar = 1006;

		// Token: 0x04005225 RID: 21029
		public const short RedDye = 1007;

		// Token: 0x04005226 RID: 21030
		public const short OrangeDye = 1008;

		// Token: 0x04005227 RID: 21031
		public const short YellowDye = 1009;

		// Token: 0x04005228 RID: 21032
		public const short LimeDye = 1010;

		// Token: 0x04005229 RID: 21033
		public const short GreenDye = 1011;

		// Token: 0x0400522A RID: 21034
		public const short TealDye = 1012;

		// Token: 0x0400522B RID: 21035
		public const short CyanDye = 1013;

		// Token: 0x0400522C RID: 21036
		public const short SkyBlueDye = 1014;

		// Token: 0x0400522D RID: 21037
		public const short BlueDye = 1015;

		// Token: 0x0400522E RID: 21038
		public const short PurpleDye = 1016;

		// Token: 0x0400522F RID: 21039
		public const short VioletDye = 1017;

		// Token: 0x04005230 RID: 21040
		public const short PinkDye = 1018;

		// Token: 0x04005231 RID: 21041
		public const short RedandBlackDye = 1019;

		// Token: 0x04005232 RID: 21042
		public const short OrangeandBlackDye = 1020;

		// Token: 0x04005233 RID: 21043
		public const short YellowandBlackDye = 1021;

		// Token: 0x04005234 RID: 21044
		public const short LimeandBlackDye = 1022;

		// Token: 0x04005235 RID: 21045
		public const short GreenandBlackDye = 1023;

		// Token: 0x04005236 RID: 21046
		public const short TealandBlackDye = 1024;

		// Token: 0x04005237 RID: 21047
		public const short CyanandBlackDye = 1025;

		// Token: 0x04005238 RID: 21048
		public const short SkyBlueandBlackDye = 1026;

		// Token: 0x04005239 RID: 21049
		public const short BlueandBlackDye = 1027;

		// Token: 0x0400523A RID: 21050
		public const short PurpleandBlackDye = 1028;

		// Token: 0x0400523B RID: 21051
		public const short VioletandBlackDye = 1029;

		// Token: 0x0400523C RID: 21052
		public const short PinkandBlackDye = 1030;

		// Token: 0x0400523D RID: 21053
		public const short FlameDye = 1031;

		// Token: 0x0400523E RID: 21054
		public const short FlameAndBlackDye = 1032;

		// Token: 0x0400523F RID: 21055
		public const short GreenFlameDye = 1033;

		// Token: 0x04005240 RID: 21056
		public const short GreenFlameAndBlackDye = 1034;

		// Token: 0x04005241 RID: 21057
		public const short BlueFlameDye = 1035;

		// Token: 0x04005242 RID: 21058
		public const short BlueFlameAndBlackDye = 1036;

		// Token: 0x04005243 RID: 21059
		public const short SilverDye = 1037;

		// Token: 0x04005244 RID: 21060
		public const short BrightRedDye = 1038;

		// Token: 0x04005245 RID: 21061
		public const short BrightOrangeDye = 1039;

		// Token: 0x04005246 RID: 21062
		public const short BrightYellowDye = 1040;

		// Token: 0x04005247 RID: 21063
		public const short BrightLimeDye = 1041;

		// Token: 0x04005248 RID: 21064
		public const short BrightGreenDye = 1042;

		// Token: 0x04005249 RID: 21065
		public const short BrightTealDye = 1043;

		// Token: 0x0400524A RID: 21066
		public const short BrightCyanDye = 1044;

		// Token: 0x0400524B RID: 21067
		public const short BrightSkyBlueDye = 1045;

		// Token: 0x0400524C RID: 21068
		public const short BrightBlueDye = 1046;

		// Token: 0x0400524D RID: 21069
		public const short BrightPurpleDye = 1047;

		// Token: 0x0400524E RID: 21070
		public const short BrightVioletDye = 1048;

		// Token: 0x0400524F RID: 21071
		public const short BrightPinkDye = 1049;

		// Token: 0x04005250 RID: 21072
		public const short BlackDye = 1050;

		// Token: 0x04005251 RID: 21073
		public const short RedandSilverDye = 1051;

		// Token: 0x04005252 RID: 21074
		public const short OrangeandSilverDye = 1052;

		// Token: 0x04005253 RID: 21075
		public const short YellowandSilverDye = 1053;

		// Token: 0x04005254 RID: 21076
		public const short LimeandSilverDye = 1054;

		// Token: 0x04005255 RID: 21077
		public const short GreenandSilverDye = 1055;

		// Token: 0x04005256 RID: 21078
		public const short TealandSilverDye = 1056;

		// Token: 0x04005257 RID: 21079
		public const short CyanandSilverDye = 1057;

		// Token: 0x04005258 RID: 21080
		public const short SkyBlueandSilverDye = 1058;

		// Token: 0x04005259 RID: 21081
		public const short BlueandSilverDye = 1059;

		// Token: 0x0400525A RID: 21082
		public const short PurpleandSilverDye = 1060;

		// Token: 0x0400525B RID: 21083
		public const short VioletandSilverDye = 1061;

		// Token: 0x0400525C RID: 21084
		public const short PinkandSilverDye = 1062;

		// Token: 0x0400525D RID: 21085
		public const short IntenseFlameDye = 1063;

		// Token: 0x0400525E RID: 21086
		public const short IntenseGreenFlameDye = 1064;

		// Token: 0x0400525F RID: 21087
		public const short IntenseBlueFlameDye = 1065;

		// Token: 0x04005260 RID: 21088
		public const short RainbowDye = 1066;

		// Token: 0x04005261 RID: 21089
		public const short IntenseRainbowDye = 1067;

		// Token: 0x04005262 RID: 21090
		public const short YellowGradientDye = 1068;

		// Token: 0x04005263 RID: 21091
		public const short CyanGradientDye = 1069;

		// Token: 0x04005264 RID: 21092
		public const short VioletGradientDye = 1070;

		// Token: 0x04005265 RID: 21093
		public const short Paintbrush = 1071;

		// Token: 0x04005266 RID: 21094
		public const short PaintRoller = 1072;

		// Token: 0x04005267 RID: 21095
		public const short RedPaint = 1073;

		// Token: 0x04005268 RID: 21096
		public const short OrangePaint = 1074;

		// Token: 0x04005269 RID: 21097
		public const short YellowPaint = 1075;

		// Token: 0x0400526A RID: 21098
		public const short LimePaint = 1076;

		// Token: 0x0400526B RID: 21099
		public const short GreenPaint = 1077;

		// Token: 0x0400526C RID: 21100
		public const short TealPaint = 1078;

		// Token: 0x0400526D RID: 21101
		public const short CyanPaint = 1079;

		// Token: 0x0400526E RID: 21102
		public const short SkyBluePaint = 1080;

		// Token: 0x0400526F RID: 21103
		public const short BluePaint = 1081;

		// Token: 0x04005270 RID: 21104
		public const short PurplePaint = 1082;

		// Token: 0x04005271 RID: 21105
		public const short VioletPaint = 1083;

		// Token: 0x04005272 RID: 21106
		public const short PinkPaint = 1084;

		// Token: 0x04005273 RID: 21107
		public const short DeepRedPaint = 1085;

		// Token: 0x04005274 RID: 21108
		public const short DeepOrangePaint = 1086;

		// Token: 0x04005275 RID: 21109
		public const short DeepYellowPaint = 1087;

		// Token: 0x04005276 RID: 21110
		public const short DeepLimePaint = 1088;

		// Token: 0x04005277 RID: 21111
		public const short DeepGreenPaint = 1089;

		// Token: 0x04005278 RID: 21112
		public const short DeepTealPaint = 1090;

		// Token: 0x04005279 RID: 21113
		public const short DeepCyanPaint = 1091;

		// Token: 0x0400527A RID: 21114
		public const short DeepSkyBluePaint = 1092;

		// Token: 0x0400527B RID: 21115
		public const short DeepBluePaint = 1093;

		// Token: 0x0400527C RID: 21116
		public const short DeepPurplePaint = 1094;

		// Token: 0x0400527D RID: 21117
		public const short DeepVioletPaint = 1095;

		// Token: 0x0400527E RID: 21118
		public const short DeepPinkPaint = 1096;

		// Token: 0x0400527F RID: 21119
		public const short BlackPaint = 1097;

		// Token: 0x04005280 RID: 21120
		public const short WhitePaint = 1098;

		// Token: 0x04005281 RID: 21121
		public const short GrayPaint = 1099;

		// Token: 0x04005282 RID: 21122
		public const short PaintScraper = 1100;

		// Token: 0x04005283 RID: 21123
		public const short LihzahrdBrick = 1101;

		// Token: 0x04005284 RID: 21124
		public const short LihzahrdBrickWall = 1102;

		// Token: 0x04005285 RID: 21125
		public const short SlushBlock = 1103;

		// Token: 0x04005286 RID: 21126
		public const short PalladiumOre = 1104;

		// Token: 0x04005287 RID: 21127
		public const short OrichalcumOre = 1105;

		// Token: 0x04005288 RID: 21128
		public const short TitaniumOre = 1106;

		// Token: 0x04005289 RID: 21129
		public const short TealMushroom = 1107;

		// Token: 0x0400528A RID: 21130
		public const short GreenMushroom = 1108;

		// Token: 0x0400528B RID: 21131
		public const short SkyBlueFlower = 1109;

		// Token: 0x0400528C RID: 21132
		public const short YellowMarigold = 1110;

		// Token: 0x0400528D RID: 21133
		public const short BlueBerries = 1111;

		// Token: 0x0400528E RID: 21134
		public const short LimeKelp = 1112;

		// Token: 0x0400528F RID: 21135
		public const short PinkPricklyPear = 1113;

		// Token: 0x04005290 RID: 21136
		public const short OrangeBloodroot = 1114;

		// Token: 0x04005291 RID: 21137
		public const short RedHusk = 1115;

		// Token: 0x04005292 RID: 21138
		public const short CyanHusk = 1116;

		// Token: 0x04005293 RID: 21139
		public const short VioletHusk = 1117;

		// Token: 0x04005294 RID: 21140
		public const short PurpleMucos = 1118;

		// Token: 0x04005295 RID: 21141
		public const short BlackInk = 1119;

		// Token: 0x04005296 RID: 21142
		public const short DyeVat = 1120;

		// Token: 0x04005297 RID: 21143
		public const short BeeGun = 1121;

		// Token: 0x04005298 RID: 21144
		public const short PossessedHatchet = 1122;

		// Token: 0x04005299 RID: 21145
		public const short BeeKeeper = 1123;

		// Token: 0x0400529A RID: 21146
		public const short Hive = 1124;

		// Token: 0x0400529B RID: 21147
		public const short HoneyBlock = 1125;

		// Token: 0x0400529C RID: 21148
		public const short HiveWall = 1126;

		// Token: 0x0400529D RID: 21149
		public const short CrispyHoneyBlock = 1127;

		// Token: 0x0400529E RID: 21150
		public const short HoneyBucket = 1128;

		// Token: 0x0400529F RID: 21151
		public const short HiveWand = 1129;

		// Token: 0x040052A0 RID: 21152
		public const short Beenade = 1130;

		// Token: 0x040052A1 RID: 21153
		public const short GravityGlobe = 1131;

		// Token: 0x040052A2 RID: 21154
		public const short HoneyComb = 1132;

		// Token: 0x040052A3 RID: 21155
		public const short Abeemination = 1133;

		// Token: 0x040052A4 RID: 21156
		public const short BottledHoney = 1134;

		// Token: 0x040052A5 RID: 21157
		public const short RainHat = 1135;

		// Token: 0x040052A6 RID: 21158
		public const short RainCoat = 1136;

		// Token: 0x040052A7 RID: 21159
		public const short LihzahrdDoor = 1137;

		// Token: 0x040052A8 RID: 21160
		public const short DungeonDoor = 1138;

		// Token: 0x040052A9 RID: 21161
		public const short LeadDoor = 1139;

		// Token: 0x040052AA RID: 21162
		public const short IronDoor = 1140;

		// Token: 0x040052AB RID: 21163
		public const short TempleKey = 1141;

		// Token: 0x040052AC RID: 21164
		public const short LihzahrdChest = 1142;

		// Token: 0x040052AD RID: 21165
		public const short LihzahrdChair = 1143;

		// Token: 0x040052AE RID: 21166
		public const short LihzahrdTable = 1144;

		// Token: 0x040052AF RID: 21167
		public const short LihzahrdWorkBench = 1145;

		// Token: 0x040052B0 RID: 21168
		public const short SuperDartTrap = 1146;

		// Token: 0x040052B1 RID: 21169
		public const short FlameTrap = 1147;

		// Token: 0x040052B2 RID: 21170
		public const short SpikyBallTrap = 1148;

		// Token: 0x040052B3 RID: 21171
		public const short SpearTrap = 1149;

		// Token: 0x040052B4 RID: 21172
		public const short WoodenSpike = 1150;

		// Token: 0x040052B5 RID: 21173
		public const short LihzahrdPressurePlate = 1151;

		// Token: 0x040052B6 RID: 21174
		public const short LihzahrdStatue = 1152;

		// Token: 0x040052B7 RID: 21175
		public const short LihzahrdWatcherStatue = 1153;

		// Token: 0x040052B8 RID: 21176
		public const short LihzahrdGuardianStatue = 1154;

		// Token: 0x040052B9 RID: 21177
		public const short WaspGun = 1155;

		// Token: 0x040052BA RID: 21178
		public const short PiranhaGun = 1156;

		// Token: 0x040052BB RID: 21179
		public const short PygmyStaff = 1157;

		// Token: 0x040052BC RID: 21180
		public const short PygmyNecklace = 1158;

		// Token: 0x040052BD RID: 21181
		public const short TikiMask = 1159;

		// Token: 0x040052BE RID: 21182
		public const short TikiShirt = 1160;

		// Token: 0x040052BF RID: 21183
		public const short TikiPants = 1161;

		// Token: 0x040052C0 RID: 21184
		public const short LeafWings = 1162;

		// Token: 0x040052C1 RID: 21185
		public const short BlizzardinaBalloon = 1163;

		// Token: 0x040052C2 RID: 21186
		public const short BundleofBalloons = 1164;

		// Token: 0x040052C3 RID: 21187
		public const short BatWings = 1165;

		// Token: 0x040052C4 RID: 21188
		public const short BoneSword = 1166;

		// Token: 0x040052C5 RID: 21189
		public const short HerculesBeetle = 1167;

		// Token: 0x040052C6 RID: 21190
		public const short SmokeBomb = 1168;

		// Token: 0x040052C7 RID: 21191
		public const short BoneKey = 1169;

		// Token: 0x040052C8 RID: 21192
		public const short Nectar = 1170;

		// Token: 0x040052C9 RID: 21193
		public const short TikiTotem = 1171;

		// Token: 0x040052CA RID: 21194
		public const short LizardEgg = 1172;

		// Token: 0x040052CB RID: 21195
		public const short GraveMarker = 1173;

		// Token: 0x040052CC RID: 21196
		public const short CrossGraveMarker = 1174;

		// Token: 0x040052CD RID: 21197
		public const short Headstone = 1175;

		// Token: 0x040052CE RID: 21198
		public const short Gravestone = 1176;

		// Token: 0x040052CF RID: 21199
		public const short Obelisk = 1177;

		// Token: 0x040052D0 RID: 21200
		public const short LeafBlower = 1178;

		// Token: 0x040052D1 RID: 21201
		public const short ChlorophyteBullet = 1179;

		// Token: 0x040052D2 RID: 21202
		public const short ParrotCracker = 1180;

		// Token: 0x040052D3 RID: 21203
		public const short StrangeGlowingMushroom = 1181;

		// Token: 0x040052D4 RID: 21204
		public const short Seedling = 1182;

		// Token: 0x040052D5 RID: 21205
		public const short WispinaBottle = 1183;

		// Token: 0x040052D6 RID: 21206
		public const short PalladiumBar = 1184;

		// Token: 0x040052D7 RID: 21207
		public const short PalladiumSword = 1185;

		// Token: 0x040052D8 RID: 21208
		public const short PalladiumPike = 1186;

		// Token: 0x040052D9 RID: 21209
		public const short PalladiumRepeater = 1187;

		// Token: 0x040052DA RID: 21210
		public const short PalladiumPickaxe = 1188;

		// Token: 0x040052DB RID: 21211
		public const short PalladiumDrill = 1189;

		// Token: 0x040052DC RID: 21212
		public const short PalladiumChainsaw = 1190;

		// Token: 0x040052DD RID: 21213
		public const short OrichalcumBar = 1191;

		// Token: 0x040052DE RID: 21214
		public const short OrichalcumSword = 1192;

		// Token: 0x040052DF RID: 21215
		public const short OrichalcumHalberd = 1193;

		// Token: 0x040052E0 RID: 21216
		public const short OrichalcumRepeater = 1194;

		// Token: 0x040052E1 RID: 21217
		public const short OrichalcumPickaxe = 1195;

		// Token: 0x040052E2 RID: 21218
		public const short OrichalcumDrill = 1196;

		// Token: 0x040052E3 RID: 21219
		public const short OrichalcumChainsaw = 1197;

		// Token: 0x040052E4 RID: 21220
		public const short TitaniumBar = 1198;

		// Token: 0x040052E5 RID: 21221
		public const short TitaniumSword = 1199;

		// Token: 0x040052E6 RID: 21222
		public const short TitaniumTrident = 1200;

		// Token: 0x040052E7 RID: 21223
		public const short TitaniumRepeater = 1201;

		// Token: 0x040052E8 RID: 21224
		public const short TitaniumPickaxe = 1202;

		// Token: 0x040052E9 RID: 21225
		public const short TitaniumDrill = 1203;

		// Token: 0x040052EA RID: 21226
		public const short TitaniumChainsaw = 1204;

		// Token: 0x040052EB RID: 21227
		public const short PalladiumMask = 1205;

		// Token: 0x040052EC RID: 21228
		public const short PalladiumHelmet = 1206;

		// Token: 0x040052ED RID: 21229
		public const short PalladiumHeadgear = 1207;

		// Token: 0x040052EE RID: 21230
		public const short PalladiumBreastplate = 1208;

		// Token: 0x040052EF RID: 21231
		public const short PalladiumLeggings = 1209;

		// Token: 0x040052F0 RID: 21232
		public const short OrichalcumMask = 1210;

		// Token: 0x040052F1 RID: 21233
		public const short OrichalcumHelmet = 1211;

		// Token: 0x040052F2 RID: 21234
		public const short OrichalcumHeadgear = 1212;

		// Token: 0x040052F3 RID: 21235
		public const short OrichalcumBreastplate = 1213;

		// Token: 0x040052F4 RID: 21236
		public const short OrichalcumLeggings = 1214;

		// Token: 0x040052F5 RID: 21237
		public const short TitaniumMask = 1215;

		// Token: 0x040052F6 RID: 21238
		public const short TitaniumHelmet = 1216;

		// Token: 0x040052F7 RID: 21239
		public const short TitaniumHeadgear = 1217;

		// Token: 0x040052F8 RID: 21240
		public const short TitaniumBreastplate = 1218;

		// Token: 0x040052F9 RID: 21241
		public const short TitaniumLeggings = 1219;

		// Token: 0x040052FA RID: 21242
		public const short OrichalcumAnvil = 1220;

		// Token: 0x040052FB RID: 21243
		public const short TitaniumForge = 1221;

		// Token: 0x040052FC RID: 21244
		public const short PalladiumWaraxe = 1222;

		// Token: 0x040052FD RID: 21245
		public const short OrichalcumWaraxe = 1223;

		// Token: 0x040052FE RID: 21246
		public const short TitaniumWaraxe = 1224;

		// Token: 0x040052FF RID: 21247
		public const short HallowedBar = 1225;

		// Token: 0x04005300 RID: 21248
		public const short ChlorophyteClaymore = 1226;

		// Token: 0x04005301 RID: 21249
		public const short ChlorophyteSaber = 1227;

		// Token: 0x04005302 RID: 21250
		public const short ChlorophytePartisan = 1228;

		// Token: 0x04005303 RID: 21251
		public const short ChlorophyteShotbow = 1229;

		// Token: 0x04005304 RID: 21252
		public const short ChlorophytePickaxe = 1230;

		// Token: 0x04005305 RID: 21253
		public const short ChlorophyteDrill = 1231;

		// Token: 0x04005306 RID: 21254
		public const short ChlorophyteChainsaw = 1232;

		// Token: 0x04005307 RID: 21255
		public const short ChlorophyteGreataxe = 1233;

		// Token: 0x04005308 RID: 21256
		public const short ChlorophyteWarhammer = 1234;

		// Token: 0x04005309 RID: 21257
		public const short ChlorophyteArrow = 1235;

		// Token: 0x0400530A RID: 21258
		public const short AmethystHook = 1236;

		// Token: 0x0400530B RID: 21259
		public const short TopazHook = 1237;

		// Token: 0x0400530C RID: 21260
		public const short SapphireHook = 1238;

		// Token: 0x0400530D RID: 21261
		public const short EmeraldHook = 1239;

		// Token: 0x0400530E RID: 21262
		public const short RubyHook = 1240;

		// Token: 0x0400530F RID: 21263
		public const short DiamondHook = 1241;

		// Token: 0x04005310 RID: 21264
		public const short AmberMosquito = 1242;

		// Token: 0x04005311 RID: 21265
		public const short UmbrellaHat = 1243;

		// Token: 0x04005312 RID: 21266
		public const short NimbusRod = 1244;

		// Token: 0x04005313 RID: 21267
		public const short OrangeTorch = 1245;

		// Token: 0x04005314 RID: 21268
		public const short CrimsandBlock = 1246;

		// Token: 0x04005315 RID: 21269
		public const short BeeCloak = 1247;

		// Token: 0x04005316 RID: 21270
		public const short EyeoftheGolem = 1248;

		// Token: 0x04005317 RID: 21271
		public const short HoneyBalloon = 1249;

		// Token: 0x04005318 RID: 21272
		public const short BlueHorseshoeBalloon = 1250;

		// Token: 0x04005319 RID: 21273
		public const short WhiteHorseshoeBalloon = 1251;

		// Token: 0x0400531A RID: 21274
		public const short YellowHorseshoeBalloon = 1252;

		// Token: 0x0400531B RID: 21275
		public const short FrozenTurtleShell = 1253;

		// Token: 0x0400531C RID: 21276
		public const short SniperRifle = 1254;

		// Token: 0x0400531D RID: 21277
		public const short VenusMagnum = 1255;

		// Token: 0x0400531E RID: 21278
		public const short CrimsonRod = 1256;

		// Token: 0x0400531F RID: 21279
		public const short CrimtaneBar = 1257;

		// Token: 0x04005320 RID: 21280
		public const short Stynger = 1258;

		// Token: 0x04005321 RID: 21281
		public const short FlowerPow = 1259;

		// Token: 0x04005322 RID: 21282
		public const short RainbowGun = 1260;

		// Token: 0x04005323 RID: 21283
		public const short StyngerBolt = 1261;

		// Token: 0x04005324 RID: 21284
		public const short ChlorophyteJackhammer = 1262;

		// Token: 0x04005325 RID: 21285
		public const short Teleporter = 1263;

		// Token: 0x04005326 RID: 21286
		public const short FlowerofFrost = 1264;

		// Token: 0x04005327 RID: 21287
		public const short Uzi = 1265;

		// Token: 0x04005328 RID: 21288
		public const short MagnetSphere = 1266;

		// Token: 0x04005329 RID: 21289
		public const short PurpleStainedGlass = 1267;

		// Token: 0x0400532A RID: 21290
		public const short YellowStainedGlass = 1268;

		// Token: 0x0400532B RID: 21291
		public const short BlueStainedGlass = 1269;

		// Token: 0x0400532C RID: 21292
		public const short GreenStainedGlass = 1270;

		// Token: 0x0400532D RID: 21293
		public const short RedStainedGlass = 1271;

		// Token: 0x0400532E RID: 21294
		public const short MulticoloredStainedGlass = 1272;

		// Token: 0x0400532F RID: 21295
		public const short SkeletronHand = 1273;

		// Token: 0x04005330 RID: 21296
		public const short Skull = 1274;

		// Token: 0x04005331 RID: 21297
		public const short BallaHat = 1275;

		// Token: 0x04005332 RID: 21298
		public const short GangstaHat = 1276;

		// Token: 0x04005333 RID: 21299
		public const short SailorHat = 1277;

		// Token: 0x04005334 RID: 21300
		public const short EyePatch = 1278;

		// Token: 0x04005335 RID: 21301
		public const short SailorShirt = 1279;

		// Token: 0x04005336 RID: 21302
		public const short SailorPants = 1280;

		// Token: 0x04005337 RID: 21303
		public const short SkeletronMask = 1281;

		// Token: 0x04005338 RID: 21304
		public const short AmethystRobe = 1282;

		// Token: 0x04005339 RID: 21305
		public const short TopazRobe = 1283;

		// Token: 0x0400533A RID: 21306
		public const short SapphireRobe = 1284;

		// Token: 0x0400533B RID: 21307
		public const short EmeraldRobe = 1285;

		// Token: 0x0400533C RID: 21308
		public const short RubyRobe = 1286;

		// Token: 0x0400533D RID: 21309
		public const short DiamondRobe = 1287;

		// Token: 0x0400533E RID: 21310
		public const short WhiteTuxedoShirt = 1288;

		// Token: 0x0400533F RID: 21311
		public const short WhiteTuxedoPants = 1289;

		// Token: 0x04005340 RID: 21312
		public const short PanicNecklace = 1290;

		// Token: 0x04005341 RID: 21313
		public const short LifeFruit = 1291;

		// Token: 0x04005342 RID: 21314
		public const short LihzahrdAltar = 1292;

		// Token: 0x04005343 RID: 21315
		public const short LihzahrdPowerCell = 1293;

		// Token: 0x04005344 RID: 21316
		public const short Picksaw = 1294;

		// Token: 0x04005345 RID: 21317
		public const short HeatRay = 1295;

		// Token: 0x04005346 RID: 21318
		public const short StaffofEarth = 1296;

		// Token: 0x04005347 RID: 21319
		public const short GolemFist = 1297;

		// Token: 0x04005348 RID: 21320
		public const short WaterChest = 1298;

		// Token: 0x04005349 RID: 21321
		public const short Binoculars = 1299;

		// Token: 0x0400534A RID: 21322
		public const short RifleScope = 1300;

		// Token: 0x0400534B RID: 21323
		public const short DestroyerEmblem = 1301;

		// Token: 0x0400534C RID: 21324
		public const short HighVelocityBullet = 1302;

		// Token: 0x0400534D RID: 21325
		public const short JellyfishNecklace = 1303;

		// Token: 0x0400534E RID: 21326
		public const short ZombieArm = 1304;

		// Token: 0x0400534F RID: 21327
		public const short TheAxe = 1305;

		// Token: 0x04005350 RID: 21328
		public const short IceSickle = 1306;

		// Token: 0x04005351 RID: 21329
		public const short ClothierVoodooDoll = 1307;

		// Token: 0x04005352 RID: 21330
		public const short PoisonStaff = 1308;

		// Token: 0x04005353 RID: 21331
		public const short SlimeStaff = 1309;

		// Token: 0x04005354 RID: 21332
		public const short PoisonDart = 1310;

		// Token: 0x04005355 RID: 21333
		public const short EyeSpring = 1311;

		// Token: 0x04005356 RID: 21334
		public const short ToySled = 1312;

		// Token: 0x04005357 RID: 21335
		public const short BookofSkulls = 1313;

		// Token: 0x04005358 RID: 21336
		public const short KOCannon = 1314;

		// Token: 0x04005359 RID: 21337
		public const short PirateMap = 1315;

		// Token: 0x0400535A RID: 21338
		public const short TurtleHelmet = 1316;

		// Token: 0x0400535B RID: 21339
		public const short TurtleScaleMail = 1317;

		// Token: 0x0400535C RID: 21340
		public const short TurtleLeggings = 1318;

		// Token: 0x0400535D RID: 21341
		public const short SnowballCannon = 1319;

		// Token: 0x0400535E RID: 21342
		public const short BonePickaxe = 1320;

		// Token: 0x0400535F RID: 21343
		public const short MagicQuiver = 1321;

		// Token: 0x04005360 RID: 21344
		public const short MagmaStone = 1322;

		// Token: 0x04005361 RID: 21345
		public const short ObsidianRose = 1323;

		// Token: 0x04005362 RID: 21346
		public const short Bananarang = 1324;

		// Token: 0x04005363 RID: 21347
		public const short ChainKnife = 1325;

		// Token: 0x04005364 RID: 21348
		public const short RodofDiscord = 1326;

		// Token: 0x04005365 RID: 21349
		public const short DeathSickle = 1327;

		// Token: 0x04005366 RID: 21350
		public const short TurtleShell = 1328;

		// Token: 0x04005367 RID: 21351
		public const short TissueSample = 1329;

		// Token: 0x04005368 RID: 21352
		public const short Vertebrae = 1330;

		// Token: 0x04005369 RID: 21353
		public const short BloodySpine = 1331;

		// Token: 0x0400536A RID: 21354
		public const short Ichor = 1332;

		// Token: 0x0400536B RID: 21355
		public const short IchorTorch = 1333;

		// Token: 0x0400536C RID: 21356
		public const short IchorArrow = 1334;

		// Token: 0x0400536D RID: 21357
		public const short IchorBullet = 1335;

		// Token: 0x0400536E RID: 21358
		public const short GoldenShower = 1336;

		// Token: 0x0400536F RID: 21359
		public const short BunnyCannon = 1337;

		// Token: 0x04005370 RID: 21360
		public const short ExplosiveBunny = 1338;

		// Token: 0x04005371 RID: 21361
		public const short VialofVenom = 1339;

		// Token: 0x04005372 RID: 21362
		public const short FlaskofVenom = 1340;

		// Token: 0x04005373 RID: 21363
		public const short VenomArrow = 1341;

		// Token: 0x04005374 RID: 21364
		public const short VenomBullet = 1342;

		// Token: 0x04005375 RID: 21365
		public const short FireGauntlet = 1343;

		// Token: 0x04005376 RID: 21366
		public const short Cog = 1344;

		// Token: 0x04005377 RID: 21367
		public const short Confetti = 1345;

		// Token: 0x04005378 RID: 21368
		public const short Nanites = 1346;

		// Token: 0x04005379 RID: 21369
		public const short ExplosivePowder = 1347;

		// Token: 0x0400537A RID: 21370
		public const short GoldDust = 1348;

		// Token: 0x0400537B RID: 21371
		public const short PartyBullet = 1349;

		// Token: 0x0400537C RID: 21372
		public const short NanoBullet = 1350;

		// Token: 0x0400537D RID: 21373
		public const short ExplodingBullet = 1351;

		// Token: 0x0400537E RID: 21374
		public const short GoldenBullet = 1352;

		// Token: 0x0400537F RID: 21375
		public const short FlaskofCursedFlames = 1353;

		// Token: 0x04005380 RID: 21376
		public const short FlaskofFire = 1354;

		// Token: 0x04005381 RID: 21377
		public const short FlaskofGold = 1355;

		// Token: 0x04005382 RID: 21378
		public const short FlaskofIchor = 1356;

		// Token: 0x04005383 RID: 21379
		public const short FlaskofNanites = 1357;

		// Token: 0x04005384 RID: 21380
		public const short FlaskofParty = 1358;

		// Token: 0x04005385 RID: 21381
		public const short FlaskofPoison = 1359;

		// Token: 0x04005386 RID: 21382
		public const short EyeofCthulhuTrophy = 1360;

		// Token: 0x04005387 RID: 21383
		public const short EaterofWorldsTrophy = 1361;

		// Token: 0x04005388 RID: 21384
		public const short BrainofCthulhuTrophy = 1362;

		// Token: 0x04005389 RID: 21385
		public const short SkeletronTrophy = 1363;

		// Token: 0x0400538A RID: 21386
		public const short QueenBeeTrophy = 1364;

		// Token: 0x0400538B RID: 21387
		public const short WallofFleshTrophy = 1365;

		// Token: 0x0400538C RID: 21388
		public const short DestroyerTrophy = 1366;

		// Token: 0x0400538D RID: 21389
		public const short SkeletronPrimeTrophy = 1367;

		// Token: 0x0400538E RID: 21390
		public const short RetinazerTrophy = 1368;

		// Token: 0x0400538F RID: 21391
		public const short SpazmatismTrophy = 1369;

		// Token: 0x04005390 RID: 21392
		public const short PlanteraTrophy = 1370;

		// Token: 0x04005391 RID: 21393
		public const short GolemTrophy = 1371;

		// Token: 0x04005392 RID: 21394
		public const short BloodMoonRising = 1372;

		// Token: 0x04005393 RID: 21395
		public const short TheHangedMan = 1373;

		// Token: 0x04005394 RID: 21396
		public const short GloryoftheFire = 1374;

		// Token: 0x04005395 RID: 21397
		public const short BoneWarp = 1375;

		// Token: 0x04005396 RID: 21398
		public const short WallSkeleton = 1376;

		// Token: 0x04005397 RID: 21399
		public const short HangingSkeleton = 1377;

		// Token: 0x04005398 RID: 21400
		public const short BlueSlabWall = 1378;

		// Token: 0x04005399 RID: 21401
		public const short BlueTiledWall = 1379;

		// Token: 0x0400539A RID: 21402
		public const short PinkSlabWall = 1380;

		// Token: 0x0400539B RID: 21403
		public const short PinkTiledWall = 1381;

		// Token: 0x0400539C RID: 21404
		public const short GreenSlabWall = 1382;

		// Token: 0x0400539D RID: 21405
		public const short GreenTiledWall = 1383;

		// Token: 0x0400539E RID: 21406
		public const short BlueBrickPlatform = 1384;

		// Token: 0x0400539F RID: 21407
		public const short PinkBrickPlatform = 1385;

		// Token: 0x040053A0 RID: 21408
		public const short GreenBrickPlatform = 1386;

		// Token: 0x040053A1 RID: 21409
		public const short MetalShelf = 1387;

		// Token: 0x040053A2 RID: 21410
		public const short BrassShelf = 1388;

		// Token: 0x040053A3 RID: 21411
		public const short WoodShelf = 1389;

		// Token: 0x040053A4 RID: 21412
		public const short BrassLantern = 1390;

		// Token: 0x040053A5 RID: 21413
		public const short CagedLantern = 1391;

		// Token: 0x040053A6 RID: 21414
		public const short CarriageLantern = 1392;

		// Token: 0x040053A7 RID: 21415
		public const short AlchemyLantern = 1393;

		// Token: 0x040053A8 RID: 21416
		public const short DiablostLamp = 1394;

		// Token: 0x040053A9 RID: 21417
		public const short OilRagSconse = 1395;

		// Token: 0x040053AA RID: 21418
		public const short BlueDungeonChair = 1396;

		// Token: 0x040053AB RID: 21419
		public const short BlueDungeonTable = 1397;

		// Token: 0x040053AC RID: 21420
		public const short BlueDungeonWorkBench = 1398;

		// Token: 0x040053AD RID: 21421
		public const short GreenDungeonChair = 1399;

		// Token: 0x040053AE RID: 21422
		public const short GreenDungeonTable = 1400;

		// Token: 0x040053AF RID: 21423
		public const short GreenDungeonWorkBench = 1401;

		// Token: 0x040053B0 RID: 21424
		public const short PinkDungeonChair = 1402;

		// Token: 0x040053B1 RID: 21425
		public const short PinkDungeonTable = 1403;

		// Token: 0x040053B2 RID: 21426
		public const short PinkDungeonWorkBench = 1404;

		// Token: 0x040053B3 RID: 21427
		public const short BlueDungeonCandle = 1405;

		// Token: 0x040053B4 RID: 21428
		public const short GreenDungeonCandle = 1406;

		// Token: 0x040053B5 RID: 21429
		public const short PinkDungeonCandle = 1407;

		// Token: 0x040053B6 RID: 21430
		public const short BlueDungeonVase = 1408;

		// Token: 0x040053B7 RID: 21431
		public const short GreenDungeonVase = 1409;

		// Token: 0x040053B8 RID: 21432
		public const short PinkDungeonVase = 1410;

		// Token: 0x040053B9 RID: 21433
		public const short BlueDungeonDoor = 1411;

		// Token: 0x040053BA RID: 21434
		public const short GreenDungeonDoor = 1412;

		// Token: 0x040053BB RID: 21435
		public const short PinkDungeonDoor = 1413;

		// Token: 0x040053BC RID: 21436
		public const short BlueDungeonBookcase = 1414;

		// Token: 0x040053BD RID: 21437
		public const short GreenDungeonBookcase = 1415;

		// Token: 0x040053BE RID: 21438
		public const short PinkDungeonBookcase = 1416;

		// Token: 0x040053BF RID: 21439
		public const short Catacomb = 1417;

		// Token: 0x040053C0 RID: 21440
		public const short DungeonShelf = 1418;

		// Token: 0x040053C1 RID: 21441
		public const short SkellingtonJSkellingsworth = 1419;

		// Token: 0x040053C2 RID: 21442
		public const short TheCursedMan = 1420;

		// Token: 0x040053C3 RID: 21443
		public const short TheEyeSeestheEnd = 1421;

		// Token: 0x040053C4 RID: 21444
		public const short SomethingEvilisWatchingYou = 1422;

		// Token: 0x040053C5 RID: 21445
		public const short TheTwinsHaveAwoken = 1423;

		// Token: 0x040053C6 RID: 21446
		public const short TheScreamer = 1424;

		// Token: 0x040053C7 RID: 21447
		public const short GoblinsPlayingPoker = 1425;

		// Token: 0x040053C8 RID: 21448
		public const short Dryadisque = 1426;

		// Token: 0x040053C9 RID: 21449
		public const short Sunflowers = 1427;

		// Token: 0x040053CA RID: 21450
		public const short TerrarianGothic = 1428;

		// Token: 0x040053CB RID: 21451
		public const short Beanie = 1429;

		// Token: 0x040053CC RID: 21452
		public const short ImbuingStation = 1430;

		// Token: 0x040053CD RID: 21453
		public const short StarinaBottle = 1431;

		// Token: 0x040053CE RID: 21454
		public const short EmptyBullet = 1432;

		// Token: 0x040053CF RID: 21455
		public const short Impact = 1433;

		// Token: 0x040053D0 RID: 21456
		public const short PoweredbyBirds = 1434;

		// Token: 0x040053D1 RID: 21457
		public const short TheDestroyer = 1435;

		// Token: 0x040053D2 RID: 21458
		public const short ThePersistencyofEyes = 1436;

		// Token: 0x040053D3 RID: 21459
		public const short UnicornCrossingtheHallows = 1437;

		// Token: 0x040053D4 RID: 21460
		public const short GreatWave = 1438;

		// Token: 0x040053D5 RID: 21461
		public const short StarryNight = 1439;

		// Token: 0x040053D6 RID: 21462
		public const short GuidePicasso = 1440;

		// Token: 0x040053D7 RID: 21463
		public const short TheGuardiansGaze = 1441;

		// Token: 0x040053D8 RID: 21464
		public const short FatherofSomeone = 1442;

		// Token: 0x040053D9 RID: 21465
		public const short NurseLisa = 1443;

		// Token: 0x040053DA RID: 21466
		public const short ShadowbeamStaff = 1444;

		// Token: 0x040053DB RID: 21467
		public const short InfernoFork = 1445;

		// Token: 0x040053DC RID: 21468
		public const short SpectreStaff = 1446;

		// Token: 0x040053DD RID: 21469
		public const short WoodenFence = 1447;

		// Token: 0x040053DE RID: 21470
		public const short LeadFence = 1448;

		// Token: 0x040053DF RID: 21471
		public const short BubbleMachine = 1449;

		// Token: 0x040053E0 RID: 21472
		public const short BubbleWand = 1450;

		// Token: 0x040053E1 RID: 21473
		public const short MarchingBonesBanner = 1451;

		// Token: 0x040053E2 RID: 21474
		public const short NecromanticSign = 1452;

		// Token: 0x040053E3 RID: 21475
		public const short RustedCompanyStandard = 1453;

		// Token: 0x040053E4 RID: 21476
		public const short RaggedBrotherhoodSigil = 1454;

		// Token: 0x040053E5 RID: 21477
		public const short MoltenLegionFlag = 1455;

		// Token: 0x040053E6 RID: 21478
		public const short DiabolicSigil = 1456;

		// Token: 0x040053E7 RID: 21479
		public const short ObsidianPlatform = 1457;

		// Token: 0x040053E8 RID: 21480
		public const short ObsidianDoor = 1458;

		// Token: 0x040053E9 RID: 21481
		public const short ObsidianChair = 1459;

		// Token: 0x040053EA RID: 21482
		public const short ObsidianTable = 1460;

		// Token: 0x040053EB RID: 21483
		public const short ObsidianWorkBench = 1461;

		// Token: 0x040053EC RID: 21484
		public const short ObsidianVase = 1462;

		// Token: 0x040053ED RID: 21485
		public const short ObsidianBookcase = 1463;

		// Token: 0x040053EE RID: 21486
		public const short HellboundBanner = 1464;

		// Token: 0x040053EF RID: 21487
		public const short HellHammerBanner = 1465;

		// Token: 0x040053F0 RID: 21488
		public const short HelltowerBanner = 1466;

		// Token: 0x040053F1 RID: 21489
		public const short LostHopesofManBanner = 1467;

		// Token: 0x040053F2 RID: 21490
		public const short ObsidianWatcherBanner = 1468;

		// Token: 0x040053F3 RID: 21491
		public const short LavaEruptsBanner = 1469;

		// Token: 0x040053F4 RID: 21492
		public const short BlueDungeonBed = 1470;

		// Token: 0x040053F5 RID: 21493
		public const short GreenDungeonBed = 1471;

		// Token: 0x040053F6 RID: 21494
		public const short PinkDungeonBed = 1472;

		// Token: 0x040053F7 RID: 21495
		public const short ObsidianBed = 1473;

		// Token: 0x040053F8 RID: 21496
		public const short Waldo = 1474;

		// Token: 0x040053F9 RID: 21497
		public const short Darkness = 1475;

		// Token: 0x040053FA RID: 21498
		public const short DarkSoulReaper = 1476;

		// Token: 0x040053FB RID: 21499
		public const short Land = 1477;

		// Token: 0x040053FC RID: 21500
		public const short TrappedGhost = 1478;

		// Token: 0x040053FD RID: 21501
		public const short DemonsEye = 1479;

		// Token: 0x040053FE RID: 21502
		public const short FindingGold = 1480;

		// Token: 0x040053FF RID: 21503
		public const short FirstEncounter = 1481;

		// Token: 0x04005400 RID: 21504
		public const short GoodMorning = 1482;

		// Token: 0x04005401 RID: 21505
		public const short UndergroundReward = 1483;

		// Token: 0x04005402 RID: 21506
		public const short ThroughtheWindow = 1484;

		// Token: 0x04005403 RID: 21507
		public const short PlaceAbovetheClouds = 1485;

		// Token: 0x04005404 RID: 21508
		public const short DoNotStepontheGrass = 1486;

		// Token: 0x04005405 RID: 21509
		public const short ColdWatersintheWhiteLand = 1487;

		// Token: 0x04005406 RID: 21510
		public const short LightlessChasms = 1488;

		// Token: 0x04005407 RID: 21511
		public const short TheLandofDeceivingLooks = 1489;

		// Token: 0x04005408 RID: 21512
		public const short Daylight = 1490;

		// Token: 0x04005409 RID: 21513
		public const short SecretoftheSands = 1491;

		// Token: 0x0400540A RID: 21514
		public const short DeadlandComesAlive = 1492;

		// Token: 0x0400540B RID: 21515
		public const short EvilPresence = 1493;

		// Token: 0x0400540C RID: 21516
		public const short SkyGuardian = 1494;

		// Token: 0x0400540D RID: 21517
		public const short AmericanExplosive = 1495;

		// Token: 0x0400540E RID: 21518
		public const short Discover = 1496;

		// Token: 0x0400540F RID: 21519
		public const short HandEarth = 1497;

		// Token: 0x04005410 RID: 21520
		public const short OldMiner = 1498;

		// Token: 0x04005411 RID: 21521
		public const short Skelehead = 1499;

		// Token: 0x04005412 RID: 21522
		public const short FacingtheCerebralMastermind = 1500;

		// Token: 0x04005413 RID: 21523
		public const short LakeofFire = 1501;

		// Token: 0x04005414 RID: 21524
		public const short TrioSuperHeroes = 1502;

		// Token: 0x04005415 RID: 21525
		public const short SpectreHood = 1503;

		// Token: 0x04005416 RID: 21526
		public const short SpectreRobe = 1504;

		// Token: 0x04005417 RID: 21527
		public const short SpectrePants = 1505;

		// Token: 0x04005418 RID: 21528
		public const short SpectrePickaxe = 1506;

		// Token: 0x04005419 RID: 21529
		public const short SpectreHamaxe = 1507;

		// Token: 0x0400541A RID: 21530
		public const short Ectoplasm = 1508;

		// Token: 0x0400541B RID: 21531
		public const short GothicChair = 1509;

		// Token: 0x0400541C RID: 21532
		public const short GothicTable = 1510;

		// Token: 0x0400541D RID: 21533
		public const short GothicWorkBench = 1511;

		// Token: 0x0400541E RID: 21534
		public const short GothicBookcase = 1512;

		// Token: 0x0400541F RID: 21535
		public const short PaladinsHammer = 1513;

		// Token: 0x04005420 RID: 21536
		public const short SWATHelmet = 1514;

		// Token: 0x04005421 RID: 21537
		public const short BeeWings = 1515;

		// Token: 0x04005422 RID: 21538
		public const short GiantHarpyFeather = 1516;

		// Token: 0x04005423 RID: 21539
		public const short BoneFeather = 1517;

		// Token: 0x04005424 RID: 21540
		public const short FireFeather = 1518;

		// Token: 0x04005425 RID: 21541
		public const short IceFeather = 1519;

		// Token: 0x04005426 RID: 21542
		public const short BrokenBatWing = 1520;

		// Token: 0x04005427 RID: 21543
		public const short TatteredBeeWing = 1521;

		// Token: 0x04005428 RID: 21544
		public const short LargeAmethyst = 1522;

		// Token: 0x04005429 RID: 21545
		public const short LargeTopaz = 1523;

		// Token: 0x0400542A RID: 21546
		public const short LargeSapphire = 1524;

		// Token: 0x0400542B RID: 21547
		public const short LargeEmerald = 1525;

		// Token: 0x0400542C RID: 21548
		public const short LargeRuby = 1526;

		// Token: 0x0400542D RID: 21549
		public const short LargeDiamond = 1527;

		// Token: 0x0400542E RID: 21550
		public const short JungleChest = 1528;

		// Token: 0x0400542F RID: 21551
		public const short CorruptionChest = 1529;

		// Token: 0x04005430 RID: 21552
		public const short CrimsonChest = 1530;

		// Token: 0x04005431 RID: 21553
		public const short HallowedChest = 1531;

		// Token: 0x04005432 RID: 21554
		public const short FrozenChest = 1532;

		// Token: 0x04005433 RID: 21555
		public const short JungleKey = 1533;

		// Token: 0x04005434 RID: 21556
		public const short CorruptionKey = 1534;

		// Token: 0x04005435 RID: 21557
		public const short CrimsonKey = 1535;

		// Token: 0x04005436 RID: 21558
		public const short HallowedKey = 1536;

		// Token: 0x04005437 RID: 21559
		public const short FrozenKey = 1537;

		// Token: 0x04005438 RID: 21560
		public const short ImpFace = 1538;

		// Token: 0x04005439 RID: 21561
		public const short OminousPresence = 1539;

		// Token: 0x0400543A RID: 21562
		public const short ShiningMoon = 1540;

		// Token: 0x0400543B RID: 21563
		public const short LivingGore = 1541;

		// Token: 0x0400543C RID: 21564
		public const short FlowingMagma = 1542;

		// Token: 0x0400543D RID: 21565
		public const short SpectrePaintbrush = 1543;

		// Token: 0x0400543E RID: 21566
		public const short SpectrePaintRoller = 1544;

		// Token: 0x0400543F RID: 21567
		public const short SpectrePaintScraper = 1545;

		// Token: 0x04005440 RID: 21568
		public const short ShroomiteHeadgear = 1546;

		// Token: 0x04005441 RID: 21569
		public const short ShroomiteMask = 1547;

		// Token: 0x04005442 RID: 21570
		public const short ShroomiteHelmet = 1548;

		// Token: 0x04005443 RID: 21571
		public const short ShroomiteBreastplate = 1549;

		// Token: 0x04005444 RID: 21572
		public const short ShroomiteLeggings = 1550;

		// Token: 0x04005445 RID: 21573
		public const short Autohammer = 1551;

		// Token: 0x04005446 RID: 21574
		public const short ShroomiteBar = 1552;

		// Token: 0x04005447 RID: 21575
		public const short SDMG = 1553;

		// Token: 0x04005448 RID: 21576
		public const short CenxsTiara = 1554;

		// Token: 0x04005449 RID: 21577
		public const short CenxsBreastplate = 1555;

		// Token: 0x0400544A RID: 21578
		public const short CenxsLeggings = 1556;

		// Token: 0x0400544B RID: 21579
		public const short CrownosMask = 1557;

		// Token: 0x0400544C RID: 21580
		public const short CrownosBreastplate = 1558;

		// Token: 0x0400544D RID: 21581
		public const short CrownosLeggings = 1559;

		// Token: 0x0400544E RID: 21582
		public const short WillsHelmet = 1560;

		// Token: 0x0400544F RID: 21583
		public const short WillsBreastplate = 1561;

		// Token: 0x04005450 RID: 21584
		public const short WillsLeggings = 1562;

		// Token: 0x04005451 RID: 21585
		public const short JimsHelmet = 1563;

		// Token: 0x04005452 RID: 21586
		public const short JimsBreastplate = 1564;

		// Token: 0x04005453 RID: 21587
		public const short JimsLeggings = 1565;

		// Token: 0x04005454 RID: 21588
		public const short AaronsHelmet = 1566;

		// Token: 0x04005455 RID: 21589
		public const short AaronsBreastplate = 1567;

		// Token: 0x04005456 RID: 21590
		public const short AaronsLeggings = 1568;

		// Token: 0x04005457 RID: 21591
		public const short VampireKnives = 1569;

		// Token: 0x04005458 RID: 21592
		public const short BrokenHeroSword = 1570;

		// Token: 0x04005459 RID: 21593
		public const short ScourgeoftheCorruptor = 1571;

		// Token: 0x0400545A RID: 21594
		public const short StaffoftheFrostHydra = 1572;

		// Token: 0x0400545B RID: 21595
		public const short TheCreationoftheGuide = 1573;

		// Token: 0x0400545C RID: 21596
		public const short TheMerchant = 1574;

		// Token: 0x0400545D RID: 21597
		public const short CrownoDevoursHisLunch = 1575;

		// Token: 0x0400545E RID: 21598
		public const short RareEnchantment = 1576;

		// Token: 0x0400545F RID: 21599
		public const short GloriousNight = 1577;

		// Token: 0x04005460 RID: 21600
		public const short SweetheartNecklace = 1578;

		// Token: 0x04005461 RID: 21601
		public const short FlurryBoots = 1579;

		// Token: 0x04005462 RID: 21602
		public const short DTownsHelmet = 1580;

		// Token: 0x04005463 RID: 21603
		public const short DTownsBreastplate = 1581;

		// Token: 0x04005464 RID: 21604
		public const short DTownsLeggings = 1582;

		// Token: 0x04005465 RID: 21605
		public const short DTownsWings = 1583;

		// Token: 0x04005466 RID: 21606
		public const short WillsWings = 1584;

		// Token: 0x04005467 RID: 21607
		public const short CrownosWings = 1585;

		// Token: 0x04005468 RID: 21608
		public const short CenxsWings = 1586;

		// Token: 0x04005469 RID: 21609
		public const short CenxsDress = 1587;

		// Token: 0x0400546A RID: 21610
		public const short CenxsDressPants = 1588;

		// Token: 0x0400546B RID: 21611
		public const short PalladiumColumn = 1589;

		// Token: 0x0400546C RID: 21612
		public const short PalladiumColumnWall = 1590;

		// Token: 0x0400546D RID: 21613
		public const short BubblegumBlock = 1591;

		// Token: 0x0400546E RID: 21614
		public const short BubblegumBlockWall = 1592;

		// Token: 0x0400546F RID: 21615
		public const short TitanstoneBlock = 1593;

		// Token: 0x04005470 RID: 21616
		public const short TitanstoneBlockWall = 1594;

		// Token: 0x04005471 RID: 21617
		public const short MagicCuffs = 1595;

		// Token: 0x04005472 RID: 21618
		public const short MusicBoxSnow = 1596;

		// Token: 0x04005473 RID: 21619
		public const short MusicBoxSpace = 1597;

		// Token: 0x04005474 RID: 21620
		public const short MusicBoxCrimson = 1598;

		// Token: 0x04005475 RID: 21621
		public const short MusicBoxBoss4 = 1599;

		// Token: 0x04005476 RID: 21622
		public const short MusicBoxAltOverworldDay = 1600;

		// Token: 0x04005477 RID: 21623
		public const short MusicBoxRain = 1601;

		// Token: 0x04005478 RID: 21624
		public const short MusicBoxIce = 1602;

		// Token: 0x04005479 RID: 21625
		public const short MusicBoxDesert = 1603;

		// Token: 0x0400547A RID: 21626
		public const short MusicBoxOcean = 1604;

		// Token: 0x0400547B RID: 21627
		public const short MusicBoxDungeon = 1605;

		// Token: 0x0400547C RID: 21628
		public const short MusicBoxPlantera = 1606;

		// Token: 0x0400547D RID: 21629
		public const short MusicBoxBoss5 = 1607;

		// Token: 0x0400547E RID: 21630
		public const short MusicBoxTemple = 1608;

		// Token: 0x0400547F RID: 21631
		public const short MusicBoxEclipse = 1609;

		// Token: 0x04005480 RID: 21632
		public const short MusicBoxMushrooms = 1610;

		// Token: 0x04005481 RID: 21633
		public const short ButterflyDust = 1611;

		// Token: 0x04005482 RID: 21634
		public const short AnkhCharm = 1612;

		// Token: 0x04005483 RID: 21635
		public const short AnkhShield = 1613;

		// Token: 0x04005484 RID: 21636
		public const short BlueFlare = 1614;

		// Token: 0x04005485 RID: 21637
		public const short AnglerFishBanner = 1615;

		// Token: 0x04005486 RID: 21638
		public const short AngryNimbusBanner = 1616;

		// Token: 0x04005487 RID: 21639
		public const short AnomuraFungusBanner = 1617;

		// Token: 0x04005488 RID: 21640
		public const short AntlionBanner = 1618;

		// Token: 0x04005489 RID: 21641
		public const short ArapaimaBanner = 1619;

		// Token: 0x0400548A RID: 21642
		public const short ArmoredSkeletonBanner = 1620;

		// Token: 0x0400548B RID: 21643
		public const short BatBanner = 1621;

		// Token: 0x0400548C RID: 21644
		public const short BirdBanner = 1622;

		// Token: 0x0400548D RID: 21645
		public const short BlackRecluseBanner = 1623;

		// Token: 0x0400548E RID: 21646
		public const short BloodFeederBanner = 1624;

		// Token: 0x0400548F RID: 21647
		public const short BloodJellyBanner = 1625;

		// Token: 0x04005490 RID: 21648
		public const short BloodCrawlerBanner = 1626;

		// Token: 0x04005491 RID: 21649
		public const short BoneSerpentBanner = 1627;

		// Token: 0x04005492 RID: 21650
		public const short BunnyBanner = 1628;

		// Token: 0x04005493 RID: 21651
		public const short ChaosElementalBanner = 1629;

		// Token: 0x04005494 RID: 21652
		public const short MimicBanner = 1630;

		// Token: 0x04005495 RID: 21653
		public const short ClownBanner = 1631;

		// Token: 0x04005496 RID: 21654
		public const short CorruptBunnyBanner = 1632;

		// Token: 0x04005497 RID: 21655
		public const short CorruptGoldfishBanner = 1633;

		// Token: 0x04005498 RID: 21656
		public const short CrabBanner = 1634;

		// Token: 0x04005499 RID: 21657
		public const short CrimeraBanner = 1635;

		// Token: 0x0400549A RID: 21658
		public const short CrimsonAxeBanner = 1636;

		// Token: 0x0400549B RID: 21659
		public const short CursedHammerBanner = 1637;

		// Token: 0x0400549C RID: 21660
		public const short DemonBanner = 1638;

		// Token: 0x0400549D RID: 21661
		public const short DemonEyeBanner = 1639;

		// Token: 0x0400549E RID: 21662
		public const short DerplingBanner = 1640;

		// Token: 0x0400549F RID: 21663
		public const short EaterofSoulsBanner = 1641;

		// Token: 0x040054A0 RID: 21664
		public const short EnchantedSwordBanner = 1642;

		// Token: 0x040054A1 RID: 21665
		public const short ZombieEskimoBanner = 1643;

		// Token: 0x040054A2 RID: 21666
		public const short FaceMonsterBanner = 1644;

		// Token: 0x040054A3 RID: 21667
		public const short FloatyGrossBanner = 1645;

		// Token: 0x040054A4 RID: 21668
		public const short FlyingFishBanner = 1646;

		// Token: 0x040054A5 RID: 21669
		public const short FlyingSnakeBanner = 1647;

		// Token: 0x040054A6 RID: 21670
		public const short FrankensteinBanner = 1648;

		// Token: 0x040054A7 RID: 21671
		public const short FungiBulbBanner = 1649;

		// Token: 0x040054A8 RID: 21672
		public const short FungoFishBanner = 1650;

		// Token: 0x040054A9 RID: 21673
		public const short GastropodBanner = 1651;

		// Token: 0x040054AA RID: 21674
		public const short GoblinThiefBanner = 1652;

		// Token: 0x040054AB RID: 21675
		public const short GoblinSorcererBanner = 1653;

		// Token: 0x040054AC RID: 21676
		public const short GoblinPeonBanner = 1654;

		// Token: 0x040054AD RID: 21677
		public const short GoblinScoutBanner = 1655;

		// Token: 0x040054AE RID: 21678
		public const short GoblinWarriorBanner = 1656;

		// Token: 0x040054AF RID: 21679
		public const short GoldfishBanner = 1657;

		// Token: 0x040054B0 RID: 21680
		public const short HarpyBanner = 1658;

		// Token: 0x040054B1 RID: 21681
		public const short HellbatBanner = 1659;

		// Token: 0x040054B2 RID: 21682
		public const short HerplingBanner = 1660;

		// Token: 0x040054B3 RID: 21683
		public const short HornetBanner = 1661;

		// Token: 0x040054B4 RID: 21684
		public const short IceElementalBanner = 1662;

		// Token: 0x040054B5 RID: 21685
		public const short IcyMermanBanner = 1663;

		// Token: 0x040054B6 RID: 21686
		public const short FireImpBanner = 1664;

		// Token: 0x040054B7 RID: 21687
		public const short JellyfishBanner = 1665;

		// Token: 0x040054B8 RID: 21688
		public const short JungleCreeperBanner = 1666;

		// Token: 0x040054B9 RID: 21689
		public const short LihzahrdBanner = 1667;

		// Token: 0x040054BA RID: 21690
		public const short ManEaterBanner = 1668;

		// Token: 0x040054BB RID: 21691
		public const short MeteorHeadBanner = 1669;

		// Token: 0x040054BC RID: 21692
		public const short MothBanner = 1670;

		// Token: 0x040054BD RID: 21693
		public const short MummyBanner = 1671;

		// Token: 0x040054BE RID: 21694
		public const short MushiLadybugBanner = 1672;

		// Token: 0x040054BF RID: 21695
		public const short ParrotBanner = 1673;

		// Token: 0x040054C0 RID: 21696
		public const short PigronBanner = 1674;

		// Token: 0x040054C1 RID: 21697
		public const short PiranhaBanner = 1675;

		// Token: 0x040054C2 RID: 21698
		public const short PirateBanner = 1676;

		// Token: 0x040054C3 RID: 21699
		public const short PixieBanner = 1677;

		// Token: 0x040054C4 RID: 21700
		public const short RaincoatZombieBanner = 1678;

		// Token: 0x040054C5 RID: 21701
		public const short ReaperBanner = 1679;

		// Token: 0x040054C6 RID: 21702
		public const short SharkBanner = 1680;

		// Token: 0x040054C7 RID: 21703
		public const short SkeletonBanner = 1681;

		// Token: 0x040054C8 RID: 21704
		public const short SkeletonMageBanner = 1682;

		// Token: 0x040054C9 RID: 21705
		public const short SlimeBanner = 1683;

		// Token: 0x040054CA RID: 21706
		public const short SnowFlinxBanner = 1684;

		// Token: 0x040054CB RID: 21707
		public const short SpiderBanner = 1685;

		// Token: 0x040054CC RID: 21708
		public const short SporeZombieBanner = 1686;

		// Token: 0x040054CD RID: 21709
		public const short SwampThingBanner = 1687;

		// Token: 0x040054CE RID: 21710
		public const short TortoiseBanner = 1688;

		// Token: 0x040054CF RID: 21711
		public const short ToxicSludgeBanner = 1689;

		// Token: 0x040054D0 RID: 21712
		public const short UmbrellaSlimeBanner = 1690;

		// Token: 0x040054D1 RID: 21713
		public const short UnicornBanner = 1691;

		// Token: 0x040054D2 RID: 21714
		public const short VampireBanner = 1692;

		// Token: 0x040054D3 RID: 21715
		public const short VultureBanner = 1693;

		// Token: 0x040054D4 RID: 21716
		public const short NypmhBanner = 1694;

		// Token: 0x040054D5 RID: 21717
		public const short WerewolfBanner = 1695;

		// Token: 0x040054D6 RID: 21718
		public const short WolfBanner = 1696;

		// Token: 0x040054D7 RID: 21719
		public const short WorldFeederBanner = 1697;

		// Token: 0x040054D8 RID: 21720
		public const short WormBanner = 1698;

		// Token: 0x040054D9 RID: 21721
		public const short WraithBanner = 1699;

		// Token: 0x040054DA RID: 21722
		public const short WyvernBanner = 1700;

		// Token: 0x040054DB RID: 21723
		public const short ZombieBanner = 1701;

		// Token: 0x040054DC RID: 21724
		public const short GlassPlatform = 1702;

		// Token: 0x040054DD RID: 21725
		public const short GlassChair = 1703;

		// Token: 0x040054DE RID: 21726
		public const short GoldenChair = 1704;

		// Token: 0x040054DF RID: 21727
		public const short GoldenToilet = 1705;

		// Token: 0x040054E0 RID: 21728
		public const short BarStool = 1706;

		// Token: 0x040054E1 RID: 21729
		public const short HoneyChair = 1707;

		// Token: 0x040054E2 RID: 21730
		public const short SteampunkChair = 1708;

		// Token: 0x040054E3 RID: 21731
		public const short GlassDoor = 1709;

		// Token: 0x040054E4 RID: 21732
		public const short GoldenDoor = 1710;

		// Token: 0x040054E5 RID: 21733
		public const short HoneyDoor = 1711;

		// Token: 0x040054E6 RID: 21734
		public const short SteampunkDoor = 1712;

		// Token: 0x040054E7 RID: 21735
		public const short GlassTable = 1713;

		// Token: 0x040054E8 RID: 21736
		public const short BanquetTable = 1714;

		// Token: 0x040054E9 RID: 21737
		public const short Bar = 1715;

		// Token: 0x040054EA RID: 21738
		public const short GoldenTable = 1716;

		// Token: 0x040054EB RID: 21739
		public const short HoneyTable = 1717;

		// Token: 0x040054EC RID: 21740
		public const short SteampunkTable = 1718;

		// Token: 0x040054ED RID: 21741
		public const short GlassBed = 1719;

		// Token: 0x040054EE RID: 21742
		public const short GoldenBed = 1720;

		// Token: 0x040054EF RID: 21743
		public const short HoneyBed = 1721;

		// Token: 0x040054F0 RID: 21744
		public const short SteampunkBed = 1722;

		// Token: 0x040054F1 RID: 21745
		public const short LivingWoodWall = 1723;

		// Token: 0x040054F2 RID: 21746
		public const short FartinaJar = 1724;

		// Token: 0x040054F3 RID: 21747
		public const short Pumpkin = 1725;

		// Token: 0x040054F4 RID: 21748
		public const short PumpkinWall = 1726;

		// Token: 0x040054F5 RID: 21749
		public const short Hay = 1727;

		// Token: 0x040054F6 RID: 21750
		public const short HayWall = 1728;

		// Token: 0x040054F7 RID: 21751
		public const short SpookyWood = 1729;

		// Token: 0x040054F8 RID: 21752
		public const short SpookyWoodWall = 1730;

		// Token: 0x040054F9 RID: 21753
		public const short PumpkinHelmet = 1731;

		// Token: 0x040054FA RID: 21754
		public const short PumpkinBreastplate = 1732;

		// Token: 0x040054FB RID: 21755
		public const short PumpkinLeggings = 1733;

		// Token: 0x040054FC RID: 21756
		public const short CandyApple = 1734;

		// Token: 0x040054FD RID: 21757
		public const short SoulCake = 1735;

		// Token: 0x040054FE RID: 21758
		public const short NurseHat = 1736;

		// Token: 0x040054FF RID: 21759
		public const short NurseShirt = 1737;

		// Token: 0x04005500 RID: 21760
		public const short NursePants = 1738;

		// Token: 0x04005501 RID: 21761
		public const short WizardsHat = 1739;

		// Token: 0x04005502 RID: 21762
		public const short GuyFawkesMask = 1740;

		// Token: 0x04005503 RID: 21763
		public const short DyeTraderRobe = 1741;

		// Token: 0x04005504 RID: 21764
		public const short SteampunkGoggles = 1742;

		// Token: 0x04005505 RID: 21765
		public const short CyborgHelmet = 1743;

		// Token: 0x04005506 RID: 21766
		public const short CyborgShirt = 1744;

		// Token: 0x04005507 RID: 21767
		public const short CyborgPants = 1745;

		// Token: 0x04005508 RID: 21768
		public const short CreeperMask = 1746;

		// Token: 0x04005509 RID: 21769
		public const short CreeperShirt = 1747;

		// Token: 0x0400550A RID: 21770
		public const short CreeperPants = 1748;

		// Token: 0x0400550B RID: 21771
		public const short CatMask = 1749;

		// Token: 0x0400550C RID: 21772
		public const short CatShirt = 1750;

		// Token: 0x0400550D RID: 21773
		public const short CatPants = 1751;

		// Token: 0x0400550E RID: 21774
		public const short GhostMask = 1752;

		// Token: 0x0400550F RID: 21775
		public const short GhostShirt = 1753;

		// Token: 0x04005510 RID: 21776
		public const short PumpkinMask = 1754;

		// Token: 0x04005511 RID: 21777
		public const short PumpkinShirt = 1755;

		// Token: 0x04005512 RID: 21778
		public const short PumpkinPants = 1756;

		// Token: 0x04005513 RID: 21779
		public const short RobotMask = 1757;

		// Token: 0x04005514 RID: 21780
		public const short RobotShirt = 1758;

		// Token: 0x04005515 RID: 21781
		public const short RobotPants = 1759;

		// Token: 0x04005516 RID: 21782
		public const short UnicornMask = 1760;

		// Token: 0x04005517 RID: 21783
		public const short UnicornShirt = 1761;

		// Token: 0x04005518 RID: 21784
		public const short UnicornPants = 1762;

		// Token: 0x04005519 RID: 21785
		public const short VampireMask = 1763;

		// Token: 0x0400551A RID: 21786
		public const short VampireShirt = 1764;

		// Token: 0x0400551B RID: 21787
		public const short VampirePants = 1765;

		// Token: 0x0400551C RID: 21788
		public const short WitchHat = 1766;

		// Token: 0x0400551D RID: 21789
		public const short LeprechaunHat = 1767;

		// Token: 0x0400551E RID: 21790
		public const short LeprechaunShirt = 1768;

		// Token: 0x0400551F RID: 21791
		public const short LeprechaunPants = 1769;

		// Token: 0x04005520 RID: 21792
		public const short PixieShirt = 1770;

		// Token: 0x04005521 RID: 21793
		public const short PixiePants = 1771;

		// Token: 0x04005522 RID: 21794
		public const short PrincessHat = 1772;

		// Token: 0x04005523 RID: 21795
		public const short PrincessDressNew = 1773;

		// Token: 0x04005524 RID: 21796
		public const short GoodieBag = 1774;

		// Token: 0x04005525 RID: 21797
		public const short WitchDress = 1775;

		// Token: 0x04005526 RID: 21798
		public const short WitchBoots = 1776;

		// Token: 0x04005527 RID: 21799
		public const short BrideofFrankensteinMask = 1777;

		// Token: 0x04005528 RID: 21800
		public const short BrideofFrankensteinDress = 1778;

		// Token: 0x04005529 RID: 21801
		public const short KarateTortoiseMask = 1779;

		// Token: 0x0400552A RID: 21802
		public const short KarateTortoiseShirt = 1780;

		// Token: 0x0400552B RID: 21803
		public const short KarateTortoisePants = 1781;

		// Token: 0x0400552C RID: 21804
		public const short CandyCornRifle = 1782;

		// Token: 0x0400552D RID: 21805
		public const short CandyCorn = 1783;

		// Token: 0x0400552E RID: 21806
		public const short JackOLanternLauncher = 1784;

		// Token: 0x0400552F RID: 21807
		public const short ExplosiveJackOLantern = 1785;

		// Token: 0x04005530 RID: 21808
		public const short Sickle = 1786;

		// Token: 0x04005531 RID: 21809
		public const short PumpkinPie = 1787;

		// Token: 0x04005532 RID: 21810
		public const short ScarecrowHat = 1788;

		// Token: 0x04005533 RID: 21811
		public const short ScarecrowShirt = 1789;

		// Token: 0x04005534 RID: 21812
		public const short ScarecrowPants = 1790;

		// Token: 0x04005535 RID: 21813
		public const short Cauldron = 1791;

		// Token: 0x04005536 RID: 21814
		public const short PumpkinChair = 1792;

		// Token: 0x04005537 RID: 21815
		public const short PumpkinDoor = 1793;

		// Token: 0x04005538 RID: 21816
		public const short PumpkinTable = 1794;

		// Token: 0x04005539 RID: 21817
		public const short PumpkinWorkBench = 1795;

		// Token: 0x0400553A RID: 21818
		public const short PumpkinPlatform = 1796;

		// Token: 0x0400553B RID: 21819
		public const short TatteredFairyWings = 1797;

		// Token: 0x0400553C RID: 21820
		public const short SpiderEgg = 1798;

		// Token: 0x0400553D RID: 21821
		public const short MagicalPumpkinSeed = 1799;

		// Token: 0x0400553E RID: 21822
		public const short BatHook = 1800;

		// Token: 0x0400553F RID: 21823
		public const short BatScepter = 1801;

		// Token: 0x04005540 RID: 21824
		public const short RavenStaff = 1802;

		// Token: 0x04005541 RID: 21825
		public const short JungleKeyMold = 1803;

		// Token: 0x04005542 RID: 21826
		public const short CorruptionKeyMold = 1804;

		// Token: 0x04005543 RID: 21827
		public const short CrimsonKeyMold = 1805;

		// Token: 0x04005544 RID: 21828
		public const short HallowedKeyMold = 1806;

		// Token: 0x04005545 RID: 21829
		public const short FrozenKeyMold = 1807;

		// Token: 0x04005546 RID: 21830
		public const short HangingJackOLantern = 1808;

		// Token: 0x04005547 RID: 21831
		public const short RottenEgg = 1809;

		// Token: 0x04005548 RID: 21832
		public const short UnluckyYarn = 1810;

		// Token: 0x04005549 RID: 21833
		public const short BlackFairyDust = 1811;

		// Token: 0x0400554A RID: 21834
		public const short Jackelier = 1812;

		// Token: 0x0400554B RID: 21835
		public const short JackOLantern = 1813;

		// Token: 0x0400554C RID: 21836
		public const short SpookyChair = 1814;

		// Token: 0x0400554D RID: 21837
		public const short SpookyDoor = 1815;

		// Token: 0x0400554E RID: 21838
		public const short SpookyTable = 1816;

		// Token: 0x0400554F RID: 21839
		public const short SpookyWorkBench = 1817;

		// Token: 0x04005550 RID: 21840
		public const short SpookyPlatform = 1818;

		// Token: 0x04005551 RID: 21841
		public const short ReaperHood = 1819;

		// Token: 0x04005552 RID: 21842
		public const short ReaperRobe = 1820;

		// Token: 0x04005553 RID: 21843
		public const short FoxMask = 1821;

		// Token: 0x04005554 RID: 21844
		public const short FoxShirt = 1822;

		// Token: 0x04005555 RID: 21845
		public const short FoxPants = 1823;

		// Token: 0x04005556 RID: 21846
		public const short CatEars = 1824;

		// Token: 0x04005557 RID: 21847
		public const short BloodyMachete = 1825;

		// Token: 0x04005558 RID: 21848
		public const short TheHorsemansBlade = 1826;

		// Token: 0x04005559 RID: 21849
		public const short BladedGlove = 1827;

		// Token: 0x0400555A RID: 21850
		public const short PumpkinSeed = 1828;

		// Token: 0x0400555B RID: 21851
		public const short SpookyHook = 1829;

		// Token: 0x0400555C RID: 21852
		public const short SpookyWings = 1830;

		// Token: 0x0400555D RID: 21853
		public const short SpookyTwig = 1831;

		// Token: 0x0400555E RID: 21854
		public const short SpookyHelmet = 1832;

		// Token: 0x0400555F RID: 21855
		public const short SpookyBreastplate = 1833;

		// Token: 0x04005560 RID: 21856
		public const short SpookyLeggings = 1834;

		// Token: 0x04005561 RID: 21857
		public const short StakeLauncher = 1835;

		// Token: 0x04005562 RID: 21858
		public const short Stake = 1836;

		// Token: 0x04005563 RID: 21859
		public const short CursedSapling = 1837;

		// Token: 0x04005564 RID: 21860
		public const short SpaceCreatureMask = 1838;

		// Token: 0x04005565 RID: 21861
		public const short SpaceCreatureShirt = 1839;

		// Token: 0x04005566 RID: 21862
		public const short SpaceCreaturePants = 1840;

		// Token: 0x04005567 RID: 21863
		public const short WolfMask = 1841;

		// Token: 0x04005568 RID: 21864
		public const short WolfShirt = 1842;

		// Token: 0x04005569 RID: 21865
		public const short WolfPants = 1843;

		// Token: 0x0400556A RID: 21866
		public const short PumpkinMoonMedallion = 1844;

		// Token: 0x0400556B RID: 21867
		public const short NecromanticScroll = 1845;

		// Token: 0x0400556C RID: 21868
		public const short JackingSkeletron = 1846;

		// Token: 0x0400556D RID: 21869
		public const short BitterHarvest = 1847;

		// Token: 0x0400556E RID: 21870
		public const short BloodMoonCountess = 1848;

		// Token: 0x0400556F RID: 21871
		public const short HallowsEve = 1849;

		// Token: 0x04005570 RID: 21872
		public const short MorbidCuriosity = 1850;

		// Token: 0x04005571 RID: 21873
		public const short TreasureHunterShirt = 1851;

		// Token: 0x04005572 RID: 21874
		public const short TreasureHunterPants = 1852;

		// Token: 0x04005573 RID: 21875
		public const short DryadCoverings = 1853;

		// Token: 0x04005574 RID: 21876
		public const short DryadLoincloth = 1854;

		// Token: 0x04005575 RID: 21877
		public const short MourningWoodTrophy = 1855;

		// Token: 0x04005576 RID: 21878
		public const short PumpkingTrophy = 1856;

		// Token: 0x04005577 RID: 21879
		public const short JackOLanternMask = 1857;

		// Token: 0x04005578 RID: 21880
		public const short SniperScope = 1858;

		// Token: 0x04005579 RID: 21881
		public const short HeartLantern = 1859;

		// Token: 0x0400557A RID: 21882
		public const short JellyfishDivingGear = 1860;

		// Token: 0x0400557B RID: 21883
		public const short ArcticDivingGear = 1861;

		// Token: 0x0400557C RID: 21884
		public const short FrostsparkBoots = 1862;

		// Token: 0x0400557D RID: 21885
		public const short FartInABalloon = 1863;

		// Token: 0x0400557E RID: 21886
		public const short PapyrusScarab = 1864;

		// Token: 0x0400557F RID: 21887
		public const short CelestialStone = 1865;

		// Token: 0x04005580 RID: 21888
		public const short Hoverboard = 1866;

		// Token: 0x04005581 RID: 21889
		public const short CandyCane = 1867;

		// Token: 0x04005582 RID: 21890
		public const short SugarPlum = 1868;

		// Token: 0x04005583 RID: 21891
		public const short Present = 1869;

		// Token: 0x04005584 RID: 21892
		public const short RedRyder = 1870;

		// Token: 0x04005585 RID: 21893
		public const short FestiveWings = 1871;

		// Token: 0x04005586 RID: 21894
		public const short PineTreeBlock = 1872;

		// Token: 0x04005587 RID: 21895
		public const short ChristmasTree = 1873;

		// Token: 0x04005588 RID: 21896
		public const short StarTopper1 = 1874;

		// Token: 0x04005589 RID: 21897
		public const short StarTopper2 = 1875;

		// Token: 0x0400558A RID: 21898
		public const short StarTopper3 = 1876;

		// Token: 0x0400558B RID: 21899
		public const short BowTopper = 1877;

		// Token: 0x0400558C RID: 21900
		public const short WhiteGarland = 1878;

		// Token: 0x0400558D RID: 21901
		public const short WhiteAndRedGarland = 1879;

		// Token: 0x0400558E RID: 21902
		public const short RedGardland = 1880;

		// Token: 0x0400558F RID: 21903
		public const short RedAndGreenGardland = 1881;

		// Token: 0x04005590 RID: 21904
		public const short GreenGardland = 1882;

		// Token: 0x04005591 RID: 21905
		public const short GreenAndWhiteGarland = 1883;

		// Token: 0x04005592 RID: 21906
		public const short MulticoloredBulb = 1884;

		// Token: 0x04005593 RID: 21907
		public const short RedBulb = 1885;

		// Token: 0x04005594 RID: 21908
		public const short YellowBulb = 1886;

		// Token: 0x04005595 RID: 21909
		public const short GreenBulb = 1887;

		// Token: 0x04005596 RID: 21910
		public const short RedAndGreenBulb = 1888;

		// Token: 0x04005597 RID: 21911
		public const short YellowAndGreenBulb = 1889;

		// Token: 0x04005598 RID: 21912
		public const short RedAndYellowBulb = 1890;

		// Token: 0x04005599 RID: 21913
		public const short WhiteBulb = 1891;

		// Token: 0x0400559A RID: 21914
		public const short WhiteAndRedBulb = 1892;

		// Token: 0x0400559B RID: 21915
		public const short WhiteAndYellowBulb = 1893;

		// Token: 0x0400559C RID: 21916
		public const short WhiteAndGreenBulb = 1894;

		// Token: 0x0400559D RID: 21917
		public const short MulticoloredLights = 1895;

		// Token: 0x0400559E RID: 21918
		public const short RedLights = 1896;

		// Token: 0x0400559F RID: 21919
		public const short GreenLights = 1897;

		// Token: 0x040055A0 RID: 21920
		public const short BlueLights = 1898;

		// Token: 0x040055A1 RID: 21921
		public const short YellowLights = 1899;

		// Token: 0x040055A2 RID: 21922
		public const short RedAndYellowLights = 1900;

		// Token: 0x040055A3 RID: 21923
		public const short RedAndGreenLights = 1901;

		// Token: 0x040055A4 RID: 21924
		public const short YellowAndGreenLights = 1902;

		// Token: 0x040055A5 RID: 21925
		public const short BlueAndGreenLights = 1903;

		// Token: 0x040055A6 RID: 21926
		public const short RedAndBlueLights = 1904;

		// Token: 0x040055A7 RID: 21927
		public const short BlueAndYellowLights = 1905;

		// Token: 0x040055A8 RID: 21928
		public const short GiantBow = 1906;

		// Token: 0x040055A9 RID: 21929
		public const short ReindeerAntlers = 1907;

		// Token: 0x040055AA RID: 21930
		public const short Holly = 1908;

		// Token: 0x040055AB RID: 21931
		public const short CandyCaneSword = 1909;

		// Token: 0x040055AC RID: 21932
		public const short ElfMelter = 1910;

		// Token: 0x040055AD RID: 21933
		public const short ChristmasPudding = 1911;

		// Token: 0x040055AE RID: 21934
		public const short Eggnog = 1912;

		// Token: 0x040055AF RID: 21935
		public const short StarAnise = 1913;

		// Token: 0x040055B0 RID: 21936
		public const short ReindeerBells = 1914;

		// Token: 0x040055B1 RID: 21937
		public const short CandyCaneHook = 1915;

		// Token: 0x040055B2 RID: 21938
		public const short ChristmasHook = 1916;

		// Token: 0x040055B3 RID: 21939
		public const short CnadyCanePickaxe = 1917;

		// Token: 0x040055B4 RID: 21940
		public const short FruitcakeChakram = 1918;

		// Token: 0x040055B5 RID: 21941
		public const short SugarCookie = 1919;

		// Token: 0x040055B6 RID: 21942
		public const short GingerbreadCookie = 1920;

		// Token: 0x040055B7 RID: 21943
		public const short HandWarmer = 1921;

		// Token: 0x040055B8 RID: 21944
		public const short Coal = 1922;

		// Token: 0x040055B9 RID: 21945
		public const short Toolbox = 1923;

		// Token: 0x040055BA RID: 21946
		public const short PineDoor = 1924;

		// Token: 0x040055BB RID: 21947
		public const short PineChair = 1925;

		// Token: 0x040055BC RID: 21948
		public const short PineTable = 1926;

		// Token: 0x040055BD RID: 21949
		public const short DogWhistle = 1927;

		// Token: 0x040055BE RID: 21950
		public const short ChristmasTreeSword = 1928;

		// Token: 0x040055BF RID: 21951
		public const short ChainGun = 1929;

		// Token: 0x040055C0 RID: 21952
		public const short Razorpine = 1930;

		// Token: 0x040055C1 RID: 21953
		public const short BlizzardStaff = 1931;

		// Token: 0x040055C2 RID: 21954
		public const short MrsClauseHat = 1932;

		// Token: 0x040055C3 RID: 21955
		public const short MrsClauseShirt = 1933;

		// Token: 0x040055C4 RID: 21956
		public const short MrsClauseHeels = 1934;

		// Token: 0x040055C5 RID: 21957
		public const short ParkaHood = 1935;

		// Token: 0x040055C6 RID: 21958
		public const short ParkaCoat = 1936;

		// Token: 0x040055C7 RID: 21959
		public const short ParkaPants = 1937;

		// Token: 0x040055C8 RID: 21960
		public const short SnowHat = 1938;

		// Token: 0x040055C9 RID: 21961
		public const short UglySweater = 1939;

		// Token: 0x040055CA RID: 21962
		public const short TreeMask = 1940;

		// Token: 0x040055CB RID: 21963
		public const short TreeShirt = 1941;

		// Token: 0x040055CC RID: 21964
		public const short TreeTrunks = 1942;

		// Token: 0x040055CD RID: 21965
		public const short ElfHat = 1943;

		// Token: 0x040055CE RID: 21966
		public const short ElfShirt = 1944;

		// Token: 0x040055CF RID: 21967
		public const short ElfPants = 1945;

		// Token: 0x040055D0 RID: 21968
		public const short SnowmanCannon = 1946;

		// Token: 0x040055D1 RID: 21969
		public const short NorthPole = 1947;

		// Token: 0x040055D2 RID: 21970
		public const short ChristmasTreeWallpaper = 1948;

		// Token: 0x040055D3 RID: 21971
		public const short OrnamentWallpaper = 1949;

		// Token: 0x040055D4 RID: 21972
		public const short CandyCaneWallpaper = 1950;

		// Token: 0x040055D5 RID: 21973
		public const short FestiveWallpaper = 1951;

		// Token: 0x040055D6 RID: 21974
		public const short StarsWallpaper = 1952;

		// Token: 0x040055D7 RID: 21975
		public const short SquigglesWallpaper = 1953;

		// Token: 0x040055D8 RID: 21976
		public const short SnowflakeWallpaper = 1954;

		// Token: 0x040055D9 RID: 21977
		public const short KrampusHornWallpaper = 1955;

		// Token: 0x040055DA RID: 21978
		public const short BluegreenWallpaper = 1956;

		// Token: 0x040055DB RID: 21979
		public const short GrinchFingerWallpaper = 1957;

		// Token: 0x040055DC RID: 21980
		public const short NaughtyPresent = 1958;

		// Token: 0x040055DD RID: 21981
		public const short BabyGrinchMischiefWhistle = 1959;

		// Token: 0x040055DE RID: 21982
		public const short IceQueenTrophy = 1960;

		// Token: 0x040055DF RID: 21983
		public const short SantaNK1Trophy = 1961;

		// Token: 0x040055E0 RID: 21984
		public const short EverscreamTrophy = 1962;

		// Token: 0x040055E1 RID: 21985
		public const short MusicBoxPumpkinMoon = 1963;

		// Token: 0x040055E2 RID: 21986
		public const short MusicBoxAltUnderground = 1964;

		// Token: 0x040055E3 RID: 21987
		public const short MusicBoxFrostMoon = 1965;

		// Token: 0x040055E4 RID: 21988
		public const short BrownPaint = 1966;

		// Token: 0x040055E5 RID: 21989
		public const short ShadowPaint = 1967;

		// Token: 0x040055E6 RID: 21990
		public const short NegativePaint = 1968;

		// Token: 0x040055E7 RID: 21991
		public const short TeamDye = 1969;

		// Token: 0x040055E8 RID: 21992
		public const short AmethystGemsparkBlock = 1970;

		// Token: 0x040055E9 RID: 21993
		public const short TopazGemsparkBlock = 1971;

		// Token: 0x040055EA RID: 21994
		public const short SapphireGemsparkBlock = 1972;

		// Token: 0x040055EB RID: 21995
		public const short EmeraldGemsparkBlock = 1973;

		// Token: 0x040055EC RID: 21996
		public const short RubyGemsparkBlock = 1974;

		// Token: 0x040055ED RID: 21997
		public const short DiamondGemsparkBlock = 1975;

		// Token: 0x040055EE RID: 21998
		public const short AmberGemsparkBlock = 1976;

		// Token: 0x040055EF RID: 21999
		public const short LifeHairDye = 1977;

		// Token: 0x040055F0 RID: 22000
		public const short ManaHairDye = 1978;

		// Token: 0x040055F1 RID: 22001
		public const short DepthHairDye = 1979;

		// Token: 0x040055F2 RID: 22002
		public const short MoneyHairDye = 1980;

		// Token: 0x040055F3 RID: 22003
		public const short TimeHairDye = 1981;

		// Token: 0x040055F4 RID: 22004
		public const short TeamHairDye = 1982;

		// Token: 0x040055F5 RID: 22005
		public const short BiomeHairDye = 1983;

		// Token: 0x040055F6 RID: 22006
		public const short PartyHairDye = 1984;

		// Token: 0x040055F7 RID: 22007
		public const short RainbowHairDye = 1985;

		// Token: 0x040055F8 RID: 22008
		public const short SpeedHairDye = 1986;

		// Token: 0x040055F9 RID: 22009
		public const short AngelHalo = 1987;

		// Token: 0x040055FA RID: 22010
		public const short Fez = 1988;

		// Token: 0x040055FB RID: 22011
		public const short Womannquin = 1989;

		// Token: 0x040055FC RID: 22012
		public const short HairDyeRemover = 1990;

		// Token: 0x040055FD RID: 22013
		public const short BugNet = 1991;

		// Token: 0x040055FE RID: 22014
		public const short Firefly = 1992;

		// Token: 0x040055FF RID: 22015
		public const short FireflyinaBottle = 1993;

		// Token: 0x04005600 RID: 22016
		public const short MonarchButterfly = 1994;

		// Token: 0x04005601 RID: 22017
		public const short PurpleEmperorButterfly = 1995;

		// Token: 0x04005602 RID: 22018
		public const short RedAdmiralButterfly = 1996;

		// Token: 0x04005603 RID: 22019
		public const short UlyssesButterfly = 1997;

		// Token: 0x04005604 RID: 22020
		public const short SulphurButterfly = 1998;

		// Token: 0x04005605 RID: 22021
		public const short TreeNymphButterfly = 1999;

		// Token: 0x04005606 RID: 22022
		public const short ZebraSwallowtailButterfly = 2000;

		// Token: 0x04005607 RID: 22023
		public const short JuliaButterfly = 2001;

		// Token: 0x04005608 RID: 22024
		public const short Worm = 2002;

		// Token: 0x04005609 RID: 22025
		public const short Mouse = 2003;

		// Token: 0x0400560A RID: 22026
		public const short LightningBug = 2004;

		// Token: 0x0400560B RID: 22027
		public const short LightningBuginaBottle = 2005;

		// Token: 0x0400560C RID: 22028
		public const short Snail = 2006;

		// Token: 0x0400560D RID: 22029
		public const short GlowingSnail = 2007;

		// Token: 0x0400560E RID: 22030
		public const short FancyGreyWallpaper = 2008;

		// Token: 0x0400560F RID: 22031
		public const short IceFloeWallpaper = 2009;

		// Token: 0x04005610 RID: 22032
		public const short MusicWallpaper = 2010;

		// Token: 0x04005611 RID: 22033
		public const short PurpleRainWallpaper = 2011;

		// Token: 0x04005612 RID: 22034
		public const short RainbowWallpaper = 2012;

		// Token: 0x04005613 RID: 22035
		public const short SparkleStoneWallpaper = 2013;

		// Token: 0x04005614 RID: 22036
		public const short StarlitHeavenWallpaper = 2014;

		// Token: 0x04005615 RID: 22037
		public const short Bird = 2015;

		// Token: 0x04005616 RID: 22038
		public const short BlueJay = 2016;

		// Token: 0x04005617 RID: 22039
		public const short Cardinal = 2017;

		// Token: 0x04005618 RID: 22040
		public const short Squirrel = 2018;

		// Token: 0x04005619 RID: 22041
		public const short Bunny = 2019;

		// Token: 0x0400561A RID: 22042
		public const short CactusBookcase = 2020;

		// Token: 0x0400561B RID: 22043
		public const short EbonwoodBookcase = 2021;

		// Token: 0x0400561C RID: 22044
		public const short FleshBookcase = 2022;

		// Token: 0x0400561D RID: 22045
		public const short HoneyBookcase = 2023;

		// Token: 0x0400561E RID: 22046
		public const short SteampunkBookcase = 2024;

		// Token: 0x0400561F RID: 22047
		public const short GlassBookcase = 2025;

		// Token: 0x04005620 RID: 22048
		public const short RichMahoganyBookcase = 2026;

		// Token: 0x04005621 RID: 22049
		public const short PearlwoodBookcase = 2027;

		// Token: 0x04005622 RID: 22050
		public const short SpookyBookcase = 2028;

		// Token: 0x04005623 RID: 22051
		public const short SkywareBookcase = 2029;

		// Token: 0x04005624 RID: 22052
		public const short LihzahrdBookcase = 2030;

		// Token: 0x04005625 RID: 22053
		public const short FrozenBookcase = 2031;

		// Token: 0x04005626 RID: 22054
		public const short CactusLantern = 2032;

		// Token: 0x04005627 RID: 22055
		public const short EbonwoodLantern = 2033;

		// Token: 0x04005628 RID: 22056
		public const short FleshLantern = 2034;

		// Token: 0x04005629 RID: 22057
		public const short HoneyLantern = 2035;

		// Token: 0x0400562A RID: 22058
		public const short SteampunkLantern = 2036;

		// Token: 0x0400562B RID: 22059
		public const short GlassLantern = 2037;

		// Token: 0x0400562C RID: 22060
		public const short RichMahoganyLantern = 2038;

		// Token: 0x0400562D RID: 22061
		public const short PearlwoodLantern = 2039;

		// Token: 0x0400562E RID: 22062
		public const short FrozenLantern = 2040;

		// Token: 0x0400562F RID: 22063
		public const short LihzahrdLantern = 2041;

		// Token: 0x04005630 RID: 22064
		public const short SkywareLantern = 2042;

		// Token: 0x04005631 RID: 22065
		public const short SpookyLantern = 2043;

		// Token: 0x04005632 RID: 22066
		public const short FrozenDoor = 2044;

		// Token: 0x04005633 RID: 22067
		public const short CactusCandle = 2045;

		// Token: 0x04005634 RID: 22068
		public const short EbonwoodCandle = 2046;

		// Token: 0x04005635 RID: 22069
		public const short FleshCandle = 2047;

		// Token: 0x04005636 RID: 22070
		public const short GlassCandle = 2048;

		// Token: 0x04005637 RID: 22071
		public const short FrozenCandle = 2049;

		// Token: 0x04005638 RID: 22072
		public const short RichMahoganyCandle = 2050;

		// Token: 0x04005639 RID: 22073
		public const short PearlwoodCandle = 2051;

		// Token: 0x0400563A RID: 22074
		public const short LihzahrdCandle = 2052;

		// Token: 0x0400563B RID: 22075
		public const short SkywareCandle = 2053;

		// Token: 0x0400563C RID: 22076
		public const short PumpkinCandle = 2054;

		// Token: 0x0400563D RID: 22077
		public const short CactusChandelier = 2055;

		// Token: 0x0400563E RID: 22078
		public const short EbonwoodChandelier = 2056;

		// Token: 0x0400563F RID: 22079
		public const short FleshChandelier = 2057;

		// Token: 0x04005640 RID: 22080
		public const short HoneyChandelier = 2058;

		// Token: 0x04005641 RID: 22081
		public const short FrozenChandelier = 2059;

		// Token: 0x04005642 RID: 22082
		public const short RichMahoganyChandelier = 2060;

		// Token: 0x04005643 RID: 22083
		public const short PearlwoodChandelier = 2061;

		// Token: 0x04005644 RID: 22084
		public const short LihzahrdChandelier = 2062;

		// Token: 0x04005645 RID: 22085
		public const short SkywareChandelier = 2063;

		// Token: 0x04005646 RID: 22086
		public const short SpookyChandelier = 2064;

		// Token: 0x04005647 RID: 22087
		public const short GlassChandelier = 2065;

		// Token: 0x04005648 RID: 22088
		public const short CactusBed = 2066;

		// Token: 0x04005649 RID: 22089
		public const short FleshBed = 2067;

		// Token: 0x0400564A RID: 22090
		public const short FrozenBed = 2068;

		// Token: 0x0400564B RID: 22091
		public const short LihzahrdBed = 2069;

		// Token: 0x0400564C RID: 22092
		public const short SkywareBed = 2070;

		// Token: 0x0400564D RID: 22093
		public const short SpookyBed = 2071;

		// Token: 0x0400564E RID: 22094
		public const short CactusBathtub = 2072;

		// Token: 0x0400564F RID: 22095
		public const short EbonwoodBathtub = 2073;

		// Token: 0x04005650 RID: 22096
		public const short FleshBathtub = 2074;

		// Token: 0x04005651 RID: 22097
		public const short GlassBathtub = 2075;

		// Token: 0x04005652 RID: 22098
		public const short FrozenBathtub = 2076;

		// Token: 0x04005653 RID: 22099
		public const short RichMahoganyBathtub = 2077;

		// Token: 0x04005654 RID: 22100
		public const short PearlwoodBathtub = 2078;

		// Token: 0x04005655 RID: 22101
		public const short LihzahrdBathtub = 2079;

		// Token: 0x04005656 RID: 22102
		public const short SkywareBathtub = 2080;

		// Token: 0x04005657 RID: 22103
		public const short SpookyBathtub = 2081;

		// Token: 0x04005658 RID: 22104
		public const short CactusLamp = 2082;

		// Token: 0x04005659 RID: 22105
		public const short EbonwoodLamp = 2083;

		// Token: 0x0400565A RID: 22106
		public const short FleshLamp = 2084;

		// Token: 0x0400565B RID: 22107
		public const short GlassLamp = 2085;

		// Token: 0x0400565C RID: 22108
		public const short FrozenLamp = 2086;

		// Token: 0x0400565D RID: 22109
		public const short RichMahoganyLamp = 2087;

		// Token: 0x0400565E RID: 22110
		public const short PearlwoodLamp = 2088;

		// Token: 0x0400565F RID: 22111
		public const short LihzahrdLamp = 2089;

		// Token: 0x04005660 RID: 22112
		public const short SkywareLamp = 2090;

		// Token: 0x04005661 RID: 22113
		public const short SpookyLamp = 2091;

		// Token: 0x04005662 RID: 22114
		public const short CactusCandelabra = 2092;

		// Token: 0x04005663 RID: 22115
		public const short EbonwoodCandelabra = 2093;

		// Token: 0x04005664 RID: 22116
		public const short FleshCandelabra = 2094;

		// Token: 0x04005665 RID: 22117
		public const short HoneyCandelabra = 2095;

		// Token: 0x04005666 RID: 22118
		public const short SteampunkCandelabra = 2096;

		// Token: 0x04005667 RID: 22119
		public const short GlassCandelabra = 2097;

		// Token: 0x04005668 RID: 22120
		public const short RichMahoganyCandelabra = 2098;

		// Token: 0x04005669 RID: 22121
		public const short PearlwoodCandelabra = 2099;

		// Token: 0x0400566A RID: 22122
		public const short FrozenCandelabra = 2100;

		// Token: 0x0400566B RID: 22123
		public const short LihzahrdCandelabra = 2101;

		// Token: 0x0400566C RID: 22124
		public const short SkywareCandelabra = 2102;

		// Token: 0x0400566D RID: 22125
		public const short SpookyCandelabra = 2103;

		// Token: 0x0400566E RID: 22126
		public const short BrainMask = 2104;

		// Token: 0x0400566F RID: 22127
		public const short FleshMask = 2105;

		// Token: 0x04005670 RID: 22128
		public const short TwinMask = 2106;

		// Token: 0x04005671 RID: 22129
		public const short SkeletronPrimeMask = 2107;

		// Token: 0x04005672 RID: 22130
		public const short BeeMask = 2108;

		// Token: 0x04005673 RID: 22131
		public const short PlanteraMask = 2109;

		// Token: 0x04005674 RID: 22132
		public const short GolemMask = 2110;

		// Token: 0x04005675 RID: 22133
		public const short EaterMask = 2111;

		// Token: 0x04005676 RID: 22134
		public const short EyeMask = 2112;

		// Token: 0x04005677 RID: 22135
		public const short DestroyerMask = 2113;

		// Token: 0x04005678 RID: 22136
		public const short BlacksmithRack = 2114;

		// Token: 0x04005679 RID: 22137
		public const short CarpentryRack = 2115;

		// Token: 0x0400567A RID: 22138
		public const short HelmetRack = 2116;

		// Token: 0x0400567B RID: 22139
		public const short SpearRack = 2117;

		// Token: 0x0400567C RID: 22140
		public const short SwordRack = 2118;

		// Token: 0x0400567D RID: 22141
		public const short StoneSlab = 2119;

		// Token: 0x0400567E RID: 22142
		public const short SandstoneSlab = 2120;

		// Token: 0x0400567F RID: 22143
		public const short Frog = 2121;

		// Token: 0x04005680 RID: 22144
		public const short MallardDuck = 2122;

		// Token: 0x04005681 RID: 22145
		public const short Duck = 2123;

		// Token: 0x04005682 RID: 22146
		public const short HoneyBathtub = 2124;

		// Token: 0x04005683 RID: 22147
		public const short SteampunkBathtub = 2125;

		// Token: 0x04005684 RID: 22148
		public const short LivingWoodBathtub = 2126;

		// Token: 0x04005685 RID: 22149
		public const short ShadewoodBathtub = 2127;

		// Token: 0x04005686 RID: 22150
		public const short BoneBathtub = 2128;

		// Token: 0x04005687 RID: 22151
		public const short HoneyLamp = 2129;

		// Token: 0x04005688 RID: 22152
		public const short SteampunkLamp = 2130;

		// Token: 0x04005689 RID: 22153
		public const short LivingWoodLamp = 2131;

		// Token: 0x0400568A RID: 22154
		public const short ShadewoodLamp = 2132;

		// Token: 0x0400568B RID: 22155
		public const short GoldenLamp = 2133;

		// Token: 0x0400568C RID: 22156
		public const short BoneLamp = 2134;

		// Token: 0x0400568D RID: 22157
		public const short LivingWoodBookcase = 2135;

		// Token: 0x0400568E RID: 22158
		public const short ShadewoodBookcase = 2136;

		// Token: 0x0400568F RID: 22159
		public const short GoldenBookcase = 2137;

		// Token: 0x04005690 RID: 22160
		public const short BoneBookcase = 2138;

		// Token: 0x04005691 RID: 22161
		public const short LivingWoodBed = 2139;

		// Token: 0x04005692 RID: 22162
		public const short BoneBed = 2140;

		// Token: 0x04005693 RID: 22163
		public const short LivingWoodChandelier = 2141;

		// Token: 0x04005694 RID: 22164
		public const short ShadewoodChandelier = 2142;

		// Token: 0x04005695 RID: 22165
		public const short GoldenChandelier = 2143;

		// Token: 0x04005696 RID: 22166
		public const short BoneChandelier = 2144;

		// Token: 0x04005697 RID: 22167
		public const short LivingWoodLantern = 2145;

		// Token: 0x04005698 RID: 22168
		public const short ShadewoodLantern = 2146;

		// Token: 0x04005699 RID: 22169
		public const short GoldenLantern = 2147;

		// Token: 0x0400569A RID: 22170
		public const short BoneLantern = 2148;

		// Token: 0x0400569B RID: 22171
		public const short LivingWoodCandelabra = 2149;

		// Token: 0x0400569C RID: 22172
		public const short ShadewoodCandelabra = 2150;

		// Token: 0x0400569D RID: 22173
		public const short GoldenCandelabra = 2151;

		// Token: 0x0400569E RID: 22174
		public const short BoneCandelabra = 2152;

		// Token: 0x0400569F RID: 22175
		public const short LivingWoodCandle = 2153;

		// Token: 0x040056A0 RID: 22176
		public const short ShadewoodCandle = 2154;

		// Token: 0x040056A1 RID: 22177
		public const short GoldenCandle = 2155;

		// Token: 0x040056A2 RID: 22178
		public const short BlackScorpion = 2156;

		// Token: 0x040056A3 RID: 22179
		public const short Scorpion = 2157;

		// Token: 0x040056A4 RID: 22180
		public const short BubbleWallpaper = 2158;

		// Token: 0x040056A5 RID: 22181
		public const short CopperPipeWallpaper = 2159;

		// Token: 0x040056A6 RID: 22182
		public const short DuckyWallpaper = 2160;

		// Token: 0x040056A7 RID: 22183
		public const short FrostCore = 2161;

		// Token: 0x040056A8 RID: 22184
		public const short BunnyCage = 2162;

		// Token: 0x040056A9 RID: 22185
		public const short SquirrelCage = 2163;

		// Token: 0x040056AA RID: 22186
		public const short MallardDuckCage = 2164;

		// Token: 0x040056AB RID: 22187
		public const short DuckCage = 2165;

		// Token: 0x040056AC RID: 22188
		public const short BirdCage = 2166;

		// Token: 0x040056AD RID: 22189
		public const short BlueJayCage = 2167;

		// Token: 0x040056AE RID: 22190
		public const short CardinalCage = 2168;

		// Token: 0x040056AF RID: 22191
		public const short WaterfallWall = 2169;

		// Token: 0x040056B0 RID: 22192
		public const short LavafallWall = 2170;

		// Token: 0x040056B1 RID: 22193
		public const short CrimsonSeeds = 2171;

		// Token: 0x040056B2 RID: 22194
		public const short HeavyWorkBench = 2172;

		// Token: 0x040056B3 RID: 22195
		public const short CopperPlating = 2173;

		// Token: 0x040056B4 RID: 22196
		public const short SnailCage = 2174;

		// Token: 0x040056B5 RID: 22197
		public const short GlowingSnailCage = 2175;

		// Token: 0x040056B6 RID: 22198
		public const short ShroomiteDiggingClaw = 2176;

		// Token: 0x040056B7 RID: 22199
		public const short AmmoBox = 2177;

		// Token: 0x040056B8 RID: 22200
		public const short MonarchButterflyJar = 2178;

		// Token: 0x040056B9 RID: 22201
		public const short PurpleEmperorButterflyJar = 2179;

		// Token: 0x040056BA RID: 22202
		public const short RedAdmiralButterflyJar = 2180;

		// Token: 0x040056BB RID: 22203
		public const short UlyssesButterflyJar = 2181;

		// Token: 0x040056BC RID: 22204
		public const short SulphurButterflyJar = 2182;

		// Token: 0x040056BD RID: 22205
		public const short TreeNymphButterflyJar = 2183;

		// Token: 0x040056BE RID: 22206
		public const short ZebraSwallowtailButterflyJar = 2184;

		// Token: 0x040056BF RID: 22207
		public const short JuliaButterflyJar = 2185;

		// Token: 0x040056C0 RID: 22208
		public const short ScorpionCage = 2186;

		// Token: 0x040056C1 RID: 22209
		public const short BlackScorpionCage = 2187;

		// Token: 0x040056C2 RID: 22210
		public const short VenomStaff = 2188;

		// Token: 0x040056C3 RID: 22211
		public const short SpectreMask = 2189;

		// Token: 0x040056C4 RID: 22212
		public const short FrogCage = 2190;

		// Token: 0x040056C5 RID: 22213
		public const short MouseCage = 2191;

		// Token: 0x040056C6 RID: 22214
		public const short BoneWelder = 2192;

		// Token: 0x040056C7 RID: 22215
		public const short FleshCloningVaat = 2193;

		// Token: 0x040056C8 RID: 22216
		public const short GlassKiln = 2194;

		// Token: 0x040056C9 RID: 22217
		public const short LihzahrdFurnace = 2195;

		// Token: 0x040056CA RID: 22218
		public const short LivingLoom = 2196;

		// Token: 0x040056CB RID: 22219
		public const short SkyMill = 2197;

		// Token: 0x040056CC RID: 22220
		public const short IceMachine = 2198;

		// Token: 0x040056CD RID: 22221
		public const short BeetleHelmet = 2199;

		// Token: 0x040056CE RID: 22222
		public const short BeetleScaleMail = 2200;

		// Token: 0x040056CF RID: 22223
		public const short BeetleShell = 2201;

		// Token: 0x040056D0 RID: 22224
		public const short BeetleLeggings = 2202;

		// Token: 0x040056D1 RID: 22225
		public const short SteampunkBoiler = 2203;

		// Token: 0x040056D2 RID: 22226
		public const short HoneyDispenser = 2204;

		// Token: 0x040056D3 RID: 22227
		public const short Penguin = 2205;

		// Token: 0x040056D4 RID: 22228
		public const short PenguinCage = 2206;

		// Token: 0x040056D5 RID: 22229
		public const short WormCage = 2207;

		// Token: 0x040056D6 RID: 22230
		public const short Terrarium = 2208;

		// Token: 0x040056D7 RID: 22231
		public const short SuperManaPotion = 2209;

		// Token: 0x040056D8 RID: 22232
		public const short EbonwoodFence = 2210;

		// Token: 0x040056D9 RID: 22233
		public const short RichMahoganyFence = 2211;

		// Token: 0x040056DA RID: 22234
		public const short PearlwoodFence = 2212;

		// Token: 0x040056DB RID: 22235
		public const short ShadewoodFence = 2213;

		// Token: 0x040056DC RID: 22236
		public const short BrickLayer = 2214;

		// Token: 0x040056DD RID: 22237
		public const short ExtendoGrip = 2215;

		// Token: 0x040056DE RID: 22238
		public const short PaintSprayer = 2216;

		// Token: 0x040056DF RID: 22239
		public const short PortableCementMixer = 2217;

		// Token: 0x040056E0 RID: 22240
		public const short BeetleHusk = 2218;

		// Token: 0x040056E1 RID: 22241
		public const short CelestialMagnet = 2219;

		// Token: 0x040056E2 RID: 22242
		public const short CelestialEmblem = 2220;

		// Token: 0x040056E3 RID: 22243
		public const short CelestialCuffs = 2221;

		// Token: 0x040056E4 RID: 22244
		public const short PeddlersHat = 2222;

		// Token: 0x040056E5 RID: 22245
		public const short PulseBow = 2223;

		// Token: 0x040056E6 RID: 22246
		public const short DynastyChandelier = 2224;

		// Token: 0x040056E7 RID: 22247
		public const short DynastyLamp = 2225;

		// Token: 0x040056E8 RID: 22248
		public const short DynastyLantern = 2226;

		// Token: 0x040056E9 RID: 22249
		public const short DynastyCandelabra = 2227;

		// Token: 0x040056EA RID: 22250
		public const short DynastyChair = 2228;

		// Token: 0x040056EB RID: 22251
		public const short DynastyWorkBench = 2229;

		// Token: 0x040056EC RID: 22252
		public const short DynastyChest = 2230;

		// Token: 0x040056ED RID: 22253
		public const short DynastyBed = 2231;

		// Token: 0x040056EE RID: 22254
		public const short DynastyBathtub = 2232;

		// Token: 0x040056EF RID: 22255
		public const short DynastyBookcase = 2233;

		// Token: 0x040056F0 RID: 22256
		public const short DynastyCup = 2234;

		// Token: 0x040056F1 RID: 22257
		public const short DynastyBowl = 2235;

		// Token: 0x040056F2 RID: 22258
		public const short DynastyCandle = 2236;

		// Token: 0x040056F3 RID: 22259
		public const short DynastyClock = 2237;

		// Token: 0x040056F4 RID: 22260
		public const short GoldenClock = 2238;

		// Token: 0x040056F5 RID: 22261
		public const short GlassClock = 2239;

		// Token: 0x040056F6 RID: 22262
		public const short HoneyClock = 2240;

		// Token: 0x040056F7 RID: 22263
		public const short SteampunkClock = 2241;

		// Token: 0x040056F8 RID: 22264
		public const short FancyDishes = 2242;

		// Token: 0x040056F9 RID: 22265
		public const short GlassBowl = 2243;

		// Token: 0x040056FA RID: 22266
		public const short WineGlass = 2244;

		// Token: 0x040056FB RID: 22267
		public const short LivingWoodPiano = 2245;

		// Token: 0x040056FC RID: 22268
		public const short FleshPiano = 2246;

		// Token: 0x040056FD RID: 22269
		public const short FrozenPiano = 2247;

		// Token: 0x040056FE RID: 22270
		public const short FrozenTable = 2248;

		// Token: 0x040056FF RID: 22271
		public const short HoneyChest = 2249;

		// Token: 0x04005700 RID: 22272
		public const short SteampunkChest = 2250;

		// Token: 0x04005701 RID: 22273
		public const short HoneyWorkBench = 2251;

		// Token: 0x04005702 RID: 22274
		public const short FrozenWorkBench = 2252;

		// Token: 0x04005703 RID: 22275
		public const short SteampunkWorkBench = 2253;

		// Token: 0x04005704 RID: 22276
		public const short GlassPiano = 2254;

		// Token: 0x04005705 RID: 22277
		public const short HoneyPiano = 2255;

		// Token: 0x04005706 RID: 22278
		public const short SteampunkPiano = 2256;

		// Token: 0x04005707 RID: 22279
		public const short HoneyCup = 2257;

		// Token: 0x04005708 RID: 22280
		public const short SteampunkCup = 2258;

		// Token: 0x04005709 RID: 22281
		public const short DynastyTable = 2259;

		// Token: 0x0400570A RID: 22282
		public const short DynastyWood = 2260;

		// Token: 0x0400570B RID: 22283
		public const short RedDynastyShingles = 2261;

		// Token: 0x0400570C RID: 22284
		public const short BlueDynastyShingles = 2262;

		// Token: 0x0400570D RID: 22285
		public const short WhiteDynastyWall = 2263;

		// Token: 0x0400570E RID: 22286
		public const short BlueDynastyWall = 2264;

		// Token: 0x0400570F RID: 22287
		public const short DynastyDoor = 2265;

		// Token: 0x04005710 RID: 22288
		public const short Sake = 2266;

		// Token: 0x04005711 RID: 22289
		public const short PadThai = 2267;

		// Token: 0x04005712 RID: 22290
		public const short Pho = 2268;

		// Token: 0x04005713 RID: 22291
		public const short Revolver = 2269;

		// Token: 0x04005714 RID: 22292
		public const short Gatligator = 2270;

		// Token: 0x04005715 RID: 22293
		public const short ArcaneRuneWall = 2271;

		// Token: 0x04005716 RID: 22294
		public const short WaterGun = 2272;

		// Token: 0x04005717 RID: 22295
		public const short Katana = 2273;

		// Token: 0x04005718 RID: 22296
		public const short UltrabrightTorch = 2274;

		// Token: 0x04005719 RID: 22297
		public const short MagicHat = 2275;

		// Token: 0x0400571A RID: 22298
		public const short DiamondRing = 2276;

		// Token: 0x0400571B RID: 22299
		public const short Gi = 2277;

		// Token: 0x0400571C RID: 22300
		public const short Kimono = 2278;

		// Token: 0x0400571D RID: 22301
		public const short GypsyRobe = 2279;

		// Token: 0x0400571E RID: 22302
		public const short BeetleWings = 2280;

		// Token: 0x0400571F RID: 22303
		public const short TigerSkin = 2281;

		// Token: 0x04005720 RID: 22304
		public const short LeopardSkin = 2282;

		// Token: 0x04005721 RID: 22305
		public const short ZebraSkin = 2283;

		// Token: 0x04005722 RID: 22306
		public const short CrimsonCloak = 2284;

		// Token: 0x04005723 RID: 22307
		public const short MysteriousCape = 2285;

		// Token: 0x04005724 RID: 22308
		public const short RedCape = 2286;

		// Token: 0x04005725 RID: 22309
		public const short WinterCape = 2287;

		// Token: 0x04005726 RID: 22310
		public const short FrozenChair = 2288;

		// Token: 0x04005727 RID: 22311
		public const short WoodFishingPole = 2289;

		// Token: 0x04005728 RID: 22312
		public const short Bass = 2290;

		// Token: 0x04005729 RID: 22313
		public const short ReinforcedFishingPole = 2291;

		// Token: 0x0400572A RID: 22314
		public const short FiberglassFishingPole = 2292;

		// Token: 0x0400572B RID: 22315
		public const short FisherofSouls = 2293;

		// Token: 0x0400572C RID: 22316
		public const short GoldenFishingRod = 2294;

		// Token: 0x0400572D RID: 22317
		public const short MechanicsRod = 2295;

		// Token: 0x0400572E RID: 22318
		public const short SittingDucksFishingRod = 2296;

		// Token: 0x0400572F RID: 22319
		public const short Trout = 2297;

		// Token: 0x04005730 RID: 22320
		public const short Salmon = 2298;

		// Token: 0x04005731 RID: 22321
		public const short AtlanticCod = 2299;

		// Token: 0x04005732 RID: 22322
		public const short Tuna = 2300;

		// Token: 0x04005733 RID: 22323
		public const short RedSnapper = 2301;

		// Token: 0x04005734 RID: 22324
		public const short NeonTetra = 2302;

		// Token: 0x04005735 RID: 22325
		public const short ArmoredCavefish = 2303;

		// Token: 0x04005736 RID: 22326
		public const short Damselfish = 2304;

		// Token: 0x04005737 RID: 22327
		public const short CrimsonTigerfish = 2305;

		// Token: 0x04005738 RID: 22328
		public const short FrostMinnow = 2306;

		// Token: 0x04005739 RID: 22329
		public const short PrincessFish = 2307;

		// Token: 0x0400573A RID: 22330
		public const short GoldenCarp = 2308;

		// Token: 0x0400573B RID: 22331
		public const short SpecularFish = 2309;

		// Token: 0x0400573C RID: 22332
		public const short Prismite = 2310;

		// Token: 0x0400573D RID: 22333
		public const short VariegatedLardfish = 2311;

		// Token: 0x0400573E RID: 22334
		public const short FlarefinKoi = 2312;

		// Token: 0x0400573F RID: 22335
		public const short DoubleCod = 2313;

		// Token: 0x04005740 RID: 22336
		public const short Honeyfin = 2314;

		// Token: 0x04005741 RID: 22337
		public const short Obsidifish = 2315;

		// Token: 0x04005742 RID: 22338
		public const short Shrimp = 2316;

		// Token: 0x04005743 RID: 22339
		public const short ChaosFish = 2317;

		// Token: 0x04005744 RID: 22340
		public const short Ebonkoi = 2318;

		// Token: 0x04005745 RID: 22341
		public const short Hemopiranha = 2319;

		// Token: 0x04005746 RID: 22342
		public const short Rockfish = 2320;

		// Token: 0x04005747 RID: 22343
		public const short Stinkfish = 2321;

		// Token: 0x04005748 RID: 22344
		public const short MiningPotion = 2322;

		// Token: 0x04005749 RID: 22345
		public const short HeartreachPotion = 2323;

		// Token: 0x0400574A RID: 22346
		public const short CalmingPotion = 2324;

		// Token: 0x0400574B RID: 22347
		public const short BuilderPotion = 2325;

		// Token: 0x0400574C RID: 22348
		public const short TitanPotion = 2326;

		// Token: 0x0400574D RID: 22349
		public const short FlipperPotion = 2327;

		// Token: 0x0400574E RID: 22350
		public const short SummoningPotion = 2328;

		// Token: 0x0400574F RID: 22351
		public const short TrapsightPotion = 2329;

		// Token: 0x04005750 RID: 22352
		public const short PurpleClubberfish = 2330;

		// Token: 0x04005751 RID: 22353
		public const short ObsidianSwordfish = 2331;

		// Token: 0x04005752 RID: 22354
		public const short Swordfish = 2332;

		// Token: 0x04005753 RID: 22355
		public const short IronFence = 2333;

		// Token: 0x04005754 RID: 22356
		public const short WoodenCrate = 2334;

		// Token: 0x04005755 RID: 22357
		public const short IronCrate = 2335;

		// Token: 0x04005756 RID: 22358
		public const short GoldenCrate = 2336;

		// Token: 0x04005757 RID: 22359
		public const short OldShoe = 2337;

		// Token: 0x04005758 RID: 22360
		public const short FishingSeaweed = 2338;

		// Token: 0x04005759 RID: 22361
		public const short TinCan = 2339;

		// Token: 0x0400575A RID: 22362
		public const short MinecartTrack = 2340;

		// Token: 0x0400575B RID: 22363
		public const short ReaverShark = 2341;

		// Token: 0x0400575C RID: 22364
		public const short SawtoothShark = 2342;

		// Token: 0x0400575D RID: 22365
		public const short Minecart = 2343;

		// Token: 0x0400575E RID: 22366
		public const short AmmoReservationPotion = 2344;

		// Token: 0x0400575F RID: 22367
		public const short LifeforcePotion = 2345;

		// Token: 0x04005760 RID: 22368
		public const short EndurancePotion = 2346;

		// Token: 0x04005761 RID: 22369
		public const short RagePotion = 2347;

		// Token: 0x04005762 RID: 22370
		public const short InfernoPotion = 2348;

		// Token: 0x04005763 RID: 22371
		public const short WrathPotion = 2349;

		// Token: 0x04005764 RID: 22372
		public const short RecallPotion = 2350;

		// Token: 0x04005765 RID: 22373
		public const short TeleportationPotion = 2351;

		// Token: 0x04005766 RID: 22374
		public const short LovePotion = 2352;

		// Token: 0x04005767 RID: 22375
		public const short StinkPotion = 2353;

		// Token: 0x04005768 RID: 22376
		public const short FishingPotion = 2354;

		// Token: 0x04005769 RID: 22377
		public const short SonarPotion = 2355;

		// Token: 0x0400576A RID: 22378
		public const short CratePotion = 2356;

		// Token: 0x0400576B RID: 22379
		public const short ShiverthornSeeds = 2357;

		// Token: 0x0400576C RID: 22380
		public const short Shiverthorn = 2358;

		// Token: 0x0400576D RID: 22381
		public const short WarmthPotion = 2359;

		// Token: 0x0400576E RID: 22382
		public const short FishHook = 2360;

		// Token: 0x0400576F RID: 22383
		public const short BeeHeadgear = 2361;

		// Token: 0x04005770 RID: 22384
		public const short BeeBreastplate = 2362;

		// Token: 0x04005771 RID: 22385
		public const short BeeGreaves = 2363;

		// Token: 0x04005772 RID: 22386
		public const short HornetStaff = 2364;

		// Token: 0x04005773 RID: 22387
		public const short ImpStaff = 2365;

		// Token: 0x04005774 RID: 22388
		public const short QueenSpiderStaff = 2366;

		// Token: 0x04005775 RID: 22389
		public const short AnglerHat = 2367;

		// Token: 0x04005776 RID: 22390
		public const short AnglerVest = 2368;

		// Token: 0x04005777 RID: 22391
		public const short AnglerPants = 2369;

		// Token: 0x04005778 RID: 22392
		public const short SpiderMask = 2370;

		// Token: 0x04005779 RID: 22393
		public const short SpiderBreastplate = 2371;

		// Token: 0x0400577A RID: 22394
		public const short SpiderGreaves = 2372;

		// Token: 0x0400577B RID: 22395
		public const short HighTestFishingLine = 2373;

		// Token: 0x0400577C RID: 22396
		public const short AnglerEarring = 2374;

		// Token: 0x0400577D RID: 22397
		public const short TackleBox = 2375;

		// Token: 0x0400577E RID: 22398
		public const short BlueDungeonPiano = 2376;

		// Token: 0x0400577F RID: 22399
		public const short GreenDungeonPiano = 2377;

		// Token: 0x04005780 RID: 22400
		public const short PinkDungeonPiano = 2378;

		// Token: 0x04005781 RID: 22401
		public const short GoldenPiano = 2379;

		// Token: 0x04005782 RID: 22402
		public const short ObsidianPiano = 2380;

		// Token: 0x04005783 RID: 22403
		public const short BonePiano = 2381;

		// Token: 0x04005784 RID: 22404
		public const short CactusPiano = 2382;

		// Token: 0x04005785 RID: 22405
		public const short SpookyPiano = 2383;

		// Token: 0x04005786 RID: 22406
		public const short SkywarePiano = 2384;

		// Token: 0x04005787 RID: 22407
		public const short LihzahrdPiano = 2385;

		// Token: 0x04005788 RID: 22408
		public const short BlueDungeonDresser = 2386;

		// Token: 0x04005789 RID: 22409
		public const short GreenDungeonDresser = 2387;

		// Token: 0x0400578A RID: 22410
		public const short PinkDungeonDresser = 2388;

		// Token: 0x0400578B RID: 22411
		public const short GoldenDresser = 2389;

		// Token: 0x0400578C RID: 22412
		public const short ObsidianDresser = 2390;

		// Token: 0x0400578D RID: 22413
		public const short BoneDresser = 2391;

		// Token: 0x0400578E RID: 22414
		public const short CactusDresser = 2392;

		// Token: 0x0400578F RID: 22415
		public const short SpookyDresser = 2393;

		// Token: 0x04005790 RID: 22416
		public const short SkywareDresser = 2394;

		// Token: 0x04005791 RID: 22417
		public const short HoneyDresser = 2395;

		// Token: 0x04005792 RID: 22418
		public const short LihzahrdDresser = 2396;

		// Token: 0x04005793 RID: 22419
		public const short Sofa = 2397;

		// Token: 0x04005794 RID: 22420
		public const short EbonwoodSofa = 2398;

		// Token: 0x04005795 RID: 22421
		public const short RichMahoganySofa = 2399;

		// Token: 0x04005796 RID: 22422
		public const short PearlwoodSofa = 2400;

		// Token: 0x04005797 RID: 22423
		public const short ShadewoodSofa = 2401;

		// Token: 0x04005798 RID: 22424
		public const short BlueDungeonSofa = 2402;

		// Token: 0x04005799 RID: 22425
		public const short GreenDungeonSofa = 2403;

		// Token: 0x0400579A RID: 22426
		public const short PinkDungeonSofa = 2404;

		// Token: 0x0400579B RID: 22427
		public const short GoldenSofa = 2405;

		// Token: 0x0400579C RID: 22428
		public const short ObsidianSofa = 2406;

		// Token: 0x0400579D RID: 22429
		public const short BoneSofa = 2407;

		// Token: 0x0400579E RID: 22430
		public const short CactusSofa = 2408;

		// Token: 0x0400579F RID: 22431
		public const short SpookySofa = 2409;

		// Token: 0x040057A0 RID: 22432
		public const short SkywareSofa = 2410;

		// Token: 0x040057A1 RID: 22433
		public const short HoneySofa = 2411;

		// Token: 0x040057A2 RID: 22434
		public const short SteampunkSofa = 2412;

		// Token: 0x040057A3 RID: 22435
		public const short MushroomSofa = 2413;

		// Token: 0x040057A4 RID: 22436
		public const short GlassSofa = 2414;

		// Token: 0x040057A5 RID: 22437
		public const short PumpkinSofa = 2415;

		// Token: 0x040057A6 RID: 22438
		public const short LihzahrdSofa = 2416;

		// Token: 0x040057A7 RID: 22439
		public const short SeashellHairpin = 2417;

		// Token: 0x040057A8 RID: 22440
		public const short MermaidAdornment = 2418;

		// Token: 0x040057A9 RID: 22441
		public const short MermaidTail = 2419;

		// Token: 0x040057AA RID: 22442
		public const short ZephyrFish = 2420;

		// Token: 0x040057AB RID: 22443
		public const short Fleshcatcher = 2421;

		// Token: 0x040057AC RID: 22444
		public const short HotlineFishingHook = 2422;

		// Token: 0x040057AD RID: 22445
		public const short FrogLeg = 2423;

		// Token: 0x040057AE RID: 22446
		public const short Anchor = 2424;

		// Token: 0x040057AF RID: 22447
		public const short CookedFish = 2425;

		// Token: 0x040057B0 RID: 22448
		public const short CookedShrimp = 2426;

		// Token: 0x040057B1 RID: 22449
		public const short Sashimi = 2427;

		// Token: 0x040057B2 RID: 22450
		public const short FuzzyCarrot = 2428;

		// Token: 0x040057B3 RID: 22451
		public const short ScalyTruffle = 2429;

		// Token: 0x040057B4 RID: 22452
		public const short SlimySaddle = 2430;

		// Token: 0x040057B5 RID: 22453
		public const short BeeWax = 2431;

		// Token: 0x040057B6 RID: 22454
		public const short CopperPlatingWall = 2432;

		// Token: 0x040057B7 RID: 22455
		public const short StoneSlabWall = 2433;

		// Token: 0x040057B8 RID: 22456
		public const short Sail = 2434;

		// Token: 0x040057B9 RID: 22457
		public const short CoralstoneBlock = 2435;

		// Token: 0x040057BA RID: 22458
		public const short BlueJellyfish = 2436;

		// Token: 0x040057BB RID: 22459
		public const short GreenJellyfish = 2437;

		// Token: 0x040057BC RID: 22460
		public const short PinkJellyfish = 2438;

		// Token: 0x040057BD RID: 22461
		public const short BlueJellyfishJar = 2439;

		// Token: 0x040057BE RID: 22462
		public const short GreenJellyfishJar = 2440;

		// Token: 0x040057BF RID: 22463
		public const short PinkJellyfishJar = 2441;

		// Token: 0x040057C0 RID: 22464
		public const short LifePreserver = 2442;

		// Token: 0x040057C1 RID: 22465
		public const short ShipsWheel = 2443;

		// Token: 0x040057C2 RID: 22466
		public const short CompassRose = 2444;

		// Token: 0x040057C3 RID: 22467
		public const short WallAnchor = 2445;

		// Token: 0x040057C4 RID: 22468
		public const short GoldfishTrophy = 2446;

		// Token: 0x040057C5 RID: 22469
		public const short BunnyfishTrophy = 2447;

		// Token: 0x040057C6 RID: 22470
		public const short SwordfishTrophy = 2448;

		// Token: 0x040057C7 RID: 22471
		public const short SharkteethTrophy = 2449;

		// Token: 0x040057C8 RID: 22472
		public const short Batfish = 2450;

		// Token: 0x040057C9 RID: 22473
		public const short BumblebeeTuna = 2451;

		// Token: 0x040057CA RID: 22474
		public const short Catfish = 2452;

		// Token: 0x040057CB RID: 22475
		public const short Cloudfish = 2453;

		// Token: 0x040057CC RID: 22476
		public const short Cursedfish = 2454;

		// Token: 0x040057CD RID: 22477
		public const short Dirtfish = 2455;

		// Token: 0x040057CE RID: 22478
		public const short DynamiteFish = 2456;

		// Token: 0x040057CF RID: 22479
		public const short EaterofPlankton = 2457;

		// Token: 0x040057D0 RID: 22480
		public const short FallenStarfish = 2458;

		// Token: 0x040057D1 RID: 22481
		public const short TheFishofCthulu = 2459;

		// Token: 0x040057D2 RID: 22482
		public const short Fishotron = 2460;

		// Token: 0x040057D3 RID: 22483
		public const short Harpyfish = 2461;

		// Token: 0x040057D4 RID: 22484
		public const short Hungerfish = 2462;

		// Token: 0x040057D5 RID: 22485
		public const short Ichorfish = 2463;

		// Token: 0x040057D6 RID: 22486
		public const short Jewelfish = 2464;

		// Token: 0x040057D7 RID: 22487
		public const short MirageFish = 2465;

		// Token: 0x040057D8 RID: 22488
		public const short MutantFlinxfin = 2466;

		// Token: 0x040057D9 RID: 22489
		public const short Pengfish = 2467;

		// Token: 0x040057DA RID: 22490
		public const short Pixiefish = 2468;

		// Token: 0x040057DB RID: 22491
		public const short Spiderfish = 2469;

		// Token: 0x040057DC RID: 22492
		public const short TundraTrout = 2470;

		// Token: 0x040057DD RID: 22493
		public const short UnicornFish = 2471;

		// Token: 0x040057DE RID: 22494
		public const short GuideVoodooFish = 2472;

		// Token: 0x040057DF RID: 22495
		public const short Wyverntail = 2473;

		// Token: 0x040057E0 RID: 22496
		public const short ZombieFish = 2474;

		// Token: 0x040057E1 RID: 22497
		public const short AmanitaFungifin = 2475;

		// Token: 0x040057E2 RID: 22498
		public const short Angelfish = 2476;

		// Token: 0x040057E3 RID: 22499
		public const short BloodyManowar = 2477;

		// Token: 0x040057E4 RID: 22500
		public const short Bonefish = 2478;

		// Token: 0x040057E5 RID: 22501
		public const short Bunnyfish = 2479;

		// Token: 0x040057E6 RID: 22502
		public const short CapnTunabeard = 2480;

		// Token: 0x040057E7 RID: 22503
		public const short Clownfish = 2481;

		// Token: 0x040057E8 RID: 22504
		public const short DemonicHellfish = 2482;

		// Token: 0x040057E9 RID: 22505
		public const short Derpfish = 2483;

		// Token: 0x040057EA RID: 22506
		public const short Fishron = 2484;

		// Token: 0x040057EB RID: 22507
		public const short InfectedScabbardfish = 2485;

		// Token: 0x040057EC RID: 22508
		public const short Mudfish = 2486;

		// Token: 0x040057ED RID: 22509
		public const short Slimefish = 2487;

		// Token: 0x040057EE RID: 22510
		public const short TropicalBarracuda = 2488;

		// Token: 0x040057EF RID: 22511
		public const short KingSlimeTrophy = 2489;

		// Token: 0x040057F0 RID: 22512
		public const short ShipInABottle = 2490;

		// Token: 0x040057F1 RID: 22513
		public const short HardySaddle = 2491;

		// Token: 0x040057F2 RID: 22514
		public const short PressureTrack = 2492;

		// Token: 0x040057F3 RID: 22515
		public const short KingSlimeMask = 2493;

		// Token: 0x040057F4 RID: 22516
		public const short FinWings = 2494;

		// Token: 0x040057F5 RID: 22517
		public const short TreasureMap = 2495;

		// Token: 0x040057F6 RID: 22518
		public const short SeaweedPlanter = 2496;

		// Token: 0x040057F7 RID: 22519
		public const short PillaginMePixels = 2497;

		// Token: 0x040057F8 RID: 22520
		public const short FishCostumeMask = 2498;

		// Token: 0x040057F9 RID: 22521
		public const short FishCostumeShirt = 2499;

		// Token: 0x040057FA RID: 22522
		public const short FishCostumeFinskirt = 2500;

		// Token: 0x040057FB RID: 22523
		public const short GingerBeard = 2501;

		// Token: 0x040057FC RID: 22524
		public const short HoneyedGoggles = 2502;

		// Token: 0x040057FD RID: 22525
		public const short BorealWood = 2503;

		// Token: 0x040057FE RID: 22526
		public const short PalmWood = 2504;

		// Token: 0x040057FF RID: 22527
		public const short BorealWoodWall = 2505;

		// Token: 0x04005800 RID: 22528
		public const short PalmWoodWall = 2506;

		// Token: 0x04005801 RID: 22529
		public const short BorealWoodFence = 2507;

		// Token: 0x04005802 RID: 22530
		public const short PalmWoodFence = 2508;

		// Token: 0x04005803 RID: 22531
		public const short BorealWoodHelmet = 2509;

		// Token: 0x04005804 RID: 22532
		public const short BorealWoodBreastplate = 2510;

		// Token: 0x04005805 RID: 22533
		public const short BorealWoodGreaves = 2511;

		// Token: 0x04005806 RID: 22534
		public const short PalmWoodHelmet = 2512;

		// Token: 0x04005807 RID: 22535
		public const short PalmWoodBreastplate = 2513;

		// Token: 0x04005808 RID: 22536
		public const short PalmWoodGreaves = 2514;

		// Token: 0x04005809 RID: 22537
		public const short PalmWoodBow = 2515;

		// Token: 0x0400580A RID: 22538
		public const short PalmWoodHammer = 2516;

		// Token: 0x0400580B RID: 22539
		public const short PalmWoodSword = 2517;

		// Token: 0x0400580C RID: 22540
		public const short PalmWoodPlatform = 2518;

		// Token: 0x0400580D RID: 22541
		public const short PalmWoodBathtub = 2519;

		// Token: 0x0400580E RID: 22542
		public const short PalmWoodBed = 2520;

		// Token: 0x0400580F RID: 22543
		public const short PalmWoodBench = 2521;

		// Token: 0x04005810 RID: 22544
		public const short PalmWoodCandelabra = 2522;

		// Token: 0x04005811 RID: 22545
		public const short PalmWoodCandle = 2523;

		// Token: 0x04005812 RID: 22546
		public const short PalmWoodChair = 2524;

		// Token: 0x04005813 RID: 22547
		public const short PalmWoodChandelier = 2525;

		// Token: 0x04005814 RID: 22548
		public const short PalmWoodChest = 2526;

		// Token: 0x04005815 RID: 22549
		public const short PalmWoodSofa = 2527;

		// Token: 0x04005816 RID: 22550
		public const short PalmWoodDoor = 2528;

		// Token: 0x04005817 RID: 22551
		public const short PalmWoodDresser = 2529;

		// Token: 0x04005818 RID: 22552
		public const short PalmWoodLantern = 2530;

		// Token: 0x04005819 RID: 22553
		public const short PalmWoodPiano = 2531;

		// Token: 0x0400581A RID: 22554
		public const short PalmWoodTable = 2532;

		// Token: 0x0400581B RID: 22555
		public const short PalmWoodLamp = 2533;

		// Token: 0x0400581C RID: 22556
		public const short PalmWoodWorkBench = 2534;

		// Token: 0x0400581D RID: 22557
		public const short OpticStaff = 2535;

		// Token: 0x0400581E RID: 22558
		public const short PalmWoodBookcase = 2536;

		// Token: 0x0400581F RID: 22559
		public const short MushroomBathtub = 2537;

		// Token: 0x04005820 RID: 22560
		public const short MushroomBed = 2538;

		// Token: 0x04005821 RID: 22561
		public const short MushroomBench = 2539;

		// Token: 0x04005822 RID: 22562
		public const short MushroomBookcase = 2540;

		// Token: 0x04005823 RID: 22563
		public const short MushroomCandelabra = 2541;

		// Token: 0x04005824 RID: 22564
		public const short MushroomCandle = 2542;

		// Token: 0x04005825 RID: 22565
		public const short MushroomChandelier = 2543;

		// Token: 0x04005826 RID: 22566
		public const short MushroomChest = 2544;

		// Token: 0x04005827 RID: 22567
		public const short MushroomDresser = 2545;

		// Token: 0x04005828 RID: 22568
		public const short MushroomLantern = 2546;

		// Token: 0x04005829 RID: 22569
		public const short MushroomLamp = 2547;

		// Token: 0x0400582A RID: 22570
		public const short MushroomPiano = 2548;

		// Token: 0x0400582B RID: 22571
		public const short MushroomPlatform = 2549;

		// Token: 0x0400582C RID: 22572
		public const short MushroomTable = 2550;

		// Token: 0x0400582D RID: 22573
		public const short SpiderStaff = 2551;

		// Token: 0x0400582E RID: 22574
		public const short BorealWoodBathtub = 2552;

		// Token: 0x0400582F RID: 22575
		public const short BorealWoodBed = 2553;

		// Token: 0x04005830 RID: 22576
		public const short BorealWoodBookcase = 2554;

		// Token: 0x04005831 RID: 22577
		public const short BorealWoodCandelabra = 2555;

		// Token: 0x04005832 RID: 22578
		public const short BorealWoodCandle = 2556;

		// Token: 0x04005833 RID: 22579
		public const short BorealWoodChair = 2557;

		// Token: 0x04005834 RID: 22580
		public const short BorealWoodChandelier = 2558;

		// Token: 0x04005835 RID: 22581
		public const short BorealWoodChest = 2559;

		// Token: 0x04005836 RID: 22582
		public const short BorealWoodClock = 2560;

		// Token: 0x04005837 RID: 22583
		public const short BorealWoodDoor = 2561;

		// Token: 0x04005838 RID: 22584
		public const short BorealWoodDresser = 2562;

		// Token: 0x04005839 RID: 22585
		public const short BorealWoodLamp = 2563;

		// Token: 0x0400583A RID: 22586
		public const short BorealWoodLantern = 2564;

		// Token: 0x0400583B RID: 22587
		public const short BorealWoodPiano = 2565;

		// Token: 0x0400583C RID: 22588
		public const short BorealWoodPlatform = 2566;

		// Token: 0x0400583D RID: 22589
		public const short SlimeBathtub = 2567;

		// Token: 0x0400583E RID: 22590
		public const short SlimeBed = 2568;

		// Token: 0x0400583F RID: 22591
		public const short SlimeBookcase = 2569;

		// Token: 0x04005840 RID: 22592
		public const short SlimeCandelabra = 2570;

		// Token: 0x04005841 RID: 22593
		public const short SlimeCandle = 2571;

		// Token: 0x04005842 RID: 22594
		public const short SlimeChair = 2572;

		// Token: 0x04005843 RID: 22595
		public const short SlimeChandelier = 2573;

		// Token: 0x04005844 RID: 22596
		public const short SlimeChest = 2574;

		// Token: 0x04005845 RID: 22597
		public const short SlimeClock = 2575;

		// Token: 0x04005846 RID: 22598
		public const short SlimeDoor = 2576;

		// Token: 0x04005847 RID: 22599
		public const short SlimeDresser = 2577;

		// Token: 0x04005848 RID: 22600
		public const short SlimeLamp = 2578;

		// Token: 0x04005849 RID: 22601
		public const short SlimeLantern = 2579;

		// Token: 0x0400584A RID: 22602
		public const short SlimePiano = 2580;

		// Token: 0x0400584B RID: 22603
		public const short SlimePlatform = 2581;

		// Token: 0x0400584C RID: 22604
		public const short SlimeSofa = 2582;

		// Token: 0x0400584D RID: 22605
		public const short SlimeTable = 2583;

		// Token: 0x0400584E RID: 22606
		public const short PirateStaff = 2584;

		// Token: 0x0400584F RID: 22607
		public const short SlimeHook = 2585;

		// Token: 0x04005850 RID: 22608
		public const short StickyGrenade = 2586;

		// Token: 0x04005851 RID: 22609
		public const short TartarSauce = 2587;

		// Token: 0x04005852 RID: 22610
		public const short DukeFishronMask = 2588;

		// Token: 0x04005853 RID: 22611
		public const short DukeFishronTrophy = 2589;

		// Token: 0x04005854 RID: 22612
		public const short MolotovCocktail = 2590;

		// Token: 0x04005855 RID: 22613
		public const short BoneClock = 2591;

		// Token: 0x04005856 RID: 22614
		public const short CactusClock = 2592;

		// Token: 0x04005857 RID: 22615
		public const short EbonwoodClock = 2593;

		// Token: 0x04005858 RID: 22616
		public const short FrozenClock = 2594;

		// Token: 0x04005859 RID: 22617
		public const short LihzahrdClock = 2595;

		// Token: 0x0400585A RID: 22618
		public const short LivingWoodClock = 2596;

		// Token: 0x0400585B RID: 22619
		public const short RichMahoganyClock = 2597;

		// Token: 0x0400585C RID: 22620
		public const short FleshClock = 2598;

		// Token: 0x0400585D RID: 22621
		public const short MushroomClock = 2599;

		// Token: 0x0400585E RID: 22622
		public const short ObsidianClock = 2600;

		// Token: 0x0400585F RID: 22623
		public const short PalmWoodClock = 2601;

		// Token: 0x04005860 RID: 22624
		public const short PearlwoodClock = 2602;

		// Token: 0x04005861 RID: 22625
		public const short PumpkinClock = 2603;

		// Token: 0x04005862 RID: 22626
		public const short ShadewoodClock = 2604;

		// Token: 0x04005863 RID: 22627
		public const short SpookyClock = 2605;

		// Token: 0x04005864 RID: 22628
		public const short SkywareClock = 2606;

		// Token: 0x04005865 RID: 22629
		public const short SpiderFang = 2607;

		// Token: 0x04005866 RID: 22630
		public const short FalconBlade = 2608;

		// Token: 0x04005867 RID: 22631
		public const short FishronWings = 2609;

		// Token: 0x04005868 RID: 22632
		public const short SlimeGun = 2610;

		// Token: 0x04005869 RID: 22633
		public const short Flairon = 2611;

		// Token: 0x0400586A RID: 22634
		public const short GreenDungeonChest = 2612;

		// Token: 0x0400586B RID: 22635
		public const short PinkDungeonChest = 2613;

		// Token: 0x0400586C RID: 22636
		public const short BlueDungeonChest = 2614;

		// Token: 0x0400586D RID: 22637
		public const short BoneChest = 2615;

		// Token: 0x0400586E RID: 22638
		public const short CactusChest = 2616;

		// Token: 0x0400586F RID: 22639
		public const short FleshChest = 2617;

		// Token: 0x04005870 RID: 22640
		public const short ObsidianChest = 2618;

		// Token: 0x04005871 RID: 22641
		public const short PumpkinChest = 2619;

		// Token: 0x04005872 RID: 22642
		public const short SpookyChest = 2620;

		// Token: 0x04005873 RID: 22643
		public const short TempestStaff = 2621;

		// Token: 0x04005874 RID: 22644
		public const short RazorbladeTyphoon = 2622;

		// Token: 0x04005875 RID: 22645
		public const short BubbleGun = 2623;

		// Token: 0x04005876 RID: 22646
		public const short Tsunami = 2624;

		// Token: 0x04005877 RID: 22647
		public const short Seashell = 2625;

		// Token: 0x04005878 RID: 22648
		public const short Starfish = 2626;

		// Token: 0x04005879 RID: 22649
		public const short SteampunkPlatform = 2627;

		// Token: 0x0400587A RID: 22650
		public const short SkywarePlatform = 2628;

		// Token: 0x0400587B RID: 22651
		public const short LivingWoodPlatform = 2629;

		// Token: 0x0400587C RID: 22652
		public const short HoneyPlatform = 2630;

		// Token: 0x0400587D RID: 22653
		public const short SkywareWorkbench = 2631;

		// Token: 0x0400587E RID: 22654
		public const short GlassWorkBench = 2632;

		// Token: 0x0400587F RID: 22655
		public const short LivingWoodWorkBench = 2633;

		// Token: 0x04005880 RID: 22656
		public const short FleshSofa = 2634;

		// Token: 0x04005881 RID: 22657
		public const short FrozenSofa = 2635;

		// Token: 0x04005882 RID: 22658
		public const short LivingWoodSofa = 2636;

		// Token: 0x04005883 RID: 22659
		public const short PumpkinDresser = 2637;

		// Token: 0x04005884 RID: 22660
		public const short SteampunkDresser = 2638;

		// Token: 0x04005885 RID: 22661
		public const short GlassDresser = 2639;

		// Token: 0x04005886 RID: 22662
		public const short FleshDresser = 2640;

		// Token: 0x04005887 RID: 22663
		public const short PumpkinLantern = 2641;

		// Token: 0x04005888 RID: 22664
		public const short ObsidianLantern = 2642;

		// Token: 0x04005889 RID: 22665
		public const short PumpkinLamp = 2643;

		// Token: 0x0400588A RID: 22666
		public const short ObsidianLamp = 2644;

		// Token: 0x0400588B RID: 22667
		public const short BlueDungeonLamp = 2645;

		// Token: 0x0400588C RID: 22668
		public const short GreenDungeonLamp = 2646;

		// Token: 0x0400588D RID: 22669
		public const short PinkDungeonLamp = 2647;

		// Token: 0x0400588E RID: 22670
		public const short HoneyCandle = 2648;

		// Token: 0x0400588F RID: 22671
		public const short SteampunkCandle = 2649;

		// Token: 0x04005890 RID: 22672
		public const short SpookyCandle = 2650;

		// Token: 0x04005891 RID: 22673
		public const short ObsidianCandle = 2651;

		// Token: 0x04005892 RID: 22674
		public const short BlueDungeonChandelier = 2652;

		// Token: 0x04005893 RID: 22675
		public const short GreenDungeonChandelier = 2653;

		// Token: 0x04005894 RID: 22676
		public const short PinkDungeonChandelier = 2654;

		// Token: 0x04005895 RID: 22677
		public const short SteampunkChandelier = 2655;

		// Token: 0x04005896 RID: 22678
		public const short PumpkinChandelier = 2656;

		// Token: 0x04005897 RID: 22679
		public const short ObsidianChandelier = 2657;

		// Token: 0x04005898 RID: 22680
		public const short BlueDungeonBathtub = 2658;

		// Token: 0x04005899 RID: 22681
		public const short GreenDungeonBathtub = 2659;

		// Token: 0x0400589A RID: 22682
		public const short PinkDungeonBathtub = 2660;

		// Token: 0x0400589B RID: 22683
		public const short PumpkinBathtub = 2661;

		// Token: 0x0400589C RID: 22684
		public const short ObsidianBathtub = 2662;

		// Token: 0x0400589D RID: 22685
		public const short GoldenBathtub = 2663;

		// Token: 0x0400589E RID: 22686
		public const short BlueDungeonCandelabra = 2664;

		// Token: 0x0400589F RID: 22687
		public const short GreenDungeonCandelabra = 2665;

		// Token: 0x040058A0 RID: 22688
		public const short PinkDungeonCandelabra = 2666;

		// Token: 0x040058A1 RID: 22689
		public const short ObsidianCandelabra = 2667;

		// Token: 0x040058A2 RID: 22690
		public const short PumpkinCandelabra = 2668;

		// Token: 0x040058A3 RID: 22691
		public const short PumpkinBed = 2669;

		// Token: 0x040058A4 RID: 22692
		public const short PumpkinBookcase = 2670;

		// Token: 0x040058A5 RID: 22693
		public const short PumpkinPiano = 2671;

		// Token: 0x040058A6 RID: 22694
		public const short SharkStatue = 2672;

		// Token: 0x040058A7 RID: 22695
		public const short TruffleWorm = 2673;

		// Token: 0x040058A8 RID: 22696
		public const short ApprenticeBait = 2674;

		// Token: 0x040058A9 RID: 22697
		public const short JourneymanBait = 2675;

		// Token: 0x040058AA RID: 22698
		public const short MasterBait = 2676;

		// Token: 0x040058AB RID: 22699
		public const short AmberGemsparkWall = 2677;

		// Token: 0x040058AC RID: 22700
		public const short AmberGemsparkWallOff = 2678;

		// Token: 0x040058AD RID: 22701
		public const short AmethystGemsparkWall = 2679;

		// Token: 0x040058AE RID: 22702
		public const short AmethystGemsparkWallOff = 2680;

		// Token: 0x040058AF RID: 22703
		public const short DiamondGemsparkWall = 2681;

		// Token: 0x040058B0 RID: 22704
		public const short DiamondGemsparkWallOff = 2682;

		// Token: 0x040058B1 RID: 22705
		public const short EmeraldGemsparkWall = 2683;

		// Token: 0x040058B2 RID: 22706
		public const short EmeraldGemsparkWallOff = 2684;

		// Token: 0x040058B3 RID: 22707
		public const short RubyGemsparkWall = 2685;

		// Token: 0x040058B4 RID: 22708
		public const short RubyGemsparkWallOff = 2686;

		// Token: 0x040058B5 RID: 22709
		public const short SapphireGemsparkWall = 2687;

		// Token: 0x040058B6 RID: 22710
		public const short SapphireGemsparkWallOff = 2688;

		// Token: 0x040058B7 RID: 22711
		public const short TopazGemsparkWall = 2689;

		// Token: 0x040058B8 RID: 22712
		public const short TopazGemsparkWallOff = 2690;

		// Token: 0x040058B9 RID: 22713
		public const short TinPlatingWall = 2691;

		// Token: 0x040058BA RID: 22714
		public const short TinPlating = 2692;

		// Token: 0x040058BB RID: 22715
		public const short WaterfallBlock = 2693;

		// Token: 0x040058BC RID: 22716
		public const short LavafallBlock = 2694;

		// Token: 0x040058BD RID: 22717
		public const short ConfettiBlock = 2695;

		// Token: 0x040058BE RID: 22718
		public const short ConfettiWall = 2696;

		// Token: 0x040058BF RID: 22719
		public const short ConfettiBlockBlack = 2697;

		// Token: 0x040058C0 RID: 22720
		public const short ConfettiWallBlack = 2698;

		// Token: 0x040058C1 RID: 22721
		public const short WeaponRack = 2699;

		// Token: 0x040058C2 RID: 22722
		public const short FireworksBox = 2700;

		// Token: 0x040058C3 RID: 22723
		public const short LivingFireBlock = 2701;

		// Token: 0x040058C4 RID: 22724
		public const short AlphabetStatue0 = 2702;

		// Token: 0x040058C5 RID: 22725
		public const short AlphabetStatue1 = 2703;

		// Token: 0x040058C6 RID: 22726
		public const short AlphabetStatue2 = 2704;

		// Token: 0x040058C7 RID: 22727
		public const short AlphabetStatue3 = 2705;

		// Token: 0x040058C8 RID: 22728
		public const short AlphabetStatue4 = 2706;

		// Token: 0x040058C9 RID: 22729
		public const short AlphabetStatue5 = 2707;

		// Token: 0x040058CA RID: 22730
		public const short AlphabetStatue6 = 2708;

		// Token: 0x040058CB RID: 22731
		public const short AlphabetStatue7 = 2709;

		// Token: 0x040058CC RID: 22732
		public const short AlphabetStatue8 = 2710;

		// Token: 0x040058CD RID: 22733
		public const short AlphabetStatue9 = 2711;

		// Token: 0x040058CE RID: 22734
		public const short AlphabetStatueA = 2712;

		// Token: 0x040058CF RID: 22735
		public const short AlphabetStatueB = 2713;

		// Token: 0x040058D0 RID: 22736
		public const short AlphabetStatueC = 2714;

		// Token: 0x040058D1 RID: 22737
		public const short AlphabetStatueD = 2715;

		// Token: 0x040058D2 RID: 22738
		public const short AlphabetStatueE = 2716;

		// Token: 0x040058D3 RID: 22739
		public const short AlphabetStatueF = 2717;

		// Token: 0x040058D4 RID: 22740
		public const short AlphabetStatueG = 2718;

		// Token: 0x040058D5 RID: 22741
		public const short AlphabetStatueH = 2719;

		// Token: 0x040058D6 RID: 22742
		public const short AlphabetStatueI = 2720;

		// Token: 0x040058D7 RID: 22743
		public const short AlphabetStatueJ = 2721;

		// Token: 0x040058D8 RID: 22744
		public const short AlphabetStatueK = 2722;

		// Token: 0x040058D9 RID: 22745
		public const short AlphabetStatueL = 2723;

		// Token: 0x040058DA RID: 22746
		public const short AlphabetStatueM = 2724;

		// Token: 0x040058DB RID: 22747
		public const short AlphabetStatueN = 2725;

		// Token: 0x040058DC RID: 22748
		public const short AlphabetStatueO = 2726;

		// Token: 0x040058DD RID: 22749
		public const short AlphabetStatueP = 2727;

		// Token: 0x040058DE RID: 22750
		public const short AlphabetStatueQ = 2728;

		// Token: 0x040058DF RID: 22751
		public const short AlphabetStatueR = 2729;

		// Token: 0x040058E0 RID: 22752
		public const short AlphabetStatueS = 2730;

		// Token: 0x040058E1 RID: 22753
		public const short AlphabetStatueT = 2731;

		// Token: 0x040058E2 RID: 22754
		public const short AlphabetStatueU = 2732;

		// Token: 0x040058E3 RID: 22755
		public const short AlphabetStatueV = 2733;

		// Token: 0x040058E4 RID: 22756
		public const short AlphabetStatueW = 2734;

		// Token: 0x040058E5 RID: 22757
		public const short AlphabetStatueX = 2735;

		// Token: 0x040058E6 RID: 22758
		public const short AlphabetStatueY = 2736;

		// Token: 0x040058E7 RID: 22759
		public const short AlphabetStatueZ = 2737;

		// Token: 0x040058E8 RID: 22760
		public const short FireworkFountain = 2738;

		// Token: 0x040058E9 RID: 22761
		public const short BoosterTrack = 2739;

		// Token: 0x040058EA RID: 22762
		public const short Grasshopper = 2740;

		// Token: 0x040058EB RID: 22763
		public const short GrasshopperCage = 2741;

		// Token: 0x040058EC RID: 22764
		public const short MusicBoxUndergroundCrimson = 2742;

		// Token: 0x040058ED RID: 22765
		public const short CactusTable = 2743;

		// Token: 0x040058EE RID: 22766
		public const short CactusPlatform = 2744;

		// Token: 0x040058EF RID: 22767
		public const short BorealWoodSword = 2745;

		// Token: 0x040058F0 RID: 22768
		public const short BorealWoodHammer = 2746;

		// Token: 0x040058F1 RID: 22769
		public const short BorealWoodBow = 2747;

		// Token: 0x040058F2 RID: 22770
		public const short GlassChest = 2748;

		// Token: 0x040058F3 RID: 22771
		public const short XenoStaff = 2749;

		// Token: 0x040058F4 RID: 22772
		public const short MeteorStaff = 2750;

		// Token: 0x040058F5 RID: 22773
		public const short LivingCursedFireBlock = 2751;

		// Token: 0x040058F6 RID: 22774
		public const short LivingDemonFireBlock = 2752;

		// Token: 0x040058F7 RID: 22775
		public const short LivingFrostFireBlock = 2753;

		// Token: 0x040058F8 RID: 22776
		public const short LivingIchorBlock = 2754;

		// Token: 0x040058F9 RID: 22777
		public const short LivingUltrabrightFireBlock = 2755;

		// Token: 0x040058FA RID: 22778
		public const short GenderChangePotion = 2756;

		// Token: 0x040058FB RID: 22779
		public const short VortexHelmet = 2757;

		// Token: 0x040058FC RID: 22780
		public const short VortexBreastplate = 2758;

		// Token: 0x040058FD RID: 22781
		public const short VortexLeggings = 2759;

		// Token: 0x040058FE RID: 22782
		public const short NebulaHelmet = 2760;

		// Token: 0x040058FF RID: 22783
		public const short NebulaBreastplate = 2761;

		// Token: 0x04005900 RID: 22784
		public const short NebulaLeggings = 2762;

		// Token: 0x04005901 RID: 22785
		public const short SolarFlareHelmet = 2763;

		// Token: 0x04005902 RID: 22786
		public const short SolarFlareBreastplate = 2764;

		// Token: 0x04005903 RID: 22787
		public const short SolarFlareLeggings = 2765;

		// Token: 0x04005904 RID: 22788
		public const short LunarTabletFragment = 2766;

		// Token: 0x04005905 RID: 22789
		public const short SolarTablet = 2767;

		// Token: 0x04005906 RID: 22790
		public const short DrillContainmentUnit = 2768;

		// Token: 0x04005907 RID: 22791
		public const short CosmicCarKey = 2769;

		// Token: 0x04005908 RID: 22792
		public const short MothronWings = 2770;

		// Token: 0x04005909 RID: 22793
		public const short BrainScrambler = 2771;

		// Token: 0x0400590A RID: 22794
		public const short VortexAxe = 2772;

		// Token: 0x0400590B RID: 22795
		public const short VortexChainsaw = 2773;

		// Token: 0x0400590C RID: 22796
		public const short VortexDrill = 2774;

		// Token: 0x0400590D RID: 22797
		public const short VortexHammer = 2775;

		// Token: 0x0400590E RID: 22798
		public const short VortexPickaxe = 2776;

		// Token: 0x0400590F RID: 22799
		public const short NebulaAxe = 2777;

		// Token: 0x04005910 RID: 22800
		public const short NebulaChainsaw = 2778;

		// Token: 0x04005911 RID: 22801
		public const short NebulaDrill = 2779;

		// Token: 0x04005912 RID: 22802
		public const short NebulaHammer = 2780;

		// Token: 0x04005913 RID: 22803
		public const short NebulaPickaxe = 2781;

		// Token: 0x04005914 RID: 22804
		public const short SolarFlareAxe = 2782;

		// Token: 0x04005915 RID: 22805
		public const short SolarFlareChainsaw = 2783;

		// Token: 0x04005916 RID: 22806
		public const short SolarFlareDrill = 2784;

		// Token: 0x04005917 RID: 22807
		public const short SolarFlareHammer = 2785;

		// Token: 0x04005918 RID: 22808
		public const short SolarFlarePickaxe = 2786;

		// Token: 0x04005919 RID: 22809
		public const short HoneyfallBlock = 2787;

		// Token: 0x0400591A RID: 22810
		public const short HoneyfallWall = 2788;

		// Token: 0x0400591B RID: 22811
		public const short ChlorophyteBrickWall = 2789;

		// Token: 0x0400591C RID: 22812
		public const short CrimtaneBrickWall = 2790;

		// Token: 0x0400591D RID: 22813
		public const short ShroomitePlatingWall = 2791;

		// Token: 0x0400591E RID: 22814
		public const short ChlorophyteBrick = 2792;

		// Token: 0x0400591F RID: 22815
		public const short CrimtaneBrick = 2793;

		// Token: 0x04005920 RID: 22816
		public const short ShroomitePlating = 2794;

		// Token: 0x04005921 RID: 22817
		public const short LaserMachinegun = 2795;

		// Token: 0x04005922 RID: 22818
		public const short ElectrosphereLauncher = 2796;

		// Token: 0x04005923 RID: 22819
		public const short Xenopopper = 2797;

		// Token: 0x04005924 RID: 22820
		public const short LaserDrill = 2798;

		// Token: 0x04005925 RID: 22821
		public const short LaserRuler = 2799;

		// Token: 0x04005926 RID: 22822
		public const short AntiGravityHook = 2800;

		// Token: 0x04005927 RID: 22823
		public const short MoonMask = 2801;

		// Token: 0x04005928 RID: 22824
		public const short SunMask = 2802;

		// Token: 0x04005929 RID: 22825
		public const short MartianCostumeMask = 2803;

		// Token: 0x0400592A RID: 22826
		public const short MartianCostumeShirt = 2804;

		// Token: 0x0400592B RID: 22827
		public const short MartianCostumePants = 2805;

		// Token: 0x0400592C RID: 22828
		public const short MartianUniformHelmet = 2806;

		// Token: 0x0400592D RID: 22829
		public const short MartianUniformTorso = 2807;

		// Token: 0x0400592E RID: 22830
		public const short MartianUniformPants = 2808;

		// Token: 0x0400592F RID: 22831
		public const short MartianAstroClock = 2809;

		// Token: 0x04005930 RID: 22832
		public const short MartianBathtub = 2810;

		// Token: 0x04005931 RID: 22833
		public const short MartianBed = 2811;

		// Token: 0x04005932 RID: 22834
		public const short MartianHoverChair = 2812;

		// Token: 0x04005933 RID: 22835
		public const short MartianChandelier = 2813;

		// Token: 0x04005934 RID: 22836
		public const short MartianChest = 2814;

		// Token: 0x04005935 RID: 22837
		public const short MartianDoor = 2815;

		// Token: 0x04005936 RID: 22838
		public const short MartianDresser = 2816;

		// Token: 0x04005937 RID: 22839
		public const short MartianHolobookcase = 2817;

		// Token: 0x04005938 RID: 22840
		public const short MartianHoverCandle = 2818;

		// Token: 0x04005939 RID: 22841
		public const short MartianLamppost = 2819;

		// Token: 0x0400593A RID: 22842
		public const short MartianLantern = 2820;

		// Token: 0x0400593B RID: 22843
		public const short MartianPiano = 2821;

		// Token: 0x0400593C RID: 22844
		public const short MartianPlatform = 2822;

		// Token: 0x0400593D RID: 22845
		public const short MartianSofa = 2823;

		// Token: 0x0400593E RID: 22846
		public const short MartianTable = 2824;

		// Token: 0x0400593F RID: 22847
		public const short MartianTableLamp = 2825;

		// Token: 0x04005940 RID: 22848
		public const short MartianWorkBench = 2826;

		// Token: 0x04005941 RID: 22849
		public const short WoodenSink = 2827;

		// Token: 0x04005942 RID: 22850
		public const short EbonwoodSink = 2828;

		// Token: 0x04005943 RID: 22851
		public const short RichMahoganySink = 2829;

		// Token: 0x04005944 RID: 22852
		public const short PearlwoodSink = 2830;

		// Token: 0x04005945 RID: 22853
		public const short BoneSink = 2831;

		// Token: 0x04005946 RID: 22854
		public const short FleshSink = 2832;

		// Token: 0x04005947 RID: 22855
		public const short LivingWoodSink = 2833;

		// Token: 0x04005948 RID: 22856
		public const short SkywareSink = 2834;

		// Token: 0x04005949 RID: 22857
		public const short ShadewoodSink = 2835;

		// Token: 0x0400594A RID: 22858
		public const short LihzahrdSink = 2836;

		// Token: 0x0400594B RID: 22859
		public const short BlueDungeonSink = 2837;

		// Token: 0x0400594C RID: 22860
		public const short GreenDungeonSink = 2838;

		// Token: 0x0400594D RID: 22861
		public const short PinkDungeonSink = 2839;

		// Token: 0x0400594E RID: 22862
		public const short ObsidianSink = 2840;

		// Token: 0x0400594F RID: 22863
		public const short MetalSink = 2841;

		// Token: 0x04005950 RID: 22864
		public const short GlassSink = 2842;

		// Token: 0x04005951 RID: 22865
		public const short GoldenSink = 2843;

		// Token: 0x04005952 RID: 22866
		public const short HoneySink = 2844;

		// Token: 0x04005953 RID: 22867
		public const short SteampunkSink = 2845;

		// Token: 0x04005954 RID: 22868
		public const short PumpkinSink = 2846;

		// Token: 0x04005955 RID: 22869
		public const short SpookySink = 2847;

		// Token: 0x04005956 RID: 22870
		public const short FrozenSink = 2848;

		// Token: 0x04005957 RID: 22871
		public const short DynastySink = 2849;

		// Token: 0x04005958 RID: 22872
		public const short PalmWoodSink = 2850;

		// Token: 0x04005959 RID: 22873
		public const short MushroomSink = 2851;

		// Token: 0x0400595A RID: 22874
		public const short BorealWoodSink = 2852;

		// Token: 0x0400595B RID: 22875
		public const short SlimeSink = 2853;

		// Token: 0x0400595C RID: 22876
		public const short CactusSink = 2854;

		// Token: 0x0400595D RID: 22877
		public const short MartianSink = 2855;

		// Token: 0x0400595E RID: 22878
		public const short WhiteLunaticHood = 2856;

		// Token: 0x0400595F RID: 22879
		public const short BlueLunaticHood = 2857;

		// Token: 0x04005960 RID: 22880
		public const short WhiteLunaticRobe = 2858;

		// Token: 0x04005961 RID: 22881
		public const short BlueLunaticRobe = 2859;

		// Token: 0x04005962 RID: 22882
		public const short MartianConduitPlating = 2860;

		// Token: 0x04005963 RID: 22883
		public const short MartianConduitWall = 2861;

		// Token: 0x04005964 RID: 22884
		public const short HiTekSunglasses = 2862;

		// Token: 0x04005965 RID: 22885
		public const short MartianHairDye = 2863;

		// Token: 0x04005966 RID: 22886
		public const short MartianArmorDye = 2864;

		// Token: 0x04005967 RID: 22887
		public const short PaintingCastleMarsberg = 2865;

		// Token: 0x04005968 RID: 22888
		public const short PaintingMartiaLisa = 2866;

		// Token: 0x04005969 RID: 22889
		public const short PaintingTheTruthIsUpThere = 2867;

		// Token: 0x0400596A RID: 22890
		public const short SmokeBlock = 2868;

		// Token: 0x0400596B RID: 22891
		public const short LivingFlameDye = 2869;

		// Token: 0x0400596C RID: 22892
		public const short LivingRainbowDye = 2870;

		// Token: 0x0400596D RID: 22893
		public const short ShadowDye = 2871;

		// Token: 0x0400596E RID: 22894
		public const short NegativeDye = 2872;

		// Token: 0x0400596F RID: 22895
		public const short LivingOceanDye = 2873;

		// Token: 0x04005970 RID: 22896
		public const short BrownDye = 2874;

		// Token: 0x04005971 RID: 22897
		public const short BrownAndBlackDye = 2875;

		// Token: 0x04005972 RID: 22898
		public const short BrightBrownDye = 2876;

		// Token: 0x04005973 RID: 22899
		public const short BrownAndSilverDye = 2877;

		// Token: 0x04005974 RID: 22900
		public const short WispDye = 2878;

		// Token: 0x04005975 RID: 22901
		public const short PixieDye = 2879;

		// Token: 0x04005976 RID: 22902
		public const short InfluxWaver = 2880;

		// Token: 0x04005977 RID: 22903
		public const short PhasicWarpEjector = 2881;

		// Token: 0x04005978 RID: 22904
		public const short ChargedBlasterCannon = 2882;

		// Token: 0x04005979 RID: 22905
		public const short ChlorophyteDye = 2883;

		// Token: 0x0400597A RID: 22906
		public const short UnicornWispDye = 2884;

		// Token: 0x0400597B RID: 22907
		public const short InfernalWispDye = 2885;

		// Token: 0x0400597C RID: 22908
		public const short ViciousPowder = 2886;

		// Token: 0x0400597D RID: 22909
		public const short ViciousMushroom = 2887;

		// Token: 0x0400597E RID: 22910
		public const short BeesKnees = 2888;

		// Token: 0x0400597F RID: 22911
		public const short GoldBird = 2889;

		// Token: 0x04005980 RID: 22912
		public const short GoldBunny = 2890;

		// Token: 0x04005981 RID: 22913
		public const short GoldButterfly = 2891;

		// Token: 0x04005982 RID: 22914
		public const short GoldFrog = 2892;

		// Token: 0x04005983 RID: 22915
		public const short GoldGrasshopper = 2893;

		// Token: 0x04005984 RID: 22916
		public const short GoldMouse = 2894;

		// Token: 0x04005985 RID: 22917
		public const short GoldWorm = 2895;

		// Token: 0x04005986 RID: 22918
		public const short StickyDynamite = 2896;

		// Token: 0x04005987 RID: 22919
		public const short AngryTrapperBanner = 2897;

		// Token: 0x04005988 RID: 22920
		public const short ArmoredVikingBanner = 2898;

		// Token: 0x04005989 RID: 22921
		public const short BlackSlimeBanner = 2899;

		// Token: 0x0400598A RID: 22922
		public const short BlueArmoredBonesBanner = 2900;

		// Token: 0x0400598B RID: 22923
		public const short BlueCultistArcherBanner = 2901;

		// Token: 0x0400598C RID: 22924
		public const short BlueCultistCasterBanner = 2902;

		// Token: 0x0400598D RID: 22925
		public const short BlueCultistFighterBanner = 2903;

		// Token: 0x0400598E RID: 22926
		public const short BoneLeeBanner = 2904;

		// Token: 0x0400598F RID: 22927
		public const short ClingerBanner = 2905;

		// Token: 0x04005990 RID: 22928
		public const short CochinealBeetleBanner = 2906;

		// Token: 0x04005991 RID: 22929
		public const short CorruptPenguinBanner = 2907;

		// Token: 0x04005992 RID: 22930
		public const short CorruptSlimeBanner = 2908;

		// Token: 0x04005993 RID: 22931
		public const short CorruptorBanner = 2909;

		// Token: 0x04005994 RID: 22932
		public const short CrimslimeBanner = 2910;

		// Token: 0x04005995 RID: 22933
		public const short CursedSkullBanner = 2911;

		// Token: 0x04005996 RID: 22934
		public const short CyanBeetleBanner = 2912;

		// Token: 0x04005997 RID: 22935
		public const short DevourerBanner = 2913;

		// Token: 0x04005998 RID: 22936
		public const short DiablolistBanner = 2914;

		// Token: 0x04005999 RID: 22937
		public const short DoctorBonesBanner = 2915;

		// Token: 0x0400599A RID: 22938
		public const short DungeonSlimeBanner = 2916;

		// Token: 0x0400599B RID: 22939
		public const short DungeonSpiritBanner = 2917;

		// Token: 0x0400599C RID: 22940
		public const short ElfArcherBanner = 2918;

		// Token: 0x0400599D RID: 22941
		public const short ElfCopterBanner = 2919;

		// Token: 0x0400599E RID: 22942
		public const short EyezorBanner = 2920;

		// Token: 0x0400599F RID: 22943
		public const short FlockoBanner = 2921;

		// Token: 0x040059A0 RID: 22944
		public const short GhostBanner = 2922;

		// Token: 0x040059A1 RID: 22945
		public const short GiantBatBanner = 2923;

		// Token: 0x040059A2 RID: 22946
		public const short GiantCursedSkullBanner = 2924;

		// Token: 0x040059A3 RID: 22947
		public const short GiantFlyingFoxBanner = 2925;

		// Token: 0x040059A4 RID: 22948
		public const short GingerbreadManBanner = 2926;

		// Token: 0x040059A5 RID: 22949
		public const short GoblinArcherBanner = 2927;

		// Token: 0x040059A6 RID: 22950
		public const short GreenSlimeBanner = 2928;

		// Token: 0x040059A7 RID: 22951
		public const short HeadlessHorsemanBanner = 2929;

		// Token: 0x040059A8 RID: 22952
		public const short HellArmoredBonesBanner = 2930;

		// Token: 0x040059A9 RID: 22953
		public const short HellhoundBanner = 2931;

		// Token: 0x040059AA RID: 22954
		public const short HoppinJackBanner = 2932;

		// Token: 0x040059AB RID: 22955
		public const short IceBatBanner = 2933;

		// Token: 0x040059AC RID: 22956
		public const short IceGolemBanner = 2934;

		// Token: 0x040059AD RID: 22957
		public const short IceSlimeBanner = 2935;

		// Token: 0x040059AE RID: 22958
		public const short IchorStickerBanner = 2936;

		// Token: 0x040059AF RID: 22959
		public const short IlluminantBatBanner = 2937;

		// Token: 0x040059B0 RID: 22960
		public const short IlluminantSlimeBanner = 2938;

		// Token: 0x040059B1 RID: 22961
		public const short JungleBatBanner = 2939;

		// Token: 0x040059B2 RID: 22962
		public const short JungleSlimeBanner = 2940;

		// Token: 0x040059B3 RID: 22963
		public const short KrampusBanner = 2941;

		// Token: 0x040059B4 RID: 22964
		public const short LacBeetleBanner = 2942;

		// Token: 0x040059B5 RID: 22965
		public const short LavaBatBanner = 2943;

		// Token: 0x040059B6 RID: 22966
		public const short LavaSlimeBanner = 2944;

		// Token: 0x040059B7 RID: 22967
		public const short MartianBrainscramblerBanner = 2945;

		// Token: 0x040059B8 RID: 22968
		public const short MartianDroneBanner = 2946;

		// Token: 0x040059B9 RID: 22969
		public const short MartianEngineerBanner = 2947;

		// Token: 0x040059BA RID: 22970
		public const short MartianGigazapperBanner = 2948;

		// Token: 0x040059BB RID: 22971
		public const short MartianGreyGruntBanner = 2949;

		// Token: 0x040059BC RID: 22972
		public const short MartianOfficerBanner = 2950;

		// Token: 0x040059BD RID: 22973
		public const short MartianRaygunnerBanner = 2951;

		// Token: 0x040059BE RID: 22974
		public const short MartianScutlixGunnerBanner = 2952;

		// Token: 0x040059BF RID: 22975
		public const short MartianTeslaTurretBanner = 2953;

		// Token: 0x040059C0 RID: 22976
		public const short MisterStabbyBanner = 2954;

		// Token: 0x040059C1 RID: 22977
		public const short MotherSlimeBanner = 2955;

		// Token: 0x040059C2 RID: 22978
		public const short NecromancerBanner = 2956;

		// Token: 0x040059C3 RID: 22979
		public const short NutcrackerBanner = 2957;

		// Token: 0x040059C4 RID: 22980
		public const short PaladinBanner = 2958;

		// Token: 0x040059C5 RID: 22981
		public const short PenguinBanner = 2959;

		// Token: 0x040059C6 RID: 22982
		public const short PinkyBanner = 2960;

		// Token: 0x040059C7 RID: 22983
		public const short PoltergeistBanner = 2961;

		// Token: 0x040059C8 RID: 22984
		public const short PossessedArmorBanner = 2962;

		// Token: 0x040059C9 RID: 22985
		public const short PresentMimicBanner = 2963;

		// Token: 0x040059CA RID: 22986
		public const short PurpleSlimeBanner = 2964;

		// Token: 0x040059CB RID: 22987
		public const short RaggedCasterBanner = 2965;

		// Token: 0x040059CC RID: 22988
		public const short RainbowSlimeBanner = 2966;

		// Token: 0x040059CD RID: 22989
		public const short RavenBanner = 2967;

		// Token: 0x040059CE RID: 22990
		public const short RedSlimeBanner = 2968;

		// Token: 0x040059CF RID: 22991
		public const short RuneWizardBanner = 2969;

		// Token: 0x040059D0 RID: 22992
		public const short RustyArmoredBonesBanner = 2970;

		// Token: 0x040059D1 RID: 22993
		public const short ScarecrowBanner = 2971;

		// Token: 0x040059D2 RID: 22994
		public const short ScutlixBanner = 2972;

		// Token: 0x040059D3 RID: 22995
		public const short SkeletonArcherBanner = 2973;

		// Token: 0x040059D4 RID: 22996
		public const short SkeletonCommandoBanner = 2974;

		// Token: 0x040059D5 RID: 22997
		public const short SkeletonSniperBanner = 2975;

		// Token: 0x040059D6 RID: 22998
		public const short SlimerBanner = 2976;

		// Token: 0x040059D7 RID: 22999
		public const short SnatcherBanner = 2977;

		// Token: 0x040059D8 RID: 23000
		public const short SnowBallaBanner = 2978;

		// Token: 0x040059D9 RID: 23001
		public const short SnowmanGangstaBanner = 2979;

		// Token: 0x040059DA RID: 23002
		public const short SpikedIceSlimeBanner = 2980;

		// Token: 0x040059DB RID: 23003
		public const short SpikedJungleSlimeBanner = 2981;

		// Token: 0x040059DC RID: 23004
		public const short SplinterlingBanner = 2982;

		// Token: 0x040059DD RID: 23005
		public const short SquidBanner = 2983;

		// Token: 0x040059DE RID: 23006
		public const short TacticalSkeletonBanner = 2984;

		// Token: 0x040059DF RID: 23007
		public const short TheGroomBanner = 2985;

		// Token: 0x040059E0 RID: 23008
		public const short TimBanner = 2986;

		// Token: 0x040059E1 RID: 23009
		public const short UndeadMinerBanner = 2987;

		// Token: 0x040059E2 RID: 23010
		public const short UndeadVikingBanner = 2988;

		// Token: 0x040059E3 RID: 23011
		public const short WhiteCultistArcherBanner = 2989;

		// Token: 0x040059E4 RID: 23012
		public const short WhiteCultistCasterBanner = 2990;

		// Token: 0x040059E5 RID: 23013
		public const short WhiteCultistFighterBanner = 2991;

		// Token: 0x040059E6 RID: 23014
		public const short YellowSlimeBanner = 2992;

		// Token: 0x040059E7 RID: 23015
		public const short YetiBanner = 2993;

		// Token: 0x040059E8 RID: 23016
		public const short ZombieElfBanner = 2994;

		// Token: 0x040059E9 RID: 23017
		public const short SparkyPainting = 2995;

		// Token: 0x040059EA RID: 23018
		public const short VineRope = 2996;

		// Token: 0x040059EB RID: 23019
		public const short WormholePotion = 2997;

		// Token: 0x040059EC RID: 23020
		public const short SummonerEmblem = 2998;

		// Token: 0x040059ED RID: 23021
		public const short BewitchingTable = 2999;

		// Token: 0x040059EE RID: 23022
		public const short AlchemyTable = 3000;

		// Token: 0x040059EF RID: 23023
		public const short StrangeBrew = 3001;

		// Token: 0x040059F0 RID: 23024
		public const short SpelunkerGlowstick = 3002;

		// Token: 0x040059F1 RID: 23025
		public const short BoneArrow = 3003;

		// Token: 0x040059F2 RID: 23026
		public const short BoneTorch = 3004;

		// Token: 0x040059F3 RID: 23027
		public const short VineRopeCoil = 3005;

		// Token: 0x040059F4 RID: 23028
		public const short SoulDrain = 3006;

		// Token: 0x040059F5 RID: 23029
		public const short DartPistol = 3007;

		// Token: 0x040059F6 RID: 23030
		public const short DartRifle = 3008;

		// Token: 0x040059F7 RID: 23031
		public const short CrystalDart = 3009;

		// Token: 0x040059F8 RID: 23032
		public const short CursedDart = 3010;

		// Token: 0x040059F9 RID: 23033
		public const short IchorDart = 3011;

		// Token: 0x040059FA RID: 23034
		public const short ChainGuillotines = 3012;

		// Token: 0x040059FB RID: 23035
		public const short FetidBaghnakhs = 3013;

		// Token: 0x040059FC RID: 23036
		public const short ClingerStaff = 3014;

		// Token: 0x040059FD RID: 23037
		public const short PutridScent = 3015;

		// Token: 0x040059FE RID: 23038
		public const short FleshKnuckles = 3016;

		// Token: 0x040059FF RID: 23039
		public const short FlowerBoots = 3017;

		// Token: 0x04005A00 RID: 23040
		public const short Seedler = 3018;

		// Token: 0x04005A01 RID: 23041
		public const short HellwingBow = 3019;

		// Token: 0x04005A02 RID: 23042
		public const short TendonHook = 3020;

		// Token: 0x04005A03 RID: 23043
		public const short ThornHook = 3021;

		// Token: 0x04005A04 RID: 23044
		public const short IlluminantHook = 3022;

		// Token: 0x04005A05 RID: 23045
		public const short WormHook = 3023;

		// Token: 0x04005A06 RID: 23046
		public const short DevDye = 3024;

		// Token: 0x04005A07 RID: 23047
		public const short PurpleOozeDye = 3025;

		// Token: 0x04005A08 RID: 23048
		public const short ReflectiveSilverDye = 3026;

		// Token: 0x04005A09 RID: 23049
		public const short ReflectiveGoldDye = 3027;

		// Token: 0x04005A0A RID: 23050
		public const short BlueAcidDye = 3028;

		// Token: 0x04005A0B RID: 23051
		public const short DaedalusStormbow = 3029;

		// Token: 0x04005A0C RID: 23052
		public const short FlyingKnife = 3030;

		// Token: 0x04005A0D RID: 23053
		public const short BottomlessBucket = 3031;

		// Token: 0x04005A0E RID: 23054
		public const short SuperAbsorbantSponge = 3032;

		// Token: 0x04005A0F RID: 23055
		public const short GoldRing = 3033;

		// Token: 0x04005A10 RID: 23056
		public const short CoinRing = 3034;

		// Token: 0x04005A11 RID: 23057
		public const short GreedyRing = 3035;

		// Token: 0x04005A12 RID: 23058
		public const short FishFinder = 3036;

		// Token: 0x04005A13 RID: 23059
		public const short WeatherRadio = 3037;

		// Token: 0x04005A14 RID: 23060
		public const short HadesDye = 3038;

		// Token: 0x04005A15 RID: 23061
		public const short TwilightDye = 3039;

		// Token: 0x04005A16 RID: 23062
		public const short AcidDye = 3040;

		// Token: 0x04005A17 RID: 23063
		public const short MushroomDye = 3041;

		// Token: 0x04005A18 RID: 23064
		public const short PhaseDye = 3042;

		// Token: 0x04005A19 RID: 23065
		public const short MagicLantern = 3043;

		// Token: 0x04005A1A RID: 23066
		public const short MusicBoxLunarBoss = 3044;

		// Token: 0x04005A1B RID: 23067
		public const short RainbowTorch = 3045;

		// Token: 0x04005A1C RID: 23068
		public const short CursedCampfire = 3046;

		// Token: 0x04005A1D RID: 23069
		public const short DemonCampfire = 3047;

		// Token: 0x04005A1E RID: 23070
		public const short FrozenCampfire = 3048;

		// Token: 0x04005A1F RID: 23071
		public const short IchorCampfire = 3049;

		// Token: 0x04005A20 RID: 23072
		public const short RainbowCampfire = 3050;

		// Token: 0x04005A21 RID: 23073
		public const short CrystalVileShard = 3051;

		// Token: 0x04005A22 RID: 23074
		public const short ShadowFlameBow = 3052;

		// Token: 0x04005A23 RID: 23075
		public const short ShadowFlameHexDoll = 3053;

		// Token: 0x04005A24 RID: 23076
		public const short ShadowFlameKnife = 3054;

		// Token: 0x04005A25 RID: 23077
		public const short PaintingAcorns = 3055;

		// Token: 0x04005A26 RID: 23078
		public const short PaintingColdSnap = 3056;

		// Token: 0x04005A27 RID: 23079
		public const short PaintingCursedSaint = 3057;

		// Token: 0x04005A28 RID: 23080
		public const short PaintingSnowfellas = 3058;

		// Token: 0x04005A29 RID: 23081
		public const short PaintingTheSeason = 3059;

		// Token: 0x04005A2A RID: 23082
		public const short BoneRattle = 3060;

		// Token: 0x04005A2B RID: 23083
		public const short ArchitectGizmoPack = 3061;

		// Token: 0x04005A2C RID: 23084
		public const short CrimsonHeart = 3062;

		// Token: 0x04005A2D RID: 23085
		public const short Meowmere = 3063;

		// Token: 0x04005A2E RID: 23086
		public const short Sundial = 3064;

		// Token: 0x04005A2F RID: 23087
		public const short StarWrath = 3065;

		// Token: 0x04005A30 RID: 23088
		public const short MarbleBlock = 3066;

		// Token: 0x04005A31 RID: 23089
		public const short HellstoneBrickWall = 3067;

		// Token: 0x04005A32 RID: 23090
		public const short CordageGuide = 3068;

		// Token: 0x04005A33 RID: 23091
		public const short WandofSparking = 3069;

		// Token: 0x04005A34 RID: 23092
		public const short GoldBirdCage = 3070;

		// Token: 0x04005A35 RID: 23093
		public const short GoldBunnyCage = 3071;

		// Token: 0x04005A36 RID: 23094
		public const short GoldButterflyCage = 3072;

		// Token: 0x04005A37 RID: 23095
		public const short GoldFrogCage = 3073;

		// Token: 0x04005A38 RID: 23096
		public const short GoldGrasshopperCage = 3074;

		// Token: 0x04005A39 RID: 23097
		public const short GoldMouseCage = 3075;

		// Token: 0x04005A3A RID: 23098
		public const short GoldWormCage = 3076;

		// Token: 0x04005A3B RID: 23099
		public const short SilkRope = 3077;

		// Token: 0x04005A3C RID: 23100
		public const short WebRope = 3078;

		// Token: 0x04005A3D RID: 23101
		public const short SilkRopeCoil = 3079;

		// Token: 0x04005A3E RID: 23102
		public const short WebRopeCoil = 3080;

		// Token: 0x04005A3F RID: 23103
		public const short Marble = 3081;

		// Token: 0x04005A40 RID: 23104
		public const short MarbleWall = 3082;

		// Token: 0x04005A41 RID: 23105
		public const short MarbleBlockWall = 3083;

		// Token: 0x04005A42 RID: 23106
		public const short Radar = 3084;

		// Token: 0x04005A43 RID: 23107
		public const short LockBox = 3085;

		// Token: 0x04005A44 RID: 23108
		public const short Granite = 3086;

		// Token: 0x04005A45 RID: 23109
		public const short GraniteBlock = 3087;

		// Token: 0x04005A46 RID: 23110
		public const short GraniteWall = 3088;

		// Token: 0x04005A47 RID: 23111
		public const short GraniteBlockWall = 3089;

		// Token: 0x04005A48 RID: 23112
		public const short RoyalGel = 3090;

		// Token: 0x04005A49 RID: 23113
		public const short NightKey = 3091;

		// Token: 0x04005A4A RID: 23114
		public const short LightKey = 3092;

		// Token: 0x04005A4B RID: 23115
		public const short HerbBag = 3093;

		// Token: 0x04005A4C RID: 23116
		public const short Javelin = 3094;

		// Token: 0x04005A4D RID: 23117
		public const short TallyCounter = 3095;

		// Token: 0x04005A4E RID: 23118
		public const short Sextant = 3096;

		// Token: 0x04005A4F RID: 23119
		public const short EoCShield = 3097;

		// Token: 0x04005A50 RID: 23120
		public const short ButchersChainsaw = 3098;

		// Token: 0x04005A51 RID: 23121
		public const short Stopwatch = 3099;

		// Token: 0x04005A52 RID: 23122
		public const short MeteoriteBrick = 3100;

		// Token: 0x04005A53 RID: 23123
		public const short MeteoriteBrickWall = 3101;

		// Token: 0x04005A54 RID: 23124
		public const short MetalDetector = 3102;

		// Token: 0x04005A55 RID: 23125
		public const short EndlessQuiver = 3103;

		// Token: 0x04005A56 RID: 23126
		public const short EndlessMusketPouch = 3104;

		// Token: 0x04005A57 RID: 23127
		public const short ToxicFlask = 3105;

		// Token: 0x04005A58 RID: 23128
		public const short PsychoKnife = 3106;

		// Token: 0x04005A59 RID: 23129
		public const short NailGun = 3107;

		// Token: 0x04005A5A RID: 23130
		public const short Nail = 3108;

		// Token: 0x04005A5B RID: 23131
		public const short NightVisionHelmet = 3109;

		// Token: 0x04005A5C RID: 23132
		public const short CelestialShell = 3110;

		// Token: 0x04005A5D RID: 23133
		public const short PinkGel = 3111;

		// Token: 0x04005A5E RID: 23134
		public const short BouncyGlowstick = 3112;

		// Token: 0x04005A5F RID: 23135
		public const short PinkSlimeBlock = 3113;

		// Token: 0x04005A60 RID: 23136
		public const short PinkTorch = 3114;

		// Token: 0x04005A61 RID: 23137
		public const short BouncyBomb = 3115;

		// Token: 0x04005A62 RID: 23138
		public const short BouncyGrenade = 3116;

		// Token: 0x04005A63 RID: 23139
		public const short PeaceCandle = 3117;

		// Token: 0x04005A64 RID: 23140
		public const short LifeformAnalyzer = 3118;

		// Token: 0x04005A65 RID: 23141
		public const short DPSMeter = 3119;

		// Token: 0x04005A66 RID: 23142
		public const short FishermansGuide = 3120;

		// Token: 0x04005A67 RID: 23143
		public const short GoblinTech = 3121;

		// Token: 0x04005A68 RID: 23144
		public const short REK = 3122;

		// Token: 0x04005A69 RID: 23145
		public const short PDA = 3123;

		// Token: 0x04005A6A RID: 23146
		public const short CellPhone = 3124;

		// Token: 0x04005A6B RID: 23147
		public const short GraniteChest = 3125;

		// Token: 0x04005A6C RID: 23148
		public const short MeteoriteClock = 3126;

		// Token: 0x04005A6D RID: 23149
		public const short MarbleClock = 3127;

		// Token: 0x04005A6E RID: 23150
		public const short GraniteClock = 3128;

		// Token: 0x04005A6F RID: 23151
		public const short MeteoriteDoor = 3129;

		// Token: 0x04005A70 RID: 23152
		public const short MarbleDoor = 3130;

		// Token: 0x04005A71 RID: 23153
		public const short GraniteDoor = 3131;

		// Token: 0x04005A72 RID: 23154
		public const short MeteoriteDresser = 3132;

		// Token: 0x04005A73 RID: 23155
		public const short MarbleDresser = 3133;

		// Token: 0x04005A74 RID: 23156
		public const short GraniteDresser = 3134;

		// Token: 0x04005A75 RID: 23157
		public const short MeteoriteLamp = 3135;

		// Token: 0x04005A76 RID: 23158
		public const short MarbleLamp = 3136;

		// Token: 0x04005A77 RID: 23159
		public const short GraniteLamp = 3137;

		// Token: 0x04005A78 RID: 23160
		public const short MeteoriteLantern = 3138;

		// Token: 0x04005A79 RID: 23161
		public const short MarbleLantern = 3139;

		// Token: 0x04005A7A RID: 23162
		public const short GraniteLantern = 3140;

		// Token: 0x04005A7B RID: 23163
		public const short MeteoritePiano = 3141;

		// Token: 0x04005A7C RID: 23164
		public const short MarblePiano = 3142;

		// Token: 0x04005A7D RID: 23165
		public const short GranitePiano = 3143;

		// Token: 0x04005A7E RID: 23166
		public const short MeteoritePlatform = 3144;

		// Token: 0x04005A7F RID: 23167
		public const short MarblePlatform = 3145;

		// Token: 0x04005A80 RID: 23168
		public const short GranitePlatform = 3146;

		// Token: 0x04005A81 RID: 23169
		public const short MeteoriteSink = 3147;

		// Token: 0x04005A82 RID: 23170
		public const short MarbleSink = 3148;

		// Token: 0x04005A83 RID: 23171
		public const short GraniteSink = 3149;

		// Token: 0x04005A84 RID: 23172
		public const short MeteoriteSofa = 3150;

		// Token: 0x04005A85 RID: 23173
		public const short MarbleSofa = 3151;

		// Token: 0x04005A86 RID: 23174
		public const short GraniteSofa = 3152;

		// Token: 0x04005A87 RID: 23175
		public const short MeteoriteTable = 3153;

		// Token: 0x04005A88 RID: 23176
		public const short MarbleTable = 3154;

		// Token: 0x04005A89 RID: 23177
		public const short GraniteTable = 3155;

		// Token: 0x04005A8A RID: 23178
		public const short MeteoriteWorkBench = 3156;

		// Token: 0x04005A8B RID: 23179
		public const short MarbleWorkBench = 3157;

		// Token: 0x04005A8C RID: 23180
		public const short GraniteWorkBench = 3158;

		// Token: 0x04005A8D RID: 23181
		public const short MeteoriteBathtub = 3159;

		// Token: 0x04005A8E RID: 23182
		public const short MarbleBathtub = 3160;

		// Token: 0x04005A8F RID: 23183
		public const short GraniteBathtub = 3161;

		// Token: 0x04005A90 RID: 23184
		public const short MeteoriteBed = 3162;

		// Token: 0x04005A91 RID: 23185
		public const short MarbleBed = 3163;

		// Token: 0x04005A92 RID: 23186
		public const short GraniteBed = 3164;

		// Token: 0x04005A93 RID: 23187
		public const short MeteoriteBookcase = 3165;

		// Token: 0x04005A94 RID: 23188
		public const short MarbleBookcase = 3166;

		// Token: 0x04005A95 RID: 23189
		public const short GraniteBookcase = 3167;

		// Token: 0x04005A96 RID: 23190
		public const short MeteoriteCandelabra = 3168;

		// Token: 0x04005A97 RID: 23191
		public const short MarbleCandelabra = 3169;

		// Token: 0x04005A98 RID: 23192
		public const short GraniteCandelabra = 3170;

		// Token: 0x04005A99 RID: 23193
		public const short MeteoriteCandle = 3171;

		// Token: 0x04005A9A RID: 23194
		public const short MarbleCandle = 3172;

		// Token: 0x04005A9B RID: 23195
		public const short GraniteCandle = 3173;

		// Token: 0x04005A9C RID: 23196
		public const short MeteoriteChair = 3174;

		// Token: 0x04005A9D RID: 23197
		public const short MarbleChair = 3175;

		// Token: 0x04005A9E RID: 23198
		public const short GraniteChair = 3176;

		// Token: 0x04005A9F RID: 23199
		public const short MeteoriteChandelier = 3177;

		// Token: 0x04005AA0 RID: 23200
		public const short MarbleChandelier = 3178;

		// Token: 0x04005AA1 RID: 23201
		public const short GraniteChandelier = 3179;

		// Token: 0x04005AA2 RID: 23202
		public const short MeteoriteChest = 3180;

		// Token: 0x04005AA3 RID: 23203
		public const short MarbleChest = 3181;

		// Token: 0x04005AA4 RID: 23204
		public const short MagicWaterDropper = 3182;

		// Token: 0x04005AA5 RID: 23205
		public const short GoldenBugNet = 3183;

		// Token: 0x04005AA6 RID: 23206
		public const short MagicLavaDropper = 3184;

		// Token: 0x04005AA7 RID: 23207
		public const short MagicHoneyDropper = 3185;

		// Token: 0x04005AA8 RID: 23208
		public const short EmptyDropper = 3186;

		// Token: 0x04005AA9 RID: 23209
		public const short GladiatorHelmet = 3187;

		// Token: 0x04005AAA RID: 23210
		public const short GladiatorBreastplate = 3188;

		// Token: 0x04005AAB RID: 23211
		public const short GladiatorLeggings = 3189;

		// Token: 0x04005AAC RID: 23212
		public const short ReflectiveDye = 3190;

		// Token: 0x04005AAD RID: 23213
		public const short EnchantedNightcrawler = 3191;

		// Token: 0x04005AAE RID: 23214
		public const short Grubby = 3192;

		// Token: 0x04005AAF RID: 23215
		public const short Sluggy = 3193;

		// Token: 0x04005AB0 RID: 23216
		public const short Buggy = 3194;

		// Token: 0x04005AB1 RID: 23217
		public const short GrubSoup = 3195;

		// Token: 0x04005AB2 RID: 23218
		public const short BombFish = 3196;

		// Token: 0x04005AB3 RID: 23219
		public const short FrostDaggerfish = 3197;

		// Token: 0x04005AB4 RID: 23220
		public const short SharpeningStation = 3198;

		// Token: 0x04005AB5 RID: 23221
		public const short IceMirror = 3199;

		// Token: 0x04005AB6 RID: 23222
		public const short SailfishBoots = 3200;

		// Token: 0x04005AB7 RID: 23223
		public const short TsunamiInABottle = 3201;

		// Token: 0x04005AB8 RID: 23224
		public const short TargetDummy = 3202;

		// Token: 0x04005AB9 RID: 23225
		public const short CorruptFishingCrate = 3203;

		// Token: 0x04005ABA RID: 23226
		public const short CrimsonFishingCrate = 3204;

		// Token: 0x04005ABB RID: 23227
		public const short DungeonFishingCrate = 3205;

		// Token: 0x04005ABC RID: 23228
		public const short FloatingIslandFishingCrate = 3206;

		// Token: 0x04005ABD RID: 23229
		public const short HallowedFishingCrate = 3207;

		// Token: 0x04005ABE RID: 23230
		public const short JungleFishingCrate = 3208;

		// Token: 0x04005ABF RID: 23231
		public const short CrystalSerpent = 3209;

		// Token: 0x04005AC0 RID: 23232
		public const short Toxikarp = 3210;

		// Token: 0x04005AC1 RID: 23233
		public const short Bladetongue = 3211;

		// Token: 0x04005AC2 RID: 23234
		public const short SharkToothNecklace = 3212;

		// Token: 0x04005AC3 RID: 23235
		public const short MoneyTrough = 3213;

		// Token: 0x04005AC4 RID: 23236
		public const short Bubble = 3214;

		// Token: 0x04005AC5 RID: 23237
		public const short DayBloomPlanterBox = 3215;

		// Token: 0x04005AC6 RID: 23238
		public const short MoonglowPlanterBox = 3216;

		// Token: 0x04005AC7 RID: 23239
		public const short CorruptPlanterBox = 3217;

		// Token: 0x04005AC8 RID: 23240
		public const short CrimsonPlanterBox = 3218;

		// Token: 0x04005AC9 RID: 23241
		public const short BlinkrootPlanterBox = 3219;

		// Token: 0x04005ACA RID: 23242
		public const short WaterleafPlanterBox = 3220;

		// Token: 0x04005ACB RID: 23243
		public const short ShiverthornPlanterBox = 3221;

		// Token: 0x04005ACC RID: 23244
		public const short FireBlossomPlanterBox = 3222;

		// Token: 0x04005ACD RID: 23245
		public const short BrainOfConfusion = 3223;

		// Token: 0x04005ACE RID: 23246
		public const short WormScarf = 3224;

		// Token: 0x04005ACF RID: 23247
		public const short BalloonPufferfish = 3225;

		// Token: 0x04005AD0 RID: 23248
		public const short BejeweledValkyrieHead = 3226;

		// Token: 0x04005AD1 RID: 23249
		public const short BejeweledValkyrieBody = 3227;

		// Token: 0x04005AD2 RID: 23250
		public const short BejeweledValkyrieWing = 3228;

		// Token: 0x04005AD3 RID: 23251
		public const short RichGravestone1 = 3229;

		// Token: 0x04005AD4 RID: 23252
		public const short RichGravestone2 = 3230;

		// Token: 0x04005AD5 RID: 23253
		public const short RichGravestone3 = 3231;

		// Token: 0x04005AD6 RID: 23254
		public const short RichGravestone4 = 3232;

		// Token: 0x04005AD7 RID: 23255
		public const short RichGravestone5 = 3233;

		// Token: 0x04005AD8 RID: 23256
		public const short CrystalBlock = 3234;

		// Token: 0x04005AD9 RID: 23257
		public const short MusicBoxMartians = 3235;

		// Token: 0x04005ADA RID: 23258
		public const short MusicBoxPirates = 3236;

		// Token: 0x04005ADB RID: 23259
		public const short MusicBoxHell = 3237;

		// Token: 0x04005ADC RID: 23260
		public const short CrystalBlockWall = 3238;

		// Token: 0x04005ADD RID: 23261
		public const short Trapdoor = 3239;

		// Token: 0x04005ADE RID: 23262
		public const short TallGate = 3240;

		// Token: 0x04005ADF RID: 23263
		public const short SharkronBalloon = 3241;

		// Token: 0x04005AE0 RID: 23264
		public const short TaxCollectorHat = 3242;

		// Token: 0x04005AE1 RID: 23265
		public const short TaxCollectorSuit = 3243;

		// Token: 0x04005AE2 RID: 23266
		public const short TaxCollectorPants = 3244;

		// Token: 0x04005AE3 RID: 23267
		public const short BoneGlove = 3245;

		// Token: 0x04005AE4 RID: 23268
		public const short ClothierJacket = 3246;

		// Token: 0x04005AE5 RID: 23269
		public const short ClothierPants = 3247;

		// Token: 0x04005AE6 RID: 23270
		public const short DyeTraderTurban = 3248;

		// Token: 0x04005AE7 RID: 23271
		public const short DeadlySphereStaff = 3249;

		// Token: 0x04005AE8 RID: 23272
		public const short BalloonHorseshoeFart = 3250;

		// Token: 0x04005AE9 RID: 23273
		public const short BalloonHorseshoeHoney = 3251;

		// Token: 0x04005AEA RID: 23274
		public const short BalloonHorseshoeSharkron = 3252;

		// Token: 0x04005AEB RID: 23275
		public const short LavaLamp = 3253;

		// Token: 0x04005AEC RID: 23276
		public const short CageEnchantedNightcrawler = 3254;

		// Token: 0x04005AED RID: 23277
		public const short CageBuggy = 3255;

		// Token: 0x04005AEE RID: 23278
		public const short CageGrubby = 3256;

		// Token: 0x04005AEF RID: 23279
		public const short CageSluggy = 3257;

		// Token: 0x04005AF0 RID: 23280
		public const short SlapHand = 3258;

		// Token: 0x04005AF1 RID: 23281
		public const short TwilightHairDye = 3259;

		// Token: 0x04005AF2 RID: 23282
		public const short BlessedApple = 3260;

		// Token: 0x04005AF3 RID: 23283
		public const short SpectreBar = 3261;

		// Token: 0x04005AF4 RID: 23284
		public const short Code1 = 3262;

		// Token: 0x04005AF5 RID: 23285
		public const short BuccaneerBandana = 3263;

		// Token: 0x04005AF6 RID: 23286
		public const short BuccaneerShirt = 3264;

		// Token: 0x04005AF7 RID: 23287
		public const short BuccaneerPants = 3265;

		// Token: 0x04005AF8 RID: 23288
		public const short ObsidianHelm = 3266;

		// Token: 0x04005AF9 RID: 23289
		public const short ObsidianShirt = 3267;

		// Token: 0x04005AFA RID: 23290
		public const short ObsidianPants = 3268;

		// Token: 0x04005AFB RID: 23291
		public const short MedusaHead = 3269;

		// Token: 0x04005AFC RID: 23292
		public const short ItemFrame = 3270;

		// Token: 0x04005AFD RID: 23293
		public const short Sandstone = 3271;

		// Token: 0x04005AFE RID: 23294
		public const short HardenedSand = 3272;

		// Token: 0x04005AFF RID: 23295
		public const short SandstoneWall = 3273;

		// Token: 0x04005B00 RID: 23296
		public const short CorruptHardenedSand = 3274;

		// Token: 0x04005B01 RID: 23297
		public const short CrimsonHardenedSand = 3275;

		// Token: 0x04005B02 RID: 23298
		public const short CorruptSandstone = 3276;

		// Token: 0x04005B03 RID: 23299
		public const short CrimsonSandstone = 3277;

		// Token: 0x04005B04 RID: 23300
		public const short WoodYoyo = 3278;

		// Token: 0x04005B05 RID: 23301
		public const short CorruptYoyo = 3279;

		// Token: 0x04005B06 RID: 23302
		public const short CrimsonYoyo = 3280;

		// Token: 0x04005B07 RID: 23303
		public const short JungleYoyo = 3281;

		// Token: 0x04005B08 RID: 23304
		public const short Cascade = 3282;

		// Token: 0x04005B09 RID: 23305
		public const short Chik = 3283;

		// Token: 0x04005B0A RID: 23306
		public const short Code2 = 3284;

		// Token: 0x04005B0B RID: 23307
		public const short Rally = 3285;

		// Token: 0x04005B0C RID: 23308
		public const short Yelets = 3286;

		// Token: 0x04005B0D RID: 23309
		public const short RedsYoyo = 3287;

		// Token: 0x04005B0E RID: 23310
		public const short ValkyrieYoyo = 3288;

		// Token: 0x04005B0F RID: 23311
		public const short Amarok = 3289;

		// Token: 0x04005B10 RID: 23312
		public const short HelFire = 3290;

		// Token: 0x04005B11 RID: 23313
		public const short Kraken = 3291;

		// Token: 0x04005B12 RID: 23314
		public const short TheEyeOfCthulhu = 3292;

		// Token: 0x04005B13 RID: 23315
		public const short RedString = 3293;

		// Token: 0x04005B14 RID: 23316
		public const short OrangeString = 3294;

		// Token: 0x04005B15 RID: 23317
		public const short YellowString = 3295;

		// Token: 0x04005B16 RID: 23318
		public const short LimeString = 3296;

		// Token: 0x04005B17 RID: 23319
		public const short GreenString = 3297;

		// Token: 0x04005B18 RID: 23320
		public const short TealString = 3298;

		// Token: 0x04005B19 RID: 23321
		public const short CyanString = 3299;

		// Token: 0x04005B1A RID: 23322
		public const short SkyBlueString = 3300;

		// Token: 0x04005B1B RID: 23323
		public const short BlueString = 3301;

		// Token: 0x04005B1C RID: 23324
		public const short PurpleString = 3302;

		// Token: 0x04005B1D RID: 23325
		public const short VioletString = 3303;

		// Token: 0x04005B1E RID: 23326
		public const short PinkString = 3304;

		// Token: 0x04005B1F RID: 23327
		public const short BrownString = 3305;

		// Token: 0x04005B20 RID: 23328
		public const short WhiteString = 3306;

		// Token: 0x04005B21 RID: 23329
		public const short RainbowString = 3307;

		// Token: 0x04005B22 RID: 23330
		public const short BlackString = 3308;

		// Token: 0x04005B23 RID: 23331
		public const short BlackCounterweight = 3309;

		// Token: 0x04005B24 RID: 23332
		public const short BlueCounterweight = 3310;

		// Token: 0x04005B25 RID: 23333
		public const short GreenCounterweight = 3311;

		// Token: 0x04005B26 RID: 23334
		public const short PurpleCounterweight = 3312;

		// Token: 0x04005B27 RID: 23335
		public const short RedCounterweight = 3313;

		// Token: 0x04005B28 RID: 23336
		public const short YellowCounterweight = 3314;

		// Token: 0x04005B29 RID: 23337
		public const short FormatC = 3315;

		// Token: 0x04005B2A RID: 23338
		public const short Gradient = 3316;

		// Token: 0x04005B2B RID: 23339
		public const short Valor = 3317;

		// Token: 0x04005B2C RID: 23340
		public const short KingSlimeBossBag = 3318;

		// Token: 0x04005B2D RID: 23341
		public const short EyeOfCthulhuBossBag = 3319;

		// Token: 0x04005B2E RID: 23342
		public const short EaterOfWorldsBossBag = 3320;

		// Token: 0x04005B2F RID: 23343
		public const short BrainOfCthulhuBossBag = 3321;

		// Token: 0x04005B30 RID: 23344
		public const short QueenBeeBossBag = 3322;

		// Token: 0x04005B31 RID: 23345
		public const short SkeletronBossBag = 3323;

		// Token: 0x04005B32 RID: 23346
		public const short WallOfFleshBossBag = 3324;

		// Token: 0x04005B33 RID: 23347
		public const short DestroyerBossBag = 3325;

		// Token: 0x04005B34 RID: 23348
		public const short TwinsBossBag = 3326;

		// Token: 0x04005B35 RID: 23349
		public const short SkeletronPrimeBossBag = 3327;

		// Token: 0x04005B36 RID: 23350
		public const short PlanteraBossBag = 3328;

		// Token: 0x04005B37 RID: 23351
		public const short GolemBossBag = 3329;

		// Token: 0x04005B38 RID: 23352
		public const short FishronBossBag = 3330;

		// Token: 0x04005B39 RID: 23353
		public const short CultistBossBag = 3331;

		// Token: 0x04005B3A RID: 23354
		public const short MoonLordBossBag = 3332;

		// Token: 0x04005B3B RID: 23355
		public const short HiveBackpack = 3333;

		// Token: 0x04005B3C RID: 23356
		public const short YoYoGlove = 3334;

		// Token: 0x04005B3D RID: 23357
		public const short DemonHeart = 3335;

		// Token: 0x04005B3E RID: 23358
		public const short SporeSac = 3336;

		// Token: 0x04005B3F RID: 23359
		public const short ShinyStone = 3337;

		// Token: 0x04005B40 RID: 23360
		public const short HallowHardenedSand = 3338;

		// Token: 0x04005B41 RID: 23361
		public const short HallowSandstone = 3339;

		// Token: 0x04005B42 RID: 23362
		public const short HardenedSandWall = 3340;

		// Token: 0x04005B43 RID: 23363
		public const short CorruptHardenedSandWall = 3341;

		// Token: 0x04005B44 RID: 23364
		public const short CrimsonHardenedSandWall = 3342;

		// Token: 0x04005B45 RID: 23365
		public const short HallowHardenedSandWall = 3343;

		// Token: 0x04005B46 RID: 23366
		public const short CorruptSandstoneWall = 3344;

		// Token: 0x04005B47 RID: 23367
		public const short CrimsonSandstoneWall = 3345;

		// Token: 0x04005B48 RID: 23368
		public const short HallowSandstoneWall = 3346;

		// Token: 0x04005B49 RID: 23369
		public const short DesertFossil = 3347;

		// Token: 0x04005B4A RID: 23370
		public const short DesertFossilWall = 3348;

		// Token: 0x04005B4B RID: 23371
		public const short DyeTradersScimitar = 3349;

		// Token: 0x04005B4C RID: 23372
		public const short PainterPaintballGun = 3350;

		// Token: 0x04005B4D RID: 23373
		public const short TaxCollectorsStickOfDoom = 3351;

		// Token: 0x04005B4E RID: 23374
		public const short StylistKilLaKillScissorsIWish = 3352;

		// Token: 0x04005B4F RID: 23375
		public const short MinecartMech = 3353;

		// Token: 0x04005B50 RID: 23376
		public const short MechanicalWheelPiece = 3354;

		// Token: 0x04005B51 RID: 23377
		public const short MechanicalWagonPiece = 3355;

		// Token: 0x04005B52 RID: 23378
		public const short MechanicalBatteryPiece = 3356;

		// Token: 0x04005B53 RID: 23379
		public const short AncientCultistTrophy = 3357;

		// Token: 0x04005B54 RID: 23380
		public const short MartianSaucerTrophy = 3358;

		// Token: 0x04005B55 RID: 23381
		public const short FlyingDutchmanTrophy = 3359;

		// Token: 0x04005B56 RID: 23382
		public const short LivingMahoganyWand = 3360;

		// Token: 0x04005B57 RID: 23383
		public const short LivingMahoganyLeafWand = 3361;

		// Token: 0x04005B58 RID: 23384
		public const short FallenTuxedoShirt = 3362;

		// Token: 0x04005B59 RID: 23385
		public const short FallenTuxedoPants = 3363;

		// Token: 0x04005B5A RID: 23386
		public const short Fireplace = 3364;

		// Token: 0x04005B5B RID: 23387
		public const short Chimney = 3365;

		// Token: 0x04005B5C RID: 23388
		public const short YoyoBag = 3366;

		// Token: 0x04005B5D RID: 23389
		public const short ShrimpyTruffle = 3367;

		// Token: 0x04005B5E RID: 23390
		public const short Arkhalis = 3368;

		// Token: 0x04005B5F RID: 23391
		public const short ConfettiCannon = 3369;

		// Token: 0x04005B60 RID: 23392
		public const short MusicBoxTowers = 3370;

		// Token: 0x04005B61 RID: 23393
		public const short MusicBoxGoblins = 3371;

		// Token: 0x04005B62 RID: 23394
		public const short BossMaskCultist = 3372;

		// Token: 0x04005B63 RID: 23395
		public const short BossMaskMoonlord = 3373;

		// Token: 0x04005B64 RID: 23396
		public const short FossilHelm = 3374;

		// Token: 0x04005B65 RID: 23397
		public const short FossilShirt = 3375;

		// Token: 0x04005B66 RID: 23398
		public const short FossilPants = 3376;

		// Token: 0x04005B67 RID: 23399
		public const short AmberStaff = 3377;

		// Token: 0x04005B68 RID: 23400
		public const short BoneJavelin = 3378;

		// Token: 0x04005B69 RID: 23401
		public const short BoneDagger = 3379;

		// Token: 0x04005B6A RID: 23402
		public const short FossilOre = 3380;

		// Token: 0x04005B6B RID: 23403
		public const short StardustHelmet = 3381;

		// Token: 0x04005B6C RID: 23404
		public const short StardustBreastplate = 3382;

		// Token: 0x04005B6D RID: 23405
		public const short StardustLeggings = 3383;

		// Token: 0x04005B6E RID: 23406
		public const short PortalGun = 3384;

		// Token: 0x04005B6F RID: 23407
		public const short StrangePlant1 = 3385;

		// Token: 0x04005B70 RID: 23408
		public const short StrangePlant2 = 3386;

		// Token: 0x04005B71 RID: 23409
		public const short StrangePlant3 = 3387;

		// Token: 0x04005B72 RID: 23410
		public const short StrangePlant4 = 3388;

		// Token: 0x04005B73 RID: 23411
		public const short Terrarian = 3389;

		// Token: 0x04005B74 RID: 23412
		public const short GoblinSummonerBanner = 3390;

		// Token: 0x04005B75 RID: 23413
		public const short SalamanderBanner = 3391;

		// Token: 0x04005B76 RID: 23414
		public const short GiantShellyBanner = 3392;

		// Token: 0x04005B77 RID: 23415
		public const short CrawdadBanner = 3393;

		// Token: 0x04005B78 RID: 23416
		public const short FritzBanner = 3394;

		// Token: 0x04005B79 RID: 23417
		public const short CreatureFromTheDeepBanner = 3395;

		// Token: 0x04005B7A RID: 23418
		public const short DrManFlyBanner = 3396;

		// Token: 0x04005B7B RID: 23419
		public const short MothronBanner = 3397;

		// Token: 0x04005B7C RID: 23420
		public const short SeveredHandBanner = 3398;

		// Token: 0x04005B7D RID: 23421
		public const short ThePossessedBanner = 3399;

		// Token: 0x04005B7E RID: 23422
		public const short ButcherBanner = 3400;

		// Token: 0x04005B7F RID: 23423
		public const short PsychoBanner = 3401;

		// Token: 0x04005B80 RID: 23424
		public const short DeadlySphereBanner = 3402;

		// Token: 0x04005B81 RID: 23425
		public const short NailheadBanner = 3403;

		// Token: 0x04005B82 RID: 23426
		public const short PoisonousSporeBanner = 3404;

		// Token: 0x04005B83 RID: 23427
		public const short MedusaBanner = 3405;

		// Token: 0x04005B84 RID: 23428
		public const short GreekSkeletonBanner = 3406;

		// Token: 0x04005B85 RID: 23429
		public const short GraniteFlyerBanner = 3407;

		// Token: 0x04005B86 RID: 23430
		public const short GraniteGolemBanner = 3408;

		// Token: 0x04005B87 RID: 23431
		public const short BloodZombieBanner = 3409;

		// Token: 0x04005B88 RID: 23432
		public const short DripplerBanner = 3410;

		// Token: 0x04005B89 RID: 23433
		public const short TombCrawlerBanner = 3411;

		// Token: 0x04005B8A RID: 23434
		public const short DuneSplicerBanner = 3412;

		// Token: 0x04005B8B RID: 23435
		public const short FlyingAntlionBanner = 3413;

		// Token: 0x04005B8C RID: 23436
		public const short WalkingAntlionBanner = 3414;

		// Token: 0x04005B8D RID: 23437
		public const short DesertGhoulBanner = 3415;

		// Token: 0x04005B8E RID: 23438
		public const short DesertLamiaBanner = 3416;

		// Token: 0x04005B8F RID: 23439
		public const short DesertDjinnBanner = 3417;

		// Token: 0x04005B90 RID: 23440
		public const short DesertBasiliskBanner = 3418;

		// Token: 0x04005B91 RID: 23441
		public const short RavagerScorpionBanner = 3419;

		// Token: 0x04005B92 RID: 23442
		public const short StardustSoldierBanner = 3420;

		// Token: 0x04005B93 RID: 23443
		public const short StardustWormBanner = 3421;

		// Token: 0x04005B94 RID: 23444
		public const short StardustJellyfishBanner = 3422;

		// Token: 0x04005B95 RID: 23445
		public const short StardustSpiderBanner = 3423;

		// Token: 0x04005B96 RID: 23446
		public const short StardustSmallCellBanner = 3424;

		// Token: 0x04005B97 RID: 23447
		public const short StardustLargeCellBanner = 3425;

		// Token: 0x04005B98 RID: 23448
		public const short SolarCoriteBanner = 3426;

		// Token: 0x04005B99 RID: 23449
		public const short SolarSrollerBanner = 3427;

		// Token: 0x04005B9A RID: 23450
		public const short SolarCrawltipedeBanner = 3428;

		// Token: 0x04005B9B RID: 23451
		public const short SolarDrakomireRiderBanner = 3429;

		// Token: 0x04005B9C RID: 23452
		public const short SolarDrakomireBanner = 3430;

		// Token: 0x04005B9D RID: 23453
		public const short SolarSolenianBanner = 3431;

		// Token: 0x04005B9E RID: 23454
		public const short NebulaSoldierBanner = 3432;

		// Token: 0x04005B9F RID: 23455
		public const short NebulaHeadcrabBanner = 3433;

		// Token: 0x04005BA0 RID: 23456
		public const short NebulaBrainBanner = 3434;

		// Token: 0x04005BA1 RID: 23457
		public const short NebulaBeastBanner = 3435;

		// Token: 0x04005BA2 RID: 23458
		public const short VortexLarvaBanner = 3436;

		// Token: 0x04005BA3 RID: 23459
		public const short VortexHornetQueenBanner = 3437;

		// Token: 0x04005BA4 RID: 23460
		public const short VortexHornetBanner = 3438;

		// Token: 0x04005BA5 RID: 23461
		public const short VortexSoldierBanner = 3439;

		// Token: 0x04005BA6 RID: 23462
		public const short VortexRiflemanBanner = 3440;

		// Token: 0x04005BA7 RID: 23463
		public const short PirateCaptainBanner = 3441;

		// Token: 0x04005BA8 RID: 23464
		public const short PirateDeadeyeBanner = 3442;

		// Token: 0x04005BA9 RID: 23465
		public const short PirateCorsairBanner = 3443;

		// Token: 0x04005BAA RID: 23466
		public const short PirateCrossbowerBanner = 3444;

		// Token: 0x04005BAB RID: 23467
		public const short MartianWalkerBanner = 3445;

		// Token: 0x04005BAC RID: 23468
		public const short RedDevilBanner = 3446;

		// Token: 0x04005BAD RID: 23469
		public const short PinkJellyfishBanner = 3447;

		// Token: 0x04005BAE RID: 23470
		public const short GreenJellyfishBanner = 3448;

		// Token: 0x04005BAF RID: 23471
		public const short DarkMummyBanner = 3449;

		// Token: 0x04005BB0 RID: 23472
		public const short LightMummyBanner = 3450;

		// Token: 0x04005BB1 RID: 23473
		public const short AngryBonesBanner = 3451;

		// Token: 0x04005BB2 RID: 23474
		public const short IceTortoiseBanner = 3452;

		// Token: 0x04005BB3 RID: 23475
		public const short NebulaPickup1 = 3453;

		// Token: 0x04005BB4 RID: 23476
		public const short NebulaPickup2 = 3454;

		// Token: 0x04005BB5 RID: 23477
		public const short NebulaPickup3 = 3455;

		// Token: 0x04005BB6 RID: 23478
		public const short FragmentVortex = 3456;

		// Token: 0x04005BB7 RID: 23479
		public const short FragmentNebula = 3457;

		// Token: 0x04005BB8 RID: 23480
		public const short FragmentSolar = 3458;

		// Token: 0x04005BB9 RID: 23481
		public const short FragmentStardust = 3459;

		// Token: 0x04005BBA RID: 23482
		public const short LunarOre = 3460;

		// Token: 0x04005BBB RID: 23483
		public const short LunarBrick = 3461;

		// Token: 0x04005BBC RID: 23484
		public const short StardustAxe = 3462;

		// Token: 0x04005BBD RID: 23485
		public const short StardustChainsaw = 3463;

		// Token: 0x04005BBE RID: 23486
		public const short StardustDrill = 3464;

		// Token: 0x04005BBF RID: 23487
		public const short StardustHammer = 3465;

		// Token: 0x04005BC0 RID: 23488
		public const short StardustPickaxe = 3466;

		// Token: 0x04005BC1 RID: 23489
		public const short LunarBar = 3467;

		// Token: 0x04005BC2 RID: 23490
		public const short WingsSolar = 3468;

		// Token: 0x04005BC3 RID: 23491
		public const short WingsVortex = 3469;

		// Token: 0x04005BC4 RID: 23492
		public const short WingsNebula = 3470;

		// Token: 0x04005BC5 RID: 23493
		public const short WingsStardust = 3471;

		// Token: 0x04005BC6 RID: 23494
		public const short LunarBrickWall = 3472;

		// Token: 0x04005BC7 RID: 23495
		public const short SolarEruption = 3473;

		// Token: 0x04005BC8 RID: 23496
		public const short StardustCellStaff = 3474;

		// Token: 0x04005BC9 RID: 23497
		public const short VortexBeater = 3475;

		// Token: 0x04005BCA RID: 23498
		public const short NebulaArcanum = 3476;

		// Token: 0x04005BCB RID: 23499
		public const short BloodWater = 3477;

		// Token: 0x04005BCC RID: 23500
		public const short TheBrideHat = 3478;

		// Token: 0x04005BCD RID: 23501
		public const short TheBrideDress = 3479;

		// Token: 0x04005BCE RID: 23502
		public const short PlatinumBow = 3480;

		// Token: 0x04005BCF RID: 23503
		public const short PlatinumHammer = 3481;

		// Token: 0x04005BD0 RID: 23504
		public const short PlatinumAxe = 3482;

		// Token: 0x04005BD1 RID: 23505
		public const short PlatinumShortsword = 3483;

		// Token: 0x04005BD2 RID: 23506
		public const short PlatinumBroadsword = 3484;

		// Token: 0x04005BD3 RID: 23507
		public const short PlatinumPickaxe = 3485;

		// Token: 0x04005BD4 RID: 23508
		public const short TungstenBow = 3486;

		// Token: 0x04005BD5 RID: 23509
		public const short TungstenHammer = 3487;

		// Token: 0x04005BD6 RID: 23510
		public const short TungstenAxe = 3488;

		// Token: 0x04005BD7 RID: 23511
		public const short TungstenShortsword = 3489;

		// Token: 0x04005BD8 RID: 23512
		public const short TungstenBroadsword = 3490;

		// Token: 0x04005BD9 RID: 23513
		public const short TungstenPickaxe = 3491;

		// Token: 0x04005BDA RID: 23514
		public const short LeadBow = 3492;

		// Token: 0x04005BDB RID: 23515
		public const short LeadHammer = 3493;

		// Token: 0x04005BDC RID: 23516
		public const short LeadAxe = 3494;

		// Token: 0x04005BDD RID: 23517
		public const short LeadShortsword = 3495;

		// Token: 0x04005BDE RID: 23518
		public const short LeadBroadsword = 3496;

		// Token: 0x04005BDF RID: 23519
		public const short LeadPickaxe = 3497;

		// Token: 0x04005BE0 RID: 23520
		public const short TinBow = 3498;

		// Token: 0x04005BE1 RID: 23521
		public const short TinHammer = 3499;

		// Token: 0x04005BE2 RID: 23522
		public const short TinAxe = 3500;

		// Token: 0x04005BE3 RID: 23523
		public const short TinShortsword = 3501;

		// Token: 0x04005BE4 RID: 23524
		public const short TinBroadsword = 3502;

		// Token: 0x04005BE5 RID: 23525
		public const short TinPickaxe = 3503;

		// Token: 0x04005BE6 RID: 23526
		public const short CopperBow = 3504;

		// Token: 0x04005BE7 RID: 23527
		public const short CopperHammer = 3505;

		// Token: 0x04005BE8 RID: 23528
		public const short CopperAxe = 3506;

		// Token: 0x04005BE9 RID: 23529
		public const short CopperShortsword = 3507;

		// Token: 0x04005BEA RID: 23530
		public const short CopperBroadsword = 3508;

		// Token: 0x04005BEB RID: 23531
		public const short CopperPickaxe = 3509;

		// Token: 0x04005BEC RID: 23532
		public const short SilverBow = 3510;

		// Token: 0x04005BED RID: 23533
		public const short SilverHammer = 3511;

		// Token: 0x04005BEE RID: 23534
		public const short SilverAxe = 3512;

		// Token: 0x04005BEF RID: 23535
		public const short SilverShortsword = 3513;

		// Token: 0x04005BF0 RID: 23536
		public const short SilverBroadsword = 3514;

		// Token: 0x04005BF1 RID: 23537
		public const short SilverPickaxe = 3515;

		// Token: 0x04005BF2 RID: 23538
		public const short GoldBow = 3516;

		// Token: 0x04005BF3 RID: 23539
		public const short GoldHammer = 3517;

		// Token: 0x04005BF4 RID: 23540
		public const short GoldAxe = 3518;

		// Token: 0x04005BF5 RID: 23541
		public const short GoldShortsword = 3519;

		// Token: 0x04005BF6 RID: 23542
		public const short GoldBroadsword = 3520;

		// Token: 0x04005BF7 RID: 23543
		public const short GoldPickaxe = 3521;

		// Token: 0x04005BF8 RID: 23544
		public const short LunarHamaxeSolar = 3522;

		// Token: 0x04005BF9 RID: 23545
		public const short LunarHamaxeVortex = 3523;

		// Token: 0x04005BFA RID: 23546
		public const short LunarHamaxeNebula = 3524;

		// Token: 0x04005BFB RID: 23547
		public const short LunarHamaxeStardust = 3525;

		// Token: 0x04005BFC RID: 23548
		public const short SolarDye = 3526;

		// Token: 0x04005BFD RID: 23549
		public const short NebulaDye = 3527;

		// Token: 0x04005BFE RID: 23550
		public const short VortexDye = 3528;

		// Token: 0x04005BFF RID: 23551
		public const short StardustDye = 3529;

		// Token: 0x04005C00 RID: 23552
		public const short VoidDye = 3530;

		// Token: 0x04005C01 RID: 23553
		public const short StardustDragonStaff = 3531;

		// Token: 0x04005C02 RID: 23554
		public const short Bacon = 3532;

		// Token: 0x04005C03 RID: 23555
		public const short ShiftingSandsDye = 3533;

		// Token: 0x04005C04 RID: 23556
		public const short MirageDye = 3534;

		// Token: 0x04005C05 RID: 23557
		public const short ShiftingPearlSandsDye = 3535;

		// Token: 0x04005C06 RID: 23558
		public const short VortexMonolith = 3536;

		// Token: 0x04005C07 RID: 23559
		public const short NebulaMonolith = 3537;

		// Token: 0x04005C08 RID: 23560
		public const short StardustMonolith = 3538;

		// Token: 0x04005C09 RID: 23561
		public const short SolarMonolith = 3539;

		// Token: 0x04005C0A RID: 23562
		public const short Phantasm = 3540;

		// Token: 0x04005C0B RID: 23563
		public const short LastPrism = 3541;

		// Token: 0x04005C0C RID: 23564
		public const short NebulaBlaze = 3542;

		// Token: 0x04005C0D RID: 23565
		public const short DayBreak = 3543;

		// Token: 0x04005C0E RID: 23566
		public const short SuperHealingPotion = 3544;

		// Token: 0x04005C0F RID: 23567
		public const short Detonator = 3545;

		// Token: 0x04005C10 RID: 23568
		public const short FireworksLauncher = 3546;

		// Token: 0x04005C11 RID: 23569
		public const short BouncyDynamite = 3547;

		// Token: 0x04005C12 RID: 23570
		public const short PartyGirlGrenade = 3548;

		// Token: 0x04005C13 RID: 23571
		public const short LunarCraftingStation = 3549;

		// Token: 0x04005C14 RID: 23572
		public const short FlameAndSilverDye = 3550;

		// Token: 0x04005C15 RID: 23573
		public const short GreenFlameAndSilverDye = 3551;

		// Token: 0x04005C16 RID: 23574
		public const short BlueFlameAndSilverDye = 3552;

		// Token: 0x04005C17 RID: 23575
		public const short ReflectiveCopperDye = 3553;

		// Token: 0x04005C18 RID: 23576
		public const short ReflectiveObsidianDye = 3554;

		// Token: 0x04005C19 RID: 23577
		public const short ReflectiveMetalDye = 3555;

		// Token: 0x04005C1A RID: 23578
		public const short MidnightRainbowDye = 3556;

		// Token: 0x04005C1B RID: 23579
		public const short BlackAndWhiteDye = 3557;

		// Token: 0x04005C1C RID: 23580
		public const short BrightSilverDye = 3558;

		// Token: 0x04005C1D RID: 23581
		public const short SilverAndBlackDye = 3559;

		// Token: 0x04005C1E RID: 23582
		public const short RedAcidDye = 3560;

		// Token: 0x04005C1F RID: 23583
		public const short GelDye = 3561;

		// Token: 0x04005C20 RID: 23584
		public const short PinkGelDye = 3562;

		// Token: 0x04005C21 RID: 23585
		public const short SquirrelRed = 3563;

		// Token: 0x04005C22 RID: 23586
		public const short SquirrelGold = 3564;

		// Token: 0x04005C23 RID: 23587
		public const short SquirrelOrangeCage = 3565;

		// Token: 0x04005C24 RID: 23588
		public const short SquirrelGoldCage = 3566;

		// Token: 0x04005C25 RID: 23589
		public const short MoonlordBullet = 3567;

		// Token: 0x04005C26 RID: 23590
		public const short MoonlordArrow = 3568;

		// Token: 0x04005C27 RID: 23591
		public const short MoonlordTurretStaff = 3569;

		// Token: 0x04005C28 RID: 23592
		public const short LunarFlareBook = 3570;

		// Token: 0x04005C29 RID: 23593
		public const short RainbowCrystalStaff = 3571;

		// Token: 0x04005C2A RID: 23594
		public const short LunarHook = 3572;

		// Token: 0x04005C2B RID: 23595
		public const short LunarBlockSolar = 3573;

		// Token: 0x04005C2C RID: 23596
		public const short LunarBlockVortex = 3574;

		// Token: 0x04005C2D RID: 23597
		public const short LunarBlockNebula = 3575;

		// Token: 0x04005C2E RID: 23598
		public const short LunarBlockStardust = 3576;

		// Token: 0x04005C2F RID: 23599
		public const short SuspiciousLookingTentacle = 3577;

		// Token: 0x04005C30 RID: 23600
		public const short Yoraiz0rShirt = 3578;

		// Token: 0x04005C31 RID: 23601
		public const short Yoraiz0rPants = 3579;

		// Token: 0x04005C32 RID: 23602
		public const short Yoraiz0rWings = 3580;

		// Token: 0x04005C33 RID: 23603
		public const short Yoraiz0rDarkness = 3581;

		// Token: 0x04005C34 RID: 23604
		public const short JimsWings = 3582;

		// Token: 0x04005C35 RID: 23605
		public const short Yoraiz0rHead = 3583;

		// Token: 0x04005C36 RID: 23606
		public const short LivingLeafWall = 3584;

		// Token: 0x04005C37 RID: 23607
		public const short SkiphsHelm = 3585;

		// Token: 0x04005C38 RID: 23608
		public const short SkiphsShirt = 3586;

		// Token: 0x04005C39 RID: 23609
		public const short SkiphsPants = 3587;

		// Token: 0x04005C3A RID: 23610
		public const short SkiphsWings = 3588;

		// Token: 0x04005C3B RID: 23611
		public const short LokisHelm = 3589;

		// Token: 0x04005C3C RID: 23612
		public const short LokisShirt = 3590;

		// Token: 0x04005C3D RID: 23613
		public const short LokisPants = 3591;

		// Token: 0x04005C3E RID: 23614
		public const short LokisWings = 3592;

		// Token: 0x04005C3F RID: 23615
		public const short SandSlimeBanner = 3593;

		// Token: 0x04005C40 RID: 23616
		public const short SeaSnailBanner = 3594;

		// Token: 0x04005C41 RID: 23617
		public const short MoonLordTrophy = 3595;

		// Token: 0x04005C42 RID: 23618
		public const short MoonLordPainting = 3596;

		// Token: 0x04005C43 RID: 23619
		public const short BurningHadesDye = 3597;

		// Token: 0x04005C44 RID: 23620
		public const short GrimDye = 3598;

		// Token: 0x04005C45 RID: 23621
		public const short LokisDye = 3599;

		// Token: 0x04005C46 RID: 23622
		public const short ShadowflameHadesDye = 3600;

		// Token: 0x04005C47 RID: 23623
		public const short CelestialSigil = 3601;

		// Token: 0x04005C48 RID: 23624
		public const short LogicGateLamp_Off = 3602;

		// Token: 0x04005C49 RID: 23625
		public const short LogicGate_AND = 3603;

		// Token: 0x04005C4A RID: 23626
		public const short LogicGate_OR = 3604;

		// Token: 0x04005C4B RID: 23627
		public const short LogicGate_NAND = 3605;

		// Token: 0x04005C4C RID: 23628
		public const short LogicGate_NOR = 3606;

		// Token: 0x04005C4D RID: 23629
		public const short LogicGate_XOR = 3607;

		// Token: 0x04005C4E RID: 23630
		public const short LogicGate_NXOR = 3608;

		// Token: 0x04005C4F RID: 23631
		public const short ConveyorBeltLeft = 3609;

		// Token: 0x04005C50 RID: 23632
		public const short ConveyorBeltRight = 3610;

		// Token: 0x04005C51 RID: 23633
		public const short WireKite = 3611;

		// Token: 0x04005C52 RID: 23634
		public const short YellowWrench = 3612;

		// Token: 0x04005C53 RID: 23635
		public const short LogicSensor_Sun = 3613;

		// Token: 0x04005C54 RID: 23636
		public const short LogicSensor_Moon = 3614;

		// Token: 0x04005C55 RID: 23637
		public const short LogicSensor_Above = 3615;

		// Token: 0x04005C56 RID: 23638
		public const short WirePipe = 3616;

		// Token: 0x04005C57 RID: 23639
		public const short AnnouncementBox = 3617;

		// Token: 0x04005C58 RID: 23640
		public const short LogicGateLamp_On = 3618;

		// Token: 0x04005C59 RID: 23641
		public const short MechanicalLens = 3619;

		// Token: 0x04005C5A RID: 23642
		public const short ActuationRod = 3620;

		// Token: 0x04005C5B RID: 23643
		public const short TeamBlockRed = 3621;

		// Token: 0x04005C5C RID: 23644
		public const short TeamBlockRedPlatform = 3622;

		// Token: 0x04005C5D RID: 23645
		public const short StaticHook = 3623;

		// Token: 0x04005C5E RID: 23646
		public const short ActuationAccessory = 3624;

		// Token: 0x04005C5F RID: 23647
		public const short MulticolorWrench = 3625;

		// Token: 0x04005C60 RID: 23648
		public const short WeightedPressurePlatePink = 3626;

		// Token: 0x04005C61 RID: 23649
		public const short EngineeringHelmet = 3627;

		// Token: 0x04005C62 RID: 23650
		public const short CompanionCube = 3628;

		// Token: 0x04005C63 RID: 23651
		public const short WireBulb = 3629;

		// Token: 0x04005C64 RID: 23652
		public const short WeightedPressurePlateOrange = 3630;

		// Token: 0x04005C65 RID: 23653
		public const short WeightedPressurePlatePurple = 3631;

		// Token: 0x04005C66 RID: 23654
		public const short WeightedPressurePlateCyan = 3632;

		// Token: 0x04005C67 RID: 23655
		public const short TeamBlockGreen = 3633;

		// Token: 0x04005C68 RID: 23656
		public const short TeamBlockBlue = 3634;

		// Token: 0x04005C69 RID: 23657
		public const short TeamBlockYellow = 3635;

		// Token: 0x04005C6A RID: 23658
		public const short TeamBlockPink = 3636;

		// Token: 0x04005C6B RID: 23659
		public const short TeamBlockWhite = 3637;

		// Token: 0x04005C6C RID: 23660
		public const short TeamBlockGreenPlatform = 3638;

		// Token: 0x04005C6D RID: 23661
		public const short TeamBlockBluePlatform = 3639;

		// Token: 0x04005C6E RID: 23662
		public const short TeamBlockYellowPlatform = 3640;

		// Token: 0x04005C6F RID: 23663
		public const short TeamBlockPinkPlatform = 3641;

		// Token: 0x04005C70 RID: 23664
		public const short TeamBlockWhitePlatform = 3642;

		// Token: 0x04005C71 RID: 23665
		public const short LargeAmber = 3643;

		// Token: 0x04005C72 RID: 23666
		public const short GemLockRuby = 3644;

		// Token: 0x04005C73 RID: 23667
		public const short GemLockSapphire = 3645;

		// Token: 0x04005C74 RID: 23668
		public const short GemLockEmerald = 3646;

		// Token: 0x04005C75 RID: 23669
		public const short GemLockTopaz = 3647;

		// Token: 0x04005C76 RID: 23670
		public const short GemLockAmethyst = 3648;

		// Token: 0x04005C77 RID: 23671
		public const short GemLockDiamond = 3649;

		// Token: 0x04005C78 RID: 23672
		public const short GemLockAmber = 3650;

		// Token: 0x04005C79 RID: 23673
		public const short SquirrelStatue = 3651;

		// Token: 0x04005C7A RID: 23674
		public const short ButterflyStatue = 3652;

		// Token: 0x04005C7B RID: 23675
		public const short WormStatue = 3653;

		// Token: 0x04005C7C RID: 23676
		public const short FireflyStatue = 3654;

		// Token: 0x04005C7D RID: 23677
		public const short ScorpionStatue = 3655;

		// Token: 0x04005C7E RID: 23678
		public const short SnailStatue = 3656;

		// Token: 0x04005C7F RID: 23679
		public const short GrasshopperStatue = 3657;

		// Token: 0x04005C80 RID: 23680
		public const short MouseStatue = 3658;

		// Token: 0x04005C81 RID: 23681
		public const short DuckStatue = 3659;

		// Token: 0x04005C82 RID: 23682
		public const short PenguinStatue = 3660;

		// Token: 0x04005C83 RID: 23683
		public const short FrogStatue = 3661;

		// Token: 0x04005C84 RID: 23684
		public const short BuggyStatue = 3662;

		// Token: 0x04005C85 RID: 23685
		public const short LogicGateLamp_Faulty = 3663;

		// Token: 0x04005C86 RID: 23686
		public const short PortalGunStation = 3664;

		// Token: 0x04005C87 RID: 23687
		public const short Fake_Chest = 3665;

		// Token: 0x04005C88 RID: 23688
		public const short Fake_GoldChest = 3666;

		// Token: 0x04005C89 RID: 23689
		public const short Fake_ShadowChest = 3667;

		// Token: 0x04005C8A RID: 23690
		public const short Fake_EbonwoodChest = 3668;

		// Token: 0x04005C8B RID: 23691
		public const short Fake_RichMahoganyChest = 3669;

		// Token: 0x04005C8C RID: 23692
		public const short Fake_PearlwoodChest = 3670;

		// Token: 0x04005C8D RID: 23693
		public const short Fake_IvyChest = 3671;

		// Token: 0x04005C8E RID: 23694
		public const short Fake_IceChest = 3672;

		// Token: 0x04005C8F RID: 23695
		public const short Fake_LivingWoodChest = 3673;

		// Token: 0x04005C90 RID: 23696
		public const short Fake_SkywareChest = 3674;

		// Token: 0x04005C91 RID: 23697
		public const short Fake_ShadewoodChest = 3675;

		// Token: 0x04005C92 RID: 23698
		public const short Fake_WebCoveredChest = 3676;

		// Token: 0x04005C93 RID: 23699
		public const short Fake_LihzahrdChest = 3677;

		// Token: 0x04005C94 RID: 23700
		public const short Fake_WaterChest = 3678;

		// Token: 0x04005C95 RID: 23701
		public const short Fake_JungleChest = 3679;

		// Token: 0x04005C96 RID: 23702
		public const short Fake_CorruptionChest = 3680;

		// Token: 0x04005C97 RID: 23703
		public const short Fake_CrimsonChest = 3681;

		// Token: 0x04005C98 RID: 23704
		public const short Fake_HallowedChest = 3682;

		// Token: 0x04005C99 RID: 23705
		public const short Fake_FrozenChest = 3683;

		// Token: 0x04005C9A RID: 23706
		public const short Fake_DynastyChest = 3684;

		// Token: 0x04005C9B RID: 23707
		public const short Fake_HoneyChest = 3685;

		// Token: 0x04005C9C RID: 23708
		public const short Fake_SteampunkChest = 3686;

		// Token: 0x04005C9D RID: 23709
		public const short Fake_PalmWoodChest = 3687;

		// Token: 0x04005C9E RID: 23710
		public const short Fake_MushroomChest = 3688;

		// Token: 0x04005C9F RID: 23711
		public const short Fake_BorealWoodChest = 3689;

		// Token: 0x04005CA0 RID: 23712
		public const short Fake_SlimeChest = 3690;

		// Token: 0x04005CA1 RID: 23713
		public const short Fake_GreenDungeonChest = 3691;

		// Token: 0x04005CA2 RID: 23714
		public const short Fake_PinkDungeonChest = 3692;

		// Token: 0x04005CA3 RID: 23715
		public const short Fake_BlueDungeonChest = 3693;

		// Token: 0x04005CA4 RID: 23716
		public const short Fake_BoneChest = 3694;

		// Token: 0x04005CA5 RID: 23717
		public const short Fake_CactusChest = 3695;

		// Token: 0x04005CA6 RID: 23718
		public const short Fake_FleshChest = 3696;

		// Token: 0x04005CA7 RID: 23719
		public const short Fake_ObsidianChest = 3697;

		// Token: 0x04005CA8 RID: 23720
		public const short Fake_PumpkinChest = 3698;

		// Token: 0x04005CA9 RID: 23721
		public const short Fake_SpookyChest = 3699;

		// Token: 0x04005CAA RID: 23722
		public const short Fake_GlassChest = 3700;

		// Token: 0x04005CAB RID: 23723
		public const short Fake_MartianChest = 3701;

		// Token: 0x04005CAC RID: 23724
		public const short Fake_MeteoriteChest = 3702;

		// Token: 0x04005CAD RID: 23725
		public const short Fake_GraniteChest = 3703;

		// Token: 0x04005CAE RID: 23726
		public const short Fake_MarbleChest = 3704;

		// Token: 0x04005CAF RID: 23727
		public const short Fake_newchest1 = 3705;

		// Token: 0x04005CB0 RID: 23728
		public const short Fake_newchest2 = 3706;

		// Token: 0x04005CB1 RID: 23729
		public const short ProjectilePressurePad = 3707;

		// Token: 0x04005CB2 RID: 23730
		public const short WallCreeperStatue = 3708;

		// Token: 0x04005CB3 RID: 23731
		public const short UnicornStatue = 3709;

		// Token: 0x04005CB4 RID: 23732
		public const short DripplerStatue = 3710;

		// Token: 0x04005CB5 RID: 23733
		public const short WraithStatue = 3711;

		// Token: 0x04005CB6 RID: 23734
		public const short BoneSkeletonStatue = 3712;

		// Token: 0x04005CB7 RID: 23735
		public const short UndeadVikingStatue = 3713;

		// Token: 0x04005CB8 RID: 23736
		public const short MedusaStatue = 3714;

		// Token: 0x04005CB9 RID: 23737
		public const short HarpyStatue = 3715;

		// Token: 0x04005CBA RID: 23738
		public const short PigronStatue = 3716;

		// Token: 0x04005CBB RID: 23739
		public const short HopliteStatue = 3717;

		// Token: 0x04005CBC RID: 23740
		public const short GraniteGolemStatue = 3718;

		// Token: 0x04005CBD RID: 23741
		public const short ZombieArmStatue = 3719;

		// Token: 0x04005CBE RID: 23742
		public const short BloodZombieStatue = 3720;

		// Token: 0x04005CBF RID: 23743
		public const short AnglerTackleBag = 3721;

		// Token: 0x04005CC0 RID: 23744
		public const short GeyserTrap = 3722;

		// Token: 0x04005CC1 RID: 23745
		public const short UltraBrightCampfire = 3723;

		// Token: 0x04005CC2 RID: 23746
		public const short BoneCampfire = 3724;

		// Token: 0x04005CC3 RID: 23747
		public const short PixelBox = 3725;

		// Token: 0x04005CC4 RID: 23748
		public const short LogicSensor_Water = 3726;

		// Token: 0x04005CC5 RID: 23749
		public const short LogicSensor_Lava = 3727;

		// Token: 0x04005CC6 RID: 23750
		public const short LogicSensor_Honey = 3728;

		// Token: 0x04005CC7 RID: 23751
		public const short LogicSensor_Liquid = 3729;

		// Token: 0x04005CC8 RID: 23752
		public const short PartyBundleOfBalloonsAccessory = 3730;

		// Token: 0x04005CC9 RID: 23753
		public const short PartyBalloonAnimal = 3731;

		// Token: 0x04005CCA RID: 23754
		public const short PartyHat = 3732;

		// Token: 0x04005CCB RID: 23755
		public const short FlowerBoyHat = 3733;

		// Token: 0x04005CCC RID: 23756
		public const short FlowerBoyShirt = 3734;

		// Token: 0x04005CCD RID: 23757
		public const short FlowerBoyPants = 3735;

		// Token: 0x04005CCE RID: 23758
		public const short SillyBalloonPink = 3736;

		// Token: 0x04005CCF RID: 23759
		public const short SillyBalloonPurple = 3737;

		// Token: 0x04005CD0 RID: 23760
		public const short SillyBalloonGreen = 3738;

		// Token: 0x04005CD1 RID: 23761
		public const short SillyStreamerBlue = 3739;

		// Token: 0x04005CD2 RID: 23762
		public const short SillyStreamerGreen = 3740;

		// Token: 0x04005CD3 RID: 23763
		public const short SillyStreamerPink = 3741;

		// Token: 0x04005CD4 RID: 23764
		public const short SillyBalloonMachine = 3742;

		// Token: 0x04005CD5 RID: 23765
		public const short SillyBalloonTiedPink = 3743;

		// Token: 0x04005CD6 RID: 23766
		public const short SillyBalloonTiedPurple = 3744;

		// Token: 0x04005CD7 RID: 23767
		public const short SillyBalloonTiedGreen = 3745;

		// Token: 0x04005CD8 RID: 23768
		public const short Pigronata = 3746;

		// Token: 0x04005CD9 RID: 23769
		public const short PartyMonolith = 3747;

		// Token: 0x04005CDA RID: 23770
		public const short PartyBundleOfBalloonTile = 3748;

		// Token: 0x04005CDB RID: 23771
		public const short PartyPresent = 3749;

		// Token: 0x04005CDC RID: 23772
		public const short SliceOfCake = 3750;

		// Token: 0x04005CDD RID: 23773
		public const short CogWall = 3751;

		// Token: 0x04005CDE RID: 23774
		public const short SandFallWall = 3752;

		// Token: 0x04005CDF RID: 23775
		public const short SnowFallWall = 3753;

		// Token: 0x04005CE0 RID: 23776
		public const short SandFallBlock = 3754;

		// Token: 0x04005CE1 RID: 23777
		public const short SnowFallBlock = 3755;

		// Token: 0x04005CE2 RID: 23778
		public const short SnowCloudBlock = 3756;

		// Token: 0x04005CE3 RID: 23779
		public const short PedguinHat = 3757;

		// Token: 0x04005CE4 RID: 23780
		public const short PedguinShirt = 3758;

		// Token: 0x04005CE5 RID: 23781
		public const short PedguinPants = 3759;

		// Token: 0x04005CE6 RID: 23782
		public const short SillyBalloonPinkWall = 3760;

		// Token: 0x04005CE7 RID: 23783
		public const short SillyBalloonPurpleWall = 3761;

		// Token: 0x04005CE8 RID: 23784
		public const short SillyBalloonGreenWall = 3762;

		// Token: 0x04005CE9 RID: 23785
		public const short AviatorSunglasses = 3763;

		// Token: 0x04005CEA RID: 23786
		public const short BluePhasesaber = 3764;

		// Token: 0x04005CEB RID: 23787
		public const short RedPhasesaber = 3765;

		// Token: 0x04005CEC RID: 23788
		public const short GreenPhasesaber = 3766;

		// Token: 0x04005CED RID: 23789
		public const short PurplePhasesaber = 3767;

		// Token: 0x04005CEE RID: 23790
		public const short WhitePhasesaber = 3768;

		// Token: 0x04005CEF RID: 23791
		public const short YellowPhasesaber = 3769;

		// Token: 0x04005CF0 RID: 23792
		public const short DjinnsCurse = 3770;

		// Token: 0x04005CF1 RID: 23793
		public const short AncientHorn = 3771;

		// Token: 0x04005CF2 RID: 23794
		public const short AntlionClaw = 3772;

		// Token: 0x04005CF3 RID: 23795
		public const short AncientArmorHat = 3773;

		// Token: 0x04005CF4 RID: 23796
		public const short AncientArmorShirt = 3774;

		// Token: 0x04005CF5 RID: 23797
		public const short AncientArmorPants = 3775;

		// Token: 0x04005CF6 RID: 23798
		public const short AncientBattleArmorHat = 3776;

		// Token: 0x04005CF7 RID: 23799
		public const short AncientBattleArmorShirt = 3777;

		// Token: 0x04005CF8 RID: 23800
		public const short AncientBattleArmorPants = 3778;

		// Token: 0x04005CF9 RID: 23801
		public const short SpiritFlame = 3779;

		// Token: 0x04005CFA RID: 23802
		public const short SandElementalBanner = 3780;

		// Token: 0x04005CFB RID: 23803
		public const short PocketMirror = 3781;

		// Token: 0x04005CFC RID: 23804
		public const short MagicSandDropper = 3782;

		// Token: 0x04005CFD RID: 23805
		public const short AncientBattleArmorMaterial = 3783;

		// Token: 0x04005CFE RID: 23806
		public const short LamiaPants = 3784;

		// Token: 0x04005CFF RID: 23807
		public const short LamiaShirt = 3785;

		// Token: 0x04005D00 RID: 23808
		public const short LamiaHat = 3786;

		// Token: 0x04005D01 RID: 23809
		public const short SkyFracture = 3787;

		// Token: 0x04005D02 RID: 23810
		public const short OnyxBlaster = 3788;

		// Token: 0x04005D03 RID: 23811
		public const short SandsharkBanner = 3789;

		// Token: 0x04005D04 RID: 23812
		public const short SandsharkCorruptBanner = 3790;

		// Token: 0x04005D05 RID: 23813
		public const short SandsharkCrimsonBanner = 3791;

		// Token: 0x04005D06 RID: 23814
		public const short SandsharkHallowedBanner = 3792;

		// Token: 0x04005D07 RID: 23815
		public const short TumbleweedBanner = 3793;

		// Token: 0x04005D08 RID: 23816
		public const short AncientCloth = 3794;

		// Token: 0x04005D09 RID: 23817
		public const short DjinnLamp = 3795;

		// Token: 0x04005D0A RID: 23818
		public const short MusicBoxSandstorm = 3796;

		// Token: 0x04005D0B RID: 23819
		public const short ApprenticeHat = 3797;

		// Token: 0x04005D0C RID: 23820
		public const short ApprenticeRobe = 3798;

		// Token: 0x04005D0D RID: 23821
		public const short ApprenticeTrousers = 3799;

		// Token: 0x04005D0E RID: 23822
		public const short SquireGreatHelm = 3800;

		// Token: 0x04005D0F RID: 23823
		public const short SquirePlating = 3801;

		// Token: 0x04005D10 RID: 23824
		public const short SquireGreaves = 3802;

		// Token: 0x04005D11 RID: 23825
		public const short HuntressWig = 3803;

		// Token: 0x04005D12 RID: 23826
		public const short HuntressJerkin = 3804;

		// Token: 0x04005D13 RID: 23827
		public const short HuntressPants = 3805;

		// Token: 0x04005D14 RID: 23828
		public const short MonkBrows = 3806;

		// Token: 0x04005D15 RID: 23829
		public const short MonkShirt = 3807;

		// Token: 0x04005D16 RID: 23830
		public const short MonkPants = 3808;

		// Token: 0x04005D17 RID: 23831
		public const short ApprenticeScarf = 3809;

		// Token: 0x04005D18 RID: 23832
		public const short SquireShield = 3810;

		// Token: 0x04005D19 RID: 23833
		public const short HuntressBuckler = 3811;

		// Token: 0x04005D1A RID: 23834
		public const short MonkBelt = 3812;

		// Token: 0x04005D1B RID: 23835
		public const short DefendersForge = 3813;

		// Token: 0x04005D1C RID: 23836
		public const short WarTable = 3814;

		// Token: 0x04005D1D RID: 23837
		public const short WarTableBanner = 3815;

		// Token: 0x04005D1E RID: 23838
		public const short DD2ElderCrystalStand = 3816;

		// Token: 0x04005D1F RID: 23839
		public const short DefenderMedal = 3817;

		// Token: 0x04005D20 RID: 23840
		public const short DD2FlameburstTowerT1Popper = 3818;

		// Token: 0x04005D21 RID: 23841
		public const short DD2FlameburstTowerT2Popper = 3819;

		// Token: 0x04005D22 RID: 23842
		public const short DD2FlameburstTowerT3Popper = 3820;

		// Token: 0x04005D23 RID: 23843
		public const short AleThrowingGlove = 3821;

		// Token: 0x04005D24 RID: 23844
		public const short DD2EnergyCrystal = 3822;

		// Token: 0x04005D25 RID: 23845
		public const short DD2SquireDemonSword = 3823;

		// Token: 0x04005D26 RID: 23846
		public const short DD2BallistraTowerT1Popper = 3824;

		// Token: 0x04005D27 RID: 23847
		public const short DD2BallistraTowerT2Popper = 3825;

		// Token: 0x04005D28 RID: 23848
		public const short DD2BallistraTowerT3Popper = 3826;

		// Token: 0x04005D29 RID: 23849
		public const short DD2SquireBetsySword = 3827;

		// Token: 0x04005D2A RID: 23850
		public const short DD2ElderCrystal = 3828;

		// Token: 0x04005D2B RID: 23851
		public const short DD2LightningAuraT1Popper = 3829;

		// Token: 0x04005D2C RID: 23852
		public const short DD2LightningAuraT2Popper = 3830;

		// Token: 0x04005D2D RID: 23853
		public const short DD2LightningAuraT3Popper = 3831;

		// Token: 0x04005D2E RID: 23854
		public const short DD2ExplosiveTrapT1Popper = 3832;

		// Token: 0x04005D2F RID: 23855
		public const short DD2ExplosiveTrapT2Popper = 3833;

		// Token: 0x04005D30 RID: 23856
		public const short DD2ExplosiveTrapT3Popper = 3834;

		// Token: 0x04005D31 RID: 23857
		public const short MonkStaffT1 = 3835;

		// Token: 0x04005D32 RID: 23858
		public const short MonkStaffT2 = 3836;

		// Token: 0x04005D33 RID: 23859
		public const short DD2GoblinBomberBanner = 3837;

		// Token: 0x04005D34 RID: 23860
		public const short DD2GoblinBanner = 3838;

		// Token: 0x04005D35 RID: 23861
		public const short DD2SkeletonBanner = 3839;

		// Token: 0x04005D36 RID: 23862
		public const short DD2DrakinBanner = 3840;

		// Token: 0x04005D37 RID: 23863
		public const short DD2KoboldFlyerBanner = 3841;

		// Token: 0x04005D38 RID: 23864
		public const short DD2KoboldBanner = 3842;

		// Token: 0x04005D39 RID: 23865
		public const short DD2WitherBeastBanner = 3843;

		// Token: 0x04005D3A RID: 23866
		public const short DD2WyvernBanner = 3844;

		// Token: 0x04005D3B RID: 23867
		public const short DD2JavelinThrowerBanner = 3845;

		// Token: 0x04005D3C RID: 23868
		public const short DD2LightningBugBanner = 3846;

		// Token: 0x04005D3D RID: 23869
		public const short OgreMask = 3847;

		// Token: 0x04005D3E RID: 23870
		public const short GoblinMask = 3848;

		// Token: 0x04005D3F RID: 23871
		public const short GoblinBomberCap = 3849;

		// Token: 0x04005D40 RID: 23872
		public const short EtherianJavelin = 3850;

		// Token: 0x04005D41 RID: 23873
		public const short KoboldDynamiteBackpack = 3851;

		// Token: 0x04005D42 RID: 23874
		public const short BookStaff = 3852;

		// Token: 0x04005D43 RID: 23875
		public const short BoringBow = 3853;

		// Token: 0x04005D44 RID: 23876
		public const short DD2PhoenixBow = 3854;

		// Token: 0x04005D45 RID: 23877
		public const short DD2PetGato = 3855;

		// Token: 0x04005D46 RID: 23878
		public const short DD2PetGhost = 3856;

		// Token: 0x04005D47 RID: 23879
		public const short DD2PetDragon = 3857;

		// Token: 0x04005D48 RID: 23880
		public const short MonkStaffT3 = 3858;

		// Token: 0x04005D49 RID: 23881
		public const short DD2BetsyBow = 3859;

		// Token: 0x04005D4A RID: 23882
		public const short BossBagBetsy = 3860;

		// Token: 0x04005D4B RID: 23883
		public const short BossBagOgre = 3861;

		// Token: 0x04005D4C RID: 23884
		public const short BossBagDarkMage = 3862;

		// Token: 0x04005D4D RID: 23885
		public const short BossMaskBetsy = 3863;

		// Token: 0x04005D4E RID: 23886
		public const short BossMaskDarkMage = 3864;

		// Token: 0x04005D4F RID: 23887
		public const short BossMaskOgre = 3865;

		// Token: 0x04005D50 RID: 23888
		public const short BossTrophyBetsy = 3866;

		// Token: 0x04005D51 RID: 23889
		public const short BossTrophyDarkmage = 3867;

		// Token: 0x04005D52 RID: 23890
		public const short BossTrophyOgre = 3868;

		// Token: 0x04005D53 RID: 23891
		public const short MusicBoxDD2 = 3869;

		// Token: 0x04005D54 RID: 23892
		public const short ApprenticeStaffT3 = 3870;

		// Token: 0x04005D55 RID: 23893
		public const short SquireAltHead = 3871;

		// Token: 0x04005D56 RID: 23894
		public const short SquireAltShirt = 3872;

		// Token: 0x04005D57 RID: 23895
		public const short SquireAltPants = 3873;

		// Token: 0x04005D58 RID: 23896
		public const short ApprenticeAltHead = 3874;

		// Token: 0x04005D59 RID: 23897
		public const short ApprenticeAltShirt = 3875;

		// Token: 0x04005D5A RID: 23898
		public const short ApprenticeAltPants = 3876;

		// Token: 0x04005D5B RID: 23899
		public const short HuntressAltHead = 3877;

		// Token: 0x04005D5C RID: 23900
		public const short HuntressAltShirt = 3878;

		// Token: 0x04005D5D RID: 23901
		public const short HuntressAltPants = 3879;

		// Token: 0x04005D5E RID: 23902
		public const short MonkAltHead = 3880;

		// Token: 0x04005D5F RID: 23903
		public const short MonkAltShirt = 3881;

		// Token: 0x04005D60 RID: 23904
		public const short MonkAltPants = 3882;

		// Token: 0x04005D61 RID: 23905
		public const short BetsyWings = 3883;

		// Token: 0x04005D62 RID: 23906
		public const short CrystalChest = 3884;

		// Token: 0x04005D63 RID: 23907
		public const short GoldenChest = 3885;

		// Token: 0x04005D64 RID: 23908
		public const short Fake_CrystalChest = 3886;

		// Token: 0x04005D65 RID: 23909
		public const short Fake_GoldenChest = 3887;

		// Token: 0x04005D66 RID: 23910
		public const short CrystalDoor = 3888;

		// Token: 0x04005D67 RID: 23911
		public const short CrystalChair = 3889;

		// Token: 0x04005D68 RID: 23912
		public const short CrystalCandle = 3890;

		// Token: 0x04005D69 RID: 23913
		public const short CrystalLantern = 3891;

		// Token: 0x04005D6A RID: 23914
		public const short CrystalLamp = 3892;

		// Token: 0x04005D6B RID: 23915
		public const short CrystalCandelabra = 3893;

		// Token: 0x04005D6C RID: 23916
		public const short CrystalChandelier = 3894;

		// Token: 0x04005D6D RID: 23917
		public const short CrystalBathtub = 3895;

		// Token: 0x04005D6E RID: 23918
		public const short CrystalSink = 3896;

		// Token: 0x04005D6F RID: 23919
		public const short CrystalBed = 3897;

		// Token: 0x04005D70 RID: 23920
		public const short CrystalClock = 3898;

		// Token: 0x04005D71 RID: 23921
		public const short SkywareClock2 = 3899;

		// Token: 0x04005D72 RID: 23922
		public const short DungeonClockBlue = 3900;

		// Token: 0x04005D73 RID: 23923
		public const short DungeonClockGreen = 3901;

		// Token: 0x04005D74 RID: 23924
		public const short DungeonClockPink = 3902;

		// Token: 0x04005D75 RID: 23925
		public const short CrystalPlatform = 3903;

		// Token: 0x04005D76 RID: 23926
		public const short GoldenPlatform = 3904;

		// Token: 0x04005D77 RID: 23927
		public const short DynastyPlatform = 3905;

		// Token: 0x04005D78 RID: 23928
		public const short LihzahrdPlatform = 3906;

		// Token: 0x04005D79 RID: 23929
		public const short FleshPlatform = 3907;

		// Token: 0x04005D7A RID: 23930
		public const short FrozenPlatform = 3908;

		// Token: 0x04005D7B RID: 23931
		public const short CrystalWorkbench = 3909;

		// Token: 0x04005D7C RID: 23932
		public const short GoldenWorkbench = 3910;

		// Token: 0x04005D7D RID: 23933
		public const short CrystalDresser = 3911;

		// Token: 0x04005D7E RID: 23934
		public const short DynastyDresser = 3912;

		// Token: 0x04005D7F RID: 23935
		public const short FrozenDresser = 3913;

		// Token: 0x04005D80 RID: 23936
		public const short LivingWoodDresser = 3914;

		// Token: 0x04005D81 RID: 23937
		public const short CrystalPiano = 3915;

		// Token: 0x04005D82 RID: 23938
		public const short DynastyPiano = 3916;

		// Token: 0x04005D83 RID: 23939
		public const short CrystalBookCase = 3917;

		// Token: 0x04005D84 RID: 23940
		public const short CrystalSofaHowDoesThatEvenWork = 3918;

		// Token: 0x04005D85 RID: 23941
		public const short DynastySofa = 3919;

		// Token: 0x04005D86 RID: 23942
		public const short CrystalTable = 3920;

		// Token: 0x04005D87 RID: 23943
		public const short ArkhalisHat = 3921;

		// Token: 0x04005D88 RID: 23944
		public const short ArkhalisShirt = 3922;

		// Token: 0x04005D89 RID: 23945
		public const short ArkhalisPants = 3923;

		// Token: 0x04005D8A RID: 23946
		public const short ArkhalisWings = 3924;

		// Token: 0x04005D8B RID: 23947
		public const short LeinforsHat = 3925;

		// Token: 0x04005D8C RID: 23948
		public const short LeinforsShirt = 3926;

		// Token: 0x04005D8D RID: 23949
		public const short LeinforsPants = 3927;

		// Token: 0x04005D8E RID: 23950
		public const short LeinforsWings = 3928;

		// Token: 0x04005D8F RID: 23951
		public const short LeinforsAccessory = 3929;

		// Token: 0x04005D90 RID: 23952
		public const short Celeb2 = 3930;

		// Token: 0x04005D91 RID: 23953
		public const short SpiderBathtub = 3931;

		// Token: 0x04005D92 RID: 23954
		public const short SpiderBed = 3932;

		// Token: 0x04005D93 RID: 23955
		public const short SpiderBookcase = 3933;

		// Token: 0x04005D94 RID: 23956
		public const short SpiderDresser = 3934;

		// Token: 0x04005D95 RID: 23957
		public const short SpiderCandelabra = 3935;

		// Token: 0x04005D96 RID: 23958
		public const short SpiderCandle = 3936;

		// Token: 0x04005D97 RID: 23959
		public const short SpiderChair = 3937;

		// Token: 0x04005D98 RID: 23960
		public const short SpiderChandelier = 3938;

		// Token: 0x04005D99 RID: 23961
		public const short SpiderChest = 3939;

		// Token: 0x04005D9A RID: 23962
		public const short SpiderClock = 3940;

		// Token: 0x04005D9B RID: 23963
		public const short SpiderDoor = 3941;

		// Token: 0x04005D9C RID: 23964
		public const short SpiderLamp = 3942;

		// Token: 0x04005D9D RID: 23965
		public const short SpiderLantern = 3943;

		// Token: 0x04005D9E RID: 23966
		public const short SpiderPiano = 3944;

		// Token: 0x04005D9F RID: 23967
		public const short SpiderPlatform = 3945;

		// Token: 0x04005DA0 RID: 23968
		public const short SpiderSinkSpiderSinkDoesWhateverASpiderSinkDoes = 3946;

		// Token: 0x04005DA1 RID: 23969
		public const short SpiderSofa = 3947;

		// Token: 0x04005DA2 RID: 23970
		public const short SpiderTable = 3948;

		// Token: 0x04005DA3 RID: 23971
		public const short SpiderWorkbench = 3949;

		// Token: 0x04005DA4 RID: 23972
		public const short Fake_SpiderChest = 3950;

		// Token: 0x04005DA5 RID: 23973
		public const short IronBrick = 3951;

		// Token: 0x04005DA6 RID: 23974
		public const short IronBrickWall = 3952;

		// Token: 0x04005DA7 RID: 23975
		public const short LeadBrick = 3953;

		// Token: 0x04005DA8 RID: 23976
		public const short LeadBrickWall = 3954;

		// Token: 0x04005DA9 RID: 23977
		public const short LesionBlock = 3955;

		// Token: 0x04005DAA RID: 23978
		public const short LesionBlockWall = 3956;

		// Token: 0x04005DAB RID: 23979
		public const short LesionPlatform = 3957;

		// Token: 0x04005DAC RID: 23980
		public const short LesionBathtub = 3958;

		// Token: 0x04005DAD RID: 23981
		public const short LesionBed = 3959;

		// Token: 0x04005DAE RID: 23982
		public const short LesionBookcase = 3960;

		// Token: 0x04005DAF RID: 23983
		public const short LesionCandelabra = 3961;

		// Token: 0x04005DB0 RID: 23984
		public const short LesionCandle = 3962;

		// Token: 0x04005DB1 RID: 23985
		public const short LesionChair = 3963;

		// Token: 0x04005DB2 RID: 23986
		public const short LesionChandelier = 3964;

		// Token: 0x04005DB3 RID: 23987
		public const short LesionChest = 3965;

		// Token: 0x04005DB4 RID: 23988
		public const short LesionClock = 3966;

		// Token: 0x04005DB5 RID: 23989
		public const short LesionDoor = 3967;

		// Token: 0x04005DB6 RID: 23990
		public const short LesionDresser = 3968;

		// Token: 0x04005DB7 RID: 23991
		public const short LesionLamp = 3969;

		// Token: 0x04005DB8 RID: 23992
		public const short LesionLantern = 3970;

		// Token: 0x04005DB9 RID: 23993
		public const short LesionPiano = 3971;

		// Token: 0x04005DBA RID: 23994
		public const short LesionSink = 3972;

		// Token: 0x04005DBB RID: 23995
		public const short LesionSofa = 3973;

		// Token: 0x04005DBC RID: 23996
		public const short LesionTable = 3974;

		// Token: 0x04005DBD RID: 23997
		public const short LesionWorkbench = 3975;

		// Token: 0x04005DBE RID: 23998
		public const short Fake_LesionChest = 3976;

		// Token: 0x04005DBF RID: 23999
		public const short HatRack = 3977;

		// Token: 0x04005DC0 RID: 24000
		public const short ColorOnlyDye = 3978;

		// Token: 0x04005DC1 RID: 24001
		public const short WoodenCrateHard = 3979;

		// Token: 0x04005DC2 RID: 24002
		public const short IronCrateHard = 3980;

		// Token: 0x04005DC3 RID: 24003
		public const short GoldenCrateHard = 3981;

		// Token: 0x04005DC4 RID: 24004
		public const short CorruptFishingCrateHard = 3982;

		// Token: 0x04005DC5 RID: 24005
		public const short CrimsonFishingCrateHard = 3983;

		// Token: 0x04005DC6 RID: 24006
		public const short DungeonFishingCrateHard = 3984;

		// Token: 0x04005DC7 RID: 24007
		public const short FloatingIslandFishingCrateHard = 3985;

		// Token: 0x04005DC8 RID: 24008
		public const short HallowedFishingCrateHard = 3986;

		// Token: 0x04005DC9 RID: 24009
		public const short JungleFishingCrateHard = 3987;

		// Token: 0x04005DCA RID: 24010
		public const short DeadMansChest = 3988;

		// Token: 0x04005DCB RID: 24011
		public const short GolfBall = 3989;

		// Token: 0x04005DCC RID: 24012
		public const short AmphibianBoots = 3990;

		// Token: 0x04005DCD RID: 24013
		public const short ArcaneFlower = 3991;

		// Token: 0x04005DCE RID: 24014
		public const short BerserkerGlove = 3992;

		// Token: 0x04005DCF RID: 24015
		public const short FairyBoots = 3993;

		// Token: 0x04005DD0 RID: 24016
		public const short FrogFlipper = 3994;

		// Token: 0x04005DD1 RID: 24017
		public const short FrogGear = 3995;

		// Token: 0x04005DD2 RID: 24018
		public const short FrogWebbing = 3996;

		// Token: 0x04005DD3 RID: 24019
		public const short FrozenShield = 3997;

		// Token: 0x04005DD4 RID: 24020
		public const short HeroShield = 3998;

		// Token: 0x04005DD5 RID: 24021
		public const short LavaSkull = 3999;

		// Token: 0x04005DD6 RID: 24022
		public const short MagnetFlower = 4000;

		// Token: 0x04005DD7 RID: 24023
		public const short ManaCloak = 4001;

		// Token: 0x04005DD8 RID: 24024
		public const short MoltenQuiver = 4002;

		// Token: 0x04005DD9 RID: 24025
		public const short MoltenSkullRose = 4003;

		// Token: 0x04005DDA RID: 24026
		public const short ObsidianSkullRose = 4004;

		// Token: 0x04005DDB RID: 24027
		public const short ReconScope = 4005;

		// Token: 0x04005DDC RID: 24028
		public const short StalkersQuiver = 4006;

		// Token: 0x04005DDD RID: 24029
		public const short StingerNecklace = 4007;

		// Token: 0x04005DDE RID: 24030
		public const short UltrabrightHelmet = 4008;

		// Token: 0x04005DDF RID: 24031
		public const short Apple = 4009;

		// Token: 0x04005DE0 RID: 24032
		public const short ApplePieSlice = 4010;

		// Token: 0x04005DE1 RID: 24033
		public const short ApplePie = 4011;

		// Token: 0x04005DE2 RID: 24034
		public const short BananaSplit = 4012;

		// Token: 0x04005DE3 RID: 24035
		public const short BBQRibs = 4013;

		// Token: 0x04005DE4 RID: 24036
		public const short BunnyStew = 4014;

		// Token: 0x04005DE5 RID: 24037
		public const short Burger = 4015;

		// Token: 0x04005DE6 RID: 24038
		public const short ChickenNugget = 4016;

		// Token: 0x04005DE7 RID: 24039
		public const short ChocolateChipCookie = 4017;

		// Token: 0x04005DE8 RID: 24040
		public const short CreamSoda = 4018;

		// Token: 0x04005DE9 RID: 24041
		public const short Escargot = 4019;

		// Token: 0x04005DEA RID: 24042
		public const short FriedEgg = 4020;

		// Token: 0x04005DEB RID: 24043
		public const short Fries = 4021;

		// Token: 0x04005DEC RID: 24044
		public const short GoldenDelight = 4022;

		// Token: 0x04005DED RID: 24045
		public const short Grapes = 4023;

		// Token: 0x04005DEE RID: 24046
		public const short GrilledSquirrel = 4024;

		// Token: 0x04005DEF RID: 24047
		public const short Hotdog = 4025;

		// Token: 0x04005DF0 RID: 24048
		public const short IceCream = 4026;

		// Token: 0x04005DF1 RID: 24049
		public const short Milkshake = 4027;

		// Token: 0x04005DF2 RID: 24050
		public const short Nachos = 4028;

		// Token: 0x04005DF3 RID: 24051
		public const short Pizza = 4029;

		// Token: 0x04005DF4 RID: 24052
		public const short PotatoChips = 4030;

		// Token: 0x04005DF5 RID: 24053
		public const short RoastedBird = 4031;

		// Token: 0x04005DF6 RID: 24054
		public const short RoastedDuck = 4032;

		// Token: 0x04005DF7 RID: 24055
		public const short SauteedFrogLegs = 4033;

		// Token: 0x04005DF8 RID: 24056
		public const short SeafoodDinner = 4034;

		// Token: 0x04005DF9 RID: 24057
		public const short ShrimpPoBoy = 4035;

		// Token: 0x04005DFA RID: 24058
		public const short Spaghetti = 4036;

		// Token: 0x04005DFB RID: 24059
		public const short Steak = 4037;

		// Token: 0x04005DFC RID: 24060
		public const short MoltenCharm = 4038;

		// Token: 0x04005DFD RID: 24061
		public const short GolfClubIron = 4039;

		// Token: 0x04005DFE RID: 24062
		public const short GolfCup = 4040;

		// Token: 0x04005DFF RID: 24063
		public const short FlowerPacketBlue = 4041;

		// Token: 0x04005E00 RID: 24064
		public const short FlowerPacketMagenta = 4042;

		// Token: 0x04005E01 RID: 24065
		public const short FlowerPacketPink = 4043;

		// Token: 0x04005E02 RID: 24066
		public const short FlowerPacketRed = 4044;

		// Token: 0x04005E03 RID: 24067
		public const short FlowerPacketYellow = 4045;

		// Token: 0x04005E04 RID: 24068
		public const short FlowerPacketViolet = 4046;

		// Token: 0x04005E05 RID: 24069
		public const short FlowerPacketWhite = 4047;

		// Token: 0x04005E06 RID: 24070
		public const short FlowerPacketTallGrass = 4048;

		// Token: 0x04005E07 RID: 24071
		public const short LawnMower = 4049;

		// Token: 0x04005E08 RID: 24072
		public const short CrimstoneBrick = 4050;

		// Token: 0x04005E09 RID: 24073
		public const short SmoothSandstone = 4051;

		// Token: 0x04005E0A RID: 24074
		public const short CrimstoneBrickWall = 4052;

		// Token: 0x04005E0B RID: 24075
		public const short SmoothSandstoneWall = 4053;

		// Token: 0x04005E0C RID: 24076
		public const short BloodMoonMonolith = 4054;

		// Token: 0x04005E0D RID: 24077
		public const short SandBoots = 4055;

		// Token: 0x04005E0E RID: 24078
		public const short AncientChisel = 4056;

		// Token: 0x04005E0F RID: 24079
		public const short CarbonGuitar = 4057;

		// Token: 0x04005E10 RID: 24080
		public const short SkeletonBow = 4058;

		// Token: 0x04005E11 RID: 24081
		public const short FossilPickaxe = 4059;

		// Token: 0x04005E12 RID: 24082
		public const short SuperStarCannon = 4060;

		// Token: 0x04005E13 RID: 24083
		public const short ThunderSpear = 4061;

		// Token: 0x04005E14 RID: 24084
		public const short ThunderStaff = 4062;

		// Token: 0x04005E15 RID: 24085
		public const short DrumSet = 4063;

		// Token: 0x04005E16 RID: 24086
		public const short PicnicTable = 4064;

		// Token: 0x04005E17 RID: 24087
		public const short PicnicTableWithCloth = 4065;

		// Token: 0x04005E18 RID: 24088
		public const short DesertMinecart = 4066;

		// Token: 0x04005E19 RID: 24089
		public const short FishMinecart = 4067;

		// Token: 0x04005E1A RID: 24090
		public const short FairyCritterPink = 4068;

		// Token: 0x04005E1B RID: 24091
		public const short FairyCritterGreen = 4069;

		// Token: 0x04005E1C RID: 24092
		public const short FairyCritterBlue = 4070;

		// Token: 0x04005E1D RID: 24093
		public const short JunoniaShell = 4071;

		// Token: 0x04005E1E RID: 24094
		public const short LightningWhelkShell = 4072;

		// Token: 0x04005E1F RID: 24095
		public const short TulipShell = 4073;

		// Token: 0x04005E20 RID: 24096
		public const short PinWheel = 4074;

		// Token: 0x04005E21 RID: 24097
		public const short WeatherVane = 4075;

		// Token: 0x04005E22 RID: 24098
		public const short VoidVault = 4076;

		// Token: 0x04005E23 RID: 24099
		public const short MusicBoxOceanAlt = 4077;

		// Token: 0x04005E24 RID: 24100
		public const short MusicBoxSlimeRain = 4078;

		// Token: 0x04005E25 RID: 24101
		public const short MusicBoxSpaceAlt = 4079;

		// Token: 0x04005E26 RID: 24102
		public const short MusicBoxTownDay = 4080;

		// Token: 0x04005E27 RID: 24103
		public const short MusicBoxTownNight = 4081;

		// Token: 0x04005E28 RID: 24104
		public const short MusicBoxWindyDay = 4082;

		// Token: 0x04005E29 RID: 24105
		public const short GolfCupFlagWhite = 4083;

		// Token: 0x04005E2A RID: 24106
		public const short GolfCupFlagRed = 4084;

		// Token: 0x04005E2B RID: 24107
		public const short GolfCupFlagGreen = 4085;

		// Token: 0x04005E2C RID: 24108
		public const short GolfCupFlagBlue = 4086;

		// Token: 0x04005E2D RID: 24109
		public const short GolfCupFlagYellow = 4087;

		// Token: 0x04005E2E RID: 24110
		public const short GolfCupFlagPurple = 4088;

		// Token: 0x04005E2F RID: 24111
		public const short GolfTee = 4089;

		// Token: 0x04005E30 RID: 24112
		public const short ShellPileBlock = 4090;

		// Token: 0x04005E31 RID: 24113
		public const short AntiPortalBlock = 4091;

		// Token: 0x04005E32 RID: 24114
		public const short GolfClubPutter = 4092;

		// Token: 0x04005E33 RID: 24115
		public const short GolfClubWedge = 4093;

		// Token: 0x04005E34 RID: 24116
		public const short GolfClubDriver = 4094;

		// Token: 0x04005E35 RID: 24117
		public const short GolfWhistle = 4095;

		// Token: 0x04005E36 RID: 24118
		public const short ToiletEbonyWood = 4096;

		// Token: 0x04005E37 RID: 24119
		public const short ToiletRichMahogany = 4097;

		// Token: 0x04005E38 RID: 24120
		public const short ToiletPearlwood = 4098;

		// Token: 0x04005E39 RID: 24121
		public const short ToiletLivingWood = 4099;

		// Token: 0x04005E3A RID: 24122
		public const short ToiletCactus = 4100;

		// Token: 0x04005E3B RID: 24123
		public const short ToiletBone = 4101;

		// Token: 0x04005E3C RID: 24124
		public const short ToiletFlesh = 4102;

		// Token: 0x04005E3D RID: 24125
		public const short ToiletMushroom = 4103;

		// Token: 0x04005E3E RID: 24126
		public const short ToiletSunplate = 4104;

		// Token: 0x04005E3F RID: 24127
		public const short ToiletShadewood = 4105;

		// Token: 0x04005E40 RID: 24128
		public const short ToiletLihzhard = 4106;

		// Token: 0x04005E41 RID: 24129
		public const short ToiletDungeonBlue = 4107;

		// Token: 0x04005E42 RID: 24130
		public const short ToiletDungeonGreen = 4108;

		// Token: 0x04005E43 RID: 24131
		public const short ToiletDungeonPink = 4109;

		// Token: 0x04005E44 RID: 24132
		public const short ToiletObsidian = 4110;

		// Token: 0x04005E45 RID: 24133
		public const short ToiletFrozen = 4111;

		// Token: 0x04005E46 RID: 24134
		public const short ToiletGlass = 4112;

		// Token: 0x04005E47 RID: 24135
		public const short ToiletHoney = 4113;

		// Token: 0x04005E48 RID: 24136
		public const short ToiletSteampunk = 4114;

		// Token: 0x04005E49 RID: 24137
		public const short ToiletPumpkin = 4115;

		// Token: 0x04005E4A RID: 24138
		public const short ToiletSpooky = 4116;

		// Token: 0x04005E4B RID: 24139
		public const short ToiletDynasty = 4117;

		// Token: 0x04005E4C RID: 24140
		public const short ToiletPalm = 4118;

		// Token: 0x04005E4D RID: 24141
		public const short ToiletBoreal = 4119;

		// Token: 0x04005E4E RID: 24142
		public const short ToiletSlime = 4120;

		// Token: 0x04005E4F RID: 24143
		public const short ToiletMartian = 4121;

		// Token: 0x04005E50 RID: 24144
		public const short ToiletGranite = 4122;

		// Token: 0x04005E51 RID: 24145
		public const short ToiletMarble = 4123;

		// Token: 0x04005E52 RID: 24146
		public const short ToiletCrystal = 4124;

		// Token: 0x04005E53 RID: 24147
		public const short ToiletSpider = 4125;

		// Token: 0x04005E54 RID: 24148
		public const short ToiletLesion = 4126;

		// Token: 0x04005E55 RID: 24149
		public const short ToiletDiamond = 4127;

		// Token: 0x04005E56 RID: 24150
		public const short MaidHead = 4128;

		// Token: 0x04005E57 RID: 24151
		public const short MaidShirt = 4129;

		// Token: 0x04005E58 RID: 24152
		public const short MaidPants = 4130;

		// Token: 0x04005E59 RID: 24153
		public const short VoidLens = 4131;

		// Token: 0x04005E5A RID: 24154
		public const short MaidHead2 = 4132;

		// Token: 0x04005E5B RID: 24155
		public const short MaidShirt2 = 4133;

		// Token: 0x04005E5C RID: 24156
		public const short MaidPants2 = 4134;

		// Token: 0x04005E5D RID: 24157
		public const short GolfHat = 4135;

		// Token: 0x04005E5E RID: 24158
		public const short GolfShirt = 4136;

		// Token: 0x04005E5F RID: 24159
		public const short GolfPants = 4137;

		// Token: 0x04005E60 RID: 24160
		public const short GolfVisor = 4138;

		// Token: 0x04005E61 RID: 24161
		public const short SpiderBlock = 4139;

		// Token: 0x04005E62 RID: 24162
		public const short SpiderWall = 4140;

		// Token: 0x04005E63 RID: 24163
		public const short ToiletMeteor = 4141;

		// Token: 0x04005E64 RID: 24164
		public const short LesionStation = 4142;

		// Token: 0x04005E65 RID: 24165
		public const short ManaCloakStar = 4143;

		// Token: 0x04005E66 RID: 24166
		public const short Terragrim = 4144;

		// Token: 0x04005E67 RID: 24167
		public const short SolarBathtub = 4145;

		// Token: 0x04005E68 RID: 24168
		public const short SolarBed = 4146;

		// Token: 0x04005E69 RID: 24169
		public const short SolarBookcase = 4147;

		// Token: 0x04005E6A RID: 24170
		public const short SolarDresser = 4148;

		// Token: 0x04005E6B RID: 24171
		public const short SolarCandelabra = 4149;

		// Token: 0x04005E6C RID: 24172
		public const short SolarCandle = 4150;

		// Token: 0x04005E6D RID: 24173
		public const short SolarChair = 4151;

		// Token: 0x04005E6E RID: 24174
		public const short SolarChandelier = 4152;

		// Token: 0x04005E6F RID: 24175
		public const short SolarChest = 4153;

		// Token: 0x04005E70 RID: 24176
		public const short SolarClock = 4154;

		// Token: 0x04005E71 RID: 24177
		public const short SolarDoor = 4155;

		// Token: 0x04005E72 RID: 24178
		public const short SolarLamp = 4156;

		// Token: 0x04005E73 RID: 24179
		public const short SolarLantern = 4157;

		// Token: 0x04005E74 RID: 24180
		public const short SolarPiano = 4158;

		// Token: 0x04005E75 RID: 24181
		public const short SolarPlatform = 4159;

		// Token: 0x04005E76 RID: 24182
		public const short SolarSink = 4160;

		// Token: 0x04005E77 RID: 24183
		public const short SolarSofa = 4161;

		// Token: 0x04005E78 RID: 24184
		public const short SolarTable = 4162;

		// Token: 0x04005E79 RID: 24185
		public const short SolarWorkbench = 4163;

		// Token: 0x04005E7A RID: 24186
		public const short Fake_SolarChest = 4164;

		// Token: 0x04005E7B RID: 24187
		public const short SolarToilet = 4165;

		// Token: 0x04005E7C RID: 24188
		public const short VortexBathtub = 4166;

		// Token: 0x04005E7D RID: 24189
		public const short VortexBed = 4167;

		// Token: 0x04005E7E RID: 24190
		public const short VortexBookcase = 4168;

		// Token: 0x04005E7F RID: 24191
		public const short VortexDresser = 4169;

		// Token: 0x04005E80 RID: 24192
		public const short VortexCandelabra = 4170;

		// Token: 0x04005E81 RID: 24193
		public const short VortexCandle = 4171;

		// Token: 0x04005E82 RID: 24194
		public const short VortexChair = 4172;

		// Token: 0x04005E83 RID: 24195
		public const short VortexChandelier = 4173;

		// Token: 0x04005E84 RID: 24196
		public const short VortexChest = 4174;

		// Token: 0x04005E85 RID: 24197
		public const short VortexClock = 4175;

		// Token: 0x04005E86 RID: 24198
		public const short VortexDoor = 4176;

		// Token: 0x04005E87 RID: 24199
		public const short VortexLamp = 4177;

		// Token: 0x04005E88 RID: 24200
		public const short VortexLantern = 4178;

		// Token: 0x04005E89 RID: 24201
		public const short VortexPiano = 4179;

		// Token: 0x04005E8A RID: 24202
		public const short VortexPlatform = 4180;

		// Token: 0x04005E8B RID: 24203
		public const short VortexSink = 4181;

		// Token: 0x04005E8C RID: 24204
		public const short VortexSofa = 4182;

		// Token: 0x04005E8D RID: 24205
		public const short VortexTable = 4183;

		// Token: 0x04005E8E RID: 24206
		public const short VortexWorkbench = 4184;

		// Token: 0x04005E8F RID: 24207
		public const short Fake_VortexChest = 4185;

		// Token: 0x04005E90 RID: 24208
		public const short VortexToilet = 4186;

		// Token: 0x04005E91 RID: 24209
		public const short NebulaBathtub = 4187;

		// Token: 0x04005E92 RID: 24210
		public const short NebulaBed = 4188;

		// Token: 0x04005E93 RID: 24211
		public const short NebulaBookcase = 4189;

		// Token: 0x04005E94 RID: 24212
		public const short NebulaDresser = 4190;

		// Token: 0x04005E95 RID: 24213
		public const short NebulaCandelabra = 4191;

		// Token: 0x04005E96 RID: 24214
		public const short NebulaCandle = 4192;

		// Token: 0x04005E97 RID: 24215
		public const short NebulaChair = 4193;

		// Token: 0x04005E98 RID: 24216
		public const short NebulaChandelier = 4194;

		// Token: 0x04005E99 RID: 24217
		public const short NebulaChest = 4195;

		// Token: 0x04005E9A RID: 24218
		public const short NebulaClock = 4196;

		// Token: 0x04005E9B RID: 24219
		public const short NebulaDoor = 4197;

		// Token: 0x04005E9C RID: 24220
		public const short NebulaLamp = 4198;

		// Token: 0x04005E9D RID: 24221
		public const short NebulaLantern = 4199;

		// Token: 0x04005E9E RID: 24222
		public const short NebulaPiano = 4200;

		// Token: 0x04005E9F RID: 24223
		public const short NebulaPlatform = 4201;

		// Token: 0x04005EA0 RID: 24224
		public const short NebulaSink = 4202;

		// Token: 0x04005EA1 RID: 24225
		public const short NebulaSofa = 4203;

		// Token: 0x04005EA2 RID: 24226
		public const short NebulaTable = 4204;

		// Token: 0x04005EA3 RID: 24227
		public const short NebulaWorkbench = 4205;

		// Token: 0x04005EA4 RID: 24228
		public const short Fake_NebulaChest = 4206;

		// Token: 0x04005EA5 RID: 24229
		public const short NebulaToilet = 4207;

		// Token: 0x04005EA6 RID: 24230
		public const short StardustBathtub = 4208;

		// Token: 0x04005EA7 RID: 24231
		public const short StardustBed = 4209;

		// Token: 0x04005EA8 RID: 24232
		public const short StardustBookcase = 4210;

		// Token: 0x04005EA9 RID: 24233
		public const short StardustDresser = 4211;

		// Token: 0x04005EAA RID: 24234
		public const short StardustCandelabra = 4212;

		// Token: 0x04005EAB RID: 24235
		public const short StardustCandle = 4213;

		// Token: 0x04005EAC RID: 24236
		public const short StardustChair = 4214;

		// Token: 0x04005EAD RID: 24237
		public const short StardustChandelier = 4215;

		// Token: 0x04005EAE RID: 24238
		public const short StardustChest = 4216;

		// Token: 0x04005EAF RID: 24239
		public const short StardustClock = 4217;

		// Token: 0x04005EB0 RID: 24240
		public const short StardustDoor = 4218;

		// Token: 0x04005EB1 RID: 24241
		public const short StardustLamp = 4219;

		// Token: 0x04005EB2 RID: 24242
		public const short StardustLantern = 4220;

		// Token: 0x04005EB3 RID: 24243
		public const short StardustPiano = 4221;

		// Token: 0x04005EB4 RID: 24244
		public const short StardustPlatform = 4222;

		// Token: 0x04005EB5 RID: 24245
		public const short StardustSink = 4223;

		// Token: 0x04005EB6 RID: 24246
		public const short StardustSofa = 4224;

		// Token: 0x04005EB7 RID: 24247
		public const short StardustTable = 4225;

		// Token: 0x04005EB8 RID: 24248
		public const short StardustWorkbench = 4226;

		// Token: 0x04005EB9 RID: 24249
		public const short Fake_StardustChest = 4227;

		// Token: 0x04005EBA RID: 24250
		public const short StardustToilet = 4228;

		// Token: 0x04005EBB RID: 24251
		public const short SolarBrick = 4229;

		// Token: 0x04005EBC RID: 24252
		public const short VortexBrick = 4230;

		// Token: 0x04005EBD RID: 24253
		public const short NebulaBrick = 4231;

		// Token: 0x04005EBE RID: 24254
		public const short StardustBrick = 4232;

		// Token: 0x04005EBF RID: 24255
		public const short SolarBrickWall = 4233;

		// Token: 0x04005EC0 RID: 24256
		public const short VortexBrickWall = 4234;

		// Token: 0x04005EC1 RID: 24257
		public const short NebulaBrickWall = 4235;

		// Token: 0x04005EC2 RID: 24258
		public const short StardustBrickWall = 4236;

		// Token: 0x04005EC3 RID: 24259
		public const short MusicBoxDayRemix = 4237;

		// Token: 0x04005EC4 RID: 24260
		public const short CrackedBlueBrick = 4238;

		// Token: 0x04005EC5 RID: 24261
		public const short CrackedGreenBrick = 4239;

		// Token: 0x04005EC6 RID: 24262
		public const short CrackedPinkBrick = 4240;

		// Token: 0x04005EC7 RID: 24263
		public const short FlowerPacketWild = 4241;

		// Token: 0x04005EC8 RID: 24264
		public const short GolfBallDyedBlack = 4242;

		// Token: 0x04005EC9 RID: 24265
		public const short GolfBallDyedBlue = 4243;

		// Token: 0x04005ECA RID: 24266
		public const short GolfBallDyedBrown = 4244;

		// Token: 0x04005ECB RID: 24267
		public const short GolfBallDyedCyan = 4245;

		// Token: 0x04005ECC RID: 24268
		public const short GolfBallDyedGreen = 4246;

		// Token: 0x04005ECD RID: 24269
		public const short GolfBallDyedLimeGreen = 4247;

		// Token: 0x04005ECE RID: 24270
		public const short GolfBallDyedOrange = 4248;

		// Token: 0x04005ECF RID: 24271
		public const short GolfBallDyedPink = 4249;

		// Token: 0x04005ED0 RID: 24272
		public const short GolfBallDyedPurple = 4250;

		// Token: 0x04005ED1 RID: 24273
		public const short GolfBallDyedRed = 4251;

		// Token: 0x04005ED2 RID: 24274
		public const short GolfBallDyedSkyBlue = 4252;

		// Token: 0x04005ED3 RID: 24275
		public const short GolfBallDyedTeal = 4253;

		// Token: 0x04005ED4 RID: 24276
		public const short GolfBallDyedViolet = 4254;

		// Token: 0x04005ED5 RID: 24277
		public const short GolfBallDyedYellow = 4255;

		// Token: 0x04005ED6 RID: 24278
		public const short AmberRobe = 4256;

		// Token: 0x04005ED7 RID: 24279
		public const short AmberHook = 4257;

		// Token: 0x04005ED8 RID: 24280
		public const short OrangePhaseblade = 4258;

		// Token: 0x04005ED9 RID: 24281
		public const short OrangePhasesaber = 4259;

		// Token: 0x04005EDA RID: 24282
		public const short OrangeStainedGlass = 4260;

		// Token: 0x04005EDB RID: 24283
		public const short OrangePressurePlate = 4261;

		// Token: 0x04005EDC RID: 24284
		public const short MysticCoilSnake = 4262;

		// Token: 0x04005EDD RID: 24285
		public const short MagicConch = 4263;

		// Token: 0x04005EDE RID: 24286
		public const short GolfCart = 4264;

		// Token: 0x04005EDF RID: 24287
		public const short GolfChest = 4265;

		// Token: 0x04005EE0 RID: 24288
		public const short Fake_GolfChest = 4266;

		// Token: 0x04005EE1 RID: 24289
		public const short DesertChest = 4267;

		// Token: 0x04005EE2 RID: 24290
		public const short Fake_DesertChest = 4268;

		// Token: 0x04005EE3 RID: 24291
		public const short SanguineStaff = 4269;

		// Token: 0x04005EE4 RID: 24292
		public const short SharpTears = 4270;

		// Token: 0x04005EE5 RID: 24293
		public const short BloodMoonStarter = 4271;

		// Token: 0x04005EE6 RID: 24294
		public const short DripplerFlail = 4272;

		// Token: 0x04005EE7 RID: 24295
		public const short VampireFrogStaff = 4273;

		// Token: 0x04005EE8 RID: 24296
		public const short GoldGoldfish = 4274;

		// Token: 0x04005EE9 RID: 24297
		public const short GoldGoldfishBowl = 4275;

		// Token: 0x04005EEA RID: 24298
		public const short CatBast = 4276;

		// Token: 0x04005EEB RID: 24299
		public const short GoldStarryGlassBlock = 4277;

		// Token: 0x04005EEC RID: 24300
		public const short BlueStarryGlassBlock = 4278;

		// Token: 0x04005EED RID: 24301
		public const short GoldStarryGlassWall = 4279;

		// Token: 0x04005EEE RID: 24302
		public const short BlueStarryGlassWall = 4280;

		// Token: 0x04005EEF RID: 24303
		public const short BabyBirdStaff = 4281;

		// Token: 0x04005EF0 RID: 24304
		public const short Apricot = 4282;

		// Token: 0x04005EF1 RID: 24305
		public const short Banana = 4283;

		// Token: 0x04005EF2 RID: 24306
		public const short BlackCurrant = 4284;

		// Token: 0x04005EF3 RID: 24307
		public const short BloodOrange = 4285;

		// Token: 0x04005EF4 RID: 24308
		public const short Cherry = 4286;

		// Token: 0x04005EF5 RID: 24309
		public const short Coconut = 4287;

		// Token: 0x04005EF6 RID: 24310
		public const short Dragonfruit = 4288;

		// Token: 0x04005EF7 RID: 24311
		public const short Elderberry = 4289;

		// Token: 0x04005EF8 RID: 24312
		public const short Grapefruit = 4290;

		// Token: 0x04005EF9 RID: 24313
		public const short Lemon = 4291;

		// Token: 0x04005EFA RID: 24314
		public const short Mango = 4292;

		// Token: 0x04005EFB RID: 24315
		public const short Peach = 4293;

		// Token: 0x04005EFC RID: 24316
		public const short Pineapple = 4294;

		// Token: 0x04005EFD RID: 24317
		public const short Plum = 4295;

		// Token: 0x04005EFE RID: 24318
		public const short Rambutan = 4296;

		// Token: 0x04005EFF RID: 24319
		public const short Starfruit = 4297;

		// Token: 0x04005F00 RID: 24320
		public const short SandstoneBathtub = 4298;

		// Token: 0x04005F01 RID: 24321
		public const short SandstoneBed = 4299;

		// Token: 0x04005F02 RID: 24322
		public const short SandstoneBookcase = 4300;

		// Token: 0x04005F03 RID: 24323
		public const short SandstoneDresser = 4301;

		// Token: 0x04005F04 RID: 24324
		public const short SandstoneCandelabra = 4302;

		// Token: 0x04005F05 RID: 24325
		public const short SandstoneCandle = 4303;

		// Token: 0x04005F06 RID: 24326
		public const short SandstoneChair = 4304;

		// Token: 0x04005F07 RID: 24327
		public const short SandstoneChandelier = 4305;

		// Token: 0x04005F08 RID: 24328
		public const short SandstoneClock = 4306;

		// Token: 0x04005F09 RID: 24329
		public const short SandstoneDoor = 4307;

		// Token: 0x04005F0A RID: 24330
		public const short SandstoneLamp = 4308;

		// Token: 0x04005F0B RID: 24331
		public const short SandstoneLantern = 4309;

		// Token: 0x04005F0C RID: 24332
		public const short SandstonePiano = 4310;

		// Token: 0x04005F0D RID: 24333
		public const short SandstonePlatform = 4311;

		// Token: 0x04005F0E RID: 24334
		public const short SandstoneSink = 4312;

		// Token: 0x04005F0F RID: 24335
		public const short SandstoneSofa = 4313;

		// Token: 0x04005F10 RID: 24336
		public const short SandstoneTable = 4314;

		// Token: 0x04005F11 RID: 24337
		public const short SandstoneWorkbench = 4315;

		// Token: 0x04005F12 RID: 24338
		public const short SandstoneToilet = 4316;

		// Token: 0x04005F13 RID: 24339
		public const short BloodHamaxe = 4317;

		// Token: 0x04005F14 RID: 24340
		public const short VoidMonolith = 4318;

		// Token: 0x04005F15 RID: 24341
		public const short ArrowSign = 4319;

		// Token: 0x04005F16 RID: 24342
		public const short PaintedArrowSign = 4320;

		// Token: 0x04005F17 RID: 24343
		public const short GameMasterShirt = 4321;

		// Token: 0x04005F18 RID: 24344
		public const short GameMasterPants = 4322;

		// Token: 0x04005F19 RID: 24345
		public const short StarPrincessCrown = 4323;

		// Token: 0x04005F1A RID: 24346
		public const short StarPrincessDress = 4324;

		// Token: 0x04005F1B RID: 24347
		public const short BloodFishingRod = 4325;

		// Token: 0x04005F1C RID: 24348
		public const short FoodPlatter = 4326;

		// Token: 0x04005F1D RID: 24349
		public const short BlackDragonflyJar = 4327;

		// Token: 0x04005F1E RID: 24350
		public const short BlueDragonflyJar = 4328;

		// Token: 0x04005F1F RID: 24351
		public const short GreenDragonflyJar = 4329;

		// Token: 0x04005F20 RID: 24352
		public const short OrangeDragonflyJar = 4330;

		// Token: 0x04005F21 RID: 24353
		public const short RedDragonflyJar = 4331;

		// Token: 0x04005F22 RID: 24354
		public const short YellowDragonflyJar = 4332;

		// Token: 0x04005F23 RID: 24355
		public const short GoldDragonflyJar = 4333;

		// Token: 0x04005F24 RID: 24356
		public const short BlackDragonfly = 4334;

		// Token: 0x04005F25 RID: 24357
		public const short BlueDragonfly = 4335;

		// Token: 0x04005F26 RID: 24358
		public const short GreenDragonfly = 4336;

		// Token: 0x04005F27 RID: 24359
		public const short OrangeDragonfly = 4337;

		// Token: 0x04005F28 RID: 24360
		public const short RedDragonfly = 4338;

		// Token: 0x04005F29 RID: 24361
		public const short YellowDragonfly = 4339;

		// Token: 0x04005F2A RID: 24362
		public const short GoldDragonfly = 4340;

		// Token: 0x04005F2B RID: 24363
		public const short PortableStool = 4341;

		// Token: 0x04005F2C RID: 24364
		public const short DragonflyStatue = 4342;

		// Token: 0x04005F2D RID: 24365
		public const short PaperAirplaneA = 4343;

		// Token: 0x04005F2E RID: 24366
		public const short PaperAirplaneB = 4344;

		// Token: 0x04005F2F RID: 24367
		public const short CanOfWorms = 4345;

		// Token: 0x04005F30 RID: 24368
		public const short EncumberingStone = 4346;

		// Token: 0x04005F31 RID: 24369
		public const short ZapinatorGray = 4347;

		// Token: 0x04005F32 RID: 24370
		public const short ZapinatorOrange = 4348;

		// Token: 0x04005F33 RID: 24371
		public const short GreenMoss = 4349;

		// Token: 0x04005F34 RID: 24372
		public const short BrownMoss = 4350;

		// Token: 0x04005F35 RID: 24373
		public const short RedMoss = 4351;

		// Token: 0x04005F36 RID: 24374
		public const short BlueMoss = 4352;

		// Token: 0x04005F37 RID: 24375
		public const short PurpleMoss = 4353;

		// Token: 0x04005F38 RID: 24376
		public const short LavaMoss = 4354;

		// Token: 0x04005F39 RID: 24377
		public const short BoulderStatue = 4355;

		// Token: 0x04005F3A RID: 24378
		public const short MusicBoxTitleAlt = 4356;

		// Token: 0x04005F3B RID: 24379
		public const short MusicBoxStorm = 4357;

		// Token: 0x04005F3C RID: 24380
		public const short MusicBoxGraveyard = 4358;

		// Token: 0x04005F3D RID: 24381
		public const short Seagull = 4359;

		// Token: 0x04005F3E RID: 24382
		public const short SeagullStatue = 4360;

		// Token: 0x04005F3F RID: 24383
		public const short LadyBug = 4361;

		// Token: 0x04005F40 RID: 24384
		public const short GoldLadyBug = 4362;

		// Token: 0x04005F41 RID: 24385
		public const short Maggot = 4363;

		// Token: 0x04005F42 RID: 24386
		public const short MaggotCage = 4364;

		// Token: 0x04005F43 RID: 24387
		public const short CelestialWand = 4365;

		// Token: 0x04005F44 RID: 24388
		public const short EucaluptusSap = 4366;

		// Token: 0x04005F45 RID: 24389
		public const short KiteBlue = 4367;

		// Token: 0x04005F46 RID: 24390
		public const short KiteBlueAndYellow = 4368;

		// Token: 0x04005F47 RID: 24391
		public const short KiteRed = 4369;

		// Token: 0x04005F48 RID: 24392
		public const short KiteRedAndYellow = 4370;

		// Token: 0x04005F49 RID: 24393
		public const short KiteYellow = 4371;

		// Token: 0x04005F4A RID: 24394
		public const short IvyGuitar = 4372;

		// Token: 0x04005F4B RID: 24395
		public const short Pupfish = 4373;

		// Token: 0x04005F4C RID: 24396
		public const short Grebe = 4374;

		// Token: 0x04005F4D RID: 24397
		public const short Rat = 4375;

		// Token: 0x04005F4E RID: 24398
		public const short RatCage = 4376;

		// Token: 0x04005F4F RID: 24399
		public const short KryptonMoss = 4377;

		// Token: 0x04005F50 RID: 24400
		public const short XenonMoss = 4378;

		// Token: 0x04005F51 RID: 24401
		public const short KiteWyvern = 4379;

		// Token: 0x04005F52 RID: 24402
		public const short LadybugCage = 4380;

		// Token: 0x04005F53 RID: 24403
		public const short BloodRainBow = 4381;

		// Token: 0x04005F54 RID: 24404
		public const short CombatBook = 4382;

		// Token: 0x04005F55 RID: 24405
		public const short DesertTorch = 4383;

		// Token: 0x04005F56 RID: 24406
		public const short CoralTorch = 4384;

		// Token: 0x04005F57 RID: 24407
		public const short CorruptTorch = 4385;

		// Token: 0x04005F58 RID: 24408
		public const short CrimsonTorch = 4386;

		// Token: 0x04005F59 RID: 24409
		public const short HallowedTorch = 4387;

		// Token: 0x04005F5A RID: 24410
		public const short JungleTorch = 4388;

		// Token: 0x04005F5B RID: 24411
		public const short ArgonMoss = 4389;

		// Token: 0x04005F5C RID: 24412
		public const short RollingCactus = 4390;

		// Token: 0x04005F5D RID: 24413
		public const short ThinIce = 4391;

		// Token: 0x04005F5E RID: 24414
		public const short EchoBlock = 4392;

		// Token: 0x04005F5F RID: 24415
		public const short ScarabFish = 4393;

		// Token: 0x04005F60 RID: 24416
		public const short ScorpioFish = 4394;

		// Token: 0x04005F61 RID: 24417
		public const short Owl = 4395;

		// Token: 0x04005F62 RID: 24418
		public const short OwlCage = 4396;

		// Token: 0x04005F63 RID: 24419
		public const short OwlStatue = 4397;

		// Token: 0x04005F64 RID: 24420
		public const short PupfishBowl = 4398;

		// Token: 0x04005F65 RID: 24421
		public const short GoldLadybugCage = 4399;

		// Token: 0x04005F66 RID: 24422
		public const short Geode = 4400;

		// Token: 0x04005F67 RID: 24423
		public const short Flounder = 4401;

		// Token: 0x04005F68 RID: 24424
		public const short RockLobster = 4402;

		// Token: 0x04005F69 RID: 24425
		public const short LobsterTail = 4403;

		// Token: 0x04005F6A RID: 24426
		public const short FloatingTube = 4404;

		// Token: 0x04005F6B RID: 24427
		public const short FrozenCrate = 4405;

		// Token: 0x04005F6C RID: 24428
		public const short FrozenCrateHard = 4406;

		// Token: 0x04005F6D RID: 24429
		public const short OasisCrate = 4407;

		// Token: 0x04005F6E RID: 24430
		public const short OasisCrateHard = 4408;

		// Token: 0x04005F6F RID: 24431
		public const short SpectreGoggles = 4409;

		// Token: 0x04005F70 RID: 24432
		public const short Oyster = 4410;

		// Token: 0x04005F71 RID: 24433
		public const short ShuckedOyster = 4411;

		// Token: 0x04005F72 RID: 24434
		public const short WhitePearl = 4412;

		// Token: 0x04005F73 RID: 24435
		public const short BlackPearl = 4413;

		// Token: 0x04005F74 RID: 24436
		public const short PinkPearl = 4414;

		// Token: 0x04005F75 RID: 24437
		public const short StoneDoor = 4415;

		// Token: 0x04005F76 RID: 24438
		public const short StonePlatform = 4416;

		// Token: 0x04005F77 RID: 24439
		public const short OasisFountain = 4417;

		// Token: 0x04005F78 RID: 24440
		public const short WaterStrider = 4418;

		// Token: 0x04005F79 RID: 24441
		public const short GoldWaterStrider = 4419;

		// Token: 0x04005F7A RID: 24442
		public const short LawnFlamingo = 4420;

		// Token: 0x04005F7B RID: 24443
		public const short MusicBoxUndergroundJungle = 4421;

		// Token: 0x04005F7C RID: 24444
		public const short Grate = 4422;

		// Token: 0x04005F7D RID: 24445
		public const short ScarabBomb = 4423;

		// Token: 0x04005F7E RID: 24446
		public const short WroughtIronFence = 4424;

		// Token: 0x04005F7F RID: 24447
		public const short SharkBait = 4425;

		// Token: 0x04005F80 RID: 24448
		public const short BeeMinecart = 4426;

		// Token: 0x04005F81 RID: 24449
		public const short LadybugMinecart = 4427;

		// Token: 0x04005F82 RID: 24450
		public const short PigronMinecart = 4428;

		// Token: 0x04005F83 RID: 24451
		public const short SunflowerMinecart = 4429;

		// Token: 0x04005F84 RID: 24452
		public const short PottedForestCedar = 4430;

		// Token: 0x04005F85 RID: 24453
		public const short PottedJungleCedar = 4431;

		// Token: 0x04005F86 RID: 24454
		public const short PottedHallowCedar = 4432;

		// Token: 0x04005F87 RID: 24455
		public const short PottedForestTree = 4433;

		// Token: 0x04005F88 RID: 24456
		public const short PottedJungleTree = 4434;

		// Token: 0x04005F89 RID: 24457
		public const short PottedHallowTree = 4435;

		// Token: 0x04005F8A RID: 24458
		public const short PottedForestPalm = 4436;

		// Token: 0x04005F8B RID: 24459
		public const short PottedJunglePalm = 4437;

		// Token: 0x04005F8C RID: 24460
		public const short PottedHallowPalm = 4438;

		// Token: 0x04005F8D RID: 24461
		public const short PottedForestBamboo = 4439;

		// Token: 0x04005F8E RID: 24462
		public const short PottedJungleBamboo = 4440;

		// Token: 0x04005F8F RID: 24463
		public const short PottedHallowBamboo = 4441;

		// Token: 0x04005F90 RID: 24464
		public const short ScarabFishingRod = 4442;

		// Token: 0x04005F91 RID: 24465
		public const short HellMinecart = 4443;

		// Token: 0x04005F92 RID: 24466
		public const short WitchBroom = 4444;

		// Token: 0x04005F93 RID: 24467
		public const short ClusterRocketI = 4445;

		// Token: 0x04005F94 RID: 24468
		public const short ClusterRocketII = 4446;

		// Token: 0x04005F95 RID: 24469
		public const short WetRocket = 4447;

		// Token: 0x04005F96 RID: 24470
		public const short LavaRocket = 4448;

		// Token: 0x04005F97 RID: 24471
		public const short HoneyRocket = 4449;

		// Token: 0x04005F98 RID: 24472
		public const short ShroomMinecart = 4450;

		// Token: 0x04005F99 RID: 24473
		public const short AmethystMinecart = 4451;

		// Token: 0x04005F9A RID: 24474
		public const short TopazMinecart = 4452;

		// Token: 0x04005F9B RID: 24475
		public const short SapphireMinecart = 4453;

		// Token: 0x04005F9C RID: 24476
		public const short EmeraldMinecart = 4454;

		// Token: 0x04005F9D RID: 24477
		public const short RubyMinecart = 4455;

		// Token: 0x04005F9E RID: 24478
		public const short DiamondMinecart = 4456;

		// Token: 0x04005F9F RID: 24479
		public const short MiniNukeI = 4457;

		// Token: 0x04005FA0 RID: 24480
		public const short MiniNukeII = 4458;

		// Token: 0x04005FA1 RID: 24481
		public const short DryRocket = 4459;

		// Token: 0x04005FA2 RID: 24482
		public const short SandcastleBucket = 4460;

		// Token: 0x04005FA3 RID: 24483
		public const short TurtleCage = 4461;

		// Token: 0x04005FA4 RID: 24484
		public const short TurtleJungleCage = 4462;

		// Token: 0x04005FA5 RID: 24485
		public const short Gladius = 4463;

		// Token: 0x04005FA6 RID: 24486
		public const short Turtle = 4464;

		// Token: 0x04005FA7 RID: 24487
		public const short TurtleJungle = 4465;

		// Token: 0x04005FA8 RID: 24488
		public const short TurtleStatue = 4466;

		// Token: 0x04005FA9 RID: 24489
		public const short AmberMinecart = 4467;

		// Token: 0x04005FAA RID: 24490
		public const short BeetleMinecart = 4468;

		// Token: 0x04005FAB RID: 24491
		public const short MeowmereMinecart = 4469;

		// Token: 0x04005FAC RID: 24492
		public const short PartyMinecart = 4470;

		// Token: 0x04005FAD RID: 24493
		public const short PirateMinecart = 4471;

		// Token: 0x04005FAE RID: 24494
		public const short SteampunkMinecart = 4472;

		// Token: 0x04005FAF RID: 24495
		public const short GrebeCage = 4473;

		// Token: 0x04005FB0 RID: 24496
		public const short SeagullCage = 4474;

		// Token: 0x04005FB1 RID: 24497
		public const short WaterStriderCage = 4475;

		// Token: 0x04005FB2 RID: 24498
		public const short GoldWaterStriderCage = 4476;

		// Token: 0x04005FB3 RID: 24499
		public const short LuckPotionLesser = 4477;

		// Token: 0x04005FB4 RID: 24500
		public const short LuckPotion = 4478;

		// Token: 0x04005FB5 RID: 24501
		public const short LuckPotionGreater = 4479;

		// Token: 0x04005FB6 RID: 24502
		public const short Seahorse = 4480;

		// Token: 0x04005FB7 RID: 24503
		public const short SeahorseCage = 4481;

		// Token: 0x04005FB8 RID: 24504
		public const short GoldSeahorse = 4482;

		// Token: 0x04005FB9 RID: 24505
		public const short GoldSeahorseCage = 4483;

		// Token: 0x04005FBA RID: 24506
		public const short TimerOneHalfSecond = 4484;

		// Token: 0x04005FBB RID: 24507
		public const short TimerOneFourthSecond = 4485;

		// Token: 0x04005FBC RID: 24508
		public const short EbonstoneEcho = 4486;

		// Token: 0x04005FBD RID: 24509
		public const short MudWallEcho = 4487;

		// Token: 0x04005FBE RID: 24510
		public const short PearlstoneEcho = 4488;

		// Token: 0x04005FBF RID: 24511
		public const short SnowWallEcho = 4489;

		// Token: 0x04005FC0 RID: 24512
		public const short AmethystEcho = 4490;

		// Token: 0x04005FC1 RID: 24513
		public const short TopazEcho = 4491;

		// Token: 0x04005FC2 RID: 24514
		public const short SapphireEcho = 4492;

		// Token: 0x04005FC3 RID: 24515
		public const short EmeraldEcho = 4493;

		// Token: 0x04005FC4 RID: 24516
		public const short RubyEcho = 4494;

		// Token: 0x04005FC5 RID: 24517
		public const short DiamondEcho = 4495;

		// Token: 0x04005FC6 RID: 24518
		public const short Cave1Echo = 4496;

		// Token: 0x04005FC7 RID: 24519
		public const short Cave2Echo = 4497;

		// Token: 0x04005FC8 RID: 24520
		public const short Cave3Echo = 4498;

		// Token: 0x04005FC9 RID: 24521
		public const short Cave4Echo = 4499;

		// Token: 0x04005FCA RID: 24522
		public const short Cave5Echo = 4500;

		// Token: 0x04005FCB RID: 24523
		public const short Cave6Echo = 4501;

		// Token: 0x04005FCC RID: 24524
		public const short Cave7Echo = 4502;

		// Token: 0x04005FCD RID: 24525
		public const short SpiderEcho = 4503;

		// Token: 0x04005FCE RID: 24526
		public const short CorruptGrassEcho = 4504;

		// Token: 0x04005FCF RID: 24527
		public const short HallowedGrassEcho = 4505;

		// Token: 0x04005FD0 RID: 24528
		public const short IceEcho = 4506;

		// Token: 0x04005FD1 RID: 24529
		public const short ObsidianBackEcho = 4507;

		// Token: 0x04005FD2 RID: 24530
		public const short CrimsonGrassEcho = 4508;

		// Token: 0x04005FD3 RID: 24531
		public const short CrimstoneEcho = 4509;

		// Token: 0x04005FD4 RID: 24532
		public const short CaveWall1Echo = 4510;

		// Token: 0x04005FD5 RID: 24533
		public const short CaveWall2Echo = 4511;

		// Token: 0x04005FD6 RID: 24534
		public const short Cave8Echo = 4512;

		// Token: 0x04005FD7 RID: 24535
		public const short Corruption1Echo = 4513;

		// Token: 0x04005FD8 RID: 24536
		public const short Corruption2Echo = 4514;

		// Token: 0x04005FD9 RID: 24537
		public const short Corruption3Echo = 4515;

		// Token: 0x04005FDA RID: 24538
		public const short Corruption4Echo = 4516;

		// Token: 0x04005FDB RID: 24539
		public const short Crimson1Echo = 4517;

		// Token: 0x04005FDC RID: 24540
		public const short Crimson2Echo = 4518;

		// Token: 0x04005FDD RID: 24541
		public const short Crimson3Echo = 4519;

		// Token: 0x04005FDE RID: 24542
		public const short Crimson4Echo = 4520;

		// Token: 0x04005FDF RID: 24543
		public const short Dirt1Echo = 4521;

		// Token: 0x04005FE0 RID: 24544
		public const short Dirt2Echo = 4522;

		// Token: 0x04005FE1 RID: 24545
		public const short Dirt3Echo = 4523;

		// Token: 0x04005FE2 RID: 24546
		public const short Dirt4Echo = 4524;

		// Token: 0x04005FE3 RID: 24547
		public const short Hallow1Echo = 4525;

		// Token: 0x04005FE4 RID: 24548
		public const short Hallow2Echo = 4526;

		// Token: 0x04005FE5 RID: 24549
		public const short Hallow3Echo = 4527;

		// Token: 0x04005FE6 RID: 24550
		public const short Hallow4Echo = 4528;

		// Token: 0x04005FE7 RID: 24551
		public const short Jungle1Echo = 4529;

		// Token: 0x04005FE8 RID: 24552
		public const short Jungle2Echo = 4530;

		// Token: 0x04005FE9 RID: 24553
		public const short Jungle3Echo = 4531;

		// Token: 0x04005FEA RID: 24554
		public const short Jungle4Echo = 4532;

		// Token: 0x04005FEB RID: 24555
		public const short Lava1Echo = 4533;

		// Token: 0x04005FEC RID: 24556
		public const short Lava2Echo = 4534;

		// Token: 0x04005FED RID: 24557
		public const short Lava3Echo = 4535;

		// Token: 0x04005FEE RID: 24558
		public const short Lava4Echo = 4536;

		// Token: 0x04005FEF RID: 24559
		public const short Rocks1Echo = 4537;

		// Token: 0x04005FF0 RID: 24560
		public const short Rocks2Echo = 4538;

		// Token: 0x04005FF1 RID: 24561
		public const short Rocks3Echo = 4539;

		// Token: 0x04005FF2 RID: 24562
		public const short Rocks4Echo = 4540;

		// Token: 0x04005FF3 RID: 24563
		public const short TheBrideBanner = 4541;

		// Token: 0x04005FF4 RID: 24564
		public const short ZombieMermanBanner = 4542;

		// Token: 0x04005FF5 RID: 24565
		public const short EyeballFlyingFishBanner = 4543;

		// Token: 0x04005FF6 RID: 24566
		public const short BloodSquidBanner = 4544;

		// Token: 0x04005FF7 RID: 24567
		public const short BloodEelBanner = 4545;

		// Token: 0x04005FF8 RID: 24568
		public const short GoblinSharkBanner = 4546;

		// Token: 0x04005FF9 RID: 24569
		public const short LargeBambooBlock = 4547;

		// Token: 0x04005FFA RID: 24570
		public const short LargeBambooBlockWall = 4548;

		// Token: 0x04005FFB RID: 24571
		public const short DemonHorns = 4549;

		// Token: 0x04005FFC RID: 24572
		public const short BambooLeaf = 4550;

		// Token: 0x04005FFD RID: 24573
		public const short HellCake = 4551;

		// Token: 0x04005FFE RID: 24574
		public const short FogMachine = 4552;

		// Token: 0x04005FFF RID: 24575
		public const short PlasmaLamp = 4553;

		// Token: 0x04006000 RID: 24576
		public const short MarbleColumn = 4554;

		// Token: 0x04006001 RID: 24577
		public const short ChefHat = 4555;

		// Token: 0x04006002 RID: 24578
		public const short ChefShirt = 4556;

		// Token: 0x04006003 RID: 24579
		public const short ChefPants = 4557;

		// Token: 0x04006004 RID: 24580
		public const short StarHairpin = 4558;

		// Token: 0x04006005 RID: 24581
		public const short HeartHairpin = 4559;

		// Token: 0x04006006 RID: 24582
		public const short BunnyEars = 4560;

		// Token: 0x04006007 RID: 24583
		public const short DevilHorns = 4561;

		// Token: 0x04006008 RID: 24584
		public const short Fedora = 4562;

		// Token: 0x04006009 RID: 24585
		public const short UnicornHornHat = 4563;

		// Token: 0x0400600A RID: 24586
		public const short BambooBlock = 4564;

		// Token: 0x0400600B RID: 24587
		public const short BambooBlockWall = 4565;

		// Token: 0x0400600C RID: 24588
		public const short BambooBathtub = 4566;

		// Token: 0x0400600D RID: 24589
		public const short BambooBed = 4567;

		// Token: 0x0400600E RID: 24590
		public const short BambooBookcase = 4568;

		// Token: 0x0400600F RID: 24591
		public const short BambooDresser = 4569;

		// Token: 0x04006010 RID: 24592
		public const short BambooCandelabra = 4570;

		// Token: 0x04006011 RID: 24593
		public const short BambooCandle = 4571;

		// Token: 0x04006012 RID: 24594
		public const short BambooChair = 4572;

		// Token: 0x04006013 RID: 24595
		public const short BambooChandelier = 4573;

		// Token: 0x04006014 RID: 24596
		public const short BambooChest = 4574;

		// Token: 0x04006015 RID: 24597
		public const short BambooClock = 4575;

		// Token: 0x04006016 RID: 24598
		public const short BambooDoor = 4576;

		// Token: 0x04006017 RID: 24599
		public const short BambooLamp = 4577;

		// Token: 0x04006018 RID: 24600
		public const short BambooLantern = 4578;

		// Token: 0x04006019 RID: 24601
		public const short BambooPiano = 4579;

		// Token: 0x0400601A RID: 24602
		public const short BambooPlatform = 4580;

		// Token: 0x0400601B RID: 24603
		public const short BambooSink = 4581;

		// Token: 0x0400601C RID: 24604
		public const short BambooSofa = 4582;

		// Token: 0x0400601D RID: 24605
		public const short BambooTable = 4583;

		// Token: 0x0400601E RID: 24606
		public const short BambooWorkbench = 4584;

		// Token: 0x0400601F RID: 24607
		public const short Fake_BambooChest = 4585;

		// Token: 0x04006020 RID: 24608
		public const short BambooToilet = 4586;

		// Token: 0x04006021 RID: 24609
		public const short GolfClubStoneIron = 4587;

		// Token: 0x04006022 RID: 24610
		public const short GolfClubRustyPutter = 4588;

		// Token: 0x04006023 RID: 24611
		public const short GolfClubBronzeWedge = 4589;

		// Token: 0x04006024 RID: 24612
		public const short GolfClubWoodDriver = 4590;

		// Token: 0x04006025 RID: 24613
		public const short GolfClubMythrilIron = 4591;

		// Token: 0x04006026 RID: 24614
		public const short GolfClubLeadPutter = 4592;

		// Token: 0x04006027 RID: 24615
		public const short GolfClubGoldWedge = 4593;

		// Token: 0x04006028 RID: 24616
		public const short GolfClubPearlwoodDriver = 4594;

		// Token: 0x04006029 RID: 24617
		public const short GolfClubTitaniumIron = 4595;

		// Token: 0x0400602A RID: 24618
		public const short GolfClubShroomitePutter = 4596;

		// Token: 0x0400602B RID: 24619
		public const short GolfClubDiamondWedge = 4597;

		// Token: 0x0400602C RID: 24620
		public const short GolfClubChlorophyteDriver = 4598;

		// Token: 0x0400602D RID: 24621
		public const short GolfTrophyBronze = 4599;

		// Token: 0x0400602E RID: 24622
		public const short GolfTrophySilver = 4600;

		// Token: 0x0400602F RID: 24623
		public const short GolfTrophyGold = 4601;

		// Token: 0x04006030 RID: 24624
		public const short BloodNautilusBanner = 4602;

		// Token: 0x04006031 RID: 24625
		public const short BirdieRattle = 4603;

		// Token: 0x04006032 RID: 24626
		public const short ExoticEasternChewToy = 4604;

		// Token: 0x04006033 RID: 24627
		public const short BedazzledNectar = 4605;

		// Token: 0x04006034 RID: 24628
		public const short MusicBoxJungleNight = 4606;

		// Token: 0x04006035 RID: 24629
		public const short StormTigerStaff = 4607;

		// Token: 0x04006036 RID: 24630
		public const short ChumBucket = 4608;

		// Token: 0x04006037 RID: 24631
		public const short GardenGnome = 4609;

		// Token: 0x04006038 RID: 24632
		public const short KiteBoneSerpent = 4610;

		// Token: 0x04006039 RID: 24633
		public const short KiteWorldFeeder = 4611;

		// Token: 0x0400603A RID: 24634
		public const short KiteBunny = 4612;

		// Token: 0x0400603B RID: 24635
		public const short KitePigron = 4613;

		// Token: 0x0400603C RID: 24636
		public const short AppleJuice = 4614;

		// Token: 0x0400603D RID: 24637
		public const short GrapeJuice = 4615;

		// Token: 0x0400603E RID: 24638
		public const short Lemonade = 4616;

		// Token: 0x0400603F RID: 24639
		public const short BananaDaiquiri = 4617;

		// Token: 0x04006040 RID: 24640
		public const short PeachSangria = 4618;

		// Token: 0x04006041 RID: 24641
		public const short PinaColada = 4619;

		// Token: 0x04006042 RID: 24642
		public const short TropicalSmoothie = 4620;

		// Token: 0x04006043 RID: 24643
		public const short BloodyMoscato = 4621;

		// Token: 0x04006044 RID: 24644
		public const short SmoothieofDarkness = 4622;

		// Token: 0x04006045 RID: 24645
		public const short PrismaticPunch = 4623;

		// Token: 0x04006046 RID: 24646
		public const short FruitJuice = 4624;

		// Token: 0x04006047 RID: 24647
		public const short FruitSalad = 4625;

		// Token: 0x04006048 RID: 24648
		public const short AndrewSphinx = 4626;

		// Token: 0x04006049 RID: 24649
		public const short WatchfulAntlion = 4627;

		// Token: 0x0400604A RID: 24650
		public const short BurningSpirit = 4628;

		// Token: 0x0400604B RID: 24651
		public const short JawsOfDeath = 4629;

		// Token: 0x0400604C RID: 24652
		public const short TheSandsOfSlime = 4630;

		// Token: 0x0400604D RID: 24653
		public const short SnakesIHateSnakes = 4631;

		// Token: 0x0400604E RID: 24654
		public const short LifeAboveTheSand = 4632;

		// Token: 0x0400604F RID: 24655
		public const short Oasis = 4633;

		// Token: 0x04006050 RID: 24656
		public const short PrehistoryPreserved = 4634;

		// Token: 0x04006051 RID: 24657
		public const short AncientTablet = 4635;

		// Token: 0x04006052 RID: 24658
		public const short Uluru = 4636;

		// Token: 0x04006053 RID: 24659
		public const short VisitingThePyramids = 4637;

		// Token: 0x04006054 RID: 24660
		public const short BandageBoy = 4638;

		// Token: 0x04006055 RID: 24661
		public const short DivineEye = 4639;

		// Token: 0x04006056 RID: 24662
		public const short AmethystStoneBlock = 4640;

		// Token: 0x04006057 RID: 24663
		public const short TopazStoneBlock = 4641;

		// Token: 0x04006058 RID: 24664
		public const short SapphireStoneBlock = 4642;

		// Token: 0x04006059 RID: 24665
		public const short EmeraldStoneBlock = 4643;

		// Token: 0x0400605A RID: 24666
		public const short RubyStoneBlock = 4644;

		// Token: 0x0400605B RID: 24667
		public const short DiamondStoneBlock = 4645;

		// Token: 0x0400605C RID: 24668
		public const short AmberStoneBlock = 4646;

		// Token: 0x0400605D RID: 24669
		public const short AmberStoneWallEcho = 4647;

		// Token: 0x0400605E RID: 24670
		public const short KiteManEater = 4648;

		// Token: 0x0400605F RID: 24671
		public const short KiteJellyfishBlue = 4649;

		// Token: 0x04006060 RID: 24672
		public const short KiteJellyfishPink = 4650;

		// Token: 0x04006061 RID: 24673
		public const short KiteShark = 4651;

		// Token: 0x04006062 RID: 24674
		public const short SuperHeroMask = 4652;

		// Token: 0x04006063 RID: 24675
		public const short SuperHeroCostume = 4653;

		// Token: 0x04006064 RID: 24676
		public const short SuperHeroTights = 4654;

		// Token: 0x04006065 RID: 24677
		public const short PinkFairyJar = 4655;

		// Token: 0x04006066 RID: 24678
		public const short GreenFairyJar = 4656;

		// Token: 0x04006067 RID: 24679
		public const short BlueFairyJar = 4657;

		// Token: 0x04006068 RID: 24680
		public const short GolfPainting1 = 4658;

		// Token: 0x04006069 RID: 24681
		public const short GolfPainting2 = 4659;

		// Token: 0x0400606A RID: 24682
		public const short GolfPainting3 = 4660;

		// Token: 0x0400606B RID: 24683
		public const short GolfPainting4 = 4661;

		// Token: 0x0400606C RID: 24684
		public const short FogboundDye = 4662;

		// Token: 0x0400606D RID: 24685
		public const short BloodbathDye = 4663;

		// Token: 0x0400606E RID: 24686
		public const short PrettyPinkDressSkirt = 4664;

		// Token: 0x0400606F RID: 24687
		public const short PrettyPinkDressPants = 4665;

		// Token: 0x04006070 RID: 24688
		public const short PrettyPinkRibbon = 4666;

		// Token: 0x04006071 RID: 24689
		public const short BambooFence = 4667;

		// Token: 0x04006072 RID: 24690
		public const short GlowPaint = 4668;

		// Token: 0x04006073 RID: 24691
		public const short KiteSandShark = 4669;

		// Token: 0x04006074 RID: 24692
		public const short KiteBunnyCorrupt = 4670;

		// Token: 0x04006075 RID: 24693
		public const short KiteBunnyCrimson = 4671;

		// Token: 0x04006076 RID: 24694
		public const short BlandWhip = 4672;

		// Token: 0x04006077 RID: 24695
		public const short DrumStick = 4673;

		// Token: 0x04006078 RID: 24696
		public const short KiteGoldfish = 4674;

		// Token: 0x04006079 RID: 24697
		public const short KiteAngryTrapper = 4675;

		// Token: 0x0400607A RID: 24698
		public const short KiteKoi = 4676;

		// Token: 0x0400607B RID: 24699
		public const short KiteCrawltipede = 4677;

		// Token: 0x0400607C RID: 24700
		public const short SwordWhip = 4678;

		// Token: 0x0400607D RID: 24701
		public const short MaceWhip = 4679;

		// Token: 0x0400607E RID: 24702
		public const short ScytheWhip = 4680;

		// Token: 0x0400607F RID: 24703
		public const short KiteSpectrum = 4681;

		// Token: 0x04006080 RID: 24704
		public const short ReleaseDoves = 4682;

		// Token: 0x04006081 RID: 24705
		public const short KiteWanderingEye = 4683;

		// Token: 0x04006082 RID: 24706
		public const short KiteUnicorn = 4684;

		// Token: 0x04006083 RID: 24707
		public const short UndertakerHat = 4685;

		// Token: 0x04006084 RID: 24708
		public const short UndertakerCoat = 4686;

		// Token: 0x04006085 RID: 24709
		public const short DandelionBanner = 4687;

		// Token: 0x04006086 RID: 24710
		public const short GnomeBanner = 4688;

		// Token: 0x04006087 RID: 24711
		public const short DesertCampfire = 4689;

		// Token: 0x04006088 RID: 24712
		public const short CoralCampfire = 4690;

		// Token: 0x04006089 RID: 24713
		public const short CorruptCampfire = 4691;

		// Token: 0x0400608A RID: 24714
		public const short CrimsonCampfire = 4692;

		// Token: 0x0400608B RID: 24715
		public const short HallowedCampfire = 4693;

		// Token: 0x0400608C RID: 24716
		public const short JungleCampfire = 4694;

		// Token: 0x0400608D RID: 24717
		public const short SoulBottleLight = 4695;

		// Token: 0x0400608E RID: 24718
		public const short SoulBottleNight = 4696;

		// Token: 0x0400608F RID: 24719
		public const short SoulBottleFlight = 4697;

		// Token: 0x04006090 RID: 24720
		public const short SoulBottleSight = 4698;

		// Token: 0x04006091 RID: 24721
		public const short SoulBottleMight = 4699;

		// Token: 0x04006092 RID: 24722
		public const short SoulBottleFright = 4700;

		// Token: 0x04006093 RID: 24723
		public const short MudBud = 4701;

		// Token: 0x04006094 RID: 24724
		public const short ReleaseLantern = 4702;

		// Token: 0x04006095 RID: 24725
		public const short QuadBarrelShotgun = 4703;

		// Token: 0x04006096 RID: 24726
		public const short FuneralHat = 4704;

		// Token: 0x04006097 RID: 24727
		public const short FuneralCoat = 4705;

		// Token: 0x04006098 RID: 24728
		public const short FuneralPants = 4706;

		// Token: 0x04006099 RID: 24729
		public const short TragicUmbrella = 4707;

		// Token: 0x0400609A RID: 24730
		public const short VictorianGothHat = 4708;

		// Token: 0x0400609B RID: 24731
		public const short VictorianGothDress = 4709;

		// Token: 0x0400609C RID: 24732
		public const short TatteredWoodSign = 4710;

		// Token: 0x0400609D RID: 24733
		public const short GravediggerShovel = 4711;

		// Token: 0x0400609E RID: 24734
		public const short DungeonDesertChest = 4712;

		// Token: 0x0400609F RID: 24735
		public const short Fake_DungeonDesertChest = 4713;

		// Token: 0x040060A0 RID: 24736
		public const short DungeonDesertKey = 4714;

		// Token: 0x040060A1 RID: 24737
		public const short SparkleGuitar = 4715;

		// Token: 0x040060A2 RID: 24738
		public const short MolluskWhistle = 4716;

		// Token: 0x040060A3 RID: 24739
		public const short BorealBeam = 4717;

		// Token: 0x040060A4 RID: 24740
		public const short RichMahoganyBeam = 4718;

		// Token: 0x040060A5 RID: 24741
		public const short GraniteColumn = 4719;

		// Token: 0x040060A6 RID: 24742
		public const short SandstoneColumn = 4720;

		// Token: 0x040060A7 RID: 24743
		public const short MushroomBeam = 4721;

		// Token: 0x040060A8 RID: 24744
		public const short FirstFractal = 4722;

		// Token: 0x040060A9 RID: 24745
		public const short Nevermore = 4723;

		// Token: 0x040060AA RID: 24746
		public const short Reborn = 4724;

		// Token: 0x040060AB RID: 24747
		public const short Graveyard = 4725;

		// Token: 0x040060AC RID: 24748
		public const short GhostManifestation = 4726;

		// Token: 0x040060AD RID: 24749
		public const short WickedUndead = 4727;

		// Token: 0x040060AE RID: 24750
		public const short BloodyGoblet = 4728;

		// Token: 0x040060AF RID: 24751
		public const short StillLife = 4729;

		// Token: 0x040060B0 RID: 24752
		public const short GhostarsWings = 4730;

		// Token: 0x040060B1 RID: 24753
		public const short TerraToilet = 4731;

		// Token: 0x040060B2 RID: 24754
		public const short GhostarSkullPin = 4732;

		// Token: 0x040060B3 RID: 24755
		public const short GhostarShirt = 4733;

		// Token: 0x040060B4 RID: 24756
		public const short GhostarPants = 4734;

		// Token: 0x040060B5 RID: 24757
		public const short BallOfFuseWire = 4735;

		// Token: 0x040060B6 RID: 24758
		public const short FullMoonSqueakyToy = 4736;

		// Token: 0x040060B7 RID: 24759
		public const short OrnateShadowKey = 4737;

		// Token: 0x040060B8 RID: 24760
		public const short DrManFlyMask = 4738;

		// Token: 0x040060B9 RID: 24761
		public const short DrManFlyLabCoat = 4739;

		// Token: 0x040060BA RID: 24762
		public const short ButcherMask = 4740;

		// Token: 0x040060BB RID: 24763
		public const short ButcherApron = 4741;

		// Token: 0x040060BC RID: 24764
		public const short ButcherPants = 4742;

		// Token: 0x040060BD RID: 24765
		public const short Football = 4743;

		// Token: 0x040060BE RID: 24766
		public const short HunterCloak = 4744;

		// Token: 0x040060BF RID: 24767
		public const short CoffinMinecart = 4745;

		// Token: 0x040060C0 RID: 24768
		public const short SafemanWings = 4746;

		// Token: 0x040060C1 RID: 24769
		public const short SafemanSunHair = 4747;

		// Token: 0x040060C2 RID: 24770
		public const short SafemanSunDress = 4748;

		// Token: 0x040060C3 RID: 24771
		public const short SafemanDressLeggings = 4749;

		// Token: 0x040060C4 RID: 24772
		public const short FoodBarbarianWings = 4750;

		// Token: 0x040060C5 RID: 24773
		public const short FoodBarbarianHelm = 4751;

		// Token: 0x040060C6 RID: 24774
		public const short FoodBarbarianArmor = 4752;

		// Token: 0x040060C7 RID: 24775
		public const short FoodBarbarianGreaves = 4753;

		// Token: 0x040060C8 RID: 24776
		public const short GroxTheGreatWings = 4754;

		// Token: 0x040060C9 RID: 24777
		public const short GroxTheGreatHelm = 4755;

		// Token: 0x040060CA RID: 24778
		public const short GroxTheGreatArmor = 4756;

		// Token: 0x040060CB RID: 24779
		public const short GroxTheGreatGreaves = 4757;

		// Token: 0x040060CC RID: 24780
		public const short Smolstar = 4758;

		// Token: 0x040060CD RID: 24781
		public const short SquirrelHook = 4759;

		// Token: 0x040060CE RID: 24782
		public const short BouncingShield = 4760;

		// Token: 0x040060CF RID: 24783
		public const short RockGolemHead = 4761;

		// Token: 0x040060D0 RID: 24784
		public const short CritterShampoo = 4762;

		// Token: 0x040060D1 RID: 24785
		public const short DiggingMoleMinecart = 4763;

		// Token: 0x040060D2 RID: 24786
		public const short Shroomerang = 4764;

		// Token: 0x040060D3 RID: 24787
		public const short TreeGlobe = 4765;

		// Token: 0x040060D4 RID: 24788
		public const short WorldGlobe = 4766;

		// Token: 0x040060D5 RID: 24789
		public const short DontHurtCrittersBook = 4767;

		// Token: 0x040060D6 RID: 24790
		public const short DogEars = 4768;

		// Token: 0x040060D7 RID: 24791
		public const short DogTail = 4769;

		// Token: 0x040060D8 RID: 24792
		public const short FoxEars = 4770;

		// Token: 0x040060D9 RID: 24793
		public const short FoxTail = 4771;

		// Token: 0x040060DA RID: 24794
		public const short LizardEars = 4772;

		// Token: 0x040060DB RID: 24795
		public const short LizardTail = 4773;

		// Token: 0x040060DC RID: 24796
		public const short PandaEars = 4774;

		// Token: 0x040060DD RID: 24797
		public const short BunnyTail = 4775;

		// Token: 0x040060DE RID: 24798
		public const short FairyGlowstick = 4776;

		// Token: 0x040060DF RID: 24799
		public const short LightningCarrot = 4777;

		// Token: 0x040060E0 RID: 24800
		public const short HallowBossDye = 4778;

		// Token: 0x040060E1 RID: 24801
		public const short MushroomHat = 4779;

		// Token: 0x040060E2 RID: 24802
		public const short MushroomVest = 4780;

		// Token: 0x040060E3 RID: 24803
		public const short MushroomPants = 4781;

		// Token: 0x040060E4 RID: 24804
		public const short FairyQueenBossBag = 4782;

		// Token: 0x040060E5 RID: 24805
		public const short FairyQueenTrophy = 4783;

		// Token: 0x040060E6 RID: 24806
		public const short FairyQueenMask = 4784;

		// Token: 0x040060E7 RID: 24807
		public const short PaintedHorseSaddle = 4785;

		// Token: 0x040060E8 RID: 24808
		public const short MajesticHorseSaddle = 4786;

		// Token: 0x040060E9 RID: 24809
		public const short DarkHorseSaddle = 4787;

		// Token: 0x040060EA RID: 24810
		public const short JoustingLance = 4788;

		// Token: 0x040060EB RID: 24811
		public const short ShadowJoustingLance = 4789;

		// Token: 0x040060EC RID: 24812
		public const short HallowJoustingLance = 4790;

		// Token: 0x040060ED RID: 24813
		public const short PogoStick = 4791;

		// Token: 0x040060EE RID: 24814
		public const short PirateShipMountItem = 4792;

		// Token: 0x040060EF RID: 24815
		public const short SpookyWoodMountItem = 4793;

		// Token: 0x040060F0 RID: 24816
		public const short SantankMountItem = 4794;

		// Token: 0x040060F1 RID: 24817
		public const short WallOfFleshGoatMountItem = 4795;

		// Token: 0x040060F2 RID: 24818
		public const short DarkMageBookMountItem = 4796;

		// Token: 0x040060F3 RID: 24819
		public const short KingSlimePetItem = 4797;

		// Token: 0x040060F4 RID: 24820
		public const short EyeOfCthulhuPetItem = 4798;

		// Token: 0x040060F5 RID: 24821
		public const short EaterOfWorldsPetItem = 4799;

		// Token: 0x040060F6 RID: 24822
		public const short BrainOfCthulhuPetItem = 4800;

		// Token: 0x040060F7 RID: 24823
		public const short SkeletronPetItem = 4801;

		// Token: 0x040060F8 RID: 24824
		public const short QueenBeePetItem = 4802;

		// Token: 0x040060F9 RID: 24825
		public const short DestroyerPetItem = 4803;

		// Token: 0x040060FA RID: 24826
		public const short TwinsPetItem = 4804;

		// Token: 0x040060FB RID: 24827
		public const short SkeletronPrimePetItem = 4805;

		// Token: 0x040060FC RID: 24828
		public const short PlanteraPetItem = 4806;

		// Token: 0x040060FD RID: 24829
		public const short GolemPetItem = 4807;

		// Token: 0x040060FE RID: 24830
		public const short DukeFishronPetItem = 4808;

		// Token: 0x040060FF RID: 24831
		public const short LunaticCultistPetItem = 4809;

		// Token: 0x04006100 RID: 24832
		public const short MoonLordPetItem = 4810;

		// Token: 0x04006101 RID: 24833
		public const short FairyQueenPetItem = 4811;

		// Token: 0x04006102 RID: 24834
		public const short PumpkingPetItem = 4812;

		// Token: 0x04006103 RID: 24835
		public const short EverscreamPetItem = 4813;

		// Token: 0x04006104 RID: 24836
		public const short IceQueenPetItem = 4814;

		// Token: 0x04006105 RID: 24837
		public const short MartianPetItem = 4815;

		// Token: 0x04006106 RID: 24838
		public const short DD2OgrePetItem = 4816;

		// Token: 0x04006107 RID: 24839
		public const short DD2BetsyPetItem = 4817;

		// Token: 0x04006108 RID: 24840
		public const short CombatWrench = 4818;

		// Token: 0x04006109 RID: 24841
		public const short DemonConch = 4819;

		// Token: 0x0400610A RID: 24842
		public const short BottomlessLavaBucket = 4820;

		// Token: 0x0400610B RID: 24843
		public const short FireproofBugNet = 4821;

		// Token: 0x0400610C RID: 24844
		public const short FlameWakerBoots = 4822;

		// Token: 0x0400610D RID: 24845
		public const short RainbowWings = 4823;

		// Token: 0x0400610E RID: 24846
		public const short WetBomb = 4824;

		// Token: 0x0400610F RID: 24847
		public const short LavaBomb = 4825;

		// Token: 0x04006110 RID: 24848
		public const short HoneyBomb = 4826;

		// Token: 0x04006111 RID: 24849
		public const short DryBomb = 4827;

		// Token: 0x04006112 RID: 24850
		public const short SuperheatedBlood = 4828;

		// Token: 0x04006113 RID: 24851
		public const short LicenseCat = 4829;

		// Token: 0x04006114 RID: 24852
		public const short LicenseDog = 4830;

		// Token: 0x04006115 RID: 24853
		public const short GemSquirrelAmethyst = 4831;

		// Token: 0x04006116 RID: 24854
		public const short GemSquirrelTopaz = 4832;

		// Token: 0x04006117 RID: 24855
		public const short GemSquirrelSapphire = 4833;

		// Token: 0x04006118 RID: 24856
		public const short GemSquirrelEmerald = 4834;

		// Token: 0x04006119 RID: 24857
		public const short GemSquirrelRuby = 4835;

		// Token: 0x0400611A RID: 24858
		public const short GemSquirrelDiamond = 4836;

		// Token: 0x0400611B RID: 24859
		public const short GemSquirrelAmber = 4837;

		// Token: 0x0400611C RID: 24860
		public const short GemBunnyAmethyst = 4838;

		// Token: 0x0400611D RID: 24861
		public const short GemBunnyTopaz = 4839;

		// Token: 0x0400611E RID: 24862
		public const short GemBunnySapphire = 4840;

		// Token: 0x0400611F RID: 24863
		public const short GemBunnyEmerald = 4841;

		// Token: 0x04006120 RID: 24864
		public const short GemBunnyRuby = 4842;

		// Token: 0x04006121 RID: 24865
		public const short GemBunnyDiamond = 4843;

		// Token: 0x04006122 RID: 24866
		public const short GemBunnyAmber = 4844;

		// Token: 0x04006123 RID: 24867
		public const short HellButterfly = 4845;

		// Token: 0x04006124 RID: 24868
		public const short HellButterflyJar = 4846;

		// Token: 0x04006125 RID: 24869
		public const short Lavafly = 4847;

		// Token: 0x04006126 RID: 24870
		public const short LavaflyinaBottle = 4848;

		// Token: 0x04006127 RID: 24871
		public const short MagmaSnail = 4849;

		// Token: 0x04006128 RID: 24872
		public const short MagmaSnailCage = 4850;

		// Token: 0x04006129 RID: 24873
		public const short GemTreeTopazSeed = 4851;

		// Token: 0x0400612A RID: 24874
		public const short GemTreeAmethystSeed = 4852;

		// Token: 0x0400612B RID: 24875
		public const short GemTreeSapphireSeed = 4853;

		// Token: 0x0400612C RID: 24876
		public const short GemTreeEmeraldSeed = 4854;

		// Token: 0x0400612D RID: 24877
		public const short GemTreeRubySeed = 4855;

		// Token: 0x0400612E RID: 24878
		public const short GemTreeDiamondSeed = 4856;

		// Token: 0x0400612F RID: 24879
		public const short GemTreeAmberSeed = 4857;

		// Token: 0x04006130 RID: 24880
		public const short PotSuspended = 4858;

		// Token: 0x04006131 RID: 24881
		public const short PotSuspendedDaybloom = 4859;

		// Token: 0x04006132 RID: 24882
		public const short PotSuspendedMoonglow = 4860;

		// Token: 0x04006133 RID: 24883
		public const short PotSuspendedWaterleaf = 4861;

		// Token: 0x04006134 RID: 24884
		public const short PotSuspendedShiverthorn = 4862;

		// Token: 0x04006135 RID: 24885
		public const short PotSuspendedBlinkroot = 4863;

		// Token: 0x04006136 RID: 24886
		public const short PotSuspendedDeathweedCorrupt = 4864;

		// Token: 0x04006137 RID: 24887
		public const short PotSuspendedDeathweedCrimson = 4865;

		// Token: 0x04006138 RID: 24888
		public const short PotSuspendedFireblossom = 4866;

		// Token: 0x04006139 RID: 24889
		public const short BrazierSuspended = 4867;

		// Token: 0x0400613A RID: 24890
		public const short VolcanoSmall = 4868;

		// Token: 0x0400613B RID: 24891
		public const short VolcanoLarge = 4869;

		// Token: 0x0400613C RID: 24892
		public const short PotionOfReturn = 4870;

		// Token: 0x0400613D RID: 24893
		public const short VanityTreeSakuraSeed = 4871;

		// Token: 0x0400613E RID: 24894
		public const short LavaAbsorbantSponge = 4872;

		// Token: 0x0400613F RID: 24895
		public const short HallowedHood = 4873;

		// Token: 0x04006140 RID: 24896
		public const short HellfireTreads = 4874;

		// Token: 0x04006141 RID: 24897
		public const short TeleportationPylonJungle = 4875;

		// Token: 0x04006142 RID: 24898
		public const short TeleportationPylonPurity = 4876;

		// Token: 0x04006143 RID: 24899
		public const short LavaCrate = 4877;

		// Token: 0x04006144 RID: 24900
		public const short LavaCrateHard = 4878;

		// Token: 0x04006145 RID: 24901
		public const short ObsidianLockbox = 4879;

		// Token: 0x04006146 RID: 24902
		public const short LavaFishbowl = 4880;

		// Token: 0x04006147 RID: 24903
		public const short LavaFishingHook = 4881;

		// Token: 0x04006148 RID: 24904
		public const short AmethystBunnyCage = 4882;

		// Token: 0x04006149 RID: 24905
		public const short TopazBunnyCage = 4883;

		// Token: 0x0400614A RID: 24906
		public const short SapphireBunnyCage = 4884;

		// Token: 0x0400614B RID: 24907
		public const short EmeraldBunnyCage = 4885;

		// Token: 0x0400614C RID: 24908
		public const short RubyBunnyCage = 4886;

		// Token: 0x0400614D RID: 24909
		public const short DiamondBunnyCage = 4887;

		// Token: 0x0400614E RID: 24910
		public const short AmberBunnyCage = 4888;

		// Token: 0x0400614F RID: 24911
		public const short AmethystSquirrelCage = 4889;

		// Token: 0x04006150 RID: 24912
		public const short TopazSquirrelCage = 4890;

		// Token: 0x04006151 RID: 24913
		public const short SapphireSquirrelCage = 4891;

		// Token: 0x04006152 RID: 24914
		public const short EmeraldSquirrelCage = 4892;

		// Token: 0x04006153 RID: 24915
		public const short RubySquirrelCage = 4893;

		// Token: 0x04006154 RID: 24916
		public const short DiamondSquirrelCage = 4894;

		// Token: 0x04006155 RID: 24917
		public const short AmberSquirrelCage = 4895;

		// Token: 0x04006156 RID: 24918
		public const short AncientHallowedMask = 4896;

		// Token: 0x04006157 RID: 24919
		public const short AncientHallowedHelmet = 4897;

		// Token: 0x04006158 RID: 24920
		public const short AncientHallowedHeadgear = 4898;

		// Token: 0x04006159 RID: 24921
		public const short AncientHallowedHood = 4899;

		// Token: 0x0400615A RID: 24922
		public const short AncientHallowedPlateMail = 4900;

		// Token: 0x0400615B RID: 24923
		public const short AncientHallowedGreaves = 4901;

		// Token: 0x0400615C RID: 24924
		public const short PottedLavaPlantPalm = 4902;

		// Token: 0x0400615D RID: 24925
		public const short PottedLavaPlantBush = 4903;

		// Token: 0x0400615E RID: 24926
		public const short PottedLavaPlantBramble = 4904;

		// Token: 0x0400615F RID: 24927
		public const short PottedLavaPlantBulb = 4905;

		// Token: 0x04006160 RID: 24928
		public const short PottedLavaPlantTendrils = 4906;

		// Token: 0x04006161 RID: 24929
		public const short VanityTreeYellowWillowSeed = 4907;

		// Token: 0x04006162 RID: 24930
		public const short DirtBomb = 4908;

		// Token: 0x04006163 RID: 24931
		public const short DirtStickyBomb = 4909;

		// Token: 0x04006164 RID: 24932
		public const short LicenseBunny = 4910;

		// Token: 0x04006165 RID: 24933
		public const short CoolWhip = 4911;

		// Token: 0x04006166 RID: 24934
		public const short FireWhip = 4912;

		// Token: 0x04006167 RID: 24935
		public const short ThornWhip = 4913;

		// Token: 0x04006168 RID: 24936
		public const short RainbowWhip = 4914;

		// Token: 0x04006169 RID: 24937
		public const short TungstenBullet = 4915;

		// Token: 0x0400616A RID: 24938
		public const short TeleportationPylonHallow = 4916;

		// Token: 0x0400616B RID: 24939
		public const short TeleportationPylonUnderground = 4917;

		// Token: 0x0400616C RID: 24940
		public const short TeleportationPylonOcean = 4918;

		// Token: 0x0400616D RID: 24941
		public const short TeleportationPylonDesert = 4919;

		// Token: 0x0400616E RID: 24942
		public const short TeleportationPylonSnow = 4920;

		// Token: 0x0400616F RID: 24943
		public const short TeleportationPylonMushroom = 4921;

		// Token: 0x04006170 RID: 24944
		public const short CavernFountain = 4922;

		// Token: 0x04006171 RID: 24945
		public const short PiercingStarlight = 4923;

		// Token: 0x04006172 RID: 24946
		public const short EyeofCthulhuMasterTrophy = 4924;

		// Token: 0x04006173 RID: 24947
		public const short EaterofWorldsMasterTrophy = 4925;

		// Token: 0x04006174 RID: 24948
		public const short BrainofCthulhuMasterTrophy = 4926;

		// Token: 0x04006175 RID: 24949
		public const short SkeletronMasterTrophy = 4927;

		// Token: 0x04006176 RID: 24950
		public const short QueenBeeMasterTrophy = 4928;

		// Token: 0x04006177 RID: 24951
		public const short KingSlimeMasterTrophy = 4929;

		// Token: 0x04006178 RID: 24952
		public const short WallofFleshMasterTrophy = 4930;

		// Token: 0x04006179 RID: 24953
		public const short TwinsMasterTrophy = 4931;

		// Token: 0x0400617A RID: 24954
		public const short DestroyerMasterTrophy = 4932;

		// Token: 0x0400617B RID: 24955
		public const short SkeletronPrimeMasterTrophy = 4933;

		// Token: 0x0400617C RID: 24956
		public const short PlanteraMasterTrophy = 4934;

		// Token: 0x0400617D RID: 24957
		public const short GolemMasterTrophy = 4935;

		// Token: 0x0400617E RID: 24958
		public const short DukeFishronMasterTrophy = 4936;

		// Token: 0x0400617F RID: 24959
		public const short LunaticCultistMasterTrophy = 4937;

		// Token: 0x04006180 RID: 24960
		public const short MoonLordMasterTrophy = 4938;

		// Token: 0x04006181 RID: 24961
		public const short UFOMasterTrophy = 4939;

		// Token: 0x04006182 RID: 24962
		public const short FlyingDutchmanMasterTrophy = 4940;

		// Token: 0x04006183 RID: 24963
		public const short MourningWoodMasterTrophy = 4941;

		// Token: 0x04006184 RID: 24964
		public const short PumpkingMasterTrophy = 4942;

		// Token: 0x04006185 RID: 24965
		public const short IceQueenMasterTrophy = 4943;

		// Token: 0x04006186 RID: 24966
		public const short EverscreamMasterTrophy = 4944;

		// Token: 0x04006187 RID: 24967
		public const short SantankMasterTrophy = 4945;

		// Token: 0x04006188 RID: 24968
		public const short DarkMageMasterTrophy = 4946;

		// Token: 0x04006189 RID: 24969
		public const short OgreMasterTrophy = 4947;

		// Token: 0x0400618A RID: 24970
		public const short BetsyMasterTrophy = 4948;

		// Token: 0x0400618B RID: 24971
		public const short FairyQueenMasterTrophy = 4949;

		// Token: 0x0400618C RID: 24972
		public const short QueenSlimeMasterTrophy = 4950;

		// Token: 0x0400618D RID: 24973
		public const short TeleportationPylonVictory = 4951;

		// Token: 0x0400618E RID: 24974
		public const short FairyQueenMagicItem = 4952;

		// Token: 0x0400618F RID: 24975
		public const short FairyQueenRangedItem = 4953;

		// Token: 0x04006190 RID: 24976
		public const short LongRainbowTrailWings = 4954;

		// Token: 0x04006191 RID: 24977
		public const short RabbitOrder = 4955;

		// Token: 0x04006192 RID: 24978
		public const short Zenith = 4956;

		// Token: 0x04006193 RID: 24979
		public const short QueenSlimeBossBag = 4957;

		// Token: 0x04006194 RID: 24980
		public const short QueenSlimeTrophy = 4958;

		// Token: 0x04006195 RID: 24981
		public const short QueenSlimeMask = 4959;

		// Token: 0x04006196 RID: 24982
		public const short QueenSlimePetItem = 4960;

		// Token: 0x04006197 RID: 24983
		public const short EmpressButterfly = 4961;

		// Token: 0x04006198 RID: 24984
		public const short AccentSlab = 4962;

		// Token: 0x04006199 RID: 24985
		public const short TruffleWormCage = 4963;

		// Token: 0x0400619A RID: 24986
		public const short EmpressButterflyJar = 4964;

		// Token: 0x0400619B RID: 24987
		public const short RockGolemBanner = 4965;

		// Token: 0x0400619C RID: 24988
		public const short BloodMummyBanner = 4966;

		// Token: 0x0400619D RID: 24989
		public const short SporeSkeletonBanner = 4967;

		// Token: 0x0400619E RID: 24990
		public const short SporeBatBanner = 4968;

		// Token: 0x0400619F RID: 24991
		public const short LarvaeAntlionBanner = 4969;

		// Token: 0x040061A0 RID: 24992
		public const short CrimsonBunnyBanner = 4970;

		// Token: 0x040061A1 RID: 24993
		public const short CrimsonGoldfishBanner = 4971;

		// Token: 0x040061A2 RID: 24994
		public const short CrimsonPenguinBanner = 4972;

		// Token: 0x040061A3 RID: 24995
		public const short BigMimicCorruptionBanner = 4973;

		// Token: 0x040061A4 RID: 24996
		public const short BigMimicCrimsonBanner = 4974;

		// Token: 0x040061A5 RID: 24997
		public const short BigMimicHallowBanner = 4975;

		// Token: 0x040061A6 RID: 24998
		public const short MossHornetBanner = 4976;

		// Token: 0x040061A7 RID: 24999
		public const short WanderingEyeBanner = 4977;

		// Token: 0x040061A8 RID: 25000
		public const short CreativeWings = 4978;

		// Token: 0x040061A9 RID: 25001
		public const short MusicBoxQueenSlime = 4979;

		// Token: 0x040061AA RID: 25002
		public const short QueenSlimeHook = 4980;

		// Token: 0x040061AB RID: 25003
		public const short QueenSlimeMountSaddle = 4981;

		// Token: 0x040061AC RID: 25004
		public const short CrystalNinjaHelmet = 4982;

		// Token: 0x040061AD RID: 25005
		public const short CrystalNinjaChestplate = 4983;

		// Token: 0x040061AE RID: 25006
		public const short CrystalNinjaLeggings = 4984;

		// Token: 0x040061AF RID: 25007
		public const short MusicBoxEmpressOfLight = 4985;

		// Token: 0x040061B0 RID: 25008
		public const short GelBalloon = 4986;

		// Token: 0x040061B1 RID: 25009
		public const short VolatileGelatin = 4987;

		// Token: 0x040061B2 RID: 25010
		public const short QueenSlimeCrystal = 4988;

		// Token: 0x040061B3 RID: 25011
		public const short EmpressFlightBooster = 4989;

		// Token: 0x040061B4 RID: 25012
		public const short MusicBoxDukeFishron = 4990;

		// Token: 0x040061B5 RID: 25013
		public const short MusicBoxMorningRain = 4991;

		// Token: 0x040061B6 RID: 25014
		public const short MusicBoxConsoleTitle = 4992;

		// Token: 0x040061B7 RID: 25015
		public const short ChippysCouch = 4993;

		// Token: 0x040061B8 RID: 25016
		public const short GraduationCapBlue = 4994;

		// Token: 0x040061B9 RID: 25017
		public const short GraduationCapMaroon = 4995;

		// Token: 0x040061BA RID: 25018
		public const short GraduationCapBlack = 4996;

		// Token: 0x040061BB RID: 25019
		public const short GraduationGownBlue = 4997;

		// Token: 0x040061BC RID: 25020
		public const short GraduationGownMaroon = 4998;

		// Token: 0x040061BD RID: 25021
		public const short GraduationGownBlack = 4999;

		// Token: 0x040061BE RID: 25022
		public const short TerrasparkBoots = 5000;

		// Token: 0x040061BF RID: 25023
		public const short MoonLordLegs = 5001;

		// Token: 0x040061C0 RID: 25024
		public const short OceanCrate = 5002;

		// Token: 0x040061C1 RID: 25025
		public const short OceanCrateHard = 5003;

		// Token: 0x040061C2 RID: 25026
		public const short BadgersHat = 5004;

		// Token: 0x040061C3 RID: 25027
		public const short EmpressBlade = 5005;

		// Token: 0x040061C4 RID: 25028
		public const short MusicBoxUndergroundDesert = 5006;

		// Token: 0x040061C5 RID: 25029
		public const short DeadMansSweater = 5007;

		// Token: 0x040061C6 RID: 25030
		public const short TeaKettle = 5008;

		// Token: 0x040061C7 RID: 25031
		public const short Teacup = 5009;

		// Token: 0x040061C8 RID: 25032
		public const short TreasureMagnet = 5010;

		// Token: 0x040061C9 RID: 25033
		public const short Mace = 5011;

		// Token: 0x040061CA RID: 25034
		public const short FlamingMace = 5012;

		// Token: 0x040061CB RID: 25035
		public const short SleepingIcon = 5013;

		// Token: 0x040061CC RID: 25036
		public const short MusicBoxOWRain = 5014;

		// Token: 0x040061CD RID: 25037
		public const short MusicBoxOWDay = 5015;

		// Token: 0x040061CE RID: 25038
		public const short MusicBoxOWNight = 5016;

		// Token: 0x040061CF RID: 25039
		public const short MusicBoxOWUnderground = 5017;

		// Token: 0x040061D0 RID: 25040
		public const short MusicBoxOWDesert = 5018;

		// Token: 0x040061D1 RID: 25041
		public const short MusicBoxOWOcean = 5019;

		// Token: 0x040061D2 RID: 25042
		public const short MusicBoxOWMushroom = 5020;

		// Token: 0x040061D3 RID: 25043
		public const short MusicBoxOWDungeon = 5021;

		// Token: 0x040061D4 RID: 25044
		public const short MusicBoxOWSpace = 5022;

		// Token: 0x040061D5 RID: 25045
		public const short MusicBoxOWUnderworld = 5023;

		// Token: 0x040061D6 RID: 25046
		public const short MusicBoxOWSnow = 5024;

		// Token: 0x040061D7 RID: 25047
		public const short MusicBoxOWCorruption = 5025;

		// Token: 0x040061D8 RID: 25048
		public const short MusicBoxOWUndergroundCorruption = 5026;

		// Token: 0x040061D9 RID: 25049
		public const short MusicBoxOWCrimson = 5027;

		// Token: 0x040061DA RID: 25050
		public const short MusicBoxOWUndergroundCrimson = 5028;

		// Token: 0x040061DB RID: 25051
		public const short MusicBoxOWUndergroundSnow = 5029;

		// Token: 0x040061DC RID: 25052
		public const short MusicBoxOWUndergroundHallow = 5030;

		// Token: 0x040061DD RID: 25053
		public const short MusicBoxOWBloodMoon = 5031;

		// Token: 0x040061DE RID: 25054
		public const short MusicBoxOWBoss2 = 5032;

		// Token: 0x040061DF RID: 25055
		public const short MusicBoxOWBoss1 = 5033;

		// Token: 0x040061E0 RID: 25056
		public const short MusicBoxOWInvasion = 5034;

		// Token: 0x040061E1 RID: 25057
		public const short MusicBoxOWTowers = 5035;

		// Token: 0x040061E2 RID: 25058
		public const short MusicBoxOWMoonLord = 5036;

		// Token: 0x040061E3 RID: 25059
		public const short MusicBoxOWPlantera = 5037;

		// Token: 0x040061E4 RID: 25060
		public const short MusicBoxOWJungle = 5038;

		// Token: 0x040061E5 RID: 25061
		public const short MusicBoxOWWallOfFlesh = 5039;

		// Token: 0x040061E6 RID: 25062
		public const short MusicBoxOWHallow = 5040;

		// Token: 0x040061E7 RID: 25063
		public const short MilkCarton = 5041;

		// Token: 0x040061E8 RID: 25064
		public const short CoffeeCup = 5042;

		// Token: 0x040061E9 RID: 25065
		public const short TorchGodsFavor = 5043;

		// Token: 0x040061EA RID: 25066
		public const short MusicBoxCredits = 5044;

		// Token: 0x040061EB RID: 25067
		public const short PlaguebringerHelmet = 5045;

		// Token: 0x040061EC RID: 25068
		public const short PlaguebringerChestplate = 5046;

		// Token: 0x040061ED RID: 25069
		public const short PlaguebringerGreaves = 5047;

		// Token: 0x040061EE RID: 25070
		public const short RoninHat = 5048;

		// Token: 0x040061EF RID: 25071
		public const short RoninShirt = 5049;

		// Token: 0x040061F0 RID: 25072
		public const short RoninPants = 5050;

		// Token: 0x040061F1 RID: 25073
		public const short TimelessTravelerHood = 5051;

		// Token: 0x040061F2 RID: 25074
		public const short TimelessTravelerRobe = 5052;

		// Token: 0x040061F3 RID: 25075
		public const short TimelessTravelerBottom = 5053;

		// Token: 0x040061F4 RID: 25076
		public const short FloretProtectorHelmet = 5054;

		// Token: 0x040061F5 RID: 25077
		public const short FloretProtectorChestplate = 5055;

		// Token: 0x040061F6 RID: 25078
		public const short FloretProtectorLegs = 5056;

		// Token: 0x040061F7 RID: 25079
		public const short CapricornMask = 5057;

		// Token: 0x040061F8 RID: 25080
		public const short CapricornChestplate = 5058;

		// Token: 0x040061F9 RID: 25081
		public const short CapricornLegs = 5059;

		// Token: 0x040061FA RID: 25082
		public const short CapricornTail = 5060;

		// Token: 0x040061FB RID: 25083
		public const short TVHeadMask = 5061;

		// Token: 0x040061FC RID: 25084
		public const short TVHeadSuit = 5062;

		// Token: 0x040061FD RID: 25085
		public const short TVHeadPants = 5063;

		// Token: 0x040061FE RID: 25086
		public const short LavaproofTackleBag = 5064;

		// Token: 0x040061FF RID: 25087
		public const short PrincessWeapon = 5065;

		// Token: 0x04006200 RID: 25088
		public const short BeeHive = 5066;

		// Token: 0x04006201 RID: 25089
		public const short AntlionEggs = 5067;

		// Token: 0x04006202 RID: 25090
		public const short FlinxFurCoat = 5068;

		// Token: 0x04006203 RID: 25091
		public const short FlinxStaff = 5069;

		// Token: 0x04006204 RID: 25092
		public const short FlinxFur = 5070;

		// Token: 0x04006205 RID: 25093
		public const short RoyalTiara = 5071;

		// Token: 0x04006206 RID: 25094
		public const short RoyalDressTop = 5072;

		// Token: 0x04006207 RID: 25095
		public const short RoyalDressBottom = 5073;

		// Token: 0x04006208 RID: 25096
		public const short BoneWhip = 5074;

		// Token: 0x04006209 RID: 25097
		public const short RainbowCursor = 5075;

		// Token: 0x0400620A RID: 25098
		public const short RoyalScepter = 5076;

		// Token: 0x0400620B RID: 25099
		public const short GlassSlipper = 5077;

		// Token: 0x0400620C RID: 25100
		public const short PrinceUniform = 5078;

		// Token: 0x0400620D RID: 25101
		public const short PrincePants = 5079;

		// Token: 0x0400620E RID: 25102
		public const short PrinceCape = 5080;

		// Token: 0x0400620F RID: 25103
		public const short PottedCrystalPlantFern = 5081;

		// Token: 0x04006210 RID: 25104
		public const short PottedCrystalPlantSpiral = 5082;

		// Token: 0x04006211 RID: 25105
		public const short PottedCrystalPlantTeardrop = 5083;

		// Token: 0x04006212 RID: 25106
		public const short PottedCrystalPlantTree = 5084;

		// Token: 0x04006213 RID: 25107
		public const short Princess64 = 5085;

		// Token: 0x04006214 RID: 25108
		public const short PaintingOfALass = 5086;

		// Token: 0x04006215 RID: 25109
		public const short DarkSideHallow = 5087;

		// Token: 0x04006216 RID: 25110
		public const short BerniePetItem = 5088;

		// Token: 0x04006217 RID: 25111
		public const short GlommerPetItem = 5089;

		// Token: 0x04006218 RID: 25112
		public const short DeerclopsPetItem = 5090;

		// Token: 0x04006219 RID: 25113
		public const short PigPetItem = 5091;

		// Token: 0x0400621A RID: 25114
		public const short MonsterLasagna = 5092;

		// Token: 0x0400621B RID: 25115
		public const short FroggleBunwich = 5093;

		// Token: 0x0400621C RID: 25116
		public const short TentacleSpike = 5094;

		// Token: 0x0400621D RID: 25117
		public const short LucyTheAxe = 5095;

		// Token: 0x0400621E RID: 25118
		public const short HamBat = 5096;

		// Token: 0x0400621F RID: 25119
		public const short BatBat = 5097;

		// Token: 0x04006220 RID: 25120
		public const short ChesterPetItem = 5098;

		// Token: 0x04006221 RID: 25121
		public const short GarlandHat = 5099;

		// Token: 0x04006222 RID: 25122
		public const short BoneHelm = 5100;

		// Token: 0x04006223 RID: 25123
		public const short Eyebrella = 5101;

		// Token: 0x04006224 RID: 25124
		public const short WilsonShirt = 5102;

		// Token: 0x04006225 RID: 25125
		public const short WilsonPants = 5103;

		// Token: 0x04006226 RID: 25126
		public const short WilsonBeardShort = 5104;

		// Token: 0x04006227 RID: 25127
		public const short WilsonBeardLong = 5105;

		// Token: 0x04006228 RID: 25128
		public const short WilsonBeardMagnificent = 5106;

		// Token: 0x04006229 RID: 25129
		public const short Magiluminescence = 5107;

		// Token: 0x0400622A RID: 25130
		public const short DeerclopsTrophy = 5108;

		// Token: 0x0400622B RID: 25131
		public const short DeerclopsMask = 5109;

		// Token: 0x0400622C RID: 25132
		public const short DeerclopsMasterTrophy = 5110;

		// Token: 0x0400622D RID: 25133
		public const short DeerclopsBossBag = 5111;

		// Token: 0x0400622E RID: 25134
		public const short MusicBoxDeerclops = 5112;

		// Token: 0x0400622F RID: 25135
		public const short DontStarveShaderItem = 5113;

		// Token: 0x04006230 RID: 25136
		public const short AbigailsFlower = 5114;

		// Token: 0x04006231 RID: 25137
		public const short WillowShirt = 5115;

		// Token: 0x04006232 RID: 25138
		public const short WillowSkirt = 5116;

		// Token: 0x04006233 RID: 25139
		public const short PewMaticHorn = 5117;

		// Token: 0x04006234 RID: 25140
		public const short WeatherPain = 5118;

		// Token: 0x04006235 RID: 25141
		public const short HoundiusShootius = 5119;

		// Token: 0x04006236 RID: 25142
		public const short DeerThing = 5120;

		// Token: 0x04006237 RID: 25143
		public const short PaintingWilson = 5121;

		// Token: 0x04006238 RID: 25144
		public const short PaintingWillow = 5122;

		// Token: 0x04006239 RID: 25145
		public const short PaintingWendy = 5123;

		// Token: 0x0400623A RID: 25146
		public const short PaintingWolfgang = 5124;

		// Token: 0x0400623B RID: 25147
		public const short FartMinecart = 5125;

		// Token: 0x0400623C RID: 25148
		public const short HandOfCreation = 5126;

		// Token: 0x0400623D RID: 25149
		public const short VioletMoss = 5127;

		// Token: 0x0400623E RID: 25150
		public const short RainbowMoss = 5128;

		// Token: 0x0400623F RID: 25151
		public const short Flymeal = 5129;

		// Token: 0x04006240 RID: 25152
		public const short WolfMountItem = 5130;

		// Token: 0x04006241 RID: 25153
		public const short ResplendentDessert = 5131;

		// Token: 0x04006242 RID: 25154
		public const short Stinkbug = 5132;

		// Token: 0x04006243 RID: 25155
		public const short StinkbugCage = 5133;

		// Token: 0x04006244 RID: 25156
		public const short Clentaminator2 = 5134;

		// Token: 0x04006245 RID: 25157
		public const short VenomDartTrap = 5135;

		// Token: 0x04006246 RID: 25158
		public const short VulkelfEar = 5136;

		// Token: 0x04006247 RID: 25159
		public const short StinkbugHousingBlocker = 5137;

		// Token: 0x04006248 RID: 25160
		public const short StinkbugHousingBlockerEcho = 5138;

		// Token: 0x04006249 RID: 25161
		public const short FishingBobber = 5139;

		// Token: 0x0400624A RID: 25162
		public const short FishingBobberGlowingStar = 5140;

		// Token: 0x0400624B RID: 25163
		public const short FishingBobberGlowingLava = 5141;

		// Token: 0x0400624C RID: 25164
		public const short FishingBobberGlowingKrypton = 5142;

		// Token: 0x0400624D RID: 25165
		public const short FishingBobberGlowingXenon = 5143;

		// Token: 0x0400624E RID: 25166
		public const short FishingBobberGlowingArgon = 5144;

		// Token: 0x0400624F RID: 25167
		public const short FishingBobberGlowingViolet = 5145;

		// Token: 0x04006250 RID: 25168
		public const short FishingBobberGlowingRainbow = 5146;

		// Token: 0x04006251 RID: 25169
		public const short WandofFrosting = 5147;

		// Token: 0x04006252 RID: 25170
		public const short CoralBathtub = 5148;

		// Token: 0x04006253 RID: 25171
		public const short CoralBed = 5149;

		// Token: 0x04006254 RID: 25172
		public const short CoralBookcase = 5150;

		// Token: 0x04006255 RID: 25173
		public const short CoralDresser = 5151;

		// Token: 0x04006256 RID: 25174
		public const short CoralCandelabra = 5152;

		// Token: 0x04006257 RID: 25175
		public const short CoralCandle = 5153;

		// Token: 0x04006258 RID: 25176
		public const short CoralChair = 5154;

		// Token: 0x04006259 RID: 25177
		public const short CoralChandelier = 5155;

		// Token: 0x0400625A RID: 25178
		public const short CoralChest = 5156;

		// Token: 0x0400625B RID: 25179
		public const short CoralClock = 5157;

		// Token: 0x0400625C RID: 25180
		public const short CoralDoor = 5158;

		// Token: 0x0400625D RID: 25181
		public const short CoralLamp = 5159;

		// Token: 0x0400625E RID: 25182
		public const short CoralLantern = 5160;

		// Token: 0x0400625F RID: 25183
		public const short CoralPiano = 5161;

		// Token: 0x04006260 RID: 25184
		public const short CoralPlatform = 5162;

		// Token: 0x04006261 RID: 25185
		public const short CoralSink = 5163;

		// Token: 0x04006262 RID: 25186
		public const short CoralSofa = 5164;

		// Token: 0x04006263 RID: 25187
		public const short CoralTable = 5165;

		// Token: 0x04006264 RID: 25188
		public const short CoralWorkbench = 5166;

		// Token: 0x04006265 RID: 25189
		public const short Fake_CoralChest = 5167;

		// Token: 0x04006266 RID: 25190
		public const short CoralToilet = 5168;

		// Token: 0x04006267 RID: 25191
		public const short BalloonBathtub = 5169;

		// Token: 0x04006268 RID: 25192
		public const short BalloonBed = 5170;

		// Token: 0x04006269 RID: 25193
		public const short BalloonBookcase = 5171;

		// Token: 0x0400626A RID: 25194
		public const short BalloonDresser = 5172;

		// Token: 0x0400626B RID: 25195
		public const short BalloonCandelabra = 5173;

		// Token: 0x0400626C RID: 25196
		public const short BalloonCandle = 5174;

		// Token: 0x0400626D RID: 25197
		public const short BalloonChair = 5175;

		// Token: 0x0400626E RID: 25198
		public const short BalloonChandelier = 5176;

		// Token: 0x0400626F RID: 25199
		public const short BalloonChest = 5177;

		// Token: 0x04006270 RID: 25200
		public const short BalloonClock = 5178;

		// Token: 0x04006271 RID: 25201
		public const short BalloonDoor = 5179;

		// Token: 0x04006272 RID: 25202
		public const short BalloonLamp = 5180;

		// Token: 0x04006273 RID: 25203
		public const short BalloonLantern = 5181;

		// Token: 0x04006274 RID: 25204
		public const short BalloonPiano = 5182;

		// Token: 0x04006275 RID: 25205
		public const short BalloonPlatform = 5183;

		// Token: 0x04006276 RID: 25206
		public const short BalloonSink = 5184;

		// Token: 0x04006277 RID: 25207
		public const short BalloonSofa = 5185;

		// Token: 0x04006278 RID: 25208
		public const short BalloonTable = 5186;

		// Token: 0x04006279 RID: 25209
		public const short BalloonWorkbench = 5187;

		// Token: 0x0400627A RID: 25210
		public const short Fake_BalloonChest = 5188;

		// Token: 0x0400627B RID: 25211
		public const short BalloonToilet = 5189;

		// Token: 0x0400627C RID: 25212
		public const short AshWoodBathtub = 5190;

		// Token: 0x0400627D RID: 25213
		public const short AshWoodBed = 5191;

		// Token: 0x0400627E RID: 25214
		public const short AshWoodBookcase = 5192;

		// Token: 0x0400627F RID: 25215
		public const short AshWoodDresser = 5193;

		// Token: 0x04006280 RID: 25216
		public const short AshWoodCandelabra = 5194;

		// Token: 0x04006281 RID: 25217
		public const short AshWoodCandle = 5195;

		// Token: 0x04006282 RID: 25218
		public const short AshWoodChair = 5196;

		// Token: 0x04006283 RID: 25219
		public const short AshWoodChandelier = 5197;

		// Token: 0x04006284 RID: 25220
		public const short AshWoodChest = 5198;

		// Token: 0x04006285 RID: 25221
		public const short AshWoodClock = 5199;

		// Token: 0x04006286 RID: 25222
		public const short AshWoodDoor = 5200;

		// Token: 0x04006287 RID: 25223
		public const short AshWoodLamp = 5201;

		// Token: 0x04006288 RID: 25224
		public const short AshWoodLantern = 5202;

		// Token: 0x04006289 RID: 25225
		public const short AshWoodPiano = 5203;

		// Token: 0x0400628A RID: 25226
		public const short AshWoodPlatform = 5204;

		// Token: 0x0400628B RID: 25227
		public const short AshWoodSink = 5205;

		// Token: 0x0400628C RID: 25228
		public const short AshWoodSofa = 5206;

		// Token: 0x0400628D RID: 25229
		public const short AshWoodTable = 5207;

		// Token: 0x0400628E RID: 25230
		public const short AshWoodWorkbench = 5208;

		// Token: 0x0400628F RID: 25231
		public const short Fake_AshWoodChest = 5209;

		// Token: 0x04006290 RID: 25232
		public const short AshWoodToilet = 5210;

		// Token: 0x04006291 RID: 25233
		public const short BiomeSightPotion = 5211;

		// Token: 0x04006292 RID: 25234
		public const short ScarletMacaw = 5212;

		// Token: 0x04006293 RID: 25235
		public const short ScarletMacawCage = 5213;

		// Token: 0x04006294 RID: 25236
		public const short AshGrassSeeds = 5214;

		// Token: 0x04006295 RID: 25237
		public const short AshWood = 5215;

		// Token: 0x04006296 RID: 25238
		public const short AshWoodWall = 5216;

		// Token: 0x04006297 RID: 25239
		public const short AshWoodFence = 5217;

		// Token: 0x04006298 RID: 25240
		public const short Outcast = 5218;

		// Token: 0x04006299 RID: 25241
		public const short FairyGuides = 5219;

		// Token: 0x0400629A RID: 25242
		public const short AHorribleNightforAlchemy = 5220;

		// Token: 0x0400629B RID: 25243
		public const short MorningHunt = 5221;

		// Token: 0x0400629C RID: 25244
		public const short SuspiciouslySparkly = 5222;

		// Token: 0x0400629D RID: 25245
		public const short Requiem = 5223;

		// Token: 0x0400629E RID: 25246
		public const short CatSword = 5224;

		// Token: 0x0400629F RID: 25247
		public const short KargohsSummon = 5225;

		// Token: 0x040062A0 RID: 25248
		public const short HighPitch = 5226;

		// Token: 0x040062A1 RID: 25249
		public const short AMachineforTerrarians = 5227;

		// Token: 0x040062A2 RID: 25250
		public const short TerraBladeChronicles = 5228;

		// Token: 0x040062A3 RID: 25251
		public const short BennyWarhol = 5229;

		// Token: 0x040062A4 RID: 25252
		public const short LizardKing = 5230;

		// Token: 0x040062A5 RID: 25253
		public const short MySon = 5231;

		// Token: 0x040062A6 RID: 25254
		public const short Duality = 5232;

		// Token: 0x040062A7 RID: 25255
		public const short ParsecPals = 5233;

		// Token: 0x040062A8 RID: 25256
		public const short RemnantsofDevotion = 5234;

		// Token: 0x040062A9 RID: 25257
		public const short NotSoLostInParadise = 5235;

		// Token: 0x040062AA RID: 25258
		public const short OcularResonance = 5236;

		// Token: 0x040062AB RID: 25259
		public const short WingsofEvil = 5237;

		// Token: 0x040062AC RID: 25260
		public const short Constellation = 5238;

		// Token: 0x040062AD RID: 25261
		public const short Eyezorhead = 5239;

		// Token: 0x040062AE RID: 25262
		public const short DreadoftheRedSea = 5240;

		// Token: 0x040062AF RID: 25263
		public const short DoNotEattheVileMushroom = 5241;

		// Token: 0x040062B0 RID: 25264
		public const short YuumaTheBlueTiger = 5242;

		// Token: 0x040062B1 RID: 25265
		public const short MoonmanandCompany = 5243;

		// Token: 0x040062B2 RID: 25266
		public const short SunshineofIsrapony = 5244;

		// Token: 0x040062B3 RID: 25267
		public const short Purity = 5245;

		// Token: 0x040062B4 RID: 25268
		public const short SufficientlyAdvanced = 5246;

		// Token: 0x040062B5 RID: 25269
		public const short StrangeGrowth = 5247;

		// Token: 0x040062B6 RID: 25270
		public const short HappyLittleTree = 5248;

		// Token: 0x040062B7 RID: 25271
		public const short StrangeDeadFellows = 5249;

		// Token: 0x040062B8 RID: 25272
		public const short Secrets = 5250;

		// Token: 0x040062B9 RID: 25273
		public const short Thunderbolt = 5251;

		// Token: 0x040062BA RID: 25274
		public const short Crustography = 5252;

		// Token: 0x040062BB RID: 25275
		public const short TheWerewolf = 5253;

		// Token: 0x040062BC RID: 25276
		public const short BlessingfromTheHeavens = 5254;

		// Token: 0x040062BD RID: 25277
		public const short LoveisintheTrashSlot = 5255;

		// Token: 0x040062BE RID: 25278
		public const short Fangs = 5256;

		// Token: 0x040062BF RID: 25279
		public const short HailtotheKing = 5257;

		// Token: 0x040062C0 RID: 25280
		public const short SeeTheWorldForWhatItIs = 5258;

		// Token: 0x040062C1 RID: 25281
		public const short WhatLurksBelow = 5259;

		// Token: 0x040062C2 RID: 25282
		public const short ThisIsGettingOutOfHand = 5260;

		// Token: 0x040062C3 RID: 25283
		public const short Buddies = 5261;

		// Token: 0x040062C4 RID: 25284
		public const short MidnightSun = 5262;

		// Token: 0x040062C5 RID: 25285
		public const short CouchGag = 5263;

		// Token: 0x040062C6 RID: 25286
		public const short SilentFish = 5264;

		// Token: 0x040062C7 RID: 25287
		public const short TheDuke = 5265;

		// Token: 0x040062C8 RID: 25288
		public const short RoyalRomance = 5266;

		// Token: 0x040062C9 RID: 25289
		public const short Bioluminescence = 5267;

		// Token: 0x040062CA RID: 25290
		public const short Wildflowers = 5268;

		// Token: 0x040062CB RID: 25291
		public const short VikingVoyage = 5269;

		// Token: 0x040062CC RID: 25292
		public const short Bifrost = 5270;

		// Token: 0x040062CD RID: 25293
		public const short Heartlands = 5271;

		// Token: 0x040062CE RID: 25294
		public const short ForestTroll = 5272;

		// Token: 0x040062CF RID: 25295
		public const short AuroraBorealis = 5273;

		// Token: 0x040062D0 RID: 25296
		public const short LadyOfTheLake = 5274;

		// Token: 0x040062D1 RID: 25297
		public const short JojaCola = 5275;

		// Token: 0x040062D2 RID: 25298
		public const short JunimoPetItem = 5276;

		// Token: 0x040062D3 RID: 25299
		public const short SpicyPepper = 5277;

		// Token: 0x040062D4 RID: 25300
		public const short Pomegranate = 5278;

		// Token: 0x040062D5 RID: 25301
		public const short AshWoodHelmet = 5279;

		// Token: 0x040062D6 RID: 25302
		public const short AshWoodBreastplate = 5280;

		// Token: 0x040062D7 RID: 25303
		public const short AshWoodGreaves = 5281;

		// Token: 0x040062D8 RID: 25304
		public const short AshWoodBow = 5282;

		// Token: 0x040062D9 RID: 25305
		public const short AshWoodHammer = 5283;

		// Token: 0x040062DA RID: 25306
		public const short AshWoodSword = 5284;

		// Token: 0x040062DB RID: 25307
		public const short MoonGlobe = 5285;

		// Token: 0x040062DC RID: 25308
		public const short RepairedLifeCrystal = 5286;

		// Token: 0x040062DD RID: 25309
		public const short RepairedManaCrystal = 5287;

		// Token: 0x040062DE RID: 25310
		public const short TerraFartMinecart = 5288;

		// Token: 0x040062DF RID: 25311
		public const short MinecartPowerup = 5289;

		// Token: 0x040062E0 RID: 25312
		public const short JimsCap = 5290;

		// Token: 0x040062E1 RID: 25313
		public const short EchoWall = 5291;

		// Token: 0x040062E2 RID: 25314
		public const short EchoPlatform = 5292;

		// Token: 0x040062E3 RID: 25315
		public const short MushroomTorch = 5293;

		// Token: 0x040062E4 RID: 25316
		public const short HiveFive = 5294;

		// Token: 0x040062E5 RID: 25317
		public const short AcornAxe = 5295;

		// Token: 0x040062E6 RID: 25318
		public const short ChlorophyteExtractinator = 5296;

		// Token: 0x040062E7 RID: 25319
		public const short BlueEgg = 5297;

		// Token: 0x040062E8 RID: 25320
		public const short Trimarang = 5298;

		// Token: 0x040062E9 RID: 25321
		public const short MushroomCampfire = 5299;

		// Token: 0x040062EA RID: 25322
		public const short BlueMacaw = 5300;

		// Token: 0x040062EB RID: 25323
		public const short BlueMacawCage = 5301;

		// Token: 0x040062EC RID: 25324
		public const short BottomlessHoneyBucket = 5302;

		// Token: 0x040062ED RID: 25325
		public const short HoneyAbsorbantSponge = 5303;

		// Token: 0x040062EE RID: 25326
		public const short UltraAbsorbantSponge = 5304;

		// Token: 0x040062EF RID: 25327
		public const short GoblorcEar = 5305;

		// Token: 0x040062F0 RID: 25328
		public const short ReefBlock = 5306;

		// Token: 0x040062F1 RID: 25329
		public const short ReefWall = 5307;

		// Token: 0x040062F2 RID: 25330
		public const short PlacePainting = 5308;

		// Token: 0x040062F3 RID: 25331
		public const short DontHurtNatureBook = 5309;

		// Token: 0x040062F4 RID: 25332
		public const short PrincessStyle = 5310;

		// Token: 0x040062F5 RID: 25333
		public const short Toucan = 5311;

		// Token: 0x040062F6 RID: 25334
		public const short YellowCockatiel = 5312;

		// Token: 0x040062F7 RID: 25335
		public const short GrayCockatiel = 5313;

		// Token: 0x040062F8 RID: 25336
		public const short ToucanCage = 5314;

		// Token: 0x040062F9 RID: 25337
		public const short YellowCockatielCage = 5315;

		// Token: 0x040062FA RID: 25338
		public const short GrayCockatielCage = 5316;

		// Token: 0x040062FB RID: 25339
		public const short MacawStatue = 5317;

		// Token: 0x040062FC RID: 25340
		public const short ToucanStatue = 5318;

		// Token: 0x040062FD RID: 25341
		public const short CockatielStatue = 5319;

		// Token: 0x040062FE RID: 25342
		public const short PlaceableHealingPotion = 5320;

		// Token: 0x040062FF RID: 25343
		public const short PlaceableManaPotion = 5321;

		// Token: 0x04006300 RID: 25344
		public const short ShadowCandle = 5322;

		// Token: 0x04006301 RID: 25345
		public const short DontHurtComboBook = 5323;

		// Token: 0x04006302 RID: 25346
		public const short RubblemakerSmall = 5324;

		// Token: 0x04006303 RID: 25347
		public const short ClosedVoidBag = 5325;

		// Token: 0x04006304 RID: 25348
		public const short ArtisanLoaf = 5326;

		// Token: 0x04006305 RID: 25349
		public const short TNTBarrel = 5327;

		// Token: 0x04006306 RID: 25350
		public const short ChestLock = 5328;

		// Token: 0x04006307 RID: 25351
		public const short RubblemakerMedium = 5329;

		// Token: 0x04006308 RID: 25352
		public const short RubblemakerLarge = 5330;

		// Token: 0x04006309 RID: 25353
		public const short HorseshoeBundle = 5331;

		// Token: 0x0400630A RID: 25354
		public const short SpiffoPlush = 5332;

		// Token: 0x0400630B RID: 25355
		public const short GlowTulip = 5333;

		// Token: 0x0400630C RID: 25356
		public const short MechdusaSummon = 5334;

		// Token: 0x0400630D RID: 25357
		public const short RodOfHarmony = 5335;

		// Token: 0x0400630E RID: 25358
		public const short CombatBookVolumeTwo = 5336;

		// Token: 0x0400630F RID: 25359
		public const short AegisCrystal = 5337;

		// Token: 0x04006310 RID: 25360
		public const short AegisFruit = 5338;

		// Token: 0x04006311 RID: 25361
		public const short ArcaneCrystal = 5339;

		// Token: 0x04006312 RID: 25362
		public const short GalaxyPearl = 5340;

		// Token: 0x04006313 RID: 25363
		public const short GummyWorm = 5341;

		// Token: 0x04006314 RID: 25364
		public const short Ambrosia = 5342;

		// Token: 0x04006315 RID: 25365
		public const short PeddlersSatchel = 5343;

		// Token: 0x04006316 RID: 25366
		public const short EchoCoating = 5344;

		// Token: 0x04006317 RID: 25367
		public const short EchoMonolith = 5345;

		// Token: 0x04006318 RID: 25368
		public const short GasTrap = 5346;

		// Token: 0x04006319 RID: 25369
		public const short ShimmerMonolith = 5347;

		// Token: 0x0400631A RID: 25370
		public const short ShimmerArrow = 5348;

		// Token: 0x0400631B RID: 25371
		public const short ShimmerBlock = 5349;

		// Token: 0x0400631C RID: 25372
		public const short Shimmerfly = 5350;

		// Token: 0x0400631D RID: 25373
		public const short ShimmerflyinaBottle = 5351;

		// Token: 0x0400631E RID: 25374
		public const short ShimmerSlimeBanner = 5352;

		// Token: 0x0400631F RID: 25375
		public const short ShimmerTorch = 5353;

		// Token: 0x04006320 RID: 25376
		public const short ReflectiveShades = 5354;

		// Token: 0x04006321 RID: 25377
		public const short ShimmerCloak = 5355;

		// Token: 0x04006322 RID: 25378
		public const short UsedGasTrap = 5356;

		// Token: 0x04006323 RID: 25379
		public const short ShimmerCampfire = 5357;

		// Token: 0x04006324 RID: 25380
		public const short Shellphone = 5358;

		// Token: 0x04006325 RID: 25381
		public const short ShellphoneSpawn = 5359;

		// Token: 0x04006326 RID: 25382
		public const short ShellphoneOcean = 5360;

		// Token: 0x04006327 RID: 25383
		public const short ShellphoneHell = 5361;

		// Token: 0x04006328 RID: 25384
		public const short MusicBoxShimmer = 5362;

		// Token: 0x04006329 RID: 25385
		public const short SpiderWallUnsafe = 5363;

		// Token: 0x0400632A RID: 25386
		public const short BottomlessShimmerBucket = 5364;

		// Token: 0x0400632B RID: 25387
		public const short BlueBrickWallUnsafe = 5365;

		// Token: 0x0400632C RID: 25388
		public const short BlueSlabWallUnsafe = 5366;

		// Token: 0x0400632D RID: 25389
		public const short BlueTiledWallUnsafe = 5367;

		// Token: 0x0400632E RID: 25390
		public const short PinkBrickWallUnsafe = 5368;

		// Token: 0x0400632F RID: 25391
		public const short PinkSlabWallUnsafe = 5369;

		// Token: 0x04006330 RID: 25392
		public const short PinkTiledWallUnsafe = 5370;

		// Token: 0x04006331 RID: 25393
		public const short GreenBrickWallUnsafe = 5371;

		// Token: 0x04006332 RID: 25394
		public const short GreenSlabWallUnsafe = 5372;

		// Token: 0x04006333 RID: 25395
		public const short GreenTiledWallUnsafe = 5373;

		// Token: 0x04006334 RID: 25396
		public const short SandstoneWallUnsafe = 5374;

		// Token: 0x04006335 RID: 25397
		public const short HardenedSandWallUnsafe = 5375;

		// Token: 0x04006336 RID: 25398
		public const short LihzahrdWallUnsafe = 5376;

		// Token: 0x04006337 RID: 25399
		public const short SpelunkerFlare = 5377;

		// Token: 0x04006338 RID: 25400
		public const short CursedFlare = 5378;

		// Token: 0x04006339 RID: 25401
		public const short RainbowFlare = 5379;

		// Token: 0x0400633A RID: 25402
		public const short ShimmerFlare = 5380;

		// Token: 0x0400633B RID: 25403
		public const short Moondial = 5381;

		// Token: 0x0400633C RID: 25404
		public const short WaffleIron = 5382;

		// Token: 0x0400633D RID: 25405
		public const short BouncyBoulder = 5383;

		// Token: 0x0400633E RID: 25406
		public const short LifeCrystalBoulder = 5384;

		// Token: 0x0400633F RID: 25407
		public const short DizzyHat = 5385;

		// Token: 0x04006340 RID: 25408
		public const short LincolnsHoodie = 5386;

		// Token: 0x04006341 RID: 25409
		public const short LincolnsPants = 5387;

		// Token: 0x04006342 RID: 25410
		public const short SunOrnament = 5388;

		// Token: 0x04006343 RID: 25411
		public const short HoplitePizza = 5389;

		// Token: 0x04006344 RID: 25412
		public const short LincolnsHood = 5390;

		// Token: 0x04006345 RID: 25413
		public const short UncumberingStone = 5391;

		// Token: 0x04006346 RID: 25414
		public const short SandSolution = 5392;

		// Token: 0x04006347 RID: 25415
		public const short SnowSolution = 5393;

		// Token: 0x04006348 RID: 25416
		public const short DirtSolution = 5394;

		// Token: 0x04006349 RID: 25417
		public const short PoopBlock = 5395;

		// Token: 0x0400634A RID: 25418
		public const short PoopWall = 5396;

		// Token: 0x0400634B RID: 25419
		public const short ShimmerWall = 5397;

		// Token: 0x0400634C RID: 25420
		public const short ShimmerBrick = 5398;

		// Token: 0x0400634D RID: 25421
		public const short ShimmerBrickWall = 5399;

		// Token: 0x0400634E RID: 25422
		public const short DirtiestBlock = 5400;

		// Token: 0x0400634F RID: 25423
		public const short LunarRustBrick = 5401;

		// Token: 0x04006350 RID: 25424
		public const short DarkCelestialBrick = 5402;

		// Token: 0x04006351 RID: 25425
		public const short AstraBrick = 5403;

		// Token: 0x04006352 RID: 25426
		public const short CosmicEmberBrick = 5404;

		// Token: 0x04006353 RID: 25427
		public const short CryocoreBrick = 5405;

		// Token: 0x04006354 RID: 25428
		public const short MercuryBrick = 5406;

		// Token: 0x04006355 RID: 25429
		public const short StarRoyaleBrick = 5407;

		// Token: 0x04006356 RID: 25430
		public const short HeavenforgeBrick = 5408;

		// Token: 0x04006357 RID: 25431
		public const short LunarRustBrickWall = 5409;

		// Token: 0x04006358 RID: 25432
		public const short DarkCelestialBrickWall = 5410;

		// Token: 0x04006359 RID: 25433
		public const short AstraBrickWall = 5411;

		// Token: 0x0400635A RID: 25434
		public const short CosmicEmberBrickWall = 5412;

		// Token: 0x0400635B RID: 25435
		public const short CryocoreBrickWall = 5413;

		// Token: 0x0400635C RID: 25436
		public const short MercuryBrickWall = 5414;

		// Token: 0x0400635D RID: 25437
		public const short StarRoyaleBrickWall = 5415;

		// Token: 0x0400635E RID: 25438
		public const short HeavenforgeBrickWall = 5416;

		// Token: 0x0400635F RID: 25439
		public const short AncientBlueDungeonBrick = 5417;

		// Token: 0x04006360 RID: 25440
		public const short AncientBlueDungeonBrickWall = 5418;

		// Token: 0x04006361 RID: 25441
		public const short AncientGreenDungeonBrick = 5419;

		// Token: 0x04006362 RID: 25442
		public const short AncientGreenDungeonBrickWall = 5420;

		// Token: 0x04006363 RID: 25443
		public const short AncientPinkDungeonBrick = 5421;

		// Token: 0x04006364 RID: 25444
		public const short AncientPinkDungeonBrickWall = 5422;

		// Token: 0x04006365 RID: 25445
		public const short AncientGoldBrick = 5423;

		// Token: 0x04006366 RID: 25446
		public const short AncientGoldBrickWall = 5424;

		// Token: 0x04006367 RID: 25447
		public const short AncientSilverBrick = 5425;

		// Token: 0x04006368 RID: 25448
		public const short AncientSilverBrickWall = 5426;

		// Token: 0x04006369 RID: 25449
		public const short AncientCopperBrick = 5427;

		// Token: 0x0400636A RID: 25450
		public const short AncientCopperBrickWall = 5428;

		// Token: 0x0400636B RID: 25451
		public const short AncientCobaltBrick = 5429;

		// Token: 0x0400636C RID: 25452
		public const short AncientCobaltBrickWall = 5430;

		// Token: 0x0400636D RID: 25453
		public const short AncientMythrilBrick = 5431;

		// Token: 0x0400636E RID: 25454
		public const short AncientMythrilBrickWall = 5432;

		// Token: 0x0400636F RID: 25455
		public const short AncientObsidianBrick = 5433;

		// Token: 0x04006370 RID: 25456
		public const short AncientObsidianBrickWall = 5434;

		// Token: 0x04006371 RID: 25457
		public const short AncientHellstoneBrick = 5435;

		// Token: 0x04006372 RID: 25458
		public const short AncientHellstoneBrickWall = 5436;

		// Token: 0x04006373 RID: 25459
		public const short ShellphoneDummy = 5437;

		// Token: 0x04006374 RID: 25460
		public const short Fertilizer = 5438;

		// Token: 0x04006375 RID: 25461
		public const short LavaMossBlock = 5439;

		// Token: 0x04006376 RID: 25462
		public const short ArgonMossBlock = 5440;

		// Token: 0x04006377 RID: 25463
		public const short KryptonMossBlock = 5441;

		// Token: 0x04006378 RID: 25464
		public const short XenonMossBlock = 5442;

		// Token: 0x04006379 RID: 25465
		public const short VioletMossBlock = 5443;

		// Token: 0x0400637A RID: 25466
		public const short RainbowMossBlock = 5444;

		// Token: 0x0400637B RID: 25467
		public const short LavaMossBlockWall = 5445;

		// Token: 0x0400637C RID: 25468
		public const short ArgonMossBlockWall = 5446;

		// Token: 0x0400637D RID: 25469
		public const short KryptonMossBlockWall = 5447;

		// Token: 0x0400637E RID: 25470
		public const short XenonMossBlockWall = 5448;

		// Token: 0x0400637F RID: 25471
		public const short VioletMossBlockWall = 5449;

		// Token: 0x04006380 RID: 25472
		public const short RainbowMossBlockWall = 5450;

		// Token: 0x04006381 RID: 25473
		public const short JimsDrone = 5451;

		// Token: 0x04006382 RID: 25474
		public const short JimsDroneVisor = 5452;

		// Token: 0x04006383 RID: 25475
		public const short DontHurtCrittersBookInactive = 5453;

		// Token: 0x04006384 RID: 25476
		public const short DontHurtNatureBookInactive = 5454;

		// Token: 0x04006385 RID: 25477
		public const short DontHurtComboBookInactive = 5455;

		// Token: 0x04006386 RID: 25478
		public const short Count = 5456;

		// Token: 0x04006387 RID: 25479
		public static readonly IdDictionary Search;

		// Token: 0x020005D2 RID: 1490
		public struct BannerEffect
		{
			// Token: 0x06003554 RID: 13652 RVA: 0x0020B684 File Offset: 0x00209884
			public BannerEffect(float strength = 1f)
			{
			}

			// Token: 0x06003555 RID: 13653 RVA: 0x0020B694 File Offset: 0x00209894
			public BannerEffect(float normalDamageDealt, float expertDamageDealt, float normalDamageReceived, float expertDamageReceived)
			{
				this.Enabled = true;
			}

			// Token: 0x06003556 RID: 13654 RVA: 0x0020B6A8 File Offset: 0x002098A8
			// Note: this type is marked as 'beforefieldinit'.
			static BannerEffect()
			{
			}

			// Token: 0x04006388 RID: 25480
			public static readonly ItemID.BannerEffect None;

			// Token: 0x04006389 RID: 25481
			public static readonly ItemID.BannerEffect Reduced;

			// Token: 0x0400638A RID: 25482
			public readonly float NormalDamageDealt;

			// Token: 0x0400638B RID: 25483
			public readonly float ExpertDamageDealt;

			// Token: 0x0400638C RID: 25484
			public readonly float NormalDamageReceived;

			// Token: 0x0400638D RID: 25485
			public readonly float ExpertDamageReceived;

			// Token: 0x0400638E RID: 25486
			public readonly bool Enabled;
		}

		// Token: 0x020005D3 RID: 1491
		public class Sets
		{
			// Token: 0x06003557 RID: 13655 RVA: 0x0020B6B8 File Offset: 0x002098B8
			public Sets()
			{
			}

			// Token: 0x06003558 RID: 13656 RVA: 0x0020B6CC File Offset: 0x002098CC
			// Note: this type is marked as 'beforefieldinit'.
			static Sets()
			{
			}

			// Token: 0x0400638F RID: 25487
			public static SetFactory Factory;

			// Token: 0x04006390 RID: 25488
			public static List<int> ItemsThatAreProcessedAfterNormalContentSample;

			// Token: 0x04006391 RID: 25489
			public static bool[] IsLavaImmuneRegardlessOfRarity;

			// Token: 0x04006392 RID: 25490
			public static bool[] ItemsThatAllowRepeatedRightClick;

			// Token: 0x04006393 RID: 25491
			public static bool[] ItemsThatCountAsBombsForDemolitionistToSpawn;

			// Token: 0x04006394 RID: 25492
			public static bool[] ItemsThatShouldNotBeInInventory;

			// Token: 0x04006395 RID: 25493
			public static bool[] DrawUnsafeIndicator;

			// Token: 0x04006396 RID: 25494
			public static bool[] UsesBetterMeleeItemLocation;

			// Token: 0x04006397 RID: 25495
			public static bool[] WorksInVoidBag;

			// Token: 0x04006398 RID: 25496
			public static bool[] GrassSeeds;

			// Token: 0x04006399 RID: 25497
			public static int[] ShimmerTransformToItem;

			// Token: 0x0400639A RID: 25498
			public static int[] ShimmerCountsAsItem;

			// Token: 0x0400639B RID: 25499
			public static int[] OverflowProtectionTimeOffset;

			// Token: 0x0400639C RID: 25500
			public static int[] ItemsForStuffCannon;

			// Token: 0x0400639D RID: 25501
			public static bool?[] CanBeQuickusedOnGamepad;

			// Token: 0x0400639E RID: 25502
			public static bool?[] ForcesBreaksSleeping;

			// Token: 0x0400639F RID: 25503
			public static bool[] SkipsInitialUseSound;

			// Token: 0x040063A0 RID: 25504
			public static bool[] UsesCursedByPlanteraTooltip;

			// Token: 0x040063A1 RID: 25505
			public static bool[] IsAKite;

			// Token: 0x040063A2 RID: 25506
			public static bool?[] ForceConsumption;

			// Token: 0x040063A3 RID: 25507
			public static bool[] HasAProjectileThatHasAUsabilityCheck;

			// Token: 0x040063A4 RID: 25508
			public static bool[] CanGetPrefixes;

			// Token: 0x040063A5 RID: 25509
			public static List<int> NonColorfulDyeItems;

			// Token: 0x040063A6 RID: 25510
			public static bool[] ColorfulDyeValues;

			// Token: 0x040063A7 RID: 25511
			public static FlowerPacketInfo[] flowerPacketInfo;

			// Token: 0x040063A8 RID: 25512
			public static bool[] IsAMaterial;

			// Token: 0x040063A9 RID: 25513
			public static int[] IsCrafted;

			// Token: 0x040063AA RID: 25514
			public static int[] IsCraftedCrimson;

			// Token: 0x040063AB RID: 25515
			public static int[] IsCraftedCorruption;

			// Token: 0x040063AC RID: 25516
			public static bool[] IgnoresEncumberingStone;

			// Token: 0x040063AD RID: 25517
			public static float[] ToolTipDamageMultiplier;

			// Token: 0x040063AE RID: 25518
			public static bool[] IsAPickup;

			// Token: 0x040063AF RID: 25519
			public static bool[] IsDrill;

			// Token: 0x040063B0 RID: 25520
			public static bool[] IsChainsaw;

			// Token: 0x040063B1 RID: 25521
			public static bool[] IsPaintScraper;

			// Token: 0x040063B2 RID: 25522
			public static bool[] SummonerWeaponThatScalesWithAttackSpeed;

			// Token: 0x040063B3 RID: 25523
			public static bool[] IsFood;

			// Token: 0x040063B4 RID: 25524
			public static Color[][] FoodParticleColors;

			// Token: 0x040063B5 RID: 25525
			public static Color[][] DrinkParticleColors;

			// Token: 0x040063B6 RID: 25526
			private static ItemID.BannerEffect DD2BannerEffect;

			// Token: 0x040063B7 RID: 25527
			public static ItemID.BannerEffect[] BannerStrength;

			// Token: 0x040063B8 RID: 25528
			public static int DefaultKillsForBannerNeeded;

			// Token: 0x040063B9 RID: 25529
			public static int[] KillsToBanner;

			// Token: 0x040063BA RID: 25530
			public static bool[] CanFishInLava;

			// Token: 0x040063BB RID: 25531
			public static bool[] IsLavaBait;

			// Token: 0x040063BC RID: 25532
			private const int healingItemsDecayRate = 4;

			// Token: 0x040063BD RID: 25533
			public static int[] ItemSpawnDecaySpeed;

			// Token: 0x040063BE RID: 25534
			public static bool[] IsFishingCrate;

			// Token: 0x040063BF RID: 25535
			public static bool[] IsFishingCrateHardmode;

			// Token: 0x040063C0 RID: 25536
			public static bool[] CanBePlacedOnWeaponRacks;

			// Token: 0x040063C1 RID: 25537
			public static int[] TextureCopyLoad;

			// Token: 0x040063C2 RID: 25538
			public static bool[] TrapSigned;

			// Token: 0x040063C3 RID: 25539
			public static bool[] Deprecated;

			// Token: 0x040063C4 RID: 25540
			public static bool[] NeverAppearsAsNewInInventory;

			// Token: 0x040063C5 RID: 25541
			public static bool[] CommonCoin;

			// Token: 0x040063C6 RID: 25542
			public static bool[] ItemIconPulse;

			// Token: 0x040063C7 RID: 25543
			public static bool[] ItemNoGravity;

			// Token: 0x040063C8 RID: 25544
			public static int[] ExtractinatorMode;

			// Token: 0x040063C9 RID: 25545
			public static int[] StaffMinionSlotsRequired;

			// Token: 0x040063CA RID: 25546
			public static bool[] ExoticPlantsForDyeTrade;

			// Token: 0x040063CB RID: 25547
			public static bool[] NebulaPickup;

			// Token: 0x040063CC RID: 25548
			public static bool[] AnimatesAsSoul;

			// Token: 0x040063CD RID: 25549
			public static bool[] gunProj;

			// Token: 0x040063CE RID: 25550
			public static int[] SortingPriorityBossSpawns;

			// Token: 0x040063CF RID: 25551
			public static int[] SortingPriorityWiring;

			// Token: 0x040063D0 RID: 25552
			public static int[] SortingPriorityMaterials;

			// Token: 0x040063D1 RID: 25553
			public static int[] SortingPriorityExtractibles;

			// Token: 0x040063D2 RID: 25554
			public static int[] SortingPriorityRopes;

			// Token: 0x040063D3 RID: 25555
			public static int[] SortingPriorityPainting;

			// Token: 0x040063D4 RID: 25556
			public static int[] SortingPriorityTerraforming;

			// Token: 0x040063D5 RID: 25557
			public static int[] GamepadExtraRange;

			// Token: 0x040063D6 RID: 25558
			public static bool[] GamepadWholeScreenUseRange;

			// Token: 0x040063D7 RID: 25559
			public static float[] BonusMeleeSpeedMultiplier;

			// Token: 0x040063D8 RID: 25560
			public static bool[] GamepadSmartQuickReach;

			// Token: 0x040063D9 RID: 25561
			public static bool[] Yoyo;

			// Token: 0x040063DA RID: 25562
			public static bool[] AlsoABuildingItem;

			// Token: 0x040063DB RID: 25563
			public static bool[] LockOnIgnoresCollision;

			// Token: 0x040063DC RID: 25564
			public static int[] LockOnAimAbove;

			// Token: 0x040063DD RID: 25565
			public static float?[] LockOnAimCompensation;

			// Token: 0x040063DE RID: 25566
			public static bool[] SingleUseInGamepad;

			// Token: 0x040063DF RID: 25567
			public static bool[] Torches;

			// Token: 0x040063E0 RID: 25568
			public static bool[] WaterTorches;

			// Token: 0x040063E1 RID: 25569
			public static short[] Workbenches;

			// Token: 0x040063E2 RID: 25570
			public static bool[] BossBag;

			// Token: 0x040063E3 RID: 25571
			public static bool[] OpenableBag;
		}
	}
}
