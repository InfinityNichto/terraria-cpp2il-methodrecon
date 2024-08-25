using System;
using UnityEngine;

namespace InControl
{
	// Token: 0x0200002F RID: 47
	public enum InputDeviceDriverType : ushort
	{
		// Token: 0x0400023C RID: 572
		Unknown,
		// Token: 0x0400023D RID: 573
		HID,
		// Token: 0x0400023E RID: 574
		USB,
		// Token: 0x0400023F RID: 575
		Bluetooth,
		// Token: 0x04000240 RID: 576
		[InspectorName("XInput")]
		XInput,
		// Token: 0x04000241 RID: 577
		[InspectorName("DirectInput")]
		DirectInput,
		// Token: 0x04000242 RID: 578
		[InspectorName("RawInput")]
		RawInput
	}
}
