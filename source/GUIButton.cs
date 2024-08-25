using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000103 RID: 259
public static class GUIButton
{
	// Token: 0x170000CE RID: 206
	// (get) Token: 0x060006A8 RID: 1704 RVA: 0x00015CCC File Offset: 0x00013ECC
	private static SpriteBatch sb
	{
		get
		{
			/*
An exception occurred when decompiling this method (060006A8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.SpriteBatch GUIButton::get_sb()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
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
	}

	// Token: 0x060006A9 RID: 1705 RVA: 0x00015CDC File Offset: 0x00013EDC
	public static void Draw(Button_Layout layout, Texture2D texture, [Optional] Color? overrideColor, [Optional] float? overrideScale)
	{
		if (!true)
		{
		}
		SpriteBatch sb = GUIButton.sb;
		ControlAnchor.ControlId anchorControl = layout.AnchorControl;
		Vector2 location = layout.Location;
		float x = layout.Location.X;
		float y = layout.Location.Y;
	}

	// Token: 0x060006AA RID: 1706 RVA: 0x00015DA8 File Offset: 0x00013FA8
	public static void DrawAtPosition(Button_Layout layout, Vector2 position, Texture2D texture, [Optional] Color? overrideColor, [Optional] float? overrideScale)
	{
		if (!true)
		{
		}
		SpriteBatch sb = GUIButton.sb;
	}

	// Token: 0x060006AB RID: 1707 RVA: 0x000021DB File Offset: 0x000003DB
	public static void Draw(Button_Layout layout, Rectangle srcRect, Texture2D texture, [Optional] Color? overrideColor, [Optional] float? overrideScale)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060006AC RID: 1708 RVA: 0x00015E10 File Offset: 0x00014010
	public static Rectangle GetRegion(Button_Layout layout, Texture2D texture)
	{
		if (!true)
		{
		}
		if (!true)
		{
		}
		if (!true)
		{
			return;
		}
	}

	// Token: 0x060006AD RID: 1709 RVA: 0x00015E38 File Offset: 0x00014038
	public static bool RegisterPickingRegion(Button_Layout layout, Texture2D texture)
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
		Vector2 vector;
		float num = vector.Length();
		float num2 = vector.Length();
		float num3 = vector.Length();
		return true;
	}

	// Token: 0x060006AE RID: 1710 RVA: 0x00015E84 File Offset: 0x00014084
	public static bool IsCursorOverAtPosition(Vector2 position, Button_Layout layout, Vector2 controlPosition, Texture2D texture)
	{
		if (!true)
		{
		}
		if (!true)
		{
		}
		if (true)
		{
			Vector2 vector;
			float num = vector.Length();
			float num2 = vector.Length();
			float num3 = vector.Length();
		}
		return true;
	}

	// Token: 0x060006AF RID: 1711 RVA: 0x00015EC8 File Offset: 0x000140C8
	public static bool IsCursorOverExpanded(Vector2 position, Button_Layout layout, Texture2D texture, float expanded)
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
		if (true)
		{
			Vector2 vector;
			float num = vector.Length();
			float num2 = vector.Length();
			float num3 = vector.Length();
			float num4 = vector.Length();
			float num5 = vector.Length();
			float num6 = vector.Length();
			float num7 = vector.Length();
		}
		return true;
	}

	// Token: 0x060006B0 RID: 1712 RVA: 0x00015F38 File Offset: 0x00014138
	public static bool IsCursorOver(Vector2 position, Button_Layout layout, Texture2D texture)
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
		if (true)
		{
			Vector2 vector;
			float num = vector.Length();
			float num2 = vector.Length();
			float num3 = vector.Length();
		}
		return true;
	}

	// Token: 0x060006B1 RID: 1713 RVA: 0x00015F80 File Offset: 0x00014180
	// Note: this type is marked as 'beforefieldinit'.
	static GUIButton()
	{
	}

	// Token: 0x04000527 RID: 1319
	public static float GlobalScale;

	// Token: 0x04000528 RID: 1320
	public static SpriteBatch overloadedSpriteBatch;
}
