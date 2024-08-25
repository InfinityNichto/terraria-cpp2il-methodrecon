using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Localization;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000944 RID: 2372
	public class CustomEntryIcon : IEntryIcon
	{
		// Token: 0x060047A4 RID: 18340 RVA: 0x0025F160 File Offset: 0x0025D360
		public CustomEntryIcon(string nameLanguageKey, string texturePath, Func<bool> unlockCondition)
		{
			LocalizedText text = Language.GetText(nameLanguageKey);
			this._text = text;
		}

		// Token: 0x060047A5 RID: 18341 RVA: 0x0025F19C File Offset: 0x0025D39C
		public IEntryIcon CreateClone()
		{
			/*
An exception occurred when decompiling this method (060047A5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.GameContent.Bestiary.IEntryIcon Terraria.GameContent.Bestiary.CustomEntryIcon::CreateClone()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:LocalizedText(var_0_06, ldfld:LocalizedText(CustomEntryIcon::_text, ldloc:CustomEntryIcon(this)))
	stloc:class ReLogic.Content.Asset`1<class Microsoft.Xna.Framework.Graphics.Texture2D>(var_1_0D, ldfld:class ReLogic.Content.Asset`1<class Microsoft.Xna.Framework.Graphics.Texture2D>(CustomEntryIcon::_textureAsset, ldloc:CustomEntryIcon(this)))
	stloc:class [mscorlib]System.Func`1<bool>(var_2_14, ldfld:class [mscorlib]System.Func`1<bool>(CustomEntryIcon::_unlockCondition, ldloc:CustomEntryIcon(this)))
	stloc:string(var_3_1B, ldfld:string(LocalizedText::Key, ldloc:LocalizedText(var_0_06)))
	stloc:string(var_4_22, ldfld:string(Asset`1::<Name>k__BackingField, ldloc:class ReLogic.Content.Asset`1<class Microsoft.Xna.Framework.Graphics.Texture2D>[exp:Asset`1](var_1_0D)))
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

		// Token: 0x060047A6 RID: 18342 RVA: 0x0025F1CC File Offset: 0x0025D3CC
		public void Update(BestiaryUICollectionInfo providedInfo, Rectangle hitbox, EntryIconDrawSettings settings)
		{
		}

		// Token: 0x060047A7 RID: 18343 RVA: 0x0025F1DC File Offset: 0x0025D3DC
		public void Draw(BestiaryUICollectionInfo providedInfo, SpriteBatch spriteBatch, EntryIconDrawSettings settings)
		{
			Asset<Texture2D> textureAsset = this._textureAsset;
			Point point;
			Vector2 vector = point.ToVector2();
			if (!true)
			{
			}
			Rectangle sourceRectangle = this._sourceRectangle;
			int width = this._sourceRectangle.Width;
			if (!true)
			{
			}
			Rectangle sourceRectangle2 = this._sourceRectangle;
			int width2 = this._sourceRectangle.Width;
			Vector2 vector2 = sourceRectangle2.Size();
		}

		// Token: 0x060047A8 RID: 18344 RVA: 0x0025F238 File Offset: 0x0025D438
		public string GetHoverText(BestiaryUICollectionInfo providedInfo)
		{
			LocalizedText text = this._text;
			return "???";
		}

		// Token: 0x060047A9 RID: 18345 RVA: 0x0025F258 File Offset: 0x0025D458
		private void UpdateUnlockState(bool state)
		{
			Asset<Texture2D> textureAsset = this._textureAsset;
			if (!true)
			{
			}
			int num = true.ToInt();
			long num2 = 0L;
			long num3 = 0L;
			long num4 = 0L;
			Rectangle rectangle = Utils.Frame(textureAsset, 2, 1, num, (int)num2, (int)num3, (int)num4);
			this._sourceRectangle = rectangle;
		}

		// Token: 0x060047AA RID: 18346 RVA: 0x000021DB File Offset: 0x000003DB
		public bool GetUnlockState(BestiaryUICollectionInfo providedInfo)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x04008375 RID: 33653
		private LocalizedText _text;

		// Token: 0x04008376 RID: 33654
		private Asset<Texture2D> _textureAsset;

		// Token: 0x04008377 RID: 33655
		private Rectangle _sourceRectangle;

		// Token: 0x04008378 RID: 33656
		private Func<bool> _unlockCondition;
	}
}
