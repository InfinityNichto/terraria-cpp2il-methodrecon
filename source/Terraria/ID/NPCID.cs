using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Reflection;
using Terraria.DataStructures;

namespace Terraria.ID
{
	// Token: 0x020005DF RID: 1503
	public class NPCID
	{
		// Token: 0x06003563 RID: 13667 RVA: 0x0020E4C8 File Offset: 0x0020C6C8
		public static int FromLegacyName(string name)
		{
			/*
An exception occurred when decompiling this method (06003563)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.ID.NPCID::FromLegacyName(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
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

		// Token: 0x06003564 RID: 13668 RVA: 0x0020E4D8 File Offset: 0x0020C6D8
		public static int FromNetId(int id)
		{
			/*
An exception occurred when decompiling this method (06003564)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.ID.NPCID::FromNetId(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
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

		// Token: 0x06003565 RID: 13669 RVA: 0x0020E4E8 File Offset: 0x0020C6E8
		public NPCID()
		{
		}

		// Token: 0x06003566 RID: 13670 RVA: 0x0020E4FC File Offset: 0x0020C6FC
		// Note: this type is marked as 'beforefieldinit'.
		static NPCID()
		{
			IdDictionary idDictionary = IdDictionary.Create();
		}

		// Token: 0x04006573 RID: 25971
		private static readonly int[] NetIdMap;

		// Token: 0x04006574 RID: 25972
		private static readonly Dictionary<string, int> LegacyNameToIdMap;

		// Token: 0x04006575 RID: 25973
		public const short NegativeIDCount = -66;

		// Token: 0x04006576 RID: 25974
		public const short BigHornetStingy = -65;

		// Token: 0x04006577 RID: 25975
		public const short LittleHornetStingy = -64;

		// Token: 0x04006578 RID: 25976
		public const short BigHornetSpikey = -63;

		// Token: 0x04006579 RID: 25977
		public const short LittleHornetSpikey = -62;

		// Token: 0x0400657A RID: 25978
		public const short BigHornetLeafy = -61;

		// Token: 0x0400657B RID: 25979
		public const short LittleHornetLeafy = -60;

		// Token: 0x0400657C RID: 25980
		public const short BigHornetHoney = -59;

		// Token: 0x0400657D RID: 25981
		public const short LittleHornetHoney = -58;

		// Token: 0x0400657E RID: 25982
		public const short BigHornetFatty = -57;

		// Token: 0x0400657F RID: 25983
		public const short LittleHornetFatty = -56;

		// Token: 0x04006580 RID: 25984
		public const short BigRainZombie = -55;

		// Token: 0x04006581 RID: 25985
		public const short SmallRainZombie = -54;

		// Token: 0x04006582 RID: 25986
		public const short BigPantlessSkeleton = -53;

		// Token: 0x04006583 RID: 25987
		public const short SmallPantlessSkeleton = -52;

		// Token: 0x04006584 RID: 25988
		public const short BigMisassembledSkeleton = -51;

		// Token: 0x04006585 RID: 25989
		public const short SmallMisassembledSkeleton = -50;

		// Token: 0x04006586 RID: 25990
		public const short BigHeadacheSkeleton = -49;

		// Token: 0x04006587 RID: 25991
		public const short SmallHeadacheSkeleton = -48;

		// Token: 0x04006588 RID: 25992
		public const short BigSkeleton = -47;

		// Token: 0x04006589 RID: 25993
		public const short SmallSkeleton = -46;

		// Token: 0x0400658A RID: 25994
		public const short BigFemaleZombie = -45;

		// Token: 0x0400658B RID: 25995
		public const short SmallFemaleZombie = -44;

		// Token: 0x0400658C RID: 25996
		public const short DemonEye2 = -43;

		// Token: 0x0400658D RID: 25997
		public const short PurpleEye2 = -42;

		// Token: 0x0400658E RID: 25998
		public const short GreenEye2 = -41;

		// Token: 0x0400658F RID: 25999
		public const short DialatedEye2 = -40;

		// Token: 0x04006590 RID: 26000
		public const short SleepyEye2 = -39;

		// Token: 0x04006591 RID: 26001
		public const short CataractEye2 = -38;

		// Token: 0x04006592 RID: 26002
		public const short BigTwiggyZombie = -37;

		// Token: 0x04006593 RID: 26003
		public const short SmallTwiggyZombie = -36;

		// Token: 0x04006594 RID: 26004
		public const short BigSwampZombie = -35;

		// Token: 0x04006595 RID: 26005
		public const short SmallSwampZombie = -34;

		// Token: 0x04006596 RID: 26006
		public const short BigSlimedZombie = -33;

		// Token: 0x04006597 RID: 26007
		public const short SmallSlimedZombie = -32;

		// Token: 0x04006598 RID: 26008
		public const short BigPincushionZombie = -31;

		// Token: 0x04006599 RID: 26009
		public const short SmallPincushionZombie = -30;

		// Token: 0x0400659A RID: 26010
		public const short BigBaldZombie = -29;

		// Token: 0x0400659B RID: 26011
		public const short SmallBaldZombie = -28;

		// Token: 0x0400659C RID: 26012
		public const short BigZombie = -27;

		// Token: 0x0400659D RID: 26013
		public const short SmallZombie = -26;

		// Token: 0x0400659E RID: 26014
		public const short BigCrimslime = -25;

		// Token: 0x0400659F RID: 26015
		public const short LittleCrimslime = -24;

		// Token: 0x040065A0 RID: 26016
		public const short BigCrimera = -23;

		// Token: 0x040065A1 RID: 26017
		public const short LittleCrimera = -22;

		// Token: 0x040065A2 RID: 26018
		public const short GiantMossHornet = -21;

		// Token: 0x040065A3 RID: 26019
		public const short BigMossHornet = -20;

		// Token: 0x040065A4 RID: 26020
		public const short LittleMossHornet = -19;

		// Token: 0x040065A5 RID: 26021
		public const short TinyMossHornet = -18;

		// Token: 0x040065A6 RID: 26022
		public const short BigStinger = -17;

		// Token: 0x040065A7 RID: 26023
		public const short LittleStinger = -16;

		// Token: 0x040065A8 RID: 26024
		public const short HeavySkeleton = -15;

		// Token: 0x040065A9 RID: 26025
		public const short BigBoned = -14;

		// Token: 0x040065AA RID: 26026
		public const short ShortBones = -13;

		// Token: 0x040065AB RID: 26027
		public const short BigEater = -12;

		// Token: 0x040065AC RID: 26028
		public const short LittleEater = -11;

		// Token: 0x040065AD RID: 26029
		public const short JungleSlime = -10;

		// Token: 0x040065AE RID: 26030
		public const short YellowSlime = -9;

		// Token: 0x040065AF RID: 26031
		public const short RedSlime = -8;

		// Token: 0x040065B0 RID: 26032
		public const short PurpleSlime = -7;

		// Token: 0x040065B1 RID: 26033
		public const short BlackSlime = -6;

		// Token: 0x040065B2 RID: 26034
		public const short BabySlime = -5;

		// Token: 0x040065B3 RID: 26035
		public const short Pinky = -4;

		// Token: 0x040065B4 RID: 26036
		public const short GreenSlime = -3;

		// Token: 0x040065B5 RID: 26037
		public const short Slimer2 = -2;

		// Token: 0x040065B6 RID: 26038
		public const short Slimeling = -1;

		// Token: 0x040065B7 RID: 26039
		public const short None = 0;

		// Token: 0x040065B8 RID: 26040
		public const short BlueSlime = 1;

		// Token: 0x040065B9 RID: 26041
		public const short DemonEye = 2;

		// Token: 0x040065BA RID: 26042
		public const short Zombie = 3;

		// Token: 0x040065BB RID: 26043
		public const short EyeofCthulhu = 4;

		// Token: 0x040065BC RID: 26044
		public const short ServantofCthulhu = 5;

		// Token: 0x040065BD RID: 26045
		public const short EaterofSouls = 6;

		// Token: 0x040065BE RID: 26046
		public const short DevourerHead = 7;

		// Token: 0x040065BF RID: 26047
		public const short DevourerBody = 8;

		// Token: 0x040065C0 RID: 26048
		public const short DevourerTail = 9;

		// Token: 0x040065C1 RID: 26049
		public const short GiantWormHead = 10;

		// Token: 0x040065C2 RID: 26050
		public const short GiantWormBody = 11;

		// Token: 0x040065C3 RID: 26051
		public const short GiantWormTail = 12;

		// Token: 0x040065C4 RID: 26052
		public const short EaterofWorldsHead = 13;

		// Token: 0x040065C5 RID: 26053
		public const short EaterofWorldsBody = 14;

		// Token: 0x040065C6 RID: 26054
		public const short EaterofWorldsTail = 15;

		// Token: 0x040065C7 RID: 26055
		public const short MotherSlime = 16;

		// Token: 0x040065C8 RID: 26056
		public const short Merchant = 17;

		// Token: 0x040065C9 RID: 26057
		public const short Nurse = 18;

		// Token: 0x040065CA RID: 26058
		public const short ArmsDealer = 19;

		// Token: 0x040065CB RID: 26059
		public const short Dryad = 20;

		// Token: 0x040065CC RID: 26060
		public const short Skeleton = 21;

		// Token: 0x040065CD RID: 26061
		public const short Guide = 22;

		// Token: 0x040065CE RID: 26062
		public const short MeteorHead = 23;

		// Token: 0x040065CF RID: 26063
		public const short FireImp = 24;

		// Token: 0x040065D0 RID: 26064
		public const short BurningSphere = 25;

		// Token: 0x040065D1 RID: 26065
		public const short GoblinPeon = 26;

		// Token: 0x040065D2 RID: 26066
		public const short GoblinThief = 27;

		// Token: 0x040065D3 RID: 26067
		public const short GoblinWarrior = 28;

		// Token: 0x040065D4 RID: 26068
		public const short GoblinSorcerer = 29;

		// Token: 0x040065D5 RID: 26069
		public const short ChaosBall = 30;

		// Token: 0x040065D6 RID: 26070
		public const short AngryBones = 31;

		// Token: 0x040065D7 RID: 26071
		public const short DarkCaster = 32;

		// Token: 0x040065D8 RID: 26072
		public const short WaterSphere = 33;

		// Token: 0x040065D9 RID: 26073
		public const short CursedSkull = 34;

		// Token: 0x040065DA RID: 26074
		public const short SkeletronHead = 35;

		// Token: 0x040065DB RID: 26075
		public const short SkeletronHand = 36;

		// Token: 0x040065DC RID: 26076
		public const short OldMan = 37;

		// Token: 0x040065DD RID: 26077
		public const short Demolitionist = 38;

		// Token: 0x040065DE RID: 26078
		public const short BoneSerpentHead = 39;

		// Token: 0x040065DF RID: 26079
		public const short BoneSerpentBody = 40;

		// Token: 0x040065E0 RID: 26080
		public const short BoneSerpentTail = 41;

		// Token: 0x040065E1 RID: 26081
		public const short Hornet = 42;

		// Token: 0x040065E2 RID: 26082
		public const short ManEater = 43;

		// Token: 0x040065E3 RID: 26083
		public const short UndeadMiner = 44;

		// Token: 0x040065E4 RID: 26084
		public const short Tim = 45;

		// Token: 0x040065E5 RID: 26085
		public const short Bunny = 46;

		// Token: 0x040065E6 RID: 26086
		public const short CorruptBunny = 47;

		// Token: 0x040065E7 RID: 26087
		public const short Harpy = 48;

		// Token: 0x040065E8 RID: 26088
		public const short CaveBat = 49;

		// Token: 0x040065E9 RID: 26089
		public const short KingSlime = 50;

		// Token: 0x040065EA RID: 26090
		public const short JungleBat = 51;

		// Token: 0x040065EB RID: 26091
		public const short DoctorBones = 52;

		// Token: 0x040065EC RID: 26092
		public const short TheGroom = 53;

		// Token: 0x040065ED RID: 26093
		public const short Clothier = 54;

		// Token: 0x040065EE RID: 26094
		public const short Goldfish = 55;

		// Token: 0x040065EF RID: 26095
		public const short Snatcher = 56;

		// Token: 0x040065F0 RID: 26096
		public const short CorruptGoldfish = 57;

		// Token: 0x040065F1 RID: 26097
		public const short Piranha = 58;

		// Token: 0x040065F2 RID: 26098
		public const short LavaSlime = 59;

		// Token: 0x040065F3 RID: 26099
		public const short Hellbat = 60;

		// Token: 0x040065F4 RID: 26100
		public const short Vulture = 61;

		// Token: 0x040065F5 RID: 26101
		public const short Demon = 62;

		// Token: 0x040065F6 RID: 26102
		public const short BlueJellyfish = 63;

		// Token: 0x040065F7 RID: 26103
		public const short PinkJellyfish = 64;

		// Token: 0x040065F8 RID: 26104
		public const short Shark = 65;

		// Token: 0x040065F9 RID: 26105
		public const short VoodooDemon = 66;

		// Token: 0x040065FA RID: 26106
		public const short Crab = 67;

		// Token: 0x040065FB RID: 26107
		public const short DungeonGuardian = 68;

		// Token: 0x040065FC RID: 26108
		public const short Antlion = 69;

		// Token: 0x040065FD RID: 26109
		public const short SpikeBall = 70;

		// Token: 0x040065FE RID: 26110
		public const short DungeonSlime = 71;

		// Token: 0x040065FF RID: 26111
		public const short BlazingWheel = 72;

		// Token: 0x04006600 RID: 26112
		public const short GoblinScout = 73;

		// Token: 0x04006601 RID: 26113
		public const short Bird = 74;

		// Token: 0x04006602 RID: 26114
		public const short Pixie = 75;

		// Token: 0x04006603 RID: 26115
		public const short None2 = 76;

		// Token: 0x04006604 RID: 26116
		public const short ArmoredSkeleton = 77;

		// Token: 0x04006605 RID: 26117
		public const short Mummy = 78;

		// Token: 0x04006606 RID: 26118
		public const short DarkMummy = 79;

		// Token: 0x04006607 RID: 26119
		public const short LightMummy = 80;

		// Token: 0x04006608 RID: 26120
		public const short CorruptSlime = 81;

		// Token: 0x04006609 RID: 26121
		public const short Wraith = 82;

		// Token: 0x0400660A RID: 26122
		public const short CursedHammer = 83;

		// Token: 0x0400660B RID: 26123
		public const short EnchantedSword = 84;

		// Token: 0x0400660C RID: 26124
		public const short Mimic = 85;

		// Token: 0x0400660D RID: 26125
		public const short Unicorn = 86;

		// Token: 0x0400660E RID: 26126
		public const short WyvernHead = 87;

		// Token: 0x0400660F RID: 26127
		public const short WyvernLegs = 88;

		// Token: 0x04006610 RID: 26128
		public const short WyvernBody = 89;

		// Token: 0x04006611 RID: 26129
		public const short WyvernBody2 = 90;

		// Token: 0x04006612 RID: 26130
		public const short WyvernBody3 = 91;

		// Token: 0x04006613 RID: 26131
		public const short WyvernTail = 92;

		// Token: 0x04006614 RID: 26132
		public const short GiantBat = 93;

		// Token: 0x04006615 RID: 26133
		public const short Corruptor = 94;

		// Token: 0x04006616 RID: 26134
		public const short DiggerHead = 95;

		// Token: 0x04006617 RID: 26135
		public const short DiggerBody = 96;

		// Token: 0x04006618 RID: 26136
		public const short DiggerTail = 97;

		// Token: 0x04006619 RID: 26137
		public const short SeekerHead = 98;

		// Token: 0x0400661A RID: 26138
		public const short SeekerBody = 99;

		// Token: 0x0400661B RID: 26139
		public const short SeekerTail = 100;

		// Token: 0x0400661C RID: 26140
		public const short Clinger = 101;

		// Token: 0x0400661D RID: 26141
		public const short AnglerFish = 102;

		// Token: 0x0400661E RID: 26142
		public const short GreenJellyfish = 103;

		// Token: 0x0400661F RID: 26143
		public const short Werewolf = 104;

		// Token: 0x04006620 RID: 26144
		public const short BoundGoblin = 105;

		// Token: 0x04006621 RID: 26145
		public const short BoundWizard = 106;

		// Token: 0x04006622 RID: 26146
		public const short GoblinTinkerer = 107;

		// Token: 0x04006623 RID: 26147
		public const short Wizard = 108;

		// Token: 0x04006624 RID: 26148
		public const short Clown = 109;

		// Token: 0x04006625 RID: 26149
		public const short SkeletonArcher = 110;

		// Token: 0x04006626 RID: 26150
		public const short GoblinArcher = 111;

		// Token: 0x04006627 RID: 26151
		public const short VileSpit = 112;

		// Token: 0x04006628 RID: 26152
		public const short WallofFlesh = 113;

		// Token: 0x04006629 RID: 26153
		public const short WallofFleshEye = 114;

		// Token: 0x0400662A RID: 26154
		public const short TheHungry = 115;

		// Token: 0x0400662B RID: 26155
		public const short TheHungryII = 116;

		// Token: 0x0400662C RID: 26156
		public const short LeechHead = 117;

		// Token: 0x0400662D RID: 26157
		public const short LeechBody = 118;

		// Token: 0x0400662E RID: 26158
		public const short LeechTail = 119;

		// Token: 0x0400662F RID: 26159
		public const short ChaosElemental = 120;

		// Token: 0x04006630 RID: 26160
		public const short Slimer = 121;

		// Token: 0x04006631 RID: 26161
		public const short Gastropod = 122;

		// Token: 0x04006632 RID: 26162
		public const short BoundMechanic = 123;

		// Token: 0x04006633 RID: 26163
		public const short Mechanic = 124;

		// Token: 0x04006634 RID: 26164
		public const short Retinazer = 125;

		// Token: 0x04006635 RID: 26165
		public const short Spazmatism = 126;

		// Token: 0x04006636 RID: 26166
		public const short SkeletronPrime = 127;

		// Token: 0x04006637 RID: 26167
		public const short PrimeCannon = 128;

		// Token: 0x04006638 RID: 26168
		public const short PrimeSaw = 129;

		// Token: 0x04006639 RID: 26169
		public const short PrimeVice = 130;

		// Token: 0x0400663A RID: 26170
		public const short PrimeLaser = 131;

		// Token: 0x0400663B RID: 26171
		public const short BaldZombie = 132;

		// Token: 0x0400663C RID: 26172
		public const short WanderingEye = 133;

		// Token: 0x0400663D RID: 26173
		public const short TheDestroyer = 134;

		// Token: 0x0400663E RID: 26174
		public const short TheDestroyerBody = 135;

		// Token: 0x0400663F RID: 26175
		public const short TheDestroyerTail = 136;

		// Token: 0x04006640 RID: 26176
		public const short IlluminantBat = 137;

		// Token: 0x04006641 RID: 26177
		public const short IlluminantSlime = 138;

		// Token: 0x04006642 RID: 26178
		public const short Probe = 139;

		// Token: 0x04006643 RID: 26179
		public const short PossessedArmor = 140;

		// Token: 0x04006644 RID: 26180
		public const short ToxicSludge = 141;

		// Token: 0x04006645 RID: 26181
		public const short SantaClaus = 142;

		// Token: 0x04006646 RID: 26182
		public const short SnowmanGangsta = 143;

		// Token: 0x04006647 RID: 26183
		public const short MisterStabby = 144;

		// Token: 0x04006648 RID: 26184
		public const short SnowBalla = 145;

		// Token: 0x04006649 RID: 26185
		public const short None3 = 146;

		// Token: 0x0400664A RID: 26186
		public const short IceSlime = 147;

		// Token: 0x0400664B RID: 26187
		public const short Penguin = 148;

		// Token: 0x0400664C RID: 26188
		public const short PenguinBlack = 149;

		// Token: 0x0400664D RID: 26189
		public const short IceBat = 150;

		// Token: 0x0400664E RID: 26190
		public const short Lavabat = 151;

		// Token: 0x0400664F RID: 26191
		public const short GiantFlyingFox = 152;

		// Token: 0x04006650 RID: 26192
		public const short GiantTortoise = 153;

		// Token: 0x04006651 RID: 26193
		public const short IceTortoise = 154;

		// Token: 0x04006652 RID: 26194
		public const short Wolf = 155;

		// Token: 0x04006653 RID: 26195
		public const short RedDevil = 156;

		// Token: 0x04006654 RID: 26196
		public const short Arapaima = 157;

		// Token: 0x04006655 RID: 26197
		public const short VampireBat = 158;

		// Token: 0x04006656 RID: 26198
		public const short Vampire = 159;

		// Token: 0x04006657 RID: 26199
		public const short Truffle = 160;

		// Token: 0x04006658 RID: 26200
		public const short ZombieEskimo = 161;

		// Token: 0x04006659 RID: 26201
		public const short Frankenstein = 162;

		// Token: 0x0400665A RID: 26202
		public const short BlackRecluse = 163;

		// Token: 0x0400665B RID: 26203
		public const short WallCreeper = 164;

		// Token: 0x0400665C RID: 26204
		public const short WallCreeperWall = 165;

		// Token: 0x0400665D RID: 26205
		public const short SwampThing = 166;

		// Token: 0x0400665E RID: 26206
		public const short UndeadViking = 167;

		// Token: 0x0400665F RID: 26207
		public const short CorruptPenguin = 168;

		// Token: 0x04006660 RID: 26208
		public const short IceElemental = 169;

		// Token: 0x04006661 RID: 26209
		public const short PigronCorruption = 170;

		// Token: 0x04006662 RID: 26210
		public const short PigronHallow = 171;

		// Token: 0x04006663 RID: 26211
		public const short RuneWizard = 172;

		// Token: 0x04006664 RID: 26212
		public const short Crimera = 173;

		// Token: 0x04006665 RID: 26213
		public const short Herpling = 174;

		// Token: 0x04006666 RID: 26214
		public const short AngryTrapper = 175;

		// Token: 0x04006667 RID: 26215
		public const short MossHornet = 176;

		// Token: 0x04006668 RID: 26216
		public const short Derpling = 177;

		// Token: 0x04006669 RID: 26217
		public const short Steampunker = 178;

		// Token: 0x0400666A RID: 26218
		public const short CrimsonAxe = 179;

		// Token: 0x0400666B RID: 26219
		public const short PigronCrimson = 180;

		// Token: 0x0400666C RID: 26220
		public const short FaceMonster = 181;

		// Token: 0x0400666D RID: 26221
		public const short FloatyGross = 182;

		// Token: 0x0400666E RID: 26222
		public const short Crimslime = 183;

		// Token: 0x0400666F RID: 26223
		public const short SpikedIceSlime = 184;

		// Token: 0x04006670 RID: 26224
		public const short SnowFlinx = 185;

		// Token: 0x04006671 RID: 26225
		public const short PincushionZombie = 186;

		// Token: 0x04006672 RID: 26226
		public const short SlimedZombie = 187;

		// Token: 0x04006673 RID: 26227
		public const short SwampZombie = 188;

		// Token: 0x04006674 RID: 26228
		public const short TwiggyZombie = 189;

		// Token: 0x04006675 RID: 26229
		public const short CataractEye = 190;

		// Token: 0x04006676 RID: 26230
		public const short SleepyEye = 191;

		// Token: 0x04006677 RID: 26231
		public const short DialatedEye = 192;

		// Token: 0x04006678 RID: 26232
		public const short GreenEye = 193;

		// Token: 0x04006679 RID: 26233
		public const short PurpleEye = 194;

		// Token: 0x0400667A RID: 26234
		public const short LostGirl = 195;

		// Token: 0x0400667B RID: 26235
		public const short Nymph = 196;

		// Token: 0x0400667C RID: 26236
		public const short ArmoredViking = 197;

		// Token: 0x0400667D RID: 26237
		public const short Lihzahrd = 198;

		// Token: 0x0400667E RID: 26238
		public const short LihzahrdCrawler = 199;

		// Token: 0x0400667F RID: 26239
		public const short FemaleZombie = 200;

		// Token: 0x04006680 RID: 26240
		public const short HeadacheSkeleton = 201;

		// Token: 0x04006681 RID: 26241
		public const short MisassembledSkeleton = 202;

		// Token: 0x04006682 RID: 26242
		public const short PantlessSkeleton = 203;

		// Token: 0x04006683 RID: 26243
		public const short SpikedJungleSlime = 204;

		// Token: 0x04006684 RID: 26244
		public const short Moth = 205;

		// Token: 0x04006685 RID: 26245
		public const short IcyMerman = 206;

		// Token: 0x04006686 RID: 26246
		public const short DyeTrader = 207;

		// Token: 0x04006687 RID: 26247
		public const short PartyGirl = 208;

		// Token: 0x04006688 RID: 26248
		public const short Cyborg = 209;

		// Token: 0x04006689 RID: 26249
		public const short Bee = 210;

		// Token: 0x0400668A RID: 26250
		public const short BeeSmall = 211;

		// Token: 0x0400668B RID: 26251
		public const short PirateDeckhand = 212;

		// Token: 0x0400668C RID: 26252
		public const short PirateCorsair = 213;

		// Token: 0x0400668D RID: 26253
		public const short PirateDeadeye = 214;

		// Token: 0x0400668E RID: 26254
		public const short PirateCrossbower = 215;

		// Token: 0x0400668F RID: 26255
		public const short PirateCaptain = 216;

		// Token: 0x04006690 RID: 26256
		public const short CochinealBeetle = 217;

		// Token: 0x04006691 RID: 26257
		public const short CyanBeetle = 218;

		// Token: 0x04006692 RID: 26258
		public const short LacBeetle = 219;

		// Token: 0x04006693 RID: 26259
		public const short SeaSnail = 220;

		// Token: 0x04006694 RID: 26260
		public const short Squid = 221;

		// Token: 0x04006695 RID: 26261
		public const short QueenBee = 222;

		// Token: 0x04006696 RID: 26262
		public const short ZombieRaincoat = 223;

		// Token: 0x04006697 RID: 26263
		public const short FlyingFish = 224;

		// Token: 0x04006698 RID: 26264
		public const short UmbrellaSlime = 225;

		// Token: 0x04006699 RID: 26265
		public const short FlyingSnake = 226;

		// Token: 0x0400669A RID: 26266
		public const short Painter = 227;

		// Token: 0x0400669B RID: 26267
		public const short WitchDoctor = 228;

		// Token: 0x0400669C RID: 26268
		public const short Pirate = 229;

		// Token: 0x0400669D RID: 26269
		public const short GoldfishWalker = 230;

		// Token: 0x0400669E RID: 26270
		public const short HornetFatty = 231;

		// Token: 0x0400669F RID: 26271
		public const short HornetHoney = 232;

		// Token: 0x040066A0 RID: 26272
		public const short HornetLeafy = 233;

		// Token: 0x040066A1 RID: 26273
		public const short HornetSpikey = 234;

		// Token: 0x040066A2 RID: 26274
		public const short HornetStingy = 235;

		// Token: 0x040066A3 RID: 26275
		public const short JungleCreeper = 236;

		// Token: 0x040066A4 RID: 26276
		public const short JungleCreeperWall = 237;

		// Token: 0x040066A5 RID: 26277
		public const short BlackRecluseWall = 238;

		// Token: 0x040066A6 RID: 26278
		public const short BloodCrawler = 239;

		// Token: 0x040066A7 RID: 26279
		public const short BloodCrawlerWall = 240;

		// Token: 0x040066A8 RID: 26280
		public const short BloodFeeder = 241;

		// Token: 0x040066A9 RID: 26281
		public const short BloodJelly = 242;

		// Token: 0x040066AA RID: 26282
		public const short IceGolem = 243;

		// Token: 0x040066AB RID: 26283
		public const short RainbowSlime = 244;

		// Token: 0x040066AC RID: 26284
		public const short Golem = 245;

		// Token: 0x040066AD RID: 26285
		public const short GolemHead = 246;

		// Token: 0x040066AE RID: 26286
		public const short GolemFistLeft = 247;

		// Token: 0x040066AF RID: 26287
		public const short GolemFistRight = 248;

		// Token: 0x040066B0 RID: 26288
		public const short GolemHeadFree = 249;

		// Token: 0x040066B1 RID: 26289
		public const short AngryNimbus = 250;

		// Token: 0x040066B2 RID: 26290
		public const short Eyezor = 251;

		// Token: 0x040066B3 RID: 26291
		public const short Parrot = 252;

		// Token: 0x040066B4 RID: 26292
		public const short Reaper = 253;

		// Token: 0x040066B5 RID: 26293
		public const short ZombieMushroom = 254;

		// Token: 0x040066B6 RID: 26294
		public const short ZombieMushroomHat = 255;

		// Token: 0x040066B7 RID: 26295
		public const short FungoFish = 256;

		// Token: 0x040066B8 RID: 26296
		public const short AnomuraFungus = 257;

		// Token: 0x040066B9 RID: 26297
		public const short MushiLadybug = 258;

		// Token: 0x040066BA RID: 26298
		public const short FungiBulb = 259;

		// Token: 0x040066BB RID: 26299
		public const short GiantFungiBulb = 260;

		// Token: 0x040066BC RID: 26300
		public const short FungiSpore = 261;

		// Token: 0x040066BD RID: 26301
		public const short Plantera = 262;

		// Token: 0x040066BE RID: 26302
		public const short PlanterasHook = 263;

		// Token: 0x040066BF RID: 26303
		public const short PlanterasTentacle = 264;

		// Token: 0x040066C0 RID: 26304
		public const short Spore = 265;

		// Token: 0x040066C1 RID: 26305
		public const short BrainofCthulhu = 266;

		// Token: 0x040066C2 RID: 26306
		public const short Creeper = 267;

		// Token: 0x040066C3 RID: 26307
		public const short IchorSticker = 268;

		// Token: 0x040066C4 RID: 26308
		public const short RustyArmoredBonesAxe = 269;

		// Token: 0x040066C5 RID: 26309
		public const short RustyArmoredBonesFlail = 270;

		// Token: 0x040066C6 RID: 26310
		public const short RustyArmoredBonesSword = 271;

		// Token: 0x040066C7 RID: 26311
		public const short RustyArmoredBonesSwordNoArmor = 272;

		// Token: 0x040066C8 RID: 26312
		public const short BlueArmoredBones = 273;

		// Token: 0x040066C9 RID: 26313
		public const short BlueArmoredBonesMace = 274;

		// Token: 0x040066CA RID: 26314
		public const short BlueArmoredBonesNoPants = 275;

		// Token: 0x040066CB RID: 26315
		public const short BlueArmoredBonesSword = 276;

		// Token: 0x040066CC RID: 26316
		public const short HellArmoredBones = 277;

		// Token: 0x040066CD RID: 26317
		public const short HellArmoredBonesSpikeShield = 278;

		// Token: 0x040066CE RID: 26318
		public const short HellArmoredBonesMace = 279;

		// Token: 0x040066CF RID: 26319
		public const short HellArmoredBonesSword = 280;

		// Token: 0x040066D0 RID: 26320
		public const short RaggedCaster = 281;

		// Token: 0x040066D1 RID: 26321
		public const short RaggedCasterOpenCoat = 282;

		// Token: 0x040066D2 RID: 26322
		public const short Necromancer = 283;

		// Token: 0x040066D3 RID: 26323
		public const short NecromancerArmored = 284;

		// Token: 0x040066D4 RID: 26324
		public const short DiabolistRed = 285;

		// Token: 0x040066D5 RID: 26325
		public const short DiabolistWhite = 286;

		// Token: 0x040066D6 RID: 26326
		public const short BoneLee = 287;

		// Token: 0x040066D7 RID: 26327
		public const short DungeonSpirit = 288;

		// Token: 0x040066D8 RID: 26328
		public const short GiantCursedSkull = 289;

		// Token: 0x040066D9 RID: 26329
		public const short Paladin = 290;

		// Token: 0x040066DA RID: 26330
		public const short SkeletonSniper = 291;

		// Token: 0x040066DB RID: 26331
		public const short TacticalSkeleton = 292;

		// Token: 0x040066DC RID: 26332
		public const short SkeletonCommando = 293;

		// Token: 0x040066DD RID: 26333
		public const short AngryBonesBig = 294;

		// Token: 0x040066DE RID: 26334
		public const short AngryBonesBigMuscle = 295;

		// Token: 0x040066DF RID: 26335
		public const short AngryBonesBigHelmet = 296;

		// Token: 0x040066E0 RID: 26336
		public const short BirdBlue = 297;

		// Token: 0x040066E1 RID: 26337
		public const short BirdRed = 298;

		// Token: 0x040066E2 RID: 26338
		public const short Squirrel = 299;

		// Token: 0x040066E3 RID: 26339
		public const short Mouse = 300;

		// Token: 0x040066E4 RID: 26340
		public const short Raven = 301;

		// Token: 0x040066E5 RID: 26341
		public const short SlimeMasked = 302;

		// Token: 0x040066E6 RID: 26342
		public const short BunnySlimed = 303;

		// Token: 0x040066E7 RID: 26343
		public const short HoppinJack = 304;

		// Token: 0x040066E8 RID: 26344
		public const short Scarecrow1 = 305;

		// Token: 0x040066E9 RID: 26345
		public const short Scarecrow2 = 306;

		// Token: 0x040066EA RID: 26346
		public const short Scarecrow3 = 307;

		// Token: 0x040066EB RID: 26347
		public const short Scarecrow4 = 308;

		// Token: 0x040066EC RID: 26348
		public const short Scarecrow5 = 309;

		// Token: 0x040066ED RID: 26349
		public const short Scarecrow6 = 310;

		// Token: 0x040066EE RID: 26350
		public const short Scarecrow7 = 311;

		// Token: 0x040066EF RID: 26351
		public const short Scarecrow8 = 312;

		// Token: 0x040066F0 RID: 26352
		public const short Scarecrow9 = 313;

		// Token: 0x040066F1 RID: 26353
		public const short Scarecrow10 = 314;

		// Token: 0x040066F2 RID: 26354
		public const short HeadlessHorseman = 315;

		// Token: 0x040066F3 RID: 26355
		public const short Ghost = 316;

		// Token: 0x040066F4 RID: 26356
		public const short DemonEyeOwl = 317;

		// Token: 0x040066F5 RID: 26357
		public const short DemonEyeSpaceship = 318;

		// Token: 0x040066F6 RID: 26358
		public const short ZombieDoctor = 319;

		// Token: 0x040066F7 RID: 26359
		public const short ZombieSuperman = 320;

		// Token: 0x040066F8 RID: 26360
		public const short ZombiePixie = 321;

		// Token: 0x040066F9 RID: 26361
		public const short SkeletonTopHat = 322;

		// Token: 0x040066FA RID: 26362
		public const short SkeletonAstonaut = 323;

		// Token: 0x040066FB RID: 26363
		public const short SkeletonAlien = 324;

		// Token: 0x040066FC RID: 26364
		public const short MourningWood = 325;

		// Token: 0x040066FD RID: 26365
		public const short Splinterling = 326;

		// Token: 0x040066FE RID: 26366
		public const short Pumpking = 327;

		// Token: 0x040066FF RID: 26367
		public const short PumpkingBlade = 328;

		// Token: 0x04006700 RID: 26368
		public const short Hellhound = 329;

		// Token: 0x04006701 RID: 26369
		public const short Poltergeist = 330;

		// Token: 0x04006702 RID: 26370
		public const short ZombieXmas = 331;

		// Token: 0x04006703 RID: 26371
		public const short ZombieSweater = 332;

		// Token: 0x04006704 RID: 26372
		public const short SlimeRibbonWhite = 333;

		// Token: 0x04006705 RID: 26373
		public const short SlimeRibbonYellow = 334;

		// Token: 0x04006706 RID: 26374
		public const short SlimeRibbonGreen = 335;

		// Token: 0x04006707 RID: 26375
		public const short SlimeRibbonRed = 336;

		// Token: 0x04006708 RID: 26376
		public const short BunnyXmas = 337;

		// Token: 0x04006709 RID: 26377
		public const short ZombieElf = 338;

		// Token: 0x0400670A RID: 26378
		public const short ZombieElfBeard = 339;

		// Token: 0x0400670B RID: 26379
		public const short ZombieElfGirl = 340;

		// Token: 0x0400670C RID: 26380
		public const short PresentMimic = 341;

		// Token: 0x0400670D RID: 26381
		public const short GingerbreadMan = 342;

		// Token: 0x0400670E RID: 26382
		public const short Yeti = 343;

		// Token: 0x0400670F RID: 26383
		public const short Everscream = 344;

		// Token: 0x04006710 RID: 26384
		public const short IceQueen = 345;

		// Token: 0x04006711 RID: 26385
		public const short SantaNK1 = 346;

		// Token: 0x04006712 RID: 26386
		public const short ElfCopter = 347;

		// Token: 0x04006713 RID: 26387
		public const short Nutcracker = 348;

		// Token: 0x04006714 RID: 26388
		public const short NutcrackerSpinning = 349;

		// Token: 0x04006715 RID: 26389
		public const short ElfArcher = 350;

		// Token: 0x04006716 RID: 26390
		public const short Krampus = 351;

		// Token: 0x04006717 RID: 26391
		public const short Flocko = 352;

		// Token: 0x04006718 RID: 26392
		public const short Stylist = 353;

		// Token: 0x04006719 RID: 26393
		public const short WebbedStylist = 354;

		// Token: 0x0400671A RID: 26394
		public const short Firefly = 355;

		// Token: 0x0400671B RID: 26395
		public const short Butterfly = 356;

		// Token: 0x0400671C RID: 26396
		public const short Worm = 357;

		// Token: 0x0400671D RID: 26397
		public const short LightningBug = 358;

		// Token: 0x0400671E RID: 26398
		public const short Snail = 359;

		// Token: 0x0400671F RID: 26399
		public const short GlowingSnail = 360;

		// Token: 0x04006720 RID: 26400
		public const short Frog = 361;

		// Token: 0x04006721 RID: 26401
		public const short Duck = 362;

		// Token: 0x04006722 RID: 26402
		public const short Duck2 = 363;

		// Token: 0x04006723 RID: 26403
		public const short DuckWhite = 364;

		// Token: 0x04006724 RID: 26404
		public const short DuckWhite2 = 365;

		// Token: 0x04006725 RID: 26405
		public const short ScorpionBlack = 366;

		// Token: 0x04006726 RID: 26406
		public const short Scorpion = 367;

		// Token: 0x04006727 RID: 26407
		public const short TravellingMerchant = 368;

		// Token: 0x04006728 RID: 26408
		public const short Angler = 369;

		// Token: 0x04006729 RID: 26409
		public const short DukeFishron = 370;

		// Token: 0x0400672A RID: 26410
		public const short DetonatingBubble = 371;

		// Token: 0x0400672B RID: 26411
		public const short Sharkron = 372;

		// Token: 0x0400672C RID: 26412
		public const short Sharkron2 = 373;

		// Token: 0x0400672D RID: 26413
		public const short TruffleWorm = 374;

		// Token: 0x0400672E RID: 26414
		public const short TruffleWormDigger = 375;

		// Token: 0x0400672F RID: 26415
		public const short SleepingAngler = 376;

		// Token: 0x04006730 RID: 26416
		public const short Grasshopper = 377;

		// Token: 0x04006731 RID: 26417
		public const short ChatteringTeethBomb = 378;

		// Token: 0x04006732 RID: 26418
		public const short CultistArcherBlue = 379;

		// Token: 0x04006733 RID: 26419
		public const short CultistArcherWhite = 380;

		// Token: 0x04006734 RID: 26420
		public const short BrainScrambler = 381;

		// Token: 0x04006735 RID: 26421
		public const short RayGunner = 382;

		// Token: 0x04006736 RID: 26422
		public const short MartianOfficer = 383;

		// Token: 0x04006737 RID: 26423
		public const short ForceBubble = 384;

		// Token: 0x04006738 RID: 26424
		public const short GrayGrunt = 385;

		// Token: 0x04006739 RID: 26425
		public const short MartianEngineer = 386;

		// Token: 0x0400673A RID: 26426
		public const short MartianTurret = 387;

		// Token: 0x0400673B RID: 26427
		public const short MartianDrone = 388;

		// Token: 0x0400673C RID: 26428
		public const short GigaZapper = 389;

		// Token: 0x0400673D RID: 26429
		public const short ScutlixRider = 390;

		// Token: 0x0400673E RID: 26430
		public const short Scutlix = 391;

		// Token: 0x0400673F RID: 26431
		public const short MartianSaucer = 392;

		// Token: 0x04006740 RID: 26432
		public const short MartianSaucerTurret = 393;

		// Token: 0x04006741 RID: 26433
		public const short MartianSaucerCannon = 394;

		// Token: 0x04006742 RID: 26434
		public const short MartianSaucerCore = 395;

		// Token: 0x04006743 RID: 26435
		public const short MoonLordHead = 396;

		// Token: 0x04006744 RID: 26436
		public const short MoonLordHand = 397;

		// Token: 0x04006745 RID: 26437
		public const short MoonLordCore = 398;

		// Token: 0x04006746 RID: 26438
		public const short MartianProbe = 399;

		// Token: 0x04006747 RID: 26439
		public const short MoonLordFreeEye = 400;

		// Token: 0x04006748 RID: 26440
		public const short MoonLordLeechBlob = 401;

		// Token: 0x04006749 RID: 26441
		public const short StardustWormHead = 402;

		// Token: 0x0400674A RID: 26442
		public const short StardustWormBody = 403;

		// Token: 0x0400674B RID: 26443
		public const short StardustWormTail = 404;

		// Token: 0x0400674C RID: 26444
		public const short StardustCellBig = 405;

		// Token: 0x0400674D RID: 26445
		public const short StardustCellSmall = 406;

		// Token: 0x0400674E RID: 26446
		public const short StardustJellyfishBig = 407;

		// Token: 0x0400674F RID: 26447
		public const short StardustJellyfishSmall = 408;

		// Token: 0x04006750 RID: 26448
		public const short StardustSpiderBig = 409;

		// Token: 0x04006751 RID: 26449
		public const short StardustSpiderSmall = 410;

		// Token: 0x04006752 RID: 26450
		public const short StardustSoldier = 411;

		// Token: 0x04006753 RID: 26451
		public const short SolarCrawltipedeHead = 412;

		// Token: 0x04006754 RID: 26452
		public const short SolarCrawltipedeBody = 413;

		// Token: 0x04006755 RID: 26453
		public const short SolarCrawltipedeTail = 414;

		// Token: 0x04006756 RID: 26454
		public const short SolarDrakomire = 415;

		// Token: 0x04006757 RID: 26455
		public const short SolarDrakomireRider = 416;

		// Token: 0x04006758 RID: 26456
		public const short SolarSroller = 417;

		// Token: 0x04006759 RID: 26457
		public const short SolarCorite = 418;

		// Token: 0x0400675A RID: 26458
		public const short SolarSolenian = 419;

		// Token: 0x0400675B RID: 26459
		public const short NebulaBrain = 420;

		// Token: 0x0400675C RID: 26460
		public const short NebulaHeadcrab = 421;

		// Token: 0x0400675D RID: 26461
		public const short NebulaBeast = 423;

		// Token: 0x0400675E RID: 26462
		public const short NebulaSoldier = 424;

		// Token: 0x0400675F RID: 26463
		public const short VortexRifleman = 425;

		// Token: 0x04006760 RID: 26464
		public const short VortexHornetQueen = 426;

		// Token: 0x04006761 RID: 26465
		public const short VortexHornet = 427;

		// Token: 0x04006762 RID: 26466
		public const short VortexLarva = 428;

		// Token: 0x04006763 RID: 26467
		public const short VortexSoldier = 429;

		// Token: 0x04006764 RID: 26468
		public const short ArmedZombie = 430;

		// Token: 0x04006765 RID: 26469
		public const short ArmedZombieEskimo = 431;

		// Token: 0x04006766 RID: 26470
		public const short ArmedZombiePincussion = 432;

		// Token: 0x04006767 RID: 26471
		public const short ArmedZombieSlimed = 433;

		// Token: 0x04006768 RID: 26472
		public const short ArmedZombieSwamp = 434;

		// Token: 0x04006769 RID: 26473
		public const short ArmedZombieTwiggy = 435;

		// Token: 0x0400676A RID: 26474
		public const short ArmedZombieCenx = 436;

		// Token: 0x0400676B RID: 26475
		public const short CultistTablet = 437;

		// Token: 0x0400676C RID: 26476
		public const short CultistDevote = 438;

		// Token: 0x0400676D RID: 26477
		public const short CultistBoss = 439;

		// Token: 0x0400676E RID: 26478
		public const short CultistBossClone = 440;

		// Token: 0x0400676F RID: 26479
		public const short GoldBird = 442;

		// Token: 0x04006770 RID: 26480
		public const short GoldBunny = 443;

		// Token: 0x04006771 RID: 26481
		public const short GoldButterfly = 444;

		// Token: 0x04006772 RID: 26482
		public const short GoldFrog = 445;

		// Token: 0x04006773 RID: 26483
		public const short GoldGrasshopper = 446;

		// Token: 0x04006774 RID: 26484
		public const short GoldMouse = 447;

		// Token: 0x04006775 RID: 26485
		public const short GoldWorm = 448;

		// Token: 0x04006776 RID: 26486
		public const short BoneThrowingSkeleton = 449;

		// Token: 0x04006777 RID: 26487
		public const short BoneThrowingSkeleton2 = 450;

		// Token: 0x04006778 RID: 26488
		public const short BoneThrowingSkeleton3 = 451;

		// Token: 0x04006779 RID: 26489
		public const short BoneThrowingSkeleton4 = 452;

		// Token: 0x0400677A RID: 26490
		public const short SkeletonMerchant = 453;

		// Token: 0x0400677B RID: 26491
		public const short CultistDragonHead = 454;

		// Token: 0x0400677C RID: 26492
		public const short CultistDragonBody1 = 455;

		// Token: 0x0400677D RID: 26493
		public const short CultistDragonBody2 = 456;

		// Token: 0x0400677E RID: 26494
		public const short CultistDragonBody3 = 457;

		// Token: 0x0400677F RID: 26495
		public const short CultistDragonBody4 = 458;

		// Token: 0x04006780 RID: 26496
		public const short CultistDragonTail = 459;

		// Token: 0x04006781 RID: 26497
		public const short Butcher = 460;

		// Token: 0x04006782 RID: 26498
		public const short CreatureFromTheDeep = 461;

		// Token: 0x04006783 RID: 26499
		public const short Fritz = 462;

		// Token: 0x04006784 RID: 26500
		public const short Nailhead = 463;

		// Token: 0x04006785 RID: 26501
		public const short CrimsonBunny = 464;

		// Token: 0x04006786 RID: 26502
		public const short CrimsonGoldfish = 465;

		// Token: 0x04006787 RID: 26503
		public const short Psycho = 466;

		// Token: 0x04006788 RID: 26504
		public const short DeadlySphere = 467;

		// Token: 0x04006789 RID: 26505
		public const short DrManFly = 468;

		// Token: 0x0400678A RID: 26506
		public const short ThePossessed = 469;

		// Token: 0x0400678B RID: 26507
		public const short CrimsonPenguin = 470;

		// Token: 0x0400678C RID: 26508
		public const short GoblinSummoner = 471;

		// Token: 0x0400678D RID: 26509
		public const short ShadowFlameApparition = 472;

		// Token: 0x0400678E RID: 26510
		public const short BigMimicCorruption = 473;

		// Token: 0x0400678F RID: 26511
		public const short BigMimicCrimson = 474;

		// Token: 0x04006790 RID: 26512
		public const short BigMimicHallow = 475;

		// Token: 0x04006791 RID: 26513
		public const short BigMimicJungle = 476;

		// Token: 0x04006792 RID: 26514
		public const short Mothron = 477;

		// Token: 0x04006793 RID: 26515
		public const short MothronEgg = 478;

		// Token: 0x04006794 RID: 26516
		public const short MothronSpawn = 479;

		// Token: 0x04006795 RID: 26517
		public const short Medusa = 480;

		// Token: 0x04006796 RID: 26518
		public const short GreekSkeleton = 481;

		// Token: 0x04006797 RID: 26519
		public const short GraniteGolem = 482;

		// Token: 0x04006798 RID: 26520
		public const short GraniteFlyer = 483;

		// Token: 0x04006799 RID: 26521
		public const short EnchantedNightcrawler = 484;

		// Token: 0x0400679A RID: 26522
		public const short Grubby = 485;

		// Token: 0x0400679B RID: 26523
		public const short Sluggy = 486;

		// Token: 0x0400679C RID: 26524
		public const short Buggy = 487;

		// Token: 0x0400679D RID: 26525
		public const short TargetDummy = 488;

		// Token: 0x0400679E RID: 26526
		public const short BloodZombie = 489;

		// Token: 0x0400679F RID: 26527
		public const short Drippler = 490;

		// Token: 0x040067A0 RID: 26528
		public const short PirateShip = 491;

		// Token: 0x040067A1 RID: 26529
		public const short PirateShipCannon = 492;

		// Token: 0x040067A2 RID: 26530
		public const short LunarTowerStardust = 493;

		// Token: 0x040067A3 RID: 26531
		public const short Crawdad = 494;

		// Token: 0x040067A4 RID: 26532
		public const short Crawdad2 = 495;

		// Token: 0x040067A5 RID: 26533
		public const short GiantShelly = 496;

		// Token: 0x040067A6 RID: 26534
		public const short GiantShelly2 = 497;

		// Token: 0x040067A7 RID: 26535
		public const short Salamander = 498;

		// Token: 0x040067A8 RID: 26536
		public const short Salamander2 = 499;

		// Token: 0x040067A9 RID: 26537
		public const short Salamander3 = 500;

		// Token: 0x040067AA RID: 26538
		public const short Salamander4 = 501;

		// Token: 0x040067AB RID: 26539
		public const short Salamander5 = 502;

		// Token: 0x040067AC RID: 26540
		public const short Salamander6 = 503;

		// Token: 0x040067AD RID: 26541
		public const short Salamander7 = 504;

		// Token: 0x040067AE RID: 26542
		public const short Salamander8 = 505;

		// Token: 0x040067AF RID: 26543
		public const short Salamander9 = 506;

		// Token: 0x040067B0 RID: 26544
		public const short LunarTowerNebula = 507;

		// Token: 0x040067B1 RID: 26545
		public const short LunarTowerVortex = 422;

		// Token: 0x040067B2 RID: 26546
		public const short TaxCollector = 441;

		// Token: 0x040067B3 RID: 26547
		public const short GiantWalkingAntlion = 508;

		// Token: 0x040067B4 RID: 26548
		public const short GiantFlyingAntlion = 509;

		// Token: 0x040067B5 RID: 26549
		public const short DuneSplicerHead = 510;

		// Token: 0x040067B6 RID: 26550
		public const short DuneSplicerBody = 511;

		// Token: 0x040067B7 RID: 26551
		public const short DuneSplicerTail = 512;

		// Token: 0x040067B8 RID: 26552
		public const short TombCrawlerHead = 513;

		// Token: 0x040067B9 RID: 26553
		public const short TombCrawlerBody = 514;

		// Token: 0x040067BA RID: 26554
		public const short TombCrawlerTail = 515;

		// Token: 0x040067BB RID: 26555
		public const short SolarFlare = 516;

		// Token: 0x040067BC RID: 26556
		public const short LunarTowerSolar = 517;

		// Token: 0x040067BD RID: 26557
		public const short SolarSpearman = 518;

		// Token: 0x040067BE RID: 26558
		public const short SolarGoop = 519;

		// Token: 0x040067BF RID: 26559
		public const short MartianWalker = 520;

		// Token: 0x040067C0 RID: 26560
		public const short AncientCultistSquidhead = 521;

		// Token: 0x040067C1 RID: 26561
		public const short AncientLight = 522;

		// Token: 0x040067C2 RID: 26562
		public const short AncientDoom = 523;

		// Token: 0x040067C3 RID: 26563
		public const short DesertGhoul = 524;

		// Token: 0x040067C4 RID: 26564
		public const short DesertGhoulCorruption = 525;

		// Token: 0x040067C5 RID: 26565
		public const short DesertGhoulCrimson = 526;

		// Token: 0x040067C6 RID: 26566
		public const short DesertGhoulHallow = 527;

		// Token: 0x040067C7 RID: 26567
		public const short DesertLamiaLight = 528;

		// Token: 0x040067C8 RID: 26568
		public const short DesertLamiaDark = 529;

		// Token: 0x040067C9 RID: 26569
		public const short DesertScorpionWalk = 530;

		// Token: 0x040067CA RID: 26570
		public const short DesertScorpionWall = 531;

		// Token: 0x040067CB RID: 26571
		public const short DesertBeast = 532;

		// Token: 0x040067CC RID: 26572
		public const short DesertDjinn = 533;

		// Token: 0x040067CD RID: 26573
		public const short DemonTaxCollector = 534;

		// Token: 0x040067CE RID: 26574
		public const short SlimeSpiked = 535;

		// Token: 0x040067CF RID: 26575
		public const short TheBride = 536;

		// Token: 0x040067D0 RID: 26576
		public const short SandSlime = 537;

		// Token: 0x040067D1 RID: 26577
		public const short SquirrelRed = 538;

		// Token: 0x040067D2 RID: 26578
		public const short SquirrelGold = 539;

		// Token: 0x040067D3 RID: 26579
		public const short PartyBunny = 540;

		// Token: 0x040067D4 RID: 26580
		public const short SandElemental = 541;

		// Token: 0x040067D5 RID: 26581
		public const short SandShark = 542;

		// Token: 0x040067D6 RID: 26582
		public const short SandsharkCorrupt = 543;

		// Token: 0x040067D7 RID: 26583
		public const short SandsharkCrimson = 544;

		// Token: 0x040067D8 RID: 26584
		public const short SandsharkHallow = 545;

		// Token: 0x040067D9 RID: 26585
		public const short Tumbleweed = 546;

		// Token: 0x040067DA RID: 26586
		public const short DD2AttackerTest = 547;

		// Token: 0x040067DB RID: 26587
		public const short DD2EterniaCrystal = 548;

		// Token: 0x040067DC RID: 26588
		public const short DD2LanePortal = 549;

		// Token: 0x040067DD RID: 26589
		public const short DD2Bartender = 550;

		// Token: 0x040067DE RID: 26590
		public const short DD2Betsy = 551;

		// Token: 0x040067DF RID: 26591
		public const short DD2GoblinT1 = 552;

		// Token: 0x040067E0 RID: 26592
		public const short DD2GoblinT2 = 553;

		// Token: 0x040067E1 RID: 26593
		public const short DD2GoblinT3 = 554;

		// Token: 0x040067E2 RID: 26594
		public const short DD2GoblinBomberT1 = 555;

		// Token: 0x040067E3 RID: 26595
		public const short DD2GoblinBomberT2 = 556;

		// Token: 0x040067E4 RID: 26596
		public const short DD2GoblinBomberT3 = 557;

		// Token: 0x040067E5 RID: 26597
		public const short DD2WyvernT1 = 558;

		// Token: 0x040067E6 RID: 26598
		public const short DD2WyvernT2 = 559;

		// Token: 0x040067E7 RID: 26599
		public const short DD2WyvernT3 = 560;

		// Token: 0x040067E8 RID: 26600
		public const short DD2JavelinstT1 = 561;

		// Token: 0x040067E9 RID: 26601
		public const short DD2JavelinstT2 = 562;

		// Token: 0x040067EA RID: 26602
		public const short DD2JavelinstT3 = 563;

		// Token: 0x040067EB RID: 26603
		public const short DD2DarkMageT1 = 564;

		// Token: 0x040067EC RID: 26604
		public const short DD2DarkMageT3 = 565;

		// Token: 0x040067ED RID: 26605
		public const short DD2SkeletonT1 = 566;

		// Token: 0x040067EE RID: 26606
		public const short DD2SkeletonT3 = 567;

		// Token: 0x040067EF RID: 26607
		public const short DD2WitherBeastT2 = 568;

		// Token: 0x040067F0 RID: 26608
		public const short DD2WitherBeastT3 = 569;

		// Token: 0x040067F1 RID: 26609
		public const short DD2DrakinT2 = 570;

		// Token: 0x040067F2 RID: 26610
		public const short DD2DrakinT3 = 571;

		// Token: 0x040067F3 RID: 26611
		public const short DD2KoboldWalkerT2 = 572;

		// Token: 0x040067F4 RID: 26612
		public const short DD2KoboldWalkerT3 = 573;

		// Token: 0x040067F5 RID: 26613
		public const short DD2KoboldFlyerT2 = 574;

		// Token: 0x040067F6 RID: 26614
		public const short DD2KoboldFlyerT3 = 575;

		// Token: 0x040067F7 RID: 26615
		public const short DD2OgreT2 = 576;

		// Token: 0x040067F8 RID: 26616
		public const short DD2OgreT3 = 577;

		// Token: 0x040067F9 RID: 26617
		public const short DD2LightningBugT3 = 578;

		// Token: 0x040067FA RID: 26618
		public const short BartenderUnconscious = 579;

		// Token: 0x040067FB RID: 26619
		public const short WalkingAntlion = 580;

		// Token: 0x040067FC RID: 26620
		public const short FlyingAntlion = 581;

		// Token: 0x040067FD RID: 26621
		public const short LarvaeAntlion = 582;

		// Token: 0x040067FE RID: 26622
		public const short FairyCritterPink = 583;

		// Token: 0x040067FF RID: 26623
		public const short FairyCritterGreen = 584;

		// Token: 0x04006800 RID: 26624
		public const short FairyCritterBlue = 585;

		// Token: 0x04006801 RID: 26625
		public const short ZombieMerman = 586;

		// Token: 0x04006802 RID: 26626
		public const short EyeballFlyingFish = 587;

		// Token: 0x04006803 RID: 26627
		public const short Golfer = 588;

		// Token: 0x04006804 RID: 26628
		public const short GolferRescue = 589;

		// Token: 0x04006805 RID: 26629
		public const short TorchZombie = 590;

		// Token: 0x04006806 RID: 26630
		public const short ArmedTorchZombie = 591;

		// Token: 0x04006807 RID: 26631
		public const short GoldGoldfish = 592;

		// Token: 0x04006808 RID: 26632
		public const short GoldGoldfishWalker = 593;

		// Token: 0x04006809 RID: 26633
		public const short WindyBalloon = 594;

		// Token: 0x0400680A RID: 26634
		public const short BlackDragonfly = 595;

		// Token: 0x0400680B RID: 26635
		public const short BlueDragonfly = 596;

		// Token: 0x0400680C RID: 26636
		public const short GreenDragonfly = 597;

		// Token: 0x0400680D RID: 26637
		public const short OrangeDragonfly = 598;

		// Token: 0x0400680E RID: 26638
		public const short RedDragonfly = 599;

		// Token: 0x0400680F RID: 26639
		public const short YellowDragonfly = 600;

		// Token: 0x04006810 RID: 26640
		public const short GoldDragonfly = 601;

		// Token: 0x04006811 RID: 26641
		public const short Seagull = 602;

		// Token: 0x04006812 RID: 26642
		public const short Seagull2 = 603;

		// Token: 0x04006813 RID: 26643
		public const short LadyBug = 604;

		// Token: 0x04006814 RID: 26644
		public const short GoldLadyBug = 605;

		// Token: 0x04006815 RID: 26645
		public const short Maggot = 606;

		// Token: 0x04006816 RID: 26646
		public const short Pupfish = 607;

		// Token: 0x04006817 RID: 26647
		public const short Grebe = 608;

		// Token: 0x04006818 RID: 26648
		public const short Grebe2 = 609;

		// Token: 0x04006819 RID: 26649
		public const short Rat = 610;

		// Token: 0x0400681A RID: 26650
		public const short Owl = 611;

		// Token: 0x0400681B RID: 26651
		public const short WaterStrider = 612;

		// Token: 0x0400681C RID: 26652
		public const short GoldWaterStrider = 613;

		// Token: 0x0400681D RID: 26653
		public const short ExplosiveBunny = 614;

		// Token: 0x0400681E RID: 26654
		public const short Dolphin = 615;

		// Token: 0x0400681F RID: 26655
		public const short Turtle = 616;

		// Token: 0x04006820 RID: 26656
		public const short TurtleJungle = 617;

		// Token: 0x04006821 RID: 26657
		public const short BloodNautilus = 618;

		// Token: 0x04006822 RID: 26658
		public const short BloodSquid = 619;

		// Token: 0x04006823 RID: 26659
		public const short GoblinShark = 620;

		// Token: 0x04006824 RID: 26660
		public const short BloodEelHead = 621;

		// Token: 0x04006825 RID: 26661
		public const short BloodEelBody = 622;

		// Token: 0x04006826 RID: 26662
		public const short BloodEelTail = 623;

		// Token: 0x04006827 RID: 26663
		public const short Gnome = 624;

		// Token: 0x04006828 RID: 26664
		public const short SeaTurtle = 625;

		// Token: 0x04006829 RID: 26665
		public const short Seahorse = 626;

		// Token: 0x0400682A RID: 26666
		public const short GoldSeahorse = 627;

		// Token: 0x0400682B RID: 26667
		public const short Dandelion = 628;

		// Token: 0x0400682C RID: 26668
		public const short IceMimic = 629;

		// Token: 0x0400682D RID: 26669
		public const short BloodMummy = 630;

		// Token: 0x0400682E RID: 26670
		public const short RockGolem = 631;

		// Token: 0x0400682F RID: 26671
		public const short MaggotZombie = 632;

		// Token: 0x04006830 RID: 26672
		public const short BestiaryGirl = 633;

		// Token: 0x04006831 RID: 26673
		public const short SporeBat = 634;

		// Token: 0x04006832 RID: 26674
		public const short SporeSkeleton = 635;

		// Token: 0x04006833 RID: 26675
		public const short HallowBoss = 636;

		// Token: 0x04006834 RID: 26676
		public const short TownCat = 637;

		// Token: 0x04006835 RID: 26677
		public const short TownDog = 638;

		// Token: 0x04006836 RID: 26678
		public const short GemSquirrelAmethyst = 639;

		// Token: 0x04006837 RID: 26679
		public const short GemSquirrelTopaz = 640;

		// Token: 0x04006838 RID: 26680
		public const short GemSquirrelSapphire = 641;

		// Token: 0x04006839 RID: 26681
		public const short GemSquirrelEmerald = 642;

		// Token: 0x0400683A RID: 26682
		public const short GemSquirrelRuby = 643;

		// Token: 0x0400683B RID: 26683
		public const short GemSquirrelDiamond = 644;

		// Token: 0x0400683C RID: 26684
		public const short GemSquirrelAmber = 645;

		// Token: 0x0400683D RID: 26685
		public const short GemBunnyAmethyst = 646;

		// Token: 0x0400683E RID: 26686
		public const short GemBunnyTopaz = 647;

		// Token: 0x0400683F RID: 26687
		public const short GemBunnySapphire = 648;

		// Token: 0x04006840 RID: 26688
		public const short GemBunnyEmerald = 649;

		// Token: 0x04006841 RID: 26689
		public const short GemBunnyRuby = 650;

		// Token: 0x04006842 RID: 26690
		public const short GemBunnyDiamond = 651;

		// Token: 0x04006843 RID: 26691
		public const short GemBunnyAmber = 652;

		// Token: 0x04006844 RID: 26692
		public const short HellButterfly = 653;

		// Token: 0x04006845 RID: 26693
		public const short Lavafly = 654;

		// Token: 0x04006846 RID: 26694
		public const short MagmaSnail = 655;

		// Token: 0x04006847 RID: 26695
		public const short TownBunny = 656;

		// Token: 0x04006848 RID: 26696
		public const short QueenSlimeBoss = 657;

		// Token: 0x04006849 RID: 26697
		public const short QueenSlimeMinionBlue = 658;

		// Token: 0x0400684A RID: 26698
		public const short QueenSlimeMinionPink = 659;

		// Token: 0x0400684B RID: 26699
		public const short QueenSlimeMinionPurple = 660;

		// Token: 0x0400684C RID: 26700
		public const short EmpressButterfly = 661;

		// Token: 0x0400684D RID: 26701
		public const short PirateGhost = 662;

		// Token: 0x0400684E RID: 26702
		public const short Princess = 663;

		// Token: 0x0400684F RID: 26703
		public const short TorchGod = 664;

		// Token: 0x04006850 RID: 26704
		public const short ChaosBallTim = 665;

		// Token: 0x04006851 RID: 26705
		public const short VileSpitEaterOfWorlds = 666;

		// Token: 0x04006852 RID: 26706
		public const short GoldenSlime = 667;

		// Token: 0x04006853 RID: 26707
		public const short Deerclops = 668;

		// Token: 0x04006854 RID: 26708
		public const short Stinkbug = 669;

		// Token: 0x04006855 RID: 26709
		public const short TownSlimeBlue = 670;

		// Token: 0x04006856 RID: 26710
		public const short ScarletMacaw = 671;

		// Token: 0x04006857 RID: 26711
		public const short BlueMacaw = 672;

		// Token: 0x04006858 RID: 26712
		public const short Toucan = 673;

		// Token: 0x04006859 RID: 26713
		public const short YellowCockatiel = 674;

		// Token: 0x0400685A RID: 26714
		public const short GrayCockatiel = 675;

		// Token: 0x0400685B RID: 26715
		public const short ShimmerSlime = 676;

		// Token: 0x0400685C RID: 26716
		public const short Shimmerfly = 677;

		// Token: 0x0400685D RID: 26717
		public const short TownSlimeGreen = 678;

		// Token: 0x0400685E RID: 26718
		public const short TownSlimeOld = 679;

		// Token: 0x0400685F RID: 26719
		public const short TownSlimePurple = 680;

		// Token: 0x04006860 RID: 26720
		public const short TownSlimeRainbow = 681;

		// Token: 0x04006861 RID: 26721
		public const short TownSlimeRed = 682;

		// Token: 0x04006862 RID: 26722
		public const short TownSlimeYellow = 683;

		// Token: 0x04006863 RID: 26723
		public const short TownSlimeCopper = 684;

		// Token: 0x04006864 RID: 26724
		public const short BoundTownSlimeOld = 685;

		// Token: 0x04006865 RID: 26725
		public const short BoundTownSlimePurple = 686;

		// Token: 0x04006866 RID: 26726
		public const short BoundTownSlimeYellow = 687;

		// Token: 0x04006867 RID: 26727
		public const short Count = 688;

		// Token: 0x04006868 RID: 26728
		public static readonly IdDictionary Search;

		// Token: 0x020005E0 RID: 1504
		public static class Sets
		{
			// Token: 0x06003567 RID: 13671 RVA: 0x0020E510 File Offset: 0x0020C710
			public static Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers> NPCBestiaryDrawOffsetCreation()
			{
				if (!true)
				{
				}
				Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers> redigitEntries = NPCID.Sets.GetRedigitEntries();
				Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers> leinforsEntries = NPCID.Sets.GetLeinforsEntries();
				Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers> groxEntries = NPCID.Sets.GetGroxEntries();
				throw new OutOfMemoryException();
			}

			// Token: 0x06003568 RID: 13672 RVA: 0x0020E560 File Offset: 0x0020C760
			private static Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers> GetRedigitEntries()
			{
			}

			// Token: 0x06003569 RID: 13673 RVA: 0x000021DB File Offset: 0x000003DB
			private static Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers> GetGroxEntries()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x0600356A RID: 13674 RVA: 0x0020E5F8 File Offset: 0x0020C7F8
			private static Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers> GetLeinforsEntries()
			{
			}

			// Token: 0x0600356B RID: 13675 RVA: 0x0020F0E8 File Offset: 0x0020D2E8
			// Note: this type is marked as 'beforefieldinit'.
			static Sets()
			{
				Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers> dictionary = NPCID.Sets.NPCBestiaryDrawOffsetCreation();
			}

			// Token: 0x04006869 RID: 26729
			public static SetFactory Factory;

			// Token: 0x0400686A RID: 26730
			public static Dictionary<int, int> SpecialSpawningRules;

			// Token: 0x0400686B RID: 26731
			public static Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers> NPCBestiaryDrawOffset;

			// Token: 0x0400686C RID: 26732
			public static Dictionary<int, NPCDebuffImmunityData> DebuffImmunitySets;

			// Token: 0x0400686D RID: 26733
			public static List<int> NormalGoldCritterBestiaryPriority;

			// Token: 0x0400686E RID: 26734
			public static List<int> BossBestiaryPriority;

			// Token: 0x0400686F RID: 26735
			public static List<int> TownNPCBestiaryPriority;

			// Token: 0x04006870 RID: 26736
			public static bool[] DontDoHardmodeScaling;

			// Token: 0x04006871 RID: 26737
			public static bool[] ReflectStarShotsInForTheWorthy;

			// Token: 0x04006872 RID: 26738
			public static bool[] IsTownPet;

			// Token: 0x04006873 RID: 26739
			public static bool[] IsTownSlime;

			// Token: 0x04006874 RID: 26740
			public static bool[] CanConvertIntoCopperSlimeTownNPC;

			// Token: 0x04006875 RID: 26741
			public static List<int> GoldCrittersCollection;

			// Token: 0x04006876 RID: 26742
			public static bool[] ZappingJellyfish;

			// Token: 0x04006877 RID: 26743
			public static bool[] CantTakeLunchMoney;

			// Token: 0x04006878 RID: 26744
			public static Dictionary<int, int> RespawnEnemyID;

			// Token: 0x04006879 RID: 26745
			public static int[] TrailingMode;

			// Token: 0x0400687A RID: 26746
			public static bool[] IsDragonfly;

			// Token: 0x0400687B RID: 26747
			public static bool[] BelongsToInvasionOldOnesArmy;

			// Token: 0x0400687C RID: 26748
			public static bool[] TeleportationImmune;

			// Token: 0x0400687D RID: 26749
			public static bool[] UsesNewTargetting;

			// Token: 0x0400687E RID: 26750
			public static bool[] TakesDamageFromHostilesWithoutBeingFriendly;

			// Token: 0x0400687F RID: 26751
			public static bool[] AllNPCs;

			// Token: 0x04006880 RID: 26752
			public static bool[] HurtingBees;

			// Token: 0x04006881 RID: 26753
			public static bool[] FighterUsesDD2PortalAppearEffect;

			// Token: 0x04006882 RID: 26754
			public static float[] StatueSpawnedDropRarity;

			// Token: 0x04006883 RID: 26755
			public static bool[] NoEarlymodeLootWhenSpawnedFromStatue;

			// Token: 0x04006884 RID: 26756
			public static bool[] NeedsExpertScaling;

			// Token: 0x04006885 RID: 26757
			public static bool[] ProjectileNPC;

			// Token: 0x04006886 RID: 26758
			public static bool[] SavesAndLoads;

			// Token: 0x04006887 RID: 26759
			public static int[] TrailCacheLength;

			// Token: 0x04006888 RID: 26760
			public static bool[] UsesMultiplayerProximitySyncing;

			// Token: 0x04006889 RID: 26761
			public static bool[] NoMultiplayerSmoothingByType;

			// Token: 0x0400688A RID: 26762
			public static bool[] NoMultiplayerSmoothingByAI;

			// Token: 0x0400688B RID: 26763
			public static bool[] MPAllowedEnemies;

			// Token: 0x0400688C RID: 26764
			public static bool[] TownCritter;

			// Token: 0x0400688D RID: 26765
			public static bool[] CountsAsCritter;

			// Token: 0x0400688E RID: 26766
			public static bool[] HasNoPartyText;

			// Token: 0x0400688F RID: 26767
			public static int[] HatOffsetY;

			// Token: 0x04006890 RID: 26768
			public static int[] FaceEmote;

			// Token: 0x04006891 RID: 26769
			public static int[] ExtraFramesCount;

			// Token: 0x04006892 RID: 26770
			public static int[] AttackFrameCount;

			// Token: 0x04006893 RID: 26771
			public static int[] DangerDetectRange;

			// Token: 0x04006894 RID: 26772
			public static bool[] ShimmerImmunity;

			// Token: 0x04006895 RID: 26773
			public static int[] ShimmerTransformToItem;

			// Token: 0x04006896 RID: 26774
			public static bool[] ShimmerTownTransform;

			// Token: 0x04006897 RID: 26775
			public static int[] ShimmerTransformToNPC;

			// Token: 0x04006898 RID: 26776
			public static int[] AttackTime;

			// Token: 0x04006899 RID: 26777
			public static int[] AttackAverageChance;

			// Token: 0x0400689A RID: 26778
			public static int[] AttackType;

			// Token: 0x0400689B RID: 26779
			public static int[] PrettySafe;

			// Token: 0x0400689C RID: 26780
			public static Color[] MagicAuraColor;

			// Token: 0x0400689D RID: 26781
			public static bool[] DemonEyes;

			// Token: 0x0400689E RID: 26782
			public static bool[] Zombies;

			// Token: 0x0400689F RID: 26783
			public static bool[] Skeletons;

			// Token: 0x040068A0 RID: 26784
			public static int[] BossHeadTextures;

			// Token: 0x040068A1 RID: 26785
			public static bool[] PositiveNPCTypesExcludedFromDeathTally;

			// Token: 0x040068A2 RID: 26786
			public static bool[] ShouldBeCountedAsBoss;

			// Token: 0x040068A3 RID: 26787
			public static bool[] DangerThatPreventsOtherDangers;

			// Token: 0x040068A4 RID: 26788
			public static bool[] MustAlwaysDraw;

			// Token: 0x040068A5 RID: 26789
			public static bool[] ExpandedCullDraw;

			// Token: 0x040068A6 RID: 26790
			public static int[] ExtraTextureCount;

			// Token: 0x040068A7 RID: 26791
			public static int[] NPCFramingGroup;

			// Token: 0x040068A8 RID: 26792
			public static bool[] CanHitPastShimmer;

			// Token: 0x040068A9 RID: 26793
			public static int[][] TownNPCsFramingGroups;

			// Token: 0x020005E1 RID: 1505
			public struct NPCBestiaryDrawModifiers
			{
				// Token: 0x0600356C RID: 13676 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public NPCBestiaryDrawModifiers(int seriouslyWhyCantStructsHaveParameterlessConstructors)
				{
				}

				// Token: 0x040068AA RID: 26794
				public Vector2 Position;

				// Token: 0x040068AB RID: 26795
				public float? PortraitPositionXOverride;

				// Token: 0x040068AC RID: 26796
				public float? PortraitPositionYOverride;

				// Token: 0x040068AD RID: 26797
				public float Rotation;

				// Token: 0x040068AE RID: 26798
				public float Scale;

				// Token: 0x040068AF RID: 26799
				public float? PortraitScale;

				// Token: 0x040068B0 RID: 26800
				public bool Hide;

				// Token: 0x040068B1 RID: 26801
				public bool IsWet;

				// Token: 0x040068B2 RID: 26802
				public int? Frame;

				// Token: 0x040068B3 RID: 26803
				public int? Direction;

				// Token: 0x040068B4 RID: 26804
				public int? SpriteDirection;

				// Token: 0x040068B5 RID: 26805
				public float Velocity;

				// Token: 0x040068B6 RID: 26806
				public string CustomTexturePath;
			}

			// Token: 0x020005E2 RID: 1506
			private static class LocalBuffID
			{
				// Token: 0x040068B7 RID: 26807
				public const int Confused = 31;

				// Token: 0x040068B8 RID: 26808
				public const int Poisoned = 20;

				// Token: 0x040068B9 RID: 26809
				public const int OnFire = 24;

				// Token: 0x040068BA RID: 26810
				public const int OnFire3 = 323;

				// Token: 0x040068BB RID: 26811
				public const int ShadowFlame = 153;

				// Token: 0x040068BC RID: 26812
				public const int Daybreak = 189;

				// Token: 0x040068BD RID: 26813
				public const int Frostburn = 44;

				// Token: 0x040068BE RID: 26814
				public const int Frostburn2 = 324;

				// Token: 0x040068BF RID: 26815
				public const int CursedInferno = 39;

				// Token: 0x040068C0 RID: 26816
				public const int BetsysCurse = 203;

				// Token: 0x040068C1 RID: 26817
				public const int Ichor = 69;

				// Token: 0x040068C2 RID: 26818
				public const int Venom = 70;

				// Token: 0x040068C3 RID: 26819
				public const int Oiled = 204;

				// Token: 0x040068C4 RID: 26820
				public const int BoneJavelin = 169;

				// Token: 0x040068C5 RID: 26821
				public const int TentacleSpike = 337;

				// Token: 0x040068C6 RID: 26822
				public const int BloodButcherer = 344;
			}
		}
	}
}
