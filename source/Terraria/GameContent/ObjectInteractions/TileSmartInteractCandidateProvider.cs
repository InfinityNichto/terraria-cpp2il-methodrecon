using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Terraria.GameContent.ObjectInteractions
{
	// Token: 0x0200084A RID: 2122
	public class TileSmartInteractCandidateProvider : ISmartInteractCandidateProvider
	{
		// Token: 0x0600431F RID: 17183 RVA: 0x0024D6D4 File Offset: 0x0024B8D4
		public void ClearSelfAndPrepareForCheck()
		{
			if (!true)
			{
			}
			Main.SmartInteractX = int.MinValue;
			Main.SmartInteractY = int.MinValue;
			Main.TileInteractionLX = int.MinValue;
			Main.TileInteractionHX = int.MinValue;
			Main.TileInteractionLY = int.MinValue;
			Main.TileInteractionHY = int.MinValue;
			Dictionary<int, bool> smartInteractTileCoords = Main.SmartInteractTileCoords;
			Dictionary<int, bool> smartInteractTileCoordsSelected = Main.SmartInteractTileCoordsSelected;
			List<int> list = this.targets;
			int version = list._version;
			list._syncRoot = version;
		}

		// Token: 0x06004320 RID: 17184 RVA: 0x000021DB File Offset: 0x000003DB
		private int JoinValue(int x, int y)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004321 RID: 17185 RVA: 0x0024D74C File Offset: 0x0024B94C
		private void SplitValue(int value, [Out] int x, [Out] int y)
		{
		}

		// Token: 0x06004322 RID: 17186 RVA: 0x0024D75C File Offset: 0x0024B95C
		public bool ProvideCandidate(SmartInteractScanSettings settings, [Out] ISmartInteractCandidate candidate)
		{
			/*
An exception occurred when decompiling this method (06004322)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.ObjectInteractions.TileSmartInteractCandidateProvider::ProvideCandidate(Terraria.GameContent.ObjectInteractions.SmartInteractScanSettings,Terraria.GameContent.ObjectInteractions.ISmartInteractCandidate)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0187:
	stloc:float32(var_55_192, ldfld:float32(Vector2::X, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](SmartInteractScanSettings::mousevec, ldloc:SmartInteractScanSettings[exp:valuetype Terraria.GameContent.ObjectInteractions.SmartInteractScanSettings&](settings))))
	stloc:float32(var_56_19F, ldfld:float32(Vector2::Y, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](SmartInteractScanSettings::mousevec, ldloc:SmartInteractScanSettings[exp:valuetype Terraria.GameContent.ObjectInteractions.SmartInteractScanSettings&](settings))))
	stloc:ReusableCandidate(var_59_1AA, ldfld:ReusableCandidate(TileSmartInteractCandidateProvider::_candidate, ldloc:TileSmartInteractCandidateProvider(this)))
	stfld:int32(ReusableCandidate::_aimedX, ldloc:ReusableCandidate(var_59_1AA), ldloc:int32(var_47_154))
	stloc:ReusableCandidate(var_61_1BE, ldfld:ReusableCandidate(TileSmartInteractCandidateProvider::_candidate, ldloc:TileSmartInteractCandidateProvider(this)))
	stloc:int32(var_62_1C1, ldc.i4:int32(1))
	stfld:bool(ReusableCandidate::_strictSettings, ldloc:ReusableCandidate(var_61_1BE), ldloc:int32[exp:bool](var_62_1C1))
	stfld:int32(ReusableCandidate::_aimedX, ldloc:ReusableCandidate(var_61_1BE), ldc.i4:int32(42168472))
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

		// Token: 0x06004323 RID: 17187 RVA: 0x000021DB File Offset: 0x000003DB
		private void FillPotentialTargetTiles(SmartInteractScanSettings settings)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004324 RID: 17188 RVA: 0x0024D940 File Offset: 0x0024BB40
		public TileSmartInteractCandidateProvider()
		{
		}

		// Token: 0x0400814E RID: 33102
		private List<int> targets;

		// Token: 0x0400814F RID: 33103
		private TileSmartInteractCandidateProvider.ReusableCandidate _candidate;

		// Token: 0x0200084B RID: 2123
		private class ReusableCandidate : ISmartInteractCandidate
		{
			// Token: 0x06004325 RID: 17189 RVA: 0x0024D954 File Offset: 0x0024BB54
			public void Reuse(bool strictSettings, float distanceFromCursor, int AimedX, int AimedY, int LX, int LY, int HX, int HY)
			{
				this._aimedX = AimedX;
				this._hx = AimedY;
				this._lx = LX;
				this.<DistanceFromCursor>k__BackingField = (float)LY;
				this._hx = HX;
				this._lx = HY;
			}

			// Token: 0x170007C7 RID: 1991
			// (get) Token: 0x06004326 RID: 17190 RVA: 0x0024D990 File Offset: 0x0024BB90
			// (set) Token: 0x06004327 RID: 17191 RVA: 0x0024D9A4 File Offset: 0x0024BBA4
			public float DistanceFromCursor
			{
				[CompilerGenerated]
				get
				{
					/*
An exception occurred when decompiling this method (06004326)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.GameContent.ObjectInteractions.TileSmartInteractCandidateProvider/ReusableCandidate::get_DistanceFromCursor()

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

			// Token: 0x06004328 RID: 17192 RVA: 0x0024D9B4 File Offset: 0x0024BBB4
			public void WinCandidacy()
			{
				int num = 1;
				int aimedX = this._aimedX;
				if (num == 0)
				{
				}
				Main.SmartInteractX = aimedX;
				Main.SmartInteractY = this._aimedY;
				bool strictSettings = this._strictSettings;
				if (num != 0 && strictSettings)
				{
					Dictionary<int, bool> smartInteractTileCoords = Main.SmartInteractTileCoords;
					return;
				}
				Main.SmartInteractShowingGenuine = true;
				int lx = this._lx;
				if (num == 0)
				{
				}
				Main.TileInteractionLX = int.MinValue;
				int ly = this._ly;
				Main.TileInteractionLY = int.MinValue;
				int hx = this._hx;
				Main.TileInteractionHX = int.MinValue;
				int hy = this._hy;
				Main.TileInteractionHY = int.MinValue;
			}

			// Token: 0x06004329 RID: 17193 RVA: 0x0024DA48 File Offset: 0x0024BC48
			public ReusableCandidate()
			{
			}

			// Token: 0x04008150 RID: 33104
			private bool _strictSettings;

			// Token: 0x04008151 RID: 33105
			private int _aimedX;

			// Token: 0x04008152 RID: 33106
			private int _aimedY;

			// Token: 0x04008153 RID: 33107
			private int _hx;

			// Token: 0x04008154 RID: 33108
			private int _hy;

			// Token: 0x04008155 RID: 33109
			private int _lx;

			// Token: 0x04008156 RID: 33110
			private int _ly;

			// Token: 0x04008157 RID: 33111
			[CompilerGenerated]
			private float <DistanceFromCursor>k__BackingField;
		}
	}
}
