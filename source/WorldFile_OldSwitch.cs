using System;
using System.IO;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.IO;
using Terraria.Utilities;

// Token: 0x020002E2 RID: 738
internal class WorldFile_OldSwitch
{
	// Token: 0x060010FA RID: 4346 RVA: 0x000546DC File Offset: 0x000528DC
	public static WorldFileData GetAllMetadata(string file)
	{
		long num = 0L;
		byte[] array;
		int num2 = BitConverter.ToInt32(array, (int)num);
		int num3 = 16384;
		long num4 = 0L;
		int num5 = 5;
		if (num3 != 0)
		{
		}
		DateTime now = DateTime.Now;
		if (num4 != 0L)
		{
			throw new OutOfMemoryException();
		}
		if (num5 == 0)
		{
		}
		long num6 = 0L;
		if (num3 != 0)
		{
		}
		if (num6 != 0L)
		{
			throw new OutOfMemoryException();
		}
		DateTime now2 = DateTime.Now;
		long num7 = 0L;
		if (num7 != 0L)
		{
			throw new OutOfMemoryException();
		}
		if (num7 != 0L)
		{
			throw new OutOfMemoryException();
		}
		throw new OutOfMemoryException();
	}

	// Token: 0x060010FB RID: 4347 RVA: 0x000547B8 File Offset: 0x000529B8
	public static byte[] DecompressData(byte[] srcData)
	{
		if (!false)
		{
			if (!false)
			{
			}
			throw new OutOfMemoryException();
		}
		throw new OutOfMemoryException();
	}

	// Token: 0x060010FC RID: 4348 RVA: 0x0005480C File Offset: 0x00052A0C
	public static bool LoadSaveData(byte[] srcData)
	{
		if (!true)
		{
		}
		long num = 0L;
		int num2 = 4;
		if (num == 0L)
		{
			long num3 = 0L;
			if (num2 == 0)
			{
			}
			if (num3 == 0L)
			{
				int num4;
				if (num4 != 0)
				{
				}
				WorldFile_OldSwitch.CleanItemsStoredInTiles();
			}
			throw new OutOfMemoryException();
		}
		throw new OutOfMemoryException();
	}

