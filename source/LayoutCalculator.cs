using System;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI.Chat;

// Token: 0x020001EC RID: 492
public static class LayoutCalculator
{
	// Token: 0x06000C54 RID: 3156 RVA: 0x0003D8D4 File Offset: 0x0003BAD4
	public static void LoadContent(ContentManager content)
	{
		Texture2D texture2D = content.Load<Texture2D>("Images/UI/VirtualControls/PickingRegion");
		Texture2D texture2D2 = content.Load<Texture2D>("Images/UI/VirtualControls/CircularPickingRegion");
	}

	// Token: 0x06000C55 RID: 3157 RVA: 0x0003D8FC File Offset: 0x0003BAFC
	public static void DrawCentredPickingRegion(SpriteBatch batch, ControlAnchor.ControlId anchorControl, LayoutCalculator.AnchorType anchorType, Vector2 position, Vector2 size)
	{
		if (!true)
		{
		}
	}

	// Token: 0x06000C56 RID: 3158 RVA: 0x0003D90C File Offset: 0x0003BB0C
	public static void DrawCentredPickingRegion(SpriteBatch batch, Vector2 position, Vector2 size)
	{
		if (!true)
		{
		}
	}

	// Token: 0x06000C57 RID: 3159 RVA: 0x0003D91C File Offset: 0x0003BB1C
	public static void DrawCentredCirclePickingRegion(SpriteBatch batch, ControlAnchor.ControlId anchorControl, LayoutCalculator.AnchorType anchorType, Vector2 position, Vector2 size)
	{
		if (!true)
		{
		}
	}

	// Token: 0x06000C58 RID: 3160 RVA: 0x0003D92C File Offset: 0x0003BB2C
	public static void DrawCentredCirclePickingRegion(SpriteBatch batch, Vector2 position, Vector2 size)
	{
		if (!true)
		{
		}
	}

	// Token: 0x06000C59 RID: 3161 RVA: 0x0003D93C File Offset: 0x0003BB3C
	public static void DrawPickingRegion(SpriteBatch batch, ControlAnchor.ControlId anchorControl, LayoutCalculator.AnchorType anchorType, Vector2 position, Vector2 size)
	{
		if (!true)
		{
		}
	}

	// Token: 0x06000C5A RID: 3162 RVA: 0x0003D94C File Offset: 0x0003BB4C
	public static void DrawPickPoint(SpriteBatch batch, Vector2 position)
	{
		if (!true)
		{
		}
	}

	// Token: 0x06000C5B RID: 3163 RVA: 0x0003D964 File Offset: 0x0003BB64
	public static void DrawPickingRegion(SpriteBatch batch, Vector2 position, Vector2 size)
	{
		if (!true)
		{
		}
	}

	// Token: 0x06000C5C RID: 3164 RVA: 0x0003D974 File Offset: 0x0003BB74
	public static void DrawSafeRegion(SpriteBatch batch, Vector2 position, Vector2 size, Color color)
	{
		if (!true)
		{
		}
	}

	// Token: 0x06000C5D RID: 3165 RVA: 0x0003D984 File Offset: 0x0003BB84
	public static void Draw(SpriteBatch batch, Vector2 position, float rotation, float scale, Texture2D texture, [Optional] Color? color)
	{
	}

	// Token: 0x06000C5E RID: 3166 RVA: 0x0003D994 File Offset: 0x0003BB94
	public static void Draw(SpriteBatch batch, Vector2 position, float scale, Texture2D texture, [Optional] Color? color)
	{
	}

	// Token: 0x06000C5F RID: 3167 RVA: 0x0003D9A4 File Offset: 0x0003BBA4
	public static void DrawCentred(SpriteBatch batch, Vector2 position, float scale, Texture2D texture, [Optional] Color? color)
	{
	}

