using System;
using Microsoft.Xna.Framework;

// Token: 0x02000094 RID: 148
public class GUIControllerJourneyModeSettings : GUIControllerItem
{
	// Token: 0x0600038F RID: 911 RVA: 0x0000BD10 File Offset: 0x00009F10
	public void SelectedSetting(int index)
	{
		this.selectedControl = GUIControllerJourneyModeSettings.Controls.Element;
	}

	// Token: 0x06000390 RID: 912 RVA: 0x0000BD24 File Offset: 0x00009F24
	public void Activate()
	{
		this.UpdateScroll();
	}

	// Token: 0x06000391 RID: 913 RVA: 0x0000BD38 File Offset: 0x00009F38
	public int GetNavigationOutDirs()
	{
	}

	// Token: 0x06000392 RID: 914 RVA: 0x0000BD48 File Offset: 0x00009F48
	private void UpdateScroll()
	{
		int selectedItem = this._selectedItem;
		int selectedItem2 = this._selectedItem;
	}

	// Token: 0x06000393 RID: 915 RVA: 0x0000BD6C File Offset: 0x00009F6C
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		/*
An exception occurred when decompiling this method (06000393)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIControllerItem GUIControllerJourneyModeSettings::Navigate(Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0011:
	stloc:Controls(var_2_17, ldfld:Controls(GUIControllerJourneyModeSettings::selectedControl, ldloc:GUIControllerJourneyModeSettings(this)))
	stloc:int32(var_3_1E, ldfld:int32(GUIControllerJourneyModeSettings::_overlayIndex, ldloc:GUIControllerJourneyModeSettings(this)))
	stloc:int32(var_4_25, call:int32(GUIPulldownSetting::GetNumberOfOptions, ldloc:GUIPulldownSetting(var_0_06)))
	stloc:int32(var_5_2D, ldfld:int32(GUIControllerJourneyModeSettings::_overlayIndex, ldloc:GUIControllerJourneyModeSettings(this)))
	stfld:int32(GUIControllerJourneyModeSettings::_overlayIndex, ldloc:GUIControllerJourneyModeSettings(this), ldloc:int32(var_5_2D))
	stloc:GUIPulldownSetting(var_6_3D, ldfld:GUIPulldownSetting(GUIControllerJourneyModeSettings::_overlayEntry, ldloc:GUIControllerJourneyModeSettings(this)))
	stloc:int32(var_7_45, ldfld:int32(GUIControllerJourneyModeSettings::_overlayIndex, ldloc:GUIControllerJourneyModeSettings(this)))
	stfld:int32(GUIPulldownSetting::selectedPosition, ldloc:GUIPulldownSetting(var_6_3D), ldloc:int32(var_7_45))
	stloc:int32(var_8_51, ldc.i4:int32(3))
	stfld:Controls(GUIControllerJourneyModeSettings::selectedControl, ldloc:GUIControllerJourneyModeSettings(this), ldloc:int32[exp:Controls](var_8_51))
	stloc:int32(var_9_61, ldfld:int32(GUIControllerJourneyModeSettings::_selectedItem, ldloc:GUIControllerJourneyModeSettings(this)))
	stfld:Controls(GUIControllerJourneyModeSettings::selectedControl, ldloc:GUIControllerJourneyModeSettings(this), ldloc:int32[exp:Controls](var_9_61))
	stfld:int32(GUIControllerJourneyModeSettings::_selectedItem, ldloc:GUIControllerJourneyModeSettings(this), ldloc:int32(var_9_61))
	call:void(GUIControllerJourneyModeSettings::UpdateScroll, ldloc:GUIControllerJourneyModeSettings(this))
	stloc:int32(var_10_7A, ldc.i4:int32(4))
	stfld:Controls(GUIControllerJourneyModeSettings::selectedControl, ldloc:GUIControllerJourneyModeSettings(this), ldloc:int32[exp:Controls](var_10_7A))
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

	// Token: 0x06000394 RID: 916 RVA: 0x0000BDFC File Offset: 0x00009FFC
	public void ActivateOverlay(GUIPulldownSetting overlayEntry, Rectangle overlayRegion, int selectedOption, float offset)
	{
		this._overlayEntry = overlayEntry;
		this._overlayRegion = overlayRegion;
		this._overlayRegion.Width = selectedOption;
	}

	// Token: 0x06000395 RID: 917 RVA: 0x0000BE24 File Offset: 0x0000A024
	public void DeactivateOverlay()
	{
	}

	// Token: 0x06000396 RID: 918 RVA: 0x0000BE34 File Offset: 0x0000A034
	public bool OverlayActive()
	{
		/*
An exception occurred when decompiling this method (06000396)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIControllerJourneyModeSettings::OverlayActive()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GUIPulldownSetting(var_0_06, ldfld:GUIPulldownSetting(GUIControllerJourneyModeSettings::_overlayEntry, ldloc:GUIControllerJourneyModeSettings(this)))
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

	// Token: 0x06000397 RID: 919 RVA: 0x0000BE48 File Offset: 0x0000A048
	public Rectangle GetSelectedItemRegion()
	{
		Rectangle region;
		if (this._overlayEntry != null)
		{
			Rectangle overlayRegion = this._overlayRegion;
			int width = this._overlayRegion.Width;
			ControlAnchor.SetGridItemRegion(overlayRegion);
			int overlayIndex = this._overlayIndex;
			TransactionButton_Layout transactionButton_Layout;
			float x = transactionButton_Layout.overloadedSize.X;
			float x2 = transactionButton_Layout.Location.X;
			float y = transactionButton_Layout.Location.Y;
			transactionButton_Layout.Location.X = x;
			transactionButton_Layout.Location.Y = x;
			region = GUITransactionButton.GetRegion(transactionButton_Layout);
			float x3 = transactionButton_Layout.Location.X;
			return region;
		}
		GUIControllerJourneyModeSettings.Controls controls = this.selectedControl;
		return region;
	}

	// Token: 0x06000398 RID: 920 RVA: 0x0000BF04 File Offset: 0x0000A104
	public GUIControllerJourneyModeSettings()
	{
	}

	// Token: 0x04000376 RID: 886
	public GUIPulldownSetting _overlayEntry;

	// Token: 0x04000377 RID: 887
	public Rectangle _overlayRegion;

	// Token: 0x04000378 RID: 888
	public int _overlayIndex;

	// Token: 0x04000379 RID: 889
	public float _overlayOffset;

	// Token: 0x0400037A RID: 890
	public GUIControllerJourneyModeSettings.Controls selectedControl = GUIControllerJourneyModeSettings.Controls.Element;

	// Token: 0x0400037B RID: 891
	private int _selectedItem;

	// Token: 0x02000095 RID: 149
	public enum Controls
	{
		// Token: 0x0400037D RID: 893
		Time,
		// Token: 0x0400037E RID: 894
		Weather,
		// Token: 0x0400037F RID: 895
		Power,
		// Token: 0x04000380 RID: 896
		Element,
		// Token: 0x04000381 RID: 897
		Back
	}
}
