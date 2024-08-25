using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

// Token: 0x02000274 RID: 628
public class GUIPageGroupEdit
{
	// Token: 0x06000E10 RID: 3600 RVA: 0x00043A10 File Offset: 0x00041C10
	private int SortSettings(GUIPageIconGrouping.SettingCategory x, GUIPageIconGrouping.SettingCategory y)
	{
		List<GUIPageIconGrouping.SettingCategory> settingOptions = this.SettingOptions;
		List<GUIPageIconGrouping.SettingCategory> settingOptions2 = this.SettingOptions;
		int size = this.SettingOptions._size;
		int size2 = this.SettingOptions._size;
		int num;
		return num;
	}

	// Token: 0x06000E11 RID: 3601 RVA: 0x00043A48 File Offset: 0x00041C48
	private int SortCategories(GUIPageIcons.Category x, GUIPageIcons.Category y)
	{
		List<GUIPageIcons.Category> pageOptions = this.PageOptions;
		List<GUIPageIcons.Category> pageOptions2 = this.PageOptions;
		int num;
		return num;
	}

	// Token: 0x06000E12 RID: 3602 RVA: 0x00043A64 File Offset: 0x00041C64
	public Rectangle GetRegion()
	{
		List<GUIPageIcons.Category> pageOptions = this.PageOptions;
		List<GUIPageIconGrouping.SettingCategory> settingOptions = this.SettingOptions;
		float x = this.toggleSize.X;
		float y = this.toggleSize.Y;
		int size = pageOptions._size;
		int size2 = settingOptions._size;
		if (pageOptions == null)
		{
		}
		Rectangle rectangle;
		return rectangle;
	}

	// Token: 0x06000E13 RID: 3603 RVA: 0x000021DB File Offset: 0x000003DB
	public void Draw()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000E14 RID: 3604 RVA: 0x00043AAC File Offset: 0x00041CAC
	private float ItemScale(int index)
	{
		/*
An exception occurred when decompiling this method (06000E14)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUIPageGroupEdit::ItemScale(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_1_0C, ldfld:float32(BuilderAccToggles_Layout::ToggleScale, callgetter:BuilderAccToggles_Layout(BuilderAccToggles_Layout::get_Instance)))
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

	// Token: 0x06000E15 RID: 3605 RVA: 0x00043AC8 File Offset: 0x00041CC8
	private void ItemOver(int index)
	{
		this.hoverItem = index;
	}

	// Token: 0x06000E16 RID: 3606 RVA: 0x00043ADC File Offset: 0x00041CDC
	private void DisableCategory(GUIPageIcons.Category cat)
	{
		if (!true)
		{
		}
		List<GUIPageIconGrouping> leftGroupings = InterfaceStyles_Layout.Active.LeftGroupings;
	}

	// Token: 0x06000E17 RID: 3607 RVA: 0x00043B38 File Offset: 0x00041D38
	private void DisableSetting(GUIPageIconGrouping.SettingCategory cat)
	{
		if (!true)
		{
		}
		List<GUIPageIconGrouping> leftGroupings = InterfaceStyles_Layout.Active.LeftGroupings;
	}

	// Token: 0x06000E18 RID: 3608 RVA: 0x00043B94 File Offset: 0x00041D94
	private void ItemDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
		float x = this.toggleSize.X;
		float y = this.toggleSize.Y;
		List<GUIPageIcons.Category> pageOptions = this.PageOptions;
		int size = pageOptions._size;
		List<GUIPageIcons.Category> pageOptions2 = this.PageOptions;
		List<GUIPageIcons.Category> pageOptions3 = this.PageOptions;
	}

	// Token: 0x06000E19 RID: 3609 RVA: 0x00043D20 File Offset: 0x00041F20
	public void Close()
	{
		if (this.Enabled)
		{
		}
		if (this.pickingInterceptor != null)
		{
		}
	}

	// Token: 0x06000E1A RID: 3610 RVA: 0x00043D40 File Offset: 0x00041F40
	private bool IsOverGroupOptions(Vector2 position)
	{
		/*
An exception occurred when decompiling this method (06000E1A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIPageGroupEdit::IsOverGroupOptions(Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000A:
	call:void(GUIPageGroupEdit::Close, ldloc:GUIPageGroupEdit(this))
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

	// Token: 0x06000E1B RID: 3611 RVA: 0x00043D60 File Offset: 0x00041F60
	public GUIPageGroupEdit()
	{
	}

	// Token: 0x040019BC RID: 6588
	private bool LastHorizontal;

	// Token: 0x040019BD RID: 6589
	public bool Enabled;

	// Token: 0x040019BE RID: 6590
	private List<GUIPageIcons.Category> PageOptions;

	// Token: 0x040019BF RID: 6591
	private List<GUIPageIconGrouping.SettingCategory> SettingOptions;

	// Token: 0x040019C0 RID: 6592
	public Vector2 toggleSize;

	// Token: 0x040019C1 RID: 6593
	private int hoverItem;

	// Token: 0x040019C2 RID: 6594
	private bool CanOptionBeAdded;

	// Token: 0x040019C3 RID: 6595
	private GUIInputRegionExclusive pickingInterceptor;

	// Token: 0x040019C4 RID: 6596
	private Rectangle popupRegion;
}
