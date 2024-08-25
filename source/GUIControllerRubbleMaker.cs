using System;
using Microsoft.Xna.Framework;

// Token: 0x020000A3 RID: 163
public class GUIControllerRubbleMaker : GUIControllerItem
{
	// Token: 0x060003D8 RID: 984 RVA: 0x0000C928 File Offset: 0x0000AB28
	public void Activate()
	{
	}

	// Token: 0x060003D9 RID: 985 RVA: 0x0000C948 File Offset: 0x0000AB48
	public int GetNavigationOutDirs()
	{
	}

	// Token: 0x060003DA RID: 986 RVA: 0x0000C958 File Offset: 0x0000AB58
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		/*
An exception occurred when decompiling this method (060003DA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIControllerItem GUIControllerRubbleMaker::Navigate(Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00F8:
	stfld:bool(GUIControllerRubbleMaker::filterButton, ldloc:GUIControllerRubbleMaker(this), ldloc:int32[exp:bool](var_23))
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

	// Token: 0x060003DB RID: 987 RVA: 0x0000CA64 File Offset: 0x0000AC64
	private void ClampMaterialGrid()
	{
		ItemGrid_Layout materialOptions = RubbleMakerUI_Layout.Instance.MaterialOptions;
		int itemLineCount = materialOptions.ItemLineCount;
		int num = this.filterGridRow;
		this.filterGridRow = itemLineCount;
	}

	// Token: 0x060003DC RID: 988 RVA: 0x0000CAB0 File Offset: 0x0000ACB0
	private void ClampRubbleGrid()
	{
		ItemGrid_Layout rubbleOptions = RubbleMakerUI_Layout.Instance.RubbleOptions;
		int itemLineCount = rubbleOptions.ItemLineCount;
		int num = this.gridRow;
		this.gridRow = itemLineCount;
	}

	// Token: 0x060003DD RID: 989 RVA: 0x0000CB08 File Offset: 0x0000AD08
	public Rectangle GetSelectedItemRegion()
	{
		bool flag;
		RubbleMakerUI_Layout instance5;
		do
		{
			Rectangle rectangle;
			ControlAnchor.SetMainMenuPageRegion(rectangle);
			if (!this.wasInFilterGrid)
			{
				this.wasInFilterGrid = true;
			}
			this.ClampMaterialGrid();
			if (this.inGrid)
			{
				this.ClampRubbleGrid();
			}
			RubbleMakerUI_Layout instance = RubbleMakerUI_Layout.Instance;
			ItemGrid_Layout materialOptions = instance.MaterialOptions;
			ItemGrid_Layout rubbleOptions = instance.RubbleOptions;
			RubbleMakerUI_Layout instance2 = RubbleMakerUI_Layout.Instance;
			float materialScale = instance2.MaterialScale;
			ControlAnchor.ControlId firstAnchorControl = materialOptions.FirstAnchorControl;
			Vector2 firstItemLocation = materialOptions.FirstItemLocation;
			float x = materialOptions.FirstItemLocation.X;
			float y = materialOptions.FirstItemLocation.Y;
			if (instance2 == null)
			{
			}
			float x2 = materialOptions.ExtraElementSpacing.X;
			int num = this.filterGridRow;
			int num2 = this.filterGridCol;
			if (this.inGrid)
			{
				RubbleMakerUI_Layout instance3 = RubbleMakerUI_Layout.Instance;
				ItemGrid_Layout rubbleOptions2 = instance3.RubbleOptions;
				ItemGrid_Layout rubbleOptions3 = instance3.RubbleOptions;
				RubbleMakerUI_Layout instance4 = RubbleMakerUI_Layout.Instance;
				float rubbleScale = instance4.RubbleScale;
				ControlAnchor.ControlId firstAnchorControl2 = rubbleOptions2.FirstAnchorControl;
				Vector2 firstItemLocation2 = rubbleOptions2.FirstItemLocation;
				float x3 = rubbleOptions2.FirstItemLocation.X;
				float y2 = rubbleOptions2.FirstItemLocation.Y;
				if (instance4 == null)
				{
				}
				float x4 = rubbleOptions2.ExtraElementSpacing.X;
				int num3 = this.gridRow;
				int num4 = this.gridCol;
				float y3 = rubbleOptions2.ExtraElementSpacing.Y;
			}
			flag = this.filterButton;
			instance5 = RubbleMakerUI_Layout.Instance;
		}
		while (!flag);
		Texture_Layout backingDisabled = instance5.MaterialToggle.BackingDisabled;
		Rectangle rectangle2;
		return rectangle2;
	}

	// Token: 0x060003DE RID: 990 RVA: 0x0000CC7C File Offset: 0x0000AE7C
	public GUIControllerRubbleMaker()
	{
	}

	// Token: 0x040003BE RID: 958
	private bool wasInFilterGrid;

	// Token: 0x040003BF RID: 959
	private int filterGridRow;

	// Token: 0x040003C0 RID: 960
	private int filterGridCol;

	// Token: 0x040003C1 RID: 961
	private bool inGrid;

	// Token: 0x040003C2 RID: 962
	private int gridRow;

	// Token: 0x040003C3 RID: 963
	private int gridCol;

	// Token: 0x040003C4 RID: 964
	private bool filterButton;

	// Token: 0x040003C5 RID: 965
	private bool sizeButton;
}
