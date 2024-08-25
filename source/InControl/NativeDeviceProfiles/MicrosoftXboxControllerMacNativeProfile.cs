using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200017B RID: 379
	[NativeInputDeviceProfile]
	[Preserve]
	public class MicrosoftXboxControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000783 RID: 1923 RVA: 0x00022544 File Offset: 0x00020744
		public override void Define()
		{
			base.Define();
			this.deviceName = "Microsoft Xbox Controller";
			this.deviceNotes = "Microsoft Xbox Controller on Mac";
			OptionalUInt16 optionalUInt = ushort.MaxValue;
			OptionalUInt16 optionalUInt2 = ushort.MaxValue;
			OptionalUInt16 optionalUInt3 = 1118;
			OptionalUInt16 optionalUInt4 = 649;
			OptionalUInt16 optionalUInt5 = 1118;
			OptionalUInt16 optionalUInt6 = 648;
			OptionalUInt16 optionalUInt7 = 1118;
			OptionalUInt16 optionalUInt8 = 645;
			OptionalUInt16 optionalUInt9 = 1118;
			OptionalUInt16 optionalUInt10 = 514;
			OptionalUInt16 optionalUInt11 = 1118;
			OptionalUInt16 optionalUInt12 = 647;
			OptionalUInt16 optionalUInt13 = 1118;
			OptionalUInt16 optionalUInt14 = 648;
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x00022614 File Offset: 0x00020814
		public MicrosoftXboxControllerMacNativeProfile()
		{
		}
	}
}
