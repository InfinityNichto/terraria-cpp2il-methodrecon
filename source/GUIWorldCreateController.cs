using System;
using Microsoft.Xna.Framework;

// Token: 0x020000AE RID: 174
public class GUIWorldCreateController : GUIControllerItem
{
	// Token: 0x0600040E RID: 1038 RVA: 0x0000D2D4 File Offset: 0x0000B4D4
	public void Activate()
	{
	}

	// Token: 0x0600040F RID: 1039 RVA: 0x0000D2E4 File Offset: 0x0000B4E4
	public int GetNavigationOutDirs()
	{
	}

	// Token: 0x06000410 RID: 1040 RVA: 0x0000D2F4 File Offset: 0x0000B4F4
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		/*
An exception occurred when decompiling this method (06000410)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIControllerItem GUIWorldCreateController::Navigate(Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0063:
	stloc:int32(var_7_64, ldc.i4:int32(2))
	stfld:int32(GUIWorldCreateController::difficultyIndex, ldloc:GUIWorldCreateController(this), ldloc:int32(var_7_64))
	stloc:int32(var_9_72, ldc.i4:int32(5))
	stfld:int32(GUIWorldCreateController::selectedItem, ldloc:GUIWorldCreateController(this), ldloc:int32(var_9_72))
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

	// Token: 0x06000411 RID: 1041 RVA: 0x0000D37C File Offset: 0x0000B57C
	public void ActivateName()
	{
		this.nameActive = true;
	}

	// Token: 0x06000412 RID: 1042 RVA: 0x0000D390 File Offset: 0x0000B590
	public void DeactivateName()
	{
	}

	// Token: 0x06000413 RID: 1043 RVA: 0x0000D3A0 File Offset: 0x0000B5A0
	public void ActivateSeed()
	{
		this.seedActive = true;
	}

	// Token: 0x06000414 RID: 1044 RVA: 0x0000D3B4 File Offset: 0x0000B5B4
	public void DeactivateSeed()
	{
	}

	// Token: 0x06000415 RID: 1045 RVA: 0x0000D3C4 File Offset: 0x0000B5C4
	public void ActivateDifficultyOptions(int selectedOption, int wrapAround)
	{
		int num = 1;
		this.difficultyActive = num != 0;
		this.evilTypeActive = wrapAround != 0;
	}

	// Token: 0x06000416 RID: 1046 RVA: 0x0000D3E4 File Offset: 0x0000B5E4
	public void DeactivateDifficultyOptions()
	{
	}

	// Token: 0x06000417 RID: 1047 RVA: 0x0000D3F4 File Offset: 0x0000B5F4
	public void ActivateWorldOptions(int selectedOption)
	{
		this.worldActive = true;
		this.worldIndex = selectedOption;
	}

	// Token: 0x06000418 RID: 1048 RVA: 0x0000D410 File Offset: 0x0000B610
	public void DeactivateWorldOptions()
	{
	}

	// Token: 0x06000419 RID: 1049 RVA: 0x0000D420 File Offset: 0x0000B620
	public void ActivateEvilTypeOptions(int selectedOption, int wrapAround)
	{
		int num = 1;
		this.evilTypeActive = num != 0;
	}

	// Token: 0x0600041A RID: 1050 RVA: 0x0000D438 File Offset: 0x0000B638
	public void DeactivateEvilTypeOptions()
	{
	}

	// Token: 0x0600041B RID: 1051 RVA: 0x0000D448 File Offset: 0x0000B648
	public Rectangle GetSelectedItemRegion()
	{
		if (this.difficultyActive)
		{
			int num = this.difficultyIndex;
		}
		Rectangle rectangle;
		if (this.worldActive)
		{
			int num2 = this.worldIndex;
			return rectangle;
		}
		if (this.evilTypeActive)
		{
			int num3 = this.evilTypeIndex;
			return rectangle;
		}
		Rectangle rectangle2;
		return rectangle2;
	}

	// Token: 0x0600041C RID: 1052 RVA: 0x0000D4AC File Offset: 0x0000B6AC
	public GUIWorldCreateController()
	{
	}

	// Token: 0x040003F3 RID: 1011
	public int selectedItem;

	// Token: 0x040003F4 RID: 1012
	private bool nameActive;

	// Token: 0x040003F5 RID: 1013
	private bool seedActive;

	// Token: 0x040003F6 RID: 1014
	private bool worldActive;

	// Token: 0x040003F7 RID: 1015
	private int worldIndex;

	// Token: 0x040003F8 RID: 1016
	private bool difficultyActive;

	// Token: 0x040003F9 RID: 1017
	private int difficultyIndex;

	// Token: 0x040003FA RID: 1018
	private int difficultyWrapAround;

	// Token: 0x040003FB RID: 1019
	private bool evilTypeActive;

	// Token: 0x040003FC RID: 1020
	private int evilTypeIndex;

	// Token: 0x040003FD RID: 1021
	private int evilTypeWrapAround;
}
