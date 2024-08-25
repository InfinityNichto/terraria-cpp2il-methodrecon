using System;

// Token: 0x020002B2 RID: 690
public interface MPSessionAPI
{
	// Token: 0x06001004 RID: 4100
	void OpenInviteOverlay(MPSession session, PlatformUser user, int numSlotsLeft);

	// Token: 0x06001005 RID: 4101
	MPSession CreateNewSession(PlatformUser hostUser, MPSessionManager.LobbyState state);

	// Token: 0x06001006 RID: 4102
	MPSession CreateNewDirectSession(PlatformUser hostUser, MPSessionManager.LobbyState state, string serverAddress, int serverPort);

	// Token: 0x06001007 RID: 4103
	MPSession[] FindUserSessions(PlatformUser[] users);

	// Token: 0x06001008 RID: 4104
	void Update();
}
