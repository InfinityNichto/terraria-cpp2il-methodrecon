using System;
using Microsoft.Xna.Framework;
using Terraria.IO;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes
{
	// Token: 0x020008F2 RID: 2290
	public class JunglePass : GenPass
	{
		// Token: 0x06004624 RID: 17956 RVA: 0x002575D4 File Offset: 0x002557D4
		public JunglePass()
		{
		}

		// Token: 0x06004625 RID: 17957 RVA: 0x002575E4 File Offset: 0x002557E4
		protected override void ApplyPass(GenerationProgress progress, GameConfiguration configuration)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Point point;
			if (point == null)
			{
			}
			int num2 = 1;
			if (num2 == 0)
			{
			}
			int value = num2.m_value;
			int num3 = 3;
			this.PlaceFirstPassMud(1073741824, int.MinValue, num3);
			int num4 = 63;
			int num5 = 2;
			this.PlaceGemsAt(1073741824, int.MinValue, (ushort)num4, num5);
			long num6 = 0L;
			progress.Set(0.15);
			int num7 = 250;
			int num8 = 150;
			this.ApplyRandomMovement((int)num6, int.MinValue, num7, num8);
			long num9 = 0L;
			this.PlaceFirstPassMud(1073741824, int.MinValue, (int)num9);
			int num10 = 65;
			int num11 = 2;
			this.PlaceGemsAt(1073741824, int.MinValue, (ushort)num10, num11);
			long num12 = 0L;
			progress.Set(0.3);
			int num13 = 400;
			int num14 = 150;
			this.ApplyRandomMovement((int)num12, int.MinValue, num13, num14);
			this.PlaceFirstPassMud((int)num12, int.MinValue, num13);
			int num15 = 67;
			int num16 = 2;
			this.PlaceGemsAt((int)num12, int.MinValue, (ushort)num15, num16);
			long num17 = 0L;
			progress.Set(0.45);
			UnifiedRandom random = GenBase._random;
			long num18 = 16505L;
			int num19 = random.Next((int)num17, int.MinValue);
			if (num18 == 0L)
			{
			}
		}

		// Token: 0x06004626 RID: 17958 RVA: 0x00257730 File Offset: 0x00255930
		private void PlaceGemsAt(int x, int y, ushort baseGem, int gemVariants)
		{
			double worldScale = this._worldScale;
			UnifiedRandom random = GenBase._random;
			double worldScale2 = this._worldScale;
			int num = random.Next(x, y);
			UnifiedRandom random2 = GenBase._random;
			double worldScale3 = this._worldScale;
			int num2 = random2.Next(x, y);
			UnifiedRandom random3 = GenBase._random;
			int num3 = 3;
			int num4 = 7;
			int num5 = random3.Next(num3, num4);
			UnifiedRandom random4 = GenBase._random;
			int num6 = 3;
			int num7 = 8;
			int num8 = random4.Next(num6, num7);
			int num9 = GenBase._random.Next(num6, gemVariants);
			double worldScale4 = this._worldScale;
		}

		// Token: 0x06004627 RID: 17959 RVA: 0x002577D0 File Offset: 0x002559D0
		private void PlaceFirstPassMud(int x, int y, int xSpeedScale)
		{
			if (!true)
			{
			}
			UnifiedRandom random = GenBase._random;
			double worldScale = this._worldScale;
			int num = random.Next(x, y);
			int num2 = GenBase._random.Next(50, 150);
		}

		// Token: 0x06004628 RID: 17960 RVA: 0x00257810 File Offset: 0x00255A10
		private Point CreateStartPoint()
		{
			/*
An exception occurred when decompiling this method (06004628)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Point Terraria.GameContent.Biomes.JunglePass::CreateStartPoint()

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

		// Token: 0x06004629 RID: 17961 RVA: 0x00257820 File Offset: 0x00255A20
		private void ApplyRandomMovement(int x, int y, int xRange, int yRange)
		{
			int num = 1;
			UnifiedRandom random = GenBase._random;
			double worldScale = this._worldScale;
			long num2 = 32752L;
			int num3 = random.Next(x, y);
			x.m_value = num;
			UnifiedRandom random2 = GenBase._random;
			double worldScale2 = this._worldScale;
			int num4 = random2.Next(x, y);
			y.m_value = yRange;
			if (num == 0)
			{
			}
			if (num2 == 0L)
			{
			}
			y.m_value = yRange;
		}

		// Token: 0x0600462A RID: 17962 RVA: 0x0025788C File Offset: 0x00255A8C
		private void GenerateTunnelToSurface(int i, int j)
		{
			UnifiedRandom random = GenBase._random;
			int num = 5;
			int num2 = 11;
			int num3 = random.Next(num, num2);
			UnifiedRandom random2 = GenBase._random;
			int num4 = 11;
			int num5 = random2.Next(num, num4);
			UnifiedRandom random3 = GenBase._random;
			int num6 = 10;
			int num7 = 20;
			int num8 = random3.Next(num6, num7);
			if (32752 == 0)
			{
			}
			Tile tile;
			ushort wall = tile.wall;
			Tile tile2;
			bool flag = tile2.active();
			Tile tile3;
			ushort wall2 = tile3.wall;
			Tile tile4;
			bool flag2 = tile4.active();
			Tile tile5;
			ushort wall3 = tile5.wall;
			Tile tile6;
			bool flag3 = tile6.active();
			Tile tile7;
			ushort wall4 = tile7.wall;
			Tile tile8;
			bool flag4 = tile8.active();
			Tile tile9;
			ushort wall5 = tile9.wall;
			Tile tile10;
			bool flag5 = tile10.active();
			Tile tile11;
			ushort wall6 = tile11.wall;
			Tile tile12;
			bool flag6 = tile12.active();
		}

		// Token: 0x0600462B RID: 17963 RVA: 0x00257ABC File Offset: 0x00255CBC
		private void GenerateHolesInMudWalls()
		{
			if (!true)
			{
			}
			UnifiedRandom random = GenBase._random;
			UnifiedRandom random2 = GenBase._random;
			int underworldLayer = Main.UnderworldLayer;
			Tile tile;
			ushort wall = tile.wall;
			Tile tile2;
			ushort wall2 = tile2.wall;
			int num;
			int num2;
			WorldGen.MudWallRunner(num, num2);
		}

		// Token: 0x0600462C RID: 17964 RVA: 0x00257B0C File Offset: 0x00255D0C
		private void GenerateFinishingTouches(GenerationProgress progress, int oldX, int oldY)
		{
			double worldScale = this._worldScale;
			int num = 32768;
			long num2 = 0L;
			int num3 = GenBase._random.Next((int)num2, oldX);
			int num4 = GenBase._random.Next((int)num2, oldX);
			UnifiedRandom random = GenBase._random;
			int num5 = 40;
			int num6 = 100;
			int num7 = random.Next(num5, num6);
			UnifiedRandom random2 = GenBase._random;
			int num8 = 300;
			int num9 = 500;
			int num10 = random2.Next(num8, num9);
			if (num == 0)
			{
			}
			int num11 = 32768;
			long num12 = 0L;
			progress.Set(-600.0);
			int num13 = GenBase._random.Next((int)num12, num10);
			int num14 = GenBase._random.Next(oldX, num10);
			if (num11 == 0)
			{
			}
			if (num11 == 0)
			{
			}
			if (num11 == 0)
			{
			}
			long num15 = 0L;
			Tile tile;
			ushort type = tile.type;
			UnifiedRandom random3 = GenBase._random;
			int num16 = 31;
			int num17 = random3.Next((int)num15, num16);
			UnifiedRandom random4 = GenBase._random;
			int num18 = 31;
			int num19 = random4.Next((int)num15, num18);
			UnifiedRandom random5 = GenBase._random;
			int num20 = 7;
			int num21 = random5.Next(num20);
			UnifiedRandom random6 = GenBase._random;
			int num22 = 10;
			int num23 = 20;
			int num24 = random6.Next(num22, num23);
			UnifiedRandom random7 = GenBase._random;
			int num25 = 30;
			int num26 = 70;
			int num27 = random7.Next(num25, num26);
			if (num11 == 0)
			{
			}
			int num28 = 32768;
			int num29 = GenBase._random.Next(num24, num27);
			int num30 = GenBase._random.Next(num24, oldX);
			if (num28 == 0)
			{
			}
			if (num28 == 0)
			{
			}
			if (num28 == 0)
			{
			}
			Tile tile2;
			ushort type2 = tile2.type;
			UnifiedRandom random8 = GenBase._random;
			int num31 = 4;
			int num32 = 10;
			int num33 = random8.Next(num31, num32);
			UnifiedRandom random9 = GenBase._random;
			int num34 = 5;
			int num35 = 30;
			int num36 = random9.Next(num34, num35);
			if (num28 == 0)
			{
			}
			UnifiedRandom random10 = GenBase._random;
			int num37 = 4;
			if (random10.Next(num37) == 0)
			{
				UnifiedRandom random11 = GenBase._random;
				int num38 = 63;
				int num39 = 69;
				int num40 = random11.Next(num38, num39);
				UnifiedRandom random12 = GenBase._random;
				int num41 = 2;
				int num42 = random12.Next(num38, num41);
				UnifiedRandom random13 = GenBase._random;
				int num43 = 2;
				int num44 = random13.Next(num38, num43);
				UnifiedRandom random14 = GenBase._random;
				int num45 = 3;
				int num46 = 7;
				int num47 = random14.Next(num45, num46);
				UnifiedRandom random15 = GenBase._random;
				int num48 = 4;
				int num49 = 8;
				int num50 = random15.Next(num48, num49);
				if (num28 == 0)
				{
				}
			}
		}

		// Token: 0x04008262 RID: 33378
		private double _worldScale;
	}
}
