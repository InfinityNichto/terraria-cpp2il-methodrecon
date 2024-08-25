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
	// Token: 0x02000812 RID: 2066
	public class TEHatRack : TileEntity, IFixLoadedData
	{
		// Token: 0x0600421E RID: 16926 RVA: 0x00249F04 File Offset: 0x00248104
		public TEHatRack()
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

		// Token: 0x0600421F RID: 16927 RVA: 0x00249F50 File Offset: 0x00248150
		public override void RegisterTileEntityID(int assignedID)
		{
		}

		// Token: 0x06004220 RID: 16928 RVA: 0x000021DB File Offset: 0x000003DB
		public override TileEntity GenerateInstance()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004221 RID: 16929 RVA: 0x00249F60 File Offset: 0x00248160
		public override void NetPlaceEntityAttempt(int x, int y)
		{
			int num = TEHatRack.Place(x, y);
		}

		// Token: 0x06004222 RID: 16930 RVA: 0x00249F78 File Offset: 0x00248178
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
				return x;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06004223 RID: 16931 RVA: 0x00249FC8 File Offset: 0x002481C8
		public static int Hook_AfterPlacement(int x, int y, int type = 475, int style = 0, int direction = 1, int alternate = 0)
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

		// Token: 0x06004224 RID: 16932 RVA: 0x0024A00C File Offset: 0x0024820C
		public static void Kill(int x, int y)
		{
			int key = TileEntity.GetKey(x, y);
			int key2 = TileEntity.GetKey(x, y);
			if (!false)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06004225 RID: 16933 RVA: 0x0024A050 File Offset: 0x00248250
		public static int Find(int x, int y)
		{
			if (!true)
			{
			}
			int key = TileEntity.GetKey(int.MinValue, x);
			return int.MinValue;
		}

		// Token: 0x06004226 RID: 16934 RVA: 0x0024A078 File Offset: 0x00248278
		public override void WriteExtraData(BinaryWriter writer, bool networkSend)
		{
			BitsByte bitsByte = 0;
			Vector2 position = this._items.position;
			Vector2 velocity = this._items.velocity;
			Vector2 position2 = this._dyes.position;
			Item[] dyes = this._dyes;
			Item[] items = this._items;
			Item[] dyes2 = this._dyes;
		}

		// Token: 0x06004227 RID: 16935 RVA: 0x0024A0E0 File Offset: 0x002482E0
		public override void ReadExtraData(BinaryReader reader, bool networkSend)
		{
			Item[] items = this._items;
			Item[] items2 = this._items;
			Item[] dyes = this._dyes;
			Item[] dyes2 = this._dyes;
		}

		// Token: 0x06004228 RID: 16936 RVA: 0x0024A11C File Offset: 0x0024831C
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
						if (velocity == null || velocity == null || velocity != null)
						{
							string text3;
							return text3;
						}
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06004229 RID: 16937 RVA: 0x0024A1B4 File Offset: 0x002483B4
		public static void Framing_CheckTile(int callX, int callY)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				short frameX = Framing.GetTileSafely(callX, callY).frameX;
				if (num == 0)
				{
				}
				Tile tile;
				bool flag = tile.active();
				if (num == 0)
				{
				}
				bool flag2 = WorldGen.SolidTileAllowBottomSlope(callX, callX);
				if (num == 0)
				{
				}
				bool flag3 = WorldGen.SolidTileAllowBottomSlope(0, callX);
				if (num == 0)
				{
				}
				bool flag4 = WorldGen.SolidTileAllowBottomSlope(0, callX);
				TEHatRack.Kill(callX, callY);
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				Tile tile2;
				bool flag5 = tile2.active();
				if (num == 0)
				{
				}
				Tile tile3;
				ushort type = tile3.type;
				if (num == 0)
				{
				}
				long num2 = 0L;
				long num3 = 0L;
				long num4 = 0L;
				WorldGen.KillTile(callX, callY, num2 != 0L, num3 != 0L, num4 != 0L);
				if (num == 0)
				{
				}
			}
		}

		// Token: 0x0600422A RID: 16938 RVA: 0x0024A270 File Offset: 0x00248470
		public void Draw(int tileLeftX, int tileTopY)
		{
			int num = 1;
			Player dollPlayer = this._dollPlayer;
			int num2 = 1;
			dollPlayer.direction = num;
			int num3 = 1;
			dollPlayer.Male = num2 != 0;
			short frameX = Framing.GetTileSafely(tileLeftX, tileTopY).frameX;
			dollPlayer.direction = num3;
			dollPlayer.isDisplayDollOrInanimate = num3 != 0;
			dollPlayer.isHatRackDoll = num3 != 0;
			Item[] items = this._items;
			Item[] armor = dollPlayer.armor;
			Vector2 position = items.position;
			if (position == null || position != null)
			{
				armor.position = position;
				Item[] dyes = this._dyes;
				Item[] dye = dollPlayer.dye;
				Vector2 position2 = dyes.position;
				if (position2 == null || position2 != null)
				{
					dye.position = position2;
					dollPlayer.ResetEffects();
					dollPlayer.ResetVisibleAccessories();
					int num4 = 1;
					dollPlayer.invis = num4 != 0;
					dollPlayer.UpdateDyes();
					dollPlayer.DisplayDollUpdate();
					dollPlayer.PlayerFrame();
					int direction = dollPlayer.direction;
					int width = dollPlayer.width;
					bool wet = dollPlayer.wet;
					dollPlayer.direction = direction;
					int direction2 = dollPlayer.direction;
					int num5 = 14;
					if (direction2 == 0)
					{
					}
					Camera camera = Main.Camera;
					float x = dollPlayer.position.X;
					float y = dollPlayer.position.Y;
					float x2 = dollPlayer.fullRotationOrigin.X;
					float y2 = dollPlayer.fullRotationOrigin.Y;
					if (num5 != 0)
					{
					}
					return;
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600422B RID: 16939 RVA: 0x0024A4C8 File Offset: 0x002486C8
		public override bool TryGetItemGamepadOverrideInstructions(Item[] inv, int context, int slot, [Out] string instruction)
		{
			bool flag;
			if (flag)
			{
			}
			if (context != 0)
			{
				if (!flag)
				{
				}
				int myPlayer = Main.myPlayer;
				Player.ItemSpaceStatus itemSpaceStatus;
				bool canTakeItemToPersonalInventory = itemSpaceStatus.CanTakeItemToPersonalInventory;
				if (!flag)
				{
				}
			}
			if (!flag)
			{
				return;
			}
		}

		// Token: 0x0600422C RID: 16940 RVA: 0x0024A4F8 File Offset: 0x002486F8
		public override void OnPlayerUpdate(Player player)
		{
			int x = player.tileEntityAnchor.X;
			int y = player.tileEntityAnchor.Y;
			TileReachCheckSettings simple = TileReachCheckSettings.Simple;
			int chest = player.chest;
			int talkNPC = player.talkNPC;
		}

		// Token: 0x0600422D RID: 16941 RVA: 0x0024A54C File Offset: 0x0024874C
		public static void OnPlayerInteraction(Player player, int clickX, int clickY)
		{
			if (!true)
			{
			}
			Tile tile;
			short frameX = tile.frameX;
			int num = 36409;
			Tile tile2;
			short frameY = tile2.frameY;
			int num2 = TEHatRack.Find(clickX, num);
			TileEntity.BasicOpenCloseInteraction(player, clickX, num, num2);
		}

		// Token: 0x0600422E RID: 16942 RVA: 0x0024A584 File Offset: 0x00248784
		private void DrawInner(Player player, SpriteBatch spriteBatch)
		{
			if (!true)
			{
			}
		}

		// Token: 0x0600422F RID: 16943 RVA: 0x0024A598 File Offset: 0x00248798
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

		// Token: 0x06004230 RID: 16944 RVA: 0x0024A60C File Offset: 0x0024880C
		public override bool OverrideItemSlotHover(Item[] inv, int context = 0, int slot = 0)
		{
			/*
An exception occurred when decompiling this method (06004230)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Tile_Entities.TEHatRack::OverrideItemSlotHover(Terraria.Item[],System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001E:
	callsetter:int32(Main::set_cursorOverride, ldc.i4:int32(8))
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

		// Token: 0x06004231 RID: 16945 RVA: 0x0024A644 File Offset: 0x00248844
		public override bool OverrideItemSlotLeftClick(Item[] inv, int context = 0, int slot = 0)
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
				if (num == 0)
				{
				}
				int cursorOverride2 = Main.cursorOverride;
				bool flag;
				return flag;
			}
			int cursorOverride3 = Main.cursorOverride;
			int myPlayer = Main.myPlayer;
			int myPlayer2 = Main.myPlayer;
			Item item;
			if (item == null || item != null)
			{
				bool netClient = Main.NetClient;
				int myPlayer3 = Main.myPlayer;
				int id = this.ID;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06004232 RID: 16946 RVA: 0x0024A6D0 File Offset: 0x002488D0
		public static bool FitsHatRack(Item item)
		{
		}

		// Token: 0x06004233 RID: 16947 RVA: 0x0024A6E0 File Offset: 0x002488E0
		private bool TryFitting(Item[] inv, int context = 0, int slot = 0, bool justCheck = false)
		{
			/*
An exception occurred when decompiling this method (06004233)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Tile_Entities.TEHatRack::TryFitting(Terraria.Item[],System.Int32,System.Int32,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Vector2(var_3_11, ldfld:Vector2(Entity::position, ldfld:class Terraria.Item[][exp:Entity](TEHatRack::_items, ldloc:TEHatRack(this))))
	stloc:class Terraria.Item[](var_5_18, ldfld:class Terraria.Item[](TEHatRack::_items, ldloc:TEHatRack(this)))
	stloc:class Terraria.Item[](var_9_26, ldfld:class Terraria.Item[](TEHatRack::_items, ldloc:TEHatRack(this)))
	stloc:bool(var_11_30, callgetter:bool(Main::get_NetClient))
	stloc:int32(var_13_3A, callgetter:int32(Main::get_myPlayer))
	stloc:int32(var_14_42, ldfld:int32(TileEntity::ID, ldloc:TEHatRack[exp:TileEntity](this)))
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

		// Token: 0x06004234 RID: 16948 RVA: 0x0024A738 File Offset: 0x00248938
		public void WriteItem(int itemIndex, BinaryWriter writer, bool dye)
		{
		}

		// Token: 0x06004235 RID: 16949 RVA: 0x0024A748 File Offset: 0x00248948
		public void ReadItem(int itemIndex, BinaryReader reader, bool dye)
		{
		}

		// Token: 0x06004236 RID: 16950 RVA: 0x0024A758 File Offset: 0x00248958
		public override bool IsTileValidForEntity(int x, int y)
		{
			/*
An exception occurred when decompiling this method (06004236)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Tile_Entities.TEHatRack::IsTileValidForEntity(System.Int32,System.Int32)

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

		// Token: 0x06004237 RID: 16951 RVA: 0x0024A798 File Offset: 0x00248998
		public static bool IsBreakable(int clickX, int clickY)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Tile tile;
			short frameX = tile.frameX;
			long num2 = 0L;
			Tile tile2;
			int num3 = TEHatRack.Find((int)tile2.frameY, (int)num2);
			if (num == 0)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06004238 RID: 16952 RVA: 0x0024A7D8 File Offset: 0x002489D8
		public bool ContainsItems()
		{
			/*
An exception occurred when decompiling this method (06004238)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Tile_Entities.TEHatRack::ContainsItems()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class Terraria.Item[](var_1_09, ldfld:class Terraria.Item[](TEHatRack::_items, ldloc:TEHatRack(this)))
	stloc:class Terraria.Item[](var_3_10, ldfld:class Terraria.Item[](TEHatRack::_dyes, ldloc:TEHatRack(this)))
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

		// Token: 0x06004239 RID: 16953 RVA: 0x0024A7FC File Offset: 0x002489FC
		public void FixLoadedData()
		{
			long entityId = this._items.entityId;
			long entityId2 = this._dyes.entityId;
		}

		// Token: 0x040080C5 RID: 32965
		private static byte _myEntityID;

		// Token: 0x040080C6 RID: 32966
		private const int MyTileID = 475;

		// Token: 0x040080C7 RID: 32967
		private const int entityTileWidth = 3;

		// Token: 0x040080C8 RID: 32968
		private const int entityTileHeight = 4;

		// Token: 0x040080C9 RID: 32969
		private Player _dollPlayer;

		// Token: 0x040080CA RID: 32970
		public Item[] _items;

		// Token: 0x040080CB RID: 32971
		public Item[] _dyes;

		// Token: 0x040080CC RID: 32972
		private static int hatTargetSlot;
	}
}
