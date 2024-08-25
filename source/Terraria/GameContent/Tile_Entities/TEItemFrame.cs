using System;
using System.IO;
using System.Threading;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Terraria.GameContent.Tile_Entities
{
	// Token: 0x02000814 RID: 2068
	public class TEItemFrame : TileEntity, IFixLoadedData
	{
		// Token: 0x0600423A RID: 16954 RVA: 0x0024A828 File Offset: 0x00248A28
		public override void RegisterTileEntityID(int assignedID)
		{
		}

		// Token: 0x0600423B RID: 16955 RVA: 0x0024A838 File Offset: 0x00248A38
		public override void NetPlaceEntityAttempt(int x, int y)
		{
			TEItemFrame.NetPlaceEntity(x, y);
		}

		// Token: 0x0600423C RID: 16956 RVA: 0x0024A84C File Offset: 0x00248A4C
		public static void NetPlaceEntity(int x, int y)
		{
			int num = TEItemFrame.Place(x, y);
		}

		// Token: 0x0600423D RID: 16957 RVA: 0x000021DB File Offset: 0x000003DB
		public override TileEntity GenerateInstance()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600423E RID: 16958 RVA: 0x0024A864 File Offset: 0x00248A64
		public TEItemFrame()
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x0600423F RID: 16959 RVA: 0x0024A87C File Offset: 0x00248A7C
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

		// Token: 0x06004240 RID: 16960 RVA: 0x0024A8CC File Offset: 0x00248ACC
		public override bool IsTileValidForEntity(int x, int y)
		{
			return TEItemFrame.ValidTile(x, y);
		}

		// Token: 0x06004241 RID: 16961 RVA: 0x0024A8E0 File Offset: 0x00248AE0
		public static int Hook_AfterPlacement(int x, int y, int type = 395, int style = 0, int direction = 1, int alternate = 0)
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

		// Token: 0x06004242 RID: 16962 RVA: 0x0024A91C File Offset: 0x00248B1C
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

		// Token: 0x06004243 RID: 16963 RVA: 0x0024A960 File Offset: 0x00248B60
		public static int Find(int x, int y)
		{
			if (!true)
			{
			}
			int key = TileEntity.GetKey(int.MinValue, x);
			return int.MinValue;
		}

		// Token: 0x06004244 RID: 16964 RVA: 0x0024A988 File Offset: 0x00248B88
		public static bool ValidTile(int x, int y)
		{
			/*
An exception occurred when decompiling this method (06004244)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Tile_Entities.TEItemFrame::ValidTile(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_002F:
	stloc:int16(var_11_36, callgetter:int16(Tile::get_frameX, ldloc:Tile[exp:valuetype Terraria.Tile&](var_10)))
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

		// Token: 0x06004245 RID: 16965 RVA: 0x0024A9CC File Offset: 0x00248BCC
		public override void WriteExtraData(BinaryWriter writer, bool networkSend)
		{
			int netID = this.item.netID;
			byte prefix = this.item.prefix;
			int stack = this.item.stack;
		}

		// Token: 0x06004246 RID: 16966 RVA: 0x0024AA00 File Offset: 0x00248C00
		public override void ReadExtraData(BinaryReader reader, bool networkSend)
		{
			long num = 0L;
			bool flag = this.item.Prefix((int)num);
			Item item = this.item;
		}

		// Token: 0x06004247 RID: 16967 RVA: 0x0024AA24 File Offset: 0x00248C24
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

		// Token: 0x06004248 RID: 16968 RVA: 0x0024AA88 File Offset: 0x00248C88
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

		// Token: 0x06004249 RID: 16969 RVA: 0x0024AAB8 File Offset: 0x00248CB8
		public static void TryPlacing(int x, int y, int netid, int prefix, int stack)
		{
			WorldGen.RangeFrame(x, y, netid, prefix);
			int num = TEItemFrame.Find(x, y);
		}

		// Token: 0x0600424A RID: 16970 RVA: 0x0024AAE4 File Offset: 0x00248CE4
		public static void OnPlayerInteraction(Player player, int clickX, int clickY)
		{
			Vector2 position = player.inventory.position;
			if (position != null)
			{
				if (position == null)
				{
				}
				Tile tile;
				short frameX = tile.frameX;
				int num = 36409;
				int num2 = 36;
				if (num == 0)
				{
				}
				Tile tile2;
				short frameY = tile2.frameY;
				int num3 = TEItemFrame.Find((int)frameY, num2);
				if (position == null)
				{
				}
				player.GamepadEnableGrappleCooldown();
				int num4 = 1;
				long num5 = 0L;
				long num6 = 0L;
				WorldGen.KillTile(clickX, clickY, num4 != 0, num5 != 0L, num6 != 0L);
				bool netClient = Main.NetClient;
				return;
			}
			player.GamepadEnableGrappleCooldown();
			TEItemFrame.PlaceItemInFrame(player, clickX, clickY);
			Recipe.FindRecipes(false);
		}

		// Token: 0x0600424B RID: 16971 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool FitsItemFrame(Item i)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600424C RID: 16972 RVA: 0x0024AB7C File Offset: 0x00248D7C
		public static void PlaceItemInFrame(Player player, int x, int y)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Tile tile;
			short frameX = tile.frameX;
			if (36409 == 0)
			{
			}
			Tile tile2;
			short frameY = tile2.frameY;
			int num2 = TEItemFrame.Find(x, y);
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

		// Token: 0x0600424D RID: 16973 RVA: 0x0024ACA0 File Offset: 0x00248EA0
		public void FixLoadedData()
		{
			this.item.FixAgainstExploit();
		}

		// Token: 0x040080D0 RID: 32976
		private static byte _myEntityID;

		// Token: 0x040080D1 RID: 32977
		public Item item;
	}
}
