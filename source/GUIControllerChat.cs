using System;
using Microsoft.Xna.Framework;

// Token: 0x0200008A RID: 138
public class GUIControllerChat : GUIControllerItem
{
	// Token: 0x0600035F RID: 863 RVA: 0x0000B0C4 File Offset: 0x000092C4
	public void Activate()
	{
		int <LineSpacing>k__BackingField = MultiplayerChat_Layout.Instance.ItemText.GetFont().<LineSpacing>k__BackingField;
		float scale = MultiplayerChat_Layout.Instance.ItemText.Scale;
	}

	// Token: 0x06000360 RID: 864 RVA: 0x0000B0FC File Offset: 0x000092FC
	public int GetNavigationOutDirs()
	{
	}

	// Token: 0x17000078 RID: 120
	// (get) Token: 0x06000361 RID: 865 RVA: 0x0000B10C File Offset: 0x0000930C
	private static int maxRowIndex
	{
		get
		{
			/*
An exception occurred when decompiling this method (06000361)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 GUIControllerChat::get_maxRowIndex()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_1_11, ldfld:int32(ItemGrid_Layout::ItemLineCount, ldfld:DraggableItemGrid_Layout[exp:ItemGrid_Layout](MultiplayerChat_Layout::EmotesGrid, callgetter:MultiplayerChat_Layout(MultiplayerChat_Layout::get_Instance))))
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

	// Token: 0x17000079 RID: 121
	// (get) Token: 0x06000362 RID: 866 RVA: 0x0000B12C File Offset: 0x0000932C
	private static int maxRowColumn
	{
		get
		{
			/*
An exception occurred when decompiling this method (06000362)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 GUIControllerChat::get_maxRowColumn()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_1_11, ldfld:int32(ItemGrid_Layout::ItemLineCount, ldfld:DraggableItemGrid_Layout[exp:ItemGrid_Layout](MultiplayerChat_Layout::EmotesGrid, callgetter:MultiplayerChat_Layout(MultiplayerChat_Layout::get_Instance))))
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

	// Token: 0x06000363 RID: 867 RVA: 0x0000B14C File Offset: 0x0000934C
	private void UpdateEmoteScroll()
	{
		int num = 1;
		DraggableItemGrid_Layout emotesGrid = MultiplayerChat_Layout.Instance.EmotesGrid;
		Rectangle rectangle = GUIPanel.Region(MultiplayerChat_Layout.Instance.EmotesGridBacking);
		ControlAnchor.ControlId firstAnchorControl = emotesGrid.FirstAnchorControl;
		Vector2 firstItemLocation = emotesGrid.FirstItemLocation;
		float x = emotesGrid.FirstItemLocation.X;
		float y = emotesGrid.FirstItemLocation.Y;
		if (num == 0)
		{
		}
		float x2 = emotesGrid.DragRegionEndItemLocation.X;
		float y2 = emotesGrid.DragRegionEndItemLocation.Y;
		ControlAnchor.ControlId dragRegionEndAnchorControl = emotesGrid.DragRegionEndAnchorControl;
		Vector2 dragRegionEndItemLocation = emotesGrid.DragRegionEndItemLocation;
		Rectangle rectangle2;
		ControlAnchor.SetGridItemRegion(rectangle2);
		if (num == 0)
		{
		}
		if (num == 0)
		{
		}
		float emoteScale = MultiplayerChat_Layout.Instance.EmoteScale;
		float y3 = emotesGrid.ExtraElementSpacing.Y;
		int selectedRow = this.SelectedRow;
	}

	// Token: 0x06000364 RID: 868 RVA: 0x0000B20C File Offset: 0x0000940C
	private static void UpdateScrollRegion()
	{
		int num = 1;
		DraggableItemGrid_Layout textGrid = MultiplayerChat_Layout.Instance.TextGrid;
		ControlAnchor.ControlId firstAnchorControl = textGrid.FirstAnchorControl;
		Vector2 firstItemLocation = textGrid.FirstItemLocation;
		float x = textGrid.FirstItemLocation.X;
		float y = textGrid.FirstItemLocation.Y;
		if (num == 0)
		{
		}
		float x2 = textGrid.DragRegionEndItemLocation.X;
		float y2 = textGrid.DragRegionEndItemLocation.Y;
		ControlAnchor.ControlId dragRegionEndAnchorControl = textGrid.DragRegionEndAnchorControl;
		Vector2 dragRegionEndItemLocation = textGrid.DragRegionEndItemLocation;
		if (num == 0)
		{
		}
		if ("Only TraceListeners can be added to a TraceListenerCollection." == null)
		{
		}
		float y3 = textGrid.ExtraElementSpacing.Y;
	}

	// Token: 0x06000365 RID: 869 RVA: 0x0000B2A4 File Offset: 0x000094A4
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		GUIControllerItem guicontrollerItem;
		do
		{
			GUIControllerChat.Controls controls = this.selectedControl;
			if (MultiplayerChat_Layout.Instance.TextGrid.Reorder == ItemGrid_Layout.ReorderStyle.None)
			{
			}
			ItemGrid_Layout.ReorderStyle reorder = MultiplayerChat_Layout.Instance.TextGrid.Reorder;
			GUIControllerChat.UpdateScrollRegion();
			int num = 7;
			this.selectedControl = (GUIControllerChat.Controls)num;
			if (MultiplayerChat_Layout.Instance.TextGrid.Reorder == ItemGrid_Layout.ReorderStyle.None)
			{
				GUIControllerChat.UpdateScrollRegion();
			}
			ItemGrid_Layout.ReorderStyle reorder2 = MultiplayerChat_Layout.Instance.TextGrid.Reorder;
		}
		while (guicontrollerItem != null);
		return guicontrollerItem;
	}

	// Token: 0x06000366 RID: 870 RVA: 0x0000B3F4 File Offset: 0x000095F4
	public Rectangle GetSelectedItemRegion()
	{
		GUIControllerChat.Controls controls = this.selectedControl;
		DraggableItemGrid_Layout emotesGrid = MultiplayerChat_Layout.Instance.EmotesGrid;
		ControlAnchor.SetGridItemRegion(GUIPanel.Region(MultiplayerChat_Layout.Instance.EmotesGridBacking));
		ControlAnchor.ControlId firstAnchorControl = emotesGrid.FirstAnchorControl;
		Vector2 firstItemLocation = emotesGrid.FirstItemLocation;
		float x = emotesGrid.FirstItemLocation.X;
		float y = emotesGrid.FirstItemLocation.Y;
		if (controls == GUIControllerChat.Controls.General)
		{
		}
		Rectangle rectangle;
		ControlAnchor.SetGridItemRegion(rectangle);
		if (controls == GUIControllerChat.Controls.General)
		{
		}
		float emoteScale = MultiplayerChat_Layout.Instance.EmoteScale;
		int selectedRow = this.SelectedRow;
		int selectedColumn = this.SelectedColumn;
		float x2 = emotesGrid.ExtraElementSpacing.X;
		float y2 = emotesGrid.ExtraElementSpacing.Y;
		return GUITransactionButton.GetRegion(MultiplayerChat_Layout.Instance.BeginChat);
	}

	// Token: 0x06000367 RID: 871 RVA: 0x0000B528 File Offset: 0x00009728
	public GUIControllerChat()
	{
	}

	// Token: 0x04000351 RID: 849
	public GUIControllerChat.Controls selectedControl = GUIControllerChat.Controls.Element;

	// Token: 0x04000352 RID: 850
	private static float maxScrollOffset;

	// Token: 0x04000353 RID: 851
	private static int lineSpacing;

	// Token: 0x04000354 RID: 852
	private int SelectedRow;

	// Token: 0x04000355 RID: 853
	private int SelectedColumn;

	// Token: 0x0200008B RID: 139
	public enum Controls
	{
		// Token: 0x04000357 RID: 855
		General,
		// Token: 0x04000358 RID: 856
		RPS,
		// Token: 0x04000359 RID: 857
		Items,
		// Token: 0x0400035A RID: 858
		BiomesAndEvents,
		// Token: 0x0400035B RID: 859
		TownNPCs,
		// Token: 0x0400035C RID: 860
		Critters,
		// Token: 0x0400035D RID: 861
		Bosses,
		// Token: 0x0400035E RID: 862
		Element,
		// Token: 0x0400035F RID: 863
		Back
	}
}
