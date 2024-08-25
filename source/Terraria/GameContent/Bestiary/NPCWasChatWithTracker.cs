using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Terraria.GameContent.NetModules;
using Terraria.Net;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x0200093F RID: 2367
	public class NPCWasChatWithTracker : IPersistentPerWorldContent, IOnPlayerJoining
	{
		// Token: 0x06004784 RID: 18308 RVA: 0x0025EA1C File Offset: 0x0025CC1C
		public NPCWasChatWithTracker()
		{
		}

		// Token: 0x06004785 RID: 18309 RVA: 0x0025EA30 File Offset: 0x0025CC30
		public void RegisterChatStartWith(NPC npc)
		{
			string bestiaryCreditId = npc.GetBestiaryCreditId();
			HashSet<string> chattedWithPlayer = this._chattedWithPlayer;
			object entryCreationLock = this._entryCreationLock;
			HashSet<string> chattedWithPlayer2 = this._chattedWithPlayer;
			long num = 0L;
			Monitor.Exit(entryCreationLock);
			if (num == 0L)
			{
				bool netHost = Main.NetHost;
				int netID = npc.netID;
				NetPacket netPacket = NetBestiaryModule.SerializeChat(netID);
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06004786 RID: 18310 RVA: 0x0025EA9C File Offset: 0x0025CC9C
		public void SetWasChatWithDirectly(string persistentId)
		{
			object entryCreationLock = this._entryCreationLock;
			HashSet<string> chattedWithPlayer = this._chattedWithPlayer;
			long num = 0L;
			Monitor.Exit(entryCreationLock);
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06004787 RID: 18311 RVA: 0x0025EAE8 File Offset: 0x0025CCE8
		public bool GetWasChatWith(NPC npc)
		{
			/*
An exception occurred when decompiling this method (06004787)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Bestiary.NPCWasChatWithTracker::GetWasChatWith(Terraria.NPC)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_06, call:string(NPC::GetBestiaryCreditId, ldloc:NPC(npc)))
	stloc:class [System.Core]System.Collections.Generic.HashSet`1<string>(var_1_0D, ldfld:class [System.Core]System.Collections.Generic.HashSet`1<string>(NPCWasChatWithTracker::_chattedWithPlayer, ldloc:NPCWasChatWithTracker(this)))
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

		// Token: 0x06004788 RID: 18312 RVA: 0x0025EB04 File Offset: 0x0025CD04
		public bool GetWasChatWith(string persistentId)
		{
			/*
An exception occurred when decompiling this method (06004788)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Bestiary.NPCWasChatWithTracker::GetWasChatWith(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [System.Core]System.Collections.Generic.HashSet`1<string>(var_0_06, ldfld:class [System.Core]System.Collections.Generic.HashSet`1<string>(NPCWasChatWithTracker::_chattedWithPlayer, ldloc:NPCWasChatWithTracker(this)))
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

		// Token: 0x06004789 RID: 18313 RVA: 0x0025EB18 File Offset: 0x0025CD18
		public void Save(BinaryWriter writer)
		{
			object entryCreationLock = this._entryCreationLock;
			int count = this._chattedWithPlayer._count;
			HashSet<string> chattedWithPlayer = this._chattedWithPlayer;
		}

		// Token: 0x0600478A RID: 18314 RVA: 0x0025EB88 File Offset: 0x0025CD88
		public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
		{
			HashSet<string> chattedWithPlayer = this._chattedWithPlayer;
		}

		// Token: 0x0600478B RID: 18315 RVA: 0x0025EB9C File Offset: 0x0025CD9C
		public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
		{
		}

		// Token: 0x0600478C RID: 18316 RVA: 0x0025EBAC File Offset: 0x0025CDAC
		public void Reset()
		{
			HashSet<string> chattedWithPlayer = this._chattedWithPlayer;
		}

		// Token: 0x0600478D RID: 18317 RVA: 0x0025EBC0 File Offset: 0x0025CDC0
		public void OnPlayerJoining(int playerIndex)
		{
			HashSet<string> chattedWithPlayer = this._chattedWithPlayer;
			if (!true)
			{
			}
			if (!true)
			{
			}
			NetPacket netPacket = NetBestiaryModule.SerializeChat(42181272);
		}

		// Token: 0x04008366 RID: 33638
		private object _entryCreationLock;

		// Token: 0x04008367 RID: 33639
		private HashSet<string> _chattedWithPlayer;
	}
}
