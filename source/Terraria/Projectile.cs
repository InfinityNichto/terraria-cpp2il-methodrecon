using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Utilities;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.Graphics;
using Terraria.Localization;
using Terraria.WorldBuilding;
using Unity.IL2CPP.CompilerServices;

namespace Terraria
{
	// Token: 0x0200041D RID: 1053
	public class Projectile : Entity
	{
		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06002608 RID: 9736 RVA: 0x0014C0C8 File Offset: 0x0014A2C8
		public string Name
		{
			get
			{
				int num = this.type;
				if (!true)
				{
				}
				return Lang.GetProjectileName(num).<Value>k__BackingField;
			}
		}

		// Token: 0x06002609 RID: 9737 RVA: 0x0014C0EC File Offset: 0x0014A2EC
		public static void InitializeStaticThings()
		{
		}

		// Token: 0x0600260A RID: 9738 RVA: 0x0014C0FC File Offset: 0x0014A2FC
		public static void ResetImmunity()
		{
			if (!true)
			{
			}
		}

		// Token: 0x0600260B RID: 9739 RVA: 0x0014C10C File Offset: 0x0014A30C
		public static bool IsNPCIndexImmuneToProjectileType(int projectileType, int npcIndex)
		{
			/*
An exception occurred when decompiling this method (0600260B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Projectile::IsNPCIndexImmuneToProjectileType(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000A:
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

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x0600260C RID: 9740 RVA: 0x0014C128 File Offset: 0x0014A328
		public bool WipableTurret
		{
			get
			{
				int num = this.owner;
				if (!true)
				{
				}
				int myPlayer = Main.myPlayer;
				bool flag;
				if (this.sentry)
				{
					flag = this.TurretShouldPersist();
					return flag;
				}
				return flag;
			}
		}

		// Token: 0x0600260D RID: 9741 RVA: 0x0014C15C File Offset: 0x0014A35C
		public bool TurretShouldPersist()
		{
			/*
An exception occurred when decompiling this method (0600260D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Projectile::TurretShouldPersist()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:int32[exp:bool](Projectile::type, ldloc:Projectile(this)))
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

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x0600260E RID: 9742 RVA: 0x0014C170 File Offset: 0x0014A370
		// (set) Token: 0x0600260F RID: 9743 RVA: 0x0014C184 File Offset: 0x0014A384
		public float Opacity
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600260E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Projectile::get_Opacity()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Projectile::alpha, ldloc:Projectile(this)))
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
			set
			{
				this.alpha = 32768;
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06002610 RID: 9744 RVA: 0x0014C1A0 File Offset: 0x0014A3A0
		// (set) Token: 0x06002611 RID: 9745 RVA: 0x0014C1B4 File Offset: 0x0014A3B4
		public int MaxUpdates
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002610)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.Projectile::get_MaxUpdates()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Projectile::extraUpdates, ldloc:Projectile(this)))
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
			set
			{
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06002612 RID: 9746 RVA: 0x0014C1C4 File Offset: 0x0014A3C4
		public NPC OwnerMinionAttackTargetNPC
		{
			get
			{
				if (!true)
				{
					return;
				}
			}
		}

		// Token: 0x06002613 RID: 9747 RVA: 0x0014C1D8 File Offset: 0x0014A3D8
		public void SetDefaults(int Type)
		{
			int num = 17530;
			this.ownerHitCheckDistance = (float)num;
			this.localNPCHitCooldown = (int)(-2f);
			if (num == 0)
			{
			}
		}

		// Token: 0x06002614 RID: 9748 RVA: 0x00153C14 File Offset: 0x00151E14
		public void DefaultToSpray()
		{
			this.aiStyle = 31;
			this.friendly = true;
			this.alpha = 255;
			this.extraUpdates = 2;
			this.ignoreWater = true;
		}

		// Token: 0x06002615 RID: 9749 RVA: 0x00153C4C File Offset: 0x00151E4C
		public void DefaultToWhip()
		{
			this.aiStyle = 165;
			this.friendly = true;
			this.scale = (float)16256;
			this.ownerHitCheck = true;
			this.extraUpdates = 1;
			this.usesLocalNPCImmunity = true;
		}

		// Token: 0x06002616 RID: 9750 RVA: 0x00153C8C File Offset: 0x00151E8C
		public static int GetNextSlot()
		{
			int num;
			do
			{
				num = 1;
				if (num == 0)
				{
				}
			}
			while (num == 0);
			return 1000;
		}

		// Token: 0x06002617 RID: 9751 RVA: 0x00153CA8 File Offset: 0x00151EA8
		public static int NewProjectile(IEntitySource spawnSource, Vector2 position, Vector2 velocity, int Type, int Damage, float KnockBack, int Owner = -1, float ai0 = 0f, float ai1 = 0f, float ai2 = 0f)
		{
			if (!true)
			{
			}
			int num;
			return num;
		}

		// Token: 0x06002618 RID: 9752 RVA: 0x00153CBC File Offset: 0x00151EBC
		public static int FindOldestProjectile()
		{
			int num = 1;
			int num2 = 1000;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
			}
			return num2;
		}

		// Token: 0x06002619 RID: 9753 RVA: 0x00153CE8 File Offset: 0x00151EE8
		public static int NewProjectile(IEntitySource spawnSource, float X, float Y, float SpeedX, float SpeedY, int Type, int Damage, float KnockBack, int Owner = -1, float ai0 = 0f, float ai1 = 0f, float ai2 = 0f)
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
			int num = Projectile.FindOldestProjectile();
			int myPlayer2 = Main.myPlayer;
			int num2;
			return num2;
		}

		// Token: 0x0600261A RID: 9754 RVA: 0x00153DB4 File Offset: 0x00151FB4
		private static void FindBannerToAssociateTo(IEntitySource spawnSource, Projectile next)
		{
			if (spawnSource != null)
			{
			}
		}

		// Token: 0x0600261B RID: 9755 RVA: 0x00153DD4 File Offset: 0x00151FD4
		public static Color GetGolfTrailColor(Projectile proj)
		{
			/*
An exception occurred when decompiling this method (0600261B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Color Terraria.Projectile::GetGolfTrailColor(Terraria.Projectile)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Projectile::type, ldloc:Projectile(proj)))
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

		// Token: 0x0600261C RID: 9756 RVA: 0x00153DFC File Offset: 0x00151FFC
		public void StatusNPC(int i)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (!this.melee)
			{
				if (num == 0)
				{
				}
				if (num == 0)
				{
					goto IL_008B;
				}
			}
			if (num == 0)
			{
			}
			if (num != 0)
			{
				bool flag = this.noEnchantments;
				if (!flag)
				{
					if (!flag)
					{
					}
					return;
				}
			}
			IL_008B:
			if (this.type == 0)
			{
			}
		}

		// Token: 0x0600261D RID: 9757 RVA: 0x00154474 File Offset: 0x00152674
		public void StatusPvP(int i)
		{
			bool flag = this.melee;
			if (!flag)
			{
				if (!flag)
				{
				}
				if (!flag)
				{
					goto IL_0056;
				}
			}
			if (!flag)
			{
			}
			bool flag2 = this.noEnchantments;
			if (!flag2)
			{
				if (!flag2)
				{
				}
				return;
			}
			IL_0056:
			if (this.type == 0)
			{
			}
			if (this.type == 0)
			{
			}
			if (this.type == 0)
			{
			}
			if (this.type == 0)
			{
			}
			bool flag3;
			if (!this.melee)
			{
				flag3 = this.ranged;
				if (!flag3)
				{
					goto IL_00F6;
				}
			}
			if (!flag3)
			{
			}
			bool flag4 = this.noEnchantments;
			if (!flag4)
			{
				if (!flag4)
				{
				}
			}
			IL_00F6:
			bool flag5 = this.melee;
			if (flag5)
			{
				if (!flag5)
				{
				}
				if (flag5)
				{
					bool flag6 = this.noEnchantments;
					if (!flag6)
					{
						if (!flag6)
						{
						}
						if (flag4)
						{
							int num;
							if (num != 0)
							{
								if (!flag4)
								{
								}
								int num2;
								if (num2 != 0)
								{
									return;
								}
								goto IL_0147;
							}
						}
						else
						{
							int num2;
							while (num2 != 0)
							{
							}
						}
						return;
					}
				}
			}
			IL_0147:
			int num3 = this.type;
			if (num3 == 0)
			{
			}
			int num4;
			if (num4 == 0)
			{
				if (num3 == 0)
				{
				}
			}
			if (this.type == 0)
			{
			}
		}

		// Token: 0x0600261E RID: 9758 RVA: 0x001546DC File Offset: 0x001528DC
		public void ghostHurt(int dmg, Vector2 Position, Entity victim)
		{
			if (this.magic)
			{
				int num = this.damage;
				if (num == 0)
				{
				}
				int myPlayer = Main.myPlayer;
				if (num == 0)
				{
				}
				int myPlayer2 = Main.myPlayer;
				float x = this.position.X;
				int width = this.width;
				int height = this.height;
				float y = this.position.Y;
				float x2 = this.position.X;
				if (height == 0)
				{
				}
				return;
			}
		}

		// Token: 0x0600261F RID: 9759 RVA: 0x00154790 File Offset: 0x00152990
		public void ghostHeal(int dmg, Vector2 Position, Entity victim)
		{
			int num = this.numHits;
			int num2 = 32640;
			if (num2 == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			if (num2 == 0)
			{
			}
			int myPlayer2 = Main.myPlayer;
			if (this.magic)
			{
				int num3 = this.owner;
				return;
			}
		}

		// Token: 0x06002620 RID: 9760 RVA: 0x001547DC File Offset: 0x001529DC
		public void vampireHeal(int dmg, Vector2 Position, Entity victim)
		{
			int num = 32640;
			if (num != 0)
			{
				if (num == 0)
				{
				}
				int myPlayer = Main.myPlayer;
				if (num == 0)
				{
				}
				int myPlayer2 = Main.myPlayer;
				int num2 = this.owner;
				int num3 = this.owner;
				return;
			}
		}

		// Token: 0x06002621 RID: 9761 RVA: 0x0015481C File Offset: 0x00152A1C
		public void StatusPlayer(int i)
		{
			if (!true)
			{
			}
			if (this.type == 0)
			{
			}
			bool expertMode = Main.expertMode;
		}

		// Token: 0x06002622 RID: 9762 RVA: 0x00154C48 File Offset: 0x00152E48
		public bool CanHitWithMeleeWeapon(Entity ent)
		{
			int num = 1;
			Vector2 center = ent.Center;
			float num2 = this.ownerHitCheckDistance;
			if (num == 0)
			{
			}
			float x = ent.position.X;
			float y = ent.position.Y;
			int width = ent.width;
			bool wet = ent.wet;
			if (num == 0)
			{
			}
			Vector2 center2 = ent.Center;
			int height = ent.height;
			if (height == 0)
			{
			}
			if (height == 0)
			{
			}
			Vector2 center3 = ent.Center;
			Vector2 center4 = ent.Center;
			bool flag;
			return flag;
		}

		// Token: 0x06002623 RID: 9763 RVA: 0x00154CE0 File Offset: 0x00152EE0
		public bool CanHitWithOwnBody(Entity ent)
		{
			int num = 1;
			Vector2 center = ent.Center;
			float num2 = this.ownerHitCheckDistance;
			float x = this.position.X;
			float y = this.position.Y;
			int width = this.width;
			bool wet = this.wet;
			float x2 = ent.position.X;
			float y2 = ent.position.Y;
			int width2 = ent.width;
			bool wet2 = ent.wet;
			if (num == 0)
			{
			}
			Vector2 center2 = base.Center;
			int direction = this.direction;
			int height = this.height;
			int height2 = this.height;
			if (direction == 0)
			{
			}
			Vector2 center3 = ent.Center;
			if (ent.height == 0)
			{
			}
			Vector2 center4 = base.Center;
			int direction2 = this.direction;
			int height3 = this.height;
			int height4 = this.height;
			int num3 = 21846;
			if (direction2 == 0)
			{
			}
			Vector2 center5 = ent.Center;
			if (direction2 == 0)
			{
			}
			if (direction2 == 0)
			{
			}
			if (height4 == 0)
			{
			}
			Vector2 top = base.Top;
			Vector2 top2 = ent.Top;
			if (width2 != 0)
			{
				Vector2 top3 = base.Top;
				if (num3 == 0)
				{
				}
				if ((width != 0 && width == 0) || (width != 0 && width == 0))
				{
					throw new ArrayTypeMismatchException();
				}
				Point point;
				float num4;
				Vector2 vector = point.ToWorldCoordinates(num4, num4);
				Vector2 top4 = ent.Top;
				if (num3 == 0)
				{
				}
				Point point2;
				Vector2 vector2 = point2.ToWorldCoordinates(num4, num4);
			}
			bool flag;
			return flag;
		}

		// Token: 0x06002624 RID: 9764 RVA: 0x00154E58 File Offset: 0x00153058
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		public void Damage()
		{
			int num = this.type;
			int num2 = this.aiStyle;
		}

		// Token: 0x06002625 RID: 9765 RVA: 0x00156888 File Offset: 0x00154A88
		private Rectangle Damage_GetHitbox()
		{
			/*
An exception occurred when decompiling this method (06002625)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Rectangle Terraria.Projectile::Damage_GetHitbox()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0045:
	stloc:int32(var_13_51, ldfld:int32(Projectile::type, ldloc:Projectile(this)))
	stloc:int32(var_16_61, ldfld:int32(Projectile::aiStyle, ldloc:Projectile(this)))
	stloc:int32(var_19_6F, ldfld:int32(Projectile::type, ldloc:Projectile(this)))
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

		// Token: 0x06002626 RID: 9766 RVA: 0x00156910 File Offset: 0x00154B10
		private void BombsHurtPlayers(Rectangle projRectangle, int j)
		{
			if (this.aiStyle == 0)
			{
			}
		}

		// Token: 0x06002627 RID: 9767 RVA: 0x001569F0 File Offset: 0x00154BF0
		public bool IsDamageDodgable()
		{
			/*
An exception occurred when decompiling this method (06002627)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Projectile::IsDamageDodgable()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Projectile::type, ldloc:Projectile(this)))
	stloc:int32(var_1_0D, ldfld:int32(Projectile::damage, ldloc:Projectile(this)))
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

		// Token: 0x06002628 RID: 9768 RVA: 0x00156A18 File Offset: 0x00154C18
		public static void KillOldestJavelin(int protectedProjectileIndex, int projectileType, int targetNPCIndex, Point[] bufferForScan)
		{
			if (!false)
			{
			}
			int myPlayer = Main.myPlayer;
		}

		// Token: 0x06002629 RID: 9769 RVA: 0x00156A48 File Offset: 0x00154C48
		private int CountEnemiesWhoAreImmuneToMeRightNow(int cap)
		{
			int num;
			return num;
		}

		// Token: 0x0600262A RID: 9770 RVA: 0x00156A58 File Offset: 0x00154C58
		private static void EmitBlackLightningParticles(NPC targetNPC)
		{
			Vector2 center = targetNPC.Center;
			if (!true)
			{
			}
		}

		// Token: 0x0600262B RID: 9771 RVA: 0x00156A74 File Offset: 0x00154C74
		private void TryDoingOnHitEffects(Entity entity)
		{
			int num = this.type;
		}

		// Token: 0x0600262C RID: 9772 RVA: 0x00156A9C File Offset: 0x00154C9C
		private void SummonSuperStarSlash(Vector2 target)
		{
			if (!true)
			{
			}
			if (17224 == 0)
			{
			}
			if (!true)
			{
			}
			IEntitySource projectileSource_FromThis = this.GetProjectileSource_FromThis();
			int num = this.damage;
			int num2 = this.owner;
		}

		// Token: 0x0600262D RID: 9773 RVA: 0x00156AD8 File Offset: 0x00154CD8
		private void SummonMonkGhast()
		{
			if (17530 == 0)
			{
			}
		}

		// Token: 0x0600262E RID: 9774 RVA: 0x00156B68 File Offset: 0x00154D68
		private void CutTiles()
		{
			bool flag = this.CanCutTiles();
			int num = 1;
			bool flag2 = this.trap;
			if (num == 0)
			{
			}
			int num2 = this.type;
			Vector2 center = base.Center;
			Vector2 center2 = base.Center;
			float x = this.velocity.X;
			float y = this.velocity.Y;
			if (num2 == 0)
			{
			}
			int width = this.width;
			float num3 = this.scale;
			if (num2 == 0)
			{
			}
			float x2 = this.position.X;
			float y2 = this.position.Y;
			int width2 = this.width;
			bool wet = this.wet;
		}

		// Token: 0x0600262F RID: 9775 RVA: 0x00156F00 File Offset: 0x00155100
		private void CutTilesAt(Vector2 boxPosition, int boxWidth, int boxHeight)
		{
			int num = 15744;
			int num2 = 32640;
			int num3 = 32768;
			if (num == 0)
			{
			}
			if (num2 != 0)
			{
				return;
			}
			if (num == 0)
			{
			}
			if (num2 == 0)
			{
			}
			if (num == 0)
			{
			}
			bool flag = this.trap;
			if (num3 == 0)
			{
			}
		}

		// Token: 0x06002630 RID: 9776 RVA: 0x00156F40 File Offset: 0x00155140
		private bool CanCutTiles()
		{
			if (this.aiStyle == 0)
			{
				return;
			}
		}

		// Token: 0x06002631 RID: 9777 RVA: 0x00156F58 File Offset: 0x00155158
		public bool Colliding(Rectangle myRect, Rectangle targetRect)
		{
			int num = 1;
			int num2 = this.aiStyle;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Vector2 vector;
			float num3 = vector.Length();
			int num4 = this.type;
			Vector2 center = base.Center;
			if (num4 == 0)
			{
			}
			Vector2 center2 = base.Center;
			if (num4 == 0)
			{
			}
			if (!true)
			{
			}
			float num5 = this.scale;
			Vector2 vector2;
			float num6 = vector2.Length();
			Vector2 center3 = base.Center;
			if (num2 == 0)
			{
			}
			Point point;
			Vector2 vector3 = point.ToVector2();
			bool flag;
			return flag;
		}

		// Token: 0x06002632 RID: 9778 RVA: 0x00157608 File Offset: 0x00155808
		public void ProjLight()
		{
			float num = this.light;
			int num2 = this.type;
		}

		// Token: 0x06002633 RID: 9779 RVA: 0x00157714 File Offset: 0x00155914
		public Rectangle getRect()
		{
			/*
An exception occurred when decompiling this method (06002633)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Rectangle Terraria.Projectile::getRect()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_0B, ldfld:float32(Vector2::X, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](Entity::position, ldloc:Projectile[exp:Entity](this))))
	stloc:float32(var_1_17, ldfld:float32(Vector2::Y, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](Entity::position, ldloc:Projectile[exp:Entity](this))))
	stloc:int32(var_2_1E, ldfld:int32(Entity::width, ldloc:Projectile[exp:Entity](this)))
	stloc:bool(var_3_25, ldfld:bool(Entity::wet, ldloc:Projectile[exp:Entity](this)))
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

		// Token: 0x06002634 RID: 9780 RVA: 0x00157748 File Offset: 0x00155948
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		public void Update(int i)
		{
			if (this.active)
			{
				if (this.type == 0)
				{
				}
				return;
			}
		}

		// Token: 0x06002635 RID: 9781 RVA: 0x001586F8 File Offset: 0x001568F8
		private bool AutomaticallyChangesDirection()
		{
			/*
An exception occurred when decompiling this method (06002635)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Projectile::AutomaticallyChangesDirection()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	stloc:int32(var_0_06, ldfld:int32(Projectile::aiStyle, ldloc:Projectile(this)))
	stloc:int32(var_3_0F, ldfld:int32(Projectile::aiStyle, ldloc:Projectile(this)))
	stloc:int32(var_6_19, ldfld:int32(Projectile::aiStyle, ldloc:Projectile(this)))
	stloc:int32(var_9_24, ldfld:int32(Projectile::aiStyle, ldloc:Projectile(this)))
	brtrue(IL_0000, ldfld:bool(Projectile::manualDirectionChange, ldloc:Projectile(this)))
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

		// Token: 0x06002636 RID: 9782 RVA: 0x00158738 File Offset: 0x00156938
		private void UpdateEnchantmentVisuals()
		{
			if (!this.npcProj)
			{
				int num = this.aiStyle;
				Vector2 center = base.Center;
				float num2 = this.rotation;
				float num3 = this.scale;
				float num4 = this.scale;
				Rectangle rectangle;
				Vector2 vector = rectangle.TopLeft();
				return;
			}
		}

		// Token: 0x06002637 RID: 9783 RVA: 0x0015880C File Offset: 0x00156A0C
		public void EmitEnchantmentVisualsAt(Vector2 boxPosition, int boxWidth, int boxHeight)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0 && (this.melee || this.ranged) && this.friendly && !this.hostile)
			{
				bool flag = this.noEnchantments;
				if (!flag)
				{
					if (!flag)
					{
					}
					int num2 = this.extraUpdates;
					int num3;
					if (num3 == 0)
					{
						int direction = this.direction;
						float x = this.velocity.X;
						float y = this.velocity.Y;
						if (num2 == 0)
						{
						}
						if (!true)
						{
						}
					}
				}
			}
			bool flag2 = this.melee;
			bool flag4;
			if (flag2)
			{
				if (flag2)
				{
					bool flag3 = this.noEnchantments;
					if (!flag3)
					{
						if (!flag3)
						{
						}
						int num4;
						if (num4 != 0)
						{
							float x2 = this.velocity.X;
							float y2 = this.velocity.Y;
							if (!flag3)
							{
							}
							int num5;
							if (num5 == 0)
							{
							}
						}
					}
				}
				flag4 = this.melee;
				if (flag4)
				{
					goto IL_00CA;
				}
			}
			if (!flag4)
			{
			}
			if (!flag4)
			{
				return;
			}
			IL_00CA:
			if (flag4)
			{
				bool flag5 = this.noEnchantments;
				if (!flag5)
				{
					if (!flag4)
					{
					}
					int num6;
					int num7;
					int num8;
					if (num6 == 0)
					{
						if (!flag4)
						{
						}
						if (!flag5)
						{
						}
						num7 = 16320;
						num8 = 1;
						if (num8 == 0)
						{
						}
					}
					if (num8 == 0)
					{
					}
					int num9;
					while (num9 != 0)
					{
					}
					if (num8 == 0)
					{
					}
					if (num7 == 0)
					{
					}
					if (!true)
					{
					}
					return;
				}
			}
		}

		// Token: 0x06002638 RID: 9784 RVA: 0x000021DB File Offset: 0x000003DB
		private void HandleMovement(Vector2 wetVelocity, [Out] int overrideWidth, [Out] int overrideHeight)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002639 RID: 9785 RVA: 0x001589F4 File Offset: 0x00156BF4
		private void LightDisc_Bounce(Vector2 hitPoint, Vector2 normal)
		{
			float x = this.velocity.X;
			float y = this.velocity.Y;
			if (!true)
			{
			}
			Dust dust;
			Color color;
			dust.color = color;
			Dust dust2 = Dust.CloneDust(dust);
			dust2.scale = (float)16256;
			dust2.frame = 50;
		}

		// Token: 0x0600263A RID: 9786 RVA: 0x000021DB File Offset: 0x000003DB
		private void AI_149_GolfBall()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600263B RID: 9787 RVA: 0x00158A54 File Offset: 0x00156C54
		private void MakeBoulderOfEarthExplosion()
		{
			int num = 16928;
			float y = this.velocity.Y;
			if (num == 0)
			{
			}
		}

		// Token: 0x0600263C RID: 9788 RVA: 0x00158AE0 File Offset: 0x00156CE0
		private void UpdatePosition(Vector2 wetVelocity)
		{
			int num = this.aiStyle;
		}

		// Token: 0x0600263D RID: 9789 RVA: 0x00158BB8 File Offset: 0x00156DB8
		public void FishingCheck()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				Vector2 center = base.Center;
				if (num == 0)
				{
				}
			}
			Vector2 center2 = base.Center;
			int num2 = 32640;
			Vector2 center3 = base.Center;
			int num3 = this.type;
			if (num2 == 0)
			{
			}
			if (num3 == 0)
			{
			}
			if (num3 != 0)
			{
				if (num3 == 0)
				{
				}
				int num4;
				if (num4 == 0)
				{
				}
			}
			if (num3 == 0)
			{
			}
			if (num3 == 0)
			{
			}
			string textValue = Language.GetTextValue("GameUI.FishingWarning");
			if (num3 == 0)
			{
			}
			int num5 = 370;
			bool flag = NPC.AnyNPCs(num5);
			int num6 = 1;
			this.netUpdate = num6 != 0;
		}

		// Token: 0x0600263E RID: 9790 RVA: 0x00158DAC File Offset: 0x00156FAC
		private void FishingCheck_RollEnemySpawns(FishingAttempt fisher)
		{
			if (!fisher.inLava)
			{
				bool inHoney = fisher.inHoney;
				if (!inHoney)
				{
					if (!inHoney)
					{
					}
					while (inHoney)
					{
					}
					int num;
					while (num != 0)
					{
					}
					if (3 == 0)
					{
					}
					if (3 == 0)
					{
						if (3 == 0)
						{
						}
						int num2;
						if (num2 == 0)
						{
							fisher.rolledEnemySpawn = 682;
							return;
						}
					}
					if (3 != 0)
					{
						return;
					}
					if (!true)
					{
					}
					if (3 == 0)
					{
					}
					fisher.rolledEnemySpawn = 3;
					int num3;
					while (num3 != 0)
					{
					}
					return;
				}
			}
		}

		// Token: 0x0600263F RID: 9791 RVA: 0x00158E0C File Offset: 0x0015700C
		private void FishingCheck_RollItemDrop(FishingAttempt fisher)
		{
			if (!true)
			{
			}
			int num;
			if (num == 0)
			{
			}
			int heightLevel;
			if (num != 0)
			{
				heightLevel = fisher.heightLevel;
				if (heightLevel == 0)
				{
					int rolledEnemySpawn = fisher.rolledEnemySpawn;
					if (fisher.inLava)
					{
						if (fisher.CanFishInLava)
						{
							bool crate = fisher.crate;
							if (crate)
							{
								if (!crate)
								{
								}
								int num2;
								if (num2 == 0)
								{
									int num3;
									if (num3 == 0)
									{
									}
									return;
								}
							}
							bool legendary = fisher.legendary;
							if (legendary)
							{
								if (!legendary)
								{
								}
								if (legendary)
								{
									if (!legendary)
									{
									}
									int num4;
									if (num4 == 0)
									{
										int num5;
										if (num5 == 0)
										{
										}
										return;
									}
								}
								bool legendary2 = fisher.legendary;
								if (legendary2)
								{
									if (!legendary2)
									{
									}
									if (!legendary2)
									{
										if (!legendary2)
										{
										}
										int num6;
										if (num6 == 0)
										{
											int num7;
											if (num7 == 0)
											{
											}
											if (num7 == 0)
											{
											}
											return;
										}
									}
								}
							}
							if (fisher.veryrare)
							{
								return;
							}
							if (fisher.rare)
							{
								return;
							}
						}
					}
					else if (fisher.inHoney)
					{
						if (fisher.rare)
						{
							int num8 = 2314;
							return;
						}
						bool uncommon = fisher.uncommon;
						if (uncommon)
						{
							if (!uncommon)
							{
							}
							int num9;
							while (num9 == 0)
							{
							}
							if (fisher.uncommon)
							{
								int questFish = fisher.questFish;
								return;
							}
						}
					}
					else
					{
						int num8;
						if (num8 == 0)
						{
						}
						if (fisher.fishingLevel == 0)
						{
						}
						int fishingLevel = fisher.fishingLevel;
						int waterTilesCount = fisher.waterTilesCount;
						float waterQuality = fisher.waterQuality;
						if (waterTilesCount == 0)
						{
						}
						int num10;
						fisher.rolledItemDrop = num10;
						int num11;
						if (num11 == 0)
						{
							return;
						}
					}
					return;
				}
			}
			if (heightLevel == 0)
			{
			}
		}

		// Token: 0x06002640 RID: 9792 RVA: 0x001597DC File Offset: 0x001579DC
		private void FishingCheck_ProbeForQuestFish(FishingAttempt fisher)
		{
			int num = 1;
			if (num == 0)
			{
			}
			fisher.questFish = fisher;
			fisher.questFish = num;
			if (num == 0)
			{
			}
			bool flag = NPC.AnyNPCs(369);
			fisher.questFish = num;
			if (num == 0)
			{
			}
			bool anglerQuestFinished = Main.anglerQuestFinished;
			fisher.questFish = num;
		}

		// Token: 0x06002641 RID: 9793 RVA: 0x00159824 File Offset: 0x00157A24
		private void FishingCheck_RollDropLevels(int fishingLevel, [Out] bool common, [Out] bool uncommon, [Out] bool rare, [Out] bool veryrare, [Out] bool legendary, [Out] bool crate)
		{
			if (1050 == 0)
			{
			}
			int num = 4;
			if (num == 0)
			{
			}
			int num2;
			int num3;
			if (num2 == 0)
			{
				num3 = 1;
				common.m_value = num3 != 0;
			}
			if (num3 == 0)
			{
			}
			int num4;
			int num5;
			if (num4 == 0)
			{
				num5 = 1;
				uncommon.m_value = num5 != 0;
			}
			if (num5 == 0)
			{
			}
			int num6;
			int num7;
			if (num6 == 0)
			{
				num7 = 1;
				rare.m_value = num7 != 0;
			}
			if (num7 == 0)
			{
			}
			int num8;
			int num9;
			if (num8 == 0)
			{
				num9 = 1;
				num.m_value = num9;
			}
			if (num9 == 0)
			{
			}
			int num10;
			int num11;
			if (num10 == 0)
			{
				num11 = 1;
				num.m_value = num11;
			}
			if (num11 == 0)
			{
			}
			int num12 = 1;
			num.m_value = num12;
		}

		// Token: 0x06002642 RID: 9794 RVA: 0x001598A8 File Offset: 0x00157AA8
		private static void GetFishingPondState(int x, int y, [Out] bool lava, [Out] bool honey, [Out] int numWaters, [Out] int chumCount)
		{
			int num = 1;
			long num2 = 0L;
			long num3 = 0L;
			long num4 = 0L;
			if (num == 0)
			{
			}
			Projectile.GetFishingPondWidth(x, (int)num2, (int)num3, (int)num4);
			int num5 = 1;
			if (num == 0)
			{
			}
			Tile tile;
			byte liquid = tile.liquid;
			long num6 = 0L;
			bool flag = WorldGen.SolidTile(x, 0, num6 != 0L);
			Tile tile2;
			bool flag2 = tile2.lava();
			if (!lava)
			{
			}
			Tile tile3;
			bool flag3 = tile3.honey();
			honey.m_value = num5 != 0;
			if (!honey)
			{
			}
			chumCount.m_value = (honey ? 1 : 0);
		}

		// Token: 0x06002643 RID: 9795 RVA: 0x00159910 File Offset: 0x00157B10
		private static void GetFishingPondWidth(int x, int y, [Out] int minX, [Out] int maxX)
		{
			int num = 1;
			minX.m_value = x;
			maxX.m_value = x;
			if (num == 0)
			{
			}
			Tile tile;
			byte liquid = tile.liquid;
			minX.m_value = y;
			Tile tile2;
			byte liquid2 = tile2.liquid;
		}

		// Token: 0x06002644 RID: 9796 RVA: 0x00159948 File Offset: 0x00157B48
		public bool CanBeReflected()
		{
			while (this.active && this.friendly && !this.hostile)
			{
			}
		}

		// Token: 0x06002645 RID: 9797 RVA: 0x00159970 File Offset: 0x00157B70
		public Color GetFairyQueenWeaponsColor(float alphaChannelMultiplier = 1f, float lerpToWhite = 0f, [Optional] float? rawHueOverride)
		{
			/*
An exception occurred when decompiling this method (06002645)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Color Terraria.Projectile::GetFairyQueenWeaponsColor(System.Single,System.Single,System.Nullable`1<System.Single>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0537:
	brtrue(IL_0000, ldloc:int32[exp:bool](var_199_531))
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

		// Token: 0x06002646 RID: 9798 RVA: 0x00159EBC File Offset: 0x001580BC
		public float GetLastPrismHue(float laserIndex, float laserLuminance, float laserAlphaMultiplier)
		{
			/*
An exception occurred when decompiling this method (06002646)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Projectile::GetLastPrismHue(System.Single,System.Single,System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_03C2:
	brtrue(IL_0000, ldstr:string[exp:bool]("Devalaous"))
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

		// Token: 0x06002647 RID: 9799 RVA: 0x0015A294 File Offset: 0x00158494
		public static int GetByUUID(int owner, float uuid)
		{
			if (!true)
			{
			}
			return Projectile.GetByUUID(0, owner);
		}

		// Token: 0x06002648 RID: 9800 RVA: 0x0015A2AC File Offset: 0x001584AC
		public static int GetByUUID(int owner, int uuid)
		{
			if (!true)
			{
			}
			return 43143168;
		}

		// Token: 0x06002649 RID: 9801 RVA: 0x0015A2C4 File Offset: 0x001584C4
		public void ProjectileFixDesperation()
		{
			int num = this.owner;
			int num2 = this.type;
		}

		// Token: 0x0600264A RID: 9802 RVA: 0x000021DB File Offset: 0x000003DB
		public bool ShouldUseWindPhysics()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600264B RID: 9803 RVA: 0x0015A2F4 File Offset: 0x001584F4
		private void AI_151_SuperStar()
		{
			int num = this.alpha;
			int num2 = this.soundDelay;
			this.alpha = num;
			float x;
			if (num2 == 0)
			{
				if (num == 0)
				{
				}
				this.soundDelay = num;
				if (num == 0)
				{
				}
				x = this.position.X;
				float y = this.position.Y;
			}
			float num3 = this.rotation;
			float x2 = this.velocity.X;
			if (num == 0)
			{
			}
			float y2 = this.velocity.Y;
			int direction = this.direction;
			this.rotation = x;
			int screenWidth = Main.screenWidth;
			int screenHeight = Main.screenHeight;
			Rectangle hitbox = base.Hitbox;
			Vector2 screenPosition = Main.screenPosition;
			int num4 = 17352;
			if (num4 == 0)
			{
			}
			Rectangle rectangle;
			bool flag = rectangle.Intersects(rectangle);
			if (num4 == 0)
			{
			}
			int num5;
			if (num5 == 0)
			{
				float x3 = this.position.X;
				float y3 = this.position.Y;
				float x4 = this.velocity.X;
				float y4 = this.velocity.Y;
				if (num4 == 0)
				{
				}
				if (num4 == 0)
				{
				}
				if (num4 == 0)
				{
				}
				if (num2 == 0)
				{
				}
			}
			int num6 = 26214;
			int num7 = 1;
			int num8;
			if (num8 == 0)
			{
				float x5 = this.position.X;
				float y5 = this.position.Y;
				int width = this.width;
				bool wet = this.wet;
				Dust dust;
				float x6 = dust.velocity.X;
				float y6 = dust.velocity.Y;
				dust.velocity.X = x;
				dust.velocity.Y = y2;
				dust.scale = (float)num6;
				dust.noGravity = num7 != 0;
				float x7 = this.velocity.X;
				float y7 = this.velocity.Y;
				dust.velocity.X = x;
				dust.velocity.Y = y2;
			}
		}

		// Token: 0x0600264C RID: 9804 RVA: 0x0015A4E4 File Offset: 0x001586E4
		public bool IsInterruptible(Player player)
		{
			/*
An exception occurred when decompiling this method (0600264C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Projectile::IsInterruptible(Terraria.Player)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Projectile::aiStyle, ldloc:Projectile(this)))
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

		// Token: 0x0600264D RID: 9805 RVA: 0x0015A4F8 File Offset: 0x001586F8
		public void Interrupt(Player player)
		{
			int num = this.aiStyle;
			this.Kill();
			player.heldProj = num;
		}

		// Token: 0x0600264E RID: 9806 RVA: 0x0015A51C File Offset: 0x0015871C
		public static IEntitySource GetNoneSource()
		{
		}

		// Token: 0x0600264F RID: 9807 RVA: 0x000021DB File Offset: 0x000003DB
		public IEntitySource GetNPCSource_FromThis()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002650 RID: 9808 RVA: 0x000021DB File Offset: 0x000003DB
		public IEntitySource GetProjectileSource_FromThis()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002651 RID: 9809 RVA: 0x000021DB File Offset: 0x000003DB
		public IEntitySource GetItemSource_DropAsItem()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002652 RID: 9810 RVA: 0x000021DB File Offset: 0x000003DB
		public IEntitySource GetItemSource_FromThis()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002653 RID: 9811 RVA: 0x000021DB File Offset: 0x000003DB
		public IEntitySource GetProjectileSource_OnHit(Entity victim, int projectileSourceId)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002654 RID: 9812 RVA: 0x000021DB File Offset: 0x000003DB
		public IEntitySource GetItemSource_OnHit(Entity victim, int itemSourceId)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002655 RID: 9813 RVA: 0x0015A52C File Offset: 0x0015872C
		public static IEntitySource InheritSource(Projectile projectile)
		{
			IEntitySource entitySource;
			return entitySource;
		}

		// Token: 0x06002656 RID: 9814 RVA: 0x0015A53C File Offset: 0x0015873C
		private void AI_152_SuperStarSlash()
		{
			int num = this.type;
			int num2 = this.alpha;
			this.alpha = num2;
			if (this.soundDelay == 0)
			{
				this.soundDelay = num;
				if (num == 0)
				{
				}
				return;
			}
			int num3 = this.type;
			float x = this.velocity.X;
			if (num3 == 0)
			{
				return;
			}
			int num4 = this.type;
			float x2 = this.velocity.X;
			float y = this.velocity.Y;
			if (num4 == 0)
			{
			}
			float num5;
			this.velocity.X = num5;
			float num6;
			this.velocity.Y = num6;
			int num7;
			if (num7 == 0)
			{
				Vector2 center = base.Center;
				float x3 = this.velocity.X;
				float y2 = this.velocity.Y;
				int num8 = 1;
				Dust dust;
				dust.noGravity = num8 != 0;
				Vector2 center2 = base.Center;
				dust.position.Y = num6;
				if (num8 == 0)
				{
				}
				int num9;
				if (num9 == 0)
				{
				}
				float x4 = this.velocity.X;
				float y3 = this.velocity.Y;
				dust.velocity.Y = num6;
			}
			int num10 = this.type;
			float x5 = this.position.X;
			float y4 = this.position.Y;
			int width = this.width;
			bool wet = this.wet;
			this.Kill();
		}

		// Token: 0x06002657 RID: 9815 RVA: 0x0015A8C8 File Offset: 0x00158AC8
		public void Resize(int newWidth, int newHeight)
		{
			Vector2 center = base.Center;
			this.width = newWidth;
			this.wet = newHeight != 0;
		}

		// Token: 0x06002658 RID: 9816 RVA: 0x0015A8EC File Offset: 0x00158AEC
		private void Shimmer()
		{
			if (!this.hostile)
			{
				int num = this.aiStyle;
				int num2 = this.aiStyle;
				int num3 = this.type;
				return;
			}
		}

		// Token: 0x06002659 RID: 9817 RVA: 0x000021DB File Offset: 0x000003DB
		public void AI()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600265A RID: 9818 RVA: 0x0015AC1C File Offset: 0x00158E1C
		private void AI_195_JimsDrone()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			float y = this.position.Y;
			int height = this.height;
			if (num == 0)
			{
			}
			Item item;
			int num2 = item.type;
			BitsByte bitsByte = 0;
			int num3 = 1;
			this.netUpdate = num3 != 0;
			Main.DroneCameraTracker.Track(this);
			float y2 = this.velocity.Y;
			int num4 = 17096;
			if (num4 == 0)
			{
			}
			float num5;
			ActiveSound activeSound;
			if (SoundEngine.GetActiveSound(SlotId.FromFloat(num5)) == null)
			{
				if (num4 == 0)
				{
				}
				Vector2 center = base.Center;
				SlotId slotId;
				float num6 = slotId.ToFloat();
				if (num4 == 0)
				{
				}
				float num7;
				activeSound = SoundEngine.GetActiveSound(SlotId.FromFloat(num7));
			}
			if (activeSound != null)
			{
				activeSound.Volume = y;
				Vector2 center2 = base.Center;
			}
			float num8 = this.rotation;
			float num10;
			float num9 = MathHelper.WrapAngle(num10);
			float x = this.velocity.X;
			this.rotation = y;
			this.velocity.X = x;
			Vector2 vector = num9.ToRotationVector2();
			float x2 = this.velocity.X;
			float y3 = this.velocity.Y;
		}

		// Token: 0x0600265B RID: 9819 RVA: 0x0015AF14 File Offset: 0x00159114
		public static void UseGasTrapInChest(int chestIndex, Chest theChest, int gasTrapIndex, int gasOffsetX, int gasOffsetY)
		{
			if (!true)
			{
			}
			if (theChest.item.position != null)
			{
				return;
			}
			long num = 0L;
			Item[] item = theChest.item;
			Vector2 position = item.position;
			if (num != 0L)
			{
				return;
			}
			if (item == null)
			{
			}
			if (item != null)
			{
				if (item == null)
				{
				}
			}
			int x = theChest.x;
			bool bankChest = theChest.bankChest;
			int x2 = theChest.x;
			bool bankChest2 = theChest.bankChest;
			if (!true)
			{
			}
		}

		// Token: 0x0600265C RID: 9820 RVA: 0x0015AFA4 File Offset: 0x001591A4
		private void AI_111_DryadsWard()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				float num2 = this.rotation;
				this.rotation = num2;
				int num3 = 32640;
				this.scale = num2;
				this.alpha = num3;
				return;
			}
			this.Kill();
		}

		// Token: 0x0600265D RID: 9821 RVA: 0x0015B1A4 File Offset: 0x001593A4
		public static bool GasTrapCheck(int x, int y, Player user)
		{
			/*
An exception occurred when decompiling this method (0600265D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Projectile::GasTrapCheck(System.Int32,System.Int32,Terraria.Player)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0078:
	stloc:int32(var_17_80, callgetter:int32(Main::get_myPlayer))
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

		// Token: 0x0600265E RID: 9822 RVA: 0x0015B238 File Offset: 0x00159438
		private void AI_194_HorsemanPumpkin()
		{
			int num = 32768;
			Vector2 center = base.Center;
			if (num == 0)
			{
			}
			Vector2 center2 = base.Center;
			float num3;
			int num2 = Math.Sign(num3);
			float y = this.velocity.Y;
			float x = this.velocity.X;
			int num4 = Math.Sign(num3);
			float y2 = this.velocity.Y;
			float x2 = this.velocity.X;
			int num5 = this.timeLeft;
			int num6 = this.alpha;
			int num7 = 32768;
			this.alpha = num7;
			if (num7 == 0)
			{
			}
			int num8;
			if (num8 != 0)
			{
				float x3 = this.position.X;
				float y3 = this.position.Y;
				int width = this.width;
				bool wet = this.wet;
				float x4 = this.velocity.X;
				float y4 = this.velocity.Y;
				int num9 = 39322;
				int num10 = 52429;
				int num11 = 1;
				Dust dust;
				dust.scale = (float)num9;
				dust.fadeIn = (float)num10;
				dust.noGravity = num11 != 0;
				dust.noLight = num11 != 0;
			}
		}

		// Token: 0x0600265F RID: 9823 RVA: 0x0015B358 File Offset: 0x00159558
		private void AI_193_Flamethrower()
		{
			this.Kill();
			int num = 17008;
			float x = this.velocity.X;
			float y = this.velocity.Y;
			if (num == 0)
			{
			}
			int num2 = 16968;
			int num3 = 17008;
			if (num2 == 0)
			{
			}
			if (num3 == 0)
			{
			}
			int num4 = 6;
			int num5 = 135;
			Vector2 center = base.Center;
			if (num4 == 0)
			{
			}
			if (num5 == 0)
			{
			}
			int num6 = 17040;
			if (num6 == 0)
			{
			}
			float x2 = this.velocity.X;
			float y2 = this.velocity.Y;
			if (num6 == 0)
			{
			}
			int num7;
			Dust dust;
			float x3;
			if (num7 != 0)
			{
				float num8 = dust.scale;
				x3 = dust.velocity.X;
				float y3 = dust.velocity.Y;
				dust.scale = num8;
				return;
			}
			float num9 = dust.scale;
			int num10 = 1;
			dust.noGravity = num10 != 0;
			dust.scale = num9;
			dust.scale = num9;
			if (num10 == 0)
			{
			}
			dust.velocity.X = x3;
			dust.velocity.Y = num9;
			float x4 = this.velocity.X;
			float y4 = this.velocity.Y;
			dust.velocity.X = x4;
			dust.velocity.Y = y4;
			if (16968 == 0)
			{
			}
			Vector2 center2 = base.Center;
			if (!true)
			{
			}
			Vector2 center3 = base.Center;
			if (16968 == 0)
			{
			}
			int num11 = 1;
			Dust dust2;
			dust2.velocity.X = y;
			float num12;
			dust2.velocity.Y = num12;
			dust2.noGravity = num11 != 0;
			float num13 = dust2.scale;
			dust2.scale = x4;
		}

		// Token: 0x06002660 RID: 9824 RVA: 0x0015B560 File Offset: 0x00159760
		private void AI_047_MagnetSphere()
		{
			int num = 1;
			float x = this.velocity.X;
			float y = this.velocity.Y;
			float x2 = this.velocity.X;
			int direction = this.direction;
			if (num == 0)
			{
			}
			int num2 = this.frameCounter;
			int num3 = this.frame;
			this.frame = num3;
			float x3 = this.velocity.X;
			float y2 = this.velocity.Y;
			if (this.whoAmI == 0)
			{
			}
			if (num2 != 0)
			{
				int num4 = this.owner;
				int num5 = this.type;
				int num6 = this.timeLeft;
				if (num2 == 0)
				{
				}
				if (num5 == 0)
				{
				}
				if (num2 == 0)
				{
				}
			}
			this.AI_047_MagnetSphere_TryAttacking();
		}

		// Token: 0x06002661 RID: 9825 RVA: 0x0015B618 File Offset: 0x00159818
		private void AI_047_MagnetSphere_TryAttacking()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			float x = this.position.X;
			int width = this.width;
			int height = this.height;
			float y = this.position.Y;
			Vector2 center = base.Center;
			if (height == 0)
			{
			}
			if (height == 0)
			{
			}
			if (this.timeLeft == 0)
			{
			}
			int width2 = this.width;
			int height2 = this.height;
			float x2 = this.position.X;
			float y2 = this.position.Y;
			float x3 = this.velocity.X;
			float y3 = this.velocity.Y;
			IEntitySource projectileSource_FromThis = this.GetProjectileSource_FromThis();
			int num2 = this.damage;
			float num3 = this.knockBack;
			int num4 = this.owner;
		}

		// Token: 0x06002662 RID: 9826 RVA: 0x0015B6F4 File Offset: 0x001598F4
		public static void AI_192_GetJuminoFall(Projectile proj, [Out] float timeSinceFall, [Out] float fall)
		{
		}

		// Token: 0x06002663 RID: 9827 RVA: 0x0015B704 File Offset: 0x00159904
		private void AI_192_JuminoAnimation()
		{
			int num = this.alpha;
			if (50047 == 0)
			{
			}
			if (16896 == 0)
			{
			}
			Rectangle rectangle;
			Vector2 vector = rectangle.TopLeft();
			int num2 = 1;
			Dust dust;
			dust.noGravity = num2 != 0;
			int num3 = 26214;
			dust.fadeIn = (float)num3;
			if (num3 == 0)
			{
			}
		}

		// Token: 0x06002664 RID: 9828 RVA: 0x0015BA00 File Offset: 0x00159C00
		private void AI_191_TrueNightsEdge()
		{
			int num = this.type;
		}

		// Token: 0x06002665 RID: 9829 RVA: 0x0015C338 File Offset: 0x0015A538
		private void AI_190_NightsEdge()
		{
			if (this.type == 0)
			{
			}
			float x = this.position.X;
			float y = this.position.Y;
			SoundEffectInstance soundEffectInstance;
			float volume;
			if (soundEffectInstance != null)
			{
				volume = soundEffectInstance._volume;
				float num;
				soundEffectInstance.Volume = num;
			}
			float x2 = this.velocity.X;
			float y2 = this.velocity.Y;
			int num2 = this.type;
			this.rotation = volume;
		}

		// Token: 0x06002666 RID: 9830 RVA: 0x0015C974 File Offset: 0x0015AB74
		private void AI_188_LightsBane()
		{
			int num = this.soundDelay;
			if (num == 0)
			{
				this.soundDelay = num;
				if (num == 0)
				{
				}
				Vector2 center = base.Center;
				SoundEffectInstance soundEffectInstance;
				if (soundEffectInstance != null)
				{
					float volume = soundEffectInstance._volume;
					float num2;
					soundEffectInstance.Volume = num2;
				}
			}
			int num3 = this.frameCounter;
			this.frameCounter = num3;
			int num4 = this.frame;
			this.frame = num4;
			float x = this.velocity.X;
			float y = this.velocity.Y;
			if (num4 == 0)
			{
			}
			float num5 = this.scale;
			float num6;
			Vector2 vector = num6.ToRotationVector2();
			int num7 = 16952;
			Vector2 center2 = base.Center;
			if (num7 == 0)
			{
			}
			Vector2 center3 = base.Center;
			if (16912 == 0)
			{
			}
			int num8 = 1;
			int num9 = 257;
			Dust dust;
			dust.noGravity = num8 != 0;
			dust.noLight = num9 != 0;
		}

		// Token: 0x06002667 RID: 9831 RVA: 0x0015CA88 File Offset: 0x0015AC88
		private void AI_189_Volcano()
		{
			int num = this.soundDelay;
			if (num == 0)
			{
				this.soundDelay = num;
				if (num == 0)
				{
				}
				Vector2 center = base.Center;
			}
			if (num == 0)
			{
			}
			int num2 = 17279;
			int num3 = 32768;
			this.alpha = num2;
			int num4 = this.frameCounter;
			this.frameCounter = num4;
			int num5 = this.frame;
			this.frame = num5;
			if (20 != 0)
			{
				if (fieldof(<PrivateImplementationDetails>.DB2AFB5E7EEEDEEC2FA21E5E4783824010961672B57ABB7BBAC3E121C7990A19).FieldHandle == null)
				{
				}
				Vector2 center2 = base.Center;
				float x = this.velocity.X;
				float y = this.velocity.Y;
				return;
			}
			int num6 = 1;
			Vector2 center3 = base.Center;
			if (num3 == 0)
			{
			}
			float x2 = this.velocity.X;
			float y2 = this.velocity.Y;
			Dust dust;
			float x3 = dust.velocity.X;
			float y3 = dust.velocity.Y;
			dust.noGravity = num6 != 0;
			dust.velocity.X = x3;
			dust.velocity.Y = y3;
			Vector2 center4 = base.Center;
			if (num3 == 0)
			{
			}
			float x4 = this.velocity.X;
			float y4 = this.velocity.Y;
			if (num3 == 0)
			{
			}
			int num7 = 1;
			Vector2 center5 = base.Center;
			if (num3 == 0)
			{
			}
			float x5 = this.velocity.X;
			float y5 = this.velocity.Y;
			int num8 = 16256;
			Dust dust2;
			dust2.noGravity = num7 != 0;
			dust2.fadeIn = (float)num8;
			float x6 = dust2.position.X;
			float y6 = dust2.position.Y;
			Vector2 vector;
			float num9 = vector.Length();
			if (num8 == 0)
			{
			}
			dust2.velocity.X = x6;
			dust2.velocity.Y = y6;
		}

		// Token: 0x06002668 RID: 9832 RVA: 0x0015CD3C File Offset: 0x0015AF3C
		private void AI_066_TryInterceptingTarget(Vector2 targetDir, Vector2 targetVelocity, float speed)
		{
			int num = this.type;
			Vector2 center = base.Center;
		}

		// Token: 0x06002669 RID: 9833 RVA: 0x0015CD60 File Offset: 0x0015AF60
		public static void RandomizeInsanityShadowFor(Entity targetEntity, bool isHostile, [Out] Vector2 spawnposition, [Out] Vector2 spawnvelocity, [Out] float ai0, [Out] float ai1)
		{
			if (true)
			{
				return;
			}
			if (17096 == 0)
			{
			}
			float x = targetEntity.velocity.X;
		}

		// Token: 0x0600266A RID: 9834 RVA: 0x0015CEA0 File Offset: 0x0015B0A0
		private void AI_187_ShadowHand()
		{
			int num = 1;
			if (num == 0)
			{
			}
			Vector2 center = base.Center;
			SlotId slotId;
			float num2 = slotId.ToFloat();
			if (num == 0)
			{
			}
			float num3;
			if (SoundEngine.GetActiveSound(SlotId.FromFloat(num3)) != null)
			{
				Vector2 center2 = base.Center;
				return;
			}
			if (num == 0)
			{
			}
			int num4 = this.alpha;
		}

		// Token: 0x0600266B RID: 9835 RVA: 0x0015D0D0 File Offset: 0x0015B2D0
		private void AI_187_ShadowHand_GetVariation([Out] int variation, [Out] float fakeCounter, [Out] float counterMax)
		{
		}

		// Token: 0x0600266C RID: 9836 RVA: 0x0015D100 File Offset: 0x0015B300
		private void AI_185_LifeDrain()
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
			int num = this.owner;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num != 0 && num == 0 && num == 0 && num == 0)
			{
				Rectangle hitbox = base.Hitbox;
				Rectangle rectangle;
				bool flag = rectangle.Intersects(rectangle);
			}
		}

		// Token: 0x0600266D RID: 9837 RVA: 0x0015D178 File Offset: 0x0015B378
		private void AI_186_PrincessWeapon()
		{
			if (17008 == 0)
			{
			}
			int num = 32768;
			this.alpha = num;
			int width = this.width;
			int num2 = this.alpha;
			int num3;
			int num7;
			if (num3 == 0)
			{
				if (!true)
				{
				}
				float num4 = this.scale;
				Vector2 center = base.Center;
				float num5 = this.scale;
				float num6 = this.scale;
				float x = this.velocity.X;
				float y = this.velocity.Y;
				num7 = 6000;
				return;
			}
			if (num7 == 0)
			{
			}
			int num8;
			if (num8 == 0)
			{
				if (num7 == 0)
				{
				}
				if (!true)
				{
				}
				float num9 = this.scale;
				Vector2 center2 = base.Center;
				float num10 = this.scale;
				float num11 = this.scale;
				float x2 = this.velocity.X;
				float y2 = this.velocity.Y;
				return;
			}
			int num12;
			if (num12 == 0)
			{
				if (!true)
				{
				}
				float num13 = this.scale;
				Vector2 center3 = base.Center;
				int num14 = this.owner;
				Vector2 velocity = this.velocity;
			}
			float num15 = this.scale;
			Vector2 center4 = base.Center;
			int num16 = this.owner;
			int num17 = this.owner;
		}

		// Token: 0x0600266E RID: 9838 RVA: 0x0015D3E4 File Offset: 0x0015B5E4
		private void AI_184_BadTorchLuck()
		{
			int num = 255;
			this.owner = num;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			if (num != 0)
			{
			}
			if (num == 0)
			{
			}
			Vector2 center = base.Center;
		}

		// Token: 0x0600266F RID: 9839 RVA: 0x0015D4A4 File Offset: 0x0015B6A4
		private void AI_121_StardustDragon()
		{
			if (!true)
			{
			}
			if (32752 == 0)
			{
				int num = 1;
				this.netUpdate = num != 0;
			}
			int num2 = this.type;
		}

		// Token: 0x06002670 RID: 9840 RVA: 0x0015DAA4 File Offset: 0x0015BCA4
		private Projectile FindStardustDragonHeadOfOwner()
		{
			/*
An exception occurred when decompiling this method (06002670)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Projectile Terraria.Projectile::FindStardustDragonHeadOfOwner()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0007:
	stloc:int32(var_2_0D, ldfld:int32(Projectile::owner, ldloc:Projectile(this)))
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

		// Token: 0x06002671 RID: 9841 RVA: 0x0015DAC0 File Offset: 0x0015BCC0
		private void AI_183_ZoologistStrike()
		{
			float x = this.velocity.X;
			int num = 1;
			this.direction = num;
			this.velocity.X = x;
			this.spriteDirection = num;
			this.direction = num;
			this.spriteDirection = num;
			if (this.frame == 0)
			{
			}
		}

		// Token: 0x06002672 RID: 9842 RVA: 0x0015DB0C File Offset: 0x0015BD0C
		private void AI_182_FinalFractal()
		{
			int num = this.type;
			if (num == 0)
			{
			}
			Vector2 center = base.Center;
			if (num == 0)
			{
			}
			Vector2 vector;
			float num2 = vector.Length();
			if (num == 0)
			{
			}
			if (17136 == 0)
			{
			}
			int num3 = 1;
			float num4;
			float num5;
			float lerpValue = Utils.GetLerpValue(num4, num4, num5, num3 != 0);
			float x = this.velocity.X;
			float y = this.velocity.Y;
			float x2 = this.velocity.X;
			int num6 = 1;
			float num7;
			float lerpValue2 = Utils.GetLerpValue(num7, num4, lerpValue, num6 != 0);
			int num8 = 16928;
			float x3 = this.velocity.X;
			float y2 = this.velocity.Y;
			if (num8 == 0)
			{
			}
			if (num8 == 0)
			{
			}
			float num10;
			float num9 = MathHelper.Lerp(num10, num10, num5);
			int num11 = 1;
			float lerpValue3 = Utils.GetLerpValue(lerpValue2, num4, num10, num11 != 0);
			this.rotation = x2;
			float x4 = this.velocity.X;
			this.rotation = x4;
			int num12 = 32640;
			FinalFractalHelper.FinalFractalProfile finalFractalProfile = FinalFractalHelper.GetFinalFractalProfile(-1073741824);
			float num13 = this.rotation;
			if (num12 == 0)
			{
			}
			float num14;
			Vector2 vector2 = num14.ToRotationVector2();
			float num15 = base.Center.Length();
			int num16 = 1;
			float lerpValue4 = Utils.GetLerpValue(num15, num4, num4, num16 != 0);
			int num17 = 1;
			float lerpValue5 = Utils.GetLerpValue(lerpValue4, num4, num4, num17 != 0);
			int num18 = 52992;
			if (num18 == 0)
			{
			}
			if (num18 == 0)
			{
			}
			float num20;
			float num19 = MathHelper.Lerp(num20, num4, num20);
			int num21 = this.spriteDirection;
			float num22 = this.rotation;
			if (!true)
			{
			}
			Vector2 center2 = base.Center;
			int num23 = this.alpha;
			int num24 = this.alpha;
			int num25 = 1;
			float num26;
			float lerpValue6 = Utils.GetLerpValue(num26, num4, num26, num25 != 0);
			int num27 = 1;
			float num28;
			float lerpValue7 = Utils.GetLerpValue(num28, num4, num28, num27 != 0);
			float num29 = MathHelper.Clamp(lerpValue7, num4, num28);
			int num30 = 32768;
			this.alpha = num30;
		}

		// Token: 0x06002673 RID: 9843 RVA: 0x0015DD4C File Offset: 0x0015BF4C
		private void AI_181_FairyQueenRangedItemShot()
		{
			if (!true)
			{
			}
			int num = 17279;
			float x = this.velocity.X;
			float y = this.velocity.Y;
			this.alpha = num;
			if (num == 0)
			{
			}
			int num2;
			if (num2 == 0)
			{
				Vector2 center = base.Center;
				if (num == 0)
				{
				}
				int num3 = 16256;
				int num4 = 1;
				int num5 = 100;
				Dust dust;
				dust.fadeIn = (float)num3;
				dust.noGravity = num4 != 0;
				dust.alpha = num5;
				if (num3 == 0)
				{
				}
				if (num4 == 0)
				{
				}
				float num6 = dust.scale;
				int num7 = 1;
				Color color;
				dust.color = color;
				dust.noLightEmittence = num7 != 0;
				dust.scale = num6;
			}
		}

		// Token: 0x06002674 RID: 9844 RVA: 0x0015DE10 File Offset: 0x0015C010
		private void AI_009_MagicMissiles()
		{
			int num = this.type;
			this.AI_009_MagicMissiles_Old();
		}

		// Token: 0x06002675 RID: 9845 RVA: 0x0015E730 File Offset: 0x0015C930
		private void AI_009_MagicMissiles_Old()
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
			if (this.owner == 0)
			{
			}
			Item item;
			int shoot = item.shoot;
			int num = this.type;
			int width = this.width;
			int height = this.height;
			float x = this.position.X;
			float y = this.position.Y;
			if (shoot == 0)
			{
			}
			Vector2 mouseWorld = Main.MouseWorld;
			int num2 = this.type;
			float x2 = this.velocity.X;
			float y2 = this.velocity.Y;
			if (num2 == 0)
			{
			}
			this.velocity.X = x;
			this.velocity.Y = y;
			Vector2 vector;
			float num3 = vector.Length();
			vector.Normalize();
			float x3 = this.velocity.X;
			float y3 = this.velocity.Y;
			this.velocity.X = x;
			this.velocity.Y = y;
		}

		// Token: 0x06002676 RID: 9846 RVA: 0x0015EF50 File Offset: 0x0015D150
		private void AI_015_HandleMovementCollision(Vector2 wetVelocity, Vector2 lastVelocity)
		{
			float x = this.velocity.X;
			float y = this.velocity.Y;
			float x2 = this.velocity.X;
			float y2 = lastVelocity.Y;
			float y3 = this.velocity.Y;
			float y4 = lastVelocity.Y;
			this.velocity.Y = y4;
			int num = 10;
			int num2 = 1;
			this.localNPCHitCooldown = num;
			this.netUpdate = num2 != 0;
			float x3 = this.position.X;
			float y5 = this.position.Y;
			if (num == 0)
			{
			}
			Vector2 bottomRight = base.BottomRight;
			Vector2 center = base.Center;
			int width = this.width;
			Vector2 center2 = base.Center;
			float x4 = this.position.X;
			float y6 = this.position.Y;
			if (num == 0)
			{
			}
			this.position.X = y4;
			this.position.Y = x2;
		}

		// Token: 0x06002677 RID: 9847 RVA: 0x0015F0EC File Offset: 0x0015D2EC
		private void ResetLocalNPCHitImmunity()
		{
		}

		// Token: 0x06002678 RID: 9848 RVA: 0x0015F0FC File Offset: 0x0015D2FC
		private void AI_015_Flails()
		{
			if (!true)
			{
			}
			Vector2 center = base.Center;
			if (17505 == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			if (this.owner == 0)
			{
			}
			bool mapFullscreen = Main.mapFullscreen;
			this.Kill();
		}

		// Token: 0x06002679 RID: 9849 RVA: 0x0015F740 File Offset: 0x0015D940
		private void AI_015_HandleMovementCollision_Old(Vector2 wetVelocity, Vector2 lastVelocity)
		{
			float x = this.velocity.X;
		}

		// Token: 0x0600267A RID: 9850 RVA: 0x0015F864 File Offset: 0x0015DA64
		private void AI_015_Flails_Old()
		{
			int num = 1;
			long num2 = 0L;
			this.AI_015_Flails_Dust(num2 != 0L);
			if (num == 0)
			{
			}
			Vector2 center = base.Center;
			Vector2 vector;
			float num3 = vector.Length();
			this.Kill();
		}

		// Token: 0x0600267B RID: 9851 RVA: 0x0015FB94 File Offset: 0x0015DD94
		private void AI_015_Flails_Dust(bool doFastThrowDust)
		{
			int num = this.type;
			float x = this.position.X;
			float y = this.position.Y;
			int width = this.width;
			bool wet = this.wet;
			float x2 = this.velocity.X;
			float y2 = this.velocity.Y;
			if (num == 0)
			{
			}
		}

		// Token: 0x0600267C RID: 9852 RVA: 0x0015FCC0 File Offset: 0x0015DEC0
		private void AI_100_Medusa()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			int num = this.type;
			int num2 = 3;
			this.timeLeft = num2;
			int num3 = this.frame;
			int num4 = 8;
			this.frame = num4;
			int num5 = this.frameCounter;
			this.frameCounter = num5;
		}

		// Token: 0x0600267D RID: 9853 RVA: 0x0015FF60 File Offset: 0x0015E160
		private void AI_120_StardustGuardian()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
			int num2 = this.type;
			if (num != 0)
			{
				return;
			}
			int num3;
			int num4;
			if (num3 != 0)
			{
				num4 = 2;
				this.timeLeft = num4;
			}
			Vector2 center = base.Center;
			if (num4 == 0)
			{
			}
		}

		// Token: 0x0600267E RID: 9854 RVA: 0x001605F0 File Offset: 0x0015E7F0
		private void AI_120_StardustGuardian_FindTarget(float lookupRange, int targetNPCIndex, float distanceToClosestTarget)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			targetNPCIndex.m_value = num;
		}

		// Token: 0x0600267F RID: 9855 RVA: 0x00160618 File Offset: 0x0015E818
		private void AI_180_FairyQueenSunDance()
		{
			if (!true)
			{
			}
			Vector2 center = base.Center;
			int num = this.alpha;
			this.alpha = num;
			if (num == 0)
			{
			}
			int num2 = 17136;
			int num3 = 32768;
			if (num2 == 0)
			{
			}
			if (num3 == 0)
			{
			}
			if (num3 != 0)
			{
			}
			if (num3 == 0)
			{
			}
			if (!true)
			{
			}
			float num4 = this.rotation;
			float num5;
			Vector2 vector = num5.ToRotationVector2();
			int num6 = 255;
			float num7;
			float num8;
			float num9;
			Vector3 vector2 = Main.hslToRgb(num7, num8, num9, (byte)num6).ToVector3();
			float num10 = this.scale;
			float num11 = this.scale;
			Vector2 center2 = base.Center;
		}

		// Token: 0x06002680 RID: 9856 RVA: 0x001606F0 File Offset: 0x0015E8F0
		private void AI_179_FairyQueenLance()
		{
			int num = 17008;
			if (num == 0)
			{
			}
			float num2;
			Vector2 vector = num2.ToRotationVector2();
			if (num == 0)
			{
			}
			int num3 = 16928;
			if (num3 == 0)
			{
			}
			int num4;
			float num8;
			if (num4 == 0)
			{
				Vector2 center = base.Center;
				if (num3 == 0)
				{
				}
				int num5 = 16256;
				int num6 = 1;
				int num7 = 100;
				Dust dust;
				dust.fadeIn = (float)num5;
				dust.noGravity = num6 != 0;
				dust.alpha = num7;
				Color color = this.AI_171_GetColor();
				if (num6 == 0)
				{
				}
				if (num6 == 0)
				{
				}
				if (num6 == 0)
				{
				}
				num8 = dust.scale;
				int num9 = 1;
				Color color2;
				dust.color = color2;
				dust.noLightEmittence = num9 != 0;
				dust.scale = num8;
			}
			if (17332 == 0)
			{
			}
			int num10 = 17279;
			this.alpha = num10;
			this.rotation = num8;
		}

		// Token: 0x06002681 RID: 9857 RVA: 0x001607E8 File Offset: 0x0015E9E8
		private void AI_176_EdgyLightning()
		{
			if (!true)
			{
			}
			int num;
			int num4;
			if (num != 0)
			{
				long num2 = 0L;
				float num3;
				NPC npc = this.FindTargetWithinRange(num3, num2 != 0L);
				if (npc != null)
				{
					int whoAmI = npc.whoAmI;
					num4 = 1;
					this.netUpdate = num4 != 0;
				}
				this.Kill();
				return;
			}
			if (num4 == 0)
			{
			}
			if (num4 == 0)
			{
			}
			int num5 = this.frameCounter;
			this.frameCounter = num5;
			if (num5 == 0)
			{
			}
			int num6;
			this.frame = num6;
		}

		// Token: 0x06002682 RID: 9858 RVA: 0x00160868 File Offset: 0x0015EA68
		public NPC FindTargetWithinRange(float maxRange, bool checkCanHit = false)
		{
			/*
An exception occurred when decompiling this method (06002682)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.NPC Terraria.Projectile::FindTargetWithinRange(System.Single,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000D:
	stloc:float32(var_5_18, ldfld:float32(Vector2::X, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](Entity::position, ldloc:Projectile[exp:Entity](this))))
	stloc:float32(var_6_25, ldfld:float32(Vector2::Y, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](Entity::position, ldloc:Projectile[exp:Entity](this))))
	stloc:int32(var_7_2D, ldfld:int32(Entity::width, ldloc:Projectile[exp:Entity](this)))
	stloc:bool(var_8_35, ldfld:bool(Entity::wet, ldloc:Projectile[exp:Entity](this)))
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

		// Token: 0x06002683 RID: 9859 RVA: 0x001608AC File Offset: 0x0015EAAC
		private void AI_177_IceWhipSlicer()
		{
			if (!true)
			{
			}
			int num = this.type;
			this.Kill();
		}

		// Token: 0x06002684 RID: 9860 RVA: 0x00160CA4 File Offset: 0x0015EEA4
		private void AI_178_FireExplosion()
		{
			if (!true)
			{
			}
			float x = this.position.X;
			float y = this.position.Y;
			float x2 = this.position.X;
			float y2 = this.position.Y;
			int width = this.width;
			bool wet = this.wet;
			Vector2 center = base.Center;
			int width2 = this.width;
			float x3 = this.position.X;
			float y3 = this.position.Y;
			int width3 = this.width;
			bool wet2 = this.wet;
			Vector2 center2 = base.Center;
			int width4 = this.width;
			float x4 = this.position.X;
			float y4 = this.position.Y;
			int width5 = this.width;
			bool wet3 = this.wet;
			Vector2 center3 = base.Center;
			int width6 = this.width;
			int num = 16416;
			float x5 = this.position.X;
			float y5 = this.position.Y;
			int width7 = this.width;
			bool wet4 = this.wet;
			if (num == 0)
			{
			}
			Vector2 center4 = base.Center;
			float x6 = this.velocity.X;
			float y6 = this.velocity.Y;
			int width8 = this.width;
			float x7 = this.position.X;
			float y7 = this.position.Y;
			int width9 = this.width;
			bool wet5 = this.wet;
			if (num == 0)
			{
			}
			Vector2 center5 = base.Center;
			float x8 = this.velocity.X;
			float y8 = this.velocity.Y;
			int width10 = this.width;
			float x9 = this.position.X;
			float y9 = this.position.Y;
			int width11 = this.width;
			int height = this.height;
			Vector2 center6 = base.Center;
			int width12 = this.width;
			this.Kill();
		}

		// Token: 0x06002685 RID: 9861 RVA: 0x00160F20 File Offset: 0x0015F120
		private void AI_175_TitaniumStormShards()
		{
			if (!true)
			{
			}
			this.Kill();
		}

		// Token: 0x06002686 RID: 9862 RVA: 0x00160FA4 File Offset: 0x0015F1A4
		private void AI_174_MultisegmentPet()
		{
			if (!true)
			{
			}
			int num = this.type;
		}

		// Token: 0x06002687 RID: 9863 RVA: 0x001611E0 File Offset: 0x0015F3E0
		private void AI_173_HallowBossRainbowTrail()
		{
			int num = 1;
			int num2 = this.timeLeft;
			if (num == 0)
			{
			}
			int num3 = this.timeLeft;
			int num4 = 17279;
			float x = this.velocity.X;
			float y = this.velocity.Y;
			this.alpha = num4;
			this.velocity.X = (float)num3;
			float x2 = this.velocity.X;
			float y2 = this.velocity.Y;
			this.rotation = (float)num3;
		}

		// Token: 0x06002688 RID: 9864 RVA: 0x00161274 File Offset: 0x0015F474
		public Color AI_173_GetColor()
		{
			/*
An exception occurred when decompiling this method (06002688)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Color Terraria.Projectile::AI_173_GetColor()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0032:
	stloc:int32(var_13_3F, ldfld:int32(Projectile::alpha, ldloc:Projectile(this)))
	brtrue(IL_0000, ldloc:int32[exp:bool](var_8_29))
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

		// Token: 0x06002689 RID: 9865 RVA: 0x001612C8 File Offset: 0x0015F4C8
		private void AI_171_HallowBossRainbowStreak()
		{
			int num = this.type;
			int num2 = this.timeLeft;
			int num3 = this.alpha;
			int num4 = 1;
			this.alpha = num3;
			Vector2 center = base.Center;
			Dust dust;
			float num5 = dust.scale;
			dust.noGravity = num4 != 0;
			dust.scale = num5;
		}

		// Token: 0x0600268A RID: 9866 RVA: 0x001614F4 File Offset: 0x0015F6F4
		public Color AI_171_GetColor()
		{
			/*
An exception occurred when decompiling this method (0600268A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Color Terraria.Projectile::AI_171_GetColor()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0032:
	stloc:int32(var_13_3F, ldfld:int32(Projectile::alpha, ldloc:Projectile(this)))
	brtrue(IL_0000, ldloc:int32[exp:bool](var_8_29))
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

		// Token: 0x0600268B RID: 9867 RVA: 0x00161548 File Offset: 0x0015F748
		private void AI_172_HallowBossRainbowPelletStorm()
		{
			int num = 16256;
			this.scale = (float)num;
			int num2 = 32768;
			this.alpha = num2;
			if (17234 == 0)
			{
			}
			if (!true)
			{
			}
			long num3 = 0L;
			Projectile.HallowBossPelletStormInfo hallowBossPelletStormInfo = this.AI_172_GetPelletStormInfo((int)num3);
			long num4 = 0L;
			bool flag = hallowBossPelletStormInfo.IsValid((int)num4);
			Vector2 center = base.Center;
		}

		// Token: 0x0600268C RID: 9868 RVA: 0x001615FC File Offset: 0x0015F7FC
		public int AI_172_GetPelletStormsCount()
		{
			return 6;
		}

		// Token: 0x0600268D RID: 9869 RVA: 0x0016160C File Offset: 0x0015F80C
		public Projectile.HallowBossPelletStormInfo AI_172_GetPelletStormInfo(int stormIndex)
		{
		}

		// Token: 0x0600268E RID: 9870 RVA: 0x0016161C File Offset: 0x0015F81C
		public int FindTargetWithLineOfSight(float maxRange = 800f)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int num2;
			if (num2 == 0)
			{
				if (num == 0)
				{
				}
				float x = this.position.X;
				float y = this.position.Y;
				int width = this.width;
				bool wet = this.wet;
				if (num == 0)
				{
				}
			}
			return 43143168;
		}

		// Token: 0x0600268F RID: 9871 RVA: 0x00161668 File Offset: 0x0015F868
		private void AI_170_FairyGlowstick()
		{
			int num = 1;
			Vector2 center = base.Center;
			if (num == 0)
			{
			}
			Point point;
			Vector2 vector = point.ToVector2();
			if (num == 0)
			{
			}
			if (!true)
			{
			}
			float x = this.position.X;
			float y = this.position.Y;
			int num2 = this.frameCounter;
			this.frameCounter = num2;
			int num3 = this.frame;
			if (num3 == 0)
			{
			}
			int num4 = 26215;
			int num5 = 10;
			if (num3 == 0)
			{
				if (num3 == 0)
				{
				}
				if (num3 == 0)
				{
				}
				if (!true)
				{
				}
				int value = num4.m_value;
				if (num5 == 0)
				{
				}
				Vector2 vector2;
				float num6 = vector2.Length();
				Vector2 vector3;
				float num7 = vector3.Length();
			}
			float x2 = this.velocity.X;
			float y2 = this.velocity.Y;
			this.velocity.X = x;
			this.velocity.Y = y;
			if (!true)
			{
			}
			int num8 = 1;
			this.netUpdate = num8 != 0;
		}

		// Token: 0x06002690 RID: 9872 RVA: 0x00161764 File Offset: 0x0015F964
		private void AI_169_Smolstars()
		{
			int num = 1;
			if (num == 0)
			{
			}
			int num2 = this.type;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				return;
			}
			int num3;
			if (num != 0)
			{
				num3 = 2;
				this.timeLeft = num3;
			}
			if (num3 == 0)
			{
			}
			int num4 = 1;
			if (num4 == 0)
			{
			}
			if (num4 == 0)
			{
			}
			Vector2 center = base.Center;
			Vector2 vector;
			float num5 = vector.Length();
			float x = this.velocity.X;
			float y = this.velocity.Y;
			int num6 = 17008;
			int num7 = 1;
			this.netUpdate = num7 != 0;
			float x2 = this.velocity.X;
			float y2 = this.velocity.Y;
			if (num6 == 0)
			{
			}
			if (!true)
			{
			}
			if (16928 == 0)
			{
			}
			if (!true)
			{
			}
			float num8 = this.rotation;
			float num10;
			float num9 = num10.AngleLerp(num10, num5);
		}

		// Token: 0x06002691 RID: 9873 RVA: 0x00161A94 File Offset: 0x0015FC94
		private void AI_019_Spears()
		{
			if (!true)
			{
			}
			int whoAmI = this.whoAmI;
			int direction = this.direction;
			int num = this.type;
			this.spriteDirection = direction;
		}

		// Token: 0x06002692 RID: 9874 RVA: 0x00162210 File Offset: 0x00160410
		public bool AI_019_Spears_GetExtensionHitbox([Out] Rectangle extensionBox)
		{
			/*
An exception occurred when decompiling this method (06002692)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Projectile::AI_019_Spears_GetExtensionHitbox(Microsoft.Xna.Framework.Rectangle)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0055:
	stloc:int64(var_16_5C, ldc.i4:int64(0))
	stfld:int32(Rectangle::X, ldloc:Rectangle[exp:valuetype Microsoft.Xna.Framework.Rectangle&](extensionBox), ldloc:Rectangle[exp:int32](var_18))
	stfld:int32(Rectangle::Width, ldloc:Rectangle[exp:valuetype Microsoft.Xna.Framework.Rectangle&](extensionBox), ldloc:int64[exp:int32](var_16_5C))
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

		// Token: 0x06002693 RID: 9875 RVA: 0x00162290 File Offset: 0x00160490
		private void AI_019_Spears_Old()
		{
			if (!true)
			{
			}
			int whoAmI = this.whoAmI;
			int width = this.width;
			bool wet = this.wet;
			if (width == 0)
			{
				int num = this.type;
				int num2 = 1;
				this.netUpdate = num2 != 0;
				if (num2 == 0)
				{
				}
				int myPlayer = Main.myPlayer;
				int num3 = this.owner;
				float x = this.velocity.X;
				float y = this.velocity.Y;
				if (num3 == 0)
				{
				}
				IEntitySource projectileSource_FromThis = this.GetProjectileSource_FromThis();
				Vector2 center = base.Center;
				float x2 = this.velocity.X;
				Vector2 center2 = base.Center;
				float y2 = this.velocity.Y;
				int num4 = this.damage;
				float num5 = this.knockBack;
				int num6 = this.owner;
				return;
			}
			float x3 = this.position.X;
			float y3 = this.position.Y;
			float x4 = this.velocity.X;
			float y4 = this.velocity.Y;
			int num7 = this.type;
			IEntitySource projectileSource_FromThis2 = this.GetProjectileSource_FromThis();
			float x5 = this.position.X;
			float y5 = this.position.Y;
			int width2 = this.width;
			bool wet2 = this.wet;
			float x6 = this.velocity.X;
			float y6 = this.velocity.Y;
			int num8 = this.damage;
			int num9 = this.owner;
			int num10;
			if (num10 == 0)
			{
			}
			int num11 = 21846;
			if (num11 == 0)
			{
			}
			if (num11 == 0)
			{
				this.Kill();
			}
			float x7 = this.velocity.X;
			float y7 = this.velocity.Y;
			if (num11 == 0)
			{
			}
			int num12 = this.spriteDirection;
			int num13 = this.type;
			if (num13 == 0)
			{
			}
			int num14;
			if (num14 == 0)
			{
				float x8 = this.position.X;
				float y8 = this.position.Y;
				int width3 = this.width;
				bool wet3 = this.wet;
				if (num13 == 0)
				{
				}
			}
			float x9 = this.position.X;
			float y9 = this.position.Y;
			int direction = this.direction;
			int height = this.height;
			int height2 = this.height;
			float x10 = this.velocity.X;
			float y10 = this.velocity.Y;
			if (num13 == 0)
			{
			}
			if (num10 == 0)
			{
			}
			float x11 = this.position.X;
			float y11 = this.position.Y;
			float x12 = this.velocity.X;
			float y12 = this.velocity.Y;
			int width4 = this.width;
			bool wet4 = this.wet;
			int num15 = this.type;
			if (num15 == 0)
			{
			}
			int num16;
			int num17;
			if (num16 == 0)
			{
				float x13 = this.position.X;
				float y13 = this.position.Y;
				int width5 = this.width;
				bool wet5 = this.wet;
				if (num15 == 0)
				{
				}
				num17 = 1;
				Dust dust;
				dust.noGravity = num17 != 0;
				float x14 = dust.velocity.X;
				float y14 = dust.velocity.Y;
				if (num17 == 0)
				{
				}
			}
			if (num17 == 0)
			{
			}
			int num18;
			if (num18 == 0)
			{
				float x15 = this.position.X;
				float y15 = this.position.Y;
				int width6 = this.width;
				bool wet6 = this.wet;
				if (num17 == 0)
				{
				}
				Dust dust2;
				float y16 = dust2.velocity.Y;
				dust2.velocity.Y = y16;
				return;
			}
		}

		// Token: 0x06002694 RID: 9876 RVA: 0x00162904 File Offset: 0x00160B04
		private void AI_168_FirstFractal()
		{
			int num;
			if (this.frameCounter == 0)
			{
				num = 1;
				this.frameCounter = num;
				if (num == 0)
				{
				}
				int num2;
				this.frame = num2;
			}
			float x = this.velocity.X;
			float y = this.velocity.Y;
			if (num == 0)
			{
			}
			int num3 = 17279;
			float x2 = this.velocity.X;
			float y2 = this.velocity.Y;
			int num4 = 32640;
			this.alpha = num3;
			if (num3 == 0)
			{
			}
			int num5 = this.spriteDirection;
			Vector2 center = base.Center;
			int num6;
			if (num6 == 0)
			{
				Vector2 center2 = base.Center;
				Color firstFractalColor = this.GetFirstFractalColor();
				if (num4 == 0)
				{
				}
				if (num4 == 0)
				{
				}
				if (num4 == 0)
				{
				}
				if (num4 == 0)
				{
				}
				int num7 = 13107;
				int num8 = 1;
				Dust dust;
				dust.scale = (float)num7;
				dust.noGravity = num8 != 0;
				float x3 = dust.velocity.X;
				float y3 = dust.velocity.Y;
				if (num7 == 0)
				{
				}
				float x4 = this.velocity.X;
				float y4 = this.velocity.Y;
				dust.velocity.X = x4;
				dust.velocity.Y = y4;
			}
		}

		// Token: 0x06002695 RID: 9877 RVA: 0x00162A68 File Offset: 0x00160C68
		private void AI_167_SparkleGuitar()
		{
			int num = 17074;
			if (num == 0)
			{
			}
			float x = this.velocity.X;
			float y = this.velocity.Y;
			if (num == 0)
			{
			}
			int num2 = this.type;
			Vector2 center = base.Center;
			if (num2 == 0)
			{
			}
			if (num2 == 0)
			{
			}
		}

		// Token: 0x06002696 RID: 9878 RVA: 0x00162AE0 File Offset: 0x00160CE0
		private void AI_164_StormTigerGem()
		{
			if (!true)
			{
			}
			int num = this.type;
			if (num != 0)
			{
				return;
			}
			if (num == 0)
			{
				return;
			}
			int num2 = 2;
			this.timeLeft = num2;
			int num3 = this.frameCounter;
			this.frameCounter = num3;
			int num4 = this.frame;
			this.frame = num4;
			if (num4 == 0)
			{
			}
		}

		// Token: 0x06002697 RID: 9879 RVA: 0x00162B44 File Offset: 0x00160D44
		public static Vector2 AI_164_GetHomeLocation(Player master, int stackedIndex, int totalIndexes)
		{
			/*
An exception occurred when decompiling this method (06002697)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 Terraria.Projectile::AI_164_GetHomeLocation(Terraria.Player,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0036:
	stloc:Vector2(var_11_42, callgetter:Vector2(Player::get_MountedCenter, ldloc:Player(master)))
	stloc:float32(var_12_4A, ldfld:float32(Player::gravDir, ldloc:Player(master)))
	stloc:float32(var_17_58, ldfld:float32(Player::gfxOffY, ldloc:Player(master)))
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

		// Token: 0x06002698 RID: 9880 RVA: 0x00162BB0 File Offset: 0x00160DB0
		private void AI_162_TigerPounce()
		{
			int num = 32768;
			this.alpha = num;
		}

		// Token: 0x06002699 RID: 9881 RVA: 0x00162DE0 File Offset: 0x00160FE0
		private void PrepareBombToBlow()
		{
			int num = this.type;
			int num2 = 255;
			this.alpha = num2;
		}

		// Token: 0x0600269A RID: 9882 RVA: 0x00162E9C File Offset: 0x0016109C
		private void AI_016()
		{
			bool wet = this.wet;
			int num = this.type;
			if (wet)
			{
				int num2 = 1;
				this.timeLeft = num2;
			}
			this.Kill();
			int num3 = this.type;
			Vector2 center = base.Center;
			int num4 = 15744;
			int num5 = 32768;
			Vector2 center2 = base.Center;
			if (num4 == 0)
			{
			}
			long num6 = 0L;
			bool flag = WorldGen.InWorld(0, num5, (int)num6);
			if (num4 == 0)
			{
			}
			Tile tile;
			bool flag2 = tile.active();
			if (num4 == 0)
			{
			}
			if (num4 == 0)
			{
				int num7 = this.type;
				float x = this.position.X;
				float y = this.position.Y;
				int num8 = 32640;
				int num9 = 32768;
				if (num8 == 0)
				{
				}
				if (num9 != 0)
				{
					if (num9 == 0)
					{
					}
					if (num9 == 0)
					{
						if (num9 == 0)
						{
						}
						Vector2 center3 = base.Center;
						Vector2 vector;
						float num10 = vector.Length();
					}
				}
				int num11 = this.type;
				return;
			}
			this.Kill();
		}

		// Token: 0x0600269B RID: 9883 RVA: 0x001643C8 File Offset: 0x001625C8
		private void AI_166_Dove()
		{
			int num = 1;
			int num2 = this.type;
			if (num == 0)
			{
			}
			int num3;
			this.frame = num3;
			int num4 = this.frameCounter;
			this.frameCounter = num4;
			int num5 = this.frame;
			this.frame = num5;
			float x = this.velocity.X;
			this.spriteDirection = num5;
			int num6 = 1;
			this.spriteDirection = num6;
			int num7 = this.alpha;
			Vector2 center = base.Center;
			float x2 = this.velocity.X;
			float y = this.velocity.Y;
		}

		// Token: 0x0600269C RID: 9884 RVA: 0x001644C0 File Offset: 0x001626C0
		private void AI_161_RapierStabs()
		{
			if (!true)
			{
			}
			float x = this.velocity.X;
			float y = this.velocity.Y;
			int num = 32768;
			this.alpha = num;
			float x2 = this.velocity.X;
			float y2 = this.velocity.Y;
			if (num == 0)
			{
			}
			float x3 = this.velocity.X;
			float y3 = this.velocity.Y;
			int num2 = 1;
			if (num2 == 0)
			{
			}
			this.spriteDirection = num2;
			int whoAmI = this.whoAmI;
		}

		// Token: 0x0600269D RID: 9885 RVA: 0x00164574 File Offset: 0x00162774
		private void AI_165_Whip()
		{
			if (!true)
			{
			}
			float x = this.velocity.X;
			float y = this.velocity.Y;
			Vector2 playerArmPosition = Main.GetPlayerArmPosition(this);
			float x2 = this.velocity.X;
			float y2 = this.velocity.Y;
			float x3 = this.velocity.X;
			float y3 = this.velocity.Y;
			int num = 1;
			if (num == 0)
			{
			}
			this.spriteDirection = num;
			int whoAmI = this.whoAmI;
			List<Vector2> whipPointsForCollision = this.WhipPointsForCollision;
			int version = whipPointsForCollision._version;
			whipPointsForCollision._syncRoot = version;
			if (version == 0)
			{
			}
			Projectile.FillWhipControlPoints(this, whipPointsForCollision);
			if (this.WhipPointsForCollision._size == 0)
			{
			}
			int num2 = this.type;
		}

		// Token: 0x0600269E RID: 9886 RVA: 0x000021DB File Offset: 0x000003DB
		public static void FillWhipControlPoints(Projectile proj, List<Vector2> controlPoints)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600269F RID: 9887 RVA: 0x00164D14 File Offset: 0x00162F14
		public static void GetWhipSettings(Projectile proj, [Out] float timeToFlyOut, [Out] int segments, [Out] float rangeMultiplier)
		{
			if (!true)
			{
			}
			int num = proj.extraUpdates;
			int num2 = proj.type;
		}

		// Token: 0x060026A0 RID: 9888 RVA: 0x00164D4C File Offset: 0x00162F4C
		private void AI_160_Kites()
		{
			if (!true)
			{
			}
			int num = 60;
			this.timeLeft = num;
			int num2 = this.type;
			Vector2 center = base.Center;
			Vector2 vector;
			float num3 = vector.Length();
			this.Kill();
		}

		// Token: 0x060026A1 RID: 9889 RVA: 0x0016501C File Offset: 0x0016321C
		private void AI_159_PaperAirplanes()
		{
			int num = 1;
			float x = this.velocity.X;
			float y = this.velocity.Y;
			this.direction = num;
			if (num == 0)
			{
			}
			int num2 = 1;
			if (num == 0)
			{
			}
			this.netUpdate = num2 != 0;
			bool wet = this.wet;
			if (wet)
			{
				int num3 = this.owner;
				if (!wet)
				{
				}
				int myPlayer = Main.myPlayer;
				this.Kill();
			}
			float num4 = this.rotation;
			if (!wet)
			{
			}
			float num5;
			Vector2 vector = num5.ToRotationVector2();
			if (!wet)
			{
			}
			if (!wet)
			{
			}
			int direction = this.direction;
			if (true)
			{
				return;
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			int direction2 = this.direction;
			int direction3 = this.direction;
			if (!true)
			{
			}
			int num6 = Math.Sign(num5);
		}

		// Token: 0x060026A2 RID: 9890 RVA: 0x001651F8 File Offset: 0x001633F8
		private void AI_158_BabyBird()
		{
			if (!true)
			{
			}
			int num = this.type;
		}

		// Token: 0x060026A3 RID: 9891 RVA: 0x001655EC File Offset: 0x001637EC
		public static Vector2 AI_158_GetHomeLocation(Player master, int stackedIndex)
		{
			int height = master.bodyFrame.Height;
			int y = master.bodyFrame.Y;
			Mount mount = master.mount;
			if (mount._active)
			{
				int num = mount._type;
				int direction = master.direction;
			}
			int direction2 = master.direction;
			float gravDir = master.gravDir;
			int direction3 = master.direction;
			float gravDir2 = master.gravDir;
			float gravDir3 = master.gravDir;
			int direction4 = master.direction;
			float gravDir4 = master.gravDir;
			int direction5 = master.direction;
			float gravDir5 = master.gravDir;
			if (direction5 == 0)
			{
			}
			float gravDir6 = master.gravDir;
			if (direction5 == 0)
			{
			}
			Vector2 mountedCenter = master.MountedCenter;
			float gravDir7 = master.gravDir;
			if (direction5 == 0)
			{
				return;
			}
		}

		// Token: 0x060026A4 RID: 9892 RVA: 0x001656B4 File Offset: 0x001638B4
		public void Minion_FindTargetInRange(int startAttackRange, int attackTarget, bool skipIfCannotHitWithOwnBody, [Optional] Func<Entity, int, bool> customEliminationCheck)
		{
			NPC ownerMinionAttackTargetNPC = this.OwnerMinionAttackTargetNPC;
			if (ownerMinionAttackTargetNPC != null)
			{
				long num = 0L;
				bool flag = ownerMinionAttackTargetNPC.CanBeChasedBy(this, num != 0L);
				int whoAmI = ownerMinionAttackTargetNPC.whoAmI;
				attackTarget.m_value = whoAmI;
				return;
			}
			if (customEliminationCheck != null)
			{
			}
		}

		// Token: 0x060026A5 RID: 9893 RVA: 0x001656F4 File Offset: 0x001638F4
		private bool AI_067_CustomEliminationCheck_Pirates(Entity otherEntity, int currentTarget)
		{
			return true;
		}

		// Token: 0x060026A6 RID: 9894 RVA: 0x00165704 File Offset: 0x00163904
		private bool AI_067_TigerSpecialAttack()
		{
			if (!true)
			{
			}
			int num = 17608;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Rectangle rectangle;
			Rectangle rectangle2;
			return rectangle.Intersects(rectangle2);
		}

		// Token: 0x060026A7 RID: 9895 RVA: 0x000021DB File Offset: 0x000003DB
		private void AI_067_FreakingPirates()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060026A8 RID: 9896 RVA: 0x001657E8 File Offset: 0x001639E8
		private void AI_157_SharpTears()
		{
			int num = this.type;
			int num2 = 5;
			int num3 = 16;
			float x = this.velocity.X;
			float y = this.velocity.Y;
			if (num2 == 0)
			{
			}
			if (num2 == 0)
			{
			}
			int num4;
			this.frame = num4;
			Vector2 center = base.Center;
			if (num3 == 0)
			{
			}
			float x2 = this.velocity.X;
			float y2 = this.velocity.Y;
			float num6;
			float num7;
			float num5 = MathHelper.Lerp(num6, num7, num6);
			Dust dust;
			float x3 = dust.velocity.X;
			float y3 = dust.velocity.Y;
			dust.velocity.X = x2;
			dust.scale = x2;
			int num8 = 16256;
			Vector2 center2 = base.Center;
			float x4 = this.velocity.X;
			float y4 = this.velocity.Y;
			float num10;
			float num11;
			float num9 = MathHelper.Lerp(num10, num11, num10);
			Dust dust2;
			float x5 = dust2.velocity.X;
			float y5 = dust2.velocity.Y;
			dust2.velocity.X = x4;
			dust2.scale = x4;
			dust2.fadeIn = (float)num8;
			int num12 = this.type;
			Vector2 center3 = base.Center;
			int num13 = this.alpha;
			int num14 = 17279;
			float num16;
			float num15 = MathHelper.Clamp(num16, num11, num11);
			int num17 = 32640;
			this.alpha = num14;
			this.scale = (float)num13;
			Vector2 center4 = base.Center;
			if (num17 == 0)
			{
			}
			float x6 = this.velocity.X;
			float y6 = this.velocity.Y;
			float num19;
			float num18 = MathHelper.Lerp(num11, num7, num19);
			Dust dust3;
			float x7 = dust3.velocity.X;
			float y7 = dust3.velocity.Y;
			dust3.velocity.X = x6;
			dust3.velocity.X = x6;
			dust3.scale = x6;
			int num20 = this.alpha;
			int num21 = 17279;
			float num23;
			float num24;
			float num22 = MathHelper.Clamp(num23, num24, num24);
			int num25 = 32640;
			this.alpha = num21;
			Vector2 center5 = base.Center;
			if (num25 == 0)
			{
			}
			float x8 = this.velocity.X;
			float y8 = this.velocity.Y;
			float num27;
			float num26 = MathHelper.Lerp(num11, num24, num27);
			Dust dust4;
			float x9 = dust4.velocity.X;
			float y9 = dust4.velocity.Y;
			dust4.velocity.X = x8;
			dust4.velocity.X = x8;
			dust4.scale = x8;
			this.Kill();
			int num28 = this.type;
			Vector2 center6 = base.Center;
			float num29 = this.scale;
		}

		// Token: 0x060026A9 RID: 9897 RVA: 0x00165AEC File Offset: 0x00163CEC
		public bool IsInRangeOfMeOrMyOwner(Entity entity, float maxDistance, [Out] float myDistance, [Out] float playerDistance, [Out] bool closerIsMe)
		{
			int num = 1;
			Vector2 center = entity.Center;
			Vector2 center2 = base.Center;
			if (num == 0)
			{
			}
			bool flag = this.CanHitWithOwnBody(entity);
			int num2 = 32640;
			closerIsMe.m_value = num2 != 0;
			Vector2 center3 = entity.Center;
			if (num2 == 0)
			{
			}
			if (num2 == 0)
			{
			}
			return this.CanHitWithMeleeWeapon(entity);
		}

		// Token: 0x060026AA RID: 9898 RVA: 0x00165B48 File Offset: 0x00163D48
		private void AI_156_BatOfLight()
		{
			int num = this.type;
			if (num != 0)
			{
				return;
			}
			int num2;
			if (num != 0)
			{
				num2 = 2;
				this.timeLeft = num2;
			}
			Vector3 vector = this.AI_156_GetColor().ToVector3();
			if (num2 == 0)
			{
			}
			Vector2 center = base.Center;
			if (num2 == 0)
			{
			}
			int num3 = this.frameCounter;
			this.frameCounter = num3;
			if (this.frame == 0)
			{
			}
			float x = this.velocity.X;
		}

		// Token: 0x060026AB RID: 9899 RVA: 0x00165BFC File Offset: 0x00163DFC
		public Color AI_156_GetColor()
		{
			/*
An exception occurred when decompiling this method (060026AB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Color Terraria.Projectile::AI_156_GetColor()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0011:
	brtrue(IL_0000, ldloc:int32[exp:bool](var_0_06))
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

		// Token: 0x060026AC RID: 9900 RVA: 0x00165C1C File Offset: 0x00163E1C
		private void AI_156_Think(List<int> blacklist)
		{
			int num = this.type;
			int num2 = 60;
			if (61 == 0)
			{
			}
			int num3;
			if (num2 != 0)
			{
				Vector2 center = base.Center;
				if (num2 == 0)
				{
				}
				num3 = 17658;
				int num4 = 1;
				this.netUpdate = num4 != 0;
			}
			if (num3 == 0)
			{
			}
			if (!true)
			{
			}
			Vector2 center2 = base.Center;
			float num5 = this.rotation;
			this.rotation = num5;
			int num6 = 1;
			this.netUpdate = num6 != 0;
		}

		// Token: 0x060026AD RID: 9901 RVA: 0x00165FC8 File Offset: 0x001641C8
		private void AI_156_StartAttack()
		{
		}

		// Token: 0x060026AE RID: 9902 RVA: 0x00165FD8 File Offset: 0x001641D8
		private int AI_156_TryAttackingNPCs(List<int> blackListedTargets, bool skipBodyCheck = false)
		{
			/*
An exception occurred when decompiling this method (060026AE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.Projectile::AI_156_TryAttackingNPCs(System.Collections.Generic.List`1<System.Int32>,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_004D:
	stloc:int32(var_14_53, ldfld:int32(Entity::whoAmI, ldloc:NPC[exp:Entity](var_1_09)))
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

		// Token: 0x060026AF RID: 9903 RVA: 0x0016603C File Offset: 0x0016423C
		private void AI_GetMyGroupIndexAndFillBlackList(List<int> blackListedTargets, [Out] int index, [Out] int totalIndexesInGroup)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				int num2 = this.owner;
				int num3 = this.type;
				if (num != 0)
				{
					return;
				}
			}
		}

		// Token: 0x060026B0 RID: 9904 RVA: 0x0016606C File Offset: 0x0016426C
		private void AI_156_GetIdlePosition(int stackedIndex, int totalIndexes, [Out] Vector2 idleSpot, [Out] float idleRotation)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int num2 = this.type;
			if (num == 0)
			{
			}
			if (!true)
			{
			}
			Vector2 center = base.Center;
			if (!true)
			{
			}
		}

		// Token: 0x060026B1 RID: 9905 RVA: 0x001660CC File Offset: 0x001642CC
		private void AI_155_MysticSnakeCoil()
		{
			if (!true)
			{
			}
			Vector2 center = base.Center;
			int num = 49312;
			this.velocity.Y = (float)num;
			if (num == 0)
			{
			}
			int num2 = 1;
			float x = this.position.X;
			float y = this.position.Y;
			Dust dust;
			float x2 = dust.velocity.X;
			float y2 = dust.velocity.Y;
			dust.velocity.X = x2;
			dust.noGravity = num2 != 0;
			float x3 = dust.position.X;
			dust.position.X = x2;
			dust.velocity.X = x2;
			dust.velocity.Y = y2;
			dust.velocity.Y = x2;
			float x4 = this.position.X;
			float y3 = this.position.Y;
			Dust dust2;
			float x5 = dust2.velocity.X;
			float y4 = dust2.velocity.Y;
			int num3 = 1;
			dust2.velocity.X = x5;
			dust2.velocity.Y = 0f;
			dust2.noGravity = num3 != 0;
			int num4 = this.alpha;
			if (num3 == 0)
			{
			}
			int num5 = this.frameCounter;
			this.frameCounter = num5;
			int num6 = this.frame;
			this.frame = num6;
			if (num6 == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			int num7 = this.owner;
			float y5 = this.position.Y;
			Vector2 center2 = base.Center;
			if (num7 == 0)
			{
			}
			Tile tile;
			bool flag = tile.active();
			Tile tile2;
			ushort num8 = tile2.type;
			Tile tile3;
			ushort num9 = tile3.type;
		}

		// Token: 0x060026B2 RID: 9906 RVA: 0x001663D8 File Offset: 0x001645D8
		private void AI_155_RemoveRope(Point start, Point end)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Tile tile;
			bool flag = tile.active();
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num != 0)
			{
				if (num == 0)
				{
				}
			}
		}

		// Token: 0x060026B3 RID: 9907 RVA: 0x00166404 File Offset: 0x00164604
		private void AI_155_SpawnRopeIn(int x, int y)
		{
			int num = 8;
			int num2 = 8;
			if (num == 0)
			{
			}
			int num3;
			if (num3 != 0)
			{
				if (num == 0)
				{
				}
				if (!true)
				{
				}
				int value = num2.m_value;
				if (num2 == 0)
				{
				}
				if (num2 == 0)
				{
				}
				int num4 = 170;
				Gore gore;
				gore.alpha = num4;
			}
			int num5 = 1;
			int num6;
			if (num6 == 0)
			{
				Dust dust;
				float x2 = dust.velocity.X;
				float y2 = dust.velocity.Y;
				dust.velocity.X = x2;
				dust.velocity.Y = y2;
			}
			Dust dust2;
			float x3 = dust2.velocity.X;
			float y3 = dust2.velocity.Y;
			dust2.velocity.X = x3;
			dust2.velocity.Y = y3;
			dust2.noGravity = num5 != 0;
		}

		// Token: 0x060026B4 RID: 9908 RVA: 0x001664E4 File Offset: 0x001646E4
		private void AI_154_VoidLens()
		{
			int num = 1;
			int num2 = this.owner;
			int myPlayer = Main.myPlayer;
			int num3 = 4;
			if (this.whoAmI == 0)
			{
			}
			if (num != 0)
			{
				int num4 = this.owner;
				int num5 = this.type;
				int num6 = this.timeLeft;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
			}
			float x = this.velocity.X;
			float y = this.velocity.Y;
			int num7 = this.frameCounter;
			int num8 = 1;
			this.direction = num8;
			this.frameCounter = num7;
			int num9 = this.frame;
			this.frame = num3;
			if (num9 == 0)
			{
			}
			int num10 = this.alpha;
			int num11 = 32640;
			this.alpha = num11;
			int num12 = 32640;
			this.alpha = num12;
		}

		// Token: 0x060026B5 RID: 9909 RVA: 0x001665B0 File Offset: 0x001647B0
		private void AI_153_ToiletPop()
		{
			Vector2 center = base.Center;
		}

		// Token: 0x060026B6 RID: 9910 RVA: 0x001666A8 File Offset: 0x001648A8
		private void AI_150_GolfClubHelper()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
			}
			this.Kill();
		}

		// Token: 0x060026B7 RID: 9911 RVA: 0x001668D8 File Offset: 0x00164AD8
		public Color GetCeleb2Color()
		{
			int num = 32768;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x060026B8 RID: 9912 RVA: 0x00166900 File Offset: 0x00164B00
		private void AI_007_GrapplingHooks()
		{
			if (!true)
			{
			}
			this.Kill();
		}

		// Token: 0x060026B9 RID: 9913 RVA: 0x00166BEC File Offset: 0x00164DEC
		private bool AI_007_GrapplingHooks_CanTileBeLatchedOnTo(Tile theTile)
		{
			/*
An exception occurred when decompiling this method (060026B9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Projectile::AI_007_GrapplingHooks_CanTileBeLatchedOnTo(Terraria.Tile)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000B:
	stloc:int32(var_3_11, ldfld:int32(Projectile::type, ldloc:Projectile(this)))
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

		// Token: 0x060026BA RID: 9914 RVA: 0x00166C10 File Offset: 0x00164E10
		private void AI_147_Celeb2Rocket()
		{
			int num = 1;
			float x = this.velocity.X;
			float y = this.velocity.Y;
			if (num == 0)
			{
			}
			int num2 = 32768;
			Vector2 center = base.Center;
			Vector3 vector = this.GetCeleb2Color().ToVector3();
			if (num2 == 0)
			{
			}
			if (num2 == 0)
			{
			}
		}

		// Token: 0x060026BB RID: 9915 RVA: 0x00166FC8 File Offset: 0x001651C8
		private void AI_148_StarSpawner()
		{
			if (!true)
			{
			}
			float y = Main.LocalPlayer.position.Y;
			float x = this.position.X;
			float num;
			Star.StarFall(num);
			int num2 = this.owner;
			int myPlayer = Main.myPlayer;
		}

		// Token: 0x060026BC RID: 9916 RVA: 0x001670C0 File Offset: 0x001652C0
		private void AI_147_Explosion()
		{
		}

		// Token: 0x060026BD RID: 9917 RVA: 0x001674E0 File Offset: 0x001656E0
		private void CreateGroundExplosion(float MAX_SPREAD, int fluff, int distFluff, int layerStart, int layerEnd, int layerJump)
		{
			int num = 1;
			float x = this.position.X;
			float y = this.position.Y;
			if (num == 0)
			{
			}
			Vector2 bottomRight = base.BottomRight;
			int width = this.width;
		}

		// Token: 0x060026BE RID: 9918 RVA: 0x001675A4 File Offset: 0x001657A4
		public void CheckUsability(Player player, bool currentlyUsable)
		{
			int num = this.aiStyle;
		}

		// Token: 0x060026BF RID: 9919 RVA: 0x001675B8 File Offset: 0x001657B8
		private void AI_163_Chum()
		{
			int width = this.width;
			if (this.whoAmI == 0)
			{
			}
			int num = this.type;
			float x = this.position.X;
			if (num == 0)
			{
			}
			float y = this.position.Y;
			float x2 = this.position.X;
			float y2 = this.position.Y;
			float x3 = this.velocity.X;
			this.velocity.X = x3;
			float y3 = this.velocity.Y;
		}

		// Token: 0x060026C0 RID: 9920 RVA: 0x00167944 File Offset: 0x00165B44
		private void ReduceRemainingChumsInPool()
		{
			int num = 1;
			Vector2 center = base.Center;
			Vector2 center2 = base.Center;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				if (num == 0)
				{
				}
				int myPlayer = Main.myPlayer;
				if (num == 0)
				{
				}
				if (!true)
				{
				}
				return;
			}
			Tile tile;
			byte liquid = tile.liquid;
		}

		// Token: 0x060026C1 RID: 9921 RVA: 0x001679A0 File Offset: 0x00165BA0
		private void AI_061_FishingBobber()
		{
			if (!true)
			{
			}
			int num = this.type;
			int num2 = 60;
			this.timeLeft = num2;
			int num3 = this.type;
			this.Kill();
		}

		// Token: 0x060026C2 RID: 9922 RVA: 0x00167D6C File Offset: 0x00165F6C
		private float AI_061_FishingBobber_GetWaterLine(int X, int Y)
		{
			/*
An exception occurred when decompiling this method (060026C2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Projectile::AI_061_FishingBobber_GetWaterLine(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_003E:
	stloc:uint8(var_10_45, callgetter:uint8(Tile::get_liquid, ldloc:Tile[exp:valuetype Terraria.Tile&](var_9)))
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

		// Token: 0x060026C3 RID: 9923 RVA: 0x00167DC0 File Offset: 0x00165FC0
		private void AI_061_FishingBobber_DoASplash()
		{
			int num = 1;
			float x = this.position.X;
			float y = this.position.Y;
			int width = this.width;
			if (num == 0)
			{
			}
			int num2 = Dust.dustWater();
			float x2 = this.position.X;
			float y2 = this.position.Y;
		}

		// Token: 0x060026C4 RID: 9924 RVA: 0x00167E1C File Offset: 0x0016601C
		private void AI_061_FishingBobber_GiveItemToPlayer(Player thePlayer, int itemType)
		{
			PlayerFishingConditions fishingConditions = thePlayer.GetFishingConditions();
		}

		// Token: 0x060026C5 RID: 9925 RVA: 0x00167EBC File Offset: 0x001660BC
		private void AI_146_DD2Victory()
		{
		}

		// Token: 0x060026C6 RID: 9926 RVA: 0x00167ECC File Offset: 0x001660CC
		private void BetsySharpnel(int npcIndex)
		{
			int num = 1;
			int num2 = this.owner;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			Vector2 center = base.Center;
			IEntitySource projectileSource_FromThis = this.GetProjectileSource_FromThis();
			int num3 = this.damage;
			float num4 = this.knockBack;
			int num5 = this.owner;
		}

		// Token: 0x060026C7 RID: 9927 RVA: 0x00167F20 File Offset: 0x00166120
		private void CopyLocalNPCImmunityTimes(Projectile p)
		{
		}

		// Token: 0x060026C8 RID: 9928 RVA: 0x00167F30 File Offset: 0x00166130
		private void AI_001()
		{
			int num = this.type;
			int num8;
			if (this.wet && !this.honeyWet && !this.shimmerWet)
			{
				this.Kill();
				int num2 = this.type;
				int num3 = this.owner;
				long num4 = 0L;
				if (num2 == 0)
				{
				}
				Vector3 vector = PortalHelper.GetPortalColor(num3, (int)num4).ToVector3();
				Vector2 center = base.Center;
				float x = this.velocity.X;
				float y = this.velocity.Y;
				if (this.alpha == 0)
				{
				}
				Vector2 center2 = base.Center;
				Vector2 center3 = base.Center;
				float x2 = this.velocity.X;
				float y2 = this.velocity.Y;
				float x3 = this.position.X;
				float y3 = this.position.Y;
				int num5 = this.alpha;
				int num6 = this.frameCounter;
				this.alpha = num5;
				this.frameCounter = num6;
				if (this.frame == 0)
				{
				}
				int num7 = this.alpha;
				if (num7 == 0)
				{
					if (num7 == 0)
					{
					}
					Vector2 center4 = base.Center;
					Vector2 center5 = base.Center;
					float x4 = this.velocity.X;
					float y4 = this.velocity.Y;
					num8 = 1;
				}
			}
			float x5 = this.position.X;
			float y5 = this.position.Y;
			int width = this.width;
			bool wet = this.wet;
			if (num8 == 0)
			{
			}
			if (!true)
			{
			}
			float x6 = this.velocity.X;
			float y6 = this.velocity.Y;
			float x7 = this.position.X;
			float y7 = this.position.Y;
			float x8 = this.position.X;
			float y8 = this.position.Y;
			int width2 = this.width;
			bool wet2 = this.wet;
			if (num8 == 0)
			{
			}
			float x9 = this.velocity.X;
			float y9 = this.velocity.Y;
			int num9 = this.alpha;
			this.alpha = num9;
		}

		// Token: 0x060026C9 RID: 9929 RVA: 0x0016F3B0 File Offset: 0x0016D5B0
		private void AI_002()
		{
			int num = 1;
			if (num == 0)
			{
			}
			float x = this.velocity.X;
			int num2 = this.type;
			if (num == 0)
			{
			}
			int num3;
			int num4;
			if (num3 == 0)
			{
				float x2 = this.position.X;
				float y = this.position.Y;
				int direction = this.direction;
				int height = this.height;
				int height2 = this.height;
				float x3 = this.velocity.X;
				float y2 = this.velocity.Y;
				if (num == 0)
				{
				}
				num4 = 39322;
			}
			int num5 = this.type;
			Vector2 center = base.Center;
			float x4 = this.velocity.X;
			float y3 = this.velocity.Y;
			if (!true)
			{
			}
			int value = num4.m_value;
			float x5 = this.velocity.X;
			float y4 = this.velocity.Y;
			int num6 = 16;
			float x6 = this.velocity.X;
			float y5 = this.velocity.Y;
			int num7;
			if (num7 == 0)
			{
			}
			int num8 = this.alpha;
			if (num7 == 0)
			{
			}
			int num9 = Math.Max(0, num6);
			this.alpha = num9;
			int num10 = this.type;
			this.frame = num7;
			int num11 = this.type;
			float x7 = this.velocity.X;
			int direction2 = this.direction;
			if (num7 == 0)
			{
			}
		}

		// Token: 0x060026CA RID: 9930 RVA: 0x00170014 File Offset: 0x0016E214
		private void AI_003()
		{
			if (this.soundDelay == 0)
			{
				int num = this.type;
				int num2 = 8;
				this.soundDelay = num2;
				if (num2 == 0)
				{
				}
				float x = this.position.X;
				float y = this.position.Y;
			}
			int num3 = this.type;
			if (num3 == 0)
			{
			}
			int num4;
			if (num4 != 0)
			{
				int num5 = this.type;
				int num6 = this.owner;
				if (num5 == 0)
				{
				}
				int myPlayer = Main.myPlayer;
				int num7 = this.damage;
				float num9;
				int num8 = this.FindTargetWithLineOfSight(num9);
				int num10 = 1;
				this.netUpdate = num10 != 0;
				int num11;
				if (num11 == 0)
				{
				}
				return;
			}
			float x2 = this.position.X;
			float y2 = this.position.Y;
			int width = this.width;
			bool wet = this.wet;
			float x3 = this.velocity.X;
			float y3 = this.velocity.Y;
			if (num3 == 0)
			{
			}
			int num12;
			if (num12 == 0)
			{
				if (26214 == 0)
				{
				}
				return;
			}
		}

		// Token: 0x060026CB RID: 9931 RVA: 0x001709C8 File Offset: 0x0016EBC8
		private void AI_004()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (this.type == 0)
			{
			}
		}

		// Token: 0x060026CC RID: 9932 RVA: 0x00170C2C File Offset: 0x0016EE2C
		private void AI_005()
		{
			if (!true)
			{
			}
			if (this.type == 0)
			{
			}
			int num = this.damage;
			this.Kill();
			int num2 = this.type;
			Vector2 center = base.Center;
			int num3 = 1;
			this.tileCollide = num3 != 0;
		}

		// Token: 0x060026CD RID: 9933 RVA: 0x00171318 File Offset: 0x0016F518
		private void AI_006()
		{
			int num = this.type;
			float x = this.velocity.X;
			float y = this.velocity.Y;
			if (num == 0)
			{
			}
			this.Kill();
			int num2 = this.type;
			if (num2 == 0)
			{
			}
			float x2 = this.position.X;
			float y2 = this.position.Y;
			int width = this.width;
			bool wet = this.wet;
			float x3 = this.velocity.X;
			float y3 = this.velocity.Y;
			if (num2 == 0)
			{
			}
			if (43691 != 0)
			{
				float x4 = this.velocity.X;
				float y4 = this.velocity.Y;
				return;
			}
			int myPlayer = Main.myPlayer;
		}

		// Token: 0x060026CE RID: 9934 RVA: 0x00171648 File Offset: 0x0016F848
		private void AI_008()
		{
			if (this.type == 0)
			{
			}
			float x = this.position.X;
			float y = this.position.Y;
			if (this.type == 0)
			{
			}
			float x2 = this.position.X;
			float y2 = this.position.Y;
			int num = this.type;
			float x3 = this.position.X;
			float y3 = this.position.Y;
			float x4 = this.velocity.X;
			float y4 = this.velocity.Y;
			int width = this.width;
			bool wet = this.wet;
			float x5 = this.velocity.X;
			float y5 = this.velocity.Y;
			float num2 = this.scale;
			if (num == 0)
			{
			}
		}

		// Token: 0x060026CF RID: 9935 RVA: 0x00171954 File Offset: 0x0016FB54
		private void AI_010()
		{
			int num = this.type;
			int num2 = this.type;
			if (num2 == 0)
			{
			}
			int num3;
			if (num3 == 0)
			{
				float x = this.position.X;
				float y = this.position.Y;
				int width = this.width;
				bool wet = this.wet;
				float y2 = this.velocity.Y;
				if (num2 == 0)
				{
				}
				return;
			}
			if (this.type == 0)
			{
			}
			int num4;
			this.frame = num4;
			int num5 = 1;
			this.tileCollide = num5 != 0;
			if (num5 == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			int num6 = this.owner;
			if (num6 == 0)
			{
			}
			if (num6 != 0)
			{
				int num7 = this.type;
				int width2 = this.width;
				int height = this.height;
				float x2 = this.position.X;
				float y3 = this.position.Y;
				if (num7 == 0)
				{
				}
				int mouseX = Main.mouseX;
				Vector2 screenPosition = Main.screenPosition;
				int mouseY = Main.mouseY;
				Vector2 screenPosition2 = Main.screenPosition;
				if (num7 == 0)
				{
				}
				Vector2 screenPosition3 = Main.screenPosition;
				int screenHeight = Main.screenHeight;
				int mouseY2 = Main.mouseY;
				return;
			}
			int num8 = 1;
			this.netUpdate = num8 != 0;
			int num9 = this.type;
		}

		// Token: 0x060026D0 RID: 9936 RVA: 0x00172024 File Offset: 0x00170224
		private void AI_011()
		{
			int num = this.type;
			float x = this.velocity.X;
		}

		// Token: 0x060026D1 RID: 9937 RVA: 0x001721EC File Offset: 0x001703EC
		private void AI_012()
		{
			if (this.type == 0)
			{
			}
			float x = this.position.X;
			float y = this.position.Y;
			int num = this.type;
			float num2 = this.scale;
			this.scale = num2;
			this.Kill();
			int num3 = this.type;
			float y2 = this.velocity.Y;
			this.velocity.Y = y2;
			float y3 = this.position.Y;
			float x2 = this.velocity.X;
			float x3 = this.position.X;
			int width = this.width;
			bool wet = this.wet;
			float x4 = this.velocity.X;
			float y4 = this.velocity.Y;
			float y5 = this.velocity.Y;
		}

		// Token: 0x060026D2 RID: 9938 RVA: 0x00172410 File Offset: 0x00170610
		private void AI_013()
		{
			if (!true)
			{
			}
			Vector2 center = base.Center;
			Vector2 vector;
			float num = vector.Length();
			this.Kill();
		}

		// Token: 0x060026D3 RID: 9939 RVA: 0x001725B0 File Offset: 0x001707B0
		private void AI_014()
		{
			int num = this.type;
			int num2 = 170;
			this.aiStyle = num2;
			int num3 = this.type;
			if (num3 == 0)
			{
			}
			Vector2 center = base.Center;
			if (num3 == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			if (num3 == 0)
			{
			}
			Vector2 vector;
			float num4 = vector.Length();
			int screenWidth = Main.screenWidth;
			if (num3 == 0)
			{
			}
			Vector2 center2 = base.Center;
			int num5 = this.type;
			int num6 = this.alpha;
			int num7 = 32640;
			this.alpha = num7;
		}

		// Token: 0x060026D4 RID: 9940 RVA: 0x001732A8 File Offset: 0x001714A8
		private void AI_017()
		{
			float x = this.velocity.X;
			float y = this.velocity.Y;
			this.velocity.X = x;
			float num = this.rotation;
			this.rotation = x;
			this.velocity.Y = y;
			float x2 = this.velocity.X;
			float y2 = this.velocity.Y;
			int num2 = this.owner;
			int myPlayer = Main.myPlayer;
			int width = this.width;
			int height = this.height;
			float x3 = this.position.X;
			float y3 = this.position.Y;
			if (width == 0)
			{
			}
			int num3 = this.type;
		}

		// Token: 0x060026D5 RID: 9941 RVA: 0x001733AC File Offset: 0x001715AC
		private void AI_018()
		{
			if (this.type == 0)
			{
			}
			float x = this.position.X;
			float y = this.position.Y;
			int num = this.type;
			float x2 = this.velocity.X;
		}

		// Token: 0x060026D6 RID: 9942 RVA: 0x000021DB File Offset: 0x000003DB
		private void AI_020()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060026D7 RID: 9943 RVA: 0x001734EC File Offset: 0x001716EC
		private void AI_021()
		{
			float x = this.velocity.X;
			int direction = this.direction;
			this.rotation = x;
			int num;
			if (num == 0)
			{
				float x2 = this.position.X;
				float y = this.position.Y;
				int width = this.width;
				bool wet = this.wet;
				if (direction == 0)
				{
				}
				if (!true)
				{
				}
			}
			float x3 = this.position.X;
			float y2 = this.position.Y;
		}

		// Token: 0x060026D8 RID: 9944 RVA: 0x00173570 File Offset: 0x00171770
		private void AI_022()
		{
			float x = this.velocity.X;
			float y = this.velocity.Y;
			int num = 255;
			this.alpha = num;
			int num2 = this.timeLeft;
			int num3 = 60;
			this.timeLeft = num3;
			float y2 = this.position.Y;
			float x2 = this.velocity.X;
			float x3 = this.position.X;
			int num4 = 15744;
			int num5 = 32640;
			int width = this.width;
			int height = this.height;
			float num6 = this.rotation;
			this.rotation = num6;
			if (num4 == 0)
			{
			}
			if (num5 != 0)
			{
				return;
			}
			int num7;
			if (num7 == 0)
			{
			}
			int num8;
			if (num8 == 0)
			{
			}
			float x4 = this.position.X;
			float y3 = this.position.Y;
			if (32640 == 0)
			{
			}
			Tile tile;
			bool flag = tile.active();
			Tile tile2;
			ushort num9 = tile2.type;
			Tile tile3;
			ushort num10 = tile3.type;
			Tile tile4;
			ushort num11 = tile4.type;
			this.Kill();
			float x5 = this.position.X;
			float y4 = this.position.Y;
			int width2 = this.width;
			bool wet = this.wet;
			if (num8 == 0)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x060026D9 RID: 9945 RVA: 0x00173ABC File Offset: 0x00171CBC
		private void AI_023()
		{
			int num = this.type;
			int num2 = this.timeLeft;
			int num3 = 60;
			this.timeLeft = num3;
		}

		// Token: 0x060026DA RID: 9946 RVA: 0x00173BC8 File Offset: 0x00171DC8
		private void AI_024()
		{
			float num = this.scale;
			float num2 = this.rotation;
			float x = this.velocity.X;
			int num3 = this.type;
			if (num3 == 0)
			{
			}
			int num4;
			float x2;
			if (num4 == 0)
			{
				x2 = this.position.X;
				float y = this.position.Y;
				int width = this.width;
				bool wet = this.wet;
				if (num3 == 0)
				{
				}
				if (!true)
				{
				}
			}
			float x3 = this.velocity.X;
			float y2 = this.velocity.Y;
			this.velocity.X = x2;
			float num5 = this.scale;
			this.scale = num5;
			int num6 = 52429;
			this.scale = (float)num6;
			this.Kill();
		}

		// Token: 0x060026DB RID: 9947 RVA: 0x00173CE8 File Offset: 0x00171EE8
		private void AI_025()
		{
			int num = this.type;
			int num2 = this.type;
			if (num2 == 0)
			{
			}
			this.frame = num2;
			long num3 = 0L;
			float y = this.velocity.Y;
			float x = this.velocity.X;
			float x2 = this.position.X;
			float y2 = this.position.Y;
			int num4 = 15744;
			if (num4 == 0)
			{
			}
			long num5 = 0L;
			bool flag = WorldGen.SolidTile(0, (int)num3, num5 != 0L);
			if (num4 == 0)
			{
			}
			long num6 = 0L;
			bool flag2 = WorldGen.SolidTile(0, (int)num3, num6 != 0L);
			int num7 = 1;
			int width = this.width;
			float x3 = this.position.X;
			int num8 = 15744;
			if (num8 == 0)
			{
			}
			long num9 = 0L;
			bool flag3 = WorldGen.SolidTile(0, (int)num3, num9 != 0L);
			if (num8 == 0)
			{
			}
			long num10 = 0L;
			bool flag4 = WorldGen.SolidTile(0, (int)num3, num10 != 0L);
			int num11;
			if (num7 != 0)
			{
				num11 = 16128;
				return;
			}
			if (num11 != 0)
			{
				int num12 = 48896;
				this.velocity = num12;
				float x4 = this.velocity.X;
				float num13 = this.rotation;
				this.rotation = x4;
				float y3 = this.velocity.Y;
				int num14 = 16768;
				this.velocity.Y = (float)num14;
				int num15 = this.type;
				float x5 = this.velocity.X;
				return;
			}
			float x6 = this.position.X;
			float y4 = this.position.Y;
			int num16 = 15744;
			if (num16 == 0)
			{
			}
			long num17 = 0L;
			long num18;
			bool flag5 = WorldGen.SolidTile(0, (int)num18, num17 != 0L);
			if (num16 == 0)
			{
			}
			long num19 = 0L;
			bool flag6 = WorldGen.SolidTile(0, (int)num18, num19 != 0L);
			int num20 = 1;
			int width2 = this.width;
			float x7 = this.position.X;
			int num21 = 15744;
			if (num21 == 0)
			{
			}
			long num22 = 0L;
			bool flag7 = WorldGen.SolidTile(0, (int)num18, num22 != 0L);
			if (num21 == 0)
			{
			}
			long num23 = 0L;
			bool flag8 = WorldGen.SolidTile(0, (int)num18, num23 != 0L);
			int num24 = 1;
			while (num20 != 0)
			{
			}
			while (num24 != 0)
			{
			}
			float x8 = this.position.X;
			float y5 = this.position.Y;
			int num25 = 49664;
			if (num25 == 0)
			{
			}
			long num26 = 0L;
			bool flag9 = WorldGen.SolidTile(0, (int)num18, num26 != 0L);
			if (num25 == 0)
			{
			}
			long num27 = 0L;
			bool flag10 = WorldGen.SolidTile(0, (int)num18, num27 != 0L);
			int width3 = this.width;
			float x9 = this.position.X;
			int num28 = 16896;
			if (num28 == 0)
			{
			}
			long num29 = 0L;
			bool flag11 = WorldGen.SolidTile(0, (int)num18, num29 != 0L);
			if (num28 == 0)
			{
			}
			long num30 = 0L;
			bool flag12 = WorldGen.SolidTile(0, (int)num18, num30 != 0L);
		}

		// Token: 0x060026DC RID: 9948 RVA: 0x00173FB0 File Offset: 0x001721B0
		private void AI_026()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				int num2 = this.type;
				return;
			}
		}

		// Token: 0x060026DD RID: 9949 RVA: 0x001794F4 File Offset: 0x001776F4
		private void AI_027()
		{
			int num = this.type;
			float x = this.velocity.X;
			float y = this.velocity.Y;
			if (num == 0)
			{
			}
			int num2 = this.type;
			float x2 = this.velocity.X;
			float y2 = this.velocity.Y;
			float x3 = this.position.X;
			float y3 = this.position.Y;
			float x4 = this.oldVelocity.X;
			float y4 = this.oldVelocity.Y;
			float x5 = this.velocity.X;
			float y5 = this.velocity.Y;
			if (this.type == 0)
			{
			}
			float x6 = this.velocity.X;
			float y6 = this.velocity.Y;
			float x7 = this.position.X;
			float y7 = this.position.Y;
			int num3 = 57;
			int num4 = 15;
			if (num3 == 0)
			{
			}
			if (num4 == 0)
			{
			}
			int num5 = this.type;
			float y8 = this.position.Y;
			float x8 = this.velocity.X;
			float x9 = this.position.X;
			float y9 = this.velocity.Y;
			float x10 = this.oldVelocity.X;
			float y10 = this.oldVelocity.Y;
			if (num5 == 0)
			{
			}
			if (num4 == 0)
			{
			}
			float y11 = this.position.Y;
			float x11 = this.velocity.X;
			float x12 = this.position.X;
			float y12 = this.velocity.Y;
			float x13 = this.oldVelocity.X;
			float y13 = this.oldVelocity.Y;
			float x14 = this.velocity.X;
			float y14 = this.velocity.Y;
		}

		// Token: 0x060026DE RID: 9950 RVA: 0x00179860 File Offset: 0x00177A60
		private void AI_028()
		{
			int num = this.type;
			int num2 = 21846;
			float x = this.position.X;
			float y = this.position.Y;
			int width = this.width;
			bool wet = this.wet;
			float x2 = this.velocity.X;
			float y2 = this.velocity.Y;
			if (num == 0)
			{
			}
			if (num2 == 0)
			{
			}
			int num3 = 1;
			float x3 = this.velocity.X;
			float y3 = this.velocity.Y;
			if (num3 == 0)
			{
			}
			int num4 = this.frameCounter;
			this.frameCounter = num4;
			int num5 = this.type;
		}

		// Token: 0x060026DF RID: 9951 RVA: 0x00179B8C File Offset: 0x00177D8C
		private void AI_029()
		{
			int num = this.type;
			int num2 = this.frameCounter;
			this.frameCounter = num2;
			if (this.frame != 0)
			{
				return;
			}
			int num3 = this.alpha;
			this.alpha = num3;
			if (32640 == 0)
			{
			}
			int num4;
			if (num4 == 0)
			{
			}
			float y = this.velocity.Y;
			this.velocity.Y = y;
		}

		// Token: 0x060026E0 RID: 9952 RVA: 0x0017A1C4 File Offset: 0x001783C4
		private void AI_030()
		{
			int num = this.type;
			if (num == 0)
			{
			}
			long num2 = 0L;
			if (num == 0)
			{
			}
			int num3 = 8;
			int num4 = Math.Max(4, (int)num2);
			int num5;
			float x2;
			float y2;
			if (num5 == 0)
			{
				float x = this.position.X;
				float y = this.position.Y;
				if (num == 0)
				{
				}
				int width = this.width;
				bool wet = this.wet;
				if (num == 0)
				{
				}
				if (num3 == 0)
				{
				}
				x2 = this.velocity.X;
				y2 = this.velocity.Y;
			}
			int num6 = 16968;
			float x3 = this.velocity.X;
			float y3 = this.velocity.Y;
			if (num6 == 0)
			{
			}
			float num7 = this.rotation;
			this.velocity.X = x2;
			this.velocity.Y = y2;
		}

		// Token: 0x060026E1 RID: 9953 RVA: 0x0017A530 File Offset: 0x00178730
		private void AI_031()
		{
			int num = this.type;
		}

		// Token: 0x060026E2 RID: 9954 RVA: 0x0017A61C File Offset: 0x0017881C
		private void AI_032()
		{
			int num = 10;
			this.timeLeft = num;
			float x = this.position.X;
			float y = this.position.Y;
			int num2 = 32640;
			int width = this.width;
			bool wet = this.wet;
			int num3 = 32768;
			int num4 = 49296;
			if (num2 == 0)
			{
			}
			if (num2 != 0)
			{
				Rectangle rectangle;
				bool flag = rectangle.Intersects(rectangle);
				float x2 = this.velocity.X;
				this.velocity.Y = (float)num4;
				this.velocity.X = x2;
				this.velocity.X = x2;
				this.velocity.Y = y;
				float x3 = this.velocity.X;
				float y2 = this.velocity.Y;
				if (num2 == 0)
				{
				}
				int value = num3.m_value;
				this.velocity.X = x2;
				this.velocity.Y = y;
				float num5;
				this.netUpdate = num5 != null;
			}
			int num6 = 49296;
			int whoAmI = this.whoAmI;
			if (whoAmI == 0)
			{
			}
			if (whoAmI != 0)
			{
				Rectangle rectangle2;
				bool flag2 = rectangle2.Intersects(rectangle2);
				float x4 = this.velocity.X;
				this.velocity.Y = (float)num6;
				this.velocity.X = x4;
				this.velocity.X = x4;
				this.velocity.Y = y;
				float x5 = this.velocity.X;
				float y3 = this.velocity.Y;
				if (whoAmI == 0)
				{
				}
				int value2 = num3.m_value;
				this.velocity.X = x4;
				this.velocity.Y = y;
				float num7;
				this.netUpdate = num7 != null;
			}
			float x6 = this.velocity.X;
			float y4 = this.velocity.Y;
			this.Kill();
			float x7 = this.velocity.X;
			float num8 = this.rotation;
			float y5 = this.velocity.Y;
		}

		// Token: 0x060026E3 RID: 9955 RVA: 0x0017A8BC File Offset: 0x00178ABC
		private void AI_033()
		{
			int num = this.alpha;
			this.alpha = num;
			if (num == 0)
			{
			}
			int num2 = this.alpha;
			int num3 = this.type;
			float x = this.position.X;
			float y = this.position.Y;
			int num4 = 127;
			int num5 = 187;
			float x2 = this.velocity.X;
			float y2 = this.velocity.Y;
			if (num5 == 0)
			{
			}
			if (num4 == 0)
			{
			}
			float x3 = this.velocity.X;
			float y3 = this.velocity.Y;
			float y4 = this.velocity.Y;
			this.velocity.Y = y4;
		}

		// Token: 0x060026E4 RID: 9956 RVA: 0x0017A9E8 File Offset: 0x00178BE8
		private void AI_034()
		{
			int num = 1;
			float x = this.velocity.X;
			float y = this.velocity.Y;
			if (num == 0)
			{
			}
			float x2 = this.position.X;
			float y2 = this.position.Y;
			int width = this.width;
			bool wet = this.wet;
			float x3 = this.velocity.X;
			float y3 = this.velocity.Y;
			float x4 = this.velocity.X;
			float y4 = this.velocity.Y;
			float x5 = this.position.X;
			float y5 = this.position.Y;
			float x6 = this.velocity.X;
			float y6 = this.velocity.Y;
			if (!true)
			{
			}
			float num2 = this.rotation;
			Vector2 center = base.Center;
			float x7 = this.position.X;
			float y7 = this.position.Y;
			float x8 = this.velocity.X;
			float y8 = this.velocity.Y;
			float num3 = this.rotation;
			Vector2 center2 = base.Center;
			float x9 = this.position.X;
			float y9 = this.position.Y;
			float x10 = this.velocity.X;
			float y10 = this.velocity.Y;
			float num4 = this.rotation;
			Vector2 center3 = base.Center;
		}

		// Token: 0x060026E5 RID: 9957 RVA: 0x0017ABF0 File Offset: 0x00178DF0
		private void AI_035()
		{
			float x = this.velocity.X;
			float y = this.velocity.Y;
			this.velocity.Y = y;
			int num = 16736;
			this.velocity.Y = (float)num;
		}

		// Token: 0x060026E6 RID: 9958 RVA: 0x0017AE5C File Offset: 0x0017905C
		private void AI_036()
		{
			int num = this.type;
			if (this.wet && !this.honeyWet && !this.shimmerWet)
			{
				this.Kill();
			}
			int num2 = this.alpha;
			this.alpha = num2;
			int num3 = this.type;
			float x = this.velocity.X;
			float y = this.velocity.Y;
			if (num3 == 0)
			{
			}
			int num4 = this.frameCounter;
			int num5 = this.frame;
			this.frameCounter = num4;
			this.frame = num5;
			float x2 = this.velocity.X;
			float y2 = this.velocity.Y;
			float x3 = this.position.X;
			float y3 = this.position.Y;
			int width = this.width;
			bool wet = this.wet;
			if (num5 == 0)
			{
			}
			if (num4 == 0)
			{
			}
			Vector2 center = base.Center;
			Vector2 center2 = base.Center;
		}

		// Token: 0x060026E7 RID: 9959 RVA: 0x0017B0F0 File Offset: 0x001792F0
		private void AI_037()
		{
			int num = 1;
			Vector2 center = base.Center;
			float x = this.velocity.X;
			Vector2 center2 = base.Center;
			float y = this.velocity.Y;
			Vector2 center3 = base.Center;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			this.rotation = y;
			float x2 = this.position.X;
			float y2 = this.position.Y;
			int width = this.width;
			bool wet = this.wet;
			Vector2 center4 = base.Center;
			int num2 = 17302;
			float x3 = this.velocity.X;
			float y3 = this.velocity.Y;
			if (num2 == 0)
			{
			}
			this.velocity.X = y;
		}

		// Token: 0x060026E8 RID: 9960 RVA: 0x0017B1E0 File Offset: 0x001793E0
		private void AI_038()
		{
			int num = 1;
			if (num == 0)
			{
			}
			float x = this.position.X;
			float y = this.position.Y;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			int num2 = this.owner;
			IEntitySource projectileSource_FromThis = this.GetProjectileSource_FromThis();
			float x2 = this.position.X;
			float y2 = this.position.Y;
			float x3 = this.velocity.X;
			float y3 = this.velocity.Y;
			int num3 = this.damage;
			float num4 = this.knockBack;
			int num5 = this.owner;
		}

		// Token: 0x060026E9 RID: 9961 RVA: 0x0017B280 File Offset: 0x00179480
		private void AI_039()
		{
			int num = this.alpha;
			bool active = this.active;
			this.alpha = num;
			if (active)
			{
				if (num == 0)
				{
				}
				Vector2 center = base.Center;
			}
			this.Kill();
		}

		// Token: 0x060026EA RID: 9962 RVA: 0x0017B640 File Offset: 0x00179840
		private void AI_040()
		{
			int num = this.alpha;
			this.alpha = num;
			int num2 = this.frameCounter;
			int num3 = this.frame;
			this.frameCounter = num2;
			this.frame = num3;
			float x = this.velocity.X;
			float y = this.velocity.Y;
			if (16972 == 0)
			{
			}
			float x2 = this.velocity.X;
			float x3 = this.velocity.X;
			float y2 = this.velocity.Y;
			this.velocity.X = x3;
			this.velocity.Y = y2;
			float y3 = this.velocity.Y;
			float x4 = this.velocity.X;
			this.velocity.X = x4;
			this.velocity.Y = y3;
		}

		// Token: 0x060026EB RID: 9963 RVA: 0x0017B740 File Offset: 0x00179940
		private void AI_041()
		{
			if (!true)
			{
			}
			int num;
			this.frame = num;
			float x = this.velocity.X;
			float num2 = this.rotation;
			this.rotation = x;
		}

		// Token: 0x060026EC RID: 9964 RVA: 0x0017B780 File Offset: 0x00179980
		private void AI_042()
		{
			if (!true)
			{
			}
			int width = this.width;
			int height = this.height;
		}

		// Token: 0x060026ED RID: 9965 RVA: 0x0017B8BC File Offset: 0x00179ABC
		private void AI_043()
		{
			int num = 1;
			float x = this.velocity.X;
			float y = this.velocity.Y;
			if (num == 0)
			{
			}
			if (this.soundDelay == 0)
			{
				int num2 = this.type;
				float x2 = this.position.X;
				float y2 = this.position.Y;
				int num3 = 32640;
				this.soundDelay = num2;
				float x3 = this.position.X;
				float y3 = this.position.Y;
				int width = this.width;
				bool wet = this.wet;
				if (num2 == 0)
				{
				}
				if (num3 == 0)
				{
				}
				float x4 = this.velocity.X;
				float y4 = this.velocity.Y;
				if (num3 == 0)
				{
				}
			}
			int num4 = this.timeLeft;
			int num5 = this.frameCounter;
			Vector2 center = base.Center;
			Vector2 velocity = this.velocity;
			if (num5 == 0)
			{
			}
			if (17279 == 0)
			{
			}
			Vector2 center2 = base.Center;
			int num6;
			if (num6 == 0)
			{
				float x5 = this.position.X;
				float y5 = this.position.Y;
				int width2 = this.width;
				bool wet2 = this.wet;
				int num7 = 1;
				Dust dust;
				dust.noGravity = num7 != 0;
				float x6 = dust.velocity.X;
				float y6 = dust.velocity.Y;
				if (num7 == 0)
				{
				}
				int num8 = 16320;
				dust.velocity.X = x5;
				dust.velocity.Y = y5;
				dust.scale = (float)num8;
				float x7 = this.velocity.X;
				float y7 = this.velocity.Y;
				if (num8 == 0)
				{
				}
				int num9 = 100;
				int num10 = 1;
				dust.velocity.X = x5;
				dust.velocity.Y = y5;
				Color color;
				dust.color = color;
				dust.color.R = (byte)width2;
				dust.alpha = num9;
				dust.noLight = num10 != 0;
			}
		}

		// Token: 0x060026EE RID: 9966 RVA: 0x0017BACC File Offset: 0x00179CCC
		private void AI_044()
		{
			int num = this.type;
			float x = this.velocity.X;
			float y = this.velocity.Y;
			if (num == 0)
			{
			}
			int num2 = this.alpha;
			this.alpha = num2;
			this.Kill();
		}

		// Token: 0x060026EF RID: 9967 RVA: 0x0017BC1C File Offset: 0x00179E1C
		private void AI_045()
		{
			int num = this.type;
			Vector2 center = base.Center;
			int height = this.height;
			float y = this.position.Y;
			if (52992 == 0)
			{
			}
			int num2 = this.frameCounter;
			this.frameCounter = num2;
			int num3 = this.frame;
			this.frame = num3;
		}

		// Token: 0x060026F0 RID: 9968 RVA: 0x0017BEF8 File Offset: 0x0017A0F8
		private void AI_046()
		{
			Vector2 center = base.Center;
			int num = 15744;
			int num2 = 32640;
			int num3 = 32768;
			Vector2 center2 = base.Center;
			if (num == 0)
			{
			}
			long num4 = 0L;
			bool flag = WorldGen.InWorld(43143168, num3, (int)num4);
			if (num == 0)
			{
			}
			Tile tile;
			byte liquid = tile.liquid;
			Tile tile2;
			bool flag2 = tile2.shimmer();
			this.Kill();
			int num5 = this.type;
			Vector2 center3 = base.Center;
			if (num5 == 0)
			{
			}
			if (num2 == 0)
			{
			}
			int num6 = this.owner;
			int myPlayer = Main.myPlayer;
			IEntitySource projectileSource_FromThis = this.GetProjectileSource_FromThis();
			Vector2 center4 = base.Center;
			Vector2 center5 = base.Center;
			float x = this.velocity.X;
			float y = this.velocity.Y;
			int num7 = this.damage;
			float num8 = this.knockBack;
			int num9 = this.owner;
			int num10 = this.timeLeft;
			int num11 = 2400;
			this.timeLeft = num11;
			float y2 = this.velocity.Y;
		}

		// Token: 0x060026F1 RID: 9969 RVA: 0x0017C10C File Offset: 0x0017A30C
		private void AI_048()
		{
			int num = this.type;
			float x = this.position.X;
			float y = this.position.Y;
			float x2 = this.velocity.X;
			float y2 = this.velocity.Y;
			int num2 = 255;
			this.alpha = num2;
			if (num2 == 0)
			{
			}
			int width = this.width;
		}

		// Token: 0x060026F2 RID: 9970 RVA: 0x0017C334 File Offset: 0x0017A534
		private void AI_049()
		{
			int num = 1;
			this.hostile = num != 0;
		}

		// Token: 0x060026F3 RID: 9971 RVA: 0x0017C5AC File Offset: 0x0017A7AC
		private void AI_050()
		{
			int num = this.type;
			float x = this.position.X;
			float y = this.position.Y;
			int width = this.width;
			bool wet = this.wet;
			float x2 = this.velocity.X;
			float y2 = this.velocity.Y;
		}

		// Token: 0x060026F4 RID: 9972 RVA: 0x0017C7A8 File Offset: 0x0017A9A8
		private void AI_051()
		{
			int num = 1;
			int num2 = this.type;
			float x = this.position.X;
			float y = this.position.Y;
			int width = this.width;
			bool wet = this.wet;
			if (num == 0)
			{
			}
		}

		// Token: 0x060026F5 RID: 9973 RVA: 0x0017C984 File Offset: 0x0017AB84
		private void AI_052()
		{
			int num = 1;
			int width = this.width;
			int height = this.height;
			float x = this.position.X;
			float y = this.position.Y;
			int num2 = 32768;
			if (num == 0)
			{
			}
			int num3 = 16968;
			float x2 = this.position.X;
			if (num3 == 0)
			{
			}
			float x3 = this.position.X;
			int width2 = this.width;
			if (num2 == 0)
			{
			}
			float y2 = this.position.Y;
			if (num2 == 0)
			{
			}
			float y3 = this.position.Y;
			int height2 = this.height;
			if (num3 == 0)
			{
			}
			int num4 = this.owner;
			if (num3 == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			if (num3 == 0)
			{
			}
			int myPlayer2 = Main.myPlayer;
			if (num3 == 0)
			{
				if (num2 == 0)
				{
				}
			}
			this.Kill();
			float x4 = this.velocity.X;
			int num5 = this.type;
			float x5 = this.position.X;
			float y4 = this.position.Y;
			int width3 = this.width;
			bool wet = this.wet;
			float x6 = this.velocity.X;
		}

		// Token: 0x060026F6 RID: 9974 RVA: 0x0017CAF4 File Offset: 0x0017ACF4
		private void AI_053()
		{
			if (17136 == 0)
			{
			}
			float x = this.position.X;
			float y = this.position.Y;
			int num = this.type;
			float x2 = this.position.X;
			float y2 = this.position.Y;
			int width = this.width;
			bool wet = this.wet;
			int num2 = this.type;
			int num3 = 4;
			this.frame = num3;
			float x3 = this.position.X;
			float y3 = this.position.Y;
			if (num3 == 0)
			{
			}
			int width2 = this.width;
			bool wet2 = this.wet;
			int num4 = this.type;
			Vector2 center = base.Center;
			if (num4 == 0)
			{
			}
			if (num4 == 0)
			{
			}
			float y4 = this.velocity.Y;
			this.velocity.Y = y4;
			Vector2 center2 = base.Center;
			Vector2 center3 = base.Center;
			NPC ownerMinionAttackTargetNPC = this.OwnerMinionAttackTargetNPC;
			bool wet3;
			if (ownerMinionAttackTargetNPC != null)
			{
				long num5 = 0L;
				bool flag = ownerMinionAttackTargetNPC.CanBeChasedBy(this, num5 != 0L);
				int width3 = ownerMinionAttackTargetNPC.width;
				wet3 = ownerMinionAttackTargetNPC.wet;
				float x4 = ownerMinionAttackTargetNPC.position.X;
				float y5 = ownerMinionAttackTargetNPC.position.Y;
				float x5 = this.position.X;
				int width4 = this.width;
				if (width3 == 0)
				{
				}
				int height = this.height;
				float y6 = this.position.Y;
				int num6 = 17530;
				float x6 = this.position.X;
				int width5 = this.width;
				float x7 = ownerMinionAttackTargetNPC.position.X;
				float y7 = ownerMinionAttackTargetNPC.position.Y;
				int width6 = ownerMinionAttackTargetNPC.width;
				bool wet4 = ownerMinionAttackTargetNPC.wet;
				if (num6 == 0)
				{
				}
				int whoAmI = ownerMinionAttackTargetNPC.whoAmI;
				int num7 = this.type;
				return;
			}
			int num8 = 17530;
			if (num8 == 0)
			{
			}
			if (num8 == 0)
			{
			}
			float x8 = this.position.X;
			int width7 = this.width;
			if (!wet3)
			{
			}
			int height2 = this.height;
			float y8 = this.position.Y;
			float x9 = this.position.X;
			int width8 = this.width;
			if (num8 == 0)
			{
			}
			if (!wet3)
			{
			}
			if (num8 == 0)
			{
			}
			int num9 = this.type;
			int num10 = 1;
			this.netUpdate = num10 != 0;
			Vector2 center4 = base.Center;
			Vector2 center5 = base.Center;
			int num11 = this.frameCounter;
			this.frameCounter = num11;
			int num12 = this.type;
			int num13 = 1;
			this.netUpdate = num13 != 0;
			if (num12 == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			int num14 = this.owner;
			int num15 = this.type;
			int width9 = this.width;
			int height3 = this.height;
			float x10 = this.position.X;
			float y9 = this.position.Y;
			int num16 = this.type;
		}

		// Token: 0x060026F7 RID: 9975 RVA: 0x0017CF04 File Offset: 0x0017B104
		private void AI_054()
		{
			int num = this.type;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			if (num != 0)
			{
				if (num == 0)
				{
				}
				int myPlayer2 = Main.myPlayer;
			}
			if (num == 0)
			{
			}
			int myPlayer3 = Main.myPlayer;
			if (num != 0)
			{
				int num2 = 2;
				this.timeLeft = num2;
			}
			if (this.whoAmI == 0)
			{
			}
			int num3 = this.owner;
			int num4 = this.type;
			float x = this.position.X;
			if (num4 == 0)
			{
			}
			float y = this.position.Y;
			int width = this.width;
			float x2 = this.position.X;
			float y2 = this.position.Y;
			float x3 = this.velocity.X;
			this.velocity.X = x3;
			float y3 = this.velocity.Y;
		}

		// Token: 0x060026F8 RID: 9976 RVA: 0x0017D384 File Offset: 0x0017B584
		private void AI_055()
		{
			int num = this.frameCounter;
			this.frameCounter = num;
			int num2 = this.frame;
			this.frame = num2;
			float x = this.velocity.X;
			this.spriteDirection = num2;
			float y = this.velocity.Y;
			if (num2 == 0)
			{
			}
		}

		// Token: 0x060026F9 RID: 9977 RVA: 0x0017D4F0 File Offset: 0x0017B6F0
		private void AI_056()
		{
			int num = 32768;
			this.spriteDirection = num;
			float x = this.velocity.X;
			if (num == 0)
			{
			}
			float y = this.velocity.Y;
			float x2 = this.velocity.X;
		}

		// Token: 0x060026FA RID: 9978 RVA: 0x0017D570 File Offset: 0x0017B770
		private void AI_057()
		{
			float x = this.velocity.X;
			float y = this.velocity.Y;
		}

		// Token: 0x060026FB RID: 9979 RVA: 0x0017D63C File Offset: 0x0017B83C
		private void AI_058()
		{
			int num = this.alpha;
			this.alpha = num;
			float y = this.velocity.Y;
			this.velocity.Y = y;
			float x = this.velocity.X;
			float y2 = this.velocity.Y;
			int num2 = 1;
			this.frame = num2;
		}

		// Token: 0x060026FC RID: 9980 RVA: 0x0017D6D0 File Offset: 0x0017B8D0
		private void AI_059()
		{
			int num = 1;
			this.friendly = num != 0;
			int myPlayer = Main.myPlayer;
			if (this.owner == 0)
			{
			}
			long num2 = 0L;
			float x = this.position.X;
			int width = this.width;
			int height = this.height;
			float y = this.position.Y;
			if (num2 != 0L)
			{
				int num3 = 1;
				this.netUpdate = num3 != 0;
				int width2 = this.width;
				int height2 = this.height;
				float x2 = this.position.X;
				float y2 = this.position.Y;
				if (num3 == 0)
				{
				}
				float x3 = this.velocity.X;
				float num4;
				this.velocity.X = num4;
				float x4 = this.position.X;
				float y3 = this.position.Y;
				float x5 = this.velocity.X;
				int width3 = this.width;
				bool wet = this.wet;
				return;
			}
			this.Kill();
		}

		// Token: 0x060026FD RID: 9981 RVA: 0x0017D7E0 File Offset: 0x0017B9E0
		private void AI_060()
		{
			float num = this.scale;
			this.scale = num;
			float x = this.velocity.X;
			float y = this.velocity.Y;
			this.velocity.X = num;
			Vector2 velocity = this.velocity;
			this.oldVelocity = velocity;
			this.Kill();
			int num2 = this.type;
			int num3 = this.owner;
			int num4 = 103;
			if (num2 == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			float x2 = this.position.X;
			float y2 = this.position.Y;
			int width = this.width;
			bool wet = this.wet;
			if (num2 == 0)
			{
			}
			if (num4 != 0)
			{
				if (num4 == 0)
				{
				}
				if (num4 == 0)
				{
					if (num4 == 0)
					{
					}
					if (num4 == 0)
					{
					}
					this.Kill();
				}
			}
			if (this.owner == 0)
			{
			}
			if (num4 != 0)
			{
				if (num4 == 0)
				{
				}
				if (num4 == 0)
				{
					if (num4 == 0)
					{
					}
					this.Kill();
				}
			}
			float y3 = this.velocity.Y;
			this.velocity.Y = y3;
			int num5 = this.type;
			float x3 = this.position.X;
			float y4 = this.position.Y;
			float x4 = this.velocity.X;
			int width2 = this.width;
			bool wet2 = this.wet;
			if (num5 == 0)
			{
			}
			if (num4 == 0)
			{
			}
			int num6;
			if (num6 != 0 || num4 == 0)
			{
			}
			if (num4 == 0)
			{
			}
			int num7;
			if (num7 != 0 || num4 == 0)
			{
			}
			if (num4 == 0)
			{
			}
			int num8;
			if (num8 != 0 || num4 == 0)
			{
			}
			if (num4 == 0)
			{
			}
			float x5 = this.velocity.X;
			float y5 = this.velocity.Y;
			Vector2 center = base.Center;
			int num9;
			if (num9 == 0)
			{
				float x6 = this.position.X;
				float y6 = this.position.Y;
				int width3 = this.width;
				bool wet3 = this.wet;
				if (num4 == 0)
				{
				}
				float x7 = this.velocity.X;
				float y7 = this.velocity.Y;
			}
			int num10 = this.type;
			float x8 = this.velocity.X;
			float y8 = this.velocity.Y;
			if (num10 == 0)
			{
			}
			float x9 = this.position.X;
			float y9 = this.position.Y;
			int width4 = this.width;
			int height = this.height;
			if (num4 == 0)
			{
			}
			int num11;
			if (num11 != 0 || num4 == 0)
			{
			}
			if (num4 == 0)
			{
			}
			int num12;
			if (num12 != 0 || num4 == 0)
			{
			}
			if (num4 == 0)
			{
			}
			int num13;
			if (num13 != 0 || num4 == 0)
			{
			}
			if (num4 == 0)
			{
			}
			float x10 = this.velocity.X;
			float y10 = this.velocity.Y;
			Vector2 center2 = base.Center;
			int num14;
			if (num14 == 0)
			{
				float x11 = this.position.X;
				float y11 = this.position.Y;
				int num15 = 1;
				if (num15 == 0)
				{
				}
				int width5 = this.width;
				bool wet4 = this.wet;
				if (num15 == 0)
				{
				}
				if (num4 == 0)
				{
				}
				float x12 = this.velocity.X;
				float y12 = this.velocity.Y;
				return;
			}
		}

		// Token: 0x060026FE RID: 9982 RVA: 0x0017DB5C File Offset: 0x0017BD5C
		private bool Chester_IsAnyPlayerTrackingThisProjectile()
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x060026FF RID: 9983 RVA: 0x0017DB78 File Offset: 0x0017BD78
		private void AI_062()
		{
			if (this.type == 0)
			{
			}
			int num = this.owner;
			int num2 = 2;
			this.timeLeft = num2;
			if (num2 == 0)
			{
			}
			this.originalDamage = num2;
			if (num2 == 0)
			{
			}
		}

		// Token: 0x06002700 RID: 9984 RVA: 0x0017EFD0 File Offset: 0x0017D1D0
		private void AI_063()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				float x = this.position.X;
				float y = this.position.Y;
				int num2 = 17402;
				if (num2 == 0)
				{
				}
				Vector2 center = base.Center;
				if (num2 == 0)
				{
				}
				float x2 = this.position.X;
				float y2 = this.position.Y;
				int width = this.width;
				bool wet = this.wet;
				if (num2 == 0)
				{
				}
				return;
			}
		}

		// Token: 0x06002701 RID: 9985 RVA: 0x0017F150 File Offset: 0x0017D350
		private void AI_064()
		{
			int num = 1;
			int num2 = this.type;
			float x = this.velocity.X;
			if (num == 0)
			{
			}
			this.spriteDirection = num;
			this.direction = num;
			int num3 = this.frameCounter;
			int num4 = this.frame;
			this.frameCounter = num3;
			this.frame = num4;
			if (num4 == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			int num5 = this.owner;
			int width = this.width;
			float x2 = this.position.X;
			this.position.X = (float)width;
			int num6 = 1;
			int num7 = 16936;
			int num8 = 32640;
			float x3 = this.position.X;
			float y = this.position.Y;
			this.width = num7;
			this.wet = num8 != 0;
			this.netUpdate = num6 != 0;
			int width2 = this.width;
			bool wet = this.wet;
		}

		// Token: 0x06002702 RID: 9986 RVA: 0x0017F3DC File Offset: 0x0017D5DC
		private void AI_065()
		{
			float x = this.velocity.X;
			float y = this.velocity.Y;
			int width = this.width;
			int height = this.height;
			Vector2 center = base.Center;
			double num;
			Vector2 vector = ((float)num).ToRotationVector2();
			float x2 = this.velocity.X;
			float y2 = this.velocity.Y;
			int num2 = this.alpha;
			float x3 = this.velocity.X;
			float num3 = this.rotation;
			this.alpha = num2;
			this.rotation = x3;
			int num4 = 21846;
			this.frame = num4;
			if (num4 == 0)
			{
			}
			Vector2 center2 = base.Center;
			if (num4 == 0)
			{
			}
			if (num4 == 0)
			{
			}
			this.velocity.X = x3;
			Vector2 vector2;
			float num5 = vector2.Length();
			this.Kill();
		}

		// Token: 0x06002703 RID: 9987 RVA: 0x0017F5B0 File Offset: 0x0017D7B0
		private void AI_066()
		{
			if (this.type == 0)
			{
			}
			if (this.owner != 0)
			{
				int num = 2;
				this.timeLeft = num;
			}
		}

		// Token: 0x06002704 RID: 9988 RVA: 0x0017FF00 File Offset: 0x0017E100
		private void AI_068()
		{
			int direction = this.direction;
			float num = this.rotation;
			int num2 = this.type;
			this.rotation = (float)direction;
			int num3 = this.alpha;
			this.alpha = num3;
			float x = this.velocity.X;
			float y = this.velocity.Y;
			this.velocity.X = x;
			this.velocity.Y = y;
			if (this.alpha == 0)
			{
				int direction2 = this.direction;
				float num4 = this.rotation;
				return;
			}
			int num5 = this.timeLeft;
			int direction3 = this.direction;
			this.spriteDirection = direction3;
			if (this.wet)
			{
				int num6 = 3;
				this.timeLeft = num6;
				return;
			}
		}

		// Token: 0x06002705 RID: 9989 RVA: 0x001800AC File Offset: 0x0017E2AC
		private void AI_069()
		{
			int num = 1;
			if (num == 0)
			{
			}
			Vector2 center = base.Center;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			this.direction = 43143168;
			int direction = this.direction;
			Vector2 vector;
			float num2 = vector.Length();
			this.Kill();
		}

		// Token: 0x06002706 RID: 9990 RVA: 0x00180198 File Offset: 0x0017E398
		private void AI_070()
		{
			Vector2 center = base.Center;
			Vector2 vector;
			float num = vector.Length();
			float x = this.position.X;
			float y = this.position.Y;
			int width = this.width;
			bool wet = this.wet;
			float x2 = this.velocity.X;
			float y2 = this.velocity.Y;
			Vector2 center2 = base.Center;
			int num2 = 1;
			this.netUpdate = num2 != 0;
		}

		// Token: 0x06002707 RID: 9991 RVA: 0x000021DB File Offset: 0x000003DB
		private void AI_075()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002708 RID: 9992 RVA: 0x001802FC File Offset: 0x0017E4FC
		private void AI_092()
		{
			int num = 1;
			int num2 = this.type;
			if (num == 0)
			{
			}
			int num3;
			if (this.direction == 0)
			{
				num3 = 1;
				this.direction = num3;
			}
			Vector2 center = base.Center;
			if (num3 == 0)
			{
			}
			if (!true)
			{
			}
			this.Kill();
		}

		// Token: 0x06002709 RID: 9993 RVA: 0x001805D4 File Offset: 0x0017E7D4
		private void AI_099_1()
		{
			int num = 6;
			this.timeLeft = num;
			int num2 = this.owner;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				if (num == 0)
				{
				}
				int num3 = this.owner;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
			}
			int num4 = 1;
			this.netUpdate = num4 != 0;
			if (num4 == 0)
			{
			}
			float num5 = this.rotation;
			this.rotation = num5;
			if (num4 == 0)
			{
			}
			this.Kill();
		}

		// Token: 0x0600270A RID: 9994 RVA: 0x001809D4 File Offset: 0x0017EBD4
		private void AI_099_2()
		{
			int whoAmI = this.whoAmI;
			if (whoAmI == 0)
			{
			}
			if (whoAmI != 0)
			{
				if (whoAmI == 0)
				{
				}
				int num = this.owner;
				if (whoAmI == 0)
				{
				}
				int num2 = this.type;
			}
		}

		// Token: 0x0600270B RID: 9995 RVA: 0x00180ED4 File Offset: 0x0017F0D4
		private void AI_130_FlameBurstTower()
		{
			Vector2 center = base.Center;
			int num = this.type;
			Vector2 center2 = base.Center;
			if (num == 0)
			{
			}
			Vector2 bottom = base.Bottom;
			if (num == 0)
			{
			}
			Vector2 bottom2 = base.Bottom;
			int direction = this.direction;
			float x = this.position.X;
			float y = this.position.Y;
			int width = this.width;
			bool wet = this.wet;
			int direction2 = this.direction;
			if (this.width == 0)
			{
			}
			int num2;
			float fadeIn;
			if (num2 == 0)
			{
				int direction3 = this.direction;
				if (!wet)
				{
				}
				int num3 = 52429;
				int num4 = 1;
				Dust dust;
				dust.scale = (float)num3;
				dust.noGravity = num4 != 0;
				dust.fadeIn = x;
				dust.noLight = num4 != 0;
				int direction4 = this.direction;
				fadeIn = dust.fadeIn;
				dust.velocity.X = x;
			}
			Vector2 center3 = base.Center;
			Vector2 bottom3 = base.Bottom;
			int width2 = this.width;
			int direction5 = this.direction;
			int height = this.height;
			if (direction5 == 0)
			{
			}
			int num5;
			if (num5 == 0)
			{
				int num6 = 16256;
				int num7 = 1;
				Dust dust2;
				dust2.fadeIn = (float)num6;
				dust2.scale = (float)num6;
				dust2.noGravity = num7 != 0;
				dust2.noLight = num7 != 0;
				float x2 = dust2.velocity.X;
				float y2 = dust2.velocity.Y;
				if (num6 == 0)
				{
				}
				dust2.velocity.X = x;
				dust2.velocity.Y = fadeIn;
				return;
			}
			int num8 = 17056;
			if (num8 == 0)
			{
			}
			if (num8 == 0)
			{
			}
			this.spriteDirection = num8;
			this.direction = num8;
			int num9 = 1;
			this.netUpdate = num9 != 0;
		}

		// Token: 0x0600270C RID: 9996 RVA: 0x00181564 File Offset: 0x0017F764
		private int AI_130_FlameBurstTower_FindTarget(float shot_range, float angleRatioMax, Vector2 shootingSpot, bool canChangeDirection = true)
		{
			int num = 1;
			NPC ownerMinionAttackTargetNPC = this.OwnerMinionAttackTargetNPC;
			int whoAmI;
			if (ownerMinionAttackTargetNPC != null)
			{
				long num2 = 0L;
				bool flag = ownerMinionAttackTargetNPC.CanBeChasedBy(this, num2 != 0L);
				long num3 = 0L;
				bool flag2 = ownerMinionAttackTargetNPC.CanBeChasedBy(this, num3 != 0L);
				Vector2 center = ownerMinionAttackTargetNPC.Center;
				if (num == 0)
				{
				}
				Vector2 center2 = ownerMinionAttackTargetNPC.Center;
				if (num == 0)
				{
				}
				if (!true)
				{
				}
				int direction = this.direction;
				Vector2 center3 = ownerMinionAttackTargetNPC.Center;
				whoAmI = ownerMinionAttackTargetNPC.whoAmI;
			}
			int direction2 = this.direction;
			return whoAmI;
		}

		// Token: 0x0600270D RID: 9997 RVA: 0x001815F0 File Offset: 0x0017F7F0
		private int AI_134_Ballista_FindTarget(float shot_range, float deadBottomAngle, Vector2 shootingSpot)
		{
			int num = 1;
			NPC ownerMinionAttackTargetNPC = this.OwnerMinionAttackTargetNPC;
			int whoAmI;
			if (ownerMinionAttackTargetNPC != null)
			{
				long num2 = 0L;
				bool flag = ownerMinionAttackTargetNPC.CanBeChasedBy(this, num2 != 0L);
				long num3 = 0L;
				bool flag2 = ownerMinionAttackTargetNPC.CanBeChasedBy(this, num3 != 0L);
				Vector2 center = ownerMinionAttackTargetNPC.Center;
				if (num == 0)
				{
				}
				Vector2 center2 = ownerMinionAttackTargetNPC.Center;
				if (num == 0)
				{
				}
				if (!true)
				{
				}
				Vector2 center3 = ownerMinionAttackTargetNPC.Center;
				whoAmI = ownerMinionAttackTargetNPC.whoAmI;
			}
			return whoAmI;
		}

		// Token: 0x0600270E RID: 9998 RVA: 0x00181670 File Offset: 0x0017F870
		private void AI_131_FlameBurstShot()
		{
			if (this.type == 0)
			{
			}
			Vector2 center = base.Center;
			int num = this.alpha;
			this.alpha = num;
			int num2 = this.type;
			int num3 = 1;
			int num4 = 3;
			if (num4 == 0)
			{
			}
			int num5;
			if (num5 != 0)
			{
				float x = this.position.X;
				float y = this.position.Y;
				int width = this.width;
				bool wet = this.wet;
				float x2 = this.velocity.X;
				float y2 = this.velocity.Y;
				if (num4 == 0)
				{
				}
				Dust dust;
				dust.noGravity = num3 != 0;
				float x3 = dust.velocity.X;
				float y3 = dust.velocity.Y;
				if (num4 == 0)
				{
				}
				if (num4 == 0)
				{
				}
				int num6;
				if (num6 == 0)
				{
					float y4 = dust.velocity.Y;
					if (num4 == 0)
					{
					}
					int num7 = Math.Sign((float)num3);
					float fadeIn = dust.fadeIn;
				}
			}
			float x4 = this.velocity.X;
			float y5 = this.velocity.Y;
		}

		// Token: 0x0600270F RID: 9999 RVA: 0x00181788 File Offset: 0x0017F988
		private void AI_134_Ballista()
		{
			int num = 1;
			Vector2 center = base.Center;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int num2 = 100;
			int num3 = 30;
			int num4 = this.type;
			if (num3 == 0)
			{
			}
			this.spriteDirection = num3;
			this.direction = num3;
			int num5 = 1;
			int direction = this.direction;
			this.netUpdate = num5 != 0;
			int num6 = 4059;
			this.rotation = (float)num6;
			if (num6 == 0)
			{
			}
			int num7;
			if (num6 != 0)
			{
				num7 = 17008;
			}
			if (num7 == 0)
			{
			}
			if (num2 != 0)
			{
				if (num2 == 0)
				{
				}
			}
			long num8 = 0L;
			int num9 = 17505;
			if (num9 == 0)
			{
			}
			if (num9 == 0)
			{
			}
			if (!true)
			{
			}
			if (num4 == 0)
			{
			}
			float num10 = this.rotation;
			if (num8 != 0L)
			{
				int num11 = this.owner;
				int myPlayer = Main.myPlayer;
				float num13;
				int num12 = Math.Sign(num13);
				this.direction = num12;
				int num14 = 1;
				this.netUpdate = num14 != 0;
				return;
			}
			float y = this.velocity.Y;
			int direction2 = this.direction;
			int num15 = 1;
			this.tileCollide = num15 != 0;
			this.spriteDirection = direction2;
			this.velocity.Y = y;
		}

		// Token: 0x06002710 RID: 10000 RVA: 0x000021DB File Offset: 0x000003DB
		public static int GetBallistraShotDelay(Player player)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002711 RID: 10001 RVA: 0x00181980 File Offset: 0x0017FB80
		private void AI_135_OgreStomp()
		{
			int num = this.type;
			this.Kill();
		}

		// Token: 0x06002712 RID: 10002 RVA: 0x00181B64 File Offset: 0x0017FD64
		private void AI_136_BetsyBreath()
		{
			this.Kill();
		}

		// Token: 0x06002713 RID: 10003 RVA: 0x00181F24 File Offset: 0x00180124
		private void AI_137_LightningAura()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Vector2 center = base.Center;
			int width = this.width;
			Rectangle hitbox = base.Hitbox;
		}

		// Token: 0x06002714 RID: 10004 RVA: 0x0018219C File Offset: 0x0018039C
		private void AI_138_ExplosiveTrap()
		{
			int num = 1;
			this.direction = num;
			this.spriteDirection = num;
			if (num == 0)
			{
			}
			int num2 = this.type;
			int num3 = 695;
			Vector2 center = base.Center;
			if (num3 == 0)
			{
			}
			int num4 = this.frameCounter;
			this.frameCounter = num4;
			int num5 = this.frame;
			if (num5 == 0)
			{
			}
			int num6 = this.owner;
			if (num5 == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			Vector2 center2 = base.Center;
			if (49728 == 0)
			{
			}
			int num7 = 17168;
			if (num7 == 0)
			{
			}
			if (num7 == 0)
			{
			}
			Rectangle rectangle;
			bool flag = rectangle.Intersects(rectangle);
		}

		// Token: 0x06002715 RID: 10005 RVA: 0x000021DB File Offset: 0x000003DB
		public static int GetExplosiveTrapCooldown(Player player)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002716 RID: 10006 RVA: 0x001822C0 File Offset: 0x001804C0
		private void AI_139_ExplosiveTrapExplosion()
		{
			int num = 1;
			if (num == 0)
			{
			}
			int num2 = this.type;
			bool flag = this.sentry;
			this.alpha = num;
			int num3 = this.frameCounter;
			this.frameCounter = num3;
			int num4 = this.frame;
			this.frame = num4;
			Vector2 top = base.Top;
			Vector2 bottom = base.Bottom;
		}

		// Token: 0x06002717 RID: 10007 RVA: 0x00182324 File Offset: 0x00180524
		private void AI_140_MonkStaffT1()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int num2 = 1;
			if (num2 == 0)
			{
			}
			if (num2 != 0)
			{
				this.Kill();
				return;
			}
			int num3 = this.type;
			int num4 = this.damage;
			float x = this.velocity.X;
			if (num4 == 0)
			{
			}
			this.velocity = num4;
			float x2 = this.velocity.X;
			int num5 = this.alpha;
			this.alpha = num5;
			float num6 = this.rotation;
			int num7 = 16968;
			int num9;
			if (num7 != 0)
			{
				if (num7 == 0)
				{
				}
				Vector2 mouseWorld = Main.MouseWorld;
				float x3 = this.velocity.X;
				float num8 = this.rotation;
				num9 = 1;
				this.netUpdate = num9 != 0;
				this.velocity = num7;
				this.rotation = num8;
				return;
			}
			this.Kill();
			float num10 = this.rotation;
			float num11;
			Vector2 vector = num11.ToRotationVector2();
			Vector2 center = base.Center;
			Vector2 vector2 = num11.ToRotationVector2();
			int num12;
			if (num12 == 0)
			{
				Dust dust;
				float x4 = dust.position.X;
				float y = dust.position.Y;
				float x5 = dust.velocity.X;
				float y2 = dust.velocity.Y;
				dust.velocity.X = x5;
				dust.velocity.Y = y;
			}
			Dust dust2;
			float x6 = dust2.position.X;
			float y3 = dust2.position.Y;
			float x7 = dust2.velocity.X;
			float y4 = dust2.velocity.Y;
			int num13 = 1;
			dust2.velocity.X = x7;
			dust2.velocity.Y = y3;
			dust2.noGravity = num13 != 0;
			dust2.color = num13;
			int num14 = 1;
			Dust dust3;
			float x8 = dust3.velocity.X;
			float y5 = dust3.velocity.Y;
			float num15 = dust3.scale;
			dust3.velocity.X = x8;
			dust3.velocity.Y = y5;
			dust3.noGravity = num14 != 0;
			dust3.scale = x8;
			int num16 = 16956;
			int num17 = this.owner;
			if (num16 == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			if (num9 == 0)
			{
			}
			IEntitySource projectileSource_FromThis = this.GetProjectileSource_FromThis();
			if (49776 == 0)
			{
			}
			int num18 = 1;
			if (num18 == 0)
			{
			}
			int num19 = this.owner;
			int value = num18.m_value;
			if (num18 == 0)
			{
			}
			if (num18 == 0)
			{
			}
			Vector2 center2 = base.Center;
			if (this.type == 0)
			{
			}
			float x9 = this.velocity.X;
			float num21;
			int num20 = Math.Sign(num21);
			float x10 = this.velocity.X;
			this.rotation = x8;
			this.rotation = x8;
			int num22 = this.alpha;
			this.alpha = num22;
			float num23 = this.rotation;
			int num24 = 16968;
			if (num24 != 0)
			{
				if (num24 == 0)
				{
				}
				Vector2 mouseWorld2 = Main.MouseWorld;
				float x11 = this.velocity.X;
				float num25 = this.rotation;
				int num26 = 1;
				this.netUpdate = num26 != 0;
				this.velocity = num24;
				this.rotation = num25;
				return;
			}
			this.Kill();
			int num27 = 2;
			int num28 = this.owner;
			if (num27 == 0)
			{
			}
			int myPlayer2 = Main.myPlayer;
			if (num27 == 0)
			{
			}
			Vector2 mouseWorld3 = Main.MouseWorld;
			if (num27 == 0)
			{
			}
		}

		// Token: 0x06002718 RID: 10008 RVA: 0x0018291C File Offset: 0x00180B1C
		private void AI_141_MonkStaffT1Explosion()
		{
			int num = 1;
			float x = this.position.X;
			float y = this.position.Y;
			if (num == 0)
			{
			}
			Vector2 bottomRight = base.BottomRight;
			int width = this.width;
			this.Kill();
		}

		// Token: 0x06002719 RID: 10009 RVA: 0x00182980 File Offset: 0x00180B80
		private void CreateImpactExplosion(int dustAmountMultiplier, Vector2 explosionOrigin, Point scanAreaStart, Point scanAreaEnd, int explosionRange, [Out] bool causedShockwaves)
		{
			int y = scanAreaStart.Y;
			float y2 = explosionOrigin.Y;
			Tile tile;
			bool flag = tile.active();
			Tile tile2;
			bool flag2 = tile2.active();
			if (y == 0)
			{
			}
			if (y == 0)
			{
			}
			int y3 = scanAreaStart.Y;
		}

		// Token: 0x0600271A RID: 10010 RVA: 0x001829C0 File Offset: 0x00180BC0
		private void CreateImpactExplosion2_SleepyOctopod(Vector2 explosionOrigin, bool causedShockwaves)
		{
			int num = 50;
			int num2 = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			float x = this.position.X;
			float y = this.position.Y;
			int width = this.width;
			bool wet = this.wet;
			if (num == 0)
			{
			}
			Dust dust;
			dust.color = num;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			dust.noLight = num2 != 0;
			int num3 = 100;
			float x2 = this.position.X;
			float y2 = this.position.Y;
			int width2 = this.width;
			bool wet2 = this.wet;
			Dust dust2;
			dust2.frame = num3;
			float num4;
			dust2.noLight = num4 != null;
		}

		// Token: 0x0600271B RID: 10011 RVA: 0x00182A90 File Offset: 0x00180C90
		private void CreateImpactExplosion2_FlailTileCollision(Vector2 explosionOrigin, bool causedShockwaves, Vector2 velocityBeforeCollision)
		{
			if (!true)
			{
			}
			int num = 50;
			int num2 = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			float x = this.position.X;
			float y = this.position.Y;
			int width = this.width;
			bool wet = this.wet;
			Dust dust;
			Color color;
			dust.color = color;
			int num3 = 52429;
			dust.scale = (float)num3;
			dust.noLight = num2 != 0;
			float x2 = dust.velocity.X;
			float y2 = dust.velocity.Y;
			int num4 = 1;
			if (num3 == 0)
			{
			}
			if (num3 == 0)
			{
			}
			float x3 = this.position.X;
			float y3 = this.position.Y;
			int width2 = this.width;
			bool wet2 = this.wet;
			int num5 = 100;
			Dust dust2;
			dust2.color = color;
			dust2.frame = num5;
			if (num5 == 0)
			{
			}
			float num6;
			dust2.scale = num6;
			dust2.noLight = num4 != 0;
			float x4 = dust2.velocity.X;
			float y4 = dust2.velocity.Y;
		}

		// Token: 0x0600271C RID: 10012 RVA: 0x000021DB File Offset: 0x000003DB
		private void AI_142_MonkStaffT2And3()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600271D RID: 10013 RVA: 0x00182BB8 File Offset: 0x00180DB8
		private void AI_143_MonkStaffT2Ghast()
		{
			int num = 1;
			if (num == 0)
			{
			}
			Vector2 center = base.Center;
			SlotId slotId;
			float num2 = slotId.ToFloat();
			if (num == 0)
			{
			}
			float num3;
			if (SoundEngine.GetActiveSound(SlotId.FromFloat(num3)) != null)
			{
				Vector2 center2 = base.Center;
				return;
			}
			if (num == 0)
			{
			}
			int num4 = this.alpha;
		}

		// Token: 0x0600271E RID: 10014 RVA: 0x00182D40 File Offset: 0x00180F40
		private void AI_144_DD2Pet()
		{
			if (!true)
			{
			}
			this.Kill();
		}

		// Token: 0x0600271F RID: 10015 RVA: 0x00183158 File Offset: 0x00181358
		private void AI_145_BookStaffStorm()
		{
			int num = this.soundDelay;
			if (num == 0)
			{
				this.soundDelay = num;
				if (num == 0)
				{
				}
				Vector2 center = base.Center;
				SlotId slotId;
				float num2 = slotId.ToFloat();
			}
			if (num == 0)
			{
			}
			float num3;
			ActiveSound activeSound = SoundEngine.GetActiveSound(SlotId.FromFloat(num3));
			if (activeSound != null)
			{
				Vector2 center2 = base.Center;
				if (num == 0)
				{
				}
				return;
			}
			int num4 = 17302;
			this.Kill();
			Vector2 top = base.Top;
			Vector2 bottom = base.Bottom;
			if (num4 == 0)
			{
			}
			Vector2 center3 = base.Center;
			int height = this.height;
			float y = this.position.Y;
			int num5 = 49952;
			if (num5 == 0)
			{
			}
			if (num5 == 0)
			{
			}
			float y2 = this.velocity.Y;
		}

		// Token: 0x06002720 RID: 10016 RVA: 0x001834C0 File Offset: 0x001816C0
		public bool AI_137_CanHit(Vector2 targetPosition)
		{
			if (!true)
			{
			}
			int num = 63488;
			Vector2 top = base.Top;
			bool flag;
			if (!flag)
			{
			}
			int num2 = 1;
			if (num2 == 0)
			{
			}
			if (num2 == 0)
			{
			}
			if (num2 == 0)
			{
			}
			if (!true)
			{
			}
			if (num == 0)
			{
			}
			Vector2 vector;
			float num3 = vector.Length();
			Vector2 vector2;
			float num4 = vector2.Length();
			bool flag2;
			if (!flag2)
			{
			}
			bool flag3;
			return flag3;
		}

		// Token: 0x06002721 RID: 10017 RVA: 0x00183544 File Offset: 0x00181744
		private Point GetScarabBombDigDirectionSnap8()
		{
			/*
An exception occurred when decompiling this method (06002721)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Point Terraria.Projectile::GetScarabBombDigDirectionSnap8()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0008:
	brtrue(IL_0000, ldloc:int32[exp:bool](var_0_01))
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

		// Token: 0x06002722 RID: 10018 RVA: 0x0018355C File Offset: 0x0018175C
		public Color GetFirstFractalColor()
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06002723 RID: 10019 RVA: 0x00183578 File Offset: 0x00181778
		public void Kill_DirtAndFluidProjectiles_RunDelegateMethodPushUpForHalfBricks(Point pt, float size, Utils.TileActionAttempt plot)
		{
			if (!true)
			{
			}
			Tile tile;
			bool flag = tile.active();
			if (!true)
			{
			}
			Vector2 vector = pt.ToVector2();
		}

		// Token: 0x06002724 RID: 10020 RVA: 0x0018359C File Offset: 0x0018179C
		public bool IsAttachedTo(NPC npc)
		{
			/*
An exception occurred when decompiling this method (06002724)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Projectile::IsAttachedTo(Terraria.NPC)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Projectile::aiStyle, ldloc:Projectile(this)))
	stloc:int32(var_5_11, ldfld:int32(Entity::whoAmI, ldloc:NPC[exp:Entity](npc)))
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

		// Token: 0x06002725 RID: 10021 RVA: 0x001835C0 File Offset: 0x001817C0
		private void BoulderExplosion()
		{
			if (!true)
			{
			}
			int num = this.damage;
			IEntitySource projectileSource_FromThis = this.GetProjectileSource_FromThis();
			Vector2 center = base.Center;
			Vector2 center2 = base.Center;
			int myPlayer = Main.myPlayer;
		}

		// Token: 0x06002726 RID: 10022 RVA: 0x00183604 File Offset: 0x00181804
		private void SpawnWebs()
		{
			Vector2 center = base.Center;
			int num = 15744;
			int num2 = 32640;
			Vector2 center2 = base.Center;
			if (num == 0)
			{
			}
			if (num2 != 0)
			{
				return;
			}
			if (num == 0)
			{
			}
			if (num2 == 0)
			{
			}
			Tile tile;
			bool flag = tile.active();
			int num3;
			if (num3 != 0)
			{
				Tile tile2;
				bool flag2 = tile2.active();
				bool netHost = Main.NetHost;
			}
		}

		// Token: 0x06002727 RID: 10023 RVA: 0x00183664 File Offset: 0x00181864
		public void Kill()
		{
			bool active = this.active;
			if (active)
			{
				if (!active)
				{
				}
				int whoAmI = this.whoAmI;
				int num = this.type;
				float y = this.oldPosition.Y;
				return;
			}
		}

		// Token: 0x06002728 RID: 10024 RVA: 0x0018BC3C File Offset: 0x00189E3C
		private void DropGeodeGems()
		{
		}

		// Token: 0x06002729 RID: 10025 RVA: 0x0018BCBC File Offset: 0x00189EBC
		private void TryGettingHitByOtherPlayersExplosives()
		{
			int num = this.owner;
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
		}

		// Token: 0x0600272A RID: 10026 RVA: 0x0018BCE8 File Offset: 0x00189EE8
		private void DoRainbowCrystalStaffExplosion()
		{
			if (!true)
			{
			}
			Vector2 center = base.Center;
			Vector2 center2 = base.Center;
			int num = 1;
			if (num == 0)
			{
			}
			int num2;
			Dust dust = Dust.CloneDust(num2);
			float num3 = dust.scale;
			float fadeIn = dust.fadeIn;
			dust.scale = num3;
			dust.fadeIn = fadeIn;
			dust.color = num;
			Vector2 center3 = base.Center;
			if (num == 0)
			{
			}
			Vector2 center4 = base.Center;
			int num4;
			Dust dust2 = Dust.CloneDust(num4);
			float num5 = dust2.scale;
			float fadeIn2 = dust2.fadeIn;
			dust2.scale = num5;
			dust2.fadeIn = fadeIn2;
		}

		// Token: 0x0600272B RID: 10027 RVA: 0x0018BDF8 File Offset: 0x00189FF8
		public bool ShouldWallExplode(Vector2 compareSpot, int radius, int minI, int maxI, int minJ, int maxJ)
		{
			/*
An exception occurred when decompiling this method (0600272B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Projectile::ShouldWallExplode(Microsoft.Xna.Framework.Vector2,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000C:
	stloc:uint16(var_3_12, callgetter:uint16(Tile::get_wall, ldloc:Tile[exp:valuetype Terraria.Tile&](var_2)))
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

		// Token: 0x0600272C RID: 10028 RVA: 0x0018BE18 File Offset: 0x0018A018
		public Color GetFloatingDaggerMinionGlowColor()
		{
		}

		// Token: 0x0600272D RID: 10029 RVA: 0x0018BE2C File Offset: 0x0018A02C
		public bool CanExplodeTile(int x, int y)
		{
			/*
An exception occurred when decompiling this method (0600272D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Projectile::CanExplodeTile(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001A:
	stloc:uint16(var_7_24, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_6)))
	stloc:int16(var_12_36, callgetter:int16(Tile::get_frameY, ldloc:Tile[exp:valuetype Terraria.Tile&](var_11)))
	stloc:int32(var_14_40, callgetter:int32(Main::get_UnderworldLayer))
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

		// Token: 0x0600272E RID: 10030 RVA: 0x0018BE80 File Offset: 0x0018A080
		public void ExplodeTiles(Vector2 compareSpot, int radius, int minI, int maxI, int minJ, int maxJ, bool wallSplode)
		{
		}

		// Token: 0x0600272F RID: 10031 RVA: 0x0018BED8 File Offset: 0x0018A0D8
		public void ExplodeCrackedTiles(Vector2 compareSpot, int radius, int minI, int maxI, int minJ, int maxJ)
		{
			int num = 15744;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Tile tile;
			bool flag = tile.active();
			Tile tile2;
			ushort num2 = tile2.type;
			long num3 = 0L;
			long num4 = 0L;
			long num5 = 0L;
			WorldGen.KillTile(radius, maxI, num3 != 0L, num4 != 0L, num5 != 0L);
			Tile tile3;
			bool flag2 = tile3.active();
		}

		// Token: 0x06002730 RID: 10032 RVA: 0x0018BF28 File Offset: 0x0018A128
		public bool TryGetContainerIndex([Out] int containerIndex)
		{
			int num = this.type;
			return true;
		}

		// Token: 0x06002731 RID: 10033 RVA: 0x0018BF40 File Offset: 0x0018A140
		public bool IsInteractible()
		{
			int num = this.type;
			return true;
		}

		// Token: 0x06002732 RID: 10034 RVA: 0x0018BF58 File Offset: 0x0018A158
		public Color GetAlpha(Color newColor)
		{
			int num2;
			do
			{
				if (this.type == 0)
				{
				}
				int num = this.alpha;
				num2 = 50047;
				if (num2 == 0)
				{
				}
			}
			while (num2 != 0);
			if (this.type == 0)
			{
			}
			if (this.type == 0)
			{
			}
			int num3 = this.alpha;
			if (50047 == 0)
			{
			}
			int num4 = 210;
			int num5 = this.alpha;
			int num6 = 50047;
			if (num4 == 0)
			{
			}
			if (num4 == 0)
			{
			}
			if (this.type == 0)
			{
			}
			int num7 = this.alpha;
			int num8 = this.type;
			Vector2 center = base.Center;
			if (num8 == 0)
			{
			}
			if (num6 == 0)
			{
			}
			if (num6 == 0)
			{
			}
			int num9 = this.alpha;
			int num10 = this.alpha;
			if (180 == 0)
			{
			}
			int num11 = this.timeLeft;
			if (num10 == 0)
			{
			}
			int num12 = 32768;
			int num13 = 64;
			if (num13 == 0)
			{
			}
			if (num12 == 0)
			{
			}
			if (num13 == 0)
			{
			}
			if (num13 == 0)
			{
			}
			if (127 == 0)
			{
			}
			int num14 = 255;
			int num15 = 32768;
			if (num14 == 0)
			{
			}
			if (num14 == 0)
			{
			}
			while (num15 == 0)
			{
			}
			if (num15 == 0)
			{
			}
			if (17279 == 0)
			{
			}
			if (227 == 0)
			{
			}
			Color color2;
			float num16;
			Color color = color2 * num16;
			int num17 = 17096;
			if (num17 == 0)
			{
			}
			if (num17 == 0)
			{
			}
			if (50047 == 0)
			{
			}
			int num18 = 255;
			if (num18 == 0)
			{
			}
			if (num18 == 0)
			{
			}
			if (num18 == 0)
			{
			}
			if (17279 == 0)
			{
			}
			if (17279 == 0)
			{
				return;
			}
		}

		// Token: 0x06002733 RID: 10035 RVA: 0x0018C1B0 File Offset: 0x0018A3B0
		public override string ToString()
		{
			string text;
			if (("type:" == null || "type:" != null) && (text == null || text != null) && (", name:" == null || ", name:" != null))
			{
				string name = this.Name;
				string text2;
				string text3;
				string text4;
				string text5;
				string text6;
				if ((name == null || name != null) && (", active:" == null || ", active:" != null) && (text2 == null || text2 != null) && (", whoAmI:" == null || ", whoAmI:" != null) && (text3 == null || text3 != null) && (", identity:" == null || ", identity:" != null) && (text4 == null || text4 != null) && (", ai0:" == null || ", ai0:" != null) && (text5 == null || text5 != null) && (", uuid:" == null || ", uuid:" != null) && (text6 == null || text6 != null))
				{
					string text7;
					return text7;
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06002734 RID: 10036 RVA: 0x0018C278 File Offset: 0x0018A478
		public Projectile()
		{
		}

		// Token: 0x06002735 RID: 10037 RVA: 0x0018C2D8 File Offset: 0x0018A4D8
		// Note: this type is marked as 'beforefieldinit'.
		static Projectile()
		{
		}

		// Token: 0x0400330F RID: 13071
		private static readonly uint[] perIDStaticNPCImmunity;

		// Token: 0x04003310 RID: 13072
		private static List<Tuple<int, float>> _medusaHeadTargetList;

		// Token: 0x04003311 RID: 13073
		private static List<int> _ai164_blacklistedTargets;

		// Token: 0x04003312 RID: 13074
		private static List<int> _ai158_blacklistedTargets;

		// Token: 0x04003313 RID: 13075
		private static List<int> _ai156_blacklistedTargets;

		// Token: 0x04003314 RID: 13076
		private static float[] _CompanionCubeScreamCooldown;

		// Token: 0x04003315 RID: 13077
		public const int SentryLifeTime = 36000;

		// Token: 0x04003316 RID: 13078
		public const int ArrowLifeTime = 1200;

		// Token: 0x04003317 RID: 13079
		public float ownerHitCheckDistance = (float)17530;

		// Token: 0x04003318 RID: 13080
		public bool arrow;

		// Token: 0x04003319 RID: 13081
		public int numHits;

		// Token: 0x0400331A RID: 13082
		public bool bobber;

		// Token: 0x0400331B RID: 13083
		public bool netImportant;

		// Token: 0x0400331C RID: 13084
		public bool noDropItem;

		// Token: 0x0400331D RID: 13085
		public static int maxAI;

		// Token: 0x0400331E RID: 13086
		public bool counterweight;

		// Token: 0x0400331F RID: 13087
		public float scale = (float)16256;

		// Token: 0x04003320 RID: 13088
		public float rotation;

		// Token: 0x04003321 RID: 13089
		public int type;

		// Token: 0x04003322 RID: 13090
		public int alpha;

		// Token: 0x04003323 RID: 13091
		public bool sentry;

		// Token: 0x04003324 RID: 13092
		public short glowMask;

		// Token: 0x04003325 RID: 13093
		public int owner = 255;

		// Token: 0x04003326 RID: 13094
		public FloatArray_3 ai;

		// Token: 0x04003327 RID: 13095
		public FloatArray_3 localAI;

		// Token: 0x04003328 RID: 13096
		public float gfxOffY;

		// Token: 0x04003329 RID: 13097
		public float stepSpeed = (float)16256;

		// Token: 0x0400332A RID: 13098
		public int aiStyle;

		// Token: 0x0400332B RID: 13099
		public int timeLeft;

		// Token: 0x0400332C RID: 13100
		public int soundDelay;

		// Token: 0x0400332D RID: 13101
		public int damage;

		// Token: 0x0400332E RID: 13102
		public int originalDamage;

		// Token: 0x0400332F RID: 13103
		public int spriteDirection = 1;

		// Token: 0x04003330 RID: 13104
		public bool hostile;

		// Token: 0x04003331 RID: 13105
		public bool reflected;

		// Token: 0x04003332 RID: 13106
		public float knockBack;

		// Token: 0x04003333 RID: 13107
		public bool friendly;

		// Token: 0x04003334 RID: 13108
		public int penetrate = 1;

		// Token: 0x04003335 RID: 13109
		private DictionaryIntArray localNPCImmunity;

		// Token: 0x04003336 RID: 13110
		public bool usesLocalNPCImmunity;

		// Token: 0x04003337 RID: 13111
		public bool usesIDStaticNPCImmunity;

		// Token: 0x04003338 RID: 13112
		public bool appliesImmunityTimeOnSingleHits;

		// Token: 0x04003339 RID: 13113
		public int maxPenetrate = 1;

		// Token: 0x0400333A RID: 13114
		public int identity;

		// Token: 0x0400333B RID: 13115
		public float light;

		// Token: 0x0400333C RID: 13116
		public bool netUpdate;

		// Token: 0x0400333D RID: 13117
		public bool netUpdate2;

		// Token: 0x0400333E RID: 13118
		public int netSpam;

		// Token: 0x0400333F RID: 13119
		public Vector2[] oldPos;

		// Token: 0x04003340 RID: 13120
		public float[] oldRot;

		// Token: 0x04003341 RID: 13121
		public int[] oldSpriteDirection;

		// Token: 0x04003342 RID: 13122
		public bool minion;

		// Token: 0x04003343 RID: 13123
		public float minionSlots;

		// Token: 0x04003344 RID: 13124
		public int minionPos;

		// Token: 0x04003345 RID: 13125
		public int restrikeDelay;

		// Token: 0x04003346 RID: 13126
		public bool tileCollide;

		// Token: 0x04003347 RID: 13127
		public int extraUpdates;

		// Token: 0x04003348 RID: 13128
		public bool stopsDealingDamageAfterPenetrateHits;

		// Token: 0x04003349 RID: 13129
		public int numUpdates;

		// Token: 0x0400334A RID: 13130
		public bool ignoreWater;

		// Token: 0x0400334B RID: 13131
		public bool isAPreviewDummy;

		// Token: 0x0400334C RID: 13132
		public bool hide;

		// Token: 0x0400334D RID: 13133
		public bool ownerHitCheck;

		// Token: 0x0400334E RID: 13134
		public bool usesOwnerMeleeHitCD;

		// Token: 0x0400334F RID: 13135
		public DictionaryIntArray playerImmune;

		// Token: 0x04003350 RID: 13136
		public string miscText = "";

		// Token: 0x04003351 RID: 13137
		public bool melee;

		// Token: 0x04003352 RID: 13138
		public bool ranged;

		// Token: 0x04003353 RID: 13139
		public bool magic;

		// Token: 0x04003354 RID: 13140
		public bool coldDamage;

		// Token: 0x04003355 RID: 13141
		public bool noEnchantments;

		// Token: 0x04003356 RID: 13142
		public bool noEnchantmentVisuals;

		// Token: 0x04003357 RID: 13143
		public bool trap;

		// Token: 0x04003358 RID: 13144
		public bool npcProj;

		// Token: 0x04003359 RID: 13145
		public bool originatedFromActivableTile;

		// Token: 0x0400335A RID: 13146
		public int frameCounter;

		// Token: 0x0400335B RID: 13147
		public int frame;

		// Token: 0x0400335C RID: 13148
		public bool manualDirectionChange;

		// Token: 0x0400335D RID: 13149
		public int projUUID;

		// Token: 0x0400335E RID: 13150
		public bool decidesManualFallThrough;

		// Token: 0x0400335F RID: 13151
		public bool shouldFallThrough;

		// Token: 0x04003360 RID: 13152
		public int localNPCHitCooldown;

		// Token: 0x04003361 RID: 13153
		public int idStaticNPCHitCooldown;

		// Token: 0x04003362 RID: 13154
		public int bannerIdToRespondTo;

		// Token: 0x04003363 RID: 13155
		private static Conditions.IsSolid _cachedConditions_solid;

		// Token: 0x04003364 RID: 13156
		private static Conditions.NotNull _cachedConditions_notNull;

		// Token: 0x04003365 RID: 13157
		private static int[] npcCrystalDartList;

		// Token: 0x04003366 RID: 13158
		private static Point[] StardustCellMinionShotJavelins;

		// Token: 0x04003367 RID: 13159
		private static Point[] DaybreakJavelins;

		// Token: 0x04003368 RID: 13160
		private static Point[] BoneJavelinJavelins;

		// Token: 0x04003369 RID: 13161
		public List<Vector2> WhipPointsForCollision;

		// Token: 0x0400336A RID: 13162
		private static Rectangle _lanceHitboxBounds;

		// Token: 0x0400336B RID: 13163
		private static Projectile.NPCDistanceByIndexComparator _medusaTargetComparer;

		// Token: 0x0400336C RID: 13164
		public static List<int> ai92Projectiles;

		// Token: 0x0200041E RID: 1054
		private class NPCDistanceByIndexComparator : IComparer<Tuple<int, float>>
		{
			// Token: 0x06002736 RID: 10038 RVA: 0x000021DB File Offset: 0x000003DB
			public int Compare(Tuple<int, float> npcIndex1, Tuple<int, float> npcIndex2)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06002737 RID: 10039 RVA: 0x0018C2EC File Offset: 0x0018A4EC
			public NPCDistanceByIndexComparator()
			{
			}
		}

		// Token: 0x0200041F RID: 1055
		public struct HallowBossPelletStormInfo
		{
			// Token: 0x06002738 RID: 10040 RVA: 0x0018C300 File Offset: 0x0018A500
			public float GetBulletProgress(int bulletIndex)
			{
				/*
An exception occurred when decompiling this method (06002738)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Projectile/HallowBossPelletStormInfo::GetBulletProgress(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(HallowBossPelletStormInfo::BulletsProgressInStormStartNormalized, ldloc:valuetype Terraria.Projectile/HallowBossPelletStormInfo&(this)))
	stloc:float32(var_1_0D, ldfld:float32(HallowBossPelletStormInfo::BulletsProgressInStormBonusByIndexNormalized, ldloc:valuetype Terraria.Projectile/HallowBossPelletStormInfo&(this)))
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

			// Token: 0x06002739 RID: 10041 RVA: 0x0018C31C File Offset: 0x0018A51C
			public bool IsValid(int bulletIndex)
			{
				/*
An exception occurred when decompiling this method (06002739)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Projectile/HallowBossPelletStormInfo::IsValid(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(HallowBossPelletStormInfo::BulletsProgressInStormStartNormalized, ldloc:valuetype Terraria.Projectile/HallowBossPelletStormInfo&(this)))
	stloc:float32(var_1_0D, ldfld:float32(HallowBossPelletStormInfo::BulletsProgressInStormBonusByIndexNormalized, ldloc:valuetype Terraria.Projectile/HallowBossPelletStormInfo&(this)))
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

			// Token: 0x0600273A RID: 10042 RVA: 0x0018C338 File Offset: 0x0018A538
			public Vector2 GetBulletPosition(int bulletIndex, Vector2 centerPoint)
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
				float startAngle = this.StartAngle;
				float anglePerBullet = this.AnglePerBullet;
				if (!true)
				{
				}
				float stormTotalRange = this.StormTotalRange;
				float bulletsProgressInStormStartNormalized = this.BulletsProgressInStormStartNormalized;
				float bulletsProgressInStormBonusByIndexNormalized = this.BulletsProgressInStormBonusByIndexNormalized;
				return 1;
			}

			// Token: 0x0600273B RID: 10043 RVA: 0x0018C380 File Offset: 0x0018A580
			public Rectangle GetBulletHitbox(int bulletIndex, Vector2 centerPoint)
			{
				Vector2 bulletPosition = this.GetBulletPosition(bulletIndex, centerPoint);
				float x = this.BulletSize.X;
				float y = this.BulletSize.Y;
				if (!true)
				{
				}
				Rectangle rectangle;
				return rectangle;
			}

			// Token: 0x0400336D RID: 13165
			public float StartAngle;

			// Token: 0x0400336E RID: 13166
			public float AnglePerBullet;

			// Token: 0x0400336F RID: 13167
			public int BulletsInStorm;

			// Token: 0x04003370 RID: 13168
			public float BulletsProgressInStormStartNormalized;

			// Token: 0x04003371 RID: 13169
			public float BulletsProgressInStormBonusByIndexNormalized;

			// Token: 0x04003372 RID: 13170
			public float StormTotalRange;

			// Token: 0x04003373 RID: 13171
			public Vector2 BulletSize;
		}
	}
}
