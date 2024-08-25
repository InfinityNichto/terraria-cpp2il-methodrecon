using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x0200082C RID: 2092
	public class BiomePreferenceListTrait : IShopPersonalityTrait, IEnumerable<BiomePreferenceListTrait.BiomePreference>, IEnumerable
	{
		// Token: 0x060042DF RID: 17119 RVA: 0x0024CCB0 File Offset: 0x0024AEB0
		public BiomePreferenceListTrait()
		{
		}

		// Token: 0x060042E0 RID: 17120 RVA: 0x000021DB File Offset: 0x000003DB
		public void Add(BiomePreferenceListTrait.BiomePreference preference)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060042E1 RID: 17121 RVA: 0x000021DB File Offset: 0x000003DB
		public void Add(AffectionLevel level, AShoppingBiome biome)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060042E2 RID: 17122 RVA: 0x000021DB File Offset: 0x000003DB
		public void ModifyShopPrice(HelperInfo info, ShopHelper shopHelperInstance)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060042E3 RID: 17123 RVA: 0x0024CCC4 File Offset: 0x0024AEC4
		private void ApplyPreference(BiomePreferenceListTrait.BiomePreference preference, HelperInfo info, ShopHelper shopHelperInstance)
		{
			AShoppingBiome biome = preference.Biome;
			AffectionLevel affection = preference.Affection;
			string <NameKey>k__BackingField = biome.<NameKey>k__BackingField;
			shopHelperInstance.LoveBiome(<NameKey>k__BackingField);
		}

		// Token: 0x060042E4 RID: 17124 RVA: 0x0024CD08 File Offset: 0x0024AF08
		public IEnumerator<BiomePreferenceListTrait.BiomePreference> GetEnumerator()
		{
			/*
An exception occurred when decompiling this method (060042E4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IEnumerator`1<Terraria.GameContent.Personalities.BiomePreferenceListTrait/BiomePreference> Terraria.GameContent.Personalities.BiomePreferenceListTrait::GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.List`1<class Terraria.GameContent.Personalities.BiomePreferenceListTrait/BiomePreference>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.List`1<class Terraria.GameContent.Personalities.BiomePreferenceListTrait/BiomePreference>(BiomePreferenceListTrait::_preferences, ldloc:BiomePreferenceListTrait(this)))
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

		// Token: 0x060042E5 RID: 17125 RVA: 0x0024CD1C File Offset: 0x0024AF1C
		IEnumerator IEnumerable.GetEnumerator()
		{
			/*
An exception occurred when decompiling this method (060042E5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.IEnumerator Terraria.GameContent.Personalities.BiomePreferenceListTrait::System.Collections.IEnumerable.GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.List`1<class Terraria.GameContent.Personalities.BiomePreferenceListTrait/BiomePreference>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.List`1<class Terraria.GameContent.Personalities.BiomePreferenceListTrait/BiomePreference>(BiomePreferenceListTrait::_preferences, ldloc:BiomePreferenceListTrait(this)))
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

		// Token: 0x0400812C RID: 33068
		private List<BiomePreferenceListTrait.BiomePreference> _preferences;

		// Token: 0x0200082D RID: 2093
		public class BiomePreference
		{
			// Token: 0x060042E6 RID: 17126 RVA: 0x0024CD30 File Offset: 0x0024AF30
			public BiomePreference(AffectionLevel affection, AShoppingBiome biome)
			{
				this.Affection = affection;
				this.Biome = biome;
			}

			// Token: 0x0400812D RID: 33069
			public AffectionLevel Affection;

			// Token: 0x0400812E RID: 33070
			public AShoppingBiome Biome;
		}
	}
}
