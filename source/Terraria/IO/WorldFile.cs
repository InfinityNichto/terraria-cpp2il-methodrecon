using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.GameContent.Creative;
using Terraria.GameContent.Tile_Entities;
using Terraria.Utilities;
using UnityEngine;

namespace Terraria.IO
{
	// Token: 0x0200057D RID: 1405
	public class WorldFile
	{
		// Token: 0x1400003E RID: 62
		// (add) Token: 0x0600340C RID: 13324 RVA: 0x0020158C File Offset: 0x001FF78C
		// (remove) Token: 0x0600340D RID: 13325 RVA: 0x002015A8 File Offset: 0x001FF7A8
		public static event Action OnWorldLoad
		{
			[CompilerGenerated]
			add
			{
				if (!true)
				{
				}
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (!true)
				{
				}
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
		}

		// Token: 0x0600340E RID: 13326 RVA: 0x002015C4 File Offset: 0x001FF7C4
		public static void CacheSaveTime()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x0600340F RID: 13327 RVA: 0x002015DC File Offset: 0x001FF7DC
		public static void SetOngoingToTemps()
		{
		}

		// Token: 0x06003410 RID: 13328 RVA: 0x002015EC File Offset: 0x001FF7EC
		public static bool IsValidWorld(string file, bool cloudSave)
		{
			/*
An exception occurred when decompiling this method (06003410)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.IO.WorldFile::IsValidWorld(System.String,System.Boolean)

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

		// Token: 0x06003411 RID: 13329 RVA: 0x002015FC File Offset: 0x001FF7FC
		public static WorldFileData GetTutorialMetadata()
		{
			byte[] bytes = Resources.Load<TextAsset>("Tutorial/World").bytes;
			DateTime now = DateTime.Now;
			long num = 0L;
			int num2 = 18;
			if (num == 0L)
			{
				if (num2 == 0)
				{
				}
				if (!false)
				{
				}
				throw new OutOfMemoryException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06003412 RID: 13330 RVA: 0x00201690 File Offset: 0x001FF890
		public static WorldFileData GetAllMetadata(string file, bool cloudSave)
		{
			WorldFileData worldFileData;
			return worldFileData;
		}

		// Token: 0x06003413 RID: 13331 RVA: 0x00201738 File Offset: 0x001FF938
		public static WorldFileData CreateMetadata(string name, bool cloudSave, int GameMode)
		{
			/*
An exception occurred when decompiling this method (06003413)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.IO.WorldFileData Terraria.IO.WorldFile::CreateMetadata(System.String,System.Boolean,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:DateTime(var_5_0F, callgetter:DateTime(DateTime::get_Now))
	stloc:FileMetadata(var_6_17, call:FileMetadata(FileMetadata::FromCurrentSettings, ldc.i4:FileType(2)))
	stloc:Guid(var_9_24, call:Guid(Guid::NewGuid))
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

		// Token: 0x06003414 RID: 13332 RVA: 0x0020176C File Offset: 0x001FF96C
		public static void ResetTemps()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Main.anglerQuestFinished = false;
		}

		// Token: 0x06003415 RID: 13333 RVA: 0x0020178C File Offset: 0x001FF98C
		private static void ClearTempTiles()
		{
			int num = 1;
			if (num == 0)
			{
			}
			long num2 = 0L;
			long num3 = 0L;
			if (num == 0)
			{
			}
			long num4 = 0L;
			long num5 = 0L;
			long num6 = 0L;
			WorldGen.KillTile((int)num3, (int)num2, num4 != 0L, num5 != 0L, num6 != 0L);
		}

		// Token: 0x06003416 RID: 13334 RVA: 0x002017BC File Offset: 0x001FF9BC
		private static void ReregisterTiles()
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
				tile.ReregisterTile();
			}
		}

		// Token: 0x06003417 RID: 13335 RVA: 0x002017E0 File Offset: 0x001FF9E0
		public static void LoadTutorialOnMainThread(object threadContext)
		{
			byte[] bytes = Resources.Load<TextAsset>("Tutorial/World").bytes;
		}

		// Token: 0x06003418 RID: 13336 RVA: 0x00201800 File Offset: 0x001FFA00
		public static void LoadWorld(bool loadFromCloud)
		{
			Main.checkXMas();
			Main.checkHalloween();
		}

		// Token: 0x06003419 RID: 13337 RVA: 0x00201B5C File Offset: 0x001FFD5C
		public static void CheckSavedOreTiers()
		{
			if (!true)
			{
			}
		}

		// Token: 0x0600341A RID: 13338 RVA: 0x00201BB4 File Offset: 0x001FFDB4
		public static void SaveWorld(WorldFile.WorldSaveContext saveContext = WorldFile.WorldSaveContext.Normal)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			long num2 = 0L;
			WorldFile.SaveWorld(true, num2 != 0L, saveContext);
			if (num == 0)
			{
			}
		}

		// Token: 0x0600341B RID: 13339 RVA: 0x00201BEC File Offset: 0x001FFDEC
		public static void SaveWorld(bool useCloudSaving, bool resetTime = false, WorldFile.WorldSaveContext saveContext = WorldFile.WorldSaveContext.Normal)
		{
			if (!true)
			{
			}
			if ("World" == null)
			{
			}
			string text = DateTime.Now.ToString() + " Saving the world";
			Debug.Log(text);
			if (text != null)
			{
				string text3;
				string text2 = text + " " + text3 + "%";
				Thread.Sleep(0);
				return;
			}
			long num = 0L;
			int num2 = 14;
			if (num != 0L)
			{
				throw new OutOfMemoryException();
			}
			if (num2 == 0)
			{
				Debug.Log(DateTime.Now.ToString() + " World saving locked out");
				long num3 = 0L;
				Thread.Sleep((int)num3);
				return;
			}
		}

		// Token: 0x0600341C RID: 13340 RVA: 0x00201C8C File Offset: 0x001FFE8C
		private static void InternalSaveWorld(bool useCloudSaving, bool resetTime)
		{
			for (;;)
			{
				int num = 1;
				if (num == 0)
				{
				}
				string worldPath = Main.WorldPath;
				if (num == 0)
				{
				}
				FileUtilities.CreateDirectory(worldPath);
				if (num == 0)
				{
				}
				if (num != 0)
				{
					break;
				}
				if (num != 0)
				{
					if (num != 0)
					{
						goto Block_2;
					}
				}
				else
				{
					while (worldPath != null)
					{
					}
				}
				WorldFile.SetTempToOngoing();
				if (num == 0)
				{
				}
				WorldFile.ResetTempsToDayTime();
				if (num == 0)
				{
				}
				if (Main.worldPathName != null)
				{
					return;
				}
			}
			return;
			Block_2:
			WorldFile.SetTempToCache();
		}

		// Token: 0x0600341D RID: 13341 RVA: 0x00201E58 File Offset: 0x00200058
		public static bool RenameWorld(string newName, bool useCloudSaving = false)
		{
			if (!true)
			{
			}
			string worldPathName = Main.worldPathName;
			long num = 0L;
			int num2 = 4;
			long num3 = 0L;
			if (num != 0L)
			{
				throw new OutOfMemoryException();
			}
			int num4;
			if (num2 == 0)
			{
				num4 = 11;
			}
			if (false)
			{
				throw new OutOfMemoryException();
			}
			int num5;
			if (num4 == 0)
			{
				num5 = 12;
			}
			if (!false)
			{
				int num6;
				if (num5 == 0)
				{
					num6 = 13;
				}
				if (!false)
				{
					if (num6 == 0)
					{
						string worldPathName2 = Main.worldPathName;
						byte[] array = FileUtilities.ReadAllBytes(Main.worldPathName, num3 != 0L);
						byte[] array2;
						if (array2 != null)
						{
							string text = Main.worldPathName + ".bak";
							if (".bak" == null)
							{
							}
							if (".bak" == null)
							{
							}
							string worldPathName3 = Main.worldPathName;
						}
						long num7 = 0L;
						long num8 = 0L;
						int num9 = 20;
						if (num8 != 0L)
						{
							throw new OutOfMemoryException();
						}
						int num10;
						if (num9 == 0)
						{
							num10 = 21;
						}
						if (false)
						{
							throw new OutOfMemoryException();
						}
						if (num10 == 0 && array2 != null && num7 != 0L)
						{
							goto IL_00D9;
						}
					}
					throw new OutOfMemoryException();
				}
				IL_00D9:
				throw new OutOfMemoryException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600341E RID: 13342 RVA: 0x00202018 File Offset: 0x00200218
		public static bool RenameWorldUsingLoadAndSave(string newName)
		{
			/*
An exception occurred when decompiling this method (0600341E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.IO.WorldFile::RenameWorldUsingLoadAndSave(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	callsetter:int32(Main::set_menuMode, ldc.i4:int32(10))
	brtrue(IL_0000, ldc.i4:bool(0))
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

		// Token: 0x0600341F RID: 13343 RVA: 0x00202034 File Offset: 0x00200234
		private static void RenameWorldCheck()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003420 RID: 13344 RVA: 0x0020204C File Offset: 0x0020024C
		private static void RenameWorldUsingLoadAndSave()
		{
			DrPlatform.Switch.CPUBoostMode = true;
		}

		// Token: 0x06003421 RID: 13345 RVA: 0x00202064 File Offset: 0x00200264
		private static void renameWorldCallBack(object threadContext)
		{
			int num = 1;
			if (threadContext != null)
			{
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
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
					WorldFile.SetOngoingToTemps();
					WorldFile.CacheSaveTime();
				}
				Main.menuMode = 6;
				DrPlatform.Switch.CPUBoostMode = false;
				return;
			}
		}

		// Token: 0x06003422 RID: 13346 RVA: 0x002020AC File Offset: 0x002002AC
		private static void DoRollingBackups(string backupWorldWritePath)
		{
			if (!true)
			{
			}
			int num = 9;
			string text2;
			string text = backupWorldWritePath + text2;
			string text4;
			string text3 = backupWorldWritePath + text4;
			string text6;
			string text5 = backupWorldWritePath + text6;
			if (num == 0)
			{
			}
		}

		// Token: 0x06003423 RID: 13347 RVA: 0x002020E4 File Offset: 0x002002E4
		private static void ResetTempsToDayTime()
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
				if (num == 0)
				{
				}
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06003424 RID: 13348 RVA: 0x0020210C File Offset: 0x0020030C
		private static void SetTempToOngoing()
		{
		}

		// Token: 0x06003425 RID: 13349 RVA: 0x000021DB File Offset: 0x000003DB
		private static void SetTempToCache()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003426 RID: 13350 RVA: 0x0020211C File Offset: 0x0020031C
		private static void ConvertMannequin(int px, int py)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int num2 = 5;
			bool flag = WorldGen.InWorld(px, py, num2);
			if (num == 0)
			{
			}
			Tile tile;
			short frameX = tile.frameX;
			Tile tile2;
			short frameX2 = tile2.frameX;
			Tile tile3;
			short frameX3 = tile3.frameX;
			Tile tile4;
			short frameX4 = tile4.frameX;
			int num3 = TEDisplayDoll.Place(px, py);
		}

		// Token: 0x06003427 RID: 13351 RVA: 0x00202180 File Offset: 0x00200380
		private static void ConvertWeaponRack(int px, int py)
		{
			int num = 1;
			if (num == 0)
			{
			}
			long num2 = 0L;
			bool flag = WorldGen.InWorld(px, py, (int)num2);
			if (num == 0)
			{
			}
			Tile tile;
			short frameX = tile.frameX;
			Tile tile2;
			short frameX2 = tile2.frameX;
			Tile tile3;
			short frameX3 = tile3.frameX;
			long num3 = 0L;
			int num4 = 471;
			Tile tile4;
			tile4.type = (ushort)num4;
			tile4.frameX = frameX2;
			tile4.frameY = frameX2;
			long num5 = 0L;
			int num6 = TEWeaponsRack.Place(px, py);
			int num7 = 1;
			TEWeaponsRack.TryPlacing(px, py, (int)num5, (int)num3, num7);
		}

		// Token: 0x06003428 RID: 13352 RVA: 0x00202214 File Offset: 0x00200414
		private static void ConvertOldTileEntities()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003429 RID: 13353 RVA: 0x00202260 File Offset: 0x00200460
		private static void SaveWorld_Version2(BinaryWriter writer)
		{
			int num = WorldFile.SaveFileFormatHeader(writer);
			int num2 = WorldFile.SaveWorldHeader(writer);
			int num3 = WorldFile.SaveWorldTilesFast(writer);
			int num4 = WorldFile.SaveChests(writer);
			int num5 = WorldFile.SaveSigns(writer);
			int num6 = WorldFile.SaveNPCs(writer);
			int num7 = WorldFile.SaveTileEntities(writer);
			int num8 = WorldFile.SaveWeightedPressurePlates(writer);
			int num9 = WorldFile.SaveTownManager(writer);
			int num10 = WorldFile.SaveBestiary(writer);
			int num11 = WorldFile.SaveCreativePowers(writer);
			int num12 = WorldFile.SaveFooter(writer);
		}

		// Token: 0x0600342A RID: 13354 RVA: 0x002022CC File Offset: 0x002004CC
		private static int SaveFileFormatHeader(BinaryWriter writer)
		{
			/*
An exception occurred when decompiling this method (0600342A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.IO.WorldFile::SaveFileFormatHeader(System.IO.BinaryWriter)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0005:
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

		// Token: 0x0600342B RID: 13355 RVA: 0x002022E4 File Offset: 0x002004E4
		private static int SaveHeaderPointers(BinaryWriter writer, int[] pointers)
		{
			/*
An exception occurred when decompiling this method (0600342B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.IO.WorldFile::SaveHeaderPointers(System.IO.BinaryWriter,System.Int32[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8[](var_0_06, ldfld:uint8[](BinaryWriter::_buffer, ldloc:BinaryWriter(writer)))
	stloc:uint8[](var_1_0D, ldfld:uint8[](BinaryWriter::_buffer, ldloc:BinaryWriter(writer)))
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

		// Token: 0x0600342C RID: 13356 RVA: 0x00202300 File Offset: 0x00200500
		private static int SaveWorldHeader(BinaryWriter writer)
		{
			/*
An exception occurred when decompiling this method (0600342C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.IO.WorldFile::SaveWorldHeader(System.IO.BinaryWriter)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_2_0A, callgetter:int32(Main::get_GameMode))
	stloc:int32(var_5_13, callgetter:int32(Main::get_spawnTileX))
	stloc:int32(var_7_1D, callgetter:int32(Main::get_spawnTileY))
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

		// Token: 0x0600342D RID: 13357 RVA: 0x00202338 File Offset: 0x00200538
		private static int SaveWorldTilesFast(BinaryWriter writer)
		{
			/*
An exception occurred when decompiling this method (0600342D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.IO.WorldFile::SaveWorldTilesFast(System.IO.BinaryWriter)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	brtrue(IL_0000, ldc.i4:bool(0))
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

		// Token: 0x0600342E RID: 13358 RVA: 0x0020237C File Offset: 0x0020057C
		public static int SaveWorldTiles(BinaryWriter writer)
		{
			/*
An exception occurred when decompiling this method (0600342E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.IO.WorldFile::SaveWorldTiles(System.IO.BinaryWriter)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0050:
	brtrue(IL_0000, ldloc:int32[exp:bool](var_14_2B))
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

		// Token: 0x0600342F RID: 13359 RVA: 0x002023DC File Offset: 0x002005DC
		private static int SaveChests(BinaryWriter writer)
		{
			/*
An exception occurred when decompiling this method (0600342F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.IO.WorldFile::SaveChests(System.IO.BinaryWriter)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000A:
	stloc:bool(var_3_10, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_2)))
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

		// Token: 0x06003430 RID: 13360 RVA: 0x00202410 File Offset: 0x00200610
		private static int SaveSigns(BinaryWriter writer)
		{
			/*
An exception occurred when decompiling this method (06003430)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.IO.WorldFile::SaveSigns(System.IO.BinaryWriter)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	brtrue(IL_0000, logicnot:bool(ldloc:int64[exp:bool](var_1_03)))
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

		// Token: 0x06003431 RID: 13361 RVA: 0x00202434 File Offset: 0x00200634
		private static int SaveNPCs(BinaryWriter writer)
		{
			/*
An exception occurred when decompiling this method (06003431)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.IO.WorldFile::SaveNPCs(System.IO.BinaryWriter)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0011:
	stloc:BitsByte(var_5_1C, call:BitsByte(BitsByte::op_Implicit, ldc.i4:uint8(0)))
	stloc:int64(var_6_1F, ldc.i4:int64(0))
	stloc:bool(var_7_2A, callgetter:bool(BitsByte::get_Item, ldloc:BitsByte[exp:valuetype Terraria.BitsByte&](var_5_1C), ldloc:int64[exp:int32](var_6_1F)))
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

		// Token: 0x06003432 RID: 13362 RVA: 0x00202470 File Offset: 0x00200670
		private static int SaveFooter(BinaryWriter writer)
		{
			/*
An exception occurred when decompiling this method (06003432)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.IO.WorldFile::SaveFooter(System.IO.BinaryWriter)

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

		// Token: 0x06003433 RID: 13363 RVA: 0x00202480 File Offset: 0x00200680
		private static int LoadWorld_Version2(BinaryReader reader)
		{
			int num = 18;
			Tile tile;
			ushort type = tile.type;
			int num2 = 63538;
			Tile tile2;
			ushort type2 = tile2.type;
			if (num2 != 0)
			{
				return num;
			}
			if (num2 == 0)
			{
			}
			WorldFile.LoadBestiaryForVersionsBefore210();
			if (num2 == 0)
			{
			}
			WorldFile.LoadWorld_LastMinuteFixes();
			int num3;
			return num3;
		}

		// Token: 0x06003434 RID: 13364 RVA: 0x002024F4 File Offset: 0x002006F4
		private static void LoadWorld_LastMinuteFixes()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			WorldFile.ConvertIlluminantPaintToNewField();
			if (!true)
			{
			}
			WorldFile.FixAgainstExploits();
		}

		// Token: 0x06003435 RID: 13365 RVA: 0x00202514 File Offset: 0x00200714
		private static void FixAgainstExploits()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06003436 RID: 13366 RVA: 0x00202548 File Offset: 0x00200748
		public static bool LoadFileFormatHeader(BinaryReader reader, [Out] bool[] importance, [Out] int[] positions, [Out] int positionsOffset)
		{
			/*
An exception occurred when decompiling this method (06003436)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.IO.WorldFile::LoadFileFormatHeader(System.IO.BinaryReader,System.Boolean[],System.Int32[],System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000D:
	call:void(Console::WriteLine, call:string(Language::GetTextValue, ldstr:string("Error.UnableToLoadWorld")))
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

		// Token: 0x06003437 RID: 13367 RVA: 0x00202574 File Offset: 0x00200774
		private static void LoadHeader(BinaryReader reader)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003438 RID: 13368 RVA: 0x00202814 File Offset: 0x00200A14
		private static void LoadWorldTiles(BinaryReader reader, bool[] importance)
		{
			if (!true)
			{
			}
			int num = 32768;
			string text2;
			string text = text2 + " " + text2 + "%";
			if (num == 0)
			{
			}
		}

		// Token: 0x06003439 RID: 13369 RVA: 0x00202898 File Offset: 0x00200A98
		private static void LoadChests(BinaryReader reader)
		{
		}

		// Token: 0x0600343A RID: 13370 RVA: 0x002028E4 File Offset: 0x00200AE4
		private static void ConvertIlluminantPaintToNewField()
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

		// Token: 0x0600343B RID: 13371 RVA: 0x00202914 File Offset: 0x00200B14
		private static void LoadSigns(BinaryReader reader)
		{
			Tile tile;
			bool flag = tile.active();
		}

		// Token: 0x0600343C RID: 13372 RVA: 0x00202948 File Offset: 0x00200B48
		private static void LoadDummies(BinaryReader reader)
		{
		}

		// Token: 0x0600343D RID: 13373 RVA: 0x00202958 File Offset: 0x00200B58
		private static void LoadNPCs(BinaryReader reader)
		{
			if (!true)
			{
			}
		}

		// Token: 0x0600343E RID: 13374 RVA: 0x002029D4 File Offset: 0x00200BD4
		private static void ValidateLoadNPCs(BinaryReader fileIO)
		{
		}

		// Token: 0x0600343F RID: 13375 RVA: 0x002029F0 File Offset: 0x00200BF0
		private static int LoadFooter(BinaryReader reader)
		{
			return 6;
		}

		// Token: 0x06003440 RID: 13376 RVA: 0x00202A00 File Offset: 0x00200C00
		private static bool ValidateWorld(BinaryReader fileIO)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06003441 RID: 13377 RVA: 0x00202A94 File Offset: 0x00200C94
		private static FileMetadata GetFileMetadata(string file, bool cloudSave)
		{
			if (true)
			{
			}
			FileMetadata fileMetadata;
			return fileMetadata;
		}

		// Token: 0x06003442 RID: 13378 RVA: 0x00202AF0 File Offset: 0x00200CF0
		private static void FixDresserChests()
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
			int num4 = Chest.CreateChest((int)num2, (int)num3, (int)num3);
		}

		// Token: 0x06003443 RID: 13379 RVA: 0x00202B20 File Offset: 0x00200D20
		private static int SaveTileEntities(BinaryWriter writer)
		{
			if (!true)
			{
			}
			if (false)
			{
				throw new OutOfMemoryException();
			}
			long num = 0L;
			if (4 == 0)
			{
			}
			if (num == 0L)
			{
				return 43147264;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06003444 RID: 13380 RVA: 0x00202B70 File Offset: 0x00200D70
		private static void LoadTileEntities(BinaryReader reader)
		{
			if (!true)
			{
			}
			long num = 0L;
			long num2 = 0L;
			TileEntity tileEntity = TileEntity.Read(reader, num2 != 0L);
			tileEntity.ID = (int)num;
			int positionKey = tileEntity.PositionKey;
			int positionKey2 = tileEntity.PositionKey;
		}

		// Token: 0x06003445 RID: 13381 RVA: 0x00202C28 File Offset: 0x00200E28
		private static int SaveWeightedPressurePlates(BinaryWriter writer)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (false)
			{
				throw new OutOfMemoryException();
			}
			long num = 0L;
			if (4 == 0)
			{
			}
			if (num == 0L)
			{
				return 43147264;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06003446 RID: 13382 RVA: 0x00202C78 File Offset: 0x00200E78
		private static void LoadWeightedPressurePlates(BinaryReader reader)
		{
			if (!true)
			{
			}
			PressurePlateHelper.Reset();
		}

		// Token: 0x06003447 RID: 13383 RVA: 0x00202C90 File Offset: 0x00200E90
		private static int SaveTownManager(BinaryWriter writer)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06003448 RID: 13384 RVA: 0x00202CA4 File Offset: 0x00200EA4
		private static void LoadTownManager(BinaryReader reader)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003449 RID: 13385 RVA: 0x00202CB4 File Offset: 0x00200EB4
		private static int SaveBestiary(BinaryWriter writer)
		{
			/*
An exception occurred when decompiling this method (06003449)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.IO.WorldFile::SaveBestiary(System.IO.BinaryWriter)

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

		// Token: 0x0600344A RID: 13386 RVA: 0x00202CC4 File Offset: 0x00200EC4
		private static void LoadBestiary(BinaryReader reader, int loadVersionNumber)
		{
			if (!true)
			{
			}
		}

		// Token: 0x0600344B RID: 13387 RVA: 0x00202CD4 File Offset: 0x00200ED4
		private static void LoadBestiaryForVersionsBefore210()
		{
			if (!true)
			{
			}
		}

		// Token: 0x0600344C RID: 13388 RVA: 0x00202CE4 File Offset: 0x00200EE4
		private static int SaveCreativePowers(BinaryWriter writer)
		{
			/*
An exception occurred when decompiling this method (0600344C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.IO.WorldFile::SaveCreativePowers(System.IO.BinaryWriter)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(CreativePowerManager::SaveToWorld, callgetter:CreativePowerManager(CreativePowerManager::get_Instance), ldloc:BinaryWriter(writer))
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

		// Token: 0x0600344D RID: 13389 RVA: 0x00202D00 File Offset: 0x00200F00
		private static void LoadCreativePowers(BinaryReader reader, int loadVersionNumber)
		{
			CreativePowerManager.Instance.LoadFromWorld(reader, loadVersionNumber);
		}

		// Token: 0x0600344E RID: 13390 RVA: 0x00202D1C File Offset: 0x00200F1C
		private static int LoadWorld_Version1_Old_BeforeRelease88(BinaryReader fileIO)
		{
			if (!true)
			{
			}
			int num = 257;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Main.GameMode = 0;
			UnifiedRandom genRand = WorldGen.genRand;
			long num2 = 0L;
			WorldGen.RandomizeMoonState(genRand, num2 != 0L);
			return 1;
		}

		// Token: 0x0600344F RID: 13391 RVA: 0x00203024 File Offset: 0x00201224
		public WorldFile()
		{
		}

		// Token: 0x06003450 RID: 13392 RVA: 0x00203038 File Offset: 0x00201238
		// Note: this type is marked as 'beforefieldinit'.
		static WorldFile()
		{
		}

		// Token: 0x040040D9 RID: 16601
		[CompilerGenerated]
		private static Action OnWorldLoad;

		// Token: 0x040040DA RID: 16602
		private static readonly object IOLock;

		// Token: 0x040040DB RID: 16603
		public static double _tempTime;

		// Token: 0x040040DC RID: 16604
		public static bool _tempRaining;

		// Token: 0x040040DD RID: 16605
		public static float _tempMaxRain;

		// Token: 0x040040DE RID: 16606
		public static int _tempRainTime;

		// Token: 0x040040DF RID: 16607
		public static bool _tempDayTime;

		// Token: 0x040040E0 RID: 16608
		public static bool _tempBloodMoon;

		// Token: 0x040040E1 RID: 16609
		public static bool _tempEclipse;

		// Token: 0x040040E2 RID: 16610
		public static int _tempMoonPhase;

		// Token: 0x040040E3 RID: 16611
		public static int _tempCultistDelay;

		// Token: 0x040040E4 RID: 16612
		public static int _versionNumber;

		// Token: 0x040040E5 RID: 16613
		public static bool _isWorldOnCloud;

		// Token: 0x040040E6 RID: 16614
		public static bool _tempPartyGenuine;

		// Token: 0x040040E7 RID: 16615
		public static bool _tempPartyManual;

		// Token: 0x040040E8 RID: 16616
		public static int _tempPartyCooldown;

		// Token: 0x040040E9 RID: 16617
		public static readonly List<int> TempPartyCelebratingNPCs;

		// Token: 0x040040EA RID: 16618
		private static bool _hasCache;

		// Token: 0x040040EB RID: 16619
		private static bool? _cachedDayTime;

		// Token: 0x040040EC RID: 16620
		private static double? _cachedTime;

		// Token: 0x040040ED RID: 16621
		private static int? _cachedMoonPhase;

		// Token: 0x040040EE RID: 16622
		private static bool? _cachedBloodMoon;

		// Token: 0x040040EF RID: 16623
		private static bool? _cachedEclipse;

		// Token: 0x040040F0 RID: 16624
		private static int? _cachedCultistDelay;

		// Token: 0x040040F1 RID: 16625
		private static bool? _cachedPartyGenuine;

		// Token: 0x040040F2 RID: 16626
		private static bool? _cachedPartyManual;

		// Token: 0x040040F3 RID: 16627
		private static int? _cachedPartyDaysOnCooldown;

		// Token: 0x040040F4 RID: 16628
		private static readonly List<int> CachedCelebratingNPCs;

		// Token: 0x040040F5 RID: 16629
		private static bool? _cachedSandstormHappening;

		// Token: 0x040040F6 RID: 16630
		public static bool _tempSandstormHappening;

		// Token: 0x040040F7 RID: 16631
		private static int? _cachedSandstormTimeLeft;

		// Token: 0x040040F8 RID: 16632
		public static int _tempSandstormTimeLeft;

		// Token: 0x040040F9 RID: 16633
		private static float? _cachedSandstormSeverity;

		// Token: 0x040040FA RID: 16634
		public static float _tempSandstormSeverity;

		// Token: 0x040040FB RID: 16635
		private static float? _cachedSandstormIntendedSeverity;

		// Token: 0x040040FC RID: 16636
		public static float _tempSandstormIntendedSeverity;

		// Token: 0x040040FD RID: 16637
		public static bool _tempLanternNightGenuine;

		// Token: 0x040040FE RID: 16638
		public static bool _tempLanternNightManual;

		// Token: 0x040040FF RID: 16639
		public static bool _tempLanternNightNextNightIsGenuine;

		// Token: 0x04004100 RID: 16640
		public static int _tempLanternNightCooldown;

		// Token: 0x04004101 RID: 16641
		private static bool? _cachedLanternNightGenuine;

		// Token: 0x04004102 RID: 16642
		private static bool? _cachedLanternNightManual;

		// Token: 0x04004103 RID: 16643
		private static bool? _cachedLanternNightNextNightIsGenuine;

		// Token: 0x04004104 RID: 16644
		private static int? _cachedLanternNightCooldown;

		// Token: 0x04004105 RID: 16645
		public static Exception LastThrownLoadException;

		// Token: 0x04004106 RID: 16646
		private static byte[] TutorialWorldData;

		// Token: 0x04004107 RID: 16647
		private static bool PendingSaveAndExit;

		// Token: 0x04004108 RID: 16648
		public static bool SavingWorld;

		// Token: 0x04004109 RID: 16649
		public static bool RequireConvertOldTileEntities;

		// Token: 0x0400410A RID: 16650
		public static bool RequireClearTempTiles;

		// Token: 0x0200057E RID: 1406
		public enum WorldSaveContext
		{
			// Token: 0x0400410C RID: 16652
			Normal,
			// Token: 0x0400410D RID: 16653
			SaveAndExit
		}

		// Token: 0x0200057F RID: 1407
		public static class TilePacker
		{
			// Token: 0x0400410E RID: 16654
			public const int Header1_1 = 1;

			// Token: 0x0400410F RID: 16655
			public const int Header1_2 = 2;

			// Token: 0x04004110 RID: 16656
			public const int Header1_4 = 4;

			// Token: 0x04004111 RID: 16657
			public const int Header1_8 = 8;

			// Token: 0x04004112 RID: 16658
			public const int Header1_10 = 16;

			// Token: 0x04004113 RID: 16659
			public const int Header1_18 = 24;

			// Token: 0x04004114 RID: 16660
			public const int Header1_20 = 32;

			// Token: 0x04004115 RID: 16661
			public const int Header1_40 = 64;

			// Token: 0x04004116 RID: 16662
			public const int Header1_80 = 128;

			// Token: 0x04004117 RID: 16663
			public const int Header1_C0 = 192;

			// Token: 0x04004118 RID: 16664
			public const int Header2_1 = 1;

			// Token: 0x04004119 RID: 16665
			public const int Header2_2 = 2;

			// Token: 0x0400411A RID: 16666
			public const int Header2_4 = 4;

			// Token: 0x0400411B RID: 16667
			public const int Header2_8 = 8;

			// Token: 0x0400411C RID: 16668
			public const int Header2_10 = 16;

			// Token: 0x0400411D RID: 16669
			public const int Header2_20 = 32;

			// Token: 0x0400411E RID: 16670
			public const int Header2_40 = 64;

			// Token: 0x0400411F RID: 16671
			public const int Header2_70 = 112;

			// Token: 0x04004120 RID: 16672
			public const int Header2_80 = 128;

			// Token: 0x04004121 RID: 16673
			public const int Header3_1 = 1;

			// Token: 0x04004122 RID: 16674
			public const int Header3_2 = 2;

			// Token: 0x04004123 RID: 16675
			public const int Header3_4 = 4;

			// Token: 0x04004124 RID: 16676
			public const int Header3_8 = 8;

			// Token: 0x04004125 RID: 16677
			public const int Header3_10 = 16;

			// Token: 0x04004126 RID: 16678
			public const int Header3_20 = 32;

			// Token: 0x04004127 RID: 16679
			public const int Header3_40 = 64;

			// Token: 0x04004128 RID: 16680
			public const int Header3_80 = 128;

			// Token: 0x04004129 RID: 16681
			public const int Header4_1 = 1;

			// Token: 0x0400412A RID: 16682
			public const int Header4_2 = 2;

			// Token: 0x0400412B RID: 16683
			public const int Header4_4 = 4;

			// Token: 0x0400412C RID: 16684
			public const int Header4_8 = 8;

			// Token: 0x0400412D RID: 16685
			public const int Header4_10 = 16;

			// Token: 0x0400412E RID: 16686
			public const int Header4_20 = 32;

			// Token: 0x0400412F RID: 16687
			public const int Header4_40 = 64;

			// Token: 0x04004130 RID: 16688
			public const int Header4_80 = 128;
		}
	}
}
