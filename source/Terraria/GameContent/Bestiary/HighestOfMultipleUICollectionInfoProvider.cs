using System;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000951 RID: 2385
	public class HighestOfMultipleUICollectionInfoProvider : IBestiaryUICollectionInfoProvider
	{
		// Token: 0x060047C0 RID: 18368 RVA: 0x0025F3BC File Offset: 0x0025D5BC
		public HighestOfMultipleUICollectionInfoProvider(params IBestiaryUICollectionInfoProvider[] providers)
		{
			this._providers = providers;
		}

		// Token: 0x060047C1 RID: 18369 RVA: 0x0025F3D8 File Offset: 0x0025D5D8
		public BestiaryUICollectionInfo GetEntryUICollectionInfo()
		{
			/*
An exception occurred when decompiling this method (060047C1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.GameContent.Bestiary.BestiaryUICollectionInfo Terraria.GameContent.Bestiary.HighestOfMultipleUICollectionInfoProvider::GetEntryUICollectionInfo()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class Terraria.GameContent.Bestiary.IBestiaryUICollectionInfoProvider[](var_0_06, ldfld:class Terraria.GameContent.Bestiary.IBestiaryUICollectionInfoProvider[](HighestOfMultipleUICollectionInfoProvider::_providers, ldloc:HighestOfMultipleUICollectionInfoProvider(this)))
	stloc:class Terraria.GameContent.Bestiary.IBestiaryUICollectionInfoProvider[](var_1_0D, ldfld:class Terraria.GameContent.Bestiary.IBestiaryUICollectionInfoProvider[](HighestOfMultipleUICollectionInfoProvider::_providers, ldloc:HighestOfMultipleUICollectionInfoProvider(this)))
	stloc:class Terraria.GameContent.Bestiary.IBestiaryUICollectionInfoProvider[](var_3_16, ldfld:class Terraria.GameContent.Bestiary.IBestiaryUICollectionInfoProvider[](HighestOfMultipleUICollectionInfoProvider::_providers, ldloc:HighestOfMultipleUICollectionInfoProvider(this)))
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

		// Token: 0x060047C2 RID: 18370 RVA: 0x0025F3FC File Offset: 0x0025D5FC
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
		}

		// Token: 0x04008386 RID: 33670
		private IBestiaryUICollectionInfoProvider[] _providers;

		// Token: 0x04008387 RID: 33671
		private int _mainProviderIndex;
	}
}
