using System;
using Controller;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using UnityEngine;

// Token: 0x02000155 RID: 341
public class GUIMana
{
	// Token: 0x06000950 RID: 2384 RVA: 0x00028BCC File Offset: 0x00026DCC
	public GUIMana()
	{
	}

	// Token: 0x170000E7 RID: 231
	// (get) Token: 0x06000951 RID: 2385 RVA: 0x00028C0C File Offset: 0x00026E0C
	public ItemGrid_Layout ManaGrid
	{
		get
		{
			/*
An exception occurred when decompiling this method (06000951)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ItemGrid_Layout GUIMana::get_ManaGrid()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_1_07, callgetter:bool(ControllerActionManager::get_AnyControllerConnected))
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
	}

	// Token: 0x170000E8 RID: 232
	// (get) Token: 0x06000952 RID: 2386 RVA: 0x00028C20 File Offset: 0x00026E20
	public String_Layout ManaTitle
	{
		get
		{
			/*
An exception occurred when decompiling this method (06000952)

ICSharpCode.Decompiler.DecompilerException: Error decompiling String_Layout GUIMana::get_ManaTitle()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_1_07, callgetter:bool(ControllerActionManager::get_AnyControllerConnected))
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
	}

	// Token: 0x170000E9 RID: 233
	// (get) Token: 0x06000953 RID: 2387 RVA: 0x00028C34 File Offset: 0x00026E34
	public String_Layout ManaValue
	{
		get
		{
			/*
An exception occurred when decompiling this method (06000953)

ICSharpCode.Decompiler.DecompilerException: Error decompiling String_Layout GUIMana::get_ManaValue()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_1_07, callgetter:bool(ControllerActionManager::get_AnyControllerConnected))
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
	}

	// Token: 0x06000954 RID: 2388 RVA: 0x00028C48 File Offset: 0x00026E48
	public Rectangle GetManaRegion()
	{
		RightSideHUDAnchorUpdator.Update();
		Rectangle right_Root = ControlAnchor.Right_Root;
		if (!true)
		{
		}
		Microsoft.Xna.Framework.Vector2 vector = right_Root.TopLeft();
		ItemGrid_Layout itemGrid_Layout;
		bool flag = this.LayoutCache.Dirty(itemGrid_Layout);
		float x = this.lastAnchorPoint.X;
		float y = this.lastAnchorPoint.Y;
		int num = this.starCount;
		CachedGridLayoutSettings layoutCache = this.LayoutCache;
		this.lastStarCount = num;
		layoutCache.Cache(itemGrid_Layout);
		GUIItemGrid.GetItemScaleHandler getItemScaleHandler = this.starScale;
		int num2 = this.starCount;
		if (num == 0)
		{
		}
		Rectangle rectangle;
		this.StarsRegion = rectangle;
		this.StarsRegion.Width = getItemScaleHandler;
		Rectangle starsRegion = this.StarsRegion;
		int width = this.StarsRegion.Width;
		return starsRegion;
	}

	// Token: 0x06000955 RID: 2389 RVA: 0x00028CFC File Offset: 0x00026EFC
	private void AdjustForTouchReturn(ItemGrid_Layout grid)
	{
	}

	// Token: 0x06000956 RID: 2390 RVA: 0x00028D0C File Offset: 0x00026F0C
	private void RestoreForTouchButton(ItemGrid_Layout grid)
	{
	}

	// Token: 0x06000957 RID: 2391 RVA: 0x000021DB File Offset: 0x000003DB
	private float StarScale(int index)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000958 RID: 2392 RVA: 0x00028D1C File Offset: 0x00026F1C
	private void StarOver(int index)
	{
		if (!true)
		{
		}
		bool mouseLeft = Main.mouseLeft;
		if (!true)
		{
		}
		bool mouseLeftRelease = Main.mouseLeftRelease;
		if (!true)
		{
		}
		int mouseX = Main.mouseX;
		int mouseY = Main.mouseY;
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
		QuickActionButton_Layout quickActionButton_Layout;
		Microsoft.Xna.Framework.Graphics.Texture2D texture = quickActionButton_Layout.BackingNormal.Texture;
		QuickActionButton_Layout quickActionButton_Layout2;
		Microsoft.Xna.Framework.Graphics.Texture2D texture2 = quickActionButton_Layout2.BackingNormal.Texture;
	}

	// Token: 0x06000959 RID: 2393 RVA: 0x00028D7C File Offset: 0x00026F7C
	private void StarDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		int num = this.starCount;
		if (gridLayout.ItemLineCount == 0)
		{
		}
	}

	// Token: 0x0600095A RID: 2394 RVA: 0x00028F88 File Offset: 0x00027188
	public void Draw()
	{
		int myPlayer = Main.myPlayer;
		int myPlayer2 = Main.myPlayer;
		int lastValue = this.LastValue;
		int myPlayer3 = Main.myPlayer;
		float timeSinceChange = this.TimeSinceChange;
		float deltaTime = Time.deltaTime;
	}

	// Token: 0x040008F8 RID: 2296
	private int starMana;

	// Token: 0x040008F9 RID: 2297
	private int starCount;

	// Token: 0x040008FA RID: 2298
	private int lastStarCount;

	// Token: 0x040008FB RID: 2299
	private CachedGridLayoutSettings LayoutCache;

	// Token: 0x040008FC RID: 2300
	private Rectangle StarsRegion;

	// Token: 0x040008FD RID: 2301
	private Microsoft.Xna.Framework.Vector2 lastAnchorPoint;

	// Token: 0x040008FE RID: 2302
	private Microsoft.Xna.Framework.Vector2 manaBackingSingleOffset = 1;

	// Token: 0x040008FF RID: 2303
	private Microsoft.Xna.Framework.Vector2 manaBackingTopOffset = 1;

	// Token: 0x04000900 RID: 2304
	private Microsoft.Xna.Framework.Vector2 manaBackingBottomOffset = 1;

	// Token: 0x04000901 RID: 2305
	private Microsoft.Xna.Framework.Vector2 manaBackingMidOffset = 1;

	// Token: 0x04000902 RID: 2306
	private Microsoft.Xna.Framework.Vector2 manaBackingLeftBarOffset;

	// Token: 0x04000903 RID: 2307
	private Microsoft.Xna.Framework.Vector2 manaBackingMidBarOffset = 1;

	// Token: 0x04000904 RID: 2308
	private Microsoft.Xna.Framework.Vector2 manaBackingRightBarOffset = 1;

	// Token: 0x04000905 RID: 2309
	private GUIItemGrid.CursorOver starOver;

	// Token: 0x04000906 RID: 2310
	private GUIItemGrid.GetItemScaleHandler starScale;

	// Token: 0x04000907 RID: 2311
	private GUIItemGrid.DrawItemHandler starDraw;

	// Token: 0x04000908 RID: 2312
	private float TimeSinceChange;

	// Token: 0x04000909 RID: 2313
	private int LastValue;
}
