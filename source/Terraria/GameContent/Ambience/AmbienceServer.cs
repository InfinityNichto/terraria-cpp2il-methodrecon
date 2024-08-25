using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Terraria.GameContent.NetModules;
using Terraria.Net;

namespace Terraria.GameContent.Ambience
{
	// Token: 0x02000AFB RID: 2811
	public class AmbienceServer
	{
		// Token: 0x0600523E RID: 21054 RVA: 0x002828F4 File Offset: 0x00280AF4
		private static bool IsSunnyDay()
		{
			if (!true)
			{
			}
			bool isItRaining = Main.IsItRaining;
			if (!true)
			{
				return;
			}
		}

		// Token: 0x0600523F RID: 21055 RVA: 0x00282910 File Offset: 0x00280B10
		private static bool IsSunset()
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06005240 RID: 21056 RVA: 0x00282924 File Offset: 0x00280B24
		private static bool IsCalmNight()
		{
			if (!true)
			{
			}
			bool isItRaining = Main.IsItRaining;
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06005241 RID: 21057 RVA: 0x00282940 File Offset: 0x00280B40
		public AmbienceServer()
		{
			this.ResetSpawnTime();
			Dictionary<SkyEntityType, Func<bool>> spawnConditions = this._spawnConditions;
			Dictionary<SkyEntityType, Func<bool>> spawnConditions2 = this._spawnConditions;
			Dictionary<SkyEntityType, Func<bool>> spawnConditions3 = this._spawnConditions;
			Dictionary<SkyEntityType, Func<bool>> spawnConditions4 = this._spawnConditions;
			Dictionary<SkyEntityType, Func<bool>> spawnConditions5 = this._spawnConditions;
			Dictionary<SkyEntityType, Func<bool>> spawnConditions6 = this._spawnConditions;
			Dictionary<SkyEntityType, Func<bool>> spawnConditions7 = this._spawnConditions;
			Dictionary<SkyEntityType, Func<bool>> spawnConditions8 = this._spawnConditions;
			Dictionary<SkyEntityType, Func<bool>> spawnConditions9 = this._spawnConditions;
			Dictionary<SkyEntityType, Func<bool>> spawnConditions10 = this._spawnConditions;
			Dictionary<SkyEntityType, Func<bool>> spawnConditions11 = this._spawnConditions;
			Dictionary<SkyEntityType, Func<bool>> spawnConditions12 = this._spawnConditions;
			Dictionary<SkyEntityType, Func<bool>> spawnConditions13 = this._spawnConditions;
			Dictionary<SkyEntityType, Func<bool>> spawnConditions14 = this._spawnConditions;
			Dictionary<SkyEntityType, Func<bool>> spawnConditions15 = this._spawnConditions;
			Dictionary<SkyEntityType, Func<bool>> spawnConditions16 = this._spawnConditions;
			Dictionary<SkyEntityType, Func<bool>> spawnConditions17 = this._spawnConditions;
			Dictionary<SkyEntityType, Func<Player, bool>> secondarySpawnConditionsPerPlayer = this._secondarySpawnConditionsPerPlayer;
			Dictionary<SkyEntityType, Func<Player, bool>> secondarySpawnConditionsPerPlayer2 = this._secondarySpawnConditionsPerPlayer;
			Dictionary<SkyEntityType, Func<Player, bool>> secondarySpawnConditionsPerPlayer3 = this._secondarySpawnConditionsPerPlayer;
			Dictionary<SkyEntityType, Func<Player, bool>> secondarySpawnConditionsPerPlayer4 = this._secondarySpawnConditionsPerPlayer;
			Dictionary<SkyEntityType, Func<Player, bool>> secondarySpawnConditionsPerPlayer5 = this._secondarySpawnConditionsPerPlayer;
			Dictionary<SkyEntityType, Func<Player, bool>> secondarySpawnConditionsPerPlayer6 = this._secondarySpawnConditionsPerPlayer;
			Dictionary<SkyEntityType, Func<Player, bool>> secondarySpawnConditionsPerPlayer7 = this._secondarySpawnConditionsPerPlayer;
			Dictionary<SkyEntityType, Func<Player, bool>> secondarySpawnConditionsPerPlayer8 = this._secondarySpawnConditionsPerPlayer;
			if (secondarySpawnConditionsPerPlayer7 == null)
			{
			}
		}

		// Token: 0x06005242 RID: 21058 RVA: 0x00282A24 File Offset: 0x00280C24
		private bool IsPlayerAtRightHeightForType(SkyEntityType type, Player plr)
		{
			return AmbienceServer.IsPlayerInAPlaceWhereTheyCanSeeAmbienceHell(plr);
		}

		// Token: 0x06005243 RID: 21059 RVA: 0x00282A3C File Offset: 0x00280C3C
		public void Update()
		{
			int num = 1;
			this.SpawnForcedEntities();
			int updatesUntilNextAttempt = this._updatesUntilNextAttempt;
			if (num == 0)
			{
			}
			this._updatesUntilNextAttempt = num;
		}

		// Token: 0x06005244 RID: 21060 RVA: 0x00282A94 File Offset: 0x00280C94
		public void ResetSpawnTime()
		{
			if (!true)
			{
			}
			int num;
			this._updatesUntilNextAttempt = num;
		}

		// Token: 0x06005245 RID: 21061 RVA: 0x000021DB File Offset: 0x000003DB
		public void ForceEntitySpawn(AmbienceServer.AmbienceSpawnInfo info)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06005246 RID: 21062 RVA: 0x00282AAC File Offset: 0x00280CAC
		private void SpawnForcedEntities()
		{
			int size = this._forcedSpawns._size;
			if (size != 0)
			{
				return;
			}
		}

		// Token: 0x06005247 RID: 21063 RVA: 0x00282AE0 File Offset: 0x00280CE0
		private static void FindPlayerThatCanSeeBackgroundAmbience([Out] Player player)
		{
			if (43139072 != 0)
			{
			}
		}

		// Token: 0x06005248 RID: 21064 RVA: 0x00282AF4 File Offset: 0x00280CF4
		private static bool IsPlayerInAPlaceWhereTheyCanSeeAmbience(Player plr)
		{
			return true;
		}

		// Token: 0x06005249 RID: 21065 RVA: 0x00282B04 File Offset: 0x00280D04
		private static bool IsPlayerInAPlaceWhereTheyCanSeeAmbienceSky(Player plr)
		{
			/*
An exception occurred when decompiling this method (06005249)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Ambience.AmbienceServer::IsPlayerInAPlaceWhereTheyCanSeeAmbienceSky(Terraria.Player)

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

		// Token: 0x0600524A RID: 21066 RVA: 0x00282B14 File Offset: 0x00280D14
		private static bool IsPlayerInAPlaceWhereTheyCanSeeAmbienceHell(Player plr)
		{
			/*
An exception occurred when decompiling this method (0600524A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Ambience.AmbienceServer::IsPlayerInAPlaceWhereTheyCanSeeAmbienceHell(Terraria.Player)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_1_0A, callgetter:int32(Main::get_UnderworldLayer))
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

		// Token: 0x0600524B RID: 21067 RVA: 0x00282B2C File Offset: 0x00280D2C
		private void SpawnForPlayer(Player player, SkyEntityType type)
		{
			if (!true)
			{
			}
			NetPacket netPacket = NetAmbienceModule.SerializeSkyEntitySpawn(player, type);
		}

		// Token: 0x04008A83 RID: 35459
		private const int MINIMUM_SECONDS_BETWEEN_SPAWNS = 10;

		// Token: 0x04008A84 RID: 35460
		private const int MAXIMUM_SECONDS_BETWEEN_SPAWNS = 120;

		// Token: 0x04008A85 RID: 35461
		private readonly Dictionary<SkyEntityType, Func<bool>> _spawnConditions;

		// Token: 0x04008A86 RID: 35462
		private readonly Dictionary<SkyEntityType, Func<Player, bool>> _secondarySpawnConditionsPerPlayer;

		// Token: 0x04008A87 RID: 35463
		private int _updatesUntilNextAttempt;

		// Token: 0x04008A88 RID: 35464
		private List<AmbienceServer.AmbienceSpawnInfo> _forcedSpawns;

		// Token: 0x02000AFC RID: 2812
		public struct AmbienceSpawnInfo
		{
			// Token: 0x04008A89 RID: 35465
			public SkyEntityType skyEntityType;

			// Token: 0x04008A8A RID: 35466
			public int targetPlayer;
		}

		// Token: 0x02000AFD RID: 2813
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600524C RID: 21068 RVA: 0x00282B44 File Offset: 0x00280D44
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600524D RID: 21069 RVA: 0x00282B54 File Offset: 0x00280D54
			public <>c()
			{
			}

			// Token: 0x0600524E RID: 21070 RVA: 0x00282B68 File Offset: 0x00280D68
			internal bool <.ctor>b__10_0()
			{
				bool flag = AmbienceServer.IsSunnyDay();
				if (!true)
				{
					return;
				}
			}

			// Token: 0x0600524F RID: 21071 RVA: 0x00282B80 File Offset: 0x00280D80
			internal bool <.ctor>b__10_1()
			{
				bool flag = AmbienceServer.IsSunnyDay();
				if (!true)
				{
				}
				if (!true)
				{
					return;
				}
			}

			// Token: 0x06005250 RID: 21072 RVA: 0x00282B9C File Offset: 0x00280D9C
			internal bool <.ctor>b__10_2()
			{
				bool flag = AmbienceServer.IsSunnyDay();
				if (!true)
				{
				}
				if (!true)
				{
					return;
				}
			}

			// Token: 0x06005251 RID: 21073 RVA: 0x00282BB8 File Offset: 0x00280DB8
			internal bool <.ctor>b__10_3()
			{
				/*
An exception occurred when decompiling this method (06005251)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Ambience.AmbienceServer/<>c::<.ctor>b__10_3()

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

			// Token: 0x06005252 RID: 21074 RVA: 0x00282BC8 File Offset: 0x00280DC8
			internal bool <.ctor>b__10_4()
			{
				/*
An exception occurred when decompiling this method (06005252)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Ambience.AmbienceServer/<>c::<.ctor>b__10_4()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001A:
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

			// Token: 0x06005253 RID: 21075 RVA: 0x00282BF4 File Offset: 0x00280DF4
			internal bool <.ctor>b__10_5()
			{
				/*
An exception occurred when decompiling this method (06005253)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Ambience.AmbienceServer/<>c::<.ctor>b__10_5()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000B:
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

			// Token: 0x06005254 RID: 21076 RVA: 0x00282C10 File Offset: 0x00280E10
			internal bool <.ctor>b__10_6()
			{
				return AmbienceServer.IsSunnyDay();
			}

			// Token: 0x06005255 RID: 21077 RVA: 0x00282C24 File Offset: 0x00280E24
			internal bool <.ctor>b__10_7()
			{
				bool flag = AmbienceServer.IsSunset();
				bool flag2 = AmbienceServer.IsSunnyDay();
				return true;
			}

			// Token: 0x06005256 RID: 21078 RVA: 0x00282C44 File Offset: 0x00280E44
			internal bool <.ctor>b__10_8()
			{
				bool flag = AmbienceServer.IsSunnyDay();
				return true;
			}

			// Token: 0x06005257 RID: 21079 RVA: 0x00282C60 File Offset: 0x00280E60
			internal bool <.ctor>b__10_9()
			{
				return AmbienceServer.IsSunnyDay();
			}

			// Token: 0x06005258 RID: 21080 RVA: 0x00282C74 File Offset: 0x00280E74
			internal bool <.ctor>b__10_10()
			{
				bool flag = AmbienceServer.IsSunnyDay();
				if (!true)
				{
				}
				if (!true)
				{
					return;
				}
			}

			// Token: 0x06005259 RID: 21081 RVA: 0x00282C90 File Offset: 0x00280E90
			internal bool <.ctor>b__10_11()
			{
				return AmbienceServer.IsCalmNight();
			}

			// Token: 0x0600525A RID: 21082 RVA: 0x00282CA4 File Offset: 0x00280EA4
			internal bool <.ctor>b__10_12()
			{
				return AmbienceServer.IsSunnyDay();
			}

			// Token: 0x0600525B RID: 21083 RVA: 0x00282CB8 File Offset: 0x00280EB8
			internal bool <.ctor>b__10_13()
			{
				bool flag = AmbienceServer.IsSunnyDay();
				return true;
			}

			// Token: 0x0600525C RID: 21084 RVA: 0x00282CD4 File Offset: 0x00280ED4
			internal bool <.ctor>b__10_14()
			{
				bool flag = AmbienceServer.IsSunnyDay();
				return true;
			}

			// Token: 0x0600525D RID: 21085 RVA: 0x00282CF0 File Offset: 0x00280EF0
			internal bool <.ctor>b__10_15()
			{
				return true;
			}

			// Token: 0x0600525E RID: 21086 RVA: 0x00282D00 File Offset: 0x00280F00
			internal bool <.ctor>b__10_16(Player player)
			{
				return player.ZoneDesert;
			}

			// Token: 0x0600525F RID: 21087 RVA: 0x00282D14 File Offset: 0x00280F14
			internal bool <.ctor>b__10_17(Player player)
			{
				return player.ZoneHallow;
			}

			// Token: 0x06005260 RID: 21088 RVA: 0x00282D28 File Offset: 0x00280F28
			internal bool <.ctor>b__10_18(Player player)
			{
				return player.ZoneBeach;
			}

			// Token: 0x06005261 RID: 21089 RVA: 0x00282D3C File Offset: 0x00280F3C
			internal bool <.ctor>b__10_19(Player player)
			{
				return player.ZoneHallow;
			}

			// Token: 0x06005262 RID: 21090 RVA: 0x00282D50 File Offset: 0x00280F50
			internal bool <.ctor>b__10_20(Player player)
			{
				return player.ZoneHallow;
			}

			// Token: 0x06005263 RID: 21091 RVA: 0x00282D64 File Offset: 0x00280F64
			internal bool <.ctor>b__10_21(Player player)
			{
				return player.ZoneCorrupt;
			}

			// Token: 0x06005264 RID: 21092 RVA: 0x00282D78 File Offset: 0x00280F78
			internal bool <.ctor>b__10_22(Player player)
			{
				return player.ZoneCrimson;
			}

			// Token: 0x06005265 RID: 21093 RVA: 0x00282D8C File Offset: 0x00280F8C
			internal bool <.ctor>b__10_23(Player player)
			{
				return player.ZoneJungle;
			}

			// Token: 0x06005266 RID: 21094 RVA: 0x000021DB File Offset: 0x000003DB
			internal bool <Update>b__12_0(KeyValuePair<SkyEntityType, Func<bool>> pair)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06005267 RID: 21095 RVA: 0x000021DB File Offset: 0x000003DB
			internal SkyEntityType <Update>b__12_1(KeyValuePair<SkyEntityType, Func<bool>> pair)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06005268 RID: 21096 RVA: 0x00282DA0 File Offset: 0x00280FA0
			internal bool <Update>b__12_2(SkyEntityType type)
			{
				return true;
			}

			// Token: 0x06005269 RID: 21097 RVA: 0x00282DB0 File Offset: 0x00280FB0
			internal bool <Update>b__12_4(SkyEntityType type)
			{
				return true;
			}

			// Token: 0x0600526A RID: 21098 RVA: 0x00282DC0 File Offset: 0x00280FC0
			internal bool <Update>b__12_6(SkyEntityType type)
			{
				return true;
			}

			// Token: 0x0600526B RID: 21099 RVA: 0x00282DD0 File Offset: 0x00280FD0
			internal bool <FindPlayerThatCanSeeBackgroundAmbience>b__16_0(Player plr)
			{
				if (plr != null && plr.active)
				{
					bool flag = AmbienceServer.IsPlayerInAPlaceWhereTheyCanSeeAmbienceSky(plr);
					return true;
				}
				return AmbienceServer.IsPlayerInAPlaceWhereTheyCanSeeAmbienceHell(plr);
			}

			// Token: 0x0600526C RID: 21100 RVA: 0x00282DFC File Offset: 0x00280FFC
			internal bool <FindPlayerThatCanSeeBackgroundAmbience>b__16_1(Player plr)
			{
				if (plr != null && plr.active)
				{
					bool flag = AmbienceServer.IsPlayerInAPlaceWhereTheyCanSeeAmbienceSky(plr);
					return true;
				}
				return AmbienceServer.IsPlayerInAPlaceWhereTheyCanSeeAmbienceHell(plr);
			}

			// Token: 0x04008A8B RID: 35467
			public static readonly AmbienceServer.<>c <>9;

			// Token: 0x04008A8C RID: 35468
			public static Func<bool> <>9__10_0;

			// Token: 0x04008A8D RID: 35469
			public static Func<bool> <>9__10_1;

			// Token: 0x04008A8E RID: 35470
			public static Func<bool> <>9__10_2;

			// Token: 0x04008A8F RID: 35471
			public static Func<bool> <>9__10_3;

			// Token: 0x04008A90 RID: 35472
			public static Func<bool> <>9__10_4;

			// Token: 0x04008A91 RID: 35473
			public static Func<bool> <>9__10_5;

			// Token: 0x04008A92 RID: 35474
			public static Func<bool> <>9__10_6;

			// Token: 0x04008A93 RID: 35475
			public static Func<bool> <>9__10_7;

			// Token: 0x04008A94 RID: 35476
			public static Func<bool> <>9__10_8;

			// Token: 0x04008A95 RID: 35477
			public static Func<bool> <>9__10_9;

			// Token: 0x04008A96 RID: 35478
			public static Func<bool> <>9__10_10;

			// Token: 0x04008A97 RID: 35479
			public static Func<bool> <>9__10_11;

			// Token: 0x04008A98 RID: 35480
			public static Func<bool> <>9__10_12;

			// Token: 0x04008A99 RID: 35481
			public static Func<bool> <>9__10_13;

			// Token: 0x04008A9A RID: 35482
			public static Func<bool> <>9__10_14;

			// Token: 0x04008A9B RID: 35483
			public static Func<bool> <>9__10_15;

			// Token: 0x04008A9C RID: 35484
			public static Func<Player, bool> <>9__10_16;

			// Token: 0x04008A9D RID: 35485
			public static Func<Player, bool> <>9__10_17;

			// Token: 0x04008A9E RID: 35486
			public static Func<Player, bool> <>9__10_18;

			// Token: 0x04008A9F RID: 35487
			public static Func<Player, bool> <>9__10_19;

			// Token: 0x04008AA0 RID: 35488
			public static Func<Player, bool> <>9__10_20;

			// Token: 0x04008AA1 RID: 35489
			public static Func<Player, bool> <>9__10_21;

			// Token: 0x04008AA2 RID: 35490
			public static Func<Player, bool> <>9__10_22;

			// Token: 0x04008AA3 RID: 35491
			public static Func<Player, bool> <>9__10_23;

			// Token: 0x04008AA4 RID: 35492
			public static Func<KeyValuePair<SkyEntityType, Func<bool>>, bool> <>9__12_0;

			// Token: 0x04008AA5 RID: 35493
			public static Func<KeyValuePair<SkyEntityType, Func<bool>>, SkyEntityType> <>9__12_1;

			// Token: 0x04008AA6 RID: 35494
			public static Func<SkyEntityType, bool> <>9__12_2;

			// Token: 0x04008AA7 RID: 35495
			public static Func<SkyEntityType, bool> <>9__12_4;

			// Token: 0x04008AA8 RID: 35496
			public static Func<SkyEntityType, bool> <>9__12_6;

			// Token: 0x04008AA9 RID: 35497
			public static Func<Player, bool> <>9__16_0;

			// Token: 0x04008AAA RID: 35498
			public static Func<Player, bool> <>9__16_1;
		}

		// Token: 0x02000AFE RID: 2814
		[CompilerGenerated]
		private sealed class <>c__DisplayClass12_0
		{
			// Token: 0x0600526D RID: 21101 RVA: 0x00282E28 File Offset: 0x00281028
			public <>c__DisplayClass12_0()
			{
			}

			// Token: 0x0600526E RID: 21102 RVA: 0x00282E3C File Offset: 0x0028103C
			internal bool <Update>b__3(SkyEntityType type)
			{
				return AmbienceServer.IsPlayerInAPlaceWhereTheyCanSeeAmbienceHell(this.player);
			}

			// Token: 0x0600526F RID: 21103 RVA: 0x00282E90 File Offset: 0x00281090
			internal bool <Update>b__5(SkyEntityType type)
			{
				bool flag = AmbienceServer.IsPlayerInAPlaceWhereTheyCanSeeAmbienceHell(this.player);
				Dictionary<SkyEntityType, Func<Player, bool>> secondarySpawnConditionsPerPlayer = this.<>4__this._secondarySpawnConditionsPerPlayer;
				Dictionary<SkyEntityType, Func<Player, bool>> secondarySpawnConditionsPerPlayer2 = this.<>4__this._secondarySpawnConditionsPerPlayer;
				Dictionary.ValueCollection values = secondarySpawnConditionsPerPlayer2._values;
				Player player = this.player;
				Dictionary.Entry[] entries = secondarySpawnConditionsPerPlayer2._entries;
				int freeCount = secondarySpawnConditionsPerPlayer2._freeCount;
				return true;
			}

			// Token: 0x04008AAB RID: 35499
			public AmbienceServer <>4__this;

			// Token: 0x04008AAC RID: 35500
			public Player player;
		}
	}
}
