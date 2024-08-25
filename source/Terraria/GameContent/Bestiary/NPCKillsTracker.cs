using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Terraria.GameContent.NetModules;
using Terraria.Net;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x0200093D RID: 2365
	public class NPCKillsTracker : IPersistentPerWorldContent, IOnPlayerJoining
	{
		// Token: 0x0600476E RID: 18286 RVA: 0x0025E620 File Offset: 0x0025C820
		public NPCKillsTracker()
		{
		}

		// Token: 0x0600476F RID: 18287 RVA: 0x0025E634 File Offset: 0x0025C834
		public void RegisterKill(NPC npc)
		{
			string bestiaryCreditId = npc.GetBestiaryCreditId();
			Dictionary<string, int> killCountsByNpcId = this._killCountsByNpcId;
			object entryCreationLock = this._entryCreationLock;
			Dictionary<string, int> killCountsByNpcId2 = this._killCountsByNpcId;
			long num = 0L;
			long num2 = 0L;
			Monitor.Exit(entryCreationLock);
			if (num == 0L)
			{
				bool netHost = Main.NetHost;
				NetPacket netPacket = NetBestiaryModule.SerializeKillCount(npc.netID, (int)num2);
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06004770 RID: 18288 RVA: 0x0025E6A0 File Offset: 0x0025C8A0
		public int GetKillCount(NPC npc)
		{
			string bestiaryCreditId = npc.GetBestiaryCreditId();
			return this.GetKillCount(bestiaryCreditId);
		}

		// Token: 0x06004771 RID: 18289 RVA: 0x0025E6BC File Offset: 0x0025C8BC
		public void SetKillCountDirectly(string persistentId, int killCount)
		{
			object entryCreationLock = this._entryCreationLock;
			Dictionary<string, int> killCountsByNpcId = this._killCountsByNpcId;
			long num = 0L;
			Monitor.Exit(entryCreationLock);
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06004772 RID: 18290 RVA: 0x0025E708 File Offset: 0x0025C908
		public int GetKillCount(string persistentId)
		{
			/*
An exception occurred when decompiling this method (06004772)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.GameContent.Bestiary.NPCKillsTracker::GetKillCount(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<string, int32>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<string, int32>(NPCKillsTracker::_killCountsByNpcId, ldloc:NPCKillsTracker(this)))
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

		// Token: 0x06004773 RID: 18291 RVA: 0x0025E71C File Offset: 0x0025C91C
		public void Save(BinaryWriter writer)
		{
			Dictionary<string, int> killCountsByNpcId = this._killCountsByNpcId;
			Dictionary<string, int> killCountsByNpcId2 = this._killCountsByNpcId;
			Dictionary<string, int> killCountsByNpcId3 = this._killCountsByNpcId;
		}

		// Token: 0x06004774 RID: 18292 RVA: 0x0025E788 File Offset: 0x0025C988
		public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
		{
			Dictionary<string, int> killCountsByNpcId = this._killCountsByNpcId;
		}

		// Token: 0x06004775 RID: 18293 RVA: 0x0025E79C File Offset: 0x0025C99C
		public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
		{
		}

		// Token: 0x06004776 RID: 18294 RVA: 0x0025E7AC File Offset: 0x0025C9AC
		public void Reset()
		{
			Dictionary<string, int> killCountsByNpcId = this._killCountsByNpcId;
		}

		// Token: 0x06004777 RID: 18295 RVA: 0x0025E7C0 File Offset: 0x0025C9C0
		public void OnPlayerJoining(int playerIndex)
		{
			Dictionary<string, int> killCountsByNpcId = this._killCountsByNpcId;
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x0400835F RID: 33631
		private object _entryCreationLock;

		// Token: 0x04008360 RID: 33632
		public const int POSITIVE_KILL_COUNT_CAP = 999999999;

		// Token: 0x04008361 RID: 33633
		private Dictionary<string, int> _killCountsByNpcId;
	}
}
