using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Terraria.Localization;
using Unity.IL2CPP.CompilerServices;

namespace Terraria
{
	// Token: 0x020003F0 RID: 1008
	public class Liquid
	{
		// Token: 0x06001BA1 RID: 7073 RVA: 0x000A91DC File Offset: 0x000A73DC
		public static void NetSendLiquid(int x, int y)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			long num = 0L;
			if (true)
			{
			}
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001BA2 RID: 7074 RVA: 0x000A9218 File Offset: 0x000A7418
		public static void tilesIgnoreWater(bool ignoreSolids)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001BA3 RID: 7075 RVA: 0x000A9228 File Offset: 0x000A7428
		public static void worldGenTilesIgnoreWater(bool ignoreSolids)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001BA4 RID: 7076 RVA: 0x000A9238 File Offset: 0x000A7438
		public static void ReInit()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true || !true)
			{
			}
		}

		// Token: 0x06001BA5 RID: 7077 RVA: 0x000A9254 File Offset: 0x000A7454
		public static void QuickWater(int verbose = 0, int minY = -1, int maxY = -1)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			WorldGen.ShimmerRemoveWater();
			Liquid.tilesIgnoreWater(true);
			int num2 = 3;
			if (num2 == 0)
			{
			}
			if (num2 == 0)
			{
			}
			if (num2 == 0)
			{
			}
			int num3 = 4;
			if (42179336 == 0)
			{
			}
			if (42179336 != 0)
			{
				if (42179336 == 0)
				{
				}
				if (42179336 == 0)
				{
					if (42179336 == 0)
					{
					}
					if (42179336 == 0)
					{
					}
					if (49236 == 0)
					{
					}
					bool flag = WorldGen.oceanDepths(num3, minY);
					return;
				}
			}
		}

		// Token: 0x06001BA6 RID: 7078 RVA: 0x000A9314 File Offset: 0x000A7514
		private unsafe static void AttemptToMoveHoney(int X, int Y, bool tileAtXYHasHoney, uint* tileLookup, byte* tileTypeBHeader, byte* tileTypeLiquid, int worldWidth)
		{
		}

		// Token: 0x06001BA7 RID: 7079 RVA: 0x000A9338 File Offset: 0x000A7538
		private unsafe static void AttemptToMoveLava(int X, int Y, bool tileAtXYHasLava, uint* tileLookup, byte* tileTypeBHeader, byte* tileTypeLiquid, int worldWidth)
		{
		}

		// Token: 0x06001BA8 RID: 7080 RVA: 0x000A935C File Offset: 0x000A755C
		private unsafe static void AttemptToMoveShimmer(int X, int Y, bool tileAtXYHasShimmer, uint* tileLookup, byte* tileTypeBHeader, byte* tileTypeLiquid, int worldWidth)
		{
			while (96 == 0)
			{
			}
			if (96 != 0)
			{
			}
		}

		// Token: 0x06001BA9 RID: 7081 RVA: 0x000A9388 File Offset: 0x000A7588
		private static void UpdateProgressDisplay(int verbose, int minY, int maxY, int y)
		{
		}

		// Token: 0x06001BAA RID: 7082 RVA: 0x000A93A8 File Offset: 0x000A75A8
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		public unsafe void Update(int worldWidth, uint* tileLookup, ushort* tileTypeData, short* tileTypeSHeader, byte* tileTypeBHeader, byte* tileLiquidValues, ushort* tileSearchUID)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int num2 = this.x;
			if (num == 0)
			{
				return;
			}
			if (num == 0)
			{
			}
			int underworldLayer = Main.UnderworldLayer;
		}

		// Token: 0x06001BAB RID: 7083 RVA: 0x000A965C File Offset: 0x000A785C
		public static void StartPanic()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				return;
			}
			if (num == 0)
			{
			}
			Console.WriteLine(Language.GetTextValue("Misc.ForceWaterSettling"));
		}

		// Token: 0x06001BAC RID: 7084 RVA: 0x000A9684 File Offset: 0x000A7884
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		public static void UpdateLiquid()
		{
			int num = 1;
			if (num == 0)
			{
			}
			Liquid.tilesIgnoreWater(true);
			if (num == 0)
			{
			}
			bool netHost = Main.NetHost;
			if (num == 0)
			{
			}
		}

		// Token: 0x06001BAD RID: 7085 RVA: 0x000A977C File Offset: 0x000A797C
		public static void AddWater(int x, int y)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001BAE RID: 7086 RVA: 0x000A97D0 File Offset: 0x000A79D0
		private static bool UnderGroundDesertCheck(int x, int y)
		{
			/*
An exception occurred when decompiling this method (06001BAE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Liquid::UnderGroundDesertCheck(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000B:
	stloc:uint16(var_4_15, callgetter:uint16(Tile::get_wall, ldloc:Tile[exp:valuetype Terraria.Tile&](var_2)))
	stloc:uint16(var_6_1E, callgetter:uint16(Tile::get_wall, ldloc:Tile[exp:valuetype Terraria.Tile&](var_5)))
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

		// Token: 0x06001BAF RID: 7087 RVA: 0x000A9804 File Offset: 0x000A7A04
		private static bool UndergroundDesertCheck(int x, int y)
		{
			/*
An exception occurred when decompiling this method (06001BAF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Liquid::UndergroundDesertCheck(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0022:
	stloc:uint16(var_6_29, callgetter:uint16(Tile::get_wall, ldloc:Tile[exp:valuetype Terraria.Tile&](var_5)))
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

		// Token: 0x06001BB0 RID: 7088 RVA: 0x000A9844 File Offset: 0x000A7A44
		public unsafe static void LiquidCheck(int x, int y, int thisLiquidType, uint* tileLookup, byte* tileTypeBHeader, byte* tileTypeLiquid, int worldWidth)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001BB1 RID: 7089 RVA: 0x000A996C File Offset: 0x000A7B6C
		public static void GetLiquidMergeTypes(int thisLiquidType, [Out] int liquidMergeTileType, [Out] int liquidMergeType, bool waterNearby, bool lavaNearby, bool honeyNearby, bool shimmerNearby)
		{
			int num = 56;
			liquidMergeTileType.m_value = num;
			liquidMergeType.m_value = thisLiquidType;
			if (thisLiquidType != 0)
			{
			}
			if (thisLiquidType != 0)
			{
				return;
			}
		}

		// Token: 0x06001BB2 RID: 7090 RVA: 0x000A99E0 File Offset: 0x000A7BE0
		public unsafe static void LavaCheck(int x, int y, uint* tileLookup, byte* tileTypeBHeader, byte* tileTypeLiquid, int worldWidth)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001BB3 RID: 7091 RVA: 0x000A9A04 File Offset: 0x000A7C04
		public unsafe static void HoneyCheck(int x, int y, uint* tileLookup, byte* tileTypeBHeader, byte* tileTypeLiquid, int worldWidth)
		{
			if (!true)
			{
			}
			Liquid.LiquidCheck(x, y, 2, tileLookup, tileTypeBHeader, tileTypeLiquid, worldWidth);
		}

		// Token: 0x06001BB4 RID: 7092 RVA: 0x000A9A24 File Offset: 0x000A7C24
		public unsafe static void ShimmerCheck(int x, int y, uint* tileLookup, byte* tileTypeBHeader, byte* tileTypeLiquid, int worldWidth)
		{
			if (!true)
			{
			}
			Liquid.LiquidCheck(x, y, 3, tileLookup, tileTypeBHeader, tileTypeLiquid, worldWidth);
		}

		// Token: 0x06001BB5 RID: 7093 RVA: 0x000A9A44 File Offset: 0x000A7C44
		public static void DelWater(int l)
		{
			if (!true)
			{
			}
			Tile tile;
			bool flag = tile.nactive();
		}

		// Token: 0x06001BB6 RID: 7094 RVA: 0x000A9B24 File Offset: 0x000A7D24
		public Liquid()
		{
		}

		// Token: 0x06001BB7 RID: 7095 RVA: 0x000A9B38 File Offset: 0x000A7D38
		// Note: this type is marked as 'beforefieldinit'.
		static Liquid()
		{
		}

		// Token: 0x040028D1 RID: 10449
		public static int skipCount;

		// Token: 0x040028D2 RID: 10450
		public static int stuckCount;

		// Token: 0x040028D3 RID: 10451
		public static int stuckAmount;

		// Token: 0x040028D4 RID: 10452
		public static int cycles;

		// Token: 0x040028D5 RID: 10453
		public static int curMaxLiquid;

		// Token: 0x040028D6 RID: 10454
		public static int numLiquid;

		// Token: 0x040028D7 RID: 10455
		public static bool stuck;

		// Token: 0x040028D8 RID: 10456
		public static bool quickFall;

		// Token: 0x040028D9 RID: 10457
		public static bool quickSettle;

		// Token: 0x040028DA RID: 10458
		private static int wetCounter;

		// Token: 0x040028DB RID: 10459
		public static int panicCounter;

		// Token: 0x040028DC RID: 10460
		public static bool panicMode;

		// Token: 0x040028DD RID: 10461
		public static int panicY;

		// Token: 0x040028DE RID: 10462
		public const int maxLiquidBuffer = 50000;

		// Token: 0x040028DF RID: 10463
		public static int maxLiquid;

		// Token: 0x040028E0 RID: 10464
		public int x;

		// Token: 0x040028E1 RID: 10465
		public int y;

		// Token: 0x040028E2 RID: 10466
		public int kill;

		// Token: 0x040028E3 RID: 10467
		public int delay;

		// Token: 0x040028E4 RID: 10468
		private static HashSet<int> _netChangeSet;

		// Token: 0x040028E5 RID: 10469
		private static HashSet<int> _swapNetChangeSet;
	}
}
