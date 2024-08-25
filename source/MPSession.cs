using System;
using System.Runtime.InteropServices;

// Token: 0x020002B1 RID: 689
public interface MPSession
{
	// Token: 0x06000FF8 RID: 4088
	PlatformUser GetHost();

	// Token: 0x06000FF9 RID: 4089
	MPSessionManager.LobbyState GetState();

	// Token: 0x06000FFA RID: 4090
	void GetServerConnection([Out] string server, [Out] int port);

	// Token: 0x06000FFB RID: 4091
	void SetState(MPSessionManager.LobbyState newState);

	// Token: 0x06000FFC RID: 4092
	bool ClientInSession();

	// Token: 0x06000FFD RID: 4093
	void SetClientInSession(bool activeInSession);

	// Token: 0x06000FFE RID: 4094
	MPSessionMetaData GetMetaData();

	// Token: 0x06000FFF RID: 4095
	void SetMetaData(MPSessionMetaData data);

	// Token: 0x06001000 RID: 4096
	void UpdatePlayerCount();

	// Token: 0x06001001 RID: 4097
	bool CanInvite();

	// Token: 0x06001002 RID: 4098
	void Leave(PlatformUser localUser);

	// Token: 0x06001003 RID: 4099
	void Join(PlatformUser localUser);
}
