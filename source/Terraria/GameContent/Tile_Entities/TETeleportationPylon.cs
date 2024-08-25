using System;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;
using Terraria.DataStructures;

namespace Terraria.GameContent.Tile_Entities
{
	// Token: 0x02000817 RID: 2071
	public class TETeleportationPylon : TileEntity
	{
		// Token: 0x06004267 RID: 16999 RVA: 0x0024B24C File Offset: 0x0024944C
		public override void RegisterTileEntityID(int assignedID)
		{
		}

		// Token: 0x06004268 RID: 17000 RVA: 0x0024B25C File Offset: 0x0024945C
		public TETeleportationPylon()
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x06004269 RID: 17001 RVA: 0x000021DB File Offset: 0x000003DB
		public override TileEntity GenerateInstance()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600426A RID: 17002 RVA: 0x0024B274 File Offset: 0x00249474
		public override void NetPlaceEntityAttempt(int x, int y)
		{
			if (!true)
			{
			}
			TETeleportationPylon.RejectPlacementFromNet(x, y);
		}

		// Token: 0x0600426B RID: 17003 RVA: 0x0024B294 File Offset: 0x00249494
		public bool TryGetPylonType([Out] TeleportPylonType pylonType)
		{
			bool flag;
			return flag;
		}

		// Token: 0x0600426C RID: 17004 RVA: 0x0024B2A4 File Offset: 0x002494A4
		private static void RejectPlacementFromNet(int x, int y)
		{
			long num = 0L;
			long num2 = 0L;
			long num3 = 0L;
			WorldGen.KillTile(x, y, num != 0L, num2 != 0L, num3 != 0L);
			bool netHost = Main.NetHost;
		}

		// Token: 0x0600426D RID: 17005 RVA: 0x0024B2CC File Offset: 0x002494CC
		public static int Place(int x, int y)
		{
			if (!true)
			{
			}
			int num = TileEntity.AssignNewID();
			Monitor.Enter(x, x != 0);
			long num2 = 0L;
			Monitor.Exit(x);
			if (num2 == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600426E RID: 17006 RVA: 0x0024B308 File Offset: 0x00249508
		public static void Kill(int x, int y)
		{
			if (!true)
			{
			}
			int key = TileEntity.GetKey(x, y);
			int key2 = TileEntity.GetKey(x, y);
			if (!false)
			{
				if (3 == 0)
				{
				}
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600426F RID: 17007 RVA: 0x0024B348 File Offset: 0x00249548
		public override string ToString()
		{
			Point16 position = this.Position;
			short y = this.Position.Y;
			string text;
			string text2;
			return text + "x  " + text2 + "y";
		}

		// Token: 0x06004270 RID: 17008 RVA: 0x0024B37C File Offset: 0x0024957C
		public static void Framing_CheckTile(int callX, int callY)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				short frameX = Framing.GetTileSafely(callX, callY).frameX;
				long num2 = 2147483644L;
				if (num2 == 0L)
				{
				}
				Tile tile;
				bool flag = tile.active();
				if (num2 == 0L)
				{
				}
				bool flag2 = WorldGen.SolidTileAllowBottomSlope(callX, callX);
				if (num2 == 0L)
				{
				}
				bool flag3 = WorldGen.SolidTileAllowBottomSlope(0, callX);
				if (num2 == 0L)
				{
				}
				bool flag4 = WorldGen.SolidTileAllowBottomSlope(0, callX);
				TETeleportationPylon.Kill(callX, callY);
				return;
			}
		}

		// Token: 0x06004271 RID: 17009 RVA: 0x000021DB File Offset: 0x000003DB
		public static int GetPylonStyleFromTile(Tile tile)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004272 RID: 17010 RVA: 0x0024B444 File Offset: 0x00249644
		public static int GetPylonItemTypeFromTileStyle(int style)
		{
			return 4876;
		}

		// Token: 0x06004273 RID: 17011 RVA: 0x0024B458 File Offset: 0x00249658
		public override bool IsTileValidForEntity(int x, int y)
		{
			/*
An exception occurred when decompiling this method (06004273)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Tile_Entities.TETeleportationPylon::IsTileValidForEntity(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0029:
	stloc:int16(var_9_30, callgetter:int16(Tile::get_frameX, ldloc:Tile[exp:valuetype Terraria.Tile&](var_8)))
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

		// Token: 0x06004274 RID: 17012 RVA: 0x0024B498 File Offset: 0x00249698
		public static int PlacementPreviewHook_AfterPlacement(int x, int y, int type = 597, int style = 0, int direction = 1, int alternate = 0)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool netClientOnly = Main.NetClientOnly;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			return 87;
		}

		// Token: 0x06004275 RID: 17013 RVA: 0x0024B4E0 File Offset: 0x002496E0
		public static int PlacementPreviewHook_CheckIfCanPlace(int x, int y, int type = 597, int style = 0, int direction = 1, int alternate = 0)
		{
			/*
An exception occurred when decompiling this method (06004275)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.GameContent.Tile_Entities.TETeleportationPylon::PlacementPreviewHook_CheckIfCanPlace(System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32)

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

		// Token: 0x06004276 RID: 17014 RVA: 0x0024B4F0 File Offset: 0x002496F0
		private bool TryGetPylonTypeFromTileCoords(int x, int y, [Out] TeleportPylonType pylonType)
		{
			/*
An exception occurred when decompiling this method (06004276)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Tile_Entities.TETeleportationPylon::TryGetPylonTypeFromTileCoords(System.Int32,System.Int32,Terraria.GameContent.TeleportPylonType)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0005:
	stloc:bool(var_2_0B, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_1)))
	stfld:uint8(TeleportPylonType::value__, ldloc:TeleportPylonType[exp:valuetype Terraria.GameContent.TeleportPylonType&](pylonType), ldloc:int32[exp:uint8](var_0_01))
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

		// Token: 0x06004277 RID: 17015 RVA: 0x000021DB File Offset: 0x000003DB
		private static TeleportPylonType GetPylonTypeFromPylonTileStyle(int pylonStyle)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004278 RID: 17016 RVA: 0x0024B518 File Offset: 0x00249718
		public static int Find(int x, int y)
		{
			if (!true)
			{
			}
			int key = TileEntity.GetKey(int.MinValue, x);
			return int.MinValue;
		}

		// Token: 0x040080E4 RID: 32996
		private static byte _myEntityID;

		// Token: 0x040080E5 RID: 32997
		private const int MyTileID = 597;

		// Token: 0x040080E6 RID: 32998
		private const int entityTileWidth = 3;

		// Token: 0x040080E7 RID: 32999
		private const int entityTileHeight = 4;
	}
}
