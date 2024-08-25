using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent
{
	// Token: 0x020007B9 RID: 1977
	public class DoorOpeningHelper
	{
		// Token: 0x0600406A RID: 16490 RVA: 0x002432AC File Offset: 0x002414AC
		public void AllowOpeningDoorsByVelocityAloneForATime(int timeInFramesToAllow)
		{
			this._timeWeCanOpenDoorsUsingVelocityAlone = timeInFramesToAllow;
		}

		// Token: 0x0600406B RID: 16491 RVA: 0x002432C0 File Offset: 0x002414C0
		public void Update(Player player)
		{
			this.LookForDoorsToClose(player);
			bool flag = this.ShouldTryOpeningDoors();
		}

		// Token: 0x0600406C RID: 16492 RVA: 0x002432DC File Offset: 0x002414DC
		private bool ShouldTryOpeningDoors()
		{
			if (!true)
			{
			}
			return true;
		}

		// Token: 0x0600406D RID: 16493 RVA: 0x002432F8 File Offset: 0x002414F8
		public static void CyclePreferences()
		{
			if (!true)
			{
			}
			if (!true)
			{
				if (!true)
				{
				}
				return;
			}
		}

		// Token: 0x0600406E RID: 16494 RVA: 0x00243318 File Offset: 0x00241518
		public void LookForDoorsToClose(Player player)
		{
			Rectangle hitbox = player.Hitbox;
			int size = this._ongoingOpenDoors._size;
		}

		// Token: 0x0600406F RID: 16495 RVA: 0x00243348 File Offset: 0x00241548
		private DoorOpeningHelper.PlayerInfoForClosingDoors GetPlayerInfoForClosingDoor(Player player)
		{
			/*
An exception occurred when decompiling this method (0600406F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.GameContent.DoorOpeningHelper/PlayerInfoForClosingDoors Terraria.GameContent.DoorOpeningHelper::GetPlayerInfoForClosingDoor(Terraria.Player)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Rectangle(var_0_06, callgetter:Rectangle(Entity::get_Hitbox, ldloc:Player[exp:Entity](player)))
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

		// Token: 0x06004070 RID: 16496 RVA: 0x0024335C File Offset: 0x0024155C
		public void LookForDoorsToOpen(Player player)
		{
			DoorOpeningHelper.PlayerInfoForOpeningDoors playerInfoForOpeningDoor = this.GetPlayerInfoForOpeningDoor(player);
			float x = player.velocity.X;
		}

		// Token: 0x06004071 RID: 16497 RVA: 0x00243380 File Offset: 0x00241580
		private DoorOpeningHelper.PlayerInfoForOpeningDoors GetPlayerInfoForOpeningDoor(Player player)
		{
			/*
An exception occurred when decompiling this method (06004071)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.GameContent.DoorOpeningHelper/PlayerInfoForOpeningDoors Terraria.GameContent.DoorOpeningHelper::GetPlayerInfoForOpeningDoor(Terraria.Player)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0068:
	stloc:Vector2(var_15_6F, call:Vector2(Utils::TopLeft, ldloc:Rectangle(var_14)))
	stloc:Vector2(var_18_7B, call:Vector2(Utils::BottomRight, ldloc:Rectangle(var_14)))
	stloc:int64(var_21_81, ldc.i4:int64(1))
	stfld:int32(PlayerInfoForOpeningDoors::intendedOpeningDirection, ldloc:PlayerInfoForOpeningDoors[exp:valuetype Terraria.GameContent.DoorOpeningHelper/PlayerInfoForOpeningDoors&](var_0), ldloc:int32(var_12))
	stfld:Rectangle(PlayerInfoForOpeningDoors::hitboxToOpenDoor, ldloc:PlayerInfoForOpeningDoors[exp:valuetype Terraria.GameContent.DoorOpeningHelper/PlayerInfoForOpeningDoors&](var_0), ldloc:int64[exp:Rectangle](var_21_81))
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

		// Token: 0x06004072 RID: 16498 RVA: 0x000021DB File Offset: 0x000003DB
		private void TryAutoOpeningDoor(Point tileCoords, DoorOpeningHelper.PlayerInfoForOpeningDoors playerInfo)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004073 RID: 16499 RVA: 0x00243420 File Offset: 0x00241620
		private bool TryGetHandler(Point tileCoords, [Out] DoorOpeningHelper.DoorAutoHandler infoProvider)
		{
			/*
An exception occurred when decompiling this method (06004073)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.DoorOpeningHelper::TryGetHandler(Microsoft.Xna.Framework.Point,Terraria.GameContent.DoorOpeningHelper/DoorAutoHandler)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0006:
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<int32, class Terraria.GameContent.DoorOpeningHelper/DoorAutoHandler>(var_2_0C, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<int32, class Terraria.GameContent.DoorOpeningHelper/DoorAutoHandler>(DoorOpeningHelper::_handlerByTileType, ldloc:DoorOpeningHelper(this)))
	stloc:uint16(var_3_13, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_1)))
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

		// Token: 0x06004074 RID: 16500 RVA: 0x00243444 File Offset: 0x00241644
		public DoorOpeningHelper()
		{
		}

		// Token: 0x06004075 RID: 16501 RVA: 0x00243458 File Offset: 0x00241658
		// Note: this type is marked as 'beforefieldinit'.
		static DoorOpeningHelper()
		{
		}

		// Token: 0x04007E23 RID: 32291
		public static DoorOpeningHelper.DoorAutoOpeningPreference PreferenceSettings;

		// Token: 0x04007E24 RID: 32292
		private Dictionary<int, DoorOpeningHelper.DoorAutoHandler> _handlerByTileType;

		// Token: 0x04007E25 RID: 32293
		private List<DoorOpeningHelper.DoorOpenCloseTogglingInfo> _ongoingOpenDoors;

		// Token: 0x04007E26 RID: 32294
		private int _timeWeCanOpenDoorsUsingVelocityAlone;

		// Token: 0x020007BA RID: 1978
		public enum DoorAutoOpeningPreference
		{
			// Token: 0x04007E28 RID: 32296
			Disabled,
			// Token: 0x04007E29 RID: 32297
			EnabledForGamepadOnly,
			// Token: 0x04007E2A RID: 32298
			EnabledForEverything
		}

		// Token: 0x020007BB RID: 1979
		private enum DoorCloseAttemptResult
		{
			// Token: 0x04007E2C RID: 32300
			StillInDoorArea,
			// Token: 0x04007E2D RID: 32301
			ClosedDoor,
			// Token: 0x04007E2E RID: 32302
			FailedToCloseDoor,
			// Token: 0x04007E2F RID: 32303
			DoorIsInvalidated
		}

		// Token: 0x020007BC RID: 1980
		private struct DoorOpenCloseTogglingInfo
		{
			// Token: 0x04007E30 RID: 32304
			public Point tileCoordsForToggling;

			// Token: 0x04007E31 RID: 32305
			public DoorOpeningHelper.DoorAutoHandler handler;
		}

		// Token: 0x020007BD RID: 1981
		private struct PlayerInfoForOpeningDoors
		{
			// Token: 0x04007E32 RID: 32306
			public Rectangle hitboxToOpenDoor;

			// Token: 0x04007E33 RID: 32307
			public int intendedOpeningDirection;

			// Token: 0x04007E34 RID: 32308
			public int playerGravityDirection;

			// Token: 0x04007E35 RID: 32309
			public Rectangle tileCoordSpaceForCheckingForDoors;
		}

		// Token: 0x020007BE RID: 1982
		private struct PlayerInfoForClosingDoors
		{
			// Token: 0x04007E36 RID: 32310
			public Rectangle hitboxToNotCloseDoor;
		}

		// Token: 0x020007BF RID: 1983
		private interface DoorAutoHandler
		{
			// Token: 0x06004076 RID: 16502
			DoorOpeningHelper.DoorOpenCloseTogglingInfo ProvideInfo(Point tileCoords);

			// Token: 0x06004077 RID: 16503
			bool TryOpenDoor(DoorOpeningHelper.DoorOpenCloseTogglingInfo info, DoorOpeningHelper.PlayerInfoForOpeningDoors playerInfo);

			// Token: 0x06004078 RID: 16504
			DoorOpeningHelper.DoorCloseAttemptResult TryCloseDoor(DoorOpeningHelper.DoorOpenCloseTogglingInfo info, DoorOpeningHelper.PlayerInfoForClosingDoors playerInfo);
		}

		// Token: 0x020007C0 RID: 1984
		private class CommonDoorOpeningInfoProvider : DoorOpeningHelper.DoorAutoHandler
		{
			// Token: 0x06004079 RID: 16505 RVA: 0x00243468 File Offset: 0x00241668
			public DoorOpeningHelper.DoorOpenCloseTogglingInfo ProvideInfo(Point tileCoords)
			{
				/*
An exception occurred when decompiling this method (06004079)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.GameContent.DoorOpeningHelper/DoorOpenCloseTogglingInfo Terraria.GameContent.DoorOpeningHelper/CommonDoorOpeningInfoProvider::ProvideInfo(Microsoft.Xna.Framework.Point)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int16(var_1_09, callgetter:int16(Tile::get_frameY, ldloc:Tile[exp:valuetype Terraria.Tile&](var_0)))
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

			// Token: 0x0600407A RID: 16506 RVA: 0x00243480 File Offset: 0x00241680
			public bool TryOpenDoor(DoorOpeningHelper.DoorOpenCloseTogglingInfo doorInfo, DoorOpeningHelper.PlayerInfoForOpeningDoors playerInfo)
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
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				Tile tile2;
				ushort type2 = tile2.type;
				if (", HasRightShoulderButton=" == null)
				{
					return;
				}
			}

			// Token: 0x0600407B RID: 16507 RVA: 0x002434C0 File Offset: 0x002416C0
			public DoorOpeningHelper.DoorCloseAttemptResult TryCloseDoor(DoorOpeningHelper.DoorOpenCloseTogglingInfo info, DoorOpeningHelper.PlayerInfoForClosingDoors playerInfo)
			{
				/*
An exception occurred when decompiling this method (0600407B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.GameContent.DoorOpeningHelper/DoorCloseAttemptResult Terraria.GameContent.DoorOpeningHelper/CommonDoorOpeningInfoProvider::TryCloseDoor(Terraria.GameContent.DoorOpeningHelper/DoorOpenCloseTogglingInfo,Terraria.GameContent.DoorOpeningHelper/PlayerInfoForClosingDoors)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0018:
	stloc:int64(var_8_19, ldc.i4:int64(0))
	stloc:int64(var_9_1C, ldc.i4:int64(0))
	stloc:bool(var_10_2C, call:bool(WorldGen::CloseDoor, ldloc:int64[exp:int32](var_8_19), ldc.i4:int32(42183576), ldloc:int64[exp:bool](var_9_1C)))
	stloc:int32(var_12_36, callgetter:int32(Main::get_myPlayer))
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

			// Token: 0x0600407C RID: 16508 RVA: 0x0024350C File Offset: 0x0024170C
			public CommonDoorOpeningInfoProvider()
			{
			}
		}

		// Token: 0x020007C1 RID: 1985
		private class TallGateOpeningInfoProvider : DoorOpeningHelper.DoorAutoHandler
		{
			// Token: 0x0600407D RID: 16509 RVA: 0x00243520 File Offset: 0x00241720
			public DoorOpeningHelper.DoorOpenCloseTogglingInfo ProvideInfo(Point tileCoords)
			{
				/*
An exception occurred when decompiling this method (0600407D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.GameContent.DoorOpeningHelper/DoorOpenCloseTogglingInfo Terraria.GameContent.DoorOpeningHelper/TallGateOpeningInfoProvider::ProvideInfo(Microsoft.Xna.Framework.Point)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int16(var_1_09, callgetter:int16(Tile::get_frameY, ldloc:Tile[exp:valuetype Terraria.Tile&](var_0)))
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

			// Token: 0x0600407E RID: 16510 RVA: 0x00243538 File Offset: 0x00241738
			public bool TryOpenDoor(DoorOpeningHelper.DoorOpenCloseTogglingInfo doorInfo, DoorOpeningHelper.PlayerInfoForOpeningDoors playerInfo)
			{
				/*
An exception occurred when decompiling this method (0600407E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.DoorOpeningHelper/TallGateOpeningInfoProvider::TryOpenDoor(Terraria.GameContent.DoorOpeningHelper/DoorOpenCloseTogglingInfo,Terraria.GameContent.DoorOpeningHelper/PlayerInfoForOpeningDoors)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_6_0B, call:int32(Utils::ToInt, ldc.i4:bool(0)))
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

			// Token: 0x0600407F RID: 16511 RVA: 0x00243558 File Offset: 0x00241758
			public DoorOpeningHelper.DoorCloseAttemptResult TryCloseDoor(DoorOpeningHelper.DoorOpenCloseTogglingInfo info, DoorOpeningHelper.PlayerInfoForClosingDoors playerInfo)
			{
				/*
An exception occurred when decompiling this method (0600407F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.GameContent.DoorOpeningHelper/DoorCloseAttemptResult Terraria.GameContent.DoorOpeningHelper/TallGateOpeningInfoProvider::TryCloseDoor(Terraria.GameContent.DoorOpeningHelper/DoorOpenCloseTogglingInfo,Terraria.GameContent.DoorOpeningHelper/PlayerInfoForClosingDoors)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0015:
	stloc:int32(var_11_20, callgetter:int32(Main::get_myPlayer))
	stloc:int32(var_13_2C, call:int32(Utils::ToInt, ldc.i4:bool(1)))
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

			// Token: 0x06004080 RID: 16512 RVA: 0x00243598 File Offset: 0x00241798
			public TallGateOpeningInfoProvider()
			{
			}
		}
	}
}
