using System;
using Controller;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;

// Token: 0x0200016D RID: 365
public class GUIReturnToTouch
{
	// Token: 0x06000A51 RID: 2641 RVA: 0x00031764 File Offset: 0x0002F964
	private bool IsOverPanel(Vector2 cursorPosition)
	{
		return this.displayPopup;
	}

	// Token: 0x06000A52 RID: 2642 RVA: 0x00031778 File Offset: 0x0002F978
	public void Draw(bool inBatch = false)
	{
		int num = 1;
		if (num == 0)
		{
		}
		XNAUnityRunner.ForcedInputMode primaryInputMode = XNAUnityRunner.PrimaryInputMode;
		if (num == 0)
		{
		}
		bool controllerModeLocked = XNAUnityRunner.ControllerModeLocked;
		if (num == 0)
		{
		}
		bool keyboardModeLocked = XNAUnityRunner.KeyboardModeLocked;
		GUIControllerModalResponse controller = this._controller;
		bool flag = this.displayPopup;
		bool flag2;
		int num2;
		if (flag)
		{
			if (!flag)
			{
			}
			Main.FlushBatches();
			if (!flag)
			{
			}
			Settings_Layout instance = Settings_Layout.Instance;
			if (this._displayBlocker != null)
			{
			}
			Panel_Layout returnTouch_Backing = instance.ReturnTouch_Backing;
			Panel_Layout returnTouch_MenuDivider = instance.ReturnTouch_MenuDivider;
			GUIControllerModalResponse controller2 = this._controller;
			String_Layout returnTouch_Prompt = instance.ReturnTouch_Prompt;
			string textValue = Language.GetTextValue("Mobile.ReturnTouchPrompt");
			if (controller == null)
			{
			}
			GUIString.Draw(returnTouch_Prompt, textValue);
			TransactionButton_Layout returnTouch_Accept = instance.ReturnTouch_Accept;
			string textValue2 = Language.GetTextValue("Mobile.ReturnTouchAccept");
			TransactionButton_Layout returnTouch_Cancel = instance.ReturnTouch_Cancel;
			if (controller == null)
			{
			}
			if (controller == null)
			{
			}
			bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
			GUITransactionButton.InputState inputState;
			if (inputState != GUITransactionButton.InputState.Clicked)
			{
				return;
			}
			GUIControllerModalResponse controller3 = this._controller;
			XNAUnityRunner.MobileControllerLocked = false;
			XNAUnityRunner.MobileKeyboardLocked = false;
			GUIControllerModalResponse controller4 = this._controller;
			GUIInputRegionExclusive displayBlocker = this._displayBlocker;
			if (displayBlocker != null)
			{
				flag2 = this.displayPopup;
				displayBlocker.Active = flag2;
			}
			if (displayBlocker == null)
			{
			}
			Main.FlushBatches();
			if (displayBlocker == null)
			{
			}
			num2 = 1;
		}
		if (num2 == 0)
		{
		}
		bool controllerModeLocked2 = XNAUnityRunner.ControllerModeLocked;
		if (num2 == 0)
		{
		}
		bool keyboardModeLocked2 = XNAUnityRunner.KeyboardModeLocked;
		if (num2 == 0)
		{
		}
		bool gameMenu = Main.gameMenu;
		if (!flag2)
		{
			return;
		}
		TransactionButton_Layout returnTouch_Menu = Settings_Layout.Instance.ReturnTouch_Menu;
		Main.FlushBatches();
		GUITransactionButton.InputState inputState2;
		if (inputState2 == GUITransactionButton.InputState.Clicked && !this.displayPopup)
		{
			int num3 = 1;
			this.displayPopup = num3 != 0;
			GUIInputRegionExclusive guiinputRegionExclusive;
			if (this._displayBlocker == null)
			{
				this._displayBlocker = guiinputRegionExclusive;
			}
			bool flag3 = this.displayPopup;
			guiinputRegionExclusive.Active = flag3;
			this._controller.Activate();
		}
		Main.FlushBatches();
	}

	// Token: 0x1700010C RID: 268
	// (get) Token: 0x06000A53 RID: 2643 RVA: 0x00031950 File Offset: 0x0002FB50
	public bool Visible
	{
		get
		{
			if (!true)
			{
			}
			XNAUnityRunner.ForcedInputMode primaryInputMode = XNAUnityRunner.PrimaryInputMode;
			if (!true)
			{
			}
			bool controllerModeLocked = XNAUnityRunner.ControllerModeLocked;
			if (!true)
			{
			}
			bool keyboardModeLocked = XNAUnityRunner.KeyboardModeLocked;
			return true;
		}
	}

	// Token: 0x06000A54 RID: 2644 RVA: 0x00031984 File Offset: 0x0002FB84
	public void DrawHUD()
	{
		XNAUnityRunner.ForcedInputMode primaryInputMode = XNAUnityRunner.PrimaryInputMode;
		bool controllerModeLocked = XNAUnityRunner.ControllerModeLocked;
		bool keyboardModeLocked = XNAUnityRunner.KeyboardModeLocked;
		TransactionButton_Layout returnTouch_HUD = Settings_Layout.Instance.ReturnTouch_HUD;
		GUITransactionButton.InputState inputState;
		if (inputState != GUITransactionButton.InputState.Clicked || this.displayPopup)
		{
			return;
		}
		int num = 1;
		this.displayPopup = num != 0;
		GUIInputRegionExclusive guiinputRegionExclusive;
		if (this._displayBlocker == null)
		{
			this._displayBlocker = guiinputRegionExclusive;
		}
		bool flag = this.displayPopup;
		guiinputRegionExclusive.Active = flag;
		this._controller.Activate();
	}

	// Token: 0x06000A55 RID: 2645 RVA: 0x00031A04 File Offset: 0x0002FC04
	public GUIReturnToTouch()
	{
	}

	// Token: 0x04000A32 RID: 2610
	public bool displayPopup;

	// Token: 0x04000A33 RID: 2611
	private GUIInputRegionExclusive _displayBlocker;

	// Token: 0x04000A34 RID: 2612
	private float scale;

	// Token: 0x04000A35 RID: 2613
	private GUIControllerModalResponse _controller;

	// Token: 0x04000A36 RID: 2614
	private GUIControllerItem _previous;
}
