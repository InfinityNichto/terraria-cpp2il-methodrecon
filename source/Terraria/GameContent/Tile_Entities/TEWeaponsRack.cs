using System;
using System.IO;
using System.Threading;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Terraria.GameContent.Tile_Entities
{
	// Token: 0x02000819 RID: 2073
	public class TEWeaponsRack : TileEntity, IFixLoadedData
	{
		// Token: 0x0600428D RID: 17037 RVA: 0x0024B8B8 File Offset: 0x00249AB8
		public TEWeaponsRack()
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x0600428E RID: 17038 RVA: 0x0024B8D0 File Offset: 0x00249AD0
		public override void RegisterTileEntityID(int assignedID)
		{
		}

		// Token: 0x0600428F RID: 17039 RVA: 0x000021DB File Offset: 0x000003DB
		public override TileEntity GenerateInstance()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004290 RID: 17040 RVA: 0x0024B8E0 File Offset: 0x00249AE0
		public override void NetPlaceEntityAttempt(int x, int y)
		{
			TEWeaponsRack.NetPlaceEntity(x, y);
		}

		// Token: 0x06004291 RID: 17041 RVA: 0x0024B8F4 File Offset: 0x00249AF4
		public static void NetPlaceEntity(int x, int y)
		{
			int num = TEWeaponsRack.Place(x, y);
		}

		// Token: 0x06004292 RID: 17042 RVA: 0x0024B90C File Offset: 0x00249B0C
		public override bool IsTileValidForEntity(int x, int y)
		{
			return TEWeaponsRack.ValidTile(x, y);
		}

		// Token: 0x06004293 RID: 17043 RVA: 0x0024B920 File Offset: 0x00249B20
		public static bool ValidTile(int x, int y)
		{
			/*
An exception occurred when decompiling this method (06004293)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Tile_Entities.TEWeaponsRack::ValidTile(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0032:
	stloc:int16(var_12_39, callgetter:int16(Tile::get_frameX, ldloc:Tile[exp:valuetype Terraria.Tile&](var_11)))
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

		// Token: 0x06004294 RID: 17044 RVA: 0x0024B968 File Offset: 0x00249B68
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

		// Token: 0x06004295 RID: 17045 RVA: 0x0024B9B8 File Offset: 0x00249BB8
		public static int Hook_AfterPlacement(int x, int y, int type = 471, int style = 0, int direction = 1, int alternate = 0)
		{
			if (!true)
			{
			}
			bool netClientOnly = Main.NetClientOnly;
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
			return 87;
		}

		// Token: 0x06004296 RID: 17046 RVA: 0x0024B9F4 File Offset: 0x00249BF4
		public static void Kill(int x, int y)
		{
			if (!true)
			{
			}
			int key = TileEntity.GetKey(x, y);
			int key2 = TileEntity.GetKey(x, y);
			if (!false)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06004297 RID: 17047 RVA: 0x0024BA38 File Offset: 0x00249C38
		public static int Find(int x, int y)
		{
			if (!true)
			{
			}
			int key = TileEntity.GetKey(int.MinValue, x);
			return int.MinValue;
		}

		// Token: 0x06004298 RID: 17048 RVA: 0x0024BA60 File Offset: 0x00249C60
		public override void WriteExtraData(BinaryWriter writer, bool networkSend)
		{
			int netID = this.item.netID;
			byte prefix = this.item.prefix;
			int stack = this.item.stack;
		}

		// Token: 0x06004299 RID: 17049 RVA: 0x0024BA94 File Offset: 0x00249C94
		public override void ReadExtraData(BinaryReader reader, bool networkSend)
		{
			long num = 0L;
			bool flag = this.item.Prefix((int)num);
			Item item = this.item;
		}

		// Token: 0x0600429A RID: 17050 RVA: 0x0024BAB8 File Offset: 0x00249CB8
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
					Item item = this.item;
					if (item == null || item == null || item != null)
					{
						string text3;
						return text3;
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600429B RID: 17051 RVA: 0x0024BB1C File Offset: 0x00249D1C
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
				int num2 = TEWeaponsRack.Find(callX, callY);
				if (num == 0)
				{
				}
				Player localPlayer = Main.LocalPlayer;
				int num3 = 471;
				localPlayer.InterruptItemUsageIfOverTile(num3);
				Tile tile2;
				bool flag2 = tile2.active();
				Tile tile3;
				ushort type = tile3.type;
				long num4 = 0L;
				long num5 = 0L;
				long num6 = 0L;
				WorldGen.KillTile(callX, callY, num4 != 0L, num5 != 0L, num6 != 0L);
				TEWeaponsRack.Kill(callX, callY);
			}
		}

		// Token: 0x0600429C RID: 17052 RVA: 0x0024BBAC File Offset: 0x00249DAC
		public void DropItem()
		{
			if (!true)
			{
			}
			bool logicHost = Main.LogicHost;
			Item item = this.item;
			int netID = item.netID;
			byte prefix = item.prefix;
		}

		// Token: 0x0600429D RID: 17053 RVA: 0x0024BBDC File Offset: 0x00249DDC
		public static void TryPlacing(int x, int y, int netid, int prefix, int stack)
		{
			int num = 1;
			if (num == 0)
			{
			}
			WorldGen.RangeFrame(x, y, netid, prefix);
			int num2 = TEWeaponsRack.Find(x, y);
			if (num == 0)
			{
			}
		}

		// Token: 0x0600429E RID: 17054 RVA: 0x0024BC10 File Offset: 0x00249E10
		public static void OnPlayerInteraction(Player player, int clickX, int clickY)
		{
			Vector2 position = player.inventory.position;
			Vector2 position2 = player.inventory.position;
			if (position2 != null)
			{
				if (position2 == null)
				{
				}
				Tile tile;
				short frameX = tile.frameX;
				Tile tile2;
				short frameY = tile2.frameY;
				int num = TEWeaponsRack.Find(clickX, clickY);
				if (position2 == null)
				{
				}
				player.GamepadEnableGrappleCooldown();
				int num2 = 1;
				long num3 = 0L;
				long num4 = 0L;
				WorldGen.KillTile(clickX, clickY, num2 != 0, num3 != 0L, num4 != 0L);
				bool netClient = Main.NetClient;
				return;
			}
			player.GamepadEnableGrappleCooldown();
			TEWeaponsRack.PlaceItemInFrame(player, clickX, clickY);
			Recipe.FindRecipes(false);
		}

		// Token: 0x0600429F RID: 17055 RVA: 0x0024BCA0 File Offset: 0x00249EA0
		public static bool FitsWeaponFrame(Item i)
		{
			int num = 1;
			if (num != 0)
			{
				bool flag;
				return flag;
			}
		}

		// Token: 0x060042A0 RID: 17056 RVA: 0x0024BCC0 File Offset: 0x00249EC0
		private static void PlaceItemInFrame(Player player, int x, int y)
		{
			int num = 1;
			bool itemTimeIsZero = player.ItemTimeIsZero;
			if (num == 0)
			{
			}
			Tile tile;
			short frameX = tile.frameX;
			Tile tile2;
			short frameY = tile2.frameY;
			int num2 = TEWeaponsRack.Find(x, y);
			if (num == 0)
			{
			}
			int num3 = 1;
			long num4 = 0L;
			long num5 = 0L;
			WorldGen.KillTile(x, y, num3 != 0, num4 != 0L, num5 != 0L);
			bool netClient = Main.NetClient;
			int tileTargetX = Player.tileTargetX;
			bool netClientOnly = Main.NetClientOnly;
			int selectedItem = player.selectedItem;
			int whoAmI = player.whoAmI;
		}

		// Token: 0x060042A1 RID: 17057 RVA: 0x0024BDE8 File Offset: 0x00249FE8
		public void FixLoadedData()
		{
			this.item.FixAgainstExploit();
		}

		// Token: 0x040080EC RID: 33004
		private static byte _myEntityID;

		// Token: 0x040080ED RID: 33005
		public Item item;

		// Token: 0x040080EE RID: 33006
		private const int MyTileID = 471;
	}
}
