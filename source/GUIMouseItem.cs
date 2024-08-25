using System;
using Terraria;

// Token: 0x02000159 RID: 345
public class GUIMouseItem
{
	// Token: 0x170000EF RID: 239
	// (get) Token: 0x06000974 RID: 2420 RVA: 0x0002B218 File Offset: 0x00029418
	public bool HoldingItem
	{
		get
		{
			if (!true)
			{
			}
			int type = Main.mouseItem.type;
			if (type != 0)
			{
				if (type == 0)
				{
				}
				int stack = Main.mouseItem.stack;
				return;
			}
		}
	}

	// Token: 0x170000F0 RID: 240
	// (get) Token: 0x06000975 RID: 2421 RVA: 0x0002B24C File Offset: 0x0002944C
	public bool BeingDragged
	{
		get
		{
			return this.mouseItemHoldDrag;
		}
	}

	// Token: 0x170000F1 RID: 241
	// (get) Token: 0x06000976 RID: 2422 RVA: 0x0002B260 File Offset: 0x00029460
	public bool IsItemDropped
	{
		get
		{
			/*
An exception occurred when decompiling this method (06000976)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIMouseItem::get_IsItemDropped()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0040:
	stloc:bool(var_10_48, callgetter:bool(Main::get_mouseLeft))
	stloc:bool(var_12_52, callgetter:bool(Main::get_mouseLeftRelease))
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
	}

	// Token: 0x06000977 RID: 2423 RVA: 0x0002B2C4 File Offset: 0x000294C4
	public void BeginDrag(bool dragging)
	{
		if (!true)
		{
		}
		this.mouseDragStart = 1;
	}

	// Token: 0x06000978 RID: 2424 RVA: 0x0002B2DC File Offset: 0x000294DC
	public void DisableDrag()
	{
		this.disableDrag = true;
		if (!true)
		{
		}
		this.disableDragStart = 1;
	}

	// Token: 0x06000979 RID: 2425 RVA: 0x0002B2FC File Offset: 0x000294FC
	public GUIMouseItem()
	{
	}

	// Token: 0x04000944 RID: 2372
	private int mouseDragStart;

	// Token: 0x04000945 RID: 2373
	private bool mouseItemHoldDrag;

	// Token: 0x04000946 RID: 2374
	private bool disableDrag;

	// Token: 0x04000947 RID: 2375
	private int disableDragStart;
}
