using System;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;

namespace Terraria.Cinematics
{
	// Token: 0x0200078F RID: 1935
	public class DSTFilm : Film
	{
		// Token: 0x06003F4B RID: 16203 RVA: 0x00240480 File Offset: 0x0023E680
		public DSTFilm()
		{
			this.BuildSequence();
		}

		// Token: 0x06003F4C RID: 16204 RVA: 0x0024049C File Offset: 0x0023E69C
		public override void OnBegin()
		{
			this.PrepareScene();
			if (!true)
			{
			}
			this._isActive = true;
		}

		// Token: 0x06003F4D RID: 16205 RVA: 0x002404BC File Offset: 0x0023E6BC
		public override void OnEnd()
		{
			this.ClearScene();
			if (!true)
			{
			}
		}

		// Token: 0x06003F4E RID: 16206 RVA: 0x002404D4 File Offset: 0x0023E6D4
		private void BuildSequence()
		{
			base.AppendEmptySequence(60);
			base.AppendEmptySequence(60);
			base.AppendEmptySequence(187);
			base.AppendEmptySequence(20);
			base.AppendEmptySequence(20);
			base.AppendEmptySequence(60);
		}

		// Token: 0x06003F4F RID: 16207 RVA: 0x0024051C File Offset: 0x0023E71C
		private void PrepareScene()
		{
			int num = 1;
			if (num == 0)
			{
			}
			long num2 = 39322L;
			num.m_value = (int)num2;
			if (num == 0)
			{
			}
			if (17568 == 0)
			{
			}
		}

		// Token: 0x06003F50 RID: 16208 RVA: 0x00240568 File Offset: 0x0023E768
		private void ClearScene()
		{
			if (this._deerclops != null)
			{
			}
			if (this._chester != null)
			{
			}
			Player localPlayer = Main.LocalPlayer;
		}

		// Token: 0x06003F51 RID: 16209 RVA: 0x00240590 File Offset: 0x0023E790
		private void EquipDSTShaderItem(FrameEventData evt)
		{
			if (!true)
			{
			}
			Vector2 oldVelocity = Main.LocalPlayer.armor.oldVelocity;
			this._oldItem = oldVelocity;
			Item[] armor = Main.LocalPlayer.armor;
		}

		// Token: 0x06003F52 RID: 16210 RVA: 0x002405CC File Offset: 0x0023E7CC
		private void RemoveDSTShaderItem(FrameEventData evt)
		{
			if (!true)
			{
			}
			Player localPlayer = Main.LocalPlayer;
			Item oldItem = this._oldItem;
			Item[] armor = localPlayer.armor;
			if (oldItem == null || oldItem != null)
			{
				armor.oldVelocity = oldItem;
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06003F53 RID: 16211 RVA: 0x00240608 File Offset: 0x0023E808
		private void CreateDeerclops(FrameEventData evt)
		{
			int num = 1;
			float x = this._startPoint.X;
			float y = this._startPoint.Y;
			NPC npc;
			this._deerclops = npc;
			int[] immune = npc.immune;
			int num2 = 1;
			npc.immortal = num2 != 0;
			npc.dontTakeDamage = num2 != 0;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			NPC deerclops = this._deerclops;
			float[] ai = deerclops.ai;
			float x2 = deerclops.position.X;
			deerclops.spriteDirection = num2;
			deerclops.position.X = x;
			deerclops.direction = num2;
		}

		// Token: 0x06003F54 RID: 16212 RVA: 0x002406B0 File Offset: 0x0023E8B0
		private NPC PlaceNPCOnGround(int type, Vector2 position)
		{
			/*
An exception occurred when decompiling this method (06003F54)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.NPC Terraria.Cinematics.DSTFilm::PlaceNPCOnGround(System.Int32,Microsoft.Xna.Framework.Vector2)

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

		// Token: 0x06003F55 RID: 16213 RVA: 0x002406C0 File Offset: 0x0023E8C0
		private void CreateChester(FrameEventData evt)
		{
			float x = this._startPoint.X;
			float y = this._startPoint.Y;
			int num = 17116;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
		}

		// Token: 0x06003F56 RID: 16214 RVA: 0x00240700 File Offset: 0x0023E900
		private void ControlPlayer(FrameEventData evt)
		{
			if (!true)
			{
			}
			Player localPlayer = Main.LocalPlayer;
			localPlayer.isControlledByFilm = true;
			localPlayer.controlRight = true;
			float x = this._startPoint.X;
			float y = this._startPoint.Y;
			if (17174 == 0)
			{
			}
			localPlayer.velocity = 16576;
		}

		// Token: 0x06003F57 RID: 16215 RVA: 0x00240754 File Offset: 0x0023E954
		private void StopBeforeCliff(FrameEventData evt)
		{
			if (!true)
			{
			}
			Player localPlayer = Main.LocalPlayer;
			Projectile chester = this._chester;
		}

		// Token: 0x06003F58 RID: 16216 RVA: 0x00240774 File Offset: 0x0023E974
		private void TurnPlayerToTheLeft(FrameEventData evt)
		{
			if (!true)
			{
			}
			Player localPlayer = Main.LocalPlayer;
			Projectile chester = this._chester;
			Projectile chester2 = this._chester;
			NPC deerclops = this._deerclops;
			float[] ai = deerclops.ai;
			deerclops.TargetClosest(true);
		}

		// Token: 0x06003F59 RID: 16217 RVA: 0x002407B4 File Offset: 0x0023E9B4
		private void DeerclopsAttack(FrameEventData evt)
		{
			if (!true)
			{
			}
			Main.LocalPlayer.controlJump = true;
			this._chester.velocity.Y = (float)26214;
			NPC deerclops = this._deerclops;
			float[] ai = deerclops.ai;
			deerclops.TargetClosest(true);
		}

		// Token: 0x06003F5A RID: 16218 RVA: 0x002407FC File Offset: 0x0023E9FC
		private static void FindFloorAt(Vector2 position, [Out] int x, [Out] int y)
		{
			int num = 1;
			position.X = (float)num;
			x.m_value = num;
			if (num == 0)
			{
			}
		}

		// Token: 0x04007DAA RID: 32170
		private NPC _deerclops;

		// Token: 0x04007DAB RID: 32171
		private Projectile _chester;

		// Token: 0x04007DAC RID: 32172
		private Vector2 _startPoint;

		// Token: 0x04007DAD RID: 32173
		private Item _oldItem;
	}
}
