using System;
using Microsoft.Xna.Framework;

// Token: 0x02000079 RID: 121
public class GUIControllerMappingOverlay : GUIControllerItem
{
	// Token: 0x060002AE RID: 686 RVA: 0x000088B0 File Offset: 0x00006AB0
	public void Activate()
	{
		this.UpdateScroll();
	}

	// Token: 0x060002AF RID: 687 RVA: 0x000088C4 File Offset: 0x00006AC4
	public int GetNavigationOutDirs()
	{
	}

	// Token: 0x060002B0 RID: 688 RVA: 0x000088D4 File Offset: 0x00006AD4
	private void UpdateScroll()
	{
		int selectedItem = this._selectedItem;
		int selectedItem2 = this._selectedItem;
	}

	// Token: 0x060002B1 RID: 689 RVA: 0x000088F8 File Offset: 0x00006AF8
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		/*
An exception occurred when decompiling this method (060002B1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIControllerItem GUIControllerMappingOverlay::Navigate(Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000F:
	stloc:Controls(var_1_15, ldfld:Controls(GUIControllerMappingOverlay::selectedControl, ldloc:GUIControllerMappingOverlay(this)))
	stloc:int32(var_2_1C, ldfld:int32(GUIControllerMappingOverlay::_selectedItem, ldloc:GUIControllerMappingOverlay(this)))
	stfld:int32(GUIControllerMappingOverlay::_selectedItem, ldloc:GUIControllerMappingOverlay(this), ldloc:int32(var_2_1C))
	stloc:int32(var_3_2A, ldfld:int32(GUIControllerMappingOverlay::_overlayIndex, ldloc:GUIControllerMappingOverlay(this)))
	stloc:int32(var_5_31, ldfld:int32(GUIControllerMappingOverlay::_overlayIndex, ldloc:GUIControllerMappingOverlay(this)))
	stfld:int32(GUIControllerMappingOverlay::_overlayIndex, ldloc:GUIControllerMappingOverlay(this), ldloc:int32(var_5_31))
	stloc:int32(var_6_3D, ldc.i4:int32(10))
	stfld:Controls(GUIControllerMappingOverlay::selectedControl, ldloc:GUIControllerMappingOverlay(this), ldloc:int32[exp:Controls](var_6_3D))
	stloc:int32(var_7_49, ldc.i4:int32(12))
	stfld:Controls(GUIControllerMappingOverlay::selectedControl, ldloc:GUIControllerMappingOverlay(this), ldloc:int32[exp:Controls](var_7_49))
	stloc:int32(var_8_55, ldc.i4:int32(12))
	stfld:Controls(GUIControllerMappingOverlay::selectedControl, ldloc:GUIControllerMappingOverlay(this), ldloc:int32[exp:Controls](var_8_55))
	call:void(GUIControllerMappingOverlay::UpdateScroll, ldloc:GUIControllerMappingOverlay(this))
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

	// Token: 0x060002B2 RID: 690 RVA: 0x0000896C File Offset: 0x00006B6C
	public void ActivateOverlay(GUIControllerMappingEntry overlayEntry, Rectangle overlayRegion)
	{
		this._overlayEntry = overlayEntry;
		this._overlayRegion = overlayRegion;
	}

	// Token: 0x060002B3 RID: 691 RVA: 0x00008988 File Offset: 0x00006B88
	public void ActivateOverlay(GUIControllerPulldownEntry overlayEntry, Rectangle overlayRegion, int selectedOption, float offset)
	{
		this._overlayEntry = overlayEntry;
		this._overlayRegion = overlayRegion;
		this._overlayRegion.Width = selectedOption;
	}

	// Token: 0x060002B4 RID: 692 RVA: 0x000089B0 File Offset: 0x00006BB0
	public void DeactivateOverlay()
	{
	}

	// Token: 0x060002B5 RID: 693 RVA: 0x000089C0 File Offset: 0x00006BC0
	public Rectangle GetSelectedItemRegion()
	{
		if (this._overlayEntry != null)
		{
		}
		GUIControllerMappingOverlay.Controls controls = this.selectedControl;
		Rectangle overlayRegion = this._overlayRegion;
		int width = this._overlayRegion.Width;
		ControlAnchor.SetGridItemRegion(overlayRegion);
		int overlayIndex = this._overlayIndex;
		TransactionButton_Layout transactionButton_Layout;
		float x = transactionButton_Layout.overloadedSize.X;
		float x2 = transactionButton_Layout.Location.X;
		float y = transactionButton_Layout.Location.Y;
		transactionButton_Layout.Location.X = x;
		float overlayOffset = this._overlayOffset;
		transactionButton_Layout.Location.Y = overlayOffset;
		Rectangle region = GUITransactionButton.GetRegion(transactionButton_Layout);
		float x3 = transactionButton_Layout.overloadedSize.X;
		float x4 = transactionButton_Layout.Location.X;
		return region;
	}

	// Token: 0x060002B6 RID: 694 RVA: 0x00008ABC File Offset: 0x00006CBC
	public GUIControllerMappingOverlay()
	{
	}

	// Token: 0x04000304 RID: 772
	public GUIControllerMappingEntryBase _overlayEntry;

	// Token: 0x04000305 RID: 773
	public Rectangle _overlayRegion;

	// Token: 0x04000306 RID: 774
	public int _overlayIndex;

	// Token: 0x04000307 RID: 775
	public float _overlayOffset;

	// Token: 0x04000308 RID: 776
	public GUIControllerMappingOverlay.Controls selectedControl = GUIControllerMappingOverlay.Controls.Element;

	// Token: 0x04000309 RID: 777
	public int _selectedItem;

	// Token: 0x0200007A RID: 122
	public enum Controls
	{
		// Token: 0x0400030B RID: 779
		PageGeneral,
		// Token: 0x0400030C RID: 780
		PageExplore,
		// Token: 0x0400030D RID: 781
		PageFight,
		// Token: 0x0400030E RID: 782
		PageMisc,
		// Token: 0x0400030F RID: 783
		PageInventory,
		// Token: 0x04000310 RID: 784
		PageChest,
		// Token: 0x04000311 RID: 785
		PageEquipment,
		// Token: 0x04000312 RID: 786
		PageShopsCraft,
		// Token: 0x04000313 RID: 787
		PagePVP,
		// Token: 0x04000314 RID: 788
		PageMap,
		// Token: 0x04000315 RID: 789
		Element,
		// Token: 0x04000316 RID: 790
		Reset,
		// Token: 0x04000317 RID: 791
		Back
	}
}
