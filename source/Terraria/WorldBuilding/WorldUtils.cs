using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.WorldBuilding
{
	// Token: 0x020004EF RID: 1263
	public static class WorldUtils
	{
		// Token: 0x06003094 RID: 12436 RVA: 0x001F698C File Offset: 0x001F4B8C
		public static Rectangle ClampToWorld(Rectangle tileRectangle)
		{
			/*
An exception occurred when decompiling this method (06003094)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Rectangle Terraria.WorldBuilding.WorldUtils::ClampToWorld(Microsoft.Xna.Framework.Rectangle)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_0_0A, call:int32(Math::Min, ldc.i4:int32(0), ldc.i4:int32(0)))
	stloc:int32(var_1_12, call:int32(Math::Max, ldc.i4:int32(0), ldloc:int32(var_0_0A)))
	stloc:int32(var_2_1E, call:int32(Math::Min, ldc.i4:int32(43147264), ldloc:int32(var_0_0A)))
	stloc:int32(var_3_26, call:int32(Math::Max, ldc.i4:int32(0), ldloc:int32(var_2_1E)))
	stloc:int64(var_4_28, ldc.i4:int64(0))
	stloc:int32(var_6_33, call:int32(Math::Min, ldloc:int32(var_5), ldloc:int64[exp:int32](var_4_28)))
	stloc:int32(var_7_3D, call:int32(Math::Max, ldc.i4:int32(0), ldloc:int32(var_6_33)))
	stloc:int64(var_8_40, ldc.i4:int64(0))
	stloc:int32(var_10_4B, call:int32(Math::Min, ldloc:int32(var_9), ldloc:int64[exp:int32](var_8_40)))
	stloc:int32(var_11_55, call:int32(Math::Max, ldc.i4:int32(0), ldloc:int32(var_10_4B)))
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

		// Token: 0x06003095 RID: 12437 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool Gen(Point origin, GenShape shape, GenAction action)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003096 RID: 12438 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool Gen(Point origin, GenShapeActionPair pair)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003097 RID: 12439 RVA: 0x001F69F0 File Offset: 0x001F4BF0
		public static bool Find(Point origin, GenSearch search, [Out] Point result)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06003098 RID: 12440 RVA: 0x001F6A00 File Offset: 0x001F4C00
		public static void ClearTile(int x, int y, bool frameNeighbors = false)
		{
			if (!true)
			{
			}
			Tile tile;
			tile.ClearTile();
			long num = 0L;
			long num2 = 0L;
			WorldGen.TileFrame(0, y, num != 0L, num2 != 0L);
			long num3 = 0L;
			long num4 = 0L;
			WorldGen.TileFrame(0, y, num3 != 0L, num4 != 0L);
			long num5 = 0L;
			long num6 = 0L;
			WorldGen.TileFrame(x, y, num5 != 0L, num6 != 0L);
			long num7 = 0L;
			long num8 = 0L;
			WorldGen.TileFrame(x, y, num7 != 0L, num8 != 0L);
		}

		// Token: 0x06003099 RID: 12441 RVA: 0x001F6A54 File Offset: 0x001F4C54
		public static void ClearWall(int x, int y, bool frameNeighbors = false)
		{
			if (!true)
			{
			}
			long num = 0L;
			Tile tile;
			tile.wall = (ushort)num;
			int num2 = 1;
			WorldGen.SquareWallFrame(0, y, num2 != 0);
			int num3 = 1;
			WorldGen.SquareWallFrame(0, y, num3 != 0);
			int num4 = 1;
			WorldGen.SquareWallFrame(x, y, num4 != 0);
			int num5 = 1;
			WorldGen.SquareWallFrame(x, y, num5 != 0);
		}

		// Token: 0x0600309A RID: 12442 RVA: 0x001F6A9C File Offset: 0x001F4C9C
		public static void TileFrame(int x, int y, bool frameNeighbors = false)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int num2 = 1;
			long num3 = 0L;
			WorldGen.TileFrame(x, y, num2 != 0, num3 != 0L);
			if (num == 0)
			{
			}
			int num4 = 1;
			long num5 = 0L;
			WorldGen.TileFrame(0, y, num4 != 0, num5 != 0L);
			int num6 = 1;
			long num7 = 0L;
			WorldGen.TileFrame(0, y, num6 != 0, num7 != 0L);
			int num8 = 1;
			long num9 = 0L;
			WorldGen.TileFrame(x, y, num8 != 0, num9 != 0L);
			int num10 = 1;
			long num11 = 0L;
			WorldGen.TileFrame(x, y, num10 != 0, num11 != 0L);
		}

		// Token: 0x0600309B RID: 12443 RVA: 0x001F6B04 File Offset: 0x001F4D04
		public static void ClearChestLocation(int x, int y)
		{
			int num = 1;
			WorldUtils.ClearTile(x, y, num != 0);
			int num2 = 1;
			WorldUtils.ClearTile(x, y, num2 != 0);
			int num3 = 1;
			WorldUtils.ClearTile(x, y, num3 != 0);
			int num4 = 1;
			WorldUtils.ClearTile(x, y, num4 != 0);
		}

		// Token: 0x0600309C RID: 12444 RVA: 0x001F6B3C File Offset: 0x001F4D3C
		public static void WireLine(Point start, Point end)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x0600309D RID: 12445 RVA: 0x001F6B58 File Offset: 0x001F4D58
		public static void DebugRegen()
		{
			if (!true)
			{
			}
			WorldGen.clearWorld();
			if (!true)
			{
			}
		}

		// Token: 0x0600309E RID: 12446 RVA: 0x001F6B74 File Offset: 0x001F4D74
		public static void DebugRotate()
		{
		}
	}
}
