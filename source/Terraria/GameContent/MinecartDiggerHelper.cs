using System;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent
{
	// Token: 0x020007B0 RID: 1968
	public class MinecartDiggerHelper
	{
		// Token: 0x06004013 RID: 16403 RVA: 0x00242094 File Offset: 0x00240294
		public void TryDigging(Player player, Vector2 trackWorldPosition, int digDirectionX, int digDirectionY)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Point point;
			ushort type = Framing.GetTileSafely(point).type;
			if (num == 0)
			{
			}
			Item item;
			if (item != null)
			{
				this.ConsumeATrackItem(player);
				this.PlaceATrack(int.MinValue, 43134976);
				float x = player.velocity.X;
				player.velocity.X = x;
			}
		}

		// Token: 0x06004014 RID: 16404 RVA: 0x002420F8 File Offset: 0x002402F8
		private bool CanConsumeATrackItem(Player player)
		{
			/*
An exception occurred when decompiling this method (06004014)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.MinecartDiggerHelper::CanConsumeATrackItem(Terraria.Player)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Item(var_0_07, call:Item(MinecartDiggerHelper::FindMinecartTrackItem, ldloc:MinecartDiggerHelper(this), ldloc:Player(player)))
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

		// Token: 0x06004015 RID: 16405 RVA: 0x0024210C File Offset: 0x0024030C
		private void ConsumeATrackItem(Player player)
		{
			Item item = this.FindMinecartTrackItem(player);
			int stack = item.stack;
			item.stack = stack;
		}

		// Token: 0x06004016 RID: 16406 RVA: 0x0024213C File Offset: 0x0024033C
		private Item FindMinecartTrackItem(Player player)
		{
			/*
An exception occurred when decompiling this method (06004016)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Item Terraria.GameContent.MinecartDiggerHelper::FindMinecartTrackItem(Terraria.Player)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Player::selectedItem, ldloc:Player(player)))
	stloc:int32(var_2_0F, ldfld:int32(Player::itemAnimation, ldloc:Player(player)))
	stloc:int32(var_3_16, ldfld:int32(Player::reuseDelay, ldloc:Player(player)))
	stloc:int32(var_4_1D, ldfld:int32(Player::itemTime, ldloc:Player(player)))
	stloc:Vector2(var_5_2A, ldfld:Vector2(Entity::position, ldfld:class Terraria.Item[][exp:Entity](Player::inventory, ldloc:Player(player))))
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

		// Token: 0x06004017 RID: 16407 RVA: 0x00242178 File Offset: 0x00240378
		private void PoundTrack(Point spot)
		{
			if (!true)
			{
			}
			Tile tile;
			ushort type = tile.type;
			bool netClient = Main.NetClient;
		}

		// Token: 0x06004018 RID: 16408 RVA: 0x00242198 File Offset: 0x00240398
		private bool AlreadyLeadsIntoWantedTrack(Point tileCoordsOfFrontWheel, Point tileCoordsWeWantToReach)
		{
			Tile tileSafely = Framing.GetTileSafely(tileCoordsOfFrontWheel);
			bool flag = Framing.GetTileSafely(tileCoordsWeWantToReach).active();
			bool flag2;
			return flag2;
		}

		// Token: 0x06004019 RID: 16409 RVA: 0x002421C0 File Offset: 0x002403C0
		private static void GetExpectedDirections(Point startCoords, Point endCoords, [Out] int? expectedStartLeft, [Out] int? expectedStartRight, [Out] int? expectedEndLeft, [Out] int? expectedEndRight)
		{
			int num = 1;
			expectedStartLeft.hasValue = num != 0;
			expectedEndRight.hasValue = num != 0;
		}

		// Token: 0x0600401A RID: 16410 RVA: 0x002421F0 File Offset: 0x002403F0
		private bool DoTheTracksConnectProperly(Point tileCoordsOfFrontWheel, Point tileCoordsWeWantToReach)
		{
			return this.AlreadyLeadsIntoWantedTrack(tileCoordsOfFrontWheel, tileCoordsWeWantToReach);
		}

		// Token: 0x0600401B RID: 16411 RVA: 0x00242208 File Offset: 0x00240408
		private void CorrectTrackConnections(Point startCoords, Point endCoords)
		{
			if (!true)
			{
			}
			Tile tileSafely = Framing.GetTileSafely(startCoords);
			bool flag = Framing.GetTileSafely(endCoords).active();
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x0600401C RID: 16412 RVA: 0x00242234 File Offset: 0x00240434
		private bool HasPickPower(Player player, int x, int y)
		{
			return player.HasEnoughPickPowerToHurtTile(x, y);
		}

		// Token: 0x0600401D RID: 16413 RVA: 0x0024224C File Offset: 0x0024044C
		private bool CanGetPastTile(int x, int y)
		{
			/*
An exception occurred when decompiling this method (0600401D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.MinecartDiggerHelper::CanGetPastTile(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0035:
	stloc:bool(var_7_3C, call:bool(WorldGen::CanKillTile, ldloc:int32(x), ldloc:int32(y)))
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

		// Token: 0x0600401E RID: 16414 RVA: 0x0024229C File Offset: 0x0024049C
		private void PlaceATrack(int x, int y)
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
			long num = 0L;
			long num2 = 0L;
			long num3 = 0L;
			bool flag = WorldGen.PlaceTile(x, y, 314, num != 0L, num2 != 0L, myPlayer, (int)num3);
		}

		// Token: 0x0600401F RID: 16415 RVA: 0x002422D0 File Offset: 0x002404D0
		private void MineTheTileIfNecessary(int x, int y)
		{
			Tile tile;
			bool flag = tile.active();
			long num = 0L;
			long num2 = 0L;
			long num3 = 0L;
			WorldGen.KillTile(x, y, num != 0L, num2 != 0L, num3 != 0L);
		}

		// Token: 0x06004020 RID: 16416 RVA: 0x002422F8 File Offset: 0x002404F8
		public MinecartDiggerHelper()
		{
		}

		// Token: 0x06004021 RID: 16417 RVA: 0x0024230C File Offset: 0x0024050C
		// Note: this type is marked as 'beforefieldinit'.
		static MinecartDiggerHelper()
		{
		}

		// Token: 0x04007E00 RID: 32256
		public static MinecartDiggerHelper Instance;
	}
}
