using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;
using Terraria.GameContent.UI;
using Terraria.GameInput;

namespace Terraria.GameContent
{
	// Token: 0x020007EF RID: 2031
	public class SmartCursorHelper
	{
		// Token: 0x06004141 RID: 16705 RVA: 0x002451AC File Offset: 0x002433AC
		public static void SmartCursorLookup(Player player)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Main.SmartCursorShowing = false;
			bool smartCursorIsUsed = Main.SmartCursorIsUsed;
			if (num == 0)
			{
			}
			if (player.inventory.position == null)
			{
			}
			Vector2 mouseWorld = Main.MouseWorld;
			Vector2 position = player.position;
			Vector2 center = player.Center;
			int tileTargetX = Player.tileTargetX;
			int tileTargetY = Player.tileTargetY;
			int tileRangeX = Player.tileRangeX;
			int tileRangeY = Player.tileRangeY;
			float x = player.position.X;
			int num2 = 32640;
			int width = player.width;
			float y = player.position.Y;
			int height = player.height;
			if (num2 == 0)
			{
			}
			if (num2 == 0)
			{
			}
			int grapCount = player.grapCount;
			if (player.grappling == null)
			{
			}
		}

		// Token: 0x06004142 RID: 16706 RVA: 0x002452A8 File Offset: 0x002434A8
		private static void TryFindingPaintInplayerInventory(SmartCursorHelper.SmartCursorUsageInfo providedInfo, [Out] int paintLookup, [Out] int coatingLookup)
		{
			int type = providedInfo.item.type;
			Item item = providedInfo.player.FindPaintOrCoating();
			if (item != null)
			{
				byte paintCoating = item.paintCoating;
				coatingLookup.m_value = (int)paintCoating;
				byte paint = item.paint;
				paintLookup.m_value = (int)paint;
			}
		}

