using System;
using Terraria;
using Terraria.Utilities;
using UnityEngine;

// Token: 0x020002CC RID: 716
public class SaveSynchronisationOperation_ReceiveFile : SaveSynchronisationOperation
{
	// Token: 0x0600108B RID: 4235 RVA: 0x00050D28 File Offset: 0x0004EF28
	public SaveSynchronisationOperation_ReceiveFile(SaveSynchronisationOperation.SendDataFunction sendOperation)
	{
		if (!true)
		{
		}
		base..ctor();
		this.SendData = sendOperation;
	}

	// Token: 0x0600108C RID: 4236 RVA: 0x00050D48 File Offset: 0x0004EF48
	public override void Begin()
	{
	}

	// Token: 0x0600108D RID: 4237 RVA: 0x00050D58 File Offset: 0x0004EF58
	public override void ProcessMessage(SaveSynchronisationOperation.MessageId messageId, byte[] data)
	{
		bool flag = this.filename.Contains(".plr");
		string text = this.filename;
		string text2 = this.filename;
		Debug.Log("Setting active player " + text2);
		long num = 0L;
		int num2 = 6;
		if (num == 0L)
		{
			if (num2 == 0)
			{
				bool flag2 = this.filename.Contains(".wld");
				string text3 = this.filename;
				string text4 = this.filename;
				Debug.Log("Setting active world " + text4);
				if (false)
				{
					throw new OutOfMemoryException();
				}
			}
			int num3;
			if (num3 != 0)
			{
			}
			return;
		}
		throw new OutOfMemoryException();
	}

	// Token: 0x0600108E RID: 4238 RVA: 0x00050E74 File Offset: 0x0004F074
	private void WriteFile()
	{
		if (!true)
		{
		}
		string savePath = Main.SavePath;
		string text = this.filename;
		string text2 = savePath + text;
		long num = 0L;
		byte[] array = FileUtilities.ReadAllBytes(text2, num != 0L);
		byte[] array2 = this.fileData;
		Debug.LogError("Error in transfer");
		byte[] array3 = this.fileData;
		Debug.LogError("Error in transfer");
	}

	// Token: 0x0600108F RID: 4239 RVA: 0x00050ED8 File Offset: 0x0004F0D8
	public override string GetStatus()
	{
		int num = this.fileOffset;
		int num2 = this.fileLength;
		string text;
		return text;
	}

	// Token: 0x04001F6D RID: 8045
	private string filename;

	// Token: 0x04001F6E RID: 8046
	private int fileOffset;

	// Token: 0x04001F6F RID: 8047
	private int fileLength;

	// Token: 0x04001F70 RID: 8048
	private byte[] fileData;
}
