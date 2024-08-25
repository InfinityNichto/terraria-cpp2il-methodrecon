using System;
using System.Runtime.InteropServices;

// Token: 0x020002B0 RID: 688
public class MPSession_Local : MPSession
{
	// Token: 0x06000FEB RID: 4075 RVA: 0x0004F098 File Offset: 0x0004D298
	public MPSession_Local()
	{
		this.state = MPSessionManager.LobbyState.InProgress;
		if (2 == 0)
		{
		}
	}

	// Token: 0x06000FEC RID: 4076 RVA: 0x0004F0B8 File Offset: 0x0004D2B8
	public void GetServerConnection([Out] string server, [Out] int port)
	{
		int num = this.serverPort;
		port.m_value = num;
	}

	// Token: 0x06000FED RID: 4077 RVA: 0x0004F0D4 File Offset: 0x0004D2D4
	public PlatformUser GetHost()
	{
		PlatformUser platformUser = this.hostUser;
		PlatformUser.Platform platformId = this.hostUser.PlatformId;
		return platformUser;
	}

	// Token: 0x06000FEE RID: 4078 RVA: 0x0004F0F8 File Offset: 0x0004D2F8
	public MPSessionManager.LobbyState GetState()
	{
		return this.state;
	}

	// Token: 0x06000FEF RID: 4079 RVA: 0x0004F10C File Offset: 0x0004D30C
	public void SetState(MPSessionManager.LobbyState newState)
	{
		MPSessionManager.LobbyState lobbyState = this.state;
		this.state = newState;
	}

	// Token: 0x06000FF0 RID: 4080 RVA: 0x0004F128 File Offset: 0x0004D328
	public void UpdatePlayerCount()
	{
	}

	// Token: 0x06000FF1 RID: 4081 RVA: 0x0004F138 File Offset: 0x0004D338
	public bool CanInvite()
	{
	}

	// Token: 0x06000FF2 RID: 4082 RVA: 0x0004F148 File Offset: 0x0004D348
	public MPSessionMetaData GetMetaData()
	{
		return this.MetaData;
	}

	// Token: 0x06000FF3 RID: 4083 RVA: 0x0004F15C File Offset: 0x0004D35C
	public void SetMetaData(MPSessionMetaData data)
	{
		this.MetaData = data;
	}

	// Token: 0x06000FF4 RID: 4084 RVA: 0x0004F170 File Offset: 0x0004D370
	public void SetClientInSession(bool activeInSession)
	{
		bool activeInSession2 = this.ActiveInSession;
	}

	// Token: 0x06000FF5 RID: 4085 RVA: 0x0004F184 File Offset: 0x0004D384
	public bool ClientInSession()
	{
		return this.ActiveInSession;
	}

	// Token: 0x06000FF6 RID: 4086 RVA: 0x0004F198 File Offset: 0x0004D398
	public void Leave(PlatformUser localUser)
	{
		if (this.ActiveInSession)
		{
		}
		PlatformUser platformUser = this.hostUser;
	}

	// Token: 0x06000FF7 RID: 4087 RVA: 0x0004F1B4 File Offset: 0x0004D3B4
	public void Join(PlatformUser localUser)
	{
	}

	// Token: 0x04001D83 RID: 7555
	private MPSessionManager.LobbyState state;

	// Token: 0x04001D84 RID: 7556
	private PlatformUser hostUser;

	// Token: 0x04001D85 RID: 7557
	private MPSessionMetaData MetaData;

	// Token: 0x04001D86 RID: 7558
	private bool ActiveInSession;

	// Token: 0x04001D87 RID: 7559
	private string serverAddress;

	// Token: 0x04001D88 RID: 7560
	private int serverPort;
}
