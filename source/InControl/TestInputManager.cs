using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000072 RID: 114
	public class TestInputManager : MonoBehaviour
	{
		// Token: 0x06000556 RID: 1366 RVA: 0x00010508 File Offset: 0x0000E708
		private void OnEnable()
		{
			Application.targetFrameRate = 42198032;
			QualitySettings.vSyncCount = 0;
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00010530 File Offset: 0x0000E730
		private void HandleInputUpdate(ulong updateTick, float deltaTime)
		{
			int num = 1;
			this.CheckForPauseButton();
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			InputControl inputControl;
			float num2 = inputControl;
			InputControl inputControl2;
			float num3 = inputControl2;
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00010560 File Offset: 0x0000E760
		private void Start()
		{
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x00010570 File Offset: 0x0000E770
		private void Update()
		{
			bool keyDown = Input.GetKeyDown(KeyCode.R);
			Utility.LoadScene("TestInputManager");
			bool keyDown2 = Input.GetKeyDown(KeyCode.E);
			if (!true)
			{
			}
			InputManager.Enabled = false;
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x000105A4 File Offset: 0x0000E7A4
		private void CheckForPauseButton()
		{
			bool keyDown = Input.GetKeyDown(KeyCode.P);
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (true)
			{
				bool flag = this.isPaused;
				bool flag2 = this.isPaused;
				this.isPaused = flag2;
			}
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x000105DC File Offset: 0x0000E7DC
		private void SetColor(Color color)
		{
			GUIStyleState normal = this.style.normal;
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x000105F8 File Offset: 0x0000E7F8
		private void OnGUI()
		{
			int width = Screen.width;
			GUISkin skin = GUI.skin;
			int num = 1;
			if (num == 0)
			{
			}
			TwoAxisInputControl direction = InputManager.ActiveDevice.Direction;
			string text2;
			string text3;
			string text = text2 + " " + text3;
			if (num != 0)
			{
				return;
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00010A3C File Offset: 0x0000EC3C
		private void DrawUnityInputDebugger()
		{
			int width = Screen.width;
			string[] joystickNames = Input.GetJoystickNames();
			string text;
			if (("Joystick " == null || "Joystick " != null) && (text == null || text != null) && (": \"" == null || ": \"" != null) && ": \"" != null)
			{
				string text2;
				string text3;
				bool key = Input.GetKey("joystick " + text2 + " button " + text3);
				string text5;
				string text4 = "Buttons: " + "B" + text5 + "  ";
				string text6;
				string text7;
				float axisRaw = Input.GetAxisRaw("joystick " + text6 + " analog " + text7);
				if ("joystick " == null)
				{
				}
				string text8;
				string text9;
				if (("Analogs: " == null || "Analogs: " != null) && ("A" == null || "A" != null) && (text8 == null || text8 != null) && (": " == null || ": " != null) && (text9 == null || text9 != null) && ("  " == null || "  " != null))
				{
					return;
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00010B3C File Offset: 0x0000ED3C
		private void OnDrawGizmos()
		{
			if (!true)
			{
			}
			InputDevice activeDevice = InputManager.ActiveDevice;
			TwoAxisInputControl direction = activeDevice.Direction;
			TwoAxisInputControl <RightStick>k__BackingField = activeDevice.<RightStick>k__BackingField;
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00010B7C File Offset: 0x0000ED7C
		public TestInputManager()
		{
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x000025E1 File Offset: 0x000007E1
		[CompilerGenerated]
		private void <OnEnable>b__4_0(LogMessage logMessage)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x04000401 RID: 1025
		public Font font;

		// Token: 0x04000402 RID: 1026
		private readonly GUIStyle style;

		// Token: 0x04000403 RID: 1027
		private readonly List<LogMessage> logMessages;

		// Token: 0x04000404 RID: 1028
		private bool isPaused;

		// Token: 0x02000073 RID: 115
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000561 RID: 1377 RVA: 0x00010B90 File Offset: 0x0000ED90
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06000562 RID: 1378 RVA: 0x00010BA0 File Offset: 0x0000EDA0
			public <>c()
			{
			}

			// Token: 0x06000563 RID: 1379 RVA: 0x00010BB4 File Offset: 0x0000EDB4
			internal void <OnEnable>b__4_1(InputDevice inputDevice)
			{
				string <Name>k__BackingField = inputDevice.<Name>k__BackingField;
				Debug.Log("Attached: " + <Name>k__BackingField);
			}

			// Token: 0x06000564 RID: 1380 RVA: 0x00010BD8 File Offset: 0x0000EDD8
			internal void <OnEnable>b__4_2(InputDevice inputDevice)
			{
				string <Name>k__BackingField = inputDevice.<Name>k__BackingField;
				Debug.Log("Detached: " + <Name>k__BackingField);
			}

			// Token: 0x06000565 RID: 1381 RVA: 0x00010BFC File Offset: 0x0000EDFC
			internal void <OnEnable>b__4_3(InputDevice inputDevice)
			{
				string <Name>k__BackingField = inputDevice.<Name>k__BackingField;
				Debug.Log("Active device changed to: " + <Name>k__BackingField);
			}

			// Token: 0x04000405 RID: 1029
			public static readonly TestInputManager.<>c <>9;

			// Token: 0x04000406 RID: 1030
			public static Action<InputDevice> <>9__4_1;

			// Token: 0x04000407 RID: 1031
			public static Action<InputDevice> <>9__4_2;

			// Token: 0x04000408 RID: 1032
			public static Action<InputDevice> <>9__4_3;
		}
	}
}
