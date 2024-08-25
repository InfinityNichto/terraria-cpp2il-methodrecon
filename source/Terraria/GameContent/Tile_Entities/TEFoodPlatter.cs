using System;
using System.IO;
using System.Threading;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Terraria.GameContent.Tile_Entities
{
	// Token: 0x02000811 RID: 2065
	public class TEFoodPlatter : TileEntity, IFixLoadedData
	{
		// Token: 0x0600420A RID: 16906 RVA: 0x00249AA0 File Offset: 0x00247CA0
		public override void RegisterTileEntityID(int assignedID)
		{
		}

		// Token: 0x0600420B RID: 16907 RVA: 0x00249AB0 File Offset: 0x00247CB0
		public override void NetPlaceEntityAttempt(int x, int y)
		{
			TEFoodPlatter.NetPlaceEntity(x, y);
		}

		// Token: 0x0600420C RID: 16908 RVA: 0x00249AC4 File Offset: 0x00247CC4
		public static void NetPlaceEntity(int x, int y)
		{
			int num = TEFoodPlatter.Place(x, y);
		}

		// Token: 0x0600420D RID: 16909 RVA: 0x000021DB File Offset: 0x000003DB
		public override TileEntity GenerateInstance()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600420E RID: 16910 RVA: 0x00249ADC File Offset: 0x00247CDC
		public TEFoodPlatter()
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x0600420F RID: 16911 RVA: 0x00249AF4 File Offset: 0x00247CF4
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

		// Token: 0x06004210 RID: 16912 RVA: 0x00249B44 File Offset: 0x00247D44
		public override bool IsTileValidForEntity(int x, int y)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06004211 RID: 16913 RVA: 0x00249B54 File Offset: 0x00247D54
		public static int Hook_AfterPlacement(int x, int y, int type = 520, int style = 0, int direction = 1, int alternate = 0)
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

		// Token: 0x06004212 RID: 16914 RVA: 0x00249B90 File Offset: 0x00247D90
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

		// Token: 0x06004213 RID: 16915 RVA: 0x00249BD4 File Offset: 0x00247DD4
		public static int Find(int x, int y)
		{
			if (!true)
			{
			}
			int key = TileEntity.GetKey(int.MinValue, x);
			return int.MinValue;
		}

		// Token: 0x06004214 RID: 16916 RVA: 0x00249BFC File Offset: 0x00247DFC
		public static bool ValidTile(int x, int y)
		{
			/*
An exception occurred when decompiling this method (06004214)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Tile_Entities.TEFoodPlatter::ValidTile(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001D:
	stloc:int16(var_7_24, callgetter:int16(Tile::get_frameY, ldloc:Tile[exp:valuetype Terraria.Tile&](var_6)))
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

		// Token: 0x06004215 RID: 16917 RVA: 0x00249C34 File Offset: 0x00247E34
		public override void WriteExtraData(BinaryWriter writer, bool networkSend)
		{
			int netID = this.item.netID;
			byte prefix = this.item.prefix;
			int stack = this.item.stack;
		}

		// Token: 0x06004216 RID: 16918 RVA: 0x00249C68 File Offset: 0x00247E68
		public override void ReadExtraData(BinaryReader reader, bool networkSend)
		{
			long num = 0L;
			bool flag = this.item.Prefix((int)num);
			Item item = this.item;
		}

		// Token: 0x06004217 RID: 16919 RVA: 0x00249C8C File Offset: 0x00247E8C
		public override string ToString()
		{
			Point16 position = this.Position;
			string text;
			if ((text == null || text != null) && ("x  " == null || "x  " != null))
			{
				short y = this.Position.Y;
				string text2;
				if ((text2 == null || text2 != null) && ("y item: " == null || "y item: " != null) && ("y item: " == null || "y item: " == null || "y item: " != null))
				{
					string text3;
					return text3;
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06004218 RID: 16920 RVA: 0x00249CF4 File Offset: 0x00247EF4
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

		// Token: 0x06004219 RID: 16921 RVA: 0x00249D24 File Offset: 0x00247F24
		public static void TryPlacing(int x, int y, int netid, int prefix, int stack)
		{
			int num = 1;
			if (num == 0)
			{
			}
			WorldGen.RangeFrame(x, y, netid, prefix);
			int num2 = TEFoodPlatter.Find(x, y);
			if (num == 0)
			{
			}
		}

		// Token: 0x0600421A RID: 16922 RVA: 0x00249D58 File Offset: 0x00247F58
		public static void OnPlayerInteraction(Player player, int clickX, int clickY)
		{
			Vector2 position = player.inventory.position;
			Vector2 position2 = player.inventory.position;
			if (position2 != null)
			{
				int num = TEFoodPlatter.Find(clickX, clickY);
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
			TEFoodPlatter.PlaceItemInFrame(player, clickX, clickY);
			Recipe.FindRecipes(false);
		}

		// Token: 0x0600421B RID: 16923 RVA: 0x00249DD0 File Offset: 0x00247FD0
		public static bool FitsFoodPlatter(Item i)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x0600421C RID: 16924 RVA: 0x00249DE4 File Offset: 0x00247FE4
		public static void PlaceItemInFrame(Player player, int x, int y)
		{
			int num = 1;
			bool itemTimeIsZero = player.ItemTimeIsZero;
			int num2 = TEFoodPlatter.Find(x, y);
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

		// Token: 0x0600421D RID: 16925 RVA: 0x00249EEC File Offset: 0x002480EC
		public void FixLoadedData()
		{
			this.item.FixAgainstExploit();
		}

		// Token: 0x040080C3 RID: 32963
		private static byte _myEntityID;

		// Token: 0x040080C4 RID: 32964
		public Item item;
	}
}
