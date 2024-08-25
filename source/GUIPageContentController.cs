using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

// Token: 0x020000E0 RID: 224
public class GUIPageContentController : GUIControllerItem
{
	// Token: 0x060005CC RID: 1484 RVA: 0x000112E8 File Offset: 0x0000F4E8
	protected GUIPageContentController(GUIPageIcons.Category pageCategory)
	{
		this.PageCategory = pageCategory;
		this.ResearchButton = 9;
	}

	// Token: 0x060005CD RID: 1485 RVA: 0x0001130C File Offset: 0x0000F50C
	protected GUIPageContentController(GUIPageIconGrouping.SettingCategory settingCategory)
	{
		this.PageCategory = GUIPageIcons.Category.None;
		this.ResearchButton = (int)settingCategory;
	}

	// Token: 0x060005CE RID: 1486 RVA: 0x00011330 File Offset: 0x0000F530
	public virtual int GetNavigationOutDirs()
	{
	}

	// Token: 0x060005CF RID: 1487 RVA: 0x00011340 File Offset: 0x0000F540
	public bool IsPageContoller(GUIControllerItem item)
	{
		/*
An exception occurred when decompiling this method (060005CF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIPageContentController::IsPageContoller(GUIControllerItem)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GUIControllerPageGroup(var_0_13, callgetter:GUIControllerPageGroup(GUIPageIconGrouping::get_MenuController, callgetter:GUIPageIconGrouping(GUIPageContentController::get_ParentGrouping, ldloc:GUIPageContentController(this))))
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

	// Token: 0x170000AB RID: 171
	// (get) Token: 0x060005D0 RID: 1488 RVA: 0x00011360 File Offset: 0x0000F560
	public GUIPageIconGrouping ParentGrouping
	{
		get
		{
			GUIPageIcons.Category pageCategory = this.PageCategory;
			if (!true)
			{
			}
			InterfaceProfile_Layout active = InterfaceStyles_Layout.Active;
			GUIPageIconGrouping.SettingCategory settingCategory = this.SettingCategory;
			return active.GetSettingGrouping(settingCategory);
		}
	}

	// Token: 0x060005D1 RID: 1489 RVA: 0x00011398 File Offset: 0x0000F598
	public void LoadPageAnchor()
	{
		if (this.ParentGrouping != null)
		{
			this.ParentGrouping.LoadPageAnchor();
			return;
		}
	}

	// Token: 0x060005D2 RID: 1490 RVA: 0x000113BC File Offset: 0x0000F5BC
	public virtual void Activate()
	{
	}

	// Token: 0x060005D3 RID: 1491 RVA: 0x000021DB File Offset: 0x000003DB
	public virtual GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060005D4 RID: 1492 RVA: 0x000113CC File Offset: 0x0000F5CC
	public virtual Rectangle GetSelectedItemRegion()
	{
	}

	// Token: 0x060005D5 RID: 1493 RVA: 0x000113DC File Offset: 0x0000F5DC
	public virtual void NavigateInto(int column, int row)
	{
	}

	// Token: 0x040004B7 RID: 1207
	private readonly GUIPageIcons.Category PageCategory;

	// Token: 0x040004B8 RID: 1208
	private readonly GUIPageIconGrouping.SettingCategory SettingCategory;

	// Token: 0x040004B9 RID: 1209
	public int ResearchButton;
}
