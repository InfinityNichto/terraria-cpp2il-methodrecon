using System;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.Golf
{
	// Token: 0x02000A0A RID: 2570
	public class GolfState
	{
		// Token: 0x06004BD2 RID: 19410 RVA: 0x002703CC File Offset: 0x0026E5CC
		private void UpdateScoreTime()
		{
			int num = this.golfScoreTime;
			int num2 = this.golfScoreDelay;
			this.golfScoreTime = num;
		}

		// Token: 0x06004BD3 RID: 19411 RVA: 0x002703F0 File Offset: 0x0026E5F0
		public void ResetScoreTime()
		{
		}

		// Token: 0x06004BD4 RID: 19412 RVA: 0x00270400 File Offset: 0x0026E600
		public void SetScoreTime()
		{
			int num = this.golfScoreTimeMax;
			this.golfScoreTime = num;
		}

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x06004BD5 RID: 19413 RVA: 0x0027041C File Offset: 0x0026E61C
		public float ScoreAdjustment
		{
			get
			{
				/*
An exception occurred when decompiling this method (06004BD5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.GameContent.Golf.GolfState::get_ScoreAdjustment()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(GolfState::golfScoreTime, ldloc:GolfState(this)))
	stloc:int32(var_1_0D, ldfld:int32(GolfState::golfScoreTimeMax, ldloc:GolfState(this)))
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

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x06004BD6 RID: 19414 RVA: 0x00270438 File Offset: 0x0026E638
		public bool ShouldScoreHole
		{
			get
			{
				/*
An exception occurred when decompiling this method (06004BD6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Golf.GolfState::get_ShouldScoreHole()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(GolfState::golfScoreTime, ldloc:GolfState(this)))
	stloc:int32(var_1_0D, ldfld:int32(GolfState::golfScoreDelay, ldloc:GolfState(this)))
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

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x06004BD7 RID: 19415 RVA: 0x00270454 File Offset: 0x0026E654
		public bool IsTrackingBall
		{
			get
			{
				/*
An exception occurred when decompiling this method (06004BD7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Golf.GolfState::get_IsTrackingBall()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_0E, ldfld:bool(GolfState::_waitingForBallToSettle, ldloc:GolfState(this)))
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

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x06004BD8 RID: 19416 RVA: 0x00270470 File Offset: 0x0026E670
		public bool ShouldCameraTrackBallLastKnownLocation
		{
			get
			{
				/*
An exception occurred when decompiling this method (06004BD8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Golf.GolfState::get_ShouldCameraTrackBallLastKnownLocation()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000A:
	stloc:Projectile(var_3_12, call:Projectile(GolfState::GetLastHitBall, ldloc:GolfState(this)))
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

		// Token: 0x06004BD9 RID: 19417 RVA: 0x00270490 File Offset: 0x0026E690
		public Vector2? GetLastBallLocation()
		{
			return this._lastRecordedBallLocation;
		}

		// Token: 0x06004BDA RID: 19418 RVA: 0x002704A4 File Offset: 0x0026E6A4
		public void WorldClear()
		{
		}

		// Token: 0x06004BDB RID: 19419 RVA: 0x002704B4 File Offset: 0x0026E6B4
		public void CancelBallTracking()
		{
		}

		// Token: 0x06004BDC RID: 19420 RVA: 0x002704C4 File Offset: 0x0026E6C4
		public void RecordSwing(Projectile golfBall)
		{
			Vector2 position = golfBall.position;
			this._lastSwingPosition = position;
			this._lastHitGolfBall = golfBall;
			int num = 1;
			this._waitingForBallToSettle = num != 0;
			this._lastRecordedSwingCount = position;
			GolfBallTrackRecord[] hitRecords = this._hitRecords;
			GolfBallTrackRecord[] hitRecords2 = this._hitRecords;
			float x = golfBall.position.X;
			float y = golfBall.position.Y;
		}

		// Token: 0x06004BDD RID: 19421 RVA: 0x00270528 File Offset: 0x0026E728
		private int GetGolfBallId(Projectile golfBall)
		{
			return golfBall.whoAmI;
		}

		// Token: 0x06004BDE RID: 19422 RVA: 0x0027053C File Offset: 0x0026E73C
		public Projectile GetLastHitBall()
		{
			Projectile lastHitGolfBall = this._lastHitGolfBall;
			if (lastHitGolfBall == null)
			{
				return;
			}
			bool active = lastHitGolfBall.active;
			if (!active)
			{
				return;
			}
			Projectile lastHitGolfBall2;
			if (!active)
			{
				lastHitGolfBall2 = this._lastHitGolfBall;
			}
			if (active)
			{
				int owner = lastHitGolfBall2.owner;
				int myPlayer = Main.myPlayer;
				Projectile lastHitGolfBall3 = this._lastHitGolfBall;
				int lastRecordedSwingCount = this._lastRecordedSwingCount;
				return this._lastHitGolfBall;
			}
		}

		// Token: 0x06004BDF RID: 19423 RVA: 0x002705A4 File Offset: 0x0026E7A4
		public void Update()
		{
			int num = this.golfScoreTime;
			int num2 = this.golfScoreDelay;
			this.golfScoreTime = num;
			if (this.GetLastHitBall() != null)
			{
				int num3;
				if (this._waitingForBallToSettle)
				{
					num3 = 32640;
					this._waitingForBallToSettle = num3 != 0;
				}
				if (num3 == 0)
				{
				}
				int type = Main.LocalPlayer.HeldItem.type;
				if (num2 == 0)
				{
				}
				Item heldItem = Main.LocalPlayer.HeldItem;
				if (num2 == 0)
				{
				}
				bool flag = Item.IsAGolfingItem(heldItem);
			}
		}

		// Token: 0x06004BE0 RID: 19424 RVA: 0x00270620 File Offset: 0x0026E820
		public void RecordBallInfo(Projectile golfBall)
		{
			Projectile lastHitBall = this.GetLastHitBall();
			bool waitingForBallToSettle = this._waitingForBallToSettle;
			if (waitingForBallToSettle)
			{
				Vector2 center = golfBall.Center;
				if (!waitingForBallToSettle)
				{
				}
				double num;
				this._lastRecordedBallTime = num;
			}
		}

		// Token: 0x06004BE1 RID: 19425 RVA: 0x00270650 File Offset: 0x0026E850
		public void LandBall(Projectile golfBall)
		{
			GolfBallTrackRecord[] hitRecords = this._hitRecords;
			if (this != null)
			{
				float x = golfBall.position.X;
				float y = golfBall.position.Y;
				return;
			}
		}

		// Token: 0x06004BE2 RID: 19426 RVA: 0x00270680 File Offset: 0x0026E880
		public int GetGolfBallScore(Projectile golfBall)
		{
			/*
An exception occurred when decompiling this method (06004BE2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.GameContent.Golf.GolfState::GetGolfBallScore(Terraria.Projectile)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_1_10, ldfld:int32(GolfState::golfScoreTime, ldloc:GolfState(this)))
	stloc:int32(var_2_17, ldfld:int32(GolfState::golfScoreTimeMax, ldloc:GolfState(this)))
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

		// Token: 0x06004BE3 RID: 19427 RVA: 0x002706A4 File Offset: 0x0026E8A4
		public void ResetGolfBall()
		{
			int num = 1;
			Projectile lastHitBall = this.GetLastHitBall();
			if (lastHitBall != null)
			{
				float x = lastHitBall.position.X;
				float y = lastHitBall.position.Y;
				float x2 = this._lastSwingPosition.X;
				float y2 = this._lastSwingPosition.Y;
				if (num == 0)
				{
				}
				Vector2 lastSwingPosition = this._lastSwingPosition;
				lastHitBall.position = lastSwingPosition;
				if (lastSwingPosition == null)
				{
				}
				if (!true)
				{
				}
				int num2 = 1;
				lastHitBall.netUpdate2 = num2 != 0;
				int num3 = 32768;
				this._lastRecordedSwingCount = num3;
			}
		}

		// Token: 0x06004BE4 RID: 19428 RVA: 0x00270730 File Offset: 0x0026E930
		public GolfState()
		{
		}

		// Token: 0x0400860C RID: 34316
		private const int BALL_RETURN_PENALTY = 1;

		// Token: 0x0400860D RID: 34317
		private int golfScoreTime;

		// Token: 0x0400860E RID: 34318
		private int golfScoreTimeMax;

		// Token: 0x0400860F RID: 34319
		private int golfScoreDelay;

		// Token: 0x04008610 RID: 34320
		private double _lastRecordedBallTime;

		// Token: 0x04008611 RID: 34321
		private Vector2? _lastRecordedBallLocation;

		// Token: 0x04008612 RID: 34322
		private bool _waitingForBallToSettle;

		// Token: 0x04008613 RID: 34323
		private Vector2 _lastSwingPosition;

		// Token: 0x04008614 RID: 34324
		private Projectile _lastHitGolfBall;

		// Token: 0x04008615 RID: 34325
		private int _lastRecordedSwingCount;

		// Token: 0x04008616 RID: 34326
		private GolfBallTrackRecord[] _hitRecords;
	}
}
