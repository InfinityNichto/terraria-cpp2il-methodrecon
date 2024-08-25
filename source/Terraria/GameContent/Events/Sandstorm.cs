using System;

namespace Terraria.GameContent.Events
{
	// Token: 0x02000A56 RID: 2646
	public class Sandstorm
	{
		// Token: 0x06004E28 RID: 20008 RVA: 0x00275D94 File Offset: 0x00273F94
		private static bool HasSufficientWind()
		{
			/*
An exception occurred when decompiling this method (06004E28)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Events.Sandstorm::HasSufficientWind()

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

		// Token: 0x06004E29 RID: 20009 RVA: 0x00275DA4 File Offset: 0x00273FA4
		public static void WorldClear()
		{
		}

		// Token: 0x06004E2A RID: 20010 RVA: 0x00275DB4 File Offset: 0x00273FB4
		public static void UpdateTime()
		{
			bool logicHost = Main.LogicHost;
			if (20865 == 0)
			{
			}
			bool flag = Sandstorm.HasSufficientWind();
		}

		// Token: 0x06004E2B RID: 20011 RVA: 0x00275E2C File Offset: 0x0027402C
		private static void ChangeSeverityIntentions()
		{
		}

		// Token: 0x06004E2C RID: 20012 RVA: 0x00275E48 File Offset: 0x00274048
		private static void UpdateSeverity()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x06004E2D RID: 20013 RVA: 0x00275E6C File Offset: 0x0027406C
		private static void StartSandstorm()
		{
			Sandstorm.ChangeSeverityIntentions();
		}

		// Token: 0x06004E2E RID: 20014 RVA: 0x00275E80 File Offset: 0x00274080
		private static void StopSandstorm()
		{
			Sandstorm.ChangeSeverityIntentions();
		}

		// Token: 0x06004E2F RID: 20015 RVA: 0x00275E94 File Offset: 0x00274094
		public static void HandleEffectAndSky(bool toState)
		{
		}

		// Token: 0x06004E30 RID: 20016 RVA: 0x00275EAC File Offset: 0x002740AC
		public static bool ShouldSandstormDustPersist()
		{
			/*
An exception occurred when decompiling this method (06004E30)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Events.Sandstorm::ShouldSandstormDustPersist()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_1_07, callgetter:int32(Main::get_myPlayer))
	stloc:int32(var_4_0F, callgetter:int32(Main::get_bgStyle))
	stloc:int32(var_6_19, callgetter:int32(Main::get_bgStyle))
	stloc:int32(var_8_23, callgetter:int32(Main::get_bgDelay))
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

		// Token: 0x06004E31 RID: 20017 RVA: 0x00275EE0 File Offset: 0x002740E0
		public static void EmitDust()
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
				int <SandTileCount>k__BackingField = Main.SceneMetrics.<SandTileCount>k__BackingField;
				int myPlayer = Main.myPlayer;
				bool flag = Sandstorm.ShouldSandstormDustPersist();
				bool useStormEffects = Main.UseStormEffects;
				return;
			}
		}

		// Token: 0x06004E32 RID: 20018 RVA: 0x002761F4 File Offset: 0x002743F4
		public Sandstorm()
		{
		}

		// Token: 0x040086DA RID: 34522
		private const int SANDSTORM_DURATION_MINIMUM = 28800;

		// Token: 0x040086DB RID: 34523
		private const int SANDSTORM_DURATION_MAXIMUM = 86400;

		// Token: 0x040086DC RID: 34524
		public static bool Happening;

		// Token: 0x040086DD RID: 34525
		public static int TimeLeft;

		// Token: 0x040086DE RID: 34526
		public static float Severity;

		// Token: 0x040086DF RID: 34527
		public static float IntendedSeverity;

		// Token: 0x040086E0 RID: 34528
		private static bool _effectsUp;
	}
}
