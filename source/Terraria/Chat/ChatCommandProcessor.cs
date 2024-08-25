using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Terraria.Chat.Commands;
using Terraria.Localization;

namespace Terraria.Chat
{
	// Token: 0x02000798 RID: 1944
	public class ChatCommandProcessor : IChatProcessor
	{
		// Token: 0x06003F96 RID: 16278 RVA: 0x00240DA8 File Offset: 0x0023EFA8
		public ChatCommandProcessor AddCommand<T>() where T : IChatCommand, new()
		{
			Dictionary<ChatCommandId, IChatCommand> commands = this._commands;
			string text;
			bool flag = Language.Exists(text);
			Dictionary<LocalizedText, ChatCommandId> localizedCommands = this._localizedCommands;
			LocalizedText text2 = Language.GetText(text);
			bool flag2 = text == "ChatCommand.Playing";
			Dictionary<LocalizedText, ChatCommandId> localizedCommands2 = this._localizedCommands;
			return "ChatCommand.Playing_0";
		}

		// Token: 0x06003F97 RID: 16279 RVA: 0x00240E20 File Offset: 0x0023F020
		public void AddAlias(LocalizedText text, NetworkText result)
		{
			Dictionary<LocalizedText, NetworkText> aliases = this._aliases;
		}

		// Token: 0x06003F98 RID: 16280 RVA: 0x00240E34 File Offset: 0x0023F034
		public void ClearAliases()
		{
			Dictionary<LocalizedText, NetworkText> aliases = this._aliases;
		}

		// Token: 0x06003F99 RID: 16281 RVA: 0x00240E48 File Offset: 0x0023F048
		public ChatCommandProcessor AddDefaultCommand<T>() where T : IChatCommand, new()
		{
			Dictionary<ChatCommandId, IChatCommand> commands = this._commands;
			this._defaultCommand = commands;
			return this;
		}

		// Token: 0x06003F9A RID: 16282 RVA: 0x00240E64 File Offset: 0x0023F064
		private static bool HasLocalizedCommand(ChatMessage message, LocalizedText command)
		{
			string <Text>k__BackingField = message.<Text>k__BackingField;
			string text;
			bool flag = text.StartsWith(<Text>k__BackingField);
			int stringLength = text._stringLength;
			int stringLength2 = <Text>k__BackingField._stringLength;
			return true;
		}

		// Token: 0x06003F9B RID: 16283 RVA: 0x00240EA0 File Offset: 0x0023F0A0
		private static string RemoveCommandPrefix(string messageText, LocalizedText command)
		{
			int stringLength = messageText._stringLength;
			int stringLength2 = messageText._stringLength;
			string text;
			return text;
		}

		// Token: 0x06003F9C RID: 16284 RVA: 0x00240EC8 File Offset: 0x0023F0C8
		public ChatMessage CreateOutgoingMessage(string text)
		{
			/*
An exception occurred when decompiling this method (06003F9C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Chat.ChatMessage Terraria.Chat.ChatCommandProcessor::CreateOutgoingMessage(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001C:
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<valuetype Terraria.Chat.ChatCommandId, class Terraria.Chat.Commands.IChatCommand>(var_4_22, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<valuetype Terraria.Chat.ChatCommandId, class Terraria.Chat.Commands.IChatCommand>(ChatCommandProcessor::_commands, ldloc:ChatCommandProcessor(this)))
	brtrue(IL_0000, logicnot:bool(ldloc:int32[exp:bool](var_0_01)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

		// Token: 0x06003F9D RID: 16285 RVA: 0x00240EFC File Offset: 0x0023F0FC
		public void ProcessIncomingMessage(ChatMessage message, int clientId)
		{
			Dictionary<ChatCommandId, IChatCommand> commands = this._commands;
			ChatCommandId <CommandId>k__BackingField = message.<CommandId>k__BackingField;
			string <Text>k__BackingField = message.<Text>k__BackingField;
		}

		// Token: 0x06003F9E RID: 16286 RVA: 0x00240F3C File Offset: 0x0023F13C
		public ChatCommandProcessor()
		{
		}

		// Token: 0x04007DC2 RID: 32194
		private readonly Dictionary<LocalizedText, ChatCommandId> _localizedCommands;

		// Token: 0x04007DC3 RID: 32195
		private readonly Dictionary<ChatCommandId, IChatCommand> _commands;

		// Token: 0x04007DC4 RID: 32196
		private readonly Dictionary<LocalizedText, NetworkText> _aliases;

		// Token: 0x04007DC5 RID: 32197
		private IChatCommand _defaultCommand;

		// Token: 0x02000799 RID: 1945
		[CompilerGenerated]
		private sealed class <>c__DisplayClass10_0
		{
			// Token: 0x06003F9F RID: 16287 RVA: 0x00240F50 File Offset: 0x0023F150
			public <>c__DisplayClass10_0()
			{
			}

			// Token: 0x06003FA0 RID: 16288 RVA: 0x00240F64 File Offset: 0x0023F164
			internal bool <CreateOutgoingMessage>b__0(KeyValuePair<LocalizedText, ChatCommandId> pair)
			{
				ChatMessage chatMessage = this.message;
				bool flag;
				return flag;
			}

			// Token: 0x06003FA1 RID: 16289 RVA: 0x00240F7C File Offset: 0x0023F17C
			internal bool <CreateOutgoingMessage>b__1(KeyValuePair<LocalizedText, NetworkText> pair)
			{
				ChatMessage chatMessage = this.message;
				bool flag;
				return flag;
			}

			// Token: 0x06003FA2 RID: 16290 RVA: 0x00240F94 File Offset: 0x0023F194
			internal bool <CreateOutgoingMessage>b__2(KeyValuePair<LocalizedText, NetworkText> pair)
			{
				ChatMessage chatMessage = this.message;
				bool flag;
				return flag;
			}

			// Token: 0x04007DC6 RID: 32198
			public ChatMessage message;

			// Token: 0x04007DC7 RID: 32199
			public Func<KeyValuePair<LocalizedText, NetworkText>, bool> <>9__2;
		}
	}
}
