using System;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Achievements;
using Terraria.UI;
using Terraria.UI.Chat;

namespace Terraria.GameContent.UI.Chat
{
	// Token: 0x02000AD6 RID: 2774
	public class AchievementTagHandler : ITagHandler
	{
		// Token: 0x0600519F RID: 20895 RVA: 0x00280EBC File Offset: 0x0027F0BC
		TextSnippet ITagHandler.Parse(string text, Color baseColor, string options)
		{
			/*
An exception occurred when decompiling this method (0600519F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.UI.Chat.TextSnippet Terraria.GameContent.UI.Chat.AchievementTagHandler::Terraria.UI.Chat.ITagHandler.Parse(System.String,Microsoft.Xna.Framework.Graphics.Color,System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	brtrue(IL_0000, logicnot:bool(call:Achievement[exp:bool](AchievementManager::GetAchievement, callgetter:AchievementManager(Main::get_Achievements), ldloc:string(text))))
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

		// Token: 0x060051A0 RID: 20896 RVA: 0x00280EDC File Offset: 0x0027F0DC
		public static string GenerateTag(Achievement achievement)
		{
			string text;
			return text;
		}

		// Token: 0x060051A1 RID: 20897 RVA: 0x00280EEC File Offset: 0x0027F0EC
		public AchievementTagHandler()
		{
		}

		// Token: 0x02000AD7 RID: 2775
		private class AchievementSnippet : TextSnippet
		{
			// Token: 0x060051A2 RID: 20898 RVA: 0x00280F00 File Offset: 0x0027F100
			public AchievementSnippet(Achievement achievement)
			{
				string <Value>k__BackingField = achievement.FriendlyName.<Value>k__BackingField;
				this.CheckForHover = true;
				this._achievement = achievement;
			}

			// Token: 0x060051A3 RID: 20899 RVA: 0x00280F28 File Offset: 0x0027F128
			public override void OnClick()
			{
				IngameFancyUI.OpenAchievementsAndGoto(this._achievement);
			}

			// Token: 0x04008A31 RID: 35377
			private Achievement _achievement;
		}
	}
}
