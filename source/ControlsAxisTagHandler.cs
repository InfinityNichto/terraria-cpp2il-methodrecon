using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI.Chat;

// Token: 0x020000F6 RID: 246
public class ControlsAxisTagHandler : ITagHandler
{
	// Token: 0x06000678 RID: 1656 RVA: 0x00014E58 File Offset: 0x00013058
	public static bool MeasureInline(SpriteFont.CharacterSource text, int offset, int endOffset, Vector2 size)
	{
	}

	// Token: 0x06000679 RID: 1657 RVA: 0x00014E70 File Offset: 0x00013070
	public static bool PrintInline(SpriteBatch spriteBatch, Vector2 position, Color color, float scale, SpriteFont.CharacterSource text, int offset, int endOffset, Vector2 size)
	{
	}

	// Token: 0x0600067A RID: 1658 RVA: 0x00014E88 File Offset: 0x00013088
	public TextSnippet Parse(string text, [Optional] Color baseColor, [Optional] string options)
	{
		/*
An exception occurred when decompiling this method (0600067A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.UI.Chat.TextSnippet ControlsAxisTagHandler::Parse(System.String,Microsoft.Xna.Framework.Graphics.Color,System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_2_10, call:string(string::Concat, ldstr:string("[ca:"), ldloc:string(var_1), ldstr:string("]")))
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

	// Token: 0x0600067B RID: 1659 RVA: 0x00014EA8 File Offset: 0x000130A8
	public ControlsAxisTagHandler()
	{
	}

	// Token: 0x020000F7 RID: 247
	public class ControlsAxisSnippet : TextSnippet
	{
		// Token: 0x0600067C RID: 1660 RVA: 0x00014EBC File Offset: 0x000130BC
		public ControlsAxisSnippet(GUIControllerInputButton.AxisControl axisControl)
			: base("")
		{
			this._axisControl = axisControl;
			if (!true)
			{
			}
			this.Color = 1;
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x00014EE8 File Offset: 0x000130E8
		public static bool Draw(GUIControllerInputButton.AxisControl axisControl, bool justCheckingString, [Out] Vector2 size, SpriteBatch spriteBatch, [Optional] Vector2 position, [Optional] Color color, float scale = 1f)
		{
			if (true && true)
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
			}
			justCheckingString.m_value = true;
			return true;
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x00014F0C File Offset: 0x0001310C
		public override bool UniqueDraw(bool justCheckingString, [Out] Vector2 size, SpriteBatch spriteBatch, [Optional] Vector2 position, [Optional] Color color, float scale = 1f)
		{
			bool flag = ControlsAxisTagHandler.ControlsAxisSnippet.Draw(this._axisControl, justCheckingString, size, spriteBatch, position, color, scale);
			return true;
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x000021DB File Offset: 0x000003DB
		public override float GetStringLength(SpriteFont font)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x040004F4 RID: 1268
		private readonly GUIControllerInputButton.AxisControl _axisControl;
	}
}
