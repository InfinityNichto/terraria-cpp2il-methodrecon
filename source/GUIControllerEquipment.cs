using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

// Token: 0x020000C4 RID: 196
public class GUIControllerEquipment : GUIPageContentController
{
	// Token: 0x060004C0 RID: 1216 RVA: 0x0000EC90 File Offset: 0x0000CE90
	public GUIControllerEquipment()
		: base(GUIPageIcons.Category.Equipment)
	{
	}

	// Token: 0x060004C1 RID: 1217 RVA: 0x0000ECA4 File Offset: 0x0000CEA4
	public override void Activate()
	{
	}

	// Token: 0x060004C2 RID: 1218 RVA: 0x0000ECB4 File Offset: 0x0000CEB4
	public virtual void NavigateInto(Vector2 source, Vector2 navigationVector)
	{
	}

	// Token: 0x060004C3 RID: 1219 RVA: 0x0000ECC4 File Offset: 0x0000CEC4
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		if (this.inAccessories)
		{
			int num = this.itemColumn;
			int num2 = this.itemColumn;
		}
		int num3 = this.itemColumn;
		this.itemColumn = num3;
		int num4 = this.itemColumn;
		this.itemColumn = num4;
		int num5 = this.itemRow;
		int num6 = this.itemColumn;
		int num7 = this.itemRow;
		int num8 = 2;
		this.itemRow = num8;
		int num9 = this.itemRow;
		this.itemRow = num9;
		int num10 = this.itemRow;
		bool flag = this.inAccessories;
		int num11 = this.itemRow;
		GUIControllerItem guicontrollerItem;
		return guicontrollerItem;
	}

	// Token: 0x17000085 RID: 133
	// (get) Token: 0x060004C4 RID: 1220 RVA: 0x000021DB File Offset: 0x000003DB
	private int MinColumnAccesories
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x17000086 RID: 134
	// (get) Token: 0x060004C5 RID: 1221 RVA: 0x000021DB File Offset: 0x000003DB
	private int MinRowLastColumnAccesories
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x060004C6 RID: 1222 RVA: 0x0000ED64 File Offset: 0x0000CF64
	public virtual void ClampAccessories()
	{
		int num = this.itemColumn;
		int num2;
		this.itemColumn = num2;
	}

	// Token: 0x060004C7 RID: 1223 RVA: 0x0000ED90 File Offset: 0x0000CF90
	public override Rectangle GetSelectedItemRegion()
	{
		/*
An exception occurred when decompiling this method (060004C7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Rectangle GUIControllerEquipment::GetSelectedItemRegion()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00C4:
	stloc:int32(var_27_CA, ldfld:int32(GUIControllerEquipment::itemRow, ldloc:GUIControllerEquipment(this)))
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

	// Token: 0x04000458 RID: 1112
	public int itemRow;

	// Token: 0x04000459 RID: 1113
	public int itemColumn;

	// Token: 0x0400045A RID: 1114
	public bool inAccessories;

	// Token: 0x0400045B RID: 1115
	public bool inLoadout;
}
