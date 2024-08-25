using System;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes
{
	// Token: 0x020008EE RID: 2286
	public class GraniteBiome : MicroBiome
	{
		// Token: 0x0600460A RID: 17930 RVA: 0x00256C64 File Offset: 0x00254E64
		public static bool CanPlace(Point origin, StructureMap structures)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x0600460B RID: 17931 RVA: 0x00256C80 File Offset: 0x00254E80
		public override bool Place(Point origin, StructureMap structures)
		{
			if (!true)
			{
			}
			Tile tile;
			return tile.active();
		}

		// Token: 0x0600460C RID: 17932 RVA: 0x00256CB0 File Offset: 0x00254EB0
		private void BuildMagmaMap(Point tileOrigin)
		{
			this._sourceMagmaMap = 42165528;
			GraniteBiome.Magma[,] sourceMagmaMap = this._sourceMagmaMap;
			this._targetMagmaMap = 42165528;
			GraniteBiome.Magma[,] sourceMagmaMap2 = this._sourceMagmaMap;
			GraniteBiome.Magma[,] sourceMagmaMap3 = this._sourceMagmaMap;
			if (sourceMagmaMap == null)
			{
			}
			long num = 0L;
			bool flag = WorldGen.SolidTile(42165528, 43134976, num != 0L);
			bool isActive = sourceMagmaMap3.IsActive;
			GraniteBiome.Magma[,] sourceMagmaMap4 = this._sourceMagmaMap;
			GraniteBiome.Magma[,] targetMagmaMap = this._targetMagmaMap;
			bool isActive2 = sourceMagmaMap4.IsActive;
			bool isActive3 = targetMagmaMap.IsActive;
			GraniteBiome.Magma[,] sourceMagmaMap5 = this._sourceMagmaMap;
			GraniteBiome.Magma[,] sourceMagmaMap6 = this._sourceMagmaMap;
		}

		// Token: 0x0600460D RID: 17933 RVA: 0x00256D50 File Offset: 0x00254F50
		private void SimulatePressure([Out] Rectangle effectedMapArea)
		{
			GraniteBiome.Magma[,] sourceMagmaMap = this._sourceMagmaMap;
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				if (num == 0)
				{
				}
				return;
			}
			Vector2D vector2D;
			double num2 = vector2D.Length();
		}

		// Token: 0x0600460E RID: 17934 RVA: 0x00256D98 File Offset: 0x00254F98
		private bool ShouldUseLava(Point tileOrigin)
		{
			/*
An exception occurred when decompiling this method (0600460E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Biomes.GraniteBiome::ShouldUseLava(Microsoft.Xna.Framework.Point)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:valuetype Terraria.GameContent.Biomes.GraniteBiome/Magma[, ](var_0_06, ldfld:valuetype Terraria.GameContent.Biomes.GraniteBiome/Magma[, ](GraniteBiome::_sourceMagmaMap, ldloc:GraniteBiome(this)))
	stloc:valuetype Terraria.GameContent.Biomes.GraniteBiome/Magma[, ](var_3_0F, ldfld:valuetype Terraria.GameContent.Biomes.GraniteBiome/Magma[, ](GraniteBiome::_sourceMagmaMap, ldloc:GraniteBiome(this)))
	stloc:bool(var_7_1A, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_6)))
	stloc:uint16(var_9_23, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_8)))
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

		// Token: 0x0600460F RID: 17935 RVA: 0x00256DD0 File Offset: 0x00254FD0
		private void PlaceGranite(Point tileOrigin, Rectangle magmaMapArea)
		{
			bool flag = this.ShouldUseLava(tileOrigin);
			long num = 0L;
			bool isActive = this._sourceMagmaMap.IsActive;
			if (!true)
			{
			}
			long num2 = 0L;
			bool flag2 = WorldGen.SolidTile(0, (int)num, num2 != 0L);
		}

		// Token: 0x06004610 RID: 17936 RVA: 0x00256E20 File Offset: 0x00255020
		private void CleanupTiles(Point tileOrigin, Rectangle magmaMapArea)
		{
			if (!true)
			{
			}
			long num = 0L;
			GraniteBiome.Magma[,] sourceMagmaMap = this._sourceMagmaMap;
			bool isActive = sourceMagmaMap.IsActive;
			if (sourceMagmaMap == null)
			{
			}
			if (sourceMagmaMap == null)
			{
			}
			long num2 = 0L;
			bool flag = WorldGen.SolidTile(0, (int)num, num2 != 0L);
		}

		// Token: 0x06004611 RID: 17937 RVA: 0x00256E78 File Offset: 0x00255078
		private void PlaceDecorations(Point tileOrigin, Rectangle magmaMapArea)
		{
			if (!true)
			{
			}
			long num = 0L;
			GraniteBiome.Magma[,] sourceMagmaMap = this._sourceMagmaMap;
			bool isActive = sourceMagmaMap.IsActive;
			long num2 = 0L;
			int num3;
			WorldUtils.TileFrame(num3, (int)num, num2 != 0L);
			if (sourceMagmaMap == null)
			{
			}
			int num4 = 1;
			WorldGen.SquareWallFrame(0, (int)num, num4 != 0);
			int num5 = 8;
			FastRandom fastRandom;
			if (fastRandom.Next(num5) == 0)
			{
				if (!true)
				{
				}
				Tile tile;
				bool flag = tile.active();
				if (!true)
				{
				}
				Tile tile2;
				bool flag2 = tile2.active();
				int num6 = 3;
				long num7 = 0L;
				if (!isActive)
				{
				}
				long num8 = 0L;
				int num9;
				WorldGen.PlaceUncheckedStalactite(0, num6, num7 != 0L, num9, num8 != 0L);
				if (!true)
				{
				}
				Tile tile3;
				bool flag3 = tile3.active();
				int num10 = 3;
				long num11 = 0L;
				if (!isActive)
				{
				}
				long num12 = 0L;
				int num13;
				WorldGen.PlaceUncheckedStalactite(0, num10, num11 != 0L, num13, num12 != 0L);
			}
			int num14 = 2;
			int num15;
			if (num15 == 0)
			{
				if (!false)
				{
				}
				int num16 = 1;
				long num17 = 0L;
				Tile.SmoothSlope(1073741824, num14, num16 != 0, num17 != 0L);
			}
		}

		// Token: 0x06004612 RID: 17938 RVA: 0x00256F54 File Offset: 0x00255154
		public GraniteBiome()
		{
		}

		// Token: 0x06004613 RID: 17939 RVA: 0x00256F68 File Offset: 0x00255168
		// Note: this type is marked as 'beforefieldinit'.
		static GraniteBiome()
		{
			if (!true)
			{
			}
		}

		// Token: 0x0400825B RID: 33371
		private const int MAX_MAGMA_ITERATIONS = 300;

		// Token: 0x0400825C RID: 33372
		private GraniteBiome.Magma[,] _sourceMagmaMap;

		// Token: 0x0400825D RID: 33373
		private GraniteBiome.Magma[,] _targetMagmaMap;

		// Token: 0x0400825E RID: 33374
		private static Vector2D[] _normalisedVectors;

		// Token: 0x020008EF RID: 2287
		private struct Magma
		{
			// Token: 0x06004614 RID: 17940 RVA: 0x00256F90 File Offset: 0x00255190
			private Magma(double pressure, double resistance, bool active)
			{
				this.Pressure = pressure;
			}

			// Token: 0x06004615 RID: 17941 RVA: 0x00256FA4 File Offset: 0x002551A4
			public GraniteBiome.Magma ToFlow()
			{
				double pressure = this.Pressure;
				double resistance = this.Resistance;
				GraniteBiome.Magma magma;
				magma.Resistance = resistance;
				magma.IsActive = true;
				magma.Pressure = pressure;
				return magma;
			}

			// Token: 0x06004616 RID: 17942 RVA: 0x00256FD8 File Offset: 0x002551D8
			public static GraniteBiome.Magma CreateFlow(double pressure, double resistance = 0.0)
			{
				GraniteBiome.Magma magma;
				magma.IsActive = true;
				magma.Pressure = pressure;
				return magma;
			}

			// Token: 0x06004617 RID: 17943 RVA: 0x00256FF4 File Offset: 0x002551F4
			public static GraniteBiome.Magma CreateEmpty(double resistance = 0.0)
			{
				GraniteBiome.Magma magma;
				magma.Resistance = resistance;
				return magma;
			}

			// Token: 0x0400825F RID: 33375
			public readonly double Pressure;

			// Token: 0x04008260 RID: 33376
			public readonly double Resistance;

			// Token: 0x04008261 RID: 33377
			public readonly bool IsActive;
		}
	}
}
