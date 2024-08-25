using System;
using Controller;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.UI;
using UnityEngine;

// Token: 0x0200013E RID: 318
public class GUIEquipment
{
	// Token: 0x170000DB RID: 219
	// (get) Token: 0x06000874 RID: 2164 RVA: 0x0002232C File Offset: 0x0002052C
	public bool collapsed
	{
		get
		{
			if (!true)
			{
			}
			return InterfaceStyles_Layout.Active.IsCollapsed(GUIPageIcons.Category.Equipment);
		}
	}

	// Token: 0x06000875 RID: 2165 RVA: 0x0002234C File Offset: 0x0002054C
	public void LoadPageRegion()
	{
		!0 instance = PageControllerLayoutDefinition.Instance;
		!0 instance2 = PageControllerLayoutDefinition.Instance;
		!0 instance3 = PageControllerLayoutDefinition.Instance;
		!0 instance4 = PageControllerLayoutDefinition.Instance;
		!0 instance5 = PageControllerLayoutDefinition.Instance;
		!0 instance6 = PageControllerLayoutDefinition.Instance;
		!0 instance7 = PageControllerLayoutDefinition.Instance;
		!0 instance8 = PageControllerLayoutDefinition.Instance;
		!0 instance9 = PageControllerLayoutDefinition.Instance;
		!0 instance10 = PageControllerLayoutDefinition.Instance;
		!0 instance11 = PageControllerLayoutDefinition.Instance;
		if (instance5 == null)
		{
		}
		!0 instance12 = PageControllerLayoutDefinition.Instance;
	}

