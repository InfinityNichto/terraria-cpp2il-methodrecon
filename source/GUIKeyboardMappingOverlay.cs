using System;
using Microsoft.Xna.Framework;

// Token: 0x020000AC RID: 172
public class GUIKeyboardMappingOverlay : GUIControllerItem
{
	// Token: 0x06000406 RID: 1030 RVA: 0x0000D1C0 File Offset: 0x0000B3C0
	public void Activate()
	{
		this.UpdateScroll();
	}

	// Token: 0x06000407 RID: 1031 RVA: 0x0000D1D4 File Offset: 0x0000B3D4
	public int GetNavigationOutDirs()
	{
	}

	// Token: 0x06000408 RID: 1032 RVA: 0x0000D1E4 File Offset: 0x0000B3E4
	private void UpdateScroll()
	{
		int selectedItem = this._selectedItem;
		int selectedItem2 = this._selectedItem;
	}

	// Token: 0x06000409 RID: 1033 RVA: 0x0000D208 File Offset: 0x0000B408
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		/*
An exception occurred when decompiling this method (06000409)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIControllerItem GUIKeyboardMappingOverlay::Navigate(Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0008:
	stloc:Controls(var_0_0E, ldfld:Controls(GUIKeyboardMappingOverlay::selectedControl, ldloc:GUIKeyboardMappingOverlay(this)))
	stloc:int32(var_1_15, ldfld:int32(GUIKeyboardMappingOverlay::_selectedItem, ldloc:GUIKeyboardMappingOverlay(this)))
	stloc:int32(var_2_17, ldc.i4:int32(5))
	stfld:Controls(GUIKeyboardMappingOverlay::selectedControl, ldloc:GUIKeyboardMappingOverlay(this), ldloc:int32[exp:Controls](var_2_17))
	stloc:int32(var_3_20, ldc.i4:int32(4))
	stfld:Controls(GUIKeyboardMappingOverlay::selectedControl, ldloc:GUIKeyboardMappingOverlay(this), ldloc:int32[exp:Controls](var_3_20))
	call:void(GUIKeyboardMappingOverlay::UpdateScroll, ldloc:GUIKeyboardMappingOverlay(this))
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

	// Token: 0x0600040A RID: 1034 RVA: 0x0000D244 File Offset: 0x0000B444
	public void ActivateOverlay(GUIKeyboardMappingEntry overlayEntry, Rectangle overlayRegion)
	{
		this._overlayEntry = overlayEntry;
		this._overlayRegion = overlayRegion;
	}

	// Token: 0x0600040B RID: 1035 RVA: 0x0000D260 File Offset: 0x0000B460
	public void DeactivateOverlay()
	{
	}

	// Token: 0x0600040C RID: 1036 RVA: 0x0000D270 File Offset: 0x0000B470
	public Rectangle GetSelectedItemRegion()
	{
		if (this._overlayEntry != null)
		{
		}
		GUIKeyboardMappingOverlay.Controls controls = this.selectedControl;
		int selectedItem = this._selectedItem;
		this.UpdateScroll();
		int selectedItem2 = this._selectedItem;
		int selectedItem3 = this._selectedItem;
		Rectangle rectangle;
		return rectangle;
	}

	// Token: 0x0600040D RID: 1037 RVA: 0x0000D2B8 File Offset: 0x0000B4B8
	public GUIKeyboardMappingOverlay()
	{
	}

	// Token: 0x040003E3 RID: 995
	public GUIKeyboardMappingEntry _overlayEntry;

	// Token: 0x040003E4 RID: 996
	public Rectangle _overlayRegion;

	// Token: 0x040003E5 RID: 997
	public int _overlayIndex;

	// Token: 0x040003E6 RID: 998
	public float _overlayOffset;

	// Token: 0x040003E7 RID: 999
	public GUIKeyboardMappingOverlay.Controls selectedControl = GUIKeyboardMappingOverlay.Controls.Element;

	// Token: 0x040003E8 RID: 1000
	public int _selectedItem;

	// Token: 0x020000AD RID: 173
	public enum Controls
	{
		// Token: 0x040003EA RID: 1002
		PageGeneral,
		// Token: 0x040003EB RID: 1003
		PageExplore,
		// Token: 0x040003EC RID: 1004
		PageFight,
		// Token: 0x040003ED RID: 1005
		PageMisc,
		// Token: 0x040003EE RID: 1006
		PageMap,
		// Token: 0x040003EF RID: 1007
		Element,
		// Token: 0x040003F0 RID: 1008
		Reset,
		// Token: 0x040003F1 RID: 1009
		Default,
		// Token: 0x040003F2 RID: 1010
		Back
	}
}
