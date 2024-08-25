using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Localization;

namespace Terraria.Chat.Commands
{
	// Token: 0x020007A5 RID: 1957
	[ChatCommand("Help")]
	public class HelpCommand : IChatCommand
	{
		// Token: 0x06003FD2 RID: 16338 RVA: 0x00241414 File Offset: 0x0023F614
		public void ProcessIncomingMessage(string text, byte clientId)
		{
			if (!true)
			{
			}
			NetworkText networkText = HelpCommand.ComposeMessage(HelpCommand.GetCommandAliasesByID());
		}

		// Token: 0x06003FD3 RID: 16339 RVA: 0x00241430 File Offset: 0x0023F630
		private static Dictionary<string, List<LocalizedText>> GetCommandAliasesByID()
		{
			/*
An exception occurred when decompiling this method (06003FD3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.Dictionary`2<System.String,System.Collections.Generic.List`1<Terraria.Localization.LocalizedText>> Terraria.Chat.Commands.HelpCommand::GetCommandAliasesByID()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:string(var_2_1A, ldfld:string(LocalizedText::<Value>k__BackingField, call:class Terraria.Localization.LocalizedText[][exp:LocalizedText](Language::FindAll, call:LanguageSearchFilter(Lang::CreateDialogFilter, ldstr:string("ChatCommandDescription."), ldloc:object(var_1)))))
	stloc:int32(var_5_1F, ldc.i4:int32(95))
	stloc:int32(var_6_2A, call:int32(string::IndexOf, ldloc:string(var_4), ldloc:int32[exp:char](var_5_1F)))
	stloc:int64(var_7_2D, ldc.i4:int64(0))
	stloc:string(var_8_3A, call:string(string::Substring, ldloc:string(var_4), ldloc:int64[exp:int32](var_7_2D), ldloc:int32(var_6_2A)))
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

		// Token: 0x06003FD4 RID: 16340 RVA: 0x00241478 File Offset: 0x0023F678
		private static NetworkText ComposeMessage(Dictionary<string, List<LocalizedText>> aliases)
		{
			string text2;
			string text = "" + "{" + text2 + "}\n";
			string text3;
			return Language.GetText(text3).ToNetworkText();
		}

		// Token: 0x06003FD5 RID: 16341 RVA: 0x002414C4 File Offset: 0x0023F6C4
		public void ProcessOutgoingMessage(ChatMessage message)
		{
		}

		// Token: 0x06003FD6 RID: 16342 RVA: 0x002414D4 File Offset: 0x0023F6D4
		public HelpCommand()
		{
		}

		// Token: 0x06003FD7 RID: 16343 RVA: 0x002414E8 File Offset: 0x0023F6E8
		// Note: this type is marked as 'beforefieldinit'.
		static HelpCommand()
		{
		}

		// Token: 0x04007DD3 RID: 32211
		private static readonly Color RESPONSE_COLOR;
	}
}
