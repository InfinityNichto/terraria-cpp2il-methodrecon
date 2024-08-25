using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent
{
	// Token: 0x020007E5 RID: 2021
	public struct PlayerSleepingHelper
	{
		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x0600410B RID: 16651 RVA: 0x00244768 File Offset: 0x00242968
		public bool FullyFallenAsleep
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600410B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.PlayerSleepingHelper::get_FullyFallenAsleep()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(PlayerSleepingHelper::timeSleeping, ldloc:valuetype Terraria.GameContent.PlayerSleepingHelper&(this)))
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

		// Token: 0x0600410C RID: 16652 RVA: 0x00244780 File Offset: 0x00242980
		public void GetSleepingOffsetInfo(Player player, [Out] Vector2 posOffset)
		{
			float x = this.visualOffsetOfBedBase.X;
			float y = this.visualOffsetOfBedBase.Y;
			Vector2 directions = player.Directions;
			int num = this.sleepingIndex;
			float gravDir = player.gravDir;
			posOffset.X = (float)num;
			posOffset.Y = gravDir;
		}

		// Token: 0x0600410D RID: 16653 RVA: 0x002447DC File Offset: 0x002429DC
		private bool DoesPlayerHaveReasonToActUpInBed(Player player)
		{
			if (!true)
			{
			}
			long num = 0L;
			bool flag = NPC.AnyDanger(true, num != 0L);
			if (!true)
			{
			}
			if (!true || !true)
			{
			}
			return true;
		}

		// Token: 0x0600410E RID: 16654 RVA: 0x0024480C File Offset: 0x00242A0C
		public void SetIsSleepingAndAdjustPlayerRotation(Player player, bool state)
		{
			int direction = player.direction;
		}

		// Token: 0x0600410F RID: 16655 RVA: 0x000021DB File Offset: 0x000003DB
		public void UpdateState(Player player)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004110 RID: 16656 RVA: 0x00244824 File Offset: 0x00242A24
		public void StopSleeping(Player player, bool multiplayerBroadcast = true)
		{
			int myPlayer = Main.myPlayer;
			int whoAmI = player.whoAmI;
		}

		// Token: 0x06004111 RID: 16657 RVA: 0x00244840 File Offset: 0x00242A40
		public void StartSleeping(Player player, int x, int y)
		{
			int num = 1;
			Vector2 bottom = player.Bottom;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Vector2 bottom2 = player.Bottom;
			int num2 = 1;
			this.StopSleeping(player, num2 != 0);
		}

		// Token: 0x06004112 RID: 16658 RVA: 0x0024490C File Offset: 0x00242B0C
		public static bool GetSleepingTargetInfo(int x, int y, [Out] int targetDirection, [Out] Vector2 anchorPosition, [Out] Vector2 visualoffset)
		{
			/*
An exception occurred when decompiling this method (06004112)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.PlayerSleepingHelper::GetSleepingTargetInfo(System.Int32,System.Int32,System.Int32,Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0036:
	stloc:Vector2(var_13_3D, call:Vector2(PlayerSleepingHelper::SetOffsetbyBed, ldloc:int16[exp:int32](var_12)))
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

		// Token: 0x06004113 RID: 16659 RVA: 0x0024495C File Offset: 0x00242B5C
		private static Vector2 SetOffsetbyBed(int bedStyle)
		{
			Vector2 vector;
			return vector;
		}

		// Token: 0x04007EC1 RID: 32449
		public const int BedSleepingMaxDistance = 96;

		// Token: 0x04007EC2 RID: 32450
		public const int TimeToFullyFallAsleep = 120;

		// Token: 0x04007EC3 RID: 32451
		public bool isSleeping;

		// Token: 0x04007EC4 RID: 32452
		public int sleepingIndex;

		// Token: 0x04007EC5 RID: 32453
		public int timeSleeping;

		// Token: 0x04007EC6 RID: 32454
		public Vector2 visualOffsetOfBedBase;
	}
}