	// Token: 0x060010FD RID: 4349 RVA: 0x00054874 File Offset: 0x00052A74
	private static void CleanItemsStoredInTiles()
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
		ushort type = tile.type;
		WorldFile_OldSwitch.CheckWeaponsRack((int)num2, (int)num3);
	}

	// Token: 0x060010FE RID: 4350 RVA: 0x000548A8 File Offset: 0x00052AA8
	private static void CheckWeaponsRack(int i, int j)
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
		short frameY2 = tile2.frameY;
		if (num == 0)
		{
		}
		Tile tile3;
		short frameY3 = tile3.frameY;
		if (num == 0)
		{
		}
		Tile tile4;
		short frameX = tile4.frameX;
		int num2 = 36409;
		if (num2 == 0)
		{
		}
		Tile tile5;
		short frameX2 = tile5.frameX;
		if (num2 == 0)
		{
		}
		Tile tile6;
		short frameX3 = tile6.frameX;
		long num3 = 0L;
		Tile tile7;
		tile7.SetFrameX((short)num3);
		int num4 = 18;
		Tile tile8;
		tile8.SetFrameY((short)num4);
	}

	// Token: 0x060010FF RID: 4351 RVA: 0x0005493C File Offset: 0x00052B3C
	public static bool ItemFitsWeaponRack(Item i)
	{
		if (!true || true)
		{
			return;
		}
	}

	// Token: 0x06001100 RID: 4352 RVA: 0x00054950 File Offset: 0x00052B50
	public static void PlaceWeapon(int x, int y, Item item)
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
		if (num == 0)
		{
		}
		Tile tile3;
		short frameY = tile3.frameY;
		if (num == 0)
		{
		}
		Tile tile4;
		short frameY2 = tile4.frameY;
		if (num == 0)
		{
		}
		Tile tile5;
		short frameY3 = tile5.frameY;
		if (num == 0)
		{
		}
		Tile tile6;
		short frameX = tile6.frameX;
		if (36409 == 0)
		{
		}
		Tile tile7;
		short frameX2 = tile7.frameX;
		int netID = item.netID;
		Tile tile8;
		tile8.SetFrameX((short)x);
		byte prefix = item.prefix;
		Tile tile9;
		tile9.SetFrameX((short)x);
	}

	// Token: 0x06001101 RID: 4353 RVA: 0x000549DC File Offset: 0x00052BDC
	private static void CheckMannequin(int i, int j)
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
	}

	// Token: 0x06001102 RID: 4354 RVA: 0x00054A54 File Offset: 0x00052C54
	private static int LoadWorld_Version2(BinaryReader reader)
	{
		return 5;
	}

	// Token: 0x06001103 RID: 4355 RVA: 0x00054A74 File Offset: 0x00052C74
	private static void LoadWeightedPressurePlates(BinaryReader reader)
	{
		if (!true)
		{
		}
		PressurePlateHelper.Reset();
	}

	// Token: 0x06001104 RID: 4356 RVA: 0x00054A8C File Offset: 0x00052C8C
	private static void LoadTownManager(BinaryReader reader)
	{
		if (!true)
		{
		}
	}

	// Token: 0x06001105 RID: 4357 RVA: 0x00054A9C File Offset: 0x00052C9C
	private static void LoadTileEntities(BinaryReader reader)
	{
		if (!true)
		{
		}
		TileEntity.Clear();
		long num = 0L;
		long num2 = 0L;
		TileEntity tileEntity = TileEntity.ReadPos32(reader, num2 != 0L);
		tileEntity.ID = (int)num;
		int positionKey = tileEntity.PositionKey;
		int positionKey2 = tileEntity.PositionKey;
	}

	// Token: 0x06001106 RID: 4358 RVA: 0x00054B5C File Offset: 0x00052D5C
	private static bool LoadFileFormatHeader(BinaryReader reader, [Out] bool[] importance, [Out] int[] positions)
	{
		/*
An exception occurred when decompiling this method (06001106)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean WorldFile_OldSwitch::LoadFileFormatHeader(System.IO.BinaryReader,System.Boolean[],System.Int32[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
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

	// Token: 0x06001107 RID: 4359 RVA: 0x00054B88 File Offset: 0x00052D88
	private static void LoadHeader(BinaryReader reader)
	{
		Guid guid = Guid.NewGuid();
	}

	// Token: 0x06001108 RID: 4360 RVA: 0x00054D40 File Offset: 0x00052F40
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

	// Token: 0x06001109 RID: 4361 RVA: 0x00054E38 File Offset: 0x00053038
	private static void LoadChests(BinaryReader reader)
	{
	}

	// Token: 0x0600110A RID: 4362 RVA: 0x00054E7C File Offset: 0x0005307C
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

	// Token: 0x0600110B RID: 4363 RVA: 0x00054EAC File Offset: 0x000530AC
	private static void LoadSigns(BinaryReader reader)
	{
		Tile tile;
		bool flag = tile.active();
	}

	// Token: 0x0600110C RID: 4364 RVA: 0x00054EE0 File Offset: 0x000530E0
	private static void LoadDummies(BinaryReader reader)
	{
	}

	// Token: 0x0600110D RID: 4365 RVA: 0x00054EF0 File Offset: 0x000530F0
	private static void LoadNPCs(BinaryReader reader)
	{
		Vector2 vector = reader.ReadVector2();
	}

	// Token: 0x0600110E RID: 4366 RVA: 0x00054F04 File Offset: 0x00053104
	private static int LoadFooter(BinaryReader reader)
	{
		return 6;
	}

	// Token: 0x0600110F RID: 4367 RVA: 0x00054F14 File Offset: 0x00053114
	public static int LoadWorld_Version1(BinaryReader fileIO)
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

	// Token: 0x06001110 RID: 4368 RVA: 0x000021DB File Offset: 0x000003DB
	private static int ReadItemID(BinaryReader fileIO)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06001111 RID: 4369 RVA: 0x000552EC File Offset: 0x000534EC
	public WorldFile_OldSwitch()
	{
	}

	// Token: 0x040020D5 RID: 8405
	public const int WorldVersion_AddGUID = 1000;

	// Token: 0x040020D6 RID: 8406
	public const int WorldVersion_CompressWorld = 1001;

	// Token: 0x040020D7 RID: 8407
	public const int WorldVersion_StoreFrameAsRowsAndColumnsInsteadOfPixels = 1002;

	// Token: 0x040020D8 RID: 8408
	public const int WorldVersion_RemoveSectionPointers = 1003;

	// Token: 0x040020D9 RID: 8409
	public const int WorldVersion_1_3_2 = 1004;

	// Token: 0x040020DA RID: 8410
	public const int WorldVersion_1_3_3 = 1005;

	// Token: 0x040020DB RID: 8411
	public const int WorldVersion_1_3_4 = 1007;

	// Token: 0x040020DC RID: 8412
	public const int WorldVersion_RemapConsoleSpecificItems = 1008;

	// Token: 0x040020DD RID: 8413
	public const int WorldVersionOneMaxRelease = 87;

	// Token: 0x040020DE RID: 8414
	public const int WorldFileVersion = 1008;

	// Token: 0x040020DF RID: 8415
	public const int ApproximateWriteSize = 7000000;

	// Token: 0x040020E0 RID: 8416
	public const int MaximumWriteSize = 16777216;

	// Token: 0x040020E1 RID: 8417
	private static int versionNumber;
}
