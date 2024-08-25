using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000112 RID: 274
public static class GUIPopoutMenu
{
	// Token: 0x060006E4 RID: 1764 RVA: 0x000173CC File Offset: 0x000155CC
	public static void LoadContent(ContentManager content)
	{
		Texture2D texture2D = content.Load<Texture2D>("Images/UI/PageIcons/ChestMenu");
		Texture2D texture2D2 = content.Load<Texture2D>("Images/UI/PageIcons/ChestMenuSelected");
	}

	// Token: 0x060006E5 RID: 1765 RVA: 0x000173F4 File Offset: 0x000155F4
	private static int DrawMenu(PopoutMenu_Layout layout, string[] options, Rectangle menuRegion)
	{
		/*
An exception occurred when decompiling this method (060006E5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 GUIPopoutMenu::DrawMenu(PopoutMenu_Layout,System.String[],Microsoft.Xna.Framework.Rectangle)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_004B:
	stloc:bool(var_28_56, callgetter:bool(Main::get_mouseLeft))
	stloc:bool(var_30_60, callgetter:bool(Main::get_mouseLeftRelease))
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

	// Token: 0x060006E6 RID: 1766 RVA: 0x00017464 File Offset: 0x00015664
	public static int Draw(PopoutMenu_Layout layout, string[] options, bool menuOpen, float scale, Rectangle menuRegion)
	{
		int num;
		return num;
	}

	// Token: 0x04000568 RID: 1384
	public static Texture2D _menuClosed;

	// Token: 0x04000569 RID: 1385
	public static Texture2D _menuOpen;
}
