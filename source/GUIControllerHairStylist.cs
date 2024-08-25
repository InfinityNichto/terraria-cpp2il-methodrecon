using System;
using Microsoft.Xna.Framework;
using Terraria;

// Token: 0x020000C6 RID: 198
public class GUIControllerHairStylist : GUIControllerItem
{
	// Token: 0x060004D8 RID: 1240 RVA: 0x0000F1E4 File Offset: 0x0000D3E4
	public int GetNavigationOutDirs()
	{
	}

	// Token: 0x060004D9 RID: 1241 RVA: 0x0000F1F4 File Offset: 0x0000D3F4
	public void Activate()
	{
		int myPlayer = Main.myPlayer;
		int myPlayer2 = Main.myPlayer;
		this.UpdateScroll();
		int num = 2;
		this.itemSlider = num;
	}

	// Token: 0x060004DA RID: 1242 RVA: 0x0000F22C File Offset: 0x0000D42C
	private void UpdateScroll()
	{
		int num = this.itemRow;
	}

	// Token: 0x060004DB RID: 1243 RVA: 0x0000F248 File Offset: 0x0000D448
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		/*
An exception occurred when decompiling this method (060004DB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIControllerItem GUIControllerHairStylist::Navigate(Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Controls(var_0_06, ldfld:Controls(GUIControllerHairStylist::selectedControl, ldloc:GUIControllerHairStylist(this)))
	stloc:int32(var_1_08, ldc.i4:int32(2))
	stfld:Controls(GUIControllerHairStylist::selectedControl, ldloc:GUIControllerHairStylist(this), ldloc:int32[exp:Controls](var_1_08))
	stfld:int32(GUIControllerHairStylist::itemSlider, ldloc:GUIControllerHairStylist(this), ldloc:int32(var_1_08))
	stloc:int32(var_2_18, ldc.i4:int32(2))
	stfld:Controls(GUIControllerHairStylist::selectedControl, ldloc:GUIControllerHairStylist(this), ldloc:int32[exp:Controls](var_2_18))
	stloc:int32(var_3_26, ldfld:int32(GUIControllerHairStylist::itemSlider, ldloc:GUIControllerHairStylist(this)))
	stloc:int32(var_4_28, ldc.i4:int32(4))
	stfld:Controls(GUIControllerHairStylist::selectedControl, ldloc:GUIControllerHairStylist(this), ldloc:int32[exp:Controls](var_4_28))
	stloc:int32(var_5_38, ldfld:int32(GUIControllerHairStylist::maxRowIndex, ldloc:GUIControllerHairStylist(this)))
	stfld:int32(GUIControllerHairStylist::itemRow, ldloc:GUIControllerHairStylist(this), ldloc:int32(var_5_38))
	call:void(GUIControllerHairStylist::UpdateScroll, ldloc:GUIControllerHairStylist(this))
	stloc:int32(var_6_4E, ldfld:int32(GUIControllerHairStylist::itemRow, ldloc:GUIControllerHairStylist(this)))
	stfld:int32(GUIControllerHairStylist::itemRow, ldloc:GUIControllerHairStylist(this), ldloc:int32(var_6_4E))
	call:void(GUIControllerHairStylist::UpdateScroll, ldloc:GUIControllerHairStylist(this))
	stloc:int32(var_7_64, ldfld:int32(GUIControllerHairStylist::itemSlider, ldloc:GUIControllerHairStylist(this)))
	stfld:int32(GUIControllerHairStylist::itemSlider, ldloc:GUIControllerHairStylist(this), ldloc:int32(var_7_64))
	stloc:int32(var_8_74, ldfld:int32(GUIControllerHairStylist::itemRow, ldloc:GUIControllerHairStylist(this)))
	stloc:int32(var_9_7C, ldfld:int32(GUIControllerHairStylist::maxRowIndex, ldloc:GUIControllerHairStylist(this)))
	stfld:int32(GUIControllerHairStylist::itemRow, ldloc:GUIControllerHairStylist(this), ldloc:int32(var_8_74))
	stloc:int32(var_10_8C, ldfld:int32(GUIControllerHairStylist::itemColumn, ldloc:GUIControllerHairStylist(this)))
	stloc:int32(var_11_94, ldfld:int32(GUIControllerHairStylist::maxRowColumn, ldloc:GUIControllerHairStylist(this)))
	stfld:int32(GUIControllerHairStylist::itemColumn, ldloc:GUIControllerHairStylist(this), ldloc:int32(var_11_94))
	stloc:int32(var_12_9F, ldc.i4:int32(4))
	stfld:Controls(GUIControllerHairStylist::selectedControl, ldloc:GUIControllerHairStylist(this), ldloc:int32[exp:Controls](var_12_9F))
	stloc:int32(var_13_AF, ldfld:int32(GUIControllerHairStylist::itemColumn, ldloc:GUIControllerHairStylist(this)))
	stloc:int32(var_14_B7, ldfld:int32(GUIControllerHairStylist::maxRowIndex, ldloc:GUIControllerHairStylist(this)))
	stloc:int32(var_15_BF, ldfld:int32(GUIControllerHairStylist::itemRow, ldloc:GUIControllerHairStylist(this)))
	stloc:int32(var_16_C7, ldfld:int32(GUIControllerHairStylist::scrollOffset, ldloc:GUIControllerHairStylist(this)))
	stloc:int32(var_17_CF, ldfld:int32(GUIControllerHairStylist::maxRowColumn, ldloc:GUIControllerHairStylist(this)))
	stfld:int32(GUIControllerHairStylist::itemColumn, ldloc:GUIControllerHairStylist(this), ldloc:int32(var_16_C7))
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

	// Token: 0x060004DC RID: 1244 RVA: 0x0000F330 File Offset: 0x0000D530
	private void ClampPosition()
	{
	}

	// Token: 0x060004DD RID: 1245 RVA: 0x0000F340 File Offset: 0x0000D540
	public Rectangle GetSelectedItemRegion()
	{
		Rectangle rectangle;
		ControlAnchor.SetGridItemRegion(rectangle);
		GUIControllerHairStylist.Controls controls = this.selectedControl;
		return rectangle;
	}

	// Token: 0x060004DE RID: 1246 RVA: 0x0000F384 File Offset: 0x0000D584
	public GUIControllerHairStylist()
	{
	}

	// Token: 0x0400045E RID: 1118
	public GUIControllerHairStylist.Controls selectedControl = GUIControllerHairStylist.Controls.Element;

	// Token: 0x0400045F RID: 1119
	public int itemRow;

	// Token: 0x04000460 RID: 1120
	public int itemColumn;

	// Token: 0x04000461 RID: 1121
	public int scrollOffset;

	// Token: 0x04000462 RID: 1122
	public int itemSlider = 2;

	// Token: 0x04000463 RID: 1123
	public int maxRowIndex;

	// Token: 0x04000464 RID: 1124
	public int maxRowColumn;

	// Token: 0x020000C7 RID: 199
	public enum Controls
	{
		// Token: 0x04000466 RID: 1126
		Style,
		// Token: 0x04000467 RID: 1127
		Colour,
		// Token: 0x04000468 RID: 1128
		Element,
		// Token: 0x04000469 RID: 1129
		Back,
		// Token: 0x0400046A RID: 1130
		Buy
	}
}
