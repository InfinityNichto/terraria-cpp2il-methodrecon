using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.Utilities
{
	// Token: 0x020004FD RID: 1277
	public static class NPCUtils
	{
		// Token: 0x060030F1 RID: 12529 RVA: 0x001F7494 File Offset: 0x001F5694
		public static NPCUtils.TargetSearchResults SearchForTarget(Vector2 position, NPCUtils.TargetSearchFlag flags = NPCUtils.TargetSearchFlag.All, float maxPlayerDistance = -1f, int npcFilter = 0)
		{
			NPCUtils.TargetSearchResults targetSearchResults;
			return targetSearchResults;
		}

		// Token: 0x060030F2 RID: 12530 RVA: 0x001F74A4 File Offset: 0x001F56A4
		public static NPCUtils.TargetSearchResults SearchForTarget(NPC searcher, NPCUtils.TargetSearchFlag flags = NPCUtils.TargetSearchFlag.All, float maxPlayerDistance = -1f, int npcFilter = 0)
		{
			Vector2 center = searcher.Center;
			NPCUtils.TargetSearchResults targetSearchResults;
			return targetSearchResults;
		}

		// Token: 0x060030F3 RID: 12531 RVA: 0x001F74BC File Offset: 0x001F56BC
		public static NPCUtils.TargetSearchResults SearchForTarget(NPC searcher, Vector2 position, NPCUtils.TargetSearchFlag flags = NPCUtils.TargetSearchFlag.All, float maxPlayerDistance = -1f, int npcFilter = 0)
		{
			/*
An exception occurred when decompiling this method (060030F3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Utilities.NPCUtils/TargetSearchResults Terraria.Utilities.NPCUtils::SearchForTarget(Terraria.NPC,Microsoft.Xna.Framework.Vector2,Terraria.Utilities.NPCUtils/TargetSearchFlag,System.Single,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0054:
	stfld:int32(TargetSearchResults::_nearestTankIndex, ldloc:TargetSearchResults[exp:valuetype Terraria.Utilities.NPCUtils/TargetSearchResults&](var_0), ldloc:float32[exp:int32](var_13))
	stfld:TargetType(TargetSearchResults::_nearestTankType, ldloc:TargetSearchResults[exp:valuetype Terraria.Utilities.NPCUtils/TargetSearchResults&](var_0), ldloc:int32[exp:TargetType](var_20_41))
	stloc:int32(var_26_65, ldc.i4:int32(1))
	stfld:TargetType(TargetSearchResults::_nearestTargetType, ldloc:TargetSearchResults[exp:valuetype Terraria.Utilities.NPCUtils/TargetSearchResults&](var_0), ldloc:int32[exp:TargetType](var_26_65))
	stfld:TargetType(TargetSearchResults::_nearestTargetType, ldloc:TargetSearchResults[exp:valuetype Terraria.Utilities.NPCUtils/TargetSearchResults&](var_0), ldloc:int32[exp:TargetType](var_20_41))
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

		// Token: 0x060030F4 RID: 12532 RVA: 0x001F7540 File Offset: 0x001F5740
		public static void TargetClosestOldOnesInvasion(NPC searcher, bool faceTarget = true, [Optional] Vector2? checkPosition)
		{
			NPCUtils.TargetSearchResults targetSearchResults;
			int nearestTargetIndex = targetSearchResults.NearestTargetIndex;
			searcher.target = nearestTargetIndex;
			Rectangle rectangle;
			searcher.targetRect = rectangle;
			searcher.targetRect.Width = 3;
			searcher.FaceTarget();
		}

		// Token: 0x060030F5 RID: 12533 RVA: 0x001F7574 File Offset: 0x001F5774
		public static void TargetClosestNonBees(NPC searcher, bool faceTarget = true, [Optional] Vector2? checkPosition)
		{
			NPCUtils.TargetSearchResults targetSearchResults;
			int nearestTargetIndex = targetSearchResults.NearestTargetIndex;
			searcher.target = nearestTargetIndex;
			Rectangle rectangle;
			searcher.targetRect = rectangle;
			searcher.targetRect.Width = 3;
			searcher.FaceTarget();
		}

		// Token: 0x060030F6 RID: 12534 RVA: 0x001F75A8 File Offset: 0x001F57A8
		public static void TargetClosestDownwindFromNPC(NPC searcher, float distanceMaxX, bool faceTarget = true, [Optional] Vector2? checkPosition)
		{
			int nearestTargetIndex = NPCUtils.SearchForTarget(searcher, NPCUtils.TargetSearchFlag.Players, distanceMaxX, 3).NearestTargetIndex;
			searcher.target = nearestTargetIndex;
			Rectangle rectangle;
			searcher.targetRect = rectangle;
			searcher.targetRect.Width = 2;
			searcher.FaceTarget();
		}

		// Token: 0x060030F7 RID: 12535 RVA: 0x001F75E4 File Offset: 0x001F57E4
		public static void TargetClosestCommon(NPC searcher, bool faceTarget = true, [Optional] Vector2? checkPosition)
		{
			searcher.TargetClosest(faceTarget);
		}

		// Token: 0x060030F8 RID: 12536 RVA: 0x001F75F8 File Offset: 0x001F57F8
		public static void TargetClosestBetsy(NPC searcher, bool faceTarget = true, [Optional] Vector2? checkPosition)
		{
			NPCUtils.TargetSearchResults targetSearchResults;
			bool dead = targetSearchResults.NearestTankOwner.dead;
			int num;
			searcher.target = num;
			Rectangle rectangle;
			searcher.targetRect = rectangle;
			searcher.targetRect.Width = 3;
			searcher.FaceTarget();
		}

		// Token: 0x04003AD7 RID: 15063
		public const int NPCSearchFilter_OnlyCrystal = 1;

		// Token: 0x04003AD8 RID: 15064
		public const int NPCSearchFilter_NonBeeNPCs = 2;

		// Token: 0x04003AD9 RID: 15065
		public const int NPCSearchFilter_DownWind = 3;

		// Token: 0x020004FE RID: 1278
		public sealed class SearchFilter<T> : MulticastDelegate where T : Entity
		{
			// Token: 0x060030F9 RID: 12537 RVA: 0x001F7634 File Offset: 0x001F5834
			public SearchFilter(object @object, IntPtr method)
			{
			}

			// Token: 0x060030FA RID: 12538 RVA: 0x000021DB File Offset: 0x000003DB
			public bool Invoke(T entity)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x060030FB RID: 12539 RVA: 0x000021DB File Offset: 0x000003DB
			public IAsyncResult BeginInvoke(T entity, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x060030FC RID: 12540 RVA: 0x000021DB File Offset: 0x000003DB
			public bool EndInvoke(IAsyncResult result)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x020004FF RID: 1279
		public sealed class NPCTargetingMethod : MulticastDelegate
		{
			// Token: 0x060030FD RID: 12541 RVA: 0x001F7654 File Offset: 0x001F5854
			public NPCTargetingMethod(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x060030FE RID: 12542 RVA: 0x001F76B4 File Offset: 0x001F58B4
			public void Invoke(NPC searcher, bool faceTarget, Vector2? checkPosition)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}

			// Token: 0x060030FF RID: 12543 RVA: 0x000021DB File Offset: 0x000003DB
			public IAsyncResult BeginInvoke(NPC searcher, bool faceTarget, Vector2? checkPosition, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06003100 RID: 12544 RVA: 0x001F76D8 File Offset: 0x001F58D8
			public void EndInvoke(IAsyncResult result)
			{
			}
		}

		// Token: 0x02000500 RID: 1280
		public static class SearchFilters
		{
			// Token: 0x06003101 RID: 12545 RVA: 0x001F76E8 File Offset: 0x001F58E8
			public static bool OnlyCrystal(NPC npc)
			{
			}

			// Token: 0x06003102 RID: 12546 RVA: 0x000021DB File Offset: 0x000003DB
			public static NPCUtils.SearchFilter<Player> OnlyPlayersInCertainDistance(Vector2 position, float maxDistance)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06003103 RID: 12547 RVA: 0x001F76F8 File Offset: 0x001F58F8
			public static bool NonBeeNPCs(NPC npc)
			{
				bool flag;
				return flag;
			}

			// Token: 0x06003104 RID: 12548 RVA: 0x000021DB File Offset: 0x000003DB
			public static NPCUtils.SearchFilter<Player> DownwindFromNPC(NPC npc, float maxDistanceX)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x02000501 RID: 1281
			[CompilerGenerated]
			private sealed class <>c__DisplayClass1_0
			{
				// Token: 0x06003105 RID: 12549 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public <>c__DisplayClass1_0()
				{
				}

				// Token: 0x06003106 RID: 12550 RVA: 0x001F770C File Offset: 0x001F590C
				internal bool <OnlyPlayersInCertainDistance>b__0(Player player)
				{
					return default(bool);
				}

				// Token: 0x04003ADA RID: 15066
				public Vector2 position;

				// Token: 0x04003ADB RID: 15067
				public float maxDistance;
			}

			// Token: 0x02000502 RID: 1282
			[CompilerGenerated]
			private sealed class <>c__DisplayClass3_0
			{
				// Token: 0x06003107 RID: 12551 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public <>c__DisplayClass3_0()
				{
				}

				// Token: 0x06003108 RID: 12552 RVA: 0x001F7724 File Offset: 0x001F5924
				internal bool <DownwindFromNPC>b__0(Player player)
				{
					return default(bool);
				}

				// Token: 0x04003ADC RID: 15068
				public NPC npc;

				// Token: 0x04003ADD RID: 15069
				public float maxDistanceX;
			}
		}

		// Token: 0x02000503 RID: 1283
		public enum TargetType
		{
			// Token: 0x04003ADF RID: 15071
			None,
			// Token: 0x04003AE0 RID: 15072
			NPC,
			// Token: 0x04003AE1 RID: 15073
			Player,
			// Token: 0x04003AE2 RID: 15074
			TankPet
		}

		// Token: 0x02000504 RID: 1284
		public struct TargetSearchResults
		{
			// Token: 0x17000616 RID: 1558
			// (get) Token: 0x06003109 RID: 12553 RVA: 0x001F773C File Offset: 0x001F593C
			public int NearestTargetIndex
			{
				get
				{
					return this.NearestNPC.WhoAmIToTargettingIndex;
				}
			}

			// Token: 0x17000617 RID: 1559
			// (get) Token: 0x0600310A RID: 12554 RVA: 0x001F775C File Offset: 0x001F595C
			public Rectangle NearestTargetHitbox
			{
				get
				{
					Player nearestTankOwner = this.NearestTankOwner;
					NPC nearestNPC = this.NearestNPC;
					return this.NearestTankOwner.Hitbox;
				}
			}

			// Token: 0x17000618 RID: 1560
			// (get) Token: 0x0600310B RID: 12555 RVA: 0x000021DB File Offset: 0x000003DB
			public NPCUtils.TargetType NearestTargetType
			{
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x17000619 RID: 1561
			// (get) Token: 0x0600310C RID: 12556 RVA: 0x000021DB File Offset: 0x000003DB
			public bool FoundTarget
			{
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x1700061A RID: 1562
			// (get) Token: 0x0600310D RID: 12557 RVA: 0x001F7790 File Offset: 0x001F5990
			public NPC NearestNPC
			{
				get
				{
					/*
An exception occurred when decompiling this method (0600310D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.NPC Terraria.Utilities.NPCUtils/TargetSearchResults::get_NearestNPC()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(TargetSearchResults::_nearestNPCIndex, ldloc:valuetype Terraria.Utilities.NPCUtils/TargetSearchResults&(this)))
	stloc:int32(var_1_0D, ldfld:int32(TargetSearchResults::_nearestNPCIndex, ldloc:valuetype Terraria.Utilities.NPCUtils/TargetSearchResults&(this)))
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

			// Token: 0x1700061B RID: 1563
			// (get) Token: 0x0600310E RID: 12558 RVA: 0x001F77AC File Offset: 0x001F59AC
			public bool FoundNPC
			{
				get
				{
					/*
An exception occurred when decompiling this method (0600310E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Utilities.NPCUtils/TargetSearchResults::get_FoundNPC()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(TargetSearchResults::_nearestNPCIndex, ldloc:valuetype Terraria.Utilities.NPCUtils/TargetSearchResults&(this)))
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

			// Token: 0x1700061C RID: 1564
			// (get) Token: 0x0600310F RID: 12559 RVA: 0x001F77C0 File Offset: 0x001F59C0
			public int NearestNPCIndex
			{
				get
				{
					return this._nearestNPCIndex;
				}
			}

			// Token: 0x1700061D RID: 1565
			// (get) Token: 0x06003110 RID: 12560 RVA: 0x001F77D4 File Offset: 0x001F59D4
			public float NearestNPCDistance
			{
				get
				{
					/*
An exception occurred when decompiling this method (06003110)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Utilities.NPCUtils/TargetSearchResults::get_NearestNPCDistance()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(TargetSearchResults::_nearestNPCDistance, ldloc:valuetype Terraria.Utilities.NPCUtils/TargetSearchResults&(this)))
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

			// Token: 0x1700061E RID: 1566
			// (get) Token: 0x06003111 RID: 12561 RVA: 0x001F77E8 File Offset: 0x001F59E8
			public Player NearestTankOwner
			{
				get
				{
					/*
An exception occurred when decompiling this method (06003111)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Player Terraria.Utilities.NPCUtils/TargetSearchResults::get_NearestTankOwner()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(TargetSearchResults::_nearestTankIndex, ldloc:valuetype Terraria.Utilities.NPCUtils/TargetSearchResults&(this)))
	stloc:int32(var_1_0D, ldfld:int32(TargetSearchResults::_nearestTankIndex, ldloc:valuetype Terraria.Utilities.NPCUtils/TargetSearchResults&(this)))
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

			// Token: 0x1700061F RID: 1567
			// (get) Token: 0x06003112 RID: 12562 RVA: 0x001F7804 File Offset: 0x001F5A04
			public bool FoundTank
			{
				get
				{
					/*
An exception occurred when decompiling this method (06003112)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Utilities.NPCUtils/TargetSearchResults::get_FoundTank()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(TargetSearchResults::_nearestTankIndex, ldloc:valuetype Terraria.Utilities.NPCUtils/TargetSearchResults&(this)))
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

			// Token: 0x17000620 RID: 1568
			// (get) Token: 0x06003113 RID: 12563 RVA: 0x001F7818 File Offset: 0x001F5A18
			public int NearestTankOwnerIndex
			{
				get
				{
					return this._nearestTankIndex;
				}
			}

			// Token: 0x17000621 RID: 1569
			// (get) Token: 0x06003114 RID: 12564 RVA: 0x001F782C File Offset: 0x001F5A2C
			public float NearestTankDistance
			{
				get
				{
					/*
An exception occurred when decompiling this method (06003114)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Utilities.NPCUtils/TargetSearchResults::get_NearestTankDistance()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(TargetSearchResults::_nearestTankDistance, ldloc:valuetype Terraria.Utilities.NPCUtils/TargetSearchResults&(this)))
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

			// Token: 0x17000622 RID: 1570
			// (get) Token: 0x06003115 RID: 12565 RVA: 0x001F7840 File Offset: 0x001F5A40
			public float AdjustedTankDistance
			{
				get
				{
					/*
An exception occurred when decompiling this method (06003115)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Utilities.NPCUtils/TargetSearchResults::get_AdjustedTankDistance()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(TargetSearchResults::_adjustedTankDistance, ldloc:valuetype Terraria.Utilities.NPCUtils/TargetSearchResults&(this)))
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

			// Token: 0x17000623 RID: 1571
			// (get) Token: 0x06003116 RID: 12566 RVA: 0x001F7854 File Offset: 0x001F5A54
			public NPCUtils.TargetType NearestTankType
			{
				get
				{
					return this._nearestTankType;
				}
			}

			// Token: 0x06003117 RID: 12567 RVA: 0x001F7868 File Offset: 0x001F5A68
			public TargetSearchResults(NPC searcher, int nearestNPCIndex, float nearestNPCDistance, int nearestTankIndex, float nearestTankDistance, float adjustedTankDistance, NPCUtils.TargetType tankType)
			{
				this._nearestNPCIndex = nearestNPCIndex;
				this._nearestTankIndex = nearestTankIndex;
				this._nearestTankType = tankType;
				this._nearestTargetType = NPCUtils.TargetType.NPC;
			}

			// Token: 0x04003AE3 RID: 15075
			private NPCUtils.TargetType _nearestTargetType;

			// Token: 0x04003AE4 RID: 15076
			private int _nearestNPCIndex;

			// Token: 0x04003AE5 RID: 15077
			private float _nearestNPCDistance;

			// Token: 0x04003AE6 RID: 15078
			private int _nearestTankIndex;

			// Token: 0x04003AE7 RID: 15079
			private float _nearestTankDistance;

			// Token: 0x04003AE8 RID: 15080
			private float _adjustedTankDistance;

			// Token: 0x04003AE9 RID: 15081
			private NPCUtils.TargetType _nearestTankType;
		}

		// Token: 0x02000505 RID: 1285
		[Flags]
		public enum TargetSearchFlag
		{
			// Token: 0x04003AEB RID: 15083
			None = 0,
			// Token: 0x04003AEC RID: 15084
			NPCs = 1,
			// Token: 0x04003AED RID: 15085
			Players = 2,
			// Token: 0x04003AEE RID: 15086
			All = 3
		}
	}
}
