using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Utilities;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.GameContent;
using Terraria.GameContent.Achievements;
using Terraria.GameContent.Creative;
using Terraria.GameContent.Events;
using Terraria.GameContent.Generation;
using Terraria.GameContent.Tile_Entities;
using Terraria.Graphics.Capture;
using Terraria.ID;
using Terraria.IO;
using Terraria.Localization;
using Terraria.Map;
using Terraria.ObjectData;
using Terraria.Utilities;
using Terraria.WorldBuilding;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Profiling;

namespace Terraria
{
	// Token: 0x02000471 RID: 1137
	public class WorldGen
	{
		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06002C3C RID: 11324 RVA: 0x001B7B30 File Offset: 0x001B5D30
		public static UnifiedRandom genRand
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002C3C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Utilities.UnifiedRandom Terraria.WorldGen::get_genRand()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0006:
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

		// Token: 0x06002C3D RID: 11325 RVA: 0x001B7B48 File Offset: 0x001B5D48
		public static void SetupStatueList()
		{
		}

		// Token: 0x06002C3E RID: 11326 RVA: 0x001B7C74 File Offset: 0x001B5E74
		public static void PlaceStatueTrap(int x, int y)
		{
			if (!true)
			{
			}
			Tile tile;
			bool flag = tile.active();
		}

		// Token: 0x06002C3F RID: 11327 RVA: 0x001B7C8C File Offset: 0x001B5E8C
		private static EntitySource_TileBreak GetProjectileSource_TileBreak(int x, int y)
		{
		}

		// Token: 0x06002C40 RID: 11328 RVA: 0x001B7C9C File Offset: 0x001B5E9C
		private static EntitySource_TileBreak GetNPCSource_TileBreak(int x, int y)
		{
		}

		// Token: 0x06002C41 RID: 11329 RVA: 0x000021DB File Offset: 0x000003DB
		public static EntitySource_ShakeTree GetNPCSource_ShakeTree(int x, int y)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002C42 RID: 11330 RVA: 0x000021DB File Offset: 0x000003DB
		private static EntitySource_ShakeTree GetProjectileSource_ShakeTree(int x, int y)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002C43 RID: 11331 RVA: 0x000021DB File Offset: 0x000003DB
		private static EntitySource_ShakeTree GetItemSource_ShakeTree(int x, int y)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002C44 RID: 11332 RVA: 0x000021DB File Offset: 0x000003DB
		private static IEntitySource GetProjectileSource_PlayerOrWires(int x, int y, bool fromWiring, Player player)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002C45 RID: 11333 RVA: 0x001B7CAC File Offset: 0x001B5EAC
		public static bool EmptyLiquid(int x, int y)
		{
			/*
An exception occurred when decompiling this method (06002C45)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::EmptyLiquid(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0049:
	call:void(Liquid::AddWater, ldc.i4:int32(42179336), ldloc:int32(x))
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

		// Token: 0x06002C46 RID: 11334 RVA: 0x001B7D14 File Offset: 0x001B5F14
		public static bool PlaceLiquid(int x, int y, byte liquidType, byte amount)
		{
			if (!true)
			{
			}
			long num = 0L;
			bool flag = WorldGen.InWorld(0, x, (int)num);
			if (!flag)
			{
			}
			Tile tile;
			bool isLoaded = tile.IsLoaded;
			if (!flag)
			{
			}
			if (flag)
			{
				if (!flag)
				{
				}
				if (!flag)
				{
					return;
				}
			}
			if (!flag)
			{
			}
			int num2 = 1;
			WorldGen.SquareTileFrame(0, x, num2 != 0);
			if (!flag)
			{
			}
			if (flag)
			{
				if (!flag)
				{
				}
				NetMessage.sendWater(0, x);
				return false;
			}
		}

		// Token: 0x06002C47 RID: 11335 RVA: 0x001B7D9C File Offset: 0x001B5F9C
		public static void PlayLiquidChangeSound(TileChangeType eventType, int x, int y, int count = 1)
		{
		}

		// Token: 0x06002C48 RID: 11336 RVA: 0x001B7DBC File Offset: 0x001B5FBC
		public static TileChangeType GetLiquidChangeType(int liquidType, int otherLiquidType)
		{
			/*
An exception occurred when decompiling this method (06002C48)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.ID.TileChangeType Terraria.WorldGen::GetLiquidChangeType(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0006:
	brtrue(IL_0000, ldloc:int32[exp:bool](liquidType))
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

		// Token: 0x06002C49 RID: 11337 RVA: 0x001B7DD4 File Offset: 0x001B5FD4
		public static bool MoveTownNPC(int x, int y, int n)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool flag = WorldGen.StartRoomCheck(0, x);
			if (num == 0)
			{
			}
			bool flag2 = WorldGen.RoomNeeds(0);
			if (!false)
			{
			}
			if (!false)
			{
			}
			string textValue = Language.GetTextValue("TownNPCHousingFailureReasons.TooCloseToWorldEdge");
			if ("TownNPCHousingFailureReasons.TooCloseToWorldEdge" == null)
			{
				if ("TownNPCHousingFailureReasons.TooCloseToWorldEdge" == null)
				{
				}
				if ("TownNPCHousingFailureReasons.TooCloseToWorldEdge" == null)
				{
				}
				if ("TownNPCHousingFailureReasons.TooCloseToWorldEdge" != null)
				{
					return false;
				}
				if ("TownNPCHousingFailureReasons.TooCloseToWorldEdge" == null)
				{
				}
				if ("TownNPCHousingFailureReasons.RoomHasAStinkbug" == null)
				{
					goto IL_013C;
				}
				string textValue2 = Language.GetTextValue("TownNPCHousingFailureReasons.RoomHasAnEchoStinkbug");
				if ("TownNPCHousingFailureReasons.RoomHasAnEchoStinkbug" == null)
				{
					return false;
				}
				if ("TownNPCHousingFailureReasons.TooCloseToWorldEdge" == null)
				{
				}
				if ("TownNPCHousingFailureReasons.TooCloseToWorldEdge" != null)
				{
					return false;
				}
				string textValue3 = Language.GetTextValue("Game.HouseLightSource");
				if (textValue3 == null || textValue3 != null)
				{
					if ("TownNPCHousingFailureReasons.TooCloseToWorldEdge" == null)
					{
					}
					if ("TownNPCHousingFailureReasons.TooCloseToWorldEdge" == null)
					{
						string textValue4 = Language.GetTextValue("Game.HouseDoor");
						if (textValue4 != null && textValue4 == null)
						{
							goto IL_0196;
						}
					}
					if ("TownNPCHousingFailureReasons.TooCloseToWorldEdge" == null)
					{
					}
					if ("TownNPCHousingFailureReasons.TooCloseToWorldEdge" == null)
					{
						string textValue5 = Language.GetTextValue("Game.HouseTable");
						if (textValue5 != null && textValue5 == null)
						{
							goto IL_0196;
						}
					}
					if ("TownNPCHousingFailureReasons.TooCloseToWorldEdge" == null)
					{
					}
					if (!false)
					{
						string textValue6 = Language.GetTextValue("Game.HouseChair");
						if (textValue6 != null && textValue6 == null)
						{
							goto IL_0196;
						}
					}
					string text2;
					string text = "Game.HouseMissing_" + text2;
					if ("TownNPCHousingFailureReasons.TooCloseToWorldEdge" == null)
					{
						goto IL_011A;
					}
					goto IL_011A;
				}
				IL_0196:
				throw new ArrayTypeMismatchException();
			}
			IL_011A:
			int num2 = 255;
			int num3 = 240;
			int num4 = 20;
			string text3;
			Main.NewText(text3, (byte)num2, (byte)num3, (byte)num4);
			IL_013C:
			if ("TownNPCHousingFailureReasons.TooCloseToWorldEdge" == null)
			{
			}
			if ("TownNPCHousingFailureReasons.TooCloseToWorldEdge" == null)
			{
			}
			return false;
		}

		// Token: 0x06002C4A RID: 11338 RVA: 0x001B7F7C File Offset: 0x001B617C
		public static void moveRoom(int x, int y, int n)
		{
			if (!true)
			{
			}
			bool netClientOnly = Main.NetClientOnly;
		}

		// Token: 0x06002C4B RID: 11339 RVA: 0x001B7FA4 File Offset: 0x001B61A4
		public static bool IsNPCEvictable(int n)
		{
			if (!true)
			{
			}
			Rectangle hitbox = Main.LocalPlayer.Hitbox;
			bool flag;
			return flag;
		}

		// Token: 0x06002C4C RID: 11340 RVA: 0x001B7FC4 File Offset: 0x001B61C4
		public static void kickOut(int n)
		{
			if (!true)
			{
			}
			bool netClientOnly = Main.NetClientOnly;
		}

		// Token: 0x06002C4D RID: 11341 RVA: 0x001B7FE4 File Offset: 0x001B61E4
		public static bool IsThereASpawnablePrioritizedTownNPC(int x, int y, bool canSpawnNewTownNPC)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool flag = WorldGen.CheckSpecialTownNPCSpawningConditions(0);
			if (num == 0)
			{
			}
			return NPC.AnyNPCs(43143168);
		}

		// Token: 0x06002C4E RID: 11342 RVA: 0x001B8050 File Offset: 0x001B6250
		public static bool IsThereASpawnablePrioritizedTownNPC_Old(int x, int y)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool flag = WorldGen.CheckSpecialTownNPCSpawningConditions(0);
			if (num == 0)
			{
			}
			bool flag2 = NPC.AnyNPCs(43143168);
			long num2 = 0L;
			bool flag3 = NPC.AnyNPCs(-1073741824);
			bool flag4 = WorldGen.CheckSpecialTownNPCSpawningConditions(-1073741824);
			bool flag5 = WorldGen.CheckSpecialTownNPCSpawningConditions((int)num2);
			bool flag6 = NPC.AnyNPCs((int)num2);
			bool flag7;
			return flag7;
		}

		// Token: 0x06002C4F RID: 11343 RVA: 0x001B80B0 File Offset: 0x001B62B0
		public static bool CheckSpecialTownNPCSpawningConditions(int type)
		{
			/*
An exception occurred when decompiling this method (06002C4F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::CheckSpecialTownNPCSpawningConditions(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000B:
	stloc:bool(var_2_11, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_1)))
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

		// Token: 0x06002C50 RID: 11344 RVA: 0x001B80D8 File Offset: 0x001B62D8
		public static void UnspawnTravelNPC()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0 || num == 0)
			{
			}
		}

		// Token: 0x06002C51 RID: 11345 RVA: 0x001B8164 File Offset: 0x001B6364
		public static void SpawnTravelNPC()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002C52 RID: 11346 RVA: 0x001B83AC File Offset: 0x001B65AC
		public static TownNPCSpawnResult SpawnTownNPC(int x, int y)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Tile tile;
			ushort wall = tile.wall;
			int num2;
			if (num != 0)
			{
				if (num == 0)
				{
				}
				num2 = 1;
			}
			if (num == 0)
			{
			}
			if (num != 0)
			{
				if (num == 0)
				{
				}
				bool flag = WorldGen.StartRoomCheck(0, x);
				if (num == 0)
				{
				}
				bool flag2 = WorldGen.RoomNeeds(0);
				if (num == 0)
				{
				}
				int num3 = WorldGen.FindAHomelessNPC();
				if (num == 0)
				{
				}
				if (num2 == 0)
				{
				}
				if (!true)
				{
				}
				long num4 = 0L;
				if (num2 != 0 || num2 == 0)
				{
				}
				if (num4 != 0L)
				{
					WorldGen.ScoreRoom(0, x);
					int num5 = 1;
					if (num5 == 0)
					{
					}
					bool flag3 = WorldGen.IsThereASpawnablePrioritizedTownNPC(0, x, x != 0);
					if (!false)
					{
					}
					if (num5 == 0)
					{
					}
					if (num5 == 0)
					{
					}
					AchievementsHelper.NotifyProgressionEvent(8);
				}
			}
			if (false)
			{
				int num5;
				if (num5 == 0)
				{
				}
				if (num5 == 0)
				{
				}
				int num6 = 1;
				int num3;
				TownNPCSpawnResult townNPCSpawnResult = WorldGen.SpawnTownNPC(0, num3);
				if (num5 == 0)
				{
				}
				long num4;
				bool flag4 = WorldGen.IsRoomConsideredAlreadyOccupied(num6, (int)num4, x);
				if (!false)
				{
				}
				int num7 = 8;
				int num8 = 8;
				int num9 = 32;
				if (!false)
				{
				}
				if (false)
				{
					if (num8 == 0)
					{
					}
					if (num8 == 0 || num8 == 0)
					{
					}
				}
				IEntitySource spawnSourceForTownSpawn = NPC.GetSpawnSourceForTownSpawn();
				if (num8 == 0)
				{
				}
				if (num7 != 0)
				{
					return TownNPCSpawnResult.Blocked;
				}
				if (num7 == 0)
				{
					return TownNPCSpawnResult.Blocked;
				}
				if (num3 == 0)
				{
				}
				if (num3 == 0)
				{
					string text;
					string textValue = Language.GetTextValue("Announcement.HasArrived", text);
					if (num3 == 0)
					{
					}
					int num10 = 50;
					int num11 = 125;
					int num12 = 255;
					Main.NewText(textValue, (byte)num10, (byte)num11, (byte)num12);
				}
				if (num3 == 0)
				{
				}
				bool netHost = Main.NetHost;
				if (num3 == 0)
				{
				}
				NetworkText networkText;
				if (networkText != null && networkText == null)
				{
					throw new ArrayTypeMismatchException();
				}
				AchievementsHelper.NotifyProgressionEvent(8);
				AchievementsHelper.NotifyProgressionEvent(18);
				if (!true)
				{
				}
				if (!false)
				{
				}
				if (false)
				{
				}
				if (!false)
				{
				}
				Tile tile2;
				bool flag5 = tile2.nactive();
				if (!false)
				{
				}
				long num13 = 0L;
				long num14 = 0L;
				Tile tile3;
				ushort type = tile3.type;
				if (!false)
				{
				}
				bool flag6 = Collision.SolidTiles(42168472, (int)num14, num9, (int)num13);
				int num15 = 8;
				if (num15 == 0)
				{
				}
				int num16;
				if (num15 != 0)
				{
					if (num15 == 0)
					{
					}
					num16 = 32640;
				}
				if (num16 == 0)
				{
				}
				if (num16 == 0)
				{
				}
				if (num16 == 0)
				{
				}
				if (num16 == 0)
				{
				}
				if (num16 == 0)
				{
				}
				if (num16 == 0)
				{
				}
				if (num16 == 0)
				{
				}
				if (num16 == 0)
				{
				}
				WorldGen.CheckAchievement_RealEstateAndTownSlimes();
			}
			return TownNPCSpawnResult.Blocked;
		}

		// Token: 0x06002C53 RID: 11347 RVA: 0x001B85C4 File Offset: 0x001B67C4
		private static int FindAHomelessNPC()
		{
			/*
An exception occurred when decompiling this method (06002C53)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.WorldGen::FindAHomelessNPC()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0007:
	stloc:bool(var_2_11, call:bool(WorldGen::CheckSpecialTownNPCSpawningConditions, ldc.i4:int32(43143168)))
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

		// Token: 0x06002C54 RID: 11348 RVA: 0x001B85E4 File Offset: 0x001B67E4
		private static bool IsRoomConsideredAlreadyOccupied(int spawnTileX, int spawnTileY, int npcTypeToSpawn)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06002C55 RID: 11349 RVA: 0x001B8600 File Offset: 0x001B6800
		public static void CheckAchievement_RealEstateAndTownSlimes()
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
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
			}
			if (num != 0 && num != 0 && num != 0 && num != 0 && num != 0 && num != 0 && num != 0 && num != 0 && num != 0 && num != 0 && num != 0 && num != 0 && num != 0 && num != 0 && num != 0 && num != 0 && num != 0 && num != 0 && num != 0 && num != 0 && num != 0 && num != 0 && num != 0 && num != 0 && num != 0)
			{
				AchievementsHelper.NotifyProgressionEvent(17);
			}
			if (num != 0 && num != 0 && num != 0 && num != 0 && num != 0 && num != 0 && num != 0 && num != 0)
			{
				AchievementsHelper.NotifyProgressionEvent(26);
				return;
			}
		}

		// Token: 0x06002C56 RID: 11350 RVA: 0x001B86A8 File Offset: 0x001B68A8
		public static bool RoomNeeds(int npcType)
		{
			/*
An exception occurred when decompiling this method (06002C56)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::RoomNeeds(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0069:
	brtrue(IL_0000, ldloc:int32[exp:bool](var_6_2A))
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

		// Token: 0x06002C57 RID: 11351 RVA: 0x001B8724 File Offset: 0x001B6924
		public static void QuickFindHome(int npc)
		{
			if (!true)
			{
			}
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06002C58 RID: 11352 RVA: 0x001B8794 File Offset: 0x001B6994
		private static bool IsRoomConsideredOccupiedForNPCIndex(int npc)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0 || num == 0 || num != 0)
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

		// Token: 0x06002C59 RID: 11353 RVA: 0x001B87BC File Offset: 0x001B69BC
		private static bool ScoreRoom_IsThisRoomOccupiedBySomeone(int ignoreNPC = -1, int npcTypeAsking = -1)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06002C5A RID: 11354 RVA: 0x001B87D8 File Offset: 0x001B69D8
		public static void CountTileTypesInArea(int[] tileTypeCounts, int startX, int endX, int startY, int endY)
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
		}

		// Token: 0x06002C5B RID: 11355 RVA: 0x001B87FC File Offset: 0x001B69FC
		public static int GetTileTypeCountByCategory(int[] tileTypeCounts, TileScanGroup group)
		{
			int num;
			return num;
		}

		// Token: 0x06002C5C RID: 11356 RVA: 0x001B8810 File Offset: 0x001B6A10
		public static void ScoreRoom(int ignoreNPC = -1, int npcTypeAskingToScoreRoom = -1)
		{
			if (!true)
			{
			}
			bool flag = WorldGen.ScoreRoom_IsThisRoomOccupiedBySomeone(ignoreNPC, npcTypeAskingToScoreRoom);
		}

		// Token: 0x06002C5D RID: 11357 RVA: 0x001B894C File Offset: 0x001B6B4C
		public static void Housing_GetTestedRoomBounds([Out] int startX, [Out] int endX, [Out] int startY, [Out] int endY)
		{
			int num = 1;
			if (num == 0)
			{
			}
			endY.m_value = num;
			int num2 = 5;
			startX.m_value = num2;
			if (num2 == 0)
			{
			}
			endX.m_value = num2;
			int num3 = 5;
			startY.m_value = num3;
			if (num3 == 0)
			{
			}
		}

		// Token: 0x06002C5E RID: 11358 RVA: 0x001B8984 File Offset: 0x001B6B84
		private static bool ScoreRoom_CanBeHomeSpot(int x, int y)
		{
			if (!true)
			{
			}
			Tile tile;
			bool flag = tile.active();
			return true;
		}

		// Token: 0x06002C5F RID: 11359 RVA: 0x001B89A0 File Offset: 0x001B6BA0
		private static bool Housing_CheckIfIsCeiling(int i, int j)
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

		// Token: 0x06002C60 RID: 11360 RVA: 0x001B89B8 File Offset: 0x001B6BB8
		private static bool Housing_CheckIfInRoom(int i, int j)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06002C61 RID: 11361 RVA: 0x001B89D4 File Offset: 0x001B6BD4
		public static bool StartRoomCheck(int x, int y)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			return false;
		}

		// Token: 0x06002C62 RID: 11362 RVA: 0x001B8A38 File Offset: 0x001B6C38
		public static void CheckRoom(int x, int y)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002C63 RID: 11363 RVA: 0x001B8AA8 File Offset: 0x001B6CA8
		public static void dropMeteor()
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool netClientOnly = Main.NetClientOnly;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				if (num == 0)
				{
				}
				if (num != 0)
				{
					if (num == 0)
					{
					}
					if (num != 0)
					{
						return;
					}
					long num2 = 16505L;
					long num3 = 32752L;
					if (num2 == 0L)
					{
					}
					if (num2 == 0L)
					{
					}
					if (num3 == 0L)
					{
					}
					Tile tile;
					bool flag = tile.active();
					Tile tile2;
					ushort type = tile2.type;
					return;
				}
			}
		}

		// Token: 0x06002C64 RID: 11364 RVA: 0x001B8BC0 File Offset: 0x001B6DC0
		public static bool meteor(int i, int j, bool ignorePlayers = false)
		{
			/*
An exception occurred when decompiling this method (06002C64)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::meteor(System.Int32,System.Int32,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_02CD:
	stloc:bool(var_113_2D5, callgetter:bool(Main::get_NetHost))
	stloc:bool(var_119_2F1, callgetter:bool(Main::get_LogicHost))
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

		// Token: 0x06002C65 RID: 11365 RVA: 0x001B8EC8 File Offset: 0x001B70C8
		public static void setWorldSize()
		{
			int num = 1;
			if (num == 0)
			{
			}
			int num2 = 34079;
			if (num2 == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num2 == 0)
			{
			}
		}

		// Token: 0x06002C66 RID: 11366 RVA: 0x001B8EF8 File Offset: 0x001B70F8
		public static int GetWorldSize()
		{
			/*
An exception occurred when decompiling this method (06002C66)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.WorldGen::GetWorldSize()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	brtrue(IL_0000, ldc.i4:int32[exp:bool](4201))
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

		// Token: 0x06002C67 RID: 11367 RVA: 0x001B8F10 File Offset: 0x001B7110
		public static void worldGenCallback(object threadContext)
		{
			int num = 1;
			if (num == 0)
			{
			}
			DrPlatform.Switch.CPUBoostMode = true;
			if (num == 0)
			{
			}
			WorldGen.clearWorld();
			ThreadManager.CheckThreadTerminiate();
			if (threadContext != null)
			{
			}
		}

		// Token: 0x06002C68 RID: 11368 RVA: 0x001B8FB0 File Offset: 0x001B71B0
		public static void CreateNewWorld([Optional] GenerationProgress progress)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x06002C69 RID: 11369 RVA: 0x001B8FC8 File Offset: 0x001B71C8
		public static void JustQuit()
		{
			int num = 1;
			if (num == 0)
			{
			}
			Main.menuMode = 10;
			Main.gameMenu = true;
			SoundEngine.StopTrackedSounds();
			if (num == 0)
			{
			}
			CaptureInterface.ResetFocus();
			Main.ActivePlayerFileData.StopPlayTimer();
			Main.UpdateTimeRate();
			bool logicClient = Main.LogicClient;
			Main.GoToWorldSelect();
			int myPlayer = Main.myPlayer;
			bool netClientOnly = Main.NetClientOnly;
			Main.menuMode = 0;
		}

		// Token: 0x06002C6A RID: 11370 RVA: 0x001B904C File Offset: 0x001B724C
		private static void ShutDownServer()
		{
		}

		// Token: 0x06002C6B RID: 11371 RVA: 0x001B9068 File Offset: 0x001B7268
		private static void WaitForFileSync()
		{
			string textValue = Language.GetTextValue("Mobile.FileSyncInProgress");
		}

		// Token: 0x06002C6C RID: 11372 RVA: 0x001B909C File Offset: 0x001B729C
		public static void SaveAndQuitCallBack(object threadContext)
		{
			if (threadContext != null)
			{
				return;
			}
			DrPlatform.Switch.CPUBoostMode = true;
			WorldFile.CacheSaveTime();
		}

		// Token: 0x06002C6D RID: 11373 RVA: 0x001B91BC File Offset: 0x001B73BC
		private static void LocalUserQuitOnMainThread(object localUserContext)
		{
			if (true)
			{
				if (localUserContext == null)
				{
					return;
				}
			}
			else if (localUserContext != null)
			{
			}
		}

		// Token: 0x06002C6E RID: 11374 RVA: 0x001B91D8 File Offset: 0x001B73D8
		public static void SaveAndQuit()
		{
			if (!true)
			{
			}
			Main.Quitting = true;
			if (!true)
			{
			}
		}

		// Token: 0x06002C6F RID: 11375 RVA: 0x001B91F4 File Offset: 0x001B73F4
		public static void RenameWorld(WorldFileData data, string newName, [Optional] Action<string> callback)
		{
		}

		// Token: 0x06002C70 RID: 11376 RVA: 0x001B9204 File Offset: 0x001B7404
		public static void RenameWorldCallBack(object threadContext)
		{
			if (threadContext != null)
			{
			}
		}

		// Token: 0x06002C71 RID: 11377 RVA: 0x001B9270 File Offset: 0x001B7470
		public static void playWorldCallBack(object threadContext)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			long ticks = DateTime.Now.Ticks;
			int myPlayer = Main.myPlayer;
			int num2 = 1;
			Main.ToggleGameplayUpdates(false);
			if (num2 == 0)
			{
			}
			WorldFile.LoadWorld(true);
			if (num2 == 0)
			{
				if (num2 == 0)
				{
				}
				return;
			}
			if (num2 == 0)
			{
			}
			WorldFile.LoadWorld(true);
			if (num2 == 0)
			{
				if (num2 == 0)
				{
				}
				return;
			}
			string text = Main.worldPathName + ".bak";
			if (num2 == 0)
			{
			}
			if (num2 == 0)
			{
			}
			if (num2 == 0)
			{
			}
			bool flag;
			if (flag)
			{
				if (ticks == 0L)
				{
					string textValue = Language.GetTextValue("Error.LoadFailedNoBackup");
					if (num2 == 0)
					{
					}
					Console.WriteLine(textValue);
					return;
				}
				string worldPathName = Main.worldPathName;
				string text2 = Main.worldPathName + ".bad";
				if (num2 == 0)
				{
				}
				int num3 = 1;
				FileUtilities.Copy(worldPathName, text2, true, num3 != 0);
				string text3 = Main.worldPathName + ".bak";
				string worldPathName2 = Main.worldPathName;
				int num4 = 1;
				FileUtilities.Copy(text3, worldPathName2, true, num4 != 0);
				FileUtilities.Delete(Main.worldPathName + ".bak", true);
				if (num2 == 0)
				{
				}
				WorldFile.LoadWorld(true);
				if (num2 == 0)
				{
					if (num2 == 0)
					{
					}
					return;
				}
				if (num2 == 0)
				{
				}
				WorldFile.LoadWorld(true);
				if (num2 != 0)
				{
					string worldPathName3 = Main.worldPathName;
					string text4 = Main.worldPathName + ".bak";
					if (num2 == 0)
					{
					}
					int num5 = 1;
					FileUtilities.Copy(worldPathName3, text4, true, num5 != 0);
					string text5 = Main.worldPathName + ".bad";
					string worldPathName4 = Main.worldPathName;
					int num6 = 1;
					FileUtilities.Copy(text5, worldPathName4, true, num6 != 0);
					FileUtilities.Delete(Main.worldPathName + ".bad", true);
					string textValue2 = Language.GetTextValue("Error.LoadFailed");
					if (num2 == 0)
					{
					}
					Console.WriteLine(textValue2);
					DrPlatform.Switch.CPUBoostMode = false;
					return;
				}
				if (num2 == 0)
				{
				}
				bool mapEnabled = Main.mapEnabled;
				Main.Map.Load();
				bool logicClient = Main.LogicClient;
				Main.sectionManager.SetAllSectionsLoaded();
				bool loadMapLock = Main.loadMapLock;
				int totalMapSections = Main.sectionManager.TotalMapSections;
				int mapSectionsLeft = Main.sectionManager.mapSectionsLeft;
				int totalMapSections2 = Main.sectionManager.TotalMapSections;
				if (num2 == 0)
				{
				}
				Thread.Sleep(0);
				bool mapEnabled2 = Main.mapEnabled;
				return;
			}
			else
			{
				if (".bad" != null)
				{
					return;
				}
				Main.menuMode = 201;
				return;
			}
		}

		// Token: 0x06002C72 RID: 11378 RVA: 0x001B9508 File Offset: 0x001B7708
		public static void JoinLocalWorld()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002C73 RID: 11379 RVA: 0x001B951C File Offset: 0x001B771C
		public static void joinLocalWorldCallBack(object threadContext)
		{
			if (threadContext != null)
			{
				return;
			}
			long ticks = DateTime.Now.Ticks;
			long num = 0L;
			int num2 = 1;
			bool mapEnabled = Main.mapEnabled;
			Main.Map.Allocate((int)ticks, (int)num);
			Main.Map.Load();
			bool loadMapLock = Main.loadMapLock;
			int totalMapSections = Main.sectionManager.TotalMapSections;
			int mapSectionsLeft = Main.sectionManager.mapSectionsLeft;
			int totalMapSections2 = Main.sectionManager.TotalMapSections;
			if (num2 == 0)
			{
			}
			Thread.Sleep(0);
			bool mapEnabled2 = Main.mapEnabled;
		}

		// Token: 0x06002C74 RID: 11380 RVA: 0x001B95B8 File Offset: 0x001B77B8
		public static void FinaliseOnMainThread(object threadContext)
		{
			long num;
			if (threadContext != null)
			{
				num = 0L;
				return;
			}
			CreativePowerManager.SyncSplitScreenPlayer((int)num);
			int num2 = 1;
			bool gameMenu = Main.gameMenu;
			WaterfallManager waterfallManager;
			waterfallManager.Reset();
			Main.gameMenu = false;
			if (num2 != 0)
			{
			}
		}

		// Token: 0x06002C75 RID: 11381 RVA: 0x001B9658 File Offset: 0x001B7858
		public static void playWorld()
		{
			DrPlatform.Switch.CPUBoostMode = true;
		}

		// Token: 0x06002C76 RID: 11382 RVA: 0x001B9670 File Offset: 0x001B7870
		public static void saveAndPlayCallBack(object threadContext)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			Profiler.EndThreadProfiling();
		}

		// Token: 0x06002C77 RID: 11383 RVA: 0x001B968C File Offset: 0x001B788C
		public static void saveAndPlay()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002C78 RID: 11384 RVA: 0x001B96A0 File Offset: 0x001B78A0
		public static void saveToonWhilePlayingCallBack(object threadContext)
		{
			if (threadContext != null)
			{
				bool gameMenu = Main.gameMenu;
				bool settingsSavePending = Main.SettingsSavePending;
				bool flag = Main.SaveSettings();
				if (Main.ActivePlayerFileData != null)
				{
					Player player = Main.ActivePlayerFileData._player;
					if (player != null)
					{
						if (player == null)
						{
						}
						int num = 1;
						if (player == null)
						{
						}
						PlayerFileData activePlayerFileData = Main.ActivePlayerFileData;
						if (num == 0)
						{
						}
						long num2 = 0L;
						long num3 = 0L;
						Player.SavePlayer(activePlayerFileData, num2 != 0L, num3 != 0L);
					}
				}
			}
			Profiler.EndThreadProfiling();
		}

		// Token: 0x06002C79 RID: 11385 RVA: 0x001B9720 File Offset: 0x001B7920
		public static void saveToonWhilePlaying()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002C7A RID: 11386 RVA: 0x001B9734 File Offset: 0x001B7934
		public static void serverLoadWorldCallBack()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			long ticks = DateTime.Now.Ticks;
			WorldFile.LoadWorld(true);
			WorldFile.LoadWorld(true);
			string text = Main.worldPathName + ".bak";
			bool flag;
			if (flag)
			{
				string worldPathName = Main.worldPathName;
				long num = 0L;
				string text2 = worldPathName + ".bak";
				string worldPathName2 = Main.worldPathName;
				FileUtilities.Copy(text2, worldPathName2, num != 0L, true);
				string text3 = Main.worldPathName + ".bak";
				WorldFile.LoadWorld(true);
				WorldFile.LoadWorld(true);
				return;
			}
			string textValue = Language.GetTextValue("Error.LoadFailedNoBackup");
			Console.WriteLine(textValue);
		}

		// Token: 0x06002C7B RID: 11387 RVA: 0x001B982C File Offset: 0x001B7A2C
		public static ManagedThread serverLoadWorld()
		{
			if (!true)
			{
			}
			ManagedThread managedThread;
			return managedThread;
		}

		// Token: 0x06002C7C RID: 11388 RVA: 0x001B9840 File Offset: 0x001B7A40
		private static void SetWorldSizeOnMainThread(object data)
		{
			if (!true)
			{
			}
			bool logicClient = Main.LogicClient;
			int num = 150;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			bool logicHost = Main.LogicHost;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			WorldMap map = Main.Map;
		}

		// Token: 0x06002C7D RID: 11389 RVA: 0x001B9884 File Offset: 0x001B7A84
		public static void clearWorld()
		{
			int num = 1;
			if (num == 0)
			{
			}
			WorldGen.ResetTreeShakes();
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			NPC.ResetBadgerHatTime();
			Main.mapDelay = 2;
			Main.waterStyle = 0;
			Main.ResetWindCounter(true);
			PressurePlateHelper.Reset();
			NPC.ResetKillCount();
			MapHelper.ResetMapData();
			TileEntity.Clear();
			Main.checkXMas();
			Main.checkHalloween();
			DontStarveDarknessDamageDealer.Reset();
			Wiring.ClearAll();
			bool mapReady = Main.mapReady;
		}

		// Token: 0x06002C7E RID: 11390 RVA: 0x001B9A18 File Offset: 0x001B7C18
		public static void setBG(int bg, int style)
		{
		}

		// Token: 0x06002C7F RID: 11391 RVA: 0x001B9AB8 File Offset: 0x001B7CB8
		private static void SetForestBGSet(int style, int[] mountainSet, int[] treeSet)
		{
		}

		// Token: 0x06002C80 RID: 11392 RVA: 0x001B9AE0 File Offset: 0x001B7CE0
		public static void RandomizeWeather()
		{
			if (!true)
			{
			}
			int num = WorldGen.genRand.Next(10, 200);
			int num2 = WorldGen.genRand.Next(10, 401);
		}

		// Token: 0x06002C81 RID: 11393 RVA: 0x001B9B1C File Offset: 0x001B7D1C
		public static void RandomizeMoonState(UnifiedRandom random, bool garenteeNewStyle = false)
		{
			if (!true)
			{
			}
			int num = random.Next(9);
		}

		// Token: 0x06002C82 RID: 11394 RVA: 0x001B9B38 File Offset: 0x001B7D38
		public static void RandomizeBackgroundBasedOnPlayer(UnifiedRandom random, Player player)
		{
			bool zoneGlowshroom = player.ZoneGlowshroom;
			if (!true)
			{
			}
			if (!true)
			{
			}
			int num = random.Next(4);
			WorldGen.setBG(8, num);
		}

		// Token: 0x06002C83 RID: 11395 RVA: 0x001B9C9C File Offset: 0x001B7E9C
		public static void RandomizeBackgrounds(UnifiedRandom random)
		{
			if (!true)
			{
			}
			int num = WorldGen.RollRandomForestBGStyle(random);
			int num2 = WorldGen.RollRandomForestBGStyle(random);
			int num3 = WorldGen.RollRandomForestBGStyle(random);
		}

		// Token: 0x06002C84 RID: 11396 RVA: 0x001B9DAC File Offset: 0x001B7FAC
		private static int RollRandomForestBGStyle(UnifiedRandom random)
		{
			int num;
			if (num == 0)
			{
				int num2;
				if (num2 == 0)
				{
				}
				int num3;
				return num3;
			}
			int num4;
			return num4;
		}

		// Token: 0x06002C85 RID: 11397 RVA: 0x001B9DF0 File Offset: 0x001B7FF0
		public static bool IsBackgroundConsideredTheSame(int oldBG, int newBG)
		{
		}

		// Token: 0x06002C86 RID: 11398 RVA: 0x001B9E00 File Offset: 0x001B8000
		public static void RandomizeTreeStyle()
		{
			long num;
			if (true)
			{
				UnifiedRandom genRand = WorldGen.genRand;
				num = 32752L;
				UnifiedRandom genRand2 = WorldGen.genRand;
				int num2 = 6;
				int num3 = genRand2.Next(num2);
				UnifiedRandom genRand3 = WorldGen.genRand;
				int num4 = 6;
				int num5 = genRand3.Next(num4);
				if (num == 0L)
				{
				}
				if (num == 0L)
				{
				}
				while (num != 0L)
				{
				}
				return;
			}
			if (num == 0L)
			{
			}
			int num6 = 4200;
			if (num6 == 0)
			{
			}
			if (num6 == 0)
			{
			}
			UnifiedRandom genRand4 = WorldGen.genRand;
			int num8;
			long num9;
			int num7 = genRand4.Next(num8, (int)num9);
			int num10 = WorldGen.genRand.Next(num8, (int)num9);
			UnifiedRandom genRand5 = WorldGen.genRand;
			int num11 = 6;
			int num12 = genRand5.Next(num11);
			UnifiedRandom genRand6 = WorldGen.genRand;
			int num13 = 6;
			int num14 = genRand6.Next(num13);
			UnifiedRandom genRand7 = WorldGen.genRand;
			int num15 = 6;
			int num16 = genRand7.Next(num15);
			UnifiedRandom genRand8 = WorldGen.genRand;
			int num17 = 6;
			int num18 = genRand8.Next(num17);
		}

		// Token: 0x06002C87 RID: 11399 RVA: 0x001BA014 File Offset: 0x001B8214
		public static void RandomizeCaveBackgrounds()
		{
			long num2;
			if (true)
			{
				UnifiedRandom genRand = WorldGen.genRand;
				int num = WorldGen.genRand.Next(8);
				UnifiedRandom genRand2 = WorldGen.genRand;
				num2 = 0L;
				int num3 = genRand2.Next(8);
				return;
			}
			if (4200 == 0)
			{
			}
			if (4200 == 0)
			{
			}
			int num4 = WorldGen.genRand.Next(8, (int)num2);
			int num5 = WorldGen.genRand.Next(8, (int)num2);
			int num6 = WorldGen.genRand.Next(8);
			int num7 = WorldGen.genRand.Next(8);
			int num8 = WorldGen.genRand.Next(8);
			int num9 = WorldGen.genRand.Next(8);
		}

		// Token: 0x06002C88 RID: 11400 RVA: 0x001BA194 File Offset: 0x001B8394
		private static void ResetGenerator()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x06002C89 RID: 11401 RVA: 0x001BA1AC File Offset: 0x001B83AC
		public static bool mayanTrap(int x2, int y2)
		{
			int num = 1;
			if (num == 0)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num2 = 3;
			int num3 = genRand.Next(num2);
			if (num == 0)
			{
			}
			bool flag = WorldGen.SolidOrSlopedTile(0, x2);
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
			Tile tile2;
			ushort type2 = tile2.type;
			if (num == 0)
			{
			}
			Tile tile3;
			byte liquid = tile3.liquid;
			if (num == 0)
			{
			}
			Tile tile4;
			bool flag2 = tile4.lava();
			if (num == 0)
			{
			}
			Tile tile5;
			bool flag3 = tile5.nactive();
			if (num == 0)
			{
			}
			Tile tile6;
			bool flag4 = tile6.nactive();
			if (num == 0)
			{
			}
			Tile tile7;
			bool flag5 = tile7.nactive();
			if (num == 0)
			{
			}
			Tile tile8;
			bool flag6 = tile8.nactive();
			if (num == 0)
			{
			}
			Tile tile9;
			bool flag7 = tile9.nactive();
			if (num == 0)
			{
			}
			Tile tile10;
			bool flag8 = tile10.nactive();
			if (num == 0)
			{
			}
			Tile tile11;
			bool flag9 = tile11.nactive();
			if (num == 0)
			{
			}
			Tile tile12;
			bool flag10 = tile12.nactive();
			if (num == 0)
			{
			}
			Tile tile13;
			bool flag11 = tile13.nactive();
			if (num == 0)
			{
			}
			Tile tile14;
			ushort type3 = tile14.type;
			if (num == 0)
			{
			}
			Tile tile15;
			ushort type4 = tile15.type;
			if (num == 0)
			{
			}
			Tile tile16;
			ushort type5 = tile16.type;
			long num4;
			if (num3 != 0)
			{
				num4 = 0L;
				if (num == 0)
				{
				}
				bool flag12 = WorldGen.SolidOrSlopedTile(0, num3);
			}
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num5 = 3;
			int num6 = genRand2.Next(num5);
			int num7 = 5;
			bool flag13 = WorldGen.InWorld((int)num4, num3, num7);
			return WorldGen.SolidOrSlopedTile((int)num4, num3);
		}

		// Token: 0x06002C8A RID: 11402 RVA: 0x001BA7E0 File Offset: 0x001B89E0
		public static bool placeLavaTrap(int x, int y)
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
			byte liquid = tile2.liquid;
			if (num == 0)
			{
			}
			Tile tile3;
			bool flag2 = tile3.lava();
			if (num == 0)
			{
			}
			Tile tile4;
			bool flag3 = tile4.lava();
			if (num == 0)
			{
			}
			Tile tile5;
			bool flag4 = tile5.active();
			if (num == 0)
			{
			}
			Tile tile6;
			byte liquid2 = tile6.liquid;
			Tile tile7;
			bool flag5 = tile7.active();
			Tile tile8;
			ushort type = tile8.type;
			Tile tile9;
			ushort type2 = tile9.type;
			Tile tile10;
			bool flag6 = tile10.active();
			Tile tile11;
			ushort type3 = tile11.type;
			Tile tile12;
			ushort type4 = tile12.type;
			Tile tile13;
			return tile13.wire();
		}

		// Token: 0x06002C8B RID: 11403 RVA: 0x001BA94C File Offset: 0x001B8B4C
		public static bool IsTileNearby(int x, int y, int type, int distance)
		{
			return 1073741824 != 0;
		}

		// Token: 0x06002C8C RID: 11404 RVA: 0x001BA970 File Offset: 0x001B8B70
		private static bool placeTNTBarrel(int x, int y)
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
			}
			Tile tile2;
			bool flag2 = tile2.shimmer();
			if (num == 0)
			{
			}
			bool flag3;
			return flag3;
		}

		// Token: 0x06002C8D RID: 11405 RVA: 0x001BA9A4 File Offset: 0x001B8BA4
		public static bool placeTrap(int x2, int y2, int type = -1)
		{
			if (!true)
			{
			}
			long num = 16473L;
			if (num == 0L)
			{
			}
			if (num == 0L || num == 0L)
			{
			}
			if (num == 0L)
			{
			}
			long num2 = 0L;
			bool flag = WorldGen.SolidTile(0, x2, num2 != 0L);
			if (num == 0L)
			{
			}
			int num3 = 70;
			int num4 = 20;
			bool flag2 = WorldGen.IsTileNearby(0, 42189464, num3, num4);
			Tile tile;
			ushort wall = tile.wall;
			Tile tile2;
			byte liquid = tile2.liquid;
			Tile tile3;
			return tile3.lava();
		}

		// Token: 0x06002C8E RID: 11406 RVA: 0x001BB0C4 File Offset: 0x001B92C4
		public static int countWires(int x, int y, int size)
		{
			/*
An exception occurred when decompiling this method (06002C8E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.WorldGen::countWires(System.Int32,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0019:
	stloc:bool(var_5_20, call:bool(Tile::wire, ldloc:Tile[exp:valuetype Terraria.Tile&](var_4)))
	stloc:bool(var_7_29, call:bool(Tile::wire2, ldloc:Tile[exp:valuetype Terraria.Tile&](var_6)))
	stloc:bool(var_9_32, call:bool(Tile::wire3, ldloc:Tile[exp:valuetype Terraria.Tile&](var_8)))
	stloc:bool(var_11_3B, call:bool(Tile::wire4, ldloc:Tile[exp:valuetype Terraria.Tile&](var_10)))
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

		// Token: 0x06002C8F RID: 11407 RVA: 0x001BB110 File Offset: 0x001B9310
		public static int countTiles(int x, int y, bool jungle = false, bool lavaOk = false)
		{
			if (!true)
			{
			}
			WorldGen.nextCount(0, x, y != 0, jungle);
			return 0;
		}

		// Token: 0x06002C90 RID: 11408 RVA: 0x001BB12C File Offset: 0x001B932C
		public static void nextCount(int x, int y, bool jungle = false, bool lavaOk = false)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Tile.StartNewSearch();
			if (num == 0)
			{
			}
		}

		// Token: 0x06002C91 RID: 11409 RVA: 0x001BB184 File Offset: 0x001B9384
		public static int countDirtTiles(int x, int y)
		{
			if (!true)
			{
			}
			WorldGen.nextDirtCount(0, x);
			return 0;
		}

		// Token: 0x06002C92 RID: 11410 RVA: 0x001BB19C File Offset: 0x001B939C
		public static void nextDirtCount(int x, int y)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Tile.StartNewSearch();
			if (num == 0)
			{
			}
		}

		// Token: 0x06002C93 RID: 11411 RVA: 0x001BB2BC File Offset: 0x001B94BC
		public static bool InWorld(int x, int y, int fluff = 0)
		{
			/*
An exception occurred when decompiling this method (06002C93)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::InWorld(System.Int32,System.Int32,System.Int32)

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

		// Token: 0x06002C94 RID: 11412 RVA: 0x001BB2D0 File Offset: 0x001B94D0
		public static void gemCave(int x, int y)
		{
			int num = 1;
			if (num == 0)
			{
			}
			long num2 = 0L;
			long num3 = 0L;
			int num4 = WorldGen.countTiles(x, y, num2 != 0L, num3 != 0L);
			if (num == 0)
			{
			}
		}

		// Token: 0x06002C95 RID: 11413 RVA: 0x001BB340 File Offset: 0x001B9540
		public static int randGem()
		{
			while (!true)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num = 6;
			return genRand.Next(num);
		}

		// Token: 0x06002C96 RID: 11414 RVA: 0x001BB360 File Offset: 0x001B9560
		public static ushort randGemTile()
		{
			/*
An exception occurred when decompiling this method (06002C96)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.UInt16 Terraria.WorldGen::randGemTile()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0014:
	stloc:int32(var_0_19, call:int32(WorldGen::randGem))
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

		// Token: 0x06002C97 RID: 11415 RVA: 0x001BB388 File Offset: 0x001B9588
		public static void randMoss(bool justNeon = false)
		{
			if (!true)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num = WorldGen.genRand.Next(5);
			int num2 = WorldGen.genRand.Next(5);
			int num3 = WorldGen.genRand.Next(5);
		}

		// Token: 0x06002C98 RID: 11416 RVA: 0x001BB3D0 File Offset: 0x001B95D0
		public static void neonMossBiome(int i, int j, int maxY = 99999)
		{
			if (!true)
			{
			}
			double num = WorldGen.genRand.NextDouble();
			double num2 = WorldGen.genRand.NextDouble();
			long num3 = 16368L;
			if (num3 == 0L)
			{
			}
			Vector2D vector2D;
			double num4 = vector2D.Length();
			if (num3 == 0L)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num5 = 60;
			int num6 = 80;
			int num7 = genRand.Next(num5, num6);
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num8 = 30;
			int num9 = 40;
			int num10 = genRand2.Next(num8, num9);
			if (32752 == 0)
			{
			}
		}

		// Token: 0x06002C99 RID: 11417 RVA: 0x001BB4F8 File Offset: 0x001B96F8
		public static void setMoss(int x, int y)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002C9A RID: 11418 RVA: 0x001BB510 File Offset: 0x001B9710
		public static void FillWallHolesInArea(Rectangle worldCoordsArea)
		{
			if (!true)
			{
			}
			long num = 0L;
			int num3;
			int num2 = Math.Min(num3, (int)num);
			int num5;
			int num6;
			int num4 = WorldGen.FillWallHolesInColumn(num5, 43143168, num6);
		}

		// Token: 0x06002C9B RID: 11419 RVA: 0x001BB53C File Offset: 0x001B973C
		private static int FillWallHolesInColumn(int x, int startY, int endY)
		{
			/*
An exception occurred when decompiling this method (06002C9B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.WorldGen::FillWallHolesInColumn(System.Int32,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_0_04, ldc.i4:int32(2))
	stloc:int32(var_1_0C, call:int32(Math::Max, ldloc:int32(x), ldloc:int32(var_0_04)))
	stloc:int32(var_2_14, call:int32(Math::Min, ldloc:int32(startY), ldloc:int32(var_0_04)))
	stloc:uint16(var_4_1B, callgetter:uint16(Tile::get_wall, ldloc:Tile[exp:valuetype Terraria.Tile&](var_3)))
	stloc:int32(var_5_22, ldc.i4:int32(150))
	stloc:bool(var_6_31, call:bool(WorldGen::FillWallHolesInSpot, ldc.i4:int32(1073741824), ldloc:int32(var_1_0C), ldloc:int32(var_5_22)))
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

		// Token: 0x06002C9C RID: 11420 RVA: 0x001BB580 File Offset: 0x001B9780
		private static bool FillWallHolesInSpot(int originX, int originY, int maxWallsThreshold)
		{
			int num = 2;
			bool flag = WorldGen.InWorld(0, originX, num);
			return false;
		}

		// Token: 0x06002C9D RID: 11421 RVA: 0x001BB600 File Offset: 0x001B9800
		public static void tileCountAndDestroy()
		{
			if (!true)
			{
			}
			int num = 10;
			int num2 = 10;
			Tile tile;
			bool flag = tile.active();
			int num3 = WorldGen.tileCounter(num, num2);
			WorldGen.tileCounterKill();
		}

		// Token: 0x06002C9E RID: 11422 RVA: 0x001BB630 File Offset: 0x001B9830
		public static int tileCounter(int x, int y)
		{
			if (!true)
			{
			}
			Tile tile;
			ushort tileSeachUID = tile.TileSeachUID;
			return 0;
		}

		// Token: 0x06002C9F RID: 11423 RVA: 0x001BB658 File Offset: 0x001B9858
		public static void tileCounterNext(int x, int y)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Tile tile;
			ushort tileSeachUID = tile.TileSeachUID;
			WorldGen.tileCounterNext(0, y);
			WorldGen.tileCounterNext(0, y);
			WorldGen.tileCounterNext(x, y);
			WorldGen.tileCounterNext(x, y);
		}

		// Token: 0x06002CA0 RID: 11424 RVA: 0x001BB694 File Offset: 0x001B9894
		public static void tileCounterKill()
		{
			long num = 0L;
			Tile tile;
			tile.active(num != 0L);
		}

		// Token: 0x06002CA1 RID: 11425 RVA: 0x001BB6AC File Offset: 0x001B98AC
		private static void AddGenerationPass(string name, WorldGenLegacyMethod method)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002CA2 RID: 11426 RVA: 0x001BB6BC File Offset: 0x001B98BC
		private static void AddGenerationPass(GenPass pass)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002CA3 RID: 11427 RVA: 0x001BB6CC File Offset: 0x001B98CC
		private static void AddGenerationPass(string name, double weight, WorldGenLegacyMethod method)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002CA4 RID: 11428 RVA: 0x001BB6DC File Offset: 0x001B98DC
		public static bool checkUnderground(int x, int y)
		{
			/*
An exception occurred when decompiling this method (06002CA4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::checkUnderground(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0031:
	stloc:uint16(var_8_3B, callgetter:uint16(Tile::get_wall, ldloc:Tile[exp:valuetype Terraria.Tile&](var_6)))
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

		// Token: 0x06002CA5 RID: 11429 RVA: 0x001BB72C File Offset: 0x001B992C
		public static int GetNextJungleChestItem()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num2 = 50;
			if (genRand.Next(num2) == 0)
			{
				int num3;
				return num3;
			}
			if (num == 0)
			{
			}
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num4 = 15;
			int num6;
			if (genRand2.Next(num4) != 0)
			{
				if (num == 0)
				{
				}
				UnifiedRandom genRand3 = WorldGen.genRand;
				int num5 = 20;
				int num3 = genRand3.Next(num5);
				num6 = 3017;
				return num3;
			}
			int num7 = 2292;
			if (num6 == 0)
			{
			}
			return num7;
		}

		// Token: 0x06002CA6 RID: 11430 RVA: 0x001BB7A0 File Offset: 0x001B99A0
		private static void ScanTileColumnAndRemoveClumps(int x)
		{
			if (!true)
			{
			}
			Tile tile;
			bool flag = tile.active();
			Tile tile2;
			ushort type = tile2.type;
			Tile tile3;
			ushort type2 = tile3.type;
		}

		// Token: 0x06002CA7 RID: 11431 RVA: 0x001BB7E4 File Offset: 0x001B99E4
		public static void OreHelper(int X, int Y)
		{
			if (!true)
			{
			}
			Tile tile;
			ushort type = tile.type;
		}

		// Token: 0x06002CA8 RID: 11432 RVA: 0x001BB800 File Offset: 0x001B9A00
		public static bool StonePatch(int X, int Y)
		{
			/*
An exception occurred when decompiling this method (06002CA8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::StonePatch(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0218:
	stloc:uint16(var_81_222, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_80)))
	stloc:int32(var_83_228, ldc.i4:int32(1))
	call:void(WorldGen::SquareTileFrame, ldc.i4:int32(0), ldc.i4:int32(0), ldloc:int32[exp:bool](var_83_228))
	stloc:float64(var_86_240, call:float64(UnifiedRandom::NextDouble, callgetter:UnifiedRandom(WorldGen::get_genRand)))
	stloc:float64(var_87_24C, call:float64(UnifiedRandom::NextDouble, callgetter:UnifiedRandom(WorldGen::get_genRand)))
	stloc:bool(var_92_258, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_91)))
	stloc:uint16(var_94_261, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_93)))
	stloc:uint16(var_96_26A, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_95)))
	stloc:uint16(var_98_273, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_97)))
	stloc:uint16(var_100_27C, callgetter:uint16(Tile::get_wall, ldloc:Tile[exp:valuetype Terraria.Tile&](var_99)))
	stloc:uint16(var_102_285, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_101)))
	stloc:uint16(var_104_28E, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_103)))
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

		// Token: 0x06002CA9 RID: 11433 RVA: 0x001BBAA0 File Offset: 0x001B9CA0
		public static bool ShellPile(int X, int Y)
		{
			/*
An exception occurred when decompiling this method (06002CA9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::ShellPile(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00E2:
	stloc:bool(var_45_FC, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_44)))
	stloc:bool(var_52_118, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_51)))
	stloc:bool(var_59_131, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_58)))
	stloc:int64(var_63_141, ldc.i4:int64(0))
	stloc:int32(var_64_144, ldc.i4:int32(1))
	call:void(WorldGen::SquareTileFrame, ldc.i4:int32(0), ldloc:int64[exp:int32](var_63_141), ldloc:int32[exp:bool](var_64_144))
	stloc:float64(var_67_15D, call:float64(UnifiedRandom::NextDouble, callgetter:UnifiedRandom(WorldGen::get_genRand)))
	stloc:float64(var_68_169, call:float64(UnifiedRandom::NextDouble, callgetter:UnifiedRandom(WorldGen::get_genRand)))
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

		// Token: 0x06002CAA RID: 11434 RVA: 0x001BBC1C File Offset: 0x001B9E1C
		public static bool MarblePileWithStatues(int X, int Y)
		{
			int num = 1;
			if (num == 0)
			{
			}
			long num2 = 0L;
			bool flag = WorldGen.SolidTile(0, X, num2 != 0L);
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
			Tile tile2;
			ushort type2 = tile2.type;
			if (num == 0)
			{
			}
			Tile tile3;
			ushort wall = tile3.wall;
			if (num == 0)
			{
			}
			int num3 = 32640;
			Tile tile4;
			bool flag2 = tile4.active();
			Tile tile5;
			ushort type3 = tile5.type;
			Tile tile6;
			ushort type4 = tile6.type;
			double num4 = WorldGen.genRand.NextDouble();
			double num5 = WorldGen.genRand.NextDouble();
			UnifiedRandom genRand = WorldGen.genRand;
			int num6 = 2;
			int num7 = 4;
			int num8 = genRand.Next(num6, num7);
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num9 = 10;
			int num10 = genRand2.Next(num9);
			if (num3 == 0)
			{
			}
			UnifiedRandom genRand3 = WorldGen.genRand;
			int num11 = 3;
			int num12 = 6;
			int num13 = genRand3.Next(num11, num12);
			UnifiedRandom genRand4 = WorldGen.genRand;
			int num14 = 70;
			int num15 = 91;
			int num16 = genRand4.Next(num14, num15);
			Vector2D vector2D;
			double num17 = vector2D.Length();
			double num18 = WorldGen.genRand.NextDouble();
			double num19 = WorldGen.genRand.NextDouble();
			Tile tile7;
			bool flag3 = tile7.active();
			int num20 = 1;
			WorldGen.SquareTileFrame(X, num16, num20 != 0);
			double num21 = WorldGen.genRand.NextDouble();
			double num22 = WorldGen.genRand.NextDouble();
			int num23 = 32768;
			if (num23 == 0)
			{
			}
			UnifiedRandom genRand5 = WorldGen.genRand;
			int num24 = 5;
			if (genRand5.Next(num24) == 0)
			{
				if (num23 == 0)
				{
				}
				Tile tile8;
				bool flag4 = tile8.active();
				while (num23 != 0)
				{
				}
				if (num23 == 0)
				{
				}
				Tile tile9;
				bool flag5 = tile9.active();
				if (num23 == 0)
				{
				}
				int num25 = 26;
				bool flag6 = WorldGen.Statue(0, X, (byte)num25);
				return;
			}
		}

		// Token: 0x06002CAB RID: 11435 RVA: 0x001BBDE4 File Offset: 0x001B9FE4
		public static bool Statue(int x, int y, byte paint)
		{
			/*
An exception occurred when decompiling this method (06002CAB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::Statue(System.Int32,System.Int32,System.Byte)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:UnifiedRandom(var_0_08, callgetter:UnifiedRandom(WorldGen::get_genRand))
	stloc:int32(var_1_0A, ldc.i4:int32(2))
	stloc:int32(var_2_13, call:int32(UnifiedRandom::Next, ldloc:UnifiedRandom(var_0_08), ldloc:int32(var_1_0A), ldloc:int32(y)))
	stloc:bool(var_4_1A, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_3)))
	call:void(Tile::color, ldloc:Tile[exp:valuetype Terraria.Tile&](var_7), ldloc:int32[exp:uint8](y))
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

		// Token: 0x06002CAC RID: 11436 RVA: 0x001BBE20 File Offset: 0x001BA020
		public static bool OrePatch(int X, int Y)
		{
			/*
An exception occurred when decompiling this method (06002CAC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::OrePatch(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_02C1:
	stloc:float64(var_89_2CB, call:float64(UnifiedRandom::NextDouble, callgetter:UnifiedRandom(WorldGen::get_genRand)))
	stloc:float64(var_90_2D7, call:float64(UnifiedRandom::NextDouble, callgetter:UnifiedRandom(WorldGen::get_genRand)))
	stloc:bool(var_95_2E3, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_94)))
	stloc:uint16(var_97_2EC, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_96)))
	stloc:uint16(var_99_2F5, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_98)))
	stloc:uint16(var_101_2FE, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_100)))
	stloc:uint16(var_103_307, callgetter:uint16(Tile::get_wall, ldloc:Tile[exp:valuetype Terraria.Tile&](var_102)))
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

		// Token: 0x06002CAD RID: 11437 RVA: 0x001BC138 File Offset: 0x001BA338
		public static bool PlaceOasis(int X, int Y)
		{
			/*
An exception occurred when decompiling this method (06002CAD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::PlaceOasis(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_01F7:
	stloc:int32(var_97_1F8, ldc.i4:int32(1))
	call:void(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_96), ldloc:int32[exp:bool](var_97_1F8))
	stloc:int32(var_98_205, ldc.i4:int32(53))
	callsetter:uint16(Tile::set_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_96), ldloc:int32[exp:uint16](var_98_205))
	stloc:int32(var_101_214, ldc.i4:int32(1))
	call:void(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_100), ldloc:int32[exp:bool](var_101_214))
	stloc:int32(var_102_221, ldc.i4:int32(53))
	callsetter:uint16(Tile::set_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_100), ldloc:int32[exp:uint16](var_102_221))
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

		// Token: 0x06002CAE RID: 11438 RVA: 0x001BC374 File Offset: 0x001BA574
		public static bool BiomeTileCheck(int x, int y)
		{
			/*
An exception occurred when decompiling this method (06002CAE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::BiomeTileCheck(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int64(var_1_06, ldc.i4:int64(0))
	stloc:bool(var_2_13, call:bool(WorldGen::InWorld, ldc.i4:int32(0), ldc.i4:int32(1073741824), ldloc:int64[exp:int32](var_1_06)))
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

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06002CAF RID: 11439 RVA: 0x001BC39C File Offset: 0x001BA59C
		public static double oceanLevel
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002CAF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Double Terraria.WorldGen::get_oceanLevel()

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
		}

		// Token: 0x06002CB0 RID: 11440 RVA: 0x001BC3AC File Offset: 0x001BA5AC
		public static bool oceanDepths(int x, int y)
		{
			int num = 1;
			if (num == 0)
			{
			}
			double oceanLevel = WorldGen.oceanLevel;
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06002CB1 RID: 11441 RVA: 0x001BC3CC File Offset: 0x001BA5CC
		public static void UpdateDesertHiveBounds(int x, int y)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x06002CB2 RID: 11442 RVA: 0x001BC3E8 File Offset: 0x001BA5E8
		public static bool ValidateTypes()
		{
			/*
An exception occurred when decompiling this method (06002CB2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::ValidateTypes()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000C:
	stloc:uint16(var_4_12, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_3)))
	call:void(Debug::LogError, ldloc:string[exp:object](var_6))
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

		// Token: 0x06002CB3 RID: 11443 RVA: 0x001BC418 File Offset: 0x001BA618
		public static void GenerateWorld(int seed, [Optional] GenerationProgress customProgressObject)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int num2 = 50212;
			if (num2 == 0)
			{
			}
			if (num2 == 0)
			{
			}
			if (num2 == 0)
			{
			}
		}

		// Token: 0x06002CB4 RID: 11444 RVA: 0x001BC518 File Offset: 0x001BA718
		private static Point GetAdjustedFloorPosition(int x, int y)
		{
			int num;
			do
			{
				num = 1;
				if (num == 0)
				{
				}
				int spawnTileY = Main.spawnTileY;
				if (num == 0)
				{
				}
				while (num == 0)
				{
				}
			}
			while (num != 0);
			return 43143168;
		}

		// Token: 0x06002CB5 RID: 11445 RVA: 0x001BC554 File Offset: 0x001BA754
		private static void Scan3By3(int topLeftX, int topLeftY, [Out] bool isEmpty, [Out] bool hasFloor)
		{
			int num = 1;
			isEmpty.m_value = num != 0;
			if (num == 0)
			{
			}
			long num2 = 0L;
			bool flag = WorldGen.SolidTile(43143168, topLeftY, num2 != 0L);
		}

		// Token: 0x06002CB6 RID: 11446 RVA: 0x001BC5A4 File Offset: 0x001BA7A4
		private static void FinishTenthAnniversaryWorld()
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
				int num2 = 2;
				int num3 = 1;
				WorldGen.ConvertSkyIslands(num2, num3 != 0);
			}
			if (num == 0)
			{
			}
			int num4 = 24;
			int num5 = 24;
			WorldGen.PaintTheDungeon((byte)num4, (byte)num5);
			int num6 = 12;
			int num7 = 12;
			WorldGen.PaintTheLivingTrees((byte)num6, (byte)num7);
			int num8 = 10;
			int num9 = 5;
			WorldGen.PaintTheTemple((byte)num8, (byte)num9);
			int num10 = 12;
			int num11 = 12;
			WorldGen.PaintTheClouds((byte)num10, (byte)num11);
			WorldGen.PaintTheSand(7, (byte)num11);
			int num12 = 12;
			int num13 = 12;
			WorldGen.PaintThePyramids((byte)num12, (byte)num13);
			if (num == 0)
			{
			}
			WorldGen.PaintTheTrees();
			WorldGen.PaintTheMushrooms();
			if (num == 0)
			{
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				UnifiedRandom genRand = WorldGen.genRand;
				int num14 = 4;
				if (genRand.Next(num14) == 0)
				{
					int num15 = 665;
					Tile tile;
					tile.type = (ushort)num15;
					int num16 = 665;
					Tile tile2;
					tile2.type = (ushort)num16;
					int num17 = 665;
					Tile tile3;
					tile3.type = (ushort)num17;
				}
				return;
			}
			WorldGen.ImproveAllChestContents();
		}

		// Token: 0x06002CB7 RID: 11447 RVA: 0x001BC698 File Offset: 0x001BA898
		private static void PaintTheMushrooms()
		{
			if (!true)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num = 1;
			int num2 = 13;
			int num3 = genRand.Next(num, num2);
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num4 = 5;
			int num5 = 31;
			int num6 = genRand2.Next(num4, num5);
			UnifiedRandom genRand3 = WorldGen.genRand;
			int num7 = 2;
			if (genRand3.Next(num7) == 0)
			{
				UnifiedRandom genRand4 = WorldGen.genRand;
				int num8 = 5;
				int num9 = 16;
				int num10 = genRand4.Next(num8, num9);
			}
			Tile tile;
			bool flag = tile.active();
		}

		// Token: 0x06002CB8 RID: 11448 RVA: 0x001BC764 File Offset: 0x001BA964
		private static void PaintTheTrees()
		{
			int num = 1;
			if (num == 0)
			{
			}
			int num2;
			long num3;
			if (num != 0)
			{
				num2 = 32768;
				num3 = 32752L;
				return;
			}
			if (num3 == 0L)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num4 = 1;
			int num5 = 13;
			int num6 = genRand.Next(num4, num5);
			if (num3 == 0L)
			{
			}
			if (num3 == 0L)
			{
			}
			if (num2 == 0)
			{
			}
			Tile tile;
			bool flag = tile.active();
		}

		// Token: 0x06002CB9 RID: 11449 RVA: 0x001BC7C0 File Offset: 0x001BA9C0
		private static void PaintTheSand(byte tilePaintColor, byte wallPaintColor)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Tile tile;
			bool flag = tile.active();
			Tile tile2;
			ushort type = tile2.type;
			Tile tile3;
			ushort type2 = tile3.type;
			Tile tile4;
			ushort type3 = tile4.type;
			Tile tile5;
			ushort type4 = tile5.type;
			Tile tile6;
			tile6.color(tilePaintColor);
			Tile tile7;
			ushort type5 = tile7.type;
			Tile tile8;
			ushort type6 = tile8.type;
			Tile tile9;
			ushort type7 = tile9.type;
			Tile tile10;
			ushort type8 = tile10.type;
			Tile tile11;
			tile11.color(tilePaintColor);
			Tile tile12;
			ushort type9 = tile12.type;
			Tile tile13;
			tile13.color(tilePaintColor);
			Tile tile14;
			ushort type10 = tile14.type;
			Tile tile15;
			tile15.color(tilePaintColor);
			ushort wall = tile15.wall;
		}

		// Token: 0x06002CBA RID: 11450 RVA: 0x001BC874 File Offset: 0x001BAA74
		private static void PaintThePurityGrass(byte tilePaintColor, byte wallPaintColor)
		{
		}

		// Token: 0x06002CBB RID: 11451 RVA: 0x001BC8C0 File Offset: 0x001BAAC0
		private static void PaintThePyramids(byte tilePaintColor, byte wallPaintColor)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Tile tile;
			bool flag = tile.active();
		}

		// Token: 0x06002CBC RID: 11452 RVA: 0x001BC8E4 File Offset: 0x001BAAE4
		private static void PaintTheTemple(byte tilePaintColor, byte wallPaintColor)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Tile tile;
			bool flag = tile.active();
		}

		// Token: 0x06002CBD RID: 11453 RVA: 0x001BC908 File Offset: 0x001BAB08
		private static void PaintTheClouds(byte tilePaintColor, byte wallPaintColor)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Tile tile;
			bool flag = tile.active();
		}

		// Token: 0x06002CBE RID: 11454 RVA: 0x001BC92C File Offset: 0x001BAB2C
		private static void PaintTheDungeon(byte tilePaintColor, byte wallPaintColor)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Tile tile;
			bool flag = tile.active();
		}

		// Token: 0x06002CBF RID: 11455 RVA: 0x001BC950 File Offset: 0x001BAB50
		private static void PaintTheLivingTrees(byte livingTreePaintColor, byte livingTreeWallPaintColor)
		{
			int num = 1;
			long num2 = 0L;
			if (num == 0)
			{
			}
			long num3 = 0L;
			if (num == 0)
			{
			}
			long num4 = 0L;
			Tile tile;
			bool flag = tile.active();
			WorldGen.GetVineTop((int)num2, (int)num3, (int)num3, (int)num4);
			Tile tile2;
			ushort type = tile2.type;
		}

		// Token: 0x06002CC0 RID: 11456 RVA: 0x001BC998 File Offset: 0x001BAB98
		private static void ConvertSkyIslands(int convertType, bool growTrees)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Tile tile;
			bool flag = tile.active();
		}

		// Token: 0x06002CC1 RID: 11457 RVA: 0x001BCA20 File Offset: 0x001BAC20
		private static void ImproveAllChestContents()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06002CC2 RID: 11458 RVA: 0x001BCA40 File Offset: 0x001BAC40
		private static void GiveItemGoodPrefixes(Item item)
		{
			bool accessory = item.accessory;
			if (!accessory || !accessory)
			{
			}
			bool melee = item.melee;
			if (!melee || !melee)
			{
			}
			bool ranged = item.ranged;
			if (!ranged || !ranged)
			{
			}
			bool magic = item.magic;
			if (!magic || !magic)
			{
			}
			bool summon = item.summon;
			if (summon)
			{
				if (!summon)
				{
				}
				return;
			}
		}

		// Token: 0x06002CC3 RID: 11459 RVA: 0x001BCA94 File Offset: 0x001BAC94
		private static void PrefixItemFromOptions(Item item, int[] options)
		{
			byte prefix = item.prefix;
			bool flag = item.Prefix(options);
			bool flag2 = item.Prefix(-1073741824);
			byte prefix2 = item.prefix;
			bool flag3 = item.Prefix((int)prefix);
		}

		// Token: 0x06002CC4 RID: 11460 RVA: 0x001BCAD0 File Offset: 0x001BACD0
		private static void NotTheBees()
		{
			if (!true)
			{
			}
			long num = 0L;
			long num2 = 0L;
			UnifiedRandom genRand = WorldGen.genRand;
			int num3 = 3;
			int num4 = genRand.Next(num3);
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num5 = 3;
			int num6 = genRand2.Next(num5);
			UnifiedRandom genRand3 = WorldGen.genRand;
			int num7 = 3;
			int num8 = genRand3.Next(num7);
			UnifiedRandom genRand4 = WorldGen.genRand;
			int num9 = 3;
			int num10 = genRand4.Next(num9);
			Tile tile;
			ushort type = tile.type;
			bool flag = WorldGen.SolidOrSlopedTile((int)num, (int)num2);
		}

		// Token: 0x06002CC5 RID: 11461 RVA: 0x001BCC2C File Offset: 0x001BAE2C
		private static void FinishNotTheBees()
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
				if (num == 0)
				{
				}
				Tile tile;
				bool flag = tile.active();
				Tile tile2;
				ushort type = tile2.type;
				return;
			}
		}

		// Token: 0x06002CC6 RID: 11462 RVA: 0x001BCF84 File Offset: 0x001BB184
		private static void FinishGetGoodWorld()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Tile tile;
			bool flag = tile.active();
			Tile tile2;
			ushort type = tile2.type;
		}

		// Token: 0x06002CC7 RID: 11463 RVA: 0x001BD254 File Offset: 0x001BB454
		private static void FinishNoTraps()
		{
			int num = 1;
			if (num == 0)
			{
			}
			int num2 = 50;
			if (num == 0)
			{
			}
			int num3 = 50;
			if (num == 0)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num4 = 5;
			if (genRand.Next(num4) == 0)
			{
				int num5 = 665;
				Tile tile;
				tile.type = (ushort)num5;
				int num6 = 665;
				tile.type = (ushort)num6;
				int num7 = 665;
				tile.type = (ushort)num7;
				int num8 = 665;
				tile.type = (ushort)num8;
			}
			Tile tile2;
			bool flag = tile2.active();
			Tile tile3;
			ushort type = tile3.type;
			Tile tile4;
			bool flag2 = tile4.wire();
			long num9 = 0L;
			Tile tile5;
			ushort type2 = tile5.type;
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num10 = 9;
			int num11 = genRand2.Next((int)num9, num10);
			UnifiedRandom genRand3 = WorldGen.genRand;
			int num12 = 9;
			int num13 = genRand3.Next((int)num9, num12);
			Tile tile6;
			ushort type3 = tile6.type;
			Tile tile7;
			ushort type4 = tile7.type;
			Tile tile8;
			ushort type5 = tile8.type;
			Tile tile9;
			ushort type6 = tile9.type;
			Tile tile10;
			ushort type7 = tile10.type;
			long num14 = 0L;
			bool flag3 = WorldGen.SolidTile(num3, num2, num14 != 0L);
			int num15 = 141;
			Tile tile11;
			tile11.type = (ushort)num15;
			long num16 = 0L;
			tile11.frameY = (short)num16;
			long num17 = 0L;
			tile11.frameX = (short)num17;
			long num18 = 0L;
			tile11.slope((byte)num18);
			long num19 = 0L;
			tile11.halfBrick(num19 != 0L);
			int num20 = 1;
			long num21 = 0L;
			WorldGen.TileFrame(0, (int)num19, num20 != 0, num21 != 0L);
			Tile tile12;
			ushort type8 = tile12.type;
		}

		// Token: 0x06002CC8 RID: 11464 RVA: 0x001BD534 File Offset: 0x001BB734
		private static void FinishDrunkGen()
		{
			int num = 1;
			if (num == 0)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num2 = 13;
			int num3 = 25;
			int num4 = genRand.Next(num2, num3);
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Tile tile;
			bool flag = tile.active();
			Tile tile2;
			ushort type = tile2.type;
			Tile tile3;
			ushort type2 = tile3.type;
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num5 = 13;
			int num6 = 15;
			int num7 = genRand2.Next(num5, num6);
			UnifiedRandom genRand3 = WorldGen.genRand;
			int num8 = 2;
			if (genRand3.Next(num8) == 0)
			{
				UnifiedRandom genRand4 = WorldGen.genRand;
				int num9 = 23;
				int num10 = 25;
				int num11 = genRand4.Next(num9, num10);
			}
			Tile tile4;
			ushort type3 = tile4.type;
			UnifiedRandom genRand5 = WorldGen.genRand;
			int num12 = 15;
			int num13 = 19;
			int num14 = genRand5.Next(num12, num13);
			Tile tile5;
			ushort type4 = tile5.type;
			UnifiedRandom genRand6 = WorldGen.genRand;
			int num15 = 19;
			int num16 = 23;
			int num17 = genRand6.Next(num15, num16);
		}

		// Token: 0x06002CC9 RID: 11465 RVA: 0x001BD720 File Offset: 0x001BB920
		private static void FinishRemixWorld()
		{
			int num = 1;
			int num2 = 25;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			long num3 = 0L;
			long num4 = 0L;
			long num5 = 0L;
			long num6 = 0L;
			WorldGen.KillTile(num2, (int)num3, num4 != 0L, num5 != 0L, num6 != 0L);
			int num7 = 1;
			Tile tile;
			tile.lava(num7 != 0);
			ushort type = tile.type;
			long num8 = 0L;
			long num9 = 0L;
			long num10 = 0L;
			long num11 = 0L;
			WorldGen.KillTile(num2, (int)num8, num9 != 0L, num10 != 0L, num11 != 0L);
			long num12 = 0L;
			long num13 = 0L;
			long num14 = 0L;
			WorldGen.TileFrame(num2, (int)num12, num13 != 0L, num14 != 0L);
			UnifiedRandom genRand = WorldGen.genRand;
			int num15 = 3;
			int num16 = genRand.Next(num15);
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num17 = 3;
			int num18 = genRand2.Next(num15, num17);
		}

		// Token: 0x06002CCA RID: 11466 RVA: 0x001BDB68 File Offset: 0x001BBD68
		public static bool IsItATrap(Tile tile)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				return;
			}
		}

		// Token: 0x06002CCB RID: 11467 RVA: 0x001BDB84 File Offset: 0x001BBD84
		public static bool IsItATrigger(Tile tile)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				return;
			}
		}

		// Token: 0x06002CCC RID: 11468 RVA: 0x001BDBA0 File Offset: 0x001BBDA0
		public static void ClearAllBrokenTraps()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Tile tile;
			bool flag = tile.wire();
		}

		// Token: 0x06002CCD RID: 11469 RVA: 0x000021DB File Offset: 0x000003DB
		public static void ClearBrokenTraps(Point startTileCoords, List<Point> pointsWeAlreadyWentOver)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002CCE RID: 11470 RVA: 0x001BDBC8 File Offset: 0x001BBDC8
		private static double TuneOceanDepth(int count, double depth, bool floridaStyle = false)
		{
			/*
An exception occurred when decompiling this method (06002CCE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Double Terraria.WorldGen::TuneOceanDepth(System.Int32,System.Double,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_0E, call:int32(UnifiedRandom::Next, callgetter:UnifiedRandom(WorldGen::get_genRand), ldc.i4:int32(10), ldc.i4:int32(20)))
	stloc:int32(var_1_1D, call:int32(UnifiedRandom::Next, callgetter:UnifiedRandom(WorldGen::get_genRand), ldc.i4:int32(10), ldc.i4:int32(20)))
	stloc:int32(var_2_2C, call:int32(UnifiedRandom::Next, callgetter:UnifiedRandom(WorldGen::get_genRand), ldc.i4:int32(10), ldc.i4:int32(20)))
	stloc:int32(var_3_3B, call:int32(UnifiedRandom::Next, callgetter:UnifiedRandom(WorldGen::get_genRand), ldc.i4:int32(10), ldc.i4:int32(20)))
	stloc:int32(var_4_4A, call:int32(UnifiedRandom::Next, callgetter:UnifiedRandom(WorldGen::get_genRand), ldc.i4:int32(10), ldc.i4:int32(20)))
	stloc:int32(var_5_5A, call:int32(UnifiedRandom::Next, callgetter:UnifiedRandom(WorldGen::get_genRand), ldc.i4:int32(10), ldc.i4:int32(20)))
	stloc:int32(var_6_6A, call:int32(UnifiedRandom::Next, callgetter:UnifiedRandom(WorldGen::get_genRand), ldc.i4:int32(10), ldc.i4:int32(20)))
	stloc:int32(var_7_7A, call:int32(UnifiedRandom::Next, callgetter:UnifiedRandom(WorldGen::get_genRand), ldc.i4:int32(10), ldc.i4:int32(20)))
	stloc:int32(var_8_8A, call:int32(UnifiedRandom::Next, callgetter:UnifiedRandom(WorldGen::get_genRand), ldc.i4:int32(10), ldc.i4:int32(20)))
	stloc:int32(var_9_9A, call:int32(UnifiedRandom::Next, callgetter:UnifiedRandom(WorldGen::get_genRand), ldc.i4:int32(10), ldc.i4:int32(20)))
	stloc:int32(var_10_AA, call:int32(UnifiedRandom::Next, callgetter:UnifiedRandom(WorldGen::get_genRand), ldc.i4:int32(10), ldc.i4:int32(20)))
	stloc:int32(var_11_BA, call:int32(UnifiedRandom::Next, callgetter:UnifiedRandom(WorldGen::get_genRand), ldc.i4:int32(10), ldc.i4:int32(20)))
	stloc:int32(var_12_CA, call:int32(UnifiedRandom::Next, callgetter:UnifiedRandom(WorldGen::get_genRand), ldc.i4:int32(10), ldc.i4:int32(20)))
	stloc:int32(var_13_DA, call:int32(UnifiedRandom::Next, callgetter:UnifiedRandom(WorldGen::get_genRand), ldc.i4:int32(10), ldc.i4:int32(20)))
	stloc:int32(var_14_EA, call:int32(UnifiedRandom::Next, callgetter:UnifiedRandom(WorldGen::get_genRand), ldc.i4:int32(10), ldc.i4:int32(20)))
	stloc:int32(var_15_FA, call:int32(UnifiedRandom::Next, callgetter:UnifiedRandom(WorldGen::get_genRand), ldc.i4:int32(10), ldc.i4:int32(20)))
	stloc:int32(var_16_10A, call:int32(UnifiedRandom::Next, callgetter:UnifiedRandom(WorldGen::get_genRand), ldc.i4:int32(10), ldc.i4:int32(20)))
	stloc:int32(var_17_11A, call:int32(UnifiedRandom::Next, callgetter:UnifiedRandom(WorldGen::get_genRand), ldc.i4:int32(10), ldc.i4:int32(20)))
	stloc:int32(var_18_12A, call:int32(UnifiedRandom::Next, callgetter:UnifiedRandom(WorldGen::get_genRand), ldc.i4:int32(10), ldc.i4:int32(20)))
	stloc:int32(var_19_13A, call:int32(UnifiedRandom::Next, callgetter:UnifiedRandom(WorldGen::get_genRand), ldc.i4:int32(10), ldc.i4:int32(20)))
	stloc:int32(var_20_14A, call:int32(UnifiedRandom::Next, callgetter:UnifiedRandom(WorldGen::get_genRand), ldc.i4:int32(10), ldc.i4:int32(20)))
	stloc:int32(var_21_15A, call:int32(UnifiedRandom::Next, callgetter:UnifiedRandom(WorldGen::get_genRand), ldc.i4:int32(10), ldc.i4:int32(20)))
	stloc:int32(var_22_16A, call:int32(UnifiedRandom::Next, callgetter:UnifiedRandom(WorldGen::get_genRand), ldc.i4:int32(10), ldc.i4:int32(20)))
	stloc:int32(var_23_17A, call:int32(UnifiedRandom::Next, callgetter:UnifiedRandom(WorldGen::get_genRand), ldc.i4:int32(10), ldc.i4:int32(20)))
	stloc:int32(var_24_18A, call:int32(UnifiedRandom::Next, callgetter:UnifiedRandom(WorldGen::get_genRand), ldc.i4:int32(10), ldc.i4:int32(20)))
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

		// Token: 0x06002CCF RID: 11471 RVA: 0x001BDD60 File Offset: 0x001BBF60
		public static void QueuePostGenAction(Action<StructureMap> action)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002CD0 RID: 11472 RVA: 0x000021DB File Offset: 0x000003DB
		public static void ConsumePostGenActions(StructureMap structures)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002CD1 RID: 11473 RVA: 0x001BDD70 File Offset: 0x001BBF70
		public static Point RandomRectanglePoint(Rectangle rectangle)
		{
			/*
An exception occurred when decompiling this method (06002CD1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Point Terraria.WorldGen::RandomRectanglePoint(Microsoft.Xna.Framework.Rectangle)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:UnifiedRandom(var_0_08, callgetter:UnifiedRandom(WorldGen::get_genRand))
	stloc:UnifiedRandom(var_2_0E, callgetter:UnifiedRandom(WorldGen::get_genRand))
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

		// Token: 0x06002CD2 RID: 11474 RVA: 0x001BDD8C File Offset: 0x001BBF8C
		public static Point RandomRectanglePoint(int x, int y, int width, int height)
		{
			/*
An exception occurred when decompiling this method (06002CD2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Point Terraria.WorldGen::RandomRectanglePoint(System.Int32,System.Int32,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_0_0F, call:int32(UnifiedRandom::Next, callgetter:UnifiedRandom(WorldGen::get_genRand), ldloc:int32(x), ldloc:int32(y)))
	stloc:int32(var_1_1C, call:int32(UnifiedRandom::Next, callgetter:UnifiedRandom(WorldGen::get_genRand), ldloc:int32(x), ldloc:int32(y)))
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

		// Token: 0x06002CD3 RID: 11475 RVA: 0x001BDDB8 File Offset: 0x001BBFB8
		public static Point RandomWorldPoint(int padding)
		{
			if (!true)
			{
			}
			Point point;
			return point;
		}

		// Token: 0x06002CD4 RID: 11476 RVA: 0x001BDDCC File Offset: 0x001BBFCC
		public static Point RandomWorldPoint(int top = 0, int right = 0, int bottom = 0, int left = 0)
		{
			/*
An exception occurred when decompiling this method (06002CD4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Point Terraria.WorldGen::RandomWorldPoint(System.Int32,System.Int32,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_0_0F, call:int32(UnifiedRandom::Next, callgetter:UnifiedRandom(WorldGen::get_genRand), ldloc:int32(bottom), ldloc:int32(right)))
	stloc:int32(var_1_1C, call:int32(UnifiedRandom::Next, callgetter:UnifiedRandom(WorldGen::get_genRand), ldloc:int32(bottom), ldloc:int32(right)))
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

		// Token: 0x06002CD5 RID: 11477 RVA: 0x001BDDF8 File Offset: 0x001BBFF8
		public static bool GrowPalmTree(int i, int y)
		{
			int num = 1;
			if (num == 0)
			{
			}
			long num2 = 0L;
			bool flag = WorldGen.InWorld(0, i, (int)num2);
			if (num == 0)
			{
			}
			Tile tile;
			ushort type = tile.type;
			if (num == 0)
			{
			}
			Tile tile2;
			return tile2.IsLoaded;
		}

		// Token: 0x06002CD6 RID: 11478 RVA: 0x001BDFB0 File Offset: 0x001BC1B0
		public static bool IsPalmOasisTree(int x)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06002CD7 RID: 11479 RVA: 0x001BDFC4 File Offset: 0x001BC1C4
		public static bool GrowEpicTree(int i, int y)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Tile tile;
			ushort type = tile.type;
			if (num == 0)
			{
			}
			Tile tile2;
			bool flag = tile2.active();
			if (num == 0)
			{
			}
			Tile tile3;
			bool flag2 = tile3.halfBrick();
			if (num == 0)
			{
			}
			Tile tile4;
			byte b = tile4.slope();
			if (num == 0)
			{
			}
			Tile tile5;
			ushort type2 = tile5.type;
			if (num == 0)
			{
			}
			Tile tile6;
			ushort wall = tile6.wall;
			if (num == 0)
			{
			}
			Tile tile7;
			byte liquid = tile7.liquid;
			if (num == 0)
			{
			}
			Tile tile8;
			bool flag3 = tile8.active();
			if (num == 0)
			{
			}
			Tile tile9;
			ushort type3 = tile9.type;
			if (num == 0)
			{
			}
			Tile tile10;
			ushort type4 = tile10.type;
			if (num == 0)
			{
			}
			Tile tile11;
			ushort type5 = tile11.type;
			if (num == 0)
			{
			}
			Tile tile12;
			ushort type6 = tile12.type;
			if (num == 0)
			{
			}
			Tile tile13;
			bool flag4 = tile13.active();
			if (num == 0)
			{
			}
			Tile tile14;
			ushort type7 = tile14.type;
			if (num == 0)
			{
			}
			Tile tile15;
			ushort type8 = tile15.type;
			if (num == 0)
			{
			}
			Tile tile16;
			ushort type9 = tile16.type;
			if (num == 0)
			{
			}
			long num2 = 0L;
			long num3 = 0L;
			Tile tile17;
			ushort type10 = tile17.type;
			if (num == 0)
			{
			}
			int num4 = 20;
			bool flag5 = WorldGen.EmptyTileCheck(0, (int)num3, 0, (int)num2, num4);
			if (num == 0)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num5 = 20;
			int num6 = 30;
			int num7 = genRand.Next(num5, num6);
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num8 = 3;
			int num9 = 7;
			int num10 = genRand2.Next(num8, num9);
			if (!false)
			{
			}
			UnifiedRandom genRand3 = WorldGen.genRand;
			int num11 = 3;
			int num12 = genRand3.Next(num11);
			UnifiedRandom genRand4 = WorldGen.genRand;
			int num13 = 3;
			int num14 = genRand4.Next(num13);
			UnifiedRandom genRand5 = WorldGen.genRand;
			int num15 = 10;
			int num16 = genRand5.Next(num15);
			if (!false)
			{
			}
			UnifiedRandom genRand6 = WorldGen.genRand;
			int num17 = 10;
			int num18 = genRand6.Next(num17);
			int num28;
			if (num14 == 0)
			{
				if (num14 != 0)
				{
					if (num14 != 0 || num14 != 0 || num14 != 0)
					{
						goto IL_0317;
					}
					if (num14 == 0)
					{
						if (num14 != 0)
						{
							goto IL_02A8;
						}
						if (num14 != 0)
						{
						}
					}
				}
				if (!false)
				{
				}
				int num19 = 1;
				Tile tile18;
				tile18.active(num19 != 0);
				int num20 = 5;
				tile18.type = (ushort)num20;
				if (!false)
				{
				}
				UnifiedRandom genRand7 = WorldGen.genRand;
				int num21 = 3;
				int num22 = genRand7.Next(num21);
				UnifiedRandom genRand8 = WorldGen.genRand;
				int num23 = 3;
				int num24 = genRand8.Next(num23);
				if (num22 == 0 || num22 != 0)
				{
				}
				IL_02A8:
				if (!false)
				{
				}
				int num25 = 1;
				Tile tile19;
				tile19.active(num25 != 0);
				int num26 = 5;
				tile19.type = (ushort)num26;
				if (!false)
				{
				}
				UnifiedRandom genRand9 = WorldGen.genRand;
				int num27 = 3;
				num28 = genRand9.Next(num27);
				UnifiedRandom genRand10 = WorldGen.genRand;
				int num29 = 3;
				int num30 = genRand10.Next(num29);
				if (num28 == 0 || num28 != 0)
				{
				}
			}
			IL_0317:
			if (!false)
			{
			}
			UnifiedRandom genRand11 = WorldGen.genRand;
			int num31 = 3;
			int num32 = genRand11.Next(num31);
			Tile tile20;
			bool flag6 = tile20.active();
			Tile tile21;
			bool flag7 = tile21.halfBrick();
			Tile tile22;
			byte b2 = tile22.slope();
			long num33 = 0L;
			Tile tile23;
			bool flag8 = tile23.active();
			Tile tile24;
			bool flag9 = tile24.halfBrick();
			Tile tile25;
			byte b3 = tile25.slope();
			long num34 = 0L;
			int num35 = 2;
			if (num28 != 0)
			{
				if (num34 == 0L)
				{
				}
				int num36 = 1;
				Tile tile26;
				tile26.active(num36 != 0);
				int num37 = 5;
				tile26.type = (ushort)num37;
				if (num34 == 0L)
				{
				}
				UnifiedRandom genRand12 = WorldGen.genRand;
				int num38 = 3;
				if (genRand12.Next(num38) == 0)
				{
				}
			}
			if (num34 == 0L)
			{
			}
			int num39 = 1;
			Tile tile27;
			tile27.active(num39 != 0);
			int num40 = 5;
			tile27.type = (ushort)num40;
			if (num34 == 0L)
			{
			}
			UnifiedRandom genRand13 = WorldGen.genRand;
			int num41 = 3;
			if (genRand13.Next(num41) == 0)
			{
			}
			if (num34 == 0L)
			{
			}
			UnifiedRandom genRand14 = WorldGen.genRand;
			int num42 = 3;
			int num43 = genRand14.Next(num42);
			if (num33 != 0L)
			{
				if (num34 == 0L)
				{
				}
				if (num43 != 0)
				{
					goto IL_051F;
				}
				long num44 = 0L;
				Tile tile28;
				tile28.frameX = (short)num44;
			}
			if (num34 == 0L)
			{
			}
			int num47;
			if (num43 == 0)
			{
				int num45 = 88;
				Tile tile29;
				tile29.frameX = (short)num45;
				if (num34 == 0L)
				{
				}
				if (num43 == 0)
				{
					int num46 = 66;
					Tile tile30;
					tile30.frameX = (short)num46;
					if (num34 == 0L)
					{
					}
					Tile tile31;
					ushort type11 = tile31.type;
					if (num34 == 0L)
					{
					}
					Tile tile32;
					ushort type12 = tile32.type;
					if (num34 == 0L)
					{
					}
					Tile tile33;
					ushort type13 = tile33.type;
					if (num34 == 0L)
					{
					}
					Tile tile34;
					ushort type14 = tile34.type;
					if (num34 == 0L)
					{
					}
					Tile tile35;
					ushort type15 = tile35.type;
					if (num34 == 0L)
					{
					}
					Tile tile36;
					ushort type16 = tile36.type;
					if (num34 == 0L)
					{
					}
					Tile tile37;
					ushort type17 = tile37.type;
					if (num34 == 0L)
					{
					}
					Tile tile38;
					ushort type18 = tile38.type;
					num47 = 1;
				}
			}
			IL_051F:
			if (num47 == 0)
			{
			}
			UnifiedRandom genRand15 = WorldGen.genRand;
			int num48 = 13;
			int num49 = genRand15.Next(num48);
			if (num35 == 0)
			{
			}
			if (num49 != 0)
			{
				if (num35 == 0)
				{
				}
				UnifiedRandom genRand16 = WorldGen.genRand;
				int num50 = 3;
				if (genRand16.Next(num50) != 0)
				{
					goto IL_0595;
				}
			}
			if (num35 == 0)
			{
			}
			UnifiedRandom genRand17 = WorldGen.genRand;
			int num51 = 3;
			int num52;
			long num53;
			if (genRand17.Next(num51) == 0)
			{
				num52 = 220;
				num53 = 0L;
			}
			IL_0595:
			if (!false)
			{
			}
			WorldGen.RangeFrame(0, num52, (int)num53, 0);
			if (!false)
			{
			}
			bool netHost = Main.NetHost;
			if (!false)
			{
				return;
			}
		}

		// Token: 0x06002CD8 RID: 11480 RVA: 0x001BE588 File Offset: 0x001BC788
		public static bool Pyramid(int i, int j)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Tile tile;
			ushort type = tile.type;
			if (num == 0)
			{
			}
			Tile tile2;
			ushort wall = tile2.wall;
			if (num == 0)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num2 = 7;
			long num3 = 0L;
			int num4 = genRand.Next((int)num3, num2);
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num5 = 9;
			int num6 = 13;
			int num7 = genRand2.Next(num5, num6);
			UnifiedRandom genRand3 = WorldGen.genRand;
			int num8 = 75;
			int num9 = 125;
			int num10 = genRand3.Next(num8, num9);
			if (num == 0)
			{
			}
			int num11 = 151;
			Tile tile3;
			tile3.type = (ushort)num11;
			int num12 = 1;
			tile3.active(num12 != 0);
			long num13 = 0L;
			tile3.halfBrick(num13 != 0L);
			long num14 = 0L;
			tile3.slope((byte)num14);
			if (num == 0)
			{
			}
			Tile tile4;
			ushort type2 = tile4.type;
			if (num == 0)
			{
			}
			int num15 = 34;
			Tile tile5;
			tile5.wall = (ushort)num15;
			if (num == 0)
			{
			}
			int num16 = 1;
			WorldGen.SquareWallFrame(43143168, num4, num16 != 0);
			if (num == 0)
			{
			}
			UnifiedRandom genRand4 = WorldGen.genRand;
			int num17 = 2;
			int num18 = genRand4.Next(num17);
			if (num18 == 0)
			{
			}
			UnifiedRandom genRand5 = WorldGen.genRand;
			int num19 = 5;
			int num20 = 8;
			int num21 = genRand5.Next(num19, num20);
			UnifiedRandom genRand6 = WorldGen.genRand;
			int num22 = 20;
			int num23 = 30;
			int num24 = genRand6.Next(num22, num23);
			if (num18 == 0)
			{
			}
			Tile tile6;
			ushort type3 = tile6.type;
			Tile tile7;
			ushort type4 = tile7.type;
			int num25 = 34;
			Tile tile8;
			tile8.wall = (ushort)num25;
			int num26 = 34;
			Tile tile9;
			tile9.wall = (ushort)num26;
			long num27 = 0L;
			tile9.active(num27 != 0L);
			int num28 = 53;
			tile9.type = (ushort)num28;
			int num29 = 1;
			tile9.active(num29 != 0);
			long num30 = 0L;
			tile9.halfBrick(num30 != 0L);
			long num31 = 0L;
			tile9.slope((byte)num31);
			if (!true)
			{
			}
			long num32 = 0L;
			Tile tile10;
			tile10.active(num32 != 0L);
			long num33 = 0L;
			int num39;
			if (num33 != 0L)
			{
				if (num33 == 0L)
				{
				}
				UnifiedRandom genRand7 = WorldGen.genRand;
				if (num33 == 0L)
				{
				}
				UnifiedRandom genRand8 = WorldGen.genRand;
				int num34 = 7;
				int num35 = 13;
				int num36 = genRand8.Next(num34, num35);
				UnifiedRandom genRand9 = WorldGen.genRand;
				int num37 = 23;
				int num38 = 28;
				num39 = genRand9.Next(num37, num38);
				if (num33 == 0L)
				{
				}
				long num40 = 0L;
				Tile tile11;
				tile11.active(num40 != 0L);
			}
			if (num33 == 0L)
			{
			}
			UnifiedRandom genRand10 = WorldGen.genRand;
			if (num33 == 0L)
			{
			}
			UnifiedRandom genRand11 = WorldGen.genRand;
			int num41 = 3;
			if (genRand11.Next(num41) == 0)
			{
				if (num33 == 0L)
				{
				}
				UnifiedRandom genRand12 = WorldGen.genRand;
				int num42 = 3;
				int num43 = genRand12.Next(num42);
			}
			if (num33 == 0L)
			{
			}
			int num44 = 1;
			long num45 = 0L;
			long num46 = 0L;
			long num47 = 0L;
			bool flag = WorldGen.AddBuriedChest(0, 43143168, 0, num45 != 0L, num44, num46 != 0L, (ushort)num47);
			UnifiedRandom genRand13 = WorldGen.genRand;
			int num48 = 1;
			int num49 = 10;
			int num50 = genRand13.Next(num48, num49);
			if (!false)
			{
			}
			int num51 = WorldGen.genRand.Next(num48, num39);
			UnifiedRandom genRand14 = WorldGen.genRand;
			int num52 = 16;
			int num53 = 19;
			int num54 = genRand14.Next(num52, num53);
			int num55 = 1;
			int num56 = 185;
			return WorldGen.PlaceSmallPile(num51, 0, num54, num55, (ushort)num56);
		}

		// Token: 0x06002CD9 RID: 11481 RVA: 0x001BEAD4 File Offset: 0x001BCCD4
		public static bool GrowLivingTree(int i, int j, bool patch = false)
		{
			UnifiedRandom genRand26;
			int num89;
			do
			{
				int num = 2000;
				long num2 = 0L;
				bool flag = WorldGen.SolidTile(0, num, num2 != 0L);
				if (!flag)
				{
				}
				Tile tile;
				bool flag2 = tile.active();
				if (!flag)
				{
				}
				Tile tile2;
				ushort type = tile2.type;
				if (!flag)
				{
				}
				Tile tile3;
				ushort type2 = tile3.type;
				if (!flag)
				{
				}
				Tile tile4;
				ushort type3 = tile4.type;
				if (!flag)
				{
				}
				Tile tile5;
				ushort type4 = tile5.type;
				if (!flag)
				{
				}
				Tile tile6;
				ushort type5 = tile6.type;
				UnifiedRandom genRand = WorldGen.genRand;
				int num3 = 2;
				int num4 = 3;
				int num5 = genRand.Next(num3, num4);
				UnifiedRandom genRand2 = WorldGen.genRand;
				int num6 = 2;
				int num7 = 3;
				int num8 = genRand2.Next(num6, num7);
				UnifiedRandom genRand3 = WorldGen.genRand;
				int num9 = 5;
				if (genRand3.Next(num9) == 0)
				{
					UnifiedRandom genRand4 = WorldGen.genRand;
					int num10 = 2;
					if (genRand4.Next(num10) != 0)
					{
					}
				}
				UnifiedRandom genRand5 = WorldGen.genRand;
				int num11 = 1;
				int num12 = 3;
				int num13 = genRand5.Next(num11, num12);
				UnifiedRandom genRand6 = WorldGen.genRand;
				int num14 = 1;
				int num15 = 3;
				int num16 = genRand6.Next(num14, num15);
				int num17 = WorldGen.genRand.Next(num14, num15);
				UnifiedRandom genRand7 = WorldGen.genRand;
				int num18 = 2;
				int num19 = genRand7.Next(num18);
				UnifiedRandom genRand8 = WorldGen.genRand;
				int num20 = 5;
				int num21 = 15;
				int num22 = genRand8.Next(num20, num21);
				UnifiedRandom genRand9 = WorldGen.genRand;
				int num23 = 5;
				int num24 = 15;
				int num25 = genRand9.Next(num23, num24);
				UnifiedRandom genRand10 = WorldGen.genRand;
				int num26 = 5;
				int num27 = genRand10.Next(num26);
				UnifiedRandom genRand11 = WorldGen.genRand;
				int num28 = 5;
				int num29 = genRand11.Next(num28);
				UnifiedRandom genRand12 = WorldGen.genRand;
				int num30 = 2;
				int num31 = genRand12.Next(num30);
				UnifiedRandom genRand13 = WorldGen.genRand;
				int num32 = 2;
				int num33 = genRand13.Next(num32);
				int num34 = 191;
				Tile tile7;
				tile7.type = (ushort)num34;
				int num35 = 1;
				tile7.active(num35 != 0);
				long num36 = 0L;
				tile7.halfBrick(num36 != 0L);
				if (!false)
				{
				}
				UnifiedRandom genRand14 = WorldGen.genRand;
				int num37 = 20;
				int num38 = 30;
				int num39 = genRand14.Next(num37, num38);
				if (num39 == 0)
				{
				}
				int num40 = 191;
				Tile tile8;
				tile8.type = (ushort)num40;
				int num41 = 1;
				tile8.active(num41 != 0);
				long num42 = 0L;
				tile8.halfBrick(num42 != 0L);
				UnifiedRandom genRand15 = WorldGen.genRand;
				int num43 = 3;
				int num44 = 5;
				int num45 = genRand15.Next(num43, num44);
				if (num39 == 0)
				{
				}
				int num46 = 191;
				Tile tile9;
				tile9.type = (ushort)num46;
				int num47 = 1;
				tile9.active(num47 != 0);
				long num48 = 0L;
				tile9.halfBrick(num48 != 0L);
				if (num39 == 0)
				{
				}
				UnifiedRandom genRand16 = WorldGen.genRand;
				int num49 = 10;
				if (genRand16.Next(num49) != 0)
				{
				}
				if (-1073741824 == 0)
				{
				}
				UnifiedRandom genRand17 = WorldGen.genRand;
				int num50 = 2;
				if (genRand17.Next(num50) != 0)
				{
				}
				if (-1073741824 == 0)
				{
				}
				UnifiedRandom genRand18 = WorldGen.genRand;
				int num51 = 2;
				int num54;
				if (genRand18.Next(num51) == 0)
				{
					if (-1073741824 == 0)
					{
					}
					UnifiedRandom genRand19 = WorldGen.genRand;
					int num52 = 2;
					int num53 = 5;
					num54 = genRand19.Next(num52, num53);
					UnifiedRandom genRand20 = WorldGen.genRand;
					int num55 = 2;
					int num56 = genRand20.Next(num55);
					int num57 = 191;
					Tile tile10;
					tile10.type = (ushort)num57;
					int num58 = 1;
					tile10.active(num58 != 0);
					long num59 = 0L;
					tile10.halfBrick(num59 != 0L);
					if (num56 != 0)
					{
					}
					int num60 = 191;
					Tile tile11;
					tile11.type = (ushort)num60;
					int num61 = 1;
					tile11.active(num61 != 0);
					long num62 = 0L;
					tile11.halfBrick(num62 != 0L);
				}
				Tile tile12;
				bool flag3 = tile12.active();
				long num63 = 0L;
				Tile tile13;
				ushort type6 = tile13.type;
				long num64 = 0L;
				int num65 = WorldGen.genRand.Next((int)num63, num54);
				long num66 = 0L;
				long num67 = 0L;
				int num68 = 191;
				Tile tile14;
				tile14.type = (ushort)num68;
				int num69 = 1;
				tile14.active(num69 != 0);
				long num70 = 0L;
				tile14.halfBrick(num70 != 0L);
				if (num64 == 0L)
				{
					goto IL_057F;
				}
				if (num66 == 0L)
				{
				}
				if (num67 != 0L)
				{
					goto IL_057F;
				}
				UnifiedRandom genRand21 = WorldGen.genRand;
				int num71 = 2;
				long num72 = 0L;
				if (genRand21.Next(num71) != 0)
				{
					goto IL_057F;
				}
				int num73 = WorldGen.genRand.Next(num71, (int)num72);
				UnifiedRandom genRand22 = WorldGen.genRand;
				int num74 = 3;
				int num75 = 5;
				int num76 = genRand22.Next(num74, num75);
				UnifiedRandom genRand23 = WorldGen.genRand;
				int num77 = 3;
				int num78 = 5;
				int num79 = genRand23.Next(num77, num78);
				if (!false)
				{
				}
				int num80 = 191;
				Tile tile15;
				tile15.type = (ushort)num80;
				int num81 = 1;
				tile15.active(num81 != 0);
				long num82 = 0L;
				tile15.halfBrick(num82 != 0L);
				if (!false)
				{
				}
				if (!false)
				{
				}
				UnifiedRandom genRand24 = WorldGen.genRand;
				int num83 = 5;
				if (genRand24.Next(num83) == 0)
				{
					if (!false)
					{
					}
					UnifiedRandom genRand25 = WorldGen.genRand;
					int num84 = 2;
					int num85 = genRand25.Next(num84);
					int num86 = 191;
					Tile tile16;
					tile16.type = (ushort)num86;
					int num87 = 1;
					tile16.active(num87 != 0);
					long num88 = 0L;
					tile16.halfBrick(num88 != 0L);
				}
				genRand26 = WorldGen.genRand;
				num89 = 3;
			}
			while (genRand26.Next(num89) != 0);
			UnifiedRandom genRand27 = WorldGen.genRand;
			int num90 = 2;
			int num91 = 4;
			int num92 = genRand27.Next(num90, num91);
			UnifiedRandom genRand28 = WorldGen.genRand;
			int num93 = 2;
			int num94 = genRand28.Next(num93);
			int num95 = 191;
			Tile tile17;
			tile17.type = (ushort)num95;
			int num96 = 1;
			tile17.active(num96 != 0);
			long num97 = 0L;
			tile17.halfBrick(num97 != 0L);
			if (!true)
			{
			}
			UnifiedRandom genRand29 = WorldGen.genRand;
			int num98 = 6;
			int num99 = genRand29.Next((int)num97, num98);
			UnifiedRandom genRand30 = WorldGen.genRand;
			int num100 = 6;
			int num101 = genRand30.Next((int)num97, num100);
			int num102 = 1;
			int num103 = 1;
			IL_057F:
			if (num103 == 0)
			{
			}
			UnifiedRandom genRand31 = WorldGen.genRand;
			int num104 = 4;
			if (genRand31.Next(num104) == 0)
			{
				if (num103 == 0)
				{
				}
				UnifiedRandom genRand32 = WorldGen.genRand;
				int num105 = 2;
				int num106 = genRand32.Next(num105);
				int num107 = 191;
				Tile tile18;
				tile18.type = (ushort)num107;
				int num108 = 1;
				tile18.active(num108 != 0);
				long num109 = 0L;
				tile18.halfBrick(num109 != 0L);
			}
			long num110 = 32752L;
			UnifiedRandom genRand33 = WorldGen.genRand;
			int num111 = 1;
			int num112 = 6;
			int num113 = genRand33.Next(num111, num112);
			long num114 = 0L;
			bool flag4 = WorldGen.SolidTile(num102, 0, num114 != 0L);
			if (num110 == 0L)
			{
			}
			int num115 = 191;
			Tile tile19;
			tile19.type = (ushort)num115;
			int num116 = 1;
			tile19.active(num116 != 0);
			long num117 = 0L;
			long num118 = 0L;
			tile19.halfBrick(num117 != 0L);
			UnifiedRandom genRand34 = WorldGen.genRand;
			int num119 = 2;
			int num120 = genRand34.Next(num119, (int)num118);
			int num121 = WorldGen.genRand.Next(num119, (int)num118);
			Tile tile20;
			ushort wall = tile20.wall;
			Tile tile21;
			ushort wall2 = tile21.wall;
			Tile tile22;
			bool flag5 = tile22.active();
			if (num110 == 0L)
			{
			}
			UnifiedRandom genRand35 = WorldGen.genRand;
			int num122 = 3;
			int num123;
			if (genRand35.Next(num122) != 0)
			{
				if (!flag5)
				{
				}
				UnifiedRandom genRand36 = WorldGen.genRand;
				num123 = 3;
				int num124 = genRand36.Next(num123);
			}
			if (num103 != 0)
			{
			}
			if (!flag5)
			{
			}
			UnifiedRandom genRand37 = WorldGen.genRand;
			int num125 = 2;
			int num126 = genRand37.Next(num123, num125);
			UnifiedRandom genRand38 = WorldGen.genRand;
			int num127 = 5;
			int num128 = 8;
			int num129 = genRand38.Next(num127, num128);
			UnifiedRandom genRand39 = WorldGen.genRand;
			int num130 = 6;
			int num131 = 12;
			int num132 = genRand39.Next(num130, num131);
			UnifiedRandom genRand40 = WorldGen.genRand;
			int num133 = 5;
			int num134 = genRand40.Next(num133);
			if (!false)
			{
			}
			Tile tile23;
			ushort type7 = tile23.type;
			if (false)
			{
				Vector2D vector2D;
				double num135 = vector2D.Length();
			}
			UnifiedRandom genRand41 = WorldGen.genRand;
			int num136 = 30;
			if (genRand41.Next(num136) == 0)
			{
				Tile tile24;
				bool flag6 = tile24.active();
				Tile tile25;
				bool flag7 = tile25.active();
				Tile tile26;
				ushort type8 = tile26.type;
				UnifiedRandom genRand42 = WorldGen.genRand;
				int num137 = 50;
				int num138 = 52;
				int num139 = genRand42.Next(num137, num138);
			}
			UnifiedRandom genRand43 = WorldGen.genRand;
			int num140 = 15;
			if (genRand43.Next(num140) == 0)
			{
				Tile tile27;
				bool flag8 = tile27.active();
				Tile tile28;
				bool flag9 = tile28.active();
				Tile tile29;
				ushort type9 = tile29.type;
				UnifiedRandom genRand44 = WorldGen.genRand;
				int num141 = 2;
				int num142 = genRand44.Next(num141);
				UnifiedRandom genRand45 = WorldGen.genRand;
				if (num142 != 0)
				{
					int num143 = 2;
					int num144 = genRand45.Next(num143);
					if (!false)
					{
					}
					UnifiedRandom genRand46 = WorldGen.genRand;
					int num145 = 59;
					int num146 = 62;
					int num147 = genRand46.Next(num145, num146);
				}
				bool flag10;
				return flag10;
			}
			return false;
		}

		// Token: 0x06002CDA RID: 11482 RVA: 0x001BF440 File Offset: 0x001BD640
		public static bool GrowDungeonTree(int i, int j, bool patch = false)
		{
			/*
An exception occurred when decompiling this method (06002CDA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::GrowDungeonTree(System.Int32,System.Int32,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_07F6:
	stloc:int64(var_243_7F7, ldc.i4:int64(0))
	call:void(WorldGen::GrowDungeonTree_MakePassage, ldc.i4:int32(0), ldloc:int32(var_241), ldloc:int64[exp:int32](var_242), ldloc:int64[exp:int32](var_236), ldloc:int64[exp:bool](var_243_7F7))
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

		// Token: 0x06002CDB RID: 11483 RVA: 0x001BFC58 File Offset: 0x001BDE58
		private static bool GrowLivingTree_HorizontalTunnel(int i, int j)
		{
			int num = 1;
			if (num == 0)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num2 = 2;
			int num3 = genRand.Next(num2);
			long num4 = 0L;
			if (num == 0)
			{
			}
			int num5 = 10;
			bool flag = WorldGen.InWorld(0, i, num5);
			if (num4 == 0L)
			{
			}
			if (num4 == 0L)
			{
			}
			Tile tile;
			ushort wall = tile.wall;
			if (num4 == 0L)
			{
			}
			Tile tile2;
			ushort type = tile2.type;
			Tile tile3;
			ushort type2 = tile3.type;
			Tile tile4;
			return tile4.active();
		}

		// Token: 0x06002CDC RID: 11484 RVA: 0x001BFF28 File Offset: 0x001BE128
		private static void GrowDungeonTree_MakePassage(int j, int W, int minl, int minr, bool noSecretRoom = false)
		{
			UnifiedRandom genRand = WorldGen.genRand;
			int num = 5;
			int num2 = 16;
			int num3 = genRand.Next(num, num2);
			if (!true)
			{
			}
			Tile tile;
			ushort type = tile.type;
			Tile tile2;
			ushort type2 = tile2.type;
			Tile tile3;
			ushort type3 = tile3.type;
			Tile tile4;
			ushort type4 = tile4.type;
			Tile tile5;
			ushort type5 = tile5.type;
			Tile tile6;
			ushort type6 = tile6.type;
			Tile tile7;
			ushort type7 = tile7.type;
			Tile tile8;
			ushort type8 = tile8.type;
			Tile tile9;
			ushort type9 = tile9.type;
			Tile tile10;
			ushort type10 = tile10.type;
			long num4 = 0L;
			Tile tile11;
			tile11.active(num4 != 0L);
			Tile tile12;
			ushort wall = tile12.wall;
			int num5 = 244;
			Tile tile13;
			tile13.wall = (ushort)num5;
			Tile tile14;
			ushort wall2 = tile14.wall;
			Tile tile15;
			ushort wall3 = tile15.wall;
			int num6 = 244;
			Tile tile16;
			tile16.wall = (ushort)num6;
			Tile tile17;
			ushort wall4 = tile17.wall;
			Tile tile18;
			ushort wall5 = tile18.wall;
			int num7 = 244;
			Tile tile19;
			tile19.wall = (ushort)num7;
			long num8 = 0L;
			Tile tile20;
			tile20.active(num8 != 0L);
		}

		// Token: 0x06002CDD RID: 11485 RVA: 0x001C0234 File Offset: 0x001BE434
		private static void GrowLivingTree_MakePassage(int j, int W, int minl, int minr, bool noSecretRoom = false)
		{
			UnifiedRandom genRand = WorldGen.genRand;
			int num = 400;
			int num2 = 700;
			int num3 = genRand.Next(num, num2);
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num4 = 5;
			int num5 = 16;
			int num6 = genRand2.Next(num4, num5);
			Tile tile;
			bool flag = tile.active();
			Tile tile2;
			ushort wall = tile2.wall;
			Tile tile3;
			bool flag2 = tile3.active();
			Tile tile4;
			ushort wall2 = tile4.wall;
			Tile tile5;
			ushort wall3 = tile5.wall;
			Tile tile6;
			ushort type = tile6.type;
			Tile tile7;
			ushort type2 = tile7.type;
			Tile tile8;
			ushort type3 = tile8.type;
			Tile tile9;
			ushort type4 = tile9.type;
			Tile tile10;
			ushort type5 = tile10.type;
			Tile tile11;
			ushort type6 = tile11.type;
			Tile tile12;
			ushort type7 = tile12.type;
			Tile tile13;
			ushort type8 = tile13.type;
			Tile tile14;
			ushort type9 = tile14.type;
			Tile tile15;
			ushort type10 = tile15.type;
			long num7 = 0L;
			Tile tile16;
			tile16.active(num7 != 0L);
			Tile tile17;
			ushort wall4 = tile17.wall;
			int num8 = 244;
			Tile tile18;
			tile18.wall = (ushort)num8;
			Tile tile19;
			ushort wall5 = tile19.wall;
			Tile tile20;
			ushort wall6 = tile20.wall;
			int num9 = 244;
			Tile tile21;
			tile21.wall = (ushort)num9;
			Tile tile22;
			ushort wall7 = tile22.wall;
			Tile tile23;
			ushort wall8 = tile23.wall;
			int num10 = 244;
			Tile tile24;
			tile24.wall = (ushort)num10;
			long num11 = 0L;
			Tile tile25;
			tile25.active(num11 != 0L);
		}

		// Token: 0x06002CDE RID: 11486 RVA: 0x001C0578 File Offset: 0x001BE778
		private static void GrowLivingTreePassageRoom(int minl, int minr, int Y)
		{
			if (!true)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num = 2;
			int num2 = genRand.Next(num);
			int num3 = 1;
			if (num2 == 0)
			{
			}
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num4 = 15;
			int num5 = 30;
			int num6 = genRand2.Next(num4, num5);
			if (num2 == 0)
			{
			}
			Tile tile;
			ushort wall = tile.wall;
			if (num2 == 0)
			{
			}
			Tile tile2;
			bool flag = tile2.active();
			if (num2 == 0)
			{
			}
			if (num3 == 0)
			{
			}
			if (num3 == 0)
			{
			}
		}

		// Token: 0x06002CDF RID: 11487 RVA: 0x001C08D0 File Offset: 0x001BEAD0
		public static void TreeGrowFXCheck(int x, int y)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int num2 = 1;
			if (num == 0)
			{
			}
			Tile tile;
			bool flag = tile.active();
			if (num == 0)
			{
			}
			if (num != 0)
			{
			}
			if (num == 0)
			{
			}
			Tile tile2;
			bool flag2 = tile2.active();
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
			}
			bool netHost = Main.NetHost;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			bool logicHost = Main.LogicHost;
			if (num == 0)
			{
			}
			long num3 = 0L;
			WorldGen.TreeGrowFX(x, y, num2, 0, num3 != 0L);
		}

		// Token: 0x06002CE0 RID: 11488 RVA: 0x001C0940 File Offset: 0x001BEB40
		public static void GetTreeLeaf(int x, Tile topTile, Tile t, int treeHeight, [Out] int treeFrame, [Out] int passStyle)
		{
			int num = 1;
			passStyle.m_value = num;
		}

		// Token: 0x06002CE1 RID: 11489 RVA: 0x001C09F4 File Offset: 0x001BEBF4
		public static void TreeGrowFX(int x, int y, int height, int treeGore, bool hitTree = false)
		{
			if (!true)
			{
			}
			WorldGen.TreeGrowFX_AshShake(x, y, height, treeGore != 0);
		}

		// Token: 0x06002CE2 RID: 11490 RVA: 0x001C0A44 File Offset: 0x001BEC44
		private static void TreeGrowFX_AshShake(int x, int y, int height, bool hitTree = false)
		{
			if (!true)
			{
			}
			int num = 5;
			int num2 = 10;
			if (num == 0)
			{
			}
			int num3;
			if (num3 != 0)
			{
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				if (num2 == 0)
				{
				}
			}
			int num4;
			int num6;
			if (num4 != 0)
			{
				if (num2 == 0)
				{
				}
				Dust dust;
				float x2 = dust.velocity.X;
				float y2 = dust.velocity.Y;
				int num5;
				if (num5 == 0)
				{
					num6 = 1;
					dust.noGravity = num6 != 0;
				}
				if (num6 == 0)
				{
				}
			}
			if (num6 == 0)
			{
			}
			if (num6 == 0)
			{
			}
			if (num2 == 0)
			{
			}
			if (!true)
			{
			}
			Gore gore;
			float x3 = gore.velocity.X;
			float y3 = gore.velocity.Y;
			gore.velocity.X = x3;
			gore.velocity.Y = y3;
		}

		// Token: 0x06002CE3 RID: 11491 RVA: 0x001C0B38 File Offset: 0x001BED38
		public static bool IsTileALeafyTreeTop(int i, int j)
		{
			int num = 1;
			bool flag = Framing.GetTileSafely(0, i).active();
			if (num == 0)
			{
			}
			if (num != 0)
			{
				return;
			}
		}

		// Token: 0x06002CE4 RID: 11492 RVA: 0x001C0B60 File Offset: 0x001BED60
		public static bool IsTileTypeFitForTree(ushort type)
		{
		}

		// Token: 0x06002CE5 RID: 11493 RVA: 0x001C0B80 File Offset: 0x001BED80
		public static bool GrowTree(int i, int y)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Tile tile;
			ushort type = tile.type;
			if (num == 0)
			{
			}
			Tile tile2;
			byte liquid = tile2.liquid;
			if (num == 0)
			{
			}
			Tile tile3;
			byte liquid2 = tile3.liquid;
			if (num == 0)
			{
			}
			Tile tile4;
			byte liquid3 = tile4.liquid;
			if (num == 0)
			{
			}
			int num7;
			int num8;
			if (num != 0)
			{
				if (num == 0)
				{
				}
				Tile tile5;
				bool flag = tile5.nactive();
				if (num == 0)
				{
				}
				Tile tile6;
				bool flag2 = tile6.halfBrick();
				if (num == 0)
				{
				}
				Tile tile7;
				byte b = tile7.slope();
				if (num == 0)
				{
				}
				Tile tile8;
				bool flag3 = WorldGen.IsTileTypeFitForTree(tile8.type);
				Tile tile9;
				ushort wall = tile9.wall;
				Tile tile10;
				ushort wall2 = tile10.wall;
				bool flag4 = WorldGen.DefaultTreeWallTest(0);
				if (!false)
				{
				}
				Tile tile11;
				bool flag5 = tile11.active();
				if (!false)
				{
				}
				Tile tile12;
				bool flag6 = WorldGen.IsTileTypeFitForTree(tile12.type);
				if (!false)
				{
				}
				Tile tile13;
				bool flag7 = tile13.active();
				if (!false)
				{
				}
				Tile tile14;
				bool flag8 = WorldGen.IsTileTypeFitForTree(tile14.type);
				if (!false)
				{
				}
				Tile tile15;
				TileColorCache tileColorCache = tile15.BlockColorAndCoating();
				if (i == 0)
				{
					if (tileColorCache == null)
					{
					}
					UnifiedRandom genRand = WorldGen.genRand;
					int num2 = 1;
					int num3 = 13;
					int num4 = genRand.Next(num2, num3);
				}
				if (tileColorCache == null)
				{
				}
				UnifiedRandom genRand2 = WorldGen.genRand;
				int num5 = 5;
				int num6 = 17;
				num7 = genRand2.Next(num5, num6);
				Tile tile16;
				ushort type2 = tile16.type;
				num8 = 4;
				long num9 = 0L;
				Tile tile17;
				ushort type3 = tile17.type;
				if (num8 == 0)
				{
				}
				int num10 = 20;
				bool flag9 = WorldGen.EmptyTileCheck(0, (int)num9, num6, 0, num10);
				if (num8 == 0)
				{
				}
				int num11 = 20;
				return WorldGen.EmptyTileCheck(0, (int)num9, num6, 0, num11);
			}
			if (num8 == 0)
			{
			}
			UnifiedRandom genRand3 = WorldGen.genRand;
			int num12 = 3;
			int num13 = genRand3.Next(num12);
			UnifiedRandom genRand4 = WorldGen.genRand;
			int num14 = 3;
			int num15 = genRand4.Next(num14);
			UnifiedRandom genRand5 = WorldGen.genRand;
			int num16 = 10;
			int num17 = genRand5.Next(num16);
			if (!false)
			{
			}
			UnifiedRandom genRand6 = WorldGen.genRand;
			int num18 = 10;
			int num19 = genRand6.Next(num18);
			if (num15 == 0)
			{
				if (num15 != 0)
				{
					if (num15 != 0 || num15 != 0 || num15 != 0)
					{
						goto IL_0360;
					}
					if (num15 == 0)
					{
						if (num15 != 0)
						{
							goto IL_02F1;
						}
						if (num15 != 0)
						{
						}
					}
				}
				if (!false)
				{
				}
				int num20 = 1;
				Tile tile18;
				tile18.active(num20 != 0);
				int num21 = 5;
				tile18.type = (ushort)num21;
				if (!false)
				{
				}
				UnifiedRandom genRand7 = WorldGen.genRand;
				int num22 = 3;
				int num23 = genRand7.Next(num22);
				UnifiedRandom genRand8 = WorldGen.genRand;
				int num24 = 3;
				int num25 = genRand8.Next(num24);
				if ((!false && num23 != 0) || num23 == 0)
				{
				}
				IL_02F1:
				if (!false)
				{
				}
				int num26 = 1;
				Tile tile19;
				tile19.active(num26 != 0);
				int num27 = 5;
				tile19.type = (ushort)num27;
				if (!false)
				{
				}
				UnifiedRandom genRand9 = WorldGen.genRand;
				int num28 = 3;
				int num29 = genRand9.Next(num28);
				UnifiedRandom genRand10 = WorldGen.genRand;
				int num30 = 3;
				int num31 = genRand10.Next(num30);
				if ((!false && num29 != 0) || num29 == 0)
				{
				}
			}
			IL_0360:
			if (!false)
			{
			}
			UnifiedRandom genRand11 = WorldGen.genRand;
			int num32 = 3;
			int num33 = genRand11.Next(num32);
			Tile tile20;
			bool flag10 = tile20.nactive();
			Tile tile21;
			bool flag11 = tile21.halfBrick();
			Tile tile22;
			byte b2 = tile22.slope();
			Tile tile23;
			bool flag12 = tile23.nactive();
			Tile tile24;
			bool flag13 = tile24.halfBrick();
			Tile tile25;
			byte b3 = tile25.slope();
			int num34 = 3;
			int num35 = 2;
			if (num33 != 0)
			{
				if (num35 == 0)
				{
				}
				int num36 = 1;
				Tile tile26;
				tile26.active(num36 != 0);
				int num37 = 5;
				tile26.type = (ushort)num37;
				if (num35 == 0)
				{
				}
				UnifiedRandom genRand12 = WorldGen.genRand;
				int num38 = 3;
				if (genRand12.Next(num38) == 0)
				{
				}
			}
			if (num35 == 0)
			{
			}
			int num39 = 1;
			Tile tile27;
			tile27.active(num39 != 0);
			int num40 = 5;
			tile27.type = (ushort)num40;
			if (num35 == 0)
			{
			}
			UnifiedRandom genRand13 = WorldGen.genRand;
			int num41 = 3;
			if (genRand13.Next(num41) == 0)
			{
			}
			if (num35 == 0)
			{
			}
			UnifiedRandom genRand14 = WorldGen.genRand;
			int num42 = 3;
			int num43 = genRand14.Next(num42);
			if (num7 != 0)
			{
				if (num35 == 0)
				{
				}
				if (num43 != 0)
				{
					goto IL_04F4;
				}
				long num44 = 0L;
				Tile tile28;
				tile28.frameX = (short)num44;
			}
			if (num35 == 0)
			{
			}
			if (num43 == 0)
			{
				int num45 = 88;
				Tile tile29;
				tile29.frameX = (short)num45;
				if (num35 == 0)
				{
				}
				if (num43 == 0)
				{
					int num46 = 66;
					Tile tile30;
					tile30.frameX = (short)num46;
					if (num35 == 0)
					{
					}
					Tile tile31;
					ushort type4 = tile31.type;
					if (num34 == 0)
					{
					}
					return WorldGen.IsTileTypeFitForTree(type4);
				}
			}
			IL_04F4:
			if (!false)
			{
			}
			UnifiedRandom genRand15 = WorldGen.genRand;
			int num47 = 13;
			int num48 = genRand15.Next(num47);
			if (num34 == 0)
			{
			}
			if (num34 == 0)
			{
			}
			UnifiedRandom genRand16 = WorldGen.genRand;
			int num49 = 3;
			int num51;
			if (genRand16.Next(num49) == 0)
			{
				if (num34 == 0)
				{
				}
				UnifiedRandom genRand17 = WorldGen.genRand;
				int num50 = 3;
				if (genRand17.Next(num50) == 0)
				{
					num51 = 220;
				}
			}
			if (!false)
			{
			}
			long num52;
			WorldGen.RangeFrame(0, num51, (int)num52, 0);
			if (!false)
			{
			}
			bool netHost = Main.NetHost;
			if (!false)
			{
			}
			Tile tile32;
			ushort type5 = tile32.type;
			if (num34 == 0)
			{
			}
			return WorldGen.IsTileTypeFitForTree(type5);
		}

		// Token: 0x06002CE6 RID: 11494 RVA: 0x001C1124 File Offset: 0x001BF324
		public static bool DefaultTreeWallTest(int wallType)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06002CE7 RID: 11495 RVA: 0x001C1138 File Offset: 0x001BF338
		public static bool GemTreeWallTest(int wallType)
		{
			/*
An exception occurred when decompiling this method (06002CE7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::GemTreeWallTest(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:bool(var_0_09, call:bool(WorldGen::DefaultTreeWallTest, ldc.i4:int32(0)))
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

		// Token: 0x06002CE8 RID: 11496 RVA: 0x001C1154 File Offset: 0x001BF354
		public static bool GemTreeGroundTest(int tileType)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06002CE9 RID: 11497 RVA: 0x001C1168 File Offset: 0x001BF368
		public static bool VanityTreeGroundTest(int tileType)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06002CEA RID: 11498 RVA: 0x001C117C File Offset: 0x001BF37C
		public static bool AshTreeGroundTest(int tileType)
		{
		}

		// Token: 0x06002CEB RID: 11499 RVA: 0x001C118C File Offset: 0x001BF38C
		public static bool TryGrowingTreeByType(int treeTileType, int checkedX, int checkedY)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int value = num.m_value;
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
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			return WorldGen.GrowTree(treeTileType, checkedX);
		}

		// Token: 0x06002CEC RID: 11500 RVA: 0x001C1200 File Offset: 0x001BF400
		public static bool GrowTreeWithSettings(int checkedX, int checkedY, WorldGen.GrowTreeSettings settings)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Tile tile;
			ushort type = tile.type;
			if (num == 0)
			{
			}
			Tile tile2;
			byte liquid = tile2.liquid;
			if (num == 0)
			{
			}
			Tile tile3;
			byte liquid2 = tile3.liquid;
			if (num == 0)
			{
			}
			Tile tile4;
			byte liquid3 = tile4.liquid;
			if (num == 0)
			{
			}
			Tile tile5;
			bool flag = tile5.nactive();
			if (num == 0)
			{
			}
			Tile tile6;
			ushort wall = tile6.wall;
			if (num == 0)
			{
			}
			Tile tile7;
			bool flag2 = tile7.active();
			if (num == 0)
			{
			}
			Tile tile8;
			ushort type2 = tile8.type;
			if (num == 0)
			{
			}
			Tile tile9;
			bool flag3 = tile9.active();
			if (num == 0)
			{
			}
			Tile tile10;
			ushort type3 = tile10.type;
			if (num == 0)
			{
			}
			long num2 = 0L;
			Tile tile11;
			TileColorCache tileColorCache = tile11.BlockColorAndCoating();
			int num4;
			if (num != 0)
			{
				UnifiedRandom genRand = WorldGen.genRand;
				long num3 = 0L;
				num4 = genRand.Next((int)num2, checkedX);
				int num5 = 20;
				bool flag4 = WorldGen.EmptyTileCheck(num4, (int)num2, checkedX, (int)num3, num5);
				if (num4 == 0)
				{
				}
				UnifiedRandom genRand2 = WorldGen.genRand;
				int num6 = 3;
				int num7 = genRand2.Next(num6);
				UnifiedRandom genRand3 = WorldGen.genRand;
				int num8 = 3;
				int num9 = genRand3.Next(num8);
				UnifiedRandom genRand4 = WorldGen.genRand;
				int num10 = 10;
				int num11 = genRand4.Next(num10);
				UnifiedRandom genRand5 = WorldGen.genRand;
				int num12 = 10;
				int num13 = genRand5.Next(num12);
				int num14 = 1;
				Tile tile12;
				tile12.active(num14 != 0);
				UnifiedRandom genRand6 = WorldGen.genRand;
				int num15 = 3;
				int num16 = genRand6.Next(num15);
				UnifiedRandom genRand7 = WorldGen.genRand;
				int num17 = 3;
				int num18 = genRand7.Next(num17);
				if (num16 == 0 || num16 != 0)
				{
				}
				int num19 = 1;
				Tile tile13;
				tile13.active(num19 != 0);
				UnifiedRandom genRand8 = WorldGen.genRand;
				int num20 = 3;
				int num21 = genRand8.Next(num20);
				UnifiedRandom genRand9 = WorldGen.genRand;
				int num22 = 3;
				int num23 = genRand9.Next(num22);
				if (num21 == 0 || num21 != 0)
				{
				}
				Tile tile14;
				bool flag5 = tile14.nactive();
				Tile tile15;
				bool flag6 = tile15.halfBrick();
				Tile tile16;
				byte b = tile16.slope();
				Tile tile17;
				ushort type4 = tile17.type;
				if (num4 == 0)
				{
				}
				return WorldGen.IsTileTypeFitForTree(type4);
			}
			UnifiedRandom genRand10 = WorldGen.genRand;
			int num24 = 1;
			int num25 = 13;
			int num26 = genRand10.Next(num24, num25);
			if (num26 != 0)
			{
				int num27 = 1;
				Tile tile18;
				tile18.active(num27 != 0);
				UnifiedRandom genRand11 = WorldGen.genRand;
				int num28 = 3;
				if (genRand11.Next(num28) == 0)
				{
				}
			}
			UnifiedRandom genRand12 = WorldGen.genRand;
			int num29 = 3;
			int num30 = genRand12.Next(num29);
			if (num30 == 0)
			{
				int num31 = 88;
				Tile tile19;
				tile19.frameX = (short)num31;
				if (num26 != 0)
				{
					if (num30 != 0)
					{
						goto IL_03ED;
					}
					long num32 = 0L;
					Tile tile20;
					tile20.frameX = (short)num32;
				}
				long num33;
				if (num33 != 0L && num30 == 0)
				{
					int num34 = 66;
					Tile tile21;
					tile21.frameX = (short)num34;
					int num35 = 88;
					tile21.frameX = (short)num35;
					int num36 = 88;
					tile21.frameX = (short)num36;
					Tile tile22;
					ushort type5 = tile22.type;
					if (num4 == 0)
					{
					}
					return WorldGen.IsTileTypeFitForTree(type5);
				}
			}
			IL_03ED:
			UnifiedRandom genRand13 = WorldGen.genRand;
			int num37 = 13;
			int num38 = genRand13.Next(num37);
			if (num4 == 0)
			{
			}
			long num39 = 0L;
			if (num38 != 0)
			{
				if (num4 == 0)
				{
				}
				UnifiedRandom genRand14 = WorldGen.genRand;
				int num40 = 3;
				if (genRand14.Next(num40) != 0)
				{
					goto IL_0462;
				}
			}
			if (num4 == 0)
			{
			}
			UnifiedRandom genRand15 = WorldGen.genRand;
			int num41 = 3;
			int num42;
			long num43;
			if (genRand15.Next(num41) == 0)
			{
				num42 = 220;
				num43 = 0L;
			}
			IL_0462:
			WorldGen.RangeFrame(0, num42, (int)num43, (int)num39);
			if (!false)
			{
			}
			bool netHost = Main.NetHost;
			if (!false)
			{
				goto IL_047E;
			}
			goto IL_047E;
			IL_047E:;
		}

		// Token: 0x06002CED RID: 11501 RVA: 0x001C169C File Offset: 0x001BF89C
		public static void GrowUndergroundTree(int i, int y)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Tile tile;
			ushort type = tile.type;
			if (num == 0)
			{
			}
			Tile tile2;
			bool flag = tile2.nactive();
			if (num == 0)
			{
			}
			Tile tile3;
			bool flag2 = tile3.halfBrick();
			if (num == 0)
			{
			}
			Tile tile4;
			byte b = tile4.slope();
			if (num == 0)
			{
			}
			Tile tile5;
			ushort type2 = tile5.type;
			if (num == 0)
			{
			}
			Tile tile6;
			bool flag3 = tile6.active();
			if (num == 0)
			{
			}
			Tile tile7;
			ushort type3 = tile7.type;
			if (num == 0)
			{
			}
			Tile tile8;
			bool flag4 = tile8.active();
			if (num == 0)
			{
			}
			Tile tile9;
			ushort type4 = tile9.type;
			if (num == 0)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num2 = 5;
			int num3 = 15;
			int num4 = genRand.Next(num2, num3);
			long num5 = 0L;
			long num6 = 0L;
			Tile tile10;
			ushort type5 = tile10.type;
			int num7 = 20;
			bool flag5 = WorldGen.EmptyTileCheck(43143168, (int)num6, y, (int)num5, num7);
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num8 = 3;
			int num9 = genRand2.Next(num8);
			UnifiedRandom genRand3 = WorldGen.genRand;
			int num10 = 3;
			int num11 = genRand3.Next(num10);
			UnifiedRandom genRand4 = WorldGen.genRand;
			int num12 = 10;
			int num13 = genRand4.Next(num12);
			UnifiedRandom genRand5 = WorldGen.genRand;
			int num14 = 10;
			int num15 = genRand5.Next(num14);
		}

		// Token: 0x06002CEE RID: 11502 RVA: 0x001C1C00 File Offset: 0x001BFE00
		public static bool GrowShroom(int i, int y)
		{
			/*
An exception occurred when decompiling this method (06002CEE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::GrowShroom(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_015F:
	stloc:UnifiedRandom(var_59_164, callgetter:UnifiedRandom(WorldGen::get_genRand))
	stloc:int32(var_60_167, ldc.i4:int32(3))
	stloc:int32(var_62_175, call:int32(UnifiedRandom::Next, ldloc:UnifiedRandom(var_59_164), ldloc:int32(var_60_167)))
	stloc:int64(var_63_178, ldc.i4:int64(0))
	stloc:int32(var_65_17C, ldc.i4:int32(36))
	callsetter:int16(Tile::set_frameX, ldloc:Tile[exp:valuetype Terraria.Tile&](var_64), ldloc:int32[exp:int16](var_65_17C))
	stloc:int64(var_66_188, ldc.i4:int64(0))
	callsetter:int16(Tile::set_frameY, ldloc:Tile[exp:valuetype Terraria.Tile&](var_64), ldloc:int32[exp:int16](var_65_17C))
	call:void(WorldGen::RangeFrame, ldc.i4:int32(0), ldloc:int32(var_65_17C), ldloc:int64[exp:int32](var_66_188), ldloc:int64[exp:int32](var_63_178))
	stloc:bool(var_68_1A7, callgetter:bool(Main::get_NetHost))
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

		// Token: 0x06002CEF RID: 11503 RVA: 0x001C1DB8 File Offset: 0x001BFFB8
		public static void AddTrees(bool undergroundOnly = false)
		{
			int num = 1;
			if (num == 0)
			{
			}
			double num2 = WorldGen.genRand.NextDouble();
			double num3 = WorldGen.genRand.NextDouble();
			if (num == 0)
			{
			}
			double num4 = WorldGen.genRand.NextDouble();
		}

		// Token: 0x06002CF0 RID: 11504 RVA: 0x001C1EE0 File Offset: 0x001C00E0
		public static void ExplodeMine(int i, int j, bool fromWiring)
		{
			if (!true)
			{
			}
			Tile tile;
			ushort type = tile.type;
			if (!true)
			{
			}
			long num = 0L;
			long num2 = 0L;
			WorldGen.KillTile(i, j, num != 0L, num2 != 0L, true);
			if (!true)
			{
			}
			Player localPlayer = Main.LocalPlayer;
			IEntitySource projectileSource_PlayerOrWires = WorldGen.GetProjectileSource_PlayerOrWires(i, j, j != 0, localPlayer);
			int myPlayer = Main.myPlayer;
		}

		// Token: 0x06002CF1 RID: 11505 RVA: 0x001C1F2C File Offset: 0x001C012C
		public static bool EmptyTileCheck(int startX, int endX, int startY, int endY, int ignoreID = -1)
		{
			long num = 0L;
			Tile tile;
			bool flag = tile.active();
			Tile tile2;
			ushort type = tile2.type;
			Tile tile3;
			ushort type2 = tile3.type;
			if (num != 0L)
			{
				Tile tile4;
				ushort type3 = tile4.type;
				Tile tile5;
				ushort type4 = tile5.type;
				return;
			}
		}

		// Token: 0x06002CF2 RID: 11506 RVA: 0x001C1F7C File Offset: 0x001C017C
		public static void StartHardmode()
		{
			if (!true)
			{
			}
			bool netClientOnly = Main.NetClientOnly;
			if (!true)
			{
			}
		}

		// Token: 0x06002CF3 RID: 11507 RVA: 0x001C1F9C File Offset: 0x001C019C
		public static void TryProtectingSpawnedItems()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002CF4 RID: 11508 RVA: 0x001C1FB4 File Offset: 0x001C01B4
		private static bool EligibleForSpawnProtection(Item item)
		{
			int num = 1;
			if (num == 0 || num == 0)
			{
				return;
			}
		}

		// Token: 0x06002CF5 RID: 11509 RVA: 0x001C1FCC File Offset: 0x001C01CC
		public static void UndoSpawnedItemProtection()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002CF6 RID: 11510 RVA: 0x001C1FE4 File Offset: 0x001C01E4
		public static void smCallBack(object threadContext)
		{
			if (!true)
			{
			}
			Thread currentThread = Thread.CurrentThread;
		}

		// Token: 0x06002CF7 RID: 11511 RVA: 0x001C22E0 File Offset: 0x001C04E0
		private static void FinaliseHardModeOnMainThread(object data)
		{
			if (!true)
			{
			}
			DrPlatform.Switch.CPUBoostMode = false;
			bool netHost = Main.NetHost;
			AchievementsHelper.NotifyProgressionEvent(9);
			bool netHost2 = Main.NetHost;
			Netplay.ResetSections();
			WorldGen.UndoSpawnedItemProtection();
		}

		// Token: 0x06002CF8 RID: 11512 RVA: 0x001C231C File Offset: 0x001C051C
		public static bool PlaceDoor(int i, int j, int type, int style = 0)
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
			long num2 = 0L;
			Tile tile2;
			ushort type2 = tile2.type;
			if (num != 0)
			{
				if (num == 0)
				{
				}
				long num3 = 0L;
				bool flag2 = WorldGen.SolidTile(0, (int)num2, num3 != 0L);
				if (num == 0)
				{
				}
				int num4 = 1;
				Tile tile3;
				tile3.active(num4 != 0);
				int num5 = 10;
				tile3.type = (ushort)num5;
				int num6 = 36409;
				tile3.frameY = (short)type;
				if (num6 == 0)
				{
				}
				UnifiedRandom genRand = WorldGen.genRand;
				int num7 = 3;
				int num8 = genRand.Next(num7);
				int num9 = 1;
				Tile tile4;
				tile4.active(num9 != 0);
				int num10 = 10;
				tile4.type = (ushort)num10;
				tile4.frameY = (short)num10;
				UnifiedRandom genRand2 = WorldGen.genRand;
				int num11 = 3;
				int num12 = genRand2.Next(num11);
				int num13 = 1;
				Tile tile5;
				tile5.active(num13 != 0);
				int num14 = 10;
				tile5.type = (ushort)num14;
				tile5.frameY = (short)num14;
				UnifiedRandom genRand3 = WorldGen.genRand;
				int num15 = 3;
				int num16 = genRand3.Next(num15);
				return;
			}
		}

		// Token: 0x06002CF9 RID: 11513 RVA: 0x001C241C File Offset: 0x001C061C
		public static bool CloseDoor(int i, int j, bool forced = false)
		{
			/*
An exception occurred when decompiling this method (06002CF9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::CloseDoor(System.Int32,System.Int32,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_007B:
	stloc:int64(var_19_7C, ldc.i4:int64(0))
	stloc:int64(var_20_7F, ldc.i4:int64(0))
	call:void(WorldGen::TileFrame, ldloc:int16[exp:int32](var_2_0B), ldloc:int32(var_10_2E), ldloc:int64[exp:bool](var_19_7C), ldloc:int64[exp:bool](var_20_7F))
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

		// Token: 0x06002CFA RID: 11514 RVA: 0x001C24BC File Offset: 0x001C06BC
		public static bool AddLifeCrystal(int i, int j)
		{
			/*
An exception occurred when decompiling this method (06002CFA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::AddLifeCrystal(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0064:
	stloc:int32(var_32_65, ldc.i4:int32(1))
	call:void(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_31), ldloc:int32[exp:bool](var_32_65))
	stloc:int32(var_33_72, ldc.i4:int32(12))
	callsetter:uint16(Tile::set_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_31), ldloc:int32[exp:uint16](var_33_72))
	stloc:int64(var_34_7E, ldc.i4:int64(0))
	callsetter:int16(Tile::set_frameX, ldloc:Tile[exp:valuetype Terraria.Tile&](var_31), ldloc:int64[exp:int16](var_34_7E))
	stloc:int64(var_35_8A, ldc.i4:int64(0))
	callsetter:int16(Tile::set_frameY, ldloc:Tile[exp:valuetype Terraria.Tile&](var_31), ldloc:int64[exp:int16](var_35_8A))
	stloc:int32(var_37_96, ldc.i4:int32(1))
	call:void(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_36), ldloc:int32[exp:bool](var_37_96))
	stloc:int32(var_38_A3, ldc.i4:int32(12))
	callsetter:uint16(Tile::set_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_36), ldloc:int32[exp:uint16](var_38_A3))
	stloc:int32(var_39_B0, ldc.i4:int32(18))
	callsetter:int16(Tile::set_frameX, ldloc:Tile[exp:valuetype Terraria.Tile&](var_36), ldloc:int32[exp:int16](var_39_B0))
	stloc:int64(var_40_BC, ldc.i4:int64(0))
	callsetter:int16(Tile::set_frameY, ldloc:Tile[exp:valuetype Terraria.Tile&](var_36), ldloc:int64[exp:int16](var_40_BC))
	stloc:int32(var_42_C8, ldc.i4:int32(1))
	call:void(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_41), ldloc:int32[exp:bool](var_42_C8))
	stloc:int32(var_43_D5, ldc.i4:int32(12))
	callsetter:uint16(Tile::set_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_41), ldloc:int32[exp:uint16](var_43_D5))
	stloc:int64(var_44_E1, ldc.i4:int64(0))
	callsetter:int16(Tile::set_frameX, ldloc:Tile[exp:valuetype Terraria.Tile&](var_41), ldloc:int64[exp:int16](var_44_E1))
	stloc:int32(var_45_EE, ldc.i4:int32(18))
	callsetter:int16(Tile::set_frameY, ldloc:Tile[exp:valuetype Terraria.Tile&](var_41), ldloc:int32[exp:int16](var_45_EE))
	stloc:int32(var_47_FA, ldc.i4:int32(1))
	call:void(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_46), ldloc:int32[exp:bool](var_47_FA))
	stloc:int32(var_48_107, ldc.i4:int32(12))
	callsetter:uint16(Tile::set_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_46), ldloc:int32[exp:uint16](var_48_107))
	stloc:int32(var_49_114, ldc.i4:int32(18))
	callsetter:int16(Tile::set_frameX, ldloc:Tile[exp:valuetype Terraria.Tile&](var_46), ldloc:int32[exp:int16](var_49_114))
	stloc:int32(var_50_121, ldc.i4:int32(18))
	callsetter:int16(Tile::set_frameY, ldloc:Tile[exp:valuetype Terraria.Tile&](var_46), ldloc:int32[exp:int16](var_50_121))
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

		// Token: 0x06002CFB RID: 11515 RVA: 0x001C25F8 File Offset: 0x001C07F8
		public static void AddShadowOrb(int x, int y)
		{
			if (!true)
			{
			}
			int num = 1;
			Tile tile;
			tile.active(num != 0);
			int num2 = 31;
			tile.type = (ushort)num2;
			long num3 = 0L;
			tile.frameY = (short)num3;
			int num4 = 1;
			Tile tile2;
			tile2.active(num4 != 0);
			int num5 = 31;
			tile2.type = (ushort)num5;
			tile2.frameX = (short)num5;
			long num6 = 0L;
			tile2.frameY = (short)num6;
			int num7 = 1;
			Tile tile3;
			tile3.active(num7 != 0);
			int num8 = 31;
			tile3.type = (ushort)num8;
			int num9 = 18;
			tile3.frameY = (short)num9;
			int num10 = 1;
			Tile tile4;
			tile4.active(num10 != 0);
			int num11 = 31;
			tile4.type = (ushort)num11;
			tile4.frameX = (short)num11;
			int num12 = 18;
			tile4.frameY = (short)num12;
		}

		// Token: 0x06002CFC RID: 11516 RVA: 0x001C26C4 File Offset: 0x001C08C4
		public static void AddHellHouses()
		{
			int num = 1;
			if (num == 0)
			{
			}
			long num2 = 32752L;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num2 != 0L)
			{
				return;
			}
			if (num2 == 0L)
			{
			}
			if (num == 0 || num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num2 != 0L || num2 == 0L)
			{
			}
			Tile tile;
			bool flag = tile.active();
			Tile tile2;
			byte liquid = tile2.liquid;
		}

		// Token: 0x06002CFD RID: 11517 RVA: 0x001C2F04 File Offset: 0x001C1104
		public static void HellFort(int i, int j, ushort tileType = 75, byte wallType = 14)
		{
			int num = WorldGen.genRand.Next(43143168, (int)tileType);
			int num2 = WorldGen.genRand.Next(43143168, (int)tileType);
			int num3 = WorldGen.genRand.Next(43143168, (int)tileType);
			int num4 = WorldGen.genRand.Next(43143168, (int)tileType);
			int num5 = WorldGen.genRand.Next(43143168, (int)tileType);
			int num6 = WorldGen.genRand.Next(43143168, (int)tileType);
			UnifiedRandom genRand = WorldGen.genRand;
			int num7 = 6;
			int num8 = 12;
			int num9 = genRand.Next(num7, num8);
			wallType.m_value = (byte)j;
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num10 = 6;
			int num11 = 12;
			int num12 = genRand2.Next(num10, num11);
			i.m_value = j;
			UnifiedRandom genRand3 = WorldGen.genRand;
			int num13 = 6;
			int num14 = 12;
			int num15 = genRand3.Next(num13, num14);
			UnifiedRandom genRand4 = WorldGen.genRand;
			int num16 = 3;
			if (genRand4.Next(num16) != 0)
			{
			}
			UnifiedRandom genRand5 = WorldGen.genRand;
			int num17 = 10;
			int num18 = genRand5.Next(num17);
			UnifiedRandom genRand6 = WorldGen.genRand;
			int num19 = 2;
			if (genRand6.Next(num19) != 0)
			{
			}
		}

		// Token: 0x06002CFE RID: 11518 RVA: 0x001C34D4 File Offset: 0x001C16D4
		public static void HellHouse(int i, int j, byte type = 76, byte wall = 13)
		{
			int num = 1;
			if (num == 0)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num2 = 8;
			int num3 = 20;
			int num4 = genRand.Next(num2, num3);
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num5 = 1;
			int num6 = 3;
			int num7 = genRand2.Next(num5, num6);
			UnifiedRandom genRand3 = WorldGen.genRand;
			int num8 = 4;
			int num9 = 13;
			int num10 = genRand3.Next(num8, num9);
			if (num == 0)
			{
			}
			UnifiedRandom genRand4 = WorldGen.genRand;
			int num11 = 5;
			int num12 = 9;
			int num13 = genRand4.Next(num11, num12);
			WorldGen.HellRoom(i, j, num4, num13, type, wall);
			if (num == 0)
			{
			}
			UnifiedRandom genRand5 = WorldGen.genRand;
			int num14 = 5;
			int num15 = 9;
			int num16 = genRand5.Next(num14, num15);
			WorldGen.HellRoom(i, j, num4, num16, type, wall);
			if (num == 0)
			{
			}
			Tile tile;
			bool flag = tile.active();
			Tile tile2;
			ushort type2 = tile2.type;
			Tile tile3;
			ushort type3 = tile3.type;
			Tile tile4;
			ushort wall2 = tile4.wall;
			Tile tile5;
			ushort wall3 = tile5.wall;
		}

		// Token: 0x06002CFF RID: 11519 RVA: 0x001C36F8 File Offset: 0x001C18F8
		public static void HellRoom(int i, int j, int width, int height, byte type = 76, byte wall = 13)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int num2 = 1;
			Tile tile;
			tile.active(num2 != 0);
			tile.type = (ushort)type;
			long num3 = 0L;
			tile.liquid = (byte)num3;
			long num4 = 0L;
			tile.lava(num4 != 0L);
		}

		// Token: 0x06002D00 RID: 11520 RVA: 0x001C3774 File Offset: 0x001C1974
		public static void templeCleaner(int x, int y)
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
		}

		// Token: 0x06002D01 RID: 11521 RVA: 0x001C3868 File Offset: 0x001C1A68
		public static Vector2D templePather(Vector2D templePath, int destX, int destY)
		{
			/*
An exception occurred when decompiling this method (06002D01)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ReLogic.Utilities.Vector2D Terraria.WorldGen::templePather(ReLogic.Utilities.Vector2D,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0038:
	stloc:int64(var_10_39, ldc.i4:int64(0))
	call:void(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_9), ldloc:int64[exp:bool](var_10_39))
	stloc:int32(var_11_46, ldc.i4:int32(87))
	callsetter:uint16(Tile::set_wall, ldloc:Tile[exp:valuetype Terraria.Tile&](var_9), ldloc:int32[exp:uint16](var_11_46))
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

		// Token: 0x06002D02 RID: 11522 RVA: 0x001C38C8 File Offset: 0x001C1AC8
		public static void outerTempled(int x, int y)
		{
			if (!true)
			{
			}
			Tile tile;
			bool flag = tile.active();
			Tile tile2;
			ushort type = tile2.type;
			Tile tile3;
			ushort wall = tile3.wall;
			Tile tile4;
			bool flag2 = tile4.active();
			Tile tile5;
			ushort wall2 = tile5.wall;
		}

		// Token: 0x06002D03 RID: 11523 RVA: 0x001C3944 File Offset: 0x001C1B44
		public static void makeTemple(int x, int y)
		{
			UnifiedRandom genRand = WorldGen.genRand;
			int num = 32768;
			if (num == 0)
			{
			}
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num2 = 2;
			int num3 = genRand2.Next(num2);
			if (num == 0)
			{
			}
			UnifiedRandom genRand3 = WorldGen.genRand;
			int num4 = 1;
			int num5 = 3;
			int num6 = genRand3.Next(num4, num5);
			UnifiedRandom genRand4 = WorldGen.genRand;
			int num7 = 25;
			int num8 = 50;
			int num9 = genRand4.Next(num7, num8);
			UnifiedRandom genRand5 = WorldGen.genRand;
			int num10 = 20;
			int num11 = 35;
			int num12 = genRand5.Next(num10, num11);
			UnifiedRandom genRand6 = WorldGen.genRand;
			int num13 = 55;
			int num14 = 65;
			int num15 = genRand6.Next(num13, num14);
			UnifiedRandom genRand7 = WorldGen.genRand;
			int num16 = 45;
			int num17 = 50;
			if (genRand7.Next(num16, num17) == 0)
			{
			}
			UnifiedRandom genRand8 = WorldGen.genRand;
			int num18 = 5;
			int num19 = 10;
			int num20 = genRand8.Next(num18, num19);
		}

		// Token: 0x06002D04 RID: 11524 RVA: 0x001C45AC File Offset: 0x001C27AC
		public static void templePart2()
		{
			if (!true)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num = WorldGen.genRand.Next(1073741824, 43143168);
			int num2 = WorldGen.genRand.Next(1073741824, 43143168);
			Tile tile;
			ushort wall = tile.wall;
			Tile tile2;
			bool flag = tile2.active();
			bool flag2 = WorldGen.mayanTrap(num, num2);
		}

		// Token: 0x06002D05 RID: 11525 RVA: 0x001C48FC File Offset: 0x001C2AFC
		public static bool nearPicture(int x, int y)
		{
			/*
An exception occurred when decompiling this method (06002D05)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::nearPicture(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:bool(var_1_09, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_0)))
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

		// Token: 0x06002D06 RID: 11526 RVA: 0x001C4918 File Offset: 0x001C2B18
		public static bool nearPicture2(int x, int y)
		{
			/*
An exception occurred when decompiling this method (06002D06)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::nearPicture2(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0083:
	stloc:uint16(var_25_8A, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_24)))
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

		// Token: 0x06002D07 RID: 11527 RVA: 0x001C49B8 File Offset: 0x001C2BB8
		private static void ShimmerCleanUp()
		{
			int num = 1;
			if (num == 0)
			{
			}
			WorldGen.ShimmerRemoveWater();
			if (num == 0)
			{
			}
			Tile tile;
			ushort type = tile.type;
		}

		// Token: 0x06002D08 RID: 11528 RVA: 0x001C4B54 File Offset: 0x001C2D54
		public static void ShimmerRemoveWater()
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
				if (num == 0)
				{
				}
				long num2 = 0L;
				bool flag = WorldGen.InWorld(0, 43143168, (int)num2);
				if (num == 0)
				{
				}
				Tile tile;
				bool flag2 = tile.shimmer();
			}
		}

		// Token: 0x06002D09 RID: 11529 RVA: 0x001C4B9C File Offset: 0x001C2D9C
		public static bool ShimmerMakeBiome(int X, int Y)
		{
			/*
An exception occurred when decompiling this method (06002D09)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::ShimmerMakeBiome(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_054F:
	stloc:uint16(var_154_556, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_153)))
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

		// Token: 0x06002D0A RID: 11530 RVA: 0x001C5104 File Offset: 0x001C3304
		private static void ShimmerMakeBiomeOpening(int direction, int X, int Y, int caveOpenningSize)
		{
			if (!true)
			{
			}
			long num = 0L;
			bool flag = WorldGen.SolidTile(caveOpenningSize, X, num != 0L);
			long num2 = 0L;
			bool flag2 = WorldGen.SolidTile(0, X, num2 != 0L);
			long num3 = 0L;
			bool flag3 = WorldGen.SolidTile(0, X, num3 != 0L);
			long num4 = 0L;
			Tile tile;
			tile.active(num4 != 0L);
		}

		// Token: 0x06002D0B RID: 11531 RVA: 0x001C51B8 File Offset: 0x001C33B8
		private static void Shimminate()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int num2 = 1;
			Tile tile;
			tile.shimmer(num2 != 0);
			int num3 = 255;
			tile.liquid = (byte)num3;
			ushort type = tile.type;
			if (num == 0)
			{
			}
			long num4 = 0L;
			long num5 = 0L;
			long num6 = 0L;
			WorldGen.KillTile(0, 0, num4 != 0L, num5 != 0L, num6 != 0L);
		}

		// Token: 0x06002D0C RID: 11532 RVA: 0x001C522C File Offset: 0x001C342C
		public static void Shimmerator(int x, int y, bool jungle = false, bool lavaOk = false)
		{
			int num = 1;
			if (num == 0)
			{
			}
			WorldGen.ShimmeratorNext(x, y);
			if (num == 0)
			{
			}
			WorldGen.Shimminate();
		}

		// Token: 0x06002D0D RID: 11533 RVA: 0x001C5250 File Offset: 0x001C3450
		public static void ShimmeratorNext(int x, int y)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Tile.StartNewSearch();
			if (num == 0)
			{
			}
		}

		// Token: 0x06002D0E RID: 11534 RVA: 0x001C52CC File Offset: 0x001C34CC
		public static void MakeDungeon(int x, int y)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num2 = 3;
			int num3 = genRand.Next(num2);
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num4 = 3;
			int num5 = genRand2.Next(num4);
		}

		// Token: 0x06002D0F RID: 11535 RVA: 0x001C63D8 File Offset: 0x001C45D8
		private static void MakeDungeon_Traps(int failCount, int failMax, int numAdd)
		{
			if (!true)
			{
			}
			int num = WorldGen.genRand.Next(failMax, numAdd);
			int num2 = WorldGen.genRand.Next(failMax, numAdd);
			UnifiedRandom genRand = WorldGen.genRand;
		}

		// Token: 0x06002D10 RID: 11536 RVA: 0x001C641C File Offset: 0x001C461C
		private static void MakeDungeon_Lights(ushort tileType, int failCount, int failMax, int numAdd, int[] roomWall)
		{
			UnifiedRandom genRand = WorldGen.genRand;
			int num = 7;
			int num2 = genRand.Next(num);
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num3 = 7;
			int num4 = genRand2.Next(num3);
			UnifiedRandom genRand3 = WorldGen.genRand;
			int num5 = 7;
			int num6 = genRand3.Next(num5);
		}

		// Token: 0x06002D11 RID: 11537 RVA: 0x001C67BC File Offset: 0x001C49BC
		private static double MakeDungeon_Banners(int[] roomWall, double count)
		{
			/*
An exception occurred when decompiling this method (06002D11)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Double Terraria.WorldGen::MakeDungeon_Banners(System.Int32[],System.Double)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0008:
	stloc:UnifiedRandom(var_1_0D, callgetter:UnifiedRandom(WorldGen::get_genRand))
	stloc:UnifiedRandom(var_3_13, callgetter:UnifiedRandom(WorldGen::get_genRand))
	stloc:uint16(var_6_1B, callgetter:uint16(Tile::get_wall, ldloc:Tile[exp:valuetype Terraria.Tile&](var_5)))
	stloc:bool(var_8_24, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_7)))
	stloc:int64(var_9_27, ldc.i4:int64(0))
	stloc:bool(var_10_33, call:bool(WorldGen::SolidTile, ldloc:int32(var_2), ldloc:int32(var_4), ldloc:int64[exp:bool](var_9_27)))
	stloc:uint16(var_12_3C, callgetter:uint16(Tile::get_wall, ldloc:Tile[exp:valuetype Terraria.Tile&](var_11)))
	stloc:uint16(var_14_45, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_13)))
	stloc:bool(var_16_4E, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_15)))
	stloc:bool(var_18_57, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_17)))
	stloc:bool(var_20_60, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_19)))
	stloc:bool(var_23_6C, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_21)))
	stloc:bool(var_26_78, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_24)))
	stloc:uint16(var_29_84, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_27)))
	stloc:uint16(var_32_90, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_30)))
	stloc:uint16(var_34_99, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_33)))
	stloc:uint16(var_36_A2, callgetter:uint16(Tile::get_wall, ldloc:Tile[exp:valuetype Terraria.Tile&](var_35)))
	stloc:uint16(var_39_AF, callgetter:uint16(Tile::get_wall, ldloc:Tile[exp:valuetype Terraria.Tile&](var_38)))
	stloc:UnifiedRandom(var_40_B6, callgetter:UnifiedRandom(WorldGen::get_genRand))
	stloc:int32(var_41_B9, ldc.i4:int32(2))
	stloc:int32(var_42_C4, call:int32(UnifiedRandom::Next, ldloc:UnifiedRandom(var_40_B6), ldloc:int32(var_41_B9)))
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

		// Token: 0x06002D12 RID: 11538 RVA: 0x001C6890 File Offset: 0x001C4A90
		private static double MakeDungeon_Pictures(int[] roomWall, double count)
		{
			/*
An exception occurred when decompiling this method (06002D12)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Double Terraria.WorldGen::MakeDungeon_Pictures(System.Int32[],System.Double)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00E4:
	stloc:UnifiedRandom(var_51_E9, callgetter:UnifiedRandom(WorldGen::get_genRand))
	stloc:int32(var_52_EC, ldc.i4:int32(3))
	stloc:int32(var_53_F7, call:int32(UnifiedRandom::Next, ldloc:UnifiedRandom(var_51_E9), ldloc:int32(var_52_EC)))
	stloc:uint16(var_55_100, callgetter:uint16(Tile::get_wall, ldloc:Tile[exp:valuetype Terraria.Tile&](var_54)))
	stloc:UnifiedRandom(var_56_107, callgetter:UnifiedRandom(WorldGen::get_genRand))
	stloc:int32(var_57_10A, ldc.i4:int32(3))
	stloc:int32(var_58_115, call:int32(UnifiedRandom::Next, ldloc:UnifiedRandom(var_56_107), ldloc:int32(var_57_10A)))
	stloc:bool(var_59_11E, call:bool(WorldGen::nearPicture2, ldloc:int32(var_1), ldloc:int32(var_3)))
	stloc:PaintingEntry(var_60_125, call:PaintingEntry(WorldGen::RandPictureTile))
	stloc:uint16(var_62_12E, callgetter:uint16(Tile::get_wall, ldloc:Tile[exp:valuetype Terraria.Tile&](var_61)))
	stloc:PaintingEntry(var_63_135, call:PaintingEntry(WorldGen::RandBonePicture))
	stloc:bool(var_64_13E, call:bool(WorldGen::nearPicture, ldloc:int32(var_1), ldloc:int32(var_3)))
	stloc:PaintingEntry(var_66_145, call:PaintingEntry(WorldGen::RandPictureTile))
	stloc:uint16(var_68_14E, callgetter:uint16(Tile::get_wall, ldloc:Tile[exp:valuetype Terraria.Tile&](var_67)))
	stloc:PaintingEntry(var_69_155, call:PaintingEntry(WorldGen::RandBonePicture))
	stloc:bool(var_71_15E, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_70)))
	stloc:bool(var_75_16A, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_74)))
	stloc:bool(var_77_173, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_76)))
	stloc:bool(var_79_17C, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_78)))
	stloc:bool(var_81_185, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_80)))
	stloc:bool(var_83_18E, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_82)))
	stloc:bool(var_85_197, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_84)))
	stloc:PaintingEntry(var_86_19E, call:PaintingEntry(WorldGen::RandPictureTile))
	stloc:uint16(var_88_1A7, callgetter:uint16(Tile::get_wall, ldloc:Tile[exp:valuetype Terraria.Tile&](var_87)))
	stloc:PaintingEntry(var_89_1AE, call:PaintingEntry(WorldGen::RandBonePicture))
	stloc:bool(var_90_1B7, call:bool(WorldGen::nearPicture, ldloc:int32(var_1), ldloc:int32(var_3)))
	stloc:bool(var_94_1C3, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_93)))
	stloc:bool(var_96_1CC, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_95)))
	stloc:bool(var_98_1D5, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_97)))
	stloc:bool(var_100_1DE, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_99)))
	stloc:bool(var_102_1E7, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_101)))
	stloc:bool(var_104_1F0, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_103)))
	stloc:PaintingEntry(var_105_1F7, call:PaintingEntry(WorldGen::RandPictureTile))
	stloc:uint16(var_107_200, callgetter:uint16(Tile::get_wall, ldloc:Tile[exp:valuetype Terraria.Tile&](var_106)))
	stloc:PaintingEntry(var_108_207, call:PaintingEntry(WorldGen::RandBonePicture))
	stloc:bool(var_109_210, call:bool(WorldGen::nearPicture, ldloc:int32(var_1), ldloc:int32(var_3)))
	stloc:PaintingEntry(var_111_217, call:PaintingEntry(WorldGen::RandPictureTile))
	stloc:uint16(var_113_220, callgetter:uint16(Tile::get_wall, ldloc:Tile[exp:valuetype Terraria.Tile&](var_112)))
	stloc:PaintingEntry(var_114_227, call:PaintingEntry(WorldGen::RandBonePicture))
	stloc:bool(var_116_230, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_115)))
	stloc:bool(var_120_23C, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_119)))
	stloc:bool(var_122_245, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_121)))
	stloc:bool(var_124_24E, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_123)))
	stloc:bool(var_126_257, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_125)))
	stloc:bool(var_128_260, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_127)))
	stloc:bool(var_130_269, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_129)))
	stloc:PaintingEntry(var_131_270, call:PaintingEntry(WorldGen::RandPictureTile))
	stloc:uint16(var_133_279, callgetter:uint16(Tile::get_wall, ldloc:Tile[exp:valuetype Terraria.Tile&](var_132)))
	stloc:PaintingEntry(var_134_280, call:PaintingEntry(WorldGen::RandBonePicture))
	stloc:bool(var_135_289, call:bool(WorldGen::nearPicture, ldloc:int32(var_1), ldloc:int32(var_3)))
	stloc:bool(var_139_295, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_138)))
	stloc:bool(var_141_29E, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_140)))
	stloc:bool(var_143_2A7, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_142)))
	stloc:bool(var_145_2B0, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_144)))
	stloc:bool(var_147_2B9, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_146)))
	stloc:bool(var_149_2C2, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_148)))
	stloc:PaintingEntry(var_150_2C9, call:PaintingEntry(WorldGen::RandPictureTile))
	stloc:uint16(var_152_2D2, callgetter:uint16(Tile::get_wall, ldloc:Tile[exp:valuetype Terraria.Tile&](var_151)))
	stloc:PaintingEntry(var_153_2D9, call:PaintingEntry(WorldGen::RandBonePicture))
	stloc:bool(var_154_2E2, call:bool(WorldGen::nearPicture, ldloc:int32(var_1), ldloc:int32(var_3)))
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

		// Token: 0x06002D13 RID: 11539 RVA: 0x001C6B80 File Offset: 0x001C4D80
		private static double MakeDungeon_GroundFurniture(int wallType)
		{
			int num14;
			int num23;
			int num25;
			long num27;
			for (;;)
			{
				if (!true)
				{
				}
				long num = 32752L;
				long num2 = -2147483647L;
				if (num == 0L)
				{
				}
				UnifiedRandom genRand = WorldGen.genRand;
				if (num2 == 0L)
				{
				}
				UnifiedRandom genRand2 = WorldGen.genRand;
				if (num2 == 0L)
				{
				}
				Tile tile;
				ushort wall = tile.wall;
				long num3 = 0L;
				Tile tile2;
				bool flag = tile2.active();
				int num5;
				int num4 = WorldGen.genRand.Next((int)num3, num5);
				UnifiedRandom genRand3 = WorldGen.genRand;
				Tile tile3;
				ushort wall2 = tile3.wall;
				long num6 = 0L;
				Tile tile4;
				bool flag2 = tile4.active();
				long num7 = 0L;
				bool flag3 = WorldGen.SolidTile(num4, (int)num6, num7 != 0L);
				int underworldLayer = Main.UnderworldLayer;
				long num8 = 0L;
				Tile tile5;
				bool flag4 = tile5.active();
				long num9 = 0L;
				bool flag5 = WorldGen.SolidTile(num4, (int)num8, num9 != 0L);
				long num10 = 0L;
				Tile tile6;
				bool flag6 = tile6.active();
				long num11 = 0L;
				bool flag7 = WorldGen.SolidTile(num4, (int)num10, num11 != 0L);
				Tile tile7;
				bool flag8 = tile7.active();
				long num12 = 0L;
				Tile tile8;
				ushort wall3 = tile8.wall;
				long num13 = 0L;
				bool flag9 = WorldGen.SolidTile(num4, (int)num12, num13 != 0L);
				Tile tile9;
				ushort type = tile9.type;
				num14 = 5;
				int num15 = 30;
				if (num15 == 0)
				{
				}
				Tile tile10;
				ushort wall4 = tile10.wall;
				if (num15 == 0)
				{
				}
				Tile tile11;
				ushort wall5 = tile11.wall;
				int num16 = 15;
				if (num16 == 0)
				{
				}
				UnifiedRandom genRand4 = WorldGen.genRand;
				int num17 = 13;
				int num18 = genRand4.Next(num17);
				if (num16 == 0)
				{
				}
				UnifiedRandom genRand5 = WorldGen.genRand;
				int num19 = 4;
				int num20 = genRand5.Next(num19);
				if (num20 != 0)
				{
					if (num16 == 0)
					{
					}
					UnifiedRandom genRand6 = WorldGen.genRand;
					int num21 = 13;
					int num22 = genRand6.Next(num21);
				}
				num23 = 2;
				int num24 = 1;
				if (num24 == 0)
				{
				}
				Tile tile12;
				bool flag10 = tile12.active();
				num25 = 10;
				if (num24 == 0)
				{
				}
				if (num24 == 0)
				{
				}
				Tile tile13;
				bool flag11 = tile13.active();
				if (num24 == 0)
				{
				}
				Tile tile14;
				bool flag12 = tile14.active();
				if (num24 == 0)
				{
				}
				if (num24 == 0)
				{
				}
				Tile tile15;
				bool flag13 = tile15.active();
				if (num24 == 0)
				{
				}
				Tile tile16;
				short frameX = tile16.frameX;
				Tile tile17;
				short frameX2 = tile17.frameX;
				Tile tile18;
				bool flag14 = tile18.active();
				UnifiedRandom genRand7 = WorldGen.genRand;
				int num26 = 2;
				if (genRand7.Next(num26) == 0)
				{
					break;
				}
				Tile tile19;
				ushort type2 = tile19.type;
				num27 = 0L;
				Tile tile20;
				ushort type3 = tile20.type;
				Tile tile21;
				bool flag15 = tile21.active();
				UnifiedRandom genRand8 = WorldGen.genRand;
				int num28 = 2;
				int num29 = genRand8.Next(num28);
				if (num24 == 0)
				{
				}
				if (num29 != 0)
				{
					goto Block_2;
				}
				Tile tile22;
				bool flag16 = tile22.active();
				if (42190112.0 == null)
				{
				}
				if (42190112.0 == null)
				{
				}
				Tile tile23;
				bool flag17 = tile23.active();
				if (42190112.0 == null)
				{
				}
				Tile tile24;
				short frameX3 = tile24.frameX;
				Tile tile25;
				short frameX4 = tile25.frameX;
				UnifiedRandom genRand9 = WorldGen.genRand;
				int num30 = 2;
				if (genRand9.Next(num30) == 0)
				{
					goto Block_3;
				}
			}
			Tile tile26;
			bool flag18 = tile26.active();
			UnifiedRandom genRand10 = WorldGen.genRand;
			int num31 = 5;
			int num32 = genRand10.Next(num31);
			Tile tile27;
			ushort type4 = tile27.type;
			Tile tile28;
			ushort type5 = tile28.type;
			int num33 = 49;
			int num34 = 1;
			long num35 = 0L;
			long num36 = 0L;
			bool flag19 = WorldGen.PlaceTile(num14, num25, num33, num34 != 0, num35 != 0L, num23, (int)num36);
			return 42190112.0;
			Block_2:
			Tile tile29;
			bool flag20 = tile29.active();
			return 42190112.0;
			Block_3:
			Tile tile30;
			bool flag21 = tile30.active();
			UnifiedRandom genRand11 = WorldGen.genRand;
			int num37 = 5;
			int num38 = genRand11.Next(num37);
			Tile tile31;
			ushort type6 = tile31.type;
			int num39 = 33;
			int num40 = 1;
			long num41 = 0L;
			int num42;
			int num43;
			bool flag22 = WorldGen.PlaceTile(num42, num43, num39, num40 != 0, num41 != 0L, num23, (int)num27);
			Tile tile32;
			ushort type7 = tile32.type;
			int num44 = 49;
			int num45 = 1;
			long num46 = 0L;
			long num47 = 0L;
			bool flag23 = WorldGen.PlaceTile(num42, num43, num44, num45 != 0, num46 != 0L, num23, (int)num47);
			return 42190112.0;
		}

		// Token: 0x06002D14 RID: 11540 RVA: 0x001C7070 File Offset: 0x001C5270
		public static PaintingEntry RandBonePicture()
		{
			if (!true)
			{
			}
			if (WorldGen.genRand.Next(2) != 0)
			{
				return 241;
			}
			if (!true)
			{
			}
			if (WorldGen.genRand.Next(2) != 0)
			{
				return 240;
			}
			return 240;
		}

		// Token: 0x06002D15 RID: 11541 RVA: 0x001C70C8 File Offset: 0x001C52C8
		public static PaintingEntry RandHellPicture()
		{
			/*
An exception occurred when decompiling this method (06002D15)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.GameContent.Generation.PaintingEntry Terraria.WorldGen::RandHellPicture()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_006C:
	stloc:UnifiedRandom(var_13_71, callgetter:UnifiedRandom(WorldGen::get_genRand))
	stloc:int32(var_14_74, ldc.i4:int32(3))
	stloc:int32(var_15_7F, call:int32(UnifiedRandom::Next, ldloc:UnifiedRandom(var_13_71), ldloc:int32(var_14_74)))
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

		// Token: 0x06002D16 RID: 11542 RVA: 0x001C715C File Offset: 0x001C535C
		public static PaintingEntry RandHousePictureDesert()
		{
			/*
An exception occurred when decompiling this method (06002D16)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.GameContent.Generation.PaintingEntry Terraria.WorldGen::RandHousePictureDesert()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0034:
	stloc:UnifiedRandom(var_7_39, callgetter:UnifiedRandom(WorldGen::get_genRand))
	stloc:int32(var_8_3C, ldc.i4:int32(6))
	stloc:int32(var_9_47, call:int32(UnifiedRandom::Next, ldloc:UnifiedRandom(var_7_39), ldloc:int32(var_8_3C)))
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

		// Token: 0x06002D17 RID: 11543 RVA: 0x001C71BC File Offset: 0x001C53BC
		public static PaintingEntry RandHousePicture()
		{
			int num = 1;
			if (num == 0)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num2 = 4;
			int num3 = genRand.Next(num2);
			if (num == 0)
			{
			}
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num4 = 2;
			if (genRand2.Next(num4) != 0)
			{
				if (num == 0)
				{
				}
				UnifiedRandom genRand3 = WorldGen.genRand;
				int num5 = 3;
				int num6 = genRand3.Next(num5);
			}
			if (num == 0)
			{
			}
			UnifiedRandom genRand4 = WorldGen.genRand;
			int num7 = 9;
			if (genRand4.Next(num7) == 0)
			{
				if (num == 0)
				{
				}
				UnifiedRandom genRand5 = WorldGen.genRand;
				int num8 = 3;
				if (genRand5.Next(num8) == 0)
				{
					return;
				}
				if (num == 0)
				{
				}
				UnifiedRandom genRand6 = WorldGen.genRand;
				int num9 = 9;
				int num10 = genRand6.Next(num9);
			}
			if (num == 0)
			{
			}
			UnifiedRandom genRand7 = WorldGen.genRand;
			int num11 = 15;
			int num12 = genRand7.Next(num11);
			if (246 == 0)
			{
			}
			UnifiedRandom genRand8 = WorldGen.genRand;
			int num13 = 4;
			int num14 = genRand8.Next(num13);
		}

		// Token: 0x06002D18 RID: 11544 RVA: 0x001C72B0 File Offset: 0x001C54B0
		public static PaintingEntry RandPictureTile()
		{
			/*
An exception occurred when decompiling this method (06002D18)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.GameContent.Generation.PaintingEntry Terraria.WorldGen::RandPictureTile()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_004A:
	stloc:UnifiedRandom(var_9_4F, callgetter:UnifiedRandom(WorldGen::get_genRand))
	stloc:int32(var_10_52, ldc.i4:int32(7))
	stloc:int32(var_11_5D, call:int32(UnifiedRandom::Next, ldloc:UnifiedRandom(var_9_4F), ldloc:int32(var_10_52)))
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

		// Token: 0x06002D19 RID: 11545 RVA: 0x001C7324 File Offset: 0x001C5524
		public static void DungeonStairs(int i, int j, ushort tileType, int wallType)
		{
			UnifiedRandom genRand = WorldGen.genRand;
			int num = 5;
			int num2 = 9;
			int num3 = genRand.Next(num, num2);
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num4 = 10;
			int num5 = 30;
			int num6 = genRand2.Next(num4, num5);
			int num7 = 399;
			if (num7 == 0)
			{
			}
			UnifiedRandom genRand3 = WorldGen.genRand;
			int num8 = 3;
			int num9 = genRand3.Next(num8);
			if (num7 == 0)
			{
			}
			UnifiedRandom genRand4 = WorldGen.genRand;
			if (num9 != 0)
			{
				int num10 = 200;
				long num11 = 0L;
				int num12 = genRand4.Next((int)num11, num10);
				return;
			}
			if (num7 == 0)
			{
			}
			UnifiedRandom genRand5 = WorldGen.genRand;
			int num13;
			if (num13 != 0)
			{
				int num14 = 6;
				int num15 = genRand5.Next(num14);
				UnifiedRandom genRand6 = WorldGen.genRand;
				int num16 = 6;
				int num17 = genRand6.Next(num16);
				UnifiedRandom genRand7 = WorldGen.genRand;
				int num18 = 6;
				int num19 = genRand7.Next(num18);
				UnifiedRandom genRand8 = WorldGen.genRand;
				int num20 = 6;
				if (genRand8.Next(num20) == 0)
				{
				}
				return;
			}
		}

		// Token: 0x06002D1A RID: 11546 RVA: 0x001C752C File Offset: 0x001C572C
		public static bool PlaceSandTrap(int i, int j)
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
			int underworldLayer = Main.UnderworldLayer;
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
				bool flag2 = tile3.halfBrick();
				if (num == 0)
				{
				}
				Tile tile4;
				bool flag3 = tile4.topSlope();
			}
			if (num == 0)
			{
			}
			Tile tile5;
			ushort type2 = tile5.type;
			if (num == 0)
			{
			}
			Tile tile6;
			ushort type3 = tile6.type;
			if (num == 0)
			{
			}
			Tile tile7;
			ushort type4 = tile7.type;
			if (num == 0)
			{
			}
			Tile tile8;
			ushort wall = tile8.wall;
			if (num == 0)
			{
			}
			Tile tile9;
			ushort wall2 = tile9.wall;
			if (num == 0)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num2 = 6;
			int num3 = 12;
			int num4 = genRand.Next(num2, num3);
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num5 = 6;
			int num6 = 14;
			int num7 = genRand2.Next(num5, num6);
			if (num == 0)
			{
			}
			Tile tile10;
			ushort type5 = tile10.type;
			if (num == 0)
			{
			}
			Tile tile11;
			return tile11.active();
		}

		// Token: 0x06002D1B RID: 11547 RVA: 0x001C78A0 File Offset: 0x001C5AA0
		public static bool DungeonPitTrap(int i, int j, ushort tileType, int wallType)
		{
			if (!true)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num = 8;
			int num2 = 19;
			int num3 = genRand.Next(num, num2);
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num4 = 19;
			int num5 = 46;
			int num6 = genRand2.Next(num4, num5);
			UnifiedRandom genRand3 = WorldGen.genRand;
			int num7 = 6;
			int num8 = 10;
			int num9 = genRand3.Next(num7, num8);
			UnifiedRandom genRand4 = WorldGen.genRand;
			int num10 = 6;
			int num11 = 10;
			int num12 = genRand4.Next(num10, num11);
			Tile tile;
			ushort wall = tile.wall;
			Tile tile2;
			bool flag = tile2.active();
			Tile tile3;
			bool flag2 = tile3.active();
			bool flag3;
			return flag3;
		}

		// Token: 0x06002D1C RID: 11548 RVA: 0x001C7A04 File Offset: 0x001C5C04
		public static void DungeonHalls(int i, int j, ushort tileType, int wallType, bool forceX = false)
		{
			if (!true)
			{
			}
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num2 = 4;
			int num3 = 6;
			int num4 = genRand.Next(num2, num3);
			int num5;
			if (!true)
			{
				num5 = 1;
			}
			if (num5 == 0)
			{
			}
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num6 = 35;
			int num7 = 80;
			int num8 = genRand2.Next(num6, num7);
			UnifiedRandom genRand3 = WorldGen.genRand;
			int num9 = 6;
			int num10 = genRand3.Next(num9);
			if (num5 == 0)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x06002D1D RID: 11549 RVA: 0x001C7F0C File Offset: 0x001C610C
		public static void DungeonRoom(int i, int j, ushort tileType, int wallType)
		{
			if (!true)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num = 15;
			int num2 = 30;
			int num3 = genRand.Next(num, num2);
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num4 = 11;
			int num5 = genRand2.Next(num, num4);
			UnifiedRandom genRand3 = WorldGen.genRand;
			int num6 = 11;
			int num7 = genRand3.Next(num, num6);
			UnifiedRandom genRand4 = WorldGen.genRand;
			int num8 = 10;
			int num9 = 20;
			int num10 = genRand4.Next(num8, num9);
			if (33501184 == 0)
			{
			}
			if (33501184 != 0)
			{
				return;
			}
			if (33501184 == 0)
			{
			}
			if (33501184 == 0)
			{
			}
			if (33501184 == 0)
			{
			}
			if (33501184 == 0)
			{
			}
			long num11 = 0L;
			Tile tile;
			tile.liquid = (byte)num11;
			ushort wall = tile.wall;
			Tile tile2;
			tile2.wall = (ushort)wallType;
			if (33501184 != 0)
			{
				return;
			}
			if (33501184 == 0)
			{
			}
			long num12 = 0L;
			Tile tile3;
			tile3.active(num12 != 0L);
			tile3.wall = (ushort)wallType;
		}

		// Token: 0x06002D1E RID: 11550 RVA: 0x001C802C File Offset: 0x001C622C
		public static void DungeonEnt(int i, int j, ushort tileType, int wallType)
		{
			long num = 0L;
			bool flag = WorldGen.InWorld(0, j, (int)num);
			if (!false)
			{
			}
			long num2 = 0L;
			Tile tile;
			tile.liquid = (byte)num2;
			long num3 = 0L;
			tile.lava(num3 != 0L);
			if (!false)
			{
			}
			long num4 = 32752L;
			if (num4 == 0L)
			{
			}
			if (num4 == 0L)
			{
			}
			if (num4 == 0L)
			{
				if (num4 == 0L)
				{
				}
				if (false)
				{
				}
			}
			if (!false)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num5 = 2;
			int num6 = 5;
			int num7 = genRand.Next(num5, num6);
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num8 = 2;
			int num9 = 5;
			int num10 = genRand2.Next(num8, num9);
			UnifiedRandom genRand3 = WorldGen.genRand;
			int num11 = 2;
			int num12 = 5;
			int num13 = genRand3.Next(num11, num12);
			UnifiedRandom genRand4 = WorldGen.genRand;
			int num14 = 8;
			int num15 = 16;
			int num16 = genRand4.Next(num14, num15);
			if (num16 == 0)
			{
			}
			if (num4 != 0L)
			{
				return;
			}
			if (num16 == 0)
			{
			}
			if (num4 == 0L)
			{
			}
			long num17 = 0L;
			Tile tile2;
			tile2.liquid = (byte)num17;
			ushort wall = tile2.wall;
			UnifiedRandom genRand5 = WorldGen.genRand;
			int num18 = 4;
			int num19 = genRand5.Next(num18);
			UnifiedRandom genRand6 = WorldGen.genRand;
			int num20 = 3;
			int num21 = genRand6.Next(num20);
			long num22 = 0L;
			Tile tile3;
			tile3.liquid = (byte)num22;
			ushort wall2 = tile3.wall;
			UnifiedRandom genRand7 = WorldGen.genRand;
			int num23 = 4;
			int num24 = genRand7.Next(num23);
			UnifiedRandom genRand8 = WorldGen.genRand;
			int num25 = 3;
			int num26 = genRand8.Next(num25);
			long num27 = 0L;
			Tile tile4;
			tile4.liquid = (byte)num27;
			ushort wall3 = tile4.wall;
			UnifiedRandom genRand9 = WorldGen.genRand;
			int num28 = 2;
			int num29 = genRand9.Next(num28);
			UnifiedRandom genRand10 = WorldGen.genRand;
			int num30 = 4;
			int num31 = genRand10.Next(num30);
			long num32 = 0L;
			Tile tile5;
			tile5.liquid = (byte)num32;
			ushort wall4 = tile5.wall;
			if (!false)
			{
			}
			if (num4 == 0L)
			{
			}
			long num33 = 0L;
			Tile tile6;
			tile6.liquid = (byte)num33;
			ushort wall5 = tile6.wall;
			if (false)
			{
				if (num16 != 0)
				{
				}
				return;
			}
			while (num16 != 0)
			{
			}
		}

		// Token: 0x06002D1F RID: 11551 RVA: 0x001C8788 File Offset: 0x001C6988
		public static bool AddBuriedChest(Point point, int contain = 0, bool notNearOtherChests = false, int Style = -1)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06002D20 RID: 11552 RVA: 0x001C879C File Offset: 0x001C699C
		public static bool IsChestRigged(int x, int y)
		{
			/*
An exception occurred when decompiling this method (06002D20)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::IsChestRigged(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0011:
	stloc:int16(var_5_18, callgetter:int16(Tile::get_frameX, ldloc:Tile[exp:valuetype Terraria.Tile&](var_4)))
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

		// Token: 0x06002D21 RID: 11553 RVA: 0x001C87C8 File Offset: 0x001C69C8
		private static bool IsUndergroundDesert(int x, int y)
		{
			/*
An exception occurred when decompiling this method (06002D21)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::IsUndergroundDesert(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0008:
	stloc:uint16(var_3_10, callgetter:uint16(Tile::get_wall, ldloc:Tile[exp:valuetype Terraria.Tile&](var_2)))
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

		// Token: 0x06002D22 RID: 11554 RVA: 0x001C87EC File Offset: 0x001C69EC
		private static bool IsDungeon(int x, int y)
		{
			/*
An exception occurred when decompiling this method (06002D22)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::IsDungeon(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0009:
	stloc:uint16(var_1_0F, callgetter:uint16(Tile::get_wall, ldloc:Tile[exp:valuetype Terraria.Tile&](var_0)))
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

		// Token: 0x06002D23 RID: 11555 RVA: 0x001C8808 File Offset: 0x001C6A08
		public static bool AddBuriedChest(int i, int j, int contain = 0, bool notNearOtherChests = false, int Style = -1, bool trySlope = false, ushort chestTileType = 0)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int num2 = 45;
			if (num == 0)
			{
			}
			if (num2 == 0)
			{
			}
			Tile tile;
			bool flag = tile.shimmer();
			Tile tile2;
			bool flag2 = tile2.active();
			Tile tile3;
			ushort type = tile3.type;
			Tile tile4;
			ushort type2 = tile4.type;
			if (num2 == 0)
			{
			}
			if (num2 == 0)
			{
			}
			long num3 = 0L;
			return WorldGen.SolidTile(0, i, num3 != 0L);
		}

		// Token: 0x06002D24 RID: 11556 RVA: 0x001CA19C File Offset: 0x001C839C
		public static void UnlockDoor(int i, int j)
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
			short frameY = tile2.frameY;
			if (num == 0)
			{
			}
			Tile tile3;
			short frameY2 = tile3.frameY;
		}

		// Token: 0x06002D25 RID: 11557 RVA: 0x001CA1F8 File Offset: 0x001C83F8
		public static bool OpenDoor(int i, int j, int direction)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Tile tile;
			ushort type = tile.type;
			if (num == 0)
			{
			}
			if (4855 == 0)
			{
			}
			Tile tile2;
			TileColorCache tileColorCache = tile2.BlockColorAndCoating();
			Tile tile3;
			TileColorCache tileColorCache2 = tile3.BlockColorAndCoating();
			Tile tile4;
			TileColorCache tileColorCache3 = tile4.BlockColorAndCoating();
			Tile tile5;
			bool flag = tile5.active();
			Tile tile6;
			ushort type2 = tile6.type;
			Tile tile7;
			ushort type3 = tile7.type;
			Tile tile8;
			ushort type4 = tile8.type;
			Tile tile9;
			ushort type5 = tile9.type;
			Tile tile10;
			ushort type6 = tile10.type;
			Tile tile11;
			ushort type7 = tile11.type;
			Tile tile12;
			ushort type8 = tile12.type;
			Tile tile13;
			ushort type9 = tile13.type;
			Tile tile14;
			ushort type10 = tile14.type;
			Tile tile15;
			ushort type11 = tile15.type;
			Tile tile16;
			ushort type12 = tile16.type;
			Tile tile17;
			ushort type13 = tile17.type;
			Tile tile18;
			ushort type14 = tile18.type;
			Tile tile19;
			ushort type15 = tile19.type;
			Tile tile20;
			ushort type16 = tile20.type;
			long num2 = 0L;
			long num3 = 0L;
			long num4 = 0L;
			WorldGen.KillTile(0, 43143168, num2 != 0L, num3 != 0L, num4 != 0L);
			return false;
		}

		// Token: 0x06002D26 RID: 11558 RVA: 0x001CA4B8 File Offset: 0x001C86B8
		public static void Check1xX(int x, int j, short type)
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
				Tile tile;
				short frameX = tile.frameX;
				int num2 = 3;
				Tile tile2;
				short frameY = tile2.frameY;
				if (num2 == 0)
				{
				}
				Tile tile3;
				short frameX2 = tile3.frameX;
				int num3 = 36409;
				if (num3 == 0)
				{
				}
				Tile tile4;
				bool flag = tile4.active();
				if (num3 == 0)
				{
				}
				Tile tile5;
				ushort type2 = tile5.type;
				if (num3 == 0)
				{
				}
				Tile tile6;
				short frameY2 = tile6.frameY;
				if (num3 == 0)
				{
				}
				Tile tile7;
				short frameX3 = tile7.frameX;
				return;
			}
		}

		// Token: 0x06002D27 RID: 11559 RVA: 0x001CA590 File Offset: 0x001C8790
		public static void Check2xX(int i, int j, ushort type)
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
				Tile tile;
				short frameX = tile.frameX;
				if (35 == 0)
				{
				}
				Tile tile2;
				short frameY = tile2.frameY;
				Tile tile3;
				short frameX2 = tile3.frameX;
				Tile tile4;
				short frameY2 = tile4.frameY;
				Tile tile5;
				bool flag = tile5.active();
				Tile tile6;
				ushort type2 = tile6.type;
				Tile tile7;
				short frameY3 = tile7.frameY;
				Tile tile8;
				short frameX3 = tile8.frameX;
				return;
			}
		}

		// Token: 0x06002D28 RID: 11560 RVA: 0x001CA7F8 File Offset: 0x001C89F8
		public static bool IsBelowANonHammeredPlatform(int x, int y)
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
			if (num != 0)
			{
				return;
			}
		}

		// Token: 0x06002D29 RID: 11561 RVA: 0x001CA81C File Offset: 0x001C8A1C
		public static void PlaceTight(int x, int y, bool spiders = false)
		{
			if (!true)
			{
			}
			Tile tile;
			bool flag = tile.shimmer();
			if (!true)
			{
			}
			int num = WorldGen.genRand.Next(2);
			int num2 = WorldGen.genRand.Next(3);
			if (!true)
			{
			}
			Tile tile2;
			ushort type = tile2.type;
			if (!true)
			{
			}
			WorldGen.CheckTight(x, y);
		}

		// Token: 0x06002D2A RID: 11562 RVA: 0x001CA864 File Offset: 0x001C8A64
		public static void PlaceUncheckedStalactite(int x, int y, bool preferSmall, int variation, bool spiders)
		{
			if (!true)
			{
			}
			Tile tile;
			bool flag = tile.active();
			Tile tile2;
			bool flag2 = tile2.active();
			long num = 0L;
			bool flag3 = WorldGen.SolidTile(x, 0, num != 0L);
			Tile tile3;
			bool flag4 = tile3.active();
			Tile tile4;
			bool flag5 = tile4.active();
			Tile tile5;
			ushort type = tile5.type;
			Tile tile6;
			ushort type2 = tile6.type;
			Tile tile7;
			ushort type3 = tile7.type;
			Tile tile8;
			ushort type4 = tile8.type;
			Tile tile9;
			ushort type5 = tile9.type;
			int num2 = 165;
			Tile tile10;
			tile10.type = (ushort)num2;
			int num3 = 1;
			tile10.active(num3 != 0);
			tile10.frameX = (spiders ? 1 : 0);
		}

		// Token: 0x06002D2B RID: 11563 RVA: 0x001CAF40 File Offset: 0x001C9140
		public static bool UpdateStalagtiteStyle(int x, int j)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool netClientOnly = Main.NetClientOnly;
			if (num == 0)
			{
			}
			long num2 = 0L;
			Tile tile;
			bool isLoaded = tile.IsLoaded;
			if (num == 0)
			{
			}
			WorldGen.GetStalagtiteStyle(0, x, x, num2 != 0L);
			long num5;
			if (num == 0)
			{
				if (num == 0)
				{
				}
				if (num == 0)
				{
					if (num == 0)
					{
					}
					UnifiedRandom genRand = WorldGen.genRand;
					int num3 = 3;
					int num4 = genRand.Next(num3);
					if (num == 0)
					{
					}
					Tile tile2;
					tile2.frameX = (short)num5;
					bool netHost = Main.NetHost;
					return false;
				}
			}
			num5 = 0L;
			return false;
		}

		// Token: 0x06002D2C RID: 11564 RVA: 0x001CAFB4 File Offset: 0x001C91B4
		private static void GetDesiredStalagtiteStyle(int x, int j, [Out] bool fail, [Out] int desiredStyle, [Out] int height, [Out] int y)
		{
			int num = 1;
			height.m_value = num;
			y.m_value = j;
			if (num == 0)
			{
			}
			Tile tile;
			short frameY = tile.frameY;
		}

		// Token: 0x06002D2D RID: 11565 RVA: 0x001CB05C File Offset: 0x001C925C
		private static void GetStalagtiteStyle(int x, int y, [Out] int style, [Out] bool fail)
		{
			if (!true)
			{
			}
			Tile tile;
			short frameX = tile.frameX;
		}

		// Token: 0x06002D2E RID: 11566 RVA: 0x001CB094 File Offset: 0x001C9294
		public static void CheckTight(int x, int j)
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
			short frameY = tile2.frameY;
			if (num == 0)
			{
			}
		}

		// Token: 0x06002D2F RID: 11567 RVA: 0x001CB1C4 File Offset: 0x001C93C4
		public static void Place1xX(int x, int y, ushort type, int style = 0)
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
			byte liquid = tile2.liquid;
			bool flag2 = WorldGen.SolidTile2(x, y);
			int num2 = 1;
			Tile tile3;
			tile3.active(num2 != 0);
			tile3.frameY = (short)num2;
			long num3 = 0L;
			tile3.frameX = (short)num3;
			tile3.type = type;
		}

		// Token: 0x06002D30 RID: 11568 RVA: 0x001CB220 File Offset: 0x001C9420
		public static int checkXmasTreeDrop(int x, int y, int obj)
		{
			/*
An exception occurred when decompiling this method (06002D30)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.WorldGen::checkXmasTreeDrop(System.Int32,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0011:
	stloc:int16(var_6_1B, callgetter:int16(Tile::get_frameX, ldloc:Tile[exp:valuetype Terraria.Tile&](var_4)))
	stloc:int16(var_8_24, callgetter:int16(Tile::get_frameY, ldloc:Tile[exp:valuetype Terraria.Tile&](var_7)))
	stloc:int16(var_10_2D, callgetter:int16(Tile::get_frameY, ldloc:Tile[exp:valuetype Terraria.Tile&](var_9)))
	stloc:int16(var_12_36, callgetter:int16(Tile::get_frameY, ldloc:Tile[exp:valuetype Terraria.Tile&](var_11)))
	stloc:int16(var_14_3F, callgetter:int16(Tile::get_frameY, ldloc:Tile[exp:valuetype Terraria.Tile&](var_13)))
	stloc:int16(var_16_48, callgetter:int16(Tile::get_frameY, ldloc:Tile[exp:valuetype Terraria.Tile&](var_15)))
	stloc:int16(var_18_51, callgetter:int16(Tile::get_frameY, ldloc:Tile[exp:valuetype Terraria.Tile&](var_17)))
	stloc:int16(var_20_5A, callgetter:int16(Tile::get_frameY, ldloc:Tile[exp:valuetype Terraria.Tile&](var_19)))
	stloc:int16(var_22_63, callgetter:int16(Tile::get_frameY, ldloc:Tile[exp:valuetype Terraria.Tile&](var_21)))
	stloc:int16(var_24_6C, callgetter:int16(Tile::get_frameY, ldloc:Tile[exp:valuetype Terraria.Tile&](var_23)))
	stloc:int16(var_26_75, callgetter:int16(Tile::get_frameY, ldloc:Tile[exp:valuetype Terraria.Tile&](var_25)))
	stloc:int16(var_28_7E, callgetter:int16(Tile::get_frameY, ldloc:Tile[exp:valuetype Terraria.Tile&](var_27)))
	stloc:int16(var_30_87, callgetter:int16(Tile::get_frameY, ldloc:Tile[exp:valuetype Terraria.Tile&](var_29)))
	stloc:int16(var_32_90, callgetter:int16(Tile::get_frameY, ldloc:Tile[exp:valuetype Terraria.Tile&](var_31)))
	stloc:int16(var_34_99, callgetter:int16(Tile::get_frameY, ldloc:Tile[exp:valuetype Terraria.Tile&](var_33)))
	brtrue(IL_0000, callgetter:int16[exp:bool](Tile::get_frameY, ldloc:Tile[exp:valuetype Terraria.Tile&](var_35)))
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

		// Token: 0x06002D31 RID: 11569 RVA: 0x001CB2D4 File Offset: 0x001C94D4
		public static void dropXmasTree(int x, int y, int obj)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Tile tile;
			short frameX = tile.frameX;
			if (num == 0)
			{
			}
			Tile tile2;
			short frameX2 = tile2.frameX;
			Tile tile3;
			short frameY = tile3.frameY;
			Tile tile4;
			short frameY2 = tile4.frameY;
			Tile tile5;
			short frameY3 = tile5.frameY;
			Tile tile6;
			short frameY4 = tile6.frameY;
			Tile tile7;
			short frameY5 = tile7.frameY;
			Tile tile8;
			short frameY6 = tile8.frameY;
			Tile tile9;
			short frameY7 = tile9.frameY;
			Tile tile10;
			short frameY8 = tile10.frameY;
			Tile tile11;
			short frameY9 = tile11.frameY;
			Tile tile12;
			short frameY10 = tile12.frameY;
			Tile tile13;
			short frameY11 = tile13.frameY;
			Tile tile14;
			short frameY12 = tile14.frameY;
			Tile tile15;
			short frameY13 = tile15.frameY;
			Tile tile16;
			short frameY14 = tile16.frameY;
			Tile tile17;
			short frameY15 = tile17.frameY;
			if (x != 0)
			{
				return;
			}
			if (x != 0)
			{
				return;
			}
			if (x != 0)
			{
				return;
			}
			if (frameY13 != 0)
			{
				bool netClientOnly = Main.NetClientOnly;
			}
		}

		// Token: 0x06002D32 RID: 11570 RVA: 0x001CB3A0 File Offset: 0x001C95A0
		public static void setXmasTree(int x, int y, int obj, int style)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Tile tile;
			short frameX = tile.frameX;
			if (num == 0)
			{
			}
			Tile tile2;
			short frameX2 = tile2.frameX;
			Tile tile3;
			short frameY = tile3.frameY;
		}

		// Token: 0x06002D33 RID: 11571 RVA: 0x001CB400 File Offset: 0x001C9600
		public static int PlaceXmasTree_Direct(int x, int y, int type, int style, int dir, int alternate)
		{
			/*
An exception occurred when decompiling this method (06002D33)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.WorldGen::PlaceXmasTree_Direct(System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0009:
	stloc:int32(var_4_0A, ldc.i4:int32(1))
	call:void(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_3), ldloc:int32[exp:bool](var_4_0A))
	callsetter:uint16(Tile::set_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_3), ldloc:int32[exp:uint16](y))
	callsetter:int16(Tile::set_frameX, ldloc:Tile[exp:valuetype Terraria.Tile&](var_3), ldloc:int32[exp:int16](y))
	callsetter:int16(Tile::set_frameY, ldloc:Tile[exp:valuetype Terraria.Tile&](var_3), ldloc:int32[exp:int16](y))
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

		// Token: 0x06002D34 RID: 11572 RVA: 0x001CB438 File Offset: 0x001C9638
		public static void PlaceXmasTree(int x, int y, ushort type = 171)
		{
			if (!true)
			{
			}
			long num = 0L;
			Tile tile;
			bool flag = tile.active();
			long num2 = 0L;
			bool flag2 = WorldGen.SolidTile(43143168, (int)num, num2 != 0L);
			long num3 = 0L;
			int num4 = 1;
			Tile tile2;
			tile2.active(num4 != 0);
			tile2.frameX = (short)num3;
		}

		// Token: 0x06002D35 RID: 11573 RVA: 0x001CB4B4 File Offset: 0x001C96B4
		public static void CheckXmasTree(int x, int y)
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
				Tile tile;
				short frameX = tile.frameX;
				if (num == 0)
				{
				}
				Tile tile2;
				short frameX2 = tile2.frameX;
				Tile tile3;
				short frameY = tile3.frameY;
				long num2 = 0L;
				int num3 = 65527;
				long num4 = 0L;
				if (num3 == 0)
				{
				}
				Tile tile4;
				bool flag = tile4.active();
				if (num3 == 0)
				{
				}
				Tile tile5;
				ushort type = tile5.type;
				if (num2 != 0L && num4 != 0L)
				{
					if (num3 == 0)
					{
					}
					Tile tile6;
					short frameX3 = tile6.frameX;
					if (num3 == 0)
					{
					}
					Tile tile7;
					short frameY2 = tile7.frameY;
					return;
				}
				bool flag2 = WorldGen.SolidTile2(x, y);
				Tile tile8;
				ushort type2 = tile8.type;
				long num5 = 0L;
				long num6 = 0L;
				long num7 = 0L;
				WorldGen.KillTile(x, y, num5 != 0L, num6 != 0L, num7 != 0L);
			}
		}

		// Token: 0x06002D36 RID: 11574 RVA: 0x001CB578 File Offset: 0x001C9778
		public static void Place2xX(int x, int y, ushort type, int style = 0)
		{
		}

		// Token: 0x06002D37 RID: 11575 RVA: 0x001CB604 File Offset: 0x001C9804
		public static int GetItemDrop_Benches(int style)
		{
			return 335;
		}

		// Token: 0x06002D38 RID: 11576 RVA: 0x001CB618 File Offset: 0x001C9818
		public static int GetItemDrop_PicnicTables(int style)
		{
			return 4064;
		}

		// Token: 0x06002D39 RID: 11577 RVA: 0x001CB62C File Offset: 0x001C982C
		public static int GetItemDrop_Chair(int style)
		{
			return 34;
		}

		// Token: 0x06002D3A RID: 11578 RVA: 0x001CB63C File Offset: 0x001C983C
		public static int GetItemDrop_Toilet(int style)
		{
		}

		// Token: 0x06002D3B RID: 11579 RVA: 0x001CB650 File Offset: 0x001C9850
		public static void Check1x2(int x, int j, ushort type)
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
			Tile tile;
			short frameY = tile.frameY;
		}

		// Token: 0x06002D3C RID: 11580 RVA: 0x001CB7C8 File Offset: 0x001C99C8
		public static void CheckOnTable1x1(int x, int y, int type)
		{
			if (!true)
			{
			}
			Tile tile;
			bool flag = tile.topSlope();
			Tile tile2;
			ushort type2 = tile2.type;
			Tile tile3;
			int num = tile3.blockType();
			Tile tile4;
			bool flag2 = tile4.active();
			Tile tile5;
			if (tile5.blockType() == 0)
			{
				Tile tile6;
				ushort type3 = tile6.type;
				return;
			}
			Tile tile7;
			int num2 = tile7.blockType();
			Tile tile8;
			bool flag3 = tile8.active();
			Tile tile9;
			if (tile9.blockType() == 0)
			{
				Tile tile10;
				ushort type4 = tile10.type;
				return;
			}
			long num3 = 0L;
			long num4 = 0L;
			long num5 = 0L;
			WorldGen.KillTile(x, y, num3 != 0L, num4 != 0L, num5 != 0L);
		}

		// Token: 0x06002D3D RID: 11581 RVA: 0x001CB86C File Offset: 0x001C9A6C
		public static void CheckSign(int x, int y, ushort type)
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
			Tile tile;
			short frameX = tile.frameX;
			Tile tile2;
			short frameY = tile2.frameY;
			Tile tile3;
			short frameX2 = tile3.frameX;
			Tile tile4;
			short frameY2 = tile4.frameY;
			Tile tile5;
			short frameX3 = tile5.frameX;
		}

		// Token: 0x06002D3E RID: 11582 RVA: 0x001CBB00 File Offset: 0x001C9D00
		public static bool PlaceSign(int x, int y, ushort type, int Style = 0)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06002D3F RID: 11583 RVA: 0x001CBC50 File Offset: 0x001C9E50
		public static bool Place2x2Horizontal(int x, int y, ushort type, int Style = 0)
		{
			/*
An exception occurred when decompiling this method (06002D3F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::Place2x2Horizontal(System.Int32,System.Int32,System.UInt16,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_07, call:bool(WorldGen::SolidTile2, ldc.i4:int32(0), ldc.i4:int32(0)))
	stloc:bool(var_1_0F, call:bool(WorldGen::SolidTile2, ldc.i4:int32(0), ldc.i4:int32(0)))
	stloc:bool(var_3_16, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_2)))
	stloc:bool(var_6_21, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_4)))
	stloc:bool(var_8_2A, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_7)))
	stloc:bool(var_10_33, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_9)))
	stloc:int32(var_15_3F, ldc.i4:int32(1))
	call:void(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_14), ldloc:int32[exp:bool](var_15_3F))
	callsetter:uint16(Tile::set_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_14), ldloc:int32[exp:uint16](y))
	callsetter:int16(Tile::set_frameX, ldloc:Tile[exp:valuetype Terraria.Tile&](var_14), ldloc:int32[exp:int16](x))
	callsetter:int16(Tile::set_frameY, ldloc:Tile[exp:valuetype Terraria.Tile&](var_14), ldloc:int32[exp:int16](x))
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

		// Token: 0x06002D40 RID: 11584 RVA: 0x001CBCC4 File Offset: 0x001C9EC4
		public static Color paintColor(int color)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06002D41 RID: 11585 RVA: 0x001CBCD8 File Offset: 0x001C9ED8
		public static Color coatingColor(int coating)
		{
			return 1;
		}

		// Token: 0x06002D42 RID: 11586 RVA: 0x001CBCF0 File Offset: 0x001C9EF0
		public static List<Color> coatingColors(Tile tile, bool block)
		{
			/*
An exception occurred when decompiling this method (06002D42)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.List`1<Microsoft.Xna.Framework.Graphics.Color> Terraria.WorldGen::coatingColors(Terraria.Tile,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0012:
	stloc:Color(var_6_18, call:Color(WorldGen::coatingColor, ldc.i4:int32(2)))
	brtrue(IL_0000, ldloc:int32[exp:bool](var_0_01))
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

		// Token: 0x06002D43 RID: 11587 RVA: 0x001CBD1C File Offset: 0x001C9F1C
		public static void paintEffect(int x, int y, byte color, byte oldColor)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Color color2 = WorldGen.paintColor((int)oldColor);
			if (num == 0)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num2 = 2;
			if (genRand.Next(num2) == 0)
			{
			}
		}

		// Token: 0x06002D44 RID: 11588 RVA: 0x001CBD50 File Offset: 0x001C9F50
		public static void paintCoatEffect(int x, int y, byte paintCoatId, List<Color> oldColors)
		{
			if (!true)
			{
			}
			Color color = WorldGen.coatingColor(0);
			if (oldColors._size == 0)
			{
			}
			int size = oldColors._size;
			UnifiedRandom genRand = WorldGen.genRand;
			int num = 2;
			if (genRand.Next(num) == 0)
			{
			}
		}

		// Token: 0x06002D45 RID: 11589 RVA: 0x001CBD90 File Offset: 0x001C9F90
		public static bool paintTile(int x, int y, byte color, bool broadCast = false)
		{
			if (!true)
			{
			}
			Tile tile;
			bool isLoaded = tile.IsLoaded;
			long num = 0L;
			WorldGen.paintEffect(0, x, (byte)y, (byte)num);
			return true;
		}

		// Token: 0x06002D46 RID: 11590 RVA: 0x001CBDB8 File Offset: 0x001C9FB8
		public static bool paintCoatTile(int x, int y, byte paintCoatId, bool broadcast = false)
		{
			if (!true)
			{
			}
			Tile tile;
			bool flag = tile.active();
			if (!true)
			{
			}
			if (!true)
			{
				bool flag2;
				return flag2;
			}
			List<Color> list;
			WorldGen.paintCoatEffect(0, x, (byte)y, list);
			return true;
		}

		// Token: 0x06002D47 RID: 11591 RVA: 0x001CBDFC File Offset: 0x001C9FFC
		public static bool paintCoatWall(int x, int y, byte paintCoatId, bool broadcast = false)
		{
			if (!true)
			{
			}
			Tile tile;
			ushort wall = tile.wall;
			if (!true)
			{
			}
			bool flag;
			return true || flag;
		}

		// Token: 0x06002D48 RID: 11592 RVA: 0x001CBE40 File Offset: 0x001CA040
		public static bool paintWall(int x, int y, byte color, bool broadCast = false)
		{
			if (!true)
			{
			}
			Tile tile;
			bool isLoaded = tile.IsLoaded;
			long num = 0L;
			WorldGen.paintEffect(0, x, (byte)y, (byte)num);
			return true;
		}

		// Token: 0x06002D49 RID: 11593 RVA: 0x001CBE68 File Offset: 0x001CA068
		public static void Place3x3Wall(int x, int y, ushort type, int style)
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
			ushort wall = tile2.wall;
		}

		// Token: 0x06002D4A RID: 11594 RVA: 0x001CBEB4 File Offset: 0x001CA0B4
		public static void Check3x3Wall(int x, int y)
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
				Tile tile;
				ushort type = tile.type;
				return;
			}
		}

		// Token: 0x06002D4B RID: 11595 RVA: 0x001CBF90 File Offset: 0x001CA190
		public static void Place2x3Wall(int x, int y, ushort type, int style)
		{
			int num = 65533;
			if (num == 0)
			{
			}
			Tile tile;
			bool flag = tile.active();
			if (num == 0)
			{
			}
			Tile tile2;
			ushort wall = tile2.wall;
		}

		// Token: 0x06002D4C RID: 11596 RVA: 0x001CBFDC File Offset: 0x001CA1DC
		public static void Check2x3Wall(int x, int y)
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
				Tile tile;
				ushort type = tile.type;
				Tile tile2;
				short frameX = tile2.frameX;
				return;
			}
		}

		// Token: 0x06002D4D RID: 11597 RVA: 0x001CC0DC File Offset: 0x001CA2DC
		public static void Place3x2Wall(int x, int y, ushort type, int style)
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
			ushort wall = tile2.wall;
		}

		// Token: 0x06002D4E RID: 11598 RVA: 0x001CC138 File Offset: 0x001CA338
		public static void Check3x2Wall(int x, int y)
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
				Tile tile;
				ushort type = tile.type;
				Tile tile2;
				short frameY = tile2.frameY;
				return;
			}
		}

		// Token: 0x06002D4F RID: 11599 RVA: 0x001CC22C File Offset: 0x001CA42C
		public static void Place4x3Wall(int x, int y, ushort type, int style)
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
			ushort wall = tile2.wall;
		}

		// Token: 0x06002D50 RID: 11600 RVA: 0x001CC27C File Offset: 0x001CA47C
		public static void Check4x3Wall(int x, int y)
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
				Tile tile;
				ushort type = tile.type;
				Tile tile2;
				short frameY = tile2.frameY;
				return;
			}
		}

		// Token: 0x06002D51 RID: 11601 RVA: 0x001CC360 File Offset: 0x001CA560
		public static void Place6x4Wall(int x, int y, ushort type, int style)
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
			ushort wall = tile2.wall;
		}

		// Token: 0x06002D52 RID: 11602 RVA: 0x001CC3AC File Offset: 0x001CA5AC
		public static void Check6x4Wall(int x, int y)
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
				Tile tile;
				ushort type = tile.type;
				Tile tile2;
				short frameY = tile2.frameY;
				Tile tile3;
				short frameX = tile3.frameX;
				Tile tile4;
				short frameX2 = tile4.frameX;
				int num2 = 65529;
				if (num2 == 0)
				{
				}
				Tile tile5;
				ushort type2 = tile5.type;
				if (num2 == 0)
				{
				}
				Tile tile6;
				bool flag = tile6.active();
				if (num2 == 0)
				{
				}
				Tile tile7;
				ushort wall = tile7.wall;
				if (num2 == 0)
				{
				}
				Tile tile8;
				short frameY2 = tile8.frameY;
				if (num2 == 0)
				{
				}
				Tile tile9;
				short frameX3 = tile9.frameX;
				return;
			}
		}

		// Token: 0x06002D53 RID: 11603 RVA: 0x001CC4DC File Offset: 0x001CA6DC
		private static int RollRandomSeaShellStyle()
		{
			if (!true)
			{
			}
			int num = WorldGen.genRand.Next(2);
			int num2 = WorldGen.genRand.Next(10);
			int num3 = WorldGen.genRand.Next(10);
			return WorldGen.genRand.Next(50);
		}

		// Token: 0x06002D54 RID: 11604 RVA: 0x001CC520 File Offset: 0x001CA720
		public static void Place1x1(int x, int y, int type, int style = 0)
		{
			if (!true)
			{
			}
			bool flag = WorldGen.SolidTile2(x, y);
			Tile tile;
			bool flag2 = tile.nactive();
			Tile tile2;
			ushort type2 = tile2.type;
			UnifiedRandom genRand = WorldGen.genRand;
			int num = 3;
			int num2 = genRand.Next(num);
		}

		// Token: 0x06002D55 RID: 11605 RVA: 0x001CC570 File Offset: 0x001CA770
		public static void Check1x1(int x, int y, int type)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			bool flag = WorldGen.SolidTileAllowBottomSlope(x, int.MinValue);
			if (num == 0)
			{
			}
			long num2 = 0L;
			long num3 = 0L;
			long num4 = 0L;
			WorldGen.KillTile(x, y, num2 != 0L, num3 != 0L, num4 != 0L);
			if (num == 0)
			{
			}
			bool flag2 = WorldGen.HasValidGroundForAbigailsFlowerBelowSpot(x, y);
		}

		// Token: 0x06002D56 RID: 11606 RVA: 0x001CC5D0 File Offset: 0x001CA7D0
		public static void CheckGolf1x1(int x, int y, int type)
		{
			if (!true)
			{
			}
			Tile tile;
			short frameX = tile.frameX;
			int num = 36409;
			long num2 = 0L;
			bool flag = WorldGen.SolidTileAllowBottomSlope(x, (int)num2);
			if (num == 0)
			{
			}
			short num3;
			if (num3 == 0)
			{
			}
			long num4 = 0L;
			long num5 = 0L;
			long num6 = 0L;
			WorldGen.KillTile(x, y, num4 != 0L, num5 != 0L, num6 != 0L);
		}

		// Token: 0x06002D57 RID: 11607 RVA: 0x001CC618 File Offset: 0x001CA818
		public static void CheckLogicTiles(int x, int y, int type)
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
			short frameX = tile2.frameX;
			if (num != 0)
			{
				if (num == 0)
				{
				}
				long num2 = 0L;
				long num3 = 0L;
				long num4 = 0L;
				WorldGen.KillTile(x, y, num2 != 0L, num3 != 0L, num4 != 0L);
			}
		}

		// Token: 0x06002D58 RID: 11608 RVA: 0x001CC65C File Offset: 0x001CA85C
		public static void PlaceLogicTiles(int x, int y, int type, int style = 0)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Tile tile;
			bool flag = tile.active();
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
		}

		// Token: 0x06002D59 RID: 11609 RVA: 0x001CC6A4 File Offset: 0x001CA8A4
		public static void PlaceOnTable1x1(int x, int y, int type, int style = 0)
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
			bool flag2 = tile2.nactive();
			if (num == 0)
			{
			}
			Tile tile3;
			ushort type2 = tile3.type;
		}

		// Token: 0x06002D5A RID: 11610 RVA: 0x001CC770 File Offset: 0x001CA970
		public static bool PlaceAlch(int x, int y, int style)
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
			bool flag2 = tile2.nactive();
			if (num == 0)
			{
			}
			Tile tile3;
			bool flag3 = tile3.halfBrick();
			if (num == 0)
			{
			}
			Tile tile4;
			byte b = tile4.slope();
			if (y == 0)
			{
			}
			Tile tile5;
			ushort type = tile5.type;
			if (y == 0)
			{
			}
			Tile tile6;
			ushort type2 = tile6.type;
			if (y == 0)
			{
			}
			Tile tile7;
			ushort type3 = tile7.type;
			if (y == 0)
			{
			}
			Tile tile8;
			ushort type4 = tile8.type;
			if (y == 0)
			{
			}
			Tile tile9;
			ushort type5 = tile9.type;
			if (y == 0)
			{
			}
			Tile tile10;
			ushort type6 = tile10.type;
			if (y == 0)
			{
			}
			Tile tile11;
			ushort type7 = tile11.type;
			if (y == 0)
			{
			}
			Tile tile12;
			ushort type8 = tile12.type;
			if (y == 0)
			{
			}
			Tile tile13;
			ushort type9 = tile13.type;
			if (y == 0)
			{
			}
			Tile tile14;
			ushort type10 = tile14.type;
			if (y == 0)
			{
			}
			Tile tile15;
			ushort type11 = tile15.type;
			if (y == 0)
			{
			}
			Tile tile16;
			ushort type12 = tile16.type;
			if (y == 0)
			{
			}
			Tile tile17;
			ushort type13 = tile17.type;
			if (y == 0)
			{
			}
			Tile tile18;
			ushort type14 = tile18.type;
			if (y == 0)
			{
			}
			Tile tile19;
			ushort type15 = tile19.type;
			if (y == 0)
			{
			}
			Tile tile20;
			ushort type16 = tile20.type;
			if (y == 0)
			{
			}
			Tile tile21;
			ushort type17 = tile21.type;
			if (y == 0)
			{
			}
			Tile tile22;
			byte liquid = tile22.liquid;
			if (y == 0)
			{
			}
			int num2 = 1;
			Tile tile23;
			tile23.active(num2 != 0);
			int num3 = 82;
			tile23.type = (ushort)num3;
			tile23.frameX = (short)num3;
			long num4 = 0L;
			tile23.frameY = (short)num4;
			if (y == 0)
			{
			}
			Tile tile24;
			ushort type18 = tile24.type;
			if (y == 0)
			{
			}
			Tile tile25;
			ushort type19 = tile25.type;
			if (y == 0)
			{
			}
			Tile tile26;
			ushort type20 = tile26.type;
			if (y == 0)
			{
			}
			Tile tile27;
			ushort type21 = tile27.type;
			if (y == 0)
			{
			}
			Tile tile28;
			ushort type22 = tile28.type;
			if (y == 0)
			{
			}
			Tile tile29;
			ushort type23 = tile29.type;
			if (y == 0)
			{
			}
			Tile tile30;
			ushort type24 = tile30.type;
			long num5 = 0L;
			if (y == 0)
			{
			}
			Tile tile31;
			byte liquid2 = tile31.liquid;
			if (y == 0)
			{
			}
			Tile tile32;
			bool flag4 = tile32.lava();
			while (num5 != 0L)
			{
			}
			return flag4;
		}

		// Token: 0x06002D5B RID: 11611 RVA: 0x001CCA30 File Offset: 0x001CAC30
		public static void GrowSpike(int i, int j, ushort spikeType, ushort landType)
		{
			int num = 661;
			Tile tile;
			bool flag = tile.active();
			if (num == 0)
			{
			}
			Tile tile2;
			ushort type = tile2.type;
		}

		// Token: 0x06002D5C RID: 11612 RVA: 0x001CCC04 File Offset: 0x001CAE04
		private static bool GrowMoreVines(int x, int y)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int num2 = 30;
			bool flag = WorldGen.InWorld(0, x, num2);
			if (num == 0)
			{
			}
			int num3 = 12;
			bool flag2;
			if (num3 != 0)
			{
				return flag2;
			}
			return flag2;
		}

		// Token: 0x06002D5D RID: 11613 RVA: 0x001CCC44 File Offset: 0x001CAE44
		private static void GrowGlowTulips()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002D5E RID: 11614 RVA: 0x001CCCE8 File Offset: 0x001CAEE8
		private static void MatureTheHerbPlants()
		{
			int num = 1;
			int num2 = 10;
			if (num == 0)
			{
			}
			int num3 = 11;
			if (num == 0)
			{
			}
			Tile tile;
			ushort type = tile.type;
			Tile tile2;
			ushort type2 = tile2.type;
			long num4 = 0L;
			bool flag = WorldGen.SolidTile(num2, num3, num4 != 0L);
			UnifiedRandom genRand = WorldGen.genRand;
			int num5 = 25;
			if (genRand.Next(num5) == 0)
			{
			}
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num6 = 3;
			if (genRand2.Next(num6) == 0)
			{
				UnifiedRandom genRand3 = WorldGen.genRand;
				int num7 = 2;
				if (genRand3.Next(num7) == 0)
				{
				}
				UnifiedRandom genRand4 = WorldGen.genRand;
				int num8 = 3;
				if (genRand4.Next(num8) == 0)
				{
				}
			}
		}

		// Token: 0x06002D5F RID: 11615 RVA: 0x001CCD94 File Offset: 0x001CAF94
		public static void GrowAlch(int x, int y)
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
			long num2 = 0L;
			long num3 = 0L;
			long num4 = 0L;
			WorldGen.KillTile(x, y, num2 != 0L, num3 != 0L, num4 != 0L);
			if (num == 0)
			{
			}
			bool netHost = Main.NetHost;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int num5 = 1;
			WorldGen.SquareTileFrame(x, y, num5 != 0);
			if (num == 0)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num6 = 50;
			if (genRand.Next(num6) != 0)
			{
				if (num == 0)
				{
				}
				if (num != 0)
				{
					if (num == 0)
					{
					}
					UnifiedRandom genRand2 = WorldGen.genRand;
					int num7 = 50;
					if (genRand2.Next(num7) == 0)
					{
						goto IL_0156;
					}
				}
				if (num == 0)
				{
				}
				if (num == 0)
				{
					if (num == 0)
					{
					}
					UnifiedRandom genRand3 = WorldGen.genRand;
					int num8 = 50;
					if (genRand3.Next(num8) == 0)
					{
						goto IL_0156;
					}
				}
				if (num == 0)
				{
				}
				if (num != 0)
				{
					if (num == 0)
					{
					}
					UnifiedRandom genRand4 = WorldGen.genRand;
					int num9 = 50;
					if (genRand4.Next(num9) == 0)
					{
						goto IL_0156;
					}
				}
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				UnifiedRandom genRand5 = WorldGen.genRand;
				int num10 = 50;
				if (genRand5.Next(num10) != 0)
				{
					if (num == 0)
					{
					}
					if (num == 0)
					{
					}
					UnifiedRandom genRand6 = WorldGen.genRand;
					return;
				}
			}
			else
			{
				if (num == 0)
				{
				}
				UnifiedRandom genRand7 = WorldGen.genRand;
				int num11 = 2;
				if (genRand7.Next(num11) != 0)
				{
					return;
				}
			}
			IL_0156:
			if (num == 0)
			{
			}
			bool netHost2 = Main.NetHost;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int num12 = 1;
			WorldGen.SquareTileFrame(x, y, num12 != 0);
		}

		// Token: 0x06002D60 RID: 11616 RVA: 0x001CCF4C File Offset: 0x001CB14C
		public static void PlantAlch()
		{
			if (!true)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			UnifiedRandom genRand2 = WorldGen.genRand;
			Tile tile;
			bool flag = tile.active();
		}

		// Token: 0x06002D61 RID: 11617 RVA: 0x001CD108 File Offset: 0x001CB308
		public static void CheckAlch(int x, int y)
		{
			if (!true)
			{
			}
			Tile tile;
			bool flag = tile.nactive();
			Tile tile2;
			bool flag2 = tile2.halfBrick();
			Tile tile3;
			ushort type = tile3.type;
		}

		// Token: 0x06002D62 RID: 11618 RVA: 0x001CD27C File Offset: 0x001CB47C
		public static void CheckBanner(int x, int j, byte type)
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
				Tile tile;
				short frameY = tile.frameY;
				return;
			}
		}

		// Token: 0x06002D63 RID: 11619 RVA: 0x001CD368 File Offset: 0x001CB568
		public static void PlaceBanner(int x, int y, ushort type, int style = 0)
		{
			int num = 1;
			if (63916 == 0)
			{
			}
			Tile tile;
			bool flag = tile.nactive();
			if (num == 0)
			{
			}
			Tile tile2;
			ushort type2 = tile2.type;
			if (num != 0)
			{
				if (num == 0)
				{
				}
				Tile tile3;
				ushort type3 = tile3.type;
				if (num == 0)
				{
					if (num == 0)
					{
					}
					Tile tile4;
					bool flag2 = tile4.active();
					if (num == 0)
					{
					}
					Tile tile5;
					bool flag3 = tile5.active();
					if (num == 0)
					{
					}
					Tile tile6;
					bool flag4 = tile6.active();
					if (num == 0)
					{
					}
					int num2 = 1;
					Tile tile7;
					tile7.active(num2 != 0);
					tile7.frameX = (short)style;
					tile7.type = type;
					int num3 = 1;
					Tile tile8;
					tile8.active(num3 != 0);
					tile8.frameY = (short)num3;
					tile8.frameX = (short)style;
					tile8.type = type;
					int num4 = 1;
					Tile tile9;
					tile9.active(num4 != 0);
					tile9.frameY = (short)num4;
					tile9.frameX = (short)style;
					tile9.type = type;
				}
			}
		}

		// Token: 0x06002D64 RID: 11620 RVA: 0x001CD43C File Offset: 0x001CB63C
		public static void PlaceMan(int i, int j, int dir)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool flag = WorldGen.SolidTile2(i, j);
			if (num == 0)
			{
			}
			bool flag2 = WorldGen.SolidTile2(0, j);
			if (num == 0)
			{
			}
			int num2 = 1;
			Tile tile;
			tile.active(num2 != 0);
			long num3 = 0L;
			tile.frameY = (short)num3;
			tile.frameX = (short)dir;
			int num4 = 128;
			tile.type = (ushort)num4;
			int num5 = 1;
			Tile tile2;
			tile2.active(num5 != 0);
			int num6 = 18;
			tile2.frameY = (short)num6;
			tile2.frameX = (short)dir;
			int num7 = 128;
			tile2.type = (ushort)num7;
			int num8 = 1;
			Tile tile3;
			tile3.active(num8 != 0);
			int num9 = 36;
			tile3.frameY = (short)num9;
			tile3.frameX = (short)dir;
			int num10 = 128;
			tile3.type = (ushort)num10;
			int num11 = 1;
			Tile tile4;
			tile4.active(num11 != 0);
			long num12 = 0L;
			tile4.frameY = (short)num12;
			tile4.frameX = (short)i;
			int num13 = 128;
			tile4.type = (ushort)num13;
			int num14 = 1;
			Tile tile5;
			tile5.active(num14 != 0);
			int num15 = 18;
			tile5.frameY = (short)num15;
			tile5.frameX = (short)i;
			int num16 = 128;
			tile5.type = (ushort)num16;
			int num17 = 1;
			Tile tile6;
			tile6.active(num17 != 0);
			int num18 = 36;
			tile6.frameY = (short)num18;
			tile6.frameX = (short)i;
			int num19 = 128;
			tile6.type = (ushort)num19;
		}

		// Token: 0x06002D65 RID: 11621 RVA: 0x001CD59C File Offset: 0x001CB79C
		public static void PlaceWoman(int i, int j, int dir)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool flag = WorldGen.SolidTile2(i, j);
			if (num == 0)
			{
			}
			bool flag2 = WorldGen.SolidTile2(0, j);
			if (num == 0)
			{
			}
			int num2 = 1;
			Tile tile;
			tile.active(num2 != 0);
			long num3 = 0L;
			tile.frameY = (short)num3;
			tile.frameX = (short)dir;
			int num4 = 269;
			tile.type = (ushort)num4;
			int num5 = 1;
			Tile tile2;
			tile2.active(num5 != 0);
			int num6 = 18;
			tile2.frameY = (short)num6;
			tile2.frameX = (short)dir;
			int num7 = 269;
			tile2.type = (ushort)num7;
			int num8 = 1;
			Tile tile3;
			tile3.active(num8 != 0);
			int num9 = 36;
			tile3.frameY = (short)num9;
			tile3.frameX = (short)dir;
			int num10 = 269;
			tile3.type = (ushort)num10;
			int num11 = 1;
			Tile tile4;
			tile4.active(num11 != 0);
			long num12 = 0L;
			tile4.frameY = (short)num12;
			tile4.frameX = (short)i;
			int num13 = 269;
			tile4.type = (ushort)num13;
			int num14 = 1;
			Tile tile5;
			tile5.active(num14 != 0);
			int num15 = 18;
			tile5.frameY = (short)num15;
			tile5.frameX = (short)i;
			int num16 = 269;
			tile5.type = (ushort)num16;
			int num17 = 1;
			Tile tile6;
			tile6.active(num17 != 0);
			int num18 = 36;
			tile6.frameY = (short)num18;
			tile6.frameX = (short)i;
			int num19 = 269;
			tile6.type = (ushort)num19;
		}

		// Token: 0x06002D66 RID: 11622 RVA: 0x001CD6FC File Offset: 0x001CB8FC
		public static void CheckWeaponsRack(int i, int j)
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
				Tile tile;
				short frameY = tile.frameY;
				Tile tile2;
				short frameX = tile2.frameX;
				int num2 = 4855;
				long num3 = 0L;
				Tile tile3;
				short frameX2 = tile3.frameX;
				Tile tile4;
				bool flag = tile4.active();
				Tile tile5;
				ushort type = tile5.type;
				Tile tile6;
				ushort wall = tile6.wall;
				int num4 = 4855;
				if (num2 == 0)
				{
				}
				Tile tile7;
				int num5 = TEWeaponsRack.Find((int)tile7.frameY, 43143168);
				if (num4 == 0)
				{
				}
				Player localPlayer = Main.LocalPlayer;
				int num6 = 471;
				localPlayer.InterruptItemUsageIfOverTile(num6);
				int num7;
				TEWeaponsRack.Kill(num7, 43143168);
				Tile tile8;
				bool flag2 = tile8.active();
				Tile tile9;
				ushort type2 = tile9.type;
				long num8 = 0L;
				long num9 = 0L;
				long num10 = 0L;
				WorldGen.KillTile((int)num3, j, num8 != 0L, num9 != 0L, num10 != 0L);
			}
		}

		// Token: 0x06002D67 RID: 11623 RVA: 0x001CD7E4 File Offset: 0x001CB9E4
		public static void ToggleGemLock(int i, int j, bool on)
		{
			bool flag = Framing.GetTileSafely(i, j).active();
			Tile tile;
			short frameX = tile.frameX;
			Tile tile2;
			short frameX2 = tile2.frameX;
			Tile tile3;
			short frameY = tile3.frameY;
		}

		// Token: 0x06002D68 RID: 11624 RVA: 0x001CD868 File Offset: 0x001CBA68
		public static void CheckMan(int i, int j)
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
				Tile tile;
				short frameY = tile.frameY;
				Tile tile2;
				short frameX = tile2.frameX;
				int num2 = 34079;
				int num3 = 100;
				Tile tile3;
				short frameX2 = tile3.frameX;
				Tile tile4;
				bool flag = tile4.active();
				if (frameX2 == 0)
				{
				}
				Tile tile5;
				ushort type = tile5.type;
				if (frameX2 == 0)
				{
				}
				long num4 = 0L;
				Tile tile6;
				short frameY2 = tile6.frameY;
				if (frameX2 == 0)
				{
				}
				bool flag2 = WorldGen.SolidTileAllowBottomSlope(0, (int)num4);
				if (frameX2 == 0)
				{
				}
				bool flag3 = WorldGen.SolidTileAllowBottomSlope(0, (int)num4);
				if (frameX2 == 0)
				{
				}
				Tile tile7;
				bool flag4 = tile7.active();
				Tile tile8;
				ushort type2 = tile8.type;
				long num5 = 0L;
				long num6 = 0L;
				long num7 = 0L;
				WorldGen.KillTile(num2, num3, num5 != 0L, num6 != 0L, num7 != 0L);
			}
		}

		// Token: 0x06002D69 RID: 11625 RVA: 0x001CD938 File Offset: 0x001CBB38
		public static void CheckWoman(int i, int j)
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
				Tile tile;
				short frameY = tile.frameY;
				Tile tile2;
				short frameX = tile2.frameX;
				int num2 = 34079;
				int num3 = 100;
				Tile tile3;
				short frameX2 = tile3.frameX;
				Tile tile4;
				bool flag = tile4.active();
				if (frameX2 == 0)
				{
				}
				Tile tile5;
				ushort type = tile5.type;
				if (frameX2 == 0)
				{
				}
				long num4 = 0L;
				Tile tile6;
				short frameY2 = tile6.frameY;
				if (frameX2 == 0)
				{
				}
				bool flag2 = WorldGen.SolidTileAllowBottomSlope(0, (int)num4);
				if (frameX2 == 0)
				{
				}
				bool flag3 = WorldGen.SolidTileAllowBottomSlope(0, (int)num4);
				if (frameX2 == 0)
				{
				}
				Tile tile7;
				bool flag4 = tile7.active();
				Tile tile8;
				ushort type2 = tile8.type;
				long num5 = 0L;
				long num6 = 0L;
				long num7 = 0L;
				WorldGen.KillTile(num2, num3, num5 != 0L, num6 != 0L, num7 != 0L);
			}
		}

		// Token: 0x06002D6A RID: 11626 RVA: 0x001CDA08 File Offset: 0x001CBC08
		public static void Place1x2(int x, int y, ushort type, int style)
		{
			int num = 1;
			long num2 = 0L;
			if (num == 0)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num3 = 3;
			int num4 = genRand.Next(num3);
			if (num == 0)
			{
			}
			bool flag = WorldGen.SolidTile2(x, num3);
			Tile tile;
			bool flag2 = tile.active();
			int num5 = 1;
			Tile tile2;
			tile2.active(num5 != 0);
			tile2.frameY = (short)style;
			tile2.frameX = (short)num2;
			tile2.type = type;
			int num6 = 1;
			Tile tile3;
			tile3.active(num6 != 0);
			tile3.frameY = (short)num6;
			tile3.frameX = (short)num2;
			tile3.type = type;
		}

		// Token: 0x06002D6B RID: 11627 RVA: 0x001CDA8C File Offset: 0x001CBC8C
		public static void Place1x2Top(int x, int y, ushort type, int style)
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
			Tile tile2;
			ushort type2 = tile2.type;
			if (num != 0)
			{
				if (num == 0)
				{
				}
				Tile tile3;
				ushort type3 = tile3.type;
				if (num == 0)
				{
					if (num == 0)
					{
					}
					Tile tile4;
					bool flag2 = tile4.active();
					if (num == 0)
					{
					}
					int num2 = 1;
					Tile tile5;
					tile5.active(num2 != 0);
					tile5.frameY = (short)style;
					long num3 = 0L;
					tile5.frameX = (short)num3;
					tile5.type = type;
					int num4 = 1;
					Tile tile6;
					tile6.active(num4 != 0);
					tile6.frameY = (short)num4;
					long num5 = 0L;
					tile6.frameX = (short)num5;
					tile6.type = type;
				}
			}
		}

		// Token: 0x06002D6C RID: 11628 RVA: 0x001CDB24 File Offset: 0x001CBD24
		public static void Check1x2Top(int x, int j, ushort type)
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
				Tile tile;
				short frameY = tile.frameY;
				return;
			}
		}

		// Token: 0x06002D6D RID: 11629 RVA: 0x001CDC78 File Offset: 0x001CBE78
		public static bool PlaceSmallPile(int i, int j, int X, int Y, ushort type = 185)
		{
			/*
An exception occurred when decompiling this method (06002D6D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::PlaceSmallPile(System.Int32,System.Int32,System.Int32,System.Int32,System.UInt16)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0045:
	stloc:int32(var_12_46, ldc.i4:int32(1))
	stloc:int32(var_13_49, ldc.i4:int32(1))
	call:void(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_11), ldloc:int32[exp:bool](var_12_46))
	callsetter:int16(Tile::set_frameY, ldloc:Tile[exp:valuetype Terraria.Tile&](var_11), ldloc:int32[exp:int16](X))
	callsetter:int16(Tile::set_frameX, ldloc:Tile[exp:valuetype Terraria.Tile&](var_11), ldloc:int32[exp:int16](X))
	callsetter:uint16(Tile::set_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_11), ldloc:int32[exp:uint16](Y))
	stloc:int32(var_15_6D, ldc.i4:int32(1))
	call:void(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_14), ldloc:int32[exp:bool](var_15_6D))
	callsetter:int16(Tile::set_frameY, ldloc:Tile[exp:valuetype Terraria.Tile&](var_14), ldloc:int32[exp:int16](X))
	callsetter:int16(Tile::set_frameX, ldloc:Tile[exp:valuetype Terraria.Tile&](var_14), ldloc:int32[exp:int16](X))
	stloc:bool(var_16_90, call:bool(WorldGen::SolidTile2, ldloc:int32(var_13_49), ldloc:int32(X)))
	stloc:bool(var_18_99, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_17)))
	stloc:int32(var_20_9C, ldc.i4:int32(1))
	call:void(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_19), ldloc:int32[exp:bool](var_20_9C))
	callsetter:int16(Tile::set_frameY, ldloc:Tile[exp:valuetype Terraria.Tile&](var_19), ldloc:int32[exp:int16](X))
	callsetter:int16(Tile::set_frameX, ldloc:Tile[exp:valuetype Terraria.Tile&](var_19), ldloc:int32[exp:int16](j))
	callsetter:uint16(Tile::set_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_19), ldloc:int32[exp:uint16](Y))
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

		// Token: 0x06002D6E RID: 11630 RVA: 0x001CDD44 File Offset: 0x001CBF44
		public static void CheckPile(int i, int y)
		{
			if (!true)
			{
			}
			Tile tile;
			short frameY = tile.frameY;
			ushort num;
			WorldGen.Check2x1(i, y, num);
		}

		// Token: 0x06002D6F RID: 11631 RVA: 0x001CDDA4 File Offset: 0x001CBFA4
		public static void Check2x1(int i, int y, ushort type)
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
				Tile tile;
				short frameX = tile.frameX;
				Tile tile2;
				short frameY = tile2.frameY;
				Tile tile3;
				short frameX2 = tile3.frameX;
				Tile tile4;
				short frameX3 = tile4.frameX;
				Tile tile5;
				ushort type2 = tile5.type;
				Tile tile6;
				ushort type3 = tile6.type;
				return;
			}
		}

		// Token: 0x06002D70 RID: 11632 RVA: 0x001CE42C File Offset: 0x001CC62C
		public static void Place2x1(int x, int y, ushort type, int style = 0)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool flag = WorldGen.SolidTile2(x, y);
			if (num == 0)
			{
			}
			bool flag2 = WorldGen.SolidTile2(0, y);
			if (num == 0)
			{
			}
			Tile tile;
			bool flag3 = tile.active();
			if (num == 0)
			{
			}
			Tile tile2;
			bool flag4 = tile2.active();
			if (num == 0)
			{
			}
			Tile tile3;
			bool flag5 = tile3.active();
			if (num == 0)
			{
			}
			Tile tile4;
			bool flag6 = tile4.active();
			if (num == 0)
			{
			}
			Tile tile5;
			ushort type2 = tile5.type;
			if (num != 0)
			{
				if (num == 0)
				{
				}
				Tile tile6;
				ushort type3 = tile6.type;
				if (num != 0)
				{
					if (num == 0)
					{
					}
					Tile tile7;
					bool flag7 = tile7.active();
					if (num == 0)
					{
					}
					Tile tile8;
					bool flag8 = tile8.active();
					if (num == 0)
					{
					}
					int num2 = 1;
					Tile tile9;
					tile9.active(num2 != 0);
					long num3 = 0L;
					tile9.frameY = (short)num3;
					tile9.frameX = (short)style;
					tile9.type = type;
					int num4 = 1;
					Tile tile10;
					tile10.active(num4 != 0);
					long num5 = 0L;
					tile10.frameY = (short)num5;
					tile10.frameX = (short)num5;
					tile10.type = type;
				}
			}
		}

		// Token: 0x06002D71 RID: 11633 RVA: 0x001CE510 File Offset: 0x001CC710
		public static void Check4x2(int i, int j, int type)
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
				Tile tile;
				short frameX = tile.frameX;
				return;
			}
		}

		// Token: 0x06002D72 RID: 11634 RVA: 0x001CE650 File Offset: 0x001CC850
		private static bool OasisPlantWaterCheck(int x, int y, bool boost = false)
		{
			if (!boost || y != 0)
			{
				return;
			}
		}

		// Token: 0x06002D73 RID: 11635 RVA: 0x001CE66C File Offset: 0x001CC86C
		public static void PlaceOasisPlant(int X, int Y, ushort type = 530)
		{
			if (!true)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num = 9;
			int num2 = genRand.Next(num);
		}

		// Token: 0x06002D74 RID: 11636 RVA: 0x001CE79C File Offset: 0x001CC99C
		public static void CheckOasisPlant(int i, int j, int type = 530)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				short frameY = Framing.GetTileSafely(0, j).frameY;
				long num2 = 0L;
				short num3;
				short frameY2 = Framing.GetTileSafely((int)num3, (int)num2).frameY;
				return;
			}
		}

		// Token: 0x06002D75 RID: 11637 RVA: 0x001CE8B0 File Offset: 0x001CCAB0
		public static void GetCactusType(int tileX, int tileY, int frameX, int frameY, [Out] bool evil, [Out] bool good, [Out] bool crimson)
		{
		}

		// Token: 0x06002D76 RID: 11638 RVA: 0x001CE904 File Offset: 0x001CCB04
		public static void GetBiomeInfluence(int startX, int endX, int startY, int endY, [Out] int corruptCount, [Out] int crimsonCount, [Out] int hallowedCount)
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
			}
		}

		// Token: 0x06002D77 RID: 11639 RVA: 0x001CE924 File Offset: 0x001CCB24
		public static void PlaceJunglePlant(int X2, int Y2, ushort type, int styleX, int styleY)
		{
		}

		// Token: 0x06002D78 RID: 11640 RVA: 0x001CEBEC File Offset: 0x001CCDEC
		public static void CheckJunglePlant(int i, int j, int type)
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
				Tile tile;
				short frameY = tile.frameY;
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
				short frameX = tile4.frameX;
				return;
			}
		}

		// Token: 0x06002D79 RID: 11641 RVA: 0x001CEDB4 File Offset: 0x001CCFB4
		public static void CheckSuper(int x, int y, int type)
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
		}

		// Token: 0x06002D7A RID: 11642 RVA: 0x001CEF74 File Offset: 0x001CD174
		public static void Check2x2(int i, int j, int type)
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
				Tile tile;
				short frameX = tile.frameX;
				int num2 = 29127;
				int num3 = 38;
				if (num2 == 0)
				{
				}
				Tile tile2;
				short frameY = tile2.frameY;
				if (num3 == 0)
				{
				}
				Tile tile3;
				short frameX2 = tile3.frameX;
				Tile tile4;
				short frameX3 = tile4.frameX;
				return;
			}
		}

		// Token: 0x06002D7B RID: 11643 RVA: 0x001CF2C4 File Offset: 0x001CD4C4
		public static bool CheckBoulderChest(int i, int j)
		{
			if (!true)
			{
			}
			Tile tile;
			short frameX = tile.frameX;
			int num = 29127;
			Tile tile2;
			short frameY = tile2.frameY;
			if (35 == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06002D7C RID: 11644 RVA: 0x001CF2FC File Offset: 0x001CD4FC
		public static bool IsAContainer(Tile t)
		{
			/*
An exception occurred when decompiling this method (06002D7C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::IsAContainer(Terraria.Tile)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0011:
	brtrue(IL_0000, ldloc:int32[exp:bool](var_0_01))
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

		// Token: 0x06002D7D RID: 11645 RVA: 0x001CF31C File Offset: 0x001CD51C
		public static void OreRunner(int i, int j, double strength, int steps, ushort type)
		{
			if (!true)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num = 11;
			int num2 = genRand.Next(j, num);
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num3 = 11;
			int num4 = genRand2.Next(j, num3);
			int num5 = 59;
			if (num5 != 0)
			{
				return;
			}
			if (num5 == 0)
			{
			}
			UnifiedRandom genRand3 = WorldGen.genRand;
			int num6 = 11;
			int num7 = genRand3.Next(j, num6);
			Tile tile;
			bool flag = tile.active();
			int num8 = 1;
			WorldGen.SquareTileFrame(j, num2, num8 != 0);
			bool netHost = Main.NetHost;
			UnifiedRandom genRand4 = WorldGen.genRand;
			int num9 = 11;
			int num10 = genRand4.Next(j, num9);
		}

		// Token: 0x06002D7E RID: 11646 RVA: 0x001CF3B0 File Offset: 0x001CD5B0
		public static void SmashAltar(int i, int j)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool netClientOnly = Main.NetClientOnly;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				if (num == 0)
				{
				}
				return;
			}
		}

		// Token: 0x06002D7F RID: 11647 RVA: 0x001CF648 File Offset: 0x001CD848
		public static void Check3x1(int i, int j, int type)
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
				Tile tile;
				short frameX = tile.frameX;
				return;
			}
		}

		// Token: 0x06002D80 RID: 11648 RVA: 0x001CF794 File Offset: 0x001CD994
		public static void Check3x2(int i, int j, int type)
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
			Tile tile;
			short frameY = tile.frameY;
			Tile tile2;
			short frameY2 = tile2.frameY;
			Tile tile3;
			short frameX = tile3.frameX;
		}

		// Token: 0x06002D81 RID: 11649 RVA: 0x001D02C4 File Offset: 0x001CE4C4
		private static int GetDresserItemDrop(int style)
		{
			return 918;
		}

		// Token: 0x06002D82 RID: 11650 RVA: 0x001D02DC File Offset: 0x001CE4DC
		private static int GetCampfireItemDrop(int style)
		{
			return 966;
		}

		// Token: 0x06002D83 RID: 11651 RVA: 0x001D0308 File Offset: 0x001CE508
		public static void Check3x4(int i, int j, int type)
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
				Tile tile;
				short frameX = tile.frameX;
				Tile tile2;
				short frameY = tile2.frameY;
				return;
			}
		}

		// Token: 0x06002D84 RID: 11652 RVA: 0x001D0408 File Offset: 0x001CE608
		public static void Check5x4(int i, int j, int type)
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
				Tile tile;
				short frameX = tile.frameX;
				return;
			}
		}

		// Token: 0x06002D85 RID: 11653 RVA: 0x001D0504 File Offset: 0x001CE704
		public static void Check6x3(int i, int j, int type)
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
				int num2 = 65533;
				Tile tile;
				short frameX = tile.frameX;
				Tile tile2;
				short frameY = tile2.frameY;
				int num3 = 65533;
				if (num3 == 0)
				{
				}
				Tile tile3;
				bool flag = tile3.active();
				if (num3 == 0)
				{
				}
				Tile tile4;
				ushort type2 = tile4.type;
				if (num3 == 0)
				{
				}
				Tile tile5;
				short frameX2 = tile5.frameX;
				if (num3 == 0)
				{
				}
				Tile tile6;
				short frameY2 = tile6.frameY;
				if (num3 == 0)
				{
				}
				bool flag2 = WorldGen.SolidTileAllowBottomSlope(0, j);
				if (num3 == 0)
				{
				}
				Tile tile7;
				bool flag3 = tile7.nactive();
				if (num3 == 0)
				{
				}
				Tile tile8;
				ushort type3 = tile8.type;
				if (num3 != 0)
				{
					if (num3 == 0)
					{
					}
					Tile tile9;
					short frameY3 = tile9.frameY;
				}
				if (num3 == 0)
				{
				}
				int num4 = 65533;
				if (num4 == 0)
				{
				}
				Tile tile10;
				ushort type4 = tile10.type;
				if (num4 == 0)
				{
				}
				Tile tile11;
				bool flag4 = tile11.active();
				if (num4 == 0)
				{
				}
				long num5 = 0L;
				long num6 = 0L;
				long num7 = 0L;
				WorldGen.KillTile(j, num2, num5 != 0L, num6 != 0L, num7 != 0L);
				return;
			}
		}

		// Token: 0x06002D86 RID: 11654 RVA: 0x001D0650 File Offset: 0x001CE850
		public static void Place6x3(int x, int y, ushort type, int direction = -1, int style = 0)
		{
			if (!true)
			{
			}
			Tile tile;
			bool flag = tile.active();
			bool flag2 = WorldGen.SolidTile2(43143168, x);
			Tile tile2;
			bool flag3 = tile2.nactive();
			Tile tile3;
			ushort type2 = tile3.type;
			Tile tile4;
			short frameY = tile4.frameY;
			long num = 0L;
			long num2 = 0L;
			int num3 = 1;
			Tile tile5;
			tile5.active(num3 != 0);
			tile5.frameY = (short)num2;
			tile5.frameX = (short)num;
			tile5.type = type;
		}

		// Token: 0x06002D87 RID: 11655 RVA: 0x001D06BC File Offset: 0x001CE8BC
		public static void Place4x2(int x, int y, ushort type, int direction = -1, int style = 0)
		{
			if (!true)
			{
			}
			int num = 65533;
			if (num == 0)
			{
			}
			Tile tile;
			bool flag = tile.active();
			if (num == 0)
			{
			}
		}

		// Token: 0x06002D88 RID: 11656 RVA: 0x001D07A0 File Offset: 0x001CE9A0
		public static void ShootFromCannon(int x, int y, int angle, int ammo, int Damage, float KnockBack, int owner, bool fromWire)
		{
			int num = 162;
			int num2 = 281;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			bool flag = WorldGen.BunnyCannonCanFire();
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			if (num == 0)
			{
			}
			bool netHost = Main.NetHost;
			if (num == 0)
			{
			}
			int myPlayer2 = Main.myPlayer;
			if (num == 0)
			{
			}
			if (num2 == 0)
			{
			}
			if (num2 == 0)
			{
			}
		}

		// Token: 0x06002D89 RID: 11657 RVA: 0x001D0804 File Offset: 0x001CEA04
		public static bool BunnyCannonCanFire()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0 || num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num != 0)
			{
				return;
			}
		}

		// Token: 0x06002D8A RID: 11658 RVA: 0x001D0830 File Offset: 0x001CEA30
		public static void SwitchCannon(int i, int j)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Tile tile;
			short frameX = tile.frameX;
			Tile tile2;
			short frameY = tile2.frameY;
			if (num == 0)
			{
			}
			Tile tile3;
			short frameY2 = tile3.frameY;
		}

		// Token: 0x06002D8B RID: 11659 RVA: 0x001D088C File Offset: 0x001CEA8C
		public static void CheckCannon(int i, int j, int type)
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
				Tile tile;
				short frameX = tile.frameX;
				return;
			}
		}

		// Token: 0x06002D8C RID: 11660 RVA: 0x001D0990 File Offset: 0x001CEB90
		public static void PlaceCannon(int x, int y, ushort type, int style = 0)
		{
			if (!true)
			{
			}
			long num = 2147483644L;
			long num2 = 0L;
			if (num == 0L)
			{
			}
			Tile tile;
			bool flag = tile.active();
			if (num == 0L)
			{
			}
			bool flag2 = WorldGen.SolidTile2(0, y);
			if (num == 0L)
			{
			}
			int num3 = 1;
			Tile tile2;
			tile2.active(num3 != 0);
			long num4 = 0L;
			tile2.frameY = (short)num4;
			tile2.frameX = (short)num2;
			tile2.type = type;
			int num5 = 1;
			Tile tile3;
			tile3.active(num5 != 0);
			long num6 = 0L;
			tile3.frameY = (short)num6;
			tile3.frameX = (short)num6;
			tile3.type = type;
			int num7 = 1;
			Tile tile4;
			tile4.active(num7 != 0);
			long num8 = 0L;
			tile4.frameY = (short)num8;
			tile4.frameX = (short)num8;
			tile4.type = type;
			int num9 = 1;
			Tile tile5;
			tile5.active(num9 != 0);
			long num10 = 0L;
			tile5.frameY = (short)num10;
			tile5.frameX = (short)num10;
			tile5.type = type;
			int num11 = 1;
			Tile tile6;
			tile6.active(num11 != 0);
			int num12 = 18;
			tile6.frameY = (short)num12;
			tile6.frameX = (short)num2;
			tile6.type = type;
			int num13 = 1;
			Tile tile7;
			tile7.active(num13 != 0);
			int num14 = 18;
			tile7.frameY = (short)num14;
			tile7.frameX = (short)num14;
			tile7.type = type;
			int num15 = 1;
			Tile tile8;
			tile8.active(num15 != 0);
			int num16 = 18;
			tile8.frameY = (short)num16;
			tile8.frameX = (short)y;
			tile8.type = type;
			int num17 = 1;
			Tile tile9;
			tile9.active(num17 != 0);
			int num18 = 18;
			tile9.frameY = (short)num18;
			tile9.frameX = (short)num18;
			tile9.type = type;
			int num19 = 1;
			Tile tile10;
			tile10.active(num19 != 0);
			int num20 = 36;
			tile10.frameY = (short)num20;
			tile10.frameX = (short)num2;
			tile10.type = type;
			int num21 = 1;
			Tile tile11;
			tile11.active(num21 != 0);
			int num22 = 36;
			tile11.frameY = (short)num22;
			tile11.frameX = (short)num22;
			tile11.type = type;
			int num23 = 1;
			Tile tile12;
			tile12.active(num23 != 0);
			int num24 = 36;
			tile12.frameY = (short)num24;
			tile12.frameX = (short)y;
			tile12.type = type;
			int num25 = 1;
			Tile tile13;
			tile13.active(num25 != 0);
			int num26 = 36;
			tile13.frameY = (short)num26;
			tile13.frameX = (short)num26;
			tile13.type = type;
		}

		// Token: 0x06002D8D RID: 11661 RVA: 0x001D0BBC File Offset: 0x001CEDBC
		public static void SwitchMB(int i, int j)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Tile tile;
			short frameY = tile.frameY;
			if (num == 0)
			{
			}
			Tile tile2;
			short frameX = tile2.frameX;
			if (num == 0)
			{
			}
			Tile tile3;
			bool flag = tile3.active();
		}

		// Token: 0x06002D8E RID: 11662 RVA: 0x001D0C20 File Offset: 0x001CEE20
		public static void SwitchMonolith(int i, int j)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Tile tile;
			short frameX = tile.frameX;
			if (num == 0)
			{
			}
			Tile tile2;
			short frameY = tile2.frameY;
			if (num == 0)
			{
			}
			Tile tile3;
			bool flag = tile3.active();
		}

		// Token: 0x06002D8F RID: 11663 RVA: 0x001D0CAC File Offset: 0x001CEEAC
		public static void SwitchFountain(int i, int j)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Tile tile;
			short frameX = tile.frameX;
			if (num == 0)
			{
			}
			Tile tile2;
			short frameY = tile2.frameY;
			if (num == 0)
			{
			}
			Tile tile3;
			bool flag = tile3.active();
		}

		// Token: 0x06002D90 RID: 11664 RVA: 0x001D0D4C File Offset: 0x001CEF4C
		public static void CheckMB(int i, int j, int type)
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
				Tile tile;
				short frameY = tile.frameY;
				return;
			}
		}

		// Token: 0x06002D91 RID: 11665 RVA: 0x001D0E94 File Offset: 0x001CF094
		public static void PlaceMB(int X, int y, ushort type, int style)
		{
			if (!true)
			{
			}
			if (65533 == 0)
			{
			}
			Tile tile;
			bool flag = tile.active();
		}

		// Token: 0x06002D92 RID: 11666 RVA: 0x001D0F94 File Offset: 0x001CF194
		public static void Place2x2(int x, int y, ushort type, int style)
		{
			if (!true)
			{
			}
			bool flag = WorldGen.CanPlaceSink(x, y, type, style);
		}

		// Token: 0x06002D93 RID: 11667 RVA: 0x001D1058 File Offset: 0x001CF258
		public static bool PlaceObject(int x, int y, int type, bool mute = false, int style = 0, int alternate = 0, int random = -1, int direction = -1)
		{
			/*
An exception occurred when decompiling this method (06002D93)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::PlaceObject(System.Int32,System.Int32,System.Int32,System.Boolean,System.Int32,System.Int32,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0006:
	call:void(WorldGen::SquareTileFrame, ldc.i4:int32(0), ldloc:int32(x), ldc.i4:int32[exp:bool](16777216))
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

		// Token: 0x06002D94 RID: 11668 RVA: 0x001D107C File Offset: 0x001CF27C
		public static bool ShiftTrapdoor(int x, int y, bool playerAbove, int onlyCloseOrOpen = -1)
		{
			int num = 1;
			Tile tileSafely = Framing.GetTileSafely(0, x);
			long num2 = 0L;
			ushort type = tileSafely.type;
			if (num == 0)
			{
			}
			int num3 = 2;
			int num4 = 2;
			int num5 = 18;
			int num6 = 18;
			long num10;
			if (WorldGen.GetTopLeftAndStyles(0, (int)num2, num3, num4, num5, num6) == null)
			{
				if (num == 0)
				{
				}
				bool logicHost = Main.LogicHost;
				if (num == 0)
				{
				}
				if (num != 0)
				{
					if (num == 0)
					{
					}
					Wiring.SkipWire(y, playerAbove ? 1 : 0);
					Wiring.SkipWire(y, playerAbove ? 1 : 0);
					Wiring.SkipWire(y, playerAbove ? 1 : 0);
					Wiring.SkipWire(y, playerAbove ? 1 : 0);
				}
				if (num == 0)
				{
				}
				int num7 = 1;
				bool flag = Collision.EmptyTile(y, playerAbove ? 1 : 0, num7 != 0);
				if (num == 0)
				{
				}
				int num8 = 1;
				bool flag2 = Collision.EmptyTile(42168472, playerAbove ? 1 : 0, num8 != 0);
				long num9 = 0L;
				Tile tile;
				tile.ClearTile();
				num10 = 0L;
				int num11 = 387;
				Tile tile2;
				tile2.type = (ushort)num11;
				tile2.frameX = (short)num11;
				tile2.frameY = (short)num9;
				if (num == 0)
				{
				}
				long num12 = 0L;
				long num13 = 0L;
				WorldGen.TileFrame(0, (int)num9, num12 != 0L, num13 != 0L);
				return false;
			}
			long num14 = 0L;
			long num22;
			int num31;
			if (num10 != 0L)
			{
				if (num == 0)
				{
				}
				int num15 = 2;
				int num16 = 1;
				int num17 = 18;
				int num18 = 18;
				Point topLeftAndStyles = WorldGen.GetTopLeftAndStyles(0, (int)num14, num15, num16, num17, num18);
				if (num == 0)
				{
				}
				long num19 = 0L;
				int num20 = true.ToDirectionInt();
				long num21 = 0L;
				bool flag3 = Framing.GetTileSafely(num20, (int)num19).active();
				if (num == 0)
				{
				}
				if (num != 0)
				{
					if (num == 0)
					{
					}
					bool logicHost2 = Main.LogicHost;
					if (num == 0)
					{
					}
					if (num != 0)
					{
						if (num == 0)
						{
						}
						Wiring.SkipWire((int)num21, 42168472);
						Wiring.SkipWire((int)num21, 42168472);
						Wiring.SkipWire((int)num21, 42168472);
						Wiring.SkipWire((int)num21, 42168472);
					}
					num22 = 0L;
					Tile tile3;
					bool flag4 = tile3.active();
					if (num == 0)
					{
					}
					long num23 = 0L;
					if (num != 0)
					{
						if (num == 0)
						{
						}
						long num24 = 0L;
						long num25 = 0L;
						long num26 = 0L;
						WorldGen.KillTile(0, (int)num23, num24 != 0L, num25 != 0L, num26 != 0L);
					}
					TileColorCache tileColorCache = Framing.GetTileSafely(0, (int)num23).BlockColorAndCoating();
					if (num == 0)
					{
					}
					long num27 = 0L;
					int num28 = true.ToInt();
					Tile tileSafely2 = Framing.GetTileSafely(num, (int)num27);
					int num29 = 386;
					tileSafely2.type = (ushort)num29;
					if (num == 0)
					{
					}
					long num30 = 0L;
					num31 = true.ToInt();
					long num32 = 0L;
					long num33 = 0L;
					WorldGen.TileFrame(0, (int)num30, num32 != 0L, num33 != 0L);
				}
			}
			if (!false)
			{
			}
			bool logicHost3 = Main.LogicHost;
			if (!false)
			{
			}
			if (false)
			{
				if (!false)
				{
				}
				long num30;
				Wiring.SkipWire(num31, (int)num30);
				Wiring.SkipWire(num31, (int)num30);
				Wiring.SkipWire(num31, (int)num30);
				Wiring.SkipWire(num31, (int)num30);
			}
			if (!false)
			{
			}
			int num34 = 1;
			bool flag5 = Collision.EmptyTile(num31, (int)num22, num34 != 0);
			if (!false)
			{
			}
			long num35 = 0L;
			Tile tile4;
			tile4.ClearTile();
			int num36 = 387;
			Tile tile5;
			tile5.type = (ushort)num36;
			tile5.frameX = (short)num36;
			tile5.frameY = (short)num35;
			if (!false)
			{
			}
			long num37 = 0L;
			long num38 = 0L;
			WorldGen.TileFrame(0, (int)num35, num37 != 0L, num38 != 0L);
			return false;
		}

		// Token: 0x06002D95 RID: 11669 RVA: 0x001D133C File Offset: 0x001CF53C
		public static void CheckTrapDoor(int x, int y, int type)
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
				int num2 = 2;
				int num3 = 1;
				int num4 = 18;
				int num5 = 18;
				Point topLeftAndStyles = WorldGen.GetTopLeftAndStyles(0, y, num2, num3, num4, num5);
				if (!false)
				{
				}
				return;
			}
		}

		// Token: 0x06002D96 RID: 11670 RVA: 0x001D1400 File Offset: 0x001CF600
		public static void CheckTallGate(int x, int y, int type)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				Tile tileSafely = Framing.GetTileSafely(x, y);
				long num2 = 0L;
				short frameX = tileSafely.frameX;
				long num3 = 0L;
				TileObjectData tileData = TileObjectData.GetTileData(type, (int)num2, (int)num3);
				int coordinateFullHeight = tileData.CoordinateFullHeight;
				int width = tileData.Width;
				int height = tileData.Height;
				int coordinateFullHeight2 = tileData.CoordinateFullHeight;
				int[] coordinateHeights = tileData.CoordinateHeights;
				int[] coordinateHeights2 = tileData.CoordinateHeights;
				return;
			}
		}

		// Token: 0x06002D97 RID: 11671 RVA: 0x001D14FC File Offset: 0x001CF6FC
		public static bool ShiftTallGate(int x, int y, bool closing, bool forced = false)
		{
			int num = 388;
			ushort type = Framing.GetTileSafely(0, x).type;
			long num2 = 0L;
			int num3 = 388;
			long num4 = 0L;
			TileObjectData tileData = TileObjectData.GetTileData(num3, (int)num2, (int)num4);
			int coordinateFullHeight = tileData.CoordinateFullHeight;
			int width = tileData.Width;
			int height = tileData.Height;
			int coordinateFullHeight2 = tileData.CoordinateFullHeight;
			int[] coordinateHeights = tileData.CoordinateHeights;
			int[] coordinateHeights2 = tileData.CoordinateHeights;
			int coordinateFullHeight3 = tileData.CoordinateFullHeight;
			if (num == 0)
			{
			}
			bool logicHost = Main.LogicHost;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				if (num == 0)
				{
				}
				if (height != 0)
				{
					return false;
				}
			}
			if (num == 0)
			{
			}
			Tile tile;
			tile.type = (ushort)y;
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06002D98 RID: 11672 RVA: 0x001D15B4 File Offset: 0x001CF7B4
		public static Point GetTopLeftAndStyles(int x, int y, int w, int h, int frameXinc, int frameYinc)
		{
			/*
An exception occurred when decompiling this method (06002D98)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Point Terraria.WorldGen::GetTopLeftAndStyles(System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000E:
	brtrue(IL_0000, logicnot:bool(ldloc:int32[exp:bool](frameXinc)))
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

		// Token: 0x06002D99 RID: 11673 RVA: 0x001D15D4 File Offset: 0x001CF7D4
		public static bool CheckTileFrames(int type, int sx, int sy, int w, int h, int styleX, int frameXinc, int styleY, int frameYinc)
		{
			Tile tile;
			bool flag = tile.active();
			while (w != 0)
			{
			}
		}

		// Token: 0x06002D9A RID: 11674 RVA: 0x001D15F4 File Offset: 0x001CF7F4
		public static bool CheckTileAnchors(int sx, int sy, int w, int h, int mode, AnchorType anchor)
		{
			/*
An exception occurred when decompiling this method (06002D9A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::CheckTileAnchors(System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,Terraria.Enums.AnchorType)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Tile(var_1_09, call:Tile(Framing::GetTileSafely, ldc.i4:int32(0), ldloc:int32(sx)))
	stloc:Tile(var_3_11, call:Tile(Framing::GetTileSafely, ldloc:bool[exp:int32](var_2), ldloc:int32(sx)))
	stloc:Tile(var_5_1A, call:Tile(Framing::GetTileSafely, ldloc:bool[exp:int32](var_4), ldloc:int32(h)))
	stloc:Tile(var_7_28, call:Tile(Framing::GetTileSafely, ldloc:bool[exp:int32](var_6), ldc.i4:int32(43143168)))
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

		// Token: 0x06002D9B RID: 11675 RVA: 0x001D1630 File Offset: 0x001CF830
		public static bool AnchorValid(Tile tileCache, AnchorType anchor)
		{
			for (;;)
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
					if (num == 0)
					{
						if (num == 0)
						{
						}
						if (num == 0)
						{
							continue;
						}
					}
				}
				long num2 = 0L;
				if (num == 0)
				{
				}
				if (num != 0)
				{
					if (num == 0)
					{
					}
					if (num != 0)
					{
						if (num == 0)
						{
						}
						if (num != 0)
						{
						}
					}
				}
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				bool flag;
				if (num2 == 0L)
				{
					if (num == 0)
					{
					}
					if (num != 0)
					{
						int num3 = TileObjectData.PlatformFrameWidth();
						if (!flag)
						{
							goto IL_0056;
						}
					}
					if (!flag)
					{
					}
					if (!flag || !flag)
					{
					}
				}
				IL_0056:
				if (num2 == 0L)
				{
					if (!flag)
					{
					}
					if (!flag)
					{
						if (!flag)
						{
						}
						if (flag)
						{
						}
					}
				}
				if (num2 == 0L)
				{
					if (!flag)
					{
					}
					if (!flag)
					{
						return;
					}
					if (!flag)
					{
					}
					if (flag)
					{
						return;
					}
				}
			}
		}

		// Token: 0x06002D9C RID: 11676 RVA: 0x001D16C0 File Offset: 0x001CF8C0
		public static bool CanPlaceSink(int x, int y, ushort type, int style)
		{
			if (!true)
			{
			}
			return int.MinValue != 0;
		}

		// Token: 0x06002D9D RID: 11677 RVA: 0x001D1708 File Offset: 0x001CF908
		public static void Place3x4(int x, int y, ushort type, int style)
		{
			if (!true)
			{
			}
			if (65533 == 0)
			{
			}
			long num = 0L;
			Tile tile;
			bool flag = tile.active();
			bool flag2 = WorldGen.SolidTile2(0, (int)num);
			if (54 == 0)
			{
			}
			int num2 = 1;
			Tile tile2;
			tile2.active(num2 != 0);
			tile2.frameY = (short)y;
			tile2.frameX = (short)style;
			tile2.type = type;
			int num3 = 1;
			Tile tile3;
			tile3.active(num3 != 0);
			tile3.frameY = (short)y;
			tile3.frameX = (short)y;
			tile3.type = type;
			int num4 = 1;
			Tile tile4;
			tile4.active(num4 != 0);
			tile4.frameY = (short)y;
			tile4.frameX = (short)y;
			tile4.type = type;
		}

		// Token: 0x06002D9E RID: 11678 RVA: 0x001D17B4 File Offset: 0x001CF9B4
		public static void Place5x4(int x, int y, ushort type, int style)
		{
			if (!true)
			{
			}
			int num = 1;
			long num2 = 0L;
			Tile tile;
			bool flag = tile.active();
			bool flag2 = WorldGen.SolidTile2(0, 0);
			if (54 == 0)
			{
			}
			int num3 = 1;
			Tile tile2;
			tile2.active(num3 != 0);
			tile2.frameY = (short)y;
			tile2.frameX = (short)y;
			tile2.type = type;
			int num4 = 1;
			Tile tile3;
			tile3.active(num4 != 0);
			tile3.frameY = (short)y;
			tile3.frameX = (short)y;
			tile3.type = type;
			int num5 = 1;
			Tile tile4;
			tile4.active(num5 != 0);
			tile4.frameY = (short)y;
			tile4.frameX = (short)num;
			tile4.type = type;
			int num6 = 1;
			Tile tile5;
			tile5.active(num6 != 0);
			tile5.frameY = (short)y;
			tile5.frameX = (short)num2;
			tile5.type = type;
			int num7 = 1;
			Tile tile6;
			tile6.active(num7 != 0);
			tile6.frameY = (short)y;
			tile6.frameX = (short)y;
			tile6.type = type;
		}

		// Token: 0x06002D9F RID: 11679 RVA: 0x001D1898 File Offset: 0x001CFA98
		public static void Place3x1(int x, int y, ushort type, int style = 0)
		{
			if (!true)
			{
			}
			if (65533 == 0)
			{
			}
			Tile tile;
			bool flag = tile.active();
		}

		// Token: 0x06002DA0 RID: 11680 RVA: 0x001D192C File Offset: 0x001CFB2C
		public static void Place3x2(int x, int y, ushort type, int style = 0)
		{
			if (!true)
			{
			}
			int num = 65533;
			if (num == 0)
			{
			}
			Tile tile;
			bool flag = tile.active();
			if (num == 0)
			{
			}
			long num2 = 0L;
			Tile tile2;
			byte liquid = tile2.liquid;
			bool flag2 = WorldGen.SolidTile2(0, (int)num2);
			if (!false)
			{
			}
			Tile tile3;
			bool flag3 = tile3.nactive();
			if (!false)
			{
			}
			Tile tile4;
			ushort type2 = tile4.type;
			if (false)
			{
				if (!false)
				{
				}
				Tile tile5;
				short frameY = tile5.frameY;
			}
		}

		// Token: 0x06002DA1 RID: 11681 RVA: 0x001D1B54 File Offset: 0x001CFD54
		public static void Place2x2Style(int x, int y, ushort type, int style = 0)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002DA2 RID: 11682 RVA: 0x001D1C3C File Offset: 0x001CFE3C
		public static bool NearFriendlyWall(int x, int y)
		{
			/*
An exception occurred when decompiling this method (06002DA2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::NearFriendlyWall(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint16(var_2_08, callgetter:uint16(Tile::get_wall, ldloc:Tile[exp:valuetype Terraria.Tile&](var_0)))
	stloc:uint16(var_4_0F, callgetter:uint16(Tile::get_wall, ldloc:Tile[exp:valuetype Terraria.Tile&](var_3)))
	stloc:uint16(var_7_1B, callgetter:uint16(Tile::get_wall, ldloc:Tile[exp:valuetype Terraria.Tile&](var_6)))
	stloc:uint16(var_9_24, callgetter:uint16(Tile::get_wall, ldloc:Tile[exp:valuetype Terraria.Tile&](var_8)))
	stloc:uint16(var_11_2D, callgetter:uint16(Tile::get_wall, ldloc:Tile[exp:valuetype Terraria.Tile&](var_10)))
	stloc:uint16(var_14_39, callgetter:uint16(Tile::get_wall, ldloc:Tile[exp:valuetype Terraria.Tile&](var_12)))
	stloc:uint16(var_17_45, callgetter:uint16(Tile::get_wall, ldloc:Tile[exp:valuetype Terraria.Tile&](var_15)))
	stloc:uint16(var_20_51, callgetter:uint16(Tile::get_wall, ldloc:Tile[exp:valuetype Terraria.Tile&](var_18)))
	stloc:uint16(var_23_5D, callgetter:uint16(Tile::get_wall, ldloc:Tile[exp:valuetype Terraria.Tile&](var_21)))
	stloc:uint16(var_25_66, callgetter:uint16(Tile::get_wall, ldloc:Tile[exp:valuetype Terraria.Tile&](var_24)))
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

		// Token: 0x06002DA3 RID: 11683 RVA: 0x001D1CB0 File Offset: 0x001CFEB0
		public static void Check2x2Style(int i, int j, int type)
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
				Tile tile;
				short frameY = tile.frameY;
				Tile tile2;
				short frameX = tile2.frameX;
				return;
			}
		}

		// Token: 0x06002DA4 RID: 11684 RVA: 0x001D1E0C File Offset: 0x001D000C
		public static void PlacePumpkin(int x, int superY)
		{
			int num = 1;
			if (num == 0)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num2 = 6;
			int num3 = genRand.Next(num2);
			if (num == 0)
			{
			}
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
			ushort type2 = tile3.type;
			if (num == 0)
			{
			}
			Tile tile4;
			ushort type3 = tile4.type;
			if (num == 0)
			{
			}
			Tile tile5;
			ushort type4 = tile5.type;
			if (num == 0)
			{
			}
			Tile tile6;
			ushort type5 = tile6.type;
			if (num == 0)
			{
			}
			Tile tile7;
			short frameY = tile7.frameY;
			if (num == 0)
			{
			}
			long num4 = 0L;
			Tile tile8;
			byte liquid = tile8.liquid;
			if (num == 0)
			{
			}
			long num5 = 0L;
			bool flag2 = WorldGen.SolidTile(0, (int)num4, num5 != 0L);
			if (num == 0)
			{
			}
			Tile tile9;
			ushort type6 = tile9.type;
			if (num == 0)
			{
			}
			Tile tile10;
			ushort type7 = tile10.type;
			if (num == 0)
			{
			}
			int num6 = 1;
			Tile tile11;
			tile11.active(num6 != 0);
			tile11.frameY = (short)num3;
			long num7 = 0L;
			tile11.frameX = (short)num7;
			int num8 = 254;
			tile11.type = (ushort)num8;
			int num9 = 1;
			Tile tile12;
			tile12.active(num9 != 0);
			tile12.frameY = (short)num3;
			int num10 = 18;
			tile12.frameX = (short)num10;
			int num11 = 254;
			tile12.type = (ushort)num11;
			int num12 = 1;
			Tile tile13;
			tile13.active(num12 != 0);
			long num13 = 0L;
			tile13.frameX = (short)num13;
			int num14 = 254;
			tile13.type = (ushort)num14;
			int num15 = 1;
			Tile tile14;
			tile14.active(num15 != 0);
			int num16 = 18;
			tile14.frameX = (short)num16;
			int num17 = 254;
			tile14.type = (ushort)num17;
		}

		// Token: 0x06002DA5 RID: 11685 RVA: 0x001D1F98 File Offset: 0x001D0198
		public static void GrowPumpkin(int i, int j, int type)
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
			Tile tile;
			short frameY = tile.frameY;
			Tile tile2;
			short frameX = tile2.frameX;
		}

		// Token: 0x06002DA6 RID: 11686 RVA: 0x001D206C File Offset: 0x001D026C
		public static void FixHearts()
		{
			int num = 1;
			long num2 = 0L;
			if (num == 0)
			{
			}
			long num3 = 0L;
			if (num == 0)
			{
			}
			Tile tile;
			bool flag = tile.active();
			WorldGen.FixHeart((int)num2, (int)num3);
		}

		// Token: 0x06002DA7 RID: 11687 RVA: 0x001D2098 File Offset: 0x001D0298
		public static void DestroyHeart(int i, int j)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int num2 = 1;
			if (num == 0)
			{
			}
			if (num2 == 0)
			{
			}
			if (num2 == 0)
			{
			}
			Tile tile;
			bool flag = tile.active();
			long num3 = 0L;
			long num4 = 0L;
			long num5 = 0L;
			WorldGen.KillTile(i, j, num3 != 0L, num4 != 0L, num5 != 0L);
		}

		// Token: 0x06002DA8 RID: 11688 RVA: 0x001D20DC File Offset: 0x001D02DC
		public static void FixHeart(int i, int j)
		{
			if (!true)
			{
			}
			Tile tile;
			bool flag = tile.active();
			long num = 0L;
			long num2 = 0L;
			long num3 = 0L;
			WorldGen.KillTile(i, 0, num != 0L, num2 != 0L, num3 != 0L);
			long num4 = 0L;
			long num5 = 0L;
			long num6 = 0L;
			WorldGen.KillTile(0, 0, num4 != 0L, num5 != 0L, num6 != 0L);
			int num7;
			if (num7 != 0)
			{
			}
			int num8;
			if (num8 != 0)
			{
				return;
			}
		}

		// Token: 0x06002DA9 RID: 11689 RVA: 0x001D2144 File Offset: 0x001D0344
		public static void FixChands()
		{
			int num = 1;
			int num2 = 5;
			if (num == 0)
			{
			}
			int num3 = 5;
			if (num == 0)
			{
			}
			Tile tile;
			bool flag = tile.active();
			Tile tile2;
			ushort type = tile2.type;
			Tile tile3;
			bool flag2 = tile3.active();
			WorldGen.FixChand(num2, num3);
		}

		// Token: 0x06002DAA RID: 11690 RVA: 0x001D2180 File Offset: 0x001D0380
		public static void FixChand(int i, int j)
		{
			if (!true)
			{
			}
			Tile tile;
			ushort type = tile.type;
			Tile tile2;
			bool flag = tile2.active();
		}

		// Token: 0x06002DAB RID: 11691 RVA: 0x001D21E0 File Offset: 0x001D03E0
		public static void PlaceChand(int x, int y, ushort type, int style = 0)
		{
			if (!true)
			{
			}
			Tile tile;
			bool flag = tile.active();
		}

		// Token: 0x06002DAC RID: 11692 RVA: 0x001D2390 File Offset: 0x001D0590
		public static void CheckChand(int i, int j, int type)
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
				Tile tile;
				short frameX = tile.frameX;
				if (36409 == 0)
				{
				}
				Tile tile2;
				short frameY = tile2.frameY;
				return;
			}
		}

		// Token: 0x06002DAD RID: 11693 RVA: 0x001D253C File Offset: 0x001D073C
		public static void Check3x3(int i, int j, int type)
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
			Tile tile;
			short frameX = tile.frameX;
		}

		// Token: 0x06002DAE RID: 11694 RVA: 0x001D2784 File Offset: 0x001D0984
		public static void Check2x5(int i, int j, int type)
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
				Tile tile;
				short frameX = tile.frameX;
				return;
			}
		}

		// Token: 0x06002DAF RID: 11695 RVA: 0x001D28A0 File Offset: 0x001D0AA0
		public static void Check3x5(int i, int j, int type)
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
				Tile tile;
				short frameX = tile.frameX;
				return;
			}
		}

		// Token: 0x06002DB0 RID: 11696 RVA: 0x001D2998 File Offset: 0x001D0B98
		public static void Check3x6(int i, int j, int type)
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
				Tile tile;
				short frameX = tile.frameX;
				return;
			}
		}

		// Token: 0x06002DB1 RID: 11697 RVA: 0x001D2AA4 File Offset: 0x001D0CA4
		public static void Place3x3(int x, int y, ushort type, int style = 0)
		{
			int num = 1;
			if (num == 0)
			{
			}
			long num2 = 0L;
			Tile tile;
			bool flag = tile.active();
			if (num == 0)
			{
			}
			bool flag2 = WorldGen.SolidTile2(y, (int)num2);
		}

		// Token: 0x06002DB2 RID: 11698 RVA: 0x001D2C64 File Offset: 0x001D0E64
		public static void PlaceSunflower(int x, int y, ushort type = 27)
		{
			if (!true)
			{
			}
			int num = 65533;
			if (num == 0)
			{
			}
			Tile tile;
			bool flag = tile.active();
			if (num == 0)
			{
			}
			Tile tile2;
			ushort wall = tile2.wall;
		}

		// Token: 0x06002DB3 RID: 11699 RVA: 0x001D2D44 File Offset: 0x001D0F44
		public static void FixSunflowers()
		{
			int num = 1;
			int num2 = 5;
			if (num == 0)
			{
			}
			int num3 = 5;
			if (num == 0)
			{
			}
			Tile tile;
			bool flag = tile.active();
			Tile tile2;
			ushort type = tile2.type;
			WorldGen.FixSunflower(num2, num3);
		}

		// Token: 0x06002DB4 RID: 11700 RVA: 0x001D2D78 File Offset: 0x001D0F78
		public static void FixSunflower(int i, int j)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Tile tile;
			ushort type = tile.type;
			if (num == 0)
			{
			}
			Tile tile2;
			short frameX = tile2.frameX;
			Tile tile3;
			short frameY = tile3.frameY;
			UnifiedRandom genRand = WorldGen.genRand;
			int num2 = 3;
			int num3 = genRand.Next(num2);
			if (65533 == 0)
			{
			}
			Tile tile4;
			tile4.frameX = (short)j;
		}

		// Token: 0x06002DB5 RID: 11701 RVA: 0x001D2DD4 File Offset: 0x001D0FD4
		public static void CheckSunflower(int i, int j, int type = 27)
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
				Tile tile;
				short frameX = tile.frameX;
				Tile tile2;
				short frameY = tile2.frameY;
				int num2 = 65533;
				if (num2 == 0)
				{
				}
				Tile tile3;
				short frameX2 = tile3.frameX;
				Tile tile4;
				bool flag = tile4.nactive();
				if (num2 == 0)
				{
				}
				Tile tile5;
				ushort type2 = tile5.type;
				if (num2 == 0)
				{
				}
				Tile tile6;
				short frameY2 = tile6.frameY;
				return;
			}
		}

		// Token: 0x06002DB6 RID: 11702 RVA: 0x001D2F28 File Offset: 0x001D1128
		public static void CheckDye(int x, int y)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Tile tile;
			short frameX = tile.frameX;
			if (num == 0)
			{
			}
		}

		// Token: 0x06002DB7 RID: 11703 RVA: 0x001D2F8C File Offset: 0x001D118C
		public static void CheckRockGolemHead(int x, int y)
		{
			if (!true)
			{
			}
			bool flag = WorldGen.SolidTileAllowBottomSlope(x, y);
		}

		// Token: 0x06002DB8 RID: 11704 RVA: 0x001D2FBC File Offset: 0x001D11BC
		public static void CheckStinkbugBlocker(int x, int y)
		{
			short frameX = Framing.GetTileSafely(x, y).frameX;
		}

		// Token: 0x06002DB9 RID: 11705 RVA: 0x001D2FEC File Offset: 0x001D11EC
		public static bool AttemptReorientingStinkbugBlocker(int x, int y, int wall, int style)
		{
			int num = 1;
			wall.m_value = num;
			if (num == 0)
			{
			}
			return WorldGen.SolidTileAllowBottomSlope(0, x);
		}

		// Token: 0x06002DBA RID: 11706 RVA: 0x001D3038 File Offset: 0x001D1238
		public static void CheckGnome(int x, int j)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				Tile tileSafely = Framing.GetTileSafely(x, j);
				short frameY = Framing.GetTileSafely(x, j).frameY;
				Tile tileSafely2 = Framing.GetTileSafely(x, 43143168);
				short frameX = Framing.GetTileSafely(x, j).frameX;
				return;
			}
		}

		// Token: 0x06002DBB RID: 11707 RVA: 0x001D30DC File Offset: 0x001D12DC
		public static void PlaceGnome(int x, int y, int style)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002DBC RID: 11708 RVA: 0x001D30EC File Offset: 0x001D12EC
		public static void PlaceDye(int x, int y, int style)
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
			bool isLoaded2 = tile2.IsLoaded;
			if (num == 0)
			{
			}
			Tile tile3;
			bool flag = tile3.active();
			if (num == 0)
			{
			}
			Tile tile4;
			ushort type = tile4.type;
			if (num == 0)
			{
			}
			Tile tile5;
			ushort type2 = tile5.type;
			if (num == 0)
			{
			}
			Tile tile6;
			ushort type3 = tile6.type;
			if (num == 0)
			{
			}
			Tile tile7;
			ushort type4 = tile7.type;
			if (num == 0)
			{
			}
			Tile tile8;
			ushort type5 = tile8.type;
			if (num == 0)
			{
			}
			long num2 = 0L;
			Tile tile9;
			ushort type6 = tile9.type;
			if (num == 0)
			{
			}
			long num3 = 0L;
			bool flag2 = WorldGen.SolidTile(x, (int)num2, num3 != 0L);
			if (num == 0)
			{
			}
			Tile tile10;
			bool flag3 = tile10.active();
			if (num == 0)
			{
			}
			int num4 = 227;
			Tile tile11;
			tile11.type = (ushort)num4;
			int num5 = 1;
			tile11.active(num5 != 0);
			long num6 = 0L;
			tile11.halfBrick(num6 != 0L);
			long num7 = 0L;
			tile11.slope((byte)num7);
			long num8 = 0L;
			tile11.frameY = (short)num8;
			tile11.frameX = (short)num8;
		}

		// Token: 0x06002DBD RID: 11709 RVA: 0x001D32B8 File Offset: 0x001D14B8
		public static bool PlacePot(int x, int y, ushort type = 28, int style = 0)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0 || num == 0)
			{
			}
			if (65533 == 0)
			{
			}
			Tile tile;
			return tile.active();
		}

		// Token: 0x06002DBE RID: 11710 RVA: 0x001D3378 File Offset: 0x001D1578
		public static bool CheckCactus(int i, int j)
		{
			/*
An exception occurred when decompiling this method (06002DBE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::CheckCactus(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_004D:
	stloc:bool(var_17_57, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_15)))
	stloc:uint16(var_20_63, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_18)))
	stloc:bool(var_24_6F, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_22)))
	stloc:uint16(var_27_7B, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_25)))
	stloc:bool(var_31_87, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_29)))
	stloc:uint16(var_34_93, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_32)))
	stloc:bool(var_38_9F, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_36)))
	stloc:uint16(var_40_A8, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_39)))
	stloc:bool(var_42_B1, call:bool(Tile::nactive, ldloc:Tile[exp:valuetype Terraria.Tile&](var_41)))
	stloc:bool(var_44_BA, call:bool(Tile::halfBrick, ldloc:Tile[exp:valuetype Terraria.Tile&](var_43)))
	stloc:uint8(var_46_C3, call:uint8(Tile::slope, ldloc:Tile[exp:valuetype Terraria.Tile&](var_45)))
	stloc:int64(var_47_C6, ldc.i4:int64(0))
	stloc:int64(var_48_C9, ldc.i4:int64(0))
	stloc:int64(var_49_CC, ldc.i4:int64(0))
	call:void(WorldGen::KillTile, ldc.i4:int32(0), ldloc:int32(i), ldloc:int64[exp:bool](var_47_C6), ldloc:int64[exp:bool](var_48_C9), ldloc:int64[exp:bool](var_49_CC))
	stloc:uint16(var_52_E5, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_51)))
	stloc:uint16(var_54_EE, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_53)))
	stloc:uint16(var_56_F7, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_55)))
	stloc:uint16(var_59_103, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_57)))
	stloc:bool(var_62_10F, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_60)))
	stloc:uint16(var_65_11B, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_63)))
	stloc:uint16(var_68_127, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_66)))
	stloc:uint16(var_71_133, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_69)))
	stloc:uint16(var_74_13F, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_72)))
	stloc:uint16(var_77_14B, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_75)))
	stloc:bool(var_80_157, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_78)))
	stloc:uint16(var_82_160, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_81)))
	stloc:bool(var_84_169, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_83)))
	stloc:uint16(var_86_172, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_85)))
	stloc:bool(var_88_17B, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_87)))
	stloc:uint16(var_90_184, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_89)))
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

		// Token: 0x06002DBF RID: 11711 RVA: 0x001D3510 File Offset: 0x001D1710
		public static void PlantCactus(int i, int j)
		{
			int num = 1;
			if (num == 0)
			{
			}
			WorldGen.GrowCactus(i, j);
			if (num == 0)
			{
			}
			int num2 = WorldGen.genRand.Next(43143168, i);
			int num3 = WorldGen.genRand.Next(43143168, j);
			WorldGen.GrowCactus(num2, num3);
		}

		// Token: 0x06002DC0 RID: 11712 RVA: 0x001D3558 File Offset: 0x001D1758
		public static void CheckOrb(int i, int j, int type)
		{
			if (!true)
			{
			}
			Tile tile;
			short frameX = tile.frameX;
			Tile tile2;
			short frameX2 = tile2.frameX;
			Tile tile3;
			short frameX3 = tile3.frameX;
			Tile tile4;
			short frameY = tile4.frameY;
			Tile tile5;
			bool isLoaded = tile5.IsLoaded;
		}

		// Token: 0x06002DC1 RID: 11713 RVA: 0x001D36B0 File Offset: 0x001D18B0
		public static void CheckPalmTree(int i, int j)
		{
			if (!true)
			{
			}
			Tile tile;
			ushort type = tile.type;
			Tile tile2;
			bool flag = tile2.active();
			Tile tile3;
			ushort type2 = tile3.type;
		}

		// Token: 0x06002DC2 RID: 11714 RVA: 0x001D3784 File Offset: 0x001D1984
		public static void CheckTreeWithSettings(int x, int y, WorldGen.CheckTreeSettings settings)
		{
			if (!true)
			{
			}
			Tile tile;
			ushort type = tile.type;
			Tile tile2;
			bool flag = tile2.active();
			Tile tile3;
			ushort type2 = tile3.type;
		}

		// Token: 0x06002DC3 RID: 11715 RVA: 0x001D39FC File Offset: 0x001D1BFC
		public static void CheckTree(int i, int j)
		{
			if (!true)
			{
			}
			Tile tile;
			ushort type = tile.type;
			Tile tile2;
			bool flag = tile2.active();
			Tile tile3;
			ushort type2 = tile3.type;
		}

		// Token: 0x06002DC4 RID: 11716 RVA: 0x001D3CD8 File Offset: 0x001D1ED8
		public static bool TileIsExposedToAir(int x, int y)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int num2 = 2;
			bool flag = WorldGen.InWorld(0, x, num2);
			if (num == 0)
			{
			}
			Tile tile;
			bool flag2 = tile.active();
			if (num == 0)
			{
			}
			if (num == 0)
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

		// Token: 0x06002DC5 RID: 11717 RVA: 0x001D3D14 File Offset: 0x001D1F14
		public static bool TryKillingTreesAboveIfTheyWouldBecomeInvalid(int i, int j, int newFloorType)
		{
			/*
An exception occurred when decompiling this method (06002DC5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::TryKillingTreesAboveIfTheyWouldBecomeInvalid(System.Int32,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_002F:
	stloc:int64(var_11_30, ldc.i4:int64(0))
	stloc:int64(var_12_33, ldc.i4:int64(0))
	stloc:int64(var_13_36, ldc.i4:int64(0))
	call:void(WorldGen::KillTile, ldc.i4:int32(0), ldloc:int32(i), ldloc:int64[exp:bool](var_11_30), ldloc:int64[exp:bool](var_12_33), ldloc:int64[exp:bool](var_13_36))
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

		// Token: 0x06002DC6 RID: 11718 RVA: 0x001D3D6C File Offset: 0x001D1F6C
		public static void Convert(int i, int j, int conversionType, int size = 4)
		{
		}

		// Token: 0x06002DC7 RID: 11719 RVA: 0x001D441C File Offset: 0x001D261C
		public static void CactusFrame(int i, int j)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool flag = WorldGen.CheckCactus(i, j);
			if (num == 0)
			{
			}
			Tile tile;
			bool flag2 = tile.active();
			if (num == 0)
			{
			}
			Tile tile2;
			ushort type = tile2.type;
			if (num == 0)
			{
			}
			Tile tile3;
			bool isLoaded = tile3.IsLoaded;
			if (num == 0)
			{
			}
			Tile tile4;
			bool flag3 = tile4.active();
			if (num == 0)
			{
			}
			Tile tile5;
			ushort type2 = tile5.type;
			if (num == 0)
			{
			}
			Tile tile6;
			bool flag4 = tile6.active();
			Tile tile7;
			ushort type3 = tile7.type;
			Tile tile8;
			bool flag5 = tile8.active();
			Tile tile9;
			ushort type4 = tile9.type;
			Tile tile10;
			bool flag6 = tile10.active();
			Tile tile11;
			ushort type5 = tile11.type;
			Tile tile12;
			bool flag7 = tile12.active();
			Tile tile13;
			ushort type6 = tile13.type;
		}

		// Token: 0x06002DC8 RID: 11720 RVA: 0x001D466C File Offset: 0x001D286C
		public static void GrowCactus(int i, int j)
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
			Tile tile2;
			bool flag2 = tile2.halfBrick();
			if (num == 0)
			{
			}
			byte liquid2;
			if (43143168 != 0)
			{
				if (num == 0)
				{
				}
				Tile tile3;
				byte liquid = tile3.liquid;
				if (num == 0)
				{
				}
				Tile tile4;
				ushort type = tile4.type;
				if (num == 0)
				{
				}
				Tile tile5;
				ushort type2 = tile5.type;
				if (num == 0)
				{
				}
				Tile tile6;
				ushort type3 = tile6.type;
				if (num == 0)
				{
				}
				Tile tile7;
				ushort type4 = tile7.type;
				if (num == 0)
				{
				}
				Tile tile8;
				ushort type5 = tile8.type;
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
				Tile tile9;
				liquid2 = tile9.liquid;
				return;
			}
			if (liquid2 == 0)
			{
			}
			Tile tile10;
			byte b = tile10.slope();
		}

		// Token: 0x06002DC9 RID: 11721 RVA: 0x001D4AE0 File Offset: 0x001D2CE0
		public static void CheckPot(int i, int j, int type = 28)
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
				Tile tile;
				short frameX = tile.frameX;
				Tile tile2;
				short frameY = tile2.frameY;
				return;
			}
		}

		// Token: 0x06002DCA RID: 11722 RVA: 0x001D4D1C File Offset: 0x001D2F1C
		private static void SpawnThingsFromPot(int i, int j, int x2, int y2, int style)
		{
			if (!true)
			{
			}
			int underworldLayer = Main.UnderworldLayer;
			int underworldLayer2 = Main.UnderworldLayer;
		}

		// Token: 0x06002DCB RID: 11723 RVA: 0x001D5258 File Offset: 0x001D3458
		public static int PlaceChest(int x, int y, ushort type = 21, bool notNearOtherChests = false, int style = 0)
		{
			if (!true)
			{
			}
			Tile tile;
			ushort type2 = tile.type;
			Tile tile2;
			ushort type3 = tile2.type;
			long num = 0L;
			bool flag = Chest.NearOtherChests(42168200, x);
			int num2 = Chest.CreateChest(42187544, (int)type, (int)num);
			bool netClientOnly = Main.NetClientOnly;
			bool netClientOnly2 = Main.NetClientOnly;
			return 34;
		}

		// Token: 0x06002DCC RID: 11724 RVA: 0x001D52B4 File Offset: 0x001D34B4
		public static void PlaceChestDirect(int x, int y, ushort type, int style, int id)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int num2 = 1;
			Tile tile;
			tile.active(num2 != 0);
			long num3 = 0L;
			tile.frameY = (short)num3;
			tile.frameX = (short)style;
			tile.type = type;
			long num4 = 0L;
			tile.halfBrick(num4 != 0L);
			int num5 = 1;
			Tile tile2;
			tile2.active(num5 != 0);
			long num6 = 0L;
			tile2.frameY = (short)num6;
			tile2.type = type;
			long num7 = 0L;
			tile2.halfBrick(num7 != 0L);
			int num8 = 1;
			Tile tile3;
			tile3.active(num8 != 0);
			int num9 = 18;
			tile3.frameY = (short)num9;
			tile3.frameX = (short)style;
			tile3.type = type;
			long num10 = 0L;
			tile3.halfBrick(num10 != 0L);
			int num11 = 1;
			Tile tile4;
			tile4.active(num11 != 0);
			int num12 = 18;
			tile4.frameY = (short)num12;
			tile4.type = type;
			long num13 = 0L;
			tile4.halfBrick(num13 != 0L);
		}

		// Token: 0x06002DCD RID: 11725 RVA: 0x001D5384 File Offset: 0x001D3584
		public static void PlaceDresserDirect(int x, int y, ushort type, int style, int id)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int num2 = 1;
			Tile tile;
			tile.active(num2 != 0);
			long num3 = 0L;
			tile.frameY = (short)num3;
			tile.frameX = (short)id;
			tile.type = type;
			int num4 = 1;
			Tile tile2;
			tile2.active(num4 != 0);
			long num5 = 0L;
			tile2.frameY = (short)num5;
			tile2.frameX = (short)style;
			tile2.type = type;
			int num6 = 1;
			Tile tile3;
			tile3.active(num6 != 0);
			long num7 = 0L;
			tile3.frameY = (short)num7;
			tile3.type = type;
			int num8 = 1;
			Tile tile4;
			tile4.active(num8 != 0);
			int num9 = 18;
			tile4.frameY = (short)num9;
			tile4.frameX = (short)id;
			tile4.type = type;
			int num10 = 1;
			Tile tile5;
			tile5.active(num10 != 0);
			int num11 = 18;
			tile5.frameY = (short)num11;
			tile5.frameX = (short)style;
			tile5.type = type;
			int num12 = 1;
			Tile tile6;
			tile6.active(num12 != 0);
			int num13 = 18;
			tile6.frameY = (short)num13;
			tile6.type = type;
		}

		// Token: 0x06002DCE RID: 11726 RVA: 0x001D5478 File Offset: 0x001D3678
		public static void CheckChest(int i, int j, int type)
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
				Tile tile;
				short frameX = tile.frameX;
				Tile tile2;
				short frameY = tile2.frameY;
				int num2 = 65533;
				if (num2 == 0)
				{
				}
				Tile tile3;
				short frameX2 = tile3.frameX;
				Tile tile4;
				bool flag = tile4.active();
				if (num2 == 0)
				{
				}
				Tile tile5;
				ushort type2 = tile5.type;
				if (num2 == 0)
				{
				}
				Tile tile6;
				short frameY2 = tile6.frameY;
				return;
			}
		}

		// Token: 0x06002DCF RID: 11727 RVA: 0x001D55A8 File Offset: 0x001D37A8
		private static int GetChestItemDrop(int x, int y, int type)
		{
			/*
An exception occurred when decompiling this method (06002DCF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.WorldGen::GetChestItemDrop(System.Int32,System.Int32,System.Int32)

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

		// Token: 0x06002DD0 RID: 11728 RVA: 0x001D55C0 File Offset: 0x001D37C0
		public static bool PlaceActuator(int i, int j)
		{
			if (!true)
			{
			}
			Tile tile;
			return tile.actuator();
		}

		// Token: 0x06002DD1 RID: 11729 RVA: 0x001D55EC File Offset: 0x001D37EC
		public static bool KillActuator(int i, int j)
		{
			if (!true)
			{
			}
			Tile tile;
			bool flag = tile.actuator();
			if (!true)
			{
			}
			long num = 0L;
			Tile tile2;
			tile2.actuator(num != 0L);
			bool logicHost = Main.LogicHost;
			return true;
		}

		// Token: 0x06002DD2 RID: 11730 RVA: 0x001D5628 File Offset: 0x001D3828
		public static bool PlaceWire(int i, int j)
		{
			if (!true)
			{
			}
			Tile tile;
			return tile.wire();
		}

		// Token: 0x06002DD3 RID: 11731 RVA: 0x001D5654 File Offset: 0x001D3854
		public static bool KillWire(int i, int j)
		{
			if (!true)
			{
			}
			Tile tile;
			bool flag = tile.wire();
			if (!true)
			{
			}
			long num = 0L;
			Tile tile2;
			tile2.wire(num != 0L);
			bool logicHost = Main.LogicHost;
			return true;
		}

		// Token: 0x06002DD4 RID: 11732 RVA: 0x001D5690 File Offset: 0x001D3890
		public static bool PlaceWire2(int i, int j)
		{
			if (!true)
			{
			}
			Tile tile;
			return tile.wire2();
		}

		// Token: 0x06002DD5 RID: 11733 RVA: 0x001D56BC File Offset: 0x001D38BC
		public static bool KillWire2(int i, int j)
		{
			if (!true)
			{
			}
			Tile tile;
			bool flag = tile.wire2();
			if (!true)
			{
			}
			long num = 0L;
			Tile tile2;
			tile2.wire2(num != 0L);
			bool logicHost = Main.LogicHost;
			return true;
		}

		// Token: 0x06002DD6 RID: 11734 RVA: 0x001D56F8 File Offset: 0x001D38F8
		public static bool PlaceWire3(int i, int j)
		{
			if (!true)
			{
			}
			Tile tile;
			return tile.wire3();
		}

		// Token: 0x06002DD7 RID: 11735 RVA: 0x001D5724 File Offset: 0x001D3924
		public static bool KillWire3(int i, int j)
		{
			if (!true)
			{
			}
			Tile tile;
			bool flag = tile.wire3();
			if (!true)
			{
			}
			long num = 0L;
			Tile tile2;
			tile2.wire3(num != 0L);
			bool logicHost = Main.LogicHost;
			return true;
		}

		// Token: 0x06002DD8 RID: 11736 RVA: 0x001D5760 File Offset: 0x001D3960
		public static bool PlaceWire4(int i, int j)
		{
			if (!true)
			{
			}
			Tile tile;
			return tile.wire4();
		}

		// Token: 0x06002DD9 RID: 11737 RVA: 0x001D578C File Offset: 0x001D398C
		public static bool KillWire4(int i, int j)
		{
			if (!true)
			{
			}
			Tile tile;
			bool flag = tile.wire4();
			if (!true)
			{
			}
			long num = 0L;
			Tile tile2;
			tile2.wire4(num != 0L);
			bool logicHost = Main.LogicHost;
			return true;
		}

		// Token: 0x06002DDA RID: 11738 RVA: 0x001D57C8 File Offset: 0x001D39C8
		public static bool IsFitToPlaceFlowerIn(int x, int y, int typeAttemptedToPlace)
		{
			/*
An exception occurred when decompiling this method (06002DDA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::IsFitToPlaceFlowerIn(System.Int32,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:bool(var_1_09, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_0)))
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

		// Token: 0x06002DDB RID: 11739 RVA: 0x001D57E4 File Offset: 0x001D39E4
		private static bool SeaOatWaterCheck(int x, int y)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06002DDC RID: 11740 RVA: 0x001D57FC File Offset: 0x001D39FC
		private static bool PlantSeaOat(int x, int y)
		{
			/*
An exception occurred when decompiling this method (06002DDC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::PlantSeaOat(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001B:
	stloc:uint16(var_7_22, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_6)))
	stloc:bool(var_8_2B, call:bool(WorldGen::SeaOatWaterCheck, ldc.i4:int32(0), ldloc:int32(x)))
	stloc:UnifiedRandom(var_13_42, callgetter:UnifiedRandom(WorldGen::get_genRand))
	stloc:int32(var_14_45, ldc.i4:int32(5))
	stloc:int32(var_15_50, call:int32(UnifiedRandom::Next, ldloc:UnifiedRandom(var_13_42), ldloc:int32(var_14_45)))
	stloc:bool(var_18_5D, callgetter:bool(Main::get_NetHost))
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

		// Token: 0x06002DDD RID: 11741 RVA: 0x001D5870 File Offset: 0x001D3A70
		private static bool CheckSeaOat(int x, int y)
		{
			if (!true)
			{
			}
			bool flag = WorldGen.SeaOatWaterCheck(0, x);
			return true;
		}

		// Token: 0x06002DDE RID: 11742 RVA: 0x001D58AC File Offset: 0x001D3AAC
		private static bool GrowSeaOat(int x, int y)
		{
			/*
An exception occurred when decompiling this method (06002DDE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::GrowSeaOat(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0011:
	stloc:bool(var_6_19, callgetter:bool(Main::get_NetHost))
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

		// Token: 0x06002DDF RID: 11743 RVA: 0x001D58D8 File Offset: 0x001D3AD8
		private static int GetWaterDepth(int x, int y)
		{
			/*
An exception occurred when decompiling this method (06002DDF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.WorldGen::GetWaterDepth(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0024:
	stloc:int64(var_6_25, ldc.i4:int64(0))
	stloc:bool(var_7_34, call:bool(WorldGen::SolidTile, ldc.i4:int32(0), ldc.i4:int32(43143168), ldloc:int64[exp:bool](var_6_25)))
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

		// Token: 0x06002DE0 RID: 11744 RVA: 0x001D591C File Offset: 0x001D3B1C
		private static int CountGrowingPlantTiles(int x, int y, int range, int type)
		{
			/*
An exception occurred when decompiling this method (06002DE0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.WorldGen::CountGrowingPlantTiles(System.Int32,System.Int32,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0014:
	stloc:uint16(var_6_1B, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_5)))
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

		// Token: 0x06002DE1 RID: 11745 RVA: 0x001D5948 File Offset: 0x001D3B48
		private static bool PlaceBamboo(int x, int y)
		{
			if (!true)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num = 1;
			int num2 = 21;
			int num3 = genRand.Next(num, num2);
			Tile tile;
			ushort wall = tile.wall;
			Tile tile2;
			ushort type = tile2.type;
			int waterDepth = WorldGen.GetWaterDepth(0, x);
			int num4 = 5;
			int num5 = 571;
			int num6 = WorldGen.CountGrowingPlantTiles(0, x, num4, num5);
			long num7 = 0L;
			long num8 = 0L;
			bool flag = WorldGen.SolidTile(0, (int)num7, num8 != 0L);
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num9 = 1;
			int num10 = 21;
			int num11 = genRand2.Next(num9, num10);
			UnifiedRandom genRand3 = WorldGen.genRand;
			int num12 = 40;
			int num13 = 61;
			int num14 = genRand3.Next(num12, num13);
			int num15 = 1;
			Tile tile3;
			tile3.active(num15 != 0);
			int num16 = 571;
			tile3.type = (ushort)num16;
			long num17 = 0L;
			tile3.frameX = (short)num17;
			long num18 = 0L;
			tile3.frameY = (short)num18;
			long num19 = 0L;
			tile3.slope((byte)num19);
			long num20 = 0L;
			tile3.halfBrick(num20 != 0L);
			int num21 = 1;
			WorldGen.SquareTileFrame(0, x, num21 != 0);
			return false;
		}

		// Token: 0x06002DE2 RID: 11746 RVA: 0x001D5A48 File Offset: 0x001D3C48
		public static void CheckBamboo(int x, int y)
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
			bool isLoaded2 = tile2.IsLoaded;
			if (num == 0)
			{
			}
			Tile tile3;
			bool isLoaded3 = tile3.IsLoaded;
		}

		// Token: 0x06002DE3 RID: 11747 RVA: 0x001D5B14 File Offset: 0x001D3D14
		public static void PlaceUnderwaterPlant(ushort type, int x, int y)
		{
			int num = 1;
			if (num == 0)
			{
			}
			long num2 = 0L;
			bool flag = WorldGen.CanUnderwaterPlantGrowHere(type, x, y, num2 != 0L);
			Tile tileSafely = Framing.GetTileSafely(x, x);
			long num3 = 0L;
			tileSafely.slope((byte)num3);
			long num4 = 0L;
			tileSafely.halfBrick(num4 != 0L);
			Tile tileSafely2 = Framing.GetTileSafely(x, y);
			int num5 = 1;
			tileSafely2.active(num5 != 0);
			tileSafely2.type = type;
			long num6 = 0L;
			tileSafely2.frameX = (short)num6;
			long num7 = 0L;
			tileSafely2.frameY = (short)num7;
			long num8 = 0L;
			tileSafely2.slope((byte)num8);
			long num9 = 0L;
			tileSafely2.halfBrick(num9 != 0L);
			if (num == 0)
			{
			}
			int num10 = 1;
			WorldGen.SquareTileFrame(x, y, num10 != 0);
		}

		// Token: 0x06002DE4 RID: 11748 RVA: 0x001D5BAC File Offset: 0x001D3DAC
		public static bool CanUnderwaterPlantGrowHere(ushort type, int x, int y, bool ignoreSelf)
		{
			/*
An exception occurred when decompiling this method (06002DE4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::CanUnderwaterPlantGrowHere(System.UInt16,System.Int32,System.Int32,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_004B:
	stloc:uint16(var_12_57, callgetter:uint16(Tile::get_wall, call:Tile[exp:valuetype Terraria.Tile&](Framing::GetTileSafely, ldloc:uint16[exp:int32](type), ldloc:int32(x))))
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

		// Token: 0x06002DE5 RID: 11749 RVA: 0x001D5C18 File Offset: 0x001D3E18
		public static void CheckUnderwaterPlant(ushort type, int x, int y)
		{
			if (!true)
			{
			}
			int num = 1;
			bool flag = WorldGen.CanUnderwaterPlantGrowHere(type, x, y, num != 0);
			Tile tileSafely = Framing.GetTileSafely(x, x);
			Tile tileSafely2 = Framing.GetTileSafely(x, y);
			bool flag2 = Framing.GetTileSafely(x, y).active();
		}

		// Token: 0x06002DE6 RID: 11750 RVA: 0x001D5CE0 File Offset: 0x001D3EE0
		public static Point PlaceCatTail(int x, int j)
		{
			if (!true)
			{
			}
			Tile tile;
			bool flag = tile.active();
			Tile tile2;
			ushort type = tile2.type;
			Tile tile3;
			byte liquid = tile3.liquid;
			Tile tile4;
			byte b = tile4.liquidType();
			Tile tile5;
			byte liquid2 = tile5.liquid;
			Tile tile6;
			bool flag2 = tile6.active();
			Tile tile7;
			bool flag3 = tile7.active();
			Tile tile8;
			byte liquid3 = tile8.liquid;
			Tile tile9;
			byte b2 = tile9.liquidType();
			Tile tile10;
			ushort wall = tile10.wall;
			Tile tile11;
			ushort wall2 = tile11.wall;
			Tile tile12;
			ushort wall3 = tile12.wall;
			Tile tile13;
			ushort wall4 = tile13.wall;
			Tile tile14;
			ushort wall5 = tile14.wall;
			Tile tile15;
			ushort wall6 = tile15.wall;
			Tile tile16;
			bool flag4 = tile16.active();
			Tile tile17;
			ushort type2 = tile17.type;
			Tile tile18;
			bool flag5 = tile18.active();
			Tile tile19;
			ushort type3 = tile19.type;
			Tile tile20;
			ushort type4 = tile20.type;
			Tile tile21;
			bool flag6 = tile21.active();
			Tile tile22;
			ushort type5 = tile22.type;
			Tile tile23;
			ushort type6 = tile23.type;
			Tile tile24;
			bool flag7 = tile24.nactive();
			return 0;
		}

		// Token: 0x06002DE7 RID: 11751 RVA: 0x001D5EB0 File Offset: 0x001D40B0
		public static void CheckCatTail(int x, int j)
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
			bool flag = tile2.active();
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
					Tile tile5;
					bool isLoaded2 = tile5.IsLoaded;
					Tile tile6;
					byte liquid = tile6.liquid;
					Tile tile7;
					bool flag2 = tile7.active();
					Tile tile8;
					ushort type3 = tile8.type;
					Tile tile9;
					byte b = tile9.liquidType();
					Tile tile10;
					bool isLoaded3 = tile10.IsLoaded;
					return;
				}
			}
			if (num == 0)
			{
			}
			Tile tile11;
			bool flag3 = tile11.active();
			Tile tile12;
			ushort type4 = tile12.type;
			Tile tile13;
			bool flag4 = tile13.active();
			Tile tile14;
			bool isLoaded4 = tile14.IsLoaded;
		}

		// Token: 0x06002DE8 RID: 11752 RVA: 0x001D60D8 File Offset: 0x001D42D8
		public static void GrowCheckSeaweed(int x, int y)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool logicHost = Main.LogicHost;
			if (num == 0)
			{
			}
			Tile tile;
			ushort type = tile.type;
			if (num == 0)
			{
			}
			Tile tile2;
			byte liquid = tile2.liquid;
			if (num == 0)
			{
			}
			Tile tile3;
			byte liquid2 = tile3.liquid;
			if (num == 0)
			{
			}
			Tile tile4;
			bool flag = tile4.active();
			if (num == 0)
			{
			}
			Tile tile5;
			bool flag2 = tile5.active();
			if (num == 0)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num2 = 1;
			if (genRand.Next(num2) == 0)
			{
				if (num == 0)
				{
				}
				Tile tile6;
				byte liquid3 = tile6.liquid;
				if (num == 0)
				{
				}
				long num3 = 0L;
				Tile tile7;
				byte liquid4 = tile7.liquid;
				if (num == 0)
				{
				}
				long num4 = 0L;
				bool flag3 = WorldGen.SolidTile(x, (int)num3, num4 != 0L);
				if (num == 0)
				{
				}
				return;
			}
		}

		// Token: 0x06002DE9 RID: 11753 RVA: 0x001D6264 File Offset: 0x001D4464
		public static void GrowCatTail(int x, int j)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool logicHost = Main.LogicHost;
			if (num == 0)
			{
			}
			Tile tile;
			byte liquid = tile.liquid;
			Tile tile2;
			bool flag = tile2.active();
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
					if (num == 0)
					{
					}
					Tile tile5;
					bool flag2 = tile5.active();
					if (num == 0)
					{
					}
					Tile tile6;
					short frameX = tile6.frameX;
					if (num == 0)
					{
					}
					Tile tile7;
					bool flag3 = tile7.active();
					if (num == 0)
					{
					}
					Tile tile8;
					ushort type3 = tile8.type;
					if (num != 0)
					{
						if (num == 0)
						{
						}
						long num2 = 0L;
						long num3 = 0L;
						long num4 = 0L;
						WorldGen.KillTile(x, num, num2 != 0L, num3 != 0L, num4 != 0L);
						if (num == 0)
						{
						}
						bool netHost = Main.NetHost;
						if (num == 0)
						{
						}
					}
					if (num == 0)
					{
					}
					Tile tile9;
					bool flag4 = tile9.active();
					if (num == 0)
					{
					}
					Tile tile10;
					if (tile10.frameX != 0)
					{
						Tile tile11;
						short frameX2 = tile11.frameX;
						UnifiedRandom genRand = WorldGen.genRand;
						int num5 = 2;
						int num6 = 5;
						int num7 = genRand.Next(num5, num6);
						int num8 = 1;
						Tile tile12;
						tile12.active(num8 != 0);
						int num9 = 519;
						tile12.type = (ushort)num9;
						int num10 = 90;
						tile12.frameX = (short)num10;
						Tile tile13;
						short frameY = tile13.frameY;
						return;
					}
					int num11 = 18;
					Tile tile14;
					tile14.frameX = (short)num11;
					int num12 = 1;
					WorldGen.SquareTileFrame(x, 0, num12 != 0);
					bool netHost2 = Main.NetHost;
					return;
				}
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06002DEA RID: 11754 RVA: 0x001D64FC File Offset: 0x001D46FC
		public static bool PlaceLilyPad(int x, int j)
		{
			if (!true)
			{
			}
			Tile tile;
			bool flag = tile.active();
			Tile tile2;
			byte liquid = tile2.liquid;
			Tile tile3;
			byte b = tile3.liquidType();
			Tile tile4;
			byte liquid2 = tile4.liquid;
			Tile tile5;
			bool flag2 = tile5.active();
			Tile tile6;
			bool flag3 = tile6.active();
			Tile tile7;
			byte liquid3 = tile7.liquid;
			Tile tile8;
			byte b2 = tile8.liquidType();
			Tile tile9;
			ushort wall = tile9.wall;
			Tile tile10;
			ushort wall2 = tile10.wall;
			Tile tile11;
			ushort wall3 = tile11.wall;
			Tile tile12;
			bool flag4 = tile12.active();
			Tile tile13;
			ushort type = tile13.type;
			Tile tile14;
			bool flag5 = tile14.active();
			Tile tile15;
			ushort type2 = tile15.type;
			Tile tile16;
			ushort type3 = tile16.type;
			Tile tile17;
			bool flag6 = tile17.active();
			Tile tile18;
			ushort type4 = tile18.type;
			Tile tile19;
			ushort type5 = tile19.type;
			long num = 0L;
			if (num == 0L)
			{
			}
			Tile tile20;
			ushort wall4 = tile20.wall;
			if (num == 0L)
			{
			}
			Tile tile21;
			ushort wall5 = tile21.wall;
			int num2 = 18;
			int num3 = 36;
			if (num2 == 0)
			{
			}
			int num4 = 1;
			Tile tile22;
			tile22.active(num4 != 0);
			int num5 = 518;
			tile22.type = (ushort)num5;
			if (num2 == 0)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num6 = 2;
			int num7 = genRand.Next(num6);
			if (num3 == 0)
			{
			}
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num9;
			if (num7 != 0)
			{
				int num8 = 15;
				if (genRand2.Next(num8) != 0)
				{
					num9 = 26215;
					UnifiedRandom genRand3 = WorldGen.genRand;
				}
			}
			UnifiedRandom genRand4 = WorldGen.genRand;
			int num10 = 18;
			int num11 = genRand4.Next(num10);
			UnifiedRandom genRand5 = WorldGen.genRand;
			UnifiedRandom genRand6 = WorldGen.genRand;
			if (num9 == 0)
			{
			}
			UnifiedRandom genRand7 = WorldGen.genRand;
			int num12 = 12;
			int num13 = 15;
			int num14 = genRand7.Next(num12, num13);
			int num15 = 1;
			WorldGen.SquareTileFrame(0, 0, num15 != 0);
			return false;
		}

		// Token: 0x06002DEB RID: 11755 RVA: 0x001D66DC File Offset: 0x001D48DC
		public static void CheckLilyPad(int x, int y)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool logicHost = Main.LogicHost;
			if (num == 0)
			{
			}
			Tile tile;
			byte b = tile.liquidType();
			if (num == 0)
			{
			}
			long num2 = 0L;
			long num3 = 0L;
			long num4 = 0L;
			WorldGen.KillTile(x, y, num2 != 0L, num3 != 0L, num4 != 0L);
			if (num == 0)
			{
			}
			bool netHost = Main.NetHost;
			if (num == 0)
			{
			}
		}

		// Token: 0x06002DEC RID: 11756 RVA: 0x001D68B8 File Offset: 0x001D4AB8
		public static bool TryKillingReplaceableTile(int x, int y, int tileType)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int num2 = 2;
			bool flag = WorldGen.InWorld(0, x, num2);
			if (num == 0)
			{
			}
			Tile tile;
			bool flag2 = tile.active();
			if (num == 0)
			{
			}
			Tile tile2;
			ushort type = tile2.type;
			if (num == 0)
			{
				if (num == 0)
				{
				}
				Tile tile3;
				ushort type2 = tile3.type;
			}
			Tile tile4;
			ushort type3 = tile4.type;
			Tile tile5;
			ushort type4 = tile5.type;
			Tile tile6;
			ushort type5 = tile6.type;
			Tile tile7;
			ushort type6 = tile7.type;
			Tile tile8;
			ushort type7 = tile8.type;
			Tile tile9;
			ushort type8 = tile9.type;
			Tile tile10;
			ushort type9 = tile10.type;
			Tile tile11;
			ushort type10 = tile11.type;
			Tile tile12;
			ushort type11 = tile12.type;
			Tile tile13;
			ushort type12 = tile13.type;
			Tile tile14;
			ushort type13 = tile14.type;
			long num3 = 0L;
			Tile tile15;
			short frameX = tile15.frameX;
			return WorldGen.IsHarvestableHerbWithSeed(0, (int)num3);
		}

		// Token: 0x06002DED RID: 11757 RVA: 0x001D69D0 File Offset: 0x001D4BD0
		public static bool PlaceTile(int i, int j, int Type, bool mute = false, bool forced = false, int plr = -1, int style = 0)
		{
			int num = 1;
			if (num == 0)
			{
			}
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
			bool flag2 = tile3.active();
			long num2 = 0L;
			bool flag3 = Collision.EmptyTile(42168472, i, num2 != 0L);
			if (42168472 == 0)
			{
			}
			if (42168472 != 0)
			{
				bool flag4;
				return flag4;
			}
			bool flag5;
			return flag5;
		}

		// Token: 0x06002DEE RID: 11758 RVA: 0x001D7C60 File Offset: 0x001D5E60
		public static void KillWall(int i, int j, bool fail = false)
		{
			if (!true)
			{
			}
			Tile tile;
			ushort wall = tile.wall;
			int num = 10;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int num2 = 1;
			WorldGen.SquareWallFrame(i, j, num2 != 0);
		}

		// Token: 0x06002DEF RID: 11759 RVA: 0x001D7CBC File Offset: 0x001D5EBC
		private static bool KillWall_CheckFailure(bool fail, Tile tileCache)
		{
			/*
An exception occurred when decompiling this method (06002DEF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::KillWall_CheckFailure(System.Boolean,Terraria.Tile)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000B:
	brtrue(IL_0000, ldloc:int32[exp:bool](var_0_01))
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

		// Token: 0x06002DF0 RID: 11760 RVA: 0x001D7CD8 File Offset: 0x001D5ED8
		private static void KillWall_PlaySounds(int i, int j, Tile tileCache)
		{
		}

		// Token: 0x06002DF1 RID: 11761 RVA: 0x001D7CE8 File Offset: 0x001D5EE8
		private static void KillWall_DropItems(int i, int j, Tile tileCache)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x06002DF2 RID: 11762 RVA: 0x001D7D00 File Offset: 0x001D5F00
		private static int KillWall_GetItemDrops(Tile tileCache)
		{
			return 1383;
		}

		// Token: 0x06002DF3 RID: 11763 RVA: 0x001D80D4 File Offset: 0x001D62D4
		private static void KillWall_MakeWallDust(int i, int j, Tile tileCache)
		{
		}

		// Token: 0x06002DF4 RID: 11764 RVA: 0x001D834C File Offset: 0x001D654C
		public static void LaunchRocket(int x, int y, bool fromWiring)
		{
			if (!true)
			{
			}
			Tile tile;
			short frameY = tile.frameY;
		}

		// Token: 0x06002DF5 RID: 11765 RVA: 0x001D83A8 File Offset: 0x001D65A8
		public static void LaunchRocketSmall(int x, int y, bool fromWiring)
		{
			if (!true)
			{
			}
			Tile tile;
			short frameX = tile.frameX;
			Tile tile2;
			short frameY = tile2.frameY;
			if (frameX == 0)
			{
			}
			long num = 0L;
			Player localPlayer = Main.LocalPlayer;
			IEntitySource projectileSource_PlayerOrWires = WorldGen.GetProjectileSource_PlayerOrWires(x, 43143168, num != 0L, localPlayer);
			int myPlayer = Main.myPlayer;
		}

		// Token: 0x06002DF6 RID: 11766 RVA: 0x001D83F4 File Offset: 0x001D65F4
		public static bool CanKillTile(int i, int j, WorldGen.SpecialKillTileContext context)
		{
			if (!true)
			{
			}
			Tile tile;
			bool isLoaded = tile.IsLoaded;
			return true;
		}

		// Token: 0x06002DF7 RID: 11767 RVA: 0x001D8418 File Offset: 0x001D6618
		public static bool CanKillTile(int i, int j)
		{
			if (!true)
			{
			}
			return WorldGen.CanKillTile(0, i, j != 0);
		}

		// Token: 0x06002DF8 RID: 11768 RVA: 0x001D8430 File Offset: 0x001D6630
		public static bool CanKillTile(int i, int j, [Out] bool blockDamaged)
		{
			bool flag = WorldGen.CheckBoulderChest(0, i);
			int num = 1;
			j.m_value = num;
			if (num != 0)
			{
				if (num == 0)
				{
				}
				Tile tile;
				short frameX = tile.frameX;
			}
			if (num == 0)
			{
			}
			Tile tile2;
			short frameX2 = tile2.frameX;
			if (num == 0)
			{
			}
			Tile tile3;
			short frameX3 = tile3.frameX;
			return 42168200 != 0;
		}

		// Token: 0x06002DF9 RID: 11769 RVA: 0x001D850C File Offset: 0x001D670C
		public static bool IsTileReplacable(int x, int y)
		{
			/*
An exception occurred when decompiling this method (06002DF9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::IsTileReplacable(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001E:
	brtrue(IL_0000, logicnot:bool(ldloc:int32[exp:bool](var_0_01)))
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

		// Token: 0x06002DFA RID: 11770 RVA: 0x001D853C File Offset: 0x001D673C
		public static int CheckTileBreakability(int x, int y)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Tile tile;
			bool isLoaded = tile.IsLoaded;
			long num2 = 0L;
			bool flag = WorldGen.IsLockedDoor(0, (int)num2);
			bool flag2 = WorldGen.IsLockedDoor(0, 43143168);
			long num3 = 0L;
			if (num3 != 0L)
			{
				if (num3 == 0L)
				{
				}
				if (num3 == 0L)
				{
					return 2;
				}
			}
			if (num3 == 0L)
			{
			}
			return 1;
		}

		// Token: 0x06002DFB RID: 11771 RVA: 0x001D85D0 File Offset: 0x001D67D0
		public static bool CheckTileBreakability2_ShouldTileSurvive(int x, int y)
		{
			if (!true)
			{
			}
			return Main.NetClientOnly;
		}

		// Token: 0x06002DFC RID: 11772 RVA: 0x001D8634 File Offset: 0x001D6834
		public static bool ReplaceWall(int x, int y, ushort targetWall)
		{
			/*
An exception occurred when decompiling this method (06002DFC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::ReplaceWall(System.Int32,System.Int32,System.UInt16)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0015:
	stloc:int32(var_5_16, ldc.i4:int32(1))
	call:void(WorldGen::SquareWallFrame, ldloc:int64[exp:int32](var_4), ldloc:int32(x), ldloc:int32[exp:bool](var_5_16))
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

		// Token: 0x06002DFD RID: 11773 RVA: 0x001D8664 File Offset: 0x001D6864
		public static bool ReplaceTile(int x, int y, ushort targetType, int targetStyle)
		{
			Tile tileSafely = Framing.GetTileSafely(0, x);
			bool flag = WorldGen.WouldTileReplacementWork((ushort)y, x, x);
			bool flag2 = WorldGen.IsTileReplacable(0, x);
			if (!false)
			{
			}
			if (!false)
			{
				return;
			}
		}

		// Token: 0x06002DFE RID: 11774 RVA: 0x001D8698 File Offset: 0x001D6898
		private static void ReplaceTIle_DoActualReplacement(ushort targetType, int targetStyle, int topLeftX, int topLeftY, Tile t)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			bool flag = WorldGen.IsChestRigged(topLeftX, topLeftY);
			bool logicHost = Main.LogicHost;
			Wiring.HitSwitch(topLeftX, topLeftY);
		}

		// Token: 0x06002DFF RID: 11775 RVA: 0x001D86E0 File Offset: 0x001D68E0
		private static void ReplaceTile_DoActualReplacement_Single(ushort targetType, int targetStyle, int topLeftX, int topLeftY, Tile t)
		{
			int num = 1;
			if (num == 0)
			{
			}
			WorldGen.ReplaceTile_EliminateNaturalExtras(topLeftX, topLeftY);
			if (num == 0)
			{
			}
			if (num != 0)
			{
			}
			if (22 == 0)
			{
			}
			bool flag = WorldGen.CanPoundTile(topLeftX, topLeftY);
			int num2 = 1;
			WorldGen.SquareTileFrame(topLeftX, topLeftY, num2 != 0);
		}

		// Token: 0x06002E00 RID: 11776 RVA: 0x001D8728 File Offset: 0x001D6928
		private static void ReplaceTile_EliminateNaturalExtras(int x, int y)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int num2 = 2;
			bool flag = WorldGen.InWorld(x, y, num2);
			if (num == 0)
			{
			}
			Tile tile;
			bool flag2 = tile.active();
			Tile tile2;
			ushort type = tile2.type;
			long num3 = 0L;
			long num4 = 0L;
			long num5 = 0L;
			WorldGen.KillTile(x, 43143168, num3 != 0L, num4 != 0L, num5 != 0L);
			Tile tile3;
			bool flag3 = tile3.active();
			Tile tile4;
			ushort type2 = tile4.type;
			long num6 = 0L;
			long num7 = 0L;
			long num8 = 0L;
			WorldGen.KillTile(x, y, num6 != 0L, num7 != 0L, num8 != 0L);
		}

		// Token: 0x06002E01 RID: 11777 RVA: 0x001D87E8 File Offset: 0x001D69E8
		private static void ReplaceTile_DoActualReplacement_Area(ushort targetType, int targetStyle, int topLeftX, int topLeftY, int areaSizeX, int areaSizeY)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Tile tile;
			tile.type = targetType;
			tile.frameX = (short)targetType;
			tile.frameY = (short)targetType;
			tile.ClearBlockPaintAndCoating();
			if (num == 0)
			{
			}
			int num2 = 1;
			WorldGen.SquareTileFrame((int)targetType, topLeftY, num2 != 0);
		}

		// Token: 0x06002E02 RID: 11778 RVA: 0x001D882C File Offset: 0x001D6A2C
		private static void MoveReplaceTileAnchor(int x, int y, ushort targetType, Tile t)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				x.m_value = num;
				y.m_value = num;
			}
			if (num == 0)
			{
			}
			if (num != 0)
			{
				x.m_value = num;
				y.m_value = num;
			}
			x.m_value = num;
			y.m_value = num;
		}

		// Token: 0x06002E03 RID: 11779 RVA: 0x001D8874 File Offset: 0x001D6A74
		public static bool WouldTileReplacementBeBlockedByLiquid(int x, int y, int liquidType)
		{
			/*
An exception occurred when decompiling this method (06002E03)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::WouldTileReplacementBeBlockedByLiquid(System.Int32,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0047:
	stloc:uint8(var_15_4E, call:uint8(Tile::liquidType, ldloc:Tile[exp:valuetype Terraria.Tile&](var_14)))
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

		// Token: 0x06002E04 RID: 11780 RVA: 0x001D88D4 File Offset: 0x001D6AD4
		public static bool WouldTileReplacementWork(ushort attemptingToReplaceWith, int x, int y)
		{
			if (!true)
			{
			}
			int num = 2;
			bool flag = WorldGen.InWorld((int)attemptingToReplaceWith, x, num);
			Tile tile;
			bool flag2 = tile.active();
			bool flag3 = WorldGen.ReplaceTile_IsValidSolid(43143168);
			return WorldGen.ReplaceTile_IsValidSolid(0);
		}

		// Token: 0x06002E05 RID: 11781 RVA: 0x001D8990 File Offset: 0x001D6B90
		private static bool ReplaceTile_IsValidSolid(int type)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06002E06 RID: 11782 RVA: 0x000021DB File Offset: 0x000003DB
		private static bool ReplaceTile_IsValidTorch(int type)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002E07 RID: 11783 RVA: 0x000021DB File Offset: 0x000003DB
		private static bool ReplaceTile_IsValidCampfire(int type)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002E08 RID: 11784 RVA: 0x001D89A4 File Offset: 0x001D6BA4
		private static bool ReplaceTile_IsValidChest(int type)
		{
			/*
An exception occurred when decompiling this method (06002E08)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::ReplaceTile_IsValidChest(System.Int32)

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

		// Token: 0x06002E09 RID: 11785 RVA: 0x001D89B4 File Offset: 0x001D6BB4
		private static bool ReplaceTile_IsValidDresser(int type)
		{
			/*
An exception occurred when decompiling this method (06002E09)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::ReplaceTile_IsValidDresser(System.Int32)

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

		// Token: 0x06002E0A RID: 11786 RVA: 0x001D89C4 File Offset: 0x001D6BC4
		private static bool ReplaceTile_IsValidPlatform(int type)
		{
			/*
An exception occurred when decompiling this method (06002E0A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::ReplaceTile_IsValidPlatform(System.Int32)

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

		// Token: 0x06002E0B RID: 11787 RVA: 0x001D89D4 File Offset: 0x001D6BD4
		public static bool GetAshTreeFoliageData(int i, int j, int xoffset, int treeFrame, int treeStyle, [Out] int floorY, [Out] int topTextureFrameWidth, [Out] int topTextureFrameHeight)
		{
			/*
An exception occurred when decompiling this method (06002E0B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::GetAshTreeFoliageData(System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_002E:
	stloc:uint16(var_5_35, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_4)))
	stloc:int32(var_7_3C, ldc.i4:int32(31))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](treeFrame), ldloc:int32(var_7_3C))
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

		// Token: 0x06002E0C RID: 11788 RVA: 0x001D8A2C File Offset: 0x001D6C2C
		public static bool GetVanityTreeFoliageData(int i, int j, int xoffset, int treeFrame, int treeStyle, [Out] int floorY, [Out] int topTextureFrameWidth, [Out] int topTextureFrameHeight)
		{
			/*
An exception occurred when decompiling this method (06002E0C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::GetVanityTreeFoliageData(System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_003D:
	stloc:int32(var_9_42, ldc.i4:int32(29))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](treeFrame), ldloc:int32(var_9_42))
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

		// Token: 0x06002E0D RID: 11789 RVA: 0x001D8A88 File Offset: 0x001D6C88
		public static bool GetGemTreeFoliageData(int i, int j, int xoffset, int treeFrame, int treeStyle, [Out] int floorY, [Out] int topTextureFrameWidth, [Out] int topTextureFrameHeight)
		{
			/*
An exception occurred when decompiling this method (06002E0D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::GetGemTreeFoliageData(System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_003D:
	stloc:bool(var_8_44, callgetter:bool(Tile::get_IsLoaded, ldloc:Tile[exp:valuetype Terraria.Tile&](var_7)))
	stloc:int32(var_12_4B, ldc.i4:int32(28))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](treeFrame), ldloc:int32(var_12_4B))
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

		// Token: 0x06002E0E RID: 11790 RVA: 0x001D8AEC File Offset: 0x001D6CEC
		public static bool GetCommonTreeFoliageData(int i, int j, int xoffset, int treeFrame, int treeStyle, [Out] int floorY, [Out] int topTextureFrameWidth, [Out] int topTextureFrameHeight)
		{
			/*
An exception occurred when decompiling this method (06002E0E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::GetCommonTreeFoliageData(System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_27_119, ldc.i4:int32(26215))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](treeFrame), ldloc:int32(var_27_119))
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

		// Token: 0x06002E0F RID: 11791 RVA: 0x001D8C20 File Offset: 0x001D6E20
		public static int GetHollowTreeFoliageStyle()
		{
			if (!true)
			{
			}
			return 20;
		}

		// Token: 0x06002E10 RID: 11792 RVA: 0x001D8C38 File Offset: 0x001D6E38
		public static int GetTreeFrame(Tile t)
		{
			return 1;
		}

		// Token: 0x06002E11 RID: 11793 RVA: 0x001D8C48 File Offset: 0x001D6E48
		public static TreeTypes GetTreeType(int tileType)
		{
			return TreeTypes.Palm;
		}

		// Token: 0x06002E12 RID: 11794 RVA: 0x001D8C6C File Offset: 0x001D6E6C
		public static bool IsThisAMushroomTree(int i, int j)
		{
			/*
An exception occurred when decompiling this method (06002E12)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::IsThisAMushroomTree(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0006:
	stloc:TreeTypes(var_1_11, call:TreeTypes(WorldGen::GetTreeType, callgetter:uint16[exp:int32](Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_0))))
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

		// Token: 0x06002E13 RID: 11795 RVA: 0x001D8C8C File Offset: 0x001D6E8C
		public static void ResetTreeShakes()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002E14 RID: 11796 RVA: 0x001D8C9C File Offset: 0x001D6E9C
		private static void ShakeTree(int i, int j)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Tile tile;
			if (WorldGen.GetTreeType((int)tile.type) != TreeTypes.None)
			{
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				return;
			}
		}

		// Token: 0x06002E15 RID: 11797 RVA: 0x001D9438 File Offset: 0x001D7638
		private static void GetVineTop(int i, int j, [Out] int x, [Out] int y)
		{
			x.m_value = i;
			y.m_value = j;
			long num = 0L;
			y.m_value = (int)num;
		}

		// Token: 0x06002E16 RID: 11798 RVA: 0x001D9460 File Offset: 0x001D7660
		public static void GetTreeBottom(int i, int j, [Out] int x, [Out] int y)
		{
			int num = 1;
			x.m_value = i;
			y.m_value = j;
			Tile tile;
			ushort type = tile.type;
			if (num == 0)
			{
			}
			long num2 = 0L;
			y.m_value = (int)num2;
		}

		// Token: 0x06002E17 RID: 11799 RVA: 0x001D94B4 File Offset: 0x001D76B4
		private static void AttemptFossilShattering(int i, int j, Tile tileCache, bool fail)
		{
			bool logicHost = Main.LogicHost;
			int num = 4;
			if (num == 0)
			{
			}
			long num2 = 0L;
			bool flag = WorldGen.SolidTile(0, fail ? 1 : 0, num2 != 0L);
			if (num == 0)
			{
			}
			Tile tile;
			bool flag2 = tile.active();
			if (num == 0)
			{
			}
			long num3 = 0L;
			Tile tile2;
			ushort type = tile2.type;
			if (num == 0)
			{
			}
			if (WorldGen.genRand.Next((int)num3) == 0)
			{
				if (num == 0)
				{
				}
				int num4 = 1;
				long num5 = 0L;
				long num6 = 0L;
				WorldGen.KillTile(0, j, num5 != 0L, num6 != 0L, num4 != 0);
				return;
			}
		}

		// Token: 0x06002E18 RID: 11800 RVA: 0x001D9540 File Offset: 0x001D7740
		public static void KillTile(int i, int j, bool fail = false, bool effectOnly = false, bool noItem = false)
		{
			if (!true)
			{
			}
			Tile tile;
			bool flag = tile.active();
			int num = WorldGen.CheckTileBreakability(i, j);
		}

		// Token: 0x06002E19 RID: 11801 RVA: 0x001D9948 File Offset: 0x001D7B48
		private static Player GetPlayerForTile(int x, int y)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06002E1A RID: 11802 RVA: 0x001D9964 File Offset: 0x001D7B64
		private static void KillTile_DropItems(int x, int y, Tile tileCache, bool includeLargeObjectDrops = false)
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
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06002E1B RID: 11803 RVA: 0x001D9988 File Offset: 0x001D7B88
		public static void KillTile_GetItemDrops(int x, int y, Tile tileCache, [Out] int dropItem, [Out] int dropItemStack, [Out] int secondaryItem, [Out] int secondaryItemStack, bool includeLargeObjectDrops = false)
		{
			int num = 1;
			dropItemStack.m_value = num;
			secondaryItemStack.m_value = num;
			if (4855 == 0)
			{
			}
			int dresserItemDrop = WorldGen.GetDresserItemDrop(includeLargeObjectDrops ? 1 : 0);
		}

		// Token: 0x06002E1C RID: 11804 RVA: 0x001DA2BC File Offset: 0x001D84BC
		private static void SetGemTreeDrops(int gemType, int seedType, Tile tileCache, int dropItem, int secondaryItem)
		{
			if (!true)
			{
			}
			dropItem.m_value = 3;
			if (3 == 0)
			{
			}
			int num;
			if (num == 0)
			{
				secondaryItem.m_value = seedType;
			}
		}

		// Token: 0x06002E1D RID: 11805 RVA: 0x001DA2E4 File Offset: 0x001D84E4
		private static void SetVanityTreeDrops(int dropType, Tile tileCache, int dropItem)
		{
			if (!true)
			{
			}
			int num;
			if (num == 0)
			{
				dropItem.m_value = dropType;
			}
		}

		// Token: 0x06002E1E RID: 11806 RVA: 0x001DA300 File Offset: 0x001D8500
		public static bool IsHarvestableHerbWithSeed(int type, int style)
		{
			/*
An exception occurred when decompiling this method (06002E1E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::IsHarvestableHerbWithSeed(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000A:
	brtrue(IL_0000, ldloc:int32[exp:bool](type))
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

		// Token: 0x06002E1F RID: 11807 RVA: 0x001DA31C File Offset: 0x001D851C
		private static bool KillTile_ShouldDropSeeds(int x, int y)
		{
			if (!true)
			{
			}
			int num;
			if (num != 0)
			{
			}
			if (!true)
			{
			}
			bool flag = WorldGen.GetPlayerForTile(0, x).HasItem(281);
			return true;
		}

		// Token: 0x06002E20 RID: 11808 RVA: 0x001DA35C File Offset: 0x001D855C
		private static void KillTile_GetTreeDrops(int i, int j, Tile tileCache, bool bonusWood, int dropItem, int secondaryItem)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool logicHost = Main.LogicHost;
			if (num == 0)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num2 = 2;
			long num3 = 0L;
			if (genRand.Next(num2) != 0)
			{
				int num4 = 9;
				dropItem.m_value = num4;
				if (num4 == 0)
				{
				}
				WorldGen.GetTreeBottom(i, j, (int)num3, bonusWood ? 1 : 0);
				if (num4 == 0)
				{
				}
				Tile tile;
				bool flag = tile.active();
				if (num4 == 0)
				{
				}
				Tile tile2;
				ushort type = tile2.type;
				return;
			}
			int num5;
			if (num5 == 0)
			{
			}
			Tile tile3;
			bool flag2 = tile3.active();
			Tile tile4;
			ushort type2 = tile4.type;
			Tile tile5;
			ushort type3 = tile5.type;
		}

		// Token: 0x06002E21 RID: 11809 RVA: 0x001DA46C File Offset: 0x001D866C
		private static void KillTile_DropBait(int i, int j, Tile tileCache)
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
				return;
			}
			if (num == 0)
			{
			}
			if (num != 0)
			{
			}
			if (num == 0)
			{
			}
			int num2;
			if (num != 0)
			{
				num2 = 16960;
				return;
			}
			if (num2 == 0)
			{
			}
			int num3;
			if (num2 != 0)
			{
				num3 = 13568;
				return;
			}
			if (num3 == 0)
			{
			}
			if (num3 != 0)
			{
			}
		}

		// Token: 0x06002E22 RID: 11810 RVA: 0x001DA6F8 File Offset: 0x001D88F8
		public static void KillTile_PlaySounds(int i, int j, bool fail, Tile tileCache)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002E23 RID: 11811 RVA: 0x001DA770 File Offset: 0x001D8970
		public static Rectangle? GetTileVisualHitbox(int x, int y)
		{
			/*
An exception occurred when decompiling this method (06002E23)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Nullable`1<Microsoft.Xna.Framework.Rectangle> Terraria.WorldGen::GetTileVisualHitbox(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:bool(var_1_09, callgetter:bool(Tile::get_IsLoaded, ldloc:Tile[exp:valuetype Terraria.Tile&](var_0)))
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

		// Token: 0x06002E24 RID: 11812 RVA: 0x001DA790 File Offset: 0x001D8990
		public static int KillTile_GetTileDustAmount(bool fail, Tile tileCache)
		{
			return 2;
		}

		// Token: 0x06002E25 RID: 11813 RVA: 0x001DA7C4 File Offset: 0x001D89C4
		public static int KillTile_MakeTileDust(int i, int j, Tile tileCache)
		{
			int num = 82;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				int num2 = 7;
				if (num2 == 0)
				{
				}
				int num3;
				if (num2 != 0)
				{
					num3 = 301;
				}
				if (num3 == 0)
				{
				}
				Tile tile;
				ushort type = tile.type;
			}
			if (17 == 0)
			{
			}
			return 0;
		}

		// Token: 0x06002E26 RID: 11814 RVA: 0x001DB4C0 File Offset: 0x001D96C0
		public static bool IsOpenDoorAnchorFrame(int x, int y)
		{
			/*
An exception occurred when decompiling this method (06002E26)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::IsOpenDoorAnchorFrame(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:bool(var_1_09, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_0)))
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

		// Token: 0x06002E27 RID: 11815 RVA: 0x001DB4DC File Offset: 0x001D96DC
		public static bool IsLockedDoor(int x, int y)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06002E28 RID: 11816 RVA: 0x001DB4F0 File Offset: 0x001D96F0
		public static bool IsLockedDoor(Tile t)
		{
		}

		// Token: 0x06002E29 RID: 11817 RVA: 0x001DB500 File Offset: 0x001D9700
		public static void DropDoorItem(int x, int y, int doorStyle)
		{
		}

		// Token: 0x06002E2A RID: 11818 RVA: 0x001DB51C File Offset: 0x001D971C
		public static IEntitySource GetItemSource_FromTileBreak(int x, int y)
		{
		}

		// Token: 0x06002E2B RID: 11819 RVA: 0x001DB52C File Offset: 0x001D972C
		public static IEntitySource GetItemSource_FromWallBreak(int x, int y)
		{
		}

		// Token: 0x06002E2C RID: 11820 RVA: 0x000021DB File Offset: 0x000003DB
		public static IEntitySource GetItemSource_FromTreeShake(int x, int y)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002E2D RID: 11821 RVA: 0x001DB53C File Offset: 0x001D973C
		public static bool PlayerLOS(int x, int y)
		{
		}

		// Token: 0x06002E2E RID: 11822 RVA: 0x001DB558 File Offset: 0x001D9758
		public static void ChlorophyteDefense(int x, int y)
		{
			if (!true)
			{
			}
			Tile tile;
			ushort type = tile.type;
			WorldGen.SquareTileFrame(x, y, true);
			bool netHost = Main.NetHost;
		}

		// Token: 0x06002E2F RID: 11823 RVA: 0x001DB59C File Offset: 0x001D979C
		public static bool Chlorophyte(int i, int j)
		{
			if (!true)
			{
			}
			int num = 130;
			if (num == 0)
			{
			}
			int value = num.m_value;
			if (!false)
			{
				return;
			}
		}

		// Token: 0x06002E30 RID: 11824 RVA: 0x001DB5CC File Offset: 0x001D97CC
		private static bool nearbyChlorophyte(int i, int j)
		{
			/*
An exception occurred when decompiling this method (06002E30)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::nearbyChlorophyte(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000B:
	stloc:UnifiedRandom(var_1_10, callgetter:UnifiedRandom(WorldGen::get_genRand))
	stloc:int32(var_2_12, ldc.i4:int32(4))
	stloc:int32(var_3_1B, call:int32(UnifiedRandom::Next, ldloc:UnifiedRandom(var_1_10), ldloc:int32(i), ldloc:int32(var_2_12)))
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

		// Token: 0x06002E31 RID: 11825 RVA: 0x001DB5F8 File Offset: 0x001D97F8
		public static int CountNearBlocksTypes(int i, int j, int radius, int cap, ushort tiletypes)
		{
			/*
An exception occurred when decompiling this method (06002E31)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.WorldGen::CountNearBlocksTypes(System.Int32,System.Int32,System.Int32,System.Int32,System.UInt16)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:bool(var_2_0B, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_1)))
	stloc:uint16(var_4_12, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_3)))
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

		// Token: 0x06002E32 RID: 11826 RVA: 0x001DB618 File Offset: 0x001D9818
		public static void hardUpdateWorld(int i, int j)
		{
			if (!true)
			{
			}
			Tile tile;
			bool flag = tile.inActive();
			UnifiedRandom genRand = WorldGen.genRand;
			int num = 5;
			long num3;
			if (genRand.Next(num) == 0)
			{
				UnifiedRandom genRand2 = WorldGen.genRand;
				int num2 = 4;
				if (genRand2.Next(num2) != 0)
				{
					return;
				}
				Tile tile2;
				bool flag2 = tile2.active();
				num3 = 0L;
				Tile tile3;
				bool flag3 = tile3.active();
				Tile tile4;
				ushort type = tile4.type;
				UnifiedRandom genRand3 = WorldGen.genRand;
				int num4 = 18;
				int num5 = genRand3.Next(num4);
				UnifiedRandom genRand4 = WorldGen.genRand;
				int num6 = 50;
				if (genRand4.Next(num6) == 0)
				{
					UnifiedRandom genRand5 = WorldGen.genRand;
					int num7 = 6;
					int num8 = genRand5.Next(num7);
				}
			}
			UnifiedRandom genRand6 = WorldGen.genRand;
			int num9 = 300;
			if (genRand6.Next(num9) == 0)
			{
				UnifiedRandom genRand7 = WorldGen.genRand;
				int num10 = 11;
				int num11 = genRand7.Next(num9, num10);
				UnifiedRandom genRand8 = WorldGen.genRand;
				int num12 = 11;
				int num13 = genRand8.Next(num9, num12);
				int num14 = 2;
				bool flag4 = WorldGen.InWorld((int)num3, num9, num14);
				Tile tile5;
				bool flag5 = tile5.active();
				Tile tile6;
				ushort type2 = tile6.type;
				Tile tile7;
				bool flag6 = tile7.active();
				Tile tile8;
				ushort type3 = tile8.type;
				Tile tile9;
				ushort type4 = tile9.type;
				long num15 = 0L;
				Tile tile10;
				ushort type5 = tile10.type;
				bool flag7 = WorldGen.Chlorophyte((int)num3, (int)num15);
				int num16 = 211;
				Tile tile11;
				tile11.type = (ushort)num16;
				int num17 = 1;
				WorldGen.SquareTileFrame((int)num3, num16, num17 != 0);
				bool netHost = Main.NetHost;
				return;
			}
			if (!false)
			{
			}
			if (false)
			{
				if (!false)
				{
				}
				UnifiedRandom genRand9 = WorldGen.genRand;
				int num18 = 2;
				if (genRand9.Next(num18) != 0)
				{
					return;
				}
			}
			if (!false)
			{
			}
			if (false)
			{
				return;
			}
		}

		// Token: 0x06002E33 RID: 11827 RVA: 0x001DBC84 File Offset: 0x001D9E84
		public static bool SolidTile(short tileSHeader, ushort tileType)
		{
			if (29792 == 0)
			{
				return;
			}
		}

		// Token: 0x06002E34 RID: 11828 RVA: 0x001DBC9C File Offset: 0x001D9E9C
		public static bool SolidTile(Tile testTile)
		{
		}

		// Token: 0x06002E35 RID: 11829 RVA: 0x001DBCB4 File Offset: 0x001D9EB4
		public static bool TileEmpty(int i, int j)
		{
			if (!true)
			{
			}
			Tile tile;
			bool isLoaded = tile.IsLoaded;
			if (!true)
			{
			}
			Tile tile2;
			bool flag = tile2.active();
			if (!true)
			{
			}
			Tile tile3;
			return tile3.inActive();
		}

		// Token: 0x06002E36 RID: 11830 RVA: 0x001DBCE8 File Offset: 0x001D9EE8
		public static bool SolidOrSlopedTile(Tile tile)
		{
		}

		// Token: 0x06002E37 RID: 11831 RVA: 0x001DBCF8 File Offset: 0x001D9EF8
		public static int TileType(int x, int y)
		{
			/*
An exception occurred when decompiling this method (06002E37)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.WorldGen::TileType(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000F:
	stloc:uint16(var_4_15, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_3)))
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

		// Token: 0x06002E38 RID: 11832 RVA: 0x001DBD1C File Offset: 0x001D9F1C
		public static bool SolidOrSlopedTile(int x, int y)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06002E39 RID: 11833 RVA: 0x001DBD30 File Offset: 0x001D9F30
		public static bool IsRope(int x, int y)
		{
			/*
An exception occurred when decompiling this method (06002E39)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::IsRope(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:bool(var_3_0B, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_1)))
	stloc:uint16(var_6_16, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_4)))
	stloc:uint16(var_10_25, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_8)))
	stloc:uint16(var_13_31, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_11)))
	stloc:bool(var_18_3D, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_16)))
	stloc:bool(var_21_49, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_19)))
	stloc:uint16(var_24_55, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_22)))
	stloc:uint16(var_26_5E, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_25)))
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

		// Token: 0x06002E3A RID: 11834 RVA: 0x001DBDA0 File Offset: 0x001D9FA0
		public static bool SolidTile(Point p)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06002E3B RID: 11835 RVA: 0x001DBDB4 File Offset: 0x001D9FB4
		public static bool SolidTile(int i, int j, bool noDoors = false)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06002E3C RID: 11836 RVA: 0x001DBDD0 File Offset: 0x001D9FD0
		public static bool SolidTile(Tile tileCache, bool noDoors = false)
		{
			if (!true)
			{
			}
			if (29792 == 0)
			{
				return;
			}
		}

		// Token: 0x06002E3D RID: 11837 RVA: 0x001DBDEC File Offset: 0x001D9FEC
		public static bool SolidTile2(Tile testTile)
		{
			int num = 29792;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				return;
			}
		}

		// Token: 0x06002E3E RID: 11838 RVA: 0x001DBE0C File Offset: 0x001DA00C
		public static bool PlatformProperTopFrame(short frameX)
		{
			/*
An exception occurred when decompiling this method (06002E3E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::PlatformProperTopFrame(System.Int16)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_1_07, call:int32(TileObjectData::PlatformFrameWidth))
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

		// Token: 0x06002E3F RID: 11839 RVA: 0x001DBE24 File Offset: 0x001DA024
		public static bool SolidTileAllowBottomSlope(int i, int j)
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
			if (num == 0)
			{
				if (num == 0)
				{
				}
				if (num == 0)
				{
					return;
				}
			}
			if (num == 0)
			{
			}
			if (num != 0)
			{
				short num2;
				bool flag = WorldGen.PlatformProperTopFrame(num2);
				return;
			}
		}

		// Token: 0x06002E40 RID: 11840 RVA: 0x001DBE60 File Offset: 0x001DA060
		public static bool ActiveAndWalkableTile(int i, int j)
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
				return;
			}
		}

		// Token: 0x06002E41 RID: 11841 RVA: 0x001DBE84 File Offset: 0x001DA084
		public static bool SolidTileAllowTopSlope(int i, int j)
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
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num != 0)
			{
				return;
			}
		}

		// Token: 0x06002E42 RID: 11842 RVA: 0x001DBEB0 File Offset: 0x001DA0B0
		public static bool SolidTileAllowLeftSlope(int i, int j)
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
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06002E43 RID: 11843 RVA: 0x001DBEE0 File Offset: 0x001DA0E0
		public static bool SolidTileAllowRightSlope(int i, int j)
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
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06002E44 RID: 11844 RVA: 0x001DBF10 File Offset: 0x001DA110
		public static bool TopEdgeCanBeAttachedTo(int i, int j)
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
			if (num == 0)
			{
				if (num == 0)
				{
				}
				if (num == 0)
				{
					return;
				}
			}
			if (num == 0)
			{
			}
			if (num != 0)
			{
				short num2;
				bool flag = WorldGen.PlatformProperTopFrame(num2);
				return;
			}
		}

		// Token: 0x06002E45 RID: 11845 RVA: 0x001DBF4C File Offset: 0x001DA14C
		public static bool RightEdgeCanBeAttachedTo(int i, int j)
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
			if (num == 0)
			{
				return;
			}
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
			if (num != 0)
			{
				return;
			}
		}

		// Token: 0x06002E46 RID: 11846 RVA: 0x001DBF7C File Offset: 0x001DA17C
		public static bool LeftEdgeCanBeAttachedTo(int i, int j)
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
			if (num == 0)
			{
				return;
			}
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
			if (num != 0)
			{
				return;
			}
		}

		// Token: 0x06002E47 RID: 11847 RVA: 0x001DBFAC File Offset: 0x001DA1AC
		public static bool BottomEdgeCanBeAttachedTo(int i, int j)
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
			if (num == 0)
			{
				return;
			}
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
			if (num != 0)
			{
				return;
			}
		}

		// Token: 0x06002E48 RID: 11848 RVA: 0x001DBFDC File Offset: 0x001DA1DC
		public static bool SolidTile3(int i, int j)
		{
			if (!true)
			{
			}
			bool flag = WorldGen.InWorld(0, i, 1);
			if (!true)
			{
			}
			bool flag2;
			return flag2;
		}

		// Token: 0x06002E49 RID: 11849 RVA: 0x001DBFFC File Offset: 0x001DA1FC
		public static bool SolidTile3(Tile t)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0 || num == 0)
			{
				return;
			}
		}

		// Token: 0x06002E4A RID: 11850 RVA: 0x001DC018 File Offset: 0x001DA218
		public static bool SolidTile2(int i, int j)
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
			bool flag = tile2.active();
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
				Tile tile5;
				bool flag2 = tile5.halfBrick();
				Tile tile6;
				bool flag3 = tile6.topSlope();
				Tile tile7;
				byte b = tile7.slope();
				Tile tile8;
				bool flag4 = tile8.halfBrick();
				Tile tile9;
				bool flag5 = tile9.inActive();
				return;
			}
		}

		// Token: 0x06002E4B RID: 11851 RVA: 0x001DC0A4 File Offset: 0x001DA2A4
		public static bool SolidTileNoAttach(int i, int j)
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
			bool flag = tile2.active();
			if (num == 0)
			{
			}
			Tile tile3;
			ushort type = tile3.type;
			if (num == 0)
			{
				return;
			}
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
				byte b = tile5.slope();
				if (num == 0)
				{
				}
				Tile tile6;
				bool flag2 = tile6.halfBrick();
				if (num == 0)
				{
				}
				Tile tile7;
				bool flag3 = tile7.inActive();
				return;
			}
		}

		// Token: 0x06002E4C RID: 11852 RVA: 0x001DC124 File Offset: 0x001DA324
		public static void MineHouse(int i, int j)
		{
			if (!true)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num = 6;
			int num2 = 12;
			int num3 = genRand.Next(num, num2);
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num4 = 3;
			int num5 = 6;
			int num6 = genRand2.Next(num4, num5);
			UnifiedRandom genRand3 = WorldGen.genRand;
			int num7 = 15;
			int num8 = 30;
			int num9 = genRand3.Next(num7, num8);
			UnifiedRandom genRand4 = WorldGen.genRand;
			int num10 = 15;
			int num11 = 30;
			int num12 = genRand4.Next(num10, num11);
			long num13 = 0L;
			bool flag = WorldGen.SolidTile(i, j, num13 != 0L);
			Tile tile;
			ushort wall = tile.wall;
			long num14 = 0L;
			Tile tile2;
			ushort wall2 = tile2.wall;
			long num15 = 0L;
			bool flag2 = WorldGen.SolidTile(0, (int)num14, num15 != 0L);
			int num16 = 30;
			long num17 = 0L;
			bool flag3 = WorldGen.SolidTile(0, num16, num17 != 0L);
			if (!false)
			{
			}
			Tile tile3;
			bool flag4 = tile3.halfBrick();
			if (!false)
			{
			}
			Tile tile4;
			byte b = tile4.slope();
			if (!false)
			{
			}
			int num18 = 30;
			Tile tile5;
			tile5.type = (ushort)num18;
		}

		// Token: 0x06002E4D RID: 11853 RVA: 0x001DCCB0 File Offset: 0x001DAEB0
		public static void CountTiles(int X)
		{
			int num = 1;
			if (X == 0)
			{
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				return;
			}
			int num2;
			if (num2 != 0)
			{
				return;
			}
			if (num2 == 0)
			{
			}
			if (false)
			{
				return;
			}
			WorldGen.AddUpAlignmentCounts(false);
		}

		// Token: 0x06002E4E RID: 11854 RVA: 0x001DCD24 File Offset: 0x001DAF24
		public static void AddUpAlignmentCounts(bool clearCounts = false)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06002E4F RID: 11855 RVA: 0x001DCD44 File Offset: 0x001DAF44
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		public static bool checkPlantDye(int i, int j, bool exoticPlant = false)
		{
			int num = 1;
			int num2 = 240;
			if (num == 0)
			{
			}
			if (num2 == 0)
			{
			}
			if (num2 == 0)
			{
				return;
			}
		}

		// Token: 0x06002E50 RID: 11856 RVA: 0x001DCD68 File Offset: 0x001DAF68
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		public static void plantDye(int i, int j, bool exoticPlant = false)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
		}

		// Token: 0x06002E51 RID: 11857 RVA: 0x001DCFA4 File Offset: 0x001DB1A4
		private static int MossConversion(int thisType, int otherType)
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
			if (num != 0)
			{
				return;
			}
		}

		// Token: 0x06002E52 RID: 11858 RVA: 0x001DCFCC File Offset: 0x001DB1CC
		public static void UpdateWorld()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002E53 RID: 11859 RVA: 0x001DD1C4 File Offset: 0x001DB3C4
		public static int GetWorldUpdateRate()
		{
			/*
An exception occurred when decompiling this method (06002E53)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.WorldGen::GetWorldUpdateRate()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_0_0F, call:int32(Math::Min, ldc.i4:int32(-2147483648), ldc.i4:int32(24)))
	stloc:bool(var_2_21, ldfld:bool(ASharedTogglePower::<Enabled>k__BackingField, call:FreezeTime[exp:ASharedTogglePower](CreativePowerManager::GetPower, callgetter:CreativePowerManager(CreativePowerManager::get_Instance))))
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

		// Token: 0x06002E54 RID: 11860 RVA: 0x001DD1F4 File Offset: 0x001DB3F4
		private static void UpdateWorld_OvergroundTile(int i, int j, bool checkNPCSpawns, int wallDist)
		{
			int num = 1;
			int num2 = 10;
			if (num == 0)
			{
			}
			if (num2 != 0)
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
			if (num == 0)
			{
			}
			WorldGen.GrowAlch(i, j);
		}

		// Token: 0x06002E55 RID: 11861 RVA: 0x001DE50C File Offset: 0x001DC70C
		public static bool AttemptToGrowTreeFromSapling(int x, int y, bool underground)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int num2 = 2;
			bool flag = WorldGen.InWorld(0, x, num2);
			if (num == 0)
			{
			}
			Tile tile;
			bool flag2 = tile.active();
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			long num3 = 0L;
			if (num == 0)
			{
			}
			bool flag3 = WorldGen.TryGrowingTreeByType(596, (int)num3, x);
			if (num == 0)
			{
			}
			bool flag4 = WorldGen.PlayerLOS(0, x);
			if (num == 0)
			{
			}
			WorldGen.TreeGrowFXCheck(0, x);
			if (num == 0)
			{
			}
			return WorldGen.GrowPalmTree(0, x);
		}

		// Token: 0x06002E56 RID: 11862 RVA: 0x001DE59C File Offset: 0x001DC79C
		public static void DontStarveTryWateringTile(int x, int y)
		{
			if (!true)
			{
			}
			Tile tile;
			bool flag = tile.active();
			if (!true)
			{
			}
			bool flag2 = WorldGen.IsSafeFromRain(x, y);
			if (!true)
			{
			}
			long num = 0L;
			bool flag3 = WorldGen.HasAnyWireNearby(x, y, (int)num);
			long num2 = 0L;
			long num3 = 0L;
			long num4 = 0L;
			WorldGen.KillTile(x, y, num2 != 0L, num3 != 0L, num4 != 0L);
			bool netHost = Main.NetHost;
		}

		// Token: 0x06002E57 RID: 11863 RVA: 0x001DE5F0 File Offset: 0x001DC7F0
		public static bool HasAnyWireNearby(int sourceX, int sourceY, int boxSpread)
		{
			if (!true)
			{
			}
			Tile tile;
			bool flag = tile.wire();
			bool flag2;
			return flag2;
		}

		// Token: 0x06002E58 RID: 11864 RVA: 0x001DE614 File Offset: 0x001DC814
		public static bool IsSafeFromRain(int startX, int startY)
		{
			Vector2 rainFallVelocity = Rain.GetRainFallVelocity();
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06002E59 RID: 11865 RVA: 0x001DE654 File Offset: 0x001DC854
		public static bool TryToggleLight(int x, int y, bool? forcedState, bool skipWires)
		{
			if (!true)
			{
			}
			Tile tile;
			bool flag = tile.active();
			if (!true)
			{
			}
			return false;
		}

		// Token: 0x06002E5A RID: 11866 RVA: 0x001DE6A0 File Offset: 0x001DC8A0
		private static bool HasValidGroundForAbigailsFlowerBelowSpot(int x, int y)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int num2 = 2;
			bool flag = WorldGen.InWorld(0, x, num2);
			if (num == 0)
			{
			}
			Tile tile;
			bool flag2 = tile.active();
			if (num == 0)
			{
			}
			if (num != 0)
			{
				if (num == 0)
				{
				}
				return WorldGen.SolidTileAllowBottomSlope(0, x);
			}
		}

		// Token: 0x06002E5B RID: 11867 RVA: 0x001DE6DC File Offset: 0x001DC8DC
		private static bool TryGrowingAbigailsFlower(int i, int j)
		{
			/*
An exception occurred when decompiling this method (06002E5B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::TryGrowingAbigailsFlower(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00BA:
	stloc:bool(var_21_C1, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_20)))
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

		// Token: 0x06002E5C RID: 11868 RVA: 0x001DE7B0 File Offset: 0x001DC9B0
		private static bool NoNearbyAbigailsFlower(int i, int j)
		{
			/*
An exception occurred when decompiling this method (06002E5C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::NoNearbyAbigailsFlower(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:bool(var_2_0B, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_1)))
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

		// Token: 0x06002E5D RID: 11869 RVA: 0x001DE7CC File Offset: 0x001DC9CC
		private static bool HasValidGroundForGlowTulipBelowSpot(int x, int y)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int num2 = 2;
			bool flag = WorldGen.InWorld(0, x, num2);
			if (num == 0)
			{
			}
			Tile tile;
			bool flag2 = tile.active();
			if (num == 0 || num == 0)
			{
			}
			return WorldGen.SolidTileAllowBottomSlope(0, x);
		}

		// Token: 0x06002E5E RID: 11870 RVA: 0x001DE804 File Offset: 0x001DCA04
		private static bool TryGrowingGlowTulip(int i, int j)
		{
			if (!true)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num = Math.Max(10, 43143168);
			int num2 = Math.Min(int.MinValue, 43143168);
			int num3 = genRand.Next(num, num2);
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num4 = Math.Max(10, num);
			int num5 = Math.Min(num4, num);
			int num6 = genRand2.Next(num4, num5);
			bool flag = WorldGen.HasValidGroundForGlowTulipBelowSpot(num3, num6);
			if (-2147483648 == 0)
			{
			}
			bool flag2 = WorldGen.NoNearbyGlowTulips(num3, num6);
			if (-2147483648 == 0)
			{
			}
			if (-2147483648 == 0)
			{
			}
			Tile tile;
			bool flag3 = tile.active();
			if (-2147483648 == 0)
			{
			}
			if (-2147483648 == 0)
			{
				if (-2147483648 == 0)
				{
				}
				bool netHost = Main.NetHost;
				if (-2147483648 == 0)
				{
				}
				Tile tile2;
				bool flag4 = tile2.active();
				return;
			}
		}

		// Token: 0x06002E5F RID: 11871 RVA: 0x001DE8D0 File Offset: 0x001DCAD0
		private static bool NoNearbyGlowTulips(int i, int j)
		{
			/*
An exception occurred when decompiling this method (06002E5F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::NoNearbyGlowTulips(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:bool(var_2_0B, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_1)))
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

		// Token: 0x06002E60 RID: 11872 RVA: 0x001DE8EC File Offset: 0x001DCAEC
		private static void UpdateWorld_UndergroundTile(int i, int j, bool checkNPCSpawns, int wallDist)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
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
			WorldGen.GrowAlch(i, j);
			UnifiedRandom genRand = WorldGen.genRand;
			int num2 = 3;
			int num3 = genRand.Next(j, num2);
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num4 = 3;
			int num5 = genRand2.Next(j, num4);
			int num6 = 10;
			bool flag = WorldGen.InWorld(1073741824, wallDist, num6);
			if (1073741824 == 0)
			{
			}
			Tile tile;
			ushort wall = tile.wall;
			if (1073741824 == 0)
			{
			}
			Tile tile2;
			ushort wall2 = tile2.wall;
			long num7 = 0L;
			if (num7 == 0L)
			{
			}
			Tile tile3;
			bool flag2 = tile3.active();
			if (num7 == 0L)
			{
			}
			Tile tile4;
			ushort type = tile4.type;
			if (num7 == 0L)
			{
			}
			int num8 = 81;
			Tile tile5;
			tile5.wall = (ushort)num8;
			bool netHost = Main.NetHost;
		}

		// Token: 0x06002E61 RID: 11873 RVA: 0x001DF864 File Offset: 0x001DDA64
		private static void GrowWeb(int i, int j)
		{
			int num = 1;
			if (num == 0)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num2 = 10;
			if (genRand.Next(num2) == 0)
			{
				if (num == 0)
				{
				}
				UnifiedRandom genRand2 = WorldGen.genRand;
				int num3 = 2;
				int num4 = 4;
				int num5 = genRand2.Next(num3, num4);
				if (num == 0)
				{
				}
				long num6 = 0L;
				bool flag = WorldGen.SolidTile(43143168, num3, num6 != 0L);
				return;
			}
		}

		// Token: 0x06002E62 RID: 11874 RVA: 0x001DF8EC File Offset: 0x001DDAEC
		public static bool GeneratePlanteraBulbOnAllMechsDefeated()
		{
			while (32752 == 0)
			{
			}
			long num = 32752L;
			int underworldLayer = Main.UnderworldLayer;
			int num2 = 2500;
			if (num == 0L)
			{
			}
			int num3 = WorldGen.genRand.Next(-1717567488);
			UnifiedRandom genRand = WorldGen.genRand;
			long num4 = 0L;
			int num5 = genRand.Next(-1717567488);
			if (num == 0L)
			{
			}
			if (num == 0L)
			{
			}
			Tile tile;
			bool flag = tile.active();
			long num6 = 0L;
			if (num == 0L)
			{
			}
			bool flag3;
			bool flag2 = WorldGen.AttemptToGeneratePlanteraBulbAt(flag3 ? 1 : 0, (int)num6, num4 != 0L);
			if (num == 0L)
			{
			}
			bool flag4 = WorldGen.AttemptToGeneratePlanteraBulbAt(0, (int)num6, num4 != 0L);
			if (num == 0L)
			{
			}
			bool flag5 = WorldGen.AttemptToGeneratePlanteraBulbAt(0, (int)num6, num4 != 0L);
			while (num2 != 0)
			{
			}
		}

		// Token: 0x06002E63 RID: 11875 RVA: 0x001DF990 File Offset: 0x001DDB90
		private static bool AttemptToGeneratePlanteraBulbAt(int i, int j, bool forceBulb)
		{
			int num = 1;
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
			if (num == 0)
			{
				int num2 = 1;
				if (num == 0)
				{
				}
				Tile tile2;
				tile2.ClearTile();
				if (num2 != 0)
				{
					int num3 = 60;
					tile2.type = (ushort)num3;
					int num4 = 1;
					tile2.active(num4 != 0);
				}
				if (num == 0)
				{
				}
				int num5 = 1;
				WorldGen.SquareTileFrame(j, 43143168, num5 != 0);
				if (num == 0)
				{
				}
				int num6 = 238;
				long num7 = 0L;
				long num8 = 0L;
				WorldGen.PlaceJunglePlant(0, i, (ushort)num6, (int)num7, (int)num8);
				if (num == 0)
				{
				}
				Tile tile3;
				ushort type2 = tile3.type;
				if (num == 0)
				{
				}
				int num9 = 1;
				WorldGen.SquareTileFrame(0, i, num9 != 0);
				int num10 = 1;
				WorldGen.SquareTileFrame(0, i, num10 != 0);
				int num11 = 1;
				WorldGen.SquareTileFrame(0, i, num11 != 0);
				if (num == 0)
				{
				}
				bool netHost = Main.NetHost;
				if (num == 0)
				{
				}
				return false;
			}
		}

		// Token: 0x06002E64 RID: 11876 RVA: 0x001DFABC File Offset: 0x001DDCBC
		private static void UpdateWorld_GrassGrowth(int i, int j, int minI, int maxI, int minJ, int maxJ, bool underground)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int num2 = 10;
			bool flag = WorldGen.InWorld(i, j, num2);
			if (num == 0)
			{
			}
			Tile tile;
			ushort type = tile.type;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				return;
			}
		}

		// Token: 0x06002E65 RID: 11877 RVA: 0x001E0348 File Offset: 0x001DE548
		private static void TrySpawningTownNPC(int x, int y)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			Tile tile;
			ushort wall = tile.wall;
			if (!true)
			{
			}
			int num;
			if (num == 0)
			{
				if (!true)
				{
				}
				TownNPCSpawnResult townNPCSpawnResult = WorldGen.SpawnTownNPC(x, y);
			}
			if (!true)
			{
			}
		}

		// Token: 0x06002E66 RID: 11878 RVA: 0x001E037C File Offset: 0x001DE57C
		public static void SpreadDesertWalls(int wallDist, int i, int j)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int num2 = 10;
			bool flag = WorldGen.InWorld(i, j, num2);
			if (num == 0)
			{
			}
			if (num == 0)
			{
				if (num == 0)
				{
				}
				if (num == 0)
				{
					if (num == 0)
					{
					}
					if (num == 0)
					{
						return;
					}
				}
			}
			if (num == 0)
			{
			}
			long num3;
			if (num == 0)
			{
				if (num == 0)
				{
				}
				if (num == 0)
				{
					num3 = 0L;
					return;
				}
			}
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
			if (num == 0)
			{
			}
			if (num == 0)
			{
				if (num == 0)
				{
				}
				if (num == 0)
				{
					while (num3 != 0L)
					{
					}
					return;
				}
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num4 = 3;
			int num5 = genRand.Next(j, num4);
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num6 = 3;
			int num7 = genRand2.Next(j, num6);
			if (num7 == 0)
			{
			}
			if (num7 != 0)
			{
				if (num7 == 0)
				{
					return;
				}
				if (num7 == 0)
				{
				}
				return;
			}
		}

		// Token: 0x06002E67 RID: 11879 RVA: 0x001E0448 File Offset: 0x001DE648
		public static void PlaceWall(int i, int j, int type, bool mute = false)
		{
			if (!true)
			{
			}
			Tile tile;
			ushort wall = tile.wall;
			int num = 1;
			WorldGen.SquareWallFrame(i, j, num != 0);
		}

		// Token: 0x06002E68 RID: 11880 RVA: 0x001E046C File Offset: 0x001DE66C
		public static void SpreadGrass(int i, int j, int dirt = 0, int grass = 2, bool repeat = true, [Optional] TileColorCache color)
		{
			if (!true)
			{
			}
			if (grass != 0)
			{
				return;
			}
			if (grass != 0)
			{
				return;
			}
		}

		// Token: 0x06002E69 RID: 11881 RVA: 0x001E04A0 File Offset: 0x001DE6A0
		public static void ChasmRunnerSideways(int i, int j, int direction, int steps)
		{
			if (!true)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num = 10;
			int num2 = 21;
			int num3 = genRand.Next(num, num2);
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num4 = 10;
			int num5 = genRand2.Next(num, num4);
			UnifiedRandom genRand3 = WorldGen.genRand;
			int num6 = 5;
			int num7 = genRand3.Next(num6);
			UnifiedRandom genRand4 = WorldGen.genRand;
			int num8 = 3;
			int num9 = genRand4.Next(num8);
			UnifiedRandom genRand5 = WorldGen.genRand;
			int num10 = 3;
			int num11 = genRand5.Next(num10);
		}

		// Token: 0x06002E6A RID: 11882 RVA: 0x001E069C File Offset: 0x001DE89C
		public static void CrimStart(int i, int j)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int num2 = 32768;
			if (num2 == 0)
			{
			}
			long num3 = 0L;
			bool flag = WorldGen.SolidTile(i, j, num3 != 0L);
			long num4 = 0L;
			if (num2 == 0)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num5 = 21;
			int num6 = genRand.Next((int)num4, num5);
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num7 = 20;
			int num8 = 201;
			int num9 = genRand2.Next(num7, num8);
			UnifiedRandom genRand3 = WorldGen.genRand;
			int num10 = 15;
			int num11 = 26;
			int num12 = genRand3.Next(num10, num11);
			UnifiedRandom genRand4 = WorldGen.genRand;
			int num13 = 51;
			int num14 = genRand4.Next(num10, num13);
			long num15 = 0L;
			Tile tile;
			tile.active(num15 != 0L);
		}

		// Token: 0x06002E6B RID: 11883 RVA: 0x001E0A90 File Offset: 0x001DEC90
		public static void CrimPlaceHearts()
		{
			UnifiedRandom genRand = WorldGen.genRand;
			int num = 16;
			int num2 = 21;
			int num3 = genRand.Next(num, num2);
			int num4 = 1;
			Tile tile;
			tile.active(num4 != 0);
			int num5 = 203;
			tile.type = (ushort)num5;
			int num6 = 83;
			tile.wall = (ushort)num6;
		}

		// Token: 0x06002E6C RID: 11884 RVA: 0x001E0B30 File Offset: 0x001DED30
		public static void CrimEnt(Vector2D position, int crimDir)
		{
			if (!true)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num = 6;
			int num2 = 11;
			int num3 = genRand.Next(num, num2);
			UnifiedRandom genRand2 = WorldGen.genRand;
			long num4 = 0L;
			int num5 = genRand2.Next(num, (int)num4);
			long num6 = 0L;
			UnifiedRandom genRand3 = WorldGen.genRand;
			int num7 = 11;
			int num8 = genRand3.Next((int)num6, num7);
			Tile tile;
			bool flag = tile.active();
			Tile tile2;
			ushort type = tile2.type;
			long num9 = 0L;
			Tile tile3;
			tile3.active(num9 != 0L);
		}

		// Token: 0x06002E6D RID: 11885 RVA: 0x001E0BA8 File Offset: 0x001DEDA8
		public static void CrimVein(Vector2D position, Vector2D velocity)
		{
			int num = 1;
			if (num == 0)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num2 = 15;
			int num3 = 26;
			int num4 = genRand.Next(num2, num3);
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num5 = 100;
			int num6 = 150;
			int num7 = genRand2.Next(num5, num6);
			if (num == 0)
			{
			}
			UnifiedRandom genRand3 = WorldGen.genRand;
			int num8 = 51;
			int num9 = genRand3.Next(num5, num8);
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			long num10 = 0L;
			Tile tile;
			tile.active(num10 != 0L);
			int num11 = 83;
			tile.wall = (ushort)num11;
		}

		// Token: 0x06002E6E RID: 11886 RVA: 0x001E0C84 File Offset: 0x001DEE84
		public static void ChasmRunner(int i, int j, int steps, bool makeOrb = false)
		{
			if (!true)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num = 11;
			int num2 = genRand.Next(j, num);
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num3 = 11;
			int num4 = genRand2.Next(num3);
			UnifiedRandom genRand3 = WorldGen.genRand;
			int num5 = 5;
			int num6 = genRand3.Next(num5);
			UnifiedRandom genRand4 = WorldGen.genRand;
			int num7 = 3;
			int num8 = genRand4.Next(num7);
			UnifiedRandom genRand5 = WorldGen.genRand;
			int num9 = 3;
			int num10 = genRand5.Next(num9);
		}

		// Token: 0x06002E6F RID: 11887 RVA: 0x001E0F40 File Offset: 0x001DF140
		public static void ExecuteThreadTime()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			DateTime now = DateTime.Now;
			if (!false)
			{
				if (3 == 0)
				{
					Thread.Sleep(0);
					MainThreadExecution.ExecuteSnippetsOnly();
					if (false)
					{
						goto IL_0038;
					}
					if (5 == 0)
					{
						return;
					}
				}
				return;
			}
			IL_0038:
			throw new OutOfMemoryException();
		}

		// Token: 0x06002E70 RID: 11888 RVA: 0x001E0FA8 File Offset: 0x001DF1A8
		private static void CloseThreadTime()
		{
			if (!true)
			{
			}
			if (!false)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06002E71 RID: 11889 RVA: 0x001E0FD8 File Offset: 0x001DF1D8
		private static void WaitForThreadTime()
		{
			if (!true)
			{
			}
			DateTime now = DateTime.Now;
			TimeSpan timeSpan;
			TimeSpan timeSpan2;
			bool flag = timeSpan > timeSpan2;
			long num = 0L;
			Monitor.Exit(timeSpan);
			if (num == 0L)
			{
				WorldGen.WaitForThreadTime();
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06002E72 RID: 11890 RVA: 0x001E109C File Offset: 0x001DF29C
		public static void SpawnPlanteraThorns(Vector2 position)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int num2 = 15744;
			int num3 = 32640;
			if (num2 == 0)
			{
			}
			if (num3 == 0)
			{
			}
			int num4 = 1;
			if (num4 == 0)
			{
			}
			Tile tile;
			bool flag = tile.active();
			if (num4 == 0)
			{
			}
			if (num4 == 0)
			{
			}
			Tile tile2;
			bool flag2 = tile2.active();
			if (num4 == 0)
			{
			}
			bool netHost = Main.NetHost;
			if (!false)
			{
			}
			long num5 = 0L;
			int num6;
			bool flag3 = WorldGen.InWorld(0, num6, (int)num5);
			if (!false)
			{
			}
			int num7;
			while (num7 != 0)
			{
			}
			if (!false)
			{
			}
		}

		// Token: 0x06002E73 RID: 11891 RVA: 0x001E1130 File Offset: 0x001DF330
		public static void GERunner(int i, int j, double speedX = 0.0, double speedY = 0.0, bool good = true)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Tile tile;
			bool flag = tile.active();
			Tile tile2;
			ushort type = tile2.type;
		}

		// Token: 0x06002E74 RID: 11892 RVA: 0x001E127C File Offset: 0x001DF47C
		private static bool badOceanCaveTiles(int x, int y)
		{
			/*
An exception occurred when decompiling this method (06002E74)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::badOceanCaveTiles(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_008B:
	stloc:uint16(var_23_92, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_22)))
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

		// Token: 0x06002E75 RID: 11893 RVA: 0x001E131C File Offset: 0x001DF51C
		public static void oceanCave(int i, int j)
		{
			if (!true)
			{
			}
			double num = WorldGen.genRand.NextDouble();
			double num2 = WorldGen.genRand.NextDouble();
			UnifiedRandom genRand = WorldGen.genRand;
			int num3 = 17;
			int num4 = 25;
			int num5 = genRand.Next(num3, num4);
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num6 = 600;
			int num7 = 800;
			int num8 = genRand2.Next(num6, num7);
			int num9 = 1;
			double num10 = WorldGen.genRand.NextDouble();
			long num11 = 32752L;
			long num12 = 32752L;
			if (num11 == 0L)
			{
			}
			if (num11 == 0L)
			{
			}
			if (num12 == 0L)
			{
			}
			if (num11 == 0L)
			{
			}
			long num13 = 16473L;
			if (num13 == 0L)
			{
			}
			bool flag = WorldGen.badOceanCaveTiles(1073741824, num9);
			if (num13 == 0L)
			{
			}
			if (num13 == 0L)
			{
			}
			int num14 = 264;
			Tile tile;
			tile.type = (ushort)num14;
			long num15 = 0L;
			tile.active(num15 != 0L);
		}

		// Token: 0x06002E76 RID: 11894 RVA: 0x001E1584 File Offset: 0x001DF784
		public static void WavyCaverer(int startX, int startY, double waveStrengthScalar, double wavePercentScalar, int steps, int type)
		{
			if (!true)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num = 2;
			int num2 = genRand.Next(num);
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num3 = 11;
			int num4 = genRand2.Next(num3);
			UnifiedRandom genRand3 = WorldGen.genRand;
			int num5 = 2;
			int num6 = genRand3.Next(num5);
			double num7 = WorldGen.genRand.NextDouble();
			double num8 = WorldGen.genRand.NextDouble();
			double num9 = Math.Max(num8, wavePercentScalar);
			double num10 = Math.Min(num9, num9);
			UnifiedRandom genRand4 = WorldGen.genRand;
			long num11 = 0L;
			double num12 = genRand4.NextDouble();
			double num13 = Math.Max(num12, num9);
			double num14 = Math.Min(num13, num13);
			int num15 = Math.Min(0, (int)num11);
		}

		// Token: 0x06002E77 RID: 11895 RVA: 0x001E1680 File Offset: 0x001DF880
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		public static void TileRunner(int i, int j, double strength, int steps, int type, bool addTile = false, double speedX = 0.0, double speedY = 0.0, bool noYChange = false, bool overRide = true, int ignoreTileType = -1)
		{
			if (!true)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num = 81;
			int num2 = genRand.Next(j, num);
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num3 = 81;
			int num4 = genRand2.Next(j, num3);
		}

		// Token: 0x06002E78 RID: 11896 RVA: 0x001E1BD4 File Offset: 0x001DFDD4
		public static void DirtyRockRunner(int i, int j)
		{
			if (!true)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num = 2;
			int num2 = 6;
			int num3 = genRand.Next(num, num2);
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num4 = 5;
			int num5 = 50;
			int num6 = genRand2.Next(num4, num5);
			UnifiedRandom genRand3 = WorldGen.genRand;
			int num7 = 11;
			int num8 = genRand3.Next(num4, num7);
			UnifiedRandom genRand4 = WorldGen.genRand;
			int num9 = 11;
			int num10 = genRand4.Next(num4, num9);
		}

		// Token: 0x06002E79 RID: 11897 RVA: 0x001E1C9C File Offset: 0x001DFE9C
		public static void MudWallRunner(int i, int j)
		{
			if (!true)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num = 8;
			int num2 = 21;
			int num3 = genRand.Next(num, num2);
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num4 = 8;
			int num5 = 33;
			int num6 = genRand2.Next(num4, num5);
			UnifiedRandom genRand3 = WorldGen.genRand;
			int num7 = 11;
			int num8 = genRand3.Next(num4, num7);
			UnifiedRandom genRand4 = WorldGen.genRand;
			int num9 = 11;
			int num10 = genRand4.Next(num4, num9);
		}

		// Token: 0x06002E7A RID: 11898 RVA: 0x001E1D64 File Offset: 0x001DFF64
		public static void SnowCloudIsland(int i, int j)
		{
			if (!true)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num = 100;
			int num2 = 150;
			int num3 = genRand.Next(num, num2);
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num4 = 20;
			int num5 = 30;
			int num6 = genRand2.Next(num4, num5);
			UnifiedRandom genRand3 = WorldGen.genRand;
			int num7 = 21;
			int num8 = genRand3.Next(num4, num7);
			UnifiedRandom genRand4 = WorldGen.genRand;
			int num9 = 21;
			if (genRand4.Next(num4, num9) != 0)
			{
			}
			int num10 = WorldGen.genRand.Next(num4, num9);
			UnifiedRandom genRand5 = WorldGen.genRand;
			int num11 = 4;
			int num12 = genRand5.Next(num11);
		}

		// Token: 0x06002E7B RID: 11899 RVA: 0x001E2364 File Offset: 0x001E0564
		public static void DesertCloudIsland(int i, int j)
		{
			if (!true)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num = 100;
			int num2 = 150;
			int num3 = genRand.Next(num, num2);
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num4 = 20;
			int num5 = 30;
			int num6 = genRand2.Next(num4, num5);
			UnifiedRandom genRand3 = WorldGen.genRand;
			int num7 = 21;
			int num8 = genRand3.Next(num4, num7);
			UnifiedRandom genRand4 = WorldGen.genRand;
			int num9 = 21;
			if (genRand4.Next(num4, num9) != 0)
			{
			}
			int num10 = WorldGen.genRand.Next(num4, num9);
			UnifiedRandom genRand5 = WorldGen.genRand;
			int num11 = 4;
			int num12 = genRand5.Next(num11);
		}

		// Token: 0x06002E7C RID: 11900 RVA: 0x001E2960 File Offset: 0x001E0B60
		public static void CloudIsland(int i, int j)
		{
			if (!true)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num = 100;
			int num2 = 150;
			int num3 = genRand.Next(num, num2);
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num4 = 20;
			int num5 = 30;
			int num6 = genRand2.Next(num4, num5);
			UnifiedRandom genRand3 = WorldGen.genRand;
			int num7 = 21;
			int num8 = genRand3.Next(num4, num7);
			UnifiedRandom genRand4 = WorldGen.genRand;
			int num9 = 21;
			if (genRand4.Next(num4, num9) != 0)
			{
			}
			int num10 = WorldGen.genRand.Next(num4, num9);
			UnifiedRandom genRand5 = WorldGen.genRand;
			int num11 = 4;
			int num12 = genRand5.Next(num11);
		}

		// Token: 0x06002E7D RID: 11901 RVA: 0x001E2F5C File Offset: 0x001E115C
		public static bool WillWaterPlacedHereStayPut(int x, int y)
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
			if (num != 0)
			{
				if (num == 0)
				{
				}
				Tile tile3;
				ushort type2 = tile3.type;
				if (num == 0)
				{
					goto IL_003E;
				}
			}
			if (num == 0)
			{
			}
			Tile tile4;
			byte liquid = tile4.liquid;
			IL_003E:
			if (num == 0)
			{
			}
			Tile tile5;
			bool flag2 = tile5.active();
			if (num == 0)
			{
			}
			Tile tile6;
			ushort type3 = tile6.type;
			if (num != 0)
			{
				if (num == 0)
				{
				}
				Tile tile7;
				ushort type4 = tile7.type;
				if (num == 0)
				{
					goto IL_0077;
				}
			}
			if (num == 0)
			{
			}
			Tile tile8;
			byte liquid2 = tile8.liquid;
			IL_0077:
			if (num == 0)
			{
			}
			Tile tile9;
			bool flag3 = tile9.active();
			if (num == 0)
			{
			}
			Tile tile10;
			ushort type5 = tile10.type;
			if (num != 0)
			{
				if (num == 0)
				{
				}
				Tile tile11;
				ushort type6 = tile11.type;
				if (num == 0)
				{
					return;
				}
			}
			if (num == 0)
			{
			}
			Tile tile12;
			byte liquid3 = tile12.liquid;
		}

		// Token: 0x06002E7E RID: 11902 RVA: 0x001E3024 File Offset: 0x001E1224
		public static void CloudLake(int i, int j)
		{
			if (!true)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num = 100;
			int num2 = 150;
			int num3 = genRand.Next(num, num2);
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num4 = 20;
			int num5 = 30;
			int num6 = genRand2.Next(num4, num5);
			UnifiedRandom genRand3 = WorldGen.genRand;
			int num7 = 21;
			int num8 = genRand3.Next(num4, num7);
			UnifiedRandom genRand4 = WorldGen.genRand;
			int num9 = 21;
			if (genRand4.Next(num4, num9) != 0)
			{
			}
			int num10 = WorldGen.genRand.Next(num4, num9);
			UnifiedRandom genRand5 = WorldGen.genRand;
			int num11 = 4;
			int num12 = genRand5.Next(num11);
		}

		// Token: 0x06002E7F RID: 11903 RVA: 0x001E3588 File Offset: 0x001E1788
		public static void FloatingIsland(int i, int j)
		{
			if (!true)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num = 80;
			int num2 = 120;
			int num3 = genRand.Next(num, num2);
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num4 = 20;
			int num5 = 25;
			int num6 = genRand2.Next(num4, num5);
			UnifiedRandom genRand3 = WorldGen.genRand;
			int num7 = 21;
			int num8 = genRand3.Next(num4, num7);
			UnifiedRandom genRand4 = WorldGen.genRand;
			int num9 = 21;
			if (genRand4.Next(num4, num9) != 0)
			{
			}
			int num10 = WorldGen.genRand.Next(num4, num9);
			UnifiedRandom genRand5 = WorldGen.genRand;
			int num11 = 4;
			int num12 = genRand5.Next(num11);
		}

		// Token: 0x06002E80 RID: 11904 RVA: 0x001E36C4 File Offset: 0x001E18C4
		public static void Caverer(int X, int Y)
		{
			if (!true)
			{
			}
			if (WorldGen.genRand.Next(2) == 0)
			{
				if (!true)
				{
				}
				int num = WorldGen.genRand.Next(7, 9);
				int num2 = WorldGen.genRand.Next(100);
				int num3 = WorldGen.genRand.Next(2);
				int num4 = WorldGen.genRand.Next(2);
				int num5 = WorldGen.genRand.Next(6, 20);
				int num6 = WorldGen.genRand.Next(4, 9);
				int num7 = WorldGen.genRand.Next(num6, 21);
				int num8 = WorldGen.genRand.Next(num6, 21);
				int num9 = WorldGen.genRand.Next(100);
				int num10 = WorldGen.genRand.Next(2);
				int num11 = WorldGen.genRand.Next(2);
				int num12 = WorldGen.genRand.Next(30, 50);
				int num13 = WorldGen.genRand.Next(3, 6);
				int num14 = WorldGen.genRand.Next(10, 20);
				int num15 = WorldGen.genRand.Next(5, 10);
				return;
			}
		}

		// Token: 0x06002E81 RID: 11905 RVA: 0x001E3838 File Offset: 0x001E1A38
		public static Vector2D digTunnel(double X, double Y, double xDir, double yDir, int Steps, int Size, bool Wet = false)
		{
			/*
An exception occurred when decompiling this method (06002E81)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ReLogic.Utilities.Vector2D Terraria.WorldGen::digTunnel(System.Double,System.Double,System.Double,System.Double,System.Int32,System.Int32,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:UnifiedRandom(var_3_0A, callgetter:UnifiedRandom(WorldGen::get_genRand))
	stloc:int32(var_4_0D, ldc.i4:int32(11))
	stloc:int32(var_5_19, call:int32(UnifiedRandom::Next, ldloc:UnifiedRandom(var_3_0A), ldloc:int32(Size), ldloc:int32(var_4_0D)))
	stloc:int64(var_7_1C, ldc.i4:int64(0))
	call:void(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_6), ldloc:int64[exp:bool](var_7_1C))
	stloc:int32(var_8_2C, ldc.i4:int32(255))
	callsetter:uint8(Tile::set_liquid, ldloc:Tile[exp:valuetype Terraria.Tile&](var_6), ldloc:int32[exp:uint8](var_8_2C))
	stloc:UnifiedRandom(var_9_3C, callgetter:UnifiedRandom(WorldGen::get_genRand))
	stloc:int32(var_10_40, ldc.i4:int32(51))
	stloc:int32(var_11_4D, call:int32(UnifiedRandom::Next, ldloc:UnifiedRandom(var_9_3C), ldloc:int32(var_8_2C), ldloc:int32(var_10_40)))
	stloc:UnifiedRandom(var_12_54, callgetter:UnifiedRandom(WorldGen::get_genRand))
	stloc:int32(var_13_58, ldc.i4:int32(21))
	stloc:int32(var_14_65, call:int32(UnifiedRandom::Next, ldloc:UnifiedRandom(var_12_54), ldloc:int32(var_8_2C), ldloc:int32(var_13_58)))
	stloc:UnifiedRandom(var_15_6C, callgetter:UnifiedRandom(WorldGen::get_genRand))
	stloc:int32(var_16_70, ldc.i4:int32(21))
	stloc:int32(var_17_7D, call:int32(UnifiedRandom::Next, ldloc:UnifiedRandom(var_15_6C), ldloc:int32(var_8_2C), ldloc:int32(var_16_70)))
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

		// Token: 0x06002E82 RID: 11906 RVA: 0x001E38CC File Offset: 0x001E1ACC
		public static void IslandHouse(int i, int j, int islandStyle)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
			if (num == 0)
			{
			}
			if (num == 0 || num == 0)
			{
			}
			if (num == 0)
			{
			}
			int num2;
			if (num == 0)
			{
				if (num == 0)
				{
				}
				num2 = 1;
				return;
			}
			if (num2 == 0)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num3 = 2;
			int num4 = genRand.Next(num3);
			if (num2 == 0)
			{
			}
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num5 = 7;
			int num6 = 12;
			int num7 = genRand2.Next(num5, num6);
			UnifiedRandom genRand3 = WorldGen.genRand;
			int num8 = 5;
			int num9 = 7;
			int num10 = genRand3.Next(num8, num9);
			if (num2 == 0)
			{
			}
			Tile tile;
			bool flag = tile.active();
		}

		// Token: 0x06002E83 RID: 11907 RVA: 0x001E3DC4 File Offset: 0x001E1FC4
		public static void Mountinater(int i, int j)
		{
			if (!true)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num = 80;
			int num2 = 120;
			int num3 = genRand.Next(num, num2);
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num4 = 40;
			int num5 = 55;
			int num6 = genRand2.Next(num4, num5);
			UnifiedRandom genRand3 = WorldGen.genRand;
			int num7 = 11;
			int num8 = genRand3.Next(num4, num7);
			int num9 = WorldGen.genRand.Next(num4, num7);
			UnifiedRandom genRand4 = WorldGen.genRand;
			int num10 = 4;
			int num11 = genRand4.Next(num10);
		}

		// Token: 0x06002E84 RID: 11908 RVA: 0x001E3EA4 File Offset: 0x001E20A4
		public static void MakeWateryIceThing(int i, int j)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Tile tile;
			byte liquid = tile.liquid;
			if (num == 0)
			{
			}
			Tile tile2;
			bool flag = tile2.active();
			if (num == 0)
			{
			}
			Tile tile3;
			bool flag2 = tile3.lava();
			Tile tile4;
			bool flag3 = tile4.active();
			Tile tile5;
			byte liquid2 = tile5.liquid;
		}

		// Token: 0x06002E85 RID: 11909 RVA: 0x001E3F74 File Offset: 0x001E2174
		public static void Lakinater(int i, int j, double strengthMultiplier = 1.0)
		{
			if (!true)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num = 25;
			int num2 = 50;
			int num3 = genRand.Next(num, num2);
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num4 = 30;
			int num5 = 80;
			int num6 = genRand2.Next(num4, num5);
			UnifiedRandom genRand3 = WorldGen.genRand;
			int num7 = 5;
			int num8 = genRand3.Next(num7);
			UnifiedRandom genRand4 = WorldGen.genRand;
			int num9 = 11;
			int num10 = genRand4.Next(num7, num9);
			int num11 = WorldGen.genRand.Next(num7, num9);
		}

		// Token: 0x06002E86 RID: 11910 RVA: 0x001E406C File Offset: 0x001E226C
		public static void SonOfLakinater(int i, int j, double strengthMultiplier = 1.0)
		{
			UnifiedRandom genRand = WorldGen.genRand;
			int num = 3;
			int num2 = genRand.Next(num);
		}

		// Token: 0x06002E87 RID: 11911 RVA: 0x001E42EC File Offset: 0x001E24EC
		public static void ShroomPatch(int i, int j)
		{
			if (!true)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num = 80;
			int num2 = 100;
			int num3 = genRand.Next(num, num2);
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num4 = 20;
			int num5 = 26;
			int num6 = genRand2.Next(num4, num5);
			UnifiedRandom genRand3 = WorldGen.genRand;
			int num7 = 101;
			int num8 = genRand3.Next(num4, num7);
			int num9 = WorldGen.genRand.Next(num4, num7);
			UnifiedRandom genRand4 = WorldGen.genRand;
			int num10 = 3;
			int num11 = genRand4.Next(num10);
		}

		// Token: 0x06002E88 RID: 11912 RVA: 0x001E446C File Offset: 0x001E266C
		public static void Cavinator(int i, int j, int steps)
		{
			if (!true)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num = 7;
			int num2 = 15;
			int num3 = genRand.Next(num, num2);
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num4 = 2;
			int num5 = genRand2.Next(num4);
			UnifiedRandom genRand3 = WorldGen.genRand;
			int num6 = 20;
			int num7 = 40;
			int num8 = genRand3.Next(num6, num7);
			UnifiedRandom genRand4 = WorldGen.genRand;
			int num9 = 10;
			int num10 = 20;
			int num11 = genRand4.Next(num9, num10);
			if (32752 == 0)
			{
			}
		}

		// Token: 0x06002E89 RID: 11913 RVA: 0x001E4578 File Offset: 0x001E2778
		public static void CaveOpenater(int i, int j)
		{
			if (!true)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num = 7;
			int num2 = 12;
			int num3 = genRand.Next(num, num2);
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num4 = 2;
			int num5 = genRand2.Next(num4);
			UnifiedRandom genRand3 = WorldGen.genRand;
			int num6 = 10;
			if (genRand3.Next(num6) == 0 || num5 == 0)
			{
			}
			Tile tile;
			ushort wall = tile.wall;
		}

		// Token: 0x06002E8A RID: 11914 RVA: 0x001E4640 File Offset: 0x001E2840
		public static void DiamondTileFrame(int i, int j)
		{
			if (!true)
			{
			}
			long num = 0L;
			long num2 = 0L;
			WorldGen.TileFrame(0, j, num != 0L, num2 != 0L);
			long num3 = 0L;
			long num4 = 0L;
			WorldGen.TileFrame(i, j, num3 != 0L, num4 != 0L);
			long num5 = 0L;
			long num6 = 0L;
			WorldGen.TileFrame(i, j, num5 != 0L, num6 != 0L);
			long num7 = 0L;
			long num8 = 0L;
			WorldGen.TileFrame(i, j, num7 != 0L, num8 != 0L);
		}

		// Token: 0x06002E8B RID: 11915 RVA: 0x001E468C File Offset: 0x001E288C
		public static void SquareTileFrame(int i, int j, bool resetFrame = true)
		{
			if (!true)
			{
			}
			long num = 0L;
			long num2 = 0L;
			WorldGen.TileFrame(43143168, 0, num != 0L, num2 != 0L);
			long num3 = 0L;
			long num4 = 0L;
			WorldGen.TileFrame(43143168, j, num3 != 0L, num4 != 0L);
			long num5 = 0L;
			long num6 = 0L;
			WorldGen.TileFrame(43143168, j, num5 != 0L, num6 != 0L);
			long num7 = 0L;
			long num8 = 0L;
			WorldGen.TileFrame(i, 0, num7 != 0L, num8 != 0L);
			long num9 = 0L;
			WorldGen.TileFrame(i, j, num7 != 0L, num9 != 0L);
			long num10 = 0L;
			long num11 = 0L;
			WorldGen.TileFrame(i, j, num10 != 0L, num11 != 0L);
			long num12 = 0L;
			long num13 = 0L;
			WorldGen.TileFrame(i, 0, num12 != 0L, num13 != 0L);
			long num14 = 0L;
			long num15 = 0L;
			WorldGen.TileFrame(i, j, num14 != 0L, num15 != 0L);
			long num16 = 0L;
			long num17 = 0L;
			WorldGen.TileFrame(i, j, num16 != 0L, num17 != 0L);
		}

		// Token: 0x06002E8C RID: 11916 RVA: 0x001E4738 File Offset: 0x001E2938
		public static void SquareWallFrame(int i, int j, bool resetFrame = true)
		{
			long num = 0L;
			Framing.WallFrame(i, j, num != 0L);
			long num2 = 0L;
			Framing.WallFrame(i, j, num2 != 0L);
			long num3 = 0L;
			Framing.WallFrame(i, j, num3 != 0L);
			long num4 = 0L;
			Framing.WallFrame(i, j, num4 != 0L);
			Framing.WallFrame(i, j, num4 != 0L);
			long num5 = 0L;
			Framing.WallFrame(i, j, num5 != 0L);
			long num6 = 0L;
			Framing.WallFrame(resetFrame ? 1 : 0, j, num6 != 0L);
			long num7 = 0L;
			Framing.WallFrame(resetFrame ? 1 : 0, j, num7 != 0L);
			long num8 = 0L;
			Framing.WallFrame(resetFrame ? 1 : 0, j, num8 != 0L);
		}

		// Token: 0x06002E8D RID: 11917 RVA: 0x001E47A8 File Offset: 0x001E29A8
		public static void SectionTileFrameWithCheck(int startX, int startY, int endX, int endY)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int sectionX = Netplay.GetSectionX(startX);
			int sectionY = Netplay.GetSectionY(startY);
			int sectionX2 = Netplay.GetSectionX(endX);
			int sectionY2 = Netplay.GetSectionY(endY);
			if (num == 0)
			{
			}
			bool flag = Main.sectionManager.SectionLoaded(sectionX, sectionY);
			if (num == 0)
			{
			}
			bool flag2 = Main.sectionManager.SectionFramed(sectionX, sectionY);
			if (num == 0)
			{
			}
			WorldGen.SectionTileFrame(sectionX, sectionY, sectionX, sectionY);
			if (num == 0)
			{
			}
			bool anyUnfinishedSections = Main.sectionManager.AnyUnfinishedSections;
		}

		// Token: 0x06002E8E RID: 11918 RVA: 0x001E4820 File Offset: 0x001E2A20
		public static void RefreshSections(int startX, int startY, int endX, int endY)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int sectionX = Netplay.GetSectionX(startX);
			int sectionY = Netplay.GetSectionY(startY);
			int sectionX2 = Netplay.GetSectionX(endX);
			int sectionY2 = Netplay.GetSectionY(endY);
			if (num == 0)
			{
			}
			bool flag = Main.sectionManager.SectionNeedsRefresh(sectionX, sectionY);
			if (num == 0)
			{
			}
			WorldGen.RefreshSection(sectionX, sectionY);
		}

		// Token: 0x06002E8F RID: 11919 RVA: 0x001E4870 File Offset: 0x001E2A70
		public static void RefreshSection(int sectionX, int sectionY)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int num2 = 1;
			if (num == 0)
			{
			}
			int num3 = Math.Min(Math.Min(0, sectionX), sectionX);
			if (num2 == 0)
			{
			}
			Main.sectionManager.SetSectionAsRefreshed(sectionX, 0);
		}

		// Token: 0x06002E90 RID: 11920 RVA: 0x001E48A8 File Offset: 0x001E2AA8
		public static void RefreshStrip(int xStart, int yStart, int xEnd, int yEnd, int totalEcho, int totalFramed)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Tile tile;
			bool flag = tile.invisibleBlock();
		}

		// Token: 0x06002E91 RID: 11921 RVA: 0x001E48F0 File Offset: 0x001E2AF0
		public static void Reframe(int x, int y, bool resetFrame = false)
		{
			if (!true)
			{
			}
			WorldGen.TileFrame(x, y, resetFrame, true);
			Framing.WallFrame(x, y, resetFrame);
		}

		// Token: 0x06002E92 RID: 11922 RVA: 0x001E4914 File Offset: 0x001E2B14
		public static void SectionTileFrame(int sectionStartX, int sectionStartY, int sectionEndXInclusive, int sectionEndYInclusive)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Main.mapTime = Main.mapTimeMax;
			if (num == 0)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x06002E93 RID: 11923 RVA: 0x001E4948 File Offset: 0x001E2B48
		public static void GetSectionBounds(int sectionStartX, int sectionStartY, int sectionEndXInclusive, int sectionEndYInclusive, [Out] int tileStartX, [Out] int tileEndX, [Out] int tileStartY, [Out] int tileEndY)
		{
			int num = 200;
			int num2 = 150;
			tileEndX.m_value = num;
			tileEndY.m_value = num2;
			int num3 = 1;
			tileStartX.m_value = num3;
			int num4 = 1;
			tileStartY.m_value = num4;
			if (num4 == 0)
			{
			}
			if (num2 == 0)
			{
			}
			tileStartX.m_value = num4;
			if (num4 == 0)
			{
			}
			if (num2 == 0)
			{
			}
			tileStartY.m_value = num4;
			if (num4 == 0)
			{
			}
			if (num2 == 0)
			{
			}
			tileEndX.m_value = num4;
			if (num4 == 0)
			{
			}
			if (num2 == 0)
			{
			}
		}

		// Token: 0x06002E94 RID: 11924 RVA: 0x001E49B8 File Offset: 0x001E2BB8
		public static void RangeFrame(int startX, int startY, int endX, int endY)
		{
			if (!true)
			{
			}
			long num = 0L;
			long num2 = 0L;
			WorldGen.TileFrame(startX, endY, num != 0L, num2 != 0L);
			long num3 = 0L;
			Framing.WallFrame(startX, endY, num3 != 0L);
		}

		// Token: 0x06002E95 RID: 11925 RVA: 0x001E49E0 File Offset: 0x001E2BE0
		public static void WaterCheck()
		{
			if (!true)
			{
			}
			Liquid.tilesIgnoreWater(true);
			long num = 1L;
			if (num != 0L)
			{
				return;
			}
			Liquid.tilesIgnoreWater(false);
		}

		// Token: 0x06002E96 RID: 11926 RVA: 0x001E4A6C File Offset: 0x001E2C6C
		public static void EveryTileFrame()
		{
			int num = 1;
			if (num == 0)
			{
			}
			int num2 = 1;
			long num3 = 0L;
			if (num == 0)
			{
			}
			if (num2 == 0)
			{
			}
			if (num2 == 0)
			{
			}
			string text2;
			string text = text2 + " " + text2 + "%";
			long num4 = 0L;
			if (text == null)
			{
			}
			if (num2 == 0)
			{
			}
			Tile tile;
			bool flag = tile.active();
			int num5 = 1;
			long num6 = 0L;
			WorldGen.TileFrame((int)num3, (int)num4, num5 != 0, num6 != 0L);
			Tile tile2;
			ushort wall = tile2.wall;
			int num7 = 1;
			Framing.WallFrame((int)num3, (int)num4, num7 != 0);
		}

		// Token: 0x06002E97 RID: 11927 RVA: 0x001E4ADC File Offset: 0x001E2CDC
		public static void PlantCheck(int x, int y)
		{
			if (!true)
			{
			}
			Tile tile;
			if (tile.type == 0)
			{
			}
			Tile tile2;
			bool flag = tile2.nactive();
			Tile tile3;
			ushort type = tile3.type;
			Tile tile4;
			bool flag2 = tile4.nactive();
			Tile tile5;
			ushort type2 = tile5.type;
			Tile tile6;
			bool flag3 = tile6.nactive();
			Tile tile7;
			ushort type3 = tile7.type;
			Tile tile8;
			bool flag4 = tile8.nactive();
			Tile tile9;
			bool flag5 = tile9.halfBrick();
			Tile tile10;
			byte b = tile10.slope();
			Tile tile11;
			ushort type4 = tile11.type;
			Tile tile12;
			bool flag6 = tile12.nactive();
			Tile tile13;
			ushort type5 = tile13.type;
			Tile tile14;
			bool flag7 = tile14.nactive();
			Tile tile15;
			ushort type6 = tile15.type;
			Tile tile16;
			bool flag8 = tile16.nactive();
			Tile tile17;
			ushort type7 = tile17.type;
			Tile tile18;
			bool flag9 = tile18.nactive();
			Tile tile19;
			ushort type8 = tile19.type;
		}

		// Token: 0x06002E98 RID: 11928 RVA: 0x001E4C7C File Offset: 0x001E2E7C
		public static bool CanPoundTile(int x, int y)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Tile tile;
			ushort type = tile.type;
			if (num == 0)
			{
			}
			if (43143168 != 0)
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
			}
			if (num == 0)
			{
			}
			Tile tile4;
			bool flag = tile4.active();
			if (num == 0)
			{
			}
			Tile tile5;
			ushort type4 = tile5.type;
			if (num == 0)
			{
			}
			return WorldGen.CanKillTile(0, x);
		}

		// Token: 0x06002E99 RID: 11929 RVA: 0x001E4CFC File Offset: 0x001E2EFC
		public static bool SlopeTile(int i, int j, int slope = 0, bool noEffects = false)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool flag = WorldGen.CanPoundTile(0, i);
			if (num == 0)
			{
			}
			long num2 = 0L;
			Tile tile;
			tile.halfBrick(num2 != 0L);
			Tile tile2;
			tile2.slope((byte)j);
			if (j == 0)
			{
				int num3 = 1;
				int num4 = 1;
				long num5 = 0L;
				WorldGen.KillTile(0, i, num3 != 0, num4 != 0, num5 != 0L);
				int num6 = 1;
				WorldGen.SquareTileFrame(0, i, num6 != 0);
				Tile tile3;
				byte b = tile3.slope();
				return;
			}
		}

		// Token: 0x06002E9A RID: 11930 RVA: 0x001E4D6C File Offset: 0x001E2F6C
		public static bool PoundTile(int i, int j)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool flag = WorldGen.CanPoundTile(0, i);
			if (num == 0)
			{
			}
			long num2 = 0L;
			Tile tile;
			bool flag2 = tile.halfBrick();
			Tile tile2;
			tile2.halfBrick(num2 != 0L);
			if (!flag2)
			{
				int num3 = 1;
				int num4 = 1;
				long num5 = 0L;
				WorldGen.KillTile(0, i, num3 != 0, num4 != 0, num5 != 0L);
				Tile tile3;
				bool flag3 = tile3.halfBrick();
				return;
			}
		}

		// Token: 0x06002E9B RID: 11931 RVA: 0x001E4DD4 File Offset: 0x001E2FD4
		public static void PoundPlatform(int x, int y)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Tile tile;
			bool flag = tile.halfBrick();
			if (num == 0)
			{
			}
			bool flag2 = WorldGen.PoundTile(x, y);
			if (num == 0)
			{
			}
			bool netClient = Main.NetClient;
			if (num == 0)
			{
			}
		}

		// Token: 0x06002E9C RID: 11932 RVA: 0x001E4EC0 File Offset: 0x001E30C0
		public static int PlatformProperSides(int x, int y, bool acceptNonOpposing = false)
		{
			/*
An exception occurred when decompiling this method (06002E9C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.WorldGen::PlatformProperSides(System.Int32,System.Int32,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0088:
	stloc:uint16(var_32_92, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_30)))
	stloc:uint8(var_34_9B, call:uint8(Tile::slope, ldloc:Tile[exp:valuetype Terraria.Tile&](var_33)))
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

		// Token: 0x06002E9D RID: 11933 RVA: 0x001E4F6C File Offset: 0x001E316C
		public static bool CacheUpdateMapTile(int i, int j, bool addToList = true)
		{
			if (!true)
			{
			}
			if (19999 == 0)
			{
				return;
			}
		}

		// Token: 0x06002E9E RID: 11934 RVA: 0x001E4F88 File Offset: 0x001E3188
		public static void PerformCachedMapTileUpdates()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int num2 = 1;
			long num3 = 0L;
			bool flag = WorldGen.UpdateMapTile(0, (int)num3, num2 != 0);
		}

		// Token: 0x06002E9F RID: 11935 RVA: 0x001E4FB0 File Offset: 0x001E31B0
		public static bool UpdateMapTile(int i, int j, bool addToList = true)
		{
			/*
An exception occurred when decompiling this method (06002E9F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::UpdateMapTile(System.Int32,System.Int32,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0058:
	callsetter:bool(Main::set_refreshMap, ldc.i4:bool(1))
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

		// Token: 0x06002EA0 RID: 11936 RVA: 0x001E5020 File Offset: 0x001E3220
		public static void TileMergeAttemptFrametest(int i, int j, int myType, int lookfor, int up, int down, int left, int right, int upLeft, int upRight, int downLeft, int downRight)
		{
			long num = 0L;
			long num2 = 0L;
			WorldGen.TileFrame(i, j, num != 0L, num2 != 0L);
			up.m_value = myType;
			long num3 = 0L;
			long num4 = 0L;
			WorldGen.TileFrame(i, j, num3 != 0L, num4 != 0L);
			down.m_value = myType;
			long num5 = 0L;
			long num6 = 0L;
			WorldGen.TileFrame(0, j, num5 != 0L, num6 != 0L);
			if (false)
			{
				left.m_value = myType;
			}
			long num7 = 0L;
			long num8 = 0L;
			WorldGen.TileFrame(0, j, num7 != 0L, num8 != 0L);
			if (false)
			{
				right.m_value = myType;
			}
			down.m_value = myType;
			left.m_value = myType;
		}

		// Token: 0x06002EA1 RID: 11937 RVA: 0x001E50A0 File Offset: 0x001E32A0
		public static void TileMergeAttemptFrametest(int i, int j, int myType, bool[] lookfor, int up, int down, int left, int right, int upLeft, int upRight, int downLeft, int downRight)
		{
			int num = 1;
			if (num != 0)
			{
				if (num == 0)
				{
				}
				long num2 = 0L;
				long num3 = 0L;
				WorldGen.TileFrame(i, j, num2 != 0L, num3 != 0L);
				up.m_value = myType;
			}
			long num4 = 0L;
			long num5 = 0L;
			WorldGen.TileFrame(i, j, num4 != 0L, num5 != 0L);
			down.m_value = myType;
			long num6 = 0L;
			long num7 = 0L;
			WorldGen.TileFrame(0, j, num6 != 0L, num7 != 0L);
			if (false)
			{
				left.m_value = myType;
			}
			if (false)
			{
				if (!false)
				{
				}
				long num8 = 0L;
				long num9 = 0L;
				WorldGen.TileFrame(0, j, num8 != 0L, num9 != 0L);
				if (false)
				{
					right.m_value = myType;
				}
			}
			down.m_value = myType;
			left.m_value = myType;
			if (false)
			{
			}
		}

		// Token: 0x06002EA2 RID: 11938 RVA: 0x001E5134 File Offset: 0x001E3334
		public static void TileMergeAttempt(int myType, int lookfor, int up, int down, int left, int right)
		{
			up.m_value = myType;
			down.m_value = myType;
			left.m_value = myType;
			right.m_value = myType;
		}

		// Token: 0x06002EA3 RID: 11939 RVA: 0x001E5160 File Offset: 0x001E3360
		public static void TileMergeAttempt(int myType, bool[] lookfor, int up, int down, int left, int right)
		{
			up.m_value = myType;
			down.m_value = myType;
			left.m_value = myType;
			right.m_value = myType;
		}

		// Token: 0x06002EA4 RID: 11940 RVA: 0x001E518C File Offset: 0x001E338C
		public static void TileMergeAttempt(int myType, int lookfor, int up, int down, int left, int right, int upLeft, int upRight, int downLeft, int downRight)
		{
			up.m_value = myType;
			down.m_value = myType;
			left.m_value = myType;
			right.m_value = myType;
			upLeft.m_value = myType;
			upRight.m_value = myType;
		}

		// Token: 0x06002EA5 RID: 11941 RVA: 0x001E51C8 File Offset: 0x001E33C8
		public static void TileMergeAttempt(int myType, bool[] lookfor, int up, int down, int left, int right, int upLeft, int upRight, int downLeft, int downRight)
		{
			up.m_value = myType;
			down.m_value = myType;
			left.m_value = myType;
			right.m_value = myType;
			upLeft.m_value = myType;
			upRight.m_value = myType;
		}

		// Token: 0x06002EA6 RID: 11942 RVA: 0x001E5204 File Offset: 0x001E3404
		public static void TileMergeAttempt(int myType, bool[] lookfor, bool[] exclude, int up, int down, int left, int right, int upLeft, int upRight, int downLeft, int downRight)
		{
			up.m_value = myType;
			down.m_value = myType;
			left.m_value = myType;
			right.m_value = myType;
			upLeft.m_value = myType;
		}

		// Token: 0x06002EA7 RID: 11943 RVA: 0x001E5238 File Offset: 0x001E3438
		public static void TileMergeAttemptWeird(int myType, int changeTo, bool[] exclude, int up, int down, int left, int right, int upLeft, int upRight, int downLeft, int downRight)
		{
			up.m_value = changeTo;
			down.m_value = changeTo;
			left.m_value = changeTo;
			right.m_value = changeTo;
			upLeft.m_value = changeTo;
		}

		// Token: 0x06002EA8 RID: 11944 RVA: 0x001E526C File Offset: 0x001E346C
		public static int GetTileMossColor(int tileType)
		{
			return 4;
		}

		// Token: 0x06002EA9 RID: 11945 RVA: 0x001E528C File Offset: 0x001E348C
		public static void CheckFoodPlatter(int x, int y, int type)
		{
			int num = 1;
			if (num == 0)
			{
			}
			long num2 = 0L;
			Tile tile;
			bool isLoaded = tile.IsLoaded;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				if (num == 0)
				{
				}
				bool flag = WorldGen.SolidTileAllowBottomSlope(x, (int)num2);
				int num3 = TEFoodPlatter.Find(x, y);
				if (num == 0)
				{
				}
				bool logicClient = Main.LogicClient;
				Player localPlayer = Main.LocalPlayer;
				int num4 = 520;
				localPlayer.InterruptItemUsageIfOverTile(num4);
				Tile tile2;
				ushort type2 = tile2.type;
				long num5 = 0L;
				long num6 = 0L;
				long num7 = 0L;
				WorldGen.KillTile(x, y, num5 != 0L, num6 != 0L, num7 != 0L);
				TEFoodPlatter.Kill(x, y);
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06002EAA RID: 11946 RVA: 0x001E5318 File Offset: 0x001E3518
		public static bool SkipFramingBecauseOfGen
		{
			get
			{
				if (!true)
				{
					return;
				}
			}
		}

		// Token: 0x06002EAB RID: 11947 RVA: 0x001E532C File Offset: 0x001E352C
		public static void TileFrameDoWork(int i, int j, bool resetFrame, bool noBreak, bool mapCheck)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int num2 = 1;
			bool flag = WorldGen.CacheUpdateMapTile(i, j, num2 != 0);
			mapCheck.m_value = num != 0;
			if (num == 0)
			{
			}
			int num3 = 175;
			if (num3 == 0)
			{
			}
			if (num3 == 0)
			{
			}
			if (num3 == 0)
			{
				Liquid.AddWater(i, j);
			}
		}

		// Token: 0x06002EAC RID: 11948 RVA: 0x001E6A88 File Offset: 0x001E4C88
		public static void TileFrame(int i, int j, bool resetFrame = false, bool noBreak = false)
		{
			if (!true)
			{
			}
			bool skipFramingBecauseOfGen = WorldGen.SkipFramingBecauseOfGen;
			Tile tile;
			ushort type = tile.type;
		}

		// Token: 0x06002EAD RID: 11949 RVA: 0x001E6AB4 File Offset: 0x001E4CB4
		private static void StopMergingByInvsibility(int currentMerge, Tile block, bool wantedInvisibilityState)
		{
		}

		// Token: 0x06002EAE RID: 11950 RVA: 0x001E6AC4 File Offset: 0x001E4CC4
		private static bool SpawnFallingBlockProjectile(int i, int j, Tile tileCache, Tile tileTopCache, Tile tileBottomCache, int type)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			bool flag = WorldGen.BlockBelowMakesSandFall(0, i);
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			tileBottomCache.ClearTile();
			if (num == 0)
			{
			}
			if (num == 0)
			{
				if (!false)
				{
				}
				int myPlayer = Main.myPlayer;
				int num2 = 1;
				int num3;
				WorldGen.SquareTileFrame(num3, i, num2 != 0);
			}
			bool netHost = Main.NetHost;
			int num4 = 8;
			int num5 = 10;
			if (num4 == 0)
			{
			}
			if (num5 != 0)
			{
				if (num5 == 0)
				{
				}
				int myPlayer2 = Main.myPlayer;
				if (num5 == 0)
				{
				}
				if (num5 == 0)
				{
				}
			}
			int myPlayer3 = Main.myPlayer;
			if (num5 == 0)
			{
			}
			int num6 = 1;
			WorldGen.SquareTileFrame(0, i, num6 != 0);
			return false;
		}

		// Token: 0x06002EAF RID: 11951 RVA: 0x001E6B68 File Offset: 0x001E4D68
		public static void CheckTorch(int x, int y)
		{
			if (!true)
			{
			}
			Tile tile;
			short frameX = tile.frameX;
			int num = 66;
			if (num == 0)
			{
			}
			long num2 = 0L;
			if (num != 0)
			{
				bool flag = WorldGen.TopEdgeCanBeAttachedTo(x, (int)num2);
			}
		}

		// Token: 0x06002EB0 RID: 11952 RVA: 0x001E6BF8 File Offset: 0x001E4DF8
		public static void CheckProjectilePressurePad(int i, int j)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Tile tile;
			short frameX = tile.frameX;
		}

		// Token: 0x06002EB1 RID: 11953 RVA: 0x001E6C50 File Offset: 0x001E4E50
		private static void CheckProjectilePressurePad_GetPossiblePlacementDirections(int i, int j, [Out] bool canUp, [Out] bool canLeft, [Out] bool canRight, [Out] bool canDown)
		{
			if (!true)
			{
			}
			Tile tile;
			bool flag = tile.nactive();
		}

		// Token: 0x06002EB2 RID: 11954 RVA: 0x001E6CF8 File Offset: 0x001E4EF8
		public static bool IsTreeType(int tree)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06002EB3 RID: 11955 RVA: 0x001E6D0C File Offset: 0x001E4F0C
		public static int CanPlaceProjectilePressurePad(int x, int y, int type = 442, int style = 0, int direction = 0, int alternate = 0)
		{
			if (!true)
			{
			}
			WorldGen.CheckProjectilePressurePad_GetPossiblePlacementDirections(0, x, y != 0, type != 0, style != 0, direction != 0);
			return 0;
		}

		// Token: 0x06002EB4 RID: 11956 RVA: 0x001E6D38 File Offset: 0x001E4F38
		private static void CheckDoorOpen(int i, int j, Tile tileCache)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				return;
			}
			int num2 = 54;
			if (num2 != 0)
			{
				return;
			}
		}

		// Token: 0x06002EB5 RID: 11957 RVA: 0x001E6DA8 File Offset: 0x001E4FA8
		private static void CheckDoorClosed(int i, int j, Tile tileCache, int type)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				int num2 = 36409;
				if (num2 == 0)
				{
				}
				if (num2 == 0)
				{
				}
				if (num2 == 0)
				{
				}
				return;
			}
		}

		// Token: 0x06002EB6 RID: 11958 RVA: 0x001E6E24 File Offset: 0x001E5024
		private static void GetSandfallProjData(int type, [Out] int projType, [Out] int dmg)
		{
			int num = 10;
			dmg.m_value = num;
		}

		// Token: 0x06002EB7 RID: 11959 RVA: 0x001E6E68 File Offset: 0x001E5068
		public static bool BlockBelowMakesSandConvertIntoHardenedSand(int i, int j)
		{
			/*
An exception occurred when decompiling this method (06002EB7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::BlockBelowMakesSandConvertIntoHardenedSand(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:bool(var_1_09, call:bool(Tile::nactive, ldloc:Tile[exp:valuetype Terraria.Tile&](var_0)))
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

		// Token: 0x06002EB8 RID: 11960 RVA: 0x001E6E84 File Offset: 0x001E5084
		public static bool BlockBelowMakesSandFall(int i, int j)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06002EB9 RID: 11961 RVA: 0x001E6E98 File Offset: 0x001E5098
		public static bool AllowsSandfall(Tile tileTopCache)
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

		// Token: 0x06002EBA RID: 11962 RVA: 0x001E6EB8 File Offset: 0x001E50B8
		public static void TriggerLunarApocalypse()
		{
		}

		// Token: 0x06002EBB RID: 11963 RVA: 0x001E6FC4 File Offset: 0x001E51C4
		public static void UpdateLunarApocalypse()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
			if (num == 0)
			{
			}
			if (num != 0)
			{
				if (num == 0)
				{
				}
				return;
			}
		}

		// Token: 0x06002EBC RID: 11964 RVA: 0x001E7004 File Offset: 0x001E5204
		public static void StartImpendingDoom(int countdownTime)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			NetworkText networkText;
			WorldGen.BroadcastText(networkText, 50, 255, 130);
			bool logicHost = Main.LogicHost;
			WorldGen.GetRidOfCultists();
		}

		// Token: 0x06002EBD RID: 11965 RVA: 0x001E7040 File Offset: 0x001E5240
		public static void GetRidOfCultists()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			bool logicHost = Main.LogicHost;
			if (num == 0)
			{
			}
		}

		// Token: 0x06002EBE RID: 11966 RVA: 0x001E7068 File Offset: 0x001E5268
		public static void MessageLunarApocalypse()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002EBF RID: 11967 RVA: 0x001E709C File Offset: 0x001E529C
		public static void BroadcastText(NetworkText text, Vector4 color)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002EC0 RID: 11968 RVA: 0x001E70AC File Offset: 0x001E52AC
		public static void BroadcastText(NetworkText text, Vector3 color)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002EC1 RID: 11969 RVA: 0x001E70BC File Offset: 0x001E52BC
		public static void BroadcastText(NetworkText text, int r, int g, int b)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002EC2 RID: 11970 RVA: 0x001E70CC File Offset: 0x001E52CC
		public static void BroadcastText(NetworkText text, byte r, byte g, byte b)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002EC3 RID: 11971 RVA: 0x001E70DC File Offset: 0x001E52DC
		public static void BroadcastText(NetworkText text, Color color)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			bool netHost = Main.NetHost;
		}

		// Token: 0x06002EC4 RID: 11972 RVA: 0x001E70F8 File Offset: 0x001E52F8
		public static bool CanCutTile(int x, int y, TileCuttingContext context)
		{
			int num;
			do
			{
				num = 1;
				if (num == 0)
				{
				}
			}
			while (num == 0);
			if (!false)
			{
				return;
			}
		}

		// Token: 0x06002EC5 RID: 11973 RVA: 0x001E7114 File Offset: 0x001E5314
		public static bool InAPlaceWithWind(Vector2 position, int width, int height)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06002EC6 RID: 11974 RVA: 0x001E7134 File Offset: 0x001E5334
		public static bool DoesWindBlowAtThisHeight(int tileY)
		{
			/*
An exception occurred when decompiling this method (06002EC6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::DoesWindBlowAtThisHeight(System.Int32)

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

		// Token: 0x06002EC7 RID: 11975 RVA: 0x001E7144 File Offset: 0x001E5344
		public static bool InAPlaceWithWind(int x, int y, int width, int height)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool flag = WorldGen.DoesWindBlowAtThisHeight(x);
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
				return;
			}
		}

		// Token: 0x06002EC8 RID: 11976 RVA: 0x001E7178 File Offset: 0x001E5378
		public static int[] CountTileTypesInWorld(params int[] oreTypes)
		{
			/*
An exception occurred when decompiling this method (06002EC8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32[] Terraria.WorldGen::CountTileTypesInWorld(System.Int32[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000C:
	stloc:bool(var_4_12, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_3)))
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

		// Token: 0x06002EC9 RID: 11977 RVA: 0x001E719C File Offset: 0x001E539C
		public WorldGen()
		{
		}

		// Token: 0x06002ECA RID: 11978 RVA: 0x001E71B0 File Offset: 0x001E53B0
		// Note: this type is marked as 'beforefieldinit'.
		static WorldGen()
		{
		}

		// Token: 0x06002ECB RID: 11979 RVA: 0x001E71FC File Offset: 0x001E53FC
		[CompilerGenerated]
		internal static bool <GenerateWorld>g__SolidTileL|277_105(int x, int y, WorldGen.<>c__DisplayClass277_0 cpp2il__autoParamName__idx_3)
		{
		}

		// Token: 0x06002ECC RID: 11980 RVA: 0x000021DB File Offset: 0x000003DB
		[CompilerGenerated]
		internal static bool <GenerateWorld>g__Main_tile_active|277_106(int x, int y, WorldGen.<>c__DisplayClass277_0 cpp2il__autoParamName__idx_3)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002ECD RID: 11981 RVA: 0x000021DB File Offset: 0x000003DB
		[CompilerGenerated]
		internal static ushort <GenerateWorld>g__Main_tile_type|277_107(int x, int y, WorldGen.<>c__DisplayClass277_0 cpp2il__autoParamName__idx_3)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002ECE RID: 11982 RVA: 0x000021DB File Offset: 0x000003DB
		[CompilerGenerated]
		internal static bool <GenerateWorld>g__Main_tile_halfBrick|277_108(int x, int y, WorldGen.<>c__DisplayClass277_0 cpp2il__autoParamName__idx_3)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002ECF RID: 11983 RVA: 0x000021DB File Offset: 0x000003DB
		[CompilerGenerated]
		internal static byte <GenerateWorld>g__Main_tile_slope|277_109(int x, int y, WorldGen.<>c__DisplayClass277_0 cpp2il__autoParamName__idx_3)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002ED0 RID: 11984 RVA: 0x000021DB File Offset: 0x000003DB
		[CompilerGenerated]
		internal static bool <GenerateWorld>g__Main_tile_active|277_112(int x, int y, WorldGen.<>c__DisplayClass277_2 cpp2il__autoParamName__idx_3)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002ED1 RID: 11985 RVA: 0x001E720C File Offset: 0x001E540C
		[CompilerGenerated]
		internal unsafe static void <GenerateWorld>g__TileActiveSet|277_113(int _tileOffset, bool isActive, WorldGen.<>c__DisplayClass277_2 cpp2il__autoParamName__idx_2)
		{
			short* tileData_TileSHeader = cpp2il__autoParamName__idx_2.TileData_TileSHeader;
		}

		// Token: 0x06002ED2 RID: 11986 RVA: 0x000021DB File Offset: 0x000003DB
		[CompilerGenerated]
		internal static short <GenerateWorld>g__Main_tile_frameX|277_114(int x, int y, WorldGen.<>c__DisplayClass277_2 cpp2il__autoParamName__idx_3)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002ED3 RID: 11987 RVA: 0x000021DB File Offset: 0x000003DB
		[CompilerGenerated]
		internal static ushort <GenerateWorld>g__Main_tile_type|277_115(int x, int y, WorldGen.<>c__DisplayClass277_2 cpp2il__autoParamName__idx_3)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002ED4 RID: 11988 RVA: 0x000021DB File Offset: 0x000003DB
		[CompilerGenerated]
		internal static byte <GenerateWorld>g__Main_tile_slope|277_116(int x, int y, WorldGen.<>c__DisplayClass277_2 cpp2il__autoParamName__idx_3)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002ED5 RID: 11989 RVA: 0x001E722C File Offset: 0x001E542C
		[CompilerGenerated]
		internal unsafe static void <GenerateWorld>g__Main_tile_slope_set|277_117(int _tileOffset, short slope, WorldGen.<>c__DisplayClass277_2 cpp2il__autoParamName__idx_2)
		{
			short* tileData_TileSHeader = cpp2il__autoParamName__idx_2.TileData_TileSHeader;
		}

		// Token: 0x06002ED6 RID: 11990 RVA: 0x000021DB File Offset: 0x000003DB
		[CompilerGenerated]
		internal static bool <GenerateWorld>g__Main_tile_halfBrick|277_118(int x, int y, WorldGen.<>c__DisplayClass277_2 cpp2il__autoParamName__idx_3)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002ED7 RID: 11991 RVA: 0x001E7240 File Offset: 0x001E5440
		[CompilerGenerated]
		internal unsafe static void <GenerateWorld>g__Main_tile_halfBrick_set|277_119(int _tileOffset, bool halfBrick, WorldGen.<>c__DisplayClass277_2 cpp2il__autoParamName__idx_2)
		{
			short* tileData_TileSHeader = cpp2il__autoParamName__idx_2.TileData_TileSHeader;
			TileData.SetSHeader(_tileOffset, halfBrick ? 1 : 0);
		}

		// Token: 0x06002ED8 RID: 11992 RVA: 0x001E725C File Offset: 0x001E545C
		[CompilerGenerated]
		internal static bool <GenerateWorld>g__Main_tile_lava|277_120(int x, int y, WorldGen.<>c__DisplayClass277_2 cpp2il__autoParamName__idx_3)
		{
			/*
An exception occurred when decompiling this method (06002ED8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen::<GenerateWorld>g__Main_tile_lava|277_120(System.Int32,System.Int32,Terraria.WorldGen/<>c__DisplayClass277_2)

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

		// Token: 0x06002ED9 RID: 11993 RVA: 0x001E726C File Offset: 0x001E546C
		[CompilerGenerated]
		internal static bool <GenerateWorld>g__Main_tile_honey|277_121(int x, int y, WorldGen.<>c__DisplayClass277_2 cpp2il__autoParamName__idx_3)
		{
			if (!true)
			{
			}
			return false;
		}

		// Token: 0x040037F4 RID: 14324
		public static TownRoomManager TownManager;

		// Token: 0x040037F5 RID: 14325
		private static Queue<Action<StructureMap>> _postGenActions;

		// Token: 0x040037F6 RID: 14326
		public static int tileReframeCount;

		// Token: 0x040037F7 RID: 14327
		public static int globalTileReframeCount;

		// Token: 0x040037F8 RID: 14328
		public static List<WorldGen.PendingRefame> pendingGlobalFrames;

		// Token: 0x040037F9 RID: 14329
		public static bool noMapUpdate;

		// Token: 0x040037FA RID: 14330
		public static int treeBG1;

		// Token: 0x040037FB RID: 14331
		public static int treeBG2;

		// Token: 0x040037FC RID: 14332
		public static int treeBG3;

		// Token: 0x040037FD RID: 14333
		public static int treeBG4;

		// Token: 0x040037FE RID: 14334
		public static int corruptBG;

		// Token: 0x040037FF RID: 14335
		public static int jungleBG;

		// Token: 0x04003800 RID: 14336
		public static int snowBG;

		// Token: 0x04003801 RID: 14337
		public static int hallowBG;

		// Token: 0x04003802 RID: 14338
		public static int crimsonBG;

		// Token: 0x04003803 RID: 14339
		public static int desertBG;

		// Token: 0x04003804 RID: 14340
		public static int oceanBG;

		// Token: 0x04003805 RID: 14341
		public static int mushroomBG;

		// Token: 0x04003806 RID: 14342
		public static int underworldBG;

		// Token: 0x04003807 RID: 14343
		public static readonly int oceanDistance;

		// Token: 0x04003808 RID: 14344
		public static readonly int beachDistance;

		// Token: 0x04003809 RID: 14345
		public static readonly int shimmerSafetyDistance;

		// Token: 0x0400380A RID: 14346
		public static bool crimson;

		// Token: 0x0400380B RID: 14347
		public static int[] tileCounts;

		// Token: 0x0400380C RID: 14348
		public static int totalEvil;

		// Token: 0x0400380D RID: 14349
		public static int totalBlood;

		// Token: 0x0400380E RID: 14350
		public static int totalGood;

		// Token: 0x0400380F RID: 14351
		public static int totalSolid;

		// Token: 0x04003810 RID: 14352
		public static int totalEvil2;

		// Token: 0x04003811 RID: 14353
		public static int totalBlood2;

		// Token: 0x04003812 RID: 14354
		public static int totalGood2;

		// Token: 0x04003813 RID: 14355
		public static int totalSolid2;

		// Token: 0x04003814 RID: 14356
		public static byte tEvil;

		// Token: 0x04003815 RID: 14357
		public static byte tBlood;

		// Token: 0x04003816 RID: 14358
		public static byte tGood;

		// Token: 0x04003817 RID: 14359
		public static string currentWorldSeed;

		// Token: 0x04003818 RID: 14360
		public static int totalX;

		// Token: 0x04003819 RID: 14361
		public static int totalD;

		// Token: 0x0400381A RID: 14362
		public static bool IsGeneratingHardMode;

		// Token: 0x0400381B RID: 14363
		public static int HardModeProgress;

		// Token: 0x0400381C RID: 14364
		public static bool noTileActions;

		// Token: 0x0400381D RID: 14365
		public static bool spawnEye;

		// Token: 0x0400381E RID: 14366
		public static int spawnHardBoss;

		// Token: 0x0400381F RID: 14367
		public static bool gen;

		// Token: 0x04003820 RID: 14368
		public static bool shadowOrbSmashed;

		// Token: 0x04003821 RID: 14369
		public static int shadowOrbCount;

		// Token: 0x04003822 RID: 14370
		public static int altarCount;

		// Token: 0x04003823 RID: 14371
		public static bool spawnMeteor;

		// Token: 0x04003824 RID: 14372
		public static bool loadFailed;

		// Token: 0x04003825 RID: 14373
		public static bool loadSuccess;

		// Token: 0x04003826 RID: 14374
		public static bool worldCleared;

		// Token: 0x04003827 RID: 14375
		public static bool worldBackup;

		// Token: 0x04003828 RID: 14376
		public static bool loadBackup;

		// Token: 0x04003829 RID: 14377
		private static int lastMaxTilesX;

		// Token: 0x0400382A RID: 14378
		private static int lastMaxTilesY;

		// Token: 0x0400382B RID: 14379
		private static bool mergeUp;

		// Token: 0x0400382C RID: 14380
		private static bool mergeDown;

		// Token: 0x0400382D RID: 14381
		private static bool mergeLeft;

		// Token: 0x0400382E RID: 14382
		private static bool mergeRight;

		// Token: 0x0400382F RID: 14383
		private static bool stopDrops;

		// Token: 0x04003830 RID: 14384
		public static bool noLiquidCheck;

		// Token: 0x04003831 RID: 14385
		public static bool AllowedToSpreadInfections;

		// Token: 0x04003832 RID: 14386
		[ThreadStatic]
		public static UnifiedRandom _genRand;

		// Token: 0x04003833 RID: 14387
		[ThreadStatic]
		public static int _genRandSeed;

		// Token: 0x04003834 RID: 14388
		public static int _lastSeed;

		// Token: 0x04003835 RID: 14389
		public static string statusText;

		// Token: 0x04003836 RID: 14390
		public static bool destroyObject;

		// Token: 0x04003837 RID: 14391
		public static int spawnDelay;

		// Token: 0x04003838 RID: 14392
		public static int prioritizedTownNPCType;

		// Token: 0x04003839 RID: 14393
		public static int numTileCount;

		// Token: 0x0400383A RID: 14394
		public static int maxTileCount;

		// Token: 0x0400383B RID: 14395
		public static int maxWallOut2;

		// Token: 0x0400383C RID: 14396
		public static int lavaCount;

		// Token: 0x0400383D RID: 14397
		public static int iceCount;

		// Token: 0x0400383E RID: 14398
		public static int sandCount;

		// Token: 0x0400383F RID: 14399
		public static int rockCount;

		// Token: 0x04003840 RID: 14400
		public static int shroomCount;

		// Token: 0x04003841 RID: 14401
		public static int maxRoomTiles;

		// Token: 0x04003842 RID: 14402
		public static int numRoomTiles;

		// Token: 0x04003843 RID: 14403
		public static int[] roomX;

		// Token: 0x04003844 RID: 14404
		public static int[] roomY;

		// Token: 0x04003845 RID: 14405
		public static int roomCeilingsCount;

		// Token: 0x04003846 RID: 14406
		public static int[] roomCeilingX;

		// Token: 0x04003847 RID: 14407
		public static int[] roomCeilingY;

		// Token: 0x04003848 RID: 14408
		public static int roomX1;

		// Token: 0x04003849 RID: 14409
		public static int roomX2;

		// Token: 0x0400384A RID: 14410
		public static int roomY1;

		// Token: 0x0400384B RID: 14411
		public static int roomY2;

		// Token: 0x0400384C RID: 14412
		public static bool canSpawn;

		// Token: 0x0400384D RID: 14413
		public static bool[] houseTile;

		// Token: 0x0400384E RID: 14414
		public static int bestX;

		// Token: 0x0400384F RID: 14415
		public static int bestY;

		// Token: 0x04003850 RID: 14416
		public static int hiScore;

		// Token: 0x04003851 RID: 14417
		private static bool roomTorch;

		// Token: 0x04003852 RID: 14418
		private static bool roomDoor;

		// Token: 0x04003853 RID: 14419
		private static bool roomChair;

		// Token: 0x04003854 RID: 14420
		private static bool roomTable;

		// Token: 0x04003855 RID: 14421
		private static bool roomOccupied;

		// Token: 0x04003856 RID: 14422
		private static bool roomEvil;

		// Token: 0x04003857 RID: 14423
		private static bool roomHasStinkbug;

		// Token: 0x04003858 RID: 14424
		private static bool roomHasEchoStinkbug;

		// Token: 0x04003859 RID: 14425
		public static int WorldGenParam_Evil;

		// Token: 0x0400385A RID: 14426
		public static readonly int cactusWaterWidth;

		// Token: 0x0400385B RID: 14427
		public static readonly int cactusWaterHeight;

		// Token: 0x0400385C RID: 14428
		public static readonly int cactusWaterLimit;

		// Token: 0x0400385D RID: 14429
		public static MysticLogFairiesEvent mysticLogsEvent;

		// Token: 0x0400385E RID: 14430
		private static bool currentlyTryingToUseAlternateHousingSpot;

		// Token: 0x0400385F RID: 14431
		private static int sharedRoomX;

		// Token: 0x04003860 RID: 14432
		public static TownNPCRoomCheckFailureReason roomCheckFailureReason;

		// Token: 0x04003861 RID: 14433
		public const int WorldSizeSmallX = 4200;

		// Token: 0x04003862 RID: 14434
		public const int WorldSizeSmallY = 1200;

		// Token: 0x04003863 RID: 14435
		public const int WorldSizeMediumX = 6400;

		// Token: 0x04003864 RID: 14436
		public const int WorldSizeMediumY = 1800;

		// Token: 0x04003865 RID: 14437
		public const int WorldSizeLargeX = 8400;

		// Token: 0x04003866 RID: 14438
		public const int WorldSizeLargeY = 2400;

		// Token: 0x04003867 RID: 14439
		public const int InfectionAndGrassSpreadOuterWorldBuffer = 10;

		// Token: 0x04003868 RID: 14440
		public static bool generatingWorld;

		// Token: 0x04003869 RID: 14441
		public static ManagedThread worldGenThread;

		// Token: 0x0400386A RID: 14442
		public static bool SavingSettings;

		// Token: 0x0400386B RID: 14443
		public static bool SavingPlayer;

		// Token: 0x0400386C RID: 14444
		private static int[,] trapDiag;

		// Token: 0x0400386D RID: 14445
		public static List<WorldGen.nextCountNode> _countOpenNodes;

		// Token: 0x0400386E RID: 14446
		public static List<WorldGen.nextCountNode> _countAvailableNodes;

		// Token: 0x0400386F RID: 14447
		private static List<WorldGen.nextCountDirtNode> _dirtCountOpenNodes;

		// Token: 0x04003870 RID: 14448
		private static List<WorldGen.nextCountDirtNode> _dirtCountAvailableNodes;

		// Token: 0x04003871 RID: 14449
		private static bool[] gem;

		// Token: 0x04003872 RID: 14450
		private static int[] mossType;

		// Token: 0x04003873 RID: 14451
		private static ushort neonMossType;

		// Token: 0x04003874 RID: 14452
		private static int tileCounterNum;

		// Token: 0x04003875 RID: 14453
		private static int tileCounterMax;

		// Token: 0x04003876 RID: 14454
		private static int[] tileCounterX;

		// Token: 0x04003877 RID: 14455
		private static int[] tileCounterY;

		// Token: 0x04003878 RID: 14456
		public static ushort lastTileCounterSearch;

		// Token: 0x04003879 RID: 14457
		private static WorldGenerator _generator;

		// Token: 0x0400387A RID: 14458
		public static int SmallConsecutivesFound;

		// Token: 0x0400387B RID: 14459
		public static int SmallConsecutivesEliminated;

		// Token: 0x0400387C RID: 14460
		public static bool tempRemixWorldGen;

		// Token: 0x0400387D RID: 14461
		public static bool remixWorldGen;

		// Token: 0x0400387E RID: 14462
		public static bool everythingWorldGen;

		// Token: 0x0400387F RID: 14463
		public static bool noTrapsWorldGen;

		// Token: 0x04003880 RID: 14464
		public static bool drunkWorldGen;

		// Token: 0x04003881 RID: 14465
		public static bool getGoodWorldGen;

		// Token: 0x04003882 RID: 14466
		public static bool tempTenthAnniversaryWorldGen;

		// Token: 0x04003883 RID: 14467
		public static bool tenthAnniversaryWorldGen;

		// Token: 0x04003884 RID: 14468
		public static bool dontStarveWorldGen;

		// Token: 0x04003885 RID: 14469
		public static bool notTheBees;

		// Token: 0x04003886 RID: 14470
		public static bool drunkWorldGenText;

		// Token: 0x04003887 RID: 14471
		public static bool placingTraps;

		// Token: 0x04003888 RID: 14472
		public const bool USE_FRAMING_SKIP_FOR_UNIMPORTANT_TILES_IN_WORLDGEN = false;

		// Token: 0x04003889 RID: 14473
		private const int ItemSpawnProtectionTime = 18000;

		// Token: 0x0400388A RID: 14474
		public static Thread ConversionThread;

		// Token: 0x0400388B RID: 14475
		private static List<Point> ShimmerTiles;

		// Token: 0x0400388C RID: 14476
		private static List<Color> _coatingColors;

		// Token: 0x0400388D RID: 14477
		private static int catTailDistance;

		// Token: 0x0400388E RID: 14478
		public static TreeTopsInfo TreeTops;

		// Token: 0x0400388F RID: 14479
		public static BackgroundChangeFlashInfo BackgroundsCache;

		// Token: 0x04003890 RID: 14480
		private static int maxTreeShakes;

		// Token: 0x04003891 RID: 14481
		private static int numTreeShakes;

		// Token: 0x04003892 RID: 14482
		private static int[] treeShakeX;

		// Token: 0x04003893 RID: 14483
		private static int[] treeShakeY;

		// Token: 0x04003894 RID: 14484
		private static bool fossilBreak;

		// Token: 0x04003895 RID: 14485
		public static Queue<Point> ExploitDestroyQueue;

		// Token: 0x04003896 RID: 14486
		private static int _lastFrame;

		// Token: 0x04003897 RID: 14487
		private static bool growGrassUnderground;

		// Token: 0x04003898 RID: 14488
		public const bool BUBBLES_SOLID_STATE_FOR_HOUSING = true;

		// Token: 0x04003899 RID: 14489
		public static int grassSpread;

		// Token: 0x0400389A RID: 14490
		private static Point[] heartPos;

		// Token: 0x0400389B RID: 14491
		private static int heartCount;

		// Token: 0x0400389C RID: 14492
		private static object WaitingLock;

		// Token: 0x0400389D RID: 14493
		private static bool ThreadWaiting;

		// Token: 0x0400389E RID: 14494
		private static bool ThreadRunning;

		// Token: 0x0400389F RID: 14495
		private static DateTime ThreadStarted;

		// Token: 0x040038A0 RID: 14496
		private static bool threadInProgress;

		// Token: 0x040038A1 RID: 14497
		private const int strip_w = 200;

		// Token: 0x040038A2 RID: 14498
		private const int strip_h = 50;

		// Token: 0x040038A3 RID: 14499
		private static readonly Vertical64BitStrips bitStrip;

		// Token: 0x040038A4 RID: 14500
		public static bool noMapUpdateRefresh;

		// Token: 0x040038A5 RID: 14501
		private const int MaxCachedUpdates = 20000;

		// Token: 0x040038A6 RID: 14502
		private static uint[] CachedMapTileUpdates;

		// Token: 0x040038A7 RID: 14503
		private static int CachedMapTileUpdateCount;

		// Token: 0x040038A8 RID: 14504
		private static bool skipFramingDuringGen;

		// Token: 0x040038A9 RID: 14505
		public static bool LogFrames;

		// Token: 0x040038AA RID: 14506
		private static int currentStack;

		// Token: 0x040038AB RID: 14507
		private static int maxStack;

		// Token: 0x040038AC RID: 14508
		private static Rectangle fallingBlockRegion;

		// Token: 0x040038AD RID: 14509
		private static int maxCount;

		// Token: 0x02000472 RID: 1138
		public static class WorldSize
		{
			// Token: 0x040038AE RID: 14510
			public const int Small = 0;

			// Token: 0x040038AF RID: 14511
			public const int Medium = 1;

			// Token: 0x040038B0 RID: 14512
			public const int Large = 2;
		}

		// Token: 0x02000473 RID: 1139
		public static class SavedOreTiers
		{
			// Token: 0x06002EDA RID: 11994 RVA: 0x001E729C File Offset: 0x001E549C
			// Note: this type is marked as 'beforefieldinit'.
			static SavedOreTiers()
			{
			}

			// Token: 0x040038B1 RID: 14513
			public static int Copper;

			// Token: 0x040038B2 RID: 14514
			public static int Iron;

			// Token: 0x040038B3 RID: 14515
			public static int Silver;

			// Token: 0x040038B4 RID: 14516
			public static int Gold;

			// Token: 0x040038B5 RID: 14517
			public static int Cobalt;

			// Token: 0x040038B6 RID: 14518
			public static int Mythril;

			// Token: 0x040038B7 RID: 14519
			public static int Adamantite;
		}

		// Token: 0x02000474 RID: 1140
		public static class Hooks
		{
			// Token: 0x1400002C RID: 44
			// (add) Token: 0x06002EDB RID: 11995 RVA: 0x001E72AC File Offset: 0x001E54AC
			// (remove) Token: 0x06002EDC RID: 11996 RVA: 0x001E72C4 File Offset: 0x001E54C4
			public static event WorldGen.Hooks.WorldGenConfigProcessEvent OnWorldGenConfigProcess
			{
				[CompilerGenerated]
				add
				{
					Delegate @delegate;
					if (@delegate != null)
					{
					}
				}
				[CompilerGenerated]
				remove
				{
					Delegate @delegate;
					if (@delegate != null)
					{
					}
				}
			}

			// Token: 0x1400002D RID: 45
			// (add) Token: 0x06002EDD RID: 11997 RVA: 0x001E72DC File Offset: 0x001E54DC
			// (remove) Token: 0x06002EDE RID: 11998 RVA: 0x001E72F4 File Offset: 0x001E54F4
			public static event Action OnWorldLoad
			{
				[CompilerGenerated]
				add
				{
					Delegate @delegate;
					if (@delegate != null)
					{
					}
				}
				[CompilerGenerated]
				remove
				{
					Delegate @delegate;
					if (@delegate != null)
					{
					}
				}
			}

			// Token: 0x06002EDF RID: 11999 RVA: 0x001E730C File Offset: 0x001E550C
			public static void Initialize()
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
			}

			// Token: 0x06002EE0 RID: 12000 RVA: 0x001E7324 File Offset: 0x001E5524
			public static void WorldLoaded()
			{
			}

			// Token: 0x06002EE1 RID: 12001 RVA: 0x001E7334 File Offset: 0x001E5534
			public static void ProcessWorldGenConfig(WorldGenConfiguration config)
			{
			}

			// Token: 0x040038B8 RID: 14520
			[CompilerGenerated]
			private static WorldGen.Hooks.WorldGenConfigProcessEvent OnWorldGenConfigProcess;

			// Token: 0x040038B9 RID: 14521
			[CompilerGenerated]
			private static Action OnWorldLoad;

			// Token: 0x02000475 RID: 1141
			// (Invoke) Token: 0x06002EE3 RID: 12003
			public delegate void WorldGenConfigProcessEvent(WorldGenConfiguration config);

			// Token: 0x02000476 RID: 1142
			[CompilerGenerated]
			[Serializable]
			private sealed class <>c
			{
				// Token: 0x06002EE6 RID: 12006 RVA: 0x00003BB6 File Offset: 0x00001DB6
				// Note: this type is marked as 'beforefieldinit'.
				static <>c()
				{
				}

				// Token: 0x06002EE7 RID: 12007 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public <>c()
				{
				}

				// Token: 0x06002EE8 RID: 12008 RVA: 0x00003BB6 File Offset: 0x00001DB6
				internal void <Initialize>b__7_0(Player player)
				{
				}

				// Token: 0x040038BA RID: 14522
				public static readonly WorldGen.Hooks.<>c <>9;

				// Token: 0x040038BB RID: 14523
				public static Action<Player> <>9__7_0;
			}
		}

		// Token: 0x02000477 RID: 1143
		public static class Spread
		{
			// Token: 0x06002EE9 RID: 12009 RVA: 0x001E7344 File Offset: 0x001E5544
			public static void Wall(int x, int y, int wallType)
			{
				int num = 1;
				if (num == 0)
				{
				}
				long num2 = 0L;
				bool flag = WorldGen.InWorld(x, y, (int)num2);
				if (num == 0)
				{
				}
				Tile.StartNewSearch();
				if (num == 0)
				{
				}
			}

			// Token: 0x06002EEA RID: 12010 RVA: 0x001E73E0 File Offset: 0x001E55E0
			public static void Wall2(int x, int y, int wallType)
			{
				if (!true)
				{
				}
				long num = 0L;
				bool flag = WorldGen.InWorld(x, y, (int)num);
				Tile.StartNewSearch();
			}

			// Token: 0x06002EEB RID: 12011 RVA: 0x001E74DC File Offset: 0x001E56DC
			public static void Moss(int x, int y)
			{
				int num = 1;
				if (num == 0)
				{
				}
				long num2 = 0L;
				bool flag = WorldGen.InWorld(x, y, (int)num2);
				if (num == 0)
				{
				}
			}

			// Token: 0x06002EEC RID: 12012 RVA: 0x001E7524 File Offset: 0x001E5724
			public static void Gem(int x, int y)
			{
				if (!true)
				{
				}
				long num = 0L;
				bool flag = WorldGen.InWorld(x, y, (int)num);
			}

			// Token: 0x06002EED RID: 12013 RVA: 0x001E7608 File Offset: 0x001E5808
			public static void Spider(int x, int y)
			{
			}

			// Token: 0x06002EEE RID: 12014 RVA: 0x001E7804 File Offset: 0x001E5A04
			public static void WallDungeon(int x, int y, int wallType)
			{
				if (!true)
				{
				}
				long num = 0L;
				bool flag = WorldGen.InWorld(x, y, (int)num);
			}

			// Token: 0x06002EEF RID: 12015 RVA: 0x001E7848 File Offset: 0x001E5A48
			private static bool Gemmable(int type)
			{
			}
		}

		// Token: 0x02000478 RID: 1144
		public struct PendingRefame
		{
			// Token: 0x040038BC RID: 14524
			public int x;

			// Token: 0x040038BD RID: 14525
			public int y;

			// Token: 0x040038BE RID: 14526
			public bool resetFrame;

			// Token: 0x040038BF RID: 14527
			public bool noBreak;

			// Token: 0x040038C0 RID: 14528
			public int reframeCount;
		}

		// Token: 0x02000479 RID: 1145
		public class nextCountNode
		{
			// Token: 0x06002EF0 RID: 12016 RVA: 0x001E7858 File Offset: 0x001E5A58
			public void Setup(int x, int y, bool jungle, bool lavaOk)
			{
				this.x = x;
				this.jungle = y != 0;
			}

			// Token: 0x06002EF1 RID: 12017 RVA: 0x001E7874 File Offset: 0x001E5A74
			public nextCountNode()
			{
			}

			// Token: 0x040038C1 RID: 14529
			public int x;

			// Token: 0x040038C2 RID: 14530
			public int y;

			// Token: 0x040038C3 RID: 14531
			public bool jungle;

			// Token: 0x040038C4 RID: 14532
			public bool lavaOk;
		}

		// Token: 0x0200047A RID: 1146
		internal class nextCountDirtNode
		{
			// Token: 0x06002EF2 RID: 12018 RVA: 0x001E7888 File Offset: 0x001E5A88
			public void Setup(int x, int y)
			{
				this.x = x;
			}

			// Token: 0x06002EF3 RID: 12019 RVA: 0x001E789C File Offset: 0x001E5A9C
			public nextCountDirtNode()
			{
			}

			// Token: 0x040038C5 RID: 14533
			public int x;

			// Token: 0x040038C6 RID: 14534
			public int y;
		}

		// Token: 0x0200047B RID: 1147
		public static class TenthAnniversaryWorldInfo
		{
			// Token: 0x06002EF4 RID: 12020 RVA: 0x001E78B0 File Offset: 0x001E5AB0
			// Note: this type is marked as 'beforefieldinit'.
			static TenthAnniversaryWorldInfo()
			{
			}

			// Token: 0x040038C7 RID: 14535
			public static int[] GoodPrefixIdsForAccessory;

			// Token: 0x040038C8 RID: 14536
			public static int[] GoodPrefixIdsForMeleeWeapon;

			// Token: 0x040038C9 RID: 14537
			public static int[] GoodPrefixIdsForRangedWeapon;

			// Token: 0x040038CA RID: 14538
			public static int[] GoodPrefixIdsForMagicWeapon;

			// Token: 0x040038CB RID: 14539
			public static int[] GoodPrefixIdsForSummonerWeapon;
		}

		// Token: 0x0200047C RID: 1148
		public struct GrowTreeSettings
		{
			// Token: 0x040038CC RID: 14540
			public ushort TreeTileType;

			// Token: 0x040038CD RID: 14541
			public int TreeHeightMin;

			// Token: 0x040038CE RID: 14542
			public int TreeHeightMax;

			// Token: 0x040038CF RID: 14543
			public int TreeTopPaddingNeeded;

			// Token: 0x040038D0 RID: 14544
			public WorldGen.GrowTreeSettings.IsTileFitForTreeGroundTest GroundTest;

			// Token: 0x040038D1 RID: 14545
			public WorldGen.GrowTreeSettings.IsWallTypeFitForTreeBack WallTest;

			// Token: 0x040038D2 RID: 14546
			public ushort SaplingTileType;

			// Token: 0x0200047D RID: 1149
			// (Invoke) Token: 0x06002EF6 RID: 12022
			public delegate bool IsTileFitForTreeGroundTest(int tileType);

			// Token: 0x0200047E RID: 1150
			// (Invoke) Token: 0x06002EFA RID: 12026
			public delegate bool IsWallTypeFitForTreeBack(int wallType);

			// Token: 0x0200047F RID: 1151
			public static class Profiles
			{
				// Token: 0x06002EFD RID: 12029 RVA: 0x001E78C0 File Offset: 0x001E5AC0
				public static bool TryGetFromItemId(int itemType, [Out] WorldGen.GrowTreeSettings profile)
				{
					return default(bool);
				}

				// Token: 0x06002EFE RID: 12030 RVA: 0x001E78D8 File Offset: 0x001E5AD8
				public static bool TryGetFromTreeId(int tileType, [Out] WorldGen.GrowTreeSettings profile)
				{
					return default(bool);
				}

				// Token: 0x06002EFF RID: 12031 RVA: 0x00003BB6 File Offset: 0x00001DB6
				// Note: this type is marked as 'beforefieldinit'.
				static Profiles()
				{
				}

				// Token: 0x040038D3 RID: 14547
				public static WorldGen.GrowTreeSettings GemTree_Ruby;

				// Token: 0x040038D4 RID: 14548
				public static WorldGen.GrowTreeSettings GemTree_Diamond;

				// Token: 0x040038D5 RID: 14549
				public static WorldGen.GrowTreeSettings GemTree_Topaz;

				// Token: 0x040038D6 RID: 14550
				public static WorldGen.GrowTreeSettings GemTree_Amethyst;

				// Token: 0x040038D7 RID: 14551
				public static WorldGen.GrowTreeSettings GemTree_Sappphire;

				// Token: 0x040038D8 RID: 14552
				public static WorldGen.GrowTreeSettings GemTree_Emerald;

				// Token: 0x040038D9 RID: 14553
				public static WorldGen.GrowTreeSettings GemTree_Amber;

				// Token: 0x040038DA RID: 14554
				public static WorldGen.GrowTreeSettings VanityTree_Sakura;

				// Token: 0x040038DB RID: 14555
				public static WorldGen.GrowTreeSettings VanityTree_Willow;

				// Token: 0x040038DC RID: 14556
				public static WorldGen.GrowTreeSettings Tree_Ash;
			}
		}

		// Token: 0x02000480 RID: 1152
		public struct CheckTreeSettings
		{
			// Token: 0x040038DD RID: 14557
			public WorldGen.CheckTreeSettings.GroundValidTest IsGroundValid;

			// Token: 0x02000481 RID: 1153
			// (Invoke) Token: 0x06002F01 RID: 12033
			public delegate bool GroundValidTest(int groundTileType);
		}

		// Token: 0x02000482 RID: 1154
		public enum SpecialKillTileContext
		{
			// Token: 0x040038DF RID: 14559
			None,
			// Token: 0x040038E0 RID: 14560
			MowingTheGrass
		}

		// Token: 0x02000483 RID: 1155
		public sealed class GetTreeFoliageDataMethod : MulticastDelegate
		{
			// Token: 0x06002F04 RID: 12036 RVA: 0x001E78F0 File Offset: 0x001E5AF0
			public GetTreeFoliageDataMethod(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06002F05 RID: 12037 RVA: 0x001E7944 File Offset: 0x001E5B44
			public bool Invoke(int i, int j, int xoffset, int treeFrame, int treeStyle, [Out] int floorY, [Out] int topTextureFrameWidth, [Out] int topTextureFrameHeight)
			{
				/*
An exception occurred when decompiling this method (06002F05)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldGen/GetTreeFoliageDataMethod::Invoke(System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:native int(var_0_06, ldfld:native int(Delegate::invoke_impl, ldloc:GetTreeFoliageDataMethod[exp:Delegate](this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::method, ldloc:GetTreeFoliageDataMethod[exp:Delegate](this)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method_code, ldloc:GetTreeFoliageDataMethod[exp:Delegate](this)))
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

			// Token: 0x06002F06 RID: 12038 RVA: 0x000021DB File Offset: 0x000003DB
			public IAsyncResult BeginInvoke(int i, int j, int xoffset, int treeFrame, int treeStyle, [Out] int floorY, [Out] int topTextureFrameWidth, [Out] int topTextureFrameHeight, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06002F07 RID: 12039 RVA: 0x000021DB File Offset: 0x000003DB
			public bool EndInvoke(int treeFrame, int treeStyle, [Out] int floorY, [Out] int topTextureFrameWidth, [Out] int topTextureFrameHeight, IAsyncResult result)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x02000484 RID: 1156
		public struct TileMergeCullCache
		{
			// Token: 0x06002F08 RID: 12040 RVA: 0x001E7968 File Offset: 0x001E5B68
			public void Cull(int up, int down, int left, int right, int upLeft, int upRight, int downLeft, int downRight)
			{
				bool cullBottom = this.CullBottom;
				if (cullBottom)
				{
					down.m_value = (cullBottom ? 1 : 0);
				}
				bool cullLeft = this.CullLeft;
				if (cullLeft)
				{
					left.m_value = (cullLeft ? 1 : 0);
				}
				bool cullRight = this.CullRight;
				if (cullRight)
				{
					right.m_value = (cullRight ? 1 : 0);
				}
				bool cullTopLeft = this.CullTopLeft;
				if (cullTopLeft)
				{
					upLeft.m_value = (cullTopLeft ? 1 : 0);
				}
				bool cullTopRight = this.CullTopRight;
				if (cullTopRight)
				{
					upRight.m_value = (cullTopRight ? 1 : 0);
				}
				bool cullBottomLeft = this.CullBottomLeft;
				if (cullBottomLeft)
				{
					downLeft.m_value = (cullBottomLeft ? 1 : 0);
				}
				if (this.CullBottomRight)
				{
				}
			}

			// Token: 0x040038E1 RID: 14561
			public bool CullTop;

			// Token: 0x040038E2 RID: 14562
			public bool CullBottom;

			// Token: 0x040038E3 RID: 14563
			public bool CullLeft;

			// Token: 0x040038E4 RID: 14564
			public bool CullRight;

			// Token: 0x040038E5 RID: 14565
			public bool CullTopLeft;

			// Token: 0x040038E6 RID: 14566
			public bool CullTopRight;

			// Token: 0x040038E7 RID: 14567
			public bool CullBottomLeft;

			// Token: 0x040038E8 RID: 14568
			public bool CullBottomRight;
		}

		// Token: 0x02000485 RID: 1157
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <>c__DisplayClass277_0
		{
			// Token: 0x040038E9 RID: 14569
			public int Main_maxTilesX;

			// Token: 0x040038EA RID: 14570
			public unsafe uint* TileData_tileLookupPtr;

			// Token: 0x040038EB RID: 14571
			public unsafe short* TileData_TileSHeader;

			// Token: 0x040038EC RID: 14572
			public unsafe ushort* TileData_TileType;

			// Token: 0x040038ED RID: 14573
			public bool[] Main_tileSolid;

			// Token: 0x040038EE RID: 14574
			public bool[] Main_tileSolidTop;
		}

		// Token: 0x02000486 RID: 1158
		[CompilerGenerated]
		private sealed class <>c__DisplayClass277_1
		{
			// Token: 0x06002F09 RID: 12041 RVA: 0x001E79F0 File Offset: 0x001E5BF0
			public <>c__DisplayClass277_1()
			{
			}

			// Token: 0x06002F0A RID: 12042 RVA: 0x001E7A04 File Offset: 0x001E5C04
			internal bool <GenerateWorld>b__110(int x, int y, object[] args)
			{
				this.foundInvalidTile = true;
				return true;
			}

			// Token: 0x06002F0B RID: 12043 RVA: 0x001E7A1C File Offset: 0x001E5C1C
			internal bool <GenerateWorld>b__111(int x, int y, object[] args)
			{
				this.foundInvalidTile = true;
				return true;
			}

			// Token: 0x040038EF RID: 14575
			public bool foundInvalidTile;
		}

		// Token: 0x02000487 RID: 1159
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <>c__DisplayClass277_2
		{
			// Token: 0x040038F0 RID: 14576
			public unsafe uint* TileData_TileLookup;

			// Token: 0x040038F1 RID: 14577
			public int Main_maxTilesX;

			// Token: 0x040038F2 RID: 14578
			public unsafe short* TileData_TileSHeader;

			// Token: 0x040038F3 RID: 14579
			public unsafe short* TileData_TileFrameX;

			// Token: 0x040038F4 RID: 14580
			public unsafe ushort* TileData_TileType;

			// Token: 0x040038F5 RID: 14581
			public unsafe byte* TileData_TileBHeader;
		}

		// Token: 0x02000488 RID: 1160
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002F0C RID: 12044 RVA: 0x001E7A34 File Offset: 0x001E5C34
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06002F0D RID: 12045 RVA: 0x001E7A44 File Offset: 0x001E5C44
			public <>c()
			{
			}

			// Token: 0x06002F0E RID: 12046 RVA: 0x001E7A58 File Offset: 0x001E5C58
			internal void <GenerateWorld>b__277_0(GenerationProgress progress, GameConfiguration passConfig)
			{
				if (!true)
				{
				}
				UnifiedRandom genRand = WorldGen.genRand;
				int num = 2;
				int num2 = genRand.Next(num);
			}

			// Token: 0x06002F0F RID: 12047 RVA: 0x001E7E84 File Offset: 0x001E6084
			internal void <GenerateWorld>b__277_1(GenerationProgress progress, GameConfiguration passConfig)
			{
				if (!true)
				{
				}
				UnifiedRandom genRand = WorldGen.genRand;
				double num = passConfig.Get<double>("ChanceOfPyramid");
				if (32752 == 0)
				{
				}
				int num2 = 1;
				int num3 = 500;
				int num4 = 500;
				long num5 = 0L;
				long num6 = 0L;
				Point point = WorldGen.RandomWorldPoint((int)num5, num3, (int)num6, num4);
				if (num2 == 0)
				{
				}
				if (num2 == 0)
				{
				}
			}

			// Token: 0x06002F10 RID: 12048 RVA: 0x001E7F1C File Offset: 0x001E611C
			internal void <GenerateWorld>b__277_2(GenerationProgress progress, GameConfiguration passConfig)
			{
				string textValue = Language.GetTextValue("WorldGeneration.OceanSand");
				long num = 0L;
				long num2 = 0L;
				int num3 = WorldGen.genRand.Next((int)num2);
				UnifiedRandom genRand = WorldGen.genRand;
				int num4 = 35;
				int num5 = 90;
				int num6 = genRand.Next(num4, num5);
				UnifiedRandom genRand2 = WorldGen.genRand;
				int num7 = 20;
				int num8 = 40;
				int num9 = genRand2.Next(num7, num8);
				long num10 = 32752L;
				int num11 = 32768;
				if (num10 == 0L)
				{
				}
				UnifiedRandom genRand3 = WorldGen.genRand;
				int num12 = 3;
				int num13 = genRand3.Next(num12);
				if (num11 == 0)
				{
				}
				UnifiedRandom genRand4 = WorldGen.genRand;
				int num14 = 35;
				int num15 = 90;
				int num16 = genRand4.Next(num14, num15);
				UnifiedRandom genRand5 = WorldGen.genRand;
				int num17 = 3;
				int num18 = genRand5.Next(num17);
				if (num18 == 0)
				{
				}
				if (num11 != 0)
				{
					return;
				}
				if (num == 0L)
				{
					if (num18 == 0)
					{
					}
					return;
				}
				UnifiedRandom genRand6 = WorldGen.genRand;
				int num19 = 50;
				int num20 = 100;
				int num21 = genRand6.Next(num19, num20);
				UnifiedRandom genRand7 = WorldGen.genRand;
				int num22 = 2;
				int num25;
				if (genRand7.Next(num22) == 0)
				{
					UnifiedRandom genRand8 = WorldGen.genRand;
					int num23 = 2;
					int num24 = genRand8.Next(num22, num23);
					num25 = 200;
				}
				if (num25 == 0)
				{
				}
				Tile tile;
				bool flag = tile.active();
			}

			// Token: 0x06002F11 RID: 12049 RVA: 0x001E80E0 File Offset: 0x001E62E0
			internal void <GenerateWorld>b__277_3(GenerationProgress progress, GameConfiguration passConfig)
			{
				if (!true)
				{
				}
				UnifiedRandom genRand = WorldGen.genRand;
				UnifiedRandom genRand2 = WorldGen.genRand;
				UnifiedRandom genRand3 = WorldGen.genRand;
			}

			// Token: 0x06002F12 RID: 12050 RVA: 0x001E8168 File Offset: 0x001E6368
			internal void <GenerateWorld>b__277_4(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				int num2 = 32768;
				if (num != 0)
				{
				}
				UnifiedRandom genRand = WorldGen.genRand;
				if (num2 == 0)
				{
					if (num2 == 0)
					{
					}
					UnifiedRandom genRand2 = WorldGen.genRand;
					return;
				}
				Tile tile;
				bool flag = tile.active();
			}

			// Token: 0x06002F13 RID: 12051 RVA: 0x001E8294 File Offset: 0x001E6494
			internal void <GenerateWorld>b__277_5(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				long num2 = 0L;
				if (num == 0)
				{
				}
				long num3;
				if (num != 0)
				{
					num3 = 32752L;
				}
				long num4 = 0L;
				if (num3 == 0L)
				{
				}
				int num5 = WorldGen.genRand.Next((int)num4, (int)num2);
			}

			// Token: 0x06002F14 RID: 12052 RVA: 0x001E8348 File Offset: 0x001E6548
			internal void <GenerateWorld>b__277_6(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				long num2 = 0L;
				UnifiedRandom genRand = WorldGen.genRand;
				int num3 = 2;
				int num4 = genRand.Next((int)num2, num3);
				int num5 = 10;
				if (num5 == 0)
				{
				}
				if (num5 == 0)
				{
				}
				Tile tile;
				bool flag = tile.active();
				Tile tile2;
				bool flag2 = tile2.active();
				Tile tile3;
				bool flag3 = tile3.active();
				Tile tile4;
				bool flag4 = tile4.active();
				Tile tile5;
				bool flag5 = tile5.active();
				Tile tile6;
				bool flag6 = tile6.active();
			}

			// Token: 0x06002F15 RID: 12053 RVA: 0x001E83D8 File Offset: 0x001E65D8
			internal void <GenerateWorld>b__277_7(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				long num2 = 0L;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				UnifiedRandom genRand = WorldGen.genRand;
				long num3 = 0L;
				int num4 = genRand.Next((int)num3, (int)num2);
				UnifiedRandom genRand2 = WorldGen.genRand;
				long num5 = 0L;
				int num6 = genRand2.Next((int)num5, (int)num2);
				UnifiedRandom genRand3 = WorldGen.genRand;
				int num7 = 4;
				int num8 = 15;
				int num9 = genRand3.Next(num7, num8);
				UnifiedRandom genRand4 = WorldGen.genRand;
				int num10 = 5;
				int num11 = 40;
				int num12 = genRand4.Next(num10, num11);
				progress.Set(0.34);
				UnifiedRandom genRand5 = WorldGen.genRand;
				long num13 = 0L;
				int num14 = genRand5.Next((int)num13, num12);
				int num15 = WorldGen.genRand.Next((int)num13, num12);
				long num16 = 0L;
				Tile tile;
				bool flag = tile.active();
				int num17 = WorldGen.genRand.Next((int)num16, num12);
				UnifiedRandom genRand6 = WorldGen.genRand;
				int num18 = 4;
				int num19 = 10;
				int num20 = genRand6.Next(num18, num19);
				UnifiedRandom genRand7 = WorldGen.genRand;
				int num21 = 5;
				int num22 = 30;
				int num23 = genRand7.Next(num21, num22);
				progress.Set(0.67);
				UnifiedRandom genRand8 = WorldGen.genRand;
				long num24 = 0L;
				int num25 = genRand8.Next((int)num24, num23);
				int num26 = WorldGen.genRand.Next((int)num24, num23);
				UnifiedRandom genRand9 = WorldGen.genRand;
				int num27 = 2;
				int num28 = 7;
				int num29 = genRand9.Next(num27, num28);
				UnifiedRandom genRand10 = WorldGen.genRand;
				int num30 = 2;
				int num31 = 23;
				int num32 = genRand10.Next(num30, num31);
			}

			// Token: 0x06002F16 RID: 12054 RVA: 0x001E856C File Offset: 0x001E676C
			internal void <GenerateWorld>b__277_8(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				long num2 = 0L;
				if (num == 0)
				{
				}
				progress.Set(0.005);
				if (num == 0)
				{
				}
				UnifiedRandom genRand = WorldGen.genRand;
				long num3 = 0L;
				int num4 = genRand.Next((int)num3, (int)num2);
				int num5 = WorldGen.genRand.Next((int)num3, (int)num2);
				UnifiedRandom genRand2 = WorldGen.genRand;
				int num6 = 2;
				int num7 = 6;
				int num8 = genRand2.Next(num6, num7);
				UnifiedRandom genRand3 = WorldGen.genRand;
				int num9 = 2;
				int num10 = 40;
				int num11 = genRand3.Next(num9, num10);
				UnifiedRandom genRand4 = WorldGen.genRand;
				int num12 = 3;
				int num13 = genRand4.Next(num5, num12);
				Tile tile;
				bool flag = tile.active();
			}

			// Token: 0x06002F17 RID: 12055 RVA: 0x001E8624 File Offset: 0x001E6824
			internal void <GenerateWorld>b__277_9(GenerationProgress progress, GameConfiguration passConfig)
			{
				if (!true)
				{
				}
				long num = 0L;
				UnifiedRandom genRand = WorldGen.genRand;
				long num2 = 0L;
				int num3 = genRand.Next((int)num2, (int)num);
				UnifiedRandom genRand2 = WorldGen.genRand;
				long num4 = 0L;
				int num5 = genRand2.Next((int)num4, (int)num);
				UnifiedRandom genRand3 = WorldGen.genRand;
				int num6 = 4;
				int num7 = 14;
				int num8 = genRand3.Next(num6, num7);
				UnifiedRandom genRand4 = WorldGen.genRand;
				int num9 = 10;
				int num10 = 50;
				int num11 = genRand4.Next(num9, num10);
			}

			// Token: 0x06002F18 RID: 12056 RVA: 0x001E8818 File Offset: 0x001E6A18
			internal void <GenerateWorld>b__277_10(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
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
				UnifiedRandom genRand = WorldGen.genRand;
				int num2 = 5;
				long num3 = 0L;
				int num4 = genRand.Next(num2);
				UnifiedRandom genRand2 = WorldGen.genRand;
				long num5 = 0L;
				int num6 = genRand2.Next((int)num5, (int)num3);
				int num7 = WorldGen.genRand.Next((int)num5, (int)num3);
				UnifiedRandom genRand3 = WorldGen.genRand;
				long num8 = 0L;
				int num9 = genRand3.Next((int)num8, (int)num3);
				int num10 = WorldGen.genRand.Next((int)num8, (int)num3);
			}

			// Token: 0x06002F19 RID: 12057 RVA: 0x001E897C File Offset: 0x001E6B7C
			internal void <GenerateWorld>b__277_11(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				long num2 = 0L;
				progress.Set((double)num2);
				UnifiedRandom genRand = WorldGen.genRand;
				int num3 = 6;
				long num4 = 0L;
				int num5 = genRand.Next(num3);
				UnifiedRandom genRand2 = WorldGen.genRand;
				long num6 = 0L;
				int num7 = genRand2.Next((int)num6, (int)num4);
				int num8 = WorldGen.genRand.Next((int)num6, (int)num4);
				if (36700692 == 0)
				{
				}
				if (36700692 == 0)
				{
				}
				if (36700692 == 0)
				{
				}
				UnifiedRandom genRand3 = WorldGen.genRand;
				while (36700692 != 0)
				{
				}
			}

			// Token: 0x06002F1A RID: 12058 RVA: 0x001E8A54 File Offset: 0x001E6C54
			internal void <GenerateWorld>b__277_12(GenerationProgress progress, GameConfiguration passConfig)
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
				if (true)
				{
				}
				progress.Set(6.953355807835E-310);
				if (32768 == 0)
				{
				}
				int num = WorldGen.genRand.Next(10);
				int num2 = WorldGen.genRand.Next(6, 20);
				int num3 = WorldGen.genRand.Next(50, 300);
				UnifiedRandom genRand = WorldGen.genRand;
				long num4 = 0L;
				int num5 = genRand.Next((int)num4, 300);
				int num6 = WorldGen.genRand.Next((int)num4, 300);
				int num7 = WorldGen.genRand.Next(10);
				int num8 = WorldGen.genRand.Next(7, 26);
				int num9 = WorldGen.genRand.Next(50, 200);
				int num10 = WorldGen.genRand.Next(100, 221);
				int num11 = WorldGen.genRand.Next(100, 11);
				UnifiedRandom genRand2 = WorldGen.genRand;
				long num12 = 0L;
				int num13 = genRand2.Next((int)num12, 11);
				int num14 = WorldGen.genRand.Next((int)num12, 11);
			}

			// Token: 0x06002F1B RID: 12059 RVA: 0x001E8B78 File Offset: 0x001E6D78
			internal void <GenerateWorld>b__277_13(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				long num2 = 0L;
				if (num == 0)
				{
				}
				if (32752 == 0)
				{
				}
				if (num != 0)
				{
				}
				UnifiedRandom genRand = WorldGen.genRand;
				long num3 = 0L;
				int num4 = genRand.Next((int)num3, (int)num2);
			}

			// Token: 0x06002F1C RID: 12060 RVA: 0x001E8E8C File Offset: 0x001E708C
			internal void <GenerateWorld>b__277_14(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num == 0)
				{
					return;
				}
				string textValue = Language.GetTextValue("WorldGeneration.WavyCaves");
				long num2 = 0L;
				progress.Message = textValue;
				if ("WorldGeneration.WavyCaves" == null)
				{
				}
				int num3 = 32768;
				int num4 = 80;
				long num5 = 0L;
				progress.Set((double)num4);
				if ("WorldGeneration.WavyCaves" == null)
				{
				}
				UnifiedRandom genRand = WorldGen.genRand;
				if (num3 == 0)
				{
				}
				int num6 = 100;
				int underworldLayer = Main.UnderworldLayer;
				int num7 = genRand.Next((int)num5, (int)num2);
				if (num3 == 0)
				{
				}
				if (num6 != 0)
				{
					UnifiedRandom genRand2 = WorldGen.genRand;
					if (num3 == 0)
					{
					}
					return;
				}
				if (num3 == 0)
				{
				}
				UnifiedRandom genRand3 = WorldGen.genRand;
				int num8 = 3;
				int num9 = 6;
				int num10 = genRand3.Next(num8, num9);
				double num11 = WorldGen.genRand.NextDouble();
				UnifiedRandom genRand4 = WorldGen.genRand;
				int num12 = 300;
				int num13 = 500;
				int num14 = genRand4.Next(num12, num13);
			}

			// Token: 0x06002F1D RID: 12061 RVA: 0x001E8F80 File Offset: 0x001E7180
			internal void <GenerateWorld>b__277_15(GenerationProgress progress, GameConfiguration passConfig)
			{
				if (!true)
				{
				}
				int num = 32768;
				UnifiedRandom genRand = WorldGen.genRand;
				int num2 = 160;
				int num3 = 200;
				int num4 = genRand.Next(num2, num3);
				if (num != 0)
				{
					if (num == 0)
					{
					}
					UnifiedRandom genRand2 = WorldGen.genRand;
					int num5 = 160;
					int num6 = 200;
					int num7 = genRand2.Next(num5, num6);
					return;
				}
				if (num == 0)
				{
				}
				long num8 = 0L;
				UnifiedRandom genRand3 = WorldGen.genRand;
				int num9 = 4;
				int num10 = genRand3.Next((int)num8, num9);
				UnifiedRandom genRand4 = WorldGen.genRand;
				int num11 = 5;
				int num12 = genRand4.Next((int)num8, num11);
				if (num12 == 0)
				{
				}
				if (num12 == 0)
				{
				}
				UnifiedRandom genRand5 = WorldGen.genRand;
				int num13 = 4;
				if (genRand5.Next(num13) == 0)
				{
					return;
				}
				Tile tile;
				ushort wall = tile.wall;
				Tile tile2;
				ushort type = tile2.type;
			}

			// Token: 0x06002F1E RID: 12062 RVA: 0x001E9154 File Offset: 0x001E7354
			internal void <GenerateWorld>b__277_16(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				progress.Set(0.002);
				if (num == 0)
				{
				}
				UnifiedRandom genRand = WorldGen.genRand;
				UnifiedRandom genRand2 = WorldGen.genRand;
			}

			// Token: 0x06002F1F RID: 12063 RVA: 0x001E9298 File Offset: 0x001E7498
			internal void <GenerateWorld>b__277_17(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				WorldGen.NotTheBees();
				Tile tile;
				bool flag = tile.active();
			}

			// Token: 0x06002F20 RID: 12064 RVA: 0x001E92CC File Offset: 0x001E74CC
			internal void <GenerateWorld>b__277_18(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				UnifiedRandom genRand = WorldGen.genRand;
				UnifiedRandom genRand2 = WorldGen.genRand;
				UnifiedRandom genRand3 = WorldGen.genRand;
			}

			// Token: 0x06002F21 RID: 12065 RVA: 0x001E9384 File Offset: 0x001E7584
			internal void <GenerateWorld>b__277_19(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				long num2 = 0L;
				if (num == 0)
				{
				}
				long num3 = 0L;
				UnifiedRandom genRand = WorldGen.genRand;
				if (33501184 == 0)
				{
				}
				int num4 = genRand.Next((int)num3, (int)num2);
				if (33501184 == 0)
				{
				}
			}

			// Token: 0x06002F22 RID: 12066 RVA: 0x001E9490 File Offset: 0x001E7690
			internal void <GenerateWorld>b__277_20(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				int num4;
				long num5;
				if (num != 0)
				{
					if (num == 0)
					{
					}
					UnifiedRandom genRand = WorldGen.genRand;
					int num2 = 3;
					int num3 = genRand.Next(num2);
					Tile tile;
					ushort type = tile.type;
					num4 = 59;
					num5 = 0L;
					return;
				}
				if (!true)
				{
				}
				int num6 = WorldGen.genRand.Next(num4, (int)num5);
				int num7 = WorldGen.genRand.Next(num4, (int)num5);
			}

			// Token: 0x06002F23 RID: 12067 RVA: 0x001E9774 File Offset: 0x001E7974
			internal void <GenerateWorld>b__277_21(GenerationProgress progress, GameConfiguration passConfig)
			{
				if (!true)
				{
				}
				UnifiedRandom genRand = WorldGen.genRand;
				long num = 32752L;
				int num2 = 80;
				long num3;
				int num4;
				if (false)
				{
					if (!false)
					{
					}
					if (num2 == 0)
					{
					}
					if (num == 0L)
					{
					}
					num3 = 32752L;
					num4 = 32768;
				}
				if (num3 == 0L)
				{
				}
				if (num3 == 0L)
				{
				}
				UnifiedRandom genRand2 = WorldGen.genRand;
				if (num4 != 0)
				{
					return;
				}
			}

			// Token: 0x06002F24 RID: 12068 RVA: 0x001E97D0 File Offset: 0x001E79D0
			internal void <GenerateWorld>b__277_22(GenerationProgress progress, GameConfiguration passConfig)
			{
				if (!true)
				{
				}
				UnifiedRandom genRand = WorldGen.genRand;
				long num = 32752L;
				int num2 = 100;
				long num3;
				int num4;
				if (false)
				{
					if (!false)
					{
					}
					if (num2 == 0)
					{
					}
					if (num == 0L)
					{
					}
					num3 = 32752L;
					num4 = 32768;
				}
				if (num3 == 0L)
				{
				}
				if (num3 == 0L)
				{
				}
				UnifiedRandom genRand2 = WorldGen.genRand;
				if (num4 != 0)
				{
					return;
				}
			}

			// Token: 0x06002F25 RID: 12069 RVA: 0x001E9840 File Offset: 0x001E7A40
			internal void <GenerateWorld>b__277_23(GenerationProgress progress, GameConfiguration passConfig)
			{
			}

			// Token: 0x06002F26 RID: 12070 RVA: 0x001E98C8 File Offset: 0x001E7AC8
			internal void <GenerateWorld>b__277_24(GenerationProgress progress, GameConfiguration passConfig)
			{
				if (!true)
				{
				}
				long num = 0L;
				UnifiedRandom genRand = WorldGen.genRand;
				long num2 = 0L;
				int num3 = genRand.Next((int)num2, (int)num);
				int num4 = WorldGen.genRand.Next((int)num2, (int)num);
				int num5 = WorldGen.genRand.Next((int)num2, (int)num);
				Tile tile;
				ushort wall = tile.wall;
				Tile tile2;
				ushort wall2 = tile2.wall;
				UnifiedRandom genRand2 = WorldGen.genRand;
				int num6 = 5;
				int num7 = 12;
				int num8 = genRand2.Next(num6, num7);
				UnifiedRandom genRand3 = WorldGen.genRand;
				int num9 = 15;
				int num10 = 50;
				int num11 = genRand3.Next(num9, num10);
			}

			// Token: 0x06002F27 RID: 12071 RVA: 0x001E99F8 File Offset: 0x001E7BF8
			internal void <GenerateWorld>b__277_25(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				UnifiedRandom genRand = WorldGen.genRand;
				int num2 = 2;
				long num3 = 0L;
				int num4 = genRand.Next(num2);
				UnifiedRandom genRand2 = WorldGen.genRand;
				long num5 = 0L;
				int num6 = genRand2.Next((int)num5, (int)num3);
				int num7 = WorldGen.genRand.Next((int)num5, (int)num3);
				UnifiedRandom genRand3 = WorldGen.genRand;
				int num8 = 3;
				int num9 = 6;
				int num10 = genRand3.Next(num8, num9);
				UnifiedRandom genRand4 = WorldGen.genRand;
				int num11 = 2;
				int num12 = 6;
				int num13 = genRand4.Next(num11, num12);
			}

			// Token: 0x06002F28 RID: 12072 RVA: 0x001EAE28 File Offset: 0x001E9028
			internal void <GenerateWorld>b__277_26(GenerationProgress progress, GameConfiguration passConfig)
			{
				if (!true)
				{
				}
				long num = 0L;
				UnifiedRandom genRand = WorldGen.genRand;
				int num2 = 20;
				int num3 = genRand.Next(num2, (int)num);
				int num4 = WorldGen.genRand.Next(num2, (int)num);
			}

			// Token: 0x06002F29 RID: 12073 RVA: 0x001EAEF0 File Offset: 0x001E90F0
			internal void <GenerateWorld>b__277_27(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				UnifiedRandom genRand = WorldGen.genRand;
				int num2 = 150;
				int num3 = 190;
				int num4 = genRand.Next(num2, num3);
				if (num4 == 0)
				{
				}
				if (num4 == 0)
				{
				}
				UnifiedRandom genRand2 = WorldGen.genRand;
				int num5 = 4;
				int num6 = genRand2.Next(num2, num5);
			}

			// Token: 0x06002F2A RID: 12074 RVA: 0x001EBC18 File Offset: 0x001E9E18
			internal void <GenerateWorld>b__277_28(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				Tile tile;
				bool flag = tile.active();
				Tile tile2;
				ushort type = tile2.type;
			}

			// Token: 0x06002F2B RID: 12075 RVA: 0x001EC2FC File Offset: 0x001EA4FC
			internal void <GenerateWorld>b__277_29(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				UnifiedRandom genRand = WorldGen.genRand;
				UnifiedRandom genRand2 = WorldGen.genRand;
			}

			// Token: 0x06002F2C RID: 12076 RVA: 0x001EC468 File Offset: 0x001EA668
			internal void <GenerateWorld>b__277_30(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				long num2 = 0L;
				if (num == 0)
				{
				}
				UnifiedRandom genRand = WorldGen.genRand;
				int num3 = 200;
				int num4 = genRand.Next((int)num2, num3);
				if (32768 == 0)
				{
				}
				if (32752 == 0)
				{
				}
			}

			// Token: 0x06002F2D RID: 12077 RVA: 0x001EC4A8 File Offset: 0x001EA6A8
			internal void <GenerateWorld>b__277_31(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
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
				Tile tile;
				ushort type = tile.type;
			}

			// Token: 0x06002F2E RID: 12078 RVA: 0x001EC518 File Offset: 0x001EA718
			internal void <GenerateWorld>b__277_32(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				UnifiedRandom genRand = WorldGen.genRand;
				int num2 = 40;
				int num3 = 50;
				int num4 = genRand.Next(num2, num3);
			}

			// Token: 0x06002F2F RID: 12079 RVA: 0x001EC548 File Offset: 0x001EA748
			internal void <GenerateWorld>b__277_33(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				UnifiedRandom genRand = WorldGen.genRand;
				int num2 = 4;
				if (genRand.Next(num2) != 0)
				{
					return;
				}
				if (num == 0)
				{
				}
				UnifiedRandom genRand2 = WorldGen.genRand;
				int num3 = 2;
				long num4 = 0L;
				int num5 = genRand2.Next(num3);
				if (false)
				{
					if (num == 0)
					{
					}
					int num6 = WorldGen.genRand.Next(num3, (int)num4);
					return;
				}
				int num7 = WorldGen.genRand.Next(num3, (int)num4);
			}

			// Token: 0x06002F30 RID: 12080 RVA: 0x001EC750 File Offset: 0x001EA950
			internal void <GenerateWorld>b__277_34(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
			}

			// Token: 0x06002F31 RID: 12081 RVA: 0x001EC878 File Offset: 0x001EAA78
			internal void <GenerateWorld>b__277_35(GenerationProgress progress, GameConfiguration passConfig)
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
				tile2.ResetToType(type);
			}

			// Token: 0x06002F32 RID: 12082 RVA: 0x001EC8A8 File Offset: 0x001EAAA8
			internal void <GenerateWorld>b__277_36(GenerationProgress progress, GameConfiguration passConfig)
			{
				if (!true)
				{
				}
				int num = 2;
				if (false || num == 0)
				{
				}
			}

			// Token: 0x06002F33 RID: 12083 RVA: 0x001EC924 File Offset: 0x001EAB24
			internal void <GenerateWorld>b__277_37(GenerationProgress progress, GameConfiguration passConfig)
			{
				if (!true)
				{
				}
				long num = 32752L;
				if (21846 == 0)
				{
				}
				if (num == 0L)
				{
				}
				UnifiedRandom genRand = WorldGen.genRand;
				if (num == 0L)
				{
				}
				if (num == 0L)
				{
				}
				UnifiedRandom genRand2 = WorldGen.genRand;
				if (num == 0L)
				{
				}
			}

			// Token: 0x06002F34 RID: 12084 RVA: 0x001ECA34 File Offset: 0x001EAC34
			internal void <GenerateWorld>b__277_38(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				Tile tile;
				ushort wall = tile.wall;
			}

			// Token: 0x06002F35 RID: 12085 RVA: 0x001ECCF4 File Offset: 0x001EAEF4
			internal void <GenerateWorld>b__277_39(GenerationProgress progress, GameConfiguration passConfig)
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
				}
			}

			// Token: 0x06002F36 RID: 12086 RVA: 0x001ECD44 File Offset: 0x001EAF44
			internal void <GenerateWorld>b__277_40(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				UnifiedRandom genRand = WorldGen.genRand;
				UnifiedRandom genRand2 = WorldGen.genRand;
				Tile tile;
				ushort wall = tile.wall;
				int num2;
				int num3;
				WorldGen.DirtyRockRunner(num2, num3);
			}

			// Token: 0x06002F37 RID: 12087 RVA: 0x001ECD80 File Offset: 0x001EAF80
			internal void <GenerateWorld>b__277_41(GenerationProgress progress, GameConfiguration passConfig)
			{
				if (!true)
				{
				}
				UnifiedRandom genRand = WorldGen.genRand;
				int num = 32768;
				int num2;
				if (num2 == 0)
				{
					if (num == 0)
					{
					}
					UnifiedRandom genRand2 = WorldGen.genRand;
					int num3 = 2;
					int num4 = genRand2.Next(num3);
				}
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
				long num5;
				if (num != 0)
				{
					num5 = 32752L;
					return;
				}
				if (num5 == 0L)
				{
				}
				UnifiedRandom genRand3 = WorldGen.genRand;
			}

			// Token: 0x06002F38 RID: 12088 RVA: 0x001ECF50 File Offset: 0x001EB150
			internal void <GenerateWorld>b__277_42(GenerationProgress progress, GameConfiguration passConfig)
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
				Tile tile3;
				ushort type3 = tile3.type;
				Tile tile4;
				ushort type4 = tile4.type;
				Tile tile5;
				ushort type5 = tile5.type;
				Tile tile6;
				ushort type6 = tile6.type;
				Tile tile7;
				ushort wall = tile7.wall;
				int num2 = 244;
				Tile tile8;
				tile8.wall = (ushort)num2;
			}

			// Token: 0x06002F39 RID: 12089 RVA: 0x001ECFC8 File Offset: 0x001EB1C8
			internal void <GenerateWorld>b__277_43(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				long num2 = 0L;
				UnifiedRandom genRand = WorldGen.genRand;
				int num3 = 281;
				int num4 = genRand.Next(num3, (int)num2);
				int num5 = WorldGen.genRand.Next(num3, (int)num2);
			}

			// Token: 0x06002F3A RID: 12090 RVA: 0x001ED0A8 File Offset: 0x001EB2A8
			internal void <GenerateWorld>b__277_44(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				Tile tile;
				bool flag = tile.active();
			}

			// Token: 0x06002F3B RID: 12091 RVA: 0x001ED0F4 File Offset: 0x001EB2F4
			internal void <GenerateWorld>b__277_45(GenerationProgress progress, GameConfiguration passConfig)
			{
				if (!true)
				{
				}
				UnifiedRandom genRand = WorldGen.genRand;
				double num = WorldGen.genRand.NextDouble();
				UnifiedRandom genRand2 = WorldGen.genRand;
			}

			// Token: 0x06002F3C RID: 12092 RVA: 0x001ED1E4 File Offset: 0x001EB3E4
			internal void <GenerateWorld>b__277_46(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				UnifiedRandom genRand = WorldGen.genRand;
				int num2 = 20;
				int num3 = 300;
				int num4 = 20;
				Point point = WorldGen.RandomWorldPoint(0, num2, num3, num4);
				int num5 = 20;
				int num6 = 300;
				int num7 = 20;
				Point point2 = WorldGen.RandomWorldPoint(0, num5, num6, num7);
				if (!false)
				{
				}
				if (!false)
				{
				}
				UnifiedRandom genRand2 = WorldGen.genRand;
				int num8 = 5;
				int num9 = genRand2.Next(num8);
				if (!false)
				{
				}
				double num10 = WorldGen.genRand.NextDouble();
				UnifiedRandom genRand3 = WorldGen.genRand;
				double num11 = genRand3.NextDouble();
			}

			// Token: 0x06002F3D RID: 12093 RVA: 0x001ED294 File Offset: 0x001EB494
			internal void <GenerateWorld>b__277_47(GenerationProgress progress, GameConfiguration passConfig)
			{
				if (!true)
				{
				}
				UnifiedRandom genRand = WorldGen.genRand;
				UnifiedRandom genRand2 = WorldGen.genRand;
				long num = 32752L;
				UnifiedRandom genRand3 = WorldGen.genRand;
				int num2 = 7;
				int num3 = 12;
				int num4 = genRand3.Next(num2, num3);
				if (!false)
				{
				}
				UnifiedRandom genRand4 = WorldGen.genRand;
				if (num == 0L)
				{
				}
				int num5 = 40;
				int num6 = genRand4.Next(num5, num3);
				if (num == 0L)
				{
				}
				UnifiedRandom genRand5 = WorldGen.genRand;
				if (num == 0L)
				{
				}
				int num7 = genRand5.Next(num5, num3);
				UnifiedRandom genRand6 = WorldGen.genRand;
				int num8 = 2;
				int num9 = 4;
				int num10 = genRand6.Next(num8, num9);
				UnifiedRandom genRand7 = WorldGen.genRand;
				int num11 = 2;
				int num12 = 4;
				int num13 = genRand7.Next(num11, num12);
				Tile tile;
				ushort type = tile.type;
				Tile tile2;
				bool flag = tile2.active();
				Tile tile3;
				ushort type2 = tile3.type;
				Tile tile4;
				ushort type3 = tile4.type;
				Tile tile5;
				ushort type4 = tile5.type;
				Tile tile6;
				ushort type5 = tile6.type;
				Tile tile7;
				ushort type6 = tile7.type;
				Tile tile8;
				ushort wall = tile8.wall;
				Tile tile9;
				ushort wall2 = tile9.wall;
			}

			// Token: 0x06002F3E RID: 12094 RVA: 0x001ED518 File Offset: 0x001EB718
			internal void <GenerateWorld>b__277_48(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				long num2 = 0L;
				if (num == 0)
				{
				}
				if (num != 0)
				{
					if (num == 0)
					{
					}
					WorldGen.NotTheBees();
				}
				if (num == 0)
				{
				}
				int num3 = 1;
				long num4 = 0L;
				Liquid.worldGenTilesIgnoreWater(num3 != 0);
				Liquid.QuickWater(3, (int)num4, (int)num2);
				if (num == 0)
				{
				}
				WorldGen.WaterCheck();
			}

			// Token: 0x06002F3F RID: 12095 RVA: 0x001ED580 File Offset: 0x001EB780
			internal void <GenerateWorld>b__277_49(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				Tile tile;
				bool flag = tile.active();
			}

			// Token: 0x06002F40 RID: 12096 RVA: 0x001ED5C4 File Offset: 0x001EB7C4
			internal void <GenerateWorld>b__277_50(GenerationProgress progress, GameConfiguration passConfig)
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
					int num2 = 39447;
					UnifiedRandom genRand = WorldGen.genRand;
					int num3 = 2;
					long num4 = 0L;
					int num5 = genRand.Next(num3);
					if (num == 0)
					{
					}
					UnifiedRandom genRand2 = WorldGen.genRand;
					if (num2 == 0)
					{
					}
					UnifiedRandom genRand3 = WorldGen.genRand;
					int num6 = 100;
					int num7 = genRand3.Next(num6, (int)num4);
					int num8;
					bool flag = WorldGen.PlaceOasis(num8, num7);
				}
			}

			// Token: 0x06002F41 RID: 12097 RVA: 0x001ED634 File Offset: 0x001EB834
			internal void <GenerateWorld>b__277_51(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				int num2;
				int num3;
				int num5;
				if (num != 0)
				{
					if (num == 0)
					{
					}
					num2 = 32768;
					num3 = 49152;
					if (num == 0)
					{
					}
					UnifiedRandom genRand = WorldGen.genRand;
					if (num2 == 0)
					{
					}
					UnifiedRandom genRand2 = WorldGen.genRand;
					if (num2 == 0)
					{
					}
					int num4 = 100;
					bool flag = WorldGen.MarblePileWithStatues(num5, num4);
				}
				UnifiedRandom genRand3 = WorldGen.genRand;
				int num6 = 2;
				if (genRand3.Next(num6) == 0)
				{
					Tile tile;
					bool flag2 = tile.active();
					Tile tile2;
					ushort type = tile2.type;
					Tile tile3;
					bool flag3 = tile3.active();
					Tile tile4;
					byte liquid = tile4.liquid;
					Tile tile5;
					bool flag4 = tile5.active();
					Tile tile6;
					byte liquid2 = tile6.liquid;
					if (num2 == 0)
					{
					}
					UnifiedRandom genRand4 = WorldGen.genRand;
					int num7 = 5;
					int num8 = genRand4.Next(num7);
					UnifiedRandom genRand5 = WorldGen.genRand;
					int num9 = 2;
					if (genRand5.Next(num9) == 0)
					{
						UnifiedRandom genRand6 = WorldGen.genRand;
						int num10 = 10;
						int num11 = genRand6.Next(num10);
					}
					UnifiedRandom genRand7 = WorldGen.genRand;
					int num12 = 3;
					if (genRand7.Next(num12) == 0)
					{
						UnifiedRandom genRand8 = WorldGen.genRand;
						int num13 = 15;
						int num14 = genRand8.Next(num13);
					}
					UnifiedRandom genRand9 = WorldGen.genRand;
					int num15 = 4;
					if (genRand9.Next(num15) != 0)
					{
						bool flag5 = WorldGen.ShellPile(num5, num3);
					}
					UnifiedRandom genRand10 = WorldGen.genRand;
					int num16 = 2;
					int num17 = 4;
					int num18 = genRand10.Next(num16, num17);
					if (WorldGen.genRand.Next(num18) == 0)
					{
						UnifiedRandom genRand11 = WorldGen.genRand;
						int num19 = 10;
						int num20 = 35;
						bool flag6 = WorldGen.ShellPile(genRand11.Next(num19, num20), num19);
					}
					if (WorldGen.genRand.Next(num18) == 0)
					{
						UnifiedRandom genRand12 = WorldGen.genRand;
						int num21 = 40;
						int num22 = 65;
						bool flag7 = WorldGen.ShellPile(genRand12.Next(num21, num22), num21);
					}
					if (WorldGen.genRand.Next(num18) == 0)
					{
						UnifiedRandom genRand13 = WorldGen.genRand;
						int num23 = 70;
						int num24 = 95;
						bool flag8 = WorldGen.ShellPile(genRand13.Next(num23, num24), num23);
					}
					if (WorldGen.genRand.Next(num18) == 0)
					{
						UnifiedRandom genRand14 = WorldGen.genRand;
						int num25 = 100;
						int num26 = 125;
						bool flag9 = WorldGen.ShellPile(genRand14.Next(num25, num26), num25);
					}
					if (WorldGen.genRand.Next(num18) == 0)
					{
						UnifiedRandom genRand15 = WorldGen.genRand;
						int num27 = 10;
						int num28 = 25;
						bool flag10 = WorldGen.ShellPile(genRand15.Next(num27, num28), num27);
					}
				}
				UnifiedRandom genRand16 = WorldGen.genRand;
				int num29 = 2;
				if (genRand16.Next(num29) == 0)
				{
					Tile tile7;
					bool flag11 = tile7.active();
					Tile tile8;
					ushort type2 = tile8.type;
					Tile tile9;
					bool flag12 = tile9.active();
					Tile tile10;
					byte liquid3 = tile10.liquid;
					Tile tile11;
					bool flag13 = tile11.active();
					Tile tile12;
					byte liquid4 = tile12.liquid;
					if (num2 == 0)
					{
					}
					UnifiedRandom genRand17 = WorldGen.genRand;
					int num30 = 5;
					int num31 = genRand17.Next(num30);
					UnifiedRandom genRand18 = WorldGen.genRand;
					int num32 = 2;
					if (genRand18.Next(num32) == 0)
					{
						UnifiedRandom genRand19 = WorldGen.genRand;
						int num33 = 10;
						int num34 = genRand19.Next(num33);
					}
					UnifiedRandom genRand20 = WorldGen.genRand;
					int num35 = 3;
					if (genRand20.Next(num35) == 0)
					{
						UnifiedRandom genRand21 = WorldGen.genRand;
						int num36 = 15;
						int num37 = genRand21.Next(num36);
					}
					UnifiedRandom genRand22 = WorldGen.genRand;
					int num38 = 4;
					if (genRand22.Next(num38) != 0)
					{
						bool flag14 = WorldGen.ShellPile(num5, num5);
					}
					UnifiedRandom genRand23 = WorldGen.genRand;
					int num39 = 2;
					int num40 = 4;
					int num41 = genRand23.Next(num39, num40);
					if (WorldGen.genRand.Next(num41) == 0)
					{
						UnifiedRandom genRand24 = WorldGen.genRand;
						int num42 = 10;
						int num43 = 35;
						bool flag15 = WorldGen.ShellPile(genRand24.Next(num42, num43), num42);
					}
					if (WorldGen.genRand.Next(num41) == 0)
					{
						UnifiedRandom genRand25 = WorldGen.genRand;
						int num44 = 40;
						int num45 = 65;
						bool flag16 = WorldGen.ShellPile(genRand25.Next(num44, num45), num44);
					}
					if (WorldGen.genRand.Next(num41) == 0)
					{
						UnifiedRandom genRand26 = WorldGen.genRand;
						int num46 = 70;
						int num47 = 95;
						bool flag17 = WorldGen.ShellPile(genRand26.Next(num46, num47), num46);
					}
					if (WorldGen.genRand.Next(num41) == 0)
					{
						UnifiedRandom genRand27 = WorldGen.genRand;
						int num48 = 100;
						int num49 = 125;
						bool flag18 = WorldGen.ShellPile(genRand27.Next(num48, num49), num48);
					}
					if (WorldGen.genRand.Next(num41) == 0)
					{
						UnifiedRandom genRand28 = WorldGen.genRand;
						int num50 = 10;
						int num51 = 25;
						bool flag19 = WorldGen.ShellPile(genRand28.Next(num50, num51), num50);
					}
				}
			}

			// Token: 0x06002F42 RID: 12098 RVA: 0x001EDACC File Offset: 0x001EBCCC
			internal void <GenerateWorld>b__277_52(GenerationProgress progress, GameConfiguration passConfig)
			{
				if (!true)
				{
				}
				int num = 1;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
			}

			// Token: 0x06002F43 RID: 12099 RVA: 0x001EDED8 File Offset: 0x001EC0D8
			internal void <GenerateWorld>b__277_53(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				int num2 = 20;
				if (num == 0)
				{
				}
				int num3 = 20;
				long num4 = 0L;
				bool flag = WorldGen.SolidTile(num2, num3, num4 != 0L);
				long num5 = 0L;
				Tile tile;
				bool flag2 = tile.active();
				long num6 = 0L;
				bool flag3 = WorldGen.SolidTile(num2, (int)num5, num6 != 0L);
				Tile tile2;
				bool flag4 = tile2.active();
				Tile tile3;
				byte liquid = tile3.liquid;
				Tile tile4;
				byte liquid2 = tile4.liquid;
				UnifiedRandom genRand = WorldGen.genRand;
				int num7 = 8;
				int num8 = 20;
				int num9 = genRand.Next(num7, num8);
				UnifiedRandom genRand2 = WorldGen.genRand;
				int num10 = 8;
				int num11 = 20;
				int num12 = genRand2.Next(num10, num11);
				Tile tile5;
				bool flag5 = tile5.halfBrick();
			}

			// Token: 0x06002F44 RID: 12100 RVA: 0x001EE05C File Offset: 0x001EC25C
			internal void <GenerateWorld>b__277_54(GenerationProgress progress, GameConfiguration passConfig)
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
					WorldGen.NotTheBees();
				}
				int num2 = 10;
				if (num == 0)
				{
				}
				Tile tile;
				byte liquid = tile.liquid;
				Tile tile2;
				bool flag = tile2.lava();
				WorldGen.MakeWateryIceThing(num2, 43147264);
			}

			// Token: 0x06002F45 RID: 12101 RVA: 0x001EE0A0 File Offset: 0x001EC2A0
			internal void <GenerateWorld>b__277_55(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				long num2 = 32752L;
				progress.Set(5040000.0);
				if (num2 == 0L)
				{
				}
			}

			// Token: 0x06002F46 RID: 12102 RVA: 0x001EE1E8 File Offset: 0x001EC3E8
			internal void <GenerateWorld>b__277_56(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num != 0)
				{
				}
				WorldGen.NotTheBees();
				long num2 = 0L;
				double num3 = Main.starGameMath(0.2);
				long num4 = 0L;
				int num5 = WorldGen.genRand.Next((int)num4, (int)num2);
				int num6 = WorldGen.genRand.Next((int)num4, (int)num2);
				bool flag = WorldGen.AddLifeCrystal(WorldGen.genRand.Next((int)num4, (int)num2), num6);
			}

			// Token: 0x06002F47 RID: 12103 RVA: 0x001EE270 File Offset: 0x001EC470
			internal void <GenerateWorld>b__277_57(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				long num2 = 0L;
				if (num == 0)
				{
				}
				long num3 = 32752L;
				if (num3 == 0L)
				{
				}
				int num4;
				if (num3 != 0L)
				{
					if (num3 == 0L)
					{
					}
					if (num3 != 0L || num3 == 0L)
					{
					}
					num4 = 26215;
				}
				if (num4 == 0)
				{
				}
				int num5 = 4829;
				long num7;
				if (num4 != 0)
				{
					if (num4 == 0)
					{
					}
					double num6 = Main.starGameMath(0.2);
					num7 = 32752L;
				}
				if (num7 == 0L)
				{
				}
				if (num7 == 0L)
				{
				}
				UnifiedRandom genRand = WorldGen.genRand;
				if (num5 == 0)
				{
				}
				int num8 = 20;
				int num9 = genRand.Next(num8, (int)num2);
				int num10 = WorldGen.genRand.Next(num8, (int)num2);
				if (num5 != 0)
				{
					if (num5 == 0)
					{
					}
					UnifiedRandom genRand2 = WorldGen.genRand;
					if (num5 == 0)
					{
					}
					int num11 = genRand2.Next(num8, (int)num2);
				}
				bool flag = WorldGen.oceanDepths(num9, num10);
				Tile tile;
				bool flag2 = tile.active();
			}

			// Token: 0x06002F48 RID: 12104 RVA: 0x001EE37C File Offset: 0x001EC57C
			internal void <GenerateWorld>b__277_58(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				int num2 = 257;
				num.m_value = num2;
				if (num == 0)
				{
				}
				if (num2 == 0)
				{
				}
				UnifiedRandom genRand = WorldGen.genRand;
				UnifiedRandom genRand2 = WorldGen.genRand;
				UnifiedRandom genRand3 = WorldGen.genRand;
				UnifiedRandom genRand4 = WorldGen.genRand;
				double num3 = Main.starGameMath(0.2);
			}

			// Token: 0x06002F49 RID: 12105 RVA: 0x001EE564 File Offset: 0x001EC764
			internal void <GenerateWorld>b__277_59(GenerationProgress progress, GameConfiguration passConfig)
			{
				if (!true)
				{
				}
				long num = 0L;
				UnifiedRandom genRand = WorldGen.genRand;
				int num2 = 200;
				int num3 = genRand.Next(num2, (int)num);
				int num4 = WorldGen.genRand.Next(num2, (int)num);
				int num5 = WorldGen.genRand.Next(num2, (int)num);
			}

			// Token: 0x06002F4A RID: 12106 RVA: 0x001EE648 File Offset: 0x001EC848
			internal void <GenerateWorld>b__277_60(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				int nextJungleChestItem = WorldGen.GetNextJungleChestItem();
				UnifiedRandom genRand = WorldGen.genRand;
				int num2 = 2;
				int num3 = genRand.Next(num2);
				int num4 = 10;
				long num5 = 0L;
				long num6 = 0L;
				long num7 = 0L;
				bool flag = WorldGen.AddBuriedChest(num3, num2, nextJungleChestItem, num5 != 0L, num4, num6 != 0L, (ushort)num7);
				long num8 = 0L;
				long num9 = 0L;
				long num10 = 0L;
				WorldGen.KillTile(43147264, num2, num8 != 0L, num9 != 0L, num10 != 0L);
			}

			// Token: 0x06002F4B RID: 12107 RVA: 0x001EE700 File Offset: 0x001EC900
			internal void <GenerateWorld>b__277_61(GenerationProgress progress, GameConfiguration passConfig)
			{
				if (!true)
				{
				}
				UnifiedRandom genRand = WorldGen.genRand;
				UnifiedRandom genRand2 = WorldGen.genRand;
				UnifiedRandom genRand3 = WorldGen.genRand;
				Tile tile;
				byte liquid = tile.liquid;
			}

			// Token: 0x06002F4C RID: 12108 RVA: 0x001EE8A4 File Offset: 0x001ECAA4
			internal void <GenerateWorld>b__277_62(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				long num2 = 0L;
				if (num == 0)
				{
				}
				int num3 = 1;
				UnifiedRandom genRand = WorldGen.genRand;
				int num4 = 200;
				int num5 = genRand.Next(num4, (int)num2);
				int num6 = WorldGen.genRand.Next(num4, (int)num2);
				int num7;
				if (num3 != 0)
				{
					if (num3 == 0)
					{
					}
					UnifiedRandom genRand2 = WorldGen.genRand;
					if (num3 == 0)
					{
					}
					num7 = genRand2.Next(num4, (int)num2);
				}
				if (num3 == 0)
				{
				}
				int num8 = 1;
				long num9 = 0L;
				int num10 = WorldGen.countTiles(num5, num7, num9 != 0L, num8 != 0);
				UnifiedRandom genRand3 = WorldGen.genRand;
				if (num3 == 0)
				{
				}
				int num11 = 200;
				int num12 = genRand3.Next(num11, (int)num9);
				int num13 = WorldGen.genRand.Next(num11, (int)num9);
				int num14;
				if (num3 != 0)
				{
					if (num3 == 0)
					{
					}
					UnifiedRandom genRand4 = WorldGen.genRand;
					if (num3 == 0)
					{
					}
					num14 = genRand4.Next(num11, (int)num9);
				}
				if (num3 == 0)
				{
				}
				int num15 = 1;
				long num16 = 0L;
				int num17 = WorldGen.countTiles(num12, num14, num16 != 0L, num15 != 0);
				WorldGen.Spread.Spider(num12, num14);
				if (num17 == 0)
				{
				}
				if (num17 == 0 || num17 == 0)
				{
				}
				if (num17 == 0)
				{
				}
			}

			// Token: 0x06002F4D RID: 12109 RVA: 0x001EE9B4 File Offset: 0x001ECBB4
			internal void <GenerateWorld>b__277_63(GenerationProgress progress, GameConfiguration passConfig)
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
					long num2 = 0L;
					if (num == 0)
					{
					}
					int num3 = 300;
					if (num3 == 0)
					{
					}
					if (num3 == 0)
					{
					}
					int num4 = 4829;
					double num5;
					if (num4 != 0)
					{
						if (num4 == 0)
						{
						}
						num5 = Main.starGameMath(0.2);
					}
					progress.Set(num5);
					UnifiedRandom genRand = WorldGen.genRand;
					if (num3 == 0)
					{
					}
					int num6 = 200;
					int num7 = genRand.Next(num6, (int)num2);
					int num8 = WorldGen.genRand.Next(num6, (int)num2);
					int num9;
					if (num3 != 0)
					{
						if (num3 == 0)
						{
						}
						UnifiedRandom genRand2 = WorldGen.genRand;
						if (num3 == 0)
						{
						}
						num9 = genRand2.Next(num6, (int)num2);
					}
					if (num3 == 0)
					{
					}
					long num10 = 0L;
					long num11 = 0L;
					int num12 = WorldGen.countTiles(num7, num9, num10 != 0L, num11 != 0L);
					if (num3 == 0)
					{
					}
					UnifiedRandom genRand3 = WorldGen.genRand;
					if (num3 == 0)
					{
					}
					int num13 = 200;
					int num14 = genRand3.Next(num13, (int)num10);
					int num15 = WorldGen.genRand.Next(num13, (int)num10);
					int num16;
					if (num3 != 0)
					{
						if (num3 == 0)
						{
						}
						UnifiedRandom genRand4 = WorldGen.genRand;
						if (num3 == 0)
						{
						}
						num16 = genRand4.Next(num13, (int)num10);
					}
					if (num3 == 0)
					{
					}
					long num17 = 0L;
					long num18 = 0L;
					int num19 = WorldGen.countTiles(num14, num16, num17 != 0L, num18 != 0L);
					return;
				}
			}

			// Token: 0x06002F4E RID: 12110 RVA: 0x001EEAF0 File Offset: 0x001ECCF0
			internal void <GenerateWorld>b__277_64(GenerationProgress progress, GameConfiguration passConfig)
			{
				if (!true)
				{
				}
				WorldGen.randMoss(false);
			}

			// Token: 0x06002F4F RID: 12111 RVA: 0x001EEEB0 File Offset: 0x001ED0B0
			internal void <GenerateWorld>b__277_65(GenerationProgress progress, GameConfiguration passConfig)
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
				WorldGen.templePart2();
			}

			// Token: 0x06002F50 RID: 12112 RVA: 0x001EEECC File Offset: 0x001ED0CC
			internal void <GenerateWorld>b__277_66(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				if (1500 == 0)
				{
				}
			}

			// Token: 0x06002F51 RID: 12113 RVA: 0x001EF1C0 File Offset: 0x001ED3C0
			internal void <GenerateWorld>b__277_67(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				long num2 = 0L;
				if (num == 0)
				{
				}
				UnifiedRandom genRand = WorldGen.genRand;
				int num3 = 10;
				if (genRand.Next(num3) != 0)
				{
				}
				WorldGen.GrowUndergroundTree((int)num2, 43147264);
			}

			// Token: 0x06002F52 RID: 12114 RVA: 0x001EF1FC File Offset: 0x001ED3FC
			internal void <GenerateWorld>b__277_68(GenerationProgress progress, GameConfiguration passConfig)
			{
				if (!true)
				{
				}
			}

			// Token: 0x06002F53 RID: 12115 RVA: 0x001EF214 File Offset: 0x001ED414
			internal void <GenerateWorld>b__277_69(GenerationProgress progress, GameConfiguration passConfig)
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
					WorldGen.NotTheBees();
				}
				if (num == 0)
				{
				}
				int num2 = 20;
				if (num == 0)
				{
				}
				int num3 = 20;
				if (num == 0)
				{
				}
				bool flag = WorldGen.oceanDepths(num2, num3);
				UnifiedRandom genRand = WorldGen.genRand;
				int num4 = 4;
				int num5 = 7;
				int num6 = genRand.Next(num4, num5);
				Tile tile;
				bool flag2 = tile.active();
				Tile tile2;
				bool flag3 = tile2.active();
				Tile tile3;
				ushort type = tile3.type;
				Tile tile4;
				ushort type2 = tile4.type;
				Tile tile5;
				ushort type3 = tile5.type;
				Tile tile6;
				bool flag4 = tile6.active();
				Tile tile7;
				ushort type4 = tile7.type;
				Tile tile8;
				ushort type5 = tile8.type;
				Tile tile9;
				ushort type6 = tile9.type;
			}

			// Token: 0x06002F54 RID: 12116 RVA: 0x001EF358 File Offset: 0x001ED558
			internal void <GenerateWorld>b__277_70(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				int num2 = 1;
				if (num == 0)
				{
				}
				long num3 = 0L;
				if (num == 0)
				{
				}
				if (num2 != 0)
				{
					if (num2 == 0)
					{
					}
					UnifiedRandom genRand = WorldGen.genRand;
					if (num2 == 0)
					{
					}
					int num4 = 50;
					int num5 = genRand.Next(num4, (int)num3);
					int num6 = WorldGen.genRand.Next(num4, (int)num3);
					if (num2 == 0)
					{
					}
					Tile tile;
					bool flag = tile.active();
					if (num2 == 0)
					{
					}
					return;
				}
				if (num2 == 0)
				{
				}
				if (num2 != 0)
				{
					if (num2 == 0)
					{
					}
					double num7 = Main.starGameMath(0.2);
				}
				long num8 = 0L;
				long num9 = 0L;
				UnifiedRandom genRand2 = WorldGen.genRand;
				if (num8 == 0L)
				{
				}
				if (num8 == 0L)
				{
				}
				int num11;
				int num10 = genRand2.Next((int)num9, num11);
			}

			// Token: 0x06002F55 RID: 12117 RVA: 0x001EF6AC File Offset: 0x001ED8AC
			internal void <GenerateWorld>b__277_71(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				long num2 = 0L;
				if (num == 0)
				{
				}
				UnifiedRandom genRand = WorldGen.genRand;
				int num3 = 1;
				int num4 = genRand.Next(num3, (int)num2);
				int num5 = WorldGen.genRand.Next(num3, (int)num2);
				Tile tile;
				ushort wall = tile.wall;
				Tile tile2;
				ushort wall2 = tile2.wall;
				Tile tile3;
				bool flag = tile3.active();
			}

			// Token: 0x06002F56 RID: 12118 RVA: 0x001EF734 File Offset: 0x001ED934
			internal void <GenerateWorld>b__277_72(GenerationProgress progress, GameConfiguration passConfig)
			{
				if (!true)
				{
				}
				Tile tile;
				bool flag = tile.active();
				Tile tile2;
				ushort type = tile2.type;
				Tile tile3;
				bool flag2 = tile3.active();
				Tile tile4;
				bool flag3 = tile4.active();
				Tile tile5;
				bool flag4 = tile5.active();
			}

			// Token: 0x06002F57 RID: 12119 RVA: 0x001EFA8C File Offset: 0x001EDC8C
			internal void <GenerateWorld>b__277_73(GenerationProgress progress, GameConfiguration passConfig)
			{
				if (!true)
				{
				}
				UnifiedRandom genRand = WorldGen.genRand;
				long num = 0L;
				UnifiedRandom genRand2 = WorldGen.genRand;
				if (num != 0L)
				{
					return;
				}
			}

			// Token: 0x06002F58 RID: 12120 RVA: 0x001EFB68 File Offset: 0x001EDD68
			internal void <GenerateWorld>b__277_74(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
			}

			// Token: 0x06002F59 RID: 12121 RVA: 0x001EFD14 File Offset: 0x001EDF14
			internal void <GenerateWorld>b__277_75(GenerationProgress progress, GameConfiguration passConfig)
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
					if (num == 0)
					{
					}
					return;
				}
			}

			// Token: 0x06002F5A RID: 12122 RVA: 0x001EFF14 File Offset: 0x001EE114
			internal void <GenerateWorld>b__277_76(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				long num2 = 0L;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				if (num == 0 || num == 0)
				{
				}
				UnifiedRandom genRand = WorldGen.genRand;
				int num3 = 25;
				int num4 = genRand.Next(num3, (int)num2);
				int num5 = WorldGen.genRand.Next(num3, (int)num2);
				bool flag = WorldGen.oceanDepths(num4, num5);
			}

			// Token: 0x06002F5B RID: 12123 RVA: 0x001F15B8 File Offset: 0x001EF7B8
			internal void <GenerateWorld>b__277_77(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				int num2;
				if (num != 0)
				{
					if (num == 0)
					{
					}
					if (num == 0)
					{
						UnifiedRandom genRand = WorldGen.genRand;
						num2 = 2;
						if (genRand.Next(num2) != 0)
						{
						}
					}
				}
				int num3 = 5;
				int num4 = WorldGen.genRand.Next(num2, num3);
				Tile tile;
				bool flag = tile.active();
			}

			// Token: 0x06002F5C RID: 12124 RVA: 0x001F16C4 File Offset: 0x001EF8C4
			internal void <GenerateWorld>b__277_78(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				int num2 = 3500;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				UnifiedRandom genRand = WorldGen.genRand;
				int num3 = 4;
				if (genRand.Next(num3) == 0)
				{
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
					ushort wall = tile3.wall;
					if (num == 0)
					{
					}
					Tile tile4;
					ushort wall2 = tile4.wall;
					if (num == 0)
					{
					}
					long num4 = 0L;
					Tile tile5;
					ushort wall3 = tile5.wall;
					if (num == 0)
					{
					}
					long num5 = 0L;
					bool flag2 = WorldGen.SolidTile(0, (int)num4, num5 != 0L);
					if (num == 0)
					{
					}
					Tile tile6;
					ushort wall4 = tile6.wall;
					if (num == 0)
					{
					}
					long num6 = 0L;
					Tile tile7;
					ushort wall5 = tile7.wall;
					if (num == 0)
					{
					}
					long num7 = 0L;
					bool flag3 = WorldGen.SolidTile(0, (int)num6, num7 != 0L);
					if (num == 0)
					{
					}
					int num8 = WorldGen.countDirtTiles(0, (int)num6);
					int num9;
					int num10;
					if (num2 != 0)
					{
						if (num2 == 0)
						{
						}
						UnifiedRandom genRand2 = WorldGen.genRand;
						num9 = 3;
						num10 = genRand2.Next(num9);
						return;
					}
					int num11 = 63;
					WorldGen.Spread.Wall2(num10, num9, num11);
				}
			}

			// Token: 0x06002F5D RID: 12125 RVA: 0x001F1804 File Offset: 0x001EFA04
			internal void <GenerateWorld>b__277_79(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				int num4;
				if (num != 0)
				{
					if (num == 0)
					{
					}
					int num2 = 1;
					if (num == 0)
					{
					}
					int num3;
					if (num != 0)
					{
						if (num2 == 0)
						{
						}
						num3 = 1;
					}
					int spawnTileX = Main.spawnTileX;
					int spawnTileY = Main.spawnTileY;
					if (num3 == 0)
					{
					}
					num4 = 1;
					return;
				}
				if (num4 != 0)
				{
					int spawnTileX2 = Main.spawnTileX;
					int spawnTileY2 = Main.spawnTileY;
					if (num4 == 0)
					{
					}
					int spawnTileX3 = Main.spawnTileX;
					int spawnTileY3 = Main.spawnTileY;
					return;
				}
				int num5;
				if (num5 == 0)
				{
				}
				int num6;
				if (num5 != 0)
				{
					int spawnTileX4 = Main.spawnTileX;
					int spawnTileY4 = Main.spawnTileY;
					if (num5 == 0)
					{
					}
					int spawnTileX5 = Main.spawnTileX;
					int spawnTileY5 = Main.spawnTileY;
					num6 = 1;
					return;
				}
				if (num6 == 0)
				{
				}
				int num7;
				if (num6 != 0)
				{
					int spawnTileX6 = Main.spawnTileX;
					int spawnTileY6 = Main.spawnTileY;
					if (num6 == 0)
					{
					}
					int spawnTileX7 = Main.spawnTileX;
					int spawnTileY7 = Main.spawnTileY;
					num7 = 1;
					return;
				}
				if (num7 == 0)
				{
				}
				if ("PartyGirlNames.Amanda" == null)
				{
				}
				int spawnTileX8 = Main.spawnTileX;
				int spawnTileY8 = Main.spawnTileY;
				if (num7 == 0)
				{
				}
				if ("SlimeNames_Rainbow.Slimestar" != null)
				{
					int spawnTileX9 = Main.spawnTileX;
					int spawnTileY9 = Main.spawnTileY;
					return;
				}
				int spawnTileX10 = Main.spawnTileX;
				int spawnTileY10 = Main.spawnTileY;
			}

			// Token: 0x06002F5E RID: 12126 RVA: 0x001F1A3C File Offset: 0x001EFC3C
			internal void <GenerateWorld>b__277_80(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				long num2 = 0L;
				progress.Set((double)(-755914244));
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				int num3 = WorldGen.genRand.Next((int)num2);
				UnifiedRandom genRand = WorldGen.genRand;
				int num4 = 10;
				int num5 = genRand.Next(num4);
				UnifiedRandom genRand2 = WorldGen.genRand;
				int num6 = 10;
				int num7 = genRand2.Next(num6);
			}

			// Token: 0x06002F5F RID: 12127 RVA: 0x001F1AD0 File Offset: 0x001EFCD0
			internal void <GenerateWorld>b__277_81(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				long num2 = 0L;
				if (num == 0)
				{
				}
				if (num == 0)
				{
					if (num == 0)
					{
					}
					if (num == 0)
					{
						UnifiedRandom genRand = WorldGen.genRand;
						int num3 = 50;
						int num4 = genRand.Next(num3, (int)num2);
						UnifiedRandom genRand2 = WorldGen.genRand;
						int num5 = 25;
						int num6 = 50;
						int num7 = genRand2.Next(num5, num6);
						int num8 = 20;
						bool flag = WorldGen.GrowEpicTree(42178960, num8);
						return;
					}
				}
				WorldGen.AddTrees(false);
			}

			// Token: 0x06002F60 RID: 12128 RVA: 0x001F1B44 File Offset: 0x001EFD44
			internal void <GenerateWorld>b__277_82(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				progress.Set(1.7);
				if (num == 0)
				{
				}
				WorldGen.PlantAlch();
			}

			// Token: 0x06002F61 RID: 12129 RVA: 0x001F1B70 File Offset: 0x001EFD70
			internal void <GenerateWorld>b__277_83(GenerationProgress progress, GameConfiguration passConfig)
			{
				if (!true)
				{
				}
				UnifiedRandom genRand = WorldGen.genRand;
				UnifiedRandom genRand2 = WorldGen.genRand;
				int underworldLayer = Main.UnderworldLayer;
				int num = 100;
				int num2 = genRand2.Next(num, underworldLayer);
				long num3 = 0L;
				int num4;
				WorldGen.plantDye(num4, num2, num3 != 0L);
			}

			// Token: 0x06002F62 RID: 12130 RVA: 0x001F1BD0 File Offset: 0x001EFDD0
			internal void <GenerateWorld>b__277_84(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				int num2 = 100;
				if (num == 0)
				{
				}
				if (50 == 0)
				{
				}
				Tile tile;
				ushort wall = tile.wall;
				UnifiedRandom genRand = WorldGen.genRand;
				int num3 = 3;
				if (genRand.Next(num3) == 0)
				{
					long num4 = 0L;
					WorldGen.PlaceTight(num2, 43147264, num4 != 0L);
				}
				Tile tile2;
				bool flag = tile2.active();
				UnifiedRandom genRand2 = WorldGen.genRand;
				int num5 = 10;
				if (genRand2.Next(num5) != 0)
				{
					UnifiedRandom genRand3 = WorldGen.genRand;
					int num6 = 2;
					int num7 = 5;
					int num8 = genRand3.Next(num6, num7);
					long num9 = 0L;
					bool flag2 = WorldGen.SolidTile(0, num6, num9 != 0L);
					return;
				}
			}

			// Token: 0x06002F63 RID: 12131 RVA: 0x001F1C88 File Offset: 0x001EFE88
			internal void <GenerateWorld>b__277_85(GenerationProgress progress, GameConfiguration passConfig)
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
					int num2 = 40;
					if (num == 0)
					{
					}
					if (num == 0)
					{
					}
					Tile tile;
					bool flag = tile.active();
					Tile tile2;
					ushort type = tile2.type;
					UnifiedRandom genRand = WorldGen.genRand;
					int num3 = 15;
					if (genRand.Next(num3) == 0)
					{
						WorldGen.PlacePumpkin(num2, num3);
						UnifiedRandom genRand2 = WorldGen.genRand;
						int num4 = 5;
						int num5 = genRand2.Next(num4);
						int num6 = 254;
						WorldGen.GrowPumpkin(num2, num4, num6);
					}
					return;
				}
				Tile tile3;
				ushort type2 = tile3.type;
				Tile tile4;
				bool flag2 = tile4.nactive();
				Tile tile5;
				bool flag3 = tile5.active();
			}

			// Token: 0x06002F64 RID: 12132 RVA: 0x001F1D90 File Offset: 0x001EFF90
			internal void <GenerateWorld>b__277_86(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				long num2 = 0L;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				Tile tile;
				bool flag = tile.active();
				Tile tile2;
				ushort type = tile2.type;
				long num3 = 0L;
				Tile tile3;
				bool flag2 = tile3.active();
				bool flag3 = WorldGen.GrowTree((int)num2, (int)num3);
				long num4 = 0L;
				Tile tile4;
				bool flag4 = tile4.active();
				bool flag5 = WorldGen.GrowTree((int)num2, (int)num4);
				long num5 = 0L;
				Tile tile5;
				bool flag6 = tile5.active();
				bool flag7 = WorldGen.GrowTree((int)num2, (int)num5);
				Tile tile6;
				bool flag8 = tile6.active();
				Tile tile7;
				ushort type2 = tile7.type;
				Tile tile8;
				bool flag9 = tile8.active();
			}

			// Token: 0x06002F65 RID: 12133 RVA: 0x001F1E1C File Offset: 0x001F001C
			internal void <GenerateWorld>b__277_87(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				UnifiedRandom genRand = WorldGen.genRand;
				int num2 = 40;
				int num3 = WorldGen.genRand.Next(num2);
				Tile tile;
				bool flag = tile.active();
			}

			// Token: 0x06002F66 RID: 12134 RVA: 0x001F1EDC File Offset: 0x001F00DC
			internal void <GenerateWorld>b__277_88(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				int num2 = 5;
				if (num == 0)
				{
				}
				long num3 = 32752L;
				long num4 = 0L;
				Tile tile;
				bool flag = tile.active();
				bool flag2 = WorldGen.GrowMoreVines(num2, (int)num4);
				Tile tile2;
				ushort wall = tile2.wall;
				Tile tile3;
				ushort wall2 = tile3.wall;
				Tile tile4;
				ushort wall3 = tile4.wall;
				Tile tile5;
				ushort wall4 = tile5.wall;
				if (num3 == 0L)
				{
				}
				int num7;
				if (num3 != 0L)
				{
					if (num3 == 0L)
					{
					}
					UnifiedRandom genRand = WorldGen.genRand;
					int num5 = 5;
					int num6 = genRand.Next(num5);
					num7 = 382;
				}
				if (num7 == 0)
				{
				}
				UnifiedRandom genRand2 = WorldGen.genRand;
				int num8 = 5;
				int num9 = genRand2.Next(num8);
				UnifiedRandom genRand3 = WorldGen.genRand;
				int num10 = 1;
				int num11 = 10;
				int num12 = genRand3.Next(num10, num11);
			}

			// Token: 0x06002F67 RID: 12135 RVA: 0x001F2450 File Offset: 0x001F0650
			internal void <GenerateWorld>b__277_89(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				long num2 = 0L;
				if (num == 0)
				{
				}
				UnifiedRandom genRand = WorldGen.genRand;
				int num3 = 100;
				int num4 = genRand.Next(num3, (int)num2);
				UnifiedRandom genRand2 = WorldGen.genRand;
				int num5 = 15;
				int num6 = 30;
				int num7 = genRand2.Next(num5, num6);
				UnifiedRandom genRand3 = WorldGen.genRand;
				int num8 = 15;
				int num9 = 30;
				int num10 = genRand3.Next(num8, num9);
				UnifiedRandom genRand4 = WorldGen.genRand;
				int num11 = 15;
				int num12 = 45;
				int num13 = genRand4.Next(num11, num12);
				UnifiedRandom genRand5 = WorldGen.genRand;
				int num14 = 15;
				int num15 = 45;
				int num16 = genRand5.Next(num14, num15);
				UnifiedRandom genRand6 = WorldGen.genRand;
				long num17 = 32752L;
				int num18 = genRand6.Next(num14, num15);
				if (num17 == 0L)
				{
				}
			}

			// Token: 0x06002F68 RID: 12136 RVA: 0x001F2810 File Offset: 0x001F0A10
			internal void <GenerateWorld>b__277_90(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				long num2 = 0L;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				UnifiedRandom genRand = WorldGen.genRand;
				int num3 = 20;
				int num4 = genRand.Next(num3, (int)num2);
				UnifiedRandom genRand2 = WorldGen.genRand;
				int num5 = 4;
				int num6 = 10;
				int num7 = genRand2.Next(num5, num6);
				UnifiedRandom genRand3 = WorldGen.genRand;
				int num8 = 15;
				int num9 = 30;
				int num10 = genRand3.Next(num8, num9);
				UnifiedRandom genRand4 = WorldGen.genRand;
				int num11 = 8;
				int num12 = 17;
				int num13 = genRand4.Next(num11, num12);
				UnifiedRandom genRand5 = WorldGen.genRand;
				int num14 = 8;
				int num15 = 17;
				int num16 = genRand5.Next(num14, num15);
				UnifiedRandom genRand6 = WorldGen.genRand;
				long num17 = 32752L;
				int num18 = genRand6.Next(num14, num15);
				Tile tile;
				bool flag = tile.active();
				if (num17 == 0L)
				{
				}
				if (num17 == 0L)
				{
				}
				Tile tile2;
				ushort type = tile2.type;
				Tile tile3;
				ushort type2 = tile3.type;
			}

			// Token: 0x06002F69 RID: 12137 RVA: 0x001F2948 File Offset: 0x001F0B48
			internal void <GenerateWorld>b__277_91(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num != 0)
				{
					return;
				}
				UnifiedRandom genRand = WorldGen.genRand;
			}

			// Token: 0x06002F6A RID: 12138 RVA: 0x001F2A50 File Offset: 0x001F0C50
			internal void <GenerateWorld>b__277_92(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				UnifiedRandom genRand = WorldGen.genRand;
				UnifiedRandom genRand2 = WorldGen.genRand;
				Tile tile;
				bool flag = tile.active();
				Tile tile2;
				bool flag2 = tile2.lava();
				Tile tile3;
				ushort wall = tile3.wall;
				Tile tile4;
				ushort wall2 = tile4.wall;
				UnifiedRandom genRand3 = WorldGen.genRand;
				int num2 = 12;
				int num3 = genRand3.Next(num2);
			}

			// Token: 0x06002F6B RID: 12139 RVA: 0x001F2B98 File Offset: 0x001F0D98
			internal void <GenerateWorld>b__277_93(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				Tile tile;
				bool flag = tile.active();
				Tile tile2;
				ushort type = tile2.type;
			}

			// Token: 0x06002F6C RID: 12140 RVA: 0x001F2BDC File Offset: 0x001F0DDC
			internal void <GenerateWorld>b__277_94(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				Tile tile;
				bool flag = tile.active();
				Tile tile2;
				ushort type = tile2.type;
			}

			// Token: 0x06002F6D RID: 12141 RVA: 0x001F2C64 File Offset: 0x001F0E64
			internal void <GenerateWorld>b__277_95(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				int num2 = 1;
				if (num == 0)
				{
				}
				if (num2 == 0)
				{
				}
				int num3 = 1;
				Tile tile;
				tile.active(num3 != 0);
				int num4 = 225;
				tile.type = (ushort)num4;
				long num5 = 0L;
				tile.slope((byte)num5);
				long num6 = 0L;
				tile.halfBrick(num6 != 0L);
			}

			// Token: 0x06002F6E RID: 12142 RVA: 0x001F2CC4 File Offset: 0x001F0EC4
			internal void <GenerateWorld>b__277_96(GenerationProgress progress, GameConfiguration passConfig)
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
				}
				if (num == 0)
				{
				}
				long num2 = 0L;
				if (num == 0)
				{
				}
				if (num != 0)
				{
					if (num == 0)
					{
					}
					WorldGen.NotTheBees();
				}
				if (num == 0)
				{
				}
				int num3 = 1;
				long num4 = 0L;
				Liquid.worldGenTilesIgnoreWater(num3 != 0);
				Liquid.QuickWater(3, (int)num4, (int)num2);
				if (num == 0)
				{
				}
				WorldGen.WaterCheck();
			}

			// Token: 0x06002F6F RID: 12143 RVA: 0x001F2D38 File Offset: 0x001F0F38
			internal void <GenerateWorld>b__277_97(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				int num2 = 8;
				if (num == 0)
				{
				}
				UnifiedRandom genRand = WorldGen.genRand;
				int num3 = 3;
				int num4 = 13;
				int num5 = genRand.Next(num3, num4);
				UnifiedRandom genRand2 = WorldGen.genRand;
				int num6 = 3;
				int num7 = 13;
				int num8 = genRand2.Next(num6, num7);
				UnifiedRandom genRand3 = WorldGen.genRand;
				int num9 = 2;
				int num10 = 6;
				int num11 = genRand3.Next(num9, num10);
				UnifiedRandom genRand4 = WorldGen.genRand;
				int num12 = 2;
				int num13 = 6;
				int num14 = genRand4.Next(num12, num13);
				if (num2 == 0)
				{
				}
				if (32768 == 0)
				{
				}
				long num15 = 0L;
				bool flag = WorldGen.InWorld(0, num12, (int)num15);
				Tile tile;
				bool flag2 = tile.active();
				Tile tile2;
				ushort type = tile2.type;
				UnifiedRandom genRand5 = WorldGen.genRand;
				long num16 = 0L;
				double num17 = genRand5.NextDouble();
				bool flag3 = WorldGen.GrowPalmTree(0, (int)num16);
				bool flag4 = WorldGen.PlantSeaOat(0, (int)num16);
				UnifiedRandom genRand6 = WorldGen.genRand;
				int num18 = 2;
				if (genRand6.Next(num18) == 0)
				{
					bool flag5 = WorldGen.GrowSeaOat(0, num18);
				}
				UnifiedRandom genRand7 = WorldGen.genRand;
				int num19 = 2;
				if (genRand7.Next(num19) == 0)
				{
					bool flag6 = WorldGen.GrowSeaOat(0, num19);
				}
				int num20 = 530;
				WorldGen.PlaceOasisPlant(0, num19, (ushort)num20);
			}

			// Token: 0x06002F70 RID: 12144 RVA: 0x001F3068 File Offset: 0x001F1268
			internal void <GenerateWorld>b__277_98(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
			}

			// Token: 0x06002F71 RID: 12145 RVA: 0x001F353C File Offset: 0x001F173C
			internal void <GenerateWorld>b__277_99(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				int num2 = 1;
				Tile tile;
				tile.active(num2 != 0);
				int num3 = 237;
				tile.type = (ushort)num3;
				if (num == 0)
				{
				}
				int num4 = 1;
				Tile tile2;
				tile2.active(num4 != 0);
				long num5 = 0L;
				tile2.slope((byte)num5);
				long num6 = 0L;
				tile2.halfBrick(num6 != 0L);
				int num7 = 226;
				tile2.type = (ushort)num7;
			}

			// Token: 0x06002F72 RID: 12146 RVA: 0x001F35B0 File Offset: 0x001F17B0
			internal void <GenerateWorld>b__277_100(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				UnifiedRandom genRand = WorldGen.genRand;
				List<int> list;
				if (list._size == 0)
				{
				}
				UnifiedRandom genRand2 = WorldGen.genRand;
				int size = list._size;
				int num2 = genRand2.Next(size);
				UnifiedRandom genRand3 = WorldGen.genRand;
				int num3 = 20;
				int num4 = 50;
				int num5 = 200;
				int num6 = 50;
				Point point = WorldGen.RandomWorldPoint(0, num4, num5, num6);
				if (num3 == 0)
				{
				}
			}

			// Token: 0x06002F73 RID: 12147 RVA: 0x001F37C4 File Offset: 0x001F19C4
			internal void <GenerateWorld>b__277_101(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				long num2 = 32752L;
				if (num2 == 0L)
				{
				}
				if (num2 == 0L || num2 == 0L)
				{
				}
				int num3 = 20;
				if (num2 == 0L)
				{
				}
				int num4 = 1;
				UnifiedRandom genRand = WorldGen.genRand;
				int num5 = 5;
				if (genRand.Next(num5) != 0)
				{
					return;
				}
				Tile tile;
				byte liquid = tile.liquid;
				Tile tile2;
				bool flag = tile2.active();
				UnifiedRandom genRand2 = WorldGen.genRand;
				int num6 = 2;
				if (genRand2.Next(num6) != 0)
				{
					Point point = WorldGen.PlaceCatTail(num3, num4);
					UnifiedRandom genRand3 = WorldGen.genRand;
					int num7 = 14;
					int num8 = genRand3.Next(num7);
					return;
				}
			}

			// Token: 0x06002F74 RID: 12148 RVA: 0x001F38E8 File Offset: 0x001F1AE8
			internal void <GenerateWorld>b__277_102(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num;
				int num2;
				int num3;
				for (;;)
				{
					num = 1;
					num2 = 20;
					if (num == 0)
					{
					}
					if (num == 0)
					{
					}
					if (num == 0)
					{
					}
					if (num != 0)
					{
						break;
					}
					if (num == 0)
					{
					}
					if (num != 0)
					{
						break;
					}
					if (num3 == 0)
					{
					}
					UnifiedRandom genRand = WorldGen.genRand;
					int num4 = 5;
					if (genRand.Next(num4) != 0)
					{
						goto Block_1;
					}
				}
				if (num == 0)
				{
				}
				Tile tile;
				byte liquid = tile.liquid;
				if (num == 0)
				{
				}
				UnifiedRandom genRand2 = WorldGen.genRand;
				int num5 = 7;
				num3 = genRand2.Next(num5);
				bool flag = WorldGen.TryGrowingTreeByType(0, num2, 43147264);
				return;
				Block_1:
				if (num3 == 0)
				{
				}
				bool flag2 = WorldGen.oceanDepths(num2, 43147264);
				if (num3 == 0)
				{
				}
				Tile tile2;
				bool flag3 = tile2.active();
				if (num3 == 0)
				{
				}
				UnifiedRandom genRand3 = WorldGen.genRand;
				int num6 = 5;
				if (genRand3.Next(num6) == 0)
				{
					if (num3 == 0)
					{
					}
					Tile tile3;
					ushort type = tile3.type;
					Tile tile4;
					ushort type2 = tile4.type;
					long num7 = 0L;
					WorldGen.PlaceTight(num2, 43147264, num7 != 0L);
				}
			}

			// Token: 0x06002F75 RID: 12149 RVA: 0x001F3A38 File Offset: 0x001F1C38
			internal void <GenerateWorld>b__277_103(GenerationProgress progress, GameConfiguration passConfig)
			{
				if (!true)
				{
				}
				Tile tile;
				bool flag = tile.wire();
			}

			// Token: 0x06002F76 RID: 12150 RVA: 0x001F3A58 File Offset: 0x001F1C58
			internal void <GenerateWorld>b__277_104(GenerationProgress progress, GameConfiguration passConfig)
			{
				int num = 1;
				if (num == 0)
				{
				}
				int num2 = 32768;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				long num3 = 0L;
				if (num == 0)
				{
				}
				if (num2 == 0)
				{
				}
				long num4 = 0L;
				if (num2 == 0)
				{
				}
				long num5 = 0L;
				Tile tile;
				bool flag = tile.active();
				long num6 = 0L;
				bool flag2 = WorldGen.SolidTile((int)num3, (int)num5, num6 != 0L);
				if (num2 == 0)
				{
				}
				Tile tile2;
				bool flag3 = tile2.active();
				Tile tile3;
				ushort wall = tile3.wall;
				bool flag4 = WorldGen.oceanDepths((int)num3, (int)num4);
				Tile tile4;
				ushort type = tile4.type;
				Tile tile5;
				ushort type2 = tile5.type;
			}

			// Token: 0x040038F6 RID: 14582
			public static readonly WorldGen.<>c <>9;

			// Token: 0x040038F7 RID: 14583
			public static WorldGenLegacyMethod <>9__277_0;

			// Token: 0x040038F8 RID: 14584
			public static WorldGenLegacyMethod <>9__277_1;

			// Token: 0x040038F9 RID: 14585
			public static WorldGenLegacyMethod <>9__277_2;

			// Token: 0x040038FA RID: 14586
			public static WorldGenLegacyMethod <>9__277_3;

			// Token: 0x040038FB RID: 14587
			public static WorldGenLegacyMethod <>9__277_4;

			// Token: 0x040038FC RID: 14588
			public static WorldGenLegacyMethod <>9__277_5;

			// Token: 0x040038FD RID: 14589
			public static WorldGenLegacyMethod <>9__277_6;

			// Token: 0x040038FE RID: 14590
			public static WorldGenLegacyMethod <>9__277_7;

			// Token: 0x040038FF RID: 14591
			public static WorldGenLegacyMethod <>9__277_8;

			// Token: 0x04003900 RID: 14592
			public static WorldGenLegacyMethod <>9__277_9;

			// Token: 0x04003901 RID: 14593
			public static WorldGenLegacyMethod <>9__277_10;

			// Token: 0x04003902 RID: 14594
			public static WorldGenLegacyMethod <>9__277_11;

			// Token: 0x04003903 RID: 14595
			public static WorldGenLegacyMethod <>9__277_12;

			// Token: 0x04003904 RID: 14596
			public static WorldGenLegacyMethod <>9__277_13;

			// Token: 0x04003905 RID: 14597
			public static WorldGenLegacyMethod <>9__277_14;

			// Token: 0x04003906 RID: 14598
			public static WorldGenLegacyMethod <>9__277_15;

			// Token: 0x04003907 RID: 14599
			public static WorldGenLegacyMethod <>9__277_16;

			// Token: 0x04003908 RID: 14600
			public static WorldGenLegacyMethod <>9__277_17;

			// Token: 0x04003909 RID: 14601
			public static WorldGenLegacyMethod <>9__277_18;

			// Token: 0x0400390A RID: 14602
			public static WorldGenLegacyMethod <>9__277_19;

			// Token: 0x0400390B RID: 14603
			public static WorldGenLegacyMethod <>9__277_20;

			// Token: 0x0400390C RID: 14604
			public static WorldGenLegacyMethod <>9__277_21;

			// Token: 0x0400390D RID: 14605
			public static WorldGenLegacyMethod <>9__277_22;

			// Token: 0x0400390E RID: 14606
			public static WorldGenLegacyMethod <>9__277_23;

			// Token: 0x0400390F RID: 14607
			public static WorldGenLegacyMethod <>9__277_24;

			// Token: 0x04003910 RID: 14608
			public static WorldGenLegacyMethod <>9__277_25;

			// Token: 0x04003911 RID: 14609
			public static WorldGenLegacyMethod <>9__277_26;

			// Token: 0x04003912 RID: 14610
			public static WorldGenLegacyMethod <>9__277_27;

			// Token: 0x04003913 RID: 14611
			public static WorldGenLegacyMethod <>9__277_28;

			// Token: 0x04003914 RID: 14612
			public static WorldGenLegacyMethod <>9__277_29;

			// Token: 0x04003915 RID: 14613
			public static WorldGenLegacyMethod <>9__277_30;

			// Token: 0x04003916 RID: 14614
			public static WorldGenLegacyMethod <>9__277_31;

			// Token: 0x04003917 RID: 14615
			public static WorldGenLegacyMethod <>9__277_32;

			// Token: 0x04003918 RID: 14616
			public static WorldGenLegacyMethod <>9__277_33;

			// Token: 0x04003919 RID: 14617
			public static WorldGenLegacyMethod <>9__277_34;

			// Token: 0x0400391A RID: 14618
			public static WorldGenLegacyMethod <>9__277_35;

			// Token: 0x0400391B RID: 14619
			public static WorldGenLegacyMethod <>9__277_36;

			// Token: 0x0400391C RID: 14620
			public static WorldGenLegacyMethod <>9__277_37;

			// Token: 0x0400391D RID: 14621
			public static WorldGenLegacyMethod <>9__277_38;

			// Token: 0x0400391E RID: 14622
			public static WorldGenLegacyMethod <>9__277_39;

			// Token: 0x0400391F RID: 14623
			public static WorldGenLegacyMethod <>9__277_40;

			// Token: 0x04003920 RID: 14624
			public static WorldGenLegacyMethod <>9__277_41;

			// Token: 0x04003921 RID: 14625
			public static WorldGenLegacyMethod <>9__277_42;

			// Token: 0x04003922 RID: 14626
			public static WorldGenLegacyMethod <>9__277_43;

			// Token: 0x04003923 RID: 14627
			public static WorldGenLegacyMethod <>9__277_44;

			// Token: 0x04003924 RID: 14628
			public static WorldGenLegacyMethod <>9__277_45;

			// Token: 0x04003925 RID: 14629
			public static WorldGenLegacyMethod <>9__277_46;

			// Token: 0x04003926 RID: 14630
			public static WorldGenLegacyMethod <>9__277_47;

			// Token: 0x04003927 RID: 14631
			public static WorldGenLegacyMethod <>9__277_48;

			// Token: 0x04003928 RID: 14632
			public static WorldGenLegacyMethod <>9__277_49;

			// Token: 0x04003929 RID: 14633
			public static WorldGenLegacyMethod <>9__277_50;

			// Token: 0x0400392A RID: 14634
			public static WorldGenLegacyMethod <>9__277_51;

			// Token: 0x0400392B RID: 14635
			public static WorldGenLegacyMethod <>9__277_52;

			// Token: 0x0400392C RID: 14636
			public static WorldGenLegacyMethod <>9__277_53;

			// Token: 0x0400392D RID: 14637
			public static WorldGenLegacyMethod <>9__277_54;

			// Token: 0x0400392E RID: 14638
			public static WorldGenLegacyMethod <>9__277_55;

			// Token: 0x0400392F RID: 14639
			public static WorldGenLegacyMethod <>9__277_56;

			// Token: 0x04003930 RID: 14640
			public static WorldGenLegacyMethod <>9__277_57;

			// Token: 0x04003931 RID: 14641
			public static WorldGenLegacyMethod <>9__277_58;

			// Token: 0x04003932 RID: 14642
			public static WorldGenLegacyMethod <>9__277_59;

			// Token: 0x04003933 RID: 14643
			public static WorldGenLegacyMethod <>9__277_60;

			// Token: 0x04003934 RID: 14644
			public static WorldGenLegacyMethod <>9__277_61;

			// Token: 0x04003935 RID: 14645
			public static WorldGenLegacyMethod <>9__277_62;

			// Token: 0x04003936 RID: 14646
			public static WorldGenLegacyMethod <>9__277_63;

			// Token: 0x04003937 RID: 14647
			public static WorldGenLegacyMethod <>9__277_64;

			// Token: 0x04003938 RID: 14648
			public static WorldGenLegacyMethod <>9__277_65;

			// Token: 0x04003939 RID: 14649
			public static WorldGenLegacyMethod <>9__277_66;

			// Token: 0x0400393A RID: 14650
			public static WorldGenLegacyMethod <>9__277_67;

			// Token: 0x0400393B RID: 14651
			public static WorldGenLegacyMethod <>9__277_68;

			// Token: 0x0400393C RID: 14652
			public static WorldGenLegacyMethod <>9__277_69;

			// Token: 0x0400393D RID: 14653
			public static WorldGenLegacyMethod <>9__277_70;

			// Token: 0x0400393E RID: 14654
			public static WorldGenLegacyMethod <>9__277_71;

			// Token: 0x0400393F RID: 14655
			public static WorldGenLegacyMethod <>9__277_72;

			// Token: 0x04003940 RID: 14656
			public static WorldGenLegacyMethod <>9__277_73;

			// Token: 0x04003941 RID: 14657
			public static WorldGenLegacyMethod <>9__277_74;

			// Token: 0x04003942 RID: 14658
			public static WorldGenLegacyMethod <>9__277_75;

			// Token: 0x04003943 RID: 14659
			public static WorldGenLegacyMethod <>9__277_76;

			// Token: 0x04003944 RID: 14660
			public static WorldGenLegacyMethod <>9__277_77;

			// Token: 0x04003945 RID: 14661
			public static WorldGenLegacyMethod <>9__277_78;

			// Token: 0x04003946 RID: 14662
			public static WorldGenLegacyMethod <>9__277_79;

			// Token: 0x04003947 RID: 14663
			public static WorldGenLegacyMethod <>9__277_80;

			// Token: 0x04003948 RID: 14664
			public static WorldGenLegacyMethod <>9__277_81;

			// Token: 0x04003949 RID: 14665
			public static WorldGenLegacyMethod <>9__277_82;

			// Token: 0x0400394A RID: 14666
			public static WorldGenLegacyMethod <>9__277_83;

			// Token: 0x0400394B RID: 14667
			public static WorldGenLegacyMethod <>9__277_84;

			// Token: 0x0400394C RID: 14668
			public static WorldGenLegacyMethod <>9__277_85;

			// Token: 0x0400394D RID: 14669
			public static WorldGenLegacyMethod <>9__277_86;

			// Token: 0x0400394E RID: 14670
			public static WorldGenLegacyMethod <>9__277_87;

			// Token: 0x0400394F RID: 14671
			public static WorldGenLegacyMethod <>9__277_88;

			// Token: 0x04003950 RID: 14672
			public static WorldGenLegacyMethod <>9__277_89;

			// Token: 0x04003951 RID: 14673
			public static WorldGenLegacyMethod <>9__277_90;

			// Token: 0x04003952 RID: 14674
			public static WorldGenLegacyMethod <>9__277_91;

			// Token: 0x04003953 RID: 14675
			public static WorldGenLegacyMethod <>9__277_92;

			// Token: 0x04003954 RID: 14676
			public static WorldGenLegacyMethod <>9__277_93;

			// Token: 0x04003955 RID: 14677
			public static WorldGenLegacyMethod <>9__277_94;

			// Token: 0x04003956 RID: 14678
			public static WorldGenLegacyMethod <>9__277_95;

			// Token: 0x04003957 RID: 14679
			public static WorldGenLegacyMethod <>9__277_96;

			// Token: 0x04003958 RID: 14680
			public static WorldGenLegacyMethod <>9__277_97;

			// Token: 0x04003959 RID: 14681
			public static WorldGenLegacyMethod <>9__277_98;

			// Token: 0x0400395A RID: 14682
			public static WorldGenLegacyMethod <>9__277_99;

			// Token: 0x0400395B RID: 14683
			public static WorldGenLegacyMethod <>9__277_100;

			// Token: 0x0400395C RID: 14684
			public static WorldGenLegacyMethod <>9__277_101;

			// Token: 0x0400395D RID: 14685
			public static WorldGenLegacyMethod <>9__277_102;

			// Token: 0x0400395E RID: 14686
			public static WorldGenLegacyMethod <>9__277_103;

			// Token: 0x0400395F RID: 14687
			public static WorldGenLegacyMethod <>9__277_104;
		}
	}
}
