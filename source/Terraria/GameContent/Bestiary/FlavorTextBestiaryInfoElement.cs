using System;
using System.Runtime.CompilerServices;
using Terraria.GameContent.UI.Elements;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000962 RID: 2402
	public class FlavorTextBestiaryInfoElement : IBestiaryInfoElement
	{
		// Token: 0x0600480D RID: 18445 RVA: 0x0025FB3C File Offset: 0x0025DD3C
		public FlavorTextBestiaryInfoElement(string languageKey)
		{
			this._key = languageKey;
		}

		// Token: 0x0600480E RID: 18446 RVA: 0x0025FB58 File Offset: 0x0025DD58
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			/*
An exception occurred when decompiling this method (0600480E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.UI.UIElement Terraria.GameContent.Bestiary.FlavorTextBestiaryInfoElement::ProvideUIElement(Terraria.GameContent.Bestiary.BestiaryUICollectionInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0015:
	stloc:LocalizedText(var_4_20, call:LocalizedText(Language::GetText, ldfld:string(FlavorTextBestiaryInfoElement::_key, ldloc:FlavorTextBestiaryInfoElement(this))))
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

		// Token: 0x0600480F RID: 18447 RVA: 0x0025FB90 File Offset: 0x0025DD90
		private static void AddDynamicResize(UIElement container, UIText text)
		{
		}

		// Token: 0x040083A2 RID: 33698
		public string _key;

		// Token: 0x02000963 RID: 2403
		[CompilerGenerated]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x06004810 RID: 18448 RVA: 0x0025FBA0 File Offset: 0x0025DDA0
			public <>c__DisplayClass3_0()
			{
			}

			// Token: 0x06004811 RID: 18449 RVA: 0x0025FBB4 File Offset: 0x0025DDB4
			internal void <AddDynamicResize>b__0()
			{
				UIElement uielement = this.container;
				float pixels = this.text.MinHeight.Pixels;
			}

			// Token: 0x040083A3 RID: 33699
			public UIElement container;

			// Token: 0x040083A4 RID: 33700
			public UIText text;
		}
	}
}
