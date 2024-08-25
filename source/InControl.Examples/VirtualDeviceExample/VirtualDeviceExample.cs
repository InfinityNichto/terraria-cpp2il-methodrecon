using System;
using System.Runtime.CompilerServices;
using InControl;
using UnityEngine;

namespace VirtualDeviceExample
{
	// Token: 0x02000003 RID: 3
	public class VirtualDeviceExample : MonoBehaviour
	{
		// Token: 0x06000008 RID: 8 RVA: 0x000022A4 File Offset: 0x000004A4
		private void OnEnable()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000022B4 File Offset: 0x000004B4
		private void OnDisable()
		{
			VirtualDevice virtualDevice = this.virtualDevice;
			if (!true)
			{
			}
			InputManager.DetachDevice(virtualDevice);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000022D4 File Offset: 0x000004D4
		private void Update()
		{
			if (!true)
			{
			}
			InputDevice activeDevice = InputManager.ActiveDevice;
			Transform transform = this.leftObject.transform;
			float deltaTime = Time.deltaTime;
			float num = activeDevice.LeftStickX;
			Transform transform2 = this.leftObject.transform;
			float deltaTime2 = Time.deltaTime;
			float num2 = activeDevice.LeftStickY;
			Transform transform3 = this.rightObject.transform;
			float deltaTime3 = Time.deltaTime;
			float num3 = activeDevice.RightStickX;
			Transform transform4 = this.rightObject.transform;
			float deltaTime4 = Time.deltaTime;
			float num4 = activeDevice.RightStickY;
			bool isPressed = activeDevice.Action1.IsPressed;
			bool isPressed2 = activeDevice.Action2.IsPressed;
			bool isPressed3 = activeDevice.Action3.IsPressed;
			bool isPressed4 = activeDevice.Action4.IsPressed;
			Material material = this.leftObject.GetComponent<Renderer>().material;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000023C0 File Offset: 0x000005C0
		public VirtualDeviceExample()
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000023D4 File Offset: 0x000005D4
		[CompilerGenerated]
		private void <OnEnable>b__3_0()
		{
			VirtualDevice virtualDevice = this.virtualDevice;
			if (!true)
			{
			}
			InputManager.AttachDevice(virtualDevice);
		}

		// Token: 0x04000007 RID: 7
		public GameObject leftObject;

		// Token: 0x04000008 RID: 8
		public GameObject rightObject;

		// Token: 0x04000009 RID: 9
		private VirtualDevice virtualDevice;
	}
}
