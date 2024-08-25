using System;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Terraria.Chat.Commands;

namespace Terraria.Chat
{
	// Token: 0x0200079A RID: 1946
	public sealed class ChatMessage
	{
		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x06003FA3 RID: 16291 RVA: 0x00240FAC File Offset: 0x0023F1AC
		// (set) Token: 0x06003FA4 RID: 16292 RVA: 0x00240FC0 File Offset: 0x0023F1C0
		public ChatCommandId CommandId
		{
			[CompilerGenerated]
			get
			{
				return this.<CommandId>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<CommandId>k__BackingField = value;
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x06003FA5 RID: 16293 RVA: 0x00240FD4 File Offset: 0x0023F1D4
		// (set) Token: 0x06003FA6 RID: 16294 RVA: 0x00240FE8 File Offset: 0x0023F1E8
		public string Text
		{
			[CompilerGenerated]
			get
			{
				return this.<Text>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Text>k__BackingField = value;
			}
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x06003FA7 RID: 16295 RVA: 0x00240FFC File Offset: 0x0023F1FC
		// (set) Token: 0x06003FA8 RID: 16296 RVA: 0x00241010 File Offset: 0x0023F210
		public bool IsConsumed
		{
			[CompilerGenerated]
			get
			{
				return this.<IsConsumed>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003FA9 RID: 16297 RVA: 0x00241020 File Offset: 0x0023F220
		public ChatMessage(string message)
		{
			ChatCommandId chatCommandId = ChatCommandId.FromType();
			this.CommandId = chatCommandId;
			this.Text = message;
		}

		// Token: 0x06003FAA RID: 16298 RVA: 0x00241048 File Offset: 0x0023F248
		private ChatMessage(string message, ChatCommandId commandId)
		{
			this.CommandId = commandId;
			this.Text = message;
		}

		// Token: 0x06003FAB RID: 16299 RVA: 0x0024106C File Offset: 0x0023F26C
		public void Serialize(BinaryWriter writer)
		{
			while (this.<IsConsumed>k__BackingField)
			{
			}
			ChatCommandId chatCommandId = this.<CommandId>k__BackingField;
			string text = this.<Text>k__BackingField;
		}

		// Token: 0x06003FAC RID: 16300 RVA: 0x00241090 File Offset: 0x0023F290
		public int GetMaxSerializedSize()
		{
			/*
An exception occurred when decompiling this method (06003FAC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.Chat.ChatMessage::GetMaxSerializedSize()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ChatCommandId(var_0_0E, ldfld:ChatCommandId(ChatMessage::<CommandId>k__BackingField, ldloc:ChatMessage(this)))
	stloc:Encoding(var_3_16, callgetter:Encoding(Encoding::get_UTF8))
	stloc:string(var_4_1D, ldfld:string(ChatMessage::<Text>k__BackingField, ldloc:ChatMessage(this)))
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

		// Token: 0x06003FAD RID: 16301 RVA: 0x000021DB File Offset: 0x000003DB
		public static ChatMessage Deserialize(BinaryReader reader)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003FAE RID: 16302 RVA: 0x002410BC File Offset: 0x0023F2BC
		public void SetCommand(ChatCommandId commandId)
		{
			while (this.<IsConsumed>k__BackingField)
			{
			}
			this.<CommandId>k__BackingField = commandId;
		}

		// Token: 0x06003FAF RID: 16303 RVA: 0x002410D8 File Offset: 0x0023F2D8
		public void SetCommand<T>() where T : IChatCommand
		{
			while (this.<IsConsumed>k__BackingField)
			{
			}
		}

		// Token: 0x06003FB0 RID: 16304 RVA: 0x002410F0 File Offset: 0x0023F2F0
		public void Consume()
		{
			this.<IsConsumed>k__BackingField = true;
		}

		// Token: 0x04007DC8 RID: 32200
		[CompilerGenerated]
		private ChatCommandId <CommandId>k__BackingField;

		// Token: 0x04007DC9 RID: 32201
		[CompilerGenerated]
		private string <Text>k__BackingField;

		// Token: 0x04007DCA RID: 32202
		[CompilerGenerated]
		private bool <IsConsumed>k__BackingField;
	}
}
