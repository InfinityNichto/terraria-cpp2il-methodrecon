using System;
using Controller;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using UnityEngine;

// Token: 0x02000146 RID: 326
public class GUIHearts
{
	// Token: 0x060008D3 RID: 2259 RVA: 0x00025340 File Offset: 0x00023540
	public GUIHearts()
	{
	}

	// Token: 0x170000DE RID: 222
	// (get) Token: 0x060008D4 RID: 2260 RVA: 0x00025384 File Offset: 0x00023584
	public ItemGrid_Layout HeartsGrid
	{
		get
		{
			/*
An exception occurred when decompiling this method (060008D4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ItemGrid_Layout GUIHearts::get_HeartsGrid()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_1_07, callgetter:bool(ControllerActionManager::get_AnyControllerConnected))
	stloc:ResourceSet(var_2_0E, ldfld:ResourceSet(GUIHearts::ActiveSet, ldloc:GUIHearts(this)))
	stloc:ResourceSet(var_3_15, ldfld:ResourceSet(GUIHearts::ActiveSet, ldloc:GUIHearts(this)))
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

	// Token: 0x060008D5 RID: 2261 RVA: 0x000253A8 File Offset: 0x000235A8
	public Rectangle GetHeartsRegion()
	{
		RightSideHUDAnchorUpdator.Update();
		Rectangle right_Root = ControlAnchor.Right_Root;
		if (!true)
		{
		}
		Microsoft.Xna.Framework.Vector2 vector = right_Root.TopLeft();
		ItemGrid_Layout heartsGrid = this.HeartsGrid;
		int num = this.lastHeartCount;
		int num2 = this.heartCount;
		bool flag = this.LayoutCache.Dirty(heartsGrid);
		float x = this.lastAnchorPoint.X;
		float y = this.lastAnchorPoint.Y;
		int num3 = this.heartCount;
		CachedGridLayoutSettings layoutCache = this.LayoutCache;
		this.lastHeartCount = num3;
		layoutCache.Cache(heartsGrid);
		int num4 = this.heartCount;
		if (num3 == 0)
		{
		}
		if (num2 == 0)
		{
		}
		Rectangle rectangle;
		this.HeartsRegion = rectangle;
		Rectangle heartsRegion = this.HeartsRegion;
		int width = this.HeartsRegion.Width;
		return heartsRegion;
	}

	// Token: 0x060008D6 RID: 2262 RVA: 0x00025464 File Offset: 0x00023664
	private void DrawLifeString()
	{
		int num = 1;
		int lastValue = this.LastValue;
		if (num == 0)
		{
		}
		int myPlayer = Main.myPlayer;
		float timeSinceChange = this.TimeSinceChange;
		float deltaTime = Time.deltaTime;
	}

	// Token: 0x060008D7 RID: 2263 RVA: 0x000021DB File Offset: 0x000003DB
	private float HeartScale(int index)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060008D8 RID: 2264 RVA: 0x00025514 File Offset: 0x00023714
	private void HeartOver(int index)
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

	// Token: 0x060008D9 RID: 2265 RVA: 0x00025574 File Offset: 0x00023774
	private void HeartDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		int num = 1;
		if (num == 0)
		{
		}
		int myPlayer = Main.myPlayer;
		float num2 = this.heartLife;
		if (num == 0)
		{
		}
		int myPlayer2 = Main.myPlayer;
		float num3 = this.heartLife;
	}

	// Token: 0x060008DA RID: 2266 RVA: 0x000257DC File Offset: 0x000239DC
	private void AdjustForTouchReturn(ItemGrid_Layout grid)
	{
		float x = grid.FirstItemLocation.X;
		grid.FirstItemLocation.X = x;
	}

	// Token: 0x060008DB RID: 2267 RVA: 0x00025804 File Offset: 0x00023A04
	private void RestoreForTouchButton(ItemGrid_Layout grid)
	{
		float x = grid.FirstItemLocation.X;
		grid.FirstItemLocation.X = x;
	}

	// Token: 0x060008DC RID: 2268 RVA: 0x0002582C File Offset: 0x00023A2C
	public void Draw()
	{
		int myPlayer = Main.myPlayer;
	}

	// Token: 0x0400079B RID: 1947
	public GUIHearts.ResourceSet ActiveSet = GUIHearts.ResourceSet.New;

	// Token: 0x0400079C RID: 1948
	private float heartLife;

	// Token: 0x0400079D RID: 1949
	private int heartCountOriginal;

	// Token: 0x0400079E RID: 1950
	private int heartCount;

	// Token: 0x0400079F RID: 1951
	private int fruitHearts;

	// Token: 0x040007A0 RID: 1952
	private int lastHeartCount;

	// Token: 0x040007A1 RID: 1953
	private CachedGridLayoutSettings LayoutCache;

	// Token: 0x040007A2 RID: 1954
	private Microsoft.Xna.Framework.Vector2 lastAnchorPoint;

	// Token: 0x040007A3 RID: 1955
	private Rectangle HeartsRegion;

	// Token: 0x040007A4 RID: 1956
	private Microsoft.Xna.Framework.Vector2 heartBackingSingleOffset;

	// Token: 0x040007A5 RID: 1957
	private Microsoft.Xna.Framework.Vector2 heartBackingLeftOffset = 1;

	// Token: 0x040007A6 RID: 1958
	private Microsoft.Xna.Framework.Vector2 heartBackingRightOffset = 1;

	// Token: 0x040007A7 RID: 1959
	private Microsoft.Xna.Framework.Vector2 heartBackingRightFancyOffset = 1;

	// Token: 0x040007A8 RID: 1960
	private Microsoft.Xna.Framework.Vector2 heartBackingMidOffset = 1;

	// Token: 0x040007A9 RID: 1961
	private Microsoft.Xna.Framework.Vector2 heartBackingLeftBarOffset;

	// Token: 0x040007AA RID: 1962
	private Microsoft.Xna.Framework.Vector2 heartBackingMidBarOffset = 1;

	// Token: 0x040007AB RID: 1963
	private Microsoft.Xna.Framework.Vector2 heartBackingRightBarOffset = 1;

	// Token: 0x040007AC RID: 1964
	private float TimeSinceChange;

	// Token: 0x040007AD RID: 1965
	private int LastValue;

	// Token: 0x040007AE RID: 1966
	private GUIItemGrid.GetItemScaleHandler heartScale;

	// Token: 0x040007AF RID: 1967
	private GUIItemGrid.CursorOver heartOver;

	// Token: 0x040007B0 RID: 1968
	private GUIItemGrid.DrawItemHandler heartDraw;

	// Token: 0x02000147 RID: 327
	public enum ResourceSet
	{
		// Token: 0x040007B2 RID: 1970
		Default,
		// Token: 0x040007B3 RID: 1971
		New,
		// Token: 0x040007B4 RID: 1972
		HorizontalBars
	}
}
