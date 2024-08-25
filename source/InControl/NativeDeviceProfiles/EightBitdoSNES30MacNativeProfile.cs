using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001B4 RID: 436
	[NativeInputDeviceProfile]
	[Preserve]
	public class EightBitdoSNES30MacNativeProfile : InputDeviceProfile
	{
		// Token: 0x060007F5 RID: 2037 RVA: 0x00023984 File Offset: 0x00021B84
		public override void Define()
		{
			base.Define();
			this.deviceName = "8Bitdo SNES30 Controller";
			this.deviceNotes = "8Bitdo SNES30 Controller on Mac";
			if ("OS X" == null || "OS X" != null)
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x00023A24 File Offset: 0x00021C24
		public EightBitdoSNES30MacNativeProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
