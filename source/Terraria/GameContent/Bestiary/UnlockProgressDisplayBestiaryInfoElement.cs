using System;
using System.Runtime.CompilerServices;
using Terraria.GameContent.UI.Elements;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000964 RID: 2404
	public class UnlockProgressDisplayBestiaryInfoElement : IBestiaryInfoElement
	{
		// Token: 0x06004812 RID: 18450 RVA: 0x0025FBDC File Offset: 0x0025DDDC
		public UnlockProgressDisplayBestiaryInfoElement(BestiaryUnlockProgressReport progressReport)
		{
			this._progressReport = progressReport;
		}

		// Token: 0x06004813 RID: 18451 RVA: 0x0025FBF8 File Offset: 0x0025DDF8
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			/*
An exception occurred when decompiling this method (06004813)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.UI.UIElement Terraria.GameContent.Bestiary.UnlockProgressDisplayBestiaryInfoElement::ProvideUIElement(Terraria.GameContent.Bestiary.BestiaryUICollectionInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0038:
	stloc:string(var_8_44, call:string(string::Format, ldstr:string("{0} Bestiary Collected"), ldloc:string[exp:object](var_7)))
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

		// Token: 0x06004814 RID: 18452 RVA: 0x0025FC5C File Offset: 0x0025DE5C
		private void AddDynamicResize(UIElement container, UIText text)
		{
		}

		// Token: 0x040083A5 RID: 33701
		private BestiaryUnlockProgressReport _progressReport;

		// Token: 0x040083A6 RID: 33702
		private UIElement _text1;

		// Token: 0x040083A7 RID: 33703
		private UIElement _text2;

		// Token: 0x02000965 RID: 2405
		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_0
		{
			// Token: 0x06004815 RID: 18453 RVA: 0x0025FC6C File Offset: 0x0025DE6C
			public <>c__DisplayClass5_0()
			{
			}

			// Token: 0x06004816 RID: 18454 RVA: 0x0025FC80 File Offset: 0x0025DE80
			internal void <AddDynamicResize>b__0()
			{
				UIElement uielement = this.container;
				UnlockProgressDisplayBestiaryInfoElement unlockProgressDisplayBestiaryInfoElement = this.<>4__this;
				UIElement text = unlockProgressDisplayBestiaryInfoElement._text1;
				UIElement text2 = unlockProgressDisplayBestiaryInfoElement._text2;
				float pixels = text.MinHeight.Pixels;
				float pixels2 = text2.MinHeight.Pixels;
				UnlockProgressDisplayBestiaryInfoElement unlockProgressDisplayBestiaryInfoElement2 = this.<>4__this;
				UIElement text3 = unlockProgressDisplayBestiaryInfoElement2._text1;
				UIElement text4 = unlockProgressDisplayBestiaryInfoElement2._text2;
				float pixels3 = text3.MinHeight.Pixels;
			}

			// Token: 0x040083A8 RID: 33704
			public UIElement container;

			// Token: 0x040083A9 RID: 33705
			public UnlockProgressDisplayBestiaryInfoElement <>4__this;
		}
	}
}
