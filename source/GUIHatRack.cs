using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Tile_Entities;
using Terraria.UI;

// Token: 0x02000144 RID: 324
public class GUIHatRack
{
	// Token: 0x060008C1 RID: 2241 RVA: 0x00024C44 File Offset: 0x00022E44
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

	// Token: 0x060008C2 RID: 2242 RVA: 0x00024C6C File Offset: 0x00022E6C
	public float HatScale(int index)
	{
		/*
An exception occurred when decompiling this method (060008C2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUIHatRack::HatScale(System.Int32)

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

	// Token: 0x060008C3 RID: 2243 RVA: 0x00024C80 File Offset: 0x00022E80
	public float HatDyeScale(int index)
	{
		/*
An exception occurred when decompiling this method (060008C3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUIHatRack::HatDyeScale(System.Int32)

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

	// Token: 0x060008C4 RID: 2244 RVA: 0x00024C94 File Offset: 0x00022E94
	private void ItemOver(Item[] inv, int index, GUIHatRack.EquipmentItemType equipmentType, int itemContext, int itemDragStart)
	{
		this.cursorOver = index;
		this.itemOver = index;
		this.itemType = equipmentType;
		this.UnequipButtonScale = (float)index;
		this.itemOver = index;
		this.itemType = equipmentType;
		this.UnequipButtonScale = (float)index;
		ItemSlot.LeftClick(inv, itemContext, index);
	}

	// Token: 0x060008C5 RID: 2245 RVA: 0x00024DA8 File Offset: 0x00022FA8
	public void HatOver(int index)
	{
		Item[] items = this.HatRack._items;
	}

	// Token: 0x060008C6 RID: 2246 RVA: 0x00024DC4 File Offset: 0x00022FC4
	public void HatDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
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

	// Token: 0x060008C7 RID: 2247 RVA: 0x00024EA8 File Offset: 0x000230A8
	public void HatDyeOver(int index)
	{
		Item[] dyes = this.HatRack._dyes;
	}

	// Token: 0x060008C8 RID: 2248 RVA: 0x00024EC4 File Offset: 0x000230C4
	public void HatDyeDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
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

	// Token: 0x060008C9 RID: 2249 RVA: 0x00024FA0 File Offset: 0x000231A0
	public int CanBeEquipedAccessory(Item checkItem)
	{
		/*
An exception occurred when decompiling this method (060008C9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 GUIHatRack::CanBeEquipedAccessory(Terraria.Item)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_1_0A, callgetter:int32(Main::get_myPlayer))
	stloc:int32(var_3_12, callgetter:int32(Main::get_myPlayer))
	stloc:int32(var_5_1B, callgetter:int32(Main::get_myPlayer))
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

	// Token: 0x060008CA RID: 2250 RVA: 0x00024FD4 File Offset: 0x000231D4
	public bool CanBeEquiped(Item checkItem)
	{
		/*
An exception occurred when decompiling this method (060008CA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIHatRack::CanBeEquiped(Terraria.Item)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Item::headSlot, ldloc:Item(checkItem)))
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

	// Token: 0x060008CB RID: 2251 RVA: 0x00024FE8 File Offset: 0x000231E8
	public bool CanBeStored(Item checkItem)
	{
		int headSlot = checkItem.headSlot;
		return true;
	}

	// Token: 0x060008CC RID: 2252 RVA: 0x00025008 File Offset: 0x00023208
	private bool CanBeStored(int context, Item checkItem, int slot)
	{
		/*
An exception occurred when decompiling this method (060008CC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIHatRack::CanBeStored(System.Int32,Terraria.Item,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Item::headSlot, ldloc:Item(checkItem)))
	stloc:int32(var_1_0D, ldfld:int32(Item::stack, ldloc:Item(checkItem)))
	stloc:uint8(var_2_14, ldfld:uint8(Item::dye, ldloc:Item(checkItem)))
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

	// Token: 0x060008CD RID: 2253 RVA: 0x0002502C File Offset: 0x0002322C
	private void DrawHats()
	{
		!0 instance = PageControllerLayoutDefinition.Instance;
		if (!true)
		{
		}
		int num = this.itemDragStartHat;
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
				this.itemDragStartHat = type;
				!0 instance2 = PageControllerLayoutDefinition.Instance;
				int num2 = this.itemDragStartHatDye;
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
						this.itemDragStartHatDye = type2;
						return;
					}
				}
				int num3 = this.itemDragStartHatDye;
				int num4 = this.itemOver;
				ItemSlot.LeftClick(this.HatRack._dyes, 27, num3);
				return;
			}
		}
		int num5 = this.itemDragStartHat;
		int num6 = this.itemOver;
		ItemSlot.LeftClick(this.HatRack._items, 26, num5);
	}

	// Token: 0x060008CE RID: 2254 RVA: 0x00025114 File Offset: 0x00023314
	public Item GetSelectedItem()
	{
		/*
An exception occurred when decompiling this method (060008CE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Item GUIHatRack::GetSelectedItem()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:EquipmentItemType(var_0_06, ldfld:EquipmentItemType(GUIHatRack::itemType, ldloc:GUIHatRack(this)))
	stloc:float32(var_1_0D, ldfld:float32(GUIHatRack::UnequipButtonScale, ldloc:GUIHatRack(this)))
	stloc:TEHatRack(var_2_14, ldfld:TEHatRack(GUIHatRack::HatRack, ldloc:GUIHatRack(this)))
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

	// Token: 0x060008CF RID: 2255 RVA: 0x00025138 File Offset: 0x00023338
	public void DrawUnequipButton()
	{
		if (!true)
		{
		}
		int myPlayer = Main.myPlayer;
		TileEntity tileEntity;
		if (tileEntity != null)
		{
		}
	}

	// Token: 0x170000DD RID: 221
	// (get) Token: 0x060008D0 RID: 2256 RVA: 0x000252B8 File Offset: 0x000234B8
	public bool HasFocus
	{
		get
		{
			DrPlatform.DrPlatformType currentPlatform = DrPlatform.CurrentPlatform;
			return true;
		}
	}

	// Token: 0x060008D1 RID: 2257 RVA: 0x000252D0 File Offset: 0x000234D0
	public void Draw()
	{
		int num = 1;
		if (num == 0)
		{
		}
		if (num == 0)
		{
		}
		int num2 = 255;
		!0 instance = PageControllerLayoutDefinition.Instance;
		if (num2 == 0)
		{
		}
		if (num2 == 0)
		{
		}
		int myPlayer = Main.myPlayer;
		TileEntity tileEntity;
		if (tileEntity != null)
		{
		}
		long num3 = 0L;
		Recipe.FindRecipes(num3 != 0L);
	}

	// Token: 0x060008D2 RID: 2258 RVA: 0x00025320 File Offset: 0x00023520
	public GUIHatRack()
	{
	}

	// Token: 0x04000790 RID: 1936
	private int cursorOver;

	// Token: 0x04000791 RID: 1937
	private int itemOver;

	// Token: 0x04000792 RID: 1938
	private int itemDragStartHat;

	// Token: 0x04000793 RID: 1939
	private int itemDragStartHatDye;

	// Token: 0x04000794 RID: 1940
	private GUIHatRack.EquipmentItemType itemType;

	// Token: 0x04000795 RID: 1941
	private int itemPieceSelected;

	// Token: 0x04000796 RID: 1942
	private float UnequipButtonScale = (float)16256;

	// Token: 0x04000797 RID: 1943
	private TEHatRack HatRack;

	// Token: 0x02000145 RID: 325
	private enum EquipmentItemType
	{
		// Token: 0x04000799 RID: 1945
		Hat,
		// Token: 0x0400079A RID: 1946
		HatDye
	}
}
