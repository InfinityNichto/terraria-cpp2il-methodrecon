using System;
using Cpp2IlInjected;
using Terraria.Localization;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x0200088F RID: 2191
	public class Conditions
	{
		// Token: 0x0600445E RID: 17502 RVA: 0x0024FAA4 File Offset: 0x0024DCA4
		public static bool SoulOfWhateverConditionCanDrop(DropAttemptInfo info)
		{
			int num = 1;
			int num2 = 28673;
			if (num != 0)
			{
				while (num2 != 0)
				{
				}
			}
			if (num2 == 0)
			{
				return;
			}
		}

		// Token: 0x0600445F RID: 17503 RVA: 0x0024FAC8 File Offset: 0x0024DCC8
		public Conditions()
		{
		}

		// Token: 0x02000890 RID: 2192
		public class NeverTrue : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004460 RID: 17504 RVA: 0x0024FADC File Offset: 0x0024DCDC
			public bool CanDrop(DropAttemptInfo info)
			{
			}

			// Token: 0x06004461 RID: 17505 RVA: 0x0024FAEC File Offset: 0x0024DCEC
			public bool CanShowItemDropInUI()
			{
				return true;
			}

			// Token: 0x06004462 RID: 17506 RVA: 0x0024FAFC File Offset: 0x0024DCFC
			public string GetConditionDescription()
			{
			}

			// Token: 0x06004463 RID: 17507 RVA: 0x0024FB0C File Offset: 0x0024DD0C
			public NeverTrue()
			{
			}
		}

		// Token: 0x02000891 RID: 2193
		public class IsUsingSpecificAIValues : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004464 RID: 17508 RVA: 0x0024FB20 File Offset: 0x0024DD20
			public IsUsingSpecificAIValues(int aislot, float valueToMatch)
			{
				this.aiSlotToCheck = aislot;
			}

			// Token: 0x06004465 RID: 17509 RVA: 0x0024FB3C File Offset: 0x0024DD3C
			public bool CanDrop(DropAttemptInfo info)
			{
				/*
An exception occurred when decompiling this method (06004465)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.ItemDropRules.Conditions/IsUsingSpecificAIValues::CanDrop(Terraria.GameContent.ItemDropRules.DropAttemptInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(IsUsingSpecificAIValues::valueToMatch, ldloc:IsUsingSpecificAIValues(this)))
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

			// Token: 0x06004466 RID: 17510 RVA: 0x0024FB50 File Offset: 0x0024DD50
			public bool CanShowItemDropInUI()
			{
				return true;
			}

			// Token: 0x06004467 RID: 17511 RVA: 0x000021DB File Offset: 0x000003DB
			public string GetConditionDescription()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x040081F6 RID: 33270
			public int aiSlotToCheck;

			// Token: 0x040081F7 RID: 33271
			public float valueToMatch;
		}

		// Token: 0x02000892 RID: 2194
		public class FrostMoonDropGatingChance : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004468 RID: 17512 RVA: 0x0024FB60 File Offset: 0x0024DD60
			public bool CanDrop(DropAttemptInfo info)
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num != 0)
				{
					bool expertMode = Main.expertMode;
					bool expertMode2 = Main.expertMode;
					Player player = info.player;
					return;
				}
			}

			// Token: 0x06004469 RID: 17513 RVA: 0x0024FB90 File Offset: 0x0024DD90
			public bool CanShowItemDropInUI()
			{
				return true;
			}

			// Token: 0x0600446A RID: 17514 RVA: 0x0024FBA0 File Offset: 0x0024DDA0
			public string GetConditionDescription()
			{
				return Language.GetTextValue("Bestiary_ItemDropConditions.WaveBasedDrop");
			}

			// Token: 0x0600446B RID: 17515 RVA: 0x0024FBB8 File Offset: 0x0024DDB8
			public FrostMoonDropGatingChance()
			{
			}
		}

		// Token: 0x02000893 RID: 2195
		public class PumpkinMoonDropGatingChance : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x0600446C RID: 17516 RVA: 0x0024FBCC File Offset: 0x0024DDCC
			public bool CanDrop(DropAttemptInfo info)
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num != 0)
				{
					bool expertMode = Main.expertMode;
					bool expertMode2 = Main.expertMode;
					Player player = info.player;
					return;
				}
			}

			// Token: 0x0600446D RID: 17517 RVA: 0x0024FBFC File Offset: 0x0024DDFC
			public bool CanShowItemDropInUI()
			{
				return true;
			}

			// Token: 0x0600446E RID: 17518 RVA: 0x0024FC0C File Offset: 0x0024DE0C
			public string GetConditionDescription()
			{
				return Language.GetTextValue("Bestiary_ItemDropConditions.WaveBasedDrop");
			}

			// Token: 0x0600446F RID: 17519 RVA: 0x0024FC24 File Offset: 0x0024DE24
			public PumpkinMoonDropGatingChance()
			{
			}
		}

		// Token: 0x02000894 RID: 2196
		public class FrostMoonDropGateForTrophies : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004470 RID: 17520 RVA: 0x0024FC38 File Offset: 0x0024DE38
			public bool CanDrop(DropAttemptInfo info)
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num != 0)
				{
					if (num == 0)
					{
					}
					bool expertMode = Main.expertMode;
					if (num == 0)
					{
					}
					int num2 = info.rng.Next(int.MinValue);
					return;
				}
			}

			// Token: 0x06004471 RID: 17521 RVA: 0x0024FC74 File Offset: 0x0024DE74
			public bool CanShowItemDropInUI()
			{
				return true;
			}

			// Token: 0x06004472 RID: 17522 RVA: 0x0024FC84 File Offset: 0x0024DE84
			public string GetConditionDescription()
			{
			}

			// Token: 0x06004473 RID: 17523 RVA: 0x0024FC94 File Offset: 0x0024DE94
			public FrostMoonDropGateForTrophies()
			{
			}
		}

		// Token: 0x02000895 RID: 2197
		public class PumpkinMoonDropGateForTrophies : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004474 RID: 17524 RVA: 0x0024FCA8 File Offset: 0x0024DEA8
			public bool CanDrop(DropAttemptInfo info)
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num != 0)
				{
					if (num == 0)
					{
					}
					bool expertMode = Main.expertMode;
					if (num == 0)
					{
					}
					int num2 = info.rng.Next(int.MinValue);
					return;
				}
			}

			// Token: 0x06004475 RID: 17525 RVA: 0x0024FCE0 File Offset: 0x0024DEE0
			public bool CanShowItemDropInUI()
			{
				return true;
			}

			// Token: 0x06004476 RID: 17526 RVA: 0x0024FCF0 File Offset: 0x0024DEF0
			public string GetConditionDescription()
			{
			}

			// Token: 0x06004477 RID: 17527 RVA: 0x0024FD00 File Offset: 0x0024DF00
			public PumpkinMoonDropGateForTrophies()
			{
			}
		}

		// Token: 0x02000896 RID: 2198
		public class IsPumpkinMoon : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004478 RID: 17528 RVA: 0x0024FD14 File Offset: 0x0024DF14
			public bool CanDrop(DropAttemptInfo info)
			{
				/*
An exception occurred when decompiling this method (06004478)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.ItemDropRules.Conditions/IsPumpkinMoon::CanDrop(Terraria.GameContent.ItemDropRules.DropAttemptInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}

			// Token: 0x06004479 RID: 17529 RVA: 0x0024FD24 File Offset: 0x0024DF24
			public bool CanShowItemDropInUI()
			{
				return true;
			}

			// Token: 0x0600447A RID: 17530 RVA: 0x0024FD34 File Offset: 0x0024DF34
			public string GetConditionDescription()
			{
			}

			// Token: 0x0600447B RID: 17531 RVA: 0x0024FD44 File Offset: 0x0024DF44
			public IsPumpkinMoon()
			{
			}
		}

		// Token: 0x02000897 RID: 2199
		public class FromCertainWaveAndAbove : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x0600447C RID: 17532 RVA: 0x0024FD58 File Offset: 0x0024DF58
			public FromCertainWaveAndAbove(int neededWave)
			{
				this.neededWave = neededWave;
			}

			// Token: 0x0600447D RID: 17533 RVA: 0x0024FD74 File Offset: 0x0024DF74
			public bool CanDrop(DropAttemptInfo info)
			{
				/*
An exception occurred when decompiling this method (0600447D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.ItemDropRules.Conditions/FromCertainWaveAndAbove::CanDrop(Terraria.GameContent.ItemDropRules.DropAttemptInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_0_09, ldfld:int32(FromCertainWaveAndAbove::neededWave, ldloc:FromCertainWaveAndAbove(this)))
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

			// Token: 0x0600447E RID: 17534 RVA: 0x0024FD8C File Offset: 0x0024DF8C
			public bool CanShowItemDropInUI()
			{
				return true;
			}

			// Token: 0x0600447F RID: 17535 RVA: 0x0024FD9C File Offset: 0x0024DF9C
			public string GetConditionDescription()
			{
				int num = this.neededWave;
				string text;
				return text;
			}

			// Token: 0x040081F8 RID: 33272
			public int neededWave;
		}

		// Token: 0x02000898 RID: 2200
		public class IsBloodMoonAndNotFromStatue : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004480 RID: 17536 RVA: 0x0024FDB4 File Offset: 0x0024DFB4
			public bool CanDrop(DropAttemptInfo info)
			{
				/*
An exception occurred when decompiling this method (06004480)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.ItemDropRules.Conditions/IsBloodMoonAndNotFromStatue::CanDrop(Terraria.GameContent.ItemDropRules.DropAttemptInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:bool(var_1_0B, ldfld:bool(DropAttemptInfo::IsInSimulation, ldloc:DropAttemptInfo[exp:valuetype Terraria.GameContent.ItemDropRules.DropAttemptInfo&](info)))
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

			// Token: 0x06004481 RID: 17537 RVA: 0x0024FDCC File Offset: 0x0024DFCC
			public bool CanShowItemDropInUI()
			{
				return true;
			}

			// Token: 0x06004482 RID: 17538 RVA: 0x0024FDDC File Offset: 0x0024DFDC
			public string GetConditionDescription()
			{
			}

			// Token: 0x06004483 RID: 17539 RVA: 0x0024FDEC File Offset: 0x0024DFEC
			public IsBloodMoonAndNotFromStatue()
			{
			}
		}

		// Token: 0x02000899 RID: 2201
		public class DownedAllMechBosses : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004484 RID: 17540 RVA: 0x0024FE00 File Offset: 0x0024E000
			public bool CanDrop(DropAttemptInfo info)
			{
				if (!true)
				{
					return;
				}
			}

			// Token: 0x06004485 RID: 17541 RVA: 0x0024FE14 File Offset: 0x0024E014
			public bool CanShowItemDropInUI()
			{
				return true;
			}

			// Token: 0x06004486 RID: 17542 RVA: 0x0024FE24 File Offset: 0x0024E024
			public string GetConditionDescription()
			{
			}

			// Token: 0x06004487 RID: 17543 RVA: 0x0024FE34 File Offset: 0x0024E034
			public DownedAllMechBosses()
			{
			}
		}

		// Token: 0x0200089A RID: 2202
		public class DownedPlantera : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004488 RID: 17544 RVA: 0x0024FE48 File Offset: 0x0024E048
			public bool CanDrop(DropAttemptInfo info)
			{
				/*
An exception occurred when decompiling this method (06004488)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.ItemDropRules.Conditions/DownedPlantera::CanDrop(Terraria.GameContent.ItemDropRules.DropAttemptInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}

			// Token: 0x06004489 RID: 17545 RVA: 0x0024FE58 File Offset: 0x0024E058
			public bool CanShowItemDropInUI()
			{
				return true;
			}

			// Token: 0x0600448A RID: 17546 RVA: 0x0024FE68 File Offset: 0x0024E068
			public string GetConditionDescription()
			{
			}

			// Token: 0x0600448B RID: 17547 RVA: 0x0024FE78 File Offset: 0x0024E078
			public DownedPlantera()
			{
			}
		}

		// Token: 0x0200089B RID: 2203
		public class IsHardmode : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x0600448C RID: 17548 RVA: 0x0024FE8C File Offset: 0x0024E08C
			public bool CanDrop(DropAttemptInfo info)
			{
				/*
An exception occurred when decompiling this method (0600448C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.ItemDropRules.Conditions/IsHardmode::CanDrop(Terraria.GameContent.ItemDropRules.DropAttemptInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}

			// Token: 0x0600448D RID: 17549 RVA: 0x0024FE9C File Offset: 0x0024E09C
			public bool CanShowItemDropInUI()
			{
				return true;
			}

			// Token: 0x0600448E RID: 17550 RVA: 0x0024FEAC File Offset: 0x0024E0AC
			public string GetConditionDescription()
			{
			}

			// Token: 0x0600448F RID: 17551 RVA: 0x0024FEBC File Offset: 0x0024E0BC
			public IsHardmode()
			{
			}
		}

		// Token: 0x0200089C RID: 2204
		public class FirstTimeKillingPlantera : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004490 RID: 17552 RVA: 0x0024FED0 File Offset: 0x0024E0D0
			public bool CanDrop(DropAttemptInfo info)
			{
				/*
An exception occurred when decompiling this method (06004490)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.ItemDropRules.Conditions/FirstTimeKillingPlantera::CanDrop(Terraria.GameContent.ItemDropRules.DropAttemptInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}

			// Token: 0x06004491 RID: 17553 RVA: 0x0024FEE0 File Offset: 0x0024E0E0
			public bool CanShowItemDropInUI()
			{
				return true;
			}

			// Token: 0x06004492 RID: 17554 RVA: 0x0024FEF0 File Offset: 0x0024E0F0
			public string GetConditionDescription()
			{
			}

			// Token: 0x06004493 RID: 17555 RVA: 0x0024FF00 File Offset: 0x0024E100
			public FirstTimeKillingPlantera()
			{
			}
		}

		// Token: 0x0200089D RID: 2205
		public class MechanicalBossesDummyCondition : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004494 RID: 17556 RVA: 0x0024FF14 File Offset: 0x0024E114
			public bool CanDrop(DropAttemptInfo info)
			{
				return true;
			}

			// Token: 0x06004495 RID: 17557 RVA: 0x0024FF24 File Offset: 0x0024E124
			public bool CanShowItemDropInUI()
			{
				return true;
			}

			// Token: 0x06004496 RID: 17558 RVA: 0x0024FF34 File Offset: 0x0024E134
			public string GetConditionDescription()
			{
			}

			// Token: 0x06004497 RID: 17559 RVA: 0x0024FF44 File Offset: 0x0024E144
			public MechanicalBossesDummyCondition()
			{
			}
		}

		// Token: 0x0200089E RID: 2206
		public class PirateMap : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004498 RID: 17560 RVA: 0x0024FF58 File Offset: 0x0024E158
			public bool CanDrop(DropAttemptInfo info)
			{
				/*
An exception occurred when decompiling this method (06004498)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.ItemDropRules.Conditions/PirateMap::CanDrop(Terraria.GameContent.ItemDropRules.DropAttemptInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0007:
	stloc:bool(var_2_0D, ldfld:bool(DropAttemptInfo::IsInSimulation, ldloc:DropAttemptInfo[exp:valuetype Terraria.GameContent.ItemDropRules.DropAttemptInfo&](info)))
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

			// Token: 0x06004499 RID: 17561 RVA: 0x0024FF74 File Offset: 0x0024E174
			public bool CanShowItemDropInUI()
			{
				return true;
			}

			// Token: 0x0600449A RID: 17562 RVA: 0x0024FF84 File Offset: 0x0024E184
			public string GetConditionDescription()
			{
				return Language.GetTextValue("Bestiary_ItemDropConditions.PirateMap");
			}

			// Token: 0x0600449B RID: 17563 RVA: 0x0024FF9C File Offset: 0x0024E19C
			public PirateMap()
			{
			}
		}

		// Token: 0x0200089F RID: 2207
		public class IsChristmas : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x0600449C RID: 17564 RVA: 0x0024FFB0 File Offset: 0x0024E1B0
			public bool CanDrop(DropAttemptInfo info)
			{
				/*
An exception occurred when decompiling this method (0600449C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.ItemDropRules.Conditions/IsChristmas::CanDrop(Terraria.GameContent.ItemDropRules.DropAttemptInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}

			// Token: 0x0600449D RID: 17565 RVA: 0x0024FFC0 File Offset: 0x0024E1C0
			public bool CanShowItemDropInUI()
			{
				return true;
			}

			// Token: 0x0600449E RID: 17566 RVA: 0x0024FFD0 File Offset: 0x0024E1D0
			public string GetConditionDescription()
			{
				return Language.GetTextValue("Bestiary_ItemDropConditions.IsChristmas");
			}

			// Token: 0x0600449F RID: 17567 RVA: 0x0024FFE8 File Offset: 0x0024E1E8
			public IsChristmas()
			{
			}
		}

		// Token: 0x020008A0 RID: 2208
		public class NotExpert : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x060044A0 RID: 17568 RVA: 0x0024FFFC File Offset: 0x0024E1FC
			public bool CanDrop(DropAttemptInfo info)
			{
				if (!true)
				{
				}
				return Main.expertMode;
			}

			// Token: 0x060044A1 RID: 17569 RVA: 0x00250014 File Offset: 0x0024E214
			public bool CanShowItemDropInUI()
			{
				if (!true)
				{
				}
				return Main.expertMode;
			}

			// Token: 0x060044A2 RID: 17570 RVA: 0x0025002C File Offset: 0x0024E22C
			public string GetConditionDescription()
			{
				return Language.GetTextValue("Bestiary_ItemDropConditions.NotExpert");
			}

			// Token: 0x060044A3 RID: 17571 RVA: 0x00250044 File Offset: 0x0024E244
			public NotExpert()
			{
			}
		}

		// Token: 0x020008A1 RID: 2209
		public class NotMasterMode : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x060044A4 RID: 17572 RVA: 0x00250058 File Offset: 0x0024E258
			public bool CanDrop(DropAttemptInfo info)
			{
				if (!true)
				{
				}
				return Main.masterMode;
			}

			// Token: 0x060044A5 RID: 17573 RVA: 0x00250070 File Offset: 0x0024E270
			public bool CanShowItemDropInUI()
			{
				if (!true)
				{
				}
				return Main.masterMode;
			}

			// Token: 0x060044A6 RID: 17574 RVA: 0x00250088 File Offset: 0x0024E288
			public string GetConditionDescription()
			{
				return Language.GetTextValue("Bestiary_ItemDropConditions.NotMasterMode");
			}

			// Token: 0x060044A7 RID: 17575 RVA: 0x002500A0 File Offset: 0x0024E2A0
			public NotMasterMode()
			{
			}
		}

		// Token: 0x020008A2 RID: 2210
		public class MissingTwin : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x060044A8 RID: 17576 RVA: 0x002500B4 File Offset: 0x0024E2B4
			public bool CanDrop(DropAttemptInfo info)
			{
				bool flag;
				return flag;
			}

			// Token: 0x060044A9 RID: 17577 RVA: 0x002500C4 File Offset: 0x0024E2C4
			public bool CanShowItemDropInUI()
			{
				return true;
			}

			// Token: 0x060044AA RID: 17578 RVA: 0x002500D4 File Offset: 0x0024E2D4
			public string GetConditionDescription()
			{
			}

			// Token: 0x060044AB RID: 17579 RVA: 0x002500E4 File Offset: 0x0024E2E4
			public MissingTwin()
			{
			}
		}

		// Token: 0x020008A3 RID: 2211
		public class EmpressOfLightIsGenuinelyEnraged : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x060044AC RID: 17580 RVA: 0x002500F8 File Offset: 0x0024E2F8
			public bool CanDrop(DropAttemptInfo info)
			{
				bool flag;
				return flag;
			}

			// Token: 0x060044AD RID: 17581 RVA: 0x00250108 File Offset: 0x0024E308
			public bool CanShowItemDropInUI()
			{
				return true;
			}

			// Token: 0x060044AE RID: 17582 RVA: 0x00250118 File Offset: 0x0024E318
			public string GetConditionDescription()
			{
				return Language.GetTextValue("Bestiary_ItemDropConditions.EmpressOfLightOnlyTookDamageWhileEnraged");
			}

			// Token: 0x060044AF RID: 17583 RVA: 0x00250130 File Offset: 0x0024E330
			public EmpressOfLightIsGenuinelyEnraged()
			{
			}
		}

		// Token: 0x020008A4 RID: 2212
		public class PlayerNeedsHealing : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x060044B0 RID: 17584 RVA: 0x00250144 File Offset: 0x0024E344
			public bool CanDrop(DropAttemptInfo info)
			{
				/*
An exception occurred when decompiling this method (060044B0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.ItemDropRules.Conditions/PlayerNeedsHealing::CanDrop(Terraria.GameContent.ItemDropRules.DropAttemptInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Player(var_0_06, ldfld:Player(DropAttemptInfo::player, ldloc:DropAttemptInfo[exp:valuetype Terraria.GameContent.ItemDropRules.DropAttemptInfo&](info)))
	stloc:int32(var_1_0D, ldfld:int32(Player::statLife, ldloc:Player(var_0_06)))
	stloc:int32(var_2_14, ldfld:int32(Player::statLifeMax2, ldloc:Player(var_0_06)))
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

			// Token: 0x060044B1 RID: 17585 RVA: 0x00250168 File Offset: 0x0024E368
			public bool CanShowItemDropInUI()
			{
				return true;
			}

			// Token: 0x060044B2 RID: 17586 RVA: 0x00250178 File Offset: 0x0024E378
			public string GetConditionDescription()
			{
				return Language.GetTextValue("Bestiary_ItemDropConditions.PlayerNeedsHealing");
			}

			// Token: 0x060044B3 RID: 17587 RVA: 0x00250190 File Offset: 0x0024E390
			public PlayerNeedsHealing()
			{
			}
		}

		// Token: 0x020008A5 RID: 2213
		public class MechdusaKill : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x060044B4 RID: 17588 RVA: 0x002501A4 File Offset: 0x0024E3A4
			public bool CanDrop(DropAttemptInfo info)
			{
				if (!true)
				{
				}
				return NPC.AnyNPCs(int.MinValue);
			}

			// Token: 0x060044B5 RID: 17589 RVA: 0x002501C4 File Offset: 0x0024E3C4
			public bool CanShowItemDropInUI()
			{
				if (!true)
				{
					return;
				}
			}

			// Token: 0x060044B6 RID: 17590 RVA: 0x002501D8 File Offset: 0x0024E3D8
			public string GetConditionDescription()
			{
			}

			// Token: 0x060044B7 RID: 17591 RVA: 0x002501E8 File Offset: 0x0024E3E8
			public MechdusaKill()
			{
			}

			// Token: 0x060044B8 RID: 17592 RVA: 0x002501FC File Offset: 0x0024E3FC
			// Note: this type is marked as 'beforefieldinit'.
			static MechdusaKill()
			{
			}

			// Token: 0x040081F9 RID: 33273
			private static int[] _targetList;
		}

		// Token: 0x020008A6 RID: 2214
		public class LegacyHack_IsBossAndExpert : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x060044B9 RID: 17593 RVA: 0x0025020C File Offset: 0x0024E40C
			public bool CanDrop(DropAttemptInfo info)
			{
				return Main.expertMode;
			}

			// Token: 0x060044BA RID: 17594 RVA: 0x00250224 File Offset: 0x0024E424
			public bool CanShowItemDropInUI()
			{
				if (!true)
				{
				}
				return Main.expertMode;
			}

			// Token: 0x060044BB RID: 17595 RVA: 0x0025023C File Offset: 0x0024E43C
			public string GetConditionDescription()
			{
				return Language.GetTextValue("Bestiary_ItemDropConditions.LegacyHack_IsBossAndExpert");
			}

			// Token: 0x060044BC RID: 17596 RVA: 0x00250254 File Offset: 0x0024E454
			public LegacyHack_IsBossAndExpert()
			{
			}
		}

		// Token: 0x020008A7 RID: 2215
		public class LegacyHack_IsBossAndNotExpert : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x060044BD RID: 17597 RVA: 0x00250268 File Offset: 0x0024E468
			public bool CanDrop(DropAttemptInfo info)
			{
				return Main.expertMode;
			}

			// Token: 0x060044BE RID: 17598 RVA: 0x0025027C File Offset: 0x0024E47C
			public bool CanShowItemDropInUI()
			{
				if (!true)
				{
				}
				return Main.expertMode;
			}

			// Token: 0x060044BF RID: 17599 RVA: 0x00250294 File Offset: 0x0024E494
			public string GetConditionDescription()
			{
				return Language.GetTextValue("Bestiary_ItemDropConditions.LegacyHack_IsBossAndNotExpert");
			}

			// Token: 0x060044C0 RID: 17600 RVA: 0x002502AC File Offset: 0x0024E4AC
			public LegacyHack_IsBossAndNotExpert()
			{
			}
		}

		// Token: 0x020008A8 RID: 2216
		public class LegacyHack_IsABoss : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x060044C1 RID: 17601 RVA: 0x000021DB File Offset: 0x000003DB
			public bool CanDrop(DropAttemptInfo info)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x060044C2 RID: 17602 RVA: 0x002502C0 File Offset: 0x0024E4C0
			public bool CanShowItemDropInUI()
			{
				return true;
			}

			// Token: 0x060044C3 RID: 17603 RVA: 0x002502D0 File Offset: 0x0024E4D0
			public string GetConditionDescription()
			{
			}

			// Token: 0x060044C4 RID: 17604 RVA: 0x002502E0 File Offset: 0x0024E4E0
			public LegacyHack_IsABoss()
			{
			}
		}

		// Token: 0x020008A9 RID: 2217
		public class IsExpert : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x060044C5 RID: 17605 RVA: 0x002502F4 File Offset: 0x0024E4F4
			public bool CanDrop(DropAttemptInfo info)
			{
				if (!true)
				{
				}
				return Main.expertMode;
			}

			// Token: 0x060044C6 RID: 17606 RVA: 0x0025030C File Offset: 0x0024E50C
			public bool CanShowItemDropInUI()
			{
				if (!true)
				{
				}
				return Main.expertMode;
			}

			// Token: 0x060044C7 RID: 17607 RVA: 0x00250324 File Offset: 0x0024E524
			public string GetConditionDescription()
			{
				if (!true)
				{
				}
				bool masterMode = Main.masterMode;
				string text;
				return text;
			}

			// Token: 0x060044C8 RID: 17608 RVA: 0x00250340 File Offset: 0x0024E540
			public IsExpert()
			{
			}
		}

		// Token: 0x020008AA RID: 2218
		public class IsMasterMode : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x060044C9 RID: 17609 RVA: 0x00250354 File Offset: 0x0024E554
			public bool CanDrop(DropAttemptInfo info)
			{
				if (!true)
				{
				}
				return Main.masterMode;
			}

			// Token: 0x060044CA RID: 17610 RVA: 0x0025036C File Offset: 0x0024E56C
			public bool CanShowItemDropInUI()
			{
				if (!true)
				{
				}
				return Main.masterMode;
			}

			// Token: 0x060044CB RID: 17611 RVA: 0x00250384 File Offset: 0x0024E584
			public string GetConditionDescription()
			{
				return Language.GetTextValue("Bestiary_ItemDropConditions.IsMasterMode");
			}

			// Token: 0x060044CC RID: 17612 RVA: 0x0025039C File Offset: 0x0024E59C
			public IsMasterMode()
			{
			}
		}

		// Token: 0x020008AB RID: 2219
		public class IsCrimson : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x060044CD RID: 17613 RVA: 0x002503B0 File Offset: 0x0024E5B0
			public bool CanDrop(DropAttemptInfo info)
			{
				/*
An exception occurred when decompiling this method (060044CD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.ItemDropRules.Conditions/IsCrimson::CanDrop(Terraria.GameContent.ItemDropRules.DropAttemptInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}

			// Token: 0x060044CE RID: 17614 RVA: 0x002503C0 File Offset: 0x0024E5C0
			public bool CanShowItemDropInUI()
			{
				/*
An exception occurred when decompiling this method (060044CE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.ItemDropRules.Conditions/IsCrimson::CanShowItemDropInUI()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}

			// Token: 0x060044CF RID: 17615 RVA: 0x002503D0 File Offset: 0x0024E5D0
			public string GetConditionDescription()
			{
				return Language.GetTextValue("Bestiary_ItemDropConditions.IsCrimson");
			}

			// Token: 0x060044D0 RID: 17616 RVA: 0x002503E8 File Offset: 0x0024E5E8
			public IsCrimson()
			{
			}
		}

		// Token: 0x020008AC RID: 2220
		public class IsCorruption : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x060044D1 RID: 17617 RVA: 0x002503FC File Offset: 0x0024E5FC
			public bool CanDrop(DropAttemptInfo info)
			{
				/*
An exception occurred when decompiling this method (060044D1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.ItemDropRules.Conditions/IsCorruption::CanDrop(Terraria.GameContent.ItemDropRules.DropAttemptInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}

			// Token: 0x060044D2 RID: 17618 RVA: 0x0025040C File Offset: 0x0024E60C
			public bool CanShowItemDropInUI()
			{
				/*
An exception occurred when decompiling this method (060044D2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.ItemDropRules.Conditions/IsCorruption::CanShowItemDropInUI()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}

			// Token: 0x060044D3 RID: 17619 RVA: 0x0025041C File Offset: 0x0024E61C
			public string GetConditionDescription()
			{
				return Language.GetTextValue("Bestiary_ItemDropConditions.IsCorruption");
			}

			// Token: 0x060044D4 RID: 17620 RVA: 0x00250434 File Offset: 0x0024E634
			public IsCorruption()
			{
			}
		}

		// Token: 0x020008AD RID: 2221
		public class IsCrimsonAndNotExpert : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x060044D5 RID: 17621 RVA: 0x00250448 File Offset: 0x0024E648
			public bool CanDrop(DropAttemptInfo info)
			{
				do
				{
					if (!true)
					{
					}
				}
				while (!true);
				return Main.expertMode;
			}

			// Token: 0x060044D6 RID: 17622 RVA: 0x00250464 File Offset: 0x0024E664
			public bool CanShowItemDropInUI()
			{
				do
				{
					if (!true)
					{
					}
				}
				while (!true);
				return Main.expertMode;
			}

			// Token: 0x060044D7 RID: 17623 RVA: 0x00250480 File Offset: 0x0024E680
			public string GetConditionDescription()
			{
				return Language.GetTextValue("Bestiary_ItemDropConditions.IsCrimsonAndNotExpert");
			}

			// Token: 0x060044D8 RID: 17624 RVA: 0x00250498 File Offset: 0x0024E698
			public IsCrimsonAndNotExpert()
			{
			}
		}

		// Token: 0x020008AE RID: 2222
		public class IsCorruptionAndNotExpert : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x060044D9 RID: 17625 RVA: 0x002504AC File Offset: 0x0024E6AC
			public bool CanDrop(DropAttemptInfo info)
			{
				if (!true)
				{
				}
				if (true)
				{
				}
				return Main.expertMode;
			}

			// Token: 0x060044DA RID: 17626 RVA: 0x002504C4 File Offset: 0x0024E6C4
			public bool CanShowItemDropInUI()
			{
				if (!true)
				{
				}
				if (true)
				{
				}
				return Main.expertMode;
			}

			// Token: 0x060044DB RID: 17627 RVA: 0x002504E0 File Offset: 0x0024E6E0
			public string GetConditionDescription()
			{
				return Language.GetTextValue("Bestiary_ItemDropConditions.IsCorruptionAndNotExpert");
			}

			// Token: 0x060044DC RID: 17628 RVA: 0x002504F8 File Offset: 0x0024E6F8
			public IsCorruptionAndNotExpert()
			{
			}
		}

		// Token: 0x020008AF RID: 2223
		public class HalloweenWeapons : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x060044DD RID: 17629 RVA: 0x0025050C File Offset: 0x0024E70C
			public bool CanDrop(DropAttemptInfo info)
			{
				if (!true)
				{
				}
				if (true)
				{
				}
				if (true)
				{
				}
				if (!true)
				{
				}
				if (true)
				{
					bool isInSimulation = info.IsInSimulation;
					return;
				}
			}

			// Token: 0x060044DE RID: 17630 RVA: 0x00250534 File Offset: 0x0024E734
			public bool CanShowItemDropInUI()
			{
				return true;
			}

			// Token: 0x060044DF RID: 17631 RVA: 0x00250544 File Offset: 0x0024E744
			public string GetConditionDescription()
			{
				return Language.GetTextValue("Bestiary_ItemDropConditions.HalloweenWeapons");
			}

			// Token: 0x060044E0 RID: 17632 RVA: 0x0025055C File Offset: 0x0024E75C
			public HalloweenWeapons()
			{
			}
		}

		// Token: 0x020008B0 RID: 2224
		public class SoulOfNight : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x060044E1 RID: 17633 RVA: 0x00250570 File Offset: 0x0024E770
			public bool CanDrop(DropAttemptInfo info)
			{
				NPC npc = info.npc;
				bool zoneCorrupt = info.player.ZoneCorrupt;
				return true;
			}

			// Token: 0x060044E2 RID: 17634 RVA: 0x002505A0 File Offset: 0x0024E7A0
			public bool CanShowItemDropInUI()
			{
				return true;
			}

			// Token: 0x060044E3 RID: 17635 RVA: 0x002505B0 File Offset: 0x0024E7B0
			public string GetConditionDescription()
			{
				return Language.GetTextValue("Bestiary_ItemDropConditions.SoulOfNight");
			}

			// Token: 0x060044E4 RID: 17636 RVA: 0x002505C8 File Offset: 0x0024E7C8
			public SoulOfNight()
			{
			}
		}

		// Token: 0x020008B1 RID: 2225
		public class SoulOfLight : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x060044E5 RID: 17637 RVA: 0x002505DC File Offset: 0x0024E7DC
			public bool CanDrop(DropAttemptInfo info)
			{
				NPC npc = info.npc;
				return info.player.ZoneHallow;
			}

			// Token: 0x060044E6 RID: 17638 RVA: 0x00250600 File Offset: 0x0024E800
			public bool CanShowItemDropInUI()
			{
				return true;
			}

			// Token: 0x060044E7 RID: 17639 RVA: 0x00250610 File Offset: 0x0024E810
			public string GetConditionDescription()
			{
				return Language.GetTextValue("Bestiary_ItemDropConditions.SoulOfLight");
			}

			// Token: 0x060044E8 RID: 17640 RVA: 0x00250628 File Offset: 0x0024E828
			public SoulOfLight()
			{
			}
		}

		// Token: 0x020008B2 RID: 2226
		public class NotFromStatue : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x060044E9 RID: 17641 RVA: 0x000021DB File Offset: 0x000003DB
			public bool CanDrop(DropAttemptInfo info)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x060044EA RID: 17642 RVA: 0x0025063C File Offset: 0x0024E83C
			public bool CanShowItemDropInUI()
			{
				return true;
			}

			// Token: 0x060044EB RID: 17643 RVA: 0x0025064C File Offset: 0x0024E84C
			public string GetConditionDescription()
			{
				return Language.GetTextValue("Bestiary_ItemDropConditions.NotFromStatue");
			}

			// Token: 0x060044EC RID: 17644 RVA: 0x00250664 File Offset: 0x0024E864
			public NotFromStatue()
			{
			}
		}

		// Token: 0x020008B3 RID: 2227
		public class HalloweenGoodieBagDrop : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x060044ED RID: 17645 RVA: 0x00250678 File Offset: 0x0024E878
			public bool CanDrop(DropAttemptInfo info)
			{
				/*
An exception occurred when decompiling this method (060044ED)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.ItemDropRules.Conditions/HalloweenGoodieBagDrop::CanDrop(Terraria.GameContent.ItemDropRules.DropAttemptInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0006:
	stloc:bool(var_2_10, ldfld:bool(DropAttemptInfo::IsInSimulation, ldloc:DropAttemptInfo[exp:valuetype Terraria.GameContent.ItemDropRules.DropAttemptInfo&](info)))
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

			// Token: 0x060044EE RID: 17646 RVA: 0x00250698 File Offset: 0x0024E898
			public bool CanShowItemDropInUI()
			{
				return true;
			}

			// Token: 0x060044EF RID: 17647 RVA: 0x002506A8 File Offset: 0x0024E8A8
			public string GetConditionDescription()
			{
				return Language.GetTextValue("Bestiary_ItemDropConditions.HalloweenGoodieBagDrop");
			}

			// Token: 0x060044F0 RID: 17648 RVA: 0x002506C0 File Offset: 0x0024E8C0
			public HalloweenGoodieBagDrop()
			{
			}
		}

		// Token: 0x020008B4 RID: 2228
		public class XmasPresentDrop : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x060044F1 RID: 17649 RVA: 0x002506D4 File Offset: 0x0024E8D4
			public bool CanDrop(DropAttemptInfo info)
			{
				/*
An exception occurred when decompiling this method (060044F1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.ItemDropRules.Conditions/XmasPresentDrop::CanDrop(Terraria.GameContent.ItemDropRules.DropAttemptInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0006:
	stloc:bool(var_2_10, ldfld:bool(DropAttemptInfo::IsInSimulation, ldloc:DropAttemptInfo[exp:valuetype Terraria.GameContent.ItemDropRules.DropAttemptInfo&](info)))
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

			// Token: 0x060044F2 RID: 17650 RVA: 0x002506F4 File Offset: 0x0024E8F4
			public bool CanShowItemDropInUI()
			{
				return true;
			}

			// Token: 0x060044F3 RID: 17651 RVA: 0x00250704 File Offset: 0x0024E904
			public string GetConditionDescription()
			{
				return Language.GetTextValue("Bestiary_ItemDropConditions.XmasPresentDrop");
			}

			// Token: 0x060044F4 RID: 17652 RVA: 0x0025071C File Offset: 0x0024E91C
			public XmasPresentDrop()
			{
			}
		}

		// Token: 0x020008B5 RID: 2229
		public class LivingFlames : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x060044F5 RID: 17653 RVA: 0x00250730 File Offset: 0x0024E930
			public bool CanDrop(DropAttemptInfo info)
			{
				/*
An exception occurred when decompiling this method (060044F5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.ItemDropRules.Conditions/LivingFlames::CanDrop(Terraria.GameContent.ItemDropRules.DropAttemptInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_2_09, callgetter:int32(Main::get_UnderworldLayer))
	stloc:bool(var_3_10, ldfld:bool(DropAttemptInfo::IsInSimulation, ldloc:DropAttemptInfo[exp:valuetype Terraria.GameContent.ItemDropRules.DropAttemptInfo&](info)))
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

			// Token: 0x060044F6 RID: 17654 RVA: 0x00250750 File Offset: 0x0024E950
			public bool CanShowItemDropInUI()
			{
				return true;
			}

			// Token: 0x060044F7 RID: 17655 RVA: 0x00250760 File Offset: 0x0024E960
			public string GetConditionDescription()
			{
				return Language.GetTextValue("Bestiary_ItemDropConditions.LivingFlames");
			}

			// Token: 0x060044F8 RID: 17656 RVA: 0x00250778 File Offset: 0x0024E978
			public LivingFlames()
			{
			}
		}

		// Token: 0x020008B6 RID: 2230
		public class NamedNPC : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x060044F9 RID: 17657 RVA: 0x0025078C File Offset: 0x0024E98C
			public NamedNPC(string neededName)
			{
				this.neededName = neededName;
			}

			// Token: 0x060044FA RID: 17658 RVA: 0x002507A8 File Offset: 0x0024E9A8
			public bool CanDrop(DropAttemptInfo info)
			{
				string text = this.neededName;
				string text2;
				return text2 == text;
			}

			// Token: 0x060044FB RID: 17659 RVA: 0x002507C4 File Offset: 0x0024E9C4
			public bool CanShowItemDropInUI()
			{
				return true;
			}

			// Token: 0x060044FC RID: 17660 RVA: 0x002507D4 File Offset: 0x0024E9D4
			public string GetConditionDescription()
			{
				return Language.GetTextValue("Bestiary_ItemDropConditions.NamedNPC");
			}

			// Token: 0x040081FA RID: 33274
			public string neededName;
		}

		// Token: 0x020008B7 RID: 2231
		public class HallowKeyCondition : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x060044FD RID: 17661 RVA: 0x002507EC File Offset: 0x0024E9EC
			public bool CanDrop(DropAttemptInfo info)
			{
				bool isInSimulation = info.IsInSimulation;
				return info.player.ZoneHallow;
			}

			// Token: 0x060044FE RID: 17662 RVA: 0x00250810 File Offset: 0x0024EA10
			public bool CanShowItemDropInUI()
			{
				return true;
			}

			// Token: 0x060044FF RID: 17663 RVA: 0x00250820 File Offset: 0x0024EA20
			public string GetConditionDescription()
			{
				return Language.GetTextValue("Bestiary_ItemDropConditions.HallowKeyCondition");
			}

			// Token: 0x06004500 RID: 17664 RVA: 0x00250838 File Offset: 0x0024EA38
			public HallowKeyCondition()
			{
			}
		}

		// Token: 0x020008B8 RID: 2232
		public class JungleKeyCondition : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004501 RID: 17665 RVA: 0x0025084C File Offset: 0x0024EA4C
			public bool CanDrop(DropAttemptInfo info)
			{
				bool isInSimulation = info.IsInSimulation;
				return info.player.ZoneJungle;
			}

			// Token: 0x06004502 RID: 17666 RVA: 0x00250870 File Offset: 0x0024EA70
			public bool CanShowItemDropInUI()
			{
				return true;
			}

			// Token: 0x06004503 RID: 17667 RVA: 0x00250880 File Offset: 0x0024EA80
			public string GetConditionDescription()
			{
				return Language.GetTextValue("Bestiary_ItemDropConditions.JungleKeyCondition");
			}

			// Token: 0x06004504 RID: 17668 RVA: 0x00250898 File Offset: 0x0024EA98
			public JungleKeyCondition()
			{
			}
		}

		// Token: 0x020008B9 RID: 2233
		public class CorruptKeyCondition : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004505 RID: 17669 RVA: 0x002508AC File Offset: 0x0024EAAC
			public bool CanDrop(DropAttemptInfo info)
			{
				bool isInSimulation = info.IsInSimulation;
				return info.player.ZoneCorrupt;
			}

			// Token: 0x06004506 RID: 17670 RVA: 0x002508D0 File Offset: 0x0024EAD0
			public bool CanShowItemDropInUI()
			{
				return true;
			}

			// Token: 0x06004507 RID: 17671 RVA: 0x002508E0 File Offset: 0x0024EAE0
			public string GetConditionDescription()
			{
				return Language.GetTextValue("Bestiary_ItemDropConditions.CorruptKeyCondition");
			}

			// Token: 0x06004508 RID: 17672 RVA: 0x002508F8 File Offset: 0x0024EAF8
			public CorruptKeyCondition()
			{
			}
		}

		// Token: 0x020008BA RID: 2234
		public class CrimsonKeyCondition : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004509 RID: 17673 RVA: 0x0025090C File Offset: 0x0024EB0C
			public bool CanDrop(DropAttemptInfo info)
			{
				bool isInSimulation = info.IsInSimulation;
				return info.player.ZoneCrimson;
			}

			// Token: 0x0600450A RID: 17674 RVA: 0x00250930 File Offset: 0x0024EB30
			public bool CanShowItemDropInUI()
			{
				return true;
			}

			// Token: 0x0600450B RID: 17675 RVA: 0x00250940 File Offset: 0x0024EB40
			public string GetConditionDescription()
			{
				return Language.GetTextValue("Bestiary_ItemDropConditions.CrimsonKeyCondition");
			}

			// Token: 0x0600450C RID: 17676 RVA: 0x00250958 File Offset: 0x0024EB58
			public CrimsonKeyCondition()
			{
			}
		}

		// Token: 0x020008BB RID: 2235
		public class FrozenKeyCondition : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x0600450D RID: 17677 RVA: 0x0025096C File Offset: 0x0024EB6C
			public bool CanDrop(DropAttemptInfo info)
			{
				bool isInSimulation = info.IsInSimulation;
				return info.player.ZoneSnow;
			}

			// Token: 0x0600450E RID: 17678 RVA: 0x00250990 File Offset: 0x0024EB90
			public bool CanShowItemDropInUI()
			{
				return true;
			}

			// Token: 0x0600450F RID: 17679 RVA: 0x002509A0 File Offset: 0x0024EBA0
			public string GetConditionDescription()
			{
				return Language.GetTextValue("Bestiary_ItemDropConditions.FrozenKeyCondition");
			}

			// Token: 0x06004510 RID: 17680 RVA: 0x002509B8 File Offset: 0x0024EBB8
			public FrozenKeyCondition()
			{
			}
		}

		// Token: 0x020008BC RID: 2236
		public class DesertKeyCondition : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004511 RID: 17681 RVA: 0x002509CC File Offset: 0x0024EBCC
			public bool CanDrop(DropAttemptInfo info)
			{
				bool isInSimulation = info.IsInSimulation;
				bool zoneDesert = info.player.ZoneDesert;
				return info.player.ZoneBeach;
			}

			// Token: 0x06004512 RID: 17682 RVA: 0x002509FC File Offset: 0x0024EBFC
			public bool CanShowItemDropInUI()
			{
				return true;
			}

			// Token: 0x06004513 RID: 17683 RVA: 0x00250A0C File Offset: 0x0024EC0C
			public string GetConditionDescription()
			{
				return Language.GetTextValue("Bestiary_ItemDropConditions.DesertKeyCondition");
			}

			// Token: 0x06004514 RID: 17684 RVA: 0x00250A24 File Offset: 0x0024EC24
			public DesertKeyCondition()
			{
			}
		}

		// Token: 0x020008BD RID: 2237
		public class BeatAnyMechBoss : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004515 RID: 17685 RVA: 0x00250A38 File Offset: 0x0024EC38
			public bool CanDrop(DropAttemptInfo info)
			{
				/*
An exception occurred when decompiling this method (06004515)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.ItemDropRules.Conditions/BeatAnyMechBoss::CanDrop(Terraria.GameContent.ItemDropRules.DropAttemptInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}

			// Token: 0x06004516 RID: 17686 RVA: 0x00250A48 File Offset: 0x0024EC48
			public bool CanShowItemDropInUI()
			{
				return true;
			}

			// Token: 0x06004517 RID: 17687 RVA: 0x00250A58 File Offset: 0x0024EC58
			public string GetConditionDescription()
			{
				return Language.GetTextValue("Bestiary_ItemDropConditions.BeatAnyMechBoss");
			}

			// Token: 0x06004518 RID: 17688 RVA: 0x00250A70 File Offset: 0x0024EC70
			public BeatAnyMechBoss()
			{
			}
		}

		// Token: 0x020008BE RID: 2238
		public class YoyoCascade : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004519 RID: 17689 RVA: 0x00250A84 File Offset: 0x0024EC84
			public bool CanDrop(DropAttemptInfo info)
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num == 0)
				{
					bool isInSimulation = info.IsInSimulation;
					return;
				}
			}

			// Token: 0x0600451A RID: 17690 RVA: 0x00250AA4 File Offset: 0x0024ECA4
			public bool CanShowItemDropInUI()
			{
				return true;
			}

			// Token: 0x0600451B RID: 17691 RVA: 0x00250AB4 File Offset: 0x0024ECB4
			public string GetConditionDescription()
			{
				return Language.GetTextValue("Bestiary_ItemDropConditions.YoyoCascade");
			}

			// Token: 0x0600451C RID: 17692 RVA: 0x00250ACC File Offset: 0x0024ECCC
			public YoyoCascade()
			{
			}
		}

		// Token: 0x020008BF RID: 2239
		public class YoyosAmarok : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x0600451D RID: 17693 RVA: 0x00250AE0 File Offset: 0x0024ECE0
			public bool CanDrop(DropAttemptInfo info)
			{
				if (!true)
				{
				}
				if (true)
				{
					bool zoneSnow = info.player.ZoneSnow;
					bool isInSimulation = info.IsInSimulation;
					return zoneSnow;
				}
			}

			// Token: 0x0600451E RID: 17694 RVA: 0x00250B0C File Offset: 0x0024ED0C
			public bool CanShowItemDropInUI()
			{
				return true;
			}

			// Token: 0x0600451F RID: 17695 RVA: 0x00250B1C File Offset: 0x0024ED1C
			public string GetConditionDescription()
			{
				return Language.GetTextValue("Bestiary_ItemDropConditions.YoyosAmarok");
			}

			// Token: 0x06004520 RID: 17696 RVA: 0x00250B34 File Offset: 0x0024ED34
			public YoyosAmarok()
			{
			}
		}

		// Token: 0x020008C0 RID: 2240
		public class YoyosYelets : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004521 RID: 17697 RVA: 0x00250B48 File Offset: 0x0024ED48
			public bool CanDrop(DropAttemptInfo info)
			{
				if (!true)
				{
				}
				if (!true)
				{
					return;
				}
				bool zoneJungle = info.player.ZoneJungle;
				if (!true)
				{
				}
				if (true)
				{
					bool flag;
					return flag;
				}
			}

			// Token: 0x06004522 RID: 17698 RVA: 0x00250B70 File Offset: 0x0024ED70
			public bool CanShowItemDropInUI()
			{
				return true;
			}

			// Token: 0x06004523 RID: 17699 RVA: 0x00250B80 File Offset: 0x0024ED80
			public string GetConditionDescription()
			{
				return Language.GetTextValue("Bestiary_ItemDropConditions.YoyosYelets");
			}

			// Token: 0x06004524 RID: 17700 RVA: 0x00250B98 File Offset: 0x0024ED98
			public YoyosYelets()
			{
			}
		}

		// Token: 0x020008C1 RID: 2241
		public class YoyosKraken : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004525 RID: 17701 RVA: 0x00250BAC File Offset: 0x0024EDAC
			public bool CanDrop(DropAttemptInfo info)
			{
				if (!true)
				{
				}
				if (!true)
				{
					return;
				}
				bool zoneDungeon = info.player.ZoneDungeon;
				if (!true)
				{
				}
				if (true)
				{
					bool isInSimulation = info.IsInSimulation;
					bool flag;
					return flag;
				}
			}

			// Token: 0x06004526 RID: 17702 RVA: 0x00250BDC File Offset: 0x0024EDDC
			public bool CanShowItemDropInUI()
			{
				return true;
			}

			// Token: 0x06004527 RID: 17703 RVA: 0x00250BEC File Offset: 0x0024EDEC
			public string GetConditionDescription()
			{
				return Language.GetTextValue("Bestiary_ItemDropConditions.YoyosKraken");
			}

			// Token: 0x06004528 RID: 17704 RVA: 0x00250C04 File Offset: 0x0024EE04
			public YoyosKraken()
			{
			}
		}

		// Token: 0x020008C2 RID: 2242
		public class YoyosHelFire : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004529 RID: 17705 RVA: 0x00250C18 File Offset: 0x0024EE18
			public bool CanDrop(DropAttemptInfo info)
			{
				if (!true)
				{
				}
				if (!true)
				{
					return;
				}
				bool zoneDungeon = info.player.ZoneDungeon;
				if (15744 == 0)
				{
					bool isInSimulation = info.IsInSimulation;
					bool flag;
					return flag;
				}
			}

			// Token: 0x0600452A RID: 17706 RVA: 0x00250C48 File Offset: 0x0024EE48
			public bool CanShowItemDropInUI()
			{
				return true;
			}

			// Token: 0x0600452B RID: 17707 RVA: 0x00250C58 File Offset: 0x0024EE58
			public string GetConditionDescription()
			{
				return Language.GetTextValue("Bestiary_ItemDropConditions.YoyosHelFire");
			}

			// Token: 0x0600452C RID: 17708 RVA: 0x00250C70 File Offset: 0x0024EE70
			public YoyosHelFire()
			{
			}
		}

		// Token: 0x020008C3 RID: 2243
		public class WindyEnoughForKiteDrops : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x0600452D RID: 17709 RVA: 0x00250C84 File Offset: 0x0024EE84
			public bool CanDrop(DropAttemptInfo info)
			{
				if (!true)
				{
				}
				return Main.WindyEnoughForKiteDrops;
			}

			// Token: 0x0600452E RID: 17710 RVA: 0x00250C9C File Offset: 0x0024EE9C
			public bool CanShowItemDropInUI()
			{
				return true;
			}

			// Token: 0x0600452F RID: 17711 RVA: 0x00250CAC File Offset: 0x0024EEAC
			public string GetConditionDescription()
			{
				return Language.GetTextValue("Bestiary_ItemDropConditions.IsItAHappyWindyDay");
			}

			// Token: 0x06004530 RID: 17712 RVA: 0x00250CC4 File Offset: 0x0024EEC4
			public WindyEnoughForKiteDrops()
			{
			}
		}

		// Token: 0x020008C4 RID: 2244
		public class RemixSeedEasymode : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004531 RID: 17713 RVA: 0x00250CD8 File Offset: 0x0024EED8
			public bool CanDrop(DropAttemptInfo info)
			{
				if (!true)
				{
					return;
				}
			}

			// Token: 0x06004532 RID: 17714 RVA: 0x00250CEC File Offset: 0x0024EEEC
			public bool CanShowItemDropInUI()
			{
				if (!true)
				{
					return;
				}
			}

			// Token: 0x06004533 RID: 17715 RVA: 0x00250D00 File Offset: 0x0024EF00
			public string GetConditionDescription()
			{
			}

			// Token: 0x06004534 RID: 17716 RVA: 0x00250D10 File Offset: 0x0024EF10
			public RemixSeedEasymode()
			{
			}
		}

		// Token: 0x020008C5 RID: 2245
		public class RemixSeedHardmode : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004535 RID: 17717 RVA: 0x00250D24 File Offset: 0x0024EF24
			public bool CanDrop(DropAttemptInfo info)
			{
				if (!true)
				{
					return;
				}
			}

			// Token: 0x06004536 RID: 17718 RVA: 0x00250D38 File Offset: 0x0024EF38
			public bool CanShowItemDropInUI()
			{
				if (!true)
				{
					return;
				}
			}

			// Token: 0x06004537 RID: 17719 RVA: 0x00250D4C File Offset: 0x0024EF4C
			public string GetConditionDescription()
			{
			}

			// Token: 0x06004538 RID: 17720 RVA: 0x00250D5C File Offset: 0x0024EF5C
			public RemixSeedHardmode()
			{
			}
		}

		// Token: 0x020008C6 RID: 2246
		public class RemixSeed : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004539 RID: 17721 RVA: 0x00250D70 File Offset: 0x0024EF70
			public bool CanDrop(DropAttemptInfo info)
			{
				/*
An exception occurred when decompiling this method (06004539)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.ItemDropRules.Conditions/RemixSeed::CanDrop(Terraria.GameContent.ItemDropRules.DropAttemptInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}

			// Token: 0x0600453A RID: 17722 RVA: 0x00250D80 File Offset: 0x0024EF80
			public bool CanShowItemDropInUI()
			{
				/*
An exception occurred when decompiling this method (0600453A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.ItemDropRules.Conditions/RemixSeed::CanShowItemDropInUI()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}

			// Token: 0x0600453B RID: 17723 RVA: 0x00250D90 File Offset: 0x0024EF90
			public string GetConditionDescription()
			{
			}

			// Token: 0x0600453C RID: 17724 RVA: 0x00250DA0 File Offset: 0x0024EFA0
			public RemixSeed()
			{
			}
		}

		// Token: 0x020008C7 RID: 2247
		public class NotRemixSeed : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x0600453D RID: 17725 RVA: 0x00250DB4 File Offset: 0x0024EFB4
			public bool CanDrop(DropAttemptInfo info)
			{
				/*
An exception occurred when decompiling this method (0600453D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.ItemDropRules.Conditions/NotRemixSeed::CanDrop(Terraria.GameContent.ItemDropRules.DropAttemptInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}

			// Token: 0x0600453E RID: 17726 RVA: 0x00250DC4 File Offset: 0x0024EFC4
			public bool CanShowItemDropInUI()
			{
				/*
An exception occurred when decompiling this method (0600453E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.ItemDropRules.Conditions/NotRemixSeed::CanShowItemDropInUI()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}

			// Token: 0x0600453F RID: 17727 RVA: 0x00250DD4 File Offset: 0x0024EFD4
			public string GetConditionDescription()
			{
			}

			// Token: 0x06004540 RID: 17728 RVA: 0x00250DE4 File Offset: 0x0024EFE4
			public NotRemixSeed()
			{
			}
		}

		// Token: 0x020008C8 RID: 2248
		public class TenthAnniversaryIsUp : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004541 RID: 17729 RVA: 0x00250DF8 File Offset: 0x0024EFF8
			public bool CanDrop(DropAttemptInfo info)
			{
				/*
An exception occurred when decompiling this method (06004541)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.ItemDropRules.Conditions/TenthAnniversaryIsUp::CanDrop(Terraria.GameContent.ItemDropRules.DropAttemptInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}

			// Token: 0x06004542 RID: 17730 RVA: 0x00250E08 File Offset: 0x0024F008
			public bool CanShowItemDropInUI()
			{
				/*
An exception occurred when decompiling this method (06004542)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.ItemDropRules.Conditions/TenthAnniversaryIsUp::CanShowItemDropInUI()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}

			// Token: 0x06004543 RID: 17731 RVA: 0x00250E18 File Offset: 0x0024F018
			public string GetConditionDescription()
			{
			}

			// Token: 0x06004544 RID: 17732 RVA: 0x00250E28 File Offset: 0x0024F028
			public TenthAnniversaryIsUp()
			{
			}
		}

		// Token: 0x020008C9 RID: 2249
		public class TenthAnniversaryIsNotUp : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004545 RID: 17733 RVA: 0x00250E3C File Offset: 0x0024F03C
			public bool CanDrop(DropAttemptInfo info)
			{
				/*
An exception occurred when decompiling this method (06004545)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.ItemDropRules.Conditions/TenthAnniversaryIsNotUp::CanDrop(Terraria.GameContent.ItemDropRules.DropAttemptInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}

			// Token: 0x06004546 RID: 17734 RVA: 0x00250E4C File Offset: 0x0024F04C
			public bool CanShowItemDropInUI()
			{
				/*
An exception occurred when decompiling this method (06004546)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.ItemDropRules.Conditions/TenthAnniversaryIsNotUp::CanShowItemDropInUI()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}

			// Token: 0x06004547 RID: 17735 RVA: 0x00250E5C File Offset: 0x0024F05C
			public string GetConditionDescription()
			{
			}

			// Token: 0x06004548 RID: 17736 RVA: 0x00250E6C File Offset: 0x0024F06C
			public TenthAnniversaryIsNotUp()
			{
			}
		}

		// Token: 0x020008CA RID: 2250
		public class DontStarveIsUp : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004549 RID: 17737 RVA: 0x00250E80 File Offset: 0x0024F080
			public bool CanDrop(DropAttemptInfo info)
			{
				/*
An exception occurred when decompiling this method (06004549)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.ItemDropRules.Conditions/DontStarveIsUp::CanDrop(Terraria.GameContent.ItemDropRules.DropAttemptInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}

			// Token: 0x0600454A RID: 17738 RVA: 0x000021DB File Offset: 0x000003DB
			public bool CanShowItemDropInUI()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x0600454B RID: 17739 RVA: 0x00250E90 File Offset: 0x0024F090
			public string GetConditionDescription()
			{
			}

			// Token: 0x0600454C RID: 17740 RVA: 0x00250EA0 File Offset: 0x0024F0A0
			public DontStarveIsUp()
			{
			}
		}

		// Token: 0x020008CB RID: 2251
		public class DontStarveIsNotUp : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x0600454D RID: 17741 RVA: 0x00250EB4 File Offset: 0x0024F0B4
			public bool CanDrop(DropAttemptInfo info)
			{
				/*
An exception occurred when decompiling this method (0600454D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.ItemDropRules.Conditions/DontStarveIsNotUp::CanDrop(Terraria.GameContent.ItemDropRules.DropAttemptInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}

			// Token: 0x0600454E RID: 17742 RVA: 0x00250EC4 File Offset: 0x0024F0C4
			public bool CanShowItemDropInUI()
			{
				/*
An exception occurred when decompiling this method (0600454E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.ItemDropRules.Conditions/DontStarveIsNotUp::CanShowItemDropInUI()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}

			// Token: 0x0600454F RID: 17743 RVA: 0x00250ED4 File Offset: 0x0024F0D4
			public string GetConditionDescription()
			{
			}

			// Token: 0x06004550 RID: 17744 RVA: 0x00250EE4 File Offset: 0x0024F0E4
			public DontStarveIsNotUp()
			{
			}
		}
	}
}
