using System;
using System.Collections.Generic;
using Controller;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.GameContent;
using Terraria.Localization;
using Terraria.ObjectData;

// Token: 0x0200016E RID: 366
public class GUIRubbleMaker
{
	// Token: 0x06000A56 RID: 2646 RVA: 0x00031A18 File Offset: 0x0002FC18
	public GUIRubbleMaker()
	{
		if (!true)
		{
		}
		if (!true)
		{
		}
		this.TimeSinceChange = (float)17096;
		base..ctor();
		GUIInputRegionExclusive guiinputRegionExclusive;
		this.PickingInterceptor = guiinputRegionExclusive;
		GUIInputRegionExclusive guiinputRegionExclusive2;
		this.PickingInterceptorMaterials = guiinputRegionExclusive2;
	}

	// Token: 0x1700010D RID: 269
	// (get) Token: 0x06000A57 RID: 2647 RVA: 0x00031A54 File Offset: 0x0002FC54
	public static bool DrawRubbleModeUI
	{
		get
		{
			/*
An exception occurred when decompiling this method (06000A57)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIRubbleMaker::get_DrawRubbleModeUI()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_1_0A, callgetter:int32(Main::get_myPlayer))
	stloc:int32(var_3_12, callgetter:int32(Main::get_myPlayer))
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

	// Token: 0x06000A58 RID: 2648 RVA: 0x00031A80 File Offset: 0x0002FC80
	public void PlayerMenuDisplayToggle()
	{
		int num = 1;
		if (num == 0)
		{
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			if (num == 0)
			{
				float x = RubbleMakerUI_Layout.Instance.TouchPanelOffset.X;
				float y = RubbleMakerUI_Layout.Instance.TouchPanelOffset.Y;
				return;
			}
		}
	}

	// Token: 0x06000A59 RID: 2649 RVA: 0x00031AF8 File Offset: 0x0002FCF8
	private Vector2 ClampPositionToScreen(Vector2 position, VirtualControlsHardwareConfigurationMapping_Layout slotConfig)
	{
		int num = 1;
		Panel_Layout backing = RubbleMakerUI_Layout.Instance.Backing;
		Rectangle rectangle = GUIPanel.Region(backing);
		if (num == 0)
		{
		}
		return 42190744;
	}

	// Token: 0x06000A5A RID: 2650 RVA: 0x00031BA8 File Offset: 0x0002FDA8
	private float MaterialItemScale(int index)
	{
		/*
An exception occurred when decompiling this method (06000A5A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUIRubbleMaker::MaterialItemScale(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_1_0C, ldfld:float32(RubbleMakerUI_Layout::MaterialScale, callgetter:RubbleMakerUI_Layout(RubbleMakerUI_Layout::get_Instance)))
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

	// Token: 0x06000A5B RID: 2651 RVA: 0x00031BC4 File Offset: 0x0002FDC4
	private float RubbleItemScale(int index)
	{
		/*
An exception occurred when decompiling this method (06000A5B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUIRubbleMaker::RubbleItemScale(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_1_0C, ldfld:float32(RubbleMakerUI_Layout::RubbleScale, callgetter:RubbleMakerUI_Layout(RubbleMakerUI_Layout::get_Instance)))
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

	// Token: 0x06000A5C RID: 2652 RVA: 0x000021DB File Offset: 0x000003DB
	private void MaterialItemOver(int i)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000A5D RID: 2653 RVA: 0x00031BE0 File Offset: 0x0002FDE0
	private void RubbleItemOver(int i)
	{
		FlexibleTileWand.OptionBucket selectedMaterial = this.SelectedMaterial;
		this.wasOverRubbleItem = true;
		this.cursorOverRubble = i;
		if (selectedMaterial != null)
		{
			if (selectedMaterial == null)
			{
			}
			bool mouseLeft = Main.mouseLeft;
			if (selectedMaterial == null)
			{
			}
			bool mouseLeftRelease = Main.mouseLeftRelease;
			int size = this.SelectedMaterial.Options._size;
			FlexibleTileWand.PlacementOption selectedOption = this.SelectedOption;
			List<FlexibleTileWand.PlacementOption> options = this.SelectedMaterial.Options;
			this.SelectedOption = options;
			if (!true)
			{
				return;
			}
		}
	}

	// Token: 0x06000A5E RID: 2654 RVA: 0x000021DB File Offset: 0x000003DB
	public void MaterialItemDraw(ItemGrid_Layout gridLayout, int i, Vector2 position, float scale)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000A5F RID: 2655 RVA: 0x000021DB File Offset: 0x000003DB
	public void RubbleItemDraw(ItemGrid_Layout gridLayout, int i, Vector2 position, float scale)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000A60 RID: 2656 RVA: 0x00031C50 File Offset: 0x0002FE50
	public void SetupPreview(int type, int style, int dir)
	{
		long num = 0L;
		TileObjectData tileData = TileObjectData.GetTileData(type, style, (int)num);
		if (tileData != null)
		{
			int randomStyleRange = tileData.RandomStyleRange;
			long num2 = 0L;
			TileObjectData tileData2 = TileObjectData.GetTileData(type, style, (int)num2);
			if (tileData2.Direction != TileObjectDirection.None)
			{
				TileObjectDirection direction = tileData2.Direction;
				TileObjectDirection direction2 = tileData2.Direction;
			}
			Point16 origin = tileData2.Origin;
			Point16 origin2 = tileData2.Origin;
			int width = tileData2.Width;
			int height = tileData2.Height;
			AnchorData anchorTop = tileData2.AnchorTop;
			return;
		}
	}

	// Token: 0x06000A61 RID: 2657 RVA: 0x00031DB8 File Offset: 0x0002FFB8
	public void DrawPreview(SpriteBatch sb, TileObjectPreviewData op, Vector2 position)
	{
		if (!true)
		{
		}
		ushort type = op._type;
		int alternate = op._alternate;
		int alternate2 = op._alternate;
		bool active = op._active;
		TileObjectData tileObjectData;
		int drawYOffset = tileObjectData.DrawYOffset;
		int drawXOffset = tileObjectData.DrawXOffset;
		int drawStyleOffset = tileObjectData.DrawStyleOffset;
		int styleWrapLimit = tileObjectData.StyleWrapLimit;
		int styleLineSkip = tileObjectData.StyleLineSkip;
		int? styleWrapLimitVisualOverride = tileObjectData.StyleWrapLimitVisualOverride;
		int? styleWrapLimitVisualOverride2 = tileObjectData.StyleWrapLimitVisualOverride;
		int? styleLineSkipVisualOverride = tileObjectData.styleLineSkipVisualOverride;
		int? styleLineSkipVisualOverride2 = tileObjectData.styleLineSkipVisualOverride;
	}

	// Token: 0x06000A62 RID: 2658 RVA: 0x00031EB0 File Offset: 0x000300B0
	private bool CanInteract()
	{
		/*
An exception occurred when decompiling this method (06000A62)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIRubbleMaker::CanInteract()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_003C:
	stloc:int32(var_10_44, callgetter:int32(Main::get_signHover))
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

	// Token: 0x06000A63 RID: 2659 RVA: 0x000021DB File Offset: 0x000003DB
	public void RefreshOptions()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x1700010E RID: 270
	// (get) Token: 0x06000A64 RID: 2660 RVA: 0x00031F04 File Offset: 0x00030104
	public int RubbleCount
	{
		get
		{
			FlexibleTileWand.OptionBucket selectedMaterial = this.SelectedMaterial;
			if (selectedMaterial != null)
			{
				return selectedMaterial.Options._size;
			}
		}
	}

	// Token: 0x1700010F RID: 271
	// (get) Token: 0x06000A65 RID: 2661 RVA: 0x00031F28 File Offset: 0x00030128
	public int MaterialCount
	{
		get
		{
			return this.MaterialOptions._size;
		}
	}

	// Token: 0x06000A66 RID: 2662 RVA: 0x00031F40 File Offset: 0x00030140
	public void DrawOverlay()
	{
		Cursor cursor;
		if (this.DisplayOptions && cursor != null)
		{
			bool displayMaterials;
			if (this.DisplayMaterials)
			{
				Rectangle rectangle = this.CalculateMaterialRegion();
				TransactionButton_Layout materialToggle = RubbleMakerUI_Layout.Instance.MaterialToggle;
				Rectangle pickRegion = GUITransactionButton.GetPickRegion(materialToggle);
				displayMaterials = this.DisplayMaterials;
				if (displayMaterials)
				{
				}
			}
			Panel_Layout backing = RubbleMakerUI_Layout.Instance.Backing;
			Rectangle rectangle2 = GUIPanel.Region(backing);
			float x = cursor.Position.x;
			float y = cursor.Position.y;
			if (!displayMaterials)
			{
			}
			this.Close();
		}
		bool drawRubbleModeUI = GUIRubbleMaker.DrawRubbleModeUI;
		bool displayOptions = this.DisplayOptions;
		if (displayOptions)
		{
			this.RefreshOptions();
			if (!displayOptions)
			{
			}
			Main.FlushBatches();
			string textValue = Language.GetTextValue("Mobile.FilterItemsClose");
			bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
			if (this.DisplayMaterials)
			{
				GUIInputRegionExclusive pickingInterceptor = this.PickingInterceptor;
				Panel_Layout backing2 = RubbleMakerUI_Layout.Instance.Backing;
				Rectangle rectangle3 = GUIPanel.Region(backing2);
				Panel_Layout backing3 = RubbleMakerUI_Layout.Instance.Backing;
				ControlAnchor.SetMainMenuPageRegion(rectangle3);
				Panel_Layout menuDivider = RubbleMakerUI_Layout.Instance.MenuDivider;
				Cursor cursor2;
				if (cursor2 != null)
				{
				}
				int myPlayer = Main.myPlayer;
				int myPlayer2 = Main.myPlayer;
				int num = 5329;
				TransactionButton_Layout sizeToggle = RubbleMakerUI_Layout.Instance.SizeToggle;
				GUITransactionButton.InputState inputState;
				if (inputState == GUITransactionButton.InputState.Clicked)
				{
					if (num == 0)
					{
					}
					return;
				}
				FlexibleTileWand.OptionBucket selectedMaterial;
				if (this.SelectedMaterial != null)
				{
					int itemTypeToConsume = this.SelectedMaterial.ItemTypeToConsume;
					selectedMaterial = this.SelectedMaterial;
					if (selectedMaterial != null)
					{
						return;
					}
				}
				else
				{
					Item item = this.EmptyItem;
				}
				if (selectedMaterial == null)
				{
				}
				List<FlexibleTileWand.PlacementOption> options = selectedMaterial.Options;
				RubbleMakerUI_Layout instance = RubbleMakerUI_Layout.Instance;
				List<FlexibleTileWand.OptionBucket> materialOptions = this.MaterialOptions;
				TransactionButton_Layout materialToggle2 = instance.MaterialToggle;
				int size = materialOptions._size;
				GUITransactionButton.InputState inputState2;
				if (inputState2 == GUITransactionButton.InputState.Clicked)
				{
					bool displayMaterials2 = this.DisplayMaterials;
					this.DisplayMaterials = displayMaterials2;
				}
				FlexibleTileWand.OptionBucket selectedMaterial2 = this.SelectedMaterial;
				if (selectedMaterial2 != null)
				{
					int size2 = selectedMaterial2.Options._size;
					return;
				}
				ItemGrid_Layout rubbleOptions = RubbleMakerUI_Layout.Instance.RubbleOptions;
				Rectangle rectangle4;
				if (rectangle4 == null)
				{
				}
				int mouseX = Main.mouseX;
				int mouseY = Main.mouseY;
				Vector2 smallRubblePreviewScaleOffset = RubbleMakerUI_Layout.Instance.SmallRubblePreviewScaleOffset;
				this.rubbleScaleOffset = smallRubblePreviewScaleOffset;
				RubbleMakerUI_Layout instance2 = RubbleMakerUI_Layout.Instance;
				return;
			}
			else
			{
				this.Close();
			}
		}
	}

	// Token: 0x06000A67 RID: 2663 RVA: 0x000322E4 File Offset: 0x000304E4
	public void CloseMaterials()
	{
		if (this.DisplayMaterials)
		{
		}
	}

	// Token: 0x06000A68 RID: 2664 RVA: 0x000322FC File Offset: 0x000304FC
	public void Close()
	{
		if (this.DisplayOptions)
		{
			if (this.DisplayMaterials)
			{
			}
			GUIControllerRubbleMaker controller = this._controller;
			int selectedItem = Main.LocalPlayer.selectedItem;
			return;
		}
	}

	// Token: 0x06000A69 RID: 2665 RVA: 0x00032330 File Offset: 0x00030530
	public bool IsOver(Vector2 cursorPosition)
	{
		if (!true)
		{
		}
		bool gameMenu = Main.gameMenu;
		if (this.DisplayOptions)
		{
			bool drawRubbleModeUI = GUIRubbleMaker.DrawRubbleModeUI;
			if (GUIPanel.Region(RubbleMakerUI_Layout.Instance.Backing) == null)
			{
			}
			bool flag;
			return flag;
		}
	}

	// Token: 0x06000A6A RID: 2666 RVA: 0x00032374 File Offset: 0x00030574
	public Rectangle CalculateMaterialRegion()
	{
		ControlAnchor.SetMainMenuPageRegion(GUIPanel.Region(RubbleMakerUI_Layout.Instance.Backing));
		RubbleMakerUI_Layout instance = RubbleMakerUI_Layout.Instance;
		ItemGrid_Layout materialOptions = instance.MaterialOptions;
		bool useCollpasedCoinsAmmo = RightSideHUDAnchorUpdator.UseCollpasedCoinsAmmo;
		float x = materialOptions.FirstItemLocation.X;
		materialOptions.FirstItemLocation.X = x;
		int size = this.MaterialOptions._size;
		float x2 = instance.MaterialBackingTLOffset.X;
		float y = instance.MaterialBackingTLOffset.Y;
		float x3 = instance.MaterialBackingBROffset.X;
		float y2 = instance.MaterialBackingBROffset.Y;
		Rectangle rectangle;
		return rectangle;
	}

	// Token: 0x06000A6B RID: 2667 RVA: 0x00032410 File Offset: 0x00030610
	public bool IsOverMaterial(Vector2 cursorPosition)
	{
		if (!true)
		{
		}
		bool gameMenu = Main.gameMenu;
		if (this.DisplayOptions && this.DisplayMaterials)
		{
			bool drawRubbleModeUI = GUIRubbleMaker.DrawRubbleModeUI;
			if (this.CalculateMaterialRegion() == null)
			{
			}
			bool flag;
			return flag;
		}
	}

	// Token: 0x06000A6C RID: 2668 RVA: 0x00032450 File Offset: 0x00030650
	public Rectangle CalculateRegion()
	{
		return GUIPanel.Region(RubbleMakerUI_Layout.Instance.Backing);
	}

	// Token: 0x06000A6D RID: 2669 RVA: 0x00032470 File Offset: 0x00030670
	private bool IsOverInventoryOpenButton(Vector2 position)
	{
		/*
An exception occurred when decompiling this method (06000A6D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIRubbleMaker::IsOverInventoryOpenButton(Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_003A:
	callsetter:Rectangle(ControlAnchor::set_PageGroupRegion, ldloc:Rectangle(var_4_0F))
	callsetter:Rectangle(ControlAnchor::set_PageContentRegion, ldloc:Rectangle(var_6_19))
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

	// Token: 0x04000A37 RID: 2615
	private int hoverItem = 1;

	// Token: 0x04000A38 RID: 2616
	public Vector2 PopupPosition;

	// Token: 0x04000A39 RID: 2617
	private bool wasOverMaterialItem;

	// Token: 0x04000A3A RID: 2618
	private int cursorOverMaterial;

	// Token: 0x04000A3B RID: 2619
	private bool wasOverRubbleItem;

	// Token: 0x04000A3C RID: 2620
	private int cursorOverRubble;

	// Token: 0x04000A3D RID: 2621
	private float[] ButtonScales;

	// Token: 0x04000A3E RID: 2622
	private float TimeSinceChange;

	// Token: 0x04000A3F RID: 2623
	private Item emptyItem;

	// Token: 0x04000A40 RID: 2624
	public TileObjectPreviewData objectPreview;

	// Token: 0x04000A41 RID: 2625
	private float ToggleButtonScale;

	// Token: 0x04000A42 RID: 2626
	public bool DisplayOptions;

	// Token: 0x04000A43 RID: 2627
	public bool DisplayMaterials;

	// Token: 0x04000A44 RID: 2628
	public GUIControllerRubbleMaker _controller;

	// Token: 0x04000A45 RID: 2629
	public float materialScrollOffset;

	// Token: 0x04000A46 RID: 2630
	private float materialScrollMomentum;

	// Token: 0x04000A47 RID: 2631
	private int materialScrollDragging;

	// Token: 0x04000A48 RID: 2632
	private Vector2 materialDragOffset;

	// Token: 0x04000A49 RID: 2633
	public float rubbleScrollOffset;

	// Token: 0x04000A4A RID: 2634
	private float rubbleScrollMomentum;

	// Token: 0x04000A4B RID: 2635
	private int rubbleScrollDragging;

	// Token: 0x04000A4C RID: 2636
	private Vector2 rubbleDragOffset;

	// Token: 0x04000A4D RID: 2637
	public FlexibleTileWand.PlacementOption SelectedOption;

	// Token: 0x04000A4E RID: 2638
	public FlexibleTileWand.OptionBucket SelectedMaterial;

	// Token: 0x04000A4F RID: 2639
	private List<FlexibleTileWand.OptionBucket> MaterialOptions;

	// Token: 0x04000A50 RID: 2640
	private Vector2 rubbleScaleOffset;

	// Token: 0x04000A51 RID: 2641
	private float rubbleScale;

	// Token: 0x04000A52 RID: 2642
	private Item EmptyItem;

	// Token: 0x04000A53 RID: 2643
	private bool wasExcluded;

	// Token: 0x04000A54 RID: 2644
	public GUIInputRegionExclusive PickingInterceptor;

	// Token: 0x04000A55 RID: 2645
	public GUIInputRegionExclusive PickingInterceptorMaterials;
}
