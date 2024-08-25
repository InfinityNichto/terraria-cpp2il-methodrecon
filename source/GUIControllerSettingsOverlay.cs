using System;
using Microsoft.Xna.Framework;

// Token: 0x020000A7 RID: 167
public class GUIControllerSettingsOverlay : GUIControllerItem
{
	// Token: 0x060003F1 RID: 1009 RVA: 0x0000CDBC File Offset: 0x0000AFBC
	public void SelectedSetting(int index)
	{
		this.selectedControl = GUIControllerSettingsOverlay.Controls.Element;
	}

	// Token: 0x060003F2 RID: 1010 RVA: 0x0000CDD0 File Offset: 0x0000AFD0
	public void Activate()
	{
		this.UpdateScroll();
	}

	// Token: 0x060003F3 RID: 1011 RVA: 0x0000CDE4 File Offset: 0x0000AFE4
	public int GetNavigationOutDirs()
	{
	}

	// Token: 0x060003F4 RID: 1012 RVA: 0x0000CDF4 File Offset: 0x0000AFF4
	public void UpdateScroll()
	{
		int selectedItem = this._selectedItem;
		int selectedItem2 = this._selectedItem;
	}

	// Token: 0x060003F5 RID: 1013 RVA: 0x0000CE18 File Offset: 0x0000B018
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		/*
An exception occurred when decompiling this method (060003F5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIControllerItem GUIControllerSettingsOverlay::Navigate(Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0011:
	stloc:Controls(var_2_17, ldfld:Controls(GUIControllerSettingsOverlay::selectedControl, ldloc:GUIControllerSettingsOverlay(this)))
	stloc:int32(var_3_1E, ldfld:int32(GUIControllerSettingsOverlay::_selectedItem, ldloc:GUIControllerSettingsOverlay(this)))
	stfld:int32(GUIControllerSettingsOverlay::_selectedItem, ldloc:GUIControllerSettingsOverlay(this), ldloc:int32(var_3_1E))
	stloc:int32(var_4_2C, ldfld:int32(GUIControllerSettingsOverlay::_overlayIndex, ldloc:GUIControllerSettingsOverlay(this)))
	stloc:int32(var_5_34, call:int32(GUIPulldownSetting::GetNumberOfOptions, ldloc:GUIPulldownSetting(var_0_06)))
	stloc:int32(var_6_3C, ldfld:int32(GUIControllerSettingsOverlay::_overlayIndex, ldloc:GUIControllerSettingsOverlay(this)))
	stfld:int32(GUIControllerSettingsOverlay::_overlayIndex, ldloc:GUIControllerSettingsOverlay(this), ldloc:int32(var_6_3C))
	stloc:GUIPulldownSetting(var_7_4C, ldfld:GUIPulldownSetting(GUIControllerSettingsOverlay::_overlayEntry, ldloc:GUIControllerSettingsOverlay(this)))
	stloc:int32(var_8_54, ldfld:int32(GUIControllerSettingsOverlay::_overlayIndex, ldloc:GUIControllerSettingsOverlay(this)))
	stfld:int32(GUIPulldownSetting::selectedPosition, ldloc:GUIPulldownSetting(var_7_4C), ldloc:int32(var_8_54))
	stloc:int32(var_9_60, ldc.i4:int32(8))
	stfld:Controls(GUIControllerSettingsOverlay::selectedControl, ldloc:GUIControllerSettingsOverlay(this), ldloc:int32[exp:Controls](var_9_60))
	stloc:bool(var_11_72, callgetter:bool(Main::get_gameMenu))
	stloc:int32(var_12_76, ldc.i4:int32(9))
	stfld:Controls(GUIControllerSettingsOverlay::selectedControl, ldloc:GUIControllerSettingsOverlay(this), ldloc:int32[exp:Controls](var_12_76))
	stloc:int32(var_13_81, ldc.i4:int32(3))
	stfld:Controls(GUIControllerSettingsOverlay::selectedControl, ldloc:GUIControllerSettingsOverlay(this), ldloc:int32[exp:Controls](var_13_81))
	call:void(GUIControllerSettingsOverlay::UpdateScroll, ldloc:GUIControllerSettingsOverlay(this))
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

	// Token: 0x060003F6 RID: 1014 RVA: 0x0000CEB8 File Offset: 0x0000B0B8
	public void ActivateOverlay(GUIPulldownSetting overlayEntry, Rectangle overlayRegion, int selectedOption, float offset)
	{
		this._overlayEntry = overlayEntry;
		this._overlayRegion = overlayRegion;
		this._overlayRegion.Width = selectedOption;
	}

	// Token: 0x060003F7 RID: 1015 RVA: 0x0000CEE0 File Offset: 0x0000B0E0
	public void DeactivateOverlay()
	{
	}

	// Token: 0x060003F8 RID: 1016 RVA: 0x0000CEF0 File Offset: 0x0000B0F0
	public bool OverlayActive()
	{
		/*
An exception occurred when decompiling this method (060003F8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIControllerSettingsOverlay::OverlayActive()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GUIPulldownSetting(var_0_06, ldfld:GUIPulldownSetting(GUIControllerSettingsOverlay::_overlayEntry, ldloc:GUIControllerSettingsOverlay(this)))
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

	// Token: 0x060003F9 RID: 1017 RVA: 0x0000CF04 File Offset: 0x0000B104
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
			float x3 = transactionButton_Layout.overloadedSize.X;
			float x4 = transactionButton_Layout.Location.X;
			return region;
		}
		GUIControllerSettingsOverlay.Controls controls = this.selectedControl;
		return region;
	}

	// Token: 0x060003FA RID: 1018 RVA: 0x0000CFF4 File Offset: 0x0000B1F4
	public GUIControllerSettingsOverlay()
	{
	}

	// Token: 0x040003C6 RID: 966
	public GUIPulldownSetting _overlayEntry;

	// Token: 0x040003C7 RID: 967
	public Rectangle _overlayRegion;

	// Token: 0x040003C8 RID: 968
	public int _overlayIndex;

	// Token: 0x040003C9 RID: 969
	public float _overlayOffset;

	// Token: 0x040003CA RID: 970
	private GUIControllerSettingsOverlay.Controls selectedControl = GUIControllerSettingsOverlay.Controls.Element;

	// Token: 0x040003CB RID: 971
	private int _selectedItem;

	// Token: 0x020000A8 RID: 168
	private enum Controls
	{
		// Token: 0x040003CD RID: 973
		PageSettings,
		// Token: 0x040003CE RID: 974
		PageInterface,
		// Token: 0x040003CF RID: 975
		PageVideo,
		// Token: 0x040003D0 RID: 976
		PageSound,
		// Token: 0x040003D1 RID: 977
		PageControls,
		// Token: 0x040003D2 RID: 978
		PageTouch,
		// Token: 0x040003D3 RID: 979
		PageController,
		// Token: 0x040003D4 RID: 980
		PageKeyboard,
		// Token: 0x040003D5 RID: 981
		Element,
		// Token: 0x040003D6 RID: 982
		Reset,
		// Token: 0x040003D7 RID: 983
		Back
	}
}
