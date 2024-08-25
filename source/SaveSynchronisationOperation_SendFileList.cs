using System;
using System.IO;
using Terraria;
using Terraria.IO;

// Token: 0x020002CE RID: 718
public class SaveSynchronisationOperation_SendFileList : SaveSynchronisationOperation
{
	// Token: 0x06001096 RID: 4246 RVA: 0x0005123C File Offset: 0x0004F43C
	public SaveSynchronisationOperation_SendFileList(SaveSynchronisationOperation.SendDataFunction sendOperation)
	{
		if (!true)
		{
		}
		base..ctor(sendOperation);
	}

	// Token: 0x06001097 RID: 4247 RVA: 0x00051254 File Offset: 0x0004F454
	public override void Begin()
	{
		this.SendNextFile();
	}

	// Token: 0x06001098 RID: 4248 RVA: 0x00051268 File Offset: 0x0004F468
	private void SendPlayerFile(PlayerFileData playerFileData)
	{
		FileMetadata metadata = playerFileData.Metadata;
		string path = playerFileData._path;
		string savePath = Main.SavePath;
		string text = path.Replace(savePath, "");
		TimeSpan playTime = playerFileData.GetPlayTime();
		Player player = playerFileData._player;
		SaveSynchronisationOperation.SendDataFunction sendData = this.SendData;
		IntPtr method_code = sendData.method_code;
		IntPtr invoke_impl = sendData.invoke_impl;
		IntPtr method = sendData.method;
		if (invoke_impl != 0)
		{
		}
	}

	// Token: 0x06001099 RID: 4249 RVA: 0x0005135C File Offset: 0x0004F55C
	private void WritePlayerData(BinaryWriter writer, Player player)
	{
		string name = player.name;
		byte difficulty = player.difficulty;
		int hair = player.hair;
		byte hairDye = player.hairDye;
		BitsByte bitsByte = 0;
		bool[] hideVisibleAccessory = player.hideVisibleAccessory;
		BitsByte bitsByte2 = 0;
		bool[] hideVisibleAccessory2 = player.hideVisibleAccessory;
		BitsByte hideMisc = player.hideMisc;
		int skinVariant = player.skinVariant;
		int statLife = player.statLife;
		int statLifeMax = player.statLifeMax;
		int statMana = player.statMana;
		int statManaMax = player.statManaMax;
		bool extraAccessory = player.extraAccessory;
		bool unlockedBiomeTorches = player.unlockedBiomeTorches;
		bool usingBiomeTorches = player.UsingBiomeTorches;
		bool downedDD2EventAnyDifficulty = player.downedDD2EventAnyDifficulty;
		int taxMoney = player.taxMoney;
		byte r = player.hairColor.R;
		byte g = player.hairColor.G;
		byte b = player.hairColor.B;
		byte r2 = player.skinColor.R;
		byte g2 = player.skinColor.G;
		byte b2 = player.skinColor.B;
		byte r3 = player.eyeColor.R;
		byte g3 = player.eyeColor.G;
		byte b3 = player.eyeColor.B;
		byte r4 = player.shirtColor.R;
		byte g4 = player.shirtColor.G;
		byte b4 = player.shirtColor.B;
		byte r5 = player.underShirtColor.R;
		byte g5 = player.underShirtColor.G;
		byte b5 = player.underShirtColor.B;
		byte r6 = player.pantsColor.R;
		byte g6 = player.pantsColor.G;
		byte b6 = player.pantsColor.B;
		byte r7 = player.shoeColor.R;
		byte g7 = player.shoeColor.G;
		byte b7 = player.shoeColor.B;
		Item[] armor = player.armor;
		long entityId = armor.entityId;
		int netID = armor.netID;
		byte prefix = player.armor.prefix;
		Item[] armor2 = player.armor;
		Item[] dye = player.dye;
		long entityId2 = dye.entityId;
		int netID2 = dye.netID;
		byte prefix2 = player.dye.prefix;
		Item[] dye2 = player.dye;
		int netID3 = player.inventory.netID;
		int stack = player.inventory.stack;
		byte prefix3 = player.inventory.prefix;
		bool favorited = player.inventory.favorited;
		Item[] miscEquips = player.miscEquips;
		long entityId3 = miscEquips.entityId;
		int netID4 = miscEquips.netID;
		byte prefix4 = player.miscEquips.prefix;
		int netID5 = player.miscDyes.netID;
		byte prefix5 = player.miscDyes.prefix;
		Item[] miscEquips2 = player.miscEquips;
		int netID6 = player.bank.item.netID;
		int stack2 = player.bank.item.stack;
		byte prefix6 = player.bank.item.prefix;
		int netID7 = player.bank2.item.netID;
		int stack3 = player.bank2.item.stack;
		byte prefix7 = player.bank2.item.prefix;
		int netID8 = player.bank3.item.netID;
		int stack4 = player.bank3.item.stack;
		byte prefix8 = player.bank3.item.prefix;
		int netID9 = player.bank4.item.netID;
		int stack5 = player.bank4.item.stack;
		byte prefix9 = player.bank4.item.prefix;
		BitsByte voidVaultInfo = player.voidVaultInfo;
		bool[] hideInfo = player.hideInfo;
		bool[] hideInfo2 = player.hideInfo;
	}

