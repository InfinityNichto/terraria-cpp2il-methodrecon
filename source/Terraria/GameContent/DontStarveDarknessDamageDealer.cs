using System;
using Terraria.DataStructures;
using Terraria.Localization;

namespace Terraria.GameContent
{
	// Token: 0x020007B7 RID: 1975
	public class DontStarveDarknessDamageDealer
	{
		// Token: 0x0600405A RID: 16474 RVA: 0x00243038 File Offset: 0x00241238
		public static void Reset()
		{
			if (!true)
			{
			}
			DontStarveDarknessDamageDealer.ResetTimer();
		}

		// Token: 0x0600405B RID: 16475 RVA: 0x00243050 File Offset: 0x00241250
		private static void ResetTimer()
		{
			if (!true)
			{
			}
		}

		// Token: 0x0600405C RID: 16476 RVA: 0x00243060 File Offset: 0x00241260
		private static int GetDarknessDamagePerHit()
		{
			return 250;
		}

		// Token: 0x0600405D RID: 16477 RVA: 0x00243074 File Offset: 0x00241274
		private static int GetDarknessTimeBeforeStartingHits()
		{
			return 120;
		}

		// Token: 0x0600405E RID: 16478 RVA: 0x00243084 File Offset: 0x00241284
		private static int GetDarknessTimeForMessage()
		{
			return 60;
		}

		// Token: 0x0600405F RID: 16479 RVA: 0x00243094 File Offset: 0x00241294
		public static void Update(Player player)
		{
			int num = 1;
			bool deadOrGhost = player.DeadOrGhost;
			if (num == 0)
			{
			}
			bool shimmering;
			if (num == 0)
			{
				shimmering = player.shimmering;
				if (!shimmering)
				{
					if (!shimmering)
					{
					}
					DontStarveDarknessDamageDealer.UpdateDarknessState(player);
					int num2 = 120;
					shimmering.m_value = num2 != 0;
					bool immune = player.immune;
					if (!immune)
					{
						if (!immune)
						{
						}
						if (!immune)
						{
						}
						PlayerDeathReason playerDeathReason = PlayerDeathReason.ByOther(17);
					}
					return;
				}
			}
			if (!shimmering)
			{
			}
			DontStarveDarknessDamageDealer.ResetTimer();
		}

		// Token: 0x06004060 RID: 16480 RVA: 0x002430F4 File Offset: 0x002412F4
		private static void UpdateDarknessState(Player player)
		{
			if (!true)
			{
			}
			bool flag = DontStarveDarknessDamageDealer.IsPlayerSafe(player);
			string textValue = Language.GetTextValue("Game.DarknessSafe");
			int num = 50;
			int num2 = 200;
			int num3 = 50;
			Main.NewText(textValue, (byte)num, (byte)num2, (byte)num3);
			DontStarveDarknessDamageDealer.ResetTimer();
		}

		// Token: 0x06004061 RID: 16481 RVA: 0x0024315C File Offset: 0x0024135C
		private static bool IsPlayerSafe(Player player)
		{
			/*
An exception occurred when decompiling this method (06004061)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.DontStarveDarknessDamageDealer::IsPlayerSafe(Terraria.Player)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_2:
	brtrue(IL_0000, ldloc:bool(var_12_67))
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
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06004062 RID: 16482 RVA: 0x002431DC File Offset: 0x002413DC
		public DontStarveDarknessDamageDealer()
		{
		}

		// Token: 0x06004063 RID: 16483 RVA: 0x002431F0 File Offset: 0x002413F0
		// Note: this type is marked as 'beforefieldinit'.
		static DontStarveDarknessDamageDealer()
		{
		}

		// Token: 0x04007E1E RID: 32286
		public const int DARKNESS_HIT_TIMER_MAX_BEFORE_HIT = 60;

		// Token: 0x04007E1F RID: 32287
		public static int darknessTimer;

		// Token: 0x04007E20 RID: 32288
		public static int darknessHitTimer;

		// Token: 0x04007E21 RID: 32289
		public static bool saidMessage;

		// Token: 0x04007E22 RID: 32290
		public static bool lastFrameWasTooBright;
	}
}
