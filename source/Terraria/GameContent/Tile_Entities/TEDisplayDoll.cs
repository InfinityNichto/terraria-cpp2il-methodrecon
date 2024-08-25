using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.Graphics;
using Terraria.UI;

namespace Terraria.GameContent.Tile_Entities
{
	// Token: 0x0200080F RID: 2063
	public class TEDisplayDoll : TileEntity, IFixLoadedData
	{
		// Token: 0x060041EC RID: 16876 RVA: 0x002490F4 File Offset: 0x002472F4
		public TEDisplayDoll()
		{
			if (!true)
			{
			}
			base..ctor();
			Item[] items = this._items;
			Item[] dyes = this._dyes;
			if (15 == 0)
			{
			}
			int num = 10;
			this._dollPlayer.skinVariant = num;
		}

		// Token: 0x060041ED RID: 16877 RVA: 0x00249140 File Offset: 0x00247340
		public override void RegisterTileEntityID(int assignedID)
		{
			if (!true)
			{
			}
		}

		// Token: 0x060041EE RID: 16878 RVA: 0x000021DB File Offset: 0x000003DB
		public override TileEntity GenerateInstance()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060041EF RID: 16879 RVA: 0x00249150 File Offset: 0x00247350
		public override void NetPlaceEntityAttempt(int x, int y)
		{
			if (!true)
			{
			}
			int num = TEDisplayDoll.Place(x, y);
		}

