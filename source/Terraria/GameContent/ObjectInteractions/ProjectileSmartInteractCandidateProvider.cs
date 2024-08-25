using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Terraria.GameContent.ObjectInteractions
{
	// Token: 0x0200084E RID: 2126
	public class ProjectileSmartInteractCandidateProvider : ISmartInteractCandidateProvider
	{
		// Token: 0x06004332 RID: 17202 RVA: 0x0024DB90 File Offset: 0x0024BD90
		public void ClearSelfAndPrepareForCheck()
		{
			if (!true)
			{
			}
			Main.SmartInteractProj = int.MinValue;
		}

		// Token: 0x06004333 RID: 17203 RVA: 0x0024DBAC File Offset: 0x0024BDAC
		public bool ProvideCandidate(SmartInteractScanSettings settings, [Out] ISmartInteractCandidate candidate)
		{
			/*
An exception occurred when decompiling this method (06004333)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.ObjectInteractions.ProjectileSmartInteractCandidateProvider::ProvideCandidate(Terraria.GameContent.ObjectInteractions.SmartInteractScanSettings,Terraria.GameContent.ObjectInteractions.ISmartInteractCandidate)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_06, ldfld:bool(SmartInteractScanSettings::FullInteraction, ldloc:SmartInteractScanSettings[exp:valuetype Terraria.GameContent.ObjectInteractions.SmartInteractScanSettings&](settings)))
	stloc:float32(var_1_12, ldfld:float32(Vector2::X, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](SmartInteractScanSettings::mousevec, ldloc:SmartInteractScanSettings[exp:valuetype Terraria.GameContent.ObjectInteractions.SmartInteractScanSettings&](settings))))
	stloc:float32(var_2_1E, ldfld:float32(Vector2::Y, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](SmartInteractScanSettings::mousevec, ldloc:SmartInteractScanSettings[exp:valuetype Terraria.GameContent.ObjectInteractions.SmartInteractScanSettings&](settings))))
	stloc:bool(var_11_2D, ldfld:bool(SmartInteractScanSettings::DemandOnlyZeroDistanceTargets, ldloc:SmartInteractScanSettings[exp:valuetype Terraria.GameContent.ObjectInteractions.SmartInteractScanSettings&](settings)))
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

		// Token: 0x06004334 RID: 17204 RVA: 0x0024DBF0 File Offset: 0x0024BDF0
		public ProjectileSmartInteractCandidateProvider()
		{
		}

		// Token: 0x0400815B RID: 33115
		private ProjectileSmartInteractCandidateProvider.ReusableCandidate _candidate;

		// Token: 0x0200084F RID: 2127
		private class ReusableCandidate : ISmartInteractCandidate
		{
			// Token: 0x170007C9 RID: 1993
			// (get) Token: 0x06004335 RID: 17205 RVA: 0x0024DC00 File Offset: 0x0024BE00
			// (set) Token: 0x06004336 RID: 17206 RVA: 0x0024DC14 File Offset: 0x0024BE14
			public float DistanceFromCursor
			{
				[CompilerGenerated]
				get
				{
					/*
An exception occurred when decompiling this method (06004335)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.GameContent.ObjectInteractions.ProjectileSmartInteractCandidateProvider/ReusableCandidate::get_DistanceFromCursor()

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

			// Token: 0x06004337 RID: 17207 RVA: 0x0024DC24 File Offset: 0x0024BE24
			public void WinCandidacy()
			{
				int projectileIndexToTarget = this._projectileIndexToTarget;
				if (!true)
				{
				}
				Main.SmartInteractProj = projectileIndexToTarget;
				Main.SmartInteractShowingGenuine = true;
			}

			// Token: 0x06004338 RID: 17208 RVA: 0x0024DC48 File Offset: 0x0024BE48
			public void Reuse(int projectileIndex, float projectileDistanceFromCursor)
			{
				this._projectileIndexToTarget = projectileIndex;
			}

			// Token: 0x06004339 RID: 17209 RVA: 0x0024DC5C File Offset: 0x0024BE5C
			public ReusableCandidate()
			{
			}

			// Token: 0x0400815C RID: 33116
			[CompilerGenerated]
			private float <DistanceFromCursor>k__BackingField;

			// Token: 0x0400815D RID: 33117
			private int _projectileIndexToTarget;
		}
	}
}
