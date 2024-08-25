using System;
using System.Threading;

// Token: 0x020002C7 RID: 711
public class SaveSynchronisationManager
{
	// Token: 0x06001073 RID: 4211 RVA: 0x00050978 File Offset: 0x0004EB78
	public bool AttemptHostConnection(bool isLocalHost)
	{
		object @lock = this.Lock;
		Monitor.Enter(@lock, isLocalHost);
		if (this.ClientState != SaveSynchronisationManager.ConnectionState.Waiting)
		{
		}
		long num = 0L;
		Monitor.Exit(@lock);
		if (num == 0L)
		{
		}
		throw new OutOfMemoryException();
	}

	// Token: 0x06001074 RID: 4212 RVA: 0x000509CC File Offset: 0x0004EBCC
	public void ProcessServerMessage(SaveSynchronisationOperation.MessageId messageId, byte[] data, SaveSynchronisationOperation.SendDataFunction sendDataFunction)
	{
		if (!this.HostIsConnectedToLocal)
		{
			SaveSynchronisationManager.ConnectionState hostState = this.HostState;
			this.RemoteState.ProcessMessage(messageId, data);
		}
		this.RemoteState.ProcessMessageResponse(messageId, sendDataFunction);
	}

	// Token: 0x06001075 RID: 4213 RVA: 0x00050A04 File Offset: 0x0004EC04
	public void ProcessClientMessage(SaveSynchronisationOperation.MessageId messageId, byte[] data, SaveSynchronisationOperation.SendDataFunction sendDataFunction)
	{
		this.RemoteState.ProcessMessage(messageId, data);
		this.RemoteState.ProcessMessageResponse(messageId, sendDataFunction);
	}

	// Token: 0x06001076 RID: 4214 RVA: 0x00050A2C File Offset: 0x0004EC2C
	public void Update()
	{
		this.server.Update();
		this.client.Update();
	}

	// Token: 0x06001077 RID: 4215 RVA: 0x00050A50 File Offset: 0x0004EC50
	public bool AttemptClientConnection()
	{
		object @lock = this.Lock;
		if (this.HostState == SaveSynchronisationManager.ConnectionState.Waiting || this.HostIsConnectedToLocal)
		{
			SaveSynchronisationManager.ConnectionState clientState = this.ClientState;
			this.ClientState = SaveSynchronisationManager.ConnectionState.Connected;
		}
		long num = 0L;
		if (2 != 0)
		{
			Monitor.Exit(@lock);
		}
		if (num == 0L)
		{
		}
		throw new OutOfMemoryException();
	}

	// Token: 0x06001078 RID: 4216 RVA: 0x00050AB8 File Offset: 0x0004ECB8
	public bool IsLookingForConnection()
	{
		while (this.ClientState == SaveSynchronisationManager.ConnectionState.Waiting)
		{
		}
	}

	// Token: 0x06001079 RID: 4217 RVA: 0x00050AD0 File Offset: 0x0004ECD0
	public void Startup()
	{
		this.LocalState.RefreshFromFileSystem();
		this.RemoteState.Clear();
		SaveSynchronisationHost saveSynchronisationHost = this.server;
		bool flag = saveSynchronisationHost.Server.Start(5555);
		SaveSynchronisationBroadcast.StartBroadCasting();
		if (saveSynchronisationHost == null)
		{
		}
		SaveSynchronisationFinder.StartSearching();
	}

	// Token: 0x0600107A RID: 4218 RVA: 0x00050B18 File Offset: 0x0004ED18
	public void Shutdown()
	{
		if (!true)
		{
		}
		SaveSynchronisationFinder.StopSearching();
		SaveSynchronisationBroadcast.StopBroadCasting();
		this.server.Server.Stop();
		this.client.Client.Disconnect();
	}

	// Token: 0x0600107B RID: 4219 RVA: 0x00050B54 File Offset: 0x0004ED54
	public void Restart()
	{
		this.Shutdown();
		this.Startup();
	}

	// Token: 0x0600107C RID: 4220 RVA: 0x00050B70 File Offset: 0x0004ED70
	public void Connect(string connectionAddress)
	{
		object @lock = this.Lock;
		SaveSynchronisationManager.ConnectionState clientState;
		if (this.HostState == SaveSynchronisationManager.ConnectionState.Waiting)
		{
			clientState = this.ClientState;
			if (clientState == SaveSynchronisationManager.ConnectionState.Waiting)
			{
				this.ClientState = SaveSynchronisationManager.ConnectionState.Connecting;
				return;
			}
		}
		long num = 0L;
		if (clientState != SaveSynchronisationManager.ConnectionState.Waiting)
		{
			Monitor.Exit(@lock);
		}
		if (num == 0L)
		{
			if (3 == 0)
			{
				this.client.Client.Connect(connectionAddress, 5555);
			}
			return;
		}
		throw new OutOfMemoryException();
	}

	// Token: 0x0600107D RID: 4221 RVA: 0x00050BE4 File Offset: 0x0004EDE4
	public SaveSynchronisationManager()
	{
	}

	// Token: 0x04001F53 RID: 8019
	public static SaveSynchronisationManager Instance;

	// Token: 0x04001F54 RID: 8020
	public SaveSynchronisationState LocalState;

	// Token: 0x04001F55 RID: 8021
	public SaveSynchronisationState RemoteState;

	// Token: 0x04001F56 RID: 8022
	public SaveSynchronisationClient client;

	// Token: 0x04001F57 RID: 8023
	public SaveSynchronisationHost server;

	// Token: 0x04001F58 RID: 8024
	public object Lock;

	// Token: 0x04001F59 RID: 8025
	public SaveSynchronisationManager.ConnectionState ClientState;

	// Token: 0x04001F5A RID: 8026
	public SaveSynchronisationManager.ConnectionState HostState;

	// Token: 0x04001F5B RID: 8027
	public bool HostIsConnectedToLocal;

	// Token: 0x020002C8 RID: 712
	public enum ConnectionState
	{
		// Token: 0x04001F5D RID: 8029
		Waiting,
		// Token: 0x04001F5E RID: 8030
		Connecting,
		// Token: 0x04001F5F RID: 8031
		Connected
	}
}
