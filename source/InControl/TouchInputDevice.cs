using System;

namespace InControl
{
	// Token: 0x02000052 RID: 82
	public class TouchInputDevice : InputDevice
	{
		// Token: 0x060003D1 RID: 977 RVA: 0x0000CBA8 File Offset: 0x0000ADA8
		public TouchInputDevice()
		{
			if (!true)
			{
			}
			base..ctor("Touch Input Device", true);
			this.<DeviceClass>k__BackingField = InputDeviceClass.TouchScreen;
		}
	}
}
