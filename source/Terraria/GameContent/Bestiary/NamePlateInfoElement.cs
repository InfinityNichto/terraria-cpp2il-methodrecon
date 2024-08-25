using System;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000966 RID: 2406
	public class NamePlateInfoElement : IBestiaryInfoElement, IProvideSearchFilterString
	{
		// Token: 0x06004817 RID: 18455 RVA: 0x0025FCEC File Offset: 0x0025DEEC
		public NamePlateInfoElement(string languageKey, int npcNetId)
		{
			this._key = languageKey;
			this._npcNetId = npcNetId;
		}

		// Token: 0x06004818 RID: 18456 RVA: 0x0025FD10 File Offset: 0x0025DF10
		public string GetName()
		{
			return Language.GetTextValue(this._key);
		}

		// Token: 0x06004819 RID: 18457 RVA: 0x0025FD28 File Offset: 0x0025DF28
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			/*
An exception occurred when decompiling this method (06004819)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.UI.UIElement Terraria.GameContent.Bestiary.NamePlateInfoElement::ProvideUIElement(Terraria.GameContent.Bestiary.BestiaryUICollectionInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:LocalizedText(var_0_0B, call:LocalizedText(Language::GetText, ldfld:string(NamePlateInfoElement::_key, ldloc:NamePlateInfoElement(this))))
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

		// Token: 0x0600481A RID: 18458 RVA: 0x0025FD40 File Offset: 0x0025DF40
		public string GetSearchString(BestiaryUICollectionInfo info)
		{
			if (info.UnlockState != BestiaryEntryUnlockState.NotKnownAtAll_0)
			{
				return Language.GetText(this._key).<Value>k__BackingField;
			}
		}

		// Token: 0x040083AA RID: 33706
		private string _key;

		// Token: 0x040083AB RID: 33707
		private int _npcNetId;
	}
}
