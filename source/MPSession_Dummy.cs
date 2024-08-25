using System;
using System.Runtime.InteropServices;
using UnityEngine;

// Token: 0x020002AF RID: 687
public class MPSession_Dummy : MPSession
{
	// Token: 0x06000FDD RID: 4061 RVA: 0x0004EEEC File Offset: 0x0004D0EC
	public MPSession_Dummy(PlatformUser user, string server, int port, MPSessionManager.LobbyState lobbyState)
	{
		this.hostUser = user;
		this.hostUser.PlatformId = server;
		this.serverAddress = port;
		this.serverPort = (int)lobbyState;
	}

	// Token: 0x06000FDE RID: 4062 RVA: 0x0004EF24 File Offset: 0x0004D124
	public MPSession_Dummy(PlatformUser user, MPSessionManager.LobbyState lobbyState)
	{
		this.hostUser = user;
		this.hostUser.PlatformId = (PlatformUser.Platform)lobbyState;
	}

	// Token: 0x06000FDF RID: 4063 RVA: 0x0004EF4C File Offset: 0x0004D14C
	public void GetServerConnection([Out] string server, [Out] int port)
	{
		string text = this.serverAddress;
		int num = this.serverPort;
		port.m_value = num;
	}

	// Token: 0x06000FE0 RID: 4064 RVA: 0x0004EF70 File Offset: 0x0004D170
	public PlatformUser GetHost()
	{
		PlatformUser platformUser = this.hostUser;
		PlatformUser.Platform platformId = this.hostUser.PlatformId;
		return platformUser;
	}

	// Token: 0x06000FE1 RID: 4065 RVA: 0x0004EF94 File Offset: 0x0004D194
	public MPSessionManager.LobbyState GetState()
	{
		return this.state;
	}

	// Token: 0x06000FE2 RID: 4066 RVA: 0x0004EFA8 File Offset: 0x0004D1A8
	public void SetState(MPSessionManager.LobbyState newState)
	{
		MPSessionManager.LobbyState lobbyState = this.state;
		this.state = newState;
	}

	// Token: 0x06000FE3 RID: 4067 RVA: 0x0004EFC4 File Offset: 0x0004D1C4
	public void UpdatePlayerCount()
	{
		int num = 1;
		long num2 = 0L;
		if (num == 0)
		{
		}
		if (num == 0 || num == 0)
		{
		}
		MPSessionMetaData metaData = this.MetaData;
		int numberOfPlayers = metaData.NumberOfPlayers;
		metaData.NumberOfPlayers = (int)num2;
	}

	// Token: 0x06000FE4 RID: 4068 RVA: 0x0004EFF8 File Offset: 0x0004D1F8
	public bool CanInvite()
	{
	}

	// Token: 0x06000FE5 RID: 4069 RVA: 0x0004F008 File Offset: 0x0004D208
	public MPSessionMetaData GetMetaData()
	{
		return this.MetaData;
	}

	// Token: 0x06000FE6 RID: 4070 RVA: 0x0004F01C File Offset: 0x0004D21C
	public void SetMetaData(MPSessionMetaData data)
	{
		this.MetaData = data;
	}

	// Token: 0x06000FE7 RID: 4071 RVA: 0x0004F030 File Offset: 0x0004D230
	public void SetClientInSession(bool activeInSession)
	{
		bool activeInSession2 = this.ActiveInSession;
		string text;
		Debug.Log("Setting SetClientInSession " + text);
	}

	// Token: 0x06000FE8 RID: 4072 RVA: 0x0004F054 File Offset: 0x0004D254
	public bool ClientInSession()
	{
		return this.ActiveInSession;
	}

	// Token: 0x06000FE9 RID: 4073 RVA: 0x0004F068 File Offset: 0x0004D268
	public void Leave(PlatformUser localUser)
	{
		long num = 0L;
		this.SetClientInSession(num != 0L);
		PlatformUser platformUser = this.hostUser;
	}

	// Token: 0x06000FEA RID: 4074 RVA: 0x0004F088 File Offset: 0x0004D288
	public void Join(PlatformUser localUser)
	{
	}

	// Token: 0x04001D7D RID: 7549
	private MPSessionManager.LobbyState state;

	// Token: 0x04001D7E RID: 7550
	private PlatformUser hostUser;

	// Token: 0x04001D7F RID: 7551
	private MPSessionMetaData MetaData;

	// Token: 0x04001D80 RID: 7552
	private bool ActiveInSession;

	// Token: 0x04001D81 RID: 7553
	private string serverAddress;

	// Token: 0x04001D82 RID: 7554
	private int serverPort;
}
