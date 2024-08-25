using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Terraria;
using Terraria.UI;
using UnityEngine;

// Token: 0x0200012D RID: 301
public class GUICoins
{
	// Token: 0x060007DA RID: 2010 RVA: 0x0001EC4C File Offset: 0x0001CE4C
	public GUICoins()
	{
	}

	// Token: 0x060007DB RID: 2011 RVA: 0x0001EC70 File Offset: 0x0001CE70
	public Rectangle GetRegion()
	{
		bool useCollpasedCoinsAmmo = RightSideHUDAnchorUpdator.UseCollpasedCoinsAmmo;
		!0 instance = PageControllerLayoutDefinition.Instance;
		GUIItemGrid.GetItemScaleHandler itemScaleDelegate = this.ItemScaleDelegate;
		if (instance == null)
		{
		}
		Rectangle rectangle;
		return rectangle;
	}

	// Token: 0x060007DC RID: 2012 RVA: 0x0001EC98 File Offset: 0x0001CE98
	public float ItemScale(int index)
	{
		/*
An exception occurred when decompiling this method (060007DC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUICoins::ItemScale(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_1_07, callgetter:bool(RightSideHUDAnchorUpdator::get_UseCollpasedCoinsAmmo))
	stloc:!0(var_2_0D, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
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

	// Token: 0x060007DD RID: 2013 RVA: 0x0001ECB4 File Offset: 0x0001CEB4
	public void ItemOver(int index)
	{
		int myPlayer = Main.myPlayer;
		bool isAir = Main.mouseItem.IsAir;
		int myPlayer2 = Main.myPlayer;
		int myPlayer3 = Main.myPlayer;
		int myPlayer4 = Main.myPlayer;
		int myPlayer5 = Main.myPlayer;
		global::Cursor cursor;
		if (cursor != null)
		{
			return;
		}
		long num = 0L;
		global::Cursor cursor2;
		if (cursor2 != null)
		{
			return;
		}
		int myPlayer6 = Main.myPlayer;
		if (this.rightClickHeld)
		{
			int num2 = this.lastItemClicked;
			int num3 = this.lastItemClicked;
			if (num3 == 0)
			{
			}
			bool mouseLeft = Main.mouseLeft;
			int type;
			if (num3 != 0)
			{
				if (num3 == 0)
				{
				}
				if (Main.mouseItem != null)
				{
					if (num3 == 0)
					{
					}
					type = Main.mouseItem.type;
					if (type != 0)
					{
					}
				}
			}
			if (type == 0)
			{
			}
			Main.mouseRight = Main.mouseLeft;
			int myPlayer7 = Main.myPlayer;
			bool mouseRight = Main.mouseRight;
			int myPlayer8 = Main.myPlayer;
			return;
		}
		if (num == 0L)
		{
			float num4 = this.doubleClickTimer;
			int num5 = this.lastItemClicked;
			this.lastItemClicked = num5;
		}
		int myPlayer9 = Main.myPlayer;
		int myPlayer10 = Main.myPlayer;
		int myPlayer11 = Main.myPlayer;
		Recipe.FindRecipes(false);
		GUIControllerCoins guicontrollerCoins;
		if (guicontrollerCoins != null)
		{
			guicontrollerCoins.itemRow = index;
			return;
		}
	}

	// Token: 0x060007DE RID: 2014 RVA: 0x0001EFA4 File Offset: 0x0001D1A4
	private bool CanBeStored(Item checkItem)
	{
		/*
An exception occurred when decompiling this method (060007DE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUICoins::CanBeStored(Terraria.Item)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Item::type, ldloc:Item(checkItem)))
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

	// Token: 0x060007DF RID: 2015 RVA: 0x0001EFBC File Offset: 0x0001D1BC
	public void ItemDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		this.ItemOver(index);
		GUIControllerCoins guicontrollerCoins;
		guicontrollerCoins.itemRow = index;
		Mouse.UpdateUICursorPoint();
		int num = this.cursorOver;
		if (!true)
		{
		}
		if (this.itemOver == 0)
		{
		}
		bool useCollpasedCoinsAmmo = RightSideHUDAnchorUpdator.UseCollpasedCoinsAmmo;
		!0 instance = PageControllerLayoutDefinition.Instance;
		if (60 == 0)
		{
		}
		ItemSlot.SetSelectHighlight(true, scale);
		if (instance == null)
		{
		}
		Main.inventoryScale = scale;
		int myPlayer = Main.myPlayer;
		int num2 = 16256;
		int myPlayer2 = Main.myPlayer;
		if (num2 == 0)
		{
		}
	}

	// Token: 0x060007E0 RID: 2016 RVA: 0x0001F0BC File Offset: 0x0001D2BC
	public void Draw()
	{
		int num = 1;
		float num2 = this.doubleClickTimer;
		float deltaTime = Time.deltaTime;
		this.lastItemClicked = num;
		if (num == 0)
		{
		}
		if (num == 0)
		{
		}
		bool useCollpasedCoinsAmmo = RightSideHUDAnchorUpdator.UseCollpasedCoinsAmmo;
		!0 instance = PageControllerLayoutDefinition.Instance;
		this.itemOver = (int)deltaTime;
		bool useCollpasedCoinsAmmo2 = RightSideHUDAnchorUpdator.UseCollpasedCoinsAmmo;
		!0 instance2 = PageControllerLayoutDefinition.Instance;
		GUIItemGrid.GetItemScaleHandler itemScaleDelegate = this.ItemScaleDelegate;
		GUIItemGrid.CursorOver itemOverDelegate = this.ItemOverDelegate;
		GUIItemGrid.DrawItemHandler drawItemHandler = this.itemDrawDelegate;
		if (instance2 == null)
		{
		}
		if (this.rightClickHeld)
		{
			int num3 = this.itemOver;
		}
		int num4 = this.itemDragStart;
		if (num4 == 0)
		{
		}
		bool mouseLeft = Main.mouseLeft;
		if (num4 == 0)
		{
		}
		if (Main.mouseItem != null)
		{
			if (num4 == 0)
			{
			}
			int type = Main.mouseItem.type;
			if (type != 0)
			{
				this.itemDragStart = type;
				return;
			}
		}
		int num5 = this.itemDragStart;
		int num6 = this.itemOver;
		int myPlayer = Main.myPlayer;
		int num7 = this.itemDragStart;
		if (num6 == 0)
		{
		}
		Recipe.FindRecipes(false);
	}

	// Token: 0x0400066E RID: 1646
	private int itemOver = 1;

	// Token: 0x0400066F RID: 1647
	private int cursorOver;

	// Token: 0x04000670 RID: 1648
	private int itemDragStart = 1;

	// Token: 0x04000671 RID: 1649
	private int lastItemClicked;

	// Token: 0x04000672 RID: 1650
	private float doubleClickTimer;

	// Token: 0x04000673 RID: 1651
	private bool rightClickHeld;

	// Token: 0x04000674 RID: 1652
	public GUIItemGrid.GetItemScaleHandler ItemScaleDelegate;

	// Token: 0x04000675 RID: 1653
	private GUIItemGrid.CursorOver ItemOverDelegate;

	// Token: 0x04000676 RID: 1654
	private GUIItemGrid.DrawItemHandler itemDrawDelegate;
}
