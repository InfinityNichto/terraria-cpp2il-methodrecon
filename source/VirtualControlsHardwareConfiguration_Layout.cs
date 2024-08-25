using System;
using Microsoft.Xna.Framework;
using Terraria.Localization;

// Token: 0x0200024B RID: 587
[Serializable]
public class VirtualControlsHardwareConfiguration_Layout
{
	// Token: 0x06000D38 RID: 3384 RVA: 0x0003F29C File Offset: 0x0003D49C
	public void Copy(VirtualControlsHardwareConfiguration_Layout other)
	{
		string editedName = other.EditedName;
		this.EditedName = editedName;
		GUIPageIcons.PageControlsType pageControls = other.PageControls;
		this.PageControls = pageControls;
		Vector2 leftPagePosition = other.LeftPagePosition;
		this.LeftPagePosition = leftPagePosition;
		Vector2 leftControlsPosition = other.LeftControlsPosition;
		this.LeftControlsPosition = leftControlsPosition;
		Vector2 rightPagePosition = other.RightPagePosition;
		this.RightPagePosition = rightPagePosition;
		Vector2 rightControlsPosition = other.RightControlsPosition;
		this.RightControlsPosition = rightControlsPosition;
		Vector2 settingsPosition = other.SettingsPosition;
		this.SettingsPosition = settingsPosition;
		Vector2 menuPosition = other.MenuPosition;
		this.MenuPosition = menuPosition;
		VirtualControlsSlotTypeMapping_Layout style = other.Slots.Style;
		VirtualControlsHardwareConfigurationMapping_Layout[] slots = this.Slots;
		VirtualControlsHardwareConfigurationMapping_Layout[] slots2 = other.Slots;
		VirtualControlsHardwareConfigurationMapping_Layout[] slots3 = this.Slots;
	}

	// Token: 0x06000D39 RID: 3385 RVA: 0x0003F34C File Offset: 0x0003D54C
	public bool IsSame(VirtualControlsHardwareConfiguration_Layout other)
	{
		/*
An exception occurred when decompiling this method (06000D39)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean VirtualControlsHardwareConfiguration_Layout::IsSame(VirtualControlsHardwareConfiguration_Layout)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_017E:
	stloc:class VirtualControlsHardwareConfigurationMapping_Layout[](var_41_187, ldfld:class VirtualControlsHardwareConfigurationMapping_Layout[](VirtualControlsHardwareConfiguration_Layout::Slots, ldloc:VirtualControlsHardwareConfiguration_Layout(this)))
	stloc:class VirtualControlsHardwareConfigurationMapping_Layout[](var_42_18F, ldfld:class VirtualControlsHardwareConfigurationMapping_Layout[](VirtualControlsHardwareConfiguration_Layout::Slots, ldloc:VirtualControlsHardwareConfiguration_Layout(other)))
	stloc:VirtualControlsSlotTypeMapping_Layout(var_43_198, ldfld:VirtualControlsSlotTypeMapping_Layout(VirtualControlsHardwareConfigurationMapping_Layout::Style, ldloc:class VirtualControlsHardwareConfigurationMapping_Layout[][exp:VirtualControlsHardwareConfigurationMapping_Layout](var_41_187)))
	stloc:VirtualControlsSlotTypeMapping_Layout(var_44_1A1, ldfld:VirtualControlsSlotTypeMapping_Layout(VirtualControlsHardwareConfigurationMapping_Layout::Style, ldloc:class VirtualControlsHardwareConfigurationMapping_Layout[][exp:VirtualControlsHardwareConfigurationMapping_Layout](var_42_18F)))
	stloc:ContolType(var_45_1AA, ldfld:ContolType(VirtualControlsHardwareConfigurationMapping_Layout::DefaultControl, ldloc:class VirtualControlsHardwareConfigurationMapping_Layout[][exp:VirtualControlsHardwareConfigurationMapping_Layout](var_41_187)))
	stloc:ContolType(var_46_1B3, ldfld:ContolType(VirtualControlsHardwareConfigurationMapping_Layout::DefaultControl, ldloc:class VirtualControlsHardwareConfigurationMapping_Layout[][exp:VirtualControlsHardwareConfigurationMapping_Layout](var_42_18F)))
	stloc:class VirtualControlsHardwareConfigurationMapping_Layout[](var_48_1BB, ldfld:class VirtualControlsHardwareConfigurationMapping_Layout[](VirtualControlsHardwareConfiguration_Layout::Slots, ldloc:VirtualControlsHardwareConfiguration_Layout(this)))
	stloc:class VirtualControlsHardwareConfigurationMapping_Layout[](var_49_1C3, ldfld:class VirtualControlsHardwareConfigurationMapping_Layout[](VirtualControlsHardwareConfiguration_Layout::Slots, ldloc:VirtualControlsHardwareConfiguration_Layout(other)))
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

	// Token: 0x06000D3A RID: 3386 RVA: 0x0003F528 File Offset: 0x0003D728
	public void LoadControlPositions()
	{
		GUIPageIcons.PageControlsType pageControls = this.PageControls;
	}

	// Token: 0x06000D3B RID: 3387 RVA: 0x0003F55C File Offset: 0x0003D75C
	public string GetDisplayName()
	{
		string editedName = this.EditedName;
		bool flag = string.IsNullOrEmpty(editedName);
		string id = this.Id;
		return Language.GetTextValue("Hardware." + id);
	}

	// Token: 0x06000D3C RID: 3388 RVA: 0x0003F590 File Offset: 0x0003D790
	public VirtualControlsHardwareConfiguration_Layout()
	{
	}

	// Token: 0x04001844 RID: 6212
	public string Id;

	// Token: 0x04001845 RID: 6213
	public string EditedName;

	// Token: 0x04001846 RID: 6214
	public Vector2 LeftPagePosition;

	// Token: 0x04001847 RID: 6215
	public Vector2 LeftControlsPosition;

	// Token: 0x04001848 RID: 6216
	public Vector2 RightPagePosition;

	// Token: 0x04001849 RID: 6217
	public Vector2 RightControlsPosition;

	// Token: 0x0400184A RID: 6218
	public Vector2 SettingsPosition;

	// Token: 0x0400184B RID: 6219
	public Vector2 MenuPosition;

	// Token: 0x0400184C RID: 6220
	public GUIPageIcons.PageControlsType PageControls;

	// Token: 0x0400184D RID: 6221
	public VirtualControlsHardwareConfigurationMapping_Layout[] Slots;
}
