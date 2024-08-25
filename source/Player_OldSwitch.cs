using System;
using System.IO;
using Cpp2IlInjected;
using Terraria;
using Terraria.IO;

// Token: 0x020002E1 RID: 737
internal class Player_OldSwitch
{
	// Token: 0x060010F5 RID: 4341 RVA: 0x000021DB File Offset: 0x000003DB
	private static short ReadItemID(BinaryReader fileIO, int playerFileVersion)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060010F6 RID: 4342 RVA: 0x000544A8 File Offset: 0x000526A8
	public static bool LoadPlayer(string playerPath, PlayerFileData playerData)
	{
		if (!true)
		{
		}
		long num = 0L;
		BitsByte bitsByte2;
		BitsByte bitsByte = (bitsByte2[(int)num] ? 1 : 0);
		long num2 = 0L;
		return bitsByte[(int)num2];
	}

	// Token: 0x060010F7 RID: 4343 RVA: 0x00054640 File Offset: 0x00052840
	private static void GivePlayerCoins(Player player, int value)
	{
		Item[] inventory = player.inventory;
	}

	// Token: 0x060010F8 RID: 4344 RVA: 0x000546B8 File Offset: 0x000528B8
	public Player_OldSwitch()
	{
	}

	// Token: 0x060010F9 RID: 4345 RVA: 0x000546CC File Offset: 0x000528CC
	// Note: this type is marked as 'beforefieldinit'.
	static Player_OldSwitch()
	{
	}

	// Token: 0x040020CF RID: 8399
	private const int PlayerFileVersion_GUID = 1000;

	// Token: 0x040020D0 RID: 8400
	private const int PlayerFileVersion_1_3_1 = 1001;

	// Token: 0x040020D1 RID: 8401
	private const int PlayerFileVersion_1_3_4 = 1002;

	// Token: 0x040020D2 RID: 8402
	private const int PlayerFileVersion_RemapENGINEItems = 1003;

	// Token: 0x040020D3 RID: 8403
	private const int PlayerFileVersion_RememberDPadShortcut = 1004;

	// Token: 0x040020D4 RID: 8404
	public static byte[] EncryptionKey;
}
