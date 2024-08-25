using System;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Utilities;

namespace Terraria
{
	// Token: 0x020003ED RID: 1005
	public class HitTile
	{
		// Token: 0x06001AEA RID: 6890 RVA: 0x00072600 File Offset: 0x00070800
		public static void ClearAllTilesAtThisLocation(int x, int y)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
			}
		}

		// Token: 0x06001AEB RID: 6891 RVA: 0x00072618 File Offset: 0x00070818
		public void ClearThisTile(int x, int y)
		{
			this.Clear(x);
			this.Prune();
		}

		// Token: 0x06001AEC RID: 6892 RVA: 0x00072634 File Offset: 0x00070834
		public HitTile()
		{
			int[] hitTileObjectData = this.HitTileObjectData;
			int num = this.NextCrackStyle();
			hitTileObjectData.m_value = num;
			int[] array = this.order;
		}

		// Token: 0x06001AED RID: 6893 RVA: 0x00072674 File Offset: 0x00070874
		private int NextCrackStyle()
		{
			if (!true)
			{
			}
			return 43139072;
		}

		// Token: 0x06001AEE RID: 6894 RVA: 0x0007268C File Offset: 0x0007088C
		public int TryFinding(int x, int y, int hitType)
		{
			/*
An exception occurred when decompiling this method (06001AEE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.HitTile::TryFinding(System.Int32,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	stloc:int32[](var_0_06, ldfld:int32[](HitTile::HitTileObjectData, ldloc:HitTile(this)))
	stloc:int32[](var_1_0D, ldfld:int32[](HitTile::order, ldloc:HitTile(this)))
	brtrue(IL_0000, logicnot:bool(ldc.i4:bool(0)))
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

		// Token: 0x06001AEF RID: 6895 RVA: 0x000726AC File Offset: 0x000708AC
		public void TryClearingAndPruning(int x, int y, int hitType)
		{
			int num = this.TryFinding(x, y, hitType);
		}

		// Token: 0x06001AF0 RID: 6896 RVA: 0x000726C4 File Offset: 0x000708C4
		public int HitObject(int x, int y, int hitType)
		{
			int[] hitTileObjectData = this.HitTileObjectData;
			int[] array = this.order;
			if (false)
			{
			}
			int num = this.bufferLocation;
			hitTileObjectData.m_value = x;
			hitTileObjectData.m_value = y;
			hitTileObjectData.m_value = hitType;
			return this.bufferLocation;
		}

		// Token: 0x06001AF1 RID: 6897 RVA: 0x00072704 File Offset: 0x00070904
		public void UpdatePosition(int tileId, int x, int y)
		{
			int[] hitTileObjectData = this.HitTileObjectData;
		}

		// Token: 0x06001AF2 RID: 6898 RVA: 0x00072718 File Offset: 0x00070918
		public int AddDamage(int tileId, int damageAmount, bool updateAmount = true)
		{
			if (damageAmount == 0)
			{
				int num = this.bufferLocation;
				return;
			}
		}

		// Token: 0x06001AF3 RID: 6899 RVA: 0x00072734 File Offset: 0x00070934
		private void ClearEntryData(int tileId)
		{
			int[] hitTileObjectData = this.HitTileObjectData;
			int num = this.NextCrackStyle();
			int[] hitTileObjectData2 = this.HitTileObjectData;
		}

		// Token: 0x06001AF4 RID: 6900 RVA: 0x00072758 File Offset: 0x00070958
		private void SortSlots(int tileId)
		{
			int num = this.bufferLocation;
			int[] array = this.order;
			this.bufferLocation = num;
			this.ClearEntryData(num);
			int[] array2 = this.order;
			int num2 = this.bufferLocation;
		}

		// Token: 0x06001AF5 RID: 6901 RVA: 0x00072794 File Offset: 0x00070994
		public void Clear(int tileId)
		{
			this.ClearEntryData(tileId);
			int[] array = this.order;
		}

		// Token: 0x06001AF6 RID: 6902 RVA: 0x000727B4 File Offset: 0x000709B4
		public void Prune()
		{
			int[] hitTileObjectData = this.HitTileObjectData;
		}

		// Token: 0x06001AF7 RID: 6903 RVA: 0x000727FC File Offset: 0x000709FC
		public void DrawFreshAnimations(SpriteBatch spriteBatch)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool settingsEnabled_MinersWobble = Main.SettingsEnabled_MinersWobble;
			if (num == 0)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			bool flag = Main.ShouldShowInvisibleWalls();
			long num2 = 0L;
			bool flag2 = WorldGen.InWorld(int.MinValue, 536870912, (int)num2);
			Tile tile;
			bool isLoaded = tile.IsLoaded;
		}

		// Token: 0x06001AF8 RID: 6904 RVA: 0x000728F0 File Offset: 0x00070AF0
		// Note: this type is marked as 'beforefieldinit'.
		static HitTile()
		{
		}

		// Token: 0x0400281F RID: 10271
		private static int lastCrack;

		// Token: 0x04002820 RID: 10272
		public const int xIndex = 0;

		// Token: 0x04002821 RID: 10273
		public const int yIndex = 1;

		// Token: 0x04002822 RID: 10274
		public const int damageIndex = 2;

		// Token: 0x04002823 RID: 10275
		public const int typeIndex = 3;

		// Token: 0x04002824 RID: 10276
		public const int timeToLiveIndex = 4;

		// Token: 0x04002825 RID: 10277
		public const int crackStyleIndex = 5;

		// Token: 0x04002826 RID: 10278
		public const int animationTimeElapsedIndex = 6;

		// Token: 0x04002827 RID: 10279
		public const int HitTileObjectCount = 7;

		// Token: 0x04002828 RID: 10280
		internal const int UNUSED = 0;

		// Token: 0x04002829 RID: 10281
		internal const int TILE = 1;

		// Token: 0x0400282A RID: 10282
		internal const int WALL = 2;

		// Token: 0x0400282B RID: 10283
		internal const int MAX_HITTILES = 500;

		// Token: 0x0400282C RID: 10284
		internal const int TIMETOLIVE = 60;

		// Token: 0x0400282D RID: 10285
		private static UnifiedRandom rand;

		// Token: 0x0400282E RID: 10286
		public readonly int[] HitTileObjectData;

		// Token: 0x0400282F RID: 10287
		private readonly int[] order;

		// Token: 0x04002830 RID: 10288
		private int bufferLocation;
	}
}
