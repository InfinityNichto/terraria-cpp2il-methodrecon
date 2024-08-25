using System;
using Telepathy;
using Terraria;
using Terraria.Net;

// Token: 0x020002C6 RID: 710
public class SaveSynchronisationHost
{
	// Token: 0x0600106C RID: 4204 RVA: 0x0005078C File Offset: 0x0004E98C
	public void Start()
	{
		bool flag = this.Server.Start(5555);
	}

	// Token: 0x0600106D RID: 4205 RVA: 0x000507AC File Offset: 0x0004E9AC
	public void Close()
	{
		this.Server.Stop();
	}

	// Token: 0x0600106E RID: 4206 RVA: 0x000507C4 File Offset: 0x0004E9C4
	private void SendDataFunction(byte[] messageData, int length)
	{
		if (!true)
		{
		}
		long num = 0L;
		ushort num2 = BitConverter.ToUInt16(messageData, (int)num);
		Server server = this.Server;
		int num3 = this.connectedClient;
		bool flag = server.Send(num3, messageData, length);
	}

	// Token: 0x0600106F RID: 4207 RVA: 0x00050810 File Offset: 0x0004EA10
	public void RequestFile(string filename)
	{
		if (!true)
		{
		}
		string savePath = Main.SavePath;
		string text = filename.Replace(savePath, "");
	}

	// Token: 0x06001070 RID: 4208 RVA: 0x00050888 File Offset: 0x0004EA88
	public void SendFile(string filename)
	{
		if (!true)
		{
		}
		string savePath = Main.SavePath;
		string text = filename.Replace(savePath, "");
	}

	// Token: 0x06001071 RID: 4209 RVA: 0x000508B0 File Offset: 0x0004EAB0
	public void Update()
	{
		int num = 1;
		Server server = this.Server;
		if (num == 0)
		{
			Server server2 = this.Server;
			string text2;
			string text = text2.Replace("::ffff:", "");
			bool flag = TcpAddress.IsLocalHost(text);
			this.connectedClient = num;
			return;
		}
		Server server3 = this.Server;
	}

	// Token: 0x06001072 RID: 4210 RVA: 0x00050964 File Offset: 0x0004EB64
	public SaveSynchronisationHost()
	{
	}

	// Token: 0x04001F50 RID: 8016
	public Server Server;

	// Token: 0x04001F51 RID: 8017
	public SaveSynchronisationOperation CurrentOperation;

	// Token: 0x04001F52 RID: 8018
	public int connectedClient;
}
