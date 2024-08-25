using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.Cinematics
{
	// Token: 0x0200078E RID: 1934
	public class DD2Film : Film
	{
		// Token: 0x06003F2F RID: 16175 RVA: 0x0023FDE4 File Offset: 0x0023DFE4
		public DD2Film()
		{
			int nextSequenceAppendTime = this._nextSequenceAppendTime;
			int nextSequenceAppendTime2 = this._nextSequenceAppendTime;
			int nextSequenceAppendTime3 = this._nextSequenceAppendTime;
			int nextSequenceAppendTime4 = this._nextSequenceAppendTime;
			int nextSequenceAppendTime5 = this._nextSequenceAppendTime;
			int nextSequenceAppendTime6 = this._nextSequenceAppendTime;
			int nextSequenceAppendTime7 = this._nextSequenceAppendTime;
			int nextSequenceAppendTime8 = this._nextSequenceAppendTime;
			int nextSequenceAppendTime9 = this._nextSequenceAppendTime;
			int nextSequenceAppendTime10 = this._nextSequenceAppendTime;
			int nextSequenceAppendTime11 = this._nextSequenceAppendTime;
			int nextSequenceAppendTime12 = this._nextSequenceAppendTime;
			int nextSequenceAppendTime13 = this._nextSequenceAppendTime;
		}

		// Token: 0x06003F30 RID: 16176 RVA: 0x0023FE88 File Offset: 0x0023E088
		private void PerFrameSettings(FrameEventData evt)
		{
			if (!true)
			{
			}
			CombatText.clearAll();
		}

		// Token: 0x06003F31 RID: 16177 RVA: 0x0023FEA0 File Offset: 0x0023E0A0
		private void CreateDryad(FrameEventData evt)
		{
			float x = this._startPoint.X;
			float y = this._startPoint.Y;
			NPC npc;
			this._dryad = npc;
			int[] immune = npc.immune;
			npc.immortal = true;
			npc.dontTakeDamage = true;
		}

		// Token: 0x06003F32 RID: 16178 RVA: 0x0023FEE4 File Offset: 0x0023E0E4
		private void DryadInteract(FrameEventData evt)
		{
			NPC dryad = this._dryad;
			if (dryad != null)
			{
				float[] ai = dryad.ai;
				float[] localAI = dryad.localAI;
			}
		}

		// Token: 0x06003F33 RID: 16179 RVA: 0x000021DB File Offset: 0x000003DB
		private void SpawnWitherBeast(FrameEventData evt)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003F34 RID: 16180 RVA: 0x000021DB File Offset: 0x000003DB
		private void SpawnJavalinThrower(FrameEventData evt)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003F35 RID: 16181 RVA: 0x000021DB File Offset: 0x000003DB
		private void SpawnGoblin(FrameEventData evt)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003F36 RID: 16182 RVA: 0x000021DB File Offset: 0x000003DB
		private void CreateCritters(FrameEventData evt)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003F37 RID: 16183 RVA: 0x0023FF0C File Offset: 0x0023E10C
		private void OgreSwingSound(FrameEventData evt)
		{
			if (!true)
			{
			}
			Vector2 center = this._ogre.Center;
		}

		// Token: 0x06003F38 RID: 16184 RVA: 0x0023FF28 File Offset: 0x0023E128
		private void DryadPortalKnock(FrameEventData evt)
		{
			NPC dryad = this._dryad;
			if (dryad != null)
			{
				float x = dryad.velocity.X;
				dryad.velocity.X = x;
				Vector2 center = dryad.Center;
				Vector2 center2 = this._dryad.Center;
				return;
			}
			NPC ogre = this._ogre;
			if (ogre != null)
			{
				int myPlayer = Main.myPlayer;
				ogre.target = myPlayer;
				NPC ogre2 = this._ogre;
				int num = 1;
				ogre2.direction = num;
				return;
			}
		}

		// Token: 0x06003F39 RID: 16185 RVA: 0x00240010 File Offset: 0x0023E210
		private void RemoveEnemyDamage(FrameEventData evt)
		{
			NPC ogre = this._ogre;
			ogre.friendly = true;
			List<NPC> army = this._army;
			ogre.friendly = true;
		}

		// Token: 0x06003F3A RID: 16186 RVA: 0x0024004C File Offset: 0x0023E24C
		private void RestoreEnemyDamage(FrameEventData evt)
		{
			NPC ogre = this._ogre;
			List<NPC> army = this._army;
		}

		// Token: 0x06003F3B RID: 16187 RVA: 0x0024007C File Offset: 0x0023E27C
		private void DryadPortalFade(FrameEventData evt)
		{
			if (this._dryad != null && this._portal != null)
			{
				Vector2 center = this._dryad.Center;
				NPC dryad = this._dryad;
				if (!true)
				{
				}
				float num;
				this._dryad.Opacity = num;
				NPC dryad2 = this._dryad;
				float rotation = dryad2.rotation;
				NPC portal = this._portal;
				float x = dryad2.position.X;
				Vector2 right = portal.Right;
				NPC dryad3 = this._dryad;
				float x2 = dryad3.velocity.X;
				dryad3.velocity.X = x2;
				return;
			}
		}

		// Token: 0x06003F3C RID: 16188 RVA: 0x002401F8 File Offset: 0x0023E3F8
		private void CreatePortal(FrameEventData evt)
		{
			float x = this._startPoint.X;
			float y = this._startPoint.Y;
			if (50032 == 0)
			{
			}
			NPC npc;
			this._portal = npc;
			npc.immortal = true;
		}

		// Token: 0x06003F3D RID: 16189 RVA: 0x00240238 File Offset: 0x0023E438
		private void DryadStand(FrameEventData evt)
		{
			NPC dryad = this._dryad;
			if (dryad != null)
			{
				float[] ai = dryad.ai;
			}
		}

		// Token: 0x06003F3E RID: 16190 RVA: 0x00240258 File Offset: 0x0023E458
		private void DryadLookRight(FrameEventData evt)
		{
			NPC dryad = this._dryad;
			if (dryad != null)
			{
				dryad.direction = 1;
				dryad.spriteDirection = 1;
			}
		}

		// Token: 0x06003F3F RID: 16191 RVA: 0x00240280 File Offset: 0x0023E480
		private void DryadLookLeft(FrameEventData evt)
		{
			if (this._dryad != null)
			{
			}
		}

		// Token: 0x06003F40 RID: 16192 RVA: 0x00240298 File Offset: 0x0023E498
		private void DryadWalk(FrameEventData evt)
		{
			float[] ai = this._dryad.ai;
		}

		// Token: 0x06003F41 RID: 16193 RVA: 0x002402B4 File Offset: 0x0023E4B4
		private void DryadConfusedEmote(FrameEventData evt)
		{
			if (this._dryad != null)
			{
				return;
			}
		}

		// Token: 0x06003F42 RID: 16194 RVA: 0x002402CC File Offset: 0x0023E4CC
		private void DryadAlertEmote(FrameEventData evt)
		{
			if (this._dryad != null)
			{
				return;
			}
		}

		// Token: 0x06003F43 RID: 16195 RVA: 0x002402E4 File Offset: 0x0023E4E4
		private void CreateOgre(FrameEventData evt)
		{
			int num = 1;
			Vector2 center = this._portal.Center;
			Vector2 bottom = this._portal.Bottom;
			if (num == 0)
			{
			}
			if (32640 == 0)
			{
			}
		}

		// Token: 0x06003F44 RID: 16196 RVA: 0x00240328 File Offset: 0x0023E528
		private void OgreStand(FrameEventData evt)
		{
			NPC ogre = this._ogre;
			if (ogre != null)
			{
				if (ogre.ai == null)
				{
				}
				if (!true)
				{
				}
				ogre.velocity = 1;
			}
		}

		// Token: 0x06003F45 RID: 16197 RVA: 0x00240354 File Offset: 0x0023E554
		private void DryadAttack(FrameEventData evt)
		{
			NPC dryad = this._dryad;
			if (dryad != null)
			{
				float[] ai = dryad.ai;
			}
		}

		// Token: 0x06003F46 RID: 16198 RVA: 0x00240378 File Offset: 0x0023E578
		private void OgreLookRight(FrameEventData evt)
		{
			NPC ogre = this._ogre;
			if (ogre != null)
			{
				ogre.direction = 1;
				ogre.spriteDirection = 1;
			}
		}

		// Token: 0x06003F47 RID: 16199 RVA: 0x002403A0 File Offset: 0x0023E5A0
		private void OgreLookLeft(FrameEventData evt)
		{
			if (this._ogre != null)
			{
			}
		}

		// Token: 0x06003F48 RID: 16200 RVA: 0x002403B8 File Offset: 0x0023E5B8
		public override void OnBegin()
		{
			if (!true)
			{
			}
			Vector2 screenPosition = Main.screenPosition;
			int mouseX = Main.mouseX;
			int mouseY = Main.mouseY;
			if (49664 == 0)
			{
			}
			this._isActive = true;
		}

		// Token: 0x06003F49 RID: 16201 RVA: 0x002403F4 File Offset: 0x0023E5F4
		private NPC PlaceNPCOnGround(int type, Vector2 position)
		{
			/*
An exception occurred when decompiling this method (06003F49)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.NPC Terraria.Cinematics.DD2Film::PlaceNPCOnGround(System.Int32,Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0017:
	brtrue(IL_0000, ldloc:int32[exp:bool](var_3_13))
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

		// Token: 0x06003F4A RID: 16202 RVA: 0x0024041C File Offset: 0x0023E61C
		public override void OnEnd()
		{
			if (this._dryad != null)
			{
			}
			if (this._portal != null)
			{
			}
			NPC ogre = this._ogre;
			if (ogre != null)
			{
			}
			List<NPC> critters = this._critters;
		}

		// Token: 0x04007DA4 RID: 32164
		private NPC _dryad;

		// Token: 0x04007DA5 RID: 32165
		private NPC _ogre;

		// Token: 0x04007DA6 RID: 32166
		private NPC _portal;

		// Token: 0x04007DA7 RID: 32167
		private List<NPC> _army;

		// Token: 0x04007DA8 RID: 32168
		private List<NPC> _critters;

		// Token: 0x04007DA9 RID: 32169
		private Vector2 _startPoint;
	}
}
