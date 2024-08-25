using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000184 RID: 388
	[NativeInputDeviceProfile]
	[Preserve]
	public class PDPBattlefieldXBoxOneControllerMacNativeProfile : XboxOneDriverMacNativeProfile
	{
		// Token: 0x06000795 RID: 1941 RVA: 0x00022954 File Offset: 0x00020B54
		public override void Define()
		{
			base.Define();
			this.deviceName = "PDP Battlefield XBox One Controller";
			this.deviceNotes = "PDP Battlefield XBox One Controller on Mac";
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x00022980 File Offset: 0x00020B80
		public PDPBattlefieldXBoxOneControllerMacNativeProfile()
		{
		}
	}
}
