using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.NetModules;
using Terraria.Localization;
using Terraria.Net;

namespace Terraria.Chat
{
	// Token: 0x02000794 RID: 1940
	public static class ChatHelper
	{
		// Token: 0x06003F7D RID: 16253 RVA: 0x00240B24 File Offset: 0x0023ED24
		public static void DisplayMessageOnClient(NetworkText text, Color color, int playerId)
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
		}

		// Token: 0x06003F7E RID: 16254 RVA: 0x00240B48 File Offset: 0x0023ED48
		public static void SendChatMessageToClient(NetworkText text, Color color, int playerId)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003F7F RID: 16255 RVA: 0x00240B58 File Offset: 0x0023ED58
		public static void SendChatMessageToClientAs(byte messageAuthor, NetworkText text, Color color, int playerId)
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
		}

		// Token: 0x06003F80 RID: 16256 RVA: 0x00240B7C File Offset: 0x0023ED7C
		public static void BroadcastChatMessage(NetworkText text, Color color, int excludedPlayer = -1)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003F81 RID: 16257 RVA: 0x00240B8C File Offset: 0x0023ED8C
		public static void BroadcastChatMessageAs(byte messageAuthor, NetworkText text, Color color, int excludedPlayer = -1)
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
			bool netHost = Main.NetHost;
		}

		// Token: 0x06003F82 RID: 16258 RVA: 0x00240BB0 File Offset: 0x0023EDB0
		public static bool OnlySendToPlayersWhoAreLoggedIn(int clientIndex)
		{
			/*
An exception occurred when decompiling this method (06003F82)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Chat.ChatHelper::OnlySendToPlayersWhoAreLoggedIn(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
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

		// Token: 0x06003F83 RID: 16259 RVA: 0x00240BC0 File Offset: 0x0023EDC0
		public static void SendChatMessageFromClient(ChatMessage message)
		{
			bool <IsConsumed>k__BackingField = message.<IsConsumed>k__BackingField;
			if (<IsConsumed>k__BackingField)
			{
				return;
			}
			NetPacket netPacket = NetTextModule.SerializeClientMessage(message);
			if (!<IsConsumed>k__BackingField)
			{
			}
		}

		// Token: 0x06003F84 RID: 16260 RVA: 0x00240BE4 File Offset: 0x0023EDE4
		public static void DisplayCheckedMessage(bool result, ChatHelper.ChatRequest request)
		{
			if (!true)
			{
			}
			byte messageAuthor = request.messageAuthor;
			string message = request.message;
			byte messageAuthor2 = request.messageAuthor;
			Color color = request.color;
			byte messageAuthor3 = request.messageAuthor;
			string message2 = request.message;
			string text2;
			string text = text2 + " " + message2;
			if (messageAuthor3 == 0)
			{
			}
			bool flag = ChatHelper.ShouldCacheMessage();
			Color color2 = request.color;
			ChatHelper.CacheMessage(text, color2);
		}

		// Token: 0x06003F85 RID: 16261 RVA: 0x00240C64 File Offset: 0x0023EE64
		public static void PlatformCheckedMessage(string message, Color color, byte messageAuthor)
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
		}

		// Token: 0x06003F86 RID: 16262 RVA: 0x00240C8C File Offset: 0x0023EE8C
		public static void DisplayMessage(NetworkText text, Color color, byte messageAuthor)
		{
			bool hasChatPermissions = DrPlatform.User.HasChatPermissions;
		}

		// Token: 0x06003F87 RID: 16263 RVA: 0x00240CAC File Offset: 0x0023EEAC
		private static void CacheMessage(string message, Color color)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003F88 RID: 16264 RVA: 0x00240CC0 File Offset: 0x0023EEC0
		public static void ShowCachedMessages()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x06003F89 RID: 16265 RVA: 0x00240D14 File Offset: 0x0023EF14
		public static void ClearDelayedMessagesCache()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003F8A RID: 16266 RVA: 0x00240D28 File Offset: 0x0023EF28
		private static bool ShouldCacheMessage()
		{
			if (!true)
			{
			}
			bool netClient = Main.NetClient;
			if (!true)
			{
			}
			return Main.gameMenu;
		}

		// Token: 0x06003F8B RID: 16267 RVA: 0x00240D4C File Offset: 0x0023EF4C
		// Note: this type is marked as 'beforefieldinit'.
		static ChatHelper()
		{
		}

		// Token: 0x04007DB9 RID: 32185
		private static List<Tuple<string, Color>> _cachedMessages;

		// Token: 0x02000795 RID: 1941
		public class ChatRequest
		{
			// Token: 0x06003F8C RID: 16268 RVA: 0x00240D5C File Offset: 0x0023EF5C
			public ChatRequest()
			{
			}

			// Token: 0x04007DBA RID: 32186
			public PlatformUser LocalUser;

			// Token: 0x04007DBB RID: 32187
			public PlatformUser SendingUser;

			// Token: 0x04007DBC RID: 32188
			public ChatHelper.ChatRequest.ChatRequestCallback Callback;

			// Token: 0x04007DBD RID: 32189
			public string message;

			// Token: 0x04007DBE RID: 32190
			public Color color;

			// Token: 0x04007DBF RID: 32191
			public byte messageAuthor;

			// Token: 0x04007DC0 RID: 32192
			public bool result;

			// Token: 0x02000796 RID: 1942
			// (Invoke) Token: 0x06003F8E RID: 16270
			public delegate void ChatRequestCallback(bool result, ChatHelper.ChatRequest request);
		}
	}
}
