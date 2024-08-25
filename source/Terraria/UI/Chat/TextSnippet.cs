using System;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.UI.Chat
{
	// Token: 0x02000730 RID: 1840
	public class TextSnippet
	{
		// Token: 0x06003CE0 RID: 15584 RVA: 0x00237C30 File Offset: 0x00235E30
		public TextSnippet(string text = "")
		{
			if (!true)
			{
			}
			this.Color = 1;
			this.CheckForHover = 16256 != 0;
			base..ctor();
			this.Text = text;
			this.TextOriginal = text;
		}

		// Token: 0x06003CE1 RID: 15585 RVA: 0x00237C68 File Offset: 0x00235E68
		public TextSnippet(string text, Color color, float scale = 1f)
		{
			if (!true)
			{
			}
			this.Color = 1;
			this.CheckForHover = 16256 != 0;
			base..ctor();
			this.Text = text;
			this.TextOriginal = text;
			this.Color = color;
		}

		// Token: 0x06003CE2 RID: 15586 RVA: 0x00237CA8 File Offset: 0x00235EA8
		public virtual void Update()
		{
		}

		// Token: 0x06003CE3 RID: 15587 RVA: 0x00237CB8 File Offset: 0x00235EB8
		public virtual void OnHover()
		{
		}

		// Token: 0x06003CE4 RID: 15588 RVA: 0x00237CC8 File Offset: 0x00235EC8
		public virtual void OnClick()
		{
		}

		// Token: 0x06003CE5 RID: 15589 RVA: 0x00237CD8 File Offset: 0x00235ED8
		public virtual Color GetVisibleColor()
		{
			Color color = this.Color;
			if (!true)
			{
			}
			Color color2 = ChatManager.WaveColor(color);
			return 1;
		}

		// Token: 0x06003CE6 RID: 15590 RVA: 0x00237CF8 File Offset: 0x00235EF8
		public virtual bool UniqueDraw(bool justCheckingString, [Out] Vector2 size, SpriteBatch spriteBatch, [Optional] Vector2 position, [Optional] Color color, float scale = 1f)
		{
			/*
An exception occurred when decompiling this method (06003CE6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.UI.Chat.TextSnippet::UniqueDraw(System.Boolean,Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Graphics.SpriteBatch,Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Graphics.Color,System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0006:
	stfld:float32(Vector2::X, ldloc:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](size), ldc.i4:int32[exp:float32](1))
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

		// Token: 0x06003CE7 RID: 15591 RVA: 0x00237D14 File Offset: 0x00235F14
		public virtual TextSnippet CopyMorph(string newText)
		{
			if (base.MemberwiseClone() != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06003CE8 RID: 15592 RVA: 0x00237D30 File Offset: 0x00235F30
		public virtual float GetStringLength(SpriteFont font)
		{
			/*
An exception occurred when decompiling this method (06003CE8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.UI.Chat.TextSnippet::GetStringLength(Microsoft.Xna.Framework.Graphics.SpriteFont)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_06, ldfld:string(TextSnippet::Text, ldloc:TextSnippet(this)))
	stloc:Vector2(var_1_0E, call:Vector2(SpriteFont::MeasureString, ldloc:SpriteFont(font), ldloc:string(var_0_06)))
	stloc:float32(var_2_15, ldfld:float32(TextSnippet::Scale, ldloc:TextSnippet(this)))
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

		// Token: 0x06003CE9 RID: 15593 RVA: 0x00237D54 File Offset: 0x00235F54
		public override string ToString()
		{
			string text = this.Text;
			string textOriginal = this.TextOriginal;
			return "Text: " + text + " | OriginalText: " + textOriginal;
		}

		// Token: 0x04007BED RID: 31725
		public string Text;

		// Token: 0x04007BEE RID: 31726
		public string TextOriginal;

		// Token: 0x04007BEF RID: 31727
		public Color Color;

		// Token: 0x04007BF0 RID: 31728
		public float Scale;

		// Token: 0x04007BF1 RID: 31729
		public bool CheckForHover;

		// Token: 0x04007BF2 RID: 31730
		public bool DeleteWhole;
	}
}
