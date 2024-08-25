using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001BC RID: 444
[Serializable]
public class StringButton_Layout
{
	// Token: 0x06000BD2 RID: 3026 RVA: 0x0003ADDC File Offset: 0x00038FDC
	public SpriteFont GetFont()
	{
		/*
An exception occurred when decompiling this method (06000BD2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.SpriteFont StringButton_Layout::GetFont()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	stloc:FontType(var_0_06, ldfld:FontType(StringButton_Layout::RenderFont, ldloc:StringButton_Layout(this)))
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

	// Token: 0x06000BD3 RID: 3027 RVA: 0x0003ADF4 File Offset: 0x00038FF4
	public StringButton_Layout()
	{
		if (17146 == 0)
		{
		}
		this.BackingColor = 17146;
		this.DisabledBackingColour = 17146;
		this.PressedBackingColour = 17146;
		this.BorderColor = 17146;
		this.DisabledBorderColour = 17146;
		this.PressedBorderColour = 17146;
		this.TextColour = 17146;
		this.DisabledTextColour = 17146;
		this.PressedTextColour = 17146;
		if (!true)
		{
		}
		this.HighlightSize = 1;
		this.RenderFont = StringButton_Layout.FontType.DeathText;
		base..ctor();
	}

	// Token: 0x04000EBD RID: 3773
	public ControlAnchor.ControlId AnchorControl;

	// Token: 0x04000EBE RID: 3774
	public LayoutCalculator.AnchorType Anchor = LayoutCalculator.AnchorType.BottomLeft;

	// Token: 0x04000EBF RID: 3775
	public Vector2 Location = 17146;

	// Token: 0x04000EC0 RID: 3776
	public Vector2 Size;

	// Token: 0x04000EC1 RID: 3777
	public Vector2 PickBorder = 17146;

	// Token: 0x04000EC2 RID: 3778
	public Vector2 PickOffset = 17146;

	// Token: 0x04000EC3 RID: 3779
	public int TextInset;

	// Token: 0x04000EC4 RID: 3780
	public Color BackingColor;

	// Token: 0x04000EC5 RID: 3781
	public Color DisabledBackingColour;

	// Token: 0x04000EC6 RID: 3782
	public Color PressedBackingColour;

	// Token: 0x04000EC7 RID: 3783
	public Color BorderColor;

	// Token: 0x04000EC8 RID: 3784
	public Color DisabledBorderColour;

	// Token: 0x04000EC9 RID: 3785
	public Color PressedBorderColour;

	// Token: 0x04000ECA RID: 3786
	public Color TextColour;

	// Token: 0x04000ECB RID: 3787
	public Color DisabledTextColour;

	// Token: 0x04000ECC RID: 3788
	public Color PressedTextColour;

	// Token: 0x04000ECD RID: 3789
	public float Scale;

	// Token: 0x04000ECE RID: 3790
	public float DisabledScale;

	// Token: 0x04000ECF RID: 3791
	public float PressedScale;

	// Token: 0x04000ED0 RID: 3792
	public float ScaleSpeed;

	// Token: 0x04000ED1 RID: 3793
	public Texture_Layout BackingDisabled;

	// Token: 0x04000ED2 RID: 3794
	public Texture_Layout BorderDisabled;

	// Token: 0x04000ED3 RID: 3795
	public Texture_Layout BackingNormal;

	// Token: 0x04000ED4 RID: 3796
	public Texture_Layout BorderNormal;

	// Token: 0x04000ED5 RID: 3797
	public Texture_Layout BackingPressed;

	// Token: 0x04000ED6 RID: 3798
	public Texture_Layout BorderPressed;

	// Token: 0x04000ED7 RID: 3799
	public Texture_Layout BackingHighlightPressed;

	// Token: 0x04000ED8 RID: 3800
	public Vector2 HighlightSize;

	// Token: 0x04000ED9 RID: 3801
	public Color HighlightColour;

	// Token: 0x04000EDA RID: 3802
	public Texture_Layout OverBackingHighlight;

	// Token: 0x04000EDB RID: 3803
	public StringButton_Layout.FontType RenderFont;

	// Token: 0x020001BD RID: 445
	public enum FontType
	{
		// Token: 0x04000EDD RID: 3805
		MouseText,
		// Token: 0x04000EDE RID: 3806
		DeathText
	}
}
