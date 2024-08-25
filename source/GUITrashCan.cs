using System;
using Microsoft.Xna.Framework;
using Terraria;

// Token: 0x02000174 RID: 372
public class GUITrashCan
{
	// Token: 0x06000A8B RID: 2699 RVA: 0x000334A4 File Offset: 0x000316A4
	public float ItemScale(int index)
	{
		/*
An exception occurred when decompiling this method (06000A8B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUITrashCan::ItemScale(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:!0(var_0_05, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
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

	// Token: 0x06000A8C RID: 2700 RVA: 0x000334B8 File Offset: 0x000316B8
	public void ItemOver(int index)
	{
		int num = 1;
		this.cursorOverTrashCan = num != 0;
		if (!true)
		{
		}
		if (Main.myPlayer == 0)
		{
		}
		Recipe.FindRecipes(false);
	}

	// Token: 0x06000A8D RID: 2701 RVA: 0x00033548 File Offset: 0x00031748
	public void ItemDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
		if (!this.cursorOverTrashCan || !true)
		{
		}
	}

	// Token: 0x06000A8E RID: 2702 RVA: 0x000335C0 File Offset: 0x000317C0
	public void Draw()
	{
		for (;;)
		{
			int num = 1;
			!0 instance = PageControllerLayoutDefinition.Instance;
			if (num == 0)
			{
			}
			bool flag = this.itemDragStart;
			if (!flag)
			{
				break;
			}
			if (!flag)
			{
			}
			bool mouseLeft = Main.mouseLeft;
			if (!flag)
			{
			}
			if (Main.mouseItem != null)
			{
				if (!flag)
				{
				}
				if (Main.mouseItem.type != 0)
				{
					break;
				}
			}
			if (this.itemDragStart)
			{
				goto Block_2;
			}
		}
		return;
		Block_2:
		if (this.overTrashCan)
		{
		}
		if (Main.myPlayer == 0)
		{
		}
		Recipe.FindRecipes(false);
	}

	// Token: 0x06000A8F RID: 2703 RVA: 0x00033630 File Offset: 0x00031830
	public GUITrashCan()
	{
	}

	// Token: 0x04000A78 RID: 2680
	private bool itemDragStart;

	// Token: 0x04000A79 RID: 2681
	private bool overTrashCan;

	// Token: 0x04000A7A RID: 2682
	private bool cursorOverTrashCan;
}
