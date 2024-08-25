using System;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI.Chat;

// Token: 0x0200011A RID: 282
public static class GUIString
{
	// Token: 0x0600070E RID: 1806 RVA: 0x00018AD4 File Offset: 0x00016CD4
	public static void Draw(String_Layout layout, TextSnippet[] textSnippets, [Out] int snippetSelected, float maxWidth = -1f, int maxLines = 100)
	{
		ControlAnchor.ControlId anchorControl = layout.AnchorControl;
		Vector2 location = layout.Location;
		float x = layout.Location.X;
		float y = layout.Location.Y;
		SpriteFont font = layout.GetFont();
		float scale = layout.Scale;
		LayoutCalculator.AnchorType alignment = layout.Alignment;
		SpriteFont font2 = layout.GetFont();
		if (!true)
		{
		}
		if (!true)
		{
		}
		float scale2 = layout.Scale;
		if (!true)
		{
		}
	}

	// Token: 0x0600070F RID: 1807 RVA: 0x00018B3C File Offset: 0x00016D3C
	public static string ApplyMultiLineAlignment(String_Layout layout, string value, [Out] int lineCount)
	{
		/*
An exception occurred when decompiling this method (0600070F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String GUIString::ApplyMultiLineAlignment(String_Layout,System.String,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00A6:
	stloc:Vector2(var_67_AF, call:Vector2(SpriteFont::MeasureString, ldloc:SpriteFont(var_66), ldloc:string(var_64)))
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

	// Token: 0x06000710 RID: 1808 RVA: 0x00018C00 File Offset: 0x00016E00
	public static void Draw(String_Layout layout, string value, Color overloadedColour, bool multilineAlignmentApplied = false)
	{
		int num;
		do
		{
			if (!true)
			{
			}
			num = 1;
			float scale = layout.Scale;
			if (layout.MultiLineUseAlignment)
			{
				float wrapWidth = layout.WrapWidth;
				float multilineScale = layout.MultilineScale;
			}
			ControlAnchor.ControlId anchorControl = layout.AnchorControl;
			Vector2 location = layout.Location;
			float x = layout.Location.X;
			float y = layout.Location.Y;
			SpriteFont font = layout.GetFont();
			LayoutCalculator.AnchorType alignment = layout.Alignment;
			if (num == 0)
			{
			}
		}
		while (!layout.MultiLineUseAlignment);
		if (layout.Alignment == (LayoutCalculator.AnchorType)0)
		{
		}
		SpriteFont font2 = layout.GetFont();
		if (num == 0)
		{
		}
		int num2 = 1;
		if (num2 == 0)
		{
		}
		int value2 = num2.m_value;
		int num3 = 1;
		if (num3 == 0)
		{
		}
		if (num3 == 0)
		{
		}
	}

	// Token: 0x06000711 RID: 1809 RVA: 0x00018D50 File Offset: 0x00016F50
	public static void Draw(String_Layout layout, StringBuilder value, Color overloadedColour)
	{
		if (!true)
		{
		}
		ControlAnchor.ControlId anchorControl = layout.AnchorControl;
		Vector2 location = layout.Location;
		float x = layout.Location.X;
		float y = layout.Location.Y;
		SpriteFont font = layout.GetFont();
		float scale = layout.Scale;
		LayoutCalculator.AnchorType alignment = layout.Alignment;
		if (!true)
		{
		}
		SpriteFont font2 = layout.GetFont();
		if (!true)
		{
		}
		if (!true)
		{
		}
		if (!true)
		{
		}
		float scale2 = layout.Scale;
	}

	// Token: 0x06000712 RID: 1810 RVA: 0x00018DC0 File Offset: 0x00016FC0
	public static void Draw(String_Layout layout, string value)
	{
		Color color = layout.Color;
		if (!true)
		{
		}
		long num = 0L;
		GUIString.Draw(layout, value, color, num != 0L);
	}

	// Token: 0x06000713 RID: 1811 RVA: 0x00018DE4 File Offset: 0x00016FE4
	public static void Draw(String_Layout layout, StringBuilder value)
	{
		Color color = layout.Color;
		if (!true)
		{
		}
		GUIString.Draw(layout, value, color);
	}

	// Token: 0x06000714 RID: 1812 RVA: 0x00018E04 File Offset: 0x00017004
	public static Vector2 CalculateStringPosition(String_Layout layout, string value)
	{
		/*
An exception occurred when decompiling this method (06000714)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 GUIString::CalculateStringPosition(String_Layout,System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0045:
	stloc:AnchorType(var_14_54, ldfld:AnchorType(String_Layout::Alignment, ldloc:String_Layout(layout)))
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

	// Token: 0x06000715 RID: 1813 RVA: 0x00018E68 File Offset: 0x00017068
	public static Rectangle GetRegion(String_Layout layout, string value)
	{
		int num = 1;
		if (num == 0)
		{
		}
		if (num == 0)
		{
			return;
		}
	}

	// Token: 0x06000716 RID: 1814 RVA: 0x00018E88 File Offset: 0x00017088
	public static void DrawWithShadow(String_Layout layout, string value, Vector2 position, Color overloadedColour)
	{
		if (!true)
		{
		}
		SpriteFont font = layout.GetFont();
		if (!true)
		{
		}
		if (!true)
		{
		}
		float scale = layout.Scale;
		if (!true)
		{
		}
	}

	// Token: 0x06000717 RID: 1815 RVA: 0x00018EB4 File Offset: 0x000170B4
	public static void DrawWithShadow(String_Layout layout, string value, Vector2 stringPosition)
	{
		Color color = layout.Color;
		if (!true)
		{
		}
	}

	// Token: 0x06000718 RID: 1816 RVA: 0x00018ECC File Offset: 0x000170CC
	public static void DrawWithShadow(String_Layout layout, string value)
	{
		if (!true)
		{
		}
		Vector2 vector = GUIString.CalculateStringPosition(layout, value);
		Color color = layout.Color;
	}

	// Token: 0x06000719 RID: 1817 RVA: 0x00018EEC File Offset: 0x000170EC
	public static void DrawWithShadow(String_Layout layout, string value, bool calculatePosition, Color overloadedColour)
	{
		if (!true)
		{
		}
		if (!true)
		{
		}
		if (!true)
		{
		}
		Vector2 vector = GUIString.CalculateStringPosition(layout, value);
	}

	// Token: 0x0600071A RID: 1818 RVA: 0x00018F10 File Offset: 0x00017110
	public static bool DrawButton(String_Layout layout, string value, Color overloadedColour)
	{
		/*
An exception occurred when decompiling this method (0600071A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIString::DrawButton(String_Layout,System.String,Microsoft.Xna.Framework.Graphics.Color)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00C0:
	brtrue(IL_0000, ldloc:int32[exp:bool](var_35_BA))
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

	// Token: 0x0600071B RID: 1819 RVA: 0x00018FE8 File Offset: 0x000171E8
	public static bool DrawButton(String_Layout layout, string value)
	{
		if (!true)
		{
		}
		bool flag;
		return flag;
	}

	// Token: 0x0600071C RID: 1820 RVA: 0x00018FFC File Offset: 0x000171FC
	// Note: this type is marked as 'beforefieldinit'.
	static GUIString()
	{
	}

	// Token: 0x04000593 RID: 1427
	public static int MaxLastLineWidthInsertExraLine;
}
