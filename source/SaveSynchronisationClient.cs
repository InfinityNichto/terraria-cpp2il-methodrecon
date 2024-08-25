using System;
using Telepathy;
using Terraria;

// Token: 0x020002C3 RID: 707
public class SaveSynchronisationClient
{
	// Token: 0x0600105F RID: 4191 RVA: 0x00050400 File Offset: 0x0004E600
	public void Connect(string hostName)
	{
		this.Client.Connect(hostName, 5555);
	}

	// Token: 0x06001060 RID: 4192 RVA: 0x00050420 File Offset: 0x0004E620
	public void Close()
	{
		this.Client.Disconnect();
	}

	// Token: 0x06001061 RID: 4193 RVA: 0x00050438 File Offset: 0x0004E638
	private void SendDataFunction(byte[] messageData, int length)
	{
		if (!true)
		{
		}
		long num = 0L;
		ushort num2 = BitConverter.ToUInt16(messageData, (int)num);
		bool flag = this.Client.Send(messageData, length);
	}

	// Token: 0x06001062 RID: 4194 RVA: 0x00050478 File Offset: 0x0004E678
	public void RequestFile(string filename)
	{
		if (!true)
		{
		}
		string savePath = Main.SavePath;
		string text = filename.Replace(savePath, "");
	}

	// Token: 0x06001063 RID: 4195 RVA: 0x000504F0 File Offset: 0x0004E6F0
	public void SendFile(string filename)
	{
		if (!true)
		{
		}
		string savePath = Main.SavePath;
		string text = filename.Replace(savePath, "");
	}

	// Token: 0x06001064 RID: 4196 RVA: 0x00050518 File Offset: 0x0004E718
	public void Update()
	{
		int num = 1;
		Client client = this.Client;
		if (num == 0)
		{
			return;
		}
		Client client2 = this.Client;
	}

	// Token: 0x06001065 RID: 4197 RVA: 0x000505A0 File Offset: 0x0004E7A0
	public SaveSynchronisationClient()
	{
	}

	// Token: 0x04001F42 RID: 8002
	public Client Client;

	// Token: 0x04001F43 RID: 8003
	public SaveSynchronisationOperation CurrentOperation;
}
