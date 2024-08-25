using System;
using Cpp2IlInjected;

// Token: 0x020002AE RID: 686
public class MPSessionAPI_Dummy : MPSessionAPI
{
	// Token: 0x06000FD7 RID: 4055 RVA: 0x0004EE18 File Offset: 0x0004D018
	public void OpenInviteOverlay(MPSession session, PlatformUser user, int numSlotsLeft)
	{
	}

	// Token: 0x06000FD8 RID: 4056 RVA: 0x000021DB File Offset: 0x000003DB
	public MPSession CreateNewSession(PlatformUser hostUser, MPSessionManager.LobbyState state)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000FD9 RID: 4057 RVA: 0x000021DB File Offset: 0x000003DB
	public MPSession CreateNewDirectSession(PlatformUser hostUser, MPSessionManager.LobbyState state, string serverAddress, int serverPort)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000FDA RID: 4058 RVA: 0x0004EE28 File Offset: 0x0004D028
	public MPSession[] FindUserSessions(PlatformUser[] users)
	{
		int num = 1;
		DrPlatform.DrPlatformType currentPlatform = DrPlatform.CurrentPlatform;
		if (users == null)
		{
			throw new ArrayTypeMismatchException();
		}
		if (num != 0)
		{
			if (6400 != 0)
			{
			}
			return "DummyWorld";
		}
		return "DummyWorld";
	}

	// Token: 0x06000FDB RID: 4059 RVA: 0x0004EE64 File Offset: 0x0004D064
	public void Update()
	{
		int num = 1;
		if (num == 0)
		{
		}
		if (num == 0)
		{
		}
		PlatformUser currentUser = PlatformUser.CurrentUser;
	}

	// Token: 0x06000FDC RID: 4060 RVA: 0x0004EED8 File Offset: 0x0004D0D8
	public MPSessionAPI_Dummy()
	{
	}
}
