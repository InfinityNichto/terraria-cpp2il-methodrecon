using System;
using Controller;
using Terraria;
using Terraria.GameInput;

// Token: 0x02000135 RID: 309
public class GUIControlsStatusIndicators
{
	// Token: 0x06000809 RID: 2057 RVA: 0x0001FB7C File Offset: 0x0001DD7C
	public void Draw()
	{
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
		bool mapFullscreen = Main.mapFullscreen;
		int myPlayer = Main.myPlayer;
		bool enabled = LockOnHelper.Enabled;
	}

	// Token: 0x0600080A RID: 2058 RVA: 0x0001FBBC File Offset: 0x0001DDBC
	public GUIControlsStatusIndicators()
	{
	}
}
