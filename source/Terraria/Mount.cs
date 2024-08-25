using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;
using Terraria.Graphics.Shaders;

namespace Terraria
{
	// Token: 0x02000441 RID: 1089
	public class Mount
	{
		// Token: 0x06002904 RID: 10500 RVA: 0x00197A68 File Offset: 0x00195C68
		private static void MeowcartLandingSound(Player Player, Vector2 Position, int Width, int Height)
		{
		}

		// Token: 0x06002905 RID: 10501 RVA: 0x00197A78 File Offset: 0x00195C78
		private static void MeowcartBumperSound(Player Player, Vector2 Position, int Width, int Height)
		{
		}

		// Token: 0x06002906 RID: 10502 RVA: 0x00197A88 File Offset: 0x00195C88
		public Mount()
		{
			long num = 0L;
			this._type = 1;
			this._idleTime = (int)num;
		}

		// Token: 0x06002907 RID: 10503 RVA: 0x00197AAC File Offset: 0x00195CAC
		public void Reset()
		{
			long num = 0L;
			this._idleTime = (int)num;
		}

		// Token: 0x06002908 RID: 10504 RVA: 0x000021DB File Offset: 0x000003DB
		public static void Initialize()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002909 RID: 10505 RVA: 0x00197AC4 File Offset: 0x00195CC4
		private static void SetAsHorse(Mount.MountData newMount, int buff, Asset<Texture2D> texture)
		{
			int num9;
			do
			{
				int num = 3;
				newMount.spawnDust = num;
				long num2 = 6L;
				int num3 = 34;
				int num4 = 16;
				newMount.heightBoost = num3;
				newMount.extraBuff = buff;
				newMount.jumpHeight = (int)num2;
				newMount.totalFrames = num4;
				int num5 = 28;
				num2.m_value = (long)num5;
				long num6 = 7L;
				int num7 = 40;
				newMount.runningFrameCount = (int)num6;
				newMount.dashingFrameDelay = num7;
				int num8 = 1;
				num9 = 12;
				newMount.flyingFrameStart = num8;
				newMount.inAirFrameDelay = num9;
				newMount.swimFrameDelay = num9;
				if (num9 == 0)
				{
				}
				bool logicClient = Main.LogicClient;
				newMount.backTexture = texture;
			}
			while (num9 != 0);
			int num10 = Utils.Width(newMount.backTexture);
			Asset<Texture2D> backTexture = newMount.backTexture;
			newMount.textureWidth = num10;
			int num11 = Utils.Height(backTexture);
			newMount.textureHeight = num11;
		}

