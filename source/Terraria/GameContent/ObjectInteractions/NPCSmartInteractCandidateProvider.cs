using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Terraria.GameContent.ObjectInteractions
{
	// Token: 0x0200084C RID: 2124
	public class NPCSmartInteractCandidateProvider : ISmartInteractCandidateProvider
	{
		// Token: 0x0600432A RID: 17194 RVA: 0x0024DA5C File Offset: 0x0024BC5C
		public void ClearSelfAndPrepareForCheck()
		{
			if (!true)
			{
			}
			Main.SmartInteractNPC = int.MinValue;
		}

		// Token: 0x0600432B RID: 17195 RVA: 0x0024DA78 File Offset: 0x0024BC78
		public bool ProvideCandidate(SmartInteractScanSettings settings, [Out] ISmartInteractCandidate candidate)
		{
			/*
An exception occurred when decompiling this method (0600432B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.ObjectInteractions.NPCSmartInteractCandidateProvider::ProvideCandidate(Terraria.GameContent.ObjectInteractions.SmartInteractScanSettings,Terraria.GameContent.ObjectInteractions.ISmartInteractCandidate)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0068:
	stloc:bool(var_23_6E, ldfld:bool(SmartInteractScanSettings::DemandOnlyZeroDistanceTargets, ldloc:SmartInteractScanSettings[exp:valuetype Terraria.GameContent.ObjectInteractions.SmartInteractScanSettings&](settings)))
	stloc:ReusableCandidate(var_24_76, ldfld:ReusableCandidate(NPCSmartInteractCandidateProvider::_candidate, ldloc:NPCSmartInteractCandidateProvider(this)))
	stfld:int32(ReusableCandidate::_npcIndexToTarget, ldloc:ReusableCandidate(var_24_76), ldloc:float32[exp:int32](var_21))
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

		// Token: 0x0600432C RID: 17196 RVA: 0x0024DB0C File Offset: 0x0024BD0C
		public NPCSmartInteractCandidateProvider()
		{
		}

		// Token: 0x04008158 RID: 33112
		private NPCSmartInteractCandidateProvider.ReusableCandidate _candidate;

		// Token: 0x0200084D RID: 2125
		private class ReusableCandidate : ISmartInteractCandidate
		{
			// Token: 0x170007C8 RID: 1992
			// (get) Token: 0x0600432D RID: 17197 RVA: 0x0024DB20 File Offset: 0x0024BD20
			// (set) Token: 0x0600432E RID: 17198 RVA: 0x0024DB34 File Offset: 0x0024BD34
			public float DistanceFromCursor
			{
				[CompilerGenerated]
				get
				{
					/*
An exception occurred when decompiling this method (0600432D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.GameContent.ObjectInteractions.NPCSmartInteractCandidateProvider/ReusableCandidate::get_DistanceFromCursor()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(ReusableCandidate::<DistanceFromCursor>k__BackingField, ldloc:ReusableCandidate(this)))
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
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0600432F RID: 17199 RVA: 0x0024DB44 File Offset: 0x0024BD44
			public void WinCandidacy()
			{
				int npcIndexToTarget = this._npcIndexToTarget;
				if (!true)
				{
				}
				Main.SmartInteractNPC = npcIndexToTarget;
				Main.SmartInteractShowingGenuine = true;
			}

			// Token: 0x06004330 RID: 17200 RVA: 0x0024DB68 File Offset: 0x0024BD68
			public void Reuse(int npcIndex, float npcDistanceFromCursor)
			{
				this._npcIndexToTarget = npcIndex;
			}

			// Token: 0x06004331 RID: 17201 RVA: 0x0024DB7C File Offset: 0x0024BD7C
			public ReusableCandidate()
			{
			}

			// Token: 0x04008159 RID: 33113
			[CompilerGenerated]
			private float <DistanceFromCursor>k__BackingField;

			// Token: 0x0400815A RID: 33114
			private int _npcIndexToTarget;
		}
	}
}
