using System;
using System.Collections.Generic;
using System.IO;
using Cpp2IlInjected;
using Terraria;
using Terraria.IO;

// Token: 0x020002CF RID: 719
public class SaveSynchronisationState
{
	// Token: 0x0600109E RID: 4254 RVA: 0x0005190C File Offset: 0x0004FB0C
	public void RefreshFromFileSystem()
	{
		this.Clear();
		if (!true)
		{
		}
		Main.LoadPlayers();
		List<PlayerFileData> list = this.playerFiles;
		Main.LoadWorlds();
		List<WorldFileData> list2 = this.worldFiles;
	}

	// Token: 0x0600109F RID: 4255 RVA: 0x00051940 File Offset: 0x0004FB40
	public void ProcessMessage(SaveSynchronisationOperation.MessageId messageId, byte[] data)
	{
	}

	// Token: 0x060010A0 RID: 4256 RVA: 0x00051968 File Offset: 0x0004FB68
	public void SendEmptyMessage(SaveSynchronisationOperation.MessageId id, SaveSynchronisationOperation.SendDataFunction sendDataFunction)
	{
		if (!true)
		{
		}
		IntPtr invoke_impl = sendDataFunction.invoke_impl;
		IntPtr method_code = sendDataFunction.method_code;
		IntPtr method = sendDataFunction.method;
	}

	// Token: 0x060010A1 RID: 4257 RVA: 0x00051990 File Offset: 0x0004FB90
	public void ProcessMessageResponse(SaveSynchronisationOperation.MessageId messageId, SaveSynchronisationOperation.SendDataFunction sendDataFunction)
	{
	}

	// Token: 0x060010A2 RID: 4258 RVA: 0x000021DB File Offset: 0x000003DB
	private void ReadPlayerFileData(byte[] data)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060010A3 RID: 4259 RVA: 0x000519A0 File Offset: 0x0004FBA0
	private void ReadPlayerData(BinaryReader reader, Player player)
	{
		player.name = reader;
		player.difficulty = reader;
		player.hair = reader;
		player.hairDye = reader;
		long num = 0L;
		bool[] hideVisibleAccessory = player.hideVisibleAccessory;
		BitsByte bitsByte;
		bool flag = bitsByte[(int)num];
		long num2 = 0L;
		bool[] hideVisibleAccessory2 = player.hideVisibleAccessory;
		BitsByte bitsByte2;
		bool flag2 = bitsByte2[(int)num2];
		long num3 = 0L;
		BitsByte bitsByte3;
		player.hideMisc = bitsByte3;
		player.statLife = reader;
		player.statLifeMax = reader;
		player.statMana = reader;
		player.statManaMax = reader;
		player.UsingBiomeTorches = num3 != 0L;
		player.taxMoney = reader;
		player.hairColor.R = reader;
		player.hairColor.G = reader;
		player.hairColor.B = reader;
		player.skinColor.R = reader;
		player.skinColor.G = reader;
		player.skinColor.B = reader;
		player.eyeColor.R = reader;
		player.eyeColor.G = reader;
		player.eyeColor.B = reader;
		player.shirtColor.R = reader;
		player.shirtColor.G = reader;
		player.shirtColor.B = reader;
		player.underShirtColor.R = reader;
		player.underShirtColor.G = reader;
		player.underShirtColor.B = reader;
		player.pantsColor.R = reader;
		player.pantsColor.G = reader;
		player.pantsColor.B = reader;
		player.shoeColor.R = reader;
		player.shoeColor.G = reader;
		Item[] armor = player.armor;
		player.shoeColor.B = reader;
		long entityId = armor.entityId;
		Item[] armor2 = player.armor;
		Item[] armor3 = player.armor;
		long entityId2 = player.dye.entityId;
		Item[] dye = player.dye;
		Item[] inventory = player.inventory;
		Item[] inventory2 = player.inventory;
		Item[] inventory3 = player.inventory;
		long entityId3 = player.miscEquips.entityId;
		Item[] miscEquips = player.miscEquips;
		Item[] miscDyes = player.miscDyes;
		Item[] miscDyes2 = player.miscDyes;
		Item[] miscEquips2 = player.miscEquips;
		Item[] item = player.bank.item;
		Item[] item2 = player.bank.item;
		Item[] item3 = player.bank.item;
		Item[] item4 = player.bank2.item;
		Item[] item5 = player.bank2.item;
		Item[] item6 = player.bank2.item;
		Item[] item7 = player.bank3.item;
		Item[] item8 = player.bank3.item;
		Item[] item9 = player.bank3.item;
		Item[] item10 = player.bank4.item;
		Item[] item11 = player.bank4.item;
		Item[] item12 = player.bank4.item;
		bool[] hideInfo = player.hideInfo;
		BitsByte bitsByte4;
		player.voidVaultInfo = bitsByte4;
		bool[] hideInfo2 = player.hideInfo;
	}

	// Token: 0x060010A4 RID: 4260 RVA: 0x000021DB File Offset: 0x000003DB
	private void ReadWorldFileData(byte[] data)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060010A5 RID: 4261 RVA: 0x000021DB File Offset: 0x000003DB
	public void Clear()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060010A6 RID: 4262 RVA: 0x00051C68 File Offset: 0x0004FE68
	public SaveSynchronisationState()
	{
	}

	// Token: 0x060010A7 RID: 4263 RVA: 0x00051C7C File Offset: 0x0004FE7C
	// Note: this type is marked as 'beforefieldinit'.
	static SaveSynchronisationState()
	{
	}

	// Token: 0x04001F7D RID: 8061
	private static byte[] emptyMessageData;

	// Token: 0x04001F7E RID: 8062
	public bool IsSynchronised;

	// Token: 0x04001F7F RID: 8063
	public List<PlayerFileData> playerFiles;

	// Token: 0x04001F80 RID: 8064
	public List<WorldFileData> worldFiles;
}