		// Token: 0x06004143 RID: 16707 RVA: 0x002452EC File Offset: 0x002434EC
		private static bool IsHoveringOverAnInteractibleTileThatBlocksSmartCursor(SmartCursorHelper.SmartCursorUsageInfo providedInfo)
		{
			/*
An exception occurred when decompiling this method (06004143)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.SmartCursorHelper::IsHoveringOverAnInteractibleTileThatBlocksSmartCursor(Terraria.GameContent.SmartCursorHelper/SmartCursorUsageInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_1_06, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_0)))
	stloc:uint16(var_3_0D, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_2)))
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

		// Token: 0x06004144 RID: 16708 RVA: 0x0024530C File Offset: 0x0024350C
		private static void Step_StaffOfRegrowth(SmartCursorHelper.SmartCursorUsageInfo providedInfo, int focusedX, int focusedY)
		{
			Item item = providedInfo.item;
			int type = item.type;
			int reachableStartX = providedInfo.reachableStartX;
			int reachableStartY = providedInfo.reachableStartY;
			int reachableEndY = providedInfo.reachableEndY;
			int reachableStartY2 = providedInfo.reachableStartY;
		}

		// Token: 0x06004145 RID: 16709 RVA: 0x00245430 File Offset: 0x00243630
		private static void Step_GrassSeeds(SmartCursorHelper.SmartCursorUsageInfo providedInfo, int focusedX, int focusedY)
		{
		}

		// Token: 0x06004146 RID: 16710 RVA: 0x002454BC File Offset: 0x002436BC
		private static void Step_ClayPots(SmartCursorHelper.SmartCursorUsageInfo providedInfo, int focusedX, int focusedY)
		{
			int createTile = providedInfo.item.createTile;
			int screenTargetX = providedInfo.screenTargetX;
			int reachableStartX = providedInfo.reachableStartX;
			Tile tile;
			bool flag = tile.active();
			int screenTargetX2 = providedInfo.screenTargetX;
			int reachableStartX2 = providedInfo.reachableStartX;
			int reachableStartX3 = providedInfo.reachableStartX;
			int reachableStartY = providedInfo.reachableStartY;
			int reachableStartY2 = providedInfo.reachableStartY;
			int paintLookup = providedInfo.paintLookup;
			bool flag2 = Collision.InTileBounds(screenTargetX2, reachableStartX2, reachableStartX3, reachableStartY2, reachableStartY, paintLookup);
			int reachableStartX4 = providedInfo.reachableStartX;
			int reachableStartY3 = providedInfo.reachableStartY;
			int reachableEndY = providedInfo.reachableEndY;
			int reachableStartY4 = providedInfo.reachableStartY;
			if (reachableStartY3 == 0)
			{
			}
			Tile tile2;
			bool flag3 = tile2.active();
			int reachableEndY2 = providedInfo.reachableEndY;
		}

		// Token: 0x06004147 RID: 16711 RVA: 0x002455EC File Offset: 0x002437EC
		private static void Step_PlanterBox(SmartCursorHelper.SmartCursorUsageInfo providedInfo, int focusedX, int focusedY)
		{
			int createTile = providedInfo.item.createTile;
			int screenTargetX = providedInfo.screenTargetX;
			int reachableStartX = providedInfo.reachableStartX;
			Tile tile;
			bool flag = tile.active();
			int screenTargetX2 = providedInfo.screenTargetX;
			int reachableStartX2 = providedInfo.reachableStartX;
			Tile tile2;
			ushort type = tile2.type;
			int reachableStartX3 = providedInfo.reachableStartX;
			int reachableStartY = providedInfo.reachableStartY;
			int reachableEndY = providedInfo.reachableEndY;
			int reachableStartY2 = providedInfo.reachableStartY;
		}

		// Token: 0x06004148 RID: 16712 RVA: 0x00245744 File Offset: 0x00243944
		private static void Step_AlchemySeeds(SmartCursorHelper.SmartCursorUsageInfo providedInfo, int focusedX, int focusedY)
		{
			Item item = providedInfo.item;
			int createTile = item.createTile;
			int placeStyle = item.placeStyle;
			long entityId = item.entityId;
			int reachableStartX = providedInfo.reachableStartX;
			int reachableStartY = providedInfo.reachableStartY;
			int reachableEndY = providedInfo.reachableEndY;
			int reachableStartY2 = providedInfo.reachableStartY;
			if (reachableStartY == 0)
			{
			}
			Tile tile;
			bool flag = tile.active();
			if (true)
			{
				return;
			}
			int reachableEndY2 = providedInfo.reachableEndY;
			if (providedInfo.reachableEndX == 0)
			{
			}
			if (reachableEndY2 == 0)
			{
			}
			if (reachableEndY2 == 0)
			{
			}
			float x = providedInfo.mouse.X;
			float y = providedInfo.mouse.Y;
		}

		// Token: 0x06004149 RID: 16713 RVA: 0x00245838 File Offset: 0x00243A38
		private static void Step_Actuators(SmartCursorHelper.SmartCursorUsageInfo providedInfo, int focusedX, int focusedY)
		{
			int type = providedInfo.item.type;
			int reachableStartX = providedInfo.reachableStartX;
			int reachableStartY = providedInfo.reachableStartY;
			int reachableEndY = providedInfo.reachableEndY;
			int reachableStartY2 = providedInfo.reachableStartY;
			if (reachableStartY == 0)
			{
			}
			Tile tile;
			bool flag = tile.wire();
			if (reachableStartY == 0)
			{
			}
		}

		// Token: 0x0600414A RID: 16714 RVA: 0x002458F8 File Offset: 0x00243AF8
		private static void Step_EmptyBuckets(SmartCursorHelper.SmartCursorUsageInfo providedInfo, int focusedX, int focusedY)
		{
			int type = providedInfo.item.type;
			int reachableStartX = providedInfo.reachableStartX;
			int reachableEndX = providedInfo.reachableEndX;
			int reachableEndY = providedInfo.reachableEndY;
			int reachableStartY = providedInfo.reachableStartY;
		}

		// Token: 0x0600414B RID: 16715 RVA: 0x002459D8 File Offset: 0x00243BD8
		private static void Step_PaintScrapper(SmartCursorHelper.SmartCursorUsageInfo providedInfo, int focusedX, int focusedY)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Item item = providedInfo.item;
			if (num != 0)
			{
				int reachableStartX = providedInfo.reachableStartX;
				int reachableStartY = providedInfo.reachableStartY;
				int reachableEndY = providedInfo.reachableEndY;
				int reachableStartY2 = providedInfo.reachableStartY;
				if (reachableStartY == 0)
				{
				}
				Tile tile;
				bool flag = tile.active();
				return;
			}
		}

		// Token: 0x0600414C RID: 16716 RVA: 0x00245AA0 File Offset: 0x00243CA0
		private static void Step_PaintBrush(SmartCursorHelper.SmartCursorUsageInfo providedInfo, int focusedX, int focusedY)
		{
			int type = providedInfo.item.type;
			if (providedInfo.paintLookup == 0 && providedInfo.paintCoatingLookup == 0)
			{
				return;
			}
			int paintLookup = providedInfo.paintLookup;
			int reachableStartX = providedInfo.reachableStartX;
			int reachableStartY = providedInfo.reachableStartY;
			int reachableEndY = providedInfo.reachableEndY;
			int reachableStartY2 = providedInfo.reachableStartY;
			if (reachableStartY == 0)
			{
			}
			Tile tile;
			bool flag = tile.active();
			if (paintLookup != 0)
			{
				return;
			}
		}

		// Token: 0x0600414D RID: 16717 RVA: 0x00245B8C File Offset: 0x00243D8C
		private static void Step_PaintRoller(SmartCursorHelper.SmartCursorUsageInfo providedInfo, int focusedX, int focusedY)
		{
			int type = providedInfo.item.type;
			if (providedInfo.paintLookup == 0 && providedInfo.paintCoatingLookup == 0)
			{
				return;
			}
			int reachableStartX = providedInfo.reachableStartX;
			int reachableStartY = providedInfo.reachableStartY;
			int reachableEndY = providedInfo.reachableEndY;
			int paintCoatingLookup = providedInfo.paintCoatingLookup;
			int paintCoatingLookup2 = providedInfo.paintCoatingLookup;
			int reachableStartY2 = providedInfo.reachableStartY;
			if (reachableStartY == 0)
			{
			}
			Tile tile;
			ushort wall = tile.wall;
			if (reachableStartY == 0)
			{
			}
			if (reachableStartY != 0)
			{
				if (reachableStartY == 0)
				{
				}
				if (reachableStartY == 0)
				{
					int reachableEndY2 = providedInfo.reachableEndY;
					int reachableEndX = providedInfo.reachableEndX;
					if (reachableEndY2 == 0)
					{
					}
					if (reachableEndY2 == 0)
					{
					}
					float x = providedInfo.mouse.X;
					float y = providedInfo.mouse.Y;
					return;
				}
			}
			if (paintCoatingLookup != 0)
			{
				return;
			}
		}

		// Token: 0x0600414E RID: 16718 RVA: 0x00245C88 File Offset: 0x00243E88
		private static void Step_BlocksLines(SmartCursorHelper.SmartCursorUsageInfo providedInfo, int focusedX, int focusedY)
		{
			Item item = providedInfo.item;
			bool smartBlocksEnabled = Player.SmartCursorSettings.SmartBlocksEnabled;
			int createTile = providedInfo.item.createTile;
			int num = 5295;
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
			Item item2 = providedInfo.item;
			Item item3 = providedInfo.item;
			Item item4 = providedInfo.item;
			int screenTargetX = providedInfo.screenTargetX;
			int reachableStartX = providedInfo.reachableStartX;
			Tile tile;
			bool flag = tile.active();
			int screenTargetX2 = providedInfo.screenTargetX;
			int reachableStartX2 = providedInfo.reachableStartX;
			int reachableStartX3 = providedInfo.reachableStartX;
			int reachableStartY = providedInfo.reachableStartY;
			int reachableStartY2 = providedInfo.reachableStartY;
			int paintLookup = providedInfo.paintLookup;
			if (item4 == null)
			{
			}
			bool flag2 = Collision.InTileBounds(screenTargetX2, reachableStartX2, reachableStartX3, reachableStartY2, reachableStartY, paintLookup);
			int reachableStartX4 = providedInfo.reachableStartX;
			int reachableStartY3 = providedInfo.reachableStartY;
			int reachableEndY = providedInfo.reachableEndY;
			int reachableStartY4 = providedInfo.reachableStartY;
		}

		// Token: 0x0600414F RID: 16719 RVA: 0x00245EC8 File Offset: 0x002440C8
		private static void Step_Boulders(SmartCursorHelper.SmartCursorUsageInfo providedInfo, int focusedX, int focusedY)
		{
			if (true)
			{
				Tile tile;
				bool flag = tile.nactive();
				return;
			}
		}

		// Token: 0x06004150 RID: 16720 RVA: 0x00245F34 File Offset: 0x00244134
		private static void Step_Pigronata(SmartCursorHelper.SmartCursorUsageInfo providedInfo, int focusedX, int focusedY)
		{
			int createTile = providedInfo.item.createTile;
			int reachableStartX = providedInfo.reachableStartX;
			int reachableStartY = providedInfo.reachableStartY;
			int reachableStartY2 = providedInfo.reachableStartY;
			int paintLookup = providedInfo.paintLookup;
		}

		// Token: 0x06004151 RID: 16721 RVA: 0x00246008 File Offset: 0x00244208
		private static void Step_PumpkinSeeds(SmartCursorHelper.SmartCursorUsageInfo providedInfo, int focusedX, int focusedY)
		{
			int createTile = providedInfo.item.createTile;
			Tile tile;
			bool flag = tile.active();
		}

		// Token: 0x06004152 RID: 16722 RVA: 0x00246070 File Offset: 0x00244270
		private static void Step_WallsCell(int x, int y, int cx, int cy, int minX, int minY, int maxX, int maxY)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Tile tile;
			ushort wall = tile.wall;
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
					return;
				}
			}
			bool flag = DelegateMethods.NotDoorStand(x, y);
		}

		// Token: 0x06004153 RID: 16723 RVA: 0x00246188 File Offset: 0x00244388
		private static void Step_Walls(SmartCursorHelper.SmartCursorUsageInfo providedInfo, int focusedX, int focusedY)
		{
			int createWall = providedInfo.item.createWall;
			Player player = providedInfo.player;
			int width = player.width;
			bool wet = player.wet;
			long entityId = player.entityId;
			int num = 15744;
			float x = providedInfo.position.X;
			float y = providedInfo.position.Y;
			int num2 = 32640;
			int reachableStartX = providedInfo.reachableStartX;
			int reachableEndX = providedInfo.reachableEndX;
			int reachableStartY = providedInfo.reachableStartY;
			int paintLookup = providedInfo.paintLookup;
			if (num == 0)
			{
			}
			if (num2 == 0)
			{
			}
			if (num2 == 0)
			{
			}
			float x2 = providedInfo.mouse.X;
			float y2 = providedInfo.mouse.Y;
		}

		// Token: 0x06004154 RID: 16724 RVA: 0x00246270 File Offset: 0x00244470
		private static void Step_MinecartTracks(SmartCursorHelper.SmartCursorUsageInfo providedInfo, int focusedX, int focusedY)
		{
			int type = providedInfo.item.type;
			Vector2 mouseWorld = Main.MouseWorld;
			float x = providedInfo.Center.X;
			float y = providedInfo.Center.Y;
			if (!true)
			{
			}
			if (!true)
			{
			}
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int screenTargetX = providedInfo.screenTargetX;
			int reachableStartX = providedInfo.reachableStartX;
			Tile tile;
			bool flag = tile.active();
			if (num == 0)
			{
			}
			int screenTargetX2 = providedInfo.screenTargetX;
			int reachableStartX2 = providedInfo.reachableStartX;
			Tile tile2;
			ushort type2 = tile2.type;
			int reachableStartX3 = providedInfo.reachableStartX;
			int reachableStartY = providedInfo.reachableStartY;
			int reachableEndY = providedInfo.reachableEndY;
			int reachableStartY2 = providedInfo.reachableStartY;
			if (reachableStartY == 0)
			{
			}
			Tile tile3;
			bool flag2 = tile3.active();
			if (reachableStartY == 0)
			{
			}
			Tile tile4;
			bool flag3 = tile4.active();
			if (reachableStartY == 0)
			{
			}
			Tile tile5;
			ushort type3 = tile5.type;
		}

		// Token: 0x06004155 RID: 16725 RVA: 0x002466A4 File Offset: 0x002448A4
		private static void Step_Platforms(SmartCursorHelper.SmartCursorUsageInfo providedInfo, int focusedX, int focusedY)
		{
			int createTile = providedInfo.item.createTile;
			if (providedInfo.item.createTile != 0)
			{
				int screenTargetX = providedInfo.screenTargetX;
				int reachableStartX = providedInfo.reachableStartX;
				Tile tile;
				bool flag = tile.active();
				int screenTargetX2 = providedInfo.screenTargetX;
				int reachableStartX2 = providedInfo.reachableStartX;
				Tile tile2;
				ushort type = tile2.type;
				int reachableStartX3 = providedInfo.reachableStartX;
				int reachableStartY = providedInfo.reachableStartY;
				int reachableEndY = providedInfo.reachableEndY;
				int reachableStartY2 = providedInfo.reachableStartY;
				return;
			}
		}

		// Token: 0x06004156 RID: 16726 RVA: 0x00246824 File Offset: 0x00244A24
		private static void Step_WireCutter(SmartCursorHelper.SmartCursorUsageInfo providedInfo, int focusedX, int focusedY)
		{
			Item item = providedInfo.item;
			int reachableStartX = providedInfo.reachableStartX;
			int reachableStartY = providedInfo.reachableStartY;
			int reachableEndY = providedInfo.reachableEndY;
			int reachableStartY2 = providedInfo.reachableStartY;
			if (reachableStartY == 0)
			{
			}
			Tile tile;
			bool flag = tile.wire();
			if (reachableStartY == 0)
			{
			}
		}

		// Token: 0x06004157 RID: 16727 RVA: 0x002468DC File Offset: 0x00244ADC
		private static void Step_ActuationRod(SmartCursorHelper.SmartCursorUsageInfo providedInfo, int focusedX, int focusedY)
		{
			int type = providedInfo.item.type;
			Player player = providedInfo.player;
			bool actuationRodLock = player.ActuationRodLock;
			bool actuationRodLockSetting = player.ActuationRodLockSetting;
			long entityId = player.entityId;
			int reachableStartX = providedInfo.reachableStartX;
			int reachableStartY = providedInfo.reachableStartY;
			int reachableEndY = providedInfo.reachableEndY;
			int reachableStartY2 = providedInfo.reachableStartY;
			if (reachableStartY == 0)
			{
			}
			Tile tile;
			bool flag = tile.active();
			if (actuationRodLock)
			{
			}
			if (reachableStartY == 0)
			{
			}
		}

		// Token: 0x06004158 RID: 16728 RVA: 0x002469C0 File Offset: 0x00244BC0
		private static void Step_Hammers(SmartCursorHelper.SmartCursorUsageInfo providedInfo, int focusedX, int focusedY)
		{
			Player player = providedInfo.player;
			int width = player.width;
			int height = player.height;
			int hammer = providedInfo.item.hammer;
		}

		// Token: 0x06004159 RID: 16729 RVA: 0x00246D44 File Offset: 0x00244F44
		private static void Step_MulticolorWrench(SmartCursorHelper.SmartCursorUsageInfo providedInfo, int focusedX, int focusedY)
		{
			int type = providedInfo.item.type;
			WiresUI.Settings.MultiToolMode toolMode = WiresUI.Settings.ToolMode;
			int screenTargetX = providedInfo.screenTargetX;
			int reachableStartX = providedInfo.reachableStartX;
			Tile tile;
			bool flag = tile.wire();
			int screenTargetX2 = providedInfo.screenTargetX;
			int reachableStartX2 = providedInfo.reachableStartX;
			Tile tile2;
			bool flag2 = tile2.wire2();
			int screenTargetX3 = providedInfo.screenTargetX;
			int reachableStartX3 = providedInfo.reachableStartX;
			Tile tile3;
			bool flag3 = tile3.wire3();
			int screenTargetX4 = providedInfo.screenTargetX;
			int reachableStartX4 = providedInfo.reachableStartX;
			Tile tile4;
			bool flag4 = tile4.wire4();
			WiresUI.Settings.MultiToolMode toolMode2 = WiresUI.Settings.ToolMode;
			int reachableStartX5 = providedInfo.reachableStartX;
			int reachableStartY = providedInfo.reachableStartY;
			int reachableEndY = providedInfo.reachableEndY;
			int reachableStartY2 = providedInfo.reachableStartY;
		}

		// Token: 0x0600415A RID: 16730 RVA: 0x00246F20 File Offset: 0x00245120
		private static void Step_ColoredWrenches(SmartCursorHelper.SmartCursorUsageInfo providedInfo, int focusedX, int focusedY)
		{
			int type = providedInfo.item.type;
			int type2 = providedInfo.item.type;
			int num = 4;
			int screenTargetX = providedInfo.screenTargetX;
			int reachableStartX = providedInfo.reachableStartX;
			Tile tile;
			bool flag = tile.wire();
			if (num == 0)
			{
			}
			int screenTargetX2 = providedInfo.screenTargetX;
			int reachableStartX2 = providedInfo.reachableStartX;
			Tile tile2;
			bool flag2 = tile2.wire2();
			if (num == 0)
			{
			}
			int screenTargetX3 = providedInfo.screenTargetX;
			int reachableStartX3 = providedInfo.reachableStartX;
			Tile tile3;
			bool flag3 = tile3.wire3();
			if (num == 0)
			{
			}
			int screenTargetX4 = providedInfo.screenTargetX;
			int reachableStartX4 = providedInfo.reachableStartX;
			Tile tile4;
			bool flag4 = tile4.wire4();
			int reachableStartX5 = providedInfo.reachableStartX;
			int reachableStartY = providedInfo.reachableStartY;
			int reachableEndY = providedInfo.reachableEndY;
			int reachableStartY2 = providedInfo.reachableStartY;
		}

		// Token: 0x0600415B RID: 16731 RVA: 0x00247110 File Offset: 0x00245310
		private static void Step_Acorns(SmartCursorHelper.SmartCursorUsageInfo providedInfo, int focusedX, int focusedY)
		{
		}

		// Token: 0x0600415C RID: 16732 RVA: 0x002471A4 File Offset: 0x002453A4
		private static void Step_GemCorns(SmartCursorHelper.SmartCursorUsageInfo providedInfo, int focusedX, int focusedY)
		{
		}

		// Token: 0x0600415D RID: 16733 RVA: 0x00247208 File Offset: 0x00245408
		private static void Step_ForceCursorToAnyMinableThing(SmartCursorHelper.SmartCursorUsageInfo providedInfo, int fX, int fY)
		{
			int reachableStartX = providedInfo.reachableStartX;
			int reachableStartY = providedInfo.reachableStartY;
			int reachableStartY2 = providedInfo.reachableStartY;
			int paintLookup = providedInfo.paintLookup;
			float x = providedInfo.mouse.X;
			float y = providedInfo.mouse.Y;
			Item item = providedInfo.item;
			Tile tile;
			bool flag = tile.active();
			int axe = item.axe;
			if (axe == 0)
			{
			}
			int hammer;
			if (axe != 0)
			{
				hammer = item.hammer;
			}
			if (hammer == 0)
			{
			}
			if (hammer == 0)
			{
				if (hammer == 0)
				{
				}
				if (hammer == 0)
				{
					int pick = item.pick;
				}
			}
			Point point;
			fX.m_value = point;
		}

		// Token: 0x0600415E RID: 16734 RVA: 0x0024729C File Offset: 0x0024549C
		private static void Step_Pickaxe_MineShinies(SmartCursorHelper.SmartCursorUsageInfo providedInfo, int fX, int fY)
		{
			int pick = providedInfo.item.pick;
			int reachableStartX = providedInfo.reachableStartX;
			int reachableStartY = providedInfo.reachableStartY;
			int reachableStartY2 = providedInfo.reachableStartY;
			int paintLookup = providedInfo.paintLookup;
			float x = providedInfo.mouse.X;
			float y = providedInfo.mouse.Y;
			if (reachableStartY2 == 0)
			{
			}
		}

		// Token: 0x0600415F RID: 16735 RVA: 0x00247304 File Offset: 0x00245504
		private static void Step_Pickaxe_MineSolids(Player player, SmartCursorHelper.SmartCursorUsageInfo providedInfo, List<int> grappleTargets, int focusedX, int focusedY)
		{
			int num = 1;
			int direction = player.direction;
			int height = player.height;
			int height2 = player.height;
			Vector2 center = player.Center;
			float x = player.position.X;
			float y = player.position.Y;
			float gravDir = player.gravDir;
			int whoAmI = player.whoAmI;
			if (num == 0)
			{
			}
			int pick = providedInfo.item.pick;
			bool usingGamepad = PlayerInput.UsingGamepad;
			Vector2 navigatorDirections = PlayerInput.Triggers.Current.GetNavigatorDirections();
			int num2 = 1;
			if (num2 == 0)
			{
			}
			int value = num2.m_value;
			float x2 = providedInfo.mouse.X;
			float y2 = providedInfo.mouse.Y;
			float num4;
			int num3 = Math.Sign(num4);
			int num5 = Math.Sign(num4);
		}

		// Token: 0x06004160 RID: 16736 RVA: 0x0024750C File Offset: 0x0024570C
		private static void Step_Axe(SmartCursorHelper.SmartCursorUsageInfo providedInfo, int fX, int fY)
		{
		}

		// Token: 0x06004161 RID: 16737 RVA: 0x00247538 File Offset: 0x00245738
		private static void Step_BlocksFilling(SmartCursorHelper.SmartCursorUsageInfo providedInfo, int fX, int fY)
		{
			bool smartBlocksEnabled = Player.SmartCursorSettings.SmartBlocksEnabled;
			Item item = providedInfo.item;
			int reachableStartX = providedInfo.reachableStartX;
			int reachableStartY = providedInfo.reachableStartY;
			int reachableStartY2 = providedInfo.reachableStartY;
			int paintLookup = providedInfo.paintLookup;
			int screenTargetX = providedInfo.screenTargetX;
			int reachableStartX2 = providedInfo.reachableStartX;
			bool smartBlocksEnabled2 = Player.SmartCursorSettings.SmartBlocksEnabled;
			int createTile = providedInfo.item.createTile;
			int num = 5295;
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
			Item item2 = providedInfo.item;
			Item item3 = providedInfo.item;
			Item item4 = providedInfo.item;
			Tile tile;
			bool flag = tile.active();
			if (item4 == null)
			{
			}
			bool flag2 = Collision.InTileBounds(screenTargetX, reachableStartX2, screenTargetX, reachableStartY2, reachableStartX2, paintLookup);
		}

		// Token: 0x06004162 RID: 16738 RVA: 0x002476BC File Offset: 0x002458BC
		private static void UpdateTorchLocations(int LX, int LY, int HX, int HY)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Tile tile;
			ushort type = tile.type;
			if (num == 0)
			{
			}
		}

		// Token: 0x06004163 RID: 16739 RVA: 0x002476E0 File Offset: 0x002458E0
		private static bool IsNearExistingTorch(int x, int y)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06004164 RID: 16740 RVA: 0x002476F8 File Offset: 0x002458F8
		private static void Step_Torch(SmartCursorHelper.SmartCursorUsageInfo providedInfo, int fX, int fY)
		{
			int createTile = providedInfo.item.createTile;
			int reachableStartX = providedInfo.reachableStartX;
			int reachableStartY = providedInfo.reachableStartY;
			int reachableStartY2 = providedInfo.reachableStartY;
			int paintLookup = providedInfo.paintLookup;
			SmartCursorHelper.UpdateTorchLocations(reachableStartX, reachableStartY2, reachableStartY, paintLookup);
			int type = providedInfo.item.type;
		}

		// Token: 0x06004165 RID: 16741 RVA: 0x00247868 File Offset: 0x00245A68
		private static void Step_LawnMower(SmartCursorHelper.SmartCursorUsageInfo providedInfo, int fX, int fY)
		{
			int type = providedInfo.item.type;
			int reachableStartX = providedInfo.reachableStartX;
			int reachableStartY = providedInfo.reachableStartY;
			int reachableStartY2 = providedInfo.reachableStartY;
			int paintLookup = providedInfo.paintLookup;
			if (reachableStartY == 0)
			{
			}
			if (reachableStartY == 0)
			{
			}
			Tile tile;
			bool flag = tile.active();
			if (reachableStartY == 0)
			{
			}
		}

		// Token: 0x06004166 RID: 16742 RVA: 0x002478E8 File Offset: 0x00245AE8
		public SmartCursorHelper()
		{
		}

		// Token: 0x06004167 RID: 16743 RVA: 0x002478FC File Offset: 0x00245AFC
		// Note: this type is marked as 'beforefieldinit'.
		static SmartCursorHelper()
		{
		}

		// Token: 0x04007EEC RID: 32492
		private static List<int> _targetsInt;

		// Token: 0x04007EED RID: 32493
		private static List<int> _points;

		// Token: 0x04007EEE RID: 32494
		private static List<int> _endpoints;

		// Token: 0x04007EEF RID: 32495
		private static List<Tuple<int, int>> _targets;

		// Token: 0x04007EF0 RID: 32496
		private static List<int> _grappleTargets;

		// Token: 0x04007EF1 RID: 32497
		private static List<Tuple<int, int>> _toRemove;

		// Token: 0x04007EF2 RID: 32498
		private static List<Tuple<int, int>> _targets2;

		// Token: 0x04007EF3 RID: 32499
		private static SmartCursorHelper.SmartCursorUsageInfo providedInfo;

		// Token: 0x04007EF4 RID: 32500
		private static List<int> _torchPositions;

		// Token: 0x04007EF5 RID: 32501
		private const int rangeToAvoidOtherTorches = 8;

		// Token: 0x020007F0 RID: 2032
		private class SmartCursorUsageInfo
		{
			// Token: 0x06004168 RID: 16744 RVA: 0x0024790C File Offset: 0x00245B0C
			public SmartCursorUsageInfo()
			{
			}

			// Token: 0x04007EF6 RID: 32502
			public Player player;

			// Token: 0x04007EF7 RID: 32503
			public Item item;

			// Token: 0x04007EF8 RID: 32504
			public Vector2 mouse;

			// Token: 0x04007EF9 RID: 32505
			public Vector2 position;

			// Token: 0x04007EFA RID: 32506
			public Vector2 Center;

			// Token: 0x04007EFB RID: 32507
			public int screenTargetX;

			// Token: 0x04007EFC RID: 32508
			public int screenTargetY;

			// Token: 0x04007EFD RID: 32509
			public int reachableStartX;

			// Token: 0x04007EFE RID: 32510
			public int reachableEndX;

			// Token: 0x04007EFF RID: 32511
			public int reachableStartY;

			// Token: 0x04007F00 RID: 32512
			public int reachableEndY;

			// Token: 0x04007F01 RID: 32513
			public int paintLookup;

			// Token: 0x04007F02 RID: 32514
			public int paintCoatingLookup;
		}
	}
}