	// Token: 0x0600109A RID: 4250 RVA: 0x000516F4 File Offset: 0x0004F8F4
	private void SendWorldFile(WorldFileData worldFileData)
	{
		int num = this.fileCountPending;
		this.fileCountPending = num;
		FileMetadata metadata = worldFileData.Metadata;
		string path = worldFileData._path;
		string savePath = Main.SavePath;
		string text = path.Replace(savePath, "");
		string name = worldFileData.Name;
		int worldSizeX = worldFileData.WorldSizeX;
		int worldSizeY = worldFileData.WorldSizeY;
		int gameMode = worldFileData.GameMode;
		bool drunkWorld = worldFileData.DrunkWorld;
		bool hasCorruption = worldFileData.HasCorruption;
		bool isHardMode = worldFileData.IsHardMode;
		SaveSynchronisationOperation.SendDataFunction sendData = this.SendData;
		IntPtr method_code = sendData.method_code;
		IntPtr invoke_impl = sendData.invoke_impl;
		IntPtr method = sendData.method;
		if (invoke_impl != 0)
		{
		}
	}

	// Token: 0x0600109B RID: 4251 RVA: 0x00051824 File Offset: 0x0004FA24
	private void SendNextFile()
	{
		if (!this.sentPlayers)
		{
			int num = this.fileOffset;
			return;
		}
		if (!this.sentWorlds)
		{
			int num2 = this.fileOffset;
			bool isComplete = this.IsComplete;
			int num3 = this.fileOffset;
			this.fileOffset = num3;
			return;
		}
		if (!this.sentEndList)
		{
			int num4 = 1;
			this.IsComplete = num4 != 0;
		}
	}

	// Token: 0x0600109C RID: 4252 RVA: 0x00051890 File Offset: 0x0004FA90
	public override void ProcessMessage(SaveSynchronisationOperation.MessageId messageId, byte[] data)
	{
		int num = this.fileCountPending;
		this.fileCountPending = num;
		this.SendNextFile();
		if (this.fileCountPending == 0)
		{
			int num2 = 1;
			this.IsComplete = num2 != 0;
		}
	}

	// Token: 0x0600109D RID: 4253 RVA: 0x000518C4 File Offset: 0x0004FAC4
	public override string GetStatus()
	{
		if (!this.sentPlayers)
		{
			int num = this.fileOffset;
			return "Finalising Save Data Sync";
		}
		if (this.sentWorlds)
		{
			return "Finalising Save Data Sync";
		}
		int num2 = this.fileOffset;
		return string.Format("Transmitting World Save Data State {0}%", "Finalising Save Data Sync");
	}

	// Token: 0x04001F78 RID: 8056
	private int fileCountPending;

	// Token: 0x04001F79 RID: 8057
	private int fileOffset;

	// Token: 0x04001F7A RID: 8058
	private bool sentPlayers;

	// Token: 0x04001F7B RID: 8059
	private bool sentWorlds;

	// Token: 0x04001F7C RID: 8060
	private bool sentEndList;
}
