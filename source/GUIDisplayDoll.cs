using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Tile_Entities;
using Terraria.UI;

// Token: 0x0200013A RID: 314
public class GUIDisplayDoll
{
	// Token: 0x06000847 RID: 2119 RVA: 0x00021518 File Offset: 0x0001F718
	public void LoadPageRegion()
	{
		!0 instance = PageControllerLayoutDefinition.Instance;
		if (!true)
		{
		}
		!0 instance2 = PageControllerLayoutDefinition.Instance;
		if (!true)
		{
		}
		Rectangle rectangle;
		ControlAnchor.PageContentRegion = rectangle;
	}

	// Token: 0x06000848 RID: 2120 RVA: 0x00021540 File Offset: 0x0001F740
	public float ArmourScale(int index)
	{
		/*
An exception occurred when decompiling this method (06000848)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUIDisplayDoll::ArmourScale(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:!0(var_0_05, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
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

	// Token: 0x06000849 RID: 2121 RVA: 0x00021554 File Offset: 0x0001F754
	public float ArmourDyeScale(int index)
	{
		/*
An exception occurred when decompiling this method (06000849)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUIDisplayDoll::ArmourDyeScale(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:!0(var_0_05, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
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

	// Token: 0x0600084A RID: 2122 RVA: 0x00021568 File Offset: 0x0001F768
	private void ItemOver(Item[] inv, int index, GUIDisplayDoll.EquipmentItemType equipmentType, int itemContext, int itemDragStart)
	{
		this.cursorOver = index;
		this.itemOver = index;
		this.itemType = equipmentType;
		this.UnequipButtonScale = (float)index;
		this.itemOver = index;
		this.itemType = equipmentType;
		this.UnequipButtonScale = (float)index;
	}

	// Token: 0x0600084B RID: 2123 RVA: 0x00021674 File Offset: 0x0001F874
	public void ArmourOver(int index)
	{
		Item[] items = this.DisplayDoll._items;
	}

	// Token: 0x0600084C RID: 2124 RVA: 0x00021690 File Offset: 0x0001F890
	public void ArmourDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
		int num = this.cursorOver;
		if (!true)
		{
		}
		if (this.itemOver == 0)
		{
		}
		!0 instance = PageControllerLayoutDefinition.Instance;
		ItemSlot.SetSelectHighlight(true, scale);
	}

	// Token: 0x0600084D RID: 2125 RVA: 0x0002177C File Offset: 0x0001F97C
	public void ArmourDyeOver(int index)
	{
		Item[] dyes = this.DisplayDoll._dyes;
	}

	// Token: 0x0600084E RID: 2126 RVA: 0x00021798 File Offset: 0x0001F998
	public void ArmourDyeDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
		int num = this.cursorOver;
		if (!true)
		{
		}
		if (this.itemOver == 0)
		{
		}
		!0 instance = PageControllerLayoutDefinition.Instance;
		ItemSlot.SetSelectHighlight(true, scale);
	}

	// Token: 0x0600084F RID: 2127 RVA: 0x00021874 File Offset: 0x0001FA74
	public int CanBeEquipedAccessory(Item checkItem)
	{
		for (;;)
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
			TileEntity tileEntity;
			long num;
			if (tileEntity != null)
			{
				num = 0L;
			}
			this.DisplayDoll = num;
			if (num != 0L)
			{
				return;
			}
		}
	}

	// Token: 0x06000850 RID: 2128 RVA: 0x000218A4 File Offset: 0x0001FAA4
	public bool CanBeEquiped(Item checkItem)
	{
		int headSlot = checkItem.headSlot;
		int bodySlot = checkItem.bodySlot;
		int legSlot = checkItem.legSlot;
		return true;
	}

	// Token: 0x06000851 RID: 2129 RVA: 0x000218D0 File Offset: 0x0001FAD0
	public bool CanBeStored(Item checkItem)
	{
		int headSlot = checkItem.headSlot;
		int bodySlot = checkItem.bodySlot;
		int legSlot = checkItem.legSlot;
		if (checkItem.accessory)
		{
			return true;
		}
		byte dye = checkItem.dye;
		return true;
	}

	// Token: 0x06000852 RID: 2130 RVA: 0x00021904 File Offset: 0x0001FB04
	private bool CanBeStored(int context, Item checkItem, int slot)
	{
		if (slot == 0)
		{
			int headSlot = checkItem.headSlot;
		}
		int bodySlot = checkItem.bodySlot;
		int stack = checkItem.stack;
		byte dye = checkItem.dye;
		bool flag;
		if (checkItem.accessory)
		{
			flag = ItemSlot.AccCheck(this.DisplayDoll._items, checkItem, slot);
		}
		return flag;
	}

	// Token: 0x06000853 RID: 2131 RVA: 0x0002195C File Offset: 0x0001FB5C
	private void DrawArmour()
	{
		!0 instance = PageControllerLayoutDefinition.Instance;
		if (!true)
		{
		}
		int num = this.itemDragStartArmour;
		if (num == 0)
		{
		}
		bool mouseLeft = Main.mouseLeft;
		if (num == 0)
		{
		}
		if (Main.mouseItem != null)
		{
			if (num == 0)
			{
			}
			int type = Main.mouseItem.type;
			if (type != 0)
			{
				this.itemDragStartArmour = type;
				!0 instance2 = PageControllerLayoutDefinition.Instance;
				int num2 = this.itemDragStartArmourDye;
				if (num2 == 0)
				{
				}
				bool mouseLeft2 = Main.mouseLeft;
				if (num2 == 0)
				{
				}
				if (Main.mouseItem != null)
				{
					if (num2 == 0)
					{
					}
					int type2 = Main.mouseItem.type;
					if (type2 != 0)
					{
						this.itemDragStartArmourDye = type2;
						return;
					}
				}
				int num3 = this.itemDragStartArmourDye;
				int num4 = this.itemOver;
				ItemSlot.LeftClick(this.DisplayDoll._dyes, 25, num3);
				return;
			}
		}
		int num5 = this.itemDragStartArmour;
		int num6 = this.itemOver;
		ItemSlot.LeftClick(this.DisplayDoll._items, 23, num5);
	}

	// Token: 0x06000854 RID: 2132 RVA: 0x00021A44 File Offset: 0x0001FC44
	public float AccessoryScale(int index)
	{
		/*
An exception occurred when decompiling this method (06000854)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUIDisplayDoll::AccessoryScale(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:!0(var_0_05, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
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

	// Token: 0x06000855 RID: 2133 RVA: 0x00021A58 File Offset: 0x0001FC58
	public float AccessoryDyeScale(int index)
	{
		/*
An exception occurred when decompiling this method (06000855)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUIDisplayDoll::AccessoryDyeScale(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:!0(var_0_05, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
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

	// Token: 0x06000856 RID: 2134 RVA: 0x00021A6C File Offset: 0x0001FC6C
	public void AccessoryOver(int index)
	{
		Item[] items = this.DisplayDoll._items;
	}

	// Token: 0x06000857 RID: 2135 RVA: 0x00021A88 File Offset: 0x0001FC88
	public void AccessoryDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
		int num = this.cursorOver;
		if (!true)
		{
		}
		if (this.itemOver == 0)
		{
		}
		!0 instance = PageControllerLayoutDefinition.Instance;
		ItemSlot.SetSelectHighlight(true, scale);
	}

	// Token: 0x06000858 RID: 2136 RVA: 0x00021B80 File Offset: 0x0001FD80
	public void AccessoryDyeOver(int index)
	{
		Item[] dyes = this.DisplayDoll._dyes;
	}

	// Token: 0x06000859 RID: 2137 RVA: 0x00021B9C File Offset: 0x0001FD9C
	public void AccessoryDyeDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
		int num = this.cursorOver;
		if (!true)
		{
		}
		if (this.itemOver == 0)
		{
		}
		!0 instance = PageControllerLayoutDefinition.Instance;
		ItemSlot.SetSelectHighlight(true, scale);
	}

	// Token: 0x0600085A RID: 2138 RVA: 0x00021C80 File Offset: 0x0001FE80
	private void DrawAccesories()
	{
		!0 instance = PageControllerLayoutDefinition.Instance;
		if (!true)
		{
		}
		int num = this.itemDragStartAccessory;
		if (num == 0)
		{
		}
		bool mouseLeft = Main.mouseLeft;
		if (num == 0)
		{
		}
		if (Main.mouseItem != null)
		{
			if (num == 0)
			{
			}
			int type = Main.mouseItem.type;
			if (type != 0)
			{
				this.itemDragStartAccessory = type;
				!0 instance2 = PageControllerLayoutDefinition.Instance;
				int num2 = this.itemDragStartAccessoryDye;
				if (num2 == 0)
				{
				}
				bool mouseLeft2 = Main.mouseLeft;
				if (num2 == 0)
				{
				}
				if (Main.mouseItem != null)
				{
					if (num2 == 0)
					{
					}
					int type2 = Main.mouseItem.type;
					if (type2 != 0)
					{
						this.itemDragStartAccessoryDye = type2;
						return;
					}
				}
				int num3 = this.itemDragStartAccessoryDye;
				int num4 = this.itemOver;
				ItemSlot.LeftClick(this.DisplayDoll._dyes, 25, num3);
				return;
			}
		}
		int num5 = this.itemDragStartAccessory;
		int num6 = this.itemOver;
		ItemSlot.LeftClick(this.DisplayDoll._items, 24, num5);
	}

	// Token: 0x0600085B RID: 2139 RVA: 0x00021D64 File Offset: 0x0001FF64
	public Item GetSelectedItem()
	{
		/*
An exception occurred when decompiling this method (0600085B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Item GUIDisplayDoll::GetSelectedItem()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:EquipmentItemType(var_0_06, ldfld:EquipmentItemType(GUIDisplayDoll::itemType, ldloc:GUIDisplayDoll(this)))
	stloc:TEDisplayDoll(var_1_0D, ldfld:TEDisplayDoll(GUIDisplayDoll::DisplayDoll, ldloc:GUIDisplayDoll(this)))
	stloc:TEDisplayDoll(var_2_14, ldfld:TEDisplayDoll(GUIDisplayDoll::DisplayDoll, ldloc:GUIDisplayDoll(this)))
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

	// Token: 0x0600085C RID: 2140 RVA: 0x00021D88 File Offset: 0x0001FF88
	public void DrawUnequipButton()
	{
		if (!true)
		{
		}
		int myPlayer = Main.myPlayer;
		TileEntity tileEntity;
		if (tileEntity != null)
		{
			return;
		}
	}

	// Token: 0x170000DA RID: 218
	// (get) Token: 0x0600085D RID: 2141 RVA: 0x00021F00 File Offset: 0x00020100
	public bool HasFocus
	{
		get
		{
			DrPlatform.DrPlatformType currentPlatform = DrPlatform.CurrentPlatform;
			return true;
		}
	}

	// Token: 0x0600085E RID: 2142 RVA: 0x00021F18 File Offset: 0x00020118
	public void Draw()
	{
		int num = 1;
		if (num == 0)
		{
		}
		if (num == 0)
		{
		}
		int myPlayer = Main.myPlayer;
		int myPlayer2 = Main.myPlayer;
		Tile tile;
		short frameX = tile.frameX;
		int num2 = 1989;
		!0 instance = PageControllerLayoutDefinition.Instance;
		if (num2 == 0)
		{
		}
		if (num2 == 0)
		{
		}
		int myPlayer3 = Main.myPlayer;
		TileEntity tileEntity;
		if (tileEntity != null)
		{
		}
		long num3 = 0L;
		Recipe.FindRecipes(num3 != 0L);
	}

	// Token: 0x0600085F RID: 2143 RVA: 0x00021F8C File Offset: 0x0002018C
	public GUIDisplayDoll()
	{
	}

	// Token: 0x04000724 RID: 1828
	private int cursorOver;

	// Token: 0x04000725 RID: 1829
	private int itemOver;

	// Token: 0x04000726 RID: 1830
	private int itemDragStartArmour;

	// Token: 0x04000727 RID: 1831
	private int itemDragStartArmourDye;

	// Token: 0x04000728 RID: 1832
	private int itemDragStartAccessory;

	// Token: 0x04000729 RID: 1833
	private int itemDragStartAccessoryDye;

	// Token: 0x0400072A RID: 1834
	private GUIDisplayDoll.EquipmentItemType itemType;

	// Token: 0x0400072B RID: 1835
	private int itemPieceSelected;

	// Token: 0x0400072C RID: 1836
	private float UnequipButtonScale;

	// Token: 0x0400072D RID: 1837
	private float HideShowButtonScale;

	// Token: 0x0400072E RID: 1838
	private TEDisplayDoll DisplayDoll;

	// Token: 0x0200013B RID: 315
	private enum EquipmentItemType
	{
		// Token: 0x04000730 RID: 1840
		Armour,
		// Token: 0x04000731 RID: 1841
		ArmourDye,
		// Token: 0x04000732 RID: 1842
		Accessory,
		// Token: 0x04000733 RID: 1843
		AccessoryDye
	}
}
