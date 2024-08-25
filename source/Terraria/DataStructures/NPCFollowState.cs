using System;
using System.IO;
using Microsoft.Xna.Framework;

namespace Terraria.DataStructures
{
	// Token: 0x02000639 RID: 1593
	public class NPCFollowState
	{
		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06003639 RID: 13881 RVA: 0x002126AC File Offset: 0x002108AC
		public Vector2 BreadcrumbPosition
		{
			get
			{
				float x = this._floorBreadcrumb.X;
				float y = this._floorBreadcrumb.Y;
				Vector2 vector;
				return vector;
			}
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x0600363A RID: 13882 RVA: 0x002126D4 File Offset: 0x002108D4
		public bool IsFollowingPlayer
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600363A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.DataStructures.NPCFollowState::get_IsFollowingPlayer()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:valuetype [mscorlib]System.Nullable`1<int32>(var_0_06, ldfld:valuetype [mscorlib]System.Nullable`1<int32>(NPCFollowState::_playerIndexBeingFollowed, ldloc:NPCFollowState(this)))
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
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x0600363B RID: 13883 RVA: 0x002126E8 File Offset: 0x002108E8
		public Player PlayerBeingFollowed
		{
			get
			{
				int? playerIndexBeingFollowed = this._playerIndexBeingFollowed;
				if (playerIndexBeingFollowed == null || playerIndexBeingFollowed == null)
				{
					return;
				}
			}
		}

		// Token: 0x0600363C RID: 13884 RVA: 0x00212704 File Offset: 0x00210904
		public void FollowPlayer(int playerIndex)
		{
			int num = 1;
			this._playerIndexBeingFollowed = num;
			if (num == 0)
			{
			}
			NPC npc = this._npc;
			int num2 = 1;
			npc.netUpdate = num2 != 0;
		}

		// Token: 0x0600363D RID: 13885 RVA: 0x00212730 File Offset: 0x00210930
		public void StopFollowing()
		{
			NPC npc = this._npc;
			float[] ai = npc.ai;
			npc.netUpdate = true;
		}

		// Token: 0x0600363E RID: 13886 RVA: 0x00212754 File Offset: 0x00210954
		public void Clear(NPC npcToBelongTo)
		{
			this._npc = npcToBelongTo;
		}

		// Token: 0x0600363F RID: 13887 RVA: 0x00212768 File Offset: 0x00210968
		private bool ShouldSync()
		{
			return this._npc.isLikeATownNPC;
		}

		// Token: 0x06003640 RID: 13888 RVA: 0x00212780 File Offset: 0x00210980
		public void WriteTo(BinaryWriter writer)
		{
			if (this._playerIndexBeingFollowed != null)
			{
				return;
			}
		}

		// Token: 0x06003641 RID: 13889 RVA: 0x00212798 File Offset: 0x00210998
		public void ReadFrom(BinaryReader reader)
		{
		}

		// Token: 0x06003642 RID: 13890 RVA: 0x002127A8 File Offset: 0x002109A8
		private void MoveNPCBackHome()
		{
			NPC npc = this._npc;
			float[] ai = npc.ai;
			npc.netUpdate = true;
		}

		// Token: 0x06003643 RID: 13891 RVA: 0x002127CC File Offset: 0x002109CC
		public void Update()
		{
			if (this._playerIndexBeingFollowed != null)
			{
				Player playerBeingFollowed = this.PlayerBeingFollowed;
				NPC npc;
				if (playerBeingFollowed.active && !playerBeingFollowed.dead)
				{
					this.UpdateBreadcrumbs(playerBeingFollowed);
					float x = this._floorBreadcrumb.X;
					float y = this._floorBreadcrumb.Y;
					if (npc == null)
					{
					}
					if (!true)
					{
					}
					return;
				}
				npc = this._npc;
				float[] ai = npc.ai;
				npc.netUpdate = true;
			}
		}

		// Token: 0x06003644 RID: 13892 RVA: 0x00212834 File Offset: 0x00210A34
		private void UpdateBreadcrumbs(Player player)
		{
			float y = player.velocity.Y;
			float gravDir = player.gravDir;
			Vector2 bottom = player.Bottom;
			if (true)
			{
				float x = this._floorBreadcrumb.X;
				float y2 = this._floorBreadcrumb.Y;
				if (!true)
				{
				}
				NPC npc = this._npc;
				this._floorBreadcrumb.X = gravDir;
				npc.netUpdate = true;
			}
		}

		// Token: 0x06003645 RID: 13893 RVA: 0x0021289C File Offset: 0x00210A9C
		public NPCFollowState()
		{
		}

		// Token: 0x040076FB RID: 30459
		private NPC _npc;

		// Token: 0x040076FC RID: 30460
		private int? _playerIndexBeingFollowed;

		// Token: 0x040076FD RID: 30461
		private Vector2 _floorBreadcrumb;
	}
}
