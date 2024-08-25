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

// Token: 0x020002E0 RID: 736
internal class WorldFile_OldConsole
{
	// Token: 0x060010DD RID: 4317 RVA: 0x00053794 File Offset: 0x00051994
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
		if (num3 != 0)
		{
		}
		if (num7 != 0L)
		{
			throw new OutOfMemoryException();
		}
		if (num3 != 0)
		{
		}
		if (num7 != 0L)
		{
			throw new OutOfMemoryException();
		}
	}

	// Token: 0x060010DE RID: 4318 RVA: 0x0005388C File Offset: 0x00051A8C
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

	// Token: 0x060010DF RID: 4319 RVA: 0x000538E0 File Offset: 0x00051AE0
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
				WorldFile_OldConsole.CleanItemsStoredInTiles();
			}
			throw new OutOfMemoryException();
		}
		throw new OutOfMemoryException();
	}

	// Token: 0x060010E0 RID: 4320 RVA: 0x00053948 File Offset: 0x00051B48
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
		WorldFile_OldConsole.CheckWeaponsRack((int)num2, (int)num3);
	}

	// Token: 0x060010E1 RID: 4321 RVA: 0x0005397C File Offset: 0x00051B7C
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
		if (36409 == 0)
		{
		}
		Tile tile5;
		short frameX2 = tile5.frameX;
		Tile tile6;
		if (tile6.frameX == 0)
		{
		}
		long num2 = 0L;
		Tile tile7;
		tile7.SetFrameX((short)num2);
		int num3 = 18;
		Tile tile8;
		tile8.SetFrameY((short)num3);
	}

	// Token: 0x060010E2 RID: 4322 RVA: 0x00053A0C File Offset: 0x00051C0C
	public static bool ItemFitsWeaponRack(Item i)
	{
		if (!true || true)
		{
			return;
		}
	}

	// Token: 0x060010E3 RID: 4323 RVA: 0x00053A20 File Offset: 0x00051C20
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

	// Token: 0x060010E4 RID: 4324 RVA: 0x00053AAC File Offset: 0x00051CAC
	private static void CheckMannequin(int i, int j)
	{
		int num = 1;
		if (num == 0)
		{
		}
		Tile tile;
		short frameX = tile.frameX;
		int num2 = 34079;
		if (num == 0)
		{
		}
		Tile tile2;
		bool flag = ItemConversion_OldConsole.ModifyBodySlot((int)tile2.frameY);
		if (num2 == 0)
		{
		}
	}

	// Token: 0x060010E5 RID: 4325 RVA: 0x00053B54 File Offset: 0x00051D54
	private static int LoadWorld_Version2(BinaryReader reader)
	{
		int num;
		return num;
	}

	// Token: 0x060010E6 RID: 4326 RVA: 0x00053B64 File Offset: 0x00051D64
	private static void LoadWeightedPressurePlates(BinaryReader reader)
	{
		if (!true)
		{
		}
		PressurePlateHelper.Reset();
	}

	// Token: 0x060010E7 RID: 4327 RVA: 0x00053B7C File Offset: 0x00051D7C
	private static void LoadTownManager(BinaryReader reader)
	{
		if (!true)
		{
		}
	}

	// Token: 0x060010E8 RID: 4328 RVA: 0x00053B8C File Offset: 0x00051D8C
	private static void LoadTileEntities(BinaryReader reader)
	{
		if (!true)
		{
		}
		TileEntity.Clear();
		long num = 0L;
		long num2 = 0L;
		TileEntity tileEntity = TileEntity.Read(reader, num2 != 0L);
		tileEntity.ID = (int)num;
		int positionKey = tileEntity.PositionKey;
		int positionKey2 = tileEntity.PositionKey;
	}

	// Token: 0x060010E9 RID: 4329 RVA: 0x00053C4C File Offset: 0x00051E4C
	private static bool LoadFileFormatHeader(BinaryReader reader, [Out] bool[] importance, [Out] int[] positions)
	{
		/*
An exception occurred when decompiling this method (060010E9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean WorldFile_OldConsole::LoadFileFormatHeader(System.IO.BinaryReader,System.Boolean[],System.Int32[])

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

	// Token: 0x060010EA RID: 4330 RVA: 0x00053C78 File Offset: 0x00051E78
	private static void LoadHeader(BinaryReader reader)
	{
		Guid guid = Guid.NewGuid();
	}

	// Token: 0x060010EB RID: 4331 RVA: 0x00053EB0 File Offset: 0x000520B0
	private static void LoadWorldTiles(BinaryReader reader, bool[] importance)
	{
		int num = 1;
		if (num == 0)
		{
		}
		if (num == 0)
		{
		}
		int num2 = 32768;
		string text2;
		string text = text2 + " " + text2 + "%";
		if (num2 == 0)
		{
		}
	}

	// Token: 0x060010EC RID: 4332 RVA: 0x00053FC8 File Offset: 0x000521C8
	private static void LoadChests(BinaryReader reader)
	{
		int num = WorldFile_OldConsole.ReadItemID(reader);
	}

	// Token: 0x060010ED RID: 4333 RVA: 0x00054024 File Offset: 0x00052224
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

	// Token: 0x060010EE RID: 4334 RVA: 0x00054054 File Offset: 0x00052254
	private static void LoadSigns(BinaryReader reader)
	{
		Tile tile;
		bool flag = tile.active();
	}

	// Token: 0x060010EF RID: 4335 RVA: 0x00054088 File Offset: 0x00052288
	private static void LoadDummies(BinaryReader reader)
	{
	}

	// Token: 0x060010F0 RID: 4336 RVA: 0x00054098 File Offset: 0x00052298
	private static void LoadNPCs(BinaryReader reader)
	{
		Vector2 vector = reader.ReadVector2();
	}

	// Token: 0x060010F1 RID: 4337 RVA: 0x000540AC File Offset: 0x000522AC
	private static int LoadFooter(BinaryReader reader)
	{
		return 6;
	}

	// Token: 0x060010F2 RID: 4338 RVA: 0x000540BC File Offset: 0x000522BC
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

	// Token: 0x060010F3 RID: 4339 RVA: 0x000021DB File Offset: 0x000003DB
	private static int ReadItemID(BinaryReader fileIO)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060010F4 RID: 4340 RVA: 0x00054494 File Offset: 0x00052694
	public WorldFile_OldConsole()
	{
	}

	// Token: 0x040020C3 RID: 8387
	public const int WorldVersion_AddGUID = 1000;

	// Token: 0x040020C4 RID: 8388
	public const int WorldVersion_CompressWorld = 1001;

	// Token: 0x040020C5 RID: 8389
	public const int WorldVersion_StoreFrameAsRowsAndColumnsInsteadOfPixels = 1002;

	// Token: 0x040020C6 RID: 8390
	public const int WorldVersion_1_3_2 = 1003;

	// Token: 0x040020C7 RID: 8391
	public const int WorldVersion_1_3_3 = 1004;

	// Token: 0x040020C8 RID: 8392
	public const int WorldVersion_1_3_4 = 1005;

	// Token: 0x040020C9 RID: 8393
	public const int WorldVersion_RemapConsoleSpecificItems = 1006;

	// Token: 0x040020CA RID: 8394
	public const int WorldVersionOneMaxRelease = 87;

	// Token: 0x040020CB RID: 8395
	public const int WorldFileVersion = 1006;

	// Token: 0x040020CC RID: 8396
	public const int ApproximateWriteSize = 7000000;

	// Token: 0x040020CD RID: 8397
	public const int MaximumWriteSize = 16777216;

	// Token: 0x040020CE RID: 8398
	private static int versionNumber;
}
