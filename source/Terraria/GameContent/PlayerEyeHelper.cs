using System;
using System.Runtime.CompilerServices;

namespace Terraria.GameContent
{
	// Token: 0x020007E6 RID: 2022
	public struct PlayerEyeHelper
	{
		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x06004114 RID: 16660 RVA: 0x0024498C File Offset: 0x00242B8C
		// (set) Token: 0x06004115 RID: 16661 RVA: 0x002449A0 File Offset: 0x00242BA0
		public int EyeFrameToShow
		{
			[CompilerGenerated]
			readonly get
			{
				return this.<EyeFrameToShow>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<EyeFrameToShow>k__BackingField = value;
			}
		}

		// Token: 0x06004116 RID: 16662 RVA: 0x002449B4 File Offset: 0x00242BB4
		public void Update(Player player)
		{
			this.SetStateByPlayerInfo(player);
			this.UpdateEyeFrameToShow(player);
			int timeInState = this._timeInState;
			this._timeInState = timeInState;
		}

		// Token: 0x06004117 RID: 16663 RVA: 0x002449E0 File Offset: 0x00242BE0
		private void UpdateEyeFrameToShow(Player player)
		{
		}

		// Token: 0x06004118 RID: 16664 RVA: 0x00244A28 File Offset: 0x00242C28
		private void SetStateByPlayerInfo(Player player)
		{
			if (player.blackout || player.blind)
			{
				return;
			}
			int timeInState = this._timeInState;
			if (player.sleeping != null)
			{
				int itemAnimation = player.itemAnimation;
				return;
			}
			int statLifeMax = player.statLifeMax2;
			int statLife = player.statLife;
			if (player.tipsy)
			{
				return;
			}
			if (player.poisoned || player.venom)
			{
				return;
			}
			bool zoneSandstorm = player.ZoneSandstorm;
		}

		// Token: 0x06004119 RID: 16665 RVA: 0x00244AAC File Offset: 0x00242CAC
		private void SwitchToState(PlayerEyeHelper.EyeState newState, bool resetStateTimerEvenIfAlreadyInState = false)
		{
		}

		// Token: 0x0600411A RID: 16666 RVA: 0x00244AC4 File Offset: 0x00242CC4
		private bool DoesPlayerCountAsModeratelyDamaged(Player player)
		{
			/*
An exception occurred when decompiling this method (0600411A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.PlayerEyeHelper::DoesPlayerCountAsModeratelyDamaged(Terraria.Player)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Player::statLifeMax2, ldloc:Player(player)))
	stloc:int32(var_1_0D, ldfld:int32(Player::statLife, ldloc:Player(player)))
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

		// Token: 0x0600411B RID: 16667 RVA: 0x00244AE0 File Offset: 0x00242CE0
		public void BlinkBecausePlayerGotHurt()
		{
		}

		// Token: 0x04007EC7 RID: 32455
		private PlayerEyeHelper.EyeState _state;

		// Token: 0x04007EC8 RID: 32456
		private int _timeInState;

		// Token: 0x04007EC9 RID: 32457
		[CompilerGenerated]
		private int <EyeFrameToShow>k__BackingField;

		// Token: 0x04007ECA RID: 32458
		private const int TimeToActDamaged = 20;

		// Token: 0x020007E7 RID: 2023
		private enum EyeFrame
		{
			// Token: 0x04007ECC RID: 32460
			EyeOpen,
			// Token: 0x04007ECD RID: 32461
			EyeHalfClosed,
			// Token: 0x04007ECE RID: 32462
			EyeClosed
		}

		// Token: 0x020007E8 RID: 2024
		private enum EyeState
		{
			// Token: 0x04007ED0 RID: 32464
			NormalBlinking,
			// Token: 0x04007ED1 RID: 32465
			InStorm,
			// Token: 0x04007ED2 RID: 32466
			InBed,
			// Token: 0x04007ED3 RID: 32467
			JustTookDamage,
			// Token: 0x04007ED4 RID: 32468
			IsModeratelyDamaged,
			// Token: 0x04007ED5 RID: 32469
			IsBlind,
			// Token: 0x04007ED6 RID: 32470
			IsTipsy,
			// Token: 0x04007ED7 RID: 32471
			IsPoisoned
		}
	}
}
