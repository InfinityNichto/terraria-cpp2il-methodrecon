using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001BE RID: 446
[Serializable]
public class String_Layout
{
	// Token: 0x06000BD4 RID: 3028 RVA: 0x0003AEAC File Offset: 0x000390AC
	public void Copy(String_Layout other)
	{
		ControlAnchor.ControlId anchorControl = other.AnchorControl;
		this.AnchorControl = anchorControl;
		Vector2 location = other.Location;
		this.Location = location;
		Color color = other.Color;
		this.Color = color;
		String_Layout.FontType renderFont = other.RenderFont;
		this.RenderFont = renderFont;
		bool multiLineUseAlignment = other.MultiLineUseAlignment;
		this.MultiLineUseAlignment = multiLineUseAlignment;
		float multilineScale = other.MultilineScale;
		this.MultilineScale = multilineScale;
	}

	// Token: 0x06000BD5 RID: 3029 RVA: 0x0003AF14 File Offset: 0x00039114
	public SpriteFont GetFont()
	{
		/*
An exception occurred when decompiling this method (06000BD5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.SpriteFont String_Layout::GetFont()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	stloc:FontType(var_0_06, ldfld:FontType(String_Layout::RenderFont, ldloc:String_Layout(this)))
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
	}

	// Token: 0x06000BD6 RID: 3030 RVA: 0x0003AF2C File Offset: 0x0003912C
	public String_Layout()
	{
		if (17146 == 0)
		{
		}
		this.Color = 17146;
		this.MultilineScale = (float)49024;
		base..ctor();
	}

	// Token: 0x04000EDF RID: 3807
	public ControlAnchor.ControlId AnchorControl;

	// Token: 0x04000EE0 RID: 3808
	public LayoutCalculator.AnchorType Anchor = LayoutCalculator.AnchorType.BottomLeft;

	// Token: 0x04000EE1 RID: 3809
	public Vector2 Location = 17146;

	// Token: 0x04000EE2 RID: 3810
	public Color Color;

	// Token: 0x04000EE3 RID: 3811
	public LayoutCalculator.AnchorType Alignment;

	// Token: 0x04000EE4 RID: 3812
	public float Scale;

	// Token: 0x04000EE5 RID: 3813
	public String_Layout.FontType RenderFont;

	// Token: 0x04000EE6 RID: 3814
	public bool MultiLineUseAlignment;

	// Token: 0x04000EE7 RID: 3815
	public float WrapWidth;

	// Token: 0x04000EE8 RID: 3816
	public int MaxLines;

	// Token: 0x04000EE9 RID: 3817
	public float MultilineScale;

	// Token: 0x020001BF RID: 447
	public enum FontType
	{
		// Token: 0x04000EEB RID: 3819
		MouseText,
		// Token: 0x04000EEC RID: 3820
		DeathText
	}
}
