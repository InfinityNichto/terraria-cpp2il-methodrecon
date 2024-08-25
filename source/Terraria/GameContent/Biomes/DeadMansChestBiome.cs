using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Newtonsoft.Json;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes
{
	// Token: 0x020008E4 RID: 2276
	public class DeadMansChestBiome : MicroBiome
	{
		// Token: 0x060045DD RID: 17885 RVA: 0x002561C8 File Offset: 0x002543C8
		public override bool Place(Point origin, StructureMap structures)
		{
			bool flag = DeadMansChestBiome.IsAGoodSpot(origin);
			this.ClearCaches();
			this.FindBoulderTrapSpots(origin);
			this.FindDartTrapSpots(origin);
			this.FindExplosiveTrapSpots(origin);
			bool flag2 = this.AreThereEnoughTraps();
			List<DeadMansChestBiome.DartTrapPlacementAttempt> dartTrapPlacementSpots = this._dartTrapPlacementSpots;
			List<DeadMansChestBiome.WirePlacementAttempt> wirePlacementSpots = this._wirePlacementSpots;
			List<DeadMansChestBiome.BoulderPlacementAttempt> boulderPlacementSpots = this._boulderPlacementSpots;
			List<DeadMansChestBiome.ExplosivePlacementAttempt> explosivePlacementAttempt = this._explosivePlacementAttempt;
			this.PlaceWiresForExplosives(origin);
			if (false)
			{
				throw new OutOfMemoryException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060045DE RID: 17886 RVA: 0x000021DB File Offset: 0x000003DB
		private void PlaceWiresForExplosives(Point origin)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060045DF RID: 17887 RVA: 0x00256258 File Offset: 0x00254458
		private bool AreThereEnoughTraps()
		{
			/*
An exception occurred when decompiling this method (060045DF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Biomes.DeadMansChestBiome::AreThereEnoughTraps()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_0B, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class Terraria.GameContent.Biomes.DeadMansChestBiome/BoulderPlacementAttempt>[exp:List`1](DeadMansChestBiome::_boulderPlacementSpots, ldloc:DeadMansChestBiome(this))))
	stloc:int32(var_1_17, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class Terraria.GameContent.Biomes.DeadMansChestBiome/ExplosivePlacementAttempt>[exp:List`1](DeadMansChestBiome::_explosivePlacementAttempt, ldloc:DeadMansChestBiome(this))))
	stloc:int32(var_2_23, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class Terraria.GameContent.Biomes.DeadMansChestBiome/DartTrapPlacementAttempt>[exp:List`1](DeadMansChestBiome::_dartTrapPlacementSpots, ldloc:DeadMansChestBiome(this))))
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

		// Token: 0x060045E0 RID: 17888 RVA: 0x000021DB File Offset: 0x000003DB
		private void ClearCaches()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060045E1 RID: 17889 RVA: 0x0025628C File Offset: 0x0025448C
		private void FindBoulderTrapSpots(Point position)
		{
			UnifiedRandom random = GenBase._random;
			UnifiedRandom random2 = GenBase._random;
		}

		// Token: 0x060045E2 RID: 17890 RVA: 0x002562B8 File Offset: 0x002544B8
		private void FindBoulderTrapSpot(Point position)
		{
			if (!true)
			{
			}
			Tile tile;
			bool flag = tile.active();
		}

		// Token: 0x060045E3 RID: 17891 RVA: 0x002562DC File Offset: 0x002544DC
		private void PlaceBoulderTrapSpot(Point position, int yPush)
		{
			int num = 65533;
			if (num == 0)
			{
			}
			Tile tile;
			bool flag = tile.active();
			if (num == 0)
			{
			}
			if (num == 0)
			{
				if (num == 0)
				{
				}
				if (num != 0)
				{
				}
			}
			if (num == 0)
			{
			}
			if (num != 0)
			{
				if (num == 0)
				{
				}
				if (num == 0)
				{
					if (num == 0)
					{
					}
					Tile tile2;
					bool flag2 = tile2.active();
					if (num == 0)
					{
					}
					if (num == 0)
					{
						return;
					}
				}
			}
		}

		// Token: 0x060045E4 RID: 17892 RVA: 0x000021DB File Offset: 0x000003DB
		private void FindDartTrapSpots(Point position)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060045E5 RID: 17893 RVA: 0x000021DB File Offset: 0x000003DB
		private bool FindDartTrapSpotSingle(Point position, int directionX)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060045E6 RID: 17894 RVA: 0x000021DB File Offset: 0x000003DB
		private void FindExplosiveTrapSpots(Point position)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060045E7 RID: 17895 RVA: 0x00256340 File Offset: 0x00254540
		private bool IsGoodSpotsForExplosive(int x, int y)
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
			if (num != 0)
			{
				return;
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
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
			if (num != 0)
			{
				return;
			}
		}

		// Token: 0x060045E8 RID: 17896 RVA: 0x00256378 File Offset: 0x00254578
		public List<int> GetPossibleChestsToTrapify(StructureMap structures)
		{
			/*
An exception occurred when decompiling this method (060045E8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.List`1<System.Int32> Terraria.GameContent.Biomes.DeadMansChestBiome::GetPossibleChestsToTrapify(Terraria.WorldBuilding.StructureMap)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(DeadMansChestBiome::ClearCaches, ldloc:DeadMansChestBiome(this))
	stloc:bool(var_4_1F, call:bool(DeadMansChestBiome::AreThereEnoughTraps, ldloc:DeadMansChestBiome(this)))
	brtrue(IL_0000, logicnot:bool(ldloc:StructureMap[exp:bool](structures)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

		// Token: 0x060045E9 RID: 17897 RVA: 0x002563A8 File Offset: 0x002545A8
		private static bool IsAGoodSpot(Point position)
		{
			/*
An exception occurred when decompiling this method (060045E9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Biomes.DeadMansChestBiome::IsAGoodSpot(Microsoft.Xna.Framework.Point)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001C:
	stloc:int64(var_9_1D, ldc.i4:int64(0))
	stloc:int32(var_11_21, ldc.i4:int32(20))
	stloc:int32(var_12_2D, call:int32(WorldGen::countWires, ldc.i4:int32(0), ldloc:int64[exp:int32](var_9_1D), ldloc:int32(var_11_21)))
	stloc:int32(var_14_33, ldc.i4:int32(1))
	stloc:int64(var_15_36, ldc.i4:int64(0))
	stloc:int32(var_16_44, call:int32(WorldGen::countTiles, ldc.i4:int32(0), ldloc:int64[exp:int32](var_9_1D), ldloc:int64[exp:bool](var_15_36), ldloc:int32[exp:bool](var_14_33)))
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

		// Token: 0x060045EA RID: 17898 RVA: 0x002563FC File Offset: 0x002545FC
		private void TurnGoldChestIntoDeadMansChest(Point position)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int num2 = 467;
			Tile tile;
			tile.type = (ushort)num2;
			tile.frameX = (short)num2;
			tile.frameY = (short)num2;
			UnifiedRandom random = GenBase._random;
			int num3 = 3;
			if (random.Next(num3) == 0)
			{
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				Item item;
				if (num != 0 && item != null && item == null)
				{
					throw new ArrayTypeMismatchException();
				}
				if (43134976 == 0)
				{
				}
			}
		}

		// Token: 0x060045EB RID: 17899 RVA: 0x00256470 File Offset: 0x00254670
		private void ActuallyPlaceDartTrap(Point position, int directionX, int x, int y, int xPush, Tile t)
		{
			if (18 == 0)
			{
			}
			long num = 0L;
			WorldGen.TileFrame(x, y, true, num != 0L);
		}

		// Token: 0x060045EC RID: 17900 RVA: 0x00256498 File Offset: 0x00254698
		private void PlaceWireLine(Point start, int offsetX, int offsetY, int steps)
		{
			if (!true)
			{
			}
			int num = 1;
			Tile tile;
			tile.wire(num != 0);
		}

		// Token: 0x060045ED RID: 17901 RVA: 0x002564B8 File Offset: 0x002546B8
		private void ActuallyPlaceBoulderTrap(Point position, int yPush, int requiredHeight, int bestType)
		{
			if (65533 == 0)
			{
			}
			Tile tile;
			tile.ClearTile();
		}

		// Token: 0x060045EE RID: 17902 RVA: 0x0025650C File Offset: 0x0025470C
		private void ActuallyPlaceExplosive(Point position)
		{
			if (!true)
			{
			}
			long num = 0L;
			Tile tile;
			tile.frameY = (short)num;
			long num2 = 0L;
			tile.frameX = (short)num2;
			long num3 = 0L;
			tile.slope((byte)num3);
			long num4 = 0L;
			tile.halfBrick(num4 != 0L);
			if (!true)
			{
			}
		}

		// Token: 0x060045EF RID: 17903 RVA: 0x00256548 File Offset: 0x00254748
		public DeadMansChestBiome()
		{
		}

		// Token: 0x04008239 RID: 33337
		private List<DeadMansChestBiome.DartTrapPlacementAttempt> _dartTrapPlacementSpots;

		// Token: 0x0400823A RID: 33338
		private List<DeadMansChestBiome.WirePlacementAttempt> _wirePlacementSpots;

		// Token: 0x0400823B RID: 33339
		private List<DeadMansChestBiome.BoulderPlacementAttempt> _boulderPlacementSpots;

		// Token: 0x0400823C RID: 33340
		private List<DeadMansChestBiome.ExplosivePlacementAttempt> _explosivePlacementAttempt;

		// Token: 0x0400823D RID: 33341
		[JsonProperty("NumberOfDartTraps")]
		private IntRange _numberOfDartTraps = 1;

		// Token: 0x0400823E RID: 33342
		[JsonProperty("NumberOfBoulderTraps")]
		private IntRange _numberOfBoulderTraps = 1;

		// Token: 0x0400823F RID: 33343
		[JsonProperty("NumberOfStepsBetweenBoulderTraps")]
		private IntRange _numberOfStepsBetweenBoulderTraps = 1;

		// Token: 0x020008E5 RID: 2277
		private class DartTrapPlacementAttempt
		{
			// Token: 0x060045F0 RID: 17904 RVA: 0x00256570 File Offset: 0x00254770
			public DartTrapPlacementAttempt(Point position, int directionX, int x, int y, int xPush, Tile t)
			{
				this.position = position;
				this.x = x;
				this.position = y;
				this.directionX = directionX;
				this.x = xPush;
				this.t = t;
			}

			// Token: 0x04008240 RID: 33344
			public int directionX;

			// Token: 0x04008241 RID: 33345
			public int xPush;

			// Token: 0x04008242 RID: 33346
			public int x;

			// Token: 0x04008243 RID: 33347
			public int y;

			// Token: 0x04008244 RID: 33348
			public Point position;

			// Token: 0x04008245 RID: 33349
			public Tile t;
		}

		// Token: 0x020008E6 RID: 2278
		private class BoulderPlacementAttempt
		{
			// Token: 0x060045F1 RID: 17905 RVA: 0x002565B0 File Offset: 0x002547B0
			public BoulderPlacementAttempt(Point position, int yPush, int requiredHeight, int bestType)
			{
				this.position = position;
				this.yPush = yPush;
				this.bestType = requiredHeight;
				this.bestType = bestType;
			}

			// Token: 0x04008246 RID: 33350
			public Point position;

			// Token: 0x04008247 RID: 33351
			public int yPush;

			// Token: 0x04008248 RID: 33352
			public int requiredHeight;

			// Token: 0x04008249 RID: 33353
			public int bestType;
		}

		// Token: 0x020008E7 RID: 2279
		private class WirePlacementAttempt
		{
			// Token: 0x060045F2 RID: 17906 RVA: 0x002565E0 File Offset: 0x002547E0
			public WirePlacementAttempt(Point position, int dirX, int dirY, int steps)
			{
				this.position = position;
				this.dirX = dirX;
				this.steps = dirY;
				this.steps = steps;
			}

			// Token: 0x0400824A RID: 33354
			public Point position;

			// Token: 0x0400824B RID: 33355
			public int dirX;

			// Token: 0x0400824C RID: 33356
			public int dirY;

			// Token: 0x0400824D RID: 33357
			public int steps;
		}

		// Token: 0x020008E8 RID: 2280
		private class ExplosivePlacementAttempt
		{
			// Token: 0x060045F3 RID: 17907 RVA: 0x00256610 File Offset: 0x00254810
			public ExplosivePlacementAttempt(Point position)
			{
				this.position = position;
			}

			// Token: 0x0400824E RID: 33358
			public Point position;
		}
	}
}
