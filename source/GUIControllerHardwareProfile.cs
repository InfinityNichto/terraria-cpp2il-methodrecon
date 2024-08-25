using System;
using System.Collections.Generic;
using Controller;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using UnityEngine;

// Token: 0x020000AF RID: 175
public class GUIControllerHardwareProfile
{
	// Token: 0x0600041D RID: 1053 RVA: 0x0000D4C0 File Offset: 0x0000B6C0
	public static void RegisterOverlay(GUIControllerMappingEntryBase entry, Rectangle region)
	{
		int num = 1;
		if (num == 0)
		{
		}
		num.m_value = entry;
		if (entry != null)
		{
			return;
		}
	}

	// Token: 0x0600041E RID: 1054 RVA: 0x0000D4E0 File Offset: 0x0000B6E0
	public static void SetControllerFace(ControllerDevice.ControlScheme scheme)
	{
		if (!true)
		{
		}
	}

	// Token: 0x0600041F RID: 1055 RVA: 0x0000D4F0 File Offset: 0x0000B6F0
	public static void Draw()
	{
	}

	// Token: 0x06000420 RID: 1056 RVA: 0x0000D574 File Offset: 0x0000B774
	public static void Close()
	{
		if (!true)
		{
		}
	}

	// Token: 0x06000421 RID: 1057 RVA: 0x0000D584 File Offset: 0x0000B784
	public static void UpdateAndSaveCurrentProfile()
	{
		int num = 1;
		if (num == 0)
		{
		}
		while (num == 0)
		{
		}
	}

	// Token: 0x06000422 RID: 1058 RVA: 0x0000D5D0 File Offset: 0x0000B7D0
	private static void DrawMainButtons()
	{
		bool mouseLeft = Main.mouseLeft;
		bool mouseLeftRelease = Main.mouseLeftRelease;
		GUITransactionButton.InputState inputState;
		if (inputState != GUITransactionButton.InputState.Clicked)
		{
			if (!true)
			{
			}
			if (true)
			{
				goto IL_0042;
			}
			if (!true)
			{
			}
			bool keyUp = KeyboardInput.GetKeyUp(KeyCode.Escape);
		}
		if (!true)
		{
		}
		bool keyUp2 = KeyboardInput.GetKeyUp(KeyCode.Escape);
		GUIControllerHardwareProfile.UpdateAndSaveCurrentProfile();
		Main.mouseLeftRelease = false;
		GUIControllerHardwareProfile.Close();
		IL_0042:
		GUITransactionButton.InputState inputState2;
		if (inputState2 != GUITransactionButton.InputState.Clicked)
		{
			return;
		}
		if (!true)
		{
		}
		Main.mouseLeftRelease = false;
		if (!true)
		{
		}
		GUIControllerHardwareProfile.Close();
	}

	// Token: 0x06000423 RID: 1059 RVA: 0x0000D638 File Offset: 0x0000B838
	private static void DrawTitle()
	{
		string textValue = Language.GetTextValue("GameUI.HardwareProfileMenu");
	}

	// Token: 0x06000424 RID: 1060 RVA: 0x0000D660 File Offset: 0x0000B860
	private static void DrawBacking()
	{
	}

	// Token: 0x06000425 RID: 1061 RVA: 0x0000D670 File Offset: 0x0000B870
	private static void DrawCategoryOptions()
	{
	}

	// Token: 0x06000426 RID: 1062 RVA: 0x000021DB File Offset: 0x000003DB
	private static float SettingScale(int index)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000427 RID: 1063 RVA: 0x0000D688 File Offset: 0x0000B888
	private static void SettingOver(int index)
	{
	}

	// Token: 0x06000428 RID: 1064 RVA: 0x0000D698 File Offset: 0x0000B898
	private static void SettingDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
	}

	// Token: 0x06000429 RID: 1065 RVA: 0x000021DB File Offset: 0x000003DB
	private static Microsoft.Xna.Framework.Vector2 SettingSize(int index)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x0600042A RID: 1066 RVA: 0x0000D6A8 File Offset: 0x0000B8A8
	public static void Open(ControllerDevice device)
	{
		int num = 1;
		if (num == 0)
		{
		}
		if (device != null)
		{
			ControllerDevice.ControlScheme controls = device.Controls;
			if (num == 0)
			{
			}
			return;
		}
	}

	// Token: 0x0600042B RID: 1067 RVA: 0x0000D6CC File Offset: 0x0000B8CC
	public GUIControllerHardwareProfile()
	{
	}

	// Token: 0x0600042C RID: 1068 RVA: 0x0000D6E0 File Offset: 0x0000B8E0
	// Note: this type is marked as 'beforefieldinit'.
	static GUIControllerHardwareProfile()
	{
	}

	// Token: 0x040003FE RID: 1022
	private static GUIControllerMappingEntryBase overlayEntry;

	// Token: 0x040003FF RID: 1023
	private static Rectangle overlayRegion;

	// Token: 0x04000400 RID: 1024
	public static bool Enabled;

	// Token: 0x04000401 RID: 1025
	private static bool performingBinding;

	// Token: 0x04000402 RID: 1026
	private static float TimeSinceItemChange;

	// Token: 0x04000403 RID: 1027
	private static float GameplayButtonScale;

	// Token: 0x04000404 RID: 1028
	private static float UIButtonScale;

	// Token: 0x04000405 RID: 1029
	private static float SaveAndCloseButtonScale;

	// Token: 0x04000406 RID: 1030
	private static float ResetSettingsButtonScale;

	// Token: 0x04000407 RID: 1031
	private static float titleScale;

	// Token: 0x04000408 RID: 1032
	public static float ScrollOffset;

	// Token: 0x04000409 RID: 1033
	private static float ScrollMomentum;

	// Token: 0x0400040A RID: 1034
	private static int ScrollDragging;

	// Token: 0x0400040B RID: 1035
	private static Microsoft.Xna.Framework.Vector2 DragOffset;

	// Token: 0x0400040C RID: 1036
	public static List<GUIControllerMappingEntryBase> _categorySettings;

	// Token: 0x0400040D RID: 1037
	private static bool hasFocus;

	// Token: 0x0400040E RID: 1038
	private static GUIInputRegionExclusive _categoriesBlocker;

	// Token: 0x0400040F RID: 1039
	public static ControllerDevice.ControlScheme ActiveScheme;

	// Token: 0x04000410 RID: 1040
	public static ControllerDevice CurrentDevice;
}
