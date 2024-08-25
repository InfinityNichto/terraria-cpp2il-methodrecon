using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Terraria;
using Terraria.Localization;
using Terraria.UI;
using UnityEngine;

// Token: 0x02000122 RID: 290
public class GUIAmmo
{
	// Token: 0x06000746 RID: 1862 RVA: 0x0001ACA4 File Offset: 0x00018EA4
	public GUIAmmo()
	{
	}

	// Token: 0x06000747 RID: 1863 RVA: 0x0001ACC8 File Offset: 0x00018EC8
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

	// Token: 0x06000748 RID: 1864 RVA: 0x0001ACF0 File Offset: 0x00018EF0
	private bool CanBeStored(Item checkItem)
	{
		int ammo = checkItem.ammo;
		int bait = checkItem.bait;
		if (checkItem.notAmmo)
		{
			int type = checkItem.type;
		}
		return true;
	}

	// Token: 0x06000749 RID: 1865 RVA: 0x0001AD1C File Offset: 0x00018F1C
	public float ItemScale(int index)
	{
		/*
An exception occurred when decompiling this method (06000749)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUIAmmo::ItemScale(System.Int32)

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

	// Token: 0x0600074A RID: 1866 RVA: 0x0001AD38 File Offset: 0x00018F38
	public void ItemOver(int index)
	{
		int myPlayer = Main.myPlayer;
		bool isAir = Main.mouseItem.IsAir;
		int myPlayer2 = Main.myPlayer;
		int myPlayer3 = Main.myPlayer;
		int myPlayer4 = Main.myPlayer;
		int myPlayer5 = Main.myPlayer;
		int myPlayer6 = Main.myPlayer;
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
		bool flag = this.rightClickHeld;
		int num3;
		if (num == 0L && !flag)
		{
			float num2 = this.doubleClickTimer;
			num3 = this.lastItemClicked;
			this.lastItemClicked = num3;
		}
		if (flag)
		{
			int num4 = this.lastItemClicked;
			int num5 = this.lastItemClicked;
			if (num5 == 0)
			{
			}
			bool mouseLeft = Main.mouseLeft;
			int type;
			if (num5 != 0)
			{
				if (num5 == 0)
				{
				}
				if (Main.mouseItem != null)
				{
					if (num5 == 0)
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
			if (num3 == 0)
			{
			}
			bool mouseRight = Main.mouseRight;
			int myPlayer8 = Main.myPlayer;
			return;
		}
		int myPlayer9 = Main.myPlayer;
		int myPlayer10 = Main.myPlayer;
		int myPlayer11 = Main.myPlayer;
		if (num3 == 0)
		{
		}
		Recipe.FindRecipes(false);
		if (num3 == 0)
		{
			GUIControllerAmmo guicontrollerAmmo;
			if (guicontrollerAmmo != null)
			{
				guicontrollerAmmo.itemRow = index;
				return;
			}
			return;
		}
		else
		{
			bool mouseLeft2 = Main.mouseLeft;
			int type2;
			if (Main.mouseItem == null || Main.mouseItem.type == 0)
			{
				int num6 = this.itemDragStart;
				if (num6 == 0)
				{
				}
				bool mouseLeftRelease = Main.mouseLeftRelease;
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
					type2 = Main.mouseItem.type;
					if (type2 != 0)
					{
					}
				}
			}
			if (type2 == 0)
			{
			}
			int myPlayer12 = Main.myPlayer;
			int cursorOverride = Main.cursorOverride;
			int num7;
			int num8;
			if (num7 != 0)
			{
				if (type2 == 0)
				{
				}
				int myPlayer13 = Main.myPlayer;
				if (num8 == 0)
				{
				}
				if (type2 == 0)
				{
				}
				Recipe.FindRecipes(false);
				this.itemDragStart = type2;
				this.itemOver = type2;
			}
			if (num8 != 0)
			{
				string textValue = Language.GetTextValue("ControllerMappings.TakeOne");
				int myPlayer14 = Main.myPlayer;
				Recipe.FindRecipes(false);
				return;
			}
			return;
		}
	}

	// Token: 0x0600074B RID: 1867 RVA: 0x0001B074 File Offset: 0x00019274
	public void ItemDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		this.ItemOver(index);
		GUIControllerAmmo guicontrollerAmmo;
		guicontrollerAmmo.itemRow = index;
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

	// Token: 0x0600074C RID: 1868 RVA: 0x0001B194 File Offset: 0x00019394
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

	// Token: 0x040005AD RID: 1453
	private int itemOver = 1;

	// Token: 0x040005AE RID: 1454
	private int cursorOver;

	// Token: 0x040005AF RID: 1455
	private int itemDragStart = 1;

	// Token: 0x040005B0 RID: 1456
	private int lastItemClicked;

	// Token: 0x040005B1 RID: 1457
	private float doubleClickTimer;

	// Token: 0x040005B2 RID: 1458
	private bool rightClickHeld;

	// Token: 0x040005B3 RID: 1459
	public GUIItemGrid.GetItemScaleHandler ItemScaleDelegate;

	// Token: 0x040005B4 RID: 1460
	private GUIItemGrid.CursorOver ItemOverDelegate;

	// Token: 0x040005B5 RID: 1461
	private GUIItemGrid.DrawItemHandler itemDrawDelegate;
}
