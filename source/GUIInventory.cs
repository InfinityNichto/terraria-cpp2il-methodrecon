using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Terraria;
using Terraria.Localization;
using UnityEngine;

// Token: 0x0200014B RID: 331
public class GUIInventory
{
	// Token: 0x06000900 RID: 2304 RVA: 0x00026908 File Offset: 0x00024B08
	public GUIInventory()
	{
	}

	// Token: 0x06000901 RID: 2305 RVA: 0x00026928 File Offset: 0x00024B28
	public void LoadPageRegion()
	{
		!0 instance = PageControllerLayoutDefinition.Instance;
		GUIItemGrid.GetItemScaleHandler itemScaleDelegate = this.ItemScaleDelegate;
		if (instance == null)
		{
		}
		!0 instance2 = PageControllerLayoutDefinition.Instance;
		GUIItemGrid.GetItemScaleHandler itemScaleDelegate2 = this.ItemScaleDelegate;
		if (instance2 == null)
		{
		}
		if (instance2 == null)
		{
		}
		!0 instance3 = PageControllerLayoutDefinition.Instance;
		if (instance3 == null)
		{
		}
		if (instance3 == null)
		{
		}
		!0 instance4 = PageControllerLayoutDefinition.Instance;
		Rectangle rectangle;
		ControlAnchor.PageContentRegion = rectangle;
	}

	// Token: 0x06000902 RID: 2306 RVA: 0x00026978 File Offset: 0x00024B78
	public Item GetSelectedItem()
	{
		/*
An exception occurred when decompiling this method (06000902)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Item GUIInventory::GetSelectedItem()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0015:
	stloc:int32(var_5_1D, callgetter:int32(Main::get_myPlayer))
	stloc:int32(var_7_27, callgetter:int32(Main::get_myPlayer))
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

	// Token: 0x06000903 RID: 2307 RVA: 0x000269B0 File Offset: 0x00024BB0
	public float ItemScale(int index)
	{
		/*
An exception occurred when decompiling this method (06000903)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUIInventory::ItemScale(System.Int32)

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

	// Token: 0x06000904 RID: 2308 RVA: 0x000269C4 File Offset: 0x00024BC4
	public void ItemOver(int index)
	{
		int num = this.itemOffset;
		int myPlayer = Main.myPlayer;
		int myPlayer2 = Main.myPlayer;
		int myPlayer3 = Main.myPlayer;
		int myPlayer4 = Main.myPlayer;
		int myPlayer5 = Main.myPlayer;
		int myPlayer6 = Main.myPlayer;
		bool isAir = Main.mouseItem.IsAir;
		int myPlayer7 = Main.myPlayer;
		int myPlayer8 = Main.myPlayer;
		int myPlayer9 = Main.myPlayer;
		int myPlayer10 = Main.myPlayer;
		int myPlayer11 = Main.myPlayer;
		int myPlayer12 = Main.myPlayer;
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
		int myPlayer13 = Main.myPlayer;
		long num2 = 0L;
		this.cursorOver = index;
		int myPlayer14 = Main.myPlayer;
		int myPlayer15 = Main.myPlayer;
		int cursorOverride = Main.cursorOverride;
		int num3 = 49024;
		this.doubleClickTimer = (float)num3;
		if (num2 != 0L)
		{
			if (num3 == 0)
			{
			}
			int myPlayer16 = Main.myPlayer;
			if (num3 == 0)
			{
			}
			Recipe.FindRecipes(false);
			this.itemDragStart = num3;
			this.itemOver = num3;
		}
		string textValue = Language.GetTextValue("ControllerMappings.TakeOne");
		int myPlayer17 = Main.myPlayer;
		Recipe.FindRecipes(false);
	}

	// Token: 0x06000905 RID: 2309 RVA: 0x00026D14 File Offset: 0x00024F14
	public void ItemDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		int num = this.itemOffset;
		this.ItemOver(index);
		Mouse.UpdateUICursorPoint();
		if (this.itemOver == 0)
		{
		}
		int myPlayer = Main.myPlayer;
		!0 instance = PageControllerLayoutDefinition.Instance;
		!0 instance2 = PageControllerLayoutDefinition.Instance;
		!0 instance3 = PageControllerLayoutDefinition.Instance;
		if (instance3 == null)
		{
		}
		if (instance3 == null)
		{
		}
		int myPlayer2 = Main.myPlayer;
		if (instance3 == null)
		{
		}
		int num2 = 16256;
		if (instance3 == null)
		{
		}
		int myPlayer3 = Main.myPlayer;
		if (num2 == 0)
		{
		}
	}

	// Token: 0x170000E3 RID: 227
	// (get) Token: 0x06000906 RID: 2310 RVA: 0x00026DA8 File Offset: 0x00024FA8
	public bool HasFocus
	{
		get
		{
			DrPlatform.DrPlatformType currentPlatform = DrPlatform.CurrentPlatform;
			return true;
		}
	}

	// Token: 0x06000907 RID: 2311 RVA: 0x00026DC0 File Offset: 0x00024FC0
	public void Draw()
	{
		int num = 1;
		float deltaTime = Time.deltaTime;
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
			return;
		}
		if (PageControllerLayoutDefinition.Instance == null)
		{
		}
		if (PageControllerLayoutDefinition.Instance == null)
		{
		}
	}

	// Token: 0x06000908 RID: 2312 RVA: 0x00026EA4 File Offset: 0x000250A4
	public void DrawItem(SpriteBatch spriteBatch, ItemGrid_Layout gridLayout, Item[] inv, int slot, Microsoft.Xna.Framework.Vector2 position, Microsoft.Xna.Framework.Graphics.Color lightColor, float scale)
	{
		int num = 1;
		if (num == 0)
		{
		}
		int myPlayer = Main.myPlayer;
		if (num == 0)
		{
		}
		int gameMode = Main.GameMode;
	}

	// Token: 0x0400086D RID: 2157
	private int cursorOver;

	// Token: 0x0400086E RID: 2158
	private int itemOver;

	// Token: 0x0400086F RID: 2159
	private int itemOffset;

	// Token: 0x04000870 RID: 2160
	private int lastItemClicked;

	// Token: 0x04000871 RID: 2161
	private int itemDragStart;

	// Token: 0x04000872 RID: 2162
	private float doubleClickTimer;

	// Token: 0x04000873 RID: 2163
	private bool rightClickHeld;

	// Token: 0x04000874 RID: 2164
	private float favoriteButtonScale = (float)16256;

	// Token: 0x04000875 RID: 2165
	public bool InHandItemActionHappened;

	// Token: 0x04000876 RID: 2166
	private GUIItemGrid.GetItemScaleHandler ItemScaleDelegate;

	// Token: 0x04000877 RID: 2167
	private GUIItemGrid.CursorOver ItemOverDelegate;

	// Token: 0x04000878 RID: 2168
	private GUIItemGrid.DrawItemHandler itemDrawDelegate;
}
