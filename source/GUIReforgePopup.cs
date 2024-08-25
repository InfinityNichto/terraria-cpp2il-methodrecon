using System;
using Controller;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;

// Token: 0x02000168 RID: 360
public class GUIReforgePopup
{
	// Token: 0x06000A1D RID: 2589 RVA: 0x00030294 File Offset: 0x0002E494
	private void SetupBackingSize()
	{
		float y = this.CachedTextSize.Y;
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
		int num = 32768;
		int num2 = 28;
		if (num == 0)
		{
		}
		if (num2 == 0)
		{
		}
		int num3 = 32768;
		Item item;
		int stack = item.stack;
		int type = item.type;
		string hoverName = item.HoverName;
		if (num3 == 0)
		{
		}
	}

	// Token: 0x06000A1E RID: 2590 RVA: 0x000302F4 File Offset: 0x0002E4F4
	public void LoadRegion()
	{
		this.SetupBackingSize();
		Rectangle rectangle;
		ControlAnchor.SetGridItemRegion(rectangle);
	}

	// Token: 0x06000A1F RID: 2591 RVA: 0x00030310 File Offset: 0x0002E510
	public void OpenPopup()
	{
		if (!this.PopupDisplayed)
		{
			GUIInputRegionExclusive guiinputRegionExclusive;
			this.PickingInterceptor = guiinputRegionExclusive;
			guiinputRegionExclusive.Active = true;
		}
		this.PopupDisplayed = true;
	}

	// Token: 0x06000A20 RID: 2592 RVA: 0x0003033C File Offset: 0x0002E53C
	public void ClosePopup()
	{
		if (!this.PopupDisplayed || this.PickingInterceptor != null)
		{
		}
	}

	// Token: 0x06000A21 RID: 2593 RVA: 0x0003035C File Offset: 0x0002E55C
	public bool IsOver(Vector2 cursorPosition)
	{
		/*
An exception occurred when decompiling this method (06000A21)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIReforgePopup::IsOver(Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_003F:
	call:void(ControlAnchor::SetGridItemRegion, ldloc:Rectangle(var_8))
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

	// Token: 0x06000A22 RID: 2594 RVA: 0x000303B0 File Offset: 0x0002E5B0
	private void UpdateText()
	{
		int cachedTextLines = this.CachedTextLines;
		int num = this.numLines;
		float cachedLayoutSize = this.CachedLayoutSize;
		float cachedLayoutWrapSize = this.CachedLayoutWrapSize;
		int cachedMinTextHeight = this.CachedMinTextHeight;
	}

	// Token: 0x06000A23 RID: 2595 RVA: 0x00030408 File Offset: 0x0002E608
	public void LoadPanelRegion()
	{
		this.SetupBackingSize();
		Rectangle rectangle;
		ControlAnchor.SetGridItemRegion(rectangle);
	}

	// Token: 0x06000A24 RID: 2596 RVA: 0x00030424 File Offset: 0x0002E624
	public Rectangle GetRegion()
	{
		this.SetupBackingSize();
		Rectangle rectangle;
		return rectangle;
	}

	// Token: 0x06000A25 RID: 2597 RVA: 0x00030438 File Offset: 0x0002E638
	private void DrawItem()
	{
	}

	// Token: 0x06000A26 RID: 2598 RVA: 0x000304F0 File Offset: 0x0002E6F0
	private void UpdatePrefixes(Item reforgeItem)
	{
		int num = this.numLines;
		bool[] array = this.badPreFixLine;
		if (reforgeItem.prefix != 0)
		{
			Item item = this.tooltipPrefixComparisonItem;
			if (item != null)
			{
				int netID = item.netID;
				int netID2 = reforgeItem.netID;
			}
			int netID3 = reforgeItem.netID;
			int damage = reforgeItem.damage;
			if (16473 == 0)
			{
			}
			return;
		}
	}

	// Token: 0x06000A27 RID: 2599 RVA: 0x000308E4 File Offset: 0x0002EAE4
	public void DrawPrefixes()
	{
		int num = this.numLines;
		int num2 = 17136;
		bool[] array = this.badPreFixLine;
		if (array != null)
		{
			return;
		}
		if (array == null)
		{
		}
		string[] array2 = this.toolTipLine;
		if (num2 == 0)
		{
		}
		if (!true)
		{
		}
		SpriteFont spriteFont;
		int <LineSpacing>k__BackingField = spriteFont.<LineSpacing>k__BackingField;
	}

	// Token: 0x06000A28 RID: 2600 RVA: 0x00030980 File Offset: 0x0002EB80
	public void Draw()
	{
		if (!true)
		{
		}
		if (!true)
		{
		}
		Main.FlushBatches();
		if (this.PickingInterceptor != null)
		{
		}
		GUIControllerReforgePopup controller = this._controller;
		this._controller.Activate();
		Item item;
		this.UpdatePrefixes(item);
		this.UpdateText();
		this.SetupBackingSize();
		Rectangle rectangle;
		ControlAnchor.SetGridItemRegion(rectangle);
		float y = this.CachedTextSize.Y;
		this.DrawPrefixes();
		int openedFrame = this.OpenedFrame;
	}

	// Token: 0x06000A29 RID: 2601 RVA: 0x00030B0C File Offset: 0x0002ED0C
	public GUIReforgePopup()
	{
	}

	// Token: 0x06000A2A RID: 2602 RVA: 0x00030B20 File Offset: 0x0002ED20
	// Note: this type is marked as 'beforefieldinit'.
	static GUIReforgePopup()
	{
	}

	// Token: 0x040009F9 RID: 2553
	private static int reforgeItemNamePos;

	// Token: 0x040009FA RID: 2554
	private static int reforgeTextPos;

	// Token: 0x040009FB RID: 2555
	private static int reforgeTextBackingSize;

	// Token: 0x040009FC RID: 2556
	private static int defaultBackingWidth;

	// Token: 0x040009FD RID: 2557
	private int OpenedFrame;

	// Token: 0x040009FE RID: 2558
	public bool PopupDisplayed;

	// Token: 0x040009FF RID: 2559
	private GUIInputRegionExclusive PickingInterceptor;

	// Token: 0x04000A00 RID: 2560
	private float CachedLayoutSize;

	// Token: 0x04000A01 RID: 2561
	private float CachedLayoutWrapSize;

	// Token: 0x04000A02 RID: 2562
	private int CachedMinTextHeight;

	// Token: 0x04000A03 RID: 2563
	private Vector2 CachedTextSize;

	// Token: 0x04000A04 RID: 2564
	private int CachedTextLines;

	// Token: 0x04000A05 RID: 2565
	public GUIControllerReforgePopup _controller;

	// Token: 0x04000A06 RID: 2566
	private int numLines;

	// Token: 0x04000A07 RID: 2567
	private string[] toolTipLine;

	// Token: 0x04000A08 RID: 2568
	private bool[] badPreFixLine;

	// Token: 0x04000A09 RID: 2569
	private Item tooltipPrefixComparisonItem;
}