		// Token: 0x060041F0 RID: 16880 RVA: 0x00249168 File Offset: 0x00247368
		public static int Place(int x, int y)
		{
			if (!true)
			{
			}
			int num = TileEntity.AssignNewID();
			if (!true)
			{
			}
			Monitor.Enter(x, x != 0);
			long num2 = 0L;
			Monitor.Exit(x);
			if (num2 == 0L)
			{
				return x;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060041F1 RID: 16881 RVA: 0x002491B8 File Offset: 0x002473B8
		public static int Hook_AfterPlacement(int x, int y, int type = 470, int style = 0, int direction = 1, int alternate = 0)
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

		// Token: 0x060041F2 RID: 16882 RVA: 0x002491FC File Offset: 0x002473FC
		public static void Kill(int x, int y)
		{
			if (!true)
			{
			}
			int key = TileEntity.GetKey(x, y);
			if (!true)
			{
			}
			if (!true)
			{
			}
			int key2 = TileEntity.GetKey(x, y);
			if (!false)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060041F3 RID: 16883 RVA: 0x00249248 File Offset: 0x00247448
		public static int Find(int x, int y)
		{
			/*
An exception occurred when decompiling this method (060041F3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.GameContent.Tile_Entities.TEDisplayDoll::Find(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_0_0E, call:int32(TileEntity::GetKey, ldc.i4:int32(-2147483648), ldloc:int32(x)))
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

		// Token: 0x060041F4 RID: 16884 RVA: 0x00249264 File Offset: 0x00247464
		public override void WriteExtraData(BinaryWriter writer, bool networkSend)
		{
			BitsByte bitsByte = 0;
			Vector2 position = this._items.position;
			Vector2 velocity = this._items.velocity;
			Vector2 oldPosition = this._items.oldPosition;
			Vector2 oldVelocity = this._items.oldVelocity;
			int width = this._items.width;
			bool wet = this._items.wet;
			Item[] items = this._items;
			bool flag;
			BitsByte bitsByte2 = (flag ? 1 : 0);
			Item[] dyes = this._dyes;
			Vector2 position2 = dyes.position;
			Vector2 velocity2 = this._dyes.velocity;
			Item[] dyes2 = this._dyes;
			Vector2 oldVelocity2 = this._dyes.oldVelocity;
			int oldDirection = this._dyes.oldDirection;
			int width2 = this._dyes.width;
			bool wet2 = this._dyes.wet;
			string nameOverride = this._dyes._nameOverride;
			Item[] items2 = this._items;
			Item[] dyes3 = this._dyes;
		}

		// Token: 0x060041F5 RID: 16885 RVA: 0x00249384 File Offset: 0x00247584
		public override void ReadExtraData(BinaryReader reader, bool networkSend)
		{
			Item[] items = this._items;
			Item[] items2 = this._items;
			Item[] dyes = this._dyes;
			Item[] dyes2 = this._dyes;
		}

		// Token: 0x060041F6 RID: 16886 RVA: 0x002493C4 File Offset: 0x002475C4
		public override string ToString()
		{
			Point16 position = this.Position;
			string text;
			if ((text == null || text != null) && ("x  " == null || "x  " != null))
			{
				short y = this.Position.Y;
				string text2;
				if ((text2 == null || text2 != null) && ("y item: " == null || "y item: " != null))
				{
					Vector2 position2 = this._items.position;
					if (position2 == null || position2 == null || position2 == null)
					{
					}
					if (" " == null || " " != null)
					{
						Vector2 velocity = this._items.velocity;
						if (velocity == null || velocity == null || velocity == null)
						{
						}
						if (" " == null || " " != null)
						{
							Vector2 oldPosition = this._items.oldPosition;
							if (oldPosition == null || oldPosition == null || oldPosition != null)
							{
								string text3;
								return text3;
							}
						}
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060041F7 RID: 16887 RVA: 0x00249488 File Offset: 0x00247688
		public static void Framing_CheckTile(int callX, int callY)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				short frameX = Framing.GetTileSafely(callX, callY).frameX;
				int num2 = 36409;
				if (num == 0)
				{
				}
				Tile tile;
				bool flag = tile.active();
				if (num == 0)
				{
				}
				bool flag2 = WorldGen.SolidTileAllowBottomSlope(43134976, 43134976);
				if (num == 0)
				{
				}
				bool flag3 = WorldGen.SolidTileAllowBottomSlope(0, 43134976);
				TEDisplayDoll.Kill(0, num2);
				if (!false)
				{
				}
				Tile tile2;
				short frameX2 = tile2.frameX;
				int num3 = 1989;
				if (num3 == 0)
				{
				}
				if (num3 == 0)
				{
				}
				Tile tile3;
				bool flag4 = tile3.active();
				if (num3 == 0)
				{
				}
				Tile tile4;
				ushort type = tile4.type;
				if (num3 == 0)
				{
				}
				long num4 = 0L;
				long num5 = 0L;
				long num6 = 0L;
				WorldGen.KillTile(43134976, num2, num4 != 0L, num5 != 0L, num6 != 0L);
				if (num3 == 0)
				{
				}
			}
		}

		// Token: 0x060041F8 RID: 16888 RVA: 0x0024955C File Offset: 0x0024775C
		public void Draw(int tileLeftX, int tileTopY)
		{
			Player dollPlayer = this._dollPlayer;
			Item[] items = this._items;
			Item[] armor = dollPlayer.armor;
			Item[] dyes = this._dyes;
			Item[] dye = dollPlayer.dye;
			int num = 1;
			int num2 = 1;
			dollPlayer.Male = num != 0;
			short frameX = Framing.GetTileSafely(tileLeftX, tileTopY).frameX;
			dollPlayer.direction = num2;
			long num3 = 0L;
			dollPlayer.Male = num3 != 0L;
			int num4 = 1;
			dollPlayer.isDisplayDollOrInanimate = num4 != 0;
			dollPlayer.ResetEffects();
			dollPlayer.ResetVisibleAccessories();
			dollPlayer.UpdateDyes();
			dollPlayer.DisplayDollUpdate();
			dollPlayer.UpdateSocialShadow();
			dollPlayer.PlayerFrame();
			int width = dollPlayer.width;
			bool wet = dollPlayer.wet;
			dollPlayer.isFullbright = width != 0;
			if (!wet)
			{
			}
			int num5;
			dollPlayer.skinDyePacked = num5;
			if (-1073741824 == 0)
			{
			}
			Camera camera = Main.Camera;
			float x = dollPlayer.position.X;
			float y = dollPlayer.position.Y;
			float x2 = dollPlayer.fullRotationOrigin.X;
			float y2 = dollPlayer.fullRotationOrigin.Y;
			if (wet)
			{
			}
		}

		// Token: 0x060041F9 RID: 16889 RVA: 0x00249674 File Offset: 0x00247874
		public override void OnPlayerUpdate(Player player)
		{
			int x = player.tileEntityAnchor.X;
			int y = player.tileEntityAnchor.Y;
			TileReachCheckSettings simple = TileReachCheckSettings.Simple;
			int chest = player.chest;
			int talkNPC = player.talkNPC;
		}

		// Token: 0x060041FA RID: 16890 RVA: 0x002496C8 File Offset: 0x002478C8
		public static void OnPlayerInteraction(Player player, int clickX, int clickY)
		{
			if (!true)
			{
			}
			Tile tile;
			short frameX = tile.frameX;
			Tile tile2;
			short frameY = tile2.frameY;
			int num = TEDisplayDoll.Find(clickX, int.MinValue);
			if (frameY == 0)
			{
			}
			if (frameY == 0)
			{
			}
			TileEntity.BasicOpenCloseInteraction(player, clickX, int.MinValue, num);
		}

		// Token: 0x060041FB RID: 16891 RVA: 0x0024970C File Offset: 0x0024790C
		public override bool TryGetItemGamepadOverrideInstructions(Item[] inv, int context, int slot, [Out] string instruction)
		{
			bool flag;
			if (flag)
			{
			}
			if (context == 0)
			{
				return;
			}
			if (!flag)
			{
			}
			int myPlayer = Main.myPlayer;
			Player.ItemSpaceStatus itemSpaceStatus;
			bool canTakeItemToPersonalInventory = itemSpaceStatus.CanTakeItemToPersonalInventory;
			if (!flag)
			{
				return;
			}
		}

		// Token: 0x060041FC RID: 16892 RVA: 0x0024973C File Offset: 0x0024793C
		private void DrawInner(Player player, SpriteBatch spriteBatch)
		{
			if (!true)
			{
			}
		}

		// Token: 0x060041FD RID: 16893 RVA: 0x00249750 File Offset: 0x00247950
		private void DrawSlotPairSet(Player player, SpriteBatch spriteBatch, int slotsToShowLine, int slotsArrayOffset, float offsetX, float offsetY, int inventoryContextTarget)
		{
			if (16992 == 0)
			{
			}
			float inventoryScale = Main.inventoryScale;
			float inventoryScale2 = Main.inventoryScale;
			int num = 40;
			if (num == 0)
			{
			}
			int mouseX = Main.mouseX;
			int mouseY = Main.mouseY;
			if (num == 0)
			{
			}
			float inventoryScale3 = Main.inventoryScale;
			float inventoryScale4 = Main.inventoryScale;
			bool ignoreMouseInterface = PlayerInput.IgnoreMouseInterface;
		}

		// Token: 0x060041FE RID: 16894 RVA: 0x002497C4 File Offset: 0x002479C4
		public override bool OverrideItemSlotHover(Item[] inv, int context = 0, int slot = 0)
		{
			/*
An exception occurred when decompiling this method (060041FE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Tile_Entities.TEDisplayDoll::OverrideItemSlotHover(Terraria.Item[],System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_1:
	callsetter:int32(Main::set_cursorOverride, ldc.i4:int32(9))
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

		// Token: 0x060041FF RID: 16895 RVA: 0x002497FC File Offset: 0x002479FC
		public override bool OverrideItemSlotLeftClick(Item[] inv, int context = 0, int slot = 0)
		{
			Item item;
			do
			{
				int num = 1;
				if (num == 0)
				{
				}
				bool shiftInUse = ItemSlot.ShiftInUse;
				if (num == 0)
				{
				}
				int cursorOverride = Main.cursorOverride;
				if (context == 0)
				{
				}
				int cursorOverride2 = Main.cursorOverride;
				int myPlayer = Main.myPlayer;
				int myPlayer2 = Main.myPlayer;
				if (item != null && item == null)
				{
					goto IL_0092;
				}
				bool netClient = Main.NetClient;
				int myPlayer3 = Main.myPlayer;
				int id = this.ID;
				int headSlot = item.headSlot;
				int bodySlot = item.bodySlot;
				int legSlot = item.legSlot;
			}
			while (!item.accessory);
			bool flag;
			return flag;
			IL_0092:
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06004200 RID: 16896 RVA: 0x002498A0 File Offset: 0x00247AA0
		public static bool FitsDisplayDoll(Item item)
		{
			return true;
		}

		// Token: 0x06004201 RID: 16897 RVA: 0x002498B4 File Offset: 0x00247AB4
		private bool TryFitting(Item[] inv, int context = 0, int slot = 0, bool justCheck = false)
		{
			int headSlot = inv.headSlot;
			int bodySlot = inv.bodySlot;
			int legSlot = inv.legSlot;
			bool accessory = inv.accessory;
			int num = 2;
			if (!accessory || headSlot == 0)
			{
			}
			bool accessory2 = inv.accessory;
			int num2;
			if (accessory2)
			{
				if (!accessory2)
				{
				}
				if (num == 0)
				{
				}
				num2 = 3;
				Item[] items = this._items;
				Item[] items2 = this._items;
				bool flag;
				return flag;
			}
			Item[] items3 = this._items;
			int num3;
			if (num3 == 0)
			{
			}
			if (num3 == 0)
			{
			}
			bool netClient = Main.NetClient;
			if (num3 == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			int id = this.ID;
			if (num2 == 0)
			{
				goto IL_00A8;
			}
			goto IL_00A8;
			IL_00A8:;
		}

		// Token: 0x06004202 RID: 16898 RVA: 0x00249970 File Offset: 0x00247B70
		public void WriteItem(int itemIndex, BinaryWriter writer, bool dye)
		{
		}

		// Token: 0x06004203 RID: 16899 RVA: 0x00249980 File Offset: 0x00247B80
		public void ReadItem(int itemIndex, BinaryReader reader, bool dye)
		{
		}

		// Token: 0x06004204 RID: 16900 RVA: 0x00249990 File Offset: 0x00247B90
		public override bool IsTileValidForEntity(int x, int y)
		{
			/*
An exception occurred when decompiling this method (06004204)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Tile_Entities.TEDisplayDoll::IsTileValidForEntity(System.Int32,System.Int32)

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

		// Token: 0x06004205 RID: 16901 RVA: 0x002499D0 File Offset: 0x00247BD0
		public void SetInventoryFromMannequin(int headFrame, int shirtFrame, int legFrame)
		{
			Vector2 position = this._items.position;
			Vector2 velocity = this._items.velocity;
			Vector2 oldPosition = this._items.oldPosition;
		}

		// Token: 0x06004206 RID: 16902 RVA: 0x00249A04 File Offset: 0x00247C04
		public static bool IsBreakable(int clickX, int clickY)
		{
			if (!true)
			{
			}
			Tile tile;
			short frameX = tile.frameX;
			Tile tile2;
			short frameY = tile2.frameY;
			int num = TEDisplayDoll.Find(0, clickX);
			if (frameY == 0)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06004207 RID: 16903 RVA: 0x00249A40 File Offset: 0x00247C40
		public bool ContainsItems()
		{
			/*
An exception occurred when decompiling this method (06004207)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Tile_Entities.TEDisplayDoll::ContainsItems()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class Terraria.Item[](var_1_09, ldfld:class Terraria.Item[](TEDisplayDoll::_items, ldloc:TEDisplayDoll(this)))
	stloc:class Terraria.Item[](var_3_10, ldfld:class Terraria.Item[](TEDisplayDoll::_dyes, ldloc:TEDisplayDoll(this)))
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

		// Token: 0x06004208 RID: 16904 RVA: 0x00249A64 File Offset: 0x00247C64
		public void FixLoadedData()
		{
			long entityId = this._items.entityId;
			long entityId2 = this._dyes.entityId;
		}

		// Token: 0x06004209 RID: 16905 RVA: 0x00249A90 File Offset: 0x00247C90
		// Note: this type is marked as 'beforefieldinit'.
		static TEDisplayDoll()
		{
		}

		// Token: 0x040080B2 RID: 32946
		private static byte _myEntityID;

		// Token: 0x040080B3 RID: 32947
		private const int MyTileID = 470;

		// Token: 0x040080B4 RID: 32948
		private const int entityTileWidth = 2;

		// Token: 0x040080B5 RID: 32949
		private const int entityTileHeight = 3;

		// Token: 0x040080B6 RID: 32950
		public Player _dollPlayer;

		// Token: 0x040080B7 RID: 32951
		public Item[] _items;

		// Token: 0x040080B8 RID: 32952
		public Item[] _dyes;

		// Token: 0x040080B9 RID: 32953
		private static int accessoryTargetSlot;
	}
}
