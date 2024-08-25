using System;
using Controller;
using Cpp2IlInjected;
using Terraria;

// Token: 0x020001AA RID: 426
public static class BottomCentreHUDAnchorUpdator
{
	// Token: 0x17000124 RID: 292
	// (get) Token: 0x06000B78 RID: 2936 RVA: 0x000021DB File Offset: 0x000003DB
	// (set) Token: 0x06000B79 RID: 2937 RVA: 0x0003A380 File Offset: 0x00038580
	private static int BottomCentreHUDUpdateFrame
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
		set
		{
		}
	}

	// Token: 0x06000B7A RID: 2938 RVA: 0x0003A390 File Offset: 0x00038590
	public static void Update()
	{
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
		bool flag = Main.BigBossProgressBar.IsTracking();
		int num = 32768;
		if (num != 0 || num == 0)
		{
		}
	}
}
