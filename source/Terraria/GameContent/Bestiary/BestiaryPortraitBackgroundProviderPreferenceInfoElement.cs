using System;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000959 RID: 2393
	public class BestiaryPortraitBackgroundProviderPreferenceInfoElement : IPreferenceProviderElement, IBestiaryInfoElement
	{
		// Token: 0x060047E4 RID: 18404 RVA: 0x0025F7B0 File Offset: 0x0025D9B0
		public BestiaryPortraitBackgroundProviderPreferenceInfoElement(IBestiaryBackgroundImagePathAndColorProvider preferredProvider)
		{
			this._preferredProvider = preferredProvider;
		}

		// Token: 0x060047E5 RID: 18405 RVA: 0x0025F7CC File Offset: 0x0025D9CC
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
		}

		// Token: 0x060047E6 RID: 18406 RVA: 0x0025F7DC File Offset: 0x0025D9DC
		public bool Matches(IBestiaryBackgroundImagePathAndColorProvider provider)
		{
			/*
An exception occurred when decompiling this method (060047E6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Bestiary.BestiaryPortraitBackgroundProviderPreferenceInfoElement::Matches(Terraria.GameContent.Bestiary.IBestiaryBackgroundImagePathAndColorProvider)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:IBestiaryBackgroundImagePathAndColorProvider(var_0_06, ldfld:IBestiaryBackgroundImagePathAndColorProvider(BestiaryPortraitBackgroundProviderPreferenceInfoElement::_preferredProvider, ldloc:BestiaryPortraitBackgroundProviderPreferenceInfoElement(this)))
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

		// Token: 0x060047E7 RID: 18407 RVA: 0x0025F7F0 File Offset: 0x0025D9F0
		public IBestiaryBackgroundImagePathAndColorProvider GetPreferredProvider()
		{
			return this._preferredProvider;
		}

		// Token: 0x04008393 RID: 33683
		private IBestiaryBackgroundImagePathAndColorProvider _preferredProvider;
	}
}
