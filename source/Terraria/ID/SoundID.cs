using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Terraria.Audio;

namespace Terraria.ID
{
	// Token: 0x020005EF RID: 1519
	public class SoundID
	{
		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x0600358B RID: 13707 RVA: 0x002111E4 File Offset: 0x0020F3E4
		public static int TrackableLegacySoundCount
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600358B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.ID.SoundID::get_TrackableLegacySoundCount()

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
		}

		// Token: 0x0600358C RID: 13708 RVA: 0x002111F4 File Offset: 0x0020F3F4
		public static string GetTrackableLegacySoundPath(int id)
		{
			/*
An exception occurred when decompiling this method (0600358C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Terraria.ID.SoundID::GetTrackableLegacySoundPath(System.Int32)

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

		// Token: 0x0600358D RID: 13709 RVA: 0x00211204 File Offset: 0x0020F404
		private static LegacySoundStyle CreateTrackable(string name, SoundID.SoundStyleDefaults defaults)
		{
			if (!true)
			{
			}
			LegacySoundStyle legacySoundStyle;
			return legacySoundStyle;
		}

		// Token: 0x0600358E RID: 13710 RVA: 0x00211218 File Offset: 0x0020F418
		private static LegacySoundStyle CreateTrackable(string name, int variations, SoundID.SoundStyleDefaults defaults)
		{
			if (!true)
			{
			}
			LegacySoundStyle legacySoundStyle;
			return legacySoundStyle;
		}

		// Token: 0x0600358F RID: 13711 RVA: 0x0021122C File Offset: 0x0020F42C
		private static LegacySoundStyle CreateTrackable(string name, SoundType type = SoundType.Sound)
		{
			if ("Invalid URI: A Dos path must be rooted, for example, 'c:\\\\'." == null)
			{
			}
			LegacySoundStyle legacySoundStyle;
			return legacySoundStyle;
		}

		// Token: 0x06003590 RID: 13712 RVA: 0x00211244 File Offset: 0x0020F444
		private static LegacySoundStyle CreateTrackable(string name, int variations, SoundType type = SoundType.Sound)
		{
			/*
An exception occurred when decompiling this method (06003590)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Audio.LegacySoundStyle Terraria.ID.SoundID::CreateTrackable(System.String,System.Int32,Terraria.Audio.SoundType)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0008:
	stloc:string(var_2_14, call:string(string::Concat, ldloc:string(var_1), ldstr:string("_"), ldloc:string(var_1)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06003591 RID: 13713 RVA: 0x00211268 File Offset: 0x0020F468
		public static void FillAccessMap()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003592 RID: 13714 RVA: 0x00211278 File Offset: 0x0020F478
		public SoundID()
		{
		}

		// Token: 0x06003593 RID: 13715 RVA: 0x0021128C File Offset: 0x0020F48C
		// Note: this type is marked as 'beforefieldinit'.
		static SoundID()
		{
			LegacySoundStyle legacySoundStyle = SoundID.CreateTrackable("blizzard_inside_building_loop", SoundType.Ambient);
			LegacySoundStyle legacySoundStyle2 = SoundID.CreateTrackable("blizzard_strong_loop", SoundType.Ambient).WithVolume(0.06f);
			LegacySoundStyle legacySoundStyle3 = SoundID.CreateTrackable("liquids_honey_water", 3, SoundType.Ambient);
			LegacySoundStyle legacySoundStyle4 = SoundID.CreateTrackable("liquids_honey_lava", 3, SoundType.Ambient);
			LegacySoundStyle legacySoundStyle5 = SoundID.CreateTrackable("liquids_water_lava", 3, SoundType.Ambient);
			LegacySoundStyle legacySoundStyle7;
			LegacySoundStyle legacySoundStyle6 = legacySoundStyle7.WithVolume(0.06f);
			LegacySoundStyle legacySoundStyle9;
			LegacySoundStyle legacySoundStyle8 = legacySoundStyle9.WithVolume(0.06f).WithPitchVariance(0.06f);
			LegacySoundStyle legacySoundStyle11;
			LegacySoundStyle legacySoundStyle10 = legacySoundStyle11.WithVolume(0.06f);
			LegacySoundStyle legacySoundStyle13;
			LegacySoundStyle legacySoundStyle12 = legacySoundStyle13.WithVolume(0.06f);
			LegacySoundStyle legacySoundStyle15;
			LegacySoundStyle legacySoundStyle14 = legacySoundStyle15.WithVolume(0.06f);
			LegacySoundStyle legacySoundStyle17;
			LegacySoundStyle legacySoundStyle16 = legacySoundStyle17.WithVolume(0.06f);
			LegacySoundStyle legacySoundStyle19;
			LegacySoundStyle legacySoundStyle18 = legacySoundStyle19.WithVolume(0.06f);
			LegacySoundStyle legacySoundStyle21;
			LegacySoundStyle legacySoundStyle20 = legacySoundStyle21.WithVolume(0.06f);
			LegacySoundStyle legacySoundStyle23;
			LegacySoundStyle legacySoundStyle22 = legacySoundStyle23.WithVolume(0.06f);
			LegacySoundStyle legacySoundStyle25;
			LegacySoundStyle legacySoundStyle24 = legacySoundStyle25.WithVolume(0.06f);
			LegacySoundStyle legacySoundStyle27;
			LegacySoundStyle legacySoundStyle26 = legacySoundStyle27.WithVolume(0.06f);
			LegacySoundStyle legacySoundStyle29;
			LegacySoundStyle legacySoundStyle28 = legacySoundStyle29.WithVolume(0.06f);
			LegacySoundStyle legacySoundStyle31;
			LegacySoundStyle legacySoundStyle30 = legacySoundStyle31.WithVolume(0.06f);
		}

		// Token: 0x04006DB7 RID: 28087
		private static readonly SoundID.SoundStyleDefaults ItemDefaults;

		// Token: 0x04006DB8 RID: 28088
		public const int Dig = 0;

		// Token: 0x04006DB9 RID: 28089
		public const int PlayerHit = 1;

		// Token: 0x04006DBA RID: 28090
		public const int Item = 2;

		// Token: 0x04006DBB RID: 28091
		public const int NPCHit = 3;

		// Token: 0x04006DBC RID: 28092
		public const int NPCKilled = 4;

		// Token: 0x04006DBD RID: 28093
		public const int PlayerKilled = 5;

		// Token: 0x04006DBE RID: 28094
		public const int Grass = 6;

		// Token: 0x04006DBF RID: 28095
		public const int Grab = 7;

		// Token: 0x04006DC0 RID: 28096
		public const int DoorOpen = 8;

		// Token: 0x04006DC1 RID: 28097
		public const int DoorClosed = 9;

		// Token: 0x04006DC2 RID: 28098
		public const int MenuOpen = 10;

		// Token: 0x04006DC3 RID: 28099
		public const int MenuClose = 11;

		// Token: 0x04006DC4 RID: 28100
		public const int MenuTick = 12;

		// Token: 0x04006DC5 RID: 28101
		public const int Shatter = 13;

		// Token: 0x04006DC6 RID: 28102
		public const int ZombieMoan = 14;

		// Token: 0x04006DC7 RID: 28103
		public const int Roar = 15;

		// Token: 0x04006DC8 RID: 28104
		public const int DoubleJump = 16;

		// Token: 0x04006DC9 RID: 28105
		public const int Run = 17;

		// Token: 0x04006DCA RID: 28106
		public const int Coins = 18;

		// Token: 0x04006DCB RID: 28107
		public const int Splash = 19;

		// Token: 0x04006DCC RID: 28108
		public const int FemaleHit = 20;

		// Token: 0x04006DCD RID: 28109
		public const int Tink = 21;

		// Token: 0x04006DCE RID: 28110
		public const int Unlock = 22;

		// Token: 0x04006DCF RID: 28111
		public const int Drown = 23;

		// Token: 0x04006DD0 RID: 28112
		public const int Chat = 24;

		// Token: 0x04006DD1 RID: 28113
		public const int MaxMana = 25;

		// Token: 0x04006DD2 RID: 28114
		public const int Mummy = 26;

		// Token: 0x04006DD3 RID: 28115
		public const int Pixie = 27;

		// Token: 0x04006DD4 RID: 28116
		public const int Mech = 28;

		// Token: 0x04006DD5 RID: 28117
		public const int Zombie = 29;

		// Token: 0x04006DD6 RID: 28118
		public const int Duck = 30;

		// Token: 0x04006DD7 RID: 28119
		public const int Frog = 31;

		// Token: 0x04006DD8 RID: 28120
		public const int Bird = 32;

		// Token: 0x04006DD9 RID: 28121
		public const int Critter = 33;

		// Token: 0x04006DDA RID: 28122
		public const int Waterfall = 34;

		// Token: 0x04006DDB RID: 28123
		public const int Lavafall = 35;

		// Token: 0x04006DDC RID: 28124
		public const int ForceRoar = 36;

		// Token: 0x04006DDD RID: 28125
		public const int Meowmere = 37;

		// Token: 0x04006DDE RID: 28126
		public const int CoinPickup = 38;

		// Token: 0x04006DDF RID: 28127
		public const int Drip = 39;

		// Token: 0x04006DE0 RID: 28128
		public const int Camera = 40;

		// Token: 0x04006DE1 RID: 28129
		public const int MoonLord = 41;

		// Token: 0x04006DE2 RID: 28130
		public const int Trackable = 42;

		// Token: 0x04006DE3 RID: 28131
		public const int Thunder = 43;

		// Token: 0x04006DE4 RID: 28132
		public const int Seagull = 44;

		// Token: 0x04006DE5 RID: 28133
		public const int Dolphin = 45;

		// Token: 0x04006DE6 RID: 28134
		public const int Owl = 46;

		// Token: 0x04006DE7 RID: 28135
		public const int GuitarC = 47;

		// Token: 0x04006DE8 RID: 28136
		public const int GuitarD = 48;

		// Token: 0x04006DE9 RID: 28137
		public const int GuitarEm = 49;

		// Token: 0x04006DEA RID: 28138
		public const int GuitarG = 50;

		// Token: 0x04006DEB RID: 28139
		public const int GuitarBm = 51;

		// Token: 0x04006DEC RID: 28140
		public const int GuitarAm = 52;

		// Token: 0x04006DED RID: 28141
		public const int DrumHiHat = 53;

		// Token: 0x04006DEE RID: 28142
		public const int DrumTomHigh = 54;

		// Token: 0x04006DEF RID: 28143
		public const int DrumTomLow = 55;

		// Token: 0x04006DF0 RID: 28144
		public const int DrumTomMid = 56;

		// Token: 0x04006DF1 RID: 28145
		public const int DrumClosedHiHat = 57;

		// Token: 0x04006DF2 RID: 28146
		public const int DrumCymbal1 = 58;

		// Token: 0x04006DF3 RID: 28147
		public const int DrumCymbal2 = 59;

		// Token: 0x04006DF4 RID: 28148
		public const int DrumKick = 60;

		// Token: 0x04006DF5 RID: 28149
		public const int DrumTamaSnare = 61;

		// Token: 0x04006DF6 RID: 28150
		public const int DrumFloorTom = 62;

		// Token: 0x04006DF7 RID: 28151
		public const int Research = 63;

		// Token: 0x04006DF8 RID: 28152
		public const int ResearchComplete = 64;

		// Token: 0x04006DF9 RID: 28153
		public const int QueenSlime = 65;

		// Token: 0x04006DFA RID: 28154
		public const int Clown = 66;

		// Token: 0x04006DFB RID: 28155
		public const int Cockatiel = 67;

		// Token: 0x04006DFC RID: 28156
		public const int Macaw = 68;

		// Token: 0x04006DFD RID: 28157
		public const int Toucan = 69;

		// Token: 0x04006DFE RID: 28158
		public static readonly LegacySoundStyle NPCHit1;

		// Token: 0x04006DFF RID: 28159
		public static readonly LegacySoundStyle NPCHit2;

		// Token: 0x04006E00 RID: 28160
		public static readonly LegacySoundStyle NPCHit3;

		// Token: 0x04006E01 RID: 28161
		public static readonly LegacySoundStyle NPCHit4;

		// Token: 0x04006E02 RID: 28162
		public static readonly LegacySoundStyle NPCHit5;

		// Token: 0x04006E03 RID: 28163
		public static readonly LegacySoundStyle NPCHit6;

		// Token: 0x04006E04 RID: 28164
		public static readonly LegacySoundStyle NPCHit7;

		// Token: 0x04006E05 RID: 28165
		public static readonly LegacySoundStyle NPCHit8;

		// Token: 0x04006E06 RID: 28166
		public static readonly LegacySoundStyle NPCHit9;

		// Token: 0x04006E07 RID: 28167
		public static readonly LegacySoundStyle NPCHit10;

		// Token: 0x04006E08 RID: 28168
		public static readonly LegacySoundStyle NPCHit11;

		// Token: 0x04006E09 RID: 28169
		public static readonly LegacySoundStyle NPCHit12;

		// Token: 0x04006E0A RID: 28170
		public static readonly LegacySoundStyle NPCHit13;

		// Token: 0x04006E0B RID: 28171
		public static readonly LegacySoundStyle NPCHit14;

		// Token: 0x04006E0C RID: 28172
		public static readonly LegacySoundStyle NPCHit15;

		// Token: 0x04006E0D RID: 28173
		public static readonly LegacySoundStyle NPCHit16;

		// Token: 0x04006E0E RID: 28174
		public static readonly LegacySoundStyle NPCHit17;

		// Token: 0x04006E0F RID: 28175
		public static readonly LegacySoundStyle NPCHit18;

		// Token: 0x04006E10 RID: 28176
		public static readonly LegacySoundStyle NPCHit19;

		// Token: 0x04006E11 RID: 28177
		public static readonly LegacySoundStyle NPCHit20;

		// Token: 0x04006E12 RID: 28178
		public static readonly LegacySoundStyle NPCHit21;

		// Token: 0x04006E13 RID: 28179
		public static readonly LegacySoundStyle NPCHit22;

		// Token: 0x04006E14 RID: 28180
		public static readonly LegacySoundStyle NPCHit23;

		// Token: 0x04006E15 RID: 28181
		public static readonly LegacySoundStyle NPCHit24;

		// Token: 0x04006E16 RID: 28182
		public static readonly LegacySoundStyle NPCHit25;

		// Token: 0x04006E17 RID: 28183
		public static readonly LegacySoundStyle NPCHit26;

		// Token: 0x04006E18 RID: 28184
		public static readonly LegacySoundStyle NPCHit27;

		// Token: 0x04006E19 RID: 28185
		public static readonly LegacySoundStyle NPCHit28;

		// Token: 0x04006E1A RID: 28186
		public static readonly LegacySoundStyle NPCHit29;

		// Token: 0x04006E1B RID: 28187
		public static readonly LegacySoundStyle NPCHit30;

		// Token: 0x04006E1C RID: 28188
		public static readonly LegacySoundStyle NPCHit31;

		// Token: 0x04006E1D RID: 28189
		public static readonly LegacySoundStyle NPCHit32;

		// Token: 0x04006E1E RID: 28190
		public static readonly LegacySoundStyle NPCHit33;

		// Token: 0x04006E1F RID: 28191
		public static readonly LegacySoundStyle NPCHit34;

		// Token: 0x04006E20 RID: 28192
		public static readonly LegacySoundStyle NPCHit35;

		// Token: 0x04006E21 RID: 28193
		public static readonly LegacySoundStyle NPCHit36;

		// Token: 0x04006E22 RID: 28194
		public static readonly LegacySoundStyle NPCHit37;

		// Token: 0x04006E23 RID: 28195
		public static readonly LegacySoundStyle NPCHit38;

		// Token: 0x04006E24 RID: 28196
		public static readonly LegacySoundStyle NPCHit39;

		// Token: 0x04006E25 RID: 28197
		public static readonly LegacySoundStyle NPCHit40;

		// Token: 0x04006E26 RID: 28198
		public static readonly LegacySoundStyle NPCHit41;

		// Token: 0x04006E27 RID: 28199
		public static readonly LegacySoundStyle NPCHit42;

		// Token: 0x04006E28 RID: 28200
		public static readonly LegacySoundStyle NPCHit43;

		// Token: 0x04006E29 RID: 28201
		public static readonly LegacySoundStyle NPCHit44;

		// Token: 0x04006E2A RID: 28202
		public static readonly LegacySoundStyle NPCHit45;

		// Token: 0x04006E2B RID: 28203
		public static readonly LegacySoundStyle NPCHit46;

		// Token: 0x04006E2C RID: 28204
		public static readonly LegacySoundStyle NPCHit47;

		// Token: 0x04006E2D RID: 28205
		public static readonly LegacySoundStyle NPCHit48;

		// Token: 0x04006E2E RID: 28206
		public static readonly LegacySoundStyle NPCHit49;

		// Token: 0x04006E2F RID: 28207
		public static readonly LegacySoundStyle NPCHit50;

		// Token: 0x04006E30 RID: 28208
		public static readonly LegacySoundStyle NPCHit51;

		// Token: 0x04006E31 RID: 28209
		public static readonly LegacySoundStyle NPCHit52;

		// Token: 0x04006E32 RID: 28210
		public static readonly LegacySoundStyle NPCHit53;

		// Token: 0x04006E33 RID: 28211
		public static readonly LegacySoundStyle NPCHit54;

		// Token: 0x04006E34 RID: 28212
		public static readonly LegacySoundStyle NPCHit55;

		// Token: 0x04006E35 RID: 28213
		public static readonly LegacySoundStyle NPCHit56;

		// Token: 0x04006E36 RID: 28214
		public static readonly LegacySoundStyle NPCHit57;

		// Token: 0x04006E37 RID: 28215
		public static readonly LegacySoundStyle NPCDeath1;

		// Token: 0x04006E38 RID: 28216
		public static readonly LegacySoundStyle NPCDeath2;

		// Token: 0x04006E39 RID: 28217
		public static readonly LegacySoundStyle NPCDeath3;

		// Token: 0x04006E3A RID: 28218
		public static readonly LegacySoundStyle NPCDeath4;

		// Token: 0x04006E3B RID: 28219
		public static readonly LegacySoundStyle NPCDeath5;

		// Token: 0x04006E3C RID: 28220
		public static readonly LegacySoundStyle NPCDeath6;

		// Token: 0x04006E3D RID: 28221
		public static readonly LegacySoundStyle NPCDeath7;

		// Token: 0x04006E3E RID: 28222
		public static readonly LegacySoundStyle NPCDeath8;

		// Token: 0x04006E3F RID: 28223
		public static readonly LegacySoundStyle NPCDeath9;

		// Token: 0x04006E40 RID: 28224
		public static readonly LegacySoundStyle NPCDeath10;

		// Token: 0x04006E41 RID: 28225
		public static readonly LegacySoundStyle NPCDeath11;

		// Token: 0x04006E42 RID: 28226
		public static readonly LegacySoundStyle NPCDeath12;

		// Token: 0x04006E43 RID: 28227
		public static readonly LegacySoundStyle NPCDeath13;

		// Token: 0x04006E44 RID: 28228
		public static readonly LegacySoundStyle NPCDeath14;

		// Token: 0x04006E45 RID: 28229
		public static readonly LegacySoundStyle NPCDeath15;

		// Token: 0x04006E46 RID: 28230
		public static readonly LegacySoundStyle NPCDeath16;

		// Token: 0x04006E47 RID: 28231
		public static readonly LegacySoundStyle NPCDeath17;

		// Token: 0x04006E48 RID: 28232
		public static readonly LegacySoundStyle NPCDeath18;

		// Token: 0x04006E49 RID: 28233
		public static readonly LegacySoundStyle NPCDeath19;

		// Token: 0x04006E4A RID: 28234
		public static readonly LegacySoundStyle NPCDeath20;

		// Token: 0x04006E4B RID: 28235
		public static readonly LegacySoundStyle NPCDeath21;

		// Token: 0x04006E4C RID: 28236
		public static readonly LegacySoundStyle NPCDeath22;

		// Token: 0x04006E4D RID: 28237
		public static readonly LegacySoundStyle NPCDeath23;

		// Token: 0x04006E4E RID: 28238
		public static readonly LegacySoundStyle NPCDeath24;

		// Token: 0x04006E4F RID: 28239
		public static readonly LegacySoundStyle NPCDeath25;

		// Token: 0x04006E50 RID: 28240
		public static readonly LegacySoundStyle NPCDeath26;

		// Token: 0x04006E51 RID: 28241
		public static readonly LegacySoundStyle NPCDeath27;

		// Token: 0x04006E52 RID: 28242
		public static readonly LegacySoundStyle NPCDeath28;

		// Token: 0x04006E53 RID: 28243
		public static readonly LegacySoundStyle NPCDeath29;

		// Token: 0x04006E54 RID: 28244
		public static readonly LegacySoundStyle NPCDeath30;

		// Token: 0x04006E55 RID: 28245
		public static readonly LegacySoundStyle NPCDeath31;

		// Token: 0x04006E56 RID: 28246
		public static readonly LegacySoundStyle NPCDeath32;

		// Token: 0x04006E57 RID: 28247
		public static readonly LegacySoundStyle NPCDeath33;

		// Token: 0x04006E58 RID: 28248
		public static readonly LegacySoundStyle NPCDeath34;

		// Token: 0x04006E59 RID: 28249
		public static readonly LegacySoundStyle NPCDeath35;

		// Token: 0x04006E5A RID: 28250
		public static readonly LegacySoundStyle NPCDeath36;

		// Token: 0x04006E5B RID: 28251
		public static readonly LegacySoundStyle NPCDeath37;

		// Token: 0x04006E5C RID: 28252
		public static readonly LegacySoundStyle NPCDeath38;

		// Token: 0x04006E5D RID: 28253
		public static readonly LegacySoundStyle NPCDeath39;

		// Token: 0x04006E5E RID: 28254
		public static readonly LegacySoundStyle NPCDeath40;

		// Token: 0x04006E5F RID: 28255
		public static readonly LegacySoundStyle NPCDeath41;

		// Token: 0x04006E60 RID: 28256
		public static readonly LegacySoundStyle NPCDeath42;

		// Token: 0x04006E61 RID: 28257
		public static readonly LegacySoundStyle NPCDeath43;

		// Token: 0x04006E62 RID: 28258
		public static readonly LegacySoundStyle NPCDeath44;

		// Token: 0x04006E63 RID: 28259
		public static readonly LegacySoundStyle NPCDeath45;

		// Token: 0x04006E64 RID: 28260
		public static readonly LegacySoundStyle NPCDeath46;

		// Token: 0x04006E65 RID: 28261
		public static readonly LegacySoundStyle NPCDeath47;

		// Token: 0x04006E66 RID: 28262
		public static readonly LegacySoundStyle NPCDeath48;

		// Token: 0x04006E67 RID: 28263
		public static readonly LegacySoundStyle NPCDeath49;

		// Token: 0x04006E68 RID: 28264
		public static readonly LegacySoundStyle NPCDeath50;

		// Token: 0x04006E69 RID: 28265
		public static readonly LegacySoundStyle NPCDeath51;

		// Token: 0x04006E6A RID: 28266
		public static readonly LegacySoundStyle NPCDeath52;

		// Token: 0x04006E6B RID: 28267
		public static readonly LegacySoundStyle NPCDeath53;

		// Token: 0x04006E6C RID: 28268
		public static readonly LegacySoundStyle NPCDeath54;

		// Token: 0x04006E6D RID: 28269
		public static readonly LegacySoundStyle NPCDeath55;

		// Token: 0x04006E6E RID: 28270
		public static readonly LegacySoundStyle NPCDeath56;

		// Token: 0x04006E6F RID: 28271
		public static readonly LegacySoundStyle NPCDeath57;

		// Token: 0x04006E70 RID: 28272
		public static readonly LegacySoundStyle NPCDeath58;

		// Token: 0x04006E71 RID: 28273
		public static readonly LegacySoundStyle NPCDeath59;

		// Token: 0x04006E72 RID: 28274
		public static readonly LegacySoundStyle NPCDeath60;

		// Token: 0x04006E73 RID: 28275
		public static readonly LegacySoundStyle NPCDeath61;

		// Token: 0x04006E74 RID: 28276
		public static readonly LegacySoundStyle NPCDeath62;

		// Token: 0x04006E75 RID: 28277
		public static readonly LegacySoundStyle NPCDeath63;

		// Token: 0x04006E76 RID: 28278
		public static readonly LegacySoundStyle NPCDeath64;

		// Token: 0x04006E77 RID: 28279
		public static readonly LegacySoundStyle NPCDeath65;

		// Token: 0x04006E78 RID: 28280
		public static readonly LegacySoundStyle NPCDeath66;

		// Token: 0x04006E79 RID: 28281
		public static short NPCDeathCount;

		// Token: 0x04006E7A RID: 28282
		public static readonly LegacySoundStyle Item1;

		// Token: 0x04006E7B RID: 28283
		public static readonly LegacySoundStyle Item2;

		// Token: 0x04006E7C RID: 28284
		public static readonly LegacySoundStyle Item3;

		// Token: 0x04006E7D RID: 28285
		public static readonly LegacySoundStyle Item4;

		// Token: 0x04006E7E RID: 28286
		public static readonly LegacySoundStyle Item5;

		// Token: 0x04006E7F RID: 28287
		public static readonly LegacySoundStyle Item6;

		// Token: 0x04006E80 RID: 28288
		public static readonly LegacySoundStyle Item7;

		// Token: 0x04006E81 RID: 28289
		public static readonly LegacySoundStyle Item8;

		// Token: 0x04006E82 RID: 28290
		public static readonly LegacySoundStyle Item9;

		// Token: 0x04006E83 RID: 28291
		public static readonly LegacySoundStyle Item10;

		// Token: 0x04006E84 RID: 28292
		public static readonly LegacySoundStyle Item11;

		// Token: 0x04006E85 RID: 28293
		public static readonly LegacySoundStyle Item12;

		// Token: 0x04006E86 RID: 28294
		public static readonly LegacySoundStyle Item13;

		// Token: 0x04006E87 RID: 28295
		public static readonly LegacySoundStyle Item14;

		// Token: 0x04006E88 RID: 28296
		public static readonly LegacySoundStyle Item15;

		// Token: 0x04006E89 RID: 28297
		public static readonly LegacySoundStyle Item16;

		// Token: 0x04006E8A RID: 28298
		public static readonly LegacySoundStyle Item17;

		// Token: 0x04006E8B RID: 28299
		public static readonly LegacySoundStyle Item18;

		// Token: 0x04006E8C RID: 28300
		public static readonly LegacySoundStyle Item19;

		// Token: 0x04006E8D RID: 28301
		public static readonly LegacySoundStyle Item20;

		// Token: 0x04006E8E RID: 28302
		public static readonly LegacySoundStyle Item21;

		// Token: 0x04006E8F RID: 28303
		public static readonly LegacySoundStyle Item22;

		// Token: 0x04006E90 RID: 28304
		public static readonly LegacySoundStyle Item23;

		// Token: 0x04006E91 RID: 28305
		public static readonly LegacySoundStyle Item24;

		// Token: 0x04006E92 RID: 28306
		public static readonly LegacySoundStyle Item25;

		// Token: 0x04006E93 RID: 28307
		public static readonly LegacySoundStyle Item26;

		// Token: 0x04006E94 RID: 28308
		public static readonly LegacySoundStyle Item27;

		// Token: 0x04006E95 RID: 28309
		public static readonly LegacySoundStyle Item28;

		// Token: 0x04006E96 RID: 28310
		public static readonly LegacySoundStyle Item29;

		// Token: 0x04006E97 RID: 28311
		public static readonly LegacySoundStyle Item30;

		// Token: 0x04006E98 RID: 28312
		public static readonly LegacySoundStyle Item31;

		// Token: 0x04006E99 RID: 28313
		public static readonly LegacySoundStyle Item32;

		// Token: 0x04006E9A RID: 28314
		public static readonly LegacySoundStyle Item33;

		// Token: 0x04006E9B RID: 28315
		public static readonly LegacySoundStyle Item34;

		// Token: 0x04006E9C RID: 28316
		public static readonly LegacySoundStyle Item35;

		// Token: 0x04006E9D RID: 28317
		public static readonly LegacySoundStyle Item36;

		// Token: 0x04006E9E RID: 28318
		public static readonly LegacySoundStyle Item37;

		// Token: 0x04006E9F RID: 28319
		public static readonly LegacySoundStyle Item38;

		// Token: 0x04006EA0 RID: 28320
		public static readonly LegacySoundStyle Item39;

		// Token: 0x04006EA1 RID: 28321
		public static readonly LegacySoundStyle Item40;

		// Token: 0x04006EA2 RID: 28322
		public static readonly LegacySoundStyle Item41;

		// Token: 0x04006EA3 RID: 28323
		public static readonly LegacySoundStyle Item42;

		// Token: 0x04006EA4 RID: 28324
		public static readonly LegacySoundStyle Item43;

		// Token: 0x04006EA5 RID: 28325
		public static readonly LegacySoundStyle Item44;

		// Token: 0x04006EA6 RID: 28326
		public static readonly LegacySoundStyle Item45;

		// Token: 0x04006EA7 RID: 28327
		public static readonly LegacySoundStyle Item46;

		// Token: 0x04006EA8 RID: 28328
		public static readonly LegacySoundStyle Item47;

		// Token: 0x04006EA9 RID: 28329
		public static readonly LegacySoundStyle Item48;

		// Token: 0x04006EAA RID: 28330
		public static readonly LegacySoundStyle Item49;

		// Token: 0x04006EAB RID: 28331
		public static readonly LegacySoundStyle Item50;

		// Token: 0x04006EAC RID: 28332
		public static readonly LegacySoundStyle Item51;

		// Token: 0x04006EAD RID: 28333
		public static readonly LegacySoundStyle Item52;

		// Token: 0x04006EAE RID: 28334
		public static readonly LegacySoundStyle Item53;

		// Token: 0x04006EAF RID: 28335
		public static readonly LegacySoundStyle Item54;

		// Token: 0x04006EB0 RID: 28336
		public static readonly LegacySoundStyle Item55;

		// Token: 0x04006EB1 RID: 28337
		public static readonly LegacySoundStyle Item56;

		// Token: 0x04006EB2 RID: 28338
		public static readonly LegacySoundStyle Item57;

		// Token: 0x04006EB3 RID: 28339
		public static readonly LegacySoundStyle Item58;

		// Token: 0x04006EB4 RID: 28340
		public static readonly LegacySoundStyle Item59;

		// Token: 0x04006EB5 RID: 28341
		public static readonly LegacySoundStyle Item60;

		// Token: 0x04006EB6 RID: 28342
		public static readonly LegacySoundStyle Item61;

		// Token: 0x04006EB7 RID: 28343
		public static readonly LegacySoundStyle Item62;

		// Token: 0x04006EB8 RID: 28344
		public static readonly LegacySoundStyle Item63;

		// Token: 0x04006EB9 RID: 28345
		public static readonly LegacySoundStyle Item64;

		// Token: 0x04006EBA RID: 28346
		public static readonly LegacySoundStyle Item65;

		// Token: 0x04006EBB RID: 28347
		public static readonly LegacySoundStyle Item66;

		// Token: 0x04006EBC RID: 28348
		public static readonly LegacySoundStyle Item67;

		// Token: 0x04006EBD RID: 28349
		public static readonly LegacySoundStyle Item68;

		// Token: 0x04006EBE RID: 28350
		public static readonly LegacySoundStyle Item69;

		// Token: 0x04006EBF RID: 28351
		public static readonly LegacySoundStyle Item70;

		// Token: 0x04006EC0 RID: 28352
		public static readonly LegacySoundStyle Item71;

		// Token: 0x04006EC1 RID: 28353
		public static readonly LegacySoundStyle Item72;

		// Token: 0x04006EC2 RID: 28354
		public static readonly LegacySoundStyle Item73;

		// Token: 0x04006EC3 RID: 28355
		public static readonly LegacySoundStyle Item74;

		// Token: 0x04006EC4 RID: 28356
		public static readonly LegacySoundStyle Item75;

		// Token: 0x04006EC5 RID: 28357
		public static readonly LegacySoundStyle Item76;

		// Token: 0x04006EC6 RID: 28358
		public static readonly LegacySoundStyle Item77;

		// Token: 0x04006EC7 RID: 28359
		public static readonly LegacySoundStyle Item78;

		// Token: 0x04006EC8 RID: 28360
		public static readonly LegacySoundStyle Item79;

		// Token: 0x04006EC9 RID: 28361
		public static readonly LegacySoundStyle Item80;

		// Token: 0x04006ECA RID: 28362
		public static readonly LegacySoundStyle Item81;

		// Token: 0x04006ECB RID: 28363
		public static readonly LegacySoundStyle Item82;

		// Token: 0x04006ECC RID: 28364
		public static readonly LegacySoundStyle Item83;

		// Token: 0x04006ECD RID: 28365
		public static readonly LegacySoundStyle Item84;

		// Token: 0x04006ECE RID: 28366
		public static readonly LegacySoundStyle Item85;

		// Token: 0x04006ECF RID: 28367
		public static readonly LegacySoundStyle Item86;

		// Token: 0x04006ED0 RID: 28368
		public static readonly LegacySoundStyle Item87;

		// Token: 0x04006ED1 RID: 28369
		public static readonly LegacySoundStyle Item88;

		// Token: 0x04006ED2 RID: 28370
		public static readonly LegacySoundStyle Item89;

		// Token: 0x04006ED3 RID: 28371
		public static readonly LegacySoundStyle Item90;

		// Token: 0x04006ED4 RID: 28372
		public static readonly LegacySoundStyle Item91;

		// Token: 0x04006ED5 RID: 28373
		public static readonly LegacySoundStyle Item92;

		// Token: 0x04006ED6 RID: 28374
		public static readonly LegacySoundStyle Item93;

		// Token: 0x04006ED7 RID: 28375
		public static readonly LegacySoundStyle Item94;

		// Token: 0x04006ED8 RID: 28376
		public static readonly LegacySoundStyle Item95;

		// Token: 0x04006ED9 RID: 28377
		public static readonly LegacySoundStyle Item96;

		// Token: 0x04006EDA RID: 28378
		public static readonly LegacySoundStyle Item97;

		// Token: 0x04006EDB RID: 28379
		public static readonly LegacySoundStyle Item98;

		// Token: 0x04006EDC RID: 28380
		public static readonly LegacySoundStyle Item99;

		// Token: 0x04006EDD RID: 28381
		public static readonly LegacySoundStyle Item100;

		// Token: 0x04006EDE RID: 28382
		public static readonly LegacySoundStyle Item101;

		// Token: 0x04006EDF RID: 28383
		public static readonly LegacySoundStyle Item102;

		// Token: 0x04006EE0 RID: 28384
		public static readonly LegacySoundStyle Item103;

		// Token: 0x04006EE1 RID: 28385
		public static readonly LegacySoundStyle Item104;

		// Token: 0x04006EE2 RID: 28386
		public static readonly LegacySoundStyle Item105;

		// Token: 0x04006EE3 RID: 28387
		public static readonly LegacySoundStyle Item106;

		// Token: 0x04006EE4 RID: 28388
		public static readonly LegacySoundStyle Item107;

		// Token: 0x04006EE5 RID: 28389
		public static readonly LegacySoundStyle Item108;

		// Token: 0x04006EE6 RID: 28390
		public static readonly LegacySoundStyle Item109;

		// Token: 0x04006EE7 RID: 28391
		public static readonly LegacySoundStyle Item110;

		// Token: 0x04006EE8 RID: 28392
		public static readonly LegacySoundStyle Item111;

		// Token: 0x04006EE9 RID: 28393
		public static readonly LegacySoundStyle Item112;

		// Token: 0x04006EEA RID: 28394
		public static readonly LegacySoundStyle Item113;

		// Token: 0x04006EEB RID: 28395
		public static readonly LegacySoundStyle Item114;

		// Token: 0x04006EEC RID: 28396
		public static readonly LegacySoundStyle Item115;

		// Token: 0x04006EED RID: 28397
		public static readonly LegacySoundStyle Item116;

		// Token: 0x04006EEE RID: 28398
		public static readonly LegacySoundStyle Item117;

		// Token: 0x04006EEF RID: 28399
		public static readonly LegacySoundStyle Item118;

		// Token: 0x04006EF0 RID: 28400
		public static readonly LegacySoundStyle Item119;

		// Token: 0x04006EF1 RID: 28401
		public static readonly LegacySoundStyle Item120;

		// Token: 0x04006EF2 RID: 28402
		public static readonly LegacySoundStyle Item121;

		// Token: 0x04006EF3 RID: 28403
		public static readonly LegacySoundStyle Item122;

		// Token: 0x04006EF4 RID: 28404
		public static readonly LegacySoundStyle Item123;

		// Token: 0x04006EF5 RID: 28405
		public static readonly LegacySoundStyle Item124;

		// Token: 0x04006EF6 RID: 28406
		public static readonly LegacySoundStyle Item125;

		// Token: 0x04006EF7 RID: 28407
		public static readonly LegacySoundStyle Item126;

		// Token: 0x04006EF8 RID: 28408
		public static readonly LegacySoundStyle Item127;

		// Token: 0x04006EF9 RID: 28409
		public static readonly LegacySoundStyle Item128;

		// Token: 0x04006EFA RID: 28410
		public static readonly LegacySoundStyle Item129;

		// Token: 0x04006EFB RID: 28411
		public static readonly LegacySoundStyle Item130;

		// Token: 0x04006EFC RID: 28412
		public static readonly LegacySoundStyle Item131;

		// Token: 0x04006EFD RID: 28413
		public static readonly LegacySoundStyle Item132;

		// Token: 0x04006EFE RID: 28414
		public static readonly LegacySoundStyle Item133;

		// Token: 0x04006EFF RID: 28415
		public static readonly LegacySoundStyle Item134;

		// Token: 0x04006F00 RID: 28416
		public static readonly LegacySoundStyle Item135;

		// Token: 0x04006F01 RID: 28417
		public static readonly LegacySoundStyle Item136;

		// Token: 0x04006F02 RID: 28418
		public static readonly LegacySoundStyle Item137;

		// Token: 0x04006F03 RID: 28419
		public static readonly LegacySoundStyle Item138;

		// Token: 0x04006F04 RID: 28420
		public static readonly LegacySoundStyle Item139;

		// Token: 0x04006F05 RID: 28421
		public static readonly LegacySoundStyle Item140;

		// Token: 0x04006F06 RID: 28422
		public static readonly LegacySoundStyle Item141;

		// Token: 0x04006F07 RID: 28423
		public static readonly LegacySoundStyle Item142;

		// Token: 0x04006F08 RID: 28424
		public static readonly LegacySoundStyle Item143;

		// Token: 0x04006F09 RID: 28425
		public static readonly LegacySoundStyle Item144;

		// Token: 0x04006F0A RID: 28426
		public static readonly LegacySoundStyle Item145;

		// Token: 0x04006F0B RID: 28427
		public static readonly LegacySoundStyle Item146;

		// Token: 0x04006F0C RID: 28428
		public static readonly LegacySoundStyle Item147;

		// Token: 0x04006F0D RID: 28429
		public static readonly LegacySoundStyle Item148;

		// Token: 0x04006F0E RID: 28430
		public static readonly LegacySoundStyle Item149;

		// Token: 0x04006F0F RID: 28431
		public static readonly LegacySoundStyle Item150;

		// Token: 0x04006F10 RID: 28432
		public static readonly LegacySoundStyle Item151;

		// Token: 0x04006F11 RID: 28433
		public static readonly LegacySoundStyle Item152;

		// Token: 0x04006F12 RID: 28434
		public static readonly LegacySoundStyle Item153;

		// Token: 0x04006F13 RID: 28435
		public static readonly LegacySoundStyle Item154;

		// Token: 0x04006F14 RID: 28436
		public static readonly LegacySoundStyle Item155;

		// Token: 0x04006F15 RID: 28437
		public static readonly LegacySoundStyle Item156;

		// Token: 0x04006F16 RID: 28438
		public static readonly LegacySoundStyle Item157;

		// Token: 0x04006F17 RID: 28439
		public static readonly LegacySoundStyle Item158;

		// Token: 0x04006F18 RID: 28440
		public static readonly LegacySoundStyle Item159;

		// Token: 0x04006F19 RID: 28441
		public static readonly LegacySoundStyle Item160;

		// Token: 0x04006F1A RID: 28442
		public static readonly LegacySoundStyle Item161;

		// Token: 0x04006F1B RID: 28443
		public static readonly LegacySoundStyle Item162;

		// Token: 0x04006F1C RID: 28444
		public static readonly LegacySoundStyle Item163;

		// Token: 0x04006F1D RID: 28445
		public static readonly LegacySoundStyle Item164;

		// Token: 0x04006F1E RID: 28446
		public static readonly LegacySoundStyle Item165;

		// Token: 0x04006F1F RID: 28447
		public static readonly LegacySoundStyle Item166;

		// Token: 0x04006F20 RID: 28448
		public static readonly LegacySoundStyle Item167;

		// Token: 0x04006F21 RID: 28449
		public static readonly LegacySoundStyle Item168;

		// Token: 0x04006F22 RID: 28450
		public static readonly LegacySoundStyle Item169;

		// Token: 0x04006F23 RID: 28451
		public static readonly LegacySoundStyle Item170;

		// Token: 0x04006F24 RID: 28452
		public static readonly LegacySoundStyle Item171;

		// Token: 0x04006F25 RID: 28453
		public static readonly LegacySoundStyle Item172;

		// Token: 0x04006F26 RID: 28454
		public static readonly LegacySoundStyle Item173;

		// Token: 0x04006F27 RID: 28455
		public static readonly LegacySoundStyle Item174;

		// Token: 0x04006F28 RID: 28456
		public static readonly LegacySoundStyle Item175;

		// Token: 0x04006F29 RID: 28457
		public static readonly LegacySoundStyle Item176;

		// Token: 0x04006F2A RID: 28458
		public static readonly LegacySoundStyle Item177;

		// Token: 0x04006F2B RID: 28459
		public static readonly LegacySoundStyle Item178;

		// Token: 0x04006F2C RID: 28460
		public static short ItemSoundCount;

		// Token: 0x04006F2D RID: 28461
		public static readonly LegacySoundStyle DD2_GoblinBomb;

		// Token: 0x04006F2E RID: 28462
		public static readonly LegacySoundStyle AchievementComplete;

		// Token: 0x04006F2F RID: 28463
		public static readonly LegacySoundStyle BlizzardInsideBuildingLoop;

		// Token: 0x04006F30 RID: 28464
		public static readonly LegacySoundStyle BlizzardStrongLoop;

		// Token: 0x04006F31 RID: 28465
		public static readonly LegacySoundStyle LiquidsHoneyWater;

		// Token: 0x04006F32 RID: 28466
		public static readonly LegacySoundStyle LiquidsHoneyLava;

		// Token: 0x04006F33 RID: 28467
		public static readonly LegacySoundStyle LiquidsWaterLava;

		// Token: 0x04006F34 RID: 28468
		public static readonly LegacySoundStyle DD2_BallistaTowerShot;

		// Token: 0x04006F35 RID: 28469
		public static readonly LegacySoundStyle DD2_ExplosiveTrapExplode;

		// Token: 0x04006F36 RID: 28470
		public static readonly LegacySoundStyle DD2_FlameburstTowerShot;

		// Token: 0x04006F37 RID: 28471
		public static readonly LegacySoundStyle DD2_LightningAuraZap;

		// Token: 0x04006F38 RID: 28472
		public static readonly LegacySoundStyle DD2_DefenseTowerSpawn;

		// Token: 0x04006F39 RID: 28473
		public static readonly LegacySoundStyle DD2_BetsyDeath;

		// Token: 0x04006F3A RID: 28474
		public static readonly LegacySoundStyle DD2_BetsyFireballShot;

		// Token: 0x04006F3B RID: 28475
		public static readonly LegacySoundStyle DD2_BetsyFireballImpact;

		// Token: 0x04006F3C RID: 28476
		public static readonly LegacySoundStyle DD2_BetsyFlameBreath;

		// Token: 0x04006F3D RID: 28477
		public static readonly LegacySoundStyle DD2_BetsyFlyingCircleAttack;

		// Token: 0x04006F3E RID: 28478
		public static readonly LegacySoundStyle DD2_BetsyHurt;

		// Token: 0x04006F3F RID: 28479
		public static readonly LegacySoundStyle DD2_BetsyScream;

		// Token: 0x04006F40 RID: 28480
		public static readonly LegacySoundStyle DD2_BetsySummon;

		// Token: 0x04006F41 RID: 28481
		public static readonly LegacySoundStyle DD2_BetsyWindAttack;

		// Token: 0x04006F42 RID: 28482
		public static readonly LegacySoundStyle DD2_DarkMageAttack;

		// Token: 0x04006F43 RID: 28483
		public static readonly LegacySoundStyle DD2_DarkMageCastHeal;

		// Token: 0x04006F44 RID: 28484
		public static readonly LegacySoundStyle DD2_DarkMageDeath;

		// Token: 0x04006F45 RID: 28485
		public static readonly LegacySoundStyle DD2_DarkMageHealImpact;

		// Token: 0x04006F46 RID: 28486
		public static readonly LegacySoundStyle DD2_DarkMageHurt;

		// Token: 0x04006F47 RID: 28487
		public static readonly LegacySoundStyle DD2_DarkMageSummonSkeleton;

		// Token: 0x04006F48 RID: 28488
		public static readonly LegacySoundStyle DD2_DrakinBreathIn;

		// Token: 0x04006F49 RID: 28489
		public static readonly LegacySoundStyle DD2_DrakinDeath;

		// Token: 0x04006F4A RID: 28490
		public static readonly LegacySoundStyle DD2_DrakinHurt;

		// Token: 0x04006F4B RID: 28491
		public static readonly LegacySoundStyle DD2_DrakinShot;

		// Token: 0x04006F4C RID: 28492
		public static readonly LegacySoundStyle DD2_GoblinDeath;

		// Token: 0x04006F4D RID: 28493
		public static readonly LegacySoundStyle DD2_GoblinHurt;

		// Token: 0x04006F4E RID: 28494
		public static readonly LegacySoundStyle DD2_GoblinScream;

		// Token: 0x04006F4F RID: 28495
		public static readonly LegacySoundStyle DD2_GoblinBomberDeath;

		// Token: 0x04006F50 RID: 28496
		public static readonly LegacySoundStyle DD2_GoblinBomberHurt;

		// Token: 0x04006F51 RID: 28497
		public static readonly LegacySoundStyle DD2_GoblinBomberScream;

		// Token: 0x04006F52 RID: 28498
		public static readonly LegacySoundStyle DD2_GoblinBomberThrow;

		// Token: 0x04006F53 RID: 28499
		public static readonly LegacySoundStyle DD2_JavelinThrowersAttack;

		// Token: 0x04006F54 RID: 28500
		public static readonly LegacySoundStyle DD2_JavelinThrowersDeath;

		// Token: 0x04006F55 RID: 28501
		public static readonly LegacySoundStyle DD2_JavelinThrowersHurt;

		// Token: 0x04006F56 RID: 28502
		public static readonly LegacySoundStyle DD2_JavelinThrowersTaunt;

		// Token: 0x04006F57 RID: 28503
		public static readonly LegacySoundStyle DD2_KoboldDeath;

		// Token: 0x04006F58 RID: 28504
		public static readonly LegacySoundStyle DD2_KoboldExplosion;

		// Token: 0x04006F59 RID: 28505
		public static readonly LegacySoundStyle DD2_KoboldHurt;

		// Token: 0x04006F5A RID: 28506
		public static readonly LegacySoundStyle DD2_KoboldIgnite;

		// Token: 0x04006F5B RID: 28507
		public static readonly LegacySoundStyle DD2_KoboldIgniteLoop;

		// Token: 0x04006F5C RID: 28508
		public static readonly LegacySoundStyle DD2_KoboldScreamChargeLoop;

		// Token: 0x04006F5D RID: 28509
		public static readonly LegacySoundStyle DD2_KoboldFlyerChargeScream;

		// Token: 0x04006F5E RID: 28510
		public static readonly LegacySoundStyle DD2_KoboldFlyerDeath;

		// Token: 0x04006F5F RID: 28511
		public static readonly LegacySoundStyle DD2_KoboldFlyerHurt;

		// Token: 0x04006F60 RID: 28512
		public static readonly LegacySoundStyle DD2_LightningBugDeath;

		// Token: 0x04006F61 RID: 28513
		public static readonly LegacySoundStyle DD2_LightningBugHurt;

		// Token: 0x04006F62 RID: 28514
		public static readonly LegacySoundStyle DD2_LightningBugZap;

		// Token: 0x04006F63 RID: 28515
		public static readonly LegacySoundStyle DD2_OgreAttack;

		// Token: 0x04006F64 RID: 28516
		public static readonly LegacySoundStyle DD2_OgreDeath;

		// Token: 0x04006F65 RID: 28517
		public static readonly LegacySoundStyle DD2_OgreGroundPound;

		// Token: 0x04006F66 RID: 28518
		public static readonly LegacySoundStyle DD2_OgreHurt;

		// Token: 0x04006F67 RID: 28519
		public static readonly LegacySoundStyle DD2_OgreRoar;

		// Token: 0x04006F68 RID: 28520
		public static readonly LegacySoundStyle DD2_OgreSpit;

		// Token: 0x04006F69 RID: 28521
		public static readonly LegacySoundStyle DD2_SkeletonDeath;

		// Token: 0x04006F6A RID: 28522
		public static readonly LegacySoundStyle DD2_SkeletonHurt;

		// Token: 0x04006F6B RID: 28523
		public static readonly LegacySoundStyle DD2_SkeletonSummoned;

		// Token: 0x04006F6C RID: 28524
		public static readonly LegacySoundStyle DD2_WitherBeastAuraPulse;

		// Token: 0x04006F6D RID: 28525
		public static readonly LegacySoundStyle DD2_WitherBeastCrystalImpact;

		// Token: 0x04006F6E RID: 28526
		public static readonly LegacySoundStyle DD2_WitherBeastDeath;

		// Token: 0x04006F6F RID: 28527
		public static readonly LegacySoundStyle DD2_WitherBeastHurt;

		// Token: 0x04006F70 RID: 28528
		public static readonly LegacySoundStyle DD2_WyvernDeath;

		// Token: 0x04006F71 RID: 28529
		public static readonly LegacySoundStyle DD2_WyvernHurt;

		// Token: 0x04006F72 RID: 28530
		public static readonly LegacySoundStyle DD2_WyvernScream;

		// Token: 0x04006F73 RID: 28531
		public static readonly LegacySoundStyle DD2_WyvernDiveDown;

		// Token: 0x04006F74 RID: 28532
		public static readonly LegacySoundStyle DD2_EtherianPortalDryadTouch;

		// Token: 0x04006F75 RID: 28533
		public static readonly LegacySoundStyle DD2_EtherianPortalIdleLoop;

		// Token: 0x04006F76 RID: 28534
		public static readonly LegacySoundStyle DD2_EtherianPortalOpen;

		// Token: 0x04006F77 RID: 28535
		public static readonly LegacySoundStyle DD2_EtherianPortalSpawnEnemy;

		// Token: 0x04006F78 RID: 28536
		public static readonly LegacySoundStyle DD2_CrystalCartImpact;

		// Token: 0x04006F79 RID: 28537
		public static readonly LegacySoundStyle DD2_DefeatScene;

		// Token: 0x04006F7A RID: 28538
		public static readonly LegacySoundStyle DD2_WinScene;

		// Token: 0x04006F7B RID: 28539
		public static readonly LegacySoundStyle DD2_BetsysWrathShot;

		// Token: 0x04006F7C RID: 28540
		public static readonly LegacySoundStyle DD2_BetsysWrathImpact;

		// Token: 0x04006F7D RID: 28541
		public static readonly LegacySoundStyle DD2_BookStaffCast;

		// Token: 0x04006F7E RID: 28542
		public static readonly LegacySoundStyle DD2_BookStaffTwisterLoop;

		// Token: 0x04006F7F RID: 28543
		public static readonly LegacySoundStyle DD2_GhastlyGlaiveImpactGhost;

		// Token: 0x04006F80 RID: 28544
		public static readonly LegacySoundStyle DD2_GhastlyGlaivePierce;

		// Token: 0x04006F81 RID: 28545
		public static readonly LegacySoundStyle DD2_MonkStaffGroundImpact;

		// Token: 0x04006F82 RID: 28546
		public static readonly LegacySoundStyle DD2_MonkStaffGroundMiss;

		// Token: 0x04006F83 RID: 28547
		public static readonly LegacySoundStyle DD2_MonkStaffSwing;

		// Token: 0x04006F84 RID: 28548
		public static readonly LegacySoundStyle DD2_PhantomPhoenixShot;

		// Token: 0x04006F85 RID: 28549
		public static readonly LegacySoundStyle DD2_SonicBoomBladeSlash;

		// Token: 0x04006F86 RID: 28550
		public static readonly LegacySoundStyle DD2_SkyDragonsFuryCircle;

		// Token: 0x04006F87 RID: 28551
		public static readonly LegacySoundStyle DD2_SkyDragonsFuryShot;

		// Token: 0x04006F88 RID: 28552
		public static readonly LegacySoundStyle DD2_SkyDragonsFurySwing;

		// Token: 0x04006F89 RID: 28553
		public static readonly LegacySoundStyle LucyTheAxeTalk;

		// Token: 0x04006F8A RID: 28554
		public static readonly LegacySoundStyle DeerclopsHit;

		// Token: 0x04006F8B RID: 28555
		public static readonly LegacySoundStyle DeerclopsDeath;

		// Token: 0x04006F8C RID: 28556
		public static readonly LegacySoundStyle DeerclopsScream;

		// Token: 0x04006F8D RID: 28557
		public static readonly LegacySoundStyle DeerclopsIceAttack;

		// Token: 0x04006F8E RID: 28558
		public static readonly LegacySoundStyle DeerclopsRubbleAttack;

		// Token: 0x04006F8F RID: 28559
		public static readonly LegacySoundStyle DeerclopsStep;

		// Token: 0x04006F90 RID: 28560
		public static readonly LegacySoundStyle ChesterOpen;

		// Token: 0x04006F91 RID: 28561
		public static readonly LegacySoundStyle ChesterClose;

		// Token: 0x04006F92 RID: 28562
		public static readonly LegacySoundStyle AbigailSummon;

		// Token: 0x04006F93 RID: 28563
		public static readonly LegacySoundStyle AbigailCry;

		// Token: 0x04006F94 RID: 28564
		public static readonly LegacySoundStyle AbigailAttack;

		// Token: 0x04006F95 RID: 28565
		public static readonly LegacySoundStyle AbigailUpgrade;

		// Token: 0x04006F96 RID: 28566
		public static readonly LegacySoundStyle GlommerBounce;

		// Token: 0x04006F97 RID: 28567
		public static readonly LegacySoundStyle DSTMaleHurt;

		// Token: 0x04006F98 RID: 28568
		public static readonly LegacySoundStyle DSTFemaleHurt;

		// Token: 0x04006F99 RID: 28569
		public static readonly LegacySoundStyle JimsDrone;

		// Token: 0x04006F9A RID: 28570
		private static List<string> _trackableLegacySoundPathList;

		// Token: 0x04006F9B RID: 28571
		public static Dictionary<string, LegacySoundStyle> SoundByName;

		// Token: 0x04006F9C RID: 28572
		public static Dictionary<string, ushort> IndexByName;

		// Token: 0x04006F9D RID: 28573
		public static Dictionary<ushort, LegacySoundStyle> SoundByIndex;

		// Token: 0x020005F0 RID: 1520
		private struct SoundStyleDefaults
		{
			// Token: 0x06003594 RID: 13716 RVA: 0x002113A8 File Offset: 0x0020F5A8
			public SoundStyleDefaults(float volume, float pitchVariance, SoundType type = SoundType.Sound)
			{
				this.Type = type;
			}

			// Token: 0x04006F9E RID: 28574
			public readonly float PitchVariance;

			// Token: 0x04006F9F RID: 28575
			public readonly float Volume;

			// Token: 0x04006FA0 RID: 28576
			public readonly SoundType Type;
		}

		// Token: 0x020005F1 RID: 1521
		[CompilerGenerated]
		private sealed class <>c__DisplayClass495_0
		{
			// Token: 0x06003595 RID: 13717 RVA: 0x002113BC File Offset: 0x0020F5BC
			public <>c__DisplayClass495_0()
			{
			}

			// Token: 0x06003596 RID: 13718 RVA: 0x002113D0 File Offset: 0x0020F5D0
			internal void <FillAccessMap>b__2(FieldInfo field)
			{
				Dictionary<string, LegacySoundStyle> dictionary = this.ret;
				if (field != null)
				{
				}
				Dictionary<string, ushort> dictionary2 = this.ret2;
				ushort num = this.nextIndex;
				Dictionary<ushort, LegacySoundStyle> dictionary3 = this.ret3;
				ushort num2 = this.nextIndex;
				if (field != null)
				{
				}
				ushort num3 = this.nextIndex;
				this.nextIndex = num3;
			}

			// Token: 0x04006FA1 RID: 28577
			public Dictionary<string, LegacySoundStyle> ret;

			// Token: 0x04006FA2 RID: 28578
			public Dictionary<string, ushort> ret2;

			// Token: 0x04006FA3 RID: 28579
			public ushort nextIndex;

			// Token: 0x04006FA4 RID: 28580
			public Dictionary<ushort, LegacySoundStyle> ret3;
		}

		// Token: 0x020005F2 RID: 1522
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003597 RID: 13719 RVA: 0x00211420 File Offset: 0x0020F620
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06003598 RID: 13720 RVA: 0x00211430 File Offset: 0x0020F630
			public <>c()
			{
			}

			// Token: 0x06003599 RID: 13721 RVA: 0x00211444 File Offset: 0x0020F644
			internal bool <FillAccessMap>b__495_0(FieldInfo f)
			{
				bool flag;
				return flag;
			}

			// Token: 0x0600359A RID: 13722 RVA: 0x00211454 File Offset: 0x0020F654
			internal int <FillAccessMap>b__495_1(FieldInfo a, FieldInfo b)
			{
				int num;
				return num;
			}

			// Token: 0x04006FA5 RID: 28581
			public static readonly SoundID.<>c <>9;

			// Token: 0x04006FA6 RID: 28582
			public static Func<FieldInfo, bool> <>9__495_0;

			// Token: 0x04006FA7 RID: 28583
			public static Comparison<FieldInfo> <>9__495_1;
		}
	}
}
