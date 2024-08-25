using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.IO;

namespace Terraria.GameContent.UI.BigProgressBar
{
	// Token: 0x02000AE4 RID: 2788
	public class BigProgressBarSystem
	{
		// Token: 0x060051ED RID: 20973 RVA: 0x00281DC4 File Offset: 0x0027FFC4
		public bool IsTracking()
		{
			/*
An exception occurred when decompiling this method (060051ED)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.UI.BigProgressBar.BigProgressBarSystem::IsTracking()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:IBigProgressBar(var_0_06, ldfld:IBigProgressBar(BigProgressBarSystem::_currentBar, ldloc:BigProgressBarSystem(this)))
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

		// Token: 0x060051EE RID: 20974 RVA: 0x00281DD8 File Offset: 0x0027FFD8
		public void Update()
		{
			if (this._currentBar == null)
			{
				this.TryFindingNPCToTrack();
				if (this._currentBar == null)
				{
					return;
				}
			}
		}

		// Token: 0x060051EF RID: 20975 RVA: 0x00281DFC File Offset: 0x0027FFFC
		public void Draw(SpriteBatch spriteBatch)
		{
			if (this._currentBar != null)
			{
				return;
			}
		}

		// Token: 0x060051F0 RID: 20976 RVA: 0x00281E14 File Offset: 0x00280014
		private void TryFindingNPCToTrack()
		{
			int num = 1;
			if (num == 0)
			{
			}
			Vector2 screenPosition = Main.screenPosition;
			Vector2 screenPosition2 = Main.screenPosition;
			int screenWidth = Main.screenWidth;
			int screenHeight = Main.screenHeight;
			if (num == 0)
			{
			}
			Vector2 center = Main.LocalPlayer.Center;
		}

		// Token: 0x060051F1 RID: 20977 RVA: 0x00281E74 File Offset: 0x00280074
		public bool TryTracking(int npcIndex)
		{
			/*
An exception occurred when decompiling this method (060051F1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.UI.BigProgressBar.BigProgressBarSystem::TryTracking(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<int32, class Terraria.GameContent.UI.BigProgressBar.IBigProgressBar>(var_0_09, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<int32, class Terraria.GameContent.UI.BigProgressBar.IBigProgressBar>(BigProgressBarSystem::_bossBarsByNpcNetId, ldloc:BigProgressBarSystem(this)))
	stloc:CommonBossBigProgressBar(var_1_10, ldfld:CommonBossBigProgressBar(BigProgressBarSystem::_bossBar, ldloc:BigProgressBarSystem(this)))
	stfld:IBigProgressBar(BigProgressBarSystem::_currentBar, ldloc:BigProgressBarSystem(this), ldloc:CommonBossBigProgressBar[exp:IBigProgressBar](var_1_10))
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

		// Token: 0x060051F2 RID: 20978 RVA: 0x00281E9C File Offset: 0x0028009C
		private void Configuration_Save(Preferences obj)
		{
			if (!true)
			{
			}
		}

		// Token: 0x060051F3 RID: 20979 RVA: 0x00281EAC File Offset: 0x002800AC
		private void Configuration_OnLoad(Preferences obj)
		{
			if (!true)
			{
			}
			Preferences configuration = Main.Configuration;
		}

		// Token: 0x060051F4 RID: 20980 RVA: 0x00281EC4 File Offset: 0x002800C4
		public static void ToggleShowText()
		{
			if (!true)
			{
			}
		}

		// Token: 0x060051F5 RID: 20981 RVA: 0x00281ED4 File Offset: 0x002800D4
		public BigProgressBarSystem()
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x060051F6 RID: 20982 RVA: 0x00281EEC File Offset: 0x002800EC
		// Note: this type is marked as 'beforefieldinit'.
		static BigProgressBarSystem()
		{
		}

		// Token: 0x04008A49 RID: 35401
		private static TwinsBigProgressBar _twinsBar;

		// Token: 0x04008A4A RID: 35402
		private static EaterOfWorldsProgressBar _eaterOfWorldsBar;

		// Token: 0x04008A4B RID: 35403
		private static BrainOfCthuluBigProgressBar _brainOfCthuluBar;

		// Token: 0x04008A4C RID: 35404
		private static GolemHeadProgressBar _golemBar;

		// Token: 0x04008A4D RID: 35405
		private static MoonLordProgressBar _moonlordBar;

		// Token: 0x04008A4E RID: 35406
		private static SolarFlarePillarBigProgressBar _solarPillarBar;

		// Token: 0x04008A4F RID: 35407
		private static VortexPillarBigProgressBar _vortexPillarBar;

		// Token: 0x04008A50 RID: 35408
		private static NebulaPillarBigProgressBar _nebulaPillarBar;

		// Token: 0x04008A51 RID: 35409
		private static StardustPillarBigProgressBar _stardustPillarBar;

		// Token: 0x04008A52 RID: 35410
		private static NeverValidProgressBar _neverValid;

		// Token: 0x04008A53 RID: 35411
		private static PirateShipBigProgressBar _pirateShipBar;

		// Token: 0x04008A54 RID: 35412
		private static MartianSaucerBigProgressBar _martianSaucerBar;

		// Token: 0x04008A55 RID: 35413
		private IBigProgressBar _currentBar;

		// Token: 0x04008A56 RID: 35414
		private CommonBossBigProgressBar _bossBar;

		// Token: 0x04008A57 RID: 35415
		private BigProgressBarInfo _info;

		// Token: 0x04008A58 RID: 35416
		private static DeerclopsBigProgressBar _deerclopsBar;

		// Token: 0x04008A59 RID: 35417
		public static bool ShowText;

		// Token: 0x04008A5A RID: 35418
		private Dictionary<int, IBigProgressBar> _bossBarsByNpcNetId;

		// Token: 0x04008A5B RID: 35419
		private const string _preferencesKey = "ShowBossBarHealthText";
	}
}
