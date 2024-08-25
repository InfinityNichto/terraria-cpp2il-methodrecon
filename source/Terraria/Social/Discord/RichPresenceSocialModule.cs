using System;
using Terraria.Localization;
using Terraria.Net;
using Terraria.Social.Base;

namespace Terraria.Social.Discord
{
	// Token: 0x02000526 RID: 1318
	public class RichPresenceSocialModule : ISocialModule
	{
		// Token: 0x060031AD RID: 12717 RVA: 0x001F8C58 File Offset: 0x001F6E58
		public void Initialize()
		{
			if (!true)
			{
			}
		}

		// Token: 0x060031AE RID: 12718 RVA: 0x001F8C68 File Offset: 0x001F6E68
		public void Shutdown()
		{
			if (!true)
			{
			}
		}

		// Token: 0x060031AF RID: 12719 RVA: 0x001F8C78 File Offset: 0x001F6E78
		private void UpdatePresence()
		{
			RichPresenceState currentState = RichPresenceState.GetCurrentState();
			RichPresenceState lastState = this._lastState;
			if (lastState != null)
			{
				RichPresenceState.GameModeState gameMode = lastState.GameMode;
				RichPresenceState.GameModeState gameMode2 = currentState.GameMode;
			}
			this.PublishPresence(currentState);
			this._lastState = currentState;
		}

		// Token: 0x060031B0 RID: 12720 RVA: 0x001F8CB4 File Offset: 0x001F6EB4
		private void PublishPresence(RichPresenceState state)
		{
			RichPresenceState.GameModeState gameMode = state.GameMode;
			string text;
			string textValue = Language.GetTextValue("RichPresence." + text);
			RichPresenceState.GameModeState gameMode2 = state.GameMode;
			string text2 = this._infoAboutNetGroup.ComposeInfo();
		}

		// Token: 0x060031B1 RID: 12721 RVA: 0x001F8CF0 File Offset: 0x001F6EF0
		private bool ShouldAllowJoinRequests(RichPresenceState state)
		{
			/*
An exception occurred when decompiling this method (060031B1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Social.Discord.RichPresenceSocialModule::ShouldAllowJoinRequests(Terraria.Social.Base.RichPresenceState)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GameModeState(var_0_06, ldfld:GameModeState(RichPresenceState::GameMode, ldloc:RichPresenceState(state)))
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

		// Token: 0x060031B2 RID: 12722 RVA: 0x001F8D04 File Offset: 0x001F6F04
		private string GetJoinSecret()
		{
			return this._infoAboutNetGroup.ComposeInfo();
		}

		// Token: 0x060031B3 RID: 12723 RVA: 0x001F8D1C File Offset: 0x001F6F1C
		public RichPresenceSocialModule()
		{
		}

		// Token: 0x04003B59 RID: 15193
		private RichPresenceState _lastState;

		// Token: 0x04003B5A RID: 15194
		private Guid _uniquePartyId;

		// Token: 0x04003B5B RID: 15195
		private NetGroupInfo _infoAboutNetGroup;
	}
}
