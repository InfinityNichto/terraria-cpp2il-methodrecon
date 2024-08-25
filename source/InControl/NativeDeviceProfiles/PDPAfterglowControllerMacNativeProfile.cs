using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000182 RID: 386
	[NativeInputDeviceProfile]
	[Preserve]
	public class PDPAfterglowControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000791 RID: 1937 RVA: 0x000227A8 File Offset: 0x000209A8
		public override void Define()
		{
			base.Define();
			this.deviceName = "PDP Afterglow Controller";
			this.deviceNotes = "PDP Afterglow Controller on Mac";
			OptionalUInt16 optionalUInt = 9414;
			OptionalUInt16 optionalUInt2 = 64252;
			OptionalUInt16 optionalUInt3 = 7085;
			OptionalUInt16 optionalUInt4 = 63751;
			OptionalUInt16 optionalUInt5 = 64253;
			OptionalUInt16 optionalUInt6 = 1118;
			OptionalUInt16 optionalUInt7 = 742;
			OptionalUInt16 optionalUInt8 = 7085;
			OptionalUInt16 optionalUInt9 = 768;
			OptionalUInt16 optionalUInt10 = 9414;
			OptionalUInt16 optionalUInt11 = 22554;
			OptionalUInt16 optionalUInt12 = 3695;
			OptionalUInt16 optionalUInt13 = 1043;
			OptionalUInt16 optionalUInt14 = 7085;
			OptionalUInt16 optionalUInt15 = 63744;
			OptionalUInt16 optionalUInt16 = 3695;
			OptionalUInt16 optionalUInt17 = 63744;
			OptionalUInt16 optionalUInt18 = 3695;
			OptionalUInt16 optionalUInt19 = 275;
			OptionalUInt16 optionalUInt20 = 3695;
			OptionalUInt16 optionalUInt21 = 531;
			OptionalUInt16 optionalUInt22 = 4779;
			OptionalUInt16 optionalUInt23 = 769;
			OptionalUInt16 optionalUInt24 = 3695;
			OptionalUInt16 optionalUInt25 = 4371;
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x00022900 File Offset: 0x00020B00
		public PDPAfterglowControllerMacNativeProfile()
		{
		}
	}
}
