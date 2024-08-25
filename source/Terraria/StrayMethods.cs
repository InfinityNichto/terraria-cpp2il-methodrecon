using System;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;

namespace Terraria
{
	// Token: 0x0200045D RID: 1117
	public class StrayMethods
	{
		// Token: 0x06002A3A RID: 10810 RVA: 0x001B21D8 File Offset: 0x001B03D8
		public static bool CountSandHorizontally(int i, int j, bool[] fittingTypes, int requiredTotalSpread = 4, int spreadInEachAxis = 5)
		{
			/*
An exception occurred when decompiling this method (06002A3A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.StrayMethods::CountSandHorizontally(System.Int32,System.Int32,System.Boolean[],System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_003A:
	stloc:int16(var_12_41, callgetter:int16(Tile::get_sTileHeader, ldloc:Tile[exp:valuetype Terraria.Tile&](var_11)))
	stloc:bool(var_14_4E, call:bool(WorldGen::SolidTileAllowBottomSlope, ldc.i4:int32(0), ldc.i4:int32(43143168)))
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

		// Token: 0x06002A3B RID: 10811 RVA: 0x001B2234 File Offset: 0x001B0434
		public static bool CanSpawnSandstormHostile(Vector2 position, int expandUp, int expandDown)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06002A3C RID: 10812 RVA: 0x001B2250 File Offset: 0x001B0450
		public static bool CanSpawnSandstormFriendly(Vector2 position, int expandUp, int expandDown)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06002A3D RID: 10813 RVA: 0x001B226C File Offset: 0x001B046C
		public static void CheckArenaScore(Vector2 arenaCenter, [Out] Point xLeftEnd, [Out] Point xRightEnd, int walkerWidthInTiles = 5, int walkerHeightInTiles = 10)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Point point;
			xLeftEnd.X = point;
			arenaCenter.X = point;
			if (num == 0)
			{
			}
			arenaCenter.X = (float)num;
			xLeftEnd.X = num;
		}

		// Token: 0x06002A3E RID: 10814 RVA: 0x001B22A0 File Offset: 0x001B04A0
		public static void SendWalker(Point startFloorPosition, int height, int direction, [Out] int distanceCoveredInTiles, [Out] Point lastIteratedFloorSpot, int maxDistance = 100, bool showDebug = false)
		{
			int num = 1;
			lastIteratedFloorSpot.X = startFloorPosition;
			if (num == 0)
			{
			}
			int num2 = 16256;
			Dust dust;
			dust.scale = (float)num2;
			lastIteratedFloorSpot.X = startFloorPosition;
		}

		// Token: 0x06002A3F RID: 10815 RVA: 0x001B22DC File Offset: 0x001B04DC
		public StrayMethods()
		{
		}
	}
}
