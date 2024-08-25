using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Terraria.Physics
{
	// Token: 0x0200053C RID: 1340
	public static class BallCollision
	{
		// Token: 0x06003256 RID: 12886 RVA: 0x001F98F4 File Offset: 0x001F7AF4
		public static BallStepResult Step(PhysicsProperties physicsProperties, Entity entity, float entityAngularVelocity, IBallContactListener listener)
		{
			if (!true)
			{
			}
			long num = 0L;
			Vector2 vector;
			float num2 = vector.Length();
			if (17530 == 0)
			{
			}
			if (17530 == 0)
			{
			}
			int num3 = 32768;
			int num4 = Math.Max(1, (int)num);
			if (num3 == 0)
			{
			}
			if (num3 == 0)
			{
			}
			if (num3 == 0)
			{
			}
			if (num3 == 0)
			{
				return;
			}
			if (num3 == 0)
			{
			}
			if (num3 != 0)
			{
				return;
			}
		}

		// Token: 0x06003257 RID: 12887 RVA: 0x001F9988 File Offset: 0x001F7B88
		private static bool CheckForPassThrough(Vector2 center, [Out] BallPassThroughType type, [Out] Tile contactTile)
		{
			if (!true)
			{
			}
			Tile tile;
			center.X = tile;
			bool flag = tile.nactive();
			bool flag2;
			return flag2;
		}

		// Token: 0x06003258 RID: 12888 RVA: 0x001F99B0 File Offset: 0x001F7BB0
		private static bool IsPositionInsideTile(Vector2 position, Point tileCoordinates, Tile tile)
		{
		}

		// Token: 0x06003259 RID: 12889 RVA: 0x001F99C8 File Offset: 0x001F7BC8
		private static bool IsBallInWorld(Vector2 position, Vector2 size)
		{
			if (16896 == 0)
			{
			}
			if (49664 == 0)
			{
				return;
			}
		}

		// Token: 0x0600325A RID: 12890 RVA: 0x001F99E4 File Offset: 0x001F7BE4
		private static bool GetClosestEdgeToCircle(Vector2 position, Vector2 size, Vector2 velocity, [Out] Vector2 collisionPoint, [Out] Tile collisionTile)
		{
			/*
An exception occurred when decompiling this method (0600325A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Physics.BallCollision::GetClosestEdgeToCircle(Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Vector2,Terraria.Tile)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000D:
	stfld:float32(Vector2::X, ldloc:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](position), ldloc:Tile[exp:float32](var_12))
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

		// Token: 0x0600325B RID: 12891 RVA: 0x001F9A0C File Offset: 0x001F7C0C
		private static bool GetCollisionPointForTile(BallCollision.TileEdges edgesToTest, int x, int y, Vector2 center, Vector2 closestPointOut, float distanceSquaredOut)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Tile tile;
			bool flag = tile.nactive();
			if (num == 0)
			{
			}
			if (num == 0)
			{
				if (num == 0)
				{
				}
				if (num == 0)
				{
					return;
				}
			}
			if (num == 0)
			{
			}
			int num2;
			if (num != 0)
			{
				if (num == 0)
				{
				}
				if (num != 0)
				{
					num2 = 193;
				}
				if (num2 == 0)
				{
				}
				long num3 = 0L;
				if (num2 == 0)
				{
				}
				if (num3 != 0L)
				{
				}
				int num4 = 1;
				if (num2 == 0)
				{
				}
				if (num4 != 0)
				{
				}
			}
			if (num2 == 0)
			{
			}
			while (num2 == 0)
			{
			}
		}

		// Token: 0x0600325C RID: 12892 RVA: 0x001F9A74 File Offset: 0x001F7C74
		private static bool GetSlopeEdge(BallCollision.TileEdges edgesToTest, Tile tile, Vector2 tilePosition, LineSegment edge)
		{
		}

		// Token: 0x0600325D RID: 12893 RVA: 0x001F9A84 File Offset: 0x001F7C84
		private static bool GetTopOrBottomEdge(BallCollision.TileEdges edgesToTest, int x, int y, Vector2 tilePosition, LineSegment edge)
		{
			if (!true)
			{
			}
			Tile tile;
			bool flag = BallCollision.IsNeighborSolid(tile);
			bool flag2;
			return flag2;
		}

		// Token: 0x0600325E RID: 12894 RVA: 0x001F9ABC File Offset: 0x001F7CBC
		private static bool GetLeftOrRightEdge(BallCollision.TileEdges edgesToTest, int x, int y, Vector2 tilePosition, LineSegment edge)
		{
			if (!true)
			{
			}
			Tile tile;
			bool flag = BallCollision.IsNeighborSolid(tile);
			Tile tile2;
			bool flag2 = BallCollision.IsNeighborSolid(tile2);
			bool flag3;
			return flag3;
		}

		// Token: 0x0600325F RID: 12895 RVA: 0x001F9AE8 File Offset: 0x001F7CE8
		private static Rectangle GetTileBounds(Vector2 position, Vector2 size)
		{
			/*
An exception occurred when decompiling this method (0600325F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Rectangle Terraria.Physics.BallCollision::GetTileBounds(Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Vector2)

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

		// Token: 0x06003260 RID: 12896 RVA: 0x001F9AF8 File Offset: 0x001F7CF8
		private static bool IsNeighborSolid(Tile tile)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0 || num == 0)
			{
				return;
			}
		}

		// Token: 0x06003261 RID: 12897 RVA: 0x001F9B14 File Offset: 0x001F7D14
		private static Vector2 ClosestPointOnLineSegment(Vector2 point, LineSegment lineSegment)
		{
			if (!true)
			{
			}
			Vector2 vector;
			float num = vector.LengthSquared();
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06003262 RID: 12898 RVA: 0x001F9B40 File Offset: 0x001F7D40
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_DEBUG")]
		private static void DrawEdge(LineSegment edge)
		{
		}

		// Token: 0x0200053D RID: 1341
		[Flags]
		private enum TileEdges : uint
		{
			// Token: 0x04003B85 RID: 15237
			None = 0U,
			// Token: 0x04003B86 RID: 15238
			Top = 1U,
			// Token: 0x04003B87 RID: 15239
			Bottom = 2U,
			// Token: 0x04003B88 RID: 15240
			Left = 4U,
			// Token: 0x04003B89 RID: 15241
			Right = 8U,
			// Token: 0x04003B8A RID: 15242
			TopLeftSlope = 16U,
			// Token: 0x04003B8B RID: 15243
			TopRightSlope = 32U,
			// Token: 0x04003B8C RID: 15244
			BottomLeftSlope = 64U,
			// Token: 0x04003B8D RID: 15245
			BottomRightSlope = 128U
		}
	}
}