	// Token: 0x06000C60 RID: 3168 RVA: 0x0003D9BC File Offset: 0x0003BBBC
	public static void DrawCentred(SpriteBatch batch, ControlAnchor.ControlId anchorControl, LayoutCalculator.AnchorType anchorType, Vector2 position, float scale, Texture2D texture, [Optional] Color? color)
	{
		if (!true)
		{
		}
		Rectangle layoutRect = LayoutCalculator.GetLayoutRect(anchorControl, anchorType, position, position, texture);
	}

	// Token: 0x06000C61 RID: 3169 RVA: 0x0003D9DC File Offset: 0x0003BBDC
	public static void DrawCentred(SpriteBatch batch, ControlAnchor.ControlId anchorControl, LayoutCalculator.AnchorType anchorType, Vector2 position, Rectangle srcRect, float scale, Texture2D texture, [Optional] Color? color)
	{
		if (!true)
		{
		}
	}

	// Token: 0x06000C62 RID: 3170 RVA: 0x0003D9F0 File Offset: 0x0003BBF0
	public static void DrawCentred(SpriteBatch batch, Vector2 position, Rectangle srcRect, float scale, Texture2D texture, [Optional] Color? color)
	{
	}

	// Token: 0x06000C63 RID: 3171 RVA: 0x0003DA08 File Offset: 0x0003BC08
	public static void Draw(SpriteBatch batch, ControlAnchor.ControlId anchorControl, LayoutCalculator.AnchorType anchorType, Vector2 position, float scale, Texture2D texture, [Optional] Color? color)
	{
		if (!true)
		{
		}
		Rectangle layoutRect = LayoutCalculator.GetLayoutRect(anchorControl, anchorType, position, position, texture);
	}

	// Token: 0x06000C64 RID: 3172 RVA: 0x0003DA28 File Offset: 0x0003BC28
	public static void Draw(SpriteBatch batch, ControlAnchor.ControlId anchorControl, LayoutCalculator.AnchorType anchorType, Vector2 position, Vector2 size, Texture2D texture, [Optional] Color? color)
	{
		if (!true)
		{
		}
	}

	// Token: 0x06000C65 RID: 3173 RVA: 0x0003DA3C File Offset: 0x0003BC3C
	public static bool IsOverIcon(Vector2 position, ControlAnchor.ControlId anchorControl, LayoutCalculator.AnchorType anchorType, Vector2 anchorPosition, Texture2D texture, float textureScale, Vector2 pickingBorder)
	{
		if (!true)
		{
		}
		if (!true)
		{
		}
		return true;
	}