	// Token: 0x06000876 RID: 2166 RVA: 0x000223D0 File Offset: 0x000205D0
	public float ArmourScale(int index)
	{
		/*
An exception occurred when decompiling this method (06000876)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUIEquipment::ArmourScale(System.Int32)

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

	// Token: 0x06000877 RID: 2167 RVA: 0x000223E4 File Offset: 0x000205E4
	public float ArmourDyeScale(int index)
	{
		/*
An exception occurred when decompiling this method (06000877)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUIEquipment::ArmourDyeScale(System.Int32)

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

	// Token: 0x06000878 RID: 2168 RVA: 0x000223F8 File Offset: 0x000205F8
	public float ArmourVanityScale(int index)
	{
		/*
An exception occurred when decompiling this method (06000878)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUIEquipment::ArmourVanityScale(System.Int32)

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

	// Token: 0x06000879 RID: 2169 RVA: 0x0002240C File Offset: 0x0002060C
	private bool ShouldShowMenu(GUIEquipment.EquipmentItemType type, int i)
	{
		/*
An exception occurred when decompiling this method (06000879)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIEquipment::ShouldShowMenu(GUIEquipment/EquipmentItemType,System.Int32)

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

	// Token: 0x0600087A RID: 2170 RVA: 0x00022428 File Offset: 0x00020628
	private void ItemOver(Item[] inv, int index, GUIEquipment.EquipmentItemType equipmentType, int itemContext, int itemDragStart)
	{
		this.cursorOver = index;
		global::Cursor cursor;
		if (cursor != null)
		{
			return;
		}
		global::Cursor cursor2;
		if (cursor2 != null)
		{
			return;
		}
		this.itemOver = index;
		this.itemType = equipmentType;
		this.UnequipButtonScale = (float)index;
		bool flag = this.rightClickHeld;
		if (flag)
		{
			int num = this.lastItemClicked;
		}
		GUIEquipment.EquipmentItemType equipmentItemType = this.lastItemTypeClicked;
		if (flag)
		{
			int num2 = this.lastItemClicked;
			bool mouseLeft = Main.mouseLeft;
			if (Main.mouseItem != null && Main.mouseItem.type != 0)
			{
				this.itemOver = index;
			}
			Main.mouseRight = Main.mouseLeft;
			bool flag2 = ItemSlot.RightClick(inv, itemContext, index);
			bool mouseRight = Main.mouseRight;
			long num3 = 0L;
			this.itemOver = index;
			this.itemType = equipmentType;
			this.UnequipButtonScale = (float)index;
			if (num2 == 0 && num3 != 0L)
			{
				return;
			}
		}
		else
		{
			long num4 = 0L;
			this.itemOver = index;
			this.itemType = equipmentType;
			this.UnequipButtonScale = (float)index;
			if (equipmentType == GUIEquipment.EquipmentItemType.Armour && num4 != 0L)
			{
				return;
			}
		}
		ItemSlot.LeftClick(inv, itemContext, index);
		long num5 = 0L;
		ItemSlot.OverrideHover(inv, itemContext, index);
		ItemSlot.MouseHover(inv, itemContext, index);
		int cursorOverride = Main.cursorOverride;
		if (num5 != 0L)
		{
			ItemSlot.LeftClick(inv, itemContext, index);
			Recipe.FindRecipes(false);
		}
	}

	// Token: 0x0600087B RID: 2171 RVA: 0x000226A4 File Offset: 0x000208A4
	public void ArmourOver(int index)
	{
		if (!true)
		{
		}
		int myPlayer = Main.myPlayer;
	}

	// Token: 0x0600087C RID: 2172 RVA: 0x000226BC File Offset: 0x000208BC
	public void ArmourDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		int num = this.cursorOver;
		if (!true)
		{
		}
		if (this.itemOver == 0)
		{
		}
		bool controllerModeLocked = XNAUnityRunner.ControllerModeLocked;
		GUIControllerEquipment guicontrollerEquipment;
		int itemColumn = guicontrollerEquipment.itemColumn;
		!0 instance = PageControllerLayoutDefinition.Instance;
		ItemSlot.SetSelectHighlight(true, scale);
	}

	// Token: 0x0600087D RID: 2173 RVA: 0x00022794 File Offset: 0x00020994
	public void ArmourDyeOver(int index)
	{
		if (!true)
		{
		}
		int myPlayer = Main.myPlayer;
	}

	// Token: 0x0600087E RID: 2174 RVA: 0x000227AC File Offset: 0x000209AC
	public void ArmourDyeDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		int num = this.cursorOver;
		if (!true)
		{
		}
		if (this.itemOver == 0)
		{
		}
		bool controllerModeLocked = XNAUnityRunner.ControllerModeLocked;
		GUIControllerEquipment guicontrollerEquipment;
		int itemColumn = guicontrollerEquipment.itemColumn;
		!0 instance = PageControllerLayoutDefinition.Instance;
		ItemSlot.SetSelectHighlight(true, scale);
	}

	// Token: 0x0600087F RID: 2175 RVA: 0x0002286C File Offset: 0x00020A6C
	public void ArmourVanityOver(int index)
	{
		if (!true)
		{
		}
		int myPlayer = Main.myPlayer;
	}

	// Token: 0x06000880 RID: 2176 RVA: 0x00022884 File Offset: 0x00020A84
	public void ArmourVanityDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		int num = this.cursorOver;
		if (!true)
		{
		}
		if (this.itemOver == 0)
		{
		}
		bool controllerModeLocked = XNAUnityRunner.ControllerModeLocked;
		GUIControllerEquipment guicontrollerEquipment;
		int itemColumn = guicontrollerEquipment.itemColumn;
		!0 instance = PageControllerLayoutDefinition.Instance;
		ItemSlot.SetSelectHighlight(true, scale);
	}

	// Token: 0x06000881 RID: 2177 RVA: 0x00022958 File Offset: 0x00020B58
	public int CanBeEquipedAccessory(Item checkItem)
	{
		/*
An exception occurred when decompiling this method (06000881)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 GUIEquipment::CanBeEquipedAccessory(Terraria.Item)

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

	// Token: 0x06000882 RID: 2178 RVA: 0x0002298C File Offset: 0x00020B8C
	public bool CanBeEquiped(Item checkItem)
	{
		/*
An exception occurred when decompiling this method (06000882)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIEquipment::CanBeEquiped(Terraria.Item)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_002D:
	stloc:int32(var_6_36, ldfld:int32(Item::buffType, ldloc:Item(checkItem)))
	stloc:int32(var_7_3E, ldfld:int32(Item::buffType, ldloc:Item(checkItem)))
	stloc:int32(var_8_46, ldfld:int32(Item::buffType, ldloc:Item(checkItem)))
	stloc:int32(var_9_4E, ldfld:int32(Item::buffType, ldloc:Item(checkItem)))
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

	// Token: 0x06000883 RID: 2179 RVA: 0x000229EC File Offset: 0x00020BEC
	public bool CanBeStored(Item checkItem)
	{
		/*
An exception occurred when decompiling this method (06000883)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIEquipment::CanBeStored(Terraria.Item)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0035:
	stloc:int32(var_6_3E, ldfld:int32(Item::buffType, ldloc:Item(checkItem)))
	stloc:int32(var_7_46, ldfld:int32(Item::buffType, ldloc:Item(checkItem)))
	stloc:int32(var_8_4E, ldfld:int32(Item::buffType, ldloc:Item(checkItem)))
	stloc:int32(var_9_56, ldfld:int32(Item::buffType, ldloc:Item(checkItem)))
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

	// Token: 0x06000884 RID: 2180 RVA: 0x00022A54 File Offset: 0x00020C54
	private bool CanBeStored(int context, Item checkItem, int slot)
	{
		bool accessory;
		do
		{
			if (slot == 0)
			{
				int headSlot = checkItem.headSlot;
			}
			int bodySlot = checkItem.bodySlot;
			int legSlot = checkItem.legSlot;
			int headSlot2 = checkItem.headSlot;
			int bodySlot2 = checkItem.bodySlot;
			if (checkItem.accessory)
			{
				goto IL_0043;
			}
			accessory = checkItem.accessory;
		}
		while (!accessory);
		bool fitsAccessoryVanitySlot = checkItem.FitsAccessoryVanitySlot;
		IL_0043:
		if (!accessory)
		{
		}
		return ItemSlot.AccCheck(Main.LocalPlayer.armor, checkItem, slot);
	}

	// Token: 0x06000885 RID: 2181 RVA: 0x00022B24 File Offset: 0x00020D24
	private void DrawArmour()
	{
		int num = 1;
		!0 instance = PageControllerLayoutDefinition.Instance;
		!0 instance2 = PageControllerLayoutDefinition.Instance;
		!0 instance3 = PageControllerLayoutDefinition.Instance;
		!0 instance4 = PageControllerLayoutDefinition.Instance;
		if (num == 0)
		{
		}
		!0 instance5 = PageControllerLayoutDefinition.Instance;
		int num2 = this.itemDragStartArmour;
		if (num2 == 0)
		{
		}
		bool mouseLeft = Main.mouseLeft;
		if (num2 == 0)
		{
		}
		if (Main.mouseItem != null)
		{
			if (num2 == 0)
			{
			}
			int type = Main.mouseItem.type;
			if (type != 0)
			{
				this.itemDragStartArmour = type;
				!0 instance6 = PageControllerLayoutDefinition.Instance;
				int num3 = this.itemDragStartArmourDye;
				if (num3 == 0)
				{
				}
				bool mouseLeft2 = Main.mouseLeft;
				if (num3 == 0)
				{
				}
				if (Main.mouseItem != null)
				{
					if (num3 == 0)
					{
					}
					int type2 = Main.mouseItem.type;
					if (type2 != 0)
					{
						this.itemDragStartArmourDye = type2;
						!0 instance7 = PageControllerLayoutDefinition.Instance;
						int num4 = this.itemDragStartArmourVanity;
						if (num4 == 0)
						{
						}
						bool mouseLeft3 = Main.mouseLeft;
						if (num4 == 0)
						{
						}
						if (Main.mouseItem != null)
						{
							if (num4 == 0)
							{
							}
							int type3 = Main.mouseItem.type;
							if (type3 != 0)
							{
								this.itemDragStartArmourVanity = type3;
								return;
							}
						}
						int num5 = this.itemDragStartArmourVanity;
						int num6 = this.itemOver;
						int myPlayer = Main.myPlayer;
						int num7 = this.itemDragStartArmourVanity;
						return;
					}
				}
				int num8 = this.itemDragStartArmourDye;
				int num9 = this.itemOver;
				int myPlayer2 = Main.myPlayer;
				int num10 = this.itemDragStartArmourDye;
				return;
			}
		}
		int num11 = this.itemDragStartArmour;
		int num12 = this.itemOver;
		int myPlayer3 = Main.myPlayer;
		int num13 = this.itemDragStartArmour;
	}

	// Token: 0x06000886 RID: 2182 RVA: 0x00022CA4 File Offset: 0x00020EA4
	public float AccessoryScale(int index)
	{
		/*
An exception occurred when decompiling this method (06000886)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUIEquipment::AccessoryScale(System.Int32)

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

	// Token: 0x06000887 RID: 2183 RVA: 0x00022CB8 File Offset: 0x00020EB8
	public float AccessoryDyeScale(int index)
	{
		/*
An exception occurred when decompiling this method (06000887)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUIEquipment::AccessoryDyeScale(System.Int32)

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

	// Token: 0x06000888 RID: 2184 RVA: 0x00022CCC File Offset: 0x00020ECC
	public float AccessoryVanityScale(int index)
	{
		/*
An exception occurred when decompiling this method (06000888)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUIEquipment::AccessoryVanityScale(System.Int32)

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

	// Token: 0x06000889 RID: 2185 RVA: 0x00022CE0 File Offset: 0x00020EE0
	public void AccessoryOver(int index)
	{
		int num;
		do
		{
			num = this.accOffset;
		}
		while (num == 0);
		if (num == 0)
		{
		}
		int myPlayer = Main.myPlayer;
		if (this.accOffset == 0)
		{
		}
		int myPlayer2 = Main.myPlayer;
	}

	// Token: 0x0600088A RID: 2186 RVA: 0x00022D28 File Offset: 0x00020F28
	public void AccessoryDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		int num;
		do
		{
			num = this.accOffset;
		}
		while (num == 0);
		if (num == 0)
		{
		}
		int myPlayer = Main.myPlayer;
		if (this.accOffset == 0)
		{
		}
		int myPlayer2 = Main.myPlayer;
		int num2 = this.cursorOver;
		if (!true)
		{
		}
		if (this.itemOver == 0)
		{
		}
		bool controllerModeLocked = XNAUnityRunner.ControllerModeLocked;
		GUIControllerEquipment guicontrollerEquipment;
		int itemColumn = guicontrollerEquipment.itemColumn;
		!0 instance = PageControllerLayoutDefinition.Instance;
		ItemSlot.SetSelectHighlight(true, scale);
	}

	// Token: 0x0600088B RID: 2187 RVA: 0x00022F0C File Offset: 0x0002110C
	public void AccessoryDyeOver(int index)
	{
		int num;
		do
		{
			num = this.accOffset;
		}
		while (num == 0);
		if (num == 0)
		{
		}
		int myPlayer = Main.myPlayer;
		if (this.accOffset == 0)
		{
		}
		int myPlayer2 = Main.myPlayer;
	}

	// Token: 0x0600088C RID: 2188 RVA: 0x00022F54 File Offset: 0x00021154
	public void AccessoryDyeDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		int num;
		do
		{
			num = this.accOffset;
		}
		while (num == 0);
		if (num == 0)
		{
		}
		int myPlayer = Main.myPlayer;
		if (this.accOffset == 0)
		{
		}
		int myPlayer2 = Main.myPlayer;
		int num2 = this.cursorOver;
		if (!true)
		{
		}
		if (this.itemOver == 0)
		{
		}
		bool controllerModeLocked = XNAUnityRunner.ControllerModeLocked;
		GUIControllerEquipment guicontrollerEquipment;
		int itemColumn = guicontrollerEquipment.itemColumn;
		!0 instance = PageControllerLayoutDefinition.Instance;
		ItemSlot.SetSelectHighlight(true, scale);
	}

	// Token: 0x0600088D RID: 2189 RVA: 0x000230DC File Offset: 0x000212DC
	public void AccessoryVanityOver(int index)
	{
		int num;
		do
		{
			num = this.accOffset;
		}
		while (num == 0);
		if (num == 0)
		{
		}
		int myPlayer = Main.myPlayer;
		if (this.accOffset == 0)
		{
		}
		int myPlayer2 = Main.myPlayer;
	}

	// Token: 0x0600088E RID: 2190 RVA: 0x00023124 File Offset: 0x00021324
	public void AccessoryVanityDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		int num;
		do
		{
			num = this.accOffset;
		}
		while (num == 0);
		if (num == 0)
		{
		}
		int myPlayer = Main.myPlayer;
		if (this.accOffset == 0)
		{
		}
		int myPlayer2 = Main.myPlayer;
		int num2 = this.cursorOver;
		if (!true)
		{
		}
		if (this.itemOver == 0)
		{
		}
		bool controllerModeLocked = XNAUnityRunner.ControllerModeLocked;
		GUIControllerEquipment guicontrollerEquipment;
		int itemColumn = guicontrollerEquipment.itemColumn;
		!0 instance = PageControllerLayoutDefinition.Instance;
		ItemSlot.SetSelectHighlight(true, scale);
	}

	// Token: 0x0600088F RID: 2191 RVA: 0x000232B4 File Offset: 0x000214B4
	private void DrawAccesories()
	{
		if (!true)
		{
		}
		int myPlayer = Main.myPlayer;
		!0 instance = PageControllerLayoutDefinition.Instance;
		!0 instance2 = PageControllerLayoutDefinition.Instance;
		!0 instance3 = PageControllerLayoutDefinition.Instance;
		!0 instance4 = PageControllerLayoutDefinition.Instance;
		int num = 5;
		!0 instance5 = PageControllerLayoutDefinition.Instance;
		!0 instance6 = PageControllerLayoutDefinition.Instance;
		this.accOffset = num;
		!0 instance7 = PageControllerLayoutDefinition.Instance;
		!0 instance8 = PageControllerLayoutDefinition.Instance;
		!0 instance9 = PageControllerLayoutDefinition.Instance;
		!0 instance10 = PageControllerLayoutDefinition.Instance;
		int num2 = this.itemDragStartAccessory;
		if (num2 == 0)
		{
		}
		bool mouseLeft = Main.mouseLeft;
		if (num2 == 0)
		{
		}
		if (Main.mouseItem != null)
		{
			if (num2 == 0)
			{
			}
			int type = Main.mouseItem.type;
			if (type != 0)
			{
				this.itemDragStartAccessory = type;
				!0 instance11 = PageControllerLayoutDefinition.Instance;
				int num3 = 5;
				this.accOffset = num3;
				!0 instance12 = PageControllerLayoutDefinition.Instance;
				int num4 = this.itemDragStartAccessoryDye;
				if (num4 == 0)
				{
				}
				bool mouseLeft2 = Main.mouseLeft;
				if (num4 == 0)
				{
				}
				Item mouseItem = Main.mouseItem;
				if (mouseItem != null)
				{
					if (mouseItem.tileBoost == 0)
					{
					}
					int type2 = Main.mouseItem.type;
					if (type2 != 0)
					{
						this.itemDragStartAccessoryDye = type2;
						!0 instance13 = PageControllerLayoutDefinition.Instance;
						int num5 = 5;
						this.accOffset = num5;
						!0 instance14 = PageControllerLayoutDefinition.Instance;
						int num6 = this.itemDragStartAccessoryVanity;
						if (num6 == 0)
						{
						}
						bool mouseLeft3 = Main.mouseLeft;
						if (num6 == 0)
						{
						}
						if (Main.mouseItem != null)
						{
							if (num6 == 0)
							{
							}
							int type3 = Main.mouseItem.type;
							if (type3 != 0)
							{
								this.itemDragStartAccessoryVanity = type3;
								return;
							}
						}
						int num7 = this.itemDragStartAccessoryVanity;
						int num8 = this.itemOver;
						int myPlayer2 = Main.myPlayer;
						int num9 = this.itemDragStartAccessoryVanity;
						return;
					}
				}
				int num10 = this.itemDragStartAccessoryDye;
				int num11 = this.itemOver;
				int myPlayer3 = Main.myPlayer;
				int num12 = this.itemDragStartAccessoryDye;
				return;
			}
		}
		int num13 = this.itemDragStartAccessory;
		int num14 = this.itemOver;
		int myPlayer4 = Main.myPlayer;
		int num15 = this.itemDragStartAccessory;
	}

	// Token: 0x06000890 RID: 2192 RVA: 0x00023498 File Offset: 0x00021698
	public float QuickSlotScale(int index)
	{
		/*
An exception occurred when decompiling this method (06000890)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUIEquipment::QuickSlotScale(System.Int32)

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

	// Token: 0x06000891 RID: 2193 RVA: 0x000234AC File Offset: 0x000216AC
	public float QuickSlotScaleDye(int index)
	{
		/*
An exception occurred when decompiling this method (06000891)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUIEquipment::QuickSlotScaleDye(System.Int32)

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

	// Token: 0x06000892 RID: 2194 RVA: 0x000234C0 File Offset: 0x000216C0
	public void QuickSlotOver(int index)
	{
	}

	// Token: 0x06000893 RID: 2195 RVA: 0x000234DC File Offset: 0x000216DC
	public void QuickSlotDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
	}

	// Token: 0x06000894 RID: 2196 RVA: 0x000235F4 File Offset: 0x000217F4
	public void QuickSlotDyeOver(int index)
	{
		if (!true)
		{
		}
		int myPlayer = Main.myPlayer;
	}

	// Token: 0x06000895 RID: 2197 RVA: 0x0002360C File Offset: 0x0002180C
	public void QuickSlotDyeDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		int num = this.cursorOver;
		if (!true)
		{
		}
		if (this.itemOver == 0)
		{
		}
		bool controllerModeLocked = XNAUnityRunner.ControllerModeLocked;
		GUIControllerEquipment guicontrollerEquipment;
		int itemColumn = guicontrollerEquipment.itemColumn;
		!0 instance = PageControllerLayoutDefinition.Instance;
		ItemSlot.SetSelectHighlight(true, scale);
	}

	// Token: 0x06000896 RID: 2198 RVA: 0x000236CC File Offset: 0x000218CC
	private void DrawQuickSlots()
	{
		int num = 1;
		!0 instance = PageControllerLayoutDefinition.Instance;
		!0 instance2 = PageControllerLayoutDefinition.Instance;
		!0 instance3 = PageControllerLayoutDefinition.Instance;
		!0 instance4 = PageControllerLayoutDefinition.Instance;
		if (num == 0)
		{
		}
		!0 instance5 = PageControllerLayoutDefinition.Instance;
		int num2 = this.itemDragStartQuickSlot;
		if (num2 == 0)
		{
		}
		bool mouseLeft = Main.mouseLeft;
		if (num2 == 0)
		{
		}
		if (Main.mouseItem != null)
		{
			if (num2 == 0)
			{
			}
			int type = Main.mouseItem.type;
			if (type != 0)
			{
				this.itemDragStartQuickSlot = type;
				!0 instance6 = PageControllerLayoutDefinition.Instance;
				int num3 = this.itemDragStartQuickSlotDye;
				if (num3 == 0)
				{
				}
				bool mouseLeft2 = Main.mouseLeft;
				if (num3 == 0)
				{
				}
				if (Main.mouseItem != null)
				{
					if (num3 == 0)
					{
					}
					int type2 = Main.mouseItem.type;
					if (type2 != 0)
					{
						this.itemDragStartQuickSlotDye = type2;
						return;
					}
				}
				int num4 = this.itemDragStartQuickSlotDye;
				int num5 = this.itemOver;
				int myPlayer = Main.myPlayer;
				int num6 = this.itemDragStartQuickSlotDye;
				return;
			}
		}
		int num7 = this.itemDragStartQuickSlot;
		int num8 = this.itemOver;
	}

	// Token: 0x06000897 RID: 2199 RVA: 0x000237CC File Offset: 0x000219CC
	private void DrawHeaders()
	{
	}

	// Token: 0x06000898 RID: 2200 RVA: 0x000237E0 File Offset: 0x000219E0
	private void DrawArmourBonus()
	{
		this.LoadPageRegion();
		!0 instance = PageControllerLayoutDefinition.Instance;
		Button_Layout button_Layout;
		float x = button_Layout.Location.X;
		button_Layout.Location.X = x;
		!0 instance2 = PageControllerLayoutDefinition.Instance;
		String_Layout string_Layout;
		float x2 = string_Layout.Location.X;
		string_Layout.Location.X = x2;
		!0 instance3 = PageControllerLayoutDefinition.Instance;
		string text = Main.myPlayer.ToString();
	}

	// Token: 0x06000899 RID: 2201 RVA: 0x000238CC File Offset: 0x00021ACC
	public Item GetSelectedItem()
	{
		/*
An exception occurred when decompiling this method (06000899)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Item GUIEquipment::GetSelectedItem()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_1_0A, callgetter:int32(Main::get_myPlayer))
	stloc:EquipmentItemType(var_2_11, ldfld:EquipmentItemType(GUIEquipment::itemType, ldloc:GUIEquipment(this)))
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

	// Token: 0x0600089A RID: 2202 RVA: 0x000238EC File Offset: 0x00021AEC
	public void DrawUnequipButton()
	{
		int myPlayer = Main.myPlayer;
		Item selectedItem = this.GetSelectedItem();
		!0 instance = PageControllerLayoutDefinition.Instance;
		int type = selectedItem.type;
		if (type != 0 && selectedItem.stack != 0)
		{
			if (type == 0)
			{
			}
			int myPlayer2 = Main.myPlayer;
			bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
			GUIControllerEquipment guicontrollerEquipment;
			bool inAccessories = guicontrollerEquipment.inAccessories;
			if (PageControllerLayoutDefinition.Instance == null)
			{
			}
			return;
		}
		GUIEquipment.EquipmentItemType equipmentItemType = this.itemType;
	}

	// Token: 0x0600089B RID: 2203 RVA: 0x000239F4 File Offset: 0x00021BF4
	public bool CanBeHiddenOrShow()
	{
		return true;
	}

	// Token: 0x0600089C RID: 2204 RVA: 0x00023A04 File Offset: 0x00021C04
	public void DrawExpandButton()
	{
	}

	// Token: 0x0600089D RID: 2205 RVA: 0x00023A14 File Offset: 0x00021C14
	public void DrawHideShowButton()
	{
		if (!true)
		{
		}
		int myPlayer = Main.myPlayer;
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
		GUIControllerEquipment guicontrollerEquipment;
		if (!guicontrollerEquipment.inAccessories)
		{
			!0 instance = PageControllerLayoutDefinition.Instance;
			!0 instance2 = PageControllerLayoutDefinition.Instance;
			!0 instance3 = PageControllerLayoutDefinition.Instance;
			!0 instance4 = PageControllerLayoutDefinition.Instance;
			!0 instance5 = PageControllerLayoutDefinition.Instance;
			GUIEquipment.EquipmentItemType equipmentItemType = this.itemType;
			!0 instance6 = PageControllerLayoutDefinition.Instance;
			!0 instance7 = PageControllerLayoutDefinition.Instance;
			!0 instance8 = PageControllerLayoutDefinition.Instance;
			!0 instance9 = PageControllerLayoutDefinition.Instance;
			!0 instance10 = PageControllerLayoutDefinition.Instance;
			return;
		}
	}

	// Token: 0x170000DC RID: 220
	// (get) Token: 0x0600089E RID: 2206 RVA: 0x00023B6C File Offset: 0x00021D6C
	public bool HasFocus
	{
		get
		{
			DrPlatform.DrPlatformType currentPlatform = DrPlatform.CurrentPlatform;
			return true;
		}
	}

	// Token: 0x0600089F RID: 2207 RVA: 0x00023B84 File Offset: 0x00021D84
	public void Draw()
	{
		float num = this.doubleClickTimer;
		float deltaTime = Time.deltaTime;
		this.lastItemClicked = 1;
		this.DrawArmour();
		this.DrawAccesories();
		this.DrawQuickSlots();
		this.DrawHeaders();
		this.DrawArmourBonus();
		bool hasFocus = this.HasFocus;
		GUIControllerEquipment guicontrollerEquipment;
		if (!guicontrollerEquipment.inAccessories && this.GetSelectedItem().type != 0)
		{
			int stack = this.GetSelectedItem().stack;
			return;
		}
	}

	// Token: 0x060008A0 RID: 2208 RVA: 0x00023BF0 File Offset: 0x00021DF0
	public GUIEquipment()
	{
	}

	// Token: 0x04000752 RID: 1874
	private int cursorOver;

	// Token: 0x04000753 RID: 1875
	private int itemOver;

	// Token: 0x04000754 RID: 1876
	private int itemDragStartArmour;

	// Token: 0x04000755 RID: 1877
	private int itemDragStartArmourDye;

	// Token: 0x04000756 RID: 1878
	private int itemDragStartArmourVanity;

	// Token: 0x04000757 RID: 1879
	private int itemDragStartAccessory;

	// Token: 0x04000758 RID: 1880
	private int itemDragStartAccessoryDye;

	// Token: 0x04000759 RID: 1881
	private int itemDragStartAccessoryVanity;

	// Token: 0x0400075A RID: 1882
	private int itemDragStartQuickSlot;

	// Token: 0x0400075B RID: 1883
	private int itemDragStartQuickSlotDye;

	// Token: 0x0400075C RID: 1884
	private float collapseAnimationTime = (float)17096;

	// Token: 0x0400075D RID: 1885
	private GUIEquipment.EquipmentItemType lastItemTypeClicked;

	// Token: 0x0400075E RID: 1886
	private int lastItemClicked = 17096;

	// Token: 0x0400075F RID: 1887
	private float doubleClickTimer;

	// Token: 0x04000760 RID: 1888
	private bool rightClickHeld;

	// Token: 0x04000761 RID: 1889
	private GUIEquipment.EquipmentItemType itemType;

	// Token: 0x04000762 RID: 1890
	private int itemPieceSelected;

	// Token: 0x04000763 RID: 1891
	private float UnequipButtonScale;

	// Token: 0x04000764 RID: 1892
	private float HideShowButtonScale;

	// Token: 0x04000765 RID: 1893
	private float globalAnimationOffset;

	// Token: 0x04000766 RID: 1894
	private float row1AnimationOffset;

	// Token: 0x04000767 RID: 1895
	private float row2AnimationOffset;

	// Token: 0x04000768 RID: 1896
	private float row1AnimationScale;

	// Token: 0x04000769 RID: 1897
	private float row2AnimationScale = (float)16256;

	// Token: 0x0400076A RID: 1898
	private int accOffset;

	// Token: 0x0400076B RID: 1899
	private float ExpandButtonScale;

	// Token: 0x0200013F RID: 319
	private enum EquipmentItemType
	{
		// Token: 0x0400076D RID: 1901
		Armour,
		// Token: 0x0400076E RID: 1902
		ArmourDye,
		// Token: 0x0400076F RID: 1903
		ArmourVanity,
		// Token: 0x04000770 RID: 1904
		Accessory,
		// Token: 0x04000771 RID: 1905
		AccessoryDye,
		// Token: 0x04000772 RID: 1906
		AccessoryVanity,
		// Token: 0x04000773 RID: 1907
		QuickSlot,
		// Token: 0x04000774 RID: 1908
		QuickSlotDye
	}
}
