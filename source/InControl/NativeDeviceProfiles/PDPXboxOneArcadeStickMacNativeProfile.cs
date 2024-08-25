using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200018B RID: 395
	[Preserve]
	[NativeInputDeviceProfile]
	public class PDPXboxOneArcadeStickMacNativeProfile : XboxOneDriverMacNativeProfile
	{
		// Token: 0x060007A3 RID: 1955 RVA: 0x00022B0C File Offset: 0x00020D0C
		public override void Define()
		{
			base.Define();
			this.deviceName = "PDP Xbox One Arcade Stick";
			this.deviceNotes = "PDP Xbox One Arcade Stick on Mac";
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x00022B38 File Offset: 0x00020D38
		public PDPXboxOneArcadeStickMacNativeProfile()
		{
		}
	}
}
