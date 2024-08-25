using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Utilities;
using Terraria.Achievements;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.GameContent.Achievements;
using Terraria.GameContent.Creative;
using Terraria.GameContent.Events;
using Terraria.GameContent.ObjectInteractions;
using Terraria.GameContent.UI;
using Terraria.GameInput;
using Terraria.Graphics.Shaders;
using Terraria.IO;
using Terraria.Localization;
using Terraria.UI;
using Terraria.UI.Chat;
using Terraria.Utilities;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Terraria
{
	// Token: 0x02000404 RID: 1028
	public class Player : Entity, IFixLoadedData
	{
		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06002293 RID: 8851 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06002294 RID: 8852 RVA: 0x00116144 File Offset: 0x00114344
		public static int tileRangeX
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06002295 RID: 8853 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06002296 RID: 8854 RVA: 0x00116154 File Offset: 0x00114354
		public static int tileRangeY
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06002297 RID: 8855 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06002298 RID: 8856 RVA: 0x00116164 File Offset: 0x00114364
		public static int tileTargetX
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06002299 RID: 8857 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x0600229A RID: 8858 RVA: 0x00116174 File Offset: 0x00114374
		public static int tileTargetY
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x0600229B RID: 8859 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x0600229C RID: 8860 RVA: 0x00116184 File Offset: 0x00114384
		public static int jumpHeight
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x0600229D RID: 8861 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x0600229E RID: 8862 RVA: 0x00116194 File Offset: 0x00114394
		public static float jumpSpeed
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x0600229F RID: 8863 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x060022A0 RID: 8864 RVA: 0x001161A4 File Offset: 0x001143A4
		public static int BlockInteractionWithProjectiles
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x060022A1 RID: 8865 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x060022A2 RID: 8866 RVA: 0x001161B4 File Offset: 0x001143B4
		public static bool lastPound
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x060022A3 RID: 8867 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x060022A4 RID: 8868 RVA: 0x001161C4 File Offset: 0x001143C4
		public static int musicNotes
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x060022A5 RID: 8869 RVA: 0x001161D4 File Offset: 0x001143D4
		public Microsoft.Xna.Framework.Vector2 BlehOldPositionFixer
		{
			get
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x060022A6 RID: 8870 RVA: 0x001161EC File Offset: 0x001143EC
		public float HeightOffsetVisual
		{
			get
			{
				/*
An exception occurred when decompiling this method (060022A6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Player::get_HeightOffsetVisual()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0016:
	brtrue(IL_0000, logicnot:bool(ldloc:Mount[exp:bool](var_0_06)))
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
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x060022A7 RID: 8871 RVA: 0x00116214 File Offset: 0x00114414
		public float HeightOffsetHitboxCenter
		{
			get
			{
				/*
An exception occurred when decompiling this method (060022A7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Player::get_HeightOffsetHitboxCenter()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0016:
	brtrue(IL_0000, logicnot:bool(ldloc:Mount[exp:bool](var_0_06)))
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
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x060022A8 RID: 8872 RVA: 0x0011623C File Offset: 0x0011443C
		public float MountXOffset
		{
			get
			{
				/*
An exception occurred when decompiling this method (060022A8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Player::get_MountXOffset()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_1_15, callgetter:int32(Mount::get_PlayerXOFfset, ldloc:Mount(var_0_06)))
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

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x060022A9 RID: 8873 RVA: 0x00116260 File Offset: 0x00114460
		public int HeightOffsetBoost
		{
			get
			{
				Mount mount = this.mount;
				int heightBoost;
				if (mount._active)
				{
					heightBoost = mount.HeightBoost;
					return heightBoost;
				}
				if (mount != null)
				{
					return heightBoost;
				}
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x060022AA RID: 8874 RVA: 0x0011628C File Offset: 0x0011448C
		public int HeightMapOffset
		{
			get
			{
				Mount mount = this.mount;
				int playerHeadOffset;
				if (mount._active)
				{
					playerHeadOffset = mount.PlayerHeadOffset;
					return playerHeadOffset;
				}
				if (mount != null)
				{
					return playerHeadOffset;
				}
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x060022AB RID: 8875 RVA: 0x001162B8 File Offset: 0x001144B8
		public Rectangle HitboxForBestiaryNearbyCheck
		{
			get
			{
				/*
An exception occurred when decompiling this method (060022AB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Rectangle Terraria.Player::get_HitboxForBestiaryNearbyCheck()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_0B, ldfld:float32(Vector2::X, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](Entity::position, ldloc:Player[exp:Entity](this))))
	stloc:float32(var_1_17, ldfld:float32(Vector2::Y, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](Entity::position, ldloc:Player[exp:Entity](this))))
	stloc:int32(var_2_1E, ldfld:int32(Entity::width, ldloc:Player[exp:Entity](this)))
	stloc:bool(var_3_25, ldfld:bool(Entity::wet, ldloc:Player[exp:Entity](this)))
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

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x060022AC RID: 8876 RVA: 0x001162EC File Offset: 0x001144EC
		public bool IsStandingStillForSpecialEffects
		{
			get
			{
				/*
An exception occurred when decompiling this method (060022AC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::get_IsStandingStillForSpecialEffects()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000F:
	stloc:float32(var_1_1A, ldfld:float32(Vector2::Y, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](Entity::velocity, ldloc:Player[exp:Entity](this))))
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

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x060022AD RID: 8877 RVA: 0x00116318 File Offset: 0x00114518
		// (set) Token: 0x060022AE RID: 8878 RVA: 0x00116350 File Offset: 0x00114550
		public Microsoft.Xna.Framework.Vector2 MountedCenter
		{
			get
			{
				int width = this.width;
				float x = this.position.X;
				float y = this.position.Y;
				float heightOffsetHitboxCenter = this.HeightOffsetHitboxCenter;
				Microsoft.Xna.Framework.Vector2 vector;
				return vector;
			}
			set
			{
				int width = this.width;
				float heightOffsetHitboxCenter = this.HeightOffsetHitboxCenter;
			}
		}

		// Token: 0x060022AF RID: 8879 RVA: 0x0011636C File Offset: 0x0011456C
		public void RotateRelativePoint(float x, float y)
		{
		}

		// Token: 0x060022B0 RID: 8880 RVA: 0x0011637C File Offset: 0x0011457C
		public Microsoft.Xna.Framework.Vector2 RotatedRelativePointOld(Microsoft.Xna.Framework.Vector2 pos, bool rotateForward = true)
		{
			/*
An exception occurred when decompiling this method (060022B0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 Terraria.Player::RotatedRelativePointOld(Microsoft.Xna.Framework.Vector2,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0041:
	stloc:int32(var_7_47, call:int32(Utils::ToInt, ldc.i4:bool(1)))
	stloc:float32(var_11_5A, ldfld:float32(Vector2::X, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](Entity::position, ldloc:Player[exp:Entity](this))))
	stloc:float32(var_12_67, ldfld:float32(Vector2::Y, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](Entity::position, ldloc:Player[exp:Entity](this))))
	stloc:float32(var_13_74, ldfld:float32(Vector2::X, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](Player::fullRotationOrigin, ldloc:Player(this))))
	stloc:float32(var_14_81, ldfld:float32(Vector2::Y, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](Player::fullRotationOrigin, ldloc:Player(this))))
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

		// Token: 0x060022B1 RID: 8881 RVA: 0x00116414 File Offset: 0x00114614
		public Microsoft.Xna.Framework.Vector2 RotatedRelativePoint(Microsoft.Xna.Framework.Vector2 pos, bool reverseRotation = false, bool addGfxOffY = true)
		{
			PlayerSittingHelper playerSittingHelper;
			do
			{
				int num = 1;
				float num2 = this.fullRotation;
				PlayerSleepingHelper playerSleepingHelper = this.sleeping;
				Microsoft.Xna.Framework.Vector2 bottom = base.Bottom;
				float num3 = this.gfxOffY;
				if (num == 0)
				{
				}
				int playerOffset = this.mount.PlayerOffset;
				if (num == 0)
				{
				}
				float num4 = this.gfxOffY;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				playerSittingHelper = this.sitting;
			}
			while (playerSittingHelper == null);
			if (playerSittingHelper == null)
			{
				return;
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x060022B2 RID: 8882 RVA: 0x00116490 File Offset: 0x00114690
		public bool TileReplacementEnabled
		{
			get
			{
				/*
An exception occurred when decompiling this method (060022B2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::get_TileReplacementEnabled()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32[](var_0_06, ldfld:int32[](Player::builderAccStatus, ldloc:Player(this)))
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

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x060022B3 RID: 8883 RVA: 0x001164A4 File Offset: 0x001146A4
		public override Microsoft.Xna.Framework.Vector2 VisualPosition
		{
			get
			{
				float num = this.gfxOffY;
				float x = this.position.X;
				float y = this.position.Y;
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x060022B4 RID: 8884 RVA: 0x001164D8 File Offset: 0x001146D8
		public bool CCed
		{
			get
			{
				return (!this.frozen && !this.webbed) || true;
			}
		}

		// Token: 0x060022B5 RID: 8885 RVA: 0x001164F8 File Offset: 0x001146F8
		public bool CanDemonHeartAccessoryBeShown()
		{
			bool flag = this.IsItemSlotUnlockedAndUsable(8);
			Item[] array = this.armor;
			bool questItem = array.questItem;
			int ownTime = array.ownTime;
			return true;
		}

		// Token: 0x060022B6 RID: 8886 RVA: 0x00116534 File Offset: 0x00114734
		public bool CanMasterModeAccessoryBeShown()
		{
			bool flag = this.IsItemSlotUnlockedAndUsable(9);
			Item[] array = this.armor;
			bool instanced = array.instanced;
			int timeLeftInWhichTheItemCannotBeTakenByEnemies = array.timeLeftInWhichTheItemCannotBeTakenByEnemies;
			return true;
		}

		// Token: 0x060022B7 RID: 8887 RVA: 0x00116570 File Offset: 0x00114770
		public int GetAmountOfExtraAccessorySlotsToShow()
		{
			/*
An exception occurred when decompiling this method (060022B7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.Player::GetAmountOfExtraAccessorySlotsToShow()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_06, call:bool(Player::CanDemonHeartAccessoryBeShown, ldloc:Player(this)))
	stloc:bool(var_1_0D, call:bool(Player::CanMasterModeAccessoryBeShown, ldloc:Player(this)))
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

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x060022B8 RID: 8888 RVA: 0x0011658C File Offset: 0x0011478C
		public float miscCounterNormalized
		{
			get
			{
				/*
An exception occurred when decompiling this method (060022B8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Player::get_miscCounterNormalized()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Player::miscCounter, ldloc:Player(this)))
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

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x060022B9 RID: 8889 RVA: 0x001165A0 File Offset: 0x001147A0
		// (set) Token: 0x060022BA RID: 8890 RVA: 0x001165B0 File Offset: 0x001147B0
		public bool Male
		{
			get
			{
				/*
An exception occurred when decompiling this method (060022B9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::get_Male()

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
			set
			{
				bool male = this.Male;
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x060022BB RID: 8891 RVA: 0x001165D4 File Offset: 0x001147D4
		// (set) Token: 0x060022BC RID: 8892 RVA: 0x001165E4 File Offset: 0x001147E4
		public bool ZoneDungeon
		{
			get
			{
				bool flag;
				return flag;
			}
			set
			{
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x060022BD RID: 8893 RVA: 0x001165F4 File Offset: 0x001147F4
		// (set) Token: 0x060022BE RID: 8894 RVA: 0x00116604 File Offset: 0x00114804
		public bool ZoneCorrupt
		{
			get
			{
				bool flag;
				return flag;
			}
			set
			{
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x060022BF RID: 8895 RVA: 0x00116614 File Offset: 0x00114814
		// (set) Token: 0x060022C0 RID: 8896 RVA: 0x00116624 File Offset: 0x00114824
		public bool ZoneHallow
		{
			get
			{
				bool flag;
				return flag;
			}
			set
			{
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x060022C1 RID: 8897 RVA: 0x00116634 File Offset: 0x00114834
		// (set) Token: 0x060022C2 RID: 8898 RVA: 0x00116644 File Offset: 0x00114844
		public bool ZoneMeteor
		{
			get
			{
				bool flag;
				return flag;
			}
			set
			{
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x060022C3 RID: 8899 RVA: 0x00116654 File Offset: 0x00114854
		// (set) Token: 0x060022C4 RID: 8900 RVA: 0x00116664 File Offset: 0x00114864
		public bool ZoneJungle
		{
			get
			{
				bool flag;
				return flag;
			}
			set
			{
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x060022C5 RID: 8901 RVA: 0x00116674 File Offset: 0x00114874
		// (set) Token: 0x060022C6 RID: 8902 RVA: 0x00116684 File Offset: 0x00114884
		public bool ZoneSnow
		{
			get
			{
				bool flag;
				return flag;
			}
			set
			{
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x060022C7 RID: 8903 RVA: 0x00116694 File Offset: 0x00114894
		// (set) Token: 0x060022C8 RID: 8904 RVA: 0x001166A4 File Offset: 0x001148A4
		public bool ZoneCrimson
		{
			get
			{
				bool flag;
				return flag;
			}
			set
			{
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x060022C9 RID: 8905 RVA: 0x001166B4 File Offset: 0x001148B4
		// (set) Token: 0x060022CA RID: 8906 RVA: 0x001166C4 File Offset: 0x001148C4
		public bool ZoneWaterCandle
		{
			get
			{
				bool flag;
				return flag;
			}
			set
			{
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x060022CB RID: 8907 RVA: 0x001166D4 File Offset: 0x001148D4
		// (set) Token: 0x060022CC RID: 8908 RVA: 0x001166E4 File Offset: 0x001148E4
		public bool ZonePeaceCandle
		{
			get
			{
				bool flag;
				return flag;
			}
			set
			{
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x060022CD RID: 8909 RVA: 0x001166F4 File Offset: 0x001148F4
		// (set) Token: 0x060022CE RID: 8910 RVA: 0x00116704 File Offset: 0x00114904
		public bool ZoneTowerSolar
		{
			get
			{
				bool flag;
				return flag;
			}
			set
			{
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x060022CF RID: 8911 RVA: 0x00116714 File Offset: 0x00114914
		// (set) Token: 0x060022D0 RID: 8912 RVA: 0x00116724 File Offset: 0x00114924
		public bool ZoneTowerVortex
		{
			get
			{
				bool flag;
				return flag;
			}
			set
			{
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x060022D1 RID: 8913 RVA: 0x00116734 File Offset: 0x00114934
		// (set) Token: 0x060022D2 RID: 8914 RVA: 0x00116744 File Offset: 0x00114944
		public bool ZoneTowerNebula
		{
			get
			{
				bool flag;
				return flag;
			}
			set
			{
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x060022D3 RID: 8915 RVA: 0x00116754 File Offset: 0x00114954
		// (set) Token: 0x060022D4 RID: 8916 RVA: 0x00116764 File Offset: 0x00114964
		public bool ZoneTowerStardust
		{
			get
			{
				bool flag;
				return flag;
			}
			set
			{
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x060022D5 RID: 8917 RVA: 0x00116774 File Offset: 0x00114974
		// (set) Token: 0x060022D6 RID: 8918 RVA: 0x00116784 File Offset: 0x00114984
		public bool ZoneDesert
		{
			get
			{
				bool flag;
				return flag;
			}
			set
			{
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x060022D7 RID: 8919 RVA: 0x00116794 File Offset: 0x00114994
		// (set) Token: 0x060022D8 RID: 8920 RVA: 0x001167A4 File Offset: 0x001149A4
		public bool ZoneGlowshroom
		{
			get
			{
				bool flag;
				return flag;
			}
			set
			{
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x060022D9 RID: 8921 RVA: 0x001167B4 File Offset: 0x001149B4
		// (set) Token: 0x060022DA RID: 8922 RVA: 0x001167C4 File Offset: 0x001149C4
		public bool ZoneUndergroundDesert
		{
			get
			{
				bool flag;
				return flag;
			}
			set
			{
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x060022DB RID: 8923 RVA: 0x001167D4 File Offset: 0x001149D4
		// (set) Token: 0x060022DC RID: 8924 RVA: 0x001167E4 File Offset: 0x001149E4
		public bool ZoneSkyHeight
		{
			get
			{
				bool flag;
				return flag;
			}
			set
			{
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x060022DD RID: 8925 RVA: 0x001167F4 File Offset: 0x001149F4
		// (set) Token: 0x060022DE RID: 8926 RVA: 0x00116804 File Offset: 0x00114A04
		public bool ZoneOverworldHeight
		{
			get
			{
				bool flag;
				return flag;
			}
			set
			{
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x060022DF RID: 8927 RVA: 0x00116814 File Offset: 0x00114A14
		// (set) Token: 0x060022E0 RID: 8928 RVA: 0x00116824 File Offset: 0x00114A24
		public bool ZoneDirtLayerHeight
		{
			get
			{
				bool flag;
				return flag;
			}
			set
			{
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x060022E1 RID: 8929 RVA: 0x00116834 File Offset: 0x00114A34
		// (set) Token: 0x060022E2 RID: 8930 RVA: 0x00116844 File Offset: 0x00114A44
		public bool ZoneRockLayerHeight
		{
			get
			{
				bool flag;
				return flag;
			}
			set
			{
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x060022E3 RID: 8931 RVA: 0x00116854 File Offset: 0x00114A54
		// (set) Token: 0x060022E4 RID: 8932 RVA: 0x00116864 File Offset: 0x00114A64
		public bool ZoneUnderworldHeight
		{
			get
			{
				bool flag;
				return flag;
			}
			set
			{
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x060022E5 RID: 8933 RVA: 0x00116874 File Offset: 0x00114A74
		// (set) Token: 0x060022E6 RID: 8934 RVA: 0x00116884 File Offset: 0x00114A84
		public bool ZoneBeach
		{
			get
			{
				bool flag;
				return flag;
			}
			set
			{
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x060022E7 RID: 8935 RVA: 0x00116894 File Offset: 0x00114A94
		// (set) Token: 0x060022E8 RID: 8936 RVA: 0x001168A4 File Offset: 0x00114AA4
		public bool ZoneRain
		{
			get
			{
				bool flag;
				return flag;
			}
			set
			{
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x060022E9 RID: 8937 RVA: 0x001168B4 File Offset: 0x00114AB4
		// (set) Token: 0x060022EA RID: 8938 RVA: 0x001168C4 File Offset: 0x00114AC4
		public bool ZoneSandstorm
		{
			get
			{
				bool flag;
				return flag;
			}
			set
			{
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x060022EB RID: 8939 RVA: 0x001168D4 File Offset: 0x00114AD4
		// (set) Token: 0x060022EC RID: 8940 RVA: 0x001168E4 File Offset: 0x00114AE4
		public bool ZoneOldOneArmy
		{
			get
			{
				bool flag;
				return flag;
			}
			set
			{
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x060022ED RID: 8941 RVA: 0x001168F4 File Offset: 0x00114AF4
		// (set) Token: 0x060022EE RID: 8942 RVA: 0x00116904 File Offset: 0x00114B04
		public bool ZoneGranite
		{
			get
			{
				bool flag;
				return flag;
			}
			set
			{
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x060022EF RID: 8943 RVA: 0x00116914 File Offset: 0x00114B14
		// (set) Token: 0x060022F0 RID: 8944 RVA: 0x00116924 File Offset: 0x00114B24
		public bool ZoneMarble
		{
			get
			{
				bool flag;
				return flag;
			}
			set
			{
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x060022F1 RID: 8945 RVA: 0x00116934 File Offset: 0x00114B34
		// (set) Token: 0x060022F2 RID: 8946 RVA: 0x00116944 File Offset: 0x00114B44
		public bool ZoneHive
		{
			get
			{
				bool flag;
				return flag;
			}
			set
			{
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x060022F3 RID: 8947 RVA: 0x00116954 File Offset: 0x00114B54
		// (set) Token: 0x060022F4 RID: 8948 RVA: 0x00116964 File Offset: 0x00114B64
		public bool ZoneGemCave
		{
			get
			{
				bool flag;
				return flag;
			}
			set
			{
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x060022F5 RID: 8949 RVA: 0x00116974 File Offset: 0x00114B74
		// (set) Token: 0x060022F6 RID: 8950 RVA: 0x00116984 File Offset: 0x00114B84
		public bool ZoneLihzhardTemple
		{
			get
			{
				bool flag;
				return flag;
			}
			set
			{
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x060022F7 RID: 8951 RVA: 0x00116994 File Offset: 0x00114B94
		// (set) Token: 0x060022F8 RID: 8952 RVA: 0x001169A4 File Offset: 0x00114BA4
		public bool ZoneGraveyard
		{
			get
			{
				bool flag;
				return flag;
			}
			set
			{
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x060022F9 RID: 8953 RVA: 0x001169B4 File Offset: 0x00114BB4
		// (set) Token: 0x060022FA RID: 8954 RVA: 0x001169C4 File Offset: 0x00114BC4
		public bool ZoneShadowCandle
		{
			get
			{
				bool flag;
				return flag;
			}
			set
			{
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x060022FB RID: 8955 RVA: 0x001169D4 File Offset: 0x00114BD4
		// (set) Token: 0x060022FC RID: 8956 RVA: 0x001169E4 File Offset: 0x00114BE4
		public bool ZoneShimmer
		{
			get
			{
				bool flag;
				return flag;
			}
			set
			{
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x060022FD RID: 8957 RVA: 0x001169F4 File Offset: 0x00114BF4
		public bool ShoppingZone_AnyBiome
		{
			get
			{
				bool flag;
				return flag;
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x060022FE RID: 8958 RVA: 0x00116A20 File Offset: 0x00114C20
		public bool ShoppingZone_BelowSurface
		{
			get
			{
				/*
An exception occurred when decompiling this method (060022FE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::get_ShoppingZone_BelowSurface()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	stloc:float32(var_0_0B, ldfld:float32(Vector2::Y, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](Entity::position, ldloc:Player[exp:Entity](this))))
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
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x060022FF RID: 8959 RVA: 0x00116A3C File Offset: 0x00114C3C
		public bool ShoppingZone_Forest
		{
			get
			{
				bool shoppingZone_AnyBiome = this.ShoppingZone_AnyBiome;
				return this.ShoppingZone_BelowSurface;
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06002300 RID: 8960 RVA: 0x00116A58 File Offset: 0x00114C58
		public Microsoft.Xna.Framework.Vector2 Directions
		{
			get
			{
				int direction = this.direction;
				float num = this.gravDir;
				Microsoft.Xna.Framework.Vector2 vector;
				return vector;
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06002301 RID: 8961 RVA: 0x00116A74 File Offset: 0x00114C74
		public Item HeldItem
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002301)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Item Terraria.Player::get_HeldItem()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Vector2(var_0_0B, ldfld:Vector2(Entity::position, ldfld:class Terraria.Item[][exp:Entity](Player::inventory, ldloc:Player(this))))
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

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06002302 RID: 8962 RVA: 0x00116A8C File Offset: 0x00114C8C
		public int breathCDMax
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002302)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.Player::get_breathCDMax()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Vector2(var_0_0B, ldfld:Vector2(Entity::position, ldfld:class Terraria.Item[][exp:Entity](Player::inventory, ldloc:Player(this))))
	stloc:int32(var_1_12, ldfld:int32(Player::itemAnimation, ldloc:Player(this)))
	stloc:bool(var_2_19, ldfld:bool(Player::accDivingHelm, ldloc:Player(this)))
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

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06002303 RID: 8963 RVA: 0x00116AB4 File Offset: 0x00114CB4
		public bool ShouldFloatInWater
		{
			get
			{
				if (!this.canFloatInWater || this.controlDown)
				{
				}
				return true;
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06002304 RID: 8964 RVA: 0x00116AD4 File Offset: 0x00114CD4
		public bool CanBeTalkedTo
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002304)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::get_CanBeTalkedTo()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001D:
	brtrue(IL_001D, logicnot:bool(ldloc:bool(var_0)))
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
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06002305 RID: 8965 RVA: 0x00116B00 File Offset: 0x00114D00
		// (set) Token: 0x06002306 RID: 8966 RVA: 0x00116B10 File Offset: 0x00114D10
		public bool IsVoidVaultEnabled
		{
			get
			{
				bool flag;
				return flag;
			}
			set
			{
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06002307 RID: 8967 RVA: 0x00116B20 File Offset: 0x00114D20
		public bool DeadOrGhost
		{
			get
			{
				return !this.dead || true;
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06002308 RID: 8968 RVA: 0x00116B38 File Offset: 0x00114D38
		public bool TryingToHoverUp
		{
			get
			{
				return !this.controlUp || true;
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06002309 RID: 8969 RVA: 0x00116B50 File Offset: 0x00114D50
		public bool TryingToHoverDown
		{
			get
			{
				return !this.controlDown || true;
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x0600230A RID: 8970 RVA: 0x00116B68 File Offset: 0x00114D68
		public Microsoft.Xna.Framework.Vector2 DefaultSize
		{
			get
			{
				return 16936;
			}
		}

		// Token: 0x0600230B RID: 8971 RVA: 0x00116B7C File Offset: 0x00114D7C
		public EntityShadowInfo GetAdvancedShadow(int shadowIndex)
		{
			int num = this.availableAdvancedShadowsCount;
			int lastAddedAvancedShadow = this._lastAddedAvancedShadow;
			int num2 = 60;
			int num3 = 1073741824.ModulusPositive(num2);
			return this._advancedShadows;
		}

		// Token: 0x0600230C RID: 8972 RVA: 0x00116BB0 File Offset: 0x00114DB0
		public void UpdateAdvancedShadows()
		{
			int num = this.availableAdvancedShadowsCount;
			int lastAddedAvancedShadow = this._lastAddedAvancedShadow;
			EntityShadowInfo[] advancedShadows = this._advancedShadows;
			this.availableAdvancedShadowsCount = num;
			this._lastAddedAvancedShadow = num;
		}

		// Token: 0x0600230D RID: 8973 RVA: 0x00116BE4 File Offset: 0x00114DE4
		public void ResetAdvancedShadows()
		{
		}

		// Token: 0x0600230E RID: 8974 RVA: 0x00116BF4 File Offset: 0x00114DF4
		public void SetCompositeArmFront(bool enabled, Player.CompositeArmStretchAmount stretch, float rotation)
		{
			float num = this.gravDir;
		}

		// Token: 0x0600230F RID: 8975 RVA: 0x00116C08 File Offset: 0x00114E08
		public void SetCompositeArmBack(bool enabled, Player.CompositeArmStretchAmount stretch, float rotation)
		{
			float num = this.gravDir;
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06002310 RID: 8976 RVA: 0x00116C1C File Offset: 0x00114E1C
		// (set) Token: 0x06002311 RID: 8977 RVA: 0x00116C3C File Offset: 0x00114E3C
		public bool UsingBiomeTorches
		{
			get
			{
				if (this.unlockedBiomeTorches)
				{
					int[] array = this.builderAccStatus;
					return;
				}
			}
			set
			{
				int[] array = this.builderAccStatus;
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06002312 RID: 8978 RVA: 0x00116C50 File Offset: 0x00114E50
		// (set) Token: 0x06002313 RID: 8979 RVA: 0x00116C70 File Offset: 0x00114E70
		public bool UsingSuperCart
		{
			get
			{
				if (this.unlockedSuperCart)
				{
					bool flag = this.enabledSuperCart;
					return;
				}
			}
			set
			{
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06002314 RID: 8980 RVA: 0x00116C80 File Offset: 0x00114E80
		public float bowEffectiveDamage
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002314)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Player::get_bowEffectiveDamage()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(Player::rangedDamage, ldloc:Player(this)))
	stloc:float32(var_1_0D, ldfld:float32(Player::rangedMultDamage, ldloc:Player(this)))
	stloc:float32(var_2_14, ldfld:float32(Player::arrowDamageAdditiveStack, ldloc:Player(this)))
	stloc:float32(var_3_1B, ldfld:float32(Player::arrowDamage, ldloc:Player(this)))
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

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06002315 RID: 8981 RVA: 0x00116CA8 File Offset: 0x00114EA8
		public float gunEffectiveDamage
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002315)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Player::get_gunEffectiveDamage()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(Player::rangedDamage, ldloc:Player(this)))
	stloc:float32(var_1_0D, ldfld:float32(Player::bulletDamage, ldloc:Player(this)))
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

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06002316 RID: 8982 RVA: 0x00116CC4 File Offset: 0x00114EC4
		public float specialistEffectiveDamage
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002316)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Player::get_specialistEffectiveDamage()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(Player::rangedDamage, ldloc:Player(this)))
	stloc:float32(var_1_0D, ldfld:float32(Player::rocketDamage, ldloc:Player(this)))
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

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06002317 RID: 8983 RVA: 0x00116CE0 File Offset: 0x00114EE0
		public bool ShouldNotDraw
		{
			get
			{
				while (this.invis && this.itemAnimation == 0 && !this.isDisplayDollOrInanimate)
				{
				}
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06002318 RID: 8984 RVA: 0x00116D08 File Offset: 0x00114F08
		public bool isLockedToATile
		{
			get
			{
				return this.sitting == null || true;
			}
		}

		// Token: 0x06002319 RID: 8985 RVA: 0x00116D20 File Offset: 0x00114F20
		public void SetTalkNPC(int npcIndex, bool fromNet = false)
		{
			this.talkNPC = npcIndex;
			LocalUser localUser = this.LocalUser;
			if (localUser != null)
			{
				if (localUser != null)
				{
					return;
				}
				int num = this.talkNPC;
				int num2 = this.selectedItem;
				this.DpadRadial.LoadNPCHeldItem(num2);
			}
			bool logicHost = Main.LogicHost;
			int num3 = this.talkNPC;
			int num4 = this.talkNPC;
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x0600231A RID: 8986 RVA: 0x00116DA4 File Offset: 0x00114FA4
		public bool PortalPhysicsEnabled
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600231A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::get_PortalPhysicsEnabled()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Player::_portalPhysicsTime, ldloc:Player(this)))
	stloc:bool(var_1_12, ldfld:bool(Mount::_active, ldfld:Mount(Player::mount, ldloc:Player(this))))
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

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x0600231B RID: 8987 RVA: 0x00116DC8 File Offset: 0x00114FC8
		public bool MountFishronSpecial
		{
			get
			{
				int num = this.statLifeMax2;
				int num2 = this.statLife;
				if (!this.wet || this.lavaWet || this.honeyWet)
				{
					bool flag = this.dripping;
					if (!flag)
					{
						float mountFishronSpecialCounter = this.MountFishronSpecialCounter;
						if (!flag)
						{
						}
						if (flag)
						{
							float x = this.position.X;
							float y = this.position.Y;
							int width = this.width;
							bool wet = this.wet;
							bool flag2;
							return flag2;
						}
					}
				}
				return true;
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x0600231C RID: 8988 RVA: 0x00116E44 File Offset: 0x00115044
		public bool HasMinionRestTarget
		{
			get
			{
				float x = this.MinionRestTargetPoint.X;
				float y = this.MinionRestTargetPoint.Y;
				if (!true)
				{
				}
				if (!true)
				{
				}
				bool flag;
				return flag;
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x0600231D RID: 8989 RVA: 0x00116E74 File Offset: 0x00115074
		public bool HasMinionAttackTargetNPC
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600231D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::get_HasMinionAttackTargetNPC()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Player::MinionAttackTargetNPC, ldloc:Player(this)))
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

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x0600231E RID: 8990 RVA: 0x00116E88 File Offset: 0x00115088
		public bool ItemTimeIsZero
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600231E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::get_ItemTimeIsZero()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Player::itemTime, ldloc:Player(this)))
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

		// Token: 0x0600231F RID: 8991 RVA: 0x00116E9C File Offset: 0x0011509C
		public void SetItemTime(int frames)
		{
			this.itemTime = frames;
			this.itemTimeMax = frames;
		}

		// Token: 0x06002320 RID: 8992 RVA: 0x00116EB8 File Offset: 0x001150B8
		public void ApplyItemTime(Item sItem)
		{
			int useTime = sItem.useTime;
			this.itemTime = useTime;
			this.itemTimeMax = useTime;
		}

		// Token: 0x06002321 RID: 8993 RVA: 0x00116EDC File Offset: 0x001150DC
		public void ApplyItemTime(Item sItem, float multiplier)
		{
			int useTime = sItem.useTime;
			this.itemTime = 32640;
			this.itemTimeMax = 32640;
		}

		// Token: 0x06002322 RID: 8994 RVA: 0x00116F08 File Offset: 0x00115108
		public void SetDummyItemTime(int frames)
		{
			this.itemAnimation = frames;
			this.itemTime = frames;
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06002323 RID: 8995 RVA: 0x00116F24 File Offset: 0x00115124
		public bool ItemAnimationJustStarted
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002323)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::get_ItemAnimationJustStarted()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Player::itemAnimationMax, ldloc:Player(this)))
	stloc:int32(var_1_0D, ldfld:int32(Player::itemAnimation, ldloc:Player(this)))
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

		// Token: 0x06002324 RID: 8996 RVA: 0x00116F40 File Offset: 0x00115140
		public void SetItemAnimation(int frames)
		{
			this.itemAnimation = frames;
			this.itemAnimationMax = frames;
		}

		// Token: 0x06002325 RID: 8997 RVA: 0x00116F5C File Offset: 0x0011515C
		private void ApplyItemAnimation(Item sItem)
		{
			if (sItem.autoReuse && sItem.reuseDelay == 0)
			{
				int useAnimation = sItem.useAnimation;
				int stack = sItem.stack;
				int shoot = sItem.shoot;
				byte useStyle = sItem.useStyle;
				return;
			}
			if (sItem.melee)
			{
				int useAnimation2 = sItem.useAnimation;
				float num = this.meleeSpeed;
				int num2 = 32640;
				this.itemAnimation = num2;
				this.itemAnimationMax = num2;
				int num3 = sItem.reuseDelay;
				this.reuseDelay = num3;
				return;
			}
			bool summon = sItem.summon;
			if (summon)
			{
				if (!summon)
				{
				}
				if (summon)
				{
					int useAnimation3 = sItem.useAnimation;
					float num4 = this.summonerWeaponSpeedBonus;
					float num5 = this.whipUseTimeMultiplier;
					return;
				}
			}
			int createTile = sItem.createTile;
			int useAnimation4 = sItem.useAnimation;
			float num6 = this.tileSpeed;
		}

		// Token: 0x06002326 RID: 8998 RVA: 0x00117038 File Offset: 0x00115238
		public void MatchItemTimeToItemAnimation()
		{
			int num = this.itemAnimation;
			this.itemTime = num;
		}

		// Token: 0x06002327 RID: 8999 RVA: 0x00117054 File Offset: 0x00115254
		public bool InOpposingTeam(Player otherPlayer)
		{
			if (this.hostile && otherPlayer.hostile)
			{
				if (otherPlayer.team != 0)
				{
					int num = this.team;
				}
			}
			return true;
		}

		// Token: 0x06002328 RID: 9000 RVA: 0x00117084 File Offset: 0x00115284
		public bool TeamChangeAllowed()
		{
			return true;
		}

		// Token: 0x06002329 RID: 9001 RVA: 0x00117094 File Offset: 0x00115294
		public void HealEffect(int healAmount, bool broadcast = true)
		{
			float x = this.position.X;
			float y = this.position.Y;
			int width = this.width;
			bool wet = this.wet;
			if (32640 == 0)
			{
			}
			if (32640 == 0)
			{
			}
			bool netClientOnly = Main.NetClientOnly;
			int whoAmI = this.whoAmI;
			if (32640 == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			int whoAmI2 = this.whoAmI;
		}

		// Token: 0x0600232A RID: 9002 RVA: 0x00117100 File Offset: 0x00115300
		public void ManaEffect(int manaAmount)
		{
			float x = this.position.X;
			float y = this.position.Y;
			int width = this.width;
			bool wet = this.wet;
			if (32640 == 0)
			{
			}
			if (32640 == 0)
			{
			}
			bool netClientOnly = Main.NetClientOnly;
			int whoAmI = this.whoAmI;
			if (32640 == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			int whoAmI2 = this.whoAmI;
		}

		// Token: 0x0600232B RID: 9003 RVA: 0x0011716C File Offset: 0x0011536C
		public void InterruptItemUsageIfOverTile(int tileTypeToBeOver)
		{
			if (!true)
			{
			}
			int tileTargetX = Player.tileTargetX;
			int tileTargetY = Player.tileTargetY;
			Tile tile;
			bool flag = tile.active();
		}

		// Token: 0x0600232C RID: 9004 RVA: 0x00117190 File Offset: 0x00115390
		public Microsoft.Xna.Framework.Vector2 GetHairDrawOffset(int hairID, bool hatHair)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x0600232D RID: 9005 RVA: 0x001171C4 File Offset: 0x001153C4
		public Microsoft.Xna.Framework.Vector2 GetHelmetDrawOffset()
		{
			if (!true)
			{
			}
			int num = 1;
			if (num == 0)
			{
			}
			int num2 = this.head;
			int value = num.m_value;
			int num3 = this.hair;
			int direction = this.direction;
			float num4 = this.gravDir;
			if (num3 == 0)
			{
			}
			int direction2 = this.direction;
			int num5 = this.hair;
			int direction3 = this.direction;
			float num6 = this.gravDir;
			if (num5 == 0)
			{
				return;
			}
		}

		// Token: 0x0600232E RID: 9006 RVA: 0x0011722C File Offset: 0x0011542C
		public Microsoft.Xna.Framework.Vector2 GetBeardDrawOffsetFromHelmet()
		{
			/*
An exception occurred when decompiling this method (0600232E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 Terraria.Player::GetBeardDrawOffsetFromHelmet()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0006:
	stloc:int32(var_0_0C, ldfld:int32(Player::head, ldloc:Player(this)))
	stloc:int32(var_2_15, ldfld:int32(Entity::direction, ldloc:Player[exp:Entity](this)))
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

		// Token: 0x0600232F RID: 9007 RVA: 0x00117250 File Offset: 0x00115450
		public Microsoft.Xna.Framework.Vector2 GetFaceHeadOffsetFromHelmet()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			sbyte b = this.faceHead;
			int num = this.head;
			int direction = this.direction;
			float num2 = this.gravDir;
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06002330 RID: 9008 RVA: 0x00117284 File Offset: 0x00115484
		public Microsoft.Xna.Framework.Vector2 GetHelmetOffsetAddonFromFaceHead(Microsoft.Xna.Framework.Vector2 headOffset)
		{
			/*
An exception occurred when decompiling this method (06002330)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 Terraria.Player::GetHelmetOffsetAddonFromFaceHead(Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int8(var_0_06, ldfld:int8(Player::faceHead, ldloc:Player(this)))
	stloc:int32(var_1_0D, ldfld:int32(Player::head, ldloc:Player(this)))
	stloc:int32(var_3_1A, ldfld:int32(Entity::direction, ldloc:Player[exp:Entity](this)))
	stloc:float32(var_4_21, ldfld:float32(Player::gravDir, ldloc:Player(this)))
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

		// Token: 0x06002331 RID: 9009 RVA: 0x001172BC File Offset: 0x001154BC
		public Microsoft.Xna.Framework.Vector2 GetLegsDrawOffset()
		{
			/*
An exception occurred when decompiling this method (06002331)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 Terraria.Player::GetLegsDrawOffset()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001E:
	stloc:int32(var_5_26, ldfld:int32(int32::m_value, ldloc:int32[exp:int32&](var_0_0C)))
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

		// Token: 0x06002332 RID: 9010 RVA: 0x001172F0 File Offset: 0x001154F0
		public void AccumulateGolfingScore(int score)
		{
			int num = this.golferScoreAccumulated;
			this.golferScoreAccumulated = num;
		}

		// Token: 0x06002333 RID: 9011 RVA: 0x0011730C File Offset: 0x0011550C
		public static byte FindClosest(Microsoft.Xna.Framework.Vector2 Position, int Width, int Height)
		{
			/*
An exception occurred when decompiling this method (06002333)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte Terraria.Player::FindClosest(Microsoft.Xna.Framework.Vector2,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_3:
	brtrue(IL_0000, ldloc:int32[exp:bool](var_0_01))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

		// Token: 0x06002334 RID: 9012 RVA: 0x00117344 File Offset: 0x00115544
		public void ToggleInv()
		{
			if (!true)
			{
			}
			bool mapFullscreen = Main.mapFullscreen;
			Main.mapFullscreen = false;
			this.LockGamepadTileInteractions();
		}

		// Token: 0x06002335 RID: 9013 RVA: 0x001174EC File Offset: 0x001156EC
		private static void OpenInventory()
		{
			if (!true)
			{
			}
			Recipe.FindRecipes(false);
			if (!true)
			{
			}
			Main.playerInventory = true;
		}

		// Token: 0x06002336 RID: 9014 RVA: 0x0011750C File Offset: 0x0011570C
		public void ToggleCreativeMenu()
		{
			if (!this.dead)
			{
				byte b = this.difficulty;
				if (b == 0)
				{
				}
				bool mapFullscreen = Main.mapFullscreen;
				if (b == 0)
				{
				}
				Main.mapFullscreen = false;
				return;
			}
		}

		// Token: 0x06002337 RID: 9015 RVA: 0x001175FC File Offset: 0x001157FC
		public void dropItemCheck()
		{
			if (!true)
			{
			}
			bool playerInventory = Main.playerInventory;
			int num = this.noThrow;
			this.noThrow = num;
		}

		// Token: 0x06002338 RID: 9016 RVA: 0x00117D1C File Offset: 0x00115F1C
		public void DropSelectedItem()
		{
			Item[] array = this.inventory;
			int whoAmI = this.whoAmI;
			Item item;
			if (item == null || item != null)
			{
				int num = this.selectedItem;
				Item[] array2 = this.inventory;
				Main.mouseItem = item;
				if (array2 == null)
				{
				}
				Recipe.FindRecipes(false);
				Microsoft.Xna.Framework.Vector2 position = this.inventory.position;
				if (position == null)
				{
					return;
				}
				if (position == null)
				{
				}
				bool mouseRight = Main.mouseRight;
				bool flag = this.mouseInterface;
				if (!flag)
				{
					if (!flag)
					{
					}
					bool mouseRightRelease = Main.mouseRightRelease;
				}
				if (!flag)
				{
				}
				bool playerInventory = Main.playerInventory;
				if (!flag)
				{
				}
				if (Main.mouseItem.type == 0)
				{
				}
				int stack = Main.mouseItem.stack;
				Item[] array3 = this.inventory;
				if (stack == 0)
				{
				}
				Item mouseItem = Main.mouseItem;
				if (mouseItem == null || mouseItem != null)
				{
					int num2 = 1;
					this.delayUseItem = num2 != 0;
					int whoAmI2 = this.whoAmI;
					if (num2 == 0)
					{
					}
					int myPlayer = Main.myPlayer;
					Microsoft.Xna.Framework.Vector2 position2 = this.inventory.position;
					Microsoft.Xna.Framework.Vector2 top = base.Top;
					if (this.direction == 0)
					{
					}
					int num3 = 4;
					IEntitySource itemSource_Misc = this.GetItemSource_Misc(num3);
					Item[] array4 = this.inventory;
					float x = this.position.X;
					float y = this.position.Y;
					int width = this.width;
					bool wet = this.wet;
					int num4 = 32768;
					Item[] array5 = this.inventory;
					Microsoft.Xna.Framework.Vector2 position3 = array5.position;
					if (num4 == 0)
					{
					}
					Microsoft.Xna.Framework.Vector2 position4 = array5.position;
					Item[] array6 = this.inventory;
					Microsoft.Xna.Framework.Vector2 position5 = array6.position;
					if (position5 != null)
					{
						if (position5 == null)
						{
							goto IL_0250;
						}
						int num5 = this.selectedItem;
					}
					Item[] array7 = this.inventory;
					if (position5 == null || position5 != null)
					{
						if (this.selectedItem == 0)
						{
						}
						int tileWand = array6.tileWand;
						if (num4 == 0)
						{
						}
						if (array6 != null || array6 == null)
						{
						}
						int direction = this.direction;
						float x2 = this.velocity.X;
						bool mouseRight2 = Main.mouseRight;
						bool flag2 = this.mouseInterface;
						if (flag2)
						{
							if (!flag2)
							{
							}
							bool playerInventory2 = Main.playerInventory;
						}
						if (!flag2)
						{
						}
						int type = Main.mouseItem.type;
						Item[] array8 = this.inventory;
						if (item == null || item != null)
						{
							if (num4 == 0)
							{
							}
							return;
						}
					}
				}
			}
			IL_0250:
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06002339 RID: 9017 RVA: 0x00117F80 File Offset: 0x00116180
		public void PlayDroppedItemAnimation(int time)
		{
			int num = this.selectedItem;
			Item[] array = this.inventory;
			this.nonTorch = num;
			this.selectedItem = 58;
			this.JustDroppedAnItem = true;
			this.DropSelectedItem_InterruptActionsThatUseAnimations();
		}

		// Token: 0x0600233A RID: 9018 RVA: 0x00117FBC File Offset: 0x001161BC
		public void DropSelectedItem_InterruptActionsThatUseAnimations()
		{
			int num = this.heldProj;
			int num2 = this.heldProj;
			if (num2 != 0)
			{
				int whoAmI = this.whoAmI;
			}
			if (num2 == 0)
			{
			}
			if (num2 != 0)
			{
				int whoAmI2 = this.whoAmI;
			}
		}

		// Token: 0x0600233B RID: 9019 RVA: 0x00117FF4 File Offset: 0x001161F4
		public int FindBuffIndex(int type)
		{
			/*
An exception occurred when decompiling this method (0600233B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.Player::FindBuffIndex(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000F:
	stloc:int32[](var_2_15, ldfld:int32[](Player::buffTime, ldloc:Player(this)))
	stloc:int32[](var_3_1C, ldfld:int32[](Player::buffType, ldloc:Player(this)))
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

		// Token: 0x0600233C RID: 9020 RVA: 0x00118020 File Offset: 0x00116220
		public void AddBuff(int type, int timeToAdd, bool quiet = true, bool foodHack = false)
		{
			bool[] array = this.buffImmune;
			if (array == null)
			{
				if (array == null)
				{
				}
				int whoAmI;
				if (array != null)
				{
					if (array == null)
					{
					}
					int myPlayer = Main.myPlayer;
					whoAmI = this.whoAmI;
				}
				if (whoAmI == 0)
				{
				}
				if (whoAmI != 0)
				{
					long num = 0L;
					if (whoAmI == 0)
					{
					}
					if (whoAmI == 0)
					{
					}
					int[] array2 = this.buffType;
					if (whoAmI != 0)
					{
						this.DelBuff((int)num);
					}
					return;
				}
				int num2 = this.AddBuff_DetermineBuffTimeToAdd(type, timeToAdd);
				bool flag = this.AddBuff_TryUpdatingExistingBuffTime(type, num2);
			}
		}

		// Token: 0x0600233D RID: 9021 RVA: 0x001180C0 File Offset: 0x001162C0
		private bool AddBuff_ActuallyTryToAddTheBuff(int type, int time)
		{
			/*
An exception occurred when decompiling this method (0600233D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::AddBuff_ActuallyTryToAddTheBuff(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001A:
	call:void(Player::DelBuff, ldloc:Player(this), ldloc:int64[exp:int32](var_0_01))
	stfld:int32(int32::m_value, ldfld:int32[][exp:int32&](Player::buffType, ldloc:Player(this)), ldloc:int32(type))
	stloc:int32[](var_3_35, ldfld:int32[](Player::buffTime, ldloc:Player(this)))
	stfld:int32(int32::m_value, ldloc:int32[][exp:int32&](var_3_35), ldloc:int32(time))
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

		// Token: 0x0600233E RID: 9022 RVA: 0x0011810C File Offset: 0x0011630C
		private void AddBuff_RemoveOldMeleeBuffsOfMatchingType(int type)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				long num2 = 0L;
				if (num == 0)
				{
				}
				int[] array = this.buffType;
				if (this.buffType != null)
				{
					this.DelBuff((int)num2);
				}
				return;
			}
		}

		// Token: 0x0600233F RID: 9023 RVA: 0x00118140 File Offset: 0x00116340
		private void AddBuff_RemoveOldPetBuffsOfMatchingType(int type)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				long num2 = 0L;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				int[] array = this.buffType;
				if (num != 0)
				{
					this.DelBuff((int)num2);
				}
				return;
			}
			string text = this.name;
			if (text == null)
			{
			}
			if (text != null)
			{
				long num3 = 0L;
				if (text == null)
				{
				}
				if (text == null)
				{
				}
				int[] array2 = this.buffType;
				if (text != null)
				{
					this.DelBuff((int)num3);
				}
				return;
			}
		}

		// Token: 0x06002340 RID: 9024 RVA: 0x0011819C File Offset: 0x0011639C
		private bool AddBuff_TryUpdatingExistingBuffTime(int type, int time)
		{
			/*
An exception occurred when decompiling this method (06002340)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::AddBuff_TryUpdatingExistingBuffTime(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0007:
	stloc:int32[](var_2_0D, ldfld:int32[](Player::buffType, ldloc:Player(this)))
	stloc:int32[](var_3_14, ldfld:int32[](Player::buffTime, ldloc:Player(this)))
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

		// Token: 0x06002341 RID: 9025 RVA: 0x001181C8 File Offset: 0x001163C8
		private int AddBuff_DetermineBuffTimeToAdd(int type, int time1)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool expertMode = Main.expertMode;
			int whoAmI = this.whoAmI;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			long num2 = 48157L;
			if (num == 0)
			{
			}
			if (true)
			{
			}
			int num3 = 1;
			if (num3 == 0)
			{
			}
			if (num3 != 0)
			{
				if (num3 == 0)
				{
				}
				bool masterMode = Main.masterMode;
				if (num2 == 0L)
				{
				}
				bool expertMode2 = Main.expertMode;
			}
			return time1;
		}

		// Token: 0x06002342 RID: 9026 RVA: 0x0011822C File Offset: 0x0011642C
		public void DelBuff(int b)
		{
			int[] array = this.buffTime;
			if (this.buffType == null)
			{
			}
			int[] array2 = this.buffTime;
			int[] array3 = this.buffType;
		}

		// Token: 0x06002343 RID: 9027 RVA: 0x0011825C File Offset: 0x0011645C
		public void ClearBuff(int type)
		{
			int num = 1;
			long num2 = 0L;
			if (num == 0)
			{
			}
			int[] array = this.buffType;
			this.DelBuff((int)num2);
		}

		// Token: 0x06002344 RID: 9028 RVA: 0x00118280 File Offset: 0x00116480
		public int CountBuffs()
		{
			/*
An exception occurred when decompiling this method (06002344)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.Player::CountBuffs()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0009:
	stloc:int32[](var_3_0F, ldfld:int32[](Player::buffType, ldloc:Player(this)))
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

		// Token: 0x06002345 RID: 9029 RVA: 0x0011829C File Offset: 0x0011649C
		public void QuickHeal()
		{
			if (!this.cursed && !this.frozen && !this.webbed && !this.stoned && !this.dead)
			{
				int num = this.statLife;
				int num2 = this.statLifeMax2;
				int num3 = this.potionDelay;
			}
		}

		// Token: 0x06002346 RID: 9030 RVA: 0x001183AC File Offset: 0x001165AC
		public Item QuickHeal_GetItemToUse()
		{
			/*
An exception occurred when decompiling this method (06002346)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Item Terraria.Player::QuickHeal_GetItemToUse()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Player::statLifeMax2, ldloc:Player(this)))
	stloc:int32(var_1_0D, ldfld:int32(Player::statLife, ldloc:Player(this)))
	stloc:class Terraria.Item[](var_2_14, ldfld:class Terraria.Item[](Player::inventory, ldloc:Player(this)))
	stloc:class Terraria.Item[](var_8_34, ldfld:class Terraria.Item[](Chest::item, ldfld:Chest(Player::bank4, ldloc:Player(this))))
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

		// Token: 0x06002347 RID: 9031 RVA: 0x001183F0 File Offset: 0x001165F0
		public void QuickMana()
		{
			if (!this.cursed && !this.frozen && !this.webbed && !this.stoned && !this.dead)
			{
				int num = this.statMana;
				int num2 = this.statManaMax2;
				Item item = this.QuickMana_GetItemToUse();
				if (item != null)
				{
					bool flag = this.ItemCheck_CheckCanUse(item);
					LegacySoundStyle useSound = item.UseSound;
					float x = this.position.X;
					float y = this.position.Y;
					if (item.potion)
					{
						this.ApplyPotionDelay(item);
					}
					this.ApplyLifeAndOrMana(item);
					int stack = item.stack;
					item.stack = stack;
					long num3 = 0L;
					item.TurnToAir(num3 != 0L);
					if (stack == 0)
					{
					}
					Recipe.FindRecipes(false);
					return;
				}
			}
		}

		// Token: 0x06002348 RID: 9032 RVA: 0x001184B4 File Offset: 0x001166B4
		public Item QuickMana_GetItemToUse()
		{
			for (;;)
			{
				Item[] array = this.inventory;
				int num = this.potionDelay;
				if (num != 0 && num != 0)
				{
					Chest chest = this.bank4;
					Item[] item = chest.item;
					int num2 = this.potionDelay;
					if (num2 != 0 && num2 != 0)
					{
						return;
					}
				}
			}
		}

		// Token: 0x06002349 RID: 9033 RVA: 0x0011850C File Offset: 0x0011670C
		public void TrySwitchingLoadout(int loadoutIndex)
		{
			int num = this.itemTime;
		}

		// Token: 0x0600234A RID: 9034 RVA: 0x00118600 File Offset: 0x00116800
		public bool GetHasAvailableBuff([Out] bool canUse)
		{
			/*
An exception occurred when decompiling this method (0600234A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::GetHasAvailableBuff(System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00CD:
	stloc:int32(var_15_CE, ldc.i4:int32(1))
	stfld:bool(bool::m_value, ldloc:bool[exp:bool&](canUse), ldloc:int32[exp:bool](var_15_CE))
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

		// Token: 0x0600234B RID: 9035 RVA: 0x001186E4 File Offset: 0x001168E4
		public void QuickBuff()
		{
			if (!this.cursed && !this.frozen && !this.webbed && !this.stoned && !this.dead)
			{
				int num = this.CountBuffs();
				Item item = this.QuickBuff_PickBestFoodItem();
				int num4;
				if (item != null)
				{
					bool flag = this.ItemCheck_CheckCanUse(item);
					int num2 = item.buffTime;
					int num3 = item.buffType;
					LegacySoundStyle useSound = item.UseSound;
					num4 = 3600;
					if (item.consumable)
					{
						int stack = item.stack;
						item.stack = stack;
						long num5 = 0L;
						item.TurnToAir(num5 != 0L);
						return;
					}
				}
				int num6 = this.CountBuffs();
				if (num4 == 0)
				{
				}
				Item[] array = this.inventory;
				Item[] item2 = this.bank4.item;
				return;
			}
		}

		// Token: 0x0600234C RID: 9036 RVA: 0x00118868 File Offset: 0x00116A68
		private Item QuickBuff_PickBestFoodItem()
		{
			/*
An exception occurred when decompiling this method (0600234C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Item Terraria.Player::QuickBuff_PickBestFoodItem()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0031:
	stloc:class Terraria.Item[](var_11_37, ldfld:class Terraria.Item[](Player::inventory, ldloc:Player(this)))
	stloc:class Terraria.Item[](var_15_53, ldfld:class Terraria.Item[](Chest::item, ldfld:Chest(Player::bank4, ldloc:Player(this))))
	brtrue(IL_0000, logicnot:bool(ldloc:int32[exp:bool](var_2_05)))
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

		// Token: 0x0600234D RID: 9037 RVA: 0x001188D0 File Offset: 0x00116AD0
		private int QuickBuff_FindFoodPriority(int buffType)
		{
			return 2;
		}

		// Token: 0x0600234E RID: 9038 RVA: 0x001188E4 File Offset: 0x00116AE4
		private bool QuickBuff_ShouldBotherUsingThisBuff(int attemptedType)
		{
			/*
An exception occurred when decompiling this method (0600234E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::QuickBuff_ShouldBotherUsingThisBuff(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_3:
	brtrue(IL_0000, ldloc:int32[][exp:bool](var_6_4C))
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

		// Token: 0x0600234F RID: 9039 RVA: 0x00118948 File Offset: 0x00116B48
		public void QuickMount()
		{
			Mount mount;
			for (;;)
			{
				mount = this.mount;
				if (mount._active)
				{
					break;
				}
				if (this.frozen || this.tongued || this.webbed || this.stoned)
				{
					return;
				}
				float num = this.gravDir;
				if (!this.dead && !this.noItems)
				{
					Item item = this.QuickMount_GetItemToUse();
					if (item == null)
					{
						goto IL_00B3;
					}
					int mountType = item.mountType;
					bool flag = this.mount.CanMount(mountType, this);
					bool flag2 = this.ItemCheck_CheckCanUse(item);
					bool flag3 = this.QuickMinecartSnap();
					Mount mount2 = this.mount;
					int mountType2 = item.mountType;
					long num2 = 0L;
					mount2.SetMount(mountType2, this, num2 != 0L);
					if (item.UseSound != null)
					{
						goto Block_7;
					}
				}
			}
			mount.Dismount(this);
			return;
			Block_7:
			Microsoft.Xna.Framework.Vector2 center = base.Center;
			return;
			IL_00B3:
			this.QuickMinecart();
		}

		// Token: 0x06002350 RID: 9040 RVA: 0x00118A10 File Offset: 0x00116C10
		public bool CanFitSpace(int heightBoost)
		{
			int height = this.height;
			float x = this.position.X;
			float y = this.position.Y;
			if (height == 0)
			{
			}
			float x2 = this.velocity.X;
			float y2 = this.velocity.Y;
			int width = this.width;
			if (height == 0)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06002351 RID: 9041 RVA: 0x00118A6C File Offset: 0x00116C6C
		public bool UseQuickMineCartHook()
		{
			/*
An exception occurred when decompiling this method (06002351)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::UseQuickMineCartHook()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0094:
	stloc:Vector2(var_26_A0, callgetter:Vector2(Entity::get_Center, ldloc:Player[exp:Entity](this)))
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

		// Token: 0x06002352 RID: 9042 RVA: 0x00118B24 File Offset: 0x00116D24
		public bool UseQuickMineCartSnapHook()
		{
			/*
An exception occurred when decompiling this method (06002352)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::UseQuickMineCartSnapHook()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0030:
	stloc:Rectangle(var_8_36, callgetter:Rectangle(Entity::get_Hitbox, ldloc:Player[exp:Entity](this)))
	stloc:int64(var_9_39, ldc.i4:int64(0))
	stloc:bool(var_10_4C, call:bool(Tile::active, call:Tile[exp:valuetype Terraria.Tile&](Framing::GetTileSafely, ldc.i4:int32(-2147483648), ldloc:int64[exp:int32](var_9_39))))
	stloc:Vector2(var_17_5A, callgetter:Vector2(Entity::get_Center, ldloc:Player[exp:Entity](this)))
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

		// Token: 0x06002353 RID: 9043 RVA: 0x00118B98 File Offset: 0x00116D98
		private void QuickMinecart()
		{
			int num = 1;
			float x = this.position.X;
			if (num == 0)
			{
			}
			int tileRangeX = Player.tileRangeX;
			float x2 = this.position.X;
			int width = this.width;
			int tileRangeX2 = Player.tileRangeX;
			float y = this.position.Y;
			int tileRangeY = Player.tileRangeY;
			float y2 = this.position.Y;
			int height = this.height;
			int tileRangeY2 = Player.tileRangeY;
			int num2 = 32640;
			Rectangle hitbox = base.Hitbox;
			long num3 = 0L;
			bool flag = Framing.GetTileSafely(tileRangeX, (int)num3).active();
			if (num2 == 0)
			{
			}
			if (num2 == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 center = base.Center;
			this.LaunchMinecartHook(tileRangeX, 1073741824);
		}

		// Token: 0x06002354 RID: 9044 RVA: 0x00118C60 File Offset: 0x00116E60
		private bool QuickMinecartSnap()
		{
			/*
An exception occurred when decompiling this method (06002354)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::QuickMinecartSnap()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0030:
	stloc:Rectangle(var_8_36, callgetter:Rectangle(Entity::get_Hitbox, ldloc:Player[exp:Entity](this)))
	stloc:int64(var_9_39, ldc.i4:int64(0))
	stloc:bool(var_10_4C, call:bool(Tile::active, call:Tile[exp:valuetype Terraria.Tile&](Framing::GetTileSafely, ldc.i4:int32(-2147483648), ldloc:int64[exp:int32](var_9_39))))
	stloc:Vector2(var_24_60, callgetter:Vector2(Entity::get_Center, ldloc:Player[exp:Entity](this)))
	call:void(Player::LaunchMinecartHook, ldloc:Player(this), ldc.i4:int32(-2147483648), ldc.i4:int32(1073741824))
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

		// Token: 0x06002355 RID: 9045 RVA: 0x00118CE8 File Offset: 0x00116EE8
		public Item QuickMount_GetItemToUse()
		{
			/*
An exception occurred when decompiling this method (06002355)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Item Terraria.Player::QuickMount_GetItemToUse()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class Terraria.Item[](var_1_1F, ldfld:class Terraria.Item[](Player::inventory, ldloc:Player(this)))
	stloc:class Terraria.Item[](var_3_29, ldfld:class Terraria.Item[](Player::inventory, ldloc:Player(this)))
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

		// Token: 0x06002356 RID: 9046 RVA: 0x00118D24 File Offset: 0x00116F24
		public void ClearGrapplingBlacklist()
		{
			HashSet<Point> blackListedTileCoordsForGrappling = this._blackListedTileCoordsForGrappling;
		}

		// Token: 0x06002357 RID: 9047 RVA: 0x00118D38 File Offset: 0x00116F38
		public bool IsBlacklistedForGrappling(Point p)
		{
			/*
An exception occurred when decompiling this method (06002357)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::IsBlacklistedForGrappling(Microsoft.Xna.Framework.Point)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [System.Core]System.Collections.Generic.HashSet`1<valuetype Microsoft.Xna.Framework.Point>(var_0_06, ldfld:class [System.Core]System.Collections.Generic.HashSet`1<valuetype Microsoft.Xna.Framework.Point>(Player::_blackListedTileCoordsForGrappling, ldloc:Player(this)))
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

		// Token: 0x06002358 RID: 9048 RVA: 0x00118D4C File Offset: 0x00116F4C
		public void UpdateBlacklistedTilesForGrappling()
		{
			int num = 1;
			this.ClearGrapplingBlacklist();
			if (num == 0)
			{
			}
			int whoAmI = this.whoAmI;
			long num2 = 0L;
			long num3 = 0L;
			bool flag = WorldGen.SolidTile(0, (int)num2, num3 != 0L);
			HashSet<Point> blackListedTileCoordsForGrappling = this._blackListedTileCoordsForGrappling;
		}

		// Token: 0x06002359 RID: 9049 RVA: 0x00118D8C File Offset: 0x00116F8C
		private void FireGrapple(Item grappleItem)
		{
			if (grappleItem.shoot == 0)
			{
			}
			int myPlayer = Main.myPlayer;
		}

		// Token: 0x0600235A RID: 9050 RVA: 0x00118FC8 File Offset: 0x001171C8
		public void QuickGrapple()
		{
			while (!this.frozen && !this.tongued && !this.webbed && !this.stoned)
			{
				bool flag = this.dead;
				if (flag)
				{
					break;
				}
				if (!flag)
				{
				}
				if (flag)
				{
					if (!flag)
					{
					}
					bool hoveringOverAnNPC = Main.HoveringOverAnNPC;
					if (!flag)
					{
					}
					bool smartInteractShowingGenuine = Main.SmartInteractShowingGenuine;
					if (!flag)
					{
					}
					bool smartInteractShowingFake = Main.SmartInteractShowingFake;
					if (this._quickGrappleCooldown == 0)
					{
					}
					bool mapFullscreen = Main.mapFullscreen;
					bool drawToolModeUI = WiresUI.Settings.DrawToolModeUI;
					bool drawRubbleModeUI = GUIRubbleMaker.DrawRubbleModeUI;
					bool flag2 = this.controlUseTile;
					bool flag3 = this.releaseUseTile;
					while (!flag2)
					{
					}
					int tileTargetX = Player.tileTargetX;
					int tileTargetY = Player.tileTargetY;
					bool flag4 = Framing.GetTileSafely(tileTargetX, tileTargetY).active();
					if (this.inventory.position == null)
					{
					}
					bool usingGamepad = PlayerInput.UsingGamepad;
				}
				if (!this.noItems)
				{
					Mount mount = this.mount;
					if (mount._active)
					{
						mount.Dismount(this);
					}
					Item item = this.QuickGrapple_GetItemToUse();
					while (item == null)
					{
					}
					bool flag5 = this.ItemCheck_CheckCanUse(item);
					this.FireGrapple(item);
					return;
				}
			}
		}

		// Token: 0x0600235B RID: 9051 RVA: 0x001190E0 File Offset: 0x001172E0
		public Item QuickGrapple_GetItemToUse()
		{
			/*
An exception occurred when decompiling this method (0600235B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Item Terraria.Player::QuickGrapple_GetItemToUse()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0018:
	stloc:class Terraria.Item[](var_2_1E, ldfld:class Terraria.Item[](Player::inventory, ldloc:Player(this)))
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

		// Token: 0x0600235C RID: 9052 RVA: 0x00119110 File Offset: 0x00117310
		public void StatusToNPC(int type, int i)
		{
			byte b = this.meleeEnchant;
			if (b != 0)
			{
				if (b == 0)
				{
				}
				if (this.meleeEnchant == 0)
				{
				}
				if (this.meleeEnchant == 0)
				{
				}
				if (this.meleeEnchant == 0)
				{
				}
				if (this.meleeEnchant == 0)
				{
				}
				if (this.meleeEnchant == 0)
				{
				}
				if (this.meleeEnchant == 0)
				{
				}
			}
			bool flag = this.frostBurn;
			if (flag)
			{
				if (!flag)
				{
				}
			}
			bool flag2 = this.magmaStone;
			if (flag2)
			{
				if (!flag2)
				{
				}
				int num;
				if (num == 0)
				{
					return;
				}
				int num2;
				if (num2 != 0)
				{
					return;
				}
			}
			if (5382 == 0)
			{
			}
		}

		// Token: 0x0600235D RID: 9053 RVA: 0x00119290 File Offset: 0x00117490
		public void StatusToPlayerPvP(int type, int i)
		{
			byte b = this.meleeEnchant;
			if (b != 0)
			{
				if (b == 0)
				{
				}
				if (this.meleeEnchant == 0)
				{
				}
				if (this.meleeEnchant == 0)
				{
				}
				if (this.meleeEnchant == 0)
				{
				}
				if (this.meleeEnchant == 0)
				{
				}
				if (this.meleeEnchant == 0)
				{
				}
			}
			bool flag = this.frostBurn;
			if (flag)
			{
				if (!flag)
				{
				}
			}
			bool flag2 = this.magmaStone;
			if (flag2)
			{
				if (!flag2)
				{
				}
				int num;
				if (num == 0)
				{
					return;
				}
				int num2;
				if (num2 != 0)
				{
					return;
				}
			}
		}

		// Token: 0x0600235E RID: 9054 RVA: 0x0011940C File Offset: 0x0011760C
		public void Ghost()
		{
			Player.eToHellAndBackStatus toHellAndBackStatus = this.ToHellAndBackStatus;
			if (toHellAndBackStatus == Player.eToHellAndBackStatus.NotStarted)
			{
			}
			if (toHellAndBackStatus != Player.eToHellAndBackStatus.NotStarted)
			{
				int whoAmI = this.whoAmI;
				if (toHellAndBackStatus == Player.eToHellAndBackStatus.NotStarted)
				{
				}
				int myPlayer = Main.myPlayer;
				if (toHellAndBackStatus == Player.eToHellAndBackStatus.NotStarted)
				{
				}
				if (toHellAndBackStatus == Player.eToHellAndBackStatus.NotStarted)
				{
					if (toHellAndBackStatus == Player.eToHellAndBackStatus.NotStarted)
					{
					}
					bool editSign = Main.editSign;
					if (toHellAndBackStatus == Player.eToHellAndBackStatus.NotStarted)
					{
					}
					bool editChest = Main.editChest;
					if (toHellAndBackStatus == Player.eToHellAndBackStatus.NotStarted)
					{
					}
					bool blockInput = Main.blockInput;
					PlayerInput.Triggers.Current.CopyInto(this);
					bool flag = this.controlJump;
					this.controlJump = flag;
					bool flag2 = this.controlLeft;
					this.controlLeft = flag;
					bool flag3 = this.controlRight;
					this.controlRight = flag;
					bool flag4 = this.controlUp;
					this.controlUp = flag;
					bool flag5 = this.controlDown;
					bool flag6 = this.controlUp;
					bool flag7 = this.controlDown;
					return;
				}
			}
			if (this.controlUp || this.controlJump)
			{
				float y = this.velocity.Y;
				this.velocity.Y = y;
				int num = 49376;
				this.velocity.Y = (float)num;
				bool flag8 = this.controlLeft;
				bool flag9 = this.controlRight;
				if (!flag8)
				{
					float x = this.velocity.X;
					while (!flag9)
					{
					}
					while (flag8)
					{
					}
					return;
				}
				float x2 = this.velocity.X;
				if (flag9)
				{
					return;
				}
				int num2 = 49376;
				float x3 = this.position.X;
				float y2 = this.position.Y;
				if (num2 == 0)
				{
				}
				int num3 = this.ghostFrameCounter;
				float x4 = this.velocity.X;
				this.ghostFrameCounter = num3;
				return;
			}
			else
			{
				bool flag10 = this.controlDown;
				float y3 = this.velocity.Y;
				if (flag10)
				{
					this.velocity.Y = y3;
					float num4;
					this.velocity.Y = num4;
					return;
				}
				return;
			}
		}

		// Token: 0x0600235F RID: 9055 RVA: 0x0011974C File Offset: 0x0011794C
		private void TrySyncingInput()
		{
			if (!true)
			{
			}
			bool netClient = Main.NetClient;
			if (!true)
			{
			}
			bool flag = this.controlUp;
			bool flag2 = this.controlDown;
			bool flag3 = this.controlLeft;
			bool flag4 = this.controlRight;
			bool flag5 = this.controlJump;
			bool flag6 = this.controlUseItem;
			int num = this.selectedItem;
			bool flag7 = this.autoReuseAllWeapons;
			bool flag8 = this.controlDownHold;
			bool flag9 = this.isOperatingAnotherEntity;
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
			if (!flag9)
			{
			}
		}

		// Token: 0x06002360 RID: 9056 RVA: 0x001197C8 File Offset: 0x001179C8
		public void OnHit(float x, float y, Entity victim)
		{
			int num = 1;
			if (num == 0)
			{
			}
			LocalUser localUser = this.LocalUser;
			if (localUser != null)
			{
				localUser.LoadState();
			}
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			int whoAmI = this.whoAmI;
			if (victim != null)
			{
			}
			int num2 = this.titaniumStormCooldown;
		}

		// Token: 0x06002361 RID: 9057 RVA: 0x00119A78 File Offset: 0x00117C78
		public void OpenPresent(int itemType)
		{
			IEntitySource itemSource_OpenItem = this.GetItemSource_OpenItem(itemType);
			int num;
			if (num == 0)
			{
				int num2;
				if (num2 == 0)
				{
				}
				while (num2 == 0)
				{
				}
				return;
			}
			int num3;
			if (num3 == 0)
			{
				return;
			}
			int num4;
			if (num4 == 0)
			{
				return;
			}
			int num5;
			if (num5 == 0)
			{
				int num6 = 32640;
				if (num6 == 0)
				{
				}
				bool netClientOnly = Main.NetClientOnly;
				if (num6 == 0)
				{
				}
				return;
			}
			int num7;
			if (num7 == 0)
			{
				return;
			}
			int num8;
			if (num8 == 0)
			{
				return;
			}
			int num9;
			if (num9 == 0)
			{
				return;
			}
			int num10;
			if (num10 == 0)
			{
				return;
			}
			int num11;
			if (num11 == 0)
			{
				return;
			}
			int num12;
			if (num12 == 0)
			{
				return;
			}
			int num13;
			if (num13 == 0)
			{
				return;
			}
			int num14;
			if (num14 == 0)
			{
				if (32640 == 0)
				{
				}
				bool netClientOnly2 = Main.NetClientOnly;
				return;
			}
			int num15;
			if (num15 == 0)
			{
				return;
			}
			int num16;
			int num17;
			if (num16 == 0)
			{
				if (1911 == 0)
				{
				}
				num17 = 32640;
				return;
			}
			int num18;
			int num20;
			if (num18 == 0)
			{
				int num19;
				if (num19 == 0)
				{
				}
				if (num17 == 0)
				{
				}
				num20 = 32640;
				return;
			}
			int num21;
			if (num21 == 0)
			{
				if (num20 == 0)
				{
				}
				return;
			}
			int num22;
			if (num22 == 0)
			{
				float x = this.position.X;
				float y = this.position.Y;
				int width = this.width;
				bool wet = this.wet;
				int num2 = 32640;
				return;
			}
			int num23;
			if (num23 == 0)
			{
			}
		}

		// Token: 0x06002362 RID: 9058 RVA: 0x00119CCC File Offset: 0x00117ECC
		public void OpenLegacyPresent(int itemType)
		{
			IEntitySource itemSource_OpenItem = this.GetItemSource_OpenItem(itemType);
			int num;
			if (num != 0)
			{
				float x = this.position.X;
				float y = this.position.Y;
				int width = this.width;
				bool wet = this.wet;
				return;
			}
			if (32640 == 0)
			{
			}
			while (32640 == 0)
			{
			}
			if (32640 == 0)
			{
			}
		}

		// Token: 0x06002363 RID: 9059 RVA: 0x00119D24 File Offset: 0x00117F24
		public void QuickSpawnItem(IEntitySource source, int item, int stack = 1)
		{
			float x = this.position.X;
			float y = this.position.Y;
			int width = this.width;
			bool wet = this.wet;
			if (!true)
			{
			}
			if (32640 == 0)
			{
			}
			bool netClientOnly = Main.NetClientOnly;
		}

		// Token: 0x06002364 RID: 9060 RVA: 0x00119D6C File Offset: 0x00117F6C
		public void OpenBossBag(int type)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			CreativePowers.DifficultySliderPower power = CreativePowerManager.Instance.GetPower<CreativePowers.DifficultySliderPower>();
			if (power != null)
			{
				float <StrengthMultiplierToGiveNPCs>k__BackingField = power.<StrengthMultiplierToGiveNPCs>k__BackingField;
			}
		}

		// Token: 0x06002365 RID: 9061 RVA: 0x0011AB50 File Offset: 0x00118D50
		private void TryGettingDevArmor(IEntitySource source)
		{
			if (!true)
			{
			}
			int num = 16;
			int num2;
			if (num2 != 0)
			{
				return;
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06002366 RID: 9062 RVA: 0x0011B058 File Offset: 0x00119258
		public void OpenFishingCrate(int crateItemID)
		{
			int num;
			do
			{
				IEntitySource itemSource_OpenItem = this.GetItemSource_OpenItem(crateItemID);
			}
			while (num != 0);
			int num2;
			if (num2 != 0)
			{
				return;
			}
		}

		// Token: 0x06002367 RID: 9063 RVA: 0x0011BBF4 File Offset: 0x00119DF4
		public int CountItem(int type, int stopCountingAt = 0)
		{
			/*
An exception occurred when decompiling this method (06002367)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.Player::CountItem(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class Terraria.Item[](var_0_06, ldfld:class Terraria.Item[](Player::inventory, ldloc:Player(this)))
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

		// Token: 0x06002368 RID: 9064 RVA: 0x0011BC0C File Offset: 0x00119E0C
		public bool ConsumeItem(int type, bool reverseOrder = false, bool includeVoidBag = false)
		{
			/*
An exception occurred when decompiling this method (06002368)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::ConsumeItem(System.Int32,System.Boolean,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class Terraria.Item[](var_0_06, ldfld:class Terraria.Item[](Player::inventory, ldloc:Player(this)))
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

		// Token: 0x06002369 RID: 9065 RVA: 0x0011BC3C File Offset: 0x00119E3C
		public void OpenShadowLockbox(int boxType)
		{
			IEntitySource itemSource_OpenItem = this.GetItemSource_OpenItem(boxType);
			float x = this.position.X;
			float y = this.position.Y;
			int width = this.width;
			bool wet = this.wet;
			if (32640 == 0)
			{
			}
			if (32640 == 0)
			{
			}
			int num;
			if (num == 0)
			{
				float x2 = this.position.X;
				float y2 = this.position.Y;
				int width2 = this.width;
				bool wet2 = this.wet;
				if (32640 == 0)
				{
				}
				bool netClientOnly = Main.NetClientOnly;
			}
		}

		// Token: 0x0600236A RID: 9066 RVA: 0x0011BCC8 File Offset: 0x00119EC8
		public void OpenLockBox(int lockboxItemType)
		{
			IEntitySource itemSource_OpenItem = this.GetItemSource_OpenItem(lockboxItemType);
		}

		// Token: 0x0600236B RID: 9067 RVA: 0x0011BD74 File Offset: 0x00119F74
		public void OpenHerbBag(int bagType)
		{
			IEntitySource itemSource_OpenItem = this.GetItemSource_OpenItem(bagType);
			int num = 310;
			if (num == 0)
			{
			}
			int num2;
			if (num2 == 0)
			{
			}
			float x = this.position.X;
			float y = this.position.Y;
			int width = this.width;
			bool wet = this.wet;
			if (num == 0)
			{
			}
			bool netClientOnly = Main.NetClientOnly;
		}

		// Token: 0x0600236C RID: 9068 RVA: 0x0011BDF0 File Offset: 0x00119FF0
		public void OpenCanofWorms(int sourceItemType)
		{
			IEntitySource itemSource_OpenItem = this.GetItemSource_OpenItem(sourceItemType);
			int num;
			this.QuickSpawnItem(itemSource_OpenItem, 2002, num);
			int num2;
			this.QuickSpawnItem(itemSource_OpenItem, 3191, num2);
			int num3;
			if (num3 != 0)
			{
				return;
			}
			this.QuickSpawnItem(itemSource_OpenItem, 2895, 1);
		}

		// Token: 0x0600236D RID: 9069 RVA: 0x0011BE34 File Offset: 0x0011A034
		public void OpenOyster(int sourceItemType)
		{
			IEntitySource itemSource_OpenItem = this.GetItemSource_OpenItem(sourceItemType);
			int num;
			if (num == 0)
			{
				int num2;
				if (num2 != 0)
				{
					return;
				}
				this.QuickSpawnItem(itemSource_OpenItem, 4414, 1);
			}
			this.QuickSpawnItem(itemSource_OpenItem, 4411, 1);
		}

		// Token: 0x0600236E RID: 9070 RVA: 0x0011BE6C File Offset: 0x0011A06C
		public void OpenGoodieBag(int itemType)
		{
			IEntitySource itemSource_OpenItem = this.GetItemSource_OpenItem(itemType);
			int num;
			if (num != 0)
			{
				int num2;
				if (num2 != 0)
				{
					int num3;
					int num5;
					if (num3 == 0)
					{
						int num4;
						if (num4 == 0)
						{
						}
						num5 = 32640;
						return;
					}
					int num6;
					if (num6 != 0)
					{
						return;
					}
					if (num5 == 0)
					{
					}
				}
				else
				{
					int num4 = 32640;
					if (num4 == 0)
					{
						return;
					}
				}
				bool netClientOnly = Main.NetClientOnly;
				return;
			}
		}

		// Token: 0x0600236F RID: 9071 RVA: 0x0011C200 File Offset: 0x0011A400
		public void UpdateDyes()
		{
			Item[] array = this.dye;
			long num = 0L;
			this.cTail = (int)num;
			Microsoft.Xna.Framework.Vector2 position = array.position;
			bool flag = this.wearsRobe;
			Item[] array2 = this.miscDyes;
			long num2 = 0L;
			this.cHead = position;
			Microsoft.Xna.Framework.Vector2 velocity = array.velocity;
			this.cBody = velocity;
			Microsoft.Xna.Framework.Vector2 oldPosition = array.oldPosition;
			this.cLegs = oldPosition;
			Microsoft.Xna.Framework.Vector2 position2 = array2.position;
			this.cPet = position2;
			Microsoft.Xna.Framework.Vector2 velocity2 = array2.velocity;
			this.cLight = velocity2;
			Microsoft.Xna.Framework.Vector2 oldPosition2 = array2.oldPosition;
			this.cMinecart = oldPosition2;
			Microsoft.Xna.Framework.Vector2 oldVelocity = array2.oldVelocity;
			this.cMount = oldVelocity;
			int oldDirection = array2.oldDirection;
			this.cGrapple = oldDirection;
			bool flag2 = this.IsItemSlotUnlockedAndUsable((int)num2);
			bool[] array3 = this.hideVisibleAccessory;
			Item[] array4 = this.armor;
			Item[] array5 = this.dye;
			int num3 = this.cPet;
			this.cYorai = num3;
		}

		// Token: 0x06002370 RID: 9072 RVA: 0x0011C2E4 File Offset: 0x0011A4E4
		private void UpdateItemDye(bool isNotInVanitySlot, bool isSetToHidden, Item armorItem, Item dyeItem)
		{
			int num = 1;
			bool isAir = armorItem.IsAir;
			int num2 = 1;
			if (num == 0)
			{
			}
			int num3 = this.cShieldFallback;
			byte b = dyeItem.dye;
			this.cShieldFallback = (int)b;
			if (num2 == 0)
			{
				return;
			}
			if (b == 0)
			{
			}
			byte b2 = dyeItem.dye;
			this.cHandOn = (int)b2;
			if (b2 == 0)
			{
			}
			byte b3 = dyeItem.dye;
			this.cHandOff = (int)b3;
			if (b3 == 0)
			{
			}
			byte b4 = dyeItem.dye;
			this.cBackpack = (int)b4;
		}

		// Token: 0x06002371 RID: 9073 RVA: 0x0011C56C File Offset: 0x0011A76C
		public int ArmorSetDye()
		{
			if (!true)
			{
			}
			int num;
			if (num == 0)
			{
				return num;
			}
			return num;
		}

		// Token: 0x06002372 RID: 9074 RVA: 0x0011C584 File Offset: 0x0011A784
		public IEntitySource GetProjectileSource_Buff(int buffIndex)
		{
			/*
An exception occurred when decompiling this method (06002372)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.DataStructures.IEntitySource Terraria.Player::GetProjectileSource_Buff(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32[](var_0_06, ldfld:int32[](Player::buffType, ldloc:Player(this)))
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

		// Token: 0x06002373 RID: 9075 RVA: 0x000021DB File Offset: 0x000003DB
		public IEntitySource GetProjectileSource_Item(Item item)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002374 RID: 9076 RVA: 0x000021DB File Offset: 0x000003DB
		public IEntitySource GetItemSource_OpenItem(int itemType)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002375 RID: 9077 RVA: 0x000021DB File Offset: 0x000003DB
		public IEntitySource GetItemSource_Death()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002376 RID: 9078 RVA: 0x000021DB File Offset: 0x000003DB
		public IEntitySource GetItemSource_Misc(int itemSourceId)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002377 RID: 9079 RVA: 0x000021DB File Offset: 0x000003DB
		public IEntitySource GetProjectileSource_Item_WithPotentialAmmo(Item item, int ammoItemId)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002378 RID: 9080 RVA: 0x000021DB File Offset: 0x000003DB
		public IEntitySource GetProjectileSource_SetBonus(int projectileSourceId)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002379 RID: 9081 RVA: 0x000021DB File Offset: 0x000003DB
		public IEntitySource GetProjectileSource_OnHit(Entity victim, int projectileSourceId)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600237A RID: 9082 RVA: 0x000021DB File Offset: 0x000003DB
		public IEntitySource GetProjectileSource_OnHurt(Entity attacker, int projectileSourceId)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600237B RID: 9083 RVA: 0x000021DB File Offset: 0x000003DB
		public IEntitySource GetProjectileSource_Accessory(Item item)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600237C RID: 9084 RVA: 0x000021DB File Offset: 0x000003DB
		public IEntitySource GetProjectileSource_Misc(int projectileSourceId)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600237D RID: 9085 RVA: 0x000021DB File Offset: 0x000003DB
		public IEntitySource GetProjectileSource_TileInteraction(int tileCoordsX, int tileCoordsY)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600237E RID: 9086 RVA: 0x000021DB File Offset: 0x000003DB
		public IEntitySource GetItemSource_TileInteraction(int tileCoordsX, int tileCoordsY)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600237F RID: 9087 RVA: 0x000021DB File Offset: 0x000003DB
		public IEntitySource GetNPCSource_TileInteraction(int tileCoordsX, int tileCoordsY)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002380 RID: 9088 RVA: 0x000021DB File Offset: 0x000003DB
		public IEntitySource GetItemSource_OnHit(Entity victim, int itemSourceId)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002381 RID: 9089 RVA: 0x0011C598 File Offset: 0x0011A798
		public void UpdateBuffs(int i)
		{
			int num = this.soulDrain;
			int whoAmI = this.whoAmI;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			int num2 = 151;
			int num3 = 2;
			int num4 = 1;
			long num5 = 0L;
			this.AddBuff(num2, num3, num4 != 0, num5 != 0L);
			if (num == 0)
			{
			}
			if (num != 0)
			{
				int num6 = 1;
				this.UpdateStarvingState(num6 != 0);
			}
			int num7 = 1;
			int[] array = this.buffType;
			if (array == null)
			{
			}
			int myPlayer2 = Main.myPlayer;
			if (array == null)
			{
			}
			int[] array2 = this.buffType;
			if (this.buffType == null)
			{
			}
			int[] array3 = this.buffType;
			bool[] array4 = this.buffImmune;
			this.lavaImmune = num7 != 0;
			this.fireWalk = num7 != 0;
		}

		// Token: 0x06002382 RID: 9090 RVA: 0x0011EF08 File Offset: 0x0011D108
		public void TryToResetHungerToNeutral()
		{
			if (!true)
			{
			}
			int[] array = this.buffType;
			int[] array2 = this.buffTime;
		}

		// Token: 0x06002383 RID: 9091 RVA: 0x0011EF30 File Offset: 0x0011D130
		public void UpdateHungerBuffs()
		{
			if (!true)
			{
			}
			int[] array = this.buffType;
			int[] array2 = this.buffTime;
			int whoAmI = this.whoAmI;
			if (array == null)
			{
			}
			int myPlayer = Main.myPlayer;
			if (array == null)
			{
			}
			if (array2 != null)
			{
				if (array2 == null)
				{
				}
				return;
			}
			int num = 18000;
			int num2 = 333;
			int num3 = 1;
			long num4 = 0L;
			this.AddBuff(num2, num, num3 != 0, num4 != 0L);
			EmoteBubble.MakeLocalPlayerEmote(147);
			int[] array3 = this.buffTime;
		}

		// Token: 0x06002384 RID: 9092 RVA: 0x0011EFD4 File Offset: 0x0011D1D4
		public void UpdateStarvingState(bool withEmote)
		{
			int num = 1;
			int whoAmI = this.whoAmI;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			if (num == 0)
			{
			}
			int[] array = this.buffTime;
			if (array == null)
			{
			}
			int[] array2 = this.buffType;
			if (array == null)
			{
				return;
			}
		}

		// Token: 0x06002385 RID: 9093 RVA: 0x0011F04C File Offset: 0x0011D24C
		private void UpdateProjectileCaches(int i)
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
				int[] array = this.ownedProjectileCounts;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				int num2 = this.highestStormTigerGemOriginalDamage;
				this.highestStormTigerGemOriginalDamage = num;
				return;
			}
		}

		// Token: 0x06002386 RID: 9094 RVA: 0x0011F094 File Offset: 0x0011D294
		private void ResetProjectileCaches()
		{
			int[] array = this.ownedProjectileCounts;
		}

		// Token: 0x06002387 RID: 9095 RVA: 0x0011F0AC File Offset: 0x0011D2AC
		public void BuffHandle_SpawnPetIfNeededAndSetTime(int buffIndex, bool petBool, int petProjID, int buffTimeToGive = 18000)
		{
			int[] array = this.buffTime;
			this.BuffHandle_SpawnPetIfNeeded(petBool, petProjID, buffIndex);
		}

		// Token: 0x06002388 RID: 9096 RVA: 0x0011F0CC File Offset: 0x0011D2CC
		public void BuffHandle_SpawnPetIfNeeded(bool petBool, int petProjID, int buffIndex)
		{
			int num = 1;
			petBool.m_value = num != 0;
			int[] array = this.ownedProjectileCounts;
			Microsoft.Xna.Framework.Vector2 center = base.Center;
			int[] array2 = this.buffType;
			if (this.direction == 0)
			{
			}
		}

		// Token: 0x06002389 RID: 9097 RVA: 0x0011F134 File Offset: 0x0011D334
		private void UpdateAbigailStatus()
		{
			int[] array = this.ownedProjectileCounts;
			Microsoft.Xna.Framework.Vector2 center = base.Center;
			if (array == null)
			{
			}
			int num = 1;
			if (num == 0)
			{
			}
			int whoAmI = this.whoAmI;
			int value = num.m_value;
			if (num == 0)
			{
			}
		}

		// Token: 0x0600238A RID: 9098 RVA: 0x0011F180 File Offset: 0x0011D380
		private void UpdateStormTigerStatus()
		{
			int[] array = this.ownedProjectileCounts;
			if (array == null)
			{
			}
			if (array == null)
			{
			}
			int[] array2 = this.ownedProjectileCounts;
		}

		// Token: 0x0600238B RID: 9099 RVA: 0x0011F1F0 File Offset: 0x0011D3F0
		private int GetDesiredStormTigerMinionRank()
		{
			/*
An exception occurred when decompiling this method (0600238B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.Player::GetDesiredStormTigerMinionRank()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32[](var_0_06, ldfld:int32[](Player::ownedProjectileCounts, ldloc:Player(this)))
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

		// Token: 0x0600238C RID: 9100 RVA: 0x0011F204 File Offset: 0x0011D404
		public void Counterweight(Microsoft.Xna.Framework.Vector2 hitPos, int dmg, float kb)
		{
			int num;
			if (!this.yoyoGlove)
			{
				num = this.counterWeight;
			}
			if (num == 0)
			{
			}
			int whoAmI;
			if (num != 0)
			{
				if (num == 0)
				{
				}
				whoAmI = this.whoAmI;
				if (num == 0)
				{
				}
				if (num != 0)
				{
					return;
				}
				if (num == 0)
				{
				}
			}
			bool flag = this.yoyoGlove;
			if (flag)
			{
				Microsoft.Xna.Framework.Vector2 center = base.Center;
				if (!flag)
				{
				}
				Microsoft.Xna.Framework.Vector2 vector;
				vector.Normalize();
				if (!flag)
				{
				}
				if (whoAmI == 0)
				{
				}
				Microsoft.Xna.Framework.Vector2 center2 = base.Center;
				Microsoft.Xna.Framework.Vector2 center3 = base.Center;
				int whoAmI2 = this.whoAmI;
				return;
			}
			Microsoft.Xna.Framework.Vector2 center4 = base.Center;
			Microsoft.Xna.Framework.Vector2 vector2;
			vector2.Normalize();
			if (whoAmI == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 center5 = base.Center;
			Microsoft.Xna.Framework.Vector2 center6 = base.Center;
			int num2 = this.counterWeight;
			int whoAmI3 = this.whoAmI;
		}

		// Token: 0x0600238D RID: 9101 RVA: 0x0011F2C4 File Offset: 0x0011D4C4
		public int beeType()
		{
			bool flag = this.strongBees;
			if (flag)
			{
				if (!flag)
				{
				}
				int num;
				if (num == 0)
				{
					this.makeStrongBee = true;
					return 566;
				}
			}
			return 181;
		}

		// Token: 0x0600238E RID: 9102 RVA: 0x0011F2F4 File Offset: 0x0011D4F4
		public int beeDamage(int dmg)
		{
			int num = 1;
			bool flag = this.makeStrongBee;
			if (num == 0)
			{
			}
			if (flag)
			{
				int num2;
				return num2;
			}
			int num3;
			return num3;
		}

		// Token: 0x0600238F RID: 9103 RVA: 0x0011F31C File Offset: 0x0011D51C
		public float beeKB(float KB)
		{
			/*
An exception occurred when decompiling this method (0600238F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Player::beeKB(System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_06, ldfld:bool(Player::makeStrongBee, ldloc:Player(this)))
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

		// Token: 0x06002390 RID: 9104 RVA: 0x0011F330 File Offset: 0x0011D530
		public void Yoraiz0rEye()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int direction = this.direction;
			float num2 = this.gravDir;
			int width = this.width;
			bool wet = this.wet;
			Microsoft.Xna.Framework.Vector2 mountedCenter = this.MountedCenter;
			Microsoft.Xna.Framework.Vector2 center = base.Center;
			sbyte b = this.face;
			float num3 = this.gravDir;
			int num4 = this.head;
			int direction2 = this.direction;
			Mount mount = this.mount;
			if (mount._active)
			{
				int type = mount._type;
				int direction3 = this.direction;
				float num5 = this.gravDir;
			}
			int direction4 = this.direction;
			float num6 = this.gravDir;
			if (direction4 == 0)
			{
			}
			if (!true)
			{
			}
			float num7 = this.gfxOffY;
			int[] array = this.shadowDirection;
			int direction5 = this.direction;
			if (array == null)
			{
			}
			if (!true)
			{
			}
			Mount mount2 = this.mount;
			bool active = mount2._active;
			int value = direction5.m_value;
			if (active)
			{
				bool cart = mount2.Cart;
				float x = this.velocity.X;
				if (mount2 == null)
				{
				}
				int num8;
				if (num8 == 0)
				{
					int direction6 = this.direction;
				}
				float num9 = this.fullRotation;
				float num10 = this.fullRotation;
				float num11 = this.fullRotation;
				float num12 = this.fullRotation;
				float num14;
				int num13 = Math.Sign(num14);
				float num15 = this.fullRotation;
			}
			float num16 = this.fullRotation;
		}

		// Token: 0x06002391 RID: 9105 RVA: 0x0011F600 File Offset: 0x0011D800
		public bool IsItemSlotUnlockedAndUsable(int slot)
		{
			if (!true)
			{
			}
			bool masterMode = Main.masterMode;
			if (!true)
			{
			}
			bool gameMenu = Main.gameMenu;
			return true;
		}

		// Token: 0x06002392 RID: 9106 RVA: 0x0011F648 File Offset: 0x0011D848
		public void RefreshInfoAccs()
		{
			int type = this.inventory.type;
			this.RefreshInfoAccsFromItemType(type);
			int num = 32;
			int type2 = this.armor.type;
			this.RefreshInfoAccsFromItemType(type2);
			Item[] item = this.bank4.item;
			if (item == null)
			{
			}
			if (item.oldDirection != 0)
			{
				this.RefreshInfoAccsFromItemType(num);
			}
			this.RefreshInfoAccsFromTeamPlayers();
		}

		// Token: 0x06002393 RID: 9107 RVA: 0x0011F6BC File Offset: 0x0011D8BC
		public void RefreshInfoAccsFromTeamPlayers()
		{
			int num = 1;
			if (num == 0)
			{
			}
			int whoAmI = this.whoAmI;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			int num2 = 1;
			if (this.whoAmI == 0)
			{
			}
			if (this.team == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 center = base.Center;
			Microsoft.Xna.Framework.Vector2 vector;
			float num3 = vector.Length();
			if (this.accWatch == 0)
			{
			}
			if (this.accCompass == 0)
			{
			}
			int num4 = this.accDepthMeter;
			if (num4 == 0)
			{
			}
			if (num4 != 0)
			{
				this.accFishFinder = num2 != 0;
			}
			if (num4 == 0)
			{
			}
			if (num4 != 0)
			{
				this.accWeatherRadio = num2 != 0;
			}
			if (num4 == 0)
			{
			}
			if (num4 != 0)
			{
				this.accThirdEye = num2 != 0;
			}
			if (num4 == 0)
			{
			}
			if (num4 != 0)
			{
				this.accJarOfSouls = num2 != 0;
			}
			if (num4 == 0)
			{
			}
			if (num4 != 0)
			{
				this.accCalendar = num2 != 0;
			}
			if (num4 == 0)
			{
			}
			if (num4 != 0)
			{
				this.accStopwatch = num2 != 0;
			}
			if (num4 == 0)
			{
			}
			if (num4 != 0)
			{
				this.accOreFinder = num2 != 0;
			}
			if (num4 == 0)
			{
			}
			if (num4 != 0)
			{
				this.accCritterGuide = num2 != 0;
			}
			if (num4 == 0)
			{
			}
			if (num4 != 0)
			{
				this.accDreamCatcher = num2 != 0;
			}
			if (num4 == 0)
			{
			}
			if (num4 != 0)
			{
				this.hasLuck_LuckyHorseshoe = num2 != 0;
			}
			if (num4 == 0)
			{
			}
			this.hasLuck_LuckyCoin = num2 != 0;
		}

		// Token: 0x06002394 RID: 9108 RVA: 0x0011F7D0 File Offset: 0x0011D9D0
		public void RefreshInfoAccsFromItemType(int accType)
		{
		}

		// Token: 0x06002395 RID: 9109 RVA: 0x0011F908 File Offset: 0x0011DB08
		public void RefreshMechanicalAccsFromItemType(int accType)
		{
		}

		// Token: 0x06002396 RID: 9110 RVA: 0x0011F968 File Offset: 0x0011DB68
		public void UpdatePermanentBoosters()
		{
			if (this.usedAegisFruit)
			{
				int num = this.statDefense;
				this.statDefense = num;
			}
			if (this.usedGummyWorm)
			{
				int num2 = this.fishingSkill;
				this.fishingSkill = num2;
			}
			if (this.usedAmbrosia)
			{
				float num3 = this.tileSpeed;
				this.tileSpeed = num3;
			}
		}

		// Token: 0x06002397 RID: 9111 RVA: 0x0011F9B8 File Offset: 0x0011DBB8
		private bool UpdateEquips_CanItemGrantBenefits(int itemSlot, Item item)
		{
			/*
An exception occurred when decompiling this method (06002397)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::UpdateEquips_CanItemGrantBenefits(System.Int32,Terraria.Item)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_06, ldfld:bool(Item::accessory, ldloc:Item(item)))
	stloc:int32(var_1_0D, ldfld:int32(Item::headSlot, ldloc:Item(item)))
	stloc:int32(var_2_14, ldfld:int32(Item::bodySlot, ldloc:Item(item)))
	stloc:int32(var_3_1B, ldfld:int32(Item::legSlot, ldloc:Item(item)))
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

		// Token: 0x06002398 RID: 9112 RVA: 0x0011F9E4 File Offset: 0x0011DBE4
		public void UpdateEquips(int i)
		{
			Microsoft.Xna.Framework.Vector2 position = this.inventory.position;
			Mount mount = this.mount;
			if (mount._active)
			{
				bool cart = mount.Cart;
			}
			int num = 1;
			this.trident = num != 0;
			Item[] array = this.inventory;
			int num2 = 1;
			int type = array.type;
			this.RefreshInfoAccsFromItemType(type);
			this.RefreshMechanicalAccsFromItemType(type);
			this.hasFootball = num2 != 0;
		}

		// Token: 0x06002399 RID: 9113 RVA: 0x0011FE64 File Offset: 0x0011E064
		private void GrantArmorBenefits(Item armorPiece)
		{
			int type = armorPiece.type;
			this.RefreshInfoAccsFromItemType(type);
			this.RefreshMechanicalAccsFromItemType(type);
			int type2 = armorPiece.type;
			int num = 1;
			this.flowerBoots = num != 0;
			int whoAmI = this.whoAmI;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			int type3 = armorPiece.type;
			float num2 = this.moveSpeed;
			int num3 = 1;
			this.moonLordLegs = num3 != 0;
			this.moveSpeed = num2;
			int num4 = this.statDefense;
			int defense = armorPiece.defense;
			this.statDefense = num4;
			int num5 = this.lifeRegen;
			int num6 = armorPiece.lifeRegen;
			this.lifeRegen = num5;
			int num7 = 1;
			this.hasRaisableShield = num7 != 0;
		}

		// Token: 0x0600239A RID: 9114 RVA: 0x001211D8 File Offset: 0x0011F3D8
		private void GrantPrefixBenefits(Item item)
		{
			byte prefix = item.prefix;
		}

		// Token: 0x0600239B RID: 9115 RVA: 0x001212F4 File Offset: 0x0011F4F4
		private void SpawnHallucination(Item item)
		{
			int num = 1;
			int whoAmI = this.whoAmI;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			int num2 = this.insanityShadowCooldown;
			int num3;
			this.insanityShadowCooldown = num3;
			float x = this.position.X;
			float y = this.position.Y;
			int width = this.width;
			bool wet = this.wet;
		}

		// Token: 0x0600239C RID: 9116 RVA: 0x00121368 File Offset: 0x0011F568
		public void DoBootsEffect(Utils.TileActionAttempt theEffectMethod)
		{
			int num = this.miscCounter;
			float y = this.velocity.Y;
			int[] array = this.grappling;
		}

		// Token: 0x0600239D RID: 9117 RVA: 0x001213D4 File Offset: 0x0011F5D4
		public bool DoBootsEffect_PlaceFlamesOnTile(int X, int Y)
		{
			if (!true)
			{
			}
			Tile tile;
			bool isLoaded = tile.IsLoaded;
			bool flag = WorldGen.SolidTileAllowBottomSlope(X, int.MinValue);
			int num = 8;
			int whoAmI = this.whoAmI;
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x0600239E RID: 9118 RVA: 0x0012140C File Offset: 0x0011F60C
		public bool DoBootsEffect_PlaceFlowersOnTile(int X, int Y)
		{
			/*
An exception occurred when decompiling this method (0600239E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::DoBootsEffect_PlaceFlowersOnTile(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00B0:
	stloc:int16(var_47_C1, callgetter:int16(Tile::get_frameX, ldloc:Tile[exp:valuetype Terraria.Tile&](var_46)))
	stloc:uint16(var_52_D0, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_51)))
	stloc:uint16(var_59_E8, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_58)))
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

		// Token: 0x0600239F RID: 9119 RVA: 0x00121514 File Offset: 0x0011F714
		private void ApplyEquipVanity(int itemSlot, Item currentItem)
		{
			int num = 1;
			int type = currentItem.type;
			this.wings = num;
			int num2 = 1;
			this.forceWerewolf = num2 != 0;
		}

		// Token: 0x060023A0 RID: 9120 RVA: 0x0012166C File Offset: 0x0011F86C
		private void DoEyebrellaRainEffect()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				if (num == 0)
				{
				}
				int num2;
				if (num2 == 0)
				{
					Microsoft.Xna.Framework.Vector2 mountedCenter = this.MountedCenter;
					int height = this.height;
					if (num == 0)
					{
					}
					if (num == 0)
					{
					}
					int width = this.width;
					int num3 = 15744;
					int num4 = 32768;
					if (num3 == 0)
					{
					}
					if (num3 == 0)
					{
					}
					if (num4 == 0)
					{
					}
				}
			}
		}

		// Token: 0x060023A1 RID: 9121 RVA: 0x001216CC File Offset: 0x0011F8CC
		public WingStats GetWingStats(int wingID)
		{
			/*
An exception occurred when decompiling this method (060023A1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.DataStructures.WingStats Terraria.Player::GetWingStats(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stfld:float32(WingStats::DownHoverSpeedOverride, ldloc:WingStats[exp:valuetype Terraria.DataStructures.WingStats&](var_0), ldc.i4:int32[exp:float32](24))
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

		// Token: 0x060023A2 RID: 9122 RVA: 0x001216E0 File Offset: 0x0011F8E0
		private void ApplyEquipFunctional(int itemSlot, Item currentItem)
		{
			bool expertOnly = currentItem.expertOnly;
			if (expertOnly)
			{
				if (!expertOnly)
				{
				}
				bool expertMode = Main.expertMode;
			}
			int type = currentItem.type;
			int num = 1;
			this.dd2Accessory = num != 0;
			if (this.hideVisibleAccessory == null)
			{
				this.UpdateBootVisualEffects(currentItem);
				this.UpdateFishingBobber(currentItem);
				int type2 = currentItem.type;
			}
		}

		// Token: 0x060023A3 RID: 9123 RVA: 0x00122E5C File Offset: 0x0012105C
		private void ApplyWilsonBeard(Item currentItem)
		{
			int num = this.beardGrowthTimer;
			int num2 = 43200;
			this.beardGrowthTimer = num;
			if (num == 0)
			{
			}
			int num3;
			if (num3 != 0)
			{
				return;
			}
			int type = currentItem.type;
			if (num2 == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 center = base.Center;
			currentItem.SetDefaults(int.MinValue);
		}

		// Token: 0x060023A4 RID: 9124 RVA: 0x00122EB0 File Offset: 0x001210B0
		private void ApplyMusicBox(Item currentItem)
		{
			int num = 1;
			int type = currentItem.type;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				return;
			}
		}

		// Token: 0x060023A5 RID: 9125 RVA: 0x001230E0 File Offset: 0x001212E0
		private string GetArmourSetId(string id, [Optional] string formatId)
		{
			/*
An exception occurred when decompiling this method (060023A5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Terraria.Player::GetArmourSetId(System.String,System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000C:
	stloc:int32(var_3_13, callgetter:int32(Main::get_myPlayer))
	stloc:GameCulture(var_5_1C, callgetter:GameCulture(Language::get_ActiveCulture))
	stloc:GameCulture(var_9_26, callgetter:GameCulture(Language::get_ActiveCulture))
	stloc:bool(var_10_2E, call:bool(string::IsNullOrEmpty, ldloc:string(formatId)))
	stloc:string(var_12_3D, call:string(Language::GetTextValue, call:string(Language::GetTextValue, ldloc:string(id)), ldloc:string[exp:object](var_11)))
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

		// Token: 0x060023A6 RID: 9126 RVA: 0x0012312C File Offset: 0x0012132C
		public void UpdateArmorSets(int i)
		{
			int num = this.body;
			int num2 = this.legs;
			int num3 = this.head;
			int num4 = 1;
			string text;
			this.setBonus = text;
			this.shroomiteStealth = num4 != 0;
			int num5 = this.head;
		}

		// Token: 0x060023A7 RID: 9127 RVA: 0x00124300 File Offset: 0x00122500
		public void UpdateSocialShadow()
		{
			int[] array = this.shadowDirection;
			int direction = this.direction;
			int num = this.shadowCount;
			this.shadowCount = array;
			if (num == 0)
			{
				Microsoft.Xna.Framework.Vector2[] array2 = this.shadowPos;
				float[] array3 = this.shadowRotation;
				Microsoft.Xna.Framework.Vector2[] array4 = this.shadowOrigin;
				return;
			}
			Microsoft.Xna.Framework.Vector2[] array5 = this.shadowPos;
			Microsoft.Xna.Framework.Vector2 position = this.position;
			Microsoft.Xna.Framework.Vector2[] array6 = this.shadowPos;
			float num2 = this.gfxOffY;
			float[] array7 = this.shadowRotation;
			float num3 = this.fullRotation;
			Microsoft.Xna.Framework.Vector2[] array8 = this.shadowOrigin;
			Microsoft.Xna.Framework.Vector2 vector = this.fullRotationOrigin;
			float y = this.fullRotationOrigin.Y;
			array8.X = y;
		}

		// Token: 0x060023A8 RID: 9128 RVA: 0x001243B4 File Offset: 0x001225B4
		public void UpdateTeleportVisuals()
		{
			float num = this.teleportTime;
			int num2 = this.teleportStyle;
		}

		// Token: 0x060023A9 RID: 9129 RVA: 0x0012451C File Offset: 0x0012271C
		private void UpdateGraveyard(bool now = false)
		{
			if (!true)
			{
			}
			int <GraveyardTileCount>k__BackingField = Main.SceneMetrics.<GraveyardTileCount>k__BackingField;
			int num = 30;
			this.graveImmediateTime = num;
		}

		// Token: 0x060023AA RID: 9130 RVA: 0x001245B8 File Offset: 0x001227B8
		public void ForceUpdateBiomes()
		{
			int num = 1;
			int whoAmI = this.whoAmI;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			if (num == 0)
			{
			}
			SceneMetrics sceneMetrics = Main.SceneMetrics;
			Microsoft.Xna.Framework.Vector2 center = base.Center;
			bool flag = this.accOreFinder;
			this.UpdateBiomes();
		}

		// Token: 0x060023AB RID: 9131 RVA: 0x00124604 File Offset: 0x00122804
		public bool CanSeeShimmerEffects()
		{
			/*
An exception occurred when decompiling this method (060023AB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::CanSeeShimmerEffects()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_004B:
	stloc:Vector2(var_12_53, callgetter:Vector2(Main::get_screenPosition))
	stloc:bool(var_13_5B, ldfld:bool(Player::shimmering, ldloc:Player(this)))
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

		// Token: 0x060023AC RID: 9132 RVA: 0x00124670 File Offset: 0x00122870
		public void UpdateBiomes()
		{
			Microsoft.Xna.Framework.Vector2 center = base.Center;
			int <DungeonTileCount>k__BackingField = Main.SceneMetrics.<DungeonTileCount>k__BackingField;
			Microsoft.Xna.Framework.Vector2 center2 = base.Center;
			if (<DungeonTileCount>k__BackingField == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 center3 = base.Center;
			Microsoft.Xna.Framework.Vector2 center4 = base.Center;
			Tile tile;
			ushort wall = tile.wall;
			Microsoft.Xna.Framework.Vector2 center5 = base.Center;
			int num = 32640;
			Microsoft.Xna.Framework.Vector2 center6 = base.Center;
			Tile tile2;
			ushort wall2 = tile2.wall;
			Microsoft.Xna.Framework.Vector2 center7 = base.Center;
			Tile tile3;
			ushort wall3 = tile3.wall;
			this.behindBackWall = num != 0;
			Microsoft.Xna.Framework.Vector2 center8 = base.Center;
		}

		// Token: 0x060023AD RID: 9133 RVA: 0x00124F74 File Offset: 0x00123174
		private void TrySpawningFaelings()
		{
			bool wasInShimmerZone = this._wasInShimmerZone;
			if (!wasInShimmerZone)
			{
				if (!wasInShimmerZone)
				{
				}
				NPC.SpawnFaelings(this.whoAmI);
			}
		}

		// Token: 0x060023AE RID: 9134 RVA: 0x00124FA0 File Offset: 0x001231A0
		public void ManageSpecialBiomeVisuals(string biomeName, bool inZone, [Optional] Microsoft.Xna.Framework.Vector2 activationSource)
		{
			if (!true)
			{
			}
			!0 !;
			if (! != null)
			{
				if (!true)
				{
				}
				return;
			}
		}

		// Token: 0x060023AF RID: 9135 RVA: 0x00124FC0 File Offset: 0x001231C0
		public void GetHairSettings([Out] bool fullHair, [Out] bool hatHair, [Out] bool hideHair, [Out] bool backHairDraw, [Out] bool drawsBackHairWithoutHeadgear)
		{
			int num = this.head;
		}

		// Token: 0x060023B0 RID: 9136 RVA: 0x00125054 File Offset: 0x00123254
		public void UpdateDead()
		{
			Player.eToHellAndBackStatus toHellAndBackStatus = this.ToHellAndBackStatus;
			BitsByte bitsByte = 0;
			this.ownedLargeGems = bitsByte;
			this.face = (sbyte)toHellAndBackStatus;
			this.handon = (sbyte)toHellAndBackStatus;
			int num = 16256;
			this.gravDir = (float)num;
			if (toHellAndBackStatus == Player.eToHellAndBackStatus.NotStarted)
			{
			}
			int[] array = this.buffType;
			int[] array2 = this.buffType;
			int[] array3 = this.buffTime;
		}

		// Token: 0x060023B1 RID: 9137 RVA: 0x00125344 File Offset: 0x00123544
		private void TryOpeningInGameOptionsBasedOnInput()
		{
			if (this.controlInv)
			{
				if (this.releaseInventory)
				{
					return;
				}
			}
			else
			{
				this.releaseInventory = true;
			}
		}

		// Token: 0x060023B2 RID: 9138 RVA: 0x0012536C File Offset: 0x0012356C
		public void UpdatePet(int i)
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
			if (this.miscEquips.position == null)
			{
			}
			Microsoft.Xna.Framework.Vector2 position = this.miscEquips.position;
			if (position == null)
			{
			}
			if (position != null)
			{
				int num = this.FindBuffIndex(i);
			}
		}

		// Token: 0x060023B3 RID: 9139 RVA: 0x00125400 File Offset: 0x00123600
		public void CheckForPetAchievement(int buffID)
		{
			int num = 1;
			int whoAmI = this.whoAmI;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			IntHashSet petBuffsSpawned = this.LocalUser.PersistentUserData.PetBuffsSpawned;
			petBuffsSpawned.Add(buffID);
			int count = petBuffsSpawned.Count;
		}

		// Token: 0x060023B4 RID: 9140 RVA: 0x00125448 File Offset: 0x00123648
		public void UpdatePetLight(int i)
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
			if (this.miscEquips.velocity == null)
			{
			}
			Microsoft.Xna.Framework.Vector2 velocity = this.miscEquips.velocity;
			if (velocity == null)
			{
			}
			if (velocity != null)
			{
				int num = this.FindBuffIndex(i);
				int num2 = 102;
				int num3 = this.FindBuffIndex(num2);
				int num4 = 101;
				int num5 = this.FindBuffIndex(num4);
			}
		}

		// Token: 0x060023B5 RID: 9141 RVA: 0x00125500 File Offset: 0x00123700
		public void TogglePet()
		{
			long num = 0L;
			Microsoft.Xna.Framework.Vector2 position = this.miscEquips.position;
			this.ClearBuff((int)num);
		}

		// Token: 0x060023B6 RID: 9142 RVA: 0x0012552C File Offset: 0x0012372C
		public void ToggleLight()
		{
			int num = 1;
			Microsoft.Xna.Framework.Vector2 velocity = this.miscEquips.velocity;
			this.ClearBuff(num);
			Microsoft.Xna.Framework.Vector2 velocity2 = this.miscEquips.velocity;
			int num2 = 102;
			this.ClearBuff(num2);
			int num3 = 101;
			this.ClearBuff(num3);
		}

		// Token: 0x060023B7 RID: 9143 RVA: 0x00125580 File Offset: 0x00123780
		public bool IsWithinSnappngRangeToTile(int x, int y, int distanceInPixels)
		{
			/*
An exception occurred when decompiling this method (060023B7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::IsWithinSnappngRangeToTile(System.Int32,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0011:
	stloc:float32(var_4_19, call:float32(Vector2::Length, ldloc:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](var_3)))
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

		// Token: 0x060023B8 RID: 9144 RVA: 0x001255A8 File Offset: 0x001237A8
		public void SmartInteractLookup()
		{
			if (!true)
			{
			}
			Main.ClearSmartInteract();
			if (!true)
			{
			}
			bool usingGamepad = PlayerInput.UsingGamepad;
			if (!true)
			{
			}
			bool hoveringOverAnNPC = Main.HoveringOverAnNPC;
			if (!true)
			{
			}
			Dictionary<int, bool> smartInteractTileCoordsSelected = Main.SmartInteractTileCoordsSelected;
			if (!true)
			{
			}
			bool usingGamepad2 = PlayerInput.UsingGamepad;
			if (!true)
			{
			}
			bool smartCursorIsUsed = Main.SmartCursorIsUsed;
			if (!true)
			{
			}
			bool flag = this.IsRightClickItemActive();
			bool drawToolModeUI = WiresUI.Settings.DrawToolModeUI;
			bool drawRubbleModeUI = GUIRubbleMaker.DrawRubbleModeUI;
			bool smartCursorIsUsed2 = Main.SmartCursorIsUsed;
		}

		// Token: 0x060023B9 RID: 9145 RVA: 0x0012563C File Offset: 0x0012383C
		private void SmartInteractLookup_PrepareCommonlyUsedInfo([Out] Microsoft.Xna.Framework.Vector2 mousevec, [Out] int LX, [Out] int HX, [Out] int LY, [Out] int HY)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 mouseScreen = Main.MouseScreen;
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			if (num == 0)
			{
			}
			float x = this.position.X;
			if (num == 0)
			{
			}
			int tileRangeX = Player.tileRangeX;
			int num2 = 15744;
			int num3 = 32640;
			LX.m_value = num2;
			float x2 = this.position.X;
			int width = this.width;
			int tileRangeX2 = Player.tileRangeX;
			HX.m_value = num2;
			float y = this.position.Y;
			int tileRangeY = Player.tileRangeY;
			LY.m_value = num2;
			float y2 = this.position.Y;
			int height = this.height;
			int tileRangeY2 = Player.tileRangeY;
			HY.m_value = num2;
			if (num3 == 0)
			{
			}
		}

		// Token: 0x060023BA RID: 9146 RVA: 0x00125700 File Offset: 0x00123900
		public Item SmartItem()
		{
			/*
An exception occurred when decompiling this method (060023BA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Item Terraria.Player::SmartItem()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0128:
	stloc:Vector2(var_35_133, ldfld:Vector2(Entity::position, ldfld:class Terraria.Item[][exp:Entity](Player::inventory, ldloc:Player(this))))
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

		// Token: 0x060023BB RID: 9147 RVA: 0x00125844 File Offset: 0x00123A44
		public void SmartSelectLookup()
		{
			int num;
			while (!this.mouseInterface)
			{
				if (this.controlTorch)
				{
					if (this.itemAnimation != 0)
					{
						return;
					}
					if (num == 0)
					{
					}
					bool usingGamepad = PlayerInput.UsingGamepad;
					int lastSmartCursorToolStrategy = this._lastSmartCursorToolStrategy;
					return;
				}
			}
			if (this.itemAnimation == 0)
			{
				int num2 = this.DpadRadial.SelectedItem;
				Player.SelectionRadial dpadRadial = this.DpadRadial;
				Item[] array = this.inventory;
				int num3 = dpadRadial.SelectedItem;
				int num4 = this.nonTorch;
				int num5 = this.selectedItem;
				this.nonTorch = num5;
				int num6 = this.DpadRadial.SelectedItem;
				this.selectedItem = num6;
				return;
			}
			num = this.nonTorch;
			this.selectedItem = num;
			this.nonTorch = num;
			this._lastSmartCursorToolStrategy = num;
		}

		// Token: 0x060023BC RID: 9148 RVA: 0x001259A0 File Offset: 0x00123BA0
		private void SmartSelectLookup_GetTargetTile([Out] int tX, [Out] int tY)
		{
			if (!true)
			{
			}
			int mouseX = Main.mouseX;
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			tX.m_value = 15744;
			int mouseY = Main.mouseY;
			Microsoft.Xna.Framework.Vector2 screenPosition2 = Main.screenPosition;
			tY.m_value = 15744;
			float num = this.gravDir;
			if (15744 == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 screenPosition3 = Main.screenPosition;
			int screenHeight = Main.screenHeight;
			int mouseY2 = Main.mouseY;
			tY.m_value = 15744;
		}

		// Token: 0x060023BD RID: 9149 RVA: 0x00125A24 File Offset: 0x00123C24
		private void SmartSelect_PickToolForStrategy(int tX, int tY, int toolStrategy, bool wetTile)
		{
			Microsoft.Xna.Framework.Vector2 position = this.inventory.position;
		}

		// Token: 0x060023BE RID: 9150 RVA: 0x00125B38 File Offset: 0x00123D38
		private void SmartSelect_SelectItem(int t)
		{
			int num = this.nonTorch;
			int num2 = this.selectedItem;
			this.nonTorch = num2;
			this.selectedItem = t;
		}

		// Token: 0x060023BF RID: 9151 RVA: 0x00125B64 File Offset: 0x00123D64
		private void SmartSelect_GetToolStrategy(int tX, int tY, [Out] int toolStrategy, [Out] bool wetTile)
		{
			float x = this.position.X;
			int width = this.width;
			float y = this.position.Y;
		}

		// Token: 0x060023C0 RID: 9152 RVA: 0x00125CA8 File Offset: 0x00123EA8
		private void SmartSelect_GetAvailableToolRanges([Out] int pickRange, [Out] int axeRange, [Out] int hammerRange, [Out] int cannonRange, [Out] int extractItemRange, [Out] int paintScraperRange)
		{
			int num = 1;
			pickRange.m_value = num;
			axeRange.m_value = num;
			hammerRange.m_value = num;
			cannonRange.m_value = num;
			extractItemRange.m_value = num;
			paintScraperRange.m_value = num;
			Item[] array = this.inventory;
			Item[] array2 = this.inventory;
			Item[] array3 = this.inventory;
		}

		// Token: 0x060023C1 RID: 9153 RVA: 0x00125D00 File Offset: 0x00123F00
		private void EndOngoingTorchGodEvent()
		{
			bool flag = this.happyFunTorchTime;
			if (flag)
			{
				this.RelightTorches();
				if (!flag)
				{
				}
				int whoAmI = this.whoAmI;
			}
		}

		// Token: 0x060023C2 RID: 9154 RVA: 0x00125D28 File Offset: 0x00123F28
		private void TryRecalculatingTorchLuck()
		{
			if (this.happyFunTorchTime)
			{
				this.TorchAttack();
				return;
			}
			int num = this.torchGodCooldown;
			this.torchGodCooldown = num;
			float x = this._nextTorchLuckCheckCenter.X;
			float y = this._nextTorchLuckCheckCenter.Y;
			if (num == 0)
			{
			}
			bool flag = this.dead;
			if (flag)
			{
				this.UpdateTorchLuck_ConsumeCountersAndCalculate();
				return;
			}
			if (this.name == null)
			{
			}
			if (!flag)
			{
			}
			int num2 = this.luckyTorchCounter;
			if (num2 == 0)
			{
			}
			int num3 = 1;
			if (num2 == 0)
			{
			}
			Tile tile;
			bool isLoaded = tile.IsLoaded;
			int num4 = this.nearbyTorches;
			this.nearbyTorches = num4;
			if (!flag)
			{
			}
			bool[] array = this.nearbyTorch;
			this.dryCoralTorch = num3 != 0;
		}

		// Token: 0x060023C3 RID: 9155 RVA: 0x00125DDC File Offset: 0x00123FDC
		private void RelightTorches()
		{
			int num = this.numberOfTorchAttacksMade;
			int num2 = 3600;
			this.torchGodCooldown = num2;
			int[] array = this.unlitTorchX;
			int[] array2 = this.unlitTorchY;
			if (array == null)
			{
			}
			Tile tile;
			ushort type = tile.type;
			if (array == null)
			{
			}
		}

		// Token: 0x060023C4 RID: 9156 RVA: 0x00125E20 File Offset: 0x00124020
		private void TorchAttack()
		{
			int num = 1;
			int whoAmI = this.whoAmI;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			float y = this.position.Y;
			if (num == 0)
			{
			}
			this.EndOngoingTorchGodEvent();
		}

		// Token: 0x060023C5 RID: 9157 RVA: 0x00125FB0 File Offset: 0x001241B0
		private void UpdateTorchLuck_ConsumeCountersAndCalculate()
		{
			bool[] array3;
			bool[] array4;
			int num2;
			for (;;)
			{
				Microsoft.Xna.Framework.Vector2 center = base.Center;
				Microsoft.Xna.Framework.Vector2 position = this.inventory.position;
				Microsoft.Xna.Framework.Vector2 position2 = this.inventory.position;
				bool[] array = this.nearbyTorch;
				int num = 1;
				bool[] array2 = this.nearbyTorch;
				if (num != 0)
				{
					break;
				}
				if (array3 != null)
				{
					return;
				}
				array4 = this.nearbyTorch;
				if (array4 != null)
				{
					goto Block_2;
				}
				if (this.nearbyTorch != null)
				{
					return;
				}
				if (this.nearbyTorch != null)
				{
					return;
				}
				if (this.nearbyTorch != null)
				{
					return;
				}
				bool[] array5 = this.nearbyTorch;
				if (num2 != 0)
				{
					if (this.nearbyTorch != null)
					{
						return;
					}
					bool[] array6 = this.nearbyTorch;
					if (num2 != 0)
					{
						goto Block_8;
					}
				}
			}
			array3 = this.nearbyTorch;
			return;
			Block_2:
			Microsoft.Xna.Framework.Vector2 center2 = base.Center;
			long num3 = 0L;
			Microsoft.Xna.Framework.Vector2 center3 = base.Center;
			if (array4 == null)
			{
			}
			num2 = 32640;
			bool flag = WorldGen.oceanDepths(0, (int)num3);
			return;
			Block_8:
			if (this.nearbyTorch != null)
			{
				return;
			}
			if (this.nearbyTorch != null)
			{
			}
			bool[] array7 = this.nearbyTorch;
			if (array7 != null)
			{
				return;
			}
			float num4 = this.torchLuck;
			this.torchLuck = num4;
			float num5 = this.torchLuck;
		}

		// Token: 0x060023C6 RID: 9158 RVA: 0x00126180 File Offset: 0x00124380
		public void AddCoinLuck(Microsoft.Xna.Framework.Vector2 coinPosition, int coinAmount)
		{
			bool flag = this.dead;
			if (!flag)
			{
				Microsoft.Xna.Framework.Vector2 center = base.Center;
				if (!flag)
				{
				}
				float num = this.coinLuck;
				this.coinLuck = num;
				this.luckNeedsSync = true;
			}
		}

		// Token: 0x060023C7 RID: 9159 RVA: 0x001261BC File Offset: 0x001243BC
		private void UpdateCoinLuck()
		{
			float num = this.coinLuck;
			this.coinLuck = num;
		}

		// Token: 0x060023C8 RID: 9160 RVA: 0x001261D8 File Offset: 0x001243D8
		private float CalculateCoinLuck()
		{
			/*
An exception occurred when decompiling this method (060023C8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Player::CalculateCoinLuck()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(Player::coinLuck, ldloc:Player(this)))
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

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x060023C9 RID: 9161 RVA: 0x001261EC File Offset: 0x001243EC
		public float NormalizedLuck
		{
			get
			{
				/*
An exception occurred when decompiling this method (060023C9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Player::get_NormalizedLuck()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(Player::luck, ldloc:Player(this)))
	stloc:float32(var_1_0D, ldfld:float32(Player::luckMaximumCap, ldloc:Player(this)))
	stloc:float32(var_2_14, ldfld:float32(Player::luckMinimumCap, ldloc:Player(this)))
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

		// Token: 0x060023CA RID: 9162 RVA: 0x00126210 File Offset: 0x00124410
		private float GetLadyBugLuck()
		{
			/*
An exception occurred when decompiling this method (060023CA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Player::GetLadyBugLuck()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	brtrue(IL_0000, ldc.i4:bool(1))
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

		// Token: 0x060023CB RID: 9163 RVA: 0x0012622C File Offset: 0x0012442C
		public static float GetClosestPlayersLuck(Point Position)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x060023CC RID: 9164 RVA: 0x00126244 File Offset: 0x00124444
		public static float GetClosestPlayersLuck(Microsoft.Xna.Framework.Vector2 Position)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x060023CD RID: 9165 RVA: 0x00126258 File Offset: 0x00124458
		public int RollLuck(int range)
		{
			float num = this.luck;
			if (!true)
			{
			}
			float num2 = this.luck;
			int num3;
			return num3;
		}

		// Token: 0x060023CE RID: 9166 RVA: 0x00126278 File Offset: 0x00124478
		public static float GetClosestRollLuck(Microsoft.Xna.Framework.Vector2 position, int range)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x060023CF RID: 9167 RVA: 0x0012628C File Offset: 0x0012448C
		public static float GetClosestRollLuck(int x, int y, int range)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x060023D0 RID: 9168 RVA: 0x001262A4 File Offset: 0x001244A4
		public void ResetEffects()
		{
			bool flag = this.CanDemonHeartAccessoryBeShown();
			bool flag2 = this.CanMasterModeAccessoryBeShown();
			int num = 1;
			int num2 = 8;
			this.extraAccessorySlots = num;
			bool flag3 = this.IsItemSlotUnlockedAndUsable(num2);
			int num3 = this.extraAccessorySlotsUse;
			this.extraAccessorySlotsUse = num3;
			int num4 = 9;
			bool flag4 = this.IsItemSlotUnlockedAndUsable(num4);
			int num5 = this.extraAccessorySlotsUse;
			this.extraAccessorySlotsUse = num5;
			bool flag5 = this.shimmering;
			float num6 = this.shimmerTransparency;
			if (flag5)
			{
				this.shimmerTransparency = num6;
				int num7 = 52429;
				this.shimmerTransparency = (float)num7;
				return;
			}
			float x = this.position.X;
			float y = this.position.Y;
			float num8 = this.shimmerTransparency;
			this.shimmerTransparency = num8;
			int num9 = 16256;
			int num10 = 4;
			this.manaCost = (float)num9;
			this.meleeSpeed = (float)num9;
			this.meleeDamage = (float)num9;
			this.rangedMultDamage = (float)num9;
			this.rangedCrit = num10;
			int num11 = this.forcedGravity;
			this.forcedGravity = num11;
			int num12 = this.statLifeMax;
			int num13 = this.statManaMax;
			this.statLifeMax2 = num12;
			this.statManaMax2 = num13;
			this.overrideFishingBobber = num12;
			int num14 = 1;
			this.maxMinions = num14;
			this.maxTurrets = num14;
			if (num14 == 0)
			{
			}
			long num15;
			if (num13 != 0)
			{
				if (num13 == 0)
				{
				}
				if (num14 != 0)
				{
					num15 = 0L;
					return;
				}
			}
			if (num15 == 0L)
			{
			}
			this.dontStarveShader = num15 != 0L;
			int num16 = 16256;
			int num17 = 256;
			this.pickSpeed = (float)num16;
			this.rulerGrid = num17 != 0;
			this.ResizeHitbox();
			int num18 = this.phantasmTime;
			this.phantasmTime = num18;
			int num19 = this.brainOfConfusionDodgeAnimationCounter;
			this.brainOfConfusionDodgeAnimationCounter = num19;
			int num20 = this.wireOperationsCooldown;
			this.wireOperationsCooldown = num20;
			if (this.releaseUseItem)
			{
			}
			bool[] array = this.npcTypeNoAggro;
			int[] array2 = this.ownedProjectileCounts;
			int whoAmI = this.whoAmI;
			if (array2 == null)
			{
			}
			int myPlayer = Main.myPlayer;
			bool flag6 = this.isDisplayDollOrInanimate;
			if (flag6)
			{
				this.mount.CheckMountBuff(this);
				return;
			}
			if (!flag6)
			{
			}
			Player.tileRangeX = 5;
			Player.tileRangeY = 4;
			if (!flag6)
			{
			}
			int num21 = 1;
			if (num21 == 0)
			{
			}
			while (num21 == 0)
			{
			}
			CreativePowers.FarPlacementRangePower power = CreativePowerManager.Instance.GetPower<CreativePowers.FarPlacementRangePower>();
			int whoAmI2 = this.whoAmI;
			bool flag7 = power.IsEnabledForPlayer(whoAmI2);
			Player.tileRangeX = Player.tileRangeX;
			Player.tileRangeY = Player.tileRangeY;
			Player.tileRangeX = Player.tileRangeX;
			Player.tileRangeY = Player.tileRangeY;
		}

		// Token: 0x060023D1 RID: 9169 RVA: 0x00126500 File Offset: 0x00124700
		private void UpdateLadyBugLuckTime()
		{
			int num = 1;
			int num2 = this.ladyBugLuckTimeLeft;
			if (num == 0)
			{
			}
		}

		// Token: 0x060023D2 RID: 9170 RVA: 0x00126528 File Offset: 0x00124728
		public void UpdateImmunity()
		{
			while (this.immune && !this.dead)
			{
				int num = this.immuneTime;
				this.immuneTime = num;
				if (!this.immuneNoBlink)
				{
					int num2 = this.immuneAlpha;
					int num3 = this.immuneAlphaDirection;
					this.immuneAlpha = num2;
					return;
				}
			}
			int[] array = this.hurtCooldowns;
		}

		// Token: 0x060023D3 RID: 9171 RVA: 0x00126588 File Offset: 0x00124788
		private void TryToPoop()
		{
			int num = 1;
			int whoAmI = this.whoAmI;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			bool flag = this.wellFed;
			if (flag)
			{
				if (!flag)
				{
				}
				int num2;
				if (num2 == 0)
				{
					int num3 = 207;
					int num4 = this.FindBuffIndex(num3);
					return;
				}
			}
		}

		// Token: 0x060023D4 RID: 9172 RVA: 0x00126644 File Offset: 0x00124844
		public void UpdateLifeRegen()
		{
			if (this.shinyStone)
			{
				bool isStandingStillForSpecialEffects = this.IsStandingStillForSpecialEffects;
				int num = this.itemAnimation;
				return;
			}
			long num2 = 0L;
			if (this.poisoned)
			{
				int num3 = this.lifeRegen;
				long num4 = 0L;
				this.lifeRegen = (int)num4;
			}
			if (this.venom)
			{
				int num5 = this.lifeRegen;
				long num6 = 0L;
				this.lifeRegen = (int)num6;
			}
			if (this.onFire)
			{
				int num7 = this.lifeRegen;
				long num8 = 0L;
				this.lifeRegen = (int)num8;
			}
			if (this.onFire3)
			{
				int num9 = this.lifeRegen;
				long num10 = 0L;
				this.lifeRegen = (int)num10;
			}
			if (this.onFrostBurn)
			{
				int num11 = this.lifeRegen;
				long num12 = 0L;
				this.lifeRegen = (int)num12;
			}
			if (this.onFrostBurn2)
			{
				int num13 = this.lifeRegen;
				long num14 = 0L;
				this.lifeRegen = (int)num14;
			}
			if (this.onFire2)
			{
				int num15 = this.lifeRegen;
				long num16 = 0L;
				this.lifeRegen = (int)num16;
			}
			if (this.burned)
			{
				int num17 = this.lifeRegen;
				long num18 = 0L;
				float num19 = this.moveSpeed;
				this.lifeRegen = (int)num18;
				this.moveSpeed = num19;
			}
			if (this.suffocating)
			{
				int num20 = this.lifeRegen;
				long num21 = 0L;
				this.lifeRegen = (int)num21;
			}
			if (this.electrified)
			{
				int num22 = this.lifeRegen;
				long num23 = 0L;
				if (this.controlLeft || this.controlRight)
				{
					this.lifeRegen = (int)num23;
				}
			}
			bool flag = this.tongued;
			if (flag)
			{
				if (!flag)
				{
				}
				bool expertMode = Main.expertMode;
				int num24 = this.lifeRegen;
				long num25 = 0L;
				this.lifeRegen = (int)num25;
			}
			bool flag2 = this.honey;
			int num26 = this.lifeRegen;
			if (flag2)
			{
				return;
			}
			int num27 = this.nebulaLevelLife;
			long num28 = 0L;
			float num29 = this.lifeRegenTime;
			bool flag3 = this.usedAegisCrystal;
			this.lifeRegenTime = num29;
			if (flag3)
			{
				this.lifeRegenTime = num29;
			}
			if (this.crimsonRegen)
			{
				this.lifeRegenTime = num29;
			}
			int num30 = this.soulDrain;
			this.lifeRegenTime = num29;
			if (num2 != 0L)
			{
				int num31 = 17633;
				this.lifeRegenTime = (float)num31;
				this.lifeRegenTime = num29;
				this.lifeRegen = (int)num28;
			}
			if (flag2)
			{
				this.lifeRegenTime = num29;
				this.lifeRegen = (int)num28;
			}
			int num33;
			if (this.starving)
			{
				int num32 = this.lifeRegenCount;
				num33 = this.statLifeMax2;
				this.lifeRegen = num33;
			}
			this.lifeRegenTime = num29;
			this.lifeRegen = num33;
			if (this.heartyMeal)
			{
			}
			int whoAmI = this.whoAmI;
			if (num33 == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			if (num33 == 0)
			{
			}
			bool <HasCampfire>k__BackingField = Main.SceneMetrics.<HasCampfire>k__BackingField;
			if (<HasCampfire>k__BackingField)
			{
			}
			int whoAmI2 = this.whoAmI;
			if (!<HasCampfire>k__BackingField)
			{
			}
			int myPlayer2 = Main.myPlayer;
			if (!<HasCampfire>k__BackingField)
			{
			}
			if (Main.SceneMetrics.<HasHeartLantern>k__BackingField)
			{
			}
			if (this.bleed)
			{
				if (num2 == 0L)
				{
					return;
				}
			}
			else
			{
				float num34 = this.lifeRegenTime;
				if (num2 == 0L)
				{
					int num35 = 17761;
					this.lifeRegenTime = (float)num35;
					if (this.sitting != null)
					{
						ExtraSeatInfo details = this.sitting.details;
						this.lifeRegenTime = num34;
						if (details != null)
						{
							this.TryToPoop();
							return;
						}
					}
					else if (this.sleeping != null)
					{
						this.lifeRegenTime = num34;
					}
					float x = this.velocity.X;
					return;
				}
			}
		}

		// Token: 0x060023D5 RID: 9173 RVA: 0x00126DEC File Offset: 0x00124FEC
		public void UpdateManaRegen()
		{
			int num = this.nebulaLevelMana;
			int num2 = this.nebulaManaCounter;
			this.nebulaManaCounter = num2;
			int num3 = this.statMana;
			int num4 = this.statManaMax2;
			this.nebulaManaCounter = num;
			this.statMana = num;
		}

		// Token: 0x060023D6 RID: 9174 RVA: 0x00126FCC File Offset: 0x001251CC
		public void UpdateJumpHeight()
		{
			if (this.mount._active)
			{
				float x = this.velocity.X;
				int num;
				Player.jumpHeight = num;
				Mount mount = this.mount;
				float x2 = this.velocity.X;
				return;
			}
			bool flag = this.jumpBoost;
			if (flag)
			{
				if (!flag)
				{
				}
				Player.jumpHeight = 20;
				float num2;
				Player.jumpSpeed = num2;
			}
			if (this.empressBrooch)
			{
				float num3 = this.jumpSpeedBoost;
				this.jumpSpeedBoost = num3;
			}
			if (this.frogLegJumpBoost)
			{
				float num4 = this.jumpSpeedBoost;
				int num5 = this.extraFall;
				this.jumpSpeedBoost = num4;
			}
			if (this.moonLordLegs)
			{
				float num6 = this.jumpSpeedBoost;
				int num7 = this.extraFall;
				this.jumpSpeedBoost = num6;
				this.extraFall = num7;
				if (num7 == 0)
				{
				}
				Player.jumpHeight = Player.jumpHeight;
			}
			bool flag2 = this.wereWolf;
			if (flag2)
			{
				if (!flag2)
				{
				}
				Player.jumpHeight = Player.jumpHeight;
				Player.jumpSpeed = Player.jumpSpeed;
			}
			bool isInUse = this.portableStoolInfo.IsInUse;
			if (isInUse)
			{
				if (!isInUse)
				{
				}
				Player.jumpHeight = Player.jumpHeight;
			}
			if (!isInUse)
			{
			}
			float jumpSpeed = Player.jumpSpeed;
			float num8 = this.jumpSpeedBoost;
			Player.jumpSpeed = jumpSpeed;
			bool flag3 = this.sticky;
			if (flag3)
			{
				if (!flag3)
				{
				}
				Player.jumpHeight = Player.jumpHeight;
				Player.jumpSpeed = Player.jumpSpeed;
			}
			bool flag4 = this.dazed;
			if (flag4)
			{
				if (!flag4)
				{
				}
				Player.jumpHeight = Player.jumpHeight;
				Player.jumpSpeed = Player.jumpSpeed;
				return;
			}
		}

		// Token: 0x060023D7 RID: 9175 RVA: 0x00127140 File Offset: 0x00125340
		public void FindPulley()
		{
			if (!this.portableStoolInfo.IsInUse && (this.controlUp || this.controlDown))
			{
				int width = this.width;
				float x = this.position.X;
				float y = this.position.Y;
				int num = 32640;
				if (width == 0)
				{
				}
				float y2 = this.position.Y;
				Tile tile;
				bool flag = tile.active();
				Tile tile2;
				ushort type = tile2.type;
				Tile tile3;
				bool flag2 = tile3.active();
				Tile tile4;
				ushort type2 = tile4.type;
				int width2 = this.width;
				float x2 = this.position.X;
				if (num == 0)
				{
					float x3 = this.position.X;
				}
				if (width2 == 0)
				{
					float x4 = this.position.X;
				}
				return;
			}
		}

		// Token: 0x060023D8 RID: 9176 RVA: 0x0012739C File Offset: 0x0012559C
		public void HorizontalMovement()
		{
			if (this.chilled)
			{
				float num = this.maxRunSpeed;
				this.accRunSpeed = num;
			}
			if (this.itemAnimation == 0 || this.inventory.position != null)
			{
				bool allowDirectionChange = this.mount.AllowDirectionChange;
				return;
			}
			if (this.controlLeft)
			{
				return;
			}
			bool flag = this.controlRight;
			float num2 = this.accRunSpeed;
			float num3 = this.maxRunSpeed;
			if (flag)
			{
				Mount mount = this.mount;
				if (mount._active)
				{
					int type = mount._type;
					float y = this.velocity.Y;
					if (!this.controlJump)
					{
						bool flag2;
						if (!flag2)
						{
						}
						Microsoft.Xna.Framework.Vector2 center = base.Center;
						if (!flag2)
						{
						}
						float jumpSpeed = Player.jumpSpeed;
						float num4 = this.gravDir;
						float num5;
						this.velocity.Y = num5;
						int jumpHeight = Player.jumpHeight;
						this.jump = jumpHeight;
						return;
					}
				}
			}
			if (this.windPushed && this.sitting == null && this.sleeping == null && this.mount._active)
			{
				float y2 = this.velocity.Y;
			}
			float num6 = this.trackBoost;
			float x = this.velocity.X;
			float num7 = this.maxRunSpeed;
			this.velocity.X = num6;
		}

		// Token: 0x060023D9 RID: 9177 RVA: 0x00128020 File Offset: 0x00126220
		public void NoteRunning()
		{
			int totalRunTime = this.TotalRunTime;
			this.TotalRunTime = totalRunTime;
		}

		// Token: 0x060023DA RID: 9178 RVA: 0x0012803C File Offset: 0x0012623C
		private void TryUsingDiggerCart()
		{
			int num = 1;
			int whoAmI = this.whoAmI;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			Mount mount = this.mount;
			if (mount._active)
			{
				int type = mount._type;
				float y = this.velocity.Y;
				float num2 = this.gravDir;
				Microsoft.Xna.Framework.Vector2 center = base.Center;
				int direction = this.direction;
				float num3 = this.gravDir;
				if (direction == 0)
				{
				}
				Tile tile;
				bool flag = tile.active();
				Microsoft.Xna.Framework.Vector2 center2 = base.Center;
				int direction2 = this.direction;
				float num4 = this.gravDir;
				if (direction2 == 0)
				{
				}
				bool flag2 = this.controlDown;
				if (direction2 == 0)
				{
				}
				int num5 = true.ToInt();
				int num6 = this.controlUp.ToInt();
				int num7 = this.controlUp.ToInt();
				int num8 = this.controlDown.ToInt();
				int num9 = this.controlLeft.ToInt();
				bool flag3 = this.controlRight;
				int num10 = flag3.ToInt();
				if (!flag3)
				{
				}
				int direction3 = this.direction;
			}
		}

		// Token: 0x060023DB RID: 9179 RVA: 0x00128144 File Offset: 0x00126344
		private void SpawnFastRunParticles()
		{
			float num = this.gravDir;
			int height = this.height;
		}

		// Token: 0x060023DC RID: 9180 RVA: 0x00128538 File Offset: 0x00126738
		private void MowTheLawn()
		{
			int num = this.miscCounter;
			float y = this.velocity.Y;
			int[] array = this.grappling;
		}

		// Token: 0x060023DD RID: 9181 RVA: 0x00128728 File Offset: 0x00126928
		private void MowGrassTile(Microsoft.Xna.Framework.Vector2 thePos)
		{
			if (!true)
			{
			}
			Tile tile;
			bool isLoaded = tile.IsLoaded;
			if (477 == 0)
			{
			}
			if (477 == 0)
			{
			}
			if (477 == 0)
			{
			}
			bool netClientOnly = Main.NetClientOnly;
		}

		// Token: 0x060023DE RID: 9182 RVA: 0x00128760 File Offset: 0x00126960
		private int CollideWithNPCs(Rectangle myRect, float Damage, float Knockback, int NPCImmuneTime, int PlayerImmuneTime)
		{
			if (!true)
			{
			}
			Rectangle rectangle;
			bool flag = rectangle.Intersects(rectangle);
			float x = this.position.X;
			float y = this.position.Y;
			int width = this.width;
			bool wet = this.wet;
			float x2 = this.velocity.X;
			int direction = this.direction;
			int whoAmI = this.whoAmI;
			int myPlayer = Main.myPlayer;
			this.GiveImmuneTimeForCollisionAttack(43143168);
			return 1;
		}

		// Token: 0x060023DF RID: 9183 RVA: 0x001287D8 File Offset: 0x001269D8
		public void ApplyDamageToNPC(NPC npc, int damage, float knockback, int direction, bool crit)
		{
			int num = Item.NPCtoBanner(npc.BannerID());
			bool expertMode = Main.expertMode;
			int num2 = Item.BannerToItem(num);
		}

		// Token: 0x060023E0 RID: 9184 RVA: 0x00128898 File Offset: 0x00126A98
		public void OnKillNPC(NPCKillAttempt attempt, object externalKillingBlowSource)
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
			int whoAmI = this.whoAmI;
			if (externalKillingBlowSource != null)
			{
				int num = 336;
				int num2 = 420;
				long num3 = 0L;
				long num4 = 0L;
				this.AddBuff(num, num2, num3 != 0L, num4 != 0L);
				return;
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x060023E1 RID: 9185 RVA: 0x001288E4 File Offset: 0x00126AE4
		public bool SlimeDontHyperJump
		{
			get
			{
				Mount mount = this.mount;
				if (!mount._active)
				{
					return;
				}
				bool isConsideredASlimeMount = mount.IsConsideredASlimeMount;
				if (this.wetSlime != 0)
				{
					bool flag = this.controlJump;
					return isConsideredASlimeMount;
				}
			}
		}

		// Token: 0x060023E2 RID: 9186 RVA: 0x0012891C File Offset: 0x00126B1C
		public void GiveImmuneTimeForCollisionAttack(int time)
		{
			int timeSinceLastImmuneGet = this._timeSinceLastImmuneGet;
			int immuneStrikes = this._immuneStrikes;
			this._immuneStrikes = immuneStrikes;
		}

		// Token: 0x060023E3 RID: 9187 RVA: 0x00128964 File Offset: 0x00126B64
		public bool CanNPCBeHitByPlayerOrPlayerProjectile(NPC npc, [Optional] Projectile projectile)
		{
			/*
An exception occurred when decompiling this method (060023E3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::CanNPCBeHitByPlayerOrPlayerProjectile(Terraria.NPC,Terraria.Projectile)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_1:
	brtrue(IL_0000, ldloc:bool(var_0_06))
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

		// Token: 0x060023E4 RID: 9188 RVA: 0x00128988 File Offset: 0x00126B88
		public void IncreaseAirTime()
		{
			if (!true)
			{
			}
			LocalUser localUser = UserManagement.FindLocalUserByPlayer(this);
			if (localUser != null)
			{
				PersistentUserData persistentUserData = localUser.PersistentUserData;
				uint currentAirTime = persistentUserData.CurrentAirTime;
				uint totalAirTime = persistentUserData.TotalAirTime;
				if (currentAirTime != 0U)
				{
					return;
				}
			}
		}

		// Token: 0x060023E5 RID: 9189 RVA: 0x001289BC File Offset: 0x00126BBC
		public void ResetAirTime()
		{
			if (!true)
			{
			}
			LocalUser localUser = UserManagement.FindLocalUserByPlayer(this);
			if (localUser != null)
			{
				PersistentUserData persistentUserData = localUser.PersistentUserData;
			}
		}

		// Token: 0x060023E6 RID: 9190 RVA: 0x001289E0 File Offset: 0x00126BE0
		public void JumpMovement()
		{
			Mount mount = this.mount;
			long num4;
			if (mount._active)
			{
				bool isConsideredASlimeMount = mount.IsConsideredASlimeMount;
				if (this.wetSlime == 0)
				{
					float y = this.velocity.Y;
					Rectangle rect = this.getRect();
					int height = this.height;
					int num = 2;
					int num2 = 12;
					int num3 = 6;
					rect.Inflate(num2, num3);
					if (num == 0)
					{
					}
					num4 = 0L;
					Rectangle rectangle;
					bool flag = rectangle.Intersects(rectangle);
					float x = this.position.X;
					float y2 = this.position.Y;
					int width = this.width;
					bool wet = this.wet;
				}
			}
			Mount mount2 = this.mount;
			if (mount2._active)
			{
				int type = mount2._type;
				float y3 = this.velocity.Y;
				Rectangle rect2 = this.getRect();
				int height2 = this.height;
				long num5 = 0L;
				rect2.Offset((int)num5, (int)num4);
				int num6 = 2;
				int num7 = 12;
				int num8 = 6;
				rect2.Inflate(num7, num8);
				if (num6 == 0)
				{
				}
				Rectangle rectangle2;
				bool flag2 = rectangle2.Intersects(rectangle2);
				float x2 = this.position.X;
				float y4 = this.position.Y;
				int width2 = this.width;
				bool wet2 = this.wet;
			}
			if (this.jumping)
			{
				this.IncreaseAirTime();
				return;
			}
			this.ResetAirTime();
			if (!this.controlJump)
			{
				int num9 = 1;
				this.releaseJump = num9 != 0;
				this.rocketRelease = num9 != 0;
				return;
			}
			if (this.sliding)
			{
			}
			if (this.wet)
			{
				bool flag3 = this.accFlipper;
				return;
			}
			Mount mount3 = this.mount;
			if (mount3._active)
			{
				bool cart = mount3.Cart;
				Mount mount4 = this.mount;
				if (mount4._active)
				{
					bool isConsideredASlimeMount2 = mount4.IsConsideredASlimeMount;
					if (this.wetSlime != 0)
					{
						return;
					}
				}
				return;
			}
			Mount mount5 = this.mount;
			bool active = mount5._active;
			if (active)
			{
				int type2 = mount5._type;
				if (this.releaseJump)
				{
					float y5 = this.velocity.Y;
					int num10 = 1;
					this.isPerformingPogostickTricks = num10 != 0;
				}
			}
			int num11 = this.jump;
			float y6 = this.velocity.Y;
		}

		// Token: 0x060023E7 RID: 9191 RVA: 0x001299F8 File Offset: 0x00127BF8
		public void DashMovement()
		{
			if (this.dashDelay != 0)
			{
				int num = this.dash;
				return;
			}
			int num2 = this.dashType;
			this.dash = num2;
			if (num2 == 0)
			{
				return;
			}
			int whoAmI = this.whoAmI;
			int num3;
			if (num3 == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			float x = this.velocity.X;
			float y = this.velocity.Y;
			float x2 = this.position.X;
			float y2 = this.position.Y;
			int width = this.width;
			bool wet = this.wet;
			if (width == 0)
			{
			}
			if (width == 0 || width != 0 || width == 0)
			{
			}
		}

		// Token: 0x060023E8 RID: 9192 RVA: 0x0012A17C File Offset: 0x0012837C
		private void SolarDashStart(int dashDirection)
		{
			this.solarDashing = true;
		}

		// Token: 0x060023E9 RID: 9193 RVA: 0x0012A190 File Offset: 0x00128390
		private void DoCommonDashHandle([Out] int dir, [Out] bool dashing, [Optional] Player.DashStartAction dashStartAction)
		{
			int num = this.dashTime;
		}

		// Token: 0x060023EA RID: 9194 RVA: 0x0012A20C File Offset: 0x0012840C
		public void WallslideMovement()
		{
			while (this.slideDir != 0)
			{
				int num = this.spikedBoots;
				if (this.mount._active)
				{
					break;
				}
				if (this.controlLeft)
				{
					float x = this.position.X;
					return;
				}
				if (this.controlRight)
				{
					int width = this.width;
					float x2 = this.position.X;
					int height = this.height;
					float y = this.position.Y;
					float num2 = this.gravDir;
					if (15744 == 0)
					{
					}
					bool flag;
					if (!flag)
					{
					}
					int num3 = this.spikedBoots;
					float y2 = this.velocity.Y;
					float num4 = this.gravDir;
					float num5 = this.gravDir;
					float x3 = this.position.X;
					float y3 = this.position.Y;
					bool flag2 = this.controlDown;
					int num6 = 1;
					int num7 = 32768;
					this.sliding = num6 != 0;
					int width2 = this.width;
					this.fallStart = num7;
					int height2 = this.height;
					int num8 = this.slideDir;
					this.velocity.Y = (float)width;
					if (height2 == 0)
					{
					}
					int num9 = this.slideDir;
					if (num9 == 0)
					{
					}
					float num10 = this.gravDir;
					if (num9 == 0)
					{
					}
					if (num9 == 0)
					{
					}
					if (num9 == 0)
					{
					}
					if (!true)
					{
					}
					int num11 = this.cShoe;
					return;
				}
			}
		}

		// Token: 0x060023EB RID: 9195 RVA: 0x0012A438 File Offset: 0x00128638
		public void CarpetMovement()
		{
			int[] array = this.grappling;
			this.carpetFrame = array;
		}

		// Token: 0x060023EC RID: 9196 RVA: 0x0012A568 File Offset: 0x00128768
		public void DoubleJumpVisuals()
		{
			while (this.isPerformingJump_Cloud && this.hasJumpOption_Cloud && !this.canJumpAgain_Cloud)
			{
				bool flag = this.canJumpAgain_Sandstorm;
				if (flag)
				{
					float num = this.gravDir;
					float y = this.velocity.Y;
					float y2 = this.velocity.Y;
					int height = this.height;
					float x = this.position.X;
					float y3 = this.position.Y;
					int width = this.width;
					float x2 = this.velocity.X;
					float y4 = this.velocity.Y;
					if (!flag)
					{
					}
					float x3 = this.velocity.X;
					return;
				}
				if (!this.hasJumpOption_Sandstorm)
				{
					return;
				}
			}
			if (this.isPerformingJump_Sandstorm && this.hasJumpOption_Sandstorm && !this.canJumpAgain_Sandstorm)
			{
				float num2 = this.gravDir;
				float y5 = this.velocity.Y;
				float y6 = this.velocity.Y;
				int num3 = this.jump;
				int height2 = this.height;
				float x4 = this.position.X;
				float y7 = this.position.Y;
				int width2 = this.width;
				float x5 = this.velocity.X;
				float y8 = this.velocity.Y;
				if (height2 == 0)
				{
				}
				int num4 = 21846;
				int num5 = 1;
				this.sandStorm = num5 != 0;
				int width3 = this.width;
				float x6 = this.position.X;
				float y9 = this.position.Y;
				float x7 = this.velocity.X;
				float y10 = this.velocity.Y;
				if (width3 == 0)
				{
				}
				if (num5 == 0)
				{
				}
				float x8 = this.velocity.X;
				float y11 = this.velocity.Y;
				if (num4 == 0)
				{
				}
				return;
			}
			if (this.isPerformingJump_Fart && this.hasJumpOption_Fart)
			{
				bool flag2 = this.canJumpAgain_Fart;
				if (!flag2)
				{
					float num6 = this.gravDir;
					float y12 = this.velocity.Y;
					float y13 = this.velocity.Y;
					int height3 = this.height;
					float x9 = this.position.X;
					float y14 = this.position.Y;
					int width4 = this.width;
					float x10 = this.velocity.X;
					float y15 = this.velocity.Y;
					if (!flag2)
					{
					}
					float x11 = this.velocity.X;
				}
			}
			if (this.isPerformingJump_Unicorn && this.hasJumpOption_Unicorn)
			{
				bool flag3 = this.canJumpAgain_Unicorn;
				if (!flag3)
				{
					float num7 = this.gravDir;
					float y16 = this.velocity.Y;
					float y17 = this.velocity.Y;
					if (!flag3)
					{
					}
					float x12 = this.position.X;
					float y18 = this.position.Y;
					int width5 = this.width;
					bool wet = this.wet;
					if (!true)
					{
					}
					int num8 = this.cMount;
				}
			}
			if (this.isPerformingJump_Sail && this.hasJumpOption_Sail && !this.canJumpAgain_Sail)
			{
				float num9 = this.gravDir;
				float y19 = this.velocity.Y;
				float y20 = this.velocity.Y;
				int num10 = this.jump;
				int height4 = this.height;
				float x13 = this.position.X;
				float y21 = this.position.Y;
				int width6 = this.width;
				float x14 = this.velocity.X;
				float y22 = this.velocity.Y;
				if (num10 == 0)
				{
				}
				if (height4 == 0)
				{
				}
				int num11 = this.jump;
				float x15 = this.velocity.X;
				float y23 = this.velocity.Y;
				return;
			}
			if (this.isPerformingJump_Blizzard && this.hasJumpOption_Blizzard && !this.canJumpAgain_Blizzard)
			{
				float num12 = this.gravDir;
				float y24 = this.velocity.Y;
				float y25 = this.velocity.Y;
				int height5 = this.height;
				long num13 = 0L;
				float x16 = this.position.X;
				float y26 = this.position.Y;
				int width7 = this.width;
				float x17 = this.velocity.X;
				float y27 = this.velocity.Y;
				if (height5 == 0)
				{
				}
				float x18 = this.velocity.X;
				float y28 = this.velocity.Y;
				if (num13 != 0L)
				{
					return;
				}
				float x19 = this.velocity.X;
				float y29 = this.velocity.Y;
				float x20 = this.position.X;
				float y30 = this.position.Y;
				int width8 = this.width;
				float x21 = this.velocity.X;
				float y31 = this.velocity.Y;
				float x22 = this.velocity.X;
				float y32 = this.velocity.Y;
				float x23 = this.position.X;
				float y33 = this.position.Y;
				int width9 = this.width;
				float x24 = this.velocity.X;
				float y34 = this.velocity.Y;
				float x25 = this.velocity.X;
				float y35 = this.velocity.Y;
			}
		}

		// Token: 0x060023ED RID: 9197 RVA: 0x0012AAC4 File Offset: 0x00128CC4
		public void WingMovement()
		{
			int num = this.wingsLogic;
			if (this.controlUp || this.tryKeepingHoveringUp)
			{
				float num2 = this.gravDir;
				float y = this.velocity.Y;
				return;
			}
			if (!this.controlUp)
			{
				bool flag = this.tryKeepingHoveringUp;
				if (!flag)
				{
					if ((this.controlDown || this.tryKeepingHoveringDown) && !this.controlJump)
					{
						float y2 = this.velocity.Y;
						this.velocity.Y = y2;
						return;
					}
					int num3 = this.wingsLogic;
					if (!this.controlUp)
					{
						bool flag2 = this.tryKeepingHoveringUp;
						if (!flag2)
						{
							if ((this.controlDown || this.tryKeepingHoveringDown) && !this.controlJump)
							{
								float y3 = this.velocity.Y;
								this.velocity.Y = y3;
							}
							int num4 = this.wingsLogic;
							if (this.controlDown || this.tryKeepingHoveringDown)
							{
								float num5 = this.gravDir;
								float y4 = this.velocity.Y;
								float num6;
								this.velocity.Y = num6;
								return;
							}
							return;
						}
					}
					float num7 = this.gravDir;
					float y5 = this.velocity.Y;
					float num8;
					this.velocity.Y = num8;
					return;
				}
			}
			float num9 = this.gravDir;
			float y6 = this.velocity.Y;
			float num10;
			this.velocity.Y = num10;
		}

		// Token: 0x060023EE RID: 9198 RVA: 0x0012AE48 File Offset: 0x00129048
		public void MoonLeechRope()
		{
			if (!true)
			{
			}
			int whoAmI = this.whoAmI;
		}

		// Token: 0x060023EF RID: 9199 RVA: 0x0012AED0 File Offset: 0x001290D0
		public void WOFTongue()
		{
			if (!true)
			{
			}
			float x = this.position.X;
			int width = this.width;
			bool flag = this.gross;
			if (flag)
			{
				if (!flag)
				{
				}
				PlayerDeathReason playerDeathReason = PlayerDeathReason.LegacyDefault();
			}
			bool flag2 = this.gross;
			int num6;
			bool flag3;
			if (!flag2)
			{
				float y = this.position.Y;
				if (!flag2)
				{
				}
				float x2 = this.position.X;
				int num = 17648;
				int num2 = 37;
				int num3 = 10;
				int num4 = 1;
				long num5 = 0L;
				this.AddBuff(num2, num3, num4 != 0, num5 != 0L);
				if (num == 0)
				{
				}
				num6 = 32640;
				flag3 = this.gross;
				if (!flag3)
				{
					goto IL_0104;
				}
			}
			float y2 = this.position.Y;
			if (!flag3)
			{
			}
			int underworldLayer = Main.UnderworldLayer;
			int num7 = 38;
			int num8 = 10;
			int num9 = 1;
			long num10 = 0L;
			this.AddBuff(num7, num8, num9 != 0, num10 != 0L);
			if (!flag3)
			{
			}
			float x3 = this.position.X;
			int width2 = this.width;
			if (!flag3)
			{
			}
			int num11 = 38;
			int num12 = 10;
			int num13 = 1;
			long num14 = 0L;
			this.AddBuff(num11, num12, num13 != 0, num14 != 0L);
			IL_0104:
			bool flag4 = this.tongued;
			if (flag4)
			{
				if (!flag4)
				{
				}
				if (num6 != 0)
				{
					if (num6 == 0)
					{
					}
					int myPlayer = Main.myPlayer;
					if (num6 == 0)
					{
					}
				}
				Microsoft.Xna.Framework.Vector2 center = base.Center;
				return;
			}
		}

		// Token: 0x060023F0 RID: 9200 RVA: 0x0012B04C File Offset: 0x0012924C
		public void StatusFromNPC(NPC npc)
		{
			if (!true)
			{
			}
			bool expertMode = Main.expertMode;
			if (npc.type == 0)
			{
			}
			int num;
			int type;
			if (num != 0)
			{
				type = npc.type;
			}
			if (type == 0)
			{
			}
			if (type == 0)
			{
			}
			if (type == 0)
			{
			}
		}

		// Token: 0x060023F1 RID: 9201 RVA: 0x0012B70C File Offset: 0x0012990C
		public void GrappleMovement()
		{
			if (this.grappling == null)
			{
			}
			int myPlayer = Main.myPlayer;
			int whoAmI = this.whoAmI;
			Mount mount = this.mount;
			if (mount._active)
			{
				mount.Dismount(this);
			}
			float y = this.velocity.Y;
			int num = 1;
			this.canCarpet = num != 0;
			this.wingFrame = num;
			int num2 = this.wings;
		}

		// Token: 0x060023F2 RID: 9202 RVA: 0x0012BA00 File Offset: 0x00129C00
		public void DoQueenSlimeHookTeleport(Microsoft.Xna.Framework.Vector2 targetPosition)
		{
			float x = this.position.X;
			float y = this.position.Y;
			Microsoft.Xna.Framework.Vector2 size = base.Size;
			if (!true)
			{
			}
			if (!true)
			{
			}
			int width = this.width;
			bool wet = this.wet;
			float num = this.gravDir;
			float x2 = this.position.X;
			float y2 = this.position.Y;
			int whoAmI = this.whoAmI;
		}

		// Token: 0x060023F3 RID: 9203 RVA: 0x0012BA80 File Offset: 0x00129C80
		private void GetGrapplingForces(Microsoft.Xna.Framework.Vector2 fromPosition, [Out] int? preferredPlayerDirectionToSet, [Out] float preferedPlayerVelocityX, [Out] float preferedPlayerVelocityY)
		{
			int num = this.grapCount;
			int[] array = this.grappling;
			bool flag = this.controlRight;
			int num2 = true.ToInt();
			int num3 = this.controlLeft.ToInt();
			int num4 = this.controlDown.ToInt();
			bool flag2 = this.controlUp;
			int num5 = flag2.ToInt();
			float num6 = this.gravDir;
			if (!flag2)
			{
			}
			int num7 = 1;
			if (num7 == 0)
			{
			}
			int value = num7.m_value;
			if (num7 == 0)
			{
			}
			int num8 = 17096;
			Microsoft.Xna.Framework.Vector2 center = base.Center;
			if (num8 == 0)
			{
			}
			if (num8 == 0)
			{
			}
		}

		// Token: 0x060023F4 RID: 9204 RVA: 0x0012BC58 File Offset: 0x00129E58
		private void RefreshMovementAbilities(bool doubleJumps = true)
		{
			int num = this.wingTimeMax;
			int num2 = this.rocketTimeMax;
			this.rocketTime = num2;
			this.wingTime = (float)num;
			this.RefreshDoubleJumps();
		}

		// Token: 0x060023F5 RID: 9205 RVA: 0x0012BC88 File Offset: 0x00129E88
		private void RefreshDoubleJumps()
		{
			if (this.hasJumpOption_Cloud)
			{
				this.canJumpAgain_Cloud = true;
			}
			if (this.hasJumpOption_Sandstorm)
			{
				this.canJumpAgain_Sandstorm = true;
			}
			if (this.hasJumpOption_Blizzard)
			{
				this.canJumpAgain_Blizzard = true;
			}
			if (this.hasJumpOption_Fart)
			{
				this.canJumpAgain_Fart = true;
			}
			if (this.hasJumpOption_Sail)
			{
				this.canJumpAgain_Sail = true;
			}
			if (this.hasJumpOption_Unicorn)
			{
				this.canJumpAgain_Unicorn = true;
			}
			if (this.hasJumpOption_Santank)
			{
				this.canJumpAgain_Santank = true;
			}
			if (this.hasJumpOption_WallOfFleshGoat)
			{
				this.canJumpAgain_WallOfFleshGoat = true;
			}
			if (this.hasJumpOption_Basilisk)
			{
				this.canJumpAgain_Basilisk = true;
			}
		}

		// Token: 0x060023F6 RID: 9206 RVA: 0x0012BD1C File Offset: 0x00129F1C
		public void StickyMovement()
		{
			if (this.shimmering)
			{
				return;
			}
			int type = this.mount._type;
			if (this.mount._type != 0)
			{
				float x = this.velocity.X;
				return;
			}
			int width = this.width;
			bool wet = this.wet;
			float x2 = this.position.X;
			float y = this.position.Y;
			float x3 = this.position.X;
			float y2 = this.position.Y;
			float x4 = this.velocity.X;
			float y3 = this.velocity.Y;
			int width2 = this.width;
			bool wet2 = this.wet;
			if (width == 0)
			{
			}
			Tile tile;
			ushort type2 = tile.type;
			int whoAmI = this.whoAmI;
			int myPlayer = Main.myPlayer;
			float x5 = this.velocity.X;
			float y4 = this.velocity.Y;
			int num = this.stickyBreak;
			this.stickyBreak = whoAmI;
			if (num == 0)
			{
			}
			long num2 = 0L;
			long num3 = 0L;
			long num4 = 0L;
			WorldGen.KillTile(wet2 ? 1 : 0, width2, num2 != 0L, num3 != 0L, num4 != 0L);
			bool netClientOnly = Main.NetClientOnly;
			Tile tile2;
			bool flag = tile2.active();
			bool netClient = Main.NetClient;
			float y5 = this.position.Y;
			int num5 = 15744;
			this.fallStart = num5;
			float x6 = this.velocity.X;
			this.velocity.X = y;
			float num6 = this.gravDir;
			this.velocity.X = x6;
			float y6 = this.velocity.Y;
		}

		// Token: 0x060023F7 RID: 9207 RVA: 0x0012BFD0 File Offset: 0x0012A1D0
		public bool HasLockedInventory()
		{
			return this.IsStackingItems();
		}

		// Token: 0x060023F8 RID: 9208 RVA: 0x0012BFE4 File Offset: 0x0012A1E4
		public bool IsStackingItems()
		{
			bool[] array = this.inventoryChestStack;
			if (this.inventory.position == null)
			{
				int num = this.disableVoidBag;
				return;
			}
		}

		// Token: 0x060023F9 RID: 9209 RVA: 0x0012C010 File Offset: 0x0012A210
		public List<int> GetNearbyContainerProjectilesList()
		{
			/*
An exception occurred when decompiling this method (060023F9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.List`1<System.Int32> Terraria.Player::GetNearbyContainerProjectilesList()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0016:
	stloc:TileReachCheckSettings(var_10_21, callgetter:TileReachCheckSettings(TileReachCheckSettings::get_QuickStackToNearbyChests))
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

		// Token: 0x060023FA RID: 9210 RVA: 0x000021DB File Offset: 0x000003DB
		public void UpdateNearbyInteractibleProjectilesList()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060023FB RID: 9211 RVA: 0x0012C040 File Offset: 0x0012A240
		public bool IsProjectileInteractibleAndInInteractionRange(Projectile proj, Microsoft.Xna.Framework.Vector2 compareSpot)
		{
			bool active = proj.active;
			if (active)
			{
				bool flag = proj.IsInteractible();
				Rectangle hitbox = proj.Hitbox;
				float x = compareSpot.X;
				float y = compareSpot.Y;
				if (!active)
				{
				}
				TileReachCheckSettings simple = TileReachCheckSettings.Simple;
				bool flag2;
				return flag2;
			}
		}

		// Token: 0x060023FC RID: 9212 RVA: 0x0012C08C File Offset: 0x0012A28C
		public bool useVoidBag()
		{
			/*
An exception occurred when decompiling this method (060023FC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::useVoidBag()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class Terraria.Item[](var_0_06, ldfld:class Terraria.Item[](Player::inventory, ldloc:Player(this)))
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

		// Token: 0x060023FD RID: 9213 RVA: 0x0012C0B0 File Offset: 0x0012A2B0
		public void QuickStackAllChests()
		{
			bool flag = this.IsStackingItems();
			List<int> nearbyContainerProjectilesList = this.GetNearbyContainerProjectilesList();
			int size = nearbyContainerProjectilesList._size;
			if (size == 0)
			{
			}
			long num = 0L;
			int num2 = this.chest;
			this.chest = size;
			ContainerTransferContext containerTransferContext;
			ChestUI.QuickStack(containerTransferContext, num != 0L);
			Item[] array = this.inventory;
		}

		// Token: 0x060023FE RID: 9214 RVA: 0x0012C2EC File Offset: 0x0012A4EC
		public void CheckDrowning()
		{
			Mount mount;
			for (;;)
			{
				int num = 1;
				float x = this.position.X;
				float y = this.position.Y;
				int width = this.width;
				bool wet = this.wet;
				float num2 = this.gravDir;
				if (num == 0)
				{
				}
				Item[] array = this.armor;
				Microsoft.Xna.Framework.Vector2 position = array.position;
				Microsoft.Xna.Framework.Vector2 position2 = this.inventory.position;
				if (this.itemAnimation == 0)
				{
					break;
				}
				bool flag = this.gills;
				if (!flag || !flag)
				{
				}
				mount = this.mount;
				bool flag2 = this.shimmering;
				if (mount._active)
				{
					goto Block_2;
				}
			}
			int direction = this.direction;
			int height = this.height;
			float x2 = this.position.X;
			float num3 = this.gravDir;
			int height2 = this.height;
			return;
			Block_2:
			if (mount._type == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			int whoAmI = this.whoAmI;
			if (this.accMerman)
			{
				int num4 = 1;
				this.merman = num4 != 0;
				return;
			}
			int num5 = this.breathCD;
			Item[] array2 = this.inventory;
			this.breathCD = num5;
			Microsoft.Xna.Framework.Vector2 position3 = array2.position;
			int num6 = this.itemAnimation;
			bool flag3 = this.accDivingHelm;
			int num7 = this.breath;
			this.breath = num7;
			int num8 = this.breath;
			int num9 = this.statLife;
			this.statLife = num9;
			PlayerDeathReason playerDeathReason = PlayerDeathReason.ByOther(1);
		}

		// Token: 0x060023FF RID: 9215 RVA: 0x0012C534 File Offset: 0x0012A734
		public void CheckCrackedBrickBreak()
		{
			bool flag = this.shimmering;
			if (!flag)
			{
				if (!flag)
				{
				}
				float x = this.velocity.X;
				float y = this.velocity.Y;
				Microsoft.Xna.Framework.Vector2 bottom = base.Bottom;
				int num = 1;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				Microsoft.Xna.Framework.Vector2 bottomLeft = base.BottomLeft;
				if (!true)
				{
				}
				Microsoft.Xna.Framework.Vector2 bottomRight = base.BottomRight;
				if (!true)
				{
				}
				Tile tile;
				ushort type = tile.type;
				Tile tile2;
				ushort type2 = tile2.type;
				Tile tile3;
				ushort type3 = tile3.type;
				float x2 = this.position.X;
				float y2 = this.position.Y;
				float x3 = this.velocity.X;
				float y3 = this.velocity.Y;
				int width = this.width;
				int height = this.height;
				float y4 = this.position.Y;
				int num2 = 15744;
				Rectangle rect = this.getRect();
				int num3 = 1;
				int num4 = 1;
				rect.Inflate(num3, num4);
				if (num2 == 0)
				{
				}
				Tile tile4;
				bool isLoaded = tile4.IsLoaded;
				if (num2 == 0)
				{
				}
				Tile tile5;
				bool flag2 = tile5.nactive();
				if (num2 == 0)
				{
				}
				if (num2 == 0)
				{
				}
				Tile tile6;
				ushort type4 = tile6.type;
				float y5 = this.velocity.Y;
				int num5 = 16256;
				this.velocity.Y = (float)num5;
				int whoAmI = this.whoAmI;
				int width2 = this.width;
				int num6 = 15744;
				if (num6 == 0)
				{
				}
				Tile tile7;
				bool flag3 = tile7.nactive();
				if (num6 == 0)
				{
				}
				if (num6 == 0)
				{
				}
				Tile tile8;
				ushort type5 = tile8.type;
				bool netClient = Main.NetClient;
			}
		}

		// Token: 0x06002400 RID: 9216 RVA: 0x0012C6DC File Offset: 0x0012A8DC
		public void CheckIceBreak()
		{
			float y = this.velocity.Y;
			float x = this.position.X;
			float y2 = this.position.Y;
			float x2 = this.velocity.X;
			int num = 15744;
			int width = this.width;
			int height = this.height;
			float y3 = this.position.Y;
			if (num == 0)
			{
			}
			Tile tile;
			bool isLoaded = tile.IsLoaded;
			if (num == 0)
			{
			}
			Tile tile2;
			bool flag = tile2.nactive();
			if (num == 0)
			{
			}
			Tile tile3;
			ushort type = tile3.type;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			bool netClient = Main.NetClient;
			if (num == 0)
			{
			}
		}

		// Token: 0x06002401 RID: 9217 RVA: 0x0012C788 File Offset: 0x0012A988
		public void SlopeDownMovement()
		{
			Mount mount = this.mount;
			if (mount._active)
			{
				int type = mount._type;
			}
			float x = this.velocity.X;
			float y = this.velocity.Y;
			float x2 = this.position.X;
			float y2 = this.position.Y;
			int width = this.width;
			bool wet = this.wet;
			float num = this.gravity;
			float num2 = this.gravDir;
			this.sloping = true;
		}

		// Token: 0x06002402 RID: 9218 RVA: 0x0012C804 File Offset: 0x0012AA04
		public void ShimmerCollision(bool fallThrough, bool ignorePlats, bool noCollision)
		{
			bool flag = this.onTrack;
			int height = this.height;
			float x = this.velocity.X;
			float y = this.velocity.Y;
			float x2 = this.position.X;
			float y2 = this.position.Y;
			int width = this.width;
			float num = this.gravDir;
			int num2 = 32768;
			if (num2 == 0)
			{
			}
			float x3 = this.velocity.X;
			float y3 = this.velocity.Y;
			float x4 = this.position.X;
			float y4 = this.position.Y;
			if (num2 == 0)
			{
			}
			if (this.shimmerImmune)
			{
				this.TryFloatingInFluid();
				return;
			}
		}

		// Token: 0x06002403 RID: 9219 RVA: 0x0012C8BC File Offset: 0x0012AABC
		public void HoneyCollision(bool fallThrough, bool ignorePlats)
		{
			bool flag = this.onTrack;
			int width = this.width;
			bool wet = this.wet;
			float x = this.velocity.X;
			float y = this.velocity.Y;
			float x2 = this.position.X;
			float y2 = this.position.Y;
			float num = this.gravDir;
			int num2 = 32768;
			if (num2 == 0)
			{
			}
			float x3 = this.velocity.X;
			float y3 = this.velocity.Y;
			float x4 = this.position.X;
			float y4 = this.position.Y;
			if (num2 == 0)
			{
			}
			this.TryFloatingInFluid();
		}

		// Token: 0x06002404 RID: 9220 RVA: 0x0012C968 File Offset: 0x0012AB68
		public void WaterCollision(bool fallThrough, bool ignorePlats)
		{
			bool flag = this.onTrack;
			int width = this.width;
			bool wet = this.wet;
			float x = this.velocity.X;
			float y = this.velocity.Y;
			float x2 = this.position.X;
			float y2 = this.position.Y;
			float num = this.gravDir;
			int num2 = 32768;
			if (num2 == 0)
			{
			}
			float x3 = this.velocity.X;
			float y3 = this.velocity.Y;
			float x4 = this.position.X;
			float y4 = this.position.Y;
			if (num2 == 0)
			{
			}
			this.TryFloatingInFluid();
		}

		// Token: 0x06002405 RID: 9221 RVA: 0x0012CA14 File Offset: 0x0012AC14
		private void TryFloatingInFluid()
		{
			if (this.canFloatInWater && !this.controlDown)
			{
				Mount mount = this.mount;
				bool active = mount._active;
				if (active)
				{
					int type = mount._type;
				}
				int whoAmI = this.whoAmI;
				int myPlayer = Main.myPlayer;
				PlayerSittingHelper playerSittingHelper = this.sitting;
				if (playerSittingHelper != null)
				{
				}
				Microsoft.Xna.Framework.Vector2 center = base.Center;
				if (playerSittingHelper == null)
				{
				}
				if (!active)
				{
				}
				Microsoft.Xna.Framework.Vector2 center2 = base.Center;
				Mount mount2 = this.mount;
				if (mount2._active)
				{
					int type2 = mount2._type;
				}
				float y = this.velocity.Y;
				return;
			}
		}

		// Token: 0x06002406 RID: 9222 RVA: 0x0012CAEC File Offset: 0x0012ACEC
		public void DryCollision(bool fallThrough, bool ignorePlats)
		{
			int height = this.height;
			bool flag = this.onTrack;
			float x = this.position.X;
			float y = this.position.Y;
			float x2 = this.velocity.X;
			float y2 = this.velocity.Y;
			int width = this.width;
			float num = this.gravDir;
			if (height == 0)
			{
			}
			int num2 = 32768;
			Microsoft.Xna.Framework.Vector2 vector;
			float num3 = vector.Length();
			float x3 = this.velocity.X;
			float y3 = this.velocity.Y;
			if (num2 == 0)
			{
			}
			if (num2 == 0)
			{
			}
			if (!true)
			{
			}
			int type = this.mount._type;
			bool value = flag.m_value;
		}

		// Token: 0x06002407 RID: 9223 RVA: 0x0012CF30 File Offset: 0x0012B130
		private bool TouchBlockSurfaceCenter(int x, int y, Tile tile, [Out] int exitNormalX, [Out] int exitNormalY, [Out] Microsoft.Xna.Framework.Vector2 surfaceCenter)
		{
			/*
An exception occurred when decompiling this method (06002407)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::TouchBlockSurfaceCenter(System.Int32,System.Int32,Terraria.Tile,System.Int32,System.Int32,Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_2_03, ldc.i4:int32(1))
	stloc:int64(var_3_05, ldc.i4:int64(0))
	stloc:float32(var_4_11, ldfld:float32(Vector2::X, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](Entity::position, ldloc:Player[exp:Entity](this))))
	stloc:float32(var_5_1E, ldfld:float32(Vector2::Y, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](Entity::position, ldloc:Player[exp:Entity](this))))
	stloc:Vector2(var_8_29, callgetter:Vector2(Entity::get_Size, ldloc:Player[exp:Entity](this)))
	stloc:Rectangle(var_13_37, callgetter:Rectangle(Entity::get_Hitbox, ldloc:Player[exp:Entity](this)))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](exitNormalX), ldloc:int64[exp:int32](var_3_05))
	stloc:int32(var_32_5A, ldc.i4:int32(1))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](exitNormalX), ldloc:int32(var_2_03))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](exitNormalY), ldloc:int32(var_32_5A))
	stloc:int32(var_33_6E, ldc.i4:int32(1))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](exitNormalX), ldloc:int32(var_33_6E))
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

		// Token: 0x06002408 RID: 9224 RVA: 0x0012CFB8 File Offset: 0x0012B1B8
		public void SlopingCollision(bool fallThrough, bool ignorePlats)
		{
			int[] array;
			if (!this.controlDown)
			{
				array = this.grappling;
				float num = this.gravDir;
			}
			this.stairFall = true;
			float x = this.position.X;
			float y = this.position.Y;
			float x2 = this.velocity.X;
			float y2 = this.velocity.Y;
			int width = this.width;
			bool wet = this.wet;
			float num2 = this.gravity;
			if (array == null)
			{
			}
			float y3 = this.position.Y;
			float x3 = this.velocity.X;
			float y4 = this.position.Y;
			float num3 = this.gfxOffY;
			this.stepSpeed = (float)16512;
			this.gfxOffY = y4;
			float num4 = this.gravDir;
			this.position.X = y;
			this.position.Y = num2;
			this.velocity.X = x;
			this.velocity.Y = num4;
		}

		// Token: 0x06002409 RID: 9225 RVA: 0x0012D0B4 File Offset: 0x0012B2B4
		public void FloorVisuals(bool Falling)
		{
			int width = this.width;
			int height = this.height;
			float x = this.position.X;
			float y = this.position.Y;
			float num = this.gravDir;
			int num2 = 32640;
			int num3 = 63488;
			Tile floorTile = Player.GetFloorTile(43143168, Falling ? 1 : 0);
			if (num2 == 0)
			{
			}
			this.slippy2 = num2 != 0;
			this.powerrun = num3 != 0;
			if (num2 == 0)
			{
				if (num2 == 0)
				{
				}
				if (num2 == 0)
				{
					if (this.name == null)
					{
					}
					return;
				}
			}
			int num4 = 1;
			this.runningOnSand = num4 != 0;
			int whoAmI = this.whoAmI;
			if (num4 == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			int num5 = 120;
			int num6 = 180;
			int num7 = 1;
			long num8 = 0L;
			this.AddBuff(num5, num6, num7 != 0, num8 != 0L);
			if (num4 == 0)
			{
			}
			Tile tile;
			byte b = tile.slope();
			if (num4 == 0)
			{
			}
			Tile tile2;
			byte b2 = tile2.slope();
			if (num4 == 0)
			{
			}
			Tile tile3;
			byte b3 = tile3.slope();
			if (!this.wet)
			{
				bool cart = this.mount.Cart;
				return;
			}
		}

		// Token: 0x0600240A RID: 9226 RVA: 0x0012D1B8 File Offset: 0x0012B3B8
		public void ResetFloorFlags()
		{
		}

		// Token: 0x0600240B RID: 9227 RVA: 0x0012D1C8 File Offset: 0x0012B3C8
		public static Tile GetFloorTile(int x, int y)
		{
			if (!true)
			{
			}
			Tile tile;
			bool flag = tile.nactive();
			Tile tile2;
			ushort type = tile2.type;
			Tile tile3;
			bool flag2 = tile3.nactive();
			Tile tile4;
			ushort type2 = tile4.type;
			Tile tile5;
			bool flag3 = tile5.nactive();
			Tile tile6;
			ushort type3 = tile6.type;
			Tile tile7;
			return tile7;
		}

		// Token: 0x0600240C RID: 9228 RVA: 0x0012D218 File Offset: 0x0012B418
		public static int GetFloorTileType(int x, int y)
		{
			/*
An exception occurred when decompiling this method (0600240C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.Player::GetFloorTileType(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:Tile(var_0_0E, call:Tile(Player::GetFloorTile, ldc.i4:int32(-2147483648), ldloc:int32(x)))
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

		// Token: 0x0600240D RID: 9229 RVA: 0x0012D234 File Offset: 0x0012B434
		private void MakeFloorDust(bool Falling, int type, int paintColor)
		{
			float x = this.velocity.X;
			int num = 16968;
			int height = this.height;
			float x2 = this.position.X;
			float y = this.position.Y;
			int width = this.width;
			if (num == 0)
			{
			}
			int whoAmI = this.whoAmI;
		}

		// Token: 0x0600240E RID: 9230 RVA: 0x0012D3C8 File Offset: 0x0012B5C8
		public void BordersMovement()
		{
			float x = this.position.X;
			if (!true)
			{
			}
			if (17440 == 0)
			{
			}
		}

		// Token: 0x0600240F RID: 9231 RVA: 0x0012D524 File Offset: 0x0012B724
		public void CollectTaxes()
		{
			if (!true)
			{
			}
			int num = 50;
			long num2 = 0L;
			long num3 = 0L;
			long num4 = 0L;
			int num5 = Item.buyPrice((int)num2, (int)num3, (int)num4, num);
			int num6 = 25;
			long num7 = 0L;
			long num8 = 0L;
			long num9 = 0L;
			int num10 = Item.buyPrice((int)num7, num6, (int)num8, (int)num9);
			int num11 = this.taxMoney;
			if (num11 == 0)
			{
			}
			if (num11 == 0)
			{
				int num12 = NPC.TypeToDefaultHeadIndex(num5);
			}
			int num13 = this.taxMoney;
			this.taxMoney = num13;
		}

		// Token: 0x06002410 RID: 9232 RVA: 0x0012D594 File Offset: 0x0012B794
		public void GamepadEnableGrappleCooldown()
		{
			this._quickGrappleCooldown = 3;
		}

		// Token: 0x06002411 RID: 9233 RVA: 0x0012D5A8 File Offset: 0x0012B7A8
		public void TryInterruptingItemUsage()
		{
			int num = this.heldProj;
			if (this.heldProj == 0)
			{
			}
			bool hotbar = PlayerInput.Triggers.Current.Hotbar1;
			bool hotbar2 = PlayerInput.Triggers.Current.Hotbar2;
			bool hotbar3 = PlayerInput.Triggers.Current.Hotbar3;
			bool hotbar4 = PlayerInput.Triggers.Current.Hotbar4;
			bool hotbar5 = PlayerInput.Triggers.Current.Hotbar5;
			bool hotbar6 = PlayerInput.Triggers.Current.Hotbar6;
			bool hotbar7 = PlayerInput.Triggers.Current.Hotbar7;
			bool hotbar8 = PlayerInput.Triggers.Current.Hotbar8;
			bool hotbar9 = PlayerInput.Triggers.Current.Hotbar9;
			bool hotbar10 = PlayerInput.Triggers.Current.Hotbar10;
			bool hairWindow = Main.hairWindow;
			int screenHeight = Main.screenHeight;
			int screenWidth = Main.screenWidth;
			Microsoft.Xna.Framework.Vector2 mouseScreen = Main.MouseScreen;
		}

		// Token: 0x06002412 RID: 9234 RVA: 0x0012D788 File Offset: 0x0012B988
		private bool CanMoveForwardOnRope(int dir, int x, int y)
		{
			if (!true)
			{
			}
			Tile tile;
			bool flag = tile.active();
			Tile tile2;
			ushort type = tile2.type;
			int width = this.width;
			Tile tile3;
			bool flag2 = tile3.active();
			int num = 8;
			if (num == 0)
			{
			}
			Tile tile4;
			ushort type2 = tile4.type;
			if (num == 0)
			{
				if (num == 0)
				{
				}
				Tile tile5;
				bool flag3 = tile5.active();
				if (num == 0)
				{
				}
				Tile tile6;
				ushort type3 = tile6.type;
			}
			int width2 = this.width;
			bool wet = this.wet;
			if (num == 0)
			{
			}
			bool flag4;
			return flag4;
		}

		// Token: 0x06002413 RID: 9235 RVA: 0x0012D800 File Offset: 0x0012BA00
		public void UpdateHairDyeDust()
		{
			int num = 1;
			byte b = this.hairDye;
			if (num == 0)
			{
			}
			bool netHostOnly = Main.NetHostOnly;
			if (!this.dead && !this.ghost && !this.stoned)
			{
				bool flag = this.frozen;
				if (!flag)
				{
					if (!flag)
					{
					}
					int num2;
					if (num2 == 0)
					{
						if (!flag)
						{
						}
						float x = this.position.X;
						float y = this.position.Y;
						int width = this.width;
						float x2 = this.velocity.X;
						float y2 = this.velocity.Y;
					}
					int num3;
					if (num3 == 0)
					{
						float x3 = this.position.X;
						int width2 = this.width;
						float y3 = this.position.Y;
						float x4 = this.velocity.X;
						float y4 = this.velocity.Y;
						float x5 = this.velocity.X;
						float y5 = this.velocity.Y;
					}
				}
			}
		}

		// Token: 0x06002414 RID: 9236 RVA: 0x0012D95C File Offset: 0x0012BB5C
		public bool IsScopeActive()
		{
			Microsoft.Xna.Framework.Vector2 position = this.inventory.position;
			return this.scope;
		}

		// Token: 0x06002415 RID: 9237 RVA: 0x0012D97C File Offset: 0x0012BB7C
		public bool IsRightClickItemActive()
		{
			/*
An exception occurred when decompiling this method (06002415)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::IsRightClickItemActive()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_002D:
	stloc:Vector2(var_5_38, ldfld:Vector2(Entity::position, ldfld:class Terraria.Item[][exp:Entity](Player::inventory, ldloc:Player(this))))
	brtrue(IL_0000, ldloc:bool(var_2))
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

		// Token: 0x06002416 RID: 9238 RVA: 0x0012D9C8 File Offset: 0x0012BBC8
		private bool CanUseItem()
		{
			/*
An exception occurred when decompiling this method (06002416)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::CanUseItem()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_016B:
	stloc:class Terraria.Item[](var_47_171, ldfld:class Terraria.Item[](Player::inventory, ldloc:Player(this)))
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

		// Token: 0x06002417 RID: 9239 RVA: 0x0012DB54 File Offset: 0x0012BD54
		public bool CheckPulley()
		{
			int width = this.width;
			float x = this.position.X;
			float y = this.position.Y;
			if (32640 == 0)
			{
			}
			Tile tile;
			bool flag = tile.active();
			Tile tile2;
			ushort type = tile2.type;
			Tile tile3;
			bool flag2 = tile3.active();
			Tile tile4;
			ushort type2 = tile4.type;
			Tile tile5;
			bool flag3 = tile5.active();
			Tile tile6;
			ushort type3 = tile6.type;
			int width2 = this.width;
			float x2 = this.position.X;
			int num = 8;
			if (width == 0)
			{
				float x3 = this.position.X;
			}
			if (width2 == 0)
			{
				float x4 = this.position.X;
			}
			long num2 = 0L;
			if (num2 == 0L)
			{
			}
			if (num2 == 0L)
			{
			}
			int num3 = 2;
			this.pulleyDir = (byte)num3;
			this.direction = num;
			int num4 = 2;
			int num5 = 1;
			this.pulleyDir = (byte)num4;
			this.direction = num5;
			int num6 = 1;
			this.pulleyDir = (byte)num6;
			float y2 = this.position.Y;
			int width3 = this.width;
			bool wet = this.wet;
			if (num6 == 0)
			{
			}
			int num7 = 1;
			float y3 = this.position.Y;
			int num8 = 2;
			this.pulleyDir = (byte)num8;
			this.direction = num7;
			int width4 = this.width;
			bool wet2 = this.wet;
			if (num7 == 0)
			{
			}
			float y4 = this.position.Y;
			int num9 = 2;
			this.pulleyDir = (byte)num9;
			this.direction = num9;
			int width5 = this.width;
			bool wet3 = this.wet;
			if (num9 == 0)
			{
			}
			bool flag4;
			return flag4;
		}

		// Token: 0x06002418 RID: 9240 RVA: 0x0012DCCC File Offset: 0x0012BECC
		public bool CheckCuteFishron()
		{
			Mount mount = this.mount;
			if (mount != null && mount._active)
			{
				int type = mount._type;
				int width = this.width;
				float x = this.position.X;
				float y = this.position.Y;
				if (32640 == 0)
				{
				}
				Tile tile;
				bool isLoaded = tile.IsLoaded;
				if (width == 0)
				{
				}
				Tile tile2;
				bool isLoaded2 = tile2.IsLoaded;
			}
			bool flag;
			return flag;
		}

		// Token: 0x06002419 RID: 9241 RVA: 0x000021DB File Offset: 0x000003DB
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		public void Update(int i)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600241A RID: 9242 RVA: 0x0012DD34 File Offset: 0x0012BF34
		public void ResetToHellAndBackIfNotCompleted()
		{
			Player.eToHellAndBackStatus toHellAndBackStatus = this.ToHellAndBackStatus;
		}

		// Token: 0x0600241B RID: 9243 RVA: 0x0012DD48 File Offset: 0x0012BF48
		private void TryToShimmerUnstuck()
		{
			bool flag = this.shimmering;
			int num = this.timeShimmering;
			if (this.LocalInputCache != null || this.LocalInputCache.controlRight || this.LocalInputCache.controlUp || this.LocalInputCache.controlDown)
			{
				this.ShimmerUnstuck();
				return;
			}
		}

		// Token: 0x0600241C RID: 9244 RVA: 0x0012DD9C File Offset: 0x0012BF9C
		private void ShimmerUnstuck()
		{
			Microsoft.Xna.Framework.Vector2? vector = this.TryFindingShimmerFreeSpot();
			int num = 353;
			this.ClearBuff(num);
			Microsoft.Xna.Framework.Vector2 bottom = base.Bottom;
		}

		// Token: 0x0600241D RID: 9245 RVA: 0x0012DE10 File Offset: 0x0012C010
		private Microsoft.Xna.Framework.Vector2? TryFindingShimmerFreeSpot()
		{
			int num = 1;
			Microsoft.Xna.Framework.Vector2 top = base.Top;
			if (num == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2? vector;
			return vector;
		}

		// Token: 0x0600241E RID: 9246 RVA: 0x0012DEB0 File Offset: 0x0012C0B0
		private void AdjustRemainingPotionSickness()
		{
			int num = 1;
			int whoAmI = this.whoAmI;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			int num2 = 21;
			int num3 = this.FindBuffIndex(num2);
			int[] array = this.buffTime;
			int[] array2 = this.buffTime;
			bool flag = this.pStone;
		}

		// Token: 0x0600241F RID: 9247 RVA: 0x0012DF00 File Offset: 0x0012C100
		private Collision.HurtTile GetHurtTile()
		{
			Mount mount = this.mount;
			float x = this.position.X;
			float y = this.position.Y;
			int width = this.width;
			int height;
			if (mount._active)
			{
				bool cart = mount.Cart;
				height = this.height;
			}
			int height2 = this.height;
			if (height == 0)
			{
			}
			List<Point> touchedTiles = this.TouchedTiles;
			Tile tile;
			bool flag = tile.active();
			Collision.HurtTile hurtTile;
			return hurtTile;
		}

		// Token: 0x06002420 RID: 9248 RVA: 0x0012DF98 File Offset: 0x0012C198
		private void ApplyTouchDamage(int tileId, int x, int y)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				int num2 = 67;
				int num3 = 20;
				int num4 = 1;
				long num5 = 0L;
				this.AddBuff(num2, num3, num4 != 0, num5 != 0L);
			}
			if (num == 0)
			{
			}
			if (num != 0)
			{
				byte b = this.suffocateDelay;
				int num6 = 68;
				int num7 = 1;
				int num8 = 1;
				long num9 = 0L;
				this.AddBuff(num6, num7, num8 != 0, num9 != 0L);
				return;
			}
		}

		// Token: 0x06002421 RID: 9249 RVA: 0x0012E074 File Offset: 0x0012C274
		private void CapAttackSpeeds()
		{
			float num = this.meleeSpeed;
			float num2 = this.summonerWeaponSpeedBonus;
			this.meleeSpeed = num2;
			this.summonerWeaponSpeedBonus = num;
		}

		// Token: 0x06002422 RID: 9250 RVA: 0x000021DB File Offset: 0x000003DB
		private float TurnAttackSpeedToUseTimeMultiplier(float speed)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002423 RID: 9251 RVA: 0x0012E0A0 File Offset: 0x0012C2A0
		public void UpdateLuck()
		{
			this.UpdateLuckFactors();
			this.RecalculateLuck();
			if (this.luckNeedsSync)
			{
				int whoAmI = this.whoAmI;
				int myPlayer = Main.myPlayer;
				int whoAmI2 = this.whoAmI;
			}
		}

		// Token: 0x06002424 RID: 9252 RVA: 0x0012E0D8 File Offset: 0x0012C2D8
		private void ResetControls()
		{
		}

		// Token: 0x06002425 RID: 9253 RVA: 0x0012E0E8 File Offset: 0x0012C2E8
		private void UpdateControlHolds()
		{
			int num = 1;
			int whoAmI = this.whoAmI;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			if (this.controlUp)
			{
				bool flag = this.releaseUp;
				if (!flag || !flag)
				{
				}
			}
			if (this.controlDown)
			{
				bool flag2 = this.releaseDown;
				if (!flag2 || !flag2)
				{
				}
			}
			bool flag3 = this.controlUp;
			this.releaseUp = flag3;
		}

		// Token: 0x06002426 RID: 9254 RVA: 0x0012E14C File Offset: 0x0012C34C
		public void TryOpeningFullscreenMap()
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool mapEnabled = Main.mapEnabled;
			if (num == 0)
			{
			}
			Main.playerInventory = false;
			int myPlayer = Main.myPlayer;
			Main.npcChatCornerItem = 0;
			Main.mapFullscreen = true;
			Main.resetMapFull = true;
		}

		// Token: 0x06002427 RID: 9255 RVA: 0x0012E194 File Offset: 0x0012C394
		public void UpdateLuckFactors()
		{
			this.UpdateLadyBugLuckTime();
			float num = this.coinLuck;
			this.coinLuck = num;
			int whoAmI = this.whoAmI;
			int myPlayer = Main.myPlayer;
			float num2 = this.torchLuck;
			this.TryRecalculatingTorchLuck();
			float num3 = this.torchLuck;
			this.luckNeedsSync = true;
		}

		// Token: 0x06002428 RID: 9256 RVA: 0x0012E1E4 File Offset: 0x0012C3E4
		public void RecalculateLuck()
		{
			float ladyBugLuck = this.GetLadyBugLuck();
			float num = this.torchLuck;
			byte b = this.luckPotion;
			if (this.usedGalaxyPearl)
			{
			}
			bool lanternsUp = LanternNight.LanternsUp;
			float num2 = this.luck;
			this.luck = num2;
			bool hasGardenGnomeNearby = this.HasGardenGnomeNearby;
			float num3 = this.luck;
			if (hasGardenGnomeNearby)
			{
				this.luck = num3;
			}
			float num4 = this.equipmentBasedLuckBonus;
			float num5 = this.CalculateCoinLuck();
			this.luck = num3;
		}

		// Token: 0x06002429 RID: 9257 RVA: 0x0012E25C File Offset: 0x0012C45C
		public static int GetMouseScrollDelta()
		{
			if (!true)
			{
			}
			return PlayerInput.ScrollWheelDelta;
		}

		// Token: 0x0600242A RID: 9258 RVA: 0x0012E274 File Offset: 0x0012C474
		private void UpdatePortableStoolUsage()
		{
			while (this.portableStoolInfo != null && this.controlUp && !this.gravControl && !this.mount._active)
			{
				float x = this.velocity.X;
				float y = this.velocity.Y;
				if (!this.pulley)
				{
					int[] array = this.grappling;
					int heightBoost = this.portableStoolInfo.HeightBoost;
					bool flag = this.CanFitSpace(heightBoost);
					this.portableStoolInfo.IsInUse = true;
					this.ResizeHitbox();
					return;
				}
			}
		}

		// Token: 0x0600242B RID: 9259 RVA: 0x0012E2F8 File Offset: 0x0012C4F8
		private void ResizeHitbox()
		{
			int height = this.height;
			float y = this.position.Y;
			Mount mount = this.mount;
			this.position.Y = (float)height;
			float y2;
			if (mount._active)
			{
				int heightBoost = mount.HeightBoost;
				y2 = this.position.Y;
				return;
			}
			bool isInUse = this.portableStoolInfo.IsInUse;
			if (isInUse)
			{
				int heightBoost2 = this.portableStoolInfo.HeightBoost;
				return;
			}
			this.height = (isInUse ? 1 : 0);
			this.position.Y = y2;
		}

		// Token: 0x0600242C RID: 9260 RVA: 0x0012E37C File Offset: 0x0012C57C
		private void UpdateReleaseUseTile()
		{
			int lockTileInteractionsTimer = this._lockTileInteractionsTimer;
			bool flag = this.tileInteractAttempted;
			bool flag2 = this.releaseUseTile;
			this._lockTileInteractionsTimer = (flag ? 1 : 0);
		}

		// Token: 0x0600242D RID: 9261 RVA: 0x0012E3B0 File Offset: 0x0012C5B0
		private void GetMinecartDamage(float currentSpeed, [Out] int damage, [Out] float knockback)
		{
			int type = this.mount._type;
			float num = this.luck;
			if (type == 0)
			{
			}
			int num2 = Main.DamageVar(currentSpeed, knockback);
			damage.m_value = num2;
			if (this.unlockedSuperCart)
			{
				bool flag = this.enabledSuperCart;
				if (flag)
				{
					float num3 = this.luck;
					if (!flag)
					{
					}
					int num4 = Main.DamageVar(currentSpeed, knockback);
					damage.m_value = num4;
				}
			}
			if (16928 == 0)
			{
			}
			if (16928 != 0)
			{
			}
			bool expertMode = Main.expertMode;
		}

		// Token: 0x0600242E RID: 9262 RVA: 0x0012E43C File Offset: 0x0012C63C
		public void UpdateMiscCounter()
		{
			int num = this.miscCounter;
			this.miscCounter = num;
		}

		// Token: 0x0600242F RID: 9263 RVA: 0x0012E458 File Offset: 0x0012C658
		private void WingAirLogicTweaks()
		{
			int num = this.wingsLogic;
			WingStats wingStats = this.GetWingStats(num);
			if ((this.controlDown || this.tryKeepingHoveringDown) && this.controlJump)
			{
				float num2 = this.wingTime;
			}
		}

		// Token: 0x06002430 RID: 9264 RVA: 0x0012E4CC File Offset: 0x0012C6CC
		private void RocketBootVisuals()
		{
			float num = this.gravDir;
			int height = this.height;
			long num2 = 0L;
			float x = this.position.X;
			if (num2 != 0L)
			{
				int width = this.width;
				return;
			}
			float y = this.position.Y;
			int direction = this.direction;
			float x2 = this.velocity.X;
			float y2 = this.velocity.Y;
			float num3 = this.gravDir;
			int num4 = this.vanityRocketBoots;
		}

		// Token: 0x06002431 RID: 9265 RVA: 0x0012E78C File Offset: 0x0012C98C
		public void WingFrame(bool wingFlap)
		{
			int num = this.wingsLogic;
			int num2 = this.wings;
		}

		// Token: 0x06002432 RID: 9266 RVA: 0x0012F380 File Offset: 0x0012D580
		public bool ShouldDrawWingsThatAreAlwaysAnimated()
		{
			float y = this.velocity.Y;
			int[] array = this.grappling;
			if (!this.wet || !this.canFloatInWater || this.controlDown)
			{
				bool active = this.mount._active;
			}
			Mount mount = this.mount;
			if (mount._active)
			{
				int type = mount._type;
				return;
			}
		}

		// Token: 0x06002433 RID: 9267 RVA: 0x0012F3E0 File Offset: 0x0012D5E0
		private void WingAirVisuals()
		{
			int num = this.wingsLogic;
			if (this.wings == 0)
			{
			}
			int num2;
			if (num2 == 0)
			{
				int direction = this.direction;
				int height = this.height;
				float x = this.position.X;
				float y = this.position.Y;
				if (this.height == 0)
				{
				}
				if (height == 0)
				{
				}
				int num3 = 1;
				if (52429 == 0)
				{
				}
				if (num3 == 0)
				{
				}
				int num4 = this.cWings;
			}
			if (this.wings == 0)
			{
			}
			int num5;
			if (num5 == 0)
			{
				int direction2 = this.direction;
				int height2 = this.height;
				float x2 = this.position.X;
				float y2 = this.position.Y;
				if (this.height == 0)
				{
				}
				if (height2 == 0)
				{
				}
				int num6 = 1;
				if (52429 == 0)
				{
				}
				if (num6 == 0)
				{
				}
				int num7 = this.cWings;
			}
			if (this.wings == 0)
			{
			}
			int num8;
			if (num8 == 0)
			{
				int direction3 = this.direction;
				int height3 = this.height;
				float x3 = this.position.X;
				float y3 = this.position.Y;
				if (this.height == 0)
				{
				}
				if (height3 == 0)
				{
				}
				if (!true)
				{
				}
				if (height3 == 0)
				{
				}
				int num9 = this.cWings;
			}
			if (this.wings == 0)
			{
			}
			int num10;
			if (num10 == 0)
			{
				int direction4 = this.direction;
				int height4 = this.height;
				float x4 = this.position.X;
				float y4 = this.position.Y;
				if (this.height == 0)
				{
				}
				if (height4 == 0)
				{
				}
				int num11 = this.cWings;
			}
			if (this.wings == 0)
			{
			}
			int num12;
			if (num12 == 0)
			{
				int direction5 = this.direction;
				int height5 = this.height;
				float x5 = this.position.X;
				float y5 = this.position.Y;
				int height6 = this.height;
				if (direction5 == 0)
				{
				}
				if (height5 == 0)
				{
				}
				if (height5 == 0)
				{
				}
				int num13 = this.cWings;
			}
			int num14 = this.wings;
			int direction6 = this.direction;
			int height7 = this.height;
			float x6 = this.position.X;
			float y6 = this.position.Y;
			int height8 = this.height;
			if (direction6 == 0)
			{
			}
			if (height7 == 0)
			{
			}
			if (!true)
			{
			}
			float x7 = this.velocity.X;
			float y7 = this.velocity.Y;
			if (height7 == 0)
			{
			}
			int num15 = this.cWings;
			int num16;
			if (num16 == 0)
			{
				int direction7 = this.direction;
				float num17 = this.gravDir;
				float y8 = this.position.Y;
				int height9 = this.height;
				int width = this.width;
				float x8 = this.position.X;
				int height10 = this.height;
				if (width == 0)
				{
				}
				if (height7 == 0)
				{
				}
				if (!true)
				{
				}
				float x9 = this.velocity.X;
				float y9 = this.velocity.Y;
				if (height7 == 0)
				{
				}
				int num18 = this.cWings;
			}
			int num19 = this.wings;
			int direction8 = this.direction;
			int height11 = this.height;
			float x10 = this.position.X;
			float y10 = this.position.Y;
			int height12 = this.height;
			if (direction8 == 0)
			{
			}
			if (height11 == 0)
			{
			}
			int num20 = 1;
			Dust dust;
			dust.noGravity = num20 != 0;
			dust.noLight = num20 != 0;
			float x11 = dust.velocity.X;
			float y11 = dust.velocity.Y;
			if (num20 == 0)
			{
			}
			dust.velocity.X = x10;
			dust.velocity.Y = y10;
			float x12 = this.velocity.X;
			float y12 = this.velocity.Y;
			dust.velocity.X = x12;
			dust.velocity.Y = y12;
			if (num20 == 0)
			{
			}
			int num21 = this.cWings;
			int type = dust.type;
			ArmorShaderData armorShaderData;
			dust.shader = armorShaderData;
			int num22 = 1;
			dust.noGravity = num22 != 0;
			float x13 = dust.velocity.X;
			float y13 = dust.velocity.Y;
			if (num22 == 0)
			{
			}
			dust.velocity.X = x12;
			dust.velocity.Y = y12;
			if (num22 == 0)
			{
			}
			dust.color = num22;
			if (num22 == 0)
			{
			}
			int num23;
			if (num23 == 0)
			{
				int direction9 = this.direction;
				float num24 = this.gravDir;
				float y14 = this.position.Y;
				int height13 = this.height;
				int width2 = this.width;
				float x14 = this.position.X;
				int height14 = this.height;
				if (width2 == 0)
				{
				}
				if (height11 == 0)
				{
				}
				int num25 = 1;
				Dust dust2;
				dust2.noGravity = num25 != 0;
				dust2.noLight = num25 != 0;
				float x15 = dust2.velocity.X;
				float y15 = dust2.velocity.Y;
				dust2.velocity.X = x12;
				dust2.velocity.Y = y14;
				float x16 = this.velocity.X;
				float y16 = this.velocity.Y;
				dust2.velocity.X = x16;
				dust2.velocity.Y = y16;
				int num26 = this.cWings;
				int type2 = dust2.type;
				ArmorShaderData armorShaderData2;
				dust2.shader = armorShaderData2;
				int num27 = 1;
				dust2.noGravity = num27 != 0;
				float x17 = dust2.velocity.X;
				float y17 = dust2.velocity.Y;
				if (num27 == 0)
				{
				}
				dust2.velocity.X = x16;
				dust2.velocity.Y = y16;
				if (num27 == 0)
				{
				}
				dust2.color = num27;
			}
			if (this.wings == 0)
			{
			}
			int num28;
			int height15;
			if (num28 == 0)
			{
				int direction10 = this.direction;
				height15 = this.height;
				float x18 = this.position.X;
				float y18 = this.position.Y;
				if (this.height == 0)
				{
				}
				if (height15 == 0)
				{
				}
				if (!true)
				{
				}
				int num29;
				if (num29 == 0)
				{
					if (height15 == 0)
					{
					}
				}
				if (height15 == 0)
				{
				}
				if (height15 == 0)
				{
				}
				int num30 = this.cWings;
			}
			if (this.wings == 0)
			{
			}
			int num31;
			int num32;
			int num33;
			if (num31 == 0)
			{
				int direction11 = this.direction;
				if (height15 == 0)
				{
				}
				int width3 = this.width;
				bool wet = this.wet;
				float x19 = this.position.X;
				float y19 = this.position.Y;
				if (direction11 == 0)
				{
				}
				num32 = 39322;
				num33 = 16256;
				if (num33 == 0)
				{
				}
				if (num33 == 0)
				{
				}
				int num34 = this.cWings;
			}
			if (num33 == 0)
			{
			}
			int num35;
			int num36;
			if (num35 == 0)
			{
				int direction12 = this.direction;
				if (num32 == 0)
				{
				}
				int width4 = this.width;
				bool wet2 = this.wet;
				float x20 = this.position.X;
				float y20 = this.position.Y;
				if (direction12 == 0)
				{
				}
				if (!true)
				{
				}
				num36 = 200;
				if (num36 == 0)
				{
				}
				int num37 = this.cWings;
			}
			if (num36 == 0)
			{
			}
			int num38;
			if (num38 == 0)
			{
				if (num36 == 0)
				{
				}
				int num39;
				int num41;
				if (num39 == 0)
				{
					int direction13 = this.direction;
					float num40 = this.gravDir;
					float y21 = this.position.Y;
					int height16 = this.height;
					if (height16 == 0)
					{
					}
					int width5 = this.width;
					float x21 = this.position.X;
					int height17 = this.height;
					if (height16 == 0)
					{
					}
					num41 = 16256;
					if (num41 == 0)
					{
					}
					if (num41 == 0)
					{
					}
					int num42 = this.cWings;
				}
				if (num41 == 0)
				{
				}
				int num43;
				if (num43 == 0)
				{
					int direction14 = this.direction;
					float num44 = this.gravDir;
					float y22 = this.position.Y;
					int height18 = this.height;
					if (height18 == 0)
					{
					}
					int width6 = this.width;
					float x22 = this.position.X;
					int height19 = this.height;
					if (height18 == 0)
					{
					}
					if (!true)
					{
					}
					if (200 == 0)
					{
					}
					int num45 = this.cWings;
				}
			}
		}

		// Token: 0x06002434 RID: 9268 RVA: 0x0012FB9C File Offset: 0x0012DD9C
		private void HandleBeingInChestRange()
		{
			int num = this.chest;
		}

		// Token: 0x06002435 RID: 9269 RVA: 0x0012FDAC File Offset: 0x0012DFAC
		public bool IsInInteractionRangeToMultiTileHitbox(int chestPointX, int chestPointY)
		{
			/*
An exception occurred when decompiling this method (06002435)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::IsInInteractionRangeToMultiTileHitbox(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_008A:
	stloc:int32(var_27_8F, callgetter:int32(Player::get_tileRangeX))
	stloc:int32(var_28_96, callgetter:int32(Player::get_tileRangeX))
	stloc:int32(var_29_9D, callgetter:int32(Player::get_tileRangeY))
	stloc:int32(var_31_A7, callgetter:int32(Player::get_tileRangeY))
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

		// Token: 0x06002436 RID: 9270 RVA: 0x0012FE64 File Offset: 0x0012E064
		public void ResetVisibleAccessories()
		{
		}

		// Token: 0x06002437 RID: 9271 RVA: 0x0012FE74 File Offset: 0x0012E074
		public void UpdateArmorLights()
		{
			if (!this.vortexStealthActive)
			{
				int num = this.head;
				return;
			}
		}

		// Token: 0x06002438 RID: 9272 RVA: 0x0012FFC4 File Offset: 0x0012E1C4
		public void Update_NPCCollision()
		{
			if (!this.creativeGodMode)
			{
				float x = this.position.X;
				float y = this.position.Y;
				int width = this.width;
				bool wet = this.wet;
				return;
			}
		}

		// Token: 0x06002439 RID: 9273 RVA: 0x00130194 File Offset: 0x0012E394
		public bool CanParryAgainst(Rectangle blockingPlayerRect, Rectangle enemyRect, Microsoft.Xna.Framework.Vector2 enemyVelocity)
		{
			int num = this.shieldParryTimeLeft;
			int num2 = Math.Sign(0);
			if (this.direction == 0)
			{
			}
			int num3 = 1;
			if (num3 == 0)
			{
			}
			int value = num3.m_value;
			bool flag = this.immune;
			bool flag2;
			return flag2;
		}

		// Token: 0x0600243A RID: 9274 RVA: 0x001301D8 File Offset: 0x0012E3D8
		private void PurgeDD2EnergyCrystals()
		{
			Item item = this.trashItem;
			int type = item.type;
			long num = 0L;
			item.TurnToAir(num != 0L);
			if (type == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			if (this.whoAmI == 0)
			{
			}
			if (Main.mouseItem.type == 0)
			{
			}
			Item mouseItem = Main.mouseItem;
			long num2 = 0L;
			mouseItem.TurnToAir(num2 != 0L);
			Item[] array = this.inventory;
			int stack = mouseItem.stack;
			int type2 = mouseItem.type;
			long num3 = 0L;
			mouseItem.TurnToAir(num3 != 0L);
			int num4 = this.chest;
			Chest chest = this.bank;
			Item[] item2 = chest.item;
			int stack2 = mouseItem.stack;
			int type3 = mouseItem.type;
			long num5 = 0L;
			mouseItem.TurnToAir(num5 != 0L);
			int num6 = this.chest;
			Chest chest2 = this.bank3;
			Item[] item3 = chest2.item;
			int stack3 = mouseItem.stack;
			int type4 = mouseItem.type;
			long num7 = 0L;
			mouseItem.TurnToAir(num7 != 0L);
			int num8 = this.chest;
			Chest chest3 = this.bank4;
			Item[] item4 = chest3.item;
			int stack4 = mouseItem.stack;
			int type5 = mouseItem.type;
			long num9 = 0L;
			mouseItem.TurnToAir(num9 != 0L);
			int num10 = this.chest;
			Chest chest4 = this.bank2;
			Item[] item5 = chest4.item;
			int stack5 = mouseItem.stack;
			int type6 = mouseItem.type;
			long num11 = 0L;
			mouseItem.TurnToAir(num11 != 0L);
			int num12 = this.chest;
			int num13 = this.chest;
			if (num13 == 0)
			{
			}
			bool netClientOnly = Main.NetClientOnly;
			int num14 = this.chest;
			if (num13 == 0)
			{
			}
		}

		// Token: 0x0600243B RID: 9275 RVA: 0x00130380 File Offset: 0x0012E580
		public void ItemCheck_ManageRightClickFeatures()
		{
			for (;;)
			{
				int num = this.selectedItem;
				bool flag = this.controlUseTile;
				bool flag2;
				if (flag)
				{
					if (!flag)
					{
					}
					int myPlayer = Main.myPlayer;
					int whoAmI = this.whoAmI;
					flag2 = this.tileInteractionHappened;
					if (!flag2)
					{
						if (this.releaseUseItem && !this.controlUseItem)
						{
							goto Block_8;
						}
						continue;
					}
				}
				if (!flag2)
				{
				}
				Microsoft.Xna.Framework.Vector2 position = this.inventory.position;
				if (position != null)
				{
					break;
				}
				if (position == null)
				{
				}
				bool mouseRightRelease = Main.mouseRightRelease;
				if (this.altFunctionUse != 0)
				{
					goto Block_2;
				}
				int size = this._projectilesToInteractWith._size;
				List<int> projectilesToInteractWith = this._projectilesToInteractWith;
				Microsoft.Xna.Framework.Vector2 mouseWorld = Main.MouseWorld;
				int smartInteractProj = Main.SmartInteractProj;
				int size2 = this._projectilesToInteractWith._size;
				if (this.altFunctionUse == 0)
				{
					if (this.itemTime == 0 && this.itemAnimation == 0)
					{
						goto IL_0157;
					}
					Microsoft.Xna.Framework.Vector2 position2 = this.inventory.position;
					int num2 = this.itemAnimation;
					if (num2 == 0)
					{
						return;
					}
					if (num2 == 0)
					{
						Microsoft.Xna.Framework.Vector2 position3 = this.inventory.position;
					}
					if (num2 != 0)
					{
						goto Block_11;
					}
					int num3 = this.altFunctionUse;
					while (num3 != 0)
					{
					}
					if (num3 == 0 && this.inventory.position == null)
					{
						return;
					}
				}
			}
			return;
			Block_2:
			if (!this.controlUseItem)
			{
				int num4 = this.altFunctionUse;
			}
			return;
			Block_8:
			bool flag3 = this.mouseInterface;
			while (flag3)
			{
			}
			if (!flag3)
			{
			}
			if (!flag3)
			{
			}
			bool hoveringOverAnNPC = Main.HoveringOverAnNPC;
			if (!flag3)
			{
			}
			bool smartInteractShowingGenuine = Main.SmartInteractShowingGenuine;
			return;
			Block_11:
			int num5 = 1;
			this.altFunctionUse = num5;
			this.controlUseItem = num5 != 0;
			return;
			IL_0157:
			Microsoft.Xna.Framework.Vector2 position4 = this.inventory.position;
		}

		// Token: 0x0600243C RID: 9276 RVA: 0x001305C4 File Offset: 0x0012E7C4
		public void ItemCheck_ManageRightClickFeatures_ShieldRaise(bool theGeneralCheck)
		{
			if (!true)
			{
			}
			bool mouseRight = PlayerInput.Triggers.JustPressed.MouseRight;
			int whoAmI = this.whoAmI;
			int myPlayer = Main.myPlayer;
			bool flag = this.shieldRaised;
			Item[] array = this.inventory;
			if (array.position != null)
			{
				if (!this.hasRaisableShield || this.mount._active)
				{
					return;
				}
				int num = this.itemAnimation;
			}
			int num2 = this.shield_parry_cooldown;
			this.shield_parry_cooldown = num2;
			Microsoft.Xna.Framework.Vector2 center = base.Center;
			Microsoft.Xna.Framework.Vector2 center2 = base.Center;
			int direction = this.direction;
			if (direction == 0)
			{
			}
			if (direction == 0)
			{
			}
			int num3 = 16;
			int num4 = this.shieldParryTimeLeft;
			this.shieldParryTimeLeft = num4;
			this.TryTogglingShield(num3 != 0);
		}

		// Token: 0x0600243D RID: 9277 RVA: 0x001306AC File Offset: 0x0012E8AC
		public void TryTogglingShield(bool shouldGuard)
		{
			bool flag = this.shieldRaised;
		}

		// Token: 0x0600243E RID: 9278 RVA: 0x001306E4 File Offset: 0x0012E8E4
		private void HandleHotbar()
		{
			if (!true)
			{
			}
			bool hotbarPlus = PlayerInput.Triggers.Current.HotbarPlus;
			int num = true.ToInt();
			int num2 = PlayerInput.Triggers.Current.HotbarMinus.ToInt();
			int num3 = 1;
			if (num3 == 0)
			{
			}
			TriggersSet current;
			int num5;
			if (num != 0)
			{
				if (num3 == 0)
				{
				}
				int hotbarHoldTime = PlayerInput.Triggers.Current.HotbarHoldTime;
				int num4 = 1;
				if (num4 == 0)
				{
				}
				if (num4 == 0)
				{
				}
				if (!true)
				{
				}
				current = PlayerInput.Triggers.Current;
				num5 = 2;
				current.HotbarScrollCD = num5;
			}
			if (current == null)
			{
			}
			int num6 = 1;
			if (num6 == 0)
			{
			}
			if (num6 == 0)
			{
			}
			bool hotbarPlus2 = PlayerInput.Triggers.JustReleased.HotbarPlus;
			if (num5 == 0)
			{
			}
			int num7 = true.ToInt();
			int num8 = PlayerInput.Triggers.JustReleased.HotbarMinus.ToInt();
			if (PlayerInput.Triggers.Current.HotbarScrollCD == 0)
			{
			}
			TriggersPack triggers = PlayerInput.Triggers;
			TriggersSet current2;
			if (num7 != 0 && triggers.Current.HotbarScrollCD == 0)
			{
				int hotbarOffset = this.HotbarOffset;
				this.HotbarOffset = hotbarOffset;
				if (hotbarOffset == 0)
				{
				}
				current2 = PlayerInput.Triggers.Current;
				int num9 = 8;
				current2.HotbarScrollCD = num9;
			}
			if (current2 == null)
			{
			}
			bool inFancyUI = Main.inFancyUI;
			if (current2 == null)
			{
			}
			bool ingameOptionsWindow = Main.ingameOptionsWindow;
			int hotbarOffset2 = this.HotbarOffset;
			if (current2 == null)
			{
			}
			int scrollWheelDelta = PlayerInput.ScrollWheelDelta;
			long num10 = 2004318071L;
			this.HotbarOffset = (int)num10;
			this.UpdateChangeItem();
		}

		// Token: 0x0600243F RID: 9279 RVA: 0x00130860 File Offset: 0x0012EA60
		private void ItemCheckWrapped(int i)
		{
			if (!this.controlLeft && !this.controlRight && !this.controlUp)
			{
				bool flag = this.controlDown;
				if (!flag)
				{
					if (!flag)
					{
					}
					bool usingGamepad = PlayerInput.UsingGamepad;
					if (!flag)
					{
					}
					bool smartCursorIsUsed = Main.SmartCursorIsUsed;
					if (!flag)
					{
					}
				}
			}
			bool smartCursorIsUsed2 = Main.SmartCursorIsUsed;
		}

		// Token: 0x06002440 RID: 9280 RVA: 0x00130948 File Offset: 0x0012EB48
		private void ForceForwardCursor(bool state)
		{
			bool forceForwardCursor = this._forceForwardCursor;
			int mouseX = PlayerInput.MouseX;
			int mouseY = PlayerInput.MouseY;
			int mouseX2 = Main.mouseX;
			int mouseY2 = Main.mouseY;
			Microsoft.Xna.Framework.Vector2 center = base.Center;
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			if (this.direction == 0)
			{
			}
			PlayerInput.MouseY = mouseX2;
			Main.mouseY = mouseX2;
		}

		// Token: 0x06002441 RID: 9281 RVA: 0x001309DC File Offset: 0x0012EBDC
		private void ForceSmartSelectCursor(bool state)
		{
			bool forceSmartSelectCursor = this._forceSmartSelectCursor;
			if (!forceSmartSelectCursor)
			{
			}
			int mouseX = PlayerInput.MouseX;
			int mouseY = PlayerInput.MouseY;
			state.m_value = forceSmartSelectCursor;
			if (!forceSmartSelectCursor)
			{
			}
			int mouseX2 = Main.mouseX;
			int mouseY2 = Main.mouseY;
			if (!forceSmartSelectCursor)
			{
			}
			int tileTargetX = Player.tileTargetX;
			int tileTargetY = Player.tileTargetY;
			PlayerInput.MouseY = (state ? 1 : 0);
			Main.mouseY = (state ? 1 : 0);
			Point point;
			Microsoft.Xna.Framework.Vector2 vector = point.ToVector2();
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
		}

		// Token: 0x06002442 RID: 9282 RVA: 0x00130A80 File Offset: 0x0012EC80
		public void UpdateChangeItem()
		{
			int num = this.changeItem;
			this.lastHotbarItem = num;
			int num2 = this.selectedItem;
			int num3 = this.changeItem;
			this.selectedItem = num3;
			this.changeItem = num3;
			if (this.itemAnimation == 0)
			{
				bool playerInventory = Main.playerInventory;
				int num4 = this.selectedItem;
				int num5 = this.lastHotbarItem;
				this.selectedItem = num5;
			}
		}

		// Token: 0x06002443 RID: 9283 RVA: 0x00130AE4 File Offset: 0x0012ECE4
		public void ScrollHotbar(int Offset)
		{
			if (!true)
			{
			}
			int num = 9;
			int num2 = this.selectedItem;
			this.selectedItem = Offset;
			if (num != 0)
			{
				Player.SelectionRadial dpadRadial = this.DpadRadial;
				int num3 = this.selectedItem;
				dpadRadial.ChangeSelection(Offset);
				this.CircularRadial.ChangeSelection(Offset);
				this.selectedItem = num3;
			}
			int num4 = this.changeItem;
			int num5 = this.changeItem;
			this.selectedItem = num5;
			this.changeItem = num4;
			if (this.itemAnimation == 0)
			{
				return;
			}
		}

		// Token: 0x06002444 RID: 9284 RVA: 0x000021DB File Offset: 0x000003DB
		private static int ClampHotbarOffset(int Offset)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002445 RID: 9285 RVA: 0x00130B70 File Offset: 0x0012ED70
		public List<int> GetListOfProjectilesToInteractWithHack()
		{
			return this._projectilesToInteractWith;
		}

		// Token: 0x06002446 RID: 9286 RVA: 0x00130B84 File Offset: 0x0012ED84
		public void LockGamepadTileInteractions()
		{
			this._lockTileInteractionsTimer = 3;
			if (3 == 0)
			{
			}
			PlayerInput.LockGamepadTileUseButton = true;
		}

		// Token: 0x06002447 RID: 9287 RVA: 0x00130BA4 File Offset: 0x0012EDA4
		public void LookForTileInteractions()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
			int whoAmI = this.whoAmI;
			if (whoAmI == 0)
			{
			}
			bool mapFullscreen = Main.mapFullscreen;
			if (whoAmI == 0)
			{
			}
			int tileTargetX = Player.tileTargetX;
			int tileTargetY = Player.tileTargetY;
			bool smartInteractShowingGenuine = Main.SmartInteractShowingGenuine;
			int smartInteractNPC = Main.SmartInteractNPC;
			int smartInteractProj = Main.SmartInteractProj;
			int smartInteractX = Main.SmartInteractX;
			int smartInteractY = Main.SmartInteractY;
			bool flag = this.controlUseTile;
			bool hoveringOverAnNPC = Main.HoveringOverAnNPC;
			bool flag2 = this.releaseUseTile;
			if (flag2 && flag2)
			{
				if (!flag2)
				{
				}
				if (this.talkNPC == 0)
				{
				}
				bool npcChatRelease = Main.npcChatRelease;
				this.tileInteractAttempted = true;
				if (!true)
				{
				}
				if (true)
				{
					this.tileInteractAttempted = true;
					return;
				}
			}
			TileReachCheckSettings simple = TileReachCheckSettings.Simple;
			if (!true)
			{
			}
			int tileTargetX2 = Player.tileTargetX;
			int tileTargetY2 = Player.tileTargetY;
			this.TileInteractionsCheckLongDistance(tileTargetX2, tileTargetY2);
			this.TileInteractionsCheck(smartInteractX, smartInteractY);
		}

		// Token: 0x06002448 RID: 9288 RVA: 0x00130CA8 File Offset: 0x0012EEA8
		private void TryInteractingWithMinecartTrackInNearbyArea(int selectedTargetX, int selectedTargetY)
		{
			bool active;
			do
			{
				active = this.mount._active;
				if (!active)
				{
					goto IL_0022;
				}
			}
			while (active);
			if (this.mount._frame != 0)
			{
				return;
			}
			IL_0022:
			if (this.botherWithUnaimedMinecartTracks)
			{
				bool flag = this.tileInteractionHappened;
				if (!flag)
				{
					if (!flag)
					{
					}
					bool smartInteractShowingGenuine = Main.SmartInteractShowingGenuine;
					if (!flag)
					{
					}
					int smartInteractNPC = Main.SmartInteractNPC;
					if (!flag)
					{
					}
					int smartInteractProj = Main.SmartInteractProj;
					int num = 10;
					bool flag2 = WorldGen.InWorld(selectedTargetX, selectedTargetY, num);
					float num2 = this.gravDir;
					int num3 = 2;
					int num4 = 1;
					int num5 = 2343;
					TileReachCheckSettings simple = TileReachCheckSettings.Simple;
					Tile tile;
					bool isLoaded = tile.IsLoaded;
					if (!this.cursorItemIconEnabled)
					{
						this.noThrow = num3;
						this.cursorItemIconEnabled = num4 != 0;
						this.cursorItemIconID = num5;
					}
					if (this.tileInteractAttempted)
					{
						this.TileInteractionsCheck(0, selectedTargetY);
					}
					if (!this.tileInteractionHappened)
					{
					}
				}
			}
		}

		// Token: 0x06002449 RID: 9289 RVA: 0x00130D84 File Offset: 0x0012EF84
		public bool InInteractionRange(int interactX, int interactY, TileReachCheckSettings settings)
		{
			/*
An exception occurred when decompiling this method (06002449)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::InInteractionRange(System.Int32,System.Int32,Terraria.DataStructures.TileReachCheckSettings)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0038:
	stloc:int64(var_6_39, ldc.i4:int64(0))
	call:void(TileReachCheckSettings::GetRanges, ldloc:TileReachCheckSettings[exp:valuetype Terraria.DataStructures.TileReachCheckSettings&](settings), ldloc:Player(this), ldloc:int32(interactY), ldloc:int64[exp:int32](var_6_39))
	stloc:float32(var_9_50, ldfld:float32(Vector2::X, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](Entity::position, ldloc:Player[exp:Entity](this))))
	stloc:float32(var_10_5D, ldfld:float32(Vector2::Y, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](Entity::position, ldloc:Player[exp:Entity](this))))
	stloc:Vector2(var_13_68, callgetter:Vector2(Entity::get_BottomRight, ldloc:Player[exp:Entity](this)))
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

		// Token: 0x0600244A RID: 9290 RVA: 0x00130E00 File Offset: 0x0012F000
		public bool IsInTileInteractionRange(int targetX, int targetY, TileReachCheckSettings settings)
		{
			/*
An exception occurred when decompiling this method (0600244A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::IsInTileInteractionRange(System.Int32,System.Int32,Terraria.DataStructures.TileReachCheckSettings)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_0B, ldfld:float32(Vector2::X, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](Entity::position, ldloc:Player[exp:Entity](this))))
	stloc:int32(var_1_12, ldfld:int32(Entity::width, ldloc:Player[exp:Entity](this)))
	stloc:float32(var_2_1E, ldfld:float32(Vector2::Y, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](Entity::position, ldloc:Player[exp:Entity](this))))
	stloc:int32(var_4_27, ldfld:int32(Entity::height, ldloc:Player[exp:Entity](this)))
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

		// Token: 0x0600244B RID: 9291 RVA: 0x00130E38 File Offset: 0x0012F038
		public void TileInteractionsCheck(int myX, int myY)
		{
			if (!true)
			{
			}
			Tile tile;
			bool flag = tile.active();
			this.TileInteractionsMouseOver(myX, myY);
			this.TileInteractionsUse(myX, myY);
		}

		// Token: 0x0600244C RID: 9292 RVA: 0x00130E60 File Offset: 0x0012F060
		private void TileInteractionsCheckLongDistance(int myX, int myY)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int num2 = 10;
			bool flag = WorldGen.InWorld(myX, myY, num2);
			if (num == 0)
			{
			}
			Tile tile;
			bool isLoaded = tile.IsLoaded;
			if (num == 0)
			{
			}
			Tile tile2;
			bool flag2 = tile2.active();
			if (num == 0)
			{
			}
			Tile tile3;
			ushort type = tile3.type;
			this.TileInteractionsMouseOver_Containers(myX, myY);
			bool flag3 = this.cursorItemIconText == "";
			Tile tile4;
			ushort type2 = tile4.type;
			Tile tile5;
			short frameX = tile5.frameX;
			if (4855 == 0)
			{
			}
			int num3 = Chest.FindChest(43143168, (int)frameX);
			this.cursorItemIconID = int.MinValue;
		}

		// Token: 0x0600244D RID: 9293 RVA: 0x00131020 File Offset: 0x0012F220
		private void TileInteractionsUse(int myX, int myY)
		{
			if (!true)
			{
			}
			bool open = WiresUI.Open;
			int[] array = this.ownedProjectileCounts;
			bool flag = this.tileInteractAttempted;
			if (flag)
			{
				bool flag2 = this.releaseUseTile;
				if (!flag)
				{
				}
				Tile tile;
				ushort type = tile.type;
				int num = this.snowBallLauncherInteractionCooldown;
				if (flag2)
				{
					if (num == 0)
					{
					}
					Tile tile2;
					ushort type2 = tile2.type;
					if (num == 0)
					{
					}
					Tile tile3;
					ushort type3 = tile3.type;
					if (num == 0)
					{
					}
					Tile tile4;
					ushort type4 = tile4.type;
					if (num == 0)
					{
					}
					Wiring.HitSwitch(myX, myY);
					if (num == 0)
					{
					}
					return;
				}
				int num2;
				if (num2 != 0)
				{
				}
			}
		}

		// Token: 0x0600244E RID: 9294 RVA: 0x00132148 File Offset: 0x00130348
		private static bool IsHoveringOverABottomSideOfABed(int myX, int myY)
		{
			/*
An exception occurred when decompiling this method (0600244E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::IsHoveringOverABottomSideOfABed(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int16(var_1_09, callgetter:int16(Tile::get_frameX, ldloc:Tile[exp:valuetype Terraria.Tile&](var_0)))
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

		// Token: 0x0600244F RID: 9295 RVA: 0x00132160 File Offset: 0x00130360
		public void PetAnimal(int animalNpcIndex)
		{
			int num = 1;
			if (num == 0)
			{
			}
			long num2 = 0L;
			Microsoft.Xna.Framework.Vector2 bottom = base.Bottom;
			if (num == 0)
			{
			}
			bool flag = WorldGen.SolidTileAllowBottomSlope(0, (int)num2);
			bool flag2 = this.isPettingAnimal;
			if (flag2)
			{
				Microsoft.Xna.Framework.Vector2 bottom2 = base.Bottom;
				if (!flag2)
				{
				}
				return;
			}
			int num3 = 1;
			this.RemoveAllGrapplingHooks();
			Mount mount = this.mount;
			bool active = mount._active;
			if (active)
			{
				mount.Dismount(this);
			}
			long num4 = 0L;
			this.ChangeDir((int)num4);
			this.isPettingAnimal = num3 != 0;
			this.isTheAnimalBeingPetSmall = active;
			if (!active)
			{
			}
			if (!true)
			{
			}
			int num5 = 16256;
			this.gravDir = (float)num5;
			int whoAmI = this.whoAmI;
			int myPlayer = Main.myPlayer;
			int num6 = 21;
			AchievementsHelper.HandleSpecialEvent(this, num6);
		}

		// Token: 0x06002450 RID: 9296 RVA: 0x00132224 File Offset: 0x00130424
		private void GetPettingInfo(int animalNpcIndex, [Out] int targetDirection, [Out] Microsoft.Xna.Framework.Vector2 playerPositionWhenPetting, [Out] bool isPetSmall)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 center = base.Center;
			targetDirection.m_value = num;
			int num2 = 1;
			isPetSmall.m_value = num2 != 0;
		}

		// Token: 0x06002451 RID: 9297 RVA: 0x00132258 File Offset: 0x00130458
		public bool CanSnapToPosition(Microsoft.Xna.Framework.Vector2 offset)
		{
			/*
An exception occurred when decompiling this method (06002451)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::CanSnapToPosition(Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_010B:
	stloc:float32(var_36_119, ldfld:float32(Vector2::X, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](Entity::position, ldloc:Player[exp:Entity](this))))
	stloc:float32(var_37_126, ldfld:float32(Vector2::Y, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](Entity::position, ldloc:Player[exp:Entity](this))))
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

		// Token: 0x06002452 RID: 9298 RVA: 0x00132390 File Offset: 0x00130590
		private void TryAllowingSnappingToPosition(bool canSnapToPosition, Microsoft.Xna.Framework.Vector2 pos1, Microsoft.Xna.Framework.Vector2 pos2)
		{
			int width = this.width;
			if (width == 0)
			{
			}
			int height = this.height;
			if (width == 0)
			{
			}
			canSnapToPosition.m_value = width != 0;
			if (width == 0)
			{
			}
			int height2 = this.height;
			int height3 = this.height;
			if (width == 0)
			{
			}
			canSnapToPosition.m_value = width != 0;
			int height4 = this.height;
			if (width == 0)
			{
			}
			canSnapToPosition.m_value = width != 0;
			int height5 = this.height;
			if (width == 0)
			{
			}
			int height6 = this.height;
			if (width == 0)
			{
			}
			canSnapToPosition.m_value = width != 0;
		}

		// Token: 0x06002453 RID: 9299 RVA: 0x0013241C File Offset: 0x0013061C
		public void StopVanityActions(bool multiplayerBroadcast = true)
		{
		}

		// Token: 0x06002454 RID: 9300 RVA: 0x0013242C File Offset: 0x0013062C
		private void StopPettingAnimal()
		{
		}

		// Token: 0x06002455 RID: 9301 RVA: 0x0013243C File Offset: 0x0013063C
		private void UpdatePettingAnimal()
		{
			if (this.isPettingAnimal)
			{
				int num = this.talkNPC;
				int num2 = this.talkNPC;
				Microsoft.Xna.Framework.Vector2 center = base.Center;
				if (num2 == 0)
				{
				}
				if (!this.controlLeft && !this.controlRight && !this.controlUp && !this.controlDown && !this.controlJump && !this.pulley && !this.mount._active)
				{
					int direction = this.direction;
					int num3 = this.talkNPC;
					Microsoft.Xna.Framework.Vector2 bottom = base.Bottom;
					if (direction == 0)
					{
					}
				}
			}
		}

		// Token: 0x06002456 RID: 9302 RVA: 0x001324CC File Offset: 0x001306CC
		private void OpenChest(int x, int y, int newChest)
		{
			if (this.chest == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			int whoAmI = this.whoAmI;
			if (whoAmI == 0)
			{
			}
			this.chest = newChest;
			if (whoAmI == 0)
			{
			}
			Main.playerInventory = true;
			TriggersSet justPressed = PlayerInput.Triggers.JustPressed;
			long num = 0L;
			justPressed.Grapple = num != 0L;
			this.chestX = x;
			this.chestY = y;
		}

		// Token: 0x06002457 RID: 9303 RVA: 0x00132530 File Offset: 0x00130730
		public void CloseSign()
		{
			if (this.sign == 0)
			{
			}
			Main.editSign = false;
		}

		// Token: 0x06002458 RID: 9304 RVA: 0x0013254C File Offset: 0x0013074C
		private void LaunchMinecartHook(int myX, int myY)
		{
			if (!true)
			{
			}
			int mouseX = Main.mouseX;
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			int mouseY = Main.mouseY;
			Microsoft.Xna.Framework.Vector2 screenPosition2 = Main.screenPosition;
			int direction = this.direction;
			this.minecartLeft = direction != 0;
			this.RemoveAllGrapplingHooks();
			IEntitySource projectileSource_TileInteraction = this.GetProjectileSource_TileInteraction(myX, myY);
			int whoAmI = this.whoAmI;
			if (8 == 0)
			{
			}
		}

		// Token: 0x06002459 RID: 9305 RVA: 0x001325AC File Offset: 0x001307AC
		public void RemoveAllGrapplingHooks()
		{
			this.ClearGrapplingBlacklist();
			if (this.grappling == null)
			{
			}
			int whoAmI = this.whoAmI;
		}

		// Token: 0x0600245A RID: 9306 RVA: 0x001325D4 File Offset: 0x001307D4
		public void RemoveAllFishingBobbers()
		{
			if (!true)
			{
			}
			int whoAmI = this.whoAmI;
		}

		// Token: 0x0600245B RID: 9307 RVA: 0x001325F0 File Offset: 0x001307F0
		private void TileInteractionsMouseOver(int myX, int myY)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int tileTargetX = Player.tileTargetX;
			if (num == 0)
			{
			}
			int tileTargetY = Player.tileTargetY;
			if (num == 0)
			{
			}
			Tile tile;
			ushort type = tile.type;
			if (num == 0)
			{
			}
			bool flag = Player.IsHoveringOverABottomSideOfABed(myX, myY);
			int num2 = 2;
			int num3 = 1;
			this.noThrow = num2;
			this.cursorItemIconEnabled = num3 != 0;
			if (num2 == 0)
			{
			}
			Tile tile2;
			short frameY = tile2.frameY;
		}

		// Token: 0x0600245C RID: 9308 RVA: 0x00133F10 File Offset: 0x00132110
		public Microsoft.Xna.Framework.Graphics.Color ChatColor()
		{
			if (this.difficulty == 0)
			{
			}
			return 3280;
		}

		// Token: 0x0600245D RID: 9309 RVA: 0x00133F44 File Offset: 0x00132144
		private void TileInteractionsMouseOver_Containers(int myX, int myY)
		{
			if (!true)
			{
			}
			Tile tile;
			ushort type = tile.type;
			int num = Chest.FindChest(myX, myY);
		}

		// Token: 0x0600245E RID: 9310 RVA: 0x00133FB8 File Offset: 0x001321B8
		private void TryLandingOnDetonator()
		{
			int whoAmI = this.whoAmI;
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
			float y = this.velocity.Y;
			Microsoft.Xna.Framework.Vector2 bottom = base.Bottom;
			Tile tile;
			bool flag = tile.active();
		}

		// Token: 0x0600245F RID: 9311 RVA: 0x00133FFC File Offset: 0x001321FC
		private void TryBouncingBlocks(bool Falling)
		{
			if (!this.wet && !this.shimmering)
			{
				float y = this.velocity.Y;
				List<Point> touchedTiles = this.TouchedTiles;
				Tile tile;
				bool flag = tile.active();
				float y2 = this.velocity.Y;
				bool flag2 = this.controlJump;
				this.velocity.Y = y2;
				if (flag2)
				{
					this.velocity.Y = y2;
				}
				int height = this.height;
				return;
			}
		}

		// Token: 0x06002460 RID: 9312 RVA: 0x001340E4 File Offset: 0x001322E4
		public bool CanAcceptItemIntoInventory(Item item)
		{
			bool flag = this.preventAllItemPickups;
			if (!flag || !flag)
			{
				return;
			}
		}

		// Token: 0x06002461 RID: 9313 RVA: 0x00134100 File Offset: 0x00132300
		private void GrabItems(int i)
		{
			Point center = base.Hitbox.Center;
			if (this.goldRing)
			{
				return;
			}
			if (this.manaMagnet)
			{
			}
			if (this.lifeMagnet)
			{
			}
			if (!this.treasureMagnet)
			{
			}
			byte b = this.difficulty;
			CreativePowers.FarPlacementRangePower power = CreativePowerManager.Instance.GetPower<CreativePowers.FarPlacementRangePower>();
			int whoAmI = this.whoAmI;
			bool flag = power.IsEnabledForPlayer(whoAmI);
			int myPlayer = Main.myPlayer;
			if (this.inventory.position != null)
			{
				return;
			}
			int num = this.itemAnimation;
		}

		// Token: 0x06002462 RID: 9314 RVA: 0x001341F0 File Offset: 0x001323F0
		private void PullItem_ToVoidVault(Item itemToPickUp)
		{
		}

		// Token: 0x06002463 RID: 9315 RVA: 0x00134200 File Offset: 0x00132400
		private void PullItem_Common(Item itemToPickUp, float xPullSpeed)
		{
			int width = this.width;
			float x = this.position.X;
			int width2 = itemToPickUp.width;
			float x2 = itemToPickUp.position.X;
			float x3 = itemToPickUp.velocity.X;
			if (width == 0)
			{
			}
			float x4 = this.velocity.X;
			float x5 = itemToPickUp.velocity.X;
			if (width2 == 0)
			{
			}
			itemToPickUp.velocity.X = x5;
			if (width == 0)
			{
			}
		}

		// Token: 0x06002464 RID: 9316 RVA: 0x00134328 File Offset: 0x00132528
		private void PullItem_Pickup(Item itemToPickUp, float speed, int acc)
		{
			int width = itemToPickUp.width;
			bool wet = itemToPickUp.wet;
			float x = itemToPickUp.position.X;
			float y = itemToPickUp.position.Y;
			Microsoft.Xna.Framework.Vector2 center = base.Center;
			Microsoft.Xna.Framework.Vector2 center2 = base.Center;
			if (width == 0)
			{
			}
			float x2 = itemToPickUp.velocity.X;
			float y2 = itemToPickUp.velocity.Y;
			itemToPickUp.velocity.X = x2;
			itemToPickUp.velocity.Y = x;
		}

		// Token: 0x06002465 RID: 9317 RVA: 0x001343A4 File Offset: 0x001325A4
		private Item PickupItem(int playerIndex, int worldItemArrayIndex, Item itemToPickUp)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				float x = this.position.X;
				float y = this.position.Y;
				int num2 = 32640;
				int num3 = itemToPickUp.buffType;
				if (num2 == 0)
				{
				}
				bool netClientOnly = Main.NetClientOnly;
				Microsoft.Xna.Framework.Vector2 center = base.Center;
				Microsoft.Xna.Framework.Vector2 center2 = base.Center;
				if (num2 == 0)
				{
				}
				this.NebulaLevelup(num3);
			}
			float x2 = this.position.X;
			float y2 = this.position.Y;
			int num4 = 20;
			this.Heal(num4);
			float x3 = this.position.X;
			float y3 = this.position.Y;
			int num5 = this.statMana;
			this.statMana = num5;
			if (num5 == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			int whoAmI = this.whoAmI;
			float x4 = this.position.X;
			float y4 = this.position.Y;
			int num6 = this.statMana;
			this.statMana = num6;
			if (num6 == 0)
			{
			}
			int myPlayer2 = Main.myPlayer;
			int whoAmI2 = this.whoAmI;
			int num7 = 100;
			this.ManaEffect(num7);
			int num8 = this.statMana;
			int num9 = this.statManaMax2;
			this.statMana = num9;
			if (num9 == 0)
			{
			}
			bool netClient = Main.NetClient;
			Item item;
			return item;
		}

		// Token: 0x06002466 RID: 9318 RVA: 0x0013450C File Offset: 0x0013270C
		public void Heal(int amount)
		{
			int num = this.statLife;
			this.statLife = num;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			int whoAmI = this.whoAmI;
			int num2 = 1;
			this.HealEffect(amount, num2 != 0);
			int num3 = this.statLife;
			int num4 = this.statLifeMax2;
			this.statLife = num4;
		}

		// Token: 0x06002467 RID: 9319 RVA: 0x00134560 File Offset: 0x00132760
		public int GetItemGrabRange(Item item)
		{
			/*
An exception occurred when decompiling this method (06002467)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.Player::GetItemGrabRange(Terraria.Item)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0041:
	stloc:uint8(var_6_47, ldfld:uint8(Player::difficulty, ldloc:Player(this)))
	stloc:FarPlacementRangePower(var_8_56, call:FarPlacementRangePower(CreativePowerManager::GetPower, callgetter:CreativePowerManager(CreativePowerManager::get_Instance)))
	stloc:int32(var_9_5E, ldfld:int32(Entity::whoAmI, ldloc:Player[exp:Entity](this)))
	stloc:bool(var_10_69, call:bool(APerPlayerTogglePower::IsEnabledForPlayer, ldloc:FarPlacementRangePower[exp:APerPlayerTogglePower](var_8_56), ldloc:int32(var_9_5E)))
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

		// Token: 0x06002468 RID: 9320 RVA: 0x001345D8 File Offset: 0x001327D8
		public long SellItemAmount(Item item, int stack = -1)
		{
			int stack2 = item.stack;
			int amount = Main.shopSellbackHelper.GetAmount(item);
			int stack3 = item.stack;
			int num = Math.Min(amount, stack3);
			return 0L;
		}

		// Token: 0x06002469 RID: 9321 RVA: 0x00134610 File Offset: 0x00132810
		public bool SellItem(Item item, int stack = -1)
		{
			int stack2 = item.stack;
			Item[] array = this.inventory;
			int amount = Main.shopSellbackHelper.GetAmount(item);
			int stack3 = item.stack;
			int num = Math.Min(amount, stack3);
			int num2 = 53;
			Item[] array2 = this.inventory;
			bool flag = this.DoCoins(num2);
			Microsoft.Xna.Framework.Vector2 position = this.inventory.position;
			int num3 = 53;
			Item[] array3 = this.inventory;
			bool flag2 = this.DoCoins(num3);
			Microsoft.Xna.Framework.Vector2 position2 = this.inventory.position;
			int num4 = 53;
			Item[] array4 = this.inventory;
			bool flag3 = this.DoCoins(num4);
			Microsoft.Xna.Framework.Vector2 position3 = this.inventory.position;
			int num5 = 53;
			Item[] array5 = this.inventory;
			bool flag4 = this.DoCoins(num5);
			Microsoft.Xna.Framework.Vector2 position4 = this.inventory.position;
			Item[] array6 = this.inventory;
			Item item2;
			if (item2 == null || item2 != null)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600246A RID: 9322 RVA: 0x00134738 File Offset: 0x00132938
		public void RefreshItems(bool onlyIfVariantChanged = true)
		{
			int whoAmI = this.whoAmI;
			int myPlayer = Main.myPlayer;
			Recipe.UpdateItemVariants();
			Item[] array = this.inventory;
			Item[] array2 = this.armor;
			Item[] array3 = this.dye;
			Item[] array4 = this.miscEquips;
			Item[] array5 = this.miscDyes;
			Item[] item = this.bank.item;
			Item[] item2 = this.bank2.item;
			Item[] item3 = this.bank3.item;
			Item[] item4 = this.bank4.item;
			Item[] temporaryItemSlots = this._temporaryItemSlots;
		}

		// Token: 0x0600246B RID: 9323 RVA: 0x001347C0 File Offset: 0x001329C0
		private void RefreshItems(Item[] array, bool onlyIfVariantChanged)
		{
			long entityId = array.entityId;
			if (this != null)
			{
				long entityId2 = array.entityId;
			}
		}

		// Token: 0x0600246C RID: 9324 RVA: 0x001347E0 File Offset: 0x001329E0
		public void GetItemExpectedPrice(Item item, [Out] long calcForSelling, [Out] long calcForBuying)
		{
			int shopSpecialCurrency = item.shopSpecialCurrency;
			CustomCurrencyManager.GetPrices(item, calcForSelling, calcForBuying);
		}

		// Token: 0x0600246D RID: 9325 RVA: 0x00134880 File Offset: 0x00132A80
		public bool CanAffordItem(long price, int customCurrency = -1)
		{
			return CustomCurrencyManager.CanAffordItem(this, price, customCurrency);
		}

		// Token: 0x0600246E RID: 9326 RVA: 0x00134A48 File Offset: 0x00132C48
		public bool BuyItem(long price, int customCurrency = -1)
		{
			return CustomCurrencyManager.BuyItem(this, price, customCurrency);
		}

		// Token: 0x0600246F RID: 9327 RVA: 0x000021DB File Offset: 0x000003DB
		private static bool TryPurchasing(long price, List<Item[]> inv, List<Point> slotCoins, List<Point> slotsEmpty, List<Point> slotEmptyBank, List<Point> slotEmptyBank2, List<Point> slotEmptyBank3, List<Point> slotEmptyBank4)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002470 RID: 9328 RVA: 0x00134B20 File Offset: 0x00132D20
		public void AdjTiles()
		{
			bool flag = this.ateArtisanBread;
			bool[] array = this.oldAdjTile;
			bool[] array2 = this.adjTile;
			int num = 7;
			bool flag2 = this.adjWater;
			this.oldAdjWater = flag2;
			int width = this.width;
			int height = this.height;
			float x = this.position.X;
			float y = this.position.Y;
			if (num == 0)
			{
			}
			Tile tile;
			bool flag3 = tile.active();
			bool[] array3 = this.adjTile;
		}

		// Token: 0x06002471 RID: 9329 RVA: 0x00134C2C File Offset: 0x00132E2C
		public bool IsTileTypeInInteractionRange(int targetTileType, TileReachCheckSettings settings)
		{
			/*
An exception occurred when decompiling this method (06002471)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::IsTileTypeInInteractionRange(System.Int32,Terraria.DataStructures.TileReachCheckSettings)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_002D:
	stloc:uint16(var_9_34, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_8)))
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

		// Token: 0x06002472 RID: 9330 RVA: 0x00134C74 File Offset: 0x00132E74
		public void DisplayDollUpdate()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				int num2 = this.miscCounter;
				this.miscCounter = num2;
			}
		}

		// Token: 0x06002473 RID: 9331 RVA: 0x00134C98 File Offset: 0x00132E98
		public bool IsColorfulDye(int dye)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06002474 RID: 9332 RVA: 0x00134CAC File Offset: 0x00132EAC
		public bool ShouldDrawFootball()
		{
			/*
An exception occurred when decompiling this method (06002474)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::ShouldDrawFootball()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0017:
	stloc:Vector2(var_1_22, ldfld:Vector2(Entity::position, ldfld:class Terraria.Item[][exp:Entity](Player::inventory, ldloc:Player(this))))
	stloc:int32(var_3_2F, ldfld:int32(Player::itemAnimation, ldloc:Player(this)))
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

		// Token: 0x06002475 RID: 9333 RVA: 0x00134CE8 File Offset: 0x00132EE8
		public void PlayerFrame()
		{
			int num = this.swimTime;
			bool wet = this.wet;
			this.swimTime = num;
			Item[] array = this.armor;
			Microsoft.Xna.Framework.Vector2 position = array.position;
			Microsoft.Xna.Framework.Vector2 velocity = array.velocity;
			Microsoft.Xna.Framework.Vector2 oldPosition = array.oldPosition;
			bool notAmmo = array.notAmmo;
			bool material = array.material;
			bool summon = array.summon;
			if (!this.dead)
			{
				this.UpdateVisibleAccessories();
				int num2 = this.head;
				int num3 = this.body;
				int num4 = this.legs;
			}
			bool male = this.Male;
			if (!material)
			{
			}
		}

		// Token: 0x06002476 RID: 9334 RVA: 0x00136074 File Offset: 0x00134274
		private void CancelAllJumpVisualEffects()
		{
		}

		// Token: 0x06002477 RID: 9335 RVA: 0x00136084 File Offset: 0x00134284
		private void CancelAllBootRunVisualEffects()
		{
		}

		// Token: 0x06002478 RID: 9336 RVA: 0x00136094 File Offset: 0x00134294
		private void UpdateFishingBobber(Item item)
		{
			int type = item.type;
			this.overrideFishingBobber = type;
		}

		// Token: 0x06002479 RID: 9337 RVA: 0x001360B0 File Offset: 0x001342B0
		private void UpdateBootVisualEffects(Item item)
		{
			int type = item.type;
		}

		// Token: 0x0600247A RID: 9338 RVA: 0x00136134 File Offset: 0x00134334
		private void UpdateVisibleAccessories()
		{
			Item[] array = this.armor;
			int num = this.eocDash;
			Microsoft.Xna.Framework.Vector2 oldVelocity = array.oldVelocity;
			sbyte b = this.shield;
			if (this.shieldRaised)
			{
				sbyte b2 = this.shield;
			}
			bool[] array2 = this.hideVisibleAccessory;
			if (array2 != null)
			{
				float y = this.velocity.Y;
				if (this.mount._active)
				{
					return;
				}
			}
			this.wings = num;
			if (array2 == null)
			{
			}
		}

		// Token: 0x0600247B RID: 9339 RVA: 0x0013620C File Offset: 0x0013440C
		private bool ItemIsVisuallyIncompatible(Item item)
		{
			/*
An exception occurred when decompiling this method (0600247B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::ItemIsVisuallyIncompatible(Terraria.Item)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0040:
	stloc:int8(var_5_46, ldfld:int8(Item::balloonSlot, ldloc:Item(item)))
	stloc:int32(var_6_4E, ldfld:int32(Player::body, ldloc:Player(this)))
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

		// Token: 0x0600247C RID: 9340 RVA: 0x0013626C File Offset: 0x0013446C
		private bool IsVisibleCapeBad(int accFrontSlot)
		{
		}

		// Token: 0x0600247D RID: 9341 RVA: 0x0013627C File Offset: 0x0013447C
		private void UpdateVisibleAccessory(int itemSlot, Item item)
		{
			int num = item.stringColor;
			this.stringColor = num;
			this.handon = (sbyte)num;
			this.handoff = (sbyte)num;
			sbyte backSlot = item.backSlot;
			this.backpack = backSlot;
		}

		// Token: 0x0600247E RID: 9342 RVA: 0x001363A4 File Offset: 0x001345A4
		public void SetArmorEffectVisuals(Player drawPlayer)
		{
			int num = drawPlayer.head;
		}

		// Token: 0x0600247F RID: 9343 RVA: 0x001367A4 File Offset: 0x001349A4
		public static int SetMatch(Player.SetMatchRequest request, bool somethingSpecial)
		{
			if (!true)
			{
			}
			int num = 1;
			int num2 = 96;
			request.Head = num;
			return num2;
		}

		// Token: 0x06002480 RID: 9344 RVA: 0x00136824 File Offset: 0x00134A24
		public void Teleport(Microsoft.Xna.Framework.Vector2 newPos, int Style = 0, int extraInfo = 0)
		{
			int num = 100;
			int num2 = 4;
			this._funkytownAchievementCheckCooldown = num;
			this.environmentBuffImmunityTimer = num2;
			this.RemoveAllGrapplingHooks();
			if (this.shimmering || this.shimmerWet)
			{
				int num3 = 353;
				this.ClearBuff(num3);
			}
			int num4 = this.lastPortalColorIndex;
		}

		// Token: 0x06002481 RID: 9345 RVA: 0x00136A5C File Offset: 0x00134C5C
		public void DoPotionOfReturnTeleportationAndSetTheComebackPoint()
		{
			int num = 1;
			this.RemoveAllGrapplingHooks();
			Microsoft.Xna.Framework.Vector2 bottom = base.Bottom;
			bool flag = this.immune;
			int num2 = this.immuneTime;
			Microsoft.Xna.Framework.Vector2 bottom2 = base.Bottom;
			int whoAmI = this.whoAmI;
			if (num == 0)
			{
			}
			this.immune = flag;
			this.immuneTime = num2;
		}

		// Token: 0x06002482 RID: 9346 RVA: 0x00136AB4 File Offset: 0x00134CB4
		public void DoPotionOfReturnReturnToOriginalUsePosition()
		{
			if (this.PotionOfReturnOriginalUsePosition != null)
			{
				Microsoft.Xna.Framework.Vector2 size = base.Size;
				int whoAmI = this.whoAmI;
			}
		}

		// Token: 0x06002483 RID: 9347 RVA: 0x00136AE0 File Offset: 0x00134CE0
		public void AutoFinchStaff()
		{
			Item[] array = this.inventory;
		}

		// Token: 0x06002484 RID: 9348 RVA: 0x00136B00 File Offset: 0x00134D00
		public void Spawn(PlayerSpawnContext context)
		{
			if (!true)
			{
			}
			Player localPlayer = Main.LocalPlayer;
			int num = 100;
			this._funkytownAchievementCheckCooldown = num;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				bool flag = this.unlockedBiomeTorches;
				if (!flag || !flag)
				{
				}
			}
			bool flag2 = this.dead;
			bool flag3;
			if (flag2)
			{
				if (!flag2)
				{
				}
				Player.AdjustRespawnTimerForWorldJoining(this);
				flag3 = this.dead;
				return;
			}
			int whoAmI = this.whoAmI;
			if (!flag3)
			{
			}
			int myPlayer = Main.myPlayer;
			if (!flag3)
			{
			}
			int whoAmI2 = this.whoAmI;
			if (!flag3)
			{
			}
			int myPlayer2 = Main.myPlayer;
			if (!flag3)
			{
			}
			int mapTime = Main.mapTime;
			if (!flag3)
			{
			}
			Main.mapTime = 5;
			if (!flag3)
			{
			}
			Main.instantBGTransitionCounter = 10;
			this.FindSpawn();
			int spawnX = this.SpawnX;
			int spawnY = this.SpawnY;
			if (!flag3)
			{
			}
			bool flag4 = Player.CheckSpawn(spawnX, spawnY);
			if (!flag3)
			{
			}
			int num2 = 1;
			if (!flag3)
			{
			}
			NPC.ResetNetOffsets();
			bool netClientOnly = Main.NetClientOnly;
			int whoAmI3 = this.whoAmI;
			int myPlayer3 = Main.myPlayer;
			int myPlayer4 = Main.myPlayer;
			if (num2 == 0)
			{
			}
			if (true)
			{
				return;
			}
			if (true)
			{
				return;
			}
			if (!true)
			{
			}
			int num3 = this.lavaMax;
			this.lavaTime = num3;
			int num4 = this.statLife;
			int num5 = this.statLifeMax2;
			int num6 = this.breathMax;
			bool flag5 = this.spawnMax;
			int num7 = 100;
			this.statLife = num7;
			this.breath = num6;
			if (flag5)
			{
				int num8 = this.statManaMax2;
				this.statLife = num5;
				this.statMana = num8;
			}
			int num9 = 1;
			this.immune = num9 != 0;
			int spawnX2 = this.SpawnX;
			float x = this.position.X;
			float y = this.position.Y;
			int num10 = 1;
			this.active = num10 != 0;
			int spawnY2 = this.SpawnY;
			int width = this.width;
			bool wet = this.wet;
		}

		// Token: 0x06002485 RID: 9349 RVA: 0x00136F3C File Offset: 0x0013513C
		public bool Spawn_GetPositionAtWorldSpawn(int floorX, int floorY)
		{
			/*
An exception occurred when decompiling this method (06002485)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::Spawn_GetPositionAtWorldSpawn(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_1_0A, callgetter:int32(Main::get_spawnTileX))
	stloc:int32(var_3_12, callgetter:int32(Main::get_spawnTileY))
	stloc:int32(var_5_1A, call:int32(Player::Spawn_DescendFromDefaultSpace, ldloc:int32(var_1_0A), ldloc:int32(var_3_12)))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](floorX), ldloc:int32(var_1_0A))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](floorY), ldloc:int32(var_5_1A))
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

		// Token: 0x06002486 RID: 9350 RVA: 0x00136F7C File Offset: 0x0013517C
		private void Spawn_SetPositionAtWorldSpawn()
		{
			if (!true)
			{
			}
			int spawnTileX = Main.spawnTileX;
			int spawnTileY = Main.spawnTileY;
			int width = this.width;
			bool wet = this.wet;
			Player.Spawn_ForceClearArea(43143168, int.MinValue);
		}

		// Token: 0x06002487 RID: 9351 RVA: 0x00136FBC File Offset: 0x001351BC
		private static int Spawn_DescendFromDefaultSpace(int x, int y)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Tile tile;
			bool flag = tile.nactive();
			if (num == 0)
			{
			}
			if (num == 0)
			{
				if (num == 0)
				{
				}
				if (num != 0)
				{
				}
			}
			return x;
		}

		// Token: 0x06002488 RID: 9352 RVA: 0x00136FE4 File Offset: 0x001351E4
		private static void Spawn_ForceClearArea(int floorX, int floorY)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Tile tile;
			bool isLoaded = tile.IsLoaded;
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
					if (num == 0)
					{
					}
					long num2 = 0L;
					long num3 = 0L;
					long num4 = 0L;
					WorldGen.KillTile(43143168, floorX, num2 != 0L, num3 != 0L, num4 != 0L);
				}
			}
			if (num == 0)
			{
			}
			int num5 = 1;
			WorldGen.SquareTileFrame(43143168, floorX, num5 != 0);
		}

		// Token: 0x06002489 RID: 9353 RVA: 0x00137048 File Offset: 0x00135248
		private bool Spawn_IsAreaAValidWorldSpawn(int floorX, int floorY)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Tile tile;
			bool isLoaded = tile.IsLoaded;
			if (num == 0)
			{
			}
			Tile tile2;
			bool flag = tile2.nactive();
			if (num == 0)
			{
			}
			Tile tile3;
			ushort type = tile3.type;
			if (num != 0)
			{
				if (num == 0)
				{
				}
				Tile tile4;
				ushort type2 = tile4.type;
				if (num == 0)
				{
					return;
				}
			}
			if (num == 0)
			{
			}
			Tile tile5;
			byte liquid = tile5.liquid;
		}

		// Token: 0x0600248A RID: 9354 RVA: 0x001370A4 File Offset: 0x001352A4
		private void Spawn_SetPosition(int floorX, int floorY)
		{
			int width = this.width;
			bool wet = this.wet;
		}

		// Token: 0x0600248B RID: 9355 RVA: 0x001370C0 File Offset: 0x001352C0
		public void SetImmuneTimeForAllTypes(int time)
		{
			int[] array = this.hurtCooldowns;
			int num = 1;
			this.immune = num != 0;
			this.immuneTime = time;
			array.m_value = time;
		}

		// Token: 0x0600248C RID: 9356 RVA: 0x001370F0 File Offset: 0x001352F0
		public void ShadowDodge()
		{
			bool flag = this.longInvince;
			int[] array = this.hurtCooldowns;
			int num = 1;
			this.immune = num != 0;
			this.immuneTime = (flag ? 1 : 0);
			int whoAmI = this.whoAmI;
			if (!flag)
			{
			}
			int myPlayer = Main.myPlayer;
			long num2 = 0L;
			if (!flag)
			{
			}
			int[] array2 = this.buffTime;
			int[] array3 = this.buffType;
			this.DelBuff((int)num2);
		}

		// Token: 0x0600248D RID: 9357 RVA: 0x00137174 File Offset: 0x00135374
		private void PutHallowedArmorSetBonusOnCooldown()
		{
			this.shadowDodgeTimer = 1800;
		}

		// Token: 0x0600248E RID: 9358 RVA: 0x0013718C File Offset: 0x0013538C
		public void BrainOfConfusionDodge()
		{
			bool flag = this.longInvince;
			int[] array = this.hurtCooldowns;
			int num = 120;
			int num2 = 1;
			this.immune = num2 != 0;
			this.immuneTime = num;
			int num3 = 300;
			this.brainOfConfusionDodgeAnimationCounter = num3;
			int whoAmI = this.whoAmI;
			int myPlayer = Main.myPlayer;
			int num4 = 321;
			int num5 = 240;
			long num6 = 0L;
			long num7 = 0L;
			this.AddBuff(num4, num5, num6 != 0L, num7 != 0L);
			int whoAmI2 = this.whoAmI;
		}

		// Token: 0x0600248F RID: 9359 RVA: 0x00137210 File Offset: 0x00135410
		public void NinjaDodge()
		{
			bool flag = this.longInvince;
			int[] array = this.hurtCooldowns;
			int num = 1;
			this.immune = num != 0;
			this.immuneTime = (flag ? 1 : 0);
			this.immuneAlphaDirection = (int)float.Epsilon;
			float x = this.position.X;
			float y = this.position.Y;
			int width = this.width;
			bool wet = this.wet;
			int num2 = this.cWaist;
			int num3;
			if (num3 == 0)
			{
			}
			float x2 = this.position.X;
			int width2 = this.width;
			bool wet2 = this.wet;
			float y2 = this.position.Y;
			if (width2 == 0)
			{
			}
			if (!wet2)
			{
			}
			int width3 = this.width;
			bool wet3 = this.wet;
			float x3 = this.position.X;
			float y3 = this.position.Y;
			int width4 = this.width;
			bool wet4 = this.wet;
			float x4 = this.position.X;
			float y4 = this.position.Y;
			int width5 = this.width;
			bool wet5 = this.wet;
			float x5 = this.position.X;
			float y5 = this.position.Y;
			int width6 = this.width;
			bool wet6 = this.wet;
			float x6 = this.position.X;
			float y6 = this.position.Y;
			int whoAmI = this.whoAmI;
			int myPlayer = Main.myPlayer;
			int whoAmI2 = this.whoAmI;
		}

		// Token: 0x06002490 RID: 9360 RVA: 0x00137404 File Offset: 0x00135604
		public void ApplyArmorSoundAndDustChanges()
		{
			Item[] array = this.armor;
			bool flag = this.wereWolf;
			bool notAmmo = array.notAmmo;
			bool material = array.material;
			Microsoft.Xna.Framework.Vector2 position = array.position;
			Microsoft.Xna.Framework.Vector2 velocity = array.velocity;
			bool summon = array.summon;
			Microsoft.Xna.Framework.Vector2 oldPosition = array.oldPosition;
			if ((!flag && !this.forceWerewolf) || this.hideWolf)
			{
				this.boneArmor = true;
				return;
			}
		}

		// Token: 0x06002491 RID: 9361 RVA: 0x00137470 File Offset: 0x00135670
		public double Hurt(PlayerDeathReason damageSource, int Damage, int hitDirection, bool pvp = false, bool quiet = false, bool Crit = false, int cooldownCounter = -1, bool dodgeable = true)
		{
			/*
An exception occurred when decompiling this method (06002491)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Double Terraria.Player::Hurt(Terraria.DataStructures.PlayerDeathReason,System.Int32,System.Int32,System.Boolean,System.Boolean,System.Boolean,System.Int32,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0B6E:
	brtrue(IL_0000, logicnot:bool(ldc.r8:float64[exp:bool](42179920)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

		// Token: 0x06002492 RID: 9362 RVA: 0x00137FF8 File Offset: 0x001361F8
		private static bool AllowShimmerDodge(PlayerDeathReason damageSource, int cooldownCounter, bool dodgeable)
		{
			if (cooldownCounter != 0)
			{
			}
			if (NPC.GetNPCInvasionGroup(1) == 0)
			{
				while (cooldownCounter != 0)
				{
				}
				return;
			}
		}

		// Token: 0x06002493 RID: 9363 RVA: 0x00138018 File Offset: 0x00136218
		public void KillMeForGood()
		{
			if (!true)
			{
			}
			bool isCloudSave = Main.ActivePlayerFileData._isCloudSave;
			string playerPathName = Main.playerPathName;
			string playerPathName2 = Main.playerPathName;
			string text = Main.playerPathName + ".bak";
			string text2 = Main.playerPathName + ".bak";
		}

		// Token: 0x06002494 RID: 9364 RVA: 0x00138070 File Offset: 0x00136270
		public void KillMe(PlayerDeathReason damageSource, double dmg, int hitDirection, bool pvp = false)
		{
			if (!this.creativeGodMode)
			{
				bool flag = this.dead;
				if (!flag)
				{
					if (!flag)
					{
					}
					LocalUser localUser = this.LocalUser;
					if (localUser != null)
					{
						localUser.LoadState();
					}
					int num = 1;
					this.pvpDeath = num != 0;
					bool flag2 = this.trapDebuffSource;
					if (flag2)
					{
						int num2 = 4;
						AchievementsHelper.HandleSpecialEvent(this, num2);
					}
					if (!flag2)
					{
					}
					int myPlayer = Main.myPlayer;
					int whoAmI = this.whoAmI;
					int framesLeftEligibleForDeadmansChestDeathAchievement = this._framesLeftEligibleForDeadmansChestDeathAchievement;
					int num3 = 23;
					AchievementsHelper.HandleSpecialEvent(this, num3);
					int whoAmI2 = this.whoAmI;
					return;
				}
			}
		}

		// Token: 0x06002495 RID: 9365 RVA: 0x001385D4 File Offset: 0x001367D4
		private int GetRespawnTime(bool pvp)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int num2;
			int num3;
			if (num != 0)
			{
				if (num == 0)
				{
				}
				Microsoft.Xna.Framework.Vector2 center = base.Center;
				Microsoft.Xna.Framework.Vector2 center2 = base.Center;
				num2 = 1200;
				num3 = 1;
			}
			bool expertMode = Main.expertMode;
			long num4 = 32752L;
			int num5 = 32768;
			if (num3 != 0)
			{
				if (num4 == 0L)
				{
				}
				if (num5 != 0)
				{
					if (num5 == 0)
					{
					}
					if (num4 != 0L)
					{
						int whoAmI = this.whoAmI;
						if (whoAmI == 0)
						{
						}
						if (whoAmI == 0)
						{
						}
					}
				}
			}
			return num2;
		}

		// Token: 0x06002496 RID: 9366 RVA: 0x0013864C File Offset: 0x0013684C
		public void DropTombstone(long coinsOwned, NetworkText deathText, int hitDirection)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool logicHost = Main.LogicHost;
			if (num == 0)
			{
			}
			int num2;
			if (num2 != 0)
			{
			}
		}

		// Token: 0x06002497 RID: 9367 RVA: 0x00138708 File Offset: 0x00136908
		public bool CanPullItem(Item item, Player.ItemSpaceStatus status)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06002498 RID: 9368 RVA: 0x00138718 File Offset: 0x00136918
		public Player.ItemSpaceStatus ItemSpace(Item newItem)
		{
			/*
An exception occurred when decompiling this method (06002498)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Player/ItemSpaceStatus Terraria.Player::ItemSpace(Terraria.Item)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_005C:
	stloc:class Terraria.Item[](var_15_69, ldfld:class Terraria.Item[](Player::inventory, ldloc:Player(this)))
	stloc:bool(var_17_72, call:bool(Player::ItemSpaceForCofveve, ldloc:Player(this), ldloc:Item(newItem)))
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

		// Token: 0x06002499 RID: 9369 RVA: 0x00138798 File Offset: 0x00136998
		public void ItemSpace(Item newItem, Player.ItemSpaceStatus result)
		{
			if (!true)
			{
			}
			int num = 1;
			long num2 = 0L;
			result.Set(num != 0, num2 != 0L);
		}

		// Token: 0x0600249A RID: 9370 RVA: 0x00138824 File Offset: 0x00136A24
		public bool ItemSpaceForCofveve(Item newItem)
		{
			if (!newItem.questItem)
			{
				int type = newItem.type;
				long entityId = this.bank4.item.entityId;
				int netID = newItem.netID;
				return;
			}
		}

		// Token: 0x0600249B RID: 9371 RVA: 0x00138868 File Offset: 0x00136A68
		public bool CanItemSlotAccept(Item theSlot, Item theItemToAccept)
		{
			if (theSlot.type != 0)
			{
				int stack = theSlot.stack;
				int pick = theSlot.pick;
				bool flag = theItemToAccept.IsTheSameAs(theSlot);
			}
			return true;
		}

		// Token: 0x0600249C RID: 9372 RVA: 0x00138898 File Offset: 0x00136A98
		public bool CanGoIntoAmmoOnPickup(Item theSlot, Item theItemToAccept)
		{
			do
			{
				bool flag = theItemToAccept.CanFillEmptyAmmoSlot();
			}
			while (theSlot.type == 0);
			int stack = theSlot.stack;
			int pick = theSlot.pick;
			bool flag2 = theItemToAccept.IsTheSameAs(theSlot);
			return true;
		}

		// Token: 0x0600249D RID: 9373 RVA: 0x001388D0 File Offset: 0x00136AD0
		public bool DoCoins(int i)
		{
			Microsoft.Xna.Framework.Vector2 position = this.inventory.position;
			Microsoft.Xna.Framework.Vector2 position2 = this.inventory.position;
			Item[] array = this.inventory;
			int type = array.type;
			int stack = array.stack;
			int pick = array.pick;
			bool flag;
			return flag;
		}

		// Token: 0x0600249E RID: 9374 RVA: 0x00138948 File Offset: 0x00136B48
		public bool CanFillAmmo(int plr, Item newItem)
		{
			/*
An exception occurred when decompiling this method (0600249E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::CanFillAmmo(System.Int32,Terraria.Item)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class Terraria.Item[](var_10_48, ldfld:class Terraria.Item[](Player::inventory, ldloc:Player(this)))
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

		// Token: 0x0600249F RID: 9375 RVA: 0x001389A8 File Offset: 0x00136BA8
		public Item FillAmmo(int plr, Item newItem, GetItemSettings settings)
		{
			int num = 54;
			Microsoft.Xna.Framework.Vector2 position = this.inventory.position;
			float x = this.position.X;
			float y = this.position.Y;
			Item[] array = this.inventory;
			int stack = newItem.stack;
			Microsoft.Xna.Framework.Vector2 position2 = array.position;
			Microsoft.Xna.Framework.Vector2 position3 = this.inventory.position;
			bool flag = this.DoCoins(num);
			int myPlayer = Main.myPlayer;
			Recipe.FindRecipes(false);
			Microsoft.Xna.Framework.Vector2 position4 = this.inventory.position;
			bool flag2 = newItem.CanFillEmptyAmmoSlot();
			Item[] array2 = this.inventory;
			if (newItem == null || newItem != null)
			{
				int stack2 = newItem.stack;
				float x2 = this.position.X;
				float y2 = this.position.Y;
				int num2 = 32640;
				int num3 = 32768;
				if (num2 == 0)
				{
				}
				int myPlayer2 = Main.myPlayer;
				Recipe.FindRecipes(false);
				this.inventory.stack = num3;
				int stack3 = newItem.stack;
				int myPlayer3 = Main.myPlayer;
				Recipe.FindRecipes(false);
				Microsoft.Xna.Framework.Vector2 position5 = this.inventory.position;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060024A0 RID: 9376 RVA: 0x00138AD0 File Offset: 0x00136CD0
		public bool CanStoreItem(int plr, Item newItem)
		{
			/*
An exception occurred when decompiling this method (060024A0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::CanStoreItem(System.Int32,Terraria.Item)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0066:
	brtrue(IL_0066, ldloc:int32[exp:bool](var_10))
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

		// Token: 0x060024A1 RID: 9377 RVA: 0x00138B48 File Offset: 0x00136D48
		public Item GetItem(int plr, Item newItem, GetItemSettings settings, bool disableMerge = false)
		{
			bool isACoin = newItem.IsACoin;
			int noGrabDelay = newItem.noGrabDelay;
			return newItem;
		}

		// Token: 0x060024A2 RID: 9378 RVA: 0x00138C30 File Offset: 0x00136E30
		private bool GetItem_VoidVault(int plr, Item[] inventory, Item newItem, GetItemSettings settings, Item returnItem)
		{
			/*
An exception occurred when decompiling this method (060024A2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::GetItem_VoidVault(System.Int32,Terraria.Item[],Terraria.Item,Terraria.GetItemSettings,Terraria.Item)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0047:
	call:void(AchievementsHelper::NotifyItemPickup, ldloc:Player(this), ldloc:Item(newItem))
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

		// Token: 0x060024A3 RID: 9379 RVA: 0x00138C94 File Offset: 0x00136E94
		private bool CanVoidVaultAccept(Item item)
		{
			/*
An exception occurred when decompiling this method (060024A3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::CanVoidVaultAccept(Terraria.Item)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000A:
	stloc:int32(var_1_10, ldfld:int32(Item::type, ldloc:Item(item)))
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

		// Token: 0x060024A4 RID: 9380 RVA: 0x00138CB4 File Offset: 0x00136EB4
		private bool GetItem_FillIntoOccupiedSlot_VoidBag(int plr, Item[] inv, Item newItem, GetItemSettings settings, Item returnItem, int i)
		{
			/*
An exception occurred when decompiling this method (060024A4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::GetItem_FillIntoOccupiedSlot_VoidBag(System.Int32,Terraria.Item[],Terraria.Item,Terraria.GetItemSettings,Terraria.Item,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Vector2(var_1_08, ldfld:Vector2(Entity::position, ldloc:class Terraria.Item[][exp:Entity](inv)))
	stloc:bool(var_3_0F, callgetter:bool(Item::get_IsACoin, ldloc:Item(newItem)))
	stloc:float32(var_4_1B, ldfld:float32(Vector2::X, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](Entity::position, ldloc:Player[exp:Entity](this))))
	stloc:float32(var_5_28, ldfld:float32(Vector2::Y, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](Entity::position, ldloc:Player[exp:Entity](this))))
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

		// Token: 0x060024A5 RID: 9381 RVA: 0x00138CFC File Offset: 0x00136EFC
		private bool GetItem_FillIntoOccupiedSlot(int plr, Item newItem, GetItemSettings settings, Item returnItem, int i)
		{
			/*
An exception occurred when decompiling this method (060024A5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::GetItem_FillIntoOccupiedSlot(System.Int32,Terraria.Item,Terraria.GetItemSettings,Terraria.Item,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00AC:
	call:void(Recipe::FindRecipes, ldc.i4:bool(0))
	stloc:Vector2(var_23_BD, ldfld:Vector2(Entity::position, ldfld:class Terraria.Item[][exp:Entity](Player::inventory, ldloc:Player(this))))
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

		// Token: 0x060024A6 RID: 9382 RVA: 0x00138DCC File Offset: 0x00136FCC
		private bool GetItem_FillEmptyInventorySlot_VoidBag(int plr, Item[] inv, Item newItem, GetItemSettings settings, Item returnItem, int i)
		{
			bool isACoin = newItem.IsACoin;
			float x = this.position.X;
			float y = this.position.Y;
			if (i == 0 || i != 0)
			{
				int stack = newItem.stack;
				int myPlayer = Main.myPlayer;
				Recipe.FindRecipes(false);
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060024A7 RID: 9383 RVA: 0x00138E28 File Offset: 0x00137028
		private bool GetItem_FillEmptyInventorySlot(int plr, Item newItem, GetItemSettings settings, Item returnItem, int i, bool disableMerge)
		{
			if (this.inventory.position != null)
			{
			}
			bool isACoin = newItem.IsACoin;
			float x = this.position.X;
			float y = this.position.Y;
			Item[] array = this.inventory;
			if (i == 0 || i != 0)
			{
				int stack = newItem.stack;
				bool flag = this.DoCoins(disableMerge ? 1 : 0);
				int myPlayer = Main.myPlayer;
				Recipe.FindRecipes(false);
				int myPlayer2 = Main.myPlayer;
				int type = newItem.type;
				Microsoft.Xna.Framework.Vector2 top = base.Top;
				if (type == 0)
				{
				}
				Microsoft.Xna.Framework.Vector2 position = this.inventory.position;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060024A8 RID: 9384 RVA: 0x00138ED8 File Offset: 0x001370D8
		public void PlaceThing(Player.ItemCheckContext context)
		{
			if (this.itemTime == 0)
			{
			}
			this.PlaceThing_Paintbrush();
			this.PlaceThing_PaintRoller();
			this.PlaceThing_PaintScrapper();
			this.PlaceThing_CannonBall();
			this.PlaceThing_XMasTreeTops();
			this.PlaceThing_ItemInExtractinator(context);
			this.PlaceThing_LockChest();
			if (this.noBuilding)
			{
				return;
			}
			this.PlaceThing_Tiles();
			this.PlaceThing_Walls();
		}

		// Token: 0x060024A9 RID: 9385 RVA: 0x00138F30 File Offset: 0x00137130
		private void PlaceThing_Walls()
		{
			for (;;)
			{
				Microsoft.Xna.Framework.Vector2 position = this.inventory.position;
				float x = this.position.X;
				if (position == null)
				{
				}
				int tileRangeX = Player.tileRangeX;
				Item[] array = this.inventory;
				int num = this.blockRange;
				Microsoft.Xna.Framework.Vector2 position2 = array.position;
				int tileTargetX = Player.tileTargetX;
				int num2 = 15744;
				float x2 = this.position.X;
				int width = this.width;
				if (num2 == 0)
				{
				}
				int tileRangeX2 = Player.tileRangeX;
				Item[] array2 = this.inventory;
				int num3 = this.blockRange;
				Microsoft.Xna.Framework.Vector2 position3 = array2.position;
				int tileTargetX2 = Player.tileTargetX;
				int num4 = 15744;
				float y = this.position.Y;
				if (num4 == 0)
				{
				}
				int tileRangeY = Player.tileRangeY;
				Item[] array3 = this.inventory;
				int num5 = this.blockRange;
				Microsoft.Xna.Framework.Vector2 position4 = array3.position;
				int tileTargetY = Player.tileTargetY;
				int num6 = 15744;
				float y2 = this.position.Y;
				int height = this.height;
				if (num6 == 0)
				{
				}
				int tileRangeY2 = Player.tileRangeY;
				Item[] array4 = this.inventory;
				int num7 = this.blockRange;
				Microsoft.Xna.Framework.Vector2 position5 = array4.position;
				int tileTargetY2 = Player.tileTargetY;
				int num8 = this.itemTime;
				int num9 = 1;
				this.cursorItemIconEnabled = num9 != 0;
				if (num8 != 0)
				{
					break;
				}
				int num10 = this.itemAnimation;
				bool flag = this.controlUseItem;
				while (!flag)
				{
				}
				if (!flag)
				{
				}
				int tileTargetX3 = Player.tileTargetX;
				int tileTargetY3 = Player.tileTargetY;
				Tile tile;
				bool flag2 = tile.active();
				int tileTargetX4 = Player.tileTargetX;
				int tileTargetY4 = Player.tileTargetY;
				Tile tile2;
				ushort wall = tile2.wall;
				int tileTargetX5 = Player.tileTargetX;
				int tileTargetY5 = Player.tileTargetY;
				Tile tile3;
				bool flag3 = tile3.active();
				int tileTargetX6 = Player.tileTargetX;
				int tileTargetY6 = Player.tileTargetY;
				Tile tile4;
				ushort wall2 = tile4.wall;
				int tileTargetX7 = Player.tileTargetX;
				int tileTargetY7 = Player.tileTargetY;
				Tile tile5;
				bool flag4 = tile5.active();
				int tileTargetX8 = Player.tileTargetX;
				int tileTargetY8 = Player.tileTargetY;
				Tile tile6;
				ushort wall3 = tile6.wall;
				int tileTargetX9 = Player.tileTargetX;
				int tileTargetY9 = Player.tileTargetY;
				Tile tile7;
				bool flag5 = tile7.active();
				int tileTargetX10 = Player.tileTargetX;
				int tileTargetY10 = Player.tileTargetY;
				Tile tile8;
				ushort wall4 = tile8.wall;
				int tileTargetX11 = Player.tileTargetX;
				int tileTargetY11 = Player.tileTargetY;
				Tile tile9;
				ushort wall5 = tile9.wall;
				Microsoft.Xna.Framework.Vector2 position6 = this.inventory.position;
				int[] array5 = this.builderAccStatus;
				if (array5 == null)
				{
					int num11 = 1;
					bool flag6 = this.PlaceThing_TryReplacingWalls(num11 != 0);
				}
				if (array5 == null)
				{
				}
				int tileTargetX12 = Player.tileTargetX;
				int tileTargetY12 = Player.tileTargetY;
				Item[] array6 = this.inventory;
				long num12 = 0L;
				WorldGen.PlaceWall(tileTargetX12, tileTargetY12, 0, num12 != 0L);
				if (!false)
				{
				}
				int tileTargetX13 = Player.tileTargetX;
				int tileTargetY13 = Player.tileTargetY;
				Tile tile10;
				ushort wall6 = tile10.wall;
				Microsoft.Xna.Framework.Vector2 position7 = this.inventory.position;
				float num13 = this.wallSpeed;
				int num14 = 32640;
				this.itemTime = num14;
				this.itemTimeMax = num14;
				if (num14 == 0)
				{
				}
				bool netClient = Main.NetClient;
				if (num14 == 0)
				{
				}
				int tileTargetX14 = Player.tileTargetX;
				int tileTargetY14 = Player.tileTargetY;
				Item[] array7 = this.inventory;
				this.PlaceThing_Walls_FillEmptySpace();
				if (this.autoPaint)
				{
					goto Block_3;
				}
			}
			return;
			Block_3:
			int[] array8 = this.builderAccStatus;
			while (array8 != null)
			{
			}
			if (array8 == null)
			{
			}
			int tileTargetX15 = Player.tileTargetX;
			int tileTargetY15 = Player.tileTargetY;
			int num15 = 1;
			long num16 = 0L;
			this.TryPainting(tileTargetX15, tileTargetY15, num15 != 0, num16 != 0L);
		}

		// Token: 0x060024AA RID: 9386 RVA: 0x00139258 File Offset: 0x00137458
		private void PlaceThing_Walls_FillEmptySpace()
		{
			if (!true)
			{
			}
			int tileTargetX = Player.tileTargetX;
			int tileTargetY = Player.tileTargetY;
		}

		// Token: 0x060024AB RID: 9387 RVA: 0x000021DB File Offset: 0x000003DB
		private void PlaceThing_Tiles()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060024AC RID: 9388 RVA: 0x001392CC File Offset: 0x001374CC
		private bool ModifyFlexibleWandPlacementInfo(int tileType, int tileStyle, int? forcedRandom)
		{
			Item[] array = this.inventory;
			Microsoft.Xna.Framework.Vector2 position = array.position;
			FlexibleTileWand flexibleTileWand;
			if (flexibleTileWand != null)
			{
				int whoAmI = this.whoAmI;
				if (array == null)
				{
				}
				int myPlayer = Main.myPlayer;
				if (array == null)
				{
				}
				int tileTargetX = Player.tileTargetX;
				int tileTargetY = Player.tileTargetY;
				return;
			}
		}

		// Token: 0x060024AD RID: 9389 RVA: 0x00139314 File Offset: 0x00137514
		private bool PlaceThing_TryReplacingWalls(bool canUse)
		{
			int num = this.itemAnimation;
			if (this.itemTime != 0)
			{
			}
			bool flag = this.controlUseItem;
			while (!flag)
			{
			}
			if (!flag)
			{
			}
			int tileTargetX = Player.tileTargetX;
			int tileTargetY = Player.tileTargetY;
			bool flag2 = WorldGen.NearFriendlyWall(tileTargetX, tileTargetY);
			int tileTargetX2 = Player.tileTargetX;
			int tileTargetY2 = Player.tileTargetY;
			Item[] array = this.inventory;
			bool flag3 = WorldGen.ReplaceWall(tileTargetX2, tileTargetY2, (ushort)tileTargetY);
			Item[] array2 = this.inventory;
			float num2 = this.wallSpeed;
			Microsoft.Xna.Framework.Vector2 position = array2.position;
			int num3 = 32640;
			this.itemTime = num3;
			this.itemTimeMax = num3;
			if (num3 == 0)
			{
			}
			int tileTargetX3 = Player.tileTargetX;
			int tileTargetY3 = Player.tileTargetY;
			Item[] array3 = this.inventory;
			if (!this.autoPaint)
			{
				return;
			}
			int[] array4 = this.builderAccStatus;
			if (array4 == null)
			{
				if (array4 == null)
				{
				}
				int tileTargetX4 = Player.tileTargetX;
				int tileTargetY4 = Player.tileTargetY;
				int num4 = 1;
				long num5 = 0L;
				this.TryPainting(tileTargetX4, tileTargetY4, num4 != 0, num5 != 0L);
				return;
			}
		}

		// Token: 0x060024AE RID: 9390 RVA: 0x00139408 File Offset: 0x00137608
		private bool PlaceThing_ValidWallForReplacement()
		{
			/*
An exception occurred when decompiling this method (060024AE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::PlaceThing_ValidWallForReplacement()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_0_08, callgetter:int32(Player::get_tileTargetX))
	stloc:int32(var_1_0E, callgetter:int32(Player::get_tileTargetY))
	stloc:int32(var_3_14, callgetter:int32(Player::get_tileTargetX))
	stloc:int32(var_4_1A, callgetter:int32(Player::get_tileTargetY))
	stloc:uint16(var_6_23, callgetter:uint16(Tile::get_wall, ldloc:Tile[exp:valuetype Terraria.Tile&](var_5)))
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

		// Token: 0x060024AF RID: 9391 RVA: 0x0013943C File Offset: 0x0013763C
		private bool PlaceThing_TryReplacingTiles(bool canUse)
		{
			bool flag2;
			do
			{
				bool flag = this.PlaceThing_ValidTileForReplacement();
				TileObject.objectPreview.Reset();
				flag2 = this.controlUseItem;
			}
			while (!flag2);
			if (!flag2)
			{
			}
			int tileTargetX = Player.tileTargetX;
			int tileTargetY = Player.tileTargetY;
			Tile tile;
			bool flag3 = tile.active();
			int num = this.itemAnimation;
			int num2 = this.itemTime;
			return flag3;
		}

		// Token: 0x060024B0 RID: 9392 RVA: 0x00139654 File Offset: 0x00137854
		private bool PlaceThing_ValidTileForReplacement()
		{
			Microsoft.Xna.Framework.Vector2 position = this.inventory.position;
			bool flag = this.unlockedBiomeTorches;
			int[] array;
			if (flag)
			{
				if (this.builderAccStatus == null)
				{
				}
				array = this.builderAccStatus;
				if (array == null)
				{
				}
			}
			if (array == null)
			{
			}
			int tileTargetX = Player.tileTargetX;
			int tileTargetY = Player.tileTargetY;
			int tileTargetX2 = Player.tileTargetX;
			int tileTargetY2 = Player.tileTargetY;
			if (!flag)
			{
			}
			int num = 1;
			bool flag2 = WorldGen.WouldTileReplacementBeBlockedByLiquid(tileTargetX2, tileTargetY2, num);
			Microsoft.Xna.Framework.Vector2 position2 = this.inventory.position;
			if (position2 == null)
			{
			}
			if (position2 == null)
			{
				if (position2 == null)
				{
				}
				if (flag || !flag)
				{
				}
			}
			int num2 = 22;
			if (num2 == 0)
			{
			}
			if (num2 != 0)
			{
				if (num2 == 0)
				{
				}
				if (num2 != 0)
				{
				}
			}
			if (num2 == 0)
			{
			}
			int num3;
			if (num2 != 0)
			{
				if (num2 == 0)
				{
				}
				if (num2 != 0)
				{
					num3 = 4855;
				}
			}
			if (num2 == 0)
			{
			}
			if (num2 != 0)
			{
			}
			if (num2 == 0)
			{
			}
			if (num2 != 0)
			{
				if (num2 == 0)
				{
				}
				while (num2 == 0)
				{
				}
			}
			if (num2 == 0)
			{
			}
			int tileTargetX3 = Player.tileTargetX;
			int tileTargetY3 = Player.tileTargetY;
			Tile tile;
			ushort type = tile.type;
			int tileTargetX4 = Player.tileTargetX;
			int tileTargetY4 = Player.tileTargetY;
			Tile tile2;
			ushort type2 = tile2.type;
			int tileTargetX5 = Player.tileTargetX;
			int tileTargetY5 = Player.tileTargetY;
			if (num3 == 0)
			{
			}
			if (this.inventory.position == null)
			{
			}
			int tileTargetX6 = Player.tileTargetX;
			int tileTargetY6 = Player.tileTargetY;
			if (num3 == 0)
			{
			}
			bool flag3;
			return flag3;
		}

		// Token: 0x060024B1 RID: 9393 RVA: 0x00139788 File Offset: 0x00137988
		private bool PlaceThing_CheckSpecificValidtyCaseForBlockSwap(int tileTypeBeingPlaced, int tileTypeCurrentlyPlaced)
		{
			/*
An exception occurred when decompiling this method (060024B1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::PlaceThing_CheckSpecificValidtyCaseForBlockSwap(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_002A:
	stloc:int32(var_6_2F, callgetter:int32(Player::get_tileTargetX))
	stloc:int32(var_7_36, callgetter:int32(Player::get_tileTargetY))
	stloc:bool(var_9_3F, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_8)))
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

		// Token: 0x060024B2 RID: 9394 RVA: 0x001397DC File Offset: 0x001379DC
		public Item GetBestPickaxe()
		{
			/*
An exception occurred when decompiling this method (060024B2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Item Terraria.Player::GetBestPickaxe()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	stloc:class Terraria.Item[](var_0_06, ldfld:class Terraria.Item[](Player::inventory, ldloc:Player(this)))
	stloc:int64(var_1_08, ldc.i4:int64(0))
	brtrue(IL_0000, logicnot:bool(ldloc:int64[exp:bool](var_1_08)))
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

		// Token: 0x060024B3 RID: 9395 RVA: 0x001397F8 File Offset: 0x001379F8
		private TileObject PlaceThing_Tiles_PlaceIt(bool newObjectType, TileObject data, int tileToCreate)
		{
			/*
An exception occurred when decompiling this method (060024B3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.TileObject Terraria.Player::PlaceThing_Tiles_PlaceIt(System.Boolean,Terraria.TileObject,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_021A:
	stloc:int32(var_54_220, ldfld:int32(TileObject::alternate, ldloc:TileObject[exp:valuetype Terraria.TileObject&](data)))
	stfld:int32(TileObject::alternate, ldloc:TileObject[exp:valuetype Terraria.TileObject&](var_0), ldloc:int32(var_54_220))
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

		// Token: 0x060024B4 RID: 9396 RVA: 0x00139A30 File Offset: 0x00137C30
		public void PlaceThing_Tiles_PlaceIt_ConsumeFlexibleWandMaterial()
		{
			Item[] array = this.inventory;
			Microsoft.Xna.Framework.Vector2 position = array.position;
			FlexibleTileWand flexibleTileWand;
			if (flexibleTileWand != null)
			{
				if (array == null)
				{
				}
				int damage = array.damage;
				int healLife = array.healLife;
			}
		}

		// Token: 0x060024B5 RID: 9397 RVA: 0x00139A64 File Offset: 0x00137C64
		public int BiomeTorchPlaceStyle(int style)
		{
			if (this.unlockedBiomeTorches)
			{
				int[] array = this.builderAccStatus;
				if (array == null)
				{
					float y = this.position.Y;
					if (array == null)
					{
					}
					return Main.UnderworldLayer;
				}
			}
			int num;
			return num;
		}

		// Token: 0x060024B6 RID: 9398 RVA: 0x00139AD8 File Offset: 0x00137CD8
		public int BiomeTorchHoldStyle(int style)
		{
			int[] array;
			for (;;)
			{
				if (this.unlockedBiomeTorches)
				{
					array = this.builderAccStatus;
					if (array == null)
					{
						break;
					}
				}
			}
			float y = this.position.Y;
			if (array == null)
			{
			}
			return Main.UnderworldLayer;
		}

		// Token: 0x060024B7 RID: 9399 RVA: 0x00139B74 File Offset: 0x00137D74
		public int BiomeCampfirePlaceStyle(int style)
		{
			if (this.unlockedBiomeTorches)
			{
				int[] array = this.builderAccStatus;
				if (array == null)
				{
					float y = this.position.Y;
					if (array == null)
					{
					}
					return Main.UnderworldLayer;
				}
			}
			int num;
			return num;
		}

		// Token: 0x060024B8 RID: 9400 RVA: 0x00139BE8 File Offset: 0x00137DE8
		public int BiomeCampfireHoldStyle(int itemType)
		{
			int[] array;
			for (;;)
			{
				if (this.unlockedBiomeTorches)
				{
					array = this.builderAccStatus;
					if (array == null)
					{
						break;
					}
				}
			}
			float y = this.position.Y;
			if (array == null)
			{
			}
			return Main.UnderworldLayer;
		}

		// Token: 0x060024B9 RID: 9401 RVA: 0x00139C94 File Offset: 0x00137E94
		private int[,] PlaceThing_Tiles_GetAutoAccessoryCache()
		{
			/*
An exception occurred when decompiling this method (060024B9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32[,] Terraria.Player::PlaceThing_Tiles_GetAutoAccessoryCache()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0010:
	stloc:int32(var_2_19, callgetter:int32(Player::get_tileTargetX))
	stloc:int32(var_3_1F, callgetter:int32(Player::get_tileTargetY))
	stloc:bool(var_5_27, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_4)))
	stloc:uint16(var_7_30, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_6)))
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

		// Token: 0x060024BA RID: 9402 RVA: 0x00139CD4 File Offset: 0x00137ED4
		private int PlaceThing_Tiles_PlaceIt_GetLegacyTileStyle(int style)
		{
			Item[] array = this.inventory;
			Microsoft.Xna.Framework.Vector2 position = array.position;
			if (array == null)
			{
			}
			int direction = this.direction;
			if (array == null)
			{
				if (array == null)
				{
				}
				int num;
				return num;
			}
			return style;
		}

		// Token: 0x060024BB RID: 9403 RVA: 0x00139D34 File Offset: 0x00137F34
		private void PlaceThing_Tiles_PlaceIt_UnslopeForSolids()
		{
			if (!true)
			{
			}
			Microsoft.Xna.Framework.Vector2 position = this.inventory.position;
			Microsoft.Xna.Framework.Vector2 position2 = this.inventory.position;
			if (position2 == null)
			{
				if (position2 == null)
				{
				}
				int tileTargetX = Player.tileTargetX;
				int tileTargetY = Player.tileTargetY;
				Tile tile;
				ushort type = tile.type;
				int tileTargetX2 = Player.tileTargetX;
				int tileTargetY2 = Player.tileTargetY;
				Tile tile2;
				ushort type2 = tile2.type;
				Tile tile3;
				bool flag = tile3.bottomSlope();
				long num = 0L;
				long num2 = 0L;
				bool flag2 = WorldGen.SlopeTile(tileTargetX2, 0, (int)num, num2 != 0L);
				bool netClient = Main.NetClient;
			}
		}

		// Token: 0x060024BC RID: 9404 RVA: 0x00139DF0 File Offset: 0x00137FF0
		private void PlaceThing_Tiles_PlaceIt_KillGrassForSolids()
		{
			if (!true)
			{
			}
			Microsoft.Xna.Framework.Vector2 position = this.inventory.position;
			if (position != null)
			{
				if (position == null)
				{
				}
				int tileTargetX = Player.tileTargetX;
				if (position == null)
				{
				}
				int tileTargetX2 = Player.tileTargetX;
				if (position == null)
				{
				}
				int tileTargetY = Player.tileTargetY;
				if (position == null)
				{
				}
				int tileTargetY2 = Player.tileTargetY;
				if (position == null)
				{
				}
				Tile tile;
				bool flag = tile.active();
				Microsoft.Xna.Framework.Vector2 position2 = this.inventory.position;
				if (position2 == null)
				{
				}
				long num = 0L;
				bool flag2 = WorldGen.SolidTile(0, int.MinValue, num != 0L);
				if (position2 == null)
				{
				}
				int num2 = 1;
				long num3 = 0L;
				long num4 = 0L;
				WorldGen.KillTile(43143168, int.MinValue, num2 != 0, num3 != 0L, num4 != 0L);
				if (position2 == null)
				{
				}
				bool netClient = Main.NetClient;
				return;
			}
		}

		// Token: 0x060024BD RID: 9405 RVA: 0x00139E9C File Offset: 0x0013809C
		private void PlaceThing_Tiles_PlaceIt_AutoPaintAndActuate(int[,] typeCaches, int tileToCreate)
		{
			bool flag;
			if (!this.autoPaint)
			{
				flag = this.autoActuator;
				if (!flag)
				{
					return;
				}
			}
			if (!flag)
			{
			}
			int tileTargetX = Player.tileTargetX;
			int tileTargetY = Player.tileTargetY;
			Tile tile;
			ushort type = tile.type;
			int tileTargetX2 = Player.tileTargetX;
			int tileTargetY2 = Player.tileTargetY;
			Tile tile2;
			ushort type2 = tile2.type;
		}

		// Token: 0x060024BE RID: 9406 RVA: 0x00139FE4 File Offset: 0x001381E4
		private void PlaceThing_Tiles_PlaceIt_SpinSmartPlatform()
		{
			Microsoft.Xna.Framework.Vector2 position = this.inventory.position;
			Microsoft.Xna.Framework.Vector2 position2 = this.inventory.position;
			if (position2 != null)
			{
				if (position2 == null)
				{
				}
				bool smartCursorIsUsed = Main.SmartCursorIsUsed;
				int tileTargetX = Player.tileTargetX;
				int tileTargetY = Player.tileTargetY;
				Tile tile;
				ushort type = tile.type;
				Tile tile2;
				bool flag = tile2.active();
				return;
			}
		}

		// Token: 0x060024BF RID: 9407 RVA: 0x0013A2A0 File Offset: 0x001384A0
		private void PlaceThing_Tiles_PlaceIt_TriggerLogicLamp()
		{
			Microsoft.Xna.Framework.Vector2 position = this.inventory.position;
			bool netClient = Main.NetClient;
			int tileTargetX = Player.tileTargetX;
			int tileTargetY = Player.tileTargetY;
		}

		// Token: 0x060024C0 RID: 9408 RVA: 0x0013A2DC File Offset: 0x001384DC
		private void PlaceThing_Tiles_PlaceIt_SpinBedsAndBaths()
		{
			Microsoft.Xna.Framework.Vector2 position = this.inventory.position;
			bool netClientOnly = Main.NetClientOnly;
			int tileTargetX = Player.tileTargetX;
			int tileTargetY = Player.tileTargetY;
		}

		// Token: 0x060024C1 RID: 9409 RVA: 0x0013A30C File Offset: 0x0013850C
		private void PlaceThing_Tiles_PlaceIt_SpinChairs()
		{
			Microsoft.Xna.Framework.Vector2 position = this.inventory.position;
			if (this.direction == 0)
			{
			}
			int tileTargetX = Player.tileTargetX;
			int tileTargetY = Player.tileTargetY;
			int tileTargetX2 = Player.tileTargetX;
			int tileTargetY2 = Player.tileTargetY;
			Tile tile;
			short frameX = tile.frameX;
			bool netClientOnly = Main.NetClientOnly;
			int tileTargetX3 = Player.tileTargetX;
			int tileTargetY3 = Player.tileTargetY;
		}

		// Token: 0x060024C2 RID: 9410 RVA: 0x0013A370 File Offset: 0x00138570
		private void PlaceThing_Tiles_PlaceIt_SpinTraps()
		{
			Microsoft.Xna.Framework.Vector2 position = this.inventory.position;
			if (this.direction == 0)
			{
			}
			int tileTargetX = Player.tileTargetX;
			int tileTargetY = Player.tileTargetY;
			Tile tile;
			short frameX = tile.frameX;
			bool netClientOnly = Main.NetClientOnly;
			int tileTargetX2 = Player.tileTargetX;
			int tileTargetY2 = Player.tileTargetY;
		}

		// Token: 0x060024C3 RID: 9411 RVA: 0x0013A3C0 File Offset: 0x001385C0
		private void PlaceThing_Tiles_PlaceIt_AdjustPlants()
		{
			Microsoft.Xna.Framework.Vector2 position = this.inventory.position;
			if (this.inventory.position != null)
			{
				long entityId = this.entityId;
				if (entityId != 0L)
				{
					if (entityId == 0L)
					{
					}
					long entityId2 = this.entityId;
					int tileTargetX = Player.tileTargetX;
					int tileTargetY = Player.tileTargetY;
					Tile tile;
					tile.frameX = (short)tileTargetX;
					bool netClientOnly = Main.NetClientOnly;
					int tileTargetX2 = Player.tileTargetX;
					int tileTargetY2 = Player.tileTargetY;
				}
			}
		}

		// Token: 0x060024C4 RID: 9412 RVA: 0x0013A42C File Offset: 0x0013862C
		private bool PlaceThing_Tiles_PlaceIt_StaffOfRegrowthCheck(bool placed)
		{
			Microsoft.Xna.Framework.Vector2 position = this.inventory.position;
			if (5295 == 0)
			{
			}
			int tileTargetX = Player.tileTargetX;
			int tileTargetY = Player.tileTargetY;
			Tile tile;
			ushort type = tile.type;
			int tileTargetX2 = Player.tileTargetX;
			int tileTargetY2 = Player.tileTargetY;
			Tile tile2;
			bool flag = tile2.active();
			Microsoft.Xna.Framework.Vector2 center = base.Center;
			int tileTargetX3 = Player.tileTargetX;
			int tileTargetY3 = Player.tileTargetY;
			int tileTargetX4 = Player.tileTargetX;
			int tileTargetY4 = Player.tileTargetY;
			if (5295 == 0)
			{
			}
			int tileTargetX5 = Player.tileTargetX;
			int tileTargetY5 = Player.tileTargetY;
			Tile tile3;
			ushort type2 = tile3.type;
			int tileTargetX6 = Player.tileTargetX;
			int tileTargetY6 = Player.tileTargetY;
			Tile tile4;
			bool flag2 = tile4.active();
			int tileTargetX7 = Player.tileTargetX;
			int tileTargetY7 = Player.tileTargetY;
			int tileTargetX8 = Player.tileTargetX;
			int tileTargetY8 = Player.tileTargetY;
			int num = 1;
			WorldGen.SquareTileFrame(tileTargetX8, tileTargetY8, num != 0);
			int tileTargetX9 = Player.tileTargetX;
			int tileTargetY9 = Player.tileTargetY;
			throw new OutOfMemoryException();
		}

		// Token: 0x060024C5 RID: 9413 RVA: 0x0013A55C File Offset: 0x0013875C
		private bool PlaceThing_Tiles_BlockPlacementForAssortedThings(bool canPlace)
		{
			Microsoft.Xna.Framework.Vector2 position = this.inventory.position;
			int num = 5295;
			if (position == null)
			{
			}
			if (num == 0)
			{
			}
			int tileTargetX = Player.tileTargetX;
			int tileTargetY = Player.tileTargetY;
			Tile tile;
			ushort type = tile.type;
			if (num == 0)
			{
			}
			int tileTargetX2 = Player.tileTargetX;
			int tileTargetY2 = Player.tileTargetY;
			Tile tile2;
			ushort type2 = tile2.type;
			if (num == 0)
			{
			}
			int tileTargetX3 = Player.tileTargetX;
			int tileTargetY3 = Player.tileTargetY;
			Tile tile3;
			ushort type3 = tile3.type;
			if (num == 0)
			{
			}
			int tileTargetX4 = Player.tileTargetX;
			int tileTargetY4 = Player.tileTargetY;
			Tile tile4;
			bool flag = tile4.active();
			int tileTargetX5 = Player.tileTargetX;
			int tileTargetY5 = Player.tileTargetY;
			Tile tile5;
			ushort type4 = tile5.type;
			Tile tile6;
			ushort type5 = tile6.type;
			Tile tile7;
			ushort type6 = tile7.type;
			int tileTargetX6 = Player.tileTargetX;
			int tileTargetY6 = Player.tileTargetY;
			long num2 = 0L;
			long num3 = 0L;
			long num4 = 0L;
			WorldGen.KillTile(tileTargetX6, tileTargetY6, num2 != 0L, num3 != 0L, num4 != 0L);
			int tileTargetX7 = Player.tileTargetX;
			int tileTargetY7 = Player.tileTargetY;
			Tile tile8;
			bool flag2 = tile8.active();
			bool netClient = Main.NetClient;
			if (num == 0)
			{
			}
			int tileTargetX8 = Player.tileTargetX;
			int tileTargetY8 = Player.tileTargetY;
			Tile tile9;
			bool flag3 = tile9.nactive();
			if (num == 0)
			{
			}
			int tileTargetX9 = Player.tileTargetX;
			int tileTargetY9 = Player.tileTargetY;
			Tile tile10;
			ushort type7 = tile10.type;
			if (num == 0)
			{
			}
			int tileTargetX10 = Player.tileTargetX;
			int tileTargetY10 = Player.tileTargetY;
			Tile tile11;
			ushort type8 = tile11.type;
			if (num == 0)
			{
			}
			int tileTargetX11 = Player.tileTargetX;
			int tileTargetY11 = Player.tileTargetY;
			Tile tile12;
			bool flag4 = tile12.nactive();
			if (num == 0)
			{
			}
			int tileTargetX12 = Player.tileTargetX;
			int tileTargetY12 = Player.tileTargetY;
			Tile tile13;
			ushort type9 = tile13.type;
			if (!true)
			{
			}
			int tileTargetX13 = Player.tileTargetX;
			int tileTargetY13 = Player.tileTargetY;
			Tile tile14;
			bool flag5 = tile14.nactive();
			int tileTargetX14 = Player.tileTargetX;
			int tileTargetY14 = Player.tileTargetY;
			Tile tile15;
			ushort type10 = tile15.type;
			Tile tile16;
			ushort type11 = tile16.type;
			Tile tile17;
			short frameX = tile17.frameX;
			int num5 = 36409;
			int tileTargetX15 = Player.tileTargetX;
			int tileTargetY15 = Player.tileTargetY;
			if (num5 == 0)
			{
			}
			Tile tile18;
			bool flag6 = tile18.nactive();
			Tile tile19;
			ushort type12 = tile19.type;
			Tile tile20;
			ushort type13 = tile20.type;
			int num6 = 1;
			if (num6 == 0)
			{
			}
			int tileTargetX16 = Player.tileTargetX;
			int tileTargetY16 = Player.tileTargetY;
			Tile tile21;
			bool flag7 = tile21.active();
			if (num6 == 0)
			{
			}
			int tileTargetX17 = Player.tileTargetX;
			int tileTargetY17 = Player.tileTargetY;
			Tile tile22;
			ushort wall = tile22.wall;
			if (num6 == 0)
			{
			}
			int tileTargetX18 = Player.tileTargetX;
			int tileTargetY18 = Player.tileTargetY;
			Tile tile23;
			bool flag8 = tile23.active();
			if (num6 == 0)
			{
			}
			int tileTargetX19 = Player.tileTargetX;
			int tileTargetY19 = Player.tileTargetY;
			Tile tile24;
			ushort wall2 = tile24.wall;
			if (num6 == 0)
			{
			}
			int tileTargetX20 = Player.tileTargetX;
			int tileTargetY20 = Player.tileTargetY;
			Tile tile25;
			bool flag9 = tile25.active();
			if (num6 == 0)
			{
			}
			int tileTargetX21 = Player.tileTargetX;
			int tileTargetY21 = Player.tileTargetY;
			Tile tile26;
			ushort wall3 = tile26.wall;
			if (num6 == 0)
			{
			}
			int tileTargetX22 = Player.tileTargetX;
			int tileTargetY22 = Player.tileTargetY;
			Tile tile27;
			bool flag10 = tile27.active();
			if (num6 == 0)
			{
			}
			int tileTargetX23 = Player.tileTargetX;
			int tileTargetY23 = Player.tileTargetY;
			Tile tile28;
			ushort wall4 = tile28.wall;
			if (tileTargetX23 != 0)
			{
				int tileTargetX24 = Player.tileTargetX;
				int tileTargetY24 = Player.tileTargetY;
				long num7 = 0L;
				long num8 = 0L;
				long num9 = 0L;
				WorldGen.KillTile(tileTargetX24, tileTargetY24, num7 != 0L, num8 != 0L, num9 != 0L);
				int tileTargetX25 = Player.tileTargetX;
				int tileTargetY25 = Player.tileTargetY;
				if (!true)
				{
				}
				int tileTargetX26 = Player.tileTargetX;
				int tileTargetY26 = Player.tileTargetY;
				Tile tile29;
				return tile29.nactive();
			}
			Microsoft.Xna.Framework.Vector2 position2 = this.inventory.position;
			int tileTargetX27 = Player.tileTargetX;
			int tileTargetY27 = Player.tileTargetY;
			Tile tile30;
			bool flag11 = tile30.active();
			int tileTargetX28 = Player.tileTargetX;
			int tileTargetY28 = Player.tileTargetY;
			Tile tile31;
			ushort type14 = tile31.type;
			if (position2 == null)
			{
			}
			int tileTargetX29 = Player.tileTargetX;
			int tileTargetY29 = Player.tileTargetY;
			Tile tile32;
			ushort type15 = tile32.type;
			if (position2 == null)
			{
			}
			int tileTargetX30 = Player.tileTargetX;
			int tileTargetY30 = Player.tileTargetY;
			Tile tile33;
			ushort type16 = tile33.type;
			if (this.inventory.position == null)
			{
			}
			if (position2 == null)
			{
			}
			int tileTargetX31 = Player.tileTargetX;
			int tileTargetY31 = Player.tileTargetY;
			Tile tile34;
			ushort type17 = tile34.type;
			if (position2 == null)
			{
			}
			int tileTargetX32 = Player.tileTargetX;
			int tileTargetY32 = Player.tileTargetY;
			Tile tile35;
			ushort type18 = tile35.type;
			if (position2 == null)
			{
			}
			int tileTargetX33 = Player.tileTargetX;
			int tileTargetY33 = Player.tileTargetY;
			Tile tile36;
			ushort type19 = tile36.type;
			if (position2 == null)
			{
			}
			int tileTargetX34 = Player.tileTargetX;
			int tileTargetY34 = Player.tileTargetY;
			Tile tile37;
			ushort type20 = tile37.type;
			if (position2 == null)
			{
			}
			int tileTargetX35 = Player.tileTargetX;
			int tileTargetY35 = Player.tileTargetY;
			Tile tile38;
			ushort type21 = tile38.type;
			if (position2 == null)
			{
			}
			int tileTargetX36 = Player.tileTargetX;
			int tileTargetY36 = Player.tileTargetY;
			Tile tile39;
			ushort type22 = tile39.type;
			if (position2 == null)
			{
			}
			int tileTargetX37 = Player.tileTargetX;
			int tileTargetY37 = Player.tileTargetY;
			Tile tile40;
			ushort type23 = tile40.type;
			if (position2 == null)
			{
			}
			int tileTargetX38 = Player.tileTargetX;
			int tileTargetY38 = Player.tileTargetY;
			Tile tile41;
			ushort type24 = tile41.type;
			int tileTargetX39 = Player.tileTargetX;
			int tileTargetY39 = Player.tileTargetY;
			Tile tile42;
			ushort type25 = tile42.type;
			if (position2 == null)
			{
			}
			int tileTargetX40 = Player.tileTargetX;
			int tileTargetY40 = Player.tileTargetY;
			Tile tile43;
			ushort type26 = tile43.type;
			int tileTargetX41 = Player.tileTargetX;
			int tileTargetY41 = Player.tileTargetY;
			long num10 = 0L;
			Tile tile44;
			short frameX2 = tile44.frameX;
			return WorldGen.IsHarvestableHerbWithSeed(0, (int)num10);
		}

		// Token: 0x060024C6 RID: 9414 RVA: 0x0013B3F4 File Offset: 0x001395F4
		private static void PlaceThing_Tiles_BlockPlacementForRepeatedPumpkins(bool canPlace, TileObject data)
		{
			int type = data.type;
			if (type == 0)
			{
			}
			int tileTargetX = Player.tileTargetX;
			int tileTargetY = Player.tileTargetY;
			while (type != 0)
			{
			}
		}

		// Token: 0x060024C7 RID: 9415 RVA: 0x0013B41C File Offset: 0x0013961C
		private static void PlaceThing_Tiles_BlockPlacementForRepeatedCoralAndBeachPiles(bool canPlace, TileObject data)
		{
			if (data.type == 0)
			{
			}
			int tileTargetX = Player.tileTargetX;
			int tileTargetY = Player.tileTargetY;
			Tile tile;
			bool flag = tile.active();
		}

		// Token: 0x060024C8 RID: 9416 RVA: 0x0013B448 File Offset: 0x00139648
		private static void PlaceThing_Tiles_BlockPlacementForRepeatedPigronatas(bool canPlace, TileObject data)
		{
			if (data.type == 0)
			{
			}
			int tileTargetX = Player.tileTargetX;
			int tileTargetY = Player.tileTargetY;
			Tile tile;
			bool flag = tile.active();
		}

		// Token: 0x060024C9 RID: 9417 RVA: 0x0013B470 File Offset: 0x00139670
		private static void PlaceThing_Tiles_BlockPlacementIfOverPlayers(bool canPlace, TileObject data)
		{
			int type = data.type;
		}

		// Token: 0x060024CA RID: 9418 RVA: 0x0013B4A8 File Offset: 0x001396A8
		private bool PlaceThing_Tiles_CheckLavaBlocking()
		{
			if (!true)
			{
			}
			int tileTargetX = Player.tileTargetX;
			int tileTargetY = Player.tileTargetY;
			Tile tile;
			byte liquid = tile.liquid;
			int tileTargetX2 = Player.tileTargetX;
			int tileTargetY2 = Player.tileTargetY;
			Tile tile2;
			bool flag = tile2.lava();
			if (this.inventory.position == null)
			{
			}
			int tileTargetX3 = Player.tileTargetX;
			int tileTargetY3 = Player.tileTargetY;
			bool flag2;
			return flag2;
		}

		// Token: 0x060024CB RID: 9419 RVA: 0x0013B500 File Offset: 0x00139700
		private bool PlaceThing_Tiles_CheckRopeUsability(bool canUse)
		{
			/*
An exception occurred when decompiling this method (060024CB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::PlaceThing_Tiles_CheckRopeUsability(System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_009C:
	stloc:bool(var_22_A3, call:bool(Tile::lava, ldloc:Tile[exp:valuetype Terraria.Tile&](var_21)))
	stloc:bool(var_24_AC, callgetter:bool(Tile::get_IsLoaded, ldloc:Tile[exp:valuetype Terraria.Tile&](var_23)))
	stloc:int32(var_25_B3, callgetter:int32(Player::get_tileTargetY))
	stloc:bool(var_28_BF, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_27)))
	callsetter:int32(Player::set_tileTargetY, ldloc:int32(var_25_B3))
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

		// Token: 0x060024CC RID: 9420 RVA: 0x0013B5D4 File Offset: 0x001397D4
		private bool PlaceThing_Tiles_CheckFlexibleWand(bool canUse)
		{
			Item[] array = this.inventory;
			Microsoft.Xna.Framework.Vector2 position = array.position;
			FlexibleTileWand flexibleTileWand;
			if (flexibleTileWand != null)
			{
				if (array == null)
				{
				}
				int damage = array.damage;
				int healLife = array.healLife;
			}
			bool flag;
			return flag;
		}

		// Token: 0x060024CD RID: 9421 RVA: 0x0013B608 File Offset: 0x00139808
		private bool PlaceThing_Tiles_CheckWandUsability(bool canUse)
		{
			/*
An exception occurred when decompiling this method (060024CD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::PlaceThing_Tiles_CheckWandUsability(System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class Terraria.Item[](var_0_06, ldfld:class Terraria.Item[](Player::inventory, ldloc:Player(this)))
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

		// Token: 0x060024CE RID: 9422 RVA: 0x0013B620 File Offset: 0x00139820
		private bool PlaceThing_Tiles_CheckGamepadTorchUsability(bool canUse)
		{
			if (!true)
			{
			}
			bool usingGamepad = PlayerInput.UsingGamepad;
			Microsoft.Xna.Framework.Vector2 position = this.inventory.position;
			if (position == null)
			{
			}
			bool smartCursorIsUsed = Main.SmartCursorIsUsed;
			if (position == null)
			{
			}
			return Main.SmartCursorShowing;
		}

		// Token: 0x060024CF RID: 9423 RVA: 0x0013B664 File Offset: 0x00139864
		private void PlaceThing_LockChest()
		{
			if (!true)
			{
			}
			int tileTargetX = Player.tileTargetX;
			int tileTargetY = Player.tileTargetY;
			Item[] array = this.inventory;
			Microsoft.Xna.Framework.Vector2 position = array.position;
			Tile tile;
			bool flag = tile.active();
			if (array == null)
			{
			}
			Microsoft.Xna.Framework.Vector2 position2 = array.position;
			if (position2 != null)
			{
				float x = this.position.X;
				if (position2 == null)
				{
				}
				int tileRangeX = Player.tileRangeX;
				int num = this.blockRange;
				int tileTargetX2 = Player.tileTargetX;
				int num2 = 15744;
				float x2 = this.position.X;
				int width = this.width;
				if (num2 == 0)
				{
				}
				int tileRangeX2 = Player.tileRangeX;
				int num3 = this.blockRange;
				int tileTargetX3 = Player.tileTargetX;
				int num4 = 15744;
				float y = this.position.Y;
				if (num4 == 0)
				{
				}
				int tileRangeY = Player.tileRangeY;
				int num5 = this.blockRange;
				int tileTargetY2 = Player.tileTargetY;
				int num6 = 15744;
				float y2 = this.position.Y;
				int height = this.height;
				if (num6 == 0)
				{
				}
				int tileRangeY2 = Player.tileRangeY;
				int num7 = this.blockRange;
				int tileTargetY3 = Player.tileTargetY;
				if (this.itemTime == 0)
				{
					int num8 = this.itemAnimation;
					bool flag2 = this.controlUseItem;
					while (!flag2)
					{
					}
					if (!flag2)
					{
					}
					int tileTargetX4 = Player.tileTargetX;
					int tileTargetY4 = Player.tileTargetY;
					ushort type = Framing.GetTileSafely(tileTargetX4, tileTargetY4).type;
					return;
				}
			}
		}

		// Token: 0x060024D0 RID: 9424 RVA: 0x0013B83C File Offset: 0x00139A3C
		private void PlaceThing_ItemInExtractinator(Player.ItemCheckContext context)
		{
			for (;;)
			{
				if (!true)
				{
				}
				int tileTargetX = Player.tileTargetX;
				int tileTargetY = Player.tileTargetY;
				Item[] array = this.inventory;
				Microsoft.Xna.Framework.Vector2 position = array.position;
				Tile tile;
				bool flag = tile.active();
				float x = this.position.X;
				if (array == null)
				{
				}
				int tileRangeX = Player.tileRangeX;
				int num = this.blockRange;
				int tileTargetX2 = Player.tileTargetX;
				int num2 = 15744;
				float x2 = this.position.X;
				int width = this.width;
				if (num2 == 0)
				{
				}
				int tileRangeX2 = Player.tileRangeX;
				int num3 = this.blockRange;
				int tileTargetX3 = Player.tileTargetX;
				int num4 = 15744;
				float y = this.position.Y;
				if (num4 == 0)
				{
				}
				int tileRangeY = Player.tileRangeY;
				int num5 = this.blockRange;
				int tileTargetY2 = Player.tileTargetY;
				int num6 = 15744;
				float y2 = this.position.Y;
				int height = this.height;
				if (num6 == 0)
				{
				}
				int tileRangeY2 = Player.tileRangeY;
				int num7 = this.blockRange;
				int tileTargetY3 = Player.tileTargetY;
				if (this.itemTime != 0)
				{
					break;
				}
				int num8 = this.itemAnimation;
				if (this.controlUseItem)
				{
					goto Block_1;
				}
			}
			return;
			Block_1:
			ItemTrader itemTrader;
			int num10;
			if (itemTrader != null)
			{
				int num9 = 1;
				num10 = 32640;
				this.itemTime = num10;
				this.itemTimeMax = num10;
				context.SkipItemConsumption = num9 != 0;
				long num11 = 0L;
				long num12 = 0L;
				this.DropItemFromExtractinator((int)num11, (int)num12);
				return;
			}
			if (num10 == 0)
			{
			}
			int num13 = 32640;
			this.itemTime = num13;
			this.itemTimeMax = num13;
			if (num13 == 0)
			{
			}
			int num14 = 219;
			PlatformAwardNotifierUtility.NoteCraftingStationUsed(this, num14);
			if (num13 == 0)
			{
			}
		}

		// Token: 0x060024D1 RID: 9425 RVA: 0x0013B9C4 File Offset: 0x00139BC4
		private static ItemTrader TryGettingItemTraderFromBlock(Tile targetBlock)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x060024D2 RID: 9426 RVA: 0x0013B9D8 File Offset: 0x00139BD8
		private void PlaceThing_XMasTreeTops()
		{
			for (;;)
			{
				if (this.inventory.position == null)
				{
				}
				int tileTargetX = Player.tileTargetX;
				int tileTargetY = Player.tileTargetY;
				Tile tile;
				bool flag = tile.active();
				int tileTargetX2 = Player.tileTargetX;
				int tileTargetY2 = Player.tileTargetY;
				Tile tile2;
				ushort type = tile2.type;
				float x = this.position.X;
				int tileRangeX = Player.tileRangeX;
				Item[] array = this.inventory;
				int num = this.blockRange;
				Microsoft.Xna.Framework.Vector2 position = array.position;
				int tileTargetX3 = Player.tileTargetX;
				int num2 = 15744;
				float x2 = this.position.X;
				int width = this.width;
				if (num2 == 0)
				{
				}
				int tileRangeX2 = Player.tileRangeX;
				Item[] array2 = this.inventory;
				int num3 = this.blockRange;
				Microsoft.Xna.Framework.Vector2 position2 = array2.position;
				int tileTargetX4 = Player.tileTargetX;
				int num4 = 15744;
				float y = this.position.Y;
				if (num4 == 0)
				{
				}
				int tileRangeY = Player.tileRangeY;
				Item[] array3 = this.inventory;
				int num5 = this.blockRange;
				Microsoft.Xna.Framework.Vector2 position3 = array3.position;
				int tileTargetY3 = Player.tileTargetY;
				int num6 = 15744;
				float y2 = this.position.Y;
				int height = this.height;
				if (num6 == 0)
				{
				}
				int tileRangeY2 = Player.tileRangeY;
				Item[] array4 = this.inventory;
				int num7 = this.blockRange;
				Microsoft.Xna.Framework.Vector2 position4 = array4.position;
				int tileTargetY4 = Player.tileTargetY;
				if (this.itemTime != 0)
				{
					break;
				}
				int num8 = this.itemAnimation;
				if (this.controlUseItem)
				{
					goto Block_1;
				}
			}
			return;
			Block_1:
			if (this.inventory.position == null)
			{
			}
			int tileTargetX5 = Player.tileTargetX;
			int tileTargetY5 = Player.tileTargetY;
			int num9 = 3;
			int num10 = WorldGen.checkXmasTreeDrop(tileTargetX5, tileTargetY5, num9);
			Microsoft.Xna.Framework.Vector2 position5 = this.inventory.position;
			this.itemTime = position5;
			this.itemTimeMax = position5;
			if (position5 == null)
			{
			}
			int tileTargetX6 = Player.tileTargetX;
			int tileTargetY6 = Player.tileTargetY;
			int num11 = 3;
			WorldGen.dropXmasTree(tileTargetX6, tileTargetY6, num11);
			int tileTargetX7 = Player.tileTargetX;
			int tileTargetY7 = Player.tileTargetY;
		}

		// Token: 0x060024D3 RID: 9427 RVA: 0x0013BCF0 File Offset: 0x00139EF0
		private void PlaceThing_CannonBall()
		{
			Microsoft.Xna.Framework.Vector2 position = this.inventory.position;
			float x = this.position.X;
			if (position == null)
			{
			}
			int tileRangeX = Player.tileRangeX;
			Item[] array = this.inventory;
			int num = this.blockRange;
			Microsoft.Xna.Framework.Vector2 position2 = array.position;
			int tileTargetX = Player.tileTargetX;
			int num2 = 15744;
			float x2 = this.position.X;
			int width = this.width;
			if (num2 == 0)
			{
			}
			int tileRangeX2 = Player.tileRangeX;
			Item[] array2 = this.inventory;
			int num3 = this.blockRange;
			Microsoft.Xna.Framework.Vector2 position3 = array2.position;
			int tileTargetX2 = Player.tileTargetX;
			int num4 = 15744;
			float y = this.position.Y;
			if (num4 == 0)
			{
			}
			int tileRangeY = Player.tileRangeY;
			Item[] array3 = this.inventory;
			int num5 = this.blockRange;
			Microsoft.Xna.Framework.Vector2 position4 = array3.position;
			int tileTargetY = Player.tileTargetY;
			int num6 = 15744;
			float y2 = this.position.Y;
			int height = this.height;
			if (num6 == 0)
			{
			}
			int tileRangeY2 = Player.tileRangeY;
			Item[] array4 = this.inventory;
			int num7 = this.blockRange;
			Microsoft.Xna.Framework.Vector2 position5 = array4.position;
			int tileTargetY2 = Player.tileTargetY;
			if (15744 == 0)
			{
			}
			int tileTargetX3 = Player.tileTargetX;
			int tileTargetY3 = Player.tileTargetY;
			Tile tile;
			bool flag = tile.active();
			Tile tile2;
			ushort type = tile2.type;
			this.ShootFromCannon(tileTargetX3, tileTargetY3);
		}

		// Token: 0x060024D4 RID: 9428 RVA: 0x0013BE3C File Offset: 0x0013A03C
		private void PlaceThing_PaintScrapper()
		{
			if (!true)
			{
			}
			Microsoft.Xna.Framework.Vector2 position = this.inventory.position;
			if (position != null)
			{
				float x = this.position.X;
				if (position == null)
				{
				}
				int tileRangeX = Player.tileRangeX;
				Item[] array = this.inventory;
				int num = this.blockRange;
				Microsoft.Xna.Framework.Vector2 position2 = array.position;
				int tileTargetX = Player.tileTargetX;
				int num2 = 15744;
				float x2 = this.position.X;
				int width = this.width;
				if (num2 == 0)
				{
				}
				int tileRangeX2 = Player.tileRangeX;
				Item[] array2 = this.inventory;
				int num3 = this.blockRange;
				Microsoft.Xna.Framework.Vector2 position3 = array2.position;
				int tileTargetX2 = Player.tileTargetX;
				int num4 = 15744;
				float y = this.position.Y;
				if (num4 == 0)
				{
				}
				int tileRangeY = Player.tileRangeY;
				Item[] array3 = this.inventory;
				int num5 = this.blockRange;
				Microsoft.Xna.Framework.Vector2 position4 = array3.position;
				int tileTargetY = Player.tileTargetY;
				int num6 = 15744;
				float y2 = this.position.Y;
				int height = this.height;
				if (num6 == 0)
				{
				}
				int tileRangeY2 = Player.tileRangeY;
				Item[] array4 = this.inventory;
				int num7 = this.blockRange;
				Microsoft.Xna.Framework.Vector2 position5 = array4.position;
				int tileTargetY2 = Player.tileTargetY;
			}
		}

		// Token: 0x060024D5 RID: 9429 RVA: 0x0013BF8C File Offset: 0x0013A18C
		private void PlaceThing_PaintScrapper_LongMoss(int x, int y)
		{
			if (!true)
			{
			}
			Tile tile;
			ushort type = tile.type;
			int num = this.itemTime;
			int num2 = 1;
			this.cursorItemIconEnabled = num2 != 0;
			if (num != 0)
			{
				return;
			}
			int num3 = this.itemAnimation;
			bool flag = this.controlUseItem;
			while (!flag)
			{
			}
			if (!flag)
			{
			}
			Tile tile2;
			ushort type2 = tile2.type;
			Tile tile3;
			short frameX = tile3.frameX;
			if (num2 == 0)
			{
			}
			long num4 = 0L;
			long num5 = 0L;
			long num6 = 0L;
			WorldGen.KillTile(x, y, num4 != 0L, num5 != 0L, num6 != 0L);
			Tile tile4;
			bool flag2 = tile4.active();
			Microsoft.Xna.Framework.Vector2 position = this.inventory.position;
			this.itemTime = position;
			this.itemTimeMax = position;
			if (position == null)
			{
			}
			bool netClient = Main.NetClient;
			if (position == null)
			{
			}
			if (position == null)
			{
			}
			int num7;
			while (num7 != 0)
			{
			}
		}

		// Token: 0x060024D6 RID: 9430 RVA: 0x0013C064 File Offset: 0x0013A264
		private void PlaceThing_PaintScrapper_TryScrapping(int x, int y)
		{
			if (!true)
			{
			}
			Tile tile;
			ushort wall = tile.wall;
		}

		// Token: 0x060024D7 RID: 9431 RVA: 0x0013C14C File Offset: 0x0013A34C
		private void PlaceThing_PaintRoller()
		{
			Microsoft.Xna.Framework.Vector2 position = this.inventory.position;
			float x = this.position.X;
			if (position == null)
			{
			}
			int tileRangeX = Player.tileRangeX;
			Item[] array = this.inventory;
			int num = this.blockRange;
			Microsoft.Xna.Framework.Vector2 position2 = array.position;
			int tileTargetX = Player.tileTargetX;
			int num2 = 15744;
			float x2 = this.position.X;
			int width = this.width;
			if (num2 == 0)
			{
			}
			int tileRangeX2 = Player.tileRangeX;
			Item[] array2 = this.inventory;
			int num3 = this.blockRange;
			Microsoft.Xna.Framework.Vector2 position3 = array2.position;
			int tileTargetX2 = Player.tileTargetX;
			int num4 = 15744;
			float y = this.position.Y;
			if (num4 == 0)
			{
			}
			int tileRangeY = Player.tileRangeY;
			Item[] array3 = this.inventory;
			int num5 = this.blockRange;
			Microsoft.Xna.Framework.Vector2 position4 = array3.position;
			int tileTargetY = Player.tileTargetY;
			int num6 = 15744;
			float y2 = this.position.Y;
			int height = this.height;
			if (num6 == 0)
			{
			}
			int tileRangeY2 = Player.tileRangeY;
			Item[] array4 = this.inventory;
			int num7 = this.blockRange;
			Microsoft.Xna.Framework.Vector2 position5 = array4.position;
			int tileTargetY2 = Player.tileTargetY;
			if (15744 == 0)
			{
			}
			int tileTargetX3 = Player.tileTargetX;
			int tileTargetY3 = Player.tileTargetY;
			Tile tile;
			ushort wall = tile.wall;
			int num8 = this.itemTime;
			int num9 = 1;
			this.cursorItemIconEnabled = num9 != 0;
			if (num8 == 0)
			{
				int num10 = this.itemAnimation;
				if (this.controlUseItem)
				{
					int num11 = 1;
					int num12 = 1;
					this.TryPainting(tileTargetX3, tileTargetY3, num11 != 0, num12 != 0);
				}
			}
		}

		// Token: 0x060024D8 RID: 9432 RVA: 0x0013C2C0 File Offset: 0x0013A4C0
		private void PlaceThing_Paintbrush()
		{
			Microsoft.Xna.Framework.Vector2 position = this.inventory.position;
			float x = this.position.X;
			if (position == null)
			{
			}
			int tileRangeX = Player.tileRangeX;
			Item[] array = this.inventory;
			int num = this.blockRange;
			Microsoft.Xna.Framework.Vector2 position2 = array.position;
			int tileTargetX = Player.tileTargetX;
			int num2 = 15744;
			float x2 = this.position.X;
			int width = this.width;
			if (num2 == 0)
			{
			}
			int tileRangeX2 = Player.tileRangeX;
			Item[] array2 = this.inventory;
			int num3 = this.blockRange;
			Microsoft.Xna.Framework.Vector2 position3 = array2.position;
			int tileTargetX2 = Player.tileTargetX;
			int num4 = 15744;
			float y = this.position.Y;
			if (num4 == 0)
			{
			}
			int tileRangeY = Player.tileRangeY;
			Item[] array3 = this.inventory;
			int num5 = this.blockRange;
			Microsoft.Xna.Framework.Vector2 position4 = array3.position;
			int tileTargetY = Player.tileTargetY;
			int num6 = 15744;
			float y2 = this.position.Y;
			int height = this.height;
			if (num6 == 0)
			{
			}
			int tileRangeY2 = Player.tileRangeY;
			Item[] array4 = this.inventory;
			int num7 = this.blockRange;
			Microsoft.Xna.Framework.Vector2 position5 = array4.position;
			int tileTargetY2 = Player.tileTargetY;
			if (15744 == 0)
			{
			}
			int tileTargetX3 = Player.tileTargetX;
			int tileTargetY3 = Player.tileTargetY;
			Tile tile;
			bool flag = tile.active();
			int num8 = this.itemTime;
			int num9 = 1;
			this.cursorItemIconEnabled = num9 != 0;
			if (num8 == 0)
			{
				int num10 = this.itemAnimation;
				if (this.controlUseItem)
				{
					int num11 = 1;
					long num12 = 0L;
					this.TryPainting(tileTargetX3, tileTargetY3, num12 != 0L, num11 != 0);
				}
			}
		}

		// Token: 0x060024D9 RID: 9433 RVA: 0x0013C434 File Offset: 0x0013A634
		public Item FindPaintOrCoating()
		{
			/*
An exception occurred when decompiling this method (060024D9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Item Terraria.Player::FindPaintOrCoating()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class Terraria.Item[](var_1_09, ldfld:class Terraria.Item[](Player::inventory, ldloc:Player(this)))
	stloc:Vector2(var_4_17, ldfld:Vector2(Entity::position, ldfld:class Terraria.Item[][exp:Entity](Player::inventory, ldloc:Player(this))))
	stloc:Vector2(var_7_27, ldfld:Vector2(Entity::position, ldfld:class Terraria.Item[][exp:Entity](Player::inventory, ldloc:Player(this))))
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

		// Token: 0x060024DA RID: 9434 RVA: 0x0013C46C File Offset: 0x0013A66C
		private void TryPainting(int x, int y, bool paintingAWall = false, bool applyItemAnimation = true)
		{
			Item item = this.FindPaintOrCoating();
			if (item != null)
			{
				if (item.paintCoating != 0)
				{
					this.ApplyCoating(x, y, paintingAWall, applyItemAnimation, item);
				}
				if (item.paint != 0)
				{
					this.ApplyPaint(x, y, paintingAWall, applyItemAnimation, item);
					return;
				}
			}
		}

		// Token: 0x060024DB RID: 9435 RVA: 0x0013C4AC File Offset: 0x0013A6AC
		private void ApplyCoating(int x, int y, bool paintingAWall, bool applyItemAnimation, Item targetItem)
		{
			int num = 1;
			byte paintCoating = targetItem.paintCoating;
			if (num == 0)
			{
			}
			int num2 = 1;
			bool flag = WorldGen.paintCoatWall(x, y, paintCoating, num2 != 0);
			int stack = targetItem.stack;
			targetItem.stack = stack;
		}

		// Token: 0x060024DC RID: 9436 RVA: 0x0013C55C File Offset: 0x0013A75C
		private void ApplyPaint(int x, int y, bool paintingAWall, bool applyItemAnimation, Item targetItem)
		{
			int num = 1;
			byte paint = targetItem.paint;
			if (num == 0)
			{
			}
			Tile tile;
			byte b = tile.wallColor();
			if (num == 0)
			{
			}
			int num2 = 1;
			bool flag = WorldGen.paintWall(x, y, paint, num2 != 0);
			int stack = targetItem.stack;
			targetItem.stack = stack;
			long num3 = 0L;
			targetItem.SetDefaults((int)num3);
			Item[] array = this.inventory;
			float num4 = this.wallSpeed;
		}

		// Token: 0x060024DD RID: 9437 RVA: 0x0013C620 File Offset: 0x0013A820
		private void ShootFromCannon(int x, int y)
		{
			if (!true)
			{
			}
			Tile tile;
			short frameX = tile.frameX;
			Microsoft.Xna.Framework.Vector2 position = this.inventory.position;
		}

		// Token: 0x060024DE RID: 9438 RVA: 0x0013C6CC File Offset: 0x0013A8CC
		private void ExtractinatorUse(int extractType, int extractinatorBlockType)
		{
			if (!true)
			{
			}
			int num;
			if (num != 0)
			{
				return;
			}
			int num2;
			if (num2 == 0)
			{
			}
			int num3;
			if (num3 != 0)
			{
				return;
			}
			int num4;
			if (num4 == 0)
			{
			}
			int num5;
			if (num5 == 0)
			{
			}
		}

		// Token: 0x060024DF RID: 9439 RVA: 0x0013CAA4 File Offset: 0x0013ACA4
		private void DropItemFromExtractinator(int itemType, int stack)
		{
			if (!true)
			{
			}
			Microsoft.Xna.Framework.Vector2 mouseScreen = Main.MouseScreen;
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			if (!true)
			{
			}
			bool smartCursorIsUsed = Main.SmartCursorIsUsed;
			bool usingGamepad = PlayerInput.UsingGamepad;
			Microsoft.Xna.Framework.Vector2 center = base.Center;
			int tileTargetX = Player.tileTargetX;
			int tileTargetY = Player.tileTargetY;
			IEntitySource itemSource_TileInteraction = this.GetItemSource_TileInteraction(tileTargetX, tileTargetY);
			if (32640 == 0)
			{
			}
			bool netClientOnly = Main.NetClientOnly;
		}

		// Token: 0x060024E0 RID: 9440 RVA: 0x0013CB18 File Offset: 0x0013AD18
		public void ChangeDir(int dir)
		{
			if (this.pulley)
			{
				byte b = this.pulleyDir;
				int direction = this.direction;
				int width = this.width;
				float x = this.position.X;
				float y = this.position.Y;
				int width2 = this.width;
				bool wet = this.wet;
				if (width == 0)
				{
				}
				int whoAmI = this.whoAmI;
				if (width == 0)
				{
				}
				int myPlayer = Main.myPlayer;
				if (width == 0)
				{
				}
				float x2 = this.position.X;
				int num = 1;
				this.pulleyDir = (byte)num;
			}
			this.direction = dir;
		}

		// Token: 0x060024E1 RID: 9441 RVA: 0x0013CBB0 File Offset: 0x0013ADB0
		public Rectangle getRect()
		{
			/*
An exception occurred when decompiling this method (060024E1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Rectangle Terraria.Player::getRect()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_0B, ldfld:float32(Vector2::X, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](Entity::position, ldloc:Player[exp:Entity](this))))
	stloc:float32(var_1_17, ldfld:float32(Vector2::Y, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](Entity::position, ldloc:Player[exp:Entity](this))))
	stloc:int32(var_2_1E, ldfld:int32(Entity::width, ldloc:Player[exp:Entity](this)))
	stloc:bool(var_3_25, ldfld:bool(Entity::wet, ldloc:Player[exp:Entity](this)))
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

		// Token: 0x060024E2 RID: 9442 RVA: 0x0013CBE4 File Offset: 0x0013ADE4
		public void HorsemansBlade_SpawnPumpkin(int npcIndex, int dmg, float kb)
		{
			if (!true)
			{
			}
			float x = this.position.X;
			float y = this.position.Y;
			if (32640 == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 position = this.inventory.position;
			int whoAmI = this.whoAmI;
		}

		// Token: 0x060024E3 RID: 9443 RVA: 0x0013CC44 File Offset: 0x0013AE44
		public void PutItemInInventoryFromItemUsage(int type, int theSelectedItem = -1)
		{
			Item[] array = this.inventory;
			Microsoft.Xna.Framework.Vector2 position = array.position;
			if (array != null)
			{
				int whoAmI = this.whoAmI;
				if (array == null)
				{
				}
				bool summon = array.summon;
				int noGrabDelay = array.noGrabDelay;
				Item item;
				int stack = item.stack;
				Item[] array2 = this.inventory;
				Microsoft.Xna.Framework.Vector2 position2 = array2.position;
				float x = this.position.X;
				float y = this.position.Y;
				int width = this.width;
				bool wet = this.wet;
				if (array2 == null)
				{
				}
				if (32640 == 0)
				{
				}
				bool netClientOnly = Main.NetClientOnly;
				return;
			}
		}

		// Token: 0x060024E4 RID: 9444 RVA: 0x0013CCF4 File Offset: 0x0013AEF4
		public bool SummonItemCheck(Item item)
		{
			int num = 1;
			int type = item.type;
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x060024E5 RID: 9445 RVA: 0x0013CD2C File Offset: 0x0013AF2C
		public PlayerFishingConditions GetFishingConditions()
		{
			/*
An exception occurred when decompiling this method (060024E5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.DataStructures.PlayerFishingConditions Terraria.Player::GetFishingConditions()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0039:
	stloc:float32(var_13_3E, call:float32(Player::Fishing_GetPowerMultiplier))
	stloc:int32(var_14_45, ldc.i4:int32(32640))
	stfld:float32(PlayerFishingConditions::LevelMultipliers, ldloc:PlayerFishingConditions[exp:valuetype Terraria.DataStructures.PlayerFishingConditions&](var_0), ldloc:int32[exp:float32](var_14_45))
	stfld:int32(PlayerFishingConditions::PolePower, ldloc:PlayerFishingConditions[exp:valuetype Terraria.DataStructures.PlayerFishingConditions&](var_0), ldloc:float32[exp:int32](var_13_3E))
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

		// Token: 0x060024E6 RID: 9446 RVA: 0x000021DB File Offset: 0x000003DB
		private static float Fishing_GetPowerMultiplier()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060024E7 RID: 9447 RVA: 0x0013CD90 File Offset: 0x0013AF90
		private void Fishing_GetBait([Out] int baitPower, [Out] int baitType)
		{
			Item[] array = this.inventory;
		}

		// Token: 0x060024E8 RID: 9448 RVA: 0x0013CDC0 File Offset: 0x0013AFC0
		private void Fishing_GetBestFishingPole([Out] int fishingPolePower, [Out] int fishingPoleType)
		{
			Item[] array = this.inventory;
			long num = 0L;
			fishingPoleType.m_value = (int)num;
		}

		// Token: 0x060024E9 RID: 9449 RVA: 0x0013CDE4 File Offset: 0x0013AFE4
		public bool HasUnityPotion()
		{
			/*
An exception occurred when decompiling this method (060024E9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::HasUnityPotion()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class Terraria.Item[](var_0_06, ldfld:class Terraria.Item[](Player::inventory, ldloc:Player(this)))
	stloc:Chest(var_4_19, ldfld:Chest(Player::bank4, ldloc:Player(this)))
	stloc:class Terraria.Item[](var_6_26, ldfld:class Terraria.Item[](Chest::item, ldloc:Chest(var_4_19)))
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

		// Token: 0x060024EA RID: 9450 RVA: 0x0013CE20 File Offset: 0x0013B020
		public void TakeUnityPotion()
		{
			Item[] array = this.inventory;
		}

		// Token: 0x060024EB RID: 9451 RVA: 0x0013CE4C File Offset: 0x0013B04C
		public void UnityTeleport(Microsoft.Xna.Framework.Vector2 telePos)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool logicHost = Main.LogicHost;
			if (num == 0)
			{
			}
			bool netHost = Main.NetHost;
			int whoAmI = this.whoAmI;
			int whoAmI2 = this.whoAmI;
			Microsoft.Xna.Framework.Vector2 vector;
			float num2 = vector.Length();
			float num3 = vector.Length();
			if ((this == null || this != null) && (this == null || this != null))
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060024EC RID: 9452 RVA: 0x0013CED0 File Offset: 0x0013B0D0
		private void PayDD2CrystalsBeforeUse(Item item)
		{
			int type = item.type;
			int num = 3822;
			int num2 = 1;
			long num3 = 0L;
			bool flag = this.ConsumeItem(num, num2 != 0, num3 != 0L);
		}

		// Token: 0x060024ED RID: 9453 RVA: 0x0013CEFC File Offset: 0x0013B0FC
		private bool CheckDD2CrystalPaymentLock(Item item)
		{
			/*
An exception occurred when decompiling this method (060024ED)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::CheckDD2CrystalPaymentLock(Terraria.Item)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000F:
	stloc:class Terraria.Item[](var_4_19, ldfld:class Terraria.Item[](Player::inventory, ldloc:Player(this)))
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

		// Token: 0x060024EE RID: 9454 RVA: 0x0013CF2C File Offset: 0x0013B12C
		private int GetRequiredDD2CrystalsToUse(Item item)
		{
			/*
An exception occurred when decompiling this method (060024EE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.Player::GetRequiredDD2CrystalsToUse(Terraria.Item)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Item::type, ldloc:Item(item)))
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

		// Token: 0x060024EF RID: 9455 RVA: 0x0013CF44 File Offset: 0x0013B144
		public void SporeSac(Item sourceItem)
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
				if (num != 0)
				{
					if (num == 0)
					{
					}
					int whoAmI = this.whoAmI;
					if (num == 0)
					{
					}
					if (num == 0)
					{
					}
				}
				return;
			}
		}

		// Token: 0x060024F0 RID: 9456 RVA: 0x0013D058 File Offset: 0x0013B258
		public void VolatileGelatin(Item sourceItem)
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
			int whoAmI = this.whoAmI;
			int num = this.volatileGelatinCounter;
			this.volatileGelatinCounter = num;
			int num2 = 17440;
			long num3 = 0L;
			if (num2 == 0)
			{
			}
			if (num2 != 0)
			{
				if (num2 == 0)
				{
				}
				bool flag = Collision.CanHit(this, this);
				Microsoft.Xna.Framework.Vector2 center = base.Center;
				if (num2 == 0)
				{
				}
			}
			if (num3 != 0L)
			{
				Microsoft.Xna.Framework.Vector2 center2 = base.Center;
				if (num2 == 0)
				{
				}
				if (!true)
				{
				}
				IEntitySource projectileSource_Accessory = this.GetProjectileSource_Accessory(sourceItem);
				Microsoft.Xna.Framework.Vector2 center3 = base.Center;
				Microsoft.Xna.Framework.Vector2 center4 = base.Center;
				int whoAmI2 = this.whoAmI;
				return;
			}
		}

		// Token: 0x060024F1 RID: 9457 RVA: 0x0013D0F8 File Offset: 0x0013B2F8
		public bool CanHit(Entity ent)
		{
			int num = 1;
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
			Microsoft.Xna.Framework.Vector2 center = base.Center;
			int direction = this.direction;
			int height = this.height;
			int height2 = this.height;
			float num2 = this.gravDir;
			if (direction == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 center2 = ent.Center;
			if (ent.height == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 center3 = base.Center;
			int direction2 = this.direction;
			int height3 = this.height;
			int height4 = this.height;
			float num3 = this.gravDir;
			if (direction2 == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 center4 = ent.Center;
			if (direction2 == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 center5 = base.Center;
			int direction3 = this.direction;
			int height5 = this.height;
			if (direction3 == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 center6 = ent.Center;
			if (direction3 == 0)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060024F2 RID: 9458 RVA: 0x0013D218 File Offset: 0x0013B418
		public Rectangle GetItemDrawFrame(int type)
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
			int value = num2.m_value;
			Rectangle rectangle;
			return rectangle;
		}

		// Token: 0x060024F3 RID: 9459 RVA: 0x0013D254 File Offset: 0x0013B454
		public float GetAdjustedItemScale(Item item)
		{
			/*
An exception occurred when decompiling this method (060024F3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Player::GetAdjustedItemScale(Terraria.Item)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	brtrue(IL_0000, logicnot:bool(ldfld:bool(Player::meleeScaleGlove, ldloc:Player(this))))
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

		// Token: 0x060024F4 RID: 9460 RVA: 0x0013D27C File Offset: 0x0013B47C
		public void ApplyMeleeScale(float scale)
		{
			if (this.meleeScaleGlove)
			{
			}
		}

		// Token: 0x060024F5 RID: 9461 RVA: 0x0013D294 File Offset: 0x0013B494
		public Microsoft.Xna.Framework.Vector2 ApplyRangeCompensation(float rangeCompensation, Microsoft.Xna.Framework.Vector2 startPos, Microsoft.Xna.Framework.Vector2 targetPos)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			Microsoft.Xna.Framework.Vector2 vector;
			float num = vector.Length();
			return 17455;
		}

		// Token: 0x060024F6 RID: 9462 RVA: 0x000021DB File Offset: 0x000003DB
		public void ItemCheck()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060024F7 RID: 9463 RVA: 0x000021DB File Offset: 0x000003DB
		private void UpdatePlacementPreview(Item sItem)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060024F8 RID: 9464 RVA: 0x0013D2BC File Offset: 0x0013B4BC
		private void FigureOutWhatToPlace(Tile targetTile, Item sItem, [Out] int tileToCreate, [Out] int previewPlaceStyle, [Out] bool? overrideCanPlace, [Out] int? forcedRandom)
		{
			int createTile = sItem.createTile;
			tileToCreate.m_value = createTile;
			int placeStyle = sItem.placeStyle;
			previewPlaceStyle.m_value = placeStyle;
			if (this.unlockedBiomeTorches && this.builderAccStatus == null)
			{
				long num = 0L;
				int num2 = this.BiomeCampfirePlaceStyle((int)num);
				previewPlaceStyle.m_value = num2;
			}
		}

		// Token: 0x060024F9 RID: 9465 RVA: 0x0013D324 File Offset: 0x0013B524
		private void ItemCheck_OwnerOnlyCode(Player.ItemCheckContext context, Item sItem, int weaponDamage, Rectangle heldItemFrame)
		{
			int type = sItem.type;
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x060024FA RID: 9466 RVA: 0x0013D820 File Offset: 0x0013BA20
		public Microsoft.Xna.Framework.Vector2? MouthPosition
		{
			get
			{
				Mount mount = this.mount;
				if (mount._active)
				{
					Mount.MountDelegatesData.OverridePositionMethod mouthPosition = mount.Delegations.MouthPosition;
					if (mouthPosition != null)
					{
						IntPtr invoke_impl = mouthPosition.invoke_impl;
						IntPtr method_code = mouthPosition.method_code;
						IntPtr method = mouthPosition.method;
					}
				}
				int direction = this.direction;
				float num = this.gravDir;
				Microsoft.Xna.Framework.Vector2 mountedCenter = this.MountedCenter;
				float num2 = this.fullRotation;
				if (direction == 0)
				{
				}
				if (direction == 0)
				{
					return;
				}
			}
		}

		// Token: 0x060024FB RID: 9467 RVA: 0x0013D890 File Offset: 0x0013BA90
		private void ItemCheck_EmitFoodParticles(Item sItem)
		{
			int num = this.itemAnimation;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				if (num == 0)
				{
				}
				int num2;
				if (num2 != 0)
				{
					Microsoft.Xna.Framework.Vector2? mouthPosition = this.MouthPosition;
					float num3 = this.gravDir;
					int direction = this.direction;
				}
			}
		}

		// Token: 0x060024FC RID: 9468 RVA: 0x0013D8DC File Offset: 0x0013BADC
		private void ItemCheck_EmitDrinkParticles(Item sItem)
		{
			int num = this.itemAnimation;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				Microsoft.Xna.Framework.Vector2? mouthPosition = this.MouthPosition;
				int direction = this.direction;
				float num2 = this.gravDir;
			}
		}

		// Token: 0x060024FD RID: 9469 RVA: 0x0013D91C File Offset: 0x0013BB1C
		private void ItemCheck_UseBossSpawners(int onWhichPlayer, Item sItem)
		{
			if (this.itemTime != 0)
			{
				return;
			}
			int num = this.itemAnimation;
			int type = sItem.type;
			int type2 = sItem.type;
			int useTime = sItem.useTime;
			float x = this.position.X;
			float y = this.position.Y;
			this.itemTime = useTime;
			this.itemTimeMax = useTime;
			if (useTime == 0)
			{
			}
			if (useTime != 0)
			{
				int whoAmI = this.whoAmI;
				if (useTime == 0)
				{
				}
				return;
			}
			int num2;
			if (num2 == 0)
			{
			}
		}

		// Token: 0x060024FE RID: 9470 RVA: 0x0013DD6C File Offset: 0x0013BF6C
		private void ItemCheck_UseEventItems(Item sItem)
		{
			if (this.itemTime == 0)
			{
				int num = this.itemAnimation;
				if (sItem.type == 0)
				{
				}
				bool flag = Main.CanStartInvasion(1, 16777216 != 0);
				int useTime = sItem.useTime;
				float x = this.position.X;
				float y = this.position.Y;
				this.itemTime = useTime;
				this.itemTimeMax = useTime;
				if (useTime == 0)
				{
				}
				if (32640 != 0)
				{
					int whoAmI = this.whoAmI;
					if (useTime == 0)
					{
					}
					return;
				}
				if (32640 == 0)
				{
				}
				if (32640 == 0)
				{
					if (32640 == 0)
					{
					}
					Main.StartInvasion(1);
				}
				if (this.itemTime == 0)
				{
					int num2 = this.itemAnimation;
					if (sItem.type == 0)
					{
					}
					bool flag2 = Main.CanStartInvasion(2, 16777216 != 0);
					int useTime2 = sItem.useTime;
					float x2 = this.position.X;
					float y2 = this.position.Y;
					this.itemTime = useTime2;
					this.itemTimeMax = useTime2;
					if (useTime2 == 0)
					{
					}
					if (32640 != 0)
					{
						int whoAmI2 = this.whoAmI;
						if (useTime2 == 0)
						{
						}
						return;
					}
					if (32640 == 0)
					{
					}
					if (32640 == 0)
					{
						if (32640 == 0)
						{
						}
						Main.StartInvasion(2);
					}
					if (this.itemTime == 0)
					{
						int num3 = this.itemAnimation;
						if (sItem.type == 0)
						{
						}
						bool flag3 = Main.CanStartInvasion(3, 16777216 != 0);
						int useTime3 = sItem.useTime;
						float x3 = this.position.X;
						float y3 = this.position.Y;
						this.itemTime = useTime3;
						this.itemTimeMax = useTime3;
						if (useTime3 == 0)
						{
						}
						if (32640 != 0)
						{
							int whoAmI3 = this.whoAmI;
							if (useTime3 == 0)
							{
							}
							return;
						}
						if (32640 == 0)
						{
						}
						if (32640 == 0)
						{
							if (32640 == 0)
							{
							}
							Main.StartInvasion(3);
						}
						if (this.itemTime == 0)
						{
							int num4 = this.itemAnimation;
							if (sItem.type == 0)
							{
							}
							if (32640 == 0)
							{
								if (32640 == 0)
								{
								}
								if (32640 == 0)
								{
									if (32640 == 0)
									{
									}
									int useTime4 = sItem.useTime;
									float x4 = this.position.X;
									float y4 = this.position.Y;
									this.itemTime = useTime4;
									this.itemTimeMax = useTime4;
									if (useTime4 == 0)
									{
									}
									if (useTime4 != 0)
									{
										int whoAmI4 = this.whoAmI;
										if (useTime4 == 0)
										{
										}
										return;
									}
									if (32640 == 0)
									{
									}
									if (32640 == 0)
									{
									}
									Main.startPumpkinMoon();
								}
							}
							if (this.itemTime == 0)
							{
								int num5 = this.itemAnimation;
								if (sItem.type == 0)
								{
								}
								if (32640 != 0)
								{
									if (32640 == 0)
									{
									}
									float x5 = this.position.X;
									float y5 = this.position.Y;
									int useTime5 = sItem.useTime;
									this.itemTime = useTime5;
									this.itemTimeMax = useTime5;
									if (useTime5 == 0)
									{
									}
									int whoAmI5;
									if (32768 != 0)
									{
										whoAmI5 = this.whoAmI;
										if (useTime5 == 0)
										{
										}
										return;
									}
									if (32768 == 0)
									{
									}
									if (!true)
									{
									}
									if (whoAmI5 != 0)
									{
										return;
									}
									if (!true)
									{
									}
								}
								if (this.itemTime == 0)
								{
									int num6 = this.itemAnimation;
									if (sItem.type == 0)
									{
									}
									if (4271 == 0)
									{
										if (4271 == 0)
										{
										}
										float x6 = this.position.X;
										float y6 = this.position.Y;
										int useTime6 = sItem.useTime;
										this.itemTime = useTime6;
										this.itemTimeMax = useTime6;
										if (useTime6 == 0)
										{
										}
										if (useTime6 != 0)
										{
											int whoAmI6 = this.whoAmI;
											if (useTime6 == 0)
											{
											}
											return;
										}
										AchievementsHelper.NotifyProgressionEvent(4);
										if (useTime6 == 0)
										{
										}
										if (32768 == 0)
										{
										}
										if (5 == 0)
										{
										}
										if (5 == 0)
										{
										}
									}
									if (this.itemTime == 0)
									{
										int num7 = this.itemAnimation;
										int type = sItem.type;
										if (type == 0)
										{
										}
										if (type != 0)
										{
											if (type == 0)
											{
											}
											if (type != 0)
											{
												if (type == 0)
												{
												}
												long num8 = 0L;
												long num9 = 0L;
												bool flag4 = NPC.AnyDanger(num8 != 0L, num9 != 0L);
												if (type == 0)
												{
												}
												bool flag5 = NPC.AnyoneNearCultists();
												float x7 = this.position.X;
												float y7 = this.position.Y;
												int useTime7 = sItem.useTime;
												this.itemTime = useTime7;
												this.itemTimeMax = useTime7;
												if (useTime7 == 0)
												{
												}
												if (useTime7 != 0)
												{
													int whoAmI7 = this.whoAmI;
													if (useTime7 == 0)
													{
													}
													return;
												}
												WorldGen.StartImpendingDoom(720);
											}
										}
										if (this.itemTime == 0)
										{
											int num10 = this.itemAnimation;
											if (sItem.type == 0)
											{
											}
											while (32768 != 0)
											{
											}
											if (32768 == 0)
											{
											}
											while (32768 != 0)
											{
											}
											if (32768 == 0)
											{
											}
											int useTime8 = sItem.useTime;
											float x8 = this.position.X;
											float y8 = this.position.Y;
											this.itemTime = useTime8;
											this.itemTimeMax = useTime8;
											if (useTime8 == 0)
											{
											}
											if (useTime8 != 0)
											{
												int whoAmI8 = this.whoAmI;
												if (useTime8 == 0)
												{
												}
												return;
											}
											if (32640 == 0)
											{
											}
											if (32640 == 0)
											{
											}
											Main.startSnowMoon();
											return;
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060024FF RID: 9471 RVA: 0x0013E1F4 File Offset: 0x0013C3F4
		private void ItemCheck_ReleaseCritter(Item sItem)
		{
			short makeNPC = sItem.makeNPC;
			int useTime = sItem.useTime;
			this.itemTime = useTime;
			this.itemTimeMax = useTime;
			Microsoft.Xna.Framework.Vector2 center = base.Center;
			Microsoft.Xna.Framework.Vector2 bottom = base.Bottom;
			int placeStyle = sItem.placeStyle;
			int whoAmI = this.whoAmI;
			if (useTime == 0)
			{
			}
		}

		// Token: 0x06002500 RID: 9472 RVA: 0x0013E340 File Offset: 0x0013C540
		private void ItemCheck_MeleeHitPVP(Item sItem, Rectangle itemRectangle, int damage, float knockBack)
		{
			if (this.hostile)
			{
				int num = 32768;
				long num2 = 0L;
				int whoAmI = this.whoAmI;
				if (whoAmI != 0 && whoAmI != 0 && whoAmI == 0)
				{
					int num3 = this.team;
					if (num3 != 0)
					{
					}
					Rectangle rectangle;
					bool flag = rectangle.Intersects(rectangle);
					if (num3 == 0)
					{
					}
					float num4 = this.luck;
					if (num == 0)
					{
					}
					int num5 = Main.DamageVar(knockBack, -2f);
					int type = sItem.type;
					this.StatusToPlayerPvP(type, (int)num2);
					Microsoft.Xna.Framework.Vector2 center = base.Center;
					PlayerDeathReason playerDeathReason = PlayerDeathReason.ByPlayer(this.whoAmI);
					int direction = this.direction;
					Microsoft.Xna.Framework.Vector2 position = this.inventory.position;
					int direction2 = this.direction;
					if (position == null)
					{
					}
					if (num == 0)
					{
					}
					if (num == 0)
					{
					}
					int type2 = sItem.type;
					int num6;
					if (type2 != 0)
					{
						num6 = 52992;
					}
					int type3 = sItem.type;
					if (type3 == 0)
					{
					}
					if (type3 != 0)
					{
						if (type3 == 0)
						{
						}
					}
					if (num6 == 0)
					{
					}
					if (num6 == 0)
					{
					}
					if (16256 == 0)
					{
					}
					bool netClientOnly = Main.NetClientOnly;
				}
			}
		}

		// Token: 0x06002501 RID: 9473 RVA: 0x0013E478 File Offset: 0x0013C678
		private void Volcano_TrySpawningVolcano(NPC npc, Item sItem, float damage, float knockBack, Rectangle itemRectangle)
		{
			if (this._spawnVolcanoExplosion)
			{
				int myPlayer = Main.myPlayer;
				int whoAmI = this.whoAmI;
				if (npc != null)
				{
					bool flag = npc.HittableForOnHitRewards();
				}
				Microsoft.Xna.Framework.Vector2 center = npc.Center;
				IEntitySource projectileSource_Item = this.GetProjectileSource_Item(sItem);
				float num = this.gravDir;
				int whoAmI2 = this.whoAmI;
			}
		}

		// Token: 0x06002502 RID: 9474 RVA: 0x0013E4C8 File Offset: 0x0013C6C8
		private void TentacleSpike_TrySpiking(NPC npc, Item sItem, float damage, float knockBack)
		{
			bool spawnTentacleSpikes = this._spawnTentacleSpikes;
			if (spawnTentacleSpikes)
			{
				if (!spawnTentacleSpikes)
				{
				}
				int myPlayer = Main.myPlayer;
				int whoAmI = this.whoAmI;
				if (npc != null)
				{
					long num = 0L;
					bool flag = npc.CanBeChasedBy(this, num != 0L);
				}
				Microsoft.Xna.Framework.Vector2 center = npc.Center;
				Microsoft.Xna.Framework.Vector2 mountedCenter = this.MountedCenter;
				if (whoAmI == 0)
				{
				}
				if (!true)
				{
				}
				Rectangle hitbox = npc.Hitbox;
				Microsoft.Xna.Framework.Vector2 mountedCenter2 = this.MountedCenter;
				Microsoft.Xna.Framework.Vector2 center2 = npc.Center;
				IEntitySource projectileSource_Item = this.GetProjectileSource_Item(sItem);
				int whoAmI2 = this.whoAmI;
				int whoAmI3 = npc.whoAmI;
				if (32640 == 0)
				{
				}
				int whoAmI4 = npc.whoAmI;
				int whoAmI5 = npc.whoAmI;
			}
		}

		// Token: 0x06002503 RID: 9475 RVA: 0x0013E574 File Offset: 0x0013C774
		private void BloodButcherer_TryButchering(NPC npc, Item sItem, float damage, float knockBack)
		{
			bool spawnBloodButcherer = this._spawnBloodButcherer;
			if (spawnBloodButcherer)
			{
				if (!spawnBloodButcherer)
				{
				}
				int myPlayer = Main.myPlayer;
				int whoAmI = this.whoAmI;
				if (npc != null)
				{
					long num = 0L;
					bool flag = npc.CanBeChasedBy(this, num != 0L);
				}
				Microsoft.Xna.Framework.Vector2 center = npc.Center;
				Microsoft.Xna.Framework.Vector2 mountedCenter = this.MountedCenter;
				if (whoAmI == 0)
				{
				}
				if (!true)
				{
				}
				Rectangle hitbox = npc.Hitbox;
				Microsoft.Xna.Framework.Vector2 mountedCenter2 = this.MountedCenter;
				Microsoft.Xna.Framework.Vector2 center2 = npc.Center;
				IEntitySource projectileSource_Item = this.GetProjectileSource_Item(sItem);
				int whoAmI2 = this.whoAmI;
				int whoAmI3 = npc.whoAmI;
				int whoAmI4 = npc.whoAmI;
				int whoAmI5 = npc.whoAmI;
			}
		}

		// Token: 0x06002504 RID: 9476 RVA: 0x0013E61C File Offset: 0x0013C81C
		private void BatBat_TryLifeLeeching(Entity entity)
		{
			if (this._batbatCanHeal)
			{
				int num = this.statLife;
				int num2 = this.statLifeMax2;
				if (entity != null)
				{
				}
				int num3 = 1;
				this.Heal(num3);
				return;
			}
		}

		// Token: 0x06002505 RID: 9477 RVA: 0x0013E64C File Offset: 0x0013C84C
		public bool HasNPCBannerBuff(int bannerType)
		{
			/*
An exception occurred when decompiling this method (06002505)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::HasNPCBannerBuff(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:bool[](var_1_0F, ldfld:bool[](SceneMetrics::NPCBannerBuff, callgetter:SceneMetrics(Main::get_SceneMetrics)))
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

		// Token: 0x06002506 RID: 9478 RVA: 0x0013E668 File Offset: 0x0013C868
		public void ResetMeleeHitCooldowns()
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
			int whoAmI = this.whoAmI;
			int[] array = this.meleeNPCHitCooldown;
		}

		// Token: 0x06002507 RID: 9479 RVA: 0x0013E690 File Offset: 0x0013C890
		public void UpdateMeleeHitCooldowns()
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
			int whoAmI = this.whoAmI;
			int[] array = this.meleeNPCHitCooldown;
		}

		// Token: 0x06002508 RID: 9480 RVA: 0x0013E6BC File Offset: 0x0013C8BC
		public bool CanHitNPCWithMeleeHit(int npcIndex)
		{
			/*
An exception occurred when decompiling this method (06002508)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::CanHitNPCWithMeleeHit(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32[](var_0_06, ldfld:int32[](Player::meleeNPCHitCooldown, ldloc:Player(this)))
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

		// Token: 0x06002509 RID: 9481 RVA: 0x0013E6D0 File Offset: 0x0013C8D0
		public void SetMeleeHitCooldown(int npcIndex, int timeInFrames)
		{
			int[] array = this.meleeNPCHitCooldown;
		}

		// Token: 0x0600250A RID: 9482 RVA: 0x0013E6E4 File Offset: 0x0013C8E4
		private void ItemCheck_MeleeHitNPCs(Item sItem, Rectangle itemRectangle, int originalDamage, float knockBack)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0 && num == 0)
			{
				int[] array = this.meleeNPCHitCooldown;
				if (this.attackCD == 0)
				{
				}
			}
		}

		// Token: 0x0600250B RID: 9483 RVA: 0x0013E714 File Offset: 0x0013C914
		public void TakeDamageFromJellyfish(int npcIndex)
		{
			if (!true)
			{
			}
			PlayerDeathReason playerDeathReason = PlayerDeathReason.ByNPC(npcIndex);
			int direction = this.direction;
			int[] array = this.meleeNPCHitCooldown;
			int num = this.itemAnimation;
			this.ApplyAttackCooldown();
		}

		// Token: 0x0600250C RID: 9484 RVA: 0x0013E748 File Offset: 0x0013C948
		private void ProcessHitAgainstNPC(Item sItem, Rectangle itemRectangle, int originalDamage, float knockBack, int npcIndex)
		{
			if (!true)
			{
			}
			if (!this.killGuide)
			{
				return;
			}
			bool flag;
			if (32768 != 0)
			{
				flag = this.meleeScaleGlove;
				if (flag)
				{
				}
			}
			if (flag)
			{
				bool flag2 = this.meleeScaleGlove;
				if (flag2)
				{
				}
			}
			if (17036 == 0)
			{
			}
			bool spawnVolcanoExplosion = this._spawnVolcanoExplosion;
		}

		// Token: 0x0600250D RID: 9485 RVA: 0x0013E96C File Offset: 0x0013CB6C
		public void ApplyAttackCooldown()
		{
			int num = this.itemAnimationMax;
			if (!true)
			{
			}
			int num2;
			this.attackCD = num2;
		}

		// Token: 0x0600250E RID: 9486 RVA: 0x0013E98C File Offset: 0x0013CB8C
		public void ApplyAttackCooldown(int frames)
		{
			int num = this.attackCD;
			this.attackCD = frames;
		}

		// Token: 0x0600250F RID: 9487 RVA: 0x0013E9A8 File Offset: 0x0013CBA8
		private void ApplyNPCOnHitEffects(Item sItem, Rectangle itemRectangle, int damage, float knockBack, int npcIndex, int dmgRandomized, int dmgDone)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int type = sItem.type;
			int direction = this.direction;
			if (num == 0)
			{
			}
			if (type == 0)
			{
			}
			IEntitySource projectileSource_Item = this.GetProjectileSource_Item(sItem);
			int whoAmI = this.whoAmI;
			if (type == 0)
			{
			}
			int num2 = 32768;
			bool flag = this.beetleOffense;
			float num3 = this.beetleCounter;
			this.beetleCounter = num3;
			byte b = this.meleeEnchant;
			if (num2 == 0)
			{
			}
			int whoAmI2 = this.whoAmI;
			int type2 = sItem.type;
			int num4 = 16256;
			this.stealth = (float)num4;
			if (num4 == 0)
			{
			}
			bool netClientOnly = Main.NetClientOnly;
			int whoAmI3 = this.whoAmI;
			if (sItem.type == 0)
			{
			}
			if (sItem.type == 0)
			{
			}
			if (sItem.type == 0)
			{
			}
			if (sItem.type == 0)
			{
			}
			if (sItem.type == 0)
			{
			}
			bool flag2 = this.strongBees;
			if (flag2)
			{
				if (!flag2)
				{
				}
			}
			int num5 = 21846;
			int direction2 = this.direction;
			if (num5 == 0)
			{
			}
			IEntitySource projectileSource_Item2 = this.GetProjectileSource_Item(sItem);
			int num6 = this.beeType();
			int num7 = this.beeDamage(damage);
			int whoAmI4 = this.whoAmI;
			bool flag3 = this.makeStrongBee;
			if (num5 == 0)
			{
			}
			int type3 = sItem.type;
			bool spawnMuramasaCut = this._spawnMuramasaCut;
			if (spawnMuramasaCut)
			{
				if (!spawnMuramasaCut)
				{
				}
				if (num5 == 0)
				{
				}
				int num8 = 30;
				int num9 = 16;
				Rectangle rectangle;
				rectangle.Inflate(num8, num9);
				Point point;
				Microsoft.Xna.Framework.Vector2 vector = point.ToVector2();
				int direction3 = this.direction;
				float num10 = this.gravDir;
				IEntitySource projectileSource_Item3 = this.GetProjectileSource_Item(sItem);
				int whoAmI5 = this.whoAmI;
			}
			bool flag4 = this.hasLuckyCoin;
			if (flag4)
			{
				if (!flag4)
				{
				}
				int num11;
				if (num11 == 0)
				{
					if (!flag4)
					{
					}
					int direction4 = this.direction;
					bool netClientOnly2 = Main.NetClientOnly;
				}
			}
		}

		// Token: 0x06002510 RID: 9488 RVA: 0x0013EBC8 File Offset: 0x0013CDC8
		private void ItemCheck_EmitHammushProjectiles(int i, Item sItem, Rectangle itemRectangle, int damage)
		{
			int type = sItem.type;
			int num = this.itemAnimationMax;
			int num2 = this.itemAnimation;
		}

		// Token: 0x06002511 RID: 9489 RVA: 0x0013EC48 File Offset: 0x0013CE48
		private bool[] ItemCheck_GetTileCutIgnoreList(Item sItem)
		{
			int type = sItem.type;
			long num = 0L;
			long num2 = 0L;
			return this.GetTileCutIgnorance(num != 0L, num2 != 0L);
		}

		// Token: 0x06002512 RID: 9490 RVA: 0x0013EC68 File Offset: 0x0013CE68
		public bool[] GetTileCutIgnorance(bool allowRegrowth, bool fromTrap)
		{
			/*
An exception occurred when decompiling this method (06002512)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean[] Terraria.Player::GetTileCutIgnorance(System.Boolean,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	brtrue(IL_0000, logicnot:bool(ldfld:bool(Player::dontHurtNature, ldloc:Player(this))))
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

		// Token: 0x06002513 RID: 9491 RVA: 0x0013EC80 File Offset: 0x0013CE80
		private void ItemCheck_CutTiles(Item sItem, Rectangle itemRectangle, bool[] shouldIgnore)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Tile tile;
			ushort type = tile.type;
			Tile tile2;
			ushort type2 = tile2.type;
			if (sItem.type == 0)
			{
			}
			Tile tile3;
			ushort type3 = tile3.type;
			Tile tile4;
			bool flag = tile4.active();
		}

		// Token: 0x06002514 RID: 9492 RVA: 0x0013ECF0 File Offset: 0x0013CEF0
		private Rectangle ItemCheck_CatchCritters(Item sItem, Rectangle itemRectangle)
		{
			int num = 1;
			int type = sItem.type;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			int whoAmI = this.whoAmI;
			PlayerDeathReason playerDeathReason = PlayerDeathReason.ByNPC(myPlayer);
			Microsoft.Xna.Framework.Vector2 center = base.Center;
			bool flag = this.dead;
			if (!flag)
			{
				int num2 = 24;
				int num3 = 300;
				long num4 = 0L;
				long num5 = 0L;
				this.AddBuff(num2, num3, num4 != 0L, num5 != 0L);
				if (!flag)
				{
				}
				if (!flag)
				{
				}
				int whoAmI2 = this.whoAmI;
				if (!flag)
				{
				}
				NPC.CatchNPC(int.MinValue, whoAmI2);
			}
			return int.MinValue;
		}

		// Token: 0x06002515 RID: 9493 RVA: 0x0013ED84 File Offset: 0x0013CF84
		private void GetPointOnSwungItemPath(float spriteWidth, float spriteHeight, float normalizedPointOnPath, float itemScale, [Out] Microsoft.Xna.Framework.Vector2 location, [Out] Microsoft.Xna.Framework.Vector2 outwardDirection)
		{
			if (!true)
			{
			}
			int direction = this.direction;
			if (!true)
			{
			}
			int num = true.ToInt();
			float num2 = this.gravDir;
			int direction2 = this.direction;
			float num3 = this.itemRotation;
			Microsoft.Xna.Framework.Vector2 vector = spriteWidth.ToRotationVector2();
			outwardDirection.Y = (float)direction2;
			float x = this.itemLocation.X;
			float y = this.itemLocation.Y;
			location.Y = (float)direction2;
		}

		// Token: 0x06002516 RID: 9494 RVA: 0x0013EE00 File Offset: 0x0013D000
		private Rectangle ItemCheck_EmitUseVisuals(Item sItem, Rectangle itemRectangle)
		{
			int type = sItem.type;
			if (type == 0)
			{
			}
			int num;
			if (num == 0)
			{
				if (type == 0)
				{
				}
				int num2 = 15;
				int direction = this.direction;
				if (num2 == 0)
				{
				}
			}
			int type2 = sItem.type;
			if (type2 == 0)
			{
			}
			int num3;
			int num4;
			if (num3 == 0)
			{
				if (type2 == 0)
				{
				}
				int direction2 = this.direction;
				num4 = 1;
			}
			int type3 = sItem.type;
			long num5 = 3L;
			if (type3 == 0)
			{
			}
			int num6;
			if (num6 == 0)
			{
				int direction3 = this.direction;
			}
			if (sItem.type == 0)
			{
			}
			int num7;
			if (num7 == 0)
			{
				int direction4 = this.direction;
			}
			if (sItem.type == 0)
			{
			}
			int num8;
			if (num8 == 0)
			{
				int direction5 = this.direction;
			}
			int direction6 = this.direction;
			float x = this.velocity.X;
			float y = this.velocity.Y;
			if (num4 == 0)
			{
			}
			int num9 = 1;
			if (sItem.type == 0)
			{
			}
			int num10;
			int num11;
			if (num10 == 0)
			{
				if (num9 == 0)
				{
				}
				num11 = 1;
			}
			if (sItem.type == 0)
			{
			}
			int num12;
			if (num12 == 0)
			{
			}
			int num13;
			if (num13 != 0 || num11 == 0)
			{
			}
			int type4 = sItem.type;
			if (num11 == 0)
			{
			}
			int num14;
			if (num14 == 0)
			{
				int direction7 = this.direction;
			}
			int type5 = sItem.type;
			int num15 = 5295;
			int direction8 = this.direction;
			float x2 = this.velocity.X;
			float y2 = this.velocity.Y;
			int direction9 = this.direction;
			float x3 = this.velocity.X;
			float y3 = this.velocity.Y;
			if (num15 == 0)
			{
			}
			int type6 = sItem.type;
			int num16 = 1;
			bool melee = sItem.melee;
			float scale = sItem.scale;
			bool flag;
			if (melee)
			{
				flag = this.meleeScaleGlove;
				if (flag)
				{
				}
			}
			int direction10 = this.direction;
			float num17 = this.gravDir;
			Dust dust;
			dust.noGravity = num16 != 0;
			int type7 = sItem.type;
			int direction11 = this.direction;
			float x4 = this.velocity.X;
			float y4 = this.velocity.Y;
			if (!flag)
			{
			}
			int num18 = 1;
			int type8 = sItem.type;
			int direction12 = this.direction;
			float x5 = this.velocity.X;
			float y5 = this.velocity.Y;
			if (num18 == 0)
			{
			}
			if (sItem.type == 0)
			{
			}
			int num19;
			if (num19 == 0)
			{
				int direction13 = this.direction;
				float x6 = this.velocity.X;
				float y6 = this.velocity.Y;
				if (num18 == 0)
				{
				}
			}
			int type9 = sItem.type;
			if (num5 == 0L)
			{
			}
			if (num18 == 0)
			{
			}
			int type10 = sItem.type;
			int direction14 = this.direction;
			float x7 = this.velocity.X;
			float y7 = this.velocity.Y;
			if (num5 == 0L)
			{
			}
			int num20 = 1;
			Dust dust2;
			dust2.noGravity = num20 != 0;
			float x8 = dust2.velocity.X;
			float y8 = dust2.velocity.Y;
			int num21 = 26214;
			dust2.fadeIn = (float)num21;
			if (sItem.type == 0)
			{
			}
			int num22;
			if (num22 == 0)
			{
				int direction15 = this.direction;
				float x9 = this.velocity.X;
				float y9 = this.velocity.Y;
				if (num18 == 0)
				{
				}
			}
			int type11 = sItem.type;
			bool melee2 = sItem.melee;
			float scale2 = sItem.scale;
			bool flag2;
			if (melee2)
			{
				flag2 = this.meleeScaleGlove;
				if (flag2)
				{
				}
			}
			int direction16 = this.direction;
			float num23 = this.gravDir;
			int num24;
			if (num24 == 0)
			{
				int direction17 = this.direction;
				float x10 = this.velocity.X;
				float y10 = this.velocity.Y;
				if (!flag2)
				{
				}
			}
			if (sItem.type == 0)
			{
			}
			int num25;
			if (num25 != 0)
			{
			}
			int direction18 = this.direction;
			float x11 = this.velocity.X;
			float y11 = this.velocity.Y;
			if (!flag2)
			{
			}
			int direction19 = this.direction;
			if (!flag2)
			{
			}
			int num26;
			if (num26 == 0)
			{
				if (!flag2)
				{
				}
			}
			int type12 = sItem.type;
			float x12 = this.itemLocation.X;
			float x13 = this.velocity.X;
			float y12 = this.itemLocation.Y;
			int num27;
			float num28;
			float num29;
			Lighting.AddLight(1073741824, num27, num28, num29, num29);
			return 1073741824;
		}

		// Token: 0x06002517 RID: 9495 RVA: 0x0013F3C4 File Offset: 0x0013D5C4
		private void ItemCheck_GetMeleeHitbox(Item sItem, Rectangle heldItemFrame, [Out] bool dontAttack, [Out] Rectangle itemRectangle)
		{
			float x = this.itemLocation.X;
			float y = this.itemLocation.Y;
			int num = 32640;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				int type = sItem.type;
				return;
			}
			bool melee = sItem.melee;
			float scale = sItem.scale;
			if (!melee || this.meleeScaleGlove)
			{
			}
			int direction = this.direction;
			float num2 = this.gravDir;
			byte useStyle = sItem.useStyle;
			int num3 = this.itemAnimationMax;
			int num4 = this.itemAnimation;
			int direction2 = this.direction;
		}

		// Token: 0x06002518 RID: 9496 RVA: 0x0013F614 File Offset: 0x0013D814
		private void ItemCheck_UseDemonHeart(Item sItem)
		{
			int type = sItem.type;
			int num = this.itemAnimation;
			if (!this.extraAccessory)
			{
				bool expertMode = Main.expertMode;
				if (this.itemTime == 0)
				{
					int useTime = sItem.useTime;
					this.itemTime = useTime;
					this.itemTimeMax = useTime;
					this.extraAccessory = true;
					int whoAmI = this.whoAmI;
					if (useTime == 0)
					{
					}
				}
			}
		}

		// Token: 0x06002519 RID: 9497 RVA: 0x0013F674 File Offset: 0x0013D874
		private void ItemCheck_UseMinecartPowerUp(Item sItem)
		{
			int type = sItem.type;
			int num = this.itemAnimation;
			if (this.itemTime != 0)
			{
				return;
			}
			int useTime = sItem.useTime;
			bool flag = this.unlockedSuperCart;
			this.itemTime = useTime;
			this.itemTimeMax = useTime;
			if (!flag)
			{
				this.unlockedSuperCart = true;
				int whoAmI = this.whoAmI;
			}
			IEntitySource itemSource_OpenItem = this.GetItemSource_OpenItem(5289);
			this.QuickSpawnItem(itemSource_OpenItem, 3353, 1);
		}

		// Token: 0x0600251A RID: 9498 RVA: 0x0013F6E4 File Offset: 0x0013D8E4
		private void ItemCheck_UseArtisanLoaf(Item sItem)
		{
			int type = sItem.type;
			int num = this.itemAnimation;
			if (!this.ateArtisanBread && this.itemTime == 0)
			{
				int useTime = sItem.useTime;
				this.itemTime = useTime;
				this.itemTimeMax = useTime;
				this.ateArtisanBread = true;
				int whoAmI = this.whoAmI;
				if (useTime == 0)
				{
				}
			}
		}

		// Token: 0x0600251B RID: 9499 RVA: 0x0013F738 File Offset: 0x0013D938
		private void ItemCheck_UseTorchGodsFavor(Item sItem)
		{
			int type = sItem.type;
			int num = this.itemAnimation;
			if (!this.unlockedBiomeTorches && this.itemTime == 0)
			{
				int useTime = sItem.useTime;
				int[] array = this.builderAccStatus;
				this.unlockedBiomeTorches = true;
				this.itemTime = useTime;
				this.itemTimeMax = useTime;
				AchievementsHelper.HandleSpecialEvent(this, 24);
				if (useTime == 0)
				{
				}
				if (useTime == 0)
				{
				}
				int whoAmI = this.whoAmI;
				int whoAmI2 = this.whoAmI;
			}
		}

		// Token: 0x0600251C RID: 9500 RVA: 0x0013F7A4 File Offset: 0x0013D9A4
		private void ItemCheck_TryDestroyingDrones(Item sItem)
		{
			int type = sItem.type;
			int[] array = this.ownedProjectileCounts;
			if (this.controlUseItem && this.itemTime == 0)
			{
				bool flag = this.mouseInterface;
				if (!flag)
				{
					if (!flag)
					{
					}
					int whoAmI = this.whoAmI;
				}
			}
		}

		// Token: 0x0600251D RID: 9501 RVA: 0x0013F7F0 File Offset: 0x0013D9F0
		private void ItemCheck_UseManaCrystal(Item sItem)
		{
			int type = sItem.type;
			int num = this.itemAnimation;
			int num2 = this.statManaMax;
			if (this.itemTime != 0)
			{
				return;
			}
			int useTime = sItem.useTime;
			int num3 = this.statManaMax2;
			int num4 = this.statMana;
			this.statManaMax = num2;
			this.itemTime = useTime;
			this.itemTimeMax = useTime;
			this.statManaMax2 = num2;
			this.statMana = useTime;
			if (num2 == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			int whoAmI = this.whoAmI;
			int num5 = 20;
			this.ManaEffect(num5);
			int num6 = 1;
			AchievementsHelper.HandleSpecialEvent(this, num6);
		}

		// Token: 0x0600251E RID: 9502 RVA: 0x0013F884 File Offset: 0x0013DA84
		private void ItemCheck_UseLifeFruit(Item sItem)
		{
			int type = sItem.type;
			int num = this.itemAnimation;
			int num2 = this.statLifeMax;
			if (this.itemTime != 0)
			{
				return;
			}
			int num3 = this.statLifeMax2;
			int useTime = sItem.useTime;
			this.statLifeMax = num2;
			this.itemTime = useTime;
			this.itemTimeMax = useTime;
			this.statLifeMax2 = num3;
			if (num2 == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			int whoAmI = this.whoAmI;
			int num4 = 5;
			int num5 = 1;
			this.HealEffect(num4, num5 != 0);
			int num6 = 2;
			AchievementsHelper.HandleSpecialEvent(this, num6);
		}

		// Token: 0x0600251F RID: 9503 RVA: 0x0013F90C File Offset: 0x0013DB0C
		private void ItemCheck_UseLifeCrystal(Item sItem)
		{
			int type = sItem.type;
			int num = this.itemAnimation;
			int num2 = this.statLifeMax;
			if (this.itemTime != 0)
			{
				return;
			}
			int num3 = this.statLifeMax2;
			int useTime = sItem.useTime;
			this.statLifeMax = num2;
			this.itemTime = useTime;
			this.itemTimeMax = useTime;
			this.statLifeMax2 = num3;
			if (num2 == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			int whoAmI = this.whoAmI;
			int num4 = 20;
			int num5 = 1;
			this.HealEffect(num4, num5 != 0);
			long num6 = 0L;
			AchievementsHelper.HandleSpecialEvent(this, (int)num6);
		}

		// Token: 0x06002520 RID: 9504 RVA: 0x0013F998 File Offset: 0x0013DB98
		private void ItemCheck_UseCombatBook(Item sItem)
		{
			if (!true)
			{
			}
			if (!true)
			{
				int type = sItem.type;
				int num = this.itemAnimation;
				if (this.itemTime == 0)
				{
					int useTime = sItem.useTime;
					this.itemTime = useTime;
					this.itemTimeMax = useTime;
					if (useTime == 0)
					{
					}
					if (useTime != 0)
					{
						int whoAmI = this.whoAmI;
						if (useTime == 0)
						{
						}
						return;
					}
					if (useTime == 0)
					{
					}
					string textValue = Language.GetTextValue("Misc.CombatBookUsed");
					if (!true)
					{
					}
				}
			}
			int type2 = sItem.type;
			int num2 = this.itemAnimation;
			if (this.itemTime == 0)
			{
				int useTime2 = sItem.useTime;
				this.itemTime = useTime2;
				this.itemTimeMax = useTime2;
				if (useTime2 == 0)
				{
				}
				if (useTime2 == 0)
				{
					if (useTime2 == 0)
					{
					}
					string textValue2 = Language.GetTextValue("Misc.CombatBookVolumeTwoUsed");
					if (!true)
					{
					}
					return;
				}
				int whoAmI2 = this.whoAmI;
				if (useTime2 == 0)
				{
				}
			}
		}

		// Token: 0x06002521 RID: 9505 RVA: 0x0013FA54 File Offset: 0x0013DC54
		private void ItemCheck_UsePetLicenses(Item sItem)
		{
			int type = sItem.type;
			if (this.itemAnimation == 0)
			{
			}
			int type2 = sItem.type;
			if (this.itemAnimation == 0)
			{
			}
			int type3 = sItem.type;
			if (this.itemAnimation == 0)
			{
			}
		}

		// Token: 0x06002522 RID: 9506 RVA: 0x0013FAA4 File Offset: 0x0013DCA4
		private void ItemCheck_UsePeddlersSatchel(Item sItem)
		{
			if (!true)
			{
			}
			if (!true)
			{
				int type = sItem.type;
				int num = this.itemAnimation;
				if (this.itemTime == 0)
				{
					int useTime = sItem.useTime;
					this.itemTime = useTime;
					this.itemTimeMax = useTime;
					if (useTime == 0)
					{
					}
					if (useTime == 0)
					{
						string textValue = Language.GetTextValue("Misc.PeddlersSatchelUsed");
						if (!true)
						{
						}
						return;
					}
					int whoAmI = this.whoAmI;
				}
			}
		}

		// Token: 0x06002523 RID: 9507 RVA: 0x0013FB00 File Offset: 0x0013DD00
		private void ItemCheck_UseShimmerPermanentItems(Item sItem)
		{
			int type = sItem.type;
			int num = this.itemAnimation;
			if (!this.usedAegisCrystal && this.itemTime == 0)
			{
				int useTime = sItem.useTime;
				this.usedAegisCrystal = true;
				int whoAmI = this.whoAmI;
				this.itemTime = useTime;
				this.itemTimeMax = useTime;
				if (useTime == 0)
				{
				}
				int type2 = sItem.type;
				int num2 = this.itemAnimation;
				if (!this.usedAegisFruit && this.itemTime == 0)
				{
					int useTime2 = sItem.useTime;
					this.usedAegisFruit = true;
					int whoAmI2 = this.whoAmI;
					this.itemTime = useTime2;
					this.itemTimeMax = useTime2;
					if (useTime2 == 0)
					{
					}
					int type3 = sItem.type;
					int num3 = this.itemAnimation;
					if (!this.usedArcaneCrystal && this.itemTime == 0)
					{
						int useTime3 = sItem.useTime;
						this.usedArcaneCrystal = true;
						int whoAmI3 = this.whoAmI;
						this.itemTime = useTime3;
						this.itemTimeMax = useTime3;
						if (useTime3 == 0)
						{
						}
						int type4 = sItem.type;
						int num4 = this.itemAnimation;
						if (!this.usedGalaxyPearl && this.itemTime == 0)
						{
							int useTime4 = sItem.useTime;
							this.usedGalaxyPearl = true;
							int whoAmI4 = this.whoAmI;
							this.itemTime = useTime4;
							this.itemTimeMax = useTime4;
							if (useTime4 == 0)
							{
							}
							int type5 = sItem.type;
							int num5 = this.itemAnimation;
							if (!this.usedGummyWorm && this.itemTime == 0)
							{
								int useTime5 = sItem.useTime;
								this.usedGummyWorm = true;
								int whoAmI5 = this.whoAmI;
								this.itemTime = useTime5;
								this.itemTimeMax = useTime5;
								if (useTime5 == 0)
								{
								}
								int type6 = sItem.type;
								int num6 = this.itemAnimation;
								if (!this.usedAmbrosia && this.itemTime == 0)
								{
									int useTime6 = sItem.useTime;
									this.usedAmbrosia = true;
									this.itemTime = useTime6;
									this.itemTimeMax = useTime6;
									int whoAmI6 = this.whoAmI;
									if (useTime6 == 0)
									{
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06002524 RID: 9508 RVA: 0x0013FCE8 File Offset: 0x0013DEE8
		private void LicenseOrExchangePet(Item sItem, bool petBoughtFlag, int npcType, string textKeyForLicense, int netMessageData)
		{
			if (this.itemTime != 0)
			{
				return;
			}
			bool flag = NPC.AnyNPCs(npcType);
			int useTime = sItem.useTime;
			this.itemTime = useTime;
			this.itemTimeMax = useTime;
			if (useTime == 0)
			{
			}
			NPC.UnlockOrExchangePet(petBoughtFlag, npcType, textKeyForLicense, netMessageData);
		}

		// Token: 0x06002525 RID: 9509 RVA: 0x0013FD28 File Offset: 0x0013DF28
		public void LimitPointToPlayerReachableArea(Microsoft.Xna.Framework.Vector2 pointPoisition)
		{
			Microsoft.Xna.Framework.Vector2 center = base.Center;
			float x = pointPoisition.X;
			float y = pointPoisition.Y;
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x06002526 RID: 9510 RVA: 0x0013FD60 File Offset: 0x0013DF60
		private void ItemCheck_UseTeleportRod(Item sItem)
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
			int whoAmI = this.whoAmI;
			int type = sItem.type;
			int num = this.itemAnimation;
			if (this.itemTime == 0)
			{
				int useTime = sItem.useTime;
				this.itemTime = useTime;
				this.itemTimeMax = useTime;
				if (useTime == 0)
				{
				}
				int mouseX = Main.mouseX;
				Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
				float num2 = this.gravDir;
				if (useTime == 0)
				{
				}
				int mouseY = Main.mouseY;
				Microsoft.Xna.Framework.Vector2 screenPosition2 = Main.screenPosition;
				int height = this.height;
				return;
			}
		}

		// Token: 0x06002527 RID: 9511 RVA: 0x0013FECC File Offset: 0x0013E0CC
		private bool IsTilePoundable(Tile targetTile)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				return;
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06002528 RID: 9512 RVA: 0x0013FEEC File Offset: 0x0013E0EC
		private void UseShovel(Player user, Item item, int sX, int sY)
		{
			this.DamageTileWithShovel(user, item, sX, sY);
			int useTime = item.useTime;
			float num = this.pickSpeed;
			int num2 = 32640;
			this.itemTime = num2;
		}

		// Token: 0x06002529 RID: 9513 RVA: 0x0013FF20 File Offset: 0x0013E120
		private void DamageTileWithShovel(Player user, Item item, int x, int y)
		{
			Tile tileSafely = Framing.GetTileSafely(x, y);
			int num = 100;
			this.PickTile(x, y, num);
			int num2 = 30;
			this.PickTile(x, y, num2);
		}

		// Token: 0x0600252A RID: 9514 RVA: 0x0013FF54 File Offset: 0x0013E154
		private void ItemCheck_UseMiningTools(Item sItem)
		{
			int type = sItem.type;
		}

		// Token: 0x0600252B RID: 9515 RVA: 0x0014008C File Offset: 0x0013E28C
		private void ItemCheck_UseMiningTools_ActuallyUseMiningTool(Item sItem, [Out] bool canHitWalls, int x, int y)
		{
			int num = 1;
			canHitWalls.m_value = num != 0;
			if (num == 0)
			{
			}
			Tile tile;
			bool flag = tile.active();
			int pick = sItem.pick;
			if (pick == 0)
			{
			}
			if (pick == 0)
			{
				if (pick == 0)
				{
				}
				if (pick == 0)
				{
					goto IL_0046;
				}
			}
			int axe = sItem.axe;
			if (axe == 0)
			{
			}
			if (axe == 0)
			{
				int hammer = sItem.hammer;
				if (hammer == 0)
				{
				}
				if (hammer != 0)
				{
				}
			}
			IL_0046:
			HitTile hitTile = this.hitTile;
			int num2 = 1;
			int num3 = hitTile.HitObject(x, y, num2);
			if (100 != 0)
			{
				int hammer2 = sItem.hammer;
				bool flag2 = WorldGen.CanKillTile(x, y);
				int hammer3 = sItem.hammer;
				if (hammer3 == 0)
				{
				}
				long num5;
				if (hammer3 == 0)
				{
					PlayerDeathReason playerDeathReason = PlayerDeathReason.ByOther(4);
					int num4 = this.statLife;
					int direction = this.direction;
					num5 = 0L;
				}
				int num6 = 1;
				int num7 = this.hitTile.AddDamage(num3, (int)num5, num6 != 0);
				HitTile hitTile2 = this.hitReplace;
				int num8 = 1;
				hitTile2.TryClearingAndPruning(x, y, num8);
				HitTile hitTile3 = this.hitTile;
				int num9 = 1;
				hitTile3.TryClearingAndPruning(x, y, num9);
				long num10 = 0L;
				long num11 = 0L;
				long num12 = 0L;
				WorldGen.KillTile(x, y, num10 != 0L, num11 != 0L, num12 != 0L);
				bool netClient = Main.NetClient;
				return;
			}
		}

		// Token: 0x0600252C RID: 9516 RVA: 0x00140360 File Offset: 0x0013E560
		private bool IsBottomOfTreeTrunkNoRoots(int x, int y)
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
				return;
			}
		}

		// Token: 0x0600252D RID: 9517 RVA: 0x00140384 File Offset: 0x0013E584
		private void TryReplantingTree()
		{
			if (!true)
			{
			}
			int tileTargetX = Player.tileTargetX;
			int tileTargetY = Player.tileTargetY;
			int direction = this.direction;
			int tileTargetX2 = Player.tileTargetX;
			int tileTargetY2 = Player.tileTargetY;
			WorldGen.SquareTileFrame(tileTargetX2, tileTargetY2, true);
			int tileTargetX3 = Player.tileTargetX;
			int tileTargetY3 = Player.tileTargetY;
			int direction2 = this.direction;
			bool netClient = Main.NetClient;
			int tileTargetX4 = Player.tileTargetX;
			int tileTargetY4 = Player.tileTargetY;
			int direction3 = this.direction;
			NetMessage.SendObjectPlacement(0, tileTargetX4, tileTargetY4, 42187544, tileTargetY2, int.MinValue, 0, direction3);
		}

		// Token: 0x0600252E RID: 9518 RVA: 0x00140410 File Offset: 0x0013E610
		private static void ItemCheck_UseMiningTools_TryFindingWallToHammer([Out] int wX, [Out] int wY)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int tileTargetX = Player.tileTargetX;
			wX.m_value = tileTargetX;
			int tileTargetY = Player.tileTargetY;
			wY.m_value = tileTargetY;
			if (num == 0)
			{
			}
			Tile tile;
			ushort wall = tile.wall;
			if (num == 0)
			{
			}
			Tile tile2;
			ushort wall2 = tile2.wall;
			if (num == 0)
			{
				Tile tile3;
				ushort wall3 = tile3.wall;
				Tile tile4;
				ushort wall4 = tile4.wall;
				return;
			}
		}

		// Token: 0x0600252F RID: 9519 RVA: 0x00140544 File Offset: 0x0013E744
		private void ItemCheck_UseMiningTools_TryHittingWall(Item sItem, int wX, int wY)
		{
			long num2;
			for (;;)
			{
				int num = 1;
				if (num == 0)
				{
				}
				Tile tile;
				ushort wall = tile.wall;
				if (num == 0)
				{
				}
				Tile tile2;
				bool flag = tile2.active();
				if (num == 0)
				{
				}
				int tileTargetX = Player.tileTargetX;
				if (num == 0)
				{
				}
				int tileTargetY = Player.tileTargetY;
				if (num == 0)
				{
				}
				num2 = 0L;
				Tile tile3;
				ushort type = tile3.type;
				if (num != 0 || this.poundRelease || this.toolTime != 0)
				{
					break;
				}
				int num3 = this.itemAnimation;
				if (this.controlUseItem)
				{
					goto Block_2;
				}
			}
			return;
			Block_2:
			if (sItem.hammer == 0)
			{
			}
			bool flag2 = Player.CanPlayerSmashWall(wX, wY);
			int hammer = sItem.hammer;
			this.PickWall(wX, wY, (int)num2);
			int useTime = sItem.useTime;
			this.itemTime = useTime;
		}

		// Token: 0x06002530 RID: 9520 RVA: 0x001405E4 File Offset: 0x0013E7E4
		public static bool CanPlayerSmashWall(int X, int Y)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Tile tile;
			ushort wall = tile.wall;
			if (num != 0)
			{
			}
			if (num == 0)
			{
			}
			Tile tile2;
			ushort wall2 = tile2.wall;
			if (num == 0)
			{
			}
			Tile tile3;
			ushort wall3 = tile3.wall;
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06002531 RID: 9521 RVA: 0x00140620 File Offset: 0x0013E820
		public void PickWall(int x, int y, int damage)
		{
			int num = this.hitTile.HitObject(x, y, 2);
			HitTile hitTile = this.hitTile;
			int num2 = hitTile.AddDamage(num, damage, true);
			if (hitTile == null)
			{
			}
			WorldGen.KillWall(x, y, true);
			if (hitTile == null)
			{
			}
			bool netClient = Main.NetClient;
			if (hitTile == null)
			{
			}
		}

		// Token: 0x06002532 RID: 9522 RVA: 0x001406C0 File Offset: 0x0013E8C0
		private void ItemCheck_UseMiningTools_TryPoundingTile(Item sItem, int tileHitId, bool hitWall, int x, int y)
		{
			if (!true)
			{
			}
			int hammer = sItem.hammer;
			Tile tile;
			bool flag = tile.active();
			if (hammer == 0)
			{
			}
			if (hammer == 0)
			{
			}
			if (this.poundRelease)
			{
				int useTime = sItem.useTime;
				this.itemTime = useTime;
				this.itemTimeMax = useTime;
				if (useTime == 0)
				{
				}
				bool flag2 = WorldGen.IsLockedDoor(x, hitWall ? 1 : 0);
				if (useTime == 0)
				{
				}
				bool flag3 = WorldGen.IsLockedDoor(x, hitWall ? 1 : 0);
				return;
			}
		}

		// Token: 0x06002533 RID: 9523 RVA: 0x00140AA8 File Offset: 0x0013ECA8
		public bool IsTargetTileInItemRange(Item sItem)
		{
			/*
An exception occurred when decompiling this method (06002533)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::IsTargetTileInItemRange(Terraria.Item)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_009D:
	stloc:int32(var_16_A2, callgetter:int32(Player::get_tileRangeY))
	stloc:int32(var_17_AA, ldfld:int32(Item::tileBoost, ldloc:Item(sItem)))
	stloc:int32(var_18_B1, callgetter:int32(Player::get_tileTargetY))
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

		// Token: 0x06002534 RID: 9524 RVA: 0x00140B68 File Offset: 0x0013ED68
		private void ItemCheck_UseBuckets(Item sItem)
		{
			int type = sItem.type;
		}

		// Token: 0x06002535 RID: 9525 RVA: 0x001412AC File Offset: 0x0013F4AC
		private void ItemCheck_PlayInstruments(Item sItem)
		{
			int num = 1;
			int width = this.width;
			int height = this.height;
			float x = this.position.X;
			float y = this.position.Y;
			if (num == 0)
			{
			}
			int mouseX = Main.mouseX;
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			int mouseY = Main.mouseY;
			Microsoft.Xna.Framework.Vector2 screenPosition2 = Main.screenPosition;
			if (num == 0)
			{
			}
			int screenHeight = Main.screenHeight;
			int num2 = this.itemAnimation;
			this.musicDist = (float)width;
			if (this.itemTime == 0)
			{
				int type = sItem.type;
				int width2 = this.width;
				int height2 = this.height;
				float x2 = this.position.X;
				float y2 = this.position.Y;
				int useTime = sItem.useTime;
				this.itemTime = useTime;
				this.itemTimeMax = useTime;
				if (useTime == 0)
				{
				}
				int mouseX2 = Main.mouseX;
				Microsoft.Xna.Framework.Vector2 screenPosition3 = Main.screenPosition;
				int mouseY2 = Main.mouseY;
				Microsoft.Xna.Framework.Vector2 screenPosition4 = Main.screenPosition;
				if (useTime == 0)
				{
				}
				int screenHeight2 = Main.screenHeight;
				int musicNotes = Player.musicNotes;
				return;
			}
			bool flag = this.mouseInterface;
			if (!flag)
			{
				if (!flag)
				{
				}
				bool mouseLeft = Main.mouseLeft;
				if (!flag)
				{
				}
				bool mouseLeftRelease = Main.mouseLeftRelease;
				int type2 = sItem.type;
				int num3 = 4372;
				int width3 = this.width;
				int height3 = this.height;
				float x3 = this.position.X;
				float y3 = this.position.Y;
				if (type2 == 0)
				{
				}
				int mouseX3 = Main.mouseX;
				Microsoft.Xna.Framework.Vector2 screenPosition5 = Main.screenPosition;
				int mouseY3 = Main.mouseY;
				Microsoft.Xna.Framework.Vector2 screenPosition6 = Main.screenPosition;
				if (type2 == 0)
				{
				}
				int screenHeight3 = Main.screenHeight;
				int musicNotes2 = Player.musicNotes;
				if (num3 == 0)
				{
				}
				return;
			}
		}

		// Token: 0x06002536 RID: 9526 RVA: 0x001416B0 File Offset: 0x0013F8B0
		private bool GetSparkleGuitarTarget([Out] List<NPC> validTargets)
		{
			/*
An exception occurred when decompiling this method (06002536)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::GetSparkleGuitarTarget(System.Collections.Generic.List`1<Terraria.NPC>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0019:
	stloc:bool(var_8_24, call:bool(Rectangle::Intersects, ldloc:Rectangle[exp:valuetype Microsoft.Xna.Framework.Rectangle&](var_7), ldloc:Rectangle(var_3)))
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

		// Token: 0x06002537 RID: 9527 RVA: 0x001416E4 File Offset: 0x0013F8E4
		private bool GetZenithTarget(Microsoft.Xna.Framework.Vector2 searchCenter, float maxDistance, [Out] int npcTargetIndex)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			long num2 = 0L;
			if (num != 0)
			{
				searchCenter.X = (float)num2;
				return;
			}
		}

		// Token: 0x06002538 RID: 9528 RVA: 0x00141710 File Offset: 0x0013F910
		public void PlayGuitarChord(float range)
		{
			Microsoft.Xna.Framework.Vector2 center = base.Center;
		}

		// Token: 0x06002539 RID: 9529 RVA: 0x0014172C File Offset: 0x0013F92C
		public void PlayDrums(float range)
		{
			Microsoft.Xna.Framework.Vector2 center = base.Center;
		}

		// Token: 0x0600253A RID: 9530 RVA: 0x0014174C File Offset: 0x0013F94C
		private void ItemCheck_UseWiringTools(Item sItem)
		{
			int type = sItem.type;
			float x = this.position.X;
			if (type == 0)
			{
			}
			int tileRangeX = Player.tileRangeX;
			int tileBoost = sItem.tileBoost;
			int num = this.blockRange;
			int tileTargetX = Player.tileTargetX;
			int num2 = 15744;
			float x2 = this.position.X;
			int width = this.width;
			if (num2 == 0)
			{
			}
			int tileRangeX2 = Player.tileRangeX;
			int tileBoost2 = sItem.tileBoost;
			int num3 = this.blockRange;
			int tileTargetX2 = Player.tileTargetX;
			int num4 = 15744;
			float y = this.position.Y;
			if (num4 == 0)
			{
			}
			int tileRangeY = Player.tileRangeY;
			int tileBoost3 = sItem.tileBoost;
			int num5 = this.blockRange;
			int tileTargetY = Player.tileTargetY;
			int num6 = 15744;
			float y2 = this.position.Y;
			int height = this.height;
			if (num6 == 0)
			{
			}
			int tileRangeY2 = Player.tileRangeY;
			int tileBoost4 = sItem.tileBoost;
			int num7 = this.blockRange;
			int tileTargetY2 = Player.tileTargetY;
			if (15744 == 0)
			{
			}
			bool gamepadDisableCursorItemIcon = Main.GamepadDisableCursorItemIcon;
			int num8 = 1;
			this.cursorItemIconEnabled = num8 != 0;
			int type2 = sItem.type;
			if (num8 == 0)
			{
			}
			Main.ItemIconCacheUpdate(type2);
			if (num8 == 0)
			{
			}
			int tileTargetX3 = Player.tileTargetX;
			int tileTargetY3 = Player.tileTargetY;
			int num9 = this.itemAnimation;
			if (this.itemTime != 0)
			{
				return;
			}
			bool flag = this.controlUseItem;
			while (!flag)
			{
			}
			if (!flag)
			{
			}
			int tileTargetX4 = Player.tileTargetX;
			int tileTargetY4 = Player.tileTargetY;
			int type3 = sItem.type;
			Item[] array = this.inventory;
		}

		// Token: 0x0600253B RID: 9531 RVA: 0x00141C98 File Offset: 0x0013FE98
		public bool CanDoWireStuffHere(int x, int y)
		{
			if (!true)
			{
			}
			long num = 0L;
			bool flag = WorldGen.InWorld(x, y, (int)num);
			if (!flag)
			{
			}
			if (!flag)
			{
				if (!flag)
				{
				}
				Tile tile;
				ushort wall = tile.wall;
			}
			return true;
		}

		// Token: 0x0600253C RID: 9532 RVA: 0x00141CC8 File Offset: 0x0013FEC8
		private void ItemCheck_UseLawnMower(Item sItem)
		{
			int type = sItem.type;
			float x = this.position.X;
			if (type == 0)
			{
			}
			int tileRangeX = Player.tileRangeX;
			int tileBoost = sItem.tileBoost;
			int num = this.blockRange;
			int tileTargetX = Player.tileTargetX;
			float x2 = this.position.X;
			int width = this.width;
			if (15744 == 0)
			{
			}
			int tileRangeX2 = Player.tileRangeX;
			int tileBoost2 = sItem.tileBoost;
			int num2 = this.blockRange;
			int tileTargetX2 = Player.tileTargetX;
			float y = this.position.Y;
			if (15744 == 0)
			{
			}
			int tileRangeY = Player.tileRangeY;
			int tileBoost3 = sItem.tileBoost;
			int num3 = this.blockRange;
			int tileTargetY = Player.tileTargetY;
			float y2 = this.position.Y;
			int height = this.height;
			if (15744 == 0)
			{
			}
			int tileRangeY2 = Player.tileRangeY;
			int tileBoost4 = sItem.tileBoost;
			int num4 = this.blockRange;
			int tileTargetY2 = Player.tileTargetY;
			int num5 = this.itemAnimation;
			if (this.itemTime == 0)
			{
				bool flag = this.controlUseItem;
				if (flag)
				{
					if (!flag)
					{
					}
					int tileTargetX3 = Player.tileTargetX;
					int tileTargetY3 = Player.tileTargetY;
					if (!flag)
					{
					}
					int useTime = sItem.useTime;
					this.itemTime = useTime;
					this.itemTimeMax = useTime;
				}
			}
		}

		// Token: 0x0600253D RID: 9533 RVA: 0x00141DF8 File Offset: 0x0013FFF8
		private void DestroyOldestProximityMinesOverMinesCap(int minesCap)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int whoAmI = this.whoAmI;
		}

		// Token: 0x0600253E RID: 9534 RVA: 0x00141E28 File Offset: 0x00140028
		private void ItemCheck_Shoot(int i, Item sItem, int weaponDamage)
		{
			float shootSpeed = sItem.shootSpeed;
			bool melee = sItem.melee;
			int damage = sItem.damage;
			if (melee)
			{
				if (!melee)
				{
				}
				if (!melee)
				{
					float num = this.meleeSpeed;
				}
			}
			float knockBack = sItem.knockBack;
			if (sItem.useAmmo == 0)
			{
			}
		}

		// Token: 0x0600253F RID: 9535 RVA: 0x00143904 File Offset: 0x00141B04
		public Microsoft.Xna.Framework.Vector2 GetFarthestSpawnPositionOnLine(Microsoft.Xna.Framework.Vector2 startPos, float speedX, float speedY)
		{
			/*
An exception occurred when decompiling this method (0600253F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 Terraria.Player::GetFarthestSpawnPositionOnLine(Microsoft.Xna.Framework.Vector2,System.Single,System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_004D:
	stloc:float32(var_19_57, call:float32(Vector2::Length, ldloc:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](var_18)))
	brtrue(IL_0000, ldloc:int32[exp:bool](var_14_40))
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

		// Token: 0x06002540 RID: 9536 RVA: 0x00143970 File Offset: 0x00141B70
		public int SpawnMinionOnCursor(IEntitySource projectileSource, int ownerIndex, int minionProjectileId, int originalDamageNotScaledByMinionDamage, float KnockBack, [Optional] Microsoft.Xna.Framework.Vector2 offsetFromCursor, [Optional] Microsoft.Xna.Framework.Vector2 velocityOnSpawn)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 mouseWorld = Main.MouseWorld;
			if (num == 0)
			{
			}
			if (projectileSource != null)
			{
			}
			int num2;
			return num2;
		}

		// Token: 0x06002541 RID: 9537 RVA: 0x00143998 File Offset: 0x00141B98
		private Point FindSharpTearsSpot(Microsoft.Xna.Framework.Vector2 targetSpot)
		{
			int num3;
			do
			{
				int num = 1;
				if (num == 0)
				{
				}
				Microsoft.Xna.Framework.Vector2 center = base.Center;
				if (num == 0)
				{
				}
				if (32640 == 0)
				{
				}
				if (!true)
				{
				}
				long num2 = 0L;
				num3 = 8;
				if (num3 == 0)
				{
				}
				bool flag = WorldGen.SolidTile2(0, (int)num2);
				if (num3 == 0)
				{
				}
			}
			while (num3 != 0 || num3 != 0);
			Point point;
			Microsoft.Xna.Framework.Vector2 vector = point.ToVector2();
			Point point2;
			return point2;
		}

		// Token: 0x06002542 RID: 9538 RVA: 0x00143A30 File Offset: 0x00141C30
		private bool FindSharpTearsOpening(int x, int y, bool acceptLeft, bool acceptRight, bool acceptUp, bool acceptDown)
		{
			/*
An exception occurred when decompiling this method (06002542)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::FindSharpTearsOpening(System.Int32,System.Int32,System.Boolean,System.Boolean,System.Boolean,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0033:
	stloc:int64(var_7_34, ldc.i4:int64(0))
	stloc:bool(var_8_3F, call:bool(WorldGen::SolidTile, ldloc:int32(x), ldloc:int32(y), ldloc:int64[exp:bool](var_7_34)))
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

		// Token: 0x06002543 RID: 9539 RVA: 0x00143A84 File Offset: 0x00141C84
		public bool TryPlacingAGolfBallNearANearbyTee(Microsoft.Xna.Framework.Vector2 placePosition)
		{
			/*
An exception occurred when decompiling this method (06002543)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::TryPlacingAGolfBallNearANearbyTee(Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0028:
	stloc:Vector2(var_6_30, callgetter:Vector2(Main::get_screenPosition))
	stloc:int32(var_8_3A, callgetter:int32(Main::get_mouseX))
	stloc:int32(var_10_44, callgetter:int32(Main::get_mouseY))
	stloc:int64(var_11_47, ldc.i4:int64(0))
	stloc:float32(var_14_52, ldfld:float32(Player::gravDir, ldloc:Player(this)))
	stloc:Vector2(var_16_5C, callgetter:Vector2(Main::get_screenPosition))
	stloc:int32(var_18_66, callgetter:int32(Main::get_screenHeight))
	stloc:int32(var_20_70, callgetter:int32(Main::get_mouseY))
	stloc:int32(var_23_76, ldc.i4:int32(1))
	stloc:bool(var_24_83, call:bool(WorldGen::InWorld, ldloc:int32(var_8_3A), ldloc:int64[exp:int32](var_11_47), ldloc:int32(var_23_76)))
	stloc:bool(var_25_93, call:bool(Tile::active, call:Tile[exp:valuetype Terraria.Tile&](Framing::GetTileSafely, ldloc:int32(var_8_3A), ldloc:int64[exp:int32](var_11_47))))
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

		// Token: 0x06002544 RID: 9540 RVA: 0x00143B34 File Offset: 0x00141D34
		public void GetPreferredGolfBallToUse([Out] int projType)
		{
			int num = 721;
			projType.m_value = num;
			Item[] array = this.inventory;
			long num2 = 0L;
			Microsoft.Xna.Framework.Vector2 position = array.position;
			bool flag = this.IsItemSlotUnlockedAndUsable((int)num2);
			Item[] array2 = this.armor;
			Item[] array3 = this.inventory;
		}

		// Token: 0x06002545 RID: 9541 RVA: 0x00143B84 File Offset: 0x00141D84
		private void ItemCheck_MinionAltFeatureUse(Item sItem, bool cShoot)
		{
			int shoot = sItem.shoot;
			if (sItem.shoot != 0)
			{
				int num = this.altFunctionUse;
				if (this.itemTime == 0)
				{
					int useTime = sItem.useTime;
					long num2 = 0L;
					this.itemTime = useTime;
					this.itemTimeMax = useTime;
					this.MinionNPCTargetAim(num2 != 0L);
					return;
				}
			}
		}

		// Token: 0x06002546 RID: 9542 RVA: 0x00143BD0 File Offset: 0x00141DD0
		private void ItemCheck_TurretAltFeatureUse(Item sItem, bool cShoot)
		{
			int shoot = sItem.shoot;
			if (sItem.shoot != 0)
			{
				int num = this.altFunctionUse;
				if (this.itemTime == 0)
				{
					int useTime = sItem.useTime;
					this.itemTime = useTime;
					this.itemTimeMax = useTime;
					if (useTime == 0)
					{
					}
					bool active = sItem.active;
					if (active)
					{
						bool dd2Summon = sItem.DD2Summon;
						if (!active)
						{
						}
						int myPlayer = Main.myPlayer;
						if (!active)
						{
						}
						if (active)
						{
						}
					}
				}
			}
		}

		// Token: 0x06002547 RID: 9543 RVA: 0x00143C40 File Offset: 0x00141E40
		private void EmitMaxManaEffect()
		{
			float x = this.position.X;
			float y = this.position.Y;
			int width = this.width;
			bool wet = this.wet;
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06002548 RID: 9544 RVA: 0x00143C88 File Offset: 0x00141E88
		public Microsoft.Xna.Framework.Vector2? HandPosition
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002548)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Nullable`1<Microsoft.Xna.Framework.Vector2> Terraria.Player::get_HandPosition()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0085:
	stloc:Vector2(var_24_9A, callgetter:Vector2(Player::get_MountedCenter, ldloc:Player(this)))
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

		// Token: 0x06002549 RID: 9545 RVA: 0x000021DB File Offset: 0x000003DB
		private void ItemCheck_EmitHeldItemLight(Item sItem)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600254A RID: 9546 RVA: 0x00143D34 File Offset: 0x00141F34
		public bool CanVisuallyHoldItem(Item item)
		{
			byte holdStyle = item.holdStyle;
			if (this.isPettingAnimal || this.pulley)
			{
				return;
			}
			float num = this.gravDir;
			float y = this.velocity.Y;
			if (!this.mount._active)
			{
				return true;
			}
		}

		// Token: 0x0600254B RID: 9547 RVA: 0x00143D84 File Offset: 0x00141F84
		private void ItemCheck_ApplyHoldStyle(float mountOffset, Item sItem, Rectangle heldItemFrame)
		{
			if (this.isPettingAnimal)
			{
				int direction = this.direction;
				bool flag = this.isTheAnimalBeingPetSmall;
				int num = 3;
				float num2 = this.gravDir;
				this.compositeBackArm = num;
			}
			bool flag2 = this.CanVisuallyHoldItem(sItem);
			byte holdStyle = sItem.holdStyle;
		}

		// Token: 0x0600254C RID: 9548 RVA: 0x001445BC File Offset: 0x001427BC
		private void ItemCheck_ApplyManaRegenDelay(Item sItem)
		{
			if (this.spaceGun)
			{
				int type = sItem.type;
			}
			float num = this.maxRegenDelay;
			this.manaRegenDelay = num;
		}

		// Token: 0x0600254D RID: 9549 RVA: 0x001445E8 File Offset: 0x001427E8
		public Microsoft.Xna.Framework.Vector2 GetFrontHandPosition(Player.CompositeArmStretchAmount stretch, float rotation)
		{
			if (stretch == Player.CompositeArmStretchAmount.Full)
			{
			}
			if (stretch == Player.CompositeArmStretchAmount.Full)
			{
			}
			if (stretch == Player.CompositeArmStretchAmount.Full)
			{
			}
			if (stretch == Player.CompositeArmStretchAmount.Full)
			{
			}
			int direction = this.direction;
			if (direction == 0)
			{
			}
			if (direction == 0)
			{
			}
			if (direction == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 mountedCenter = this.MountedCenter;
			if (direction == 0)
			{
				return;
			}
		}

		// Token: 0x0600254E RID: 9550 RVA: 0x0014462C File Offset: 0x0014282C
		public Microsoft.Xna.Framework.Vector2 GetBackHandPosition(Player.CompositeArmStretchAmount stretch, float rotation)
		{
			if (stretch == Player.CompositeArmStretchAmount.Full)
			{
			}
			int direction = this.direction;
			if (direction == 0)
			{
			}
			int value__ = stretch.value__;
			Microsoft.Xna.Framework.Vector2 mountedCenter = this.MountedCenter;
			if (direction == 0)
			{
				return;
			}
		}

		// Token: 0x0600254F RID: 9551 RVA: 0x00144660 File Offset: 0x00142860
		public void ItemCheck_ApplyUseStyle(float mountOffset, Item sItem, Rectangle heldItemFrame)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				return;
			}
			byte useStyle = sItem.useStyle;
		}

		// Token: 0x06002550 RID: 9552 RVA: 0x001455FC File Offset: 0x001437FC
		public void FlipItemLocationAndRotationForGravity()
		{
			float num = this.gravDir;
			float num2 = this.itemRotation;
			float y = this.position.Y;
			float y2 = this.itemLocation.Y;
			this.itemRotation = num2;
			Microsoft.Xna.Framework.Vector2 bottom = base.Bottom;
			this.itemLocation.Y = num2;
		}

		// Token: 0x06002551 RID: 9553 RVA: 0x0014564C File Offset: 0x0014384C
		private void ItemCheck_StartActualUse(Item sItem)
		{
			int pick = sItem.pick;
			int type = sItem.type;
			int axe = sItem.axe;
			if (type != 0)
			{
				int num = 1;
				this.toolTime = num;
			}
			int[] array = this.grappling;
			bool flag = this.controlRight;
			int num2 = 1;
			this.pulleyDir = (byte)num2;
			bool flag2;
			if (!flag)
			{
				flag2 = this.controlLeft;
				if (!flag2)
				{
					goto IL_005C;
				}
			}
			this.direction = (flag2 ? 1 : 0);
			IL_005C:
			int shoot;
			if (sItem.channel)
			{
				int num3 = 1;
				this.channel = num3 != 0;
				shoot = sItem.shoot;
				this._channelShotCache = shoot;
			}
			this.ResetMeleeHitCooldowns();
			this.ApplyItemAnimation(sItem);
			if (shoot == 0)
			{
			}
			if (shoot == 0 && sItem.UseSound != null)
			{
				Microsoft.Xna.Framework.Vector2 center = base.Center;
				return;
			}
		}

		// Token: 0x06002552 RID: 9554 RVA: 0x00145700 File Offset: 0x00143900
		private void FreeUpPetsAndMinions(Item sItem)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				int whoAmI = this.whoAmI;
				return;
			}
			int whoAmI2 = this.whoAmI;
		}

		// Token: 0x06002553 RID: 9555 RVA: 0x001457B0 File Offset: 0x001439B0
		private void ApplyPotionDelay(Item sItem)
		{
			if (sItem.type == 0)
			{
			}
			bool flag = this.pStone;
			int num;
			this.potionDelay = num;
			if (flag)
			{
				if (!flag)
				{
				}
				this.potionDelay = num;
			}
		}

		// Token: 0x06002554 RID: 9556 RVA: 0x0014582C File Offset: 0x00143A2C
		private void ApplyLifeAndOrMana(Item item)
		{
			int type = item.type;
			int healLife = item.healLife;
			int healMana = item.healMana;
			if (type == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			if (this.whoAmI == 0)
			{
			}
		}

		// Token: 0x06002555 RID: 9557 RVA: 0x00145920 File Offset: 0x00143B20
		private bool ItemCheck_CheckCanUse(Item sItem)
		{
			int num = 1;
			int whoAmI = this.whoAmI;
			if (num == 0)
			{
			}
			int mouseX = Main.mouseX;
			Microsoft.Xna.Framework.Vector2 screenPosition = Main.screenPosition;
			int mouseY = Main.mouseY;
			Microsoft.Xna.Framework.Vector2 screenPosition2 = Main.screenPosition;
			float num2 = this.gravDir;
			if (32768 == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 screenPosition3 = Main.screenPosition;
			int screenHeight = Main.screenHeight;
			int mouseY2 = Main.mouseY;
			int type = sItem.type;
			bool flag = this.extraAccessory;
			if (!flag)
			{
				if (!flag)
				{
				}
				return Main.expertMode;
			}
			if (this.pulley)
			{
				int fishingPole = sItem.fishingPole;
				if (type == 0)
				{
				}
				return false;
			}
			int type2 = sItem.type;
			WiresUI.Settings.MultiToolMode toolMode = WiresUI.Settings.ToolMode;
			int type3 = sItem.type;
			int num3 = 5451;
			int[] array = this.ownedProjectileCounts;
			int num4 = this.wireOperationsCooldown;
			bool flag2 = this.CheckDD2CrystalPaymentLock(sItem);
			int shoot = sItem.shoot;
			if (num3 == 0)
			{
			}
			bool flag3;
			if (num3 != 0)
			{
				flag3 = this.downedDD2EventAnyDifficulty;
				if (!flag3)
				{
					if (!flag3)
					{
						goto IL_0121;
					}
					goto IL_0121;
				}
			}
			if (!flag3)
			{
			}
			if (flag3)
			{
				int myPlayer = Main.myPlayer;
				return Player.WouldSpotOverlapWithSentry(int.MinValue, int.MinValue, false);
			}
			IL_0121:
			if (!flag3)
			{
			}
			if (-2147483648 != 0)
			{
				if (-2147483648 == 0)
				{
				}
				int myPlayer2 = Main.myPlayer;
				return Collision.SolidTiles(42168472, int.MinValue, 0, int.MinValue);
			}
			if (this.wet)
			{
			}
			return NPC.CanReleaseNPCs(this.whoAmI);
		}

		// Token: 0x06002556 RID: 9558 RVA: 0x00145D94 File Offset: 0x00143F94
		private bool ItemCheck_CheckUsabilityOfProjectiles(bool canUse)
		{
			/*
An exception occurred when decompiling this method (06002556)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::ItemCheck_CheckUsabilityOfProjectiles(System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_2_10, ldfld:int32(Entity::whoAmI, ldloc:Player[exp:Entity](this)))
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

		// Token: 0x06002557 RID: 9559 RVA: 0x00145DB4 File Offset: 0x00143FB4
		private bool ItemCheck_CheckFishingBobbers(bool canUse)
		{
			/*
An exception occurred when decompiling this method (06002557)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::ItemCheck_CheckFishingBobbers(System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0007:
	stloc:int32(var_2_0D, ldfld:int32(Entity::whoAmI, ldloc:Player[exp:Entity](this)))
	stloc:int32(var_4_15, callgetter:int32(Main::get_myPlayer))
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

		// Token: 0x06002558 RID: 9560 RVA: 0x00145DE4 File Offset: 0x00143FE4
		private void ItemCheck_CheckFishingBobber_PullBobber(Projectile bobber, int baitTypeUsed)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int whoAmI = this.whoAmI;
			if (num != 0)
			{
				if (num == 0)
				{
				}
				return;
			}
			int num2;
			if (num2 == 0)
			{
			}
			int num3 = 370;
			NPC.SpawnOnPlayer(whoAmI, num3);
			int num4 = 1;
			bobber.netUpdate = num4 != 0;
		}

		// Token: 0x06002559 RID: 9561 RVA: 0x00145E9C File Offset: 0x0014409C
		private void ItemCheck_CheckFishingBobber_PickAndConsumeBait(Projectile bobber, [Out] bool pullTheBobber, [Out] int baitTypeUsed)
		{
			Item[] array = this.inventory;
		}

		// Token: 0x0600255A RID: 9562 RVA: 0x00145F0C File Offset: 0x0014410C
		private static bool ItemCheck_IsValidDirtRodTarget(Tile t)
		{
			return true;
		}

		// Token: 0x0600255B RID: 9563 RVA: 0x00145F20 File Offset: 0x00144120
		private bool ItemCheck_PayMana(Item sItem, bool canUse)
		{
			/*
An exception occurred when decompiling this method (0600255B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::ItemCheck_PayMana(Terraria.Item,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_1:
	call:void(Player::QuickMana, ldloc:Player(this))
	stloc:int32(var_10_6E, ldfld:int32(Player::statMana, ldloc:Player(this)))
	stfld:int32(Player::statMana, ldloc:Player(this), ldloc:int32(var_10_6E))
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

		// Token: 0x0600255C RID: 9564 RVA: 0x00145FA4 File Offset: 0x001441A4
		private void ItemCheck_TryPlacingWearablesOnMannequins(Item sItem)
		{
			if (this.controlUseItem && this.releaseUseItem)
			{
				int headSlot = sItem.headSlot;
				int bodySlot = sItem.bodySlot;
				int legSlot = sItem.legSlot;
				byte useStyle = sItem.useStyle;
				if (useStyle == 0)
				{
				}
				float x = this.position.X;
				if (useStyle == 0)
				{
				}
				int tileRangeX = Player.tileRangeX;
				int tileBoost = sItem.tileBoost;
				int tileTargetX = Player.tileTargetX;
				int num = 15744;
				float x2 = this.position.X;
				int width = this.width;
				if (num == 0)
				{
				}
				int tileRangeX2 = Player.tileRangeX;
				int tileBoost2 = sItem.tileBoost;
				int tileTargetX2 = Player.tileTargetX;
				int num2 = 15744;
				float y = this.position.Y;
				if (num2 == 0)
				{
				}
				int tileRangeY = Player.tileRangeY;
				int tileBoost3 = sItem.tileBoost;
				int tileTargetY = Player.tileTargetY;
				int num3 = 15744;
				float y2 = this.position.Y;
				int height = this.height;
				if (num3 == 0)
				{
				}
				int tileRangeY2 = Player.tileRangeY;
				int tileBoost4 = sItem.tileBoost;
				int tileTargetY2 = Player.tileTargetY;
				if (15744 == 0)
				{
				}
				int tileTargetX3 = Player.tileTargetX;
				int tileTargetY3 = Player.tileTargetY;
				Tile tile;
				bool flag = tile.active();
				Tile tile2;
				ushort type = tile2.type;
				Tile tile3;
				ushort type2 = tile3.type;
				Tile tile4;
				short frameY = tile4.frameY;
				int bodySlot2 = sItem.bodySlot;
				int legSlot2 = sItem.legSlot;
				Tile tile5;
				short frameY2 = tile5.frameY;
				return;
			}
		}

		// Token: 0x0600255D RID: 9565 RVA: 0x00146218 File Offset: 0x00144418
		private void ApplyReuseDelay()
		{
			int num = this.reuseDelay;
			this.itemAnimation = num;
			this.itemTime = num;
		}

		// Token: 0x0600255E RID: 9566 RVA: 0x0014623C File Offset: 0x0014443C
		private void ItemCheck_HackHoldStyles(Item sItem)
		{
			int fishingPole = sItem.fishingPole;
			int num;
			int whoAmI;
			if (this.itemTime == 0)
			{
				num = this.itemAnimation;
				if (num == 0)
				{
					int num2 = 1;
					if (num == 0)
					{
					}
					if (num != 0)
					{
						if (num == 0)
						{
						}
						whoAmI = this.whoAmI;
						if (num == 0)
						{
						}
						if (num != 0)
						{
							sItem.holdStyle = (byte)num2;
						}
					}
				}
			}
			if (num == 0)
			{
			}
			if (num != 0 && this.itemTime == 0)
			{
				int num3 = this.itemAnimation;
				if (num3 == 0)
				{
					int num4 = 1;
					if (num3 == 0)
					{
					}
					int whoAmI2 = this.whoAmI;
					int shoot = sItem.shoot;
					sItem.holdStyle = (byte)num4;
					if (whoAmI == 0)
					{
					}
					long num5 = 0L;
					Microsoft.Xna.Framework.Vector2 center = base.Center;
					this.ChangeDir((int)num5);
				}
			}
		}

		// Token: 0x0600255F RID: 9567 RVA: 0x001462D8 File Offset: 0x001444D8
		private void ItemCheck_HandleMPItemAnimation(Item sItem)
		{
			if (sItem.autoReuse && !this.noItems)
			{
				int num = this.itemAnimation;
				this.releaseUseItem = true;
				int stack = sItem.stack;
				int shoot = sItem.shoot;
				int whoAmI = this.whoAmI;
				int myPlayer = Main.myPlayer;
				if (this.controlUseItem)
				{
					byte useStyle = sItem.useStyle;
					if (sItem.reuseDelay == 0)
					{
						this.ApplyItemAnimation(sItem);
						return;
					}
				}
			}
			this.TryAllowingItemReuse(sItem);
		}

		// Token: 0x06002560 RID: 9568 RVA: 0x0014634C File Offset: 0x0014454C
		private void TryAllowingItemReuse(Item sItem)
		{
			bool summon;
			if (this.autoReuseGlove)
			{
				if (sItem.melee)
				{
					int type = sItem.type;
					return;
				}
				summon = sItem.summon;
				if (!summon || !summon)
				{
				}
			}
			if (this.autoReuseAllWeapons)
			{
				int damage = sItem.damage;
				if (sItem.channel)
				{
					bool flag = this.channel;
					return;
				}
			}
			else if (!summon)
			{
				return;
			}
			int num = 1;
			this.releaseUseItem = num != 0;
		}

		// Token: 0x06002561 RID: 9569 RVA: 0x001463AC File Offset: 0x001445AC
		private void ItemCheck_HandleMount()
		{
			if (this.mount._active)
			{
				int whoAmI = this.whoAmI;
				int myPlayer = Main.myPlayer;
				float num = this.gravDir;
				this.mount.Dismount(this);
				return;
			}
		}

		// Token: 0x06002562 RID: 9570 RVA: 0x0014644C File Offset: 0x0014464C
		public void StartChanneling()
		{
			this.channel = true;
		}

		// Token: 0x06002563 RID: 9571 RVA: 0x00146460 File Offset: 0x00144660
		public void StartChanneling(Item item)
		{
			if (item.channel)
			{
				this.channel = true;
				int shoot = item.shoot;
				this._channelShotCache = shoot;
			}
		}

		// Token: 0x06002564 RID: 9572 RVA: 0x0014648C File Offset: 0x0014468C
		public void TryUpdateChannel(Projectile projectile)
		{
		}

		// Token: 0x06002565 RID: 9573 RVA: 0x0014649C File Offset: 0x0014469C
		public void TryCancelChannel(Projectile projectile)
		{
		}

		// Token: 0x06002566 RID: 9574 RVA: 0x001464AC File Offset: 0x001446AC
		public static bool WouldSpotOverlapWithSentry(int worldX, int worldY, bool lightningAura)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0 || num != 0)
			{
				return;
			}
		}

		// Token: 0x06002567 RID: 9575 RVA: 0x001464D0 File Offset: 0x001446D0
		public void FindSentryRestingSpot(int checkProj, [Out] int worldX, [Out] int worldY, [Out] int pushYUp)
		{
			if (!true)
			{
			}
			Microsoft.Xna.Framework.Vector2 mouseWorld = Main.MouseWorld;
			int num = 8;
			worldX.m_value = num;
			int num2 = 41;
			pushYUp.m_value = num2;
		}

		// Token: 0x06002568 RID: 9576 RVA: 0x00146548 File Offset: 0x00144748
		public void UpdateMaxTurrets()
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
			int whoAmI = this.whoAmI;
		}

		// Token: 0x06002569 RID: 9577 RVA: 0x00146580 File Offset: 0x00144780
		private void ItemCheck_ApplyPetBuffs(Item sItem)
		{
			int num = 1;
			int num2 = sItem.buffType;
			this.CheckForPetAchievement(num2);
			int whoAmI = this.whoAmI;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			int type = sItem.type;
			if (type == 0)
			{
			}
			if (type != 0)
			{
				int num3 = 3600;
				int num4 = 1;
				long num5 = 0L;
				this.AddBuff(num2, num3, num4 != 0, num5 != 0L);
			}
			if (type == 0)
			{
			}
			int myPlayer2 = Main.myPlayer;
			int type2 = sItem.type;
			int num6 = 3600;
			int num7 = 1;
			long num8 = 0L;
			this.AddBuff(num2, num6, num7 != 0, num8 != 0L);
			if (type2 == 0)
			{
			}
			int myPlayer3 = Main.myPlayer;
			int type3 = sItem.type;
			int num9 = 3600;
			int num10 = 1;
			long num11 = 0L;
			this.AddBuff(num2, num9, num10 != 0, num11 != 0L);
			if (type3 == 0)
			{
			}
			int myPlayer4 = Main.myPlayer;
			int type4 = sItem.type;
			int num12 = 3600;
			int num13 = 1;
			long num14 = 0L;
			this.AddBuff(num2, num12, num13 != 0, num14 != 0L);
			if (type4 == 0)
			{
			}
			int myPlayer5 = Main.myPlayer;
			int type5 = sItem.type;
			int num15 = 3600;
			int num16 = 1;
			long num17 = 0L;
			this.AddBuff(num2, num15, num16 != 0, num17 != 0L);
			if (type5 == 0)
			{
			}
			int myPlayer6 = Main.myPlayer;
			int type6 = sItem.type;
			int num18 = 3600;
			int num19 = 1;
			long num20 = 0L;
			this.AddBuff(num2, num18, num19 != 0, num20 != 0L);
			if (type6 == 0)
			{
			}
			int myPlayer7 = Main.myPlayer;
			int type7 = sItem.type;
			int num21 = 3600;
			int num22 = 1;
			long num23 = 0L;
			this.AddBuff(num2, num21, num22 != 0, num23 != 0L);
			if (type7 == 0)
			{
			}
			int myPlayer8 = Main.myPlayer;
			if (sItem.type == 0)
			{
			}
			int num24 = 27;
			long num25 = 0L;
			if (num24 == 0)
			{
			}
			int[] array = this.buffType;
			this.DelBuff((int)num25);
		}

		// Token: 0x0600256A RID: 9578 RVA: 0x00146D3C File Offset: 0x00144F3C
		public float GetWeaponKnockback(Item sItem, float KnockBack)
		{
			/*
An exception occurred when decompiling this method (0600256A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Player::GetWeaponKnockback(Terraria.Item,System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_4:
	stloc:float32(var_4_4A, ldfld:float32(Player::stealth, ldloc:Player(this)))
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

		// Token: 0x0600256B RID: 9579 RVA: 0x00146D94 File Offset: 0x00144F94
		public int GetWeaponCrit(Item sItem)
		{
			int num;
			if (sItem.melee)
			{
				num = this.meleeCrit;
				return num;
			}
			if (sItem.ranged)
			{
				return num;
			}
			if (sItem.magic)
			{
				return num;
			}
		}

		// Token: 0x0600256C RID: 9580 RVA: 0x00146DC8 File Offset: 0x00144FC8
		public int GetWeaponDamage(Item sItem)
		{
			int damage;
			for (;;)
			{
				damage = sItem.damage;
				if (sItem.melee)
				{
					float num = this.meleeDamage;
				}
				bool ranged = sItem.ranged;
				if (ranged)
				{
					float num2 = this.rangedDamage;
					int useAmmo = sItem.useAmmo;
					if (!ranged)
					{
					}
					int useAmmo2 = sItem.useAmmo;
					float num3 = this.rangedDamage;
					float num4 = this.rangedMultDamage;
					float num5 = this.arrowDamageAdditiveStack;
					float num6 = this.arrowDamage;
					int useAmmo3 = sItem.useAmmo;
					if (!ranged)
					{
					}
					int useAmmo4 = sItem.useAmmo;
					float num7 = this.rangedDamage;
					float num8 = this.bulletDamage;
					int useAmmo5 = sItem.useAmmo;
					if (!ranged)
					{
					}
					int useAmmo6 = sItem.useAmmo;
					int useAmmo7 = sItem.useAmmo;
					int useAmmo8 = sItem.useAmmo;
					int useAmmo9 = sItem.useAmmo;
					int useAmmo10 = sItem.useAmmo;
					int useAmmo11 = sItem.useAmmo;
					int useAmmo12 = sItem.useAmmo;
					int useAmmo13 = sItem.useAmmo;
					int useAmmo14 = sItem.useAmmo;
					int useAmmo15 = sItem.useAmmo;
					float num9 = this.rangedDamage;
					float num10 = this.rocketDamage;
					int type = sItem.type;
				}
				if (sItem.magic)
				{
					break;
				}
				if (sItem.summon)
				{
					goto Block_3;
				}
			}
			float num11 = this.magicDamage;
			float num12 = this.rangedDamage;
			float num13 = this.rocketDamage;
			return damage;
			Block_3:
			float num14 = this.minionDamage;
			return damage;
		}

		// Token: 0x0600256D RID: 9581 RVA: 0x00146F00 File Offset: 0x00145100
		public bool HasAmmo(Item sItem, bool canUse)
		{
			/*
An exception occurred when decompiling this method (0600256D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::HasAmmo(Terraria.Item,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Item::useAmmo, ldloc:Item(sItem)))
	stloc:class Terraria.Item[](var_1_0D, ldfld:class Terraria.Item[](Player::inventory, ldloc:Player(this)))
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

		// Token: 0x0600256E RID: 9582 RVA: 0x00146F20 File Offset: 0x00145120
		private bool PickAmmo_TryFindingSpecificMatches(int launcher, int ammo, [Out] int pickedProjectileId)
		{
			if (!true)
			{
			}
			return true;
		}

		// Token: 0x0600256F RID: 9583 RVA: 0x00146F34 File Offset: 0x00145134
		public void PickAmmo(Item sItem, int projToShoot, float speed, bool canShoot, int Damage, float KnockBack, [Out] int usedAmmoItemId, bool dontConsume = false)
		{
			int num = 1;
			int useAmmo = sItem.useAmmo;
			if (num == 0)
			{
			}
			Item[] array = this.inventory;
			int useAmmo2 = sItem.useAmmo;
			Item[] array2 = this.inventory;
			int useAmmo3 = sItem.useAmmo;
		}

		// Token: 0x06002570 RID: 9584 RVA: 0x00147268 File Offset: 0x00145468
		public void GetOtherPlayersPickTile(int x, int y, int pickDamage)
		{
			int num = this.hitTile.HitObject(x, y, 1);
			int num2 = this.hitTile.AddDamage(num, pickDamage, true);
		}

		// Token: 0x06002571 RID: 9585 RVA: 0x00147294 File Offset: 0x00145494
		public void PickTile(int x, int y, int pickPower)
		{
			HitTile hitTile = this.hitTile;
			int num = 1;
			int num2 = hitTile.HitObject(x, y, num);
			Tile tile;
			ushort type = tile.type;
			bool flag = WorldGen.CanKillTile(x, y);
			HitTile hitTile2 = this.hitTile;
			HitTile hitTile3 = this.hitTile;
			int num3 = 1;
			int num5;
			int num4 = hitTile3.AddDamage(num2, num5, num3 != 0);
			if (hitTile3 == null)
			{
			}
			int num6 = 1;
			long num7 = 0L;
			long num8 = 0L;
			WorldGen.KillTile(x, y, num6 != 0, num7 != 0L, num8 != 0L);
			if (hitTile3 == null)
			{
			}
			bool netClient = Main.NetClient;
			if (hitTile3 == null)
			{
			}
			if (hitTile3 == null)
			{
			}
			int myPlayer = Main.myPlayer;
			if (num5 == 0)
			{
				return;
			}
			this.hitTile.Prune();
		}

		// Token: 0x06002572 RID: 9586 RVA: 0x0014746C File Offset: 0x0014566C
		private void ClearMiningCacheAt(int x, int y, int hitTileCacheType)
		{
			this.hitReplace.TryClearingAndPruning(x, y, 1);
			this.hitTile.TryClearingAndPruning(x, y, 1);
		}

		// Token: 0x06002573 RID: 9587 RVA: 0x00147498 File Offset: 0x00145698
		public bool isNearFairy()
		{
			/*
An exception occurred when decompiling this method (06002573)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::isNearFairy()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:Vector2(var_2_0C, callgetter:Vector2(Entity::get_Center, ldloc:Player[exp:Entity](this)))
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

		// Token: 0x06002574 RID: 9588 RVA: 0x001474BC File Offset: 0x001456BC
		public bool isNearNPC(int type, float range = -1f)
		{
			int num = 1;
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
				Microsoft.Xna.Framework.Vector2 center = base.Center;
				return;
			}
		}

		// Token: 0x06002575 RID: 9589 RVA: 0x001474EC File Offset: 0x001456EC
		public bool HasEnoughPickPowerToHurtTile(int x, int y)
		{
			Item[] array = this.inventory;
			long num = 0L;
			if (num != 0L)
			{
			}
			if (num != 0L)
			{
				if (array == null)
				{
				}
				Tile tile;
				ushort type = tile.type;
				HitTile hitTile = this.hitTile;
				int num2 = 1;
				int num3 = hitTile.HitObject(x, y, num2);
				return;
			}
		}

		// Token: 0x06002576 RID: 9590 RVA: 0x00147530 File Offset: 0x00145730
		private int GetPickaxeDamage(int x, int y, int pickPower, int hitBufferIndex, Tile tileTarget)
		{
			if (!true)
			{
			}
			if (100 == 0)
			{
			}
			int num = 199;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int underworldLayer = Main.UnderworldLayer;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				int num2 = 36409;
				if (num == 0)
				{
				}
				if (num == 0)
				{
					goto IL_004A;
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
			}
			int num3 = 21846;
			IL_004A:
			if (num3 == 0)
			{
			}
			if (num3 == 0)
			{
			}
			if (num3 == 0)
			{
			}
			this.hitTile.UpdatePosition(hitBufferIndex, x, y);
			if (num3 == 0)
			{
			}
			if (num3 == 0)
			{
			}
			this.hitTile.UpdatePosition(hitBufferIndex, x, y);
			if (num3 == 0)
			{
			}
			this.hitTile.UpdatePosition(hitBufferIndex, x, y);
			Tile tile;
			short frameX = tile.frameX;
			if (5000 == 0)
			{
				return;
			}
		}

		// Token: 0x06002577 RID: 9591 RVA: 0x001475FC File Offset: 0x001457FC
		private bool DoesPickTargetTransformOnKill(HitTile hitCounter, int damage, int x, int y, int pickPower, int bufferIndex, Tile tileTarget)
		{
			int num = 1;
			long num2 = 0L;
			int num3 = hitCounter.AddDamage(bufferIndex, damage, num2 != 0L);
			if (num == 0)
			{
			}
			if (num != 0)
			{
				return;
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06002578 RID: 9592 RVA: 0x0014762C File Offset: 0x0014582C
		public bool ItemFitsWeaponRack(Item i)
		{
			int fishingPole = i.fishingPole;
			int netID = i.netID;
			int damage = i.damage;
			if (true && i.useStyle != 0)
			{
				int stack = i.stack;
				return;
			}
		}

		// Token: 0x06002579 RID: 9593 RVA: 0x00147664 File Offset: 0x00145864
		public void PlaceWeapon(int x, int y)
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
			Tile tile2;
			ushort type = tile2.type;
			if (num == 0)
			{
			}
			Tile tile3;
			short frameY = tile3.frameY;
			if (num == 0)
			{
			}
			Tile tile4;
			short frameY2 = tile4.frameY;
			if (num == 0)
			{
			}
			Tile tile5;
			short frameY3 = tile5.frameY;
			if (num == 0)
			{
			}
			Tile tile6;
			short frameX = tile6.frameX;
			int num2 = 5000;
			if (36409 == 0)
			{
			}
			Tile tile7;
			short frameX2 = tile7.frameX;
			if (num2 == 0)
			{
			}
			int num3 = 1;
			long num4 = 0L;
			long num5 = 0L;
			WorldGen.KillTile(x, y, num3 != 0, num4 != 0L, num5 != 0L);
			bool netClient = Main.NetClient;
			if (num2 == 0)
			{
			}
			if (num2 == 0)
			{
			}
			bool netClient2 = Main.NetClient;
			if (num2 == 0)
			{
			}
			if (num2 == 0)
			{
			}
			if (num2 == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 position = this.inventory.position;
			Tile tile8;
			tile8.frameX = 0;
			Microsoft.Xna.Framework.Vector2 position2 = this.inventory.position;
			tile8.frameX = 0;
			bool netClientOnly = Main.NetClientOnly;
			if (position2 == null)
			{
			}
			if (position2 == null)
			{
			}
			bool netClientOnly2 = Main.NetClientOnly;
			if (position2 == null)
			{
			}
			Item[] array = this.inventory;
			Microsoft.Xna.Framework.Vector2 position3 = array.position;
			if (position2 == null)
			{
			}
			Item mouseItem = Main.mouseItem;
			long num6 = 0L;
			mouseItem.SetDefaults((int)num6);
			int num7 = this.selectedItem;
			Item[] array2 = this.inventory;
			Item item = mouseItem.Clone();
			if (array == null)
			{
			}
			Main.mouseItem = item;
			int num8 = 1;
			this.mouseInterface = num8 != 0;
		}

		// Token: 0x0600257A RID: 9594 RVA: 0x001477C4 File Offset: 0x001459C4
		public bool ItemFitsItemFrame(Item i)
		{
			/*
An exception occurred when decompiling this method (0600257A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::ItemFitsItemFrame(Terraria.Item)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Item::stack, ldloc:Item(i)))
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

		// Token: 0x0600257B RID: 9595 RVA: 0x001477D8 File Offset: 0x001459D8
		public Microsoft.Xna.Framework.Graphics.Color GetImmuneAlpha(Microsoft.Xna.Framework.Graphics.Color newColor, float alphaReduction)
		{
			/*
An exception occurred when decompiling this method (0600257B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Color Terraria.Player::GetImmuneAlpha(Microsoft.Xna.Framework.Graphics.Color,System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Player::immuneAlpha, ldloc:Player(this)))
	stloc:float32(var_1_0D, ldfld:float32(Player::shimmerTransparency, ldloc:Player(this)))
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

		// Token: 0x0600257C RID: 9596 RVA: 0x001477F4 File Offset: 0x001459F4
		public Microsoft.Xna.Framework.Graphics.Color GetImmuneAlphaPure(Microsoft.Xna.Framework.Graphics.Color newColor, float alphaReduction)
		{
			/*
An exception occurred when decompiling this method (0600257C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Color Terraria.Player::GetImmuneAlphaPure(Microsoft.Xna.Framework.Graphics.Color,System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	stloc:int32(var_0_06, ldfld:int32(Player::immuneAlpha, ldloc:Player(this)))
	stloc:float32(var_1_0D, ldfld:float32(Player::shimmerTransparency, ldloc:Player(this)))
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

		// Token: 0x0600257D RID: 9597 RVA: 0x00147814 File Offset: 0x00145A14
		public Microsoft.Xna.Framework.Graphics.Color GetDeathAlpha(Microsoft.Xna.Framework.Graphics.Color newColor)
		{
			/*
An exception occurred when decompiling this method (0600257D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Color Terraria.Player::GetDeathAlpha(Microsoft.Xna.Framework.Graphics.Color)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Player::immuneAlpha, ldloc:Player(this)))
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

		// Token: 0x0600257E RID: 9598 RVA: 0x00147828 File Offset: 0x00145A28
		public void addDPS(int dmg)
		{
			int num;
			if (this.dpsStarted)
			{
				DateTime now = DateTime.Now;
				num = this.dpsDamage;
				this.dpsLastHit = now;
				this.dpsDamage = num;
				DateTime now2 = DateTime.Now;
				this.dpsEnd = now2;
				return;
			}
			int num2 = 1;
			this.dpsStarted = num2 != 0;
			if (num == 0)
			{
			}
			DateTime now3 = DateTime.Now;
			this.dpsStart = now3;
			DateTime now4 = DateTime.Now;
			this.dpsEnd = now4;
			DateTime now5 = DateTime.Now;
			this.dpsLastHit = now5;
			this.dpsDamage = dmg;
		}

		// Token: 0x0600257F RID: 9599 RVA: 0x001478B8 File Offset: 0x00145AB8
		public void checkDPSTime()
		{
			if (this.dpsStarted)
			{
				DateTime now = DateTime.Now;
				DateTime dateTime = this.dpsLastHit;
				int seconds = (now - dateTime).Seconds;
			}
		}

		// Token: 0x06002580 RID: 9600 RVA: 0x001478EC File Offset: 0x00145AEC
		public int getDPS()
		{
			int num = 1;
			DateTime dateTime = this.dpsEnd;
			DateTime dateTime2 = this.dpsStart;
			if (num == 0)
			{
			}
			int milliseconds = (dateTime - dateTime2).Milliseconds;
			if (17008 == 0)
			{
			}
			DateTime now = DateTime.Now;
			this.dpsStart = now;
			int num2 = this.dpsDamage;
			DateTime dateTime3;
			this.dpsStart = dateTime3;
			int num3 = 32640;
			DateTime dateTime4 = this.dpsEnd;
			this.dpsDamage = num3;
			int milliseconds2 = (dateTime4 - dateTime3).Milliseconds;
			int num4 = this.dpsDamage;
			int num5;
			return num5;
		}

		// Token: 0x06002581 RID: 9601 RVA: 0x00147974 File Offset: 0x00145B74
		public long DropCoins()
		{
			IEntitySource itemSource_Death = this.GetItemSource_Death();
			long num = 0L;
			Item[] array = this.inventory;
			Item[] array2 = this.inventory;
			float x = this.position.X;
			float y = this.position.Y;
			int width = this.width;
			bool wet = this.wet;
			int type = array2.type;
			int num2 = 32640;
			int stack = this.inventory.stack;
			if (num2 == 0)
			{
			}
			bool expertMode = Main.expertMode;
			Item[] array3 = this.inventory;
			if (array3.stack == 0)
			{
			}
			bool masterMode = Main.masterMode;
			Item[] array4 = this.inventory;
			int num3 = 100;
			bool netClientOnly = Main.NetClientOnly;
			Item[] array5 = this.inventory;
			if (num3 == 0)
			{
			}
			Item item;
			Main.mouseItem = item;
			this.lostCoins = num;
			string text = Main.ValueToCoins(num);
			this.lostCoinString = text;
			return num;
		}

		// Token: 0x06002582 RID: 9602 RVA: 0x00147A68 File Offset: 0x00145C68
		public void DropItems()
		{
			IEntitySource itemSource_Death = this.GetItemSource_Death();
			Microsoft.Xna.Framework.Vector2 position = this.inventory.position;
			Microsoft.Xna.Framework.Vector2 position2 = this.inventory.position;
			Microsoft.Xna.Framework.Vector2 position3 = this.armor.position;
			Microsoft.Xna.Framework.Vector2 position4 = this.dye.position;
			Microsoft.Xna.Framework.Vector2 position5 = this.miscEquips.position;
			Microsoft.Xna.Framework.Vector2 position6 = this.miscDyes.position;
			Item[] array = this.Loadouts.Dye;
			Item[] array2 = this.inventory;
			Microsoft.Xna.Framework.Vector2 position7 = array2.position;
			Microsoft.Xna.Framework.Vector2 position8 = this.inventory.position;
			Item[] array3 = this.inventory;
			Microsoft.Xna.Framework.Vector2 velocity = array3.velocity;
			Microsoft.Xna.Framework.Vector2 velocity2 = this.inventory.velocity;
			Item[] array4 = this.inventory;
			Microsoft.Xna.Framework.Vector2 oldPosition = array4.oldPosition;
			Item[] array5 = this.inventory;
			Microsoft.Xna.Framework.Vector2 oldPosition2 = array5.oldPosition;
			if (array5 == null)
			{
			}
			Item mouseItem = Main.mouseItem;
			long num = 0L;
			mouseItem.TurnToAir(num != 0L);
		}

		// Token: 0x06002583 RID: 9603 RVA: 0x00147B6C File Offset: 0x00145D6C
		public void TryDroppingSingleItem(IEntitySource source, Item theItem)
		{
			int stack = theItem.stack;
			float x = this.position.X;
			float y = this.position.Y;
			int width = this.width;
			bool wet = this.wet;
			int type = theItem.type;
			if (32640 == 0)
			{
			}
			int netID = theItem.netID;
			byte prefix = theItem.prefix;
			int stack2 = theItem.stack;
			bool netClient = Main.NetClient;
			int num = 1;
			theItem.TurnToAir(num != 0);
		}

		// Token: 0x06002584 RID: 9604 RVA: 0x00147BF4 File Offset: 0x00145DF4
		public object Clone()
		{
			return base.MemberwiseClone();
		}

		// Token: 0x06002585 RID: 9605 RVA: 0x00147C08 File Offset: 0x00145E08
		public object clientClone(Player clonePlayer)
		{
			/*
An exception occurred when decompiling this method (06002585)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object Terraria.Player::clientClone(Terraria.Player)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_03B4:
	stloc:int32[](var_85_3BA, ldfld:int32[](Player::buffType, ldloc:Player(this)))
	stfld:int32(int32::m_value, ldfld:int32[][exp:int32&](Player::buffType, ldloc:Player(clonePlayer)), ldloc:int32[][exp:int32](var_85_3BA))
	stloc:int32[](var_86_3CF, ldfld:int32[](Player::buffTime, ldloc:Player(this)))
	stfld:int32(int32::m_value, ldfld:int32[][exp:int32&](Player::buffTime, ldloc:Player(clonePlayer)), ldloc:int32[][exp:int32](var_86_3CF))
	stloc:SelectionRadial(var_87_3E4, ldfld:SelectionRadial(Player::DpadRadial, ldloc:Player(this)))
	stloc:SelectionRadial(var_88_3EC, ldfld:SelectionRadial(Player::DpadRadial, ldloc:Player(clonePlayer)))
	call:void(SelectionRadial::CopyTo, ldloc:SelectionRadial(var_87_3E4), ldloc:SelectionRadial(var_88_3EC))
	stloc:SelectionRadial(var_89_3FD, ldfld:SelectionRadial(Player::CircularRadial, ldloc:Player(this)))
	stloc:SelectionRadial(var_90_405, ldfld:SelectionRadial(Player::CircularRadial, ldloc:Player(clonePlayer)))
	call:void(SelectionRadial::CopyTo, ldloc:SelectionRadial(var_89_3FD), ldloc:SelectionRadial(var_90_405))
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

		// Token: 0x06002586 RID: 9606 RVA: 0x00148024 File Offset: 0x00146224
		public void CopyVisuals(Player other)
		{
			int num = other.skinVariant;
			this.skinVariant = num;
			int direction = other.direction;
			this.direction = direction;
			int num2 = other.selectedItem;
			this.selectedItem = num2;
			bool flag = other.extraAccessory;
			this.extraAccessory = flag;
			Microsoft.Xna.Framework.Graphics.Color color = other.skinColor;
			this.skinColor = color;
			Microsoft.Xna.Framework.Graphics.Color color2 = other.eyeColor;
			this.eyeColor = color2;
			int num3 = other.hair;
			this.hair = num3;
			Microsoft.Xna.Framework.Graphics.Color color3 = other.hairColor;
			this.hairColor = color3;
			Microsoft.Xna.Framework.Graphics.Color color4 = other.shirtColor;
			this.shirtColor = color4;
			Microsoft.Xna.Framework.Graphics.Color color5 = other.underShirtColor;
			this.underShirtColor = color5;
			Microsoft.Xna.Framework.Graphics.Color color6 = other.pantsColor;
			this.pantsColor = color6;
			Microsoft.Xna.Framework.Graphics.Color color7 = other.shoeColor;
			this.shoeColor = color7;
			Microsoft.Xna.Framework.Vector2 position = other.position;
			this.position = position;
			Microsoft.Xna.Framework.Vector2 velocity = other.velocity;
			this.velocity = velocity;
			int num4 = other.statLife;
			this.statLife = num4;
			int num5 = other.statLifeMax;
			this.statLifeMax = num5;
			int num6 = other.statLifeMax2;
			this.statLifeMax2 = num6;
			int num7 = other.statMana;
			this.statMana = num7;
			int num8 = other.statManaMax2;
			this.statManaMax2 = num8;
			BitsByte bitsByte = other.hideMisc;
			this.hideMisc = bitsByte;
			Item[] array = other.inventory;
			Item[] array2 = this.inventory;
			Microsoft.Xna.Framework.Vector2 position2 = array.position;
			Item item;
			if (item == null || item != null)
			{
				Item[] array3 = this.armor;
				Microsoft.Xna.Framework.Vector2 position3 = other.armor.position;
				Item item2;
				if (item2 == null || item2 != null)
				{
					Item[] array4 = this.dye;
					Microsoft.Xna.Framework.Vector2 position4 = other.dye.position;
					Item item3;
					if (item3 == null || item3 != null)
					{
						Item[] array5 = this.miscEquips;
						Microsoft.Xna.Framework.Vector2 position5 = other.miscEquips.position;
						Item item4;
						if (item4 == null || item4 != null)
						{
							Item[] array6 = this.miscDyes;
							Microsoft.Xna.Framework.Vector2 position6 = other.miscDyes.position;
							Item item5;
							if (item5 == null || item5 != null)
							{
								bool[] array7 = this.hideVisibleAccessory;
								bool[] array8 = other.hideVisibleAccessory;
								return;
							}
						}
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06002587 RID: 9607 RVA: 0x0014821C File Offset: 0x0014641C
		public Player clientClone()
		{
			BitsByte bitsByte = this.zone1;
			BitsByte bitsByte2 = this.zone2;
			BitsByte bitsByte3 = this.zone3;
			BitsByte bitsByte4 = this.zone4;
			BitsByte bitsByte5 = this.zone5;
			BitsByte bitsByte6 = this.voidVaultInfo;
			float num = this.luck;
			bool flag = this.extraAccessory;
			int minionAttackTargetNPC = this.MinionAttackTargetNPC;
			int direction = this.direction;
			int num2 = this.selectedItem;
			bool flag2 = this.controlUp;
			bool flag3 = this.controlDown;
			bool flag4 = this.controlLeft;
			bool flag5 = this.controlRight;
			bool flag6 = this.controlJump;
			bool flag7 = this.controlUseItem;
			bool flag8 = this.controlDownHold;
			bool flag9 = this.isOperatingAnotherEntity;
			bool flag10 = this.autoReuseAllWeapons;
			int num3 = this.statLifeMax;
			int num4 = this.statManaMax;
			Microsoft.Xna.Framework.Vector2 position = this.position;
			int num5 = this.chest;
			int num6 = this.talkNPC;
			bool <IsTrackingSomething>k__BackingField = this.piggyBankProjTracker.<IsTrackingSomething>k__BackingField;
			int <ProjectileLocalIndex>k__BackingField = this.piggyBankProjTracker.<ProjectileLocalIndex>k__BackingField;
			bool <IsTrackingSomething>k__BackingField2 = this.voidLensChest.<IsTrackingSomething>k__BackingField;
			int <ProjectileLocalIndex>k__BackingField2 = this.voidLensChest.<ProjectileLocalIndex>k__BackingField;
			bool[] array = this.hideVisibleAccessory;
			BitsByte bitsByte7 = this.hideMisc;
			bool flag11 = this.shieldRaised;
			Item[] array2 = this.inventory;
			Microsoft.Xna.Framework.Vector2 position2 = array2.position;
			Item item;
			if (item != null)
			{
				int oldDirection = array2.oldDirection;
				if (item == null)
				{
					goto IL_02F0;
				}
			}
			array2.position = item;
			Item[] array3 = this.armor;
			Microsoft.Xna.Framework.Vector2 position3 = array3.position;
			Item item2;
			if (item2 != null)
			{
				int oldDirection2 = array3.oldDirection;
				if (item2 == null)
				{
					goto IL_02F0;
				}
			}
			array3.position = item2;
			Item[] array4 = this.dye;
			Microsoft.Xna.Framework.Vector2 position4 = array4.position;
			Item item3;
			if (item3 != null)
			{
				int oldDirection3 = array4.oldDirection;
				if (item3 == null)
				{
					goto IL_02F0;
				}
			}
			array4.position = item3;
			Item[] array5 = this.miscEquips;
			Microsoft.Xna.Framework.Vector2 position5 = array5.position;
			Item item4;
			if (item4 != null)
			{
				int oldDirection4 = array5.oldDirection;
				if (item4 == null)
				{
					goto IL_02F0;
				}
			}
			array5.position = item4;
			Item[] array6 = this.miscDyes;
			Microsoft.Xna.Framework.Vector2 position6 = array6.position;
			Item item5;
			if (item5 != null)
			{
				int oldDirection5 = array6.oldDirection;
				if (item5 == null)
				{
					goto IL_02F0;
				}
			}
			array6.position = item5;
			Item[] item6 = this.bank.item;
			Microsoft.Xna.Framework.Vector2 position7 = item6.position;
			Item item7;
			if (item7 != null)
			{
				int oldDirection6 = item6.oldDirection;
				if (item7 == null)
				{
					goto IL_02F0;
				}
			}
			item6.position = item7;
			Item[] item8 = this.bank2.item;
			Microsoft.Xna.Framework.Vector2 position8 = item8.position;
			Item item9;
			if (item9 != null)
			{
				int oldDirection7 = item8.oldDirection;
				if (item9 == null)
				{
					goto IL_02F0;
				}
			}
			item8.position = item9;
			Item[] item10 = this.bank3.item;
			Microsoft.Xna.Framework.Vector2 position9 = item10.position;
			Item item11;
			if (item11 != null)
			{
				int oldDirection8 = item10.oldDirection;
				if (item11 == null)
				{
					goto IL_02F0;
				}
			}
			item10.position = item11;
			Item[] item12 = this.bank4.item;
			Microsoft.Xna.Framework.Vector2 position10 = item12.position;
			Item item13;
			if (item13 != null)
			{
				int oldDirection9 = item12.oldDirection;
				if (item13 == null)
				{
					goto IL_02F0;
				}
			}
			item12.position = item13;
			Item item14 = this.trashItem.Clone();
			if (item12 == null)
			{
			}
			int[] array7 = this.buffType;
			int[] array8 = this.buffTime;
			Player.SelectionRadial dpadRadial = this.DpadRadial;
			Player.SelectionRadial circularRadial = this.CircularRadial;
			IL_02F0:
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06002588 RID: 9608 RVA: 0x00148520 File Offset: 0x00146720
		private void CloneLoadouts(Player clonePlayer)
		{
			long entityId = this.armor.entityId;
			Item[] array = clonePlayer.armor;
			Item item;
			if (item == null || item != null)
			{
				long entityId2 = this.dye.entityId;
				Item[] array2 = clonePlayer.dye;
				Item item2 = item.Clone();
				if (item2 == null || item2 != null)
				{
					Item[] array3 = this.Loadouts.Dye;
					Microsoft.Xna.Framework.Vector2 position = array3.position;
					bool[] hide = clonePlayer.Loadouts.Hide;
					Item item3 = item2.Clone();
					if (item3 == null || item3 != null)
					{
						EquipmentLoadout[] loadouts = this.Loadouts;
						bool[] hide2 = clonePlayer.Loadouts.Hide;
						Item item4 = item3.Clone();
						if (item4 == null || item4 != null)
						{
							EquipmentLoadout[] loadouts2 = this.Loadouts;
							return;
						}
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06002589 RID: 9609 RVA: 0x001485E4 File Offset: 0x001467E4
		public static bool CheckSpawn(int x, int y)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			return Player.CheckSpawn_Internal(int.MinValue, x);
		}

		// Token: 0x0600258A RID: 9610 RVA: 0x00148604 File Offset: 0x00146804
		private static bool CheckSpawn_Internal(int x, int y)
		{
			if (!false)
			{
			}
			long num = 0L;
			if (num == 0L)
			{
			}
			if (num == 0L)
			{
			}
			Tile tile;
			bool isLoaded = tile.IsLoaded;
			Tile tile2;
			bool flag = tile2.active();
			Tile tile3;
			ushort type = tile3.type;
			return WorldGen.StartRoomCheck(0, 43143168);
		}

		// Token: 0x0600258B RID: 9611 RVA: 0x001486BC File Offset: 0x001468BC
		public void FindSpawn()
		{
			if (this.spN == null)
			{
			}
			int[] array = this.spI;
		}

		// Token: 0x0600258C RID: 9612 RVA: 0x00148700 File Offset: 0x00146900
		public void RemoveSpawn()
		{
			if (this.spN == null)
			{
			}
			int[] array = this.spI;
		}

		// Token: 0x0600258D RID: 9613 RVA: 0x00148764 File Offset: 0x00146964
		public void ChangeSpawn(int x, int y)
		{
			int num = 1;
			string[] array = this.spN;
			if (num == 0)
			{
			}
			int[] array2 = this.spI;
			string[] array3 = this.spN;
			int[] array4 = this.spI;
			int[] array5 = this.spX;
			int[] array6 = this.spY;
			string[] array7 = this.spN;
			if (array6 == null)
			{
			}
			int[] array8 = this.spI;
			int[] array9 = this.spX;
			int[] array10 = this.spY;
			this.FindSpawn();
		}

		// Token: 0x0600258E RID: 9614 RVA: 0x00148804 File Offset: 0x00146A04
		public static void UpdateOldMobilePath(PlayerFileData playerFile)
		{
			bool flag = string.IsNullOrEmpty(playerFile._path);
			string path = playerFile._path;
			if (!true)
			{
			}
			string oldPlayerPath = Main.OldPlayerPath;
			bool flag2 = path.StartsWith(oldPlayerPath);
			string path2 = playerFile._path;
			if (!true)
			{
			}
			string oldPlayerPath2 = Main.OldPlayerPath;
			string playerPath = Main.PlayerPath;
			string text = path2.Replace(oldPlayerPath2, playerPath).Replace(".player", ".plr");
			playerFile._path = text;
		}

		// Token: 0x0600258F RID: 9615 RVA: 0x0014887C File Offset: 0x00146A7C
		public static void SavePlayer(PlayerFileData playerFile, bool skipMapSave = false, bool forceSave = false)
		{
			Player player = playerFile._player;
			LocalUser localUser = player.LocalUser;
			if (localUser != null)
			{
				localUser.SavePersistantData();
			}
			if (player == null)
			{
			}
			Player.UpdateOldMobilePath(playerFile);
			if (player == null)
			{
			}
			AchievementManager achievements = Main.Achievements;
			long num = 0L;
			achievements.Save();
			bool isCloudSave = playerFile._isCloudSave;
			if (player == null)
			{
			}
			Player.InternalSaveMap(true, num != 0L);
			if (player == null)
			{
			}
			if (player.DpadRadial != null)
			{
				string text = DateTime.Now.ToString() + " Serverside characters enabled, saving disabled.";
				Debug.Log(text);
				return;
			}
		}

		// Token: 0x06002590 RID: 9616 RVA: 0x00148910 File Offset: 0x00146B10
		private static void InternalSavePlayerFile(PlayerFileData playerFile)
		{
			int num = 1;
			string path = playerFile._path;
			Player player = playerFile._player;
			bool isCloudSave = playerFile._isCloudSave;
			if (num == 0)
			{
			}
			Debug.Log(DateTime.Now.ToString() + " Saving the player");
			if (path == null)
			{
				return;
			}
			bool flag = path == "";
			if ("" == null)
			{
			}
			if ("" != null)
			{
				if ("" == null)
				{
				}
				long num2 = 0L;
				string text = path + ".bak";
				int num3 = 1;
				FileUtilities.Copy(path, text, num2 != 0L, num3 != 0);
			}
			FileMetadata metadata = playerFile.Metadata;
			long num4 = 0L;
			string text2 = player.name;
			byte b = player.difficulty;
			TimeSpan playTime = playerFile.GetPlayTime();
			int num5 = player.hair;
			byte b2 = player.hairDye;
			BitsByte bitsByte = 0;
			long num6 = 0L;
			bool[] array = player.hideVisibleAccessory;
			bitsByte[(int)num6] = num4 != 0L;
			BitsByte bitsByte2 = 0;
			long num7 = 0L;
			bool[] array2 = player.hideVisibleAccessory;
			bitsByte2[(int)num7] = num4 != 0L;
			BitsByte bitsByte3 = player.hideMisc;
			int num8 = player.skinVariant;
			int num9 = player.statLife;
			int num10 = player.statLifeMax;
			int num11 = player.statMana;
			int num12 = player.statManaMax;
			bool flag2 = player.extraAccessory;
			bool flag3 = player.unlockedBiomeTorches;
			if (player.unlockedBiomeTorches)
			{
				int[] array3 = player.builderAccStatus;
				return;
			}
			bool flag4 = player.ateArtisanBread;
			bool flag5 = player.usedAegisCrystal;
			bool flag6 = player.usedAegisFruit;
			bool flag7 = player.usedArcaneCrystal;
			bool flag8 = player.usedGalaxyPearl;
			bool flag9 = player.usedGummyWorm;
			bool flag10 = player.usedAmbrosia;
			bool flag11 = player.downedDD2EventAnyDifficulty;
			int num13 = player.taxMoney;
			int num14 = player.numberOfDeathsPVE;
			int num15 = player.numberOfDeathsPVP;
			byte r = player.hairColor.R;
			byte g = player.hairColor.G;
			byte b3 = player.hairColor.B;
			byte r2 = player.skinColor.R;
			byte g2 = player.skinColor.G;
			byte b4 = player.skinColor.B;
			byte r3 = player.eyeColor.R;
			byte g3 = player.eyeColor.G;
			byte b5 = player.eyeColor.B;
			byte r4 = player.shirtColor.R;
			byte g4 = player.shirtColor.G;
			byte b6 = player.shirtColor.B;
			byte r5 = player.underShirtColor.R;
			byte g5 = player.underShirtColor.G;
			byte b7 = player.underShirtColor.B;
			byte r6 = player.pantsColor.R;
			byte g6 = player.pantsColor.G;
			byte b8 = player.pantsColor.B;
			byte r7 = player.shoeColor.R;
			byte g7 = player.shoeColor.G;
			byte b9 = player.shoeColor.B;
			Item[] array4 = player.armor;
			long entityId = array4.entityId;
			int netID = array4.netID;
			byte prefix = player.armor.prefix;
			Item[] array5 = player.armor;
			Item[] array6 = player.dye;
			long entityId2 = array6.entityId;
			int netID2 = array6.netID;
			byte prefix2 = player.dye.prefix;
			Item[] array7 = player.dye;
			int netID3 = player.inventory.netID;
			int stack = player.inventory.stack;
			byte prefix3 = player.inventory.prefix;
			bool favorited = player.inventory.favorited;
			Item[] array8 = player.miscEquips;
			long entityId3 = array8.entityId;
			int netID4 = array8.netID;
			byte prefix4 = player.miscEquips.prefix;
			int netID5 = player.miscDyes.netID;
			byte prefix5 = player.miscDyes.prefix;
			Item[] array9 = player.miscEquips;
			int netID6 = player.bank.item.netID;
			int stack2 = player.bank.item.stack;
			byte prefix6 = player.bank.item.prefix;
			int netID7 = player.bank2.item.netID;
			int stack3 = player.bank2.item.stack;
			byte prefix7 = player.bank2.item.prefix;
			int netID8 = player.bank3.item.netID;
			int stack4 = player.bank3.item.stack;
			byte prefix8 = player.bank3.item.prefix;
			int netID9 = player.bank4.item.netID;
			int stack5 = player.bank4.item.stack;
			byte prefix9 = player.bank4.item.prefix;
			bool favorited2 = player.bank4.item.favorited;
			BitsByte bitsByte4 = player.voidVaultInfo;
			int[] array10 = player.buffType;
		}

		// Token: 0x06002591 RID: 9617 RVA: 0x0014901C File Offset: 0x0014721C
		private void SaveTemporaryItemSlotContents(BinaryWriter writer)
		{
			if (!true)
			{
			}
			BitsByte bitsByte = 0;
			bool isAir = Main.mouseItem.IsAir;
			Item item;
			bool isAir2 = item.IsAir;
			bool isAir3 = Main.guideItem.IsAir;
			bool isAir4 = Main.reforgeItem.IsAir;
			Item mouseItem = Main.mouseItem;
			Item guideItem = Main.guideItem;
			Item reforgeItem = Main.reforgeItem;
		}

		// Token: 0x06002592 RID: 9618 RVA: 0x00149090 File Offset: 0x00147290
		private void LoadTemporaryItemSlotContents(BinaryReader reader)
		{
			long num = 0L;
			BitsByte bitsByte;
			bool flag = bitsByte[(int)num];
			Item[] temporaryItemSlots = this._temporaryItemSlots;
			Microsoft.Xna.Framework.Vector2 position = this._temporaryItemSlots.position;
			Item[] temporaryItemSlots2 = this._temporaryItemSlots;
			Microsoft.Xna.Framework.Vector2 velocity = this._temporaryItemSlots.velocity;
			Item[] temporaryItemSlots3 = this._temporaryItemSlots;
			Microsoft.Xna.Framework.Vector2 oldPosition = this._temporaryItemSlots.oldPosition;
			Item[] temporaryItemSlots4 = this._temporaryItemSlots;
			Microsoft.Xna.Framework.Vector2 oldVelocity = this._temporaryItemSlots.oldVelocity;
		}

		// Token: 0x06002593 RID: 9619 RVA: 0x00149100 File Offset: 0x00147300
		public void SetPlayerDataToOutOfClassFields()
		{
			Item[] temporaryItemSlots = this._temporaryItemSlots;
			if (temporaryItemSlots.position != null)
			{
			}
			if (temporaryItemSlots == null)
			{
			}
			Item item;
			Main.mouseItem = item;
			Item[] temporaryItemSlots2 = this._temporaryItemSlots;
			if (temporaryItemSlots2.velocity != null)
			{
			}
			if (temporaryItemSlots2 == null)
			{
			}
			bool wet = temporaryItemSlots2.wet;
			Item[] temporaryItemSlots3 = this._temporaryItemSlots;
			if (temporaryItemSlots3.oldPosition != null)
			{
			}
			if (temporaryItemSlots3 == null)
			{
			}
			Item item2;
			Main.guideItem = item2;
			Item[] temporaryItemSlots4 = this._temporaryItemSlots;
			if (temporaryItemSlots4.oldVelocity != null)
			{
			}
			if (temporaryItemSlots4 == null)
			{
			}
			Item item3;
			Main.reforgeItem = item3;
			CreativePowerManager.Instance.ApplyLoadedDataToPlayer(this);
		}

		// Token: 0x06002594 RID: 9620 RVA: 0x00149188 File Offset: 0x00147388
		public static void ClearPlayerTempInfo()
		{
			if (!true)
			{
			}
			Item mouseItem = Main.mouseItem;
			long num = 0L;
			mouseItem.TurnToAir(num != 0L);
			Item guideItem = Main.guideItem;
			long num2 = 0L;
			guideItem.TurnToAir(num2 != 0L);
			Item reforgeItem = Main.reforgeItem;
			long num3 = 0L;
			reforgeItem.TurnToAir(num3 != 0L);
			long num4 = 0L;
			Item item;
			item.TurnToAir(num4 != 0L);
		}

		// Token: 0x06002595 RID: 9621 RVA: 0x001491E4 File Offset: 0x001473E4
		public static void InternalSaveMap(bool isCloudSave, bool forceSave = false)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool flag = string.IsNullOrEmpty(Main.playerPathName);
			if (num == 0)
			{
			}
			string text = DateTime.Now.ToString() + " Saving the map";
			long num2 = 0L;
			Debug.Log(text);
			bool mapEnabled = Main.mapEnabled;
			Main.Map.Save(num2 != 0L);
			FileUtilities.CreateDirectory(Main.PlayerPath);
			string text2 = DateTime.Now.ToString() + " Map saved!";
			Debug.Log(text2);
		}

		// Token: 0x06002596 RID: 9622 RVA: 0x00149280 File Offset: 0x00147480
		public static PlayerFileData LoadTutorialPlayer()
		{
			if (!true)
			{
			}
			long ticks = DateTime.Now.Ticks;
			byte[] bytes = Resources.Load<TextAsset>("Tutorial/Player").bytes;
			long num = 0L;
			BitsByte bitsByte2;
			BitsByte bitsByte = (bitsByte2[(int)num] ? 1 : 0);
			long num2 = 0L;
			BitsByte bitsByte3 = (bitsByte[(int)num2] ? 1 : 0);
			long num3 = 0L;
			bool flag = bitsByte3[(int)num3];
			int myPlayer = Main.myPlayer;
			int myPlayer2 = Main.myPlayer;
			int myPlayer3 = Main.myPlayer;
			int num4 = 1;
			Item item;
			if (item == null || item != null)
			{
				long num5 = 0L;
				BitsByte bitsByte4;
				if (bitsByte4 != null && bitsByte4 == null)
				{
					throw new ArrayTypeMismatchException();
				}
				num5.m_value = bitsByte4;
				int num6;
				if (num4 == 0 && num4 == 0 && num4 == 0 && num4 == 0)
				{
					if (num4 == 0)
					{
						num6 = 135;
						if (num4 == 0)
						{
							return 42167192;
						}
					}
					if (num4 != 0)
					{
						long num7 = DateTime.UtcNow.ToBinary();
					}
					else
					{
						if (num4 != 0)
						{
							return 42167192;
						}
						if (num4 != 0)
						{
							return 42167192;
						}
						if (num4 != 0)
						{
							return 42167192;
						}
						CreativePowerManager instance = CreativePowerManager.Instance;
						if (num4 != 0)
						{
						}
						CreativePowerManager instance2 = CreativePowerManager.Instance;
						goto IL_01BC;
					}
				}
				long num8 = 0L;
				if (42167192 != 0)
				{
					if (num6 != 0)
					{
					}
					return 42167192;
				}
				if (num8 != 0L)
				{
					throw new OutOfMemoryException();
				}
				if (num4 != 0)
				{
					return 42167192;
				}
				long num9 = 0L;
				if (num6 != 0)
				{
				}
				long num10 = 0L;
				long num11;
				if (num9 == 0L)
				{
					num11 = 0L;
				}
				if (num6 != 0)
				{
				}
				if (num10 != 0L)
				{
					throw new OutOfMemoryException();
				}
				if (num11 == 0L)
				{
				}
				long num12 = 0L;
				if (num10 != 0L)
				{
					if (num6 != 0)
					{
					}
					long value = num10.m_value;
				}
				if (num12 == 0L)
				{
					long num13 = 0L;
					if (num6 != 0)
					{
					}
					if (num13 == 0L)
					{
					}
					throw new OutOfMemoryException();
				}
				throw new OutOfMemoryException();
			}
			IL_01BC:
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06002597 RID: 9623 RVA: 0x001494E0 File Offset: 0x001476E0
		public static PlayerFileData LoadPlayer(string playerPath, bool cloudSave)
		{
			long ticks = DateTime.Now.Ticks;
			string oldSavePath = Main.OldSavePath;
			bool flag = oldSavePath.Contains(oldSavePath);
			DrPlatform.DrPlatformType currentPlatform = DrPlatform.CurrentPlatform;
			CreativePowerManager instance = CreativePowerManager.Instance;
			long num = 0L;
			BitsByte bitsByte2;
			BitsByte bitsByte = (bitsByte2[(int)num] ? 1 : 0);
			long num2 = 0L;
			BitsByte bitsByte3 = (bitsByte[(int)num2] ? 1 : 0);
			long num3 = 0L;
			bool flag2 = bitsByte3[(int)num3];
			int myPlayer = Main.myPlayer;
			int myPlayer2 = Main.myPlayer;
			int myPlayer3 = Main.myPlayer;
			int myPlayer4 = Main.myPlayer;
			int myPlayer5 = Main.myPlayer;
			int myPlayer6 = Main.myPlayer;
			int myPlayer7 = Main.myPlayer;
			int num4 = 32;
			Item item;
			if (item == null || item != null)
			{
				int num5 = 22;
				int num6;
				if (num4 == 0)
				{
					while (num5 != 0)
					{
					}
					num6 = 136;
					BitsByte bitsByte4;
					if (num4 == 0 && bitsByte4 != null && bitsByte4 == null)
					{
						throw new ArrayTypeMismatchException();
					}
					if (num4 == 0 && num4 == 0 && num4 == 0 && num4 == 0)
					{
						bitsByte4.value = bitsByte4;
						if (num4 != 0 || num4 == 0)
						{
						}
					}
				}
				long num7 = 0L;
				if (42167192 != 0)
				{
					return 42167192;
				}
				if (num7 == 0L)
				{
					if (num4 == 0)
					{
						int num8 = 170;
						if (42167192 == 0)
						{
							return 42167192;
						}
					}
					else
					{
						long num9 = 0L;
						if (42167192 == 0)
						{
							if (num9 != 0L)
							{
								throw new OutOfMemoryException();
							}
							int num8;
							int num10;
							long num11;
							if (num8 == 0)
							{
								num10 = 171;
								if (num6 == 0)
								{
									return 42167192;
								}
							}
							else
							{
								num11 = 0L;
								if (num6 == 0)
								{
									goto IL_0200;
								}
							}
							int value = num6.m_value;
							IL_0200:
							if (num11 != 0L)
							{
								throw new OutOfMemoryException();
							}
							if (num10 == 0)
							{
								while (num10 != 0)
								{
								}
								while (num10 != 0)
								{
								}
								while (num10 != 0)
								{
								}
								while (num10 != 0)
								{
								}
								while (num10 != 0)
								{
								}
								while (num10 != 0)
								{
								}
								if (num10 != 0 || num10 != 0)
								{
									if (num10 != 0)
									{
										long num12 = DateTime.UtcNow.ToBinary();
									}
									if (num10 != 0)
									{
									}
									if (num10 != 0)
									{
									}
								}
								if (num10 != 0)
								{
								}
								CreativePowerManager instance2 = CreativePowerManager.Instance;
								if (num10 != 0)
								{
								}
								CreativePowerManager instance3 = CreativePowerManager.Instance;
								if (num10 != 0)
								{
								}
								bool flag3;
								BitsByte bitsByte5 = (flag3 ? 1 : 0);
								long num13 = 0L;
								bool flag4 = bitsByte5[(int)num13];
								while (num10 != 0)
								{
								}
								goto IL_02B6;
							}
							throw new OutOfMemoryException();
						}
					}
					return 42167192;
				}
				throw new OutOfMemoryException();
			}
			IL_02B6:
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06002598 RID: 9624 RVA: 0x0014984C File Offset: 0x00147A4C
		private static void AdjustRespawnTimerForWorldJoining(Player newPlayer)
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
			int whoAmI = newPlayer.whoAmI;
			if (newPlayer.dead)
			{
				long num = DateTime.UtcNow.ToBinary();
				if (newPlayer.lastTimePlayerWasSaved == 0L)
				{
				}
				int num2 = newPlayer.respawnTimer;
				int num3 = newPlayer.respawnTimer;
				newPlayer.respawnTimer = num3;
			}
		}

		// Token: 0x06002599 RID: 9625 RVA: 0x001498A4 File Offset: 0x00147AA4
		public void FixLoadedData()
		{
			Item[] array = this.armor;
			Item[] array2 = this.dye;
			Item[] array3 = this.inventory;
			Item[] array4 = this.miscEquips;
			Item[] array5 = this.miscDyes;
			Item[] item = this.bank.item;
			Item[] item2 = this.bank2.item;
			Item[] item3 = this.bank3.item;
			Chest chest = this.bank4;
			Item[] item4 = chest.item;
			Item[] temporaryItemSlots = this._temporaryItemSlots;
			Item[] array6 = this.armor;
			if (chest == null)
			{
			}
			Player.FixLoadedData_EliminiateDuplicateAccessories(array6);
			EquipmentLoadout[] loadouts = this.Loadouts;
			Item[] array7 = loadouts.Dye;
			bool[] hide = loadouts.Hide;
			EquipmentLoadout[] loadouts2 = this.Loadouts;
		}

		// Token: 0x0600259A RID: 9626 RVA: 0x00149950 File Offset: 0x00147B50
		public static void FixLoadedData_EliminiateDuplicateAccessories(Item[] armorArray)
		{
			bool isAir = armorArray.IsAir;
		}

		// Token: 0x0600259B RID: 9627 RVA: 0x0014996C File Offset: 0x00147B6C
		private void FixLoadedData_Items(Item[] items)
		{
			long entityId = items.entityId;
			if (this != null)
			{
				long entityId2 = items.entityId;
			}
		}

		// Token: 0x0600259C RID: 9628 RVA: 0x0014998C File Offset: 0x00147B8C
		private static void LoadPlayer_LastMinuteFixes(Player newPlayer)
		{
			int num = 1;
			int num2 = newPlayer.skinVariant;
			if (num == 0)
			{
			}
			Item[] array = newPlayer.armor;
			int type = array.type;
		}

		// Token: 0x0600259D RID: 9629 RVA: 0x00149A20 File Offset: 0x00147C20
		public static PlayerFileData GetFileData(string file, bool cloudSave)
		{
			for (;;)
			{
				PlayerFileData playerFileData;
				Player player = playerFileData._player;
				if (player == null)
				{
					return;
				}
				int num = player.loadStatus;
				long num2 = 0L;
				string text;
				FileUtilities.Move(text, ".bak", num2 != 0L, true);
				PlayerFileData playerFileData2;
				if (playerFileData2._player == null)
				{
					return;
				}
			}
		}

		// Token: 0x0600259E RID: 9630 RVA: 0x00149A5C File Offset: 0x00147C5C
		public Microsoft.Xna.Framework.Graphics.Color GetHairColor(bool useLighting = true)
		{
			/*
An exception occurred when decompiling this method (0600259E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Color Terraria.Player::GetHairColor(System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_004B:
	stloc:uint8(var_8_51, ldfld:uint8(Player::hairDye, ldloc:Player(this)))
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

		// Token: 0x0600259F RID: 9631 RVA: 0x00149ABC File Offset: 0x00147CBC
		public bool HasItem(int type)
		{
			/*
An exception occurred when decompiling this method (0600259F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::HasItem(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class Terraria.Item[](var_0_06, ldfld:class Terraria.Item[](Player::inventory, ldloc:Player(this)))
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

		// Token: 0x060025A0 RID: 9632 RVA: 0x00149AD8 File Offset: 0x00147CD8
		public bool HasItem(int type, Item[] collection)
		{
			/*
An exception occurred when decompiling this method (060025A0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::HasItem(System.Int32,Terraria.Item[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int64(var_0_06, ldfld:int64(Entity::entityId, ldloc:class Terraria.Item[][exp:Entity](collection)))
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

		// Token: 0x060025A1 RID: 9633 RVA: 0x00149AF4 File Offset: 0x00147CF4
		public bool HasItemInInventoryOrOpenVoidBag(int type)
		{
			/*
An exception occurred when decompiling this method (060025A1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::HasItemInInventoryOrOpenVoidBag(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class Terraria.Item[](var_0_06, ldfld:class Terraria.Item[](Player::inventory, ldloc:Player(this)))
	stloc:int32(var_5_1C, ldfld:int32(Entity::whoAmI, ldloc:class Terraria.Item[][exp:Entity](var_0_06)))
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

		// Token: 0x060025A2 RID: 9634 RVA: 0x00149B24 File Offset: 0x00147D24
		public bool HasItemInAnyInventory(int type)
		{
			/*
An exception occurred when decompiling this method (060025A2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::HasItemInAnyInventory(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int64(var_0_0B, ldfld:int64(Entity::entityId, ldfld:class Terraria.Item[][exp:Entity](Player::inventory, ldloc:Player(this))))
	stloc:int64(var_1_17, ldfld:int64(Entity::entityId, ldfld:class Terraria.Item[][exp:Entity](Player::armor, ldloc:Player(this))))
	stloc:int64(var_2_23, ldfld:int64(Entity::entityId, ldfld:class Terraria.Item[][exp:Entity](Player::dye, ldloc:Player(this))))
	stloc:int64(var_3_2F, ldfld:int64(Entity::entityId, ldfld:class Terraria.Item[][exp:Entity](Player::miscEquips, ldloc:Player(this))))
	stloc:int64(var_4_3B, ldfld:int64(Entity::entityId, ldfld:class Terraria.Item[][exp:Entity](Player::miscDyes, ldloc:Player(this))))
	stloc:int64(var_5_4D, ldfld:int64(Entity::entityId, ldfld:class Terraria.Item[][exp:Entity](Chest::item, ldfld:Chest(Player::bank, ldloc:Player(this)))))
	stloc:int64(var_6_5F, ldfld:int64(Entity::entityId, ldfld:class Terraria.Item[][exp:Entity](Chest::item, ldfld:Chest(Player::bank2, ldloc:Player(this)))))
	stloc:int64(var_7_71, ldfld:int64(Entity::entityId, ldfld:class Terraria.Item[][exp:Entity](Chest::item, ldfld:Chest(Player::bank3, ldloc:Player(this)))))
	stloc:int64(var_8_83, ldfld:int64(Entity::entityId, ldfld:class Terraria.Item[][exp:Entity](Chest::item, ldfld:Chest(Player::bank4, ldloc:Player(this)))))
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

		// Token: 0x060025A3 RID: 9635 RVA: 0x00149BBC File Offset: 0x00147DBC
		public int FindItem(int netid)
		{
			/*
An exception occurred when decompiling this method (060025A3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.Player::FindItem(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class Terraria.Item[](var_0_06, ldfld:class Terraria.Item[](Player::inventory, ldloc:Player(this)))
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

		// Token: 0x060025A4 RID: 9636 RVA: 0x00149BD4 File Offset: 0x00147DD4
		public int FindItem(List<int> netids)
		{
			/*
An exception occurred when decompiling this method (060025A4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.Player::FindItem(System.Collections.Generic.List`1<System.Int32>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class Terraria.Item[](var_1_08, ldfld:class Terraria.Item[](Player::inventory, ldloc:Player(this)))
	stloc:int32(var_2_0F, ldfld:int32(Item::stack, ldloc:class Terraria.Item[][exp:Item](var_1_08)))
	stloc:int32(var_3_16, ldfld:int32(Item::netID, ldloc:class Terraria.Item[][exp:Item](var_1_08)))
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

		// Token: 0x060025A5 RID: 9637 RVA: 0x00149BF8 File Offset: 0x00147DF8
		public int FindItem(bool[] validtypes)
		{
			/*
An exception occurred when decompiling this method (060025A5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.Player::FindItem(System.Boolean[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class Terraria.Item[](var_0_06, ldfld:class Terraria.Item[](Player::inventory, ldloc:Player(this)))
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

		// Token: 0x060025A6 RID: 9638 RVA: 0x00149C10 File Offset: 0x00147E10
		public int FindItem(int type, Item[] collection)
		{
			/*
An exception occurred when decompiling this method (060025A6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.Player::FindItem(System.Int32,Terraria.Item[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int64(var_0_06, ldfld:int64(Entity::entityId, ldloc:class Terraria.Item[][exp:Entity](collection)))
	stloc:class Terraria.Item[](var_1_0D, ldfld:class Terraria.Item[](Player::inventory, ldloc:Player(this)))
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

		// Token: 0x060025A7 RID: 9639 RVA: 0x00149C2C File Offset: 0x00147E2C
		public int FindItemInInventoryOrOpenVoidBag(int type, [Out] bool inVoidBag)
		{
			/*
An exception occurred when decompiling this method (060025A7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.Player::FindItemInInventoryOrOpenVoidBag(System.Int32,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class Terraria.Item[](var_0_06, ldfld:class Terraria.Item[](Player::inventory, ldloc:Player(this)))
	stloc:int64(var_4_22, ldfld:int64(Entity::entityId, ldfld:class Terraria.Item[][exp:Entity](Chest::item, ldfld:Chest(Player::bank4, ldloc:Player(this)))))
	stloc:int32(var_6_28, ldc.i4:int32(1))
	stfld:bool(bool::m_value, ldloc:bool[exp:bool&](inVoidBag), ldloc:int32[exp:bool](var_6_28))
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

		// Token: 0x060025A8 RID: 9640 RVA: 0x00149C6C File Offset: 0x00147E6C
		public Player()
		{
			int num = 1;
			this.lostCoinString = "";
			this.name = "";
			int num2 = 16256;
			this.flameRingScale = (float)num2;
			int num3 = 20352;
			long num4 = 0L;
			this.lifeSteal = (float)num3;
			this.maxMinions = num;
			BitsByte bitsByte = (byte)num4;
			this.zone1 = bitsByte;
			BitsByte bitsByte2 = 0;
			this.zone2 = bitsByte2;
			BitsByte bitsByte3 = 0;
			this.zone3 = bitsByte3;
			BitsByte bitsByte4 = 0;
			this.zone4 = bitsByte4;
			BitsByte bitsByte5 = 0;
			this.zone5 = bitsByte5;
			this.ghostDir = (float)num2;
			this.stealth = (float)num2;
			this.setBonus = "";
			if ("" == null)
			{
			}
			if (!true)
			{
			}
			int num5 = 16256;
			this.stepSpeed = (float)num5;
			BitsByte bitsByte6 = 0;
			this.hideMisc = bitsByte6;
			this.opacityForAnimation = (float)num5;
			this.cursorItemIconText = "";
			this.manaCost = (float)num5;
			int num6 = 100;
			int num7 = 1;
			this.statLife = num6;
			this.gravDir = (float)num5;
			this.enabledSuperCart = num7 != 0;
			int num8 = 4;
			int num9 = 16256;
			this.rangedCrit = num8;
			this.meleeSpeed = (float)num9;
			int num10 = 52429;
			this.runSlowdown = (float)num10;
			this.displayedFishingInfo = "";
			int num11 = 7;
			this.rocketTimeMax = num11;
		}

		// Token: 0x060025A9 RID: 9641 RVA: 0x00149FE8 File Offset: 0x001481E8
		public void MagicConch()
		{
			int num = 1;
			float x = this.position.X;
			if (num == 0)
			{
			}
			if (15744 == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (257 == 0)
			{
			}
			int num2 = 1;
			if (num2 == 0)
			{
			}
			if (num2 == 0)
			{
			}
			int num3 = true.ToDirectionInt();
			if (num2 == 0)
			{
			}
		}

		// Token: 0x060025AA RID: 9642 RVA: 0x0014A098 File Offset: 0x00148298
		public void Shellphone_Spawn()
		{
			if (!true)
			{
			}
			int spawnTileX = Main.spawnTileX;
			int spawnTileY = Main.spawnTileY;
			Player.Spawn_ForceClearArea(43143168, 43143168);
			int width = this.width;
			int height = this.height;
			if (width == 0)
			{
			}
			if (!true)
			{
			}
			this.velocity = 1;
			if (!true)
			{
			}
			bool netHost = Main.NetHost;
			int whoAmI = this.whoAmI;
			float x = this.position.X;
			float y = this.position.Y;
			int whoAmI2 = this.whoAmI;
		}

		// Token: 0x060025AB RID: 9643 RVA: 0x0014A120 File Offset: 0x00148320
		public void DemonConch()
		{
			if (!true)
			{
			}
			int underworldLayer = Main.UnderworldLayer;
			int num = 1;
			if (num != 0 || num != 0 || num != 0)
			{
				if (num == 0)
				{
				}
				if (!true)
				{
				}
				bool netHost = Main.NetHost;
				int whoAmI = this.whoAmI;
				float x = this.position.X;
				float y = this.position.Y;
				int whoAmI2 = this.whoAmI;
				return;
			}
			if (!true)
			{
			}
			bool netHost2 = Main.NetHost;
		}

		// Token: 0x060025AC RID: 9644 RVA: 0x0014A190 File Offset: 0x00148390
		public void TeleportationPotion()
		{
			if (!true)
			{
			}
			int underworldLayer = Main.UnderworldLayer;
			int num = 1;
			if (num != 0)
			{
				if (num == 0)
				{
				}
				if (!true)
				{
				}
				bool netHost = Main.NetHost;
				int whoAmI = this.whoAmI;
				float x = this.position.X;
				float y = this.position.Y;
				int whoAmI2 = this.whoAmI;
				return;
			}
			if (!true)
			{
			}
			bool netHost2 = Main.NetHost;
		}

		// Token: 0x060025AD RID: 9645 RVA: 0x0014A1FC File Offset: 0x001483FC
		public Microsoft.Xna.Framework.Vector2 CheckForGoodTeleportationSpot(bool canSpawn, int teleportStartX, int teleportRangeX, int teleportStartY, int teleportRangeY, Player.RandomTeleportationAttemptSettings settings)
		{
			/*
An exception occurred when decompiling this method (060025AD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 Terraria.Player::CheckForGoodTeleportationSpot(System.Boolean,System.Int32,System.Int32,System.Int32,System.Int32,Terraria.Player/RandomTeleportationAttemptSettings)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_02B3:
	stloc:int32(var_129_2B8, ldc.i4:int32(32768))
	stloc:int32(var_133_2BE, ldc.i4:int32(1))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](var_129_2B8), ldloc:int32(var_133_2BE))
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

		// Token: 0x060025AE RID: 9646 RVA: 0x0014A4D4 File Offset: 0x001486D4
		public void GetAnglerReward(NPC angler, int questItemType)
		{
			int num = this.anglerQuestsFinished;
			if (!true)
			{
			}
			float anglerRewardRarityMultiplier = Player.GetAnglerRewardRarityMultiplier(num);
			double priceAdjustment = this.currentShoppingSettings.PriceAdjustment;
			if (!true)
			{
			}
		}

		// Token: 0x060025AF RID: 9647 RVA: 0x000021DB File Offset: 0x000003DB
		public static float GetAnglerRewardRarityMultiplier(int questsDone)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060025B0 RID: 9648 RVA: 0x0014A504 File Offset: 0x00148704
		private void GetAnglerReward_MainReward(IEntitySource source, int questsDone, float rarityReduction, int questItemType, GetItemSettings anglerRewardSettings)
		{
		}

		// Token: 0x060025B1 RID: 9649 RVA: 0x0014A824 File Offset: 0x00148A24
		private void GetAnglerReward_Decoration(IEntitySource source, int questsDone, float rarityReduction, GetItemSettings anglerRewardSettings)
		{
			if (!true)
			{
			}
			if (17096 == 0)
			{
			}
		}

		// Token: 0x060025B2 RID: 9650 RVA: 0x0014A8A4 File Offset: 0x00148AA4
		private void GetAnglerReward_Bait(IEntitySource source, int questsDone, float rarityReduction, GetItemSettings anglerRewardSettings)
		{
			if (!true)
			{
			}
			if (17096 == 0)
			{
			}
			int num = 32640;
			int num2;
			int num3;
			int num4;
			if (num2 != 0)
			{
				if (num == 0)
				{
				}
				num3 = 32768;
				num4 = 2674;
				return;
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
			if (num4 == 0)
			{
			}
			if (num4 == 0)
			{
			}
			if (num4 == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 center = base.Center;
			int whoAmI = this.whoAmI;
			if (num4 == 0)
			{
			}
			Item item;
			int stack = item.stack;
			float x = this.position.X;
			float y = this.position.Y;
			int width = this.width;
			bool wet = this.wet;
			int type = item.type;
			if (num3 == 0)
			{
			}
			if (32640 == 0)
			{
			}
			bool netClientOnly = Main.NetClientOnly;
		}

		// Token: 0x060025B3 RID: 9651 RVA: 0x0014A984 File Offset: 0x00148B84
		private void GetAnglerReward_Money(IEntitySource source, int questsDone, float rarityReduction, GetItemSettings anglerRewardSettings)
		{
			if (32752 == 0)
			{
			}
			bool expertMode = Main.expertMode;
		}

		// Token: 0x060025B4 RID: 9652 RVA: 0x0014AA30 File Offset: 0x00148C30
		public bool DropAnglerAccByMissing(List<int> itemIdsOfAccsWeWant, float totalChance, [Out] bool botheredRollingForADrop, [Out] int itemIdToDrop)
		{
			long entityId = this.inventory.entityId;
			long entityId2 = this.armor.entityId;
			long entityId3 = this.bank.item.entityId;
			long entityId4 = this.bank2.item.entityId;
			long entityId5 = this.bank3.item.entityId;
			long entityId6 = this.bank4.item.entityId;
			Item[] array = this.Loadouts.Dye;
			Microsoft.Xna.Framework.Vector2 position = array.position;
			EquipmentLoadout[] loadouts = this.Loadouts;
			if (loadouts != null)
			{
				if (loadouts == null)
				{
				}
				int num = 1;
				botheredRollingForADrop.m_value = num != 0;
				if (num == 0)
				{
				}
				if (position == null)
				{
				}
				return;
			}
		}

		// Token: 0x060025B5 RID: 9653 RVA: 0x0014AAF4 File Offset: 0x00148CF4
		private void RemoveAnglerAccOptionsFromRewardPool(List<int> itemIdsOfAccsWeWant, Item itemToTestAgainst)
		{
			bool isAir = itemToTestAgainst.IsAir;
		}

		// Token: 0x060025B6 RID: 9654 RVA: 0x0014AB1C File Offset: 0x00148D1C
		public void GetDyeTraderReward(NPC dyeTrader)
		{
		}

		// Token: 0x060025B7 RID: 9655 RVA: 0x0014ABDC File Offset: 0x00148DDC
		public bool CheckMana(int amount, bool pay = false, bool blockQuickMana = false)
		{
			float num = this.manaCost;
			int num2 = this.statMana;
			if (this.manaFlower)
			{
				this.QuickMana();
				int num3 = this.statMana;
				this.statMana = num3;
			}
			return true;
		}

		// Token: 0x060025B8 RID: 9656 RVA: 0x0014AC14 File Offset: 0x00148E14
		public void TryPortalJumping()
		{
			if (this.mount._active || this.dead || this.sitting != null || this.sleeping != null)
			{
				return;
			}
			PortalHelper.TryGoingThroughPortals(this);
		}

		// Token: 0x060025B9 RID: 9657 RVA: 0x0014AC50 File Offset: 0x00148E50
		public bool ConsumeSolarFlare()
		{
			/*
An exception occurred when decompiling this method (060025B9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player::ConsumeSolarFlare()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_003F:
	stloc:int32(var_7_47, callgetter:int32(Main::get_myPlayer))
	stloc:int32(var_8_4F, ldfld:int32(Player::solarShields, ldloc:Player(this)))
	stloc:int32(var_9_52, ldc.i4:int32(5))
	stloc:int64(var_10_55, ldc.i4:int64(0))
	stloc:int64(var_11_58, ldc.i4:int64(0))
	call:void(Player::AddBuff, ldloc:Player(this), ldloc:int64[exp:int32](var_1), ldloc:int32(var_9_52), ldloc:int64[exp:bool](var_10_55), ldloc:int64[exp:bool](var_11_58))
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

		// Token: 0x060025BA RID: 9658 RVA: 0x0014ACC8 File Offset: 0x00148EC8
		public void KeyDoubleTap(int keyDir)
		{
			if (!true)
			{
			}
			bool reversedUpDownArmorSetBonuses = Main.ReversedUpDownArmorSetBonuses;
			if (this.setVortex && !this.mount._active)
			{
				bool flag = this.vortexStealthActive;
				this.vortexStealthActive = flag;
			}
			if (this.setForbidden)
			{
				this.MinionRestTargetAim();
				if (!this.setForbiddenCooldownLocked)
				{
					this.CommandForbiddenStorm();
				}
			}
			this.holdUpJump = true;
			if (true)
			{
				return;
			}
			this.controlJump = true;
		}

		// Token: 0x060025BB RID: 9659 RVA: 0x0014AD34 File Offset: 0x00148F34
		public void UpdateForbiddenSetLock()
		{
			if (!true)
			{
			}
			int whoAmI = this.whoAmI;
		}

		// Token: 0x060025BC RID: 9660 RVA: 0x0014AD58 File Offset: 0x00148F58
		public void CommandForbiddenStorm()
		{
			if (!true)
			{
			}
			int whoAmI = this.whoAmI;
		}

		// Token: 0x060025BD RID: 9661 RVA: 0x0014AEF0 File Offset: 0x001490F0
		public void KeyHoldDown(int keyDir, int holdTime)
		{
			if (!true)
			{
			}
			bool reversedUpDownArmorSetBonuses = Main.ReversedUpDownArmorSetBonuses;
			bool flag = this.setStardust;
			if (flag)
			{
				if (!flag)
				{
				}
				if (!true)
				{
				}
			}
			bool flag2 = this.setForbidden;
			if (flag2)
			{
				if (!flag2)
				{
				}
				if (!true)
				{
				}
			}
		}

		// Token: 0x060025BE RID: 9662 RVA: 0x0014AF28 File Offset: 0x00149128
		public void MinionNPCTargetAim(bool doNotDisableIfTheTargetIsTheSame)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 mouseWorld = Main.MouseWorld;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int minionAttackTargetNPC = this.MinionAttackTargetNPC;
			this.MinionAttackTargetNPC = minionAttackTargetNPC;
		}

		// Token: 0x060025BF RID: 9663 RVA: 0x0014AF60 File Offset: 0x00149160
		public void MinionRestTargetAim()
		{
			int num = 1;
			if (num == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 mouseWorld = Main.MouseWorld;
			int num2 = 32640;
			Tile tile;
			bool flag = tile.nactive();
			if (num == 0)
			{
			}
			Tile tile2;
			ushort type = tile2.type;
			if (num != 0)
			{
				if (num == 0)
				{
				}
				Tile tile3;
				ushort type2 = tile3.type;
				if (num == 0)
				{
					int num3;
					if (num3 == 0)
					{
					}
					if (num2 == 0)
					{
					}
					Tile tile4;
					bool flag2 = tile4.nactive();
					if (-2147483648 == 0)
					{
					}
					Tile tile5;
					ushort type3 = tile5.type;
					if (-2147483648 != 0)
					{
						if (-2147483648 == 0)
						{
						}
						Tile tile6;
						ushort type4 = tile6.type;
						return;
					}
					return;
				}
			}
			if (65530 == 0)
			{
			}
			bool flag3 = WorldGen.SolidTileAllowBottomSlope(43143168, int.MinValue);
		}

		// Token: 0x060025C0 RID: 9664 RVA: 0x0014B054 File Offset: 0x00149254
		public void UpdateMinionTarget()
		{
			int num = 1;
			int whoAmI = this.whoAmI;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			float x = this.MinionRestTargetPoint.X;
			float y = this.MinionRestTargetPoint.Y;
			if (17530 == 0)
			{
			}
			if (!true)
			{
			}
			int minionAttackTargetNPC = this.MinionAttackTargetNPC;
			if (this.MinionAttackTargetNPC == 0)
			{
			}
			Microsoft.Xna.Framework.Vector2 center = base.Center;
			if (this.stardustGuardian)
			{
				bool hasMinionRestTarget = this.HasMinionRestTarget;
				int num2 = this.miscCounter;
				float x2 = this.MinionRestTargetPoint.X;
				float y2 = this.MinionRestTargetPoint.Y;
				float num3;
				Microsoft.Xna.Framework.Vector2 vector = num3.ToRotationVector2();
				int num4 = this.cPet;
			}
		}

		// Token: 0x060025C1 RID: 9665 RVA: 0x0014B10C File Offset: 0x0014930C
		public void NebulaLevelup(int type)
		{
			int num = 1;
			int whoAmI = this.whoAmI;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			long num2 = 0L;
			if (num == 0)
			{
			}
			int[] array = this.buffType;
			this.DelBuff((int)num2);
		}

		// Token: 0x060025C2 RID: 9666 RVA: 0x000021DB File Offset: 0x000003DB
		public void UpdateTouchingTiles()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060025C3 RID: 9667 RVA: 0x0014B19C File Offset: 0x0014939C
		// Note: this type is marked as 'beforefieldinit'.
		static Player()
		{
			if (!true)
			{
			}
		}

		// Token: 0x04002E46 RID: 11846
		private static float _blizzardSoundVolume;

		// Token: 0x04002E47 RID: 11847
		private static SlotId _strongBlizzardSound;

		// Token: 0x04002E48 RID: 11848
		private static SlotId _insideBlizzardSound;

		// Token: 0x04002E49 RID: 11849
		public static int taxRate;

		// Token: 0x04002E4A RID: 11850
		public const int crystalLeafDamage = 100;

		// Token: 0x04002E4B RID: 11851
		public const int crystalLeafKB = 10;

		// Token: 0x04002E4C RID: 11852
		public const int manaSickTime = 300;

		// Token: 0x04002E4D RID: 11853
		public const int manaSickTimeMax = 600;

		// Token: 0x04002E4E RID: 11854
		public const float manaSickLessDmg = 0.25f;

		// Token: 0x04002E4F RID: 11855
		public const int nameLen = 20;

		// Token: 0x04002E50 RID: 11856
		public static bool deadForGood;

		// Token: 0x04002E51 RID: 11857
		public const float defaultGravity = 0.4f;

		// Token: 0x04002E52 RID: 11858
		public const int defaultItemGrabRange = 42;

		// Token: 0x04002E53 RID: 11859
		private static GameCulture lastArmourCulture;

		// Token: 0x04002E54 RID: 11860
		private static string lastId;

		// Token: 0x04002E55 RID: 11861
		private static string lastFormatId;

		// Token: 0x04002E56 RID: 11862
		private static string lastResult;

		// Token: 0x04002E57 RID: 11863
		private static SmartInteractSystem _smartInteractSys;

		// Token: 0x04002E58 RID: 11864
		private static int[] _torchAttackPosX;

		// Token: 0x04002E59 RID: 11865
		private static int[] _torchAttackPosY;

		// Token: 0x04002E5A RID: 11866
		public static bool requestedSignInfo;

		// Token: 0x04002E5B RID: 11867
		public static int lastRequestSignX;

		// Token: 0x04002E5C RID: 11868
		public static int lastRequestSignY;

		// Token: 0x04002E5D RID: 11869
		private static List<Projectile> _oldestProjCheckList;

		// Token: 0x04002E5E RID: 11870
		public static Player EmptyPlayer;

		// Token: 0x04002E5F RID: 11871
		public int emoteTime;

		// Token: 0x04002E60 RID: 11872
		public CreativeUnlocksTracker creativeTracker;

		// Token: 0x04002E61 RID: 11873
		private static byte[] ENCRYPTION_KEY;

		// Token: 0x04002E62 RID: 11874
		public Player.OverheadMessage chatOverhead;

		// Token: 0x04002E63 RID: 11875
		public Player.SelectionRadial DpadRadial;

		// Token: 0x04002E64 RID: 11876
		public Player.SelectionRadial CircularRadial;

		// Token: 0x04002E65 RID: 11877
		public Player.SelectionRadial QuicksRadial;

		// Token: 0x04002E66 RID: 11878
		public bool alchemyTable;

		// Token: 0x04002E67 RID: 11879
		public int HotbarOffset;

		// Token: 0x04002E68 RID: 11880
		public bool GoingDownWithGrapple;

		// Token: 0x04002E69 RID: 11881
		public byte spelunkerTimer;

		// Token: 0x04002E6A RID: 11882
		public bool[] hideInfo;

		// Token: 0x04002E6B RID: 11883
		public int[] builderAccStatus;

		// Token: 0x04002E6C RID: 11884
		public long lostCoins;

		// Token: 0x04002E6D RID: 11885
		public string lostCoinString;

		// Token: 0x04002E6E RID: 11886
		public int soulDrain;

		// Token: 0x04002E6F RID: 11887
		public float drainBoost;

		// Token: 0x04002E70 RID: 11888
		public bool dd2Accessory;

		// Token: 0x04002E71 RID: 11889
		private static bool disabledBlizzardGraphic;

		// Token: 0x04002E72 RID: 11890
		private static bool disabledBlizzardSound;

		// Token: 0x04002E73 RID: 11891
		public string name;

		// Token: 0x04002E74 RID: 11892
		public int taxMoney;

		// Token: 0x04002E75 RID: 11893
		public int taxTimer;

		// Token: 0x04002E76 RID: 11894
		public int numberOfDeathsPVE;

		// Token: 0x04002E77 RID: 11895
		public int numberOfDeathsPVP;

		// Token: 0x04002E78 RID: 11896
		public float basiliskCharge;

		// Token: 0x04002E79 RID: 11897
		public Microsoft.Xna.Framework.Vector2 lastDeathPostion;

		// Token: 0x04002E7A RID: 11898
		public DateTime lastDeathTime;

		// Token: 0x04002E7B RID: 11899
		public bool showLastDeath;

		// Token: 0x04002E7C RID: 11900
		public bool usedAegisCrystal;

		// Token: 0x04002E7D RID: 11901
		public bool usedAegisFruit;

		// Token: 0x04002E7E RID: 11902
		public bool usedArcaneCrystal;

		// Token: 0x04002E7F RID: 11903
		public bool usedGalaxyPearl;

		// Token: 0x04002E80 RID: 11904
		public bool usedGummyWorm;

		// Token: 0x04002E81 RID: 11905
		public bool usedAmbrosia;

		// Token: 0x04002E82 RID: 11906
		public int extraAccessorySlots;

		// Token: 0x04002E83 RID: 11907
		public int extraAccessorySlotsUse;

		// Token: 0x04002E84 RID: 11908
		public bool extraAccessory;

		// Token: 0x04002E85 RID: 11909
		private bool dontConsumeWand;

		// Token: 0x04002E86 RID: 11910
		public int tankPet;

		// Token: 0x04002E87 RID: 11911
		public bool tankPetReset;

		// Token: 0x04002E88 RID: 11912
		public int stringColor;

		// Token: 0x04002E89 RID: 11913
		public int counterWeight;

		// Token: 0x04002E8A RID: 11914
		public bool yoyoString;

		// Token: 0x04002E8B RID: 11915
		public bool yoyoGlove;

		// Token: 0x04002E8C RID: 11916
		public int beetleOrbs;

		// Token: 0x04002E8D RID: 11917
		public float beetleCounter;

		// Token: 0x04002E8E RID: 11918
		public int beetleCountdown;

		// Token: 0x04002E8F RID: 11919
		public bool beetleDefense;

		// Token: 0x04002E90 RID: 11920
		public bool beetleOffense;

		// Token: 0x04002E91 RID: 11921
		public bool beetleBuff;

		// Token: 0x04002E92 RID: 11922
		public int solarShields;

		// Token: 0x04002E93 RID: 11923
		public int solarCounter;

		// Token: 0x04002E94 RID: 11924
		public const int maxSolarShields = 3;

		// Token: 0x04002E95 RID: 11925
		public Microsoft.Xna.Framework.Vector2[] solarShieldPos;

		// Token: 0x04002E96 RID: 11926
		public Microsoft.Xna.Framework.Vector2[] solarShieldVel;

		// Token: 0x04002E97 RID: 11927
		public bool solarDashing;

		// Token: 0x04002E98 RID: 11928
		public bool solarDashConsumedFlare;

		// Token: 0x04002E99 RID: 11929
		public const int nebulaMaxLevel = 3;

		// Token: 0x04002E9A RID: 11930
		public int nebulaLevelLife;

		// Token: 0x04002E9B RID: 11931
		public int nebulaLevelMana;

		// Token: 0x04002E9C RID: 11932
		public int nebulaManaCounter;

		// Token: 0x04002E9D RID: 11933
		public int nebulaLevelDamage;

		// Token: 0x04002E9E RID: 11934
		public bool manaMagnet;

		// Token: 0x04002E9F RID: 11935
		public bool lifeMagnet;

		// Token: 0x04002EA0 RID: 11936
		public bool treasureMagnet;

		// Token: 0x04002EA1 RID: 11937
		public bool chiselSpeed;

		// Token: 0x04002EA2 RID: 11938
		public bool lifeForce;

		// Token: 0x04002EA3 RID: 11939
		public bool calmed;

		// Token: 0x04002EA4 RID: 11940
		public bool inferno;

		// Token: 0x04002EA5 RID: 11941
		public float flameRingRot;

		// Token: 0x04002EA6 RID: 11942
		public float flameRingScale;

		// Token: 0x04002EA7 RID: 11943
		public byte flameRingFrame;

		// Token: 0x04002EA8 RID: 11944
		public byte flameRingAlpha;

		// Token: 0x04002EA9 RID: 11945
		public int netManaTime;

		// Token: 0x04002EAA RID: 11946
		public int netLifeTime;

		// Token: 0x04002EAB RID: 11947
		public bool netMana;

		// Token: 0x04002EAC RID: 11948
		public bool netLife;

		// Token: 0x04002EAD RID: 11949
		public Microsoft.Xna.Framework.Vector2[] beetlePos;

		// Token: 0x04002EAE RID: 11950
		public Microsoft.Xna.Framework.Vector2[] beetleVel;

		// Token: 0x04002EAF RID: 11951
		public int beetleFrame;

		// Token: 0x04002EB0 RID: 11952
		public int beetleFrameCounter;

		// Token: 0x04002EB1 RID: 11953
		public float manaSickReduction;

		// Token: 0x04002EB2 RID: 11954
		public bool manaSick;

		// Token: 0x04002EB3 RID: 11955
		public int afkCounter;

		// Token: 0x04002EB4 RID: 11956
		public bool stairFall;

		// Token: 0x04002EB5 RID: 11957
		public int loadStatus;

		// Token: 0x04002EB6 RID: 11958
		public Microsoft.Xna.Framework.Vector2[] itemFlamePos;

		// Token: 0x04002EB7 RID: 11959
		public int itemFlameCount;

		// Token: 0x04002EB8 RID: 11960
		public bool outOfRange;

		// Token: 0x04002EB9 RID: 11961
		public float lifeSteal;

		// Token: 0x04002EBA RID: 11962
		public float ghostDmg;

		// Token: 0x04002EBB RID: 11963
		public bool teleporting;

		// Token: 0x04002EBC RID: 11964
		public float teleportTime;

		// Token: 0x04002EBD RID: 11965
		public int teleportStyle;

		// Token: 0x04002EBE RID: 11966
		public bool sloping;

		// Token: 0x04002EBF RID: 11967
		public bool chilled;

		// Token: 0x04002EC0 RID: 11968
		public bool dazed;

		// Token: 0x04002EC1 RID: 11969
		public bool frozen;

		// Token: 0x04002EC2 RID: 11970
		public bool stoned;

		// Token: 0x04002EC3 RID: 11971
		public bool lastStoned;

		// Token: 0x04002EC4 RID: 11972
		public bool ichor;

		// Token: 0x04002EC5 RID: 11973
		public bool webbed;

		// Token: 0x04002EC6 RID: 11974
		public bool tipsy;

		// Token: 0x04002EC7 RID: 11975
		public bool noBuilding;

		// Token: 0x04002EC8 RID: 11976
		public int ropeCount;

		// Token: 0x04002EC9 RID: 11977
		public int manaRegenBonus;

		// Token: 0x04002ECA RID: 11978
		public float manaRegenDelayBonus;

		// Token: 0x04002ECB RID: 11979
		public int dashType;

		// Token: 0x04002ECC RID: 11980
		public int dash;

		// Token: 0x04002ECD RID: 11981
		public int dashTime;

		// Token: 0x04002ECE RID: 11982
		public int timeSinceLastDashStarted;

		// Token: 0x04002ECF RID: 11983
		public int dashDelay;

		// Token: 0x04002ED0 RID: 11984
		public int eocDash;

		// Token: 0x04002ED1 RID: 11985
		public int eocHit;

		// Token: 0x04002ED2 RID: 11986
		public float accRunSpeed;

		// Token: 0x04002ED3 RID: 11987
		public bool cordage;

		// Token: 0x04002ED4 RID: 11988
		public int gem;

		// Token: 0x04002ED5 RID: 11989
		public int gemCount;

		// Token: 0x04002ED6 RID: 11990
		public BitsByte ownedLargeGems;

		// Token: 0x04002ED7 RID: 11991
		public byte meleeEnchant;

		// Token: 0x04002ED8 RID: 11992
		public byte pulleyDir;

		// Token: 0x04002ED9 RID: 11993
		public bool pulley;

		// Token: 0x04002EDA RID: 11994
		public int pulleyFrame;

		// Token: 0x04002EDB RID: 11995
		public float pulleyFrameCounter;

		// Token: 0x04002EDC RID: 11996
		public bool blackBelt;

		// Token: 0x04002EDD RID: 11997
		public bool sliding;

		// Token: 0x04002EDE RID: 11998
		public int slideDir;

		// Token: 0x04002EDF RID: 11999
		public int snowBallLauncherInteractionCooldown;

		// Token: 0x04002EE0 RID: 12000
		public bool iceSkate;

		// Token: 0x04002EE1 RID: 12001
		public bool carpet;

		// Token: 0x04002EE2 RID: 12002
		public int spikedBoots;

		// Token: 0x04002EE3 RID: 12003
		public int carpetFrame;

		// Token: 0x04002EE4 RID: 12004
		public float carpetFrameCounter;

		// Token: 0x04002EE5 RID: 12005
		public bool canCarpet;

		// Token: 0x04002EE6 RID: 12006
		public int carpetTime;

		// Token: 0x04002EE7 RID: 12007
		public int miscCounter;

		// Token: 0x04002EE8 RID: 12008
		public int infernoCounter;

		// Token: 0x04002EE9 RID: 12009
		public int insanityShadowCooldown;

		// Token: 0x04002EEA RID: 12010
		public int starCloakCooldown;

		// Token: 0x04002EEB RID: 12011
		public bool sandStorm;

		// Token: 0x04002EEC RID: 12012
		public bool crimsonRegen;

		// Token: 0x04002EED RID: 12013
		public bool ghostHeal;

		// Token: 0x04002EEE RID: 12014
		public bool ghostHurt;

		// Token: 0x04002EEF RID: 12015
		public bool sticky;

		// Token: 0x04002EF0 RID: 12016
		public bool slippy;

		// Token: 0x04002EF1 RID: 12017
		public bool slippy2;

		// Token: 0x04002EF2 RID: 12018
		public bool powerrun;

		// Token: 0x04002EF3 RID: 12019
		public bool runningOnSand;

		// Token: 0x04002EF4 RID: 12020
		public bool flapSound;

		// Token: 0x04002EF5 RID: 12021
		public bool iceBarrier;

		// Token: 0x04002EF6 RID: 12022
		public bool dangerSense;

		// Token: 0x04002EF7 RID: 12023
		public byte luckPotion;

		// Token: 0x04002EF8 RID: 12024
		public byte oldLuckPotion;

		// Token: 0x04002EF9 RID: 12025
		public float endurance;

		// Token: 0x04002EFA RID: 12026
		public float whipRangeMultiplier;

		// Token: 0x04002EFB RID: 12027
		public float whipUseTimeMultiplier;

		// Token: 0x04002EFC RID: 12028
		public bool loveStruck;

		// Token: 0x04002EFD RID: 12029
		public bool stinky;

		// Token: 0x04002EFE RID: 12030
		public bool resistCold;

		// Token: 0x04002EFF RID: 12031
		public bool electrified;

		// Token: 0x04002F00 RID: 12032
		public bool dryadWard;

		// Token: 0x04002F01 RID: 12033
		public bool panic;

		// Token: 0x04002F02 RID: 12034
		public Item brainOfConfusionItem;

		// Token: 0x04002F03 RID: 12035
		public int brainOfConfusionDodgeAnimationCounter;

		// Token: 0x04002F04 RID: 12036
		public byte iceBarrierFrame;

		// Token: 0x04002F05 RID: 12037
		public byte iceBarrierFrameCounter;

		// Token: 0x04002F06 RID: 12038
		public bool shadowDodge;

		// Token: 0x04002F07 RID: 12039
		public float shadowDodgeCount;

		// Token: 0x04002F08 RID: 12040
		public bool palladiumRegen;

		// Token: 0x04002F09 RID: 12041
		public bool onHitDodge;

		// Token: 0x04002F0A RID: 12042
		public bool onHitRegen;

		// Token: 0x04002F0B RID: 12043
		public bool onHitPetal;

		// Token: 0x04002F0C RID: 12044
		public bool onHitTitaniumStorm;

		// Token: 0x04002F0D RID: 12045
		public int titaniumStormCooldown;

		// Token: 0x04002F0E RID: 12046
		public bool hasTitaniumStormBuff;

		// Token: 0x04002F0F RID: 12047
		public int petalTimer;

		// Token: 0x04002F10 RID: 12048
		public int shadowDodgeTimer;

		// Token: 0x04002F11 RID: 12049
		public int boneGloveTimer;

		// Token: 0x04002F12 RID: 12050
		public int phantomPhoneixCounter;

		// Token: 0x04002F13 RID: 12051
		public int fishingSkill;

		// Token: 0x04002F14 RID: 12052
		public bool cratePotion;

		// Token: 0x04002F15 RID: 12053
		public bool sonarPotion;

		// Token: 0x04002F16 RID: 12054
		public bool accFishingLine;

		// Token: 0x04002F17 RID: 12055
		public bool accFishingBobber;

		// Token: 0x04002F18 RID: 12056
		public bool accTackleBox;

		// Token: 0x04002F19 RID: 12057
		public bool accLavaFishing;

		// Token: 0x04002F1A RID: 12058
		public int maxMinions;

		// Token: 0x04002F1B RID: 12059
		public int numMinions;

		// Token: 0x04002F1C RID: 12060
		public float slotsMinions;

		// Token: 0x04002F1D RID: 12061
		public bool pygmy;

		// Token: 0x04002F1E RID: 12062
		public bool raven;

		// Token: 0x04002F1F RID: 12063
		public bool slime;

		// Token: 0x04002F20 RID: 12064
		public bool hornetMinion;

		// Token: 0x04002F21 RID: 12065
		public bool impMinion;

		// Token: 0x04002F22 RID: 12066
		public bool twinsMinion;

		// Token: 0x04002F23 RID: 12067
		public bool spiderMinion;

		// Token: 0x04002F24 RID: 12068
		public int nextCycledSpiderMinionType;

		// Token: 0x04002F25 RID: 12069
		public bool pirateMinion;

		// Token: 0x04002F26 RID: 12070
		public bool sharknadoMinion;

		// Token: 0x04002F27 RID: 12071
		public bool UFOMinion;

		// Token: 0x04002F28 RID: 12072
		public bool DeadlySphereMinion;

		// Token: 0x04002F29 RID: 12073
		public bool stardustMinion;

		// Token: 0x04002F2A RID: 12074
		public bool stardustGuardian;

		// Token: 0x04002F2B RID: 12075
		public bool stardustDragon;

		// Token: 0x04002F2C RID: 12076
		public bool batsOfLight;

		// Token: 0x04002F2D RID: 12077
		public bool babyBird;

		// Token: 0x04002F2E RID: 12078
		public bool vampireFrog;

		// Token: 0x04002F2F RID: 12079
		public bool stormTiger;

		// Token: 0x04002F30 RID: 12080
		public int highestStormTigerGemOriginalDamage;

		// Token: 0x04002F31 RID: 12081
		public bool smolstar;

		// Token: 0x04002F32 RID: 12082
		public bool empressBlade;

		// Token: 0x04002F33 RID: 12083
		public bool flinxMinion;

		// Token: 0x04002F34 RID: 12084
		public bool abigailMinion;

		// Token: 0x04002F35 RID: 12085
		public int highestAbigailCounterOriginalDamage;

		// Token: 0x04002F36 RID: 12086
		public float wingTime;

		// Token: 0x04002F37 RID: 12087
		public int wings;

		// Token: 0x04002F38 RID: 12088
		public int wingsLogic;

		// Token: 0x04002F39 RID: 12089
		public int wingTimeMax;

		// Token: 0x04002F3A RID: 12090
		public int wingFrame;

		// Token: 0x04002F3B RID: 12091
		public int wingFrameCounter;

		// Token: 0x04002F3C RID: 12092
		public int skinVariant;

		// Token: 0x04002F3D RID: 12093
		public bool ghost;

		// Token: 0x04002F3E RID: 12094
		public int ghostFrame;

		// Token: 0x04002F3F RID: 12095
		public int ghostFrameCounter;

		// Token: 0x04002F40 RID: 12096
		public int miscTimer;

		// Token: 0x04002F41 RID: 12097
		public int environmentBuffImmunityTimer;

		// Token: 0x04002F42 RID: 12098
		public int _framesLeftEligibleForDeadmansChestDeathAchievement;

		// Token: 0x04002F43 RID: 12099
		public bool pvpDeath;

		// Token: 0x04002F44 RID: 12100
		public BitsByte zone1;

		// Token: 0x04002F45 RID: 12101
		public BitsByte zone2;

		// Token: 0x04002F46 RID: 12102
		public BitsByte zone3;

		// Token: 0x04002F47 RID: 12103
		public BitsByte zone4;

		// Token: 0x04002F48 RID: 12104
		public BitsByte zone5;

		// Token: 0x04002F49 RID: 12105
		private bool _wasInShimmerZone;

		// Token: 0x04002F4A RID: 12106
		public bool boneArmor;

		// Token: 0x04002F4B RID: 12107
		public bool frostArmor;

		// Token: 0x04002F4C RID: 12108
		public bool honey;

		// Token: 0x04002F4D RID: 12109
		public bool crystalLeaf;

		// Token: 0x04002F4E RID: 12110
		public int crystalLeafCooldown;

		// Token: 0x04002F4F RID: 12111
		public PortableStoolUsage portableStoolInfo;

		// Token: 0x04002F50 RID: 12112
		public bool preventAllItemPickups;

		// Token: 0x04002F51 RID: 12113
		public bool dontHurtCritters;

		// Token: 0x04002F52 RID: 12114
		public bool hasLucyTheAxe;

		// Token: 0x04002F53 RID: 12115
		public bool dontHurtNature;

		// Token: 0x04002F54 RID: 12116
		public int[] doubleTapCardinalTimer;

		// Token: 0x04002F55 RID: 12117
		public int[] holdDownCardinalTimer;

		// Token: 0x04002F56 RID: 12118
		public bool defendedByPaladin;

		// Token: 0x04002F57 RID: 12119
		public bool hasPaladinShield;

		// Token: 0x04002F58 RID: 12120
		public float[] speedSlice;

		// Token: 0x04002F59 RID: 12121
		public float townNPCs;

		// Token: 0x04002F5A RID: 12122
		public double headFrameCounter;

		// Token: 0x04002F5B RID: 12123
		public double bodyFrameCounter;

		// Token: 0x04002F5C RID: 12124
		public double legFrameCounter;

		// Token: 0x04002F5D RID: 12125
		public int netSkip;

		// Token: 0x04002F5E RID: 12126
		public int oldSelectItem;

		// Token: 0x04002F5F RID: 12127
		public bool immune;

		// Token: 0x04002F60 RID: 12128
		public bool immuneNoBlink;

		// Token: 0x04002F61 RID: 12129
		public int immuneTime;

		// Token: 0x04002F62 RID: 12130
		public int immuneAlphaDirection;

		// Token: 0x04002F63 RID: 12131
		public int immuneAlpha;

		// Token: 0x04002F64 RID: 12132
		public int team;

		// Token: 0x04002F65 RID: 12133
		private int _timeSinceLastImmuneGet;

		// Token: 0x04002F66 RID: 12134
		private int _immuneStrikes;

		// Token: 0x04002F67 RID: 12135
		public bool hbLocked;

		// Token: 0x04002F68 RID: 12136
		public float maxRegenDelay;

		// Token: 0x04002F69 RID: 12137
		public int sign;

		// Token: 0x04002F6A RID: 12138
		public bool editedChestName;

		// Token: 0x04002F6B RID: 12139
		public int reuseDelay;

		// Token: 0x04002F6C RID: 12140
		public int aggro;

		// Token: 0x04002F6D RID: 12141
		public float nearbyActiveNPCs;

		// Token: 0x04002F6E RID: 12142
		public bool creativeInterface;

		// Token: 0x04002F6F RID: 12143
		public bool mouseInterface;

		// Token: 0x04002F70 RID: 12144
		public bool lastMouseInterface;

		// Token: 0x04002F71 RID: 12145
		public int noThrow;

		// Token: 0x04002F72 RID: 12146
		public int changeItem;

		// Token: 0x04002F73 RID: 12147
		public int lastHotbarItem;

		// Token: 0x04002F74 RID: 12148
		public int selectedItem;

		// Token: 0x04002F75 RID: 12149
		public const int SupportedSlotsArmor = 3;

		// Token: 0x04002F76 RID: 12150
		public const int SupportedSlotsAccs = 7;

		// Token: 0x04002F77 RID: 12151
		public const int SupportedSlotSets = 10;

		// Token: 0x04002F78 RID: 12152
		public const int InitialAccSlotCount = 5;

		// Token: 0x04002F79 RID: 12153
		public const int miscSlotPet = 0;

		// Token: 0x04002F7A RID: 12154
		public const int miscSlotLight = 1;

		// Token: 0x04002F7B RID: 12155
		public const int miscSlotCart = 2;

		// Token: 0x04002F7C RID: 12156
		public const int miscSlotMount = 3;

		// Token: 0x04002F7D RID: 12157
		public const int miscSlotHook = 4;

		// Token: 0x04002F7E RID: 12158
		public const int SupportedMiscSlotCount = 5;

		// Token: 0x04002F7F RID: 12159
		public Item[] armor;

		// Token: 0x04002F80 RID: 12160
		public Item[] dye;

		// Token: 0x04002F81 RID: 12161
		public Item[] miscEquips;

		// Token: 0x04002F82 RID: 12162
		public Item[] miscDyes;

		// Token: 0x04002F83 RID: 12163
		public Item trashItem;

		// Token: 0x04002F84 RID: 12164
		public float itemRotation;

		// Token: 0x04002F85 RID: 12165
		public int itemWidth;

		// Token: 0x04002F86 RID: 12166
		public int itemHeight;

		// Token: 0x04002F87 RID: 12167
		public Microsoft.Xna.Framework.Vector2 itemLocation;

		// Token: 0x04002F88 RID: 12168
		public bool poundRelease;

		// Token: 0x04002F89 RID: 12169
		public float ghostFade;

		// Token: 0x04002F8A RID: 12170
		public float ghostDir;

		// Token: 0x04002F8B RID: 12171
		public static readonly int maxBuffs;

		// Token: 0x04002F8C RID: 12172
		public int[] buffType;

		// Token: 0x04002F8D RID: 12173
		public int[] buffTime;

		// Token: 0x04002F8E RID: 12174
		public bool[] buffImmune;

		// Token: 0x04002F8F RID: 12175
		public int heldProj;

		// Token: 0x04002F90 RID: 12176
		public int breathCD;

		// Token: 0x04002F91 RID: 12177
		public int breathMax;

		// Token: 0x04002F92 RID: 12178
		public int breath;

		// Token: 0x04002F93 RID: 12179
		public int lavaCD;

		// Token: 0x04002F94 RID: 12180
		public int lavaMax;

		// Token: 0x04002F95 RID: 12181
		public int lavaTime;

		// Token: 0x04002F96 RID: 12182
		public bool ignoreWater;

		// Token: 0x04002F97 RID: 12183
		public bool armorEffectDrawShadow;

		// Token: 0x04002F98 RID: 12184
		public bool armorEffectDrawShadowSubtle;

		// Token: 0x04002F99 RID: 12185
		public bool armorEffectDrawOutlines;

		// Token: 0x04002F9A RID: 12186
		public bool armorEffectDrawShadowLokis;

		// Token: 0x04002F9B RID: 12187
		public bool armorEffectDrawShadowBasilisk;

		// Token: 0x04002F9C RID: 12188
		public bool armorEffectDrawOutlinesForbidden;

		// Token: 0x04002F9D RID: 12189
		public bool armorEffectDrawShadowEOCShield;

		// Token: 0x04002F9E RID: 12190
		public bool socialShadowRocketBoots;

		// Token: 0x04002F9F RID: 12191
		public bool socialGhost;

		// Token: 0x04002FA0 RID: 12192
		public bool shroomiteStealth;

		// Token: 0x04002FA1 RID: 12193
		public bool ashWoodBonus;

		// Token: 0x04002FA2 RID: 12194
		public bool socialIgnoreLight;

		// Token: 0x04002FA3 RID: 12195
		public int stealthTimer;

		// Token: 0x04002FA4 RID: 12196
		public float stealth;

		// Token: 0x04002FA5 RID: 12197
		public int beardGrowthTimer;

		// Token: 0x04002FA6 RID: 12198
		public bool isDisplayDollOrInanimate;

		// Token: 0x04002FA7 RID: 12199
		public bool isFullbright;

		// Token: 0x04002FA8 RID: 12200
		public bool isHatRackDoll;

		// Token: 0x04002FA9 RID: 12201
		public bool isFirstFractalAfterImage;

		// Token: 0x04002FAA RID: 12202
		public float firstFractalAfterImageOpacity;

		// Token: 0x04002FAB RID: 12203
		public string setBonus;

		// Token: 0x04002FAC RID: 12204
		public Item[] inventory;

		// Token: 0x04002FAD RID: 12205
		public bool[] inventoryChestStack;

		// Token: 0x04002FAE RID: 12206
		public Item lastVisualizedSelectedItem;

		// Token: 0x04002FAF RID: 12207
		public Chest bank;

		// Token: 0x04002FB0 RID: 12208
		public Chest bank2;

		// Token: 0x04002FB1 RID: 12209
		public Chest bank3;

		// Token: 0x04002FB2 RID: 12210
		public Chest bank4;

		// Token: 0x04002FB3 RID: 12211
		public BitsByte voidVaultInfo;

		// Token: 0x04002FB4 RID: 12212
		public float headRotation;

		// Token: 0x04002FB5 RID: 12213
		public float bodyRotation;

		// Token: 0x04002FB6 RID: 12214
		public float legRotation;

		// Token: 0x04002FB7 RID: 12215
		public Microsoft.Xna.Framework.Vector2 headPosition;

		// Token: 0x04002FB8 RID: 12216
		public Microsoft.Xna.Framework.Vector2 bodyPosition;

		// Token: 0x04002FB9 RID: 12217
		public Microsoft.Xna.Framework.Vector2 legPosition;

		// Token: 0x04002FBA RID: 12218
		public Microsoft.Xna.Framework.Vector2 headVelocity;

		// Token: 0x04002FBB RID: 12219
		public Microsoft.Xna.Framework.Vector2 bodyVelocity;

		// Token: 0x04002FBC RID: 12220
		public Microsoft.Xna.Framework.Vector2 legVelocity;

		// Token: 0x04002FBD RID: 12221
		public float fullRotation;

		// Token: 0x04002FBE RID: 12222
		public Microsoft.Xna.Framework.Vector2 fullRotationOrigin;

		// Token: 0x04002FBF RID: 12223
		public int fartKartCloudDelay;

		// Token: 0x04002FC0 RID: 12224
		public const int fartKartCloudDelayMax = 20;

		// Token: 0x04002FC1 RID: 12225
		public int nonTorch;

		// Token: 0x04002FC2 RID: 12226
		public float gfxOffY;

		// Token: 0x04002FC3 RID: 12227
		public float stepSpeed;

		// Token: 0x04002FC4 RID: 12228
		public bool dead;

		// Token: 0x04002FC5 RID: 12229
		public int respawnTimer;

		// Token: 0x04002FC6 RID: 12230
		public const int respawnTimerMax = 3600;

		// Token: 0x04002FC7 RID: 12231
		public long lastTimePlayerWasSaved;

		// Token: 0x04002FC8 RID: 12232
		public int attackCD;

		// Token: 0x04002FC9 RID: 12233
		public int potionDelay;

		// Token: 0x04002FCA RID: 12234
		public byte difficulty;

		// Token: 0x04002FCB RID: 12235
		public byte wetSlime;

		// Token: 0x04002FCC RID: 12236
		public HitTile hitTile;

		// Token: 0x04002FCD RID: 12237
		public HitTile hitReplace;

		// Token: 0x04002FCE RID: 12238
		public float startJumpY;

		// Token: 0x04002FCF RID: 12239
		public bool jumping;

		// Token: 0x04002FD0 RID: 12240
		public int jump;

		// Token: 0x04002FD1 RID: 12241
		public int head;

		// Token: 0x04002FD2 RID: 12242
		public int body;

		// Token: 0x04002FD3 RID: 12243
		public int legs;

		// Token: 0x04002FD4 RID: 12244
		public sbyte handon;

		// Token: 0x04002FD5 RID: 12245
		public sbyte handoff;

		// Token: 0x04002FD6 RID: 12246
		public sbyte back;

		// Token: 0x04002FD7 RID: 12247
		public sbyte front;

		// Token: 0x04002FD8 RID: 12248
		public sbyte shoe;

		// Token: 0x04002FD9 RID: 12249
		public sbyte waist;

		// Token: 0x04002FDA RID: 12250
		public sbyte shield;

		// Token: 0x04002FDB RID: 12251
		public sbyte neck;

		// Token: 0x04002FDC RID: 12252
		public sbyte face;

		// Token: 0x04002FDD RID: 12253
		public sbyte balloon;

		// Token: 0x04002FDE RID: 12254
		public sbyte backpack;

		// Token: 0x04002FDF RID: 12255
		public sbyte tail;

		// Token: 0x04002FE0 RID: 12256
		public sbyte faceHead;

		// Token: 0x04002FE1 RID: 12257
		public sbyte faceFlower;

		// Token: 0x04002FE2 RID: 12258
		public sbyte balloonFront;

		// Token: 0x04002FE3 RID: 12259
		public sbyte beard;

		// Token: 0x04002FE4 RID: 12260
		public bool[] hideVisibleAccessory;

		// Token: 0x04002FE5 RID: 12261
		public BitsByte hideMisc;

		// Token: 0x04002FE6 RID: 12262
		public Rectangle headFrame;

		// Token: 0x04002FE7 RID: 12263
		public Rectangle bodyFrame;

		// Token: 0x04002FE8 RID: 12264
		public Rectangle legFrame;

		// Token: 0x04002FE9 RID: 12265
		public Rectangle hairFrame;

		// Token: 0x04002FEA RID: 12266
		public Player.DirectionalInputSyncCache LocalInputCache;

		// Token: 0x04002FEB RID: 12267
		public bool blockUseItem;

		// Token: 0x04002FEC RID: 12268
		public bool holdUpJump;

		// Token: 0x04002FED RID: 12269
		private bool rewsing;

		// Token: 0x04002FEE RID: 12270
		public short InitialItemUsing;

		// Token: 0x04002FEF RID: 12271
		public bool disableUseUntilRelease;

		// Token: 0x04002FF0 RID: 12272
		public bool controlLeft;

		// Token: 0x04002FF1 RID: 12273
		public bool controlRight;

		// Token: 0x04002FF2 RID: 12274
		public bool controlUp;

		// Token: 0x04002FF3 RID: 12275
		public bool controlDown;

		// Token: 0x04002FF4 RID: 12276
		public bool controlJump;

		// Token: 0x04002FF5 RID: 12277
		public bool controlUseItem;

		// Token: 0x04002FF6 RID: 12278
		public bool controlUseTile;

		// Token: 0x04002FF7 RID: 12279
		public bool controlThrow;

		// Token: 0x04002FF8 RID: 12280
		public bool controlInv;

		// Token: 0x04002FF9 RID: 12281
		public bool controlHook;

		// Token: 0x04002FFA RID: 12282
		public bool controlTorch;

		// Token: 0x04002FFB RID: 12283
		public bool controlMap;

		// Token: 0x04002FFC RID: 12284
		public bool controlSmart;

		// Token: 0x04002FFD RID: 12285
		public bool controlMount;

		// Token: 0x04002FFE RID: 12286
		public bool releaseJump;

		// Token: 0x04002FFF RID: 12287
		public bool releaseUp;

		// Token: 0x04003000 RID: 12288
		public bool releaseUseItem;

		// Token: 0x04003001 RID: 12289
		public bool releaseUseTile;

		// Token: 0x04003002 RID: 12290
		public bool releaseInventory;

		// Token: 0x04003003 RID: 12291
		public bool releaseHook;

		// Token: 0x04003004 RID: 12292
		public bool releaseThrow;

		// Token: 0x04003005 RID: 12293
		public bool releaseQuickMana;

		// Token: 0x04003006 RID: 12294
		public bool releaseQuickHeal;

		// Token: 0x04003007 RID: 12295
		public bool releaseLeft;

		// Token: 0x04003008 RID: 12296
		public bool releaseRight;

		// Token: 0x04003009 RID: 12297
		public bool releaseSmart;

		// Token: 0x0400300A RID: 12298
		public bool releaseMount;

		// Token: 0x0400300B RID: 12299
		public bool releaseDown;

		// Token: 0x0400300C RID: 12300
		public bool controlQuickMana;

		// Token: 0x0400300D RID: 12301
		public bool controlQuickHeal;

		// Token: 0x0400300E RID: 12302
		public bool controlCreativeMenu;

		// Token: 0x0400300F RID: 12303
		public bool releaseCreativeMenu;

		// Token: 0x04003010 RID: 12304
		public bool controlQuickBuff;

		// Token: 0x04003011 RID: 12305
		public bool controlFireRelease;

		// Token: 0x04003012 RID: 12306
		public bool controlFire;

		// Token: 0x04003013 RID: 12307
		public bool controlInteractionRelease;

		// Token: 0x04003014 RID: 12308
		public bool controlInteraction;

		// Token: 0x04003015 RID: 12309
		public bool controlLayout1;

		// Token: 0x04003016 RID: 12310
		public bool controlLayout2;

		// Token: 0x04003017 RID: 12311
		public bool controlLayout3;

		// Token: 0x04003018 RID: 12312
		public bool controlLayoutCycle;

		// Token: 0x04003019 RID: 12313
		public int lockInteractionForFrame;

		// Token: 0x0400301A RID: 12314
		public PlatformUser UserData;

		// Token: 0x0400301B RID: 12315
		public LocalUser LocalUser;

		// Token: 0x0400301C RID: 12316
		public bool tileInteractionHappened;

		// Token: 0x0400301D RID: 12317
		public bool tileInteractAttempted;

		// Token: 0x0400301E RID: 12318
		public bool controlDownHold;

		// Token: 0x0400301F RID: 12319
		public bool isOperatingAnotherEntity;

		// Token: 0x04003020 RID: 12320
		public bool autoReuseAllWeapons;

		// Token: 0x04003021 RID: 12321
		public bool isControlledByFilm;

		// Token: 0x04003022 RID: 12322
		public bool tryKeepingHoveringDown;

		// Token: 0x04003023 RID: 12323
		public bool tryKeepingHoveringUp;

		// Token: 0x04003024 RID: 12324
		public int altFunctionUse;

		// Token: 0x04003025 RID: 12325
		public bool mapZoomIn;

		// Token: 0x04003026 RID: 12326
		public bool mapZoomOut;

		// Token: 0x04003027 RID: 12327
		public bool mapAlphaUp;

		// Token: 0x04003028 RID: 12328
		public bool mapAlphaDown;

		// Token: 0x04003029 RID: 12329
		public bool mapFullScreen;

		// Token: 0x0400302A RID: 12330
		public bool mapStyle;

		// Token: 0x0400302B RID: 12331
		public bool releaseMapFullscreen;

		// Token: 0x0400302C RID: 12332
		public bool releaseMapStyle;

		// Token: 0x0400302D RID: 12333
		public int leftTimer;

		// Token: 0x0400302E RID: 12334
		public int rightTimer;

		// Token: 0x0400302F RID: 12335
		public bool delayUseItem;

		// Token: 0x04003030 RID: 12336
		public const int defaultWidth = 20;

		// Token: 0x04003031 RID: 12337
		public const int defaultHeight = 42;

		// Token: 0x04003032 RID: 12338
		public bool cursorItemIconEnabled;

		// Token: 0x04003033 RID: 12339
		public bool cursorItemIconReversed;

		// Token: 0x04003034 RID: 12340
		public int cursorItemIconID;

		// Token: 0x04003035 RID: 12341
		public int cursorItemIconPush;

		// Token: 0x04003036 RID: 12342
		public int cursorChestItemIconID;

		// Token: 0x04003037 RID: 12343
		public string cursorItemIconText;

		// Token: 0x04003038 RID: 12344
		public int runSoundDelay;

		// Token: 0x04003039 RID: 12345
		public float opacityForAnimation;

		// Token: 0x0400303A RID: 12346
		public const int shadowMax = 3;

		// Token: 0x0400303B RID: 12347
		public Microsoft.Xna.Framework.Vector2[] shadowPos;

		// Token: 0x0400303C RID: 12348
		public float[] shadowRotation;

		// Token: 0x0400303D RID: 12349
		public Microsoft.Xna.Framework.Vector2[] shadowOrigin;

		// Token: 0x0400303E RID: 12350
		public int[] shadowDirection;

		// Token: 0x0400303F RID: 12351
		public int shadowCount;

		// Token: 0x04003040 RID: 12352
		public float manaCost;

		// Token: 0x04003041 RID: 12353
		public bool fireWalk;

		// Token: 0x04003042 RID: 12354
		public bool channel;

		// Token: 0x04003043 RID: 12355
		public int step;

		// Token: 0x04003044 RID: 12356
		private Player.ChannelCancelKey _channelShotCache;

		// Token: 0x04003045 RID: 12357
		public bool skipAnimatingValuesInPlayerFrame;

		// Token: 0x04003046 RID: 12358
		public Player.RabbitOrderFrameHelper rabbitOrderFrame;

		// Token: 0x04003047 RID: 12359
		public bool creativeGodMode;

		// Token: 0x04003048 RID: 12360
		private const int MaxAdvancedShadows = 60;

		// Token: 0x04003049 RID: 12361
		public int availableAdvancedShadowsCount;

		// Token: 0x0400304A RID: 12362
		private EntityShadowInfo[] _advancedShadows;

		// Token: 0x0400304B RID: 12363
		private int _lastAddedAvancedShadow;

		// Token: 0x0400304C RID: 12364
		public Player.CompositeArmData compositeFrontArm;

		// Token: 0x0400304D RID: 12365
		public Player.CompositeArmData compositeBackArm;

		// Token: 0x0400304E RID: 12366
		public int anglerQuestsFinished;

		// Token: 0x0400304F RID: 12367
		public int golferScoreAccumulated;

		// Token: 0x04003050 RID: 12368
		public int bartenderQuestLog;

		// Token: 0x04003051 RID: 12369
		public bool downedDD2EventAnyDifficulty;

		// Token: 0x04003052 RID: 12370
		public int armorPenetration;

		// Token: 0x04003053 RID: 12371
		public int statDefense;

		// Token: 0x04003054 RID: 12372
		public int statLifeMax;

		// Token: 0x04003055 RID: 12373
		public int statLifeMax2;

		// Token: 0x04003056 RID: 12374
		public int statLife;

		// Token: 0x04003057 RID: 12375
		public int statMana;

		// Token: 0x04003058 RID: 12376
		public int statManaMax;

		// Token: 0x04003059 RID: 12377
		public int statManaMax2;

		// Token: 0x0400305A RID: 12378
		public int lifeRegen;

		// Token: 0x0400305B RID: 12379
		public int lifeRegenCount;

		// Token: 0x0400305C RID: 12380
		public float lifeRegenTime;

		// Token: 0x0400305D RID: 12381
		public int manaRegen;

		// Token: 0x0400305E RID: 12382
		public int manaRegenCount;

		// Token: 0x0400305F RID: 12383
		public float manaRegenDelay;

		// Token: 0x04003060 RID: 12384
		public bool manaRegenBuff;

		// Token: 0x04003061 RID: 12385
		public bool noKnockback;

		// Token: 0x04003062 RID: 12386
		private bool shimmerImmune;

		// Token: 0x04003063 RID: 12387
		public bool spaceGun;

		// Token: 0x04003064 RID: 12388
		public float gravDir;

		// Token: 0x04003065 RID: 12389
		public bool chloroAmmoCost80;

		// Token: 0x04003066 RID: 12390
		public bool huntressAmmoCost90;

		// Token: 0x04003067 RID: 12391
		public bool ammoCost80;

		// Token: 0x04003068 RID: 12392
		public bool ammoCost75;

		// Token: 0x04003069 RID: 12393
		public int stickyBreak;

		// Token: 0x0400306A RID: 12394
		public bool magicQuiver;

		// Token: 0x0400306B RID: 12395
		public bool magmaStone;

		// Token: 0x0400306C RID: 12396
		public bool lavaRose;

		// Token: 0x0400306D RID: 12397
		public bool hasMoltenQuiver;

		// Token: 0x0400306E RID: 12398
		public int phantasmTime;

		// Token: 0x0400306F RID: 12399
		public bool ammoBox;

		// Token: 0x04003070 RID: 12400
		public bool ammoPotion;

		// Token: 0x04003071 RID: 12401
		public bool chaosState;

		// Token: 0x04003072 RID: 12402
		public bool strongBees;

		// Token: 0x04003073 RID: 12403
		public bool sporeSac;

		// Token: 0x04003074 RID: 12404
		public bool shinyStone;

		// Token: 0x04003075 RID: 12405
		public bool empressBrooch;

		// Token: 0x04003076 RID: 12406
		public bool volatileGelatin;

		// Token: 0x04003077 RID: 12407
		public int volatileGelatinCounter;

		// Token: 0x04003078 RID: 12408
		public bool hasMagiluminescence;

		// Token: 0x04003079 RID: 12409
		public bool shadowArmor;

		// Token: 0x0400307A RID: 12410
		public bool dontStarveShader;

		// Token: 0x0400307B RID: 12411
		public bool eyebrellaCloud;

		// Token: 0x0400307C RID: 12412
		public int yoraiz0rEye;

		// Token: 0x0400307D RID: 12413
		public bool yoraiz0rDarkness;

		// Token: 0x0400307E RID: 12414
		public bool hasUnicornHorn;

		// Token: 0x0400307F RID: 12415
		public bool hasAngelHalo;

		// Token: 0x04003080 RID: 12416
		public bool hasRainbowCursor;

		// Token: 0x04003081 RID: 12417
		public bool leinforsHair;

		// Token: 0x04003082 RID: 12418
		public bool stardustMonolithShader;

		// Token: 0x04003083 RID: 12419
		public bool nebulaMonolithShader;

		// Token: 0x04003084 RID: 12420
		public bool vortexMonolithShader;

		// Token: 0x04003085 RID: 12421
		public bool solarMonolithShader;

		// Token: 0x04003086 RID: 12422
		public bool moonLordMonolithShader;

		// Token: 0x04003087 RID: 12423
		public bool bloodMoonMonolithShader;

		// Token: 0x04003088 RID: 12424
		public bool shimmerMonolithShader;

		// Token: 0x04003089 RID: 12425
		public int overrideFishingBobber;

		// Token: 0x0400308A RID: 12426
		public bool unlockedBiomeTorches;

		// Token: 0x0400308B RID: 12427
		public bool ateArtisanBread;

		// Token: 0x0400308C RID: 12428
		public bool unlockedSuperCart;

		// Token: 0x0400308D RID: 12429
		public bool enabledSuperCart;

		// Token: 0x0400308E RID: 12430
		public bool suspiciouslookingTentacle;

		// Token: 0x0400308F RID: 12431
		public bool crimsonHeart;

		// Token: 0x04003090 RID: 12432
		public bool lightOrb;

		// Token: 0x04003091 RID: 12433
		public bool blueFairy;

		// Token: 0x04003092 RID: 12434
		public bool redFairy;

		// Token: 0x04003093 RID: 12435
		public bool greenFairy;

		// Token: 0x04003094 RID: 12436
		public bool bunny;

		// Token: 0x04003095 RID: 12437
		public bool turtle;

		// Token: 0x04003096 RID: 12438
		public bool eater;

		// Token: 0x04003097 RID: 12439
		public bool penguin;

		// Token: 0x04003098 RID: 12440
		public bool HasGardenGnomeNearby;

		// Token: 0x04003099 RID: 12441
		public bool magicLantern;

		// Token: 0x0400309A RID: 12442
		public bool rabid;

		// Token: 0x0400309B RID: 12443
		public bool sunflower;

		// Token: 0x0400309C RID: 12444
		public bool wellFed;

		// Token: 0x0400309D RID: 12445
		public bool puppy;

		// Token: 0x0400309E RID: 12446
		public bool grinch;

		// Token: 0x0400309F RID: 12447
		public bool miniMinotaur;

		// Token: 0x040030A0 RID: 12448
		public bool flowerBoots;

		// Token: 0x040030A1 RID: 12449
		public bool fairyBoots;

		// Token: 0x040030A2 RID: 12450
		public bool hellfireTreads;

		// Token: 0x040030A3 RID: 12451
		public bool moonLordLegs;

		// Token: 0x040030A4 RID: 12452
		public bool arcticDivingGear;

		// Token: 0x040030A5 RID: 12453
		public bool coolWhipBuff;

		// Token: 0x040030A6 RID: 12454
		public bool wearsRobe;

		// Token: 0x040030A7 RID: 12455
		public bool minecartLeft;

		// Token: 0x040030A8 RID: 12456
		public bool onWrongGround;

		// Token: 0x040030A9 RID: 12457
		public bool onTrack;

		// Token: 0x040030AA RID: 12458
		public int cartRampTime;

		// Token: 0x040030AB RID: 12459
		public bool cartFlip;

		// Token: 0x040030AC RID: 12460
		public float trackBoost;

		// Token: 0x040030AD RID: 12461
		public Microsoft.Xna.Framework.Vector2 lastBoost;

		// Token: 0x040030AE RID: 12462
		public Mount mount;

		// Token: 0x040030AF RID: 12463
		public bool blackCat;

		// Token: 0x040030B0 RID: 12464
		public bool spider;

		// Token: 0x040030B1 RID: 12465
		public bool squashling;

		// Token: 0x040030B2 RID: 12466
		public bool petFlagDD2Gato;

		// Token: 0x040030B3 RID: 12467
		public bool petFlagDD2Ghost;

		// Token: 0x040030B4 RID: 12468
		public bool petFlagDD2Dragon;

		// Token: 0x040030B5 RID: 12469
		public bool petFlagUpbeatStar;

		// Token: 0x040030B6 RID: 12470
		public bool petFlagSugarGlider;

		// Token: 0x040030B7 RID: 12471
		public bool petFlagBabyShark;

		// Token: 0x040030B8 RID: 12472
		public bool petFlagLilHarpy;

		// Token: 0x040030B9 RID: 12473
		public bool petFlagFennecFox;

		// Token: 0x040030BA RID: 12474
		public bool petFlagGlitteryButterfly;

		// Token: 0x040030BB RID: 12475
		public bool petFlagBabyImp;

		// Token: 0x040030BC RID: 12476
		public bool petFlagBabyRedPanda;

		// Token: 0x040030BD RID: 12477
		public bool petFlagPlantero;

		// Token: 0x040030BE RID: 12478
		public bool petFlagDynamiteKitten;

		// Token: 0x040030BF RID: 12479
		public bool petFlagBabyWerewolf;

		// Token: 0x040030C0 RID: 12480
		public bool petFlagShadowMimic;

		// Token: 0x040030C1 RID: 12481
		public bool petFlagVoltBunny;

		// Token: 0x040030C2 RID: 12482
		public bool petFlagKingSlimePet;

		// Token: 0x040030C3 RID: 12483
		public bool petFlagEyeOfCthulhuPet;

		// Token: 0x040030C4 RID: 12484
		public bool petFlagEaterOfWorldsPet;

		// Token: 0x040030C5 RID: 12485
		public bool petFlagBrainOfCthulhuPet;

		// Token: 0x040030C6 RID: 12486
		public bool petFlagSkeletronPet;

		// Token: 0x040030C7 RID: 12487
		public bool petFlagQueenBeePet;

		// Token: 0x040030C8 RID: 12488
		public bool petFlagDestroyerPet;

		// Token: 0x040030C9 RID: 12489
		public bool petFlagTwinsPet;

		// Token: 0x040030CA RID: 12490
		public bool petFlagSkeletronPrimePet;

		// Token: 0x040030CB RID: 12491
		public bool petFlagPlanteraPet;

		// Token: 0x040030CC RID: 12492
		public bool petFlagGolemPet;

		// Token: 0x040030CD RID: 12493
		public bool petFlagDukeFishronPet;

		// Token: 0x040030CE RID: 12494
		public bool petFlagLunaticCultistPet;

		// Token: 0x040030CF RID: 12495
		public bool petFlagMoonLordPet;

		// Token: 0x040030D0 RID: 12496
		public bool petFlagFairyQueenPet;

		// Token: 0x040030D1 RID: 12497
		public bool petFlagPumpkingPet;

		// Token: 0x040030D2 RID: 12498
		public bool petFlagEverscreamPet;

		// Token: 0x040030D3 RID: 12499
		public bool petFlagIceQueenPet;

		// Token: 0x040030D4 RID: 12500
		public bool petFlagMartianPet;

		// Token: 0x040030D5 RID: 12501
		public bool petFlagDD2OgrePet;

		// Token: 0x040030D6 RID: 12502
		public bool petFlagDD2BetsyPet;

		// Token: 0x040030D7 RID: 12503
		public bool petFlagQueenSlimePet;

		// Token: 0x040030D8 RID: 12504
		public bool petFlagBerniePet;

		// Token: 0x040030D9 RID: 12505
		public bool petFlagGlommerPet;

		// Token: 0x040030DA RID: 12506
		public bool petFlagDeerclopsPet;

		// Token: 0x040030DB RID: 12507
		public bool petFlagPigPet;

		// Token: 0x040030DC RID: 12508
		public bool petFlagChesterPet;

		// Token: 0x040030DD RID: 12509
		public bool petFlagJunimoPet;

		// Token: 0x040030DE RID: 12510
		public bool petFlagBlueChickenPet;

		// Token: 0x040030DF RID: 12511
		public bool petFlagSpiffo;

		// Token: 0x040030E0 RID: 12512
		public bool petFlagCaveling;

		// Token: 0x040030E1 RID: 12513
		public bool petFlagDirtiestBlock;

		// Token: 0x040030E2 RID: 12514
		public bool companionCube;

		// Token: 0x040030E3 RID: 12515
		public bool babyFaceMonster;

		// Token: 0x040030E4 RID: 12516
		public bool magicCuffs;

		// Token: 0x040030E5 RID: 12517
		public bool coldDash;

		// Token: 0x040030E6 RID: 12518
		public bool sailDash;

		// Token: 0x040030E7 RID: 12519
		public bool desertDash;

		// Token: 0x040030E8 RID: 12520
		public bool desertBoots;

		// Token: 0x040030E9 RID: 12521
		public bool eyeSpring;

		// Token: 0x040030EA RID: 12522
		public bool snowman;

		// Token: 0x040030EB RID: 12523
		public bool scope;

		// Token: 0x040030EC RID: 12524
		public bool dino;

		// Token: 0x040030ED RID: 12525
		public bool skeletron;

		// Token: 0x040030EE RID: 12526
		public bool hornet;

		// Token: 0x040030EF RID: 12527
		public bool zephyrfish;

		// Token: 0x040030F0 RID: 12528
		public bool tiki;

		// Token: 0x040030F1 RID: 12529
		public bool parrot;

		// Token: 0x040030F2 RID: 12530
		public bool truffle;

		// Token: 0x040030F3 RID: 12531
		public bool sapling;

		// Token: 0x040030F4 RID: 12532
		public bool cSapling;

		// Token: 0x040030F5 RID: 12533
		public bool wisp;

		// Token: 0x040030F6 RID: 12534
		public bool lizard;

		// Token: 0x040030F7 RID: 12535
		public bool archery;

		// Token: 0x040030F8 RID: 12536
		public bool poisoned;

		// Token: 0x040030F9 RID: 12537
		public bool venom;

		// Token: 0x040030FA RID: 12538
		public bool blind;

		// Token: 0x040030FB RID: 12539
		public bool blackout;

		// Token: 0x040030FC RID: 12540
		public bool headcovered;

		// Token: 0x040030FD RID: 12541
		public bool frostBurn;

		// Token: 0x040030FE RID: 12542
		public bool onFrostBurn;

		// Token: 0x040030FF RID: 12543
		public bool onFrostBurn2;

		// Token: 0x04003100 RID: 12544
		public bool burned;

		// Token: 0x04003101 RID: 12545
		public bool shimmering;

		// Token: 0x04003102 RID: 12546
		public int timeShimmering;

		// Token: 0x04003103 RID: 12547
		public float shimmerTransparency;

		// Token: 0x04003104 RID: 12548
		public ShimmerUnstuckHelper shimmerUnstuckHelper;

		// Token: 0x04003105 RID: 12549
		public bool suffocating;

		// Token: 0x04003106 RID: 12550
		public byte suffocateDelay;

		// Token: 0x04003107 RID: 12551
		public bool dripping;

		// Token: 0x04003108 RID: 12552
		public bool drippingSlime;

		// Token: 0x04003109 RID: 12553
		public bool drippingSparkleSlime;

		// Token: 0x0400310A RID: 12554
		public bool onFire;

		// Token: 0x0400310B RID: 12555
		public bool onFire2;

		// Token: 0x0400310C RID: 12556
		public bool onFire3;

		// Token: 0x0400310D RID: 12557
		public bool noItems;

		// Token: 0x0400310E RID: 12558
		public bool cursed;

		// Token: 0x0400310F RID: 12559
		public bool hungry;

		// Token: 0x04003110 RID: 12560
		public bool starving;

		// Token: 0x04003111 RID: 12561
		public bool heartyMeal;

		// Token: 0x04003112 RID: 12562
		public bool windPushed;

		// Token: 0x04003113 RID: 12563
		public bool wereWolf;

		// Token: 0x04003114 RID: 12564
		public bool wolfAcc;

		// Token: 0x04003115 RID: 12565
		public bool hideMerman;

		// Token: 0x04003116 RID: 12566
		public bool hideWolf;

		// Token: 0x04003117 RID: 12567
		public bool forceMerman;

		// Token: 0x04003118 RID: 12568
		public bool forceWerewolf;

		// Token: 0x04003119 RID: 12569
		public bool rulerGrid;

		// Token: 0x0400311A RID: 12570
		public bool rulerLine;

		// Token: 0x0400311B RID: 12571
		public bool bleed;

		// Token: 0x0400311C RID: 12572
		public bool confused;

		// Token: 0x0400311D RID: 12573
		public bool accMerman;

		// Token: 0x0400311E RID: 12574
		public bool merman;

		// Token: 0x0400311F RID: 12575
		public bool trident;

		// Token: 0x04003120 RID: 12576
		public bool brokenArmor;

		// Token: 0x04003121 RID: 12577
		public bool silence;

		// Token: 0x04003122 RID: 12578
		public bool slow;

		// Token: 0x04003123 RID: 12579
		public bool gross;

		// Token: 0x04003124 RID: 12580
		public bool tongued;

		// Token: 0x04003125 RID: 12581
		public bool kbGlove;

		// Token: 0x04003126 RID: 12582
		public bool autoReuseGlove;

		// Token: 0x04003127 RID: 12583
		public bool meleeScaleGlove;

		// Token: 0x04003128 RID: 12584
		public bool kbBuff;

		// Token: 0x04003129 RID: 12585
		public bool remoteVisionForDrone;

		// Token: 0x0400312A RID: 12586
		public Item starCloakItem;

		// Token: 0x0400312B RID: 12587
		public Item starCloakItem_manaCloakOverrideItem;

		// Token: 0x0400312C RID: 12588
		public Item starCloakItem_starVeilOverrideItem;

		// Token: 0x0400312D RID: 12589
		public Item starCloakItem_beeCloakOverrideItem;

		// Token: 0x0400312E RID: 12590
		public bool longInvince;

		// Token: 0x0400312F RID: 12591
		public bool pStone;

		// Token: 0x04003130 RID: 12592
		public static readonly float PhilosopherStoneDurationMultiplier;

		// Token: 0x04003131 RID: 12593
		public bool manaFlower;

		// Token: 0x04003132 RID: 12594
		public bool moonLeech;

		// Token: 0x04003133 RID: 12595
		public bool vortexDebuff;

		// Token: 0x04003134 RID: 12596
		public bool trapDebuffSource;

		// Token: 0x04003135 RID: 12597
		public bool witheredArmor;

		// Token: 0x04003136 RID: 12598
		public bool witheredWeapon;

		// Token: 0x04003137 RID: 12599
		public bool slowOgreSpit;

		// Token: 0x04003138 RID: 12600
		public bool parryDamageBuff;

		// Token: 0x04003139 RID: 12601
		public bool ballistaPanic;

		// Token: 0x0400313A RID: 12602
		public bool JustDroppedAnItem;

		// Token: 0x0400313B RID: 12603
		public int meleeCrit;

		// Token: 0x0400313C RID: 12604
		public int magicCrit;

		// Token: 0x0400313D RID: 12605
		public int rangedCrit;

		// Token: 0x0400313E RID: 12606
		public float meleeDamage;

		// Token: 0x0400313F RID: 12607
		public float magicDamage;

		// Token: 0x04003140 RID: 12608
		public float rangedDamage;

		// Token: 0x04003141 RID: 12609
		public float rangedMultDamage;

		// Token: 0x04003142 RID: 12610
		public float arrowDamageAdditiveStack;

		// Token: 0x04003143 RID: 12611
		public float arrowDamage;

		// Token: 0x04003144 RID: 12612
		public float bulletDamage;

		// Token: 0x04003145 RID: 12613
		public float rocketDamage;

		// Token: 0x04003146 RID: 12614
		public float minionDamage;

		// Token: 0x04003147 RID: 12615
		public float minionKB;

		// Token: 0x04003148 RID: 12616
		public float meleeSpeed;

		// Token: 0x04003149 RID: 12617
		public float summonerWeaponSpeedBonus;

		// Token: 0x0400314A RID: 12618
		public float moveSpeed;

		// Token: 0x0400314B RID: 12619
		public float pickSpeed;

		// Token: 0x0400314C RID: 12620
		public float wallSpeed;

		// Token: 0x0400314D RID: 12621
		public float tileSpeed;

		// Token: 0x0400314E RID: 12622
		public bool autoPaint;

		// Token: 0x0400314F RID: 12623
		public bool autoActuator;

		// Token: 0x04003150 RID: 12624
		public int SpawnX;

		// Token: 0x04003151 RID: 12625
		public int SpawnY;

		// Token: 0x04003152 RID: 12626
		public Microsoft.Xna.Framework.Vector2? PotionOfReturnOriginalUsePosition;

		// Token: 0x04003153 RID: 12627
		public Microsoft.Xna.Framework.Vector2? PotionOfReturnHomePosition;

		// Token: 0x04003154 RID: 12628
		public int[] spX;

		// Token: 0x04003155 RID: 12629
		public int[] spY;

		// Token: 0x04003156 RID: 12630
		public string[] spN;

		// Token: 0x04003157 RID: 12631
		public int[] spI;

		// Token: 0x04003158 RID: 12632
		public int lastTileRangeX;

		// Token: 0x04003159 RID: 12633
		public int lastTileRangeY;

		// Token: 0x0400315A RID: 12634
		public float gravity;

		// Token: 0x0400315B RID: 12635
		public float maxFallSpeed;

		// Token: 0x0400315C RID: 12636
		public float maxRunSpeed;

		// Token: 0x0400315D RID: 12637
		public float runAcceleration;

		// Token: 0x0400315E RID: 12638
		public float runSlowdown;

		// Token: 0x0400315F RID: 12639
		public int TotalRunTime;

		// Token: 0x04003160 RID: 12640
		public bool adjWater;

		// Token: 0x04003161 RID: 12641
		public bool adjHoney;

		// Token: 0x04003162 RID: 12642
		public bool adjLava;

		// Token: 0x04003163 RID: 12643
		public bool oldAdjWater;

		// Token: 0x04003164 RID: 12644
		public bool oldAdjHoney;

		// Token: 0x04003165 RID: 12645
		public bool oldAdjLava;

		// Token: 0x04003166 RID: 12646
		public bool[] adjTile;

		// Token: 0x04003167 RID: 12647
		public bool[] oldAdjTile;

		// Token: 0x04003168 RID: 12648
		private static float itemGrabSpeed;

		// Token: 0x04003169 RID: 12649
		private static float itemGrabSpeedMax;

		// Token: 0x0400316A RID: 12650
		public byte hairDye;

		// Token: 0x0400316B RID: 12651
		public Microsoft.Xna.Framework.Graphics.Color hairDyeColor;

		// Token: 0x0400316C RID: 12652
		public float hairDyeVar;

		// Token: 0x0400316D RID: 12653
		public int skinDyePacked;

		// Token: 0x0400316E RID: 12654
		public Microsoft.Xna.Framework.Graphics.Color hairColor;

		// Token: 0x0400316F RID: 12655
		public Microsoft.Xna.Framework.Graphics.Color skinColor;

		// Token: 0x04003170 RID: 12656
		public Microsoft.Xna.Framework.Graphics.Color eyeColor;

		// Token: 0x04003171 RID: 12657
		public Microsoft.Xna.Framework.Graphics.Color shirtColor;

		// Token: 0x04003172 RID: 12658
		public Microsoft.Xna.Framework.Graphics.Color underShirtColor;

		// Token: 0x04003173 RID: 12659
		public Microsoft.Xna.Framework.Graphics.Color pantsColor;

		// Token: 0x04003174 RID: 12660
		public Microsoft.Xna.Framework.Graphics.Color shoeColor;

		// Token: 0x04003175 RID: 12661
		public int hair;

		// Token: 0x04003176 RID: 12662
		public bool hostile;

		// Token: 0x04003177 RID: 12663
		public SoundPlaySet hermesStepSound;

		// Token: 0x04003178 RID: 12664
		public Microsoft.Xna.Framework.Vector2 instantMovementAccumulatedThisFrame;

		// Token: 0x04003179 RID: 12665
		public int accCompass;

		// Token: 0x0400317A RID: 12666
		public int accWatch;

		// Token: 0x0400317B RID: 12667
		public int accDepthMeter;

		// Token: 0x0400317C RID: 12668
		public bool accFishFinder;

		// Token: 0x0400317D RID: 12669
		public bool accWeatherRadio;

		// Token: 0x0400317E RID: 12670
		public bool accJarOfSouls;

		// Token: 0x0400317F RID: 12671
		public bool accCalendar;

		// Token: 0x04003180 RID: 12672
		public int lastCreatureHit;

		// Token: 0x04003181 RID: 12673
		public bool accThirdEye;

		// Token: 0x04003182 RID: 12674
		public byte accThirdEyeCounter;

		// Token: 0x04003183 RID: 12675
		public byte accThirdEyeNumber;

		// Token: 0x04003184 RID: 12676
		public bool accStopwatch;

		// Token: 0x04003185 RID: 12677
		public bool accOreFinder;

		// Token: 0x04003186 RID: 12678
		public bool accCritterGuide;

		// Token: 0x04003187 RID: 12679
		public byte accCritterGuideCounter;

		// Token: 0x04003188 RID: 12680
		public byte accCritterGuideNumber;

		// Token: 0x04003189 RID: 12681
		public bool accDreamCatcher;

		// Token: 0x0400318A RID: 12682
		public bool hasFootball;

		// Token: 0x0400318B RID: 12683
		public bool drawingFootball;

		// Token: 0x0400318C RID: 12684
		public bool ActuationRodLock;

		// Token: 0x0400318D RID: 12685
		public bool ActuationRodLockSetting;

		// Token: 0x0400318E RID: 12686
		public bool InfoAccMechShowWires;

		// Token: 0x0400318F RID: 12687
		public DateTime dpsStart;

		// Token: 0x04003190 RID: 12688
		public DateTime dpsEnd;

		// Token: 0x04003191 RID: 12689
		public DateTime dpsLastHit;

		// Token: 0x04003192 RID: 12690
		public int dpsDamage;

		// Token: 0x04003193 RID: 12691
		public bool dpsStarted;

		// Token: 0x04003194 RID: 12692
		public string displayedFishingInfo;

		// Token: 0x04003195 RID: 12693
		public bool discountEquipped;

		// Token: 0x04003196 RID: 12694
		public bool discountAvailable;

		// Token: 0x04003197 RID: 12695
		public bool hasLuckyCoin;

		// Token: 0x04003198 RID: 12696
		public Item boneGloveItem;

		// Token: 0x04003199 RID: 12697
		public bool goldRing;

		// Token: 0x0400319A RID: 12698
		public bool accDivingHelm;

		// Token: 0x0400319B RID: 12699
		public bool accFlipper;

		// Token: 0x0400319C RID: 12700
		public bool hasLuck_LuckyCoin;

		// Token: 0x0400319D RID: 12701
		public bool hasLuck_LuckyHorseshoe;

		// Token: 0x0400319E RID: 12702
		public int doubleJumpsConsumed;

		// Token: 0x0400319F RID: 12703
		public bool hasJumpOption_Cloud;

		// Token: 0x040031A0 RID: 12704
		public bool canJumpAgain_Cloud;

		// Token: 0x040031A1 RID: 12705
		public bool isPerformingJump_Cloud;

		// Token: 0x040031A2 RID: 12706
		public bool hasJumpOption_Sandstorm;

		// Token: 0x040031A3 RID: 12707
		public bool canJumpAgain_Sandstorm;

		// Token: 0x040031A4 RID: 12708
		public bool isPerformingJump_Sandstorm;

		// Token: 0x040031A5 RID: 12709
		public bool hasJumpOption_Blizzard;

		// Token: 0x040031A6 RID: 12710
		public bool canJumpAgain_Blizzard;

		// Token: 0x040031A7 RID: 12711
		public bool isPerformingJump_Blizzard;

		// Token: 0x040031A8 RID: 12712
		public bool hasJumpOption_Fart;

		// Token: 0x040031A9 RID: 12713
		public bool canJumpAgain_Fart;

		// Token: 0x040031AA RID: 12714
		public bool isPerformingJump_Fart;

		// Token: 0x040031AB RID: 12715
		public bool hasJumpOption_Sail;

		// Token: 0x040031AC RID: 12716
		public bool canJumpAgain_Sail;

		// Token: 0x040031AD RID: 12717
		public bool isPerformingJump_Sail;

		// Token: 0x040031AE RID: 12718
		public bool hasJumpOption_Unicorn;

		// Token: 0x040031AF RID: 12719
		public bool canJumpAgain_Unicorn;

		// Token: 0x040031B0 RID: 12720
		public bool isPerformingJump_Unicorn;

		// Token: 0x040031B1 RID: 12721
		public bool hasJumpOption_Santank;

		// Token: 0x040031B2 RID: 12722
		public bool canJumpAgain_Santank;

		// Token: 0x040031B3 RID: 12723
		public bool isPerformingJump_Santank;

		// Token: 0x040031B4 RID: 12724
		public bool hasJumpOption_WallOfFleshGoat;

		// Token: 0x040031B5 RID: 12725
		public bool canJumpAgain_WallOfFleshGoat;

		// Token: 0x040031B6 RID: 12726
		public bool isPerformingJump_WallOfFleshGoat;

		// Token: 0x040031B7 RID: 12727
		public bool hasJumpOption_Basilisk;

		// Token: 0x040031B8 RID: 12728
		public bool canJumpAgain_Basilisk;

		// Token: 0x040031B9 RID: 12729
		public bool isPerformingJump_Basilisk;

		// Token: 0x040031BA RID: 12730
		public bool isPerformingPogostickTricks;

		// Token: 0x040031BB RID: 12731
		public bool autoJump;

		// Token: 0x040031BC RID: 12732
		public bool justJumped;

		// Token: 0x040031BD RID: 12733
		public float jumpSpeedBoost;

		// Token: 0x040031BE RID: 12734
		public int extraFall;

		// Token: 0x040031BF RID: 12735
		private const float PixelsPerMeter = 26.24672f;

		// Token: 0x040031C0 RID: 12736
		private float FractionalDistanceTraveled;

		// Token: 0x040031C1 RID: 12737
		public bool canFloatInWater;

		// Token: 0x040031C2 RID: 12738
		public bool hasFloatingTube;

		// Token: 0x040031C3 RID: 12739
		public bool frogLegJumpBoost;

		// Token: 0x040031C4 RID: 12740
		public bool skyStoneEffects;

		// Token: 0x040031C5 RID: 12741
		public bool spawnMax;

		// Token: 0x040031C6 RID: 12742
		public int blockRange;

		// Token: 0x040031C7 RID: 12743
		public int[] grappling;

		// Token: 0x040031C8 RID: 12744
		public int grapCount;

		// Token: 0x040031C9 RID: 12745
		public int rocketTime;

		// Token: 0x040031CA RID: 12746
		public int rocketTimeMax;

		// Token: 0x040031CB RID: 12747
		public int rocketDelay;

		// Token: 0x040031CC RID: 12748
		public int rocketDelay2;

		// Token: 0x040031CD RID: 12749
		public int rocketSoundDelay;

		// Token: 0x040031CE RID: 12750
		public bool rocketRelease;

		// Token: 0x040031CF RID: 12751
		public bool rocketFrame;

		// Token: 0x040031D0 RID: 12752
		public int rocketBoots;

		// Token: 0x040031D1 RID: 12753
		public int vanityRocketBoots;

		// Token: 0x040031D2 RID: 12754
		public bool canRocket;

		// Token: 0x040031D3 RID: 12755
		public bool jumpBoost;

		// Token: 0x040031D4 RID: 12756
		public bool noFallDmg;

		// Token: 0x040031D5 RID: 12757
		public int swimTime;

		// Token: 0x040031D6 RID: 12758
		public bool killGuide;

		// Token: 0x040031D7 RID: 12759
		public bool killClothier;

		// Token: 0x040031D8 RID: 12760
		public float equipmentBasedLuckBonus;

		// Token: 0x040031D9 RID: 12761
		public float lastEquipmentBasedLuckBonus;

		// Token: 0x040031DA RID: 12762
		public bool hasCreditsSceneMusicBox;

		// Token: 0x040031DB RID: 12763
		public bool lavaImmune;

		// Token: 0x040031DC RID: 12764
		public bool gills;

		// Token: 0x040031DD RID: 12765
		public bool slowFall;

		// Token: 0x040031DE RID: 12766
		public bool findTreasure;

		// Token: 0x040031DF RID: 12767
		public bool biomeSight;

		// Token: 0x040031E0 RID: 12768
		public bool invis;

		// Token: 0x040031E1 RID: 12769
		public bool detectCreature;

		// Token: 0x040031E2 RID: 12770
		public bool nightVision;

		// Token: 0x040031E3 RID: 12771
		public bool enemySpawns;

		// Token: 0x040031E4 RID: 12772
		public float thorns;

		// Token: 0x040031E5 RID: 12773
		public bool turtleArmor;

		// Token: 0x040031E6 RID: 12774
		public bool turtleThorns;

		// Token: 0x040031E7 RID: 12775
		public bool cactusThorns;

		// Token: 0x040031E8 RID: 12776
		public bool spiderArmor;

		// Token: 0x040031E9 RID: 12777
		public bool anglerSetSpawnReduction;

		// Token: 0x040031EA RID: 12778
		public bool CanSeeInvisibleBlocks;

		// Token: 0x040031EB RID: 12779
		public bool setSolar;

		// Token: 0x040031EC RID: 12780
		public bool setVortex;

		// Token: 0x040031ED RID: 12781
		public bool setNebula;

		// Token: 0x040031EE RID: 12782
		public int nebulaCD;

		// Token: 0x040031EF RID: 12783
		public bool setStardust;

		// Token: 0x040031F0 RID: 12784
		public bool setForbidden;

		// Token: 0x040031F1 RID: 12785
		public bool setForbiddenCooldownLocked;

		// Token: 0x040031F2 RID: 12786
		public bool setSquireT3;

		// Token: 0x040031F3 RID: 12787
		public bool setHuntressT3;

		// Token: 0x040031F4 RID: 12788
		public bool setApprenticeT3;

		// Token: 0x040031F5 RID: 12789
		public bool setMonkT3;

		// Token: 0x040031F6 RID: 12790
		public bool setSquireT2;

		// Token: 0x040031F7 RID: 12791
		public bool setHuntressT2;

		// Token: 0x040031F8 RID: 12792
		public bool setApprenticeT2;

		// Token: 0x040031F9 RID: 12793
		public bool setMonkT2;

		// Token: 0x040031FA RID: 12794
		public int maxTurrets;

		// Token: 0x040031FB RID: 12795
		public int maxTurretsOld;

		// Token: 0x040031FC RID: 12796
		public bool vortexStealthActive;

		// Token: 0x040031FD RID: 12797
		public bool waterWalk;

		// Token: 0x040031FE RID: 12798
		public bool waterWalk2;

		// Token: 0x040031FF RID: 12799
		public int forcedGravity;

		// Token: 0x04003200 RID: 12800
		public bool gravControl;

		// Token: 0x04003201 RID: 12801
		public bool gravControl2;

		// Token: 0x04003202 RID: 12802
		public Item honeyCombItem;

		// Token: 0x04003203 RID: 12803
		public int wireOperationsCooldown;

		// Token: 0x04003204 RID: 12804
		public int lastChest;

		// Token: 0x04003205 RID: 12805
		public TrackedProjectileReference piggyBankProjTracker;

		// Token: 0x04003206 RID: 12806
		public List<int> interactableProjectiles;

		// Token: 0x04003207 RID: 12807
		public TrackedProjectileReference voidLensChest;

		// Token: 0x04003208 RID: 12808
		public int chest;

		// Token: 0x04003209 RID: 12809
		public int chestX;

		// Token: 0x0400320A RID: 12810
		public int chestY;

		// Token: 0x0400320B RID: 12811
		public Player.eToHellAndBackStatus ToHellAndBackStatus;

		// Token: 0x0400320C RID: 12812
		public int talkNPC;

		// Token: 0x0400320D RID: 12813
		public int fallStart;

		// Token: 0x0400320E RID: 12814
		public int fallStart2;

		// Token: 0x0400320F RID: 12815
		public int potionDelayTime;

		// Token: 0x04003210 RID: 12816
		public int restorationDelayTime;

		// Token: 0x04003211 RID: 12817
		public int mushroomDelayTime;

		// Token: 0x04003212 RID: 12818
		private bool _batbatCanHeal;

		// Token: 0x04003213 RID: 12819
		private bool _spawnTentacleSpikes;

		// Token: 0x04003214 RID: 12820
		private bool _spawnBloodButcherer;

		// Token: 0x04003215 RID: 12821
		private bool _spawnVolcanoExplosion;

		// Token: 0x04003216 RID: 12822
		private bool _spawnMuramasaCut;

		// Token: 0x04003217 RID: 12823
		public bool isPettingAnimal;

		// Token: 0x04003218 RID: 12824
		public bool isTheAnimalBeingPetSmall;

		// Token: 0x04003219 RID: 12825
		public PlayerSittingHelper sitting;

		// Token: 0x0400321A RID: 12826
		public PlayerSleepingHelper sleeping;

		// Token: 0x0400321B RID: 12827
		public PlayerEyeHelper eyeHelper;

		// Token: 0x0400321C RID: 12828
		public PlayerInteractionAnchor tileEntityAnchor;

		// Token: 0x0400321D RID: 12829
		public DoorOpeningHelper doorHelper;

		// Token: 0x0400321E RID: 12830
		public ShoppingSettings currentShoppingSettings;

		// Token: 0x0400321F RID: 12831
		public int cHead;

		// Token: 0x04003220 RID: 12832
		public int cBody;

		// Token: 0x04003221 RID: 12833
		public int cLegs;

		// Token: 0x04003222 RID: 12834
		public int cHandOn;

		// Token: 0x04003223 RID: 12835
		public int cHandOff;

		// Token: 0x04003224 RID: 12836
		public int cBack;

		// Token: 0x04003225 RID: 12837
		public int cFront;

		// Token: 0x04003226 RID: 12838
		public int cShoe;

		// Token: 0x04003227 RID: 12839
		public int cWaist;

		// Token: 0x04003228 RID: 12840
		public int cShield;

		// Token: 0x04003229 RID: 12841
		public int cNeck;

		// Token: 0x0400322A RID: 12842
		public int cFace;

		// Token: 0x0400322B RID: 12843
		public int cFaceHead;

		// Token: 0x0400322C RID: 12844
		public int cFaceFlower;

		// Token: 0x0400322D RID: 12845
		public int cBalloon;

		// Token: 0x0400322E RID: 12846
		public int cBalloonFront;

		// Token: 0x0400322F RID: 12847
		public int cWings;

		// Token: 0x04003230 RID: 12848
		public int cCarpet;

		// Token: 0x04003231 RID: 12849
		public int cFloatingTube;

		// Token: 0x04003232 RID: 12850
		public int cBackpack;

		// Token: 0x04003233 RID: 12851
		public int cTail;

		// Token: 0x04003234 RID: 12852
		public int cShieldFallback;

		// Token: 0x04003235 RID: 12853
		public int cGrapple;

		// Token: 0x04003236 RID: 12854
		public int cMount;

		// Token: 0x04003237 RID: 12855
		public int cMinecart;

		// Token: 0x04003238 RID: 12856
		public int cPet;

		// Token: 0x04003239 RID: 12857
		public int cLight;

		// Token: 0x0400323A RID: 12858
		public int cYorai;

		// Token: 0x0400323B RID: 12859
		public int cPortableStool;

		// Token: 0x0400323C RID: 12860
		public int cUnicornHorn;

		// Token: 0x0400323D RID: 12861
		public int cAngelHalo;

		// Token: 0x0400323E RID: 12862
		public int cBeard;

		// Token: 0x0400323F RID: 12863
		public int cMinion;

		// Token: 0x04003240 RID: 12864
		public int cLeinShampoo;

		// Token: 0x04003241 RID: 12865
		public int cFlameWaker;

		// Token: 0x04003242 RID: 12866
		public int[] ownedProjectileCounts;

		// Token: 0x04003243 RID: 12867
		public bool[] npcTypeNoAggro;

		// Token: 0x04003244 RID: 12868
		public int lastPortalColorIndex;

		// Token: 0x04003245 RID: 12869
		public int _portalPhysicsTime;

		// Token: 0x04003246 RID: 12870
		public bool portalPhysicsFlag;

		// Token: 0x04003247 RID: 12871
		public int lastTeleportPylonStyleUsed;

		// Token: 0x04003248 RID: 12872
		public float MountFishronSpecialCounter;

		// Token: 0x04003249 RID: 12873
		public Microsoft.Xna.Framework.Vector2 MinionRestTargetPoint;

		// Token: 0x0400324A RID: 12874
		public int MinionAttackTargetNPC;

		// Token: 0x0400324B RID: 12875
		public List<Point> TouchedTiles;

		// Token: 0x0400324C RID: 12876
		public int itemAnimation;

		// Token: 0x0400324D RID: 12877
		public int itemAnimationMax;

		// Token: 0x0400324E RID: 12878
		public int itemTime;

		// Token: 0x0400324F RID: 12879
		public int itemTimeMax;

		// Token: 0x04003250 RID: 12880
		public int toolTime;

		// Token: 0x04003251 RID: 12881
		private static Item defaultItem;

		// Token: 0x04003252 RID: 12882
		public const int SafeItemAnimationTimeForPreventingExploits = 20;

		// Token: 0x04003253 RID: 12883
		private static List<Point> QuickMinecartPts;

		// Token: 0x04003254 RID: 12884
		private HashSet<Point> _blackListedTileCoordsForGrappling;

		// Token: 0x04003255 RID: 12885
		private bool makeStrongBee;

		// Token: 0x04003256 RID: 12886
		public bool equippedAnyTileRangeAcc;

		// Token: 0x04003257 RID: 12887
		public bool equippedAnyTileSpeedAcc;

		// Token: 0x04003258 RID: 12888
		public bool equippedAnyWallSpeedAcc;

		// Token: 0x04003259 RID: 12889
		private static List<NPC> _hallucinationCandidates;

		// Token: 0x0400325A RID: 12890
		public bool behindBackWall;

		// Token: 0x0400325B RID: 12891
		public int _funkytownAchievementCheckCooldown;

		// Token: 0x0400325C RID: 12892
		private float _stormShaderObstruction;

		// Token: 0x0400325D RID: 12893
		private float _shaderObstructionInternalValue;

		// Token: 0x0400325E RID: 12894
		private int graveImmediateTime;

		// Token: 0x0400325F RID: 12895
		public static float airLightDecay;

		// Token: 0x04003260 RID: 12896
		public static float solidLightDecay;

		// Token: 0x04003261 RID: 12897
		private float _deerclopsBlizzardSmoothedEffect;

		// Token: 0x04003262 RID: 12898
		public static int[] PetBuffs;

		// Token: 0x04003263 RID: 12899
		public const int ChairSittingMaxDistance = 40;

		// Token: 0x04003264 RID: 12900
		private int _lastSmartCursorToolStrategy;

		// Token: 0x04003265 RID: 12901
		private bool[] nearbyTorch;

		// Token: 0x04003266 RID: 12902
		private bool dryCoralTorch;

		// Token: 0x04003267 RID: 12903
		private int luckyTorchCounter;

		// Token: 0x04003268 RID: 12904
		private int nearbyTorches;

		// Token: 0x04003269 RID: 12905
		public float torchLuck;

		// Token: 0x0400326A RID: 12906
		private Microsoft.Xna.Framework.Vector2 _nextTorchLuckCheckCenter;

		// Token: 0x0400326B RID: 12907
		public bool happyFunTorchTime;

		// Token: 0x0400326C RID: 12908
		private int torchFunTimer;

		// Token: 0x0400326D RID: 12909
		private int torchGodCooldown;

		// Token: 0x0400326E RID: 12910
		private int numberOfTorchAttacksMade;

		// Token: 0x0400326F RID: 12911
		private static int maxTorchAttacks;

		// Token: 0x04003270 RID: 12912
		private int[] unlitTorchX;

		// Token: 0x04003271 RID: 12913
		private int[] unlitTorchY;

		// Token: 0x04003272 RID: 12914
		public int ladyBugLuckTimeLeft;

		// Token: 0x04003273 RID: 12915
		public float luck;

		// Token: 0x04003274 RID: 12916
		public float luckMinimumCap;

		// Token: 0x04003275 RID: 12917
		public float luckMaximumCap;

		// Token: 0x04003276 RID: 12918
		public float coinLuck;

		// Token: 0x04003277 RID: 12919
		public bool luckNeedsSync;

		// Token: 0x04003278 RID: 12920
		public int disableVoidBag;

		// Token: 0x04003279 RID: 12921
		private int _quickGrappleCooldown;

		// Token: 0x0400327A RID: 12922
		public PlayerMovementAccsCache movementAbilitiesCache;

		// Token: 0x0400327B RID: 12923
		private bool wasScopeActionActive;

		// Token: 0x0400327C RID: 12924
		private static bool[] ItemUsesRightFire;

		// Token: 0x0400327D RID: 12925
		public float wingAccRunSpeed;

		// Token: 0x0400327E RID: 12926
		public float wingRunAccelerationMult;

		// Token: 0x0400327F RID: 12927
		public const int SHIELD_PARRY_DURATION = 20;

		// Token: 0x04003280 RID: 12928
		public const int SHIELD_PARRY_DURATION_DRAWING_TWEAKER = 20;

		// Token: 0x04003281 RID: 12929
		public const int SHIELD_PARRY_DAMAGE_BUFF_MULTIPLIER = 5;

		// Token: 0x04003282 RID: 12930
		public bool hasRaisableShield;

		// Token: 0x04003283 RID: 12931
		public bool shieldRaised;

		// Token: 0x04003284 RID: 12932
		public int shieldParryTimeLeft;

		// Token: 0x04003285 RID: 12933
		public int shield_parry_cooldown;

		// Token: 0x04003286 RID: 12934
		private bool _forceForwardCursor;

		// Token: 0x04003287 RID: 12935
		private Point _inputMouseCoordsForward;

		// Token: 0x04003288 RID: 12936
		private Point _mainMouseCoordsForward;

		// Token: 0x04003289 RID: 12937
		private bool _forceSmartSelectCursor;

		// Token: 0x0400328A RID: 12938
		private Point _inputMouseCoordsSmartSelect;

		// Token: 0x0400328B RID: 12939
		private Point _mainMouseCoordsSmartSelect;

		// Token: 0x0400328C RID: 12940
		private Point _tileTargetSmartSelect;

		// Token: 0x0400328D RID: 12941
		private bool botherWithUnaimedMinecartTracks;

		// Token: 0x0400328E RID: 12942
		private List<int> _projectilesToInteractWith;

		// Token: 0x0400328F RID: 12943
		private int _lockTileInteractionsTimer;

		// Token: 0x04003290 RID: 12944
		private static Item[] costInventory;

		// Token: 0x04003291 RID: 12945
		private static Item[] costBankInventory;

		// Token: 0x04003292 RID: 12946
		private static Item[] costBank2Inventory;

		// Token: 0x04003293 RID: 12947
		private static Item[] costBank3Inventory;

		// Token: 0x04003294 RID: 12948
		private static Item[] costBank4Inventory;

		// Token: 0x04003295 RID: 12949
		public int[] hurtCooldowns;

		// Token: 0x04003296 RID: 12950
		public static int FlexibleWandRandomSeed;

		// Token: 0x04003297 RID: 12951
		public static int FlexibleWandCycleOffset;

		// Token: 0x04003298 RID: 12952
		public static Point FlexibleWandLastPosition;

		// Token: 0x04003299 RID: 12953
		private static Point[] _tentacleSpikesMax5;

		// Token: 0x0400329A RID: 12954
		private static Point[] _bloodButchererMax5;

		// Token: 0x0400329B RID: 12955
		public int[] meleeNPCHitCooldown;

		// Token: 0x0400329C RID: 12956
		public float musicDist;

		// Token: 0x0400329D RID: 12957
		public EquipmentLoadout[] Loadouts;

		// Token: 0x0400329E RID: 12958
		public int CurrentLoadoutIndex;

		// Token: 0x0400329F RID: 12959
		public Player.SavedPlayerDataWithAnnoyingRules savedPerPlayerFieldsThatArentInThePlayerClass;

		// Token: 0x040032A0 RID: 12960
		private const int SaveSlotIndex_MouseItem = 0;

		// Token: 0x040032A1 RID: 12961
		private const int SaveSlotIndex_CreativeSacrifice = 1;

		// Token: 0x040032A2 RID: 12962
		private const int SaveSlotIndex_GuideItem = 2;

		// Token: 0x040032A3 RID: 12963
		private const int SaveSlotIndex_TinkererItem = 3;

		// Token: 0x040032A4 RID: 12964
		private const int SaveSlotIndexCount = 4;

		// Token: 0x040032A5 RID: 12965
		private Item[] _temporaryItemSlots;

		// Token: 0x02000405 RID: 1029
		public class SmartCursorSettings
		{
			// Token: 0x1700054D RID: 1357
			// (get) Token: 0x060025C4 RID: 9668 RVA: 0x000021DB File Offset: 0x000003DB
			// (set) Token: 0x060025C5 RID: 9669 RVA: 0x0014B1AC File Offset: 0x001493AC
			public static bool SmartBlocksEnabled
			{
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
				set
				{
				}
			}

			// Token: 0x1700054E RID: 1358
			// (get) Token: 0x060025C6 RID: 9670 RVA: 0x000021DB File Offset: 0x000003DB
			// (set) Token: 0x060025C7 RID: 9671 RVA: 0x0014B1BC File Offset: 0x001493BC
			public static bool SmartAxeAfterPickaxe
			{
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
				set
				{
				}
			}

			// Token: 0x060025C8 RID: 9672 RVA: 0x0014B1CC File Offset: 0x001493CC
			public SmartCursorSettings()
			{
			}
		}

		// Token: 0x02000406 RID: 1030
		public class Settings
		{
			// Token: 0x060025C9 RID: 9673 RVA: 0x0014B1E0 File Offset: 0x001493E0
			public static void CycleHoverControl()
			{
			}

			// Token: 0x060025CA RID: 9674 RVA: 0x0014B1F0 File Offset: 0x001493F0
			public Settings()
			{
			}

			// Token: 0x040032A6 RID: 12966
			public static Player.Settings.HoverControlMode HoverControl;

			// Token: 0x02000407 RID: 1031
			public enum HoverControlMode
			{
				// Token: 0x040032A8 RID: 12968
				Hold,
				// Token: 0x040032A9 RID: 12969
				Click
			}
		}

		// Token: 0x02000408 RID: 1032
		public static class BuilderAccToggleIDs
		{
			// Token: 0x060025CB RID: 9675 RVA: 0x0014B204 File Offset: 0x00149404
			// Note: this type is marked as 'beforefieldinit'.
			static BuilderAccToggleIDs()
			{
			}

			// Token: 0x040032AA RID: 12970
			public const int RulerLine = 0;

			// Token: 0x040032AB RID: 12971
			public const int RulerGrid = 1;

			// Token: 0x040032AC RID: 12972
			public const int AutoActuate = 2;

			// Token: 0x040032AD RID: 12973
			public const int AutoPaint = 3;

			// Token: 0x040032AE RID: 12974
			public const int WireVisibility_Red = 4;

			// Token: 0x040032AF RID: 12975
			public const int WireVisibility_Green = 5;

			// Token: 0x040032B0 RID: 12976
			public const int WireVisibility_Blue = 6;

			// Token: 0x040032B1 RID: 12977
			public const int WireVisibility_Yellow = 7;

			// Token: 0x040032B2 RID: 12978
			public const int HideAllWires = 8;

			// Token: 0x040032B3 RID: 12979
			public const int WireVisibility_Actuators = 9;

			// Token: 0x040032B4 RID: 12980
			public const int BlockSwap = 10;

			// Token: 0x040032B5 RID: 12981
			public const int TorchBiome = 11;

			// Token: 0x040032B6 RID: 12982
			public static readonly int Count;
		}

		// Token: 0x02000409 RID: 1033
		public struct DirectionalInputSyncCache
		{
			// Token: 0x060025CC RID: 9676 RVA: 0x0014B214 File Offset: 0x00149414
			public DirectionalInputSyncCache(Player player)
			{
				bool flag = player.controlLeft;
				this.controlLeft = flag;
				bool flag2 = player.controlRight;
				this.controlRight = flag2;
				bool flag3 = player.controlUp;
				this.controlUp = flag3;
				bool flag4 = player.controlDown;
				this.controlDown = flag4;
			}

			// Token: 0x060025CD RID: 9677 RVA: 0x0014B25C File Offset: 0x0014945C
			public void ApplyTo(Player player)
			{
				bool flag = this.controlRight;
				player.controlRight = flag;
				bool flag2 = this.controlUp;
				player.controlUp = flag2;
				bool flag3 = this.controlDown;
				player.controlDown = flag3;
			}

			// Token: 0x040032B7 RID: 12983
			public bool controlLeft;

			// Token: 0x040032B8 RID: 12984
			public bool controlRight;

			// Token: 0x040032B9 RID: 12985
			public bool controlUp;

			// Token: 0x040032BA RID: 12986
			public bool controlDown;
		}

		// Token: 0x0200040A RID: 1034
		private struct ChannelCancelKey
		{
			// Token: 0x060025CE RID: 9678 RVA: 0x0014B294 File Offset: 0x00149494
			public bool Matches(Projectile projectile)
			{
				/*
An exception occurred when decompiling this method (060025CE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player/ChannelCancelKey::Matches(Terraria.Projectile)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Projectile::type, ldloc:Projectile(projectile)))
	stloc:int32(var_1_0D, ldfld:int32(ChannelCancelKey::ProjectileIndexExpected, ldloc:valuetype Terraria.Player/ChannelCancelKey&(this)))
	stloc:int32(var_2_14, ldfld:int32(Entity::whoAmI, ldloc:Projectile[exp:Entity](projectile)))
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

			// Token: 0x060025CF RID: 9679 RVA: 0x0014B2B8 File Offset: 0x001494B8
			public void TryTracking(Projectile projectile)
			{
				int type = projectile.type;
				int whoAmI = projectile.whoAmI;
				this.ProjectileIndexExpected = whoAmI;
			}

			// Token: 0x040032BB RID: 12987
			public int ProjectileTypeExpected;

			// Token: 0x040032BC RID: 12988
			public int ProjectileIndexExpected;
		}

		// Token: 0x0200040B RID: 1035
		public struct RabbitOrderFrameHelper
		{
			// Token: 0x060025D0 RID: 9680 RVA: 0x0014B2DC File Offset: 0x001494DC
			public void Update()
			{
				int aiState = this._aiState;
			}

			// Token: 0x060025D1 RID: 9681 RVA: 0x0014B328 File Offset: 0x00149528
			public void Reset()
			{
				this.Update();
			}

			// Token: 0x060025D2 RID: 9682 RVA: 0x0014B33C File Offset: 0x0014953C
			private void ChangeToAIState(int aiState)
			{
				this.Update();
			}

			// Token: 0x060025D3 RID: 9683 RVA: 0x0014B350 File Offset: 0x00149550
			private void UpdateFrame(int displayFrameMin, int displayFrameMax, int exitAIState, int gameFramesPerDisplayFrame)
			{
				if (!true)
				{
				}
				int frameCounter = this._frameCounter;
				this.DisplayFrame = frameCounter;
			}

			// Token: 0x040032BD RID: 12989
			public int DisplayFrame;

			// Token: 0x040032BE RID: 12990
			private int _frameCounter;

			// Token: 0x040032BF RID: 12991
			private int _aiState;

			// Token: 0x040032C0 RID: 12992
			private const int AIState_Idle = 0;

			// Token: 0x040032C1 RID: 12993
			private const int AIState_LookingAtCamera = 1;

			// Token: 0x040032C2 RID: 12994
			private const int AIState_Resting = 2;

			// Token: 0x040032C3 RID: 12995
			private const int AIState_EatingCarrot = 3;
		}

		// Token: 0x0200040C RID: 1036
		public enum CompositeArmStretchAmount
		{
			// Token: 0x040032C5 RID: 12997
			Full,
			// Token: 0x040032C6 RID: 12998
			None,
			// Token: 0x040032C7 RID: 12999
			Quarter,
			// Token: 0x040032C8 RID: 13000
			ThreeQuarters
		}

		// Token: 0x0200040D RID: 1037
		public struct CompositeArmData
		{
			// Token: 0x060025D4 RID: 9684 RVA: 0x0014B378 File Offset: 0x00149578
			public CompositeArmData(bool enabled, Player.CompositeArmStretchAmount intendedStrech, float rotation)
			{
				this.stretch = intendedStrech;
			}

			// Token: 0x040032C9 RID: 13001
			public bool enabled;

			// Token: 0x040032CA RID: 13002
			public Player.CompositeArmStretchAmount stretch;

			// Token: 0x040032CB RID: 13003
			public float rotation;
		}

		// Token: 0x0200040E RID: 1038
		public enum eToHellAndBackStatus
		{
			// Token: 0x040032CD RID: 13005
			NotStarted,
			// Token: 0x040032CE RID: 13006
			SurfaceToHell,
			// Token: 0x040032CF RID: 13007
			HellToSurface,
			// Token: 0x040032D0 RID: 13008
			Completed
		}

		// Token: 0x0200040F RID: 1039
		public sealed class DashStartAction : MulticastDelegate
		{
			// Token: 0x060025D5 RID: 9685 RVA: 0x0014B38C File Offset: 0x0014958C
			public DashStartAction(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x060025D6 RID: 9686 RVA: 0x0014B3E0 File Offset: 0x001495E0
			public void Invoke(int dashDirection)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}

			// Token: 0x060025D7 RID: 9687 RVA: 0x000021DB File Offset: 0x000003DB
			public IAsyncResult BeginInvoke(int dashDirection, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x060025D8 RID: 9688 RVA: 0x0014B404 File Offset: 0x00149604
			public void EndInvoke(IAsyncResult result)
			{
			}
		}

		// Token: 0x02000410 RID: 1040
		public struct SetMatchRequest
		{
			// Token: 0x040032D1 RID: 13009
			public int Head;

			// Token: 0x040032D2 RID: 13010
			public int Body;

			// Token: 0x040032D3 RID: 13011
			public int Legs;

			// Token: 0x040032D4 RID: 13012
			public int ArmorSlotRequested;

			// Token: 0x040032D5 RID: 13013
			public bool Male;
		}

		// Token: 0x02000411 RID: 1041
		public struct ItemSpaceStatus
		{
			// Token: 0x1700054F RID: 1359
			// (get) Token: 0x060025D9 RID: 9689 RVA: 0x0014B414 File Offset: 0x00149614
			public bool CanTakeItemToPersonalInventory
			{
				get
				{
					/*
An exception occurred when decompiling this method (060025D9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Player/ItemSpaceStatus::get_CanTakeItemToPersonalInventory()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_06, ldfld:bool(ItemSpaceStatus::ItemIsGoingToVoidVault, ldloc:valuetype Terraria.Player/ItemSpaceStatus&(this)))
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

			// Token: 0x060025DA RID: 9690 RVA: 0x0014B42C File Offset: 0x0014962C
			public ItemSpaceStatus(bool CanTakeItem = false, bool ItemIsGoingToVoidVault = false)
			{
			}

			// Token: 0x060025DB RID: 9691 RVA: 0x0014B43C File Offset: 0x0014963C
			public void Set(bool CanTakeItem, bool ItemIsGoingToVoidVault = false)
			{
			}

			// Token: 0x040032D6 RID: 13014
			public bool CanTakeItem;

			// Token: 0x040032D7 RID: 13015
			public bool ItemIsGoingToVoidVault;
		}

		// Token: 0x02000412 RID: 1042
		public struct ItemCheckContext
		{
			// Token: 0x040032D8 RID: 13016
			public bool SkipItemConsumption;
		}

		// Token: 0x02000413 RID: 1043
		private struct SpecialToolUsageSettings
		{
			// Token: 0x040032D9 RID: 13017
			public bool IsAValidTool;

			// Token: 0x040032DA RID: 13018
			public Player.SpecialToolUsageSettings.CanUseToolCondition UsageCondition;

			// Token: 0x040032DB RID: 13019
			public Player.SpecialToolUsageSettings.UseToolAction UsageAction;

			// Token: 0x02000414 RID: 1044
			// (Invoke) Token: 0x060025DD RID: 9693
			public delegate bool CanUseToolCondition(Player user, Item item, int targetX, int targetY);

			// Token: 0x02000415 RID: 1045
			// (Invoke) Token: 0x060025E1 RID: 9697
			public delegate void UseToolAction(Player user, Item item, int targetX, int targetY);
		}

		// Token: 0x02000416 RID: 1046
		public class SavedPlayerDataWithAnnoyingRules
		{
			// Token: 0x060025E4 RID: 9700 RVA: 0x0014B44C File Offset: 0x0014964C
			public SavedPlayerDataWithAnnoyingRules()
			{
			}

			// Token: 0x040032DC RID: 13020
			public bool godmodePowerEnabled;

			// Token: 0x040032DD RID: 13021
			public bool farPlacementRangePowerEnabled;

			// Token: 0x040032DE RID: 13022
			public float spawnRatePowerSliderValue;
		}

		// Token: 0x02000417 RID: 1047
		public class RandomTeleportationAttemptSettings
		{
			// Token: 0x060025E5 RID: 9701 RVA: 0x0014B460 File Offset: 0x00149660
			public RandomTeleportationAttemptSettings()
			{
			}

			// Token: 0x040032DF RID: 13023
			public bool mostlySolidFloor;

			// Token: 0x040032E0 RID: 13024
			public bool avoidLava;

			// Token: 0x040032E1 RID: 13025
			public bool avoidAnyLiquid;

			// Token: 0x040032E2 RID: 13026
			public bool avoidHurtTiles;

			// Token: 0x040032E3 RID: 13027
			public bool avoidWalls;

			// Token: 0x040032E4 RID: 13028
			public int attemptsBeforeGivingUp;

			// Token: 0x040032E5 RID: 13029
			public int maximumFallDistanceFromOrignalPoint;
		}

		// Token: 0x02000418 RID: 1048
		public static class Hooks
		{
			// Token: 0x1400002B RID: 43
			// (add) Token: 0x060025E6 RID: 9702 RVA: 0x0014B474 File Offset: 0x00149674
			// (remove) Token: 0x060025E7 RID: 9703 RVA: 0x0014B490 File Offset: 0x00149690
			public static event Action<Player> OnEnterWorld
			{
				[CompilerGenerated]
				add
				{
					Delegate @delegate;
					if (@delegate != null && @delegate == null)
					{
						return;
					}
				}
				[CompilerGenerated]
				remove
				{
					Delegate @delegate;
					if (@delegate != null && @delegate == null)
					{
						return;
					}
				}
			}

			// Token: 0x060025E8 RID: 9704 RVA: 0x0014B4AC File Offset: 0x001496AC
			public static void PlayerConnect(int playerIndex)
			{
				if (!true)
				{
				}
				PressurePlateHelper.ResetPlayer(playerIndex);
			}

			// Token: 0x060025E9 RID: 9705 RVA: 0x0014B4C4 File Offset: 0x001496C4
			public static void PlayerDisconnect(int playerIndex)
			{
				if (!true)
				{
				}
				PressurePlateHelper.ResetPlayer(playerIndex);
			}

			// Token: 0x060025EA RID: 9706 RVA: 0x0014B4DC File Offset: 0x001496DC
			public static void EnterWorld(int playerIndex)
			{
				if (!true)
				{
				}
				int myPlayer = Main.myPlayer;
				int myPlayer2 = Main.myPlayer;
				Main.ToggleGameplayUpdates(true);
			}

			// Token: 0x040032E6 RID: 13030
			[CompilerGenerated]
			private static Action<Player> OnEnterWorld;
		}

		// Token: 0x02000419 RID: 1049
		public class SelectionRadial
		{
			// Token: 0x17000550 RID: 1360
			// (get) Token: 0x060025EB RID: 9707 RVA: 0x0014B504 File Offset: 0x00149704
			public int SelectedBinding
			{
				get
				{
					return this._SelectedBinding;
				}
			}

			// Token: 0x17000551 RID: 1361
			// (get) Token: 0x060025EC RID: 9708 RVA: 0x0014B518 File Offset: 0x00149718
			public int SelectedItem
			{
				get
				{
					int selectedBinding = this._SelectedBinding;
					Player localPlayer = Main.LocalPlayer;
					Microsoft.Xna.Framework.Vector2 position = localPlayer.inventory.position;
					int[] bindings = this.Bindings;
					int talkNPC = localPlayer.talkNPC;
					return this._NPCHeldItem;
				}
			}

			// Token: 0x060025ED RID: 9709 RVA: 0x0014B56C File Offset: 0x0014976C
			public void LoadNPCHeldItem(int heldItem)
			{
				this.RadialCount = heldItem;
			}

			// Token: 0x060025EE RID: 9710 RVA: 0x0014B580 File Offset: 0x00149780
			public SelectionRadial(Player.SelectionRadial.SelectionMode mode = Player.SelectionRadial.SelectionMode.Dpad4)
			{
				int num = 1;
				this._SelectedBinding = num;
				base..ctor();
				this.Mode = mode;
			}

			// Token: 0x060025EF RID: 9711 RVA: 0x0014B5B8 File Offset: 0x001497B8
			public void Update()
			{
				int radialCount3;
				if (this.Mode != Player.SelectionRadial.SelectionMode.Dpad4)
				{
					int radialCount = this.RadialCount;
					int[] bindings = this.Bindings;
					long num = 0L;
					bindings.m_value = (int)num;
					if (this.Mode == Player.SelectionRadial.SelectionMode.Dpad4)
					{
					}
					bool radialHotbar = PlayerInput.Triggers.Current.RadialHotbar;
					if (this.Mode == Player.SelectionRadial.SelectionMode.Dpad4)
					{
					}
					bool radialQuickbar = PlayerInput.Triggers.Current.RadialQuickbar;
					int radialCount2 = this.RadialCount;
					Player.SelectionRadial.SelectionMode mode = this.Mode;
					Microsoft.Xna.Framework.Vector2 vector;
					float num2 = vector.Length();
					Microsoft.Xna.Framework.Vector2 vector2;
					float num3 = vector2.Length();
					radialCount3 = this.RadialCount;
					return;
				}
				if (radialCount3 == 0)
				{
				}
				bool dpadRadial = PlayerInput.Triggers.JustPressed.DpadRadial1;
				int selectedBinding = this._SelectedBinding;
				this._SelectedBinding = selectedBinding;
				if (selectedBinding == 0)
				{
				}
				bool dpadRadial2 = PlayerInput.Triggers.JustPressed.DpadRadial2;
				int selectedBinding2 = this._SelectedBinding;
				this._SelectedBinding = selectedBinding2;
				if (selectedBinding2 == 0)
				{
				}
				bool dpadRadial3 = PlayerInput.Triggers.JustPressed.DpadRadial3;
				int selectedBinding3 = this._SelectedBinding;
				int num4 = 2;
				this._SelectedBinding = num4;
				if (num4 == 0)
				{
				}
				bool dpadRadial4 = PlayerInput.Triggers.JustPressed.DpadRadial4;
				int selectedBinding4 = this._SelectedBinding;
				int num5 = 3;
				this._SelectedBinding = num5;
			}

			// Token: 0x060025F0 RID: 9712 RVA: 0x0014B728 File Offset: 0x00149928
			public void ChangeBinding(int itemSlot)
			{
				Player.SelectionRadial.SelectionMode mode = this.Mode;
				if (mode == Player.SelectionRadial.SelectionMode.Dpad4)
				{
					if (mode == Player.SelectionRadial.SelectionMode.Dpad4)
					{
					}
					bool dpadRadial = PlayerInput.Triggers.JustPressed.DpadRadial1;
					int[] bindings = this.Bindings;
					int radialCount = this.RadialCount;
					int radialCount2 = this.RadialCount;
					return;
				}
			}

			// Token: 0x060025F1 RID: 9713 RVA: 0x0014B820 File Offset: 0x00149A20
			public void ChangeSelection(int to)
			{
				int selectedBinding = this._SelectedBinding;
				this._SelectedBinding = selectedBinding;
			}

			// Token: 0x060025F2 RID: 9714 RVA: 0x0014B83C File Offset: 0x00149A3C
			public void Bind(int itemslot, int radialslot)
			{
				int[] bindings = this.Bindings;
				int radialCount = this.RadialCount;
				int radialCount2 = this.RadialCount;
			}

			// Token: 0x060025F3 RID: 9715 RVA: 0x0014B860 File Offset: 0x00149A60
			public int GetSlotBinding(int itemSlot)
			{
				/*
An exception occurred when decompiling this method (060025F3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.Player/SelectionRadial::GetSlotBinding(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(SelectionRadial::RadialCount, ldloc:SelectionRadial(this)))
	stloc:int32[](var_1_0D, ldfld:int32[](SelectionRadial::Bindings, ldloc:SelectionRadial(this)))
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

			// Token: 0x060025F4 RID: 9716 RVA: 0x0014B87C File Offset: 0x00149A7C
			public int GetDrawMode(int itemslot)
			{
				int[] bindings = this.Bindings;
				return 2;
			}

			// Token: 0x060025F5 RID: 9717 RVA: 0x0014B898 File Offset: 0x00149A98
			public void CopyTo(Player.SelectionRadial that)
			{
				int selectedBinding = this._SelectedBinding;
				that._SelectedBinding = selectedBinding;
				Player.SelectionRadial.SelectionMode mode = this.Mode;
				that.Mode = mode;
				int radialCount = this.RadialCount;
				that.RadialCount = radialCount;
				int radialCount2 = this.RadialCount;
				int radialCount3 = this.RadialCount;
				int[] bindings = this.Bindings;
			}

			// Token: 0x040032E7 RID: 13031
			private int _SelectedBinding;

			// Token: 0x040032E8 RID: 13032
			private int _NPCHeldItem;

			// Token: 0x040032E9 RID: 13033
			public int RadialCount;

			// Token: 0x040032EA RID: 13034
			public int[] Bindings;

			// Token: 0x040032EB RID: 13035
			public Player.SelectionRadial.SelectionMode Mode;

			// Token: 0x0200041A RID: 1050
			public enum SelectionMode
			{
				// Token: 0x040032ED RID: 13037
				Dpad4,
				// Token: 0x040032EE RID: 13038
				RadialCircular,
				// Token: 0x040032EF RID: 13039
				RadialQuicks
			}
		}

		// Token: 0x0200041B RID: 1051
		public struct OverheadMessage
		{
			// Token: 0x060025F6 RID: 9718 RVA: 0x0014B8EC File Offset: 0x00149AEC
			public void NewMessage(string message, int displayTime)
			{
				this.chatText = message;
				if (!true)
				{
				}
				TextSnippet[] array;
				this.snippets = array;
				TextSnippet[] array2 = this.snippets;
				if (!true)
				{
				}
				this.timeLeft = displayTime;
			}

			// Token: 0x040032F0 RID: 13040
			public string chatText;

			// Token: 0x040032F1 RID: 13041
			public TextSnippet[] snippets;

			// Token: 0x040032F2 RID: 13042
			public Microsoft.Xna.Framework.Vector2 messageSize;

			// Token: 0x040032F3 RID: 13043
			public int timeLeft;

			// Token: 0x040032F4 RID: 13044
			public Microsoft.Xna.Framework.Graphics.Color color;
		}
	}
}
