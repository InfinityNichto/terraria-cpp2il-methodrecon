using System;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes
{
	// Token: 0x020008F0 RID: 2288
	public class HiveBiome : MicroBiome
	{
		// Token: 0x06004618 RID: 17944 RVA: 0x0025700C File Offset: 0x0025520C
		public override bool Place(Point origin, StructureMap structures)
		{
			bool flag = HiveBiome.TooCloseToImportantLocations(origin);
			Vector2D vector2D = origin.ToVector2D();
			UnifiedRandom genRand = WorldGen.genRand;
			int num = 2;
			int num2 = 5;
			int num3 = genRand.Next(num, num2);
			UnifiedRandom genRand2 = WorldGen.genRand;
			UnifiedRandom genRand3 = WorldGen.genRand;
			int num4 = 2;
			int num5 = 5;
			int num6 = genRand3.Next(num4, num5);
			UnifiedRandom genRand4 = WorldGen.genRand;
			int num7 = 2;
			int num8 = 5;
			int num9 = genRand4.Next(num7, num8);
			UnifiedRandom genRand5 = WorldGen.genRand;
			Vector2D vector2D2 = HiveBiome.CreateHiveTunnel(-1073741824, 0, genRand5);
			int num10 = 50;
			HiveBiome.FrameOutAllHiveContents(origin, num10);
			UnifiedRandom genRand6 = WorldGen.genRand;
			int num11 = 2;
			int num12 = genRand6.Next(num11);
			return false;
		}

		// Token: 0x06004619 RID: 17945 RVA: 0x00257168 File Offset: 0x00255368
		private static void FrameOutAllHiveContents(Point origin, int squareHalfWidth)
		{
			if (!true)
			{
			}
			int num = Math.Max(10, squareHalfWidth);
			int num2 = Math.Min(int.MinValue, squareHalfWidth);
			int num3 = Math.Max(10, squareHalfWidth);
			int num4 = Math.Min(num3, squareHalfWidth);
			if (-2147483648 == 0)
			{
			}
			Tile tile;
			bool flag = tile.active();
			if (-2147483648 == 0)
			{
			}
			int num5 = 1;
			WorldGen.SquareTileFrame(num, num3, num5 != 0);
			if (-2147483648 == 0)
			{
			}
			int num6 = 1;
			WorldGen.SquareWallFrame(num, num3, num6 != 0);
		}

		// Token: 0x0600461A RID: 17946 RVA: 0x002571D4 File Offset: 0x002553D4
		private static Vector2D CreateHiveTunnel(int i, int j, UnifiedRandom random)
		{
			/*
An exception occurred when decompiling this method (0600461A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ReLogic.Utilities.Vector2D Terraria.GameContent.Biomes.HiveBiome::CreateHiveTunnel(System.Int32,System.Int32,Terraria.Utilities.UnifiedRandom)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0174:
	stloc:int32(var_62_179, ldc.i4:int32(11))
	stloc:int32(var_63_185, call:int32(UnifiedRandom::Next, ldloc:UnifiedRandom(random), ldloc:int32(var_59), ldloc:int32(var_62_179)))
	stloc:int32(var_64_189, ldc.i4:int32(11))
	stloc:int32(var_65_195, call:int32(UnifiedRandom::Next, ldloc:UnifiedRandom(random), ldloc:int32(var_59), ldloc:int32(var_64_189)))
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

		// Token: 0x0600461B RID: 17947 RVA: 0x00257378 File Offset: 0x00255578
		private static bool TooCloseToImportantLocations(Point origin)
		{
			/*
An exception occurred when decompiling this method (0600461B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Biomes.HiveBiome::TooCloseToImportantLocations(Microsoft.Xna.Framework.Point)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0008:
	stloc:bool(var_2_0E, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_1)))
	stloc:uint16(var_4_15, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_3)))
	stloc:uint16(var_6_1E, callgetter:uint16(Tile::get_wall, ldloc:Tile[exp:valuetype Terraria.Tile&](var_5)))
	stloc:uint16(var_8_27, callgetter:uint16(Tile::get_wall, ldloc:Tile[exp:valuetype Terraria.Tile&](var_7)))
	stloc:uint16(var_10_30, callgetter:uint16(Tile::get_wall, ldloc:Tile[exp:valuetype Terraria.Tile&](var_9)))
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

		// Token: 0x0600461C RID: 17948 RVA: 0x002573BC File Offset: 0x002555BC
		private static void CreateDentForHoneyFall(int x, int y, int dir)
		{
		}

		// Token: 0x0600461D RID: 17949 RVA: 0x00257414 File Offset: 0x00255614
		private static void CreateBlockedHoneyCube(int x, int y)
		{
			if (!true)
			{
			}
			int num = 1;
			Tile tile;
			tile.active(num != 0);
			int num2 = 225;
			tile.type = (ushort)num2;
		}

		// Token: 0x0600461E RID: 17950 RVA: 0x0025746C File Offset: 0x0025566C
		private static bool SpotActuallyNotInHive(int x, int y)
		{
			/*
An exception occurred when decompiling this method (0600461E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Biomes.HiveBiome::SpotActuallyNotInHive(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:bool(var_1_09, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_0)))
	stloc:uint16(var_3_10, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_2)))
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

		// Token: 0x0600461F RID: 17951 RVA: 0x00257490 File Offset: 0x00255690
		private static bool BadSpotForHoneyFall(int x, int y)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Tile tile;
			bool flag = tile.active();
			if (num == 0)
			{
			}
			Tile tile2;
			bool flag2 = tile2.active();
			if (num == 0)
			{
			}
			Tile tile3;
			bool flag3 = tile3.active();
			if (num == 0)
			{
			}
			Tile tile4;
			return tile4.active();
		}

		// Token: 0x06004620 RID: 17952 RVA: 0x002574DC File Offset: 0x002556DC
		public static void CreateStandForLarva(Vector2D position)
		{
			if (!true)
			{
			}
			int num = 1;
			Tile tile;
			tile.active(num != 0);
			int num2 = 225;
			tile.type = (ushort)num2;
			long num3 = 0L;
			tile.slope((byte)num3);
			long num4 = 0L;
			tile.halfBrick(num4 != 0L);
		}

		// Token: 0x06004621 RID: 17953 RVA: 0x00257528 File Offset: 0x00255728
		public HiveBiome()
		{
		}
	}
}
