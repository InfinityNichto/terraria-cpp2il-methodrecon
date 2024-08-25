using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200017A RID: 378
	[Preserve]
	[NativeInputDeviceProfile]
	public class MicrosoftXbox360ControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000781 RID: 1921 RVA: 0x00022460 File Offset: 0x00020660
		public override void Define()
		{
			base.Define();
			this.deviceName = "Microsoft Xbox 360 Controller";
			this.deviceNotes = "Microsoft Xbox 360 Controller on Mac";
			OptionalUInt16 optionalUInt = 1118;
			OptionalUInt16 optionalUInt2 = 654;
			OptionalUInt16 optionalUInt3 = 1118;
			OptionalUInt16 optionalUInt4 = 655;
			OptionalUInt16 optionalUInt5 = 3695;
			OptionalUInt16 optionalUInt6 = 307;
			OptionalUInt16 optionalUInt7 = 3695;
			OptionalUInt16 optionalUInt8 = 63233;
			OptionalUInt16 optionalUInt9 = 3695;
			OptionalUInt16 optionalUInt10 = 672;
			OptionalUInt16 optionalUInt11 = 3695;
			OptionalUInt16 optionalUInt12 = 62721;
			OptionalUInt16 optionalUInt13 = 1118;
			OptionalUInt16 optionalUInt14 = 672;
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x00022530 File Offset: 0x00020730
		public MicrosoftXbox360ControllerMacNativeProfile()
		{
		}
	}
}
