using System;
using System.Text;
using Controller;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.GameContent.Liquid;
using Terraria.Graphics.Effects;
using UnityEngine;

// Token: 0x020002B8 RID: 696
public class LocalUser
{
	// Token: 0x0600101B RID: 4123 RVA: 0x000021DB File Offset: 0x000003DB
	public LocalUser(int userIndex, PlatformUser user)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x0600101C RID: 4124 RVA: 0x0004F420 File Offset: 0x0004D620
	public void SetupState()
	{
		this.LoadState();
		int num;
		if (this.UserIndex != 0)
		{
			this.mpSessionManager.PendingSession = 42179856;
			num = 150;
			if (num == 0)
			{
			}
		}
		if (num == 0)
		{
		}
		Rain[] rain = this.GameState.rain;
	}

	// Token: 0x0600101D RID: 4125 RVA: 0x0004F518 File Offset: 0x0004D718
	public void LoadThreadstate()
	{
		LocalUserGameState gameState = this.GameState;
		FileManager fileManager = this.fileManager;
	}

	// Token: 0x0600101E RID: 4126 RVA: 0x0004F534 File Offset: 0x0004D734
	public void LoadState()
	{
		if (!true)
		{
		}
		LocalUserGameState gameState = this.GameState;
		LocalUserXNAState xnastate = this.XNAState;
		FileManager fileManager = this.fileManager;
		CursorManager cursorManager = this.cursorManager;
		ControllerActionManager controllerActionManager = this.controllerActionManager;
		ControllerDevice activeController = this.ActiveController;
		GUIInputRegionManager guiinputRegionManager = this.guiInputRegionManager;
		XNAUIInputLayer xnauiinputLayer = this.xnaUIInputLayer;
		GUIInstance guiinstance = this.GUIInstance;
		MPSessionManager mpsessionManager = this.mpSessionManager;
		LiquidRenderer liquidRenderer = this.liquidRenderer;
		SkyManager skyManager = this.SkyManager;
		FilterManager filterManager = this.FilterManager;
		OverlayManager overlayManager = this.OverlayManager;
		InterfaceProfile_Layout[] customProfiles = this.CustomProfiles;
		XNAUICameraSettings uicameraSettings = this.UICameraSettings;
		GeometryBufferInstance.SetActive(this.UserIndex);
	}

	// Token: 0x0600101F RID: 4127 RVA: 0x0004F5CC File Offset: 0x0004D7CC
	public static void UnloadState()
	{
		if (!true)
		{
		}
	}

	// Token: 0x06001020 RID: 4128 RVA: 0x0004F5DC File Offset: 0x0004D7DC
	public void LoadPersistantData()
	{
	}

	// Token: 0x06001021 RID: 4129 RVA: 0x0004F7B8 File Offset: 0x0004D9B8
	public void SavePersistantData()
	{
	}

	// Token: 0x1700018C RID: 396
	// (get) Token: 0x06001023 RID: 4131 RVA: 0x0004F890 File Offset: 0x0004DA90
	// (set) Token: 0x06001022 RID: 4130 RVA: 0x0004F874 File Offset: 0x0004DA74
	public Rect ViewportRegion
	{
		get
		{
			return this.UICameraSettings.Camera.rect;
		}
		set
		{
			XNAUICameraSettings uicameraSettings = this.UICameraSettings;
			XNAWorldCameraSettings worldCameraSettings = this.WorldCameraSettings;
		}
	}

	// Token: 0x06001024 RID: 4132 RVA: 0x0004F8B0 File Offset: 0x0004DAB0
	private static Camera GetCamera(string name)
	{
		GameObject gameObject = GameObject.Find("SplitScreenCameras");
		GameObject gameObject2;
		return gameObject2.GetComponent<Camera>();
	}

