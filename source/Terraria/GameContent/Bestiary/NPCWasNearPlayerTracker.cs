using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.GameContent.NetModules;
using Terraria.Net;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x0200093E RID: 2366
	public class NPCWasNearPlayerTracker : IPersistentPerWorldContent, IOnPlayerJoining
	{
		// Token: 0x06004778 RID: 18296 RVA: 0x0025E7F8 File Offset: 0x0025C9F8
		public void PrepareSamplesBasedOptimizations()
		{
		}

		// Token: 0x06004779 RID: 18297 RVA: 0x0025E808 File Offset: 0x0025CA08
		public NPCWasNearPlayerTracker()
		{
		}

		// Token: 0x0600477A RID: 18298 RVA: 0x0025E81C File Offset: 0x0025CA1C
		public void RegisterWasNearby(NPC npc)
		{
			string bestiaryCreditId = npc.GetBestiaryCreditId();
			HashSet<string> wasNearPlayer = this._wasNearPlayer;
			object entryCreationLock = this._entryCreationLock;
			HashSet<string> wasNearPlayer2 = this._wasNearPlayer;
			long num = 0L;
			Monitor.Exit(entryCreationLock);
			if (num == 0L)
			{
				bool netHost = Main.NetHost;
				int netID = npc.netID;
				NetPacket netPacket = NetBestiaryModule.SerializeSight(netID);
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600477B RID: 18299 RVA: 0x0025E888 File Offset: 0x0025CA88
		public void SetWasSeenDirectly(string persistentId)
		{
			object entryCreationLock = this._entryCreationLock;
			HashSet<string> wasNearPlayer = this._wasNearPlayer;
			long num = 0L;
			Monitor.Exit(entryCreationLock);
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600477C RID: 18300 RVA: 0x0025E8D4 File Offset: 0x0025CAD4
		public bool GetWasNearbyBefore(NPC npc)
		{
			string bestiaryCreditId = npc.GetBestiaryCreditId();
			return this.GetWasNearbyBefore(bestiaryCreditId);
		}

		// Token: 0x0600477D RID: 18301 RVA: 0x0025E8F0 File Offset: 0x0025CAF0
		public bool GetWasNearbyBefore(string persistentIdentifier)
		{
			/*
An exception occurred when decompiling this method (0600477D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Bestiary.NPCWasNearPlayerTracker::GetWasNearbyBefore(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [System.Core]System.Collections.Generic.HashSet`1<string>(var_0_06, ldfld:class [System.Core]System.Collections.Generic.HashSet`1<string>(NPCWasNearPlayerTracker::_wasNearPlayer, ldloc:NPCWasNearPlayerTracker(this)))
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

		// Token: 0x0600477E RID: 18302 RVA: 0x0025E904 File Offset: 0x0025CB04
		public void Save(BinaryWriter writer)
		{
			object entryCreationLock = this._entryCreationLock;
			int count = this._wasNearPlayer._count;
			HashSet<string> wasNearPlayer = this._wasNearPlayer;
		}

		// Token: 0x0600477F RID: 18303 RVA: 0x0025E974 File Offset: 0x0025CB74
		public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
		{
			HashSet<string> wasNearPlayer = this._wasNearPlayer;
		}

		// Token: 0x06004780 RID: 18304 RVA: 0x0025E988 File Offset: 0x0025CB88
		public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
		{
		}

		// Token: 0x06004781 RID: 18305 RVA: 0x0025E998 File Offset: 0x0025CB98
		public void Reset()
		{
			HashSet<string> wasNearPlayer = this._wasNearPlayer;
			List<Rectangle> playerHitboxesForBestiary = this._playerHitboxesForBestiary;
			int version = playerHitboxesForBestiary._version;
			playerHitboxesForBestiary._syncRoot = version;
			List<int> wasSeenNearPlayerByNetId = this._wasSeenNearPlayerByNetId;
			int version2 = wasSeenNearPlayerByNetId._version;
			wasSeenNearPlayerByNetId._syncRoot = version2;
		}

		// Token: 0x06004782 RID: 18306 RVA: 0x000021DB File Offset: 0x000003DB
		public void ScanWorldForFinds()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004783 RID: 18307 RVA: 0x0025E9D8 File Offset: 0x0025CBD8
		public void OnPlayerJoining(int playerIndex)
		{
			HashSet<string> wasNearPlayer = this._wasNearPlayer;
			if (!true)
			{
			}
			if (!true)
			{
			}
			NetPacket netPacket = NetBestiaryModule.SerializeSight(42181272);
		}

		// Token: 0x04008362 RID: 33634
		private object _entryCreationLock;

		// Token: 0x04008363 RID: 33635
		private HashSet<string> _wasNearPlayer;

		// Token: 0x04008364 RID: 33636
		private List<Rectangle> _playerHitboxesForBestiary;

		// Token: 0x04008365 RID: 33637
		private List<int> _wasSeenNearPlayerByNetId;
	}
}
