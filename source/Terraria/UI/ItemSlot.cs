using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.GameContent.UI;
using Terraria.GameInput;
using UnityEngine;

namespace Terraria.UI
{
	// Token: 0x020006D2 RID: 1746
	public class ItemSlot
	{
		// Token: 0x06003A7E RID: 14974 RVA: 0x0023068C File Offset: 0x0022E88C
		static ItemSlot()
		{
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x06003A7F RID: 14975 RVA: 0x002307AC File Offset: 0x0022E9AC
		public static bool AltInUse
		{
			get
			{
				global::Cursor cursor;
				if (cursor != null)
				{
					bool key = KeyboardInput.GetKey(KeyCode.LeftAlt);
					return true;
				}
				return KeyboardInput.GetKey(KeyCode.RightAlt);
			}
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x06003A80 RID: 14976 RVA: 0x002307D8 File Offset: 0x0022E9D8
		public static bool ShiftInUse
		{
			get
			{
				global::Cursor cursor;
				if (cursor != null)
				{
					bool key = KeyboardInput.GetKey(KeyCode.LeftShift);
					return true;
				}
				return KeyboardInput.GetKey(KeyCode.RightShift);
			}
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x06003A81 RID: 14977 RVA: 0x00230804 File Offset: 0x0022EA04
		public static bool ControlInUse
		{
			get
			{
				global::Cursor cursor;
				if (cursor != null)
				{
					bool key = KeyboardInput.GetKey(KeyCode.LeftControl);
					return true;
				}
				return KeyboardInput.GetKey(KeyCode.RightControl);
			}
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x06003A82 RID: 14978 RVA: 0x00230830 File Offset: 0x0022EA30
		public static bool NotUsingGamepad
		{
			get
			{
				if (!true)
				{
				}
				return PlayerInput.UsingGamepad;
			}
		}

		// Token: 0x14000046 RID: 70
		// (add) Token: 0x06003A83 RID: 14979 RVA: 0x00230848 File Offset: 0x0022EA48
		// (remove) Token: 0x06003A84 RID: 14980 RVA: 0x00230864 File Offset: 0x0022EA64
		public static event ItemSlot.ItemTransferEvent OnItemTransferred
		{
			[CompilerGenerated]
			add
			{
				if (!true)
				{
				}
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (!true)
				{
				}
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
		}

		// Token: 0x06003A85 RID: 14981 RVA: 0x00230880 File Offset: 0x0022EA80
		public static void AnnounceTransfer(ItemSlot.ItemTransferInfo info)
		{
			if (!true)
			{
			}
			if (true)
			{
				return;
			}
		}

		// Token: 0x06003A86 RID: 14982 RVA: 0x00230894 File Offset: 0x0022EA94
		public static void SetGlow(int index, float hue, bool chest)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003A87 RID: 14983 RVA: 0x002308AC File Offset: 0x0022EAAC
		public static void UpdateInterface()
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool playerInventory = Main.playerInventory;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
		}

		// Token: 0x06003A88 RID: 14984 RVA: 0x002308F4 File Offset: 0x0022EAF4
		public static void Handle(Item inv, int context = 0)
		{
			if (!true)
			{
			}
			Recipe.FindRecipes(false);
		}

		// Token: 0x06003A89 RID: 14985 RVA: 0x00230910 File Offset: 0x0022EB10
		public static void Handle(Item[] inv, int context = 0, int slot = 0)
		{
			if (!true)
			{
			}
			ItemSlot.OverrideHover(inv, context, slot);
			ItemSlot.LeftClick(inv, context, slot);
			bool flag = ItemSlot.RightClick(inv, context, slot);
			if (!true)
			{
			}
			bool mouseLeftRelease = Main.mouseLeftRelease;
			if (!true)
			{
			}
			bool mouseLeft = Main.mouseLeft;
			Recipe.FindRecipes(false);
			ItemSlot.MouseHover(inv, context, slot);
		}

		// Token: 0x06003A8A RID: 14986 RVA: 0x00230960 File Offset: 0x0022EB60
		public static void OverrideHover(Item inv, int context = 0)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003A8B RID: 14987 RVA: 0x00230978 File Offset: 0x0022EB78
		public static bool isEquipLocked(int type)
		{
		}

		// Token: 0x06003A8C RID: 14988 RVA: 0x00230988 File Offset: 0x0022EB88
		public static void OverrideHover(Item[] inv, int context = 0, int slot = 0)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool notUsingGamepad = ItemSlot.NotUsingGamepad;
			bool disableLeftShiftTrashCan = ItemSlot.Options.DisableLeftShiftTrashCan;
			if (num == 0)
			{
			}
			bool controlInUse = ItemSlot.ControlInUse;
			bool disableQuickTrash = ItemSlot.Options.DisableQuickTrash;
			if (num == 0)
			{
			}
			bool shiftInUse = ItemSlot.ShiftInUse;
			if (num == 0)
			{
			}
			Player localPlayer = Main.LocalPlayer;
			if (num == 0)
			{
			}
			Player localPlayer2 = Main.LocalPlayer;
		}

		// Token: 0x06003A8D RID: 14989 RVA: 0x00230B28 File Offset: 0x0022ED28
		private static bool OverrideLeftClick(Item[] inv, int context = 0, int slot = 0)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Player localPlayer = Main.LocalPlayer;
			if (num == 0)
			{
			}
			Player localPlayer2 = Main.LocalPlayer;
			int cursorOverride = Main.cursorOverride;
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06003A8E RID: 14990 RVA: 0x00230C70 File Offset: 0x0022EE70
		public static bool IsMouseItem(Item[] slots, int index)
		{
			/*
An exception occurred when decompiling this method (06003A8E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.UI.ItemSlot::IsMouseItem(Terraria.Item[],System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_003B:
	stloc:int32(var_8_43, callgetter:int32(Main::get_mouseItemSourceIndex))
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

		// Token: 0x06003A8F RID: 14991 RVA: 0x00230CC4 File Offset: 0x0022EEC4
		public static void LeftClick(Item inv, int context = 0)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003A90 RID: 14992 RVA: 0x00230CDC File Offset: 0x0022EEDC
		public static void LeftClick(Item[] inv, int context = 0, int slot = 0)
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
			bool flag = ItemSlot.OverrideLeftClick(inv, context, slot);
			bool flag2 = ItemSlot.LeftClick_SellOrTrash(inv, context, slot);
			Item mouseItem = Main.mouseItem;
		}

		// Token: 0x06003A91 RID: 14993 RVA: 0x002316C4 File Offset: 0x0022F8C4
		private static bool DisableTrashing()
		{
			bool disableLeftShiftTrashCan = ItemSlot.Options.DisableLeftShiftTrashCan;
			if (!true)
			{
			}
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06003A92 RID: 14994 RVA: 0x002316E0 File Offset: 0x0022F8E0
		private static bool LeftClick_SellOrTrash(Item[] inv, int context, int slot)
		{
			if (!true)
			{
			}
			bool notUsingGamepad = ItemSlot.NotUsingGamepad;
			bool disableLeftShiftTrashCan = ItemSlot.Options.DisableLeftShiftTrashCan;
			bool disableQuickTrash = ItemSlot.Options.DisableQuickTrash;
			return ItemSlot.ControlInUse;
		}

		// Token: 0x06003A93 RID: 14995 RVA: 0x00231744 File Offset: 0x0022F944
		private static void SellOrTrash(Item[] inv, int context, int slot)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			if (num == 0)
			{
			}
			int npcShop = Main.npcShop;
			if (num == 0)
			{
				if (num == 0)
				{
				}
				int npcShop2 = Main.npcShop;
				if (num == 0)
				{
				}
				return;
			}
		}

		// Token: 0x06003A94 RID: 14996 RVA: 0x002317B4 File Offset: 0x0022F9B4
		private static string GetOverrideInstructions(Item[] inv, int context, int slot)
		{
			int whoAmI;
			do
			{
				if (!true)
				{
				}
				int myPlayer = Main.myPlayer;
				TileEntity tileEntity;
				if (tileEntity != null)
				{
				}
				int npcShop = Main.npcShop;
				int npcShop2 = Main.npcShop;
				if (inv == null)
				{
				}
				int myPlayer2 = Main.myPlayer;
				Microsoft.Xna.Framework.Vector2 position = inv.position;
				Player.ItemSpaceStatus itemSpaceStatus;
				bool canTakeItemToPersonalInventory = itemSpaceStatus.CanTakeItemToPersonalInventory;
				if (inv == null)
				{
				}
				whoAmI = inv.whoAmI;
				if (whoAmI == 0)
				{
				}
				int myPlayer3 = Main.myPlayer;
				Player.ItemSpaceStatus itemSpaceStatus2;
				bool canTakeItemToPersonalInventory2 = itemSpaceStatus2.CanTakeItemToPersonalInventory;
			}
			while (whoAmI == 0);
			return "";
		}

		// Token: 0x06003A95 RID: 14997 RVA: 0x00231858 File Offset: 0x0022FA58
		private static void UpdateChestOnServer(int context, int slot)
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
			if (num == 0)
			{
			}
			int myPlayer2 = Main.myPlayer;
			if (num == 0)
			{
			}
			int myPlayer3 = Main.myPlayer;
		}

		// Token: 0x06003A96 RID: 14998 RVA: 0x0023189C File Offset: 0x0022FA9C
		private static void PlaceItem(Item[] inv, Item item, int context = 0, int slot = -1, int keepStack = 0)
		{
			if (keepStack != 0)
			{
				return;
			}
			Microsoft.Xna.Framework.Vector2 position = item.position;
		}

		// Token: 0x06003A97 RID: 14999 RVA: 0x0023191C File Offset: 0x0022FB1C
		public static int PickItemMovementAction(Item[] inv, int context, int slot, Item checkItem, bool backwardCheck = false, int initialSlot = -1)
		{
			for (;;)
			{
				if (!true)
				{
				}
				int myPlayer = Main.myPlayer;
				Item mouseItem = Main.mouseItem;
				ChestUI.GetContainerUsageInfo(true, inv);
				if (!true)
				{
				}
				if (Main.mouseItem != null)
				{
					if (!true)
					{
					}
					if (Main.mouseItem.type == 0)
					{
					}
					if (Main.mouseItemSource != null)
					{
						break;
					}
				}
			}
			int mouseItemSourceContext = Main.mouseItemSourceContext;
			int mouseItemSourceContext2 = Main.mouseItemSourceContext;
			Item[] mouseItemSource = Main.mouseItemSource;
			int mouseItemSourceContext3 = Main.mouseItemSourceContext;
			int mouseItemSourceIndex = Main.mouseItemSourceIndex;
			if (mouseItemSourceContext3 == 0 || mouseItemSourceContext3 != 0)
			{
				return mouseItemSourceContext3;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06003A98 RID: 15000 RVA: 0x00231A9C File Offset: 0x0022FC9C
		public static void RightClick(Item inv, int context = 0)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003A99 RID: 15001 RVA: 0x00231AB4 File Offset: 0x0022FCB4
		public static bool RightClick(Item[] inv, int context = 0, int slot = 0)
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
			if (inv == null)
			{
			}
			bool mouseRight = Main.mouseRight;
			if (inv == null)
			{
			}
			bool mouseRightRelease = Main.mouseRightRelease;
			if (inv == null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06003A9A RID: 15002 RVA: 0x00231C1C File Offset: 0x0022FE1C
		public static void TakeOne(Item[] inv, int context, int slot)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Item mouseItem = Main.mouseItem;
			if (num == 0)
			{
			}
			int type = Main.mouseItem.type;
			if (type == 0)
			{
				if (type == 0)
				{
				}
				int stack = Main.mouseItem.stack;
				if (Main.mouseItem.maxStack == 0)
				{
				}
				int type2 = Main.mouseItem.type;
				if (type2 == 0)
				{
					return;
				}
			}
		}

		// Token: 0x06003A9B RID: 15003 RVA: 0x00231C9C File Offset: 0x0022FE9C
		public static void PickupItemIntoMouse(Item[] inv, int context, int slot, Player player)
		{
			if (!true)
			{
			}
			Item mouseItem = Main.mouseItem;
			if (mouseItem.type == 0)
			{
				Main.mouseItem = mouseItem.Clone();
				Item mouseItem2 = Main.mouseItem;
				int type = Main.mouseItem.type;
				mouseItem2.SetDefaults(type);
				Item mouseItem3 = Main.mouseItem;
				Item mouseItem4 = Main.mouseItem;
				return;
			}
			Item mouseItem5 = Main.mouseItem;
			int stack = mouseItem5.stack;
			mouseItem5.stack = stack;
		}

		// Token: 0x06003A9C RID: 15004 RVA: 0x00231DC0 File Offset: 0x0022FFC0
		public static void RefreshStackSplitCooldown()
		{
			if (!true)
			{
			}
			int stackSplit = Main.stackSplit;
			if (stackSplit != 0)
			{
				int stackDelay = Main.stackDelay;
				return;
			}
			Main.stackSplit = 30;
		}

		// Token: 0x06003A9D RID: 15005 RVA: 0x00231DF0 File Offset: 0x0022FFF0
		private static bool TryOpenContainer(Item item, Player player)
		{
			/*
An exception occurred when decompiling this method (06003A9D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.UI.ItemSlot::TryOpenContainer(Terraria.Item,Terraria.Player)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000B:
	stloc:int64(var_0_0C, ldc.i4:int64(0))
	call:void(Item::SetDefaults, ldloc:Item(item), ldloc:int64[exp:int32](var_0_0C))
	callsetter:int32(Main::set_stackSplit, ldc.i4:int32(30))
	callsetter:bool(Main::set_mouseRightRelease, ldc.i4:bool(0))
	stloc:int64(var_3_24, ldc.i4:int64(0))
	call:void(Recipe::FindRecipes, ldloc:int64[exp:bool](var_3_24))
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

		// Token: 0x06003A9E RID: 15006 RVA: 0x00231E7C File Offset: 0x0023007C
		private static bool SwapVanityEquip(Item[] inv, int context, int slot, Player player)
		{
			/*
An exception occurred when decompiling this method (06003A9E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.UI.ItemSlot::SwapVanityEquip(Terraria.Item[],System.Int32,System.Int32,Terraria.Player)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001F:
	brtrue(IL_001F, ldloc:class Terraria.Item[][exp:bool](inv))
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

		// Token: 0x06003A9F RID: 15007 RVA: 0x00231EAC File Offset: 0x002300AC
		private static bool TryPickupDyeToCursor(int context, Item[] inv, int slot, Player player)
		{
			if (!true)
			{
			}
			int stack = Main.mouseItem.stack;
			if (Main.mouseItem.maxStack == 0)
			{
			}
			int type = Main.mouseItem.type;
			if (type == 0)
			{
			}
			bool isAir = Main.mouseItem.IsAir;
			if (type == 0)
			{
			}
			int type2 = Main.mouseItem.type;
			bool isAir2 = Main.mouseItem.IsAir;
			bool isAir3 = Main.mouseItem.IsAir;
			if (type2 == 0)
			{
			}
			Item item;
			Main.mouseItem = item;
			Item mouseItem = Main.mouseItem;
			int stack2 = mouseItem.stack;
			mouseItem.stack = stack2;
			if (stack2 == 0)
			{
			}
			bool netClient = Main.NetClient;
			if (stack2 == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			if (type2 == 0)
			{
			}
			bool netClient2 = Main.NetClient;
			int myPlayer2 = Main.myPlayer;
			if (type2 == 0)
			{
				return;
			}
		}

		// Token: 0x06003AA0 RID: 15008 RVA: 0x00231F98 File Offset: 0x00230198
		private static bool TryItemSwap(Item item)
		{
			if (5323 == 0)
			{
			}
			ItemSlot.AfterItemSwap(0, 0);
			return false;
		}

		// Token: 0x06003AA1 RID: 15009 RVA: 0x00232040 File Offset: 0x00230240
		public static void AfterItemSwap(int oldType, int newType)
		{
			Main.stackSplit = 30;
			Main.mouseRightRelease = false;
			Recipe.FindRecipes(false);
		}

		// Token: 0x06003AA2 RID: 15010 RVA: 0x00232074 File Offset: 0x00230274
		private static void HandleShopSlot(Item[] inv, int slot, bool rightClickIsValid, bool leftClickIsValid)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int cursorOverride = Main.cursorOverride;
			if (num == 0)
			{
			}
			int npcShop = Main.npcShop;
			bool mouseRight = Main.mouseRight;
		}

		// Token: 0x06003AA3 RID: 15011 RVA: 0x002321D0 File Offset: 0x002303D0
		public static void Draw(SpriteBatch spriteBatch, Item inv, int context, Microsoft.Xna.Framework.Vector2 position)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003AA4 RID: 15012 RVA: 0x002321E0 File Offset: 0x002303E0
		public static void Draw(SpriteBatch spriteBatch, Item inv, int context, Microsoft.Xna.Framework.Vector2 position, Microsoft.Xna.Framework.Graphics.Color lightColor)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003AA5 RID: 15013 RVA: 0x002321F8 File Offset: 0x002303F8
		public static void SetCursorHighlight(bool hasFocus)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003AA6 RID: 15014 RVA: 0x00232208 File Offset: 0x00230408
		public static void SetSelectHighlight(bool hasFocus, float highlightScale = -1f)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003AA7 RID: 15015 RVA: 0x00232218 File Offset: 0x00230418
		public static void SetOverridenScale(float highlightScale)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003AA8 RID: 15016 RVA: 0x00232228 File Offset: 0x00230428
		public static void Draw(SpriteBatch spriteBatch, Item[] inv, int context, int slot, Microsoft.Xna.Framework.Vector2 position)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003AA9 RID: 15017 RVA: 0x00232238 File Offset: 0x00230438
		public static void Draw(SpriteBatch spriteBatch, Item[] inv, int context, int slot, Microsoft.Xna.Framework.Vector2 position, Microsoft.Xna.Framework.Graphics.Color lightColor)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003AAA RID: 15018 RVA: 0x00232248 File Offset: 0x00230448
		public static void Draw(SpriteBatch spriteBatch, Item[] inv, int context, int slot, Microsoft.Xna.Framework.Vector2 position, Microsoft.Xna.Framework.Graphics.Color lightColor, Microsoft.Xna.Framework.Graphics.Color backColor)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			float inventoryScale = Main.inventoryScale;
			if (num == 0)
			{
			}
			bool highlightThingsForMouse = PlayerInput.SettingsForUI.HighlightThingsForMouse;
			bool highlightNewItems = ItemSlot.Options.HighlightNewItems;
			int num2;
			if (context != 0)
			{
				if (context == 0)
				{
				}
				if (17279 == 0)
				{
				}
				num2 = 2000;
				if (num2 == 0)
				{
				}
				return;
			}
			if (context == 0)
			{
				if (num2 == 0)
				{
				}
				if (num2 == 0)
				{
				}
				return;
			}
		}

		// Token: 0x06003AAB RID: 15019 RVA: 0x002326B0 File Offset: 0x002308B0
		public static Microsoft.Xna.Framework.Graphics.Color GetColorByLoadout(int slot, int context)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Player localPlayer = Main.LocalPlayer;
			int currentLoadoutIndex = localPlayer.CurrentLoadoutIndex;
			if (localPlayer == null)
			{
			}
			if (localPlayer == null)
			{
				return;
			}
		}

		// Token: 0x06003AAC RID: 15020 RVA: 0x002326E0 File Offset: 0x002308E0
		public static Microsoft.Xna.Framework.Graphics.Color GetHighlightColorByLoadout(int slot, int context)
		{
			/*
An exception occurred when decompiling this method (06003AAC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Color Terraria.UI.ItemSlot::GetHighlightColorByLoadout(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_1_0F, ldfld:int32(Player::CurrentLoadoutIndex, callgetter:Player(Main::get_LocalPlayer)))
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

		// Token: 0x06003AAD RID: 15021 RVA: 0x002326FC File Offset: 0x002308FC
		public static void RecordLoadoutChange()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003AAE RID: 15022 RVA: 0x0023270C File Offset: 0x0023090C
		public static bool TryGetSlotColor(int loadoutIndex, int context, [Out] Microsoft.Xna.Framework.Graphics.Color color)
		{
			/*
An exception occurred when decompiling this method (06003AAE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.UI.ItemSlot::TryGetSlotColor(System.Int32,System.Int32,Microsoft.Xna.Framework.Graphics.Color)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_01, ldc.i4:int32(1))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](context), ldloc:int32(var_0_01))
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

		// Token: 0x06003AAF RID: 15023 RVA: 0x00232728 File Offset: 0x00230928
		public static bool TryGetHighlightedSlotColor(int loadoutIndex, int context, [Out] Microsoft.Xna.Framework.Graphics.Color color)
		{
			/*
An exception occurred when decompiling this method (06003AAF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.UI.ItemSlot::TryGetHighlightedSlotColor(System.Int32,System.Int32,Microsoft.Xna.Framework.Graphics.Color)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_01, ldc.i4:int32(1))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](context), ldloc:int32(var_0_01))
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

		// Token: 0x06003AB0 RID: 15024 RVA: 0x000021DB File Offset: 0x000003DB
		public static float ShiftHueByLoadout(float hue, int loadoutIndex)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003AB1 RID: 15025 RVA: 0x00232744 File Offset: 0x00230944
		public static Microsoft.Xna.Framework.Graphics.Color GetLoadoutColor(int loadoutIndex)
		{
			/*
An exception occurred when decompiling this method (06003AB1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Color Terraria.UI.ItemSlot::GetLoadoutColor(System.Int32)

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

		// Token: 0x06003AB2 RID: 15026 RVA: 0x00232754 File Offset: 0x00230954
		public static float DrawItemIcon(Item item, int context, SpriteBatch spriteBatch, Microsoft.Xna.Framework.Vector2 screenPositionForItemCenter, float scale, float sizeLimit, Microsoft.Xna.Framework.Graphics.Color environmentColor)
		{
			/*
An exception occurred when decompiling this method (06003AB2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.UI.ItemSlot::DrawItemIcon(Terraria.Item,System.Int32,Microsoft.Xna.Framework.Graphics.SpriteBatch,Microsoft.Xna.Framework.Vector2,System.Single,System.Single,Microsoft.Xna.Framework.Graphics.Color)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0032:
	brtrue(IL_0000, ldloc:int32[exp:bool](var_8_1D))
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

		// Token: 0x06003AB3 RID: 15027 RVA: 0x00232798 File Offset: 0x00230998
		public static void DrawItem_GetColorAndScale(Item item, float scale, Microsoft.Xna.Framework.Graphics.Color currentWhite, float sizeLimit, Rectangle frame, [Out] Microsoft.Xna.Framework.Graphics.Color itemLight, [Out] float finalDrawScale)
		{
			if (16256 == 0)
			{
			}
			int width = frame.Width;
		}

		// Token: 0x06003AB4 RID: 15028 RVA: 0x002327B8 File Offset: 0x002309B8
		public static void MouseHover(int context = 0)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003AB5 RID: 15029 RVA: 0x002327D0 File Offset: 0x002309D0
		public static void MouseHover(Item inv, int context = 0)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003AB6 RID: 15030 RVA: 0x002327E8 File Offset: 0x002309E8
		public static void UpdateTooltipButton(TransactionButton_Layout button)
		{
			global::Cursor cursor;
			if (cursor != null)
			{
			}
		}

		// Token: 0x06003AB7 RID: 15031 RVA: 0x002327F8 File Offset: 0x002309F8
		public static void UpdateTooltipContext(int context, int slot)
		{
			global::Cursor cursor;
			if (cursor != null)
			{
			}
		}

		// Token: 0x06003AB8 RID: 15032 RVA: 0x00232808 File Offset: 0x00230A08
		public static void MouseHover(Item[] inv, int context = 0, int slot = 0)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			string text2;
			string text3;
			string text = text2 + " (" + text3 + ")";
			Item item;
			item.tooltipContext = context;
			int num2 = 1;
			item.wornArmor = num2 != 0;
		}

		// Token: 0x06003AB9 RID: 15033 RVA: 0x00232898 File Offset: 0x00230A98
		public static void SwapEquip(Item inv, int context = 0)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003ABA RID: 15034 RVA: 0x002328B0 File Offset: 0x00230AB0
		public static bool SwapEquip(Item[] inv, int context, int slot)
		{
			int myPlayer;
			Item item2;
			int mountType3;
			int buffType2;
			for (;;)
			{
				if (!true)
				{
				}
				myPlayer = Main.myPlayer;
				if (myPlayer != 0)
				{
					if (myPlayer == 0)
					{
					}
					Item item;
					if (item != null && item == null)
					{
						goto IL_00F5;
					}
					if (myPlayer == 0)
					{
						goto IL_00DE;
					}
					if (myPlayer == 0)
					{
					}
				}
				if (myPlayer == 0)
				{
				}
				if (myPlayer != 0)
				{
					break;
				}
				int mountType = item2.mountType;
				int num;
				if (num == 0)
				{
					int mountType2 = item2.mountType;
				}
				if (num == 0)
				{
					goto IL_00A3;
				}
				if (num == 0)
				{
					mountType3 = item2.mountType;
				}
				if (mountType3 != 0)
				{
					goto Block_9;
				}
				int buffType = item2.buffType;
				if (num == 0)
				{
					buffType2 = item2.buffType;
				}
				if (num != 0)
				{
					goto Block_11;
				}
			}
			if (myPlayer == 0)
			{
			}
			if (item2 != null && item2 == null)
			{
				goto IL_00F5;
			}
			if (myPlayer != 0)
			{
				if (myPlayer == 0)
				{
				}
				int num = 2;
				return false;
			}
			goto IL_00DE;
			Block_9:
			if (mountType3 == 0)
			{
			}
			return false;
			Block_11:
			if (buffType2 == 0)
			{
			}
			Item item3;
			if (item3 != null && item3 == null)
			{
				goto IL_00F5;
			}
			IL_00A3:
			Item item4;
			if (item4 != null && item4 == null)
			{
				goto IL_00F5;
			}
			int buffType3;
			if (2 == 0)
			{
				buffType3 = item4.buffType;
			}
			if (buffType3 == 0 || buffType3 == 0)
			{
			}
			if (buffType3 == 0)
			{
			}
			Item item5 = ItemSlot.ArmorSwap(item4, false);
			if (item5 != null && item5 == null)
			{
				goto IL_00F5;
			}
			bool accessory = item4.accessory;
			IL_00DE:
			Recipe.FindRecipes(false);
			bool netClient = Main.NetClient;
			IL_00F5:
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06003ABB RID: 15035 RVA: 0x002329B8 File Offset: 0x00230BB8
		public static bool Equippable(Item inv, int context = 0)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06003ABC RID: 15036 RVA: 0x002329D0 File Offset: 0x00230BD0
		public static bool Equippable(Item[] inv, int context, int slot)
		{
			/*
An exception occurred when decompiling this method (06003ABC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.UI.ItemSlot::Equippable(Terraria.Item[],System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_1_0A, callgetter:int32(Main::get_myPlayer))
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

		// Token: 0x06003ABD RID: 15037 RVA: 0x002329EC File Offset: 0x00230BEC
		public static bool IsMiscEquipment(Item item)
		{
			/*
An exception occurred when decompiling this method (06003ABD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.UI.ItemSlot::IsMiscEquipment(Terraria.Item)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	brtrue(IL_0000, ldloc:int32[exp:bool](var_0_01))
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

		// Token: 0x06003ABE RID: 15038 RVA: 0x00232A04 File Offset: 0x00230C04
		public static bool AccCheck(Item[] itemCollection, Item item, int slot)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06003ABF RID: 15039 RVA: 0x00232A1C File Offset: 0x00230C1C
		private static Item DyeSwap(Item item, [Out] bool success)
		{
			int num = 1;
			if (num != 0)
			{
				if (num == 0)
				{
				}
				int myPlayer = Main.myPlayer;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				int num2 = 9;
				if (num == 0)
				{
				}
				Item item2;
				if (item2 == null || item2 != null)
				{
					if (num2 == 0)
					{
					}
					Recipe.FindRecipes(false);
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06003AC0 RID: 15040 RVA: 0x00232A68 File Offset: 0x00230C68
		private static Item ArmorSwap(Item item, [Out] bool success)
		{
			int num = 1;
			if (num != 0)
			{
				if (num == 0)
				{
				}
				int myPlayer = Main.myPlayer;
				int num2 = 10;
				Item item2;
				if (item2 != null && item2 == null)
				{
					goto IL_0054;
				}
				if (num2 == 0)
				{
				}
				Recipe.FindRecipes(false);
			}
			bool flag;
			while (!flag)
			{
			}
			if (flag)
			{
			}
			if (!flag)
			{
			}
			if (!flag)
			{
			}
			if (!flag)
			{
			}
			if (!flag)
			{
			}
			if (!flag)
			{
			}
			Item item3;
			if (item3 == null || item3 != null)
			{
			}
			IL_0054:
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06003AC1 RID: 15041 RVA: 0x00232AD0 File Offset: 0x00230CD0
		private static Item EquipSwap(Item item, Item[] inv, int slot, [Out] bool success)
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
			Item item2;
			if (item2 == null || item2 != null)
			{
				int num = 1;
				Recipe.FindRecipes(false);
				slot.m_value = num;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06003AC2 RID: 15042 RVA: 0x00232B08 File Offset: 0x00230D08
		public static void DrawMoney(SpriteBatch sb, string text, float shopx, float shopy, int[] coinsArray, bool horizontal = false, [Optional] SpriteBatch textSb)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (255 == 0)
			{
			}
			if (!true)
			{
			}
			int num2 = 16968;
			if (!false)
			{
			}
			if (num2 == 0)
			{
			}
			int num3 = 16948;
			if (num3 == 0)
			{
			}
			if (num3 != 0)
			{
				return;
			}
		}

		// Token: 0x06003AC3 RID: 15043 RVA: 0x00232B6C File Offset: 0x00230D6C
		public static void DrawCost(SpriteBatch sb, float shopx, float shopy, long cost, [Optional] SpriteBatch textSb)
		{
			int[] array = Utils.CoinsSplit(cost);
		}

		// Token: 0x06003AC4 RID: 15044 RVA: 0x00232B80 File Offset: 0x00230D80
		public static void DrawSavings(SpriteBatch sb, Panel_Layout savingsBacking, float shopx, float shopy, Microsoft.Xna.Framework.Vector2 savings1IconOffset, Microsoft.Xna.Framework.Vector2 savings2Offset, Microsoft.Xna.Framework.Vector2 savings3Offset, Microsoft.Xna.Framework.Vector2 savings4Offset, bool horizontal = false, [Optional] SpriteBatch textSb)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			if (num == 0)
			{
			}
			int npcShop = Main.npcShop;
			if (!true)
			{
			}
			long currencyCount = CustomCurrencyManager.GetCurrencyCount(-1073741824);
			if (-1073741824 == 0)
			{
			}
			int npcShop2 = Main.npcShop;
		}

		// Token: 0x06003AC5 RID: 15045 RVA: 0x00232BF8 File Offset: 0x00230DF8
		public static void DrawSavings(SpriteBatch sb, float shopx, float shopy, bool horizontal = false, [Optional] SpriteBatch textSb)
		{
			if (!true)
			{
			}
			if (Main.myPlayer == 0)
			{
			}
		}

		// Token: 0x06003AC6 RID: 15046 RVA: 0x00232C40 File Offset: 0x00230E40
		public static void GetItemLight(Microsoft.Xna.Framework.Graphics.Color currentColor, Item item, bool outInTheWorld = false)
		{
			if (16256 == 0)
			{
			}
		}

		// Token: 0x06003AC7 RID: 15047 RVA: 0x00232C54 File Offset: 0x00230E54
		public static void GetItemLight(Microsoft.Xna.Framework.Graphics.Color currentColor, int type, bool outInTheWorld = false)
		{
			if (16256 == 0)
			{
			}
		}

		// Token: 0x06003AC8 RID: 15048 RVA: 0x00232C68 File Offset: 0x00230E68
		public static void GetItemLight(Microsoft.Xna.Framework.Graphics.Color currentColor, float scale, Item item, bool outInTheWorld = false)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003AC9 RID: 15049 RVA: 0x00232C78 File Offset: 0x00230E78
		public static Microsoft.Xna.Framework.Graphics.Color GetItemLight(Microsoft.Xna.Framework.Graphics.Color currentColor, float scale, int type, bool outInTheWorld = false)
		{
			/*
An exception occurred when decompiling this method (06003AC9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Color Terraria.UI.ItemSlot::GetItemLight(Microsoft.Xna.Framework.Graphics.Color,System.Single,System.Int32,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0083:
	stloc:uint8(var_9_89, ldfld:uint8(Color::R, ldloc:Color[exp:valuetype Microsoft.Xna.Framework.Graphics.Color&](currentColor)))
	stloc:uint8(var_10_91, ldfld:uint8(Color::G, ldloc:Color[exp:valuetype Microsoft.Xna.Framework.Graphics.Color&](currentColor)))
	stloc:uint8(var_11_99, ldfld:uint8(Color::B, ldloc:Color[exp:valuetype Microsoft.Xna.Framework.Graphics.Color&](currentColor)))
	stfld:uint8(Color::R, ldloc:Color[exp:valuetype Microsoft.Xna.Framework.Graphics.Color&](currentColor), ldloc:int32[exp:uint8](var_8_7D))
	stfld:uint8(Color::G, ldloc:Color[exp:valuetype Microsoft.Xna.Framework.Graphics.Color&](currentColor), ldloc:int32[exp:uint8](var_7_5A))
	stfld:uint8(Color::B, ldloc:Color[exp:valuetype Microsoft.Xna.Framework.Graphics.Color&](currentColor), ldloc:int32[exp:uint8](var_8_7D))
	stfld:uint8(Color::A, ldloc:Color[exp:valuetype Microsoft.Xna.Framework.Graphics.Color&](currentColor), ldloc:int32[exp:uint8](var_8_7D))
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

		// Token: 0x06003ACA RID: 15050 RVA: 0x00232D40 File Offset: 0x00230F40
		public static void DrawRadialCircular(SpriteBatch sb, Microsoft.Xna.Framework.Vector2 position, Player.SelectionRadial radial, Item[] items)
		{
			if (!true)
			{
			}
			bool usingGamepad = PlayerInput.UsingGamepad;
			bool radialHotbar = PlayerInput.Triggers.Current.RadialHotbar;
		}

		// Token: 0x06003ACB RID: 15051 RVA: 0x00232DBC File Offset: 0x00230FBC
		public static void DrawRadialQuicks(SpriteBatch sb, Microsoft.Xna.Framework.Vector2 position)
		{
			if (!true)
			{
			}
			bool usingGamepad = PlayerInput.UsingGamepad;
			bool radialQuickbar = PlayerInput.Triggers.Current.RadialQuickbar;
		}

		// Token: 0x06003ACC RID: 15052 RVA: 0x00232E6C File Offset: 0x0023106C
		public static void DrawRadialDpad(SpriteBatch sb, Microsoft.Xna.Framework.Vector2 position)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool usingGamepad = PlayerInput.UsingGamepad;
			if (num == 0)
			{
			}
			int num2 = 1;
			if (num2 == 0)
			{
			}
			if (num2 == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			if (num2 == 0)
			{
			}
			if (50047 == 0)
			{
			}
			float inventoryScale = Main.inventoryScale;
			float inventoryScale2 = Main.inventoryScale;
		}

		// Token: 0x06003ACD RID: 15053 RVA: 0x00232EC8 File Offset: 0x002310C8
		public static bool IsABuildingItem(Item item)
		{
		}

		// Token: 0x06003ACE RID: 15054 RVA: 0x00232ED8 File Offset: 0x002310D8
		public static void SelectEquipPage(Item item)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool isAir = item.IsAir;
			if (num == 0)
			{
			}
			if (item.mountType == 0)
			{
			}
		}

		// Token: 0x06003ACF RID: 15055 RVA: 0x00232F54 File Offset: 0x00231154
		public ItemSlot()
		{
		}

		// Token: 0x04007A74 RID: 31348
		public static bool DrawGoldBGForCraftingMaterial;

		// Token: 0x04007A75 RID: 31349
		public static bool ShiftForcedOn;

		// Token: 0x04007A76 RID: 31350
		public static float[] inventoryGlowHue;

		// Token: 0x04007A77 RID: 31351
		public static int[] inventoryGlowTime;

		// Token: 0x04007A78 RID: 31352
		private static float[] inventoryGlowHueChest;

		// Token: 0x04007A79 RID: 31353
		private static int[] inventoryGlowTimeChest;

		// Token: 0x04007A7A RID: 31354
		private static int _customCurrencyForSavings;

		// Token: 0x04007A7B RID: 31355
		private static int additionalThrowVelocity;

		// Token: 0x04007A7C RID: 31356
		public static bool DuplicationMode;

		// Token: 0x04007A7D RID: 31357
		private static int dyeSlotCount;

		// Token: 0x04007A7E RID: 31358
		private static int accSlotToSwapTo;

		// Token: 0x04007A7F RID: 31359
		public static float CircularRadialOpacity;

		// Token: 0x04007A80 RID: 31360
		public static float QuicksRadialOpacity;

		// Token: 0x04007A81 RID: 31361
		private static Item[] singleSlotArray;

		// Token: 0x04007A82 RID: 31362
		private static bool[] canFavoriteAt;

		// Token: 0x04007A83 RID: 31363
		private static bool[] canShareAt;

		// Token: 0x04007A84 RID: 31364
		[CompilerGenerated]
		private static ItemSlot.ItemTransferEvent OnItemTransferred;

		// Token: 0x04007A85 RID: 31365
		public static bool forceClearGlowsOnChest;

		// Token: 0x04007A86 RID: 31366
		private static Item dummyItem;

		// Token: 0x04007A87 RID: 31367
		private static bool CursorHighlight;

		// Token: 0x04007A88 RID: 31368
		private static bool SelectHighlight;

		// Token: 0x04007A89 RID: 31369
		private static float HighlightScale;

		// Token: 0x04007A8A RID: 31370
		private static float ForceRenderScale;

		// Token: 0x04007A8B RID: 31371
		private static double _lastTimeForVisualEffectsThatLoadoutWasChanged;

		// Token: 0x04007A8C RID: 31372
		private static Microsoft.Xna.Framework.Graphics.Color[,] LoadoutSlotColors;

		// Token: 0x04007A8D RID: 31373
		private static Microsoft.Xna.Framework.Graphics.Color[,] LoadoutHighlightSlotColors;

		// Token: 0x04007A8E RID: 31374
		private static int LastHoverContext;

		// Token: 0x04007A8F RID: 31375
		private static int LastHoverSlot;

		// Token: 0x04007A90 RID: 31376
		private static TransactionButton_Layout LastHoverButton;

		// Token: 0x04007A91 RID: 31377
		private static int LastButtonFrame;

		// Token: 0x04007A92 RID: 31378
		private static Microsoft.Xna.Framework.Vector2 defenderTextOffset;

		// Token: 0x04007A93 RID: 31379
		private static Microsoft.Xna.Framework.Vector2 defenderPigOffset;

		// Token: 0x020006D3 RID: 1747
		public class Options
		{
			// Token: 0x17000753 RID: 1875
			// (get) Token: 0x06003AD0 RID: 15056 RVA: 0x000021DB File Offset: 0x000003DB
			// (set) Token: 0x06003AD1 RID: 15057 RVA: 0x00232F6C File Offset: 0x0023116C
			public static bool DisableLeftShiftTrashCan
			{
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
				set
				{
				}
			}

			// Token: 0x17000754 RID: 1876
			// (get) Token: 0x06003AD2 RID: 15058 RVA: 0x000021DB File Offset: 0x000003DB
			// (set) Token: 0x06003AD3 RID: 15059 RVA: 0x00232F7C File Offset: 0x0023117C
			public static bool HighlightNewItems
			{
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
				set
				{
				}
			}

			// Token: 0x17000755 RID: 1877
			// (get) Token: 0x06003AD4 RID: 15060 RVA: 0x000021DB File Offset: 0x000003DB
			// (set) Token: 0x06003AD5 RID: 15061 RVA: 0x00232F8C File Offset: 0x0023118C
			public static bool DisableQuickTrash
			{
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
				set
				{
				}
			}

			// Token: 0x06003AD6 RID: 15062 RVA: 0x00232F9C File Offset: 0x0023119C
			public Options()
			{
			}
		}

		// Token: 0x020006D4 RID: 1748
		public enum GUIFakeTooltipContext
		{
			// Token: 0x04007A95 RID: 31381
			DefenseIcon = 36,
			// Token: 0x04007A96 RID: 31382
			HousingMenu,
			// Token: 0x04007A97 RID: 31383
			PVPMenu,
			// Token: 0x04007A98 RID: 31384
			ItemDuplication,
			// Token: 0x04007A99 RID: 31385
			CraftGuide,
			// Token: 0x04007A9A RID: 31386
			BestiaryDrop,
			// Token: 0x04007A9B RID: 31387
			Reforge,
			// Token: 0x04007A9C RID: 31388
			Team,
			// Token: 0x04007A9D RID: 31389
			AccessoryInfo,
			// Token: 0x04007A9E RID: 31390
			BuilderAccessories,
			// Token: 0x04007A9F RID: 31391
			Hotbar,
			// Token: 0x04007AA0 RID: 31392
			Buffs,
			// Token: 0x04007AA1 RID: 31393
			Loadout
		}

		// Token: 0x020006D5 RID: 1749
		public class Context
		{
			// Token: 0x06003AD7 RID: 15063 RVA: 0x00232FB0 File Offset: 0x002311B0
			public Context()
			{
			}

			// Token: 0x04007AA2 RID: 31394
			public const int InventoryItem = 0;

			// Token: 0x04007AA3 RID: 31395
			public const int InventoryCoin = 1;

			// Token: 0x04007AA4 RID: 31396
			public const int InventoryAmmo = 2;

			// Token: 0x04007AA5 RID: 31397
			public const int ChestItem = 3;

			// Token: 0x04007AA6 RID: 31398
			public const int BankItem = 4;

			// Token: 0x04007AA7 RID: 31399
			public const int PrefixItem = 5;

			// Token: 0x04007AA8 RID: 31400
			public const int TrashItem = 6;

			// Token: 0x04007AA9 RID: 31401
			public const int GuideItem = 7;

			// Token: 0x04007AAA RID: 31402
			public const int EquipArmor = 8;

			// Token: 0x04007AAB RID: 31403
			public const int EquipArmorVanity = 9;

			// Token: 0x04007AAC RID: 31404
			public const int EquipAccessory = 10;

			// Token: 0x04007AAD RID: 31405
			public const int EquipAccessoryVanity = 11;

			// Token: 0x04007AAE RID: 31406
			public const int EquipDye = 12;

			// Token: 0x04007AAF RID: 31407
			public const int HotbarItem = 13;

			// Token: 0x04007AB0 RID: 31408
			public const int ChatItem = 14;

			// Token: 0x04007AB1 RID: 31409
			public const int ShopItem = 15;

			// Token: 0x04007AB2 RID: 31410
			public const int EquipGrapple = 16;

			// Token: 0x04007AB3 RID: 31411
			public const int EquipMount = 17;

			// Token: 0x04007AB4 RID: 31412
			public const int EquipMinecart = 18;

			// Token: 0x04007AB5 RID: 31413
			public const int EquipPet = 19;

			// Token: 0x04007AB6 RID: 31414
			public const int EquipLight = 20;

			// Token: 0x04007AB7 RID: 31415
			public const int MouseItem = 21;

			// Token: 0x04007AB8 RID: 31416
			public const int CraftingMaterial = 22;

			// Token: 0x04007AB9 RID: 31417
			public const int DisplayDollArmor = 23;

			// Token: 0x04007ABA RID: 31418
			public const int DisplayDollAccessory = 24;

			// Token: 0x04007ABB RID: 31419
			public const int DisplayDollDye = 25;

			// Token: 0x04007ABC RID: 31420
			public const int HatRackHat = 26;

			// Token: 0x04007ABD RID: 31421
			public const int HatRackDye = 27;

			// Token: 0x04007ABE RID: 31422
			public const int GoldDebug = 28;

			// Token: 0x04007ABF RID: 31423
			public const int CreativeInfinite = 29;

			// Token: 0x04007AC0 RID: 31424
			public const int CreativeSacrifice = 30;

			// Token: 0x04007AC1 RID: 31425
			public const int InWorld = 31;

			// Token: 0x04007AC2 RID: 31426
			public const int VoidItem = 32;

			// Token: 0x04007AC3 RID: 31427
			public const int EquipMiscDye = 33;

			// Token: 0x04007AC4 RID: 31428
			public const int CreativeResearch = 34;

			// Token: 0x04007AC5 RID: 31429
			public const int RubbleMaker = 35;

			// Token: 0x04007AC6 RID: 31430
			public const int Count = 36;
		}

		// Token: 0x020006D6 RID: 1750
		public struct ItemTransferInfo
		{
			// Token: 0x06003AD8 RID: 15064 RVA: 0x00232FC4 File Offset: 0x002311C4
			public ItemTransferInfo(Item itemAfter, int fromContext, int toContext, int transferAmount = 0)
			{
				int type = itemAfter.type;
				this.ItemType = type;
				int stack = itemAfter.stack;
				this.ToContext = toContext;
				this.TransferAmount = stack;
				this.ToContext = fromContext;
			}

			// Token: 0x04007AC7 RID: 31431
			public int ItemType;

			// Token: 0x04007AC8 RID: 31432
			public int TransferAmount;

			// Token: 0x04007AC9 RID: 31433
			public int FromContenxt;

			// Token: 0x04007ACA RID: 31434
			public int ToContext;
		}

		// Token: 0x020006D7 RID: 1751
		public sealed class ItemTransferEvent : MulticastDelegate
		{
			// Token: 0x06003AD9 RID: 15065 RVA: 0x00232FFC File Offset: 0x002311FC
			public ItemTransferEvent(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06003ADA RID: 15066 RVA: 0x00233050 File Offset: 0x00231250
			public void Invoke(ItemSlot.ItemTransferInfo info)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}

			// Token: 0x06003ADB RID: 15067 RVA: 0x000021DB File Offset: 0x000003DB
			public IAsyncResult BeginInvoke(ItemSlot.ItemTransferInfo info, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06003ADC RID: 15068 RVA: 0x00233074 File Offset: 0x00231274
			public void EndInvoke(IAsyncResult result)
			{
			}
		}
	}
}