	// Token: 0x06001025 RID: 4133 RVA: 0x0004F8D0 File Offset: 0x0004DAD0
	public static Camera GetWorldCamera(int index)
	{
		if (!true)
		{
		}
		Camera camera = LocalUser.GetCamera("MainCamera_2");
		if (16 == 0)
		{
		}
		Camera camera2 = LocalUser.GetCamera("MainCamera_4");
		if (16 == 0)
		{
		}
		if (32 == 0)
		{
		}
		Camera camera3 = LocalUser.GetCamera("MainCamera_3");
		if (32 == 0)
		{
			return;
		}
	}

	// Token: 0x06001026 RID: 4134 RVA: 0x0004F914 File Offset: 0x0004DB14
	public static Camera GetUICamera(int index)
	{
		if (!true)
		{
		}
		Camera camera = LocalUser.GetCamera("UICamera_2");
		if (40 == 0)
		{
		}
		Camera camera2 = LocalUser.GetCamera("UICamera_4");
		if (40 == 0)
		{
		}
		if (56 == 0)
		{
		}
		Camera camera3 = LocalUser.GetCamera("UICamera_3");
		if (56 == 0)
		{
			return;
		}
	}

	// Token: 0x06001027 RID: 4135 RVA: 0x0004F958 File Offset: 0x0004DB58
	// Note: this type is marked as 'beforefieldinit'.
	static LocalUser()
	{
		Encoding ascii = Encoding.ASCII;
	}

	// Token: 0x04001DA0 RID: 7584
	private static byte[] _cryptoKey;

	// Token: 0x04001DA1 RID: 7585
	public static LocalUser Active;

	// Token: 0x04001DA2 RID: 7586
	public SkyManager SkyManager;

	// Token: 0x04001DA3 RID: 7587
	public FilterManager FilterManager;

	// Token: 0x04001DA4 RID: 7588
	public OverlayManager OverlayManager;

	// Token: 0x04001DA5 RID: 7589
	private bool usingKeyboardMouse;

	// Token: 0x04001DA6 RID: 7590
	public ControllerDevice ActiveController;

	// Token: 0x04001DA7 RID: 7591
	public GUIInstance GUIInstance;

	// Token: 0x04001DA8 RID: 7592
	public CursorManager cursorManager;

	// Token: 0x04001DA9 RID: 7593
	public ControllerActionManager controllerActionManager;

	// Token: 0x04001DAA RID: 7594
	public GUIInputRegionManager guiInputRegionManager;

	// Token: 0x04001DAB RID: 7595
	public MPSessionManager mpSessionManager;

	// Token: 0x04001DAC RID: 7596
	public XNAUIInputLayer xnaUIInputLayer;

	// Token: 0x04001DAD RID: 7597
	public FileManager fileManager;

	// Token: 0x04001DAE RID: 7598
	public LiquidRenderer liquidRenderer;

	// Token: 0x04001DAF RID: 7599
	public int UserIndex;

	// Token: 0x04001DB0 RID: 7600
	public PlatformUser UserId;

	// Token: 0x04001DB1 RID: 7601
	public IPlatformAwardNotifier PlatformAwards;

	// Token: 0x04001DB2 RID: 7602
	public PersistentUserData PersistentUserData;

	// Token: 0x04001DB3 RID: 7603
	public XNAUICameraSettings UICameraSettings;

	// Token: 0x04001DB4 RID: 7604
	public XNAWorldCameraSettings WorldCameraSettings;

	// Token: 0x04001DB5 RID: 7605
	public LocalUserGameState GameState;

	// Token: 0x04001DB6 RID: 7606
	public LocalUserXNAState XNAState;

	// Token: 0x04001DB7 RID: 7607
	public InterfaceProfile_Layout[] CustomProfiles;

	// Token: 0x04001DB8 RID: 7608
	private static Camera _worldCam2;

	// Token: 0x04001DB9 RID: 7609
	private static Camera _worldCam3;

	// Token: 0x04001DBA RID: 7610
	private static Camera _worldCam4;

	// Token: 0x04001DBB RID: 7611
	private static Camera _uiCam2;

	// Token: 0x04001DBC RID: 7612
	private static Camera _uiCam3;

	// Token: 0x04001DBD RID: 7613
	private static Camera _uiCam4;
}
