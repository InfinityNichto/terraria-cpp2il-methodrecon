using System;
using System.IO;
using Terraria;
using Terraria.IO;

// Token: 0x020002DF RID: 735
internal class Player_OldConsole
{
	// Token: 0x060010D8 RID: 4312 RVA: 0x0005351C File Offset: 0x0005171C
	private static short ReadItemID(BinaryReader fileIO, int playerFileVersion)
	{
		short num;
		return num;
	}

	// Token: 0x060010D9 RID: 4313 RVA: 0x0005352C File Offset: 0x0005172C
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

	// Token: 0x060010DA RID: 4314 RVA: 0x000536F8 File Offset: 0x000518F8
	private static void GivePlayerCoins(Player player, int value)
	{
		Item[] inventory = player.inventory;
	}

	// Token: 0x060010DB RID: 4315 RVA: 0x00053770 File Offset: 0x00051970
	public Player_OldConsole()
	{
	}

	// Token: 0x060010DC RID: 4316 RVA: 0x00053784 File Offset: 0x00051984
	// Note: this type is marked as 'beforefieldinit'.
	static Player_OldConsole()
	{
	}

	// Token: 0x040020BD RID: 8381
	private const int PlayerFileVersion_GUID = 1000;

	// Token: 0x040020BE RID: 8382
	private const int PlayerFileVersion_1_3_1 = 1001;

	// Token: 0x040020BF RID: 8383
	private const int PlayerFileVersion_1_3_4 = 1002;

	// Token: 0x040020C0 RID: 8384
	private const int PlayerFileVersion_RemapENGINEItems = 1003;

	// Token: 0x040020C1 RID: 8385
	private const int PlayerFileVersion_RememberDPadShortcut = 1004;

	// Token: 0x040020C2 RID: 8386
	public static byte[] EncryptionKey;
}