		// Token: 0x0600290A RID: 10506 RVA: 0x00197B94 File Offset: 0x00195D94
		private static void SetAsMinecart(Mount.MountData newMount, int buffToLeft, int buffToRight, Asset<Texture2D> texture, int verticalOffset = 0, int playerVerticalOffset = 0)
		{
			int num = 1;
			newMount.Minecart = num != 0;
			int num2 = 213;
			newMount.spawnDust = num2;
			long num3 = 15L;
			int num4 = 10;
			int num5 = 3;
			newMount.extraBuff = buffToRight;
			newMount.blockExtraJumps = num != 0;
			newMount.heightBoost = num4;
			newMount.extraBuff = buffToLeft;
			newMount.jumpHeight = (int)num3;
			newMount.totalFrames = num5;
			long num6 = 3L;
			newMount.xOffset = num;
			newMount.runningFrameCount = (int)num6;
			bool logicClient = Main.LogicClient;
			newMount.frontTexture = texture;
			int num7 = Utils.Width(texture);
			Asset<Texture2D> frontTexture = newMount.frontTexture;
			newMount.textureWidth = num7;
			int num8 = Utils.Height(frontTexture);
			newMount.textureHeight = num8;
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x0600290B RID: 10507 RVA: 0x00197C40 File Offset: 0x00195E40
		public bool Active
		{
			get
			{
				return this._active;
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x0600290C RID: 10508 RVA: 0x00197C54 File Offset: 0x00195E54
		public int Type
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x0600290D RID: 10509 RVA: 0x00197C68 File Offset: 0x00195E68
		public int FlyTime
		{
			get
			{
				return this._flyTime;
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x0600290E RID: 10510 RVA: 0x00197C7C File Offset: 0x00195E7C
		public int BuffType
		{
			get
			{
				return this._data.buff;
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x0600290F RID: 10511 RVA: 0x00197C94 File Offset: 0x00195E94
		public int BodyFrame
		{
			get
			{
				return this._data.bodyFrame;
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06002910 RID: 10512 RVA: 0x00197CAC File Offset: 0x00195EAC
		public int XOffset
		{
			get
			{
				return this._data.xOffset;
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06002911 RID: 10513 RVA: 0x00197CC4 File Offset: 0x00195EC4
		public int YOffset
		{
			get
			{
				return this._data.yOffset;
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06002912 RID: 10514 RVA: 0x00197CDC File Offset: 0x00195EDC
		public int PlayerXOFfset
		{
			get
			{
				return this._data.playerXOffset;
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06002913 RID: 10515 RVA: 0x00197CF4 File Offset: 0x00195EF4
		public int PlayerOffset
		{
			get
			{
				if (this._active)
				{
					Mount.MountData data = this._data;
					int totalFrames = data.totalFrames;
					int[] playerYOffsets = data.playerYOffsets;
					return;
				}
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06002914 RID: 10516 RVA: 0x00197D20 File Offset: 0x00195F20
		public int PlayerOffsetHitbox
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002914)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.Mount::get_PlayerOffsetHitbox()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001D:
	stloc:int32(var_4_25, ldfld:int32(MountData::heightBoost, ldloc:MountData(var_0)))
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

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06002915 RID: 10517 RVA: 0x00197D54 File Offset: 0x00195F54
		public int PlayerHeadOffset
		{
			get
			{
				if (this._active)
				{
					return this._data.playerHeadOffset;
				}
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06002916 RID: 10518 RVA: 0x00197D78 File Offset: 0x00195F78
		public int HeightBoost
		{
			get
			{
				return this._data.heightBoost;
			}
		}

		// Token: 0x06002917 RID: 10519 RVA: 0x00197D90 File Offset: 0x00195F90
		public static int GetHeightBoost(int MountType)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06002918 RID: 10520 RVA: 0x00197DA4 File Offset: 0x00195FA4
		public float RunSpeed
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002918)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Mount::get_RunSpeed()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	brtrue(IL_0000, ldloc:bool(var_12_71))
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
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06002919 RID: 10521 RVA: 0x00197E2C File Offset: 0x0019602C
		public float DashSpeed
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002919)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Mount::get_DashSpeed()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	brtrue(IL_0000, ldloc:bool(var_0_06))
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
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x0600291A RID: 10522 RVA: 0x00197E48 File Offset: 0x00196048
		public float Acceleration
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600291A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Mount::get_Acceleration()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	brtrue(IL_0000, ldloc:bool(var_0_06))
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
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x0600291B RID: 10523 RVA: 0x00197E64 File Offset: 0x00196064
		public float FallDamage
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600291B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Mount::get_FallDamage()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_0B, ldfld:float32(MountData::fallDamage, ldfld:MountData(Mount::_data, ldloc:Mount(this))))
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

		// Token: 0x0600291C RID: 10524 RVA: 0x00197E7C File Offset: 0x0019607C
		public int JumpHeight(float xVelocity)
		{
			int type;
			int jumpHeight;
			do
			{
				Mount.MountData data = this._data;
				type = this._type;
				jumpHeight = data.jumpHeight;
			}
			while (type == 0);
			if (type == 0)
			{
			}
			if (this._frameState == 0)
			{
			}
			bool shouldSuperCart = this._shouldSuperCart;
			if (!shouldSuperCart || !shouldSuperCart)
			{
			}
			return jumpHeight;
		}

		// Token: 0x0600291D RID: 10525 RVA: 0x00197EC4 File Offset: 0x001960C4
		public float JumpSpeed(float xVelocity)
		{
			/*
An exception occurred when decompiling this method (0600291D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Mount::JumpSpeed(System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	brtrue(IL_0000, ldloc:bool(var_4_22))
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

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x0600291E RID: 10526 RVA: 0x00197EFC File Offset: 0x001960FC
		public bool AutoJump
		{
			get
			{
				return this._data.constantJump;
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x0600291F RID: 10527 RVA: 0x00197F14 File Offset: 0x00196114
		public bool BlockExtraJumps
		{
			get
			{
				return this._data.blockExtraJumps;
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06002920 RID: 10528 RVA: 0x00197F2C File Offset: 0x0019612C
		public bool IsConsideredASlimeMount
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002920)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Mount::get_IsConsideredASlimeMount()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Mount::_type, ldloc:Mount(this)))
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

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06002921 RID: 10529 RVA: 0x00197F40 File Offset: 0x00196140
		public bool Cart
		{
			get
			{
				Mount.MountData data = this._data;
				if (data != null && this._active)
				{
					bool minecart = data.Minecart;
					return;
				}
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06002922 RID: 10530 RVA: 0x00197F68 File Offset: 0x00196168
		public bool Directional
		{
			get
			{
				Mount.MountData data = this._data;
				if (data != null)
				{
					bool minecartDirectional = data.MinecartDirectional;
				}
				return true;
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06002923 RID: 10531 RVA: 0x00197F88 File Offset: 0x00196188
		public Mount.MountDelegatesData Delegations
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002923)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Mount/MountDelegatesData Terraria.Mount::get_Delegations()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:MountData(var_0_06, ldfld:MountData(Mount::_data, ldloc:Mount(this)))
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

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06002924 RID: 10532 RVA: 0x00197F9C File Offset: 0x0019619C
		public Vector2 Origin
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002924)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 Terraria.Mount::get_Origin()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:MountData(var_0_06, ldfld:MountData(Mount::_data, ldloc:Mount(this)))
	stloc:int32(var_1_0D, ldfld:int32(MountData::textureWidth, ldloc:MountData(var_0_06)))
	stloc:int32(var_2_14, ldfld:int32(MountData::textureHeight, ldloc:MountData(var_0_06)))
	stloc:int32(var_3_1B, ldfld:int32(MountData::totalFrames, ldloc:MountData(var_0_06)))
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

		// Token: 0x06002925 RID: 10533 RVA: 0x00197FC4 File Offset: 0x001961C4
		public bool CanFly()
		{
			if (this._active && this._data.flightTimeMax != 0)
			{
				int type = this._type;
				return;
			}
		}

		// Token: 0x06002926 RID: 10534 RVA: 0x00197FF0 File Offset: 0x001961F0
		public bool CanHover()
		{
			if (this._active && this._data.usesHover)
			{
				int type = this._type;
				int frameState = this._frameState;
			}
			return true;
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06002927 RID: 10535 RVA: 0x00198024 File Offset: 0x00196224
		public bool AbilityCharging
		{
			get
			{
				return this._abilityCharging;
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06002928 RID: 10536 RVA: 0x00198038 File Offset: 0x00196238
		public bool AbilityActive
		{
			get
			{
				return this._abilityActive;
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06002929 RID: 10537 RVA: 0x0019804C File Offset: 0x0019624C
		public float AbilityCharge
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002929)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Mount::get_AbilityCharge()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:MountData(var_0_06, ldfld:MountData(Mount::_data, ldloc:Mount(this)))
	stloc:int32(var_1_0D, ldfld:int32(Mount::_abilityCharge, ldloc:Mount(this)))
	stloc:int32(var_2_14, ldfld:int32(MountData::abilityChargeMax, ldloc:MountData(var_0_06)))
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

		// Token: 0x0600292A RID: 10538 RVA: 0x00198070 File Offset: 0x00196270
		public IEntitySource GetProjectileSpawnSource(Player mountedPlayer)
		{
			/*
An exception occurred when decompiling this method (0600292A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.DataStructures.IEntitySource Terraria.Mount::GetProjectileSpawnSource(Terraria.Player)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Mount::_type, ldloc:Mount(this)))
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

		// Token: 0x0600292B RID: 10539 RVA: 0x00198084 File Offset: 0x00196284
		public void StartAbilityCharge(Player mountedPlayer)
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
			int whoAmI = mountedPlayer.whoAmI;
			if (this._type == 0)
			{
			}
			Vector2 screenPosition = Main.screenPosition;
			int mouseX = Main.mouseX;
			Vector2 screenPosition2 = Main.screenPosition;
			int mouseY = Main.mouseY;
			float x = mountedPlayer.position.X;
			float y = mountedPlayer.position.Y;
			IEntitySource projectileSpawnSource = this.GetProjectileSpawnSource(mountedPlayer);
			int whoAmI2 = mountedPlayer.whoAmI;
			if (whoAmI == 0)
			{
			}
		}

		// Token: 0x0600292C RID: 10540 RVA: 0x00198108 File Offset: 0x00196308
		public void StopAbilityCharge()
		{
			int type = this._type;
			Mount.MountData data = this._data;
		}

		// Token: 0x0600292D RID: 10541 RVA: 0x00198124 File Offset: 0x00196324
		public bool CheckBuff(int buffID)
		{
			Mount.MountData data = this._data;
			int buff = data.buff;
			return true;
		}

		// Token: 0x0600292E RID: 10542 RVA: 0x0019814C File Offset: 0x0019634C
		public void AbilityRecovery()
		{
			bool abilityCharging = this._abilityCharging;
			int abilityCharge = this._abilityCharge;
			if (abilityCharging)
			{
				int abilityChargeMax = this._data.abilityChargeMax;
				return;
			}
			this._abilityCharge = abilityCharge;
			int abilityCooldown = this._abilityCooldown;
			this._abilityCooldown = abilityCooldown;
			int abilityDuration = this._abilityDuration;
			this._abilityDuration = abilityDuration;
		}

		// Token: 0x0600292F RID: 10543 RVA: 0x0019819C File Offset: 0x0019639C
		public void FatigueRecovery()
		{
			float fatigue = this._fatigue;
			this._fatigue = fatigue;
		}

		// Token: 0x06002930 RID: 10544 RVA: 0x001981B8 File Offset: 0x001963B8
		public bool Flight()
		{
			int flyTime = this._flyTime;
			this._flyTime = flyTime;
			return true;
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06002931 RID: 10545 RVA: 0x001981D8 File Offset: 0x001963D8
		public bool AllowDirectionChange
		{
			get
			{
				int type = this._type;
				Mount.MountData data = this._data;
				int abilityCooldown = this._abilityCooldown;
				int abilityCooldown2 = data.abilityCooldown;
				return true;
			}
		}

		// Token: 0x06002932 RID: 10546 RVA: 0x00198204 File Offset: 0x00196404
		public void UpdateDrill(Player mountedPlayer, bool controlUp, bool controlDown)
		{
			if (this._mountSpecificData != null)
			{
			}
		}

		// Token: 0x06002933 RID: 10547 RVA: 0x00198224 File Offset: 0x00196424
		public void UseDrill(Player mountedPlayer)
		{
			int type = this._type;
			if (this._abilityActive)
			{
				if (this._mountSpecificData != null)
				{
				}
				int whoAmI = mountedPlayer.whoAmI;
				int myPlayer = Main.myPlayer;
				bool controlUseItem = mountedPlayer.controlUseItem;
				if (controlUseItem)
				{
					if (!controlUseItem)
					{
					}
					if (!controlUseItem)
					{
						if (whoAmI != 0 || whoAmI == 0)
						{
						}
						return;
					}
				}
				bool controlUseTile = mountedPlayer.controlUseTile;
				if (controlUseTile)
				{
					if (!controlUseTile)
					{
					}
					if (!controlUseTile)
					{
						int num;
						if (num != 0 || num == 0)
						{
						}
						return;
					}
				}
			}
		}

		// Token: 0x06002934 RID: 10548 RVA: 0x00198318 File Offset: 0x00196518
		private static bool DrillSmartCursor_BlocksPlot(int x, int y)
		{
			if (!true)
			{
			}
			bool flag = WorldGen.CanKillTile(0, x, y != 0);
			if (!false)
			{
			}
			Tile tile;
			return tile.nactive();
		}

		// Token: 0x06002935 RID: 10549 RVA: 0x00198340 File Offset: 0x00196540
		private Point16 DrillSmartCursor_Blocks(Player mountedPlayer, Mount.DrillMountData data)
		{
			/*
An exception occurred when decompiling this method (06002935)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.DataStructures.Point16 Terraria.Mount::DrillSmartCursor_Blocks(Terraria.Player,Terraria.Mount/DrillMountData)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0084:
	brtrue(IL_0000, ldc.i4:int32[exp:bool](16896))
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

		// Token: 0x06002936 RID: 10550 RVA: 0x001983DC File Offset: 0x001965DC
		private Point16 DrillSmartCursor_Walls(Player mountedPlayer, Mount.DrillMountData data)
		{
			/*
An exception occurred when decompiling this method (06002936)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.DataStructures.Point16 Terraria.Mount::DrillSmartCursor_Walls(Terraria.Player,Terraria.Mount/DrillMountData)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_005D:
	brtrue(IL_0000, ldc.i4:int32[exp:bool](17248))
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

		// Token: 0x06002937 RID: 10551 RVA: 0x00198454 File Offset: 0x00196654
		public void UseAbility(Player mountedPlayer, Vector2 mousePosition, bool toggleOn)
		{
			int width;
			do
			{
				if (this._type == 0)
				{
				}
				int myPlayer = Main.myPlayer;
				int whoAmI = mountedPlayer.whoAmI;
				Vector2 vector = this.ClampToDeadZone(mountedPlayer, mousePosition);
				width = mountedPlayer.width;
				int height = mountedPlayer.height;
				float x = mountedPlayer.position.X;
				float y = mountedPlayer.position.Y;
				int frameExtra = this._frameExtra;
				if (width == 0)
				{
				}
				Mount.MountData data = this._data;
				int direction = mountedPlayer.direction;
				int yOffset = data.yOffset;
			}
			while (width != 0);
			int xOffset = this._data.xOffset;
		}

		// Token: 0x06002938 RID: 10552 RVA: 0x00198614 File Offset: 0x00196814
		public bool Hover(Player mountedPlayer)
		{
			int type = this._type;
			int frameState = this._frameState;
			float gravity = mountedPlayer.gravity;
			bool slowFall = mountedPlayer.slowFall;
			int flyTime = this._flyTime;
			this._flyTime = flyTime;
			int frameState2 = this._frameState;
			float y = mountedPlayer.velocity.Y;
			if (type == 0)
			{
			}
			int num = 1;
			if (num == 0)
			{
			}
			float gravDir = mountedPlayer.gravDir;
			float x = mountedPlayer.position.X;
			float y2 = mountedPlayer.position.Y;
			int width = mountedPlayer.width;
			bool wet = mountedPlayer.wet;
			float gravDir2 = mountedPlayer.gravDir;
			if (num == 0)
			{
			}
			if (mountedPlayer.controlDown)
			{
				int num2 = 4719;
				mountedPlayer.velocity.Y = (float)num2;
				float gravity2 = mountedPlayer.gravity;
				float gravDir3 = mountedPlayer.gravDir;
				mountedPlayer.velocity.Y = y;
				float fatigue = this._fatigue;
				float fatigueMax = this._fatigueMax;
				this._fatigue = y;
				bool mountFishronSpecial = mountedPlayer.MountFishronSpecial;
				int type2 = this._type;
				return mountFishronSpecial;
			}
			int type3 = this._type;
			Mount.MountData data = this._data;
			float x2 = mountedPlayer.velocity.X;
			float dashSpeed = data.dashSpeed;
			int frame = this._frame;
			float x3 = mountedPlayer.position.X;
			float y3 = mountedPlayer.position.Y;
			int width2 = mountedPlayer.width;
			bool wet2 = mountedPlayer.wet;
			return false;
		}

		// Token: 0x06002939 RID: 10553 RVA: 0x001988C0 File Offset: 0x00196AC0
		private bool DoesHoverIgnoresFatigue()
		{
			int type = this._type;
			return true;
		}

		// Token: 0x0600293A RID: 10554 RVA: 0x001988D8 File Offset: 0x00196AD8
		private float GetWitchBroomTrinketRotation(Player player)
		{
			/*
An exception occurred when decompiling this method (0600293A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Mount::GetWitchBroomTrinketRotation(Terraria.Player)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_002D:
	stloc:int32(var_6_33, ldfld:int32(Player::miscCounter, ldloc:Player(player)))
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

		// Token: 0x0600293B RID: 10555 RVA: 0x0019891C File Offset: 0x00196B1C
		private Vector2 GetWitchBroomTrinketOriginOffset(Player player)
		{
			/*
An exception occurred when decompiling this method (0600293B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 Terraria.Mount::GetWitchBroomTrinketOriginOffset(Terraria.Player)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Entity::direction, ldloc:Player[exp:Entity](player)))
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

		// Token: 0x0600293C RID: 10556 RVA: 0x00198930 File Offset: 0x00196B30
		public void UpdateFrame(Player mountedPlayer, int state, Vector2 velocity)
		{
			int frameState = this._frameState;
			this._frameState = state;
			int type = this._type;
			if (state != 0)
			{
				return;
			}
			if (this._data.emitsLight)
			{
				Vector2 center = mountedPlayer.Center;
				Mount.MountData data = this._data;
				float x = data.lightColor.X;
				float y = data.lightColor.Y;
				float z = data.lightColor.Z;
			}
			int type2 = this._type;
		}

		// Token: 0x0600293D RID: 10557 RVA: 0x001995B8 File Offset: 0x001977B8
		public void TryBeginningFlight(Player mountedPlayer, int state)
		{
			int frameState = this._frameState;
			if (this._active && this._data.usesHover)
			{
				int type = this._type;
				if (!mountedPlayer.controlUp && !mountedPlayer.controlDown)
				{
					bool controlJump = mountedPlayer.controlJump;
					if (!controlJump)
					{
						if (!controlJump)
						{
						}
						if (!true)
						{
						}
						float gravDir = mountedPlayer.gravDir;
						float x = mountedPlayer.position.X;
						float y = mountedPlayer.position.Y;
						int width = mountedPlayer.width;
						bool wet = mountedPlayer.wet;
						float gravDir2 = mountedPlayer.gravDir;
						int type2 = this._type;
						float y2 = mountedPlayer.position.Y;
						mountedPlayer.position.Y = y2;
					}
				}
			}
		}

		// Token: 0x0600293E RID: 10558 RVA: 0x001996B8 File Offset: 0x001978B8
		public int GetIntendedGroundedFrame(Player mountedPlayer)
		{
			do
			{
				float x = mountedPlayer.velocity.X;
			}
			while ((mountedPlayer.slippy || mountedPlayer.slippy2 || mountedPlayer.windPushed) && !mountedPlayer.controlLeft && !mountedPlayer.controlRight);
			return 1;
		}

		// Token: 0x0600293F RID: 10559 RVA: 0x001996FC File Offset: 0x001978FC
		public void TryLanding(Player mountedPlayer)
		{
			int frameState = this._frameState;
			if (!mountedPlayer.controlUp && !mountedPlayer.controlDown)
			{
				bool controlJump = mountedPlayer.controlJump;
				if (!controlJump)
				{
					if (!controlJump)
					{
					}
					if (!true)
					{
					}
					float gravDir = mountedPlayer.gravDir;
					float x = mountedPlayer.position.X;
					float y = mountedPlayer.position.Y;
					int width = mountedPlayer.width;
					bool wet = mountedPlayer.wet;
					float gravDir2 = mountedPlayer.gravDir;
					if (!true)
					{
					}
					float x2 = mountedPlayer.velocity.X;
					return;
				}
			}
		}

		// Token: 0x06002940 RID: 10560 RVA: 0x001997B8 File Offset: 0x001979B8
		private void UpdateFrame_GolfCart(Player mountedPlayer, int state, Vector2 velocity)
		{
			int frameExtra = this._frameExtra;
		}

		// Token: 0x06002941 RID: 10561 RVA: 0x00199864 File Offset: 0x00197A64
		private static void EmitGolfCartSmoke(Player mountedPlayer, bool rushing)
		{
			Vector2 bottom = mountedPlayer.Bottom;
			int direction = mountedPlayer.direction;
			float gravDir = mountedPlayer.gravDir;
			if (direction == 0)
			{
			}
			int direction2 = mountedPlayer.direction;
			float gravDir2 = mountedPlayer.gravDir;
			if (direction == 0)
			{
			}
			Dust dust;
			float x = dust.velocity.X;
			float y = dust.velocity.Y;
			dust.velocity.X = x;
			dust.velocity.Y = y;
			int direction3 = mountedPlayer.direction;
			float gravDir3 = mountedPlayer.gravDir;
			dust.velocity.X = x;
			dust.velocity.Y = y;
			dust.scale = (float)16128;
			float x2 = mountedPlayer.velocity.X;
			dust.fadeIn = (float)52429;
		}

		// Token: 0x06002942 RID: 10562 RVA: 0x00199948 File Offset: 0x00197B48
		private static void EmitGolfCartlight(Vector2 worldLocation, int playerDirection)
		{
			Point point;
			Vector2 vector = point.ToVector2();
		}

		// Token: 0x06002943 RID: 10563 RVA: 0x0019996C File Offset: 0x00197B6C
		private static bool ShouldGolfCartEmitLight()
		{
			return true;
		}

		// Token: 0x06002944 RID: 10564 RVA: 0x0019997C File Offset: 0x00197B7C
		private static void EmitGolfCartWheelDust(Player mountedPlayer, Vector2 legSpot)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int num2;
			if (num2 == 0)
			{
				float gravDir = mountedPlayer.gravDir;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				Point point;
				bool flag = WorldGen.SolidTile(point);
				Tile tile;
				int num3 = WorldGen.KillTile_GetTileDustAmount(true, tile);
				int direction = mountedPlayer.direction;
				float gravDir2 = mountedPlayer.gravDir;
				if (direction == 0)
				{
				}
				float x = mountedPlayer.position.X;
				mountedPlayer.position.X = gravDir2;
				mountedPlayer.position.X = gravDir2;
				float y = mountedPlayer.velocity.Y;
				float y2 = mountedPlayer.position.Y;
				mountedPlayer.velocity.Y = y;
			}
		}

		// Token: 0x06002945 RID: 10565 RVA: 0x00199A24 File Offset: 0x00197C24
		private void DoGemMinecartEffect(Player mountedPlayer, int dustType)
		{
			if (!true)
			{
			}
			int num;
			if (num == 0)
			{
				if (!true)
				{
				}
				Vector2 directions = mountedPlayer.Directions;
				Vector2 center = mountedPlayer.Center;
				Dust dust;
				float x = dust.velocity.X;
				float y = dust.velocity.Y;
				dust.fadeIn = (float)39322;
				dust.noGravity = true;
				dust.scale = (float)52429;
				dust.velocity.X = x;
				dust.velocity.Y = y;
				if (52429 == 0)
				{
				}
				int cMinecart = mountedPlayer.cMinecart;
				ArmorShaderData armorShaderData;
				dust.shader = armorShaderData;
			}
		}

		// Token: 0x06002946 RID: 10566 RVA: 0x00199ACC File Offset: 0x00197CCC
		private void DoSteamMinecartEffect(Player mountedPlayer, int dustType)
		{
			float x = mountedPlayer.velocity.X;
			if (!true)
			{
			}
			int frame = this._frame;
			if (frame == 0)
			{
				if (frame == 0)
				{
				}
				Vector2 directions = mountedPlayer.Directions;
				Vector2 center = mountedPlayer.Center;
				Dust dust;
				float x2 = dust.velocity.X;
				float y = dust.velocity.Y;
				dust.fadeIn = (float)39322;
				dust.noGravity = true;
				dust.scale = (float)26214;
				dust.velocity.X = x2;
				dust.velocity.Y = y;
				if (26214 == 0)
				{
				}
				int cMinecart = mountedPlayer.cMinecart;
				ArmorShaderData armorShaderData;
				dust.shader = armorShaderData;
			}
		}

		// Token: 0x06002947 RID: 10567 RVA: 0x00199B88 File Offset: 0x00197D88
		private void DoExhaustMinecartEffect(Player mountedPlayer, int dustType)
		{
			if (!true)
			{
			}
			int num;
			if (num == 0)
			{
				int num2 = 39322;
				int num3 = 39322;
				Vector2 directions = mountedPlayer.Directions;
				int direction = mountedPlayer.direction;
				float x = mountedPlayer.velocity.X;
				float y = mountedPlayer.velocity.Y;
				if (direction == 0)
				{
				}
				int num4 = 43691;
				Vector2 center = mountedPlayer.Center;
				if (num4 == 0)
				{
				}
				Dust dust;
				float x2 = dust.velocity.X;
				float y2 = dust.velocity.Y;
				int num5 = 1;
				dust.noGravity = num5 != 0;
				dust.fadeIn = (float)num2;
				dust.scale = (float)num3;
				dust.velocity.X = x2;
				dust.velocity.Y = y2;
				int direction2 = mountedPlayer.direction;
				dust.velocity.X = x2;
				if (num5 == 0)
				{
				}
				int cMinecart = mountedPlayer.cMinecart;
				ArmorShaderData armorShaderData;
				dust.shader = armorShaderData;
			}
		}

		// Token: 0x06002948 RID: 10568 RVA: 0x00199C84 File Offset: 0x00197E84
		private void DoConfettiMinecartEffect(Player mountedPlayer)
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
				int num3;
				if (num3 == 0)
				{
					int num4 = 1;
					Vector2 directions = mountedPlayer.Directions;
					int direction = mountedPlayer.direction;
					float x = mountedPlayer.velocity.X;
					float y = mountedPlayer.velocity.Y;
					if (direction == 0)
					{
					}
					int num5 = 43691;
					Vector2 center = mountedPlayer.Center;
					if (num5 == 0)
					{
					}
					if (num5 == 0)
					{
					}
					Dust dust;
					float x2 = dust.velocity.X;
					float y2 = dust.velocity.Y;
					dust.noGravity = num4 != 0;
					float num6;
					dust.fadeIn = num6;
					dust.velocity.X = x2;
					dust.velocity.Y = y2;
					int direction2 = mountedPlayer.direction;
					dust.velocity.X = x2;
					int cMinecart = mountedPlayer.cMinecart;
					ArmorShaderData armorShaderData;
					dust.shader = armorShaderData;
				}
			}
		}

		// Token: 0x06002949 RID: 10569 RVA: 0x00199D7C File Offset: 0x00197F7C
		public void UpdateEffects(Player mountedPlayer)
		{
			bool constantJump = this._data.constantJump;
			mountedPlayer.autoJump = constantJump;
			if (!constantJump)
			{
			}
			if (constantJump)
			{
				bool usingSuperCart = mountedPlayer.UsingSuperCart;
				this._shouldSuperCart = constantJump;
				this.CastSuperCartLaser(mountedPlayer);
				float x = mountedPlayer.velocity.X;
				if (!constantJump)
				{
				}
				float runSpeed = this.RunSpeed;
				int statDefense = mountedPlayer.statDefense;
				mountedPlayer.statDefense = statDefense;
				return;
			}
			int type = this._type;
		}

		// Token: 0x0600294A RID: 10570 RVA: 0x0019A5C4 File Offset: 0x001987C4
		private void CastSuperCartLaser(Player mountedPlayer)
		{
			int num = 1;
			float x = mountedPlayer.velocity.X;
			if (num == 0)
			{
			}
			int num2;
			if (num2 == 0)
			{
				int direction = mountedPlayer.direction;
			}
			int whoAmI = mountedPlayer.whoAmI;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			float x2 = mountedPlayer.velocity.X;
			if (num == 0)
			{
			}
			long num3 = 0L;
			long num4 = 0L;
			float num6;
			float num5 = MathHelper.WrapAngle(num6);
			float fullRotation = mountedPlayer.fullRotation;
			float num7 = MathHelper.WrapAngle(num5);
			float num8 = MathHelper.WrapAngle(num7);
			Vector2 minecartMechPoint = Mount.GetMinecartMechPoint(mountedPlayer, (int)num4, (int)num3);
			IEntitySource projectileSpawnSource = this.GetProjectileSpawnSource(mountedPlayer);
			int whoAmI2 = mountedPlayer.whoAmI;
		}

		// Token: 0x0600294B RID: 10571 RVA: 0x0019A678 File Offset: 0x00198878
		public static Vector2 GetMinecartMechPoint(Player mountedPlayer, int offX, int offY)
		{
			/*
An exception occurred when decompiling this method (0600294B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 Terraria.Mount::GetMinecartMechPoint(Terraria.Player,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_003A:
	stloc:float32(var_9_43, ldfld:float32(Player::fullRotation, ldloc:Player(mountedPlayer)))
	stloc:float32(var_12_4E, ldfld:float32(Player::fullRotation, ldloc:Player(mountedPlayer)))
	stloc:float32(var_15_59, ldfld:float32(Player::fullRotation, ldloc:Player(mountedPlayer)))
	stloc:float32(var_18_64, ldfld:float32(Player::fullRotation, ldloc:Player(mountedPlayer)))
	stloc:int32(var_20_70, call:int32(Math::Sign, ldloc:float32(var_11)))
	stloc:float32(var_21_78, ldfld:float32(Player::fullRotation, ldloc:Player(mountedPlayer)))
	stloc:Vector2(var_26_86, callgetter:Vector2(Entity::get_Bottom, ldloc:Player[exp:Entity](mountedPlayer)))
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

		// Token: 0x0600294C RID: 10572 RVA: 0x0019A714 File Offset: 0x00198914
		public void ResetFlightTime(float xVelocity)
		{
			if (this._active)
			{
				int flightTimeMax = this._data.flightTimeMax;
				return;
			}
			long num = 0L;
			int type = this._type;
			this._flyTime = (int)num;
			if (type == 0)
			{
				int num2 = 32640;
				this._flyTime = num2;
			}
		}

		// Token: 0x0600294D RID: 10573 RVA: 0x0019A758 File Offset: 0x00198958
		public void CheckMountBuff(Player mountedPlayer)
		{
			if (this._type == 0)
			{
			}
			int[] buffType = mountedPlayer.buffType;
			Mount.MountData data = this._data;
			int buff = data.buff;
			if (data != null && this._active && data.Minecart)
			{
				int extraBuff = data.extraBuff;
			}
		}

		// Token: 0x0600294E RID: 10574 RVA: 0x0019A7AC File Offset: 0x001989AC
		public void ResetHeadPosition()
		{
			if (this._aiming)
			{
				int type = this._type;
			}
		}

		// Token: 0x0600294F RID: 10575 RVA: 0x0019A7C8 File Offset: 0x001989C8
		private Vector2 ClampToDeadZone(Player mountedPlayer, Vector2 position)
		{
			int type = this._type;
			if (type == 0)
			{
			}
			if (type == 0)
			{
			}
			if (type == 0)
			{
			}
			int num = 32640;
			Vector2 center = mountedPlayer.Center;
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06002950 RID: 10576 RVA: 0x0019A7FC File Offset: 0x001989FC
		public bool AimAbility(Player mountedPlayer, Vector2 mousePosition)
		{
			int type = this._type;
			int num = 1;
			this._aiming = num != 0;
			int direction = mountedPlayer.direction;
			int frameExtra = this._frameExtra;
			Vector2 vector = this.ClampToDeadZone(mountedPlayer, mousePosition);
			Vector2 center = mountedPlayer.Center;
			if (direction == 0)
			{
			}
			if (direction == 0)
			{
			}
			float num3;
			float num2 = MathHelper.ToDegrees(num3);
			int num4 = 17204;
			int frameExtra2 = this._frameExtra;
			int direction2 = mountedPlayer.direction;
			Vector2 vector2 = this.ClampToDeadZone(mountedPlayer, mousePosition);
			Vector2 center2 = mountedPlayer.Center;
			if (num4 == 0)
			{
			}
			if (num4 == 0)
			{
			}
			float num6;
			float num5 = MathHelper.ToDegrees(num6);
			float x = mountedPlayer.velocity.X;
			int num7 = 1;
			mountedPlayer.direction = num7;
			Vector2 vector3 = this.ClampToDeadZone(mountedPlayer, mousePosition);
			Vector2 center3 = mountedPlayer.Center;
			if (num7 == 0)
			{
			}
			if (this._mountSpecificData != null)
			{
			}
			float x2 = mountedPlayer.velocity.X;
			int width = mountedPlayer.width;
			int height = mountedPlayer.height;
			float x3 = mountedPlayer.position.X;
			float y = mountedPlayer.position.Y;
			int num8 = 1;
			long num9 = 0L;
			Lighting.AddLight(0, (int)num9, num2, num5, num5);
			if (num8 != 0)
			{
				int direction3 = mountedPlayer.direction;
				int height2 = mountedPlayer.height;
				return false;
			}
			int direction4 = mountedPlayer.direction;
			return false;
		}

		// Token: 0x06002951 RID: 10577 RVA: 0x0019A9E0 File Offset: 0x00198BE0
		public void Draw(PlayerDrawSet playerDrawData, int drawType, Player drawPlayer, Vector2 Position, Color drawColor, SpriteEffects playerEffect, float shadow)
		{
		}

		// Token: 0x06002952 RID: 10578 RVA: 0x0019AEB4 File Offset: 0x001990B4
		public void Dismount(Player mountedPlayer)
		{
			while (this._active)
			{
				Mount.MountData data = this._data;
				if (data == null)
				{
					if (116 == 0)
					{
					}
					if (!true)
					{
					}
					long num = 0L;
					this.DoSpawnDust(mountedPlayer, num != 0L);
					long num2 = 0L;
					this._idleTime = (int)num2;
					int height = mountedPlayer.height;
					float y = mountedPlayer.position.Y;
					int num3 = 42;
					mountedPlayer.height = num3;
					mountedPlayer.position.Y = (float)height;
					int whoAmI = mountedPlayer.whoAmI;
					if (num3 == 0)
					{
					}
					int myPlayer = Main.myPlayer;
					int whoAmI2 = mountedPlayer.whoAmI;
					break;
				}
				bool minecart = data.Minecart;
				int buff = data.buff;
				mountedPlayer.ClearBuff(buff);
				if (minecart)
				{
					Mount.MountData data2 = this._data;
					int extraBuff = data2.extraBuff;
					mountedPlayer.ClearBuff(extraBuff);
					if (data2 == null)
					{
					}
					if (!true)
					{
					}
					return;
				}
			}
		}

		// Token: 0x06002953 RID: 10579 RVA: 0x0019AF7C File Offset: 0x0019917C
		public void SetMount(int m, Player mountedPlayer, bool faceLeft = false)
		{
			if (this._type == 0)
			{
			}
			if (mountedPlayer.wet)
			{
				return;
			}
			if (this._active)
			{
				int buff = this._data.buff;
				mountedPlayer.ClearBuff(buff);
				Mount.MountData data = this._data;
				if (data != null && this._active && data.Minecart)
				{
					int extraBuff = data.extraBuff;
					mountedPlayer.ClearBuff(extraBuff);
					if (data == null)
					{
					}
					if (!true)
					{
					}
				}
				if (!true)
				{
				}
				return;
			}
			int num = 1;
			this._active = num != 0;
			this._type = m;
			if (num == 0)
			{
			}
			this._data = num;
			if (num != 0)
			{
				bool active = this._active;
				if (active && active && !active)
				{
					return;
				}
			}
			long num2 = 0L;
			int type = this._type;
			this._flipDraw = num2 != 0L;
			float x = mountedPlayer.velocity.X;
			float y = mountedPlayer.velocity.Y;
			if (type == 0)
			{
			}
			int type2 = this._type;
			int abilityCooldown = this._abilityCooldown;
		}

		// Token: 0x06002954 RID: 10580 RVA: 0x0019B12C File Offset: 0x0019932C
		private void DoSpawnDust(Player mountedPlayer, bool isDismounting)
		{
			if (!true)
			{
			}
			bool netHostOnly = Main.NetHostOnly;
			int type = this._type;
			int num = 1;
			float x = mountedPlayer.position.X;
			float y = mountedPlayer.position.Y;
			int width = mountedPlayer.width;
			bool wet = mountedPlayer.wet;
			if (type == 0)
			{
			}
			Dust dust;
			float scale = dust.scale;
			if (type == 0)
			{
			}
			dust.noGravity = num != 0;
			dust.scale = x;
			float x2 = dust.velocity.X;
			float y2 = dust.velocity.Y;
			float x3 = mountedPlayer.velocity.X;
			float y3 = mountedPlayer.velocity.Y;
			if (type == 0)
			{
			}
			dust.velocity.X = x;
			dust.velocity.Y = y;
			dust.velocity.X = x;
			dust.velocity.Y = y;
			dust.velocity.Y = x;
			dust.noLight = num != 0;
			int num2;
			if (num2 == 0)
			{
				Dust dust2 = Dust.CloneDust(dust);
				float scale2 = dust2.scale;
				dust2.scale = scale2;
			}
		}

		// Token: 0x06002955 RID: 10581 RVA: 0x0019B450 File Offset: 0x00199650
		public bool CanMount(int m, Player mountingPlayer)
		{
			if (!true)
			{
			}
			return mountingPlayer.CanFitSpace(m);
		}

		// Token: 0x06002956 RID: 10582 RVA: 0x0019B468 File Offset: 0x00199668
		public bool FindTileHeight(Vector2 position, int maxTilesDown, [Out] float tileHeight)
		{
			/*
An exception occurred when decompiling this method (06002956)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Mount::FindTileHeight(Microsoft.Xna.Framework.Vector2,System.Int32,System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000B:
	stloc:uint16(var_3_11, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_2)))
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

		// Token: 0x06002957 RID: 10583 RVA: 0x0019B48C File Offset: 0x0019968C
		// Note: this type is marked as 'beforefieldinit'.
		static Mount()
		{
		}

		// Token: 0x040035E3 RID: 13795
		public static int currentShader;

		// Token: 0x040035E4 RID: 13796
		public const int FrameStanding = 0;

		// Token: 0x040035E5 RID: 13797
		public const int FrameRunning = 1;

		// Token: 0x040035E6 RID: 13798
		public const int FrameInAir = 2;

		// Token: 0x040035E7 RID: 13799
		public const int FrameFlying = 3;

		// Token: 0x040035E8 RID: 13800
		public const int FrameSwimming = 4;

		// Token: 0x040035E9 RID: 13801
		public const int FrameDashing = 5;

		// Token: 0x040035EA RID: 13802
		public const int DrawBack = 0;

		// Token: 0x040035EB RID: 13803
		public const int DrawBackExtra = 1;

		// Token: 0x040035EC RID: 13804
		public const int DrawFront = 2;

		// Token: 0x040035ED RID: 13805
		public const int DrawFrontExtra = 3;

		// Token: 0x040035EE RID: 13806
		private static Mount.MountData[] mounts;

		// Token: 0x040035EF RID: 13807
		private static Vector2[] scutlixEyePositions;

		// Token: 0x040035F0 RID: 13808
		private static Vector2 scutlixTextureSize;

		// Token: 0x040035F1 RID: 13809
		public const int scutlixBaseDamage = 50;

		// Token: 0x040035F2 RID: 13810
		public static Vector2 drillDiodePoint1;

		// Token: 0x040035F3 RID: 13811
		public static Vector2 drillDiodePoint2;

		// Token: 0x040035F4 RID: 13812
		public static Vector2 drillTextureSize;

		// Token: 0x040035F5 RID: 13813
		public const int drillTextureWidth = 80;

		// Token: 0x040035F6 RID: 13814
		public const float drillRotationChange = 0.05235988f;

		// Token: 0x040035F7 RID: 13815
		public static int drillPickPower;

		// Token: 0x040035F8 RID: 13816
		public static int drillPickTime;

		// Token: 0x040035F9 RID: 13817
		public static int amountOfBeamsAtOnce;

		// Token: 0x040035FA RID: 13818
		public const float maxDrillLength = 48f;

		// Token: 0x040035FB RID: 13819
		private static Vector2 santankTextureSize;

		// Token: 0x040035FC RID: 13820
		private Mount.MountData _data;

		// Token: 0x040035FD RID: 13821
		private int _type;

		// Token: 0x040035FE RID: 13822
		private bool _flipDraw;

		// Token: 0x040035FF RID: 13823
		private int _frame;

		// Token: 0x04003600 RID: 13824
		private float _frameCounter;

		// Token: 0x04003601 RID: 13825
		private int _frameExtra;

		// Token: 0x04003602 RID: 13826
		private float _frameExtraCounter;

		// Token: 0x04003603 RID: 13827
		private int _frameState;

		// Token: 0x04003604 RID: 13828
		private int _flyTime;

		// Token: 0x04003605 RID: 13829
		private int _idleTime;

		// Token: 0x04003606 RID: 13830
		private int _idleTimeNext;

		// Token: 0x04003607 RID: 13831
		private float _fatigue;

		// Token: 0x04003608 RID: 13832
		private float _fatigueMax;

		// Token: 0x04003609 RID: 13833
		private bool _abilityCharging;

		// Token: 0x0400360A RID: 13834
		private int _abilityCharge;

		// Token: 0x0400360B RID: 13835
		private int _abilityCooldown;

		// Token: 0x0400360C RID: 13836
		private int _abilityDuration;

		// Token: 0x0400360D RID: 13837
		private bool _abilityActive;

		// Token: 0x0400360E RID: 13838
		private bool _aiming;

		// Token: 0x0400360F RID: 13839
		private bool _shouldSuperCart;

		// Token: 0x04003610 RID: 13840
		public List<DrillDebugDraw> _debugDraw;

		// Token: 0x04003611 RID: 13841
		private object _mountSpecificData;

		// Token: 0x04003612 RID: 13842
		private bool _active;

		// Token: 0x04003613 RID: 13843
		public static float SuperCartRunSpeed;

		// Token: 0x04003614 RID: 13844
		public static float SuperCartDashSpeed;

		// Token: 0x04003615 RID: 13845
		public static float SuperCartAcceleration;

		// Token: 0x04003616 RID: 13846
		public static int SuperCartJumpHeight;

		// Token: 0x04003617 RID: 13847
		public static float SuperCartJumpSpeed;

		// Token: 0x04003618 RID: 13848
		private Mount.MountDelegatesData _defaultDelegatesData;

		// Token: 0x04003619 RID: 13849
		private static Mount.DrillMountData DrillSmartCursor_BlocksPlotData;

		// Token: 0x0400361A RID: 13850
		private static int DrillSmartCursor_BlocksPlotX;

		// Token: 0x0400361B RID: 13851
		private static int DrillSmartCursor_BlocksPlotY;

		// Token: 0x0400361C RID: 13852
		private static Utils.TileActionAttempt DrillSmartCursor_BlocksPlotInstance;

		// Token: 0x02000442 RID: 1090
		private class DrillBeam
		{
			// Token: 0x06002958 RID: 10584 RVA: 0x0019B49C File Offset: 0x0019969C
			public DrillBeam()
			{
				if (!true)
				{
				}
				this.curTileTarget = 1;
			}

			// Token: 0x0400361D RID: 13853
			public Point16 curTileTarget;

			// Token: 0x0400361E RID: 13854
			public int cooldown;

			// Token: 0x0400361F RID: 13855
			public int lastPurpose;
		}

		// Token: 0x02000443 RID: 1091
		private class DrillMountData
		{
			// Token: 0x06002959 RID: 10585 RVA: 0x0019B4BC File Offset: 0x001996BC
			public DrillMountData()
			{
				Mount.DrillBeam[] array = this.beams;
			}

			// Token: 0x04003620 RID: 13856
			public float diodeRotationTarget;

			// Token: 0x04003621 RID: 13857
			public float diodeRotation;

			// Token: 0x04003622 RID: 13858
			public float outerRingRotation;

			// Token: 0x04003623 RID: 13859
			public Mount.DrillBeam[] beams;

			// Token: 0x04003624 RID: 13860
			public int beamCooldown;

			// Token: 0x04003625 RID: 13861
			public Vector2 crosshairPosition;
		}

		// Token: 0x02000444 RID: 1092
		private class BooleanMountData
		{
			// Token: 0x0600295A RID: 10586 RVA: 0x0019B4E4 File Offset: 0x001996E4
			public BooleanMountData()
			{
			}

			// Token: 0x04003626 RID: 13862
			public bool boolean;
		}

		// Token: 0x02000445 RID: 1093
		private class ExtraFrameMountData
		{
			// Token: 0x0600295B RID: 10587 RVA: 0x0019B4F8 File Offset: 0x001996F8
			public ExtraFrameMountData()
			{
			}

			// Token: 0x04003627 RID: 13863
			public int frame;

			// Token: 0x04003628 RID: 13864
			public float frameCounter;
		}

		// Token: 0x02000446 RID: 1094
		public class MountDelegatesData
		{
			// Token: 0x0600295C RID: 10588 RVA: 0x0019B50C File Offset: 0x0019970C
			public MountDelegatesData()
			{
			}

			// Token: 0x04003629 RID: 13865
			public Action<Vector2> MinecartDust;

			// Token: 0x0400362A RID: 13866
			public Action<Player, Vector2, int, int> MinecartJumpingSound;

			// Token: 0x0400362B RID: 13867
			public Action<Player, Vector2, int, int> MinecartLandingSound;

			// Token: 0x0400362C RID: 13868
			public Action<Player, Vector2, int, int> MinecartBumperSound;

			// Token: 0x0400362D RID: 13869
			public Mount.MountDelegatesData.OverridePositionMethod MouthPosition;

			// Token: 0x0400362E RID: 13870
			public Mount.MountDelegatesData.OverridePositionMethod HandPosition;

			// Token: 0x02000447 RID: 1095
			// (Invoke) Token: 0x0600295E RID: 10590
			public delegate bool OverridePositionMethod(Player player, [Out] Vector2? position);
		}

		// Token: 0x02000448 RID: 1096
		private class MountData
		{
			// Token: 0x06002961 RID: 10593 RVA: 0x0019B520 File Offset: 0x00199720
			public MountData()
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
				base..ctor();
			}

			// Token: 0x0400362F RID: 13871
			public Asset<Texture2D> backTexture;

			// Token: 0x04003630 RID: 13872
			public Asset<Texture2D> backTextureGlow;

			// Token: 0x04003631 RID: 13873
			public Asset<Texture2D> backTextureExtra;

			// Token: 0x04003632 RID: 13874
			public Asset<Texture2D> backTextureExtraGlow;

			// Token: 0x04003633 RID: 13875
			public Asset<Texture2D> frontTexture;

			// Token: 0x04003634 RID: 13876
			public Asset<Texture2D> frontTextureGlow;

			// Token: 0x04003635 RID: 13877
			public Asset<Texture2D> frontTextureExtra;

			// Token: 0x04003636 RID: 13878
			public Asset<Texture2D> frontTextureExtraGlow;

			// Token: 0x04003637 RID: 13879
			public int textureWidth;

			// Token: 0x04003638 RID: 13880
			public int textureHeight;

			// Token: 0x04003639 RID: 13881
			public int xOffset;

			// Token: 0x0400363A RID: 13882
			public int yOffset;

			// Token: 0x0400363B RID: 13883
			public int[] playerYOffsets;

			// Token: 0x0400363C RID: 13884
			public int bodyFrame;

			// Token: 0x0400363D RID: 13885
			public int playerHeadOffset;

			// Token: 0x0400363E RID: 13886
			public int heightBoost;

			// Token: 0x0400363F RID: 13887
			public int buff;

			// Token: 0x04003640 RID: 13888
			public int extraBuff;

			// Token: 0x04003641 RID: 13889
			public int flightTimeMax;

			// Token: 0x04003642 RID: 13890
			public bool usesHover;

			// Token: 0x04003643 RID: 13891
			public float runSpeed;

			// Token: 0x04003644 RID: 13892
			public float dashSpeed;

			// Token: 0x04003645 RID: 13893
			public float swimSpeed;

			// Token: 0x04003646 RID: 13894
			public float acceleration;

			// Token: 0x04003647 RID: 13895
			public float jumpSpeed;

			// Token: 0x04003648 RID: 13896
			public int jumpHeight;

			// Token: 0x04003649 RID: 13897
			public float fallDamage;

			// Token: 0x0400364A RID: 13898
			public int fatigueMax;

			// Token: 0x0400364B RID: 13899
			public bool constantJump;

			// Token: 0x0400364C RID: 13900
			public bool blockExtraJumps;

			// Token: 0x0400364D RID: 13901
			public int abilityChargeMax;

			// Token: 0x0400364E RID: 13902
			public int abilityDuration;

			// Token: 0x0400364F RID: 13903
			public int abilityCooldown;

			// Token: 0x04003650 RID: 13904
			public int spawnDust;

			// Token: 0x04003651 RID: 13905
			public bool spawnDustNoGravity;

			// Token: 0x04003652 RID: 13906
			public int totalFrames;

			// Token: 0x04003653 RID: 13907
			public int standingFrameStart;

			// Token: 0x04003654 RID: 13908
			public int standingFrameCount;

			// Token: 0x04003655 RID: 13909
			public int standingFrameDelay;

			// Token: 0x04003656 RID: 13910
			public int runningFrameStart;

			// Token: 0x04003657 RID: 13911
			public int runningFrameCount;

			// Token: 0x04003658 RID: 13912
			public int runningFrameDelay;

			// Token: 0x04003659 RID: 13913
			public int flyingFrameStart;

			// Token: 0x0400365A RID: 13914
			public int flyingFrameCount;

			// Token: 0x0400365B RID: 13915
			public int flyingFrameDelay;

			// Token: 0x0400365C RID: 13916
			public int inAirFrameStart;

			// Token: 0x0400365D RID: 13917
			public int inAirFrameCount;

			// Token: 0x0400365E RID: 13918
			public int inAirFrameDelay;

			// Token: 0x0400365F RID: 13919
			public int idleFrameStart;

			// Token: 0x04003660 RID: 13920
			public int idleFrameCount;

			// Token: 0x04003661 RID: 13921
			public int idleFrameDelay;

			// Token: 0x04003662 RID: 13922
			public bool idleFrameLoop;

			// Token: 0x04003663 RID: 13923
			public int swimFrameStart;

			// Token: 0x04003664 RID: 13924
			public int swimFrameCount;

			// Token: 0x04003665 RID: 13925
			public int swimFrameDelay;

			// Token: 0x04003666 RID: 13926
			public int dashingFrameStart;

			// Token: 0x04003667 RID: 13927
			public int dashingFrameCount;

			// Token: 0x04003668 RID: 13928
			public int dashingFrameDelay;

			// Token: 0x04003669 RID: 13929
			public bool Minecart;

			// Token: 0x0400366A RID: 13930
			public bool MinecartDirectional;

			// Token: 0x0400366B RID: 13931
			public Vector3 lightColor;

			// Token: 0x0400366C RID: 13932
			public bool emitsLight;

			// Token: 0x0400366D RID: 13933
			public Mount.MountDelegatesData delegations;

			// Token: 0x0400366E RID: 13934
			public int playerXOffset;
		}

		// Token: 0x02000449 RID: 1097
		[CompilerGenerated]
		private sealed class <>c__DisplayClass141_0
		{
			// Token: 0x06002962 RID: 10594 RVA: 0x0019B53C File Offset: 0x0019973C
			public <>c__DisplayClass141_0()
			{
			}

			// Token: 0x06002963 RID: 10595 RVA: 0x0019B550 File Offset: 0x00199750
			internal bool <DrillSmartCursor_Walls>b__0(int x, int y)
			{
				Mount.DrillBeam[] beams = this.data.beams;
				int lastPurpose = beams.lastPurpose;
				Point16 curTileTarget = beams.curTileTarget;
				if (lastPurpose == 0)
				{
				}
				Mount.DrillBeam[] beams2 = this.data.beams;
				Point16 point = this.tilePoint;
				bool flag;
				return flag;
			}

			// Token: 0x0400366F RID: 13935
			public Point16 tilePoint;

			// Token: 0x04003670 RID: 13936
			public Mount.DrillMountData data;
		}
	}
}
