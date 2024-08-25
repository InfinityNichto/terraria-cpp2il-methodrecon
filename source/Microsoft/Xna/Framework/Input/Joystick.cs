using System;

namespace Microsoft.Xna.Framework.Input
{
	// Token: 0x0200034C RID: 844
	public static class Joystick
	{
		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06001598 RID: 5528 RVA: 0x00060C54 File Offset: 0x0005EE54
		public static bool IsSupported
		{
			get
			{
			}
		}

		// Token: 0x06001599 RID: 5529 RVA: 0x00060C64 File Offset: 0x0005EE64
		public static JoystickCapabilities GetCapabilities(int index)
		{
			JoystickCapabilities joystickCapabilities;
			return joystickCapabilities;
		}

		// Token: 0x0600159A RID: 5530 RVA: 0x00060C74 File Offset: 0x0005EE74
		public static JoystickState GetState(int index)
		{
			JoystickState joystickState = Joystick.PlatformGetState(index);
			JoystickState joystickState2;
			return joystickState2;
		}

		// Token: 0x0600159B RID: 5531 RVA: 0x00060C8C File Offset: 0x0005EE8C
		private static JoystickCapabilities PlatformGetCapabilities(int index)
		{
			JoystickCapabilities joystickCapabilities;
			return joystickCapabilities;
		}

		// Token: 0x0600159C RID: 5532 RVA: 0x00060C9C File Offset: 0x0005EE9C
		private static JoystickState PlatformGetState(int index)
		{
		}

		// Token: 0x04002323 RID: 8995
		private const bool PlatformIsSupported = false;
	}
}
