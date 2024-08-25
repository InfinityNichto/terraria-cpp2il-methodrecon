using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Terraria.GameContent
{
	// Token: 0x020007F3 RID: 2035
	public class TeleportPylonsSystem : IOnPlayerJoining
	{
		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06004171 RID: 16753 RVA: 0x00247B30 File Offset: 0x00245D30
		public List<TeleportPylonInfo> Pylons
		{
			get
			{
				return this._pylons;
			}
		}

		// Token: 0x06004172 RID: 16754 RVA: 0x00247B44 File Offset: 0x00245D44
		public void Update()
		{
			if (!true)
			{
			}
			bool netClientOnly = Main.NetClientOnly;
			int cooldownForUpdatingPylonsList = this._cooldownForUpdatingPylonsList;
			this._cooldownForUpdatingPylonsList = cooldownForUpdatingPylonsList;
		}

		// Token: 0x06004173 RID: 16755 RVA: 0x00247B78 File Offset: 0x00245D78
		public bool HasPylonOfType(TeleportPylonType pylonType)
		{
			/*
An exception occurred when decompiling this method (06004173)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.TeleportPylonsSystem::HasPylonOfType(Terraria.GameContent.TeleportPylonType)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.List`1<valuetype Terraria.GameContent.TeleportPylonInfo>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.List`1<valuetype Terraria.GameContent.TeleportPylonInfo>(TeleportPylonsSystem::_pylons, ldloc:TeleportPylonsSystem(this)))
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

		// Token: 0x06004174 RID: 16756 RVA: 0x00247B8C File Offset: 0x00245D8C
		public bool HasAnyPylon()
		{
			/*
An exception occurred when decompiling this method (06004174)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.TeleportPylonsSystem::HasAnyPylon()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_0B, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<valuetype Terraria.GameContent.TeleportPylonInfo>[exp:List`1](TeleportPylonsSystem::_pylons, ldloc:TeleportPylonsSystem(this))))
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

		// Token: 0x06004175 RID: 16757 RVA: 0x00247BA4 File Offset: 0x00245DA4
		public void RequestImmediateUpdate()
		{
			if (!true)
			{
			}
			bool netClientOnly = Main.NetClientOnly;
		}

		// Token: 0x06004176 RID: 16758 RVA: 0x00247BCC File Offset: 0x00245DCC
		private void UpdatePylonsListAndBroadcastChanges()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06004177 RID: 16759 RVA: 0x000021DB File Offset: 0x000003DB
		public void AddForClient(TeleportPylonInfo info)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004178 RID: 16760 RVA: 0x00247C5C File Offset: 0x00245E5C
		public void RemoveForClient(TeleportPylonInfo info)
		{
			List<TeleportPylonInfo> pylons = this._pylons;
		}

		// Token: 0x06004179 RID: 16761 RVA: 0x00247C70 File Offset: 0x00245E70
		public void HandleTeleportRequest(TeleportPylonInfo info, int playerIndex)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int num2 = 1;
			bool flag = NPC.AnyDanger(false, num2 != 0);
		}

		// Token: 0x0600417A RID: 16762 RVA: 0x00247D0C File Offset: 0x00245F0C
		public static bool IsPlayerNearAPylon(Player player)
		{
			if (15744 == 0)
			{
			}
			int tileRangeX = Player.tileRangeX;
			int tileRangeY = Player.tileRangeY;
			int num = 15744;
			int num2 = 32640;
			if (num == 0)
			{
			}
			if (num2 == 0)
			{
				return;
			}
		}

		// Token: 0x0600417B RID: 16763 RVA: 0x00247D54 File Offset: 0x00245F54
		private bool DoesPylonHaveEnoughNPCsAroundIt(TeleportPylonInfo info, int necessaryNPCCount)
		{
			bool flag;
			return flag;
		}

		// Token: 0x0600417C RID: 16764 RVA: 0x00247D64 File Offset: 0x00245F64
		public static bool DoesPositionHaveEnoughNPCs(int necessaryNPCCount, Point16 centerPoint)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num != 0 && num == 0)
			{
				if (num == 0)
				{
				}
				return;
			}
		}

		// Token: 0x0600417D RID: 16765 RVA: 0x00247D90 File Offset: 0x00245F90
		public void RequestTeleportation(TeleportPylonInfo info, Player player)
		{
			if (!true)
			{
			}
		}

		// Token: 0x0600417E RID: 16766 RVA: 0x00247DA0 File Offset: 0x00245FA0
		private bool DoesPylonAcceptTeleportation(TeleportPylonInfo info, Player player)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			bool inUse;
			if (Main.DroneCameraTracker != null)
			{
				if (num == 0)
				{
				}
				inUse = Main.DroneCameraTracker._inUse;
				if (inUse)
				{
				}
			}
			if (!inUse)
			{
			}
			return this._sceneMetrics.EnoughTilesForHallow;
		}

		// Token: 0x0600417F RID: 16767 RVA: 0x000021DB File Offset: 0x000003DB
		private int HowManyNPCsDoesPylonNeed(TeleportPylonInfo info, Player player)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004180 RID: 16768 RVA: 0x00247E00 File Offset: 0x00246000
		public void Reset()
		{
			List<TeleportPylonInfo> pylons = this._pylons;
			int version = pylons._version;
			pylons._syncRoot = version;
		}

		// Token: 0x06004181 RID: 16769 RVA: 0x00247E24 File Offset: 0x00246024
		public void OnPlayerJoining(int playerIndex)
		{
			List<TeleportPylonInfo> pylons = this._pylons;
			if (!true)
			{
			}
		}

		// Token: 0x06004182 RID: 16770 RVA: 0x00247E58 File Offset: 0x00246058
		public static void SpawnInWorldDust(int tileStyle, Rectangle dustBox)
		{
		}

		// Token: 0x06004183 RID: 16771 RVA: 0x00247E70 File Offset: 0x00246070
		public TeleportPylonsSystem()
		{
		}

		// Token: 0x04007F07 RID: 32519
		private List<TeleportPylonInfo> _pylons;

		// Token: 0x04007F08 RID: 32520
		private List<TeleportPylonInfo> _pylonsOld;

		// Token: 0x04007F09 RID: 32521
		private int _cooldownForUpdatingPylonsList;

		// Token: 0x04007F0A RID: 32522
		private const int CooldownTimePerPylonsListUpdate = 2147483647;

		// Token: 0x04007F0B RID: 32523
		private SceneMetrics _sceneMetrics;

		// Token: 0x020007F4 RID: 2036
		[CompilerGenerated]
		private sealed class <>c__DisplayClass8_0
		{
			// Token: 0x06004184 RID: 16772 RVA: 0x00247E88 File Offset: 0x00246088
			public <>c__DisplayClass8_0()
			{
			}

			// Token: 0x06004185 RID: 16773 RVA: 0x00247E9C File Offset: 0x0024609C
			internal bool <HasPylonOfType>b__0(TeleportPylonInfo x)
			{
				/*
An exception occurred when decompiling this method (06004185)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.TeleportPylonsSystem/<>c__DisplayClass8_0::<HasPylonOfType>b__0(Terraria.GameContent.TeleportPylonInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:TeleportPylonType(var_0_06, ldfld:TeleportPylonType('<>c__DisplayClass8_0'::pylonType, ldloc:'<>c__DisplayClass8_0'(this)))
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

			// Token: 0x04007F0C RID: 32524
			public TeleportPylonType pylonType;
		}

		// Token: 0x020007F5 RID: 2037
		[CompilerGenerated]
		private sealed class <>c__DisplayClass13_0
		{
			// Token: 0x06004186 RID: 16774 RVA: 0x00247EB0 File Offset: 0x002460B0
			public <>c__DisplayClass13_0()
			{
			}

			// Token: 0x06004187 RID: 16775 RVA: 0x00247EC4 File Offset: 0x002460C4
			internal bool <RemoveForClient>b__0(TeleportPylonInfo x)
			{
				TeleportPylonType typeOfPylon = this.info.TypeOfPylon;
				TeleportPylonInfo teleportPylonInfo = this.info;
				bool flag;
				return flag;
			}

			// Token: 0x04007F0D RID: 32525
			public TeleportPylonInfo info;
		}
	}
}
