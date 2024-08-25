using System;
using Terraria;
using Terraria.Utilities;
using UnityEngine;

// Token: 0x020002CD RID: 717
public class SaveSynchronisationOperation_SendFile : SaveSynchronisationOperation
{
	// Token: 0x06001090 RID: 4240 RVA: 0x00050EF4 File Offset: 0x0004F0F4
	public SaveSynchronisationOperation_SendFile(string filenameToSend, SaveSynchronisationOperation.SendDataFunction sendOperation)
	{
		if (!true)
		{
		}
		base..ctor();
		this.SendData = sendOperation;
		bool flag = filenameToSend.Contains(".plr");
		bool flag2 = filenameToSend.StartsWith("/OldSaves");
		if ("/OldSaves" == null)
		{
		}
		string savePath = Main.SavePath;
		string text = filenameToSend.Replace(".plr", "");
		string[] files = FileManager.GetFiles(savePath + text, "*.map");
		this.mapFiles = files;
		if (files == null)
		{
			this.filename = filenameToSend;
			if ("/OldSaves/PersistentUserData.dat" == null)
			{
			}
			string savePath2 = Main.SavePath;
			string text2 = this.filename;
			string text3 = savePath2 + text2;
			long num = 0L;
			byte[] array = FileUtilities.ReadAllBytes(text3, num != 0L);
			this.fileDataToSend = array;
			return;
		}
		if ("/OldSaves" == null)
		{
		}
		string savePath3 = Main.SavePath;
		string text4;
		if (text4 == null || text4 != null)
		{
			string[] array2 = this.mapFiles;
			return;
		}
		throw new ArrayTypeMismatchException();
	}

	// Token: 0x06001091 RID: 4241 RVA: 0x00050FF4 File Offset: 0x0004F1F4
	public override void Begin()
	{
		IntPtr invoke_impl;
		if (this.fileDataToSend != null)
		{
			string text = this.filename;
			byte[] array = this.fileDataToSend;
			SaveSynchronisationOperation.SendDataFunction sendData = this.SendData;
			IntPtr method_code = sendData.method_code;
			invoke_impl = sendData.invoke_impl;
			IntPtr method = sendData.method;
			if (invoke_impl != 0)
			{
			}
			return;
		}
		string text2 = this.filename;
		string text3 = "No Data " + text2;
		if (invoke_impl == 0)
		{
		}
		Debug.LogError(text3);
		int num = 1;
		this.IsComplete = num != 0;
	}

	// Token: 0x06001092 RID: 4242 RVA: 0x00051110 File Offset: 0x0004F310
	public override void ProcessMessage(SaveSynchronisationOperation.MessageId messageId, byte[] data)
	{
		int num = this.sendOffset;
		int num2 = this.mapFilesOffset;
		byte[] array = this.fileDataToSend;
		this.pendingChunks = num2;
		this.SendNextChunk();
		if (this.pendingChunks == 0)
		{
			string[] array2 = this.mapFiles;
			if (array2 != null)
			{
				this.filename = array2;
				if (array2 == null)
				{
				}
				string savePath = Main.SavePath;
				string text = this.filename;
				string text2 = savePath + text;
				long num3 = 0L;
				byte[] array3 = FileUtilities.ReadAllBytes(text2, num3 != 0L);
				int num4 = this.mapFilesOffset;
				this.fileDataToSend = array3;
				this.mapFilesOffset = num4;
				return;
			}
			int num5 = 1;
			this.IsComplete = num5 != 0;
		}
	}

	// Token: 0x06001093 RID: 4243 RVA: 0x000511AC File Offset: 0x0004F3AC
	private void SendNextChunk()
	{
		byte[] array = this.fileDataToSend;
		int num = this.sendOffset;
		byte[] array2 = this.fileDataToSend;
		int num2 = this.sendOffset;
		SaveSynchronisationOperation.SendDataFunction sendData = this.SendData;
		IntPtr invoke_impl = sendData.invoke_impl;
		IntPtr method_code = sendData.method_code;
		int num3 = this.sendOffset;
		int num4 = this.mapFilesOffset;
		this.sendOffset = num3;
		this.mapFilesOffset = num4;
	}

	// Token: 0x06001094 RID: 4244 RVA: 0x00051210 File Offset: 0x0004F410
	public override string GetStatus()
	{
		byte[] array = this.fileDataToSend;
		int num = this.sendOffset;
		string text;
		return text;
	}

	// Token: 0x06001095 RID: 4245 RVA: 0x0005122C File Offset: 0x0004F42C
	// Note: this type is marked as 'beforefieldinit'.
	static SaveSynchronisationOperation_SendFile()
	{
	}

	// Token: 0x04001F71 RID: 8049
	private string filename;

	// Token: 0x04001F72 RID: 8050
	private byte[] fileDataToSend;

	// Token: 0x04001F73 RID: 8051
	private int sendOffset;

	// Token: 0x04001F74 RID: 8052
	private int pendingChunks;

	// Token: 0x04001F75 RID: 8053
	private int mapFilesOffset;

	// Token: 0x04001F76 RID: 8054
	private string[] mapFiles;

	// Token: 0x04001F77 RID: 8055
	private static byte[] fileDataBuffer;
}