	// Token: 0x06000C66 RID: 3174 RVA: 0x0003DA5C File Offset: 0x0003BC5C
	public static Vector2 GetChatManagerAlignmentOffset(SpriteFont font, TextSnippet[] text, float scale, LayoutCalculator.AnchorType stringAlignment, float maxWidth = -1f)
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
		return 1;
	}

	// Token: 0x06000C67 RID: 3175 RVA: 0x0003DA7C File Offset: 0x0003BC7C
	public static Vector2 GetAlignmentOffset(SpriteFont font, string text, float scale, LayoutCalculator.AnchorType stringAlignment)
	{
		if (!true)
		{
		}
		return 1;
	}

	// Token: 0x06000C68 RID: 3176 RVA: 0x0003DA98 File Offset: 0x0003BC98
	public static Vector2 GetChatManagerAlignmentOffset(SpriteFont font, string text, float scale, LayoutCalculator.AnchorType stringAlignment)
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
		return 1;
	}

	// Token: 0x06000C69 RID: 3177 RVA: 0x0003DAB8 File Offset: 0x0003BCB8
	public static Vector2 GetAlignmentOffset(SpriteFont font, StringBuilder text, float scale, LayoutCalculator.AnchorType stringAlignment)
	{
		Vector2 vector = font.MeasureString(text);
		if (!true)
		{
		}
		return 1;
	}

	// Token: 0x06000C6A RID: 3178 RVA: 0x0003DADC File Offset: 0x0003BCDC
	public static Vector2 GetAlignmentOffset(SpriteFont font, string text, float scale, LayoutCalculator.AnchorType stringAlignment, [Out] Vector2 stringDimensions)
	{
		Vector2 vector = font.MeasureString(text);
		if (!true)
		{
		}
		return 1;
	}

	// Token: 0x06000C6B RID: 3179 RVA: 0x0003DB00 File Offset: 0x0003BD00
	public static Vector2 GetAlignmentOffset(SpriteFont font, StringBuilder text, float scale, LayoutCalculator.AnchorType stringAlignment, [Out] Vector2 stringDimensions)
	{
		Vector2 vector = font.MeasureString(text);
		if (!true)
		{
		}
		return 1;
	}

	// Token: 0x06000C6C RID: 3180 RVA: 0x0003DB24 File Offset: 0x0003BD24
	public static Vector2 GetAnchoredStringPosition(ControlAnchor.ControlId anchorControl, LayoutCalculator.AnchorType anchorType, Vector2 position, SpriteFont font, string text, float scale, LayoutCalculator.AnchorType stringAlignment)
	{
		if (!true)
		{
		}
		Vector2 anchoredPosition = LayoutCalculator.GetAnchoredPosition(anchorControl, anchorType, position);
		if (!true)
		{
		}
		return 1;
	}

	// Token: 0x06000C6D RID: 3181 RVA: 0x0003DB44 File Offset: 0x0003BD44
	public static Vector2 GetAnchoredStringPosition(ControlAnchor.ControlId anchorControl, LayoutCalculator.AnchorType anchorType, Vector2 position, SpriteFont font, TextSnippet[] text, float scale, LayoutCalculator.AnchorType stringAlignment, float maxWidth = -1f)
	{
		if (!true)
		{
		}
		Vector2 anchoredPosition = LayoutCalculator.GetAnchoredPosition(anchorControl, anchorType, position);
		if (!true)
		{
		}
		return 1;
	}

	// Token: 0x06000C6E RID: 3182 RVA: 0x0003DB64 File Offset: 0x0003BD64
	public static Vector2 GetAnchoredChatManagerStringPosition(ControlAnchor.ControlId anchorControl, LayoutCalculator.AnchorType anchorType, Vector2 position, SpriteFont font, string text, float scale, LayoutCalculator.AnchorType stringAlignment)
	{
		if (!true)
		{
		}
		Vector2 anchoredPosition = LayoutCalculator.GetAnchoredPosition(anchorControl, anchorType, position);
		if (!true)
		{
		}
		return 1;
	}

	// Token: 0x06000C6F RID: 3183 RVA: 0x0003DB84 File Offset: 0x0003BD84
	public static Vector2 GetAnchoredStringPosition(ControlAnchor.ControlId anchorControl, LayoutCalculator.AnchorType anchorType, Vector2 position, SpriteFont font, StringBuilder text, float scale, LayoutCalculator.AnchorType stringAlignment)
	{
		if (!true)
		{
		}
		Vector2 anchoredPosition = LayoutCalculator.GetAnchoredPosition(anchorControl, anchorType, position);
		if (!true)
		{
		}
		return 1;
	}

	// Token: 0x06000C70 RID: 3184 RVA: 0x0003DBA4 File Offset: 0x0003BDA4
	public static Vector2 GetAnchoredStringButtonPosition(ControlAnchor.ControlId anchorControl, LayoutCalculator.AnchorType anchorType, Vector2 position, SpriteFont font, string text, float scale, LayoutCalculator.AnchorType stringAlignment, [Out] bool over, [Out] Vector2 dimensions)
	{
		/*
An exception occurred when decompiling this method (06000C70)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 LayoutCalculator::GetAnchoredStringButtonPosition(ControlAnchor/ControlId,LayoutCalculator/AnchorType,Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Graphics.SpriteFont,System.String,System.Single,LayoutCalculator/AnchorType,System.Boolean,Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000F:
	stloc:bool(var_4_18, ldfld:bool(bool::m_value, ldloc:bool[exp:bool&](over)))
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

	// Token: 0x06000C71 RID: 3185 RVA: 0x0003DBCC File Offset: 0x0003BDCC
	public static Vector2 GetAnchoredStringButtonPosition(ControlAnchor.ControlId anchorControl, LayoutCalculator.AnchorType anchorType, Vector2 position, SpriteFont font, StringBuilder text, float scale, LayoutCalculator.AnchorType stringAlignment, [Out] bool over, [Out] Vector2 dimensions)
	{
		/*
An exception occurred when decompiling this method (06000C71)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 LayoutCalculator::GetAnchoredStringButtonPosition(ControlAnchor/ControlId,LayoutCalculator/AnchorType,Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Graphics.SpriteFont,System.Text.StringBuilder,System.Single,LayoutCalculator/AnchorType,System.Boolean,Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000F:
	stloc:bool(var_4_18, ldfld:bool(bool::m_value, ldloc:bool[exp:bool&](over)))
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

	// Token: 0x06000C72 RID: 3186 RVA: 0x0003DBF4 File Offset: 0x0003BDF4
	public static Vector2 GetAnchoredPosition(ControlAnchor.ControlId anchorControl, LayoutCalculator.AnchorType anchorType, Vector2 position)
	{
		Rectangle controlRegion = ControlAnchor.GetControlRegion(anchorControl);
		Vector2 vector;
		return vector;
	}

	// Token: 0x06000C73 RID: 3187 RVA: 0x000021DB File Offset: 0x000003DB
	public static Rectangle GetLayoutRect(ControlAnchor.ControlId anchorControl, LayoutCalculator.AnchorType anchorType, Vector2 position, Vector2 size, Texture2D texture)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000C74 RID: 3188 RVA: 0x0003DC18 File Offset: 0x0003BE18
	// Note: this type is marked as 'beforefieldinit'.
	static LayoutCalculator()
	{
	}

	// Token: 0x040011E7 RID: 4583
	public static bool DrawSafeRegions;

	// Token: 0x040011E8 RID: 4584
	public static bool DrawPickingRegions;

	// Token: 0x040011E9 RID: 4585
	private static Texture2D _pickingRegion;

	// Token: 0x040011EA RID: 4586
	private static Texture2D _pickingRegionCircle;

	// Token: 0x040011EB RID: 4587
	private static Color _pickingRegionColour;

	// Token: 0x020001ED RID: 493
	public enum AnchorFlags
	{
		// Token: 0x040011ED RID: 4589
		Left = 1,
		// Token: 0x040011EE RID: 4590
		CentreHorizontal,
		// Token: 0x040011EF RID: 4591
		Right = 4,
		// Token: 0x040011F0 RID: 4592
		Top = 8,
		// Token: 0x040011F1 RID: 4593
		CentreVertical = 16,
		// Token: 0x040011F2 RID: 4594
		Bottom = 32
	}

	// Token: 0x020001EE RID: 494
	public enum AnchorType
	{
		// Token: 0x040011F4 RID: 4596
		TopLeft = 9,
		// Token: 0x040011F5 RID: 4597
		TopCentre,
		// Token: 0x040011F6 RID: 4598
		TopRight = 12,
		// Token: 0x040011F7 RID: 4599
		CentreLeft = 17,
		// Token: 0x040011F8 RID: 4600
		CentreBoth,
		// Token: 0x040011F9 RID: 4601
		CentreRight = 20,
		// Token: 0x040011FA RID: 4602
		BottomLeft = 33,
		// Token: 0x040011FB RID: 4603
		BottomCentre,
		// Token: 0x040011FC RID: 4604
		BottomRight = 36
	}
}
