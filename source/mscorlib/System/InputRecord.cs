using System;

namespace System
{
	// Token: 0x020001A6 RID: 422
	internal struct InputRecord
	{
		// Token: 0x040008AC RID: 2220
		public short EventType;

		// Token: 0x040008AD RID: 2221
		public bool KeyDown;

		// Token: 0x040008AE RID: 2222
		public short RepeatCount;

		// Token: 0x040008AF RID: 2223
		public short VirtualKeyCode;

		// Token: 0x040008B0 RID: 2224
		public short VirtualScanCode;

		// Token: 0x040008B1 RID: 2225
		public char Character;

		// Token: 0x040008B2 RID: 2226
		public int ControlKeyState;

		// Token: 0x040008B3 RID: 2227
		private int pad1;

		// Token: 0x040008B4 RID: 2228
		private bool pad2;
	}
}
