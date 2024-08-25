using System;
using InControl;
using UnityEngine;

namespace InterfaceMovement
{
	// Token: 0x0200000C RID: 12
	public class ButtonManager : MonoBehaviour
	{
		// Token: 0x0600003E RID: 62 RVA: 0x00002D70 File Offset: 0x00000F70
		private void Awake()
		{
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002D80 File Offset: 0x00000F80
		private void Update()
		{
			if (!true)
			{
			}
			InputDevice activeDevice = InputManager.ActiveDevice;
			TwoAxisInputControl twoAxisInputControl = this.filteredDirection;
			TwoAxisInputControl direction = activeDevice.Direction;
			float deltaTime = Time.deltaTime;
			twoAxisInputControl.Filter(direction, deltaTime);
			bool wasRepeated = this.filteredDirection.<Left>k__BackingField.WasRepeated;
			bool wasPressed = this.filteredDirection.<Up>k__BackingField.WasPressed;
			Button up = this.focusedButton.up;
			this.MoveFocusTo(up);
			bool wasPressed2 = this.filteredDirection.<Down>k__BackingField.WasPressed;
			Button down = this.focusedButton.down;
			this.MoveFocusTo(down);
			bool wasPressed3 = this.filteredDirection.<Left>k__BackingField.WasPressed;
			Button left = this.focusedButton.left;
			this.MoveFocusTo(left);
			bool wasPressed4 = this.filteredDirection.<Right>k__BackingField.WasPressed;
			Button right = this.focusedButton.right;
			this.MoveFocusTo(right);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002E68 File Offset: 0x00001068
		private void MoveFocusTo(Button newFocusedButton)
		{
			if (!true)
			{
			}
			bool flag = newFocusedButton != newFocusedButton;
			this.focusedButton = newFocusedButton;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002E88 File Offset: 0x00001088
		public ButtonManager()
		{
		}

		// Token: 0x04000027 RID: 39
		public Button focusedButton;

		// Token: 0x04000028 RID: 40
		private TwoAxisInputControl filteredDirection;
	}
}
