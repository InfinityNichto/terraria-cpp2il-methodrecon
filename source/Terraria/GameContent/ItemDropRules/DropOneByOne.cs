using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x02000885 RID: 2181
	public class DropOneByOne : IItemDropRule
	{
		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x0600442B RID: 17451 RVA: 0x0024F504 File Offset: 0x0024D704
		// (set) Token: 0x0600442C RID: 17452 RVA: 0x0024F518 File Offset: 0x0024D718
		public List<IItemDropRuleChainAttempt> ChainedRules
		{
			[CompilerGenerated]
			get
			{
				return this.<ChainedRules>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<ChainedRules>k__BackingField = value;
			}
		}

		// Token: 0x0600442D RID: 17453 RVA: 0x0024F52C File Offset: 0x0024D72C
		public DropOneByOne(int itemId, DropOneByOne.Parameters parameters)
		{
			int chanceNumerator = parameters.ChanceNumerator;
			int chanceDenominator = parameters.ChanceDenominator;
			this.itemId = itemId;
		}

		// Token: 0x0600442E RID: 17454 RVA: 0x0024F554 File Offset: 0x0024D754
		public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
		{
			/*
An exception occurred when decompiling this method (0600442E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.GameContent.ItemDropRules.ItemDropAttemptResult Terraria.GameContent.ItemDropRules.DropOneByOne::TryDroppingItem(Terraria.GameContent.ItemDropRules.DropAttemptInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Player(var_1_08, ldfld:Player(DropAttemptInfo::player, ldloc:DropAttemptInfo[exp:valuetype Terraria.GameContent.ItemDropRules.DropAttemptInfo&](info)))
	stloc:int32(var_2_14, ldfld:int32(Parameters::ChanceDenominator, ldfld:Parameters[exp:valuetype Terraria.GameContent.ItemDropRules.DropOneByOne/Parameters&](DropOneByOne::parameters, ldloc:DropOneByOne(this))))
	stloc:int32(var_3_1C, call:int32(Player::RollLuck, ldloc:Player(var_1_08), ldloc:int32(var_2_14)))
	stloc:int32(var_4_28, ldfld:int32(Parameters::MinimumItemDropsCount, ldfld:Parameters[exp:valuetype Terraria.GameContent.ItemDropRules.DropOneByOne/Parameters&](DropOneByOne::parameters, ldloc:DropOneByOne(this))))
	stloc:int32(var_5_35, ldfld:int32(Parameters::MinimumStackPerChunkBase, ldfld:Parameters[exp:valuetype Terraria.GameContent.ItemDropRules.DropOneByOne/Parameters&](DropOneByOne::parameters, ldloc:DropOneByOne(this))))
	stloc:UnifiedRandom(var_6_3D, ldfld:UnifiedRandom(DropAttemptInfo::rng, ldloc:DropAttemptInfo[exp:valuetype Terraria.GameContent.ItemDropRules.DropAttemptInfo&](info)))
	stloc:int32(var_8_4A, ldfld:int32(Parameters::BonusMinDropsPerChunkPerPlayer, ldfld:Parameters[exp:valuetype Terraria.GameContent.ItemDropRules.DropOneByOne/Parameters&](DropOneByOne::parameters, ldloc:DropOneByOne(this))))
	stloc:int32(var_9_57, ldfld:int32(Parameters::MinimumStackPerChunkBase, ldfld:Parameters[exp:valuetype Terraria.GameContent.ItemDropRules.DropOneByOne/Parameters&](DropOneByOne::parameters, ldloc:DropOneByOne(this))))
	stloc:int32(var_10_64, ldfld:int32(Parameters::BonusMinDropsPerChunkPerPlayer, ldfld:Parameters[exp:valuetype Terraria.GameContent.ItemDropRules.DropOneByOne/Parameters&](DropOneByOne::parameters, ldloc:DropOneByOne(this))))
	stloc:UnifiedRandom(var_11_6C, ldfld:UnifiedRandom(DropAttemptInfo::rng, ldloc:DropAttemptInfo[exp:valuetype Terraria.GameContent.ItemDropRules.DropAttemptInfo&](info)))
	stloc:int32(var_12_74, ldfld:int32(DropOneByOne::itemId, ldloc:DropOneByOne(this)))
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

		// Token: 0x0600442F RID: 17455 RVA: 0x000021DB File Offset: 0x000003DB
		public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004430 RID: 17456 RVA: 0x0024F5DC File Offset: 0x0024D7DC
		public bool CanDrop(DropAttemptInfo info)
		{
			return true;
		}

		// Token: 0x040081D6 RID: 33238
		public int itemId;

		// Token: 0x040081D7 RID: 33239
		public DropOneByOne.Parameters parameters;

		// Token: 0x040081D8 RID: 33240
		[CompilerGenerated]
		private List<IItemDropRuleChainAttempt> <ChainedRules>k__BackingField;

		// Token: 0x02000886 RID: 2182
		public struct Parameters
		{
			// Token: 0x06004431 RID: 17457 RVA: 0x0024F5EC File Offset: 0x0024D7EC
			public float GetPersonalDropRate()
			{
				/*
An exception occurred when decompiling this method (06004431)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.GameContent.ItemDropRules.DropOneByOne/Parameters::GetPersonalDropRate()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Parameters::ChanceNumerator, ldloc:valuetype Terraria.GameContent.ItemDropRules.DropOneByOne/Parameters&(this)))
	stloc:int32(var_1_0D, ldfld:int32(Parameters::ChanceDenominator, ldloc:valuetype Terraria.GameContent.ItemDropRules.DropOneByOne/Parameters&(this)))
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

			// Token: 0x040081D9 RID: 33241
			public int ChanceNumerator;

			// Token: 0x040081DA RID: 33242
			public int ChanceDenominator;

			// Token: 0x040081DB RID: 33243
			public int MinimumItemDropsCount;

			// Token: 0x040081DC RID: 33244
			public int MaximumItemDropsCount;

			// Token: 0x040081DD RID: 33245
			public int MinimumStackPerChunkBase;

			// Token: 0x040081DE RID: 33246
			public int MaximumStackPerChunkBase;

			// Token: 0x040081DF RID: 33247
			public int BonusMinDropsPerChunkPerPlayer;

			// Token: 0x040081E0 RID: 33248
			public int BonusMaxDropsPerChunkPerPlayer;
		}
	}
}
