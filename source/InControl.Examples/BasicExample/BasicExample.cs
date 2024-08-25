using System;
using InControl;
using UnityEngine;

namespace BasicExample
{
	// Token: 0x02000010 RID: 16
	public class BasicExample : MonoBehaviour
	{
		// Token: 0x06000052 RID: 82 RVA: 0x00003228 File Offset: 0x00001428
		private void Update()
		{
			if (!true)
			{
			}
			InputDevice activeDevice = InputManager.ActiveDevice;
			Transform transform = base.transform;
			float deltaTime = Time.deltaTime;
			float num = activeDevice.LeftStickX;
			Transform transform2 = base.transform;
			float deltaTime2 = Time.deltaTime;
			float num2 = activeDevice.LeftStickY;
			bool isPressed = activeDevice.Action1.IsPressed;
			bool isPressed2 = activeDevice.Action2.IsPressed;
			Material material = base.GetComponent<Renderer>().material;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000032A4 File Offset: 0x000014A4
		public BasicExample()
		{
		}
	}
}
