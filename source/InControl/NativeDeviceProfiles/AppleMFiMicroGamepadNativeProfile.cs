using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001C4 RID: 452
	[NativeInputDeviceProfile]
	[Preserve]
	public class AppleMFiMicroGamepadNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000815 RID: 2069 RVA: 0x00024D18 File Offset: 0x00022F18
		public override void Define()
		{
			base.Define();
			this.deviceName = "{NAME} MFi Controller";
			this.deviceNotes = "MFi Controller on iOS / tvOS";
			if (("iOS" == null || "iOS" != null) && ("tvOS" == null || "tvOS" != null) && ("iPhone" == null || "iPhone" != null) && ("iPad" == null || "iPad" != null) && ("AppleTV" == null || "AppleTV" != null) && ("OS X" == null || "OS X" != null))
			{
				OptionalUInt16 optionalUInt = 0;
				OptionalUInt32 optionalUInt2 = (uint)1;
				if ("A" == null)
				{
				}
				InputControlSource inputControlSource = InputDeviceProfile.Button(0);
				InputControlSource inputControlSource2 = InputDeviceProfile.Button(1);
				InputControlSource inputControlSource3 = InputDeviceProfile.Button(2);
				InputControlSource inputControlSource4 = InputDeviceProfile.Button(3);
				InputControlSource inputControlSource5 = InputDeviceProfile.Button(4);
				InputControlSource inputControlSource6 = InputDeviceProfile.Button(5);
				InputControlSource inputControlSource7 = InputDeviceProfile.Button(6);
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x00024DF4 File Offset: 0x00022FF4
		public AppleMFiMicroGamepadNativeProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
